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
		[Cpp2IlInjected.Address(RVA = "0x1DF1A90", Offset = "0x1DF0E90", VA = "0x181DF1A90")]
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
public struct ELPBIAKGICB<TMInput, TMOutput, TMNode> : IEnumerator<CEECNPFCENP<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private PFMLLKCPKKE<TMInput, TMOutput, TMNode> ACACCFPMBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NLABFEEDAIC<TMInput, TMOutput, TMNode> ILFLJCLFLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private bool OBPILALIJLP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly CEECNPFCENP<TMNode> MPGEHNMDMNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3369CD0", Offset = "0x33690D0", VA = "0x183369CD0", Slot = "4")]
		get
		{
			return default(CEECNPFCENP<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3369B70", Offset = "0x3368F70", VA = "0x183369B70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3369C00", Offset = "0x3369000", VA = "0x183369C00")]
	internal ELPBIAKGICB([In] PFMLLKCPKKE<TMInput, TMOutput, TMNode> NCPKJPLOEMJ, [In] NLABFEEDAIC<TMInput, TMOutput, TMNode> BIBOLEKLAME, bool DGNLHAKMPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3369A30", Offset = "0x3368E30", VA = "0x183369A30", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3369AF0", Offset = "0x3368EF0", VA = "0x183369AF0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x33699B0", Offset = "0x3368DB0", VA = "0x1833699B0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class ILBAHCHMNBC
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x282F180", Offset = "0x282E580", VA = "0x18282F180")]
	public static ELPBIAKGICB<TMInput, TMOutput, TMNode> HGJFOBLHCKL<TMInput, TMOutput, TMNode>([In] MJPLIIJGJEM<TMInput, TMOutput, TMNode> OBGCOIEBMDG, CEECNPFCENP<TMNode> IPJEEPFEOCM)
	{
		return default(ELPBIAKGICB<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct NLABFEEDAIC<TMInput, TMOutput, TMNode> : IEnumerator<CEECNPFCENP<TMInput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private OONLFEIMAID<CEECNPFCENP<TMOutput>>.DFJBEGPLHED NIKBHGLJCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private OONLFEIMAID<CEECNPFCENP<TMInput>>.DFJBEGPLHED LOGPHFCDBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly MBOAONAHPJE<TMInput, TMOutput, TMNode> HNOEGAOOMKD;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public CEECNPFCENP<TMInput> MPGEHNMDMNL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3FD3FC0", Offset = "0x3FD33C0", VA = "0x183FD3FC0", Slot = "4")]
		get
		{
			return default(CEECNPFCENP<TMInput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3FD3E90", Offset = "0x3FD3290", VA = "0x183FD3E90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3FD3F40", Offset = "0x3FD3340", VA = "0x183FD3F40")]
	internal NLABFEEDAIC([In] OONLFEIMAID<CEECNPFCENP<TMOutput>>.DFJBEGPLHED CGDKAMCILFA, [In] OONLFEIMAID<CEECNPFCENP<TMInput>>.DFJBEGPLHED FEHNJHABINK, [In] MBOAONAHPJE<TMInput, TMOutput, TMNode> PAFGLOPGPCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3FD3CC0", Offset = "0x3FD30C0", VA = "0x183FD3CC0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3FD3E20", Offset = "0x3FD3220", VA = "0x183FD3E20", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3FD3C50", Offset = "0x3FD3050", VA = "0x183FD3C50", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class LCIFJNGEIBK
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2884940", Offset = "0x2883D40", VA = "0x182884940")]
	public static NLABFEEDAIC<TMInput, TMOutput, TMNode> HGJFOBLHCKL<TMInput, TMOutput, TMNode>([In] MJPLIIJGJEM<TMInput, TMOutput, TMNode> OBGCOIEBMDG, CEECNPFCENP<TMNode> IPJEEPFEOCM)
	{
		return default(NLABFEEDAIC<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct PFMLLKCPKKE<TMInput, TMOutput, TMNode> : IEnumerator<CEECNPFCENP<TMOutput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private OONLFEIMAID<CEECNPFCENP<TMInput>>.DFJBEGPLHED GOCCGLHEGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private OONLFEIMAID<CEECNPFCENP<TMOutput>>.DFJBEGPLHED NPEOAEHCPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly ICADBGBAOMP<TMInput, TMOutput, TMNode> NPJOMAMLIIP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CEECNPFCENP<TMOutput> MPGEHNMDMNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3FD3FC0", Offset = "0x3FD33C0", VA = "0x183FD3FC0", Slot = "4")]
		get
		{
			return default(CEECNPFCENP<TMOutput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3FD3E90", Offset = "0x3FD3290", VA = "0x183FD3E90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3FD3F40", Offset = "0x3FD3340", VA = "0x183FD3F40")]
	internal PFMLLKCPKKE([In] OONLFEIMAID<CEECNPFCENP<TMInput>>.DFJBEGPLHED AOBPFNOHMPO, [In] OONLFEIMAID<CEECNPFCENP<TMOutput>>.DFJBEGPLHED FMPMAFEHFPM, [In] ICADBGBAOMP<TMInput, TMOutput, TMNode> DGBCALFBOAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3FD3CC0", Offset = "0x3FD30C0", VA = "0x183FD3CC0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3FD3E20", Offset = "0x3FD3220", VA = "0x183FD3E20", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3FD3C50", Offset = "0x3FD3050", VA = "0x183FD3C50", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class MAHPJMEPMCI
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x28A2C70", Offset = "0x28A2070", VA = "0x1828A2C70")]
	public static PFMLLKCPKKE<TMInput, TMOutput, TMNode> HGJFOBLHCKL<TMInput, TMOutput, TMNode>([In] MJPLIIJGJEM<TMInput, TMOutput, TMNode> OBGCOIEBMDG, CEECNPFCENP<TMNode> IPJEEPFEOCM)
	{
		return default(PFMLLKCPKKE<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct MJPLIIJGJEM<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public ICADBGBAOMP<TMInput, TMOutput, TMNode> OHOHGFFIMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public MBOAONAHPJE<TMInput, TMOutput, TMNode> PIEMLLGMIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public IFPOJJEBAJO<TMInput, TMOutput, TMNode> PJEAEEEOIGI;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3F098C0", Offset = "0x3F08CC0", VA = "0x183F098C0")]
	internal MJPLIIJGJEM([In] ICADBGBAOMP<TMInput, TMOutput, TMNode> DGBCALFBOAG, [In] MBOAONAHPJE<TMInput, TMOutput, TMNode> PAFGLOPGPCO, [In] IFPOJJEBAJO<TMInput, TMOutput, TMNode> DCFFCEBKIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3F09610", Offset = "0x3F08A10", VA = "0x183F09610")]
	public static MJPLIIJGJEM<TMInput?, TMOutput?, TMNode?> HGJFOBLHCKL()
	{
		return default(MJPLIIJGJEM<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class DNDOBPAPGCG
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2666D70", Offset = "0x2666170", VA = "0x182666D70")]
	public static HJEDOMBGBML? HBIMCCJEPGN<TMInput, TMOutput, TMNode>([In] this MJPLIIJGJEM<TMInput, TMOutput, TMNode> MEEBIDIALDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2666710", Offset = "0x2665B10", VA = "0x182666710")]
	public static MJPLIIJGJEM<TMInput?, TMOutput?, TMNode?> CMCHCKHHIFC<TMInput, TMOutput, TMNode>(this HJEDOMBGBML MEEBIDIALDO)
	{
		return default(MJPLIIJGJEM<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2666D10", Offset = "0x2666110", VA = "0x182666D10")]
	public static void FHLEEDLMEFH<TMInput, TMOutput, TMNode>(this MJPLIIJGJEM<TMInput, TMOutput, TMNode> MEEBIDIALDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2667070", Offset = "0x2666470", VA = "0x182667070")]
	public static void ICNELGKKLDB<TMInput, TMOutput, TMNode>(this MJPLIIJGJEM<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMOutput> KDAFHKOLINM, CEECNPFCENP<TMInput> MLFPBIGKPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2666C20", Offset = "0x2666020", VA = "0x182666C20")]
	public static void EIIONFPHHBA<TMInput, TMOutput, TMNode>(this MJPLIIJGJEM<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMOutput> KDAFHKOLINM, CEECNPFCENP<TMInput> MLFPBIGKPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2666640", Offset = "0x2665A40", VA = "0x182666640")]
	public static bool CLNEGCPILKL<TMInput, TMOutput, TMNode>([In] this MJPLIIJGJEM<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMOutput> KDAFHKOLINM, CEECNPFCENP<TMInput> MLFPBIGKPEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2666C80", Offset = "0x2666080", VA = "0x182666C80")]
	public static CEECNPFCENP<TMNode?> EOLOLGPIMPK<TMNode, TMInput, TMOutput>(this MJPLIIJGJEM<TMInput, TMOutput, TMNode> MEEBIDIALDO)
	{
		return default(CEECNPFCENP<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2666E50", Offset = "0x2666250", VA = "0x182666E50")]
	public static void HCNGJCOEFHJ<TMInput, TMOutput, TMNode>(this MJPLIIJGJEM<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMNode> IPJEEPFEOCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x26674E0", Offset = "0x26668E0", VA = "0x1826674E0")]
	public static CEECNPFCENP<TMInput?> MECFNPMFLDF<TMInput, TMOutput, TMNode>(this MJPLIIJGJEM<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMNode> IPJEEPFEOCM)
	{
		return default(CEECNPFCENP<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2667550", Offset = "0x2666950", VA = "0x182667550")]
	public static CEECNPFCENP<TMOutput?> MNPCBHEMKKH<TMOutput, TMInput, TMNode>(this MJPLIIJGJEM<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMNode> IPJEEPFEOCM)
	{
		return default(CEECNPFCENP<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2666510", Offset = "0x2665910", VA = "0x182666510")]
	public static CEECNPFCENP<TMInput?> BCCPEBBJNHD<TMInput, TMOutput, TMNode>(this MJPLIIJGJEM<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMNode> IPJEEPFEOCM, int PMLKPJNGBAD)
	{
		return default(CEECNPFCENP<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x26670D0", Offset = "0x26664D0", VA = "0x1826670D0")]
	public static CEECNPFCENP<TMOutput?> IMANFEFEPPF<TMOutput, TMInput, TMNode>(this MJPLIIJGJEM<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMNode> IPJEEPFEOCM, int PMLKPJNGBAD)
	{
		return default(CEECNPFCENP<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2666F60", Offset = "0x2666360", VA = "0x182666F60")]
	public static void HGACFIHCNGB<TMInput, TMOutput, TMNode>(this MJPLIIJGJEM<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMNode> IPJEEPFEOCM, int OLEGNKLBLCE, int CALPLAKKDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2666B80", Offset = "0x2665F80", VA = "0x182666B80")]
	public static void EGIHGCDIDCO<TMInput, TMOutput, TMNode>(this MJPLIIJGJEM<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMNode> IPJEEPFEOCM, int OLEGNKLBLCE, int CALPLAKKDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2666A90", Offset = "0x2665E90", VA = "0x182666A90")]
	public static void EACHDEDFDGG<TMInput, TMOutput, TMNode>(this MJPLIIJGJEM<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMInput> OHOJMGNOIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x26672E0", Offset = "0x26666E0", VA = "0x1826672E0")]
	public static void KIHAJLJNLKP<TMInput, TMOutput, TMNode>(this MJPLIIJGJEM<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMOutput> KJMLGAEJIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x87D480", Offset = "0x87C880", VA = "0x18087D480")]
	public static DOCCPFAGOMH<TMInput?> GJOLPMOLDJP<TMInput, TMOutput, TMNode>([In] this MJPLIIJGJEM<TMInput, TMOutput, TMNode> MEEBIDIALDO)
	{
		return default(DOCCPFAGOMH<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2666A80", Offset = "0x2665E80", VA = "0x182666A80")]
	public static DOCCPFAGOMH<TMOutput?> DHGPPJNFLDB<TMOutput, TMInput, TMNode>([In] this MJPLIIJGJEM<TMInput, TMOutput, TMNode> MEEBIDIALDO)
	{
		return default(DOCCPFAGOMH<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x26673C0", Offset = "0x26667C0", VA = "0x1826673C0")]
	public static DOCCPFAGOMH<TMNode?> KMLLGEOFLPD<TMNode, TMInput, TMOutput>([In] this MJPLIIJGJEM<TMInput, TMOutput, TMNode> MEEBIDIALDO)
	{
		return default(DOCCPFAGOMH<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2667000", Offset = "0x2666400", VA = "0x182667000")]
	public static NLABFEEDAIC<TMInput?, TMOutput?, TMNode?> HKBNDCLHABC<TMInput, TMOutput, TMNode>([In] this MJPLIIJGJEM<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMNode> BFMGPLIBCKL)
	{
		return default(NLABFEEDAIC<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2667000", Offset = "0x2666400", VA = "0x182667000")]
	public static PFMLLKCPKKE<TMInput?, TMOutput?, TMNode?> JBKIPBPICLI<TMInput, TMOutput, TMNode>([In] this MJPLIIJGJEM<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMNode> BFMGPLIBCKL)
	{
		return default(PFMLLKCPKKE<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2666590", Offset = "0x2665990", VA = "0x182666590")]
	public static ELPBIAKGICB<TMInput?, TMOutput?, TMNode?> BKMDDDLMGOL<TMInput, TMOutput, TMNode>([In] this MJPLIIJGJEM<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMNode> BFMGPLIBCKL)
	{
		return default(ELPBIAKGICB<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x26673D0", Offset = "0x26667D0", VA = "0x1826673D0")]
	public static OCIEPPKJBLK<CEECNPFCENP<TMInput?>, NLABFEEDAIC<TMInput?, TMOutput?, TMNode?>> KOOLPEJDBAM<TMInput, TMOutput, TMNode>([In] this MJPLIIJGJEM<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMNode> BFMGPLIBCKL)
	{
		return default(OCIEPPKJBLK<CEECNPFCENP<TMInput>, NLABFEEDAIC<TMInput, TMOutput, TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2667150", Offset = "0x2666550", VA = "0x182667150")]
	public static OCIEPPKJBLK<CEECNPFCENP<TMNode?>, ELPBIAKGICB<TMInput?, TMOutput?, TMNode?>> JNCANNPHGEL<TMNode, TMInput, TMOutput>([In] this MJPLIIJGJEM<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMNode> BFMGPLIBCKL)
	{
		return default(OCIEPPKJBLK<CEECNPFCENP<TMNode>, ELPBIAKGICB<TMInput, TMOutput, TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct ICADBGBAOMP<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal DOCCPFAGOMH<TMInput> MCOMOHHIIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal HMEBJJCHPDI<TMInput, CEECNPFCENP<TMNode>> CBCDEHHICCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal HMEBJJCHPDI<TMInput, OONLFEIMAID<CEECNPFCENP<TMOutput>>> HNOEGAOOMKD;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x39967E0", Offset = "0x3995BE0", VA = "0x1839967E0")]
	internal ICADBGBAOMP([In] DOCCPFAGOMH<TMInput> CJMPECHLICD, [In] HMEBJJCHPDI<TMInput, CEECNPFCENP<TMNode>> DCFFCEBKIAN, [In] HMEBJJCHPDI<TMInput, OONLFEIMAID<CEECNPFCENP<TMOutput>>> PAFGLOPGPCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3996620", Offset = "0x3995A20", VA = "0x183996620")]
	internal static ICADBGBAOMP<TMInput, TMOutput, TMNode> HGJFOBLHCKL()
	{
		return default(ICADBGBAOMP<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class KEKAFHPIKCL
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x286CBC0", Offset = "0x286BFC0", VA = "0x18286CBC0")]
	internal static INNDDJENHHE HBIMCCJEPGN<TMInput, TMOutput, TMNode>([In] this ICADBGBAOMP<TMInput, TMOutput, TMNode> MEEBIDIALDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x286C520", Offset = "0x286B920", VA = "0x18286C520")]
	internal static ICADBGBAOMP<TMInput, TMOutput, TMNode> CMCHCKHHIFC<TMInput, TMOutput, TMNode>(this INNDDJENHHE MEEBIDIALDO)
	{
		return default(ICADBGBAOMP<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x286C350", Offset = "0x286B750", VA = "0x18286C350")]
	private static ADBKJKDEGJF ANPMIAIBHLL<TMOutput>([In] this OONLFEIMAID<CEECNPFCENP<TMOutput>> MEEBIDIALDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x286D000", Offset = "0x286C400", VA = "0x18286D000")]
	private static OONLFEIMAID<CEECNPFCENP<TMOutput>> LEDCEKABCLB<TMOutput>(this ADBKJKDEGJF MEEBIDIALDO)
	{
		return default(OONLFEIMAID<CEECNPFCENP<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x286CA30", Offset = "0x286BE30", VA = "0x18286CA30")]
	internal static void FHLEEDLMEFH<TMInput, TMOutput, TMNode>(this ICADBGBAOMP<TMInput, TMOutput, TMNode> MEEBIDIALDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x286D280", Offset = "0x286C680", VA = "0x18286D280")]
	internal static CEECNPFCENP<TMInput> PFEIPFNMOCD<TMInput, TMOutput, TMNode>(this ICADBGBAOMP<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMNode> HBIAHPFPLFB)
	{
		return default(CEECNPFCENP<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x286CF70", Offset = "0x286C370", VA = "0x18286CF70")]
	internal static void LBDCCEJODEM<TMInput, TMOutput, TMNode>(this ICADBGBAOMP<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMInput> BFMGPLIBCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x25C6ED0", Offset = "0x25C62D0", VA = "0x1825C6ED0")]
	public static bool AJPDEGILBCF<TMInput, TMOutput, TMNode>([In] this ICADBGBAOMP<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMInput> BFMGPLIBCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x24A8AD0", Offset = "0x24A7ED0", VA = "0x1824A8AD0")]
	public static int NDIIMGODLPM<TMInput, TMOutput, TMNode>([In] this ICADBGBAOMP<TMInput, TMOutput, TMNode> MEEBIDIALDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x286CF50", Offset = "0x286C350", VA = "0x18286CF50")]
	public static CEECNPFCENP<TMNode> JENKDJIOHOB<TMNode, TMInput, TMOutput>([In] this ICADBGBAOMP<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMInput> BFMGPLIBCKL)
	{
		return default(CEECNPFCENP<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x25C7400", Offset = "0x25C6800", VA = "0x1825C7400")]
	public static int EFPAFAPJCDA<TMInput, TMOutput, TMNode>([In] this ICADBGBAOMP<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMInput> BFMGPLIBCKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x25C8160", Offset = "0x25C7560", VA = "0x1825C8160")]
	public static CEECNPFCENP<TMOutput> IIIOJOKIFNH<TMOutput, TMInput, TMNode>([In] this ICADBGBAOMP<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMInput> BFMGPLIBCKL, int PMLKPJNGBAD)
	{
		return default(CEECNPFCENP<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x25C7480", Offset = "0x25C6880", VA = "0x1825C7480")]
	internal static void FJGOLABIGBL<TMInput, TMOutput, TMNode>(this ICADBGBAOMP<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMInput> BFMGPLIBCKL, CEECNPFCENP<TMOutput> KJMLGAEJIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x25C7480", Offset = "0x25C6880", VA = "0x1825C7480")]
	internal static void FEKIHLJLLLM<TMInput, TMOutput, TMNode>(this ICADBGBAOMP<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMInput> BFMGPLIBCKL, CEECNPFCENP<TMOutput> KJMLGAEJIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x25C81B0", Offset = "0x25C75B0", VA = "0x1825C81B0")]
	public static OONLFEIMAID<CEECNPFCENP<TMOutput>>.DFJBEGPLHED MGBNJAFIJKG<TMOutput, TMInput, TMNode>([In] this ICADBGBAOMP<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMInput> BFMGPLIBCKL)
	{
		return default(OONLFEIMAID<CEECNPFCENP<TMOutput>>.DFJBEGPLHED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x25C81B0", Offset = "0x25C75B0", VA = "0x1825C81B0")]
	public static DEJDBPHDKAG<CEECNPFCENP<TMOutput>, OONLFEIMAID<CEECNPFCENP<TMOutput>>.DFJBEGPLHED> JICFMFEEGNK<TMOutput, TMInput, TMNode>([In] this ICADBGBAOMP<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMInput> BFMGPLIBCKL)
	{
		return default(DEJDBPHDKAG<CEECNPFCENP<TMOutput>, OONLFEIMAID<CEECNPFCENP<TMOutput>>.DFJBEGPLHED>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct IFPOJJEBAJO<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal DOCCPFAGOMH<TMNode> MCOMOHHIIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal HMEBJJCHPDI<TMNode, OONLFEIMAID<CEECNPFCENP<TMInput>>> NPJOMAMLIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal HMEBJJCHPDI<TMNode, OONLFEIMAID<CEECNPFCENP<TMOutput>>> HNOEGAOOMKD;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x39967E0", Offset = "0x3995BE0", VA = "0x1839967E0")]
	internal IFPOJJEBAJO([In] DOCCPFAGOMH<TMNode> CJMPECHLICD, [In] HMEBJJCHPDI<TMNode, OONLFEIMAID<CEECNPFCENP<TMInput>>> DGBCALFBOAG, [In] HMEBJJCHPDI<TMNode, OONLFEIMAID<CEECNPFCENP<TMOutput>>> PAFGLOPGPCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3996620", Offset = "0x3995A20", VA = "0x183996620")]
	internal static IFPOJJEBAJO<TMInput, TMOutput, TMNode> HGJFOBLHCKL()
	{
		return default(IFPOJJEBAJO<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class BPODKOIAINA
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x25C7950", Offset = "0x25C6D50", VA = "0x1825C7950")]
	internal static PKLNNDHDDOH HBIMCCJEPGN<TMInput, TMOutput, TMNode>([In] this IFPOJJEBAJO<TMInput, TMOutput, TMNode> MEEBIDIALDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x25C6EF0", Offset = "0x25C62F0", VA = "0x1825C6EF0")]
	internal static IFPOJJEBAJO<TMInput, TMOutput, TMNode> CMCHCKHHIFC<TMInput, TMOutput, TMNode>(this PKLNNDHDDOH MEEBIDIALDO)
	{
		return default(IFPOJJEBAJO<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x25C7F90", Offset = "0x25C7390", VA = "0x1825C7F90")]
	private static MPPCLPPGJLL HPLDHPDCIFN<TMInput>([In] this OONLFEIMAID<CEECNPFCENP<TMInput>> MEEBIDIALDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x25C6BA0", Offset = "0x25C5FA0", VA = "0x1825C6BA0")]
	private static OONLFEIMAID<CEECNPFCENP<TMInput>> ACLPHINLAOE<TMInput>(this MPPCLPPGJLL MEEBIDIALDO)
	{
		return default(OONLFEIMAID<CEECNPFCENP<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x25C7780", Offset = "0x25C6B80", VA = "0x1825C7780")]
	private static HNAFNJJCFPM FJDCHECCMLO<TMOutput>([In] this OONLFEIMAID<CEECNPFCENP<TMOutput>> MEEBIDIALDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x25C7D10", Offset = "0x25C7110", VA = "0x1825C7D10")]
	private static OONLFEIMAID<CEECNPFCENP<TMOutput>> HIHFFAGMJJK<TMOutput>(this HNAFNJJCFPM MEEBIDIALDO)
	{
		return default(OONLFEIMAID<CEECNPFCENP<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x25C74C0", Offset = "0x25C68C0", VA = "0x1825C74C0")]
	internal static void FHLEEDLMEFH<TMInput, TMOutput, TMNode>(this IFPOJJEBAJO<TMInput, TMOutput, TMNode> MEEBIDIALDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x25C83F0", Offset = "0x25C77F0", VA = "0x1825C83F0")]
	internal static CEECNPFCENP<TMNode> PFEIPFNMOCD<TMNode, TMInput, TMOutput>(this IFPOJJEBAJO<TMInput, TMOutput, TMNode> MEEBIDIALDO, [In] OONLFEIMAID<CEECNPFCENP<TMInput>> DGBCALFBOAG, [In] OONLFEIMAID<CEECNPFCENP<TMOutput>> PAFGLOPGPCO)
	{
		return default(CEECNPFCENP<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x25C82A0", Offset = "0x25C76A0", VA = "0x1825C82A0")]
	internal static void LBDCCEJODEM<TMInput, TMOutput, TMNode>(this IFPOJJEBAJO<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMNode> BFMGPLIBCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x25C6ED0", Offset = "0x25C62D0", VA = "0x1825C6ED0")]
	public static bool AJPDEGILBCF<TMInput, TMOutput, TMNode>([In] this IFPOJJEBAJO<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMNode> BFMGPLIBCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x24A8AD0", Offset = "0x24A7ED0", VA = "0x1824A8AD0")]
	public static int NDIIMGODLPM<TMInput, TMOutput, TMNode>([In] this IFPOJJEBAJO<TMInput, TMOutput, TMNode> MEEBIDIALDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x25C83B0", Offset = "0x25C77B0", VA = "0x1825C83B0")]
	public static int OBOFAMKMECG<TMInput, TMOutput, TMNode>([In] this IFPOJJEBAJO<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMNode> BFMGPLIBCKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x25C7400", Offset = "0x25C6800", VA = "0x1825C7400")]
	public static int EFPAFAPJCDA<TMInput, TMOutput, TMNode>([In] this IFPOJJEBAJO<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMNode> BFMGPLIBCKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x25C6E80", Offset = "0x25C6280", VA = "0x1825C6E80")]
	public static CEECNPFCENP<TMInput> AFFGMDHCFEP<TMInput, TMOutput, TMNode>([In] this IFPOJJEBAJO<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMNode> BFMGPLIBCKL, int PMLKPJNGBAD)
	{
		return default(CEECNPFCENP<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x25C8160", Offset = "0x25C7560", VA = "0x1825C8160")]
	public static CEECNPFCENP<TMOutput> IIIOJOKIFNH<TMOutput, TMInput, TMNode>([In] this IFPOJJEBAJO<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMNode> BFMGPLIBCKL, int PMLKPJNGBAD)
	{
		return default(CEECNPFCENP<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x25C8210", Offset = "0x25C7610", VA = "0x1825C8210")]
	internal static void MIEHDMJMJDG<TMInput, TMOutput, TMNode>(this IFPOJJEBAJO<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMNode> BFMGPLIBCKL, CEECNPFCENP<TMInput> OHOJMGNOIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x25C7480", Offset = "0x25C6880", VA = "0x1825C7480")]
	internal static void FJGOLABIGBL<TMInput, TMOutput, TMNode>(this IFPOJJEBAJO<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMNode> BFMGPLIBCKL, CEECNPFCENP<TMOutput> KJMLGAEJIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x25C8250", Offset = "0x25C7650", VA = "0x1825C8250")]
	internal static void KPAAIEJIIOL<TMInput, TMOutput, TMNode>(this IFPOJJEBAJO<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMNode> BFMGPLIBCKL, int PMLKPJNGBAD, CEECNPFCENP<TMInput> OHOJMGNOIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x25C8360", Offset = "0x25C7760", VA = "0x1825C8360")]
	internal static void NINMDLONDBO<TMInput, TMOutput, TMNode>(this IFPOJJEBAJO<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMNode> BFMGPLIBCKL, int PMLKPJNGBAD, CEECNPFCENP<TMOutput> KJMLGAEJIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x25C8210", Offset = "0x25C7610", VA = "0x1825C8210")]
	internal static void KOALHGAJBLI<TMInput, TMOutput, TMNode>(this IFPOJJEBAJO<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMNode> BFMGPLIBCKL, CEECNPFCENP<TMInput> OHOJMGNOIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x25C7480", Offset = "0x25C6880", VA = "0x1825C7480")]
	internal static void FEKIHLJLLLM<TMInput, TMOutput, TMNode>(this IFPOJJEBAJO<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMNode> BFMGPLIBCKL, CEECNPFCENP<TMOutput> KJMLGAEJIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x25C6E20", Offset = "0x25C6220", VA = "0x1825C6E20")]
	public static OONLFEIMAID<CEECNPFCENP<TMInput>>.DFJBEGPLHED ADBMHBNDHOH<TMInput, TMOutput, TMNode>([In] this IFPOJJEBAJO<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMNode> BFMGPLIBCKL)
	{
		return default(OONLFEIMAID<CEECNPFCENP<TMInput>>.DFJBEGPLHED);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x25C81B0", Offset = "0x25C75B0", VA = "0x1825C81B0")]
	public static OONLFEIMAID<CEECNPFCENP<TMOutput>>.DFJBEGPLHED MGBNJAFIJKG<TMOutput, TMInput, TMNode>([In] this IFPOJJEBAJO<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMNode> BFMGPLIBCKL)
	{
		return default(OONLFEIMAID<CEECNPFCENP<TMOutput>>.DFJBEGPLHED);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x25C6E20", Offset = "0x25C6220", VA = "0x1825C6E20")]
	public static DEJDBPHDKAG<CEECNPFCENP<TMInput>, OONLFEIMAID<CEECNPFCENP<TMInput>>.DFJBEGPLHED> LHDMHFADFJC<TMInput, TMOutput, TMNode>([In] this IFPOJJEBAJO<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMNode> BFMGPLIBCKL)
	{
		return default(DEJDBPHDKAG<CEECNPFCENP<TMInput>, OONLFEIMAID<CEECNPFCENP<TMInput>>.DFJBEGPLHED>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x25C81B0", Offset = "0x25C75B0", VA = "0x1825C81B0")]
	public static DEJDBPHDKAG<CEECNPFCENP<TMOutput>, OONLFEIMAID<CEECNPFCENP<TMOutput>>.DFJBEGPLHED> JICFMFEEGNK<TMOutput, TMInput, TMNode>([In] this IFPOJJEBAJO<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMNode> BFMGPLIBCKL)
	{
		return default(DEJDBPHDKAG<CEECNPFCENP<TMOutput>, OONLFEIMAID<CEECNPFCENP<TMOutput>>.DFJBEGPLHED>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x25C7440", Offset = "0x25C6840", VA = "0x1825C7440")]
	public static OCIEPPKJBLK<CEECNPFCENP<TMNode>, DOCCPFAGOMH<TMNode>.AEKHELIDLOK> EJCNNPGLFML<TMNode, TMInput, TMOutput>([In] this IFPOJJEBAJO<TMInput, TMOutput, TMNode> MEEBIDIALDO)
	{
		return default(OCIEPPKJBLK<CEECNPFCENP<TMNode>, DOCCPFAGOMH<TMNode>.AEKHELIDLOK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct MBOAONAHPJE<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal DOCCPFAGOMH<TMOutput> MCOMOHHIIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal HMEBJJCHPDI<TMOutput, CEECNPFCENP<TMNode>> CBCDEHHICCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal HMEBJJCHPDI<TMOutput, OONLFEIMAID<CEECNPFCENP<TMInput>>> NPJOMAMLIIP;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x39967E0", Offset = "0x3995BE0", VA = "0x1839967E0")]
	internal MBOAONAHPJE([In] DOCCPFAGOMH<TMOutput> CJMPECHLICD, [In] HMEBJJCHPDI<TMOutput, CEECNPFCENP<TMNode>> DCFFCEBKIAN, [In] HMEBJJCHPDI<TMOutput, OONLFEIMAID<CEECNPFCENP<TMInput>>> DGBCALFBOAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3996620", Offset = "0x3995A20", VA = "0x183996620")]
	internal static MBOAONAHPJE<TMInput, TMOutput, TMNode> HGJFOBLHCKL()
	{
		return default(MBOAONAHPJE<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class AJMEGIONLMO
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2DB6610", Offset = "0x2DB5A10", VA = "0x182DB6610")]
	internal static OBADNNCCEAH HBIMCCJEPGN<TMInput, TMOutput, TMNode>([In] this MBOAONAHPJE<TMInput, TMOutput, TMNode> MEEBIDIALDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2DB5E80", Offset = "0x2DB5280", VA = "0x182DB5E80")]
	internal static MBOAONAHPJE<TMInput, TMOutput, TMNode> CMCHCKHHIFC<TMInput, TMOutput, TMNode>(this OBADNNCCEAH MEEBIDIALDO)
	{
		return default(MBOAONAHPJE<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2DB69A0", Offset = "0x2DB5DA0", VA = "0x182DB69A0")]
	private static BICJEOKBHJH OFDLMNMNLDK<TMInput>([In] this OONLFEIMAID<CEECNPFCENP<TMInput>> MEEBIDIALDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2DB6390", Offset = "0x2DB5790", VA = "0x182DB6390")]
	private static OONLFEIMAID<CEECNPFCENP<TMInput>> GDHIKOHNPBD<TMInput>(this BICJEOKBHJH MEEBIDIALDO)
	{
		return default(OONLFEIMAID<CEECNPFCENP<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x286CA30", Offset = "0x286BE30", VA = "0x18286CA30")]
	internal static void FHLEEDLMEFH<TMInput, TMOutput, TMNode>(this MBOAONAHPJE<TMInput, TMOutput, TMNode> MEEBIDIALDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x286D280", Offset = "0x286C680", VA = "0x18286D280")]
	internal static CEECNPFCENP<TMOutput> PFEIPFNMOCD<TMOutput, TMInput, TMNode>(this MBOAONAHPJE<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMNode> HBIAHPFPLFB)
	{
		return default(CEECNPFCENP<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x286CF70", Offset = "0x286C370", VA = "0x18286CF70")]
	internal static void LBDCCEJODEM<TMInput, TMOutput, TMNode>(this MBOAONAHPJE<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMOutput> BFMGPLIBCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x25C6ED0", Offset = "0x25C62D0", VA = "0x1825C6ED0")]
	public static bool AJPDEGILBCF<TMInput, TMOutput, TMNode>([In] this MBOAONAHPJE<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMOutput> BFMGPLIBCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x24A8AD0", Offset = "0x24A7ED0", VA = "0x1824A8AD0")]
	public static int NDIIMGODLPM<TMInput, TMOutput, TMNode>([In] this MBOAONAHPJE<TMInput, TMOutput, TMNode> MEEBIDIALDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x286CF50", Offset = "0x286C350", VA = "0x18286CF50")]
	public static CEECNPFCENP<TMNode> JENKDJIOHOB<TMNode, TMInput, TMOutput>([In] this MBOAONAHPJE<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMOutput> BFMGPLIBCKL)
	{
		return default(CEECNPFCENP<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x25C7400", Offset = "0x25C6800", VA = "0x1825C7400")]
	public static int OBOFAMKMECG<TMInput, TMOutput, TMNode>([In] this MBOAONAHPJE<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMOutput> BFMGPLIBCKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x25C8160", Offset = "0x25C7560", VA = "0x1825C8160")]
	public static CEECNPFCENP<TMInput> AFFGMDHCFEP<TMInput, TMOutput, TMNode>([In] this MBOAONAHPJE<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMOutput> BFMGPLIBCKL, int PMLKPJNGBAD)
	{
		return default(CEECNPFCENP<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x25C7480", Offset = "0x25C6880", VA = "0x1825C7480")]
	internal static void MIEHDMJMJDG<TMInput, TMOutput, TMNode>(this MBOAONAHPJE<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMOutput> BFMGPLIBCKL, CEECNPFCENP<TMInput> OHOJMGNOIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x25C7480", Offset = "0x25C6880", VA = "0x1825C7480")]
	internal static void KOALHGAJBLI<TMInput, TMOutput, TMNode>(this MBOAONAHPJE<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMOutput> BFMGPLIBCKL, CEECNPFCENP<TMInput> OHOJMGNOIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x25C81B0", Offset = "0x25C75B0", VA = "0x1825C81B0")]
	public static OONLFEIMAID<CEECNPFCENP<TMInput>>.DFJBEGPLHED ADBMHBNDHOH<TMInput, TMOutput, TMNode>([In] this MBOAONAHPJE<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMOutput> BFMGPLIBCKL)
	{
		return default(OONLFEIMAID<CEECNPFCENP<TMInput>>.DFJBEGPLHED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x25C81B0", Offset = "0x25C75B0", VA = "0x1825C81B0")]
	public static DEJDBPHDKAG<CEECNPFCENP<TMInput>, OONLFEIMAID<CEECNPFCENP<TMInput>>.DFJBEGPLHED> LHDMHFADFJC<TMInput, TMOutput, TMNode>([In] this MBOAONAHPJE<TMInput, TMOutput, TMNode> MEEBIDIALDO, CEECNPFCENP<TMOutput> BFMGPLIBCKL)
	{
		return default(DEJDBPHDKAG<CEECNPFCENP<TMInput>, OONLFEIMAID<CEECNPFCENP<TMInput>>.DFJBEGPLHED>);
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
