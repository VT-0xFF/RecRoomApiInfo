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
public struct CLLABMOPHPC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct MKNHKHMMBLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int FNJCKEMEJDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int EFEEEGCHADH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int OAILFANCEFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int HNKJEFJHGBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int JGHKNNMCJKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int GLOCJHDBGME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 DDDAMLFHNGO;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x627DC50", Offset = "0x627CC50", VA = "0x18627DC50")]
		public MKNHKHMMBLM(int NMAKCBEPOJK, int OHPEILLPCGO, int MJONMAIBFBA, int GJJFEFOGAKL, int OBOANFFABEE, int ANCLJIAHOLF, float3 KMBEHGBELJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct NLGBBHNLLCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int OEIAJOLINLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int NIKKGFCMEGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float KCBFFHKLMJC;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x104BB10", Offset = "0x104AB10", VA = "0x18104BB10")]
		public NLGBBHNLLCN(int FBGJMCPJFED, int JAFLBDFOJHA, float GEJPKFDIMAP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct EFDAAENEDID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int NIKKGFCMEGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int LCANDJAKJOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int MPAEJKFBHOA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, MKNHKHMMBLM> LMNBGHAJJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<NLGBBHNLLCN> BNIAJOOCBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> GEIHIFAKOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<EFDAAENEDID> ICNPBAJKJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> NEHGFLDIICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int DIHOINHJHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int LACCLNDNBNC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x627A380", Offset = "0x6279380", VA = "0x18627A380", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x627A890", Offset = "0x6279890", VA = "0x18627A890")]
	public bool FHMONJKDHKN([In] NativeArray<float3> EBOOJCHCNFJ, NativeList<float3> MFJKGNNFHMK, NativeList<int> IAJKHAFODFG, Allocator NFBFCGHLHAF, CancellationToken GHLJDIEPICD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x627A030", Offset = "0x6279030", VA = "0x18627A030")]
	private void CJMKLAKCCOG([In] NativeArray<float3> EBOOJCHCNFJ, Allocator NFBFCGHLHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x627AA00", Offset = "0x6279A00", VA = "0x18627AA00")]
	private void JECKNCCDGDD([In] NativeArray<float3> EBOOJCHCNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6279710", Offset = "0x6278710", VA = "0x186279710")]
	private void AIFJCIHLEOC([In] NativeArray<float3> EBOOJCHCNFJ, [Out] int MLAICMHBJDI, [Out] int HFINCLBDOLJ, [Out] int ABPOMJLNFBM, [Out] int PJPLLHLCNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x627BEB0", Offset = "0x627AEB0", VA = "0x18627BEB0")]
	private void MOCECBEBBLB([In] NativeArray<float3> EBOOJCHCNFJ, Allocator NFBFCGHLHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6279BD0", Offset = "0x6278BD0", VA = "0x186279BD0")]
	private void BPPHIINBKEI([In] NativeArray<float3> EBOOJCHCNFJ, float3 FCJBPODALAO, int FIBPMADJGLH, MKNHKHMMBLM IAIONNPAGNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x627A4C0", Offset = "0x62794C0", VA = "0x18627A4C0")]
	private void ECDFALCBGFN([In] NativeArray<float3> EBOOJCHCNFJ, float3 FCJBPODALAO, int JABIKKGFOHM, int LACCLNDNBNC, MKNHKHMMBLM IAIONNPAGNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x627C110", Offset = "0x627B110", VA = "0x18627C110")]
	private void OHJEHPLBKGE([In] NativeArray<float3> EBOOJCHCNFJ, int CENKBBKGDIF, Allocator NFBFCGHLHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x627BAE0", Offset = "0x627AAE0", VA = "0x18627BAE0")]
	private void LCIEHCNNOCC([In] NativeArray<float3> EBOOJCHCNFJ, Allocator NFBFCGHLHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6278F50", Offset = "0x6277F50", VA = "0x186278F50")]
	private void AAGNJKKPKKL([In] NativeArray<float3> EBOOJCHCNFJ, NativeList<float3> MFJKGNNFHMK, NativeList<int> IAJKHAFODFG, Allocator NFBFCGHLHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x627C0B0", Offset = "0x627B0B0", VA = "0x18627C0B0")]
	private float MPADPEOOJDJ(float3 FCJBPODALAO, float3 NDJGDPIIABI, MKNHKHMMBLM IAIONNPAGNB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x627A270", Offset = "0x6279270", VA = "0x18627A270")]
	private float3 DDDAMLFHNGO(float3 NMAKCBEPOJK, float3 OHPEILLPCGO, float3 MJONMAIBFBA)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x627A9D0", Offset = "0x62799D0", VA = "0x18627A9D0")]
	private static float GKFEIOHEOEJ(float3 AAOIMEIMECG, float3 ABLGCHAEIGE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x627BE50", Offset = "0x627AE50", VA = "0x18627BE50")]
	private static float3 MFABBFHJGBA(float3 AAOIMEIMECG, float3 ABLGCHAEIGE)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x627A210", Offset = "0x6279210", VA = "0x18627A210")]
	private bool DBIDMCFLLPO(float3 AAOIMEIMECG, float3 ABLGCHAEIGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x627BA10", Offset = "0x627AA10", VA = "0x18627BA10")]
	private bool JPBAOKCGBPD(float3 AAOIMEIMECG, float3 ABLGCHAEIGE, float3 PPMIKHJHPEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6279420", Offset = "0x6278420", VA = "0x186279420")]
	private bool ABAANGFEJMA(float3 AAOIMEIMECG, float3 ABLGCHAEIGE, float3 PPMIKHJHPEE, float3 GEJPKFDIMAP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct KFLIFDPFIGA : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct KODIBOCFMPG
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
	private NativeList<float3> EABKOAMJJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> DCKDPCFLICC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int MBGNDOMDJNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x627CA90", Offset = "0x627BA90", VA = "0x18627CA90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int JBHPFBFMILD
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x627D650", Offset = "0x627C650", VA = "0x18627D650")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool EDCFENPGADL
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x627CAD0", Offset = "0x627BAD0", VA = "0x18627CAD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public CKHPEPFAABA IJPIFEKFDFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x627CC40", Offset = "0x627BC40", VA = "0x18627CC40")]
		get
		{
			return default(CKHPEPFAABA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x627DB90", Offset = "0x627CB90", VA = "0x18627DB90")]
	public KFLIFDPFIGA(int HCEIPJNIFCF, int GCMPHABKKFN, Allocator NFBFCGHLHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x627D690", Offset = "0x627C690", VA = "0x18627D690")]
	public KFLIFDPFIGA(CKHPEPFAABA ICJOHOGCFLL, Allocator NFBFCGHLHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x627DA20", Offset = "0x627CA20", VA = "0x18627DA20")]
	public KFLIFDPFIGA(Mesh GCFMCPMBPPI, Allocator NFBFCGHLHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x627D6C0", Offset = "0x627C6C0", VA = "0x18627D6C0")]
	public KFLIFDPFIGA(KFLIFDPFIGA GPKMLHOONCL, Allocator NFBFCGHLHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x627CB10", Offset = "0x627BB10", VA = "0x18627CB10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x627C710", Offset = "0x627B710", VA = "0x18627C710")]
	public void BGLDHBEBEIE([In] KFLIFDPFIGA KEHDHCINJMM, float4x4 IPMNAPGBLEC, Transform OCKHJMEPNID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x627D1B0", Offset = "0x627C1B0", VA = "0x18627D1B0")]
	public void IJNHPPFHDLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x627CCC0", Offset = "0x627BCC0", VA = "0x18627CCC0")]
	public void HNPKCNAEIOB(float MPDLEMGFFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x627D420", Offset = "0x627C420", VA = "0x18627D420")]
	public KFLIFDPFIGA OFEJIAEDEIJ(Allocator NFBFCGHLHAF, CancellationToken GHLJDIEPICD)
	{
		return default(KFLIFDPFIGA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x627D300", Offset = "0x627C300", VA = "0x18627D300")]
	public Mesh KIOEHOKMEDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x627CBA0", Offset = "0x627BBA0", VA = "0x18627CBA0")]
	private unsafe static float3* FBNBPFLJBCP(NativeArray<float3> PAFIMPMPKHD)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x627CBF0", Offset = "0x627BBF0", VA = "0x18627CBF0")]
	private unsafe static int* FBNBPFLJBCP(NativeArray<int> PAFIMPMPKHD)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x627D620", Offset = "0x627C620", VA = "0x18627D620")]
	[CompilerGenerated]
	internal static void OIHGPOOLFOO(int AHMOBOOLPBC, int JADAGFAJOND, KODIBOCFMPG P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct CKHPEPFAABA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int MBGNDOMDJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int JBHPFBFMILD;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int KDNONHGLBBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6278E30", Offset = "0x6277E30", VA = "0x186278E30")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1D51030", Offset = "0x1D50030", VA = "0x181D51030")]
	public static CKHPEPFAABA JICKFCFOKMA(CKHPEPFAABA AAOIMEIMECG, CKHPEPFAABA ABLGCHAEIGE)
	{
		return default(CKHPEPFAABA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6278E90", Offset = "0x6277E90", VA = "0x186278E90")]
	public static CKHPEPFAABA PMDGLAMNKDH(CKHPEPFAABA CMDDMOHKEFF, int MBGPCNKOEPO)
	{
		return default(CKHPEPFAABA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6278DE0", Offset = "0x6277DE0", VA = "0x186278DE0", Slot = "0")]
	public override bool Equals(object GJCEOEGGOCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6278E40", Offset = "0x6277E40", VA = "0x186278E40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6278EB0", Offset = "0x6277EB0", VA = "0x186278EB0", Slot = "3")]
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
