using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x78D520", Offset = "0x78C920", VA = "0x18078D520")]
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
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x78D520", Offset = "0x78C920", VA = "0x18078D520")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct KLAAANBOPPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int PCAJGFLFLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 NCOAEFGOFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion AALKLPCOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 HDADOFPCELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int JGPBGJCKBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int ECDKMOIOOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int FLDNIAKGCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float MCACMAJPHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 PHAKHIFBJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool FOBPKGBBDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public NOEGBMCPIIK OPOCEINBCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 DCILIKPFPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float OEHLPAFPAMD;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class LNOOBNFAKHJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static DDMAKFBHEHF DOLPPNGHOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<KLAAANBOPPP> IEJNMKOHCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<CBNINCAKMBK> CPLEOFKGADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<GDMPDNJLKDG> BAKNIEIOEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<ECKDFMNEBIM> MAOABHGKBPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<CBNINCAKMBK> AOAMPMFKAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<NOKLDOGEJLI> GLAPDGMINKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<ECKDFMNEBIM>> KDJJPNIJFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<CLFPGGIMCNE> DINFIHNPPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> FGGHPCOHMMA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int POLGGJALALP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAD7450", Offset = "0xAD6850", VA = "0x180AD7450")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xAD6AF0", Offset = "0xAD5EF0", VA = "0x180AD6AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int HNJDPPFFOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xAD7460", Offset = "0xAD6860", VA = "0x180AD7460")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAD5980", Offset = "0xAD4D80", VA = "0x180AD5980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5D21500", Offset = "0x5D20900", VA = "0x185D21500")]
	public LNOOBNFAKHJ(int EHJMEFEJOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5D209C0", Offset = "0x5D1FDC0", VA = "0x185D209C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5D21330", Offset = "0x5D20730", VA = "0x185D21330")]
	public void OCOEOHNAACP(JobHandle HDIPEJPBMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5D20D20", Offset = "0x5D20120", VA = "0x185D20D20")]
	public void KGFKHIPHIMC(KLAAANBOPPP OOIBMCBCEPD, CLFPGGIMCNE PDEIOGALALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5D20F40", Offset = "0x5D20340", VA = "0x185D20F40")]
	public void LCACLLEBEEC(GDMPDNJLKDG OOIBMCBCEPD, NativeArray<ECKDFMNEBIM> IGKAPLDAAAM, int ILFDMDPFNKA, int HNOAEBMNBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F9B0", Offset = "0x5D1EDB0", VA = "0x185D1F9B0")]
	public JobHandle AFBBMKCBHIP(EGDAGDGMKBL OAGGGAOHCCJ, JPAJKKOAMIH NHBDCEFCDPL, float3 GLONKFJPNND, quaternion JFHFENJGFDM, float KAKOEBFBIAC, bool DKCDLJMIHDC, int GBDDLMFCIGN = 0, int NHNJPIHIFLA = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5D209E0", Offset = "0x5D1FDE0", VA = "0x185D209E0")]
	public static JobHandle GIAIPKPFFPE(PPBHHHNGEKG PFJLAMMIMCH, EGDAGDGMKBL OAGGGAOHCCJ, KLAAANBOPPP OOIBMCBCEPD, JobHandle HDIPEJPBMFJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5D21080", Offset = "0x5D20480", VA = "0x185D21080")]
	public static JobHandle NOPIJCAGCHA(BCFIGDHEHAN PFJLAMMIMCH, EGDAGDGMKBL OAGGGAOHCCJ, GDMPDNJLKDG OOIBMCBCEPD, NativeArray<ECKDFMNEBIM> IGKAPLDAAAM, int ILFDMDPFNKA, int HNOAEBMNBGJ, JobHandle HDIPEJPBMFJ)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct EOOAABEKAIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float2 MICBGPINKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float2 PCOFPIMFJLC;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class JBAPIOJMDJO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<EOOAABEKAIK> HAHJCGBBNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<int> BPDNBBCONLC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int POLGGJALALP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x765400", Offset = "0x764800", VA = "0x180765400")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int HNJDPPFFOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x76B420", Offset = "0x76A820", VA = "0x18076B420")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5D1ECC0", Offset = "0x5D1E0C0", VA = "0x185D1ECC0")]
	public JBAPIOJMDJO(int JEMJGHABLLM, int OLFKDJLEDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5D1EB80", Offset = "0x5D1DF80", VA = "0x185D1EB80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5D1EBE0", Offset = "0x5D1DFE0", VA = "0x185D1EBE0")]
	public void EMPJPFIOCIH(JBAPIOJMDJO ODNKJNELBIB, int KKKKHLMLJJJ, int IPFIDMBBIMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PNMOFHAMAGI
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static JBAPIOJMDJO JEBCIDJNOIO;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static NativeList<CBNINCAKMBK> JMOEFAPEIFF;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static int[] BNPOEMKAPOG;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static bool AAKCLHFHKHC;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static Dictionary<int, JBAPIOJMDJO> OAICHMFKHOF;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static Dictionary<int, JBAPIOJMDJO> BCBIGDIKIJM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool OHIIGLPBCKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5D244A0", Offset = "0x5D238A0", VA = "0x185D244A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static NativeList<CBNINCAKMBK> HJJBMCEHNHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5D247B0", Offset = "0x5D23BB0", VA = "0x185D247B0")]
		get
		{
			return default(NativeList<CBNINCAKMBK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static JBAPIOJMDJO KFHHLDMKHAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5D24860", Offset = "0x5D23C60", VA = "0x185D24860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5D23D90", Offset = "0x5D23190", VA = "0x185D23D90")]
	private static void CELCAMDMIMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5D249E0", Offset = "0x5D23DE0", VA = "0x185D249E0")]
	public static int JACNAJBFNMN(bool JEAJECEMPKI, int GDLLGADDCIK, bool HJDGGMKEEGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5D24900", Offset = "0x5D23D00", VA = "0x185D24900")]
	private static int HKNBPKLAIDP(int GDLLGADDCIK, bool MOMEKLBHAPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5D24850", Offset = "0x5D23C50", VA = "0x185D24850")]
	private static int FEMMGDJENGN(int GDLLGADDCIK, bool MOMEKLBHAPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5D243A0", Offset = "0x5D237A0", VA = "0x185D243A0")]
	public static int EDAEBDMMKEA(int EHGKCDIPOOP, int GDLLGADDCIK, int ACCLDKKKDFC, bool MOMEKLBHAPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5D25280", Offset = "0x5D24680", VA = "0x185D25280")]
	public static int PIAHFMJNPKN(int EHGKCDIPOOP, int GDLLGADDCIK, int ACCLDKKKDFC, bool MOMEKLBHAPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5D24F10", Offset = "0x5D24310", VA = "0x185D24F10")]
	public static int NEGIALFOAIB(int ACCLDKKKDFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5D249D0", Offset = "0x5D23DD0", VA = "0x185D249D0")]
	private static int IPFLJNFOGNL(int GDLLGADDCIK, bool MOMEKLBHAPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5D249B0", Offset = "0x5D23DB0", VA = "0x185D249B0")]
	private static int IJMJNJAAKEO(int GDLLGADDCIK, bool MOMEKLBHAPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5D24430", Offset = "0x5D23830", VA = "0x185D24430")]
	public static int EENIGDEAFHB(int EHGKCDIPOOP, int GDLLGADDCIK, int ACCLDKKKDFC, bool MOMEKLBHAPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5D24920", Offset = "0x5D23D20", VA = "0x185D24920")]
	public static int IAMDOPCFAIN(int EHGKCDIPOOP, int GDLLGADDCIK, int ACCLDKKKDFC, bool MOMEKLBHAPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5D24F20", Offset = "0x5D24320", VA = "0x185D24F20")]
	public static int NJOENPCDMLG(int ACCLDKKKDFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5D23CA0", Offset = "0x5D230A0", VA = "0x185D23CA0")]
	public static JBAPIOJMDJO BJAGOLMEHID(int GDLLGADDCIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5D24520", Offset = "0x5D23920", VA = "0x185D24520")]
	private static JBAPIOJMDJO FAGONIMDBHL(int GDLLGADDCIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5D24E20", Offset = "0x5D24220", VA = "0x185D24E20")]
	public static JBAPIOJMDJO KNDGMEKKEPI(int GDLLGADDCIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5D24F40", Offset = "0x5D24340", VA = "0x185D24F40")]
	private static JBAPIOJMDJO PFBBDOMBHPI(int GDLLGADDCIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D24A10", Offset = "0x5D23E10", VA = "0x185D24A10")]
	public static void JDLPKBDKCFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct GDMPDNJLKDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public int LDKKFKJINGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float3 NCOAEFGOFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public quaternion AALKLPCOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float HDADOFPCELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float OIFHEIFGADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int JGPBGJCKBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int ECDKMOIOOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public int FLDNIAKGCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public bool LJDMGJFOEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public bool CJHJKGGPEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float MCACMAJPHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float3 PHAKHIFBJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public bool OBHDMJGJIHO;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct NOKLDOGEJLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int CJOJGLMALNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int NMBLGCNDJNA;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct BCFIGDHEHAN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeList<GDMPDNJLKDG> DALBJCACPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeArray<ECKDFMNEBIM> PAIKEICJMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<CBNINCAKMBK> FIDKPLPCGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeArray<NOKLDOGEJLI> CPGEAACMALH;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5D15C30", Offset = "0x5D15030", VA = "0x185D15C30")]
	public BCFIGDHEHAN(NativeArray<ECKDFMNEBIM> PAIKEICJMIN, int JGDHMDLNCOL = 1, Allocator JIIMEDFKEME = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5D15B40", Offset = "0x5D14F40", VA = "0x185D15B40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[BurstCompile]
public struct PNDMKBIJJLO : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	private NativeArray<EOOAABEKAIK> OKOMOGMCNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	private NativeArray<int> KMHDOBNALJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	private NativeList<CBNINCAKMBK> KNMEEKFALFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	private NativeList<GDMPDNJLKDG> DALBJCACPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	private NativeArray<ECKDFMNEBIM> PAIKEICJMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	private NativeArray<CBNINCAKMBK> FIDKPLPCGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<NOKLDOGEJLI> CPGEAACMALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	private int CFFLOFNHJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	private int ODNENHIPFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	private float3 IJKODMLFNGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	private quaternion EPMHADEDLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	private float3 OFBIBGODAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> BFPCFHEMFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> MMAOABHJGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> LHGAPDKNEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> BODINMNIEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> IHCCDIMLLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> FLPKJOMJOPP;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5D237E0", Offset = "0x5D22BE0", VA = "0x185D237E0")]
	public PNDMKBIJJLO(LNOOBNFAKHJ JAMEKLNCAJC, EGDAGDGMKBL NMPACGHDJDA, float3 NPBCOHMEAGO, quaternion GMAMNKEDAML, float FGKIOGPFFCP, int GBDDLMFCIGN = 0, int NHNJPIHIFLA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5D23A70", Offset = "0x5D22E70", VA = "0x185D23A70")]
	public PNDMKBIJJLO(BCFIGDHEHAN JAMEKLNCAJC, EGDAGDGMKBL NMPACGHDJDA, float3 NPBCOHMEAGO, quaternion GMAMNKEDAML, float3 FGKIOGPFFCP, int GBDDLMFCIGN = 0, int NHNJPIHIFLA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5D23630", Offset = "0x5D22A30", VA = "0x185D23630")]
	private float3 NEPMIAEGBLC(float3 FBJKGGPLHPC, Matrix4x4 BFOCDIMCJIH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5D23760", Offset = "0x5D22B60", VA = "0x185D23760")]
	private float3x3 OIMMKIHEACD(float3x3 DKCDMPCEHOK, float3x3 LEEOIGKNCOA)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5D23620", Offset = "0x5D22A20", VA = "0x185D23620")]
	private float KFALJFPGGIC(float IJMHENINMDB, float MOJFOKNLCPO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5D22310", Offset = "0x5D21710", VA = "0x185D22310", Slot = "4")]
	public void Execute(int ONHPLMEPMIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5D234B0", Offset = "0x5D228B0", VA = "0x185D234B0")]
	private void HBJFDFLKAJI(int ONJNMADHKBC, float3 BAONBICGOEJ, float3 DDEDMKGDKMA, float3 FAHOIHBECBC, float ILPHNFDIOJC, bool PKAIKIIFJDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5D21EB0", Offset = "0x5D212B0", VA = "0x185D21EB0")]
	private void EDANCPNGAIH(GDMPDNJLKDG AKKLNNNJPDM, float3 FJEACGMCDJE, float3x3 BFDFAOOEJAP, float IJMHENINMDB, int FJHDCKAOFFB, int PIPADGPPGOF, int IHOLINIJFMM, float EPDKOFDFLPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5D21860", Offset = "0x5D20C60", VA = "0x185D21860")]
	private void CGCCMBFMCNL(int ONJNMADHKBC, int HCKAJLMADPB, GDMPDNJLKDG AKKLNNNJPDM, float3 FJEACGMCDJE, float3x3 BFDFAOOEJAP, bool NMFHJNHIJGH, float IJMHENINMDB, int FHKHDIACDIG, int IDOKGIINNOO, int IHOLINIJFMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct PPBHHHNGEKG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<KLAAANBOPPP> JMPDBEOBLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public NativeList<CBNINCAKMBK> JJNEAOAMIHF;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5D25520", Offset = "0x5D24920", VA = "0x185D25520")]
	public PPBHHHNGEKG(int JGDHMDLNCOL, Allocator JIIMEDFKEME = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5D25480", Offset = "0x5D24880", VA = "0x185D25480", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[BurstCompile]
public struct BFCIGLIDMMN : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private enum NLCGLHIDNHI
	{
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		X,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		Z
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	private NativeList<float3> KCCIFAFHPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	private NativeArray<float3> APHJFEGNHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[ReadOnly]
	private NativeList<int> MENMGPNGLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	private NativeArray<int> JCMGFJMKMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	private NativeArray<float4> JOBFLAIFGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	[ReadOnly]
	private NativeArray<float4> KPMLDLFHEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[ReadOnly]
	private NativeArray<float4> CNDBBFINOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[ReadOnly]
	private NativeList<float3> EGDBEFCLLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	[ReadOnly]
	private NativeList<CBNINCAKMBK> AEMHOMIDOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[ReadOnly]
	private NativeList<KLAAANBOPPP> JMPDBEOBLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[ReadOnly]
	private NativeList<CBNINCAKMBK> JJNEAOAMIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[ReadOnly]
	private int CFFLOFNHJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[ReadOnly]
	private int ODNENHIPFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> BFPCFHEMFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> MMAOABHJGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> LHGAPDKNEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> BODINMNIEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> IHCCDIMLLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> FLPKJOMJOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private float3 OFBIBGODAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private quaternion EPMHADEDLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private float3 IJKODMLFNGG;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5D17360", Offset = "0x5D16760", VA = "0x185D17360")]
	public BFCIGLIDMMN(LNOOBNFAKHJ JAMEKLNCAJC, EGDAGDGMKBL NMPACGHDJDA, float3 NPBCOHMEAGO, quaternion GMAMNKEDAML, float FGKIOGPFFCP, int GBDDLMFCIGN = 0, int NHNJPIHIFLA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5D17170", Offset = "0x5D16570", VA = "0x185D17170")]
	public BFCIGLIDMMN(PPBHHHNGEKG OOIBMCBCEPD, EGDAGDGMKBL NMPACGHDJDA, float3 NPBCOHMEAGO, quaternion GMAMNKEDAML, float3 FGKIOGPFFCP, int GBDDLMFCIGN = 0, int NHNJPIHIFLA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5D15DB0", Offset = "0x5D151B0", VA = "0x185D15DB0", Slot = "4")]
	public void Execute(int ONHPLMEPMIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5D16DC0", Offset = "0x5D161C0", VA = "0x185D16DC0")]
	private void MBGCHBICKPJ(float4x4 ICCDCMPCLPP, int ONHPLMEPMIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5D16D10", Offset = "0x5D16110", VA = "0x185D16D10")]
	private NLCGLHIDNHI GILJDHDEKHE(float3 DDEDMKGDKMA)
	{
		return default(NLCGLHIDNHI);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5D15D60", Offset = "0x5D15160", VA = "0x185D15D60")]
	private float4 BLLLKBFEPMP(NLCGLHIDNHI DMOIEDFCIIP, int JPEMHHILGGG)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5D16D80", Offset = "0x5D16180", VA = "0x185D16D80")]
	private float2 KLLNEBLKKNO(NLCGLHIDNHI DMOIEDFCIIP, float3 BAONBICGOEJ)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct CLFPGGIMCNE
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum NIOOIPHGFEP
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static CLFPGGIMCNE KLACMHEBBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public float3 HJGCFEACNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float3x3 FJDOJIFNENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float3 NLNGCCHEOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public NIOOIPHGFEP EMLIJIGFNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float3 IMAHABAJLFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public float3 CDBLPHOJMGG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool ADBIFDDOPEC
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5D1A140", Offset = "0x5D19540", VA = "0x185D1A140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float3 ENEDKFDILDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5D1A690", Offset = "0x5D19A90", VA = "0x185D1A690")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5D1A7E0", Offset = "0x5D19BE0", VA = "0x185D1A7E0")]
	public CLFPGGIMCNE(float3 BAONBICGOEJ, quaternion CKFJFCLIANA, float3 JGDHMDLNCOL, NIOOIPHGFEP DJMKKNDNCBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5D19F40", Offset = "0x5D19340", VA = "0x185D19F40")]
	public float CMHMDODLAMA(float3 FJEACGMCDJE, float EFHMIBMLCPJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5D19E50", Offset = "0x5D19250", VA = "0x185D19E50")]
	public bool ADGNIGLCDKN(float3 DDEDMKGDKMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5D1A250", Offset = "0x5D19650", VA = "0x185D1A250")]
	public void FGDJOHICGHC(float3 NPNPONLGMOD, float3x3 JCEKKNCKCLF, float NJMOHJAHKNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5D1A150", Offset = "0x5D19550", VA = "0x185D1A150")]
	private void DPCMCGGEHEP(float3 NODMEHJAHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5D1A400", Offset = "0x5D19800", VA = "0x185D1A400")]
	public void LNAMOIKLDPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct EBJIGHFCIIA : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeList<CLFPGGIMCNE> OOIBMCBCEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeList<float3> PNANCBEKHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeList<int> FDAPJIJNFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> FGGHPCOHMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private NativeList<CBNINCAKMBK> JJNEAOAMIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private int PGKGNGNCHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private int IAHANDIKGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	private float EFHMIBMLCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float IKDNMNKJFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> MFHAAOHNCJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> AFMKNFEEFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> EMIAGFPEPHB;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B9A0", Offset = "0x5D1ADA0", VA = "0x185D1B9A0")]
	public EBJIGHFCIIA(EGDAGDGMKBL PFHPDAMABCN, float CFOLBGJILFO, int IPFIDMBBIMG, int FJHDCKAOFFB, NativeList<CLFPGGIMCNE> OOIBMCBCEPD, NativeArray<int> FGGHPCOHMMA, NativeList<CBNINCAKMBK> JJNEAOAMIHF, JPAJKKOAMIH NHBDCEFCDPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5D1AF00", Offset = "0x5D1A300", VA = "0x185D1AF00", Slot = "4")]
	public void Execute(int PNNOKFIJFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B8E0", Offset = "0x5D1ACE0", VA = "0x185D1B8E0")]
	private bool LCHJLAPNPFP(CLFPGGIMCNE BOGGCLFEFDJ, CLFPGGIMCNE OGHJEHJOFGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B640", Offset = "0x5D1AA40", VA = "0x185D1B640")]
	private bool GAEPBFMDMMG(CLFPGGIMCNE NHFCBHANLPL, int GJPDEALMLPP, int EBNMCOPBKLC, int MGPOAILGFPM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class JPAJKKOAMIH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public NativeArray<bool> DOEFMHLLBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public NativeArray<int> MPGIBMPCJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public NativeArray<bool> LJLMLBKNCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeArray<float> CAKDDCGKDGE;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F7C0", Offset = "0x5D1EBC0", VA = "0x185D1F7C0")]
	public void GICPCOMDHOE(int JEMJGHABLLM, int OLFKDJLEDLM, Allocator JIIMEDFKEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F7A0", Offset = "0x5D1EBA0", VA = "0x185D1F7A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F8C0", Offset = "0x5D1ECC0", VA = "0x185D1F8C0")]
	public void OCOEOHNAACP(JobHandle HDIPEJPBMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public JPAJKKOAMIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct JDLFGPGFKDP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NativeList<float3> PNANCBEKHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private NativeArray<float3> AGMBLIKIPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private NativeArray<float4> EMBGLIHDIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private NativeArray<float2> OILHOPODHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private NativeList<int> FDAPJIJNFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> CKEOKMLGFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private NativeArray<int> KFCOPLMLMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[ReadOnly]
	private NativeArray<bool> MFHAAOHNCJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[ReadOnly]
	private NativeArray<bool> AFMKNFEEFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[ReadOnly]
	private int GBDDLMFCIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[ReadOnly]
	private int NHNJPIHIFLA;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F1C0", Offset = "0x5D1E5C0", VA = "0x185D1F1C0")]
	public JDLFGPGFKDP(EGDAGDGMKBL PFHPDAMABCN, JPAJKKOAMIH NHBDCEFCDPL, int NHNJPIHIFLA = 0, int GBDDLMFCIGN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5D1ED80", Offset = "0x5D1E180", VA = "0x185D1ED80", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F160", Offset = "0x5D1E560", VA = "0x185D1F160")]
	private void MNOHLKKDIFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class PPBKEBIAAAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2552810", Offset = "0x2551C10", VA = "0x182552810")]
	public static bool KGLCGOKANLA<T>(NativeArray<T> FOAJABBKLPB, int JGDHMDLNCOL, Allocator JIIMEDFKEME, NativeArrayOptions MJHKFBFAIOB = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2552950", Offset = "0x2551D50", VA = "0x182552950")]
	public static bool KGLCGOKANLA<T>(NativeList<T> NMLNNLIOHNF, int JGDHMDLNCOL, Allocator JIIMEDFKEME) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum DBDIAOLDDNA
{
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	Near,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	Far,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	None
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface KABNOBNGCIP
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int KPDBGGNKPCD(DBDIAOLDDNA EHGKCDIPOOP);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int LPFIILLGGLJ(DBDIAOLDDNA EHGKCDIPOOP);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PCCGFKCMGDE(DBDIAOLDDNA EHGKCDIPOOP, LNOOBNFAKHJ PNEKIAGPCAB, int ILNOGDBNHOD = -1);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class EGDAGDGMKBL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public const int CGEPKNBFMIE = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public NativeList<float3> KLKKNACILLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public NativeArray<float3> JOEEINHHJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public NativeArray<float4> JMIAEIDDAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public NativeArray<float4> NAHOOLAFHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public NativeArray<float2> IIHCOLHMHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public NativeList<int> DKKLFAGEFFK;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool NAKHODPHEOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5D1BB50", Offset = "0x5D1AF50", VA = "0x185D1BB50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int POLGGJALALP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5D1C770", Offset = "0x5D1BB70", VA = "0x185D1C770")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int HNJDPPFFOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5D1C7F0", Offset = "0x5D1BBF0", VA = "0x185D1C7F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool MMHLFJLEIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5D1C7B0", Offset = "0x5D1BBB0", VA = "0x185D1C7B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BA40", Offset = "0x5D1AE40", VA = "0x185D1BA40", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BB90", Offset = "0x5D1AF90", VA = "0x185D1BB90")]
	public void GICPCOMDHOE(int JEMJGHABLLM, int OLFKDJLEDLM, Allocator JIIMEDFKEME, bool DDBIEKCDMPP, bool FFKGPAJGKOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5D1C830", Offset = "0x5D1BC30", VA = "0x185D1C830")]
	public void OLCKEICELKE(int JEMJGHABLLM, int OLFKDJLEDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BD60", Offset = "0x5D1B160", VA = "0x185D1BD60", Slot = "6")]
	public bool HKBAGGPDJGP(Mesh PFHPDAMABCN, bool MABGJFHAKGM = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5D1C140", Offset = "0x5D1B540", VA = "0x185D1C140")]
	public bool LPJGEODNJBK(Mesh PFHPDAMABCN, EGDAGDGMKBL CFJHHGOBAAA, bool MABGJFHAKGM = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public EGDAGDGMKBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class MLLDGABNMPC
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5D21710", Offset = "0x5D20B10", VA = "0x185D21710")]
	public static void JDLPKBDKCFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class GLGBHKGHEMF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public NativeList<float3> KLKKNACILLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public NativeArray<float3> JOEEINHHJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public NativeArray<int> EHGEDMELKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public NativeArray<float4> MDHEBAMBEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public NativeArray<float4> AKDKKFEDKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public NativeArray<float4> LDNLELADBPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public NativeList<float3> LHGCKMOOILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public NativeList<int> DKKLFAGEFFK;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int POLGGJALALP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5D1D710", Offset = "0x5D1CB10", VA = "0x185D1D710")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int HNJDPPFFOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5D1D750", Offset = "0x5D1CB50", VA = "0x185D1D750")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int NCFHHOIJNBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5D1D6D0", Offset = "0x5D1CAD0", VA = "0x185D1D6D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5D1DA80", Offset = "0x5D1CE80", VA = "0x185D1DA80")]
	public GLGBHKGHEMF(int JEMJGHABLLM, int OLFKDJLEDLM, int FMICDPENONP, Allocator JIIMEDFKEME = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5D1D790", Offset = "0x5D1CB90", VA = "0x185D1D790")]
	public GLGBHKGHEMF(Mesh PFHPDAMABCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5D1C8B0", Offset = "0x5D1BCB0", VA = "0x185D1C8B0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5D1CE50", Offset = "0x5D1C250", VA = "0x185D1CE50")]
	public void EMPJPFIOCIH(GLGBHKGHEMF PFHPDAMABCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5D1C9C0", Offset = "0x5D1BDC0", VA = "0x185D1C9C0")]
	private void EMFBFGDCMLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5D1D150", Offset = "0x5D1C550", VA = "0x185D1D150")]
	private void HBBNFLBMPPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct CBNINCAKMBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public int NILOMENCFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public int POLGGJALALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int PNOELDELLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int HNJDPPFFOOK;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5D19E30", Offset = "0x5D19230", VA = "0x185D19E30")]
	public CBNINCAKMBK(int FJHDCKAOFFB, int ILFDMDPFNKA, int IPFIDMBBIMG, int HNOAEBMNBGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class DDMAKFBHEHF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public NativeList<CBNINCAKMBK> OBGPHNHMLHN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA40000", Offset = "0xA3F400", VA = "0x180A40000")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<CBNINCAKMBK>);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1A436F0", Offset = "0x1A42AF0", VA = "0x181A436F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public GLGBHKGHEMF JCEAEGADHED
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x76B410", Offset = "0x76A810", VA = "0x18076B410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x765100", Offset = "0x764500", VA = "0x180765100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5D1A940", Offset = "0x5D19D40", VA = "0x185D1A940")]
	public DDMAKFBHEHF(IEnumerable<GLGBHKGHEMF> ODELHDLNMCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5D1A8D0", Offset = "0x5D19CD0", VA = "0x185D1A8D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum NOEGBMCPIIK
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class JMONCOGNNMD
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static NativeArray<float2> HIHCOCAGHND;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static NativeArray<float3> LAOPLDPACMN;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static NativeArray<float4> BFHGBEILLIB;

	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static NativeArray<int> FEIKKFFBGNC;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F570", Offset = "0x5D1E970", VA = "0x185D1F570")]
	public static void JDLPKBDKCFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F460", Offset = "0x5D1E860", VA = "0x185D1F460")]
	public static NativeArray<float2> HLONKCJDFPC(NativeArray<float2> FEJBHFJBADI, int FAMHCJFKKDF, NativeArray<float2> DOMKEONGOPH, int JCIEBGFFMBA)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F690", Offset = "0x5D1EA90", VA = "0x185D1F690")]
	public static NativeArray<float3> PBNEOOKLEGA(NativeArray<float3> FEJBHFJBADI, int FAMHCJFKKDF, NativeArray<float3> DOMKEONGOPH, int JCIEBGFFMBA)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F350", Offset = "0x5D1E750", VA = "0x185D1F350")]
	public static NativeArray<float4> HGLEAEDHHFC(NativeArray<float4> FEJBHFJBADI, int FAMHCJFKKDF, NativeArray<float4> DOMKEONGOPH, int JCIEBGFFMBA)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F240", Offset = "0x5D1E640", VA = "0x185D1F240")]
	public static NativeArray<int> HDHLMJHMHGD(NativeArray<int> FEJBHFJBADI, int FAMHCJFKKDF, NativeArray<int> DOMKEONGOPH, int JCIEBGFFMBA)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2416EE0", Offset = "0x24162E0", VA = "0x182416EE0")]
	private static void OGDPKNBLFKA<T>(NativeArray<T> FOAJABBKLPB, int EBOECLNGKHM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2416E30", Offset = "0x2416230", VA = "0x182416E30")]
	private static void AKFCJFGNNOP<T>(NativeArray<T> FEJBHFJBADI, int FAMHCJFKKDF, NativeArray<T> DOMKEONGOPH, int JCIEBGFFMBA, NativeArray<T> NCCIOEJCDAH) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class IOPOIKKIOIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly List<KABNOBNGCIP> KHOGJOHLCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly IEJKDOPFGIA EHJILNMFJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int ILFDMDPFNKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int HNOAEBMNBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private bool JIBPHBEBFJN;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Mesh JCEAEGADHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x767740", Offset = "0x766B40", VA = "0x180767740")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x76DDB0", Offset = "0x76D1B0", VA = "0x18076DDB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public MeshRenderer HPBLMCEOKCF
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x76B430", Offset = "0x76A830", VA = "0x18076B430")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int POLGGJALALP
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5D1E8A0", Offset = "0x5D1DCA0", VA = "0x185D1E8A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1FA60F0", Offset = "0x1FA54F0", VA = "0x181FA60F0")]
	public void ODDACFHINOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5D1EA60", Offset = "0x5D1DE60", VA = "0x185D1EA60")]
	public IOPOIKKIOIK(string DKFEAPHKBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5D1EA20", Offset = "0x5D1DE20", VA = "0x185D1EA20")]
	public void OCOEOHNAACP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5D1E8C0", Offset = "0x5D1DCC0", VA = "0x185D1E8C0")]
	public void MNMEKBECEHB(KABNOBNGCIP EEGBALNAMKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5D1DD10", Offset = "0x5D1D110", VA = "0x185D1DD10")]
	private void EEHKFDPGIBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5D1E700", Offset = "0x5D1DB00", VA = "0x185D1E700")]
	public bool IGAAPLFIFPD(KABNOBNGCIP EEGBALNAMKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5D1E840", Offset = "0x5D1DC40", VA = "0x185D1E840")]
	public bool KNNGDFDBEMF(KABNOBNGCIP EEGBALNAMKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5D1DCA0", Offset = "0x5D1D0A0", VA = "0x185D1DCA0", Slot = "4")]
	public virtual void CBHKEMIGJBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5D1E770", Offset = "0x5D1DB70", VA = "0x185D1E770")]
	public void JHGDAFJFKBH(Transform CKIEOJHNAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5D1DF80", Offset = "0x5D1D380", VA = "0x185D1DF80")]
	public bool FKGNINKGJCM(Transform CKIEOJHNAHP, [Out] (EGDAGDGMKBL destMesh, Mesh mesh, JobHandle job) OOIBMCBCEPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5D1E970", Offset = "0x5D1DD70", VA = "0x185D1E970")]
	public void NMBNKEHABKB([In] (EGDAGDGMKBL destMesh, Mesh mesh, JobHandle job) OOIBMCBCEPD)
	{
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class BatchedMeshRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static readonly ProfilerMarker NBDAJCEOJBE;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static readonly ProfilerMarker IOBNDMANHGO;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private static readonly ProfilerMarker CNCGDMDEELN;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private const int BBJOHCHGDFD = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private Dictionary<Material, List<IOPOIKKIOIK>> EEKFFCCCGLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private List<IOPOIKKIOIK> KFPNBKNDIID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private List<MeshRenderer> HHOJEHOPHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private List<(IOPOIKKIOIK, (EGDAGDGMKBL, Mesh, JobHandle))> JCBOIMBEKDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private bool MBJOMLJKFIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private Dictionary<int, float> GPJEPNLONHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private Dictionary<int, Color> OBEBIGLOJPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private Dictionary<int, Vector4> MIJLPLBMCHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private Dictionary<int, Matrix4x4> DAAHCOKEOHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private IOPOIKKIOIK GHADDLKFKIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private Material GMPBOOBIDHG;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IReadOnlyList<MeshRenderer> KJEGPHNHNIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x767750", Offset = "0x766B50", VA = "0x180767750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5D18DD0", Offset = "0x5D181D0", VA = "0x185D18DD0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5D17550", Offset = "0x5D16950", VA = "0x185D17550")]
		public IOPOIKKIOIK AddToBatchedMesh(KABNOBNGCIP JHAIFCAIBMA, Material CFMOAHBPGNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5D19040", Offset = "0x5D18440", VA = "0x185D19040")]
		public void RemoveFromBatchedMesh(KABNOBNGCIP PFHPDAMABCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5D17630", Offset = "0x5D16A30", VA = "0x185D17630")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5D191C0", Offset = "0x5D185C0", VA = "0x185D191C0")]
		public void SetMaterialProperty(int LNAKMGONIOO, Color KKBAHNFNJMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5D19650", Offset = "0x5D18A50", VA = "0x185D19650")]
		public void SetMaterialProperty(int LNAKMGONIOO, float LPCGJALKADL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5D19870", Offset = "0x5D18C70", VA = "0x185D19870")]
		public void SetMaterialProperty(int LNAKMGONIOO, Vector4 DAOCKEOLOIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5D193F0", Offset = "0x5D187F0", VA = "0x185D193F0")]
		public void SetMaterialProperty(int LNAKMGONIOO, Matrix4x4 MCJOANKFCAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5D177D0", Offset = "0x5D16BD0", VA = "0x185D177D0")]
		private void EBPAFPAABBF(Renderer HOOHFMEGECM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5D17DC0", Offset = "0x5D171C0", VA = "0x185D17DC0")]
		public void ForceUpdateBatchedMeshOnGPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5D17FA0", Offset = "0x5D173A0", VA = "0x185D17FA0")]
		private void MGHLIIPKOPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5D18BD0", Offset = "0x5D17FD0", VA = "0x185D18BD0")]
		private IOPOIKKIOIK OMBJKMMNBFK(KABNOBNGCIP PFHPDAMABCN, Material CFMOAHBPGNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5D17DD0", Offset = "0x5D171D0", VA = "0x185D17DD0")]
		private IOPOIKKIOIK JGPKMGBIJKO(Material CFMOAHBPGNP, int DAHCGBPDCAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5D18720", Offset = "0x5D17B20", VA = "0x185D18720")]
		private IOPOIKKIOIK NLIKPJECIBH(Material CFMOAHBPGNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5D18690", Offset = "0x5D17A90", VA = "0x185D18690")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5D18500", Offset = "0x5D17900", VA = "0x185D18500")]
		public void MarkDirty(KABNOBNGCIP PFHPDAMABCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5D19B70", Offset = "0x5D18F70", VA = "0x185D19B70")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class EIIKFLADMAM<KeyType> : IOPOIKKIOIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly Dictionary<KeyType, KABNOBNGCIP> CBHHECGCFMP;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x30292F0", Offset = "0x30286F0", VA = "0x1830292F0")]
	public EIIKFLADMAM(string DKFEAPHKBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x30292A0", Offset = "0x30286A0", VA = "0x1830292A0")]
	public void MNMEKBECEHB(KeyType IHHOPACLNAK, KABNOBNGCIP EEGBALNAMKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3029100", Offset = "0x3028500", VA = "0x183029100")]
	public bool LAIOACOLDGO(KeyType IHHOPACLNAK, KABNOBNGCIP FJLGIAMMPLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3029060", Offset = "0x3028460", VA = "0x183029060")]
	public void JMLDOKMKMOM(KeyType IHHOPACLNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3028F80", Offset = "0x3028380", VA = "0x183028F80", Slot = "4")]
	public override void CBHKEMIGJBD()
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
