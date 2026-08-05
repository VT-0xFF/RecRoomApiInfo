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
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
		[Cpp2IlInjected.Address(RVA = "0x28C2860", Offset = "0x28C1A60", VA = "0x1828C2860")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA2C560", Offset = "0xA2B760", VA = "0x180A2C560")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2C5A0", Offset = "0xA2B7A0", VA = "0x180A2C5A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct JEIACJFDPHK<TMNode> : IEnumerator<KCKEEEOMPIF<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly KCKEEEOMPIF<TMNode> DBGBJCOKBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly ENEMFDFPNBB<TMNode, KCKEEEOMPIF<TMNode>> NBEKALMGGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private KCKEEEOMPIF<TMNode> ELDFCKDEJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool EICFGIHIDGB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public KCKEEEOMPIF<TMNode> FJFNMMOOKII
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA09790", Offset = "0xA08990", VA = "0x180A09790", Slot = "4")]
		get
		{
			return default(KCKEEEOMPIF<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x502CF40", Offset = "0x502C140", VA = "0x18502CF40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x502CFB0", Offset = "0x502C1B0", VA = "0x18502CFB0")]
	internal JEIACJFDPHK(KCKEEEOMPIF<TMNode> EIGANLKFLHL, [In] ENEMFDFPNBB<TMNode, KCKEEEOMPIF<TMNode>> BODMFCLHIMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x502CD00", Offset = "0x502BF00", VA = "0x18502CD00", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x502CF30", Offset = "0x502C130", VA = "0x18502CF30", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct KPMMLFOGMIJ<TMNode>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal static readonly KCKEEEOMPIF<TMNode> HIEKKLNCLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal LANEICCBKCK<TMNode> MPKDPAFPLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal ENEMFDFPNBB<TMNode, KCKEEEOMPIF<TMNode>> NBEKALMGGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal ENEMFDFPNBB<TMNode, LNOHLJBMIPK<KCKEEEOMPIF<TMNode>>> AOFAJLANHDK;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x28BD4A0", Offset = "0x28BC6A0", VA = "0x1828BD4A0")]
	internal KPMMLFOGMIJ([In] LANEICCBKCK<TMNode> BJBPJLJOPHC, [In] ENEMFDFPNBB<TMNode, KCKEEEOMPIF<TMNode>> BODMFCLHIMI, [In] ENEMFDFPNBB<TMNode, LNOHLJBMIPK<KCKEEEOMPIF<TMNode>>> JJEDAAFOLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x516BFB0", Offset = "0x516B1B0", VA = "0x18516BFB0")]
	public static KPMMLFOGMIJ<TMNode> FAHGDJGLLGD()
	{
		return default(KPMMLFOGMIJ<TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class DCOABCFNEKM
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3852340", Offset = "0x3851540", VA = "0x183852340")]
	public static CMNOHKLCMEK ELKKKBEIKKA<TMNode>([In] this KPMMLFOGMIJ<TMNode> IPOCHJJJBCM) where TMNode : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3852890", Offset = "0x3851A90", VA = "0x183852890")]
	internal static PIHMEECJLFL JDIKJHOHFIB<TMNode>([In] this LNOHLJBMIPK<KCKEEEOMPIF<TMNode>> IPOCHJJJBCM) where TMNode : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3851F20", Offset = "0x3851120", VA = "0x183851F20")]
	internal static LNOHLJBMIPK<KCKEEEOMPIF<TMNode>> COIJPALCJHG<TMNode>(this PIHMEECJLFL IPOCHJJJBCM) where TMNode : notnull
	{
		return default(LNOHLJBMIPK<KCKEEEOMPIF<TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3851D50", Offset = "0x3850F50", VA = "0x183851D50")]
	public static void BEPHGAAGPAM<TMNode>(this KPMMLFOGMIJ<TMNode> IPOCHJJJBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x38527B0", Offset = "0x38519B0", VA = "0x1838527B0")]
	public static bool IBDFDDCHHCK<TMNode>([In] this KPMMLFOGMIJ<TMNode> IPOCHJJJBCM, KCKEEEOMPIF<TMNode> APBCLGNDGBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x38527C0", Offset = "0x38519C0", VA = "0x1838527C0")]
	public static int IKAFADNEFPB<TMNode>([In] this KPMMLFOGMIJ<TMNode> IPOCHJJJBCM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3852B50", Offset = "0x3851D50", VA = "0x183852B50")]
	public static KCKEEEOMPIF<TMNode?> LOEGJJFGMIL<TMNode>(this KPMMLFOGMIJ<TMNode> IPOCHJJJBCM)
	{
		return default(KCKEEEOMPIF<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3852A60", Offset = "0x3851C60", VA = "0x183852A60")]
	public static KCKEEEOMPIF<TMNode?> JHIOCPHJADM<TMNode>(this KPMMLFOGMIJ<TMNode> IPOCHJJJBCM, KCKEEEOMPIF<TMNode> FLKKOCNDECC)
	{
		return default(KCKEEEOMPIF<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3852C40", Offset = "0x3851E40", VA = "0x183852C40")]
	public static void NCGHJFCANHM<TMNode>(this KPMMLFOGMIJ<TMNode> IPOCHJJJBCM, KCKEEEOMPIF<TMNode> APBCLGNDGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x38522B0", Offset = "0x38514B0", VA = "0x1838522B0")]
	public static bool EEFKKNIEIKA<TMNode>([In] this KPMMLFOGMIJ<TMNode> IPOCHJJJBCM, KCKEEEOMPIF<TMNode> APBCLGNDGBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3852B30", Offset = "0x3851D30", VA = "0x183852B30")]
	public static KCKEEEOMPIF<TMNode?> JMBNDFCBJBM<TMNode>([In] this KPMMLFOGMIJ<TMNode> IPOCHJJJBCM, KCKEEEOMPIF<TMNode> APBCLGNDGBE)
	{
		return default(KCKEEEOMPIF<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x38527D0", Offset = "0x38519D0", VA = "0x1838527D0")]
	public static KCKEEEOMPIF<TMNode?>? JCFPDFAEGJP<TMNode>([In] this KPMMLFOGMIJ<TMNode> IPOCHJJJBCM, KCKEEEOMPIF<TMNode> APBCLGNDGBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3852180", Offset = "0x3851380", VA = "0x183852180")]
	public static void DHBPMEGBLKK<TMNode>(this KPMMLFOGMIJ<TMNode> IPOCHJJJBCM, KCKEEEOMPIF<TMNode> APBCLGNDGBE, KCKEEEOMPIF<TMNode> OEMGNMMGLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x38526C0", Offset = "0x38518C0", VA = "0x1838526C0")]
	public static OGCMMCHINJD<KCKEEEOMPIF<TMNode?>, LNOHLJBMIPK<KCKEEEOMPIF<TMNode?>>.EPPMJMNPKEB> EMMNNDHNAOE<TMNode>([In] this KPMMLFOGMIJ<TMNode> IPOCHJJJBCM, KCKEEEOMPIF<TMNode> APBCLGNDGBE)
	{
		return default(OGCMMCHINJD<KCKEEEOMPIF<TMNode>, LNOHLJBMIPK<KCKEEEOMPIF<TMNode>>.EPPMJMNPKEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xCDE2C0", Offset = "0xCDD4C0", VA = "0x180CDE2C0")]
	public static LANEICCBKCK<TMNode?> DFLFACKNNFD<TMNode>([In] this KPMMLFOGMIJ<TMNode> IPOCHJJJBCM)
	{
		return default(LANEICCBKCK<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3851EE0", Offset = "0x38510E0", VA = "0x183851EE0")]
	public static LANEICCBKCK<TMNode?>.IPCMPIBKNPK BFKODFEKGDL<TMNode>([In] this KPMMLFOGMIJ<TMNode> IPOCHJJJBCM)
	{
		return default(LANEICCBKCK<TMNode>.IPCMPIBKNPK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3851D10", Offset = "0x3850F10", VA = "0x183851D10")]
	public static MNFEJHFBPAJ<KCKEEEOMPIF<TMNode?>, LANEICCBKCK<TMNode?>.IPCMPIBKNPK> ACMDJCHCBFI<TMNode>([In] this KPMMLFOGMIJ<TMNode> IPOCHJJJBCM)
	{
		return default(MNFEJHFBPAJ<KCKEEEOMPIF<TMNode>, LANEICCBKCK<TMNode>.IPCMPIBKNPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3852EA0", Offset = "0x38520A0", VA = "0x183852EA0")]
	public static bool OIFMIEKMIKG<TMNode>([In] this KPMMLFOGMIJ<TMNode> IPOCHJJJBCM, KCKEEEOMPIF<TMNode> HFACGLFOMBB, KCKEEEOMPIF<TMNode> CHIAOJJGKAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3852720", Offset = "0x3851920", VA = "0x183852720")]
	public static MNFEJHFBPAJ<KCKEEEOMPIF<TMNode?>, JEIACJFDPHK<TMNode?>> HGPIEIIFEBP<TMNode>([In] this KPMMLFOGMIJ<TMNode> IPOCHJJJBCM, KCKEEEOMPIF<TMNode> HFACGLFOMBB)
	{
		return default(MNFEJHFBPAJ<KCKEEEOMPIF<TMNode>, JEIACJFDPHK<TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class LKMKGDPAPBF
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3ACC2E0", Offset = "0x3ACB4E0", VA = "0x183ACC2E0")]
	public static KPMMLFOGMIJ<TMNode> BHIBMPPAILM<TMNode>(this CMNOHKLCMEK IPOCHJJJBCM) where TMNode : notnull
	{
		return default(KPMMLFOGMIJ<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x28C2670", Offset = "0x28C1870", VA = "0x1828C2670")]
	public static void NCGHJFCANHM(this CMNOHKLCMEK IPOCHJJJBCM, int APBCLGNDGBE)
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
