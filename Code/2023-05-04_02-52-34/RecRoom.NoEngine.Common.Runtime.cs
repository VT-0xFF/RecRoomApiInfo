using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
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
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69B38B0", Offset = "0x69B2CB0", VA = "0x1869B38B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x730090", Offset = "0x72F490", VA = "0x180730090")]
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
		[Cpp2IlInjected.Address(RVA = "0x9CC120", Offset = "0x9CB520", VA = "0x1809CC120")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class AEINHFCGMKD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly EqualityComparer<T> AMJMOCOLEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public T NDNOLKCBONM;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2B98CF0", Offset = "0x2B980F0", VA = "0x182B98CF0")]
	public AEINHFCGMKD(in T LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2B98770", Offset = "0x2B97B70", VA = "0x182B98770", Slot = "0")]
	public override bool Equals(object NBNOMDAKOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2B98950", Offset = "0x2B97D50", VA = "0x182B98950", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2B98B80", Offset = "0x2B97F80", VA = "0x182B98B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate)]
public class OAEAKFOOKJJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0")]
	public OAEAKFOOKJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
public class KCDCAGLMLEB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0")]
	public KCDCAGLMLEB(string DEONPOEKLKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class FKCOEDAALNM
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x261EAB0", Offset = "0x261DEB0", VA = "0x18261EAB0")]
	public static MMDBLFNKKAG EIJEIEDIKBI<T>()
	{
		return default(MMDBLFNKKAG);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x261ED60", Offset = "0x261E160", VA = "0x18261ED60")]
	public static MMDBLFNKKAG MCAPDIFBJEA<T>([CallerMemberName] string AMNLGEBHFHK = "") where T : notnull
	{
		return default(MMDBLFNKKAG);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x261EA20", Offset = "0x261DE20", VA = "0x18261EA20")]
	public static MMDBLFNKKAG EIJEIEDIKBI<T>(this T PJEHHDIBMKL) where T : notnull
	{
		return default(MMDBLFNKKAG);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x261EB40", Offset = "0x261DF40", VA = "0x18261EB40")]
	public static MMDBLFNKKAG FKGMENCBGIB<T>(this T PJEHHDIBMKL, [CallerMemberName] string AMNLGEBHFHK = "") where T : notnull
	{
		return default(MMDBLFNKKAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x261ECC0", Offset = "0x261E0C0", VA = "0x18261ECC0")]
	public static MMDBLFNKKAG MCAPDIFBJEA<T>(this T INHKNJBCCPD, [CallerMemberName] string AMNLGEBHFHK = "") where T : notnull
	{
		return default(MMDBLFNKKAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x69B13D0", Offset = "0x69B07D0", VA = "0x1869B13D0")]
	public static MMDBLFNKKAG MCAPDIFBJEA(string CPIGPDBOGNE, [CallerMemberName] string AMNLGEBHFHK = "")
	{
		return default(MMDBLFNKKAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x69B1310", Offset = "0x69B0710", VA = "0x1869B1310")]
	public static string KLAEAEAADJD(this object INHKNJBCCPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[OAEAKFOOKJJ]
public delegate long DAELIJIIBOG();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class PHFOFNGNANO
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static CLJIMOLIMCP MPOJOJAAFLD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static CLJIMOLIMCP IEEHDHOMAIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x69B4550", Offset = "0x69B3950", VA = "0x1869B4550")]
		get
		{
			return default(CLJIMOLIMCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static ICDJBKHKFDL JKIDCLKOGCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x69B4360", Offset = "0x69B3760", VA = "0x1869B4360")]
		get
		{
			return default(ICDJBKHKFDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static MDABJEJPBAA NKPIENCKIEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x69B45B0", Offset = "0x69B39B0", VA = "0x1869B45B0")]
		get
		{
			return default(MDABJEJPBAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x69B4920", Offset = "0x69B3D20", VA = "0x1869B4920")]
	public static void OCIIKEBAJAD(in CLJIMOLIMCP MNBALFJGNMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x69B43C0", Offset = "0x69B37C0", VA = "0x1869B43C0")]
	public static void BMBLFHKAJNC(string BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x69B4870", Offset = "0x69B3C70", VA = "0x1869B4870")]
	public static void MCFEJMHAGOD(string BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x25C47F0", Offset = "0x25C3BF0", VA = "0x1825C47F0")]
	public static void MCFEJMHAGOD<T>(T HACNEHKIBDN, global::CHBEDDIAGPD<T> BALNMHDNCIN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x69B47F0", Offset = "0x69B3BF0", VA = "0x1869B47F0")]
	public static void LEOIFHKKJAG(Exception MEIDENAJCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x69B4770", Offset = "0x69B3B70", VA = "0x1869B4770")]
	public static string KLAEAEAADJD(object NBNOMDAKOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x69B4700", Offset = "0x69B3B00", VA = "0x1869B4700")]
	public static long IJDNAANDOLB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x69B4470", Offset = "0x69B3870", VA = "0x1869B4470")]
	public static bool CCNBNHFEJFD(bool LAGGEGOCCOE, string BALNMHDNCIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x69B4610", Offset = "0x69B3A10", VA = "0x1869B4610")]
	public static double FACKMMNGNEJ()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct CLJIMOLIMCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly ICDJBKHKFDL JKIDCLKOGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly MDABJEJPBAA NKPIENCKIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly BPMDFAAGKNC PIBOMJMPJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly DAELIJIIBOG BJNGDNNGEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly OLOFAEHKGMO KHEFKBDMONG;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly BPMDFAAGKNC DAEIEKPGMBF;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly DAELIJIIBOG CCIHLBJLIHB;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly OLOFAEHKGMO ELMMBCKACIC;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly CLJIMOLIMCP IDMILJKGOPO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool JEJILLMBCFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x69B0DD0", Offset = "0x69B01D0", VA = "0x1869B0DD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x69B1280", Offset = "0x69B0680", VA = "0x1869B1280")]
	public CLJIMOLIMCP(in ICDJBKHKFDL IKEMEFMEOLL, in MDABJEJPBAA GIIGEMAJFJJ, BPMDFAAGKNC LKCPGIJDJLP, DAELIJIIBOG AMOLIOCAMGN, OLOFAEHKGMO NMNAGDKJIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x69B0F10", Offset = "0x69B0310", VA = "0x1869B0F10")]
	private static string HKFGCMPMFBN(object NBNOMDAKOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x72F5A0", Offset = "0x72E9A0", VA = "0x18072F5A0")]
	private static long GBEHKJLAPBG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7532F0", Offset = "0x7526F0", VA = "0x1807532F0")]
	private static string HMGPIBHMDHD(string ADAJMBMBPKM, string? OGGIMIMNPIL, bool GGJOAAPMNOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x69B0CB0", Offset = "0x69B00B0", VA = "0x1869B0CB0")]
	private static CLJIMOLIMCP FEDNMKCFCHK()
	{
		return default(CLJIMOLIMCP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CGIDKFOHJJN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IGJKOGMIHOL(in T MPHACEGLFIL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public delegate void AAKNJOPMLDI<T>(in T HACNEHKIBDN);
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class NHGEJMFALIP
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x28333B0", Offset = "0x28327B0", VA = "0x1828333B0")]
	public static bool IGJKOGMIHOL<T, U>(in T INHKNJBCCPD, in U NBNOMDAKOCG) where T : notnull, global::CGIDKFOHJJN<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public delegate TResult INNEBAAKBEC<T, out TResult>(in T HACNEHKIBDN);
[Cpp2IlInjected.Token(Token = "0x2000010")]
public delegate TResult IKJGILGEHCB<T1, T2, out TResult>(in T1 LPMLGHGHOBD, in T2 EPACCBAPBHK);
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct PDFKBNNABNH<T> : IEquatable<global::PDFKBNNABNH<T>>, global::CGIDKFOHJJN<global::PDFKBNNABNH<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly T NDNOLKCBONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly int CMHFEELAEBD;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1D05A80", Offset = "0x1D04E80", VA = "0x181D05A80")]
	public PDFKBNNABNH(in T LPJDDLMPNCG, int EGNHJGKABLC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x284BF20", Offset = "0x284B320", VA = "0x18284BF20")]
	public static bool BOBJELOEACN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DFA00", Offset = "0x6DEE00")] in global::PDFKBNNABNH<T> LJLKLAFAGNO, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DFA70", Offset = "0x6DEE70")] in global::PDFKBNNABNH<T> HFBAHIGFPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x284C270", Offset = "0x284B670", VA = "0x18284C270", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DFAE0", Offset = "0x6DEEE0")] global::PDFKBNNABNH<T> MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x284C1E0", Offset = "0x284B5E0", VA = "0x18284C1E0", Slot = "0")]
	public override bool Equals(object MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x284C770", Offset = "0x284BB70", VA = "0x18284C770")]
	public bool IGJKOGMIHOL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DFB40", Offset = "0x6DEF40")] in global::PDFKBNNABNH<T> MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x284C6B0", Offset = "0x284BAB0", VA = "0x18284C6B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x284D520", Offset = "0x284C920", VA = "0x18284D520", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x284CD70", Offset = "0x284C170", VA = "0x18284CD70")]
	public void LOCCMPKKMAH(out T LPJDDLMPNCG, out int EGNHJGKABLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x284D040", Offset = "0x284C440", VA = "0x18284D040")]
	public (T, int) NNKANILJCKH()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x284C190", Offset = "0x284B590", VA = "0x18284C190", Slot = "5")]
	private bool DKDADOLJFKP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DFBB0", Offset = "0x6DEFB0")] in global::PDFKBNNABNH<T> MPHACEGLFIL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class JPANKJLCPML
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1EF19A0", Offset = "0x1EF0DA0", VA = "0x181EF19A0")]
	public static global::PDFKBNNABNH<T> GILBACJLDCL<T>(in T LPJDDLMPNCG, int EGNHJGKABLC) where T : notnull
	{
		return default(global::PDFKBNNABNH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public readonly struct ICDJBKHKFDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly CKDHDEHAKOM OHBMGMPFJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly HFIHBEEFHHM CPLJMGBGELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly CKDHDEHAKOM CBADCEKKPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly HFIHBEEFHHM BLKBKDKCPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly CKDHDEHAKOM KBOHACCCNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly HFIHBEEFHHM GCPBAEJLDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly EAKMOHAKKAJ ONMJLIOEHKM;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly CKDHDEHAKOM KGNJOGELKLM;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly HFIHBEEFHHM HMGJGNBHLHB;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly CKDHDEHAKOM EAFMPOBIMJF;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly HFIHBEEFHHM GGEJMMMLFKC;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly CKDHDEHAKOM GKFFHLKIFHI;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly HFIHBEEFHHM HOCOOPHKOBI;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly EAKMOHAKKAJ DNKCOEIBFEI;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly ICDJBKHKFDL IDMILJKGOPO;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static readonly CKDHDEHAKOM JDEOKOLJCMP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool JEJILLMBCFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x69B1680", Offset = "0x69B0A80", VA = "0x1869B1680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x11B2940", Offset = "0x11B1D40", VA = "0x1811B2940")]
	public ICDJBKHKFDL(CKDHDEHAKOM EDMJKAIKKEB, HFIHBEEFHHM CFOMHHCOHGN, CKDHDEHAKOM MMCOODNLPCJ, HFIHBEEFHHM OOGAJJAJGFN, CKDHDEHAKOM FDHJKGJLEPH, HFIHBEEFHHM AGGOFMDLOMN, EAKMOHAKKAJ LBKFHJNANDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x72E820", Offset = "0x72DC20", VA = "0x18072E820")]
	private static bool POEBKPCJEEP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	private static void NPKEDHGIBKP(string BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x72E820", Offset = "0x72DC20", VA = "0x18072E820")]
	private static bool JLEONHNGCGL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	private static void DIDKFPHAGEM(string BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x72E820", Offset = "0x72DC20", VA = "0x18072E820")]
	private static bool OOPCMILKAOL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	private static void NIKOCIELLHP(string BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	private static void ACIPOBIOKBB(Exception MEIDENAJCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x69B1540", Offset = "0x69B0940", VA = "0x1869B1540")]
	private static ICDJBKHKFDL FEDNMKCFCHK()
	{
		return default(ICDJBKHKFDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7359E0", Offset = "0x734DE0", VA = "0x1807359E0")]
	private static bool LLNBEAGCHEN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x69B1450", Offset = "0x69B0850", VA = "0x1869B1450")]
	public void BMBLFHKAJNC(object BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x69B18E0", Offset = "0x69B0CE0", VA = "0x1869B18E0")]
	public void MCFEJMHAGOD(object BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x69B18C0", Offset = "0x69B0CC0", VA = "0x1869B18C0")]
	public void LEOIFHKKJAG(Exception MEIDENAJCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1DBE110", Offset = "0x1DBD510", VA = "0x181DBE110")]
	public void MCFEJMHAGOD<T>(T HACNEHKIBDN, global::CHBEDDIAGPD<T> BALNMHDNCIN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1DBE010", Offset = "0x1DBD410", VA = "0x181DBE010")]
	public void BMBLFHKAJNC<T>(in T HACNEHKIBDN, global::NHNMGAOEOBN<T> BALNMHDNCIN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x69B14C0", Offset = "0x69B08C0", VA = "0x1869B14C0")]
	public bool CCNBNHFEJFD(bool LAGGEGOCCOE, string BALNMHDNCIN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct MMDBLFNKKAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly string NDNOLKCBONM;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x982140", Offset = "0x981540", VA = "0x180982140")]
	public MMDBLFNKKAG(string LPJDDLMPNCG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x74C840", Offset = "0x74BC40", VA = "0x18074C840")]
	public static string HPHCHABBDNG(in MMDBLFNKKAG INHKNJBCCPD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xC51DD0", Offset = "0xC511D0", VA = "0x180C51DD0")]
	public static MMDBLFNKKAG HPHCHABBDNG(string MPHACEGLFIL)
	{
		return default(MMDBLFNKKAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x69B3550", Offset = "0x69B2950", VA = "0x1869B3550")]
	public string GCBEILMLFND(string NKKEIKGKIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x69B35A0", Offset = "0x69B29A0", VA = "0x1869B35A0")]
	public string JIHKCAIJPLG(object IOENONLLAKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x74C840", Offset = "0x74BC40", VA = "0x18074C840", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct JAPIHNFIDBB : IEquatable<JAPIHNFIDBB>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7359E0", Offset = "0x734DE0", VA = "0x1807359E0", Slot = "4")]
	public bool Equals(JAPIHNFIDBB MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x69B2DF0", Offset = "0x69B21F0", VA = "0x1869B2DF0", Slot = "0")]
	public override bool Equals(object MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x69B2E40", Offset = "0x69B2240", VA = "0x1869B2E40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x69B2E50", Offset = "0x69B2250", VA = "0x1869B2E50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[JMOGFODMLAN("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct DBEIBEIIMCM<T> : IEquatable<global::DBEIBEIIMCM<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T NDNOLKCBONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly bool IAFMPCFNEPA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool BBPENECPNBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x299AA80", Offset = "0x2999E80", VA = "0x18299AA80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x299AFC0", Offset = "0x299A3C0", VA = "0x18299AFC0")]
	public DBEIBEIIMCM(in T LPJDDLMPNCG, bool NKOHEMBMFOO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2999B00", Offset = "0x2998F00", VA = "0x182999B00")]
	public static bool BOBJELOEACN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DFCD0", Offset = "0x6DF0D0")] in global::DBEIBEIIMCM<T> LJLKLAFAGNO, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DFD40", Offset = "0x6DF140")] in global::DBEIBEIIMCM<T> HFBAHIGFPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x284C300", Offset = "0x284B700", VA = "0x18284C300", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DFDB0", Offset = "0x6DF1B0")] global::DBEIBEIIMCM<T> MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2999E20", Offset = "0x2999220", VA = "0x182999E20", Slot = "0")]
	public override bool Equals(object MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x299A6F0", Offset = "0x2999AF0", VA = "0x18299A6F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x299ACD0", Offset = "0x299A0D0", VA = "0x18299ACD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class JDHOCJKBEGN
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x21089E0", Offset = "0x2107DE0", VA = "0x1821089E0")]
	public static global::DBEIBEIIMCM<T> CDBEPIFNCBJ<T>(in T LPJDDLMPNCG) where T : notnull
	{
		return default(global::DBEIBEIIMCM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2108B50", Offset = "0x2107F50", VA = "0x182108B50")]
	public static global::DBEIBEIIMCM<T?> HIHPEHJNIJF<T>()
	{
		return default(global::DBEIBEIIMCM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2108AE0", Offset = "0x2107EE0", VA = "0x182108AE0")]
	public static bool GDKAAPPNNPL<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DFE50", Offset = "0x6DF250")] this in global::DBEIBEIIMCM<T> KOFANCICHCF, [MNKKOBAPPBG(true)] out T LPJDDLMPNCG) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct MDABJEJPBAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly JMNOAIEFILJ LKLFHOIKFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly ODIEBNEIKHK JCGCCIHBEDI;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly JMNOAIEFILJ BEAAAFPAKMM;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly ODIEBNEIKHK FLBKKCLEJAM;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly MDABJEJPBAA IDMILJKGOPO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool JEJILLMBCFE
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x69B31D0", Offset = "0x69B25D0", VA = "0x1869B31D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0F0", Offset = "0x7EA4F0", VA = "0x1807EB0F0")]
	public MDABJEJPBAA(JMNOAIEFILJ PMABJGDDFKI, ODIEBNEIKHK DDLGCIPPMDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	private static void JMJCGGAOONL(string AMNLGEBHFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	private static void DFICCFBDKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x69B3140", Offset = "0x69B2540", VA = "0x1869B3140")]
	private static MDABJEJPBAA FEDNMKCFCHK()
	{
		return default(MDABJEJPBAA);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class MEPGMFLPCAL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct NAKHNGMDOAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Task selfInternal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x69B36A0", Offset = "0x69B2AA0", VA = "0x1869B36A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x69B3860", Offset = "0x69B2C60", VA = "0x1869B3860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x69B3430", Offset = "0x69B2830", VA = "0x1869B3430")]
	public static Task<TaskStatus> BEGKEPCPIFN(this Task INHKNJBCCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x23B8A50", Offset = "0x23B7E50", VA = "0x1823B8A50")]
	public static Task<T> NBGIBBBKNNO<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x23B84F0", Offset = "0x23B78F0", VA = "0x1823B84F0")]
	public static Task<TResult> MOAGHGPKFCB<TResult>(this Task<TResult> IBCOHPONNBJ, CancellationToken MIFCLBEAOPM) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x69B3430", Offset = "0x69B2830", VA = "0x1869B3430")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(NAKHNGMDOAG))]
	internal static Task<TaskStatus> GFELBDAGACJ(Task ILCMPPBLJKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[AttributeUsage(AttributeTargets.Class)]
public class OPDDIGNOJMD : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0")]
	public OPDDIGNOJMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class BOOCPGKCEDP : ABKKMACBPPJ
{
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly ABKKMACBPPJ AGBLMGNNIDO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public DateTime LDLMCHDJNFI
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x69B0960", Offset = "0x69AFD60", VA = "0x1869B0960", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public BOOCPGKCEDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface ABKKMACBPPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	DateTime LDLMCHDJNFI
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class OHGHBAEEHON
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public static long GPIBKBKNACG
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x69B3A00", Offset = "0x69B2E00", VA = "0x1869B3A00")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static long OJPKLBFEFNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x69B3F60", Offset = "0x69B3360", VA = "0x1869B3F60")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static double EMDBFGCEAID
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x69B3E00", Offset = "0x69B3200", VA = "0x1869B3E00")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static double IMOCGIEENIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x69B3B70", Offset = "0x69B2F70", VA = "0x1869B3B70")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static double GIJMCFEDPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x69B3A60", Offset = "0x69B2E60", VA = "0x1869B3A60")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static double MLEAENEAGIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x69B3CF0", Offset = "0x69B30F0", VA = "0x1869B3CF0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x69B3940", Offset = "0x69B2D40", VA = "0x1869B3940")]
	public static double AHGCKEFAADB(long LKGEHBHECOH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x69B3D50", Offset = "0x69B3150", VA = "0x1869B3D50")]
	public static double MNBIAMELNIJ(long LKGEHBHECOH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x69B3AC0", Offset = "0x69B2EC0", VA = "0x1869B3AC0")]
	public static double ELGJFGAADGC(double OCCBDPDIAKC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x69B3BD0", Offset = "0x69B2FD0", VA = "0x1869B3BD0")]
	public static long FOGOBFJFFHC(long ONPCMEEMBBB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x69B39F0", Offset = "0x69B2DF0", VA = "0x1869B39F0")]
	public static long BNOCAOMAPLE(long PGCLIDGDKOP, long IHLFIIPPMCG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x69B3E60", Offset = "0x69B3260", VA = "0x1869B3E60")]
	public static double PGDHKMKNGGB(long PGCLIDGDKOP, long IHLFIIPPMCG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x69B3C80", Offset = "0x69B3080", VA = "0x1869B3C80")]
	public static double GPLAFBMEHCM(long PGCLIDGDKOP, long IHLFIIPPMCG)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class KMDOMJJDNBM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Timer MJOCLEMBKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly TimeSpan AOEGDFNBHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Action KOCMCABLOKN;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x69B3010", Offset = "0x69B2410", VA = "0x1869B3010")]
	public KMDOMJJDNBM(TimeSpan AOEGDFNBHBG, Action KOCMCABLOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x11D4290", Offset = "0x11D3690", VA = "0x1811D4290")]
	private void IDJNJBDMPKP(object OJNFGJAPBNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x69B2F80", Offset = "0x69B2380", VA = "0x1869B2F80")]
	public void LEOAKEBKNCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x69B2F60", Offset = "0x69B2360", VA = "0x1869B2F60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[AttributeUsage(AttributeTargets.All)]
public class JMOGFODMLAN : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly string EHENDBJBIEO;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x730090", Offset = "0x72F490", VA = "0x180730090")]
	public JMOGFODMLAN(string NFBKGEMICGO)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct ILKKJFENGDG : IEquatable<ILKKJFENGDG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public uint PFMEHGKPABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public int HGJCGLPMNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float GCCPANJGKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public ushort JFGOOHILHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public ushort BDDOIMMHLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public short GBEHLAHMPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public short AOGAAIENIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public char EGLAAFBBLLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public char HDOJDBLBGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public byte JHFKLKNOJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public byte HGAKOODHOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public byte MGOOCINBJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public byte ACAMAOFKCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool CDBFNIBOLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public bool DPOGBJGLLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public bool DFCLOAGKEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public bool FFMHIPPBDKA;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x879A10", Offset = "0x878E10", VA = "0x180879A10")]
	public static ILKKJFENGDG BGNFIAFBOON(uint IMOFGDNKKHM)
	{
		return default(ILKKJFENGDG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x879A10", Offset = "0x878E10", VA = "0x180879A10")]
	public static ILKKJFENGDG CBPINDFNNKG(int ADIIEHCPIOH)
	{
		return default(ILKKJFENGDG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1A8C4C0", Offset = "0x1A8B8C0", VA = "0x181A8C4C0")]
	public static ILKKJFENGDG OAEOJADLCKI(float FAFLBHPJLJL)
	{
		return default(ILKKJFENGDG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x69B1DD0", Offset = "0x69B11D0", VA = "0x1869B1DD0")]
	public static ILKKJFENGDG CCJLMMLKKFA(byte PMLPJPAINEC, byte KHEBDMGDLCG, byte NAOFLAKDDMO, byte IFGNHNABEGP)
	{
		return default(ILKKJFENGDG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x69B1DD0", Offset = "0x69B11D0", VA = "0x1869B1DD0")]
	public static ILKKJFENGDG FHEMGEHDJAL(bool LDBJPNHAFHO, bool JDAPFGOLDIC, bool FDDAEPCLFFI, bool OCDMHCGCLAC)
	{
		return default(ILKKJFENGDG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x11369F0", Offset = "0x1135DF0", VA = "0x1811369F0")]
	public static bool BOBJELOEACN(ILKKJFENGDG GBEJHLEFDJM, ILKKJFENGDG BDGBOHJLNIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x877E40", Offset = "0x877240", VA = "0x180877E40", Slot = "4")]
	public bool Equals(ILKKJFENGDG MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x69B1DF0", Offset = "0x69B11F0", VA = "0x1869B1DF0", Slot = "0")]
	public override bool Equals(object NBNOMDAKOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x9B2980", Offset = "0x9B1D80", VA = "0x1809B2980", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x69B1E70", Offset = "0x69B1270", VA = "0x1869B1E70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct AFIMEHDDHLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public ulong CJDMJPOKMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public long IEOOBBCAKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public double PNIJGBAIAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public uint CDPEKOMOMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public uint IPMMOBAPHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int FPHDDOOCHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public int NBMJLINNNBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public float NJKPPFOMPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public float OGGMKCAECPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public ushort JFGOOHILHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public ushort BDDOIMMHLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public ushort DBILBLJKCDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public ushort OIBHKCOCOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public short GBEHLAHMPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public short AOGAAIENIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public short FHKCJEPEOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public short GLLDAPFLOOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public char EGLAAFBBLLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public char HDOJDBLBGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public char EDBLIMKCMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public char PLPJNBIMIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public byte JHFKLKNOJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public byte HGAKOODHOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public byte MGOOCINBJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public byte ACAMAOFKCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public byte JPKFJEBAGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public byte LMPHDJLHGGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public byte JLKNPONJPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public byte PADCLMKCFIK;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x69B0900", Offset = "0x69AFD00", VA = "0x1869B0900")]
	public static AFIMEHDDHLN GILBACJLDCL(byte PMLPJPAINEC, byte KHEBDMGDLCG, byte NAOFLAKDDMO, byte IFGNHNABEGP, byte NOPDOFAIJJD, byte PCGFJDLJNCM, byte IJLMODJNMGH, byte FPHBIKAFJHF)
	{
		return default(AFIMEHDDHLN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class DBEEKJONJGG
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x167FD20", Offset = "0x167F120", VA = "0x18167FD20")]
	public static IEnumerable<T> DNFFMABKFEK<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7532F0", Offset = "0x7526F0", VA = "0x1807532F0")]
	public static T[] MOLAAOJHGBN<T>(params T[] JKBHGJLNEAI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7532F0", Offset = "0x7526F0", VA = "0x1807532F0")]
	public static IEnumerable<T> LEBDKIFHMIG<T>(params T[] JKBHGJLNEAI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x167FD30", Offset = "0x167F130", VA = "0x18167FD30")]
	public static HashSet<T> NEFJOCNOEBC<T>(params T[] JKBHGJLNEAI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x167FD90", Offset = "0x167F190", VA = "0x18167FD90")]
	public static KeyValuePair<TKey, TValue> OLEHFHGGNEO<TKey, TValue>(in TKey OGFDNCPKECB, in TValue LPJDDLMPNCG) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x167FD30", Offset = "0x167F130", VA = "0x18167FD30")]
	public static List<T> PDBCCCOJOIK<T>(IEnumerable<T> AABKFFENABM) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[AttributeUsage(AttributeTargets.All)]
public sealed class MDKCAKKCDHO : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly string MKCNPFCMIHF;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x730090", Offset = "0x72F490", VA = "0x180730090")]
	public MDKCAKKCDHO(string EKOBHOLKDHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[OAEAKFOOKJJ]
public delegate void JMNOAIEFILJ(string AMNLGEBHFHK);
[Cpp2IlInjected.Token(Token = "0x2000028")]
[OAEAKFOOKJJ]
public delegate void ODIEBNEIKHK();
[Cpp2IlInjected.Token(Token = "0x2000029")]
public delegate object CHBEDDIAGPD<T>(T FKFCAPAEHKO);
[Cpp2IlInjected.Token(Token = "0x200002A")]
public delegate object NHNMGAOEOBN<T>(in T FKFCAPAEHKO);
[Cpp2IlInjected.Token(Token = "0x200002B")]
[OAEAKFOOKJJ]
public delegate string OLOFAEHKGMO(string ADAJMBMBPKM, string? OGGIMIMNPIL, bool GGJOAAPMNOL);
[Cpp2IlInjected.Token(Token = "0x200002C")]
[OAEAKFOOKJJ]
public delegate void HFIHBEEFHHM(string BALNMHDNCIN);
[Cpp2IlInjected.Token(Token = "0x200002D")]
[OAEAKFOOKJJ]
public delegate void EAKMOHAKKAJ(Exception MEIDENAJCEE);
[Cpp2IlInjected.Token(Token = "0x200002E")]
public delegate object MBKGOJIOPBJ();
[Cpp2IlInjected.Token(Token = "0x200002F")]
[OAEAKFOOKJJ]
public delegate bool CKDHDEHAKOM();
[Cpp2IlInjected.Token(Token = "0x2000030")]
[OAEAKFOOKJJ]
public delegate string BPMDFAAGKNC(object NBNOMDAKOCG);
[Cpp2IlInjected.Token(Token = "0x2000031")]
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class EBIDJBJAIJA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x9CC120", Offset = "0x9CB520", VA = "0x1809CC120")]
	public EBIDJBJAIJA(bool EAHDBPNIECM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
public sealed class JHDAJBLLBFG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x69B2E80", Offset = "0x69B2280", VA = "0x1869B2E80")]
	public JHDAJBLLBFG(bool EAHDBPNIECM, string NJEDLEOJGMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class MNKKOBAPPBG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x9CC120", Offset = "0x9CB520", VA = "0x1809CC120")]
	public MNKKOBAPPBG(bool EAHDBPNIECM)
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
