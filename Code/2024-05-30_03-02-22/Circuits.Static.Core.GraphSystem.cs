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
		[Cpp2IlInjected.Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1ED1CD0", Offset = "0x1ED0ED0", VA = "0x181ED1CD0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7F3A00", Offset = "0x7F2C00", VA = "0x1807F3A00")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F3A40", Offset = "0x7F2C40", VA = "0x1807F3A40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct MOKKOEOFPMJ<TMInput, TMOutput, TMNode> : IEnumerator<MKMFEDEKPBJ<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private JIAEHBHLCGK<TMInput, TMOutput, TMNode> LLDFFHOKGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private AFELNDGEAFA<TMInput, TMOutput, TMNode> DACGACNIBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private bool PNDEEMDHFAB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly MKMFEDEKPBJ<TMNode> NPODDCIDCOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4152F80", Offset = "0x4152180", VA = "0x184152F80", Slot = "4")]
		get
		{
			return default(MKMFEDEKPBJ<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4152E30", Offset = "0x4152030", VA = "0x184152E30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4152EB0", Offset = "0x41520B0", VA = "0x184152EB0")]
	internal MOKKOEOFPMJ([In] JIAEHBHLCGK<TMInput, TMOutput, TMNode> BKEEEHANMCG, [In] AFELNDGEAFA<TMInput, TMOutput, TMNode> KDAIKKFHNLM, bool LGOEJIBGNHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4152CF0", Offset = "0x4151EF0", VA = "0x184152CF0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4152DB0", Offset = "0x4151FB0", VA = "0x184152DB0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4152C80", Offset = "0x4151E80", VA = "0x184152C80", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class MAIAPGPGDHO
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2A58C30", Offset = "0x2A57E30", VA = "0x182A58C30")]
	public static MOKKOEOFPMJ<TMInput, TMOutput, TMNode> EPPBEPCPNMI<TMInput, TMOutput, TMNode>([In] FGKDMCONBPO<TMInput, TMOutput, TMNode> HGBEPGEBPMN, MKMFEDEKPBJ<TMNode> PNCKNAFMFGK)
	{
		return default(MOKKOEOFPMJ<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct AFELNDGEAFA<TMInput, TMOutput, TMNode> : IEnumerator<MKMFEDEKPBJ<TMInput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CEHBIJEANKB<MKMFEDEKPBJ<TMOutput>>.OCHGOKIAFCM KFPMCIJMBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private CEHBIJEANKB<MKMFEDEKPBJ<TMInput>>.OCHGOKIAFCM JLEFHNICIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly HLMDFIFGEFB<TMInput, TMOutput, TMNode> ALLCLKENIOH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public MKMFEDEKPBJ<TMInput> NPODDCIDCOP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3BA9C60", Offset = "0x3BA8E60", VA = "0x183BA9C60", Slot = "4")]
		get
		{
			return default(MKMFEDEKPBJ<TMInput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3BA9B40", Offset = "0x3BA8D40", VA = "0x183BA9B40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3BA9BE0", Offset = "0x3BA8DE0", VA = "0x183BA9BE0")]
	internal AFELNDGEAFA([In] CEHBIJEANKB<MKMFEDEKPBJ<TMOutput>>.OCHGOKIAFCM PODOLNKBBNE, [In] CEHBIJEANKB<MKMFEDEKPBJ<TMInput>>.OCHGOKIAFCM GFEOHDGDKFH, [In] HLMDFIFGEFB<TMInput, TMOutput, TMNode> KACBJJFDECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3BA9980", Offset = "0x3BA8B80", VA = "0x183BA9980", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3BA9AD0", Offset = "0x3BA8CD0", VA = "0x183BA9AD0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3BA9910", Offset = "0x3BA8B10", VA = "0x183BA9910", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KHDHNHCPNHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2A21190", Offset = "0x2A20390", VA = "0x182A21190")]
	public static AFELNDGEAFA<TMInput, TMOutput, TMNode> EPPBEPCPNMI<TMInput, TMOutput, TMNode>([In] FGKDMCONBPO<TMInput, TMOutput, TMNode> HGBEPGEBPMN, MKMFEDEKPBJ<TMNode> PNCKNAFMFGK)
	{
		return default(AFELNDGEAFA<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct JIAEHBHLCGK<TMInput, TMOutput, TMNode> : IEnumerator<MKMFEDEKPBJ<TMOutput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private CEHBIJEANKB<MKMFEDEKPBJ<TMInput>>.OCHGOKIAFCM EMAEEHLIAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private CEHBIJEANKB<MKMFEDEKPBJ<TMOutput>>.OCHGOKIAFCM MBOGBJKKGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly PGDODIENPLI<TMInput, TMOutput, TMNode> NKOOJPCLPPJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public MKMFEDEKPBJ<TMOutput> NPODDCIDCOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3BA9C60", Offset = "0x3BA8E60", VA = "0x183BA9C60", Slot = "4")]
		get
		{
			return default(MKMFEDEKPBJ<TMOutput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3BA9B40", Offset = "0x3BA8D40", VA = "0x183BA9B40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3BA9BE0", Offset = "0x3BA8DE0", VA = "0x183BA9BE0")]
	internal JIAEHBHLCGK([In] CEHBIJEANKB<MKMFEDEKPBJ<TMInput>>.OCHGOKIAFCM HLBHDJAJFIL, [In] CEHBIJEANKB<MKMFEDEKPBJ<TMOutput>>.OCHGOKIAFCM KPCCLCAHALN, [In] PGDODIENPLI<TMInput, TMOutput, TMNode> KHLDLPOONGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3BA9980", Offset = "0x3BA8B80", VA = "0x183BA9980", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3BA9AD0", Offset = "0x3BA8CD0", VA = "0x183BA9AD0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3BA9910", Offset = "0x3BA8B10", VA = "0x183BA9910", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class LBPOHJLKFOE
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2A2FA00", Offset = "0x2A2EC00", VA = "0x182A2FA00")]
	public static JIAEHBHLCGK<TMInput, TMOutput, TMNode> EPPBEPCPNMI<TMInput, TMOutput, TMNode>([In] FGKDMCONBPO<TMInput, TMOutput, TMNode> HGBEPGEBPMN, MKMFEDEKPBJ<TMNode> PNCKNAFMFGK)
	{
		return default(JIAEHBHLCGK<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct FGKDMCONBPO<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public PGDODIENPLI<TMInput, TMOutput, TMNode> OKHJLBMMLME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public HLMDFIFGEFB<TMInput, TMOutput, TMNode> INILIEAFGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public FLLCCPKJEFD<TMInput, TMOutput, TMNode> EBCMLPFMMBO;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x39079A0", Offset = "0x3906BA0", VA = "0x1839079A0")]
	internal FGKDMCONBPO([In] PGDODIENPLI<TMInput, TMOutput, TMNode> KHLDLPOONGF, [In] HLMDFIFGEFB<TMInput, TMOutput, TMNode> KACBJJFDECN, [In] FLLCCPKJEFD<TMInput, TMOutput, TMNode> BKDKBKNOLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3907700", Offset = "0x3906900", VA = "0x183907700")]
	public static FGKDMCONBPO<TMInput?, TMOutput?, TMNode?> EPPBEPCPNMI()
	{
		return default(FGKDMCONBPO<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class PPFHHFEOHNG
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2B1B270", Offset = "0x2B1A470", VA = "0x182B1B270")]
	public static LAHAHFKPEFO? GKNEHCEDNDE<TMInput, TMOutput, TMNode>([In] this FGKDMCONBPO<TMInput, TMOutput, TMNode> CJKIBFNGPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2B1B510", Offset = "0x2B1A710", VA = "0x182B1B510")]
	public static FGKDMCONBPO<TMInput?, TMOutput?, TMNode?> IHPADLGFHBL<TMInput, TMOutput, TMNode>(this LAHAHFKPEFO CJKIBFNGPNM)
	{
		return default(FGKDMCONBPO<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2B1B450", Offset = "0x2B1A650", VA = "0x182B1B450")]
	public static void HJOADCBEFJH<TMInput, TMOutput, TMNode>(this FGKDMCONBPO<TMInput, TMOutput, TMNode> CJKIBFNGPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2B1B4B0", Offset = "0x2B1A6B0", VA = "0x182B1B4B0")]
	public static void IHJLDIGLLAH<TMInput, TMOutput, TMNode>(this FGKDMCONBPO<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMOutput> ENLDGMBNBEH, MKMFEDEKPBJ<TMInput> FFLOGODNOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2B1BC70", Offset = "0x2B1AE70", VA = "0x182B1BC70")]
	public static void NIJEHBLKJEM<TMInput, TMOutput, TMNode>(this FGKDMCONBPO<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMOutput> ENLDGMBNBEH, MKMFEDEKPBJ<TMInput> FFLOGODNOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2B1B0D0", Offset = "0x2B1A2D0", VA = "0x182B1B0D0")]
	public static int DIDGAKDJJNN<TMInput, TMOutput, TMNode>([In] this FGKDMCONBPO<TMInput, TMOutput, TMNode> CJKIBFNGPNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2B1B380", Offset = "0x2B1A580", VA = "0x182B1B380")]
	public static bool HCDPLFLJHJI<TMInput, TMOutput, TMNode>([In] this FGKDMCONBPO<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMOutput> ENLDGMBNBEH, MKMFEDEKPBJ<TMInput> FFLOGODNOIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2B1B350", Offset = "0x2B1A550", VA = "0x182B1B350")]
	public static bool GPKEPLAGMCL<TMInput, TMOutput, TMNode>([In] this FGKDMCONBPO<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMOutput> LBJEONCCHHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2B1BA10", Offset = "0x2B1AC10", VA = "0x182B1BA10")]
	public static bool MCHMEMKPEFJ<TMInput, TMOutput, TMNode>([In] this FGKDMCONBPO<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMInput> LBJEONCCHHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2B1BEF0", Offset = "0x2B1B0F0", VA = "0x182B1BEF0")]
	public static MKMFEDEKPBJ<TMNode?> PEGLPPONPKP<TMNode, TMInput, TMOutput>(this FGKDMCONBPO<TMInput, TMOutput, TMNode> CJKIBFNGPNM)
	{
		return default(MKMFEDEKPBJ<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2B1BDE0", Offset = "0x2B1AFE0", VA = "0x182B1BDE0")]
	public static void PEAFILIHMEP<TMInput, TMOutput, TMNode>(this FGKDMCONBPO<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMNode> PNCKNAFMFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2B1BB10", Offset = "0x2B1AD10", VA = "0x182B1BB10")]
	public static MKMFEDEKPBJ<TMInput?> NDDJFDOBCDJ<TMInput, TMOutput, TMNode>(this FGKDMCONBPO<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMNode> PNCKNAFMFGK)
	{
		return default(MKMFEDEKPBJ<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2B1B920", Offset = "0x2B1AB20", VA = "0x182B1B920")]
	public static MKMFEDEKPBJ<TMOutput?> KCPAFMKELCE<TMOutput, TMInput, TMNode>(this FGKDMCONBPO<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMNode> PNCKNAFMFGK)
	{
		return default(MKMFEDEKPBJ<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2B1AD70", Offset = "0x2B19F70", VA = "0x182B1AD70")]
	public static MKMFEDEKPBJ<TMInput?> AFPBGDFDAAJ<TMInput, TMOutput, TMNode>(this FGKDMCONBPO<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMNode> PNCKNAFMFGK, int PMNHOLIPOMJ)
	{
		return default(MKMFEDEKPBJ<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2B1B990", Offset = "0x2B1AB90", VA = "0x182B1B990")]
	public static MKMFEDEKPBJ<TMOutput?> KFGGMMHMLCM<TMOutput, TMInput, TMNode>(this FGKDMCONBPO<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMNode> PNCKNAFMFGK, int PMNHOLIPOMJ)
	{
		return default(MKMFEDEKPBJ<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2B1ADF0", Offset = "0x2B19FF0", VA = "0x182B1ADF0")]
	public static void BAADANJFPPP<TMInput, TMOutput, TMNode>(this FGKDMCONBPO<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMNode> PNCKNAFMFGK, int BFEMGDIHPGM, int OONCOKNDOFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2B1B880", Offset = "0x2B1AA80", VA = "0x182B1B880")]
	public static void IJAAJIDFCCC<TMInput, TMOutput, TMNode>(this FGKDMCONBPO<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMNode> PNCKNAFMFGK, int BFEMGDIHPGM, int OONCOKNDOFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2B1BB80", Offset = "0x2B1AD80", VA = "0x182B1BB80")]
	public static void NIECDKHBKDB<TMInput, TMOutput, TMNode>(this FGKDMCONBPO<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMInput> KKNMCFFINHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2B1BA30", Offset = "0x2B1AC30", VA = "0x182B1BA30")]
	public static void MLEADEDBFNA<TMInput, TMOutput, TMNode>(this FGKDMCONBPO<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMOutput> JCNECKHKKFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x865250", Offset = "0x864450", VA = "0x180865250")]
	public static JCDMAHIJFDH<TMInput?> POKBJOAPIBL<TMInput, TMOutput, TMNode>([In] this FGKDMCONBPO<TMInput, TMOutput, TMNode> CJKIBFNGPNM)
	{
		return default(JCDMAHIJFDH<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1EEA4C0", Offset = "0x1EE96C0", VA = "0x181EEA4C0")]
	public static JCDMAHIJFDH<TMOutput?> JKAGCFBLHAI<TMOutput, TMInput, TMNode>([In] this FGKDMCONBPO<TMInput, TMOutput, TMNode> CJKIBFNGPNM)
	{
		return default(JCDMAHIJFDH<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1EE9BC0", Offset = "0x1EE8DC0", VA = "0x181EE9BC0")]
	public static JCDMAHIJFDH<TMNode?> IJMNJPPLKOA<TMNode, TMInput, TMOutput>([In] this FGKDMCONBPO<TMInput, TMOutput, TMNode> CJKIBFNGPNM)
	{
		return default(JCDMAHIJFDH<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2B1B200", Offset = "0x2B1A400", VA = "0x182B1B200")]
	public static AFELNDGEAFA<TMInput?, TMOutput?, TMNode?> HNFACFEMHHC<TMInput, TMOutput, TMNode>([In] this FGKDMCONBPO<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMNode> IFAFPBGLEJO)
	{
		return default(AFELNDGEAFA<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2B1B200", Offset = "0x2B1A400", VA = "0x182B1B200")]
	public static JIAEHBHLCGK<TMInput?, TMOutput?, TMNode?> DMDMHKABDJL<TMInput, TMOutput, TMNode>([In] this FGKDMCONBPO<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMNode> IFAFPBGLEJO)
	{
		return default(JIAEHBHLCGK<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2B1B020", Offset = "0x2B1A220", VA = "0x182B1B020")]
	public static MOKKOEOFPMJ<TMInput?, TMOutput?, TMNode?> DCJAPHODGIJ<TMInput, TMOutput, TMNode>([In] this FGKDMCONBPO<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMNode> IFAFPBGLEJO)
	{
		return default(MOKKOEOFPMJ<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2B1BCD0", Offset = "0x2B1AED0", VA = "0x182B1BCD0")]
	public static HBNJDPADAFK<MKMFEDEKPBJ<TMInput?>, AFELNDGEAFA<TMInput?, TMOutput?, TMNode?>> OFDEKGKJLOP<TMInput, TMOutput, TMNode>([In] this FGKDMCONBPO<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMNode> IFAFPBGLEJO)
	{
		return default(HBNJDPADAFK<MKMFEDEKPBJ<TMInput>, AFELNDGEAFA<TMInput, TMOutput, TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2B1AE90", Offset = "0x2B1A090", VA = "0x182B1AE90")]
	public static HBNJDPADAFK<MKMFEDEKPBJ<TMNode?>, MOKKOEOFPMJ<TMInput?, TMOutput?, TMNode?>> BHIOPCMDJLH<TMNode, TMInput, TMOutput>([In] this FGKDMCONBPO<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMNode> IFAFPBGLEJO)
	{
		return default(HBNJDPADAFK<MKMFEDEKPBJ<TMNode>, MOKKOEOFPMJ<TMInput, TMOutput, TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct PGDODIENPLI<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal JCDMAHIJFDH<TMInput> DJACMBHGCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal MLGHBJBGIMP<TMInput, MKMFEDEKPBJ<TMNode>> CNKHBGFBIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal MLGHBJBGIMP<TMInput, CEHBIJEANKB<MKMFEDEKPBJ<TMOutput>>> ALLCLKENIOH;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3922880", Offset = "0x3921A80", VA = "0x183922880")]
	internal PGDODIENPLI([In] JCDMAHIJFDH<TMInput> JLKCLDMBDBK, [In] MLGHBJBGIMP<TMInput, MKMFEDEKPBJ<TMNode>> BKDKBKNOLEE, [In] MLGHBJBGIMP<TMInput, CEHBIJEANKB<MKMFEDEKPBJ<TMOutput>>> KACBJJFDECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x39226D0", Offset = "0x39218D0", VA = "0x1839226D0")]
	internal static PGDODIENPLI<TMInput, TMOutput, TMNode> EPPBEPCPNMI()
	{
		return default(PGDODIENPLI<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class AKDNAOFJHEB
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2FD6B40", Offset = "0x2FD5D40", VA = "0x182FD6B40")]
	internal static FKKHBFMCIFD GKNEHCEDNDE<TMInput, TMOutput, TMNode>([In] this PGDODIENPLI<TMInput, TMOutput, TMNode> CJKIBFNGPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2FD6ED0", Offset = "0x2FD60D0", VA = "0x182FD6ED0")]
	internal static PGDODIENPLI<TMInput, TMOutput, TMNode> IHPADLGFHBL<TMInput, TMOutput, TMNode>(this FKKHBFMCIFD CJKIBFNGPNM)
	{
		return default(PGDODIENPLI<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2FD73E0", Offset = "0x2FD65E0", VA = "0x182FD73E0")]
	private static DBOBMHIDEAN LAEMKLJPCLM<TMOutput>([In] this CEHBIJEANKB<MKMFEDEKPBJ<TMOutput>> CJKIBFNGPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2FD68C0", Offset = "0x2FD5AC0", VA = "0x182FD68C0")]
	private static CEHBIJEANKB<MKMFEDEKPBJ<TMOutput>> FHLLEJCHOAH<TMOutput>(this DBOBMHIDEAN CJKIBFNGPNM)
	{
		return default(CEHBIJEANKB<MKMFEDEKPBJ<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2A36D60", Offset = "0x2A35F60", VA = "0x182A36D60")]
	internal static void HJOADCBEFJH<TMInput, TMOutput, TMNode>(this PGDODIENPLI<TMInput, TMOutput, TMNode> CJKIBFNGPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2A36930", Offset = "0x2A35B30", VA = "0x182A36930")]
	internal static MKMFEDEKPBJ<TMInput> DJPABGLCGEC<TMInput, TMOutput, TMNode>(this PGDODIENPLI<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMNode> BKOKOKIHONK)
	{
		return default(MKMFEDEKPBJ<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2A368A0", Offset = "0x2A35AA0", VA = "0x182A368A0")]
	internal static void BNPNHCAJEDK<TMInput, TMOutput, TMNode>(this PGDODIENPLI<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMInput> IFAFPBGLEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x27744D0", Offset = "0x27736D0", VA = "0x1827744D0")]
	public static bool ABDMLBNKFOD<TMInput, TMOutput, TMNode>([In] this PGDODIENPLI<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMInput> IFAFPBGLEJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2776D10", Offset = "0x2775F10", VA = "0x182776D10")]
	public static int FBOPOPPKFDB<TMInput, TMOutput, TMNode>([In] this PGDODIENPLI<TMInput, TMOutput, TMNode> CJKIBFNGPNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2A36EF0", Offset = "0x2A360F0", VA = "0x182A36EF0")]
	public static MKMFEDEKPBJ<TMNode> IAGAIHIHENI<TMNode, TMInput, TMOutput>([In] this PGDODIENPLI<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMInput> IFAFPBGLEJO)
	{
		return default(MKMFEDEKPBJ<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2777D50", Offset = "0x2776F50", VA = "0x182777D50")]
	public static int NKHNKAHDOIO<TMInput, TMOutput, TMNode>([In] this PGDODIENPLI<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMInput> IFAFPBGLEJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2776D70", Offset = "0x2775F70", VA = "0x182776D70")]
	public static MKMFEDEKPBJ<TMOutput> GGAAOFNJICK<TMOutput, TMInput, TMNode>([In] this PGDODIENPLI<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMInput> IFAFPBGLEJO, int PMNHOLIPOMJ)
	{
		return default(MKMFEDEKPBJ<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2776D30", Offset = "0x2775F30", VA = "0x182776D30")]
	internal static void FLMNOHHGEJN<TMInput, TMOutput, TMNode>(this PGDODIENPLI<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMInput> IFAFPBGLEJO, MKMFEDEKPBJ<TMOutput> JCNECKHKKFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2776D30", Offset = "0x2775F30", VA = "0x182776D30")]
	internal static void PHAPFBPDAGM<TMInput, TMOutput, TMNode>(this PGDODIENPLI<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMInput> IFAFPBGLEJO, MKMFEDEKPBJ<TMOutput> JCNECKHKKFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2777A70", Offset = "0x2776C70", VA = "0x182777A70")]
	public static CEHBIJEANKB<MKMFEDEKPBJ<TMOutput>>.OCHGOKIAFCM LHGLPOIJCLO<TMOutput, TMInput, TMNode>([In] this PGDODIENPLI<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMInput> IFAFPBGLEJO)
	{
		return default(CEHBIJEANKB<MKMFEDEKPBJ<TMOutput>>.OCHGOKIAFCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2777A70", Offset = "0x2776C70", VA = "0x182777A70")]
	public static JOMAKAOFOPE<MKMFEDEKPBJ<TMOutput>, CEHBIJEANKB<MKMFEDEKPBJ<TMOutput>>.OCHGOKIAFCM> PJOLECDLBLF<TMOutput, TMInput, TMNode>([In] this PGDODIENPLI<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMInput> IFAFPBGLEJO)
	{
		return default(JOMAKAOFOPE<MKMFEDEKPBJ<TMOutput>, CEHBIJEANKB<MKMFEDEKPBJ<TMOutput>>.OCHGOKIAFCM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2777180", Offset = "0x2776380", VA = "0x182777180")]
	public static HBNJDPADAFK<MKMFEDEKPBJ<TMInput>, JCDMAHIJFDH<TMInput>.CAEIKJNJGLM> HEFOJNPOCPL<TMInput, TMOutput, TMNode>([In] this PGDODIENPLI<TMInput, TMOutput, TMNode> CJKIBFNGPNM)
	{
		return default(HBNJDPADAFK<MKMFEDEKPBJ<TMInput>, JCDMAHIJFDH<TMInput>.CAEIKJNJGLM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct FLLCCPKJEFD<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal JCDMAHIJFDH<TMNode> DJACMBHGCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal MLGHBJBGIMP<TMNode, CEHBIJEANKB<MKMFEDEKPBJ<TMInput>>> NKOOJPCLPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal MLGHBJBGIMP<TMNode, CEHBIJEANKB<MKMFEDEKPBJ<TMOutput>>> ALLCLKENIOH;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3922880", Offset = "0x3921A80", VA = "0x183922880")]
	internal FLLCCPKJEFD([In] JCDMAHIJFDH<TMNode> JLKCLDMBDBK, [In] MLGHBJBGIMP<TMNode, CEHBIJEANKB<MKMFEDEKPBJ<TMInput>>> KHLDLPOONGF, [In] MLGHBJBGIMP<TMNode, CEHBIJEANKB<MKMFEDEKPBJ<TMOutput>>> KACBJJFDECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x39226D0", Offset = "0x39218D0", VA = "0x1839226D0")]
	internal static FLLCCPKJEFD<TMInput, TMOutput, TMNode> EPPBEPCPNMI()
	{
		return default(FLLCCPKJEFD<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class BLFPPDEEDOI
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2776DC0", Offset = "0x2775FC0", VA = "0x182776DC0")]
	internal static IMOBEIPMIBJ GKNEHCEDNDE<TMInput, TMOutput, TMNode>([In] this FLLCCPKJEFD<TMInput, TMOutput, TMNode> CJKIBFNGPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2777480", Offset = "0x2776680", VA = "0x182777480")]
	internal static FLLCCPKJEFD<TMInput, TMOutput, TMNode> IHPADLGFHBL<TMInput, TMOutput, TMNode>(this IMOBEIPMIBJ CJKIBFNGPNM)
	{
		return default(FLLCCPKJEFD<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x27764B0", Offset = "0x27756B0", VA = "0x1827764B0")]
	private static NAFGCCNLFLI BEPPFCKCMCK<TMInput>([In] this CEHBIJEANKB<MKMFEDEKPBJ<TMInput>> CJKIBFNGPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2777AD0", Offset = "0x2776CD0", VA = "0x182777AD0")]
	private static CEHBIJEANKB<MKMFEDEKPBJ<TMInput>> MBLECALHPAJ<TMInput>(this NAFGCCNLFLI CJKIBFNGPNM)
	{
		return default(CEHBIJEANKB<MKMFEDEKPBJ<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2776680", Offset = "0x2775880", VA = "0x182776680")]
	private static GCJFLMMKMNK BLDIEBNPDCJ<TMOutput>([In] this CEHBIJEANKB<MKMFEDEKPBJ<TMOutput>> CJKIBFNGPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x27769A0", Offset = "0x2775BA0", VA = "0x1827769A0")]
	private static CEHBIJEANKB<MKMFEDEKPBJ<TMOutput>> CLFGEBJPIKD<TMOutput>(this GCJFLMMKMNK CJKIBFNGPNM)
	{
		return default(CEHBIJEANKB<MKMFEDEKPBJ<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x27771C0", Offset = "0x27763C0", VA = "0x1827771C0")]
	internal static void HJOADCBEFJH<TMInput, TMOutput, TMNode>(this FLLCCPKJEFD<TMInput, TMOutput, TMNode> CJKIBFNGPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2776C20", Offset = "0x2775E20", VA = "0x182776C20")]
	internal static MKMFEDEKPBJ<TMNode> DJPABGLCGEC<TMNode, TMInput, TMOutput>(this FLLCCPKJEFD<TMInput, TMOutput, TMNode> CJKIBFNGPNM, [In] CEHBIJEANKB<MKMFEDEKPBJ<TMInput>> KHLDLPOONGF, [In] CEHBIJEANKB<MKMFEDEKPBJ<TMOutput>> KACBJJFDECN)
	{
		return default(MKMFEDEKPBJ<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2776850", Offset = "0x2775A50", VA = "0x182776850")]
	internal static void BNPNHCAJEDK<TMInput, TMOutput, TMNode>(this FLLCCPKJEFD<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMNode> IFAFPBGLEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x27744D0", Offset = "0x27736D0", VA = "0x1827744D0")]
	public static bool ABDMLBNKFOD<TMInput, TMOutput, TMNode>([In] this FLLCCPKJEFD<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMNode> IFAFPBGLEJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2776D10", Offset = "0x2775F10", VA = "0x182776D10")]
	public static int FBOPOPPKFDB<TMInput, TMOutput, TMNode>([In] this FLLCCPKJEFD<TMInput, TMOutput, TMNode> CJKIBFNGPNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2777990", Offset = "0x2776B90", VA = "0x182777990")]
	public static int IJCHOCEHOEN<TMInput, TMOutput, TMNode>([In] this FLLCCPKJEFD<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMNode> IFAFPBGLEJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2777D50", Offset = "0x2776F50", VA = "0x182777D50")]
	public static int NKHNKAHDOIO<TMInput, TMOutput, TMNode>([In] this FLLCCPKJEFD<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMNode> IFAFPBGLEJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2776910", Offset = "0x2775B10", VA = "0x182776910")]
	public static MKMFEDEKPBJ<TMInput> BPNJLHFKFGH<TMInput, TMOutput, TMNode>([In] this FLLCCPKJEFD<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMNode> IFAFPBGLEJO, int PMNHOLIPOMJ)
	{
		return default(MKMFEDEKPBJ<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2776D70", Offset = "0x2775F70", VA = "0x182776D70")]
	public static MKMFEDEKPBJ<TMOutput> GGAAOFNJICK<TMOutput, TMInput, TMNode>([In] this FLLCCPKJEFD<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMNode> IFAFPBGLEJO, int PMNHOLIPOMJ)
	{
		return default(MKMFEDEKPBJ<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2776960", Offset = "0x2775B60", VA = "0x182776960")]
	internal static void DJNFOKPMFAO<TMInput, TMOutput, TMNode>(this FLLCCPKJEFD<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMNode> IFAFPBGLEJO, MKMFEDEKPBJ<TMInput> KKNMCFFINHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2776D30", Offset = "0x2775F30", VA = "0x182776D30")]
	internal static void FLMNOHHGEJN<TMInput, TMOutput, TMNode>(this FLLCCPKJEFD<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMNode> IFAFPBGLEJO, MKMFEDEKPBJ<TMOutput> JCNECKHKKFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2777A20", Offset = "0x2776C20", VA = "0x182777A20")]
	internal static void KPFDBMOGBJL<TMInput, TMOutput, TMNode>(this FLLCCPKJEFD<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMNode> IFAFPBGLEJO, int PMNHOLIPOMJ, MKMFEDEKPBJ<TMInput> KKNMCFFINHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x27779D0", Offset = "0x2776BD0", VA = "0x1827779D0")]
	internal static void JHLNKACNBEB<TMInput, TMOutput, TMNode>(this FLLCCPKJEFD<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMNode> IFAFPBGLEJO, int PMNHOLIPOMJ, MKMFEDEKPBJ<TMOutput> JCNECKHKKFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2776960", Offset = "0x2775B60", VA = "0x182776960")]
	internal static void CFLAGGKGPMJ<TMInput, TMOutput, TMNode>(this FLLCCPKJEFD<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMNode> IFAFPBGLEJO, MKMFEDEKPBJ<TMInput> KKNMCFFINHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2776D30", Offset = "0x2775F30", VA = "0x182776D30")]
	internal static void PHAPFBPDAGM<TMInput, TMOutput, TMNode>(this FLLCCPKJEFD<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMNode> IFAFPBGLEJO, MKMFEDEKPBJ<TMOutput> JCNECKHKKFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2776CB0", Offset = "0x2775EB0", VA = "0x182776CB0")]
	public static CEHBIJEANKB<MKMFEDEKPBJ<TMInput>>.OCHGOKIAFCM FADAJAAEHLL<TMInput, TMOutput, TMNode>([In] this FLLCCPKJEFD<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMNode> IFAFPBGLEJO)
	{
		return default(CEHBIJEANKB<MKMFEDEKPBJ<TMInput>>.OCHGOKIAFCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2777A70", Offset = "0x2776C70", VA = "0x182777A70")]
	public static CEHBIJEANKB<MKMFEDEKPBJ<TMOutput>>.OCHGOKIAFCM LHGLPOIJCLO<TMOutput, TMInput, TMNode>([In] this FLLCCPKJEFD<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMNode> IFAFPBGLEJO)
	{
		return default(CEHBIJEANKB<MKMFEDEKPBJ<TMOutput>>.OCHGOKIAFCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2776CB0", Offset = "0x2775EB0", VA = "0x182776CB0")]
	public static JOMAKAOFOPE<MKMFEDEKPBJ<TMInput>, CEHBIJEANKB<MKMFEDEKPBJ<TMInput>>.OCHGOKIAFCM> LFHBFPEDPDN<TMInput, TMOutput, TMNode>([In] this FLLCCPKJEFD<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMNode> IFAFPBGLEJO)
	{
		return default(JOMAKAOFOPE<MKMFEDEKPBJ<TMInput>, CEHBIJEANKB<MKMFEDEKPBJ<TMInput>>.OCHGOKIAFCM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2777A70", Offset = "0x2776C70", VA = "0x182777A70")]
	public static JOMAKAOFOPE<MKMFEDEKPBJ<TMOutput>, CEHBIJEANKB<MKMFEDEKPBJ<TMOutput>>.OCHGOKIAFCM> PJOLECDLBLF<TMOutput, TMInput, TMNode>([In] this FLLCCPKJEFD<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMNode> IFAFPBGLEJO)
	{
		return default(JOMAKAOFOPE<MKMFEDEKPBJ<TMOutput>, CEHBIJEANKB<MKMFEDEKPBJ<TMOutput>>.OCHGOKIAFCM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2777180", Offset = "0x2776380", VA = "0x182777180")]
	public static HBNJDPADAFK<MKMFEDEKPBJ<TMNode>, JCDMAHIJFDH<TMNode>.CAEIKJNJGLM> HEFOJNPOCPL<TMNode, TMInput, TMOutput>([In] this FLLCCPKJEFD<TMInput, TMOutput, TMNode> CJKIBFNGPNM)
	{
		return default(HBNJDPADAFK<MKMFEDEKPBJ<TMNode>, JCDMAHIJFDH<TMNode>.CAEIKJNJGLM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct HLMDFIFGEFB<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal JCDMAHIJFDH<TMOutput> DJACMBHGCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal MLGHBJBGIMP<TMOutput, MKMFEDEKPBJ<TMNode>> CNKHBGFBIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal MLGHBJBGIMP<TMOutput, CEHBIJEANKB<MKMFEDEKPBJ<TMInput>>> NKOOJPCLPPJ;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3922880", Offset = "0x3921A80", VA = "0x183922880")]
	internal HLMDFIFGEFB([In] JCDMAHIJFDH<TMOutput> JLKCLDMBDBK, [In] MLGHBJBGIMP<TMOutput, MKMFEDEKPBJ<TMNode>> BKDKBKNOLEE, [In] MLGHBJBGIMP<TMOutput, CEHBIJEANKB<MKMFEDEKPBJ<TMInput>>> KHLDLPOONGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x39226D0", Offset = "0x39218D0", VA = "0x1839226D0")]
	internal static HLMDFIFGEFB<TMInput, TMOutput, TMNode> EPPBEPCPNMI()
	{
		return default(HLMDFIFGEFB<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class LKGIGCMIPAF
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2A369D0", Offset = "0x2A35BD0", VA = "0x182A369D0")]
	internal static FAIFIAHBEFG GKNEHCEDNDE<TMInput, TMOutput, TMNode>([In] this HLMDFIFGEFB<TMInput, TMOutput, TMNode> CJKIBFNGPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2A36F10", Offset = "0x2A36110", VA = "0x182A36F10")]
	internal static HLMDFIFGEFB<TMInput, TMOutput, TMNode> IHPADLGFHBL<TMInput, TMOutput, TMNode>(this FAIFIAHBEFG CJKIBFNGPNM)
	{
		return default(HLMDFIFGEFB<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2A376A0", Offset = "0x2A368A0", VA = "0x182A376A0")]
	private static ECDDEALPMAG JPPJJDKGFPM<TMInput>([In] this CEHBIJEANKB<MKMFEDEKPBJ<TMInput>> CJKIBFNGPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2A37420", Offset = "0x2A36620", VA = "0x182A37420")]
	private static CEHBIJEANKB<MKMFEDEKPBJ<TMInput>> JNIBOKOMGJE<TMInput>(this ECDDEALPMAG CJKIBFNGPNM)
	{
		return default(CEHBIJEANKB<MKMFEDEKPBJ<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2A36D60", Offset = "0x2A35F60", VA = "0x182A36D60")]
	internal static void HJOADCBEFJH<TMInput, TMOutput, TMNode>(this HLMDFIFGEFB<TMInput, TMOutput, TMNode> CJKIBFNGPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2A36930", Offset = "0x2A35B30", VA = "0x182A36930")]
	internal static MKMFEDEKPBJ<TMOutput> DJPABGLCGEC<TMOutput, TMInput, TMNode>(this HLMDFIFGEFB<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMNode> BKOKOKIHONK)
	{
		return default(MKMFEDEKPBJ<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2A368A0", Offset = "0x2A35AA0", VA = "0x182A368A0")]
	internal static void BNPNHCAJEDK<TMInput, TMOutput, TMNode>(this HLMDFIFGEFB<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMOutput> IFAFPBGLEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x27744D0", Offset = "0x27736D0", VA = "0x1827744D0")]
	public static bool ABDMLBNKFOD<TMInput, TMOutput, TMNode>([In] this HLMDFIFGEFB<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMOutput> IFAFPBGLEJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2776D10", Offset = "0x2775F10", VA = "0x182776D10")]
	public static int FBOPOPPKFDB<TMInput, TMOutput, TMNode>([In] this HLMDFIFGEFB<TMInput, TMOutput, TMNode> CJKIBFNGPNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2A36EF0", Offset = "0x2A360F0", VA = "0x182A36EF0")]
	public static MKMFEDEKPBJ<TMNode> IAGAIHIHENI<TMNode, TMInput, TMOutput>([In] this HLMDFIFGEFB<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMOutput> IFAFPBGLEJO)
	{
		return default(MKMFEDEKPBJ<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2777D50", Offset = "0x2776F50", VA = "0x182777D50")]
	public static int IJCHOCEHOEN<TMInput, TMOutput, TMNode>([In] this HLMDFIFGEFB<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMOutput> IFAFPBGLEJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2776D70", Offset = "0x2775F70", VA = "0x182776D70")]
	public static MKMFEDEKPBJ<TMInput> BPNJLHFKFGH<TMInput, TMOutput, TMNode>([In] this HLMDFIFGEFB<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMOutput> IFAFPBGLEJO, int PMNHOLIPOMJ)
	{
		return default(MKMFEDEKPBJ<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2776D30", Offset = "0x2775F30", VA = "0x182776D30")]
	internal static void DJNFOKPMFAO<TMInput, TMOutput, TMNode>(this HLMDFIFGEFB<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMOutput> IFAFPBGLEJO, MKMFEDEKPBJ<TMInput> KKNMCFFINHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2776D30", Offset = "0x2775F30", VA = "0x182776D30")]
	internal static void CFLAGGKGPMJ<TMInput, TMOutput, TMNode>(this HLMDFIFGEFB<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMOutput> IFAFPBGLEJO, MKMFEDEKPBJ<TMInput> KKNMCFFINHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2777A70", Offset = "0x2776C70", VA = "0x182777A70")]
	public static CEHBIJEANKB<MKMFEDEKPBJ<TMInput>>.OCHGOKIAFCM FADAJAAEHLL<TMInput, TMOutput, TMNode>([In] this HLMDFIFGEFB<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMOutput> IFAFPBGLEJO)
	{
		return default(CEHBIJEANKB<MKMFEDEKPBJ<TMInput>>.OCHGOKIAFCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2777A70", Offset = "0x2776C70", VA = "0x182777A70")]
	public static JOMAKAOFOPE<MKMFEDEKPBJ<TMInput>, CEHBIJEANKB<MKMFEDEKPBJ<TMInput>>.OCHGOKIAFCM> LFHBFPEDPDN<TMInput, TMOutput, TMNode>([In] this HLMDFIFGEFB<TMInput, TMOutput, TMNode> CJKIBFNGPNM, MKMFEDEKPBJ<TMOutput> IFAFPBGLEJO)
	{
		return default(JOMAKAOFOPE<MKMFEDEKPBJ<TMInput>, CEHBIJEANKB<MKMFEDEKPBJ<TMInput>>.OCHGOKIAFCM>);
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
