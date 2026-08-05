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
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
		[Cpp2IlInjected.Address(RVA = "0x290F100", Offset = "0x290DB00", VA = "0x18290F100")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA35A80", Offset = "0xA34480", VA = "0x180A35A80")]
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
		[Cpp2IlInjected.Address(RVA = "0xA35AC0", Offset = "0xA344C0", VA = "0x180A35AC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct CBLOGKPGDDE<TMNode> : IEnumerator<EHLNDDDNIPO<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly EHLNDDDNIPO<TMNode> PFILOPACGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly CFFOMBMNIPG<TMNode, EHLNDDDNIPO<TMNode>> OAPGEBHMHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private EHLNDDDNIPO<TMNode> AEEEDJBDJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool MNAEPHFNIDF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public EHLNDDDNIPO<TMNode> NBBAKIJBGKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA09240", Offset = "0xA07C40", VA = "0x180A09240", Slot = "4")]
		get
		{
			return default(EHLNDDDNIPO<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x64BA170", Offset = "0x64B8B70", VA = "0x1864BA170", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x64BA1E0", Offset = "0x64B8BE0", VA = "0x1864BA1E0")]
	internal CBLOGKPGDDE(EHLNDDDNIPO<TMNode> HKECPJKDGLJ, [In] CFFOMBMNIPG<TMNode, EHLNDDDNIPO<TMNode>> CJKJLGMNLNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x64B9F30", Offset = "0x64B8930", VA = "0x1864B9F30", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x64BA160", Offset = "0x64B8B60", VA = "0x1864BA160", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct OMKILDNHFOJ<TMNode>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal static readonly EHLNDDDNIPO<TMNode> KOIHLJBJMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal EENHIBOLGKA<TMNode> JEAMMDMBGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal CFFOMBMNIPG<TMNode, EHLNDDDNIPO<TMNode>> OAPGEBHMHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal CFFOMBMNIPG<TMNode, KEIHFOCJOJN<EHLNDDDNIPO<TMNode>>> MMCDCPCJPEO;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2907890", Offset = "0x2906290", VA = "0x182907890")]
	internal OMKILDNHFOJ([In] EENHIBOLGKA<TMNode> OOIHDMPFMCG, [In] CFFOMBMNIPG<TMNode, EHLNDDDNIPO<TMNode>> CJKJLGMNLNL, [In] CFFOMBMNIPG<TMNode, KEIHFOCJOJN<EHLNDDDNIPO<TMNode>>> KJGEKOMNNIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x567FB70", Offset = "0x567E570", VA = "0x18567FB70")]
	public static OMKILDNHFOJ<TMNode> FMDOFBCLPJB()
	{
		return default(OMKILDNHFOJ<TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class HHPKLHPPCEO
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3A83550", Offset = "0x3A81F50", VA = "0x183A83550")]
	public static EBMIDJGDLCI PGPOMLMDCHO<TMNode>([In] this OMKILDNHFOJ<TMNode> NMEFAPBBOCD) where TMNode : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3A83100", Offset = "0x3A81B00", VA = "0x183A83100")]
	internal static KFFMOPAEGDM JEJBNECHEBK<TMNode>([In] this KEIHFOCJOJN<EHLNDDDNIPO<TMNode>> NMEFAPBBOCD) where TMNode : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3A82E80", Offset = "0x3A81880", VA = "0x183A82E80")]
	internal static KEIHFOCJOJN<EHLNDDDNIPO<TMNode>> IGBAKENCFJE<TMNode>(this KFFMOPAEGDM NMEFAPBBOCD) where TMNode : notnull
	{
		return default(KEIHFOCJOJN<EHLNDDDNIPO<TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3A82940", Offset = "0x3A81340", VA = "0x183A82940")]
	public static void EFCPNMLOGFP<TMNode>(this OMKILDNHFOJ<TMNode> NMEFAPBBOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3A82E30", Offset = "0x3A81830", VA = "0x183A82E30")]
	public static bool IAKPEOGICJH<TMNode>([In] this OMKILDNHFOJ<TMNode> NMEFAPBBOCD, EHLNDDDNIPO<TMNode> KHNIMGKFPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3A82E20", Offset = "0x3A81820", VA = "0x183A82E20")]
	public static int GNDFLCMCIAD<TMNode>([In] this OMKILDNHFOJ<TMNode> NMEFAPBBOCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3A832D0", Offset = "0x3A81CD0", VA = "0x183A832D0")]
	public static EHLNDDDNIPO<TMNode?> LBBLOBADELI<TMNode>(this OMKILDNHFOJ<TMNode> NMEFAPBBOCD)
	{
		return default(EHLNDDDNIPO<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3A82D50", Offset = "0x3A81750", VA = "0x183A82D50")]
	public static EHLNDDDNIPO<TMNode?> GJGECJFEPGP<TMNode>(this OMKILDNHFOJ<TMNode> NMEFAPBBOCD, EHLNDDDNIPO<TMNode> EAGGHBKHKHF)
	{
		return default(EHLNDDDNIPO<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3A826E0", Offset = "0x3A810E0", VA = "0x183A826E0")]
	public static void DKAGEAADPDL<TMNode>(this OMKILDNHFOJ<TMNode> NMEFAPBBOCD, EHLNDDDNIPO<TMNode> KHNIMGKFPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3A82C00", Offset = "0x3A81600", VA = "0x183A82C00")]
	public static bool FPFHCIFNHJK<TMNode>([In] this OMKILDNHFOJ<TMNode> NMEFAPBBOCD, EHLNDDDNIPO<TMNode> KHNIMGKFPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3A830E0", Offset = "0x3A81AE0", VA = "0x183A830E0")]
	public static EHLNDDDNIPO<TMNode?> IGONPOBPOPB<TMNode>([In] this OMKILDNHFOJ<TMNode> NMEFAPBBOCD, EHLNDDDNIPO<TMNode> KHNIMGKFPOO)
	{
		return default(EHLNDDDNIPO<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3A82C90", Offset = "0x3A81690", VA = "0x183A82C90")]
	public static EHLNDDDNIPO<TMNode?>? GGPKIHDAMCC<TMNode>([In] this OMKILDNHFOJ<TMNode> NMEFAPBBOCD, EHLNDDDNIPO<TMNode> KHNIMGKFPOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3A82AD0", Offset = "0x3A814D0", VA = "0x183A82AD0")]
	public static void ELANGCKAKBE<TMNode>(this OMKILDNHFOJ<TMNode> NMEFAPBBOCD, EHLNDDDNIPO<TMNode> KHNIMGKFPOO, EHLNDDDNIPO<TMNode> DHMKEFMFLIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3A833C0", Offset = "0x3A81DC0", VA = "0x183A833C0")]
	public static HCEBFOBENFM<EHLNDDDNIPO<TMNode?>, KEIHFOCJOJN<EHLNDDDNIPO<TMNode?>>.KBMFAMKBEAA> MKLHINCOMGI<TMNode>([In] this OMKILDNHFOJ<TMNode> NMEFAPBBOCD, EHLNDDDNIPO<TMNode> KHNIMGKFPOO)
	{
		return default(HCEBFOBENFM<EHLNDDDNIPO<TMNode>, KEIHFOCJOJN<EHLNDDDNIPO<TMNode>>.KBMFAMKBEAA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xD0DC80", Offset = "0xD0C680", VA = "0x180D0DC80")]
	public static EENHIBOLGKA<TMNode?> HGJEDFIDKAJ<TMNode>([In] this OMKILDNHFOJ<TMNode> NMEFAPBBOCD)
	{
		return default(EENHIBOLGKA<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3A82E40", Offset = "0x3A81840", VA = "0x183A82E40")]
	public static EENHIBOLGKA<TMNode?>.FFLMDMIAGPP ICNPOCIJNJG<TMNode>([In] this OMKILDNHFOJ<TMNode> NMEFAPBBOCD)
	{
		return default(EENHIBOLGKA<TMNode>.FFLMDMIAGPP);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3A826A0", Offset = "0x3A810A0", VA = "0x183A826A0")]
	public static GLIIFEKENJO<EHLNDDDNIPO<TMNode?>, EENHIBOLGKA<TMNode?>.FFLMDMIAGPP> CADGIHFEHPD<TMNode>([In] this OMKILDNHFOJ<TMNode> NMEFAPBBOCD)
	{
		return default(GLIIFEKENJO<EHLNDDDNIPO<TMNode>, EENHIBOLGKA<TMNode>.FFLMDMIAGPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3A834B0", Offset = "0x3A81EB0", VA = "0x183A834B0")]
	public static bool OIBPMMNDJDD<TMNode>([In] this OMKILDNHFOJ<TMNode> NMEFAPBBOCD, EHLNDDDNIPO<TMNode> DGGBJNBEMBF, EHLNDDDNIPO<TMNode> FAKEOLEIJIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3A83420", Offset = "0x3A81E20", VA = "0x183A83420")]
	public static GLIIFEKENJO<EHLNDDDNIPO<TMNode?>, CBLOGKPGDDE<TMNode?>> NFJEIAAMPAD<TMNode>([In] this OMKILDNHFOJ<TMNode> NMEFAPBBOCD, EHLNDDDNIPO<TMNode> DGGBJNBEMBF)
	{
		return default(GLIIFEKENJO<EHLNDDDNIPO<TMNode>, CBLOGKPGDDE<TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class HJNNBCKPMBC
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3A89D60", Offset = "0x3A88760", VA = "0x183A89D60")]
	public static OMKILDNHFOJ<TMNode> PGEPBAPICDN<TMNode>(this EBMIDJGDLCI NMEFAPBBOCD) where TMNode : notnull
	{
		return default(OMKILDNHFOJ<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x290EF10", Offset = "0x290D910", VA = "0x18290EF10")]
	public static void DKAGEAADPDL(this EBMIDJGDLCI NMEFAPBBOCD, int KHNIMGKFPOO)
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
