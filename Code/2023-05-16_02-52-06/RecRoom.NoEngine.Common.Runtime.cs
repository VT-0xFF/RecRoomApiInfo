using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A93F90", Offset = "0x6A92D90", VA = "0x186A93F90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x75C880", Offset = "0x75B680", VA = "0x18075C880")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7DB60", Offset = "0xA7C960", VA = "0x180A7DB60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class BGJNIPOAJHC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly EqualityComparer<T> MIAJFIGNDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public T KCKILJPPPGI;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x25DE870", Offset = "0x25DD670", VA = "0x1825DE870")]
	public BGJNIPOAJHC(in T MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2C923D0", Offset = "0x2C911D0", VA = "0x182C923D0", Slot = "0")]
	public override bool Equals(object OJGAEOFIMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xD69660", Offset = "0xD68460", VA = "0x180D69660", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2C926A0", Offset = "0x2C914A0", VA = "0x182C926A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate)]
public class INAHLNLFMMC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40")]
	public INAHLNLFMMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
public class PBMBPPOGDAA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40")]
	public PBMBPPOGDAA(string KGLKGGLLEPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DONJEPPICJO
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x209E890", Offset = "0x209D690", VA = "0x18209E890")]
	public static NDILHIPFEGK IAIJCDFGIIJ<T>()
	{
		return default(NDILHIPFEGK);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x209EAE0", Offset = "0x209D8E0", VA = "0x18209EAE0")]
	public static NDILHIPFEGK JDIFOPOMILP<T>([CallerMemberName] string ICIEGOLHGJN = "") where T : notnull
	{
		return default(NDILHIPFEGK);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x209E920", Offset = "0x209D720", VA = "0x18209E920")]
	public static NDILHIPFEGK IAIJCDFGIIJ<T>(this T IDKOCJBGGJO) where T : notnull
	{
		return default(NDILHIPFEGK);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x209E720", Offset = "0x209D520", VA = "0x18209E720")]
	public static NDILHIPFEGK AOEECHJKKOL<T>(this T IDKOCJBGGJO, [CallerMemberName] string ICIEGOLHGJN = "") where T : notnull
	{
		return default(NDILHIPFEGK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x209EB70", Offset = "0x209D970", VA = "0x18209EB70")]
	public static NDILHIPFEGK JDIFOPOMILP<T>(this T LCNEHOGIJPK, [CallerMemberName] string ICIEGOLHGJN = "") where T : notnull
	{
		return default(NDILHIPFEGK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6A90F60", Offset = "0x6A8FD60", VA = "0x186A90F60")]
	public static NDILHIPFEGK JDIFOPOMILP(string ACJPAOCCOGN, [CallerMemberName] string ICIEGOLHGJN = "")
	{
		return default(NDILHIPFEGK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6A90FE0", Offset = "0x6A8FDE0", VA = "0x186A90FE0")]
	public static string OOAICLGPDNN(this object LCNEHOGIJPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[INAHLNLFMMC]
public delegate long EMNJHICOLGF();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class AACILDFCDEE
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static MPCHJPJCOEK LDDJELFKMJG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static MPCHJPJCOEK NPJPCJDAFGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6A8FED0", Offset = "0x6A8ECD0", VA = "0x186A8FED0")]
		get
		{
			return default(MPCHJPJCOEK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JGHHNHHEALK GIGAIIOKHBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6A8FC10", Offset = "0x6A8EA10", VA = "0x186A8FC10")]
		get
		{
			return default(JGHHNHHEALK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static PKENMOBHNFA FGCPFAKFAPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6A8FCE0", Offset = "0x6A8EAE0", VA = "0x186A8FCE0")]
		get
		{
			return default(PKENMOBHNFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6A8FFE0", Offset = "0x6A8EDE0", VA = "0x186A8FFE0")]
	public static void MKCDCFKMHPJ(in MPCHJPJCOEK HBMLAIDHAHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6A8FD40", Offset = "0x6A8EB40", VA = "0x186A8FD40")]
	public static void DBKHFPMEGAJ(string GPAOLHFLBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6A8FF30", Offset = "0x6A8ED30", VA = "0x186A8FF30")]
	public static void MBCIOBBCNFF(string GPAOLHFLBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x22E7810", Offset = "0x22E6610", VA = "0x1822E7810")]
	public static void MBCIOBBCNFF<T>(T OHMLFHCAJEC, global::CMBCMKGEMMF<T> GPAOLHFLBHD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6A8FB90", Offset = "0x6A8E990", VA = "0x186A8FB90")]
	public static void AHFHDEBPJBO(Exception ADJEGMMBDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6A90140", Offset = "0x6A8EF40", VA = "0x186A90140")]
	public static string OOAICLGPDNN(object OJGAEOFIMPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6A8FC70", Offset = "0x6A8EA70", VA = "0x186A8FC70")]
	public static long BJOAFEIJLIO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6A8FDF0", Offset = "0x6A8EBF0", VA = "0x186A8FDF0")]
	public static bool DIDLBBIKKNI(bool IMGEDHKJCMM, string GPAOLHFLBHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6A8FAA0", Offset = "0x6A8E8A0", VA = "0x186A8FAA0")]
	public static double AGGFBKJJBIM()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct MPCHJPJCOEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly JGHHNHHEALK GIGAIIOKHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly PKENMOBHNFA FGCPFAKFAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly PGIIGCKKNOM DDHOGHOPOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly EMNJHICOLGF ABOLPIJCENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly HGNEHOHOHML EIEGCDBFEFB;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly PGIIGCKKNOM OOLHLGGLBGG;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly EMNJHICOLGF PEMLPBECFDP;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly HGNEHOHOHML EAFCHIKHOKF;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly MPCHJPJCOEK KLPFABJKKCC;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool JFJDDAHJJJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6A93940", Offset = "0x6A92740", VA = "0x186A93940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6A93DB0", Offset = "0x6A92BB0", VA = "0x186A93DB0")]
	public MPCHJPJCOEK(in JGHHNHHEALK MIDLBNCDBIB, in PKENMOBHNFA EAPHDKLDNGO, PGIIGCKKNOM AFDOFGMAJPH, EMNJHICOLGF HCOGCENLIKF, HGNEHOHOHML EGGAFAHAAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6A93900", Offset = "0x6A92700", VA = "0x186A93900")]
	private static string KLAKJPELCIJ(object OJGAEOFIMPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7487A0", Offset = "0x7475A0", VA = "0x1807487A0")]
	private static long NGBGDABIPOP()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7C69F0", Offset = "0x7C57F0", VA = "0x1807C69F0")]
	private static string PPLBOOPDJLI(string MDIBKHINKGB, string? EGJCKEHDCCN, bool BMBDJAGHCLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6A937E0", Offset = "0x6A925E0", VA = "0x186A937E0")]
	private static MPCHJPJCOEK JEKOONAONOC()
	{
		return default(MPCHJPJCOEK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LGIAMFKIPFI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GAJGNOIFGFG(in T IDBPJJAKCBN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HJIKCCEABJA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	TimeSpan NJCKEBBFNCI
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Action? NHPFHBCLKHB
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EJEHGNMMKCK();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EHPLGLOELMC();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JPADCIAGBDP();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate void DGIGONPNFHC<T>(in T OHMLFHCAJEC);
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class MKFFPIPECCI
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x25107D0", Offset = "0x250F5D0", VA = "0x1825107D0")]
	public static bool GAJGNOIFGFG<T, U>(in T LCNEHOGIJPK, in U OJGAEOFIMPK) where T : notnull, global::LGIAMFKIPFI<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public delegate TResult DMIAGCBHEFG<T, out TResult>(in T OHMLFHCAJEC);
[Cpp2IlInjected.Token(Token = "0x2000011")]
public delegate TResult IJCIPAEKIEP<T1, T2, out TResult>(in T1 OINGLPLLDMC, in T2 MEHOJPEEHPN);
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct AJPNGLJDKNK<T> : IEquatable<global::AJPNGLJDKNK<T>>, global::LGIAMFKIPFI<global::AJPNGLJDKNK<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly T KCKILJPPPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly int CEEBBJGGBDE;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x24E2760", Offset = "0x24E1560", VA = "0x1824E2760")]
	public AJPNGLJDKNK(in T MGFMONLLLPD, int NNHNOIMLALG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x24E13E0", Offset = "0x24E01E0", VA = "0x1824E13E0")]
	public static bool EJGLOGBEPOL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F2C80", Offset = "0x6F2080")] in global::AJPNGLJDKNK<T> CJCAMOJJGED, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F2CF0", Offset = "0x6F20F0")] in global::AJPNGLJDKNK<T> DDMHJAPFCFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x24E17D0", Offset = "0x24E05D0", VA = "0x1824E17D0", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F2D60", Offset = "0x6F2160")] global::AJPNGLJDKNK<T> IDBPJJAKCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x24E1740", Offset = "0x24E0540", VA = "0x1824E1740", Slot = "0")]
	public override bool Equals(object IDBPJJAKCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x24E18F0", Offset = "0x24E06F0", VA = "0x1824E18F0")]
	public bool GAJGNOIFGFG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F2DC0", Offset = "0x6F21C0")] in global::AJPNGLJDKNK<T> IDBPJJAKCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x24E1C10", Offset = "0x24E0A10", VA = "0x1824E1C10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x24E2230", Offset = "0x24E1030", VA = "0x1824E2230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x24E0D20", Offset = "0x24DFB20", VA = "0x1824E0D20")]
	public void BJOOJLCIJFO(out T MGFMONLLLPD, out int NNHNOIMLALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x24E1E40", Offset = "0x24E0C40", VA = "0x1824E1E40")]
	public (T, int) KHGGKCDIPAH()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x24E1980", Offset = "0x24E0780", VA = "0x1824E1980", Slot = "5")]
	private bool GDIJIOBAHKK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F2E30", Offset = "0x6F2230")] in global::AJPNGLJDKNK<T> IDBPJJAKCBN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class OMFBNDDOKFC
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x27D8C50", Offset = "0x27D7A50", VA = "0x1827D8C50")]
	public static global::AJPNGLJDKNK<T> AIJMFKKLHCC<T>(in T MGFMONLLLPD, int NNHNOIMLALG) where T : notnull
	{
		return default(global::AJPNGLJDKNK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct JGHHNHHEALK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly CGMGFDDJDBO BGKBDAIBFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly JDDNKDMAJOL ILBCJJNBENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly CGMGFDDJDBO ILFDHBACJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly JDDNKDMAJOL CPEAMCOMDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly CGMGFDDJDBO LHOOIBAILDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly JDDNKDMAJOL KDHDKOAKOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly BGPDEFMFBAF DOFOKIEIFKC;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly CGMGFDDJDBO FADIDMBDJIE;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly JDDNKDMAJOL NJCJFICFPDB;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly CGMGFDDJDBO LBNGPGELIOP;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly JDDNKDMAJOL PMKAOAIFPLI;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly CGMGFDDJDBO CAMECODPLKB;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly JDDNKDMAJOL GOFKJKKELNM;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly BGPDEFMFBAF JKODNMJPFIN;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly JGHHNHHEALK KLPFABJKKCC;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static readonly CGMGFDDJDBO DICGKNNHCNF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool JFJDDAHJJJF
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6A930B0", Offset = "0x6A91EB0", VA = "0x186A930B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x16B23A0", Offset = "0x16B11A0", VA = "0x1816B23A0")]
	public JGHHNHHEALK(CGMGFDDJDBO LAFJOMBJHEJ, JDDNKDMAJOL LLHHDIMMPKD, CGMGFDDJDBO MLBBAPINPEG, JDDNKDMAJOL LFCPGDJCDMM, CGMGFDDJDBO NEGDDAFFHGP, JDDNKDMAJOL GDFPJOCKEDL, BGPDEFMFBAF LIJMGFJPHJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x745330", Offset = "0x744130", VA = "0x180745330")]
	private static bool FAJECPLFLHP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	private static void EFIPONDFAAM(string GPAOLHFLBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x745330", Offset = "0x744130", VA = "0x180745330")]
	private static bool KOCNPHONJLF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	private static void NLBOGAGACNF(string GPAOLHFLBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x745330", Offset = "0x744130", VA = "0x180745330")]
	private static bool POHEIDFGKPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	private static void EOPFNPOIPHC(string GPAOLHFLBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	private static void PJPJPKEIGPF(Exception ADJEGMMBDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6A92F70", Offset = "0x6A91D70", VA = "0x186A92F70")]
	private static JGHHNHHEALK JEKOONAONOC()
	{
		return default(JGHHNHHEALK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7621B0", Offset = "0x760FB0", VA = "0x1807621B0")]
	private static bool NEKDLDLEHPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6A92E80", Offset = "0x6A91C80", VA = "0x186A92E80")]
	public void DBKHFPMEGAJ(object GPAOLHFLBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6A932F0", Offset = "0x6A920F0", VA = "0x186A932F0")]
	public void MBCIOBBCNFF(object GPAOLHFLBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6A92E60", Offset = "0x6A91C60", VA = "0x186A92E60")]
	public void AHFHDEBPJBO(Exception ADJEGMMBDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x277FC60", Offset = "0x277EA60", VA = "0x18277FC60")]
	public void MBCIOBBCNFF<T>(T OHMLFHCAJEC, global::CMBCMKGEMMF<T> GPAOLHFLBHD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x277FB60", Offset = "0x277E960", VA = "0x18277FB60")]
	public void DBKHFPMEGAJ<T>(in T OHMLFHCAJEC, global::FPIAIKKLHOA<T> GPAOLHFLBHD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6A92EF0", Offset = "0x6A91CF0", VA = "0x186A92EF0")]
	public bool DIDLBBIKKNI(bool IMGEDHKJCMM, string GPAOLHFLBHD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct NDILHIPFEGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly string KCKILJPPPGI;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x918E40", Offset = "0x917C40", VA = "0x180918E40")]
	public NDILHIPFEGK(string MGFMONLLLPD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x740000", Offset = "0x73EE00", VA = "0x180740000")]
	public static string JMLJLLKELMG(in NDILHIPFEGK LCNEHOGIJPK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xE72D60", Offset = "0xE71B60", VA = "0x180E72D60")]
	public static NDILHIPFEGK JMLJLLKELMG(string IDBPJJAKCBN)
	{
		return default(NDILHIPFEGK);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6A93F40", Offset = "0x6A92D40", VA = "0x186A93F40")]
	public string MCJJDCCBKHF(string NNDKGIFLHME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6A93E40", Offset = "0x6A92C40", VA = "0x186A93E40")]
	public string JEECNIPFCBJ(object DNAIGHGJNFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x740000", Offset = "0x73EE00", VA = "0x180740000", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct JCKJOPOBLHO : IEquatable<JCKJOPOBLHO>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7621B0", Offset = "0x760FB0", VA = "0x1807621B0", Slot = "4")]
	public bool Equals(JCKJOPOBLHO IDBPJJAKCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6A92DD0", Offset = "0x6A91BD0", VA = "0x186A92DD0", Slot = "0")]
	public override bool Equals(object IDBPJJAKCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6A92E20", Offset = "0x6A91C20", VA = "0x186A92E20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6A92E30", Offset = "0x6A91C30", VA = "0x186A92E30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[ONPFBCLBBFN("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct POPJPNDPEEI<T> : IEquatable<global::POPJPNDPEEI<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T KCKILJPPPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly bool OFIFGNBDBBD;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool KGFBANJMDCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4087640", Offset = "0x4086440", VA = "0x184087640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4087A20", Offset = "0x4086820", VA = "0x184087A20")]
	public POPJPNDPEEI(in T MGFMONLLLPD, bool KBBLKCFCJBA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4087190", Offset = "0x4085F90", VA = "0x184087190")]
	public static bool EJGLOGBEPOL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F2F50", Offset = "0x6F2350")] in global::POPJPNDPEEI<T> CJCAMOJJGED, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F2FC0", Offset = "0x6F23C0")] in global::POPJPNDPEEI<T> DDMHJAPFCFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x24E1860", Offset = "0x24E0660", VA = "0x1824E1860", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F3030", Offset = "0x6F2430")] global::POPJPNDPEEI<T> IDBPJJAKCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4087260", Offset = "0x4086060", VA = "0x184087260", Slot = "0")]
	public override bool Equals(object IDBPJJAKCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x40876D0", Offset = "0x40864D0", VA = "0x1840876D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4087960", Offset = "0x4086760", VA = "0x184087960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class OJMJGLAINFB
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2AD6FE0", Offset = "0x2AD5DE0", VA = "0x182AD6FE0")]
	public static global::POPJPNDPEEI<T> JIBIGLKCGKE<T>(in T MGFMONLLLPD) where T : notnull
	{
		return default(global::POPJPNDPEEI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2AD7170", Offset = "0x2AD5F70", VA = "0x182AD7170")]
	public static global::POPJPNDPEEI<T?> PKNJHACCAHG<T>()
	{
		return default(global::POPJPNDPEEI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2AD7070", Offset = "0x2AD5E70", VA = "0x182AD7070")]
	public static bool JMPJICJGPOD<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F3090", Offset = "0x6F2490")] this in global::POPJPNDPEEI<T> HHJLAOOEDCL, [LBBFCMALCPB(true)] out T MGFMONLLLPD) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct PKENMOBHNFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly LLPMGMFCKNE EDPBBILADLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly KCJNLDDGMFN NNDKFONAGMA;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly LLPMGMFCKNE GHFFKEGAIPH;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly KCJNLDDGMFN AMBJHOJLBFL;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly PKENMOBHNFA KLPFABJKKCC;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool JFJDDAHJJJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6A94110", Offset = "0x6A92F10", VA = "0x186A94110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x809110", Offset = "0x807F10", VA = "0x180809110")]
	public PKENMOBHNFA(LLPMGMFCKNE LDFCMHFBHKK, KCJNLDDGMFN ENHODDLEFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	private static void GAAMIBHKMID(string ICIEGOLHGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	private static void EJLIJAGCLJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6A94080", Offset = "0x6A92E80", VA = "0x186A94080")]
	private static PKENMOBHNFA JEKOONAONOC()
	{
		return default(PKENMOBHNFA);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class COPABFLFKEE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct EIOJKMCJDFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Task selfInternal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6A91180", Offset = "0x6A8FF80", VA = "0x186A91180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6A91340", Offset = "0x6A90140", VA = "0x186A91340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6A90C00", Offset = "0x6A8FA00", VA = "0x186A90C00")]
	public static Task<TaskStatus> CCHPJANOAMO(this Task LCNEHOGIJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x22AB7E0", Offset = "0x22AA5E0", VA = "0x1822AB7E0")]
	public static Task<T> LGFNBANOGFL<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6A90D20", Offset = "0x6A8FB20", VA = "0x186A90D20")]
	public static Task GOAIKDCGKPC(this Task LEGNJFDJJMM, CancellationToken AMBDKIOJFBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x22AB280", Offset = "0x22AA080", VA = "0x1822AB280")]
	public static Task<TResult> GOAIKDCGKPC<TResult>(this Task<TResult> LEGNJFDJJMM, CancellationToken AMBDKIOJFBL) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6A90C00", Offset = "0x6A8FA00", VA = "0x186A90C00")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(EIOJKMCJDFI))]
	internal static Task<TaskStatus> BNPHBBGGABJ(Task FADCMFMLBAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[AttributeUsage(AttributeTargets.Class)]
public class BCNMPBBOPDG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40")]
	public BCNMPBBOPDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class BPBCMIAOOLO : GHJJELLJAPK
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly GHJJELLJAPK NHLDGJJELOO;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public DateTime BFPFEMJMLLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6A90270", Offset = "0x6A8F070", VA = "0x186A90270", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public BPBCMIAOOLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface GHJJELLJAPK
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DateTime BFPFEMJMLLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class EMIBNELLJKB
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static long CGODEBKPNEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6A91830", Offset = "0x6A90630", VA = "0x186A91830")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static long LLPAHGOMLFP
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6A914A0", Offset = "0x6A902A0", VA = "0x186A914A0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static double DCIGHJPICFC
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6A91440", Offset = "0x6A90240", VA = "0x186A91440")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static double HIPHDAGCJCD
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6A91500", Offset = "0x6A90300", VA = "0x186A91500")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static double MBBKBFFKHAK
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6A919B0", Offset = "0x6A907B0", VA = "0x186A919B0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static double PJCLPPAOBNI
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6A91560", Offset = "0x6A90360", VA = "0x186A91560")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6A91900", Offset = "0x6A90700", VA = "0x186A91900")]
	public static double LPFFJFOONBF(long BOCNMEHADMH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6A91670", Offset = "0x6A90470", VA = "0x186A91670")]
	public static double GMDCANOIAIL(long BOCNMEHADMH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6A91390", Offset = "0x6A90190", VA = "0x186A91390")]
	public static double ALGMMOPMHJO(double MELBPAOACEE)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6A915C0", Offset = "0x6A903C0", VA = "0x186A915C0")]
	public static long FJDIOBOLNOO(long AHLFLDNKOCA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6A91820", Offset = "0x6A90620", VA = "0x186A91820")]
	public static long KBJOPJDFHLG(long JEMNGAFFELF, long GIOKOHALJNN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6A91720", Offset = "0x6A90520", VA = "0x186A91720")]
	public static double HCCPDNOFLMK(long JEMNGAFFELF, long GIOKOHALJNN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6A91890", Offset = "0x6A90690", VA = "0x186A91890")]
	public static double LANDPAKBMPP(long JEMNGAFFELF, long GIOKOHALJNN)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class COINNGJHMJM : HJIKCCEABJA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly TimeSpan NMGALDMPKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly System.Timers.Timer NBINANLIAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private TimeSpan OIPLOFODGGB;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TimeSpan NJCKEBBFNCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x741120", Offset = "0x73FF20", VA = "0x180741120", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6A907B0", Offset = "0x6A8F5B0", VA = "0x186A907B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Action? NHPFHBCLKHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7612C0", Offset = "0x7600C0", VA = "0x1807612C0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6A90B90", Offset = "0x6A8F990", VA = "0x186A90B90")]
	[Preserve]
	public COINNGJHMJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6A90970", Offset = "0x6A8F770", VA = "0x186A90970")]
	public COINNGJHMJM(TimeSpan OIPLOFODGGB, [Optional] Action? AIDGLICLKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6A90720", Offset = "0x6A8F520", VA = "0x186A90720", Slot = "7")]
	public void EJEHGNMMKCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6A906E0", Offset = "0x6A8F4E0", VA = "0x186A906E0", Slot = "8")]
	public void EHPLGLOELMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6A90780", Offset = "0x6A8F580", VA = "0x186A90780", Slot = "9")]
	public void JPADCIAGBDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x11E6F10", Offset = "0x11E5D10", VA = "0x1811E6F10")]
	private void LMJJECJEJCH(object IDKOCJBGGJO, ElapsedEventArgs NMDLBOPDKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A905C0", Offset = "0x6A8F3C0", VA = "0x186A905C0")]
	private static void CIDBONGADCH(ref TimeSpan NKDPFAIAJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A90640", Offset = "0x6A8F440", VA = "0x186A90640", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[AttributeUsage(AttributeTargets.All)]
public class ONPFBCLBBFN : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly string JGPONNJOEJO;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x75C880", Offset = "0x75B680", VA = "0x18075C880")]
	public ONPFBCLBBFN(string GMCKDEIFKJM)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct HOJNHGJKFCB : IEquatable<HOJNHGJKFCB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public uint MBIODLCJJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public int MCPELHDHJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public float KDOKGBPCBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public ushort AKCFKHDNGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public ushort FJLDBGMICGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public short GNLEMIHAHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public short KPFDOKPMHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public char NIGJKNNKKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public char FMFFCNEKIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public byte CIGHIOBLOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public byte PDHGJAFOMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public byte MHNFPALBCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public byte IEFHPNLAKDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public bool IICGPPBLEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public bool PKCJABGMKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public bool LDPCAFFFHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public bool JNCNJJAKPFE;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x8EB1D0", Offset = "0x8E9FD0", VA = "0x1808EB1D0")]
	public static HOJNHGJKFCB DKHOABLLJNJ(uint DJMJLPJNABI)
	{
		return default(HOJNHGJKFCB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8EB1D0", Offset = "0x8E9FD0", VA = "0x1808EB1D0")]
	public static HOJNHGJKFCB COCKCGBOHPK(int ENFJEJHBNLE)
	{
		return default(HOJNHGJKFCB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2606600", Offset = "0x2605400", VA = "0x182606600")]
	public static HOJNHGJKFCB PMCGCGABFDA(float CMIOIBIKONN)
	{
		return default(HOJNHGJKFCB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6A91DB0", Offset = "0x6A90BB0", VA = "0x186A91DB0")]
	public static HOJNHGJKFCB CJHKDGBPPFJ(byte LKEMMDKLBGA, byte DBNLJCPHLJP, byte BJDDDPCONDA, byte PGHBHFODOCO)
	{
		return default(HOJNHGJKFCB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6A91DB0", Offset = "0x6A90BB0", VA = "0x186A91DB0")]
	public static HOJNHGJKFCB FNGJKEGGDIA(bool DCGHBCELBGB, bool PPCKDJMIFIO, bool OLFIEOAHNFA, bool GKNKEGFGHPI)
	{
		return default(HOJNHGJKFCB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x1081290", Offset = "0x1080090", VA = "0x181081290")]
	public static bool EJGLOGBEPOL(HOJNHGJKFCB JGEPMPFGKOG, HOJNHGJKFCB CPIBOCOHLLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8E9610", Offset = "0x8E8410", VA = "0x1808E9610", Slot = "4")]
	public bool Equals(HOJNHGJKFCB IDBPJJAKCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A91DD0", Offset = "0x6A90BD0", VA = "0x186A91DD0", Slot = "0")]
	public override bool Equals(object OJGAEOFIMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0xA75730", Offset = "0xA74530", VA = "0x180A75730", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A91E50", Offset = "0x6A90C50", VA = "0x186A91E50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct OIAFKHKIKMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public ulong ACJPKMMDAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public long ODBKAPNOFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public double HAIGFKFGGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public uint JGBCGAAJGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public uint FPOJAKKCGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public int PHFIHDCOBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public int HELMKNIMLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public float MIKGMDBLMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float MNNBOOEDIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public ushort AKCFKHDNGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public ushort FJLDBGMICGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public ushort NNIPNHNILIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public ushort FJEBNOPCEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public short GNLEMIHAHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public short KPFDOKPMHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public short BPPABOJPGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public short NJGFHMCMKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public char NIGJKNNKKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public char FMFFCNEKIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public char JIOJFNNAODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public char LAMPLDAGCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public byte CIGHIOBLOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public byte PDHGJAFOMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public byte MHNFPALBCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public byte IEFHPNLAKDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public byte EKDDEDAFEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public byte AIENMCFOMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public byte BIMHDHDEFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public byte NPPLHGKIHNP;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A94020", Offset = "0x6A92E20", VA = "0x186A94020")]
	public static OIAFKHKIKMA AIJMFKKLHCC(byte LKEMMDKLBGA, byte DBNLJCPHLJP, byte BJDDDPCONDA, byte PGHBHFODOCO, byte LIHLFEEIGED, byte OLDBDMPJNAN, byte NDLINHOCPKP, byte HDBHJCGBKON)
	{
		return default(OIAFKHKIKMA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class LPIGJFJMIEF
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2B26F20", Offset = "0x2B25D20", VA = "0x182B26F20")]
	public static IEnumerable<T> NDAKPHJAOJJ<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7C69F0", Offset = "0x7C57F0", VA = "0x1807C69F0")]
	public static T[] GELLBHMKJAP<T>(params T[] NFJDKOPAPFE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7C69F0", Offset = "0x7C57F0", VA = "0x1807C69F0")]
	public static IEnumerable<T> OMDFEEDBOME<T>(params T[] NFJDKOPAPFE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x22B4780", Offset = "0x22B3580", VA = "0x1822B4780")]
	public static HashSet<T> OOIHADDAAMP<T>(params T[] NFJDKOPAPFE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2B26E30", Offset = "0x2B25C30", VA = "0x182B26E30")]
	public static KeyValuePair<TKey, TValue> DDNOGOPKIKF<TKey, TValue>(in TKey JHANOPJHOLP, in TValue MGFMONLLLPD) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x22B4780", Offset = "0x22B3580", VA = "0x1822B4780")]
	public static List<T> DMMIJKIAFAL<T>(IEnumerable<T> BFGFBJNNCDN) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[AttributeUsage(AttributeTargets.All)]
public sealed class ADOENPMINNG : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly string KLPFFGBJMIB;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x75C880", Offset = "0x75B680", VA = "0x18075C880")]
	public ADOENPMINNG(string PJKMLKEDHEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[INAHLNLFMMC]
public delegate void LLPMGMFCKNE(string ICIEGOLHGJN);
[Cpp2IlInjected.Token(Token = "0x200002A")]
[INAHLNLFMMC]
public delegate void KCJNLDDGMFN();
[Cpp2IlInjected.Token(Token = "0x200002B")]
public delegate object CMBCMKGEMMF<T>(T CFGJGLPAHFD);
[Cpp2IlInjected.Token(Token = "0x200002C")]
public delegate object FPIAIKKLHOA<T>(in T CFGJGLPAHFD);
[Cpp2IlInjected.Token(Token = "0x200002D")]
[INAHLNLFMMC]
public delegate string HGNEHOHOHML(string MDIBKHINKGB, string? EGJCKEHDCCN, bool BMBDJAGHCLN);
[Cpp2IlInjected.Token(Token = "0x200002E")]
[INAHLNLFMMC]
public delegate void JDDNKDMAJOL(string GPAOLHFLBHD);
[Cpp2IlInjected.Token(Token = "0x200002F")]
[INAHLNLFMMC]
public delegate void BGPDEFMFBAF(Exception ADJEGMMBDPA);
[Cpp2IlInjected.Token(Token = "0x2000030")]
public delegate object NPPPHMMDJMN();
[Cpp2IlInjected.Token(Token = "0x2000031")]
[INAHLNLFMMC]
public delegate bool CGMGFDDJDBO();
[Cpp2IlInjected.Token(Token = "0x2000032")]
[INAHLNLFMMC]
public delegate string PGIIGCKKNOM(object OJGAEOFIMPK);
[Cpp2IlInjected.Token(Token = "0x2000033")]
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class NIPHIJANOKG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0xA7DB60", Offset = "0xA7C960", VA = "0x180A7DB60")]
	public NIPHIJANOKG(bool KMACPACGIKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
public sealed class EBFDKJKGMCL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6A910A0", Offset = "0x6A8FEA0", VA = "0x186A910A0")]
	public EBFDKJKGMCL(bool KMACPACGIKO, string DNFACCLDKEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class LBBFCMALCPB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0xA7DB60", Offset = "0xA7C960", VA = "0x180A7DB60")]
	public LBBFCMALCPB(bool KMACPACGIKO)
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
