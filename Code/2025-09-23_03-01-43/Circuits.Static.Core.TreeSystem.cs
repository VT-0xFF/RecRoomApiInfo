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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B78C80", Offset = "0x2B77280", VA = "0x182B78C80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD1900", Offset = "0xACFF00", VA = "0x180AD1900")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD1940", Offset = "0xACFF40", VA = "0x180AD1940")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct GCKKCHDGLDI<TMNode> : IEnumerator<AIOJMGEOJFK<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly AIOJMGEOJFK<TMNode> CCCKKOFGMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly AGMAKDOIOBI<TMNode, AIOJMGEOJFK<TMNode>> JHMHFEKJAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private AIOJMGEOJFK<TMNode> MBLCKIKFPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool PIIMIDNEDME;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public AIOJMGEOJFK<TMNode> MIECLPJBKEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAB04F0", Offset = "0xAAEAF0", VA = "0x180AB04F0", Slot = "4")]
		get
		{
			return default(AIOJMGEOJFK<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x50E2B30", Offset = "0x50E1130", VA = "0x1850E2B30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x50E2BB0", Offset = "0x50E11B0", VA = "0x1850E2BB0")]
	internal GCKKCHDGLDI(AIOJMGEOJFK<TMNode> GHOFJOJMCOI, [In] AGMAKDOIOBI<TMNode, AIOJMGEOJFK<TMNode>> GKBKGOHGDLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x50E28D0", Offset = "0x50E0ED0", VA = "0x1850E28D0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x50E2B20", Offset = "0x50E1120", VA = "0x1850E2B20", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct CNPOCAIKCNN<TMNode>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal static readonly AIOJMGEOJFK<TMNode> MKAPKENLHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal MHMLJNENLGM<TMNode> PCBPLMGPMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal AGMAKDOIOBI<TMNode, AIOJMGEOJFK<TMNode>> JHMHFEKJAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal AGMAKDOIOBI<TMNode, NHNLFJGMEDN<AIOJMGEOJFK<TMNode>>> HJLIPJBHDKP;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2B70C70", Offset = "0x2B6F270", VA = "0x182B70C70")]
	internal CNPOCAIKCNN([In] MHMLJNENLGM<TMNode> NPCGIBIOHAD, [In] AGMAKDOIOBI<TMNode, AIOJMGEOJFK<TMNode>> GKBKGOHGDLF, [In] AGMAKDOIOBI<TMNode, NHNLFJGMEDN<AIOJMGEOJFK<TMNode>>> PAICHDGKDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7033200", Offset = "0x7031800", VA = "0x187033200")]
	public static CNPOCAIKCNN<TMNode> CPNHECDILPK()
	{
		return default(CNPOCAIKCNN<TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class ADLNKNKIJOL
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x32DB390", Offset = "0x32D9990", VA = "0x1832DB390")]
	public static CCHKMLFHJME ANHNANMIGBP<TMNode>([In] this CNPOCAIKCNN<TMNode> JNMMMBJNOND) where TMNode : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x32DB8D0", Offset = "0x32D9ED0", VA = "0x1832DB8D0")]
	internal static NLDDFGBJALD COEHHLPDILL<TMNode>([In] this NHNLFJGMEDN<AIOJMGEOJFK<TMNode>> JNMMMBJNOND) where TMNode : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x32DBD00", Offset = "0x32DA300", VA = "0x1832DBD00")]
	internal static NHNLFJGMEDN<AIOJMGEOJFK<TMNode>> IBHMEMOPAPB<TMNode>(this NLDDFGBJALD JNMMMBJNOND) where TMNode : notnull
	{
		return default(NHNLFJGMEDN<AIOJMGEOJFK<TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x32DBAE0", Offset = "0x32DA0E0", VA = "0x1832DBAE0")]
	public static void GELLEPHLJAH<TMNode>(this CNPOCAIKCNN<TMNode> JNMMMBJNOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x32DB810", Offset = "0x32D9E10", VA = "0x1832DB810")]
	public static bool CCCINLIBFDH<TMNode>([In] this CNPOCAIKCNN<TMNode> JNMMMBJNOND, AIOJMGEOJFK<TMNode> NMILEMOAODL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x32DB8C0", Offset = "0x32D9EC0", VA = "0x1832DB8C0")]
	public static int CLHNCECDCGG<TMNode>([In] this CNPOCAIKCNN<TMNode> JNMMMBJNOND)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x32DB720", Offset = "0x32D9D20", VA = "0x1832DB720")]
	public static AIOJMGEOJFK<TMNode?> BEIMJHMCLML<TMNode>(this CNPOCAIKCNN<TMNode> JNMMMBJNOND)
	{
		return default(AIOJMGEOJFK<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x32DC130", Offset = "0x32DA730", VA = "0x1832DC130")]
	public static AIOJMGEOJFK<TMNode?> KNOGDOECBAK<TMNode>(this CNPOCAIKCNN<TMNode> JNMMMBJNOND, AIOJMGEOJFK<TMNode> BEBONNCPGLF)
	{
		return default(AIOJMGEOJFK<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x32DB120", Offset = "0x32D9720", VA = "0x1832DB120")]
	public static void AMPHLDINMDF<TMNode>(this CNPOCAIKCNN<TMNode> JNMMMBJNOND, AIOJMGEOJFK<TMNode> NMILEMOAODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x32DBF70", Offset = "0x32DA570", VA = "0x1832DBF70")]
	public static bool JGJIPHIDAPM<TMNode>([In] this CNPOCAIKCNN<TMNode> JNMMMBJNOND, AIOJMGEOJFK<TMNode> NMILEMOAODL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x32DB100", Offset = "0x32D9700", VA = "0x1832DB100")]
	public static AIOJMGEOJFK<TMNode?> AFGPLCNMJDO<TMNode>([In] this CNPOCAIKCNN<TMNode> JNMMMBJNOND, AIOJMGEOJFK<TMNode> NMILEMOAODL)
	{
		return default(AIOJMGEOJFK<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x32DC260", Offset = "0x32DA860", VA = "0x1832DC260")]
	public static AIOJMGEOJFK<TMNode?>? MOHNAENOGGN<TMNode>([In] this CNPOCAIKCNN<TMNode> JNMMMBJNOND, AIOJMGEOJFK<TMNode> NMILEMOAODL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x32DC000", Offset = "0x32DA600", VA = "0x1832DC000")]
	public static void KKMFJLEJIIM<TMNode>(this CNPOCAIKCNN<TMNode> JNMMMBJNOND, AIOJMGEOJFK<TMNode> NMILEMOAODL, AIOJMGEOJFK<TMNode> NAJIGMFBPDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x32DC200", Offset = "0x32DA800", VA = "0x1832DC200")]
	public static AHLMKHDGFBP<AIOJMGEOJFK<TMNode?>, NHNLFJGMEDN<AIOJMGEOJFK<TMNode?>>.KMNGPCDLLAB> LJDBBKEJICL<TMNode>([In] this CNPOCAIKCNN<TMNode> JNMMMBJNOND, AIOJMGEOJFK<TMNode> NMILEMOAODL)
	{
		return default(AHLMKHDGFBP<AIOJMGEOJFK<TMNode>, NHNLFJGMEDN<AIOJMGEOJFK<TMNode>>.KMNGPCDLLAB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xE29190", Offset = "0xE27790", VA = "0x180E29190")]
	public static MHMLJNENLGM<TMNode?> PIMFLDLMACK<TMNode>([In] this CNPOCAIKCNN<TMNode> JNMMMBJNOND)
	{
		return default(MHMLJNENLGM<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x32DB0C0", Offset = "0x32D96C0", VA = "0x1832DB0C0")]
	public static MHMLJNENLGM<TMNode?>.PFKOMOKBECG ABGODHCJODA<TMNode>([In] this CNPOCAIKCNN<TMNode> JNMMMBJNOND)
	{
		return default(MHMLJNENLGM<TMNode>.PFKOMOKBECG);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x32DBAA0", Offset = "0x32DA0A0", VA = "0x1832DBAA0")]
	public static LMAMBNHNDEF<AIOJMGEOJFK<TMNode?>, MHMLJNENLGM<TMNode?>.PFKOMOKBECG> FGPOKJGJJOL<TMNode>([In] this CNPOCAIKCNN<TMNode> JNMMMBJNOND)
	{
		return default(LMAMBNHNDEF<AIOJMGEOJFK<TMNode>, MHMLJNENLGM<TMNode>.PFKOMOKBECG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x32DB820", Offset = "0x32D9E20", VA = "0x1832DB820")]
	public static bool CFDKHGJNPEM<TMNode>([In] this CNPOCAIKCNN<TMNode> JNMMMBJNOND, AIOJMGEOJFK<TMNode> EMOGDLPNEGA, AIOJMGEOJFK<TMNode> MGMICADJKBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x32DBC70", Offset = "0x32DA270", VA = "0x1832DBC70")]
	public static LMAMBNHNDEF<AIOJMGEOJFK<TMNode?>, GCKKCHDGLDI<TMNode?>> GNBIIDPGGPB<TMNode>([In] this CNPOCAIKCNN<TMNode> JNMMMBJNOND, AIOJMGEOJFK<TMNode> EMOGDLPNEGA)
	{
		return default(LMAMBNHNDEF<AIOJMGEOJFK<TMNode>, GCKKCHDGLDI<TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class AIILALADBAC
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3303C50", Offset = "0x3302250", VA = "0x183303C50")]
	public static CNPOCAIKCNN<TMNode> LPNJIHLFELG<TMNode>(this CCHKMLFHJME JNMMMBJNOND) where TMNode : notnull
	{
		return default(CNPOCAIKCNN<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2B78A90", Offset = "0x2B77090", VA = "0x182B78A90")]
	public static void AMPHLDINMDF(this CCHKMLFHJME JNMMMBJNOND, int NMILEMOAODL)
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
