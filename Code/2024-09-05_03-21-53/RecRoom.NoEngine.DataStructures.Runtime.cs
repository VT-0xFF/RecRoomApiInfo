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
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C7D960", Offset = "0x6C7C360", VA = "0x186C7D960")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AEC90", Offset = "0x8AD690", VA = "0x1808AEC90")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AECD0", Offset = "0x8AD6D0", VA = "0x1808AECD0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class BCKNLICLHBF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	protected BCKNLICLHBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class KFLOFHPPFJP<T> : BCKNLICLHBF
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct IMICIOCKEIK
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum IHBGCEEAKHP
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
		public IHBGCEEAKHP NNCMOPPBEEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T ENNGIICFMFD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int DGBGBCJBBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool POHGNPEHDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool OEFFPLKHHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? NJOMEFANCFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<IMICIOCKEIK>? JNOLODDDJIK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool KFBIBEBHJEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x433F870", Offset = "0x433E270", VA = "0x18433F870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x43400C0", Offset = "0x433EAC0", VA = "0x1843400C0")]
	protected KFLOFHPPFJP(bool OEFFPLKHHLB, bool POHGNPEHDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4340020", Offset = "0x433EA20", VA = "0x184340020")]
	protected bool PKGAALPBCBP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x433FF00", Offset = "0x433E900", VA = "0x18433FF00")]
	protected void PHJBCLFFCDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x433F8E0", Offset = "0x433E2E0", VA = "0x18433F8E0")]
	protected void FEEKAFIJBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2C9C7C0", Offset = "0x2C9B1C0", VA = "0x182C9C7C0")]
	private static void DACEJIJJDMG<U>(List<U>? JNHGBAGBHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x433F660", Offset = "0x433E060", VA = "0x18433F660", Slot = "4")]
	public void EGHPKMGPEOO(T ENNGIICFMFD, bool FOGHLMPLBIL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x433FD30", Offset = "0x433E730", VA = "0x18433FD30", Slot = "5")]
	public void MIOFMOMIMDC(T ENNGIICFMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x433FB80", Offset = "0x433E580", VA = "0x18433FB80")]
	public void IMAFILHGCCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class PLAJPLAPENK : KFLOFHPPFJP<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6C7E1B0", Offset = "0x6C7CBB0", VA = "0x186C7E1B0")]
	public PLAJPLAPENK(bool OEFFPLKHHLB = false, bool POHGNPEHDLM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6C7DF50", Offset = "0x6C7C950", VA = "0x186C7DF50")]
	public void NPIHGHHDKCM()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6C7DEF0", Offset = "0x6C7C8F0", VA = "0x186C7DEF0")]
	public static PLAJPLAPENK FFIEFDCOBEF(PLAJPLAPENK DOALHPNAKLE, Action ENNGIICFMFD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6C7E150", Offset = "0x6C7CB50", VA = "0x186C7E150")]
	public static PLAJPLAPENK PCFAOMELEBG(PLAJPLAPENK DOALHPNAKLE, Action ENNGIICFMFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FNKNKJIHBHA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EGHPKMGPEOO(Action<T> ENNGIICFMFD, bool FOGHLMPLBIL = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MIOFMOMIMDC(Action<T> ENNGIICFMFD);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class HLIGJNPKABP<T> : KFLOFHPPFJP<Action<T>>, FNKNKJIHBHA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3D69040", Offset = "0x3D67A40", VA = "0x183D69040")]
	public HLIGJNPKABP(bool OEFFPLKHHLB = false, bool POHGNPEHDLM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3EECDD0", Offset = "0x3EEB7D0", VA = "0x183EECDD0")]
	public void NPIHGHHDKCM(T LJDCGGEFKLJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3D68760", Offset = "0x3D67160", VA = "0x183D68760")]
	public static HLIGJNPKABP<T> FFIEFDCOBEF(HLIGJNPKABP<T> DOALHPNAKLE, Action<T> ENNGIICFMFD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3D68FA0", Offset = "0x3D679A0", VA = "0x183D68FA0")]
	public static HLIGJNPKABP<T> PCFAOMELEBG(HLIGJNPKABP<T> DOALHPNAKLE, Action<T> ENNGIICFMFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PHKEJBLMJAK<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class CBNFOEOMDIA<T, U> : KFLOFHPPFJP<Action<T, U>>, PHKEJBLMJAK<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3D69040", Offset = "0x3D67A40", VA = "0x183D69040")]
	public CBNFOEOMDIA(bool OEFFPLKHHLB = false, bool POHGNPEHDLM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5114A90", Offset = "0x5113490", VA = "0x185114A90")]
	public void NPIHGHHDKCM(T LJDCGGEFKLJ, U BJJFOJNCJFN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3D68760", Offset = "0x3D67160", VA = "0x183D68760")]
	public static CBNFOEOMDIA<T, U> FFIEFDCOBEF(CBNFOEOMDIA<T, U> DOALHPNAKLE, Action<T, U> ENNGIICFMFD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3D68FA0", Offset = "0x3D679A0", VA = "0x183D68FA0")]
	public static CBNFOEOMDIA<T, U> PCFAOMELEBG(CBNFOEOMDIA<T, U> DOALHPNAKLE, Action<T, U> ENNGIICFMFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class GOBDLGEBCLJ<T, U, V> : KFLOFHPPFJP<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3D69040", Offset = "0x3D67A40", VA = "0x183D69040")]
	public GOBDLGEBCLJ(bool OEFFPLKHHLB = false, bool POHGNPEHDLM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3E423A0", Offset = "0x3E40DA0", VA = "0x183E423A0")]
	public void NPIHGHHDKCM(T LJDCGGEFKLJ, U BJJFOJNCJFN, V OEHMKJHGMIJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3D68760", Offset = "0x3D67160", VA = "0x183D68760")]
	public static GOBDLGEBCLJ<T, U, V> FFIEFDCOBEF(GOBDLGEBCLJ<T, U, V> DOALHPNAKLE, Action<T, U, V> ENNGIICFMFD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3D68FA0", Offset = "0x3D679A0", VA = "0x183D68FA0")]
	public static GOBDLGEBCLJ<T, U, V> PCFAOMELEBG(GOBDLGEBCLJ<T, U, V> DOALHPNAKLE, Action<T, U, V> ENNGIICFMFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KFAENFENGKN<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class BEIEPHBJLFA<T, U, V, W> : KFLOFHPPFJP<Action<T, U, V, W>>, KFAENFENGKN<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3D69040", Offset = "0x3D67A40", VA = "0x183D69040")]
	public BEIEPHBJLFA(bool OEFFPLKHHLB = false, bool POHGNPEHDLM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5005970", Offset = "0x5004370", VA = "0x185005970")]
	public void NPIHGHHDKCM(T LJDCGGEFKLJ, U BJJFOJNCJFN, V OEHMKJHGMIJ, W MNEICOIJGBO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3D68760", Offset = "0x3D67160", VA = "0x183D68760")]
	public static BEIEPHBJLFA<T, U, V, W> FFIEFDCOBEF(BEIEPHBJLFA<T, U, V, W> DOALHPNAKLE, Action<T, U, V, W> ENNGIICFMFD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3D68FA0", Offset = "0x3D679A0", VA = "0x183D68FA0")]
	public static BEIEPHBJLFA<T, U, V, W> PCFAOMELEBG(BEIEPHBJLFA<T, U, V, W> DOALHPNAKLE, Action<T, U, V, W> ENNGIICFMFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class FNKAIKCBOFM<T, U, V, W, X> : KFLOFHPPFJP<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3D69040", Offset = "0x3D67A40", VA = "0x183D69040")]
	public FNKAIKCBOFM(bool OEFFPLKHHLB = false, bool POHGNPEHDLM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3D68810", Offset = "0x3D67210", VA = "0x183D68810")]
	public void NPIHGHHDKCM(T LJDCGGEFKLJ, U BJJFOJNCJFN, V OEHMKJHGMIJ, W MNEICOIJGBO, X ICJCFEHCALD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3D68760", Offset = "0x3D67160", VA = "0x183D68760")]
	public static FNKAIKCBOFM<T, U, V, W, X> FFIEFDCOBEF(FNKAIKCBOFM<T, U, V, W, X> DOALHPNAKLE, Action<T, U, V, W, X> ENNGIICFMFD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3D68FA0", Offset = "0x3D679A0", VA = "0x183D68FA0")]
	public static FNKAIKCBOFM<T, U, V, W, X> PCFAOMELEBG(FNKAIKCBOFM<T, U, V, W, X> DOALHPNAKLE, Action<T, U, V, W, X> ENNGIICFMFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class OOIPECBBFPK<T, U, V, W, X, Y> : KFLOFHPPFJP<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3D69040", Offset = "0x3D67A40", VA = "0x183D69040")]
	public OOIPECBBFPK(bool OEFFPLKHHLB = false, bool POHGNPEHDLM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4863CE0", Offset = "0x48626E0", VA = "0x184863CE0")]
	public void NPIHGHHDKCM(T LJDCGGEFKLJ, U BJJFOJNCJFN, V OEHMKJHGMIJ, W MNEICOIJGBO, X ICJCFEHCALD, Y MPEFCGEJLMG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3D68760", Offset = "0x3D67160", VA = "0x183D68760")]
	public static OOIPECBBFPK<T, U, V, W, X, Y> FFIEFDCOBEF(OOIPECBBFPK<T, U, V, W, X, Y> DOALHPNAKLE, Action<T, U, V, W, X, Y> ENNGIICFMFD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3D68FA0", Offset = "0x3D679A0", VA = "0x183D68FA0")]
	public static OOIPECBBFPK<T, U, V, W, X, Y> PCFAOMELEBG(OOIPECBBFPK<T, U, V, W, X, Y> DOALHPNAKLE, Action<T, U, V, W, X, Y> ENNGIICFMFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class JDFNKMMMJIH<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CFBKFBIANBJ<TKey, TVal> CKGJNDKBBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> ENFDMJNKEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly CFBKFBIANBJ<TKey, TVal>.ILMIKKLPMBN? NHKHPOCLCGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int KKIMKMLDEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly CFBKFBIANBJ<TKey, TVal>.PDJGHOJMNGM? DMDPLLOBMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int OMMABDDOLAC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int CGBABGFLMMN
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4205550", Offset = "0x4203F50", VA = "0x184205550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int EGBHAHKNAMB
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8893F0", Offset = "0x887DF0", VA = "0x1808893F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4206420", Offset = "0x4204E20", VA = "0x184206420")]
	public JDFNKMMMJIH(int KKIMKMLDEAD, [Optional] CFBKFBIANBJ<TKey, TVal>.PDJGHOJMNGM? DMDPLLOBMGL, [Optional] IEqualityComparer<TKey>? DIMOFBDOFGL, [Optional] CFBKFBIANBJ<TKey, TVal>.ILMIKKLPMBN? NHKHPOCLCGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x42055B0", Offset = "0x4203FB0", VA = "0x1842055B0")]
	public void HGEEGBKHHEG(TKey JODEIIFHAPK, TVal CLMKDBDPNNH, bool CJIIELGABMB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4205160", Offset = "0x4203B60", VA = "0x184205160")]
	public bool DEHEALGEJED(TKey JODEIIFHAPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4205060", Offset = "0x4203A60", VA = "0x184205060")]
	public bool DCBHEAIHJLO(TKey HEKNCDFGAEO, [Out] TVal CLMKDBDPNNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4205800", Offset = "0x4204200", VA = "0x184205800")]
	private void IGCGLFEDGKG(TKey JODEIIFHAPK, TVal CLMKDBDPNNH, int MPLHLKNKHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4206250", Offset = "0x4204C50", VA = "0x184206250")]
	public bool MKBDMDOAMAJ(TKey JODEIIFHAPK, TVal CLMKDBDPNNH, bool CJIIELGABMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4205AE0", Offset = "0x42044E0", VA = "0x184205AE0")]
	public void IMAFILHGCCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4205CC0", Offset = "0x42046C0", VA = "0x184205CC0")]
	private void JPOAEBMHNFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x42052D0", Offset = "0x4203CD0", VA = "0x1842052D0")]
	private bool EBIAMGDOLAD(TKey JODEIIFHAPK, OBLMGGKPFFM NDHIDCDGEGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4205420", Offset = "0x4203E20", VA = "0x184205420")]
	private void FNPGJPHMPPJ(TKey JODEIIFHAPK, TVal CLMKDBDPNNH, OBLMGGKPFFM NDHIDCDGEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4205B90", Offset = "0x4204590", VA = "0x184205B90")]
	private void JGDFKPAFEMI(TKey JODEIIFHAPK, TVal APKMEEHDCOG, OBLMGGKPFFM NDHIDCDGEGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class BFCHKLHNBJE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action PCMPEGAPKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool EAKAIPNKFLC;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x882870", Offset = "0x881270", VA = "0x180882870")]
	public BFCHKLHNBJE(Action EHDJACLPKIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6C7ABB0", Offset = "0x6C795B0", VA = "0x186C7ABB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2A101B0", Offset = "0x2A0EBB0", VA = "0x182A101B0")]
	public static LMGHFFLKBKA<T> IFAFEFDLIPC<T>(T CLMKDBDPNNH, Action EHDJACLPKIA) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class LMGHFFLKBKA<T> : BFCHKLHNBJE where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T GJBIHCLEEHA
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8869A0", Offset = "0x8853A0", VA = "0x1808869A0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x443D7F0", Offset = "0x443C1F0", VA = "0x18443D7F0")]
	public LMGHFFLKBKA(T CLMKDBDPNNH, Action EHDJACLPKIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class KHHNFCFGCAI<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly FGLNJJLGLLK<T>? MHFGDOPKFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> AILNGEMMOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool EAKAIPNKFLC;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly KHHNFCFGCAI<T> MANEDJLMOBE;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> EEAIANKGEGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4346480", Offset = "0x4344E80", VA = "0x184346480")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long PKLCBMGOIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x43468C0", Offset = "0x43452C0", VA = "0x1843468C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool OFKDLHJCMKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4346740", Offset = "0x4345140", VA = "0x184346740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4346FD0", Offset = "0x43459D0", VA = "0x184346FD0")]
	public KHHNFCFGCAI(FGLNJJLGLLK<T> IDOPGIGKCFO, FGLNJJLGLLK<T> JNJBDBJIPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4347180", Offset = "0x4345B80", VA = "0x184347180")]
	public KHHNFCFGCAI(FGLNJJLGLLK<T> IDOPGIGKCFO, int GLCOHEPGOCK, FGLNJJLGLLK<T> JNJBDBJIPNG, int CKFONDGBMJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x43470D0", Offset = "0x4345AD0", VA = "0x1843470D0")]
	private KHHNFCFGCAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4346370", Offset = "0x4344D70", VA = "0x184346370", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x43465C0", Offset = "0x4344FC0", VA = "0x1843465C0")]
	public T[] NHDDGBECIGN()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4346980", Offset = "0x4345380", VA = "0x184346980")]
	public static ReadOnlySequence<T> PFMAFNCLKDD(KHHNFCFGCAI<T>? LADNMCMIIGP)
	{
		return default(ReadOnlySequence<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct MHHIDICAJHA : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct LGECKFPGHJP : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0")]
		public static LGECKFPGHJP MMKGNMBHOIH()
		{
			return default(LGECKFPGHJP);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2D65B30", Offset = "0x2D64530", VA = "0x182D65B30")]
	public static string? IKBAEOFKPJB<T>([Optional] string? FPLIEEONAFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2D65AB0", Offset = "0x2D644B0", VA = "0x182D65AB0")]
	public static string? BPGJCGJAHFI<T>([Optional] string? HIDOMMFIICJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0")]
	public static MHHIDICAJHA KPJFEGJLPPI(string FPLIEEONAFE, string? HIDOMMFIICJ)
	{
		return default(MHHIDICAJHA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct GOLDOKHMCBL
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool EFELOPKGOCH(string ONEKIPAOMMI, GOLDOKHMCBL JBCFACDKFIJ);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class LIJENICCNKI<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public LIJENICCNKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x44307C0", Offset = "0x442F1C0", VA = "0x1844307C0")]
		internal void OGGBMIHMPFL(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int NPGBIOOADNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public string OGBOJOFLLBD;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6C7BC40", Offset = "0x6C7A640", VA = "0x186C7BC40")]
	public static Dictionary<string, GOLDOKHMCBL> OLOMNGECPND(Type MMMHMMDBHPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2C89AC0", Offset = "0x2C884C0", VA = "0x182C89AC0")]
	public static Dictionary<string, GOLDOKHMCBL> OLOMNGECPND<T>(Type MMMHMMDBHPK, IReadOnlyDictionary<T, string> HPAGJOPMPGO) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2C8A2E0", Offset = "0x2C88CE0", VA = "0x182C8A2E0")]
	public static Dictionary<string, GOLDOKHMCBL> OMBMPPGDDJL<T>(List<T> KKLFDLMMFAE) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6C7B6C0", Offset = "0x6C7A0C0", VA = "0x186C7B6C0")]
	public static Dictionary<string, GOLDOKHMCBL> GAOHBPAPBHN(Type MMMHMMDBHPK, EFELOPKGOCH EOCBINPJPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6C7BA80", Offset = "0x6C7A480", VA = "0x186C7BA80")]
	public static Dictionary<int, string> NFHLDBCIKGG(Dictionary<string, GOLDOKHMCBL> NHGOKBHHHPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class IPGCPDAOJFL : NLHAIFJDFEL
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static bool BFFMFGDNHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string? GHBJDCHJPOG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual NLHAIFJDFEL? NBJBNIHJPCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6C7CF40", Offset = "0x6C7B940", VA = "0x186C7CF40")]
	protected IPGCPDAOJFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string PDDPMMJGDDN();

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6C7C8A0", Offset = "0x6C7B2A0", VA = "0x186C7C8A0", Slot = "8")]
	public virtual string ANOMHJIFFDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6C7CAE0", Offset = "0x6C7B4E0", VA = "0x186C7CAE0", Slot = "9")]
	public void KOJPOHIAMOA(StringBuilder OPBKJFIHKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6C7CEE0", Offset = "0x6C7B8E0", VA = "0x186C7CEE0", Slot = "10")]
	public void PCHIDBAGOPK(StringBuilder OPBKJFIHKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6C7C9C0", Offset = "0x6C7B3C0", VA = "0x186C7C9C0", Slot = "11")]
	public void IPJECJLMANH(StringBuilder OPBKJFIHKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6C7CD80", Offset = "0x6C7B780", VA = "0x186C7CD80", Slot = "12")]
	public void MKNFKKDNMDM(StringBuilder OPBKJFIHKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6C7C920", Offset = "0x6C7B320", VA = "0x186C7C920")]
	public static void IHHOBCAPBPE(StringBuilder OPBKJFIHKAG, string BCFDFNAGHGF, string FBHADOMMKFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5E469E0", Offset = "0x5E453E0", VA = "0x185E469E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class JMMDBGFMDBK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6C7D1E0", Offset = "0x6C7BBE0", VA = "0x186C7D1E0")]
	public JMMDBGFMDBK(string MEBLNPKEJMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DDDJFAAOICA<TErr> : JMMDBGFMDBK where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly TErr BKAKGECHHKM;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5A5A5C0", Offset = "0x5A58FC0", VA = "0x185A5A5C0")]
	private DDDJFAAOICA([In] TErr MKGNPNAAKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5A5A4E0", Offset = "0x5A58EE0", VA = "0x185A5A4E0")]
	public static DDDJFAAOICA<TErr> MMKGNMBHOIH([In] TErr MKGNPNAAKMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ODNEDICMFDP : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashAlgorithm DEIFFIFKAEC;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool POOHHKEACPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool FABAFFOFBOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool NALNOJDDIIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long PKLCBMGOIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6C7DCF0", Offset = "0x6C7C6F0", VA = "0x186C7DCF0", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long FDBNADNMDNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6C7DD60", Offset = "0x6C7C760", VA = "0x186C7DD60", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6C7DDD0", Offset = "0x6C7C7D0", VA = "0x186C7DDD0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6C7DC80", Offset = "0x6C7C680", VA = "0x186C7DC80")]
	public ODNEDICMFDP(HashAlgorithm DEIFFIFKAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6C7DAB0", Offset = "0x6C7C4B0", VA = "0x186C7DAB0", Slot = "35")]
	public override int Read(byte[] NONPGPMAOEG, int ELDAPMPELBH, int KFBJHPBJLOG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6C7DC50", Offset = "0x6C7C650", VA = "0x186C7DC50", Slot = "38")]
	public override void Write(byte[] NONPGPMAOEG, int ELDAPMPELBH, int KFBJHPBJLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6C7DB50", Offset = "0x6C7C550", VA = "0x186C7DB50", Slot = "33")]
	public override long Seek(long ELDAPMPELBH, SeekOrigin OBDNGCBKBFA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6C7DBE0", Offset = "0x6C7C5E0", VA = "0x186C7DBE0", Slot = "34")]
	public override void SetLength(long CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6C7D9E0", Offset = "0x6C7C3E0", VA = "0x186C7D9E0")]
	public byte[] CGMEANJKANE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface NLHAIFJDFEL
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string ANOMHJIFFDI();

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string PDDPMMJGDDN();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface MACJMLCHLOC<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions GJBIHCLEEHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface MBMIKDAGKNL
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string DHPMKJHAEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class FGLNJJLGLLK<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static FGLNJJLGLLK<T>? CLHBJJKBJOC;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static object CLDHFHAMOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private IMemoryOwner<T>? GHANNEOKNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private bool EAKAIPNKFLC;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool DLOJNDBBAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9ECCE0", Offset = "0x9EB6E0", VA = "0x1809ECCE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3D4AB00", Offset = "0x3D49500", VA = "0x183D4AB00")]
	private static FGLNJJLGLLK<T> GMNPDDKKIPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3D4A400", Offset = "0x3D48E00", VA = "0x183D4A400")]
	private static void FHHPCKMCFMO(FGLNJJLGLLK<T> JLFNAKCNNIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3D4BCF0", Offset = "0x3D4A6F0", VA = "0x183D4BCF0")]
	private FGLNJJLGLLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3D4B1B0", Offset = "0x3D49BB0", VA = "0x183D4B1B0")]
	public static FGLNJJLGLLK<T> IFAFEFDLIPC(ReadOnlyMemory<T> PHIIILPGMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3D4B390", Offset = "0x3D49D90", VA = "0x183D4B390")]
	public static FGLNJJLGLLK<T> IFAFEFDLIPC(IMemoryOwner<T> LEKMGHAEOMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3D4B910", Offset = "0x3D4A310", VA = "0x183D4B910")]
	public static void PNPOADIEGDP(FGLNJJLGLLK<T> IDOPGIGKCFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3D4A170", Offset = "0x3D48B70", VA = "0x183D4A170", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3D4A9E0", Offset = "0x3D493E0", VA = "0x183D4A9E0")]
	public FGLNJJLGLLK<T> GMIIOGCKDPD(IMemoryOwner<T> LEKMGHAEOMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3D4B5B0", Offset = "0x3D49FB0", VA = "0x183D4B5B0")]
	private void JFHDOBGIEIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3D4B7B0", Offset = "0x3D4A1B0", VA = "0x183D4B7B0")]
	private FGLNJJLGLLK<T> MNDADDNLOBI(FGLNJJLGLLK<T> JLFNAKCNNIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class DIINLLHGDFK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6C7B090", Offset = "0x6C79A90", VA = "0x186C7B090")]
	public DIINLLHGDFK(string MEBLNPKEJMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class JCAPJKCKLJF<TOk> : DIINLLHGDFK where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly TOk LBMHKOFPDJM;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x41FE320", Offset = "0x41FCD20", VA = "0x1841FE320")]
	private JCAPJKCKLJF([In] TOk JGOGOOFMGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3D38DB0", Offset = "0x3D377B0", VA = "0x183D38DB0")]
	public static JCAPJKCKLJF<TOk> MMKGNMBHOIH([In] TOk JGOGOOFMGDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct MOKFKOEPKDB<TOk, TErr> : IEquatable<MOKFKOEPKDB<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly EqualityComparer<TErr> NMDPKMJLDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal readonly TErr BKAKGECHHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal readonly TOk LBMHKOFPDJM;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool ECMFFDECDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x4635B10", Offset = "0x4634510", VA = "0x184635B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool KPGBHCMHALN
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x4633F30", Offset = "0x4632930", VA = "0x184633F30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4639700", Offset = "0x4638100", VA = "0x184639700")]
	internal MOKFKOEPKDB([In] TErr MKGNPNAAKMO, [In] TOk JGOGOOFMGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4630AC0", Offset = "0x462F4C0", VA = "0x184630AC0")]
	public static MOKFKOEPKDB<TOk, TErr> CDNPANFPFHL([In] TErr MKGNPNAAKMO)
	{
		return default(MOKFKOEPKDB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4633AE0", Offset = "0x46324E0", VA = "0x184633AE0")]
	public static MOKFKOEPKDB<TOk, TErr> JAJBCLJPAAL([In] TOk JGOGOOFMGDH)
	{
		return default(MOKFKOEPKDB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1820", Offset = "0x2CA0220", VA = "0x182CA1820")]
	public MOKFKOEPKDB<TOk?, UErr?> CBJJOHMPCKP<UErr>()
	{
		return default(MOKFKOEPKDB<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2CA3670", Offset = "0x2CA2070", VA = "0x182CA3670")]
	public MOKFKOEPKDB<UOk?, TErr?> OIDCEJNMLFB<UOk>()
	{
		return default(MOKFKOEPKDB<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2CA28C0", Offset = "0x2CA12C0", VA = "0x182CA28C0")]
	public MOKFKOEPKDB<UOk?, TErr?> JGBIBAFDAMH<UOk>()
	{
		return default(MOKFKOEPKDB<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2CA30D0", Offset = "0x2CA1AD0", VA = "0x182CA30D0")]
	public MOKFKOEPKDB<TOk?, UErr?> LLPJFMFEIKP<UErr>()
	{
		return default(MOKFKOEPKDB<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x46361F0", Offset = "0x4634BF0", VA = "0x1846361F0")]
	public MOKFKOEPKDB<IEPJDCHMGFO, TErr> ONIOMPDNAOJ()
	{
		return default(MOKFKOEPKDB<IEPJDCHMGFO, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x46356A0", Offset = "0x46340A0", VA = "0x1846356A0")]
	public static bool LBPOCMFLOBH([In] MOKFKOEPKDB<TOk, TErr> JHAFNHPHBBL, [In] MOKFKOEPKDB<TOk, TErr> GONHEFIHLCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4631450", Offset = "0x462FE50", VA = "0x184631450", Slot = "4")]
	public bool Equals(MOKFKOEPKDB<TOk, TErr> AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4631530", Offset = "0x462FF30", VA = "0x184631530", Slot = "0")]
	public override bool Equals(object AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4632D70", Offset = "0x4631770", VA = "0x184632D70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4638C50", Offset = "0x4637650", VA = "0x184638C50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class FPKGBIEIOIF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct MFKJDFKEKPK<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Task<MOKFKOEPKDB<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<MOKFKOEPKDB<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x4613750", Offset = "0x4612150", VA = "0x184613750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x4614110", Offset = "0x4612B10", VA = "0x184614110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2C783C0", Offset = "0x2C76DC0", VA = "0x182C783C0")]
	public static MOKFKOEPKDB<TOk?, TErr?> LBMHKOFPDJM<TOk, TErr>([In] this MOKFKOEPKDB<TOk, TErr> PECHDAFMNOO, [In] TOk JGOGOOFMGDH)
	{
		return default(MOKFKOEPKDB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A8C0", Offset = "0x2C792C0", VA = "0x182C7A8C0")]
	public static MOKFKOEPKDB<IEPJDCHMGFO, TErr?> LBMHKOFPDJM<TErr>([In] this MOKFKOEPKDB<IEPJDCHMGFO, TErr> PECHDAFMNOO)
	{
		return default(MOKFKOEPKDB<IEPJDCHMGFO, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2C783C0", Offset = "0x2C76DC0", VA = "0x182C783C0")]
	public static MOKFKOEPKDB<TOk?, TErr?> BKAKGECHHKM<TOk, TErr>([In] this MOKFKOEPKDB<TOk, TErr> PECHDAFMNOO, [In] TErr MKGNPNAAKMO)
	{
		return default(MOKFKOEPKDB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2C7AC30", Offset = "0x2C79630", VA = "0x182C7AC30")]
	public static TOk? MNEKCMAMOFI<TOk, TErr>([In] this MOKFKOEPKDB<TOk, TErr> PECHDAFMNOO)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2C78EB0", Offset = "0x2C778B0", VA = "0x182C78EB0")]
	[AsyncStateMachine(typeof(MFKJDFKEKPK<, >))]
	public static Task<TOk?>? GPLJCFHFHFC<TOk, TErr>(this Task<MOKFKOEPKDB<TOk, TErr>> PECHDAFMNOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A6B0", Offset = "0x2C790B0", VA = "0x182C7A6B0")]
	public static TErr? KECMMNCJMDP<TErr, TOk>([In] this MOKFKOEPKDB<TOk, TErr> PECHDAFMNOO)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2C79400", Offset = "0x2C77E00", VA = "0x182C79400")]
	public static bool JOMODAJKNKK<TOk, TErr, UErr, UOk>([In] this MOKFKOEPKDB<TOk, TErr> PECHDAFMNOO, [Out] MOKFKOEPKDB<UOk, UErr> CKDKHPAJAFD) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2C786F0", Offset = "0x2C770F0", VA = "0x182C786F0")]
	public static bool DKBLNAAPKPB<TOk, TErr>([In] this MOKFKOEPKDB<TOk, TErr> PECHDAFMNOO, [Out][NotNullWhen(true)] TOk JGOGOOFMGDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2C79180", Offset = "0x2C77B80", VA = "0x182C79180")]
	public static bool JGMIJHKNJPI<TOk, TErr>([In] this MOKFKOEPKDB<TOk, TErr> PECHDAFMNOO, [Out][NotNullWhen(true)] TErr MKGNPNAAKMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2C78670", Offset = "0x2C77070", VA = "0x182C78670")]
	public static bool BKLDBKPGGKA<TOk, TErr>([In] this MOKFKOEPKDB<TOk, TErr> PECHDAFMNOO, [Out][NotNullWhen(true)] TOk JGOGOOFMGDH, [Out][NotNullWhen(false)] TErr MKGNPNAAKMO) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2C7AF10", Offset = "0x2C79910", VA = "0x182C7AF10")]
	public static bool MNHJBJCCBGF<TOk, TErr>([In] this MOKFKOEPKDB<TOk, TErr> PECHDAFMNOO, [Out][NotNullWhen(true)] TOk JGOGOOFMGDH, [Out] MOKFKOEPKDB<TOk, TErr> CKDKHPAJAFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2C79660", Offset = "0x2C78060", VA = "0x182C79660")]
	public static bool JOMODAJKNKK<TOk, TErr, UErr, UOk>([In] this MOKFKOEPKDB<TOk, TErr> PECHDAFMNOO, [Out][NotNullWhen(true)] TOk JGOGOOFMGDH, [Out] MOKFKOEPKDB<UOk, UErr> CKDKHPAJAFD) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2C77F50", Offset = "0x2C76950", VA = "0x182C77F50")]
	public static bool AAFODNFEHHN<TOk, TErr>([In] this MOKFKOEPKDB<TOk, TErr> PECHDAFMNOO, [Out][NotNullWhen(true)] TOk JGOGOOFMGDH, [Out] MOKFKOEPKDB<IEPJDCHMGFO, TErr> CKDKHPAJAFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2C78B40", Offset = "0x2C77540", VA = "0x182C78B40")]
	public static MOKFKOEPKDB<UOk, UErr> GCDAOFIKMDJ<UOk, UErr, TOk, TErr>([In] this MOKFKOEPKDB<TOk, TErr> PECHDAFMNOO, [In] MOKFKOEPKDB<UOk, UErr> AHPMMDKKKFB) where TOk : UOk where TErr : UErr
	{
		return default(MOKFKOEPKDB<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B010", Offset = "0x2C79A10", VA = "0x182C7B010")]
	public static MOKFKOEPKDB<TOk?[]?, TErr?> PELBLJMEBAM<TOk, TErr>(this IEnumerable<MOKFKOEPKDB<TOk, TErr>> PECHDAFMNOO)
	{
		return default(MOKFKOEPKDB<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class DKNNMIJBKPJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2BC53E0", Offset = "0x2BC3DE0", VA = "0x182BC53E0")]
	public static MOKFKOEPKDB<TOk, T> LBMHKOFPDJM<TOk>([In] TOk JGOGOOFMGDH) where TOk : notnull
	{
		return default(MOKFKOEPKDB<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5A6AA70", Offset = "0x5A69470", VA = "0x185A6AA70")]
	public static MOKFKOEPKDB<IEPJDCHMGFO, T> LBMHKOFPDJM()
	{
		return default(MOKFKOEPKDB<IEPJDCHMGFO, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2BC5250", Offset = "0x2BC3C50", VA = "0x182BC5250")]
	public static MOKFKOEPKDB<T, TErr> BKAKGECHHKM<TErr>([In] TErr MKGNPNAAKMO) where TErr : notnull
	{
		return default(MOKFKOEPKDB<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct DIGKGAPPGFL<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly GENEODIDDJO CAPDNBPILLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<TKey, TValue> KDMALIGKHEJ;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3D38A80", Offset = "0x3D37480", VA = "0x183D38A80")]
	public static DIGKGAPPGFL<TKey, TValue> MMKGNMBHOIH(string GJGBLLHIOAC)
	{
		return default(DIGKGAPPGFL<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3D38BB0", Offset = "0x3D375B0", VA = "0x183D38BB0")]
	internal DIGKGAPPGFL(Dictionary<TKey, TValue> CLMKDBDPNNH, GENEODIDDJO AOGOHPBJPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3D389D0", Offset = "0x3D373D0", VA = "0x183D389D0")]
	public JHIMFEJNOKO<TKey, TValue> FBLBCFAFGIJ([Out] Dictionary<TKey, TValue> CLMKDBDPNNH)
	{
		return default(JHIMFEJNOKO<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct JHIMFEJNOKO<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Dictionary<TKey, TValue> KDMALIGKHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly DBGKMJEDIHN GEDCDLGGLNA;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x225F480", Offset = "0x225DE80", VA = "0x18225F480")]
	internal JHIMFEJNOKO(Dictionary<TKey, TValue> CLMKDBDPNNH, DBGKMJEDIHN NANBLHPPIGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3D76060", Offset = "0x3D74A60", VA = "0x183D76060", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct LAMBGDOJDGM<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly GENEODIDDJO CAPDNBPILLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly HashSet<T> KDMALIGKHEJ;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3D38A80", Offset = "0x3D37480", VA = "0x183D38A80")]
	public static LAMBGDOJDGM<T> MMKGNMBHOIH(string GJGBLLHIOAC)
	{
		return default(LAMBGDOJDGM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3D38BB0", Offset = "0x3D375B0", VA = "0x183D38BB0")]
	internal LAMBGDOJDGM(HashSet<T> CLMKDBDPNNH, GENEODIDDJO AOGOHPBJPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3D389D0", Offset = "0x3D373D0", VA = "0x183D389D0")]
	public DILGKJNANPM<T> FBLBCFAFGIJ([Out] HashSet<T> CLMKDBDPNNH)
	{
		return default(DILGKJNANPM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct DILGKJNANPM<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly HashSet<T> KDMALIGKHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly DBGKMJEDIHN GEDCDLGGLNA;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x225F480", Offset = "0x225DE80", VA = "0x18225F480")]
	internal DILGKJNANPM(HashSet<T> CLMKDBDPNNH, DBGKMJEDIHN NANBLHPPIGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3D76060", Offset = "0x3D74A60", VA = "0x183D76060", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct FDKECFJPPCI<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly GENEODIDDJO CAPDNBPILLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Stack<T> KDMALIGKHEJ;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3D38A80", Offset = "0x3D37480", VA = "0x183D38A80")]
	public static FDKECFJPPCI<T> MMKGNMBHOIH(string GJGBLLHIOAC)
	{
		return default(FDKECFJPPCI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3D38BB0", Offset = "0x3D375B0", VA = "0x183D38BB0")]
	internal FDKECFJPPCI(Stack<T> CLMKDBDPNNH, GENEODIDDJO AOGOHPBJPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3D389D0", Offset = "0x3D373D0", VA = "0x183D389D0")]
	public FPODDCDMEIN<T> FBLBCFAFGIJ([Out] Stack<T> CLMKDBDPNNH)
	{
		return default(FPODDCDMEIN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct FPODDCDMEIN<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Stack<T> KDMALIGKHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly DBGKMJEDIHN GEDCDLGGLNA;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x225F480", Offset = "0x225DE80", VA = "0x18225F480")]
	internal FPODDCDMEIN(Stack<T> CLMKDBDPNNH, DBGKMJEDIHN NANBLHPPIGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3D76060", Offset = "0x3D74A60", VA = "0x183D76060", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
public sealed class HCHONMDAAAH<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct GMOGFEJGGNI : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly HCHONMDAAAH<T> LOHBKDJBPLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int KAABKPDAAHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly bool CAGCGBIGMBL;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x1F9D370", Offset = "0x1F9BD70", VA = "0x181F9D370")]
		public GMOGFEJGGNI(HCHONMDAAAH<T> BMCAAIIMEIN, int NEOMJPKJLGA, bool GCMCAILFMLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3E38540", Offset = "0x3E36F40", VA = "0x183E38540")]
		public HCHONMDAAAH<T>.DFODJIGELHJ BPGPEIEKEPK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3E38640", Offset = "0x3E37040", VA = "0x183E38640", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3E38640", Offset = "0x3E37040", VA = "0x183E38640", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class DFODJIGELHJ : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly HCHONMDAAAH<T> LOHBKDJBPLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly int GPHNPFLCIMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int ALONHEBBILJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly bool CAGCGBIGMBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private bool CJCMKPGNJJO;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T JOCMDMELDEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x5A5F970", Offset = "0x5A5E370", VA = "0x185A5F970")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x5A5FA20", Offset = "0x5A5E420", VA = "0x185A5FA20", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x5A5FB20", Offset = "0x5A5E520", VA = "0x185A5FB20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5A602B0", Offset = "0x5A5ECB0", VA = "0x185A602B0")]
		public DFODJIGELHJ(HCHONMDAAAH<T> BMCAAIIMEIN, int NEOMJPKJLGA, bool GCMCAILFMLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5A5F810", Offset = "0x5A5E210", VA = "0x185A5F810", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5A5F9B0", Offset = "0x5A5E3B0", VA = "0x185A5F9B0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class HBKBDDPPHOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public HBKBDDPPHOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x3EA98C0", Offset = "0x3EA82C0", VA = "0x183EA98C0")]
		internal T IPJCNOMAGLI(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly T[] JNBCLHFIMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int ALONHEBBILJ;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int KLEOODEJJEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3EC6720", Offset = "0x3EC5120", VA = "0x183EC6720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T JOCMDMELDEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3D14E40", Offset = "0x3D13840", VA = "0x183D14E40")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T IDCAEDBDIMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3EC6780", Offset = "0x3EC5180", VA = "0x183EC6780")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T MJCLDFCFNGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3EC65A0", Offset = "0x3EC4FA0", VA = "0x183EC65A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int PKLCBMGOIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1B3CF60", Offset = "0x1B3B960", VA = "0x181B3CF60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x131DEC0", Offset = "0x131C8C0", VA = "0x18131DEC0")]
	private static int BKBIOINDBIL(int EBDDHAPIAHH, int OMBKDMFPMFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3EC6A30", Offset = "0x3EC5430", VA = "0x183EC6A30")]
	public HCHONMDAAAH(int MPLHLKNKHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3EC67C0", Offset = "0x3EC51C0", VA = "0x183EC67C0")]
	public HCHONMDAAAH(int MPLHLKNKHIM, Func<T> MMJMHJAEHNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3EC6B60", Offset = "0x3EC5560", VA = "0x183EC6B60")]
	public HCHONMDAAAH(T[] HLHNGAOBAAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3EC66F0", Offset = "0x3EC50F0", VA = "0x183EC66F0")]
	public void GCHKHJBPBGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3EC6430", Offset = "0x3EC4E30", VA = "0x183EC6430")]
	public IEnumerable<T> BEHKLKPGEMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3EC6500", Offset = "0x3EC4F00", VA = "0x183EC6500")]
	public HCHONMDAAAH<T>.DFODJIGELHJ BPGPEIEKEPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x39A7000", Offset = "0x39A5A00", VA = "0x1839A7000", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x39A7000", Offset = "0x39A5A00", VA = "0x1839A7000", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class JFOIGPMKNCM
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2CFBE80", Offset = "0x2CFA880", VA = "0x182CFBE80")]
	public static HCHONMDAAAH<T> MMKGNMBHOIH<T>(int MPLHLKNKHIM, Func<T> MMJMHJAEHNK) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class GIBJAFIMICM<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct AFBNJPJGAHI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly GIBJAFIMICM<T> FHAMFAJNBME;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T GJBIHCLEEHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x3DC48A0", Offset = "0x3DC32A0", VA = "0x183DC48A0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3DC4870", Offset = "0x3DC3270", VA = "0x183DC4870", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xACCA10", Offset = "0xACB410", VA = "0x180ACCA10")]
		public AFBNJPJGAHI(GIBJAFIMICM<T> FHAMFAJNBME)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct FOMNNHBKIPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public AsyncTaskMethodBuilder<AFBNJPJGAHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public GIBJAFIMICM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x3D6DCD0", Offset = "0x3D6C6D0", VA = "0x183D6DCD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x3D6DF40", Offset = "0x3D6C940", VA = "0x183D6DF40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly SemaphoreSlim PPMOGHNBCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private T DKMPFGECNCP;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3E256D0", Offset = "0x3E240D0", VA = "0x183E256D0")]
	public GIBJAFIMICM([In] T DKMPFGECNCP, int BDPFIEDFAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3E25540", Offset = "0x3E23F40", VA = "0x183E25540")]
	public GIBJAFIMICM([In] T DKMPFGECNCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3E24FE0", Offset = "0x3E239E0", VA = "0x183E24FE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3E25500", Offset = "0x3E23F00", VA = "0x183E25500")]
	public AFBNJPJGAHI HPNEMILIILD()
	{
		return default(AFBNJPJGAHI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3E25040", Offset = "0x3E23A40", VA = "0x183E25040")]
	[AsyncStateMachine(typeof(GIBJAFIMICM<>.FOMNNHBKIPF))]
	public Task<GIBJAFIMICM<T>.AFBNJPJGAHI> HCCLNKMCDHD(CancellationToken OGJIGALEPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3E25020", Offset = "0x3E23A20", VA = "0x183E25020")]
	public void FIMDILKBDED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class BPCACGGBGFF
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6C7AED0", Offset = "0x6C798D0", VA = "0x186C7AED0")]
	public static GIBJAFIMICM<IEPJDCHMGFO> MMKGNMBHOIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2A287D0", Offset = "0x2A271D0", VA = "0x182A287D0")]
	public static GIBJAFIMICM<T> MMKGNMBHOIH<T>([In] T DKMPFGECNCP) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class LKFGHFCPCLI<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct HHOHHECMIFG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly LKFGHFCPCLI<T> COFJDCPDGHH;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public T GJBIHCLEEHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x3DDCDF0", Offset = "0x3DDB7F0", VA = "0x183DDCDF0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3EE5580", Offset = "0x3EE3F80", VA = "0x183EE5580", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xACCA10", Offset = "0xACB410", VA = "0x180ACCA10")]
		internal HHOHHECMIFG(LKFGHFCPCLI<T> FHAMFAJNBME)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct AHPDPLHEEIH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly LKFGHFCPCLI<T> COFJDCPDGHH;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public T GJBIHCLEEHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x3DDCDF0", Offset = "0x3DDB7F0", VA = "0x183DDCDF0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3DDCDA0", Offset = "0x3DDB7A0", VA = "0x183DDCDA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xACCA10", Offset = "0xACB410", VA = "0x180ACCA10")]
		internal AHPDPLHEEIH(LKFGHFCPCLI<T> FHAMFAJNBME)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct OAPFLIJHNKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder<AHPDPLHEEIH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public LKFGHFCPCLI<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private GIBJAFIMICM<IEPJDCHMGFO>.AFBNJPJGAHI <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<GIBJAFIMICM<IEPJDCHMGFO>.AFBNJPJGAHI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x4816A40", Offset = "0x4815440", VA = "0x184816A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3D6DF40", Offset = "0x3D6C940", VA = "0x183D6DF40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly GIBJAFIMICM<int> LAHHPFNLBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly GIBJAFIMICM<IEPJDCHMGFO> IHJLKHIPLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly GIBJAFIMICM<IEPJDCHMGFO> KKLIJBIJJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private T NADHMEOJNED;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4436870", Offset = "0x4435270", VA = "0x184436870")]
	internal LKFGHFCPCLI(GIBJAFIMICM<int> BEGAMDJLIOD, GIBJAFIMICM<IEPJDCHMGFO> MLKLKOLHBDB, GIBJAFIMICM<IEPJDCHMGFO> PFIEDEIHHFC, [In] T DKMPFGECNCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4436110", Offset = "0x4434B10", VA = "0x184436110", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4435D10", Offset = "0x4434710", VA = "0x184435D10")]
	public HHOHHECMIFG CLFIJFEJJHJ()
	{
		return default(HHOHHECMIFG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4436210", Offset = "0x4434C10", VA = "0x184436210")]
	public AHPDPLHEEIH GKMCPGCJPIC()
	{
		return default(AHPDPLHEEIH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4436740", Offset = "0x4435140", VA = "0x184436740")]
	[AsyncStateMachine(typeof(LKFGHFCPCLI<>.OAPFLIJHNKK))]
	public Task<LKFGHFCPCLI<T>.AHPDPLHEEIH> MKMMGALAIHI(CancellationToken OGJIGALEPCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class FEAHONFCFCD
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6C7B0F0", Offset = "0x6C79AF0", VA = "0x186C7B0F0")]
	public static LKFGHFCPCLI<IEPJDCHMGFO> MMKGNMBHOIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2C60A20", Offset = "0x2C5F420", VA = "0x182C60A20")]
	public static LKFGHFCPCLI<T> MMKGNMBHOIH<T>([In] T DKMPFGECNCP) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public sealed class AHEADBPPHGE<TData> : IPGCPDAOJFL where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly string LKAAOFNIBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly TData CNPFJDANIOD;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "7")]
	public override string PDDPMMJGDDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3DDB560", Offset = "0x3DD9F60", VA = "0x183DDB560")]
	internal AHEADBPPHGE(string MEBLNPKEJMN, [In] TData OIGMDCDEKEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class PNGGBEFFEFG
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6C7E210", Offset = "0x6C7CC10", VA = "0x186C7E210")]
	public static AHEADBPPHGE<IEPJDCHMGFO> MMKGNMBHOIH(string MEBLNPKEJMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2A101B0", Offset = "0x2A0EBB0", VA = "0x182A101B0")]
	public static AHEADBPPHGE<TData> MMKGNMBHOIH<TData>(string MEBLNPKEJMN, [In] TData OIGMDCDEKEG) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class GENEODIDDJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal bool DOICMBHNMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly string KJFGDENKHAN;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x121F3C0", Offset = "0x121DDC0", VA = "0x18121F3C0")]
	private GENEODIDDJO(bool LHBLKALIJDK, string NGNAEEBGBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6C7B650", Offset = "0x6C7A050", VA = "0x186C7B650")]
	public static GENEODIDDJO MMKGNMBHOIH(string NGNAEEBGBMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6C7B590", Offset = "0x6C79F90", VA = "0x186C7B590")]
	public DBGKMJEDIHN FBLBCFAFGIJ()
	{
		return default(DBGKMJEDIHN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct DBGKMJEDIHN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly GENEODIDDJO BMHGGKLDAHL;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0xACCA10", Offset = "0xACB410", VA = "0x180ACCA10")]
	internal DBGKMJEDIHN(GENEODIDDJO GJGBLLHIOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6C7B070", Offset = "0x6C79A70", VA = "0x186C7B070", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class GCCDBCKJICF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly Dictionary<object, float> EDBFMFKGPOA;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public float JBOCDNOBOEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x91E840", Offset = "0x91D240", VA = "0x18091E840")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x91E830", Offset = "0x91D230", VA = "0x18091E830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6C7B2A0", Offset = "0x6C79CA0", VA = "0x186C7B2A0")]
	public void CFGPJGNDHFC(float CLMKDBDPNNH, object KLGLJKMNAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6C7B360", Offset = "0x6C79D60", VA = "0x186C7B360")]
	public void JAABMHIDLLO(object KLGLJKMNAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6C7B310", Offset = "0x6C79D10", VA = "0x186C7B310")]
	public void IMAFILHGCCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6C7B3D0", Offset = "0x6C79DD0", VA = "0x186C7B3D0")]
	private void PBKHJADGEOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6C7B500", Offset = "0x6C79F00", VA = "0x186C7B500")]
	public GCCDBCKJICF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class BCEBKDPOPGH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class ECIHFNBBJHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public ECIHFNBBJHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3954C10", Offset = "0x3953610", VA = "0x183954C10")]
		internal int DMIMPFHGCKB(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private HashSet<T>? LGHKCODDBHL;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public IReadOnlyCollection<T> CLDNONGJFOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4FFFC80", Offset = "0x4FFE680", VA = "0x184FFFC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool MOEJOIBGICD
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4FFFAB0", Offset = "0x4FFE4B0", VA = "0x184FFFAB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int FPAPEBLAAHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x889410", Offset = "0x887E10", VA = "0x180889410")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x889400", Offset = "0x887E00", VA = "0x180889400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4FFF8D0", Offset = "0x4FFE2D0", VA = "0x184FFF8D0")]
	public bool EGHPKMGPEOO(T KLGLJKMNAIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4FFFB00", Offset = "0x4FFE500", VA = "0x184FFFB00")]
	public bool MIOFMOMIMDC(T KLGLJKMNAIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4FFF880", Offset = "0x4FFE280", VA = "0x184FFF880")]
	public bool BNBIAOAJEAG(T KLGLJKMNAIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4FFFCC0", Offset = "0x4FFE6C0", VA = "0x184FFFCC0")]
	public void POKFIGLIBPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x4FFFDB0", Offset = "0x4FFE7B0", VA = "0x184FFFDB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public BCEBKDPOPGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class MHJKPPBKJIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly string FMIHBBJGPLA;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x882870", Offset = "0x881270", VA = "0x180882870")]
	public MHJKPPBKJIK(string FMIHBBJGPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6C7D470", Offset = "0x6C7BE70", VA = "0x186C7D470", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public sealed class NMGCDKAGAKF
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class OHNDKGENBAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public OHNDKGENBAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6C7DE40", Offset = "0x6C7C840", VA = "0x186C7DE40")]
		internal int DMIMPFHGCKB(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private HashSet<object>? LGHKCODDBHL;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IReadOnlyCollection<object> CLDNONGJFOB
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6C7D6B0", Offset = "0x6C7C0B0", VA = "0x186C7D6B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool MOEJOIBGICD
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6C7D600", Offset = "0x6C7C000", VA = "0x186C7D600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int FPAPEBLAAHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x889410", Offset = "0x887E10", VA = "0x180889410")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x889400", Offset = "0x887E00", VA = "0x180889400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6C7D520", Offset = "0x6C7BF20", VA = "0x186C7D520")]
	public bool EGHPKMGPEOO(object KLGLJKMNAIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6C7D610", Offset = "0x6C7C010", VA = "0x186C7D610")]
	public bool MIOFMOMIMDC(object KLGLJKMNAIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6C7D4C0", Offset = "0x6C7BEC0", VA = "0x186C7D4C0")]
	public bool BNBIAOAJEAG(object KLGLJKMNAIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6C7D740", Offset = "0x6C7C140", VA = "0x186C7D740")]
	public void POKFIGLIBPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6C7D7B0", Offset = "0x6C7C1B0", VA = "0x186C7D7B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public NMGCDKAGAKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class JMHPEICLALM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private struct LJDJFJKALHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public float FFHDLOAHFIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public T GJBIHCLEEHA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly Dictionary<object, LJDJFJKALHC> EDBFMFKGPOA;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public virtual T AGDBCJPPAKB
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x12091D0", Offset = "0x1207BD0", VA = "0x1812091D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x1207BD0", Offset = "0x12065D0", VA = "0x181207BD0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public object? HGJLOHGKKID
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8893E0", Offset = "0x887DE0", VA = "0x1808893E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8893D0", Offset = "0x887DD0", VA = "0x1808893D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool PIIEJFCEHBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x4236200", Offset = "0x4234C00", VA = "0x184236200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x4235D20", Offset = "0x4234720", VA = "0x184235D20")]
	public bool CFGPJGNDHFC(T CLMKDBDPNNH, object KLGLJKMNAIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x4237E80", Offset = "0x4236880", VA = "0x184237E80")]
	public bool JAABMHIDLLO(object KLGLJKMNAIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3DDE160", Offset = "0x3DDCB60", VA = "0x183DDE160")]
	public void IMAFILHGCCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x4236410", Offset = "0x4234E10", VA = "0x184236410")]
	public bool DCBHEAIHJLO(object KLGLJKMNAIM, [Out] T CLMKDBDPNNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x42370B0", Offset = "0x4235AB0", VA = "0x1842370B0")]
	[KEKAIFGNLLJ("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool IGGGPGHLJLC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x4237F30", Offset = "0x4236930", VA = "0x184237F30")]
	public JMHPEICLALM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class DMAPBIDKHOP<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private List<WeakReference<T>>? LGHKCODDBHL;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool MOEJOIBGICD
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5A76FD0", Offset = "0x5A759D0", VA = "0x185A76FD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int FPAPEBLAAHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5A76E20", Offset = "0x5A75820", VA = "0x185A76E20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5A76B90", Offset = "0x5A75590", VA = "0x185A76B90")]
	public void EGHPKMGPEOO(T KLGLJKMNAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5A77100", Offset = "0x5A75B00", VA = "0x185A77100")]
	public void MIOFMOMIMDC(T KLGLJKMNAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5A772B0", Offset = "0x5A75CB0", VA = "0x185A772B0")]
	public void POKFIGLIBPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5A77300", Offset = "0x5A75D00", VA = "0x185A77300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public DMAPBIDKHOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal static class CGEEOMBHENG
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2AB9D70", Offset = "0x2AB8770", VA = "0x182AB9D70")]
	public static void GMDLAMIAKHP<T>(this List<T> JNHGBAGBHGA, int EBDDHAPIAHH) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface ANHNALELEKE
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event GCNINHOFBGK KGBBKAKIJEC;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class ICJIGFPOECJ : ANHNALELEKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public readonly struct BNFIPHKAJMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public readonly float EIIEGDCHIMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public readonly float JNJBOFHMEBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		internal readonly bool IMCHLNDGPGF;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float GCMPBODBNPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x6C7ABF0", Offset = "0x6C795F0", VA = "0x186C7ABF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6C7AD70", Offset = "0x6C79770", VA = "0x186C7AD70")]
		public BNFIPHKAJMJ(float PJOMFOPGCGL, float OAACEGBODFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6C7AC00", Offset = "0x6C79600", VA = "0x186C7AC00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class JGPDNHHDKPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public ICJIGFPOECJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public JGPDNHHDKPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6C7CFB0", Offset = "0x6C7B9B0", VA = "0x186C7CFB0")]
		internal void PLCKOJFLFLH(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly int HBMOJAPOCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int EGBACKEEOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly ANHNALELEKE[] MMGLEDJOGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly GCNINHOFBGK[] NAAJCHKOOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly BNFIPHKAJMJ[] NHEGHDHBOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private BNFIPHKAJMJ IHCDLBMKHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly KKIECNMMHCI OCMAHHEOMND;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event GCNINHOFBGK KGBBKAKIJEC
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6C7C080", Offset = "0x6C7AA80", VA = "0x186C7C080", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6C7C140", Offset = "0x6C7AB40", VA = "0x186C7C140", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6C7C710", Offset = "0x6C7B110", VA = "0x186C7C710")]
	public ICJIGFPOECJ(int HBMOJAPOCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6C7C200", Offset = "0x6C7AC00", VA = "0x186C7C200")]
	public KKIECNMMHCI MJKIEOCFPHD(BNFIPHKAJMJ IMMNAIPHFMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6C7C290", Offset = "0x6C7AC90", VA = "0x186C7C290")]
	public void POMJBMOGKFI(ANHNALELEKE ANMIBGODAAE, [Optional] BNFIPHKAJMJ CJHOIIMMDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6C7BF70", Offset = "0x6C7A970", VA = "0x186C7BF70", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public delegate void GCNINHOFBGK(float INGBCCEJJOD);
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class CDIEMJIGLMM
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class FLCGKPDHEAN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly ANHNALELEKE FOHENPCOOID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly GCNINHOFBGK DKOPNCNMOIF;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6C7B210", Offset = "0x6C79C10", VA = "0x186C7B210")]
		public FLCGKPDHEAN(ANHNALELEKE FOHENPCOOID, GCNINHOFBGK DKOPNCNMOIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6C7B1C0", Offset = "0x6C79BC0", VA = "0x186C7B1C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6C7AF40", Offset = "0x6C79940", VA = "0x186C7AF40")]
	internal static bool FCHGJBJGIFG(float GPKBBMJKBAE, float AAMOGMLMOOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6C6B000", Offset = "0x6C69A00", VA = "0x186C6B000")]
	internal static float FLGGEGIHLAP(float GPKBBMJKBAE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6C7AFB0", Offset = "0x6C799B0", VA = "0x186C7AFB0")]
	public static IDisposable KNMALDDKMED(this ANHNALELEKE FOHENPCOOID, GCNINHOFBGK DKOPNCNMOIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class KKIECNMMHCI : ANHNALELEKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private float INGBCCEJJOD;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public float AKJDJMKNABA
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6C7D240", Offset = "0x6C7BC40", VA = "0x186C7D240")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event GCNINHOFBGK? KGBBKAKIJEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6C7D330", Offset = "0x6C7BD30", VA = "0x186C7D330", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6C7D3D0", Offset = "0x6C7BDD0", VA = "0x186C7D3D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public KKIECNMMHCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface IBJEGFMMNCO<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DKGBGBCKHMK<T> ADOMJAHIMBE([Out] T CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IMAFILHGCCD();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class OJFOAMHKPED<T> : IBJEGFMMNCO<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly ConcurrentStack<T> KKLKBAJFLNB;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x4842320", Offset = "0x4840D20", VA = "0x184842320", Slot = "4")]
	public DKGBGBCKHMK<T> ADOMJAHIMBE([Out] T CLMKDBDPNNH)
	{
		return default(DKGBGBCKHMK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x48423C0", Offset = "0x4840DC0", VA = "0x1848423C0")]
	public void NNFNKLLBHJI(T CPEBNHNPNOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3DC46E0", Offset = "0x3DC30E0", VA = "0x183DC46E0", Slot = "5")]
	public void IMAFILHGCCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "6")]
	protected virtual void PNFGNCPODBL(T NJEFKABFKBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x4842440", Offset = "0x4840E40", VA = "0x184842440")]
	private T PHNOCPFLPNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x48424F0", Offset = "0x4840EF0", VA = "0x1848424F0")]
	public OJFOAMHKPED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public readonly struct DKGBGBCKHMK<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly T CPEBNHNPNOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly OJFOAMHKPED<T> EFIHMNMKKBI;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0xC4E920", Offset = "0xC4D320", VA = "0x180C4E920")]
	internal DKGBGBCKHMK(T CLMKDBDPNNH, OJFOAMHKPED<T> EFIHMNMKKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5A6A810", Offset = "0x5A69210", VA = "0x185A6A810", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class JMIOINKFCKF : OJFOAMHKPED<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public static readonly JMIOINKFCKF LPENGNKGBMO;

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6C7D050", Offset = "0x6C7BA50", VA = "0x186C7D050")]
	public static DKGBGBCKHMK<StringBuilder> PHNOCPFLPNG([Out] StringBuilder CLMKDBDPNNH)
	{
		return default(DKGBGBCKHMK<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6C7D0F0", Offset = "0x6C7BAF0", VA = "0x186C7D0F0", Slot = "6")]
	protected override void PNFGNCPODBL(StringBuilder NJEFKABFKBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6C7D1A0", Offset = "0x6C7BBA0", VA = "0x186C7D1A0")]
	public JMIOINKFCKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class FMOEKLNJPBK : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x66F05F0", Offset = "0x66EEFF0", VA = "0x1866F05F0")]
	public FMOEKLNJPBK(string MEBLNPKEJMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[DefaultMember("Item")]
public class ILGCIGBMBPO<TKey, TValue> : MJPEOMMPOCC<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, MAHLDKEAHEM where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class JHOMEFFOMDG : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public ILGCIGBMBPO<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x12091D0", Offset = "0x1207BD0", VA = "0x1812091D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x422D660", Offset = "0x422C060", VA = "0x18422D660", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x88DF90", Offset = "0x88C990", VA = "0x18088DF90")]
		[DebuggerHidden]
		public JHOMEFFOMDG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3BEA940", Offset = "0x3BE9340", VA = "0x183BEA940", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x422CCD0", Offset = "0x422B6D0", VA = "0x18422CCD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x422C820", Offset = "0x422B220", VA = "0x18422C820")]
		private void GPKDFCKBEHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x422D520", Offset = "0x422BF20", VA = "0x18422D520")]
		private void OLBNGAJNBBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x422D5C0", Offset = "0x422BFC0", VA = "0x18422D5C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly MJPEOMMPOCC<TKey, TValue> KFCKFOBIGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly IDictionary<TKey, TValue> MEGBPODJAKJ;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int FPAPEBLAAHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x4021590", Offset = "0x401FF90", VA = "0x184021590", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool NFLNLAGFBEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public TValue MJCLDFCFNGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x4021840", Offset = "0x4020240", VA = "0x184021840", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x4021AF0", Offset = "0x40204F0", VA = "0x184021AF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public ICollection<TKey> IAAGHMCCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x4021890", Offset = "0x4020290", VA = "0x184021890", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public ICollection<TValue> KDBGNFAJJKP
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x40219C0", Offset = "0x40203C0", VA = "0x1840219C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x40214C0", Offset = "0x401FEC0", VA = "0x1840214C0")]
	public ILGCIGBMBPO(MJPEOMMPOCC<TKey, TValue> KFCKFOBIGBH, [Optional] IDictionary<TKey, TValue>? MEGBPODJAKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x401F2E0", Offset = "0x401DCE0", VA = "0x18401F2E0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x401FD10", Offset = "0x401E710", VA = "0x18401FD10")]
	public void ENPPDDMHAAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x401E960", Offset = "0x401D360", VA = "0x18401E960", Slot = "9")]
	public void Add(TKey JODEIIFHAPK, TValue CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x401EBA0", Offset = "0x401D5A0", VA = "0x18401EBA0")]
	public void BJHFDOILBNG(TKey JODEIIFHAPK, TValue CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x401FE30", Offset = "0x401E830", VA = "0x18401FE30")]
	public void FKFNHFKNNIB(TKey JODEIIFHAPK, TValue CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x401EF70", Offset = "0x401D970", VA = "0x18401EF70")]
	public void COKNEEEEGJG(TKey JODEIIFHAPK, TValue CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x4020640", Offset = "0x401F040", VA = "0x184020640")]
	public void IDFHNJNAAJP(TKey JODEIIFHAPK, TValue CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x4020A90", Offset = "0x401F490", VA = "0x184020A90", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> EDKOAHIAMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x4020B30", Offset = "0x401F530", VA = "0x184020B30", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> EDKOAHIAMMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x4020E90", Offset = "0x401F890", VA = "0x184020E90", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> EDKOAHIAMMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x401F420", Offset = "0x401DE20", VA = "0x18401F420", Slot = "8")]
	public bool ContainsKey(TKey JODEIIFHAPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x4020320", Offset = "0x401ED20", VA = "0x184020320")]
	public bool FPPCFPGECAF(TKey JODEIIFHAPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x401FC40", Offset = "0x401E640", VA = "0x18401FC40")]
	public bool DKGBCOGLBOA(TKey JODEIIFHAPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x40208F0", Offset = "0x401F2F0", VA = "0x1840208F0", Slot = "10")]
	public bool Remove(TKey JODEIIFHAPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x4021310", Offset = "0x401FD10", VA = "0x184021310", Slot = "11")]
	public bool TryGetValue(TKey JODEIIFHAPK, [Out] TValue CLMKDBDPNNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x401F4F0", Offset = "0x401DEF0", VA = "0x18401F4F0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] FNCIFDCGDBA, int NPOJHGDDMDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x40211F0", Offset = "0x401FBF0", VA = "0x1840211F0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x40203F0", Offset = "0x401EDF0", VA = "0x1840203F0", Slot = "19")]
	[IteratorStateMachine(typeof(ILGCIGBMBPO<, >.JHOMEFFOMDG))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x4020790", Offset = "0x401F190", VA = "0x184020790", Slot = "21")]
	public bool OJIPMCGCHMF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x40201B0", Offset = "0x401EBB0", VA = "0x1840201B0")]
	private TValue FMEMGFIGCIB(TKey JODEIIFHAPK)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface MAHLDKEAHEM
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OJIPMCGCHMF();
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface MJPEOMMPOCC<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, MAHLDKEAHEM
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[DefaultMember("Item")]
public sealed class CFBKFBIANBJ<TKey, TVal> : MJPEOMMPOCC<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, MAHLDKEAHEM where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public delegate int PDJGHOJMNGM(TKey JODEIIFHAPK, TVal CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate void ILMIKKLPMBN(TKey JODEIIFHAPK, TVal CLMKDBDPNNH, OBLMGGKPFFM NDHIDCDGEGF);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private class OOFAHFEIAOD
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public TKey JDBNAJHLPPP
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x94B360", Offset = "0x949D60", VA = "0x18094B360")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public TVal GJBIHCLEEHA
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x8F2EF0", Offset = "0x8F18F0", VA = "0x1808F2EF0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x91A260", Offset = "0x918C60", VA = "0x18091A260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int GCMPBODBNPC
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x8C3B70", Offset = "0x8C2570", VA = "0x1808C3B70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x8C2FA0", Offset = "0x8C19A0", VA = "0x1808C2FA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTimeOffset HAOBFHLBCBK
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xDCD720", Offset = "0xDCC120", VA = "0x180DCD720")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x16FBD60", Offset = "0x16FA760", VA = "0x1816FBD60")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x485DC80", Offset = "0x485C680", VA = "0x18485DC80")]
		public OOFAHFEIAOD(TKey JODEIIFHAPK, TVal APKMEEHDCOG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class CKPBNGFMIOP : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public CFBKFBIANBJ<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private LinkedList<OOFAHFEIAOD>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x12091D0", Offset = "0x1207BD0", VA = "0x1812091D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3BEDC90", Offset = "0x3BEC690", VA = "0x183BEDC90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x88DF90", Offset = "0x88C990", VA = "0x18088DF90")]
		[DebuggerHidden]
		public CKPBNGFMIOP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3BE5520", Offset = "0x3BE3F20", VA = "0x183BE5520", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x5444610", Offset = "0x5443010", VA = "0x185444610", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x5443920", Offset = "0x5442320", VA = "0x185443920")]
		private void GPKDFCKBEHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x54460D0", Offset = "0x5444AD0", VA = "0x1854460D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public const int HBKDKEIHMPC = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly Dictionary<TKey, LinkedListNode<OOFAHFEIAOD>> KHDMLKPODMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly LinkedList<OOFAHFEIAOD> CIMDOCNIMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly PDJGHOJMNGM? DMDPLLOBMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly TimeSpan LHGFNCGAJIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly ILMIKKLPMBN? NHKHPOCLCGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly GOIJNKHANAB NICIANOOHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private bool IBFIMHDOLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly List<TKey> COHONJGGKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly List<TVal> GFJNCMFPCAO;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int EGBHAHKNAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x893630", Offset = "0x892030", VA = "0x180893630")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	internal int CGBABGFLMMN
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xCAB010", Offset = "0xCA9A10", VA = "0x180CAB010")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xCAAA30", Offset = "0xCA9430", VA = "0x180CAAA30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int FPAPEBLAAHL
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x53453F0", Offset = "0x5343DF0", VA = "0x1853453F0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	internal int MPOHBALDCBB
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3DDE160", Offset = "0x3DDCB60", VA = "0x183DDE160")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public ICollection<TVal> KDBGNFAJJKP
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x53455A0", Offset = "0x5343FA0", VA = "0x1853455A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	ICollection<TKey> IDictionary<TKey, TVal>.HIMNAHIHNDK
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5340E00", Offset = "0x533F800", VA = "0x185340E00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool NFLNLAGFBEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public TVal MJCLDFCFNGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x5345500", Offset = "0x5343F00", VA = "0x185345500", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x53455F0", Offset = "0x5343FF0", VA = "0x1853455F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5336900", Offset = "0x5335300", VA = "0x185336900")]
	private bool GEJDCEMHGAJ(int HBMOJAPOCCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x533A9D0", Offset = "0x53393D0", VA = "0x18533A9D0")]
	private void JPCKHLEOFHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x5344210", Offset = "0x5342C10", VA = "0x185344210")]
	public CFBKFBIANBJ(int HBMOJAPOCCD, [Optional] PDJGHOJMNGM? DMDPLLOBMGL, [Optional] IEqualityComparer<TKey>? DIMOFBDOFGL, [Optional] ILMIKKLPMBN? NHKHPOCLCGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5342710", Offset = "0x5341110", VA = "0x185342710")]
	public CFBKFBIANBJ(TimeSpan LHGFNCGAJIP, [Optional] IEqualityComparer<TKey>? DIMOFBDOFGL, [Optional] ILMIKKLPMBN? NHKHPOCLCGD, [Optional] GOIJNKHANAB? NICIANOOHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5342CF0", Offset = "0x53416F0", VA = "0x185342CF0")]
	public CFBKFBIANBJ(int HBMOJAPOCCD, TimeSpan LHGFNCGAJIP, [Optional] IEqualityComparer<TKey>? DIMOFBDOFGL, [Optional] ILMIKKLPMBN? NHKHPOCLCGD, [Optional] GOIJNKHANAB? NICIANOOHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5343D90", Offset = "0x5342790", VA = "0x185343D90")]
	public CFBKFBIANBJ(int HBMOJAPOCCD, PDJGHOJMNGM? DMDPLLOBMGL, TimeSpan LHGFNCGAJIP, [Optional] IEqualityComparer<TKey>? DIMOFBDOFGL, [Optional] ILMIKKLPMBN? NHKHPOCLCGD, [Optional] GOIJNKHANAB? NICIANOOHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x533EED0", Offset = "0x533D8D0", VA = "0x18533EED0", Slot = "21")]
	public bool OJIPMCGCHMF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x533B500", Offset = "0x5339F00", VA = "0x18533B500", Slot = "22")]
	public bool KOEPAHMHNIA(int MPLHLKNKHIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x5334D40", Offset = "0x5333740", VA = "0x185334D40")]
	private bool EKMHBGKGICN(int MPLHLKNKHIM, OBLMGGKPFFM NDHIDCDGEGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x53386A0", Offset = "0x53370A0", VA = "0x1853386A0")]
	public void IDPEEMDPGBG(TKey JODEIIFHAPK, TVal CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x532D340", Offset = "0x532BD40", VA = "0x18532D340", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> EDKOAHIAMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x532CB90", Offset = "0x532B590", VA = "0x18532CB90", Slot = "9")]
	public void Add(TKey JODEIIFHAPK, TVal CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x532F7B0", Offset = "0x532E1B0", VA = "0x18532F7B0", Slot = "8")]
	public bool ContainsKey(TKey JODEIIFHAPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x5340340", Offset = "0x533ED40", VA = "0x185340340", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> EDKOAHIAMMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x533FD30", Offset = "0x533E730", VA = "0x18533FD30", Slot = "10")]
	public bool Remove(TKey JODEIIFHAPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x5340BA0", Offset = "0x533F5A0", VA = "0x185340BA0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> EDKOAHIAMMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x5336EF0", Offset = "0x53358F0", VA = "0x185336EF0")]
	private bool HEEACJBHFNF(TKey JODEIIFHAPK, [Out] TVal CLMKDBDPNNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x533F1E0", Offset = "0x533DBE0", VA = "0x18533F1E0")]
	private TVal PHNOCPFLPNG(TKey HEKNCDFGAEO)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x53410C0", Offset = "0x533FAC0", VA = "0x1853410C0", Slot = "11")]
	public bool TryGetValue(TKey HEKNCDFGAEO, [Out] TVal CLMKDBDPNNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x532F680", Offset = "0x532E080", VA = "0x18532F680", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x5330E50", Offset = "0x532F850", VA = "0x185330E50", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] FNCIFDCGDBA, int NPOJHGDDMDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x533A750", Offset = "0x5339150", VA = "0x18533A750")]
	private void JGDFKPAFEMI(TKey JODEIIFHAPK, TVal APKMEEHDCOG, OBLMGGKPFFM NDHIDCDGEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x53365E0", Offset = "0x5334FE0", VA = "0x1853365E0")]
	private bool FLBIJMNLJDM(OOFAHFEIAOD HFOJJNFOKMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x533B5B0", Offset = "0x5339FB0", VA = "0x18533B5B0")]
	private void LBPAEDAPMKO(LinkedListNode<OOFAHFEIAOD> EILDOKLJCEJ, TVal ANAJBMGGMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x532EFA0", Offset = "0x532D9A0", VA = "0x18532EFA0")]
	private void CFGPJGNDHFC(TKey JODEIIFHAPK, TVal CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x5338E40", Offset = "0x5337840", VA = "0x185338E40")]
	private void ILFBHEBOPDK(OOFAHFEIAOD HFOJJNFOKMB, TVal ANAJBMGGMGD, int FPICHGAHGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x5336950", Offset = "0x5335350", VA = "0x185336950", Slot = "19")]
	[IteratorStateMachine(typeof(CFBKFBIANBJ<, >.CKPBNGFMIOP))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5340E50", Offset = "0x533F850", VA = "0x185340E50", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public enum OBLMGGKPFFM : byte
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
public class FONFOGJLPHB<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly TKey KDCHKGEBJJD;

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x3D6E6F0", Offset = "0x3D6D0F0", VA = "0x183D6E6F0")]
	public FONFOGJLPHB(TKey EFHHDGCPJLA, Exception LBKPPFCANNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class KLOMEBJDLDK : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0D60", Offset = "0x5FBF760", VA = "0x185FC0D60")]
	public KLOMEBJDLDK(string MEBLNPKEJMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class IMDBOMPAFBK<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class NDPNGHMGGPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public IMDBOMPAFBK<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public NDPNGHMGGPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x46A33B0", Offset = "0x46A1DB0", VA = "0x1846A33B0")]
		internal Task<TResource> EIMPLFNCBFF(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct KMBCIHPDPOG : IAsyncStateMachine
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
		public IMDBOMPAFBK<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x438E9F0", Offset = "0x438D3F0", VA = "0x18438E9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x438F050", Offset = "0x438DA50", VA = "0x18438F050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private struct GLCEDMEPEKC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x3E30CA0", Offset = "0x3E2F6A0", VA = "0x183E30CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3E31380", Offset = "0x3E2FD80", VA = "0x183E31380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly DEPKNGCOLMA<TId, Task<TResource>> MDHFMKIIIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> IJCFAKKHEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? DLHGCMMCCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly Action<TResource>? HHGEGJMEAAC;

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x4025DA0", Offset = "0x40247A0", VA = "0x184025DA0")]
	public IMDBOMPAFBK(int GPFHCNENELE = 0, [Optional] IEqualityComparer<TId>? DJKGBAPKFPP, [Optional] Func<TId, CancellationToken, Task<TResource>>? DDLONLHNPAA, [Optional] Action<TResource>? KCCEMKLFPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x4024EE0", Offset = "0x40238E0", VA = "0x184024EE0")]
	public LMGHFFLKBKA<Task<TResource>> EFIOCLOBLMI(TId KFBALBFDDFF, [Optional] Func<TId, CancellationToken, Task<TResource>>? DDLONLHNPAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x4025820", Offset = "0x4024220", VA = "0x184025820")]
	private void KFMGNINKLBH(Task<TResource> CCAACFNOONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x4024CE0", Offset = "0x40236E0", VA = "0x184024CE0")]
	[AsyncStateMachine(typeof(IMDBOMPAFBK<, >.KMBCIHPDPOG))]
	private Task DMCONELEFIB(Task<TResource> CCAACFNOONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x4025690", Offset = "0x4024090", VA = "0x184025690")]
	public void FEPBBOLJLLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x40244A0", Offset = "0x4022EA0", VA = "0x1840244A0")]
	public DEPKNGCOLMA<TId, Task<TResource>>.LLGEBBOGBAG BPGPEIEKEPK()
	{
		return default(DEPKNGCOLMA<TId, Task<TResource>>.LLGEBBOGBAG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x4025C50", Offset = "0x4024650", VA = "0x184025C50", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x4025C50", Offset = "0x4024650", VA = "0x184025C50", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x4024880", Offset = "0x4023280", VA = "0x184024880")]
	[AsyncStateMachine(typeof(IMDBOMPAFBK<, >.GLCEDMEPEKC))]
	[CompilerGenerated]
	internal static Task DIMFKJAEOBC(Task<TResource> CCAACFNOONL, CancellationTokenSource KGHCPEGAHBM, Dictionary<Task<TResource>, CancellationTokenSource> KAHJGAPEHEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class DEPKNGCOLMA<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private sealed class GKHGHADFHCO : IEquatable<GKHGHADFHCO>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public readonly TValue GJBIHCLEEHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int IBPKLPMACFP;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xAFDEC0", Offset = "0xAFC8C0", VA = "0x180AFDEC0")]
		public GKHGHADFHCO(TValue CLMKDBDPNNH, int PNINOBAJNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3E2EA30", Offset = "0x3E2D430", VA = "0x183E2EA30", Slot = "4")]
		public bool Equals(GKHGHADFHCO? AIPFCMFLDKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3E2EAC0", Offset = "0x3E2D4C0", VA = "0x183E2EAC0", Slot = "0")]
		public override bool Equals(object? GIGIFGONEAO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3E2ED20", Offset = "0x3E2D720", VA = "0x183E2ED20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public struct LLGEBBOGBAG : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private Dictionary<TKey, GKHGHADFHCO>.Enumerator BAMJMOONNHH;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x4439090", Offset = "0x4437A90", VA = "0x184439090", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public (TKey Key, TValue Value, int RefCount) JOCMDMELDEE
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x4439460", Offset = "0x4437E60", VA = "0x184439460", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x4439390", Offset = "0x4437D90", VA = "0x184439390")]
		public LLGEBBOGBAG(DEPKNGCOLMA<TKey, TValue> EDBFMFKGPOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x4438C30", Offset = "0x4437630", VA = "0x184438C30", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x4438CF0", Offset = "0x44376F0", VA = "0x184438CF0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4438D30", Offset = "0x4437730", VA = "0x184438D30", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class NFLCJMHBKHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public DEPKNGCOLMA<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public GKHGHADFHCO refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public NFLCJMHBKHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x46ABFD0", Offset = "0x46AA9D0", VA = "0x1846ABFD0")]
		internal void EIMPLFNCBFF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly Dictionary<TKey, GKHGHADFHCO> LMKDGJJKAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly Func<TKey, TValue>? PCIAODAPLCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly Action<TValue>? JOMGFLOHGPI;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x5A5E310", Offset = "0x5A5CD10", VA = "0x185A5E310")]
	public DEPKNGCOLMA(int GPFHCNENELE = 0, [Optional] IEqualityComparer<TKey>? DIMOFBDOFGL, [Optional] Func<TKey, TValue>? LFNDCEODKLD, [Optional] Action<TValue>? CEOOONDMACA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x5A5CD20", Offset = "0x5A5B720", VA = "0x185A5CD20")]
	public LMGHFFLKBKA<TValue> EFIOCLOBLMI(TKey JODEIIFHAPK, [Optional] Func<TKey, TValue>? NGPEEJHFONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x5A5DFE0", Offset = "0x5A5C9E0", VA = "0x185A5DFE0")]
	private void NNFNKLLBHJI(TKey JODEIIFHAPK, GKHGHADFHCO FDPOOHEGCPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x5A5D6E0", Offset = "0x5A5C0E0", VA = "0x185A5D6E0")]
	public void FEPBBOLJLLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x5A5C990", Offset = "0x5A5B390", VA = "0x185A5C990")]
	public LLGEBBOGBAG BPGPEIEKEPK()
	{
		return default(LLGEBBOGBAG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x5A5E1D0", Offset = "0x5A5CBD0", VA = "0x185A5E1D0", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5A5E1D0", Offset = "0x5A5CBD0", VA = "0x185A5E1D0", Slot = "5")]
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
