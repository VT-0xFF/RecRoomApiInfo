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
public struct DMMGDMNLIGC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct LJAEGGLBIJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int BEPDKDLGKBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int MOEIGKGDPKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int PHLFBHLGAJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int MHOHOMKHKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int AHALBMCDDNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int ANHIAANJMPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 INBOMLEDLJM;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8079260", Offset = "0x8078060", VA = "0x188079260")]
		public LJAEGGLBIJO(int MBGABICMPJG, int ENCNEIGDFEI, int LPHEFBIKAMI, int PBJFCKICJKK, int EEAJCILOLCB, int BLFIEKJLANH, float3 LCJFLGICHDD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct IHAAEKMKACG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int GEANGIKPIOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int IEEOLFBKNLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float ADGGDMCAMLN;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xDCED70", Offset = "0xDCDB70", VA = "0x180DCED70")]
		public IHAAEKMKACG(int JEDAAEHCPKE, int NANAFNILHLE, float EMDDNMINEBB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct MMHEBPADCIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int IEEOLFBKNLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int PCOGEACDNBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int DAGECLLBIBE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, LJAEGGLBIJO> BBMGLGACOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<IHAAEKMKACG> LDOMCNAKDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> CKBCHFOKPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<MMHEBPADCIB> KDAAGIHLDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> DFDCKAFKNFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int EAHHMLBKAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int EOLKLFFCPNE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x80763D0", Offset = "0x80751D0", VA = "0x1880763D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8076890", Offset = "0x8075690", VA = "0x188076890")]
	public bool FOKBJJEECKE([In] NativeArray<float3> KDJFEKEJBPI, NativeList<float3> KGIAABJAALK, NativeList<int> LMONDNDJEIO, Allocator DFGMDNGNOEN, CancellationToken HIMDFBHMPLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x80761F0", Offset = "0x8074FF0", VA = "0x1880761F0")]
	private void DGPDNICIDDD([In] NativeArray<float3> KDJFEKEJBPI, Allocator DFGMDNGNOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8077C90", Offset = "0x8076A90", VA = "0x188077C90")]
	private void NBJNCKKANBK([In] NativeArray<float3> KDJFEKEJBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8075D30", Offset = "0x8074B30", VA = "0x188075D30")]
	private void BPILJALAMFC([In] NativeArray<float3> KDJFEKEJBPI, [Out] int BMCINCLHPAH, [Out] int NBLCLPJGDNI, [Out] int KGMPGCLIEBE, [Out] int GIKBPOMEFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8077420", Offset = "0x8076220", VA = "0x188077420")]
	private void IEMAECIBHOE([In] NativeArray<float3> KDJFEKEJBPI, Allocator DFGMDNGNOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8078CB0", Offset = "0x8077AB0", VA = "0x188078CB0")]
	private void OMNGMECFIMP([In] NativeArray<float3> KDJFEKEJBPI, float3 KDBPFEMFFGD, int FEFFPAJLBEN, LJAEGGLBIJO HBPLLIFFKNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x80769D0", Offset = "0x80757D0", VA = "0x1880769D0")]
	private void GICAIJLFFCL([In] NativeArray<float3> KDJFEKEJBPI, float3 KDBPFEMFFGD, int MNDBHHBLJKK, int EOLKLFFCPNE, LJAEGGLBIJO HBPLLIFFKNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8076E20", Offset = "0x8075C20", VA = "0x188076E20")]
	private void HOFIPLKNIHC([In] NativeArray<float3> KDJFEKEJBPI, int ENBFDMLGPOB, Allocator DFGMDNGNOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x80759C0", Offset = "0x80747C0", VA = "0x1880759C0")]
	private void BLBAJGOCICM([In] NativeArray<float3> KDJFEKEJBPI, Allocator DFGMDNGNOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8077790", Offset = "0x8076590", VA = "0x188077790")]
	private void MEGPAKJODJD([In] NativeArray<float3> KDJFEKEJBPI, NativeList<float3> KGIAABJAALK, NativeList<int> LMONDNDJEIO, Allocator DFGMDNGNOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8076DC0", Offset = "0x8075BC0", VA = "0x188076DC0")]
	private float GJDLFLHNLAK(float3 KDBPFEMFFGD, float3 GPLODHGFDLE, LJAEGGLBIJO HBPLLIFFKNL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8077620", Offset = "0x8076420", VA = "0x188077620")]
	private float3 INBOMLEDLJM(float3 MBGABICMPJG, float3 ENCNEIGDFEI, float3 LPHEFBIKAMI)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8077C60", Offset = "0x8076A60", VA = "0x188077C60")]
	private static float NALEOBJDNDL(float3 LKPLCEODICL, float3 MANCHAKPLNN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8076830", Offset = "0x8075630", VA = "0x188076830")]
	private static float3 ECNEGKANFOH(float3 LKPLCEODICL, float3 MANCHAKPLNN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8077730", Offset = "0x8076530", VA = "0x188077730")]
	private bool MCKAOODPLDG(float3 LKPLCEODICL, float3 MANCHAKPLNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8079190", Offset = "0x8077F90", VA = "0x188079190")]
	private bool PLHBNCHPHKF(float3 LKPLCEODICL, float3 MANCHAKPLNN, float3 BEIDDJJHBIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8076510", Offset = "0x8075310", VA = "0x188076510")]
	private bool EABPFKHLDED(float3 LKPLCEODICL, float3 MANCHAKPLNN, float3 BEIDDJJHBIM, float3 EMDDNMINEBB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct AOKGGNBPEOH : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct CMJAOJJAOGD
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
	private NativeList<float3> JICAPNBHCNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> GMADDJJIBJF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int KOJBEOFPENK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8074C60", Offset = "0x8073A60", VA = "0x188074C60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int HLNHDJIIFOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8074670", Offset = "0x8073470", VA = "0x188074670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HFECACFKEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8074730", Offset = "0x8073530", VA = "0x188074730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public BAGAGCCKHJB ELJEHBAPMEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x80746B0", Offset = "0x80734B0", VA = "0x1880746B0")]
		get
		{
			return default(BAGAGCCKHJB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8075290", Offset = "0x8074090", VA = "0x188075290")]
	public AOKGGNBPEOH(int HEDKJAMMPBF, int HMNHJJLMHFP, Allocator DFGMDNGNOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x80754C0", Offset = "0x80742C0", VA = "0x1880754C0")]
	public AOKGGNBPEOH(BAGAGCCKHJB PJBIJEDCOJN, Allocator DFGMDNGNOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8075350", Offset = "0x8074150", VA = "0x188075350")]
	public AOKGGNBPEOH(Mesh JLPONKINLEO, Allocator DFGMDNGNOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x80754F0", Offset = "0x80742F0", VA = "0x1880754F0")]
	public AOKGGNBPEOH(AOKGGNBPEOH BOIPFNOKGBJ, Allocator DFGMDNGNOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x80745E0", Offset = "0x80733E0", VA = "0x1880745E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8074F10", Offset = "0x8073D10", VA = "0x188074F10")]
	public void OLHPIGGMIDE([In] AOKGGNBPEOH PBOOMELBCNJ, float4x4 NNHONNMDIEJ, Transform AMHCNBHLEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8074DC0", Offset = "0x8073BC0", VA = "0x188074DC0")]
	public void JNNPOHBPNMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8074770", Offset = "0x8073570", VA = "0x188074770")]
	public void FONDNPDINKI(float NGOCCMOBNDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x80743B0", Offset = "0x80731B0", VA = "0x1880743B0")]
	public AOKGGNBPEOH CENLCBAIPIM(Allocator DFGMDNGNOEN, CancellationToken HIMDFBHMPLL)
	{
		return default(AOKGGNBPEOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8074CA0", Offset = "0x8073AA0", VA = "0x188074CA0")]
	public Mesh JDFMHAGBLPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8074310", Offset = "0x8073110", VA = "0x188074310")]
	private unsafe static float3* BIEHHHHONON(NativeArray<float3> COPOPHFGNFG)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8074360", Offset = "0x8073160", VA = "0x188074360")]
	private unsafe static int* BIEHHHHONON(NativeArray<int> COPOPHFGNFG)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x80745B0", Offset = "0x80733B0", VA = "0x1880745B0")]
	[CompilerGenerated]
	internal static void DNPEKCCAOFD(int ELMKDDFLDEI, int EKDAILLDPHJ, CMJAOJJAOGD P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct BAGAGCCKHJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int KOJBEOFPENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int HLNHDJIIFOM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int NANJFDJAPDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8075850", Offset = "0x8074650", VA = "0x188075850")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x288F9B0", Offset = "0x288E7B0", VA = "0x18288F9B0")]
	public static BAGAGCCKHJB IIPBKEKCMOJ(BAGAGCCKHJB LKPLCEODICL, BAGAGCCKHJB MANCHAKPLNN)
	{
		return default(BAGAGCCKHJB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8075900", Offset = "0x8074700", VA = "0x188075900")]
	public static BAGAGCCKHJB IJFMOGFKGLM(BAGAGCCKHJB MBBFAEIFBOL, int GAHCIOCKFAM)
	{
		return default(BAGAGCCKHJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8075860", Offset = "0x8074660", VA = "0x188075860", Slot = "0")]
	public override bool Equals(object BENNJGCCPIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x80758B0", Offset = "0x80746B0", VA = "0x1880758B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8075920", Offset = "0x8074720", VA = "0x188075920", Slot = "3")]
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
