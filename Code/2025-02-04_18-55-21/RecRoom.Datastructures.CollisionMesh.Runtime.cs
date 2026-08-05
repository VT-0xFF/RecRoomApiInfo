using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct INEEAIDDILI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct FCEPDCFHAKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int NCCGODKECBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int MEIDIMAAGLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int BHCLFHABEMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int DBLJJCJMEBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int KPIGKMDKDKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int MEHGAHFMGDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 IHCJOJAHMGM;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x723DC20", Offset = "0x723CA20", VA = "0x18723DC20")]
		public FCEPDCFHAKJ(int KAIJPEGEGEG, int HFOIKCHKEFL, int IDAKIEPMMBH, int GLHPENMAEBN, int DPMIKPEOBHE, int HCMJKIEIHJO, float3 FOPIBLDPFFK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct CAPIHJCCKGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int CNKHDOIHKGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int JKEOOKMPFFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float IOEDOACDFEJ;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xB6F400", Offset = "0xB6E200", VA = "0x180B6F400")]
		public CAPIHJCCKGJ(int HLIJNINJIMK, int DCMLINGDKBO, float HLACKEEMAEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct DGENAMMMCFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int JKEOOKMPFFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int LIPGHGANBGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int GBMLKJKGMPP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, FCEPDCFHAKJ> KMNPDCCCEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<CAPIHJCCKGJ> LHLCPJGIJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> OPJNBHLPNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<DGENAMMMCFA> NDIKCACMNJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> OIMCHOMACPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int JHIJJCKCEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int CLCJPGMMKPA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x723EF10", Offset = "0x723DD10", VA = "0x18723EF10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x723F0B0", Offset = "0x723DEB0", VA = "0x18723F0B0")]
	public bool EFELPMNJOBJ([In] NativeArray<float3> JNOAOADCBIC, NativeList<float3> OGMLDJHKFDA, NativeList<int> LCOKLBEKLFO, Allocator GCNJHJPCIGN, CancellationToken FEHCANHDGHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x723F750", Offset = "0x723E550", VA = "0x18723F750")]
	private void JEELJGCJJCO([In] NativeArray<float3> JNOAOADCBIC, Allocator GCNJHJPCIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x723DEF0", Offset = "0x723CCF0", VA = "0x18723DEF0")]
	private void COMPNKLMCDK([In] NativeArray<float3> JNOAOADCBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x723F930", Offset = "0x723E730", VA = "0x18723F930")]
	private void KCFDLLACEGC([In] NativeArray<float3> JNOAOADCBIC, [Out] int LKPOPIAOLBC, [Out] int DDAJPMKGMJO, [Out] int JAEHCNPNKID, [Out] int GGNNDKEGHJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x723DCC0", Offset = "0x723CAC0", VA = "0x18723DCC0")]
	private void BFIGMOGPLCB([In] NativeArray<float3> JNOAOADCBIC, Allocator GCNJHJPCIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7240160", Offset = "0x723EF60", VA = "0x187240160")]
	private void MPNNFIIPDDM([In] NativeArray<float3> JNOAOADCBIC, float3 OHIOLMDNDJK, int FACHDKFODJE, FCEPDCFHAKJ EKCOMAJJMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7240640", Offset = "0x723F440", VA = "0x187240640")]
	private void NKHDCMOCKEN([In] NativeArray<float3> JNOAOADCBIC, float3 OHIOLMDNDJK, int DMHJEAMEFPL, int CLCJPGMMKPA, FCEPDCFHAKJ EKCOMAJJMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7240A30", Offset = "0x723F830", VA = "0x187240A30")]
	private void NPENFEOIGKH([In] NativeArray<float3> JNOAOADCBIC, int IOIEFMEGGLN, Allocator GCNJHJPCIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x723FDF0", Offset = "0x723EBF0", VA = "0x18723FDF0")]
	private void MHBKKCACAKE([In] NativeArray<float3> JNOAOADCBIC, Allocator GCNJHJPCIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7241030", Offset = "0x723FE30", VA = "0x187241030")]
	private void PGKLENBBJPC([In] NativeArray<float3> JNOAOADCBIC, NativeList<float3> OGMLDJHKFDA, NativeList<int> LCOKLBEKLFO, Allocator GCNJHJPCIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x723DC60", Offset = "0x723CA60", VA = "0x18723DC60")]
	private float AMIMGPFLCDO(float3 OHIOLMDNDJK, float3 MCINDDCMKNC, FCEPDCFHAKJ EKCOMAJJMBL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x723F640", Offset = "0x723E440", VA = "0x18723F640")]
	private float3 IHCJOJAHMGM(float3 KAIJPEGEGEG, float3 HFOIKCHKEFL, float3 IDAKIEPMMBH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x723DEC0", Offset = "0x723CCC0", VA = "0x18723DEC0")]
	private static float BKIGIMMODAB(float3 HJGGLHBFMKO, float3 AGAPPIBJJBC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x723F510", Offset = "0x723E310", VA = "0x18723F510")]
	private static float3 FPBELDHFPIM(float3 HJGGLHBFMKO, float3 AGAPPIBJJBC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x723F050", Offset = "0x723DE50", VA = "0x18723F050")]
	private bool ECJGHOPKIAC(float3 HJGGLHBFMKO, float3 AGAPPIBJJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x723F570", Offset = "0x723E370", VA = "0x18723F570")]
	private bool ICAEHCCCCAO(float3 HJGGLHBFMKO, float3 AGAPPIBJJBC, float3 MKIHPGLMNDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x723F1F0", Offset = "0x723DFF0", VA = "0x18723F1F0")]
	private bool FDIIHPEIONE(float3 HJGGLHBFMKO, float3 AGAPPIBJJBC, float3 MKIHPGLMNDF, float3 HLACKEEMAEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct CNGEDEDEBDB : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct FJBIBJLIPKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public unsafe int* indices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int indexCount;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NativeList<float3> POOKPAFAJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> IDLAFCCJMLD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int CAIKGCFBPEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x723D470", Offset = "0x723C270", VA = "0x18723D470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int KFOLEKCLBDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x723D4B0", Offset = "0x723C2B0", VA = "0x18723D4B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HLLEOGFNEAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x723CF10", Offset = "0x723BD10", VA = "0x18723CF10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public DBHJNCMCFGB HHKGDPNOGON
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x723D070", Offset = "0x723BE70", VA = "0x18723D070")]
		get
		{
			return default(DBHJNCMCFGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x723D690", Offset = "0x723C490", VA = "0x18723D690")]
	public CNGEDEDEBDB(int BMPEILPNEKI, int AIGDFINPDKD, Allocator GCNJHJPCIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x723D4F0", Offset = "0x723C2F0", VA = "0x18723D4F0")]
	public CNGEDEDEBDB(DBHJNCMCFGB PGHGJAAECJN, Allocator GCNJHJPCIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x723D520", Offset = "0x723C320", VA = "0x18723D520")]
	public CNGEDEDEBDB(Mesh KLMHPHDLFFG, Allocator GCNJHJPCIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x723D750", Offset = "0x723C550", VA = "0x18723D750")]
	public CNGEDEDEBDB(CNGEDEDEBDB JOAPLPPIFPC, Allocator GCNJHJPCIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x723CA60", Offset = "0x723B860", VA = "0x18723CA60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x723D0F0", Offset = "0x723BEF0", VA = "0x18723D0F0")]
	public void MDGAONDGEMG([In] CNGEDEDEBDB EDLHCINOAKH, float4x4 DBNIFHLIALC, Transform LFOOGOBHMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x723CAF0", Offset = "0x723B8F0", VA = "0x18723CAF0")]
	public void EODBDHHIDGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x723C570", Offset = "0x723B370", VA = "0x18723C570")]
	public void CPEJEEOOELF(float HKMCFNGLEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x723CC70", Offset = "0x723BA70", VA = "0x18723CC70")]
	public CNGEDEDEBDB GIPGLFMNIAG(Allocator GCNJHJPCIGN, CancellationToken FEHCANHDGHE)
	{
		return default(CNGEDEDEBDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x723CF50", Offset = "0x723BD50", VA = "0x18723CF50")]
	public Mesh HIPCBHNDELB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x723CE70", Offset = "0x723BC70", VA = "0x18723CE70")]
	private unsafe static float3* GOGIHIDNIBK(NativeArray<float3> EOOCBMPNEML)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x723CEC0", Offset = "0x723BCC0", VA = "0x18723CEC0")]
	private unsafe static int* GOGIHIDNIBK(NativeArray<int> EOOCBMPNEML)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x723CC40", Offset = "0x723BA40", VA = "0x18723CC40")]
	[CompilerGenerated]
	internal static void GFMHJCGONKH(int DIKCFLIGCLF, int PMKGOLLFADK, FJBIBJLIPKJ P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct DBHJNCMCFGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int CAIKGCFBPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int KFOLEKCLBDE;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int KFNOJMPDPON
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x723DB70", Offset = "0x723C970", VA = "0x18723DB70")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2429610", Offset = "0x2428410", VA = "0x182429610")]
	public static DBHJNCMCFGB FGBMGJFOFOB(DBHJNCMCFGB HJGGLHBFMKO, DBHJNCMCFGB AGAPPIBJJBC)
	{
		return default(DBHJNCMCFGB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x723DB50", Offset = "0x723C950", VA = "0x18723DB50")]
	public static DBHJNCMCFGB JFLPIDOFHFC(DBHJNCMCFGB HDLLOOLHGPL, int PANJCGCFAKM)
	{
		return default(DBHJNCMCFGB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x723DAB0", Offset = "0x723C8B0", VA = "0x18723DAB0", Slot = "0")]
	public override bool Equals(object LEFMKCEMCLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x723DB00", Offset = "0x723C900", VA = "0x18723DB00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x723DB80", Offset = "0x723C980", VA = "0x18723DB80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace Cpp2IlInjected;

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
