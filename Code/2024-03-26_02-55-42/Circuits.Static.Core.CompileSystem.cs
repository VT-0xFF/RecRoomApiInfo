using System;
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
		[Cpp2IlInjected.Address(RVA = "0x7E7D80", Offset = "0x7E7180", VA = "0x1807E7D80")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1DF1700", Offset = "0x1DF0B00", VA = "0x181DF1700")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E8560", Offset = "0x7E7960", VA = "0x1807E8560")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7E85A0", Offset = "0x7E79A0", VA = "0x1807E85A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct LFKNGIPMNFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>> ADDJLCBFBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int JDFFMJCEGAJ;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xAEAF20", Offset = "0xAEA320", VA = "0x180AEAF20")]
	public LFKNGIPMNFG(CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>> CHDKCFAGHGM, int PADMGOMCMCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct POOHGCEHMHB
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class JPLMOHPFBDJ : BLOAFAIACGF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct KKNGJFLCNBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly LMHOHLCAMLC<byte> GHMPACENOJC;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1DA9180", Offset = "0x1DA8580", VA = "0x181DA9180")]
		public KKNGJFLCNBO(LMHOHLCAMLC<byte> GHDDMAGGOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1DEBE40", Offset = "0x1DEB240", VA = "0x181DEBE40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class KMHDAKNAHHE : BLOAFAIACGF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct LHGECNOMPFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>> HOJNPIPBBAJ;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x919AC0", Offset = "0x918EC0", VA = "0x180919AC0")]
		public LHGECNOMPFG(CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>> FIBAGJBIOJI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum OELCPIONCEH
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		BytesImmediate,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		DeadEnd,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		Variable,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		X32Immediate
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class MLDCPHHACKO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class BLOAFAIACGF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct PPPOHLEIPNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly OELCPIONCEH MCCIAOABKEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly CEECNPFCENP<BLOAFAIACGF> HNOOLGJOBNJ;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAEAF20", Offset = "0xAEA320", VA = "0x180AEAF20")]
		public PPPOHLEIPNB(OELCPIONCEH MEOGECGECNG, CEECNPFCENP<BLOAFAIACGF> PNCPDELJLJB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class NAGDHCCBEGA : BLOAFAIACGF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct GEAMDGLIKEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> KNBONEKIDOL;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x919AC0", Offset = "0x918EC0", VA = "0x180919AC0")]
		public GEAMDGLIKEC(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> CAKILKPBKEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class GBMPJMBFDLH : BLOAFAIACGF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct OFLDACMPOEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly FPDIDCFFANP DHGCFGNBPJK;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x919AC0", Offset = "0x918EC0", VA = "0x180919AC0")]
		public OFLDACMPOEO(FPDIDCFFANP AILCFNHMKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1DF1810", Offset = "0x1DF0C10", VA = "0x181DF1810", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal KLCOKDEFDEP<MLDCPHHACKO, PPPOHLEIPNB> MKLGJPJHMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal KLCOKDEFDEP<JPLMOHPFBDJ, KKNGJFLCNBO> EKKPOMNPNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal KLCOKDEFDEP<KMHDAKNAHHE, LHGECNOMPFG> MBECKMFJGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal KLCOKDEFDEP<NAGDHCCBEGA, GEAMDGLIKEC> BGPPBEBBPIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal KLCOKDEFDEP<GBMPJMBFDLH, OFLDACMPOEO> FMMJBOIPOCO;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1DF1A00", Offset = "0x1DF0E00", VA = "0x181DF1A00")]
	private POOHGCEHMHB([In] KLCOKDEFDEP<MLDCPHHACKO, PPPOHLEIPNB> FMGNOEKBHLB, [In] KLCOKDEFDEP<JPLMOHPFBDJ, KKNGJFLCNBO> OEEMJCIHNMJ, [In] KLCOKDEFDEP<KMHDAKNAHHE, LHGECNOMPFG> ABDPEFCEDEG, [In] KLCOKDEFDEP<NAGDHCCBEGA, GEAMDGLIKEC> KDFPMMDAAEP, [In] KLCOKDEFDEP<GBMPJMBFDLH, OFLDACMPOEO> BBMMMPKPCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1DF18C0", Offset = "0x1DF0CC0", VA = "0x181DF18C0")]
	public static POOHGCEHMHB HGJFOBLHCKL()
	{
		return default(POOHGCEHMHB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class JHIDINPGHIK
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1DE9AA0", Offset = "0x1DE8EA0", VA = "0x181DE9AA0")]
	public static void FHLEEDLMEFH(this POOHGCEHMHB MEEBIDIALDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum NAPHBBPFBED
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Bool,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Int,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Bytes,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Class
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct EKPLFECBDOC
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class PEMDGOFFBPN : IANAPNKLHOM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct FMGDGBLFDJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> PBPMJKBGLEK;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x919AC0", Offset = "0x918EC0", VA = "0x180919AC0")]
		public FMGDGBLFDJJ(CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> NMMFGFAJBDB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum DKLLNODMIHN
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Branch,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		DeadEnd,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		DeadEndData,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		NodeAlreadyVisited,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		NodeCantVisit,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		OutNode
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class BHPDJPACCLE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class IANAPNKLHOM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct ACMGCIIPGFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly DKLLNODMIHN MCCIAOABKEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly CEECNPFCENP<IANAPNKLHOM> HNOOLGJOBNJ;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xAEAF20", Offset = "0xAEA320", VA = "0x180AEAF20")]
		public ACMGCIIPGFG(DKLLNODMIHN MEOGECGECNG, CEECNPFCENP<IANAPNKLHOM> PNCPDELJLJB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal KLCOKDEFDEP<BHPDJPACCLE, ACMGCIIPGFG> MKLGJPJHMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal KLCOKDEFDEP<PEMDGOFFBPN, FMGDGBLFDJJ> IJAMCOLDHON;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1DE7E50", Offset = "0x1DE7250", VA = "0x181DE7E50")]
	private EKPLFECBDOC([In] KLCOKDEFDEP<BHPDJPACCLE, ACMGCIIPGFG> FMGNOEKBHLB, [In] KLCOKDEFDEP<PEMDGOFFBPN, FMGDGBLFDJJ> HLIDNINIALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1DE7DC0", Offset = "0x1DE71C0", VA = "0x181DE7DC0")]
	public static EKPLFECBDOC HGJFOBLHCKL()
	{
		return default(EKPLFECBDOC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class MNFFCILKKNF
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1DEBF50", Offset = "0x1DEB350", VA = "0x181DEBF50")]
	public static void FHLEEDLMEFH(this EKPLFECBDOC MEEBIDIALDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct EGAODOHLKID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public OONLFEIMAID<int> BIEPCGCDJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public OONLFEIMAID<int> HEDOEOMDCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int GMNIJHDFCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int NHDILFMJFJF;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1DE7D50", Offset = "0x1DE7150", VA = "0x181DE7D50")]
	private EGAODOHLKID([In] OONLFEIMAID<int> JGLFGJJLIKJ, [In] OONLFEIMAID<int> DIBBMLPHIOG, int AEMNBOMOOEE, int AGFHBMFLGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1DE7CB0", Offset = "0x1DE70B0", VA = "0x181DE7CB0")]
	public static EGAODOHLKID HGJFOBLHCKL()
	{
		return default(EGAODOHLKID);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class GEDLMJNDMHM
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1DE8490", Offset = "0x1DE7890", VA = "0x181DE8490")]
	public static void FHLEEDLMEFH(this EGAODOHLKID MEEBIDIALDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct EEJHDAKPMBH
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum JLCNKAJOLFK
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class CBMPKOHPDNM : NPLLGJFEOON
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct APENJMELACP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly CEECNPFCENP<AIACDIENCOD> FJGIFEJLFLA;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x919AC0", Offset = "0x918EC0", VA = "0x180919AC0")]
		public APENJMELACP(CEECNPFCENP<AIACDIENCOD> CBOJFMNLLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class OMBIMIGMEJF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class NPLLGJFEOON
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct PCFDGKABDML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly JLCNKAJOLFK MCCIAOABKEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly CEECNPFCENP<NPLLGJFEOON> HNOOLGJOBNJ;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAEAF20", Offset = "0xAEA320", VA = "0x180AEAF20")]
		private PCFDGKABDML(JLCNKAJOLFK MEOGECGECNG, CEECNPFCENP<NPLLGJFEOON> PNCPDELJLJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1DF18B0", Offset = "0x1DF0CB0", VA = "0x181DF18B0")]
		public static PCFDGKABDML HGJFOBLHCKL(JLCNKAJOLFK MEOGECGECNG, CEECNPFCENP<NPLLGJFEOON> PNCPDELJLJB)
		{
			return default(PCFDGKABDML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class MMBNGACNGBH : NPLLGJFEOON
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct PPCJFGMGKOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly CEECNPFCENP<AIACDIENCOD> FJGIFEJLFLA;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x919AC0", Offset = "0x918EC0", VA = "0x180919AC0")]
		public PPCJFGMGKOP(CEECNPFCENP<AIACDIENCOD> CBOJFMNLLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class AIACDIENCOD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct OHOMJKINEMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public OONLFEIMAID<CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>> ADLKOBFLKIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public OONLFEIMAID<CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>> INPPNHGNCMP;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1DE7E50", Offset = "0x1DE7250", VA = "0x181DE7E50")]
		private OHOMJKINEMN([In] OONLFEIMAID<CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>> BOEGHICBNGK, [In] OONLFEIMAID<CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>> AFHJLGMCCPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1DF1830", Offset = "0x1DF0C30", VA = "0x181DF1830")]
		public static OHOMJKINEMN HGJFOBLHCKL()
		{
			return default(OHOMJKINEMN);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal KLCOKDEFDEP<OMBIMIGMEJF, PCFDGKABDML> MKLGJPJHMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal KLCOKDEFDEP<MMBNGACNGBH, PPCJFGMGKOP> DDDFJEMFKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal KLCOKDEFDEP<CBMPKOHPDNM, APENJMELACP> CAMKDEOOJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal OONLFEIMAID<(CEECNPFCENP<OMBIMIGMEJF> CallId, CEECNPFCENP<AIACDIENCOD> IOId)> KAGNJDMPPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal KLCOKDEFDEP<AIACDIENCOD, OHOMJKINEMN> PPGDAOJJPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal HMEBJJCHPDI<AIACDIENCOD, CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>> NOLKDHBOLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal HMEBJJCHPDI<AIACDIENCOD, CEECNPFCENP<GPLICHFNGAN<DAIMPPKEFEB>>> MGJGLGPEDCD;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1DE7BF0", Offset = "0x1DE6FF0", VA = "0x181DE7BF0")]
	private EEJHDAKPMBH([In] KLCOKDEFDEP<OMBIMIGMEJF, PCFDGKABDML> FMGNOEKBHLB, [In] KLCOKDEFDEP<MMBNGACNGBH, PPCJFGMGKOP> DHEIOEFBNMD, [In] KLCOKDEFDEP<CBMPKOHPDNM, APENJMELACP> JEPJFGKBLBE, [In] OONLFEIMAID<(CEECNPFCENP<OMBIMIGMEJF> CallId, CEECNPFCENP<AIACDIENCOD> IOId)> IGOBMCPMGAK, [In] KLCOKDEFDEP<AIACDIENCOD, OHOMJKINEMN> DLLPGHACHOM, [In] HMEBJJCHPDI<AIACDIENCOD, CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>> BFMDDJCIECD, [In] HMEBJJCHPDI<AIACDIENCOD, CEECNPFCENP<GPLICHFNGAN<DAIMPPKEFEB>>> AFCMPFELNAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1DE7A50", Offset = "0x1DE6E50", VA = "0x181DE7A50")]
	public static EEJHDAKPMBH HGJFOBLHCKL()
	{
		return default(EEJHDAKPMBH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class BFIPHOFKAOD
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1DE7250", Offset = "0x1DE6650", VA = "0x181DE7250")]
	private static void FHLEEDLMEFH(this EEJHDAKPMBH.OHOMJKINEMN MEEBIDIALDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1DE7040", Offset = "0x1DE6440", VA = "0x181DE7040")]
	public static void FHLEEDLMEFH(this EEJHDAKPMBH MEEBIDIALDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct GIOLGACMMAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public OONLFEIMAID<byte> JDPFCPMADKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal EEJHDAKPMBH BGNLBHFIDPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal IMNGEGPBJMM IHCFGAPAIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>> CIAPAILFIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal POOHGCEHMHB JCFCNABHCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal EKPLFECBDOC BMAPOGJPKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal HMEBJJCHPDI<IHPFKLFEHJK, CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO>?> JFNOBPACEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal OONLFEIMAID<CEECNPFCENP<IHPFKLFEHJK>> MKCOJLJFKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal HMEBJJCHPDI<OHCJECBGAHH, CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>?> MIFFMAENDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal OONLFEIMAID<(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> VariableId, CEECNPFCENP<GPLICHFNGAN<EDLGCINFKIM<COGFAOPINMA>>> ByteCodeWriteLocation)> MLFOCIBDLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal OONLFEIMAID<(CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>> Target, CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>> ByteCodeWriteLocation)> DBOMFJAKMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal DPIHGHODABF GPODPAJCKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal NJDLIHONJEL OBDJNMHDJGL;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1DE8FA0", Offset = "0x1DE83A0", VA = "0x181DE8FA0")]
	private GIOLGACMMAA([In] OONLFEIMAID<byte> JIEKKNLIPGI, [In] EEJHDAKPMBH APPPKCFCBMB, [In] IMNGEGPBJMM ADCLHNIFOBF, [In] POOHGCEHMHB LPLJBNLLKBM, [In] EKPLFECBDOC KLKKCHKNENB, [In] HMEBJJCHPDI<IHPFKLFEHJK, CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO>?> LNHMJJGJPGA, [In] OONLFEIMAID<CEECNPFCENP<IHPFKLFEHJK>> BKKABDKLONC, [In] HMEBJJCHPDI<OHCJECBGAHH, CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>?> EJLMPCGJAJC, [In] OONLFEIMAID<(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> VariableId, CEECNPFCENP<GPLICHFNGAN<EDLGCINFKIM<COGFAOPINMA>>> ByteCodeWriteLocation)> FJDBPKDNDIF, [In] OONLFEIMAID<(CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>> Target, CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>> ByteCodeWriteLocation)> HDLCCBNOMBJ, [In] DPIHGHODABF JDOENFLOPEB, [In] NJDLIHONJEL GIDJALLFOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1DE84E0", Offset = "0x1DE78E0", VA = "0x181DE84E0")]
	public static GIOLGACMMAA HGJFOBLHCKL()
	{
		return default(GIOLGACMMAA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class KJEIPHGNJIJ
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct CDEKMPGBPMG : LODFJPMFNBF<CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD>, HMEBJJCHPDI<EEJHDAKPMBH.AIACDIENCOD, CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1DE74D0", Offset = "0x1DE68D0", VA = "0x181DE74D0")]
		public CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>> JMIHOLOKADE(CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD> PMLKPJNGBAD, [In] HMEBJJCHPDI<EEJHDAKPMBH.AIACDIENCOD, CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>> JFCBPFNIMNJ)
		{
			return default(CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1DE74A0", Offset = "0x1DE68A0", VA = "0x181DE74A0", Slot = "4")]
		public CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD> EIDGOCEHHFK(int PMLKPJNGBAD)
		{
			return default(CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A80", Offset = "0x7D7E80", VA = "0x1807D8A80")]
		public bool JDKNGNHNPOJ(CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD> PMLKPJNGBAD, [In] HMEBJJCHPDI<EEJHDAKPMBH.AIACDIENCOD, CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>> JFCBPFNIMNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A80", Offset = "0x7D7E80", VA = "0x1807D8A80", Slot = "5")]
		private bool BKCGHHELKKM(CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD> PMLKPJNGBAD, [In] HMEBJJCHPDI<EEJHDAKPMBH.AIACDIENCOD, CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>> JFCBPFNIMNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1DE74D0", Offset = "0x1DE68D0", VA = "0x181DE74D0", Slot = "6")]
		private CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>> FILPHAHBJNP(CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD> PMLKPJNGBAD, [In] HMEBJJCHPDI<EEJHDAKPMBH.AIACDIENCOD, CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>> JFCBPFNIMNJ)
		{
			return default(CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct BHDNJONEHOP : FANNNGGJAFG<CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD>, HMEBJJCHPDI<EEJHDAKPMBH.AIACDIENCOD, CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1DE72A0", Offset = "0x1DE66A0", VA = "0x181DE72A0")]
		public OONLFEIMAID<CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD>> EMONFMKIPBM(int AOMBMAHFCEG, [In] HMEBJJCHPDI<EEJHDAKPMBH.AIACDIENCOD, CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>> JFCBPFNIMNJ)
		{
			return default(OONLFEIMAID<CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1DE7310", Offset = "0x1DE6710", VA = "0x181DE7310")]
		public CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>> JMIHOLOKADE(CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD> PMLKPJNGBAD, [In] HMEBJJCHPDI<EEJHDAKPMBH.AIACDIENCOD, CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>> JFCBPFNIMNJ)
		{
			return default(CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1DE7390", Offset = "0x1DE6790", VA = "0x181DE7390", Slot = "6")]
		public void KAOPFFOGNAE(CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD> PMLKPJNGBAD, HMEBJJCHPDI<EEJHDAKPMBH.AIACDIENCOD, CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>> JFCBPFNIMNJ, CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>> PCGOHCLJAPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1DE72A0", Offset = "0x1DE66A0", VA = "0x181DE72A0", Slot = "4")]
		private OONLFEIMAID<CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD>> PCMNLJMMCIF(int AOMBMAHFCEG, [In] HMEBJJCHPDI<EEJHDAKPMBH.AIACDIENCOD, CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>> JFCBPFNIMNJ)
		{
			return default(OONLFEIMAID<CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1DE7310", Offset = "0x1DE6710", VA = "0x181DE7310", Slot = "5")]
		private CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>> FEBICEFOGBJ(CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD> PMLKPJNGBAD, [In] HMEBJJCHPDI<EEJHDAKPMBH.AIACDIENCOD, CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>> JFCBPFNIMNJ)
		{
			return default(CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct DCGBMELBFKI : LODFJPMFNBF<CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD>, HMEBJJCHPDI<EEJHDAKPMBH.AIACDIENCOD, CEECNPFCENP<GPLICHFNGAN<DAIMPPKEFEB>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1DE7550", Offset = "0x1DE6950", VA = "0x181DE7550")]
		public CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>> JMIHOLOKADE(CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD> PMLKPJNGBAD, [In] HMEBJJCHPDI<EEJHDAKPMBH.AIACDIENCOD, CEECNPFCENP<GPLICHFNGAN<DAIMPPKEFEB>>> JFCBPFNIMNJ)
		{
			return default(CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1DE75D0", Offset = "0x1DE69D0", VA = "0x181DE75D0", Slot = "4")]
		public CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD> EIDGOCEHHFK(int PMLKPJNGBAD)
		{
			return default(CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A80", Offset = "0x7D7E80", VA = "0x1807D8A80")]
		public bool JDKNGNHNPOJ(CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD> PMLKPJNGBAD, [In] HMEBJJCHPDI<EEJHDAKPMBH.AIACDIENCOD, CEECNPFCENP<GPLICHFNGAN<DAIMPPKEFEB>>> JFCBPFNIMNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A80", Offset = "0x7D7E80", VA = "0x1807D8A80", Slot = "5")]
		private bool POBGCCONJEB(CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD> PMLKPJNGBAD, [In] HMEBJJCHPDI<EEJHDAKPMBH.AIACDIENCOD, CEECNPFCENP<GPLICHFNGAN<DAIMPPKEFEB>>> JFCBPFNIMNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1DE7550", Offset = "0x1DE6950", VA = "0x181DE7550", Slot = "6")]
		private CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>> BHECCGNDKIB(CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD> PMLKPJNGBAD, [In] HMEBJJCHPDI<EEJHDAKPMBH.AIACDIENCOD, CEECNPFCENP<GPLICHFNGAN<DAIMPPKEFEB>>> JFCBPFNIMNJ)
		{
			return default(CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct GPOCDNKAOOE : FANNNGGJAFG<CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD>, HMEBJJCHPDI<EEJHDAKPMBH.AIACDIENCOD, CEECNPFCENP<GPLICHFNGAN<DAIMPPKEFEB>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1DE9300", Offset = "0x1DE8700", VA = "0x181DE9300")]
		public OONLFEIMAID<CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD>> EMONFMKIPBM(int AOMBMAHFCEG, [In] HMEBJJCHPDI<EEJHDAKPMBH.AIACDIENCOD, CEECNPFCENP<GPLICHFNGAN<DAIMPPKEFEB>>> JFCBPFNIMNJ)
		{
			return default(OONLFEIMAID<CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1DE9370", Offset = "0x1DE8770", VA = "0x181DE9370")]
		public CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>> JMIHOLOKADE(CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD> PMLKPJNGBAD, [In] HMEBJJCHPDI<EEJHDAKPMBH.AIACDIENCOD, CEECNPFCENP<GPLICHFNGAN<DAIMPPKEFEB>>> JFCBPFNIMNJ)
		{
			return default(CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1DE93F0", Offset = "0x1DE87F0", VA = "0x181DE93F0", Slot = "6")]
		public void KAOPFFOGNAE(CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD> PMLKPJNGBAD, HMEBJJCHPDI<EEJHDAKPMBH.AIACDIENCOD, CEECNPFCENP<GPLICHFNGAN<DAIMPPKEFEB>>> JFCBPFNIMNJ, CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>> PCGOHCLJAPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1DE9300", Offset = "0x1DE8700", VA = "0x181DE9300", Slot = "4")]
		private OONLFEIMAID<CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD>> CJDPJBAPPKC(int AOMBMAHFCEG, [In] HMEBJJCHPDI<EEJHDAKPMBH.AIACDIENCOD, CEECNPFCENP<GPLICHFNGAN<DAIMPPKEFEB>>> JFCBPFNIMNJ)
		{
			return default(OONLFEIMAID<CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x1DE9370", Offset = "0x1DE8770", VA = "0x181DE9370", Slot = "5")]
		private CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>> KKFJGKPKCLC(CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD> PMLKPJNGBAD, [In] HMEBJJCHPDI<EEJHDAKPMBH.AIACDIENCOD, CEECNPFCENP<GPLICHFNGAN<DAIMPPKEFEB>>> JFCBPFNIMNJ)
		{
			return default(CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct IEJCJEBDNOO : LODFJPMFNBF<CEECNPFCENP<OHCJECBGAHH>, HMEBJJCHPDI<OHCJECBGAHH, CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1DE95A0", Offset = "0x1DE89A0", VA = "0x181DE95A0")]
		public CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>> JMIHOLOKADE(CEECNPFCENP<OHCJECBGAHH> PMLKPJNGBAD, [In] HMEBJJCHPDI<OHCJECBGAHH, CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>?> JFCBPFNIMNJ)
		{
			return default(CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1DE9500", Offset = "0x1DE8900", VA = "0x181DE9500", Slot = "4")]
		public CEECNPFCENP<OHCJECBGAHH> EIDGOCEHHFK(int PMLKPJNGBAD)
		{
			return default(CEECNPFCENP<OHCJECBGAHH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1DE9540", Offset = "0x1DE8940", VA = "0x181DE9540")]
		public bool JDKNGNHNPOJ(CEECNPFCENP<OHCJECBGAHH> PMLKPJNGBAD, [In] HMEBJJCHPDI<OHCJECBGAHH, CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>?> JFCBPFNIMNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1DE9540", Offset = "0x1DE8940", VA = "0x181DE9540", Slot = "5")]
		private bool KMMNAOBBOJH(CEECNPFCENP<OHCJECBGAHH> PMLKPJNGBAD, [In] HMEBJJCHPDI<OHCJECBGAHH, CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>?> JFCBPFNIMNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1DE9530", Offset = "0x1DE8930", VA = "0x181DE9530", Slot = "6")]
		private CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>> ENPHAPBFMAK(CEECNPFCENP<OHCJECBGAHH> PMLKPJNGBAD, [In] HMEBJJCHPDI<OHCJECBGAHH, CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>?> JFCBPFNIMNJ)
		{
			return default(CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct AEKLFIGPONN : FANNNGGJAFG<CEECNPFCENP<OHCJECBGAHH>, HMEBJJCHPDI<OHCJECBGAHH, CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1DE6E70", Offset = "0x1DE6270", VA = "0x181DE6E70")]
		public OONLFEIMAID<CEECNPFCENP<OHCJECBGAHH>> EMONFMKIPBM(int AOMBMAHFCEG, [In] HMEBJJCHPDI<OHCJECBGAHH, CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>?> JFCBPFNIMNJ)
		{
			return default(OONLFEIMAID<CEECNPFCENP<OHCJECBGAHH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1DE6EE0", Offset = "0x1DE62E0", VA = "0x181DE6EE0")]
		public CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>> JMIHOLOKADE(CEECNPFCENP<OHCJECBGAHH> PMLKPJNGBAD, [In] HMEBJJCHPDI<OHCJECBGAHH, CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>?> JFCBPFNIMNJ)
		{
			return default(CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1DE6F80", Offset = "0x1DE6380", VA = "0x181DE6F80", Slot = "6")]
		public void KAOPFFOGNAE(CEECNPFCENP<OHCJECBGAHH> PMLKPJNGBAD, HMEBJJCHPDI<OHCJECBGAHH, CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>?> JFCBPFNIMNJ, CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>> PCGOHCLJAPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1DE6E70", Offset = "0x1DE6270", VA = "0x181DE6E70", Slot = "4")]
		private OONLFEIMAID<CEECNPFCENP<OHCJECBGAHH>> FNFDOPCJALN(int AOMBMAHFCEG, [In] HMEBJJCHPDI<OHCJECBGAHH, CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>?> JFCBPFNIMNJ)
		{
			return default(OONLFEIMAID<CEECNPFCENP<OHCJECBGAHH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1DE7030", Offset = "0x1DE6430", VA = "0x181DE7030", Slot = "5")]
		private CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>> LNPNGMPDAEM(CEECNPFCENP<OHCJECBGAHH> PMLKPJNGBAD, [In] HMEBJJCHPDI<OHCJECBGAHH, CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>?> JFCBPFNIMNJ)
		{
			return default(CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct JAPBBPJJOBL : LODFJPMFNBF<int, OONLFEIMAID<(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>, CEECNPFCENP<GPLICHFNGAN<EDLGCINFKIM<COGFAOPINMA>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1DE9A20", Offset = "0x1DE8E20", VA = "0x181DE9A20")]
		public CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>> JMIHOLOKADE(int PMLKPJNGBAD, [In] OONLFEIMAID<(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> VariableId, CEECNPFCENP<GPLICHFNGAN<EDLGCINFKIM<COGFAOPINMA>>> ByteCodeWriteLocation)> JFCBPFNIMNJ)
		{
			return default(CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x11B6850", Offset = "0x11B5C50", VA = "0x1811B6850", Slot = "4")]
		public int EIDGOCEHHFK(int PMLKPJNGBAD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A80", Offset = "0x7D7E80", VA = "0x1807D8A80")]
		public bool JDKNGNHNPOJ(int PMLKPJNGBAD, [In] OONLFEIMAID<(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> VariableId, CEECNPFCENP<GPLICHFNGAN<EDLGCINFKIM<COGFAOPINMA>>> ByteCodeWriteLocation)> JFCBPFNIMNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A80", Offset = "0x7D7E80", VA = "0x1807D8A80", Slot = "5")]
		private bool BCDGOOIDJNF(int PMLKPJNGBAD, [In] OONLFEIMAID<(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> VariableId, CEECNPFCENP<GPLICHFNGAN<EDLGCINFKIM<COGFAOPINMA>>> ByteCodeWriteLocation)> JFCBPFNIMNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1DE9A10", Offset = "0x1DE8E10", VA = "0x181DE9A10", Slot = "6")]
		private CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>> IEHMEDIAHKL(int PMLKPJNGBAD, [In] OONLFEIMAID<(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> VariableId, CEECNPFCENP<GPLICHFNGAN<EDLGCINFKIM<COGFAOPINMA>>> ByteCodeWriteLocation)> JFCBPFNIMNJ)
		{
			return default(CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct FHACKNDECLO : FANNNGGJAFG<int, OONLFEIMAID<(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>, CEECNPFCENP<GPLICHFNGAN<EDLGCINFKIM<COGFAOPINMA>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1DE80A0", Offset = "0x1DE74A0", VA = "0x181DE80A0")]
		public OONLFEIMAID<int> EMONFMKIPBM(int AOMBMAHFCEG, [In] OONLFEIMAID<(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> VariableId, CEECNPFCENP<GPLICHFNGAN<EDLGCINFKIM<COGFAOPINMA>>> ByteCodeWriteLocation)> JFCBPFNIMNJ)
		{
			return default(OONLFEIMAID<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1DE8110", Offset = "0x1DE7510", VA = "0x181DE8110")]
		public CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>> JMIHOLOKADE(int PMLKPJNGBAD, [In] OONLFEIMAID<(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> VariableId, CEECNPFCENP<GPLICHFNGAN<EDLGCINFKIM<COGFAOPINMA>>> ByteCodeWriteLocation)> JFCBPFNIMNJ)
		{
			return default(CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1DE8190", Offset = "0x1DE7590", VA = "0x181DE8190", Slot = "6")]
		public void KAOPFFOGNAE(int PMLKPJNGBAD, OONLFEIMAID<(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> VariableId, CEECNPFCENP<GPLICHFNGAN<EDLGCINFKIM<COGFAOPINMA>>> ByteCodeWriteLocation)> JFCBPFNIMNJ, CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>> PCGOHCLJAPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1DE80A0", Offset = "0x1DE74A0", VA = "0x181DE80A0", Slot = "4")]
		private OONLFEIMAID<int> HKOIOINPLOP(int AOMBMAHFCEG, [In] OONLFEIMAID<(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> VariableId, CEECNPFCENP<GPLICHFNGAN<EDLGCINFKIM<COGFAOPINMA>>> ByteCodeWriteLocation)> JFCBPFNIMNJ)
		{
			return default(OONLFEIMAID<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1DE8280", Offset = "0x1DE7680", VA = "0x181DE8280", Slot = "5")]
		private CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>> PDDANNKNKJM(int PMLKPJNGBAD, [In] OONLFEIMAID<(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> VariableId, CEECNPFCENP<GPLICHFNGAN<EDLGCINFKIM<COGFAOPINMA>>> ByteCodeWriteLocation)> JFCBPFNIMNJ)
		{
			return default(CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct FDNPHJHJIHB : LODFJPMFNBF<int, OONLFEIMAID<(CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>, CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1DE7FF0", Offset = "0x1DE73F0", VA = "0x181DE7FF0")]
		public CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>> JMIHOLOKADE(int PMLKPJNGBAD, [In] OONLFEIMAID<(CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>> Target, CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>> ByteCodeWriteLocation)> JFCBPFNIMNJ)
		{
			return default(CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x11B6850", Offset = "0x11B5C50", VA = "0x1811B6850", Slot = "4")]
		public int EIDGOCEHHFK(int PMLKPJNGBAD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A80", Offset = "0x7D7E80", VA = "0x1807D8A80")]
		public bool JDKNGNHNPOJ(int PMLKPJNGBAD, [In] OONLFEIMAID<(CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>> Target, CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>> ByteCodeWriteLocation)> JFCBPFNIMNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A80", Offset = "0x7D7E80", VA = "0x1807D8A80", Slot = "5")]
		private bool JNAGNPFPPGI(int PMLKPJNGBAD, [In] OONLFEIMAID<(CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>> Target, CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>> ByteCodeWriteLocation)> JFCBPFNIMNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1DE7FF0", Offset = "0x1DE73F0", VA = "0x181DE7FF0", Slot = "6")]
		private CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>> MBKJOKDODMD(int PMLKPJNGBAD, [In] OONLFEIMAID<(CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>> Target, CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>> ByteCodeWriteLocation)> JFCBPFNIMNJ)
		{
			return default(CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct DOJJBJPCHJN : FANNNGGJAFG<int, OONLFEIMAID<(CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>, CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1DE7600", Offset = "0x1DE6A00", VA = "0x181DE7600")]
		public OONLFEIMAID<int> EMONFMKIPBM(int AOMBMAHFCEG, [In] OONLFEIMAID<(CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>> Target, CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>> ByteCodeWriteLocation)> JFCBPFNIMNJ)
		{
			return default(OONLFEIMAID<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1DE7670", Offset = "0x1DE6A70", VA = "0x181DE7670")]
		public CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>> JMIHOLOKADE(int PMLKPJNGBAD, [In] OONLFEIMAID<(CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>> Target, CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>> ByteCodeWriteLocation)> JFCBPFNIMNJ)
		{
			return default(CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1DE76F0", Offset = "0x1DE6AF0", VA = "0x181DE76F0", Slot = "6")]
		public void KAOPFFOGNAE(int PMLKPJNGBAD, OONLFEIMAID<(CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>> Target, CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>> ByteCodeWriteLocation)> JFCBPFNIMNJ, CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>> PCGOHCLJAPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1DE7600", Offset = "0x1DE6A00", VA = "0x181DE7600", Slot = "4")]
		private OONLFEIMAID<int> EDKBHEIOLDF(int AOMBMAHFCEG, [In] OONLFEIMAID<(CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>> Target, CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>> ByteCodeWriteLocation)> JFCBPFNIMNJ)
		{
			return default(OONLFEIMAID<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1DE7670", Offset = "0x1DE6A70", VA = "0x181DE7670", Slot = "5")]
		private CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>> POLNFOLAJNN(int PMLKPJNGBAD, [In] OONLFEIMAID<(CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>> Target, CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>> ByteCodeWriteLocation)> JFCBPFNIMNJ)
		{
			return default(CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct OEKALBPLIAE : LODFJPMFNBF<int, OONLFEIMAID<(CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>, CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1DF1780", Offset = "0x1DF0B80", VA = "0x181DF1780")]
		public CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>> JMIHOLOKADE(int PMLKPJNGBAD, [In] OONLFEIMAID<(CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>> Target, CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>> ByteCodeWriteLocation)> JFCBPFNIMNJ)
		{
			return default(CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x11B6850", Offset = "0x11B5C50", VA = "0x1811B6850", Slot = "4")]
		public int EIDGOCEHHFK(int PMLKPJNGBAD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A80", Offset = "0x7D7E80", VA = "0x1807D8A80")]
		public bool JDKNGNHNPOJ(int PMLKPJNGBAD, [In] OONLFEIMAID<(CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>> Target, CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>> ByteCodeWriteLocation)> JFCBPFNIMNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A80", Offset = "0x7D7E80", VA = "0x1807D8A80", Slot = "5")]
		private bool JNAGNPFPPGI(int PMLKPJNGBAD, [In] OONLFEIMAID<(CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>> Target, CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>> ByteCodeWriteLocation)> JFCBPFNIMNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1DF1800", Offset = "0x1DF0C00", VA = "0x181DF1800", Slot = "6")]
		private CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>> MBKJOKDODMD(int PMLKPJNGBAD, [In] OONLFEIMAID<(CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>> Target, CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>> ByteCodeWriteLocation)> JFCBPFNIMNJ)
		{
			return default(CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct FHGDBECIDCN : FANNNGGJAFG<int, OONLFEIMAID<(CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>, CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1DE8290", Offset = "0x1DE7690", VA = "0x181DE8290")]
		public OONLFEIMAID<int> EMONFMKIPBM(int AOMBMAHFCEG, [In] OONLFEIMAID<(CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>> Target, CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>> ByteCodeWriteLocation)> JFCBPFNIMNJ)
		{
			return default(OONLFEIMAID<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x1DE8300", Offset = "0x1DE7700", VA = "0x181DE8300")]
		public CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>> JMIHOLOKADE(int PMLKPJNGBAD, [In] OONLFEIMAID<(CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>> Target, CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>> ByteCodeWriteLocation)> JFCBPFNIMNJ)
		{
			return default(CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1DE8380", Offset = "0x1DE7780", VA = "0x181DE8380", Slot = "6")]
		public void KAOPFFOGNAE(int PMLKPJNGBAD, OONLFEIMAID<(CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>> Target, CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>> ByteCodeWriteLocation)> JFCBPFNIMNJ, CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>> PCGOHCLJAPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1DE8290", Offset = "0x1DE7690", VA = "0x181DE8290", Slot = "4")]
		private OONLFEIMAID<int> EDKBHEIOLDF(int AOMBMAHFCEG, [In] OONLFEIMAID<(CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>> Target, CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>> ByteCodeWriteLocation)> JFCBPFNIMNJ)
		{
			return default(OONLFEIMAID<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1DE8470", Offset = "0x1DE7870", VA = "0x181DE8470", Slot = "5")]
		private CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>> POLNFOLAJNN(int PMLKPJNGBAD, [In] OONLFEIMAID<(CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>> Target, CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>> ByteCodeWriteLocation)> JFCBPFNIMNJ)
		{
			return default(CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct FFBKOEMFFPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> MFMMPJGDEIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool DJAOFFPFKCH;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xF1B640", Offset = "0xF1AA40", VA = "0x180F1B640")]
		public FFBKOEMFFPC(CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> KOPPIDOOEOP, bool HMNBNCKKOCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1DE8090", Offset = "0x1DE7490", VA = "0x181DE8090")]
		public void BNCCPBFLAPH([Out] CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> KOPPIDOOEOP, [Out] bool HMNBNCKKOCJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct MPHNCFEFLEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly CEECNPFCENP<OHCJECBGAHH> FGKGKMOPGJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> MFMMPJGDEIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool DJAOFFPFKCH;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1DEBFE0", Offset = "0x1DEB3E0", VA = "0x181DEBFE0")]
		public MPHNCFEFLEF(CEECNPFCENP<OHCJECBGAHH> OHOJMGNOIJJ, CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> KOPPIDOOEOP, bool HMNBNCKKOCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1DEBFD0", Offset = "0x1DEB3D0", VA = "0x181DEBFD0")]
		public void BNCCPBFLAPH([Out] CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> KOPPIDOOEOP, [Out] bool HMNBNCKKOCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1DEBFB0", Offset = "0x1DEB3B0", VA = "0x181DEBFB0")]
		public void BNCCPBFLAPH([Out] CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> KOPPIDOOEOP, [Out] CEECNPFCENP<OHCJECBGAHH> OHOJMGNOIJJ, [Out] bool HMNBNCKKOCJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct FPHNELDHLCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly CEECNPFCENP<OHCJECBGAHH> FGKGKMOPGJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> MFMMPJGDEIK;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xAEAF20", Offset = "0xAEA320", VA = "0x180AEAF20")]
		public FPHNELDHLCG(CEECNPFCENP<OHCJECBGAHH> OHOJMGNOIJJ, CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> KOPPIDOOEOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1DE8480", Offset = "0x1DE7880", VA = "0x181DE8480")]
		public void BNCCPBFLAPH([Out] CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> KOPPIDOOEOP, [Out] CEECNPFCENP<OHCJECBGAHH> OHOJMGNOIJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1DEA440", Offset = "0x1DE9840", VA = "0x181DEA440")]
	public static void FHLEEDLMEFH(this GIOLGACMMAA MEEBIDIALDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1DEBD30", Offset = "0x1DEB130", VA = "0x181DEBD30")]
	public static void PIMCPPOKAAD(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IHPFKLFEHJK> KJMLGAEJIAC, CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> DGFCKJEHAFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1DEA2A0", Offset = "0x1DE96A0", VA = "0x181DEA2A0")]
	public static void EHBFNBAOGHP(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IHPFKLFEHJK> KJMLGAEJIAC, CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> DGFCKJEHAFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1DEA190", Offset = "0x1DE9590", VA = "0x181DEA190")]
	public static CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO>? EABKEGCLEPE([In] this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IHPFKLFEHJK> KJMLGAEJIAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1DEA7A0", Offset = "0x1DE9BA0", VA = "0x181DEA7A0")]
	public static CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>> GCAPJDCALEF([In] this GIOLGACMMAA MEEBIDIALDO)
	{
		return default(CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1DEAD90", Offset = "0x1DEA190", VA = "0x181DEAD90")]
	private static void KAAIPJCMMGL(this GIOLGACMMAA MEEBIDIALDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1DEBA80", Offset = "0x1DEAE80", VA = "0x181DEBA80")]
	private static CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>? OMFCFGLABOB([In] this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<OHCJECBGAHH> OHOJMGNOIJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1DEAA80", Offset = "0x1DE9E80", VA = "0x181DEAA80")]
	public static void GMDCIKICLHA(this GIOLGACMMAA MEEBIDIALDO, [In] OONLFEIMAID<LFKNGIPMNFG> AIGGCPJHJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1DE9C50", Offset = "0x1DE9050", VA = "0x181DE9C50")]
	public static POOHGCEHMHB.OELCPIONCEH ANEPBKBMCNF([In] this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> KOPPIDOOEOP)
	{
		return default(POOHGCEHMHB.OELCPIONCEH);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1DEB9D0", Offset = "0x1DEADD0", VA = "0x181DEB9D0")]
	public static LMHOHLCAMLC<byte> OLLDAOCNAFG([In] this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> KOPPIDOOEOP)
	{
		return default(LMHOHLCAMLC<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1DEB1E0", Offset = "0x1DEA5E0", VA = "0x181DEB1E0")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> KLNALGNBNCH([In] this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> KOPPIDOOEOP)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1DEAF70", Offset = "0x1DEA370", VA = "0x181DEAF70")]
	public static FPDIDCFFANP KJGHLKAKLKL([In] this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> KOPPIDOOEOP)
	{
		return default(FPDIDCFFANP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2875920", Offset = "0x2874D20", VA = "0x182875920")]
	private static CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> JFCKMNBPJEG<TMJoin>(this GIOLGACMMAA MEEBIDIALDO, POOHGCEHMHB.OELCPIONCEH MEOGECGECNG, CEECNPFCENP<TMJoin> PNCPDELJLJB) where TMJoin : POOHGCEHMHB.BLOAFAIACGF
	{
		return default(CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1DEAEF0", Offset = "0x1DEA2F0", VA = "0x181DEAEF0")]
	public static CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> KCAGIGDABFN(this GIOLGACMMAA MEEBIDIALDO, bool MMNLPCBHNFG)
	{
		return default(CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1DEB370", Offset = "0x1DEA770", VA = "0x181DEB370")]
	public static CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> LJGBFKBNOCE(this GIOLGACMMAA MEEBIDIALDO, LMHOHLCAMLC<byte> GHDDMAGGOCG)
	{
		return default(CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1DEA220", Offset = "0x1DE9620", VA = "0x181DEA220")]
	public static CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> EEIBOOKPKDI(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>> FIBAGJBIOJI)
	{
		return default(CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1DEBDC0", Offset = "0x1DEB1C0", VA = "0x181DEBDC0")]
	public static CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> PPPPENIMMPA(this GIOLGACMMAA MEEBIDIALDO, int COBGOMDJIHE)
	{
		return default(CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1DE9DD0", Offset = "0x1DE91D0", VA = "0x181DE9DD0")]
	public static CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> BDMHOBBNJMG(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> CAKILKPBKEE)
	{
		return default(CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2875890", Offset = "0x2874C90", VA = "0x182875890")]
	private static CEECNPFCENP<EKPLFECBDOC.BHPDJPACCLE> INDPGFEIJAC<TMJoin>(this GIOLGACMMAA MEEBIDIALDO, EKPLFECBDOC.DKLLNODMIHN MEOGECGECNG, CEECNPFCENP<TMJoin> PNCPDELJLJB) where TMJoin : EKPLFECBDOC.IANAPNKLHOM
	{
		return default(CEECNPFCENP<EKPLFECBDOC.BHPDJPACCLE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1DEA150", Offset = "0x1DE9550", VA = "0x181DEA150")]
	public static CEECNPFCENP<EKPLFECBDOC.BHPDJPACCLE> DOECNPPCJOL(this GIOLGACMMAA MEEBIDIALDO)
	{
		return default(CEECNPFCENP<EKPLFECBDOC.BHPDJPACCLE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1DEA0B0", Offset = "0x1DE94B0", VA = "0x181DEA0B0")]
	public static CEECNPFCENP<EKPLFECBDOC.BHPDJPACCLE> CKKPAGHHIEM(this GIOLGACMMAA MEEBIDIALDO)
	{
		return default(CEECNPFCENP<EKPLFECBDOC.BHPDJPACCLE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1DEB610", Offset = "0x1DEAA10", VA = "0x181DEB610")]
	public static CEECNPFCENP<EKPLFECBDOC.BHPDJPACCLE> MDGHJJHBJLA(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> NMMFGFAJBDB)
	{
		return default(CEECNPFCENP<EKPLFECBDOC.BHPDJPACCLE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1DEA370", Offset = "0x1DE9770", VA = "0x181DEA370")]
	public static CEECNPFCENP<EKPLFECBDOC.BHPDJPACCLE> EMNJIKDHJEG(this GIOLGACMMAA MEEBIDIALDO)
	{
		return default(CEECNPFCENP<EKPLFECBDOC.BHPDJPACCLE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1DE9B50", Offset = "0x1DE8F50", VA = "0x181DE9B50")]
	public static CEECNPFCENP<EKPLFECBDOC.BHPDJPACCLE> ACALPKFNHGJ(this GIOLGACMMAA MEEBIDIALDO)
	{
		return default(CEECNPFCENP<EKPLFECBDOC.BHPDJPACCLE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1DE9B90", Offset = "0x1DE8F90", VA = "0x181DE9B90")]
	public static EEJHDAKPMBH.JLCNKAJOLFK ADEAHHDKACE([In] this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<EEJHDAKPMBH.OMBIMIGMEJF> JDOCENAFBMB)
	{
		return default(EEJHDAKPMBH.JLCNKAJOLFK);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1DEACB0", Offset = "0x1DEA0B0", VA = "0x181DEACB0")]
	public static OCIEPPKJBLK<CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD>, BHANBDNAGFD<EEJHDAKPMBH.AIACDIENCOD>> JHEOCPCLAOH([In] this GIOLGACMMAA MEEBIDIALDO)
	{
		return default(OCIEPPKJBLK<CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD>, BHANBDNAGFD<EEJHDAKPMBH.AIACDIENCOD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1DEB4A0", Offset = "0x1DEA8A0", VA = "0x181DEB4A0")]
	public static CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD> LOMBBPFGNMB([In] this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<EEJHDAKPMBH.OMBIMIGMEJF> JDOCENAFBMB)
	{
		return default(CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1DE9BF0", Offset = "0x1DE8FF0", VA = "0x181DE9BF0")]
	public static EEJHDAKPMBH.OHOMJKINEMN AGDIOLAEANI([In] this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD> CBOJFMNLLAG)
	{
		return default(EEJHDAKPMBH.OHOMJKINEMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1DEA0F0", Offset = "0x1DE94F0", VA = "0x181DEA0F0")]
	public static EEJHDAKPMBH.OHOMJKINEMN CNFJAMINKBH(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD> CBOJFMNLLAG)
	{
		return default(EEJHDAKPMBH.OHOMJKINEMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2875800", Offset = "0x2874C00", VA = "0x182875800")]
	private static CEECNPFCENP<EEJHDAKPMBH.OMBIMIGMEJF> GKMDJOOJJBE<TMJoin>(this GIOLGACMMAA MEEBIDIALDO, EEJHDAKPMBH.JLCNKAJOLFK MEOGECGECNG, CEECNPFCENP<TMJoin> PNCPDELJLJB) where TMJoin : EEJHDAKPMBH.NPLLGJFEOON
	{
		return default(CEECNPFCENP<EEJHDAKPMBH.OMBIMIGMEJF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1DEA800", Offset = "0x1DE9C00", VA = "0x181DEA800")]
	public static (CEECNPFCENP<EEJHDAKPMBH.OMBIMIGMEJF>, CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD>) GGIJKLBODEC(this GIOLGACMMAA MEEBIDIALDO)
	{
		return default((CEECNPFCENP<EEJHDAKPMBH.OMBIMIGMEJF>, CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1DEBB10", Offset = "0x1DEAF10", VA = "0x181DEBB10")]
	public static (CEECNPFCENP<EEJHDAKPMBH.OMBIMIGMEJF>, CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD>) ONHPMBLHDIN(this GIOLGACMMAA MEEBIDIALDO)
	{
		return default((CEECNPFCENP<EEJHDAKPMBH.OMBIMIGMEJF>, CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1DEB290", Offset = "0x1DEA690", VA = "0x181DEB290")]
	public static CEECNPFCENP<EEJHDAKPMBH.OMBIMIGMEJF> LFALKBFHMGG(this GIOLGACMMAA MEEBIDIALDO)
	{
		return default(CEECNPFCENP<EEJHDAKPMBH.OMBIMIGMEJF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1DEB690", Offset = "0x1DEAA90", VA = "0x181DEB690")]
	public static void MEGHCJKCCCO(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD> CBOJFMNLLAG, CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>> IPEBHECEINF, CEECNPFCENP<GPLICHFNGAN<DAIMPPKEFEB>> KFNOKOJIKKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2874A20", Offset = "0x2873E20", VA = "0x182874A20")]
	public static FFBKOEMFFPC GCHCFEOFDJL<TDeps, TStateSys>(this GIOLGACMMAA MEEBIDIALDO, TDeps IGMHAFBOHAM, TStateSys JLAEHOODFAL, CEECNPFCENP<MCMKDNBCCKK> CBNAIGKNIGK, CEECNPFCENP<OHCJECBGAHH> OHOJMGNOIJJ) where TDeps : CPFMBLKBOIO<TStateSys>
	{
		return default(FFBKOEMFFPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x28742C0", Offset = "0x28736C0", VA = "0x1828742C0")]
	public static MPHNCFEFLEF BEHBHMNOKIB<TDeps, TStateSys>(this GIOLGACMMAA MEEBIDIALDO, TDeps IGMHAFBOHAM, TStateSys JLAEHOODFAL, CEECNPFCENP<MCMKDNBCCKK> CBNAIGKNIGK, CEECNPFCENP<HELLJKJMNFC> IPJEEPFEOCM, int PCNNNBAFEJK) where TDeps : CPFMBLKBOIO<TStateSys>
	{
		return default(MPHNCFEFLEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2874600", Offset = "0x2873A00", VA = "0x182874600")]
	public static CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO>? EMBJKMEJDOA<TDeps, TStateSys>(this GIOLGACMMAA MEEBIDIALDO, TDeps IGMHAFBOHAM, TStateSys JLAEHOODFAL, CEECNPFCENP<MCMKDNBCCKK> CBNAIGKNIGK, CEECNPFCENP<HELLJKJMNFC> IPJEEPFEOCM, [In] ReadOnlySpan<int> PACJNDGDHCI, [In] Span<FPHNELDHLCG> FJEGBMAMHPP) where TDeps : CPFMBLKBOIO<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x28759B0", Offset = "0x2874DB0", VA = "0x1828759B0")]
	public static CEECNPFCENP<EKPLFECBDOC.BHPDJPACCLE> KDOBFALOIKC<TDeps, TStateSys>(this GIOLGACMMAA MEEBIDIALDO, TDeps IGMHAFBOHAM, TStateSys JLAEHOODFAL, CEECNPFCENP<MCMKDNBCCKK> CBNAIGKNIGK, CEECNPFCENP<IHPFKLFEHJK> KJMLGAEJIAC) where TDeps : CPFMBLKBOIO<TStateSys>
	{
		return default(CEECNPFCENP<EKPLFECBDOC.BHPDJPACCLE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1DEA010", Offset = "0x1DE9410", VA = "0x181DEA010")]
	public static IMNGEGPBJMM.FFFBOLLKOHD CJOMIMDKJKA([In] this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> BFMGPLIBCKL)
	{
		return default(IMNGEGPBJMM.FFFBOLLKOHD);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1DEACF0", Offset = "0x1DEA0F0", VA = "0x181DEACF0")]
	public static IMNGEGPBJMM.DNKBMIHFDPB JPGDCBIGDPI([In] this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> BFMGPLIBCKL)
	{
		return default(IMNGEGPBJMM.DNKBMIHFDPB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1DEB400", Offset = "0x1DEA800", VA = "0x181DEB400")]
	public static IMNGEGPBJMM.LLBIHCKNKHM LJMLLCENCPB([In] this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> BFMGPLIBCKL)
	{
		return default(IMNGEGPBJMM.LLBIHCKNKHM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1DE9E50", Offset = "0x1DE9250", VA = "0x181DE9E50")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> BIEMJLBCKGM(this GIOLGACMMAA MEEBIDIALDO, int? MLIEIOHNACG, string CCNKHEJHFKM)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1DEB2D0", Offset = "0x1DEA6D0", VA = "0x181DEB2D0")]
	public static IMNGEGPBJMM.OFLLLDNBFLL LGGCBCMHDBC([In] this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> BFMGPLIBCKL)
	{
		return default(IMNGEGPBJMM.OFLLLDNBFLL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1DEB780", Offset = "0x1DEAB80", VA = "0x181DEB780")]
	public static IMNGEGPBJMM.HFMAEGMDLDB NEFDDODOANM([In] this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> BFMGPLIBCKL)
	{
		return default(IMNGEGPBJMM.HFMAEGMDLDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1DEB7E0", Offset = "0x1DEABE0", VA = "0x181DEB7E0")]
	public static int? NIFKFKMLFOH([In] this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> BFMGPLIBCKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2875F50", Offset = "0x2875350", VA = "0x182875F50")]
	private static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> LDJNNDEHOIC<TMJoin>(this GIOLGACMMAA MEEBIDIALDO, int? MLIEIOHNACG, IMNGEGPBJMM.HFMAEGMDLDB MEOGECGECNG, CEECNPFCENP<TMJoin> PNCPDELJLJB) where TMJoin : IMNGEGPBJMM.PGCAIGCGFEJ
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1DEA9D0", Offset = "0x1DE9DD0", VA = "0x181DEA9D0")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> GHFGLGANNHD(this GIOLGACMMAA MEEBIDIALDO, int? MLIEIOHNACG, CEECNPFCENP<EEJHDAKPMBH.OMBIMIGMEJF> JDOCENAFBMB, int PMLKPJNGBAD)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1DEBCD0", Offset = "0x1DEB0D0", VA = "0x181DEBCD0")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> PFHGJNPEMEL(this GIOLGACMMAA MEEBIDIALDO, int? MLIEIOHNACG)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1DEB840", Offset = "0x1DEAC40", VA = "0x181DEB840")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> OEDEPKMIJHH(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>? EAPEECKGPAJ, int? MLIEIOHNACG)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1DEA3B0", Offset = "0x1DE97B0", VA = "0x181DEA3B0")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> FDBFONDFCFL(this GIOLGACMMAA MEEBIDIALDO, int? MLIEIOHNACG, int PMLKPJNGBAD)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1DEB720", Offset = "0x1DEAB20", VA = "0x181DEB720")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> NALKAJNLIJI(this GIOLGACMMAA MEEBIDIALDO, int? MLIEIOHNACG)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1DE9CB0", Offset = "0x1DE90B0", VA = "0x181DE9CB0")]
	public static void BBCANFFKIBM(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> CAKILKPBKEE, CEECNPFCENP<EEJHDAKPMBH.OMBIMIGMEJF> JDOCENAFBMB, int PMLKPJNGBAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1DEB020", Offset = "0x1DEA420", VA = "0x181DEB020")]
	public static void KLCOFIEIIIB(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> CAKILKPBKEE, int PMLKPJNGBAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1DEB120", Offset = "0x1DEA520", VA = "0x181DEB120")]
	public static void KLKANDCNPJJ(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> CAKILKPBKEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1DEA710", Offset = "0x1DE9B10", VA = "0x181DEA710")]
	public static void FLDGDNNHEDD(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>> NDIKGOAJKGJ, CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>> KDBHLCOMAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1DEABF0", Offset = "0x1DE9FF0", VA = "0x181DEABF0")]
	public static void IJLLHGCKPDP(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> CAKILKPBKEE, CEECNPFCENP<GPLICHFNGAN<JLKBMNIDOBB>> BCCBBLAKEBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2874540", Offset = "0x2873940", VA = "0x182874540")]
	public static void ECHIKOBOGOM<M>(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> CAKILKPBKEE, CEECNPFCENP<GPLICHFNGAN<EDLGCINFKIM<M>>> BCCBBLAKEBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface CPFMBLKBOIO<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CEECNPFCENP<EBLILJDLKML> ELJOBAEBPIB(TStateSys JLAEHOODFAL);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CEECNPFCENP<EBLILJDLKML> JDFJJJANFHF(TStateSys JLAEHOODFAL);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CEECNPFCENP<EMKFLDEHDOI> IMCHFINPNKI(TStateSys JLAEHOODFAL);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CEECNPFCENP<EMKFLDEHDOI> BBMIBOPMFFP(TStateSys JLAEHOODFAL);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CEECNPFCENP<EKPLFECBDOC.BHPDJPACCLE> IJMCBJAIOJJ(TStateSys JLAEHOODFAL, GIOLGACMMAA MCDNAMBDEOE, CEECNPFCENP<MCMKDNBCCKK> CBNAIGKNIGK, CEECNPFCENP<OHCJECBGAHH> OHOJMGNOIJJ);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> CFLJHPIKGFD(TStateSys JLAEHOODFAL, GIOLGACMMAA MCDNAMBDEOE, CEECNPFCENP<MCMKDNBCCKK> CBNAIGKNIGK, CEECNPFCENP<IHPFKLFEHJK> KJMLGAEJIAC);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int FOHHCPMFFOH(TStateSys JLAEHOODFAL, CEECNPFCENP<MCMKDNBCCKK> CBNAIGKNIGK, CEECNPFCENP<OHCJECBGAHH> OHOJMGNOIJJ);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CEECNPFCENP<IHPFKLFEHJK> FMGBMPENAED(TStateSys JLAEHOODFAL, CEECNPFCENP<MCMKDNBCCKK> CBNAIGKNIGK, CEECNPFCENP<OHCJECBGAHH> OHOJMGNOIJJ, int IJJLKFHGNOA);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NAPHBBPFBED AEEHMNOIADK(TStateSys JLAEHOODFAL, CEECNPFCENP<MCMKDNBCCKK> CBNAIGKNIGK, CEECNPFCENP<OHCJECBGAHH> OHOJMGNOIJJ);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool CPGAEFEFLDK(TStateSys JLAEHOODFAL, CEECNPFCENP<MCMKDNBCCKK> CBNAIGKNIGK, CEECNPFCENP<OHCJECBGAHH> OHOJMGNOIJJ);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int BEOKGDIPDCO(TStateSys JLAEHOODFAL, CEECNPFCENP<MCMKDNBCCKK> CBNAIGKNIGK, CEECNPFCENP<OHCJECBGAHH> OHOJMGNOIJJ);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	LMHOHLCAMLC<byte> PONPGEFCKBB(TStateSys JLAEHOODFAL, CEECNPFCENP<MCMKDNBCCKK> CBNAIGKNIGK, CEECNPFCENP<OHCJECBGAHH> OHOJMGNOIJJ);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(LMHOHLCAMLC<byte>, CEECNPFCENP<EMKFLDEHDOI>) KLHCKGBCDMA(TStateSys JLAEHOODFAL, CEECNPFCENP<MCMKDNBCCKK> CBNAIGKNIGK, CEECNPFCENP<OHCJECBGAHH> OHOJMGNOIJJ);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int FJGJPAKIEFG(TStateSys JLAEHOODFAL, CEECNPFCENP<MCMKDNBCCKK> CBNAIGKNIGK, CEECNPFCENP<IHPFKLFEHJK> KJMLGAEJIAC);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	CEECNPFCENP<OHCJECBGAHH> JHMJLLDIJFP(TStateSys JLAEHOODFAL, CEECNPFCENP<MCMKDNBCCKK> CBNAIGKNIGK, CEECNPFCENP<IHPFKLFEHJK> KJMLGAEJIAC, int PCNNNBAFEJK);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	CEECNPFCENP<OHCJECBGAHH> JGCGDKBANPK(TStateSys JLAEHOODFAL, CEECNPFCENP<MCMKDNBCCKK> CBNAIGKNIGK, CEECNPFCENP<HELLJKJMNFC> IPJEEPFEOCM, int PCNNNBAFEJK);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int LGIOMCCDBIB(TStateSys JLAEHOODFAL, CEECNPFCENP<MCMKDNBCCKK> CBNAIGKNIGK);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? HKNELOEOFPH(TStateSys JLAEHOODFAL, CEECNPFCENP<MCMKDNBCCKK> CBNAIGKNIGK, int PMLKPJNGBAD);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int LNIKLPAGEPP(TStateSys JLAEHOODFAL, CEECNPFCENP<MCMKDNBCCKK> CBNAIGKNIGK);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? BDOFIOAIGFJ(TStateSys JLAEHOODFAL, CEECNPFCENP<MCMKDNBCCKK> CBNAIGKNIGK, int PMLKPJNGBAD);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class NAEMGGCKLJL
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x290EE60", Offset = "0x290E260", VA = "0x18290EE60")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI?> LJIBNAPKOAI<T, TOpInput, TOpOutput>(this GIOLGACMMAA MEEBIDIALDO, T LCALDLBCJKP, T JPKPFNMFEIJ, int CAEGLMFPLBH, IntPtr IAIHIOAMBHE)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x290E1F0", Offset = "0x290D5F0", VA = "0x18290E1F0")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI?> IAJBDCLBKFP<T, TOpInput, TOpOutput>(this GIOLGACMMAA MEEBIDIALDO, T LCALDLBCJKP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> JPKPFNMFEIJ, int CAEGLMFPLBH, IntPtr IAIHIOAMBHE)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x290CC70", Offset = "0x290C070", VA = "0x18290CC70")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI?> BILDIONNBOB<TOpInput, TOpOutput>(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> LCALDLBCJKP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> JPKPFNMFEIJ, int CAEGLMFPLBH, IntPtr IAIHIOAMBHE)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1DEE300", Offset = "0x1DED700", VA = "0x181DEE300")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> GOFBFAKEPBO(this GIOLGACMMAA MEEBIDIALDO, float HOJDNHFFALP, float DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1DF0780", Offset = "0x1DEFB80", VA = "0x181DF0780")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> NPKBAKDHFBO(this GIOLGACMMAA MEEBIDIALDO, float HOJDNHFFALP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1DEC310", Offset = "0x1DEB710", VA = "0x181DEC310")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> BCMAAIMPHCJ(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> HOJDNHFFALP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1DEDA50", Offset = "0x1DECE50", VA = "0x181DEDA50")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> FOFPABGKOKO(this GIOLGACMMAA MEEBIDIALDO, int HOJDNHFFALP, int DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1DF0A60", Offset = "0x1DEFE60", VA = "0x181DF0A60")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> PCBDDPGDNFM(this GIOLGACMMAA MEEBIDIALDO, int HOJDNHFFALP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1DEEC30", Offset = "0x1DEE030", VA = "0x181DEEC30")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> JNMKMAGPNLA(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> HOJDNHFFALP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1DECAD0", Offset = "0x1DEBED0", VA = "0x181DECAD0")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> CMBELCGDGHH(this GIOLGACMMAA MEEBIDIALDO, int HOJDNHFFALP, int DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1DEE920", Offset = "0x1DEDD20", VA = "0x181DEE920")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> JEGPMCHEDOC(this GIOLGACMMAA MEEBIDIALDO, int HOJDNHFFALP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1DF04D0", Offset = "0x1DEF8D0", VA = "0x181DF04D0")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> NKEOAEIEGEF(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> HOJDNHFFALP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1DECBC0", Offset = "0x1DEBFC0", VA = "0x181DECBC0")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> DACLFKPMJFO(this GIOLGACMMAA MEEBIDIALDO, int LCALDLBCJKP, int JPKPFNMFEIJ)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1DEF790", Offset = "0x1DEEB90", VA = "0x181DEF790")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> LNGBAFPECLL(this GIOLGACMMAA MEEBIDIALDO, int LCALDLBCJKP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> JPKPFNMFEIJ)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1DED6C0", Offset = "0x1DECAC0", VA = "0x181DED6C0")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> FBGFIHDLFBA(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> LCALDLBCJKP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> JPKPFNMFEIJ)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1DEEF20", Offset = "0x1DEE320", VA = "0x181DEEF20")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> KDIFMFJGKOK(this GIOLGACMMAA MEEBIDIALDO, float LCALDLBCJKP, float JPKPFNMFEIJ)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1DED880", Offset = "0x1DECC80", VA = "0x181DED880")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> FJMNJOFCHNL(this GIOLGACMMAA MEEBIDIALDO, float LCALDLBCJKP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> JPKPFNMFEIJ)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1DEDB40", Offset = "0x1DECF40", VA = "0x181DEDB40")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> GFKPJPKFJOG(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> LCALDLBCJKP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> JPKPFNMFEIJ)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1DECCB0", Offset = "0x1DEC0B0", VA = "0x181DECCB0")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> DKJBOFOJNKJ(this GIOLGACMMAA MEEBIDIALDO, int LCALDLBCJKP, int JPKPFNMFEIJ)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1DECA50", Offset = "0x1DEBE50", VA = "0x181DECA50")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> CEONNDGDDJB(this GIOLGACMMAA MEEBIDIALDO, int LCALDLBCJKP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> JPKPFNMFEIJ)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1DED640", Offset = "0x1DECA40", VA = "0x181DED640")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> FBDBDGGFKPD(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> LCALDLBCJKP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> JPKPFNMFEIJ)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1DF09E0", Offset = "0x1DEFDE0", VA = "0x181DF09E0")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> PBCGDGFDLBL(this GIOLGACMMAA MEEBIDIALDO, float LCALDLBCJKP, float JPKPFNMFEIJ)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1DEFC30", Offset = "0x1DEF030", VA = "0x181DEFC30")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> MFBBDBLAIMM(this GIOLGACMMAA MEEBIDIALDO, float LCALDLBCJKP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> JPKPFNMFEIJ)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1DF0610", Offset = "0x1DEFA10", VA = "0x181DF0610")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> NLKFFJLNNIK(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> LCALDLBCJKP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> JPKPFNMFEIJ)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1DEC210", Offset = "0x1DEB610", VA = "0x181DEC210")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> AFGGECOIMAF(this GIOLGACMMAA MEEBIDIALDO, int LCALDLBCJKP, int JPKPFNMFEIJ)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1DEE8A0", Offset = "0x1DEDCA0", VA = "0x181DEE8A0")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> IOMADHKHICA(this GIOLGACMMAA MEEBIDIALDO, int LCALDLBCJKP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> JPKPFNMFEIJ)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1DF11B0", Offset = "0x1DF05B0", VA = "0x181DF11B0")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> PLFGEOBHJGO(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> LCALDLBCJKP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> JPKPFNMFEIJ)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1DEFCB0", Offset = "0x1DEF0B0", VA = "0x181DEFCB0")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> MKMNKABBLHL(this GIOLGACMMAA MEEBIDIALDO, float LCALDLBCJKP, float JPKPFNMFEIJ)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1DEE660", Offset = "0x1DEDA60", VA = "0x181DEE660")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> IEPPOEHAPNO(this GIOLGACMMAA MEEBIDIALDO, float LCALDLBCJKP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> JPKPFNMFEIJ)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1DEC290", Offset = "0x1DEB690", VA = "0x181DEC290")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> APMPPJMMPEC(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> LCALDLBCJKP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> JPKPFNMFEIJ)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1DF0FD0", Offset = "0x1DF03D0", VA = "0x181DF0FD0")]
	public static CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>> PIJECPEKDJN(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> KOPPIDOOEOP)
	{
		return default(CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1DEED70", Offset = "0x1DEE170", VA = "0x181DEED70")]
	public static CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>> JOGCGCEPEKO(this GIOLGACMMAA MEEBIDIALDO, int PCGOHCLJAPN)
	{
		return default(CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1DED480", Offset = "0x1DEC880", VA = "0x181DED480")]
	public static CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>> EMOIPLDMNEK(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> PCGOHCLJAPN)
	{
		return default(CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1DECD30", Offset = "0x1DEC130", VA = "0x181DECD30")]
	public static CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>> DPPJCBFPPBB(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> KOPPIDOOEOP)
	{
		return default(CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1DEE820", Offset = "0x1DEDC20", VA = "0x181DEE820")]
	public static CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>> IJAGGMJCICE(this GIOLGACMMAA MEEBIDIALDO, int PCGOHCLJAPN)
	{
		return default(CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1DED9B0", Offset = "0x1DECDB0", VA = "0x181DED9B0")]
	public static CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>> FNJMDOKEKKL(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> PCGOHCLJAPN)
	{
		return default(CEECNPFCENP<GPLICHFNGAN<GPLICHFNGAN<LFEKFFGAHDG>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1DF0040", Offset = "0x1DEF440", VA = "0x181DF0040")]
	public static (CEECNPFCENP<EEJHDAKPMBH.OMBIMIGMEJF>, CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD>) NIFAFFFEEDI(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<EBLILJDLKML> BDAIGOLMMPP, [In] ReadOnlySpan<CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>> BOEGHICBNGK, [In] ReadOnlySpan<int?> DBIFGFENMFE, [In] Span<CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>> EBCPKCKHGEO)
	{
		return default((CEECNPFCENP<EEJHDAKPMBH.OMBIMIGMEJF>, CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1DEDE70", Offset = "0x1DED270", VA = "0x181DEDE70")]
	public static (CEECNPFCENP<EEJHDAKPMBH.OMBIMIGMEJF>, CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD>) GMLOJBBNLLB(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<HGNGFOEMFNG> AFKOBLNBEON, [In] ReadOnlySpan<CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>> BOEGHICBNGK, [In] ReadOnlySpan<int?> DBIFGFENMFE, [In] Span<CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>> EBCPKCKHGEO)
	{
		return default((CEECNPFCENP<EEJHDAKPMBH.OMBIMIGMEJF>, CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x290DB80", Offset = "0x290CF80", VA = "0x18290DB80")]
	public static (CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>, CEECNPFCENP<GPLICHFNGAN<EMKFLDEHDOI>>, CEECNPFCENP<GPLICHFNGAN<DAIMPPKEFEB>>, CEECNPFCENP<GPLICHFNGAN<TMarker>>, CEECNPFCENP<EEJHDAKPMBH.OMBIMIGMEJF>) FHDDKIAJFPK<TMarker>(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<EMKFLDEHDOI> IPNOAJEKNFJ, [In] ReadOnlySpan<byte> FLKOGFDGJDF)
	{
		return default((CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>, CEECNPFCENP<GPLICHFNGAN<EMKFLDEHDOI>>, CEECNPFCENP<GPLICHFNGAN<DAIMPPKEFEB>>, CEECNPFCENP<GPLICHFNGAN<TMarker>>, CEECNPFCENP<EEJHDAKPMBH.OMBIMIGMEJF>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x1DEDDA0", Offset = "0x1DED1A0", VA = "0x181DEDDA0")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> GJNJIGFNIMK(this GIOLGACMMAA MEEBIDIALDO, int LCIAMFNJFEE, [Optional] CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>? CMFFGOOLLIJ)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1DED390", Offset = "0x1DEC790", VA = "0x181DED390")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> EHINOLCNAHG(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> LCIAMFNJFEE, [Optional] CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>? CMFFGOOLLIJ)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x1DEEA40", Offset = "0x1DEDE40", VA = "0x181DEEA40")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> JIMJAPHOHAP(this GIOLGACMMAA MEEBIDIALDO, [In] ReadOnlySpan<byte> LCIAMFNJFEE, [Optional] CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>? CMFFGOOLLIJ)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x1DED270", Offset = "0x1DEC670", VA = "0x181DED270")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> EGOLKICCIOL(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> LCIAMFNJFEE, int HIAJHKACHMC, [Optional] CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>? CMFFGOOLLIJ)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x1DEBFF0", Offset = "0x1DEB3F0", VA = "0x181DEBFF0")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> ABGPFCABGAK(this GIOLGACMMAA MEEBIDIALDO, float HOJDNHFFALP, float DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x1DEFB10", Offset = "0x1DEEF10", VA = "0x181DEFB10")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> MCIJNOJAEOH(this GIOLGACMMAA MEEBIDIALDO, float HOJDNHFFALP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x1DEE6E0", Offset = "0x1DEDAE0", VA = "0x181DEE6E0")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> IGHDDJJJCIL(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> HOJDNHFFALP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x1DEE4F0", Offset = "0x1DED8F0", VA = "0x181DEE4F0")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> HDAKNNAEBGO(this GIOLGACMMAA MEEBIDIALDO, int HOJDNHFFALP, int DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x1DEF9F0", Offset = "0x1DEEDF0", VA = "0x181DEF9F0")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> LNPFDOJDGDD(this GIOLGACMMAA MEEBIDIALDO, int HOJDNHFFALP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1DED130", Offset = "0x1DEC530", VA = "0x181DED130")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> EFKEKEHIMNM(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> HOJDNHFFALP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x1DEF710", Offset = "0x1DEEB10", VA = "0x181DEF710")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> LIHKHDMCBIO(this GIOLGACMMAA MEEBIDIALDO, int LCALDLBCJKP, int JPKPFNMFEIJ)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x1DEE5E0", Offset = "0x1DED9E0", VA = "0x181DEE5E0")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> HPBHJLKOGMG(this GIOLGACMMAA MEEBIDIALDO, int LCALDLBCJKP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> JPKPFNMFEIJ)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x1DED800", Offset = "0x1DECC00", VA = "0x181DED800")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> FDEMJBAECGA(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> LCALDLBCJKP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> JPKPFNMFEIJ)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x1DEEB30", Offset = "0x1DEDF30", VA = "0x181DEEB30")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> JJCPICIEMAA(this GIOLGACMMAA MEEBIDIALDO, float HOJDNHFFALP, float DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x1DEEDF0", Offset = "0x1DEE1F0", VA = "0x181DEEDF0")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> KCDGECHDIHH(this GIOLGACMMAA MEEBIDIALDO, float HOJDNHFFALP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x1DEF8B0", Offset = "0x1DEECB0", VA = "0x181DEF8B0")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> LNJACLGFFFN(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> HOJDNHFFALP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x1DEC450", Offset = "0x1DEB850", VA = "0x181DEC450")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> BLPPEBKOAPD(this GIOLGACMMAA MEEBIDIALDO, int HOJDNHFFALP, int DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x1DEC0F0", Offset = "0x1DEB4F0", VA = "0x181DEC0F0")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> ABOONCBMADE(this GIOLGACMMAA MEEBIDIALDO, int HOJDNHFFALP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x1DEF160", Offset = "0x1DEE560", VA = "0x181DEF160")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> KMEKHKNLHFE(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> HOJDNHFFALP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x1DECF10", Offset = "0x1DEC310", VA = "0x181DECF10")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> EAPLDIFFFMJ(this GIOLGACMMAA MEEBIDIALDO, float HOJDNHFFALP, float DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x1DED010", Offset = "0x1DEC410", VA = "0x181DED010")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> EDJAILIBHOI(this GIOLGACMMAA MEEBIDIALDO, float HOJDNHFFALP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1DF1230", Offset = "0x1DF0630", VA = "0x181DF1230")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> PPBHMOACDEC(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> HOJDNHFFALP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x1DF0690", Offset = "0x1DEFA90", VA = "0x181DF0690")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> NOJDMKOPNHA(this GIOLGACMMAA MEEBIDIALDO, int HOJDNHFFALP, int DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x1DEF3E0", Offset = "0x1DEE7E0", VA = "0x181DEF3E0")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> LBIGIHDLLEF(this GIOLGACMMAA MEEBIDIALDO, int HOJDNHFFALP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x1DF08A0", Offset = "0x1DEFCA0", VA = "0x181DF08A0")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> OCCPNKOGDFH(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> HOJDNHFFALP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x1DF0ED0", Offset = "0x1DF02D0", VA = "0x181DF0ED0")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> PGLGJPCGHOL(this GIOLGACMMAA MEEBIDIALDO, int PCGOHCLJAPN)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x1DF0B80", Offset = "0x1DEFF80", VA = "0x181DF0B80")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> PDLAEPFEJLO(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> PCGOHCLJAPN)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x1DEDE60", Offset = "0x1DED260", VA = "0x181DEDE60")]
	public static void GMKBEHBOAIA(this GIOLGACMMAA MEEBIDIALDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x1DF0DD0", Offset = "0x1DF01D0", VA = "0x181DF0DD0")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> PGIFEGDGFNH(this GIOLGACMMAA MEEBIDIALDO, float HOJDNHFFALP, float DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x1DEDC80", Offset = "0x1DED080", VA = "0x181DEDC80")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> GGCBMIHAHHJ(this GIOLGACMMAA MEEBIDIALDO, float HOJDNHFFALP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x1DF0C90", Offset = "0x1DF0090", VA = "0x181DF0C90")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> PFIHDDHPAKM(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> HOJDNHFFALP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x1DEF500", Offset = "0x1DEE900", VA = "0x181DEF500")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> LHMFFCPHJCL(this GIOLGACMMAA MEEBIDIALDO, int HOJDNHFFALP, int DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x1DED520", Offset = "0x1DEC920", VA = "0x181DED520")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> EOKHOAGPDOH(this GIOLGACMMAA MEEBIDIALDO, int HOJDNHFFALP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x1DEF020", Offset = "0x1DEE420", VA = "0x181DEF020")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> KLLIIAJIAGN(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> HOJDNHFFALP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x1DEC680", Offset = "0x1DEBA80", VA = "0x181DEC680")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> CDJBDFLCNLL(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> BIFNBPCFLAB, CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> IBNICNBCBOI)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x1DEE400", Offset = "0x1DED800", VA = "0x181DEE400")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> HCGCGAGMNKK(this GIOLGACMMAA MEEBIDIALDO, int HOJDNHFFALP, int DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x1DEF5F0", Offset = "0x1DEE9F0", VA = "0x181DEF5F0")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> LIBAGEEJEKP(this GIOLGACMMAA MEEBIDIALDO, int HOJDNHFFALP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1DEC540", Offset = "0x1DEB940", VA = "0x181DEC540")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> BOPFEAONCFP(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> HOJDNHFFALP, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> DLOKJGNOJLA)
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x290E950", Offset = "0x290DD50", VA = "0x18290E950")]
	public static void JDGPMHFENNB<TDeps, TState>(this GIOLGACMMAA MEEBIDIALDO, TDeps IGMHAFBOHAM, TState KDDFGNJPJNG, CEECNPFCENP<EBLILJDLKML> BDAIGOLMMPP, [In] ReadOnlySpan<CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO>> OHOAFBAPALF, [In] ReadOnlySpan<int?> DBIFGFENMFE, [In] Span<CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>> EBCPKCKHGEO, [In] Span<CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>> GCICAJDOFKB, [In] ReadOnlySpan<CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>?> FHACHNKPFHM) where TDeps : notnull, CPFMBLKBOIO<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x290C760", Offset = "0x290BB60", VA = "0x18290C760")]
	public static void ANMBIGKENGC<TDeps, TState>(this GIOLGACMMAA MEEBIDIALDO, TDeps IGMHAFBOHAM, TState KDDFGNJPJNG, CEECNPFCENP<HGNGFOEMFNG> KNFHKDLGIMJ, [In] ReadOnlySpan<CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO>> OHBFFKHIDCM, [In] ReadOnlySpan<int?> DBIFGFENMFE, [In] Span<CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>> EBCPKCKHGEO, [In] Span<CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>> GCICAJDOFKB, [In] ReadOnlySpan<CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>?> FHACHNKPFHM) where TDeps : notnull, CPFMBLKBOIO<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x290DC70", Offset = "0x290D070", VA = "0x18290DC70")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> HEPABLOPHBE<TDeps, TState>(this GIOLGACMMAA MEEBIDIALDO, TDeps IGMHAFBOHAM, TState KDDFGNJPJNG, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> EAPEECKGPAJ, [Optional] CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>? CMFFGOOLLIJ) where TDeps : notnull, CPFMBLKBOIO<TState> where TState : notnull
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x290CD90", Offset = "0x290C190", VA = "0x18290CD90")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> CJKJKNBGKBO<TDeps, TState>(this GIOLGACMMAA MEEBIDIALDO, TDeps IGMHAFBOHAM, TState KDDFGNJPJNG, CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> NMMFGFAJBDB, [Optional] CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>? CMFFGOOLLIJ) where TDeps : notnull, CPFMBLKBOIO<TState> where TState : notnull
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x290F100", Offset = "0x290E500", VA = "0x18290F100")]
	public static CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> OPKGKALAFBK<TDeps, TStateSys>(this GIOLGACMMAA MEEBIDIALDO, TDeps IGMHAFBOHAM, TStateSys JLAEHOODFAL) where TDeps : notnull, CPFMBLKBOIO<TStateSys> where TStateSys : notnull
	{
		return default(CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x290F370", Offset = "0x290E770", VA = "0x18290F370")]
	public static CEECNPFCENP<EKPLFECBDOC.BHPDJPACCLE> PPDKCEPFCJP<TDeps, TStateSys>(this GIOLGACMMAA MEEBIDIALDO, TDeps IGMHAFBOHAM, TStateSys JLAEHOODFAL) where TDeps : notnull, CPFMBLKBOIO<TStateSys> where TStateSys : notnull
	{
		return default(CEECNPFCENP<EKPLFECBDOC.BHPDJPACCLE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x1DEF2A0", Offset = "0x1DEE6A0", VA = "0x181DEF2A0")]
	public static CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> KPNFFLPPPII(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> AJNDCFCHIBB, IntPtr JHBNCNCDKOI, IntPtr EGCIAPAAJLO)
	{
		return default(CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x1DEFD30", Offset = "0x1DEF130", VA = "0x181DEFD30")]
	public static CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> NHCBDDAFHDM(this GIOLGACMMAA MEEBIDIALDO, CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> AGEBPIOCOCM, CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> NHGCELJIGIG, IntPtr MIJIDMEBHPB, IntPtr GFCDFJKJOMB, IntPtr FLCJBMNHLPP, bool CBMHLPNCKNC)
	{
		return default(CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x290D4D0", Offset = "0x290C8D0", VA = "0x18290D4D0")]
	public static CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> DANFOOBEJCG<TDeps, TState>(this GIOLGACMMAA MEEBIDIALDO, TDeps IGMHAFBOHAM, TState KDDFGNJPJNG, CEECNPFCENP<EBLILJDLKML> MBPCOCFGEOM, CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> AGEBPIOCOCM, CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> NHGCELJIGIG, int? CCIMJCCGNPD, [Optional] IntPtr DGIILLMEGLC) where TDeps : notnull, CPFMBLKBOIO<TState> where TState : notnull
	{
		return default(CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x290D1C0", Offset = "0x290C5C0", VA = "0x18290D1C0")]
	private static CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> DANFOOBEJCG<TDeps, TState>(this GIOLGACMMAA MEEBIDIALDO, TDeps IGMHAFBOHAM, TState KDDFGNJPJNG, CEECNPFCENP<EBLILJDLKML> MBPCOCFGEOM, CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> AGEBPIOCOCM, CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO> NHGCELJIGIG, int? CCIMJCCGNPD) where TDeps : notnull, CPFMBLKBOIO<TState> where TState : notnull
	{
		return default(CEECNPFCENP<POOHGCEHMHB.MLDCPHHACKO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x290E4D0", Offset = "0x290D8D0", VA = "0x18290E4D0")]
	public static CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> IKNMCIAAHAP<TDeps, TState>(this GIOLGACMMAA MEEBIDIALDO, TDeps IGMHAFBOHAM, TState KDDFGNJPJNG, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI> LCIAMFNJFEE, CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>? CMFFGOOLLIJ) where TDeps : notnull, CPFMBLKBOIO<TState> where TState : notnull
	{
		return default(CEECNPFCENP<IMNGEGPBJMM.KKCFPHOJMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x290DE30", Offset = "0x290D230", VA = "0x18290DE30")]
	public static void HLCIGAHLOCI<TDeps, TState>(this GIOLGACMMAA MEEBIDIALDO, TDeps IGMHAFBOHAM, TState KDDFGNJPJNG, int AALOBLLJNJP) where TDeps : notnull, CPFMBLKBOIO<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct EGEJCHGMBON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>> ILHCILENCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>> MKDCGBNPKKK;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0xAEAF20", Offset = "0xAEA320", VA = "0x180AEAF20")]
	public EGEJCHGMBON(CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>> KCANIPADLNC, CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>> BHNMLKLBDOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x1DE7DB0", Offset = "0x1DE71B0", VA = "0x181DE7DB0")]
	public static EGEJCHGMBON HGJFOBLHCKL(CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>> KCANIPADLNC)
	{
		return default(EGEJCHGMBON);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct IMNGEGPBJMM
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class GMDGNBNDLCP : PGCAIGCGFEJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct FFFBOLLKOHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public CEECNPFCENP<EEJHDAKPMBH.OMBIMIGMEJF> PCNPNHFPKPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int LCMFLKBKPPA;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xAEAF20", Offset = "0xAEA320", VA = "0x180AEAF20")]
		public FFFBOLLKOHD(CEECNPFCENP<EEJHDAKPMBH.OMBIMIGMEJF> JDOCENAFBMB, int PMLKPJNGBAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class OGAAOKEMGHF : PGCAIGCGFEJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct DNKBMIHFDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int LCMFLKBKPPA;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x919AC0", Offset = "0x918EC0", VA = "0x180919AC0")]
		public DNKBMIHFDPB(int PMLKPJNGBAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class LKKJPOCIHAN : PGCAIGCGFEJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct LLBIHCKNKHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public CEECNPFCENP<EEJHDAKPMBH.OMBIMIGMEJF> PCNPNHFPKPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int LCMFLKBKPPA;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xAEAF20", Offset = "0xAEA320", VA = "0x180AEAF20")]
		public LLBIHCKNKHM(CEECNPFCENP<EEJHDAKPMBH.OMBIMIGMEJF> JDOCENAFBMB, int PMLKPJNGBAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum HFMAEGMDLDB
	{
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		Temporary,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		Named,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		Argument,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		CallerReturnValue,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		Parameter,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		CalleeReturnValue
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class KKCFPHOJMHI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class PGCAIGCGFEJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct FEDLDFGPFAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? HKPDPMFOLKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public EGEJCHGMBON MJFDFMPLKEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public HFMAEGMDLDB MCCIAOABKEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public CEECNPFCENP<PGCAIGCGFEJ> HNOOLGJOBNJ;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x1DE8070", Offset = "0x1DE7470", VA = "0x181DE8070")]
		public FEDLDFGPFAO(int? MLIEIOHNACG, [In] EGEJCHGMBON BFINAIMADEN, HFMAEGMDLDB MEOGECGECNG, CEECNPFCENP<PGCAIGCGFEJ> PNCPDELJLJB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class JLGIKMLIMPF : PGCAIGCGFEJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct OFLLLDNBFLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int LCMFLKBKPPA;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x919AC0", Offset = "0x918EC0", VA = "0x180919AC0")]
		public OFLLLDNBFLL(int PMLKPJNGBAD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal LBLHPFPBPOB<KKCFPHOJMHI, FEDLDFGPFAO> MKLGJPJHMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal LBLHPFPBPOB<GMDGNBNDLCP, FFFBOLLKOHD> GJPKLIGOFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal LBLHPFPBPOB<LKKJPOCIHAN, LLBIHCKNKHM> JGHNMHLJODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal LBLHPFPBPOB<JLGIKMLIMPF, OFLLLDNBFLL> BDOANABGHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal LBLHPFPBPOB<OGAAOKEMGHF, DNKBMIHFDPB> KEACMMEPOMF;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x1DE98E0", Offset = "0x1DE8CE0", VA = "0x181DE98E0")]
	private IMNGEGPBJMM([In] LBLHPFPBPOB<KKCFPHOJMHI, FEDLDFGPFAO> FMGNOEKBHLB, [In] LBLHPFPBPOB<GMDGNBNDLCP, FFFBOLLKOHD> GOJEJLAIMOL, [In] LBLHPFPBPOB<LKKJPOCIHAN, LLBIHCKNKHM> ICKKHMHOKBD, [In] LBLHPFPBPOB<JLGIKMLIMPF, OFLLLDNBFLL> CCDFODBNGOF, [In] LBLHPFPBPOB<OGAAOKEMGHF, DNKBMIHFDPB> CLMDFABFFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x1DE96F0", Offset = "0x1DE8AF0", VA = "0x181DE96F0")]
	public static IMNGEGPBJMM HGJFOBLHCKL()
	{
		return default(IMNGEGPBJMM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class IJLLJCKCKAO
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x1DE9640", Offset = "0x1DE8A40", VA = "0x181DE9640")]
	public static void FHLEEDLMEFH(this IMNGEGPBJMM MEEBIDIALDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class ELJFNJLKBAC
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x1DE7E90", Offset = "0x1DE7290", VA = "0x181DE7E90")]
	public static void KFNIOKHILDK(GIOLGACMMAA MEEBIDIALDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct DPIHGHODABF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal HMEBJJCHPDI<EEJHDAKPMBH.AIACDIENCOD, EGAODOHLKID> HGNCBOBEMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int JNBLGOOMFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int HOLLEIFFDEM;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x1DE7A10", Offset = "0x1DE6E10", VA = "0x181DE7A10")]
	private DPIHGHODABF([In] HMEBJJCHPDI<EEJHDAKPMBH.AIACDIENCOD, EGAODOHLKID> ANIEHJEKMFC, int JMIEEAFJPGL, int LCIAKKODHFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x1DE79A0", Offset = "0x1DE6DA0", VA = "0x181DE79A0")]
	public static DPIHGHODABF HGJFOBLHCKL()
	{
		return default(DPIHGHODABF);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x1DE77D0", Offset = "0x1DE6BD0", VA = "0x181DE77D0")]
	public void FHLEEDLMEFH([In] GIOLGACMMAA NDLDDDGLLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x26696B0", Offset = "0x2668AB0", VA = "0x1826696B0")]
	public static void KFNIOKHILDK<TDeps, TStateSys>(GIOLGACMMAA MEEBIDIALDO, TDeps IGMHAFBOHAM, TStateSys JLAEHOODFAL, CEECNPFCENP<MCMKDNBCCKK> CBNAIGKNIGK) where TDeps : notnull, CPFMBLKBOIO<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class NECDMGCKBGH
{
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x1DF1370", Offset = "0x1DF0770", VA = "0x181DF1370")]
	public static void KFNIOKHILDK(GIOLGACMMAA MEEBIDIALDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct NJDLIHONJEL
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface JKNIKOKEMHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NNALOMJJFLM(OONLFEIMAID<byte> JIEKKNLIPGI, int ICODMPICENM);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct HEIOOPAJBFO : JKNIKOKEMHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x1DE9480", Offset = "0x1DE8880", VA = "0x181DE9480", Slot = "4")]
		public void NNALOMJJFLM(OONLFEIMAID<byte> JIEKKNLIPGI, int ICODMPICENM)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct NFGDCGDJEMM : JKNIKOKEMHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x1DF1520", Offset = "0x1DF0920", VA = "0x181DF1520", Slot = "4")]
		public void NNALOMJJFLM(OONLFEIMAID<byte> JIEKKNLIPGI, int ICODMPICENM)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct BMLPBBMANLD : JKNIKOKEMHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x1DE7420", Offset = "0x1DE6820", VA = "0x181DE7420", Slot = "4")]
		public void NNALOMJJFLM(OONLFEIMAID<byte> JIEKKNLIPGI, int ICODMPICENM)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct MNCJKCJFOCE : JKNIKOKEMHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x1DEBEB0", Offset = "0x1DEB2B0", VA = "0x181DEBEB0", Slot = "4")]
		public void NNALOMJJFLM(OONLFEIMAID<byte> JIEKKNLIPGI, int ICODMPICENM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class IDGICAHBEPF<TCallProcessorDeps> where TCallProcessorDeps : struct, JKNIKOKEMHB
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps ECGBFCNDIAL;

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x24AEB00", Offset = "0x24ADF00", VA = "0x1824AEB00")]
		public static int KFNIOKHILDK<TDeps, TStateSys>(TDeps IGMHAFBOHAM, TStateSys KDDFGNJPJNG, GIOLGACMMAA NDLDDDGLLLC, [In] OONLFEIMAID<byte> EFILCKHOCFA, int NKOFDDBKOBN) where TDeps : CPFMBLKBOIO<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private OONLFEIMAID<LFKNGIPMNFG> CMANCDNDMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>, CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD>> JAIOKKMNGOC;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1DF16C0", Offset = "0x1DF0AC0", VA = "0x181DF16C0")]
	private NJDLIHONJEL([In] OONLFEIMAID<LFKNGIPMNFG> AIGGCPJHJJL, Dictionary<CEECNPFCENP<GPLICHFNGAN<LFEKFFGAHDG>>, CEECNPFCENP<EEJHDAKPMBH.AIACDIENCOD>> BAFAMMJGMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x1DF1600", Offset = "0x1DF0A00", VA = "0x181DF1600")]
	public static NJDLIHONJEL HGJFOBLHCKL()
	{
		return default(NJDLIHONJEL);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x1DF15C0", Offset = "0x1DF09C0", VA = "0x181DF15C0")]
	public void FHLEEDLMEFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x29207B0", Offset = "0x291FBB0", VA = "0x1829207B0")]
	public static void KFNIOKHILDK<TDeps, TStateSys>(GIOLGACMMAA MEEBIDIALDO, TDeps IGMHAFBOHAM, TStateSys JLAEHOODFAL) where TDeps : CPFMBLKBOIO<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class MMDCFELCHHF<TDeps, TIndex, TValues> where TDeps : struct, FANNNGGJAFG<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly TDeps ECGBFCNDIAL;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3F0EC30", Offset = "0x3F0E030", VA = "0x183F0EC30")]
	public static void KFNIOKHILDK([In] OONLFEIMAID<LFKNGIPMNFG> AIGGCPJHJJL, int AOMBMAHFCEG, TValues JFCBPFNIMNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface FANNNGGJAFG<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OONLFEIMAID<TIndex> EMONFMKIPBM(int AOMBMAHFCEG, [In] TValues JFCBPFNIMNJ);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>> JMIHOLOKADE(TIndex PMLKPJNGBAD, [In] TValues JFCBPFNIMNJ);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KAOPFFOGNAE(TIndex PMLKPJNGBAD, TValues JFCBPFNIMNJ, CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>> PCGOHCLJAPN);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface LODFJPMFNBF<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex EIDGOCEHHFK(int PMLKPJNGBAD);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JDKNGNHNPOJ(TIndex PMLKPJNGBAD, [In] TValues JFCBPFNIMNJ);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CEECNPFCENP<GPLICHFNGAN<COGFAOPINMA>> JMIHOLOKADE(TIndex PMLKPJNGBAD, [In] TValues JFCBPFNIMNJ);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class MGBEBPMHDPB<TDeps, TIndex, TValues> where TDeps : struct, LODFJPMFNBF<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly TDeps ECGBFCNDIAL;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x3EF9790", Offset = "0x3EF8B90", VA = "0x183EF9790")]
	public static OONLFEIMAID<TIndex> KFNIOKHILDK(int AOMBMAHFCEG, [In] TValues JFCBPFNIMNJ)
	{
		return default(OONLFEIMAID<TIndex>);
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
