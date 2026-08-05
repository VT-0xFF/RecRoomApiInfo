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
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40")]
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
		[Cpp2IlInjected.Address(RVA = "0xEA20C0", Offset = "0xEA08C0", VA = "0x180EA20C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6F06F0", Offset = "0x6EEEF0", VA = "0x1806F06F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x91F620", Offset = "0x91DE20", VA = "0x18091F620")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate global::KBDCFJABAJB<TActionKind, TPayload> GNMOPHFJADM<TActionKind, TSerializedAction, TPayload>(TSerializedAction PFLFKIOAMKP);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface FCDMCNHIILJ<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::IMDNOFMHNPP<object, IOEHGADFNAP>> HCBMBJCIDHI(TDeps JIFFNOBMAPO, TRoot FECENBBKPOP, TSerializedAction PFLFKIOAMKP);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class DPGLDMNFEEJ<TActionKind, TSerializedAction, TRoot, TDeps> : IOEHGADFNAP where TDeps : JLLDKEFPNPE.ICMBKIEAMLB<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps BDHFHIDFEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction LOHEACAEEHP;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x392F3D0", Offset = "0x392DBD0", VA = "0x18392F3D0")]
	public DPGLDMNFEEJ(in TDeps JIFFNOBMAPO, in TSerializedAction PFLFKIOAMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x392F2F0", Offset = "0x392DAF0", VA = "0x18392F2F0", Slot = "5")]
	public override string NNBNGPPOEHN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct KBDCFJABAJB<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind PJNFHMKOMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload KAHHBKPIBEC;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x27FF290", Offset = "0x27FDA90", VA = "0x1827FF290")]
	internal KBDCFJABAJB(TActionKind BNKBMDNFDKH, in TPayload HBMMCJPOJGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class FBFEBFDIMIO
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2689FE0", Offset = "0x26887E0", VA = "0x182689FE0")]
	public static global::KBDCFJABAJB<TActionKind, TPayload> HHEHBEMBBBF<TActionKind, TPayload>(in TActionKind BNKBMDNFDKH, in TPayload HBMMCJPOJGP)
	{
		return default(global::KBDCFJABAJB<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<global::IMDNOFMHNPP<TOk, TErr>> CHOMLMHEIBC<TRoot, TPayload, TOk, TErr>(TRoot FECENBBKPOP, TPayload HBMMCJPOJGP);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate global::IMDNOFMHNPP<TOk, TErr> DJLEBFAPKNO<TRoot, TPayload, TOk, TErr>(TRoot FECENBBKPOP, in TPayload HBMMCJPOJGP);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct MOMIOMIIGOJ<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : JLLDKEFPNPE.ICMBKIEAMLB<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct NHIICGKLGHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<global::IMDNOFMHNPP<object, IOEHGADFNAP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public global::MOMIOMIIGOJ<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<global::IMDNOFMHNPP<object, IOEHGADFNAP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x34C4020", Offset = "0x34C2820", VA = "0x1834C4020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x34C4430", Offset = "0x34C2C30", VA = "0x1834C4430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, global::FCDMCNHIILJ<TSerializedAction, TRoot, TDeps>> LDJBCFHGJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps BDHFHIDFEEB;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x785A30", Offset = "0x784230", VA = "0x180785A30")]
	internal MOMIOMIIGOJ(Dictionary<TActionKind, global::FCDMCNHIILJ<TSerializedAction, TRoot, TDeps>> FEBBGGCHDLF, TDeps JIFFNOBMAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x28E2C30", Offset = "0x28E1430", VA = "0x1828E2C30")]
	[AsyncStateMachine(typeof(global::MOMIOMIIGOJ<, , , >.NHIICGKLGHE))]
	public Task<global::IMDNOFMHNPP<object, IOEHGADFNAP>> HCBMBJCIDHI(TRoot FECENBBKPOP, TSerializedAction PFLFKIOAMKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class JLLDKEFPNPE
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface ICMBKIEAMLB<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind JDALLECAKFP(TSerializedAction DCJNPPINKOA);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AMEIDLPCBKA(TRoot FECENBBKPOP, TSerializedAction BEHJPKINPFB);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x14A79B0", Offset = "0x14A61B0", VA = "0x1814A79B0")]
	internal static global::MOMIOMIIGOJ<TActionKind, TSerializedAction, TRoot, TDeps> HHEHBEMBBBF<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, global::FCDMCNHIILJ<TSerializedAction, TRoot, TDeps>> FEBBGGCHDLF, TDeps JIFFNOBMAPO) where TDeps : ICMBKIEAMLB<TActionKind, TSerializedAction, TRoot>
	{
		return default(global::MOMIOMIIGOJ<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class PMDHHMGJAMB<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, global::FCDMCNHIILJ<TSerializedAction, TRoot, TDeps>> LLNOFIJJOBG;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1C56F20", Offset = "0x1C55720", VA = "0x181C56F20")]
	private PMDHHMGJAMB(Dictionary<TActionKind, global::FCDMCNHIILJ<TSerializedAction, TRoot, TDeps>> FEBBGGCHDLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3714290", Offset = "0x3712A90", VA = "0x183714290")]
	public static global::PMDHHMGJAMB<TActionKind, TSerializedAction, TRoot, TDeps> HHEHBEMBBBF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct AJMEIPHPBIE<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, JLLDKEFPNPE.ICMBKIEAMLB<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class AIAJHOFEOPL<TPayload, TOk, TErr> : global::FCDMCNHIILJ<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, IOEHGADFNAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly global::GNMOPHFJADM<TActionKind, TSerializedAction, TPayload> OBNGBKCFNDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly global::DJLEBFAPKNO<TRoot, TPayload, TOk, TErr> EJFOFPCBJNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool HGIAEODCPPN;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2FB65D0", Offset = "0x2FB4DD0", VA = "0x182FB65D0")]
		public AIAJHOFEOPL(global::GNMOPHFJADM<TActionKind, TSerializedAction, TPayload> GHHGAMEKMKD, global::DJLEBFAPKNO<TRoot, TPayload, TOk, TErr> JFDKEJADFPC, bool ABILAPLCCOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x33B8720", Offset = "0x33B6F20", VA = "0x1833B8720", Slot = "4")]
		public Task<global::IMDNOFMHNPP<object, IOEHGADFNAP>> HCBMBJCIDHI(TDeps JIFFNOBMAPO, TRoot FECENBBKPOP, TSerializedAction PFLFKIOAMKP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class MKNCFEAFNGF<TPayload, TOk, TErr> : global::FCDMCNHIILJ<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, IOEHGADFNAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly global::GNMOPHFJADM<TActionKind, TSerializedAction, TPayload> OBNGBKCFNDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly global::CHOMLMHEIBC<TRoot, TPayload, TOk, TErr> EJFOFPCBJNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool HGIAEODCPPN;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2FB65D0", Offset = "0x2FB4DD0", VA = "0x182FB65D0")]
		public MKNCFEAFNGF(global::GNMOPHFJADM<TActionKind, TSerializedAction, TPayload> GHHGAMEKMKD, global::CHOMLMHEIBC<TRoot, TPayload, TOk, TErr> JFDKEJADFPC, bool ABILAPLCCOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2FB62F0", Offset = "0x2FB4AF0", VA = "0x182FB62F0", Slot = "4")]
		[AsyncStateMachine(typeof(FCDAKNBOKLJ))]
		public Task<global::IMDNOFMHNPP<object, IOEHGADFNAP>> HCBMBJCIDHI(TDeps JIFFNOBMAPO, TRoot FECENBBKPOP, TSerializedAction PFLFKIOAMKP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly global::PMDHHMGJAMB<TActionKind, TSerializedAction, TRoot, TDeps> LBPMFJMPCHO;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8ABD70", Offset = "0x8AA570", VA = "0x1808ABD70")]
	private AJMEIPHPBIE(global::PMDHHMGJAMB<TActionKind, TSerializedAction, TRoot, TDeps> LBEMEOBAAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2E98610", Offset = "0x2E96E10", VA = "0x182E98610")]
	public static global::AJMEIPHPBIE<TActionKind, TSerializedAction, TRoot, TDeps> HHEHBEMBBBF()
	{
		return default(global::AJMEIPHPBIE<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1FCDF00", Offset = "0x1FCC700", VA = "0x181FCDF00")]
	public global::AJMEIPHPBIE<TActionKind, TSerializedAction, TRoot, TDeps> NOGOGLNMGCN<TPayload, TOk, TErr>(TActionKind BNKBMDNFDKH, global::GNMOPHFJADM<TActionKind, TSerializedAction, TPayload> GHHGAMEKMKD, global::DJLEBFAPKNO<TRoot, TPayload, TOk, TErr> JFDKEJADFPC, bool ABILAPLCCOJ = true) where TPayload : notnull where TOk : notnull where TErr : notnull, IOEHGADFNAP
	{
		return default(global::AJMEIPHPBIE<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1FCDF00", Offset = "0x1FCC700", VA = "0x181FCDF00")]
	public global::AJMEIPHPBIE<TActionKind, TSerializedAction, TRoot, TDeps> HDLOBJNADDN<TPayload, TOk, TErr>(TActionKind BNKBMDNFDKH, global::GNMOPHFJADM<TActionKind, TSerializedAction, TPayload> GHHGAMEKMKD, global::CHOMLMHEIBC<TRoot, TPayload, TOk, TErr> JFDKEJADFPC, bool ABILAPLCCOJ = true) where TPayload : notnull where TOk : notnull where TErr : notnull, IOEHGADFNAP
	{
		return default(global::AJMEIPHPBIE<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2E98560", Offset = "0x2E96D60", VA = "0x182E98560")]
	public global::MOMIOMIIGOJ<TActionKind, TSerializedAction, TRoot, TDeps> BBDBACIODGJ(TDeps JIFFNOBMAPO)
	{
		return default(global::MOMIOMIIGOJ<TActionKind, TSerializedAction, TRoot, TDeps>);
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
