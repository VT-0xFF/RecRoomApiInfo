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
public struct GEOBLOBCJMC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct LPOEMHLLAFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int FHNPMMDAKCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int IJJNMLADAID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int GHEKEJNMPCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int DGHMFLLFNKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int OBAFMNGICLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int LEMDLAAKHKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 LMJIJFLGJLE;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x699ABE0", Offset = "0x69997E0", VA = "0x18699ABE0")]
		public LPOEMHLLAFO(int MGMLELJJAPF, int CEENIHNJHMG, int FGLJDDHJKFI, int FBHAFELBOBN, int MLHPHKDMHBN, int IDNKNHBKMIP, float3 BCLJLGDCOIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct HLFBINDLPGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int LCGLIDILDHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int BOENEFEIPPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float DAENBGHAGAM;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x11D13A0", Offset = "0x11CFFA0", VA = "0x1811D13A0")]
		public HLFBINDLPGN(int GJCPBEAOKAC, int BOMPKBNPBHI, float JBCGPIDEDFO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct IAAOIPCIFCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int BOENEFEIPPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int ODBENCIJPBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int EKCJMNCGKMI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, LPOEMHLLAFO> FJCLOLOPELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<HLFBINDLPGN> JMNNFNDOEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> GAJENJPCBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<IAAOIPCIFCP> LIGPPIDBJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> JKBELKEBNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int EPDMMCCMHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int JHCFDNODOPL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6997610", Offset = "0x6996210", VA = "0x186997610", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6998600", Offset = "0x6997200", VA = "0x186998600")]
	public bool HLOAKBKAKEC([In] NativeArray<float3> MKJNGPJJDOO, NativeList<float3> GHPNJCOMOOL, NativeList<int> FLCNPAEHCMG, Allocator MJBDBDLLDBK, CancellationToken PPKBAEMFIMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x699A3D0", Offset = "0x6998FD0", VA = "0x18699A3D0")]
	private void NJFEGHENHFC([In] NativeArray<float3> MKJNGPJJDOO, Allocator MJBDBDLLDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x69990B0", Offset = "0x6997CB0", VA = "0x1869990B0")]
	private void JMDJCKFOKGP([In] NativeArray<float3> MKJNGPJJDOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x699A5B0", Offset = "0x69991B0", VA = "0x18699A5B0")]
	private void NPFNHBFHGHA([In] NativeArray<float3> MKJNGPJJDOO, [Out] int DEPANKFPCGN, [Out] int IHDKNEPJKCE, [Out] int COPMGAJHBJI, [Out] int NJBLIGGCBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x699A0C0", Offset = "0x6998CC0", VA = "0x18699A0C0")]
	private void LDIDJBJPDGO([In] NativeArray<float3> MKJNGPJJDOO, Allocator MJBDBDLLDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6998740", Offset = "0x6997340", VA = "0x186998740")]
	private void HMJJGBBIONN([In] NativeArray<float3> MKJNGPJJDOO, float3 HCMICLBLHLG, int LFJNDJLKMHI, LPOEMHLLAFO KBODDAFCJBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6998100", Offset = "0x6996D00", VA = "0x186998100")]
	private void GCHDBIPEMBL([In] NativeArray<float3> MKJNGPJJDOO, float3 HCMICLBLHLG, int LLKKAAMMNEK, int JHCFDNODOPL, LPOEMHLLAFO KBODDAFCJBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x69977B0", Offset = "0x69963B0", VA = "0x1869977B0")]
	private void FILBAIHBCDL([In] NativeArray<float3> MKJNGPJJDOO, int HGNOCPJNCMC, Allocator MJBDBDLLDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x69972A0", Offset = "0x6995EA0", VA = "0x1869972A0")]
	private void DNLEFGFBJCL([In] NativeArray<float3> MKJNGPJJDOO, Allocator MJBDBDLLDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6998BA0", Offset = "0x69977A0", VA = "0x186998BA0")]
	private void HNBKDANAAFL([In] NativeArray<float3> MKJNGPJJDOO, NativeList<float3> GHPNJCOMOOL, NativeList<int> FLCNPAEHCMG, Allocator MJBDBDLLDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6997DB0", Offset = "0x69969B0", VA = "0x186997DB0")]
	private float FLPDNLCANMH(float3 HCMICLBLHLG, float3 PKJBGPNFLFN, LPOEMHLLAFO KBODDAFCJBO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x699A2C0", Offset = "0x6998EC0", VA = "0x18699A2C0")]
	private float3 LMJIJFLGJLE(float3 MGMLELJJAPF, float3 CEENIHNJHMG, float3 FGLJDDHJKFI)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6999080", Offset = "0x6997C80", VA = "0x186999080")]
	private static float HOJPDJMJHFN(float3 PFJBMEMCGDE, float3 GCHHKKAJBGE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6997750", Offset = "0x6996350", VA = "0x186997750")]
	private static float3 EDEIJBBIIKI(float3 PFJBMEMCGDE, float3 GCHHKKAJBGE)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x69985A0", Offset = "0x69971A0", VA = "0x1869985A0")]
	private bool HJAOBHFAIDF(float3 PFJBMEMCGDE, float3 GCHHKKAJBGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x69984D0", Offset = "0x69970D0", VA = "0x1869984D0")]
	private bool GPPFLHMGFIJ(float3 PFJBMEMCGDE, float3 GCHHKKAJBGE, float3 KOBLLIODAMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6997E10", Offset = "0x6996A10", VA = "0x186997E10")]
	private bool FOFDMMLGGKH(float3 PFJBMEMCGDE, float3 GCHHKKAJBGE, float3 KOBLLIODAMP, float3 JBCGPIDEDFO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct EPFIJHKNAAI : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct PHMCMFKCFPD
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
	private NativeList<float3> NPCMGCADHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> HOEMNGHEIMC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int IIDHCPMGDJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6996AF0", Offset = "0x69956F0", VA = "0x186996AF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int HMFFBCMKPHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x69965B0", Offset = "0x69951B0", VA = "0x1869965B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LFJOKDMJBJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6995DF0", Offset = "0x69949F0", VA = "0x186995DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public LDICKKLOGAM APLPGILHNLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6996B30", Offset = "0x6995730", VA = "0x186996B30")]
		get
		{
			return default(LDICKKLOGAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6996CD0", Offset = "0x69958D0", VA = "0x186996CD0")]
	public EPFIJHKNAAI(int CHFINOAHILG, int EIONMLMCMLD, Allocator MJBDBDLLDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6997270", Offset = "0x6995E70", VA = "0x186997270")]
	public EPFIJHKNAAI(LDICKKLOGAM JFNCCPADNJH, Allocator MJBDBDLLDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6996D90", Offset = "0x6995990", VA = "0x186996D90")]
	public EPFIJHKNAAI(Mesh KBGHMNKGJFA, Allocator MJBDBDLLDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6996F00", Offset = "0x6995B00", VA = "0x186996F00")]
	public EPFIJHKNAAI(EPFIJHKNAAI JGFKFMMOAJO, Allocator MJBDBDLLDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6996520", Offset = "0x6995120", VA = "0x186996520", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6996770", Offset = "0x6995370", VA = "0x186996770")]
	public void LKPJOLMECIF([In] EPFIJHKNAAI LNMFGKOJMJG, float4x4 APILGPEEJFM, Transform IFGLEMAFOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6996620", Offset = "0x6995220", VA = "0x186996620")]
	public void KNNFKLPNDAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6996030", Offset = "0x6994C30", VA = "0x186996030")]
	public void DNMCCCFIGCF(float DIPNJIGHAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6995E30", Offset = "0x6994A30", VA = "0x186995E30")]
	public EPFIJHKNAAI DMGMCIFDIGC(Allocator MJBDBDLLDBK, CancellationToken PPKBAEMFIMG)
	{
		return default(EPFIJHKNAAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6996BB0", Offset = "0x69957B0", VA = "0x186996BB0")]
	public Mesh PEBLJENJNIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6995D50", Offset = "0x6994950", VA = "0x186995D50")]
	private unsafe static float3* ADNBAPGDALL(NativeArray<float3> DKCMKELIAPN)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6995DA0", Offset = "0x69949A0", VA = "0x186995DA0")]
	private unsafe static int* ADNBAPGDALL(NativeArray<int> DKCMKELIAPN)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x69965F0", Offset = "0x69951F0", VA = "0x1869965F0")]
	[CompilerGenerated]
	internal static void JENNCNFOFFJ(int PCFBEFCBICN, int FCNIBGNCKHA, PHMCMFKCFPD P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct LDICKKLOGAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int IIDHCPMGDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int HMFFBCMKPHB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int CLOLILGAFLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x699AA70", Offset = "0x6999670", VA = "0x18699AA70")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1ECB000", Offset = "0x1EC9C00", VA = "0x181ECB000")]
	public static LDICKKLOGAM CIMOFGPGBIC(LDICKKLOGAM PFJBMEMCGDE, LDICKKLOGAM GCHHKKAJBGE)
	{
		return default(LDICKKLOGAM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x699AB20", Offset = "0x6999720", VA = "0x18699AB20")]
	public static LDICKKLOGAM POKOGMODMOB(LDICKKLOGAM JLBHKKLIHBD, int CGDAJMLMKLA)
	{
		return default(LDICKKLOGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x699AA80", Offset = "0x6999680", VA = "0x18699AA80", Slot = "0")]
	public override bool Equals(object FKLHPLCHFJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x699AAD0", Offset = "0x69996D0", VA = "0x18699AAD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x699AB40", Offset = "0x6999740", VA = "0x18699AB40", Slot = "3")]
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
