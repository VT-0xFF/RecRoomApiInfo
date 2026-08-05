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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x27F6100", Offset = "0x27F5300", VA = "0x1827F6100")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1B770", Offset = "0xA1A970", VA = "0x180A1B770")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B7B0", Offset = "0xA1A9B0", VA = "0x180A1B7B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class ABNHKLCEBJK<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> : IDisposable where TAction : notnull where TNetSys : notnull where TReceiver : notnull where TActionDeps : notnull, AMPKJOMLEIF.CDIHPBHLCKH<TAction, TNetSys> where TReceiverDeps : notnull, AMPKJOMLEIF.CAOPBFGGNPI<TAction, TReceiver> where TRootDeps : notnull, AMPKJOMLEIF.BPPIPJJOBKG<LEAHEMLIEJA, TAction, TRoot> where TRoot : notnull where TDeps : notnull, AMPKJOMLEIF.PCPOEDNHOEP<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal sealed class DCFBBLBGMGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal int? DLKDJAHKIJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal readonly List<KFJCNFOBGBJ<TAction>> NOEPBDKNAOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal bool IFOHEMGONPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly List<Func<Task>> JOPALPAPAGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal bool JMKNPOHJLHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal TAction[]? ENLLJHAFBKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly HBDKECLCAAL<LEAHEMLIEJA, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> NGEKNNDKFGC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		internal bool JBFNJAHJABO
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x69D4E60", Offset = "0x69D4060", VA = "0x1869D4E60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x69D53B0", Offset = "0x69D45B0", VA = "0x1869D53B0")]
		public DCFBBLBGMGM(int? HOCIGIPOMEK, List<KFJCNFOBGBJ<TAction>> HNDNOGAHKBJ, bool KMAJLDOHHME, List<Func<Task>> LKDAABLJEMJ, bool JBNBHOMBPKH, TAction[]? BDHIFNBNKFC, HBDKECLCAAL<LEAHEMLIEJA, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> LJPGHHICBDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x69D5130", Offset = "0x69D4330", VA = "0x1869D5130")]
		public static ABNHKLCEBJK<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps>.DCFBBLBGMGM OIKMHICCLEP(TDeps POLANHDJCNH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class NDOCJLNAMJE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct <<SendActionToAll>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NDOCJLNAMJE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private TaskCompletionSource<LOAMJJJEMNF<object?, PLLHOMFPAAM>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private TaskAwaiter<LOAMJJJEMNF<object, PLLHOMFPAAM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x40C53C0", Offset = "0x40C45C0", VA = "0x1840C53C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x40C5770", Offset = "0x40C4970", VA = "0x1840C5770", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public DCFBBLBGMGM client;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public TNetSys sender;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public JFIBBLJIDCN<MCGHCCOIFPD> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TaskCompletionSource<LOAMJJJEMNF<object?, PLLHOMFPAAM>> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public TAction actionCopy;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public NDOCJLNAMJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x537F650", Offset = "0x537E850", VA = "0x18537F650")]
		[AsyncStateMachine(typeof(ABNHKLCEBJK<, , , , , , , >.NDOCJLNAMJE.<<SendActionToAll>b__0>d))]
		internal Task KCOLEPKJIHE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct KAKFLNHBDKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public ABNHKLCEBJK<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public JFIBBLJIDCN<MCGHCCOIFPD> receiverId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public JFIBBLJIDCN<MCGHCCOIFPD> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public JFIBBLJIDCN<LEAHEMLIEJA> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private TaskAwaiter<LOAMJJJEMNF<object, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4FD0F80", Offset = "0x4FD0180", VA = "0x184FD0F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4FD1930", Offset = "0x4FD0B30", VA = "0x184FD1930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private KGAPBMDBEOB<MCGHCCOIFPD, DCFBBLBGMGM> LHBCLMNLDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly List<KFJCNFOBGBJ<TAction>> DHOMELBCHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly int LJOECMJCKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly int KAKGKFNGFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly int KBOCDHKOHCP;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4A26950", Offset = "0x4A25B50", VA = "0x184A26950")]
	public ABNHKLCEBJK(int OJDIFOBLNLA, int PNLCCMNDPCD, int CHOBAMJGEKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4A26280", Offset = "0x4A25480", VA = "0x184A26280", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4A26340", Offset = "0x4A25540", VA = "0x184A26340")]
	public void EICICKBJAMO(JFIBBLJIDCN<MCGHCCOIFPD> IHOGKNBNKOF, TDeps POLANHDJCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4A26410", Offset = "0x4A25610", VA = "0x184A26410")]
	public void JICMOHNNIPN(JFIBBLJIDCN<MCGHCCOIFPD> IHOGKNBNKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4A263C0", Offset = "0x4A255C0", VA = "0x184A263C0")]
	public void JAJPHOKINBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4A256A0", Offset = "0x4A248A0", VA = "0x184A256A0")]
	public (Task, Task[]) CAKBFEHCGDJ(TRoot FHPKLENNKKO, [In] DHEEBEEFOLH<MCGHCCOIFPD> CBBNIFLCCLA, [In] KGAPBMDBEOB<MCGHCCOIFPD, TNetSys> CBNAIFAPKEP, [In] KGAPBMDBEOB<MCGHCCOIFPD, TReceiver> OCJMKBIHPGE, JFIBBLJIDCN<MCGHCCOIFPD> IFJLLOBDJLG, JFIBBLJIDCN<LEAHEMLIEJA> ECNLOCBECHF, TAction HDKINMMJOHF)
	{
		return default((Task, Task[]));
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4A253F0", Offset = "0x4A245F0", VA = "0x184A253F0")]
	public Task<LOAMJJJEMNF<object, PLLHOMFPAAM>> CAKBFEHCGDJ(TRoot FHPKLENNKKO, TNetSys NEGFBCIAAFG, JFIBBLJIDCN<MCGHCCOIFPD> IFJLLOBDJLG, TAction HDKINMMJOHF, bool LKDKFJKIIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4A252A0", Offset = "0x4A244A0", VA = "0x184A252A0")]
	[AsyncStateMachine(typeof(ABNHKLCEBJK<, , , , , , , >.KAKFLNHBDKM))]
	public Task BHMCMMFFJBJ(TRoot FHPKLENNKKO, TNetSys MLNADCBAOPC, TReceiver IJKONPKDHEA, JFIBBLJIDCN<MCGHCCOIFPD> OBBEBDEFABG, JFIBBLJIDCN<MCGHCCOIFPD> IFJLLOBDJLG, JFIBBLJIDCN<LEAHEMLIEJA> ECNLOCBECHF, TAction HDKINMMJOHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4A266C0", Offset = "0x4A258C0", VA = "0x184A266C0")]
	public Task NNMDLCAPNJM(TRoot FHPKLENNKKO, TNetSys MLNADCBAOPC, TReceiver IJKONPKDHEA, JFIBBLJIDCN<MCGHCCOIFPD> OBBEBDEFABG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal readonly struct KFJCNFOBGBJ<TAction> where TAction : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly JFIBBLJIDCN<MCGHCCOIFPD> LDKNCDGDNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly JFIBBLJIDCN<LEAHEMLIEJA> GBGDOPCCJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly TAction DPLFFABLIAC;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xC21700", Offset = "0xC20900", VA = "0x180C21700")]
	public KFJCNFOBGBJ(JFIBBLJIDCN<MCGHCCOIFPD> NAJOEFDLOFP, JFIBBLJIDCN<LEAHEMLIEJA> ECNLOCBECHF, TAction HDKINMMJOHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class ACFIDNEDEKK
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x40128C0", Offset = "0x4011AC0", VA = "0x1840128C0")]
	public static KFJCNFOBGBJ<TAction> OIKMHICCLEP<TAction>(JFIBBLJIDCN<MCGHCCOIFPD> NAJOEFDLOFP, JFIBBLJIDCN<LEAHEMLIEJA> ECNLOCBECHF, TAction HDKINMMJOHF) where TAction : notnull
	{
		return default(KFJCNFOBGBJ<TAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class HLACLLCCCGB<TRoot, TDeps> : FILIDBMOPNM where TRoot : notnull where TDeps : notnull, NDNIHAPLOHG.OAFBIDPGAGI<TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct MHIAHCHALFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<object?, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public HLACLLCCCGB<TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AGKENLKLGLL action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<LOAMJJJEMNF<object?, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x52DE400", Offset = "0x52DD600", VA = "0x1852DE400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x52DEA70", Offset = "0x52DDC70", VA = "0x1852DEA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly TDeps MPDDJFAHINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly TRoot OFDIECEGEIJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public JFIBBLJIDCN<MCGHCCOIFPD> FPOJLMCJKBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xBFD840", Offset = "0xBFCA40", VA = "0x180BFD840")]
		[CompilerGenerated]
		get
		{
			return default(JFIBBLJIDCN<MCGHCCOIFPD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2C98A30", Offset = "0x2C97C30", VA = "0x182C98A30")]
	public HLACLLCCCGB(TDeps POLANHDJCNH, TRoot FHPKLENNKKO, JFIBBLJIDCN<MCGHCCOIFPD> GJKLKMPDMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4BA3520", Offset = "0x4BA2720", VA = "0x184BA3520", Slot = "4")]
	[AsyncStateMachine(typeof(HLACLLCCCGB<, >.MHIAHCHALFN))]
	public Task<LOAMJJJEMNF<object, PLLHOMFPAAM>> CAKBFEHCGDJ(AGKENLKLGLL HDKINMMJOHF, bool LKDKFJKIIAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class NDNIHAPLOHG
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface OAFBIDPGAGI<TRoot> where TRoot : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<LOAMJJJEMNF<object, PLLHOMFPAAM>> CAKBFEHCGDJ(TRoot FHPKLENNKKO, JFIBBLJIDCN<MCGHCCOIFPD> IFJLLOBDJLG, AGKENLKLGLL HDKINMMJOHF, bool LKDKFJKIIAP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class OCBHOOAGCGG : DPALLJMMHEO
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate void HBHNPJNAPAL();

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly OCBHOOAGCGG NDDGJHHDBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly HBHNPJNAPAL? LGILEGPECML;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
	public OCBHOOAGCGG([Optional] HBHNPJNAPAL? HOBDBJAACEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x11579E0", Offset = "0x1156BE0", VA = "0x1811579E0", Slot = "4")]
	public void KABPPJCIIMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class PJGNCELNAIG : DFPLLPJKOKN
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate void MKKMMNMIGKJ(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<KLMHALNMEAA> KHHBPMLEJLG, JFIBBLJIDCN<PFJDLPPNNBM> FMIMEMJAMNF);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void FFHNFPDGDAB(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<KLMHALNMEAA> KHHBPMLEJLG, JFIBBLJIDCN<PFJDLPPNNBM> FMIMEMJAMNF);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void FMHKCHAGDIK(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL);

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly PJGNCELNAIG NDDGJHHDBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly MKKMMNMIGKJ? CNKLJBIDDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly FFHNFPDGDAB? LAHOPACIAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly FMHKCHAGDIK? MCACCHLBOKI;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xC40420", Offset = "0xC3F620", VA = "0x180C40420")]
	public PJGNCELNAIG([Optional] MKKMMNMIGKJ? NGEBMHIAONO, [Optional] FFHNFPDGDAB? ECOJDDOLNDF, [Optional] FMHKCHAGDIK? EMBCKFGENBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x27F6220", Offset = "0x27F5420", VA = "0x1827F6220", Slot = "4")]
	public void OnEdgeDidAdd(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<KLMHALNMEAA> KHHBPMLEJLG, JFIBBLJIDCN<PFJDLPPNNBM> FMIMEMJAMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x27F6240", Offset = "0x27F5440", VA = "0x1827F6240", Slot = "5")]
	public void OnEdgeWillRemove(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<KLMHALNMEAA> KHHBPMLEJLG, JFIBBLJIDCN<PFJDLPPNNBM> FMIMEMJAMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x27F6200", Offset = "0x27F5400", VA = "0x1827F6200", Slot = "6")]
	public void IHHOODOKMIB(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "7")]
	public void OnFunctionDeclsRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "8")]
	public void OnObjectPropertiesRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "9")]
	public void OnEditGraphDidPush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "10")]
	public void OnEditGraphDidPop()
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
