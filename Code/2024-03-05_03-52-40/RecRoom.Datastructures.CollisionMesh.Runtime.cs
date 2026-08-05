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
public struct OHAGLLMAPBO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct FJLBNEKIALP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int GJPKHKBLJJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int CBENAOOMGBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int KIHDHMIPHLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int MDBDFKILGFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int BAJAMEEJGPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int EPNFCELLLOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 ECAMAJBPDPL;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x60AA5F0", Offset = "0x60A93F0", VA = "0x1860AA5F0")]
		public FJLBNEKIALP(int HMBHFKLHOHP, int EOBBKJHONJA, int BFKALFMHDBG, int OEKBAMDEHDL, int KJLHFLFHDJH, int DIOOEHPEGGD, float3 BKELBBDDNIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct KKMLCECOLJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int JGMJCPNFMGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int JAMCCCLBJBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float ODPODCIDNGD;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xFFC320", Offset = "0xFFB120", VA = "0x180FFC320")]
		public KKMLCECOLJP(int BNKGEELECNO, int CJBAJKJOOIL, float GLPEKNLBHMD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct FAEALDAJHFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int JAMCCCLBJBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int KJHHMMEIFOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int JGCKIMCKKLE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, FJLBNEKIALP> JBPNJOKIIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<KKMLCECOLJP> CLCGOBIHHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> CCNEPLBCJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<FAEALDAJHFP> EAHFDFIGNKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> OJGIFKIHHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int FKLJBHEFELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int BFGHOPIBEID;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x60AC510", Offset = "0x60AB310", VA = "0x1860AC510", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x60ADC90", Offset = "0x60ACA90", VA = "0x1860ADC90")]
	public bool NICMHMCGJEK([In] NativeArray<float3> GJMPICGGOGG, NativeList<float3> KHEKBMGHGDI, NativeList<int> PBHPDJIAGJG, Allocator ALDDPOOJFGI, CancellationToken MBHHHCCHBAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60ACF90", Offset = "0x60ABD90", VA = "0x1860ACF90")]
	private void KCJBJGBIMAI([In] NativeArray<float3> GJMPICGGOGG, Allocator ALDDPOOJFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x60AA7A0", Offset = "0x60A95A0", VA = "0x1860AA7A0")]
	private void ABCLFACMNKE([In] NativeArray<float3> GJMPICGGOGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60ABB20", Offset = "0x60AA920", VA = "0x1860ABB20")]
	private void CECPHAOFIJA([In] NativeArray<float3> GJMPICGGOGG, [Out] int KCAEIAMJJKC, [Out] int POAIKMMMBKG, [Out] int BILDLOMNMBI, [Out] int FKMDMAOHJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x60AC650", Offset = "0x60AB450", VA = "0x1860AC650")]
	private void EANFEGKNMFI([In] NativeArray<float3> GJMPICGGOGG, Allocator ALDDPOOJFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x60AD460", Offset = "0x60AC260", VA = "0x1860AD460")]
	private void MMJEPMHAPCG([In] NativeArray<float3> GJMPICGGOGG, float3 MNMDECHMAEG, int DELGPEJBLEE, FJLBNEKIALP NFEGHBJHPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x60AD8C0", Offset = "0x60AC6C0", VA = "0x1860AD8C0")]
	private void NEGNPPJLFBG([In] NativeArray<float3> GJMPICGGOGG, float3 MNMDECHMAEG, int LIPLLOKHFFN, int BFGHOPIBEID, FJLBNEKIALP NFEGHBJHPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x60AC960", Offset = "0x60AB760", VA = "0x1860AC960")]
	private void FNAIBDNCDNL([In] NativeArray<float3> GJMPICGGOGG, int BDEMFPJCGCC, Allocator ALDDPOOJFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x60AB7B0", Offset = "0x60AA5B0", VA = "0x1860AB7B0")]
	private void CACCFIAHGHC([In] NativeArray<float3> GJMPICGGOGG, Allocator ALDDPOOJFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x60AC040", Offset = "0x60AAE40", VA = "0x1860AC040")]
	private void DOGCCLEIJOK([In] NativeArray<float3> GJMPICGGOGG, NativeList<float3> KHEKBMGHGDI, NativeList<int> PBHPDJIAGJG, Allocator ALDDPOOJFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x60ABFE0", Offset = "0x60AADE0", VA = "0x1860ABFE0")]
	private float DFEIJIODAGH(float3 MNMDECHMAEG, float3 EAAOENFGJBB, FJLBNEKIALP NFEGHBJHPFL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x60AC850", Offset = "0x60AB650", VA = "0x1860AC850")]
	private float3 ECAMAJBPDPL(float3 HMBHFKLHOHP, float3 EOBBKJHONJA, float3 BFKALFMHDBG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x60ACF60", Offset = "0x60ABD60", VA = "0x1860ACF60")]
	private static float HEINEDCNGNI(float3 AOHIFIJNOBB, float3 FNDBFMFAGPH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x60ADE30", Offset = "0x60ACC30", VA = "0x1860ADE30")]
	private static float3 PEDOPLBFBKA(float3 AOHIFIJNOBB, float3 FNDBFMFAGPH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x60ADDD0", Offset = "0x60ACBD0", VA = "0x1860ADDD0")]
	private bool NKDNOCELPIP(float3 AOHIFIJNOBB, float3 FNDBFMFAGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x60ADE90", Offset = "0x60ACC90", VA = "0x1860ADE90")]
	private bool PMHIDIKDINC(float3 AOHIFIJNOBB, float3 FNDBFMFAGPH, float3 MEJOABMJHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x60AD170", Offset = "0x60ABF70", VA = "0x1860AD170")]
	private bool KDPGJNPAOOL(float3 AOHIFIJNOBB, float3 FNDBFMFAGPH, float3 MEJOABMJHGI, float3 GLPEKNLBHMD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct CPOHPCGFALC : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct BAPOBGBAGIH
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
	private NativeList<float3> NJJJDNAEOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> NFEHFPNPIEJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int GEHBAEEJLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x60A99E0", Offset = "0x60A87E0", VA = "0x1860A99E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int ELCABDHJDJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x60A9ED0", Offset = "0x60A8CD0", VA = "0x1860A9ED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LNCGINAIOLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x60A9AA0", Offset = "0x60A88A0", VA = "0x1860A9AA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IAEIMNCHKHI FOANDCKNBNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x60A9A20", Offset = "0x60A8820", VA = "0x1860A9A20")]
		get
		{
			return default(IAEIMNCHKHI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x60AA030", Offset = "0x60A8E30", VA = "0x1860AA030")]
	public CPOHPCGFALC(int BHKPNGHCBGD, int LNKPNAAAPMI, Allocator ALDDPOOJFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x60AA450", Offset = "0x60A9250", VA = "0x1860AA450")]
	public CPOHPCGFALC(IAEIMNCHKHI KBKHFCAKKJO, Allocator ALDDPOOJFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x60AA480", Offset = "0x60A9280", VA = "0x1860AA480")]
	public CPOHPCGFALC(Mesh HCHDFAPIGCD, Allocator ALDDPOOJFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x60AA0F0", Offset = "0x60A8EF0", VA = "0x1860AA0F0")]
	public CPOHPCGFALC(CPOHPCGFALC EEDANCJJEPL, Allocator ALDDPOOJFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x60A90E0", Offset = "0x60A7EE0", VA = "0x1860A90E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x60A9660", Offset = "0x60A8460", VA = "0x1860A9660")]
	public void GALNLGNAACN([In] CPOHPCGFALC CCBBNNMCBIL, float4x4 GCBICDLKKHL, Transform IBFDAAOJDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x60A9D80", Offset = "0x60A8B80", VA = "0x1860A9D80")]
	public void NJGJCLDFOCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x60A9170", Offset = "0x60A7F70", VA = "0x1860A9170")]
	public void FNMDCHDIGFM(float CCDDMHMFCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x60A9B80", Offset = "0x60A8980", VA = "0x1860A9B80")]
	public CPOHPCGFALC MOAPGGNDDMJ(Allocator ALDDPOOJFGI, CancellationToken MBHHHCCHBAO)
	{
		return default(CPOHPCGFALC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x60A9F10", Offset = "0x60A8D10", VA = "0x1860A9F10")]
	public Mesh OKPPMAMFBAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x60A9B30", Offset = "0x60A8930", VA = "0x1860A9B30")]
	private unsafe static float3* MFFOOHLIHIM(NativeArray<float3> HHAMBPGBENG)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x60A9AE0", Offset = "0x60A88E0", VA = "0x1860A9AE0")]
	private unsafe static int* MFFOOHLIHIM(NativeArray<int> HHAMBPGBENG)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x60A90B0", Offset = "0x60A7EB0", VA = "0x1860A90B0")]
	[CompilerGenerated]
	internal static void ANFNMKCPGOB(int EMGLKCBMMJH, int AJKKEBKAGCE, BAPOBGBAGIH P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct IAEIMNCHKHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int GEHBAEEJLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int ELCABDHJDJE;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int LNIEJCMIBAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x60AA6D0", Offset = "0x60A94D0", VA = "0x1860AA6D0")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1CC3410", Offset = "0x1CC2210", VA = "0x181CC3410")]
	public static IAEIMNCHKHI LAOAHLPDKDH(IAEIMNCHKHI AOHIFIJNOBB, IAEIMNCHKHI FNDBFMFAGPH)
	{
		return default(IAEIMNCHKHI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x60AA6E0", Offset = "0x60A94E0", VA = "0x1860AA6E0")]
	public static IAEIMNCHKHI OLKNHNLCACK(IAEIMNCHKHI GBACAGPBPLK, int GJCLFAIOADJ)
	{
		return default(IAEIMNCHKHI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x60AA630", Offset = "0x60A9430", VA = "0x1860AA630", Slot = "0")]
	public override bool Equals(object JDMIDODMBFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x60AA680", Offset = "0x60A9480", VA = "0x1860AA680", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x60AA700", Offset = "0x60A9500", VA = "0x1860AA700", Slot = "3")]
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
