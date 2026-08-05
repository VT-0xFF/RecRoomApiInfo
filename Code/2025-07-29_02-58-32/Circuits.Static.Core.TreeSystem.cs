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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A87280", Offset = "0x2A85C80", VA = "0x182A87280")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAB0110", Offset = "0xAAEB10", VA = "0x180AB0110")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAB0150", Offset = "0xAAEB50", VA = "0x180AB0150")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct EFECHDGEKCD<TMNode> : IEnumerator<COBPPOBACAG<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly COBPPOBACAG<TMNode> FBJKBPNLCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly HCBAHOABANP<TMNode, COBPPOBACAG<TMNode>> KGEMGCMBHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private COBPPOBACAG<TMNode> AAGMNFAGBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool ILJMLFMCEEE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public COBPPOBACAG<TMNode> CEKGODBONJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5C0", Offset = "0xA8CFC0", VA = "0x180A8E5C0", Slot = "4")]
		get
		{
			return default(COBPPOBACAG<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x492C0C0", Offset = "0x492AAC0", VA = "0x18492C0C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x492C140", Offset = "0x492AB40", VA = "0x18492C140")]
	internal EFECHDGEKCD(COBPPOBACAG<TMNode> PAEPPOFDFDK, [In] HCBAHOABANP<TMNode, COBPPOBACAG<TMNode>> BLPFFBGHIMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x492BE60", Offset = "0x492A860", VA = "0x18492BE60", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x492C0B0", Offset = "0x492AAB0", VA = "0x18492C0B0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct AGODLLPPDNC<TMNode>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal static readonly COBPPOBACAG<TMNode> HCFLHDMOCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal LGABLCKNDKK<TMNode> CEEEIGDHCDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal HCBAHOABANP<TMNode, COBPPOBACAG<TMNode>> KGEMGCMBHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal HCBAHOABANP<TMNode, GNGEHCNCBFJ<COBPPOBACAG<TMNode>>> LANGCMFDKIE;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2A81B10", Offset = "0x2A80510", VA = "0x182A81B10")]
	internal AGODLLPPDNC([In] LGABLCKNDKK<TMNode> LABMJPDHBMP, [In] HCBAHOABANP<TMNode, COBPPOBACAG<TMNode>> BLPFFBGHIMB, [In] HCBAHOABANP<TMNode, GNGEHCNCBFJ<COBPPOBACAG<TMNode>>> GKCMIFJJHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x523D220", Offset = "0x523BC20", VA = "0x18523D220")]
	public static AGODLLPPDNC<TMNode> MDDJOGPLAFO()
	{
		return default(AGODLLPPDNC<TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class BLMICFGDGMO
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3A00290", Offset = "0x39FEC90", VA = "0x183A00290")]
	public static FDMOGJCEEBF AGNKEKDJGCC<TMNode>([In] this AGODLLPPDNC<TMNode> NLDLHIJAJBO) where TMNode : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3A00BC0", Offset = "0x39FF5C0", VA = "0x183A00BC0")]
	internal static PJPCNNJNJPH GJBOLLALJAJ<TMNode>([In] this GNGEHCNCBFJ<COBPPOBACAG<TMNode>> NLDLHIJAJBO) where TMNode : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3A006B0", Offset = "0x39FF0B0", VA = "0x183A006B0")]
	internal static GNGEHCNCBFJ<COBPPOBACAG<TMNode>> CCEEKDINCJE<TMNode>(this PJPCNNJNJPH NLDLHIJAJBO) where TMNode : notnull
	{
		return default(GNGEHCNCBFJ<COBPPOBACAG<TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3A01040", Offset = "0x39FFA40", VA = "0x183A01040")]
	public static void NHMIPJFACPH<TMNode>(this AGODLLPPDNC<TMNode> NLDLHIJAJBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3A00A80", Offset = "0x39FF480", VA = "0x183A00A80")]
	public static bool DBCKAGIKEII<TMNode>([In] this AGODLLPPDNC<TMNode> NLDLHIJAJBO, COBPPOBACAG<TMNode> EGJGKBPPPFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3A01030", Offset = "0x39FFA30", VA = "0x183A01030")]
	public static int NBHNBLDAPPI<TMNode>([In] this AGODLLPPDNC<TMNode> NLDLHIJAJBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3A00A90", Offset = "0x39FF490", VA = "0x183A00A90")]
	public static COBPPOBACAG<TMNode?> EOFEAOLJNDG<TMNode>(this AGODLLPPDNC<TMNode> NLDLHIJAJBO)
	{
		return default(COBPPOBACAG<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3A009B0", Offset = "0x39FF3B0", VA = "0x183A009B0")]
	public static COBPPOBACAG<TMNode?> CFDJFHLFOAC<TMNode>(this AGODLLPPDNC<TMNode> NLDLHIJAJBO, COBPPOBACAG<TMNode> DFKFFPKHNCH)
	{
		return default(COBPPOBACAG<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3A01260", Offset = "0x39FFC60", VA = "0x183A01260")]
	public static void OEENGNANBPH<TMNode>(this AGODLLPPDNC<TMNode> NLDLHIJAJBO, COBPPOBACAG<TMNode> EGJGKBPPPFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3A00620", Offset = "0x39FF020", VA = "0x183A00620")]
	public static bool BPOKPLLNDNE<TMNode>([In] this AGODLLPPDNC<TMNode> NLDLHIJAJBO, COBPPOBACAG<TMNode> EGJGKBPPPFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3A014D0", Offset = "0x39FFED0", VA = "0x183A014D0")]
	public static COBPPOBACAG<TMNode?> OOPAOLMCLLD<TMNode>([In] this AGODLLPPDNC<TMNode> NLDLHIJAJBO, COBPPOBACAG<TMNode> EGJGKBPPPFG)
	{
		return default(COBPPOBACAG<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3A00D90", Offset = "0x39FF790", VA = "0x183A00D90")]
	public static COBPPOBACAG<TMNode?>? GNBPPCIJANG<TMNode>([In] this AGODLLPPDNC<TMNode> NLDLHIJAJBO, COBPPOBACAG<TMNode> EGJGKBPPPFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3A00F00", Offset = "0x39FF900", VA = "0x183A00F00")]
	public static void KPDFEIDEPEF<TMNode>(this AGODLLPPDNC<TMNode> NLDLHIJAJBO, COBPPOBACAG<TMNode> EGJGKBPPPFG, COBPPOBACAG<TMNode> IJDEAEOJKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3A00EA0", Offset = "0x39FF8A0", VA = "0x183A00EA0")]
	public static FHIDCHPOPHP<COBPPOBACAG<TMNode?>, GNGEHCNCBFJ<COBPPOBACAG<TMNode?>>.ACBKIOHGOKP> IMFJKLCMGFE<TMNode>([In] this AGODLLPPDNC<TMNode> NLDLHIJAJBO, COBPPOBACAG<TMNode> EGJGKBPPPFG)
	{
		return default(FHIDCHPOPHP<COBPPOBACAG<TMNode>, GNGEHCNCBFJ<COBPPOBACAG<TMNode>>.ACBKIOHGOKP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xDE25D0", Offset = "0xDE0FD0", VA = "0x180DE25D0")]
	public static LGABLCKNDKK<TMNode?> IGHMDDHOENB<TMNode>([In] this AGODLLPPDNC<TMNode> NLDLHIJAJBO)
	{
		return default(LGABLCKNDKK<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3A00E60", Offset = "0x39FF860", VA = "0x183A00E60")]
	public static LGABLCKNDKK<TMNode?>.JIOIANGBNPC IBBMHAHFLHH<TMNode>([In] this AGODLLPPDNC<TMNode> NLDLHIJAJBO)
	{
		return default(LGABLCKNDKK<TMNode>.JIOIANGBNPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3A00B80", Offset = "0x39FF580", VA = "0x183A00B80")]
	public static NPPNACLKOBJ<COBPPOBACAG<TMNode?>, LGABLCKNDKK<TMNode?>.JIOIANGBNPC> FNPHCDILIGK<TMNode>([In] this AGODLLPPDNC<TMNode> NLDLHIJAJBO)
	{
		return default(NPPNACLKOBJ<COBPPOBACAG<TMNode>, LGABLCKNDKK<TMNode>.JIOIANGBNPC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3A00910", Offset = "0x39FF310", VA = "0x183A00910")]
	public static bool CDDLJOLAKKF<TMNode>([In] this AGODLLPPDNC<TMNode> NLDLHIJAJBO, COBPPOBACAG<TMNode> AAPGFEFGBOK, COBPPOBACAG<TMNode> BBKMHEEDCPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3A011D0", Offset = "0x39FFBD0", VA = "0x183A011D0")]
	public static NPPNACLKOBJ<COBPPOBACAG<TMNode?>, EFECHDGEKCD<TMNode?>> NOOGCKGFOIL<TMNode>([In] this AGODLLPPDNC<TMNode> NLDLHIJAJBO, COBPPOBACAG<TMNode> AAPGFEFGBOK)
	{
		return default(NPPNACLKOBJ<COBPPOBACAG<TMNode>, EFECHDGEKCD<TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class IJIAANPNHLD
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3CD4890", Offset = "0x3CD3290", VA = "0x183CD4890")]
	public static AGODLLPPDNC<TMNode> JBBKNKCPLNK<TMNode>(this FDMOGJCEEBF NLDLHIJAJBO) where TMNode : notnull
	{
		return default(AGODLLPPDNC<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2A87090", Offset = "0x2A85A90", VA = "0x182A87090")]
	public static void OEENGNANBPH(this FDMOGJCEEBF NLDLHIJAJBO, int EGJGKBPPPFG)
	{
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
