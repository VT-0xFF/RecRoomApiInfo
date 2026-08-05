using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Circuits.Shared.Api;
using Circuits.Static.Api;
using Cpp2IlInjected;
using Google.Protobuf;
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
		[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
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
		[Cpp2IlInjected.Address(RVA = "0x211D730", Offset = "0x211C130", VA = "0x18211D730")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C2AE0", Offset = "0x8C14E0", VA = "0x1808C2AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C2B20", Offset = "0x8C1520", VA = "0x1808C2B20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class PLLOHOJACCG : IDisposable, DLPCJMEMPFO, OCNNNJPGAAN, MJJPAOOPBDL, DEIPMMOAOLM
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class KMEMHDOIKMO : KNELNOGLGKD
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int PMKBNOMCCJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2110030", Offset = "0x210EA30", VA = "0x182110030", Slot = "5")]
		public OJBFNKHJHCH DFIKNDGDOCE(JHLIMPAJNBN.EJAJLDBKNGE LAKCFHGOLJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void IIODCOCIBFL();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void NAMBEJDKPGM();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2110180", Offset = "0x210EB80", VA = "0x182110180", Slot = "13")]
		public virtual void IBEDCEFHOBK(PLLOHOJACCG PFCDDIODGEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x21101C0", Offset = "0x210EBC0", VA = "0x1821101C0", Slot = "14")]
		public virtual void NODKBPMCPAF(PLLOHOJACCG PFCDDIODGEJ, EHDCBMKEILE PMCMEAHOBEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		protected KMEMHDOIKMO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface KNELNOGLGKD
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int PMKBNOMCCJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		OJBFNKHJHCH DFIKNDGDOCE(JHLIMPAJNBN.EJAJLDBKNGE LAKCFHGOLJA);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void IIODCOCIBFL();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NAMBEJDKPGM();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void IBEDCEFHOBK(PLLOHOJACCG PFCDDIODGEJ);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void NODKBPMCPAF(PLLOHOJACCG PFCDDIODGEJ, EHDCBMKEILE PMCMEAHOBEF);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct DEHNGPNNFGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly POKNCEFGIAN<MFOMNBGIJJE, EHDCBMKEILE, PLLOHOJACCG, KOAFOGCPACB.IIALHHDPMEC<MFOMNBGIJJE, EHDCBMKEILE, PLLOHOJACCG>> GLLFIKGKNOL;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2106D20", Offset = "0x2105720", VA = "0x182106D20")]
		internal DEHNGPNNFGA(POKNCEFGIAN<MFOMNBGIJJE, EHDCBMKEILE, PLLOHOJACCG, KOAFOGCPACB.IIALHHDPMEC<MFOMNBGIJJE, EHDCBMKEILE, PLLOHOJACCG>> BDPEMHOFOHC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class PPLMCELFGHJ : KOAFOGCPACB.IIALHHDPMEC<MFOMNBGIJJE, EHDCBMKEILE, PLLOHOJACCG>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly PPLMCELFGHJ DFEEMNKDOMA;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		private PPLMCELFGHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1285810", Offset = "0x1284210", VA = "0x181285810", Slot = "4")]
		public MFOMNBGIJJE MJPAOJNCCOI(EHDCBMKEILE BJNJBGHPMEH)
		{
			return default(MFOMNBGIJJE);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2121C40", Offset = "0x2120640", VA = "0x182121C40", Slot = "5")]
		public void IBEDCEFHOBK(PLLOHOJACCG JPBBEMPIGCM, EHDCBMKEILE PMCMEAHOBEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2121D50", Offset = "0x2120750", VA = "0x182121D50", Slot = "6")]
		public void NODKBPMCPAF(PLLOHOJACCG JPBBEMPIGCM, EHDCBMKEILE PMCMEAHOBEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct PLIJHIBCDME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public NLEPKENBEGE<MFOMNBGIJJE, EHDCBMKEILE, PLLOHOJACCG, KOAFOGCPACB.IIALHHDPMEC<MFOMNBGIJJE, EHDCBMKEILE, PLLOHOJACCG>> GLLFIKGKNOL;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2120150", Offset = "0x211EB50", VA = "0x182120150")]
		internal PLIJHIBCDME(NLEPKENBEGE<MFOMNBGIJJE, EHDCBMKEILE, PLLOHOJACCG, KOAFOGCPACB.IIALHHDPMEC<MFOMNBGIJJE, EHDCBMKEILE, PLLOHOJACCG>> BDPEMHOFOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2120100", Offset = "0x211EB00", VA = "0x182120100")]
		public static PLIJHIBCDME GGBAHLJJLHO()
		{
			return default(PLIJHIBCDME);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct CAEGIKPGPBM : CLPIGHBJMNE.DGPLBPMJBOM<EHDCBMKEILE, PLLOHOJACCG>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct AFOHIMCCLHM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<BCLNLKLFCPB<object, OBJIPJOMIPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public PLLOHOJACCG receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public EHDCBMKEILE action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public CAEGIKPGPBM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<BCLNLKLFCPB<object, OBJIPJOMIPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x21053D0", Offset = "0x2103DD0", VA = "0x1821053D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x21055B0", Offset = "0x2103FB0", VA = "0x1821055B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x999D80", Offset = "0x998780", VA = "0x180999D80", Slot = "4")]
		public MJGAEDNBJIL<DGAGHFGMOJF> BFBMLNJPCMD(PLLOHOJACCG PHPEHEJEKBD)
		{
			return default(MJGAEDNBJIL<DGAGHFGMOJF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x21062F0", Offset = "0x2104CF0", VA = "0x1821062F0", Slot = "5")]
		[AsyncStateMachine(typeof(AFOHIMCCLHM))]
		public Task<BCLNLKLFCPB<object, OBJIPJOMIPB>> IHEJBKOPHKO(PLLOHOJACCG PHPEHEJEKBD, EHDCBMKEILE PMCMEAHOBEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x21062D0", Offset = "0x2104CD0", VA = "0x1821062D0", Slot = "6")]
		public EHDCBMKEILE[] BGMEACEJGHE(PLLOHOJACCG PHPEHEJEKBD)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct LKJDGPPOELK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<bool, OBJIPJOMIPB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public PLLOHOJACCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public FMGJMILCPFK rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public FAOKMGJAJIO circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public PIKJJPNAMNM superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<BCLNLKLFCPB<bool, OBJIPJOMIPB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x21107B0", Offset = "0x210F1B0", VA = "0x1821107B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2110A30", Offset = "0x210F430", VA = "0x182110A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct HCPBFOHBKPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<bool, OBJIPJOMIPB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public PLLOHOJACCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<BCLNLKLFCPB<bool, OBJIPJOMIPB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x210D100", Offset = "0x210BB00", VA = "0x18210D100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x210D390", Offset = "0x210BD90", VA = "0x18210D390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct BOHEJEHIIDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public PLLOHOJACCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2105E40", Offset = "0x2104840", VA = "0x182105E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2106020", Offset = "0x2104A20", VA = "0x182106020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct CPIALKKNGJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<object, OBJIPJOMIPB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public PLLOHOJACCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public EHDCBMKEILE action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<BCLNLKLFCPB<object, OBJIPJOMIPB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2106A40", Offset = "0x2105440", VA = "0x182106A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2106C30", Offset = "0x2105630", VA = "0x182106C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct IJOOPHECDMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public PLLOHOJACCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<BCLNLKLFCPB<bool, OBJIPJOMIPB>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x210E8C0", Offset = "0x210D2C0", VA = "0x18210E8C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x210F0B0", Offset = "0x210DAB0", VA = "0x18210F0B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly MJGAEDNBJIL<DGAGHFGMOJF> MLEIKHIFCFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly DEHNGPNNFGA KEANMMCADCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly LJLLJGHEMHE BGEIKICNAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly CIGMMIPGINP ONGGECIHOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1930")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly NBIGEKGGIIN CNJJPMICPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1938")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly JKIEPPIEFOF.OJMGCGLDOGB ABNMOKCCCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1958")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly DGDFFMBNFNB MGGGNDNDDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1960")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly IIHNNAADMDI OILPFNADDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1968")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly ADNIMPJIPFG CMGFIPLKHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1970")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly ABHABACPDFJ KIMNJDKCFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1978")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EFGKIDLCFBA IFDMALMDFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1988")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private EEAOBHNHAIM NEFKPAGNJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19A8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly LJLLJGHEMHE.HDAOBPPIKJL OJFNEFONAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19B0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly PIPALGAAPKG BCPOBGJLMOO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public LJLLJGHEMHE GBCNBFOFNDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x21206C0", Offset = "0x211F0C0", VA = "0x1821206C0")]
		get
		{
			return default(LJLLJGHEMHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal KNELNOGLGKD DMLMFAPENCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2120160", Offset = "0x211EB60", VA = "0x182120160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal OJBFNKHJHCH GDJNODCIJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2121300", Offset = "0x211FD00", VA = "0x182121300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2121310", Offset = "0x211FD10", VA = "0x182121310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool HHIAIJOFCNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x21201B0", Offset = "0x211EBB0", VA = "0x1821201B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2120B10", Offset = "0x211F510", VA = "0x182120B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public JMBJIHIFOEL CBAKPOBFHNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2121950", Offset = "0x2120350", VA = "0x182121950", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public PLDGKJKJCEC LCJEKJKHDLG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2121960", Offset = "0x2120360", VA = "0x182121960", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public BJFBDBECAIA NMJBIKBNKMG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2121980", Offset = "0x2120380", VA = "0x182121980", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public GGMNELLKHNA MHOOAKGIGGE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2121970", Offset = "0x2120370", VA = "0x182121970", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public JKIEPPIEFOF? MMFCBCMFCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x21208C0", Offset = "0x211F2C0", VA = "0x1821208C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private HBLCNEAHKAK? BAGDLOECDBO
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x21211D0", Offset = "0x211FBD0", VA = "0x1821211D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2121650", Offset = "0x2120050", VA = "0x182121650")]
	private PLLOHOJACCG(NBIGEKGGIIN JANHEKCDHCN, MJGAEDNBJIL<DGAGHFGMOJF> GPABCNEPJFA, [In] DEHNGPNNFGA FDLPDEBGHNI, [In] LJLLJGHEMHE JOPCNIPBKEB, [In] CIGMMIPGINP JPMBCNNCLID, OJBFNKHJHCH IJIOOJOJNKF, [In] JKIEPPIEFOF.OJMGCGLDOGB BNJMLECIFEF, LJLLJGHEMHE.HDAOBPPIKJL OKNKPLFKPIN, PIPALGAAPKG BNHGPCJAJHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2120B20", Offset = "0x211F520", VA = "0x182120B20")]
	public static PLLOHOJACCG GGBAHLJJLHO(NBIGEKGGIIN LAKCFHGOLJA, [In] BOINMCIHAAD NMOECFNPPHJ, OOHDFMGLDIM CHPHADCPDAG, [In] NECIBONMLNB IAMIHFLPIMK, CLPHICCIMEB NNPFNOHKMEF, MJGAEDNBJIL<DGAGHFGMOJF> GPABCNEPJFA, MJGAEDNBJIL<HEPDKFCJLKH> MHELALCCLJM, HINPPEJFHLF NIHEKDKBACI, FMIDKBNAEHK OMOEJECMNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2120C60", Offset = "0x211F660", VA = "0x182120C60")]
	public static PLLOHOJACCG GGBAHLJJLHO(NBIGEKGGIIN JANHEKCDHCN, [In] LJLLJGHEMHE JOPCNIPBKEB, [In] CIGMMIPGINP JPMBCNNCLID, MJGAEDNBJIL<DGAGHFGMOJF> GPABCNEPJFA, MJGAEDNBJIL<HEPDKFCJLKH> MHELALCCLJM, HINPPEJFHLF NIHEKDKBACI, FMIDKBNAEHK OMOEJECMNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x21206D0", Offset = "0x211F0D0", VA = "0x1821206D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x21209B0", Offset = "0x211F3B0", VA = "0x1821209B0")]
	[AsyncStateMachine(typeof(LKJDGPPOELK))]
	internal Task<BCLNLKLFCPB<bool, OBJIPJOMIPB>> FNHGHMJDOFH(FMGJMILCPFK NCIIFBLDHLJ, FAOKMGJAJIO BDKIHOIIFHL, PIKJJPNAMNM FFHNFKPFGJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2121330", Offset = "0x211FD30", VA = "0x182121330")]
	[AsyncStateMachine(typeof(HCPBFOHBKPB))]
	public Task<BCLNLKLFCPB<bool, OBJIPJOMIPB>> KFIFOIOEHDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x21205D0", Offset = "0x211EFD0", VA = "0x1821205D0")]
	[AsyncStateMachine(typeof(BOHEJEHIIDC))]
	public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> BKHFCMDKGKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2120F40", Offset = "0x211F940", VA = "0x182120F40")]
	internal void HABNGPOBEEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2120550", Offset = "0x211EF50", VA = "0x182120550")]
	internal OLCEOJBLPLC<EHDCBMKEILE> BHJGLNBIBBA([In] BDIKLFAAIFG KPPPAGPJGGA)
	{
		return default(OLCEOJBLPLC<EHDCBMKEILE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2120940", Offset = "0x211F340", VA = "0x182120940")]
	internal bool EONMCCAFAML([In] BDIKLFAAIFG KPPPAGPJGGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2121150", Offset = "0x211FB50", VA = "0x182121150")]
	internal OLCEOJBLPLC<EHDCBMKEILE> ICJDKCGJOLJ([In] HKAMLFAFHNK PEEFFJOFPCJ)
	{
		return default(OLCEOJBLPLC<EHDCBMKEILE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2121540", Offset = "0x211FF40", VA = "0x182121540")]
	[AsyncStateMachine(typeof(CPIALKKNGJM))]
	internal Task<BCLNLKLFCPB<object, OBJIPJOMIPB>> PHGGAMCCKKH(EHDCBMKEILE PMCMEAHOBEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x21201C0", Offset = "0x211EBC0", VA = "0x1821201C0")]
	private EHDCBMKEILE[] BGMEACEJGHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2121420", Offset = "0x211FE20", VA = "0x182121420")]
	[AsyncStateMachine(typeof(IJOOPHECDMM))]
	public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> MKJPHPHKOBE(Guid HCLGNDNDKHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class MKIFMJCBMGP
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2E821F0", Offset = "0x2E80BF0", VA = "0x182E821F0")]
	public static GLICBOJFAKM<(TPrev?, PLLOHOJACCG?), HBLCNEAHKAK> GKGFFNFMONJ<TPrev>([In] this GLICBOJFAKM<TPrev, PLLOHOJACCG> BJNJBGHPMEH)
	{
		return default(GLICBOJFAKM<(TPrev, PLLOHOJACCG), HBLCNEAHKAK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2E824B0", Offset = "0x2E80EB0", VA = "0x182E824B0")]
	public static GLICBOJFAKM<TPrev?, PLLOHOJACCG?> MCLFCINCNGK<TPrev>([In] this GLICBOJFAKM<TPrev, PLLOHOJACCG> BJNJBGHPMEH)
	{
		return default(GLICBOJFAKM<TPrev, PLLOHOJACCG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class JEMOIKINEFJ<TData> : LBGFPGMHGDG, PKDABJNIHNM, JHLAIJINHDF where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly JEBPJLMNFAK<BKFIMEBJLKC>? IMNPNHMNOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly string OCGNGJODMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly TData MJHCHFCOEOK;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public JEBPJLMNFAK<BKFIMEBJLKC>? JHJNKNKHHCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x234A1C0", Offset = "0x2348BC0", VA = "0x18234A1C0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x899AA0", Offset = "0x8984A0", VA = "0x180899AA0", Slot = "7")]
	public override string CKGPGAAGKNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4283610", Offset = "0x4282010", VA = "0x184283610")]
	internal JEMOIKINEFJ([In] JEBPJLMNFAK<BKFIMEBJLKC>? FNFEIMODNLO, MJGAEDNBJIL<NPLAKCHMMBM>? JENGBDMODPI, IOKind? GIOKLABBDJF, string KFAOBDLOMDC, [In] TData JGCMECODHDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class FCNFMGJOLHA
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2109080", Offset = "0x2107A80", VA = "0x182109080")]
	public static BCLNLKLFCPB<CCCFAJBJNHG, PKDABJNIHNM> DCGLEIDECBF([In] this PAOMBAGNFAO<MNMGNCAOGNK> LDDMLNHIBOM)
	{
		return default(BCLNLKLFCPB<CCCFAJBJNHG, PKDABJNIHNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2D7E960", Offset = "0x2D7D360", VA = "0x182D7E960")]
	public static BCLNLKLFCPB<TOk, PKDABJNIHNM> NEFALHHOIJG<TOk>([In] this BCLNLKLFCPB<TOk, PKDABJNIHNM> BJNJBGHPMEH, [In] JEBPJLMNFAK<BKFIMEBJLKC>? FNFEIMODNLO, MJGAEDNBJIL<NPLAKCHMMBM>? JENGBDMODPI, IOKind? GIOKLABBDJF, string KFAOBDLOMDC) where TOk : notnull
	{
		return default(BCLNLKLFCPB<TOk, PKDABJNIHNM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface NBIGEKGGIIN
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FIPHNEFFDCE.IPOEBKNAGLF KHCKEABEMJA
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	JHLIMPAJNBN.EJAJLDBKNGE OJJKKNJEGFL
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	PLLOHOJACCG.KNELNOGLGKD GPEKAOAKBHO
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	FHMGLGJBBAM.JBAIHKMGBEO EDNCNNIGMOO
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	KOAFOGCPACB.IIALHHDPMEC<MFOMNBGIJJE, EHDCBMKEILE, PLLOHOJACCG> ENKAGJOGOGC
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	GOHBBJGIJKI IELODJJOMGF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	AIJHDMLFNEJ IGHDBBOFPGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	LILGLJLEAMJ EHDEGADEJKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	LKNDLJOPDAD KEMHDKDJADI
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	MADEDEPMAFJ BCPOOCELJCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class JIJKELOLOFG
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x210F7F0", Offset = "0x210E1F0", VA = "0x18210F7F0")]
	public static EHDCBMKEILE AOGGABFCACL(this EHDCBMKEILE BJNJBGHPMEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x210F900", Offset = "0x210E300", VA = "0x18210F900")]
	public static EHDCBMKEILE LPIMEIGLGGI(this HAIIPIALEGN BJNJBGHPMEH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct HAIIPIALEGN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct HHHBEPEBCBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<object, OBJIPJOMIPB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public PLLOHOJACCG root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public HAIIPIALEGN self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<BCLNLKLFCPB<object, OBJIPJOMIPB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x210D470", Offset = "0x210BE70", VA = "0x18210D470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x210D730", Offset = "0x210C130", VA = "0x18210D730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly ByteString PGPGCBGPPOH;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xB66C60", Offset = "0xB65660", VA = "0x180B66C60")]
	private HAIIPIALEGN(ByteString KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x210CF30", Offset = "0x210B930", VA = "0x18210CF30")]
	public static EHDCBMKEILE DNLPJDJPDOP(ByteString KLABJGGMBGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x210CE80", Offset = "0x210B880", VA = "0x18210CE80")]
	public static NEEHLPPFFPM<MFOMNBGIJJE, HAIIPIALEGN> DKCHBGFLGBC(EHDCBMKEILE FFNCNBIFMAD)
	{
		return default(NEEHLPPFFPM<MFOMNBGIJJE, HAIIPIALEGN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x210CFF0", Offset = "0x210B9F0", VA = "0x18210CFF0")]
	[AsyncStateMachine(typeof(HHHBEPEBCBB))]
	public static Task<BCLNLKLFCPB<object, OBJIPJOMIPB>> PHGGAMCCKKH(PLLOHOJACCG JPBBEMPIGCM, HAIIPIALEGN BJNJBGHPMEH)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct KDEOHMFLNMO
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x210FF10", Offset = "0x210E910", VA = "0x18210FF10")]
	public static EHDCBMKEILE DNLPJDJPDOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x210FEA0", Offset = "0x210E8A0", VA = "0x18210FEA0")]
	public static NEEHLPPFFPM<MFOMNBGIJJE, KDEOHMFLNMO> DKCHBGFLGBC(EHDCBMKEILE FFNCNBIFMAD)
	{
		return default(NEEHLPPFFPM<MFOMNBGIJJE, KDEOHMFLNMO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x210FFB0", Offset = "0x210E9B0", VA = "0x18210FFB0")]
	public static BCLNLKLFCPB<BLGMJKLPHOM, NGACCPLNJOL> PCINKCMIJED(PLLOHOJACCG JPBBEMPIGCM, [In] KDEOHMFLNMO BJNJBGHPMEH)
	{
		return default(BCLNLKLFCPB<BLGMJKLPHOM, NGACCPLNJOL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct IJDKDPLBMHO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct ABIBEPJLHEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<BLGMJKLPHOM, NGACCPLNJOL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public PLLOHOJACCG root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public IJDKDPLBMHO self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private BCLNLKLFCPB<BLGMJKLPHOM, NGACCPLNJOL> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2104FF0", Offset = "0x21039F0", VA = "0x182104FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2105360", Offset = "0x2103D60", VA = "0x182105360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly FMGJMILCPFK? EPBGGLAELPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly FAOKMGJAJIO? HIBHCCNEGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly PIKJJPNAMNM? IOMMMOMLFCE;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x203F510", Offset = "0x203DF10", VA = "0x18203F510")]
	private IJDKDPLBMHO(FMGJMILCPFK? NCIIFBLDHLJ, FAOKMGJAJIO? BDKIHOIIFHL, PIKJJPNAMNM? FFHNFKPFGJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x210E680", Offset = "0x210D080", VA = "0x18210E680")]
	public static EHDCBMKEILE? DNLPJDJPDOP(FMGJMILCPFK? NCIIFBLDHLJ, FAOKMGJAJIO? BDKIHOIIFHL, PIKJJPNAMNM? FFHNFKPFGJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x210E570", Offset = "0x210CF70", VA = "0x18210E570")]
	public static NEEHLPPFFPM<MFOMNBGIJJE, IJDKDPLBMHO> DKCHBGFLGBC(EHDCBMKEILE FFNCNBIFMAD)
	{
		return default(NEEHLPPFFPM<MFOMNBGIJJE, IJDKDPLBMHO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x210E780", Offset = "0x210D180", VA = "0x18210E780")]
	[AsyncStateMachine(typeof(ABIBEPJLHEK))]
	public static Task<BCLNLKLFCPB<BLGMJKLPHOM, NGACCPLNJOL>> PHGGAMCCKKH(PLLOHOJACCG JPBBEMPIGCM, IJDKDPLBMHO BJNJBGHPMEH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct PFPALPEDNCD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct COMABADGGMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<LKBKALCJMFG, OBJIPJOMIPB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public PFPALPEDNCD self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public PLLOHOJACCG root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private BCLNLKLFCPB<LKBKALCJMFG, OBJIPJOMIPB> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private BCLNLKLFCPB<object, JHLAIJINHDF>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private BCLNLKLFCPB<object, JHLAIJINHDF> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private BCLNLKLFCPB<object, JHLAIJINHDF>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<BCLNLKLFCPB<object, OBJIPJOMIPB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2106560", Offset = "0x2104F60", VA = "0x182106560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x21069D0", Offset = "0x21053D0", VA = "0x1821069D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IReadOnlyList<EHDCBMKEILE> CDPJBFFIECG;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xB66C60", Offset = "0xB65660", VA = "0x180B66C60")]
	private PFPALPEDNCD(IReadOnlyList<EHDCBMKEILE> EENNPJMHNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x211EE30", Offset = "0x211D830", VA = "0x18211EE30")]
	public static EHDCBMKEILE DNLPJDJPDOP(IReadOnlyList<EHDCBMKEILE> EENNPJMHNKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x211ED90", Offset = "0x211D790", VA = "0x18211ED90")]
	public static NEEHLPPFFPM<MFOMNBGIJJE, PFPALPEDNCD> DKCHBGFLGBC(EHDCBMKEILE FFNCNBIFMAD)
	{
		return default(NEEHLPPFFPM<MFOMNBGIJJE, PFPALPEDNCD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x211EEF0", Offset = "0x211D8F0", VA = "0x18211EEF0")]
	[AsyncStateMachine(typeof(COMABADGGMI))]
	public static Task<BCLNLKLFCPB<LKBKALCJMFG, OBJIPJOMIPB>> PHGGAMCCKKH(PLLOHOJACCG JPBBEMPIGCM, PFPALPEDNCD BJNJBGHPMEH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct HKAMLFAFHNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly int MNNLJFACLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int OAGDGHBELJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly byte[] MJHCHFCOEOK;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1E51E50", Offset = "0x1E50850", VA = "0x181E51E50")]
	private HKAMLFAFHNK(int FIGHABPEBPG, int HGFDMIDEFHN, byte[] JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x210D880", Offset = "0x210C280", VA = "0x18210D880")]
	public static EHDCBMKEILE DNLPJDJPDOP(int FIGHABPEBPG, int HGFDMIDEFHN, ByteString JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x210D960", Offset = "0x210C360", VA = "0x18210D960")]
	public static EHDCBMKEILE[] NJPEDGJMABI(EHDCBMKEILE PMCMEAHOBEF, int CPBJHCINKCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x210D7A0", Offset = "0x210C1A0", VA = "0x18210D7A0")]
	public static NEEHLPPFFPM<MFOMNBGIJJE, HKAMLFAFHNK> DKCHBGFLGBC(EHDCBMKEILE FFNCNBIFMAD)
	{
		return default(NEEHLPPFFPM<MFOMNBGIJJE, HKAMLFAFHNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x210DA90", Offset = "0x210C490", VA = "0x18210DA90")]
	public static BCLNLKLFCPB<EHDCBMKEILE, NGACCPLNJOL> PCINKCMIJED(PLLOHOJACCG JPBBEMPIGCM, [In] HKAMLFAFHNK BJNJBGHPMEH)
	{
		return default(BCLNLKLFCPB<EHDCBMKEILE, NGACCPLNJOL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct BDIKLFAAIFG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct OIOGCPEOLKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<bool, NGACCPLNJOL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public PLLOHOJACCG root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public BDIKLFAAIFG self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private BCLNLKLFCPB<bool, NGACCPLNJOL> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<BCLNLKLFCPB<BLGMJKLPHOM, NGACCPLNJOL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x211D7B0", Offset = "0x211C1B0", VA = "0x18211D7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x211DDF0", Offset = "0x211C7F0", VA = "0x18211DDF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly int MNNLJFACLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int OAGDGHBELJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly byte[] MJHCHFCOEOK;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1E51E50", Offset = "0x1E50850", VA = "0x181E51E50")]
	private BDIKLFAAIFG(int FIGHABPEBPG, int HGFDMIDEFHN, byte[] JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2105A70", Offset = "0x2104470", VA = "0x182105A70")]
	public static EHDCBMKEILE DNLPJDJPDOP(int FIGHABPEBPG, int HGFDMIDEFHN, ByteString JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x21057A0", Offset = "0x21041A0", VA = "0x1821057A0")]
	public static EHDCBMKEILE?[]? CANCDMOHPAO(int CPBJHCINKCL, FMGJMILCPFK? NCIIFBLDHLJ, FAOKMGJAJIO? BDKIHOIIFHL, PIKJJPNAMNM? FFHNFKPFGJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2105990", Offset = "0x2104390", VA = "0x182105990")]
	public static NEEHLPPFFPM<MFOMNBGIJJE, BDIKLFAAIFG> DKCHBGFLGBC(EHDCBMKEILE FFNCNBIFMAD)
	{
		return default(NEEHLPPFFPM<MFOMNBGIJJE, BDIKLFAAIFG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2105B50", Offset = "0x2104550", VA = "0x182105B50")]
	[AsyncStateMachine(typeof(OIOGCPEOLKM))]
	public static Task<BCLNLKLFCPB<bool, NGACCPLNJOL>> PHGGAMCCKKH(PLLOHOJACCG JPBBEMPIGCM, BDIKLFAAIFG BJNJBGHPMEH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class DGDFFMBNFNB : JMBJIHIFOEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly PLLOHOJACCG EBBHMAKIMNA;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public GAAMLIKEOGP? DFEEMNKDOMA
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2106D30", Offset = "0x2105730", VA = "0x182106D30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8962A0", Offset = "0x894CA0", VA = "0x1808962A0")]
	internal DGDFFMBNFNB(PLLOHOJACCG PFCDDIODGEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class IGGPNOLOJEI : GAAMLIKEOGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly PLLOHOJACCG EBBHMAKIMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly HDGDOAHDBCE EIJNCCEJHAJ;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x89CB80", Offset = "0x89B580", VA = "0x18089CB80")]
	public IGGPNOLOJEI(PLLOHOJACCG PFCDDIODGEJ, HDGDOAHDBCE HNFHGIGGGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x210E020", Offset = "0x210CA20", VA = "0x18210E020", Slot = "4")]
	public BCLNLKLFCPB<CCCFAJBJNHG, PKDABJNIHNM> PDMIMNBHLOC(JEBPJLMNFAK<BKFIMEBJLKC> JJLNKABMPOP, MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, MJGAEDNBJIL<EMOBFLMBFFJ> JJHCIBLPKAD)
	{
		return default(BCLNLKLFCPB<CCCFAJBJNHG, PKDABJNIHNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x210DD40", Offset = "0x210C740", VA = "0x18210DD40", Slot = "5")]
	public BCLNLKLFCPB<CCCFAJBJNHG, PKDABJNIHNM> DEKPIGGDKDD(JEBPJLMNFAK<BKFIMEBJLKC> JJLNKABMPOP, MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, MJGAEDNBJIL<DGNIMDELLGK> GNAGOFFMLAD)
	{
		return default(BCLNLKLFCPB<CCCFAJBJNHG, PKDABJNIHNM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class FIPHNEFFDCE : KODBJLILNLE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface IPOEBKNAGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<HDGDOAHDBCE> BFHJHPEEPNN(PLLOHOJACCG PFCDDIODGEJ, FAOKMGJAJIO? JMMMBDHOMCD, PIKJJPNAMNM? AFHCBPGJMBO, CancellationToken IONNNJNKLMJ);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		HBPBPJMDAIL NMFEAEOFJJP(PLLOHOJACCG PFCDDIODGEJ, FMGJMILCPFK LACCAKBFKMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class JFBHMLEECGC : IPOEBKNAGLF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct CADFIBIPBGA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public AsyncTaskMethodBuilder<HDGDOAHDBCE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public PLLOHOJACCG circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public FAOKMGJAJIO cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public PIKJJPNAMNM cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter<FHMGLGJBBAM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x2106090", Offset = "0x2104A90", VA = "0x182106090", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x2106260", Offset = "0x2104C60", VA = "0x182106260", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly JFBHMLEECGC DFEEMNKDOMA;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		private JFBHMLEECGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x210F120", Offset = "0x210DB20", VA = "0x18210F120", Slot = "4")]
		[AsyncStateMachine(typeof(CADFIBIPBGA))]
		public Task<HDGDOAHDBCE> BFHJHPEEPNN(PLLOHOJACCG PFCDDIODGEJ, FAOKMGJAJIO? JMMMBDHOMCD, PIKJJPNAMNM? AFHCBPGJMBO, CancellationToken IONNNJNKLMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x210F280", Offset = "0x210DC80", VA = "0x18210F280", Slot = "5")]
		public HBPBPJMDAIL NMFEAEOFJJP(PLLOHOJACCG PFCDDIODGEJ, FMGJMILCPFK LACCAKBFKMJ)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct LBDMNCGEOOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder<FIPHNEFFDCE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public PLLOHOJACCG circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public FAOKMGJAJIO cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public PIKJJPNAMNM cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public FMGJMILCPFK evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private IPOEBKNAGLF <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter<HDGDOAHDBCE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2110240", Offset = "0x210EC40", VA = "0x182110240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2110740", Offset = "0x210F140", VA = "0x182110740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly HDGDOAHDBCE EIJNCCEJHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly HBPBPJMDAIL NJAAGCNHFHC;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public JKIEPPIEFOF MMFCBCMFCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x21097C0", Offset = "0x21081C0", VA = "0x1821097C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public HBLCNEAHKAK EDONFKNGOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2109810", Offset = "0x2108210", VA = "0x182109810", Slot = "5")]
		get
		{
			return default(HBLCNEAHKAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IGGPNOLOJEI JEAJINKEGCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x898FC0", Offset = "0x8979C0", VA = "0x180898FC0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MJECCAEPCJM EGAMEHMADCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x899AF0", Offset = "0x8984F0", VA = "0x180899AF0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0xA0D6F0", Offset = "0xA0C0F0", VA = "0x180A0D6F0")]
	private FIPHNEFFDCE(HDGDOAHDBCE HNFHGIGGGHI, HBPBPJMDAIL GLCGEFKKFIJ, IGGPNOLOJEI GELJLMKDHAA, MJECCAEPCJM DJEDPBAIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x21095F0", Offset = "0x2107FF0", VA = "0x1821095F0")]
	[AsyncStateMachine(typeof(LBDMNCGEOOM))]
	public static Task<FIPHNEFFDCE> BHOHJJOHHJH(PLLOHOJACCG PFCDDIODGEJ, FMGJMILCPFK LACCAKBFKMJ, FAOKMGJAJIO? JMMMBDHOMCD, PIKJJPNAMNM? AFHCBPGJMBO, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2109760", Offset = "0x2108160", VA = "0x182109760", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class JHLIMPAJNBN : OJBFNKHJHCH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface EJAJLDBKNGE
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<KODBJLILNLE> LADJOHHIPFP(PLLOHOJACCG PFCDDIODGEJ, FMGJMILCPFK LACCAKBFKMJ, FAOKMGJAJIO? JMMMBDHOMCD, PIKJJPNAMNM? AFHCBPGJMBO, CancellationToken IONNNJNKLMJ);

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HIBGDBJANBL();

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OABJEBCKOFD();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class BJBOGCMKNIC : EJAJLDBKNGE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct LMKDJOPDKLN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public AsyncTaskMethodBuilder<KODBJLILNLE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public PLLOHOJACCG circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public FMGJMILCPFK evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public FAOKMGJAJIO cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public PIKJJPNAMNM cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private TaskAwaiter<FIPHNEFFDCE> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x2111F20", Offset = "0x2110920", VA = "0x182111F20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x2112260", Offset = "0x2110C60", VA = "0x182112260", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x2105C80", Offset = "0x2104680", VA = "0x182105C80", Slot = "4")]
		[AsyncStateMachine(typeof(LMKDJOPDKLN))]
		public Task<KODBJLILNLE> LADJOHHIPFP(PLLOHOJACCG PFCDDIODGEJ, FMGJMILCPFK LACCAKBFKMJ, FAOKMGJAJIO? JMMMBDHOMCD, PIKJJPNAMNM? AFHCBPGJMBO, CancellationToken IONNNJNKLMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void HIBGDBJANBL();

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void OABJEBCKOFD();

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		protected BJBOGCMKNIC()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct IGMODBNHHGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder<KODBJLILNLE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public JHLIMPAJNBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter<BLGMJKLPHOM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x210E300", Offset = "0x210CD00", VA = "0x18210E300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x210E500", Offset = "0x210CF00", VA = "0x18210E500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct PKOKFDEMGCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public JHLIMPAJNBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public PLLOHOJACCG circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public FMGJMILCPFK evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public FAOKMGJAJIO cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public PIKJJPNAMNM cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<KODBJLILNLE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x211FB70", Offset = "0x211E570", VA = "0x18211FB70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x21200A0", Offset = "0x211EAA0", VA = "0x1821200A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly EJAJLDBKNGE FJKKNCLMNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly TaskCompletionSource<BLGMJKLPHOM> JKLDMNFKFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly TaskCompletionSource<BLGMJKLPHOM> HCFFEJMKGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly CancellationTokenSource DJFHAJGCPIL;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool HHIAIJOFCNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xC46710", Offset = "0xC45110", VA = "0x180C46710", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xD234D0", Offset = "0xD21ED0", VA = "0x180D234D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool CMFCJHGPMDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xD234E0", Offset = "0xD21EE0", VA = "0x180D234E0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xD234C0", Offset = "0xD21EC0", VA = "0x180D234C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool NDECOHMCNFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x134D980", Offset = "0x134C380", VA = "0x18134D980")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x210F400", Offset = "0x210DE00", VA = "0x18210F400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public KODBJLILNLE? PAJJJJDAAAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8999F0", Offset = "0x8983F0", VA = "0x1808999F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x899AB0", Offset = "0x8984B0", VA = "0x180899AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x210F310", Offset = "0x210DD10", VA = "0x18210F310", Slot = "7")]
	[AsyncStateMachine(typeof(IGMODBNHHGO))]
	public Task<KODBJLILNLE> AKPOHNLBLOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x210F6E0", Offset = "0x210E0E0", VA = "0x18210F6E0")]
	public JHLIMPAJNBN(EJAJLDBKNGE LAKCFHGOLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x210F580", Offset = "0x210DF80", VA = "0x18210F580", Slot = "8")]
	[AsyncStateMachine(typeof(PKOKFDEMGCB))]
	public Task OACPNMOABHH(PLLOHOJACCG PFCDDIODGEJ, FMGJMILCPFK LACCAKBFKMJ, FAOKMGJAJIO? JMMMBDHOMCD, PIKJJPNAMNM? AFHCBPGJMBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x210F410", Offset = "0x210DE10", VA = "0x18210F410", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class LLMJLFLHAIO : MBMGGDECENJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly MJECCAEPCJM MGJGBLMBACE;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8962A0", Offset = "0x894CA0", VA = "0x1808962A0")]
	public LLMJLFLHAIO(MJECCAEPCJM DJEDPBAIHLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class HNPIMNCHGCB
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class PBFEJBFHNGJ<TGraph> : PHGLNNNIEFI where TGraph : KBEFAFEHDLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		protected readonly TGraph HEIIBGIBCAK;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public virtual FGBAOKFDFIO? JPMCKKEONIG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x118B380", Offset = "0x1189D80", VA = "0x18118B380", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public MJGAEDNBJIL<IKLMIGOGHKN> EPGBOEDHPEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x49DCD20", Offset = "0x49DB720", VA = "0x1849DCD20", Slot = "5")]
			get
			{
				return default(MJGAEDNBJIL<IKLMIGOGHKN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public MJGAEDNBJIL<IKLMIGOGHKN>? HHBOEOJMHKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x49DCCA0", Offset = "0x49DB6A0", VA = "0x1849DCCA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8962A0", Offset = "0x894CA0", VA = "0x1808962A0")]
		public PBFEJBFHNGJ(TGraph BDFEFAPJDHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class DOCJJPPDOKD : PBFEJBFHNGJ<GOBCEFHNOAK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override FGBAOKFDFIO? JPMCKKEONIG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x2108CE0", Offset = "0x21076E0", VA = "0x182108CE0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2108D00", Offset = "0x2107700", VA = "0x182108D00")]
		public DOCJJPPDOKD(GOBCEFHNOAK DHGOHNADGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x210DBB0", Offset = "0x210C5B0", VA = "0x18210DBB0")]
	public static PHGLNNNIEFI GGBAHLJJLHO(KBEFAFEHDLK BDFEFAPJDHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class GIIGAKOBIAH : IBDEEOHCPBI, PGALABIFJNM, DBDMDCDNCFC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class EJHCOALFJFJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private struct <<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public EJHCOALFJFJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public GOHBBJGIJKI errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x2121ED0", Offset = "0x21208D0", VA = "0x182121ED0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x2122140", Offset = "0x2120B40", VA = "0x182122140", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public GIIGAKOBIAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public EJHCOALFJFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2108F90", Offset = "0x2107990", VA = "0x182108F90")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task GMEKPCIALHA(GOHBBJGIJKI errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct PDHIPGMGPIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public bool checkStringPurity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public GIIGAKOBIAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x211E820", Offset = "0x211D220", VA = "0x18211E820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x211ED30", Offset = "0x211D730", VA = "0x18211ED30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class FGIMGIGOKBB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public FGIMGIGOKBB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x21221A0", Offset = "0x2120BA0", VA = "0x1821221A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x2122480", Offset = "0x2120E80", VA = "0x182122480", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public GIIGAKOBIAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public FGIMGIGOKBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2109520", Offset = "0x2107F20", VA = "0x182109520")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task JJDFHDAFDON(GOHBBJGIJKI errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly PJDJGGGLFDB CAAFAGNNJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly ICollection<PKAHBMNHOEG> DNOOGNGIJJK;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private NBIGEKGGIIN HEJJNPLBKLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x210A420", Offset = "0x2108E20", VA = "0x18210A420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public MJGAEDNBJIL<EMOBFLMBFFJ> CJDCICKDECL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9D0480", Offset = "0x9CEE80", VA = "0x1809D0480", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(MJGAEDNBJIL<EMOBFLMBFFJ>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9D1330", Offset = "0x9CFD30", VA = "0x1809D1330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private MJGAEDNBJIL<DDABHKCABNE> DPINEOKAPPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xD1D7D0", Offset = "0xD1C1D0", VA = "0x180D1D7D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public MJGAEDNBJIL<OIEHBMHNIBK> CADNKCDGPNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8BF000", Offset = "0x8BDA00", VA = "0x1808BF000", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(MJGAEDNBJIL<OIEHBMHNIBK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public override MJGAEDNBJIL<NPLAKCHMMBM> CNGHGJOOHPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x210A970", Offset = "0x2109370", VA = "0x18210A970", Slot = "20")]
		get
		{
			return default(MJGAEDNBJIL<NPLAKCHMMBM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool PFECDKHBHAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x210C6C0", Offset = "0x210B0C0", VA = "0x18210C6C0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x210CC60", Offset = "0x210B660", VA = "0x18210CC60")]
	private GIIGAKOBIAH(PLLOHOJACCG PFCDDIODGEJ, DPIPCKFLLFL KOHLOCENPAH, PJDJGGGLFDB OAMFPCMHDBI, MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, MJGAEDNBJIL<EMOBFLMBFFJ> JJHCIBLPKAD, MJGAEDNBJIL<DDABHKCABNE> IINCKHAMMKN, bool BNKGOGLKMMD, string KJPHMNNIMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x210AD40", Offset = "0x2109740", VA = "0x18210AD40")]
	public static GIIGAKOBIAH GGBAHLJJLHO(PLLOHOJACCG PFCDDIODGEJ, DPIPCKFLLFL KOHLOCENPAH, PJDJGGGLFDB DIGEGMNKCOG, MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, MJGAEDNBJIL<DDABHKCABNE> IINCKHAMMKN, MJGAEDNBJIL<EMOBFLMBFFJ> JJHCIBLPKAD, bool BNKGOGLKMMD, bool DILHCPAOMOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x210A440", Offset = "0x2108E40", VA = "0x18210A440", Slot = "21")]
	protected override void AIFHKOLJDOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x210A740", Offset = "0x2109140", VA = "0x18210A740", Slot = "22")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x210BEF0", Offset = "0x210A8F0", VA = "0x18210BEF0", Slot = "30")]
	public void JDOCEKOHJBL(PKAHBMNHOEG MILPJICLPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x210C200", Offset = "0x210AC00", VA = "0x18210C200", Slot = "27")]
	public void KFLIDABADGF(AMHGKMCFGFA OJEDFAEEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x210B0F0", Offset = "0x2109AF0", VA = "0x18210B0F0", Slot = "28")]
	public void GLFGCPILFDC(OGLJFIOCJDF LCJOKKCJGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x210A4E0", Offset = "0x2108EE0", VA = "0x18210A4E0", Slot = "23")]
	protected override void BPECPKLMPPL(APDFNBBFBPM AILIAJMFOGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x210C740", Offset = "0x210B140", VA = "0x18210C740", Slot = "32")]
	public string MIENJCPLNMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x210AA80", Offset = "0x2109480", VA = "0x18210AA80", Slot = "29")]
	public string GELAIPKAJHD(int DOBHOIOIHAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x210BF50", Offset = "0x210A950", VA = "0x18210BF50")]
	private void JPJFJPFEIFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x210C980", Offset = "0x210B380", VA = "0x18210C980", Slot = "31")]
	public void NPHJLHNIDPP(PKAHBMNHOEG MILPJICLPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x210BCE0", Offset = "0x210A6E0", VA = "0x18210BCE0")]
	private void IKJPFFABHKG(bool KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x210A630", Offset = "0x2109030", VA = "0x18210A630", Slot = "33")]
	[AsyncStateMachine(typeof(PDHIPGMGPIH))]
	public Task CDCIIEGOPCD(string KLABJGGMBGH, bool PFBJCIMBEON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x210CA50", Offset = "0x210B450", VA = "0x18210CA50")]
	public void NPJLCJHIGND(string KLABJGGMBGH, bool PFBJCIMBEON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x210BB40", Offset = "0x210A540", VA = "0x18210BB40")]
	private void IKCNPPFEELK(int KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x9D1330", Offset = "0x9CFD30", VA = "0x1809D1330")]
	internal void GBMAKPFOJEG(MJGAEDNBJIL<EMOBFLMBFFJ> KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x210BA90", Offset = "0x210A490", VA = "0x18210BA90")]
	[CompilerGenerated]
	private void HBGBFMCCLKA(string KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x210A9C0", Offset = "0x21093C0", VA = "0x18210A9C0")]
	[CompilerGenerated]
	private bool FNPHGLLPOCJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x210CBA0", Offset = "0x210B5A0", VA = "0x18210CBA0")]
	[CompilerGenerated]
	private bool PIGJHGHEEEK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x210BEA0", Offset = "0x210A8A0", VA = "0x18210BEA0")]
	[CompilerGenerated]
	private int NOLFMKKIBAC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x210C8A0", Offset = "0x210B2A0", VA = "0x18210C8A0")]
	[CompilerGenerated]
	private bool NEMPBIDEGMA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x210BAA0", Offset = "0x210A4A0", VA = "0x18210BAA0")]
	[CompilerGenerated]
	private void HFKNBGLBMPD(string KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x210A8B0", Offset = "0x21092B0", VA = "0x18210A8B0")]
	[CompilerGenerated]
	private bool ENADOLOIIAE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x210C930", Offset = "0x210B330", VA = "0x18210C930")]
	[CompilerGenerated]
	private bool NJIKKHPCIAL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x210BAB0", Offset = "0x210A4B0", VA = "0x18210BAB0")]
	[CompilerGenerated]
	private bool IGIEPPNCGID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x210BEA0", Offset = "0x210A8A0", VA = "0x18210BEA0")]
	[CompilerGenerated]
	private int IOKLDJFFPCJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x210C5F0", Offset = "0x210AFF0", VA = "0x18210C5F0")]
	[CompilerGenerated]
	private bool LHLOKMINEFM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x210C570", Offset = "0x210AF70", VA = "0x18210C570")]
	[CompilerGenerated]
	private object KLBCFBNMCHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x210C180", Offset = "0x210AB80", VA = "0x18210C180")]
	[CompilerGenerated]
	private void KBMMIKKGDGM(object KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x210A7E0", Offset = "0x21091E0", VA = "0x18210A7E0")]
	[CompilerGenerated]
	private bool EKABEOKNCMP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class LKMBKPAOLGK
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class BBAEMANAPHD : JJMDOICAKMK<DKLOONAJCHI>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override KALNDDFHJJG FCCCJLPHOED
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x98E810", Offset = "0x98D210", VA = "0x18098E810", Slot = "126")]
			get
			{
				return default(KALNDDFHJJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2105740", Offset = "0x2104140", VA = "0x182105740")]
		public BBAEMANAPHD(PLLOHOJACCG PFCDDIODGEJ, DKLOONAJCHI BDPEMHOFOHC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class NDGPLCKEABD : OCLPOHGKJMO<ELEFNGFOLBA>
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x211D6C0", Offset = "0x211C0C0", VA = "0x18211D6C0")]
		public NDGPLCKEABD(PLLOHOJACCG PFCDDIODGEJ, ELEFNGFOLBA KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x211D420", Offset = "0x211BE20", VA = "0x18211D420", Slot = "120")]
		protected override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x211D3D0", Offset = "0x211BDD0", VA = "0x18211D3D0")]
		[CompilerGenerated]
		private bool JDDFFGJAECP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x211D5A0", Offset = "0x211BFA0", VA = "0x18211D5A0")]
		[CompilerGenerated]
		private void PKJCBPBNJFN(bool KLABJGGMBGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class MNOMNHPEAJP : OCLPOHGKJMO<KNMMGHACGEJ>
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class PAOPKEPJPNP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public LPGKJOMOPPD nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public MNOMNHPEAJP <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public PAOPKEPJPNP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x211E730", Offset = "0x211D130", VA = "0x18211E730")]
			internal void JDPFBIGGGNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x211E780", Offset = "0x211D180", VA = "0x18211E780")]
			internal bool MDAPEAKELDK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x211E7D0", Offset = "0x211D1D0", VA = "0x18211E7D0")]
			internal bool NLOAMKMODOM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x211E610", Offset = "0x211D010", VA = "0x18211E610")]
			internal void IIBCAKFOPMO(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x211E5C0", Offset = "0x211CFC0", VA = "0x18211E5C0")]
			internal bool IACLJHOBOIL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x211D360", Offset = "0x211BD60", VA = "0x18211D360")]
		public MNOMNHPEAJP(PLLOHOJACCG PFCDDIODGEJ, KNMMGHACGEJ KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x211D030", Offset = "0x211BA30", VA = "0x18211D030", Slot = "120")]
		protected override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class GHGCCFDJIGB : OCLPOHGKJMO<LMOBKAJAOII>
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class PANFJOFKMGK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public LPGKJOMOPPD nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public GHGCCFDJIGB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public PANFJOFKMGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x211E110", Offset = "0x211CB10", VA = "0x18211E110")]
			internal object JDPFBIGGGNI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x211DFD0", Offset = "0x211C9D0", VA = "0x18211DFD0")]
			internal bool FICJGAHFHBG(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x211E210", Offset = "0x211CC10", VA = "0x18211E210")]
			internal void MDAPEAKELDK(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x211E460", Offset = "0x211CE60", VA = "0x18211E460")]
			internal string NLOAMKMODOM(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x211E0C0", Offset = "0x211CAC0", VA = "0x18211E0C0")]
			internal IReadOnlyList<object> IIBCAKFOPMO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x211E050", Offset = "0x211CA50", VA = "0x18211E050")]
			internal bool IACLJHOBOIL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x211DE60", Offset = "0x211C860", VA = "0x18211DE60")]
			internal bool AADPJDPABMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x211DEB0", Offset = "0x211C8B0", VA = "0x18211DEB0")]
			internal void BDPDDNLEAGC(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x210A3B0", Offset = "0x2108DB0", VA = "0x18210A3B0")]
		public GHGCCFDJIGB(PLLOHOJACCG PFCDDIODGEJ, LMOBKAJAOII KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2109C50", Offset = "0x2108650", VA = "0x182109C50", Slot = "120")]
		protected override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class KACENACDLCL : OCLPOHGKJMO<OGPPHLBEOGO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class EFNCOCALLAO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public KACENACDLCL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public LPGKJOMOPPD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public EFNCOCALLAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x2108DD0", Offset = "0x21077D0", VA = "0x182108DD0")]
			internal bool JDPFBIGGGNI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x2108E20", Offset = "0x2107820", VA = "0x182108E20")]
			internal void MDAPEAKELDK(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x2108F40", Offset = "0x2107940", VA = "0x182108F40")]
			internal bool NLOAMKMODOM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x210FC00", Offset = "0x210E600", VA = "0x18210FC00")]
		public KACENACDLCL(PLLOHOJACCG PFCDDIODGEJ, OGPPHLBEOGO KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x210F9D0", Offset = "0x210E3D0", VA = "0x18210F9D0", Slot = "120")]
		protected override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public abstract class NICBEFPGHCP<TNode> : OCLPOHGKJMO<TNode> where TNode : notnull, NEIGDLJJFDO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct FPALOBGDLBA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public AsyncTaskMethodBuilder<BCLNLKLFCPB<MJGAEDNBJIL<LPDNCAKIDEG>, OBJIPJOMIPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public NICBEFPGHCP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private TaskAwaiter<BCLNLKLFCPB<MJGAEDNBJIL<LPDNCAKIDEG>, OBJIPJOMIPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x3E12320", Offset = "0x3E10D20", VA = "0x183E12320", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x3E12720", Offset = "0x3E11120", VA = "0x183E12720", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct KFFFKEAIHII : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public AsyncTaskMethodBuilder<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public NICBEFPGHCP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public MJGAEDNBJIL<LPDNCAKIDEG> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private TaskAwaiter<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x441F8A0", Offset = "0x441E2A0", VA = "0x18441F8A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x441FCA0", Offset = "0x441E6A0", VA = "0x18441FCA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public sealed override bool EIDDJGDEAPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override MJGAEDNBJIL<LPDNCAKIDEG>? NCAMHCONKDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x47F9930", Offset = "0x47F8330", VA = "0x1847F9930", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4555420", Offset = "0x4553E20", VA = "0x184555420")]
		protected NICBEFPGHCP(PLLOHOJACCG PFCDDIODGEJ, TNode KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x47F9810", Offset = "0x47F8210", VA = "0x1847F9810", Slot = "100")]
		[AsyncStateMachine(typeof(NICBEFPGHCP<>.FPALOBGDLBA))]
		public override Task<BCLNLKLFCPB<MJGAEDNBJIL<LPDNCAKIDEG>, OBJIPJOMIPB>> IGIMMPPOEKP(string KJPHMNNIMDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x47F9770", Offset = "0x47F8170", VA = "0x1847F9770", Slot = "124")]
		public sealed override bool IBLEHLFAKBM(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x47F96D0", Offset = "0x47F80D0", VA = "0x1847F96D0", Slot = "112")]
		protected sealed override bool GIBGGBJCBHD(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x47F9520", Offset = "0x47F7F20", VA = "0x1847F9520", Slot = "113")]
		protected override bool EPKFMDJOHBB(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x47F95C0", Offset = "0x47F7FC0", VA = "0x1847F95C0", Slot = "101")]
		[AsyncStateMachine(typeof(NICBEFPGHCP<>.KFFFKEAIHII))]
		public override Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> GDGHCBBAPMO(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class PNMDNBPEIPI : GBMAMGMOMFA<GDLJAJCBCOA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class CNJAJAOGCHB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public PNMDNBPEIPI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public LPGKJOMOPPD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public CNJAJAOGCHB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x21064E0", Offset = "0x2104EE0", VA = "0x1821064E0")]
			internal bool MJDFMONDNHO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x2106420", Offset = "0x2104E20", VA = "0x182106420")]
			internal void AJMOMHLBAIF(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2121BE0", Offset = "0x21205E0", VA = "0x182121BE0")]
		public PNMDNBPEIPI(PLLOHOJACCG PFCDDIODGEJ, GDLJAJCBCOA BDPEMHOFOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2121990", Offset = "0x2120390", VA = "0x182121990", Slot = "126")]
		protected override void MIIEKGIGHCK(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class BOEJJBGOFMK : NHHGKDHPBDL<GJFDEOHOPED>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override NodeVisualizationKey PJJDBLNOLBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x923D80", Offset = "0x922780", VA = "0x180923D80", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2105DE0", Offset = "0x21047E0", VA = "0x182105DE0")]
		public BOEJJBGOFMK(PLLOHOJACCG PFCDDIODGEJ, GJFDEOHOPED KOHLOCENPAH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public abstract class NHHGKDHPBDL<TNode> : OCLPOHGKJMO<TNode> where TNode : notnull, ADFGEHKPPPC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct GNICOODNNFJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public AsyncTaskMethodBuilder<BCLNLKLFCPB<MJGAEDNBJIL<LPDNCAKIDEG>, OBJIPJOMIPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public NHHGKDHPBDL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			private TaskAwaiter<BCLNLKLFCPB<MJGAEDNBJIL<LPDNCAKIDEG>, OBJIPJOMIPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x3EE9880", Offset = "0x3EE8280", VA = "0x183EE9880", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x3EE9D40", Offset = "0x3EE8740", VA = "0x183EE9D40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct FNAKMEIOHMP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public AsyncTaskMethodBuilder<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public NHHGKDHPBDL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public MJGAEDNBJIL<LPDNCAKIDEG> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private TaskAwaiter<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x3E0BFB0", Offset = "0x3E0A9B0", VA = "0x183E0BFB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x3E0C440", Offset = "0x3E0AE40", VA = "0x183E0C440", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct AOLNCPJCBPJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public AsyncTaskMethodBuilder<BCLNLKLFCPB<LKBKALCJMFG, OBJIPJOMIPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public NHHGKDHPBDL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private TaskAwaiter<BCLNLKLFCPB<LKBKALCJMFG, OBJIPJOMIPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x410A2B0", Offset = "0x4108CB0", VA = "0x18410A2B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x410A990", Offset = "0x4109390", VA = "0x18410A990", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private sealed class FLLCNKIDIKO
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000050")]
			private struct <<BuildConfigMenuInternal>b__7>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public FLLCNKIDIKO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0x375E940", Offset = "0x375D340", VA = "0x18375E940", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000150")]
				[Cpp2IlInjected.Address(RVA = "0x8E5A10", Offset = "0x8E4410", VA = "0x1808E5A10", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public PIDEGLEPBNK configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public LPGKJOMOPPD nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public NHHGKDHPBDL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public Func<string, bool> <>9__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public Action <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public FLLCNKIDIKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x3E074E0", Offset = "0x3E05EE0", VA = "0x183E074E0")]
			internal bool BDPDDNLEAGC(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x3E07660", Offset = "0x3E06060", VA = "0x183E07660")]
			internal void JDPFBIGGGNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x3E075C0", Offset = "0x3E05FC0", VA = "0x183E075C0")]
			[AsyncStateMachine(typeof(NHHGKDHPBDL<>.FLLCNKIDIKO.<<BuildConfigMenuInternal>b__7>d))]
			internal void FICJGAHFHBG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x3E07950", Offset = "0x3E06350", VA = "0x183E07950")]
			internal bool MDAPEAKELDK()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class MOLPBJMMBII
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000052")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				public MOLPBJMMBII <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				private TaskAwaiter<TaskStatus> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000156")]
				[Cpp2IlInjected.Address(RVA = "0x375E5C0", Offset = "0x375CFC0", VA = "0x18375E5C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000157")]
				[Cpp2IlInjected.Address(RVA = "0x8E5A10", Offset = "0x8E4410", VA = "0x1808E5A10", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public string newFunctionName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public FLLCNKIDIKO CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public Func<string> <>9__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public Action<string> <>9__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public Action <>9__5;

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public MOLPBJMMBII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x478EC20", Offset = "0x478D620", VA = "0x18478EC20")]
			internal void NLOAMKMODOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0")]
			internal string IIBCAKFOPMO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x8961C0", Offset = "0x894BC0", VA = "0x1808961C0")]
			internal void IACLJHOBOIL(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x478EB80", Offset = "0x478D580", VA = "0x18478EB80")]
			[AsyncStateMachine(typeof(NHHGKDHPBDL<>.MOLPBJMMBII.<<BuildConfigMenuInternal>b__5>d))]
			internal void AADPJDPABMP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class LAAAANJIGHN
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000054")]
			private struct <<AddDynamicNodeGroupSettingV2>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000105")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				public LAAAANJIGHN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016B")]
				[Cpp2IlInjected.Address(RVA = "0x375E0F0", Offset = "0x375CAF0", VA = "0x18375E0F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0x8E5A10", Offset = "0x8E4410", VA = "0x1808E5A10", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			private struct <<AddDynamicNodeGroupSettingV2>b__6>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010A")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010B")]
				public LAAAANJIGHN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010C")]
				private TaskAwaiter<BCLNLKLFCPB<MJGAEDNBJIL<DDABHKCABNE>, OBJIPJOMIPB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0x375E2D0", Offset = "0x375CCD0", VA = "0x18375E2D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0x8E5A10", Offset = "0x8E4410", VA = "0x1808E5A10", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000056")]
			private struct <<AddDynamicNodeGroupSettingV2>b__10>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public LAAAANJIGHN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				private TaskAwaiter<BCLNLKLFCPB<MJGAEDNBJIL<OMDILHJFPPO>, OBJIPJOMIPB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0x375DA20", Offset = "0x375C420", VA = "0x18375DA20", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0x8E5A10", Offset = "0x8E4410", VA = "0x1808E5A10", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public NHHGKDHPBDL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public MJGAEDNBJIL<LPDNCAKIDEG> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public PIDEGLEPBNK configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public LPGKJOMOPPD nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public KBHINEMHBJO nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public int minGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public int maxGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public BLDEJALINAE selectedInputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public string newInputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public List<KPABBPKBIBN> inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public BLDEJALINAE selectedOutputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public string newOutputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public List<KPABBPKBIBN> outputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public Func<string, bool> <>9__17;

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public LAAAANJIGHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x44B99C0", Offset = "0x44B83C0", VA = "0x1844B99C0")]
			internal bool DMANPLCPMIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x44B9B00", Offset = "0x44B8500", VA = "0x1844B9B00")]
			internal void HKFNIPBEEBG(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x44B9FA0", Offset = "0x44B89A0", VA = "0x1844B9FA0")]
			internal bool PFGACIKJBDM(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x44B9BE0", Offset = "0x44B85E0", VA = "0x1844B9BE0")]
			internal bool IHNDMHPBGFH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x44B9C20", Offset = "0x44B8620", VA = "0x1844B9C20")]
			[AsyncStateMachine(typeof(NHHGKDHPBDL<>.LAAAANJIGHN.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void JBGDLDCFDIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x44BA080", Offset = "0x44B8A80", VA = "0x1844BA080")]
			internal bool PPBNFDFHDIK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x44B9740", Offset = "0x44B8140", VA = "0x1844B9740")]
			internal void BECKAPJAKGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x44B9E30", Offset = "0x44B8830", VA = "0x1844B9E30")]
			internal bool NBIHABDKIFF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x44B9EE0", Offset = "0x44B88E0", VA = "0x1844B9EE0")]
			internal void OADPHEABPHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x44B9910", Offset = "0x44B8310", VA = "0x1844B9910")]
			internal bool DFEPFKOCBLK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x44B9A90", Offset = "0x44B8490", VA = "0x1844B9A90")]
			internal bool GCMOBMHBFNH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x44B9800", Offset = "0x44B8200", VA = "0x1844B9800")]
			internal void CFMFCACJICC(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x44B9D20", Offset = "0x44B8720", VA = "0x1844B9D20")]
			[AsyncStateMachine(typeof(NHHGKDHPBDL<>.LAAAANJIGHN.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void MGELAOEOHNE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x44B9CC0", Offset = "0x44B86C0", VA = "0x1844B9CC0")]
			internal bool JLBKIEABNPL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x44B9DC0", Offset = "0x44B87C0", VA = "0x1844B9DC0")]
			internal bool MLBHKPIPAIN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x44B9B70", Offset = "0x44B8570", VA = "0x1844B9B70")]
			internal void HPNCGMNDMLP(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x44B9870", Offset = "0x44B8270", VA = "0x1844B9870")]
			[AsyncStateMachine(typeof(NHHGKDHPBDL<>.LAAAANJIGHN.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void CMNOKILAKJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x44B9A30", Offset = "0x44B8430", VA = "0x1844B9A30")]
			internal bool GBGLNJLDMLI()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class FDKGFHPJIBE
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000058")]
			private struct <<AddDynamicNodeGroupSettingV2>b__16>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000116")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000117")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000118")]
				public FDKGFHPJIBE <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				private TaskAwaiter<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000176")]
				[Cpp2IlInjected.Address(RVA = "0x375DD10", Offset = "0x375C710", VA = "0x18375DD10", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000177")]
				[Cpp2IlInjected.Address(RVA = "0x8E5A10", Offset = "0x8E4410", VA = "0x1808E5A10", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public LAAAANJIGHN CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public Func<string> <>9__14;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public Action<string> <>9__15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public Action <>9__16;

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public FDKGFHPJIBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x3DDA350", Offset = "0x3DD8D50", VA = "0x183DDA350")]
			internal void GNKHOOGKAPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0")]
			internal string JHNLMFBOGIB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x8961C0", Offset = "0x894BC0", VA = "0x1808961C0")]
			internal void ODGPDBPGAMI(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x3DDA2B0", Offset = "0x3DD8CB0", VA = "0x183DDA2B0")]
			[AsyncStateMachine(typeof(NHHGKDHPBDL<>.FDKGFHPJIBE.<<AddDynamicNodeGroupSettingV2>b__16>d))]
			internal void EGLEKBEGEJF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		[CompilerGenerated]
		private sealed class AGKICLFNHGJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public KBHINEMHBJO nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public List<KPABBPKBIBN> portMenu;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public NHHGKDHPBDL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public MJGAEDNBJIL<LPDNCAKIDEG> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public int portCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public Func<bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public AGKICLFNHGJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x3E7E410", Offset = "0x3E7CE10", VA = "0x183E7E410")]
			internal bool CDJOBPMMFBA()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private sealed class OLBLGICMJOO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public DBDMDCDNCFC port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public AGKICLFNHGJ CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public OLBLGICMJOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x48FF970", Offset = "0x48FE370", VA = "0x1848FF970")]
			internal void FMAAEGPAANN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x48FFC00", Offset = "0x48FE600", VA = "0x1848FFC00")]
			internal bool PJGIIGIDNEO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x48FFAE0", Offset = "0x48FE4E0", VA = "0x1848FFAE0")]
			internal void PEAABIHPJKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x48FFA80", Offset = "0x48FE480", VA = "0x1848FFA80")]
			internal bool PDFGANDOGGL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private sealed class NAPGKNEPNHK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public KPABBPKBIBN portControls;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public OLBLGICMJOO CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public NAPGKNEPNHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x47D3110", Offset = "0x47D1B10", VA = "0x1847D3110")]
			internal void HHFKFGGKANL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class DKIAPLAAICI
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005D")]
			private struct <<CreatePortItemV2>b__3>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400012D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400012E")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400012F")]
				public DKIAPLAAICI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000130")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000131")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				private TaskAwaiter<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000187")]
				[Cpp2IlInjected.Address(RVA = "0x375FDB0", Offset = "0x375E7B0", VA = "0x18375FDB0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000188")]
				[Cpp2IlInjected.Address(RVA = "0x8E5A10", Offset = "0x8E4410", VA = "0x1808E5A10", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public List<object> allTypeObjects;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public BLDEJALINAE selectedType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public KBHINEMHBJO nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public DBDMDCDNCFC port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public LPGKJOMOPPD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public DKIAPLAAICI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x5B51F00", Offset = "0x5B50900", VA = "0x185B51F00")]
			internal int DNGJMKKFPMG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x5B51F40", Offset = "0x5B50940", VA = "0x185B51F40")]
			internal void DNNHIEDOFMB(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8999F0", Offset = "0x8983F0", VA = "0x1808999F0")]
			internal string JPCMNPBKJOF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x5B52180", Offset = "0x5B50B80", VA = "0x185B52180")]
			[AsyncStateMachine(typeof(NHHGKDHPBDL<>.DKIAPLAAICI.<<CreatePortItemV2>b__3>d))]
			internal void GCDLNGKFGDN(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x5B52240", Offset = "0x5B50C40", VA = "0x185B52240")]
			internal bool JEAFMFMONCO(string text)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly Dictionary<MJGAEDNBJIL<LPDNCAKIDEG>, bool> HPKAHDKCMIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly Dictionary<MJGAEDNBJIL<LPDNCAKIDEG>, bool> LLFEHPDLJJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private readonly Dictionary<MJGAEDNBJIL<LPDNCAKIDEG>, bool> AEFPLMHCLKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Dictionary<MJGAEDNBJIL<LPDNCAKIDEG>, bool> ALJGDJBJHPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private Dictionary<MJGAEDNBJIL<LPDNCAKIDEG>, bool> ODBFODCLOEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private Dictionary<MJGAEDNBJIL<LPDNCAKIDEG>, bool> DFBOALOJELJ;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool KKKMLKCCCEH
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected virtual bool EIHKDONLGKB
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "126")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected virtual bool ENLBGNHCLIG
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "127")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected virtual bool OFIDGNLADKM
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "128")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override MJGAEDNBJIL<IKLMIGOGHKN>? EIJBGHMALEG
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x47F76F0", Offset = "0x47F60F0", VA = "0x1847F76F0", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override MJGAEDNBJIL<LPDNCAKIDEG>? NCAMHCONKDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x47F79C0", Offset = "0x47F63C0", VA = "0x1847F79C0", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override IEnumerable<JEBPJLMNFAK<BKFIMEBJLKC>>? JKMOEEOGOEK
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x47F77B0", Offset = "0x47F61B0", VA = "0x1847F77B0", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x47F74D0", Offset = "0x47F5ED0", VA = "0x1847F74D0")]
		public NHHGKDHPBDL(PLLOHOJACCG PFCDDIODGEJ, TNode KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "129")]
		protected virtual bool LAACEBFPEJA(int DOEPPHBPIJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "130")]
		protected virtual bool MPAKOFICMOM(int DOEPPHBPIJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "131")]
		protected virtual bool LADLGLKECGE(int DOEPPHBPIJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "132")]
		protected virtual void ALIDHEPCNNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x47F30D0", Offset = "0x47F1AD0", VA = "0x1847F30D0", Slot = "124")]
		public override bool IBLEHLFAKBM(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x47F3170", Offset = "0x47F1B70", VA = "0x1847F3170", Slot = "100")]
		[AsyncStateMachine(typeof(NHHGKDHPBDL<>.GNICOODNNFJ))]
		public override Task<BCLNLKLFCPB<MJGAEDNBJIL<LPDNCAKIDEG>, OBJIPJOMIPB>> IGIMMPPOEKP(string KJPHMNNIMDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x47F2D20", Offset = "0x47F1720", VA = "0x1847F2D20", Slot = "101")]
		[AsyncStateMachine(typeof(NHHGKDHPBDL<>.FNAKMEIOHMP))]
		public override Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> GDGHCBBAPMO(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x47F4D50", Offset = "0x47F3750", VA = "0x1847F4D50", Slot = "102")]
		public override void LGEOIJJKPID(MJGAEDNBJIL<LPDNCAKIDEG> HGFDMIDEFHN, MJGAEDNBJIL<LPDNCAKIDEG> LLMCGMPLMBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x47F4F60", Offset = "0x47F3960", VA = "0x1847F4F60", Slot = "103")]
		public override IEnumerable<EHDCBMKEILE> LOGEDGOLNKD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x47F73D0", Offset = "0x47F5DD0", VA = "0x1847F73D0")]
		[AsyncStateMachine(typeof(NHHGKDHPBDL<>.AOLNCPJCBPJ))]
		private Task<BCLNLKLFCPB<LKBKALCJMFG, OBJIPJOMIPB>> OCGCJGFCELF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "133")]
		protected virtual bool NOBGOAPLPHB(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "134")]
		protected virtual bool FNDADCFCGDK(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "135")]
		protected virtual bool AJBHMCBOODG(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "136")]
		protected virtual bool OIDDMFDFCCD(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "137")]
		protected virtual bool HJLDGFMGFJC(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, int ICLJOJMKBJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "138")]
		protected virtual bool FIOBCNDHIAA(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, int ICLJOJMKBJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "139")]
		protected virtual bool EHLMIANPNIA(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, int JIJODOLNGLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "140")]
		protected virtual bool MHJBLHIMMEH(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, int JIJODOLNGLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "141")]
		protected virtual bool MHMMFHFFAJC(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, int DLKOGGNFIGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "142")]
		protected virtual bool GJPBIFFHGEH(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, int POPPKCBMEOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x47F2E30", Offset = "0x47F1830", VA = "0x1847F2E30", Slot = "143")]
		protected virtual List<BLDEJALINAE> GFILOLOCLIE(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "144")]
		protected virtual void FFBGKHDKPEL(PIDEGLEPBNK BKLAAIOGBOJ, LGFDHPNODBI PDONELNLLHC, KBHINEMHBJO MEHHBDDDBKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x47F6950", Offset = "0x47F5350", VA = "0x1847F6950", Slot = "120")]
		protected override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x47F51E0", Offset = "0x47F3BE0", VA = "0x1847F51E0")]
		private LGFDHPNODBI MLJMPHKCIAA(PIDEGLEPBNK BKLAAIOGBOJ, KBHINEMHBJO MEHHBDDDBKO, MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x47F3BF0", Offset = "0x47F25F0", VA = "0x1847F3BF0")]
		private List<KPABBPKBIBN> LGENPCAEICF(PIDEGLEPBNK BKLAAIOGBOJ, KBHINEMHBJO MEHHBDDDBKO, LGFDHPNODBI FGOPPHPEGAK, bool DAMPHGNICNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x47F3290", Offset = "0x47F1C90", VA = "0x1847F3290")]
		private List<KPABBPKBIBN> JIFCNAKJEIF(PIDEGLEPBNK BKLAAIOGBOJ, KBHINEMHBJO MEHHBDDDBKO, DBDMDCDNCFC EHGIOJOEILB, bool DAMPHGNICNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x47F2A90", Offset = "0x47F1490", VA = "0x1847F2A90")]
		private BLDEJALINAE DKDFJDFGJHD(List<BLDEJALINAE> OLAFDCFNOEJ, DBDMDCDNCFC EHGIOJOEILB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x47F2C80", Offset = "0x47F1680", VA = "0x1847F2C80")]
		[CompilerGenerated]
		private EHDCBMKEILE FJPFOGDELAM(DPIPCKFLLFL DMIMFDDIIBO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public sealed class KANBBMDGHIP : OCLPOHGKJMO<PPOKGLOPLNG>
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class GHFMLCGBHPD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public KANBBMDGHIP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public LPGKJOMOPPD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public GHFMLCGBHPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x2109B70", Offset = "0x2108570", VA = "0x182109B70")]
			internal int JDPFBIGGGNI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x2109BC0", Offset = "0x21085C0", VA = "0x182109BC0")]
			internal void MDAPEAKELDK(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NodeVisualizationKey PJJDBLNOLBI
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xB1ACC0", Offset = "0xB196C0", VA = "0x180B1ACC0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x210FE30", Offset = "0x210E830", VA = "0x18210FE30")]
		public KANBBMDGHIP(PLLOHOJACCG PFCDDIODGEJ, PPOKGLOPLNG KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x210FC70", Offset = "0x210E670", VA = "0x18210FC70", Slot = "120")]
		protected override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public sealed class GFJMBGJCGJM : GBMAMGMOMFA<LBELPNIEOBI>
	{
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class BAOHBCGIOME
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public GFJMBGJCGJM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public LPGKJOMOPPD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public BAOHBCGIOME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x21056C0", Offset = "0x21040C0", VA = "0x1821056C0")]
			internal int MJDFMONDNHO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x2105620", Offset = "0x2104020", VA = "0x182105620")]
			internal void AJMOMHLBAIF(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2109B10", Offset = "0x2108510", VA = "0x182109B10")]
		public GFJMBGJCGJM(PLLOHOJACCG PFCDDIODGEJ, LBELPNIEOBI BDPEMHOFOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x21098D0", Offset = "0x21082D0", VA = "0x1821098D0", Slot = "126")]
		protected override void MIIEKGIGHCK(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private sealed class HDPGJMFDEGA : OCLPOHGKJMO<LNJJBPKEDNK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey PJJDBLNOLBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xAF4810", Offset = "0xAF3210", VA = "0x180AF4810", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x210D400", Offset = "0x210BE00", VA = "0x18210D400")]
		public HDPGJMFDEGA(PLLOHOJACCG PFCDDIODGEJ, LNJJBPKEDNK KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "120")]
		protected override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class DKKMDKMIDLL : OCLPOHGKJMO<BJHOMAEDFOE>
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class MAEBCONHMCP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public DKKMDKMIDLL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public PIDEGLEPBNK configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public Func<string> <>9__224;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public Action<string> <>9__225;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public Func<int> <>9__228;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public Action<int> <>9__229;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public Func<bool> <>9__230;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public Func<bool> <>9__231;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Func<bool> <>9__232;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Func<float> <>9__233;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Action<float> <>9__234;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Func<bool> <>9__235;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Func<bool> <>9__236;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<bool> <>9__237;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Func<string> <>9__238;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Action<string> <>9__239;

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public MAEBCONHMCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x211B5E0", Offset = "0x2119FE0", VA = "0x18211B5E0")]
			internal bool JDPFBIGGGNI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x211C0A0", Offset = "0x211AAA0", VA = "0x18211C0A0")]
			internal void MDAPEAKELDK(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x211AEF0", Offset = "0x21198F0", VA = "0x18211AEF0")]
			internal bool IACLJHOBOIL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x21122D0", Offset = "0x2110CD0", VA = "0x1821122D0")]
			internal bool AADPJDPABMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x2118890", Offset = "0x2117290", VA = "0x182118890")]
			internal void BDPDDNLEAGC(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x211CA20", Offset = "0x211B420", VA = "0x18211CA20")]
			internal bool OGIOFKDKMKL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x211B750", Offset = "0x211A150", VA = "0x18211B750")]
			internal bool JHGLEIFOOFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x211CFD0", Offset = "0x211B9D0", VA = "0x18211CFD0")]
			internal void POPLGOOHKOK(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x211A6F0", Offset = "0x21190F0", VA = "0x18211A6F0")]
			internal bool GJFPENBENHO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x211C4D0", Offset = "0x211AED0", VA = "0x18211C4D0")]
			internal bool NFANODJDBMH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x211BBE0", Offset = "0x211A5E0", VA = "0x18211BBE0")]
			internal void KJAKMIEBMMA(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x211B210", Offset = "0x2119C10", VA = "0x18211B210")]
			internal bool IEDFAIDIJEA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x211BB40", Offset = "0x211A540", VA = "0x18211BB40")]
			internal bool KGAPHNIEBEE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x211AF90", Offset = "0x2119990", VA = "0x18211AF90")]
			internal bool IAJIDFKEGPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x21125B0", Offset = "0x2110FB0", VA = "0x1821125B0")]
			internal bool AHNBGNAAGAJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x211A220", Offset = "0x2118C20", VA = "0x18211A220")]
			internal bool FKMKOEEHCIO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x211B9B0", Offset = "0x211A3B0", VA = "0x18211B9B0")]
			internal bool KADCJOEMJCO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x211BDB0", Offset = "0x211A7B0", VA = "0x18211BDB0")]
			internal bool LDGAONAJICJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x211CE40", Offset = "0x211B840", VA = "0x18211CE40")]
			internal bool PFBJILODGOG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x211B410", Offset = "0x2119E10", VA = "0x18211B410")]
			internal bool IOIADJNAJGE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x2119BF0", Offset = "0x21185F0", VA = "0x182119BF0")]
			internal void ENHCNFFFJPA(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x211B3C0", Offset = "0x2119DC0", VA = "0x18211B3C0")]
			internal bool INCJICAENBL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x211AE50", Offset = "0x2119850", VA = "0x18211AE50")]
			internal bool HOFDANBLIDL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x21187F0", Offset = "0x21171F0", VA = "0x1821187F0")]
			internal bool BCIOKBHONCE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x211B7A0", Offset = "0x211A1A0", VA = "0x18211B7A0")]
			internal bool JJEHJNHJLBG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x2119760", Offset = "0x2118160", VA = "0x182119760")]
			internal bool EALMGIMAMEN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x21124D0", Offset = "0x2110ED0", VA = "0x1821124D0")]
			internal bool AGEIOLPHPIB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x211B2D0", Offset = "0x2119CD0", VA = "0x18211B2D0")]
			internal bool IJFPPNNNBAN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x211A900", Offset = "0x2119300", VA = "0x18211A900")]
			internal bool GNMJDKGPLKI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x211B900", Offset = "0x211A300", VA = "0x18211B900")]
			internal void JNOPPGCCECB(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x211AA90", Offset = "0x2119490", VA = "0x18211AA90")]
			internal bool HDBMPIMEEJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x2119BA0", Offset = "0x21185A0", VA = "0x182119BA0")]
			internal bool EMNMHAOAOON()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x211A7E0", Offset = "0x21191E0", VA = "0x18211A7E0")]
			internal void GKNAACCBKJP(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x211A6A0", Offset = "0x21190A0", VA = "0x18211A6A0")]
			internal bool GGLJPJKOIPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x211AD60", Offset = "0x2119760", VA = "0x18211AD60")]
			internal bool HKJNOAIOEHF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x2118D50", Offset = "0x2117750", VA = "0x182118D50")]
			internal void CDCPFOBAAIH(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x21126F0", Offset = "0x21110F0", VA = "0x1821126F0")]
			internal List<KPABBPKBIBN> AMKPFMGHEOI(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x21189E0", Offset = "0x21173E0", VA = "0x1821189E0")]
			internal bool BKBABMALCON()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x211A070", Offset = "0x2118A70", VA = "0x18211A070")]
			internal int FFPMIAECBAO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x211C770", Offset = "0x211B170", VA = "0x18211C770")]
			internal void NPKIJJGBIKM(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x211AC20", Offset = "0x2119620", VA = "0x18211AC20")]
			internal bool HIJANFFBNFK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x211CC00", Offset = "0x211B600", VA = "0x18211CC00")]
			internal bool OJDJOJMPMLJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x2119620", Offset = "0x2118020", VA = "0x182119620")]
			internal bool DJDGPOGLACC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x21198E0", Offset = "0x21182E0", VA = "0x1821198E0")]
			internal int EDNNLCBFAKF()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x211BEA0", Offset = "0x211A8A0", VA = "0x18211BEA0")]
			internal void LKGKGEMDENN(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x211BE00", Offset = "0x211A800", VA = "0x18211BE00")]
			internal bool LECIKKDEGIB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x211C720", Offset = "0x211B120", VA = "0x18211C720")]
			internal bool NOEPGFIBJNN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x2112410", Offset = "0x2110E10", VA = "0x182112410")]
			internal bool ADMLGLBAGAO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x211CCF0", Offset = "0x211B6F0", VA = "0x18211CCF0")]
			internal bool ONLOFMGLCDB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x211C930", Offset = "0x211B330", VA = "0x18211C930")]
			internal bool OEEFIILJPII()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x211BAA0", Offset = "0x211A4A0", VA = "0x18211BAA0")]
			internal bool KEIKOJEDNGO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x2112600", Offset = "0x2111000", VA = "0x182112600")]
			internal string AHNEGGFOJFH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x211A520", Offset = "0x2118F20", VA = "0x18211A520")]
			internal void GAPKKFLHKML(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x211C620", Offset = "0x211B020", VA = "0x18211C620")]
			internal int NJINHNOLKEO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x211BCE0", Offset = "0x211A6E0", VA = "0x18211BCE0")]
			internal void KLOICLHMLKK(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x2112320", Offset = "0x2110D20", VA = "0x182112320")]
			internal bool AAJDODIAPOD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x211BF00", Offset = "0x211A900", VA = "0x18211BF00")]
			internal bool LLMHBEPGCIC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x2119AE0", Offset = "0x21184E0", VA = "0x182119AE0")]
			internal bool ELLEHBOKCCB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x211CDF0", Offset = "0x211B7F0", VA = "0x18211CDF0")]
			internal float PBJJDAFGEIC()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x2119030", Offset = "0x2117A30", VA = "0x182119030")]
			internal void COBJKHKHBMA(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x211CCA0", Offset = "0x211B6A0", VA = "0x18211CCA0")]
			internal bool OMDBJGEMAMK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x211C6D0", Offset = "0x211B0D0", VA = "0x18211C6D0")]
			internal bool NNKGFOHDGLM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x211CBB0", Offset = "0x211B5B0", VA = "0x18211CBB0")]
			internal bool OIGKICBDEMI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x211CAC0", Offset = "0x211B4C0", VA = "0x18211CAC0")]
			internal bool OGOLHMIPJKO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x211B030", Offset = "0x2119A30", VA = "0x18211B030")]
			internal bool IAOCLMFDELB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x211B1C0", Offset = "0x2119BC0", VA = "0x18211B1C0")]
			internal bool IDKAJAHMDNN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x2119090", Offset = "0x2117A90", VA = "0x182119090")]
			internal void COFDLMCHPKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x2112370", Offset = "0x2110D70", VA = "0x182112370")]
			internal string ABMGMOIHOOE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x211B4B0", Offset = "0x2119EB0", VA = "0x18211B4B0")]
			internal void IPKBELJOOMC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x211B170", Offset = "0x2119B70", VA = "0x18211B170")]
			internal bool ICNDFDBHBKL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x2118FE0", Offset = "0x21179E0", VA = "0x182118FE0")]
			internal bool CLNEDJILHLN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x21195D0", Offset = "0x2117FD0", VA = "0x1821195D0")]
			internal bool DHLEFFBMJNG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x2119CF0", Offset = "0x21186F0", VA = "0x182119CF0")]
			internal void FBFCECBOOFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x211A110", Offset = "0x2118B10", VA = "0x18211A110")]
			internal bool FKADOMFOFPJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x2118B30", Offset = "0x2117530", VA = "0x182118B30")]
			internal bool BOBGNEJBIJG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x21188F0", Offset = "0x21172F0", VA = "0x1821188F0")]
			internal bool BEGAMFLJBGI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x211AE00", Offset = "0x2119800", VA = "0x18211AE00")]
			internal bool HNPHKHBMOLC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x211B6F0", Offset = "0x211A0F0", VA = "0x18211B6F0")]
			internal void JHBIDCBEALD(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x211B080", Offset = "0x2119A80", VA = "0x18211B080")]
			internal bool IAPLHGGODFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x211BE50", Offset = "0x211A850", VA = "0x18211BE50")]
			internal bool LEFLFAPPKJJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x2119C50", Offset = "0x2118650", VA = "0x182119C50")]
			internal bool FAPANMIKJNA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x2119440", Offset = "0x2117E40", VA = "0x182119440")]
			internal bool COJNPBMNCAP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x211CD90", Offset = "0x211B790", VA = "0x18211CD90")]
			internal void PAMNAEEPPEN(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x2118990", Offset = "0x2117390", VA = "0x182118990")]
			internal bool BJGFGDHGHLK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x211B370", Offset = "0x2119D70", VA = "0x18211B370")]
			internal bool IMHKFPJBLDJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x211C000", Offset = "0x211AA00", VA = "0x18211C000")]
			internal bool LNDBEBEACIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x2118F90", Offset = "0x2117990", VA = "0x182118F90")]
			internal bool CLGMCFILILD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x2118B80", Offset = "0x2117580", VA = "0x182118B80")]
			internal object BOLGHOKLNID()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x2118DB0", Offset = "0x21177B0", VA = "0x182118DB0")]
			internal void CEMBBMKLALC(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x211BA50", Offset = "0x211A450", VA = "0x18211BA50")]
			internal bool KCFGFMFJJCA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x211C1F0", Offset = "0x211ABF0", VA = "0x18211C1F0")]
			internal bool MJJIEFEGNEH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x211AA40", Offset = "0x2119440", VA = "0x18211AA40")]
			internal int HAKPICDEGDH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x211A420", Offset = "0x2118E20", VA = "0x18211A420")]
			internal void FONPGDGMCCB(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x211C1A0", Offset = "0x211ABA0", VA = "0x18211C1A0")]
			internal bool MJFNFIANIGD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x211CB10", Offset = "0x211B510", VA = "0x18211CB10")]
			internal bool OHANHGAIIAM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x211C820", Offset = "0x211B220", VA = "0x18211C820")]
			internal int OBFECCMEBKO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x211A270", Offset = "0x2118C70", VA = "0x18211A270")]
			internal void FKPFGDGDLJO(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x211AC70", Offset = "0x2119670", VA = "0x18211AC70")]
			internal bool HJDHKIFJCBA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x211BC40", Offset = "0x211A640", VA = "0x18211BC40")]
			internal bool KKPMFKNBOLB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x211A8B0", Offset = "0x21192B0", VA = "0x18211A8B0")]
			internal bool GNFKCOEPPHF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x211CF80", Offset = "0x211B980", VA = "0x18211CF80")]
			internal int PNMOLFHBJBA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x211C570", Offset = "0x211AF70", VA = "0x18211C570")]
			internal void NHCANDNPEGL(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x211CEE0", Offset = "0x211B8E0", VA = "0x18211CEE0")]
			internal bool PLDCLPAFLNN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x211BFB0", Offset = "0x211A9B0", VA = "0x18211BFB0")]
			internal bool LMJBGGDGLLL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x2119930", Offset = "0x2118330", VA = "0x182119930")]
			internal bool EFHOCLHGIHN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x2119A70", Offset = "0x2118470", VA = "0x182119A70")]
			internal object ELKDOGMBFKJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x2112520", Offset = "0x2110F20", VA = "0x182112520")]
			internal void AHKBGJNCAAJ(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x211C480", Offset = "0x211AE80", VA = "0x18211C480")]
			internal bool NEFJOLFLLAM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x21196C0", Offset = "0x21180C0", VA = "0x1821196C0")]
			internal bool DNONEACINOM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x211BD40", Offset = "0x211A740", VA = "0x18211BD40")]
			internal object LAJDFCGEPMJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x2119850", Offset = "0x2118250", VA = "0x182119850")]
			internal void EDNEPENKMEG(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x2119710", Offset = "0x2118110", VA = "0x182119710")]
			internal bool DPCMEPIHAAP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x211CA70", Offset = "0x211B470", VA = "0x18211CA70")]
			internal int OGKHNONGDME()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x211BF50", Offset = "0x211A950", VA = "0x18211BF50")]
			internal void LMBLAKHFCDJ(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x211AEA0", Offset = "0x21198A0", VA = "0x18211AEA0")]
			internal bool HPFPFCCJBGB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x211AB80", Offset = "0x2119580", VA = "0x18211AB80")]
			internal bool HEECEBBECFG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x211CE90", Offset = "0x211B890", VA = "0x18211CE90")]
			internal bool PKMFLJJOCFJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x21194E0", Offset = "0x2117EE0", VA = "0x1821194E0")]
			internal int DCBDELIAFKE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x211A320", Offset = "0x2118D20", VA = "0x18211A320")]
			internal void FMEPCPBFBHH(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x211B960", Offset = "0x211A360", VA = "0x18211B960")]
			internal bool JPBLMMABNKC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x211A9F0", Offset = "0x21193F0", VA = "0x18211A9F0")]
			internal bool GPKJAMPPIKJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x211C3D0", Offset = "0x211ADD0", VA = "0x18211C3D0")]
			internal bool NBJPAJKBNJM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x211ADB0", Offset = "0x21197B0", VA = "0x18211ADB0")]
			internal float HMDNHCAICKJ()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x211C670", Offset = "0x211B070", VA = "0x18211C670")]
			internal void NMEHMCECBKJ(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x2119980", Offset = "0x2118380", VA = "0x182119980")]
			internal bool EIDFOJEKDDG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x211B120", Offset = "0x2119B20", VA = "0x18211B120")]
			internal bool ICGLHGEIDHH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x211AD10", Offset = "0x2119710", VA = "0x18211AD10")]
			internal bool HKIHKCADBKG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x211C870", Offset = "0x211B270", VA = "0x18211C870")]
			internal float OCEOILEHFDD()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x2118A30", Offset = "0x2117430", VA = "0x182118A30")]
			internal void BKHHNOJNPMP(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x2118A90", Offset = "0x2117490", VA = "0x182118A90")]
			internal bool BNFAMAEFDKL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x211B460", Offset = "0x2119E60", VA = "0x18211B460")]
			internal bool IOOGNDOOGHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x21123C0", Offset = "0x2110DC0", VA = "0x1821123C0")]
			internal string ADJPJOAEJDI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x211A840", Offset = "0x2119240", VA = "0x18211A840")]
			internal void GMIOJNOHLHA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x211C520", Offset = "0x211AF20", VA = "0x18211C520")]
			internal bool NGIMBANHFDF(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x211A020", Offset = "0x2118A20", VA = "0x18211A020")]
			internal bool FDEEAKBIANH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x2118AE0", Offset = "0x21174E0", VA = "0x182118AE0")]
			internal bool BNGJHGBDIHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x211C240", Offset = "0x211AC40", VA = "0x18211C240")]
			internal bool MKDCHDPMEMC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x211A3D0", Offset = "0x2118DD0", VA = "0x18211A3D0")]
			internal string FNIEAIDDAEJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x211B520", Offset = "0x2119F20", VA = "0x18211B520")]
			internal void IPMHDJHHDIA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x211BAF0", Offset = "0x211A4F0", VA = "0x18211BAF0")]
			internal bool KEJEEIFBBNN(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x211B320", Offset = "0x2119D20", VA = "0x18211B320")]
			internal bool IKGACPLLIDN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x2119CA0", Offset = "0x21186A0", VA = "0x182119CA0")]
			internal bool FBDHCBLBCFL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x2119490", Offset = "0x2117E90", VA = "0x182119490")]
			internal bool DAKFCLMKEIJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x211B590", Offset = "0x2119F90", VA = "0x18211B590")]
			internal string JDFIMECBIFI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x211B890", Offset = "0x211A290", VA = "0x18211B890")]
			internal void JNFOILPOCAN(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x211C100", Offset = "0x211AB00", VA = "0x18211C100")]
			internal bool MFONBEAGDNM(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x211BB90", Offset = "0x211A590", VA = "0x18211BB90")]
			internal bool KIHDJFPKLBN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x211A590", Offset = "0x2118F90", VA = "0x18211A590")]
			internal bool GCJFJDAAHPK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x211C330", Offset = "0x211AD30", VA = "0x18211C330")]
			internal bool MNIAAPJMJHL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x211A9A0", Offset = "0x21193A0", VA = "0x18211A9A0")]
			internal string GPCCNBEPPLE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x2119B30", Offset = "0x2118530", VA = "0x182119B30")]
			internal void EMJOGHHEIDO(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x211A5E0", Offset = "0x2118FE0", VA = "0x18211A5E0")]
			internal bool GDMJILLEJAC(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x211CD40", Offset = "0x211B740", VA = "0x18211CD40")]
			internal bool OPGDALMCFGA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x211C7D0", Offset = "0x211B1D0", VA = "0x18211C7D0")]
			internal bool OAHOMKKNCDC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x2119800", Offset = "0x2118200", VA = "0x182119800")]
			internal bool ECPMICHIEHC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x211A160", Offset = "0x2118B60", VA = "0x18211A160")]
			internal string FKDLFBCGDLM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x211B680", Offset = "0x211A080", VA = "0x18211B680")]
			internal void JFAOGKCDLLI(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x211A4D0", Offset = "0x2118ED0", VA = "0x18211A4D0")]
			internal bool GAHAHOEFJGO(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x211B0D0", Offset = "0x2119AD0", VA = "0x18211B0D0")]
			internal bool IBAILKLEAIP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x211B630", Offset = "0x211A030", VA = "0x18211B630")]
			internal bool JFAALLANPGE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x211CB60", Offset = "0x211B560", VA = "0x18211CB60")]
			internal bool OHJJPHBHMHE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x211A2D0", Offset = "0x2118CD0", VA = "0x18211A2D0")]
			internal string FLADCNMDHFN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x2118780", Offset = "0x2117180", VA = "0x182118780")]
			internal void BCBCCDIIENN(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x2118E90", Offset = "0x2117890", VA = "0x182118E90")]
			internal bool CGLGLGGIMDI(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x211BC90", Offset = "0x211A690", VA = "0x18211BC90")]
			internal bool KLLDJIPPEJN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x2119580", Offset = "0x2117F80", VA = "0x182119580")]
			internal bool DGKAHLAFJPM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x211CF30", Offset = "0x211B930", VA = "0x18211CF30")]
			internal bool PNADGFDGHHG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x211AB30", Offset = "0x2119530", VA = "0x18211AB30")]
			internal string HEEANAPNKIN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x2112460", Offset = "0x2110E60", VA = "0x182112460")]
			internal void AFEAOMFHEEG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x211B840", Offset = "0x211A240", VA = "0x18211B840")]
			internal bool JMLGCBAPLKA(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x2118E40", Offset = "0x2117840", VA = "0x182118E40")]
			internal bool CFJPJEKGMPF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x2112650", Offset = "0x2111050", VA = "0x182112650")]
			internal bool AJOOLICBKGC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x211AAE0", Offset = "0x21194E0", VA = "0x18211AAE0")]
			internal bool HDPNIHPABIC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x211A380", Offset = "0x2118D80", VA = "0x18211A380")]
			internal string FNHGFLMHIJD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x2118C40", Offset = "0x2117640", VA = "0x182118C40")]
			internal void BPEPLBMPGCC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x211C150", Offset = "0x211AB50", VA = "0x18211C150")]
			internal bool MGFLJCMIHPO(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x2119530", Offset = "0x2117F30", VA = "0x182119530")]
			internal bool DEGPHLHEDOP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x211A0C0", Offset = "0x2118AC0", VA = "0x18211A0C0")]
			internal bool FJEJIEJBICI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x211CC50", Offset = "0x211B650", VA = "0x18211CC50")]
			internal bool OMCBOKIBPAD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x211ACC0", Offset = "0x21196C0", VA = "0x18211ACC0")]
			internal string HKCMCOAEJHO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x211A1B0", Offset = "0x2118BB0", VA = "0x18211A1B0")]
			internal void FKIMFMHGANM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x211A740", Offset = "0x2119140", VA = "0x18211A740")]
			internal bool GKBJEAAKJAK(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x2119670", Offset = "0x2118070", VA = "0x182119670")]
			internal bool DLCFCAMBFOJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x211C5D0", Offset = "0x211AFD0", VA = "0x18211C5D0")]
			internal bool NHIAKLLLIEK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x211B7F0", Offset = "0x211A1F0", VA = "0x18211B7F0")]
			internal bool JMCGDAFOFAE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x211ABD0", Offset = "0x21195D0", VA = "0x18211ABD0")]
			internal string HHKKBOAGMDI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x211B260", Offset = "0x2119C60", VA = "0x18211B260")]
			internal void IFICMDGLEHA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x211A790", Offset = "0x2119190", VA = "0x18211A790")]
			internal bool GKMLNPJHEBF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x2118CB0", Offset = "0x21176B0", VA = "0x182118CB0")]
			internal bool CAOHAAFOGPD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x211C050", Offset = "0x211AA50", VA = "0x18211C050")]
			internal bool MBPJAIBBCDO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x2118840", Offset = "0x2117240", VA = "0x182118840")]
			internal string BDKAIHBDMAI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x2119FB0", Offset = "0x21189B0", VA = "0x182119FB0")]
			internal void FCFGOPDHBEG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x2118BF0", Offset = "0x21175F0", VA = "0x182118BF0")]
			internal bool BPDIHAHAJGP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x211A950", Offset = "0x2119350", VA = "0x18211A950")]
			internal bool GNOHNPGBLFH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x211AF40", Offset = "0x2119940", VA = "0x18211AF40")]
			internal bool IADBFBPPGAP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x211AFE0", Offset = "0x21199E0", VA = "0x18211AFE0")]
			internal string IAOCKFLPMJC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x211C8C0", Offset = "0x211B2C0", VA = "0x18211C8C0")]
			internal void ODFGKFFNDOM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x2118D00", Offset = "0x2117700", VA = "0x182118D00")]
			internal bool CDAPGENKPGJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x211C980", Offset = "0x211B380", VA = "0x18211C980")]
			internal bool OFGDLNBNEEA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x211C380", Offset = "0x211AD80", VA = "0x18211C380")]
			internal bool MOMFNCCCJJH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x2119A20", Offset = "0x2118420", VA = "0x182119A20")]
			internal string ELDGMMBEFGE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x211A630", Offset = "0x2119030", VA = "0x18211A630")]
			internal void GEHNIIHEHKH(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x21199D0", Offset = "0x21183D0", VA = "0x1821199D0")]
			internal bool ELAKBONOPAH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x2118F40", Offset = "0x2117940", VA = "0x182118F40")]
			internal bool CLBONIIEFIN(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x2118940", Offset = "0x2117340", VA = "0x182118940")]
			internal float BGHDAMPNBIE()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x211C420", Offset = "0x211AE20", VA = "0x18211C420")]
			internal void NCGIHDFKJDO(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x21197B0", Offset = "0x21181B0", VA = "0x1821197B0")]
			internal bool ECCDKDLDKLJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x211C2E0", Offset = "0x211ACE0", VA = "0x18211C2E0")]
			internal bool MMFJNDAJBIG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x211BA00", Offset = "0x211A400", VA = "0x18211BA00")]
			internal bool KAPAOLPPKJN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x211C9D0", Offset = "0x211B3D0", VA = "0x18211C9D0")]
			internal int OGFNAGLJFPC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x2118EE0", Offset = "0x21178E0", VA = "0x182118EE0")]
			internal void CJCHHMDBNEA(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x211A480", Offset = "0x2118E80", VA = "0x18211A480")]
			internal bool FOOPGHNODPB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x21126A0", Offset = "0x21110A0", VA = "0x1821126A0")]
			internal bool ALBJKOKFEJI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x211C290", Offset = "0x211AC90", VA = "0x18211C290")]
			internal bool MLMGNHIHPDF()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class PKGHHMDOFNJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public MAEBCONHMCP CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public PKGHHMDOFNJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x211F030", Offset = "0x211DA30", VA = "0x18211F030")]
			internal void KMDMOHAAJFB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class CPNJHKBINGO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public CPNJHKBINGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x2106CA0", Offset = "0x21056A0", VA = "0x182106CA0")]
			internal bool IEAGJDBOJIO(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly CFPOLMBGNDM IHCFGNNIHAB;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2108B80", Offset = "0x2107580", VA = "0x182108B80")]
		public DKKMDKMIDLL(PLLOHOJACCG PFCDDIODGEJ, BJHOMAEDFOE KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2106E40", Offset = "0x2105840", VA = "0x182106E40", Slot = "120")]
		protected override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class HEHHBCPIFOJ : OCLPOHGKJMO<FBMNPKIAFPD>
	{
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class EEGHNCGCEEL
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006A")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000175")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000176")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000177")]
				public EEGHNCGCEEL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				private TaskAwaiter<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002A5")]
				[Cpp2IlInjected.Address(RVA = "0x213EAC0", Offset = "0x213D4C0", VA = "0x18213EAC0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0x8E5A10", Offset = "0x8E4410", VA = "0x1808E5A10", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public HEHHBCPIFOJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public LPGKJOMOPPD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public EEGHNCGCEEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x2125CB0", Offset = "0x21246B0", VA = "0x182125CB0")]
			internal string JDPFBIGGGNI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x2125D00", Offset = "0x2124700", VA = "0x182125D00")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void MDAPEAKELDK(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x2125DD0", Offset = "0x21247D0", VA = "0x182125DD0")]
			internal int NLOAMKMODOM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x2125C20", Offset = "0x2124620", VA = "0x182125C20")]
			internal void IIBCAKFOPMO(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override NodeVisualizationKey PJJDBLNOLBI
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xB1ACC0", Offset = "0xB196C0", VA = "0x180B1ACC0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x212E8D0", Offset = "0x212D2D0", VA = "0x18212E8D0")]
		public HEHHBCPIFOJ(PLLOHOJACCG PFCDDIODGEJ, FBMNPKIAFPD BDPEMHOFOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x212E580", Offset = "0x212CF80", VA = "0x18212E580", Slot = "120")]
		protected override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public sealed class JICBDEFPIKE : OCLPOHGKJMO<ILLAHPLLLPF>
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private sealed class LABOALLIDAD
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006D")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				public LABOALLIDAD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000180")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000181")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000182")]
				private TaskAwaiter<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BA")]
				[Cpp2IlInjected.Address(RVA = "0x213E780", Offset = "0x213D180", VA = "0x18213E780", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BB")]
				[Cpp2IlInjected.Address(RVA = "0x8E5A10", Offset = "0x8E4410", VA = "0x1808E5A10", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006E")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000183")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000184")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000185")]
				public LABOALLIDAD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000188")]
				private TaskAwaiter<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x213EDD0", Offset = "0x213D7D0", VA = "0x18213EDD0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0x8E5A10", Offset = "0x8E4410", VA = "0x1808E5A10", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public JICBDEFPIKE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public LPGKJOMOPPD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public LABOALLIDAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x2137070", Offset = "0x2135A70", VA = "0x182137070")]
			internal string JDPFBIGGGNI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x2137160", Offset = "0x2135B60", VA = "0x182137160")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void MDAPEAKELDK(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x2137230", Offset = "0x2135C30", VA = "0x182137230")]
			internal int NLOAMKMODOM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x2136FE0", Offset = "0x21359E0", VA = "0x182136FE0")]
			internal void IIBCAKFOPMO(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x2136F90", Offset = "0x2135990", VA = "0x182136F90")]
			internal string IACLJHOBOIL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x2136D10", Offset = "0x2135710", VA = "0x182136D10")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void AADPJDPABMP(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x2136E40", Offset = "0x2135840", VA = "0x182136E40")]
			internal bool BDPDDNLEAGC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x2136E90", Offset = "0x2135890", VA = "0x182136E90")]
			internal void FICJGAHFHBG(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x2137110", Offset = "0x2135B10", VA = "0x182137110")]
			internal bool LBPBDKOKHMB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x2137280", Offset = "0x2135C80", VA = "0x182137280")]
			internal void OGIOFKDKMKL(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x21370C0", Offset = "0x2135AC0", VA = "0x1821370C0")]
			internal float JHGLEIFOOFC()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x21373B0", Offset = "0x2135DB0", VA = "0x1821373B0")]
			internal void POPLGOOHKOK(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x2136DE0", Offset = "0x21357E0", VA = "0x182136DE0")]
			internal int AIEJHEIONHE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x2137310", Offset = "0x2135D10", VA = "0x182137310")]
			internal void PIANLAOJJDB(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x2136F20", Offset = "0x2135920", VA = "0x182136F20")]
			internal bool GJFPENBENHO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey PJJDBLNOLBI
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0xB1ACC0", Offset = "0xB196C0", VA = "0x180B1ACC0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x2135D80", Offset = "0x2134780", VA = "0x182135D80")]
		public JICBDEFPIKE(PLLOHOJACCG PFCDDIODGEJ, ILLAHPLLLPF KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x2135340", Offset = "0x2133D40", VA = "0x182135340", Slot = "120")]
		protected override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class DOPICIMIIJA : OCLPOHGKJMO<BGPKFLKODOA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class GLPLCAILJIP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public LPGKJOMOPPD nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public DOPICIMIIJA <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public GLPLCAILJIP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x212DE60", Offset = "0x212C860", VA = "0x18212DE60")]
			internal Dictionary<string, OKCGCELKKAL> JDPFBIGGGNI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x212DF00", Offset = "0x212C900", VA = "0x18212DF00")]
			internal int MDAPEAKELDK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x212DF50", Offset = "0x212C950", VA = "0x18212DF50")]
			internal void NLOAMKMODOM(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x212DDE0", Offset = "0x212C7E0", VA = "0x18212DDE0")]
			internal bool IIBCAKFOPMO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey PJJDBLNOLBI
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xB1ACC0", Offset = "0xB196C0", VA = "0x180B1ACC0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x2125BB0", Offset = "0x21245B0", VA = "0x182125BB0")]
		public DOPICIMIIJA(PLLOHOJACCG PFCDDIODGEJ, BGPKFLKODOA BDPEMHOFOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x21258E0", Offset = "0x21242E0", VA = "0x1821258E0", Slot = "120")]
		protected override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class CEJDGDPCHAF : OCLPOHGKJMO<EIPPOODHFIE>
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private sealed class AJGECFENONK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public LPGKJOMOPPD nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public CEJDGDPCHAF <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public AJGECFENONK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x21242C0", Offset = "0x2122CC0", VA = "0x1821242C0")]
			internal void JDPFBIGGGNI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey PJJDBLNOLBI
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0xB1ACC0", Offset = "0xB196C0", VA = "0x180B1ACC0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x2124F00", Offset = "0x2123900", VA = "0x182124F00")]
		public CEJDGDPCHAF(PLLOHOJACCG PFCDDIODGEJ, EIPPOODHFIE BDPEMHOFOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x2124D80", Offset = "0x2123780", VA = "0x182124D80", Slot = "120")]
		protected override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private sealed class GEPIFBFAPML : NHHGKDHPBDL<NFLDBNMGCFN>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool FEHIDMPCHDO
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override bool DHMDIDJKFCL
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x212D6F0", Offset = "0x212C0F0", VA = "0x18212D6F0", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override NodeVisualizationKey PJJDBLNOLBI
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x99FAF0", Offset = "0x99E4F0", VA = "0x18099FAF0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x212D690", Offset = "0x212C090", VA = "0x18212D690")]
		public GEPIFBFAPML(PLLOHOJACCG PFCDDIODGEJ, NFLDBNMGCFN KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "120")]
		protected override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	private sealed class HAFBIGNFLCF : OCLPOHGKJMO<CAOODCIFEKN>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override NodeVisualizationKey PJJDBLNOLBI
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xAEDA10", Offset = "0xAEC410", VA = "0x180AEDA10", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x212E510", Offset = "0x212CF10", VA = "0x18212E510")]
		public HAFBIGNFLCF(PLLOHOJACCG PFCDDIODGEJ, CAOODCIFEKN KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "120")]
		protected override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class MMMMHGCJCJM : OCLPOHGKJMO<OCGMFNOMJME>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override NodeVisualizationKey PJJDBLNOLBI
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0xB2EB80", Offset = "0xB2D580", VA = "0x180B2EB80", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x213D020", Offset = "0x213BA20", VA = "0x18213D020")]
		public MMMMHGCJCJM(PLLOHOJACCG PFCDDIODGEJ, OCGMFNOMJME KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "112")]
		protected override bool GIBGGBJCBHD(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "120")]
		protected override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class FNPNJPPMCOE : OCLPOHGKJMO<MMJGIPPLNPB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override NodeVisualizationKey PJJDBLNOLBI
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x991A90", Offset = "0x990490", VA = "0x180991A90", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool PDCHHCNMNKC
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x212D470", Offset = "0x212BE70", VA = "0x18212D470", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected override bool HAHGFBEMNBC
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x212D400", Offset = "0x212BE00", VA = "0x18212D400")]
		public FNPNJPPMCOE(PLLOHOJACCG PFCDDIODGEJ, MMJGIPPLNPB KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "120")]
		protected override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private sealed class PLJEICLGFCN : OCLPOHGKJMO<CEMLDIGKCDG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override NodeVisualizationKey PJJDBLNOLBI
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x98E810", Offset = "0x98D210", VA = "0x18098E810", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override bool PDCHHCNMNKC
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x213E370", Offset = "0x213CD70", VA = "0x18213E370", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		protected override bool HAHGFBEMNBC
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x213E300", Offset = "0x213CD00", VA = "0x18213E300")]
		public PLJEICLGFCN(PLLOHOJACCG PFCDDIODGEJ, CEMLDIGKCDG KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "120")]
		protected override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public sealed class HMHIJNIDNPC : GBMAMGMOMFA<PEADKCIDNDM>
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		[CompilerGenerated]
		private sealed class FFIMMAMBBCF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public HMHIJNIDNPC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public LPGKJOMOPPD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public FFIMMAMBBCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x212CEE0", Offset = "0x212B8E0", VA = "0x18212CEE0")]
			internal float MJDFMONDNHO()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x212CE40", Offset = "0x212B840", VA = "0x18212CE40")]
			internal void AJMOMHLBAIF(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x212F410", Offset = "0x212DE10", VA = "0x18212F410")]
		public HMHIJNIDNPC(PLLOHOJACCG PFCDDIODGEJ, PEADKCIDNDM BDPEMHOFOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x212F190", Offset = "0x212DB90", VA = "0x18212F190", Slot = "126")]
		protected override void MIIEKGIGHCK(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public sealed class NHFLCCNJPBI : OCLPOHGKJMO<FPMEGHEJECG>
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		[CompilerGenerated]
		private sealed class GEIPMFHPKMI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public NHFLCCNJPBI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public LPGKJOMOPPD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public GEIPMFHPKMI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x212D520", Offset = "0x212BF20", VA = "0x18212D520")]
			internal bool JDPFBIGGGNI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x212D570", Offset = "0x212BF70", VA = "0x18212D570")]
			internal void MDAPEAKELDK(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x213D7A0", Offset = "0x213C1A0", VA = "0x18213D7A0")]
		public NHFLCCNJPBI(PLLOHOJACCG PFCDDIODGEJ, FPMEGHEJECG BDPEMHOFOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x213D4F0", Offset = "0x213BEF0", VA = "0x18213D4F0", Slot = "120")]
		protected override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public sealed class EFCOGAPLLMO : OCLPOHGKJMO<ELPPFLGBNNL>
	{
		[Cpp2IlInjected.Token(Token = "0x200007D")]
		[CompilerGenerated]
		private sealed class HOBCPKFGINP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public LPGKJOMOPPD nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public EFCOGAPLLMO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public HOBCPKFGINP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x212F720", Offset = "0x212E120", VA = "0x18212F720")]
			internal object JDPFBIGGGNI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x212F5E0", Offset = "0x212DFE0", VA = "0x18212F5E0")]
			internal bool FICJGAHFHBG(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x212F850", Offset = "0x212E250", VA = "0x18212F850")]
			internal void MDAPEAKELDK(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x212FAA0", Offset = "0x212E4A0", VA = "0x18212FAA0")]
			internal string NLOAMKMODOM(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x212F6D0", Offset = "0x212E0D0", VA = "0x18212F6D0")]
			internal IReadOnlyList<object> IIBCAKFOPMO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x212F660", Offset = "0x212E060", VA = "0x18212F660")]
			internal bool IACLJHOBOIL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x212F470", Offset = "0x212DE70", VA = "0x18212F470")]
			internal bool AADPJDPABMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x212F4C0", Offset = "0x212DEC0", VA = "0x18212F4C0")]
			internal void BDPDDNLEAGC(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x2126910", Offset = "0x2125310", VA = "0x182126910")]
		public EFCOGAPLLMO(PLLOHOJACCG PFCDDIODGEJ, ELPPFLGBNNL BDPEMHOFOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x21260D0", Offset = "0x2124AD0", VA = "0x1821260D0", Slot = "120")]
		protected override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public sealed class PIOPIBDNBLM : NICBEFPGHCP<ABCKCMIJIDL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override NodeVisualizationKey PJJDBLNOLBI
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x99D1B0", Offset = "0x99BBB0", VA = "0x18099D1B0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x213DF20", Offset = "0x213C920", VA = "0x18213DF20")]
		public PIOPIBDNBLM(PLLOHOJACCG PFCDDIODGEJ, ABCKCMIJIDL KOHLOCENPAH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public sealed class GKAEJGMDFGN : GBMAMGMOMFA<MCLCIFFOIKA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class AEIGFPNJMJH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public GKAEJGMDFGN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public LPGKJOMOPPD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public AEIGFPNJMJH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x2124240", Offset = "0x2122C40", VA = "0x182124240")]
			internal int MJDFMONDNHO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x21241A0", Offset = "0x2122BA0", VA = "0x1821241A0")]
			internal void AJMOMHLBAIF(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x212DD80", Offset = "0x212C780", VA = "0x18212DD80")]
		public GKAEJGMDFGN(PLLOHOJACCG PFCDDIODGEJ, MCLCIFFOIKA BDPEMHOFOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x212DAF0", Offset = "0x212C4F0", VA = "0x18212DAF0", Slot = "126")]
		protected override void MIIEKGIGHCK(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public sealed class CHGDNLGGNGN : OCLPOHGKJMO<PBHIEABDMBD>
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		[CompilerGenerated]
		private sealed class HIMPIJFEHLO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public CHGDNLGGNGN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public LPGKJOMOPPD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public HIMPIJFEHLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x212F0B0", Offset = "0x212DAB0", VA = "0x18212F0B0")]
			internal bool JDPFBIGGGNI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x212F100", Offset = "0x212DB00", VA = "0x18212F100")]
			internal void MDAPEAKELDK(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x2125150", Offset = "0x2123B50", VA = "0x182125150")]
		public CHGDNLGGNGN(PLLOHOJACCG PFCDDIODGEJ, PBHIEABDMBD BDPEMHOFOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x2124F70", Offset = "0x2123970", VA = "0x182124F70", Slot = "120")]
		protected override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class KFIAFKODKOB : OCLPOHGKJMO<LFMBFCLHMLK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		[CompilerGenerated]
		private sealed class MIBGFDNOAFD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public KFIAFKODKOB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public LPGKJOMOPPD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public MIBGFDNOAFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x2137970", Offset = "0x2136370", VA = "0x182137970")]
			internal bool JDPFBIGGGNI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x21379C0", Offset = "0x21363C0", VA = "0x1821379C0")]
			internal void MDAPEAKELDK(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x2136A80", Offset = "0x2135480", VA = "0x182136A80")]
		public KFIAFKODKOB(PLLOHOJACCG PFCDDIODGEJ, LFMBFCLHMLK BDPEMHOFOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x21368A0", Offset = "0x21352A0", VA = "0x1821368A0", Slot = "120")]
		protected override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class KCCPFMEEPJC : OCLPOHGKJMO<JEOPIHALAHI>
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		[CompilerGenerated]
		private sealed class BMHIEIOLONK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public KCCPFMEEPJC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public LPGKJOMOPPD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public BMHIEIOLONK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x21248A0", Offset = "0x21232A0", VA = "0x1821248A0")]
			internal int JDPFBIGGGNI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x21248F0", Offset = "0x21232F0", VA = "0x1821248F0")]
			internal void MDAPEAKELDK(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x2136830", Offset = "0x2135230", VA = "0x182136830")]
		public KCCPFMEEPJC(PLLOHOJACCG PFCDDIODGEJ, JEOPIHALAHI BDPEMHOFOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x21365C0", Offset = "0x2134FC0", VA = "0x1821365C0", Slot = "120")]
		protected override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class ICDNDMINAHH : JJMDOICAKMK<DEOIDKEEKNJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override KALNDDFHJJG FCCCJLPHOED
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x923D80", Offset = "0x922780", VA = "0x180923D80", Slot = "126")]
			get
			{
				return default(KALNDDFHJJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x2133CE0", Offset = "0x21326E0", VA = "0x182133CE0")]
		public ICDNDMINAHH(PLLOHOJACCG PFCDDIODGEJ, DEOIDKEEKNJ BDPEMHOFOHC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class OEOAPHDGOOK : OCLPOHGKJMO<DPIPCKFLLFL>
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x21374A0", Offset = "0x2135EA0", VA = "0x1821374A0")]
		public OEOAPHDGOOK(PLLOHOJACCG PFCDDIODGEJ, DPIPCKFLLFL KOHLOCENPAH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public abstract class OCLPOHGKJMO<TNode> : KJBJNDHGBLH, IDisposable where TNode : notnull, DPIPCKFLLFL
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		[CompilerGenerated]
		private sealed class DFIPEMNICNL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public OCLPOHGKJMO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			public PLLOHOJACCG circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public DFIPEMNICNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x5B34970", Offset = "0x5B33370", VA = "0x185B34970")]
			internal FAADKMCMNDL IGNPGFGFNDJ(IJBKFIGEKJK portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		[CompilerGenerated]
		private struct IMEHJKKPNGG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public OCLPOHGKJMO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private TaskAwaiter<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x40B6620", Offset = "0x40B5020", VA = "0x1840B6620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x8E5A10", Offset = "0x8E4410", VA = "0x1808E5A10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		[CompilerGenerated]
		private struct ODENAMOOKAO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public AsyncTaskMethodBuilder<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public OCLPOHGKJMO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public MMPJAFGCJFL? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public JGKIEDLDOEA? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			private TaskAwaiter<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x48EC640", Offset = "0x48EB040", VA = "0x1848EC640", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x48EC8F0", Offset = "0x48EB2F0", VA = "0x1848EC8F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008D")]
		[CompilerGenerated]
		private sealed class COIJJOOBBKJ
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200008E")]
			private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C8")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C9")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CA")]
				public COIJJOOBBKJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CB")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000396")]
				[Cpp2IlInjected.Address(RVA = "0x375EB50", Offset = "0x375D550", VA = "0x18375EB50", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000397")]
				[Cpp2IlInjected.Address(RVA = "0x8E5A10", Offset = "0x8E4410", VA = "0x1808E5A10", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public Func<string, bool> submitValidator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public LPGKJOMOPPD nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public OCLPOHGKJMO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public PIDEGLEPBNK configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public COIJJOOBBKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0")]
			internal string OKFDJHDAJJE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x8961C0", Offset = "0x894BC0", VA = "0x1808961C0")]
			internal void IOGNFCBEPJK(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0x5861D00", Offset = "0x5860700", VA = "0x185861D00")]
			[AsyncStateMachine(typeof(OCLPOHGKJMO<>.COIJJOOBBKJ.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void ABNIINCLKNE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		[CompilerGenerated]
		private sealed class PCEDEPHLBMC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public LPGKJOMOPPD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public PCEDEPHLBMC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x49E2260", Offset = "0x49E0C60", VA = "0x1849E2260")]
			internal bool POGAKMMHBMA(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x49E2250", Offset = "0x49E0C50", VA = "0x1849E2250")]
			internal bool DOIOIFNDMFE(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000090")]
		[CompilerGenerated]
		private struct EMDHONGMIPH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public AsyncTaskMethodBuilder<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public OCLPOHGKJMO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			private TaskAwaiter<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x3A5A9B0", Offset = "0x3A593B0", VA = "0x183A5A9B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x3A5AD40", Offset = "0x3A59740", VA = "0x183A5AD40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private readonly PLLOHOJACCG EBBHMAKIMNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly bool FILBJGDIALD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private FJAMCDMCAND<LPDNCAKIDEG, FAADKMCMNDL> DCELFFKBCJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private FJAMCDMCAND<LPDNCAKIDEG, KBHINEMHBJO> CALOELBDMLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private List<Action> FGMBHCNLGPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[CompilerGenerated]
		private Action<MJGAEDNBJIL<LPDNCAKIDEG>>? JNPPIEOCNIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[CompilerGenerated]
		private Action<MJGAEDNBJIL<LPDNCAKIDEG>, KBHINEMHBJO>? FBEOPBNKLAB;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		protected JLECLAOCGDF EGAMEHMADCG
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x48E5630", Offset = "0x48E4030", VA = "0x1848E5630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		protected LPGKJOMOPPD BHJIDJAIGAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x48E5990", Offset = "0x48E4390", VA = "0x1848E5990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		protected TNode DFIMPCAKHHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x8999A0", Offset = "0x8983A0", VA = "0x1808999A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public JEBPJLMNFAK<MGGLKJAMIBN> GFABNPDOHOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0xD78D20", Offset = "0xD77720", VA = "0x180D78D20", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(JEBPJLMNFAK<MGGLKJAMIBN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public MJGAEDNBJIL<HHMCJPEBKAJ> ICMKOEOHHMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x48E80B0", Offset = "0x48E6AB0", VA = "0x1848E80B0", Slot = "6")]
			get
			{
				return default(MJGAEDNBJIL<HHMCJPEBKAJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public object IECKENPPIJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x3AABC00", Offset = "0x3AAA600", VA = "0x183AABC00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public virtual bool CKKCDABPNJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int EGMBGINKKJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x48E7CE0", Offset = "0x48E66E0", VA = "0x1848E7CE0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public OKNBGAPNIGA NEEFEBAJHHE
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x48E7C80", Offset = "0x48E6680", VA = "0x1848E7C80", Slot = "10")]
			get
			{
				return default(OKNBGAPNIGA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string AIELMMHNEBD
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x48E8270", Offset = "0x48E6C70", VA = "0x1848E8270", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		protected virtual bool HAHGFBEMNBC
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual NodeVisualizationKey PJJDBLNOLBI
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public MJGAEDNBJIL<KLEOIHDMDMO> EKJKNLGKFPI
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x90B290", Offset = "0x909C90", VA = "0x18090B290", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(MJGAEDNBJIL<KLEOIHDMDMO>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x90C330", Offset = "0x90AD30", VA = "0x18090C330")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual bool PDCHHCNMNKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual bool FEHIDMPCHDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual GFPNMCHHOBN LKOINDAEEGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x9E1690", Offset = "0x9E0090", VA = "0x1809E1690", Slot = "94")]
			get
			{
				return default(GFPNMCHHOBN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool KHABJCKHCKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x48E7990", Offset = "0x48E6390", VA = "0x1848E7990", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool CAFEMOGJHAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x48E7A00", Offset = "0x48E6400", VA = "0x1848E7A00", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool OENLIGGOFLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x48E7A70", Offset = "0x48E6470", VA = "0x1848E7A70", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int BDIFLNOPBMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x48E8050", Offset = "0x48E6A50", VA = "0x1848E8050", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool PKLJBFCHEOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x48E7E70", Offset = "0x48E6870", VA = "0x1848E7E70", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool DPHDEEAGBNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x48E7BA0", Offset = "0x48E65A0", VA = "0x1848E7BA0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool MKBALEAEIKK
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x48E7B30", Offset = "0x48E6530", VA = "0x1848E7B30", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool MECHICIEFPB
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x9C9540", Offset = "0x9C7F40", VA = "0x1809C9540", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0xEC1370", Offset = "0xEBFD70", VA = "0x180EC1370")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public virtual bool FKAFFAEIEAE
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual bool MCMFFKLBFLI
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x48E7AE0", Offset = "0x48E64E0", VA = "0x1848E7AE0", Slot = "96")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool KAPJNPAODOP
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x48E7DA0", Offset = "0x48E67A0", VA = "0x1848E7DA0", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public MMPJAFGCJFL NBIMBFHIDEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x48E7F90", Offset = "0x48E6990", VA = "0x1848E7F90", Slot = "28")]
			get
			{
				return default(MMPJAFGCJFL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public JGKIEDLDOEA DGNKNFBAMNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x48E7FF0", Offset = "0x48E69F0", VA = "0x1848E7FF0", Slot = "30")]
			get
			{
				return default(JGKIEDLDOEA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool KINHEGKKMLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "108")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual MFJDJJJDGNB? GEOEEICGHNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "109")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual BBBMOIPJCFG? AHOJLAOMAJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual IEnumerable<JEBPJLMNFAK<BKFIMEBJLKC>>? JKMOEEOGOEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool ALCHGFOALAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x48E7C10", Offset = "0x48E6610", VA = "0x1848E7C10", Slot = "114")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public JEBPJLMNFAK<IKLMIGOGHKN> AMOEOBKAIDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x48E7ED0", Offset = "0x48E68D0", VA = "0x1848E7ED0", Slot = "62")]
			get
			{
				return default(JEBPJLMNFAK<IKLMIGOGHKN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public MJGAEDNBJIL<IKLMIGOGHKN> EPGBOEDHPEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x48E7D40", Offset = "0x48E6740", VA = "0x1848E7D40", Slot = "56")]
			get
			{
				return default(MJGAEDNBJIL<IKLMIGOGHKN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public virtual bool EIDDJGDEAPB
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public virtual MJGAEDNBJIL<IKLMIGOGHKN>? EIJBGHMALEG
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public virtual bool DHMDIDJKFCL
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool EMANMPLOAIC
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x48E7E00", Offset = "0x48E6800", VA = "0x1848E7E00", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string FHACOBMPENF
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x89F780", Offset = "0x89E180", VA = "0x18089F780", Slot = "64")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x89F7B0", Offset = "0x89E1B0", VA = "0x18089F7B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		private string IMCENAIAKON
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x89F720", Offset = "0x89E120", VA = "0x18089F720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public JEBPJLMNFAK<BKFIMEBJLKC> CMGBDIMJDNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x48E7F30", Offset = "0x48E6930", VA = "0x1848E7F30", Slot = "63")]
			get
			{
				return default(JEBPJLMNFAK<BKFIMEBJLKC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public JEBPJLMNFAK<BKFIMEBJLKC>? OEAKIOIIIJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x48E8140", Offset = "0x48E6B40", VA = "0x1848E8140", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public PMPIHPEBLFA<LPDNCAKIDEG, KBHINEMHBJO> HMKLMMGMCLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x48E8230", Offset = "0x48E6C30", VA = "0x1848E8230", Slot = "65")]
			get
			{
				return default(PMPIHPEBLFA<LPDNCAKIDEG, KBHINEMHBJO>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public virtual MJGAEDNBJIL<LPDNCAKIDEG>? NCAMHCONKDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public virtual bool KKKMLKCCCEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public virtual bool EFIMENCOCHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "123")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action EOPBENFBCCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x48E5750", Offset = "0x48E4150", VA = "0x1848E5750", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x48E7190", Offset = "0x48E5B90", VA = "0x1848E7190", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event HJHGLKNOHLG MGPIMFOAKCP
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x48E5860", Offset = "0x48E4260", VA = "0x1848E5860", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x48E4FA0", Offset = "0x48E39A0", VA = "0x1848E4FA0", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event JFIINNCIMID JGCANMKPNCC
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x48E3150", Offset = "0x48E1B50", VA = "0x1848E3150", Slot = "41")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x48E6290", Offset = "0x48E4C90", VA = "0x1848E6290", Slot = "42")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action FCJPACGJMHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x48E3E70", Offset = "0x48E2870", VA = "0x1848E3E70", Slot = "43")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x48E2EA0", Offset = "0x48E18A0", VA = "0x1848E2EA0", Slot = "44")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action DKEIAOPCJAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x48E6EB0", Offset = "0x48E58B0", VA = "0x1848E6EB0", Slot = "45")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x48E7270", Offset = "0x48E5C70", VA = "0x1848E7270", Slot = "46")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<MJGAEDNBJIL<LPDNCAKIDEG>, KBHINEMHBJO> AFMDPBIBJOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x48E5A80", Offset = "0x48E4480", VA = "0x1848E5A80", Slot = "67")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x48E31F0", Offset = "0x48E1BF0", VA = "0x1848E31F0", Slot = "68")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<MJGAEDNBJIL<LPDNCAKIDEG>, KBHINEMHBJO> JDFNPELBONN
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x48E6010", Offset = "0x48E4A10", VA = "0x1848E6010", Slot = "71")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x48E4EE0", Offset = "0x48E38E0", VA = "0x1848E4EE0", Slot = "72")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<MJGAEDNBJIL<LPDNCAKIDEG>> PLLNAKPLOND
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x48E40A0", Offset = "0x48E2AA0", VA = "0x1848E40A0", Slot = "69")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x48E4850", Offset = "0x48E3250", VA = "0x1848E4850", Slot = "70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<MJGAEDNBJIL<LPDNCAKIDEG>, MJGAEDNBJIL<LPDNCAKIDEG>> FDHGGHKGOOL
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x48E70D0", Offset = "0x48E5AD0", VA = "0x1848E70D0", Slot = "73")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x48E7010", Offset = "0x48E5A10", VA = "0x1848E7010", Slot = "74")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<MJGAEDNBJIL<LPDNCAKIDEG>, KBHINEMHBJO> LGBGKKIMHJA
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x48E46D0", Offset = "0x48E30D0", VA = "0x1848E46D0", Slot = "75")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x48E6F50", Offset = "0x48E5950", VA = "0x1848E6F50", Slot = "76")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<MJGAEDNBJIL<LPDNCAKIDEG>, MJGAEDNBJIL<LPDNCAKIDEG>> LCDEFGKJLLA
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x48E5690", Offset = "0x48E4090", VA = "0x1848E5690", Slot = "77")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x48E4790", Offset = "0x48E3190", VA = "0x1848E4790", Slot = "78")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x48E7380", Offset = "0x48E5D80", VA = "0x1848E7380")]
		[EMDAHHLEKNJ("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		[EMDAHHLEKNJ("Need to handle `Name` better.")]
		protected OCLPOHGKJMO(PLLOHOJACCG PFCDDIODGEJ, TNode KOHLOCENPAH, bool DILHCPAOMOM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x48E2730", Offset = "0x48E1130", VA = "0x1848E2730", Slot = "87")]
		protected virtual void AIFHKOLJDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x48E33B0", Offset = "0x48E1DB0", VA = "0x1848E33B0", Slot = "88")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x48E4C70", Offset = "0x48E3670", VA = "0x1848E4C70", Slot = "9")]
		[AsyncStateMachine(typeof(OCLPOHGKJMO<>.IMEHJKKPNGG))]
		public void JHFNLBGAHDP(int EDGCIHBIJAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x48E7310", Offset = "0x48E5D10", VA = "0x1848E7310")]
		public bool PNNPEGPLMAL([In] MMPJAFGCJFL KLABJGGMBGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x48E6870", Offset = "0x48E5270", VA = "0x1848E6870")]
		public bool MLGGPLBNIAM([In] JGKIEDLDOEA KLABJGGMBGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x48E2F00", Offset = "0x48E1900", VA = "0x1848E2F00", Slot = "32")]
		public void BNDIBOJNCFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x48E3D00", Offset = "0x48E2700", VA = "0x1848E3D00", Slot = "33")]
		[AsyncStateMachine(typeof(OCLPOHGKJMO<>.ODENAMOOKAO))]
		public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> EFLABKMMGGK(MMPJAFGCJFL? OKJIEPLMHFB, JGKIEDLDOEA? IKIABBBCOCB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "97")]
		public virtual void OMBAFJOIBKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "98")]
		public virtual void MFIJCCGEKPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "99")]
		public virtual void KJNNJIFJIPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x9A5130", Offset = "0x9A3B30", VA = "0x1809A5130")]
		protected void POGBDEGDKJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x9DE110", Offset = "0x9DCB10", VA = "0x1809DE110")]
		protected void KMEPMKFCDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x232C010", Offset = "0x232AA10", VA = "0x18232C010")]
		private void OJAKGHIMGLE([In] JGKIEDLDOEA JOLHFCINNMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x48E4910", Offset = "0x48E3310", VA = "0x1848E4910", Slot = "100")]
		public virtual Task<BCLNLKLFCPB<MJGAEDNBJIL<LPDNCAKIDEG>, OBJIPJOMIPB>> IGIMMPPOEKP(string KJPHMNNIMDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x48E4160", Offset = "0x48E2B60", VA = "0x1848E4160", Slot = "101")]
		public virtual Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> GDGHCBBAPMO(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "102")]
		public virtual void LGEOIJJKPID(MJGAEDNBJIL<LPDNCAKIDEG> OFIFBCLIDAG, MJGAEDNBJIL<LPDNCAKIDEG> BOPFNJMKCAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x48E5900", Offset = "0x48E4300", VA = "0x1848E5900", Slot = "103")]
		public virtual IEnumerable<EHDCBMKEILE> LOGEDGOLNKD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x48E6DA0", Offset = "0x48E57A0", VA = "0x1848E6DA0", Slot = "104")]
		public BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB> NDOGIJKMCFG(string PKFNNBOIFBO)
		{
			return default(BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x48E4D90", Offset = "0x48E3790", VA = "0x1848E4D90", Slot = "47")]
		public bool JOJACKJBEBO([Out] Guid JKKNLKJNDCN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x48E68E0", Offset = "0x48E52E0", VA = "0x1848E68E0")]
		public bool MLLIEEGCAOE([In] Guid CFNEBLLEIOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "105")]
		public virtual void LFBMALNLGLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "106")]
		public virtual void MKNMBIJFOHJ(bool DKEBEIBNODK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "107")]
		public virtual APHPPLLHIBD GIKJONMECFD([In] PEAKBKLICDP MBLMCDCKMLN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x48E6BA0", Offset = "0x48E55A0", VA = "0x1848E6BA0")]
		protected void MOJAJOBAHIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x48E4230", Offset = "0x48E2C30", VA = "0x1848E4230", Slot = "112")]
		protected virtual bool GIBGGBJCBHD(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "113")]
		protected virtual bool EPKFMDJOHBB(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "120")]
		protected virtual void NELGNEIPFJP(PIDEGLEPBNK IHAINNNBNBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x48E5040", Offset = "0x48E3A40", VA = "0x1848E5040")]
		protected void KEBPEHDCAOK(PIDEGLEPBNK BKLAAIOGBOJ, Func<string> BOKPBGAIDJM, Action<string> BCNNDGOPDBF, string LANGGOBEBLI, string ODLDHCGLFDP, string AGNLDNPJNNH, KDGNCPPBPBH NCGABNOIHDI, EJEDKODBLLB JLFGGAFPEJC, Func<string, bool> HKICHHMINNH, string BNPAJKGGHLA, Func<string, bool> DPFMEGGHAND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x48E49E0", Offset = "0x48E33E0", VA = "0x1848E49E0")]
		protected void IHLCAMOEKIE(PIDEGLEPBNK BKLAAIOGBOJ, Func<string> BOKPBGAIDJM, Action<string> BCNNDGOPDBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x48E60D0", Offset = "0x48E4AD0", VA = "0x1848E60D0", Slot = "121")]
		protected virtual void MJLBLMAELNB(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x48E4680", Offset = "0x48E3080", VA = "0x1848E4680", Slot = "80")]
		public void GLFGCPILFDC(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x48E32B0", Offset = "0x48E1CB0", VA = "0x1848E32B0", Slot = "81")]
		public OMNAEPPNJLF DPJEAFJKAOC()
		{
			return default(OMNAEPPNJLF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "124")]
		public virtual bool IBLEHLFAKBM(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x175CDC0", Offset = "0x175B7C0", VA = "0x18175CDC0")]
		private void OEICGOCAGBB([In] MMPJAFGCJFL LEELMECKGCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x48E3F40", Offset = "0x48E2940", VA = "0x1848E3F40")]
		private void FHDJLOFCEHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x48E6330", Offset = "0x48E4D30", VA = "0x1848E6330")]
		private void MKGDMAIDHMF(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, IJBKFIGEKJK FBANFIMFFGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0xB07BE0", Offset = "0xB065E0", VA = "0x180B07BE0")]
		private void LCGENJKFEFF(MJGAEDNBJIL<LPDNCAKIDEG> MCAKFNPAKIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x48E5500", Offset = "0x48E3F00", VA = "0x1848E5500")]
		private void KIFLFHKIKEB(MJGAEDNBJIL<LPDNCAKIDEG> MCAKFNPAKIL, IJBKFIGEKJK PPCAACPJFDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x48E5C60", Offset = "0x48E4660", VA = "0x1848E5C60")]
		private void MHLLLFCLHAD(MJGAEDNBJIL<LPDNCAKIDEG> OFIFBCLIDAG, MJGAEDNBJIL<LPDNCAKIDEG> BOPFNJMKCAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xB08350", Offset = "0xB06D50", VA = "0x180B08350")]
		private void OODNEJFGEMP(MJGAEDNBJIL<LPDNCAKIDEG> OFIFBCLIDAG, MJGAEDNBJIL<LPDNCAKIDEG> BOPFNJMKCAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x48E3E50", Offset = "0x48E2850", VA = "0x1848E3E50")]
		private void EHCLOMNDJBH(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x48E4270", Offset = "0x48E2C70", VA = "0x1848E4270")]
		private void GIONJIMDBHL(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, IJBKFIGEKJK FBANFIMFFGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x48E57F0", Offset = "0x48E41F0", VA = "0x1848E57F0")]
		private void LLHEENHONMM(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, IJBKFIGEKJK PPCAACPJFDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x48E5B40", Offset = "0x48E4540", VA = "0x1848E5B40", Slot = "125")]
		[AsyncStateMachine(typeof(OCLPOHGKJMO<>.EMDHONGMIPH))]
		public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> MFEMJAMLDJD(string PKFNNBOIFBO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x48E3C90", Offset = "0x48E2690", VA = "0x1848E3C90", Slot = "54")]
		private void EECMDCKGAOH(object HHGBCMEFNON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x48E4D20", Offset = "0x48E3720", VA = "0x1848E4D20", Slot = "55")]
		private void JNDOJGAGAKN(object HHGBCMEFNON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x48E7230", Offset = "0x48E5C30", VA = "0x1848E7230", Slot = "29")]
		private bool PAEEDEHCIOA([In] MMPJAFGCJFL KLABJGGMBGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x48E6E30", Offset = "0x48E5830", VA = "0x1848E6E30", Slot = "31")]
		private bool NPLLDNBBEMJ([In] JGKIEDLDOEA KLABJGGMBGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x48E3110", Offset = "0x48E1B10", VA = "0x1848E3110", Slot = "48")]
		private bool BOENPANLCBD([In] Guid CFNEBLLEIOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x48E6E70", Offset = "0x48E5870", VA = "0x1848E6E70")]
		[CompilerGenerated]
		private string OAKLDBDMLFP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x48E5450", Offset = "0x48E3E50", VA = "0x1848E5450")]
		[CompilerGenerated]
		private void KIBJCPIDHJL(string KJPHMNNIMDP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public sealed class FPPKGHIJILI : NICBEFPGHCP<NGNKEDLAIDM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public override NodeVisualizationKey PJJDBLNOLBI
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x14BEBF0", Offset = "0x14BD5F0", VA = "0x1814BEBF0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x212D4C0", Offset = "0x212BEC0", VA = "0x18212D4C0")]
		public FPPKGHIJILI(PLLOHOJACCG PFCDDIODGEJ, NGNKEDLAIDM KOHLOCENPAH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class KBNALPBNKGF : NHHGKDHPBDL<HPJOFAJPFBI>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public override NodeVisualizationKey PJJDBLNOLBI
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x923D80", Offset = "0x922780", VA = "0x180923D80", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x2136560", Offset = "0x2134F60", VA = "0x182136560")]
		public KBNALPBNKGF(PLLOHOJACCG PFCDDIODGEJ, HPJOFAJPFBI KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "120")]
		protected override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public abstract class JJMDOICAKMK<T> : OCLPOHGKJMO<T> where T : notnull, MFIGGNMLMMF
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class AHIHABHPDIF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public IReadOnlyList<KeyValuePair<string, OKCGCELKKAL>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public JJMDOICAKMK<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public LPGKJOMOPPD nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public KALNDDFHJJG clipType;

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public AHIHABHPDIF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0")]
			internal IReadOnlyList<KeyValuePair<string, OKCGCELKKAL>> JDPFBIGGGNI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x3E85190", Offset = "0x3E83B90", VA = "0x183E85190")]
			internal int MDAPEAKELDK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x3E852F0", Offset = "0x3E83CF0", VA = "0x183E852F0")]
			internal void NLOAMKMODOM(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x3E85080", Offset = "0x3E83A80", VA = "0x183E85080")]
			internal void IIBCAKFOPMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x3E84F30", Offset = "0x3E83930", VA = "0x183E84F30")]
			internal void IACLJHOBOIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x3E84DF0", Offset = "0x3E837F0", VA = "0x183E84DF0")]
			internal bool AADPJDPABMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x3E84EE0", Offset = "0x3E838E0", VA = "0x183E84EE0")]
			internal void BDPDDNLEAGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x3E84DF0", Offset = "0x3E837F0", VA = "0x183E84DF0")]
			internal bool FICJGAHFHBG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x3E85130", Offset = "0x3E83B30", VA = "0x183E85130")]
			internal float LBPBDKOKHMB()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x3E85510", Offset = "0x3E83F10", VA = "0x183E85510")]
			internal void OGIOFKDKMKL(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x3E850D0", Offset = "0x3E83AD0", VA = "0x183E850D0")]
			internal float JHGLEIFOOFC()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x3E85690", Offset = "0x3E84090", VA = "0x183E85690")]
			internal void POPLGOOHKOK(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x3E84E80", Offset = "0x3E83880", VA = "0x183E84E80")]
			internal float AIEJHEIONHE()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x3E855D0", Offset = "0x3E83FD0", VA = "0x183E855D0")]
			internal void PIANLAOJJDB(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override NodeVisualizationKey PJJDBLNOLBI
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0xB1ACC0", Offset = "0xB196C0", VA = "0x180B1ACC0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public abstract KALNDDFHJJG FCCCJLPHOED
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(Slot = "126")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x42A1C80", Offset = "0x42A0680", VA = "0x1842A1C80")]
		public JJMDOICAKMK(PLLOHOJACCG PFCDDIODGEJ, T KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x42A1160", Offset = "0x429FB60", VA = "0x1842A1160", Slot = "120")]
		protected sealed override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private sealed class OHDNOGLOELN : OCLPOHGKJMO<IOFMKGBIHBK>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override NodeVisualizationKey PJJDBLNOLBI
		{
			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x997ED0", Offset = "0x9968D0", VA = "0x180997ED0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x213DD50", Offset = "0x213C750", VA = "0x18213DD50")]
		public OHDNOGLOELN(PLLOHOJACCG PFCDDIODGEJ, IOFMKGBIHBK KOHLOCENPAH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class CBBHDGAKOBC : OCLPOHGKJMO<GMEDFJAAPDI>
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class EIKEHDONPPA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public CBBHDGAKOBC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public LPGKJOMOPPD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public EIKEHDONPPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x2126D80", Offset = "0x2125780", VA = "0x182126D80")]
			internal int MDAPEAKELDK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x2126DD0", Offset = "0x21257D0", VA = "0x182126DD0")]
			internal void NLOAMKMODOM(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private static Dictionary<string, OKCGCELKKAL>? BCMAFHABNDO;

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x2124D10", Offset = "0x2123710", VA = "0x182124D10")]
		public CBBHDGAKOBC(PLLOHOJACCG PFCDDIODGEJ, GMEDFJAAPDI KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x21249A0", Offset = "0x21233A0", VA = "0x1821249A0", Slot = "120")]
		protected override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class NCLHPBBLBHE : JJMDOICAKMK<ODAJJBAEOBC>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public override KALNDDFHJJG FCCCJLPHOED
		{
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "126")]
			get
			{
				return default(KALNDDFHJJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x213D090", Offset = "0x213BA90", VA = "0x18213D090")]
		public NCLHPBBLBHE(PLLOHOJACCG PFCDDIODGEJ, ODAJJBAEOBC BDPEMHOFOHC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class DKDGBFMHKMD : NHHGKDHPBDL<KEEMJMMDAOA>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public override NodeVisualizationKey PJJDBLNOLBI
		{
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x923D80", Offset = "0x922780", VA = "0x180923D80", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x2125880", Offset = "0x2124280", VA = "0x182125880")]
		public DKDGBFMHKMD(PLLOHOJACCG PFCDDIODGEJ, KEEMJMMDAOA KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "120")]
		protected override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	private sealed class NHOIPFBAHJD : NHHGKDHPBDL<JBABPPHNGJH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public override NodeVisualizationKey PJJDBLNOLBI
		{
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x923D80", Offset = "0x922780", VA = "0x180923D80", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x213D810", Offset = "0x213C210", VA = "0x18213D810")]
		public NHOIPFBAHJD(PLLOHOJACCG PFCDDIODGEJ, JBABPPHNGJH KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "120")]
		protected override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class MAABCAPBJBE : GBMAMGMOMFA<EGKHPPOGDNE>
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class HGLKOIPLAFA
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200009E")]
			private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001DF")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40001E0")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40001E1")]
				public HGLKOIPLAFA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001E2")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40001E3")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40001E4")]
				private TaskAwaiter<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60003CB")]
				[Cpp2IlInjected.Address(RVA = "0x213E470", Offset = "0x213CE70", VA = "0x18213E470", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CC")]
				[Cpp2IlInjected.Address(RVA = "0x8E5A10", Offset = "0x8E4410", VA = "0x1808E5A10", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public LPGKJOMOPPD nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public MAABCAPBJBE <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public HGLKOIPLAFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x212EFE0", Offset = "0x212D9E0", VA = "0x18212EFE0")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void MJDFMONDNHO(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x21377F0", Offset = "0x21361F0", VA = "0x1821377F0")]
		public MAABCAPBJBE(PLLOHOJACCG PFCDDIODGEJ, EGKHPPOGDNE BDPEMHOFOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x2137510", Offset = "0x2135F10", VA = "0x182137510", Slot = "126")]
		protected override void MIIEKGIGHCK(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class LDAJHBMFOLJ : JJMDOICAKMK<PMOEEGMPMGA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override KALNDDFHJJG FCCCJLPHOED
		{
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x991A90", Offset = "0x990490", VA = "0x180991A90", Slot = "126")]
			get
			{
				return default(KALNDDFHJJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x2137440", Offset = "0x2135E40", VA = "0x182137440")]
		public LDAJHBMFOLJ(PLLOHOJACCG PFCDDIODGEJ, PMOEEGMPMGA BDPEMHOFOHC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private sealed class OPBMBHBBBED : OCLPOHGKJMO<JOHCMGKMFBA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public override NodeVisualizationKey PJJDBLNOLBI
		{
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0xB6DB40", Offset = "0xB6C540", VA = "0x180B6DB40", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x213DDC0", Offset = "0x213C7C0", VA = "0x18213DDC0")]
		public OPBMBHBBBED(PLLOHOJACCG PFCDDIODGEJ, JOHCMGKMFBA KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "120")]
		protected override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public sealed class GOBNEBCGEAD : OCLPOHGKJMO<DFNBCOCAJLL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public sealed override NodeVisualizationKey PJJDBLNOLBI
		{
			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public sealed override bool PDCHHCNMNKC
		{
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected sealed override bool HAHGFBEMNBC
		{
			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x212E440", Offset = "0x212CE40", VA = "0x18212E440")]
		public GOBNEBCGEAD(PLLOHOJACCG PFCDDIODGEJ, DFNBCOCAJLL KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x212E110", Offset = "0x212CB10", VA = "0x18212E110", Slot = "120")]
		protected override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x212E0D0", Offset = "0x212CAD0", VA = "0x18212E0D0")]
		private int DKNIKKCPFOA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x212E070", Offset = "0x212CA70", VA = "0x18212E070")]
		private void ALFEGGKDAMP(int HBEFBGGFFKD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public class LPPPHDHCOEE : OEOAPHDGOOK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x21374A0", Offset = "0x2135EA0", VA = "0x1821374A0")]
		public LPPPHDHCOEE(PLLOHOJACCG PFCDDIODGEJ, DPIPCKFLLFL KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "120")]
		protected override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class GONPGHJDBOD : GBMAMGMOMFA<IDPHDPCABAH>
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x212E4B0", Offset = "0x212CEB0", VA = "0x18212E4B0")]
		public GONPGHJDBOD(PLLOHOJACCG PFCDDIODGEJ, IDPHDPCABAH KOHLOCENPAH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public abstract class GBMAMGMOMFA<TVariableNode> : OCLPOHGKJMO<TVariableNode> where TVariableNode : notnull, IDPHDPCABAH
	{
		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private sealed class DMKMJFMICMM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public GBMAMGMOMFA<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public LPGKJOMOPPD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public DMKMJFMICMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x5B565A0", Offset = "0x5B54FA0", VA = "0x185B565A0")]
			internal bool JDPFBIGGGNI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x5B56600", Offset = "0x5B55000", VA = "0x185B56600")]
			internal void MDAPEAKELDK(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x5B566C0", Offset = "0x5B550C0", VA = "0x185B566C0")]
			internal bool NLOAMKMODOM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x5B564E0", Offset = "0x5B54EE0", VA = "0x185B564E0")]
			internal void IIBCAKFOPMO(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x5B56430", Offset = "0x5B54E30", VA = "0x185B56430")]
			internal bool IACLJHOBOIL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		[CompilerGenerated]
		private sealed class OMMKAPHFCMK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public LPGKJOMOPPD nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public GBMAMGMOMFA<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public OMMKAPHFCMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x4907F80", Offset = "0x4906980", VA = "0x184907F80")]
			internal void MJDFMONDNHO(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public override NodeVisualizationKey PJJDBLNOLBI
		{
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0xCE53F0", Offset = "0xCE3DF0", VA = "0x180CE53F0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public override GFPNMCHHOBN LKOINDAEEGC
		{
			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x3EABF30", Offset = "0x3EAA930", VA = "0x183EABF30", Slot = "94")]
			get
			{
				return default(GFPNMCHHOBN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x3EABD80", Offset = "0x3EAA780", VA = "0x183EABD80")]
		protected GBMAMGMOMFA(PLLOHOJACCG PFCDDIODGEJ, TVariableNode KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x3EAB290", Offset = "0x3EA9C90", VA = "0x183EAB290", Slot = "88")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x3EAB8D0", Offset = "0x3EAA2D0", VA = "0x183EAB8D0", Slot = "120")]
		protected override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x3EAB530", Offset = "0x3EA9F30", VA = "0x183EAB530", Slot = "126")]
		protected virtual void MIIEKGIGHCK(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x3EAB430", Offset = "0x3EA9E30", VA = "0x183EAB430", Slot = "105")]
		public override void LFBMALNLGLI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2110AA0", Offset = "0x210F4A0", VA = "0x182110AA0")]
	public static KJBJNDHGBLH GGBAHLJJLHO(PLLOHOJACCG PFCDDIODGEJ, DPIPCKFLLFL KOHLOCENPAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public sealed class HFDOABPFDJP : IBDEEOHCPBI, HDDFAAMLDIO, DBDMDCDNCFC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public MJGAEDNBJIL<POKJECOIACH> CKHCNHCMGNM
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x948F30", Offset = "0x947930", VA = "0x180948F30", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(MJGAEDNBJIL<POKJECOIACH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public MJGAEDNBJIL<DGNIMDELLGK> AGKDLFMOGIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x948F50", Offset = "0x947950", VA = "0x180948F50", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(MJGAEDNBJIL<DGNIMDELLGK>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x212ECE0", Offset = "0x212D6E0", VA = "0x18212ECE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private MJGAEDNBJIL<OMDILHJFPPO> KIDLCLOLIMD
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x9ACCC0", Offset = "0x9AB6C0", VA = "0x1809ACCC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public override MJGAEDNBJIL<NPLAKCHMMBM> CNGHGJOOHPB
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x212E940", Offset = "0x212D340", VA = "0x18212E940", Slot = "20")]
		get
		{
			return default(MJGAEDNBJIL<NPLAKCHMMBM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x212ECF0", Offset = "0x212D6F0", VA = "0x18212ECF0")]
	private HFDOABPFDJP(PLLOHOJACCG PFCDDIODGEJ, DPIPCKFLLFL KOHLOCENPAH, OFFKAKEFONL OMLHNDEIDDO, MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, MJGAEDNBJIL<DGNIMDELLGK> GNAGOFFMLAD, MJGAEDNBJIL<OMDILHJFPPO> DPNCALJCMOD, bool BNKGOGLKMMD, string KJPHMNNIMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x212E990", Offset = "0x212D390", VA = "0x18212E990")]
	public static HFDOABPFDJP GGBAHLJJLHO(PLLOHOJACCG PFCDDIODGEJ, DPIPCKFLLFL KOHLOCENPAH, OFFKAKEFONL CEMLELOFBNI, MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, MJGAEDNBJIL<OMDILHJFPPO> DPNCALJCMOD, MJGAEDNBJIL<DGNIMDELLGK> GNAGOFFMLAD, bool BNKGOGLKMMD, bool DILHCPAOMOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x212ECE0", Offset = "0x212D6E0", VA = "0x18212ECE0")]
	internal void LDNCANAAJKJ(MJGAEDNBJIL<DGNIMDELLGK> KLABJGGMBGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public abstract class IBDEEOHCPBI : DBDMDCDNCFC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct PPLJJJOCHHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private OCDCOPCGBAN? JPGOPHFOEPI;

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x213E460", Offset = "0x213CE60", VA = "0x18213E460")]
		public void MPAAPCHGDCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x213E3C0", Offset = "0x213CDC0", VA = "0x18213E3C0")]
		public OCDCOPCGBAN JMEBKEJHOOM(IBDEEOHCPBI LBJPGPEKENF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	protected readonly PLLOHOJACCG EBBHMAKIMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	protected readonly DPIPCKFLLFL IOIJJGIJHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private PPLJJJOCHHK EFHADGOECHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly ACDJLCJFCDP BGIKPEJHNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private readonly List<LBGKMAHDCBD> AJNJLLNJPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private readonly List<PLDOCOGHMKI> KADKKGKPMLH;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	[EMDAHHLEKNJ("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> HPKLECLPCOL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x21324A0", Offset = "0x2130EA0", VA = "0x1821324A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public DisplayKind KBJMIBHHLLA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x8A7290", Offset = "0x8A5C90", VA = "0x1808A7290", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public MJGAEDNBJIL<IKLMIGOGHKN> EPGBOEDHPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x2133260", Offset = "0x2131C60", VA = "0x182133260", Slot = "6")]
		get
		{
			return default(MJGAEDNBJIL<IKLMIGOGHKN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public JEBPJLMNFAK<IKLMIGOGHKN> AMOEOBKAIDA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x21328C0", Offset = "0x21312C0", VA = "0x1821328C0", Slot = "7")]
		get
		{
			return default(JEBPJLMNFAK<IKLMIGOGHKN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public DHDNLKJCEHP JNAGBMCOMED
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x1F68380", Offset = "0x1F66D80", VA = "0x181F68380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public JJKCEJGCFAL BPNOLPGAEEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x21331C0", Offset = "0x2131BC0", VA = "0x1821331C0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	protected OCDCOPCGBAN HGKABLOGPIA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x21331C0", Offset = "0x2131BC0", VA = "0x1821331C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public PortImage NNHCMAGNPAD
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x21325E0", Offset = "0x2130FE0", VA = "0x1821325E0", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public string FHACOBMPENF
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x899850", Offset = "0x898250", VA = "0x180899850", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x8999D0", Offset = "0x8983D0", VA = "0x1808999D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public JEBPJLMNFAK<BKFIMEBJLKC> CMGBDIMJDNN
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x21322D0", Offset = "0x2130CD0", VA = "0x1821322D0", Slot = "9")]
		get
		{
			return default(JEBPJLMNFAK<BKFIMEBJLKC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public MJGAEDNBJIL<LPDNCAKIDEG> LOMGPGLPEKK
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x948D40", Offset = "0x947740", VA = "0x180948D40", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(MJGAEDNBJIL<LPDNCAKIDEG>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x948290", Offset = "0x946C90", VA = "0x180948290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public abstract MJGAEDNBJIL<NPLAKCHMMBM> CNGHGJOOHPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x21334C0", Offset = "0x2131EC0", VA = "0x1821334C0")]
	protected IBDEEOHCPBI(PLLOHOJACCG PFCDDIODGEJ, DPIPCKFLLFL KOHLOCENPAH, ACDJLCJFCDP EHGIOJOEILB, MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, bool BNKGOGLKMMD, string KJPHMNNIMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x2132180", Offset = "0x2130B80", VA = "0x182132180", Slot = "21")]
	protected virtual void AIFHKOLJDOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x2132350", Offset = "0x2130D50", VA = "0x182132350", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x2133160", Offset = "0x2131B60", VA = "0x182133160", Slot = "14")]
	public void KIJCPECGBHG(LBGKMAHDCBD MMPLGKEGKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x2132120", Offset = "0x2130B20", VA = "0x182132120", Slot = "15")]
	public void ADALEBMOFDI(PLDOCOGHMKI MMPLGKEGKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x21328F0", Offset = "0x21312F0", VA = "0x1821328F0", Slot = "16")]
	public void HJBEPEMMNKJ(APDFNBBFBPM AILIAJMFOGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x21322F0", Offset = "0x2130CF0", VA = "0x1821322F0", Slot = "23")]
	protected virtual void BPECPKLMPPL(APDFNBBFBPM AILIAJMFOGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x2132FD0", Offset = "0x21319D0", VA = "0x182132FD0")]
	private void JKDEIJLGPMO(bool MNKBAIOBLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x2132710", Offset = "0x2131110", VA = "0x182132710")]
	private void FGJEEIJIFCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x21332B0", Offset = "0x2131CB0", VA = "0x1821332B0")]
	private void PFBELNCOIMB([In] HAJDAJIIABF PBDJJGLJIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x2132F70", Offset = "0x2131970", VA = "0x182132F70", Slot = "17")]
	public void JAHKMPGMEHN(LBGKMAHDCBD MMPLGKEGKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x2133460", Offset = "0x2131E60", VA = "0x182133460", Slot = "18")]
	public void PNEPBBBIBFH(PLDOCOGHMKI MMPLGKEGKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x8999D0", Offset = "0x8983D0", VA = "0x1808999D0")]
	internal void DNFMFIPIFBD(string KJPHMNNIMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x2133290", Offset = "0x2131C90", VA = "0x182133290")]
	internal void PBMIGOBKGGO(IJOLNGCBMAE LAKCFHGOLJA, DHDNLKJCEHP JLAAKHANEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x948290", Offset = "0x946C90", VA = "0x180948290")]
	internal void ONODJGJMAIP(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public sealed class FAADKMCMNDL : KBHINEMHBJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class MGKJIGEPCPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public PLLOHOJACCG circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public DPIPCKFLLFL node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public MJGAEDNBJIL<LPDNCAKIDEG> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public MGKJIGEPCPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x2137850", Offset = "0x2136250", VA = "0x182137850")]
		internal GIIGAKOBIAH LIGBFNEELPJ((int PortDescIndex, int PortIndex, PJDJGGGLFDB InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x21378E0", Offset = "0x21362E0", VA = "0x1821378E0")]
		internal HFDOABPFDJP NOMDIPENEPG(OFFKAKEFONL i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct BFGHAAKHIAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public FAADKMCMNDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private GOHBBJGIJKI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private TaskAwaiter<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x21243D0", Offset = "0x2122DD0", VA = "0x1821243D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x2124830", Offset = "0x2123230", VA = "0x182124830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct JNBEJLJEDBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public FAADKMCMNDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public MJGAEDNBJIL<DDABHKCABNE> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private GOHBBJGIJKI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private TaskAwaiter<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x21361A0", Offset = "0x2134BA0", VA = "0x1821361A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x21364F0", Offset = "0x2134EF0", VA = "0x1821364F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct HOPEKNLDDED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public FAADKMCMNDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public MJGAEDNBJIL<OMDILHJFPPO> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private GOHBBJGIJKI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private TaskAwaiter<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x212FC00", Offset = "0x212E600", VA = "0x18212FC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x212FF50", Offset = "0x212E950", VA = "0x18212FF50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct JDCALIILJEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public FAADKMCMNDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public MJGAEDNBJIL<DDABHKCABNE> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public MJGAEDNBJIL<DDABHKCABNE> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private GOHBBJGIJKI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private TaskAwaiter<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x2134F80", Offset = "0x2133980", VA = "0x182134F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x21352D0", Offset = "0x2133CD0", VA = "0x1821352D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct DFAALCHAOMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public FAADKMCMNDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public MJGAEDNBJIL<OMDILHJFPPO> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public MJGAEDNBJIL<OMDILHJFPPO> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private GOHBBJGIJKI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private TaskAwaiter<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x21251C0", Offset = "0x2123BC0", VA = "0x1821251C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x2125510", Offset = "0x2123F10", VA = "0x182125510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct NJCCKONLDAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public FAADKMCMNDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private GOHBBJGIJKI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private TaskAwaiter<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x213D870", Offset = "0x213C270", VA = "0x18213D870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x213DCE0", Offset = "0x213C6E0", VA = "0x18213DCE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct IEJBLLMLPML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public FAADKMCMNDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private GOHBBJGIJKI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private TaskAwaiter<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x2133D40", Offset = "0x2132740", VA = "0x182133D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x2134090", Offset = "0x2132A90", VA = "0x182134090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct GFOBKFCFEJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public FAADKMCMNDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public MJGAEDNBJIL<DDABHKCABNE> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private GOHBBJGIJKI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private TaskAwaiter<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x212D730", Offset = "0x212C130", VA = "0x18212D730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x212DA80", Offset = "0x212C480", VA = "0x18212DA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct ILLKNBHKALA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public FAADKMCMNDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public MJGAEDNBJIL<OMDILHJFPPO> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private GOHBBJGIJKI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x2134120", Offset = "0x2132B20", VA = "0x182134120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x2134470", Offset = "0x2132E70", VA = "0x182134470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct EHJIIGPDKPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public FAADKMCMNDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public BLDEJALINAE type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public MJGAEDNBJIL<DDABHKCABNE> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private GOHBBJGIJKI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private TaskAwaiter<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x2126980", Offset = "0x2125380", VA = "0x182126980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x2126D10", Offset = "0x2125710", VA = "0x182126D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct NDLCFMHBHCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public FAADKMCMNDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public BLDEJALINAE type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public MJGAEDNBJIL<OMDILHJFPPO> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private GOHBBJGIJKI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private TaskAwaiter<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x213D0F0", Offset = "0x213BAF0", VA = "0x18213D0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x213D480", Offset = "0x213BE80", VA = "0x18213D480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private readonly bool PAMIOJFGIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly PLLOHOJACCG EBBHMAKIMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private readonly bool KOADHJEPOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private PMPIHPEBLFA<EMOBFLMBFFJ, GIIGAKOBIAH> LIDNOIMLKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private PMPIHPEBLFA<EMOBFLMBFFJ, PGALABIFJNM> AJHNNNBECKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private readonly DPIPCKFLLFL IOIJJGIJHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private PMPIHPEBLFA<DGNIMDELLGK, HFDOABPFDJP> KEJPIHKKGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private PMPIHPEBLFA<DGNIMDELLGK, HDDFAAMLDIO> BKBAGIGLJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private string? DGGDNAOIBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly IJBKFIGEKJK BCGKHKJAHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private MJGAEDNBJIL<LPDNCAKIDEG> MAJADGDFMJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private readonly bool FILBJGDIALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	[CompilerGenerated]
	private Action? KEPPDAGHDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	[CompilerGenerated]
	private Action? PDJHOICHGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	[CompilerGenerated]
	private Action<MJGAEDNBJIL<EMOBFLMBFFJ>>? JBMOMDKJLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	[CompilerGenerated]
	private Action<MJGAEDNBJIL<DGNIMDELLGK>>? EAAPFOLLECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	[CompilerGenerated]
	private KBHINEMHBJO.ICJMHJBCFMK? GKGCAKJGOOJ;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool PLKNAOCGEKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x2127830", Offset = "0x2126230", VA = "0x182127830", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool CKOAFFDLDKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x21278F0", Offset = "0x21262F0", VA = "0x1821278F0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool CAPODAAAJFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x212A590", Offset = "0x2128F90", VA = "0x18212A590", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public JEBPJLMNFAK<IKLMIGOGHKN> AMOEOBKAIDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x2129F00", Offset = "0x2128900", VA = "0x182129F00", Slot = "7")]
		get
		{
			return default(JEBPJLMNFAK<IKLMIGOGHKN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool GMAAHFHIJEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x2128B50", Offset = "0x2127550", VA = "0x182128B50", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public PMPIHPEBLFA<EMOBFLMBFFJ, PGALABIFJNM> AIPKONCGFJB
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x8999A0", Offset = "0x8983A0", VA = "0x1808999A0", Slot = "9")]
		get
		{
			return default(PMPIHPEBLFA<EMOBFLMBFFJ, PGALABIFJNM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public string FHACOBMPENF
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x212B100", Offset = "0x2129B00", VA = "0x18212B100", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public JEBPJLMNFAK<BKFIMEBJLKC> CMGBDIMJDNN
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x2127810", Offset = "0x2126210", VA = "0x182127810", Slot = "11")]
		get
		{
			return default(JEBPJLMNFAK<BKFIMEBJLKC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public PMPIHPEBLFA<DGNIMDELLGK, HDDFAAMLDIO> JHNBGHCPAMF
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x899850", Offset = "0x898250", VA = "0x180899850", Slot = "12")]
		get
		{
			return default(PMPIHPEBLFA<DGNIMDELLGK, HDDFAAMLDIO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public MJGAEDNBJIL<LPDNCAKIDEG> LOMGPGLPEKK
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x948F40", Offset = "0x947940", VA = "0x180948F40", Slot = "13")]
		get
		{
			return default(MJGAEDNBJIL<LPDNCAKIDEG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action DLCMNHKJFGB
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x212A340", Offset = "0x2128D40", VA = "0x18212A340", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x212AED0", Offset = "0x21298D0", VA = "0x18212AED0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action PBEHCJNFIMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x212BE40", Offset = "0x212A840", VA = "0x18212BE40", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x212A650", Offset = "0x2129050", VA = "0x18212A650", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<MJGAEDNBJIL<EMOBFLMBFFJ>, MJGAEDNBJIL<EMOBFLMBFFJ>> OJNGKPEEMNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x212A060", Offset = "0x2128A60", VA = "0x18212A060", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x212C6D0", Offset = "0x212B0D0", VA = "0x18212C6D0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<MJGAEDNBJIL<EMOBFLMBFFJ>, MJGAEDNBJIL<EMOBFLMBFFJ>> KAICILHMIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x2128A90", Offset = "0x2127490", VA = "0x182128A90", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x212C400", Offset = "0x212AE00", VA = "0x18212C400", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<MJGAEDNBJIL<DGNIMDELLGK>, MJGAEDNBJIL<DGNIMDELLGK>> EIKBBBCHKBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x212AD50", Offset = "0x2129750", VA = "0x18212AD50", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x212B130", Offset = "0x2129B30", VA = "0x18212B130", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<MJGAEDNBJIL<DGNIMDELLGK>, MJGAEDNBJIL<DGNIMDELLGK>> EPBMECEANLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x212B450", Offset = "0x2129E50", VA = "0x18212B450", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x212B390", Offset = "0x2129D90", VA = "0x18212B390", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<MJGAEDNBJIL<EMOBFLMBFFJ>, PGALABIFJNM> FLDHCHODLBI
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x212A3E0", Offset = "0x2128DE0", VA = "0x18212A3E0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x2129320", Offset = "0x2127D20", VA = "0x182129320", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<MJGAEDNBJIL<EMOBFLMBFFJ>> FEECFMDMKBF
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x212C790", Offset = "0x212B190", VA = "0x18212C790", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x2127B70", Offset = "0x2126570", VA = "0x182127B70", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<MJGAEDNBJIL<EMOBFLMBFFJ>, PGALABIFJNM> HAJIIKMKFIM
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x212B2D0", Offset = "0x2129CD0", VA = "0x18212B2D0", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x212AE10", Offset = "0x2129810", VA = "0x18212AE10", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<MJGAEDNBJIL<DGNIMDELLGK>, HDDFAAMLDIO> ALHJAHNNJGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x21293E0", Offset = "0x2127DE0", VA = "0x1821293E0", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x212BEF0", Offset = "0x212A8F0", VA = "0x18212BEF0", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<MJGAEDNBJIL<DGNIMDELLGK>> HIFJMCHBNCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x212B1F0", Offset = "0x2129BF0", VA = "0x18212B1F0", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x2126E60", Offset = "0x2125860", VA = "0x182126E60", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<MJGAEDNBJIL<DGNIMDELLGK>, HDDFAAMLDIO> MCDKHMJHLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x2129260", Offset = "0x2127C60", VA = "0x182129260", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x212B8B0", Offset = "0x212A2B0", VA = "0x18212B8B0", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x212CD40", Offset = "0x212B740", VA = "0x18212CD40")]
	private FAADKMCMNDL(bool BNKGOGLKMMD, PLLOHOJACCG PFCDDIODGEJ, bool GINMEHCIOLM, PMPIHPEBLFA<EMOBFLMBFFJ, GIIGAKOBIAH> DAMPHGNICNC, PMPIHPEBLFA<EMOBFLMBFFJ, PGALABIFJNM> CEEHGBMKHMK, DPIPCKFLLFL KOHLOCENPAH, PMPIHPEBLFA<DGNIMDELLGK, HFDOABPFDJP> FPLMDJDONEI, PMPIHPEBLFA<DGNIMDELLGK, HDDFAAMLDIO> MGJNMNKEALC, string? DENGFKIGILM, IJBKFIGEKJK FBANFIMFFGD, MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, bool DILHCPAOMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x2129840", Offset = "0x2128240", VA = "0x182129840")]
	public static FAADKMCMNDL GGBAHLJJLHO(bool BNKGOGLKMMD, PLLOHOJACCG PFCDDIODGEJ, bool GINMEHCIOLM, DPIPCKFLLFL KOHLOCENPAH, IJBKFIGEKJK FBANFIMFFGD, MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, bool DILHCPAOMOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x2126F20", Offset = "0x2125920", VA = "0x182126F20")]
	private void AIFHKOLJDOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x2127C30", Offset = "0x2126630", VA = "0x182127C30", Slot = "49")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x2127A80", Offset = "0x2126480", VA = "0x182127A80", Slot = "38")]
	[AsyncStateMachine(typeof(BFGHAAKHIAO))]
	public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> DDIEGLFIKIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x2128750", Offset = "0x2127150", VA = "0x182128750")]
	private (MFHKGAOPKGJ, int)? EFOIGPIJALB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x212A120", Offset = "0x2128B20", VA = "0x18212A120")]
	private void HHBIJHJBHNK(int GMCOMKJLDIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x177C360", Offset = "0x177AD60", VA = "0x18177C360")]
	private void FEPOENJFHGH(int GMCOMKJLDIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x21294A0", Offset = "0x2127EA0", VA = "0x1821294A0")]
	private void GAMLICMALGP(int CDBKHGLBCII, int CFHANJCKHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x212BDE0", Offset = "0x212A7E0", VA = "0x18212BDE0")]
	private void MFOECCDFIGO(int CDBKHGLBCII, int CFHANJCKHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x2128D20", Offset = "0x2127720", VA = "0x182128D20")]
	private void FIBFMMDGHOH(int GMCOMKJLDIL, MJGAEDNBJIL<EMOBFLMBFFJ> GADCMKPLHKE, PJDJGGGLFDB FDIIPKGGJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x21277F0", Offset = "0x21261F0", VA = "0x1821277F0")]
	private void BJPJALFFIOJ(int MNKBAIOBLHC, MJGAEDNBJIL<EMOBFLMBFFJ> GADCMKPLHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x212B2B0", Offset = "0x2129CB0", VA = "0x18212B2B0")]
	private void LMEDOPOPMMN(int MNKBAIOBLHC, MJGAEDNBJIL<EMOBFLMBFFJ> GADCMKPLHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x212BFB0", Offset = "0x212A9B0", VA = "0x18212BFB0")]
	private void NHOPGPNAAEF(int GMCOMKJLDIL, MJGAEDNBJIL<EMOBFLMBFFJ> GADCMKPLHKE, PJDJGGGLFDB FDIIPKGGJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x2127930", Offset = "0x2126330", VA = "0x182127930")]
	private void DCMLLIBKNJB(int GMCOMKJLDIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0xD1D7E0", Offset = "0xD1C1E0", VA = "0x180D1D7E0")]
	private void OFCFGOANNIG(int GMCOMKJLDIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x212C5E0", Offset = "0x212AFE0", VA = "0x18212C5E0")]
	private void NOEABLGNCLJ(int GMCOMKJLDIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x177C360", Offset = "0x177AD60", VA = "0x18177C360")]
	private void OBCLPBAEJNN(int GMCOMKJLDIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x212B510", Offset = "0x2129F10", VA = "0x18212B510")]
	private void MADOBHMELPM(int CDBKHGLBCII, int CFHANJCKHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x212AF70", Offset = "0x2129970", VA = "0x18212AF70")]
	private void KBCJPAPJLJC(int CDBKHGLBCII, int CFHANJCKHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x212A700", Offset = "0x2129100", VA = "0x18212A700")]
	private void JDFCKNNLKOB(int GMCOMKJLDIL, MJGAEDNBJIL<DGNIMDELLGK> GADCMKPLHKE, OFFKAKEFONL FDIIPKGGJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x2129EE0", Offset = "0x21288E0", VA = "0x182129EE0")]
	private void GHGCMFINPPD(int MNKBAIOBLHC, MJGAEDNBJIL<DGNIMDELLGK> GADCMKPLHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x2128730", Offset = "0x2127130", VA = "0x182128730")]
	private void EDPDOOMFIHK(int MNKBAIOBLHC, MJGAEDNBJIL<DGNIMDELLGK> GADCMKPLHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x212B970", Offset = "0x212A370", VA = "0x18212B970")]
	private void MEEAJHMNOJP(int GMCOMKJLDIL, MJGAEDNBJIL<DGNIMDELLGK> GADCMKPLHKE, OFFKAKEFONL FDIIPKGGJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x2128BD0", Offset = "0x21275D0", VA = "0x182128BD0")]
	private void FEHIBJFBOPM(int GMCOMKJLDIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0xD1D7E0", Offset = "0xD1C1E0", VA = "0x180D1D7E0")]
	private void ACPFLBCBAOM(int GMCOMKJLDIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x2128980", Offset = "0x2127380", VA = "0x182128980", Slot = "39")]
	[AsyncStateMachine(typeof(JNBEJLJEDBE))]
	public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> EIBPGDLBMCK(MJGAEDNBJIL<DDABHKCABNE> IINCKHAMMKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x212AC40", Offset = "0x2129640", VA = "0x18212AC40", Slot = "40")]
	[AsyncStateMachine(typeof(HOPEKNLDDED))]
	public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> JEJHOBENKPI(MJGAEDNBJIL<OMDILHJFPPO> DPNCALJCMOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x212C4C0", Offset = "0x212AEC0", VA = "0x18212C4C0", Slot = "41")]
	[AsyncStateMachine(typeof(JDCALIILJEI))]
	public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> NIOFGJLKHLP(MJGAEDNBJIL<DDABHKCABNE> IINCKHAMMKN, MJGAEDNBJIL<DDABHKCABNE> CMFOHNEPANN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x212CC20", Offset = "0x212B620", VA = "0x18212CC20", Slot = "42")]
	[AsyncStateMachine(typeof(DFAALCHAOMP))]
	public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> PFIJIKDEDLG(MJGAEDNBJIL<OMDILHJFPPO> DPNCALJCMOD, MJGAEDNBJIL<OMDILHJFPPO> CMFOHNEPANN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x212A4A0", Offset = "0x2128EA0", VA = "0x18212A4A0", Slot = "43")]
	[AsyncStateMachine(typeof(NJCCKONLDAO))]
	public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> HNGELCDDJJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x21276D0", Offset = "0x21260D0", VA = "0x1821276D0", Slot = "44")]
	[AsyncStateMachine(typeof(IEJBLLMLPML))]
	public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> ANIDHOIOCPF(string PKFNNBOIFBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x2129DB0", Offset = "0x21287B0", VA = "0x182129DB0", Slot = "45")]
	[AsyncStateMachine(typeof(GFOBKFCFEJL))]
	public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> GHELCLKCPAM(MJGAEDNBJIL<DDABHKCABNE> IINCKHAMMKN, string KJPHMNNIMDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x2129F30", Offset = "0x2128930", VA = "0x182129F30", Slot = "46")]
	[AsyncStateMachine(typeof(ILLKNBHKALA))]
	public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> GOHOKGCDKIN(MJGAEDNBJIL<OMDILHJFPPO> DPNCALJCMOD, string KJPHMNNIMDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x212A210", Offset = "0x2128C10", VA = "0x18212A210", Slot = "47")]
	[AsyncStateMachine(typeof(EHJIIGPDKPA))]
	public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> HIBEHFKHPBO(MJGAEDNBJIL<DDABHKCABNE> IINCKHAMMKN, BLDEJALINAE JLAAKHANEHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x212AFD0", Offset = "0x21299D0", VA = "0x18212AFD0", Slot = "48")]
	[AsyncStateMachine(typeof(NDLCFMHBHCK))]
	public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> KBCNJMFKNEO(MJGAEDNBJIL<OMDILHJFPPO> DPNCALJCMOD, BLDEJALINAE JLAAKHANEHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x212C850", Offset = "0x212B250", VA = "0x18212C850")]
	internal void ONODJGJMAIP(MJGAEDNBJIL<LPDNCAKIDEG> KLABJGGMBGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public sealed class FHMGLGJBBAM : HDGDOAHDBCE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public interface JBAIHKMGBEO
	{
		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		IJOLNGCBMAE ENGHEPONNCK
		{
			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<FAOKMGJAJIO> MOMDOOOKCGA(CancellationToken IONNNJNKLMJ);

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<PIKJJPNAMNM> IEAGLKHGNDK(CancellationToken IONNNJNKLMJ);

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<ODLNIBGADPI> FNKNKPMDBDE(CancellationToken IONNNJNKLMJ);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct JCNCGMPMNGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<FHMGLGJBBAM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public PLLOHOJACCG circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public FAOKMGJAJIO roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public PIKJJPNAMNM superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private JBAIHKMGBEO <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private PIKJJPNAMNM <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<FAOKMGJAJIO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private TaskAwaiter<PIKJJPNAMNM> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter<ODLNIBGADPI> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private TaskAwaiter<JKIEPPIEFOF> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x21344E0", Offset = "0x2132EE0", VA = "0x1821344E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x2134F10", Offset = "0x2133910", VA = "0x182134F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private readonly JKIEPPIEFOF FBOFPAHIGBD;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public JKIEPPIEFOF MMFCBCMFCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x8962A0", Offset = "0x894CA0", VA = "0x1808962A0")]
	private FHMGLGJBBAM(JKIEPPIEFOF BIHLLCENOEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x212CF60", Offset = "0x212B960", VA = "0x18212CF60")]
	[AsyncStateMachine(typeof(JCNCGMPMNGE))]
	public static Task<FHMGLGJBBAM> BHOHJJOHHJH(PLLOHOJACCG PFCDDIODGEJ, FAOKMGJAJIO? LLAPGPIJJLB, PIKJJPNAMNM? FFHNFKPFGJK, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x212D0C0", Offset = "0x212BAC0", VA = "0x18212D0C0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public readonly struct PIPALGAAPKG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct DJOKLNPILBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<object, OBJIPJOMIPB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public PIPALGAAPKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public EHDCBMKEILE action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private TaskAwaiter<BCLNLKLFCPB<object, OBJIPJOMIPB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x2125580", Offset = "0x2123F80", VA = "0x182125580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x2125810", Offset = "0x2124210", VA = "0x182125810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct IAAAKEEDCGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<bool, OBJIPJOMIPB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public FMGJMILCPFK rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public FAOKMGJAJIO circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public PIKJJPNAMNM superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public PIPALGAAPKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private EHDCBMKEILE[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private TaskAwaiter<BCLNLKLFCPB<object, OBJIPJOMIPB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x212FFC0", Offset = "0x212E9C0", VA = "0x18212FFC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x21303A0", Offset = "0x212EDA0", VA = "0x1821303A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct EFBDCCCNBCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public PIPALGAAPKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private TaskAwaiter<BCLNLKLFCPB<object, OBJIPJOMIPB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x2125E20", Offset = "0x2124820", VA = "0x182125E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x2126060", Offset = "0x2124A60", VA = "0x182126060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private readonly HINPPEJFHLF EMGMPHENKKE;

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0xB66C60", Offset = "0xB65660", VA = "0x180B66C60")]
	public PIPALGAAPKG(HINPPEJFHLF NIHEKDKBACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x213E1D0", Offset = "0x213CBD0", VA = "0x18213E1D0")]
	[AsyncStateMachine(typeof(DJOKLNPILBK))]
	private Task<BCLNLKLFCPB<object, OBJIPJOMIPB>> OLJLEKCKCBG(EHDCBMKEILE PMCMEAHOBEF, bool ODAOKKACEAL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x213E070", Offset = "0x213CA70", VA = "0x18213E070")]
	[AsyncStateMachine(typeof(IAAAKEEDCGP))]
	public Task<BCLNLKLFCPB<bool, OBJIPJOMIPB?>>? DJFAKNFBIPP(int CPBJHCINKCL, FMGJMILCPFK? NCIIFBLDHLJ, FAOKMGJAJIO? BDKIHOIIFHL, PIKJJPNAMNM? FFHNFKPFGJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x213DF80", Offset = "0x213C980", VA = "0x18213DF80")]
	[AsyncStateMachine(typeof(EFBDCCCNBCI))]
	public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> AGDCKPANMGG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public sealed class KJKEFKBJBBJ : HBPBPJMDAIL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private readonly FEOAEBCGMMG EJKPIGOCIPF;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public FEOAEBCGMMG DNLOAGBFBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x8962A0", Offset = "0x894CA0", VA = "0x1808962A0")]
	private KJKEFKBJBBJ(FEOAEBCGMMG IKPEEHDBICN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x2136AF0", Offset = "0x21354F0", VA = "0x182136AF0")]
	public static KJKEFKBJBBJ CENBFOHJAFB(PLLOHOJACCG PFCDDIODGEJ, FMGJMILCPFK LACCAKBFKMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x2136CF0", Offset = "0x21356F0", VA = "0x182136CF0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public interface KODBJLILNLE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	JKIEPPIEFOF MMFCBCMFCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	HBLCNEAHKAK EDONFKNGOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	IGGPNOLOJEI JEAJINKEGCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	MJECCAEPCJM EGAMEHMADCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public interface OJBFNKHJHCH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	KODBJLILNLE? PAJJJJDAAAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	bool CMFCJHGPMDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	bool HHIAIJOFCNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<KODBJLILNLE?>? AKPOHNLBLOD();

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task OACPNMOABHH(PLLOHOJACCG PFCDDIODGEJ, FMGJMILCPFK LACCAKBFKMJ, FAOKMGJAJIO? JMMMBDHOMCD, PIKJJPNAMNM? AFHCBPGJMBO);
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[MFCNOAAHFGA("IStaticCV2Instance")]
public interface HDGDOAHDBCE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	JKIEPPIEFOF MMFCBCMFCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[MFCNOAAHFGA("IStaticEVInstance")]
public interface HBPBPJMDAIL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	FEOAEBCGMMG DNLOAGBFBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class MJJOHCJGCOH
{
	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x213CB70", Offset = "0x213B570", VA = "0x18213CB70")]
	public static NLEPKENBEGE<MFOMNBGIJJE, EHDCBMKEILE, PLLOHOJACCG, KOAFOGCPACB.IIALHHDPMEC<MFOMNBGIJJE, EHDCBMKEILE, PLLOHOJACCG>> ICCBPAHILNI([In] this NLEPKENBEGE<MFOMNBGIJJE, EHDCBMKEILE, PLLOHOJACCG, KOAFOGCPACB.IIALHHDPMEC<MFOMNBGIJJE, EHDCBMKEILE, PLLOHOJACCG>> MLIJNCBGECD)
	{
		return default(NLEPKENBEGE<MFOMNBGIJJE, EHDCBMKEILE, PLLOHOJACCG, KOAFOGCPACB.IIALHHDPMEC<MFOMNBGIJJE, EHDCBMKEILE, PLLOHOJACCG>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public sealed class IIHNNAADMDI : PLDGKJKJCEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private readonly PLLOHOJACCG EBBHMAKIMNA;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool HHIAIJOFCNG
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x2134100", Offset = "0x2132B00", VA = "0x182134100", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x8962A0", Offset = "0x894CA0", VA = "0x1808962A0")]
	internal IIHNNAADMDI(PLLOHOJACCG PFCDDIODGEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal sealed class ADNIMPJIPFG : GGMNELLKHNA
{
	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x2124100", Offset = "0x2122B00", VA = "0x182124100", Slot = "4")]
	public IDMADOIMLCK? LNHEAHPDNGC(string? BDPJHMFKLHB, string? FHBJDDJPGCN, string? GBMLAKNHIAH, MNHGJPAIKMN.AABAGDNJGOP.KAJKCJHGCCP DNBMEOIOPNK, bool DJDNBNJODKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public ADNIMPJIPFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public sealed class ABHABACPDFJ : BJFBDBECAIA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private struct FLGCEEFOAOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public AsyncTaskMethodBuilder<JLECLAOCGDF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public ABHABACPDFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private TaskAwaiter<KODBJLILNLE?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x212D0E0", Offset = "0x212BAE0", VA = "0x18212D0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x212D390", Offset = "0x212BD90", VA = "0x18212D390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private readonly PLLOHOJACCG EBBHMAKIMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private IReadOnlyList<JEBPJLMNFAK<MGGLKJAMIBN>>? BHEOFPGMDFE;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public JLECLAOCGDF? DFEEMNKDOMA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x2123DA0", Offset = "0x21227A0", VA = "0x182123DA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public MJECCAEPCJM? BLHOJGLAPBG
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x2124080", Offset = "0x2122A80", VA = "0x182124080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool LMODGIMHBDF
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x2123D40", Offset = "0x2122740", VA = "0x182123D40", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool DGNEAAFINPD
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x2124020", Offset = "0x2122A20", VA = "0x182124020", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x8962A0", Offset = "0x894CA0", VA = "0x1808962A0")]
	internal ABHABACPDFJ(PLLOHOJACCG PFCDDIODGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x2123C50", Offset = "0x2122650", VA = "0x182123C50", Slot = "7")]
	[AsyncStateMachine(typeof(FLGCEEFOAOP))]
	public Task<JLECLAOCGDF> BPCAKOAKKLF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x21236E0", Offset = "0x21220E0", VA = "0x1821236E0", Slot = "9")]
	public IReadOnlyDictionary<JEBPJLMNFAK<IKLMIGOGHKN>, Guid> AAMMPBOJJDG(IEnumerable<GIFFLNOJBNJ> OBCKGJINPFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x2123A50", Offset = "0x2122450", VA = "0x182123A50")]
	public BCLNLKLFCPB<AFGHPFDMMAF, JHLAIJINHDF> AHCNILAINDE([In] AFGHPFDMMAF HMMNNEKGDKN, IEnumerable<GIFFLNOJBNJ> PCMPKHGEFMC, int KOGAEFGIJII)
	{
		return default(BCLNLKLFCPB<AFGHPFDMMAF, JHLAIJINHDF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x2123E20", Offset = "0x2122820", VA = "0x182123E20", Slot = "8")]
	private BCLNLKLFCPB<AFGHPFDMMAF, JHLAIJINHDF> JFNDDKECHNF([In] AFGHPFDMMAF HMMNNEKGDKN, IEnumerable<GIFFLNOJBNJ> PCMPKHGEFMC, int KOGAEFGIJII)
	{
		return default(BCLNLKLFCPB<AFGHPFDMMAF, JHLAIJINHDF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class MJECCAEPCJM : JLECLAOCGDF
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	internal static class IABMIBDGKKK
	{
		[Cpp2IlInjected.Token(Token = "0x20000CC")]
		[CompilerGenerated]
		private sealed class PDLOCLGMGMG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000294")]
			public JKIEPPIEFOF state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000295")]
			public KBEFAFEHDLK spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public PDLOCLGMGMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0x213DE30", Offset = "0x213C830", VA = "0x18213DE30")]
			internal bool EGNNJACLBIJ(HFBMPHDALGE n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CD")]
		[CompilerGenerated]
		private sealed class CABDCENKNNL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000296")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public CABDCENKNNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FC")]
			[Cpp2IlInjected.Address(RVA = "0x2124980", Offset = "0x2123380", VA = "0x182124980")]
			internal void FHIFMKPEMFK(HFBMPHDALGE n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x2130850", Offset = "0x212F250", VA = "0x182130850")]
		public static BCLNLKLFCPB<JLECLAOCGDF.MFDFCMAOJHA, HAGOHGINEAC> CKOMBPKHALD(MJECCAEPCJM BJNJBGHPMEH, [In] JLECLAOCGDF.EAAKCLDHMON AAAOIGBEBAB)
		{
			return default(BCLNLKLFCPB<JLECLAOCGDF.MFDFCMAOJHA, HAGOHGINEAC>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x2130E10", Offset = "0x212F810", VA = "0x182130E10")]
		internal static BCLNLKLFCPB<(HLELOJACBNG, BCOPDAFELLH), HAGOHGINEAC> JODPGKACHDD(MJECCAEPCJM BJNJBGHPMEH, BCOPDAFELLH FCLKPHKBHBH, bool BHMHOHKJJPC, [In] JEBPJLMNFAK<IKLMIGOGHKN> OALDCHIBHJA, [In] int? JKGKBINKIGN, [In] OMNAEPPNJLF? MBNFAMFHLMM, [In] OMNAEPPNJLF? NAEEJPBDHCH)
		{
			return default(BCLNLKLFCPB<(HLELOJACBNG, BCOPDAFELLH), HAGOHGINEAC>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x2130410", Offset = "0x212EE10", VA = "0x182130410")]
		private static void AIDGFAKOKOJ(bool BHMHOHKJJPC, GIFFLNOJBNJ LBLEGAGFFHC, HLELOJACBNG PKLCJCEHAPB, [In] JEBPJLMNFAK<IKLMIGOGHKN> OALDCHIBHJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x2131D10", Offset = "0x2130710", VA = "0x182131D10")]
		public static void OBMINBHPEKP(GILAJLCEBJH LFDKENDMAKA, [In] JLECLAOCGDF.PEGDBMENCKH BGEAECOGHGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x2131C20", Offset = "0x2130620", VA = "0x182131C20")]
		[CompilerGenerated]
		internal static bool KPDJIFPHIND(JKIEPPIEFOF AJCFNMLFIJH, KBEFAFEHDLK CIIBBHEOJMH, HFBMPHDALGE CDONBLNAEPH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x2130DE0", Offset = "0x212F7E0", VA = "0x182130DE0")]
		[CompilerGenerated]
		internal static bool EKHGNJOFAAN(HFBMPHDALGE GANDHMGOAJC)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private struct ICAAPNJKBFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public MJECCAEPCJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public MJGAEDNBJIL<IKLMIGOGHKN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public MJGAEDNBJIL<POKJECOIACH> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public MJGAEDNBJIL<OIEHBMHNIBK> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private TaskAwaiter<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x2133620", Offset = "0x2132020", VA = "0x182133620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x2133C70", Offset = "0x2132670", VA = "0x182133C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private struct JINEDGKKKJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public MJECCAEPCJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public JEBPJLMNFAK<BKFIMEBJLKC> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public JEBPJLMNFAK<IKLMIGOGHKN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public MJGAEDNBJIL<LPDNCAKIDEG> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public MJGAEDNBJIL<EMOBFLMBFFJ> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private TaskAwaiter<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x2135DF0", Offset = "0x21347F0", VA = "0x182135DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x2136130", Offset = "0x2134B30", VA = "0x182136130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[CompilerGenerated]
	private struct CKELHHCAIFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public MJECCAEPCJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public JEBPJLMNFAK<BKFIMEBJLKC> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public JEBPJLMNFAK<IKLMIGOGHKN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public MJGAEDNBJIL<LPDNCAKIDEG> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public MJGAEDNBJIL<DGNIMDELLGK> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private TaskAwaiter<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x213FFD0", Offset = "0x213E9D0", VA = "0x18213FFD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x2140310", Offset = "0x213ED10", VA = "0x182140310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private readonly PLLOHOJACCG EBBHMAKIMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private readonly HDGDOAHDBCE EIJNCCEJHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private readonly HBPBPJMDAIL NJAAGCNHFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private readonly CFPOLMBGNDM IHCFGNNIHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private readonly ABHABACPDFJ ONLEHFBOMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private Dictionary<JEBPJLMNFAK<BKFIMEBJLKC>, KJBJNDHGBLH> HPBDPMACGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	[CompilerGenerated]
	private Action<JEBPJLMNFAK<BKFIMEBJLKC>>? FCJPACGJMHP;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public JEBPJLMNFAK<IKLMIGOGHKN> EBHEIMAPOOE
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x213B3A0", Offset = "0x2139DA0", VA = "0x18213B3A0", Slot = "4")]
		get
		{
			return default(JEBPJLMNFAK<IKLMIGOGHKN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public CFPOLMBGNDM IFFMNDEICEL
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x21206C0", Offset = "0x211F0C0", VA = "0x1821206C0", Slot = "5")]
		get
		{
			return default(CFPOLMBGNDM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x213C650", Offset = "0x213B050", VA = "0x18213C650")]
	public MJECCAEPCJM(PLLOHOJACCG PFCDDIODGEJ, HDGDOAHDBCE HNFHGIGGGHI, HBPBPJMDAIL GLCGEFKKFIJ, ABHABACPDFJ JBFBEAMBAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x2138260", Offset = "0x2136C60", VA = "0x182138260", Slot = "48")]
	public MJGAEDNBJIL<KHHNPHAINJN> BHGLCEPALBF(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<OIEHBMHNIBK> JJHCIBLPKAD)
	{
		return default(MJGAEDNBJIL<KHHNPHAINJN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x2139480", Offset = "0x2137E80", VA = "0x182139480", Slot = "49")]
	public MJGAEDNBJIL<JHLLNBLCELC> GDIGDCDJMBD(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<POKJECOIACH> GNAGOFFMLAD)
	{
		return default(MJGAEDNBJIL<JHLLNBLCELC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x213B590", Offset = "0x2139F90", VA = "0x18213B590", Slot = "6")]
	public (bool, bool) NIAPECOFDML(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<POKJECOIACH> FNCFKKIMIIP, MJGAEDNBJIL<OIEHBMHNIBK> HOHFLCBELHH)
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x2138BA0", Offset = "0x21375A0", VA = "0x182138BA0")]
	public bool EAGCCHJDEKG(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, [In] DNHHGMCCKDA FJOJNJJLGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x213A400", Offset = "0x2138E00", VA = "0x18213A400", Slot = "8")]
	public bool IFIMNFLIONH(PGALABIFJNM PAPOIHIFOHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x21388C0", Offset = "0x21372C0", VA = "0x1821388C0", Slot = "9")]
	public bool DLBBEJPMMIC(HDDFAAMLDIO IPNLOKGCFLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x213C3D0", Offset = "0x213ADD0", VA = "0x18213C3D0", Slot = "10")]
	public JOJMLCOLNPG? PAGBIJLGGKC(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<OIEHBMHNIBK> JJHCIBLPKAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x213C490", Offset = "0x213AE90", VA = "0x18213C490", Slot = "11")]
	public CDJPIOGEALH? PIHCLAGPFLO(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<POKJECOIACH> GNAGOFFMLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x2139350", Offset = "0x2137D50", VA = "0x182139350", Slot = "12")]
	public IEnumerable<MJGAEDNBJIL<OGIDDDCEPIG>> FHPFFHFJHIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x213B330", Offset = "0x2139D30", VA = "0x18213B330", Slot = "13")]
	public string MBDEEEHGEOE(MJGAEDNBJIL<OGIDDDCEPIG> PGMHDMOFOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x213AA50", Offset = "0x2139450", VA = "0x18213AA50", Slot = "14")]
	public string KOPOGEGEMBC(MJGAEDNBJIL<OGIDDDCEPIG> PGMHDMOFOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x213B0B0", Offset = "0x2139AB0", VA = "0x18213B0B0")]
	public KJBJNDHGBLH? LGEIFNDJCDD([In] JEBPJLMNFAK<BKFIMEBJLKC> JJLNKABMPOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x2139400", Offset = "0x2137E00", VA = "0x182139400")]
	public MJGAEDNBJIL<BKFIMEBJLKC> LAGHACBIDPB(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, [In] JEBPJLMNFAK<BKFIMEBJLKC> OPGPKNHCAJL)
	{
		return default(MJGAEDNBJIL<BKFIMEBJLKC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x213C550", Offset = "0x213AF50", VA = "0x18213C550", Slot = "26")]
	public MJGAEDNBJIL<BKFIMEBJLKC> PLAHAPNONIF(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<OIEHBMHNIBK> JJHCIBLPKAD)
	{
		return default(MJGAEDNBJIL<BKFIMEBJLKC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x21381E0", Offset = "0x2136BE0", VA = "0x1821381E0", Slot = "27")]
	public MJGAEDNBJIL<BKFIMEBJLKC> BFGHIKBHNNE(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<POKJECOIACH> GNAGOFFMLAD)
	{
		return default(MJGAEDNBJIL<BKFIMEBJLKC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x213A5E0", Offset = "0x2138FE0", VA = "0x18213A5E0")]
	private void IOJKIFHOHDJ(JEBPJLMNFAK<BKFIMEBJLKC> JJLNKABMPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x2138570", Offset = "0x2136F70", VA = "0x182138570")]
	public IEnumerable<KJBJNDHGBLH> CJJGNADANIM([In] JEBPJLMNFAK<IKLMIGOGHKN> CFNEBLLEIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x2137A50", Offset = "0x2136450", VA = "0x182137A50", Slot = "25")]
	public MJGAEDNBJIL<OIEHBMHNIBK> ABAGOEDDNMB(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<BKFIMEBJLKC> JJLNKABMPOP, MJGAEDNBJIL<KHHNPHAINJN> DLKOGGNFIGC)
	{
		return default(MJGAEDNBJIL<OIEHBMHNIBK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x21386B0", Offset = "0x21370B0", VA = "0x1821386B0", Slot = "28")]
	public MJGAEDNBJIL<POKJECOIACH> COHLLOHCCLP(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<BKFIMEBJLKC> JJLNKABMPOP, MJGAEDNBJIL<JHLLNBLCELC> POPPKCBMEOO)
	{
		return default(MJGAEDNBJIL<POKJECOIACH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x213B1B0", Offset = "0x2139BB0", VA = "0x18213B1B0")]
	private KJBJNDHGBLH? LGMMFJBMFIB([In] JEBPJLMNFAK<BKFIMEBJLKC> JJLNKABMPOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x213A700", Offset = "0x2139100", VA = "0x18213A700")]
	private KJBJNDHGBLH JNEPLMJOOMI([In] JEBPJLMNFAK<BKFIMEBJLKC> JJLNKABMPOP, DPIPCKFLLFL KOHLOCENPAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x213B020", Offset = "0x2139A20", VA = "0x18213B020")]
	public DPIPCKFLLFL? LFPCNJAKDPB([In] JEBPJLMNFAK<BKFIMEBJLKC> JJLNKABMPOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x2139A20", Offset = "0x2138420", VA = "0x182139A20")]
	public PHGLNNNIEFI? HBCDFHMHBDI([In] JEBPJLMNFAK<IKLMIGOGHKN> CFNEBLLEIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x2137CE0", Offset = "0x21366E0", VA = "0x182137CE0", Slot = "20")]
	public IEnumerable<BIOGDENGLJE> ALBJEMJDJDH(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x213A370", Offset = "0x2138D70", VA = "0x18213A370", Slot = "21")]
	public bool HLALHEMMNDM(MJGAEDNBJIL<OGIDDDCEPIG> PGMHDMOFOGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x21390C0", Offset = "0x2137AC0", VA = "0x1821390C0", Slot = "22")]
	public IEnumerable<DNHHGMCCKDA> EPNCPJKAHPA(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<POKJECOIACH> FNCFKKIMIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x213A7D0", Offset = "0x21391D0", VA = "0x18213A7D0", Slot = "23")]
	public IEnumerable<DNHHGMCCKDA> KIELGOOJAKA(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<OIEHBMHNIBK> HOHFLCBELHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x2139500", Offset = "0x2137F00", VA = "0x182139500")]
	public MJGAEDNBJIL<IKLMIGOGHKN> GENDHABPLKA([In] JEBPJLMNFAK<IKLMIGOGHKN> CFNEBLLEIOK)
	{
		return default(MJGAEDNBJIL<IKLMIGOGHKN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x2138740", Offset = "0x2137140", VA = "0x182138740")]
	public MJGAEDNBJIL<IKLMIGOGHKN>? FGFGNPOHHEC([In] JEBPJLMNFAK<IKLMIGOGHKN> CFNEBLLEIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x213B1F0", Offset = "0x2139BF0", VA = "0x18213B1F0")]
	private KBEFAFEHDLK? LJHICOILEKN([In] JEBPJLMNFAK<IKLMIGOGHKN> CFNEBLLEIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x2139A20", Offset = "0x2138420", VA = "0x182139A20")]
	private PHGLNNNIEFI? GNNJBGGEIII([In] JEBPJLMNFAK<IKLMIGOGHKN> CFNEBLLEIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x213B520", Offset = "0x2139F20", VA = "0x18213B520", Slot = "32")]
	public JEBPJLMNFAK<IKLMIGOGHKN> NFOAKHFFDIJ(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK)
	{
		return default(JEBPJLMNFAK<IKLMIGOGHKN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x21387C0", Offset = "0x21371C0", VA = "0x1821387C0", Slot = "29")]
	public IEnumerable<BLDEJALINAE> DDGEBDDKKDH(NBDEAPDPBJH AMGOEMNHBOG, bool KNGGOCLLICE, bool HMLKIBJOLFB, bool ELNAIAOEFIO, bool JPDEBCKCJBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x2137DA0", Offset = "0x21367A0", VA = "0x182137DA0", Slot = "30")]
	public BLDEJALINAE AMBDNKFONCM(NBDEAPDPBJH AMGOEMNHBOG, DBDMDCDNCFC LCAJPCNBBOP, bool KNGGOCLLICE, bool HMLKIBJOLFB, bool ELNAIAOEFIO, bool JPDEBCKCJBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x2138A30", Offset = "0x2137430", VA = "0x182138A30")]
	public BIOGDENGLJE DOOEOHFFJPC(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, [In] DNHHGMCCKDA FJOJNJJLGCC)
	{
		return default(BIOGDENGLJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x21382E0", Offset = "0x2136CE0", VA = "0x1821382E0", Slot = "33")]
	public DNHHGMCCKDA CCAENPIGEHE(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<POKJECOIACH> FNCFKKIMIIP, MJGAEDNBJIL<OIEHBMHNIBK> HOHFLCBELHH)
	{
		return default(DNHHGMCCKDA);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x213A110", Offset = "0x2138B10", VA = "0x18213A110", Slot = "34")]
	public bool HDPEICIKEMO(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x213C5D0", Offset = "0x213AFD0", VA = "0x18213C5D0", Slot = "35")]
	public bool PPBBOCCCDOK(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<OIEHBMHNIBK> JJHCIBLPKAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x213B2B0", Offset = "0x2139CB0", VA = "0x18213B2B0", Slot = "36")]
	public bool LLNNCGCPBFO(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<POKJECOIACH> GNAGOFFMLAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x213B400", Offset = "0x2139E00", VA = "0x18213B400")]
	public BCLNLKLFCPB<JLECLAOCGDF.MFDFCMAOJHA, HAGOHGINEAC> OECLOIEDBFL([In] JLECLAOCGDF.EAAKCLDHMON AAAOIGBEBAB)
	{
		return default(BCLNLKLFCPB<JLECLAOCGDF.MFDFCMAOJHA, HAGOHGINEAC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x21380B0", Offset = "0x2136AB0", VA = "0x1821380B0", Slot = "38")]
	[AsyncStateMachine(typeof(ICAAPNJKBFC))]
	public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> BDIELOGFGDP(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<POKJECOIACH> FNCFKKIMIIP, MJGAEDNBJIL<OIEHBMHNIBK> HOHFLCBELHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x213BAF0", Offset = "0x213A4F0", VA = "0x18213BAF0", Slot = "39")]
	public BCLNLKLFCPB<IPJFJGJEIGD, JHLAIJINHDF> OBGIJBPLAKO(JEBPJLMNFAK<IKLMIGOGHKN> CFNEBLLEIOK, IPJFJGJEIGD ADDAMHCLIBE, JGKIEDLDOEA DHJLFOMHIND)
	{
		return default(BCLNLKLFCPB<IPJFJGJEIGD, JHLAIJINHDF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x213A480", Offset = "0x2138E80", VA = "0x18213A480", Slot = "40")]
	[AsyncStateMachine(typeof(JINEDGKKKJL))]
	public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> INECIEGACGL(JEBPJLMNFAK<IKLMIGOGHKN> CFNEBLLEIOK, JEBPJLMNFAK<BKFIMEBJLKC> LCANIIFIEMF, MJGAEDNBJIL<LPDNCAKIDEG> JLJOAACNPFI, MJGAEDNBJIL<EMOBFLMBFFJ> JJHCIBLPKAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x213AB40", Offset = "0x2139540", VA = "0x18213AB40", Slot = "41")]
	[AsyncStateMachine(typeof(CKELHHCAIFA))]
	public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> LBAEPMHBPAP(JEBPJLMNFAK<IKLMIGOGHKN> CFNEBLLEIOK, JEBPJLMNFAK<BKFIMEBJLKC> PDJBFCDNGBB, MJGAEDNBJIL<LPDNCAKIDEG> OHBHCKJLONM, MJGAEDNBJIL<DGNIMDELLGK> GNAGOFFMLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x213A180", Offset = "0x2138B80", VA = "0x18213A180", Slot = "42")]
	public BAGMEALJIGN HHGLOPEGEAB(IEnumerable<GIFFLNOJBNJ> PCMPKHGEFMC)
	{
		return default(BAGMEALJIGN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x2137BC0", Offset = "0x21365C0", VA = "0x182137BC0", Slot = "43")]
	public BAGMEALJIGN AEHBILKJDKD()
	{
		return default(BAGMEALJIGN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x213C220", Offset = "0x213AC20", VA = "0x18213C220")]
	private MEPFIAHFCFN OKOFPMCMDKF(FEOJIMLIEKI JMIHOMEEEFK, MJGAEDNBJIL<IKLMIGOGHKN> LOPIFPAENDO, IEnumerable<JEBPJLMNFAK<IKLMIGOGHKN>> EHGGNEILGPP, IEnumerable<JEBPJLMNFAK<BKFIMEBJLKC>> ENKCBJCPFGA)
	{
		return default(MEPFIAHFCFN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x213BEE0", Offset = "0x213A8E0", VA = "0x18213BEE0", Slot = "44")]
	public MEPFIAHFCFN OKOFPMCMDKF(FEOJIMLIEKI JMIHOMEEEFK, MJGAEDNBJIL<IKLMIGOGHKN> LOPIFPAENDO, IEnumerable<JEBPJLMNFAK<BKFIMEBJLKC>> ENKCBJCPFGA, IEnumerable<GIFFLNOJBNJ> PCMPKHGEFMC)
	{
		return default(MEPFIAHFCFN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x213ACA0", Offset = "0x21396A0", VA = "0x18213ACA0")]
	private static IEnumerable<JEBPJLMNFAK<IKLMIGOGHKN>> LCPFMGHGDPP(IEnumerable<GIFFLNOJBNJ> PCMPKHGEFMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x2139580", Offset = "0x2137F80", VA = "0x182139580")]
	private IEnumerable<JEBPJLMNFAK<BKFIMEBJLKC>> GHIBMNBBGBF(IEnumerable<GIFFLNOJBNJ> PCMPKHGEFMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x213A670", Offset = "0x2139070", VA = "0x18213A670", Slot = "45")]
	public List<PAGJKMGJCIJ> JHLFOMPHHEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x2139A50", Offset = "0x2138450", VA = "0x182139A50")]
	public (List<PAGJKMGJCIJ>, bool) GPNHGHNBOAP([In] DEMJHDDNEDF IOALIBOMCPO, string EIGKPCONJCB, [In] MPCJFPCFBLE HDGFEAEGBPD, EIHJEHOHPNN HPPMAKAELKH, MLEOPDFABBI GOLNPFHOCCO)
	{
		return default((List<PAGJKMGJCIJ>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x2138FD0", Offset = "0x21379D0", VA = "0x182138FD0", Slot = "47")]
	public bool EPMAEFABEIL(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x2138650", Offset = "0x2137050", VA = "0x182138650")]
	internal void CNKNNMDIHEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x213BA90", Offset = "0x213A490", VA = "0x18213BA90")]
	internal Task NOAIDDBHPAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x21380A0", Offset = "0x2136AA0", VA = "0x1821380A0", Slot = "7")]
	private bool BBIGHOMPFJD(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, [In] DNHHGMCCKDA FJOJNJJLGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x2139A20", Offset = "0x2138420", VA = "0x182139A20", Slot = "15")]
	private PHGLNNNIEFI KKLGOIBKCIC([In] JEBPJLMNFAK<IKLMIGOGHKN> CFNEBLLEIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x2139500", Offset = "0x2137F00", VA = "0x182139500", Slot = "16")]
	private MJGAEDNBJIL<IKLMIGOGHKN> JLGJMLBOCKB([In] JEBPJLMNFAK<IKLMIGOGHKN> CFNEBLLEIOK)
	{
		return default(MJGAEDNBJIL<IKLMIGOGHKN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x2138740", Offset = "0x2137140", VA = "0x182138740", Slot = "17")]
	private MJGAEDNBJIL<IKLMIGOGHKN>? DALDPBEHPCF([In] JEBPJLMNFAK<IKLMIGOGHKN> CFNEBLLEIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x213B430", Offset = "0x2139E30", VA = "0x18213B430", Slot = "18")]
	private KJBJNDHGBLH NDDNEMNKFMB([In] JEBPJLMNFAK<BKFIMEBJLKC> JJLNKABMPOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x2139400", Offset = "0x2137E00", VA = "0x182139400", Slot = "19")]
	private MJGAEDNBJIL<BKFIMEBJLKC> GABIGOCNKDJ(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, [In] JEBPJLMNFAK<BKFIMEBJLKC> OPGPKNHCAJL)
	{
		return default(MJGAEDNBJIL<BKFIMEBJLKC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x2137AE0", Offset = "0x21364E0", VA = "0x182137AE0", Slot = "24")]
	private IEnumerable<KJBJNDHGBLH> ACAIHFDDCGD([In] JEBPJLMNFAK<IKLMIGOGHKN> CFNEBLLEIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x2138A30", Offset = "0x2137430", VA = "0x182138A30", Slot = "31")]
	private BIOGDENGLJE DPLCDHABJFD(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, [In] DNHHGMCCKDA FJOJNJJLGCC)
	{
		return default(BIOGDENGLJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x213B400", Offset = "0x2139E00", VA = "0x18213B400", Slot = "37")]
	private BCLNLKLFCPB<JLECLAOCGDF.MFDFCMAOJHA, HAGOHGINEAC> MHHLBNPCJAN([In] JLECLAOCGDF.EAAKCLDHMON AAAOIGBEBAB)
	{
		return default(BCLNLKLFCPB<JLECLAOCGDF.MFDFCMAOJHA, HAGOHGINEAC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x2138510", Offset = "0x2136F10", VA = "0x182138510", Slot = "46")]
	private (List<PAGJKMGJCIJ>, bool) CGJADLKHMJC([In] DEMJHDDNEDF IOALIBOMCPO, string EIGKPCONJCB, [In] MPCJFPCFBLE HDGFEAEGBPD, EIHJEHOHPNN HPPMAKAELKH, MLEOPDFABBI GOLNPFHOCCO)
	{
		return default((List<PAGJKMGJCIJ>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x2138940", Offset = "0x2137340", VA = "0x182138940")]
	[CompilerGenerated]
	private KJBJNDHGBLH DMAOGMPJJFC(DPIPCKFLLFL DMIMFDDIIBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x213AAC0", Offset = "0x21394C0", VA = "0x18213AAC0")]
	[CompilerGenerated]
	private GGIKKAOEIBP LAHAJIEEBGL(DHDNLKJCEHP DMIMFDDIIBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x2138EF0", Offset = "0x21378F0", VA = "0x182138EF0")]
	[CompilerGenerated]
	private DPIPCKFLLFL EEMEOEHIHJC(JEBPJLMNFAK<BKFIMEBJLKC> DMIMFDDIIBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x2138F60", Offset = "0x2137960", VA = "0x182138F60")]
	[CompilerGenerated]
	private KBEFAFEHDLK ENKPLFGBHKB(JEBPJLMNFAK<IKLMIGOGHKN> DMIMFDDIIBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class GGIKKAOEIBP : BLDEJALINAE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private struct AIAKFOPBNNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<MJGAEDNBJIL<DDABHKCABNE>, OBJIPJOMIPB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public GGIKKAOEIBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public JEBPJLMNFAK<IKLMIGOGHKN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public JEBPJLMNFAK<BKFIMEBJLKC> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public MJGAEDNBJIL<LPDNCAKIDEG> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private TaskAwaiter<BCLNLKLFCPB<MJGAEDNBJIL<DDABHKCABNE>, OBJIPJOMIPB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x213F8B0", Offset = "0x213E2B0", VA = "0x18213F8B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x213FB30", Offset = "0x213E530", VA = "0x18213FB30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct MMAJCBNLDDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<MJGAEDNBJIL<OMDILHJFPPO>, OBJIPJOMIPB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public GGIKKAOEIBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public JEBPJLMNFAK<IKLMIGOGHKN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public JEBPJLMNFAK<BKFIMEBJLKC> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public MJGAEDNBJIL<LPDNCAKIDEG> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private TaskAwaiter<BCLNLKLFCPB<MJGAEDNBJIL<OMDILHJFPPO>, OBJIPJOMIPB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x2141F50", Offset = "0x2140950", VA = "0x182141F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x21421D0", Offset = "0x2140BD0", VA = "0x1821421D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	private readonly DHDNLKJCEHP PDGMJAONLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	private readonly HDGDOAHDBCE EIJNCCEJHAJ;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public TypeKey JLIOICDBMFI
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x941880", Offset = "0x940280", VA = "0x180941880", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public string ANKHGDAKIPK
	{
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x2140B10", Offset = "0x213F510", VA = "0x182140B10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public DHDNLKJCEHP NNCCFHGGNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x2140B40", Offset = "0x213F540", VA = "0x182140B40")]
	public GGIKKAOEIBP(DHDNLKJCEHP GPPILCGIDPO, HDGDOAHDBCE HNFHGIGGGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x2140830", Offset = "0x213F230", VA = "0x182140830", Slot = "6")]
	[AsyncStateMachine(typeof(AIAKFOPBNNC))]
	public Task<BCLNLKLFCPB<MJGAEDNBJIL<DDABHKCABNE>, OBJIPJOMIPB>> DFOEGKCLDNP(JEBPJLMNFAK<IKLMIGOGHKN> CFNEBLLEIOK, JEBPJLMNFAK<BKFIMEBJLKC> JJLNKABMPOP, MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, string KJPHMNNIMDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x21409A0", Offset = "0x213F3A0", VA = "0x1821409A0", Slot = "7")]
	[AsyncStateMachine(typeof(MMAJCBNLDDD))]
	public Task<BCLNLKLFCPB<MJGAEDNBJIL<OMDILHJFPPO>, OBJIPJOMIPB>> HOPEMPKIOPD(JEBPJLMNFAK<IKLMIGOGHKN> CFNEBLLEIOK, JEBPJLMNFAK<BKFIMEBJLKC> JJLNKABMPOP, MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, string KJPHMNNIMDP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class OCDCOPCGBAN : JJKCEJGCFAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private readonly DHDNLKJCEHP EKFNPIOLJCE;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private static readonly HashSet<DHDNLKJCEHP> AHBNNEPLFDL;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private static readonly HashSet<DHDNLKJCEHP> HHNNKCKEJEF;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private static readonly HashSet<DHDNLKJCEHP> HOMLMJDAPKM;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public TypeKey PJJDBLNOLBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x2143840", Offset = "0x2142240", VA = "0x182143840", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool PDOKMEKDLLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x2143830", Offset = "0x2142230", VA = "0x182143830", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool CLONLEEEHOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x2143890", Offset = "0x2142290", VA = "0x182143890", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool PNPEAAHNAKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x21437B0", Offset = "0x21421B0", VA = "0x1821437B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x21422E0", Offset = "0x2140CE0", VA = "0x1821422E0")]
	public bool HOPFCGCIMCA(string KLABJGGMBGH, [Out] EAFLNFBKMPG ELKCMKIAGCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x8962A0", Offset = "0x894CA0", VA = "0x1808962A0")]
	public OCDCOPCGBAN(DHDNLKJCEHP BDPEMHOFOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x2142550", Offset = "0x2140F50", VA = "0x182142550")]
	internal static TypeKey LOALKGGBBFA(DHDNLKJCEHP JLAAKHANEHC)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x2140B10", Offset = "0x213F510", VA = "0x182140B10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public readonly struct KLMPMGIBPPL : CLPIGHBJMNE.KJKIDNIDONJ<EHDCBMKEILE, BLGMJKLPHOM>
{
	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x2141D50", Offset = "0x2140750", VA = "0x182141D50", Slot = "4")]
	public int PBIHFPGECEM(BLGMJKLPHOM MNKBAIOBLHC, EHDCBMKEILE PMCMEAHOBEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x2141C40", Offset = "0x2140640", VA = "0x182141C40", Slot = "5")]
	public EHDCBMKEILE CJIJFGLHFCK(BLGMJKLPHOM MNKBAIOBLHC, EHDCBMKEILE PMCMEAHOBEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x2141C90", Offset = "0x2140690", VA = "0x182141C90", Slot = "6")]
	public EHDCBMKEILE HCCEBIGFGKG(BLGMJKLPHOM MNKBAIOBLHC, EHDCBMKEILE PMCMEAHOBEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x2141C70", Offset = "0x2140670", VA = "0x182141C70", Slot = "7")]
	public IReadOnlyList<EHDCBMKEILE> EEJOGACOINC(BLGMJKLPHOM MNKBAIOBLHC, EHDCBMKEILE PMCMEAHOBEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x2141D00", Offset = "0x2140700", VA = "0x182141D00", Slot = "8")]
	public EHDCBMKEILE[] IHJIPFOCGOK(BLGMJKLPHOM MNKBAIOBLHC, EHDCBMKEILE PMCMEAHOBEF, int JPBCAMCEGCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x2141D10", Offset = "0x2140710", VA = "0x182141D10", Slot = "9")]
	public bool INFAKIJBNBJ(BLGMJKLPHOM MNKBAIOBLHC, EHDCBMKEILE PMCMEAHOBEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x2141D30", Offset = "0x2140730", VA = "0x182141D30", Slot = "10")]
	public bool LCBKKANPDKA(BLGMJKLPHOM MNKBAIOBLHC, EHDCBMKEILE PMCMEAHOBEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x2141CE0", Offset = "0x21406E0", VA = "0x182141CE0", Slot = "11")]
	public bool IDFOHOCIBKH(BLGMJKLPHOM MNKBAIOBLHC, EHDCBMKEILE PMCMEAHOBEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x2141C20", Offset = "0x2140620", VA = "0x182141C20", Slot = "12")]
	public bool BCHHKPGBIIF(BLGMJKLPHOM MNKBAIOBLHC, EHDCBMKEILE PMCMEAHOBEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x2141CC0", Offset = "0x21406C0", VA = "0x182141CC0", Slot = "13")]
	public bool HFBCLKIGHHI(BLGMJKLPHOM GHAOBMIKKNE, EHDCBMKEILE PMCMEAHOBEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x2141C50", Offset = "0x2140650", VA = "0x182141C50", Slot = "14")]
	public bool EAENEDBMMEI(BLGMJKLPHOM MNKBAIOBLHC, EHDCBMKEILE PMCMEAHOBEF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public abstract class NIKOBALALMB : NBIGEKGGIIN
{
	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public FIPHNEFFDCE.IPOEBKNAGLF KHCKEABEMJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x2142290", Offset = "0x2140C90", VA = "0x182142290", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public abstract JHLIMPAJNBN.EJAJLDBKNGE OJJKKNJEGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public abstract PLLOHOJACCG.KNELNOGLGKD GPEKAOAKBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public abstract FHMGLGJBBAM.JBAIHKMGBEO EDNCNNIGMOO
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public KOAFOGCPACB.IIALHHDPMEC<MFOMNBGIJJE, EHDCBMKEILE, PLLOHOJACCG> ENKAGJOGOGC
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x2142240", Offset = "0x2140C40", VA = "0x182142240", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public abstract GOHBBJGIJKI IELODJJOMGF
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public abstract AIJHDMLFNEJ IGHDBBOFPGG
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public abstract LILGLJLEAMJ EHDEGADEJKM
	{
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public abstract LKNDLJOPDAD KEMHDKDJADI
	{
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public abstract MADEDEPMAFJ BCPOOCELJCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	protected NIKOBALALMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class JGPIONBCOJB : JHOIGJDACKG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct IHEJAAONBPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<object, OBJIPJOMIPB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public JGPIONBCOJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public EHDCBMKEILE action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private TaskAwaiter<BCLNLKLFCPB<object, OBJIPJOMIPB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x21416B0", Offset = "0x21400B0", VA = "0x1821416B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x2141950", Offset = "0x2140350", VA = "0x182141950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct EKHBNBHIBEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<LKBKALCJMFG, OBJIPJOMIPB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public JGPIONBCOJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public IReadOnlyList<EHDCBMKEILE> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private TaskAwaiter<BCLNLKLFCPB<object, OBJIPJOMIPB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x2140440", Offset = "0x213EE40", VA = "0x182140440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x21407C0", Offset = "0x213F1C0", VA = "0x1821407C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	private readonly HINPPEJFHLF EMGMPHENKKE;

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x8962A0", Offset = "0x894CA0", VA = "0x1808962A0")]
	public JGPIONBCOJB(HINPPEJFHLF NIHEKDKBACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x2141AF0", Offset = "0x21404F0", VA = "0x182141AF0")]
	[AsyncStateMachine(typeof(IHEJAAONBPI))]
	private Task<BCLNLKLFCPB<object, OBJIPJOMIPB>> OLJLEKCKCBG(EHDCBMKEILE PMCMEAHOBEF, bool ODAOKKACEAL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x21419C0", Offset = "0x21403C0", VA = "0x1821419C0", Slot = "4")]
	[AsyncStateMachine(typeof(EKHBNBHIBEK))]
	public Task<BCLNLKLFCPB<LKBKALCJMFG, OBJIPJOMIPB>> NKKMMCGMHBD(IReadOnlyList<EHDCBMKEILE> EENNPJMHNKA, bool ODAOKKACEAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public struct EEAOBHNHAIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	internal BHBPOCEFBGG<HKAMLFAFHNK, EHDCBMKEILE, LBHAJJONOCE> EKFNPIOLJCE;

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x2106D20", Offset = "0x2105720", VA = "0x182106D20")]
	private EEAOBHNHAIM([In] BHBPOCEFBGG<HKAMLFAFHNK, EHDCBMKEILE, LBHAJJONOCE> OHAKFLBGIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x2140380", Offset = "0x213ED80", VA = "0x182140380")]
	public static EEAOBHNHAIM GGBAHLJJLHO()
	{
		return default(EEAOBHNHAIM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public static class HBMNBBGIIML
{
	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x9461F0", Offset = "0x944BF0", VA = "0x1809461F0")]
	public static BHBPOCEFBGG<HKAMLFAFHNK, EHDCBMKEILE, LBHAJJONOCE> GKKCCNPACLP(this EEAOBHNHAIM BJNJBGHPMEH)
	{
		return default(BHBPOCEFBGG<HKAMLFAFHNK, EHDCBMKEILE, LBHAJJONOCE>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public struct LBHAJJONOCE : EMHMHKCIFHB.EKJFLNMGEMN<HKAMLFAFHNK, EHDCBMKEILE>
{
	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x2141D70", Offset = "0x2140770", VA = "0x182141D70", Slot = "5")]
	public EHDCBMKEILE NOANCEBBCHI(HKAMLFAFHNK[] GCGECJMEOOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x191AF30", Offset = "0x1919930", VA = "0x18191AF30")]
	public int NJJKAJPOLFL([In] HKAMLFAFHNK IBEOBEHLBLA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x191AF30", Offset = "0x1919930", VA = "0x18191AF30", Slot = "4")]
	private int CINHBGIGECG([In] HKAMLFAFHNK LGEGPBPIJEN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public struct EFGKIDLCFBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	internal KHGNBNGFBDM<BDIKLFAAIFG, EHDCBMKEILE, HKDIGDJHOOF> EKFNPIOLJCE;

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x2106D20", Offset = "0x2105720", VA = "0x182106D20")]
	private EFGKIDLCFBA([In] KHGNBNGFBDM<BDIKLFAAIFG, EHDCBMKEILE, HKDIGDJHOOF> NEBNKJIBLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x21403E0", Offset = "0x213EDE0", VA = "0x1821403E0")]
	public static EFGKIDLCFBA GGBAHLJJLHO()
	{
		return default(EFGKIDLCFBA);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public static class FDOGBLIJHHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x9461F0", Offset = "0x944BF0", VA = "0x1809461F0")]
	public static KHGNBNGFBDM<BDIKLFAAIFG, EHDCBMKEILE, HKDIGDJHOOF> GKKCCNPACLP(this EFGKIDLCFBA BJNJBGHPMEH)
	{
		return default(KHGNBNGFBDM<BDIKLFAAIFG, EHDCBMKEILE, HKDIGDJHOOF>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public struct HKDIGDJHOOF : LPBANJKMDOB.ELFPKLHOBFD<BDIKLFAAIFG, EHDCBMKEILE>
{
	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x191AF30", Offset = "0x1919930", VA = "0x18191AF30")]
	public int KLDOIHEMJFL([In] BDIKLFAAIFG IBEOBEHLBLA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x21414D0", Offset = "0x213FED0", VA = "0x1821414D0", Slot = "5")]
	public EHDCBMKEILE AEFBJABAPOD(BDIKLFAAIFG[] AFLGGLEOMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x191AF30", Offset = "0x1919930", VA = "0x18191AF30", Slot = "4")]
	private int FOEPHOAPKMP([In] BDIKLFAAIFG IBEOBEHLBLA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public class BGLKIAPELNH : LBGFPGMHGDG, HAGOHGINEAC, OBJIPJOMIPB, JHLAIJINHDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private readonly JHLAIJINHDF? BGFJIHIILBB;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public MDAICEEICDH LJIJAODAALE
	{
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x89F660", Offset = "0x89E060", VA = "0x18089F660", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(MDAICEEICDH);
		}
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x8A40C0", Offset = "0x8A2AC0", VA = "0x1808A40C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public override JHLAIJINHDF? GLFEJPFJNNO
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x898FC0", Offset = "0x8979C0", VA = "0x180898FC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x213FBA0", Offset = "0x213E5A0", VA = "0x18213FBA0", Slot = "7")]
	public override string CKGPGAAGKNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x213FE80", Offset = "0x213E880", VA = "0x18213FE80")]
	private BGLKIAPELNH(MDAICEEICDH FODBPFPIPNA, JHLAIJINHDF? ICAENOKHDMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x213FD90", Offset = "0x213E790", VA = "0x18213FD90")]
	public static BGLKIAPELNH IDAHCNBINFF(JHLAIJINHDF ICAENOKHDMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x213FD20", Offset = "0x213E720", VA = "0x18213FD20")]
	public static BGLKIAPELNH ICCHCCKLLEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x213FE10", Offset = "0x213E810", VA = "0x18213FE10")]
	public static BGLKIAPELNH MHEMHBDOIIM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class KPDPMIKNJLL
{
	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x2E4C990", Offset = "0x2E4B390", VA = "0x182E4C990")]
	public static BCLNLKLFCPB<TOk, HAGOHGINEAC> IKNJBICJJCD<TOk>([In] this BCLNLKLFCPB<TOk, HAGOHGINEAC> BJNJBGHPMEH, JHLAIJINHDF ICAENOKHDMC) where TOk : notnull
	{
		return default(BCLNLKLFCPB<TOk, HAGOHGINEAC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x2E4CA80", Offset = "0x2E4B480", VA = "0x182E4CA80")]
	public static BCLNLKLFCPB<TOk?, HAGOHGINEAC?> KDOCIHDCLLC<TOk>([In] this BCLNLKLFCPB<TOk, HAGOHGINEAC> BJNJBGHPMEH)
	{
		return default(BCLNLKLFCPB<TOk, HAGOHGINEAC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x2E4C890", Offset = "0x2E4B290", VA = "0x182E4C890")]
	public static BCLNLKLFCPB<TOk?, HAGOHGINEAC?> BEDFMJDJKIM<TOk>([In] this BCLNLKLFCPB<TOk, HAGOHGINEAC> BJNJBGHPMEH)
	{
		return default(BCLNLKLFCPB<TOk, HAGOHGINEAC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public interface GOHBBJGIJKI
{
	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BMKCCJLKDDB([In] BCLNLKLFCPB<BLGMJKLPHOM, JHLAIJINHDF> POBDLJBBBCI);
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public static class MKIEDJDJOOP
{
	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x2E81F30", Offset = "0x2E80930", VA = "0x182E81F30")]
	public static bool BMKCCJLKDDB<TOk, TErr>(this GOHBBJGIJKI BJNJBGHPMEH, [In] BCLNLKLFCPB<TOk, TErr> POBDLJBBBCI) where TOk : notnull where TErr : notnull, JHLAIJINHDF
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public interface AIJHDMLFNEJ
{
	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	OJJOLMFANPM CGOFIFEAKDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public interface LILGLJLEAMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OKNBGAPNIGA HBDNAJACIIE(int KDLMAHAJHMP);
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public interface NCDBNPGPHNP
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	string FHACOBMPENF
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public interface GGABBEDLODL
{
	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEOMJHEDCAP? OCDJDIEPHCC(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB);
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public interface DCLFJKKBJGK
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	string FHACOBMPENF
	{
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public interface IEOMJHEDCAP
{
	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	string FHACOBMPENF
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DCLFJKKBJGK? DPPDDHEPKFN(MJGAEDNBJIL<DDABHKCABNE> IINCKHAMMKN);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NCDBNPGPHNP? JEMPIKIALAL(MJGAEDNBJIL<OMDILHJFPPO> DPNCALJCMOD);
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public interface LKNDLJOPDAD
{
	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> GIMHHDFCHCF(string KLABJGGMBGH, string EIGKPCONJCB);
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public interface MADEDEPMAFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GGABBEDLODL? PHOLBGCCDFG([In] JEBPJLMNFAK<MGGLKJAMIBN> EJLKAHPPPLC);
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class GKFFMDBINFI
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	private struct CGCJNDNEDNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public int OAGDGHBELJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public FAOKMGJAJIO? HJIJKGACNGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public FAOKMGJAJIO? HBJNIOEMHAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public readonly List<EHDCBMKEILE> CDPJBFFIECG;

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x213FF80", Offset = "0x213E980", VA = "0x18213FF80")]
		private CGCJNDNEDNJ(int HGFDMIDEFHN, FAOKMGJAJIO? GLGDPJGHHKL, FAOKMGJAJIO? BOIDABFICBM, List<EHDCBMKEILE> EENNPJMHNKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x213FEC0", Offset = "0x213E8C0", VA = "0x18213FEC0")]
		public static CGCJNDNEDNJ GGBAHLJJLHO()
		{
			return default(CGCJNDNEDNJ);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private readonly PJKMINGADML<CGCJNDNEDNJ> FOEINHJDDJJ;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public static GKFFMDBINFI DFEEMNKDOMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x2140CA0", Offset = "0x213F6A0", VA = "0x182140CA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool NDCBOPNPOIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x923890", Offset = "0x922290", VA = "0x180923890")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x923B70", Offset = "0x922570", VA = "0x180923B70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x2140BE0", Offset = "0x213F5E0", VA = "0x182140BE0")]
	public void BLELJAEMPMD(JKIEPPIEFOF BOIDABFICBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x2140CF0", Offset = "0x213F6F0", VA = "0x182140CF0")]
	public void KNFNNCLLICE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x2140FE0", Offset = "0x213F9E0", VA = "0x182140FE0")]
	private static string? NPOFEBMAMMB([In] CGCJNDNEDNJ MPPBMOONIJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x2141420", Offset = "0x213FE20", VA = "0x182141420")]
	public GKFFMDBINFI()
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
