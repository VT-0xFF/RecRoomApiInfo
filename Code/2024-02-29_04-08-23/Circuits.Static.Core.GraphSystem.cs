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
		[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D95080", Offset = "0x1D93E80", VA = "0x181D95080")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D4330", Offset = "0x7D3130", VA = "0x1807D4330")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D4370", Offset = "0x7D3170", VA = "0x1807D4370")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct OIDCBGAKKOH<TMInput, TMOutput, TMNode> : IEnumerator<HIGDJMOGOKB<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private MHLJMGFLLGH<TMInput, TMOutput, TMNode> ICPCCHCPCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private MIIIAKKECIA<TMInput, TMOutput, TMNode> LLNGFPPIHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private bool CLGCKJNMELL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly HIGDJMOGOKB<TMNode> ODMJFPGIBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3F6A550", Offset = "0x3F69350", VA = "0x183F6A550", Slot = "4")]
		get
		{
			return default(HIGDJMOGOKB<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3F6A3F0", Offset = "0x3F691F0", VA = "0x183F6A3F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3F6A480", Offset = "0x3F69280", VA = "0x183F6A480")]
	internal OIDCBGAKKOH([In] MHLJMGFLLGH<TMInput, TMOutput, TMNode> NOGAGBMAPKC, [In] MIIIAKKECIA<TMInput, TMOutput, TMNode> DBALCEGJHHC, bool EKONPJBECPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3F6A2B0", Offset = "0x3F690B0", VA = "0x183F6A2B0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3F6A370", Offset = "0x3F69170", VA = "0x183F6A370", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3F6A230", Offset = "0x3F69030", VA = "0x183F6A230", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class MHNMHBNBJGK
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x27B5600", Offset = "0x27B4400", VA = "0x1827B5600")]
	public static OIDCBGAKKOH<TMInput, TMOutput, TMNode> KJKFMOENPNA<TMInput, TMOutput, TMNode>([In] PILAEKCBOGM<TMInput, TMOutput, TMNode> CNAAICLGIKB, HIGDJMOGOKB<TMNode> IBLKHIACFEF)
	{
		return default(OIDCBGAKKOH<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct MIIIAKKECIA<TMInput, TMOutput, TMNode> : IEnumerator<HIGDJMOGOKB<TMInput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private LGHDEKJBNJM<HIGDJMOGOKB<TMOutput>>.BFENMFFNOCG PPHFLGIBAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private LGHDEKJBNJM<HIGDJMOGOKB<TMInput>>.BFENMFFNOCG KOLMJBBLJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly NKNFEIMPDLM<TMInput, TMOutput, TMNode> HNLLCEMNANK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public HIGDJMOGOKB<TMInput> ODMJFPGIBHC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3DE6330", Offset = "0x3DE5130", VA = "0x183DE6330", Slot = "4")]
		get
		{
			return default(HIGDJMOGOKB<TMInput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3DE6200", Offset = "0x3DE5000", VA = "0x183DE6200", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3DE62B0", Offset = "0x3DE50B0", VA = "0x183DE62B0")]
	internal MIIIAKKECIA([In] LGHDEKJBNJM<HIGDJMOGOKB<TMOutput>>.BFENMFFNOCG IFLAMLJKONP, [In] LGHDEKJBNJM<HIGDJMOGOKB<TMInput>>.BFENMFFNOCG DOCBJODGKNL, [In] NKNFEIMPDLM<TMInput, TMOutput, TMNode> MIDLLPANDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3DE6030", Offset = "0x3DE4E30", VA = "0x183DE6030", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3DE6190", Offset = "0x3DE4F90", VA = "0x183DE6190", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3DE5FC0", Offset = "0x3DE4DC0", VA = "0x183DE5FC0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NOLPHAGGCHP
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2836610", Offset = "0x2835410", VA = "0x182836610")]
	public static MIIIAKKECIA<TMInput, TMOutput, TMNode> KJKFMOENPNA<TMInput, TMOutput, TMNode>([In] PILAEKCBOGM<TMInput, TMOutput, TMNode> CNAAICLGIKB, HIGDJMOGOKB<TMNode> IBLKHIACFEF)
	{
		return default(MIIIAKKECIA<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct MHLJMGFLLGH<TMInput, TMOutput, TMNode> : IEnumerator<HIGDJMOGOKB<TMOutput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private LGHDEKJBNJM<HIGDJMOGOKB<TMInput>>.BFENMFFNOCG ADJONCEJAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private LGHDEKJBNJM<HIGDJMOGOKB<TMOutput>>.BFENMFFNOCG FNKIJPKNLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly MIADAGOPJHB<TMInput, TMOutput, TMNode> DGLPGGCKNFM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public HIGDJMOGOKB<TMOutput> ODMJFPGIBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3DE6330", Offset = "0x3DE5130", VA = "0x183DE6330", Slot = "4")]
		get
		{
			return default(HIGDJMOGOKB<TMOutput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3DE6200", Offset = "0x3DE5000", VA = "0x183DE6200", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3DE62B0", Offset = "0x3DE50B0", VA = "0x183DE62B0")]
	internal MHLJMGFLLGH([In] LGHDEKJBNJM<HIGDJMOGOKB<TMInput>>.BFENMFFNOCG BFBHEDNLPKG, [In] LGHDEKJBNJM<HIGDJMOGOKB<TMOutput>>.BFENMFFNOCG DBMOEDEMNAC, [In] MIADAGOPJHB<TMInput, TMOutput, TMNode> LNIGABDEMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3DE6030", Offset = "0x3DE4E30", VA = "0x183DE6030", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3DE6190", Offset = "0x3DE4F90", VA = "0x183DE6190", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3DE5FC0", Offset = "0x3DE4DC0", VA = "0x183DE5FC0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class OKPFDFNAEML
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2858020", Offset = "0x2856E20", VA = "0x182858020")]
	public static MHLJMGFLLGH<TMInput, TMOutput, TMNode> KJKFMOENPNA<TMInput, TMOutput, TMNode>([In] PILAEKCBOGM<TMInput, TMOutput, TMNode> CNAAICLGIKB, HIGDJMOGOKB<TMNode> IBLKHIACFEF)
	{
		return default(MHLJMGFLLGH<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct PILAEKCBOGM<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public MIADAGOPJHB<TMInput, TMOutput, TMNode> DFKAJLOBNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public NKNFEIMPDLM<TMInput, TMOutput, TMNode> BBDPMGGPADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public FAJDBPCNIJK<TMInput, TMOutput, TMNode> NBCDCJBFEEO;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4046520", Offset = "0x4045320", VA = "0x184046520")]
	internal PILAEKCBOGM([In] MIADAGOPJHB<TMInput, TMOutput, TMNode> LNIGABDEMDD, [In] NKNFEIMPDLM<TMInput, TMOutput, TMNode> MIDLLPANDIG, [In] FAJDBPCNIJK<TMInput, TMOutput, TMNode> EIGKMPBMGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4046270", Offset = "0x4045070", VA = "0x184046270")]
	public static PILAEKCBOGM<TMInput?, TMOutput?, TMNode?> KJKFMOENPNA()
	{
		return default(PILAEKCBOGM<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class GOBGFMLCLLJ
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x26FF270", Offset = "0x26FE070", VA = "0x1826FF270")]
	public static JFJCIBBDBEJ? FILLENIGNNA<TMInput, TMOutput, TMNode>([In] this PILAEKCBOGM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x26FED90", Offset = "0x26FDB90", VA = "0x1826FED90")]
	public static PILAEKCBOGM<TMInput?, TMOutput?, TMNode?> CINNELLPCMC<TMInput, TMOutput, TMNode>(this JFJCIBBDBEJ CNFBJPGPBBJ)
	{
		return default(PILAEKCBOGM<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x26FF1B0", Offset = "0x26FDFB0", VA = "0x1826FF1B0")]
	public static void ECEAPGIDAKG<TMInput, TMOutput, TMNode>(this PILAEKCBOGM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x26FFA20", Offset = "0x26FE820", VA = "0x1826FFA20")]
	public static void OHEJNBNNFHP<TMInput, TMOutput, TMNode>(this PILAEKCBOGM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMOutput> BHOLNNCCCAL, HIGDJMOGOKB<TMInput> HOCLDJFDFEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x26FF210", Offset = "0x26FE010", VA = "0x1826FF210")]
	public static void EOHBIGELOPC<TMInput, TMOutput, TMNode>(this PILAEKCBOGM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMOutput> BHOLNNCCCAL, HIGDJMOGOKB<TMInput> HOCLDJFDFEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x26FF360", Offset = "0x26FE160", VA = "0x1826FF360")]
	public static bool GPMHAHCKBCB<TMInput, TMOutput, TMNode>([In] this PILAEKCBOGM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMOutput> BHOLNNCCCAL, HIGDJMOGOKB<TMInput> HOCLDJFDFEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x26FF4D0", Offset = "0x26FE2D0", VA = "0x1826FF4D0")]
	public static HIGDJMOGOKB<TMNode?> HPAJPMDMJEG<TMNode, TMInput, TMOutput>(this PILAEKCBOGM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ)
	{
		return default(HIGDJMOGOKB<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x26FF800", Offset = "0x26FE600", VA = "0x1826FF800")]
	public static void LJNNPFHCFIF<TMInput, TMOutput, TMNode>(this PILAEKCBOGM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMNode> IBLKHIACFEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x26FF9B0", Offset = "0x26FE7B0", VA = "0x1826FF9B0")]
	public static HIGDJMOGOKB<TMInput?> NJDHFIAMEFD<TMInput, TMOutput, TMNode>(this PILAEKCBOGM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMNode> IBLKHIACFEF)
	{
		return default(HIGDJMOGOKB<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x26FFA80", Offset = "0x26FE880", VA = "0x1826FFA80")]
	public static HIGDJMOGOKB<TMOutput?> OIEALAOPMBA<TMOutput, TMInput, TMNode>(this PILAEKCBOGM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMNode> IBLKHIACFEF)
	{
		return default(HIGDJMOGOKB<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x26FFB80", Offset = "0x26FE980", VA = "0x1826FFB80")]
	public static HIGDJMOGOKB<TMInput?> PJGFOAGHLJJ<TMInput, TMOutput, TMNode>(this PILAEKCBOGM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMNode> IBLKHIACFEF, int ENPOKNEMOMH)
	{
		return default(HIGDJMOGOKB<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x26FFB00", Offset = "0x26FE900", VA = "0x1826FFB00")]
	public static HIGDJMOGOKB<TMOutput?> OLBJEBHDMPE<TMOutput, TMInput, TMNode>(this PILAEKCBOGM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMNode> IBLKHIACFEF, int ENPOKNEMOMH)
	{
		return default(HIGDJMOGOKB<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x26FF910", Offset = "0x26FE710", VA = "0x1826FF910")]
	public static void LNKPKFHBDAL<TMInput, TMOutput, TMNode>(this PILAEKCBOGM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMNode> IBLKHIACFEF, int BINJLNJCCHL, int PDEAGLIJHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x26FF430", Offset = "0x26FE230", VA = "0x1826FF430")]
	public static void HEEDIDHHIDI<TMInput, TMOutput, TMNode>(this PILAEKCBOGM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMNode> IBLKHIACFEF, int BINJLNJCCHL, int PDEAGLIJHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x26FECA0", Offset = "0x26FDAA0", VA = "0x1826FECA0")]
	public static void CEADNKLOIBI<TMInput, TMOutput, TMNode>(this PILAEKCBOGM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMInput> PABKLBOPHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x26FEB50", Offset = "0x26FD950", VA = "0x1826FEB50")]
	public static void ABIGDLBNKGO<TMInput, TMOutput, TMNode>(this PILAEKCBOGM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMOutput> DGADLNLIIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x87F3D0", Offset = "0x87E1D0", VA = "0x18087F3D0")]
	public static HNMIFFNBPEC<TMInput?> NFCFDDBEHBI<TMInput, TMOutput, TMNode>([In] this PILAEKCBOGM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ)
	{
		return default(HNMIFFNBPEC<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x26FFAF0", Offset = "0x26FE8F0", VA = "0x1826FFAF0")]
	public static HNMIFFNBPEC<TMOutput?> OINIICKJDMO<TMOutput, TMInput, TMNode>([In] this PILAEKCBOGM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ)
	{
		return default(HNMIFFNBPEC<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x26FF350", Offset = "0x26FE150", VA = "0x1826FF350")]
	public static HNMIFFNBPEC<TMNode?> GBPNDJMFCCO<TMNode, TMInput, TMOutput>([In] this PILAEKCBOGM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ)
	{
		return default(HNMIFFNBPEC<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x26FEC30", Offset = "0x26FDA30", VA = "0x1826FEC30")]
	public static MIIIAKKECIA<TMInput?, TMOutput?, TMNode?> LNKHNMOPNEP<TMInput, TMOutput, TMNode>([In] this PILAEKCBOGM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMNode> DGIBOINMLED)
	{
		return default(MIIIAKKECIA<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x26FEC30", Offset = "0x26FDA30", VA = "0x1826FEC30")]
	public static MHLJMGFLLGH<TMInput?, TMOutput?, TMNode?> BKNOJPGPANH<TMInput, TMOutput, TMNode>([In] this PILAEKCBOGM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMNode> DGIBOINMLED)
	{
		return default(MHLJMGFLLGH<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x26FF100", Offset = "0x26FDF00", VA = "0x1826FF100")]
	public static OIDCBGAKKOH<TMInput?, TMOutput?, TMNode?> DBDPEAOMIAN<TMInput, TMOutput, TMNode>([In] this PILAEKCBOGM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMNode> DGIBOINMLED)
	{
		return default(OIDCBGAKKOH<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x26FF6F0", Offset = "0x26FE4F0", VA = "0x1826FF6F0")]
	public static JMBDNNCCPGJ<HIGDJMOGOKB<TMInput?>, MIIIAKKECIA<TMInput?, TMOutput?, TMNode?>> JKODCOGBBEE<TMInput, TMOutput, TMNode>([In] this PILAEKCBOGM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMNode> DGIBOINMLED)
	{
		return default(JMBDNNCCPGJ<HIGDJMOGOKB<TMInput>, MIIIAKKECIA<TMInput, TMOutput, TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x26FF560", Offset = "0x26FE360", VA = "0x1826FF560")]
	public static JMBDNNCCPGJ<HIGDJMOGOKB<TMNode?>, OIDCBGAKKOH<TMInput?, TMOutput?, TMNode?>> IEMCILGJLCL<TMNode, TMInput, TMOutput>([In] this PILAEKCBOGM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMNode> DGIBOINMLED)
	{
		return default(JMBDNNCCPGJ<HIGDJMOGOKB<TMNode>, OIDCBGAKKOH<TMInput, TMOutput, TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct MIADAGOPJHB<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal HNMIFFNBPEC<TMInput> BDJPEAFBMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal FKJDGDHDMEC<TMInput, HIGDJMOGOKB<TMNode>> MHCMMBEACAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal FKJDGDHDMEC<TMInput, LGHDEKJBNJM<HIGDJMOGOKB<TMOutput>>> HNLLCEMNANK;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x359F0B0", Offset = "0x359DEB0", VA = "0x18359F0B0")]
	internal MIADAGOPJHB([In] HNMIFFNBPEC<TMInput> BALAIOLAJGB, [In] FKJDGDHDMEC<TMInput, HIGDJMOGOKB<TMNode>> EIGKMPBMGAG, [In] FKJDGDHDMEC<TMInput, LGHDEKJBNJM<HIGDJMOGOKB<TMOutput>>> MIDLLPANDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x359EEF0", Offset = "0x359DCF0", VA = "0x18359EEF0")]
	internal static MIADAGOPJHB<TMInput, TMOutput, TMNode> KJKFMOENPNA()
	{
		return default(MIADAGOPJHB<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class GMDFENPMGAD
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x26F7650", Offset = "0x26F6450", VA = "0x1826F7650")]
	internal static JPDCBICPKFC FILLENIGNNA<TMInput, TMOutput, TMNode>([In] this MIADAGOPJHB<TMInput, TMOutput, TMNode> CNFBJPGPBBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x26F6FB0", Offset = "0x26F5DB0", VA = "0x1826F6FB0")]
	internal static MIADAGOPJHB<TMInput, TMOutput, TMNode> CINNELLPCMC<TMInput, TMOutput, TMNode>(this JPDCBICPKFC CNFBJPGPBBJ)
	{
		return default(MIADAGOPJHB<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x26F79E0", Offset = "0x26F67E0", VA = "0x1826F79E0")]
	private static OJDPHEBCCKL FNDBEBIJAGE<TMOutput>([In] this LGHDEKJBNJM<HIGDJMOGOKB<TMOutput>> CNFBJPGPBBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x26F7BB0", Offset = "0x26F69B0", VA = "0x1826F7BB0")]
	private static LGHDEKJBNJM<HIGDJMOGOKB<TMOutput>> GNBEKCLPEDN<TMOutput>(this OJDPHEBCCKL CNFBJPGPBBJ)
	{
		return default(LGHDEKJBNJM<HIGDJMOGOKB<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x26F74C0", Offset = "0x26F62C0", VA = "0x1826F74C0")]
	internal static void ECEAPGIDAKG<TMInput, TMOutput, TMNode>(this MIADAGOPJHB<TMInput, TMOutput, TMNode> CNFBJPGPBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x26F7E30", Offset = "0x26F6C30", VA = "0x1826F7E30")]
	internal static HIGDJMOGOKB<TMInput> IHOEEIJHHEK<TMInput, TMOutput, TMNode>(this MIADAGOPJHB<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMNode> ACNLHBNEANJ)
	{
		return default(HIGDJMOGOKB<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x26F7EF0", Offset = "0x26F6CF0", VA = "0x1826F7EF0")]
	internal static void PHNBJIDPAFI<TMInput, TMOutput, TMNode>(this MIADAGOPJHB<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMInput> DGIBOINMLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x24E28B0", Offset = "0x24E16B0", VA = "0x1824E28B0")]
	public static bool BEFJOKMDIPF<TMInput, TMOutput, TMNode>([In] this MIADAGOPJHB<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMInput> DGIBOINMLED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x224E700", Offset = "0x224D500", VA = "0x18224E700")]
	public static int AIFGPJKHHPG<TMInput, TMOutput, TMNode>([In] this MIADAGOPJHB<TMInput, TMOutput, TMNode> CNFBJPGPBBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x26F7ED0", Offset = "0x26F6CD0", VA = "0x1826F7ED0")]
	public static HIGDJMOGOKB<TMNode> JHGFAAKMFHL<TMNode, TMInput, TMOutput>([In] this MIADAGOPJHB<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMInput> DGIBOINMLED)
	{
		return default(HIGDJMOGOKB<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x24E3B20", Offset = "0x24E2920", VA = "0x1824E3B20")]
	public static int LCAAIPGEBFI<TMInput, TMOutput, TMNode>([In] this MIADAGOPJHB<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMInput> DGIBOINMLED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x24E3B60", Offset = "0x24E2960", VA = "0x1824E3B60")]
	public static HIGDJMOGOKB<TMOutput> MBLCPAKIEEL<TMOutput, TMInput, TMNode>([In] this MIADAGOPJHB<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMInput> DGIBOINMLED, int ENPOKNEMOMH)
	{
		return default(HIGDJMOGOKB<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x24E28D0", Offset = "0x24E16D0", VA = "0x1824E28D0")]
	internal static void PDIHOBPNOPL<TMInput, TMOutput, TMNode>(this MIADAGOPJHB<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMInput> DGIBOINMLED, HIGDJMOGOKB<TMOutput> DGADLNLIIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x24E28D0", Offset = "0x24E16D0", VA = "0x1824E28D0")]
	internal static void BNMNMDOIMLB<TMInput, TMOutput, TMNode>(this MIADAGOPJHB<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMInput> DGIBOINMLED, HIGDJMOGOKB<TMOutput> DGADLNLIIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x24E2ED0", Offset = "0x24E1CD0", VA = "0x1824E2ED0")]
	public static LGHDEKJBNJM<HIGDJMOGOKB<TMOutput>>.BFENMFFNOCG CNCIAGICNBL<TMOutput, TMInput, TMNode>([In] this MIADAGOPJHB<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMInput> DGIBOINMLED)
	{
		return default(LGHDEKJBNJM<HIGDJMOGOKB<TMOutput>>.BFENMFFNOCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x24E2ED0", Offset = "0x24E1CD0", VA = "0x1824E2ED0")]
	public static MJOPIHFOANL<HIGDJMOGOKB<TMOutput>, LGHDEKJBNJM<HIGDJMOGOKB<TMOutput>>.BFENMFFNOCG> NNHOODLCNKL<TMOutput, TMInput, TMNode>([In] this MIADAGOPJHB<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMInput> DGIBOINMLED)
	{
		return default(MJOPIHFOANL<HIGDJMOGOKB<TMOutput>, LGHDEKJBNJM<HIGDJMOGOKB<TMOutput>>.BFENMFFNOCG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct FAJDBPCNIJK<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal HNMIFFNBPEC<TMNode> BDJPEAFBMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal FKJDGDHDMEC<TMNode, LGHDEKJBNJM<HIGDJMOGOKB<TMInput>>> DGLPGGCKNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal FKJDGDHDMEC<TMNode, LGHDEKJBNJM<HIGDJMOGOKB<TMOutput>>> HNLLCEMNANK;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x359F0B0", Offset = "0x359DEB0", VA = "0x18359F0B0")]
	internal FAJDBPCNIJK([In] HNMIFFNBPEC<TMNode> BALAIOLAJGB, [In] FKJDGDHDMEC<TMNode, LGHDEKJBNJM<HIGDJMOGOKB<TMInput>>> LNIGABDEMDD, [In] FKJDGDHDMEC<TMNode, LGHDEKJBNJM<HIGDJMOGOKB<TMOutput>>> MIDLLPANDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x359EEF0", Offset = "0x359DCF0", VA = "0x18359EEF0")]
	internal static FAJDBPCNIJK<TMInput, TMOutput, TMNode> KJKFMOENPNA()
	{
		return default(FAJDBPCNIJK<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class BALPPCIHJAB
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x24E34C0", Offset = "0x24E22C0", VA = "0x1824E34C0")]
	internal static LNPLJAMHMFF FILLENIGNNA<TMInput, TMOutput, TMNode>([In] this FAJDBPCNIJK<TMInput, TMOutput, TMNode> CNFBJPGPBBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x24E2910", Offset = "0x24E1710", VA = "0x1824E2910")]
	internal static FAJDBPCNIJK<TMInput, TMOutput, TMNode> CINNELLPCMC<TMInput, TMOutput, TMNode>(this LNPLJAMHMFF CNFBJPGPBBJ)
	{
		return default(FAJDBPCNIJK<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x24E3C40", Offset = "0x24E2A40", VA = "0x1824E3C40")]
	private static KGGGLCHPKCP PCCCDMJPBGA<TMInput>([In] this LGHDEKJBNJM<HIGDJMOGOKB<TMInput>> CNFBJPGPBBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x24E3ED0", Offset = "0x24E2CD0", VA = "0x1824E3ED0")]
	private static LGHDEKJBNJM<HIGDJMOGOKB<TMInput>> PLOFDLLFCNF<TMInput>(this KGGGLCHPKCP CNFBJPGPBBJ)
	{
		return default(LGHDEKJBNJM<HIGDJMOGOKB<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x24E3880", Offset = "0x24E2680", VA = "0x1824E3880")]
	private static CJHOJBIIBME FPDIDMLNKPB<TMOutput>([In] this LGHDEKJBNJM<HIGDJMOGOKB<TMOutput>> CNFBJPGPBBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x24E3240", Offset = "0x24E2040", VA = "0x1824E3240")]
	private static LGHDEKJBNJM<HIGDJMOGOKB<TMOutput>> ENDOEJHKELC<TMOutput>(this CJHOJBIIBME CNFBJPGPBBJ)
	{
		return default(LGHDEKJBNJM<HIGDJMOGOKB<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x24E2F80", Offset = "0x24E1D80", VA = "0x1824E2F80")]
	internal static void ECEAPGIDAKG<TMInput, TMOutput, TMNode>(this FAJDBPCNIJK<TMInput, TMOutput, TMNode> CNFBJPGPBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x24E3A50", Offset = "0x24E2850", VA = "0x1824E3A50")]
	internal static HIGDJMOGOKB<TMNode> IHOEEIJHHEK<TMNode, TMInput, TMOutput>(this FAJDBPCNIJK<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, [In] LGHDEKJBNJM<HIGDJMOGOKB<TMInput>> LNIGABDEMDD, [In] LGHDEKJBNJM<HIGDJMOGOKB<TMOutput>> MIDLLPANDIG)
	{
		return default(HIGDJMOGOKB<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x24E3E10", Offset = "0x24E2C10", VA = "0x1824E3E10")]
	internal static void PHNBJIDPAFI<TMInput, TMOutput, TMNode>(this FAJDBPCNIJK<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMNode> DGIBOINMLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x24E28B0", Offset = "0x24E16B0", VA = "0x1824E28B0")]
	public static bool BEFJOKMDIPF<TMInput, TMOutput, TMNode>([In] this FAJDBPCNIJK<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMNode> DGIBOINMLED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x224E700", Offset = "0x224D500", VA = "0x18224E700")]
	public static int AIFGPJKHHPG<TMInput, TMOutput, TMNode>([In] this FAJDBPCNIJK<TMInput, TMOutput, TMNode> CNFBJPGPBBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x24E3BB0", Offset = "0x24E29B0", VA = "0x1824E3BB0")]
	public static int MGEJBPDBEMM<TMInput, TMOutput, TMNode>([In] this FAJDBPCNIJK<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMNode> DGIBOINMLED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x24E3B20", Offset = "0x24E2920", VA = "0x1824E3B20")]
	public static int LCAAIPGEBFI<TMInput, TMOutput, TMNode>([In] this FAJDBPCNIJK<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMNode> DGIBOINMLED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x24E3BF0", Offset = "0x24E29F0", VA = "0x1824E3BF0")]
	public static HIGDJMOGOKB<TMInput> NGAPMBGPFII<TMInput, TMOutput, TMNode>([In] this FAJDBPCNIJK<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMNode> DGIBOINMLED, int ENPOKNEMOMH)
	{
		return default(HIGDJMOGOKB<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x24E3B60", Offset = "0x24E2960", VA = "0x1824E3B60")]
	public static HIGDJMOGOKB<TMOutput> MBLCPAKIEEL<TMOutput, TMInput, TMNode>([In] this FAJDBPCNIJK<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMNode> DGIBOINMLED, int ENPOKNEMOMH)
	{
		return default(HIGDJMOGOKB<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x24E2870", Offset = "0x24E1670", VA = "0x1824E2870")]
	internal static void NEKGBPGDDMO<TMInput, TMOutput, TMNode>(this FAJDBPCNIJK<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMNode> DGIBOINMLED, HIGDJMOGOKB<TMInput> PABKLBOPHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x24E28D0", Offset = "0x24E16D0", VA = "0x1824E28D0")]
	internal static void PDIHOBPNOPL<TMInput, TMOutput, TMNode>(this FAJDBPCNIJK<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMNode> DGIBOINMLED, HIGDJMOGOKB<TMOutput> DGADLNLIIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x24E2F30", Offset = "0x24E1D30", VA = "0x1824E2F30")]
	internal static void DDMGHLMBHPG<TMInput, TMOutput, TMNode>(this FAJDBPCNIJK<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMNode> DGIBOINMLED, int ENPOKNEMOMH, HIGDJMOGOKB<TMInput> PABKLBOPHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x24E2E80", Offset = "0x24E1C80", VA = "0x1824E2E80")]
	internal static void CJPOKFAPJKA<TMInput, TMOutput, TMNode>(this FAJDBPCNIJK<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMNode> DGIBOINMLED, int ENPOKNEMOMH, HIGDJMOGOKB<TMOutput> DGADLNLIIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x24E2870", Offset = "0x24E1670", VA = "0x1824E2870")]
	internal static void AAJGDFLPCPL<TMInput, TMOutput, TMNode>(this FAJDBPCNIJK<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMNode> DGIBOINMLED, HIGDJMOGOKB<TMInput> PABKLBOPHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x24E28D0", Offset = "0x24E16D0", VA = "0x1824E28D0")]
	internal static void BNMNMDOIMLB<TMInput, TMOutput, TMNode>(this FAJDBPCNIJK<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMNode> DGIBOINMLED, HIGDJMOGOKB<TMOutput> DGADLNLIIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x24E2E20", Offset = "0x24E1C20", VA = "0x1824E2E20")]
	public static LGHDEKJBNJM<HIGDJMOGOKB<TMInput>>.BFENMFFNOCG CJPMCFAFBHO<TMInput, TMOutput, TMNode>([In] this FAJDBPCNIJK<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMNode> DGIBOINMLED)
	{
		return default(LGHDEKJBNJM<HIGDJMOGOKB<TMInput>>.BFENMFFNOCG);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x24E2ED0", Offset = "0x24E1CD0", VA = "0x1824E2ED0")]
	public static LGHDEKJBNJM<HIGDJMOGOKB<TMOutput>>.BFENMFFNOCG CNCIAGICNBL<TMOutput, TMInput, TMNode>([In] this FAJDBPCNIJK<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMNode> DGIBOINMLED)
	{
		return default(LGHDEKJBNJM<HIGDJMOGOKB<TMOutput>>.BFENMFFNOCG);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x24E2E20", Offset = "0x24E1C20", VA = "0x1824E2E20")]
	public static MJOPIHFOANL<HIGDJMOGOKB<TMInput>, LGHDEKJBNJM<HIGDJMOGOKB<TMInput>>.BFENMFFNOCG> GCPNOABIGBH<TMInput, TMOutput, TMNode>([In] this FAJDBPCNIJK<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMNode> DGIBOINMLED)
	{
		return default(MJOPIHFOANL<HIGDJMOGOKB<TMInput>, LGHDEKJBNJM<HIGDJMOGOKB<TMInput>>.BFENMFFNOCG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x24E2ED0", Offset = "0x24E1CD0", VA = "0x1824E2ED0")]
	public static MJOPIHFOANL<HIGDJMOGOKB<TMOutput>, LGHDEKJBNJM<HIGDJMOGOKB<TMOutput>>.BFENMFFNOCG> NNHOODLCNKL<TMOutput, TMInput, TMNode>([In] this FAJDBPCNIJK<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMNode> DGIBOINMLED)
	{
		return default(MJOPIHFOANL<HIGDJMOGOKB<TMOutput>, LGHDEKJBNJM<HIGDJMOGOKB<TMOutput>>.BFENMFFNOCG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x24E3AE0", Offset = "0x24E28E0", VA = "0x1824E3AE0")]
	public static JMBDNNCCPGJ<HIGDJMOGOKB<TMNode>, HNMIFFNBPEC<TMNode>.DMNHNMCLCOD> INEBOGEMABH<TMNode, TMInput, TMOutput>([In] this FAJDBPCNIJK<TMInput, TMOutput, TMNode> CNFBJPGPBBJ)
	{
		return default(JMBDNNCCPGJ<HIGDJMOGOKB<TMNode>, HNMIFFNBPEC<TMNode>.DMNHNMCLCOD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct NKNFEIMPDLM<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal HNMIFFNBPEC<TMOutput> BDJPEAFBMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal FKJDGDHDMEC<TMOutput, HIGDJMOGOKB<TMNode>> MHCMMBEACAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal FKJDGDHDMEC<TMOutput, LGHDEKJBNJM<HIGDJMOGOKB<TMInput>>> DGLPGGCKNFM;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x359F0B0", Offset = "0x359DEB0", VA = "0x18359F0B0")]
	internal NKNFEIMPDLM([In] HNMIFFNBPEC<TMOutput> BALAIOLAJGB, [In] FKJDGDHDMEC<TMOutput, HIGDJMOGOKB<TMNode>> EIGKMPBMGAG, [In] FKJDGDHDMEC<TMOutput, LGHDEKJBNJM<HIGDJMOGOKB<TMInput>>> LNIGABDEMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x359EEF0", Offset = "0x359DCF0", VA = "0x18359EEF0")]
	internal static NKNFEIMPDLM<TMInput, TMOutput, TMNode> KJKFMOENPNA()
	{
		return default(NKNFEIMPDLM<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class LDNECBNDCAI
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2786A10", Offset = "0x2785810", VA = "0x182786A10")]
	internal static MOFABKNOGCO FILLENIGNNA<TMInput, TMOutput, TMNode>([In] this NKNFEIMPDLM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2786330", Offset = "0x2785130", VA = "0x182786330")]
	internal static NKNFEIMPDLM<TMInput, TMOutput, TMNode> CINNELLPCMC<TMInput, TMOutput, TMNode>(this MOFABKNOGCO CNFBJPGPBBJ)
	{
		return default(NKNFEIMPDLM<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2786840", Offset = "0x2785640", VA = "0x182786840")]
	private static OEBIKBGKMJH EKCNAJLJCIJ<TMInput>([In] this LGHDEKJBNJM<HIGDJMOGOKB<TMInput>> CNFBJPGPBBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2786DA0", Offset = "0x2785BA0", VA = "0x182786DA0")]
	private static LGHDEKJBNJM<HIGDJMOGOKB<TMInput>> IKMGNOKMHJF<TMInput>(this OEBIKBGKMJH CNFBJPGPBBJ)
	{
		return default(LGHDEKJBNJM<HIGDJMOGOKB<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x26F74C0", Offset = "0x26F62C0", VA = "0x1826F74C0")]
	internal static void ECEAPGIDAKG<TMInput, TMOutput, TMNode>(this NKNFEIMPDLM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x26F7E30", Offset = "0x26F6C30", VA = "0x1826F7E30")]
	internal static HIGDJMOGOKB<TMOutput> IHOEEIJHHEK<TMOutput, TMInput, TMNode>(this NKNFEIMPDLM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMNode> ACNLHBNEANJ)
	{
		return default(HIGDJMOGOKB<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x26F7EF0", Offset = "0x26F6CF0", VA = "0x1826F7EF0")]
	internal static void PHNBJIDPAFI<TMInput, TMOutput, TMNode>(this NKNFEIMPDLM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMOutput> DGIBOINMLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x24E28B0", Offset = "0x24E16B0", VA = "0x1824E28B0")]
	public static bool BEFJOKMDIPF<TMInput, TMOutput, TMNode>([In] this NKNFEIMPDLM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMOutput> DGIBOINMLED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x224E700", Offset = "0x224D500", VA = "0x18224E700")]
	public static int AIFGPJKHHPG<TMInput, TMOutput, TMNode>([In] this NKNFEIMPDLM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x26F7ED0", Offset = "0x26F6CD0", VA = "0x1826F7ED0")]
	public static HIGDJMOGOKB<TMNode> JHGFAAKMFHL<TMNode, TMInput, TMOutput>([In] this NKNFEIMPDLM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMOutput> DGIBOINMLED)
	{
		return default(HIGDJMOGOKB<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x24E3B20", Offset = "0x24E2920", VA = "0x1824E3B20")]
	public static int MGEJBPDBEMM<TMInput, TMOutput, TMNode>([In] this NKNFEIMPDLM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMOutput> DGIBOINMLED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x24E3B60", Offset = "0x24E2960", VA = "0x1824E3B60")]
	public static HIGDJMOGOKB<TMInput> NGAPMBGPFII<TMInput, TMOutput, TMNode>([In] this NKNFEIMPDLM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMOutput> DGIBOINMLED, int ENPOKNEMOMH)
	{
		return default(HIGDJMOGOKB<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x24E28D0", Offset = "0x24E16D0", VA = "0x1824E28D0")]
	internal static void NEKGBPGDDMO<TMInput, TMOutput, TMNode>(this NKNFEIMPDLM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMOutput> DGIBOINMLED, HIGDJMOGOKB<TMInput> PABKLBOPHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x24E28D0", Offset = "0x24E16D0", VA = "0x1824E28D0")]
	internal static void AAJGDFLPCPL<TMInput, TMOutput, TMNode>(this NKNFEIMPDLM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMOutput> DGIBOINMLED, HIGDJMOGOKB<TMInput> PABKLBOPHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x24E2ED0", Offset = "0x24E1CD0", VA = "0x1824E2ED0")]
	public static LGHDEKJBNJM<HIGDJMOGOKB<TMInput>>.BFENMFFNOCG CJPMCFAFBHO<TMInput, TMOutput, TMNode>([In] this NKNFEIMPDLM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMOutput> DGIBOINMLED)
	{
		return default(LGHDEKJBNJM<HIGDJMOGOKB<TMInput>>.BFENMFFNOCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x24E2ED0", Offset = "0x24E1CD0", VA = "0x1824E2ED0")]
	public static MJOPIHFOANL<HIGDJMOGOKB<TMInput>, LGHDEKJBNJM<HIGDJMOGOKB<TMInput>>.BFENMFFNOCG> GCPNOABIGBH<TMInput, TMOutput, TMNode>([In] this NKNFEIMPDLM<TMInput, TMOutput, TMNode> CNFBJPGPBBJ, HIGDJMOGOKB<TMOutput> DGIBOINMLED)
	{
		return default(MJOPIHFOANL<HIGDJMOGOKB<TMInput>, LGHDEKJBNJM<HIGDJMOGOKB<TMInput>>.BFENMFFNOCG>);
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
