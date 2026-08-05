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
public struct LDEDPPKIDBJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct FMEANNOHBAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int GEJPMKJCOBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int AOBCHKEEFBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int BJCGHNIDOOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int HMPKDGFMGAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int PBNPHPAKIHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int CANGKKCMICD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 GIMIAIDDGOD;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6D0C9C0", Offset = "0x6D0BDC0", VA = "0x186D0C9C0")]
		public FMEANNOHBAI(int LJOCABNFJID, int AIHDGCOJNGE, int APPACMLHEOP, int CJDJLJLFEEP, int ECBCPDBINOI, int GFJCNHCCFGK, float3 HAGCLANLPAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct BEBFDJCCGBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int PIMBBAHHLCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int OOCJKLJFHAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float BMPAPCBFNNE;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1517B00", Offset = "0x1516F00", VA = "0x181517B00")]
		public BEBFDJCCGBA(int NKKDINBLGEI, int MGHOGMHECPP, float GLPIIJCKGCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct OJKLBCIPOBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int OOCJKLJFHAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int FNFHPIAMOOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int DDGIJPCOFFM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, FMEANNOHBAI> DPBCGIFBCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<BEBFDJCCGBA> LDKJHGCDDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> MEHDFBCKGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<OJKLBCIPOBM> NNALKKDGHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> IIPDCIFOHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int BLKFEHPMOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int ICJINFPNEGA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6D0E250", Offset = "0x6D0D650", VA = "0x186D0E250", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6D0F870", Offset = "0x6D0EC70", VA = "0x186D0F870")]
	public bool KJMEEFFDKOE([In] NativeArray<float3> LDODCAMBPHC, NativeList<float3> HOAPCFLIAEK, NativeList<int> GELILLPLHOC, Allocator DBCOPEDFGJL, CancellationToken GBOOEEMCFEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6D0F9B0", Offset = "0x6D0EDB0", VA = "0x186D0F9B0")]
	private void NOCOEJHJFAP([In] NativeArray<float3> LDODCAMBPHC, Allocator DBCOPEDFGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6D0CBD0", Offset = "0x6D0BFD0", VA = "0x186D0CBD0")]
	private void BPMBJIENDKA([In] NativeArray<float3> LDODCAMBPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6D0EA10", Offset = "0x6D0DE10", VA = "0x186D0EA10")]
	private void JKILEIKPAMN([In] NativeArray<float3> LDODCAMBPHC, [Out] int KFAGIOCGGBO, [Out] int HDJIMJGIEBL, [Out] int JNHNCPBJHAN, [Out] int FAFJDIHPPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6D10220", Offset = "0x6D0F620", VA = "0x186D10220")]
	private void OJLAOBKNKHB([In] NativeArray<float3> LDODCAMBPHC, Allocator DBCOPEDFGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6D0EED0", Offset = "0x6D0E2D0", VA = "0x186D0EED0")]
	private void KBOBKBFMPJL([In] NativeArray<float3> LDODCAMBPHC, float3 FJJNEGEALHA, int NMODLIBGNJF, FMEANNOHBAI GMLAMNFLEAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6D0F480", Offset = "0x6D0E880", VA = "0x186D0F480")]
	private void KHLJNKEMHIK([In] NativeArray<float3> LDODCAMBPHC, float3 FJJNEGEALHA, int OJLMBCNGPCF, int ICJINFPNEGA, FMEANNOHBAI GMLAMNFLEAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6D0DBF0", Offset = "0x6D0CFF0", VA = "0x186D0DBF0")]
	private void CFACLLGACOL([In] NativeArray<float3> LDODCAMBPHC, int FNONCPPCJMK, Allocator DBCOPEDFGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6D0FB90", Offset = "0x6D0EF90", VA = "0x186D0FB90")]
	private void OAGAEKCBBEM([In] NativeArray<float3> LDODCAMBPHC, Allocator DBCOPEDFGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6D0E4D0", Offset = "0x6D0D8D0", VA = "0x186D0E4D0")]
	private void HEGCAHFPMLK([In] NativeArray<float3> LDODCAMBPHC, NativeList<float3> HOAPCFLIAEK, NativeList<int> GELILLPLHOC, Allocator DBCOPEDFGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6D0CB70", Offset = "0x6D0BF70", VA = "0x186D0CB70")]
	private float BAMMNJPOEFG(float3 FJJNEGEALHA, float3 JOGPIIIHCGL, FMEANNOHBAI GMLAMNFLEAI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6D0E390", Offset = "0x6D0D790", VA = "0x186D0E390")]
	private float3 GIMIAIDDGOD(float3 LJOCABNFJID, float3 AIHDGCOJNGE, float3 APPACMLHEOP)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6D0E4A0", Offset = "0x6D0D8A0", VA = "0x186D0E4A0")]
	private static float GLHINAGEOOP(float3 FIGPMCHHKJO, float3 LLNOONNFEHK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6D0E9B0", Offset = "0x6D0DDB0", VA = "0x186D0E9B0")]
	private static float3 IPJKFAPOIII(float3 FIGPMCHHKJO, float3 LLNOONNFEHK)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6D0E1F0", Offset = "0x6D0D5F0", VA = "0x186D0E1F0")]
	private bool CKEALACGJMI(float3 FIGPMCHHKJO, float3 LLNOONNFEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6D0F3B0", Offset = "0x6D0E7B0", VA = "0x186D0F3B0")]
	private bool KEFHHILCLEK(float3 FIGPMCHHKJO, float3 LLNOONNFEHK, float3 JPCJICGNBND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6D0FF00", Offset = "0x6D0F300", VA = "0x186D0FF00")]
	private bool ODDFPKODPEN(float3 FIGPMCHHKJO, float3 LLNOONNFEHK, float3 JPCJICGNBND, float3 GLPIIJCKGCI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct PNHIIIJDFLH : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct GCBMLAEIJBA
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
	private NativeList<float3> IPOPJBKKNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> CHCKHCIJNMJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int CGHKBDLAPID
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6D10F60", Offset = "0x6D10360", VA = "0x186D10F60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int BAINBALNHCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6D10E00", Offset = "0x6D10200", VA = "0x186D10E00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DINKENCDIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6D10550", Offset = "0x6D0F950", VA = "0x186D10550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public LCJFNHEONCH IKOKBJJPLIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6D10FD0", Offset = "0x6D103D0", VA = "0x186D10FD0")]
		get
		{
			return default(LCJFNHEONCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6D11870", Offset = "0x6D10C70", VA = "0x186D11870")]
	public PNHIIIJDFLH(int JJMBBDFCOFB, int HPGKMCIBAGD, Allocator DBCOPEDFGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6D11930", Offset = "0x6D10D30", VA = "0x186D11930")]
	public PNHIIIJDFLH(LCJFNHEONCH CJOFMGKLADM, Allocator DBCOPEDFGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6D113A0", Offset = "0x6D107A0", VA = "0x186D113A0")]
	public PNHIIIJDFLH(Mesh OHLMFEKEKFF, Allocator DBCOPEDFGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6D11510", Offset = "0x6D10910", VA = "0x186D11510")]
	public PNHIIIJDFLH(PNHIIIJDFLH EIFGKHNPLEK, Allocator DBCOPEDFGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6D104C0", Offset = "0x6D0F8C0", VA = "0x186D104C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6D10590", Offset = "0x6D0F990", VA = "0x186D10590")]
	public void FNBCENOGBNB([In] PNHIIIJDFLH LHOBDGJGOHD, float4x4 OJEAPADKDDG, Transform IDCGNGNIFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6D11050", Offset = "0x6D10450", VA = "0x186D11050")]
	public void LOANCJGOPAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6D10910", Offset = "0x6D0FD10", VA = "0x186D10910")]
	public void GLCECNJCAIF(float ILHNKLAHFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6D111A0", Offset = "0x6D105A0", VA = "0x186D111A0")]
	public PNHIIIJDFLH NACBGHCIEFP(Allocator DBCOPEDFGJL, CancellationToken GBOOEEMCFEA)
	{
		return default(PNHIIIJDFLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6D10E40", Offset = "0x6D10240", VA = "0x186D10E40")]
	public Mesh IGOEGJKNKJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6D10420", Offset = "0x6D0F820", VA = "0x186D10420")]
	private unsafe static float3* CLDHECLFOJC(NativeArray<float3> EFKOIGFMOHD)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6D10470", Offset = "0x6D0F870", VA = "0x186D10470")]
	private unsafe static int* CLDHECLFOJC(NativeArray<int> EFKOIGFMOHD)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6D10FA0", Offset = "0x6D103A0", VA = "0x186D10FA0")]
	[CompilerGenerated]
	internal static void JHACEPJFBDO(int MKPJBBKDDDA, int HGAAFHKKHIM, GCBMLAEIJBA P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct LCJFNHEONCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int CGHKBDLAPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int BAINBALNHCN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int PCFEOOJACHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6D0CAC0", Offset = "0x6D0BEC0", VA = "0x186D0CAC0")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x216C5B0", Offset = "0x216B9B0", VA = "0x18216C5B0")]
	public static LCJFNHEONCH MMCDHOJJGKB(LCJFNHEONCH FIGPMCHHKJO, LCJFNHEONCH LLNOONNFEHK)
	{
		return default(LCJFNHEONCH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6D0CA50", Offset = "0x6D0BE50", VA = "0x186D0CA50")]
	public static LCJFNHEONCH FJDBGKEDFJM(LCJFNHEONCH FEPFHDNBLKP, int KNIHHDMJHNC)
	{
		return default(LCJFNHEONCH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6D0CA00", Offset = "0x6D0BE00", VA = "0x186D0CA00", Slot = "0")]
	public override bool Equals(object CPGHMGPNEHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6D0CA70", Offset = "0x6D0BE70", VA = "0x186D0CA70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6D0CAD0", Offset = "0x6D0BED0", VA = "0x186D0CAD0", Slot = "3")]
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
