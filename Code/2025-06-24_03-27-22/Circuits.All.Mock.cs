using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x28B4960", Offset = "0x28B3560", VA = "0x1828B4960")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA48850", Offset = "0xA47450", VA = "0x180A48850")]
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
		[Cpp2IlInjected.Address(RVA = "0xA48890", Offset = "0xA47490", VA = "0x180A48890")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct GILBBFNJKPL
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal sealed class DDCPNNLJFOJ : CCJFMGLJLNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public DDCPNNLJFOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xD21E30", Offset = "0xD20A30", VA = "0x180D21E30", Slot = "4")]
		public CCJFMGLJLNC BMNJPDCHNCB(string MEPFFFGIFGB, string OOHGFGHCOAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xD21E30", Offset = "0xD20A30", VA = "0x180D21E30", Slot = "5")]
		public CCJFMGLJLNC HNDMMKCHHHE(string MEPFFFGIFGB, string[] OOHGFGHCOAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xD21E30", Offset = "0xD20A30", VA = "0x180D21E30", Slot = "6")]
		public CCJFMGLJLNC LDLODIEEMME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "7")]
		public void GEEOJDFCKDC()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[FMJJHJFKIEK("CircuitsMockUtil")]
[MHCDBJJGKDE("We should move most methods which create objects to their respective type.")]
[MHCDBJJGKDE("All of the methods in this type should use named parameters for clarity.")]
public static class NLGKFPDFCJP
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class MOOJGPAOHHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public NEOHBEDIIMG roomRestrictionsManager;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public MOOJGPAOHHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28B3AA0", Offset = "0x28B26A0", VA = "0x1828B3AA0")]
		internal AGBLIACJDJF IMDDHAMBMAN(HPJFDLNNGLH i)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct BHDALICOPLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public AsyncTaskMethodBuilder<AEGONMJFPDD<ONOHOFNNIBD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public NEOHBEDIIMG roomRestrictionsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private TaskAwaiter<AEGONMJFPDD<FCJGMOOJNHF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x28A8710", Offset = "0x28A7310", VA = "0x1828A8710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28A8C60", Offset = "0x28A7860", VA = "0x1828A8C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct EPHAPFMMOOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AsyncTaskMethodBuilder<FCJGMOOJNHF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public CKBGMGBEBCF dependencies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public APCJJMMLALP network;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public FLOKGHAJACG? registry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public GIKBFGHDOMK? registryV2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CE0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public bool autoInitialize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CE8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private TaskAwaiter<FCJGMOOJNHF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28AD180", Offset = "0x28ABD80", VA = "0x1828AD180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x28AD7D0", Offset = "0x28AC3D0", VA = "0x1828AD7D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct OFGJOBOCGKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<FCJGMOOJNHF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public APCJJMMLALP network;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public CKBGMGBEBCF dependencies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public FLOKGHAJACG registry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public GIKBFGHDOMK registryV2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CD0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public IKLALLBKLKC<PEOCIBIIEAD>? rootObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CD8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public bool autoInitialize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CE0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private FCJGMOOJNHF <creationArgs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D08")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private CEGJGOPGACI <root>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<FCJGMOOJNHF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28B4A30", Offset = "0x28B3630", VA = "0x1828B4A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x28B4FF0", Offset = "0x28B3BF0", VA = "0x1828B4FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x28B4310", Offset = "0x28B2F10", VA = "0x1828B4310")]
	[AsyncStateMachine(typeof(BHDALICOPLM))]
	public static Task<AEGONMJFPDD<ONOHOFNNIBD>>? GJAEPHBJKHD([Optional] NEOHBEDIIMG? FKCCMDPCHKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x28B4400", Offset = "0x28B3000", VA = "0x1828B4400")]
	[FMJJHJFKIEK("NewCircuits")]
	[AsyncStateMachine(typeof(EPHAPFMMOOE))]
	public static Task<FCJGMOOJNHF> KDHCLIGJIFD(APCJJMMLALP PLHNIDGPPNO, [Optional] CKBGMGBEBCF? BNLGIODIEPM, [Optional] FLOKGHAJACG? KBMDBHHDHON, [Optional] GIKBFGHDOMK? IOPIJJPKIHO, bool ALPGKICKLKE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x28B45C0", Offset = "0x28B31C0", VA = "0x1828B45C0")]
	[FMJJHJFKIEK("NewCircuits")]
	[AsyncStateMachine(typeof(OFGJOBOCGKH))]
	public static Task<FCJGMOOJNHF> KDHCLIGJIFD(APCJJMMLALP PLHNIDGPPNO, CKBGMGBEBCF BNLGIODIEPM, FLOKGHAJACG KBMDBHHDHON, GIKBFGHDOMK IOPIJJPKIHO, IKLALLBKLKC<PEOCIBIIEAD>? OHBCDPKICHN, bool ALPGKICKLKE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x28B4140", Offset = "0x28B2D40", VA = "0x1828B4140")]
	public static (GDKMNGMOCFN, EIFCBOGJBFO) FEEFNFKHLHB()
	{
		return default((GDKMNGMOCFN, EIFCBOGJBFO));
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x28B4210", Offset = "0x28B2E10", VA = "0x1828B4210")]
	public static (EPEAAJCBNJM, CBFMLCEGIOE) GFLHCLLNNOD()
	{
		return default((EPEAAJCBNJM, CBFMLCEGIOE));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x28B4790", Offset = "0x28B3390", VA = "0x1828B4790")]
	[FMJJHJFKIEK("NewCircuitsNetwork")]
	public static APCJJMMLALP OMGOJCDPFKJ(int CEAEMJMOKLA = 10240, int OIPPNLIINDM = 204800, int FLJHNGHKAEO = 358400)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class EJJJJNFIODD
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate AGBLIACJDJF GLIKCHOBNMO(HPJFDLNNGLH KKPIMHHFAAG);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct IFPEFKOCBJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AsyncTaskMethodBuilder<AEGONMJFPDD<FCJGMOOJNHF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public EJJJJNFIODD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private TaskAwaiter<FCJGMOOJNHF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x28B2550", Offset = "0x28B1150", VA = "0x1828B2550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x28B2B60", Offset = "0x28B1760", VA = "0x1828B2B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly APCJJMMLALP GHGPFLFPIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private GLIKCHOBNMO? LNJPLGMCEIB;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xA2B6C0", Offset = "0xA2A2C0", VA = "0x180A2B6C0")]
	private EJJJJNFIODD(APCJJMMLALP PLHNIDGPPNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x28ACA50", Offset = "0x28AB650", VA = "0x1828ACA50")]
	public static EJJJJNFIODD IAIFKPGPJEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x28ACA30", Offset = "0x28AB630", VA = "0x1828ACA30")]
	public EJJJJNFIODD GPNAHKNEBFE(GLIKCHOBNMO OGBEDIBDEBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x28AC940", Offset = "0x28AB540", VA = "0x1828AC940")]
	[AsyncStateMachine(typeof(IFPEFKOCBJO))]
	public Task<AEGONMJFPDD<FCJGMOOJNHF>> GEEOJDFCKDC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class FJNEBNAOBIE : CEGJGOPGACI.GFEAJMIBKKC
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public delegate int BGLLONHFCKO();

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate void MBDEPIKOLFO();

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate void HOCOKOEPEDM();

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate MEOMPOFMLFP OHPFPHAEGEG(AANKPKALLNB.EHAACEBFNLM FCHJEFGMLNE);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void MCLJGDGCDCN(CEGJGOPGACI FADPJDENLPL);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void POGNMJOCMFN(CEGJGOPGACI FADPJDENLPL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly BGLLONHFCKO GHJMMOGFGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly MBDEPIKOLFO OCCJGKFNBPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly HOCOKOEPEDM ILFEPGLJFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly OHPFPHAEGEG OEFCHGJJALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly MCLJGDGCDCN FGLIGEADEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly POGNMJOCMFN ABAILACPNFP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int BLCMKAJDBID
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x11564B0", Offset = "0x11550B0", VA = "0x1811564B0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x28B1420", Offset = "0x28B0020", VA = "0x1828B1420", Slot = "6")]
	public void IMDCJPBOPJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x28B13F0", Offset = "0x28AFFF0", VA = "0x1828B13F0", Slot = "7")]
	public void CJGNJLAJPGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x28B1450", Offset = "0x28B0050", VA = "0x1828B1450", Slot = "5")]
	public MEOMPOFMLFP OJAPFGFBLGI(AANKPKALLNB.EHAACEBFNLM FCHJEFGMLNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xE14A60", Offset = "0xE13660", VA = "0x180E14A60", Slot = "8")]
	public void GKIFHDAJGLK(CEGJGOPGACI FADPJDENLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xE14970", Offset = "0xE13570", VA = "0x180E14970", Slot = "9")]
	public void DHNANGCIBOK(CEGJGOPGACI FADPJDENLPL, KDEPIGGKFKP IFDCDCHOGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x28B1480", Offset = "0x28B0080", VA = "0x1828B1480")]
	public FJNEBNAOBIE([Optional] BGLLONHFCKO? DDFBKMGDKOP, [Optional] MBDEPIKOLFO? EAELHFBMAII, [Optional] HOCOKOEPEDM? APLALAPJEOI, [Optional] OHPFPHAEGEG? NBFBAOMNKGB, [Optional] MCLJGDGCDCN? OKKHCGNCOEH, [Optional] POGNMJOCMFN? DIFNIGEPNNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[FMJJHJFKIEK("CircuitsCreationResult")]
public readonly struct FCJGMOOJNHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly DOINOKDAIBM<APCJJMMLALP, APCJJMMLALP.GOKBJJFGBMA> LMNDKJHLOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly FOEEKKEAGCO<APCJJMMLALP, APCJJMMLALP.DDINCOMHMNP> PMPKIFKHIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly CEGJGOPGACI MKODAANPAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly IKLALLBKLKC<KJCLJNBJCIN> DKFKKIHOHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly APCJJMMLALP MBNBCOIHGCH;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x28B10E0", Offset = "0x28AFCE0", VA = "0x1828B10E0")]
	public FCJGMOOJNHF(DOINOKDAIBM<APCJJMMLALP, APCJJMMLALP.GOKBJJFGBMA> GKADPAHCEOE, FOEEKKEAGCO<APCJJMMLALP, APCJJMMLALP.DDINCOMHMNP> NHPEGDNCKGI, CEGJGOPGACI FADPJDENLPL, IKLALLBKLKC<KJCLJNBJCIN> KPGHEBOCEPO, APCJJMMLALP PLHNIDGPPNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct ONOHOFNNIBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly CEGJGOPGACI OBMNPCHBLOE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public GIKBFGHDOMK KAKIHKOAPKN
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x28B5190", Offset = "0x28B3D90", VA = "0x1828B5190")]
		get
		{
			return default(GIKBFGHDOMK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ANJICKJOEAP GBEEPPGAEIO
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x28B5060", Offset = "0x28B3C60", VA = "0x1828B5060")]
		get
		{
			return default(ANJICKJOEAP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public LEANNJHEEGI? HFBLDNFKKCC
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x28B5090", Offset = "0x28B3C90", VA = "0x1828B5090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public HFFDMDCBNIF? CAFAPBENCLK
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x28B51C0", Offset = "0x28B3DC0", VA = "0x1828B51C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0xDCEEA0", Offset = "0xDCDAA0", VA = "0x180DCEEA0")]
	internal ONOHOFNNIBD(CEGJGOPGACI FADPJDENLPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class DEABIDBNKLM : CKBGMGBEBCF
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class ODBNPFMIADE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AGBLIACJDJF cv2Dependencies;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public ODBNPFMIADE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
		internal AGBLIACJDJF MGLLANACEIF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IOBIAKOIMFO.JEJCMAMIEJC AHLPECLFMLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AANKPKALLNB.EHAACEBFNLM ICCIACNECHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public CEGJGOPGACI.GFEAJMIBKKC IBOFJBKJJCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public DBOJBDPKOJN.JCBKFBPBICP EMHNMBGBHKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA246B0", Offset = "0xA232B0", VA = "0x180A246B0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public FMNPICICGKM.HNGEBILDPPH<FDHIFENBBCM, KDEPIGGKFKP, CEGJGOPGACI> BPABPOGNNEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA21F10", Offset = "0xA20B10", VA = "0x180A21F10", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ANJICKJOEAP.HMHKIFINHPF EABMEBPKCBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA24650", Offset = "0xA23250", VA = "0x180A24650", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public EOMCLJMENNP BHBONDCCBKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA24670", Offset = "0xA23270", VA = "0x180A24670", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public FNLPNDAMBLP PEHCNKLDPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA247E0", Offset = "0xA233E0", VA = "0x180A247E0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public OHBJGBFOGON DCEPOPKEMFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6A0", Offset = "0xA1B2A0", VA = "0x180A1C6A0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GGLGNLCNJOA PCAGLBAGCII
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6E0", Offset = "0xA1B2E0", VA = "0x180A1C6E0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public BDEMBJKFECE EBNAAGHFEFL
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6C0", Offset = "0xA1B2C0", VA = "0x180A1C6C0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x28AC0A0", Offset = "0x28AACA0", VA = "0x1828AC0A0")]
	private DEABIDBNKLM(IOBIAKOIMFO.JEJCMAMIEJC MOLKMBGOEOA, AANKPKALLNB.EHAACEBFNLM IOLJEEBMKEC, CEGJGOPGACI.GFEAJMIBKKC FMDFCGLMJKF, DBOJBDPKOJN.JCBKFBPBICP LCEOKKDHNDD, FMNPICICGKM.HNGEBILDPPH<FDHIFENBBCM, KDEPIGGKFKP, CEGJGOPGACI> FAKNKNLDDBF, ANJICKJOEAP.HMHKIFINHPF AADFPFPOJNB, EOMCLJMENNP CBCPKCBHDOF, FNLPNDAMBLP OMGHAKGLJGF, OHBJGBFOGON OEBNPKGNLDB, GGLGNLCNJOA CIIBALNIKFP, BDEMBJKFECE LLPCBDMONGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x28AB880", Offset = "0x28AA480", VA = "0x1828AB880")]
	public static DEABIDBNKLM? ELCJLCGCOAO(DBOJBDPKOJN.JCBKFBPBICP LCEOKKDHNDD, [Optional] IOBIAKOIMFO.JEJCMAMIEJC? MOLKMBGOEOA, [Optional] AANKPKALLNB.EHAACEBFNLM? IOLJEEBMKEC, [Optional] CEGJGOPGACI.GFEAJMIBKKC? FMDFCGLMJKF, [Optional] FMNPICICGKM.HNGEBILDPPH<FDHIFENBBCM, KDEPIGGKFKP, CEGJGOPGACI>? FAKNKNLDDBF, [Optional] ANJICKJOEAP.HMHKIFINHPF? AADFPFPOJNB, [Optional] EOMCLJMENNP? CBCPKCBHDOF, [Optional] FNLPNDAMBLP? OMGHAKGLJGF, [Optional] OHBJGBFOGON? OEBNPKGNLDB, [Optional] GGLGNLCNJOA? CIIBALNIKFP, [Optional] BDEMBJKFECE? LLPCBDMONGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x28ABF30", Offset = "0x28AAB30", VA = "0x1828ABF30")]
	public static DEABIDBNKLM? MCHILHDGNBG(AGBLIACJDJF PMAIPDHDENN, [Optional] IOBIAKOIMFO.JEJCMAMIEJC? MOLKMBGOEOA, [Optional] AANKPKALLNB.EHAACEBFNLM? IOLJEEBMKEC, [Optional] CEGJGOPGACI.GFEAJMIBKKC? FMDFCGLMJKF, [Optional] FMNPICICGKM.HNGEBILDPPH<FDHIFENBBCM, KDEPIGGKFKP, CEGJGOPGACI>? FAKNKNLDDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x28ABC80", Offset = "0x28AA880", VA = "0x1828ABC80")]
	public static DEABIDBNKLM? GLMKNPNJIDD(HPJFDLNNGLH NGLFMEMFIBG, [Optional] IOBIAKOIMFO.JEJCMAMIEJC? MOLKMBGOEOA, [Optional] AANKPKALLNB.EHAACEBFNLM? IOLJEEBMKEC, [Optional] CEGJGOPGACI.GFEAJMIBKKC? FMDFCGLMJKF, [Optional] FMNPICICGKM.HNGEBILDPPH<FDHIFENBBCM, KDEPIGGKFKP, CEGJGOPGACI>? FAKNKNLDDBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class FBOGOMPCFDB
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class GINEGJDPPNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int maxCloudVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public HPJFDLNNGLH getNetworkObjectDelegate;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public GINEGJDPPNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA1C110", Offset = "0xA1AD10", VA = "0x180A1C110")]
		internal int IDPNBEEJCBO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x28B22E0", Offset = "0x28B0EE0", VA = "0x1828B22E0")]
		internal DMNGLJMACGG JDLEFLGBLGG(Guid graphId, POMGKDAAEIL environmentId, bool isPlayer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x28B2170", Offset = "0x28B0D70", VA = "0x1828B2170")]
		internal DMNGLJMACGG[] BCGDMIOKCIE(POMGKDAAEIL environmentId, Guid[] graphIds, bool isPlayer)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class AHHGGGCKEPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public POMGKDAAEIL environmentId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public GINEGJDPPNI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public AHHGGGCKEPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x28A7F70", Offset = "0x28A6B70", VA = "0x1828A7F70")]
		internal DMNGLJMACGG PDAKEKFJJDG(Guid graphId)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly CMLIDFCPMDK PDBKEJIGBJI;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x28B1040", Offset = "0x28AFC40", VA = "0x1828B1040")]
	public static DMNGLJMACGG? DODMECGJDFD(IKLALLBKLKC<PEOCIBIIEAD>? HNBOGOMNMIA, [Optional] MLOOANDEKHB.ONJLIMOKEAI? PAJLAILDAOB, [Optional] MLOOANDEKHB.FOLJIKBEPMD? GEAOKLNIEKA, [Optional] MLOOANDEKHB.PCFAILFOBPJ? NFAKENPIPDN, bool CPKBIBMOIII = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x28ADBC0", Offset = "0x28AC7C0", VA = "0x1828ADBC0")]
	public static AGBLIACJDJF? ANJJILLFEBK(HPJFDLNNGLH NGLFMEMFIBG, bool GCEBJJBGOJJ = true, [Optional] GNDILNGFIBJ? EAONGEOFALP, [Optional] FHCLCGEGPPD? IPHAJBNFPNC, [Optional] EPJHIBAPADA? FDGHFPDGEHG, [Optional] NEOHBEDIIMG? PGPMPABNPJH, int ELMLDHBHFEM = 300000, bool JDGPKIAADIM = false, bool CIDFPLMICOE = false, [Optional] KCODMFNBBHP? JKGCKIGNMEK, [Optional] CKCDMHDCEJL? KMFMNBHCPOB, [Optional] HMGEEJELOJP? KHMNJLKHDAL, [Optional] EMDDGCBPJLE? MBOFICGHHIH, [Optional] HKCGODDAPIN? HEEPEKHJPDN, [Optional] HFPNDHJFHJB? PEJILBOIHMF, [Optional] OFPAHBIMAPB? NKEOHIALHKM, [Optional] MDEKLCBODDG.EDDPABJHCGP? PPBCLEEKFIO, [Optional] PAGDEKLNDBK.LOMLCJNEMOA? LNDGIGPLFJJ, [Optional] HACDCOMJBFJ? BCIGOFFKOFC, [Optional] AGBLIACJDJF.OHKFFFNCMCL? KOBGBNCBLEA, [Optional] AGBLIACJDJF.ODKJIPEFPBO? OLENEBLGFAA, [Optional] AGBLIACJDJF.NNFDJOOIKNN? GHBJBGDCGBB, [Optional] AGBLIACJDJF.EKELFDGPJEN? IBJOGOHILIF, [Optional] AGBLIACJDJF.KPJIFNBEKPG? CLNKFKAEPDC, [Optional] AGBLIACJDJF.ELBANPFNBBL? OPANFHAAEDG, [Optional] AGBLIACJDJF.GIIOHPGEEGA? FPAMHPBKINM, int EJOJGIGKDJM = 100, [Optional] AGBLIACJDJF.IBBDGLFDHOO? BGDPMLHBOBB, [Optional] AGBLIACJDJF.IIJDGPPPNJF? JBLOKELDHHK, [Optional] AGBLIACJDJF.HJNCBBILKND? LICGIKNFBKN, [Optional] AGBLIACJDJF.JFGHCLMFEPM? IAAOHLBFHLP, [Optional] AGBLIACJDJF.HBOLFHKCIDN? NADGNIHOGGC, [Optional] AGBLIACJDJF.GJPKGBCACIF? POEBJBKJADF, [Optional] AGBLIACJDJF.JBJMOMCNINA? GANJEIIMLLF, [Optional] AGBLIACJDJF.NFGKGNBCIAP? NNFNNEKLGIL, [Optional] AGBLIACJDJF.MNGLBNIPNJI? IINDKDBLPDI, [Optional] AGBLIACJDJF.HMBFEDLMIGJ? ALILOGFDCKA, [Optional] AGBLIACJDJF.NOKGKNGBHGG? MJHMKFCPMBE, [Optional] AGBLIACJDJF.NDEHBMKMPLO? KOGMLBJPDGN, [Optional] AGBLIACJDJF.NOBIHKOODKK? DMLPFGDNBNG, [Optional] AGBLIACJDJF.KHIJHODFHPH? OEBAFJJPIDM, [Optional] AGBLIACJDJF.PKCOJOOBMCH? PDJFLELFMFH, [Optional] AGBLIACJDJF.OLMPKAIHNMN? DKDEKBKFIND, [Optional] AGBLIACJDJF.AFCGELOLNBK? KJEALCKHIFC, [Optional] AGBLIACJDJF.EBNCHHMLCOC? INAFMIJBIEE, [Optional] AGBLIACJDJF.BKAFHKINPKE? MNINKEJEKNG, [Optional] AGBLIACJDJF.KLBIBBFNPAM? ICOIHBHENDB, [Optional] AGBLIACJDJF.MGHDHNOBBCH? BGIBGMIBMAG, [Optional] AGBLIACJDJF.CNFBPEADGKP? KBJCCLDHCPF, [Optional] AGBLIACJDJF.IDOFHHLCJPA? IDLACILIBPC, [Optional] AGBLIACJDJF.PLPAECHBNLD? DBEEJDNLEML, [Optional] AGBLIACJDJF.MGDMGNACJKM? GENKKMFBPOJ, [Optional] AGBLIACJDJF.FGNLGFHMBJA? MOFAGPFDEBG, [Optional] AGBLIACJDJF.GBNKNNHFJFO? IDIPNAHLKGN, [Optional] AGBLIACJDJF.AICENIGGHPK? CIOPPOOIEFN, [Optional] AGBLIACJDJF.HGEFBMCEHJJ? OFHPPOFIPHJ, [Optional] AGBLIACJDJF.AMJNMLLNNLH? DFCDPDELMPI, [Optional] AGBLIACJDJF.CAJNCOGHHON? CICDGDLNKGC, [Optional] AGBLIACJDJF.NPGLFFOBHBA? BCMBFDIKDND, [Optional] AGBLIACJDJF.JKIHGLAGFKL? AFGKCALPDPD, [Optional] AGBLIACJDJF.EFAIDPJMMGG? JBFKBKCMDGD, [Optional] AGBLIACJDJF.KCALPNIKCAN? CPEHDJLIDEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public delegate IKLALLBKLKC<PEOCIBIIEAD>? HPJFDLNNGLH([In] Guid LMBLGALMBCI, POMGKDAAEIL OAJMKPFMDHN);
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class GHIHHDMEPFC : EMDDGCBPJLE
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate object EFGKMKEAFJA();

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public static readonly GHIHHDMEPFC LBPNLDGACAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly EFGKMKEAFJA? HMDODONICGF;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x28B2050", Offset = "0x28B0C50", VA = "0x1828B2050", Slot = "4")]
	public (GPLAGLJINHB, GPLAGLJINHB, GPLAGLJINHB, GPLAGLJINHB, GPLAGLJINHB) EHDDCDLBPPI(object NEOGODNGJJE)
	{
		return default((GPLAGLJINHB, GPLAGLJINHB, GPLAGLJINHB, GPLAGLJINHB, GPLAGLJINHB));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x28B20C0", Offset = "0x28B0CC0", VA = "0x1828B20C0", Slot = "5")]
	public object PNCBOHOKKCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390", Slot = "6")]
	public bool JICHDGIBAGD(object NEOGODNGJJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xA84220", Offset = "0xA82E20", VA = "0x180A84220", Slot = "7")]
	public string GMECFFKGBGO(object NEOGODNGJJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xA2B6C0", Offset = "0xA2A2C0", VA = "0x180A2B6C0")]
	public GHIHHDMEPFC([Optional] EFGKMKEAFJA? FIHPGLPJCLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class MLOOANDEKHB : DMNGLJMACGG
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate bool ONJLIMOKEAI(MLOOANDEKHB LAAPKLDJLPE);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public delegate bool FOLJIKBEPMD(MLOOANDEKHB LAAPKLDJLPE);

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public delegate bool PCFAILFOBPJ(MLOOANDEKHB LAAPKLDJLPE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly ONJLIMOKEAI NNNGNFLCEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly FOLJIKBEPMD OCBONFGHGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly PCFAILFOBPJ CPABFAJJCKN;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string? AJPMCBKCCJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private KAMMFDFPLFI? PLMKKNGCGFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xA1F7B0", Offset = "0xA1E3B0", VA = "0x180A1F7B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public POMGKDAAEIL MIJAEEGNFKN
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xDCDC30", Offset = "0xDCC830", VA = "0x180DCDC30", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(POMGKDAAEIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool OGMIKCHLKLM
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x28B3A70", Offset = "0x28B2670", VA = "0x1828B3A70", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool MGIEGMKHMFP
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x28B3A40", Offset = "0x28B2640", VA = "0x1828B3A40", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool MMKPAEKIHCI
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x28B3A10", Offset = "0x28B2610", VA = "0x1828B3A10", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public BGFNLDBDOKO? EKCOHDKEDMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public IKLALLBKLKC<PEOCIBIIEAD>? NAFCEMDCJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xA247E0", Offset = "0xA233E0", VA = "0x180A247E0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x28B38C0", Offset = "0x28B24C0", VA = "0x1828B38C0", Slot = "11")]
	public CMFEBAIAIDJ<PCMODOINFKB> Self()
	{
		return default(CMFEBAIAIDJ<PCMODOINFKB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x28B3270", Offset = "0x28B1E70", VA = "0x1828B3270", Slot = "12")]
	public CMFEBAIAIDJ<PCMODOINFKB> GetRootObject(CMLIDFCPMDK FCEJBDLGOKN, MCABANBAJBJ EGBJBBONJCG)
	{
		return default(CMFEBAIAIDJ<PCMODOINFKB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xA1F7B0", Offset = "0xA1E3B0", VA = "0x180A1F7B0", Slot = "13")]
	public void Bind(KAMMFDFPLFI PLKADNAIHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "14")]
	public void Unbind()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x28B3960", Offset = "0x28B2560", VA = "0x1828B3960")]
	private MLOOANDEKHB(IKLALLBKLKC<PEOCIBIIEAD>? HNBOGOMNMIA, ONJLIMOKEAI PAJLAILDAOB, FOLJIKBEPMD GEAOKLNIEKA, PCFAILFOBPJ NFAKENPIPDN, string? LAOCJKNALFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "15")]
	public void ConfigureAttachedObject()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "16")]
	public void RemoveAITracking()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x28B3310", Offset = "0x28B1F10", VA = "0x1828B3310")]
	public static MLOOANDEKHB? JHMOIFLKJAD(IKLALLBKLKC<PEOCIBIIEAD>? HNBOGOMNMIA, [Optional] ONJLIMOKEAI? PAJLAILDAOB, [Optional] FOLJIKBEPMD? GEAOKLNIEKA, [Optional] PCFAILFOBPJ? NFAKENPIPDN, bool CPKBIBMOIII = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class DDPOHACBMHA : KCODMFNBBHP
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public delegate float GKBBFBOJJEH([In] float OOHGFGHCOAJ, [In] int BHIFEOIJENC);

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public delegate float ILIDDJIMBHA([In] float OOHGFGHCOAJ, [In] int BHIFEOIJENC);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public delegate ILOKKGKPOAO CMFFFIGGFMM([In] ILOKKGKPOAO ABBBJFPFEKP, [In] ILOKKGKPOAO KLKIJPOLHDE, float LPCHKKFEGJO);

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public delegate float BJFALIKCKNE([In] ILOKKGKPOAO ABBBJFPFEKP, [In] ILOKKGKPOAO KLKIJPOLHDE, [In] ILOKKGKPOAO OFHHGNENJGM);

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate FCIODMCCBFM OCJCIPKLEAP([In] CBMNNEHFFOM LAAPKLDJLPE);

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public delegate BAFEAPHEBAL DLELIDLJDBB([In] CBMNNEHFFOM LAAPKLDJLPE);

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public delegate CBMNNEHFFOM LNFCBLICGIC([In] CBMNNEHFFOM LAAPKLDJLPE);

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public delegate CBMNNEHFFOM ADDHAGDKANL([In] CBMNNEHFFOM HLPEBKMLKLE, [In] CBMNNEHFFOM MAELALMKOEM);

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public delegate CBMNNEHFFOM CFBNGEBCAKH([In] GMKNICPDGDB LAAPKLDJLPE);

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate float LOPNOGHKKMP([In] BAFEAPHEBAL HLPEBKMLKLE, [In] BAFEAPHEBAL MAELALMKOEM);

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate BAFEAPHEBAL AFIJFFGCFGM(float DKEFJLPHHMH, [In] FCIODMCCBFM KEMPOFCKINI);

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate BAFEAPHEBAL HDGIJJHFGNK([In] FCIODMCCBFM DBDCOHEOECM);

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate BAFEAPHEBAL BDAIFNAKDKH([In] FCIODMCCBFM LCBBCIAOPMI, [In] FCIODMCCBFM DOBINIDCOKP);

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public delegate BAFEAPHEBAL JKECGOBHHNP([In] FCIODMCCBFM FCFFHIKPKAE, [In] FCIODMCCBFM GODCCMEEDJH);

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public delegate float EFGAPINCEJP([In] BAFEAPHEBAL HLPEBKMLKLE, [In] BAFEAPHEBAL MAELALMKOEM);

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate BAFEAPHEBAL ODGJCKMDADJ([In] BAFEAPHEBAL LAAPKLDJLPE);

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public delegate BAFEAPHEBAL BPBHFIEIKKH([In] BAFEAPHEBAL ABBBJFPFEKP, [In] BAFEAPHEBAL KLKIJPOLHDE, float LPCHKKFEGJO);

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate BAFEAPHEBAL NHDJELNCDMB([In] BAFEAPHEBAL ABBBJFPFEKP, [In] BAFEAPHEBAL KLKIJPOLHDE, float LPCHKKFEGJO);

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public delegate float KDLIILLBANN([In] BAFEAPHEBAL ABBBJFPFEKP, [In] BAFEAPHEBAL KLKIJPOLHDE, [In] BAFEAPHEBAL OFHHGNENJGM);

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public delegate BAFEAPHEBAL KMFJPADDHID([In] BAFEAPHEBAL HLPEBKMLKLE, [In] BAFEAPHEBAL MAELALMKOEM);

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public delegate BAFEAPHEBAL FAMFMLEAHDF([In] BAFEAPHEBAL LAAPKLDJLPE);

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public delegate BAFEAPHEBAL EHPDPHKBHBB([In] BAFEAPHEBAL BBKPJEIDMDD, [In] BAFEAPHEBAL HKLMEDDFFBN, float GJKGIEIDONM);

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public delegate FCIODMCCBFM FGMACKKKHCP([In] BAFEAPHEBAL LAAPKLDJLPE, [In] FCIODMCCBFM PEEDOBEAECL);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public delegate BAFEAPHEBAL NLFIKBFCEEM([In] BAFEAPHEBAL ABBBJFPFEKP, [In] BAFEAPHEBAL KLKIJPOLHDE, float LPCHKKFEGJO);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public delegate void LMFOBBNFPEH([In] BAFEAPHEBAL LAAPKLDJLPE, [Out] float DKEFJLPHHMH, [Out] FCIODMCCBFM KEMPOFCKINI);

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public delegate FCIODMCCBFM CMKLMJBOKLM([In] BAFEAPHEBAL LAAPKLDJLPE);

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public delegate FCIODMCCBFM DFMHNDBNICC([In] FCIODMCCBFM HLPEBKMLKLE, [In] FCIODMCCBFM MAELALMKOEM);

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public delegate FCIODMCCBFM FCNDHICAGCF([In] FCIODMCCBFM LAAPKLDJLPE, [In] float CHEPOIJLLIC);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public delegate FCIODMCCBFM OJLKNNGPALJ([In] FCIODMCCBFM LAAPKLDJLPE, [In] FCIODMCCBFM JDDEHENHIEL, [In] FCIODMCCBFM EHAHFKKBMDI);

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public delegate FCIODMCCBFM LKAIPLPPPCO([In] FCIODMCCBFM HLPEBKMLKLE, [In] FCIODMCCBFM MAELALMKOEM);

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public delegate float HKFHKOFLBEP([In] FCIODMCCBFM HLPEBKMLKLE, [In] FCIODMCCBFM MAELALMKOEM);

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public delegate float MDHNKPDJHOI([In] FCIODMCCBFM HLPEBKMLKLE, [In] FCIODMCCBFM MAELALMKOEM);

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public delegate float HGMLLOGGIJE([In] FCIODMCCBFM LAAPKLDJLPE);

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public delegate FCIODMCCBFM GAIELIAEGJA([In] FCIODMCCBFM ABBBJFPFEKP, [In] FCIODMCCBFM KLKIJPOLHDE, float LPCHKKFEGJO);

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public delegate FCIODMCCBFM IMIFMLOLJCE([In] FCIODMCCBFM ABBBJFPFEKP, [In] FCIODMCCBFM KLKIJPOLHDE, float LPCHKKFEGJO);

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public delegate float HBGHGCLFENB([In] FCIODMCCBFM ABBBJFPFEKP, [In] FCIODMCCBFM KLKIJPOLHDE, [In] FCIODMCCBFM OFHHGNENJGM);

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public delegate FCIODMCCBFM MCILPNOFHLL([In] FCIODMCCBFM BEPIDBDGKDF, [In] FCIODMCCBFM MDKAAPLMLKG, float IELCCNNJLBP);

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public delegate FCIODMCCBFM OLFADCCBMFK([In] FCIODMCCBFM LAAPKLDJLPE);

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public delegate FCIODMCCBFM FOHFNAFHFCB([In] FCIODMCCBFM LAAPKLDJLPE);

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public delegate FCIODMCCBFM FEEMOPPDLFE([In] FCIODMCCBFM LAAPKLDJLPE, [In] FCIODMCCBFM IPCDFCDPLLN);

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public delegate FCIODMCCBFM HEPMGMKONDC([In] FCIODMCCBFM LAAPKLDJLPE, [In] FCIODMCCBFM EHAHFKKBMDI);

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public delegate FCIODMCCBFM NLPDGKIFGOI([In] FCIODMCCBFM LAAPKLDJLPE, float LGMFHBJKECL);

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public delegate FCIODMCCBFM IHLCNGMMGJI([In] FCIODMCCBFM BEPIDBDGKDF, [In] FCIODMCCBFM MDKAAPLMLKG, [In] FCIODMCCBFM EDCDBKJCGCC, float CCPPLDPHOCK, float IOPBCCGPEBC, float DJGAODFCDIF, [Out] FCIODMCCBFM PLOBHHEKGDJ);

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public delegate FCIODMCCBFM OODPIOJNJIB([In] FCIODMCCBFM HLPEBKMLKLE, [In] FCIODMCCBFM MAELALMKOEM);

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public delegate FCIODMCCBFM FJLKMAPDEJN([In] FCIODMCCBFM ABBBJFPFEKP, [In] FCIODMCCBFM KLKIJPOLHDE, float LPCHKKFEGJO);

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public delegate FCIODMCCBFM IMCNMJFFDGD([In] FCIODMCCBFM FMIMFBPMILF, [In] FCIODMCCBFM LEECNPFOJLB, [In] BAFEAPHEBAL MBEFGCGINBM);

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public delegate FCIODMCCBFM FHKJFLLHNCL([In] FCIODMCCBFM PLLNJKKDJMG, [In] FCIODMCCBFM LEECNPFOJLB, [In] BAFEAPHEBAL MBEFGCGINBM);

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public delegate float BMILKIGKHBJ();

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly DDPOHACBMHA LBPNLDGACAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly GKBBFBOJJEH? KCHPKJGBGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly ILIDDJIMBHA? MKMAACJMGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CMFFFIGGFMM? LMMCIIACPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly BJFALIKCKNE? FNDHEKGHCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly OCJCIPKLEAP? OKLANEBECLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly DLELIDLJDBB? IFDENGKOAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly LNFCBLICGIC? GGIFIFNAKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly ADDHAGDKANL? FNFODHFDONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly CFBNGEBCAKH? OCOKEBMBACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly LOPNOGHKKMP? HHDDJILIPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly AFIJFFGCFGM? OKCEHHMJCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly HDGIJJHFGNK? LIIBFLGGNFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly BDAIFNAKDKH? NKAKEBPJKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly JKECGOBHHNP? LNNCBEBLDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly EFGAPINCEJP? PBLAPOLFIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly ODGJCKMDADJ? HBOEBNAPMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly BPBHFIEIKKH? LLKCHIOHNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly NHDJELNCDMB? ILELOECLOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly KDLIILLBANN? CANCFJNOGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly KMFJPADDHID? BOAOAMLGGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly FAMFMLEAHDF? EKOHBBAPDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly EHPDPHKBHBB? AJFIEBFGIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly FGMACKKKHCP? OOPAALINKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly NLFIKBFCEEM? LACMELOEGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly LMFOBBNFPEH? BPDGBFBCOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly CMKLMJBOKLM? IHAABJJLALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly DFMHNDBNICC? JBNLCGAKKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly FCNDHICAGCF? CDAHKOMIOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly OJLKNNGPALJ? PPDLKLJPOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly LKAIPLPPPCO? AJDKLPAMLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly HKFHKOFLBEP? FNAIHGAFHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly MDHNKPDJHOI? EBKJNEHHKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly HGMLLOGGIJE? BABAOFEIICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly GAIELIAEGJA? MCJPCJHNPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly IMIFMLOLJCE? FCHDMIJFJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly HBGHGCLFENB? HEBKDNOPMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly MCILPNOFHLL? DPDCODFDKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly OLFADCCBMFK? BKCFEAAJMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly FOHFNAFHFCB? BBOHENEMEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly FEEMOPPDLFE? LMJBJIMGEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly HEPMGMKONDC? IHDFCMFMHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly NLPDGKIFGOI? HNMLCKKCIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly IHLCNGMMGJI? PGLJHBMFGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly OODPIOJNJIB? MACKBHAPEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly FJLKMAPDEJN? IMNPOBCCDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly IMCNMJFFDGD? ANLEHIGIBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly FHKJFLLHNCL? HMPJMGPKIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly BMILKIGKHBJ? CBDAAHFKIAM;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x28AB3A0", Offset = "0x28A9FA0", VA = "0x1828AB3A0")]
	public DDPOHACBMHA([Optional] CMFFFIGGFMM? ELIKMADEMNK, [Optional] BJFALIKCKNE? NOLKJOOCJGI, [Optional] OCJCIPKLEAP? GPICNFBNHJF, [Optional] DLELIDLJDBB? HDEIKMFGHNF, [Optional] LNFCBLICGIC? GLCMPJHLGBK, [Optional] ADDHAGDKANL? GKJCPDLLLON, [Optional] CFBNGEBCAKH? JNNCOILIOEA, [Optional] LOPNOGHKKMP? NIADMOFBKCL, [Optional] AFIJFFGCFGM? PIDCNPIMKCB, [Optional] HDGIJJHFGNK? JPMHINAABFN, [Optional] BDAIFNAKDKH? EIOFGHOBHOE, [Optional] JKECGOBHHNP? FEEHAOANIAN, [Optional] EFGAPINCEJP? GJAHJOANPDK, [Optional] ODGJCKMDADJ? LLGOFFIMMLN, [Optional] BPBHFIEIKKH? KFFKNEEDHKC, [Optional] NHDJELNCDMB? MIBDDONJCAI, [Optional] KDLIILLBANN? EHNNKHKHEMD, [Optional] KMFJPADDHID? FKPHKOJPGPE, [Optional] FAMFMLEAHDF? JEFBIDEFCMC, [Optional] EHPDPHKBHBB? PFANNIKIJPH, [Optional] FGMACKKKHCP? GHKAPBLPPAP, [Optional] NLFIKBFCEEM? DBMOJFEAOPG, [Optional] LMFOBBNFPEH? EJLDCPBCPKI, [Optional] CMKLMJBOKLM? AOELIPAINBM, [Optional] DFMHNDBNICC? BNJGLIPKDML, [Optional] FCNDHICAGCF? KPNIMCAGFHH, [Optional] OJLKNNGPALJ? GKIIKLNNOPN, [Optional] LKAIPLPPPCO? CNLPBHLKJPA, [Optional] HKFHKOFLBEP? FHFMFMKMOFI, [Optional] MDHNKPDJHOI? FDBEMCBDJIO, [Optional] HGMLLOGGIJE? BDFNJEJEGHN, [Optional] GAIELIAEGJA? IDIBJILKIKK, [Optional] IMIFMLOLJCE? JEFBDEFDLAF, [Optional] HBGHGCLFENB? NNCEKEKBDLA, [Optional] MCILPNOFHLL? PLOMOKGEBNF, [Optional] OLFADCCBMFK? JFHKFDDCNPO, [Optional] FOHFNAFHFCB? NDBGIIINODI, [Optional] FEEMOPPDLFE? JBFJGOPHFLK, [Optional] HEPMGMKONDC? LCMCFBCGMJM, [Optional] NLPDGKIFGOI? EGNOMFEOLFN, [Optional] IHLCNGMMGJI? EHLLEMHOAJA, [Optional] OODPIOJNJIB? CJHHBNJDION, [Optional] FJLKMAPDEJN? AKLLJDAALID, [Optional] IMCNMJFFDGD? JKLLFPNOAIO, [Optional] FHKJFLLHNCL? MECMMPFPCDI, [Optional] BMILKIGKHBJ? AGDBNDJPMAK, [Optional] GKBBFBOJJEH? HPELDPGPBFL, [Optional] ILIDDJIMBHA? GOBHBGECBKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x28AAB80", Offset = "0x28A9780", VA = "0x1828AAB80")]
	public float MEGGJONCKHI([In] float OOHGFGHCOAJ, [In] int BHIFEOIJENC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x28AAB60", Offset = "0x28A9760", VA = "0x1828AAB60")]
	public float LHONIHPDBEN([In] float OOHGFGHCOAJ, [In] int BHIFEOIJENC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x28AAE70", Offset = "0x28A9A70", VA = "0x1828AAE70")]
	public ILOKKGKPOAO NONEOMKMKEL([In] ILOKKGKPOAO ABBBJFPFEKP, [In] ILOKKGKPOAO KLKIJPOLHDE, float LPCHKKFEGJO)
	{
		return default(ILOKKGKPOAO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x28AA970", Offset = "0x28A9570", VA = "0x1828AA970")]
	public float MNPPOPCIOLN([In] ILOKKGKPOAO ABBBJFPFEKP, [In] ILOKKGKPOAO KLKIJPOLHDE, [In] ILOKKGKPOAO OFHHGNENJGM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x28A9F50", Offset = "0x28A8B50", VA = "0x1828A9F50")]
	public FCIODMCCBFM FBOBLBNBGFN([In] CBMNNEHFFOM LAAPKLDJLPE)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x28A9DF0", Offset = "0x28A89F0", VA = "0x1828A9DF0")]
	public BAFEAPHEBAL EINJEANCEBA([In] CBMNNEHFFOM LAAPKLDJLPE)
	{
		return default(BAFEAPHEBAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x28AA740", Offset = "0x28A9340", VA = "0x1828AA740")]
	public CBMNNEHFFOM IPMCKMOPPFE([In] CBMNNEHFFOM LAAPKLDJLPE)
	{
		return default(CBMNNEHFFOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x28AA500", Offset = "0x28A9100", VA = "0x1828AA500")]
	public CBMNNEHFFOM HNFMPKAIEJD([In] CBMNNEHFFOM HLPEBKMLKLE, [In] CBMNNEHFFOM MAELALMKOEM)
	{
		return default(CBMNNEHFFOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x28AAA80", Offset = "0x28A9680", VA = "0x1828AAA80")]
	public CBMNNEHFFOM LELANFDMDNN([In] GMKNICPDGDB LAAPKLDJLPE)
	{
		return default(CBMNNEHFFOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x28A94B0", Offset = "0x28A80B0", VA = "0x1828A94B0")]
	public float BBLEACPILKG([In] BAFEAPHEBAL HLPEBKMLKLE, [In] BAFEAPHEBAL MAELALMKOEM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x28A9270", Offset = "0x28A7E70", VA = "0x1828A9270")]
	public BAFEAPHEBAL LMKLHGCBNFH(float DKEFJLPHHMH, [In] FCIODMCCBFM KEMPOFCKINI)
	{
		return default(BAFEAPHEBAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x28A9E40", Offset = "0x28A8A40", VA = "0x1828A9E40")]
	public BAFEAPHEBAL ELGCNIIPMLJ([In] FCIODMCCBFM DBDCOHEOECM)
	{
		return default(BAFEAPHEBAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x28A9660", Offset = "0x28A8260", VA = "0x1828A9660")]
	public BAFEAPHEBAL NMFDMCKHLHN([In] FCIODMCCBFM LCBBCIAOPMI, [In] FCIODMCCBFM DOBINIDCOKP)
	{
		return default(BAFEAPHEBAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x28AAF40", Offset = "0x28A9B40", VA = "0x1828AAF40")]
	public BAFEAPHEBAL PAKPAGLJAJP([In] FCIODMCCBFM FCFFHIKPKAE, [In] FCIODMCCBFM GODCCMEEDJH)
	{
		return default(BAFEAPHEBAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x28A98F0", Offset = "0x28A84F0", VA = "0x1828A98F0")]
	public BAFEAPHEBAL IJHKLHOLIEI([In] BAFEAPHEBAL LAAPKLDJLPE)
	{
		return default(BAFEAPHEBAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x28AA5D0", Offset = "0x28A91D0", VA = "0x1828AA5D0")]
	public BAFEAPHEBAL IINAEFMFLFG([In] BAFEAPHEBAL ABBBJFPFEKP, [In] BAFEAPHEBAL KLKIJPOLHDE, float LPCHKKFEGJO)
	{
		return default(BAFEAPHEBAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x28AACE0", Offset = "0x28A98E0", VA = "0x1828AACE0")]
	public BAFEAPHEBAL MJBBHLICELD([In] BAFEAPHEBAL ABBBJFPFEKP, [In] BAFEAPHEBAL KLKIJPOLHDE, float LPCHKKFEGJO)
	{
		return default(BAFEAPHEBAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x28A9710", Offset = "0x28A8310", VA = "0x1828A9710")]
	public float BNGGIDNHNOO([In] BAFEAPHEBAL ABBBJFPFEKP, [In] BAFEAPHEBAL KLKIJPOLHDE, [In] BAFEAPHEBAL OFHHGNENJGM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x28A94D0", Offset = "0x28A80D0", VA = "0x1828A94D0")]
	public BAFEAPHEBAL HCBPLFDOMLO([In] BAFEAPHEBAL HLPEBKMLKLE, [In] BAFEAPHEBAL MAELALMKOEM)
	{
		return default(BAFEAPHEBAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x28A9D50", Offset = "0x28A8950", VA = "0x1828A9D50")]
	public BAFEAPHEBAL JGAIDEJPAJK([In] BAFEAPHEBAL LAAPKLDJLPE)
	{
		return default(BAFEAPHEBAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x28A9B20", Offset = "0x28A8720", VA = "0x1828A9B20")]
	public BAFEAPHEBAL ELHDCGIGFPP([In] BAFEAPHEBAL BBKPJEIDMDD, [In] BAFEAPHEBAL HKLMEDDFFBN, float GJKGIEIDONM)
	{
		return default(BAFEAPHEBAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x28AA6D0", Offset = "0x28A92D0", VA = "0x1828AA6D0")]
	public FCIODMCCBFM ILOFDKFDBNM([In] BAFEAPHEBAL LAAPKLDJLPE, [In] FCIODMCCBFM PEEDOBEAECL)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x28A9A00", Offset = "0x28A8600", VA = "0x1828A9A00")]
	public BAFEAPHEBAL NKPEOLFAAMH([In] BAFEAPHEBAL ABBBJFPFEKP, [In] BAFEAPHEBAL KLKIJPOLHDE, float LPCHKKFEGJO)
	{
		return default(BAFEAPHEBAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x28AA690", Offset = "0x28A9290", VA = "0x1828AA690")]
	public void IKEDDLCKACN([In] BAFEAPHEBAL LAAPKLDJLPE, [Out] float DKEFJLPHHMH, [Out] FCIODMCCBFM KEMPOFCKINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x28AA260", Offset = "0x28A8E60", VA = "0x1828AA260")]
	public FCIODMCCBFM GMANEMENACP([In] BAFEAPHEBAL LAAPKLDJLPE)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x28AA890", Offset = "0x28A9490", VA = "0x1828AA890")]
	public FCIODMCCBFM JGGADGANBNF([In] FCIODMCCBFM HLPEBKMLKLE, [In] FCIODMCCBFM MAELALMKOEM)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x28AAC10", Offset = "0x28A9810", VA = "0x1828AAC10")]
	public FCIODMCCBFM MDCJGKEJKLN([In] FCIODMCCBFM LAAPKLDJLPE, float CHEPOIJLLIC)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x28A97B0", Offset = "0x28A83B0", VA = "0x1828A97B0")]
	public FCIODMCCBFM CIFMNJPOIHF([In] FCIODMCCBFM LAAPKLDJLPE, [In] FCIODMCCBFM JDDEHENHIEL, [In] FCIODMCCBFM EHAHFKKBMDI)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x28AAED0", Offset = "0x28A9AD0", VA = "0x1828AAED0")]
	public FCIODMCCBFM OBPKCDLKCIM([In] FCIODMCCBFM HLPEBKMLKLE, [In] FCIODMCCBFM MAELALMKOEM)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x28A9250", Offset = "0x28A7E50", VA = "0x1828A9250")]
	public float NLGNGPJKNKK([In] FCIODMCCBFM HLPEBKMLKLE, [In] FCIODMCCBFM MAELALMKOEM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x28A9490", Offset = "0x28A8090", VA = "0x1828A9490")]
	public float ECLHKCLNBIJ([In] FCIODMCCBFM HLPEBKMLKLE, [In] FCIODMCCBFM MAELALMKOEM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x28AA110", Offset = "0x28A8D10", VA = "0x1828AA110")]
	public float OEEKKPKMIGG([In] FCIODMCCBFM LAAPKLDJLPE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x28AB160", Offset = "0x28A9D60", VA = "0x1828AB160")]
	public FCIODMCCBFM PJLBMKFKIAA([In] FCIODMCCBFM ABBBJFPFEKP, [In] FCIODMCCBFM KLKIJPOLHDE, float LPCHKKFEGJO)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x28A9FE0", Offset = "0x28A8BE0", VA = "0x1828A9FE0")]
	public FCIODMCCBFM FEMEPABFKBH([In] FCIODMCCBFM ABBBJFPFEKP, [In] FCIODMCCBFM KLKIJPOLHDE, float LPCHKKFEGJO)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x28A9FB0", Offset = "0x28A8BB0", VA = "0x1828A9FB0")]
	public float MDHIDFCGGCN([In] FCIODMCCBFM ABBBJFPFEKP, [In] FCIODMCCBFM KLKIJPOLHDE, [In] FCIODMCCBFM OFHHGNENJGM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x28AA2C0", Offset = "0x28A8EC0", VA = "0x1828AA2C0")]
	public FCIODMCCBFM HAFAIJLNDBG([In] FCIODMCCBFM BEPIDBDGKDF, [In] FCIODMCCBFM MDKAAPLMLKG, float IELCCNNJLBP)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x28A9820", Offset = "0x28A8420", VA = "0x1828A9820")]
	public FCIODMCCBFM CIPIFFIPLIF([In] FCIODMCCBFM LAAPKLDJLPE)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x28AA3F0", Offset = "0x28A8FF0", VA = "0x1828AA3F0")]
	public FCIODMCCBFM HFCGOLLACML([In] FCIODMCCBFM LAAPKLDJLPE)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x28AAA10", Offset = "0x28A9610", VA = "0x1828AAA10")]
	public FCIODMCCBFM LCABPDHCBON([In] FCIODMCCBFM LAAPKLDJLPE, [In] FCIODMCCBFM IPCDFCDPLLN)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x28A95F0", Offset = "0x28A81F0", VA = "0x1828A95F0")]
	public FCIODMCCBFM BHDPEDIKAAD([In] FCIODMCCBFM LAAPKLDJLPE, [In] FCIODMCCBFM EHAHFKKBMDI)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x28AA1F0", Offset = "0x28A8DF0", VA = "0x1828AA1F0")]
	public FCIODMCCBFM GKOCDEGNKCA([In] FCIODMCCBFM LAAPKLDJLPE, float LGMFHBJKECL)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x28A9CA0", Offset = "0x28A88A0", VA = "0x1828A9CA0")]
	public FCIODMCCBFM ECKOEHNOHJH([In] FCIODMCCBFM BEPIDBDGKDF, [In] FCIODMCCBFM MDKAAPLMLKG, [In] FCIODMCCBFM EDCDBKJCGCC, float CCPPLDPHOCK, float IOPBCCGPEBC, float DJGAODFCDIF, [Out] FCIODMCCBFM PLOBHHEKGDJ)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x28AA7B0", Offset = "0x28A93B0", VA = "0x1828AA7B0")]
	public FCIODMCCBFM JAJLLLAHLPE([In] FCIODMCCBFM HLPEBKMLKLE, [In] FCIODMCCBFM MAELALMKOEM)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x28A9880", Offset = "0x28A8480", VA = "0x1828A9880")]
	public FCIODMCCBFM DDAAPPNLNEB([In] FCIODMCCBFM ABBBJFPFEKP, [In] FCIODMCCBFM KLKIJPOLHDE, float LPCHKKFEGJO)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x28AADA0", Offset = "0x28A99A0", VA = "0x1828AADA0")]
	public FCIODMCCBFM NAADEHLMHMD([In] FCIODMCCBFM FMIMFBPMILF, [In] FCIODMCCBFM LEECNPFOJLB, [In] BAFEAPHEBAL MBEFGCGINBM)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x28AABA0", Offset = "0x28A97A0", VA = "0x1828AABA0")]
	public FCIODMCCBFM LOLPHBKPKCI([In] FCIODMCCBFM PLLNJKKDJMG, [In] FCIODMCCBFM LEECNPFOJLB, [In] BAFEAPHEBAL MBEFGCGINBM)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x28AB0C0", Offset = "0x28A9CC0", VA = "0x1828AB0C0", Slot = "50")]
	public Task PENJDHBAMKG(Func<Task> PAGHHLHAGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "51")]
	public void DODKDOPBKNP([Optional] string? FNFIPKNHEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x28AA450", Offset = "0x28A9050", VA = "0x1828AA450", Slot = "52")]
	public OKHIIGNFPLG HJGPIIOJCHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x28AA330", Offset = "0x28A8F30", VA = "0x1828AA330", Slot = "53")]
	public OKHIIGNFPLG HAKMOPNBICH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x28A9320", Offset = "0x28A7F20", VA = "0x1828A9320", Slot = "54")]
	public float AHBHFOBMEBG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x28AAB80", Offset = "0x28A9780", VA = "0x1828AAB80", Slot = "4")]
	private float LMPBFMGMPIC([In] float OOHGFGHCOAJ, [In] int BHIFEOIJENC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x28AAB60", Offset = "0x28A9760", VA = "0x1828AAB60", Slot = "5")]
	private float NDHALCMKKEL([In] float OOHGFGHCOAJ, [In] int BHIFEOIJENC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x28AA190", Offset = "0x28A8D90", VA = "0x1828AA190", Slot = "6")]
	private ILOKKGKPOAO GKAPEDFOKHC([In] ILOKKGKPOAO ABBBJFPFEKP, [In] ILOKKGKPOAO KLKIJPOLHDE, float LPCHKKFEGJO)
	{
		return default(ILOKKGKPOAO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x28AA970", Offset = "0x28A9570", VA = "0x1828AA970", Slot = "7")]
	private float KKONMHOEGKJ([In] ILOKKGKPOAO ABBBJFPFEKP, [In] ILOKKGKPOAO KLKIJPOLHDE, [In] ILOKKGKPOAO OFHHGNENJGM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x28AA130", Offset = "0x28A8D30", VA = "0x1828AA130", Slot = "8")]
	private FCIODMCCBFM GJKCJPNFHPI([In] CBMNNEHFFOM LAAPKLDJLPE)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x28AA0C0", Offset = "0x28A8CC0", VA = "0x1828AA0C0", Slot = "9")]
	private BAFEAPHEBAL GAFHFOLJOAH([In] CBMNNEHFFOM LAAPKLDJLPE)
	{
		return default(BAFEAPHEBAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x28AA4A0", Offset = "0x28A90A0", VA = "0x1828AA4A0", Slot = "10")]
	private CBMNNEHFFOM HMMFPNBGBNP([In] CBMNNEHFFOM LAAPKLDJLPE)
	{
		return default(CBMNNEHFFOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x28AA570", Offset = "0x28A9170", VA = "0x1828AA570", Slot = "11")]
	private CBMNNEHFFOM IHHEDKBJCCE([In] CBMNNEHFFOM HLPEBKMLKLE, [In] CBMNNEHFFOM MAELALMKOEM)
	{
		return default(CBMNNEHFFOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x28AAE10", Offset = "0x28A9A10", VA = "0x1828AAE10", Slot = "12")]
	private CBMNNEHFFOM NHFIGCOEKEA([In] GMKNICPDGDB LAAPKLDJLPE)
	{
		return default(CBMNNEHFFOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x28A94B0", Offset = "0x28A80B0", VA = "0x1828A94B0", Slot = "13")]
	private float BBPMNJBNEGM([In] BAFEAPHEBAL HLPEBKMLKLE, [In] BAFEAPHEBAL MAELALMKOEM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x28A9270", Offset = "0x28A7E70", VA = "0x1828A9270", Slot = "14")]
	private BAFEAPHEBAL ACOMOKFIKCI(float DKEFJLPHHMH, [In] FCIODMCCBFM KEMPOFCKINI)
	{
		return default(BAFEAPHEBAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x28A9E40", Offset = "0x28A8A40", VA = "0x1828A9E40", Slot = "15")]
	private BAFEAPHEBAL ODCOPIOKLCB([In] FCIODMCCBFM DBDCOHEOECM)
	{
		return default(BAFEAPHEBAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x28A9660", Offset = "0x28A8260", VA = "0x1828A9660", Slot = "16")]
	private BAFEAPHEBAL BHLCAOENFMJ([In] FCIODMCCBFM LCBBCIAOPMI, [In] FCIODMCCBFM DOBINIDCOKP)
	{
		return default(BAFEAPHEBAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x28AAF40", Offset = "0x28A9B40", VA = "0x1828AAF40", Slot = "17")]
	private BAFEAPHEBAL OLBFLCNFOCK([In] FCIODMCCBFM FCFFHIKPKAE, [In] FCIODMCCBFM GODCCMEEDJH)
	{
		return default(BAFEAPHEBAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x28A98F0", Offset = "0x28A84F0", VA = "0x1828A98F0", Slot = "18")]
	private BAFEAPHEBAL DFBIMCNDBLN([In] BAFEAPHEBAL LAAPKLDJLPE)
	{
		return default(BAFEAPHEBAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x28AA5D0", Offset = "0x28A91D0", VA = "0x1828AA5D0", Slot = "19")]
	private BAFEAPHEBAL NMMLIDHGFBO([In] BAFEAPHEBAL ABBBJFPFEKP, [In] BAFEAPHEBAL KLKIJPOLHDE, float LPCHKKFEGJO)
	{
		return default(BAFEAPHEBAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x28AACE0", Offset = "0x28A98E0", VA = "0x1828AACE0", Slot = "20")]
	private BAFEAPHEBAL OKJEBECNOME([In] BAFEAPHEBAL ABBBJFPFEKP, [In] BAFEAPHEBAL KLKIJPOLHDE, float LPCHKKFEGJO)
	{
		return default(BAFEAPHEBAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x28A9710", Offset = "0x28A8310", VA = "0x1828A9710", Slot = "21")]
	private float BIECCJMLEDC([In] BAFEAPHEBAL ABBBJFPFEKP, [In] BAFEAPHEBAL KLKIJPOLHDE, [In] BAFEAPHEBAL OFHHGNENJGM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x28A94D0", Offset = "0x28A80D0", VA = "0x1828A94D0", Slot = "22")]
	private BAFEAPHEBAL BCFNNKKMJCP([In] BAFEAPHEBAL HLPEBKMLKLE, [In] BAFEAPHEBAL MAELALMKOEM)
	{
		return default(BAFEAPHEBAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x28A9D50", Offset = "0x28A8950", VA = "0x1828A9D50", Slot = "23")]
	private BAFEAPHEBAL EHJPKBFLOHL([In] BAFEAPHEBAL LAAPKLDJLPE)
	{
		return default(BAFEAPHEBAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x28A9B20", Offset = "0x28A8720", VA = "0x1828A9B20", Slot = "24")]
	private BAFEAPHEBAL DLLMPHKIBDD([In] BAFEAPHEBAL BBKPJEIDMDD, [In] BAFEAPHEBAL HKLMEDDFFBN, float GJKGIEIDONM)
	{
		return default(BAFEAPHEBAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x28A93B0", Offset = "0x28A7FB0", VA = "0x1828A93B0", Slot = "25")]
	private FCIODMCCBFM AKJAJDCABIN([In] BAFEAPHEBAL LAAPKLDJLPE, [In] FCIODMCCBFM PEEDOBEAECL)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x28A9A00", Offset = "0x28A8600", VA = "0x1828A9A00", Slot = "26")]
	private BAFEAPHEBAL DJKGKMJAFJD([In] BAFEAPHEBAL ABBBJFPFEKP, [In] BAFEAPHEBAL KLKIJPOLHDE, float LPCHKKFEGJO)
	{
		return default(BAFEAPHEBAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x28AA690", Offset = "0x28A9290", VA = "0x1828AA690", Slot = "27")]
	private void LICDFLIACMI([In] BAFEAPHEBAL LAAPKLDJLPE, [Out] float DKEFJLPHHMH, [Out] FCIODMCCBFM KEMPOFCKINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x28A9AC0", Offset = "0x28A86C0", VA = "0x1828A9AC0", Slot = "28")]
	private FCIODMCCBFM DKBHHOODGBF([In] BAFEAPHEBAL LAAPKLDJLPE)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x28AA820", Offset = "0x28A9420", VA = "0x1828AA820", Slot = "29")]
	private FCIODMCCBFM JEKEJKJFHJC([In] FCIODMCCBFM HLPEBKMLKLE, [In] FCIODMCCBFM MAELALMKOEM)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x28A9EE0", Offset = "0x28A8AE0", VA = "0x1828A9EE0", Slot = "30")]
	private FCIODMCCBFM EOEPOMDOAHI([In] FCIODMCCBFM LAAPKLDJLPE, float CHEPOIJLLIC)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x28A9990", Offset = "0x28A8590", VA = "0x1828A9990", Slot = "31")]
	private FCIODMCCBFM DJEBNAHOHIH([In] FCIODMCCBFM IIBJECFMAJC, [In] FCIODMCCBFM DMGDMJIHNMA, [In] FCIODMCCBFM EHAHFKKBMDI)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x28AB0F0", Offset = "0x28A9CF0", VA = "0x1828AB0F0", Slot = "32")]
	private FCIODMCCBFM PHELNKCDIHI([In] FCIODMCCBFM HLPEBKMLKLE, [In] FCIODMCCBFM MAELALMKOEM)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x28AA9A0", Offset = "0x28A95A0", VA = "0x1828AA9A0", Slot = "33")]
	private FCIODMCCBFM KLFIBAHPLGJ([In] FCIODMCCBFM FMIMFBPMILF, [In] FCIODMCCBFM LEECNPFOJLB, [In] BAFEAPHEBAL MBEFGCGINBM)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x28A9420", Offset = "0x28A8020", VA = "0x1828A9420", Slot = "34")]
	private FCIODMCCBFM AMOENHIIHGD([In] FCIODMCCBFM PLLNJKKDJMG, [In] FCIODMCCBFM LEECNPFOJLB, [In] BAFEAPHEBAL MBEFGCGINBM)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x28A9250", Offset = "0x28A7E50", VA = "0x1828A9250", Slot = "35")]
	private float AAOIBJMPHCC([In] FCIODMCCBFM HLPEBKMLKLE, [In] FCIODMCCBFM MAELALMKOEM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x28A9490", Offset = "0x28A8090", VA = "0x1828A9490", Slot = "36")]
	private float BALFMJOLHCK([In] FCIODMCCBFM HLPEBKMLKLE, [In] FCIODMCCBFM MAELALMKOEM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x28AA110", Offset = "0x28A8D10", VA = "0x1828AA110", Slot = "37")]
	private float GICAGMKBEOI([In] FCIODMCCBFM LAAPKLDJLPE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x28A9340", Offset = "0x28A7F40", VA = "0x1828A9340", Slot = "38")]
	private FCIODMCCBFM AINJDDABHGH([In] FCIODMCCBFM ABBBJFPFEKP, [In] FCIODMCCBFM KLKIJPOLHDE, float LPCHKKFEGJO)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x28AA380", Offset = "0x28A8F80", VA = "0x1828AA380", Slot = "39")]
	private FCIODMCCBFM HDEBBFCCFIK([In] FCIODMCCBFM ABBBJFPFEKP, [In] FCIODMCCBFM KLKIJPOLHDE, float LPCHKKFEGJO)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x28A9FB0", Offset = "0x28A8BB0", VA = "0x1828A9FB0", Slot = "40")]
	private float FDEDNJFMDFE([In] FCIODMCCBFM ABBBJFPFEKP, [In] FCIODMCCBFM KLKIJPOLHDE, [In] FCIODMCCBFM OFHHGNENJGM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x28AA050", Offset = "0x28A8C50", VA = "0x1828AA050", Slot = "41")]
	private FCIODMCCBFM FGADINKEDFL([In] FCIODMCCBFM BEPIDBDGKDF, [In] FCIODMCCBFM MDKAAPLMLKG, float IELCCNNJLBP)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x28AB060", Offset = "0x28A9C60", VA = "0x1828AB060", Slot = "42")]
	private FCIODMCCBFM PBFLOBLOMNO([In] FCIODMCCBFM LAAPKLDJLPE)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x28AAC80", Offset = "0x28A9880", VA = "0x1828AAC80", Slot = "43")]
	private FCIODMCCBFM MEIHDPLGMKP([In] FCIODMCCBFM LAAPKLDJLPE)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x28A9580", Offset = "0x28A8180", VA = "0x1828A9580", Slot = "44")]
	private FCIODMCCBFM BGPKKFAJFNJ([In] FCIODMCCBFM LAAPKLDJLPE, [In] FCIODMCCBFM IPCDFCDPLLN)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x28AAFF0", Offset = "0x28A9BF0", VA = "0x1828AAFF0", Slot = "45")]
	private FCIODMCCBFM OMKGGELEGPA([In] FCIODMCCBFM LAAPKLDJLPE, [In] FCIODMCCBFM EHAHFKKBMDI)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x28A9740", Offset = "0x28A8340", VA = "0x1828A9740", Slot = "46")]
	private FCIODMCCBFM BPNDBMOOGKN([In] FCIODMCCBFM LAAPKLDJLPE, float LGMFHBJKECL)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x28A9BE0", Offset = "0x28A87E0", VA = "0x1828A9BE0", Slot = "47")]
	private FCIODMCCBFM EBGLONNBBPD([In] FCIODMCCBFM BEPIDBDGKDF, [In] FCIODMCCBFM MDKAAPLMLKG, [In] FCIODMCCBFM EDCDBKJCGCC, float CCPPLDPHOCK, float IOPBCCGPEBC, float DJGAODFCDIF, [Out] FCIODMCCBFM PLOBHHEKGDJ)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x28AA900", Offset = "0x28A9500", VA = "0x1828AA900", Slot = "48")]
	private FCIODMCCBFM KFPJAFJIDGD([In] FCIODMCCBFM HLPEBKMLKLE, [In] FCIODMCCBFM MAELALMKOEM)
	{
		return default(FCIODMCCBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x28AAAF0", Offset = "0x28A96F0", VA = "0x1828AAAF0", Slot = "49")]
	private FCIODMCCBFM LENDJAFBODE([In] FCIODMCCBFM ABBBJFPFEKP, [In] FCIODMCCBFM KLKIJPOLHDE, float LPCHKKFEGJO)
	{
		return default(FCIODMCCBFM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public sealed class OEHAJEFGEBL : KLDJJKAEHOI
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool FNLENPNGDAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x11D3510", Offset = "0x11D2110", VA = "0x1811D3510", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool OLMFCEBKHJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x1EFBB50", Offset = "0x1EFA750", VA = "0x181EFBB50", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x28B49E0", Offset = "0x28B35E0", VA = "0x1828B49E0")]
	public OEHAJEFGEBL(int ELMLDHBHFEM, bool JDGPKIAADIM, bool CIDFPLMICOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public sealed class PFBHLFGIFBJ : HMGEEJELOJP
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public delegate ILOKKGKPOAO PLGDOJAKBEH(int AMPLKDBJIMI);

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public delegate int EOBHLNCNFMC([In] ILOKKGKPOAO JKFOBPMCBLE);

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public delegate CMFEBAIAIDJ<BOFEABKGBFC> APLPDBGDLFE(AEBFKJBNKDA FCEJBDLGOKN, PGBNLILNOGO MAKMODIDCCD, bool BNBFIGILMOO);

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public static readonly PFBHLFGIFBJ LBPNLDGACAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly PLGDOJAKBEH? ONDHHACNMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly EOBHLNCNFMC? FPFNAJKMBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly APLPDBGDLFE? NKPNLNBBJKE;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0xCEAF50", Offset = "0xCE9B50", VA = "0x180CEAF50")]
	public PFBHLFGIFBJ([Optional] PLGDOJAKBEH? MOFCIMEAGLM, [Optional] EOBHLNCNFMC? KBHIBFDBFCF, [Optional] APLPDBGDLFE? HNBBLKGEEMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x28B5220", Offset = "0x28B3E20", VA = "0x1828B5220", Slot = "4")]
	public ILOKKGKPOAO GKFDKLCIGIJ(int AMPLKDBJIMI)
	{
		return default(ILOKKGKPOAO);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x28B5270", Offset = "0x28B3E70", VA = "0x1828B5270")]
	public int JEDKMMKGLJE([In] ILOKKGKPOAO JKFOBPMCBLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x28B5270", Offset = "0x28B3E70", VA = "0x1828B5270", Slot = "5")]
	private int PPLJFGFKDJI([In] ILOKKGKPOAO JKFOBPMCBLE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class EMLLHCPIAOH : KFAEJHKEPCC
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private class FLIJLBMJIPG
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Guid CPKBEOILJED
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xDDC970", Offset = "0xDDB570", VA = "0x180DDC970")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public long EDHCFGLOOEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int HBPCOPGIIJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xA20E70", Offset = "0xA1FA70", VA = "0x180A20E70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool FIIPFAPBHMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x16E62C0", Offset = "0x16E4EC0", VA = "0x1816E62C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool MBDLPBFBJOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x16E62D0", Offset = "0x16E4ED0", VA = "0x1816E62D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool IHFPDGEHGKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x28B1ED0", Offset = "0x28B0AD0", VA = "0x1828B1ED0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x28B1EF0", Offset = "0x28B0AF0", VA = "0x1828B1EF0")]
		public FLIJLBMJIPG(Guid NOIFDPBHJJB, long CJCDDDPLOLA, int ECNCIMMHGMO, bool GBJOPLFLJOE, bool GAEAMIJPMBJ = false)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly Dictionary<BMAAMMAFHBI<DKJICOCFIKD>, FLIJLBMJIPG> NLPLLOPOKBJ;

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x28ACB10", Offset = "0x28AB710", VA = "0x1828ACB10")]
	public bool JDOCKJINHGA([In] BMAAMMAFHBI<DKJICOCFIKD> MEPFFFGIFGB, [Out] Guid NOIFDPBHJJB, [Out] long CJCDDDPLOLA, [Out] int ECNCIMMHGMO, [Out] bool DBBDBAMJJNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x28ACC20", Offset = "0x28AB820", VA = "0x1828ACC20")]
	public void AHNEDDPKLEJ([In] BMAAMMAFHBI<DKJICOCFIKD> MEPFFFGIFGB, Guid NOIFDPBHJJB, long CJCDDDPLOLA, int ECNCIMMHGMO, bool DBBDBAMJJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x28ACD00", Offset = "0x28AB900", VA = "0x1828ACD00")]
	public void AHNEDDPKLEJ([In] BMAAMMAFHBI<DKJICOCFIKD> MEPFFFGIFGB, Guid NOIFDPBHJJB, long CJCDDDPLOLA, int ECNCIMMHGMO, bool DBBDBAMJJNG, bool GAEAMIJPMBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x28ACDE0", Offset = "0x28AB9E0", VA = "0x1828ACDE0")]
	public void ICGAGHCPLDA([In] BMAAMMAFHBI<DKJICOCFIKD> MEPFFFGIFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x28ACF00", Offset = "0x28ABB00", VA = "0x1828ACF00")]
	public void OKKKPDBDFAB([In] BMAAMMAFHBI<DKJICOCFIKD> MEPFFFGIFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x28ACF60", Offset = "0x28ABB60", VA = "0x1828ACF60")]
	public bool FIIPFAPBHMA([In] BMAAMMAFHBI<DKJICOCFIKD> MEPFFFGIFGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x28ACFF0", Offset = "0x28ABBF0", VA = "0x1828ACFF0")]
	public EMLLHCPIAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x28ACB10", Offset = "0x28AB710", VA = "0x1828ACB10", Slot = "4")]
	private bool ABEEIIMPLAJ([In] BMAAMMAFHBI<DKJICOCFIKD> MEPFFFGIFGB, [Out] Guid NOIFDPBHJJB, [Out] long CJCDDDPLOLA, [Out] int ECNCIMMHGMO, [Out] bool DBBDBAMJJNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x28ACC20", Offset = "0x28AB820", VA = "0x1828ACC20", Slot = "5")]
	private void PFGBBAAOEPC([In] BMAAMMAFHBI<DKJICOCFIKD> MEPFFFGIFGB, Guid NOIFDPBHJJB, long CJCDDDPLOLA, int ECNCIMMHGMO, bool DBBDBAMJJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x28ACDE0", Offset = "0x28AB9E0", VA = "0x1828ACDE0", Slot = "6")]
	private void BLPLIPDALPN([In] BMAAMMAFHBI<DKJICOCFIKD> MEPFFFGIFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x28ACF00", Offset = "0x28ABB00", VA = "0x1828ACF00", Slot = "7")]
	private void DOHBBIBODEA([In] BMAAMMAFHBI<DKJICOCFIKD> MEPFFFGIFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x28ACF60", Offset = "0x28ABB60", VA = "0x1828ACF60", Slot = "8")]
	private bool OGDEBKAGAIP([In] BMAAMMAFHBI<DKJICOCFIKD> MEPFFFGIFGB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public sealed class NHFJAOJKBNG
{
	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x28B3CD0", Offset = "0x28B28D0", VA = "0x1828B3CD0")]
	public static OADMBBILKFN LLIJAGNEDAJ()
	{
		return default(OADMBBILKFN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public sealed class AFMNOCGIJIF : GNDILNGFIBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public delegate bool NBJECJFKGHC();

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public delegate void OIIPLHIAMFF();

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public delegate IReadOnlyList<KeyValuePair<string, PDAOBOECEPN>> LMNPHMPICPC(NCKFOBEFMJN NCCJMLCLELA);

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public delegate IReadOnlyDictionary<Guid, int> CKMNLOEKCKB(NCKFOBEFMJN NCCJMLCLELA);

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public delegate IReadOnlyDictionary<int, Guid> EKDKJFIMPBI(NCKFOBEFMJN NCCJMLCLELA);

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public delegate IReadOnlyList<KeyValuePair<string, PDAOBOECEPN>> FILMKEKDDOP();

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public delegate IReadOnlyDictionary<Guid, int> MLFOGJBABCG();

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate IReadOnlyDictionary<int, Guid> GCNFPCHCMNC();

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public delegate void ECFCLLJBIDG(NCKFOBEFMJN NCCJMLCLELA, Guid CIPEJPOFANF);

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public delegate void GFICGOGLIPN();

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public delegate bool JIBLOIPDMGO();

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public delegate bool HDJHPHIIFHJ();

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public delegate void JDJEFJOAJPB(Guid MLHHKFAICLJ);

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public delegate void MKEINBBOMMN(FDCAFADLMKO IBOHDKHFAJH, LAHNDCHLGIA BCPABHBGHMP);

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public delegate void BCNKIEFPEPH(string DBMKCGLJJHI);

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public delegate Task<bool> GEDGINKLMBN(string? PDAECFLGGBD, string CBLPKFIJGLH);

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public delegate bool PFLLMIGADEO(Guid JKEMADAJHMA, [Out] LAPMIOMNBGJ EDOMCIFIJDF);

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public delegate void MGKJMLJMDDO(IKLALLBKLKC<JHIBINPGGHP> DPIFNPADOBK);

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public delegate Task<MDDPJNIIBBI<BOFEABKGBFC, JHFNBJHGPJG>> LKIAFGKOCEL(Task<MDDPJNIIBBI<BOFEABKGBFC, JHFNBJHGPJG>> NKDMFOKACBI);

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public delegate Task<MDDPJNIIBBI<GOPODMHAJJP, JHFNBJHGPJG>> DGDGBACHOAI(Task<MDDPJNIIBBI<GOPODMHAJJP, JHFNBJHGPJG>> NKDMFOKACBI);

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public delegate Task<MDDPJNIIBBI<IKLALLBKLKC<IEKFJJCDKCC>, JHFNBJHGPJG>> CKDBAKLIPCM(Task<MDDPJNIIBBI<IKLALLBKLKC<IEKFJJCDKCC>, JHFNBJHGPJG>> NKDMFOKACBI);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct AJNCIKAKOGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public AsyncTaskMethodBuilder<MDDPJNIIBBI<BOFEABKGBFC, JHFNBJHGPJG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Task<MDDPJNIIBBI<BOFEABKGBFC, JHFNBJHGPJG>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private TaskAwaiter<MDDPJNIIBBI<BOFEABKGBFC, JHFNBJHGPJG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x28A8020", Offset = "0x28A6C20", VA = "0x1828A8020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x28A82E0", Offset = "0x28A6EE0", VA = "0x1828A82E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct DHDNBALIACI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public AsyncTaskMethodBuilder<MDDPJNIIBBI<GOPODMHAJJP, JHFNBJHGPJG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public Task<MDDPJNIIBBI<GOPODMHAJJP, JHFNBJHGPJG>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private TaskAwaiter<MDDPJNIIBBI<GOPODMHAJJP, JHFNBJHGPJG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x28AC2F0", Offset = "0x28AAEF0", VA = "0x1828AC2F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x28AC5B0", Offset = "0x28AB1B0", VA = "0x1828AC5B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct LKEDELOCMNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public AsyncTaskMethodBuilder<MDDPJNIIBBI<IKLALLBKLKC<IEKFJJCDKCC>, JHFNBJHGPJG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public Task<MDDPJNIIBBI<IKLALLBKLKC<IEKFJJCDKCC>, JHFNBJHGPJG>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private TaskAwaiter<MDDPJNIIBBI<IKLALLBKLKC<IEKFJJCDKCC>, JHFNBJHGPJG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x28B2D50", Offset = "0x28B1950", VA = "0x1828B2D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x28B3010", Offset = "0x28B1C10", VA = "0x1828B3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly Dictionary<string, PDAOBOECEPN> ABLMEOHLECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly Dictionary<int, string> HNHCNMPHKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly List<object> FDDAFJHPPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly List<Guid> LJGPFHJCADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly NBJECJFKGHC AAAJIOJAIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly OIIPLHIAMFF OAMKFECHBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly LMNPHMPICPC NLJOHOKKKOO;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly IReadOnlyDictionary<Guid, int> AGBHINIDKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly CKMNLOEKCKB NEPBIKJKBCK;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly IReadOnlyDictionary<int, Guid> JIFFJEKCMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly EKDKJFIMPBI HDJIFGKLGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly FILMKEKDDOP BJOCNACFEBD;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly IReadOnlyDictionary<Guid, int> CMPDPBHKCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly MLFOGJBABCG FLFAGBEDMED;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly IReadOnlyDictionary<int, Guid> PBEIDOHNOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly GCNFPCHCMNC CEJFCCFPDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly ECFCLLJBIDG BDJIILOEGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly GFICGOGLIPN KAJICAFFMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly JIBLOIPDMGO NGBGCLDFCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly HDJHPHIIFHJ FFOIHMHHJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly Dictionary<string, PDAOBOECEPN> ADNBFFGHAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly JDJEFJOAJPB MOIHAMHKAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly MKEINBBOMMN KEIOHBBJHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly BCNKIEFPEPH OHEFIDNGIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly GEDGINKLMBN FCJCNLDKCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly PFLLMIGADEO MBEAJMKHLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly MGKJMLJMDDO DEFHHNJIJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly LKIAFGKOCEL DAFCOMLFEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly DGDGBACHOAI BNDNOJNODJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly CKDBAKLIPCM EFBLBIDLHCP;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public LNAJKPCBNOD PBOOJNPPBKK
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "4")]
		get
		{
			return default(LNAJKPCBNOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool OCIJMLDEMBB
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xAA8AD0", Offset = "0xAA76D0", VA = "0x180AA8AD0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public IReadOnlyDictionary<int, string> IKNNHOHCLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public IReadOnlyList<object> IFGPPNBECEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA246B0", Offset = "0xA232B0", VA = "0x180A246B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public IReadOnlyList<Guid> MIEHDPPHPNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA21F10", Offset = "0xA20B10", VA = "0x180A21F10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public IReadOnlyDictionary<string, PDAOBOECEPN> FJMJCHMNNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA2BD10", Offset = "0xA2A910", VA = "0x180A2BD10", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public FLOKLJHNNCJ AEMICGAILFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA9A0F0", Offset = "0xA98CF0", VA = "0x180A9A0F0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(FLOKLJHNNCJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool FJIHMIJJNOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA9A120", Offset = "0xA98D20", VA = "0x180A9A120", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool JICJNPLHOHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x1D9D280", Offset = "0x1D9BE80", VA = "0x181D9D280", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool CGJEMIFLIFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x28A5C00", Offset = "0x28A4800", VA = "0x1828A5C00", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x28A66E0", Offset = "0x28A52E0", VA = "0x1828A66E0")]
	public AFMNOCGIJIF([Optional] Dictionary<string, PDAOBOECEPN>? FNKOGHGAKIA, [Optional] Dictionary<int, string>? CHGEFCFGPDE, [Optional] List<object>? BHLOMOFPACC, [Optional] List<Guid>? MNIGEGAFFPB, [Optional] NBJECJFKGHC? CMGBEOFNMMA, [Optional] OIIPLHIAMFF? IMOOKIFKAAD, [Optional] LMNPHMPICPC? BENCCIADHLO, [Optional] CKMNLOEKCKB? KALLJFNMOKE, [Optional] EKDKJFIMPBI? NFLKBLAJKMG, [Optional] FILMKEKDDOP? DNBHKCOAALD, [Optional] MLFOGJBABCG? LCHPGHCMNLO, [Optional] GCNFPCHCMNC? KFDPMMAPFOB, [Optional] ECFCLLJBIDG? NOFKJHLFMGM, [Optional] GFICGOGLIPN? DOINMJMEGOG, [Optional] JIBLOIPDMGO? DMNPCANGPHL, [Optional] HDJHPHIIFHJ? DNCFOLEPMKE, [Optional] Dictionary<string, PDAOBOECEPN>? ADFHKKINFPI, [Optional] JDJEFJOAJPB? CDJAANHPCBF, [Optional] MKEINBBOMMN? PDOOMBDMAIM, [Optional] BCNKIEFPEPH? GKFBPKAJLMH, [Optional] GEDGINKLMBN? MAPGFPOENJE, [Optional] PFLLMIGADEO? LKNGEDAJEMP, [Optional] MGKJMLJMDDO? BNPLKCHKODP, [Optional] LKIAFGKOCEL? PIAOOMLAPHP, [Optional] DGDGBACHOAI? CIPFEPLBONH, [Optional] CKDBAKLIPCM? OLOBPLACDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x28A5CA0", Offset = "0x28A48A0", VA = "0x1828A5CA0", Slot = "9")]
	public bool BJOOCJDLPIK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0")]
	public static bool DALFCEECIDC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x28A6440", Offset = "0x28A5040", VA = "0x1828A6440", Slot = "10")]
	public bool OBNPLGEGMDO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
	public static void ODNNHPEJJPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0xE0EFA0", Offset = "0xE0DBA0", VA = "0x180E0EFA0", Slot = "11")]
	public void MCCDIPBGFAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x28A5C70", Offset = "0x28A4870", VA = "0x1828A5C70")]
	private static IReadOnlyList<KeyValuePair<string, PDAOBOECEPN>> AMAHFKDMNII(NCKFOBEFMJN NCCJMLCLELA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x28A6400", Offset = "0x28A5000", VA = "0x1828A6400", Slot = "12")]
	public IReadOnlyList<KeyValuePair<string, PDAOBOECEPN>> NGDDOICNEAO(NCKFOBEFMJN NCCJMLCLELA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x28A6260", Offset = "0x28A4E60", VA = "0x1828A6260")]
	private static IReadOnlyDictionary<Guid, int> MBBKGFNBCAL(NCKFOBEFMJN NCCJMLCLELA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x28A5E30", Offset = "0x28A4A30", VA = "0x1828A5E30", Slot = "13")]
	public IReadOnlyDictionary<Guid, int> HHJCMOBDLMO(NCKFOBEFMJN NCCJMLCLELA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x28A5E90", Offset = "0x28A4A90", VA = "0x1828A5E90")]
	private static IReadOnlyDictionary<int, Guid> HMKKAFMPBLM(NCKFOBEFMJN NCCJMLCLELA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x28A6000", Offset = "0x28A4C00", VA = "0x1828A6000", Slot = "14")]
	public IReadOnlyDictionary<int, Guid> INGFBLOFELH(NCKFOBEFMJN NCCJMLCLELA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x28A5D60", Offset = "0x28A4960", VA = "0x1828A5D60")]
	private static IReadOnlyList<KeyValuePair<string, PDAOBOECEPN>> BPKMCCKMBCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x289D250", Offset = "0x289BE50", VA = "0x18289D250", Slot = "15")]
	public IReadOnlyList<KeyValuePair<string, PDAOBOECEPN>> FOBLBFPJDKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x28A6470", Offset = "0x28A5070", VA = "0x1828A6470")]
	private static IReadOnlyDictionary<Guid, int> OMNCBGCFHJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x28A5EE0", Offset = "0x28A4AE0", VA = "0x1828A5EE0", Slot = "16")]
	public IReadOnlyDictionary<Guid, int> HOJPEDGJBAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x28A5E60", Offset = "0x28A4A60", VA = "0x1828A5E60", Slot = "17")]
	public IReadOnlyDictionary<int, Guid> HLJONFHDMID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
	private static void BKHLBOENLOL(NCKFOBEFMJN NCCJMLCLELA, Guid CIPEJPOFANF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x28A5DC0", Offset = "0x28A49C0", VA = "0x1828A5DC0", Slot = "18")]
	public void CKIPAAPACIA(NCKFOBEFMJN NCCJMLCLELA, Guid CIPEJPOFANF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
	private static void OLNHEAMIOED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x28A61C0", Offset = "0x28A4DC0", VA = "0x1828A61C0", Slot = "19")]
	public void LBEANBPGJJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0")]
	private static bool JNDEGOBDJLD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x28A5D90", Offset = "0x28A4990", VA = "0x1828A5D90", Slot = "20")]
	public bool CCBFBGAGGBN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0")]
	public static bool DFMMBIFFCAJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x28A5C40", Offset = "0x28A4840", VA = "0x1828A5C40", Slot = "21")]
	public bool ALDKLGGFBLO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x28A5C10", Offset = "0x28A4810", VA = "0x1828A5C10", Slot = "23")]
	public IReadOnlyList<KeyValuePair<string, PDAOBOECEPN>> AKIBDIFCECJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "24")]
	public IReadOnlyDictionary<Guid, int> KDEIOCGHLME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "25")]
	public IReadOnlyDictionary<int, Guid> DLIKIFIDELG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x28A5E00", Offset = "0x28A4A00", VA = "0x1828A5E00", Slot = "26")]
	public IReadOnlyList<KeyValuePair<string, PDAOBOECEPN>> GOPMACEOCPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "27")]
	public IReadOnlyDictionary<Guid, int> OFKPBENLPKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "28")]
	public IReadOnlyDictionary<int, Guid> KBFHENOLADA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
	public static void HHPIAHKGIIO(Guid MLHHKFAICLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x28A6180", Offset = "0x28A4D80", VA = "0x1828A6180", Slot = "29")]
	public void KPBFPDMLDGO(Guid MLHHKFAICLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
	private static void POFGGKCHDHP(FDCAFADLMKO IBOHDKHFAJH, LAHNDCHLGIA BCPABHBGHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x28A63A0", Offset = "0x28A4FA0", VA = "0x1828A63A0", Slot = "34")]
	public void MOJIICFFOHP(FDCAFADLMKO IBOHDKHFAJH, LAHNDCHLGIA BCPABHBGHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
	private static void BBJJNOLKPAB(string DBMKCGLJJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x28A6120", Offset = "0x28A4D20", VA = "0x1828A6120")]
	private static Task<bool> JMLBKAEHEFA(string? PDAECFLGGBD, string CBLPKFIJGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x28A61F0", Offset = "0x28A4DF0", VA = "0x1828A61F0", Slot = "35")]
	public Task<bool> LFCAMKGDHKM(string? PDAECFLGGBD, string CBLPKFIJGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x28A6430", Offset = "0x28A5030", VA = "0x1828A6430")]
	private static bool NOJOHOCMGAM(Guid JKEMADAJHMA, [Out] LAPMIOMNBGJ EDOMCIFIJDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x28A6220", Offset = "0x28A4E20", VA = "0x1828A6220", Slot = "36")]
	public bool LHHEMKAPAJC(Guid JKEMADAJHMA, [Out] LAPMIOMNBGJ EDOMCIFIJDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
	private static void IBFKEAHPPHH(IKLALLBKLKC<JHIBINPGGHP> DPIFNPADOBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x28A63D0", Offset = "0x28A4FD0", VA = "0x1828A63D0", Slot = "37")]
	public void MPKEOONBDHF(IKLALLBKLKC<JHIBINPGGHP> DPIFNPADOBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x28A62B0", Offset = "0x28A4EB0", VA = "0x1828A62B0")]
	[AsyncStateMachine(typeof(AJNCIKAKOGM))]
	private static Task<MDDPJNIIBBI<BOFEABKGBFC, JHFNBJHGPJG>> MNJKKLBODCC(Task<MDDPJNIIBBI<BOFEABKGBFC, JHFNBJHGPJG>> NKDMFOKACBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x28A64C0", Offset = "0x28A50C0", VA = "0x1828A64C0", Slot = "38")]
	public Task<MDDPJNIIBBI<BOFEABKGBFC, JHFNBJHGPJG>> ONCPBAFABHH(Task<MDDPJNIIBBI<BOFEABKGBFC, JHFNBJHGPJG>> NKDMFOKACBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x28A6030", Offset = "0x28A4C30", VA = "0x1828A6030")]
	[AsyncStateMachine(typeof(DHDNBALIACI))]
	private static Task<MDDPJNIIBBI<GOPODMHAJJP, JHFNBJHGPJG>> JDFGGGPHNEE(Task<MDDPJNIIBBI<GOPODMHAJJP, JHFNBJHGPJG>> NKDMFOKACBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x28A6520", Offset = "0x28A5120", VA = "0x1828A6520", Slot = "39")]
	public Task<MDDPJNIIBBI<GOPODMHAJJP, JHFNBJHGPJG>> ONCPBAFABHH(Task<MDDPJNIIBBI<GOPODMHAJJP, JHFNBJHGPJG>> NKDMFOKACBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x28A5F10", Offset = "0x28A4B10", VA = "0x1828A5F10")]
	[AsyncStateMachine(typeof(LKEDELOCMNK))]
	private static Task<MDDPJNIIBBI<IKLALLBKLKC<IEKFJJCDKCC>, JHFNBJHGPJG>> ICHOMCNFKKB(Task<MDDPJNIIBBI<IKLALLBKLKC<IEKFJJCDKCC>, JHFNBJHGPJG>> NKDMFOKACBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x28A64F0", Offset = "0x28A50F0", VA = "0x1828A64F0", Slot = "40")]
	public Task<MDDPJNIIBBI<IKLALLBKLKC<IEKFJJCDKCC>, JHFNBJHGPJG>> ONCPBAFABHH(Task<MDDPJNIIBBI<IKLALLBKLKC<IEKFJJCDKCC>, JHFNBJHGPJG>> NKDMFOKACBI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public sealed class EPJHIBAPADA : NEKJIHNNMDJ
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public delegate CMFEBAIAIDJ<BOFEABKGBFC> CIICOBGGECD(CMLIDFCPMDK FCEJBDLGOKN, object DOLEDGPOAIC, LNCBCDGMIHI ECOCHAPIFKN, IReadOnlyList<PCMODOINFKB> OJDJFNBAEAO, IList<PCMODOINFKB> CNPHJDDGEBH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private BGEFCGNBPGH? INMDDBEOJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly BGEFCGNBPGH FIHPGLPJCLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly BGEFCGNBPGH GGCFKGEIIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private BGEFCGNBPGH? LKOPBCOLLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private CIICOBGGECD? APKAJFJNHGG;

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "4")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FBEAENGNIKK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "5")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MIEKEAJLKFF(AEBFKJBNKDA FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0")]
	private static CMFEBAIAIDJ<BOFEABKGBFC> DIACPKGMELN(CMLIDFCPMDK NGGJJFKLDLG, MFBOGBHLIDC PKOMJIEMMCE)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "6")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MBCFGFBHGPO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "7")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BCCEPKMOJGG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "8")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LDLKBFAOELC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "9")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HAHGMCHFPGN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "10")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ADFDNKNNAAE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "11")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ELCIPCDPCBE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "12")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GFODELPENIO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "13")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LKGMELNNPCB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "14")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LONMBOCHJJK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "15")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CDPEAOFBEMD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "16")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DNHFGNCAHIG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "17")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IICMNAOIHLD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "18")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GCBJNOIIGJL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "19")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LEPKFHJAJKO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "20")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NAAKOGGFPAE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "21")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LGPMHMPDGII(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "22")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DONGPMMAOBA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "23")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BBAKEEIGLEN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "24")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FIFEDJGLOCO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "25")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GOJKKOLAOOI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "26")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MFJMHFEJBBK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "27")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BICFAENIDLG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "28")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HFMLHJBEPDH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "29")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KADFFJOGMMO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "30")]
	public CMFEBAIAIDJ<BOFEABKGBFC> AKHDCMPIGBB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "31")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JHIEJFKPPIG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "32")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BPGFKIADBNC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "33")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BFNNMLGIJJO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "34")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BHFMBDPKOEN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "35")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OENODBJFFOM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "36")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BMIIOKPLIPD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "37")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GFGHBDMPILO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "38")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BEIJDOBGHCB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "39")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DDLOAGAGANM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "40")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BCFNGLELNJF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "41")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DPGAKEPPPDL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "42")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DCGJMNBCBOM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "43")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CLJOLCGDHLJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "44")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HAIIJJAJLBH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "45")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LDGAMNDBOAM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "46")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KHPHGPPAEID(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "47")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HANDIFIKGON(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "48")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EBFDJMIGBKJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "49")]
	public CMFEBAIAIDJ<BOFEABKGBFC> AOMJAEAKDGM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "50")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HCDDOHNPINN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "51")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BJOFPCGFNDN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "52")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NKCMEKGHAED(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "53")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NJJMMHLLBMF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "54")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IPDCHOPIEPC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "55")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CJIJPKPMMAC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "56")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BNMMOKENDLB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "57")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PEMGPGFDHAL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "58")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IOEIPACEJBF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "59")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ILOHHMIBJJM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "60")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BGLOFFNEPNK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "61")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IBPPBJFHKDI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "62")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BIHHBGHNPEJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "63")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KHBHPMEPEJL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "64")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PNPJKECFPHA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "65")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MLHDAJOEHJC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "66")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NBNNNDHAOLH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "67")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> OBBBEDNBNIM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "68")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> ADIPKCEOEEL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "69")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> OLFNKEDGHDL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "70")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> HKOHEEEMLDC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "71")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> LLHEDGEAKAB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "72")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> BNMHPCEJGIE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "73")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MONJJCMFLIK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "74")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MKOGIPFODMN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "75")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GBAFEONNDII(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "76")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ENEDOKIGBAN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "77")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> CIGLOFDKCCK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "78")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> DCKOLEABIOC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "79")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KDOHCGGBOCB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "80")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OHFLKBCJKNE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "81")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> KEKBMDCEFHP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "82")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CEOLKJKHNCK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "83")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JLFBKGCLIFP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "84")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DMAMKFPIFIH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "85")]
	public CMFEBAIAIDJ<BOFEABKGBFC> AOMOFJOOAIA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "86")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DKLDGDDNODH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "87")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EBKDELNHPHK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "88")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LJEOKFOINMI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "89")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OBLBLKEGBDA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "91")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FPHJDNHBJCH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "92")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CIFKLBMCPGM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "93")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FDFAMELMPDD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "94")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GKMDKLHFNGJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "95")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MAOPCEGCKJF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "96")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OPGCOIDAJHE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "97")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NOKDKACHDOJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "98")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DJDJLGAGPDC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "99")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PPBHHHBBDDH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "100")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FKNIAHNIEMP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "101")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BGGDLMEMFLF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "102")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LEJBLKEMPNB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "103")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PECNBHBLMKF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "104")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GEBHPHCDFBB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "105")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MDDDACJEGBC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "106")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IIIFHBEFGHD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "107")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KNLIAIKLPFP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "108")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LHBFLCDBBJG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "109")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IINCNLOOPOC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "110")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BEIIBHHOLGH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "111")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BFOHLPLCCMG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "112")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HIJNAFPKLJM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "113")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BCHPKOBAEPA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "114")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DKPHMIOMPFL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, Guid EGLPIFKMHOI)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "115")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GBBODFOOPOC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "116")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KEMEDOCCDIF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "117")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GADHEMKMMOH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "118")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KIPAECHJFFN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "119")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KCCEBCIJHCN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "120")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MCFEGAHMIOO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "121")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JHBNOLDLEDP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "122")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LHABAJACOCN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "123")]
	public CMFEBAIAIDJ<BOFEABKGBFC> COCKCJOODFH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "124")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IJCJBEAJOFE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "125")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HJPGAMLMEPL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "126")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IOCFANHDMGB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "127")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GEKPGKBGGFM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "128")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DBMHPIIFKKJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "129")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BPBKONJLECN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "130")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OONLKJBLEMK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "131")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EIFMPPEMPAG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "132")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LAIBDHFPMJE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "133")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NBPJMOGOPNI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "134")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BHLJMNIIMLC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "135")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CKJANLEIPNM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "136")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NAIKKIGBJFH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "137")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NAJOHNPEOIA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "138")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LBPJLPDOIML(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "139")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ODMNEEOGOLE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "140")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KLENEPJPAAI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "149")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FDDJPOEGPAE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "150")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EHAAPAPJPAE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "151")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HGICCHLBCNO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "152")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OJGFFEFFAPF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "153")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PNCIMJIEEJA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "154")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LMELDNIBCHJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "155")]
	public CMFEBAIAIDJ<BOFEABKGBFC> AFOFGCNJBJO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "156")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DHDEOFMGFFP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "157")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IACPMKAFGFP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "158")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NHNHJPMBCPA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "159")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KPOHKABGPKM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "160")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KAGIFEDDEPG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "161")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KMKIBBBBLPJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "162")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DAACKMIPJJL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "163")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DACCDODGHCM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "164")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NAMKDJLENHO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "165")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EFMPLIMIMFE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "166")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KIHAKFHHBMD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "167")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EMBPDCHMCHN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "168")]
	public CMFEBAIAIDJ<BOFEABKGBFC> AHLGCLJAEIG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "169")]
	public CMFEBAIAIDJ<BOFEABKGBFC> AFBAMOFFCGH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "170")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ECMDEKCKJME(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "171")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BMFDONJBAKC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "172")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NNCFBFJPFGN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "173")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DKIJLIIENNE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "174")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IALLEFLHIKH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "175")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PHGCFGGEFAK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "176")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DACNMGHCJOL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "177")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NJHBPNJAENJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "178")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JKOBKMPPCFJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "179")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BHEDLICKPLP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "180")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HCFNHPCOLDE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "181")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HEOKNEHPDDF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "182")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FOCAILAJOCP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "183")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KINHLPFBFKK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "184")]
	public CMFEBAIAIDJ<BOFEABKGBFC> COPOAEJOFFP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "185")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JPAFGEHPEIL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "186")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NALAAABEOPA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "187")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LFGAPNGNFOL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "188")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OJLIIDONBKB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "189")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MKCLKIJIIGG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "190")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FELPPNDAOPM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "191")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EMJPPHGMMDN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "192")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LNDPIDJJLKD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "193")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KHPPIOJNEJK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "194")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NMEGKNKPMIF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "195")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DEILPHFDPEH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "196")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PDAOPLHOEDG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "197")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GFJGPLGAGCD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "198")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IAKGGMNKGLC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "199")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IIOJIIFJAHL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "200")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GDJGKEAGAJJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "201")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PPCBELMBENK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "202")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OGHDIGIHANA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "203")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FLNEGIBCAPL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "204")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FOCPMOJGKKJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "205")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MFEPDLAHOKH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "231")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NAMHKGBJNOJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "232")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DAEBJPBBBDE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "233")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HONOEPLPONO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "234")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NPOFMMPFJEP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "235")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NOJKPCGKKLM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "236")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HMKBIPBKCKD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "237")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ANHFJIMJFMI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "238")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MIMHBGOCIFM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "239")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EMOHFOHGKFK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "240")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MLONMFGLECC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "241")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GOODEECIFNI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "242")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JMPOENNAFPB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "245")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HFPJHNCMACC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "243")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MDHEEFKFKPG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "244")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KMBBJHIPJKJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "246")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IONPJONALOJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "247")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ELCMLPOCEFC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "248")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IHCPAIHFKEJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "249")]
	public CMFEBAIAIDJ<BOFEABKGBFC> AOCJIJOLLEF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "265")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NLEGNMDCGGD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "287")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DGDDKHDPFKM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "289")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PMGIKFDPANG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "274")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ALOCOKBGDFC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "275")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FCICFFABLLL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "266")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MKINLINIGGA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "291")]
	public CMFEBAIAIDJ<BOFEABKGBFC> AJMFCGGMBGM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "280")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PFNIOMPIFFI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "281")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EJGDDIKAAAJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "257")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NPDEDABDKDB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "258")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FCGFGMAJDIN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "260")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HMDGLFGAPOO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "267")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NMLJFGIPHNJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "268")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EIBCEMHOMGO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "255")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KIBHELKKJFL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "261")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JMMADFDGJFD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "276")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ENLJICEJMDA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "277")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GEJCADMIFEC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "252")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IBHNHJMFCJJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "251")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CNELBJHEHGO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "254")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IBBHMKFLLFD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "262")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NGDLJBOAEOC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "263")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OHKGELDDLMG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "264")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LJKFCMDKGAC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "278")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JGLJNKINGBN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "282")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GACCPJCEPFD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "283")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CGBJHFFPNGG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "284")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OIEGCEEAJNP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "285")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OCDHLOKGMDI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "286")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KBINMKJGPOD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "288")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GPHHAGFLEJB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "290")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BGNNEFLGHGB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "250")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LMDMAJBCKOD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "269")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FLIJCCOBDMH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "270")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HACHANNPLMI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "271")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JDDLIJCIFFC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "272")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MDALMFNEINB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "259")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KMFPIOLOAJD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "273")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EKBBPEEBBBN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "256")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GKJOLBLEGMN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "253")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GDJAMGGMOBL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "279")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FNODPBHFGIK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "292")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KLJKPDOAFAC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "293")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GMBGODKFCMA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "294")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CKMABACNEKI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "295")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MJEGCNNPCCL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "296")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JIENOEHNCEF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "297")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FLAMFMJGACC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "298")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BCOMMGLEEBI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "299")]
	public CMFEBAIAIDJ<BOFEABKGBFC> APHKMFCEGNH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "300")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IIEGHAPCLAC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "301")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PIEHEGLABJE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "303")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PMJFHPBHKPO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "304")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PCGKPABNGPA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "305")]
	public CMFEBAIAIDJ<BOFEABKGBFC> APAEODFGKAP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "307")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MAAIFAPMBPC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "306")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ENLIKNEJCKF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "315")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OGFJKFMAHGE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "316")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MBNCJIBINGP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "317")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ELOLBPOBIAE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "318")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PDPDGHPNNFM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "319")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LACOHDOOEFD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "321")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EODEDMKFALG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "327")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NHEKPPOLOCG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "328")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FJLEJBOIOEF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "331")]
	public CMFEBAIAIDJ<BOFEABKGBFC> AHOCNCNEAHN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "335")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LNFDENNAPPG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "336")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CLJAGPFODJF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "337")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KFALGMJCLAH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "338")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PNNBJAPAJEF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "339")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KICJGOCAJDD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "340")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FKFLEDFJOBN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "341")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PJGJDKMCCLO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "342")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LONKMBGBIEL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "343")]
	public CMFEBAIAIDJ<BOFEABKGBFC> AJKKKABELMB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "344")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CPNAMNAHCHE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "333")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IEGMHOFOLOL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "334")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PAOFKPIFFOF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "310")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HEBCNMLKICG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "311")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GNPOKEOOFKN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "313")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MBAFJCPPHAJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "320")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DDENIADKALO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "308")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OOFENCELKNB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "314")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NKKFIJKBGMJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "329")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BEMIKGPJPHI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "330")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HDAJMGBFIKE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "302")]
	public CMFEBAIAIDJ<BOFEABKGBFC> INCNLJBMCFK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "322")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LLDLNABHJLB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "323")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DHKCAOMLFEF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "324")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GFNFACDIGFO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "325")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NLLGIIAABOC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "312")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LCLPNLMCDIB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "326")]
	public CMFEBAIAIDJ<BOFEABKGBFC> AFABAOJKBJJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "309")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KOBKMELGBFK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "345")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OJINNHPMHII(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "332")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KGHBPBDKPJI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "346")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EDJPLABAKMD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "347")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HCMINPOKFDF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "348")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LGOJFNCHGGN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "349")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HHPPKFKBCCK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "350")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> GGDBEEHJDGG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "351")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CGOMJMILMAF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "352")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MGNMHFPGLNL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "353")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EOEMHBKCLDH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "354")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> MPAOMDMNKOC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "355")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> DPOBGGBLJMK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "356")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> PDHIGILDMIF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "357")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> IOENFPPKDJN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "358")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> PIGHKBCGCME(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "359")]
	public CMFEBAIAIDJ<OPOIHPPPKPE.ABMDDJLBBNG> ANEEHHMOCNN(CMLIDFCPMDK FCEJBDLGOKN, PCMODOINFKB HCPGBELMLAH)
	{
		return default(CMFEBAIAIDJ<OPOIHPPPKPE.ABMDDJLBBNG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "360")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HFGFLLIOOIM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "361")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CGEBOIHJHHJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "362")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EJDLDCEMBID(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "363")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KONJMBKGELD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "364")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IPFKPPMHHGN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "365")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HMFEADLHCKP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "366")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BMOOBHAKMBM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "367")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FLLHBJDHAIE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "368")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FFOLLEOBNHI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "369")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OFGFFIMHICG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "370")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GLJDGKDNJKH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "371")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ICOCHBJOPDO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "372")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DBGCHICCKPN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, int FJMCIOHOHLJ)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "373")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> ICDEPLFBFGM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "374")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> JKDHAEJAPON(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "375")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> DMGEMBJBMGM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "376")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KECNBCJNCEF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "377")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IPEMCPACHKC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "378")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> PDEJLPJNILD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "379")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FHCEBGJLMNA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "142")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FNFEOGIMPMK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "383")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CBEHAJDHNFC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "380")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EELJPPEDEOO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "381")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LCLFDBGJDLJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "382")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PBDDEBLPOFM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "384")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CHCAMLFGCCK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "385")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PKNJJLEOODH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "386")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LJFHFPOMMDC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "387")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GKNPPOHMIEL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "388")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NNLCBCDIOMH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "389")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CADNACOKADK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "390")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DDMOCJFNJFB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "391")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KEAOEHDLFBM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "392")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OKFNCPOIEGK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "393")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GOBMMNLEDGO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "394")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CHHJMDBECPD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "395")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ECBJBABPFPE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "396")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BIOMFJCNELG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "397")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IFGNPBKLNNE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "398")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GNGNJHLEEFD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "399")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BHEOMNJILHN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "400")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FBKHIOONMIC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "401")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NHMNJDPMBIP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "402")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FNBLIAOJEGM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "403")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PABKEICOODJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "404")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PJGPKEDNJNC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "405")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PIPEPHCPACJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "406")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MFEHAOBLLNN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "407")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PMIICGGLDCO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "408")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GONNCEKHPHI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "409")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EBOJGGLNEIB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "414")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FIFEBKAIABP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "415")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KLKJKGPAMBB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "416")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EMGBJJDKAPB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "417")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GGKHHKEIFLD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "418")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CMCEKOJDNJJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "419")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IEFGCONIDGG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "410")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ANDAKCNDDBP(CMLIDFCPMDK DCPGIMGFLCF, MFBOGBHLIDC KAIJGNPPCEK, int BBNNAJMAFJM)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "411")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> CPDJACGNHFD(CMLIDFCPMDK DCPGIMGFLCF, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "412")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HIIJJNDKNPK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "413")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PAGBALMHLMI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "420")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ANMPHAJLCDA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "421")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ENCCOJDNOLD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "422")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LLLMKGPEIPE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "423")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CEPGHFDBIEL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "424")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MAJMJKLBDEC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "425")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OBMKKAJKNPN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "426")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HPPCKJGGNMP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "427")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BODPHBHILCG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "428")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BLGPFNMDOFN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "429")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KPCJBBKKNKC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "430")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DDLEDAMFCFG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "431")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GCKEBEDMAKE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "432")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HEFPIMHCBPG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "433")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ONDKEGMPIKB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "434")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BFOMGJIFDAC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "435")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CHKIKOMHLCB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "436")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PKHJGJPHHBH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "437")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FJJICCPEGNO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "438")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BHDGDCCMMHC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "439")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OINOADILIJE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x28AD840", Offset = "0x28AC440", VA = "0x1828AD840", Slot = "440")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FFCAGBIKAJN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "441")]
	public CMFEBAIAIDJ<BOFEABKGBFC> AFMAANKBANL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "442")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LAOINGGAAAM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "443")]
	public CMFEBAIAIDJ<BOFEABKGBFC> AEKBBEDHOOL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "444")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DOLNBLKLBKG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "445")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EGKPKLOCFGM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "446")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IKCAAKKKBHJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "447")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HPLBCPBDFNI(AEBFKJBNKDA FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "448")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GDNIAEGNAIG(AEBFKJBNKDA FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "449")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IJPMIJAJDCK(AEBFKJBNKDA FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "450")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BFPLOLFALFN(AEBFKJBNKDA FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "451")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ELDLACMOADH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "452")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OFNPOKLOIFL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "453")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FAMCCMMMAEG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, int GCKOLKABAJC, float HBPMOBMIPIK, float HHPEMNBBGFI)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "454")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> GBEAMEGLAMD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "455")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> NHCLBCBDBFI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "456")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HHFMMGDBJJD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, int OONLMABHAHN, float FAKNEPAHFGE, float JEOPCPCOBCC, float EGDCKNGPOFI, float PLHHLPGJOJK, int DELEJMDDACF, float IHMDIMBPFMC, float FIMHPJCHCKI, float BOMJJGILOJC, bool FCMBONLPMBO)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "457")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> GCGCPHOCBGG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "458")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> AGFPHMDMPLB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "459")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LNJKFEFPOIB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, IReadOnlyList<BEFMLDEACEG.LEIAMBBDIJP> GDADHFOGLBM)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "460")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> PCAPIKDKCGG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "461")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> DEKMCPLGKKN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "462")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MOBKPBMBBNN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, int CDGOJOEAJPM, int KGEFKFJNDJH, int DIELPOPFNME, int GPNHCJFLOJJ, int OPFAHKEJCBN, float HGOCHAGNKGA, float KAFCOFLGJPK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "463")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> AHHINBKDGIP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "464")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> PBDJNPCNGIF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "465")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MPLJFLICOBI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "466")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FDLDOJGMCOG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "467")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DBNDOLDJKLM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "468")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LFNFIGHDBCH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "469")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EPGCOAOHFKE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "470")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IPIBNPMHKAN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x28AD9A0", Offset = "0x28AC5A0", VA = "0x1828AD9A0", Slot = "471")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PNCBOHOKKCO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "472")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IONGOLPMFNJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x28AD960", Offset = "0x28AC560", VA = "0x1828AD960", Slot = "474")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PAGHJPJOEKF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "473")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OPIKHFJPNFA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "475")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DFFGGALHNAD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "476")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LPAKKBCKHOL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "477")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DONLOKNPCHG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "478")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EOCGAGBCBND(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "479")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MEALGBDLAOB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "480")]
	public CMFEBAIAIDJ<BOFEABKGBFC> AJGNKJKJDEO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "481")]
	public CMFEBAIAIDJ<BOFEABKGBFC> AHOANJCEAMJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "482")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GFEJLAGHKCN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "483")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IEENECBNDIJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "484")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LPAFKMFAGDG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "485")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NBDIIBMEHDL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "486")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HNGGGJAALOE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "487")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NBHPBLJGLMP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "488")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KPEPOJGCFDL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "489")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DBKHPENBDAK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "490")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DCHGFFLMPHB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "491")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JMHPGEDNIAB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "492")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OPINDOKGHNG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "493")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BIOLLLDLEND(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "494")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KOJPBEOIMGL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "495")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GEBINNGGBII(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "496")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DKDMFBHAJOE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "497")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JCHOKDLDHAH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "498")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NOPAAPHNCPP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "499")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NNPKJBFMDJL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "500")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LABPLMFBMNO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "501")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BLIPBCGAJAN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "502")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EEILKIHNCJC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "503")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PBIBOCEMPCE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "504")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DPMMLFCPJCB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "505")]
	public CMFEBAIAIDJ<BOFEABKGBFC> AEEEJJNHBOL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "506")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HFDKIBGFFPI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "507")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HMMEGDKIEKC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "508")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EKKAJBBILNP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "509")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DLPJOOAOGHP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "510")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MFKGBCGLGGB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "511")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NIKGECBPEGK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "512")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ABACPMAOPID(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "513")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IBJAJCBJKAF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "514")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NLDOGCLKIMJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "515")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JPHIPKKGJJB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "516")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HKJMIGEDDBM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "517")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PELMKLMBEEP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "518")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KMEOIHHFPIO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "519")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JKOMEBKPIKK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "520")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GDJJDGENMPP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "521")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BHIFIDKPCKL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "522")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CNDONEPBMAH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "523")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DDCHPECDAKP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "524")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ACMBALFHBDI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "525")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MJPNANIODED(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "526")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CIGACDDOBAH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "527")]
	public CMFEBAIAIDJ<BOFEABKGBFC> POHEHACCHJJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "528")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DEAHDNKGIFD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "529")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LBFIEGDOKNL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "530")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FLKNOKDPOIP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "531")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KNIPGMPLMBF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "532")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FFECEOHINAD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "533")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ANBJJGDMPJG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "534")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OFNGEJCEIAL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "535")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BOJNMNPFIOI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "536")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ENHNJCINGJB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "537")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JHNFJAHGMKJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "538")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OKLJPHGPFNJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "539")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NGEHGHEPGOM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "540")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DCAJMILDPLI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "541")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CBCNJDKINIA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "542")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NFKMIECHDCB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "543")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IBNJLKCFDAO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "544")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NLBGOPAGKFG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "545")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NPNFJHEAPJI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "546")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BECKNGLCPMJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "547")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BEBCJLIPCPH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "548")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CAFDHNCKEEB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "549")]
	public CMFEBAIAIDJ<BOFEABKGBFC> INBNBIBKMLE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "550")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NECEKLBCIJD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "551")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EHJBKACPIME(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "552")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JCNILPBMLEI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "553")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KLGMMPOLDDL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "554")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GNPAFPDFDJC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "555")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DABDEEJCFFD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "556")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GBPEEMBIGKA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "557")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BPOIKACKEBC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "558")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MOLOBEMFLMI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "559")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BOJGDNDAINH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "560")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HLEDAFDENMD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "561")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EGNCHOLONMB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "562")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DJHCEOHOENJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "563")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EPBJKAMHCAI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "564")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JKMMNANGKBE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "565")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ELACNOBFCMM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "566")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OEPMNMBLIIL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "567")]
	public CMFEBAIAIDJ<BOFEABKGBFC> AKBANLGFCDF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "568")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FBKINHCFKFD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "569")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PGOMPBOFPMG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "570")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EKNEPHJKBHE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "571")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HGNGADJBKBE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "572")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GNHGOEMOKKD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "573")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PBAPBEOCKJF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "574")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KDGFPIBLDFD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "575")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HMAMFGCPHNN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "576")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FLEBFCNACJD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "577")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BOEGMMIKOEP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "578")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NCIJBELGJJH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "579")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NEAHOJLGGMH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "580")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MJMHNIBONAM(AEBFKJBNKDA FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "581")]
	public CMFEBAIAIDJ<BOFEABKGBFC> AIPGMNHJOIM(AEBFKJBNKDA FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "582")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CEEDPBKHHGK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "583")]
	public CMFEBAIAIDJ<BOFEABKGBFC> AEBNIMGHDLF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "584")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EHGDFDHCICP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "585")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OEHNAMKPOAF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "586")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LLDOIBFPGJC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "587")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KHNKGCGAKBA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "588")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KIDDHDIBAGO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "589")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EEBBCOBHCNF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "590")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HPBKCKOOAFN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "591")]
	public CMFEBAIAIDJ<BOFEABKGBFC> AEAEFAKCCNM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "592")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KEAFJDGBAPG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "593")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GKEPLLNDOBE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "594")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FMKHLCDBABC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "595")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BKCJKJDDEJO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "596")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FEKGPNKLLOI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "597")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JOJMMAAGMDN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "599")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IENLJAKHKPM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "598")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BFCOCEFFLED(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "600")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PDEFLAHAHFC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "601")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DCGDGDPDLKO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "602")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CAINECHILLB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "603")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ODDPALCEFMJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "604")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HCIAKFFCIGN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "605")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HJHHHDCDCAD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "606")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BJNOPBKJLLE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "607")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JMCEOLIKGHC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "608")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MDPMJGHLDDC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "609")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BLLMIGCOALL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "610")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OAGBLFHPPMB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "611")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OOLNPPBCCFI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "612")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IAHNFOGFPHP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "613")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OPOOBCIKJGB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "638")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FCBAOJLMHKC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "643")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LFNKKBMJMJP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, int MHOCIOAAIJE)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "629")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NEDKFIKAGNH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "630")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ABGOCBCDDOI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "631")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ODNIOIEBPPI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "632")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FKKBPDIPGBM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "633")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IDDLNOLACLL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "634")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MHIFHEPHAIL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "635")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CDFLBPAECJL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "636")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NBHNDIMCGMP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "637")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IEJBJBAHKLE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "614")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HDKOCLNAHOJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "615")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LMNOOLCDHGC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "616")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LFAGMABAINF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "617")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FLADKFFHEPO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "618")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KFBGLLDBFLA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "619")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HMDBEOMPHHO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "620")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IMOLMDEPDLJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "621")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GNCFGOPHCBF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "622")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KKBHPJGBLEP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "623")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ABIHJDHEICM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "624")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JOJMHCMHGDI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "625")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FGAODCMJLJD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "626")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BIDLJGOIOMP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "627")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ILOFDGHBHNK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "628")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GEPIBEKBHGP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "639")]
	public CMFEBAIAIDJ<BOFEABKGBFC> APOCFJLLNFO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "640")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FGDKDEJCBKK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "700")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HGHHOIHCIJH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "701")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> OOMOGOCLANJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "702")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> AKCOBMEHLDG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "644")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LHIFFLNGMCG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "645")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GPDNHJHIMMM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "646")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GCMPCJCCHFN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "647")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EOKCBLBFHDI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "648")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IMGHILBJNMJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "649")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FKEPLFGFLIG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "650")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OLIKKMHMGLB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "651")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HFOKLJEBLCB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "652")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ALFFAJPCLPC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "653")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NOHFKMJGMMC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "654")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CNJAAKDALIL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "655")]
	public CMFEBAIAIDJ<BOFEABKGBFC> AMIFKBIODPF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "656")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OEJHNLLIGOA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "657")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OCKCOBGFKPP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "658")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CGEJFOCGIBH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "659")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BBIBLPJLDGD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "660")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KLPBLLNPKII(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "661")]
	public CMFEBAIAIDJ<BOFEABKGBFC> COOIKPHDHNC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "662")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KGAEOIAELJO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "663")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OBBJENNOOPL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "664")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EEJELMADNHL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "665")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PJHJPCPJJCM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "666")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HFKMIHMNDBA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "667")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HCIPOJNJMKB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "668")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KAHEGPHGNHJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "669")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BJOBAPGDGJP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "670")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NNNOOPIJOCP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "671")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FAAMNKHLCOM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "672")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OHLAPOMLEGN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "673")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JABBHBJGMDE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "675")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PNBONGAJCMO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "674")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OGAMJKACOLJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "676")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KPBBDNFKHBH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "677")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PABBJFAPJPM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "678")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FEMAJCPBBMF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "679")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DPNNEEBIEPP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "680")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GLNIMDPLGFN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "681")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MDCCDGCKMJD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "682")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EHHNCPLEFKO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "683")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NKMOJOELJFE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "684")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EHNJIJIGACD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "685")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MCFHCFPIPDC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "686")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LACNHPAKJBL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "687")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IPAPNILLCJD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "688")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OENHDFNPFGA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "689")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JKPEFHGHPGI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "690")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CHFLKHNIIOL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "691")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KHPJKBPIGKG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "692")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FIPBGCGGGPO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "693")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CNLMINEOMHC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "694")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OELLAAFMFLK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "695")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DKBPDDFOBPB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "696")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IAHILJOEJON(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "697")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PIGIKCPGEEI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "698")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MNCNAPFMILD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "699")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NOBPHDLCMME(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "703")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GBPHIIPJEAB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "704")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OGCAKOCMIIE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "705")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OCEDIHEMCLH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "706")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GJBGNAKMHPN(AEBFKJBNKDA FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "707")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OGCGOCMMHEE(AEBFKJBNKDA FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "708")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GLIBINMHHAC(AEBFKJBNKDA FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "709")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GJKFEHAEOFG(CMLIDFCPMDK GENEOILCCHM, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "710")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CNGAJINNBEE(AEBFKJBNKDA FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "711")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KNALNPILBKE(AEBFKJBNKDA FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "712")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LANPPBINFKM(AEBFKJBNKDA FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "713")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KNHEDHGIBNP(AEBFKJBNKDA FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "714")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HJOLJGBCLLA(AEBFKJBNKDA FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "641")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DBPMKIPGEFH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "642")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NGDCOPADHPK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "715")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> AJCHPBCDLEC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "716")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> EMMLBEGKJNB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "717")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LPLOBLKIFPK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "718")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PCELNBJLNJC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "719")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OCLHJEOOLDP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "720")]
	public CMFEBAIAIDJ<BOFEABKGBFC> AGOEEDFDDBI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "721")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CIMEOICPNHN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "722")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PDLPPJFJHGO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "723")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PIMMDILOANP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "724")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MGELCAKLMGL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "725")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NINACNNEMBC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "726")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JLFHEFNGJMP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "727")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JAEAHCJGGGM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "728")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BGOCFIAALJI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "729")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EPOIBDMLMGK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "730")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OHGOMPNJBHP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "731")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JLBKBHNHMGD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "732")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BODGEINIBEC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "733")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LABNMDFCGPP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "734")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HEACKCGIAPP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "735")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BJLKFMBHDGM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "736")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PGMOGDPLKBI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "737")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HKIIIHGDOOL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "738")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HGKPFOJNCLE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "739")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HDFBAKKMPGI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "740")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KBKAFEDDJAE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "741")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JLPDMEKIDOG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "742")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LHDNCGIECLA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "743")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JKFCFGAAOJC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "744")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CAAMEFEILNP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "745")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BFOKBDALGIK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "746")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LIEPABBJEGM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "747")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BIGBPIPOIDH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "748")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LACABKMBFHB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "749")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FJJPKLNBGBN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "750")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EOLAJCFLOEH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "751")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ICEJDPPPKCJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "752")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JBMEDDEPBCM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "753")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FGJNIGKMEGE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "754")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JBNJPDIAIKO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "755")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BNLPMMJCBCM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "756")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FKEAIHCMOEL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "757")]
	public CMFEBAIAIDJ<BOFEABKGBFC> AOCIAEPKDDM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "758")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> GHOFOFBAKCP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "759")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LADMMJDGKFN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "760")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GMKPCAAHICD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "761")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EONCGIMANEI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "762")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CJPLMMLIBLL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "763")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CIBILMKAPOD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "764")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LILFHDHJJBD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "765")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JPMFFBEAPFB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "766")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JPDMFHODELJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "767")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FHKBCNLHMCO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, Guid IBPCMBOEOAB)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "768")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> FJAJJHLCPDD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, bool MCJBOOBGDOA)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "90")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CDBNBCDBODK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "769")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KBIAKENKCON(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "770")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BIOIFPNMGGG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "771")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BGEOADHGOLD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, Guid HDJKDFCLHMO)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "772")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> GOAAIFKHHPE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, bool MCJBOOBGDOA)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "773")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NODPIDGNMPJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "774")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JJHMDCHEGHE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, Guid EGJDBDAPIIL)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "775")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> HHPGDIIOFKL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "776")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> BKKNIIKKGMB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, bool MCJBOOBGDOA)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "777")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FOBOFBFNGBJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "778")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MAPMIHGMFOG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, Guid BANFMMDGGNI)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "779")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> EBLJLHMMGJM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, bool MCJBOOBGDOA)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "780")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> EKJLKNPMJGC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, bool MCJBOOBGDOA)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "781")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NIAOOAOGNMF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "782")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> INBPNCECKKH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "783")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> PCLOJMNEBFN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "784")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MCNEBDFLLIN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "785")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PBCHICDCBGP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "786")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OILIJLBJFHG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "787")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JPMGEBKKDFM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "788")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OLPCNCDCFMN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "789")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KNINPEPIHBJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, Guid MLCFFELIEFF)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "790")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HBFBKKNGEPN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "791")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> CDMLNPBMPFF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "792")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PLPNMAMDMMO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "793")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ENBJJFCNPDA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "794")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BMDLLCPGLHP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, Guid IKCKOHNJLLN)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "795")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> HBBCBKEKKOA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, Guid IKCKOHNJLLN, bool MCJBOOBGDOA)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "796")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> HBBCBKEKKOA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, bool MCJBOOBGDOA)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "797")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> AILKPLFNPGA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, Guid IKCKOHNJLLN, bool MCJBOOBGDOA)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "798")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> AILKPLFNPGA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, bool MCJBOOBGDOA)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "799")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OJDAJPBOLBM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "800")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JJIOOMFIJNC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "801")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MEEAMGNMPLN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "802")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LIDBIJLHJFC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "803")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OMGKMPJLLNF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "804")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PBBGNCIAOFL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "805")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> KHIFPDKHAEM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "806")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> ICNNKGNOCPG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "807")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> OBGJKKGDJKJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "808")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JABNKFNCHBJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "809")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PAJCBCBBOAJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "810")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HMDNIMGLGNK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "812")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JEAFPOHIMMA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "811")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MNBLOOHFPOK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "813")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HDDJFCBOEJD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "815")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LCOBIDBNDJJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "814")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PPHAJPCMNBL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "816")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FKBIJPCNCJB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "817")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NIDEOOJBMKB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "818")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LCAIBPPLFBK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "819")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FELBIPGGGAI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "820")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IKJHIBJFFGA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "821")]
	public CMFEBAIAIDJ<BOFEABKGBFC> AELDHKDJAEJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "822")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JAAGOACANHK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "823")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FFHBCBBAOCA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "824")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LLINFGAPCCK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "825")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BDFPLHKKENL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "826")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KDIHIPOBLIO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "827")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FBHBKLJIDOD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "828")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MBHGOOEPBBA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "829")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JNNHPEHBEBP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "830")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PHCNDDODGPA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "831")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EIKJMKJALOO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "832")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CBJCKINDCAI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "833")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HHHKKKENNCL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "834")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OFMNKNNNMNH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "835")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MDKKJCHPKBN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "836")]
	public CMFEBAIAIDJ<BOFEABKGBFC> AJNIKLKMGDI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "837")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LNJPJENNJKN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "838")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JNKGDPHAIDB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "839")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PDJEFOMBCIE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "840")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FLMFADGEENA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, CGEBFIEJEFP PJDNJJKGMDP)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "841")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JGKEBIMEAMJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, CGEBFIEJEFP PJDNJJKGMDP)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "842")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IALGACGFKLN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, CGEBFIEJEFP PJDNJJKGMDP)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "843")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GLADOELIECB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, CGEBFIEJEFP PJDNJJKGMDP)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "844")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MMFJLMKDEID(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, CGEBFIEJEFP PJDNJJKGMDP)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "845")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IKELOFNGKBI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, CGEBFIEJEFP PJDNJJKGMDP)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "846")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JFNDHLHODDA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, CGEBFIEJEFP PJDNJJKGMDP)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "847")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ONJPKBIIFBH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, CGEBFIEJEFP PJDNJJKGMDP)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "848")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FBNLBIHDOBA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, CGEBFIEJEFP PJDNJJKGMDP)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "849")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CKCADFPGIID(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "850")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FIDBKGIIGHF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "851")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MJOICJIMPOB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "852")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GGNHGHNNOIN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "853")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EKDGFJIADDG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "854")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HNIKAPONGEM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "855")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ICNMJGOIECH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "856")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OGOLGGIFDIO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "857")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DFCILPHGNON(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "858")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CIEGJNLKNEM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "859")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BLEMJNHKDFG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "860")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MLOABBDKHEI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "861")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BCHNEAKDLLF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "862")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DCMMFPLGNMM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "863")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CKIEFHMHBBE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "864")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FDFJIMHHFEO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "865")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PIMDKNAEGHJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "866")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GCCDFMMHFOO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "867")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JDCJPNCDHLB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "868")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HJOAEHBCBBI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "876")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CCGALGADPFG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "875")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DLMDJPDPCBA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "877")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GPHDNNLIAMO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "878")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GEDGCKOFPPO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "879")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BAAOOHGDJGA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "880")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EADHBPOHKED(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "881")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DOJLHGJAIAL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "869")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DGAOHFINAPM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "870")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LELMIPICOIL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "871")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IKCLIKGGJOJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "872")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GCFFJPFAKEE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "873")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EPMAEFIDGAG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "874")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MBGFKCLINFD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "882")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EPLMIJHLEKK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "883")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MFECDONHDJL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "889")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PBDABKDFPNK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "890")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JAJPKCCJNEJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "891")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EPAJIHNGHBI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "892")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NGALNABLBJG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "893")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IPHAALAMBBB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "894")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OKCLIGKKHDD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "895")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ILMILIPMBCI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "896")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OIFBAOMOMMM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "897")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JBGHHNCAOJJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "898")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BLFPLEBLJDJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "899")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IMIFOGFMCBI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "884")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OGBFOLLFHKI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "885")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EKMBHMDDIIM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "886")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NIGHNDKJMHC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "887")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NOAAIHPBKGI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "888")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JDNNDICCPBL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "900")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EJDBIIBAEPM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "901")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MMNLNDPLOKL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "902")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EDLGAPDAGFM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "903")]
	public CMFEBAIAIDJ<BOFEABKGBFC> INCEEBMBAHL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "904")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LNNDCPOJKDF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "905")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OFABKKHHGFF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "906")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FHGIBDICONI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "907")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CCCPOKMAMLM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "908")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LBPEPHEDAOH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "909")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HDHICBDMMIB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "910")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MJLJJHNDKJM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "914")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GJEBGIIAEJJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "915")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HDJPOBPBIHD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "911")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> FCGIKADIBOC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "912")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FKGDHJMMACH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "913")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MOFKLDOIFOM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "916")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IAOADDBBDEO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "917")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MEACNONDBBB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "918")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GMFPGICJLAM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "919")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IIGBNLBAAJI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "920")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HHEFDABLNCA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "921")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LLBLMIMIOPI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "922")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BPJFHPBKHJB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "923")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CHJJNBPMCAH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "924")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CKMMDAFBOND(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "925")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DCOBHJNACMF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "926")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DCOPHAFNEKM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "927")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LNOCMEPHGNF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "928")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LDOKGHDFJLC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "929")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BLGMINIPMAF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "930")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ENCJEDLHAON(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "931")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MFNCAIGEMCI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "932")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LOMLBNMDAPM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "933")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FLKFKLCCFGC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "934")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BCDPJDEEPFB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "935")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DPGMAGIJCJI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "936")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GPEMPNIGODC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "937")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MFMOMOFGGOG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "938")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JMNCJGOGGCP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "939")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NAEGMONACHG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "940")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KGEFMOAJOOG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "941")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CLNKCPJKDHJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "942")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KFMNNBPKKGD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "943")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MIDIEPCEJHL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "955")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MEMIPFKOLON(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "956")]
	public CMFEBAIAIDJ<BOFEABKGBFC> COILFCOCHPA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "957")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HJPAKJHBMOB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "958")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OCLBDFIOLOK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "959")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KLFPAKKDAKK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "960")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MKGJFNHIHKM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "961")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OPKPNMFGCBC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "962")]
	public CMFEBAIAIDJ<BOFEABKGBFC> AJPGNOCOJNK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "963")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HLFBHGNOHPB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "964")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EKEMMHLCLGI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "965")]
	public CMFEBAIAIDJ<BOFEABKGBFC> AIMNNKMBPNM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "966")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BAAHHKAIHMP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "967")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MFKGPJMICCF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "968")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NNKNKNGMPHO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "969")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PDGIIAFLNAC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "970")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LMDJPIIDJPF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "971")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LGKBHDKIPEI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "972")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GLAKHAIELKJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "973")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FNAPDBMINGN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "974")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IKNAJIICONM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "975")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PAFOMKAHGEJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "976")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KGPDLIDFCDI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "977")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MJNLEABPFPI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "978")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PDFKDNBMJPL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "979")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EDFLAGJLBAK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "980")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DBMKOJKOEEB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "981")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BDDHJBCFMAC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x28AD880", Offset = "0x28AC480", VA = "0x1828AD880", Slot = "982")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FOCJFLOHIJI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "983")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DHAPCOFNNCL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "984")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IOGPHPLMFPM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "985")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BGDLPIHOOBG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KGMLELKEGNC)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "986")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JCFFPFKPCNE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "987")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OOAFAGEDJCF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "988")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LGCPOLKCABD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "989")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JAEEKAPMALI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "990")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FFCGIBPOINO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "991")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MFABHBLPPJM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "992")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FAOFPABBBHN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "993")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JCBJNDNPNLA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "994")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KIGPHHBJMGK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "995")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HKOHIDIPKPL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "996")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LOEDEBCHELK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "997")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KOBCJMDJLFI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "998")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FHHKNNGNANF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "999")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MOALNIONLBK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1000")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PBGMLFAJEEM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1001")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KELFFHNHFNH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1002")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IECGOEHEOBF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1003")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GPLFJMLMNBL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1004")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IDCKIFGGDHD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1005")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BPHDONEIFMP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1006")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CHJAGFKAEFP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1007")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OGHFLGAMHFD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1008")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JKBDNLOGOIG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1009")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OCBACHMJEPB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1010")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NLAIELOCLOA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1011")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JILOJOFJLKA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1012")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PDEICIOECHC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1013")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ODCJJDJHINE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1014")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NBIMLANMGIP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1015")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OOPAJMKKGEC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1016")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FNHOBEGGBKF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1017")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KAHFGMEIONM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1018")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MFGKJBMPANJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1019")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OGOBABLPBJH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1020")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KCLMAONDNJE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1021")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DDIMGALPLKL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1022")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NDOLJHKOCCP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1023")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PJOLPKAONNP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1024")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ALLJPBLFABK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1025")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PBKPFCAHENF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1026")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CEPEPOHKCFK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1027")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IKOKKJCLBCJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1028")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OADHJGPHDIM(AEBFKJBNKDA FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1029")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HLEAEBHCFKD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1030")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KKKHANOJPBI(AEBFKJBNKDA FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1031")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BOONPNECHIO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1032")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MENKKKIMOPO(AEBFKJBNKDA FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1033")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ALPFJDFNCDA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1034")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GJMDHMADGKA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1035")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BHGGLELOMIE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1036")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PNOBILJOINA(AEBFKJBNKDA FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1037")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CNCCIBOHDGA(AEBFKJBNKDA FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1038")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DPCKKLGCKBJ(AEBFKJBNKDA FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1039")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GFMEFAPMMPF(AEBFKJBNKDA FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1040")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MNPPDOJCGDP(AEBFKJBNKDA FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1041")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EELNGACJJPA(AEBFKJBNKDA FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1042")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HMGGLIDNFCE(AEBFKJBNKDA FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1043")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FLGCKGDIEIH(AEBFKJBNKDA FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1044")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DFMCEMAPMON(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1045")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OLILGLDDKKA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1046")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BDEFFJDMOON(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1047")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FAJIFHJLNKI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1048")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BEIBNJGEEEP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1049")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IIIANJCHOAO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1050")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ONPDLAHOBBA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1051")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FEMHHDEEICH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1052")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LONIODBGIJI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1053")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MAEOCLJEIFE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1054")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LGAFLIDMEEJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1055")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KBCIFCBMMHC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1056")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FOJGGINNNPG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1057")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OKLMEDFHBCH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1058")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OEDHFNCOIDF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1059")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KAFDCMKPPCI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1060")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GDPIJHOGLJG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1061")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IMBFNIIIDHB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1062")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BJNALMMBDOF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1063")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GOOKDGHGNDJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1064")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NCAGMPCJHBF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1065")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CDGKHIBBDLD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1066")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KIFHKDDCJIK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1067")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HAMOLHBHLKK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1068")]
	public CMFEBAIAIDJ<BOFEABKGBFC> COLHJGMKAFF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1069")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EAOBBALEMOC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1070")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LBMLNOPFLFC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1071")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LPAHFAHOIPC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1072")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DAFJJHGFDGB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1073")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KHAGHANKNKA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1074")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GGPIKLPKOIO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1075")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GAFOBCDCDFH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1076")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CAPOLDLLAIC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1077")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GCDALCLLEKK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1078")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BAMHNJOCPGJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1079")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PNGIJJOKENL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1080")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MFHFFHMCFKA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1081")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CFGJEDNCEJL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1082")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HJEFJNOKFPL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1083")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GEAGJNEKEKH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1084")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GBDNFGFLNCB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1085")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DKKGNMPJNOB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1086")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ACBCKGEHKEB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1087")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FHPCPELMKDC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1088")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ENKDNNLEBBL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1089")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NGJLHJCPNPM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1090")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FJFOENBFFIN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1091")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ABLLILNBFPM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1092")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ENBMPADBMMN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1093")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DCGMMODBMCA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1094")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FIAJGLKJFMK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1095")]
	public CMFEBAIAIDJ<BOFEABKGBFC> APPPJEHGJDL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1096")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LAPGGBFIMID(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1097")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OAFPDKOIJOP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1098")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CDGANBFBBHJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1099")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DLJFOFKBBDH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1100")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MHFLINEDCBF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "141")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LLDCEPMEIPC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "143")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GFHFFEELJGG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "144")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MNHKDANFGCB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "145")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MGMEMGPFMLJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "146")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HJDAGIHHEDA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "147")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JJFIBELOHEC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x28AD8C0", Offset = "0x28AC4C0", VA = "0x1828AD8C0", Slot = "148")]
	public bool HMPAMLMBAPI(string KMCLKBGAPBL, [Out] int GCKOLKABAJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1101")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FHHHLEFJEOC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1102")]
	public CMFEBAIAIDJ<BOFEABKGBFC> COCMOLACGLD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1103")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CALIJNBHJDD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BBAGLAJKNIK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, [In] string NNNFHPCLBJP, [In] int BDCIFPGPGFB)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1115")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FENGBFOPLPA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1104")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GDDCKOGCBBE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1105")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DCBIAOADCDO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1106")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KIDKOGBCBNO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1107")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KPJKMEABDNN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1108")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BKBECCBHIFP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1109")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BHDJHCDDJEC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1110")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PGDFAKOIMAE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1111")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DJPGIABABGB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1112")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MBAMLNCKIKM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1113")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EMNPDILCPOL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "206")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HKOHGMKHANF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, PPMLMACJNEJ OJGMPCFAIAI)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "207")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LMCILFLIOPN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "208")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GAPEFIAPAPO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "209")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HAKDEDLKLAC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "210")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JCELMKNGPLM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "211")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DAHCOGEPKFE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "212")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JDMGBOAACLC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "213")]
	public CMFEBAIAIDJ<BOFEABKGBFC> AJHLPIAPGBK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "214")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CJBCDFBLEAM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "215")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BAIJFJPBLKM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "216")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FKJNLMJAPHA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "217")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MJPLCFMPOMF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "218")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LFMMABJNLEK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "219")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FFHILAKCIOL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "220")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ANKGOFOACAH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "221")]
	public CMFEBAIAIDJ<BOFEABKGBFC> AOADAOHPBBJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "222")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LCBLOPDMKGJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "223")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BJMOAJKKEIB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "224")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PJPGINNIOEJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "225")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PCGGLFDEGGO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "226")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OKMEGGAAOPO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "227")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OLEHEPCENJG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "228")]
	public CMFEBAIAIDJ<BOFEABKGBFC> AHDBOCFLOOH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "229")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BNBMMIJCIKN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "230")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BKKBONFCEMB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0")]
	private static CMFEBAIAIDJ<BOFEABKGBFC> DIACPKGMELN(CMLIDFCPMDK FCEJBDLGOKN, object DOLEDGPOAIC, LNCBCDGMIHI ECOCHAPIFKN, IReadOnlyList<PCMODOINFKB> OJDJFNBAEAO, IList<PCMODOINFKB> CNPHJDDGEBH)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x28AD8D0", Offset = "0x28AC4D0", VA = "0x1828AD8D0", Slot = "1116")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NDEAGLFIDCP(CMLIDFCPMDK FCEJBDLGOKN, object DOLEDGPOAIC, LNCBCDGMIHI ECOCHAPIFKN, IReadOnlyList<PCMODOINFKB> OJDJFNBAEAO, IList<PCMODOINFKB> CNPHJDDGEBH)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1119")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PLGHEIEFILD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1120")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PIPBEJGPCOC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1121")]
	public CMFEBAIAIDJ<BOFEABKGBFC> ADMLJAMNKLJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1122")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BIDAHCMPADL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1117")]
	public CMFEBAIAIDJ<BOFEABKGBFC> NEACIFKJLPG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, JFHDILGJFFP MLIHCHBPNKC)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1118")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CCAEMIHMBPA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "944")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DHIKLDJNCMF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "945")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KMBJODHPDGI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "946")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FMCBMDMDCBD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "947")]
	public CMFEBAIAIDJ<BOFEABKGBFC> GEAOOLCGNBN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "948")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KIDPGMDEDDJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "949")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DKGOIDAJCJH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "950")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CKCNAEAPLKB(CMLIDFCPMDK FCEJBDLGOKN, IReadOnlyList<PCMODOINFKB> OJDJFNBAEAO)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "951")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JDGFFJLCOAF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "952")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DMHJFPJKGPF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "953")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IOHAJGDLJOE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "954")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FPMAHFPANBP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1126")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KIEJBGNENJB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1127")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HALKAHDHFGA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1128")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KBFJJBLBPAB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1129")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KODKFDJIDBL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1130")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HICMJJEGCFH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1131")]
	public CMFEBAIAIDJ<BOFEABKGBFC> BJFDICHDMPE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1132")]
	public CMFEBAIAIDJ<BOFEABKGBFC> AAGEAGFACAL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1133")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> EHPDALJNLHH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1137")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KGGEHOODNFO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1138")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CILDNHOIKLO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1134")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MDFOBDGFACD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1135")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HNBCIOHCBFE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1136")]
	public CMFEBAIAIDJ<BOFEABKGBFC> DBJMDEPFOGL(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x28AD9E0", Offset = "0x28AC5E0", VA = "0x1828AD9E0")]
	public EPJHIBAPADA([Optional] BGEFCGNBPGH? FIHPGLPJCLP, [Optional] BGEFCGNBPGH? GGCFKGEIIAI, [Optional] BGEFCGNBPGH? LKOPBCOLLHI, [Optional] BGEFCGNBPGH? INMDDBEOJMH, [Optional] CIICOBGGECD? APKAJFJNHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1139")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> LEGKCMKBAML(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1140")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> BNCPHNMFABF(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1141")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> CPFLILFGIIP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1142")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> POJLCHJMICC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1143")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> NIDAKHJPEKD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1144")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> GEJFKIDJOAE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1145")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> GAJDEBMFJFI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1146")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> NOGHOGJJBLI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1147")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> MANHCAGCGAO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1148")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> GFNJLGPMCLA(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1149")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> EGEFEHAJJHB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1150")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> GIGHNBAJAMI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1151")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> CNNBMCPGBND(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1152")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> OOFFBJCJKNI(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1153")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> IKEENGAELEE(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1154")]
	public CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>> CMNLGEPIDIC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<Task<CMFEBAIAIDJ<CMLKJIDDPNN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1155")]
	public CMFEBAIAIDJ<BOFEABKGBFC> EHKLHMEJIHG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, int PMGLBCDCDJE)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1156")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IPLLOCPALOB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1157")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OGFDGKKOKDH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1158")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PEEPHINCPDH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1159")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JNKJACFDIIB(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1160")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CGNDFIEFDLM(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1161")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CFJNFAOJNOO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1162")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LPHLMLONKKP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1163")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KHPJPEHLEBO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1164")]
	public CMFEBAIAIDJ<BOFEABKGBFC> FCKABBBEFIN(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1165")]
	public CMFEBAIAIDJ<BOFEABKGBFC> CEGIAJDCGDJ(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1166")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JKNOFBIHBBG(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1167")]
	public CMFEBAIAIDJ<BOFEABKGBFC> IBIGPCIPACK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1168")]
	public CMFEBAIAIDJ<BOFEABKGBFC> PIKBEJNELJP(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1169")]
	public CMFEBAIAIDJ<BOFEABKGBFC> MGNOMPJLBBM(AEBFKJBNKDA FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, NMEAFGHPICL GCHNIHDDEIE)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1170")]
	public CMFEBAIAIDJ<BOFEABKGBFC> JCOAACLBGED(AEBFKJBNKDA FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, NMEAFGHPICL GCHNIHDDEIE)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1171")]
	public CMFEBAIAIDJ<BOFEABKGBFC> LHODNFOFEJH(AEBFKJBNKDA FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, NMEAFGHPICL GCHNIHDDEIE)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1172")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KPKEOBIOPKN(AEBFKJBNKDA FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, NMEAFGHPICL GCHNIHDDEIE)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1173")]
	public CMFEBAIAIDJ<BOFEABKGBFC> KHELCKDINFC(AEBFKJBNKDA FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, NMEAFGHPICL GCHNIHDDEIE)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HHDIJNODLNO(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, [In] INODBIMFEHI MJLNGOKHNNP)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1124")]
	public CMFEBAIAIDJ<BOFEABKGBFC> OMPNIDOBNAK(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1125")]
	public CMFEBAIAIDJ<BOFEABKGBFC> HONIOOFMEDH(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1114")]
	private CMFEBAIAIDJ<BOFEABKGBFC> CNENJIAEGGD(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, [In] string NNNFHPCLBJP, [In] int BDCIFPGPGFB)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "1123")]
	private CMFEBAIAIDJ<BOFEABKGBFC> GIBPPJOHAHC(CMLIDFCPMDK FCEJBDLGOKN, MFBOGBHLIDC KAIJGNPPCEK, [In] INODBIMFEHI MJLNGOKHNNP)
	{
		return default(CMFEBAIAIDJ<BOFEABKGBFC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public sealed class LCOJGGBLDFC : FHCLCGEGPPD
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public delegate Task<bool> OLDODDMEDLC(JCFPLIGIMNP PBOIPJOJPLG);

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static readonly LCOJGGBLDFC LELJIFADAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly OLDODDMEDLC CAIBFOGKHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly OLDODDMEDLC IHFBBNCOKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private bool LKCEENMFBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private bool EKBCJNDEEBG;

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x28B8270", Offset = "0x28B6E70", VA = "0x1828B8270", Slot = "4")]
	public Task<bool> AKGIPONCLDE(JCFPLIGIMNP PBOIPJOJPLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x28BD0B0", Offset = "0x28BBCB0", VA = "0x1828BD0B0", Slot = "5")]
	public Task<bool> APDCFKNAIPO(JCFPLIGIMNP PBOIPJOJPLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0x28BD180", Offset = "0x28BBD80", VA = "0x1828BD180")]
	public LCOJGGBLDFC([Optional] OLDODDMEDLC? AMGNKDGANKN, [Optional] OLDODDMEDLC? MOBCLBMDHLE, bool LKCEENMFBMH = false, bool EKBCJNDEEBG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x28BD0E0", Offset = "0x28BBCE0", VA = "0x1828BD0E0", Slot = "6")]
	public (NECFMIACHGC, Guid, Guid)? GIPMEFIOEKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0xA247B0", Offset = "0xA233B0", VA = "0x180A247B0", Slot = "7")]
	public bool PFDLGPKPCGI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x1436790", Offset = "0x1435390", VA = "0x181436790", Slot = "8")]
	public bool LOCJCJNEKJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[Obsolete]
public sealed class HBFCNBHHPIN : DBPOAHOEOAA
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Guid CEALNJJKMFK
	{
		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0xDDC970", Offset = "0xDDB570", VA = "0x180DDC970", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
	public void Bind(OPOHFAINMAJ PDPCHOHFANF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0xFE78F0", Offset = "0xFE64F0", VA = "0x180FE78F0")]
	public HBFCNBHHPIN(Guid LHECJJHBNHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(RVA = "0x28BCE80", Offset = "0x28BBA80", VA = "0x1828BCE80")]
	public static HBFCNBHHPIN JHMOIFLKJAD(Guid LHECJJHBNHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class LFJIAIOIANJ : NEOHBEDIIMG
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public delegate bool GMAHJGABGCM(BMAAMMAFHBI<DHCEMECNKGP> KNMCNCMHIOL, BMAAMMAFHBI<FNJCFKDMDPO>? DDONKFFEEKC, IReadOnlyDictionary<BMAAMMAFHBI<FNJCFKDMDPO>, Guid>? MABHDKMPOFO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private GMAHJGABGCM? DMLKBKLILDC;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool FJIHMIJJNOG
	{
		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0xAA8AD0", Offset = "0xAA76D0", VA = "0x180AA8AD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool AOGAPHNAGGF
	{
		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x28BD390", Offset = "0x28BBF90", VA = "0x1828BD390", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool NGAAMPHBHOK
	{
		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x1EFBB50", Offset = "0x1EFA750", VA = "0x181EFBB50", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390", Slot = "6")]
	public bool FNCDKPDNJJB(Guid KKLNOBFBCOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "7")]
	public JOFPIMAPEOF EJKLJHKGFOJ(Guid EDLIHNDBAFI)
	{
		return default(JOFPIMAPEOF);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0x28BD3A0", Offset = "0x28BBFA0", VA = "0x1828BD3A0", Slot = "8")]
	public bool JLMNDPMFHNF(BMAAMMAFHBI<DHCEMECNKGP> KNMCNCMHIOL, BMAAMMAFHBI<FNJCFKDMDPO>? DDONKFFEEKC, IReadOnlyDictionary<BMAAMMAFHBI<FNJCFKDMDPO>, Guid>? MABHDKMPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "9")]
	public bool DFBINHDBIKE(Guid KKLNOBFBCOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "10")]
	public bool DCBIHCDINKD(Guid KKLNOBFBCOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x28BD3F0", Offset = "0x28BBFF0", VA = "0x1828BD3F0")]
	public LFJIAIOIANJ(bool GMJJIHCPNIO = false, bool LDPKLBNILLF = false, bool JNEKDAOBAKA = false, bool LHCMGAILMMJ = false, bool CJELMIFBECI = false, bool EHIGGEFLGBH = false, [Optional] GMAHJGABGCM? BJPFAKEBICF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public sealed class PHALLDAKMOP : HACDCOMJBFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public delegate bool LDGCBADIDPP();

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public delegate bool BPDOENBBFMM();

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static readonly PHALLDAKMOP LELJIFADAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private readonly LDGCBADIDPP MMPNKLIGIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly BPDOENBBFMM NGFAHHDMIML;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool ANJCFOJBBON
	{
		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x11564B0", Offset = "0x11550B0", VA = "0x1811564B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool DJJHLABAKGH
	{
		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x28BE220", Offset = "0x28BCE20", VA = "0x1828BE220", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x28BE2D0", Offset = "0x28BCED0", VA = "0x1828BE2D0")]
	public PHALLDAKMOP([Optional] LDGCBADIDPP? JKAPKFDGGOO, [Optional] BPDOENBBFMM? JJBBLOBPAPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public sealed class AAHJKJOHBON : CKCDMHDCEJL
{
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static readonly AAHJKJOHBON LBPNLDGACAA;

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0xA84210", Offset = "0xA82E10", VA = "0x180A84210", Slot = "4")]
	public object EBAGJKMAFHO(object OOHGFGHCOAJ, Type OPOPAMPKKGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public AAHJKJOHBON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public sealed class DLGCIFIFCON : OKHIIGNFPLG
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class AALCMBOMLOE : FGPNLEOAOJB, INotifyCompletion
	{
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public static readonly AALCMBOMLOE LBPNLDGACAA;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool GHBNADMNCLG
		{
			[Cpp2IlInjected.Token(Token = "0x60006CF")]
			[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x28B5E50", Offset = "0x28B4A50", VA = "0x1828B5E50", Slot = "6")]
		public void OnCompleted(Action JPMKDGPIIAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		public void BOPJECOALEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public AALCMBOMLOE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static readonly DLGCIFIFCON LBPNLDGACAA;

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	private DLGCIFIFCON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x28B95C0", Offset = "0x28B81C0", VA = "0x1828B95C0", Slot = "4")]
	public FGPNLEOAOJB LCIABKLGBLO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public sealed class FOEEKKEAGCO<TRoot, TDeps> : IDisposable, PHDIAJJHLCL where TRoot : notnull where TDeps : notnull, DJGMKMFOACJ.HHGBPDJBAOO<TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly TDeps MPDEJFBBCAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly TRoot FDOKJEJPACH;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public IKLALLBKLKC<KJCLJNBJCIN> CADPENEOLIL
	{
		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0xA768B0", Offset = "0xA754B0", VA = "0x180A768B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(IKLALLBKLKC<KJCLJNBJCIN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x2E621E0", Offset = "0x2E60DE0", VA = "0x182E621E0")]
	public FOEEKKEAGCO(TDeps FCHJEFGMLNE, TRoot HMGDINOCJAI, IKLALLBKLKC<KJCLJNBJCIN> MEHEKMFODFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D6")]
	[Cpp2IlInjected.Address(RVA = "0x4C59810", Offset = "0x4C58410", VA = "0x184C59810", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D7")]
	[Cpp2IlInjected.Address(RVA = "0x4C599A0", Offset = "0x4C585A0", VA = "0x184C599A0")]
	public IKLALLBKLKC<PEOCIBIIEAD> EGLPEDAPAND([In] Guid? LMBLGALMBCI, POMGKDAAEIL OAJMKPFMDHN)
	{
		return default(IKLALLBKLKC<PEOCIBIIEAD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D8")]
	[Cpp2IlInjected.Address(RVA = "0x4C5A1B0", Offset = "0x4C58DB0", VA = "0x184C5A1B0", Slot = "6")]
	public void NAMDIGENEPF(IKLALLBKLKC<PEOCIBIIEAD> AEIJGHPBELE, LBKKIAJOPND MMJHOAALMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x4C5A000", Offset = "0x4C58C00", VA = "0x184C5A000", Slot = "7")]
	public void LEFIFIKJFCO(IKLALLBKLKC<PEOCIBIIEAD> AEIJGHPBELE, LBKKIAJOPND MMJHOAALMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x4C5A260", Offset = "0x4C58E60", VA = "0x184C5A260", Slot = "8")]
	public void NBOCMBGAGEJ(IKLALLBKLKC<PEOCIBIIEAD> AEIJGHPBELE, LBKKIAJOPND MMJHOAALMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x4C5A580", Offset = "0x4C59180", VA = "0x184C5A580", Slot = "10")]
	public void OBMKHNDJBJA(IKLALLBKLKC<PEOCIBIIEAD> AEIJGHPBELE, IKLALLBKLKC<KJCLJNBJCIN> KPGHEBOCEPO, LBKKIAJOPND MMJHOAALMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x4C59EC0", Offset = "0x4C58AC0", VA = "0x184C59EC0", Slot = "9")]
	public void HMBDBNJIFAJ(IKLALLBKLKC<PEOCIBIIEAD> AEIJGHPBELE, LBKKIAJOPND MMJHOAALMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(RVA = "0x4C5A880", Offset = "0x4C59480", VA = "0x184C5A880", Slot = "11")]
	public void ONEJEELEOKH(IKLALLBKLKC<PEOCIBIIEAD> AEIJGHPBELE, MFIPBIHDJDC? OPHIIDBMNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x4C59D50", Offset = "0x4C58950", VA = "0x184C59D50", Slot = "12")]
	public IKLALLBKLKC<KJCLJNBJCIN> GCJNFBIELFI(IKLALLBKLKC<PEOCIBIIEAD> AEIJGHPBELE)
	{
		return default(IKLALLBKLKC<KJCLJNBJCIN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x4C5A620", Offset = "0x4C59220", VA = "0x184C5A620", Slot = "13")]
	public IKLALLBKLKC<DAOMKHHAECF> OHEMBKIMAGE(IKLALLBKLKC<PEOCIBIIEAD> AEIJGHPBELE, string MEPFFFGIFGB, object OOHGFGHCOAJ, BDPOBDGKMIM GDKPCBPPEHB, MHBJEMDFMIG NHLHEIFMCKA)
	{
		return default(IKLALLBKLKC<DAOMKHHAECF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(RVA = "0x4C59620", Offset = "0x4C58220", VA = "0x184C59620", Slot = "14")]
	public void AOLFMHAINBL(IKLALLBKLKC<DAOMKHHAECF> DNAENMKKHIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E1")]
	[Cpp2IlInjected.Address(RVA = "0x4C59B60", Offset = "0x4C58760", VA = "0x184C59B60", Slot = "15")]
	public void FCJCAMGLNNI(IKLALLBKLKC<DAOMKHHAECF> DNAENMKKHIN, object OOHGFGHCOAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public static class DJGMKMFOACJ
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public interface HHGBPDJBAOO<TRoot> where TRoot : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FMHLIIJPBMA(TRoot HMGDINOCJAI, IKLALLBKLKC<KJCLJNBJCIN> KPGHEBOCEPO);

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IKLALLBKLKC<KJCLJNBJCIN>? DHMEPHJGOEN(TRoot HMGDINOCJAI);

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IKLALLBKLKC<PEOCIBIIEAD> EGLPEDAPAND(TRoot HMGDINOCJAI, IKLALLBKLKC<KJCLJNBJCIN> MPFBANPBMKI, [In] Guid? LMBLGALMBCI, POMGKDAAEIL OAJMKPFMDHN);

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NAMDIGENEPF(TRoot HMGDINOCJAI, IKLALLBKLKC<KJCLJNBJCIN> KPGHEBOCEPO, IKLALLBKLKC<PEOCIBIIEAD> AEIJGHPBELE, LBKKIAJOPND MMJHOAALMOF);

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void LEFIFIKJFCO(TRoot HMGDINOCJAI, IKLALLBKLKC<PEOCIBIIEAD> AEIJGHPBELE, LBKKIAJOPND MMJHOAALMOF);

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void OBMKHNDJBJA(TRoot HMGDINOCJAI, IKLALLBKLKC<KJCLJNBJCIN> KPGHEBOCEPO, IKLALLBKLKC<PEOCIBIIEAD> AEIJGHPBELE, LBKKIAJOPND MMJHOAALMOF);

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void HMBDBNJIFAJ(TRoot HMGDINOCJAI, IKLALLBKLKC<KJCLJNBJCIN> KPGHEBOCEPO, IKLALLBKLKC<PEOCIBIIEAD> AEIJGHPBELE, LBKKIAJOPND MMJHOAALMOF);

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void ONEJEELEOKH(TRoot HMGDINOCJAI, IKLALLBKLKC<KJCLJNBJCIN> KPGHEBOCEPO, IKLALLBKLKC<PEOCIBIIEAD> AEIJGHPBELE, MFIPBIHDJDC? OPHIIDBMNFD);

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(Slot = "8")]
		IKLALLBKLKC<KJCLJNBJCIN>? GCJNFBIELFI(TRoot HMGDINOCJAI, IKLALLBKLKC<PEOCIBIIEAD> AEIJGHPBELE);

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(Slot = "9")]
		IKLALLBKLKC<DAOMKHHAECF> OHEMBKIMAGE(TRoot HMGDINOCJAI, IKLALLBKLKC<KJCLJNBJCIN> KPGHEBOCEPO, string MEPFFFGIFGB, object IPOLOHBNCGD, BDPOBDGKMIM GDKPCBPPEHB, MHBJEMDFMIG NHLHEIFMCKA);

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void AOLFMHAINBL(TRoot HMGDINOCJAI, IKLALLBKLKC<KJCLJNBJCIN> KPGHEBOCEPO, IKLALLBKLKC<DAOMKHHAECF> DNAENMKKHIN);

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void FCJCAMGLNNI(TRoot HMGDINOCJAI, IKLALLBKLKC<KJCLJNBJCIN> KPGHEBOCEPO, IKLALLBKLKC<DAOMKHHAECF> DNAENMKKHIN, object OOHGFGHCOAJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal sealed class GEBNIDMHPDF
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	internal struct GLHJCLFIMAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public readonly HashSet<IKLALLBKLKC<PEOCIBIIEAD>> KNCLHAMJFLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public GFKDCKGHOGN<DAOMKHHAECF, POILGPPHEFB> PAPHDIMCBJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public readonly Dictionary<IKLALLBKLKC<DAOMKHHAECF>, IKLALLBKLKC<FBHINLCEODO.HGKJMABMPBA>> JKEHCDAAFIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public Dictionary<IKLALLBKLKC<FBHINLCEODO.HGKJMABMPBA>, IKLALLBKLKC<DAOMKHHAECF>> NFDKKCLKLID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public FKBNOJLBGKB<PEOCIBIIEAD, MFIPBIHDJDC?> AIJGHDAPHHG;

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x28BCB50", Offset = "0x28BB750", VA = "0x1828BCB50")]
		private GLHJCLFIMAM(HashSet<IKLALLBKLKC<PEOCIBIIEAD>> IBIKCPPALKC, [In] GFKDCKGHOGN<DAOMKHHAECF, POILGPPHEFB> BPEGAJJPPEA, Dictionary<IKLALLBKLKC<DAOMKHHAECF>, IKLALLBKLKC<FBHINLCEODO.HGKJMABMPBA>> LPGIGMMMMJB, Dictionary<IKLALLBKLKC<FBHINLCEODO.HGKJMABMPBA>, IKLALLBKLKC<DAOMKHHAECF>> NJHDBGNOBGF, [In] FKBNOJLBGKB<PEOCIBIIEAD, MFIPBIHDJDC?> HDMNJOPCAHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x28BC970", Offset = "0x28BB570", VA = "0x1828BC970")]
		public static GLHJCLFIMAM JHMOIFLKJAD()
		{
			return default(GLHJCLFIMAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private struct DNBANEHCMKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public IKLALLBKLKC<KJCLJNBJCIN>? OBFGJKGGNDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public readonly Guid? JEMAOKKKMOK;

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x28B9680", Offset = "0x28B8280", VA = "0x1828B9680")]
		public DNBANEHCMKI(IKLALLBKLKC<KJCLJNBJCIN> CLCJOGIKGNI, [In] Guid? LMBLGALMBCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	internal struct POILGPPHEFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public MHBJEMDFMIG KAALOEPPFBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public BDPOBDGKMIM OJOCCKIJFCF;

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0xB5F450", Offset = "0xB5E050", VA = "0x180B5F450")]
		internal POILGPPHEFB(MHBJEMDFMIG NHLHEIFMCKA, BDPOBDGKMIM GDKPCBPPEHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x28BE660", Offset = "0x28BD260", VA = "0x1828BE660")]
		public static POILGPPHEFB JHMOIFLKJAD(MHBJEMDFMIG NHLHEIFMCKA, BDPOBDGKMIM GDKPCBPPEHB)
		{
			return default(POILGPPHEFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	internal struct FBHINLCEODO
	{
		[Cpp2IlInjected.Token(Token = "0x2000091")]
		public sealed class HGKJMABMPBA
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public string AJPMCBKCCJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public object IOOEMCNJEAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public int GGAMLGBEOJN;

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x28B9C10", Offset = "0x28B8810", VA = "0x1828B9C10")]
		internal FBHINLCEODO(string LAOCJKNALFF, object OOHGFGHCOAJ, int LCPPKLGEEEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x28B9BC0", Offset = "0x28B87C0", VA = "0x1828B9BC0")]
		public static FBHINLCEODO JHMOIFLKJAD(string LAOCJKNALFF, object OOHGFGHCOAJ)
		{
			return default(FBHINLCEODO);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private GFKDCKGHOGN<PEOCIBIIEAD, DNBANEHCMKI> BCCFFAAFEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private Dictionary<(Guid, POMGKDAAEIL), IKLALLBKLKC<PEOCIBIIEAD>> BGLLABLIPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private GFKDCKGHOGN<FBHINLCEODO.HGKJMABMPBA, FBHINLCEODO> CPGLJJKKMOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private Dictionary<string, IKLALLBKLKC<FBHINLCEODO.HGKJMABMPBA>> NADKKAKPGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private FKBNOJLBGKB<KJCLJNBJCIN, GLHJCLFIMAM> FJMCGDCMIIM;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public IKLALLBKLKC<PEOCIBIIEAD>? BLKLEBPMBDL
	{
		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0xA839C0", Offset = "0xA825C0", VA = "0x180A839C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x28BB800", Offset = "0x28BA400", VA = "0x1828BB800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(RVA = "0x28BA7F0", Offset = "0x28B93F0", VA = "0x1828BA7F0")]
	public void AMAAGOMLOEN([In] HHAPOFMILMM<KJCLJNBJCIN> PICOFBFIKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x28BAB90", Offset = "0x28B9790", VA = "0x1828BAB90")]
	public void BODFABNMNLK(IKLALLBKLKC<KJCLJNBJCIN> KPGHEBOCEPO, bool FGNNGNBFHMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x28BB810", Offset = "0x28BA410", VA = "0x1828BB810")]
	public void FMHLIIJPBMA(IKLALLBKLKC<KJCLJNBJCIN> KPGHEBOCEPO, IKLALLBKLKC<KJCLJNBJCIN>? MDPFBFJECGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x28BB030", Offset = "0x28B9C30", VA = "0x1828BB030")]
	public IKLALLBKLKC<PEOCIBIIEAD> EGLPEDAPAND(IKLALLBKLKC<KJCLJNBJCIN> MPFBANPBMKI, [In] Guid? LMBLGALMBCI, POMGKDAAEIL OAJMKPFMDHN, [In] HHAPOFMILMM<KJCLJNBJCIN> PICOFBFIKIJ)
	{
		return default(IKLALLBKLKC<PEOCIBIIEAD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x28BC0B0", Offset = "0x28BACB0", VA = "0x1828BC0B0")]
	public IKLALLBKLKC<DAOMKHHAECF> OHEMBKIMAGE(IKLALLBKLKC<KJCLJNBJCIN> KPGHEBOCEPO, string LAOCJKNALFF, object IPOLOHBNCGD, BDPOBDGKMIM GDKPCBPPEHB, MHBJEMDFMIG NHLHEIFMCKA)
	{
		return default(IKLALLBKLKC<DAOMKHHAECF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0x28BA9E0", Offset = "0x28B95E0", VA = "0x1828BA9E0")]
	public void AOLFMHAINBL(IKLALLBKLKC<KJCLJNBJCIN> KPGHEBOCEPO, IKLALLBKLKC<DAOMKHHAECF> DNAENMKKHIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x28BBB70", Offset = "0x28BA770", VA = "0x1828BBB70")]
	public IKLALLBKLKC<PEOCIBIIEAD>? GKEAGDKFLJN([In] Guid LMBLGALMBCI, POMGKDAAEIL OAJMKPFMDHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0x28BBF10", Offset = "0x28BAB10", VA = "0x1828BBF10")]
	public void NAMDIGENEPF([In] HHAPOFMILMM<KJCLJNBJCIN> PICOFBFIKIJ, IKLALLBKLKC<KJCLJNBJCIN> KPGHEBOCEPO, IKLALLBKLKC<PEOCIBIIEAD> AEIJGHPBELE, LBKKIAJOPND MMJHOAALMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0x28BBDC0", Offset = "0x28BA9C0", VA = "0x1828BBDC0")]
	public void LEFIFIKJFCO(IKLALLBKLKC<PEOCIBIIEAD> AEIJGHPBELE, LBKKIAJOPND MMJHOAALMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(RVA = "0x28BBF90", Offset = "0x28BAB90", VA = "0x1828BBF90")]
	public void OBMKHNDJBJA(IKLALLBKLKC<KJCLJNBJCIN> KPGHEBOCEPO, IKLALLBKLKC<PEOCIBIIEAD> AEIJGHPBELE, LBKKIAJOPND MMJHOAALMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(RVA = "0x28BBC40", Offset = "0x28BA840", VA = "0x1828BBC40")]
	public void HMBDBNJIFAJ([In] HHAPOFMILMM<KJCLJNBJCIN> PICOFBFIKIJ, IKLALLBKLKC<KJCLJNBJCIN> KPGHEBOCEPO, IKLALLBKLKC<PEOCIBIIEAD> AEIJGHPBELE, LBKKIAJOPND MMJHOAALMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x28BC330", Offset = "0x28BAF30", VA = "0x1828BC330")]
	public void ONEJEELEOKH(IKLALLBKLKC<KJCLJNBJCIN> KPGHEBOCEPO, IKLALLBKLKC<PEOCIBIIEAD> AEIJGHPBELE, MFIPBIHDJDC? OPHIIDBMNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x28BBB10", Offset = "0x28BA710", VA = "0x1828BBB10")]
	public IKLALLBKLKC<KJCLJNBJCIN>? GCJNFBIELFI(IKLALLBKLKC<PEOCIBIIEAD> AEIJGHPBELE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x28BB450", Offset = "0x28BA050", VA = "0x1828BB450")]
	public void FCJCAMGLNNI([In] HHAPOFMILMM<KJCLJNBJCIN> PICOFBFIKIJ, IKLALLBKLKC<KJCLJNBJCIN> KPGHEBOCEPO, IKLALLBKLKC<DAOMKHHAECF> DNAENMKKHIN, object OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x28BC3E0", Offset = "0x28BAFE0", VA = "0x1828BC3E0")]
	public GEBNIDMHPDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
internal static class DJJNFIGNBDG
{
	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x28B9560", Offset = "0x28B8160", VA = "0x1828B9560")]
	public static void AMAAGOMLOEN(this GEBNIDMHPDF.GLHJCLFIMAM LAAPKLDJLPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public class NKEPEKGAAEL : MDEKLCBODDG.EDDPABJHCGP
{
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public static NKEPEKGAAEL FHPPLAEJDFB;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public POMADBABOAP FCFAMEPGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public POMADBABOAP OHFEAKALMIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0xA20DD0", Offset = "0xA1F9D0", VA = "0x180A20DD0")]
	public NKEPEKGAAEL(POMADBABOAP FKFFPJDPFNF, POMADBABOAP FNFPLINCJKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[FMJJHJFKIEK("MockCircuitsNetwork")]
public sealed class APCJJMMLALP : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private readonly struct ONJGPLEMEIJ : AFHJFGFNFMA.KLIPFOIGICN<PDKGHPFBEOL, KDEPIGGKFKP, APCJJMMLALP>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000096")]
		[CompilerGenerated]
		private struct BFCMMHKAGKD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public APCJJMMLALP root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public IKLALLBKLKC<KJCLJNBJCIN> actorId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public IKLALLBKLKC<PDKGHPFBEOL> requestId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public KDEPIGGKFKP action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public ONJGPLEMEIJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			private (Task SendLocalTask, Task[] SendOthersTasks) <tasks>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000719")]
			[Cpp2IlInjected.Address(RVA = "0x28B7E30", Offset = "0x28B6A30", VA = "0x1828B7E30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071A")]
			[Cpp2IlInjected.Address(RVA = "0x28B8140", Offset = "0x28B6D40", VA = "0x1828B8140", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "4")]
		public int IFHLMMPFCFG(APCJJMMLALP HMGDINOCJAI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x28BDE60", Offset = "0x28BCA60", VA = "0x1828BDE60", Slot = "5")]
		public int JMELMMPMBEB(APCJJMMLALP HMGDINOCJAI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x28BDE40", Offset = "0x28BCA40", VA = "0x1828BDE40", Slot = "6")]
		public int IIBKAKAIIHD(APCJJMMLALP HMGDINOCJAI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0xE7A6B0", Offset = "0xE792B0", VA = "0x180E7A6B0", Slot = "7")]
		public int LOCGFANKBPE(APCJJMMLALP HMGDINOCJAI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x28BDCB0", Offset = "0x28BC8B0", VA = "0x1828BDCB0", Slot = "8")]
		public void BELDBNFIHBO(APCJJMMLALP HMGDINOCJAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "9")]
		public bool LHFILICJAJL(APCJJMMLALP HMGDINOCJAI, IKLALLBKLKC<KJCLJNBJCIN> KJIKHIJJPOK, KDEPIGGKFKP[] PEENJLIBDIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "10")]
		public bool GEGDKICAFLP(APCJJMMLALP HMGDINOCJAI, int EPFIKJHJFND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x28BDD00", Offset = "0x28BC900", VA = "0x1828BDD00", Slot = "11")]
		[AsyncStateMachine(typeof(BFCMMHKAGKD))]
		public Task BMDDJNJNMEG(APCJJMMLALP HMGDINOCJAI, IKLALLBKLKC<KJCLJNBJCIN> KJIKHIJJPOK, IKLALLBKLKC<PDKGHPFBEOL> NFHIONLLLPO, KDEPIGGKFKP IFDCDCHOGGB, bool IJNEMJEKNLN = true)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	private readonly struct BBFFGOPFHOF : AFHJFGFNFMA.OFOPAMEGJPF<KICAJCCFFLP, CEGJGOPGACI.MNOLDPDILIA, ONJGPLEMEIJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public KICAJCCFFLP FDLELNAPDAG
		{
			[Cpp2IlInjected.Token(Token = "0x600071B")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "4")]
			get
			{
				return default(KICAJCCFFLP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public CEGJGOPGACI.MNOLDPDILIA HBAPIJJGHNM
		{
			[Cpp2IlInjected.Token(Token = "0x600071C")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "5")]
			get
			{
				return default(CEGJGOPGACI.MNOLDPDILIA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public ONJGPLEMEIJ ABJHHLMCEKI
		{
			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "6")]
			get
			{
				return default(ONJGPLEMEIJ);
			}
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public readonly struct GOKBJJFGBMA : IBPCOKIOLBL.GHMEADBPKPI<APCJJMMLALP>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000099")]
		[CompilerGenerated]
		private struct GHLBOGJBBNO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public AsyncTaskMethodBuilder<MDDPJNIIBBI<object?, JHFNBJHGPJG>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public APCJJMMLALP root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public IKLALLBKLKC<KJCLJNBJCIN> clientId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public KDEPIGGKFKP action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public GOKBJJFGBMA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			private TaskAwaiter<MDDPJNIIBBI<object?, JHFNBJHGPJG>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600071F")]
			[Cpp2IlInjected.Address(RVA = "0x28BC690", Offset = "0x28BB290", VA = "0x1828BC690", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000720")]
			[Cpp2IlInjected.Address(RVA = "0x28BC900", Offset = "0x28BB500", VA = "0x1828BC900", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x28BCD20", Offset = "0x28BB920", VA = "0x1828BCD20", Slot = "4")]
		[AsyncStateMachine(typeof(GHLBOGJBBNO))]
		public Task<MDDPJNIIBBI<object, JHFNBJHGPJG>> BMDDJNJNMEG(APCJJMMLALP HMGDINOCJAI, IKLALLBKLKC<KJCLJNBJCIN> KPGHEBOCEPO, KDEPIGGKFKP IFDCDCHOGGB, bool DLHOJKLEPHP)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public readonly struct DDINCOMHMNP : DJGMKMFOACJ.HHGBPDJBAOO<APCJJMMLALP>
	{
		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x28B8B80", Offset = "0x28B7780", VA = "0x1828B8B80", Slot = "4")]
		public void FMHLIIJPBMA(APCJJMMLALP HMGDINOCJAI, IKLALLBKLKC<KJCLJNBJCIN> KPGHEBOCEPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0xE63E10", Offset = "0xE62A10", VA = "0x180E63E10", Slot = "5")]
		public IKLALLBKLKC<KJCLJNBJCIN>? DHMEPHJGOEN(APCJJMMLALP HMGDINOCJAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x28B8AF0", Offset = "0x28B76F0", VA = "0x1828B8AF0")]
		public IKLALLBKLKC<PEOCIBIIEAD> EGLPEDAPAND(APCJJMMLALP HMGDINOCJAI, IKLALLBKLKC<KJCLJNBJCIN> MPFBANPBMKI, [In] Guid? LMBLGALMBCI, POMGKDAAEIL OAJMKPFMDHN)
		{
			return default(IKLALLBKLKC<PEOCIBIIEAD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x28B8DC0", Offset = "0x28B79C0", VA = "0x1828B8DC0", Slot = "7")]
		public void NAMDIGENEPF(APCJJMMLALP HMGDINOCJAI, IKLALLBKLKC<KJCLJNBJCIN> KPGHEBOCEPO, IKLALLBKLKC<PEOCIBIIEAD> AEIJGHPBELE, LBKKIAJOPND MMJHOAALMOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x28B8C50", Offset = "0x28B7850", VA = "0x1828B8C50", Slot = "8")]
		public void LEFIFIKJFCO(APCJJMMLALP HMGDINOCJAI, IKLALLBKLKC<PEOCIBIIEAD> AEIJGHPBELE, LBKKIAJOPND MMJHOAALMOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x28B8E50", Offset = "0x28B7A50", VA = "0x1828B8E50", Slot = "9")]
		public void OBMKHNDJBJA(APCJJMMLALP HMGDINOCJAI, IKLALLBKLKC<KJCLJNBJCIN> KPGHEBOCEPO, IKLALLBKLKC<PEOCIBIIEAD> AEIJGHPBELE, LBKKIAJOPND MMJHOAALMOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x28B8C20", Offset = "0x28B7820", VA = "0x1828B8C20", Slot = "10")]
		public void HMBDBNJIFAJ(APCJJMMLALP HMGDINOCJAI, IKLALLBKLKC<KJCLJNBJCIN> KPGHEBOCEPO, IKLALLBKLKC<PEOCIBIIEAD> AEIJGHPBELE, LBKKIAJOPND MMJHOAALMOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x28B8EF0", Offset = "0x28B7AF0", VA = "0x1828B8EF0", Slot = "11")]
		public void ONEJEELEOKH(APCJJMMLALP HMGDINOCJAI, IKLALLBKLKC<KJCLJNBJCIN> KPGHEBOCEPO, IKLALLBKLKC<PEOCIBIIEAD> AEIJGHPBELE, MFIPBIHDJDC? OPHIIDBMNFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0x28B8BB0", Offset = "0x28B77B0", VA = "0x1828B8BB0", Slot = "12")]
		public IKLALLBKLKC<KJCLJNBJCIN>? GCJNFBIELFI(APCJJMMLALP HMGDINOCJAI, IKLALLBKLKC<PEOCIBIIEAD> AEIJGHPBELE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x28B8E90", Offset = "0x28B7A90", VA = "0x1828B8E90", Slot = "13")]
		public IKLALLBKLKC<DAOMKHHAECF> OHEMBKIMAGE(APCJJMMLALP HMGDINOCJAI, IKLALLBKLKC<KJCLJNBJCIN> KPGHEBOCEPO, string MEPFFFGIFGB, object IPOLOHBNCGD, BDPOBDGKMIM GDKPCBPPEHB, MHBJEMDFMIG NHLHEIFMCKA)
		{
			return default(IKLALLBKLKC<DAOMKHHAECF>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x28B8AC0", Offset = "0x28B76C0", VA = "0x1828B8AC0", Slot = "14")]
		public void AOLFMHAINBL(APCJJMMLALP HMGDINOCJAI, IKLALLBKLKC<KJCLJNBJCIN> KPGHEBOCEPO, IKLALLBKLKC<DAOMKHHAECF> DNAENMKKHIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x28B8B50", Offset = "0x28B7750", VA = "0x1828B8B50", Slot = "15")]
		public void FCJCAMGLNNI(APCJJMMLALP HMGDINOCJAI, IKLALLBKLKC<KJCLJNBJCIN> KPGHEBOCEPO, IKLALLBKLKC<DAOMKHHAECF> DNAENMKKHIN, object OOHGFGHCOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x28B8AF0", Offset = "0x28B76F0", VA = "0x1828B8AF0", Slot = "6")]
		private IKLALLBKLKC<PEOCIBIIEAD> HMIAKPBGDDH(APCJJMMLALP HMGDINOCJAI, IKLALLBKLKC<KJCLJNBJCIN> MPFBANPBMKI, [In] Guid? LMBLGALMBCI, POMGKDAAEIL OAJMKPFMDHN)
		{
			return default(IKLALLBKLKC<PEOCIBIIEAD>);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private struct FOJDHHFNMJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public AsyncTaskMethodBuilder<FCJGMOOJNHF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public APCJJMMLALP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public IKLALLBKLKC<PEOCIBIIEAD>? rootCV2Object;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public CKBGMGBEBCF deps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public FLOKGHAJACG registry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public GIKBFGHDOMK registryV2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CD8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private IKLALLBKLKC<KJCLJNBJCIN> <clientId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CE0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private DOINOKDAIBM<APCJJMMLALP, GOKBJJFGBMA> <staticNetSys>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CE8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private FOEEKKEAGCO<APCJJMMLALP, DDINCOMHMNP> <dynamicNetSys>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CF0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private CEGJGOPGACI <circuitsManager>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CF8")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x28BA120", Offset = "0x28B8D20", VA = "0x1828BA120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0x28BA780", Offset = "0x28B9380", VA = "0x1828BA780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly FIKKBFELHPF<KDEPIGGKFKP, BOFEABKGBFC, CEGJGOPGACI, KICAJCCFFLP, CEGJGOPGACI.MNOLDPDILIA, ONJGPLEMEIJ, APCJJMMLALP, BBFFGOPFHOF> EHGJEPMBILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly GEBNIDMHPDF DDJFHAPHPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private HHAPOFMILMM<KJCLJNBJCIN> EGNDLBOIPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private FKBNOJLBGKB<KJCLJNBJCIN, BOFEABKGBFC> FJMCGDCMIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private FKBNOJLBGKB<KJCLJNBJCIN, CEGJGOPGACI> NNEMPPOHEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private IKLALLBKLKC<KJCLJNBJCIN>? FAAGJKIBNHF;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public HPJFDLNNGLH HALFDLJLLJE
	{
		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0xA1FDD0", Offset = "0xA1E9D0", VA = "0x180A1FDD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(RVA = "0x28B6A60", Offset = "0x28B5660", VA = "0x1828B6A60")]
	public APCJJMMLALP(int CEAEMJMOKLA, int OIPPNLIINDM, int DNCOLHAEIHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x28B64F0", Offset = "0x28B50F0", VA = "0x1828B64F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x28B6330", Offset = "0x28B4F30", VA = "0x1828B6330")]
	[AsyncStateMachine(typeof(FOJDHHFNMJC))]
	public Task<FCJGMOOJNHF> BODFABNMNLK(CKBGMGBEBCF FCHJEFGMLNE, FLOKGHAJACG KBMDBHHDHON, GIKBFGHDOMK IOPIJJPKIHO, IKLALLBKLKC<PEOCIBIIEAD>? GFAMMIDKOKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0x28B66C0", Offset = "0x28B52C0", VA = "0x1828B66C0")]
	private void FMHLIIJPBMA(IKLALLBKLKC<KJCLJNBJCIN> KPGHEBOCEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x28B6980", Offset = "0x28B5580", VA = "0x1828B6980")]
	[CompilerGenerated]
	private IKLALLBKLKC<PEOCIBIIEAD>? KJLLCNCCEDO([In] Guid LMBLGALMBCI, POMGKDAAEIL OAJMKPFMDHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public sealed class PDPGILCCJEI : AANKPKALLNB.EHAACEBFNLM
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public delegate Task<AODMMLCNHOC> GEDBOCIHEAL(CEGJGOPGACI FADPJDENLPL, KPDBMCPPNNP GJBFENEFNGF, MLPCIEOMKOK? LFDNBPFFIGN, HFMEMLNGCBK? PFOCDOFJMIB, CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public delegate void AGPLONLFLLL();

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public delegate void ELOJHKJJAEK();

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private struct DHIOKBEKAPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public AsyncTaskMethodBuilder<AODMMLCNHOC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public PDPGILCCJEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public CEGJGOPGACI circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public KPDBMCPPNNP evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public MLPCIEOMKOK cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public HFMEMLNGCBK cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private TaskAwaiter<AODMMLCNHOC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x28B8FB0", Offset = "0x28B7BB0", VA = "0x1828B8FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0x28B91C0", Offset = "0x28B7DC0", VA = "0x1828B91C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly GEDBOCIHEAL ABMIKDCBPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly AGPLONLFLLL? MNKNDNPCDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly ELOJHKJJAEK? KCBKJCOGDGC;

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x28BDE80", Offset = "0x28BCA80", VA = "0x1828BDE80", Slot = "4")]
	[AsyncStateMachine(typeof(DHIOKBEKAPO))]
	public Task<AODMMLCNHOC> KGKFFLKAMJJ(CEGJGOPGACI FADPJDENLPL, KPDBMCPPNNP GJBFENEFNGF, MLPCIEOMKOK? LFDNBPFFIGN, HFMEMLNGCBK? PFOCDOFJMIB, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0xF0BFE0", Offset = "0xF0ABE0", VA = "0x180F0BFE0", Slot = "5")]
	public void GAIGKCFDAIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0xF79990", Offset = "0xF78590", VA = "0x180F79990", Slot = "6")]
	public void EODEEAKKCNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x28BE000", Offset = "0x28BCC00", VA = "0x1828BE000")]
	public PDPGILCCJEI([Optional] GEDBOCIHEAL? LEMAFGGCCGC, [Optional] AGPLONLFLLL? FIPNJOKMKLE, [Optional] ELOJHKJJAEK? ILDGPKNOIOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public sealed class BAGBAJACDDJ : DBOJBDPKOJN.JCBKFBPBICP
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public delegate AGBLIACJDJF HIFHFMLJBGD();

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public delegate Task<MLPCIEOMKOK> PHOIOHKNLND(CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public delegate Task<HFMEMLNGCBK> ECIGGOABLAH(CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public delegate Task<GEHEDKIHDCL> ANLEDGKPOKF(CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public delegate Task<GJJDHOBJLAA> ADKLCFPCEOF(CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public delegate Task<DBOJBDPKOJN.JCBKFBPBICP.KFHCGMLFJAH> ILDNOMEGNEI(CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public delegate Task<OFMCHDJIMIP> FCIBMOKOOPP(CancellationToken DKKNFNCKCEB);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private struct FEOAPPKAOBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public AsyncTaskMethodBuilder<MLPCIEOMKOK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public BAGBAJACDDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private TaskAwaiter<MLPCIEOMKOK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x28B9C60", Offset = "0x28B8860", VA = "0x1828B9C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x28B9E50", Offset = "0x28B8A50", VA = "0x1828B9E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private struct MCLLGIMKKDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public AsyncTaskMethodBuilder<HFMEMLNGCBK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public BAGBAJACDDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private TaskAwaiter<HFMEMLNGCBK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x28BD470", Offset = "0x28BC070", VA = "0x1828BD470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x28BD660", Offset = "0x28BC260", VA = "0x1828BD660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct EJPMNLGHJNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public AsyncTaskMethodBuilder<GEHEDKIHDCL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public BAGBAJACDDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private TaskAwaiter<GEHEDKIHDCL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x28B9960", Offset = "0x28B8560", VA = "0x1828B9960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x28B9B50", Offset = "0x28B8750", VA = "0x1828B9B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct NFCIGPFDBHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public AsyncTaskMethodBuilder<GJJDHOBJLAA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public BAGBAJACDDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private TaskAwaiter<GJJDHOBJLAA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x28BD6D0", Offset = "0x28BC2D0", VA = "0x1828BD6D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x28BD8C0", Offset = "0x28BC4C0", VA = "0x1828BD8C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct FFAKELHCGMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public AsyncTaskMethodBuilder<DBOJBDPKOJN.JCBKFBPBICP.KFHCGMLFJAH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public BAGBAJACDDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private TaskAwaiter<DBOJBDPKOJN.JCBKFBPBICP.KFHCGMLFJAH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x28B9EC0", Offset = "0x28B8AC0", VA = "0x1828B9EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x28BA0B0", Offset = "0x28B8CB0", VA = "0x1828BA0B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct CPGIKPOGLIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public AsyncTaskMethodBuilder<OFMCHDJIMIP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public BAGBAJACDDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private TaskAwaiter<OFMCHDJIMIP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x28B8860", Offset = "0x28B7460", VA = "0x1828B8860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x28B8A50", Offset = "0x28B7650", VA = "0x1828B8A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly HIFHFMLJBGD BHMCOCIJKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly PHOIOHKNLND KLKGGFGLIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly ECIGGOABLAH OPACNFHDHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private readonly ANLEDGKPOKF KGPENGCBCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private readonly ADKLCFPCEOF MNFFGIMNKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly ILDNOMEGNEI KNDIJHGNCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly FCIBMOKOOPP IAKCEAAFOHC;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public AGBLIACJDJF GGLLPNPEDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x11564B0", Offset = "0x11550B0", VA = "0x1811564B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0x28B6DF0", Offset = "0x28B59F0", VA = "0x1828B6DF0", Slot = "5")]
	[AsyncStateMachine(typeof(FEOAPPKAOBH))]
	public Task<MLPCIEOMKOK> DHJFDFECJNJ(CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000743")]
	[Cpp2IlInjected.Address(RVA = "0x28B7340", Offset = "0x28B5F40", VA = "0x1828B7340", Slot = "6")]
	[AsyncStateMachine(typeof(MCLLGIMKKDI))]
	public Task<HFMEMLNGCBK> NGCEEMONCEC(CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x28B7120", Offset = "0x28B5D20", VA = "0x1828B7120", Slot = "7")]
	[AsyncStateMachine(typeof(EJPMNLGHJNM))]
	public Task<GEHEDKIHDCL> FNGLNNAGDHP(CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x28B7230", Offset = "0x28B5E30", VA = "0x1828B7230", Slot = "8")]
	[AsyncStateMachine(typeof(NFCIGPFDBHD))]
	public Task<GJJDHOBJLAA> HDLLPIOKBMO(CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000746")]
	[Cpp2IlInjected.Address(RVA = "0x28B6F00", Offset = "0x28B5B00", VA = "0x1828B6F00", Slot = "9")]
	[AsyncStateMachine(typeof(FFAKELHCGMG))]
	public Task<DBOJBDPKOJN.JCBKFBPBICP.KFHCGMLFJAH> DMJMHFFHHAH(CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x28B7010", Offset = "0x28B5C10", VA = "0x1828B7010", Slot = "10")]
	[AsyncStateMachine(typeof(CPGIKPOGLIM))]
	public Task<OFMCHDJIMIP> EMBAEGJBMMP(CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0x28B7450", Offset = "0x28B6050", VA = "0x1828B7450")]
	public BAGBAJACDDJ(HIFHFMLJBGD PMCFABAIPLD, [Optional] PHOIOHKNLND? GGONDPOJJEM, [Optional] ECIGGOABLAH? CKFBGGKMEDK, [Optional] ANLEDGKPOKF? DFALLPKBNAC, [Optional] ADKLCFPCEOF? IAOOMKOICHK, [Optional] ILDNOMEGNEI? HEAILELPIDA, [Optional] FCIBMOKOOPP? AJKKKCLPFKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public sealed class LBJEELFHMML : ANJICKJOEAP.HMHKIFINHPF
{
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public delegate bool GBOLLKOKANO();

	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public static readonly ANJICKJOEAP.HMHKIFINHPF LBPNLDGACAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private readonly GBOLLKOKANO MMKFDCGCPAL;

	[Cpp2IlInjected.Token(Token = "0x600076B")]
	[Cpp2IlInjected.Address(RVA = "0xA2B6C0", Offset = "0xA2A2C0", VA = "0x180A2B6C0")]
	public LBJEELFHMML(GBOLLKOKANO HBGCNKMNMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076C")]
	[Cpp2IlInjected.Address(RVA = "0x11564B0", Offset = "0x11550B0", VA = "0x1811564B0", Slot = "4")]
	public bool POAADFJOLME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public sealed class CKEJPJAAFHI : EOMCLJMENNP
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public delegate bool IBPKJLPLPAE([In] MDDPJNIIBBI<BOFEABKGBFC, EFKBKOGFPPJ> DBJBIPJCIKA);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly IBPKJLPLPAE DCOJNAIPLMP;

	[Cpp2IlInjected.Token(Token = "0x6000773")]
	[Cpp2IlInjected.Address(RVA = "0x28B8270", Offset = "0x28B6E70", VA = "0x1828B8270")]
	public bool PFFEBEOCOBN([In] MDDPJNIIBBI<BOFEABKGBFC, EFKBKOGFPPJ> DBJBIPJCIKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000774")]
	[Cpp2IlInjected.Address(RVA = "0x28B8670", Offset = "0x28B7270", VA = "0x1828B8670")]
	public CKEJPJAAFHI([Optional] IBPKJLPLPAE? HEBLFIOHLJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000775")]
	[Cpp2IlInjected.Address(RVA = "0x28B8270", Offset = "0x28B6E70", VA = "0x1828B8270", Slot = "4")]
	private bool EIPCHBFKAMG([In] MDDPJNIIBBI<BOFEABKGBFC, EFKBKOGFPPJ> DBJBIPJCIKA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public sealed class BGPPBJCMCGG : FNLPNDAMBLP
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public delegate CMLIDFCPMDK MDAAIEPOJIA();

	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public static readonly BGPPBJCMCGG LBPNLDGACAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly MDAAIEPOJIA? KGMKPADACCM;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public CMLIDFCPMDK NDNNPIFADDP
	{
		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x11564B0", Offset = "0x11550B0", VA = "0x1811564B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600077C")]
	[Cpp2IlInjected.Address(RVA = "0xA2B6C0", Offset = "0xA2A2C0", VA = "0x180A2B6C0")]
	public BGPPBJCMCGG([Optional] MDAAIEPOJIA? ACDMHBPEOMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public sealed class CECIMAOFFHO : OHBJGBFOGON
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public delegate ILOKKGKPOAO JBBOOKJAEEB(int KAHBCHHNKHP);

	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public static readonly OHBJGBFOGON LBPNLDGACAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly JBBOOKJAEEB KDHONGIOMPL;

	[Cpp2IlInjected.Token(Token = "0x6000780")]
	[Cpp2IlInjected.Address(RVA = "0x28B8270", Offset = "0x28B6E70", VA = "0x1828B8270", Slot = "4")]
	public ILOKKGKPOAO MBBMCIMJPDI(int KAHBCHHNKHP)
	{
		return default(ILOKKGKPOAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000781")]
	[Cpp2IlInjected.Address(RVA = "0x28B8310", Offset = "0x28B6F10", VA = "0x1828B8310")]
	public CECIMAOFFHO([Optional] JBBOOKJAEEB? BMLBHJBHGIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public sealed class DIHGAFECJKL : GGLGNLCNJOA
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public delegate Task<bool> BOKFBKLIHHL(string OOHGFGHCOAJ, string CBLPKFIJGLH);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct EEFJDOOKOKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public DIHGAFECJKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public string context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x28B9700", Offset = "0x28B8300", VA = "0x1828B9700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x28B98F0", Offset = "0x28B84F0", VA = "0x1828B98F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly BOKFBKLIHHL ECNFBCBPOAL;

	[Cpp2IlInjected.Token(Token = "0x6000788")]
	[Cpp2IlInjected.Address(RVA = "0x28B9230", Offset = "0x28B7E30", VA = "0x1828B9230", Slot = "4")]
	[AsyncStateMachine(typeof(EEFJDOOKOKN))]
	public Task<bool> PGFEHGLKPGL(string OOHGFGHCOAJ, string CBLPKFIJGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000789")]
	[Cpp2IlInjected.Address(RVA = "0x28B9370", Offset = "0x28B7F70", VA = "0x1828B9370")]
	public DIHGAFECJKL([Optional] BOKFBKLIHHL? LEMCIIKKFII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public sealed class NHLAPEPPLFC : BDEMBJKFECE
{
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public delegate EGECICAOENN? EEKPMKEJKDA([In] BMAAMMAFHBI<DHCEMECNKGP> KNMCNCMHIOL);

	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public static readonly BDEMBJKFECE LBPNLDGACAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly EEKPMKEJKDA DJHHKMJDOGI;

	[Cpp2IlInjected.Token(Token = "0x6000791")]
	[Cpp2IlInjected.Address(RVA = "0x28B8270", Offset = "0x28B6E70", VA = "0x1828B8270")]
	public EGECICAOENN? KNPMLGFEOHF([In] BMAAMMAFHBI<DHCEMECNKGP> KNMCNCMHIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000792")]
	[Cpp2IlInjected.Address(RVA = "0x28BD9A0", Offset = "0x28BC5A0", VA = "0x1828BD9A0")]
	public NHLAPEPPLFC([Optional] EEKPMKEJKDA? LECJHNCFGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000794")]
	[Cpp2IlInjected.Address(RVA = "0x28B8270", Offset = "0x28B6E70", VA = "0x1828B8270", Slot = "4")]
	private EGECICAOENN KHFGIMPKFEG([In] BMAAMMAFHBI<DHCEMECNKGP> KNMCNCMHIOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public sealed class BFPMPIMLPML : OJFNABHEOEI
{
	[Cpp2IlInjected.Token(Token = "0x600079A")]
	[Cpp2IlInjected.Address(RVA = "0x28B81A0", Offset = "0x28B6DA0", VA = "0x1828B81A0", Slot = "4")]
	public CCJFMGLJLNC GCMEBIFCHAK(string LAOCJKNALFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600079B")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public BFPMPIMLPML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public sealed class AHNPFIFEIFL : MMPMLBHHOLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private readonly Dictionary<string, bool> DKHABFOPKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private readonly Dictionary<string, float> LCGNNFFPCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private readonly Dictionary<string, double> PIGHCMAOMFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private readonly Dictionary<string, int> NJHLMAOFGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private readonly Dictionary<string, long> ODDKEGAJCCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private readonly Dictionary<string, string> NKAFONAPIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private readonly Dictionary<string, uint> PGLGEJDAHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly Dictionary<string, ulong> CJIEBFEEKJE;

	[Cpp2IlInjected.Token(Token = "0x600079C")]
	[Cpp2IlInjected.Address(RVA = "0x28B5FE0", Offset = "0x28B4BE0", VA = "0x1828B5FE0", Slot = "4")]
	public bool? KBEEOFBNPGJ(string MEPFFFGIFGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0x28B6080", Offset = "0x28B4C80", VA = "0x1828B6080")]
	public AHNPFIFEIFL()
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
