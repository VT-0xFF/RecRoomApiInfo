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
public struct FEONAMLDMDI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct OIGDNMIAENL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int KEIBCLBGCHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int GDAFPFLMMNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int CGNBDLLIPAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int PAFFLCPLBPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int BCDABOPJKCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int PKMDKCKMJHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 JPFFAFOAGGH;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x611DB20", Offset = "0x611CD20", VA = "0x18611DB20")]
		public OIGDNMIAENL(int AFCODMFIOPI, int CFMPNDDKCMK, int HLEKDJLMACP, int IEEALFMGIAM, int PFBAPJFFGDL, int IHFKMMFIBOI, float3 NNFMJLGEBBE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct HENDLMCGHMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int BBNKHJGCHLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int BJACMKNLFOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float HPFIHGJPPCA;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1024080", Offset = "0x1023280", VA = "0x181024080")]
		public HENDLMCGHMP(int MLNANLHFBGF, int FGLDOBMPKHF, float DFLLICFNDLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct EOILCMKJOID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int BJACMKNLFOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int JGJNCINOBGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int OHOJGEBLHCE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, OIGDNMIAENL> JOEKBCJFGMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<HENDLMCGHMP> FNNDCEBIHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> BNKEINMKBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<EOILCMKJOID> POPMPCHOGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> MLLELDACLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int IANINLFPKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int JPBKAODJACL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x611A4A0", Offset = "0x61196A0", VA = "0x18611A4A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6118CB0", Offset = "0x6117EB0", VA = "0x186118CB0")]
	public bool ADIBMFJEFJD([In] NativeArray<float3> OGGIPEKOIHO, NativeList<float3> CEBPDKICPDE, NativeList<int> GMLINIGJIKL, Allocator ECEHKFLCCDN, CancellationToken OBNOJDAGGOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6118DF0", Offset = "0x6117FF0", VA = "0x186118DF0")]
	private void AKCGAJHNOGB([In] NativeArray<float3> OGGIPEKOIHO, Allocator ECEHKFLCCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6118FD0", Offset = "0x61181D0", VA = "0x186118FD0")]
	private void BPHCGNIGMPI([In] NativeArray<float3> OGGIPEKOIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6119FE0", Offset = "0x61191E0", VA = "0x186119FE0")]
	private void COJDFCIHAMC([In] NativeArray<float3> OGGIPEKOIHO, [Out] int LEDOIBLDLIF, [Out] int KEMECJNOMDJ, [Out] int NJECGNJIBLK, [Out] int HNBOOJJFFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x611B9F0", Offset = "0x611ABF0", VA = "0x18611B9F0")]
	private void KNJJALCMLLG([In] NativeArray<float3> OGGIPEKOIHO, Allocator ECEHKFLCCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x611A640", Offset = "0x6119840", VA = "0x18611A640")]
	private void GEOMJCHJPFH([In] NativeArray<float3> OGGIPEKOIHO, float3 CPPDJJKKMJI, int PBNPOCMKMPN, OIGDNMIAENL LNDEIHHFMIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x611BBF0", Offset = "0x611ADF0", VA = "0x18611BBF0")]
	private void MIGBMPOBMFK([In] NativeArray<float3> OGGIPEKOIHO, float3 CPPDJJKKMJI, int DOKEFCDLIKI, int JPBKAODJACL, OIGDNMIAENL LNDEIHHFMIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x611AAA0", Offset = "0x6119CA0", VA = "0x18611AAA0")]
	private void HILMBLHBMJC([In] NativeArray<float3> OGGIPEKOIHO, int PLLJMPMJCEN, Allocator ECEHKFLCCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x611B570", Offset = "0x611A770", VA = "0x18611B570")]
	private void JJDGGKKALMG([In] NativeArray<float3> OGGIPEKOIHO, Allocator ECEHKFLCCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x611B0A0", Offset = "0x611A2A0", VA = "0x18611B0A0")]
	private void JICBGFELKLK([In] NativeArray<float3> OGGIPEKOIHO, NativeList<float3> CEBPDKICPDE, NativeList<int> GMLINIGJIKL, Allocator ECEHKFLCCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x611C380", Offset = "0x611B580", VA = "0x18611C380")]
	private float OGAGHKNJPHE(float3 CPPDJJKKMJI, float3 LOMFHDFJABB, OIGDNMIAENL LNDEIHHFMIE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x611B8E0", Offset = "0x611AAE0", VA = "0x18611B8E0")]
	private float3 JPFFAFOAGGH(float3 AFCODMFIOPI, float3 CFMPNDDKCMK, float3 HLEKDJLMACP)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x611C3E0", Offset = "0x611B5E0", VA = "0x18611C3E0")]
	private static float OGGNHHJJOPJ(float3 HEFLGIBKJHK, float3 LPGCLIAKDPH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x611C410", Offset = "0x611B610", VA = "0x18611C410")]
	private static float3 PPDCBAIGDGO(float3 HEFLGIBKJHK, float3 LPGCLIAKDPH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x611A5E0", Offset = "0x61197E0", VA = "0x18611A5E0")]
	private bool FJAGDLLHNNF(float3 HEFLGIBKJHK, float3 LPGCLIAKDPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x611BFC0", Offset = "0x611B1C0", VA = "0x18611BFC0")]
	private bool NGPOGKIBHKO(float3 HEFLGIBKJHK, float3 LPGCLIAKDPH, float3 IKNBBOHGFEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x611C090", Offset = "0x611B290", VA = "0x18611C090")]
	private bool NIACOADMELO(float3 HEFLGIBKJHK, float3 LPGCLIAKDPH, float3 IKNBBOHGFEE, float3 DFLLICFNDLH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct HIKEEOPKFMI : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct HIFCBPNICII
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
	private NativeList<float3> OFHACHFANEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> INDIGAAEALF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int GJKEDBHOEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x611C6B0", Offset = "0x611B8B0", VA = "0x18611C6B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int PMKAIBBIGNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x611D030", Offset = "0x611C230", VA = "0x18611D030")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool OCMFLJFDOAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x611C670", Offset = "0x611B870", VA = "0x18611C670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public MICGIAKCFGN GCLCPOLFGBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x611CFB0", Offset = "0x611C1B0", VA = "0x18611CFB0")]
		get
		{
			return default(MICGIAKCFGN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x611D8F0", Offset = "0x611CAF0", VA = "0x18611D8F0")]
	public HIKEEOPKFMI(int JEOBOGLNJJI, int OPAJBDGDAJK, Allocator ECEHKFLCCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x611D560", Offset = "0x611C760", VA = "0x18611D560")]
	public HIKEEOPKFMI(MICGIAKCFGN DIGJKLJMEJN, Allocator ECEHKFLCCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x611D3F0", Offset = "0x611C5F0", VA = "0x18611D3F0")]
	public HIKEEOPKFMI(Mesh JLFPINMNNGM, Allocator ECEHKFLCCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x611D590", Offset = "0x611C790", VA = "0x18611D590")]
	public HIKEEOPKFMI(HIKEEOPKFMI GKNJGNIHLDH, Allocator ECEHKFLCCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x611C6F0", Offset = "0x611B8F0", VA = "0x18611C6F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x611D070", Offset = "0x611C270", VA = "0x18611D070")]
	public void OJOKKDMOJFN([In] HIKEEOPKFMI CGONJAIKCGI, float4x4 MMBCEDEOPCF, Transform EELPEPBCIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x611C820", Offset = "0x611BA20", VA = "0x18611C820")]
	public void KABIPEFIPAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x611C9A0", Offset = "0x611BBA0", VA = "0x18611C9A0")]
	public void KOLPGHFIJIJ(float IIGADGFPKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x611C470", Offset = "0x611B670", VA = "0x18611C470")]
	public HIKEEOPKFMI ABILPNJLLAF(Allocator ECEHKFLCCDN, CancellationToken OBNOJDAGGOE)
	{
		return default(HIKEEOPKFMI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x611CE90", Offset = "0x611C090", VA = "0x18611CE90")]
	public Mesh LCOBCDAJDLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x611C7D0", Offset = "0x611B9D0", VA = "0x18611C7D0")]
	private unsafe static float3* GJCCPJNJLHO(NativeArray<float3> NPPGGGEFJIJ)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x611C780", Offset = "0x611B980", VA = "0x18611C780")]
	private unsafe static int* GJCCPJNJLHO(NativeArray<int> NPPGGGEFJIJ)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x611C970", Offset = "0x611BB70", VA = "0x18611C970")]
	[CompilerGenerated]
	internal static void KHNAAONPBOB(int NOEGBMKMIHJ, int KGDHPNDELNO, HIFCBPNICII P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct MICGIAKCFGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int GJKEDBHOEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int PMKAIBBIGNI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int MBEGHCCLNEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x611DA00", Offset = "0x611CC00", VA = "0x18611DA00")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1CD5680", Offset = "0x1CD4880", VA = "0x181CD5680")]
	public static MICGIAKCFGN JACEKEKEPIE(MICGIAKCFGN HEFLGIBKJHK, MICGIAKCFGN LPGCLIAKDPH)
	{
		return default(MICGIAKCFGN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x611DA60", Offset = "0x611CC60", VA = "0x18611DA60")]
	public static MICGIAKCFGN HGPGNMOAPML(MICGIAKCFGN AHDOJKMJEEL, int GCKJNKIBEKP)
	{
		return default(MICGIAKCFGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x611D9B0", Offset = "0x611CBB0", VA = "0x18611D9B0", Slot = "0")]
	public override bool Equals(object CCJLPFNGCME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x611DA10", Offset = "0x611CC10", VA = "0x18611DA10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x611DA80", Offset = "0x611CC80", VA = "0x18611DA80", Slot = "3")]
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
