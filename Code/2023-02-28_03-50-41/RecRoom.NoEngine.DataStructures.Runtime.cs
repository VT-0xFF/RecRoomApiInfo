using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x64A8130", Offset = "0x64A6B30", VA = "0x1864A8130")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6DC6F0", Offset = "0x6DB0F0", VA = "0x1806DC6F0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x90B660", Offset = "0x90A060", VA = "0x18090B660")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct NGAJJFDLJNN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly IDisposable[] FKGOKFODCII;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x897DB0", Offset = "0x8967B0", VA = "0x180897DB0")]
	public NGAJJFDLJNN(params IDisposable[] AHKJLELOIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xE211E0", Offset = "0xE1FBE0", VA = "0x180E211E0")]
	public static NGAJJFDLJNN EEKKKHPKBPD(params IDisposable[] AHKJLELOIMD)
	{
		return default(NGAJJFDLJNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x64A8010", Offset = "0x64A6A10", VA = "0x1864A8010", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct FCKMFJGALCC<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly IDisposable EAPMLLCMPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public T ACPLDDIHALN;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2899A70", Offset = "0x2898470", VA = "0x182899A70")]
	public FCKMFJGALCC(IDisposable IGMAFPJOAIE, in T MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2362A70", Offset = "0x2361470", VA = "0x182362A70")]
	public static global::FCKMFJGALCC<U> MBDPCCFHDIK<U>(in global::FCKMFJGALCC<T> IGMAFPJOAIE, in U MNIAGKNOHEJ)
	{
		return default(global::FCKMFJGALCC<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x28999E0", Offset = "0x28983E0", VA = "0x1828999E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class PPOPPDNDCAM
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4BD65F0", Offset = "0x4BD4FF0", VA = "0x184BD65F0")]
	public static global::FCKMFJGALCC<T> EEKKKHPKBPD<T>(IDisposable IGMAFPJOAIE, in T MNIAGKNOHEJ)
	{
		return default(global::FCKMFJGALCC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x23E8730", Offset = "0x23E7130", VA = "0x1823E8730")]
	public static global::FCKMFJGALCC<U> MBDPCCFHDIK<U, T>(in global::FCKMFJGALCC<T> OBLJLIKFFLC, in U MNIAGKNOHEJ)
	{
		return default(global::FCKMFJGALCC<U>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct JNODOOJGOHG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D00", Offset = "0x6C3700", VA = "0x1806C4D00")]
	public static JNODOOJGOHG KHECJIFKKPO(Type MAHAMGBPDNB, [Optional] string BINNBIKOGFD, [Optional] string KLEIMAKALGN, bool FACGHLKIICC = false)
	{
		return default(JNODOOJGOHG);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D00", Offset = "0x6C3700", VA = "0x1806C4D00")]
	public static JNODOOJGOHG KHECJIFKKPO<T>([Optional] string BINNBIKOGFD, [Optional] string KLEIMAKALGN, bool FACGHLKIICC = false)
	{
		return default(JNODOOJGOHG);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class PJMBHANDPHF
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static bool BLALJANDCBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly string CNOCNJBPEEN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public virtual PJMBHANDPHF HNILEGJPEME
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6C8170", Offset = "0x6C6B70", VA = "0x1806C8170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x64A8780", Offset = "0x64A7180", VA = "0x1864A8780")]
	protected PJMBHANDPHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract string GCAMGOIPAJL();

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x64A84D0", Offset = "0x64A6ED0", VA = "0x1864A84D0", Slot = "6")]
	public virtual string PBJMBHDCHPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x64A8550", Offset = "0x64A6F50", VA = "0x1864A8550")]
	public void PJDLJJPBMLP(StringBuilder JGCNNCLKHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x64A8350", Offset = "0x64A6D50", VA = "0x1864A8350")]
	public void JJAIEAKFFDF(StringBuilder JGCNNCLKHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x64A83B0", Offset = "0x64A6DB0", VA = "0x1864A83B0")]
	public void MDAMBOEBDHO(StringBuilder JGCNNCLKHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x64A81C0", Offset = "0x64A6BC0", VA = "0x1864A81C0")]
	public void IPJCBIJJAPK(StringBuilder JGCNNCLKHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x64A82B0", Offset = "0x64A6CB0", VA = "0x1864A82B0")]
	public static void JHMJMLOPEPG(StringBuilder JGCNNCLKHIA, string FNEFGEBNEDM, string LEIILLOMEJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6C8670", Offset = "0x6C7070", VA = "0x1806C8670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FOACPJDNGGL : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x64A7F30", Offset = "0x64A6930", VA = "0x1864A7F30")]
	public FOACPJDNGGL(string EJEIJOMMNGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class IPCKFPBEFIC<TErr> : FOACPJDNGGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly TErr KGKNGAPJNJM;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x23ACE60", Offset = "0x23AB860", VA = "0x1823ACE60")]
	private IPCKFPBEFIC(in TErr CKPDGPGOKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x23ACD90", Offset = "0x23AB790", VA = "0x1823ACD90")]
	public static global::IPCKFPBEFIC<TErr> EEKKKHPKBPD(in TErr CKPDGPGOKAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface AKLIDJJNIMC<out TOptions>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	TOptions ACPLDDIHALN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DGEDHMMCPHG
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	string COINMNPOJJF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class HFODDOMHNJB : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x64A7FA0", Offset = "0x64A69A0", VA = "0x1864A7FA0")]
	public HFODDOMHNJB(string EJEIJOMMNGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class OGGANMKOEOG<TOk> : HFODDOMHNJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly TOk NPJCHKMGBIP;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2EAC890", Offset = "0x2EAB290", VA = "0x182EAC890")]
	private OGGANMKOEOG(in TOk GLLICJLMGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x259D400", Offset = "0x259BE00", VA = "0x18259D400")]
	public static global::OGGANMKOEOG<TOk> EEKKKHPKBPD(in TOk GLLICJLMGJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct HJJOMCAHDKC<TOk, TErr> : IEquatable<global::HJJOMCAHDKC<TOk, TErr>>
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly EqualityComparer<TErr> PCHKHGCABDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly TErr KGKNGAPJNJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly TOk NPJCHKMGBIP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool HOEPPKBJHLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3BA85F0", Offset = "0x3BA6FF0", VA = "0x183BA85F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool NNGIGHGECEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3BA9040", Offset = "0x3BA7A40", VA = "0x183BA9040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3BAB250", Offset = "0x3BA9C50", VA = "0x183BAB250")]
	internal HJJOMCAHDKC(in TErr CKPDGPGOKAE, in TOk GLLICJLMGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3BA83B0", Offset = "0x3BA6DB0", VA = "0x183BA83B0")]
	public static global::HJJOMCAHDKC<TOk, TErr> KFFGDHDNHNI(in TErr CKPDGPGOKAE)
	{
		return default(global::HJJOMCAHDKC<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3BA6480", Offset = "0x3BA4E80", VA = "0x183BA6480")]
	public static global::HJJOMCAHDKC<TOk, TErr> DLICNNAHEMJ(in TOk GLLICJLMGJD)
	{
		return default(global::HJJOMCAHDKC<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2364B40", Offset = "0x2363540", VA = "0x182364B40")]
	public global::HJJOMCAHDKC<TOk, UErr> OHIFNFDPAFO<UErr>()
	{
		return default(global::HJJOMCAHDKC<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x23648D0", Offset = "0x23632D0", VA = "0x1823648D0")]
	public global::HJJOMCAHDKC<UOk, TErr> KHDMPOLDKAK<UOk>()
	{
		return default(global::HJJOMCAHDKC<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2364510", Offset = "0x2362F10", VA = "0x182364510")]
	public global::HJJOMCAHDKC<UOk, TErr> EHIHKKPDIED<UOk>()
	{
		return default(global::HJJOMCAHDKC<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2364A70", Offset = "0x2363470", VA = "0x182364A70")]
	public global::HJJOMCAHDKC<TOk, UErr> LAAPIOBCDAK<UErr>()
	{
		return default(global::HJJOMCAHDKC<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3BA5F30", Offset = "0x3BA4930", VA = "0x183BA5F30")]
	public global::HJJOMCAHDKC<OHKLLNGFCGP, TErr> AEJMAMEIHOC()
	{
		return default(global::HJJOMCAHDKC<OHKLLNGFCGP, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3BA9760", Offset = "0x3BA8160", VA = "0x183BA9760")]
	public static bool NENBKMMGKMN(in global::HJJOMCAHDKC<TOk, TErr> POBMLHBNLMA, in global::HJJOMCAHDKC<TOk, TErr> NMLIFIHDIKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3BA67C0", Offset = "0x3BA51C0", VA = "0x183BA67C0", Slot = "4")]
	public bool Equals(global::HJJOMCAHDKC<TOk, TErr> DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3BA6E40", Offset = "0x3BA5840", VA = "0x183BA6E40", Slot = "0")]
	public override bool Equals(object DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3BA7DA0", Offset = "0x3BA67A0", VA = "0x183BA7DA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3BAA840", Offset = "0x3BA9240", VA = "0x183BAA840", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class IDPFHHOCNLP
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2234650", Offset = "0x2233050", VA = "0x182234650")]
	public static global::HJJOMCAHDKC<TOk, TErr> NPJCHKMGBIP<TOk, TErr>(this in global::HJJOMCAHDKC<TOk, TErr> DCIIOIKIJFP, in TOk GLLICJLMGJD)
	{
		return default(global::HJJOMCAHDKC<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2234C70", Offset = "0x2233670", VA = "0x182234C70")]
	public static global::HJJOMCAHDKC<OHKLLNGFCGP, TErr> NPJCHKMGBIP<TErr>(this in global::HJJOMCAHDKC<OHKLLNGFCGP, TErr> DCIIOIKIJFP)
	{
		return default(global::HJJOMCAHDKC<OHKLLNGFCGP, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2234680", Offset = "0x2233080", VA = "0x182234680")]
	public static global::HJJOMCAHDKC<TOk, TErr> KGKNGAPJNJM<TOk, TErr>(this in global::HJJOMCAHDKC<TOk, TErr> DCIIOIKIJFP, in TErr CKPDGPGOKAE)
	{
		return default(global::HJJOMCAHDKC<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2233FD0", Offset = "0x22329D0", VA = "0x182233FD0")]
	public static TOk BGJGNLCDLJO<TOk, TErr>(this in global::HJJOMCAHDKC<TOk, TErr> DCIIOIKIJFP)
	{
		return (TOk)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2234140", Offset = "0x2232B40", VA = "0x182234140")]
	[AsyncStateMachine(typeof(AJOGHEOIHMI))]
	public static Task<TOk> HBFJPHPPPPE<TOk, TErr>(this Task<global::HJJOMCAHDKC<TOk, TErr>> DCIIOIKIJFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2235810", Offset = "0x2234210", VA = "0x182235810")]
	public static TErr PIIPMMAMDOF<TErr, TOk>(this in global::HJJOMCAHDKC<TOk, TErr> DCIIOIKIJFP)
	{
		return (TErr)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x22350C0", Offset = "0x2233AC0", VA = "0x1822350C0")]
	public static bool OPCFEGPINJN<TOk, TErr, UErr, UOk>(this in global::HJJOMCAHDKC<TOk, TErr> DCIIOIKIJFP, out global::HJJOMCAHDKC<UOk, UErr> JBCGENPNPEM) where TErr : UErr
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2234100", Offset = "0x2232B00", VA = "0x182234100")]
	public static bool FGJNCINNLJC<TOk, TErr>(this in global::HJJOMCAHDKC<TOk, TErr> DCIIOIKIJFP, out TOk GLLICJLMGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2234750", Offset = "0x2233150", VA = "0x182234750")]
	public static bool KHAELOJEELL<TOk, TErr>(this in global::HJJOMCAHDKC<TOk, TErr> DCIIOIKIJFP, out TErr CKPDGPGOKAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2234870", Offset = "0x2233270", VA = "0x182234870")]
	public static bool KPOBADELKNL<TOk, TErr>(this in global::HJJOMCAHDKC<TOk, TErr> DCIIOIKIJFP, out TOk GLLICJLMGJD, out TErr CKPDGPGOKAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x22347D0", Offset = "0x22331D0", VA = "0x1822347D0")]
	public static bool KNLLFFFGKKE<TOk, TErr>(this in global::HJJOMCAHDKC<TOk, TErr> DCIIOIKIJFP, out TOk GLLICJLMGJD, out global::HJJOMCAHDKC<TOk, TErr> JBCGENPNPEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2235570", Offset = "0x2233F70", VA = "0x182235570")]
	public static bool OPCFEGPINJN<TOk, TErr, UErr, UOk>(this in global::HJJOMCAHDKC<TOk, TErr> DCIIOIKIJFP, out TOk GLLICJLMGJD, out global::HJJOMCAHDKC<UOk, UErr> JBCGENPNPEM) where TErr : UErr
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x22349B0", Offset = "0x22333B0", VA = "0x1822349B0")]
	public static bool LANNIJCCJPJ<TOk, TErr>(this in global::HJJOMCAHDKC<TOk, TErr> DCIIOIKIJFP, out TOk GLLICJLMGJD, out global::HJJOMCAHDKC<OHKLLNGFCGP, TErr> JBCGENPNPEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2234EC0", Offset = "0x22338C0", VA = "0x182234EC0")]
	public static global::HJJOMCAHDKC<UOk, UErr> OLDFMLHKEJF<UOk, UErr, TOk, TErr>(this in global::HJJOMCAHDKC<TOk, TErr> DCIIOIKIJFP, in global::HJJOMCAHDKC<UOk, UErr> PAGKANKNAEA) where TOk : UOk where TErr : UErr
	{
		return default(global::HJJOMCAHDKC<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x22343A0", Offset = "0x2232DA0", VA = "0x1822343A0")]
	public static global::HJJOMCAHDKC<TOk[], TErr> IOLFOMIMDLF<TOk, TErr>(this IEnumerable<global::HJJOMCAHDKC<TOk, TErr>> DCIIOIKIJFP)
	{
		return default(global::HJJOMCAHDKC<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2234040", Offset = "0x2232A40", VA = "0x182234040")]
	[IteratorStateMachine(typeof(LOOCJEJFHMA))]
	public static IEnumerable<TOk> BHFENGCEMIN<TOk, TErr>(this IEnumerable<global::HJJOMCAHDKC<TOk, TErr>> DCIIOIKIJFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class NIKLEFPJCMN<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2800A60", Offset = "0x27FF460", VA = "0x182800A60")]
	public static global::HJJOMCAHDKC<TOk, T> NPJCHKMGBIP<TOk>(in TOk GLLICJLMGJD)
	{
		return default(global::HJJOMCAHDKC<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2317D00", Offset = "0x2316700", VA = "0x182317D00")]
	public static global::HJJOMCAHDKC<OHKLLNGFCGP, T> NPJCHKMGBIP()
	{
		return default(global::HJJOMCAHDKC<OHKLLNGFCGP, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2800B20", Offset = "0x27FF520", VA = "0x182800B20")]
	public static global::HJJOMCAHDKC<T, TErr> KGKNGAPJNJM<TErr>(in TErr CKPDGPGOKAE)
	{
		return default(global::HJJOMCAHDKC<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public sealed class JEJNFIMCEIB<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private readonly struct CJLJIEHCFHC : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly global::JEJNFIMCEIB<T> FJIFGABMBPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly int EGMMBHLBCAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly bool BBPFHPENBJB;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x24E3A50", Offset = "0x24E2450", VA = "0x1824E3A50")]
		public CJLJIEHCFHC(global::JEJNFIMCEIB<T> GCIFBDHGBMN, int OKEAICNJOEL, bool OJAMOBNEIBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x24E3920", Offset = "0x24E2320", VA = "0x1824E3920")]
		public global::JEJNFIMCEIB<T>.EOMBBMMPNID OGILHMGHFKK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x24E3A10", Offset = "0x24E2410", VA = "0x1824E3A10", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x24E3A10", Offset = "0x24E2410", VA = "0x1824E3A10", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class EOMBBMMPNID : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly global::JEJNFIMCEIB<T> FJIFGABMBPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly int BMJOEHFAHGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private int PCLEDLDMHJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly bool BBPFHPENBJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool OEOLNLMCABA;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public T PKICFDONLKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x17A4F10", Offset = "0x17A3910", VA = "0x1817A4F10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x17A5180", Offset = "0x17A3B80", VA = "0x1817A5180", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x17A52C0", Offset = "0x17A3CC0", VA = "0x1817A52C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x17A56C0", Offset = "0x17A40C0", VA = "0x1817A56C0")]
		public EOMBBMMPNID(global::JEJNFIMCEIB<T> GCIFBDHGBMN, int OKEAICNJOEL, bool OJAMOBNEIBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x17A5000", Offset = "0x17A3A00", VA = "0x1817A5000", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x17A5080", Offset = "0x17A3A80", VA = "0x1817A5080", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class CFMHOEMIDIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x680D70", Offset = "0x680170")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
		public CFMHOEMIDIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x37A9500", Offset = "0x37A7F00", VA = "0x1837A9500")]
		internal T <.ctor>b__0(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly T[] DBNHJOBCMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private int PCLEDLDMHJB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int BAFLABLGFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x30BA130", Offset = "0x30B8B30", VA = "0x1830BA130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public T PKICFDONLKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x29FAD50", Offset = "0x29F9750", VA = "0x1829FAD50")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T HIKMHHABHLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x30BA100", Offset = "0x30B8B00", VA = "0x1830BA100")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public T NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x30BA040", Offset = "0x30B8A40", VA = "0x1830BA040")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int GBJCKAFHMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8951F0", Offset = "0x893BF0", VA = "0x1808951F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x30BA170", Offset = "0x30B8B70", VA = "0x1830BA170")]
	private static int GIPIKMBEIPJ(int GFDMFLGCBKB, int KHNOOLPHJPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x30BA440", Offset = "0x30B8E40", VA = "0x1830BA440")]
	public JEJNFIMCEIB(int HGBOOPNCHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x30BA2F0", Offset = "0x30B8CF0", VA = "0x1830BA2F0")]
	public JEJNFIMCEIB(int HGBOOPNCHBL, Func<T> GABJPNJMPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x30BA4C0", Offset = "0x30B8EC0", VA = "0x1830BA4C0")]
	public JEJNFIMCEIB(T[] AHKJLELOIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x30BA190", Offset = "0x30B8B90", VA = "0x1830BA190")]
	public void LHMFBCPGIPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x30BA1C0", Offset = "0x30B8BC0", VA = "0x1830BA1C0")]
	public IEnumerable<T> OAKNBPPMBCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x30BA270", Offset = "0x30B8C70", VA = "0x1830BA270")]
	public global::JEJNFIMCEIB<T>.EOMBBMMPNID OGILHMGHFKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x235FD40", Offset = "0x235E740", VA = "0x18235FD40", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x235FD40", Offset = "0x235E740", VA = "0x18235FD40", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class IGHEDLBADIL
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2236900", Offset = "0x2235300", VA = "0x182236900")]
	public static global::JEJNFIMCEIB<T> EEKKKHPKBPD<T>(int HGBOOPNCHBL, Func<T> GABJPNJMPID) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class DFGBEGKCIOD<TData> : PJMBHANDPHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly string BOOIHLDBGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly TData EMKMBIALDJA;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "5")]
	public override string GCAMGOIPAJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2593E80", Offset = "0x2592880", VA = "0x182593E80")]
	internal DFGBEGKCIOD(string EJEIJOMMNGK, in TData NIPBPKPBPPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class DEKMEKFAEMC
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x64A7EC0", Offset = "0x64A68C0", VA = "0x1864A7EC0")]
	public static global::DFGBEGKCIOD<OHKLLNGFCGP> EEKKKHPKBPD(string EJEIJOMMNGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1D63130", Offset = "0x1D61B30", VA = "0x181D63130")]
	public static global::DFGBEGKCIOD<TData> EEKKKHPKBPD<TData>(string EJEIJOMMNGK, in TData NIPBPKPBPPP)
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
