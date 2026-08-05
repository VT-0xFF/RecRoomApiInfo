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
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x207C830", Offset = "0x207AE30", VA = "0x18207C830")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B0AE0", Offset = "0x8AF0E0", VA = "0x1808B0AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B0B20", Offset = "0x8AF120", VA = "0x1808B0B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x206F140", Offset = "0x206D740", VA = "0x18206F140", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x206F290", Offset = "0x206D890", VA = "0x18206F290", Slot = "13")]
		public virtual void IBEDCEFHOBK(PLLOHOJACCG PFCDDIODGEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x206F2D0", Offset = "0x206D8D0", VA = "0x18206F2D0", Slot = "14")]
		public virtual void NODKBPMCPAF(PLLOHOJACCG PFCDDIODGEJ, EHDCBMKEILE PMCMEAHOBEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2065E30", Offset = "0x2064430", VA = "0x182065E30")]
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
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		private PPLMCELFGHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x116ADE0", Offset = "0x11693E0", VA = "0x18116ADE0", Slot = "4")]
		public MFOMNBGIJJE MJPAOJNCCOI(EHDCBMKEILE BJNJBGHPMEH)
		{
			return default(MFOMNBGIJJE);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2080D40", Offset = "0x207F340", VA = "0x182080D40", Slot = "5")]
		public void IBEDCEFHOBK(PLLOHOJACCG JPBBEMPIGCM, EHDCBMKEILE PMCMEAHOBEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2080E50", Offset = "0x207F450", VA = "0x182080E50", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x207F250", Offset = "0x207D850", VA = "0x18207F250")]
		internal PLIJHIBCDME(NLEPKENBEGE<MFOMNBGIJJE, EHDCBMKEILE, PLLOHOJACCG, KOAFOGCPACB.IIALHHDPMEC<MFOMNBGIJJE, EHDCBMKEILE, PLLOHOJACCG>> BDPEMHOFOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x207F200", Offset = "0x207D800", VA = "0x18207F200")]
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
			[Cpp2IlInjected.Address(RVA = "0x20644E0", Offset = "0x2062AE0", VA = "0x1820644E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x20646C0", Offset = "0x2062CC0", VA = "0x1820646C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA49F10", Offset = "0xA48510", VA = "0x180A49F10", Slot = "4")]
		public MJGAEDNBJIL<DGAGHFGMOJF> BFBMLNJPCMD(PLLOHOJACCG PHPEHEJEKBD)
		{
			return default(MJGAEDNBJIL<DGAGHFGMOJF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2065400", Offset = "0x2063A00", VA = "0x182065400", Slot = "5")]
		[AsyncStateMachine(typeof(AFOHIMCCLHM))]
		public Task<BCLNLKLFCPB<object, OBJIPJOMIPB>> IHEJBKOPHKO(PLLOHOJACCG PHPEHEJEKBD, EHDCBMKEILE PMCMEAHOBEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x20653E0", Offset = "0x20639E0", VA = "0x1820653E0", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x206F8C0", Offset = "0x206DEC0", VA = "0x18206F8C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x206FB40", Offset = "0x206E140", VA = "0x18206FB40", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x206C210", Offset = "0x206A810", VA = "0x18206C210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x206C4A0", Offset = "0x206AAA0", VA = "0x18206C4A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2064F50", Offset = "0x2063550", VA = "0x182064F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2065130", Offset = "0x2063730", VA = "0x182065130", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2065B50", Offset = "0x2064150", VA = "0x182065B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2065D40", Offset = "0x2064340", VA = "0x182065D40", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x206D9D0", Offset = "0x206BFD0", VA = "0x18206D9D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x206E1C0", Offset = "0x206C7C0", VA = "0x18206E1C0", Slot = "5")]
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

	[Cpp2IlInjected.FieldOffset(Offset = "0x1900")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly NBIGEKGGIIN CNJJPMICPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1908")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly JKIEPPIEFOF.OJMGCGLDOGB ABNMOKCCCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1928")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly DGDFFMBNFNB MGGGNDNDDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1930")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly IIHNNAADMDI OILPFNADDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1938")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly ADNIMPJIPFG CMGFIPLKHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1940")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly ABHABACPDFJ KIMNJDKCFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1948")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EFGKIDLCFBA IFDMALMDFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1958")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private EEAOBHNHAIM NEFKPAGNJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1978")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly LJLLJGHEMHE.HDAOBPPIKJL OJFNEFONAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1980")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly PIPALGAAPKG BCPOBGJLMOO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public LJLLJGHEMHE GBCNBFOFNDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x207F7C0", Offset = "0x207DDC0", VA = "0x18207F7C0")]
		get
		{
			return default(LJLLJGHEMHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal KNELNOGLGKD DMLMFAPENCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x207F260", Offset = "0x207D860", VA = "0x18207F260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal OJBFNKHJHCH GDJNODCIJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2080400", Offset = "0x207EA00", VA = "0x182080400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2080410", Offset = "0x207EA10", VA = "0x182080410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool HHIAIJOFCNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x207F2B0", Offset = "0x207D8B0", VA = "0x18207F2B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x207FC10", Offset = "0x207E210", VA = "0x18207FC10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public JMBJIHIFOEL CBAKPOBFHNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2080A50", Offset = "0x207F050", VA = "0x182080A50", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public PLDGKJKJCEC LCJEKJKHDLG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2080A60", Offset = "0x207F060", VA = "0x182080A60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public BJFBDBECAIA NMJBIKBNKMG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2080A80", Offset = "0x207F080", VA = "0x182080A80", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public GGMNELLKHNA MHOOAKGIGGE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2080A70", Offset = "0x207F070", VA = "0x182080A70", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public JKIEPPIEFOF? MMFCBCMFCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x207F9C0", Offset = "0x207DFC0", VA = "0x18207F9C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private HBLCNEAHKAK? BAGDLOECDBO
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x20802D0", Offset = "0x207E8D0", VA = "0x1820802D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2080750", Offset = "0x207ED50", VA = "0x182080750")]
	private PLLOHOJACCG(NBIGEKGGIIN JANHEKCDHCN, MJGAEDNBJIL<DGAGHFGMOJF> GPABCNEPJFA, [In] DEHNGPNNFGA FDLPDEBGHNI, [In] LJLLJGHEMHE JOPCNIPBKEB, [In] CIGMMIPGINP JPMBCNNCLID, OJBFNKHJHCH IJIOOJOJNKF, [In] JKIEPPIEFOF.OJMGCGLDOGB BNJMLECIFEF, LJLLJGHEMHE.HDAOBPPIKJL OKNKPLFKPIN, PIPALGAAPKG BNHGPCJAJHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x207FC20", Offset = "0x207E220", VA = "0x18207FC20")]
	public static PLLOHOJACCG GGBAHLJJLHO(NBIGEKGGIIN LAKCFHGOLJA, [In] BOINMCIHAAD NMOECFNPPHJ, OOHDFMGLDIM CHPHADCPDAG, [In] NECIBONMLNB IAMIHFLPIMK, CLPHICCIMEB NNPFNOHKMEF, MJGAEDNBJIL<DGAGHFGMOJF> GPABCNEPJFA, MJGAEDNBJIL<HEPDKFCJLKH> MHELALCCLJM, HINPPEJFHLF NIHEKDKBACI, FMIDKBNAEHK OMOEJECMNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x207FD60", Offset = "0x207E360", VA = "0x18207FD60")]
	public static PLLOHOJACCG GGBAHLJJLHO(NBIGEKGGIIN JANHEKCDHCN, [In] LJLLJGHEMHE JOPCNIPBKEB, [In] CIGMMIPGINP JPMBCNNCLID, MJGAEDNBJIL<DGAGHFGMOJF> GPABCNEPJFA, MJGAEDNBJIL<HEPDKFCJLKH> MHELALCCLJM, HINPPEJFHLF NIHEKDKBACI, FMIDKBNAEHK OMOEJECMNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x207F7D0", Offset = "0x207DDD0", VA = "0x18207F7D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x207FAB0", Offset = "0x207E0B0", VA = "0x18207FAB0")]
	[AsyncStateMachine(typeof(LKJDGPPOELK))]
	internal Task<BCLNLKLFCPB<bool, OBJIPJOMIPB>> FNHGHMJDOFH(FMGJMILCPFK NCIIFBLDHLJ, FAOKMGJAJIO BDKIHOIIFHL, PIKJJPNAMNM FFHNFKPFGJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2080430", Offset = "0x207EA30", VA = "0x182080430")]
	[AsyncStateMachine(typeof(HCPBFOHBKPB))]
	public Task<BCLNLKLFCPB<bool, OBJIPJOMIPB>> KFIFOIOEHDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x207F6D0", Offset = "0x207DCD0", VA = "0x18207F6D0")]
	[AsyncStateMachine(typeof(BOHEJEHIIDC))]
	public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> BKHFCMDKGKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2080040", Offset = "0x207E640", VA = "0x182080040")]
	internal void HABNGPOBEEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x207F650", Offset = "0x207DC50", VA = "0x18207F650")]
	internal OLCEOJBLPLC<EHDCBMKEILE> BHJGLNBIBBA([In] BDIKLFAAIFG KPPPAGPJGGA)
	{
		return default(OLCEOJBLPLC<EHDCBMKEILE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x207FA40", Offset = "0x207E040", VA = "0x18207FA40")]
	internal bool EONMCCAFAML([In] BDIKLFAAIFG KPPPAGPJGGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2080250", Offset = "0x207E850", VA = "0x182080250")]
	internal OLCEOJBLPLC<EHDCBMKEILE> ICJDKCGJOLJ([In] HKAMLFAFHNK PEEFFJOFPCJ)
	{
		return default(OLCEOJBLPLC<EHDCBMKEILE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2080640", Offset = "0x207EC40", VA = "0x182080640")]
	[AsyncStateMachine(typeof(CPIALKKNGJM))]
	internal Task<BCLNLKLFCPB<object, OBJIPJOMIPB>> PHGGAMCCKKH(EHDCBMKEILE PMCMEAHOBEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x207F2C0", Offset = "0x207D8C0", VA = "0x18207F2C0")]
	private EHDCBMKEILE[] BGMEACEJGHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2080520", Offset = "0x207EB20", VA = "0x182080520")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D9C400", Offset = "0x2D9AA00", VA = "0x182D9C400")]
	public static GLICBOJFAKM<(TPrev?, PLLOHOJACCG?), HBLCNEAHKAK> GKGFFNFMONJ<TPrev>([In] this GLICBOJFAKM<TPrev, PLLOHOJACCG> BJNJBGHPMEH)
	{
		return default(GLICBOJFAKM<(TPrev, PLLOHOJACCG), HBLCNEAHKAK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C6C0", Offset = "0x2D9ACC0", VA = "0x182D9C6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x22A7940", Offset = "0x22A5F40", VA = "0x1822A7940", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x887AA0", Offset = "0x8860A0", VA = "0x180887AA0", Slot = "7")]
	public override string CKGPGAAGKNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x41AB4B0", Offset = "0x41A9AB0", VA = "0x1841AB4B0")]
	internal JEMOIKINEFJ([In] JEBPJLMNFAK<BKFIMEBJLKC>? FNFEIMODNLO, MJGAEDNBJIL<NPLAKCHMMBM>? JENGBDMODPI, IOKind? GIOKLABBDJF, string KFAOBDLOMDC, [In] TData JGCMECODHDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class FCNFMGJOLHA
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2068190", Offset = "0x2066790", VA = "0x182068190")]
	public static BCLNLKLFCPB<CCCFAJBJNHG, PKDABJNIHNM> DCGLEIDECBF([In] this PAOMBAGNFAO<MNMGNCAOGNK> LDDMLNHIBOM)
	{
		return default(BCLNLKLFCPB<CCCFAJBJNHG, PKDABJNIHNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2C96A90", Offset = "0x2C95090", VA = "0x182C96A90")]
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
	[Cpp2IlInjected.Address(RVA = "0x206E900", Offset = "0x206CF00", VA = "0x18206E900")]
	public static EHDCBMKEILE AOGGABFCACL(this EHDCBMKEILE BJNJBGHPMEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x206EA10", Offset = "0x206D010", VA = "0x18206EA10")]
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
		[Cpp2IlInjected.Address(RVA = "0x206C580", Offset = "0x206AB80", VA = "0x18206C580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x206C840", Offset = "0x206AE40", VA = "0x18206C840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly ByteString PGPGCBGPPOH;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xAB30F0", Offset = "0xAB16F0", VA = "0x180AB30F0")]
	private HAIIPIALEGN(ByteString KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x206C040", Offset = "0x206A640", VA = "0x18206C040")]
	public static EHDCBMKEILE DNLPJDJPDOP(ByteString KLABJGGMBGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x206BF90", Offset = "0x206A590", VA = "0x18206BF90")]
	public static NEEHLPPFFPM<MFOMNBGIJJE, HAIIPIALEGN> DKCHBGFLGBC(EHDCBMKEILE FFNCNBIFMAD)
	{
		return default(NEEHLPPFFPM<MFOMNBGIJJE, HAIIPIALEGN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x206C100", Offset = "0x206A700", VA = "0x18206C100")]
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
	[Cpp2IlInjected.Address(RVA = "0x206F020", Offset = "0x206D620", VA = "0x18206F020")]
	public static EHDCBMKEILE DNLPJDJPDOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x206EFB0", Offset = "0x206D5B0", VA = "0x18206EFB0")]
	public static NEEHLPPFFPM<MFOMNBGIJJE, KDEOHMFLNMO> DKCHBGFLGBC(EHDCBMKEILE FFNCNBIFMAD)
	{
		return default(NEEHLPPFFPM<MFOMNBGIJJE, KDEOHMFLNMO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x206F0C0", Offset = "0x206D6C0", VA = "0x18206F0C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2064100", Offset = "0x2062700", VA = "0x182064100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2064470", Offset = "0x2062A70", VA = "0x182064470", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x1F9E640", Offset = "0x1F9CC40", VA = "0x181F9E640")]
	private IJDKDPLBMHO(FMGJMILCPFK? NCIIFBLDHLJ, FAOKMGJAJIO? BDKIHOIIFHL, PIKJJPNAMNM? FFHNFKPFGJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x206D790", Offset = "0x206BD90", VA = "0x18206D790")]
	public static EHDCBMKEILE? DNLPJDJPDOP(FMGJMILCPFK? NCIIFBLDHLJ, FAOKMGJAJIO? BDKIHOIIFHL, PIKJJPNAMNM? FFHNFKPFGJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x206D680", Offset = "0x206BC80", VA = "0x18206D680")]
	public static NEEHLPPFFPM<MFOMNBGIJJE, IJDKDPLBMHO> DKCHBGFLGBC(EHDCBMKEILE FFNCNBIFMAD)
	{
		return default(NEEHLPPFFPM<MFOMNBGIJJE, IJDKDPLBMHO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x206D890", Offset = "0x206BE90", VA = "0x18206D890")]
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
		[Cpp2IlInjected.Address(RVA = "0x2065670", Offset = "0x2063C70", VA = "0x182065670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2065AE0", Offset = "0x20640E0", VA = "0x182065AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IReadOnlyList<EHDCBMKEILE> CDPJBFFIECG;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xAB30F0", Offset = "0xAB16F0", VA = "0x180AB30F0")]
	private PFPALPEDNCD(IReadOnlyList<EHDCBMKEILE> EENNPJMHNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x207DF30", Offset = "0x207C530", VA = "0x18207DF30")]
	public static EHDCBMKEILE DNLPJDJPDOP(IReadOnlyList<EHDCBMKEILE> EENNPJMHNKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x207DE90", Offset = "0x207C490", VA = "0x18207DE90")]
	public static NEEHLPPFFPM<MFOMNBGIJJE, PFPALPEDNCD> DKCHBGFLGBC(EHDCBMKEILE FFNCNBIFMAD)
	{
		return default(NEEHLPPFFPM<MFOMNBGIJJE, PFPALPEDNCD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x207DFF0", Offset = "0x207C5F0", VA = "0x18207DFF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1D157A0", Offset = "0x1D13DA0", VA = "0x181D157A0")]
	private HKAMLFAFHNK(int FIGHABPEBPG, int HGFDMIDEFHN, byte[] JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x206C990", Offset = "0x206AF90", VA = "0x18206C990")]
	public static EHDCBMKEILE DNLPJDJPDOP(int FIGHABPEBPG, int HGFDMIDEFHN, ByteString JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x206CA70", Offset = "0x206B070", VA = "0x18206CA70")]
	public static EHDCBMKEILE[] NJPEDGJMABI(EHDCBMKEILE PMCMEAHOBEF, int CPBJHCINKCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x206C8B0", Offset = "0x206AEB0", VA = "0x18206C8B0")]
	public static NEEHLPPFFPM<MFOMNBGIJJE, HKAMLFAFHNK> DKCHBGFLGBC(EHDCBMKEILE FFNCNBIFMAD)
	{
		return default(NEEHLPPFFPM<MFOMNBGIJJE, HKAMLFAFHNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x206CBA0", Offset = "0x206B1A0", VA = "0x18206CBA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x207C8B0", Offset = "0x207AEB0", VA = "0x18207C8B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x207CEF0", Offset = "0x207B4F0", VA = "0x18207CEF0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x1D157A0", Offset = "0x1D13DA0", VA = "0x181D157A0")]
	private BDIKLFAAIFG(int FIGHABPEBPG, int HGFDMIDEFHN, byte[] JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2064B80", Offset = "0x2063180", VA = "0x182064B80")]
	public static EHDCBMKEILE DNLPJDJPDOP(int FIGHABPEBPG, int HGFDMIDEFHN, ByteString JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x20648B0", Offset = "0x2062EB0", VA = "0x1820648B0")]
	public static EHDCBMKEILE?[]? CANCDMOHPAO(int CPBJHCINKCL, FMGJMILCPFK? NCIIFBLDHLJ, FAOKMGJAJIO? BDKIHOIIFHL, PIKJJPNAMNM? FFHNFKPFGJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2064AA0", Offset = "0x20630A0", VA = "0x182064AA0")]
	public static NEEHLPPFFPM<MFOMNBGIJJE, BDIKLFAAIFG> DKCHBGFLGBC(EHDCBMKEILE FFNCNBIFMAD)
	{
		return default(NEEHLPPFFPM<MFOMNBGIJJE, BDIKLFAAIFG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2064C60", Offset = "0x2063260", VA = "0x182064C60")]
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
		[Cpp2IlInjected.Address(RVA = "0x2065E40", Offset = "0x2064440", VA = "0x182065E40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8842A0", Offset = "0x8828A0", VA = "0x1808842A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x88AB80", Offset = "0x889180", VA = "0x18088AB80")]
	public IGGPNOLOJEI(PLLOHOJACCG PFCDDIODGEJ, HDGDOAHDBCE HNFHGIGGGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x206D130", Offset = "0x206B730", VA = "0x18206D130", Slot = "4")]
	public BCLNLKLFCPB<CCCFAJBJNHG, PKDABJNIHNM> PDMIMNBHLOC(JEBPJLMNFAK<BKFIMEBJLKC> JJLNKABMPOP, MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, MJGAEDNBJIL<EMOBFLMBFFJ> JJHCIBLPKAD)
	{
		return default(BCLNLKLFCPB<CCCFAJBJNHG, PKDABJNIHNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x206CE50", Offset = "0x206B450", VA = "0x18206CE50", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x20651A0", Offset = "0x20637A0", VA = "0x1820651A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x2065370", Offset = "0x2063970", VA = "0x182065370", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly JFBHMLEECGC DFEEMNKDOMA;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		private JFBHMLEECGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x206E230", Offset = "0x206C830", VA = "0x18206E230", Slot = "4")]
		[AsyncStateMachine(typeof(CADFIBIPBGA))]
		public Task<HDGDOAHDBCE> BFHJHPEEPNN(PLLOHOJACCG PFCDDIODGEJ, FAOKMGJAJIO? JMMMBDHOMCD, PIKJJPNAMNM? AFHCBPGJMBO, CancellationToken IONNNJNKLMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x206E390", Offset = "0x206C990", VA = "0x18206E390", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x206F350", Offset = "0x206D950", VA = "0x18206F350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x206F850", Offset = "0x206DE50", VA = "0x18206F850", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x20688D0", Offset = "0x2066ED0", VA = "0x1820688D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public HBLCNEAHKAK EDONFKNGOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2068920", Offset = "0x2066F20", VA = "0x182068920", Slot = "5")]
		get
		{
			return default(HBLCNEAHKAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IGGPNOLOJEI JEAJINKEGCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x886FC0", Offset = "0x8855C0", VA = "0x180886FC0", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8860F0", VA = "0x180887AF0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x965100", Offset = "0x963700", VA = "0x180965100")]
	private FIPHNEFFDCE(HDGDOAHDBCE HNFHGIGGGHI, HBPBPJMDAIL GLCGEFKKFIJ, IGGPNOLOJEI GELJLMKDHAA, MJECCAEPCJM DJEDPBAIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2068700", Offset = "0x2066D00", VA = "0x182068700")]
	[AsyncStateMachine(typeof(LBDMNCGEOOM))]
	public static Task<FIPHNEFFDCE> BHOHJJOHHJH(PLLOHOJACCG PFCDDIODGEJ, FMGJMILCPFK LACCAKBFKMJ, FAOKMGJAJIO? JMMMBDHOMCD, PIKJJPNAMNM? AFHCBPGJMBO, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2068870", Offset = "0x2066E70", VA = "0x182068870", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x2071030", Offset = "0x206F630", VA = "0x182071030", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x2071370", Offset = "0x206F970", VA = "0x182071370", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x2064D90", Offset = "0x2063390", VA = "0x182064D90", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x206D410", Offset = "0x206BA10", VA = "0x18206D410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x206D610", Offset = "0x206BC10", VA = "0x18206D610", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x207EC70", Offset = "0x207D270", VA = "0x18207EC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x207F1A0", Offset = "0x207D7A0", VA = "0x18207F1A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xB77770", Offset = "0xB75D70", VA = "0x180B77770", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xC6AF80", Offset = "0xC69580", VA = "0x180C6AF80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool CMFCJHGPMDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xC6AF90", Offset = "0xC69590", VA = "0x180C6AF90", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xC6AF70", Offset = "0xC69570", VA = "0x180C6AF70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool NDECOHMCNFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x12819F0", Offset = "0x127FFF0", VA = "0x1812819F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x206E510", Offset = "0x206CB10", VA = "0x18206E510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public KODBJLILNLE? PAJJJJDAAAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8879F0", Offset = "0x885FF0", VA = "0x1808879F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x887AB0", Offset = "0x8860B0", VA = "0x180887AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x206E420", Offset = "0x206CA20", VA = "0x18206E420", Slot = "7")]
	[AsyncStateMachine(typeof(IGMODBNHHGO))]
	public Task<KODBJLILNLE> AKPOHNLBLOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x206E7F0", Offset = "0x206CDF0", VA = "0x18206E7F0")]
	public JHLIMPAJNBN(EJAJLDBKNGE LAKCFHGOLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x206E690", Offset = "0x206CC90", VA = "0x18206E690", Slot = "8")]
	[AsyncStateMachine(typeof(PKOKFDEMGCB))]
	public Task OACPNMOABHH(PLLOHOJACCG PFCDDIODGEJ, FMGJMILCPFK LACCAKBFKMJ, FAOKMGJAJIO? JMMMBDHOMCD, PIKJJPNAMNM? AFHCBPGJMBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x206E520", Offset = "0x206CB20", VA = "0x18206E520", Slot = "9")]
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
	[Cpp2IlInjected.Address(RVA = "0x8842A0", Offset = "0x8828A0", VA = "0x1808842A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x10BC1D0", Offset = "0x10BA7D0", VA = "0x1810BC1D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public MJGAEDNBJIL<IKLMIGOGHKN> EPGBOEDHPEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x49062C0", Offset = "0x49048C0", VA = "0x1849062C0", Slot = "5")]
			get
			{
				return default(MJGAEDNBJIL<IKLMIGOGHKN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public MJGAEDNBJIL<IKLMIGOGHKN>? HHBOEOJMHKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x4906240", Offset = "0x4904840", VA = "0x184906240", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8842A0", Offset = "0x8828A0", VA = "0x1808842A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2067DF0", Offset = "0x20663F0", VA = "0x182067DF0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2067E10", Offset = "0x2066410", VA = "0x182067E10")]
		public DOCJJPPDOKD(GOBCEFHNOAK DHGOHNADGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x206CCC0", Offset = "0x206B2C0", VA = "0x18206CCC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2080FD0", Offset = "0x207F5D0", VA = "0x182080FD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x2081240", Offset = "0x207F840", VA = "0x182081240", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public EJHCOALFJFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x20680A0", Offset = "0x20666A0", VA = "0x1820680A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x207D920", Offset = "0x207BF20", VA = "0x18207D920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x207DE30", Offset = "0x207C430", VA = "0x18207DE30", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x20812A0", Offset = "0x207F8A0", VA = "0x1820812A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x2081580", Offset = "0x207FB80", VA = "0x182081580", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public FGIMGIGOKBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2068630", Offset = "0x2066C30", VA = "0x182068630")]
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
		[Cpp2IlInjected.Address(RVA = "0x2069530", Offset = "0x2067B30", VA = "0x182069530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public MJGAEDNBJIL<EMOBFLMBFFJ> CJDCICKDECL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x92CD40", Offset = "0x92B340", VA = "0x18092CD40", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(MJGAEDNBJIL<EMOBFLMBFFJ>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x92DC00", Offset = "0x92C200", VA = "0x18092DC00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private MJGAEDNBJIL<DDABHKCABNE> DPINEOKAPPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xC65240", Offset = "0xC63840", VA = "0x180C65240")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public MJGAEDNBJIL<OIEHBMHNIBK> CADNKCDGPNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8AD000", Offset = "0x8AB600", VA = "0x1808AD000", Slot = "25")]
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
		[Cpp2IlInjected.Address(RVA = "0x2069A80", Offset = "0x2068080", VA = "0x182069A80", Slot = "20")]
		get
		{
			return default(MJGAEDNBJIL<NPLAKCHMMBM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool PFECDKHBHAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x206B7D0", Offset = "0x2069DD0", VA = "0x18206B7D0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x206BD70", Offset = "0x206A370", VA = "0x18206BD70")]
	private GIIGAKOBIAH(PLLOHOJACCG PFCDDIODGEJ, DPIPCKFLLFL KOHLOCENPAH, PJDJGGGLFDB OAMFPCMHDBI, MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, MJGAEDNBJIL<EMOBFLMBFFJ> JJHCIBLPKAD, MJGAEDNBJIL<DDABHKCABNE> IINCKHAMMKN, bool BNKGOGLKMMD, string KJPHMNNIMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2069E50", Offset = "0x2068450", VA = "0x182069E50")]
	public static GIIGAKOBIAH GGBAHLJJLHO(PLLOHOJACCG PFCDDIODGEJ, DPIPCKFLLFL KOHLOCENPAH, PJDJGGGLFDB DIGEGMNKCOG, MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, MJGAEDNBJIL<DDABHKCABNE> IINCKHAMMKN, MJGAEDNBJIL<EMOBFLMBFFJ> JJHCIBLPKAD, bool BNKGOGLKMMD, bool DILHCPAOMOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2069550", Offset = "0x2067B50", VA = "0x182069550", Slot = "21")]
	protected override void AIFHKOLJDOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2069850", Offset = "0x2067E50", VA = "0x182069850", Slot = "22")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x206B000", Offset = "0x2069600", VA = "0x18206B000", Slot = "30")]
	public void JDOCEKOHJBL(PKAHBMNHOEG MILPJICLPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x206B310", Offset = "0x2069910", VA = "0x18206B310", Slot = "27")]
	public void KFLIDABADGF(AMHGKMCFGFA OJEDFAEEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x206A200", Offset = "0x2068800", VA = "0x18206A200", Slot = "28")]
	public void GLFGCPILFDC(OGLJFIOCJDF LCJOKKCJGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x20695F0", Offset = "0x2067BF0", VA = "0x1820695F0", Slot = "23")]
	protected override void BPECPKLMPPL(APDFNBBFBPM AILIAJMFOGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x206B850", Offset = "0x2069E50", VA = "0x18206B850", Slot = "32")]
	public string MIENJCPLNMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2069B90", Offset = "0x2068190", VA = "0x182069B90", Slot = "29")]
	public string GELAIPKAJHD(int DOBHOIOIHAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x206B060", Offset = "0x2069660", VA = "0x18206B060")]
	private void JPJFJPFEIFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x206BA90", Offset = "0x206A090", VA = "0x18206BA90", Slot = "31")]
	public void NPHJLHNIDPP(PKAHBMNHOEG MILPJICLPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x206ADF0", Offset = "0x20693F0", VA = "0x18206ADF0")]
	private void IKJPFFABHKG(bool KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2069740", Offset = "0x2067D40", VA = "0x182069740", Slot = "33")]
	[AsyncStateMachine(typeof(PDHIPGMGPIH))]
	public Task CDCIIEGOPCD(string KLABJGGMBGH, bool PFBJCIMBEON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x206BB60", Offset = "0x206A160", VA = "0x18206BB60")]
	public void NPJLCJHIGND(string KLABJGGMBGH, bool PFBJCIMBEON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x206AC50", Offset = "0x2069250", VA = "0x18206AC50")]
	private void IKCNPPFEELK(int KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x92DC00", Offset = "0x92C200", VA = "0x18092DC00")]
	internal void GBMAKPFOJEG(MJGAEDNBJIL<EMOBFLMBFFJ> KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x206ABA0", Offset = "0x20691A0", VA = "0x18206ABA0")]
	[CompilerGenerated]
	private void HBGBFMCCLKA(string KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2069AD0", Offset = "0x20680D0", VA = "0x182069AD0")]
	[CompilerGenerated]
	private bool FNPHGLLPOCJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x206BCB0", Offset = "0x206A2B0", VA = "0x18206BCB0")]
	[CompilerGenerated]
	private bool PIGJHGHEEEK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x206AFB0", Offset = "0x20695B0", VA = "0x18206AFB0")]
	[CompilerGenerated]
	private int NOLFMKKIBAC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x206B9B0", Offset = "0x2069FB0", VA = "0x18206B9B0")]
	[CompilerGenerated]
	private bool NEMPBIDEGMA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x206ABB0", Offset = "0x20691B0", VA = "0x18206ABB0")]
	[CompilerGenerated]
	private void HFKNBGLBMPD(string KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x20699C0", Offset = "0x2067FC0", VA = "0x1820699C0")]
	[CompilerGenerated]
	private bool ENADOLOIIAE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x206BA40", Offset = "0x206A040", VA = "0x18206BA40")]
	[CompilerGenerated]
	private bool NJIKKHPCIAL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x206ABC0", Offset = "0x20691C0", VA = "0x18206ABC0")]
	[CompilerGenerated]
	private bool IGIEPPNCGID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x206AFB0", Offset = "0x20695B0", VA = "0x18206AFB0")]
	[CompilerGenerated]
	private int IOKLDJFFPCJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x206B700", Offset = "0x2069D00", VA = "0x18206B700")]
	[CompilerGenerated]
	private bool LHLOKMINEFM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x206B680", Offset = "0x2069C80", VA = "0x18206B680")]
	[CompilerGenerated]
	private object KLBCFBNMCHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x206B290", Offset = "0x2069890", VA = "0x18206B290")]
	[CompilerGenerated]
	private void KBMMIKKGDGM(object KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x20698F0", Offset = "0x2067EF0", VA = "0x1820698F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x91FD90", Offset = "0x91E390", VA = "0x18091FD90", Slot = "126")]
			get
			{
				return default(KALNDDFHJJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2064850", Offset = "0x2062E50", VA = "0x182064850")]
		public BBAEMANAPHD(PLLOHOJACCG PFCDDIODGEJ, DKLOONAJCHI BDPEMHOFOHC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class NDGPLCKEABD : OCLPOHGKJMO<ELEFNGFOLBA>
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x207C7C0", Offset = "0x207ADC0", VA = "0x18207C7C0")]
		public NDGPLCKEABD(PLLOHOJACCG PFCDDIODGEJ, ELEFNGFOLBA KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x207C520", Offset = "0x207AB20", VA = "0x18207C520", Slot = "120")]
		protected override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x207C4D0", Offset = "0x207AAD0", VA = "0x18207C4D0")]
		[CompilerGenerated]
		private bool JDDFFGJAECP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x207C6A0", Offset = "0x207ACA0", VA = "0x18207C6A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public PAOPKEPJPNP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x207D830", Offset = "0x207BE30", VA = "0x18207D830")]
			internal void JDPFBIGGGNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x207D880", Offset = "0x207BE80", VA = "0x18207D880")]
			internal bool MDAPEAKELDK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x207D8D0", Offset = "0x207BED0", VA = "0x18207D8D0")]
			internal bool NLOAMKMODOM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x207D710", Offset = "0x207BD10", VA = "0x18207D710")]
			internal void IIBCAKFOPMO(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x207D6C0", Offset = "0x207BCC0", VA = "0x18207D6C0")]
			internal bool IACLJHOBOIL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x207C460", Offset = "0x207AA60", VA = "0x18207C460")]
		public MNOMNHPEAJP(PLLOHOJACCG PFCDDIODGEJ, KNMMGHACGEJ KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x207C130", Offset = "0x207A730", VA = "0x18207C130", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public PANFJOFKMGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x207D210", Offset = "0x207B810", VA = "0x18207D210")]
			internal object JDPFBIGGGNI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x207D0D0", Offset = "0x207B6D0", VA = "0x18207D0D0")]
			internal bool FICJGAHFHBG(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x207D310", Offset = "0x207B910", VA = "0x18207D310")]
			internal void MDAPEAKELDK(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x207D560", Offset = "0x207BB60", VA = "0x18207D560")]
			internal string NLOAMKMODOM(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x207D1C0", Offset = "0x207B7C0", VA = "0x18207D1C0")]
			internal IReadOnlyList<object> IIBCAKFOPMO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x207D150", Offset = "0x207B750", VA = "0x18207D150")]
			internal bool IACLJHOBOIL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x207CF60", Offset = "0x207B560", VA = "0x18207CF60")]
			internal bool AADPJDPABMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x207CFB0", Offset = "0x207B5B0", VA = "0x18207CFB0")]
			internal void BDPDDNLEAGC(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x20694C0", Offset = "0x2067AC0", VA = "0x1820694C0")]
		public GHGCCFDJIGB(PLLOHOJACCG PFCDDIODGEJ, LMOBKAJAOII KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2068D60", Offset = "0x2067360", VA = "0x182068D60", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public EFNCOCALLAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x2067EE0", Offset = "0x20664E0", VA = "0x182067EE0")]
			internal bool JDPFBIGGGNI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x2067F30", Offset = "0x2066530", VA = "0x182067F30")]
			internal void MDAPEAKELDK(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x2068050", Offset = "0x2066650", VA = "0x182068050")]
			internal bool NLOAMKMODOM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x206ED10", Offset = "0x206D310", VA = "0x18206ED10")]
		public KACENACDLCL(PLLOHOJACCG PFCDDIODGEJ, OGPPHLBEOGO KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x206EAE0", Offset = "0x206D0E0", VA = "0x18206EAE0", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D40890", Offset = "0x3D3EE90", VA = "0x183D40890", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x3D40C90", Offset = "0x3D3F290", VA = "0x183D40C90", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x434ABF0", Offset = "0x43491F0", VA = "0x18434ABF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x434AFF0", Offset = "0x43495F0", VA = "0x18434AFF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public sealed override bool EIDDJGDEAPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override MJGAEDNBJIL<LPDNCAKIDEG>? NCAMHCONKDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x4723180", Offset = "0x4721780", VA = "0x184723180", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x447D570", Offset = "0x447BB70", VA = "0x18447D570")]
		protected NICBEFPGHCP(PLLOHOJACCG PFCDDIODGEJ, TNode KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4723060", Offset = "0x4721660", VA = "0x184723060", Slot = "100")]
		[AsyncStateMachine(typeof(NICBEFPGHCP<>.FPALOBGDLBA))]
		public override Task<BCLNLKLFCPB<MJGAEDNBJIL<LPDNCAKIDEG>, OBJIPJOMIPB>> IGIMMPPOEKP(string KJPHMNNIMDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4722FC0", Offset = "0x47215C0", VA = "0x184722FC0", Slot = "124")]
		public sealed override bool IBLEHLFAKBM(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4722F20", Offset = "0x4721520", VA = "0x184722F20", Slot = "112")]
		protected sealed override bool GIBGGBJCBHD(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4722D70", Offset = "0x4721370", VA = "0x184722D70", Slot = "113")]
		protected override bool EPKFMDJOHBB(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4722E10", Offset = "0x4721410", VA = "0x184722E10", Slot = "101")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public CNJAJAOGCHB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x20655F0", Offset = "0x2063BF0", VA = "0x1820655F0")]
			internal bool MJDFMONDNHO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x2065530", Offset = "0x2063B30", VA = "0x182065530")]
			internal void AJMOMHLBAIF(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2080CE0", Offset = "0x207F2E0", VA = "0x182080CE0")]
		public PNMDNBPEIPI(PLLOHOJACCG PFCDDIODGEJ, GDLJAJCBCOA BDPEMHOFOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2080A90", Offset = "0x207F090", VA = "0x182080A90", Slot = "126")]
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
			[Cpp2IlInjected.Address(RVA = "0x8FB3E0", Offset = "0x8F99E0", VA = "0x1808FB3E0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2064EF0", Offset = "0x20634F0", VA = "0x182064EF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DFB680", Offset = "0x3DF9C80", VA = "0x183DFB680", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x3DFBB40", Offset = "0x3DFA140", VA = "0x183DFBB40", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D39C90", Offset = "0x3D38290", VA = "0x183D39C90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x3D3A120", Offset = "0x3D38720", VA = "0x183D3A120", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F25180", Offset = "0x3F23780", VA = "0x183F25180", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x3F25860", Offset = "0x3F23E60", VA = "0x183F25860", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x36996E0", Offset = "0x3697CE0", VA = "0x1836996E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000150")]
				[Cpp2IlInjected.Address(RVA = "0xB9D680", Offset = "0xB9BC80", VA = "0x180B9D680", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public FLLCNKIDIKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x3D35160", Offset = "0x3D33760", VA = "0x183D35160")]
			internal bool BDPDDNLEAGC(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x3D352E0", Offset = "0x3D338E0", VA = "0x183D352E0")]
			internal void JDPFBIGGGNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x3D35240", Offset = "0x3D33840", VA = "0x183D35240")]
			[AsyncStateMachine(typeof(NHHGKDHPBDL<>.FLLCNKIDIKO.<<BuildConfigMenuInternal>b__7>d))]
			internal void FICJGAHFHBG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x3D355D0", Offset = "0x3D33BD0", VA = "0x183D355D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x3699360", Offset = "0x3697960", VA = "0x183699360", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000157")]
				[Cpp2IlInjected.Address(RVA = "0xB9D680", Offset = "0xB9BC80", VA = "0x180B9D680", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public MOLPBJMMBII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x46B8270", Offset = "0x46B6870", VA = "0x1846B8270")]
			internal void NLOAMKMODOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0")]
			internal string IIBCAKFOPMO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x8841C0", Offset = "0x8827C0", VA = "0x1808841C0")]
			internal void IACLJHOBOIL(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x46B81D0", Offset = "0x46B67D0", VA = "0x1846B81D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x3698E90", Offset = "0x3697490", VA = "0x183698E90", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0xB9D680", Offset = "0xB9BC80", VA = "0x180B9D680", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x3699070", Offset = "0x3697670", VA = "0x183699070", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0xB9D680", Offset = "0xB9BC80", VA = "0x180B9D680", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x36987C0", Offset = "0x3696DC0", VA = "0x1836987C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0xB9D680", Offset = "0xB9BC80", VA = "0x180B9D680", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public LAAAANJIGHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x43E2C40", Offset = "0x43E1240", VA = "0x1843E2C40")]
			internal bool DMANPLCPMIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x43E2D80", Offset = "0x43E1380", VA = "0x1843E2D80")]
			internal void HKFNIPBEEBG(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x43E3220", Offset = "0x43E1820", VA = "0x1843E3220")]
			internal bool PFGACIKJBDM(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x43E2E60", Offset = "0x43E1460", VA = "0x1843E2E60")]
			internal bool IHNDMHPBGFH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x43E2EA0", Offset = "0x43E14A0", VA = "0x1843E2EA0")]
			[AsyncStateMachine(typeof(NHHGKDHPBDL<>.LAAAANJIGHN.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void JBGDLDCFDIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x43E3300", Offset = "0x43E1900", VA = "0x1843E3300")]
			internal bool PPBNFDFHDIK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x43E29C0", Offset = "0x43E0FC0", VA = "0x1843E29C0")]
			internal void BECKAPJAKGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x43E30B0", Offset = "0x43E16B0", VA = "0x1843E30B0")]
			internal bool NBIHABDKIFF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x43E3160", Offset = "0x43E1760", VA = "0x1843E3160")]
			internal void OADPHEABPHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x43E2B90", Offset = "0x43E1190", VA = "0x1843E2B90")]
			internal bool DFEPFKOCBLK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x43E2D10", Offset = "0x43E1310", VA = "0x1843E2D10")]
			internal bool GCMOBMHBFNH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x43E2A80", Offset = "0x43E1080", VA = "0x1843E2A80")]
			internal void CFMFCACJICC(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x43E2FA0", Offset = "0x43E15A0", VA = "0x1843E2FA0")]
			[AsyncStateMachine(typeof(NHHGKDHPBDL<>.LAAAANJIGHN.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void MGELAOEOHNE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x43E2F40", Offset = "0x43E1540", VA = "0x1843E2F40")]
			internal bool JLBKIEABNPL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x43E3040", Offset = "0x43E1640", VA = "0x1843E3040")]
			internal bool MLBHKPIPAIN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x43E2DF0", Offset = "0x43E13F0", VA = "0x1843E2DF0")]
			internal void HPNCGMNDMLP(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x43E2AF0", Offset = "0x43E10F0", VA = "0x1843E2AF0")]
			[AsyncStateMachine(typeof(NHHGKDHPBDL<>.LAAAANJIGHN.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void CMNOKILAKJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x43E2CB0", Offset = "0x43E12B0", VA = "0x1843E2CB0")]
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
				[Cpp2IlInjected.Address(RVA = "0x3698AB0", Offset = "0x36970B0", VA = "0x183698AB0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000177")]
				[Cpp2IlInjected.Address(RVA = "0xB9D680", Offset = "0xB9BC80", VA = "0x180B9D680", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public FDKGFHPJIBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x3D07A90", Offset = "0x3D06090", VA = "0x183D07A90")]
			internal void GNKHOOGKAPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0")]
			internal string JHNLMFBOGIB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x8841C0", Offset = "0x8827C0", VA = "0x1808841C0")]
			internal void ODGPDBPGAMI(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x3D079F0", Offset = "0x3D05FF0", VA = "0x183D079F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public AGKICLFNHGJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x3DA8AA0", Offset = "0x3DA70A0", VA = "0x183DA8AA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public OLBLGICMJOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x482BD90", Offset = "0x482A390", VA = "0x18482BD90")]
			internal void FMAAEGPAANN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x482C020", Offset = "0x482A620", VA = "0x18482C020")]
			internal bool PJGIIGIDNEO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x482BF00", Offset = "0x482A500", VA = "0x18482BF00")]
			internal void PEAABIHPJKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x482BEA0", Offset = "0x482A4A0", VA = "0x18482BEA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public NAPGKNEPNHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x46FC980", Offset = "0x46FAF80", VA = "0x1846FC980")]
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
				[Cpp2IlInjected.Address(RVA = "0x369AB50", Offset = "0x3699150", VA = "0x18369AB50", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000188")]
				[Cpp2IlInjected.Address(RVA = "0xB9D680", Offset = "0xB9BC80", VA = "0x180B9D680", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public DKIAPLAAICI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x5A68C10", Offset = "0x5A67210", VA = "0x185A68C10")]
			internal int DNGJMKKFPMG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x5A68C50", Offset = "0x5A67250", VA = "0x185A68C50")]
			internal void DNNHIEDOFMB(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8879F0", Offset = "0x885FF0", VA = "0x1808879F0")]
			internal string JPCMNPBKJOF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x5A68E90", Offset = "0x5A67490", VA = "0x185A68E90")]
			[AsyncStateMachine(typeof(NHHGKDHPBDL<>.DKIAPLAAICI.<<CreatePortItemV2>b__3>d))]
			internal void GCDLNGKFGDN(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x5A68F50", Offset = "0x5A67550", VA = "0x185A68F50")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected virtual bool EIHKDONLGKB
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "126")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected virtual bool ENLBGNHCLIG
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "127")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected virtual bool OFIDGNLADKM
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "128")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override MJGAEDNBJIL<IKLMIGOGHKN>? EIJBGHMALEG
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x4720F60", Offset = "0x471F560", VA = "0x184720F60", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override MJGAEDNBJIL<LPDNCAKIDEG>? NCAMHCONKDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x4721230", Offset = "0x471F830", VA = "0x184721230", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override IEnumerable<JEBPJLMNFAK<BKFIMEBJLKC>>? JKMOEEOGOEK
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x4721020", Offset = "0x471F620", VA = "0x184721020", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x4720D40", Offset = "0x471F340", VA = "0x184720D40")]
		public NHHGKDHPBDL(PLLOHOJACCG PFCDDIODGEJ, TNode KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "129")]
		protected virtual bool LAACEBFPEJA(int DOEPPHBPIJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "130")]
		protected virtual bool MPAKOFICMOM(int DOEPPHBPIJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "131")]
		protected virtual bool LADLGLKECGE(int DOEPPHBPIJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "132")]
		protected virtual void ALIDHEPCNNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x471C940", Offset = "0x471AF40", VA = "0x18471C940", Slot = "124")]
		public override bool IBLEHLFAKBM(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x471C9E0", Offset = "0x471AFE0", VA = "0x18471C9E0", Slot = "100")]
		[AsyncStateMachine(typeof(NHHGKDHPBDL<>.GNICOODNNFJ))]
		public override Task<BCLNLKLFCPB<MJGAEDNBJIL<LPDNCAKIDEG>, OBJIPJOMIPB>> IGIMMPPOEKP(string KJPHMNNIMDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x471C590", Offset = "0x471AB90", VA = "0x18471C590", Slot = "101")]
		[AsyncStateMachine(typeof(NHHGKDHPBDL<>.FNAKMEIOHMP))]
		public override Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> GDGHCBBAPMO(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x471E5C0", Offset = "0x471CBC0", VA = "0x18471E5C0", Slot = "102")]
		public override void LGEOIJJKPID(MJGAEDNBJIL<LPDNCAKIDEG> HGFDMIDEFHN, MJGAEDNBJIL<LPDNCAKIDEG> LLMCGMPLMBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x471E7D0", Offset = "0x471CDD0", VA = "0x18471E7D0", Slot = "103")]
		public override IEnumerable<EHDCBMKEILE> LOGEDGOLNKD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x4720C40", Offset = "0x471F240", VA = "0x184720C40")]
		[AsyncStateMachine(typeof(NHHGKDHPBDL<>.AOLNCPJCBPJ))]
		private Task<BCLNLKLFCPB<LKBKALCJMFG, OBJIPJOMIPB>> OCGCJGFCELF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "133")]
		protected virtual bool NOBGOAPLPHB(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "134")]
		protected virtual bool FNDADCFCGDK(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "135")]
		protected virtual bool AJBHMCBOODG(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "136")]
		protected virtual bool OIDDMFDFCCD(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "137")]
		protected virtual bool HJLDGFMGFJC(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, int ICLJOJMKBJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "138")]
		protected virtual bool FIOBCNDHIAA(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, int ICLJOJMKBJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "139")]
		protected virtual bool EHLMIANPNIA(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, int JIJODOLNGLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "140")]
		protected virtual bool MHJBLHIMMEH(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, int JIJODOLNGLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "141")]
		protected virtual bool MHMMFHFFAJC(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, int DLKOGGNFIGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "142")]
		protected virtual bool GJPBIFFHGEH(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, int POPPKCBMEOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x471C6A0", Offset = "0x471ACA0", VA = "0x18471C6A0", Slot = "143")]
		protected virtual List<BLDEJALINAE> GFILOLOCLIE(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "144")]
		protected virtual void FFBGKHDKPEL(PIDEGLEPBNK BKLAAIOGBOJ, LGFDHPNODBI PDONELNLLHC, KBHINEMHBJO MEHHBDDDBKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x47201C0", Offset = "0x471E7C0", VA = "0x1847201C0", Slot = "120")]
		protected override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x471EA50", Offset = "0x471D050", VA = "0x18471EA50")]
		private LGFDHPNODBI MLJMPHKCIAA(PIDEGLEPBNK BKLAAIOGBOJ, KBHINEMHBJO MEHHBDDDBKO, MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x471D460", Offset = "0x471BA60", VA = "0x18471D460")]
		private List<KPABBPKBIBN> LGENPCAEICF(PIDEGLEPBNK BKLAAIOGBOJ, KBHINEMHBJO MEHHBDDDBKO, LGFDHPNODBI FGOPPHPEGAK, bool DAMPHGNICNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x471CB00", Offset = "0x471B100", VA = "0x18471CB00")]
		private List<KPABBPKBIBN> JIFCNAKJEIF(PIDEGLEPBNK BKLAAIOGBOJ, KBHINEMHBJO MEHHBDDDBKO, DBDMDCDNCFC EHGIOJOEILB, bool DAMPHGNICNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x471C300", Offset = "0x471A900", VA = "0x18471C300")]
		private BLDEJALINAE DKDFJDFGJHD(List<BLDEJALINAE> OLAFDCFNOEJ, DBDMDCDNCFC EHGIOJOEILB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x471C4F0", Offset = "0x471AAF0", VA = "0x18471C4F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public GHFMLCGBHPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x2068C80", Offset = "0x2067280", VA = "0x182068C80")]
			internal int JDPFBIGGGNI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x2068CD0", Offset = "0x20672D0", VA = "0x182068CD0")]
			internal void MDAPEAKELDK(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NodeVisualizationKey PJJDBLNOLBI
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xA4BF60", Offset = "0xA4A560", VA = "0x180A4BF60", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x206EF40", Offset = "0x206D540", VA = "0x18206EF40")]
		public KANBBMDGHIP(PLLOHOJACCG PFCDDIODGEJ, PPOKGLOPLNG KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x206ED80", Offset = "0x206D380", VA = "0x18206ED80", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public BAOHBCGIOME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x20647D0", Offset = "0x2062DD0", VA = "0x1820647D0")]
			internal int MJDFMONDNHO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x2064730", Offset = "0x2062D30", VA = "0x182064730")]
			internal void AJMOMHLBAIF(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2068C20", Offset = "0x2067220", VA = "0x182068C20")]
		public GFJMBGJCGJM(PLLOHOJACCG PFCDDIODGEJ, LBELPNIEOBI BDPEMHOFOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x20689E0", Offset = "0x2066FE0", VA = "0x1820689E0", Slot = "126")]
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
			[Cpp2IlInjected.Address(RVA = "0xA25910", Offset = "0xA23F10", VA = "0x180A25910", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x206C510", Offset = "0x206AB10", VA = "0x18206C510")]
		public HDPGJMFDEGA(PLLOHOJACCG PFCDDIODGEJ, LNJJBPKEDNK KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public MAEBCONHMCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x207A6E0", Offset = "0x2078CE0", VA = "0x18207A6E0")]
			internal bool JDPFBIGGGNI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x207B1A0", Offset = "0x20797A0", VA = "0x18207B1A0")]
			internal void MDAPEAKELDK(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x2079FF0", Offset = "0x20785F0", VA = "0x182079FF0")]
			internal bool IACLJHOBOIL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x20713E0", Offset = "0x206F9E0", VA = "0x1820713E0")]
			internal bool AADPJDPABMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x2077990", Offset = "0x2075F90", VA = "0x182077990")]
			internal void BDPDDNLEAGC(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x207BB20", Offset = "0x207A120", VA = "0x18207BB20")]
			internal bool OGIOFKDKMKL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x207A850", Offset = "0x2078E50", VA = "0x18207A850")]
			internal bool JHGLEIFOOFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x207C0D0", Offset = "0x207A6D0", VA = "0x18207C0D0")]
			internal void POPLGOOHKOK(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x20797F0", Offset = "0x2077DF0", VA = "0x1820797F0")]
			internal bool GJFPENBENHO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x207B5D0", Offset = "0x2079BD0", VA = "0x18207B5D0")]
			internal bool NFANODJDBMH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x207ACE0", Offset = "0x20792E0", VA = "0x18207ACE0")]
			internal void KJAKMIEBMMA(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x207A310", Offset = "0x2078910", VA = "0x18207A310")]
			internal bool IEDFAIDIJEA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x207AC40", Offset = "0x2079240", VA = "0x18207AC40")]
			internal bool KGAPHNIEBEE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x207A090", Offset = "0x2078690", VA = "0x18207A090")]
			internal bool IAJIDFKEGPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x20716C0", Offset = "0x206FCC0", VA = "0x1820716C0")]
			internal bool AHNBGNAAGAJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x2079320", Offset = "0x2077920", VA = "0x182079320")]
			internal bool FKMKOEEHCIO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x207AAB0", Offset = "0x20790B0", VA = "0x18207AAB0")]
			internal bool KADCJOEMJCO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x207AEB0", Offset = "0x20794B0", VA = "0x18207AEB0")]
			internal bool LDGAONAJICJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x207BF40", Offset = "0x207A540", VA = "0x18207BF40")]
			internal bool PFBJILODGOG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x207A510", Offset = "0x2078B10", VA = "0x18207A510")]
			internal bool IOIADJNAJGE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x2078CF0", Offset = "0x20772F0", VA = "0x182078CF0")]
			internal void ENHCNFFFJPA(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x207A4C0", Offset = "0x2078AC0", VA = "0x18207A4C0")]
			internal bool INCJICAENBL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x2079F50", Offset = "0x2078550", VA = "0x182079F50")]
			internal bool HOFDANBLIDL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x20778F0", Offset = "0x2075EF0", VA = "0x1820778F0")]
			internal bool BCIOKBHONCE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x207A8A0", Offset = "0x2078EA0", VA = "0x18207A8A0")]
			internal bool JJEHJNHJLBG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x2078860", Offset = "0x2076E60", VA = "0x182078860")]
			internal bool EALMGIMAMEN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x20715E0", Offset = "0x206FBE0", VA = "0x1820715E0")]
			internal bool AGEIOLPHPIB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x207A3D0", Offset = "0x20789D0", VA = "0x18207A3D0")]
			internal bool IJFPPNNNBAN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x2079A00", Offset = "0x2078000", VA = "0x182079A00")]
			internal bool GNMJDKGPLKI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x207AA00", Offset = "0x2079000", VA = "0x18207AA00")]
			internal void JNOPPGCCECB(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x2079B90", Offset = "0x2078190", VA = "0x182079B90")]
			internal bool HDBMPIMEEJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x2078CA0", Offset = "0x20772A0", VA = "0x182078CA0")]
			internal bool EMNMHAOAOON()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x20798E0", Offset = "0x2077EE0", VA = "0x1820798E0")]
			internal void GKNAACCBKJP(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x20797A0", Offset = "0x2077DA0", VA = "0x1820797A0")]
			internal bool GGLJPJKOIPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x2079E60", Offset = "0x2078460", VA = "0x182079E60")]
			internal bool HKJNOAIOEHF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x2077E50", Offset = "0x2076450", VA = "0x182077E50")]
			internal void CDCPFOBAAIH(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x2071800", Offset = "0x206FE00", VA = "0x182071800")]
			internal List<KPABBPKBIBN> AMKPFMGHEOI(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x2077AE0", Offset = "0x20760E0", VA = "0x182077AE0")]
			internal bool BKBABMALCON()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x2079170", Offset = "0x2077770", VA = "0x182079170")]
			internal int FFPMIAECBAO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x207B870", Offset = "0x2079E70", VA = "0x18207B870")]
			internal void NPKIJJGBIKM(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x2079D20", Offset = "0x2078320", VA = "0x182079D20")]
			internal bool HIJANFFBNFK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x207BD00", Offset = "0x207A300", VA = "0x18207BD00")]
			internal bool OJDJOJMPMLJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x2078720", Offset = "0x2076D20", VA = "0x182078720")]
			internal bool DJDGPOGLACC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x20789E0", Offset = "0x2076FE0", VA = "0x1820789E0")]
			internal int EDNNLCBFAKF()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x207AFA0", Offset = "0x20795A0", VA = "0x18207AFA0")]
			internal void LKGKGEMDENN(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x207AF00", Offset = "0x2079500", VA = "0x18207AF00")]
			internal bool LECIKKDEGIB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x207B820", Offset = "0x2079E20", VA = "0x18207B820")]
			internal bool NOEPGFIBJNN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x2071520", Offset = "0x206FB20", VA = "0x182071520")]
			internal bool ADMLGLBAGAO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x207BDF0", Offset = "0x207A3F0", VA = "0x18207BDF0")]
			internal bool ONLOFMGLCDB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x207BA30", Offset = "0x207A030", VA = "0x18207BA30")]
			internal bool OEEFIILJPII()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x207ABA0", Offset = "0x20791A0", VA = "0x18207ABA0")]
			internal bool KEIKOJEDNGO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x2071710", Offset = "0x206FD10", VA = "0x182071710")]
			internal string AHNEGGFOJFH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x2079620", Offset = "0x2077C20", VA = "0x182079620")]
			internal void GAPKKFLHKML(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x207B720", Offset = "0x2079D20", VA = "0x18207B720")]
			internal int NJINHNOLKEO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x207ADE0", Offset = "0x20793E0", VA = "0x18207ADE0")]
			internal void KLOICLHMLKK(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x2071430", Offset = "0x206FA30", VA = "0x182071430")]
			internal bool AAJDODIAPOD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x207B000", Offset = "0x2079600", VA = "0x18207B000")]
			internal bool LLMHBEPGCIC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x2078BE0", Offset = "0x20771E0", VA = "0x182078BE0")]
			internal bool ELLEHBOKCCB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x207BEF0", Offset = "0x207A4F0", VA = "0x18207BEF0")]
			internal float PBJJDAFGEIC()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x2078130", Offset = "0x2076730", VA = "0x182078130")]
			internal void COBJKHKHBMA(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x207BDA0", Offset = "0x207A3A0", VA = "0x18207BDA0")]
			internal bool OMDBJGEMAMK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x207B7D0", Offset = "0x2079DD0", VA = "0x18207B7D0")]
			internal bool NNKGFOHDGLM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x207BCB0", Offset = "0x207A2B0", VA = "0x18207BCB0")]
			internal bool OIGKICBDEMI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x207BBC0", Offset = "0x207A1C0", VA = "0x18207BBC0")]
			internal bool OGOLHMIPJKO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x207A130", Offset = "0x2078730", VA = "0x18207A130")]
			internal bool IAOCLMFDELB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x207A2C0", Offset = "0x20788C0", VA = "0x18207A2C0")]
			internal bool IDKAJAHMDNN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x2078190", Offset = "0x2076790", VA = "0x182078190")]
			internal void COFDLMCHPKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x2071480", Offset = "0x206FA80", VA = "0x182071480")]
			internal string ABMGMOIHOOE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x207A5B0", Offset = "0x2078BB0", VA = "0x18207A5B0")]
			internal void IPKBELJOOMC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x207A270", Offset = "0x2078870", VA = "0x18207A270")]
			internal bool ICNDFDBHBKL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x20780E0", Offset = "0x20766E0", VA = "0x1820780E0")]
			internal bool CLNEDJILHLN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x20786D0", Offset = "0x2076CD0", VA = "0x1820786D0")]
			internal bool DHLEFFBMJNG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x2078DF0", Offset = "0x20773F0", VA = "0x182078DF0")]
			internal void FBFCECBOOFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x2079210", Offset = "0x2077810", VA = "0x182079210")]
			internal bool FKADOMFOFPJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x2077C30", Offset = "0x2076230", VA = "0x182077C30")]
			internal bool BOBGNEJBIJG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x20779F0", Offset = "0x2075FF0", VA = "0x1820779F0")]
			internal bool BEGAMFLJBGI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x2079F00", Offset = "0x2078500", VA = "0x182079F00")]
			internal bool HNPHKHBMOLC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x207A7F0", Offset = "0x2078DF0", VA = "0x18207A7F0")]
			internal void JHBIDCBEALD(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x207A180", Offset = "0x2078780", VA = "0x18207A180")]
			internal bool IAPLHGGODFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x207AF50", Offset = "0x2079550", VA = "0x18207AF50")]
			internal bool LEFLFAPPKJJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x2078D50", Offset = "0x2077350", VA = "0x182078D50")]
			internal bool FAPANMIKJNA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x2078540", Offset = "0x2076B40", VA = "0x182078540")]
			internal bool COJNPBMNCAP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x207BE90", Offset = "0x207A490", VA = "0x18207BE90")]
			internal void PAMNAEEPPEN(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x2077A90", Offset = "0x2076090", VA = "0x182077A90")]
			internal bool BJGFGDHGHLK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x207A470", Offset = "0x2078A70", VA = "0x18207A470")]
			internal bool IMHKFPJBLDJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x207B100", Offset = "0x2079700", VA = "0x18207B100")]
			internal bool LNDBEBEACIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x2078090", Offset = "0x2076690", VA = "0x182078090")]
			internal bool CLGMCFILILD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x2077C80", Offset = "0x2076280", VA = "0x182077C80")]
			internal object BOLGHOKLNID()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x2077EB0", Offset = "0x20764B0", VA = "0x182077EB0")]
			internal void CEMBBMKLALC(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x207AB50", Offset = "0x2079150", VA = "0x18207AB50")]
			internal bool KCFGFMFJJCA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x207B2F0", Offset = "0x20798F0", VA = "0x18207B2F0")]
			internal bool MJJIEFEGNEH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x2079B40", Offset = "0x2078140", VA = "0x182079B40")]
			internal int HAKPICDEGDH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x2079520", Offset = "0x2077B20", VA = "0x182079520")]
			internal void FONPGDGMCCB(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x207B2A0", Offset = "0x20798A0", VA = "0x18207B2A0")]
			internal bool MJFNFIANIGD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x207BC10", Offset = "0x207A210", VA = "0x18207BC10")]
			internal bool OHANHGAIIAM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x207B920", Offset = "0x2079F20", VA = "0x18207B920")]
			internal int OBFECCMEBKO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x2079370", Offset = "0x2077970", VA = "0x182079370")]
			internal void FKPFGDGDLJO(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x2079D70", Offset = "0x2078370", VA = "0x182079D70")]
			internal bool HJDHKIFJCBA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x207AD40", Offset = "0x2079340", VA = "0x18207AD40")]
			internal bool KKPMFKNBOLB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x20799B0", Offset = "0x2077FB0", VA = "0x1820799B0")]
			internal bool GNFKCOEPPHF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x207C080", Offset = "0x207A680", VA = "0x18207C080")]
			internal int PNMOLFHBJBA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x207B670", Offset = "0x2079C70", VA = "0x18207B670")]
			internal void NHCANDNPEGL(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x207BFE0", Offset = "0x207A5E0", VA = "0x18207BFE0")]
			internal bool PLDCLPAFLNN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x207B0B0", Offset = "0x20796B0", VA = "0x18207B0B0")]
			internal bool LMJBGGDGLLL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x2078A30", Offset = "0x2077030", VA = "0x182078A30")]
			internal bool EFHOCLHGIHN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x2078B70", Offset = "0x2077170", VA = "0x182078B70")]
			internal object ELKDOGMBFKJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x2071630", Offset = "0x206FC30", VA = "0x182071630")]
			internal void AHKBGJNCAAJ(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x207B580", Offset = "0x2079B80", VA = "0x18207B580")]
			internal bool NEFJOLFLLAM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x20787C0", Offset = "0x2076DC0", VA = "0x1820787C0")]
			internal bool DNONEACINOM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x207AE40", Offset = "0x2079440", VA = "0x18207AE40")]
			internal object LAJDFCGEPMJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x2078950", Offset = "0x2076F50", VA = "0x182078950")]
			internal void EDNEPENKMEG(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x2078810", Offset = "0x2076E10", VA = "0x182078810")]
			internal bool DPCMEPIHAAP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x207BB70", Offset = "0x207A170", VA = "0x18207BB70")]
			internal int OGKHNONGDME()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x207B050", Offset = "0x2079650", VA = "0x18207B050")]
			internal void LMBLAKHFCDJ(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x2079FA0", Offset = "0x20785A0", VA = "0x182079FA0")]
			internal bool HPFPFCCJBGB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x2079C80", Offset = "0x2078280", VA = "0x182079C80")]
			internal bool HEECEBBECFG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x207BF90", Offset = "0x207A590", VA = "0x18207BF90")]
			internal bool PKMFLJJOCFJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x20785E0", Offset = "0x2076BE0", VA = "0x1820785E0")]
			internal int DCBDELIAFKE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x2079420", Offset = "0x2077A20", VA = "0x182079420")]
			internal void FMEPCPBFBHH(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x207AA60", Offset = "0x2079060", VA = "0x18207AA60")]
			internal bool JPBLMMABNKC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x2079AF0", Offset = "0x20780F0", VA = "0x182079AF0")]
			internal bool GPKJAMPPIKJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x207B4D0", Offset = "0x2079AD0", VA = "0x18207B4D0")]
			internal bool NBJPAJKBNJM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x2079EB0", Offset = "0x20784B0", VA = "0x182079EB0")]
			internal float HMDNHCAICKJ()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x207B770", Offset = "0x2079D70", VA = "0x18207B770")]
			internal void NMEHMCECBKJ(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x2078A80", Offset = "0x2077080", VA = "0x182078A80")]
			internal bool EIDFOJEKDDG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x207A220", Offset = "0x2078820", VA = "0x18207A220")]
			internal bool ICGLHGEIDHH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x2079E10", Offset = "0x2078410", VA = "0x182079E10")]
			internal bool HKIHKCADBKG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x207B970", Offset = "0x2079F70", VA = "0x18207B970")]
			internal float OCEOILEHFDD()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x2077B30", Offset = "0x2076130", VA = "0x182077B30")]
			internal void BKHHNOJNPMP(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x2077B90", Offset = "0x2076190", VA = "0x182077B90")]
			internal bool BNFAMAEFDKL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x207A560", Offset = "0x2078B60", VA = "0x18207A560")]
			internal bool IOOGNDOOGHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x20714D0", Offset = "0x206FAD0", VA = "0x1820714D0")]
			internal string ADJPJOAEJDI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x2079940", Offset = "0x2077F40", VA = "0x182079940")]
			internal void GMIOJNOHLHA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x207B620", Offset = "0x2079C20", VA = "0x18207B620")]
			internal bool NGIMBANHFDF(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x2079120", Offset = "0x2077720", VA = "0x182079120")]
			internal bool FDEEAKBIANH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x2077BE0", Offset = "0x20761E0", VA = "0x182077BE0")]
			internal bool BNGJHGBDIHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x207B340", Offset = "0x2079940", VA = "0x18207B340")]
			internal bool MKDCHDPMEMC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x20794D0", Offset = "0x2077AD0", VA = "0x1820794D0")]
			internal string FNIEAIDDAEJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x207A620", Offset = "0x2078C20", VA = "0x18207A620")]
			internal void IPMHDJHHDIA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x207ABF0", Offset = "0x20791F0", VA = "0x18207ABF0")]
			internal bool KEJEEIFBBNN(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x207A420", Offset = "0x2078A20", VA = "0x18207A420")]
			internal bool IKGACPLLIDN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x2078DA0", Offset = "0x20773A0", VA = "0x182078DA0")]
			internal bool FBDHCBLBCFL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x2078590", Offset = "0x2076B90", VA = "0x182078590")]
			internal bool DAKFCLMKEIJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x207A690", Offset = "0x2078C90", VA = "0x18207A690")]
			internal string JDFIMECBIFI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x207A990", Offset = "0x2078F90", VA = "0x18207A990")]
			internal void JNFOILPOCAN(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x207B200", Offset = "0x2079800", VA = "0x18207B200")]
			internal bool MFONBEAGDNM(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x207AC90", Offset = "0x2079290", VA = "0x18207AC90")]
			internal bool KIHDJFPKLBN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x2079690", Offset = "0x2077C90", VA = "0x182079690")]
			internal bool GCJFJDAAHPK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x207B430", Offset = "0x2079A30", VA = "0x18207B430")]
			internal bool MNIAAPJMJHL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x2079AA0", Offset = "0x20780A0", VA = "0x182079AA0")]
			internal string GPCCNBEPPLE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x2078C30", Offset = "0x2077230", VA = "0x182078C30")]
			internal void EMJOGHHEIDO(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x20796E0", Offset = "0x2077CE0", VA = "0x1820796E0")]
			internal bool GDMJILLEJAC(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x207BE40", Offset = "0x207A440", VA = "0x18207BE40")]
			internal bool OPGDALMCFGA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x207B8D0", Offset = "0x2079ED0", VA = "0x18207B8D0")]
			internal bool OAHOMKKNCDC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x2078900", Offset = "0x2076F00", VA = "0x182078900")]
			internal bool ECPMICHIEHC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x2079260", Offset = "0x2077860", VA = "0x182079260")]
			internal string FKDLFBCGDLM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x207A780", Offset = "0x2078D80", VA = "0x18207A780")]
			internal void JFAOGKCDLLI(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x20795D0", Offset = "0x2077BD0", VA = "0x1820795D0")]
			internal bool GAHAHOEFJGO(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x207A1D0", Offset = "0x20787D0", VA = "0x18207A1D0")]
			internal bool IBAILKLEAIP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x207A730", Offset = "0x2078D30", VA = "0x18207A730")]
			internal bool JFAALLANPGE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x207BC60", Offset = "0x207A260", VA = "0x18207BC60")]
			internal bool OHJJPHBHMHE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x20793D0", Offset = "0x20779D0", VA = "0x1820793D0")]
			internal string FLADCNMDHFN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x2077880", Offset = "0x2075E80", VA = "0x182077880")]
			internal void BCBCCDIIENN(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x2077F90", Offset = "0x2076590", VA = "0x182077F90")]
			internal bool CGLGLGGIMDI(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x207AD90", Offset = "0x2079390", VA = "0x18207AD90")]
			internal bool KLLDJIPPEJN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x2078680", Offset = "0x2076C80", VA = "0x182078680")]
			internal bool DGKAHLAFJPM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x207C030", Offset = "0x207A630", VA = "0x18207C030")]
			internal bool PNADGFDGHHG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x2079C30", Offset = "0x2078230", VA = "0x182079C30")]
			internal string HEEANAPNKIN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x2071570", Offset = "0x206FB70", VA = "0x182071570")]
			internal void AFEAOMFHEEG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x207A940", Offset = "0x2078F40", VA = "0x18207A940")]
			internal bool JMLGCBAPLKA(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x2077F40", Offset = "0x2076540", VA = "0x182077F40")]
			internal bool CFJPJEKGMPF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x2071760", Offset = "0x206FD60", VA = "0x182071760")]
			internal bool AJOOLICBKGC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x2079BE0", Offset = "0x20781E0", VA = "0x182079BE0")]
			internal bool HDPNIHPABIC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x2079480", Offset = "0x2077A80", VA = "0x182079480")]
			internal string FNHGFLMHIJD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x2077D40", Offset = "0x2076340", VA = "0x182077D40")]
			internal void BPEPLBMPGCC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x207B250", Offset = "0x2079850", VA = "0x18207B250")]
			internal bool MGFLJCMIHPO(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x2078630", Offset = "0x2076C30", VA = "0x182078630")]
			internal bool DEGPHLHEDOP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x20791C0", Offset = "0x20777C0", VA = "0x1820791C0")]
			internal bool FJEJIEJBICI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x207BD50", Offset = "0x207A350", VA = "0x18207BD50")]
			internal bool OMCBOKIBPAD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x2079DC0", Offset = "0x20783C0", VA = "0x182079DC0")]
			internal string HKCMCOAEJHO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x20792B0", Offset = "0x20778B0", VA = "0x1820792B0")]
			internal void FKIMFMHGANM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x2079840", Offset = "0x2077E40", VA = "0x182079840")]
			internal bool GKBJEAAKJAK(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x2078770", Offset = "0x2076D70", VA = "0x182078770")]
			internal bool DLCFCAMBFOJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x207B6D0", Offset = "0x2079CD0", VA = "0x18207B6D0")]
			internal bool NHIAKLLLIEK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x207A8F0", Offset = "0x2078EF0", VA = "0x18207A8F0")]
			internal bool JMCGDAFOFAE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x2079CD0", Offset = "0x20782D0", VA = "0x182079CD0")]
			internal string HHKKBOAGMDI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x207A360", Offset = "0x2078960", VA = "0x18207A360")]
			internal void IFICMDGLEHA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x2079890", Offset = "0x2077E90", VA = "0x182079890")]
			internal bool GKMLNPJHEBF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x2077DB0", Offset = "0x20763B0", VA = "0x182077DB0")]
			internal bool CAOHAAFOGPD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x207B150", Offset = "0x2079750", VA = "0x18207B150")]
			internal bool MBPJAIBBCDO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x2077940", Offset = "0x2075F40", VA = "0x182077940")]
			internal string BDKAIHBDMAI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x20790B0", Offset = "0x20776B0", VA = "0x1820790B0")]
			internal void FCFGOPDHBEG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x2077CF0", Offset = "0x20762F0", VA = "0x182077CF0")]
			internal bool BPDIHAHAJGP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x2079A50", Offset = "0x2078050", VA = "0x182079A50")]
			internal bool GNOHNPGBLFH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x207A040", Offset = "0x2078640", VA = "0x18207A040")]
			internal bool IADBFBPPGAP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x207A0E0", Offset = "0x20786E0", VA = "0x18207A0E0")]
			internal string IAOCKFLPMJC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x207B9C0", Offset = "0x2079FC0", VA = "0x18207B9C0")]
			internal void ODFGKFFNDOM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x2077E00", Offset = "0x2076400", VA = "0x182077E00")]
			internal bool CDAPGENKPGJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x207BA80", Offset = "0x207A080", VA = "0x18207BA80")]
			internal bool OFGDLNBNEEA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x207B480", Offset = "0x2079A80", VA = "0x18207B480")]
			internal bool MOMFNCCCJJH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x2078B20", Offset = "0x2077120", VA = "0x182078B20")]
			internal string ELDGMMBEFGE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x2079730", Offset = "0x2077D30", VA = "0x182079730")]
			internal void GEHNIIHEHKH(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x2078AD0", Offset = "0x20770D0", VA = "0x182078AD0")]
			internal bool ELAKBONOPAH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x2078040", Offset = "0x2076640", VA = "0x182078040")]
			internal bool CLBONIIEFIN(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x2077A40", Offset = "0x2076040", VA = "0x182077A40")]
			internal float BGHDAMPNBIE()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x207B520", Offset = "0x2079B20", VA = "0x18207B520")]
			internal void NCGIHDFKJDO(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x20788B0", Offset = "0x2076EB0", VA = "0x1820788B0")]
			internal bool ECCDKDLDKLJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x207B3E0", Offset = "0x20799E0", VA = "0x18207B3E0")]
			internal bool MMFJNDAJBIG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x207AB00", Offset = "0x2079100", VA = "0x18207AB00")]
			internal bool KAPAOLPPKJN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x207BAD0", Offset = "0x207A0D0", VA = "0x18207BAD0")]
			internal int OGFNAGLJFPC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x2077FE0", Offset = "0x20765E0", VA = "0x182077FE0")]
			internal void CJCHHMDBNEA(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x2079580", Offset = "0x2077B80", VA = "0x182079580")]
			internal bool FOOPGHNODPB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x20717B0", Offset = "0x206FDB0", VA = "0x1820717B0")]
			internal bool ALBJKOKFEJI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x207B390", Offset = "0x2079990", VA = "0x18207B390")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public PKGHHMDOFNJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x207E130", Offset = "0x207C730", VA = "0x18207E130")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public CPNJHKBINGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x2065DB0", Offset = "0x20643B0", VA = "0x182065DB0")]
			internal bool IEAGJDBOJIO(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly CFPOLMBGNDM IHCFGNNIHAB;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2067C90", Offset = "0x2066290", VA = "0x182067C90")]
		public DKKMDKMIDLL(PLLOHOJACCG PFCDDIODGEJ, BJHOMAEDFOE KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2065F50", Offset = "0x2064550", VA = "0x182065F50", Slot = "120")]
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
				[Cpp2IlInjected.Address(RVA = "0x209DA30", Offset = "0x209C030", VA = "0x18209DA30", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0xB9D680", Offset = "0xB9BC80", VA = "0x180B9D680", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public EEGHNCGCEEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x2084DB0", Offset = "0x20833B0", VA = "0x182084DB0")]
			internal string JDPFBIGGGNI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x2084E00", Offset = "0x2083400", VA = "0x182084E00")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void MDAPEAKELDK(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x2084ED0", Offset = "0x20834D0", VA = "0x182084ED0")]
			internal int NLOAMKMODOM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x2084D20", Offset = "0x2083320", VA = "0x182084D20")]
			internal void IIBCAKFOPMO(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override NodeVisualizationKey PJJDBLNOLBI
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xA4BF60", Offset = "0xA4A560", VA = "0x180A4BF60", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x208D9D0", Offset = "0x208BFD0", VA = "0x18208D9D0")]
		public HEHHBCPIFOJ(PLLOHOJACCG PFCDDIODGEJ, FBMNPKIAFPD BDPEMHOFOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x208D680", Offset = "0x208BC80", VA = "0x18208D680", Slot = "120")]
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
				[Cpp2IlInjected.Address(RVA = "0x209D6F0", Offset = "0x209BCF0", VA = "0x18209D6F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BB")]
				[Cpp2IlInjected.Address(RVA = "0xB9D680", Offset = "0xB9BC80", VA = "0x180B9D680", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x209DD40", Offset = "0x209C340", VA = "0x18209DD40", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0xB9D680", Offset = "0xB9BC80", VA = "0x180B9D680", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public LABOALLIDAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x2096160", Offset = "0x2094760", VA = "0x182096160")]
			internal string JDPFBIGGGNI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x2096250", Offset = "0x2094850", VA = "0x182096250")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void MDAPEAKELDK(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x2096320", Offset = "0x2094920", VA = "0x182096320")]
			internal int NLOAMKMODOM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x20960D0", Offset = "0x20946D0", VA = "0x1820960D0")]
			internal void IIBCAKFOPMO(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x2096080", Offset = "0x2094680", VA = "0x182096080")]
			internal string IACLJHOBOIL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x2095E00", Offset = "0x2094400", VA = "0x182095E00")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void AADPJDPABMP(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x2095F30", Offset = "0x2094530", VA = "0x182095F30")]
			internal bool BDPDDNLEAGC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x2095F80", Offset = "0x2094580", VA = "0x182095F80")]
			internal void FICJGAHFHBG(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x2096200", Offset = "0x2094800", VA = "0x182096200")]
			internal bool LBPBDKOKHMB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x2096370", Offset = "0x2094970", VA = "0x182096370")]
			internal void OGIOFKDKMKL(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x20961B0", Offset = "0x20947B0", VA = "0x1820961B0")]
			internal float JHGLEIFOOFC()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x20964A0", Offset = "0x2094AA0", VA = "0x1820964A0")]
			internal void POPLGOOHKOK(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x2095ED0", Offset = "0x20944D0", VA = "0x182095ED0")]
			internal int AIEJHEIONHE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x2096400", Offset = "0x2094A00", VA = "0x182096400")]
			internal void PIANLAOJJDB(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x2096010", Offset = "0x2094610", VA = "0x182096010")]
			internal bool GJFPENBENHO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey PJJDBLNOLBI
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0xA4BF60", Offset = "0xA4A560", VA = "0x180A4BF60", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x2094E80", Offset = "0x2093480", VA = "0x182094E80")]
		public JICBDEFPIKE(PLLOHOJACCG PFCDDIODGEJ, ILLAHPLLLPF KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x2094440", Offset = "0x2092A40", VA = "0x182094440", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public GLPLCAILJIP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x208CF60", Offset = "0x208B560", VA = "0x18208CF60")]
			internal Dictionary<string, OKCGCELKKAL> JDPFBIGGGNI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x208D000", Offset = "0x208B600", VA = "0x18208D000")]
			internal int MDAPEAKELDK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x208D050", Offset = "0x208B650", VA = "0x18208D050")]
			internal void NLOAMKMODOM(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x208CEE0", Offset = "0x208B4E0", VA = "0x18208CEE0")]
			internal bool IIBCAKFOPMO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey PJJDBLNOLBI
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xA4BF60", Offset = "0xA4A560", VA = "0x180A4BF60", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x2084CB0", Offset = "0x20832B0", VA = "0x182084CB0")]
		public DOPICIMIIJA(PLLOHOJACCG PFCDDIODGEJ, BGPKFLKODOA BDPEMHOFOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x20849E0", Offset = "0x2082FE0", VA = "0x1820849E0", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public AJGECFENONK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x20833C0", Offset = "0x20819C0", VA = "0x1820833C0")]
			internal void JDPFBIGGGNI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey PJJDBLNOLBI
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0xA4BF60", Offset = "0xA4A560", VA = "0x180A4BF60", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x2084000", Offset = "0x2082600", VA = "0x182084000")]
		public CEJDGDPCHAF(PLLOHOJACCG PFCDDIODGEJ, EIPPOODHFIE BDPEMHOFOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x2083E80", Offset = "0x2082480", VA = "0x182083E80", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override bool DHMDIDJKFCL
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x208C7F0", Offset = "0x208ADF0", VA = "0x18208C7F0", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override NodeVisualizationKey PJJDBLNOLBI
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x8F7A60", Offset = "0x8F6060", VA = "0x1808F7A60", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x208C790", Offset = "0x208AD90", VA = "0x18208C790")]
		public GEPIFBFAPML(PLLOHOJACCG PFCDDIODGEJ, NFLDBNMGCFN KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1EA20", Offset = "0xA1D020", VA = "0x180A1EA20", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208BC10", VA = "0x18208D610")]
		public HAFBIGNFLCF(PLLOHOJACCG PFCDDIODGEJ, CAOODCIFEKN KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5FDF0", Offset = "0xA5E3F0", VA = "0x180A5FDF0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x209BF90", Offset = "0x209A590", VA = "0x18209BF90")]
		public MMMMHGCJCJM(PLLOHOJACCG PFCDDIODGEJ, OCGMFNOMJME KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "112")]
		protected override bool GIBGGBJCBHD(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0xA64FD0", Offset = "0xA635D0", VA = "0x180A64FD0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool PDCHHCNMNKC
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x208C570", Offset = "0x208AB70", VA = "0x18208C570", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected override bool HAHGFBEMNBC
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x208C500", Offset = "0x208AB00", VA = "0x18208C500")]
		public FNPNJPPMCOE(PLLOHOJACCG PFCDDIODGEJ, MMJGIPPLNPB KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x91FD90", Offset = "0x91E390", VA = "0x18091FD90", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override bool PDCHHCNMNKC
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x209D2E0", Offset = "0x209B8E0", VA = "0x18209D2E0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		protected override bool HAHGFBEMNBC
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x209D270", Offset = "0x209B870", VA = "0x18209D270")]
		public PLJEICLGFCN(PLLOHOJACCG PFCDDIODGEJ, CEMLDIGKCDG KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public FFIMMAMBBCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x208BFE0", Offset = "0x208A5E0", VA = "0x18208BFE0")]
			internal float MJDFMONDNHO()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x208BF40", Offset = "0x208A540", VA = "0x18208BF40")]
			internal void AJMOMHLBAIF(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x208E510", Offset = "0x208CB10", VA = "0x18208E510")]
		public HMHIJNIDNPC(PLLOHOJACCG PFCDDIODGEJ, PEADKCIDNDM BDPEMHOFOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x208E290", Offset = "0x208C890", VA = "0x18208E290", Slot = "126")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public GEIPMFHPKMI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x208C620", Offset = "0x208AC20", VA = "0x18208C620")]
			internal bool JDPFBIGGGNI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x208C670", Offset = "0x208AC70", VA = "0x18208C670")]
			internal void MDAPEAKELDK(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x209C710", Offset = "0x209AD10", VA = "0x18209C710")]
		public NHFLCCNJPBI(PLLOHOJACCG PFCDDIODGEJ, FPMEGHEJECG BDPEMHOFOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x209C460", Offset = "0x209AA60", VA = "0x18209C460", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public HOBCPKFGINP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x208E820", Offset = "0x208CE20", VA = "0x18208E820")]
			internal object JDPFBIGGGNI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x208E6E0", Offset = "0x208CCE0", VA = "0x18208E6E0")]
			internal bool FICJGAHFHBG(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x208E950", Offset = "0x208CF50", VA = "0x18208E950")]
			internal void MDAPEAKELDK(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x208EBA0", Offset = "0x208D1A0", VA = "0x18208EBA0")]
			internal string NLOAMKMODOM(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x208E7D0", Offset = "0x208CDD0", VA = "0x18208E7D0")]
			internal IReadOnlyList<object> IIBCAKFOPMO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x208E760", Offset = "0x208CD60", VA = "0x18208E760")]
			internal bool IACLJHOBOIL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x208E570", Offset = "0x208CB70", VA = "0x18208E570")]
			internal bool AADPJDPABMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x208E5C0", Offset = "0x208CBC0", VA = "0x18208E5C0")]
			internal void BDPDDNLEAGC(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x2085A10", Offset = "0x2084010", VA = "0x182085A10")]
		public EFCOGAPLLMO(PLLOHOJACCG PFCDDIODGEJ, ELPPFLGBNNL BDPEMHOFOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x20851D0", Offset = "0x20837D0", VA = "0x1820851D0", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0xC3B000", Offset = "0xC39600", VA = "0x180C3B000", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x209CE90", Offset = "0x209B490", VA = "0x18209CE90")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public AEIGFPNJMJH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x2083340", Offset = "0x2081940", VA = "0x182083340")]
			internal int MJDFMONDNHO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x20832A0", Offset = "0x20818A0", VA = "0x1820832A0")]
			internal void AJMOMHLBAIF(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x208CE80", Offset = "0x208B480", VA = "0x18208CE80")]
		public GKAEJGMDFGN(PLLOHOJACCG PFCDDIODGEJ, MCLCIFFOIKA BDPEMHOFOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x208CBF0", Offset = "0x208B1F0", VA = "0x18208CBF0", Slot = "126")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public HIMPIJFEHLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x208E1B0", Offset = "0x208C7B0", VA = "0x18208E1B0")]
			internal bool JDPFBIGGGNI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x208E200", Offset = "0x208C800", VA = "0x18208E200")]
			internal void MDAPEAKELDK(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x2084250", Offset = "0x2082850", VA = "0x182084250")]
		public CHGDNLGGNGN(PLLOHOJACCG PFCDDIODGEJ, PBHIEABDMBD BDPEMHOFOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x2084070", Offset = "0x2082670", VA = "0x182084070", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public MIBGFDNOAFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x2096A60", Offset = "0x2095060", VA = "0x182096A60")]
			internal bool JDPFBIGGGNI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x2096AB0", Offset = "0x20950B0", VA = "0x182096AB0")]
			internal void MDAPEAKELDK(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x2095B70", Offset = "0x2094170", VA = "0x182095B70")]
		public KFIAFKODKOB(PLLOHOJACCG PFCDDIODGEJ, LFMBFCLHMLK BDPEMHOFOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x2095990", Offset = "0x2093F90", VA = "0x182095990", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public BMHIEIOLONK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x20839A0", Offset = "0x2081FA0", VA = "0x1820839A0")]
			internal int JDPFBIGGGNI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x20839F0", Offset = "0x2081FF0", VA = "0x1820839F0")]
			internal void MDAPEAKELDK(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x2095920", Offset = "0x2093F20", VA = "0x182095920")]
		public KCCPFMEEPJC(PLLOHOJACCG PFCDDIODGEJ, JEOPIHALAHI BDPEMHOFOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x20956C0", Offset = "0x2093CC0", VA = "0x1820956C0", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x8FB3E0", Offset = "0x8F99E0", VA = "0x1808FB3E0", Slot = "126")]
			get
			{
				return default(KALNDDFHJJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x2092DE0", Offset = "0x20913E0", VA = "0x182092DE0")]
		public ICDNDMINAHH(PLLOHOJACCG PFCDDIODGEJ, DEOIDKEEKNJ BDPEMHOFOHC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class OEOAPHDGOOK : OCLPOHGKJMO<DPIPCKFLLFL>
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x2096590", Offset = "0x2094B90", VA = "0x182096590")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public DFIPEMNICNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x5A4B910", Offset = "0x5A49F10", VA = "0x185A4B910")]
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
			[Cpp2IlInjected.Address(RVA = "0x3FE5450", Offset = "0x3FE3A50", VA = "0x183FE5450", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0xB9D680", Offset = "0xB9BC80", VA = "0x180B9D680", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x48188B0", Offset = "0x4816EB0", VA = "0x1848188B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x4818B60", Offset = "0x4817160", VA = "0x184818B60", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x36998F0", Offset = "0x3697EF0", VA = "0x1836998F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000397")]
				[Cpp2IlInjected.Address(RVA = "0xB9D680", Offset = "0xB9BC80", VA = "0x180B9D680", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public COIJJOOBBKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0")]
			internal string OKFDJHDAJJE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x8841C0", Offset = "0x8827C0", VA = "0x1808841C0")]
			internal void IOGNFCBEPJK(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0x5797110", Offset = "0x5795710", VA = "0x185797110")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public PCEDEPHLBMC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x490B800", Offset = "0x4909E00", VA = "0x18490B800")]
			internal bool POGAKMMHBMA(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x490B7F0", Offset = "0x4909DF0", VA = "0x18490B7F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x39860C0", Offset = "0x39846C0", VA = "0x1839860C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x3986450", Offset = "0x3984A50", VA = "0x183986450", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x4811700", Offset = "0x480FD00", VA = "0x184811700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		protected LPGKJOMOPPD BHJIDJAIGAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x4811A60", Offset = "0x4810060", VA = "0x184811A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		protected TNode DFIMPCAKHHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x8879A0", Offset = "0x885FA0", VA = "0x1808879A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCA6E60", Offset = "0xCA5460", VA = "0x180CA6E60", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x4814180", Offset = "0x4812780", VA = "0x184814180", Slot = "6")]
			get
			{
				return default(MJGAEDNBJIL<HHMCJPEBKAJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public object IECKENPPIJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x39D6F50", Offset = "0x39D5550", VA = "0x1839D6F50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public virtual bool CKKCDABPNJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int EGMBGINKKJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x4813DB0", Offset = "0x48123B0", VA = "0x184813DB0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public OKNBGAPNIGA NEEFEBAJHHE
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x4813D50", Offset = "0x4812350", VA = "0x184813D50", Slot = "10")]
			get
			{
				return default(OKNBGAPNIGA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string AIELMMHNEBD
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x4814340", Offset = "0x4812940", VA = "0x184814340", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		protected virtual bool HAHGFBEMNBC
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual NodeVisualizationKey PJJDBLNOLBI
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public MJGAEDNBJIL<KLEOIHDMDMO> EKJKNLGKFPI
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0xAC9600", Offset = "0xAC7C00", VA = "0x180AC9600", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(MJGAEDNBJIL<KLEOIHDMDMO>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0xCB0600", Offset = "0xCAEC00", VA = "0x180CB0600")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual bool PDCHHCNMNKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual bool FEHIDMPCHDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual GFPNMCHHOBN LKOINDAEEGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x93DEF0", Offset = "0x93C4F0", VA = "0x18093DEF0", Slot = "94")]
			get
			{
				return default(GFPNMCHHOBN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool KHABJCKHCKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x4813A60", Offset = "0x4812060", VA = "0x184813A60", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool CAFEMOGJHAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x4813AD0", Offset = "0x48120D0", VA = "0x184813AD0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool OENLIGGOFLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x4813B40", Offset = "0x4812140", VA = "0x184813B40", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int BDIFLNOPBMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x4814120", Offset = "0x4812720", VA = "0x184814120", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool PKLJBFCHEOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x4813F40", Offset = "0x4812540", VA = "0x184813F40", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool DPHDEEAGBNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x4813C70", Offset = "0x4812270", VA = "0x184813C70", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool MKBALEAEIKK
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x4813C00", Offset = "0x4812200", VA = "0x184813C00", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool MECHICIEFPB
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0xDEDF10", Offset = "0xDEC510", VA = "0x180DEDF10", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0xDEE210", Offset = "0xDEC810", VA = "0x180DEE210")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public virtual bool FKAFFAEIEAE
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual bool MCMFFKLBFLI
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x4813BB0", Offset = "0x48121B0", VA = "0x184813BB0", Slot = "96")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool KAPJNPAODOP
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x4813E70", Offset = "0x4812470", VA = "0x184813E70", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public MMPJAFGCJFL NBIMBFHIDEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x4814060", Offset = "0x4812660", VA = "0x184814060", Slot = "28")]
			get
			{
				return default(MMPJAFGCJFL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public JGKIEDLDOEA DGNKNFBAMNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x48140C0", Offset = "0x48126C0", VA = "0x1848140C0", Slot = "30")]
			get
			{
				return default(JGKIEDLDOEA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool KINHEGKKMLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "108")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual MFJDJJJDGNB? GEOEEICGHNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360", Slot = "109")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual BBBMOIPJCFG? AHOJLAOMAJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360", Slot = "110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual IEnumerable<JEBPJLMNFAK<BKFIMEBJLKC>>? JKMOEEOGOEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool ALCHGFOALAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x4813CE0", Offset = "0x48122E0", VA = "0x184813CE0", Slot = "114")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public JEBPJLMNFAK<IKLMIGOGHKN> AMOEOBKAIDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x4813FA0", Offset = "0x48125A0", VA = "0x184813FA0", Slot = "62")]
			get
			{
				return default(JEBPJLMNFAK<IKLMIGOGHKN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public MJGAEDNBJIL<IKLMIGOGHKN> EPGBOEDHPEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x4813E10", Offset = "0x4812410", VA = "0x184813E10", Slot = "56")]
			get
			{
				return default(MJGAEDNBJIL<IKLMIGOGHKN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public virtual bool EIDDJGDEAPB
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public virtual MJGAEDNBJIL<IKLMIGOGHKN>? EIJBGHMALEG
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public virtual bool DHMDIDJKFCL
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool EMANMPLOAIC
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x4813ED0", Offset = "0x48124D0", VA = "0x184813ED0", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string FHACOBMPENF
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x88D780", Offset = "0x88BD80", VA = "0x18088D780", Slot = "64")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x88D7B0", Offset = "0x88BDB0", VA = "0x18088D7B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		private string IMCENAIAKON
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x88D720", Offset = "0x88BD20", VA = "0x18088D720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public JEBPJLMNFAK<BKFIMEBJLKC> CMGBDIMJDNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x4814000", Offset = "0x4812600", VA = "0x184814000", Slot = "63")]
			get
			{
				return default(JEBPJLMNFAK<BKFIMEBJLKC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public JEBPJLMNFAK<BKFIMEBJLKC>? OEAKIOIIIJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x4814210", Offset = "0x4812810", VA = "0x184814210", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public PMPIHPEBLFA<LPDNCAKIDEG, KBHINEMHBJO> HMKLMMGMCLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x4814300", Offset = "0x4812900", VA = "0x184814300", Slot = "65")]
			get
			{
				return default(PMPIHPEBLFA<LPDNCAKIDEG, KBHINEMHBJO>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public virtual MJGAEDNBJIL<LPDNCAKIDEG>? NCAMHCONKDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public virtual bool KKKMLKCCCEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public virtual bool EFIMENCOCHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "123")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action EOPBENFBCCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x4811820", Offset = "0x480FE20", VA = "0x184811820", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x4813260", Offset = "0x4811860", VA = "0x184813260", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event HJHGLKNOHLG MGPIMFOAKCP
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x4811930", Offset = "0x480FF30", VA = "0x184811930", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x4811070", Offset = "0x480F670", VA = "0x184811070", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event JFIINNCIMID JGCANMKPNCC
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x480F1B0", Offset = "0x480D7B0", VA = "0x18480F1B0", Slot = "41")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x4812360", Offset = "0x4810960", VA = "0x184812360", Slot = "42")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action FCJPACGJMHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x480FED0", Offset = "0x480E4D0", VA = "0x18480FED0", Slot = "43")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x480EF00", Offset = "0x480D500", VA = "0x18480EF00", Slot = "44")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action DKEIAOPCJAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x4812F80", Offset = "0x4811580", VA = "0x184812F80", Slot = "45")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x4813340", Offset = "0x4811940", VA = "0x184813340", Slot = "46")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<MJGAEDNBJIL<LPDNCAKIDEG>, KBHINEMHBJO> AFMDPBIBJOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x4811B50", Offset = "0x4810150", VA = "0x184811B50", Slot = "67")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x480F250", Offset = "0x480D850", VA = "0x18480F250", Slot = "68")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<MJGAEDNBJIL<LPDNCAKIDEG>, KBHINEMHBJO> JDFNPELBONN
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x48120E0", Offset = "0x48106E0", VA = "0x1848120E0", Slot = "71")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x4810FB0", Offset = "0x480F5B0", VA = "0x184810FB0", Slot = "72")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<MJGAEDNBJIL<LPDNCAKIDEG>> PLLNAKPLOND
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x4810100", Offset = "0x480E700", VA = "0x184810100", Slot = "69")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x48108B0", Offset = "0x480EEB0", VA = "0x1848108B0", Slot = "70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<MJGAEDNBJIL<LPDNCAKIDEG>, MJGAEDNBJIL<LPDNCAKIDEG>> FDHGGHKGOOL
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x48131A0", Offset = "0x48117A0", VA = "0x1848131A0", Slot = "73")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x48130E0", Offset = "0x48116E0", VA = "0x1848130E0", Slot = "74")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<MJGAEDNBJIL<LPDNCAKIDEG>, KBHINEMHBJO> LGBGKKIMHJA
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x4810730", Offset = "0x480ED30", VA = "0x184810730", Slot = "75")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x4813020", Offset = "0x4811620", VA = "0x184813020", Slot = "76")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<MJGAEDNBJIL<LPDNCAKIDEG>, MJGAEDNBJIL<LPDNCAKIDEG>> LCDEFGKJLLA
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x4811760", Offset = "0x480FD60", VA = "0x184811760", Slot = "77")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x48107F0", Offset = "0x480EDF0", VA = "0x1848107F0", Slot = "78")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x4813450", Offset = "0x4811A50", VA = "0x184813450")]
		[EMDAHHLEKNJ("Need to handle `Name` better.")]
		[EMDAHHLEKNJ("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		protected OCLPOHGKJMO(PLLOHOJACCG PFCDDIODGEJ, TNode KOHLOCENPAH, bool DILHCPAOMOM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x480E790", Offset = "0x480CD90", VA = "0x18480E790", Slot = "87")]
		protected virtual void AIFHKOLJDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x480F410", Offset = "0x480DA10", VA = "0x18480F410", Slot = "88")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x4810D40", Offset = "0x480F340", VA = "0x184810D40", Slot = "9")]
		[AsyncStateMachine(typeof(OCLPOHGKJMO<>.IMEHJKKPNGG))]
		public void JHFNLBGAHDP(int EDGCIHBIJAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x48133E0", Offset = "0x48119E0", VA = "0x1848133E0")]
		public bool PNNPEGPLMAL([In] MMPJAFGCJFL KLABJGGMBGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x4812940", Offset = "0x4810F40", VA = "0x184812940")]
		public bool MLGGPLBNIAM([In] JGKIEDLDOEA KLABJGGMBGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x480EF60", Offset = "0x480D560", VA = "0x18480EF60", Slot = "32")]
		public void BNDIBOJNCFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x480FD60", Offset = "0x480E360", VA = "0x18480FD60", Slot = "33")]
		[AsyncStateMachine(typeof(OCLPOHGKJMO<>.ODENAMOOKAO))]
		public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> EFLABKMMGGK(MMPJAFGCJFL? OKJIEPLMHFB, JGKIEDLDOEA? IKIABBBCOCB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "97")]
		public virtual void OMBAFJOIBKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "98")]
		public virtual void MFIJCCGEKPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "99")]
		public virtual void KJNNJIFJIPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x8FD050", Offset = "0x8FB650", VA = "0x1808FD050")]
		protected void POGBDEGDKJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x93A960", Offset = "0x938F60", VA = "0x18093A960")]
		protected void KMEPMKFCDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x2289F70", Offset = "0x2288570", VA = "0x182289F70")]
		private void OJAKGHIMGLE([In] JGKIEDLDOEA JOLHFCINNMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x4810970", Offset = "0x480EF70", VA = "0x184810970", Slot = "100")]
		public virtual Task<BCLNLKLFCPB<MJGAEDNBJIL<LPDNCAKIDEG>, OBJIPJOMIPB>> IGIMMPPOEKP(string KJPHMNNIMDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x48101C0", Offset = "0x480E7C0", VA = "0x1848101C0", Slot = "101")]
		public virtual Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> GDGHCBBAPMO(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "102")]
		public virtual void LGEOIJJKPID(MJGAEDNBJIL<LPDNCAKIDEG> OFIFBCLIDAG, MJGAEDNBJIL<LPDNCAKIDEG> BOPFNJMKCAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x48119D0", Offset = "0x480FFD0", VA = "0x1848119D0", Slot = "103")]
		public virtual IEnumerable<EHDCBMKEILE> LOGEDGOLNKD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x4812E70", Offset = "0x4811470", VA = "0x184812E70", Slot = "104")]
		public BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB> NDOGIJKMCFG(string PKFNNBOIFBO)
		{
			return default(BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x4810E60", Offset = "0x480F460", VA = "0x184810E60", Slot = "47")]
		public bool JOJACKJBEBO([Out] Guid JKKNLKJNDCN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x48129B0", Offset = "0x4810FB0", VA = "0x1848129B0")]
		public bool MLLIEEGCAOE([In] Guid CFNEBLLEIOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "105")]
		public virtual void LFBMALNLGLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "106")]
		public virtual void MKNMBIJFOHJ(bool DKEBEIBNODK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360", Slot = "107")]
		public virtual APHPPLLHIBD GIKJONMECFD([In] PEAKBKLICDP MBLMCDCKMLN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x4812C70", Offset = "0x4811270", VA = "0x184812C70")]
		protected void MOJAJOBAHIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x4810290", Offset = "0x480E890", VA = "0x184810290", Slot = "112")]
		protected virtual bool GIBGGBJCBHD(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "113")]
		protected virtual bool EPKFMDJOHBB(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "120")]
		protected virtual void NELGNEIPFJP(PIDEGLEPBNK IHAINNNBNBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x4811110", Offset = "0x480F710", VA = "0x184811110")]
		protected void KEBPEHDCAOK(PIDEGLEPBNK BKLAAIOGBOJ, Func<string> BOKPBGAIDJM, Action<string> BCNNDGOPDBF, string LANGGOBEBLI, string ODLDHCGLFDP, string AGNLDNPJNNH, KDGNCPPBPBH NCGABNOIHDI, EJEDKODBLLB JLFGGAFPEJC, Func<string, bool> HKICHHMINNH, string BNPAJKGGHLA, Func<string, bool> DPFMEGGHAND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x4810A40", Offset = "0x480F040", VA = "0x184810A40")]
		protected void IHLCAMOEKIE(PIDEGLEPBNK BKLAAIOGBOJ, Func<string> BOKPBGAIDJM, Action<string> BCNNDGOPDBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x48121A0", Offset = "0x48107A0", VA = "0x1848121A0", Slot = "121")]
		protected virtual void MJLBLMAELNB(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x48106E0", Offset = "0x480ECE0", VA = "0x1848106E0", Slot = "80")]
		public void GLFGCPILFDC(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x480F310", Offset = "0x480D910", VA = "0x18480F310", Slot = "81")]
		public OMNAEPPNJLF DPJEAFJKAOC()
		{
			return default(OMNAEPPNJLF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "124")]
		public virtual bool IBLEHLFAKBM(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x15DE9E0", Offset = "0x15DCFE0", VA = "0x1815DE9E0")]
		private void OEICGOCAGBB([In] MMPJAFGCJFL LEELMECKGCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x480FFA0", Offset = "0x480E5A0", VA = "0x18480FFA0")]
		private void FHDJLOFCEHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x4812400", Offset = "0x4810A00", VA = "0x184812400")]
		private void MKGDMAIDHMF(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, IJBKFIGEKJK FBANFIMFFGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0xA38CF0", Offset = "0xA372F0", VA = "0x180A38CF0")]
		private void LCGENJKFEFF(MJGAEDNBJIL<LPDNCAKIDEG> MCAKFNPAKIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x48115D0", Offset = "0x480FBD0", VA = "0x1848115D0")]
		private void KIFLFHKIKEB(MJGAEDNBJIL<LPDNCAKIDEG> MCAKFNPAKIL, IJBKFIGEKJK PPCAACPJFDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x4811D30", Offset = "0x4810330", VA = "0x184811D30")]
		private void MHLLLFCLHAD(MJGAEDNBJIL<LPDNCAKIDEG> OFIFBCLIDAG, MJGAEDNBJIL<LPDNCAKIDEG> BOPFNJMKCAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xA39460", Offset = "0xA37A60", VA = "0x180A39460")]
		private void OODNEJFGEMP(MJGAEDNBJIL<LPDNCAKIDEG> OFIFBCLIDAG, MJGAEDNBJIL<LPDNCAKIDEG> BOPFNJMKCAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x480FEB0", Offset = "0x480E4B0", VA = "0x18480FEB0")]
		private void EHCLOMNDJBH(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x48102D0", Offset = "0x480E8D0", VA = "0x1848102D0")]
		private void GIONJIMDBHL(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, IJBKFIGEKJK FBANFIMFFGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x48118C0", Offset = "0x480FEC0", VA = "0x1848118C0")]
		private void LLHEENHONMM(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, IJBKFIGEKJK PPCAACPJFDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x4811C10", Offset = "0x4810210", VA = "0x184811C10", Slot = "125")]
		[AsyncStateMachine(typeof(OCLPOHGKJMO<>.EMDHONGMIPH))]
		public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> MFEMJAMLDJD(string PKFNNBOIFBO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x480FCF0", Offset = "0x480E2F0", VA = "0x18480FCF0", Slot = "54")]
		private void EECMDCKGAOH(object HHGBCMEFNON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x4810DF0", Offset = "0x480F3F0", VA = "0x184810DF0", Slot = "55")]
		private void JNDOJGAGAKN(object HHGBCMEFNON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x4813300", Offset = "0x4811900", VA = "0x184813300", Slot = "29")]
		private bool PAEEDEHCIOA([In] MMPJAFGCJFL KLABJGGMBGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x4812F00", Offset = "0x4811500", VA = "0x184812F00", Slot = "31")]
		private bool NPLLDNBBEMJ([In] JGKIEDLDOEA KLABJGGMBGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x480F170", Offset = "0x480D770", VA = "0x18480F170", Slot = "48")]
		private bool BOENPANLCBD([In] Guid CFNEBLLEIOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x4812F40", Offset = "0x4811540", VA = "0x184812F40")]
		[CompilerGenerated]
		private string OAKLDBDMLFP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x4811520", Offset = "0x480FB20", VA = "0x184811520")]
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
			[Cpp2IlInjected.Address(RVA = "0x12B84F0", Offset = "0x12B6AF0", VA = "0x1812B84F0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x208C5C0", Offset = "0x208ABC0", VA = "0x18208C5C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8FB3E0", Offset = "0x8F99E0", VA = "0x1808FB3E0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x2095660", Offset = "0x2093C60", VA = "0x182095660")]
		public KBNALPBNKGF(PLLOHOJACCG PFCDDIODGEJ, HPJOFAJPFBI KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public AHIHABHPDIF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0")]
			internal IReadOnlyList<KeyValuePair<string, OKCGCELKKAL>> JDPFBIGGGNI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x3DAF820", Offset = "0x3DADE20", VA = "0x183DAF820")]
			internal int MDAPEAKELDK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x3DAF980", Offset = "0x3DADF80", VA = "0x183DAF980")]
			internal void NLOAMKMODOM(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x3DAF710", Offset = "0x3DADD10", VA = "0x183DAF710")]
			internal void IIBCAKFOPMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x3DAF5C0", Offset = "0x3DADBC0", VA = "0x183DAF5C0")]
			internal void IACLJHOBOIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x3DAF480", Offset = "0x3DADA80", VA = "0x183DAF480")]
			internal bool AADPJDPABMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x3DAF570", Offset = "0x3DADB70", VA = "0x183DAF570")]
			internal void BDPDDNLEAGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x3DAF480", Offset = "0x3DADA80", VA = "0x183DAF480")]
			internal bool FICJGAHFHBG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x3DAF7C0", Offset = "0x3DADDC0", VA = "0x183DAF7C0")]
			internal float LBPBDKOKHMB()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x3DAFBA0", Offset = "0x3DAE1A0", VA = "0x183DAFBA0")]
			internal void OGIOFKDKMKL(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x3DAF760", Offset = "0x3DADD60", VA = "0x183DAF760")]
			internal float JHGLEIFOOFC()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x3DAFD20", Offset = "0x3DAE320", VA = "0x183DAFD20")]
			internal void POPLGOOHKOK(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x3DAF510", Offset = "0x3DADB10", VA = "0x183DAF510")]
			internal float AIEJHEIONHE()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x3DAFC60", Offset = "0x3DAE260", VA = "0x183DAFC60")]
			internal void PIANLAOJJDB(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override NodeVisualizationKey PJJDBLNOLBI
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0xA4BF60", Offset = "0xA4A560", VA = "0x180A4BF60", Slot = "91")]
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
		[Cpp2IlInjected.Address(RVA = "0x41C8F00", Offset = "0x41C7500", VA = "0x1841C8F00")]
		public JJMDOICAKMK(PLLOHOJACCG PFCDDIODGEJ, T KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x41C83E0", Offset = "0x41C69E0", VA = "0x1841C83E0", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0xA615B0", Offset = "0xA5FBB0", VA = "0x180A615B0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x209CCC0", Offset = "0x209B2C0", VA = "0x18209CCC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public EIKEHDONPPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x2085E80", Offset = "0x2084480", VA = "0x182085E80")]
			internal int MDAPEAKELDK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x2085ED0", Offset = "0x20844D0", VA = "0x182085ED0")]
			internal void NLOAMKMODOM(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private static Dictionary<string, OKCGCELKKAL>? BCMAFHABNDO;

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x2083E10", Offset = "0x2082410", VA = "0x182083E10")]
		public CBBHDGAKOBC(PLLOHOJACCG PFCDDIODGEJ, GMEDFJAAPDI KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x2083AA0", Offset = "0x20820A0", VA = "0x182083AA0", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360", Slot = "126")]
			get
			{
				return default(KALNDDFHJJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x209C000", Offset = "0x209A600", VA = "0x18209C000")]
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
			[Cpp2IlInjected.Address(RVA = "0x8FB3E0", Offset = "0x8F99E0", VA = "0x1808FB3E0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x2084980", Offset = "0x2082F80", VA = "0x182084980")]
		public DKDGBFMHKMD(PLLOHOJACCG PFCDDIODGEJ, KEEMJMMDAOA KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x8FB3E0", Offset = "0x8F99E0", VA = "0x1808FB3E0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x209C780", Offset = "0x209AD80", VA = "0x18209C780")]
		public NHOIPFBAHJD(PLLOHOJACCG PFCDDIODGEJ, JBABPPHNGJH KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "120")]
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
				[Cpp2IlInjected.Address(RVA = "0x209D3E0", Offset = "0x209B9E0", VA = "0x18209D3E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CC")]
				[Cpp2IlInjected.Address(RVA = "0xB9D680", Offset = "0xB9BC80", VA = "0x180B9D680", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public HGLKOIPLAFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x208E0E0", Offset = "0x208C6E0", VA = "0x18208E0E0")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void MJDFMONDNHO(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x20968E0", Offset = "0x2094EE0", VA = "0x1820968E0")]
		public MAABCAPBJBE(PLLOHOJACCG PFCDDIODGEJ, EGKHPPOGDNE BDPEMHOFOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x2096600", Offset = "0x2094C00", VA = "0x182096600", Slot = "126")]
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
			[Cpp2IlInjected.Address(RVA = "0xA64FD0", Offset = "0xA635D0", VA = "0x180A64FD0", Slot = "126")]
			get
			{
				return default(KALNDDFHJJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x2096530", Offset = "0x2094B30", VA = "0x182096530")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB9FC0", Offset = "0xAB85C0", VA = "0x180AB9FC0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x209CD30", Offset = "0x209B330", VA = "0x18209CD30")]
		public OPBMBHBBBED(PLLOHOJACCG PFCDDIODGEJ, JOHCMGKMFBA KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "120")]
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
			[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public sealed override bool PDCHHCNMNKC
		{
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected sealed override bool HAHGFBEMNBC
		{
			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x208D540", Offset = "0x208BB40", VA = "0x18208D540")]
		public GOBNEBCGEAD(PLLOHOJACCG PFCDDIODGEJ, DFNBCOCAJLL KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x208D210", Offset = "0x208B810", VA = "0x18208D210", Slot = "120")]
		protected override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x208D1D0", Offset = "0x208B7D0", VA = "0x18208D1D0")]
		private int DKNIKKCPFOA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x208D170", Offset = "0x208B770", VA = "0x18208D170")]
		private void ALFEGGKDAMP(int HBEFBGGFFKD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public class LPPPHDHCOEE : OEOAPHDGOOK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x2096590", Offset = "0x2094B90", VA = "0x182096590")]
		public LPPPHDHCOEE(PLLOHOJACCG PFCDDIODGEJ, DPIPCKFLLFL KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "120")]
		protected override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class GONPGHJDBOD : GBMAMGMOMFA<IDPHDPCABAH>
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x208D5B0", Offset = "0x208BBB0", VA = "0x18208D5B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public DMKMJFMICMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x5A6DD70", Offset = "0x5A6C370", VA = "0x185A6DD70")]
			internal bool JDPFBIGGGNI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x5A6DDD0", Offset = "0x5A6C3D0", VA = "0x185A6DDD0")]
			internal void MDAPEAKELDK(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x5A6DE90", Offset = "0x5A6C490", VA = "0x185A6DE90")]
			internal bool NLOAMKMODOM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x5A6DCB0", Offset = "0x5A6C2B0", VA = "0x185A6DCB0")]
			internal void IIBCAKFOPMO(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x5A6DC00", Offset = "0x5A6C200", VA = "0x185A6DC00")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public OMMKAPHFCMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x48343A0", Offset = "0x48329A0", VA = "0x1848343A0")]
			internal void MJDFMONDNHO(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public override NodeVisualizationKey PJJDBLNOLBI
		{
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0xC2CE40", Offset = "0xC2B440", VA = "0x180C2CE40", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public override GFPNMCHHOBN LKOINDAEEGC
		{
			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x3DDB3D0", Offset = "0x3DD99D0", VA = "0x183DDB3D0", Slot = "94")]
			get
			{
				return default(GFPNMCHHOBN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x3DDB220", Offset = "0x3DD9820", VA = "0x183DDB220")]
		protected GBMAMGMOMFA(PLLOHOJACCG PFCDDIODGEJ, TVariableNode KOHLOCENPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x3DDA730", Offset = "0x3DD8D30", VA = "0x183DDA730", Slot = "88")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x3DDAD70", Offset = "0x3DD9370", VA = "0x183DDAD70", Slot = "120")]
		protected override void NELGNEIPFJP(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x3DDA9D0", Offset = "0x3DD8FD0", VA = "0x183DDA9D0", Slot = "126")]
		protected virtual void MIIEKGIGHCK(PIDEGLEPBNK BKLAAIOGBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x3DDA8D0", Offset = "0x3DD8ED0", VA = "0x183DDA8D0", Slot = "105")]
		public override void LFBMALNLGLI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x206FBB0", Offset = "0x206E1B0", VA = "0x18206FBB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xB4A4C0", Offset = "0xB48AC0", VA = "0x180B4A4C0", Slot = "24")]
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
		[Cpp2IlInjected.Address(RVA = "0x139C460", Offset = "0x139AA60", VA = "0x18139C460", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(MJGAEDNBJIL<DGNIMDELLGK>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x208DDE0", Offset = "0x208C3E0", VA = "0x18208DDE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private MJGAEDNBJIL<OMDILHJFPPO> KIDLCLOLIMD
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x9089E0", Offset = "0x906FE0", VA = "0x1809089E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public override MJGAEDNBJIL<NPLAKCHMMBM> CNGHGJOOHPB
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x208DA40", Offset = "0x208C040", VA = "0x18208DA40", Slot = "20")]
		get
		{
			return default(MJGAEDNBJIL<NPLAKCHMMBM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x208DDF0", Offset = "0x208C3F0", VA = "0x18208DDF0")]
	private HFDOABPFDJP(PLLOHOJACCG PFCDDIODGEJ, DPIPCKFLLFL KOHLOCENPAH, OFFKAKEFONL OMLHNDEIDDO, MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, MJGAEDNBJIL<DGNIMDELLGK> GNAGOFFMLAD, MJGAEDNBJIL<OMDILHJFPPO> DPNCALJCMOD, bool BNKGOGLKMMD, string KJPHMNNIMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x208DA90", Offset = "0x208C090", VA = "0x18208DA90")]
	public static HFDOABPFDJP GGBAHLJJLHO(PLLOHOJACCG PFCDDIODGEJ, DPIPCKFLLFL KOHLOCENPAH, OFFKAKEFONL CEMLELOFBNI, MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, MJGAEDNBJIL<OMDILHJFPPO> DPNCALJCMOD, MJGAEDNBJIL<DGNIMDELLGK> GNAGOFFMLAD, bool BNKGOGLKMMD, bool DILHCPAOMOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x208DDE0", Offset = "0x208C3E0", VA = "0x18208DDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x209D3D0", Offset = "0x209B9D0", VA = "0x18209D3D0")]
		public void MPAAPCHGDCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x209D330", Offset = "0x209B930", VA = "0x18209D330")]
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
		[Cpp2IlInjected.Address(RVA = "0x20915A0", Offset = "0x208FBA0", VA = "0x1820915A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public DisplayKind KBJMIBHHLLA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x895290", Offset = "0x893890", VA = "0x180895290", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2092360", Offset = "0x2090960", VA = "0x182092360", Slot = "6")]
		get
		{
			return default(MJGAEDNBJIL<IKLMIGOGHKN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public JEBPJLMNFAK<IKLMIGOGHKN> AMOEOBKAIDA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x20919C0", Offset = "0x208FFC0", VA = "0x1820919C0", Slot = "7")]
		get
		{
			return default(JEBPJLMNFAK<IKLMIGOGHKN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public DHDNLKJCEHP JNAGBMCOMED
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x1E0C480", Offset = "0x1E0AA80", VA = "0x181E0C480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public JJKCEJGCFAL BPNOLPGAEEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x20922C0", Offset = "0x20908C0", VA = "0x1820922C0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	protected OCDCOPCGBAN HGKABLOGPIA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x20922C0", Offset = "0x20908C0", VA = "0x1820922C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public PortImage NNHCMAGNPAD
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x20916E0", Offset = "0x208FCE0", VA = "0x1820916E0", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public string FHACOBMPENF
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x887850", Offset = "0x885E50", VA = "0x180887850", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x8879D0", Offset = "0x885FD0", VA = "0x1808879D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public JEBPJLMNFAK<BKFIMEBJLKC> CMGBDIMJDNN
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x20913D0", Offset = "0x208F9D0", VA = "0x1820913D0", Slot = "9")]
		get
		{
			return default(JEBPJLMNFAK<BKFIMEBJLKC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public MJGAEDNBJIL<LPDNCAKIDEG> LOMGPGLPEKK
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xBE94A0", Offset = "0xBE7AA0", VA = "0x180BE94A0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(MJGAEDNBJIL<LPDNCAKIDEG>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x1033A90", Offset = "0x1032090", VA = "0x181033A90")]
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
	[Cpp2IlInjected.Address(RVA = "0x20925C0", Offset = "0x2090BC0", VA = "0x1820925C0")]
	protected IBDEEOHCPBI(PLLOHOJACCG PFCDDIODGEJ, DPIPCKFLLFL KOHLOCENPAH, ACDJLCJFCDP EHGIOJOEILB, MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, bool BNKGOGLKMMD, string KJPHMNNIMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x2091280", Offset = "0x208F880", VA = "0x182091280", Slot = "21")]
	protected virtual void AIFHKOLJDOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x2091450", Offset = "0x208FA50", VA = "0x182091450", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x2092260", Offset = "0x2090860", VA = "0x182092260", Slot = "14")]
	public void KIJCPECGBHG(LBGKMAHDCBD MMPLGKEGKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x2091220", Offset = "0x208F820", VA = "0x182091220", Slot = "15")]
	public void ADALEBMOFDI(PLDOCOGHMKI MMPLGKEGKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x20919F0", Offset = "0x208FFF0", VA = "0x1820919F0", Slot = "16")]
	public void HJBEPEMMNKJ(APDFNBBFBPM AILIAJMFOGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x20913F0", Offset = "0x208F9F0", VA = "0x1820913F0", Slot = "23")]
	protected virtual void BPECPKLMPPL(APDFNBBFBPM AILIAJMFOGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x20920D0", Offset = "0x20906D0", VA = "0x1820920D0")]
	private void JKDEIJLGPMO(bool MNKBAIOBLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x2091810", Offset = "0x208FE10", VA = "0x182091810")]
	private void FGJEEIJIFCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x20923B0", Offset = "0x20909B0", VA = "0x1820923B0")]
	private void PFBELNCOIMB([In] HAJDAJIIABF PBDJJGLJIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x2092070", Offset = "0x2090670", VA = "0x182092070", Slot = "17")]
	public void JAHKMPGMEHN(LBGKMAHDCBD MMPLGKEGKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x2092560", Offset = "0x2090B60", VA = "0x182092560", Slot = "18")]
	public void PNEPBBBIBFH(PLDOCOGHMKI MMPLGKEGKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x8879D0", Offset = "0x885FD0", VA = "0x1808879D0")]
	internal void DNFMFIPIFBD(string KJPHMNNIMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x2092390", Offset = "0x2090990", VA = "0x182092390")]
	internal void PBMIGOBKGGO(IJOLNGCBMAE LAKCFHGOLJA, DHDNLKJCEHP JLAAKHANEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x1033A90", Offset = "0x1032090", VA = "0x181033A90")]
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
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public MGKJIGEPCPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x2096940", Offset = "0x2094F40", VA = "0x182096940")]
		internal GIIGAKOBIAH LIGBFNEELPJ((int PortDescIndex, int PortIndex, PJDJGGGLFDB InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x20969D0", Offset = "0x2094FD0", VA = "0x1820969D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x20834D0", Offset = "0x2081AD0", VA = "0x1820834D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x2083930", Offset = "0x2081F30", VA = "0x182083930", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x20952A0", Offset = "0x20938A0", VA = "0x1820952A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x20955F0", Offset = "0x2093BF0", VA = "0x1820955F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x208ED00", Offset = "0x208D300", VA = "0x18208ED00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x208F050", Offset = "0x208D650", VA = "0x18208F050", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2094080", Offset = "0x2092680", VA = "0x182094080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x20943D0", Offset = "0x20929D0", VA = "0x1820943D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x20842C0", Offset = "0x20828C0", VA = "0x1820842C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x2084610", Offset = "0x2082C10", VA = "0x182084610", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x209C7E0", Offset = "0x209ADE0", VA = "0x18209C7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x209CC50", Offset = "0x209B250", VA = "0x18209CC50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2092E40", Offset = "0x2091440", VA = "0x182092E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x2093190", Offset = "0x2091790", VA = "0x182093190", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x208C830", Offset = "0x208AE30", VA = "0x18208C830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x208CB80", Offset = "0x208B180", VA = "0x18208CB80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2093220", Offset = "0x2091820", VA = "0x182093220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x2093570", Offset = "0x2091B70", VA = "0x182093570", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2085A80", Offset = "0x2084080", VA = "0x182085A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x2085E10", Offset = "0x2084410", VA = "0x182085E10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x209C060", Offset = "0x209A660", VA = "0x18209C060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x209C3F0", Offset = "0x209A9F0", VA = "0x18209C3F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2086930", Offset = "0x2084F30", VA = "0x182086930", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool CKOAFFDLDKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x20869F0", Offset = "0x2084FF0", VA = "0x1820869F0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool CAPODAAAJFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x2089690", Offset = "0x2087C90", VA = "0x182089690", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public JEBPJLMNFAK<IKLMIGOGHKN> AMOEOBKAIDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x2089000", Offset = "0x2087600", VA = "0x182089000", Slot = "7")]
		get
		{
			return default(JEBPJLMNFAK<IKLMIGOGHKN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool GMAAHFHIJEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x2087C50", Offset = "0x2086250", VA = "0x182087C50", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public PMPIHPEBLFA<EMOBFLMBFFJ, PGALABIFJNM> AIPKONCGFJB
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x8879A0", Offset = "0x885FA0", VA = "0x1808879A0", Slot = "9")]
		get
		{
			return default(PMPIHPEBLFA<EMOBFLMBFFJ, PGALABIFJNM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public string FHACOBMPENF
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x208A200", Offset = "0x2088800", VA = "0x18208A200", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public JEBPJLMNFAK<BKFIMEBJLKC> CMGBDIMJDNN
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x2086910", Offset = "0x2084F10", VA = "0x182086910", Slot = "11")]
		get
		{
			return default(JEBPJLMNFAK<BKFIMEBJLKC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public PMPIHPEBLFA<DGNIMDELLGK, HDDFAAMLDIO> JHNBGHCPAMF
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x887850", Offset = "0x885E50", VA = "0x180887850", Slot = "12")]
		get
		{
			return default(PMPIHPEBLFA<DGNIMDELLGK, HDDFAAMLDIO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public MJGAEDNBJIL<LPDNCAKIDEG> LOMGPGLPEKK
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x9099E0", Offset = "0x907FE0", VA = "0x1809099E0", Slot = "13")]
		get
		{
			return default(MJGAEDNBJIL<LPDNCAKIDEG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action DLCMNHKJFGB
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x2089440", Offset = "0x2087A40", VA = "0x182089440", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x2089FD0", Offset = "0x20885D0", VA = "0x182089FD0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action PBEHCJNFIMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x208AF40", Offset = "0x2089540", VA = "0x18208AF40", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x2089750", Offset = "0x2087D50", VA = "0x182089750", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<MJGAEDNBJIL<EMOBFLMBFFJ>, MJGAEDNBJIL<EMOBFLMBFFJ>> OJNGKPEEMNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x2089160", Offset = "0x2087760", VA = "0x182089160", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x208B7D0", Offset = "0x2089DD0", VA = "0x18208B7D0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<MJGAEDNBJIL<EMOBFLMBFFJ>, MJGAEDNBJIL<EMOBFLMBFFJ>> KAICILHMIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x2087B90", Offset = "0x2086190", VA = "0x182087B90", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x208B500", Offset = "0x2089B00", VA = "0x18208B500", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<MJGAEDNBJIL<DGNIMDELLGK>, MJGAEDNBJIL<DGNIMDELLGK>> EIKBBBCHKBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x2089E50", Offset = "0x2088450", VA = "0x182089E50", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x208A230", Offset = "0x2088830", VA = "0x18208A230", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<MJGAEDNBJIL<DGNIMDELLGK>, MJGAEDNBJIL<DGNIMDELLGK>> EPBMECEANLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x208A550", Offset = "0x2088B50", VA = "0x18208A550", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x208A490", Offset = "0x2088A90", VA = "0x18208A490", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<MJGAEDNBJIL<EMOBFLMBFFJ>, PGALABIFJNM> FLDHCHODLBI
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x20894E0", Offset = "0x2087AE0", VA = "0x1820894E0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x2088420", Offset = "0x2086A20", VA = "0x182088420", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<MJGAEDNBJIL<EMOBFLMBFFJ>> FEECFMDMKBF
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x208B890", Offset = "0x2089E90", VA = "0x18208B890", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x2086C70", Offset = "0x2085270", VA = "0x182086C70", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<MJGAEDNBJIL<EMOBFLMBFFJ>, PGALABIFJNM> HAJIIKMKFIM
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x208A3D0", Offset = "0x20889D0", VA = "0x18208A3D0", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x2089F10", Offset = "0x2088510", VA = "0x182089F10", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<MJGAEDNBJIL<DGNIMDELLGK>, HDDFAAMLDIO> ALHJAHNNJGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x20884E0", Offset = "0x2086AE0", VA = "0x1820884E0", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x208AFF0", Offset = "0x20895F0", VA = "0x18208AFF0", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<MJGAEDNBJIL<DGNIMDELLGK>> HIFJMCHBNCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x208A2F0", Offset = "0x20888F0", VA = "0x18208A2F0", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x2085F60", Offset = "0x2084560", VA = "0x182085F60", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<MJGAEDNBJIL<DGNIMDELLGK>, HDDFAAMLDIO> MCDKHMJHLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x2088360", Offset = "0x2086960", VA = "0x182088360", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x208A9B0", Offset = "0x2088FB0", VA = "0x18208A9B0", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x208BE40", Offset = "0x208A440", VA = "0x18208BE40")]
	private FAADKMCMNDL(bool BNKGOGLKMMD, PLLOHOJACCG PFCDDIODGEJ, bool GINMEHCIOLM, PMPIHPEBLFA<EMOBFLMBFFJ, GIIGAKOBIAH> DAMPHGNICNC, PMPIHPEBLFA<EMOBFLMBFFJ, PGALABIFJNM> CEEHGBMKHMK, DPIPCKFLLFL KOHLOCENPAH, PMPIHPEBLFA<DGNIMDELLGK, HFDOABPFDJP> FPLMDJDONEI, PMPIHPEBLFA<DGNIMDELLGK, HDDFAAMLDIO> MGJNMNKEALC, string? DENGFKIGILM, IJBKFIGEKJK FBANFIMFFGD, MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, bool DILHCPAOMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x2088940", Offset = "0x2086F40", VA = "0x182088940")]
	public static FAADKMCMNDL GGBAHLJJLHO(bool BNKGOGLKMMD, PLLOHOJACCG PFCDDIODGEJ, bool GINMEHCIOLM, DPIPCKFLLFL KOHLOCENPAH, IJBKFIGEKJK FBANFIMFFGD, MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, bool DILHCPAOMOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x2086020", Offset = "0x2084620", VA = "0x182086020")]
	private void AIFHKOLJDOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x2086D30", Offset = "0x2085330", VA = "0x182086D30", Slot = "49")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x2086B80", Offset = "0x2085180", VA = "0x182086B80", Slot = "38")]
	[AsyncStateMachine(typeof(BFGHAAKHIAO))]
	public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> DDIEGLFIKIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x2087850", Offset = "0x2085E50", VA = "0x182087850")]
	private (MFHKGAOPKGJ, int)? EFOIGPIJALB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x2089220", Offset = "0x2087820", VA = "0x182089220")]
	private void HHBIJHJBHNK(int GMCOMKJLDIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x1637B50", Offset = "0x1636150", VA = "0x181637B50")]
	private void FEPOENJFHGH(int GMCOMKJLDIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x20885A0", Offset = "0x2086BA0", VA = "0x1820885A0")]
	private void GAMLICMALGP(int CDBKHGLBCII, int CFHANJCKHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x208AEE0", Offset = "0x20894E0", VA = "0x18208AEE0")]
	private void MFOECCDFIGO(int CDBKHGLBCII, int CFHANJCKHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x2087E20", Offset = "0x2086420", VA = "0x182087E20")]
	private void FIBFMMDGHOH(int GMCOMKJLDIL, MJGAEDNBJIL<EMOBFLMBFFJ> GADCMKPLHKE, PJDJGGGLFDB FDIIPKGGJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x20868F0", Offset = "0x2084EF0", VA = "0x1820868F0")]
	private void BJPJALFFIOJ(int MNKBAIOBLHC, MJGAEDNBJIL<EMOBFLMBFFJ> GADCMKPLHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x208A3B0", Offset = "0x20889B0", VA = "0x18208A3B0")]
	private void LMEDOPOPMMN(int MNKBAIOBLHC, MJGAEDNBJIL<EMOBFLMBFFJ> GADCMKPLHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x208B0B0", Offset = "0x20896B0", VA = "0x18208B0B0")]
	private void NHOPGPNAAEF(int GMCOMKJLDIL, MJGAEDNBJIL<EMOBFLMBFFJ> GADCMKPLHKE, PJDJGGGLFDB FDIIPKGGJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x2086A30", Offset = "0x2085030", VA = "0x182086A30")]
	private void DCMLLIBKNJB(int GMCOMKJLDIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0xC65250", Offset = "0xC63850", VA = "0x180C65250")]
	private void OFCFGOANNIG(int GMCOMKJLDIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x208B6E0", Offset = "0x2089CE0", VA = "0x18208B6E0")]
	private void NOEABLGNCLJ(int GMCOMKJLDIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x1637B50", Offset = "0x1636150", VA = "0x181637B50")]
	private void OBCLPBAEJNN(int GMCOMKJLDIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x208A610", Offset = "0x2088C10", VA = "0x18208A610")]
	private void MADOBHMELPM(int CDBKHGLBCII, int CFHANJCKHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x208A070", Offset = "0x2088670", VA = "0x18208A070")]
	private void KBCJPAPJLJC(int CDBKHGLBCII, int CFHANJCKHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x2089800", Offset = "0x2087E00", VA = "0x182089800")]
	private void JDFCKNNLKOB(int GMCOMKJLDIL, MJGAEDNBJIL<DGNIMDELLGK> GADCMKPLHKE, OFFKAKEFONL FDIIPKGGJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x2088FE0", Offset = "0x20875E0", VA = "0x182088FE0")]
	private void GHGCMFINPPD(int MNKBAIOBLHC, MJGAEDNBJIL<DGNIMDELLGK> GADCMKPLHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x2087830", Offset = "0x2085E30", VA = "0x182087830")]
	private void EDPDOOMFIHK(int MNKBAIOBLHC, MJGAEDNBJIL<DGNIMDELLGK> GADCMKPLHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x208AA70", Offset = "0x2089070", VA = "0x18208AA70")]
	private void MEEAJHMNOJP(int GMCOMKJLDIL, MJGAEDNBJIL<DGNIMDELLGK> GADCMKPLHKE, OFFKAKEFONL FDIIPKGGJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x2087CD0", Offset = "0x20862D0", VA = "0x182087CD0")]
	private void FEHIBJFBOPM(int GMCOMKJLDIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0xC65250", Offset = "0xC63850", VA = "0x180C65250")]
	private void ACPFLBCBAOM(int GMCOMKJLDIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x2087A80", Offset = "0x2086080", VA = "0x182087A80", Slot = "39")]
	[AsyncStateMachine(typeof(JNBEJLJEDBE))]
	public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> EIBPGDLBMCK(MJGAEDNBJIL<DDABHKCABNE> IINCKHAMMKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x2089D40", Offset = "0x2088340", VA = "0x182089D40", Slot = "40")]
	[AsyncStateMachine(typeof(HOPEKNLDDED))]
	public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> JEJHOBENKPI(MJGAEDNBJIL<OMDILHJFPPO> DPNCALJCMOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x208B5C0", Offset = "0x2089BC0", VA = "0x18208B5C0", Slot = "41")]
	[AsyncStateMachine(typeof(JDCALIILJEI))]
	public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> NIOFGJLKHLP(MJGAEDNBJIL<DDABHKCABNE> IINCKHAMMKN, MJGAEDNBJIL<DDABHKCABNE> CMFOHNEPANN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x208BD20", Offset = "0x208A320", VA = "0x18208BD20", Slot = "42")]
	[AsyncStateMachine(typeof(DFAALCHAOMP))]
	public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> PFIJIKDEDLG(MJGAEDNBJIL<OMDILHJFPPO> DPNCALJCMOD, MJGAEDNBJIL<OMDILHJFPPO> CMFOHNEPANN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x20895A0", Offset = "0x2087BA0", VA = "0x1820895A0", Slot = "43")]
	[AsyncStateMachine(typeof(NJCCKONLDAO))]
	public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> HNGELCDDJJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x20867D0", Offset = "0x2084DD0", VA = "0x1820867D0", Slot = "44")]
	[AsyncStateMachine(typeof(IEJBLLMLPML))]
	public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> ANIDHOIOCPF(string PKFNNBOIFBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x2088EB0", Offset = "0x20874B0", VA = "0x182088EB0", Slot = "45")]
	[AsyncStateMachine(typeof(GFOBKFCFEJL))]
	public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> GHELCLKCPAM(MJGAEDNBJIL<DDABHKCABNE> IINCKHAMMKN, string KJPHMNNIMDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x2089030", Offset = "0x2087630", VA = "0x182089030", Slot = "46")]
	[AsyncStateMachine(typeof(ILLKNBHKALA))]
	public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> GOHOKGCDKIN(MJGAEDNBJIL<OMDILHJFPPO> DPNCALJCMOD, string KJPHMNNIMDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x2089310", Offset = "0x2087910", VA = "0x182089310", Slot = "47")]
	[AsyncStateMachine(typeof(EHJIIGPDKPA))]
	public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> HIBEHFKHPBO(MJGAEDNBJIL<DDABHKCABNE> IINCKHAMMKN, BLDEJALINAE JLAAKHANEHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x208A0D0", Offset = "0x20886D0", VA = "0x18208A0D0", Slot = "48")]
	[AsyncStateMachine(typeof(NDLCFMHBHCK))]
	public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> KBCNJMFKNEO(MJGAEDNBJIL<OMDILHJFPPO> DPNCALJCMOD, BLDEJALINAE JLAAKHANEHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x208B950", Offset = "0x2089F50", VA = "0x18208B950")]
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
		[Cpp2IlInjected.Address(RVA = "0x20935E0", Offset = "0x2091BE0", VA = "0x1820935E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x2094010", Offset = "0x2092610", VA = "0x182094010", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x8842A0", Offset = "0x8828A0", VA = "0x1808842A0")]
	private FHMGLGJBBAM(JKIEPPIEFOF BIHLLCENOEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x208C060", Offset = "0x208A660", VA = "0x18208C060")]
	[AsyncStateMachine(typeof(JCNCGMPMNGE))]
	public static Task<FHMGLGJBBAM> BHOHJJOHHJH(PLLOHOJACCG PFCDDIODGEJ, FAOKMGJAJIO? LLAPGPIJJLB, PIKJJPNAMNM? FFHNFKPFGJK, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x208C1C0", Offset = "0x208A7C0", VA = "0x18208C1C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2084680", Offset = "0x2082C80", VA = "0x182084680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x2084910", Offset = "0x2082F10", VA = "0x182084910", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x208F0C0", Offset = "0x208D6C0", VA = "0x18208F0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x208F4A0", Offset = "0x208DAA0", VA = "0x18208F4A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2084F20", Offset = "0x2083520", VA = "0x182084F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x2085160", Offset = "0x2083760", VA = "0x182085160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private readonly HINPPEJFHLF EMGMPHENKKE;

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0xAB30F0", Offset = "0xAB16F0", VA = "0x180AB30F0")]
	public PIPALGAAPKG(HINPPEJFHLF NIHEKDKBACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x209D140", Offset = "0x209B740", VA = "0x18209D140")]
	[AsyncStateMachine(typeof(DJOKLNPILBK))]
	private Task<BCLNLKLFCPB<object, OBJIPJOMIPB>> OLJLEKCKCBG(EHDCBMKEILE PMCMEAHOBEF, bool ODAOKKACEAL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x209CFE0", Offset = "0x209B5E0", VA = "0x18209CFE0")]
	[AsyncStateMachine(typeof(IAAAKEEDCGP))]
	public Task<BCLNLKLFCPB<bool, OBJIPJOMIPB?>>? DJFAKNFBIPP(int CPBJHCINKCL, FMGJMILCPFK? NCIIFBLDHLJ, FAOKMGJAJIO? BDKIHOIIFHL, PIKJJPNAMNM? FFHNFKPFGJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x209CEF0", Offset = "0x209B4F0", VA = "0x18209CEF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x8842A0", Offset = "0x8828A0", VA = "0x1808842A0")]
	private KJKEFKBJBBJ(FEOAEBCGMMG IKPEEHDBICN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x2095BE0", Offset = "0x20941E0", VA = "0x182095BE0")]
	public static KJKEFKBJBBJ CENBFOHJAFB(PLLOHOJACCG PFCDDIODGEJ, FMGJMILCPFK LACCAKBFKMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x2095DE0", Offset = "0x20943E0", VA = "0x182095DE0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x209BAE0", Offset = "0x209A0E0", VA = "0x18209BAE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2093200", Offset = "0x2091800", VA = "0x182093200", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x8842A0", Offset = "0x8828A0", VA = "0x1808842A0")]
	internal IIHNNAADMDI(PLLOHOJACCG PFCDDIODGEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal sealed class ADNIMPJIPFG : GGMNELLKHNA
{
	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x2083200", Offset = "0x2081800", VA = "0x182083200", Slot = "4")]
	public IDMADOIMLCK? LNHEAHPDNGC(string? BDPJHMFKLHB, string? FHBJDDJPGCN, string? GBMLAKNHIAH, MNHGJPAIKMN.AABAGDNJGOP.KAJKCJHGCCP DNBMEOIOPNK, bool DJDNBNJODKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x208C1E0", Offset = "0x208A7E0", VA = "0x18208C1E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x208C490", Offset = "0x208AA90", VA = "0x18208C490", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2082EA0", Offset = "0x20814A0", VA = "0x182082EA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public MJECCAEPCJM? BLHOJGLAPBG
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x2083180", Offset = "0x2081780", VA = "0x182083180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool LMODGIMHBDF
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x2082E40", Offset = "0x2081440", VA = "0x182082E40", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool DGNEAAFINPD
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x2083120", Offset = "0x2081720", VA = "0x182083120", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x8842A0", Offset = "0x8828A0", VA = "0x1808842A0")]
	internal ABHABACPDFJ(PLLOHOJACCG PFCDDIODGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x2082D50", Offset = "0x2081350", VA = "0x182082D50", Slot = "7")]
	[AsyncStateMachine(typeof(FLGCEEFOAOP))]
	public Task<JLECLAOCGDF> BPCAKOAKKLF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x20827E0", Offset = "0x2080DE0", VA = "0x1820827E0", Slot = "9")]
	public IReadOnlyDictionary<JEBPJLMNFAK<IKLMIGOGHKN>, Guid> AAMMPBOJJDG(IEnumerable<GIFFLNOJBNJ> OBCKGJINPFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x2082B50", Offset = "0x2081150", VA = "0x182082B50")]
	public BCLNLKLFCPB<AFGHPFDMMAF, JHLAIJINHDF> AHCNILAINDE([In] AFGHPFDMMAF HMMNNEKGDKN, IEnumerable<GIFFLNOJBNJ> PCMPKHGEFMC, int KOGAEFGIJII)
	{
		return default(BCLNLKLFCPB<AFGHPFDMMAF, JHLAIJINHDF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x2082F20", Offset = "0x2081520", VA = "0x182082F20", Slot = "8")]
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

			[Cpp2IlInjected.Token(Token = "0x60004F7")]
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public PDLOCLGMGMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F8")]
			[Cpp2IlInjected.Address(RVA = "0x209CDA0", Offset = "0x209B3A0", VA = "0x18209CDA0")]
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

			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public CABDCENKNNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0x2083A80", Offset = "0x2082080", VA = "0x182083A80")]
			internal void FHIFMKPEMFK(HFBMPHDALGE n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x208F950", Offset = "0x208DF50", VA = "0x18208F950")]
		public static BCLNLKLFCPB<JLECLAOCGDF.MFDFCMAOJHA, HAGOHGINEAC> CKOMBPKHALD(MJECCAEPCJM BJNJBGHPMEH, [In] JLECLAOCGDF.EAAKCLDHMON AAAOIGBEBAB)
		{
			return default(BCLNLKLFCPB<JLECLAOCGDF.MFDFCMAOJHA, HAGOHGINEAC>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x208FF10", Offset = "0x208E510", VA = "0x18208FF10")]
		internal static BCLNLKLFCPB<(HLELOJACBNG, BCOPDAFELLH), HAGOHGINEAC> JODPGKACHDD(MJECCAEPCJM BJNJBGHPMEH, BCOPDAFELLH FCLKPHKBHBH, bool BHMHOHKJJPC, [In] JEBPJLMNFAK<IKLMIGOGHKN> OALDCHIBHJA, [In] int? JKGKBINKIGN, [In] OMNAEPPNJLF? MBNFAMFHLMM, [In] OMNAEPPNJLF? NAEEJPBDHCH)
		{
			return default(BCLNLKLFCPB<(HLELOJACBNG, BCOPDAFELLH), HAGOHGINEAC>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x208F510", Offset = "0x208DB10", VA = "0x18208F510")]
		private static void AIDGFAKOKOJ(bool BHMHOHKJJPC, GIFFLNOJBNJ LBLEGAGFFHC, HLELOJACBNG PKLCJCEHAPB, [In] JEBPJLMNFAK<IKLMIGOGHKN> OALDCHIBHJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x2090E10", Offset = "0x208F410", VA = "0x182090E10")]
		public static void OBMINBHPEKP(GILAJLCEBJH LFDKENDMAKA, [In] JLECLAOCGDF.PEGDBMENCKH BGEAECOGHGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x2090D20", Offset = "0x208F320", VA = "0x182090D20")]
		[CompilerGenerated]
		internal static bool KPDJIFPHIND(JKIEPPIEFOF AJCFNMLFIJH, KBEFAFEHDLK CIIBBHEOJMH, HFBMPHDALGE CDONBLNAEPH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x208FEE0", Offset = "0x208E4E0", VA = "0x18208FEE0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x2092720", Offset = "0x2090D20", VA = "0x182092720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x2092D70", Offset = "0x2091370", VA = "0x182092D70", Slot = "5")]
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

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x2094EF0", Offset = "0x20934F0", VA = "0x182094EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x2095230", Offset = "0x2093830", VA = "0x182095230", Slot = "5")]
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

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x209EF40", Offset = "0x209D540", VA = "0x18209EF40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x209F280", Offset = "0x209D880", VA = "0x18209F280", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x209A490", Offset = "0x2098A90", VA = "0x18209A490", Slot = "4")]
		get
		{
			return default(JEBPJLMNFAK<IKLMIGOGHKN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public CFPOLMBGNDM IFFMNDEICEL
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x207F7C0", Offset = "0x207DDC0", VA = "0x18207F7C0", Slot = "5")]
		get
		{
			return default(CFPOLMBGNDM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x209B5C0", Offset = "0x2099BC0", VA = "0x18209B5C0")]
	public MJECCAEPCJM(PLLOHOJACCG PFCDDIODGEJ, HDGDOAHDBCE HNFHGIGGGHI, HBPBPJMDAIL GLCGEFKKFIJ, ABHABACPDFJ JBFBEAMBAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x2097350", Offset = "0x2095950", VA = "0x182097350", Slot = "46")]
	public MJGAEDNBJIL<KHHNPHAINJN> BHGLCEPALBF(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<OIEHBMHNIBK> JJHCIBLPKAD)
	{
		return default(MJGAEDNBJIL<KHHNPHAINJN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x2098570", Offset = "0x2096B70", VA = "0x182098570", Slot = "47")]
	public MJGAEDNBJIL<JHLLNBLCELC> GDIGDCDJMBD(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<POKJECOIACH> GNAGOFFMLAD)
	{
		return default(MJGAEDNBJIL<JHLLNBLCELC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x209A680", Offset = "0x2098C80", VA = "0x18209A680", Slot = "6")]
	public (bool, bool) NIAPECOFDML(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<POKJECOIACH> FNCFKKIMIIP, MJGAEDNBJIL<OIEHBMHNIBK> HOHFLCBELHH)
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x2097C90", Offset = "0x2096290", VA = "0x182097C90")]
	public bool EAGCCHJDEKG(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, [In] DNHHGMCCKDA FJOJNJJLGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x20994F0", Offset = "0x2097AF0", VA = "0x1820994F0", Slot = "8")]
	public bool IFIMNFLIONH(PGALABIFJNM PAPOIHIFOHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x20979B0", Offset = "0x2095FB0", VA = "0x1820979B0", Slot = "9")]
	public bool DLBBEJPMMIC(HDDFAAMLDIO IPNLOKGCFLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x2098440", Offset = "0x2096A40", VA = "0x182098440", Slot = "10")]
	public IEnumerable<MJGAEDNBJIL<OGIDDDCEPIG>> FHPFFHFJHIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x209A420", Offset = "0x2098A20", VA = "0x18209A420", Slot = "11")]
	public string MBDEEEHGEOE(MJGAEDNBJIL<OGIDDDCEPIG> PGMHDMOFOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x2099B40", Offset = "0x2098140", VA = "0x182099B40", Slot = "12")]
	public string KOPOGEGEMBC(MJGAEDNBJIL<OGIDDDCEPIG> PGMHDMOFOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x209A1A0", Offset = "0x20987A0", VA = "0x18209A1A0")]
	public KJBJNDHGBLH? LGEIFNDJCDD([In] JEBPJLMNFAK<BKFIMEBJLKC> JJLNKABMPOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x20984F0", Offset = "0x2096AF0", VA = "0x1820984F0")]
	public MJGAEDNBJIL<BKFIMEBJLKC> LAGHACBIDPB(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, [In] JEBPJLMNFAK<BKFIMEBJLKC> OPGPKNHCAJL)
	{
		return default(MJGAEDNBJIL<BKFIMEBJLKC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x209B4C0", Offset = "0x2099AC0", VA = "0x18209B4C0", Slot = "24")]
	public MJGAEDNBJIL<BKFIMEBJLKC> PLAHAPNONIF(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<OIEHBMHNIBK> JJHCIBLPKAD)
	{
		return default(MJGAEDNBJIL<BKFIMEBJLKC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x20972D0", Offset = "0x20958D0", VA = "0x1820972D0", Slot = "25")]
	public MJGAEDNBJIL<BKFIMEBJLKC> BFGHIKBHNNE(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<POKJECOIACH> GNAGOFFMLAD)
	{
		return default(MJGAEDNBJIL<BKFIMEBJLKC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x20996D0", Offset = "0x2097CD0", VA = "0x1820996D0")]
	private void IOJKIFHOHDJ(JEBPJLMNFAK<BKFIMEBJLKC> JJLNKABMPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x2097660", Offset = "0x2095C60", VA = "0x182097660")]
	public IEnumerable<KJBJNDHGBLH> CJJGNADANIM([In] JEBPJLMNFAK<IKLMIGOGHKN> CFNEBLLEIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x2096B40", Offset = "0x2095140", VA = "0x182096B40", Slot = "23")]
	public MJGAEDNBJIL<OIEHBMHNIBK> ABAGOEDDNMB(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<BKFIMEBJLKC> JJLNKABMPOP, MJGAEDNBJIL<KHHNPHAINJN> DLKOGGNFIGC)
	{
		return default(MJGAEDNBJIL<OIEHBMHNIBK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x20977A0", Offset = "0x2095DA0", VA = "0x1820977A0", Slot = "26")]
	public MJGAEDNBJIL<POKJECOIACH> COHLLOHCCLP(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<BKFIMEBJLKC> JJLNKABMPOP, MJGAEDNBJIL<JHLLNBLCELC> POPPKCBMEOO)
	{
		return default(MJGAEDNBJIL<POKJECOIACH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x209A2A0", Offset = "0x20988A0", VA = "0x18209A2A0")]
	private KJBJNDHGBLH? LGMMFJBMFIB([In] JEBPJLMNFAK<BKFIMEBJLKC> JJLNKABMPOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x20997F0", Offset = "0x2097DF0", VA = "0x1820997F0")]
	private KJBJNDHGBLH JNEPLMJOOMI([In] JEBPJLMNFAK<BKFIMEBJLKC> JJLNKABMPOP, DPIPCKFLLFL KOHLOCENPAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x209A110", Offset = "0x2098710", VA = "0x18209A110")]
	public DPIPCKFLLFL? LFPCNJAKDPB([In] JEBPJLMNFAK<BKFIMEBJLKC> JJLNKABMPOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x2098B10", Offset = "0x2097110", VA = "0x182098B10")]
	public PHGLNNNIEFI? HBCDFHMHBDI([In] JEBPJLMNFAK<IKLMIGOGHKN> CFNEBLLEIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x2096DD0", Offset = "0x20953D0", VA = "0x182096DD0", Slot = "18")]
	public IEnumerable<BIOGDENGLJE> ALBJEMJDJDH(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x2099460", Offset = "0x2097A60", VA = "0x182099460", Slot = "19")]
	public bool HLALHEMMNDM(MJGAEDNBJIL<OGIDDDCEPIG> PGMHDMOFOGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x20981B0", Offset = "0x20967B0", VA = "0x1820981B0", Slot = "20")]
	public IEnumerable<DNHHGMCCKDA> EPNCPJKAHPA(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<POKJECOIACH> FNCFKKIMIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x20998C0", Offset = "0x2097EC0", VA = "0x1820998C0", Slot = "21")]
	public IEnumerable<DNHHGMCCKDA> KIELGOOJAKA(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<OIEHBMHNIBK> HOHFLCBELHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x20985F0", Offset = "0x2096BF0", VA = "0x1820985F0")]
	public MJGAEDNBJIL<IKLMIGOGHKN> GENDHABPLKA([In] JEBPJLMNFAK<IKLMIGOGHKN> CFNEBLLEIOK)
	{
		return default(MJGAEDNBJIL<IKLMIGOGHKN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x2097830", Offset = "0x2095E30", VA = "0x182097830")]
	public MJGAEDNBJIL<IKLMIGOGHKN>? FGFGNPOHHEC([In] JEBPJLMNFAK<IKLMIGOGHKN> CFNEBLLEIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x209A2E0", Offset = "0x20988E0", VA = "0x18209A2E0")]
	private KBEFAFEHDLK? LJHICOILEKN([In] JEBPJLMNFAK<IKLMIGOGHKN> CFNEBLLEIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x2098B10", Offset = "0x2097110", VA = "0x182098B10")]
	private PHGLNNNIEFI? GNNJBGGEIII([In] JEBPJLMNFAK<IKLMIGOGHKN> CFNEBLLEIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x209A610", Offset = "0x2098C10", VA = "0x18209A610", Slot = "30")]
	public JEBPJLMNFAK<IKLMIGOGHKN> NFOAKHFFDIJ(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK)
	{
		return default(JEBPJLMNFAK<IKLMIGOGHKN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x20978B0", Offset = "0x2095EB0", VA = "0x1820978B0", Slot = "27")]
	public IEnumerable<BLDEJALINAE> DDGEBDDKKDH(NBDEAPDPBJH AMGOEMNHBOG, bool KNGGOCLLICE, bool HMLKIBJOLFB, bool ELNAIAOEFIO, bool JPDEBCKCJBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x2096E90", Offset = "0x2095490", VA = "0x182096E90", Slot = "28")]
	public BLDEJALINAE AMBDNKFONCM(NBDEAPDPBJH AMGOEMNHBOG, DBDMDCDNCFC LCAJPCNBBOP, bool KNGGOCLLICE, bool HMLKIBJOLFB, bool ELNAIAOEFIO, bool JPDEBCKCJBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x2097B20", Offset = "0x2096120", VA = "0x182097B20")]
	public BIOGDENGLJE DOOEOHFFJPC(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, [In] DNHHGMCCKDA FJOJNJJLGCC)
	{
		return default(BIOGDENGLJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x20973D0", Offset = "0x20959D0", VA = "0x1820973D0", Slot = "31")]
	public DNHHGMCCKDA CCAENPIGEHE(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<POKJECOIACH> FNCFKKIMIIP, MJGAEDNBJIL<OIEHBMHNIBK> HOHFLCBELHH)
	{
		return default(DNHHGMCCKDA);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x2099200", Offset = "0x2097800", VA = "0x182099200", Slot = "32")]
	public bool HDPEICIKEMO(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x209B540", Offset = "0x2099B40", VA = "0x18209B540", Slot = "33")]
	public bool PPBBOCCCDOK(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<OIEHBMHNIBK> JJHCIBLPKAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x209A3A0", Offset = "0x20989A0", VA = "0x18209A3A0", Slot = "34")]
	public bool LLNNCGCPBFO(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<POKJECOIACH> GNAGOFFMLAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x209A4F0", Offset = "0x2098AF0", VA = "0x18209A4F0")]
	public BCLNLKLFCPB<JLECLAOCGDF.MFDFCMAOJHA, HAGOHGINEAC> OECLOIEDBFL([In] JLECLAOCGDF.EAAKCLDHMON AAAOIGBEBAB)
	{
		return default(BCLNLKLFCPB<JLECLAOCGDF.MFDFCMAOJHA, HAGOHGINEAC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x20971A0", Offset = "0x20957A0", VA = "0x1820971A0", Slot = "36")]
	[AsyncStateMachine(typeof(ICAAPNJKBFC))]
	public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> BDIELOGFGDP(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<POKJECOIACH> FNCFKKIMIIP, MJGAEDNBJIL<OIEHBMHNIBK> HOHFLCBELHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x209ABE0", Offset = "0x20991E0", VA = "0x18209ABE0", Slot = "37")]
	public BCLNLKLFCPB<IPJFJGJEIGD, JHLAIJINHDF> OBGIJBPLAKO(JEBPJLMNFAK<IKLMIGOGHKN> CFNEBLLEIOK, IPJFJGJEIGD ADDAMHCLIBE, JGKIEDLDOEA DHJLFOMHIND)
	{
		return default(BCLNLKLFCPB<IPJFJGJEIGD, JHLAIJINHDF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x2099570", Offset = "0x2097B70", VA = "0x182099570", Slot = "38")]
	[AsyncStateMachine(typeof(JINEDGKKKJL))]
	public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> INECIEGACGL(JEBPJLMNFAK<IKLMIGOGHKN> CFNEBLLEIOK, JEBPJLMNFAK<BKFIMEBJLKC> LCANIIFIEMF, MJGAEDNBJIL<LPDNCAKIDEG> JLJOAACNPFI, MJGAEDNBJIL<EMOBFLMBFFJ> JJHCIBLPKAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x2099C30", Offset = "0x2098230", VA = "0x182099C30", Slot = "39")]
	[AsyncStateMachine(typeof(CKELHHCAIFA))]
	public Task<BCLNLKLFCPB<BLGMJKLPHOM, OBJIPJOMIPB>> LBAEPMHBPAP(JEBPJLMNFAK<IKLMIGOGHKN> CFNEBLLEIOK, JEBPJLMNFAK<BKFIMEBJLKC> PDJBFCDNGBB, MJGAEDNBJIL<LPDNCAKIDEG> OHBHCKJLONM, MJGAEDNBJIL<DGNIMDELLGK> GNAGOFFMLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x2099270", Offset = "0x2097870", VA = "0x182099270", Slot = "40")]
	public BAGMEALJIGN HHGLOPEGEAB(IEnumerable<GIFFLNOJBNJ> PCMPKHGEFMC)
	{
		return default(BAGMEALJIGN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x2096CB0", Offset = "0x20952B0", VA = "0x182096CB0", Slot = "41")]
	public BAGMEALJIGN AEHBILKJDKD()
	{
		return default(BAGMEALJIGN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x209B310", Offset = "0x2099910", VA = "0x18209B310")]
	private MEPFIAHFCFN OKOFPMCMDKF(FEOJIMLIEKI JMIHOMEEEFK, MJGAEDNBJIL<IKLMIGOGHKN> LOPIFPAENDO, IEnumerable<JEBPJLMNFAK<IKLMIGOGHKN>> EHGGNEILGPP, IEnumerable<JEBPJLMNFAK<BKFIMEBJLKC>> ENKCBJCPFGA)
	{
		return default(MEPFIAHFCFN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x209AFD0", Offset = "0x20995D0", VA = "0x18209AFD0", Slot = "42")]
	public MEPFIAHFCFN OKOFPMCMDKF(FEOJIMLIEKI JMIHOMEEEFK, MJGAEDNBJIL<IKLMIGOGHKN> LOPIFPAENDO, IEnumerable<JEBPJLMNFAK<BKFIMEBJLKC>> ENKCBJCPFGA, IEnumerable<GIFFLNOJBNJ> PCMPKHGEFMC)
	{
		return default(MEPFIAHFCFN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x2099D90", Offset = "0x2098390", VA = "0x182099D90")]
	private static IEnumerable<JEBPJLMNFAK<IKLMIGOGHKN>> LCPFMGHGDPP(IEnumerable<GIFFLNOJBNJ> PCMPKHGEFMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x2098670", Offset = "0x2096C70", VA = "0x182098670")]
	private IEnumerable<JEBPJLMNFAK<BKFIMEBJLKC>> GHIBMNBBGBF(IEnumerable<GIFFLNOJBNJ> PCMPKHGEFMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x2099760", Offset = "0x2097D60", VA = "0x182099760", Slot = "43")]
	public List<PAGJKMGJCIJ> JHLFOMPHHEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x2098B40", Offset = "0x2097140", VA = "0x182098B40")]
	public (List<PAGJKMGJCIJ>, bool) GPNHGHNBOAP([In] DEMJHDDNEDF IOALIBOMCPO, string EIGKPCONJCB, [In] MPCJFPCFBLE HDGFEAEGBPD, EIHJEHOHPNN HPPMAKAELKH, MLEOPDFABBI GOLNPFHOCCO)
	{
		return default((List<PAGJKMGJCIJ>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x20980C0", Offset = "0x20966C0", VA = "0x1820980C0", Slot = "45")]
	public bool EPMAEFABEIL(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x2097740", Offset = "0x2095D40", VA = "0x182097740")]
	internal void CNKNNMDIHEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x209AB80", Offset = "0x2099180", VA = "0x18209AB80")]
	internal Task NOAIDDBHPAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x2097190", Offset = "0x2095790", VA = "0x182097190", Slot = "7")]
	private bool BBIGHOMPFJD(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, [In] DNHHGMCCKDA FJOJNJJLGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x2098B10", Offset = "0x2097110", VA = "0x182098B10", Slot = "13")]
	private PHGLNNNIEFI KKLGOIBKCIC([In] JEBPJLMNFAK<IKLMIGOGHKN> CFNEBLLEIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x20985F0", Offset = "0x2096BF0", VA = "0x1820985F0", Slot = "14")]
	private MJGAEDNBJIL<IKLMIGOGHKN> JLGJMLBOCKB([In] JEBPJLMNFAK<IKLMIGOGHKN> CFNEBLLEIOK)
	{
		return default(MJGAEDNBJIL<IKLMIGOGHKN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x2097830", Offset = "0x2095E30", VA = "0x182097830", Slot = "15")]
	private MJGAEDNBJIL<IKLMIGOGHKN>? DALDPBEHPCF([In] JEBPJLMNFAK<IKLMIGOGHKN> CFNEBLLEIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x209A520", Offset = "0x2098B20", VA = "0x18209A520", Slot = "16")]
	private KJBJNDHGBLH NDDNEMNKFMB([In] JEBPJLMNFAK<BKFIMEBJLKC> JJLNKABMPOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x20984F0", Offset = "0x2096AF0", VA = "0x1820984F0", Slot = "17")]
	private MJGAEDNBJIL<BKFIMEBJLKC> GABIGOCNKDJ(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, [In] JEBPJLMNFAK<BKFIMEBJLKC> OPGPKNHCAJL)
	{
		return default(MJGAEDNBJIL<BKFIMEBJLKC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x2096BD0", Offset = "0x20951D0", VA = "0x182096BD0", Slot = "22")]
	private IEnumerable<KJBJNDHGBLH> ACAIHFDDCGD([In] JEBPJLMNFAK<IKLMIGOGHKN> CFNEBLLEIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x2097B20", Offset = "0x2096120", VA = "0x182097B20", Slot = "29")]
	private BIOGDENGLJE DPLCDHABJFD(MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, [In] DNHHGMCCKDA FJOJNJJLGCC)
	{
		return default(BIOGDENGLJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x209A4F0", Offset = "0x2098AF0", VA = "0x18209A4F0", Slot = "35")]
	private BCLNLKLFCPB<JLECLAOCGDF.MFDFCMAOJHA, HAGOHGINEAC> MHHLBNPCJAN([In] JLECLAOCGDF.EAAKCLDHMON AAAOIGBEBAB)
	{
		return default(BCLNLKLFCPB<JLECLAOCGDF.MFDFCMAOJHA, HAGOHGINEAC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x2097600", Offset = "0x2095C00", VA = "0x182097600", Slot = "44")]
	private (List<PAGJKMGJCIJ>, bool) CGJADLKHMJC([In] DEMJHDDNEDF IOALIBOMCPO, string EIGKPCONJCB, [In] MPCJFPCFBLE HDGFEAEGBPD, EIHJEHOHPNN HPPMAKAELKH, MLEOPDFABBI GOLNPFHOCCO)
	{
		return default((List<PAGJKMGJCIJ>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x2097A30", Offset = "0x2096030", VA = "0x182097A30")]
	[CompilerGenerated]
	private KJBJNDHGBLH DMAOGMPJJFC(DPIPCKFLLFL DMIMFDDIIBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x2099BB0", Offset = "0x20981B0", VA = "0x182099BB0")]
	[CompilerGenerated]
	private GGIKKAOEIBP LAHAJIEEBGL(DHDNLKJCEHP DMIMFDDIIBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x2097FE0", Offset = "0x20965E0", VA = "0x182097FE0")]
	[CompilerGenerated]
	private DPIPCKFLLFL EEMEOEHIHJC(JEBPJLMNFAK<BKFIMEBJLKC> DMIMFDDIIBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x2098050", Offset = "0x2096650", VA = "0x182098050")]
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

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x209E820", Offset = "0x209CE20", VA = "0x18209E820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x209EAA0", Offset = "0x209D0A0", VA = "0x18209EAA0", Slot = "5")]
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

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x20A0EC0", Offset = "0x209F4C0", VA = "0x1820A0EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x20A1140", Offset = "0x209F740", VA = "0x1820A1140", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x8F5280", Offset = "0x8F3880", VA = "0x1808F5280", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public string ANKHGDAKIPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x209FA80", Offset = "0x209E080", VA = "0x18209FA80", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public DHDNLKJCEHP NNCCFHGGNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x209FAB0", Offset = "0x209E0B0", VA = "0x18209FAB0")]
	public GGIKKAOEIBP(DHDNLKJCEHP GPPILCGIDPO, HDGDOAHDBCE HNFHGIGGGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x209F7A0", Offset = "0x209DDA0", VA = "0x18209F7A0", Slot = "6")]
	[AsyncStateMachine(typeof(AIAKFOPBNNC))]
	public Task<BCLNLKLFCPB<MJGAEDNBJIL<DDABHKCABNE>, OBJIPJOMIPB>> DFOEGKCLDNP(JEBPJLMNFAK<IKLMIGOGHKN> CFNEBLLEIOK, JEBPJLMNFAK<BKFIMEBJLKC> JJLNKABMPOP, MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB, string KJPHMNNIMDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x209F910", Offset = "0x209DF10", VA = "0x18209F910", Slot = "7")]
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
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x20A27B0", Offset = "0x20A0DB0", VA = "0x1820A27B0", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool PDOKMEKDLLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x20A27A0", Offset = "0x20A0DA0", VA = "0x1820A27A0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool CLONLEEEHOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x20A2800", Offset = "0x20A0E00", VA = "0x1820A2800", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool PNPEAAHNAKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x20A2720", Offset = "0x20A0D20", VA = "0x1820A2720", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x20A1250", Offset = "0x209F850", VA = "0x1820A1250")]
	public bool HOPFCGCIMCA(string KLABJGGMBGH, [Out] EAFLNFBKMPG ELKCMKIAGCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x8842A0", Offset = "0x8828A0", VA = "0x1808842A0")]
	public OCDCOPCGBAN(DHDNLKJCEHP BDPEMHOFOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x20A14C0", Offset = "0x209FAC0", VA = "0x1820A14C0")]
	internal static TypeKey LOALKGGBBFA(DHDNLKJCEHP JLAAKHANEHC)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x209FA80", Offset = "0x209E080", VA = "0x18209FA80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public readonly struct KLMPMGIBPPL : CLPIGHBJMNE.KJKIDNIDONJ<EHDCBMKEILE, BLGMJKLPHOM>
{
	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x20A0CC0", Offset = "0x209F2C0", VA = "0x1820A0CC0", Slot = "4")]
	public int PBIHFPGECEM(BLGMJKLPHOM MNKBAIOBLHC, EHDCBMKEILE PMCMEAHOBEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x20A0BB0", Offset = "0x209F1B0", VA = "0x1820A0BB0", Slot = "5")]
	public EHDCBMKEILE CJIJFGLHFCK(BLGMJKLPHOM MNKBAIOBLHC, EHDCBMKEILE PMCMEAHOBEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x20A0C00", Offset = "0x209F200", VA = "0x1820A0C00", Slot = "6")]
	public EHDCBMKEILE HCCEBIGFGKG(BLGMJKLPHOM MNKBAIOBLHC, EHDCBMKEILE PMCMEAHOBEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x20A0BE0", Offset = "0x209F1E0", VA = "0x1820A0BE0", Slot = "7")]
	public IReadOnlyList<EHDCBMKEILE> EEJOGACOINC(BLGMJKLPHOM MNKBAIOBLHC, EHDCBMKEILE PMCMEAHOBEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x20A0C70", Offset = "0x209F270", VA = "0x1820A0C70", Slot = "8")]
	public EHDCBMKEILE[] IHJIPFOCGOK(BLGMJKLPHOM MNKBAIOBLHC, EHDCBMKEILE PMCMEAHOBEF, int JPBCAMCEGCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x20A0C80", Offset = "0x209F280", VA = "0x1820A0C80", Slot = "9")]
	public bool INFAKIJBNBJ(BLGMJKLPHOM MNKBAIOBLHC, EHDCBMKEILE PMCMEAHOBEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x20A0CA0", Offset = "0x209F2A0", VA = "0x1820A0CA0", Slot = "10")]
	public bool LCBKKANPDKA(BLGMJKLPHOM MNKBAIOBLHC, EHDCBMKEILE PMCMEAHOBEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x20A0C50", Offset = "0x209F250", VA = "0x1820A0C50", Slot = "11")]
	public bool IDFOHOCIBKH(BLGMJKLPHOM MNKBAIOBLHC, EHDCBMKEILE PMCMEAHOBEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x20A0B90", Offset = "0x209F190", VA = "0x1820A0B90", Slot = "12")]
	public bool BCHHKPGBIIF(BLGMJKLPHOM MNKBAIOBLHC, EHDCBMKEILE PMCMEAHOBEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x20A0C30", Offset = "0x209F230", VA = "0x1820A0C30", Slot = "13")]
	public bool HFBCLKIGHHI(BLGMJKLPHOM GHAOBMIKKNE, EHDCBMKEILE PMCMEAHOBEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x20A0BC0", Offset = "0x209F1C0", VA = "0x1820A0BC0", Slot = "14")]
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
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x20A1200", Offset = "0x209F800", VA = "0x1820A1200", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public abstract JHLIMPAJNBN.EJAJLDBKNGE OJJKKNJEGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public abstract PLLOHOJACCG.KNELNOGLGKD GPEKAOAKBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public abstract FHMGLGJBBAM.JBAIHKMGBEO EDNCNNIGMOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public KOAFOGCPACB.IIALHHDPMEC<MFOMNBGIJJE, EHDCBMKEILE, PLLOHOJACCG> ENKAGJOGOGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x20A11B0", Offset = "0x209F7B0", VA = "0x1820A11B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public abstract GOHBBJGIJKI IELODJJOMGF
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public abstract AIJHDMLFNEJ IGHDBBOFPGG
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public abstract LILGLJLEAMJ EHDEGADEJKM
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public abstract LKNDLJOPDAD KEMHDKDJADI
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public abstract MADEDEPMAFJ BCPOOCELJCH
	{
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x20A0620", Offset = "0x209EC20", VA = "0x1820A0620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x20A08C0", Offset = "0x209EEC0", VA = "0x1820A08C0", Slot = "5")]
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

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x209F3B0", Offset = "0x209D9B0", VA = "0x18209F3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x209F730", Offset = "0x209DD30", VA = "0x18209F730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	private readonly HINPPEJFHLF EMGMPHENKKE;

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x8842A0", Offset = "0x8828A0", VA = "0x1808842A0")]
	public JGPIONBCOJB(HINPPEJFHLF NIHEKDKBACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x20A0A60", Offset = "0x209F060", VA = "0x1820A0A60")]
	[AsyncStateMachine(typeof(IHEJAAONBPI))]
	private Task<BCLNLKLFCPB<object, OBJIPJOMIPB>> OLJLEKCKCBG(EHDCBMKEILE PMCMEAHOBEF, bool ODAOKKACEAL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x20A0930", Offset = "0x209EF30", VA = "0x1820A0930", Slot = "4")]
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

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x2065E30", Offset = "0x2064430", VA = "0x182065E30")]
	private EEAOBHNHAIM([In] BHBPOCEFBGG<HKAMLFAFHNK, EHDCBMKEILE, LBHAJJONOCE> OHAKFLBGIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x209F2F0", Offset = "0x209D8F0", VA = "0x18209F2F0")]
	public static EEAOBHNHAIM GGBAHLJJLHO()
	{
		return default(EEAOBHNHAIM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public static class HBMNBBGIIML
{
	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0xA36FE0", Offset = "0xA355E0", VA = "0x180A36FE0")]
	public static BHBPOCEFBGG<HKAMLFAFHNK, EHDCBMKEILE, LBHAJJONOCE> GKKCCNPACLP(this EEAOBHNHAIM BJNJBGHPMEH)
	{
		return default(BHBPOCEFBGG<HKAMLFAFHNK, EHDCBMKEILE, LBHAJJONOCE>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public struct LBHAJJONOCE : EMHMHKCIFHB.EKJFLNMGEMN<HKAMLFAFHNK, EHDCBMKEILE>
{
	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x20A0CE0", Offset = "0x209F2E0", VA = "0x1820A0CE0", Slot = "5")]
	public EHDCBMKEILE NOANCEBBCHI(HKAMLFAFHNK[] GCGECJMEOOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x17E3330", Offset = "0x17E1930", VA = "0x1817E3330")]
	public int NJJKAJPOLFL([In] HKAMLFAFHNK IBEOBEHLBLA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x17E3330", Offset = "0x17E1930", VA = "0x1817E3330", Slot = "4")]
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

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x2065E30", Offset = "0x2064430", VA = "0x182065E30")]
	private EFGKIDLCFBA([In] KHGNBNGFBDM<BDIKLFAAIFG, EHDCBMKEILE, HKDIGDJHOOF> NEBNKJIBLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x209F350", Offset = "0x209D950", VA = "0x18209F350")]
	public static EFGKIDLCFBA GGBAHLJJLHO()
	{
		return default(EFGKIDLCFBA);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public static class FDOGBLIJHHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0xA36FE0", Offset = "0xA355E0", VA = "0x180A36FE0")]
	public static KHGNBNGFBDM<BDIKLFAAIFG, EHDCBMKEILE, HKDIGDJHOOF> GKKCCNPACLP(this EFGKIDLCFBA BJNJBGHPMEH)
	{
		return default(KHGNBNGFBDM<BDIKLFAAIFG, EHDCBMKEILE, HKDIGDJHOOF>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public struct HKDIGDJHOOF : LPBANJKMDOB.ELFPKLHOBFD<BDIKLFAAIFG, EHDCBMKEILE>
{
	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x17E3330", Offset = "0x17E1930", VA = "0x1817E3330")]
	public int KLDOIHEMJFL([In] BDIKLFAAIFG IBEOBEHLBLA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x20A0440", Offset = "0x209EA40", VA = "0x1820A0440", Slot = "5")]
	public EHDCBMKEILE AEFBJABAPOD(BDIKLFAAIFG[] AFLGGLEOMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x17E3330", Offset = "0x17E1930", VA = "0x1817E3330", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x88D660", Offset = "0x88BC60", VA = "0x18088D660", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(MDAICEEICDH);
		}
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x8920C0", Offset = "0x8906C0", VA = "0x1808920C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public override JHLAIJINHDF? GLFEJPFJNNO
	{
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x886FC0", Offset = "0x8855C0", VA = "0x180886FC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x209EB10", Offset = "0x209D110", VA = "0x18209EB10", Slot = "7")]
	public override string CKGPGAAGKNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x209EDF0", Offset = "0x209D3F0", VA = "0x18209EDF0")]
	private BGLKIAPELNH(MDAICEEICDH FODBPFPIPNA, JHLAIJINHDF? ICAENOKHDMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x209ED00", Offset = "0x209D300", VA = "0x18209ED00")]
	public static BGLKIAPELNH IDAHCNBINFF(JHLAIJINHDF ICAENOKHDMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x209EC90", Offset = "0x209D290", VA = "0x18209EC90")]
	public static BGLKIAPELNH ICCHCCKLLEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x209ED80", Offset = "0x209D380", VA = "0x18209ED80")]
	public static BGLKIAPELNH MHEMHBDOIIM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class KPDPMIKNJLL
{
	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x2D6D1E0", Offset = "0x2D6B7E0", VA = "0x182D6D1E0")]
	public static BCLNLKLFCPB<TOk, HAGOHGINEAC> IKNJBICJJCD<TOk>([In] this BCLNLKLFCPB<TOk, HAGOHGINEAC> BJNJBGHPMEH, JHLAIJINHDF ICAENOKHDMC) where TOk : notnull
	{
		return default(BCLNLKLFCPB<TOk, HAGOHGINEAC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x2D6D2D0", Offset = "0x2D6B8D0", VA = "0x182D6D2D0")]
	public static BCLNLKLFCPB<TOk?, HAGOHGINEAC?> KDOCIHDCLLC<TOk>([In] this BCLNLKLFCPB<TOk, HAGOHGINEAC> BJNJBGHPMEH)
	{
		return default(BCLNLKLFCPB<TOk, HAGOHGINEAC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x2D6D0E0", Offset = "0x2D6B6E0", VA = "0x182D6D0E0")]
	public static BCLNLKLFCPB<TOk?, HAGOHGINEAC?> BEDFMJDJKIM<TOk>([In] this BCLNLKLFCPB<TOk, HAGOHGINEAC> BJNJBGHPMEH)
	{
		return default(BCLNLKLFCPB<TOk, HAGOHGINEAC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public interface GOHBBJGIJKI
{
	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BMKCCJLKDDB([In] BCLNLKLFCPB<BLGMJKLPHOM, JHLAIJINHDF> POBDLJBBBCI);
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public static class MKIEDJDJOOP
{
	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C140", Offset = "0x2D9A740", VA = "0x182D9C140")]
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
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public interface LILGLJLEAMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OKNBGAPNIGA HBDNAJACIIE(int KDLMAHAJHMP);
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public interface NCDBNPGPHNP
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	string FHACOBMPENF
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public interface GGABBEDLODL
{
	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEOMJHEDCAP? OCDJDIEPHCC(MJGAEDNBJIL<LPDNCAKIDEG> PADKCIAGKJB);
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public interface DCLFJKKBJGK
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	string FHACOBMPENF
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
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
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DCLFJKKBJGK? DPPDDHEPKFN(MJGAEDNBJIL<DDABHKCABNE> IINCKHAMMKN);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NCDBNPGPHNP? JEMPIKIALAL(MJGAEDNBJIL<OMDILHJFPPO> DPNCALJCMOD);
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public interface LKNDLJOPDAD
{
	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> GIMHHDFCHCF(string KLABJGGMBGH, string EIGKPCONJCB);
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public interface MADEDEPMAFJ
{
	[Cpp2IlInjected.Token(Token = "0x600055F")]
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

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x209EEF0", Offset = "0x209D4F0", VA = "0x18209EEF0")]
		private CGCJNDNEDNJ(int HGFDMIDEFHN, FAOKMGJAJIO? GLGDPJGHHKL, FAOKMGJAJIO? BOIDABFICBM, List<EHDCBMKEILE> EENNPJMHNKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x209EE30", Offset = "0x209D430", VA = "0x18209EE30")]
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
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x209FC10", Offset = "0x209E210", VA = "0x18209FC10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool NDCBOPNPOIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0xA00000", Offset = "0x9FE600", VA = "0x180A00000")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0xB69440", Offset = "0xB67A40", VA = "0x180B69440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x209FB50", Offset = "0x209E150", VA = "0x18209FB50")]
	public void BLELJAEMPMD(JKIEPPIEFOF BOIDABFICBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x209FC60", Offset = "0x209E260", VA = "0x18209FC60")]
	public void KNFNNCLLICE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x209FF50", Offset = "0x209E550", VA = "0x18209FF50")]
	private static string? NPOFEBMAMMB([In] CGCJNDNEDNJ MPPBMOONIJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x20A0390", Offset = "0x209E990", VA = "0x1820A0390")]
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
