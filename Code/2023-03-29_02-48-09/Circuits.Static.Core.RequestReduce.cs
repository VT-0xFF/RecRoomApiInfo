using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
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
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6644980", Offset = "0x6643780", VA = "0x186644980")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x740BD0", Offset = "0x73F9D0", VA = "0x180740BD0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xB9A310", Offset = "0xB99110", VA = "0x180B9A310")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate global::NBAPMIFFHOF<TActionKind, TPayload> EEPGFOPGHDL<TActionKind, TSerializedAction, TPayload>(TSerializedAction IDOGNHKHFNI);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface KCGAHKJLFLK<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::MLGLHJLHANB<object, ILGFEOBJLPI>> JHEIGDJIMLP(TDeps NAFCODPKCHO, TRoot DCJJENKGKJB, TSerializedAction IDOGNHKHFNI);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class MLPHFKBHDBN<TActionKind, TSerializedAction, TRoot, TDeps> : ILGFEOBJLPI where TDeps : NFMNAPHHDJF.FDPGCAJBGEO<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps GHBOMGLKHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction LMCENJDDJFF;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x396E9D0", Offset = "0x396D7D0", VA = "0x18396E9D0")]
	public MLPHFKBHDBN(in TDeps NAFCODPKCHO, in TSerializedAction IDOGNHKHFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x396E7A0", Offset = "0x396D5A0", VA = "0x18396E7A0", Slot = "5")]
	public override string NKEBKNLNMDO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct NBAPMIFFHOF<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind BAOIGIEACPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload MMGPHBADKLL;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2EA1190", Offset = "0x2E9FF90", VA = "0x182EA1190")]
	internal NBAPMIFFHOF(TActionKind DGNPCDLNJOJ, in TPayload GFDIIEHKLPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class CICGCNBLELM
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x268B160", Offset = "0x2689F60", VA = "0x18268B160")]
	public static global::NBAPMIFFHOF<TActionKind, TPayload> LBKFKMLCCNN<TActionKind, TPayload>(in TActionKind DGNPCDLNJOJ, in TPayload GFDIIEHKLPK)
	{
		return default(global::NBAPMIFFHOF<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<global::MLGLHJLHANB<TOk, TErr>> AFCHKBFHHOA<TRoot, TPayload, TOk, TErr>(TRoot DCJJENKGKJB, TPayload GFDIIEHKLPK);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate global::MLGLHJLHANB<TOk, TErr> KPEDJPBMCAB<TRoot, TPayload, TOk, TErr>(TRoot DCJJENKGKJB, in TPayload GFDIIEHKLPK);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct NHPIMBDNPKP<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : NFMNAPHHDJF.FDPGCAJBGEO<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct DIPMKCCJEPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<global::MLGLHJLHANB<object, ILGFEOBJLPI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public global::NHPIMBDNPKP<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<global::MLGLHJLHANB<object, ILGFEOBJLPI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B105B0", Offset = "0x2B0F3B0", VA = "0x182B105B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B109C0", Offset = "0x2B0F7C0", VA = "0x182B109C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, global::KCGAHKJLFLK<TSerializedAction, TRoot, TDeps>> GNBNIAGJAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps GHBOMGLKHCJ;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x9333E0", Offset = "0x9321E0", VA = "0x1809333E0")]
	internal NHPIMBDNPKP(Dictionary<TActionKind, global::KCGAHKJLFLK<TSerializedAction, TRoot, TDeps>> EICAAMOCMBE, TDeps NAFCODPKCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3958440", Offset = "0x3957240", VA = "0x183958440")]
	[AsyncStateMachine(typeof(global::NHPIMBDNPKP<, , , >.DIPMKCCJEPO))]
	public Task<global::MLGLHJLHANB<object, ILGFEOBJLPI>> JHEIGDJIMLP(TRoot DCJJENKGKJB, TSerializedAction IDOGNHKHFNI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class NFMNAPHHDJF
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface FDPGCAJBGEO<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind MKDNIJNHKPF(TSerializedAction CNBAEMLJEBG);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LOMKACPIBNA(TRoot DCJJENKGKJB, TSerializedAction KKJDJCJOLIF);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x227D750", Offset = "0x227C550", VA = "0x18227D750")]
	internal static global::NHPIMBDNPKP<TActionKind, TSerializedAction, TRoot, TDeps> LBKFKMLCCNN<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, global::KCGAHKJLFLK<TSerializedAction, TRoot, TDeps>> EICAAMOCMBE, TDeps NAFCODPKCHO) where TDeps : FDPGCAJBGEO<TActionKind, TSerializedAction, TRoot>
	{
		return default(global::NHPIMBDNPKP<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class DBBKJEPIAMJ<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, global::KCGAHKJLFLK<TSerializedAction, TRoot, TDeps>> FJBNDBIMNDH;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x28D63A0", Offset = "0x28D51A0", VA = "0x1828D63A0")]
	private DBBKJEPIAMJ(Dictionary<TActionKind, global::KCGAHKJLFLK<TSerializedAction, TRoot, TDeps>> EICAAMOCMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2B027B0", Offset = "0x2B015B0", VA = "0x182B027B0")]
	public static global::DBBKJEPIAMJ<TActionKind, TSerializedAction, TRoot, TDeps> LBKFKMLCCNN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct KJCFOGOGBBO<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, NFMNAPHHDJF.FDPGCAJBGEO<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class EPBIHBOEBBF<TPayload, TOk, TErr> : global::KCGAHKJLFLK<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, ILGFEOBJLPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly global::EEPGFOPGHDL<TActionKind, TSerializedAction, TPayload> GDBPHNFHPHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly global::KPEDJPBMCAB<TRoot, TPayload, TOk, TErr> GNNBHEAHOFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool PNMKNKLBHJC;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1FE6FA0", Offset = "0x1FE5DA0", VA = "0x181FE6FA0")]
		public EPBIHBOEBBF(global::EEPGFOPGHDL<TActionKind, TSerializedAction, TPayload> LDAKILJFENG, global::KPEDJPBMCAB<TRoot, TPayload, TOk, TErr> GMIJAJDCPPD, bool JKPNABLBOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3527500", Offset = "0x3526300", VA = "0x183527500", Slot = "4")]
		public Task<global::MLGLHJLHANB<object, ILGFEOBJLPI>> JHEIGDJIMLP(TDeps NAFCODPKCHO, TRoot DCJJENKGKJB, TSerializedAction IDOGNHKHFNI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class EPBMMPAMAHC<TPayload, TOk, TErr> : global::KCGAHKJLFLK<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, ILGFEOBJLPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly global::EEPGFOPGHDL<TActionKind, TSerializedAction, TPayload> GDBPHNFHPHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly global::AFCHKBFHHOA<TRoot, TPayload, TOk, TErr> GNNBHEAHOFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool PNMKNKLBHJC;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1FE6FA0", Offset = "0x1FE5DA0", VA = "0x181FE6FA0")]
		public EPBMMPAMAHC(global::EEPGFOPGHDL<TActionKind, TSerializedAction, TPayload> LDAKILJFENG, global::AFCHKBFHHOA<TRoot, TPayload, TOk, TErr> GMIJAJDCPPD, bool JKPNABLBOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7010", Offset = "0x1FE5E10", VA = "0x181FE7010", Slot = "4")]
		[AsyncStateMachine(typeof(NLABPBLNHHE))]
		public Task<global::MLGLHJLHANB<object, ILGFEOBJLPI>> JHEIGDJIMLP(TDeps NAFCODPKCHO, TRoot DCJJENKGKJB, TSerializedAction IDOGNHKHFNI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly global::DBBKJEPIAMJ<TActionKind, TSerializedAction, TRoot, TDeps> NAHHMHCEOOG;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6F7F00", Offset = "0x6F6D00", VA = "0x1806F7F00")]
	private KJCFOGOGBBO(global::DBBKJEPIAMJ<TActionKind, TSerializedAction, TRoot, TDeps> PHAPMEHMHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2728030", Offset = "0x2726E30", VA = "0x182728030")]
	public static global::KJCFOGOGBBO<TActionKind, TSerializedAction, TRoot, TDeps> LBKFKMLCCNN()
	{
		return default(global::KJCFOGOGBBO<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2ACD9C0", Offset = "0x2ACC7C0", VA = "0x182ACD9C0")]
	public global::KJCFOGOGBBO<TActionKind, TSerializedAction, TRoot, TDeps> IPGHIMMIGCP<TPayload, TOk, TErr>(TActionKind DGNPCDLNJOJ, global::EEPGFOPGHDL<TActionKind, TSerializedAction, TPayload> LDAKILJFENG, global::KPEDJPBMCAB<TRoot, TPayload, TOk, TErr> GMIJAJDCPPD, bool JKPNABLBOCG = true) where TPayload : notnull where TOk : notnull where TErr : notnull, ILGFEOBJLPI
	{
		return default(global::KJCFOGOGBBO<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2ACD9C0", Offset = "0x2ACC7C0", VA = "0x182ACD9C0")]
	public global::KJCFOGOGBBO<TActionKind, TSerializedAction, TRoot, TDeps> COPKCIKFEDK<TPayload, TOk, TErr>(TActionKind DGNPCDLNJOJ, global::EEPGFOPGHDL<TActionKind, TSerializedAction, TPayload> LDAKILJFENG, global::AFCHKBFHHOA<TRoot, TPayload, TOk, TErr> GMIJAJDCPPD, bool JKPNABLBOCG = true) where TPayload : notnull where TOk : notnull where TErr : notnull, ILGFEOBJLPI
	{
		return default(global::KJCFOGOGBBO<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2727F80", Offset = "0x2726D80", VA = "0x182727F80")]
	public global::NHPIMBDNPKP<TActionKind, TSerializedAction, TRoot, TDeps> BIEKLAGKDBF(TDeps NAFCODPKCHO)
	{
		return default(global::NHPIMBDNPKP<TActionKind, TSerializedAction, TRoot, TDeps>);
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
