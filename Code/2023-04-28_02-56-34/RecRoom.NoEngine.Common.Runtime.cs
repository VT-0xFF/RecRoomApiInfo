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
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x69942F0", Offset = "0x6992CF0", VA = "0x1869942F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x72C090", Offset = "0x72AA90", VA = "0x18072C090")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA36880", Offset = "0xA35280", VA = "0x180A36880")]
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
	[Cpp2IlInjected.Address(RVA = "0x2AA7240", Offset = "0x2AA5C40", VA = "0x182AA7240")]
	public AEINHFCGMKD(in T LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6CD0", Offset = "0x2AA56D0", VA = "0x182AA6CD0", Slot = "0")]
	public override bool Equals(object NBNOMDAKOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6EA0", Offset = "0x2AA58A0", VA = "0x182AA6EA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2AA70D0", Offset = "0x2AA5AD0", VA = "0x182AA70D0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0")]
	public OAEAKFOOKJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
public class KCDCAGLMLEB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0")]
	public KCDCAGLMLEB(string DEONPOEKLKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class FKCOEDAALNM
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2F808E0", Offset = "0x2F7F2E0", VA = "0x182F808E0")]
	public static MMDBLFNKKAG EIJEIEDIKBI<T>()
	{
		return default(MMDBLFNKKAG);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2F80B90", Offset = "0x2F7F590", VA = "0x182F80B90")]
	public static MMDBLFNKKAG MCAPDIFBJEA<T>([CallerMemberName] string AMNLGEBHFHK = "") where T : notnull
	{
		return default(MMDBLFNKKAG);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2F80850", Offset = "0x2F7F250", VA = "0x182F80850")]
	public static MMDBLFNKKAG EIJEIEDIKBI<T>(this T PJEHHDIBMKL) where T : notnull
	{
		return default(MMDBLFNKKAG);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2F80970", Offset = "0x2F7F370", VA = "0x182F80970")]
	public static MMDBLFNKKAG FKGMENCBGIB<T>(this T PJEHHDIBMKL, [CallerMemberName] string AMNLGEBHFHK = "") where T : notnull
	{
		return default(MMDBLFNKKAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2F80AF0", Offset = "0x2F7F4F0", VA = "0x182F80AF0")]
	public static MMDBLFNKKAG MCAPDIFBJEA<T>(this T INHKNJBCCPD, [CallerMemberName] string AMNLGEBHFHK = "") where T : notnull
	{
		return default(MMDBLFNKKAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6991EF0", Offset = "0x69908F0", VA = "0x186991EF0")]
	public static MMDBLFNKKAG MCAPDIFBJEA(string CPIGPDBOGNE, [CallerMemberName] string AMNLGEBHFHK = "")
	{
		return default(MMDBLFNKKAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6991E30", Offset = "0x6990830", VA = "0x186991E30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6994F90", Offset = "0x6993990", VA = "0x186994F90")]
		get
		{
			return default(CLJIMOLIMCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static ICDJBKHKFDL JKIDCLKOGCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6994DA0", Offset = "0x69937A0", VA = "0x186994DA0")]
		get
		{
			return default(ICDJBKHKFDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static MDABJEJPBAA NKPIENCKIEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6994FF0", Offset = "0x69939F0", VA = "0x186994FF0")]
		get
		{
			return default(MDABJEJPBAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6995360", Offset = "0x6993D60", VA = "0x186995360")]
	public static void OCIIKEBAJAD(in CLJIMOLIMCP MNBALFJGNMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6994E00", Offset = "0x6993800", VA = "0x186994E00")]
	public static void BMBLFHKAJNC(string BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x69952B0", Offset = "0x6993CB0", VA = "0x1869952B0")]
	public static void MCFEJMHAGOD(string BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x22C7540", Offset = "0x22C5F40", VA = "0x1822C7540")]
	public static void MCFEJMHAGOD<T>(T HACNEHKIBDN, global::CHBEDDIAGPD<T> BALNMHDNCIN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6995230", Offset = "0x6993C30", VA = "0x186995230")]
	public static void LEOIFHKKJAG(Exception MEIDENAJCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x69951B0", Offset = "0x6993BB0", VA = "0x1869951B0")]
	public static string KLAEAEAADJD(object NBNOMDAKOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6995140", Offset = "0x6993B40", VA = "0x186995140")]
	public static long IJDNAANDOLB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6994EB0", Offset = "0x69938B0", VA = "0x186994EB0")]
	public static bool CCNBNHFEJFD(bool LAGGEGOCCOE, string BALNMHDNCIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6995050", Offset = "0x6993A50", VA = "0x186995050")]
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
		[Cpp2IlInjected.Address(RVA = "0x69918F0", Offset = "0x69902F0", VA = "0x1869918F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6991DA0", Offset = "0x69907A0", VA = "0x186991DA0")]
	public CLJIMOLIMCP(in ICDJBKHKFDL IKEMEFMEOLL, in MDABJEJPBAA GIIGEMAJFJJ, BPMDFAAGKNC LKCPGIJDJLP, DAELIJIIBOG AMOLIOCAMGN, OLOFAEHKGMO NMNAGDKJIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6991A30", Offset = "0x6990430", VA = "0x186991A30")]
	private static string HKFGCMPMFBN(object NBNOMDAKOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x72B5A0", Offset = "0x729FA0", VA = "0x18072B5A0")]
	private static long GBEHKJLAPBG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x84FC20", Offset = "0x84E620", VA = "0x18084FC20")]
	private static string HMGPIBHMDHD(string ADAJMBMBPKM, string? OGGIMIMNPIL, bool GGJOAAPMNOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x69917D0", Offset = "0x69901D0", VA = "0x1869917D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B65150", Offset = "0x2B63B50", VA = "0x182B65150")]
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
	[Cpp2IlInjected.Address(RVA = "0x2351DD0", Offset = "0x23507D0", VA = "0x182351DD0")]
	public PDFKBNNABNH(in T LPJDDLMPNCG, int EGNHJGKABLC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2994BF0", Offset = "0x29935F0", VA = "0x182994BF0")]
	public static bool BOBJELOEACN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD140", Offset = "0x6DC540")] in global::PDFKBNNABNH<T> LJLKLAFAGNO, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD1B0", Offset = "0x6DC5B0")] in global::PDFKBNNABNH<T> HFBAHIGFPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2995030", Offset = "0x2993A30", VA = "0x182995030", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD220", Offset = "0x6DC620")] global::PDFKBNNABNH<T> MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2994FA0", Offset = "0x29939A0", VA = "0x182994FA0", Slot = "0")]
	public override bool Equals(object MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2995530", Offset = "0x2993F30", VA = "0x182995530")]
	public bool IGJKOGMIHOL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD280", Offset = "0x6DC680")] in global::PDFKBNNABNH<T> MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2995470", Offset = "0x2993E70", VA = "0x182995470", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2996210", Offset = "0x2994C10", VA = "0x182996210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2995B30", Offset = "0x2994530", VA = "0x182995B30")]
	public void LOCCMPKKMAH(out T LPJDDLMPNCG, out int EGNHJGKABLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2995E90", Offset = "0x2994890", VA = "0x182995E90")]
	public (T, int) NNKANILJCKH()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2994F50", Offset = "0x2993950", VA = "0x182994F50", Slot = "5")]
	private bool DKDADOLJFKP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD2F0", Offset = "0x6DC6F0")] in global::PDFKBNNABNH<T> MPHACEGLFIL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class JPANKJLCPML
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x199B8F0", Offset = "0x199A2F0", VA = "0x18199B8F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69921A0", Offset = "0x6990BA0", VA = "0x1869921A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1F23F80", Offset = "0x1F22980", VA = "0x181F23F80")]
	public ICDJBKHKFDL(CKDHDEHAKOM EDMJKAIKKEB, HFIHBEEFHHM CFOMHHCOHGN, CKDHDEHAKOM MMCOODNLPCJ, HFIHBEEFHHM OOGAJJAJGFN, CKDHDEHAKOM FDHJKGJLEPH, HFIHBEEFHHM AGGOFMDLOMN, EAKMOHAKKAJ LBKFHJNANDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x72A820", Offset = "0x729220", VA = "0x18072A820")]
	private static bool POEBKPCJEEP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	private static void NPKEDHGIBKP(string BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x72A820", Offset = "0x729220", VA = "0x18072A820")]
	private static bool JLEONHNGCGL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	private static void DIDKFPHAGEM(string BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x72A820", Offset = "0x729220", VA = "0x18072A820")]
	private static bool OOPCMILKAOL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	private static void NIKOCIELLHP(string BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	private static void ACIPOBIOKBB(Exception MEIDENAJCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6992060", Offset = "0x6990A60", VA = "0x186992060")]
	private static ICDJBKHKFDL FEDNMKCFCHK()
	{
		return default(ICDJBKHKFDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7319E0", Offset = "0x7303E0", VA = "0x1807319E0")]
	private static bool LLNBEAGCHEN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6991F70", Offset = "0x6990970", VA = "0x186991F70")]
	public void BMBLFHKAJNC(object BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6992400", Offset = "0x6990E00", VA = "0x186992400")]
	public void MCFEJMHAGOD(object BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x69923E0", Offset = "0x6990DE0", VA = "0x1869923E0")]
	public void LEOIFHKKJAG(Exception MEIDENAJCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2542A80", Offset = "0x2541480", VA = "0x182542A80")]
	public void MCFEJMHAGOD<T>(T HACNEHKIBDN, global::CHBEDDIAGPD<T> BALNMHDNCIN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2542980", Offset = "0x2541380", VA = "0x182542980")]
	public void BMBLFHKAJNC<T>(in T HACNEHKIBDN, global::NHNMGAOEOBN<T> BALNMHDNCIN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6991FE0", Offset = "0x69909E0", VA = "0x186991FE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x8D19D0", Offset = "0x8D03D0", VA = "0x1808D19D0")]
	public MMDBLFNKKAG(string LPJDDLMPNCG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7519F0", Offset = "0x7503F0", VA = "0x1807519F0")]
	public static string HPHCHABBDNG(in MMDBLFNKKAG INHKNJBCCPD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x10A3770", Offset = "0x10A2170", VA = "0x1810A3770")]
	public static MMDBLFNKKAG HPHCHABBDNG(string MPHACEGLFIL)
	{
		return default(MMDBLFNKKAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6993F90", Offset = "0x6992990", VA = "0x186993F90")]
	public string GCBEILMLFND(string NKKEIKGKIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6993FE0", Offset = "0x69929E0", VA = "0x186993FE0")]
	public string JIHKCAIJPLG(object IOENONLLAKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7519F0", Offset = "0x7503F0", VA = "0x1807519F0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x7319E0", Offset = "0x7303E0", VA = "0x1807319E0", Slot = "4")]
	public bool Equals(JAPIHNFIDBB MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6993910", Offset = "0x6992310", VA = "0x186993910", Slot = "0")]
	public override bool Equals(object MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6993960", Offset = "0x6992360", VA = "0x186993960", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6993970", Offset = "0x6992370", VA = "0x186993970", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x337CD10", Offset = "0x337B710", VA = "0x18337CD10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x337D070", Offset = "0x337BA70", VA = "0x18337D070")]
	public DBEIBEIIMCM(in T LPJDDLMPNCG, bool NKOHEMBMFOO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x337C2C0", Offset = "0x337ACC0", VA = "0x18337C2C0")]
	public static bool BOBJELOEACN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD3D0", Offset = "0x6DC7D0")] in global::DBEIBEIIMCM<T> LJLKLAFAGNO, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD440", Offset = "0x6DC840")] in global::DBEIBEIIMCM<T> HFBAHIGFPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x29950C0", Offset = "0x2993AC0", VA = "0x1829950C0", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD4B0", Offset = "0x6DC8B0")] global::DBEIBEIIMCM<T> MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x337C880", Offset = "0x337B280", VA = "0x18337C880", Slot = "0")]
	public override bool Equals(object MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x337CC90", Offset = "0x337B690", VA = "0x18337CC90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x337CDE0", Offset = "0x337B7E0", VA = "0x18337CDE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class JDHOCJKBEGN
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1993FF0", Offset = "0x19929F0", VA = "0x181993FF0")]
	public static global::DBEIBEIIMCM<T> CDBEPIFNCBJ<T>(in T LPJDDLMPNCG) where T : notnull
	{
		return default(global::DBEIBEIIMCM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1994180", Offset = "0x1992B80", VA = "0x181994180")]
	public static global::DBEIBEIIMCM<T?> HIHPEHJNIJF<T>()
	{
		return default(global::DBEIBEIIMCM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1994080", Offset = "0x1992A80", VA = "0x181994080")]
	public static bool GDKAAPPNNPL<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD550", Offset = "0x6DC950")] this in global::DBEIBEIIMCM<T> KOFANCICHCF, [MNKKOBAPPBG(true)] out T LPJDDLMPNCG) where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x6993C10", Offset = "0x6992610", VA = "0x186993C10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7C16B0", Offset = "0x7C00B0", VA = "0x1807C16B0")]
	public MDABJEJPBAA(JMNOAIEFILJ PMABJGDDFKI, ODIEBNEIKHK DDLGCIPPMDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	private static void JMJCGGAOONL(string AMNLGEBHFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	private static void DFICCFBDKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6993B80", Offset = "0x6992580", VA = "0x186993B80")]
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
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69940E0", Offset = "0x6992AE0", VA = "0x1869940E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x69942A0", Offset = "0x6992CA0", VA = "0x1869942A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6993E70", Offset = "0x6992870", VA = "0x186993E70")]
	public static Task<TaskStatus> BEGKEPCPIFN(this Task INHKNJBCCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3672930", Offset = "0x3671330", VA = "0x183672930")]
	public static Task<T> NBGIBBBKNNO<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x36723D0", Offset = "0x3670DD0", VA = "0x1836723D0")]
	public static Task<TResult> MOAGHGPKFCB<TResult>(this Task<TResult> IBCOHPONNBJ, CancellationToken MIFCLBEAOPM) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6993E70", Offset = "0x6992870", VA = "0x186993E70")]
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
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0")]
	public OPDDIGNOJMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class OHGHBAEEHON
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static long GPIBKBKNACG
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6994440", Offset = "0x6992E40", VA = "0x186994440")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public static long OJPKLBFEFNN
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x69949A0", Offset = "0x69933A0", VA = "0x1869949A0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public static double EMDBFGCEAID
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6994840", Offset = "0x6993240", VA = "0x186994840")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static double IMOCGIEENIF
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x69945B0", Offset = "0x6992FB0", VA = "0x1869945B0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static double GIJMCFEDPNI
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x69944A0", Offset = "0x6992EA0", VA = "0x1869944A0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static double MLEAENEAGIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6994730", Offset = "0x6993130", VA = "0x186994730")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6994380", Offset = "0x6992D80", VA = "0x186994380")]
	public static double AHGCKEFAADB(long LKGEHBHECOH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6994790", Offset = "0x6993190", VA = "0x186994790")]
	public static double MNBIAMELNIJ(long LKGEHBHECOH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6994500", Offset = "0x6992F00", VA = "0x186994500")]
	public static double ELGJFGAADGC(double OCCBDPDIAKC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6994610", Offset = "0x6993010", VA = "0x186994610")]
	public static long FOGOBFJFFHC(long ONPCMEEMBBB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6994430", Offset = "0x6992E30", VA = "0x186994430")]
	public static long BNOCAOMAPLE(long PGCLIDGDKOP, long IHLFIIPPMCG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x69948A0", Offset = "0x69932A0", VA = "0x1869948A0")]
	public static double PGDHKMKNGGB(long PGCLIDGDKOP, long IHLFIIPPMCG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x69946C0", Offset = "0x69930C0", VA = "0x1869946C0")]
	public static double GPLAFBMEHCM(long PGCLIDGDKOP, long IHLFIIPPMCG)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class KMDOMJJDNBM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Timer MJOCLEMBKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly TimeSpan AOEGDFNBHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly Action KOCMCABLOKN;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6993A50", Offset = "0x6992450", VA = "0x186993A50")]
	public KMDOMJJDNBM(TimeSpan AOEGDFNBHBG, Action KOCMCABLOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x12C9BD0", Offset = "0x12C85D0", VA = "0x1812C9BD0")]
	private void IDJNJBDMPKP(object OJNFGJAPBNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x69939C0", Offset = "0x69923C0", VA = "0x1869939C0")]
	public void LEOAKEBKNCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x69939A0", Offset = "0x69923A0", VA = "0x1869939A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[AttributeUsage(AttributeTargets.All)]
public class JMOGFODMLAN : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly string EHENDBJBIEO;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x72C090", Offset = "0x72AA90", VA = "0x18072C090")]
	public JMOGFODMLAN(string NFBKGEMICGO)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct ILKKJFENGDG : IEquatable<ILKKJFENGDG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public uint PFMEHGKPABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public int HGJCGLPMNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public float GCCPANJGKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public ushort JFGOOHILHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public ushort BDDOIMMHLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public short GBEHLAHMPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public short AOGAAIENIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public char EGLAAFBBLLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public char HDOJDBLBGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public byte JHFKLKNOJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public byte HGAKOODHOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public byte MGOOCINBJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public byte ACAMAOFKCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public bool CDBFNIBOLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool DPOGBJGLLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public bool DFCLOAGKEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public bool FFMHIPPBDKA;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8A3C20", Offset = "0x8A2620", VA = "0x1808A3C20")]
	public static ILKKJFENGDG BGNFIAFBOON(uint IMOFGDNKKHM)
	{
		return default(ILKKJFENGDG);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x8A3C20", Offset = "0x8A2620", VA = "0x1808A3C20")]
	public static ILKKJFENGDG CBPINDFNNKG(int ADIIEHCPIOH)
	{
		return default(ILKKJFENGDG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1F7D690", Offset = "0x1F7C090", VA = "0x181F7D690")]
	public static ILKKJFENGDG OAEOJADLCKI(float FAFLBHPJLJL)
	{
		return default(ILKKJFENGDG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x69928F0", Offset = "0x69912F0", VA = "0x1869928F0")]
	public static ILKKJFENGDG CCJLMMLKKFA(byte PMLPJPAINEC, byte KHEBDMGDLCG, byte NAOFLAKDDMO, byte IFGNHNABEGP)
	{
		return default(ILKKJFENGDG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x69928F0", Offset = "0x69912F0", VA = "0x1869928F0")]
	public static ILKKJFENGDG FHEMGEHDJAL(bool LDBJPNHAFHO, bool JDAPFGOLDIC, bool FDDAEPCLFFI, bool OCDMHCGCLAC)
	{
		return default(ILKKJFENGDG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x10CF340", Offset = "0x10CDD40", VA = "0x1810CF340")]
	public static bool BOBJELOEACN(ILKKJFENGDG GBEJHLEFDJM, ILKKJFENGDG BDGBOHJLNIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x8A2060", Offset = "0x8A0A60", VA = "0x1808A2060", Slot = "4")]
	public bool Equals(ILKKJFENGDG MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6992910", Offset = "0x6991310", VA = "0x186992910", Slot = "0")]
	public override bool Equals(object NBNOMDAKOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xA2E450", Offset = "0xA2CE50", VA = "0x180A2E450", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6992990", Offset = "0x6991390", VA = "0x186992990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct AFIMEHDDHLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public ulong CJDMJPOKMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public long IEOOBBCAKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public double PNIJGBAIAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public uint CDPEKOMOMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public uint IPMMOBAPHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int FPHDDOOCHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int NBMJLINNNBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public float NJKPPFOMPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public float OGGMKCAECPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public ushort JFGOOHILHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public ushort BDDOIMMHLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public ushort DBILBLJKCDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public ushort OIBHKCOCOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public short GBEHLAHMPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public short AOGAAIENIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public short FHKCJEPEOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public short GLLDAPFLOOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public char EGLAAFBBLLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public char HDOJDBLBGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public char EDBLIMKCMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public char PLPJNBIMIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public byte JHFKLKNOJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public byte HGAKOODHOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public byte MGOOCINBJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public byte ACAMAOFKCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public byte JPKFJEBAGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public byte LMPHDJLHGGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public byte JLKNPONJPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public byte PADCLMKCFIK;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x69914D0", Offset = "0x698FED0", VA = "0x1869914D0")]
	public static AFIMEHDDHLN GILBACJLDCL(byte PMLPJPAINEC, byte KHEBDMGDLCG, byte NAOFLAKDDMO, byte IFGNHNABEGP, byte NOPDOFAIJJD, byte PCGFJDLJNCM, byte IJLMODJNMGH, byte FPHBIKAFJHF)
	{
		return default(AFIMEHDDHLN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class DBEEKJONJGG
{
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x28AC540", Offset = "0x28AAF40", VA = "0x1828AC540")]
	public static IEnumerable<T> DNFFMABKFEK<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x84FC20", Offset = "0x84E620", VA = "0x18084FC20")]
	public static T[] MOLAAOJHGBN<T>(params T[] JKBHGJLNEAI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x84FC20", Offset = "0x84E620", VA = "0x18084FC20")]
	public static IEnumerable<T> LEBDKIFHMIG<T>(params T[] JKBHGJLNEAI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x25058C0", Offset = "0x25042C0", VA = "0x1825058C0")]
	public static HashSet<T> NEFJOCNOEBC<T>(params T[] JKBHGJLNEAI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x28AC550", Offset = "0x28AAF50", VA = "0x1828AC550")]
	public static KeyValuePair<TKey, TValue> OLEHFHGGNEO<TKey, TValue>(in TKey OGFDNCPKECB, in TValue LPJDDLMPNCG) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x25058C0", Offset = "0x25042C0", VA = "0x1825058C0")]
	public static List<T> PDBCCCOJOIK<T>(IEnumerable<T> AABKFFENABM) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[OAEAKFOOKJJ]
public delegate void JMNOAIEFILJ(string AMNLGEBHFHK);
[Cpp2IlInjected.Token(Token = "0x2000025")]
[OAEAKFOOKJJ]
public delegate void ODIEBNEIKHK();
[Cpp2IlInjected.Token(Token = "0x2000026")]
public delegate object CHBEDDIAGPD<T>(T FKFCAPAEHKO);
[Cpp2IlInjected.Token(Token = "0x2000027")]
public delegate object NHNMGAOEOBN<T>(in T FKFCAPAEHKO);
[Cpp2IlInjected.Token(Token = "0x2000028")]
[OAEAKFOOKJJ]
public delegate string OLOFAEHKGMO(string ADAJMBMBPKM, string? OGGIMIMNPIL, bool GGJOAAPMNOL);
[Cpp2IlInjected.Token(Token = "0x2000029")]
[OAEAKFOOKJJ]
public delegate void HFIHBEEFHHM(string BALNMHDNCIN);
[Cpp2IlInjected.Token(Token = "0x200002A")]
[OAEAKFOOKJJ]
public delegate void EAKMOHAKKAJ(Exception MEIDENAJCEE);
[Cpp2IlInjected.Token(Token = "0x200002B")]
public delegate object MBKGOJIOPBJ();
[Cpp2IlInjected.Token(Token = "0x200002C")]
[OAEAKFOOKJJ]
public delegate bool CKDHDEHAKOM();
[Cpp2IlInjected.Token(Token = "0x200002D")]
[OAEAKFOOKJJ]
public delegate string BPMDFAAGKNC(object NBNOMDAKOCG);
[Cpp2IlInjected.Token(Token = "0x200002E")]
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class EBIDJBJAIJA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0xA36880", Offset = "0xA35280", VA = "0x180A36880")]
	public EBIDJBJAIJA(bool EAHDBPNIECM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class MNKKOBAPPBG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0xA36880", Offset = "0xA35280", VA = "0x180A36880")]
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
