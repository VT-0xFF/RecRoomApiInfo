using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2576760", Offset = "0x2575B60", VA = "0x182576760")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x975680", Offset = "0x974A80", VA = "0x180975680")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9756C0", Offset = "0x974AC0", VA = "0x1809756C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct IODPCIONDHC : IEnumerator<NPEOPECJINL>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private KDKNMLEFGMO<OECNLCLGMED>.CAPEOKMHHLI FGGPJDGKGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private HOLDAFBGHPF<OECNLCLGMED, LDIDKHKLAFM<AAFGLNNJOHN<KPIEMJMGBJJ>>> IBCBAEDCAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private LDIDKHKLAFM<AAFGLNNJOHN<KPIEMJMGBJJ>>.NGLMKBFLJHE CIIANBDKACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool BOEEDKCPKBL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NPEOPECJINL FJMLFGNPDDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x25729A0", Offset = "0x2571DA0", VA = "0x1825729A0", Slot = "4")]
		get
		{
			return default(NPEOPECJINL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x25728E0", Offset = "0x2571CE0", VA = "0x1825728E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2572930", Offset = "0x2571D30", VA = "0x182572930")]
	internal IODPCIONDHC([In] KDKNMLEFGMO<OECNLCLGMED>.CAPEOKMHHLI AELKANOHLHO, [In] HOLDAFBGHPF<OECNLCLGMED, LDIDKHKLAFM<AAFGLNNJOHN<KPIEMJMGBJJ>>> EPAOEDBOJNH, [In] LDIDKHKLAFM<AAFGLNNJOHN<KPIEMJMGBJJ>>.NGLMKBFLJHE MNCFHDADCGI, bool IMKACODEGHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x25726E0", Offset = "0x2571AE0", VA = "0x1825726E0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x25728A0", Offset = "0x2571CA0", VA = "0x1825728A0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2572670", Offset = "0x2571A70", VA = "0x182572670", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct KDJGNHDNMIF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal ABIODFMGCKP JHLJJOJLINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal MNNOJOKGAEK GCPIGGCEIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal GFCPMDOJLHH ILCNCDDAICF;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2575E30", Offset = "0x2575230", VA = "0x182575E30")]
	internal KDJGNHDNMIF([In] ABIODFMGCKP NLHKPNGOOIF, [In] MNNOJOKGAEK HLLOODEPJFO, [In] GFCPMDOJLHH IHMOLBABGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2573810", Offset = "0x2572C10", VA = "0x182573810")]
	public static KDJGNHDNMIF FEOBEKOIKMG()
	{
		return default(KDJGNHDNMIF);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2573490", Offset = "0x2572890", VA = "0x182573490", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2574210", Offset = "0x2573610", VA = "0x182574210")]
	public readonly DDFMBLGHENK IMJDHHAECMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2574880", Offset = "0x2573C80", VA = "0x182574880")]
	public void JFHFFJFIIPF(AAFGLNNJOHN<OECNLCLGMED> LHFAKPEIOLP, AAFGLNNJOHN<KPIEMJMGBJJ> GLFIAEKPNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2575C10", Offset = "0x2575010", VA = "0x182575C10")]
	public AAFGLNNJOHN<KPIEMJMGBJJ> OOBJHHMMNJH(AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE)
	{
		return default(AAFGLNNJOHN<KPIEMJMGBJJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2575100", Offset = "0x2574500", VA = "0x182575100")]
	public AAFGLNNJOHN<MOHGMBIPFPM> LCEOJHKHKMN()
	{
		return default(AAFGLNNJOHN<MOHGMBIPFPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2575200", Offset = "0x2574600", VA = "0x182575200")]
	public AAFGLNNJOHN<OECNLCLGMED> LCKPPCLBOLL(AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE)
	{
		return default(AAFGLNNJOHN<OECNLCLGMED>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2575A80", Offset = "0x2574E80", VA = "0x182575A80")]
	public readonly bool ONMPHOAOLED(AAFGLNNJOHN<OECNLCLGMED> LHFAKPEIOLP, AAFGLNNJOHN<KPIEMJMGBJJ> GLFIAEKPNOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2574E60", Offset = "0x2574260", VA = "0x182574E60")]
	public readonly INCPBLHJHCJ<NPEOPECJINL, IODPCIONDHC> KNMJFDGBINO()
	{
		return default(INCPBLHJHCJ<NPEOPECJINL, IODPCIONDHC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2573280", Offset = "0x2572680", VA = "0x182573280")]
	public readonly IODPCIONDHC DGCFLAHLLHM()
	{
		return default(IODPCIONDHC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2574980", Offset = "0x2573D80", VA = "0x182574980")]
	public readonly INCPBLHJHCJ<AAFGLNNJOHN<KPIEMJMGBJJ>, KDKNMLEFGMO<KPIEMJMGBJJ>.CAPEOKMHHLI> JLMGNEOPEMO()
	{
		return default(INCPBLHJHCJ<AAFGLNNJOHN<KPIEMJMGBJJ>, KDKNMLEFGMO<KPIEMJMGBJJ>.CAPEOKMHHLI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2574AB0", Offset = "0x2573EB0", VA = "0x182574AB0")]
	public readonly AAFGLNNJOHN<KPIEMJMGBJJ> JOHFDKPNODJ(AAFGLNNJOHN<OECNLCLGMED> HFCCPEEKCLP, int HAONHOPHKAF)
	{
		return default(AAFGLNNJOHN<KPIEMJMGBJJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2573DE0", Offset = "0x25731E0", VA = "0x182573DE0")]
	public readonly INCPBLHJHCJ<AAFGLNNJOHN<PBJODNNKGBJ>, BKNIIOFGLIL<PBJODNNKGBJ>> GHPEMNGCOHA(AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE)
	{
		return default(INCPBLHJHCJ<AAFGLNNJOHN<PBJODNNKGBJ>, BKNIIOFGLIL<PBJODNNKGBJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2573540", Offset = "0x2572940", VA = "0x182573540")]
	public readonly BKNIIOFGLIL<PBJODNNKGBJ> FBGJEHCCMKN(AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE)
	{
		return default(BKNIIOFGLIL<PBJODNNKGBJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2573C80", Offset = "0x2573080", VA = "0x182573C80")]
	public readonly AAFGLNNJOHN<KPIEMJMGBJJ> FJGMFKNIBOI(AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE, AAFGLNNJOHN<PBJODNNKGBJ> HAONHOPHKAF)
	{
		return default(AAFGLNNJOHN<KPIEMJMGBJJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x25749F0", Offset = "0x2573DF0", VA = "0x1825749F0")]
	public readonly INCPBLHJHCJ<AAFGLNNJOHN<KPIEMJMGBJJ>, JIJEPDKEDPN> JOGPGIIDEIH(AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE)
	{
		return default(INCPBLHJHCJ<AAFGLNNJOHN<KPIEMJMGBJJ>, JIJEPDKEDPN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2572EB0", Offset = "0x25722B0", VA = "0x182572EB0")]
	public readonly JIJEPDKEDPN CEDMIMGMBDH(AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE)
	{
		return default(JIJEPDKEDPN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2573E70", Offset = "0x2573270", VA = "0x182573E70")]
	public readonly AJJDFIHNGOI<AAFGLNNJOHN<KPIEMJMGBJJ>, LDIDKHKLAFM<AAFGLNNJOHN<KPIEMJMGBJJ>>.NGLMKBFLJHE> HFHABDPDNMJ(AAFGLNNJOHN<OECNLCLGMED> HFCCPEEKCLP)
	{
		return default(AJJDFIHNGOI<AAFGLNNJOHN<KPIEMJMGBJJ>, LDIDKHKLAFM<AAFGLNNJOHN<KPIEMJMGBJJ>>.NGLMKBFLJHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x25752F0", Offset = "0x25746F0", VA = "0x1825752F0")]
	public readonly LDIDKHKLAFM<AAFGLNNJOHN<KPIEMJMGBJJ>>.NGLMKBFLJHE LIHIINIKOJM(AAFGLNNJOHN<OECNLCLGMED> HFCCPEEKCLP)
	{
		return default(LDIDKHKLAFM<AAFGLNNJOHN<KPIEMJMGBJJ>>.NGLMKBFLJHE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2575610", Offset = "0x2574A10", VA = "0x182575610")]
	public readonly AJJDFIHNGOI<AAFGLNNJOHN<KPIEMJMGBJJ>, LDIDKHKLAFM<AAFGLNNJOHN<KPIEMJMGBJJ>>.NGLMKBFLJHE> MIFCLLKNBJL(AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE)
	{
		return default(AJJDFIHNGOI<AAFGLNNJOHN<KPIEMJMGBJJ>, LDIDKHKLAFM<AAFGLNNJOHN<KPIEMJMGBJJ>>.NGLMKBFLJHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2573150", Offset = "0x2572550", VA = "0x182573150")]
	public readonly LDIDKHKLAFM<AAFGLNNJOHN<KPIEMJMGBJJ>>.NGLMKBFLJHE CMBFKPPLGJM(AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE)
	{
		return default(LDIDKHKLAFM<AAFGLNNJOHN<KPIEMJMGBJJ>>.NGLMKBFLJHE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2574FA0", Offset = "0x25743A0", VA = "0x182574FA0")]
	public readonly INCPBLHJHCJ<AAFGLNNJOHN<MOHGMBIPFPM>, IKGDCKIGIHA> LBMIHMCAHGB(AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE)
	{
		return default(INCPBLHJHCJ<AAFGLNNJOHN<MOHGMBIPFPM>, IKGDCKIGIHA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2572D00", Offset = "0x2572100", VA = "0x182572D00")]
	public readonly IKGDCKIGIHA ALOJGDIBBGD(AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE)
	{
		return default(IKGDCKIGIHA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2575DC0", Offset = "0x25751C0", VA = "0x182575DC0")]
	public readonly INCPBLHJHCJ<AAFGLNNJOHN<MOHGMBIPFPM>, KDKNMLEFGMO<MOHGMBIPFPM>.CAPEOKMHHLI> POHIOICACOC()
	{
		return default(INCPBLHJHCJ<AAFGLNNJOHN<MOHGMBIPFPM>, KDKNMLEFGMO<MOHGMBIPFPM>.CAPEOKMHHLI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2572FA0", Offset = "0x25723A0", VA = "0x182572FA0")]
	public readonly KDKNMLEFGMO<MOHGMBIPFPM>.CAPEOKMHHLI CFFOOGKLDDP()
	{
		return default(KDKNMLEFGMO<MOHGMBIPFPM>.CAPEOKMHHLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x25756C0", Offset = "0x2574AC0", VA = "0x1825756C0")]
	public readonly int MNDLPKIPOHC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x25741D0", Offset = "0x25735D0", VA = "0x1825741D0")]
	public readonly int IJOKPFMMHGB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x25734C0", Offset = "0x25728C0", VA = "0x1825734C0")]
	public readonly int ENBCNGMOECC(AAFGLNNJOHN<OECNLCLGMED> HFCCPEEKCLP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2575940", Offset = "0x2574D40", VA = "0x182575940")]
	public readonly int NLDEDKKMKLP(AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2573110", Offset = "0x2572510", VA = "0x182573110")]
	public readonly int CJPENFJKBGA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2575A40", Offset = "0x2574E40", VA = "0x182575A40")]
	public readonly int OJODOKLAKAI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2573200", Offset = "0x2572600", VA = "0x182573200")]
	public readonly int DBBGDDBAAMA(AAFGLNNJOHN<KPIEMJMGBJJ> FAEFIHLMPDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x25754F0", Offset = "0x25748F0", VA = "0x1825754F0")]
	public readonly int MBGECNOLIKP(AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x25733F0", Offset = "0x25727F0", VA = "0x1825733F0")]
	public readonly AAFGLNNJOHN<OECNLCLGMED> DJNJFLEJMBB(AAFGLNNJOHN<KPIEMJMGBJJ> FAEFIHLMPDO, int JLLMELNAAHA)
	{
		return default(AAFGLNNJOHN<OECNLCLGMED>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2572E00", Offset = "0x2572200", VA = "0x182572E00")]
	public readonly INCPBLHJHCJ<AAFGLNNJOHN<ILELENOJNKM>, BKNIIOFGLIL<ILELENOJNKM>> BGHPMOCGMED(AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE)
	{
		return default(INCPBLHJHCJ<AAFGLNNJOHN<ILELENOJNKM>, BKNIIOFGLIL<ILELENOJNKM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2575CB0", Offset = "0x25750B0", VA = "0x182575CB0")]
	public readonly BKNIIOFGLIL<ILELENOJNKM> PMIDFFBPJHC(AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE)
	{
		return default(BKNIIOFGLIL<ILELENOJNKM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2574DC0", Offset = "0x25741C0", VA = "0x182574DC0")]
	public readonly AAFGLNNJOHN<OECNLCLGMED> KJHLJMMELDA(AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE, AAFGLNNJOHN<ILELENOJNKM> JLLMELNAAHA)
	{
		return default(AAFGLNNJOHN<OECNLCLGMED>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2575570", Offset = "0x2574970", VA = "0x182575570")]
	public readonly AJJDFIHNGOI<AAFGLNNJOHN<OECNLCLGMED>, LDIDKHKLAFM<AAFGLNNJOHN<OECNLCLGMED>>.NGLMKBFLJHE> MEPFAJENGGO(AAFGLNNJOHN<KPIEMJMGBJJ> FAEFIHLMPDO)
	{
		return default(AJJDFIHNGOI<AAFGLNNJOHN<OECNLCLGMED>, LDIDKHKLAFM<AAFGLNNJOHN<OECNLCLGMED>>.NGLMKBFLJHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2573D40", Offset = "0x2573140", VA = "0x182573D40")]
	public readonly LDIDKHKLAFM<AAFGLNNJOHN<OECNLCLGMED>>.NGLMKBFLJHE GCKCMOIGMIK(AAFGLNNJOHN<KPIEMJMGBJJ> FAEFIHLMPDO)
	{
		return default(LDIDKHKLAFM<AAFGLNNJOHN<OECNLCLGMED>>.NGLMKBFLJHE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x25740E0", Offset = "0x25734E0", VA = "0x1825740E0")]
	public readonly EFDDCGJJFAK IIBEKEKEJKP(AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE)
	{
		return default(EFDDCGJJFAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2575850", Offset = "0x2574C50", VA = "0x182575850")]
	public readonly KDKNMLEFGMO<OECNLCLGMED>.CAPEOKMHHLI MOGJCOEOEMN()
	{
		return default(KDKNMLEFGMO<OECNLCLGMED>.CAPEOKMHHLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2575D10", Offset = "0x2575110", VA = "0x182575D10")]
	public readonly AJJDFIHNGOI<AAFGLNNJOHN<OECNLCLGMED>, LDIDKHKLAFM<AAFGLNNJOHN<OECNLCLGMED>>.NGLMKBFLJHE> PNOLANAAEDF(AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE)
	{
		return default(AJJDFIHNGOI<AAFGLNNJOHN<OECNLCLGMED>, LDIDKHKLAFM<AAFGLNNJOHN<OECNLCLGMED>>.NGLMKBFLJHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2573B80", Offset = "0x2572F80", VA = "0x182573B80")]
	public readonly LDIDKHKLAFM<AAFGLNNJOHN<OECNLCLGMED>>.NGLMKBFLJHE FHLMHCELIHD(AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE)
	{
		return default(LDIDKHKLAFM<AAFGLNNJOHN<OECNLCLGMED>>.NGLMKBFLJHE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x25758C0", Offset = "0x2574CC0", VA = "0x1825758C0")]
	public readonly AAFGLNNJOHN<MOHGMBIPFPM> NCGJOAINKFK(AAFGLNNJOHN<KPIEMJMGBJJ> FAEFIHLMPDO)
	{
		return default(AAFGLNNJOHN<MOHGMBIPFPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x25759C0", Offset = "0x2574DC0", VA = "0x1825759C0")]
	public readonly AAFGLNNJOHN<MOHGMBIPFPM> NNNAHKNHKEP(AAFGLNNJOHN<OECNLCLGMED> HFCCPEEKCLP)
	{
		return default(AAFGLNNJOHN<MOHGMBIPFPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2573C30", Offset = "0x2573030", VA = "0x182573C30")]
	public readonly bool FHNEPMKLPLE(AAFGLNNJOHN<KPIEMJMGBJJ> FAEFIHLMPDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2573330", Offset = "0x2572730", VA = "0x182573330")]
	public AAFGLNNJOHN<KPIEMJMGBJJ> DHBMJECBBNN(AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE, AAFGLNNJOHN<PBJODNNKGBJ> HAONHOPHKAF)
	{
		return default(AAFGLNNJOHN<KPIEMJMGBJJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2574020", Offset = "0x2573420", VA = "0x182574020")]
	public AAFGLNNJOHN<OECNLCLGMED> HOCONMHBAEP(AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE, AAFGLNNJOHN<ILELENOJNKM> JLLMELNAAHA)
	{
		return default(AAFGLNNJOHN<OECNLCLGMED>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2573D20", Offset = "0x2573120", VA = "0x182573D20")]
	public readonly bool FMIBKOCMGME(AAFGLNNJOHN<KPIEMJMGBJJ> FAEFIHLMPDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2572E90", Offset = "0x2572290", VA = "0x182572E90")]
	public readonly bool BKPHLAFEMIP(AAFGLNNJOHN<OECNLCLGMED> HFCCPEEKCLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2573F20", Offset = "0x2573320", VA = "0x182573F20")]
	public void HHIEIBMHKIN(AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE, AAFGLNNJOHN<PBJODNNKGBJ> IHOEEOGDLDH, AAFGLNNJOHN<PBJODNNKGBJ> PAAADJBJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x25753F0", Offset = "0x25747F0", VA = "0x1825753F0")]
	public void LPADNDBKHND(AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE, AAFGLNNJOHN<ILELENOJNKM> LEJMIBEHGEO, AAFGLNNJOHN<ILELENOJNKM> BLFENBEFKKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x25752A0", Offset = "0x25746A0", VA = "0x1825752A0")]
	public readonly bool LCMICFANOOM(AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x25753A0", Offset = "0x25747A0", VA = "0x1825753A0")]
	public readonly bool LJIEHJFGHLB(AAFGLNNJOHN<OECNLCLGMED> HFCCPEEKCLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2573010", Offset = "0x2572410", VA = "0x182573010")]
	public void CJNNBEMHIIF(AAFGLNNJOHN<OECNLCLGMED> LHFAKPEIOLP, AAFGLNNJOHN<KPIEMJMGBJJ> GLFIAEKPNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x25735A0", Offset = "0x25729A0", VA = "0x1825735A0")]
	public void FCKGCBPIOIL(AAFGLNNJOHN<KPIEMJMGBJJ> FAEFIHLMPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x25742C0", Offset = "0x25736C0", VA = "0x1825742C0")]
	public void JEOKKPKENEH(AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2574B50", Offset = "0x2573F50", VA = "0x182574B50")]
	public void KECCCHCENAG(AAFGLNNJOHN<OECNLCLGMED> HFCCPEEKCLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class JKLDDFLPPOD
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xB0B4F0", Offset = "0xB0A8F0", VA = "0x180B0B4F0")]
	public static KDKNMLEFGMO<KPIEMJMGBJJ> PKBNIDHAMJN([In] this KDJGNHDNMIF JDCFMPOHCEA)
	{
		return default(KDKNMLEFGMO<KPIEMJMGBJJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2572CF0", Offset = "0x25720F0", VA = "0x182572CF0")]
	public static KDKNMLEFGMO<OECNLCLGMED> FEFBLEAMCNE([In] this KDJGNHDNMIF JDCFMPOHCEA)
	{
		return default(KDKNMLEFGMO<OECNLCLGMED>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2572CE0", Offset = "0x25720E0", VA = "0x182572CE0")]
	public static KDKNMLEFGMO<MOHGMBIPFPM> DPFNFCCIAMM([In] this KDJGNHDNMIF JDCFMPOHCEA)
	{
		return default(KDKNMLEFGMO<MOHGMBIPFPM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal struct ABIODFMGCKP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public KDKNMLEFGMO<KPIEMJMGBJJ> JKDBEKCCFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public HOLDAFBGHPF<KPIEMJMGBJJ, AAFGLNNJOHN<MOHGMBIPFPM>> GADFMCLGIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public HOLDAFBGHPF<KPIEMJMGBJJ, LDIDKHKLAFM<AAFGLNNJOHN<OECNLCLGMED>>> AGONGCDEPOH;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x256FA50", Offset = "0x256EE50", VA = "0x18256FA50")]
	public ABIODFMGCKP([In] KDKNMLEFGMO<KPIEMJMGBJJ> FLBICDNHLHF, [In] HOLDAFBGHPF<KPIEMJMGBJJ, AAFGLNNJOHN<MOHGMBIPFPM>> IHMOLBABGJL, [In] HOLDAFBGHPF<KPIEMJMGBJJ, LDIDKHKLAFM<AAFGLNNJOHN<OECNLCLGMED>>> HLLOODEPJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x256F480", Offset = "0x256E880", VA = "0x18256F480")]
	public static ABIODFMGCKP FEOBEKOIKMG()
	{
		return default(ABIODFMGCKP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x256F2E0", Offset = "0x256E6E0", VA = "0x18256F2E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x256F620", Offset = "0x256EA20", VA = "0x18256F620")]
	public readonly DOMHDDHJDPN IMJDHHAECMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x256F560", Offset = "0x256E960", VA = "0x18256F560")]
	public AAFGLNNJOHN<KPIEMJMGBJJ> FOFIHJEGBLL(AAFGLNNJOHN<MOHGMBIPFPM> HPEELAFENFB)
	{
		return default(AAFGLNNJOHN<KPIEMJMGBJJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x256F200", Offset = "0x256E600", VA = "0x18256F200")]
	public void BHDLIGCHPAN(AAFGLNNJOHN<KPIEMJMGBJJ> KGHCKLKGJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x256F8E0", Offset = "0x256ECE0", VA = "0x18256F8E0")]
	[CompilerGenerated]
	internal static HOKIEJIILHN KCNNGFAGHPE([In] LDIDKHKLAFM<AAFGLNNJOHN<OECNLCLGMED>> JDCFMPOHCEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct JIJEPDKEDPN : IEnumerator<AAFGLNNJOHN<KPIEMJMGBJJ>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LDIDKHKLAFM<AAFGLNNJOHN<OECNLCLGMED>>.NGLMKBFLJHE FGGPJDGKGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private LDIDKHKLAFM<AAFGLNNJOHN<KPIEMJMGBJJ>>.NGLMKBFLJHE IGNPMOEALCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly HOLDAFBGHPF<OECNLCLGMED, LDIDKHKLAFM<AAFGLNNJOHN<KPIEMJMGBJJ>>> MGLNMDJCDMB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public AAFGLNNJOHN<KPIEMJMGBJJ> FJMLFGNPDDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2572CA0", Offset = "0x25720A0", VA = "0x182572CA0", Slot = "4")]
		get
		{
			return default(AAFGLNNJOHN<KPIEMJMGBJJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2572C30", Offset = "0x2572030", VA = "0x182572C30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2570720", Offset = "0x256FB20", VA = "0x182570720")]
	internal JIJEPDKEDPN([In] LDIDKHKLAFM<AAFGLNNJOHN<OECNLCLGMED>>.NGLMKBFLJHE AELKANOHLHO, [In] LDIDKHKLAFM<AAFGLNNJOHN<KPIEMJMGBJJ>>.NGLMKBFLJHE FPJCCPHAJLD, [In] HOLDAFBGHPF<OECNLCLGMED, LDIDKHKLAFM<AAFGLNNJOHN<KPIEMJMGBJJ>>> AEMAMKONOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2572A90", Offset = "0x2571E90", VA = "0x182572A90", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2572BD0", Offset = "0x2571FD0", VA = "0x182572BD0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2572A30", Offset = "0x2571E30", VA = "0x182572A30", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal struct GFCPMDOJLHH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public KDKNMLEFGMO<MOHGMBIPFPM> JKDBEKCCFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public HOLDAFBGHPF<MOHGMBIPFPM, LDIDKHKLAFM<AAFGLNNJOHN<KPIEMJMGBJJ>>> FHGGHNBKBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public HOLDAFBGHPF<MOHGMBIPFPM, LDIDKHKLAFM<AAFGLNNJOHN<OECNLCLGMED>>> AGONGCDEPOH;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x256FA50", Offset = "0x256EE50", VA = "0x18256FA50")]
	public GFCPMDOJLHH([In] KDKNMLEFGMO<MOHGMBIPFPM> FLBICDNHLHF, [In] HOLDAFBGHPF<MOHGMBIPFPM, LDIDKHKLAFM<AAFGLNNJOHN<KPIEMJMGBJJ>>> NLHKPNGOOIF, [In] HOLDAFBGHPF<MOHGMBIPFPM, LDIDKHKLAFM<AAFGLNNJOHN<OECNLCLGMED>>> HLLOODEPJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2570D40", Offset = "0x2570140", VA = "0x182570D40")]
	public static GFCPMDOJLHH FEOBEKOIKMG()
	{
		return default(GFCPMDOJLHH);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2570A70", Offset = "0x256FE70", VA = "0x182570A70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2571040", Offset = "0x2570440", VA = "0x182571040")]
	public readonly NOOAMIDHDKB IMJDHHAECMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2570E20", Offset = "0x2570220", VA = "0x182570E20")]
	public AAFGLNNJOHN<MOHGMBIPFPM> FOFIHJEGBLL([In] LDIDKHKLAFM<AAFGLNNJOHN<KPIEMJMGBJJ>> NLHKPNGOOIF, [In] LDIDKHKLAFM<AAFGLNNJOHN<OECNLCLGMED>> HLLOODEPJFO)
	{
		return default(AAFGLNNJOHN<MOHGMBIPFPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x25707C0", Offset = "0x256FBC0", VA = "0x1825707C0")]
	public void BHDLIGCHPAN(AAFGLNNJOHN<MOHGMBIPFPM> KGHCKLKGJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2570900", Offset = "0x256FD00", VA = "0x182570900")]
	[CompilerGenerated]
	internal static KBCAEJPEFFI CCBNDFNPPNE([In] LDIDKHKLAFM<AAFGLNNJOHN<KPIEMJMGBJJ>> JDCFMPOHCEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2570ED0", Offset = "0x25702D0", VA = "0x182570ED0")]
	[CompilerGenerated]
	internal static FDLFMPBHBLH IJMKIKBPNGO([In] LDIDKHKLAFM<AAFGLNNJOHN<OECNLCLGMED>> JDCFMPOHCEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct IKGDCKIGIHA : IEnumerator<AAFGLNNJOHN<MOHGMBIPFPM>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private JIJEPDKEDPN EGCMKIFJHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HOLDAFBGHPF<KPIEMJMGBJJ, AAFGLNNJOHN<MOHGMBIPFPM>> FEEPNIDIKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private EFDDCGJJFAK KDEEKHGJDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly HOLDAFBGHPF<OECNLCLGMED, AAFGLNNJOHN<MOHGMBIPFPM>> DPDKKAFGICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private bool HMACKLIJCEK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public readonly AAFGLNNJOHN<MOHGMBIPFPM> FJMLFGNPDDN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x25724F0", Offset = "0x25718F0", VA = "0x1825724F0", Slot = "4")]
		get
		{
			return default(AAFGLNNJOHN<MOHGMBIPFPM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x25723F0", Offset = "0x25717F0", VA = "0x1825723F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2572440", Offset = "0x2571840", VA = "0x182572440")]
	internal IKGDCKIGIHA([In] JIJEPDKEDPN FCDGCNPHNAM, [In] HOLDAFBGHPF<KPIEMJMGBJJ, AAFGLNNJOHN<MOHGMBIPFPM>> CFNANKMNKGO, [In] EFDDCGJJFAK GMKDOMGBAPA, [In] HOLDAFBGHPF<OECNLCLGMED, AAFGLNNJOHN<MOHGMBIPFPM>> KLBIAMMMDPP, bool NMFKGBLDAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x25722F0", Offset = "0x25716F0", VA = "0x1825722F0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2572340", Offset = "0x2571740", VA = "0x182572340", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2572250", Offset = "0x2571650", VA = "0x182572250", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal struct MNNOJOKGAEK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public KDKNMLEFGMO<OECNLCLGMED> JKDBEKCCFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public HOLDAFBGHPF<OECNLCLGMED, AAFGLNNJOHN<MOHGMBIPFPM>> GADFMCLGIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public HOLDAFBGHPF<OECNLCLGMED, LDIDKHKLAFM<AAFGLNNJOHN<KPIEMJMGBJJ>>> FHGGHNBKBMI;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x256FA50", Offset = "0x256EE50", VA = "0x18256FA50")]
	public MNNOJOKGAEK([In] KDKNMLEFGMO<OECNLCLGMED> FLBICDNHLHF, [In] HOLDAFBGHPF<OECNLCLGMED, AAFGLNNJOHN<MOHGMBIPFPM>> IHMOLBABGJL, [In] HOLDAFBGHPF<OECNLCLGMED, LDIDKHKLAFM<AAFGLNNJOHN<KPIEMJMGBJJ>>> NLHKPNGOOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2576190", Offset = "0x2575590", VA = "0x182576190")]
	public static MNNOJOKGAEK FEOBEKOIKMG()
	{
		return default(MNNOJOKGAEK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2575FF0", Offset = "0x25753F0", VA = "0x182575FF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2576330", Offset = "0x2575730", VA = "0x182576330")]
	public readonly JCNKCFJKAJN IMJDHHAECMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2576270", Offset = "0x2575670", VA = "0x182576270")]
	public AAFGLNNJOHN<OECNLCLGMED> FOFIHJEGBLL(AAFGLNNJOHN<MOHGMBIPFPM> HPEELAFENFB)
	{
		return default(AAFGLNNJOHN<OECNLCLGMED>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2575F10", Offset = "0x2575310", VA = "0x182575F10")]
	public void BHDLIGCHPAN(AAFGLNNJOHN<OECNLCLGMED> KGHCKLKGJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x25765F0", Offset = "0x25759F0", VA = "0x1825765F0")]
	[CompilerGenerated]
	internal static MEHLDIKDGDA NFIGDNGOOIJ([In] LDIDKHKLAFM<AAFGLNNJOHN<KPIEMJMGBJJ>> JDCFMPOHCEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct EFDDCGJJFAK : IEnumerator<AAFGLNNJOHN<OECNLCLGMED>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private LDIDKHKLAFM<AAFGLNNJOHN<KPIEMJMGBJJ>>.NGLMKBFLJHE NDHFHOEBJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private LDIDKHKLAFM<AAFGLNNJOHN<OECNLCLGMED>>.NGLMKBFLJHE BAAOAPEIKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HOLDAFBGHPF<KPIEMJMGBJJ, LDIDKHKLAFM<AAFGLNNJOHN<OECNLCLGMED>>> FIIJOLMMJBE;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AAFGLNNJOHN<OECNLCLGMED> FJMLFGNPDDN
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2570780", Offset = "0x256FB80", VA = "0x182570780", Slot = "4")]
		get
		{
			return default(AAFGLNNJOHN<OECNLCLGMED>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x25706B0", Offset = "0x256FAB0", VA = "0x1825706B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2570720", Offset = "0x256FB20", VA = "0x182570720")]
	internal EFDDCGJJFAK([In] LDIDKHKLAFM<AAFGLNNJOHN<KPIEMJMGBJJ>>.NGLMKBFLJHE GCIENLFCNIO, [In] LDIDKHKLAFM<AAFGLNNJOHN<OECNLCLGMED>>.NGLMKBFLJHE PPKCOLEJLPD, [In] HOLDAFBGHPF<KPIEMJMGBJJ, LDIDKHKLAFM<AAFGLNNJOHN<OECNLCLGMED>>> MNAEHDPNAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2570510", Offset = "0x256F910", VA = "0x182570510", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2570650", Offset = "0x256FA50", VA = "0x182570650", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x25704B0", Offset = "0x256F8B0", VA = "0x1825704B0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal static class ACCPGEOPIPB
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x256FBD0", Offset = "0x256EFD0", VA = "0x18256FBD0")]
	public static GFCPMDOJLHH GFOCOOKFNLL(this NOOAMIDHDKB JDCFMPOHCEA)
	{
		return default(GFCPMDOJLHH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x256FAC0", Offset = "0x256EEC0", VA = "0x18256FAC0")]
	public static void BHDLIGCHPAN(this NOOAMIDHDKB JDCFMPOHCEA, int KGHCKLKGJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2570290", Offset = "0x256F690", VA = "0x182570290")]
	[CompilerGenerated]
	internal static LDIDKHKLAFM<AAFGLNNJOHN<KPIEMJMGBJJ>> LGDIGEFLACL(KBCAEJPEFFI JDCFMPOHCEA)
	{
		return default(LDIDKHKLAFM<AAFGLNNJOHN<KPIEMJMGBJJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2570070", Offset = "0x256F470", VA = "0x182570070")]
	[CompilerGenerated]
	internal static LDIDKHKLAFM<AAFGLNNJOHN<OECNLCLGMED>> HPOEBLHNKAK(FDLFMPBHBLH JDCFMPOHCEA)
	{
		return default(LDIDKHKLAFM<AAFGLNNJOHN<OECNLCLGMED>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class PINEDMOMPPL
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2576B70", Offset = "0x2575F70", VA = "0x182576B70")]
	public static KDJGNHDNMIF GFOCOOKFNLL(this DDFMBLGHENK JDCFMPOHCEA)
	{
		return default(KDJGNHDNMIF);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2576AC0", Offset = "0x2575EC0", VA = "0x182576AC0")]
	public static AAFGLNNJOHN<KPIEMJMGBJJ> FJGMFKNIBOI(this DDFMBLGHENK JDCFMPOHCEA, AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE, AAFGLNNJOHN<PBJODNNKGBJ> HAONHOPHKAF)
	{
		return default(AAFGLNNJOHN<KPIEMJMGBJJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2576F60", Offset = "0x2576360", VA = "0x182576F60")]
	public static INCPBLHJHCJ<AAFGLNNJOHN<KPIEMJMGBJJ>, NJMKLCJIHDO<KPIEMJMGBJJ>.CAPBECFCGNA> HFHABDPDNMJ(this DDFMBLGHENK JDCFMPOHCEA, AAFGLNNJOHN<OECNLCLGMED> HFCCPEEKCLP)
	{
		return default(INCPBLHJHCJ<AAFGLNNJOHN<KPIEMJMGBJJ>, NJMKLCJIHDO<KPIEMJMGBJJ>.CAPBECFCGNA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2577C90", Offset = "0x2577090", VA = "0x182577C90")]
	public static IEnumerable<int> MIFCLLKNBJL(this DDFMBLGHENK JDCFMPOHCEA, int MEGMENINLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2577D70", Offset = "0x2577170", VA = "0x182577D70")]
	public static int NLDEDKKMKLP(this DDFMBLGHENK JDCFMPOHCEA, AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2577B10", Offset = "0x2576F10", VA = "0x182577B10")]
	public static int MBGECNOLIKP(this DDFMBLGHENK JDCFMPOHCEA, AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2577A60", Offset = "0x2576E60", VA = "0x182577A60")]
	public static AAFGLNNJOHN<OECNLCLGMED> KJHLJMMELDA(this DDFMBLGHENK JDCFMPOHCEA, AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE, AAFGLNNJOHN<ILELENOJNKM> JLLMELNAAHA)
	{
		return default(AAFGLNNJOHN<OECNLCLGMED>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2577B90", Offset = "0x2576F90", VA = "0x182577B90")]
	public static INCPBLHJHCJ<AAFGLNNJOHN<OECNLCLGMED>, NJMKLCJIHDO<OECNLCLGMED>.CAPBECFCGNA> MEPFAJENGGO(this DDFMBLGHENK JDCFMPOHCEA, AAFGLNNJOHN<KPIEMJMGBJJ> FAEFIHLMPDO)
	{
		return default(INCPBLHJHCJ<AAFGLNNJOHN<OECNLCLGMED>, NJMKLCJIHDO<OECNLCLGMED>.CAPBECFCGNA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2577E60", Offset = "0x2577260", VA = "0x182577E60")]
	public static IEnumerable<int> PNOLANAAEDF(this DDFMBLGHENK JDCFMPOHCEA, int MEGMENINLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2577D00", Offset = "0x2577100", VA = "0x182577D00")]
	public static AAFGLNNJOHN<MOHGMBIPFPM> NCGJOAINKFK(this DDFMBLGHENK JDCFMPOHCEA, AAFGLNNJOHN<KPIEMJMGBJJ> FAEFIHLMPDO)
	{
		return default(AAFGLNNJOHN<MOHGMBIPFPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2577DF0", Offset = "0x25771F0", VA = "0x182577DF0")]
	public static AAFGLNNJOHN<MOHGMBIPFPM> NNNAHKNHKEP(this DDFMBLGHENK JDCFMPOHCEA, AAFGLNNJOHN<OECNLCLGMED> HFCCPEEKCLP)
	{
		return default(AAFGLNNJOHN<MOHGMBIPFPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x25767E0", Offset = "0x2575BE0", VA = "0x1825767E0")]
	public static void FCKGCBPIOIL(this DDFMBLGHENK JDCFMPOHCEA, AAFGLNNJOHN<KPIEMJMGBJJ> FAEFIHLMPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2577060", Offset = "0x2576460", VA = "0x182577060")]
	public static void JEOKKPKENEH(this DDFMBLGHENK JDCFMPOHCEA, int MEGMENINLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2577780", Offset = "0x2576B80", VA = "0x182577780")]
	public static void KECCCHCENAG(this DDFMBLGHENK JDCFMPOHCEA, AAFGLNNJOHN<OECNLCLGMED> HFCCPEEKCLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal static class HBFBGBJCMGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2571620", Offset = "0x2570A20", VA = "0x182571620")]
	public static ABIODFMGCKP GFOCOOKFNLL(this DOMHDDHJDPN JDCFMPOHCEA)
	{
		return default(ABIODFMGCKP);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2571330", Offset = "0x2570730", VA = "0x182571330")]
	public static void BHDLIGCHPAN(this DOMHDDHJDPN JDCFMPOHCEA, int KGHCKLKGJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2571400", Offset = "0x2570800", VA = "0x182571400")]
	[CompilerGenerated]
	internal static LDIDKHKLAFM<AAFGLNNJOHN<OECNLCLGMED>> FNOHFALPHGL(HOKIEJIILHN JDCFMPOHCEA)
	{
		return default(LDIDKHKLAFM<AAFGLNNJOHN<OECNLCLGMED>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal static class ICGMDNILNFG
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2571B90", Offset = "0x2570F90", VA = "0x182571B90")]
	public static MNNOJOKGAEK GFOCOOKFNLL(this JCNKCFJKAJN JDCFMPOHCEA)
	{
		return default(MNNOJOKGAEK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2571AC0", Offset = "0x2570EC0", VA = "0x182571AC0")]
	public static void BHDLIGCHPAN(this JCNKCFJKAJN JDCFMPOHCEA, int KGHCKLKGJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2572030", Offset = "0x2571430", VA = "0x182572030")]
	[CompilerGenerated]
	internal static LDIDKHKLAFM<AAFGLNNJOHN<KPIEMJMGBJJ>> HEBKIMBOBBB(MEHLDIKDGDA JDCFMPOHCEA)
	{
		return default(LDIDKHKLAFM<AAFGLNNJOHN<KPIEMJMGBJJ>>);
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
