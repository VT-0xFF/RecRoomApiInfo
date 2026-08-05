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
		[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E40D70", Offset = "0x1E3FB70", VA = "0x181E40D70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D9DC0", Offset = "0x7D8BC0", VA = "0x1807D9DC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D9E00", Offset = "0x7D8C00", VA = "0x1807D9E00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct BENBCAJCCHF<TMInput, TMOutput, TMNode> : IEnumerator<FCLFMGJFDHI<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private KDAICOBLDOC<TMInput, TMOutput, TMNode> EIDIJGHPGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private LAOOIBLOBBD<TMInput, TMOutput, TMNode> JDAHFAFOOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private bool OLJHJLJFGMI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly FCLFMGJFDHI<TMNode> HKCIIOLPAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x483B1C0", Offset = "0x4839FC0", VA = "0x18483B1C0", Slot = "4")]
		get
		{
			return default(FCLFMGJFDHI<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x483B070", Offset = "0x4839E70", VA = "0x18483B070", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x483B0F0", Offset = "0x4839EF0", VA = "0x18483B0F0")]
	internal BENBCAJCCHF([In] KDAICOBLDOC<TMInput, TMOutput, TMNode> JBHOAKAJLKI, [In] LAOOIBLOBBD<TMInput, TMOutput, TMNode> DGCKNJHPAFC, bool HPNCNCMIOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x483AF30", Offset = "0x4839D30", VA = "0x18483AF30", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x483AFF0", Offset = "0x4839DF0", VA = "0x18483AFF0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x483AEC0", Offset = "0x4839CC0", VA = "0x18483AEC0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class BKDBJLOMNBB
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x26AB190", Offset = "0x26A9F90", VA = "0x1826AB190")]
	public static BENBCAJCCHF<TMInput, TMOutput, TMNode> KHDJPNLCMFA<TMInput, TMOutput, TMNode>([In] GLNEHLLGNMP<TMInput, TMOutput, TMNode> KLKGBBKIDAD, FCLFMGJFDHI<TMNode> NLOKDELMBLG)
	{
		return default(BENBCAJCCHF<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct LAOOIBLOBBD<TMInput, TMOutput, TMNode> : IEnumerator<FCLFMGJFDHI<TMInput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NGFOIHIBELM<FCLFMGJFDHI<TMOutput>>.GHHHKGFPNDA AICOEEBMNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private NGFOIHIBELM<FCLFMGJFDHI<TMInput>>.GHHHKGFPNDA NHIJEFALBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly FIDFABFIIJC<TMInput, TMOutput, TMNode> PJOGGMKCJAI;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public FCLFMGJFDHI<TMInput> HKCIIOLPAGP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3CDC030", Offset = "0x3CDAE30", VA = "0x183CDC030", Slot = "4")]
		get
		{
			return default(FCLFMGJFDHI<TMInput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3CDBF10", Offset = "0x3CDAD10", VA = "0x183CDBF10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3CDBFB0", Offset = "0x3CDADB0", VA = "0x183CDBFB0")]
	internal LAOOIBLOBBD([In] NGFOIHIBELM<FCLFMGJFDHI<TMOutput>>.GHHHKGFPNDA PFIMFLBHKLC, [In] NGFOIHIBELM<FCLFMGJFDHI<TMInput>>.GHHHKGFPNDA IPNKFJBEOJG, [In] FIDFABFIIJC<TMInput, TMOutput, TMNode> NPHPIACACPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3CDBD50", Offset = "0x3CDAB50", VA = "0x183CDBD50", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3CDBEA0", Offset = "0x3CDACA0", VA = "0x183CDBEA0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3CDBCE0", Offset = "0x3CDAAE0", VA = "0x183CDBCE0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class JCJKMBLOJIB
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x291F060", Offset = "0x291DE60", VA = "0x18291F060")]
	public static LAOOIBLOBBD<TMInput, TMOutput, TMNode> KHDJPNLCMFA<TMInput, TMOutput, TMNode>([In] GLNEHLLGNMP<TMInput, TMOutput, TMNode> KLKGBBKIDAD, FCLFMGJFDHI<TMNode> NLOKDELMBLG)
	{
		return default(LAOOIBLOBBD<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct KDAICOBLDOC<TMInput, TMOutput, TMNode> : IEnumerator<FCLFMGJFDHI<TMOutput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private NGFOIHIBELM<FCLFMGJFDHI<TMInput>>.GHHHKGFPNDA LEIKCMHNIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private NGFOIHIBELM<FCLFMGJFDHI<TMOutput>>.GHHHKGFPNDA FEKJPFJJGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly HJGGENKMFLH<TMInput, TMOutput, TMNode> CKMOHOPJPND;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public FCLFMGJFDHI<TMOutput> HKCIIOLPAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3CDC030", Offset = "0x3CDAE30", VA = "0x183CDC030", Slot = "4")]
		get
		{
			return default(FCLFMGJFDHI<TMOutput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3CDBF10", Offset = "0x3CDAD10", VA = "0x183CDBF10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3CDBFB0", Offset = "0x3CDADB0", VA = "0x183CDBFB0")]
	internal KDAICOBLDOC([In] NGFOIHIBELM<FCLFMGJFDHI<TMInput>>.GHHHKGFPNDA PNDACJHJKIM, [In] NGFOIHIBELM<FCLFMGJFDHI<TMOutput>>.GHHHKGFPNDA EHABOJPBHDD, [In] HJGGENKMFLH<TMInput, TMOutput, TMNode> KNFKKLBMLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3CDBD50", Offset = "0x3CDAB50", VA = "0x183CDBD50", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3CDBEA0", Offset = "0x3CDACA0", VA = "0x183CDBEA0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3CDBCE0", Offset = "0x3CDAAE0", VA = "0x183CDBCE0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class FEAPENNIPMK
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x28AC480", Offset = "0x28AB280", VA = "0x1828AC480")]
	public static KDAICOBLDOC<TMInput, TMOutput, TMNode> KHDJPNLCMFA<TMInput, TMOutput, TMNode>([In] GLNEHLLGNMP<TMInput, TMOutput, TMNode> KLKGBBKIDAD, FCLFMGJFDHI<TMNode> NLOKDELMBLG)
	{
		return default(KDAICOBLDOC<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct GLNEHLLGNMP<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public HJGGENKMFLH<TMInput, TMOutput, TMNode> BEFNNHEDMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public FIDFABFIIJC<TMInput, TMOutput, TMNode> DMCPBFHNGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public LHOCGBCMBBI<TMInput, TMOutput, TMNode> DOLJHHPIMDG;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3950B60", Offset = "0x394F960", VA = "0x183950B60")]
	internal GLNEHLLGNMP([In] HJGGENKMFLH<TMInput, TMOutput, TMNode> KNFKKLBMLEP, [In] FIDFABFIIJC<TMInput, TMOutput, TMNode> NPHPIACACPB, [In] LHOCGBCMBBI<TMInput, TMOutput, TMNode> LPEJJNHCFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x39508C0", Offset = "0x394F6C0", VA = "0x1839508C0")]
	public static GLNEHLLGNMP<TMInput?, TMOutput?, TMNode?> KHDJPNLCMFA()
	{
		return default(GLNEHLLGNMP<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class JEPOHLHNGPG
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x292AA90", Offset = "0x2929890", VA = "0x18292AA90")]
	public static KBNGJBBOGIK? JPFDICAGNEF<TMInput, TMOutput, TMNode>([In] this GLNEHLLGNMP<TMInput, TMOutput, TMNode> ILACEKALGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x292A3E0", Offset = "0x29291E0", VA = "0x18292A3E0")]
	public static GLNEHLLGNMP<TMInput?, TMOutput?, TMNode?> FPNHMAJLCHC<TMInput, TMOutput, TMNode>(this KBNGJBBOGIK ILACEKALGJH)
	{
		return default(GLNEHLLGNMP<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x292AF30", Offset = "0x2929D30", VA = "0x18292AF30")]
	public static void OFGJMFOHKEH<TMInput, TMOutput, TMNode>(this GLNEHLLGNMP<TMInput, TMOutput, TMNode> ILACEKALGJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x292A190", Offset = "0x2928F90", VA = "0x18292A190")]
	public static void ANIJGFJCIHP<TMInput, TMOutput, TMNode>(this GLNEHLLGNMP<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMOutput> EPIIAPCGGLM, FCLFMGJFDHI<TMInput> EHOGCEHDMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x292AA30", Offset = "0x2929830", VA = "0x18292AA30")]
	public static void IDOHIMOLMHN<TMInput, TMOutput, TMNode>(this GLNEHLLGNMP<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMOutput> EPIIAPCGGLM, FCLFMGJFDHI<TMInput> EHOGCEHDMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x292A260", Offset = "0x2929060", VA = "0x18292A260")]
	public static bool EHLKNJNFKIJ<TMInput, TMOutput, TMNode>([In] this GLNEHLLGNMP<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMOutput> EPIIAPCGGLM, FCLFMGJFDHI<TMInput> EHOGCEHDMKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x292B080", Offset = "0x2929E80", VA = "0x18292B080")]
	public static FCLFMGJFDHI<TMNode?> PBFFPBPEDJN<TMNode, TMInput, TMOutput>(this GLNEHLLGNMP<TMInput, TMOutput, TMNode> ILACEKALGJH)
	{
		return default(FCLFMGJFDHI<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x292AB70", Offset = "0x2929970", VA = "0x18292AB70")]
	public static void KGMCMFOHINA<TMInput, TMOutput, TMNode>(this GLNEHLLGNMP<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMNode> NLOKDELMBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x292A1F0", Offset = "0x2928FF0", VA = "0x18292A1F0")]
	public static FCLFMGJFDHI<TMInput?> EDMOINKEFMK<TMInput, TMOutput, TMNode>(this GLNEHLLGNMP<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMNode> NLOKDELMBLG)
	{
		return default(FCLFMGJFDHI<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x292B1B0", Offset = "0x2929FB0", VA = "0x18292B1B0")]
	public static FCLFMGJFDHI<TMOutput?> PGHILKJEOMB<TMOutput, TMInput, TMNode>(this GLNEHLLGNMP<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMNode> NLOKDELMBLG)
	{
		return default(FCLFMGJFDHI<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x292AC80", Offset = "0x2929A80", VA = "0x18292AC80")]
	public static FCLFMGJFDHI<TMInput?> KHFLMAJDMCA<TMInput, TMOutput, TMNode>(this GLNEHLLGNMP<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMNode> NLOKDELMBLG, int AELAKOMEEDP)
	{
		return default(FCLFMGJFDHI<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x292AD00", Offset = "0x2929B00", VA = "0x18292AD00")]
	public static FCLFMGJFDHI<TMOutput?> MHLDPOOOCMG<TMOutput, TMInput, TMNode>(this GLNEHLLGNMP<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMNode> NLOKDELMBLG, int AELAKOMEEDP)
	{
		return default(FCLFMGJFDHI<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x292B110", Offset = "0x2929F10", VA = "0x18292B110")]
	public static void PBGENNLFJHK<TMInput, TMOutput, TMNode>(this GLNEHLLGNMP<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMNode> NLOKDELMBLG, int KHGMJMHFJMG, int AJPEGAFAOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x292AD80", Offset = "0x2929B80", VA = "0x18292AD80")]
	public static void NBBBNMKLPCL<TMInput, TMOutput, TMNode>(this GLNEHLLGNMP<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMNode> NLOKDELMBLG, int KHGMJMHFJMG, int AJPEGAFAOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x292AF90", Offset = "0x2929D90", VA = "0x18292AF90")]
	public static void ONJNDEGBBLA<TMInput, TMOutput, TMNode>(this GLNEHLLGNMP<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMInput> PFKCNGFFICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x292A950", Offset = "0x2929750", VA = "0x18292A950")]
	public static void HINLEFGEPHB<TMInput, TMOutput, TMNode>(this GLNEHLLGNMP<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMOutput> DKECCAKJPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x872A70", Offset = "0x871870", VA = "0x180872A70")]
	public static BHCJOMCDNKI<TMInput?> FIMOHDKHHJF<TMInput, TMOutput, TMNode>([In] this GLNEHLLGNMP<TMInput, TMOutput, TMNode> ILACEKALGJH)
	{
		return default(BHCJOMCDNKI<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1E59680", Offset = "0x1E58480", VA = "0x181E59680")]
	public static BHCJOMCDNKI<TMOutput?> GHKONFHKKJK<TMOutput, TMInput, TMNode>([In] this GLNEHLLGNMP<TMInput, TMOutput, TMNode> ILACEKALGJH)
	{
		return default(BHCJOMCDNKI<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1E59690", Offset = "0x1E58490", VA = "0x181E59690")]
	public static BHCJOMCDNKI<TMNode?> LIOCFKLCHJA<TMNode, TMInput, TMOutput>([In] this GLNEHLLGNMP<TMInput, TMOutput, TMNode> ILACEKALGJH)
	{
		return default(BHCJOMCDNKI<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x292A750", Offset = "0x2929550", VA = "0x18292A750")]
	public static LAOOIBLOBBD<TMInput?, TMOutput?, TMNode?> GBLMGDGIHBP<TMInput, TMOutput, TMNode>([In] this GLNEHLLGNMP<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMNode> NLFEJIHGBIC)
	{
		return default(LAOOIBLOBBD<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x292A750", Offset = "0x2929550", VA = "0x18292A750")]
	public static KDAICOBLDOC<TMInput?, TMOutput?, TMNode?> NGHDCLGPFGD<TMInput, TMOutput, TMNode>([In] this GLNEHLLGNMP<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMNode> NLFEJIHGBIC)
	{
		return default(KDAICOBLDOC<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x292A330", Offset = "0x2929130", VA = "0x18292A330")]
	public static BENBCAJCCHF<TMInput?, TMOutput?, TMNode?> FBIDLLJLBAN<TMInput, TMOutput, TMNode>([In] this GLNEHLLGNMP<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMNode> NLFEJIHGBIC)
	{
		return default(BENBCAJCCHF<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x292AE20", Offset = "0x2929C20", VA = "0x18292AE20")]
	public static CBADNDLLJMD<FCLFMGJFDHI<TMInput?>, LAOOIBLOBBD<TMInput?, TMOutput?, TMNode?>> NKCPBHDDKCH<TMInput, TMOutput, TMNode>([In] this GLNEHLLGNMP<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMNode> NLFEJIHGBIC)
	{
		return default(CBADNDLLJMD<FCLFMGJFDHI<TMInput>, LAOOIBLOBBD<TMInput, TMOutput, TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x292A7C0", Offset = "0x29295C0", VA = "0x18292A7C0")]
	public static CBADNDLLJMD<FCLFMGJFDHI<TMNode?>, BENBCAJCCHF<TMInput?, TMOutput?, TMNode?>> GHIJFICNDFA<TMNode, TMInput, TMOutput>([In] this GLNEHLLGNMP<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMNode> NLFEJIHGBIC)
	{
		return default(CBADNDLLJMD<FCLFMGJFDHI<TMNode>, BENBCAJCCHF<TMInput, TMOutput, TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct HJGGENKMFLH<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal BHCJOMCDNKI<TMInput> MHCCKKFHBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal FCECAFACGGB<TMInput, FCLFMGJFDHI<TMNode>> IFPNLCEJCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal FCECAFACGGB<TMInput, NGFOIHIBELM<FCLFMGJFDHI<TMOutput>>> PJOGGMKCJAI;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x383CB40", Offset = "0x383B940", VA = "0x18383CB40")]
	internal HJGGENKMFLH([In] BHCJOMCDNKI<TMInput> KAPKOHJBFBG, [In] FCECAFACGGB<TMInput, FCLFMGJFDHI<TMNode>> LPEJJNHCFKJ, [In] FCECAFACGGB<TMInput, NGFOIHIBELM<FCLFMGJFDHI<TMOutput>>> NPHPIACACPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x383C990", Offset = "0x383B790", VA = "0x18383C990")]
	internal static HJGGENKMFLH<TMInput, TMOutput, TMNode> KHDJPNLCMFA()
	{
		return default(HJGGENKMFLH<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class LKMMNBLKEID
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2964C50", Offset = "0x2963A50", VA = "0x182964C50")]
	internal static IOHCAIAEBDO JPFDICAGNEF<TMInput, TMOutput, TMNode>([In] this HJGGENKMFLH<TMInput, TMOutput, TMNode> ILACEKALGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2964460", Offset = "0x2963260", VA = "0x182964460")]
	internal static HJGGENKMFLH<TMInput, TMOutput, TMNode> FPNHMAJLCHC<TMInput, TMOutput, TMNode>(this IOHCAIAEBDO ILACEKALGJH)
	{
		return default(HJGGENKMFLH<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2964960", Offset = "0x2963760", VA = "0x182964960")]
	private static BKLDPMGOCDG GLGHGDGIKOM<TMOutput>([In] this NGFOIHIBELM<FCLFMGJFDHI<TMOutput>> ILACEKALGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2965070", Offset = "0x2963E70", VA = "0x182965070")]
	private static NGFOIHIBELM<FCLFMGJFDHI<TMOutput>> MMOFGBJPIBB<TMOutput>(this BKLDPMGOCDG ILACEKALGJH)
	{
		return default(NGFOIHIBELM<FCLFMGJFDHI<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x29652E0", Offset = "0x29640E0", VA = "0x1829652E0")]
	internal static void OFGJMFOHKEH<TMInput, TMOutput, TMNode>(this HJGGENKMFLH<TMInput, TMOutput, TMNode> ILACEKALGJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2964FD0", Offset = "0x2963DD0", VA = "0x182964FD0")]
	internal static FCLFMGJFDHI<TMInput> LNNGIDHKCJM<TMInput, TMOutput, TMNode>(this HJGGENKMFLH<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMNode> FMEAKEGGFNK)
	{
		return default(FCLFMGJFDHI<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2964B70", Offset = "0x2963970", VA = "0x182964B70")]
	internal static void IHAHIMEKHEN<TMInput, TMOutput, TMNode>(this HJGGENKMFLH<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMInput> NLFEJIHGBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x269FF90", Offset = "0x269ED90", VA = "0x18269FF90")]
	public static bool NKPMKKDPBBC<TMInput, TMOutput, TMNode>([In] this HJGGENKMFLH<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMInput> NLFEJIHGBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x269FAE0", Offset = "0x269E8E0", VA = "0x18269FAE0")]
	public static int IHIKIDOFDPL<TMInput, TMOutput, TMNode>([In] this HJGGENKMFLH<TMInput, TMOutput, TMNode> ILACEKALGJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2964440", Offset = "0x2963240", VA = "0x182964440")]
	public static FCLFMGJFDHI<TMNode> CCLILGNNHME<TMNode, TMInput, TMOutput>([In] this HJGGENKMFLH<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMInput> NLFEJIHGBIC)
	{
		return default(FCLFMGJFDHI<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2965470", Offset = "0x2964270", VA = "0x182965470")]
	public static int PIIIKAAOONF<TMInput, TMOutput, TMNode>([In] this HJGGENKMFLH<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMInput> NLFEJIHGBIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2964C00", Offset = "0x2963A00", VA = "0x182964C00")]
	public static FCLFMGJFDHI<TMOutput> JHLMKFEFOME<TMOutput, TMInput, TMNode>([In] this HJGGENKMFLH<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMInput> NLFEJIHGBIC, int AELAKOMEEDP)
	{
		return default(FCLFMGJFDHI<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2964B30", Offset = "0x2963930", VA = "0x182964B30")]
	internal static void IANEOKFPFCI<TMInput, TMOutput, TMNode>(this HJGGENKMFLH<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMInput> NLFEJIHGBIC, FCLFMGJFDHI<TMOutput> DKECCAKJPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2964B30", Offset = "0x2963930", VA = "0x182964B30")]
	internal static void OACMCKBCNAH<TMInput, TMOutput, TMNode>(this HJGGENKMFLH<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMInput> NLFEJIHGBIC, FCLFMGJFDHI<TMOutput> DKECCAKJPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x269F7E0", Offset = "0x269E5E0", VA = "0x18269F7E0")]
	public static NGFOIHIBELM<FCLFMGJFDHI<TMOutput>>.GHHHKGFPNDA PGMPIHJMDEA<TMOutput, TMInput, TMNode>([In] this HJGGENKMFLH<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMInput> NLFEJIHGBIC)
	{
		return default(NGFOIHIBELM<FCLFMGJFDHI<TMOutput>>.GHHHKGFPNDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x269F7E0", Offset = "0x269E5E0", VA = "0x18269F7E0")]
	public static PIBDFLMMCNF<FCLFMGJFDHI<TMOutput>, NGFOIHIBELM<FCLFMGJFDHI<TMOutput>>.GHHHKGFPNDA> HNMCPBEOOLK<TMOutput, TMInput, TMNode>([In] this HJGGENKMFLH<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMInput> NLFEJIHGBIC)
	{
		return default(PIBDFLMMCNF<FCLFMGJFDHI<TMOutput>, NGFOIHIBELM<FCLFMGJFDHI<TMOutput>>.GHHHKGFPNDA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct LHOCGBCMBBI<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal BHCJOMCDNKI<TMNode> MHCCKKFHBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal FCECAFACGGB<TMNode, NGFOIHIBELM<FCLFMGJFDHI<TMInput>>> CKMOHOPJPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal FCECAFACGGB<TMNode, NGFOIHIBELM<FCLFMGJFDHI<TMOutput>>> PJOGGMKCJAI;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x383CB40", Offset = "0x383B940", VA = "0x18383CB40")]
	internal LHOCGBCMBBI([In] BHCJOMCDNKI<TMNode> KAPKOHJBFBG, [In] FCECAFACGGB<TMNode, NGFOIHIBELM<FCLFMGJFDHI<TMInput>>> KNFKKLBMLEP, [In] FCECAFACGGB<TMNode, NGFOIHIBELM<FCLFMGJFDHI<TMOutput>>> NPHPIACACPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x383C990", Offset = "0x383B790", VA = "0x18383C990")]
	internal static LHOCGBCMBBI<TMInput, TMOutput, TMNode> KHDJPNLCMFA()
	{
		return default(LHOCGBCMBBI<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class MGEHMIBOJHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x297DED0", Offset = "0x297CCD0", VA = "0x18297DED0")]
	internal static BEOGBFLCIKP JPFDICAGNEF<TMInput, TMOutput, TMNode>([In] this LHOCGBCMBBI<TMInput, TMOutput, TMNode> ILACEKALGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x297D6A0", Offset = "0x297C4A0", VA = "0x18297D6A0")]
	internal static LHOCGBCMBBI<TMInput, TMOutput, TMNode> FPNHMAJLCHC<TMInput, TMOutput, TMNode>(this BEOGBFLCIKP ILACEKALGJH)
	{
		return default(LHOCGBCMBBI<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x297D210", Offset = "0x297C010", VA = "0x18297D210")]
	private static MNKFIJBBBGN BMOAGLJCLIM<TMInput>([In] this NGFOIHIBELM<FCLFMGJFDHI<TMInput>> ILACEKALGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x297CFA0", Offset = "0x297BDA0", VA = "0x18297CFA0")]
	private static NGFOIHIBELM<FCLFMGJFDHI<TMInput>> AAAMCKIPKKO<TMInput>(this MNKFIJBBBGN ILACEKALGJH)
	{
		return default(NGFOIHIBELM<FCLFMGJFDHI<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x297D3E0", Offset = "0x297C1E0", VA = "0x18297D3E0")]
	private static IHMAJEBLOIO DHPFLBKGDIJ<TMOutput>([In] this NGFOIHIBELM<FCLFMGJFDHI<TMOutput>> ILACEKALGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x297DBA0", Offset = "0x297C9A0", VA = "0x18297DBA0")]
	private static NGFOIHIBELM<FCLFMGJFDHI<TMOutput>> HEDHCOIEKDI<TMOutput>(this IHMAJEBLOIO ILACEKALGJH)
	{
		return default(NGFOIHIBELM<FCLFMGJFDHI<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x297E3E0", Offset = "0x297D1E0", VA = "0x18297E3E0")]
	internal static void OFGJMFOHKEH<TMInput, TMOutput, TMNode>(this LHOCGBCMBBI<TMInput, TMOutput, TMNode> ILACEKALGJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x297E270", Offset = "0x297D070", VA = "0x18297E270")]
	internal static FCLFMGJFDHI<TMNode> LNNGIDHKCJM<TMNode, TMInput, TMOutput>(this LHOCGBCMBBI<TMInput, TMOutput, TMNode> ILACEKALGJH, [In] NGFOIHIBELM<FCLFMGJFDHI<TMInput>> KNFKKLBMLEP, [In] NGFOIHIBELM<FCLFMGJFDHI<TMOutput>> NPHPIACACPB)
	{
		return default(FCLFMGJFDHI<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x297DE10", Offset = "0x297CC10", VA = "0x18297DE10")]
	internal static void IHAHIMEKHEN<TMInput, TMOutput, TMNode>(this LHOCGBCMBBI<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMNode> NLFEJIHGBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x269FF90", Offset = "0x269ED90", VA = "0x18269FF90")]
	public static bool NKPMKKDPBBC<TMInput, TMOutput, TMNode>([In] this LHOCGBCMBBI<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMNode> NLFEJIHGBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x269FAE0", Offset = "0x269E8E0", VA = "0x18269FAE0")]
	public static int IHIKIDOFDPL<TMInput, TMOutput, TMNode>([In] this LHOCGBCMBBI<TMInput, TMOutput, TMNode> ILACEKALGJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x297D610", Offset = "0x297C410", VA = "0x18297D610")]
	public static int DLFOOBDKMEE<TMInput, TMOutput, TMNode>([In] this LHOCGBCMBBI<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMNode> NLFEJIHGBIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2965470", Offset = "0x2964270", VA = "0x182965470")]
	public static int PIIIKAAOONF<TMInput, TMOutput, TMNode>([In] this LHOCGBCMBBI<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMNode> NLFEJIHGBIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x297E300", Offset = "0x297D100", VA = "0x18297E300")]
	public static FCLFMGJFDHI<TMInput> MNKHGNDNCLJ<TMInput, TMOutput, TMNode>([In] this LHOCGBCMBBI<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMNode> NLFEJIHGBIC, int AELAKOMEEDP)
	{
		return default(FCLFMGJFDHI<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2964C00", Offset = "0x2963A00", VA = "0x182964C00")]
	public static FCLFMGJFDHI<TMOutput> JHLMKFEFOME<TMOutput, TMInput, TMNode>([In] this LHOCGBCMBBI<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMNode> NLFEJIHGBIC, int AELAKOMEEDP)
	{
		return default(FCLFMGJFDHI<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x297E3A0", Offset = "0x297D1A0", VA = "0x18297E3A0")]
	internal static void NOCGMDPKGGO<TMInput, TMOutput, TMNode>(this LHOCGBCMBBI<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMNode> NLFEJIHGBIC, FCLFMGJFDHI<TMInput> PFKCNGFFICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2964B30", Offset = "0x2963930", VA = "0x182964B30")]
	internal static void IANEOKFPFCI<TMInput, TMOutput, TMNode>(this LHOCGBCMBBI<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMNode> NLFEJIHGBIC, FCLFMGJFDHI<TMOutput> DKECCAKJPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x297E350", Offset = "0x297D150", VA = "0x18297E350")]
	internal static void NBLPEJFOLAB<TMInput, TMOutput, TMNode>(this LHOCGBCMBBI<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMNode> NLFEJIHGBIC, int AELAKOMEEDP, FCLFMGJFDHI<TMInput> PFKCNGFFICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x297D650", Offset = "0x297C450", VA = "0x18297D650")]
	internal static void EIINNIMCBKP<TMInput, TMOutput, TMNode>(this LHOCGBCMBBI<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMNode> NLFEJIHGBIC, int AELAKOMEEDP, FCLFMGJFDHI<TMOutput> DKECCAKJPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x297E3A0", Offset = "0x297D1A0", VA = "0x18297E3A0")]
	internal static void NDIABCABLAN<TMInput, TMOutput, TMNode>(this LHOCGBCMBBI<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMNode> NLFEJIHGBIC, FCLFMGJFDHI<TMInput> PFKCNGFFICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2964B30", Offset = "0x2963930", VA = "0x182964B30")]
	internal static void OACMCKBCNAH<TMInput, TMOutput, TMNode>(this LHOCGBCMBBI<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMNode> NLFEJIHGBIC, FCLFMGJFDHI<TMOutput> DKECCAKJPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x297D5B0", Offset = "0x297C3B0", VA = "0x18297D5B0")]
	public static NGFOIHIBELM<FCLFMGJFDHI<TMInput>>.GHHHKGFPNDA ODJMCDOGHPO<TMInput, TMOutput, TMNode>([In] this LHOCGBCMBBI<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMNode> NLFEJIHGBIC)
	{
		return default(NGFOIHIBELM<FCLFMGJFDHI<TMInput>>.GHHHKGFPNDA);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x269F7E0", Offset = "0x269E5E0", VA = "0x18269F7E0")]
	public static NGFOIHIBELM<FCLFMGJFDHI<TMOutput>>.GHHHKGFPNDA PGMPIHJMDEA<TMOutput, TMInput, TMNode>([In] this LHOCGBCMBBI<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMNode> NLFEJIHGBIC)
	{
		return default(NGFOIHIBELM<FCLFMGJFDHI<TMOutput>>.GHHHKGFPNDA);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x297D5B0", Offset = "0x297C3B0", VA = "0x18297D5B0")]
	public static PIBDFLMMCNF<FCLFMGJFDHI<TMInput>, NGFOIHIBELM<FCLFMGJFDHI<TMInput>>.GHHHKGFPNDA> DKFLDOIMGAJ<TMInput, TMOutput, TMNode>([In] this LHOCGBCMBBI<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMNode> NLFEJIHGBIC)
	{
		return default(PIBDFLMMCNF<FCLFMGJFDHI<TMInput>, NGFOIHIBELM<FCLFMGJFDHI<TMInput>>.GHHHKGFPNDA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x269F7E0", Offset = "0x269E5E0", VA = "0x18269F7E0")]
	public static PIBDFLMMCNF<FCLFMGJFDHI<TMOutput>, NGFOIHIBELM<FCLFMGJFDHI<TMOutput>>.GHHHKGFPNDA> HNMCPBEOOLK<TMOutput, TMInput, TMNode>([In] this LHOCGBCMBBI<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMNode> NLFEJIHGBIC)
	{
		return default(PIBDFLMMCNF<FCLFMGJFDHI<TMOutput>, NGFOIHIBELM<FCLFMGJFDHI<TMOutput>>.GHHHKGFPNDA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x269EFA0", Offset = "0x269DDA0", VA = "0x18269EFA0")]
	public static CBADNDLLJMD<FCLFMGJFDHI<TMNode>, BHCJOMCDNKI<TMNode>.LGHNPALILAB> PICJANNLAHM<TMNode, TMInput, TMOutput>([In] this LHOCGBCMBBI<TMInput, TMOutput, TMNode> ILACEKALGJH)
	{
		return default(CBADNDLLJMD<FCLFMGJFDHI<TMNode>, BHCJOMCDNKI<TMNode>.LGHNPALILAB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct FIDFABFIIJC<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal BHCJOMCDNKI<TMOutput> MHCCKKFHBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal FCECAFACGGB<TMOutput, FCLFMGJFDHI<TMNode>> IFPNLCEJCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal FCECAFACGGB<TMOutput, NGFOIHIBELM<FCLFMGJFDHI<TMInput>>> CKMOHOPJPND;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x383CB40", Offset = "0x383B940", VA = "0x18383CB40")]
	internal FIDFABFIIJC([In] BHCJOMCDNKI<TMOutput> KAPKOHJBFBG, [In] FCECAFACGGB<TMOutput, FCLFMGJFDHI<TMNode>> LPEJJNHCFKJ, [In] FCECAFACGGB<TMOutput, NGFOIHIBELM<FCLFMGJFDHI<TMInput>>> KNFKKLBMLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x383C990", Offset = "0x383B790", VA = "0x18383C990")]
	internal static FIDFABFIIJC<TMInput, TMOutput, TMNode> KHDJPNLCMFA()
	{
		return default(FIDFABFIIJC<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class MDEDCBIHIFE
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2977280", Offset = "0x2976080", VA = "0x182977280")]
	internal static PDCNGHAMOEL JPFDICAGNEF<TMInput, TMOutput, TMNode>([In] this FIDFABFIIJC<TMInput, TMOutput, TMNode> ILACEKALGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2976B10", Offset = "0x2975910", VA = "0x182976B10")]
	internal static FIDFABFIIJC<TMInput, TMOutput, TMNode> FPNHMAJLCHC<TMInput, TMOutput, TMNode>(this PDCNGHAMOEL ILACEKALGJH)
	{
		return default(FIDFABFIIJC<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2976940", Offset = "0x2975740", VA = "0x182976940")]
	private static MHNHKPCMDKL DIMJLCFCDMB<TMInput>([In] this NGFOIHIBELM<FCLFMGJFDHI<TMInput>> ILACEKALGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2977010", Offset = "0x2975E10", VA = "0x182977010")]
	private static NGFOIHIBELM<FCLFMGJFDHI<TMInput>> GLBDABKNIFD<TMInput>(this MHNHKPCMDKL ILACEKALGJH)
	{
		return default(NGFOIHIBELM<FCLFMGJFDHI<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x29652E0", Offset = "0x29640E0", VA = "0x1829652E0")]
	internal static void OFGJMFOHKEH<TMInput, TMOutput, TMNode>(this FIDFABFIIJC<TMInput, TMOutput, TMNode> ILACEKALGJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2964FD0", Offset = "0x2963DD0", VA = "0x182964FD0")]
	internal static FCLFMGJFDHI<TMOutput> LNNGIDHKCJM<TMOutput, TMInput, TMNode>(this FIDFABFIIJC<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMNode> FMEAKEGGFNK)
	{
		return default(FCLFMGJFDHI<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2964B70", Offset = "0x2963970", VA = "0x182964B70")]
	internal static void IHAHIMEKHEN<TMInput, TMOutput, TMNode>(this FIDFABFIIJC<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMOutput> NLFEJIHGBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x269FF90", Offset = "0x269ED90", VA = "0x18269FF90")]
	public static bool NKPMKKDPBBC<TMInput, TMOutput, TMNode>([In] this FIDFABFIIJC<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMOutput> NLFEJIHGBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x269FAE0", Offset = "0x269E8E0", VA = "0x18269FAE0")]
	public static int IHIKIDOFDPL<TMInput, TMOutput, TMNode>([In] this FIDFABFIIJC<TMInput, TMOutput, TMNode> ILACEKALGJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2964440", Offset = "0x2963240", VA = "0x182964440")]
	public static FCLFMGJFDHI<TMNode> CCLILGNNHME<TMNode, TMInput, TMOutput>([In] this FIDFABFIIJC<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMOutput> NLFEJIHGBIC)
	{
		return default(FCLFMGJFDHI<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2965470", Offset = "0x2964270", VA = "0x182965470")]
	public static int DLFOOBDKMEE<TMInput, TMOutput, TMNode>([In] this FIDFABFIIJC<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMOutput> NLFEJIHGBIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2964C00", Offset = "0x2963A00", VA = "0x182964C00")]
	public static FCLFMGJFDHI<TMInput> MNKHGNDNCLJ<TMInput, TMOutput, TMNode>([In] this FIDFABFIIJC<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMOutput> NLFEJIHGBIC, int AELAKOMEEDP)
	{
		return default(FCLFMGJFDHI<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2964B30", Offset = "0x2963930", VA = "0x182964B30")]
	internal static void NOCGMDPKGGO<TMInput, TMOutput, TMNode>(this FIDFABFIIJC<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMOutput> NLFEJIHGBIC, FCLFMGJFDHI<TMInput> PFKCNGFFICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2964B30", Offset = "0x2963930", VA = "0x182964B30")]
	internal static void NDIABCABLAN<TMInput, TMOutput, TMNode>(this FIDFABFIIJC<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMOutput> NLFEJIHGBIC, FCLFMGJFDHI<TMInput> PFKCNGFFICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x269F7E0", Offset = "0x269E5E0", VA = "0x18269F7E0")]
	public static NGFOIHIBELM<FCLFMGJFDHI<TMInput>>.GHHHKGFPNDA ODJMCDOGHPO<TMInput, TMOutput, TMNode>([In] this FIDFABFIIJC<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMOutput> NLFEJIHGBIC)
	{
		return default(NGFOIHIBELM<FCLFMGJFDHI<TMInput>>.GHHHKGFPNDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x269F7E0", Offset = "0x269E5E0", VA = "0x18269F7E0")]
	public static PIBDFLMMCNF<FCLFMGJFDHI<TMInput>, NGFOIHIBELM<FCLFMGJFDHI<TMInput>>.GHHHKGFPNDA> DKFLDOIMGAJ<TMInput, TMOutput, TMNode>([In] this FIDFABFIIJC<TMInput, TMOutput, TMNode> ILACEKALGJH, FCLFMGJFDHI<TMOutput> NLFEJIHGBIC)
	{
		return default(PIBDFLMMCNF<FCLFMGJFDHI<TMInput>, NGFOIHIBELM<FCLFMGJFDHI<TMInput>>.GHHHKGFPNDA>);
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
