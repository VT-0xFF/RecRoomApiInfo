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
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x23468C0", Offset = "0x2345CC0", VA = "0x1823468C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F1670", Offset = "0x8F0A70", VA = "0x1808F1670")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F16B0", Offset = "0x8F0AB0", VA = "0x1808F16B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct FABODCLIONC : IEnumerator<DJLKPLHDEAP>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private GKOBKBKCCCO<JGJEEGHFLFO>.OHFLLBBHJAF GKNDCDGJLHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private BPONAHELEAL<JGJEEGHFLFO, OGHLOBLCDJI<AHPCDKCOAJM<PLHEEEFNBNK>>> AALPCPFKNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private OGHLOBLCDJI<AHPCDKCOAJM<PLHEEEFNBNK>>.EAJFADKHJJA ADIAKLLKLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool MJIMFCGENAH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public DJLKPLHDEAP DLFFLJHEEDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2345340", Offset = "0x2344740", VA = "0x182345340", Slot = "4")]
		get
		{
			return default(DJLKPLHDEAP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2345280", Offset = "0x2344680", VA = "0x182345280", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x23452D0", Offset = "0x23446D0", VA = "0x1823452D0")]
	internal FABODCLIONC([In] GKOBKBKCCCO<JGJEEGHFLFO>.OHFLLBBHJAF OGFDINOBNFL, [In] BPONAHELEAL<JGJEEGHFLFO, OGHLOBLCDJI<AHPCDKCOAJM<PLHEEEFNBNK>>> NIJIJFMHKPJ, [In] OGHLOBLCDJI<AHPCDKCOAJM<PLHEEEFNBNK>>.EAJFADKHJJA BHKDBOEOKDF, bool EDDJHDNJFKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2345090", Offset = "0x2344490", VA = "0x182345090", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2345240", Offset = "0x2344640", VA = "0x182345240", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2345020", Offset = "0x2344420", VA = "0x182345020", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct PHJEECMEBKI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal OBCFGIHFNKH POBGMGHDDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal FLKKEPNAJBA MBPNEDKCOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal EJNOEFONOMP BAIPGPLCGJP;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x234C030", Offset = "0x234B430", VA = "0x18234C030")]
	internal PHJEECMEBKI([In] OBCFGIHFNKH POJBCHAHLFG, [In] FLKKEPNAJBA BOJIHAAGEDD, [In] EJNOEFONOMP FPODBFBAGHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x234B8C0", Offset = "0x234ACC0", VA = "0x18234B8C0")]
	public static PHJEECMEBKI ODOFIFAGLAJ()
	{
		return default(PHJEECMEBKI);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2349C80", Offset = "0x2349080", VA = "0x182349C80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x234A380", Offset = "0x2349780", VA = "0x18234A380")]
	public readonly HLPMBGNBJKE GKPJGNLGAKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x234B440", Offset = "0x234A840", VA = "0x18234B440")]
	public void LGNJPBNIIAI(AHPCDKCOAJM<JGJEEGHFLFO> FOKGOFPCJND, AHPCDKCOAJM<PLHEEEFNBNK> ACPIEDANBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x234BD40", Offset = "0x234B140", VA = "0x18234BD40")]
	public AHPCDKCOAJM<PLHEEEFNBNK> OMKKPIEFKGH(AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO)
	{
		return default(AHPCDKCOAJM<PLHEEEFNBNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x234ABE0", Offset = "0x2349FE0", VA = "0x18234ABE0")]
	public AHPCDKCOAJM<AMFCOJIMJGL> HNKELJGGADC()
	{
		return default(AHPCDKCOAJM<AMFCOJIMJGL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x234ADA0", Offset = "0x234A1A0", VA = "0x18234ADA0")]
	public AHPCDKCOAJM<JGJEEGHFLFO> INEPDLKGAPP(AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO)
	{
		return default(AHPCDKCOAJM<JGJEEGHFLFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x234B050", Offset = "0x234A450", VA = "0x18234B050")]
	public readonly bool JOBIPILKIPB(AHPCDKCOAJM<JGJEEGHFLFO> FOKGOFPCJND, AHPCDKCOAJM<PLHEEEFNBNK> ACPIEDANBLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x234A240", Offset = "0x2349640", VA = "0x18234A240")]
	public readonly EDADAJJFIOD<DJLKPLHDEAP, FABODCLIONC> GEMKBCOPCHG()
	{
		return default(EDADAJJFIOD<DJLKPLHDEAP, FABODCLIONC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x234B630", Offset = "0x234AA30", VA = "0x18234B630")]
	public readonly FABODCLIONC MMKIIKLKOGG()
	{
		return default(FABODCLIONC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x234A010", Offset = "0x2349410", VA = "0x18234A010")]
	public readonly EDADAJJFIOD<AHPCDKCOAJM<PLHEEEFNBNK>, GKOBKBKCCCO<PLHEEEFNBNK>.OHFLLBBHJAF> FOCAHFEDONA()
	{
		return default(EDADAJJFIOD<AHPCDKCOAJM<PLHEEEFNBNK>, GKOBKBKCCCO<PLHEEEFNBNK>.OHFLLBBHJAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x23496E0", Offset = "0x2348AE0", VA = "0x1823496E0")]
	public readonly AHPCDKCOAJM<PLHEEEFNBNK> DAKPMNKONIA(AHPCDKCOAJM<JGJEEGHFLFO> MLIAJGPJJLE, int IJNJJIFCDBB)
	{
		return default(AHPCDKCOAJM<PLHEEEFNBNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x234B1E0", Offset = "0x234A5E0", VA = "0x18234B1E0")]
	public readonly EDADAJJFIOD<AHPCDKCOAJM<JIJMEHHKNOE>, GBCKIPNOLOD<JIJMEHHKNOE>> KDJJPDIHMEE(AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO)
	{
		return default(EDADAJJFIOD<AHPCDKCOAJM<JIJMEHHKNOE>, GBCKIPNOLOD<JIJMEHHKNOE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x234A450", Offset = "0x2349850", VA = "0x18234A450")]
	public readonly GBCKIPNOLOD<JIJMEHHKNOE> GPJPDJGNAKJ(AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO)
	{
		return default(GBCKIPNOLOD<JIJMEHHKNOE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x234BF90", Offset = "0x234B390", VA = "0x18234BF90")]
	public readonly AHPCDKCOAJM<PLHEEEFNBNK> PEGBENAFHKB(AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO, AHPCDKCOAJM<JIJMEHHKNOE> IJNJJIFCDBB)
	{
		return default(AHPCDKCOAJM<PLHEEEFNBNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x234AA70", Offset = "0x2349E70", VA = "0x18234AA70")]
	public readonly EDADAJJFIOD<AHPCDKCOAJM<PLHEEEFNBNK>, LGLAINPBBEJ> HAIIIPJBBID(AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO)
	{
		return default(EDADAJJFIOD<AHPCDKCOAJM<PLHEEEFNBNK>, LGLAINPBBEJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x234BEA0", Offset = "0x234B2A0", VA = "0x18234BEA0")]
	public readonly LGLAINPBBEJ PDAMKPEKAKA(AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO)
	{
		return default(LGLAINPBBEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x234B580", Offset = "0x234A980", VA = "0x18234B580")]
	public readonly HEEJAAKOMGF<AHPCDKCOAJM<PLHEEEFNBNK>, OGHLOBLCDJI<AHPCDKCOAJM<PLHEEEFNBNK>>.EAJFADKHJJA> MCPDFOBMHHH(AHPCDKCOAJM<JGJEEGHFLFO> MLIAJGPJJLE)
	{
		return default(HEEJAAKOMGF<AHPCDKCOAJM<PLHEEEFNBNK>, OGHLOBLCDJI<AHPCDKCOAJM<PLHEEEFNBNK>>.EAJFADKHJJA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x234AB30", Offset = "0x2349F30", VA = "0x18234AB30")]
	public readonly OGHLOBLCDJI<AHPCDKCOAJM<PLHEEEFNBNK>>.EAJFADKHJJA HBHIFBBACDB(AHPCDKCOAJM<JGJEEGHFLFO> MLIAJGPJJLE)
	{
		return default(OGHLOBLCDJI<AHPCDKCOAJM<PLHEEEFNBNK>>.EAJFADKHJJA);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x234AEF0", Offset = "0x234A2F0", VA = "0x18234AEF0")]
	public readonly HEEJAAKOMGF<AHPCDKCOAJM<PLHEEEFNBNK>, OGHLOBLCDJI<AHPCDKCOAJM<PLHEEEFNBNK>>.EAJFADKHJJA> JJKBLHFMDKD(AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO)
	{
		return default(HEEJAAKOMGF<AHPCDKCOAJM<PLHEEEFNBNK>, OGHLOBLCDJI<AHPCDKCOAJM<PLHEEEFNBNK>>.EAJFADKHJJA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2349020", Offset = "0x2348420", VA = "0x182349020")]
	public readonly OGHLOBLCDJI<AHPCDKCOAJM<PLHEEEFNBNK>>.EAJFADKHJJA AFJNBIFLPIK(AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO)
	{
		return default(OGHLOBLCDJI<AHPCDKCOAJM<PLHEEEFNBNK>>.EAJFADKHJJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2349DB0", Offset = "0x23491B0", VA = "0x182349DB0")]
	public readonly EDADAJJFIOD<AHPCDKCOAJM<AMFCOJIMJGL>, PFKMJFMFGDK> EKBBOINNMJA(AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO)
	{
		return default(EDADAJJFIOD<AHPCDKCOAJM<AMFCOJIMJGL>, PFKMJFMFGDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2349F10", Offset = "0x2349310", VA = "0x182349F10")]
	public readonly PFKMJFMFGDK FAHGKKFLEJL(AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO)
	{
		return default(PFKMJFMFGDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x234B7B0", Offset = "0x234ABB0", VA = "0x18234B7B0")]
	public readonly EDADAJJFIOD<AHPCDKCOAJM<AMFCOJIMJGL>, GKOBKBKCCCO<AMFCOJIMJGL>.OHFLLBBHJAF> OAOJPGDPHHC()
	{
		return default(EDADAJJFIOD<AHPCDKCOAJM<AMFCOJIMJGL>, GKOBKBKCCCO<AMFCOJIMJGL>.OHFLLBBHJAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x234A1D0", Offset = "0x23495D0", VA = "0x18234A1D0")]
	public readonly GKOBKBKCCCO<AMFCOJIMJGL>.OHFLLBBHJAF GCDCEBOKAPJ()
	{
		return default(GKOBKBKCCCO<AMFCOJIMJGL>.OHFLLBBHJAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x234B270", Offset = "0x234A670", VA = "0x18234B270")]
	public readonly int KFCKNKFMFLD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x234ACE0", Offset = "0x234A0E0", VA = "0x18234ACE0")]
	public readonly int HNLMFFAOMDG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x234AD20", Offset = "0x234A120", VA = "0x18234AD20")]
	public readonly int IMPOFLKCFPH(AHPCDKCOAJM<JGJEEGHFLFO> MLIAJGPJJLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2349D30", Offset = "0x2349130", VA = "0x182349D30")]
	public readonly int ECNEOMOOLMK(AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x234B6E0", Offset = "0x234AAE0", VA = "0x18234B6E0")]
	public readonly int MPPKLMJDEBI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x234B400", Offset = "0x234A800", VA = "0x18234B400")]
	public readonly int LFAPHIIDGFM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2349CB0", Offset = "0x23490B0", VA = "0x182349CB0")]
	public readonly int ECBAOGENECL(AHPCDKCOAJM<PLHEEEFNBNK> AFJGGPEMBOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2349660", Offset = "0x2348A60", VA = "0x182349660")]
	public readonly int CJECCGLJOOC(AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x234BC30", Offset = "0x234B030", VA = "0x18234BC30")]
	public readonly AHPCDKCOAJM<JGJEEGHFLFO> OHAKEOBDIFG(AHPCDKCOAJM<PLHEEEFNBNK> AFJGGPEMBOM, int HCBBANBCILK)
	{
		return default(AHPCDKCOAJM<JGJEEGHFLFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x234B720", Offset = "0x234AB20", VA = "0x18234B720")]
	public readonly EDADAJJFIOD<AHPCDKCOAJM<NDHPMKFGFLB>, GBCKIPNOLOD<NDHPMKFGFLB>> NEOCKCOMIHM(AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO)
	{
		return default(EDADAJJFIOD<AHPCDKCOAJM<NDHPMKFGFLB>, GBCKIPNOLOD<NDHPMKFGFLB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2348FC0", Offset = "0x23483C0", VA = "0x182348FC0")]
	public readonly GBCKIPNOLOD<NDHPMKFGFLB> ADJNKFNHFON(AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO)
	{
		return default(GBCKIPNOLOD<NDHPMKFGFLB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2349780", Offset = "0x2348B80", VA = "0x182349780")]
	public readonly AHPCDKCOAJM<JGJEEGHFLFO> DDNNFAFIGGJ(AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO, AHPCDKCOAJM<NDHPMKFGFLB> HCBBANBCILK)
	{
		return default(AHPCDKCOAJM<JGJEEGHFLFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x234B820", Offset = "0x234AC20", VA = "0x18234B820")]
	public readonly HEEJAAKOMGF<AHPCDKCOAJM<JGJEEGHFLFO>, OGHLOBLCDJI<AHPCDKCOAJM<JGJEEGHFLFO>>.EAJFADKHJJA> OCMPDGMOIPH(AHPCDKCOAJM<PLHEEEFNBNK> AFJGGPEMBOM)
	{
		return default(HEEJAAKOMGF<AHPCDKCOAJM<JGJEEGHFLFO>, OGHLOBLCDJI<AHPCDKCOAJM<JGJEEGHFLFO>>.EAJFADKHJJA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2348F20", Offset = "0x2348320", VA = "0x182348F20")]
	public readonly OGHLOBLCDJI<AHPCDKCOAJM<JGJEEGHFLFO>>.EAJFADKHJJA AAOGGHEHCCO(AHPCDKCOAJM<PLHEEEFNBNK> AFJGGPEMBOM)
	{
		return default(OGHLOBLCDJI<AHPCDKCOAJM<JGJEEGHFLFO>>.EAJFADKHJJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2349190", Offset = "0x2348590", VA = "0x182349190")]
	public readonly OOEJHOICBAL AJOFMONOJLG(AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO)
	{
		return default(OOEJHOICBAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x234BCD0", Offset = "0x234B0D0", VA = "0x18234BCD0")]
	public readonly GKOBKBKCCCO<JGJEEGHFLFO>.OHFLLBBHJAF OMEBMDHCPPC()
	{
		return default(GKOBKBKCCCO<JGJEEGHFLFO>.OHFLLBBHJAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x234AE40", Offset = "0x234A240", VA = "0x18234AE40")]
	public readonly HEEJAAKOMGF<AHPCDKCOAJM<JGJEEGHFLFO>, OGHLOBLCDJI<AHPCDKCOAJM<JGJEEGHFLFO>>.EAJFADKHJJA> JHBNKJNBDFE(AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO)
	{
		return default(HEEJAAKOMGF<AHPCDKCOAJM<JGJEEGHFLFO>, OGHLOBLCDJI<AHPCDKCOAJM<JGJEEGHFLFO>>.EAJFADKHJJA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x234AFA0", Offset = "0x234A3A0", VA = "0x18234AFA0")]
	public readonly OGHLOBLCDJI<AHPCDKCOAJM<JGJEEGHFLFO>>.EAJFADKHJJA JKCFJKNEMCC(AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO)
	{
		return default(OGHLOBLCDJI<AHPCDKCOAJM<JGJEEGHFLFO>>.EAJFADKHJJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x23495E0", Offset = "0x23489E0", VA = "0x1823495E0")]
	public readonly AHPCDKCOAJM<AMFCOJIMJGL> BPBDAOECEDD(AHPCDKCOAJM<PLHEEEFNBNK> AFJGGPEMBOM)
	{
		return default(AHPCDKCOAJM<AMFCOJIMJGL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2349AE0", Offset = "0x2348EE0", VA = "0x182349AE0")]
	public readonly AHPCDKCOAJM<AMFCOJIMJGL> DNNAPNOHAND(AHPCDKCOAJM<JGJEEGHFLFO> MLIAJGPJJLE)
	{
		return default(AHPCDKCOAJM<AMFCOJIMJGL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x234B530", Offset = "0x234A930", VA = "0x18234B530")]
	public readonly bool LLJKFPDLCGB(AHPCDKCOAJM<PLHEEEFNBNK> AFJGGPEMBOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x234BDE0", Offset = "0x234B1E0", VA = "0x18234BDE0")]
	public AHPCDKCOAJM<PLHEEEFNBNK> PADCKPPPPHP(AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO, AHPCDKCOAJM<JIJMEHHKNOE> IJNJJIFCDBB)
	{
		return default(AHPCDKCOAJM<PLHEEEFNBNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x23490D0", Offset = "0x23484D0", VA = "0x1823490D0")]
	public AHPCDKCOAJM<JGJEEGHFLFO> AILNKCPIDKM(AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO, AHPCDKCOAJM<NDHPMKFGFLB> HCBBANBCILK)
	{
		return default(AHPCDKCOAJM<JGJEEGHFLFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x234A430", Offset = "0x2349830", VA = "0x18234A430")]
	public readonly bool GLDODDOKGKB(AHPCDKCOAJM<PLHEEEFNBNK> AFJGGPEMBOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2349C60", Offset = "0x2349060", VA = "0x182349C60")]
	public readonly bool DPFMNHIIECC(AHPCDKCOAJM<JGJEEGHFLFO> MLIAJGPJJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2349B60", Offset = "0x2348F60", VA = "0x182349B60")]
	public void DOHOJFNHMKK(AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO, AHPCDKCOAJM<JIJMEHHKNOE> BMJPHIGEGME, AHPCDKCOAJM<JIJMEHHKNOE> NICIHEEEFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x234A0D0", Offset = "0x23494D0", VA = "0x18234A0D0")]
	public void GBIAJDFLIIK(AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO, AHPCDKCOAJM<NDHPMKFGFLB> HJNEPBDLEBJ, AHPCDKCOAJM<NDHPMKFGFLB> FIPHMKMPAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x234A080", Offset = "0x2349480", VA = "0x18234A080")]
	public readonly bool FOJHBCEJNLN(AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2349820", Offset = "0x2348C20", VA = "0x182349820")]
	public readonly bool DFENBKFIAOL(AHPCDKCOAJM<JGJEEGHFLFO> MLIAJGPJJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x23494F0", Offset = "0x23488F0", VA = "0x1823494F0")]
	public void BGPLLPDNGCK(AHPCDKCOAJM<JGJEEGHFLFO> FOKGOFPCJND, AHPCDKCOAJM<PLHEEEFNBNK> ACPIEDANBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2349280", Offset = "0x2348680", VA = "0x182349280")]
	public void ALKOONJMHFL(AHPCDKCOAJM<PLHEEEFNBNK> AFJGGPEMBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x234A4B0", Offset = "0x23498B0", VA = "0x18234A4B0")]
	public void GPKJCNEAANI(AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2349870", Offset = "0x2348C70", VA = "0x182349870")]
	public void DNJICPEJHDM(AHPCDKCOAJM<JGJEEGHFLFO> MLIAJGPJJLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class CNFFMDJHHDB
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xA93730", Offset = "0xA92B30", VA = "0x180A93730")]
	public static GKOBKBKCCCO<PLHEEEFNBNK> ICIIEBFLPNB([In] this PHJEECMEBKI MPLBPEBNKFP)
	{
		return default(GKOBKBKCCCO<PLHEEEFNBNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2343D00", Offset = "0x2343100", VA = "0x182343D00")]
	public static GKOBKBKCCCO<JGJEEGHFLFO> MPFAEGIHIDM([In] this PHJEECMEBKI MPLBPEBNKFP)
	{
		return default(GKOBKBKCCCO<JGJEEGHFLFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2343CF0", Offset = "0x23430F0", VA = "0x182343CF0")]
	public static GKOBKBKCCCO<AMFCOJIMJGL> AGAPDLABFCE([In] this PHJEECMEBKI MPLBPEBNKFP)
	{
		return default(GKOBKBKCCCO<AMFCOJIMJGL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal struct OBCFGIHFNKH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public GKOBKBKCCCO<PLHEEEFNBNK> BFLLJJPFFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public BPONAHELEAL<PLHEEEFNBNK, AHPCDKCOAJM<AMFCOJIMJGL>> FIBFMIAABPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public BPONAHELEAL<PLHEEEFNBNK, OGHLOBLCDJI<AHPCDKCOAJM<JGJEEGHFLFO>>> PMJFPPCHOBC;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2344FB0", Offset = "0x23443B0", VA = "0x182344FB0")]
	public OBCFGIHFNKH([In] GKOBKBKCCCO<PLHEEEFNBNK> JGCCNBHNOIM, [In] BPONAHELEAL<PLHEEEFNBNK, AHPCDKCOAJM<AMFCOJIMJGL>> FPODBFBAGHC, [In] BPONAHELEAL<PLHEEEFNBNK, OGHLOBLCDJI<AHPCDKCOAJM<JGJEEGHFLFO>>> BOJIHAAGEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2346E50", Offset = "0x2346250", VA = "0x182346E50")]
	public static OBCFGIHFNKH ODOFIFAGLAJ()
	{
		return default(OBCFGIHFNKH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2346940", Offset = "0x2345D40", VA = "0x182346940", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2346BA0", Offset = "0x2345FA0", VA = "0x182346BA0")]
	public readonly MHHJEPAOHID GKPJGNLGAKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2346AE0", Offset = "0x2345EE0", VA = "0x182346AE0")]
	public AHPCDKCOAJM<PLHEEEFNBNK> FCPJHHJJNCF(AHPCDKCOAJM<AMFCOJIMJGL> AJLPJFOPFCG)
	{
		return default(AHPCDKCOAJM<PLHEEEFNBNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2346F30", Offset = "0x2346330", VA = "0x182346F30")]
	public void OLENLPMJDLF(AHPCDKCOAJM<PLHEEEFNBNK> LPMIIFILJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2347010", Offset = "0x2346410", VA = "0x182347010")]
	[CompilerGenerated]
	internal static DBDLPFAPPHA PDFOMODKDJJ([In] OGHLOBLCDJI<AHPCDKCOAJM<JGJEEGHFLFO>> MPLBPEBNKFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct LGLAINPBBEJ : IEnumerator<AHPCDKCOAJM<PLHEEEFNBNK>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private OGHLOBLCDJI<AHPCDKCOAJM<JGJEEGHFLFO>>.EAJFADKHJJA GKNDCDGJLHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private OGHLOBLCDJI<AHPCDKCOAJM<PLHEEEFNBNK>>.EAJFADKHJJA DDEFCKIHAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly BPONAHELEAL<JGJEEGHFLFO, OGHLOBLCDJI<AHPCDKCOAJM<PLHEEEFNBNK>>> OOIAOOLLING;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public AHPCDKCOAJM<PLHEEEFNBNK> DLFFLJHEEDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2346880", Offset = "0x2345C80", VA = "0x182346880", Slot = "4")]
		get
		{
			return default(AHPCDKCOAJM<PLHEEEFNBNK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x23467B0", Offset = "0x2345BB0", VA = "0x1823467B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2346820", Offset = "0x2345C20", VA = "0x182346820")]
	internal LGLAINPBBEJ([In] OGHLOBLCDJI<AHPCDKCOAJM<JGJEEGHFLFO>>.EAJFADKHJJA OGFDINOBNFL, [In] OGHLOBLCDJI<AHPCDKCOAJM<PLHEEEFNBNK>>.EAJFADKHJJA ADCNAFEEMPJ, [In] BPONAHELEAL<JGJEEGHFLFO, OGHLOBLCDJI<AHPCDKCOAJM<PLHEEEFNBNK>>> AOKMFOOEJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2346610", Offset = "0x2345A10", VA = "0x182346610", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2346750", Offset = "0x2345B50", VA = "0x182346750", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x23465B0", Offset = "0x23459B0", VA = "0x1823465B0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal struct EJNOEFONOMP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public GKOBKBKCCCO<AMFCOJIMJGL> BFLLJJPFFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public BPONAHELEAL<AMFCOJIMJGL, OGHLOBLCDJI<AHPCDKCOAJM<PLHEEEFNBNK>>> PMDOJENPBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public BPONAHELEAL<AMFCOJIMJGL, OGHLOBLCDJI<AHPCDKCOAJM<JGJEEGHFLFO>>> PMJFPPCHOBC;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2344FB0", Offset = "0x23443B0", VA = "0x182344FB0")]
	public EJNOEFONOMP([In] GKOBKBKCCCO<AMFCOJIMJGL> JGCCNBHNOIM, [In] BPONAHELEAL<AMFCOJIMJGL, OGHLOBLCDJI<AHPCDKCOAJM<PLHEEEFNBNK>>> POJBCHAHLFG, [In] BPONAHELEAL<AMFCOJIMJGL, OGHLOBLCDJI<AHPCDKCOAJM<JGJEEGHFLFO>>> BOJIHAAGEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2344D90", Offset = "0x2344190", VA = "0x182344D90")]
	public static EJNOEFONOMP ODOFIFAGLAJ()
	{
		return default(EJNOEFONOMP);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x23445D0", Offset = "0x23439D0", VA = "0x1823445D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2344950", Offset = "0x2343D50", VA = "0x182344950")]
	public readonly BBDBMOHAGIH GKPJGNLGAKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x23448A0", Offset = "0x2343CA0", VA = "0x1823448A0")]
	public AHPCDKCOAJM<AMFCOJIMJGL> FCPJHHJJNCF([In] OGHLOBLCDJI<AHPCDKCOAJM<PLHEEEFNBNK>> POJBCHAHLFG, [In] OGHLOBLCDJI<AHPCDKCOAJM<JGJEEGHFLFO>> BOJIHAAGEDD)
	{
		return default(AHPCDKCOAJM<AMFCOJIMJGL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2344E70", Offset = "0x2344270", VA = "0x182344E70")]
	public void OLENLPMJDLF(AHPCDKCOAJM<AMFCOJIMJGL> LPMIIFILJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2344C30", Offset = "0x2344030", VA = "0x182344C30")]
	[CompilerGenerated]
	internal static KGBINBMPMMK GMNBKBFNPPF([In] OGHLOBLCDJI<AHPCDKCOAJM<PLHEEEFNBNK>> MPLBPEBNKFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2344470", Offset = "0x2343870", VA = "0x182344470")]
	[CompilerGenerated]
	internal static GCGPGMMOCHA DNLDNEADJDF([In] OGHLOBLCDJI<AHPCDKCOAJM<JGJEEGHFLFO>> MPLBPEBNKFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct PFKMJFMFGDK : IEnumerator<AHPCDKCOAJM<AMFCOJIMJGL>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private LGLAINPBBEJ INKMLLIHPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly BPONAHELEAL<PLHEEEFNBNK, AHPCDKCOAJM<AMFCOJIMJGL>> FGGMFLLBKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private OOEJHOICBAL BHJPEMIFIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly BPONAHELEAL<JGJEEGHFLFO, AHPCDKCOAJM<AMFCOJIMJGL>> IPNBDFIJEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private bool MJMGCJEKHPD;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public readonly AHPCDKCOAJM<AMFCOJIMJGL> DLFFLJHEEDE
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2348DB0", Offset = "0x23481B0", VA = "0x182348DB0", Slot = "4")]
		get
		{
			return default(AHPCDKCOAJM<AMFCOJIMJGL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2348CB0", Offset = "0x23480B0", VA = "0x182348CB0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2348D00", Offset = "0x2348100", VA = "0x182348D00")]
	internal PFKMJFMFGDK([In] LGLAINPBBEJ FMFIPDOMFHL, [In] BPONAHELEAL<PLHEEEFNBNK, AHPCDKCOAJM<AMFCOJIMJGL>> GLIKHOMFCAF, [In] OOEJHOICBAL MGIGMBIJAPG, [In] BPONAHELEAL<JGJEEGHFLFO, AHPCDKCOAJM<AMFCOJIMJGL>> OJIJBKFFPED, bool KJIMHIEDCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2348BB0", Offset = "0x2347FB0", VA = "0x182348BB0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2348C00", Offset = "0x2348000", VA = "0x182348C00", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2348B10", Offset = "0x2347F10", VA = "0x182348B10", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal struct FLKKEPNAJBA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public GKOBKBKCCCO<JGJEEGHFLFO> BFLLJJPFFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public BPONAHELEAL<JGJEEGHFLFO, AHPCDKCOAJM<AMFCOJIMJGL>> FIBFMIAABPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public BPONAHELEAL<JGJEEGHFLFO, OGHLOBLCDJI<AHPCDKCOAJM<PLHEEEFNBNK>>> PMDOJENPBOB;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2344FB0", Offset = "0x23443B0", VA = "0x182344FB0")]
	public FLKKEPNAJBA([In] GKOBKBKCCCO<JGJEEGHFLFO> JGCCNBHNOIM, [In] BPONAHELEAL<JGJEEGHFLFO, AHPCDKCOAJM<AMFCOJIMJGL>> FPODBFBAGHC, [In] BPONAHELEAL<JGJEEGHFLFO, OGHLOBLCDJI<AHPCDKCOAJM<PLHEEEFNBNK>>> POJBCHAHLFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2345A40", Offset = "0x2344E40", VA = "0x182345A40")]
	public static FLKKEPNAJBA ODOFIFAGLAJ()
	{
		return default(FLKKEPNAJBA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x23453D0", Offset = "0x23447D0", VA = "0x1823453D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2345630", Offset = "0x2344A30", VA = "0x182345630")]
	public readonly FBNCPCECBKO GKPJGNLGAKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2345570", Offset = "0x2344970", VA = "0x182345570")]
	public AHPCDKCOAJM<JGJEEGHFLFO> FCPJHHJJNCF(AHPCDKCOAJM<AMFCOJIMJGL> AJLPJFOPFCG)
	{
		return default(AHPCDKCOAJM<JGJEEGHFLFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2345B20", Offset = "0x2344F20", VA = "0x182345B20")]
	public void OLENLPMJDLF(AHPCDKCOAJM<JGJEEGHFLFO> LPMIIFILJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x23458E0", Offset = "0x2344CE0", VA = "0x1823458E0")]
	[CompilerGenerated]
	internal static NLGEDPKAOBG IBIJDALAOCH([In] OGHLOBLCDJI<AHPCDKCOAJM<PLHEEEFNBNK>> MPLBPEBNKFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct OOEJHOICBAL : IEnumerator<AHPCDKCOAJM<JGJEEGHFLFO>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private OGHLOBLCDJI<AHPCDKCOAJM<PLHEEEFNBNK>>.EAJFADKHJJA BFAJLBBNDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private OGHLOBLCDJI<AHPCDKCOAJM<JGJEEGHFLFO>>.EAJFADKHJJA NOBLMHCMBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly BPONAHELEAL<PLHEEEFNBNK, OGHLOBLCDJI<AHPCDKCOAJM<JGJEEGHFLFO>>> HKIEELMPLFH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AHPCDKCOAJM<JGJEEGHFLFO> DLFFLJHEEDE
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x23473E0", Offset = "0x23467E0", VA = "0x1823473E0", Slot = "4")]
		get
		{
			return default(AHPCDKCOAJM<JGJEEGHFLFO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2347370", Offset = "0x2346770", VA = "0x182347370", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2346820", Offset = "0x2345C20", VA = "0x182346820")]
	internal OOEJHOICBAL([In] OGHLOBLCDJI<AHPCDKCOAJM<PLHEEEFNBNK>>.EAJFADKHJJA MKLKLCEJIHE, [In] OGHLOBLCDJI<AHPCDKCOAJM<JGJEEGHFLFO>>.EAJFADKHJJA BLOLHAMDBGH, [In] BPONAHELEAL<PLHEEEFNBNK, OGHLOBLCDJI<AHPCDKCOAJM<JGJEEGHFLFO>>> CDABGLAMMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x23471D0", Offset = "0x23465D0", VA = "0x1823471D0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2347310", Offset = "0x2346710", VA = "0x182347310", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2347170", Offset = "0x2346570", VA = "0x182347170", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal static class JENFLDLLCOH
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2345E10", Offset = "0x2345210", VA = "0x182345E10")]
	public static EJNOEFONOMP KBLFJIABLOP(this BBDBMOHAGIH MPLBPEBNKFP)
	{
		return default(EJNOEFONOMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2346290", Offset = "0x2345690", VA = "0x182346290")]
	public static void OLENLPMJDLF(this BBDBMOHAGIH MPLBPEBNKFP, int LPMIIFILJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2345C00", Offset = "0x2345000", VA = "0x182345C00")]
	[CompilerGenerated]
	internal static OGHLOBLCDJI<AHPCDKCOAJM<PLHEEEFNBNK>> CEPDDHHGBAP(KGBINBMPMMK MPLBPEBNKFP)
	{
		return default(OGHLOBLCDJI<AHPCDKCOAJM<PLHEEEFNBNK>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x23463A0", Offset = "0x23457A0", VA = "0x1823463A0")]
	[CompilerGenerated]
	internal static OGHLOBLCDJI<AHPCDKCOAJM<JGJEEGHFLFO>> PKEGBBGEMLI(GCGPGMMOCHA MPLBPEBNKFP)
	{
		return default(OGHLOBLCDJI<AHPCDKCOAJM<JGJEEGHFLFO>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class OPLKMBBIOEO
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2348470", Offset = "0x2347870", VA = "0x182348470")]
	public static PHJEECMEBKI KBLFJIABLOP(this HLPMBGNBJKE MPLBPEBNKFP)
	{
		return default(PHJEECMEBKI);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2348A60", Offset = "0x2347E60", VA = "0x182348A60")]
	public static AHPCDKCOAJM<PLHEEEFNBNK> PEGBENAFHKB(this HLPMBGNBJKE MPLBPEBNKFP, AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO, AHPCDKCOAJM<JIJMEHHKNOE> IJNJJIFCDBB)
	{
		return default(AHPCDKCOAJM<PLHEEEFNBNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2348860", Offset = "0x2347C60", VA = "0x182348860")]
	public static EDADAJJFIOD<AHPCDKCOAJM<PLHEEEFNBNK>, JIPCFAGBAPG<PLHEEEFNBNK>.GFFANPDJONH> MCPDFOBMHHH(this HLPMBGNBJKE MPLBPEBNKFP, AHPCDKCOAJM<JGJEEGHFLFO> MLIAJGPJJLE)
	{
		return default(EDADAJJFIOD<AHPCDKCOAJM<PLHEEEFNBNK>, JIPCFAGBAPG<PLHEEEFNBNK>.GFFANPDJONH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2348400", Offset = "0x2347800", VA = "0x182348400")]
	public static IEnumerable<int> JJKBLHFMDKD(this HLPMBGNBJKE MPLBPEBNKFP, int DOKBOJKBDAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2347BF0", Offset = "0x2346FF0", VA = "0x182347BF0")]
	public static int ECNEOMOOLMK(this HLPMBGNBJKE MPLBPEBNKFP, AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2347770", Offset = "0x2346B70", VA = "0x182347770")]
	public static int CJECCGLJOOC(this HLPMBGNBJKE MPLBPEBNKFP, AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x23477F0", Offset = "0x2346BF0", VA = "0x1823477F0")]
	public static AHPCDKCOAJM<JGJEEGHFLFO> DDNNFAFIGGJ(this HLPMBGNBJKE MPLBPEBNKFP, AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO, AHPCDKCOAJM<NDHPMKFGFLB> HCBBANBCILK)
	{
		return default(AHPCDKCOAJM<JGJEEGHFLFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2348960", Offset = "0x2347D60", VA = "0x182348960")]
	public static EDADAJJFIOD<AHPCDKCOAJM<JGJEEGHFLFO>, JIPCFAGBAPG<JGJEEGHFLFO>.GFFANPDJONH> OCMPDGMOIPH(this HLPMBGNBJKE MPLBPEBNKFP, AHPCDKCOAJM<PLHEEEFNBNK> AFJGGPEMBOM)
	{
		return default(EDADAJJFIOD<AHPCDKCOAJM<JGJEEGHFLFO>, JIPCFAGBAPG<JGJEEGHFLFO>.GFFANPDJONH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2348390", Offset = "0x2347790", VA = "0x182348390")]
	public static IEnumerable<int> JHBNKJNBDFE(this HLPMBGNBJKE MPLBPEBNKFP, int DOKBOJKBDAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2347700", Offset = "0x2346B00", VA = "0x182347700")]
	public static AHPCDKCOAJM<AMFCOJIMJGL> BPBDAOECEDD(this HLPMBGNBJKE MPLBPEBNKFP, AHPCDKCOAJM<PLHEEEFNBNK> AFJGGPEMBOM)
	{
		return default(AHPCDKCOAJM<AMFCOJIMJGL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2347B80", Offset = "0x2346F80", VA = "0x182347B80")]
	public static AHPCDKCOAJM<AMFCOJIMJGL> DNNAPNOHAND(this HLPMBGNBJKE MPLBPEBNKFP, AHPCDKCOAJM<JGJEEGHFLFO> MLIAJGPJJLE)
	{
		return default(AHPCDKCOAJM<AMFCOJIMJGL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2347420", Offset = "0x2346820", VA = "0x182347420")]
	public static void ALKOONJMHFL(this HLPMBGNBJKE MPLBPEBNKFP, AHPCDKCOAJM<PLHEEEFNBNK> AFJGGPEMBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2347C70", Offset = "0x2347070", VA = "0x182347C70")]
	public static void GPKJCNEAANI(this HLPMBGNBJKE MPLBPEBNKFP, int DOKBOJKBDAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x23478A0", Offset = "0x2346CA0", VA = "0x1823478A0")]
	public static void DNJICPEJHDM(this HLPMBGNBJKE MPLBPEBNKFP, AHPCDKCOAJM<JGJEEGHFLFO> MLIAJGPJJLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal static class PIJAEAHCDEK
{
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x234C320", Offset = "0x234B720", VA = "0x18234C320")]
	public static OBCFGIHFNKH KBLFJIABLOP(this MHHJEPAOHID MPLBPEBNKFP)
	{
		return default(OBCFGIHFNKH);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x234C7A0", Offset = "0x234BBA0", VA = "0x18234C7A0")]
	public static void OLENLPMJDLF(this MHHJEPAOHID MPLBPEBNKFP, int LPMIIFILJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x234C110", Offset = "0x234B510", VA = "0x18234C110")]
	[CompilerGenerated]
	internal static OGHLOBLCDJI<AHPCDKCOAJM<JGJEEGHFLFO>> EIOPJJIGICG(DBDLPFAPPHA MPLBPEBNKFP)
	{
		return default(OGHLOBLCDJI<AHPCDKCOAJM<JGJEEGHFLFO>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal static class DLAJLFCJJPA
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2343F20", Offset = "0x2343320", VA = "0x182343F20")]
	public static FLKKEPNAJBA KBLFJIABLOP(this FBNCPCECBKO MPLBPEBNKFP)
	{
		return default(FLKKEPNAJBA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x23443A0", Offset = "0x23437A0", VA = "0x1823443A0")]
	public static void OLENLPMJDLF(this FBNCPCECBKO MPLBPEBNKFP, int LPMIIFILJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2343D10", Offset = "0x2343110", VA = "0x182343D10")]
	[CompilerGenerated]
	internal static OGHLOBLCDJI<AHPCDKCOAJM<PLHEEEFNBNK>> HPELPHHBCKC(NLGEDPKAOBG MPLBPEBNKFP)
	{
		return default(OGHLOBLCDJI<AHPCDKCOAJM<PLHEEEFNBNK>>);
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
