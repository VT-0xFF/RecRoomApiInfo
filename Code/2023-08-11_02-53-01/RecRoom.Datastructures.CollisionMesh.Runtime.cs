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
public struct ECJLJEBJIJL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct GLGPHIJBLAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int NNOOMDBAGFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int MGINPMNFFJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int FEGINJFIBJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int CNEOMGKFFNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int MHJGILMIHGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int GCKNDPKIIFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 HEDFPPEJKKO;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6E619E0", Offset = "0x6E601E0", VA = "0x186E619E0")]
		public GLGPHIJBLAK(int OCANIONFLLD, int DLANFHNBEAC, int FALIIMOGCLM, int IIPIDAJFLAN, int AEKHNFOEGLK, int PIDLPMAPHGM, float3 LKJKFPNAKOC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct KAGGMABAOJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int MOJHGIDCOIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int PLMBFLPFPPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float MKNFMGPINNM;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1A0D5E0", Offset = "0x1A0BDE0", VA = "0x181A0D5E0")]
		public KAGGMABAOJP(int HLLBMEGLPCK, int OMBGILGFIEL, float LDDOOGFOLKL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct GDEHFGAMCDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int PLMBFLPFPPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int MGGPIKMMOCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int JNIHMGNIHHG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, GLGPHIJBLAK> JEHALGJPFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<KAGGMABAOJP> GPLJEAMGENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> OFHKDMPCFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<GDEHFGAMCDO> KBCCDFEMIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> PLBLCBKOPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int DIECADJFDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int NLGIJIHGKAJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6E5EA10", Offset = "0x6E5D210", VA = "0x186E5EA10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6E61710", Offset = "0x6E5FF10", VA = "0x186E61710")]
	public bool OKGDMBLBONF(in NativeArray<float3> BNGBMPEDLIK, ref NativeList<float3> EIMGHMMIEIF, ref NativeList<int> EMCPHJIDOJF, Allocator HMGEFCKKBID, CancellationToken NNLBJPBEHPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6E5E830", Offset = "0x6E5D030", VA = "0x186E5E830")]
	private void BDCEDMLOOPD(in NativeArray<float3> BNGBMPEDLIK, Allocator HMGEFCKKBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6E60040", Offset = "0x6E5E840", VA = "0x186E60040")]
	private void KFHIKMODJJO(in NativeArray<float3> BNGBMPEDLIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6E5EB50", Offset = "0x6E5D350", VA = "0x186E5EB50")]
	private void EPBCIPFGCFM(in NativeArray<float3> BNGBMPEDLIK, out int ENNONNLMJEI, out int MDKLGICALGL, out int HDCJPFBJDEM, out int ECEFLINMPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6E5F8A0", Offset = "0x6E5E0A0", VA = "0x186E5F8A0")]
	private void HFIBEHOLIJJ(in NativeArray<float3> BNGBMPEDLIK, Allocator HMGEFCKKBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6E5F3C0", Offset = "0x6E5DBC0", VA = "0x186E5F3C0")]
	private void HAIMFALCCCN(in NativeArray<float3> BNGBMPEDLIK, float3 PKBCOAILGDK, int FJDDJJKEAGM, GLGPHIJBLAK NCNFHENEADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6E5EFB0", Offset = "0x6E5D7B0", VA = "0x186E5EFB0")]
	private void FNEKIPGPPDG(in NativeArray<float3> BNGBMPEDLIK, float3 PKBCOAILGDK, int DBLGCCBAIKD, int NLGIJIHGKAJ, GLGPHIJBLAK NCNFHENEADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6E5FA90", Offset = "0x6E5E290", VA = "0x186E5FA90")]
	private void JEBGCJCOGLH(in NativeArray<float3> BNGBMPEDLIK, int MBACLJINAEK, Allocator HMGEFCKKBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6E60EF0", Offset = "0x6E5F6F0", VA = "0x186E60EF0")]
	private void MIODPNMJOIG(in NativeArray<float3> BNGBMPEDLIK, Allocator HMGEFCKKBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6E61270", Offset = "0x6E5FA70", VA = "0x186E61270")]
	private void NNBJHCDDDNB(in NativeArray<float3> BNGBMPEDLIK, ref NativeList<float3> EIMGHMMIEIF, ref NativeList<int> EMCPHJIDOJF, Allocator HMGEFCKKBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6E61800", Offset = "0x6E60000", VA = "0x186E61800")]
	private float POABCCOEGOD(float3 PKBCOAILGDK, float3 MPDBEJANLNI, GLGPHIJBLAK NCNFHENEADM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6E5E3D0", Offset = "0x6E5CBD0", VA = "0x186E5E3D0")]
	private float3 HEDFPPEJKKO(float3 OCANIONFLLD, float3 DLANFHNBEAC, float3 FALIIMOGCLM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x45BDD10", Offset = "0x45BC510", VA = "0x1845BDD10")]
	private static float MPGHBPMBLNH(float3 MBLAPCMEEGI, float3 NBEGIGNBOIE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x45BDBA0", Offset = "0x45BC3A0", VA = "0x1845BDBA0")]
	private static float3 JDBIPMFLHDG(float3 MBLAPCMEEGI, float3 NBEGIGNBOIE)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6E60E90", Offset = "0x6E5F690", VA = "0x186E60E90")]
	private bool KNBHDFPMGHK(float3 MBLAPCMEEGI, float3 NBEGIGNBOIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6E61630", Offset = "0x6E5FE30", VA = "0x186E61630")]
	private bool OCOANIELNLF(float3 MBLAPCMEEGI, float3 NBEGIGNBOIE, float3 OEDICJGOJNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6E5E510", Offset = "0x6E5CD10", VA = "0x186E5E510")]
	private bool BCLMMJCLJFO(float3 MBLAPCMEEGI, float3 NBEGIGNBOIE, float3 OEDICJGOJNL, float3 LDDOOGFOLKL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct OMHJGGIOADC : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct BAHNFIHKIHF
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
	private NativeList<float3> POBEOADADBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> FDMEBILIHKJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int FLAGBEGBCIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6E61BC0", Offset = "0x6E603C0", VA = "0x186E61BC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int CKCHKHJKOKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6E61C00", Offset = "0x6E60400", VA = "0x186E61C00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KHGFECIPALO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6E62450", Offset = "0x6E60C50", VA = "0x186E62450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public GIHJJEAPAEF EMPOAGBHDNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6E623D0", Offset = "0x6E60BD0", VA = "0x186E623D0")]
		get
		{
			return default(GIHJJEAPAEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6E629F0", Offset = "0x6E611F0", VA = "0x186E629F0")]
	public OMHJGGIOADC(int DFDGIOAFKJP, int FOAGAHLJFHN, Allocator HMGEFCKKBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6E62C40", Offset = "0x6E61440", VA = "0x186E62C40")]
	public OMHJGGIOADC(GIHJJEAPAEF EKOBKHJFHKO, Allocator HMGEFCKKBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6E62AB0", Offset = "0x6E612B0", VA = "0x186E62AB0")]
	public OMHJGGIOADC(Mesh IGPKJFHDBNF, Allocator HMGEFCKKBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6E62C70", Offset = "0x6E61470", VA = "0x186E62C70")]
	public OMHJGGIOADC(OMHJGGIOADC NFBDMLCENEN, Allocator HMGEFCKKBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6E61C40", Offset = "0x6E60440", VA = "0x186E61C40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6E62070", Offset = "0x6E60870", VA = "0x186E62070")]
	public void GLILACFFLBJ(in OMHJGGIOADC ODHKMJMLAIP, float4x4 ILDEBNONBOL, Transform DONOJELKAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6E61A20", Offset = "0x6E60220", VA = "0x186E61A20")]
	public void AGDHKOPNKFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6E62490", Offset = "0x6E60C90", VA = "0x186E62490")]
	public void NCGOHHIIEGE(float BJICICOAOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6E61DF0", Offset = "0x6E605F0", VA = "0x186E61DF0")]
	public OMHJGGIOADC FJEFINBBPLM(Allocator HMGEFCKKBID, CancellationToken NNLBJPBEHPF)
	{
		return default(OMHJGGIOADC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6E61CD0", Offset = "0x6E604D0", VA = "0x186E61CD0")]
	public Mesh ENOKJDLIPJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6E62950", Offset = "0x6E61150", VA = "0x186E62950")]
	private unsafe static float3* PABPMHCCGLO(NativeArray<float3> DLLMPOAIBGN)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6E629A0", Offset = "0x6E611A0", VA = "0x186E629A0")]
	private unsafe static int* PABPMHCCGLO(NativeArray<int> DLLMPOAIBGN)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6E61B90", Offset = "0x6E60390", VA = "0x186E61B90")]
	[CompilerGenerated]
	internal static void AOOMIFHJDCL(int OMIKJKAGCMN, int LFBMCPEEFMM, ref BAHNFIHKIHF P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct GIHJJEAPAEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int FLAGBEGBCIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int CKCHKHJKOKA;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int KLOCNBOGACB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6E618D0", Offset = "0x6E600D0", VA = "0x186E618D0")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6E61920", Offset = "0x6E60120", VA = "0x186E61920")]
	public static GIHJJEAPAEF INLOCBKJPHG(GIHJJEAPAEF MBLAPCMEEGI, GIHJJEAPAEF NBEGIGNBOIE)
	{
		return default(GIHJJEAPAEF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6E61870", Offset = "0x6E60070", VA = "0x186E61870")]
	public static GIHJJEAPAEF CNPBDNEFHGI(GIHJJEAPAEF HGKBBAIIINB, int BHOCBFLFIBD)
	{
		return default(GIHJJEAPAEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6E61890", Offset = "0x6E60090", VA = "0x186E61890", Slot = "0")]
	public override bool Equals(object EEPFAENLGFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6E618E0", Offset = "0x6E600E0", VA = "0x186E618E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6E61940", Offset = "0x6E60140", VA = "0x186E61940", Slot = "3")]
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
