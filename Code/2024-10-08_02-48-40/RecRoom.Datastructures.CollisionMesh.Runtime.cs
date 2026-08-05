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
public struct CDPEMGMOKCL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct ILIDNKMOECA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int JIMLHHCPBCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int MBECFIGFKEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int PHOGIGDFGOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int LJPBGOAOBGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int FMAOPJAMEGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int GEEGBPOKDOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 CNJLAAFJLHJ;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6C2C510", Offset = "0x6C2B710", VA = "0x186C2C510")]
		public ILIDNKMOECA(int IEGOAPJEBAF, int IIPKFCKHLHL, int PFBKMKAIMKA, int MHCGPKKJIID, int GDDIACDIEOB, int IOEBMJKMCAC, float3 DJCLDHHAKMM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct HANPKENIMOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int DEDELMGFLLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int GMCNNMLIKGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float PCOPGIOJIOB;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x14A5220", Offset = "0x14A4420", VA = "0x1814A5220")]
		public HANPKENIMOP(int HBNAJMHMLJE, int EDPMLDGPPIO, float JOBDJKNFOIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct LABGFEGELNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int GMCNNMLIKGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int MFDHIBPLEJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int BBBPKGHEAFE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, ILIDNKMOECA> PBDJGPOEJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<HANPKENIMOP> CBIOGFOIGGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> AIGMCEFKCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<LABGFEGELNP> NIAFJCEDMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> NIDOLDCMMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int ACKGFLBHIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int OKKCHIBMGFD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6C28EC0", Offset = "0x6C280C0", VA = "0x186C28EC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6C29030", Offset = "0x6C28230", VA = "0x186C29030")]
	public bool FFHBABFLKMB([In] NativeArray<float3> FFJDGLHBGNK, NativeList<float3> PJGCHGKHKEH, NativeList<int> KMPPNLIKOCN, Allocator PKPCACFEGCG, CancellationToken DDNLBFLLCLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6C28AE0", Offset = "0x6C27CE0", VA = "0x186C28AE0")]
	private void DDNLIMMJHCH([In] NativeArray<float3> FFJDGLHBGNK, Allocator PKPCACFEGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6C276D0", Offset = "0x6C268D0", VA = "0x186C276D0")]
	private void DCINLJKGHJB([In] NativeArray<float3> FFJDGLHBGNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6C2A4A0", Offset = "0x6C296A0", VA = "0x186C2A4A0")]
	private void JGMHLDPBGJO([In] NativeArray<float3> FFJDGLHBGNK, [Out] int JDKAANIGHHL, [Out] int CFBBGMIIBKG, [Out] int FKECGNFDJEA, [Out] int NBNEFIDONKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6C28CC0", Offset = "0x6C27EC0", VA = "0x186C28CC0")]
	private void DGJBPKEKCOL([In] NativeArray<float3> FFJDGLHBGNK, Allocator PKPCACFEGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6C29FC0", Offset = "0x6C291C0", VA = "0x186C29FC0")]
	private void JFLJMLHILGC([In] NativeArray<float3> FFJDGLHBGNK, float3 IBDHOCLCOJC, int CHBJGECPFCH, ILIDNKMOECA ALEPPJKCKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6C286F0", Offset = "0x6C278F0", VA = "0x186C286F0")]
	private void DCKAPPNNMNO([In] NativeArray<float3> FFJDGLHBGNK, float3 IBDHOCLCOJC, int AJDHLCBOFKA, int OKKCHIBMGFD, ILIDNKMOECA ALEPPJKCKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6C299C0", Offset = "0x6C28BC0", VA = "0x186C299C0")]
	private void IMIMLIICDLB([In] NativeArray<float3> FFJDGLHBGNK, int KBIEJAKKJMN, Allocator PKPCACFEGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6C2AA20", Offset = "0x6C29C20", VA = "0x186C2AA20")]
	private void OLHHBMNLKHD([In] NativeArray<float3> FFJDGLHBGNK, Allocator PKPCACFEGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6C294E0", Offset = "0x6C286E0", VA = "0x186C294E0")]
	private void GPEDBNCDHEH([In] NativeArray<float3> FFJDGLHBGNK, NativeList<float3> PJGCHGKHKEH, NativeList<int> KMPPNLIKOCN, Allocator PKPCACFEGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6C2A9C0", Offset = "0x6C29BC0", VA = "0x186C2A9C0")]
	private float NIKCHPHNGDI(float3 IBDHOCLCOJC, float3 FOLDHDMOOIN, ILIDNKMOECA ALEPPJKCKMJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6C275C0", Offset = "0x6C267C0", VA = "0x186C275C0")]
	private float3 CNJLAAFJLHJ(float3 IEGOAPJEBAF, float3 IIPKFCKHLHL, float3 PFBKMKAIMKA)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6C29000", Offset = "0x6C28200", VA = "0x186C29000")]
	private static float EMGNIDIMGFN(float3 APIBENHOAOO, float3 EGCFJOLCAMD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6C29170", Offset = "0x6C28370", VA = "0x186C29170")]
	private static float3 GAMADEBLFOK(float3 APIBENHOAOO, float3 EGCFJOLCAMD)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6C2A960", Offset = "0x6C29B60", VA = "0x186C2A960")]
	private bool KCJDHDJAFCA(float3 APIBENHOAOO, float3 EGCFJOLCAMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6C2AD90", Offset = "0x6C29F90", VA = "0x186C2AD90")]
	private bool PLLCCEJDOMH(float3 APIBENHOAOO, float3 EGCFJOLCAMD, float3 GPOLJDKBMJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6C291D0", Offset = "0x6C283D0", VA = "0x186C291D0")]
	private bool GDHOGPIIDGE(float3 APIBENHOAOO, float3 EGCFJOLCAMD, float3 GPOLJDKBMJM, float3 JOBDJKNFOIH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct CGIBIAGFPMM : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct JBEHOAAFFDB
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
	private NativeList<float3> EPPIPHCONGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> BHJOIFFLEPD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int BCMOHEPODGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6C2BC40", Offset = "0x6C2AE40", VA = "0x186C2BC40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int JHCDKDJOHKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B010", Offset = "0x6C2A210", VA = "0x186C2B010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LHECKIGJCLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6C2BDA0", Offset = "0x6C2AFA0", VA = "0x186C2BDA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ENFAEKPKIGM LJBJBDBHNLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AE60", Offset = "0x6C2A060", VA = "0x186C2AE60")]
		get
		{
			return default(ENFAEKPKIGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BE10", Offset = "0x6C2B010", VA = "0x186C2BE10")]
	public CGIBIAGFPMM(int KLJHAFCJJBJ, int AJAHOAGDDDF, Allocator PKPCACFEGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BDE0", Offset = "0x6C2AFE0", VA = "0x186C2BDE0")]
	public CGIBIAGFPMM(ENFAEKPKIGM LOKMKJJPMLA, Allocator PKPCACFEGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C230", Offset = "0x6C2B430", VA = "0x186C2C230")]
	public CGIBIAGFPMM(Mesh PGLODJCEFNN, Allocator PKPCACFEGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BED0", Offset = "0x6C2B0D0", VA = "0x186C2BED0")]
	public CGIBIAGFPMM(CGIBIAGFPMM LJIEGDEDOHM, Allocator PKPCACFEGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6C2AF80", Offset = "0x6C2A180", VA = "0x186C2AF80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B050", Offset = "0x6C2A250", VA = "0x186C2B050")]
	public void JIJNOIKPNBF([In] CGIBIAGFPMM KLCFDAPKGEC, float4x4 BOKHKDMLALF, Transform EIIAHDPLMGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B3D0", Offset = "0x6C2A5D0", VA = "0x186C2B3D0")]
	public void KPHNABDADKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B750", Offset = "0x6C2A950", VA = "0x186C2B750")]
	public void OHJNJLBBMGE(float ELNHAHMEPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B520", Offset = "0x6C2A720", VA = "0x186C2B520")]
	public CGIBIAGFPMM LDFLILOHAAA(Allocator PKPCACFEGCG, CancellationToken DDNLBFLLCLM)
	{
		return default(CGIBIAGFPMM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BC80", Offset = "0x6C2AE80", VA = "0x186C2BC80")]
	public Mesh OJNPIFOGFGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6C2AF30", Offset = "0x6C2A130", VA = "0x186C2AF30")]
	private unsafe static float3* DKDALKNNKEN(NativeArray<float3> IEIBCNCHGJN)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6C2AEE0", Offset = "0x6C2A0E0", VA = "0x186C2AEE0")]
	private unsafe static int* DKDALKNNKEN(NativeArray<int> IEIBCNCHGJN)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B720", Offset = "0x6C2A920", VA = "0x186C2B720")]
	[CompilerGenerated]
	internal static void OENOOFFLMCP(int KAEALGHIDNE, int CFPFPJLCANM, JBEHOAAFFDB P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct ENFAEKPKIGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int BCMOHEPODGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int JHCDKDJOHKB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int GFOLJGFKHOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6C2C460", Offset = "0x6C2B660", VA = "0x186C2C460")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x20F42F0", Offset = "0x20F34F0", VA = "0x1820F42F0")]
	public static ENFAEKPKIGM HMOCCFHDLLN(ENFAEKPKIGM APIBENHOAOO, ENFAEKPKIGM EGCFJOLCAMD)
	{
		return default(ENFAEKPKIGM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C3A0", Offset = "0x6C2B5A0", VA = "0x186C2C3A0")]
	public static ENFAEKPKIGM EOLOCGBKMMD(ENFAEKPKIGM FDMHGDPLKJE, int PICIPNDFLHH)
	{
		return default(ENFAEKPKIGM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C3C0", Offset = "0x6C2B5C0", VA = "0x186C2C3C0", Slot = "0")]
	public override bool Equals(object GKAGLCIPADO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C410", Offset = "0x6C2B610", VA = "0x186C2C410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C470", Offset = "0x6C2B670", VA = "0x186C2C470", Slot = "3")]
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
