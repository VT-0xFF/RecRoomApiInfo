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
		[Cpp2IlInjected.Address(RVA = "0x78CB70", Offset = "0x78B370", VA = "0x18078CB70")]
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
		[Cpp2IlInjected.Address(RVA = "0x1C31D20", Offset = "0x1C30520", VA = "0x181C31D20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78D440", Offset = "0x78BC40", VA = "0x18078D440")]
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
		[Cpp2IlInjected.Address(RVA = "0x78D480", Offset = "0x78BC80", VA = "0x18078D480")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate BCLLIHGKLIK<TActionKind, TPayload> KIMCPPHCAEE<TActionKind, TSerializedAction, TPayload>(TSerializedAction ENIBCCKBPCB);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface HJOBKCOCCBO<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EOPMGLNDIOA<object, NHKNMEADEEO>> IMHAEKCMPEM(TDeps JOGDKLBFLFJ, TRoot DIPDOFGLHFF, TSerializedAction ENIBCCKBPCB);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class MMFODEJNJBF<TActionKind, TSerializedAction, TRoot, TDeps> : HIMCMICGGGI where TDeps : DFLBEHIMOOF.GMDCOPMPIHF<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps DDBMMBAAAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction ONDKKIKPLKJ;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3B441C0", Offset = "0x3B429C0", VA = "0x183B441C0")]
	public MMFODEJNJBF([In] TDeps JOGDKLBFLFJ, [In] TSerializedAction ENIBCCKBPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3B44090", Offset = "0x3B42890", VA = "0x183B44090", Slot = "7")]
	public override string DGMFKNHADKE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct BCLLIHGKLIK<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind AMEGGDDAOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload OOJKHDPNLIH;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x43E71B0", Offset = "0x43E59B0", VA = "0x1843E71B0")]
	internal BCLLIHGKLIK(TActionKind GAJGEJBMCCL, [In] TPayload KAAIDPFBBBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class AFDOOOMPEEB
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x29997E0", Offset = "0x2997FE0", VA = "0x1829997E0")]
	public static BCLLIHGKLIK<TActionKind, TPayload> KKMBICLNKPK<TActionKind, TPayload>([In] TActionKind GAJGEJBMCCL, [In] TPayload KAAIDPFBBBH)
	{
		return default(BCLLIHGKLIK<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<EOPMGLNDIOA<TOk, TErr>> DLELKJHDLIJ<TRoot, TPayload, TOk, TErr>(TRoot DIPDOFGLHFF, TPayload KAAIDPFBBBH);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate EOPMGLNDIOA<TOk, TErr> MMABHGAABOE<TRoot, TPayload, TOk, TErr>(TRoot DIPDOFGLHFF, [In] TPayload KAAIDPFBBBH);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct DNMOCJLFELM<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : DFLBEHIMOOF.GMDCOPMPIHF<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct APNBIKFNJAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<EOPMGLNDIOA<object, NHKNMEADEEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public DNMOCJLFELM<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<EOPMGLNDIOA<object, NHKNMEADEEO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x365FAB0", Offset = "0x365E2B0", VA = "0x18365FAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x365FFB0", Offset = "0x365E7B0", VA = "0x18365FFB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, HJOBKCOCCBO<TSerializedAction, TRoot, TDeps>> FINFKDHCJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps DDBMMBAAAPM;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7F3540", Offset = "0x7F1D40", VA = "0x1807F3540")]
	internal DNMOCJLFELM(Dictionary<TActionKind, HJOBKCOCCBO<TSerializedAction, TRoot, TDeps>> BDLMPCGHACJ, TDeps JOGDKLBFLFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4D1DD80", Offset = "0x4D1C580", VA = "0x184D1DD80")]
	[AsyncStateMachine(typeof(DNMOCJLFELM<, , , >.APNBIKFNJAA))]
	public Task<EOPMGLNDIOA<object, NHKNMEADEEO>> IMHAEKCMPEM(TRoot DIPDOFGLHFF, TSerializedAction ENIBCCKBPCB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class DFLBEHIMOOF
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface GMDCOPMPIHF<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind MBPAFGMEBLB(TSerializedAction AFFJMIFONEM);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CIMBMHDLNLL(TRoot DIPDOFGLHFF, TSerializedAction OONIIOMBHJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x220FF50", Offset = "0x220E750", VA = "0x18220FF50")]
	internal static DNMOCJLFELM<TActionKind, TSerializedAction, TRoot, TDeps> KKMBICLNKPK<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, HJOBKCOCCBO<TSerializedAction, TRoot, TDeps>> BDLMPCGHACJ, TDeps JOGDKLBFLFJ) where TDeps : GMDCOPMPIHF<TActionKind, TSerializedAction, TRoot>
	{
		return default(DNMOCJLFELM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class LPGIBDLMHKI<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, HJOBKCOCCBO<TSerializedAction, TRoot, TDeps>> LPIJGMMNEAA;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x768BD0", Offset = "0x7673D0", VA = "0x180768BD0")]
	private LPGIBDLMHKI(Dictionary<TActionKind, HJOBKCOCCBO<TSerializedAction, TRoot, TDeps>> BDLMPCGHACJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3931710", Offset = "0x392FF10", VA = "0x183931710")]
	public static LPGIBDLMHKI<TActionKind, TSerializedAction, TRoot, TDeps> KKMBICLNKPK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct IACGCHNPDDC<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, DFLBEHIMOOF.GMDCOPMPIHF<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class MLIPGMCDFFI<TPayload, TOk, TErr> : HJOBKCOCCBO<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, NHKNMEADEEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly KIMCPPHCAEE<TActionKind, TSerializedAction, TPayload> PHMNDOEOANO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly MMABHGAABOE<TRoot, TPayload, TOk, TErr> NIIKOACHHOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool BEOGGIFDNIL;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3533F00", Offset = "0x3532700", VA = "0x183533F00")]
		public MLIPGMCDFFI(KIMCPPHCAEE<TActionKind, TSerializedAction, TPayload> IHANFIHDMIK, MMABHGAABOE<TRoot, TPayload, TOk, TErr> JDILABOMGAC, bool FCKIDDFNIDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3B304B0", Offset = "0x3B2ECB0", VA = "0x183B304B0", Slot = "4")]
		public Task<EOPMGLNDIOA<object, NHKNMEADEEO>> IMHAEKCMPEM(TDeps JOGDKLBFLFJ, TRoot DIPDOFGLHFF, TSerializedAction ENIBCCKBPCB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class ANMHLBOBEDC<TPayload, TOk, TErr> : HJOBKCOCCBO<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, NHKNMEADEEO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct DANBADMFBHJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<EOPMGLNDIOA<object?, NHKNMEADEEO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ANMHLBOBEDC<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public TDeps deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public TRoot root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public TSerializedAction serializedAction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private EOPMGLNDIOA<object?, NHKNMEADEEO> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<EOPMGLNDIOA<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x4CDDBE0", Offset = "0x4CDC3E0", VA = "0x184CDDBE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4CDE160", Offset = "0x4CDC960", VA = "0x184CDE160", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly KIMCPPHCAEE<TActionKind, TSerializedAction, TPayload> PHMNDOEOANO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly DLELKJHDLIJ<TRoot, TPayload, TOk, TErr> NIIKOACHHOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool BEOGGIFDNIL;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3533F00", Offset = "0x3532700", VA = "0x183533F00")]
		public ANMHLBOBEDC(KIMCPPHCAEE<TActionKind, TSerializedAction, TPayload> IHANFIHDMIK, DLELKJHDLIJ<TRoot, TPayload, TOk, TErr> JDILABOMGAC, bool FCKIDDFNIDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3533DA0", Offset = "0x35325A0", VA = "0x183533DA0", Slot = "4")]
		[AsyncStateMachine(typeof(ANMHLBOBEDC<, , >.DANBADMFBHJ))]
		public Task<EOPMGLNDIOA<object, NHKNMEADEEO>> IMHAEKCMPEM(TDeps JOGDKLBFLFJ, TRoot DIPDOFGLHFF, TSerializedAction ENIBCCKBPCB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly LPGIBDLMHKI<TActionKind, TSerializedAction, TRoot, TDeps> GJKJLPBNLND;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7ECAD0", Offset = "0x7EB2D0", VA = "0x1807ECAD0")]
	private IACGCHNPDDC(LPGIBDLMHKI<TActionKind, TSerializedAction, TRoot, TDeps> AELCABDCBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x361A120", Offset = "0x3618920", VA = "0x18361A120")]
	public static IACGCHNPDDC<TActionKind, TSerializedAction, TRoot, TDeps> KKMBICLNKPK()
	{
		return default(IACGCHNPDDC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x215E700", Offset = "0x215CF00", VA = "0x18215E700")]
	public IACGCHNPDDC<TActionKind, TSerializedAction, TRoot, TDeps> KMABHHMGGDB<TPayload, TOk, TErr>(TActionKind GAJGEJBMCCL, KIMCPPHCAEE<TActionKind, TSerializedAction, TPayload> IHANFIHDMIK, MMABHGAABOE<TRoot, TPayload, TOk, TErr> JDILABOMGAC, bool FCKIDDFNIDP = true) where TPayload : notnull where TOk : notnull where TErr : notnull, NHKNMEADEEO
	{
		return default(IACGCHNPDDC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x215E700", Offset = "0x215CF00", VA = "0x18215E700")]
	public IACGCHNPDDC<TActionKind, TSerializedAction, TRoot, TDeps> ACLPINDHGOA<TPayload, TOk, TErr>(TActionKind GAJGEJBMCCL, KIMCPPHCAEE<TActionKind, TSerializedAction, TPayload> IHANFIHDMIK, DLELKJHDLIJ<TRoot, TPayload, TOk, TErr> JDILABOMGAC, bool FCKIDDFNIDP = true) where TPayload : notnull where TOk : notnull where TErr : notnull, NHKNMEADEEO
	{
		return default(IACGCHNPDDC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x361A070", Offset = "0x3618870", VA = "0x18361A070")]
	public DNMOCJLFELM<TActionKind, TSerializedAction, TRoot, TDeps> GGLEHKIOADM(TDeps JOGDKLBFLFJ)
	{
		return default(DNMOCJLFELM<TActionKind, TSerializedAction, TRoot, TDeps>);
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
