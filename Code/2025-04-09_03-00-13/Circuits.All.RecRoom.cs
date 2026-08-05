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
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2644820", Offset = "0x2643C20", VA = "0x182644820")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D5490", Offset = "0x9D4890", VA = "0x1809D5490")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9D54D0", Offset = "0x9D48D0", VA = "0x1809D54D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class PMKDFPMAACD : IDisposable, PKGAPFMGNGJ, JJCJGBDNOHO, MIJPMGDGPNH, KHJAMPDAJCI
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class FICONLIPBJK : MKAKGJAKNPG
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int BNKGDNKMOPA
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2632B20", Offset = "0x2631F20", VA = "0x182632B20", Slot = "5")]
		public JEHEBBDPAGI MPEJMKMPOAP(JLEFPKJHFKH.DCJNAHIDFON OHJFEHDLOHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void FMOBEGGGEGF();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void IGNKHKFIFEM();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2632AE0", Offset = "0x2631EE0", VA = "0x182632AE0", Slot = "13")]
		public virtual void CGGLILCMDLP(PMKDFPMAACD HKPECGCBGAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2632C70", Offset = "0x2632070", VA = "0x182632C70", Slot = "14")]
		public virtual void POJCCKLONCH(PMKDFPMAACD HKPECGCBGAA, FCMLLGFOEBF IOPCFKOHPBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		protected FICONLIPBJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface MKAKGJAKNPG
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int BNKGDNKMOPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "1")]
		JEHEBBDPAGI MPEJMKMPOAP(JLEFPKJHFKH.DCJNAHIDFON OHJFEHDLOHB);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void FMOBEGGGEGF();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void IGNKHKFIFEM();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void CGGLILCMDLP(PMKDFPMAACD HKPECGCBGAA);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void POJCCKLONCH(PMKDFPMAACD HKPECGCBGAA, FCMLLGFOEBF IOPCFKOHPBF);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct APMHPDOKEOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly LAHKIFIDPBB<HLGPJHLLHLK, FCMLLGFOEBF, PMKDFPMAACD, KLOPJJFPPNK.OEAIGBPOPBO<HLGPJHLLHLK, FCMLLGFOEBF, PMKDFPMAACD>> GGEMNOPDOAG;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x262AC10", Offset = "0x262A010", VA = "0x18262AC10")]
		internal APMHPDOKEOK(LAHKIFIDPBB<HLGPJHLLHLK, FCMLLGFOEBF, PMKDFPMAACD, KLOPJJFPPNK.OEAIGBPOPBO<HLGPJHLLHLK, FCMLLGFOEBF, PMKDFPMAACD>> BGCEKLPNCIL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class PCONOEDAJBK : KLOPJJFPPNK.OEAIGBPOPBO<HLGPJHLLHLK, FCMLLGFOEBF, PMKDFPMAACD>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly PCONOEDAJBK DNEPPKLGBFA;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		private PCONOEDAJBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA40AA0", Offset = "0xA3FEA0", VA = "0x180A40AA0", Slot = "4")]
		public HLGPJHLLHLK DMEFMDBKELA(FCMLLGFOEBF JOCJBPPJMJJ)
		{
			return default(HLGPJHLLHLK);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2644D00", Offset = "0x2644100", VA = "0x182644D00", Slot = "5")]
		public void CGGLILCMDLP(PMKDFPMAACD BKHMOJGGBFN, FCMLLGFOEBF IOPCFKOHPBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2644E10", Offset = "0x2644210", VA = "0x182644E10", Slot = "6")]
		public void POJCCKLONCH(PMKDFPMAACD BKHMOJGGBFN, FCMLLGFOEBF IOPCFKOHPBF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct HBEJOLHGBFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public DNNLPNOLHBJ<HLGPJHLLHLK, FCMLLGFOEBF, PMKDFPMAACD, KLOPJJFPPNK.OEAIGBPOPBO<HLGPJHLLHLK, FCMLLGFOEBF, PMKDFPMAACD>> GGEMNOPDOAG;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2633730", Offset = "0x2632B30", VA = "0x182633730")]
		internal HBEJOLHGBFP(DNNLPNOLHBJ<HLGPJHLLHLK, FCMLLGFOEBF, PMKDFPMAACD, KLOPJJFPPNK.OEAIGBPOPBO<HLGPJHLLHLK, FCMLLGFOEBF, PMKDFPMAACD>> BGCEKLPNCIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x26336E0", Offset = "0x2632AE0", VA = "0x1826336E0")]
		public static HBEJOLHGBFP HBLBJMFGHFK()
		{
			return default(HBEJOLHGBFP);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct OLODJDAECEK : BLPDKENIACC.DDAGMBHGIHA<FCMLLGFOEBF, PMKDFPMAACD>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct PIIMNMIJEAD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<KGPHFOFOMPJ<object?, HEGOEPNOLEN>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public PMKDFPMAACD receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public FCMLLGFOEBF action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public OLODJDAECEK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<KGPHFOFOMPJ<object?, HEGOEPNOLEN>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x26451C0", Offset = "0x26445C0", VA = "0x1826451C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x26453A0", Offset = "0x26447A0", VA = "0x1826453A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xDF7530", Offset = "0xDF6930", VA = "0x180DF7530", Slot = "4")]
		public IJOGBJOFPED<BKOCDGICELM> MCMHJEBGCFG(PMKDFPMAACD IIOEMENEBDK)
		{
			return default(IJOGBJOFPED<BKOCDGICELM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x26448A0", Offset = "0x2643CA0", VA = "0x1826448A0", Slot = "5")]
		public void AGDLLMIKMDN(PMKDFPMAACD IIOEMENEBDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2644900", Offset = "0x2643D00", VA = "0x182644900", Slot = "6")]
		[AsyncStateMachine(typeof(PIIMNMIJEAD))]
		public Task<KGPHFOFOMPJ<object, HEGOEPNOLEN>> BPOIKDACAIF(PMKDFPMAACD IIOEMENEBDK, FCMLLGFOEBF IOPCFKOHPBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2644A30", Offset = "0x2643E30", VA = "0x182644A30", Slot = "7")]
		public FCMLLGFOEBF[] FJOENDHLANH(PMKDFPMAACD IIOEMENEBDK)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct EIHALJIBAPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<bool, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public PMKDFPMAACD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<KGPHFOFOMPJ<bool, HEGOEPNOLEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2632520", Offset = "0x2631920", VA = "0x182632520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x26327B0", Offset = "0x2631BB0", VA = "0x1826327B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct JAPMMHMOHHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public PMKDFPMAACD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x26415C0", Offset = "0x26409C0", VA = "0x1826415C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x26417A0", Offset = "0x2640BA0", VA = "0x1826417A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct DBAGAOOFHPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<object?, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public PMKDFPMAACD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public FCMLLGFOEBF action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<KGPHFOFOMPJ<object?, HEGOEPNOLEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x262C980", Offset = "0x262BD80", VA = "0x18262C980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x262CB70", Offset = "0x262BF70", VA = "0x18262CB70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly IJOGBJOFPED<BKOCDGICELM> GMBMKEFFMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly APMHPDOKEOK HBJADEFCLPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly OFCOBHACBAH ICDBOCAFPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly DALNKLGFLJC IHDCDNNABCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly ILKEOPJELCM KAFKHGNENCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly IAENGEFPAJO.FMJCBEMCJKB EOIBKEPGJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly KFHGFLINMNP KFJBNODCGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly MHLLOPMPAHP EGIOLCAFHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B60")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly DAPAIJIKJCN DFPBINFJFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B68")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly CGLJGDHEBMI EHPJBAGPHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B70")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private CCEJNBKACKF CLJJHCNAGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B80")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private JCPAANJCLNO OHMIFOKMBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BA0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly OFCOBHACBAH.BJBOLNKFGCC JHPJAPIPJDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BA8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly NOFMAMMILJP GIMOEPCCHAL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public OFCOBHACBAH HDPMMFDBGIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2646690", Offset = "0x2645A90", VA = "0x182646690")]
		get
		{
			return default(OFCOBHACBAH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal MKAKGJAKNPG BHDJHONCLEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2645550", Offset = "0x2644950", VA = "0x182645550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal JEHEBBDPAGI MMJGHBJPNMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2646680", Offset = "0x2645A80", VA = "0x182646680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x26467E0", Offset = "0x2645BE0", VA = "0x1826467E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool IIMBDNJIOCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x26466A0", Offset = "0x2645AA0", VA = "0x1826466A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2646800", Offset = "0x2645C00", VA = "0x182646800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public NHENNDKOIAN NONDCINKEFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2646B10", Offset = "0x2645F10", VA = "0x182646B10", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public MDHGNCHDNJA CMKJKAEILJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2646B20", Offset = "0x2645F20", VA = "0x182646B20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public NPLPKFDPNKH BMIEAFFIMEN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2646B40", Offset = "0x2645F40", VA = "0x182646B40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IBDGMLOEDJD NNJJPHAJEBP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2646B30", Offset = "0x2645F30", VA = "0x182646B30", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IAENGEFPAJO? BKDDPJLBIFA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x26464F0", Offset = "0x26458F0", VA = "0x1826464F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private OIIIPHHKNKK? HFHCBJJNANC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x26466B0", Offset = "0x2645AB0", VA = "0x1826466B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2646810", Offset = "0x2645C10", VA = "0x182646810")]
	private PMKDFPMAACD(ILKEOPJELCM CJADGLGGCKK, IJOGBJOFPED<BKOCDGICELM> GIBMIJMGIIO, [In] APMHPDOKEOK ODNAHKPHIJA, [In] OFCOBHACBAH FBLFJIPLCDK, [In] DALNKLGFLJC BFMFNGGBGLK, JEHEBBDPAGI MMDOIBNNACN, [In] IAENGEFPAJO.FMJCBEMCJKB AAGMHPHNBOO, OFCOBHACBAH.BJBOLNKFGCC LODINEJPMPM, NOFMAMMILJP FCEDJKPFDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x26460A0", Offset = "0x26454A0", VA = "0x1826460A0")]
	public static PMKDFPMAACD HBLBJMFGHFK(ILKEOPJELCM OHJFEHDLOHB, [In] OOFECDIPGHD IBMGBOFMLNN, KAMIMJHGGFM EBAPNHMKDDO, [In] LJHNMPDLNHN KCPBPDBAMOK, FPDJKPFKLEO EAOJFKOIOJH, IJOGBJOFPED<BKOCDGICELM> GIBMIJMGIIO, IJOGBJOFPED<DLAICPOMKPB> DKEALHKLKMK, JKECMCHDNIJ FLCBCFNKGNK, COMJPOLLKHA BDLPOFHPDOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x26461E0", Offset = "0x26455E0", VA = "0x1826461E0")]
	public static PMKDFPMAACD HBLBJMFGHFK(ILKEOPJELCM CJADGLGGCKK, [In] OFCOBHACBAH FBLFJIPLCDK, [In] DALNKLGFLJC BFMFNGGBGLK, IJOGBJOFPED<BKOCDGICELM> GIBMIJMGIIO, IJOGBJOFPED<DLAICPOMKPB> DKEALHKLKMK, JKECMCHDNIJ FLCBCFNKGNK, COMJPOLLKHA BDLPOFHPDOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2645820", Offset = "0x2644C20", VA = "0x182645820", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2645730", Offset = "0x2644B30", VA = "0x182645730")]
	[AsyncStateMachine(typeof(EIHALJIBAPC))]
	public Task<KGPHFOFOMPJ<bool, HEGOEPNOLEN>> DEJANCENGBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2645460", Offset = "0x2644860", VA = "0x182645460")]
	[AsyncStateMachine(typeof(JAPMMHMOHHK))]
	public Task<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> AHHPCJMHHIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2645A10", Offset = "0x2644E10", VA = "0x182645A10")]
	internal void FCKEFMIOPOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2645FB0", Offset = "0x26453B0", VA = "0x182645FB0")]
	internal NPOJFHOGAHB<FCMLLGFOEBF> GHGFLDCDIJD([In] HFHMMGMJMIM DLAKGBJHMLG)
	{
		return default(NPOJFHOGAHB<FCMLLGFOEBF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2646030", Offset = "0x2645430", VA = "0x182646030")]
	internal bool GMCBHDNOFJM([In] HFHMMGMJMIM DLAKGBJHMLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x26455A0", Offset = "0x26449A0", VA = "0x1826455A0")]
	internal KGPHFOFOMPJ<FCMLLGFOEBF, HEGOEPNOLEN> CNGBMAPLGNO([In] HMGBIKNIADJ KGHLNFBMGIG)
	{
		return default(KGPHFOFOMPJ<FCMLLGFOEBF, HEGOEPNOLEN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2645410", Offset = "0x2644810", VA = "0x182645410")]
	private void AGDLLMIKMDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2646570", Offset = "0x2645970", VA = "0x182646570")]
	[AsyncStateMachine(typeof(DBAGAOOFHPA))]
	internal Task<KGPHFOFOMPJ<object, HEGOEPNOLEN>> ILNLKDLGFOP(FCMLLGFOEBF IOPCFKOHPBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2645C20", Offset = "0x2645020", VA = "0x182645C20")]
	private FCMLLGFOEBF[] FJOENDHLANH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class OBAJODKDCLK<TData> : ADGPAJEIFGP, FMNIGGAFNEA, ALOCPDILHNE where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly HNEIHDEKOKM<EICBKBBFNCN>? BOEJMGINLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly string FOLBMPKOGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly TData EEHHJHNNGPO;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public HNEIHDEKOKM<EICBKBBFNCN>? MLHLHNLECOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x28A28E0", Offset = "0x28A1CE0", VA = "0x1828A28E0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x9AA330", Offset = "0x9A9730", VA = "0x1809AA330", Slot = "7")]
	public override string JIBLDGHIHFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x52087D0", Offset = "0x5207BD0", VA = "0x1852087D0")]
	internal OBAJODKDCLK([In] HNEIHDEKOKM<EICBKBBFNCN>? FILNIECAOAJ, IJOGBJOFPED<BIBBOHDALII>? JPNBNEHNCKN, IOKind? OABLMOFFMDG, string DAMFJFKKFBI, [In] TData HPMNBNLACCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class IFADDGAEKOL
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2640CD0", Offset = "0x26400D0", VA = "0x182640CD0")]
	public static KGPHFOFOMPJ<EGBNIOBKGKM, FMNIGGAFNEA> GDOMGLHLEAD([In] this JAKAKGGHEAN<EPKDAMIBNIB> NFIKIKDAPLD)
	{
		return default(KGPHFOFOMPJ<EGBNIOBKGKM, FMNIGGAFNEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x365B700", Offset = "0x365AB00", VA = "0x18365B700")]
	public static KGPHFOFOMPJ<TOk, FMNIGGAFNEA> ICOMEHNMHGG<TOk>([In] this KGPHFOFOMPJ<TOk, FMNIGGAFNEA> JOCJBPPJMJJ, [In] HNEIHDEKOKM<EICBKBBFNCN>? FILNIECAOAJ, IJOGBJOFPED<BIBBOHDALII>? JPNBNEHNCKN, IOKind? OABLMOFFMDG, string DAMFJFKKFBI) where TOk : notnull
	{
		return default(KGPHFOFOMPJ<TOk, FMNIGGAFNEA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface ILKEOPJELCM
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	AEMKHBLCFMH.HEIODONLACF IHMLBOBDKEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	JLEFPKJHFKH.DCJNAHIDFON CKCEDMNEIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	PMKDFPMAACD.MKAKGJAKNPG ELHOBPGBAHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	PHFLCIELONP.KEDDGHAKJLM PKILCJGBHPD
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	KLOPJJFPPNK.OEAIGBPOPBO<HLGPJHLLHLK, FCMLLGFOEBF, PMKDFPMAACD> GPLIAFBCBJI
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	OLBBMCFJDBM.MIMNCDNMBOB MKHNILOMCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	DJODKJGKOCD GEJJGLMIFDI
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	OLDBMBEFMDK PMCFOOHHPHB
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	HHAHICNEGGE ILLBLNOGADL
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	CLKIHOEIECH BKLIEICCPLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	EBPKJEHHMPE OIINIEDANEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class AHNPMALNBEG
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x262A330", Offset = "0x2629730", VA = "0x18262A330")]
	public static FCMLLGFOEBF HLJMPFFABBA(this FCMLLGFOEBF JOCJBPPJMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x262A260", Offset = "0x2629660", VA = "0x18262A260")]
	public static FCMLLGFOEBF CLDAGCMMKBG(this IOJKAKJNBHD JOCJBPPJMJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct IOJKAKJNBHD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct MGKMMNEIJKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<object?, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public PMKDFPMAACD root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public IOJKAKJNBHD self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<KGPHFOFOMPJ<object?, HEGOEPNOLEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2643A60", Offset = "0x2642E60", VA = "0x182643A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2643D20", Offset = "0x2643120", VA = "0x182643D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly ByteString HDKOPKMNJCH;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xC747D0", Offset = "0xC73BD0", VA = "0x180C747D0")]
	private IOJKAKJNBHD(ByteString FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x26413F0", Offset = "0x26407F0", VA = "0x1826413F0")]
	public static FCMLLGFOEBF GLFJCMFKHED(ByteString FFOEEMKIKJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2641340", Offset = "0x2640740", VA = "0x182641340")]
	public static ENCDLLFOBMH<HLGPJHLLHLK, IOJKAKJNBHD> AAJFNJDAKJL(FCMLLGFOEBF HNLCODEPKIL)
	{
		return default(ENCDLLFOBMH<HLGPJHLLHLK, IOJKAKJNBHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x26414B0", Offset = "0x26408B0", VA = "0x1826414B0")]
	[AsyncStateMachine(typeof(MGKMMNEIJKM))]
	public static Task<KGPHFOFOMPJ<object, HEGOEPNOLEN>> ILNLKDLGFOP(PMKDFPMAACD BKHMOJGGBFN, IOJKAKJNBHD JOCJBPPJMJJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct CAIAFEKLMLF
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x262B470", Offset = "0x262A870", VA = "0x18262B470")]
	public static FCMLLGFOEBF GLFJCMFKHED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x262B400", Offset = "0x262A800", VA = "0x18262B400")]
	public static ENCDLLFOBMH<HLGPJHLLHLK, CAIAFEKLMLF> AAJFNJDAKJL(FCMLLGFOEBF HNLCODEPKIL)
	{
		return default(ENCDLLFOBMH<HLGPJHLLHLK, CAIAFEKLMLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x262B510", Offset = "0x262A910", VA = "0x18262B510")]
	public static KGPHFOFOMPJ<LPCAMBCOBBH, IOLFOONCHKI> NBEBOJADJAF(PMKDFPMAACD BKHMOJGGBFN, [In] CAIAFEKLMLF JOCJBPPJMJJ)
	{
		return default(KGPHFOFOMPJ<LPCAMBCOBBH, IOLFOONCHKI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct LKFJJLOJHMP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct DNMIHDIMMON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<LPCAMBCOBBH, IOLFOONCHKI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public PMKDFPMAACD root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public LKFJJLOJHMP self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private KGPHFOFOMPJ<LPCAMBCOBBH, IOLFOONCHKI> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2631AC0", Offset = "0x2630EC0", VA = "0x182631AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2631E30", Offset = "0x2631230", VA = "0x182631E30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly HODMPAADEDL? BAOFPGCHLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly LECJPJBNNBI? GEJHKJCCHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly NFAAFKCENHI? ODDGKOCCHKM;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2564190", Offset = "0x2563590", VA = "0x182564190")]
	private LKFJJLOJHMP(HODMPAADEDL? MMILFLIJGKL, LECJPJBNNBI? MJJBHALKDGD, NFAAFKCENHI? JKIDAGFNHLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2643640", Offset = "0x2642A40", VA = "0x182643640")]
	public static FCMLLGFOEBF? GLFJCMFKHED(HODMPAADEDL? MMILFLIJGKL, LECJPJBNNBI? MJJBHALKDGD, NFAAFKCENHI? JKIDAGFNHLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2643530", Offset = "0x2642930", VA = "0x182643530")]
	public static ENCDLLFOBMH<HLGPJHLLHLK, LKFJJLOJHMP> AAJFNJDAKJL(FCMLLGFOEBF HNLCODEPKIL)
	{
		return default(ENCDLLFOBMH<HLGPJHLLHLK, LKFJJLOJHMP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2643740", Offset = "0x2642B40", VA = "0x182643740")]
	[AsyncStateMachine(typeof(DNMIHDIMMON))]
	public static Task<KGPHFOFOMPJ<LPCAMBCOBBH, IOLFOONCHKI>> ILNLKDLGFOP(PMKDFPMAACD BKHMOJGGBFN, LKFJJLOJHMP JOCJBPPJMJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct HPNBADFAMAK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct CDCPFLCEJGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<NMJFPHJOOOF, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public HPNBADFAMAK self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public PMKDFPMAACD root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private KGPHFOFOMPJ<NMJFPHJOOOF, HEGOEPNOLEN> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private KGPHFOFOMPJ<object?, ALOCPDILHNE>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private KGPHFOFOMPJ<object?, ALOCPDILHNE> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private KGPHFOFOMPJ<object?, ALOCPDILHNE>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter<KGPHFOFOMPJ<object?, HEGOEPNOLEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x262B590", Offset = "0x262A990", VA = "0x18262B590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x262BA00", Offset = "0x262AE00", VA = "0x18262BA00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly IReadOnlyList<FCMLLGFOEBF> DLMCLEMAICI;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xC747D0", Offset = "0xC73BD0", VA = "0x180C747D0")]
	private HPNBADFAMAK(IReadOnlyList<FCMLLGFOEBF> NBIPNPJJADG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x263F4D0", Offset = "0x263E8D0", VA = "0x18263F4D0")]
	public static FCMLLGFOEBF GLFJCMFKHED(IReadOnlyList<FCMLLGFOEBF> NBIPNPJJADG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x263F430", Offset = "0x263E830", VA = "0x18263F430")]
	public static ENCDLLFOBMH<HLGPJHLLHLK, HPNBADFAMAK> AAJFNJDAKJL(FCMLLGFOEBF HNLCODEPKIL)
	{
		return default(ENCDLLFOBMH<HLGPJHLLHLK, HPNBADFAMAK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x263F590", Offset = "0x263E990", VA = "0x18263F590")]
	[AsyncStateMachine(typeof(CDCPFLCEJGF))]
	public static Task<KGPHFOFOMPJ<NMJFPHJOOOF, HEGOEPNOLEN>> ILNLKDLGFOP(PMKDFPMAACD BKHMOJGGBFN, HPNBADFAMAK JOCJBPPJMJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct HMGBIKNIADJ
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class DMGEILLMCLF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class MEBOANJEDKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public HNEIHDEKOKM<DMGEILLMCLF> actionId;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public MEBOANJEDKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x26438F0", Offset = "0x2642CF0", VA = "0x1826438F0")]
		internal FCMLLGFOEBF LOMNHHCFMBF(int count, int index, [In] ReadOnlySpan<byte> span)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly HNEIHDEKOKM<DMGEILLMCLF> JLCCLNEJJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly int GMILMIAEFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly int FBMJOLKHIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly byte[] EEHHJHNNGPO;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2634740", Offset = "0x2633B40", VA = "0x182634740")]
	private HMGBIKNIADJ(HNEIHDEKOKM<DMGEILLMCLF> JBPKDCGKEGC, int ECKHNAPCKGD, int CJFNAFNJJLB, byte[] HPMNBNLACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2634390", Offset = "0x2633790", VA = "0x182634390")]
	public static FCMLLGFOEBF GLFJCMFKHED(HNEIHDEKOKM<DMGEILLMCLF> JBPKDCGKEGC, int ECKHNAPCKGD, int CJFNAFNJJLB, ByteString HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x26344A0", Offset = "0x26338A0", VA = "0x1826344A0")]
	public static FCMLLGFOEBF[] JKLICFDDONL(FCMLLGFOEBF IOPCFKOHPBF, int BEGLDMFGEOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2634240", Offset = "0x2633640", VA = "0x182634240")]
	public static ENCDLLFOBMH<HLGPJHLLHLK, HMGBIKNIADJ> AAJFNJDAKJL(FCMLLGFOEBF HNLCODEPKIL)
	{
		return default(ENCDLLFOBMH<HLGPJHLLHLK, HMGBIKNIADJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x26345B0", Offset = "0x26339B0", VA = "0x1826345B0")]
	public static KGPHFOFOMPJ<FCMLLGFOEBF, HEGOEPNOLEN> NBEBOJADJAF(PMKDFPMAACD BKHMOJGGBFN, [In] HMGBIKNIADJ JOCJBPPJMJJ)
	{
		return default(KGPHFOFOMPJ<FCMLLGFOEBF, HEGOEPNOLEN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct HFHMMGMJMIM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct JFCOJALELHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<bool, IOLFOONCHKI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public PMKDFPMAACD root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public HFHMMGMJMIM self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private KGPHFOFOMPJ<bool, IOLFOONCHKI> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, IOLFOONCHKI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2641810", Offset = "0x2640C10", VA = "0x182641810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2641E50", Offset = "0x2641250", VA = "0x182641E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly int GMILMIAEFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly int FBMJOLKHIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly byte[] EEHHJHNNGPO;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xB603A0", Offset = "0xB5F7A0", VA = "0x180B603A0")]
	private HFHMMGMJMIM(int ECKHNAPCKGD, int CJFNAFNJJLB, byte[] HPMNBNLACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2633A10", Offset = "0x2632E10", VA = "0x182633A10")]
	public static FCMLLGFOEBF GLFJCMFKHED(int ECKHNAPCKGD, int CJFNAFNJJLB, ByteString HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2633820", Offset = "0x2632C20", VA = "0x182633820")]
	public static FCMLLGFOEBF?[]? COPFBIOBFDI(int BEGLDMFGEOI, HODMPAADEDL? MMILFLIJGKL, LECJPJBNNBI? MJJBHALKDGD, NFAAFKCENHI? JKIDAGFNHLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2633740", Offset = "0x2632B40", VA = "0x182633740")]
	public static ENCDLLFOBMH<HLGPJHLLHLK, HFHMMGMJMIM> AAJFNJDAKJL(FCMLLGFOEBF HNLCODEPKIL)
	{
		return default(ENCDLLFOBMH<HLGPJHLLHLK, HFHMMGMJMIM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2633AF0", Offset = "0x2632EF0", VA = "0x182633AF0")]
	[AsyncStateMachine(typeof(JFCOJALELHO))]
	public static Task<KGPHFOFOMPJ<bool, IOLFOONCHKI>> ILNLKDLGFOP(PMKDFPMAACD BKHMOJGGBFN, HFHMMGMJMIM JOCJBPPJMJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class KFHGFLINMNP : NHENNDKOIAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly PMKDFPMAACD JAGCIOPDOMP;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public KIPMHOKIJEL? DNEPPKLGBFA
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2642F20", Offset = "0x2642320", VA = "0x182642F20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9B2970", Offset = "0x9B1D70", VA = "0x1809B2970")]
	internal KFHGFLINMNP(PMKDFPMAACD HKPECGCBGAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class HGOPNPABFDI : KIPMHOKIJEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly PMKDFPMAACD JAGCIOPDOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly ILBJIDDJFAI COBCJEJKOCA;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x9B9340", Offset = "0x9B8740", VA = "0x1809B9340")]
	public HGOPNPABFDI(PMKDFPMAACD HKPECGCBGAA, ILBJIDDJFAI BMMNCLDOHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2633F00", Offset = "0x2633300", VA = "0x182633F00", Slot = "4")]
	public KGPHFOFOMPJ<EGBNIOBKGKM, FMNIGGAFNEA> OMFPGOFOBLL(HNEIHDEKOKM<EICBKBBFNCN> CCBIHMLAAKK, IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI, IJOGBJOFPED<LIGOHIGOKPO> DGBNICFCJPK)
	{
		return default(KGPHFOFOMPJ<EGBNIOBKGKM, FMNIGGAFNEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2633C20", Offset = "0x2633020", VA = "0x182633C20", Slot = "5")]
	public KGPHFOFOMPJ<EGBNIOBKGKM, FMNIGGAFNEA> NPBKFEHJHAO(HNEIHDEKOKM<EICBKBBFNCN> CCBIHMLAAKK, IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI, IJOGBJOFPED<HOJGFCBIPIJ> MPJFFADFMPN)
	{
		return default(KGPHFOFOMPJ<EGBNIOBKGKM, FMNIGGAFNEA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class AEMKHBLCFMH : ICIGGIMHPMH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface HEIODONLACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<ILBJIDDJFAI> LENACGJAIOM(PMKDFPMAACD HKPECGCBGAA, LECJPJBNNBI? NJAIFIIMJEN, NFAAFKCENHI? KDHINLEFFAG, CancellationToken LMNHDKIFBOH);

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		LEJBIGAEAEM OCKPKAAOICD(PMKDFPMAACD HKPECGCBGAA, HODMPAADEDL KJADGHOGOGK);
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class APEKIDDNCMJ : HEIODONLACF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private struct DGGPIMECLLC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public AsyncTaskMethodBuilder<ILBJIDDJFAI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public PMKDFPMAACD circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public LECJPJBNNBI cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public NFAAFKCENHI cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private TaskAwaiter<PHFLCIELONP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x26314C0", Offset = "0x26308C0", VA = "0x1826314C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2631690", Offset = "0x2630A90", VA = "0x182631690", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly APEKIDDNCMJ DNEPPKLGBFA;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		private APEKIDDNCMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x262AA20", Offset = "0x2629E20", VA = "0x18262AA20", Slot = "4")]
		[AsyncStateMachine(typeof(DGGPIMECLLC))]
		public Task<ILBJIDDJFAI> LENACGJAIOM(PMKDFPMAACD HKPECGCBGAA, LECJPJBNNBI? NJAIFIIMJEN, NFAAFKCENHI? KDHINLEFFAG, CancellationToken LMNHDKIFBOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x262AB80", Offset = "0x2629F80", VA = "0x18262AB80", Slot = "5")]
		public LEJBIGAEAEM OCKPKAAOICD(PMKDFPMAACD HKPECGCBGAA, HODMPAADEDL KJADGHOGOGK)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct DODOBELFAFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public AsyncTaskMethodBuilder<AEMKHBLCFMH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public PMKDFPMAACD circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public LECJPJBNNBI cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NFAAFKCENHI cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public HODMPAADEDL evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private HEIODONLACF <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter<ILBJIDDJFAI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2631EA0", Offset = "0x26312A0", VA = "0x182631EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2632390", Offset = "0x2631790", VA = "0x182632390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly ILBJIDDJFAI COBCJEJKOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly LEJBIGAEAEM PGHBAJILLLK;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public IAENGEFPAJO BKDDPJLBIFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2629EE0", Offset = "0x26292E0", VA = "0x182629EE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public OIIIPHHKNKK PCKGOHOALLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2629F30", Offset = "0x2629330", VA = "0x182629F30", Slot = "5")]
		get
		{
			return default(OIIIPHHKNKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public HGOPNPABFDI AAIFOEHIEGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9A91D0", Offset = "0x9A85D0", VA = "0x1809A91D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public FECMAMGMIBA AALAMDEEDHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3A0", Offset = "0x9A97A0", VA = "0x1809AA3A0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xE03D50", Offset = "0xE03150", VA = "0x180E03D50")]
	private AEMKHBLCFMH(ILBJIDDJFAI BMMNCLDOHPD, LEJBIGAEAEM AMDKGIOPIPC, HGOPNPABFDI LJKNIIONNBO, FECMAMGMIBA JGIOCDLOJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2629D70", Offset = "0x2629170", VA = "0x182629D70")]
	[AsyncStateMachine(typeof(DODOBELFAFL))]
	public static Task<AEMKHBLCFMH> EDMFFMPPMGB(PMKDFPMAACD HKPECGCBGAA, HODMPAADEDL KJADGHOGOGK, LECJPJBNNBI? NJAIFIIMJEN, NFAAFKCENHI? KDHINLEFFAG, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2629D10", Offset = "0x2629110", VA = "0x182629D10", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class JLEFPKJHFKH : JEHEBBDPAGI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface DCJNAHIDFON
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<ICIGGIMHPMH> COJECPNNGOK(PMKDFPMAACD HKPECGCBGAA, HODMPAADEDL KJADGHOGOGK, LECJPJBNNBI? NJAIFIIMJEN, NFAAFKCENHI? KDHINLEFFAG, CancellationToken LMNHDKIFBOH);

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void KNLNKKBDIHP();

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void MBIFGOEDMPM();
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public abstract class CGMKKHGBCMK : DCJNAHIDFON
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private struct KBLLFNHAHMO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public AsyncTaskMethodBuilder<ICIGGIMHPMH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public PMKDFPMAACD circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public HODMPAADEDL evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public LECJPJBNNBI cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public NFAAFKCENHI cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private TaskAwaiter<AEMKHBLCFMH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x2642B70", Offset = "0x2641F70", VA = "0x182642B70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x2642EB0", Offset = "0x26422B0", VA = "0x182642EB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x262BA70", Offset = "0x262AE70", VA = "0x18262BA70", Slot = "4")]
		[AsyncStateMachine(typeof(KBLLFNHAHMO))]
		public Task<ICIGGIMHPMH> COJECPNNGOK(PMKDFPMAACD HKPECGCBGAA, HODMPAADEDL KJADGHOGOGK, LECJPJBNNBI? NJAIFIIMJEN, NFAAFKCENHI? KDHINLEFFAG, CancellationToken LMNHDKIFBOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void KNLNKKBDIHP();

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void MBIFGOEDMPM();

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		protected CGMKKHGBCMK()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct AEONLCIFAIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AsyncTaskMethodBuilder<ICIGGIMHPMH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public JLEFPKJHFKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskAwaiter<LPCAMBCOBBH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x2629FF0", Offset = "0x26293F0", VA = "0x182629FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x262A1F0", Offset = "0x26295F0", VA = "0x18262A1F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct NBHNDKLFAJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public JLEFPKJHFKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public PMKDFPMAACD circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public HODMPAADEDL evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public LECJPJBNNBI cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public NFAAFKCENHI cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<ICIGGIMHPMH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x2644280", Offset = "0x2643680", VA = "0x182644280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x26447C0", Offset = "0x2643BC0", VA = "0x1826447C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly DCJNAHIDFON AMCNMNPOCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly TaskCompletionSource<LPCAMBCOBBH> NFMGGFLDIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly TaskCompletionSource<LPCAMBCOBBH> DDMHDENKNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly CancellationTokenSource GKCKDNBLFAM;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool IIMBDNJIOCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9D7F20", Offset = "0x9D7320", VA = "0x1809D7F20", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9D7D40", Offset = "0x9D7140", VA = "0x1809D7D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool LCONPCPHNJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xD0D7D0", Offset = "0xD0CBD0", VA = "0x180D0D7D0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1213D10", Offset = "0x1213110", VA = "0x181213D10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool FFBLLMDPIAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x18CD980", Offset = "0x18CCD80", VA = "0x1818CD980")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2642290", Offset = "0x2641690", VA = "0x182642290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ICIGGIMHPMH? IIDHHEENAMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3C0", Offset = "0x9A97C0", VA = "0x1809AA3C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3D0", Offset = "0x9A97D0", VA = "0x1809AA3D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2641EC0", Offset = "0x26412C0", VA = "0x182641EC0", Slot = "7")]
	[AsyncStateMachine(typeof(AEONLCIFAIK))]
	public Task<ICIGGIMHPMH> AECBPLHABPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x26422A0", Offset = "0x26416A0", VA = "0x1826422A0")]
	public JLEFPKJHFKH(DCJNAHIDFON OHJFEHDLOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2642130", Offset = "0x2641530", VA = "0x182642130", Slot = "8")]
	[AsyncStateMachine(typeof(NBHNDKLFAJP))]
	public Task LMAMNKLAABG(PMKDFPMAACD HKPECGCBGAA, HODMPAADEDL KJADGHOGOGK, LECJPJBNNBI? NJAIFIIMJEN, NFAAFKCENHI? KDHINLEFFAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2641FB0", Offset = "0x26413B0", VA = "0x182641FB0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class DEHDNGGPMOH : JNLMBOMGKMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly FECMAMGMIBA EDEKKLCPGHI;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x9B2970", Offset = "0x9B1D70", VA = "0x1809B2970")]
	public DEHDNGGPMOH(FECMAMGMIBA JGIOCDLOJNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal static class LFJHMIGGJDK
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class OACLFKDHLMM<TGraph> : LPCHFMKMBHL where TGraph : HIOKFJEHHDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		protected readonly TGraph KENAGJDIHMC;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public virtual OJJMIEKBAMO? BMLPFNLDHCE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x16FB130", Offset = "0x16FA530", VA = "0x1816FB130", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual HNEIHDEKOKM<EICBKBBFNCN>? AJIMCNHNLDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x16FB130", Offset = "0x16FA530", VA = "0x1816FB130", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IJOGBJOFPED<IIPIDDOCOEJ> LPFNJCCDDLO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x52079F0", Offset = "0x5206DF0", VA = "0x1852079F0", Slot = "5")]
			get
			{
				return default(IJOGBJOFPED<IIPIDDOCOEJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public IJOGBJOFPED<IIPIDDOCOEJ>? OHBCFIDPDPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x5207A10", Offset = "0x5206E10", VA = "0x185207A10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9B2970", Offset = "0x9B1D70", VA = "0x1809B2970")]
		public OACLFKDHLMM(TGraph CHEHNOIOMFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private sealed class FBKFLIJADKB : OACLFKDHLMM<CHFEMOHNAPB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override OJJMIEKBAMO? BMLPFNLDHCE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x2632820", Offset = "0x2631C20", VA = "0x182632820", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override HNEIHDEKOKM<EICBKBBFNCN>? AJIMCNHNLDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x2632840", Offset = "0x2631C40", VA = "0x182632840", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x26328D0", Offset = "0x2631CD0", VA = "0x1826328D0")]
		public FBKFLIJADKB(CHFEMOHNAPB OJOEDCEGLPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x26433A0", Offset = "0x26427A0", VA = "0x1826433A0")]
	public static LPCHFMKMBHL HBLBJMFGHFK(HIOKFJEHHDO CHEHNOIOMFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class DBHFBPJKOOE : FFOFNIPBCNO, GPLOGIMGNCB, NGPIGOMMKDP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class AABCKCMAJJE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private struct <<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public AABCKCMAJJE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public DJODKJGKOCD errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x2646B50", Offset = "0x2645F50", VA = "0x182646B50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x2646DC0", Offset = "0x26461C0", VA = "0x182646DC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public DBHFBPJKOOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public AABCKCMAJJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2629C20", Offset = "0x2629020", VA = "0x182629C20")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task BEFGBHNHPDE(DJODKJGKOCD errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct AINGEJFKMOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public bool checkStringPurity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public DBHFBPJKOOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x262A440", Offset = "0x2629840", VA = "0x18262A440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x262A940", Offset = "0x2629D40", VA = "0x18262A940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class KMIBIJBCOOL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private struct <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public KMIBIJBCOOL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x2646E20", Offset = "0x2646220", VA = "0x182646E20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x2647100", Offset = "0x2646500", VA = "0x182647100", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public DBHFBPJKOOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public KMIBIJBCOOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x26432D0", Offset = "0x26426D0", VA = "0x1826432D0")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task HEBMNMPHAHE(DJODKJGKOCD errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly PLHFHAAMBEI OPBJBMINPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly ICollection<EOECGKJFMCF> GOICHEPJFNG;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private ILKEOPJELCM CPDLFFJNJHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x262F260", Offset = "0x262E660", VA = "0x18262F260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public IJOGBJOFPED<LIGOHIGOKPO> GAAIHMLKCAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xE62A20", Offset = "0xE61E20", VA = "0x180E62A20", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(IJOGBJOFPED<LIGOHIGOKPO>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xE61DD0", Offset = "0xE611D0", VA = "0x180E61DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private IJOGBJOFPED<DNIBKHBHLOO> FMEGNDMJHAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x11E83A0", Offset = "0x11E77A0", VA = "0x1811E83A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IJOGBJOFPED<KHMKGBDANIH> AFPNFEFGJHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9D1DA0", Offset = "0x9D11A0", VA = "0x1809D1DA0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(IJOGBJOFPED<KHMKGBDANIH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override IJOGBJOFPED<BIBBOHDALII> EKFHDFPKDGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2630DB0", Offset = "0x26301B0", VA = "0x182630DB0", Slot = "21")]
		get
		{
			return default(IJOGBJOFPED<BIBBOHDALII>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool JKAEGODNDPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2630470", Offset = "0x262F870", VA = "0x182630470", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x26312A0", Offset = "0x26306A0", VA = "0x1826312A0")]
	private DBHFBPJKOOE(PMKDFPMAACD HKPECGCBGAA, BCCBPIEBIKF BLGGFHHEDNC, PLHFHAAMBEI NNCFJLPOCAP, IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI, IJOGBJOFPED<LIGOHIGOKPO> DGBNICFCJPK, IJOGBJOFPED<DNIBKHBHLOO> LPLICMPKNLI, bool KLOGPAEEFAN, string IGEPDAOOLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x262F280", Offset = "0x262E680", VA = "0x18262F280")]
	public static DBHFBPJKOOE HBLBJMFGHFK(PMKDFPMAACD HKPECGCBGAA, BCCBPIEBIKF BLGGFHHEDNC, PLHFHAAMBEI PJCOHHCODGF, IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI, IJOGBJOFPED<DNIBKHBHLOO> LPLICMPKNLI, IJOGBJOFPED<LIGOHIGOKPO> DGBNICFCJPK, bool KLOGPAEEFAN, bool NOHGKBLCEDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x262F120", Offset = "0x262E520", VA = "0x18262F120", Slot = "22")]
	protected override void GDCNGOALEGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x262F080", Offset = "0x262E480", VA = "0x18262F080", Slot = "23")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x262EC20", Offset = "0x262E020", VA = "0x18262EC20", Slot = "31")]
	public void BDGMLKJPKBD(EOECGKJFMCF IKPLCGOBKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2630A30", Offset = "0x262FE30", VA = "0x182630A30", Slot = "28")]
	public void NGMOHDFDFEB(HDNELEGPGHF MKCLNGCPMCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x262F900", Offset = "0x262ED00", VA = "0x18262F900", Slot = "29")]
	public void HOKHCGLJCEF(BHIDGPKHPIM IKONOHPDFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x26302A0", Offset = "0x262F6A0", VA = "0x1826302A0", Slot = "24")]
	protected override void JDMOBJOOKOJ(DJIECCABCIC CGFEEKFOMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2630670", Offset = "0x262FA70", VA = "0x182630670", Slot = "33")]
	public string KMJBNOGNFLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2630FE0", Offset = "0x26303E0", VA = "0x182630FE0", Slot = "30")]
	public string PKHEPKOECPL(int NKOOKMNGKGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x262ECD0", Offset = "0x262E0D0", VA = "0x18262ECD0")]
	private void BNBBBDMGOGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x26305B0", Offset = "0x262F9B0", VA = "0x1826305B0", Slot = "32")]
	public void KLJLOHHGJCH(EOECGKJFMCF IKPLCGOBKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x262F630", Offset = "0x262EA30", VA = "0x18262F630")]
	private void HCJBKMAOKJL(bool FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x262F7F0", Offset = "0x262EBF0", VA = "0x18262F7F0", Slot = "34")]
	[AsyncStateMachine(typeof(AINGEJFKMOC))]
	public Task HDEGBFNCMGF(string FFOEEMKIKJO, bool JGBFBDJNDGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2630E90", Offset = "0x2630290", VA = "0x182630E90")]
	public void PICKALKJJNO(string FFOEEMKIKJO, bool JGBFBDJNDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x262EA80", Offset = "0x262DE80", VA = "0x18262EA80")]
	private void ABMFFNEEFGK(int FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0xE61DD0", Offset = "0xE611D0", VA = "0x180E61DD0")]
	internal void FKONAJMIJCF(IJOGBJOFPED<LIGOHIGOKPO> FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x262F250", Offset = "0x262E650", VA = "0x18262F250")]
	[CompilerGenerated]
	private void GGGLHOCMEOI(string FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x26304F0", Offset = "0x262F8F0", VA = "0x1826304F0")]
	[CompilerGenerated]
	private bool KIGAPHDCHLM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2630970", Offset = "0x262FD70", VA = "0x182630970")]
	[CompilerGenerated]
	private bool NBFMFGNCJHA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x262EC80", Offset = "0x262E080", VA = "0x18262EC80")]
	[CompilerGenerated]
	private int KHAEGBIPODN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x262F1C0", Offset = "0x262E5C0", VA = "0x18262F1C0")]
	[CompilerGenerated]
	private bool GFADMBFPEIK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2630DA0", Offset = "0x26301A0", VA = "0x182630DA0")]
	[CompilerGenerated]
	private void ODOIEFPMFIC(string FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x262EEF0", Offset = "0x262E2F0", VA = "0x18262EEF0")]
	[CompilerGenerated]
	private bool CCBOKMAMANB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x26307D0", Offset = "0x262FBD0", VA = "0x1826307D0")]
	[CompilerGenerated]
	private bool KOIAMBNLKDC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2630E00", Offset = "0x2630200", VA = "0x182630E00")]
	[CompilerGenerated]
	private bool OPAOPEDHFMP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x262EC80", Offset = "0x262E080", VA = "0x18262EC80")]
	[CompilerGenerated]
	private int BGHIGKHLGIC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x26308A0", Offset = "0x262FCA0", VA = "0x1826308A0")]
	[CompilerGenerated]
	private bool MEIIBNOCMKP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x26303F0", Offset = "0x262F7F0", VA = "0x1826303F0")]
	[CompilerGenerated]
	private object JFAIINNLBHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2630820", Offset = "0x262FC20", VA = "0x182630820")]
	[CompilerGenerated]
	private void LCDDDKHDPBG(object FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x262EFB0", Offset = "0x262E3B0", VA = "0x18262EFB0")]
	[CompilerGenerated]
	private bool CDBCJCINAFM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class IDPMFOJKPHH
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private sealed class FIOLGMCHOND : HHCHLJOKMMO<IDNKAOGOLMM>
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private sealed class MHMPONHBAFI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public FIOLGMCHOND <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public BKCAMONFAFL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public MHMPONHBAFI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x2643D90", Offset = "0x2643190", VA = "0x182643D90")]
			internal object ALHMIJFJECG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x2643E00", Offset = "0x2643200", VA = "0x182643E00")]
			internal void IAJMEFMNOEC(object value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2632F80", Offset = "0x2632380", VA = "0x182632F80")]
		public FIOLGMCHOND(PMKDFPMAACD HKPECGCBGAA, IDNKAOGOLMM BGCEKLPNCIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2632CF0", Offset = "0x26320F0", VA = "0x182632CF0", Slot = "134")]
		protected override void FLHCPNPGMGE(NNDHABFGLGH HIFAJDOJEBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class HHAOCJJOJFK : FCAMMJMIMIJ<BFJBJKIJCDD>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override MCEBFGLGPKE JBBONNLGILK
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xB222B0", Offset = "0xB216B0", VA = "0x180B222B0", Slot = "140")]
			get
			{
				return default(MCEBFGLGPKE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x26341E0", Offset = "0x26335E0", VA = "0x1826341E0")]
		public HHAOCJJOJFK(PMKDFPMAACD HKPECGCBGAA, BFJBJKIJCDD BGCEKLPNCIL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class GBCDPPCGELA : HHCHLJOKMMO<LCEBCMCJHGJ>
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x26332F0", Offset = "0x26326F0", VA = "0x1826332F0")]
		public GBCDPPCGELA(PMKDFPMAACD HKPECGCBGAA, LCEBCMCJHGJ BLGGFHHEDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2633120", Offset = "0x2632520", VA = "0x182633120", Slot = "134")]
		protected override void FLHCPNPGMGE(NNDHABFGLGH HIFAJDOJEBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x26332A0", Offset = "0x26326A0", VA = "0x1826332A0")]
		[CompilerGenerated]
		private bool KHIMPFJEEAA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2632FF0", Offset = "0x26323F0", VA = "0x182632FF0")]
		[CompilerGenerated]
		private void DOHLLNIKDPO(bool FFOEEMKIKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public sealed class NAGPHBPGMPK : HHCHLJOKMMO<CLDLHHGKMCE>
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class DAILKOOENDO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public BKCAMONFAFL nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public NAGPHBPGMPK <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public DAILKOOENDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x262C710", Offset = "0x262BB10", VA = "0x18262C710")]
			internal void ALHMIJFJECG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x262C760", Offset = "0x262BB60", VA = "0x18262C760")]
			internal bool IAJMEFMNOEC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x262C7B0", Offset = "0x262BBB0", VA = "0x18262C7B0")]
			internal bool KAFKDPLFJPI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x262C800", Offset = "0x262BC00", VA = "0x18262C800")]
			internal void LDMBHEIPGFP(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x262C930", Offset = "0x262BD30", VA = "0x18262C930")]
			internal bool NBLMJKLKFBL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2644210", Offset = "0x2643610", VA = "0x182644210")]
		public NAGPHBPGMPK(PMKDFPMAACD HKPECGCBGAA, CLDLHHGKMCE BLGGFHHEDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2643ED0", Offset = "0x26432D0", VA = "0x182643ED0", Slot = "134")]
		protected override void FLHCPNPGMGE(NNDHABFGLGH HIFAJDOJEBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public sealed class KAPEOINFPME : HHCHLJOKMMO<GCLNEEKKPDL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private sealed class CAFEEMANACB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public BKCAMONFAFL nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public KAPEOINFPME <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public CAFEEMANACB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x262AC80", Offset = "0x262A080", VA = "0x18262AC80")]
			internal object ALHMIJFJECG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x262B1E0", Offset = "0x262A5E0", VA = "0x18262B1E0")]
			internal bool LJMAPIPPFJE(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x262AD80", Offset = "0x262A180", VA = "0x18262AD80")]
			internal void IAJMEFMNOEC(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x262AFE0", Offset = "0x262A3E0", VA = "0x18262AFE0")]
			internal string KAFKDPLFJPI(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x262B190", Offset = "0x262A590", VA = "0x18262B190")]
			internal IReadOnlyList<object> LDMBHEIPGFP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x262B260", Offset = "0x262A660", VA = "0x18262B260")]
			internal bool NBLMJKLKFBL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x262B140", Offset = "0x262A540", VA = "0x18262B140")]
			internal bool KLEOIOCGGAJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x262B2D0", Offset = "0x262A6D0", VA = "0x18262B2D0")]
			internal void PKLLKHLFNMA(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2642B00", Offset = "0x2641F00", VA = "0x182642B00")]
		public KAPEOINFPME(PMKDFPMAACD HKPECGCBGAA, GCLNEEKKPDL BLGGFHHEDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x26423B0", Offset = "0x26417B0", VA = "0x1826423B0", Slot = "134")]
		protected override void FLHCPNPGMGE(NNDHABFGLGH HIFAJDOJEBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public sealed class KJNNMKPNCKD : HHCHLJOKMMO<AAMCOINJLGJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private sealed class IJAKJLLKLAE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public KJNNMKPNCKD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public BKCAMONFAFL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public IJAKJLLKLAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x2641170", Offset = "0x2640570", VA = "0x182641170")]
			internal bool ALHMIJFJECG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x26411C0", Offset = "0x26405C0", VA = "0x1826411C0")]
			internal void IAJMEFMNOEC(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x26412F0", Offset = "0x26406F0", VA = "0x1826412F0")]
			internal bool KAFKDPLFJPI()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2643260", Offset = "0x2642660", VA = "0x182643260")]
		public KJNNMKPNCKD(PMKDFPMAACD HKPECGCBGAA, AAMCOINJLGJ BLGGFHHEDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2643030", Offset = "0x2642430", VA = "0x182643030", Slot = "134")]
		protected override void FLHCPNPGMGE(NNDHABFGLGH HIFAJDOJEBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public abstract class FHBOOAPBNPC<TNode> : HHCHLJOKMMO<TNode> where TNode : notnull, GJPCLKCBLBD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct CJLAIEJJCJJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public AsyncTaskMethodBuilder<KGPHFOFOMPJ<IJOGBJOFPED<AFJOOIBLMOP>, HEGOEPNOLEN>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public FHBOOAPBNPC<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private TaskAwaiter<KGPHFOFOMPJ<IJOGBJOFPED<AFJOOIBLMOP>, HEGOEPNOLEN>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x63F6E90", Offset = "0x63F6290", VA = "0x1863F6E90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x63F72A0", Offset = "0x63F66A0", VA = "0x1863F72A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[CompilerGenerated]
		private struct IGMJAACMFKF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public AsyncTaskMethodBuilder<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public FHBOOAPBNPC<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public IJOGBJOFPED<AFJOOIBLMOP> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x4A13A10", Offset = "0x4A12E10", VA = "0x184A13A10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x4A13E20", Offset = "0x4A13220", VA = "0x184A13E20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public sealed override bool FLGLKBPKNCB
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "129")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public sealed override IJOGBJOFPED<AFJOOIBLMOP>? PKDDAJCIFPD
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x4755530", Offset = "0x4754930", VA = "0x184755530", Slot = "133")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x47554E0", Offset = "0x47548E0", VA = "0x1847554E0")]
		protected FHBOOAPBNPC(PMKDFPMAACD HKPECGCBGAA, TNode BLGGFHHEDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4755170", Offset = "0x4754570", VA = "0x184755170", Slot = "114")]
		[AsyncStateMachine(typeof(FHBOOAPBNPC<>.CJLAIEJJCJJ))]
		public override Task<KGPHFOFOMPJ<IJOGBJOFPED<AFJOOIBLMOP>, HEGOEPNOLEN>> BDFFCBIGLCL(string IGEPDAOOLBO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x47550D0", Offset = "0x47544D0", VA = "0x1847550D0", Slot = "138")]
		public sealed override bool AOHMLNNHGLN(IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4755290", Offset = "0x4754690", VA = "0x184755290", Slot = "126")]
		protected sealed override bool EHGKJNMCKGF(IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4755440", Offset = "0x4754840", VA = "0x184755440", Slot = "127")]
		protected override bool LIGEKJLFNED(IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4755330", Offset = "0x4754730", VA = "0x184755330", Slot = "115")]
		[AsyncStateMachine(typeof(FHBOOAPBNPC<>.IGMJAACMFKF))]
		public override Task<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> HHAHLAJIHHF(IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public sealed class OMHCMNCCCGP : ENGBJFABJNB<MNHDADKJDOD>
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private sealed class FDBBMLOEBPJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public OMHCMNCCCGP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public BKCAMONFAFL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public FDBBMLOEBPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x26329A0", Offset = "0x2631DA0", VA = "0x1826329A0")]
			internal bool LJPGDPLINLK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x2632A20", Offset = "0x2631E20", VA = "0x182632A20")]
			internal void PEEDKFDAMEI(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2644CA0", Offset = "0x26440A0", VA = "0x182644CA0")]
		public OMHCMNCCCGP(PMKDFPMAACD HKPECGCBGAA, MNHDADKJDOD BGCEKLPNCIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2644A50", Offset = "0x2643E50", VA = "0x182644A50", Slot = "140")]
		protected override void CKCDLJMHANF(NNDHABFGLGH HIFAJDOJEBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class BDOHEPFFCBM : ABKAIAOKPEM<FHALKACPIPL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override NodeVisualizationKey KKGMNHPHOBN
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xB232D0", Offset = "0xB226D0", VA = "0x180B232D0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x262AC20", Offset = "0x262A020", VA = "0x18262AC20")]
		public BDOHEPFFCBM(PMKDFPMAACD HKPECGCBGAA, FHALKACPIPL BLGGFHHEDNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public abstract class ABKAIAOKPEM<TNode> : HHCHLJOKMMO<TNode> where TNode : notnull, CEGCBCFIBOI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct NFENHGIHFLD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public AsyncTaskMethodBuilder<KGPHFOFOMPJ<IJOGBJOFPED<AFJOOIBLMOP>, HEGOEPNOLEN>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public ABKAIAOKPEM<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			private TaskAwaiter<KGPHFOFOMPJ<IJOGBJOFPED<AFJOOIBLMOP>, HEGOEPNOLEN>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x50E2110", Offset = "0x50E1510", VA = "0x1850E2110", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x50E25B0", Offset = "0x50E19B0", VA = "0x1850E25B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct NCAPFMGCCEJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public AsyncTaskMethodBuilder<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public ABKAIAOKPEM<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public IJOGBJOFPED<AFJOOIBLMOP> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x50D5330", Offset = "0x50D4730", VA = "0x1850D5330", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x50D5730", Offset = "0x50D4B30", VA = "0x1850D5730", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private struct EMPALKOBPOG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public AsyncTaskMethodBuilder<KGPHFOFOMPJ<NMJFPHJOOOF, HEGOEPNOLEN>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public ABKAIAOKPEM<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private TaskAwaiter<KGPHFOFOMPJ<NMJFPHJOOOF, HEGOEPNOLEN>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x42ED340", Offset = "0x42EC740", VA = "0x1842ED340", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x42ED9F0", Offset = "0x42ECDF0", VA = "0x1842ED9F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private sealed class MBNGDAFPABJ
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			private struct <<BuildConfigMenuInternal>b__7>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				public MBNGDAFPABJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000153")]
				[Cpp2IlInjected.Address(RVA = "0x3E8BAB0", Offset = "0x3E8AEB0", VA = "0x183E8BAB0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000154")]
				[Cpp2IlInjected.Address(RVA = "0xA0AFE0", Offset = "0xA0A3E0", VA = "0x180A0AFE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public NNDHABFGLGH configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public BKCAMONFAFL nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public ABKAIAOKPEM<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public Func<string, bool> <>9__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public Action <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public MBNGDAFPABJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x5046B60", Offset = "0x5045F60", VA = "0x185046B60")]
			internal bool PKLLKHLFNMA(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x5046400", Offset = "0x5045800", VA = "0x185046400")]
			internal void ALHMIJFJECG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x5046AC0", Offset = "0x5045EC0", VA = "0x185046AC0")]
			[AsyncStateMachine(typeof(ABKAIAOKPEM<>.MBNGDAFPABJ.<<BuildConfigMenuInternal>b__7>d))]
			internal void LJMAPIPPFJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x50466D0", Offset = "0x5045AD0", VA = "0x1850466D0")]
			internal bool IAJMEFMNOEC()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		[CompilerGenerated]
		private sealed class NMIAKIFCHIG
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000053")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public NMIAKIFCHIG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				private TaskAwaiter<TaskStatus> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600015A")]
				[Cpp2IlInjected.Address(RVA = "0x3E8B740", Offset = "0x3E8AB40", VA = "0x183E8B740", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0xA0AFE0", Offset = "0xA0A3E0", VA = "0x180A0AFE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public string newFunctionName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public MBNGDAFPABJ CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public Func<string> <>9__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public Action<string> <>9__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public Action <>9__5;

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public NMIAKIFCHIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x5104260", Offset = "0x5103660", VA = "0x185104260")]
			internal void KAFKDPLFJPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
			internal string LDMBHEIPGFP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x9AA4D0", Offset = "0x9A98D0", VA = "0x1809AA4D0")]
			internal void NBLMJKLKFBL(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x5104670", Offset = "0x5103A70", VA = "0x185104670")]
			[AsyncStateMachine(typeof(ABKAIAOKPEM<>.NMIAKIFCHIG.<<BuildConfigMenuInternal>b__5>d))]
			internal void KLEOIOCGGAJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[CompilerGenerated]
		private sealed class CGDOOIDMGHO
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			private struct <<AddDynamicNodeGroupSettingV2>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				public CGDOOIDMGHO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0x3E8B270", Offset = "0x3E8A670", VA = "0x183E8B270", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0xA0AFE0", Offset = "0xA0A3E0", VA = "0x180A0AFE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000056")]
			private struct <<AddDynamicNodeGroupSettingV2>b__6>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000102")]
				public CGDOOIDMGHO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000103")]
				private TaskAwaiter<KGPHFOFOMPJ<IJOGBJOFPED<DNIBKHBHLOO>, HEGOEPNOLEN>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0x3E8B450", Offset = "0x3E8A850", VA = "0x183E8B450", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000172")]
				[Cpp2IlInjected.Address(RVA = "0xA0AFE0", Offset = "0xA0A3E0", VA = "0x180A0AFE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000057")]
			private struct <<AddDynamicNodeGroupSettingV2>b__10>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000104")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000105")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				public CGDOOIDMGHO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				private TaskAwaiter<KGPHFOFOMPJ<IJOGBJOFPED<AKEIPLNFNIN>, HEGOEPNOLEN>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000173")]
				[Cpp2IlInjected.Address(RVA = "0x3E8ABC0", Offset = "0x3E89FC0", VA = "0x183E8ABC0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0xA0AFE0", Offset = "0xA0A3E0", VA = "0x180A0AFE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public ABKAIAOKPEM<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public IJOGBJOFPED<AFJOOIBLMOP> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public NNDHABFGLGH configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public BKCAMONFAFL nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public JGCPKBOFLCP nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public int minGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public int maxGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public EGMEIGIGMNI selectedInputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public string newInputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public List<FMDKLJMLCFC> inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public EGMEIGIGMNI selectedOutputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public string newOutputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public List<FMDKLJMLCFC> outputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public Func<string, bool> <>9__17;

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public CGDOOIDMGHO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x63E6CB0", Offset = "0x63E60B0", VA = "0x1863E6CB0")]
			internal bool AIDPMLMOLAI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x63E6FB0", Offset = "0x63E63B0", VA = "0x1863E6FB0")]
			internal void ELMOCKJIMIP(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x63E6F40", Offset = "0x63E6340", VA = "0x1863E6F40")]
			internal bool EGEJFEANGAB(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x63E7020", Offset = "0x63E6420", VA = "0x1863E7020")]
			internal bool ENEOMKCBCNH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x63E6EA0", Offset = "0x63E62A0", VA = "0x1863E6EA0")]
			[AsyncStateMachine(typeof(ABKAIAOKPEM<>.CGDOOIDMGHO.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void CKHOANIOKLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x63E7190", Offset = "0x63E6590", VA = "0x1863E7190")]
			internal bool GFOCLDGIKJG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x63E7060", Offset = "0x63E6460", VA = "0x1863E7060")]
			internal void FDFFBOBENAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x63E7450", Offset = "0x63E6850", VA = "0x1863E7450")]
			internal bool LDPLNJNIGBC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x63E7500", Offset = "0x63E6900", VA = "0x1863E7500")]
			internal void MNCKGMODOKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x63E6DF0", Offset = "0x63E61F0", VA = "0x1863E6DF0")]
			internal bool BKFAKALOBML()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x63E7120", Offset = "0x63E6520", VA = "0x1863E7120")]
			internal bool GBMFEPJGPJC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x63E71D0", Offset = "0x63E65D0", VA = "0x1863E71D0")]
			internal void GMJMACAGDKP(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x63E7240", Offset = "0x63E6640", VA = "0x1863E7240")]
			[AsyncStateMachine(typeof(ABKAIAOKPEM<>.CGDOOIDMGHO.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void HMECFBGPNOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x63E72E0", Offset = "0x63E66E0", VA = "0x1863E72E0")]
			internal bool HNJLMPFMPGP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x63E7340", Offset = "0x63E6740", VA = "0x1863E7340")]
			internal bool JIGIOCDHIKK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x63E6D80", Offset = "0x63E6180", VA = "0x1863E6D80")]
			internal void BCHMLJJLJDG(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x63E73B0", Offset = "0x63E67B0", VA = "0x1863E73B0")]
			[AsyncStateMachine(typeof(ABKAIAOKPEM<>.CGDOOIDMGHO.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void JIGKBEIIBCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x63E6D20", Offset = "0x63E6120", VA = "0x1863E6D20")]
			internal bool AKCNONALIPK()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		[CompilerGenerated]
		private sealed class FNKBJPOPPAD
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000059")]
			private struct <<AddDynamicNodeGroupSettingV2>b__16>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public FNKBJPOPPAD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600017A")]
				[Cpp2IlInjected.Address(RVA = "0x3E8AEB0", Offset = "0x3E8A2B0", VA = "0x183E8AEB0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600017B")]
				[Cpp2IlInjected.Address(RVA = "0xA0AFE0", Offset = "0xA0A3E0", VA = "0x180A0AFE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public CGDOOIDMGHO CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public Func<string> <>9__14;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public Action<string> <>9__15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public Action <>9__16;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public FNKBJPOPPAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x4781300", Offset = "0x4780700", VA = "0x184781300")]
			internal void MKFKKLDHALI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
			internal string FBOCOBGGNHM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x9AA4D0", Offset = "0x9A98D0", VA = "0x1809AA4D0")]
			internal void EDDOCEHJHOK(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x4781260", Offset = "0x4780660", VA = "0x184781260")]
			[AsyncStateMachine(typeof(ABKAIAOKPEM<>.FNKBJPOPPAD.<<AddDynamicNodeGroupSettingV2>b__16>d))]
			internal void AJCGJHGNNFC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private sealed class MHDIPFCGEAP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public JGCPKBOFLCP nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public List<FMDKLJMLCFC> portMenu;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public ABKAIAOKPEM<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public IJOGBJOFPED<AFJOOIBLMOP> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public int portCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public Func<bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public MHDIPFCGEAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x505E3A0", Offset = "0x505D7A0", VA = "0x18505E3A0")]
			internal bool NFODIKPNJEM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private sealed class KOMMHJPICPB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public NGPIGOMMKDP port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public MHDIPFCGEAP CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public KOMMHJPICPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x4DC9680", Offset = "0x4DC8A80", VA = "0x184DC9680")]
			internal void DFAJBJPHGFI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x4DC98B0", Offset = "0x4DC8CB0", VA = "0x184DC98B0")]
			internal bool HDJNFNJPMLA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x4DC9790", Offset = "0x4DC8B90", VA = "0x184DC9790")]
			internal void GBABCKJANJI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x4DC9900", Offset = "0x4DC8D00", VA = "0x184DC9900")]
			internal bool MLBOLBNKPJJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class ONMJNBGAGIO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public FMDKLJMLCFC portControls;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public KOMMHJPICPB CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public ONMJNBGAGIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x52316C0", Offset = "0x5230AC0", VA = "0x1852316C0")]
			internal void KIKKMKICICL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		[CompilerGenerated]
		private sealed class DDNFBMMGJEM
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005E")]
			private struct <<CreatePortItemV2>b__3>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000124")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000125")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000126")]
				public DDNFBMMGJEM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000127")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000128")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000129")]
				private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600018B")]
				[Cpp2IlInjected.Address(RVA = "0x3E8CEE0", Offset = "0x3E8C2E0", VA = "0x183E8CEE0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600018C")]
				[Cpp2IlInjected.Address(RVA = "0xA0AFE0", Offset = "0xA0A3E0", VA = "0x180A0AFE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public List<object> allTypeObjects;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public EGMEIGIGMNI selectedType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public JGCPKBOFLCP nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public NGPIGOMMKDP port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public BKCAMONFAFL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public DDNFBMMGJEM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x66CDE50", Offset = "0x66CD250", VA = "0x1866CDE50")]
			internal int ONFKNFBNEBH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x66CDB30", Offset = "0x66CCF30", VA = "0x1866CDB30")]
			internal void EJIPCJJJEHI(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x9AA3C0", Offset = "0x9A97C0", VA = "0x1809AA3C0")]
			internal string FGOCAEIAIFM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x66CDA70", Offset = "0x66CCE70", VA = "0x1866CDA70")]
			[AsyncStateMachine(typeof(ABKAIAOKPEM<>.DDNFBMMGJEM.<<CreatePortItemV2>b__3>d))]
			internal void CIMCAPAANMJ(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x66CDD70", Offset = "0x66CD170", VA = "0x1866CDD70")]
			internal bool ELGPLIEAEBE(string text)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private readonly Dictionary<IJOGBJOFPED<AFJOOIBLMOP>, bool> AHHFDNBGCEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private readonly Dictionary<IJOGBJOFPED<AFJOOIBLMOP>, bool> CHJHCHOIHLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly Dictionary<IJOGBJOFPED<AFJOOIBLMOP>, bool> MDKBBIIMEPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private Dictionary<IJOGBJOFPED<AFJOOIBLMOP>, bool> ADOMGIGCGKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private Dictionary<IJOGBJOFPED<AFJOOIBLMOP>, bool> MFDEAMMDINH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private Dictionary<IJOGBJOFPED<AFJOOIBLMOP>, bool> FDIPPALMAGE;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool KFLEDBFNICP
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "136")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected virtual bool MLLCCNKLBPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		protected virtual bool ADABGJHOMAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "141")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		protected virtual bool AEPOJNFGFOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "142")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override IJOGBJOFPED<IIPIDDOCOEJ>? GHHADPCKABF
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x4802420", Offset = "0x4801820", VA = "0x184802420", Slot = "130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override IJOGBJOFPED<AFJOOIBLMOP>? PKDDAJCIFPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x48026D0", Offset = "0x4801AD0", VA = "0x1848026D0", Slot = "133")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override IEnumerable<HNEIHDEKOKM<EICBKBBFNCN>>? OKKGFNIOAKD
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x48024D0", Offset = "0x48018D0", VA = "0x1848024D0", Slot = "125")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x4802200", Offset = "0x4801600", VA = "0x184802200")]
		public ABKAIAOKPEM(PMKDFPMAACD HKPECGCBGAA, TNode BLGGFHHEDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "143")]
		protected virtual bool PPKLGCDADNI(int OFFIMAFDANK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "144")]
		protected virtual bool DDDFCJPNNHA(int OFFIMAFDANK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "145")]
		protected virtual bool AOBIPNBFHKF(int OFFIMAFDANK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "146")]
		protected virtual void HCHFNJAOMCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x47FD8B0", Offset = "0x47FCCB0", VA = "0x1847FD8B0", Slot = "138")]
		public override bool AOHMLNNHGLN(IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x47FD950", Offset = "0x47FCD50", VA = "0x1847FD950", Slot = "114")]
		[AsyncStateMachine(typeof(ABKAIAOKPEM<>.NFENHGIHFLD))]
		public override Task<KGPHFOFOMPJ<IJOGBJOFPED<AFJOOIBLMOP>, HEGOEPNOLEN>> BDFFCBIGLCL(string IGEPDAOOLBO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x47FFA40", Offset = "0x47FEE40", VA = "0x1847FFA40", Slot = "115")]
		[AsyncStateMachine(typeof(ABKAIAOKPEM<>.NCAPFMGCCEJ))]
		public override Task<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> HHAHLAJIHHF(IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x47FFB50", Offset = "0x47FEF50", VA = "0x1847FFB50", Slot = "116")]
		public override void ICDHNGFCEJK(IJOGBJOFPED<AFJOOIBLMOP> CJFNAFNJJLB, IJOGBJOFPED<AFJOOIBLMOP> IGICHEAKAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x47FE6B0", Offset = "0x47FDAB0", VA = "0x1847FE6B0", Slot = "117")]
		public override IEnumerable<FCMLLGFOEBF> GAGICMKNCHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x4802100", Offset = "0x4801500", VA = "0x184802100")]
		[AsyncStateMachine(typeof(ABKAIAOKPEM<>.EMPALKOBPOG))]
		private Task<KGPHFOFOMPJ<NMJFPHJOOOF, HEGOEPNOLEN>> OEEKOLDCMEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "147")]
		protected virtual bool AIAGGMOOFAG(IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "148")]
		protected virtual bool GHLEHPMKJMJ(IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "149")]
		protected virtual bool MBKOMJEDINL(IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "150")]
		protected virtual bool BDODOONAIBK(IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "151")]
		protected virtual bool NDNMBGELNLH(IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI, int FOHNIKBLMAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "152")]
		protected virtual bool PKBABGNAGLD(IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI, int FOHNIKBLMAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "153")]
		protected virtual bool FEAEIFHLLHK(IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI, int BGKBCICJJGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "154")]
		protected virtual bool FNOMFAJJNDI(IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI, int BGKBCICJJGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "155")]
		protected virtual bool FIFGNHGMHHA(IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI, int FNJFCLABCPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "156")]
		protected virtual bool KEAHAFLMBJC(IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI, int MCIKILGHAHK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x48006A0", Offset = "0x47FFAA0", VA = "0x1848006A0", Slot = "157")]
		protected virtual List<EGMEIGIGMNI> IKLAKBBJDIO(IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "158")]
		protected virtual void LKPMHJOCOCG(NNDHABFGLGH HIFAJDOJEBN, IHMDNCAPJLH JMNCMAJFBOP, JGCPKBOFLCP NDBIFLKANCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x47FDC60", Offset = "0x47FD060", VA = "0x1847FDC60", Slot = "134")]
		protected override void FLHCPNPGMGE(NNDHABFGLGH HIFAJDOJEBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x48009C0", Offset = "0x47FFDC0", VA = "0x1848009C0")]
		private IHMDNCAPJLH MOOMJJLPDNN(NNDHABFGLGH HIFAJDOJEBN, JGCPKBOFLCP NDBIFLKANCG, IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x47FE910", Offset = "0x47FDD10", VA = "0x1847FE910")]
		private List<FMDKLJMLCFC> GEOHEFMCEAG(NNDHABFGLGH HIFAJDOJEBN, JGCPKBOFLCP NDBIFLKANCG, IHMDNCAPJLH MPMKENNHIJE, bool COMKEBALMJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x47FFD60", Offset = "0x47FF160", VA = "0x1847FFD60")]
		private List<FMDKLJMLCFC> IIDNJKAGIJH(NNDHABFGLGH HIFAJDOJEBN, JGCPKBOFLCP NDBIFLKANCG, NGPIGOMMKDP LBADMGPENPB, bool COMKEBALMJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x47FDA70", Offset = "0x47FCE70", VA = "0x1847FDA70")]
		private EGMEIGIGMNI DNMOPIELNGK(List<EGMEIGIGMNI> EIPFAHINMDD, NGPIGOMMKDP LBADMGPENPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x4800930", Offset = "0x47FFD30", VA = "0x184800930")]
		[CompilerGenerated]
		private FCMLLGFOEBF KOGBLDEGNFH(BCCBPIEBIKF JKHIIFLAPEC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class PDACIHHAGLN : HHCHLJOKMMO<CDLBOJIBOHH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000060")]
		[CompilerGenerated]
		private sealed class HACLDMNEFDB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public PDACIHHAGLN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public BKCAMONFAFL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public HACLDMNEFDB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x2633600", Offset = "0x2632A00", VA = "0x182633600")]
			internal int ALHMIJFJECG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x2633650", Offset = "0x2632A50", VA = "0x182633650")]
			internal void IAJMEFMNOEC(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey KKGMNHPHOBN
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xFBB810", Offset = "0xFBAC10", VA = "0x180FBB810", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2645150", Offset = "0x2644550", VA = "0x182645150")]
		public PDACIHHAGLN(PMKDFPMAACD HKPECGCBGAA, CDLBOJIBOHH BLGGFHHEDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2644F90", Offset = "0x2644390", VA = "0x182644F90", Slot = "134")]
		protected override void FLHCPNPGMGE(NNDHABFGLGH HIFAJDOJEBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class GLPHDNDKCIM : ENGBJFABJNB<FIKPFOMLKDG>
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		[CompilerGenerated]
		private sealed class ECGOBFMJEIK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public GLPHDNDKCIM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public BKCAMONFAFL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public ECGOBFMJEIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x2632400", Offset = "0x2631800", VA = "0x182632400")]
			internal int LJPGDPLINLK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x2632480", Offset = "0x2631880", VA = "0x182632480")]
			internal void PEEDKFDAMEI(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x26335A0", Offset = "0x26329A0", VA = "0x1826335A0")]
		public GLPHDNDKCIM(PMKDFPMAACD HKPECGCBGAA, FIKPFOMLKDG BGCEKLPNCIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2633360", Offset = "0x2632760", VA = "0x182633360", Slot = "140")]
		protected override void CKCDLJMHANF(NNDHABFGLGH HIFAJDOJEBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	private sealed class LNDPLKDKLFG : HHCHLJOKMMO<COKKNHOIHIO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey KKGMNHPHOBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xCFCCC0", Offset = "0xCFC0C0", VA = "0x180CFCCC0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2643880", Offset = "0x2642C80", VA = "0x182643880")]
		public LNDPLKDKLFG(PMKDFPMAACD HKPECGCBGAA, COKKNHOIHIO BLGGFHHEDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "134")]
		protected override void FLHCPNPGMGE(NNDHABFGLGH HIFAJDOJEBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public sealed class DBGPJLBIGFB : HHCHLJOKMMO<CMKKJFLKNLH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class HNBFHGNLJDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public DBGPJLBIGFB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public NNDHABFGLGH configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public Func<string> <>9__224;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public Action<string> <>9__225;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public Func<int> <>9__228;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public Action<int> <>9__229;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public Func<bool> <>9__230;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public Func<bool> <>9__231;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public Func<bool> <>9__232;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public Func<float> <>9__233;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public Action<float> <>9__234;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public Func<bool> <>9__235;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public Func<bool> <>9__236;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public Func<bool> <>9__237;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public Func<string> <>9__238;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public Action<string> <>9__239;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public HNBFHGNLJDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x2634A60", Offset = "0x2633E60", VA = "0x182634A60")]
			internal bool ALHMIJFJECG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x2636F00", Offset = "0x2636300", VA = "0x182636F00")]
			internal void IAJMEFMNOEC(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x26381F0", Offset = "0x26375F0", VA = "0x1826381F0")]
			internal bool NBLMJKLKFBL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x2637940", Offset = "0x2636D40", VA = "0x182637940")]
			internal bool KLEOIOCGGAJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x263F240", Offset = "0x263E640", VA = "0x18263F240")]
			internal void PKLLKHLFNMA(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x263EA50", Offset = "0x263DE50", VA = "0x18263EA50")]
			internal bool OLKABLCNKLK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x2635760", Offset = "0x2634B60", VA = "0x182635760")]
			internal bool EHFCFMENIHG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x263EC80", Offset = "0x263E080", VA = "0x18263EC80")]
			internal void OONOAJFIHIP(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x2637100", Offset = "0x2636500", VA = "0x182637100")]
			internal bool JBLJGJPFHKK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x2635560", Offset = "0x2634960", VA = "0x182635560")]
			internal bool EDBNIGPFKKB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x2634760", Offset = "0x2633B60", VA = "0x182634760")]
			internal void ACHMACFJJAP(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x263E570", Offset = "0x263D970", VA = "0x18263E570")]
			internal bool NMLFDDCNIDE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x2634D60", Offset = "0x2634160", VA = "0x182634D60")]
			internal bool BFIKAJIOAIM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x26381A0", Offset = "0x26375A0", VA = "0x1826381A0")]
			internal bool MPKNJKFPFHC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x2636140", Offset = "0x2635540", VA = "0x182636140")]
			internal bool GCIODKMEIBI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x2635A90", Offset = "0x2634E90", VA = "0x182635A90")]
			internal bool FCENMCJNOMK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x2637A80", Offset = "0x2636E80", VA = "0x182637A80")]
			internal bool LBJLIMHCHIG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x2635910", Offset = "0x2634D10", VA = "0x182635910")]
			internal bool EPAFGEJCIOP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x263ECE0", Offset = "0x263E0E0", VA = "0x18263ECE0")]
			internal bool PALGILKDKKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x2637D10", Offset = "0x2637110", VA = "0x182637D10")]
			internal bool LNAMEPLAKCA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x2636680", Offset = "0x2635A80", VA = "0x182636680")]
			internal void GHFIALAHFDF(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x26371F0", Offset = "0x26365F0", VA = "0x1826371F0")]
			internal bool JHHNCMAIDIM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x2636A70", Offset = "0x2635E70", VA = "0x182636A70")]
			internal bool HBEIPAGNPLB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x2634EA0", Offset = "0x26342A0", VA = "0x182634EA0")]
			internal bool BLDFAHOMPMC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x263E9B0", Offset = "0x263DDB0", VA = "0x18263E9B0")]
			internal bool OJPKLBNCPEM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x26350D0", Offset = "0x26344D0", VA = "0x1826350D0")]
			internal bool CBIEGAPBCJP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x2635030", Offset = "0x2634430", VA = "0x182635030")]
			internal bool CAFAAHGAFGL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x26348D0", Offset = "0x2633CD0", VA = "0x1826348D0")]
			internal bool AFAOPKDEPHG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x2634F90", Offset = "0x2634390", VA = "0x182634F90")]
			internal bool BODGEFBIDLC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x2637240", Offset = "0x2636640", VA = "0x182637240")]
			internal void JJDMDJGLMGA(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x2637D60", Offset = "0x2637160", VA = "0x182637D60")]
			internal bool LODLHFFFFAL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x26379E0", Offset = "0x2636DE0", VA = "0x1826379E0")]
			internal bool KPHMNHIPMPH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x2635460", Offset = "0x2634860", VA = "0x182635460")]
			internal void DPMMJCHHGIK(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x2636FB0", Offset = "0x26363B0", VA = "0x182636FB0")]
			internal bool IEEGGMIBPMJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x26367B0", Offset = "0x2635BB0", VA = "0x1826367B0")]
			internal bool GKHPHFONPNJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x2637C10", Offset = "0x2637010", VA = "0x182637C10")]
			internal void LJICMNGEEEI(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x26384C0", Offset = "0x26378C0", VA = "0x1826384C0")]
			internal List<FMDKLJMLCFC> NLAPIEOCJPM(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x2635AE0", Offset = "0x2634EE0", VA = "0x182635AE0")]
			internal bool FEKLCOKCJED()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x2634AB0", Offset = "0x2633EB0", VA = "0x182634AB0")]
			internal int ANAMAAKMBFJ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x2635400", Offset = "0x2634800", VA = "0x182635400")]
			internal void DNLMMIIADPK(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x2635C90", Offset = "0x2635090", VA = "0x182635C90")]
			internal bool FJCOKGMHIJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x26365E0", Offset = "0x26359E0", VA = "0x1826365E0")]
			internal bool GGOCKEPHAPJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x263E710", Offset = "0x263DB10", VA = "0x18263E710")]
			internal bool OCBIOMLBAII()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x2637890", Offset = "0x2636C90", VA = "0x182637890")]
			internal int KHGJCFMMBKO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x2637700", Offset = "0x2636B00", VA = "0x182637700")]
			internal void KECCCCEEJFO(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x2637B70", Offset = "0x2636F70", VA = "0x182637B70")]
			internal bool LGLHEINLDJK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x26373B0", Offset = "0x26367B0", VA = "0x1826373B0")]
			internal bool JMFCNPOAIAM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x263E670", Offset = "0x263DA70", VA = "0x18263E670")]
			internal bool NOOMENMKGFI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x2635260", Offset = "0x2634660", VA = "0x182635260")]
			internal bool DFKPAIHLBCL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x2637990", Offset = "0x2636D90", VA = "0x182637990")]
			internal bool KONNABGNCBK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x2634F40", Offset = "0x2634340", VA = "0x182634F40")]
			internal bool BNFECLKBCCA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x263E4D0", Offset = "0x263D8D0", VA = "0x18263E4D0")]
			internal string NLNACKGOMAP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x263F0E0", Offset = "0x263E4E0", VA = "0x18263F0E0")]
			internal void PELKODCCJEM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x2636D00", Offset = "0x2636100", VA = "0x182636D00")]
			internal int HJCGHFKHCHA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x26361E0", Offset = "0x26355E0", VA = "0x1826361E0")]
			internal void GDDEAMDCLLG(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x2635170", Offset = "0x2634570", VA = "0x182635170")]
			internal bool CNKBFJMMBDK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x2637460", Offset = "0x2636860", VA = "0x182637460")]
			internal bool JPEGDLNCMNJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x2638330", Offset = "0x2637730", VA = "0x182638330")]
			internal bool NGECECMAKJM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x2635850", Offset = "0x2634C50", VA = "0x182635850")]
			internal float EOCIJHFKNLO()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x263E5C0", Offset = "0x263D9C0", VA = "0x18263E5C0")]
			internal void NNAMFPFDCCM(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x263E620", Offset = "0x263DA20", VA = "0x18263E620")]
			internal bool NNFKPBFDDDP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x2635510", Offset = "0x2634910", VA = "0x182635510")]
			internal bool EBPMOLGMMFD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x2637F00", Offset = "0x2637300", VA = "0x182637F00")]
			internal bool MFFMFHKGDPJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x2634B00", Offset = "0x2633F00", VA = "0x182634B00")]
			internal bool ANHMDDBJNEE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x2635120", Offset = "0x2634520", VA = "0x182635120")]
			internal bool CHHOMLNJCFE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x263EC30", Offset = "0x263E030", VA = "0x18263EC30")]
			internal bool OOGFBECEBNH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x263ED30", Offset = "0x263E130", VA = "0x18263ED30")]
			internal void PDLJIFOKDEM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x26349C0", Offset = "0x2633DC0", VA = "0x1826349C0")]
			internal string AKGPNNLBGEJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x26366E0", Offset = "0x2635AE0", VA = "0x1826366E0")]
			internal void GIDPGCFHHHB(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x2635CE0", Offset = "0x26350E0", VA = "0x182635CE0")]
			internal bool FKEIKNMCGOA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x2636240", Offset = "0x2635640", VA = "0x182636240")]
			internal bool GDMKLAALGMJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x2635340", Offset = "0x2634740", VA = "0x182635340")]
			internal bool DJIIFLECGDF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x2636330", Offset = "0x2635730", VA = "0x182636330")]
			internal void GFJFOACOIPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x2634BF0", Offset = "0x2633FF0", VA = "0x182634BF0")]
			internal bool BABMCCMKKHI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x2637BC0", Offset = "0x2636FC0", VA = "0x182637BC0")]
			internal bool LGMJMLNJICA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x263F1A0", Offset = "0x263E5A0", VA = "0x18263F1A0")]
			internal bool PFOMGIFCJEF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x2637000", Offset = "0x2636400", VA = "0x182637000")]
			internal bool IHCOBICFMPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x2635D80", Offset = "0x2635180", VA = "0x182635D80")]
			internal void FLJKFAIFKCB(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x263F390", Offset = "0x263E790", VA = "0x18263F390")]
			internal bool POHPLAJIJOJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x263F3E0", Offset = "0x263E7E0", VA = "0x18263F3E0")]
			internal bool PPDABEIFGKI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x2635800", Offset = "0x2634C00", VA = "0x182635800")]
			internal bool ELLOBKJMAJF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x2637CC0", Offset = "0x26370C0", VA = "0x182637CC0")]
			internal bool LMMGJEPEMLG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x2637E50", Offset = "0x2637250", VA = "0x182637E50")]
			internal void MDIJCJEIEAG(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x2635080", Offset = "0x2634480", VA = "0x182635080")]
			internal bool CAHFMHGBCGC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x2634BA0", Offset = "0x2633FA0", VA = "0x182634BA0")]
			internal bool APDFOEDKBPO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x2635B30", Offset = "0x2634F30", VA = "0x182635B30")]
			internal bool FGOJGNEFIME()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x2634EF0", Offset = "0x26342F0", VA = "0x182634EF0")]
			internal bool BLNFCINBMPB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x2636E90", Offset = "0x2636290", VA = "0x182636E90")]
			internal object HPPFJLHBGBF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x2637760", Offset = "0x2636B60", VA = "0x182637760")]
			internal void KEFBIAMGAGO(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x2636BB0", Offset = "0x2635FB0", VA = "0x182636BB0")]
			internal bool HFDFGBPFALJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x26375A0", Offset = "0x26369A0", VA = "0x1826375A0")]
			internal bool KBANLFFLBON()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x2635FE0", Offset = "0x26353E0", VA = "0x182635FE0")]
			internal int FOLCDODHBFH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x2636C00", Offset = "0x2636000", VA = "0x182636C00")]
			internal void HGAKCMGEGPC(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x2638150", Offset = "0x2637550", VA = "0x182638150")]
			internal bool MPDCKLLBOAB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x26360F0", Offset = "0x26354F0", VA = "0x1826360F0")]
			internal bool GBBMLBBLAFO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x2635D30", Offset = "0x2635130", VA = "0x182635D30")]
			internal int FLEHLBCPMJM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x26378E0", Offset = "0x2636CE0", VA = "0x1826378E0")]
			internal void KIPAMGIAEMO(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x263E8C0", Offset = "0x263DCC0", VA = "0x18263E8C0")]
			internal bool OFNNADPMIGF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x2636C60", Offset = "0x2636060", VA = "0x182636C60")]
			internal bool HGCBJBDEHIA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x2636910", Offset = "0x2635D10", VA = "0x182636910")]
			internal bool GOLJMFEAHMI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x26362E0", Offset = "0x26356E0", VA = "0x1826362E0")]
			internal int GFIJLHNIAKP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x2634CB0", Offset = "0x26340B0", VA = "0x182634CB0")]
			internal void BCJICHENFOD(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x2636E40", Offset = "0x2636240", VA = "0x182636E40")]
			internal bool HNJGBIGCJBG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x26371A0", Offset = "0x26365A0", VA = "0x1826371A0")]
			internal bool JEMHHDJAMKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x2636630", Offset = "0x2635A30", VA = "0x182636630")]
			internal bool GHBHAJBIGCK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x263EAF0", Offset = "0x263DEF0", VA = "0x18263EAF0")]
			internal object ONHKOBEFPML()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x2635960", Offset = "0x2634D60", VA = "0x182635960")]
			internal void EPICFDKDCFA(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x2635210", Offset = "0x2634610", VA = "0x182635210")]
			internal bool COPDGEIDNJD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x263E520", Offset = "0x263D920", VA = "0x18263E520")]
			internal bool NMDHGLNCAPM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x2635B80", Offset = "0x2634F80", VA = "0x182635B80")]
			internal object FHNCDKMCEGK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x26352B0", Offset = "0x26346B0", VA = "0x1826352B0")]
			internal void DJEJOODIEFM(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x2636030", Offset = "0x2635430", VA = "0x182636030")]
			internal bool FPFMHABIAMJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x2634970", Offset = "0x2633D70", VA = "0x182634970")]
			internal int AHJGJELGOCE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x2636750", Offset = "0x2635B50", VA = "0x182636750")]
			internal void GKDHNABGGIN(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x26372F0", Offset = "0x26366F0", VA = "0x1826372F0")]
			internal bool JLKHFFMGGLI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x2638100", Offset = "0x2637500", VA = "0x182638100")]
			internal bool MOPNHIKGPGG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x2635DE0", Offset = "0x26351E0", VA = "0x182635DE0")]
			internal bool FMOLNHEEPAD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x2638290", Offset = "0x2637690", VA = "0x182638290")]
			internal int NDNGPELIFAA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x2637050", Offset = "0x2636450", VA = "0x182637050")]
			internal void IKPPHNNOONB(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x2637FA0", Offset = "0x26373A0", VA = "0x182637FA0")]
			internal bool MIAGKNFLCHM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x26355B0", Offset = "0x26349B0", VA = "0x1826355B0")]
			internal bool EEBOCEDHMLI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x2634E50", Offset = "0x2634250", VA = "0x182634E50")]
			internal bool BLALFLAHCCJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x2637500", Offset = "0x2636900", VA = "0x182637500")]
			internal float KAENOHEBIHH()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x2636800", Offset = "0x2635C00", VA = "0x182636800")]
			internal void GKNNAGIOLLB(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x2637A30", Offset = "0x2636E30", VA = "0x182637A30")]
			internal bool LACJBDMBCDB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x2637DB0", Offset = "0x26371B0", VA = "0x182637DB0")]
			internal bool LOGFGDIKMBJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x26374B0", Offset = "0x26368B0", VA = "0x1826374B0")]
			internal bool JPEGMGFICIN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x263F150", Offset = "0x263E550", VA = "0x18263F150")]
			internal float PFMOHEGIHHL()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x2637400", Offset = "0x2636800", VA = "0x182637400")]
			internal void JOILHGBPJOJ(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x2634B50", Offset = "0x2633F50", VA = "0x182634B50")]
			internal bool ANPPOKCNAGI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x2635A40", Offset = "0x2634E40", VA = "0x182635A40")]
			internal bool FAICIGKLGNJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x263F2F0", Offset = "0x263E6F0", VA = "0x18263F2F0")]
			internal string PMOIMKMLBNL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x263E850", Offset = "0x263DC50", VA = "0x18263E850")]
			internal void OFLJCPABJNI(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x2636DF0", Offset = "0x26361F0", VA = "0x182636DF0")]
			internal bool HKIINKCDFGP(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x26354C0", Offset = "0x26348C0", VA = "0x1826354C0")]
			internal bool DPOKDFEDBIO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x2636860", Offset = "0x2635C60", VA = "0x182636860")]
			internal bool GLDGJNJMOEL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x2637EB0", Offset = "0x26372B0", VA = "0x182637EB0")]
			internal bool MEIPCHGIBDF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x263F1F0", Offset = "0x263E5F0", VA = "0x18263F1F0")]
			internal string PGMAOGIFIMC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x263EBC0", Offset = "0x263DFC0", VA = "0x18263EBC0")]
			internal void OOBAIHOIAEC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x263E910", Offset = "0x263DD10", VA = "0x18263E910")]
			internal bool OIDIFABOGPG(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x2638470", Offset = "0x2637870", VA = "0x182638470")]
			internal bool NKPCHIEPEMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x2637C70", Offset = "0x2637070", VA = "0x182637C70")]
			internal bool LMGOLOKBIED()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x2634DB0", Offset = "0x26341B0", VA = "0x182634DB0")]
			internal bool BGENKGCBKFN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x2635E30", Offset = "0x2635230", VA = "0x182635E30")]
			internal string FNGPJINGBAL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x2636080", Offset = "0x2635480", VA = "0x182636080")]
			internal void GAFBJHPONCE(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x2636AC0", Offset = "0x2635EC0", VA = "0x182636AC0")]
			internal bool HCBOCOCNEAI(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x263E6C0", Offset = "0x263DAC0", VA = "0x18263E6C0")]
			internal bool OBMCCHIMNCN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x2635F20", Offset = "0x2635320", VA = "0x182635F20")]
			internal bool FNPKCOJGFAN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x26347C0", Offset = "0x2633BC0", VA = "0x1826347C0")]
			internal bool ACNEJPECOAO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x2635600", Offset = "0x2634A00", VA = "0x182635600")]
			internal string EFIIFKDDHHA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x26358A0", Offset = "0x2634CA0", VA = "0x1826358A0")]
			internal void EOLLBCEKDOJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x26382E0", Offset = "0x26376E0", VA = "0x1826382E0")]
			internal bool NEHJDLCPFKP(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x263F340", Offset = "0x263E740", VA = "0x18263F340")]
			internal bool POHKFGPOKCH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x2635E80", Offset = "0x2635280", VA = "0x182635E80")]
			internal bool FNHMKBNGKGG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x2637150", Offset = "0x2636550", VA = "0x182637150")]
			internal bool JDKABKKPHIK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x2636290", Offset = "0x2635690", VA = "0x182636290")]
			internal string GDMLCEGEMOK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x2635390", Offset = "0x2634790", VA = "0x182635390")]
			internal void DLCAMMJKEEK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x2636A20", Offset = "0x2635E20", VA = "0x182636A20")]
			internal bool HALLDDOOGCC(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x2636B10", Offset = "0x2635F10", VA = "0x182636B10")]
			internal bool HCEBLDJPELC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x2637550", Offset = "0x2636950", VA = "0x182637550")]
			internal bool KBAGNEKOLJL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x2636190", Offset = "0x2635590", VA = "0x182636190")]
			internal bool GCNMGPCMLIJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x2638420", Offset = "0x2637820", VA = "0x182638420")]
			internal string NJLOLEKEGDA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x2638090", Offset = "0x2637490", VA = "0x182638090")]
			internal void MLNFCCHEKPD(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x26359F0", Offset = "0x2634DF0", VA = "0x1826359F0")]
			internal bool EPIPHNBHFML(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x26377F0", Offset = "0x2636BF0", VA = "0x1826377F0")]
			internal bool KEIBOFGAPHL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x2636F60", Offset = "0x2636360", VA = "0x182636F60")]
			internal bool IBOGHAFFNGP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x26370B0", Offset = "0x26364B0", VA = "0x1826370B0")]
			internal bool IOCNMBGIJOF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x2637AD0", Offset = "0x2636ED0", VA = "0x182637AD0")]
			internal string LCDEKBPEIGH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x2637340", Offset = "0x2636740", VA = "0x182637340")]
			internal void JLLFBPPCFKG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x2637E00", Offset = "0x2637200", VA = "0x182637E00")]
			internal bool MBJLFPEPKKN(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x263F2A0", Offset = "0x263E6A0", VA = "0x18263F2A0")]
			internal bool PMHCGGKOHAF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x2636D50", Offset = "0x2636150", VA = "0x182636D50")]
			internal bool HJNPICEFGLF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x263E800", Offset = "0x263DC00", VA = "0x18263E800")]
			internal bool OELIFECHECB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x2636DA0", Offset = "0x26361A0", VA = "0x182636DA0")]
			internal string HKFIBJFJPLH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x2636960", Offset = "0x2635D60", VA = "0x182636960")]
			internal void GPBNCDHFHDG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x2635BF0", Offset = "0x2634FF0", VA = "0x182635BF0")]
			internal bool FHOEOJIKPGI(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x2636B60", Offset = "0x2635F60", VA = "0x182636B60")]
			internal bool HEFGPILDOPL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x26383D0", Offset = "0x26377D0", VA = "0x1826383D0")]
			internal bool NIKKEHGNHAM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x26356A0", Offset = "0x2634AA0", VA = "0x1826356A0")]
			internal bool EFPPIICLAPB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x263EA00", Offset = "0x263DE00", VA = "0x18263EA00")]
			internal string OKGONHABPFF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x26356F0", Offset = "0x2634AF0", VA = "0x1826356F0")]
			internal void EGJFKEEAGBG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x2635ED0", Offset = "0x26352D0", VA = "0x182635ED0")]
			internal bool FNLBECKOMJP(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x2638240", Offset = "0x2637640", VA = "0x182638240")]
			internal bool NDFFFIMPPKK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x2634880", Offset = "0x2633C80", VA = "0x182634880")]
			internal bool ADNGACMBMFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x2634920", Offset = "0x2633D20", VA = "0x182634920")]
			internal bool AHFONGBPOKE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x2635650", Offset = "0x2634A50", VA = "0x182635650")]
			internal string EFPLAKPKDCG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x2634810", Offset = "0x2633C10", VA = "0x182634810")]
			internal void ADNAIEMIKDL(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x2634D10", Offset = "0x2634110", VA = "0x182634D10")]
			internal bool BDFGIKBCJIK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x263E7B0", Offset = "0x263DBB0", VA = "0x18263E7B0")]
			internal bool OELGAMELDEC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x2634A10", Offset = "0x2633E10", VA = "0x182634A10")]
			internal bool AKPHHODNGDA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x2637FF0", Offset = "0x26373F0", VA = "0x182637FF0")]
			internal string MJKONFHAMPN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x2637640", Offset = "0x2636A40", VA = "0x182637640")]
			internal void KDGLMCJCDLG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x2634FE0", Offset = "0x26343E0", VA = "0x182634FE0")]
			internal bool BPFKDNNCNFN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x263E760", Offset = "0x263DB60", VA = "0x18263E760")]
			internal bool OEHLCEIAEFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x2637F50", Offset = "0x2637350", VA = "0x182637F50")]
			internal bool MHKJOOCMLMA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x26376B0", Offset = "0x2636AB0", VA = "0x1826376B0")]
			internal string KEBPFJHFFAD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x2634C40", Offset = "0x2634040", VA = "0x182634C40")]
			internal void BCGDPMDOKND(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x2637840", Offset = "0x2636C40", VA = "0x182637840")]
			internal bool KHCNCCEFHNG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x2635C40", Offset = "0x2635040", VA = "0x182635C40")]
			internal bool FIINHMLEGGC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x2637B20", Offset = "0x2636F20", VA = "0x182637B20")]
			internal bool LEPMFFGEADP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x26369D0", Offset = "0x2635DD0", VA = "0x1826369D0")]
			internal string HACJIPHEJFH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x2635F70", Offset = "0x2635370", VA = "0x182635F70")]
			internal void FOEHMCPGCKA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x26375F0", Offset = "0x26369F0", VA = "0x1826375F0")]
			internal bool KCFLNIJHMEI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x2634E00", Offset = "0x2634200", VA = "0x182634E00")]
			internal bool BKPBHJDOIGE(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x26357B0", Offset = "0x2634BB0", VA = "0x1826357B0")]
			internal float EKGCFBDEOAD()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x263EB60", Offset = "0x263DF60", VA = "0x18263EB60")]
			internal void ONPAFLLOKDA(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x2636CB0", Offset = "0x26360B0", VA = "0x182636CB0")]
			internal bool HHCDIELDMIH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x26372A0", Offset = "0x26366A0", VA = "0x1826372A0")]
			internal bool JLDKOJHOAPK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x2638040", Offset = "0x2637440", VA = "0x182638040")]
			internal bool MLKLLCFHIFK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x26351C0", Offset = "0x26345C0", VA = "0x1826351C0")]
			internal int COMIMNKFGOC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x26368B0", Offset = "0x2635CB0", VA = "0x1826368B0")]
			internal void GMHKFMMHAAK(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x2638380", Offset = "0x2637780", VA = "0x182638380")]
			internal bool NHLKDLKNGOL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x263EAA0", Offset = "0x263DEA0", VA = "0x18263EAA0")]
			internal bool ONBOIFBDCCO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x263E960", Offset = "0x263DD60", VA = "0x18263E960")]
			internal bool OJHDKIICMNF()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class CLCAEJCHJEO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public HNBFHGNLJDC CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public CLCAEJCHJEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x262BBD0", Offset = "0x262AFD0", VA = "0x18262BBD0")]
			internal void GKALDBDADDG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class AKKNFFDCEGG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public AKKNFFDCEGG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x262A9A0", Offset = "0x2629DA0", VA = "0x18262A9A0")]
			internal bool NFNIIOHOLKH(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private readonly CHCIBBALBKE IACOAFJBPAJ;

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x262E920", Offset = "0x262DD20", VA = "0x18262E920")]
		public DBGPJLBIGFB(PMKDFPMAACD HKPECGCBGAA, CMKKJFLKNLH BLGGFHHEDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x262CBE0", Offset = "0x262BFE0", VA = "0x18262CBE0", Slot = "134")]
		protected override void FLHCPNPGMGE(NNDHABFGLGH HIFAJDOJEBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public sealed class DHEFIGNFAAF : HHCHLJOKMMO<PABGFJMJDLD>
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class JDPPFLLECIA
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006B")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400016C")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400016D")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400016E")]
				public JDPPFLLECIA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400016F")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000170")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000171")]
				private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002A9")]
				[Cpp2IlInjected.Address(RVA = "0x2664720", Offset = "0x2663B20", VA = "0x182664720", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002AA")]
				[Cpp2IlInjected.Address(RVA = "0xA0AFE0", Offset = "0xA0A3E0", VA = "0x180A0AFE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public DHEFIGNFAAF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public BKCAMONFAFL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public JDPPFLLECIA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x265D200", Offset = "0x265C600", VA = "0x18265D200")]
			internal string ALHMIJFJECG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x265D250", Offset = "0x265C650", VA = "0x18265D250")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void IAJMEFMNOEC(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x265D320", Offset = "0x265C720", VA = "0x18265D320")]
			internal int KAFKDPLFJPI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x265D370", Offset = "0x265C770", VA = "0x18265D370")]
			internal void LDMBHEIPGFP(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey KKGMNHPHOBN
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0xFBB810", Offset = "0xFBAC10", VA = "0x180FBB810", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x2631A50", Offset = "0x2630E50", VA = "0x182631A50")]
		public DHEFIGNFAAF(PMKDFPMAACD HKPECGCBGAA, PABGFJMJDLD BGCEKLPNCIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x2631700", Offset = "0x2630B00", VA = "0x182631700", Slot = "134")]
		protected override void FLHCPNPGMGE(NNDHABFGLGH HIFAJDOJEBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public sealed class NCCHGHMLBIK : HHCHLJOKMMO<IJKGLPKEDFO>
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private sealed class NAEEFOKDMEM
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006E")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000174")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000175")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000176")]
				public NAEEFOKDMEM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000177")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BE")]
				[Cpp2IlInjected.Address(RVA = "0x2664A30", Offset = "0x2663E30", VA = "0x182664A30", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BF")]
				[Cpp2IlInjected.Address(RVA = "0xA0AFE0", Offset = "0xA0A3E0", VA = "0x180A0AFE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006F")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400017B")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400017C")]
				public NAEEFOKDMEM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002C0")]
				[Cpp2IlInjected.Address(RVA = "0x2664D70", Offset = "0x2664170", VA = "0x182664D70", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C1")]
				[Cpp2IlInjected.Address(RVA = "0xA0AFE0", Offset = "0xA0A3E0", VA = "0x180A0AFE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000172")]
			public NCCHGHMLBIK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public BKCAMONFAFL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public NAEEFOKDMEM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x2661090", Offset = "0x2660490", VA = "0x182661090")]
			internal string ALHMIJFJECG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x2661130", Offset = "0x2660530", VA = "0x182661130")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void IAJMEFMNOEC(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x2661270", Offset = "0x2660670", VA = "0x182661270")]
			internal int KAFKDPLFJPI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x2661390", Offset = "0x2660790", VA = "0x182661390")]
			internal void LDMBHEIPGFP(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x26615A0", Offset = "0x26609A0", VA = "0x1826615A0")]
			internal string NBLMJKLKFBL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x26612C0", Offset = "0x26606C0", VA = "0x1826612C0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void KLEOIOCGGAJ(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x2661770", Offset = "0x2660B70", VA = "0x182661770")]
			internal bool PKLLKHLFNMA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x2661420", Offset = "0x2660820", VA = "0x182661420")]
			internal void LJMAPIPPFJE(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x2661550", Offset = "0x2660950", VA = "0x182661550")]
			internal bool LPFNHJMCDNE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x2661650", Offset = "0x2660A50", VA = "0x182661650")]
			internal void OLKABLCNKLK(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x26610E0", Offset = "0x26604E0", VA = "0x1826610E0")]
			internal float EHFCFMENIHG()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x26616E0", Offset = "0x2660AE0", VA = "0x1826616E0")]
			internal void OONOAJFIHIP(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x26615F0", Offset = "0x26609F0", VA = "0x1826615F0")]
			internal int OGNIAIMBELN()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x26614B0", Offset = "0x26608B0", VA = "0x1826614B0")]
			internal void LOKICALGKAD(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x2661200", Offset = "0x2660600", VA = "0x182661200")]
			internal bool JBLJGJPFHKK()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override NodeVisualizationKey KKGMNHPHOBN
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0xFBB810", Offset = "0xFBAC10", VA = "0x180FBB810", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x2662200", Offset = "0x2661600", VA = "0x182662200")]
		public NCCHGHMLBIK(PMKDFPMAACD HKPECGCBGAA, IJKGLPKEDFO BLGGFHHEDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x26617C0", Offset = "0x2660BC0", VA = "0x1826617C0", Slot = "134")]
		protected override void FLHCPNPGMGE(NNDHABFGLGH HIFAJDOJEBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public sealed class MCLFIGKGLHK : HHCHLJOKMMO<HIMGJFGPJJO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private sealed class MCAHBIMPAAK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public BKCAMONFAFL nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public MCLFIGKGLHK <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public MCAHBIMPAAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x265E510", Offset = "0x265D910", VA = "0x18265E510")]
			internal Dictionary<string, EACGDNOMLJK> ALHMIJFJECG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x265E5B0", Offset = "0x265D9B0", VA = "0x18265E5B0")]
			internal int IAJMEFMNOEC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x265E600", Offset = "0x265DA00", VA = "0x18265E600")]
			internal void KAFKDPLFJPI(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x265E730", Offset = "0x265DB30", VA = "0x18265E730")]
			internal bool LDMBHEIPGFP()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override NodeVisualizationKey KKGMNHPHOBN
		{
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0xFBB810", Offset = "0xFBAC10", VA = "0x180FBB810", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x265EA80", Offset = "0x265DE80", VA = "0x18265EA80")]
		public MCLFIGKGLHK(PMKDFPMAACD HKPECGCBGAA, HIMGJFGPJJO BGCEKLPNCIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x265E7B0", Offset = "0x265DBB0", VA = "0x18265E7B0", Slot = "134")]
		protected override void FLHCPNPGMGE(NNDHABFGLGH HIFAJDOJEBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public sealed class MPDOECEMMJH : HHCHLJOKMMO<AHAOEMEEGHG>
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private sealed class NIAHPBHGMKP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public BKCAMONFAFL nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public MPDOECEMMJH <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public NIAHPBHGMKP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x2662E00", Offset = "0x2662200", VA = "0x182662E00")]
			internal void ALHMIJFJECG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override NodeVisualizationKey KKGMNHPHOBN
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0xFBB810", Offset = "0xFBAC10", VA = "0x180FBB810", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x2661020", Offset = "0x2660420", VA = "0x182661020")]
		public MPDOECEMMJH(PMKDFPMAACD HKPECGCBGAA, AHAOEMEEGHG BGCEKLPNCIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x2660EA0", Offset = "0x26602A0", VA = "0x182660EA0", Slot = "134")]
		protected override void FLHCPNPGMGE(NNDHABFGLGH HIFAJDOJEBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class COPNIMOLIEA<TNode> : ABKAIAOKPEM<TNode> where TNode : notnull, PKANHBDKHBP
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override bool GOONILOKLDH
		{
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "107")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override PLKONELJLOH? LGFGGDFPKFD
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x64DAC70", Offset = "0x64DA070", VA = "0x1864DAC70", Slot = "124")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override bool IHCNCOAJMHP
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x64DACE0", Offset = "0x64DA0E0", VA = "0x1864DACE0", Slot = "131")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override NodeVisualizationKey KKGMNHPHOBN
		{
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0xCE9620", Offset = "0xCE8A20", VA = "0x180CE9620", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x555C210", Offset = "0x555B610", VA = "0x18555C210")]
		public COPNIMOLIEA(PMKDFPMAACD HKPECGCBGAA, TNode BLGGFHHEDNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class HGHAIEEKPEH : COPNIMOLIEA<GBAKBDJLCJN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class CDFNKJDDOEO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public HGHAIEEKPEH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public BKCAMONFAFL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public CDFNKJDDOEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x2649890", Offset = "0x2648C90", VA = "0x182649890")]
			internal object ALHMIJFJECG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x2649900", Offset = "0x2648D00", VA = "0x182649900")]
			internal void IAJMEFMNOEC(object v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x26499D0", Offset = "0x2648DD0", VA = "0x1826499D0")]
			internal void KAFKDPLFJPI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private static object[]? MAICHFNJGPA;

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x2655B40", Offset = "0x2654F40", VA = "0x182655B40")]
		public HGHAIEEKPEH(PMKDFPMAACD HKPECGCBGAA, GBAKBDJLCJN BLGGFHHEDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x26555A0", Offset = "0x26549A0", VA = "0x1826555A0", Slot = "134")]
		protected override void FLHCPNPGMGE(NNDHABFGLGH HIFAJDOJEBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private sealed class GGPMLKGHGBB : HHCHLJOKMMO<CDAMNBKHGIO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override NodeVisualizationKey KKGMNHPHOBN
		{
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0xBF1860", Offset = "0xBF0C60", VA = "0x180BF1860", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x2655460", Offset = "0x2654860", VA = "0x182655460")]
		public GGPMLKGHGBB(PMKDFPMAACD HKPECGCBGAA, CDAMNBKHGIO BLGGFHHEDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "134")]
		protected override void FLHCPNPGMGE(NNDHABFGLGH HIFAJDOJEBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private sealed class GHELLMLKMGE : HHCHLJOKMMO<POHFDILNHKI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override NodeVisualizationKey KKGMNHPHOBN
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0xB218D0", Offset = "0xB20CD0", VA = "0x180B218D0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x26554D0", Offset = "0x26548D0", VA = "0x1826554D0")]
		public GHELLMLKMGE(PMKDFPMAACD HKPECGCBGAA, POHFDILNHKI BLGGFHHEDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "126")]
		protected override bool EHGKJNMCKGF(IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "134")]
		protected override void FLHCPNPGMGE(NNDHABFGLGH HIFAJDOJEBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private sealed class PPIIBFEDLKG : HHCHLJOKMMO<PMNLJMAADAB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override NodeVisualizationKey KKGMNHPHOBN
		{
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0xB0A470", Offset = "0xB09870", VA = "0x180B0A470", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool AHDFICLIBDP
		{
			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x26643C0", Offset = "0x26637C0", VA = "0x1826643C0", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		protected override bool MALMJHBGPKA
		{
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x2664350", Offset = "0x2663750", VA = "0x182664350")]
		public PPIIBFEDLKG(PMKDFPMAACD HKPECGCBGAA, PMNLJMAADAB BLGGFHHEDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "134")]
		protected override void FLHCPNPGMGE(NNDHABFGLGH HIFAJDOJEBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class BHJLIJFLEGI : HHCHLJOKMMO<JPNJFPFMJJB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override NodeVisualizationKey KKGMNHPHOBN
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0xB222B0", Offset = "0xB216B0", VA = "0x180B222B0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override bool AHDFICLIBDP
		{
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x26492C0", Offset = "0x26486C0", VA = "0x1826492C0", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		protected override bool MALMJHBGPKA
		{
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x2649250", Offset = "0x2648650", VA = "0x182649250")]
		public BHJLIJFLEGI(PMKDFPMAACD HKPECGCBGAA, JPNJFPFMJJB BLGGFHHEDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "134")]
		protected override void FLHCPNPGMGE(NNDHABFGLGH HIFAJDOJEBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public sealed class DPOOFLHOGEJ : ENGBJFABJNB<OCGFBNINLFP>
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		[CompilerGenerated]
		private sealed class JAHALEKLOLC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public DPOOFLHOGEJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public BKCAMONFAFL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public JAHALEKLOLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x265CDD0", Offset = "0x265C1D0", VA = "0x18265CDD0")]
			internal float LJPGDPLINLK()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x265CE50", Offset = "0x265C250", VA = "0x18265CE50")]
			internal void PEEDKFDAMEI(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x264B600", Offset = "0x264AA00", VA = "0x18264B600")]
		public DPOOFLHOGEJ(PMKDFPMAACD HKPECGCBGAA, OCGFBNINLFP BGCEKLPNCIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x264B380", Offset = "0x264A780", VA = "0x18264B380", Slot = "140")]
		protected override void CKCDLJMHANF(NNDHABFGLGH HIFAJDOJEBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public sealed class APJABGGDAGL : HHCHLJOKMMO<ONDJLBKCFNB>
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		[CompilerGenerated]
		private sealed class BPLJDKJBMFH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public APJABGGDAGL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public BKCAMONFAFL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public BPLJDKJBMFH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x2649710", Offset = "0x2648B10", VA = "0x182649710")]
			internal bool ALHMIJFJECG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x2649760", Offset = "0x2648B60", VA = "0x182649760")]
			internal void IAJMEFMNOEC(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x2649180", Offset = "0x2648580", VA = "0x182649180")]
		public APJABGGDAGL(PMKDFPMAACD HKPECGCBGAA, ONDJLBKCFNB BGCEKLPNCIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x2648EE0", Offset = "0x26482E0", VA = "0x182648EE0", Slot = "134")]
		protected override void FLHCPNPGMGE(NNDHABFGLGH HIFAJDOJEBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public sealed class AKDAOOEBIMD : HHCHLJOKMMO<JNHEMMJDEIH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class NEOFAFAOOFB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public BKCAMONFAFL nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public AKDAOOEBIMD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public NEOFAFAOOFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x2662270", Offset = "0x2661670", VA = "0x182662270")]
			internal object ALHMIJFJECG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x2662800", Offset = "0x2661C00", VA = "0x182662800")]
			internal bool LJMAPIPPFJE(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x26623A0", Offset = "0x26617A0", VA = "0x1826623A0")]
			internal void IAJMEFMNOEC(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x2662600", Offset = "0x2661A00", VA = "0x182662600")]
			internal string KAFKDPLFJPI(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x26627B0", Offset = "0x2661BB0", VA = "0x1826627B0")]
			internal IReadOnlyList<object> LDMBHEIPGFP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x2662880", Offset = "0x2661C80", VA = "0x182662880")]
			internal bool NBLMJKLKFBL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x2662760", Offset = "0x2661B60", VA = "0x182662760")]
			internal bool KLEOIOCGGAJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x26628F0", Offset = "0x2661CF0", VA = "0x1826628F0")]
			internal void PKLLKHLFNMA(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x2648E70", Offset = "0x2648270", VA = "0x182648E70")]
		public AKDAOOEBIMD(PMKDFPMAACD HKPECGCBGAA, JNHEMMJDEIH BGCEKLPNCIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x2648650", Offset = "0x2647A50", VA = "0x182648650", Slot = "134")]
		protected override void FLHCPNPGMGE(NNDHABFGLGH HIFAJDOJEBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public sealed class FEFHNHGOIAP : FHBOOAPBNPC<PCBMBBHLCDD>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override NodeVisualizationKey KKGMNHPHOBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0xCF1ED0", Offset = "0xCF12D0", VA = "0x180CF1ED0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x2652E60", Offset = "0x2652260", VA = "0x182652E60")]
		public FEFHNHGOIAP(PMKDFPMAACD HKPECGCBGAA, PCBMBBHLCDD BLGGFHHEDNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class IMIMHFEKDFO : ENGBJFABJNB<JGIDAKNLJBA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class BOMKOOOJPHE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public IMIMHFEKDFO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public BKCAMONFAFL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public BOMKOOOJPHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x26495F0", Offset = "0x26489F0", VA = "0x1826495F0")]
			internal int LJPGDPLINLK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x2649670", Offset = "0x2648A70", VA = "0x182649670")]
			internal void PEEDKFDAMEI(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x265CD70", Offset = "0x265C170", VA = "0x18265CD70")]
		public IMIMHFEKDFO(PMKDFPMAACD HKPECGCBGAA, JGIDAKNLJBA BGCEKLPNCIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x265CA70", Offset = "0x265BE70", VA = "0x18265CA70", Slot = "140")]
		protected override void CKCDLJMHANF(NNDHABFGLGH HIFAJDOJEBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class FFOOKPBAIAC : HHCHLJOKMMO<BCAONHDHOBK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000085")]
		[CompilerGenerated]
		private sealed class PPICFKNKEFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public FFOOKPBAIAC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public BKCAMONFAFL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public PPICFKNKEFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x2664270", Offset = "0x2663670", VA = "0x182664270")]
			internal bool ALHMIJFJECG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x26642C0", Offset = "0x26636C0", VA = "0x1826642C0")]
			internal void IAJMEFMNOEC(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x26544F0", Offset = "0x26538F0", VA = "0x1826544F0")]
		public FFOOKPBAIAC(PMKDFPMAACD HKPECGCBGAA, BCAONHDHOBK BGCEKLPNCIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x2654310", Offset = "0x2653710", VA = "0x182654310", Slot = "134")]
		protected override void FLHCPNPGMGE(NNDHABFGLGH HIFAJDOJEBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class CLBDLBJDEMN : HHCHLJOKMMO<FEJLBIGLDOA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class KFPFJOFFJBD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public CLBDLBJDEMN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public BKCAMONFAFL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public KFPFJOFFJBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x265D400", Offset = "0x265C800", VA = "0x18265D400")]
			internal bool ALHMIJFJECG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x265D450", Offset = "0x265C850", VA = "0x18265D450")]
			internal void IAJMEFMNOEC(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x264AE50", Offset = "0x264A250", VA = "0x18264AE50")]
		public CLBDLBJDEMN(PMKDFPMAACD HKPECGCBGAA, FEJLBIGLDOA BGCEKLPNCIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x264AC70", Offset = "0x264A070", VA = "0x18264AC70", Slot = "134")]
		protected override void FLHCPNPGMGE(NNDHABFGLGH HIFAJDOJEBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class KNGHJLHCNJN : HHCHLJOKMMO<MOFLALGIONI>
	{
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		[CompilerGenerated]
		private sealed class GAIAKLAPOAI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public KNGHJLHCNJN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public BKCAMONFAFL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public GAIAKLAPOAI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x2654920", Offset = "0x2653D20", VA = "0x182654920")]
			internal int ALHMIJFJECG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x2654970", Offset = "0x2653D70", VA = "0x182654970")]
			internal void IAJMEFMNOEC(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x265D750", Offset = "0x265CB50", VA = "0x18265D750")]
		public KNGHJLHCNJN(PMKDFPMAACD HKPECGCBGAA, MOFLALGIONI BGCEKLPNCIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x265D4E0", Offset = "0x265C8E0", VA = "0x18265D4E0", Slot = "134")]
		protected override void FLHCPNPGMGE(NNDHABFGLGH HIFAJDOJEBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class FDHFFDPFLKJ : FCAMMJMIMIJ<GAKBLGLPJMC>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public override MCEBFGLGPKE JBBONNLGILK
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0xB232D0", Offset = "0xB226D0", VA = "0x180B232D0", Slot = "140")]
			get
			{
				return default(MCEBFGLGPKE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x264BB10", Offset = "0x264AF10", VA = "0x18264BB10")]
		public FDHFFDPFLKJ(PMKDFPMAACD HKPECGCBGAA, GAKBLGLPJMC BGCEKLPNCIL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class IGIEBFEEMHI : HHCHLJOKMMO<BCCBPIEBIKF>
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x26578D0", Offset = "0x2656CD0", VA = "0x1826578D0")]
		public IGIEBFEEMHI(PMKDFPMAACD HKPECGCBGAA, BCCBPIEBIKF BLGGFHHEDNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public abstract class HHCHLJOKMMO<TNode> : BINALJFGGNF, IDisposable where TNode : notnull, BCCBPIEBIKF
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		[CompilerGenerated]
		private sealed class AMHNLILEMHO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public HHCHLJOKMMO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public PMKDFPMAACD circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public AMHNLILEMHO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x49F7450", Offset = "0x49F6850", VA = "0x1849F7450")]
			internal IHBGKOPEFOA IJFBIFKKLJC(FMFCAMOKBCJ portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		[CompilerGenerated]
		private struct NIBDNEEDLFP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public HHCHLJOKMMO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x50F3570", Offset = "0x50F2970", VA = "0x1850F3570", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0xA0AFE0", Offset = "0xA0A3E0", VA = "0x180A0AFE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		[CompilerGenerated]
		private struct DOEHGNJKGEK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public AsyncTaskMethodBuilder<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public HHCHLJOKMMO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public BICGACHNKNM? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public NJLBLADHJBH? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x66FC470", Offset = "0x66FB870", VA = "0x1866FC470", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x66FC710", Offset = "0x66FBB10", VA = "0x1866FC710", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000090")]
		[CompilerGenerated]
		private sealed class PNJIHECFMLH
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000091")]
			private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C2")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C3")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C4")]
				public PNJIHECFMLH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C5")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60003A5")]
				[Cpp2IlInjected.Address(RVA = "0x3E8BCB0", Offset = "0x3E8B0B0", VA = "0x183E8BCB0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003A6")]
				[Cpp2IlInjected.Address(RVA = "0xA0AFE0", Offset = "0xA0A3E0", VA = "0x180A0AFE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public Func<string, bool> submitValidator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public BKCAMONFAFL nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public HHCHLJOKMMO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public NNDHABFGLGH configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public PNJIHECFMLH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
			internal string APBDNPLCPGP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x9AA4D0", Offset = "0x9A98D0", VA = "0x1809AA4D0")]
			internal void DJDJPDPBAHP(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x535A1D0", Offset = "0x53595D0", VA = "0x18535A1D0")]
			[AsyncStateMachine(typeof(HHCHLJOKMMO<>.PNJIHECFMLH.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void MIBEFGOKJEN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000092")]
		[CompilerGenerated]
		private sealed class CKPPAMPELHD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public BKCAMONFAFL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public CKPPAMPELHD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x63F9E40", Offset = "0x63F9240", VA = "0x1863F9E40")]
			internal bool NNNBPOGEGEC(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x63F9E30", Offset = "0x63F9230", VA = "0x1863F9E30")]
			internal bool HAMLGPHABOP(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		[CompilerGenerated]
		private struct NCCIMBACCIC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public AsyncTaskMethodBuilder<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public HHCHLJOKMMO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x50D57A0", Offset = "0x50D4BA0", VA = "0x1850D57A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x50D5AA0", Offset = "0x50D4EA0", VA = "0x1850D5AA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private readonly PMKDFPMAACD JAGCIOPDOMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private readonly bool BAAGPEMCNJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private CHEBGGCGGEB<AFJOOIBLMOP, IHBGKOPEFOA> EJEIBICPIDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private CHEBGGCGGEB<AFJOOIBLMOP, JGCPKBOFLCP> PPHMECDJLOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private List<Action> LDDAMCKBNAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[CompilerGenerated]
		private Action<IJOGBJOFPED<AFJOOIBLMOP>>? AGOHDIAMMPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[CompilerGenerated]
		private Action<IJOGBJOFPED<AFJOOIBLMOP>, JGCPKBOFLCP>? JBNKHDIOFJN;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		protected FKHMMAMFILM AALAMDEEDHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x4903720", Offset = "0x4902B20", VA = "0x184903720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		protected BKCAMONFAFL KADECAFOOMM
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x4905DF0", Offset = "0x49051F0", VA = "0x184905DF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected TNode NFCKCCIBLDO
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x9AA490", Offset = "0x9A9890", VA = "0x1809AA490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public HNEIHDEKOKM<DJJIMCEGKJC> NNDKKBEDCDN
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x1249CF0", Offset = "0x12490F0", VA = "0x181249CF0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(HNEIHDEKOKM<DJJIMCEGKJC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public IJOGBJOFPED<GOENONHHIDE> HABPCFCEKFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x4907FA0", Offset = "0x49073A0", VA = "0x184907FA0", Slot = "6")]
			get
			{
				return default(IJOGBJOFPED<GOENONHHIDE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public object FBCEIDKHADO
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x4356ED0", Offset = "0x43562D0", VA = "0x184356ED0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public virtual bool ODLBNHLMBGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "102")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public int BANAMCLKDPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x4907C00", Offset = "0x4907000", VA = "0x184907C00", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public INFMEKLNAKP KAAFDJMPHGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x4907BA0", Offset = "0x4906FA0", VA = "0x184907BA0", Slot = "10")]
			get
			{
				return default(INFMEKLNAKP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string IICLIMDJDJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x49081A0", Offset = "0x49075A0", VA = "0x1849081A0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected virtual bool MALMJHBGPKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual NodeVisualizationKey KKGMNHPHOBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public IJOGBJOFPED<GAMEINBKIGK> LLBALJMGIHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0xD9F9D0", Offset = "0xD9EDD0", VA = "0x180D9F9D0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(IJOGBJOFPED<GAMEINBKIGK>);
			}
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0xDB5190", Offset = "0xDB4590", VA = "0x180DB5190")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public virtual bool NMJPNJJBBDE
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "105")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public virtual bool AHDFICLIBDP
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public virtual bool GOONILOKLDH
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "107")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public virtual NEKNLAANBJD PGDIJPPMBAF
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0xE8D2E0", Offset = "0xE8C6E0", VA = "0x180E8D2E0", Slot = "108")]
			get
			{
				return default(NEKNLAANBJD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool CKJKDEIPHBG
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x4907910", Offset = "0x4906D10", VA = "0x184907910", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool GJAJNJOMGCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x4907970", Offset = "0x4906D70", VA = "0x184907970", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool CNKGMGMLNIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x49079D0", Offset = "0x4906DD0", VA = "0x1849079D0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public int IJLBIGKGDLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x4907F50", Offset = "0x4907350", VA = "0x184907F50", Slot = "21")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public bool FLJDNJOAJPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x4907D80", Offset = "0x4907180", VA = "0x184907D80", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool NGOGEFIEIIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x4907AE0", Offset = "0x4906EE0", VA = "0x184907AE0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool FJHHEDLEHJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x4907A80", Offset = "0x4906E80", VA = "0x184907A80", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool PEIGECGDMON
		{
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0xE58120", Offset = "0xE57520", VA = "0x180E58120", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x121D700", Offset = "0x121CB00", VA = "0x18121D700")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool GJJAMDHEDEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "109")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual bool JECDNEHKFOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x4907A30", Offset = "0x4906E30", VA = "0x184907A30", Slot = "110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public bool JLOMMENCIAE
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x4907CB0", Offset = "0x49070B0", VA = "0x184907CB0", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public BICGACHNKNM MFPCIJJNMFP
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x4907E90", Offset = "0x4907290", VA = "0x184907E90", Slot = "29")]
			get
			{
				return default(BICGACHNKNM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public NJLBLADHJBH IGDJELKFIOC
		{
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x4907EF0", Offset = "0x49072F0", VA = "0x184907EF0", Slot = "31")]
			get
			{
				return default(NJLBLADHJBH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public virtual bool LAPJJNHKGEB
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public virtual BHPOMJIBPMC? FDMFOCDABNO
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0", Slot = "123")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public virtual PLKONELJLOH? LGFGGDFPKFD
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0", Slot = "124")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public virtual IEnumerable<HNEIHDEKOKM<EICBKBBFNCN>>? OKKGFNIOAKD
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0", Slot = "125")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool IOMIKKBMALI
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x4907B40", Offset = "0x4906F40", VA = "0x184907B40", Slot = "128")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public HNEIHDEKOKM<IIPIDDOCOEJ> GFNBGCNMIJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x4907DD0", Offset = "0x49071D0", VA = "0x184907DD0", Slot = "63")]
			get
			{
				return default(HNEIHDEKOKM<IIPIDDOCOEJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public IJOGBJOFPED<IIPIDDOCOEJ> LPFNJCCDDLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x4907C50", Offset = "0x4907050", VA = "0x184907C50", Slot = "57")]
			get
			{
				return default(IJOGBJOFPED<IIPIDDOCOEJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public virtual bool FLGLKBPKNCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "129")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public virtual IJOGBJOFPED<IIPIDDOCOEJ>? GHHADPCKABF
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0", Slot = "130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public virtual bool IHCNCOAJMHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "131")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public bool DGKPEKBLDPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x4907D10", Offset = "0x4907110", VA = "0x184907D10", Slot = "62")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public string KAFLMFCDNKO
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x9AE420", Offset = "0x9AD820", VA = "0x1809AE420", Slot = "66")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x9AE4E0", Offset = "0x9AD8E0", VA = "0x1809AE4E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public string LDLAMFAAEGC
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x9AE4D0", Offset = "0x9AD8D0", VA = "0x1809AE4D0", Slot = "67")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x9AE4F0", Offset = "0x9AD8F0", VA = "0x1809AE4F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public IJOGBJOFPED<EICBKBBFNCN> HLBOLFMOFKA
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x4908020", Offset = "0x4907420", VA = "0x184908020", Slot = "64")]
			get
			{
				return default(IJOGBJOFPED<EICBKBBFNCN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public HNEIHDEKOKM<EICBKBBFNCN> INNLDLPPLHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x4907E30", Offset = "0x4907230", VA = "0x184907E30", Slot = "65")]
			get
			{
				return default(HNEIHDEKOKM<EICBKBBFNCN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public HNEIHDEKOKM<EICBKBBFNCN>? CONNMGILHKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x4908080", Offset = "0x4907480", VA = "0x184908080", Slot = "132")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public OEEMOMGNMIG<AFJOOIBLMOP, JGCPKBOFLCP> NDEIIEIALAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x4908160", Offset = "0x4907560", VA = "0x184908160", Slot = "68")]
			get
			{
				return default(OEEMOMGNMIG<AFJOOIBLMOP, JGCPKBOFLCP>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public virtual IJOGBJOFPED<AFJOOIBLMOP>? PKDDAJCIFPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0", Slot = "133")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public virtual bool KFLEDBFNICP
		{
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "136")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public virtual bool LLGFNLOIGAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "137")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action KLBBMBOIEME
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x49038B0", Offset = "0x4902CB0", VA = "0x1849038B0", Slot = "38")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x49039F0", Offset = "0x4902DF0", VA = "0x1849039F0", Slot = "39")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event NBMIHKECGOF LNBFCEHBEHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x4905EE0", Offset = "0x49052E0", VA = "0x184905EE0", Slot = "40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x49063A0", Offset = "0x49057A0", VA = "0x1849063A0", Slot = "41")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event FMMPFIAJOPN PBOMAMPKOBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x4903190", Offset = "0x4902590", VA = "0x184903190", Slot = "42")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x4907290", Offset = "0x4906690", VA = "0x184907290", Slot = "43")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action IKGBKDBIJHA
		{
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x4903990", Offset = "0x4902D90", VA = "0x184903990", Slot = "44")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x49047C0", Offset = "0x4903BC0", VA = "0x1849047C0", Slot = "45")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action PLFCILEJHBI
		{
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x4905D50", Offset = "0x4905150", VA = "0x184905D50", Slot = "46")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x4904CB0", Offset = "0x49040B0", VA = "0x184904CB0", Slot = "47")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<IJOGBJOFPED<AFJOOIBLMOP>, JGCPKBOFLCP> HPAHBCAJHOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x49062E0", Offset = "0x49056E0", VA = "0x1849062E0", Slot = "70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x49050A0", Offset = "0x49044A0", VA = "0x1849050A0", Slot = "71")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<IJOGBJOFPED<AFJOOIBLMOP>, JGCPKBOFLCP> JPHAHBAMDEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x4906830", Offset = "0x4905C30", VA = "0x184906830", Slot = "74")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x4903660", Offset = "0x4902A60", VA = "0x184903660", Slot = "75")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<IJOGBJOFPED<AFJOOIBLMOP>> NPHACCKNMKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x4904FE0", Offset = "0x49043E0", VA = "0x184904FE0", Slot = "72")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x4906220", Offset = "0x4905620", VA = "0x184906220", Slot = "73")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<IJOGBJOFPED<AFJOOIBLMOP>, IJOGBJOFPED<AFJOOIBLMOP>> MCPCLINILKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x4904700", Offset = "0x4903B00", VA = "0x184904700", Slot = "76")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x49037F0", Offset = "0x4902BF0", VA = "0x1849037F0", Slot = "77")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<IJOGBJOFPED<AFJOOIBLMOP>, JGCPKBOFLCP> IMFKDCPHHME
		{
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x4902F80", Offset = "0x4902380", VA = "0x184902F80", Slot = "78")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0x49030D0", Offset = "0x49024D0", VA = "0x1849030D0", Slot = "79")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<IJOGBJOFPED<AFJOOIBLMOP>, IJOGBJOFPED<AFJOOIBLMOP>> GGOBPPHLJIL
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x4905870", Offset = "0x4904C70", VA = "0x184905870", Slot = "80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x4903A90", Offset = "0x4902E90", VA = "0x184903A90", Slot = "81")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x4907330", Offset = "0x4906730", VA = "0x184907330")]
		[DGBLOAGKOKD("Need to handle `Name` better.")]
		[DGBLOAGKOKD("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		protected HHCHLJOKMMO(PMKDFPMAACD HKPECGCBGAA, TNode BLGGFHHEDNC, bool NOHGKBLCEDO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x49048F0", Offset = "0x4903CF0", VA = "0x1849048F0", Slot = "100")]
		protected virtual void GDCNGOALEGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x4903F30", Offset = "0x4903330", VA = "0x184903F30", Slot = "101")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x4904330", Offset = "0x4903730", VA = "0x184904330", Slot = "9")]
		[AsyncStateMachine(typeof(HHCHLJOKMMO<>.NIBDNEEDLFP))]
		public void EBODHIBOPCN(int JOKNPPCFGNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x4904D50", Offset = "0x4904150", VA = "0x184904D50")]
		public bool IDIJMANEDDM([In] BICGACHNKNM FFOEEMKIKJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x4905160", Offset = "0x4904560", VA = "0x184905160")]
		public bool IMMGCDBFDIE([In] NJLBLADHJBH FFOEEMKIKJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x4904DC0", Offset = "0x49041C0", VA = "0x184904DC0", Slot = "33")]
		public void IDKDDGGPALO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x49060D0", Offset = "0x49054D0", VA = "0x1849060D0", Slot = "34")]
		[AsyncStateMachine(typeof(HHCHLJOKMMO<>.DOEHGNJKGEK))]
		public Task<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> LBEHECJAPAB(BICGACHNKNM? MABKBAPDDLM, NJLBLADHJBH? NHANCIDGOLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "111")]
		public virtual void NLFFHPPBLPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "112")]
		public virtual void BMHFIJCDFHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "113")]
		public virtual void FAHGCJKBMGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0xE30B00", Offset = "0xE2FF00", VA = "0x180E30B00")]
		protected void GCGJCFLCPAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xE87510", Offset = "0xE86910", VA = "0x180E87510")]
		protected void EPKNGDMANKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x20381D0", Offset = "0x20375D0", VA = "0x1820381D0")]
		private void PMCACEIPHKD([In] NJLBLADHJBH AJFJKBHPFHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x4903230", Offset = "0x4902630", VA = "0x184903230", Slot = "114")]
		public virtual Task<KGPHFOFOMPJ<IJOGBJOFPED<AFJOOIBLMOP>, HEGOEPNOLEN>> BDFFCBIGLCL(string IGEPDAOOLBO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x4904B90", Offset = "0x4903F90", VA = "0x184904B90", Slot = "115")]
		public virtual Task<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> HHAHLAJIHHF(IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "116")]
		public virtual void ICDHNGFCEJK(IJOGBJOFPED<AFJOOIBLMOP> IGIANMGJNDI, IJOGBJOFPED<AFJOOIBLMOP> KJFLNIHJEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x4904860", Offset = "0x4903C60", VA = "0x184904860", Slot = "117")]
		public virtual IEnumerable<FCMLLGFOEBF> GAGICMKNCHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x4903040", Offset = "0x4902440", VA = "0x184903040", Slot = "118")]
		public KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN> AHINOEDAHOJ(string FCIOBAHJNBG)
		{
			return default(KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x4905F80", Offset = "0x4905380", VA = "0x184905F80", Slot = "48")]
		public bool KPBBOCJLPOH([Out] Guid DOKHPLKPLKE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x49051D0", Offset = "0x49045D0", VA = "0x1849051D0")]
		public bool IONCMIGPPEK([In] Guid MIFALNLOHHH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "119")]
		public virtual void GCJCJGLHJHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "120")]
		public virtual void KJENAKPMNKI(bool FKJKDGAJHDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0", Slot = "121")]
		public virtual BDEJLPACKIC KOLOADFBHHF([In] NBPAEJEFBNF DKDFJEHKAFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x4903300", Offset = "0x4902700", VA = "0x184903300")]
		protected void BECOLBKCCIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x49043E0", Offset = "0x49037E0", VA = "0x1849043E0", Slot = "126")]
		protected virtual bool EHGKJNMCKGF(IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x49034E0", Offset = "0x49028E0", VA = "0x1849034E0", Slot = "89")]
		public bool BFDBKBMDIAH(IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "127")]
		protected virtual bool LIGEKJLFNED(IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "134")]
		protected virtual void FLHCPNPGMGE(NNDHABFGLGH EBKMIKJBMMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x4905480", Offset = "0x4904880", VA = "0x184905480")]
		protected void JMANHOJIIEM(NNDHABFGLGH HIFAJDOJEBN, Func<string> BHLDPNIJCJM, Action<string> GPFOPMMFPOA, string BMLFEMJIBOC, string LJLKBCEGIKI, string KBLKKOBAMAK, ODOFBKHPMGC DDONEPJKHEG, GCGMJFGKFLA GLCLONKOGPA, Func<string, bool> PCIFKEBGHOA, string PNKIJNFLKGN, Func<string, bool> CCECDIFLAFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x4904420", Offset = "0x4903820", VA = "0x184904420")]
		protected void EILIDJNDOAD(NNDHABFGLGH HIFAJDOJEBN, Func<string> BHLDPNIJCJM, Action<string> GPFOPMMFPOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x4903C70", Offset = "0x4903070", VA = "0x184903C70", Slot = "135")]
		protected virtual void DLJEJGAMCDI(NNDHABFGLGH HIFAJDOJEBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x4904C60", Offset = "0x4904060", VA = "0x184904C60", Slot = "83")]
		public void HOKHCGLJCEF(NNDHABFGLGH HIFAJDOJEBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x49068F0", Offset = "0x4905CF0", VA = "0x1849068F0", Slot = "84")]
		public OGKLGKEPIME NPBNEHOGKAI()
		{
			return default(OGKLGKEPIME);
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "138")]
		public virtual bool AOHMLNNHGLN(IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x1E32790", Offset = "0x1E31B90", VA = "0x181E32790")]
		private void PPCOCFPBPJO([In] BICGACHNKNM INHMOEHIHAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x4903510", Offset = "0x4902910", VA = "0x184903510")]
		private void BFFEBOBKDGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x4906440", Offset = "0x4905840", VA = "0x184906440", Slot = "90")]
		private void MIELIHJOICC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x4906A40", Offset = "0x4905E40", VA = "0x184906A40", Slot = "92")]
		private void OJIIEMAOPHM(IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xFA8CF0", Offset = "0xFA80F0", VA = "0x180FA8CF0", Slot = "94")]
		private void ACBLINBCKLO(IJOGBJOFPED<AFJOOIBLMOP> NCJKGMLAKGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x49070E0", Offset = "0x49064E0", VA = "0x1849070E0", Slot = "96")]
		private void PGKGMGGPIEA(IJOGBJOFPED<AFJOOIBLMOP> NCJKGMLAKGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x4906480", Offset = "0x4905880", VA = "0x184906480", Slot = "97")]
		private void MKLFKLPDMLN(IJOGBJOFPED<AFJOOIBLMOP> IGIANMGJNDI, IJOGBJOFPED<AFJOOIBLMOP> KJFLNIHJEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xFA97C0", Offset = "0xFA8BC0", VA = "0x180FA97C0", Slot = "98")]
		private void MDMCPMEPIPH(IJOGBJOFPED<AFJOOIBLMOP> IGIANMGJNDI, IJOGBJOFPED<AFJOOIBLMOP> KJFLNIHJEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x49069E0", Offset = "0x4905DE0", VA = "0x1849069E0", Slot = "91")]
		private void OEEMIJCFFKJ(IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x4905930", Offset = "0x4904D30", VA = "0x184905930", Slot = "93")]
		private void KEDFDCMLCGM(IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x4903780", Offset = "0x4902B80", VA = "0x184903780", Slot = "95")]
		private void BKLMNLGKALE(IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x4903B50", Offset = "0x4902F50", VA = "0x184903B50", Slot = "139")]
		[AsyncStateMachine(typeof(HHCHLJOKMMO<>.NCCIMBACCIC))]
		public Task<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> DCFJIIFGFKK(string FCIOBAHJNBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x4907070", Offset = "0x4906470", VA = "0x184907070", Slot = "55")]
		private void OPPAFJKHIAJ(object MJDJDENIBCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x4907000", Offset = "0x4906400", VA = "0x184907000", Slot = "56")]
		private void ONLFFPFELGH(object MJDJDENIBCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x4836C90", Offset = "0x4836090", VA = "0x184836C90", Slot = "30")]
		private bool FMICNHNMMGE([In] BICGACHNKNM FFOEEMKIKJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x4906A00", Offset = "0x4905E00", VA = "0x184906A00", Slot = "32")]
		private bool OGJFHBPPFKK([In] NJLBLADHJBH FFOEEMKIKJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x4904820", Offset = "0x4903C20", VA = "0x184904820", Slot = "49")]
		private bool FMAKNMMBLIH([In] Guid MIFALNLOHHH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x4903950", Offset = "0x4902D50", VA = "0x184903950")]
		[CompilerGenerated]
		private string CKLKNFDJMPK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x4903E90", Offset = "0x4903290", VA = "0x184903E90")]
		[CompilerGenerated]
		private void DNLIAADNJDK(string IGEPDAOOLBO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public sealed class BIDLBEDKJJJ : FHBOOAPBNPC<OJCPLJNADMH>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public override NodeVisualizationKey KKGMNHPHOBN
		{
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0xD00F30", Offset = "0xD00330", VA = "0x180D00F30", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x2649310", Offset = "0x2648710", VA = "0x182649310")]
		public BIDLBEDKJJJ(PMKDFPMAACD HKPECGCBGAA, OJCPLJNADMH BLGGFHHEDNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private sealed class HLPHDCMDFOG : ABKAIAOKPEM<KELDLDBMJMG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public override NodeVisualizationKey KKGMNHPHOBN
		{
			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0xB232D0", Offset = "0xB226D0", VA = "0x180B232D0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x2655BA0", Offset = "0x2654FA0", VA = "0x182655BA0")]
		public HLPHDCMDFOG(PMKDFPMAACD HKPECGCBGAA, KELDLDBMJMG BLGGFHHEDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "134")]
		protected override void FLHCPNPGMGE(NNDHABFGLGH HIFAJDOJEBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public abstract class FCAMMJMIMIJ<T> : HHCHLJOKMMO<T> where T : notnull, BBNAKGLICCG
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class JPJDPLMBNKN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public IReadOnlyList<KeyValuePair<string, EACGDNOMLJK>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public FCAMMJMIMIJ<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public BKCAMONFAFL nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public MCEBFGLGPKE clipType;

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public JPJDPLMBNKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
			internal IReadOnlyList<KeyValuePair<string, EACGDNOMLJK>> ALHMIJFJECG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x4CBD770", Offset = "0x4CBCB70", VA = "0x184CBD770")]
			internal int IAJMEFMNOEC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x4CBD8C0", Offset = "0x4CBCCC0", VA = "0x184CBD8C0")]
			internal void KAFKDPLFJPI(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x4CBDB70", Offset = "0x4CBCF70", VA = "0x184CBDB70")]
			internal void LDMBHEIPGFP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x4CBDCD0", Offset = "0x4CBD0D0", VA = "0x184CBDCD0")]
			internal void NBLMJKLKFBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x4CBDAE0", Offset = "0x4CBCEE0", VA = "0x184CBDAE0")]
			internal bool KLEOIOCGGAJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x4CBDFF0", Offset = "0x4CBD3F0", VA = "0x184CBDFF0")]
			internal void PKLLKHLFNMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x4CBDAE0", Offset = "0x4CBCEE0", VA = "0x184CBDAE0")]
			internal bool LJMAPIPPFJE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x4CBDC80", Offset = "0x4CBD080", VA = "0x184CBDC80")]
			internal float LPFNHJMCDNE()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x4CBDE70", Offset = "0x4CBD270", VA = "0x184CBDE70")]
			internal void OLKABLCNKLK(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x4CBD720", Offset = "0x4CBCB20", VA = "0x184CBD720")]
			internal float EHFCFMENIHG()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x4CBDF30", Offset = "0x4CBD330", VA = "0x184CBDF30")]
			internal void OONOAJFIHIP(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x4CBDE20", Offset = "0x4CBD220", VA = "0x184CBDE20")]
			internal float OGNIAIMBELN()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x4CBDBC0", Offset = "0x4CBCFC0", VA = "0x184CBDBC0")]
			internal void LOKICALGKAD(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override NodeVisualizationKey KKGMNHPHOBN
		{
			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0xFBB810", Offset = "0xFBAC10", VA = "0x180FBB810", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public abstract MCEBFGLGPKE JBBONNLGILK
		{
			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(Slot = "140")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x4713AC0", Offset = "0x4712EC0", VA = "0x184713AC0")]
		public FCAMMJMIMIJ(PMKDFPMAACD HKPECGCBGAA, T BLGGFHHEDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x4713010", Offset = "0x4712410", VA = "0x184713010", Slot = "134")]
		protected sealed override void FLHCPNPGMGE(NNDHABFGLGH HIFAJDOJEBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private sealed class PKBPHKBBNID : HHCHLJOKMMO<FAOGIMDKGLE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public override NodeVisualizationKey KKGMNHPHOBN
		{
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0xCEDBE0", Offset = "0xCECFE0", VA = "0x180CEDBE0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x2664200", Offset = "0x2663600", VA = "0x182664200")]
		public PKBPHKBBNID(PMKDFPMAACD HKPECGCBGAA, FAOGIMDKGLE BLGGFHHEDNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class NGNOOBEGLKL : HHCHLJOKMMO<PCGNPPCANKE>
	{
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		[CompilerGenerated]
		private sealed class CFJNPPGPBPN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public NGNOOBEGLKL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public BKCAMONFAFL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public CFJNPPGPBPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x2649ED0", Offset = "0x26492D0", VA = "0x182649ED0")]
			internal int IAJMEFMNOEC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x2649F20", Offset = "0x2649320", VA = "0x182649F20")]
			internal void KAFKDPLFJPI(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private static Dictionary<string, EACGDNOMLJK>? MNIGEPFDOEI;

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x2662D90", Offset = "0x2662190", VA = "0x182662D90")]
		public NGNOOBEGLKL(PMKDFPMAACD HKPECGCBGAA, PCGNPPCANKE BLGGFHHEDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x2662A20", Offset = "0x2661E20", VA = "0x182662A20", Slot = "134")]
		protected override void FLHCPNPGMGE(NNDHABFGLGH HIFAJDOJEBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class OKJKOAEBOHJ : FCAMMJMIMIJ<KIMPHEJGDJD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public override MCEBFGLGPKE JBBONNLGILK
		{
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0", Slot = "140")]
			get
			{
				return default(MCEBFGLGPKE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x2663B30", Offset = "0x2662F30", VA = "0x182663B30")]
		public OKJKOAEBOHJ(PMKDFPMAACD HKPECGCBGAA, KIMPHEJGDJD BGCEKLPNCIL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private sealed class HDGEIHFLDNM : ABKAIAOKPEM<JDLKPCBBOMC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public override NodeVisualizationKey KKGMNHPHOBN
		{
			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0xB232D0", Offset = "0xB226D0", VA = "0x180B232D0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x2655540", Offset = "0x2654940", VA = "0x182655540")]
		public HDGEIHFLDNM(PMKDFPMAACD HKPECGCBGAA, JDLKPCBBOMC BLGGFHHEDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "134")]
		protected override void FLHCPNPGMGE(NNDHABFGLGH HIFAJDOJEBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	private sealed class DBGGLLDCGJE : ABKAIAOKPEM<ENAMOMFKLCM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public override NodeVisualizationKey KKGMNHPHOBN
		{
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0xB232D0", Offset = "0xB226D0", VA = "0x180B232D0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x264AF60", Offset = "0x264A360", VA = "0x18264AF60")]
		public DBGGLLDCGJE(PMKDFPMAACD HKPECGCBGAA, ENAMOMFKLCM BLGGFHHEDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "134")]
		protected override void FLHCPNPGMGE(NNDHABFGLGH HIFAJDOJEBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class LANBLOGEEPF : ENGBJFABJNB<BOEAIMFEFAH>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A0")]
		[CompilerGenerated]
		private sealed class KPHEDLNLDNL
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000A1")]
			private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D9")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40001DA")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40001DB")]
				public KPHEDLNLDNL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001DC")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40001DD")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40001DE")]
				private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60003DA")]
				[Cpp2IlInjected.Address(RVA = "0x2664410", Offset = "0x2663810", VA = "0x182664410", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003DB")]
				[Cpp2IlInjected.Address(RVA = "0xA0AFE0", Offset = "0xA0A3E0", VA = "0x180A0AFE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public BKCAMONFAFL nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public LANBLOGEEPF <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public KPHEDLNLDNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0x265DBA0", Offset = "0x265CFA0", VA = "0x18265DBA0")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void LJPGDPLINLK(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x265DF50", Offset = "0x265D350", VA = "0x18265DF50")]
		public LANBLOGEEPF(PMKDFPMAACD HKPECGCBGAA, BOEAIMFEFAH BGCEKLPNCIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x265DC70", Offset = "0x265D070", VA = "0x18265DC70", Slot = "140")]
		protected override void CKCDLJMHANF(NNDHABFGLGH HIFAJDOJEBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public sealed class LEMMAHJHNKG : FCAMMJMIMIJ<GGDDBLBMIAJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public override MCEBFGLGPKE JBBONNLGILK
		{
			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0xB0A470", Offset = "0xB09870", VA = "0x180B0A470", Slot = "140")]
			get
			{
				return default(MCEBFGLGPKE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x265DFB0", Offset = "0x265D3B0", VA = "0x18265DFB0")]
		public LEMMAHJHNKG(PMKDFPMAACD HKPECGCBGAA, GGDDBLBMIAJ BGCEKLPNCIL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private sealed class BJDIELHENJC : HHCHLJOKMMO<DIHDPEEJFOB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public override NodeVisualizationKey KKGMNHPHOBN
		{
			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0xCB77F0", Offset = "0xCB6BF0", VA = "0x180CB77F0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x2649370", Offset = "0x2648770", VA = "0x182649370")]
		public BJDIELHENJC(PMKDFPMAACD HKPECGCBGAA, DIHDPEEJFOB BLGGFHHEDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "134")]
		protected override void FLHCPNPGMGE(NNDHABFGLGH HIFAJDOJEBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class LHCLIEEGIPH : HHCHLJOKMMO<OAHPDJNPIKD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public sealed override NodeVisualizationKey KKGMNHPHOBN
		{
			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public sealed override bool AHDFICLIBDP
		{
			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		protected sealed override bool MALMJHBGPKA
		{
			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x265E380", Offset = "0x265D780", VA = "0x18265E380")]
		public LHCLIEEGIPH(PMKDFPMAACD HKPECGCBGAA, OAHPDJNPIKD BLGGFHHEDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x265E0B0", Offset = "0x265D4B0", VA = "0x18265E0B0", Slot = "134")]
		protected override void FLHCPNPGMGE(NNDHABFGLGH HIFAJDOJEBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x265E070", Offset = "0x265D470", VA = "0x18265E070")]
		private int DGEAMNINCBD()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x265E010", Offset = "0x265D410", VA = "0x18265E010")]
		private void BHPLKFGPFGK(int OEAPKNBFGIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class OLOFAJMOANO : IGIEBFEEMHI
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x26578D0", Offset = "0x2656CD0", VA = "0x1826578D0")]
		public OLOFAJMOANO(PMKDFPMAACD HKPECGCBGAA, BCCBPIEBIKF BLGGFHHEDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "134")]
		protected override void FLHCPNPGMGE(NNDHABFGLGH HIFAJDOJEBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class BBBALIPGFHN : ENGBJFABJNB<LPHGCLIKECE>
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x26491F0", Offset = "0x26485F0", VA = "0x1826491F0")]
		public BBBALIPGFHN(PMKDFPMAACD HKPECGCBGAA, LPHGCLIKECE BLGGFHHEDNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public abstract class ENGBJFABJNB<TVariableNode> : HHCHLJOKMMO<TVariableNode> where TVariableNode : notnull, LPHGCLIKECE
	{
		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		[CompilerGenerated]
		private sealed class LLMFDFFFLLO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public ENGBJFABJNB<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public BKCAMONFAFL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public LLMFDFFFLLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x4E6F310", Offset = "0x4E6E710", VA = "0x184E6F310")]
			internal bool ALHMIJFJECG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x4E6F370", Offset = "0x4E6E770", VA = "0x184E6F370")]
			internal void IAJMEFMNOEC(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x4E6F430", Offset = "0x4E6E830", VA = "0x184E6F430")]
			internal bool KAFKDPLFJPI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0x4E6F490", Offset = "0x4E6E890", VA = "0x184E6F490")]
			internal void LDMBHEIPGFP(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0x4E6F550", Offset = "0x4E6E950", VA = "0x184E6F550")]
			internal bool NBLMJKLKFBL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A9")]
		[CompilerGenerated]
		private sealed class COPMDHMGABP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public BKCAMONFAFL nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public ENGBJFABJNB<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public COPMDHMGABP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x64DAB50", Offset = "0x64D9F50", VA = "0x1864DAB50")]
			internal void LJPGDPLINLK(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public override NodeVisualizationKey KKGMNHPHOBN
		{
			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0xB30050", Offset = "0xB2F450", VA = "0x180B30050", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public override NEKNLAANBJD PGDIJPPMBAF
		{
			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0x42F99E0", Offset = "0x42F8DE0", VA = "0x1842F99E0", Slot = "108")]
			get
			{
				return default(NEKNLAANBJD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x42F9840", Offset = "0x42F8C40", VA = "0x1842F9840")]
		protected ENGBJFABJNB(PMKDFPMAACD HKPECGCBGAA, TVariableNode BLGGFHHEDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x42F9180", Offset = "0x42F8580", VA = "0x1842F9180", Slot = "101")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x42F9300", Offset = "0x42F8700", VA = "0x1842F9300", Slot = "134")]
		protected override void FLHCPNPGMGE(NNDHABFGLGH HIFAJDOJEBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x42F8E00", Offset = "0x42F8200", VA = "0x1842F8E00", Slot = "140")]
		protected virtual void CKCDLJMHANF(NNDHABFGLGH HIFAJDOJEBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x42F9790", Offset = "0x42F8B90", VA = "0x1842F9790", Slot = "119")]
		public override void GCJCJGLHJHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x263F6D0", Offset = "0x263EAD0", VA = "0x18263F6D0")]
	public static BINALJFGGNF HBLBJMFGHFK(PMKDFPMAACD HKPECGCBGAA, BCCBPIEBIKF BLGGFHHEDNC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public sealed class GFCOLMNDJFH : FFOFNIPBCNO, ADPCMOJCHBJ, NGPIGOMMKDP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public IJOGBJOFPED<DIEOFHIAEHN> CCCDIFJJFOO
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0xCC4190", Offset = "0xCC3590", VA = "0x180CC4190", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(IJOGBJOFPED<DIEOFHIAEHN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public IJOGBJOFPED<HOJGFCBIPIJ> NLOBKIDLIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xDAA830", Offset = "0xDA9C30", VA = "0x180DAA830", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(IJOGBJOFPED<HOJGFCBIPIJ>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x2655120", Offset = "0x2654520", VA = "0x182655120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private IJOGBJOFPED<AKEIPLNFNIN> GADMMCKLOBP
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xCC2E70", Offset = "0xCC2270", VA = "0x180CC2E70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public override IJOGBJOFPED<BIBBOHDALII> EKFHDFPKDGA
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x2655130", Offset = "0x2654530", VA = "0x182655130", Slot = "21")]
		get
		{
			return default(IJOGBJOFPED<BIBBOHDALII>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x2655180", Offset = "0x2654580", VA = "0x182655180")]
	private GFCOLMNDJFH(PMKDFPMAACD HKPECGCBGAA, BCCBPIEBIKF BLGGFHHEDNC, PCGDBPAGELP BJNNJBCLEED, IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI, IJOGBJOFPED<HOJGFCBIPIJ> MPJFFADFMPN, IJOGBJOFPED<AKEIPLNFNIN> JNOHLGFFMHD, bool KLOGPAEEFAN, string IGEPDAOOLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x2654DD0", Offset = "0x26541D0", VA = "0x182654DD0")]
	public static GFCOLMNDJFH HBLBJMFGHFK(PMKDFPMAACD HKPECGCBGAA, BCCBPIEBIKF BLGGFHHEDNC, PCGDBPAGELP OFLDFOLPLBP, IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI, IJOGBJOFPED<AKEIPLNFNIN> JNOHLGFFMHD, IJOGBJOFPED<HOJGFCBIPIJ> MPJFFADFMPN, bool KLOGPAEEFAN, bool NOHGKBLCEDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x2655120", Offset = "0x2654520", VA = "0x182655120")]
	internal void MINHALJMCCO(IJOGBJOFPED<HOJGFCBIPIJ> FFOEEMKIKJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public abstract class FFOFNIPBCNO : NGPIGOMMKDP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private struct OJBMPLCFADK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private LELIFDBOLAG? DPOKICMLCOI;

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x2663780", Offset = "0x2662B80", VA = "0x182663780")]
		public void CJEMNCEDADJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x2663790", Offset = "0x2662B90", VA = "0x182663790")]
		public LELIFDBOLAG KDALKLIFHAG(FFOFNIPBCNO LKOCEFIKKDG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	protected readonly PMKDFPMAACD JAGCIOPDOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	protected readonly BCCBPIEBIKF CLGMBPNHCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private OJBMPLCFADK PNFLDKMBFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private readonly KPDBDKKMKAM KHBDPMJLPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private readonly List<IMLFHAHCGAO> AMLNPAHMDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private readonly List<CHNAKABNDHB> BDMPKDNIBLO;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	[DGBLOAGKOKD("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> GHKNABPAKFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x2653060", Offset = "0x2652460", VA = "0x182653060", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public DisplayKind CDJFLHBMCMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x9B9EE0", Offset = "0x9B92E0", VA = "0x1809B9EE0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public IJOGBJOFPED<IIPIDDOCOEJ> LPFNJCCDDLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x2654000", Offset = "0x2653400", VA = "0x182654000", Slot = "6")]
		get
		{
			return default(IJOGBJOFPED<IIPIDDOCOEJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public HNEIHDEKOKM<IIPIDDOCOEJ> GFNBGCNMIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x2653200", Offset = "0x2652600", VA = "0x182653200", Slot = "7")]
		get
		{
			return default(HNEIHDEKOKM<IIPIDDOCOEJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public LEHFODJABPJ OBHGFHNGNEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0xC94960", Offset = "0xC93D60", VA = "0x180C94960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public AOCGGNLDEBO MFPENGKABDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x2653F60", Offset = "0x2653360", VA = "0x182653F60", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	protected LELIFDBOLAG MHGIAPCMBHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x2653F60", Offset = "0x2653360", VA = "0x182653F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public PortImage HFEDDMHKBPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x2653DB0", Offset = "0x26531B0", VA = "0x182653DB0", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public string KAFLMFCDNKO
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x9AA390", Offset = "0x9A9790", VA = "0x1809AA390", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x9AA5C0", Offset = "0x9A99C0", VA = "0x1809AA5C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public HNEIHDEKOKM<EICBKBBFNCN> INNLDLPPLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x2653EE0", Offset = "0x26532E0", VA = "0x182653EE0", Slot = "9")]
		get
		{
			return default(HNEIHDEKOKM<EICBKBBFNCN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public IJOGBJOFPED<AFJOOIBLMOP> BJHINJMDKNH
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0xC76980", Offset = "0xC75D80", VA = "0x180C76980", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(IJOGBJOFPED<AFJOOIBLMOP>);
		}
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0xDA9720", Offset = "0xDA8B20", VA = "0x180DA9720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public abstract IJOGBJOFPED<BIBBOHDALII> EKFHDFPKDGA
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x26541B0", Offset = "0x26535B0", VA = "0x1826541B0")]
	protected FFOFNIPBCNO(PMKDFPMAACD HKPECGCBGAA, BCCBPIEBIKF BLGGFHHEDNC, KPDBDKKMKAM LBADMGPENPB, IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI, bool KLOGPAEEFAN, string IGEPDAOOLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x2653550", Offset = "0x2652950", VA = "0x182653550", Slot = "22")]
	protected virtual void GDCNGOALEGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x2653230", Offset = "0x2652630", VA = "0x182653230", Slot = "23")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x2653F00", Offset = "0x2653300", VA = "0x182653F00", Slot = "14")]
	public void LKAHCCKLGFF(IMLFHAHCGAO DBNBJHEMMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x2653CF0", Offset = "0x26530F0", VA = "0x182653CF0", Slot = "15")]
	public void HBPGKELJFIK(CHNAKABNDHB DBNBJHEMMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x2653640", Offset = "0x2652A40", VA = "0x182653640", Slot = "16")]
	public void GNAHIFNHPMA(DJIECCABCIC CGFEEKFOMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x2653D50", Offset = "0x2653150", VA = "0x182653D50", Slot = "24")]
	protected virtual void JDMOBJOOKOJ(DJIECCABCIC CGFEEKFOMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x2654030", Offset = "0x2653430", VA = "0x182654030", Slot = "19")]
	private void PLJFJNJDDCM(bool FKPHPPGPLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x2653380", Offset = "0x2652780", VA = "0x182653380")]
	private void FBANEKNMAAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x2652EC0", Offset = "0x26522C0", VA = "0x182652EC0")]
	private void BBJHEOEHILC([In] HEAJIJAKAJN CMBEDLAGKII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x2653320", Offset = "0x2652720", VA = "0x182653320", Slot = "17")]
	public void EPIFFNHEDLJ(IMLFHAHCGAO DBNBJHEMMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x26531A0", Offset = "0x26525A0", VA = "0x1826531A0", Slot = "18")]
	public void CKBDKOOBCIA(CHNAKABNDHB DBNBJHEMMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x9AA5C0", Offset = "0x9A99C0", VA = "0x1809AA5C0")]
	internal void NKIGAJOLADK(string IGEPDAOOLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x2653530", Offset = "0x2652930", VA = "0x182653530")]
	internal void FEJJKLAOPCG(HFJIEDMDOEP OHJFEHDLOHB, LEHFODJABPJ HAFNBBNOLPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0xDA9720", Offset = "0xDA8B20", VA = "0x180DA9720")]
	internal void JMEECNHJAID(IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public sealed class IHBGKOPEFOA : JGCPKBOFLCP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class MBFACKMDBKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public PMKDFPMAACD circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public BCCBPIEBIKF node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public IJOGBJOFPED<AFJOOIBLMOP> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public MBFACKMDBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x265E480", Offset = "0x265D880", VA = "0x18265E480")]
		internal DBHFBPJKOOE EGFOLLPCCNE((int PortDescIndex, int PortIndex, PLHFHAAMBEI InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x265E3F0", Offset = "0x265D7F0", VA = "0x18265E3F0")]
		internal GFCOLMNDJFH APCPKAJMHLM(PCGDBPAGELP i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct PCJJFNONGBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public IHBGKOPEFOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private DJODKJGKOCD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x2663B90", Offset = "0x2662F90", VA = "0x182663B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x2664000", Offset = "0x2663400", VA = "0x182664000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct DJFGNMIMFCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public IHBGKOPEFOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public IJOGBJOFPED<DNIBKHBHLOO> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private DJODKJGKOCD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x264AFC0", Offset = "0x264A3C0", VA = "0x18264AFC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x264B310", Offset = "0x264A710", VA = "0x18264B310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct HNBLMECAOEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public IHBGKOPEFOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public IJOGBJOFPED<AKEIPLNFNIN> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private DJODKJGKOCD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x2655C00", Offset = "0x2655000", VA = "0x182655C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x2655F50", Offset = "0x2655350", VA = "0x182655F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct IDLLDLBEDHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public IHBGKOPEFOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public IJOGBJOFPED<DNIBKHBHLOO> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public IJOGBJOFPED<DNIBKHBHLOO> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private DJODKJGKOCD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x2657500", Offset = "0x2656900", VA = "0x182657500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x2657860", Offset = "0x2656C60", VA = "0x182657860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct GDJLOAPPHIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public IHBGKOPEFOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public IJOGBJOFPED<AKEIPLNFNIN> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public IJOGBJOFPED<AKEIPLNFNIN> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private DJODKJGKOCD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x2654A00", Offset = "0x2653E00", VA = "0x182654A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x2654D60", Offset = "0x2654160", VA = "0x182654D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct NMHMFIAGHNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public IHBGKOPEFOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private DJODKJGKOCD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x2662F10", Offset = "0x2662310", VA = "0x182662F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x2663390", Offset = "0x2662790", VA = "0x182663390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct FGCFIKOHCCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public IHBGKOPEFOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private DJODKJGKOCD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x2654560", Offset = "0x2653960", VA = "0x182654560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x26548B0", Offset = "0x2653CB0", VA = "0x1826548B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct KOPLKGMIFHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public IHBGKOPEFOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public IJOGBJOFPED<DNIBKHBHLOO> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private DJODKJGKOCD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x265D7C0", Offset = "0x265CBC0", VA = "0x18265D7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x265DB30", Offset = "0x265CF30", VA = "0x18265DB30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct MHCLAMOMEDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public IHBGKOPEFOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public IJOGBJOFPED<AKEIPLNFNIN> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private DJODKJGKOCD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x265EAF0", Offset = "0x265DEF0", VA = "0x18265EAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x265EE60", Offset = "0x265E260", VA = "0x18265EE60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct CFGLLJHHEHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public IHBGKOPEFOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public EGMEIGIGMNI type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public IJOGBJOFPED<DNIBKHBHLOO> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private DJODKJGKOCD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x2649AC0", Offset = "0x2648EC0", VA = "0x182649AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x2649E60", Offset = "0x2649260", VA = "0x182649E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct IALNFDLCHJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public IHBGKOPEFOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public EGMEIGIGMNI type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public IJOGBJOFPED<AKEIPLNFNIN> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private DJODKJGKOCD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x2655FC0", Offset = "0x26553C0", VA = "0x182655FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x2656360", Offset = "0x2655760", VA = "0x182656360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly bool NICNNHPMMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private readonly PMKDFPMAACD JAGCIOPDOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private readonly bool DMJMGPDPKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private OEEMOMGNMIG<LIGOHIGOKPO, DBHFBPJKOOE> BKBJPPOMCAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private OEEMOMGNMIG<LIGOHIGOKPO, GPLOGIMGNCB> PGIJJGLJAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private readonly BCCBPIEBIKF CLGMBPNHCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private OEEMOMGNMIG<HOJGFCBIPIJ, GFCOLMNDJFH> BOIHAIMFFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private OEEMOMGNMIG<HOJGFCBIPIJ, ADPCMOJCHBJ> KOKPGJNECCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private string? DMMFIOFPBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly FMFCAMOKBCJ MENOFJKMBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private IJOGBJOFPED<AFJOOIBLMOP> BFIPIFLJGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private readonly bool BAAGPEMCNJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	[CompilerGenerated]
	private Action? JCNCHGLOILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	[CompilerGenerated]
	private Action? OAAIMGDPPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	[CompilerGenerated]
	private Action<IJOGBJOFPED<LIGOHIGOKPO>>? CMDBEADAOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	[CompilerGenerated]
	private Action<IJOGBJOFPED<HOJGFCBIPIJ>>? GLDGIEHJLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	[CompilerGenerated]
	private JGCPKBOFLCP.GGNJOIMLJAA? IODMOHEJKDP;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool AFBIHAGOBDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x265B760", Offset = "0x265AB60", VA = "0x18265B760", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool IEEPGNGILOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x2657A00", Offset = "0x2656E00", VA = "0x182657A00", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool GMIAMMDECOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x2659680", Offset = "0x2658A80", VA = "0x182659680", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public HNEIHDEKOKM<IIPIDDOCOEJ> GFNBGCNMIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x26583C0", Offset = "0x26577C0", VA = "0x1826583C0", Slot = "7")]
		get
		{
			return default(HNEIHDEKOKM<IIPIDDOCOEJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool LALLOLEIEON
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x265C010", Offset = "0x265B410", VA = "0x18265C010", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public OEEMOMGNMIG<LIGOHIGOKPO, GPLOGIMGNCB> DMKKLIPKDML
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x9AA490", Offset = "0x9A9890", VA = "0x1809AA490", Slot = "9")]
		get
		{
			return default(OEEMOMGNMIG<LIGOHIGOKPO, GPLOGIMGNCB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public string KAFLMFCDNKO
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x265B9C0", Offset = "0x265ADC0", VA = "0x18265B9C0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public HNEIHDEKOKM<EICBKBBFNCN> INNLDLPPLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x265B820", Offset = "0x265AC20", VA = "0x18265B820", Slot = "11")]
		get
		{
			return default(HNEIHDEKOKM<EICBKBBFNCN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public OEEMOMGNMIG<HOJGFCBIPIJ, ADPCMOJCHBJ> CIFEHPEBAJA
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x9AA390", Offset = "0x9A9790", VA = "0x1809AA390", Slot = "12")]
		get
		{
			return default(OEEMOMGNMIG<HOJGFCBIPIJ, ADPCMOJCHBJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public IJOGBJOFPED<AFJOOIBLMOP> BJHINJMDKNH
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0xB1BC00", Offset = "0xB1B000", VA = "0x180B1BC00", Slot = "13")]
		get
		{
			return default(IJOGBJOFPED<AFJOOIBLMOP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action? CBCMJEAGFKM
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x26586D0", Offset = "0x2657AD0", VA = "0x1826586D0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x2657F20", Offset = "0x2657320", VA = "0x182657F20", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action? LNIFMKIJELG
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x2658FE0", Offset = "0x26583E0", VA = "0x182658FE0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x265C8C0", Offset = "0x265BCC0", VA = "0x18265C8C0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<IJOGBJOFPED<LIGOHIGOKPO?>, IJOGBJOFPED<LIGOHIGOKPO?>>? GGNNBAMBBGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x265B0A0", Offset = "0x265A4A0", VA = "0x18265B0A0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x2657C70", Offset = "0x2657070", VA = "0x182657C70", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<IJOGBJOFPED<LIGOHIGOKPO?>, IJOGBJOFPED<LIGOHIGOKPO?>>? AEIKPKCBCCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x265A7D0", Offset = "0x2659BD0", VA = "0x18265A7D0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x265A890", Offset = "0x2659C90", VA = "0x18265A890", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<IJOGBJOFPED<HOJGFCBIPIJ?>, IJOGBJOFPED<HOJGFCBIPIJ?>>? NDPPLCOKNOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x2657FC0", Offset = "0x26573C0", VA = "0x182657FC0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x265AA40", Offset = "0x2659E40", VA = "0x18265AA40", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<IJOGBJOFPED<HOJGFCBIPIJ?>, IJOGBJOFPED<HOJGFCBIPIJ?>>? PCGABAPDBCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x265C150", Offset = "0x265B550", VA = "0x18265C150", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x265C090", Offset = "0x265B490", VA = "0x18265C090", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<IJOGBJOFPED<LIGOHIGOKPO?>, GPLOGIMGNCB?>? IHCKDNBAFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x265B160", Offset = "0x265A560", VA = "0x18265B160", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x265BD70", Offset = "0x265B170", VA = "0x18265BD70", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<IJOGBJOFPED<LIGOHIGOKPO?>>? MFHNBICEOBH
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x2657E60", Offset = "0x2657260", VA = "0x182657E60", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x2657940", Offset = "0x2656D40", VA = "0x182657940", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<IJOGBJOFPED<LIGOHIGOKPO?>, GPLOGIMGNCB?>? LHGGGIAEJOF
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x265B900", Offset = "0x265AD00", VA = "0x18265B900", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x265BCB0", Offset = "0x265B0B0", VA = "0x18265BCB0", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<IJOGBJOFPED<HOJGFCBIPIJ?>, ADPCMOJCHBJ?>? MLLNEEPCMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x265B840", Offset = "0x265AC40", VA = "0x18265B840", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x26583F0", Offset = "0x26577F0", VA = "0x1826583F0", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<IJOGBJOFPED<HOJGFCBIPIJ?>>? DODKBNDNPOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x265BE30", Offset = "0x265B230", VA = "0x18265BE30", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x265BF50", Offset = "0x265B350", VA = "0x18265BF50", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<IJOGBJOFPED<HOJGFCBIPIJ?>, ADPCMOJCHBJ?>? PJJNNLJAKIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x265AB00", Offset = "0x2659F00", VA = "0x18265AB00", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x2659D30", Offset = "0x2659130", VA = "0x182659D30", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x265C970", Offset = "0x265BD70", VA = "0x18265C970")]
	private IHBGKOPEFOA(bool KLOGPAEEFAN, PMKDFPMAACD HKPECGCBGAA, bool HNBIBEEIDCA, OEEMOMGNMIG<LIGOHIGOKPO, DBHFBPJKOOE> COMKEBALMJE, OEEMOMGNMIG<LIGOHIGOKPO, GPLOGIMGNCB> CNFHGPDOHJC, BCCBPIEBIKF BLGGFHHEDNC, OEEMOMGNMIG<HOJGFCBIPIJ, GFCOLMNDJFH> EENOIMJOHCP, OEEMOMGNMIG<HOJGFCBIPIJ, ADPCMOJCHBJ> FCAGGLNIEKP, string? IGFOHKHJJON, FMFCAMOKBCJ DIJCCOIIFJA, IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI, bool NOHGKBLCEDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x2659DF0", Offset = "0x26591F0", VA = "0x182659DF0")]
	public static IHBGKOPEFOA HBLBJMFGHFK(bool KLOGPAEEFAN, PMKDFPMAACD HKPECGCBGAA, bool HNBIBEEIDCA, BCCBPIEBIKF BLGGFHHEDNC, FMFCAMOKBCJ DIJCCOIIFJA, IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI, bool NOHGKBLCEDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x26588C0", Offset = "0x2657CC0", VA = "0x1826588C0", Slot = "69")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x265B670", Offset = "0x265AA70", VA = "0x18265B670", Slot = "38")]
	[AsyncStateMachine(typeof(PCJJFNONGBH))]
	public Task<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN?>>? KMGGLMLBPLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x2657A40", Offset = "0x2656E40", VA = "0x182657A40")]
	private (GCMHHKKODLH?, int)? ACEGIMKLLIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x265A950", Offset = "0x2659D50", VA = "0x18265A950", Slot = "58")]
	private void HKMMIMMDKKF(int DFEDCOAEMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x1E52990", Offset = "0x1E51D90", VA = "0x181E52990", Slot = "57")]
	private void DFOLEMLAJOF(int DFEDCOAEMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x26592E0", Offset = "0x26586E0", VA = "0x1826592E0", Slot = "61")]
	private void FIDKPKPDOFK(int GHBDEPAAKNO, int LHDFPLDNJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x265B9F0", Offset = "0x265ADF0", VA = "0x18265B9F0", Slot = "63")]
	private void MAEHJMAHDFA(int GHBDEPAAKNO, int LHDFPLDNJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x2659740", Offset = "0x2658B40", VA = "0x182659740", Slot = "50")]
	private void GILPNAIJPBC(int DFEDCOAEMHK, IJOGBJOFPED<LIGOHIGOKPO> DFCBNFBMIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x2658080", Offset = "0x2657480", VA = "0x182658080", Slot = "54")]
	private void CBLDKLMHCKD(int FKPHPPGPLLD, IJOGBJOFPED<LIGOHIGOKPO> DFCBNFBMIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x265BEF0", Offset = "0x265B2F0", VA = "0x18265BEF0", Slot = "49")]
	private void NDIHEIOGDFD(int FKPHPPGPLLD, IJOGBJOFPED<LIGOHIGOKPO> DFCBNFBMIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x265B220", Offset = "0x265A620", VA = "0x18265B220", Slot = "53")]
	private void KDFDHFOKLDF(int DFEDCOAEMHK, IJOGBJOFPED<LIGOHIGOKPO> DFCBNFBMIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x265BB60", Offset = "0x265AF60", VA = "0x18265BB60", Slot = "66")]
	private void MGJFIMKOAOF(int DFEDCOAEMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x11E8BF0", Offset = "0x11E7FF0", VA = "0x1811E8BF0", Slot = "65")]
	private void DHOMHHOJLFE(int DFEDCOAEMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x26581C0", Offset = "0x26575C0", VA = "0x1826581C0", Slot = "60")]
	private void CCDHMOAGONA(int DFEDCOAEMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x1E52990", Offset = "0x1E51D90", VA = "0x181E52990", Slot = "59")]
	private void OBFIHMDAADG(int DFEDCOAEMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x2658C40", Offset = "0x2658040", VA = "0x182658C40", Slot = "62")]
	private void EGGHOJAOGKF(int GHBDEPAAKNO, int LHDFPLDNJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x2659CD0", Offset = "0x26590D0", VA = "0x182659CD0", Slot = "64")]
	private void GOHLDDEEDGD(int GHBDEPAAKNO, int LHDFPLDNJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x265C210", Offset = "0x265B610", VA = "0x18265C210", Slot = "52")]
	private void PIAGAJIPEND(int DFEDCOAEMHK, IJOGBJOFPED<HOJGFCBIPIJ> DFCBNFBMIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x265BF10", Offset = "0x265B310", VA = "0x18265BF10", Slot = "56")]
	private void NHNOKOBGJCI(int FKPHPPGPLLD, IJOGBJOFPED<HOJGFCBIPIJ> DFCBNFBMIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x265BF30", Offset = "0x265B330", VA = "0x18265BF30", Slot = "51")]
	private void NJHPJDIAHFF(int FKPHPPGPLLD, IJOGBJOFPED<HOJGFCBIPIJ> DFCBNFBMIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x265A360", Offset = "0x2659760", VA = "0x18265A360", Slot = "55")]
	private void HCCMJLPOMBI(int DFEDCOAEMHK, IJOGBJOFPED<HOJGFCBIPIJ> DFCBNFBMIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x2658770", Offset = "0x2657B70", VA = "0x182658770", Slot = "68")]
	private void DOKGAHEIMLC(int DFEDCOAEMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x11E8BF0", Offset = "0x11E7FF0", VA = "0x1811E8BF0", Slot = "67")]
	private void JBANAJNMJHO(int DFEDCOAEMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x26582B0", Offset = "0x26576B0", VA = "0x1826582B0", Slot = "39")]
	[AsyncStateMachine(typeof(DJFGNMIMFCC))]
	public Task<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN?>>? CKONCJAMLKE(IJOGBJOFPED<DNIBKHBHLOO> LPLICMPKNLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x265BA50", Offset = "0x265AE50", VA = "0x18265BA50", Slot = "40")]
	[AsyncStateMachine(typeof(HNBLMECAOEM))]
	public Task<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN?>>? MCHKLGPKBFH(IJOGBJOFPED<AKEIPLNFNIN> JNOHLGFFMHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x26580A0", Offset = "0x26574A0", VA = "0x1826580A0", Slot = "41")]
	[AsyncStateMachine(typeof(IDLLDLBEDHA))]
	public Task<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN?>>? CBNNFOLNKKM(IJOGBJOFPED<DNIBKHBHLOO> LPLICMPKNLI, IJOGBJOFPED<DNIBKHBHLOO> GDNPAJKBPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x265C7A0", Offset = "0x265BBA0", VA = "0x18265C7A0", Slot = "42")]
	[AsyncStateMachine(typeof(GDJLOAPPHIG))]
	public Task<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN?>>? PLOBHIJLPOA(IJOGBJOFPED<AKEIPLNFNIN> JNOHLGFFMHD, IJOGBJOFPED<AKEIPLNFNIN> GDNPAJKBPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x26585E0", Offset = "0x26579E0", VA = "0x1826585E0", Slot = "43")]
	[AsyncStateMachine(typeof(NMHMFIAGHNG))]
	public Task<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN?>>? DLIDJALIJJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x2659090", Offset = "0x2658490", VA = "0x182659090", Slot = "44")]
	[AsyncStateMachine(typeof(FGCFIKOHCCL))]
	public Task<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> FBEPKMCHNKD(string FCIOBAHJNBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x265ABC0", Offset = "0x2659FC0", VA = "0x18265ABC0", Slot = "45")]
	[AsyncStateMachine(typeof(KOPLKGMIFHC))]
	public Task<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> JEMBEILOBEA(IJOGBJOFPED<DNIBKHBHLOO> LPLICMPKNLI, string IGEPDAOOLBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x26591B0", Offset = "0x26585B0", VA = "0x1826591B0", Slot = "46")]
	[AsyncStateMachine(typeof(MHCLAMOMEDP))]
	public Task<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> FCJLHGGGLMD(IJOGBJOFPED<AKEIPLNFNIN> JNOHLGFFMHD, string IGEPDAOOLBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x26584B0", Offset = "0x26578B0", VA = "0x1826584B0", Slot = "47")]
	[AsyncStateMachine(typeof(CFGLLJHHEHB))]
	public Task<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> DIKHODMJKMH(IJOGBJOFPED<DNIBKHBHLOO> LPLICMPKNLI, EGMEIGIGMNI HAFNBBNOLPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x2657D30", Offset = "0x2657130", VA = "0x182657D30", Slot = "48")]
	[AsyncStateMachine(typeof(IALNFDLCHJE))]
	public Task<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> AJHEMBIKFPJ(IJOGBJOFPED<AKEIPLNFNIN> JNOHLGFFMHD, EGMEIGIGMNI HAFNBBNOLPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x265ACF0", Offset = "0x265A0F0", VA = "0x18265ACF0")]
	internal void JMEECNHJAID(IJOGBJOFPED<AFJOOIBLMOP> FFOEEMKIKJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public sealed class PHFLCIELONP : ILBJIDDJFAI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public interface KEDDGHAKJLM
	{
		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		public readonly struct AKODEJAOCAK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025D")]
			public readonly IReadOnlyDictionary<HNEIHDEKOKM<IIPIDDOCOEJ>, Guid>? FGKLELIAIEH;

			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0xC747D0", Offset = "0xC73BD0", VA = "0x180C747D0")]
			public AKODEJAOCAK(IReadOnlyDictionary<HNEIHDEKOKM<IIPIDDOCOEJ>, Guid>? FGKLELIAIEH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		HFJIEDMDOEP AFLPPPFFHPL
		{
			[Cpp2IlInjected.Token(Token = "0x600048A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<LECJPJBNNBI> GMCNIELNCPF(CancellationToken LMNHDKIFBOH);

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<NFAAFKCENHI> JKGAHNEMELH(CancellationToken LMNHDKIFBOH);

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<GFBLDLCHKBP> CGKDGMDCIEF(CancellationToken LMNHDKIFBOH);

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<OADNLLEBHMI> MDNJCCPOCGG(CancellationToken LMNHDKIFBOH);

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<AKODEJAOCAK> HFEJGNAFMEI(CancellationToken LMNHDKIFBOH);

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<MJDKFHDCAIJ> PKFHGPACCAL(CancellationToken LMNHDKIFBOH);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct IDDHHILJOAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public AsyncTaskMethodBuilder<PHFLCIELONP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public PMKDFPMAACD circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public LECJPJBNNBI roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public NFAAFKCENHI superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		private KEDDGHAKJLM <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private LECJPJBNNBI <downloadedRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private LECJPJBNNBI <actualRoomData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private MJDKFHDCAIJ <actualStaticConfig>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private NFAAFKCENHI <finalSuperRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private GFBLDLCHKBP <roomAssetData>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private OADNLLEBHMI <playerSaveData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<LECJPJBNNBI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private LECJPJBNNBI <>7__wrap8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter<MJDKFHDCAIJ> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private TaskAwaiter<NFAAFKCENHI> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private TaskAwaiter<GFBLDLCHKBP> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private TaskAwaiter<OADNLLEBHMI> <>u__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private TaskAwaiter<KEDDGHAKJLM.AKODEJAOCAK> <>u__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private TaskAwaiter<IAENGEFPAJO> <>u__7;

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x26563D0", Offset = "0x26557D0", VA = "0x1826563D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x2657490", Offset = "0x2656890", VA = "0x182657490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private readonly IAENGEFPAJO FFIKCFOFFJN;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public IAENGEFPAJO BKDDPJLBIFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x9B2970", Offset = "0x9B1D70", VA = "0x1809B2970")]
	private PHFLCIELONP(IAENGEFPAJO LHNONMDBEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x2664090", Offset = "0x2663490", VA = "0x182664090")]
	[AsyncStateMachine(typeof(IDDHHILJOAB))]
	public static Task<PHFLCIELONP> EDMFFMPPMGB(PMKDFPMAACD HKPECGCBGAA, LECJPJBNNBI? LLMAFCHBBPF, NFAAFKCENHI? JKIDAGFNHLP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x2664070", Offset = "0x2663470", VA = "0x182664070", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public readonly struct NOFMAMMILJP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct OKIDMCMDHBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<object, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public NOFMAMMILJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public FCMLLGFOEBF action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private TaskAwaiter<KGPHFOFOMPJ<object, HEGOEPNOLEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x2663830", Offset = "0x2662C30", VA = "0x182663830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x2663AC0", Offset = "0x2662EC0", VA = "0x182663AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct AKAOJEDKLFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<bool, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public HODMPAADEDL rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public LECJPJBNNBI circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public NFAAFKCENHI superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public NOFMAMMILJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private FCMLLGFOEBF[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private TaskAwaiter<KGPHFOFOMPJ<object, HEGOEPNOLEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x2648200", Offset = "0x2647600", VA = "0x182648200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x26485E0", Offset = "0x26479E0", VA = "0x1826485E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct MNBIMBIDLPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public NOFMAMMILJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private TaskAwaiter<KGPHFOFOMPJ<object, HEGOEPNOLEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x2660BF0", Offset = "0x265FFF0", VA = "0x182660BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x2660E30", Offset = "0x2660230", VA = "0x182660E30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	private readonly JKECMCHDNIJ JGILMOEKBKL;

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0xC747D0", Offset = "0xC73BD0", VA = "0x180C747D0")]
	public NOFMAMMILJP(JKECMCHDNIJ FLCBCFNKGNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x2663560", Offset = "0x2662960", VA = "0x182663560")]
	[AsyncStateMachine(typeof(OKIDMCMDHBD))]
	private Task<KGPHFOFOMPJ<object, HEGOEPNOLEN>> NKFEECKELMI(FCMLLGFOEBF IOPCFKOHPBF, bool FHAKEDFMMAB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x2663400", Offset = "0x2662800", VA = "0x182663400")]
	[AsyncStateMachine(typeof(AKAOJEDKLFC))]
	public Task<KGPHFOFOMPJ<bool, HEGOEPNOLEN?>>? MHIOCPAMEDG(int BEGLDMFGEOI, HODMPAADEDL? MMILFLIJGKL, LECJPJBNNBI? MJJBHALKDGD, NFAAFKCENHI? JKIDAGFNHLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x2663690", Offset = "0x2662A90", VA = "0x182663690")]
	[AsyncStateMachine(typeof(MNBIMBIDLPP))]
	public Task<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> OAHDOECNNKP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public sealed class BKIACAGINJB : LEJBIGAEAEM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private readonly AEHDPDEKPEJ MELEMIKOGIN;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public AEHDPDEKPEJ CADHJDGJMLP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x9B2970", Offset = "0x9B1D70", VA = "0x1809B2970")]
	private BKIACAGINJB(AEHDPDEKPEJ FIEOOEEFAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x2649400", Offset = "0x2648800", VA = "0x182649400")]
	public static BKIACAGINJB HFAEDKNMEEN(PMKDFPMAACD HKPECGCBGAA, HODMPAADEDL KJADGHOGOGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x26493E0", Offset = "0x26487E0", VA = "0x1826493E0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public interface ICIGGIMHPMH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	IAENGEFPAJO BKDDPJLBIFA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	OIIIPHHKNKK PCKGOHOALLA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	HGOPNPABFDI AAIFOEHIEGA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	FECMAMGMIBA AALAMDEEDHA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public interface JEHEBBDPAGI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	ICIGGIMHPMH? IIDHHEENAMI
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	bool LCONPCPHNJM
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	bool IIMBDNJIOCN
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<ICIGGIMHPMH?>? AECBPLHABPI();

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task LMAMNKLAABG(PMKDFPMAACD HKPECGCBGAA, HODMPAADEDL KJADGHOGOGK, LECJPJBNNBI? NJAIFIIMJEN, NFAAFKCENHI? KDHINLEFFAG);
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[MOGMCIKHBCO("IStaticCV2Instance")]
public interface ILBJIDDJFAI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	IAENGEFPAJO BKDDPJLBIFA
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[MOGMCIKHBCO("IStaticEVInstance")]
public interface LEJBIGAEAEM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	AEHDPDEKPEJ CADHJDGJMLP
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public static class EMDCPBFMOAP
{
	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x264B660", Offset = "0x264AA60", VA = "0x18264B660")]
	public static DNNLPNOLHBJ<HLGPJHLLHLK, FCMLLGFOEBF, PMKDFPMAACD, KLOPJJFPPNK.OEAIGBPOPBO<HLGPJHLLHLK, FCMLLGFOEBF, PMKDFPMAACD>> NILBDGCKKCN([In] this DNNLPNOLHBJ<HLGPJHLLHLK, FCMLLGFOEBF, PMKDFPMAACD, KLOPJJFPPNK.OEAIGBPOPBO<HLGPJHLLHLK, FCMLLGFOEBF, PMKDFPMAACD>> OALGONLNNEB)
	{
		return default(DNNLPNOLHBJ<HLGPJHLLHLK, FCMLLGFOEBF, PMKDFPMAACD, KLOPJJFPPNK.OEAIGBPOPBO<HLGPJHLLHLK, FCMLLGFOEBF, PMKDFPMAACD>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class MHLLOPMPAHP : MDHGNCHDNJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private readonly PMKDFPMAACD JAGCIOPDOMP;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool IIMBDNJIOCN
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x265EED0", Offset = "0x265E2D0", VA = "0x18265EED0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x9B2970", Offset = "0x9B1D70", VA = "0x1809B2970")]
	internal MHLLOPMPAHP(PMKDFPMAACD HKPECGCBGAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal sealed class DAPAIJIKJCN : IBDGMLOEDJD
{
	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x264AEC0", Offset = "0x264A2C0", VA = "0x18264AEC0", Slot = "4")]
	public FEPMKPNFJOD? AMBGIOCKMKL(string? JGBBMDGLIPE, string? MNLBCHPMPOK, string? AOCIKINIDDG, MPMNBDBIGKB.IGLBHCLOMAC.FPGPAOGDFBH KFDKNCKIHNM, bool DFMIJFIDGDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public DAPAIJIKJCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public sealed class CGLJGDHEBMI : NPLPKFDPNKH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private struct JBMGFMIEMEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public AsyncTaskMethodBuilder<FKHMMAMFILM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public CGLJGDHEBMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private TaskAwaiter<ICIGGIMHPMH?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x265CEF0", Offset = "0x265C2F0", VA = "0x18265CEF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x265D190", Offset = "0x265C590", VA = "0x18265D190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private readonly PMKDFPMAACD JAGCIOPDOMP;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public FKHMMAMFILM? DNEPPKLGBFA
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x264A920", Offset = "0x2649D20", VA = "0x18264A920", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public FECMAMGMIBA? HLLKGKLFGNA
	{
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x2649FB0", Offset = "0x26493B0", VA = "0x182649FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool JHKNIJNKFIF
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x264A860", Offset = "0x2649C60", VA = "0x18264A860", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool FOMHAGONEGA
	{
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x264A8C0", Offset = "0x2649CC0", VA = "0x18264A8C0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x264AA90", Offset = "0x2649E90", VA = "0x18264AA90")]
	internal CGLJGDHEBMI(PMKDFPMAACD HKPECGCBGAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x264A9A0", Offset = "0x2649DA0", VA = "0x18264A9A0", Slot = "7")]
	[AsyncStateMachine(typeof(JBMGFMIEMEP))]
	public Task<FKHMMAMFILM> PHJIHKNMIAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x264A4F0", Offset = "0x26498F0", VA = "0x18264A4F0", Slot = "9")]
	public IReadOnlyDictionary<HNEIHDEKOKM<IIPIDDOCOEJ>, Guid> FBHDPLAKBCP(IEnumerable<AJANKEAEBKF> AJJCKPMDACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x264A370", Offset = "0x2649770", VA = "0x18264A370", Slot = "10")]
	public LNFFFCAAMND EEONKCOBOLC(IEnumerable<AJANKEAEBKF> AJJCKPMDACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x264A030", Offset = "0x2649430", VA = "0x18264A030")]
	public KGPHFOFOMPJ<BLJGKFNLMDH, ALOCPDILHNE> CKLAHDPPLGI([In] BLJGKFNLMDH FAFMAEOCHJN)
	{
		return default(KGPHFOFOMPJ<BLJGKFNLMDH, ALOCPDILHNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x264A1D0", Offset = "0x26495D0", VA = "0x18264A1D0", Slot = "8")]
	private KGPHFOFOMPJ<BLJGKFNLMDH, ALOCPDILHNE> CLGGOEEEGDH([In] BLJGKFNLMDH FAFMAEOCHJN)
	{
		return default(KGPHFOFOMPJ<BLJGKFNLMDH, ALOCPDILHNE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public sealed class FECMAMGMIBA : FKHMMAMFILM
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	internal static class MMIAKFGPOKK
	{
		[Cpp2IlInjected.Token(Token = "0x20000D1")]
		[CompilerGenerated]
		private sealed class FBELCLMOGBM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400029B")]
			public IAENGEFPAJO state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400029C")]
			public HIOKFJEHHDO spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x6000521")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public FBELCLMOGBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000522")]
			[Cpp2IlInjected.Address(RVA = "0x2666FC0", Offset = "0x26663C0", VA = "0x182666FC0")]
			internal bool PCIJLCFIOJL(ANNEGHIHGIH n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		[CompilerGenerated]
		private sealed class DCNHJHOEPLG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400029D")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x6000523")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public DCNHJHOEPLG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000524")]
			[Cpp2IlInjected.Address(RVA = "0x26666D0", Offset = "0x2665AD0", VA = "0x1826666D0")]
			internal void KOKICOCDBNB(ANNEGHIHGIH n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x265EEF0", Offset = "0x265E2F0", VA = "0x18265EEF0")]
		public static KGPHFOFOMPJ<FKHMMAMFILM.PMBHLFNPHPH, IFNDEKFLNMG> AMNMBKBGPIL(FECMAMGMIBA JOCJBPPJMJJ, [In] FKHMMAMFILM.BGLPDBGFIPI BPKDFLJLPAA)
		{
			return default(KGPHFOFOMPJ<FKHMMAMFILM.PMBHLFNPHPH, IFNDEKFLNMG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x265FDE0", Offset = "0x265F1E0", VA = "0x18265FDE0")]
		internal static KGPHFOFOMPJ<(PPBNOPGIKOE, CNCJBIEMPJA), IFNDEKFLNMG> NEGINEFODBJ(FECMAMGMIBA JOCJBPPJMJJ, CNCJBIEMPJA ODMIPAHIOPN, bool EILLGGOAABF, [In] HNEIHDEKOKM<IIPIDDOCOEJ> ICBOOCHOAND, [In] int? OHLCNOOCPFB, [In] OGKLGKEPIME? HHCCBJGPDGE, [In] OGKLGKEPIME? JPKDBEAKFON)
		{
			return default(KGPHFOFOMPJ<(PPBNOPGIKOE, CNCJBIEMPJA), IFNDEKFLNMG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x265F520", Offset = "0x265E920", VA = "0x18265F520")]
		private static void GAKKLKHFKMD(bool EILLGGOAABF, AJANKEAEBKF LLCPKAOMDKB, PPBNOPGIKOE EJLEAGDLAEO, [In] HNEIHDEKOKM<IIPIDDOCOEJ> ICBOOCHOAND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x265F9D0", Offset = "0x265EDD0", VA = "0x18265F9D0")]
		public static void NBEOEGJJNGK(KKGLKNAHIHO BGGJCPHIEBP, [In] FKHMMAMFILM.AAOLMLKPIIN CBJMMLHPHCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x265F430", Offset = "0x265E830", VA = "0x18265F430")]
		[CompilerGenerated]
		internal static bool FJNCLMAEKMN(IAENGEFPAJO PGKDGOCGOPL, HIOKFJEHHDO NKDEGGNCMCN, ANNEGHIHGIH AMGHKFFHELL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x265F9A0", Offset = "0x265EDA0", VA = "0x18265F9A0")]
		[CompilerGenerated]
		internal static bool MBDPKMLKLAB(ANNEGHIHGIH INAPFKLHCFN)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct EDDFJGIAGHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public FECMAMGMIBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public IJOGBJOFPED<IIPIDDOCOEJ> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public IJOGBJOFPED<EICBKBBFNCN> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public BICGACHNKNM offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public bool deleteBoard;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x2666D00", Offset = "0x2666100", VA = "0x182666D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x2666F50", Offset = "0x2666350", VA = "0x182666F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct IOHHIKKHEAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public FECMAMGMIBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public IJOGBJOFPED<IIPIDDOCOEJ> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public HNEIHDEKOKM<EICBKBBFNCN> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public List<IJOGBJOFPED<EICBKBBFNCN>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public BICGACHNKNM localBoardPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public NJLBLADHJBH localBoardRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public BICGACHNKNM offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x2667B00", Offset = "0x2666F00", VA = "0x182667B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x2667DC0", Offset = "0x26671C0", VA = "0x182667DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct JMFIIHFODHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public FECMAMGMIBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public IJOGBJOFPED<IIPIDDOCOEJ> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public HNEIHDEKOKM<EICBKBBFNCN> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public List<IJOGBJOFPED<EICBKBBFNCN>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x2668140", Offset = "0x2667540", VA = "0x182668140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x2668380", Offset = "0x2667780", VA = "0x182668380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct CALHIKFCALP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public FECMAMGMIBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public IJOGBJOFPED<IIPIDDOCOEJ> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public HNEIHDEKOKM<EICBKBBFNCN> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public IJOGBJOFPED<IIPIDDOCOEJ> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public List<IJOGBJOFPED<EICBKBBFNCN>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x2665D00", Offset = "0x2665100", VA = "0x182665D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x2665F40", Offset = "0x2665340", VA = "0x182665F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct KGNCPPELMDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public FECMAMGMIBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public HNEIHDEKOKM<IIPIDDOCOEJ> legacyGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public HNEIHDEKOKM<EICBKBBFNCN> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public IReadOnlyList<HNEIHDEKOKM<EICBKBBFNCN>> nodeLegacyIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public IReadOnlyDictionary<KAOGONDBLJA, (IJOGBJOFPED<AFJOOIBLMOP>, IJOGBJOFPED<LIGOHIGOKPO>)> inputMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public IReadOnlyDictionary<OFCFDCLHNFE, (IJOGBJOFPED<AFJOOIBLMOP>, IJOGBJOFPED<HOJGFCBIPIJ>)> outputMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x2668680", Offset = "0x2667A80", VA = "0x182668680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x2668CA0", Offset = "0x26680A0", VA = "0x182668CA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct CKNGBPKGKNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public FECMAMGMIBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public IJOGBJOFPED<IIPIDDOCOEJ> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public IJOGBJOFPED<DIEOFHIAEHN> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public IJOGBJOFPED<KHMKGBDANIH> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x2666010", Offset = "0x2665410", VA = "0x182666010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x2666660", Offset = "0x2665A60", VA = "0x182666660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct DFPFCHEOKOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public FECMAMGMIBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public HNEIHDEKOKM<EICBKBBFNCN> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public HNEIHDEKOKM<IIPIDDOCOEJ> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public IJOGBJOFPED<AFJOOIBLMOP> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public IJOGBJOFPED<LIGOHIGOKPO> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x26666F0", Offset = "0x2665AF0", VA = "0x1826666F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x2666A30", Offset = "0x2665E30", VA = "0x182666A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private struct LNDECAINJNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public FECMAMGMIBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public HNEIHDEKOKM<EICBKBBFNCN> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public HNEIHDEKOKM<IIPIDDOCOEJ> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public IJOGBJOFPED<AFJOOIBLMOP> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public IJOGBJOFPED<HOJGFCBIPIJ> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x266AE20", Offset = "0x266A220", VA = "0x18266AE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x266B160", Offset = "0x266A560", VA = "0x18266B160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct JPPLNDJBIDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public FECMAMGMIBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private TaskAwaiter<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x26683F0", Offset = "0x26677F0", VA = "0x1826683F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x2668610", Offset = "0x2667A10", VA = "0x182668610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private readonly PMKDFPMAACD JAGCIOPDOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private readonly ILBJIDDJFAI COBCJEJKOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private readonly LEJBIGAEAEM PGHBAJILLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private readonly CHCIBBALBKE IACOAFJBPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private readonly CGLJGDHEBMI GHDPMJKEKJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private Dictionary<HNEIHDEKOKM<EICBKBBFNCN>, BINALJFGGNF> BDCJFPNCAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	[CompilerGenerated]
	private Action<HNEIHDEKOKM<EICBKBBFNCN>>? IKGBKDBIJHA;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public HNEIHDEKOKM<IIPIDDOCOEJ> ILKELOFHENE
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x2651B90", Offset = "0x2650F90", VA = "0x182651B90", Slot = "4")]
		get
		{
			return default(HNEIHDEKOKM<IIPIDDOCOEJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public CHCIBBALBKE NDIPJPBKFEK
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x2646690", Offset = "0x2645A90", VA = "0x182646690", Slot = "5")]
		get
		{
			return default(CHCIBBALBKE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x2652940", Offset = "0x2651D40", VA = "0x182652940")]
	public FECMAMGMIBA(PMKDFPMAACD HKPECGCBGAA, ILBJIDDJFAI BMMNCLDOHPD, LEJBIGAEAEM AMDKGIOPIPC, CGLJGDHEBMI PFBIIMDEJON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x264FA80", Offset = "0x264EE80", VA = "0x18264FA80", Slot = "65")]
	public IJOGBJOFPED<HEMNMAIIMJK> HAOPHIPIJOC(IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<KHMKGBDANIH> DGBNICFCJPK)
	{
		return default(IJOGBJOFPED<HEMNMAIIMJK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x264D0D0", Offset = "0x264C4D0", VA = "0x18264D0D0", Slot = "66")]
	public IJOGBJOFPED<PHBAJLIMCFA> CBPJBAGONEN(IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<DIEOFHIAEHN> MPJFFADFMPN)
	{
		return default(IJOGBJOFPED<PHBAJLIMCFA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x2651320", Offset = "0x2650720", VA = "0x182651320", Slot = "6")]
	public (bool, bool) MECDGEDJOKO(IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<DIEOFHIAEHN> NOOHCNGJKGB, IJOGBJOFPED<KHMKGBDANIH> CINNJNFNKEL)
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x2650900", Offset = "0x264FD00", VA = "0x182650900")]
	public bool LNJOHAPINNO(IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, [In] GAPALAEOGHH BHOOGELKBIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x2651130", Offset = "0x2650530", VA = "0x182651130", Slot = "8")]
	public bool MBEKDPEPOBI(GPLOGIMGNCB LPGCHGBOCFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x264D1D0", Offset = "0x264C5D0", VA = "0x18264D1D0", Slot = "9")]
	public bool CIEFNLKMOON(ADPCMOJCHBJ IJLILDFMLGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x2652700", Offset = "0x2651B00", VA = "0x182652700", Slot = "10")]
	public AIKLHLHBHJO? PADHPFELILM(IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<KHMKGBDANIH> DGBNICFCJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x264D010", Offset = "0x264C410", VA = "0x18264D010", Slot = "11")]
	public LGINHCIGMKK? BOLAMKHIAGM(IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<DIEOFHIAEHN> MPJFFADFMPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x264BD70", Offset = "0x264B170", VA = "0x18264BD70", Slot = "12")]
	public IJOGBJOFPED<DIEOFHIAEHN>? AJJIDGOKLMH(IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK, IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI, IJOGBJOFPED<HOJGFCBIPIJ> MCIKILGHAHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x26523F0", Offset = "0x26517F0", VA = "0x1826523F0", Slot = "13")]
	public IJOGBJOFPED<KHMKGBDANIH>? OOONOKFIKJA(IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK, IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI, IJOGBJOFPED<LIGOHIGOKPO> FNJFCLABCPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x264FC20", Offset = "0x264F020", VA = "0x18264FC20", Slot = "14")]
	public IEnumerable<IJOGBJOFPED<IIPIDDOCOEJ>> HKNNBHMHMKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x264FB70", Offset = "0x264EF70", VA = "0x18264FB70", Slot = "15")]
	public IEnumerable<IJOGBJOFPED<MMPLDILNACO>> HGFEHCONMLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x264CDC0", Offset = "0x264C1C0", VA = "0x18264CDC0", Slot = "16")]
	public string BKNHANPJNJG(IJOGBJOFPED<MMPLDILNACO> NJJPILKEKJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x26506F0", Offset = "0x264FAF0", VA = "0x1826506F0", Slot = "17")]
	public string KNNDCCNHOKG(IJOGBJOFPED<MMPLDILNACO> NJJPILKEKJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x26511B0", Offset = "0x26505B0", VA = "0x1826511B0")]
	public BINALJFGGNF? MEAEGJHFBEH([In] HNEIHDEKOKM<EICBKBBFNCN> CCBIHMLAAKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x2652510", Offset = "0x2651910", VA = "0x182652510", Slot = "23")]
	public IJOGBJOFPED<GOENONHHIDE> OPANIAAKODI(IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK)
	{
		return default(IJOGBJOFPED<GOENONHHIDE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x264D150", Offset = "0x264C550", VA = "0x18264D150")]
	public IJOGBJOFPED<EICBKBBFNCN> HOOHLLLBJND(IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, [In] HNEIHDEKOKM<EICBKBBFNCN> IMJNKJFOHDC)
	{
		return default(IJOGBJOFPED<EICBKBBFNCN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x264F800", Offset = "0x264EC00", VA = "0x18264F800", Slot = "33")]
	public IJOGBJOFPED<EICBKBBFNCN> GPBINPEGCBM(IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<KHMKGBDANIH> DGBNICFCJPK)
	{
		return default(IJOGBJOFPED<EICBKBBFNCN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x264BE00", Offset = "0x264B200", VA = "0x18264BE00", Slot = "34")]
	public IJOGBJOFPED<EICBKBBFNCN> AKCHBBIBPID(IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<DIEOFHIAEHN> MPJFFADFMPN)
	{
		return default(IJOGBJOFPED<EICBKBBFNCN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x26527C0", Offset = "0x2651BC0", VA = "0x1826527C0")]
	public IJOGBJOFPED<EICBKBBFNCN>? PHPPBIKNCDJ(IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, [In] HNEIHDEKOKM<EICBKBBFNCN> IMJNKJFOHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x264CC90", Offset = "0x264C090", VA = "0x18264CC90", Slot = "25")]
	public LPGPDDAKCIG? BHPCMLPOBLC(IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x2652160", Offset = "0x2651560", VA = "0x182652160", Slot = "26")]
	public long OHBOBHOLHGM()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x264F290", Offset = "0x264E690", VA = "0x18264F290")]
	private void EPALHBCJPPB(HNEIHDEKOKM<EICBKBBFNCN> CCBIHMLAAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x2650080", Offset = "0x264F480", VA = "0x182650080", Slot = "31")]
	public IEnumerable<(IJOGBJOFPED<IIPIDDOCOEJ>, IJOGBJOFPED<EICBKBBFNCN>)> IIBCFHHKPKC(IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x2652480", Offset = "0x2651880", VA = "0x182652480", Slot = "32")]
	public IJOGBJOFPED<KHMKGBDANIH> OOONOKFIKJA(IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK, IJOGBJOFPED<HEMNMAIIMJK> FNJFCLABCPK)
	{
		return default(IJOGBJOFPED<KHMKGBDANIH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x264BCE0", Offset = "0x264B0E0", VA = "0x18264BCE0", Slot = "35")]
	public IJOGBJOFPED<DIEOFHIAEHN> AJJIDGOKLMH(IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK, IJOGBJOFPED<PHBAJLIMCFA> MCIKILGHAHK)
	{
		return default(IJOGBJOFPED<DIEOFHIAEHN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x264F880", Offset = "0x264EC80", VA = "0x18264F880")]
	private BINALJFGGNF? HAEFEBNLPNG([In] HNEIHDEKOKM<EICBKBBFNCN> CCBIHMLAAKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x264F320", Offset = "0x264E720", VA = "0x18264F320")]
	public BCCBPIEBIKF? FGMEJGCKLFI([In] HNEIHDEKOKM<EICBKBBFNCN> CCBIHMLAAKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x26506C0", Offset = "0x264FAC0", VA = "0x1826506C0")]
	public LPCHFMKMBHL? LBMFPIKHIMA([In] HNEIHDEKOKM<IIPIDDOCOEJ> MIFALNLOHHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x2650840", Offset = "0x264FC40", VA = "0x182650840", Slot = "27")]
	public IEnumerable<FEBHGHLDFDK> LMOKDDLIHDA(IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x2652840", Offset = "0x2651C40", VA = "0x182652840", Slot = "28")]
	public bool PMAEBAKDHNM(IJOGBJOFPED<MMPLDILNACO> NJJPILKEKJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x264FCB0", Offset = "0x264F0B0", VA = "0x18264FCB0", Slot = "29")]
	public IEnumerable<GAPALAEOGHH> HKPLOGGGOKJ(IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<DIEOFHIAEHN> NOOHCNGJKGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x2651EE0", Offset = "0x26512E0", VA = "0x182651EE0", Slot = "30")]
	public IEnumerable<GAPALAEOGHH> OBBINMKNLKD(IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<KHMKGBDANIH> CINNJNFNKEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x2651C70", Offset = "0x2651070", VA = "0x182651C70")]
	public IJOGBJOFPED<IIPIDDOCOEJ> NBOLNEKODAF([In] HNEIHDEKOKM<IIPIDDOCOEJ> MIFALNLOHHH)
	{
		return default(IJOGBJOFPED<IIPIDDOCOEJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x264CF90", Offset = "0x264C390", VA = "0x18264CF90")]
	public IJOGBJOFPED<IIPIDDOCOEJ>? BLKOEGECNOB([In] HNEIHDEKOKM<IIPIDDOCOEJ> MIFALNLOHHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x2650130", Offset = "0x264F530", VA = "0x182650130")]
	private HIOKFJEHHDO? JFMACHNDKKP([In] HNEIHDEKOKM<IIPIDDOCOEJ> MIFALNLOHHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x26506C0", Offset = "0x264FAC0", VA = "0x1826506C0")]
	private LPCHFMKMBHL? KHPCJOCGNEL([In] HNEIHDEKOKM<IIPIDDOCOEJ> MIFALNLOHHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x264F030", Offset = "0x264E430", VA = "0x18264F030", Slot = "21")]
	public IJOGBJOFPED<IIPIDDOCOEJ>? EHIMJABFMOG(IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x264FB00", Offset = "0x264EF00", VA = "0x18264FB00", Slot = "39")]
	public HNEIHDEKOKM<IIPIDDOCOEJ> HBCLLMMPIAE(IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH)
	{
		return default(HNEIHDEKOKM<IIPIDDOCOEJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x264C070", Offset = "0x264B470", VA = "0x18264C070", Slot = "36")]
	public IEnumerable<EGMEIGIGMNI> BAKKNEIGAKB(DENLGPGJNNO GHAKMOHCDAE, bool ACDCNDAPADF, bool MPFLOJMIPKL, bool JPNIEFNLLGM, bool FMIPCGKBIME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x264DDC0", Offset = "0x264D1C0", VA = "0x18264DDC0", Slot = "37")]
	public EGMEIGIGMNI DLIIIALMPBO(DENLGPGJNNO GHAKMOHCDAE, NGPIGOMMKDP BHBFPLKACBM, bool ACDCNDAPADF, bool MPFLOJMIPKL, bool JPNIEFNLLGM, bool FMIPCGKBIME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x264BB70", Offset = "0x264AF70", VA = "0x18264BB70")]
	public FEBHGHLDFDK MHOJPOJMNPM(IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, [In] GAPALAEOGHH BHOOGELKBIM)
	{
		return default(FEBHGHLDFDK);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x26521C0", Offset = "0x26515C0", VA = "0x1826521C0", Slot = "40")]
	public GAPALAEOGHH ONHHIOEPKMN(IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<DIEOFHIAEHN> NOOHCNGJKGB, IJOGBJOFPED<KHMKGBDANIH> CINNJNFNKEL)
	{
		return default(GAPALAEOGHH);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x264F930", Offset = "0x264ED30", VA = "0x18264F930", Slot = "41")]
	[AsyncStateMachine(typeof(EDDFJGIAGHO))]
	public Task<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> HAIGFAGCIFF(IJOGBJOFPED<IIPIDDOCOEJ> KAJGNDPHKBL, IJOGBJOFPED<EICBKBBFNCN> CIMGPOKLJHF, BICGACHNKNM HGHGCNDALFP, bool KJKMOPKFIGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x264BEF0", Offset = "0x264B2F0", VA = "0x18264BEF0", Slot = "42")]
	[AsyncStateMachine(typeof(IOHHIKKHEAI))]
	public Task<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> AOEIDIKOEKH(IJOGBJOFPED<IIPIDDOCOEJ> KAJGNDPHKBL, HNEIHDEKOKM<EICBKBBFNCN> CIMGPOKLJHF, List<IJOGBJOFPED<EICBKBBFNCN>> ABOLAIFBOMD, BICGACHNKNM AGCKOAALHBC, NJLBLADHJBH GPLMJDLEDJL, BICGACHNKNM HGHGCNDALFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x264C170", Offset = "0x264B570", VA = "0x18264C170", Slot = "45")]
	[AsyncStateMachine(typeof(JMFIIHFODHJ))]
	public Task<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> BAOJHNLIDOJ(IJOGBJOFPED<IIPIDDOCOEJ> KAJGNDPHKBL, HNEIHDEKOKM<EICBKBBFNCN> CIMGPOKLJHF, List<IJOGBJOFPED<EICBKBBFNCN>> ABOLAIFBOMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x264CE30", Offset = "0x264C230", VA = "0x18264CE30", Slot = "46")]
	[AsyncStateMachine(typeof(CALHIKFCALP))]
	public Task<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> BLFCALFOKKE(IJOGBJOFPED<IIPIDDOCOEJ> KAJGNDPHKBL, HNEIHDEKOKM<EICBKBBFNCN> CIMGPOKLJHF, IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, List<IJOGBJOFPED<EICBKBBFNCN>> ABOLAIFBOMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x2652590", Offset = "0x2651990", VA = "0x182652590", Slot = "43")]
	public (IReadOnlyDictionary<KAOGONDBLJA, (IJOGBJOFPED<AFJOOIBLMOP>, IJOGBJOFPED<LIGOHIGOKPO>)>, IReadOnlyDictionary<OFCFDCLHNFE, (IJOGBJOFPED<AFJOOIBLMOP>, IJOGBJOFPED<HOJGFCBIPIJ>)>) OPELCIFGFCJ(HNEIHDEKOKM<IIPIDDOCOEJ> MFJBHLMAMOL, IJOGBJOFPED<EICBKBBFNCN> CIMGPOKLJHF)
	{
		return default((IReadOnlyDictionary<KAOGONDBLJA, (IJOGBJOFPED<AFJOOIBLMOP>, IJOGBJOFPED<LIGOHIGOKPO>)>, IReadOnlyDictionary<OFCFDCLHNFE, (IJOGBJOFPED<AFJOOIBLMOP>, IJOGBJOFPED<HOJGFCBIPIJ>)>));
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x26501F0", Offset = "0x264F5F0", VA = "0x1826501F0", Slot = "44")]
	[AsyncStateMachine(typeof(KGNCPPELMDG))]
	public Task JMDIMCJNJFN(HNEIHDEKOKM<IIPIDDOCOEJ> MFJBHLMAMOL, HNEIHDEKOKM<EICBKBBFNCN> CIMGPOKLJHF, IReadOnlyList<HNEIHDEKOKM<EICBKBBFNCN>> ALLAPEOLBDH, IReadOnlyDictionary<KAOGONDBLJA, (IJOGBJOFPED<AFJOOIBLMOP>, IJOGBJOFPED<LIGOHIGOKPO>)> LFDBJAGINHF, IReadOnlyDictionary<OFCFDCLHNFE, (IJOGBJOFPED<AFJOOIBLMOP>, IJOGBJOFPED<HOJGFCBIPIJ>)> NHGAFEIELKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x2651820", Offset = "0x2650C20", VA = "0x182651820", Slot = "47")]
	public bool MGLAECOAHID(IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x2651BF0", Offset = "0x2650FF0", VA = "0x182651BF0", Slot = "48")]
	public bool NBJCLJIOBBP(IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<KHMKGBDANIH> DGBNICFCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x264F710", Offset = "0x264EB10", VA = "0x18264F710", Slot = "49")]
	public bool GMGLNEAOFHD(IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<DIEOFHIAEHN> MPJFFADFMPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x264F510", Offset = "0x264E910", VA = "0x18264F510")]
	public KGPHFOFOMPJ<FKHMMAMFILM.PMBHLFNPHPH, IFNDEKFLNMG> GIPJJHFMBLE([In] FKHMMAMFILM.BGLPDBGFIPI BPKDFLJLPAA)
	{
		return default(KGPHFOFOMPJ<FKHMMAMFILM.PMBHLFNPHPH, IFNDEKFLNMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x2650340", Offset = "0x264F740", VA = "0x182650340", Slot = "51")]
	[AsyncStateMachine(typeof(CKNGBPKGKNI))]
	public Task<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> KBDCJGNAGKC(IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<DIEOFHIAEHN> NOOHCNGJKGB, IJOGBJOFPED<KHMKGBDANIH> CINNJNFNKEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x264DA00", Offset = "0x264CE00", VA = "0x18264DA00", Slot = "52")]
	public KGPHFOFOMPJ<JDHIEHCNMNI, ALOCPDILHNE> DEEPHKBPNMC(HNEIHDEKOKM<IIPIDDOCOEJ> MIFALNLOHHH, JDHIEHCNMNI LBIIFNOCIGP, NJLBLADHJBH GLNPDLMGIAG)
	{
		return default(KGPHFOFOMPJ<JDHIEHCNMNI, ALOCPDILHNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x264F3B0", Offset = "0x264E7B0", VA = "0x18264F3B0", Slot = "53")]
	[AsyncStateMachine(typeof(DFPFCHEOKOP))]
	public Task<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> GELEFFGKIEL(HNEIHDEKOKM<IIPIDDOCOEJ> MIFALNLOHHH, HNEIHDEKOKM<EICBKBBFNCN> LBNKGNEFANM, IJOGBJOFPED<AFJOOIBLMOP> OHHHAKJIGPN, IJOGBJOFPED<LIGOHIGOKPO> DGBNICFCJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x2651CF0", Offset = "0x26510F0", VA = "0x182651CF0", Slot = "54")]
	[AsyncStateMachine(typeof(LNDECAINJNL))]
	public Task<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> NFMJCMNOGDE(HNEIHDEKOKM<IIPIDDOCOEJ> MIFALNLOHHH, HNEIHDEKOKM<EICBKBBFNCN> MBDECCMKNAF, IJOGBJOFPED<AFJOOIBLMOP> AJECENADALG, IJOGBJOFPED<HOJGFCBIPIJ> MPJFFADFMPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x264F160", Offset = "0x264E560", VA = "0x18264F160", Slot = "55")]
	public CBOJNEAJALB EIPCFGPMDKE()
	{
		return default(CBOJNEAJALB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x2650C30", Offset = "0x2650030", VA = "0x182650C30", Slot = "56")]
	public CBOJNEAJALB LNMJLMCDCAD()
	{
		return default(CBOJNEAJALB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x2650470", Offset = "0x264F870", VA = "0x182650470", Slot = "58")]
	public IJPHCAIAHDJ KGOGHFBOING(PMPPGEHDHDG JDEGECKGDDI, IJOGBJOFPED<IIPIDDOCOEJ> KDPCJIDKAOJ, IEnumerable<HNEIHDEKOKM<IIPIDDOCOEJ>> NJLIBEJHKFE, IEnumerable<HNEIHDEKOKM<EICBKBBFNCN>> ABOLAIFBOMD, ISet<HNEIHDEKOKM<JAAKNCCKNAM>>? BJBHPLFFNFA)
	{
		return default(IJPHCAIAHDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x264F550", Offset = "0x264E950", VA = "0x18264F550")]
	private IJPHCAIAHDJ GKHHJODPOAI(PMPPGEHDHDG JDEGECKGDDI, IJOGBJOFPED<IIPIDDOCOEJ> KDPCJIDKAOJ, IEnumerable<HNEIHDEKOKM<IIPIDDOCOEJ>> NJLIBEJHKFE, IEnumerable<HNEIHDEKOKM<EICBKBBFNCN>> ABOLAIFBOMD, ISet<HNEIHDEKOKM<JAAKNCCKNAM>>? BJBHPLFFNFA)
	{
		return default(IJPHCAIAHDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x26518F0", Offset = "0x2650CF0", VA = "0x1826518F0", Slot = "57")]
	public IJPHCAIAHDJ MIGIOILLHDM(PMPPGEHDHDG JDEGECKGDDI, IJOGBJOFPED<IIPIDDOCOEJ> KDPCJIDKAOJ, IEnumerable<HNEIHDEKOKM<EICBKBBFNCN>> ABOLAIFBOMD, IEnumerable<AJANKEAEBKF> PPELGBEJKKO, ISet<HNEIHDEKOKM<JAAKNCCKNAM>>? BJBHPLFFNFA)
	{
		return default(IJPHCAIAHDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x2650D50", Offset = "0x2650150", VA = "0x182650D50")]
	private static IEnumerable<HNEIHDEKOKM<IIPIDDOCOEJ>> LOKOOCHLFJE(IEnumerable<AJANKEAEBKF> PPELGBEJKKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x264EAA0", Offset = "0x264DEA0", VA = "0x18264EAA0")]
	private IEnumerable<HNEIHDEKOKM<EICBKBBFNCN>> DNDPEHDAGIA(IEnumerable<AJANKEAEBKF> PPELGBEJKKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x2651E50", Offset = "0x2651250", VA = "0x182651E50", Slot = "59")]
	public List<IFIMKCNEAHA> NLFBCECALFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x264D340", Offset = "0x264C740", VA = "0x18264D340")]
	public (List<IFIMKCNEAHA>, bool) COCEHFFPGMF([In] NEJFHCIFDID PDMEBPCLLDB, string PCJJKLDOJMD, [In] LAAPMGPPMJD HINLBBBPCJD, MGOOOOAJJCE PJEDPLNFEIH, LPNEEAJFIMJ AKBEGJPNAAM)
	{
		return default((List<IFIMKCNEAHA>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x264D250", Offset = "0x264C650", VA = "0x18264D250", Slot = "61")]
	public bool CKKHKHGOEEC(IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x26510D0", Offset = "0x26504D0", VA = "0x1826510D0")]
	internal void MACBHMMCCGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x2650760", Offset = "0x264FB60", VA = "0x182650760")]
	internal Task KPDKMAAHCGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x264C2C0", Offset = "0x264B6C0", VA = "0x18264C2C0", Slot = "62")]
	public KGPHFOFOMPJ<IJOGBJOFPED<DIEOFHIAEHN>?, HEGOEPNOLEN> BAPLOFLHJNM(IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK, IJOGBJOFPED<KHMKGBDANIH> DGBNICFCJPK)
	{
		return default(KGPHFOFOMPJ<IJOGBJOFPED<DIEOFHIAEHN>?, HEGOEPNOLEN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x264E0D0", Offset = "0x264D4D0", VA = "0x18264E0D0", Slot = "63")]
	public KGPHFOFOMPJ<IJOGBJOFPED<KHMKGBDANIH>?, HEGOEPNOLEN> DMEKFKADGDP(IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK, IJOGBJOFPED<DIEOFHIAEHN> MPJFFADFMPN)
	{
		return default(KGPHFOFOMPJ<IJOGBJOFPED<KHMKGBDANIH>?, HEGOEPNOLEN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x264EF40", Offset = "0x264E340", VA = "0x18264EF40", Slot = "64")]
	[AsyncStateMachine(typeof(JPPLNDJBIDH))]
	public Task<KGPHFOFOMPJ<LPCAMBCOBBH, HEGOEPNOLEN>> EAOCFKLEDHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x264F540", Offset = "0x264E940", VA = "0x18264F540", Slot = "7")]
	private bool GJBBIIFGJLP(IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, [In] GAPALAEOGHH BHOOGELKBIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x26506C0", Offset = "0x264FAC0", VA = "0x1826506C0", Slot = "18")]
	private LPCHFMKMBHL MIACJFOPNNG([In] HNEIHDEKOKM<IIPIDDOCOEJ> MIFALNLOHHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x264F280", Offset = "0x264E680", VA = "0x18264F280", Slot = "19")]
	private IJOGBJOFPED<IIPIDDOCOEJ> EOEBAOGLMDB([In] HNEIHDEKOKM<IIPIDDOCOEJ> MIFALNLOHHH)
	{
		return default(IJOGBJOFPED<IIPIDDOCOEJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x264CF90", Offset = "0x264C390", VA = "0x18264CF90", Slot = "20")]
	private IJOGBJOFPED<IIPIDDOCOEJ>? IDKJHAALFFF([In] HNEIHDEKOKM<IIPIDDOCOEJ> MIFALNLOHHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x264FF30", Offset = "0x264F330", VA = "0x18264FF30", Slot = "22")]
	private BINALJFGGNF IHDIKDBFILF([In] HNEIHDEKOKM<EICBKBBFNCN> CCBIHMLAAKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x264D150", Offset = "0x264C550", VA = "0x18264D150", Slot = "24")]
	private IJOGBJOFPED<EICBKBBFNCN> CFAFHBLPCHL(IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, [In] HNEIHDEKOKM<EICBKBBFNCN> IMJNKJFOHDC)
	{
		return default(IJOGBJOFPED<EICBKBBFNCN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x264BB70", Offset = "0x264AF70", VA = "0x18264BB70", Slot = "38")]
	private FEBHGHLDFDK AJDIKPFIECO(IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, [In] GAPALAEOGHH BHOOGELKBIM)
	{
		return default(FEBHGHLDFDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x264F510", Offset = "0x264E910", VA = "0x18264F510", Slot = "50")]
	private KGPHFOFOMPJ<FKHMMAMFILM.PMBHLFNPHPH, IFNDEKFLNMG> MHEHHMGOFNB([In] FKHMMAMFILM.BGLPDBGFIPI BPKDFLJLPAA)
	{
		return default(KGPHFOFOMPJ<FKHMMAMFILM.PMBHLFNPHPH, IFNDEKFLNMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x2651890", Offset = "0x2650C90", VA = "0x182651890", Slot = "60")]
	private (List<IFIMKCNEAHA>, bool) MICAKNLNMLN([In] NEJFHCIFDID PDMEBPCLLDB, string PCJJKLDOJMD, [In] LAAPMGPPMJD HINLBBBPCJD, MGOOOOAJJCE PJEDPLNFEIH, LPNEEAJFIMJ AKBEGJPNAAM)
	{
		return default((List<IFIMKCNEAHA>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x26507C0", Offset = "0x264FBC0", VA = "0x1826507C0")]
	[CompilerGenerated]
	private MFILNHOKGFE LJPLMBDCILH(LEHFODJABPJ JKHIIFLAPEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x264F790", Offset = "0x264EB90", VA = "0x18264F790")]
	[CompilerGenerated]
	private BCCBPIEBIKF GNDJPBDEILP(HNEIHDEKOKM<EICBKBBFNCN> JKHIIFLAPEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x26528D0", Offset = "0x2651CD0", VA = "0x1826528D0")]
	[CompilerGenerated]
	private HIOKFJEHHDO PNMAHEFIGBM(HNEIHDEKOKM<IIPIDDOCOEJ> JKHIIFLAPEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x2650650", Offset = "0x264FA50", VA = "0x182650650")]
	[CompilerGenerated]
	private BCCBPIEBIKF KHHCOGIAKMJ(HNEIHDEKOKM<EICBKBBFNCN> JKHIIFLAPEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x264BE80", Offset = "0x264B280", VA = "0x18264BE80")]
	[CompilerGenerated]
	private HIOKFJEHHDO ALDKIDIEHHH(HNEIHDEKOKM<IIPIDDOCOEJ> JKHIIFLAPEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class MFILNHOKGFE : EGMEIGIGMNI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private struct HJAKEPNNEIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<IJOGBJOFPED<DNIBKHBHLOO>, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public MFILNHOKGFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public HNEIHDEKOKM<IIPIDDOCOEJ> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public HNEIHDEKOKM<EICBKBBFNCN> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public IJOGBJOFPED<AFJOOIBLMOP> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private TaskAwaiter<KGPHFOFOMPJ<IJOGBJOFPED<DNIBKHBHLOO>, HEGOEPNOLEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x26675B0", Offset = "0x26669B0", VA = "0x1826675B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x2667830", Offset = "0x2666C30", VA = "0x182667830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private struct BHIHJIFKOGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<IJOGBJOFPED<AKEIPLNFNIN>, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public MFILNHOKGFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public HNEIHDEKOKM<IIPIDDOCOEJ> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public HNEIHDEKOKM<EICBKBBFNCN> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public IJOGBJOFPED<AFJOOIBLMOP> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private TaskAwaiter<KGPHFOFOMPJ<IJOGBJOFPED<AKEIPLNFNIN>, HEGOEPNOLEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x2665A10", Offset = "0x2664E10", VA = "0x182665A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x2665C90", Offset = "0x2665090", VA = "0x182665C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private readonly LEHFODJABPJ IBEGFJADPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private readonly ILBJIDDJFAI COBCJEJKOCA;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public TypeKey FAMPGOAOIPO
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0xB3D410", Offset = "0xB3C810", VA = "0x180B3D410", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public string KENMCLOAEHD
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x2669100", Offset = "0x2668500", VA = "0x182669100", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public LEHFODJABPJ PCBHHGJBGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x266B4B0", Offset = "0x266A8B0", VA = "0x18266B4B0")]
	public MFILNHOKGFE(LEHFODJABPJ LOEMMBCCJIB, ILBJIDDJFAI BMMNCLDOHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x266B340", Offset = "0x266A740", VA = "0x18266B340", Slot = "6")]
	[AsyncStateMachine(typeof(HJAKEPNNEIA))]
	public Task<KGPHFOFOMPJ<IJOGBJOFPED<DNIBKHBHLOO>, HEGOEPNOLEN>> FHEOFEGEAHB(HNEIHDEKOKM<IIPIDDOCOEJ> MIFALNLOHHH, HNEIHDEKOKM<EICBKBBFNCN> CCBIHMLAAKK, IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI, string IGEPDAOOLBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x266B1D0", Offset = "0x266A5D0", VA = "0x18266B1D0", Slot = "7")]
	[AsyncStateMachine(typeof(BHIHJIFKOGI))]
	public Task<KGPHFOFOMPJ<IJOGBJOFPED<AKEIPLNFNIN>, HEGOEPNOLEN>> EHICPAGIMKO(HNEIHDEKOKM<IIPIDDOCOEJ> MIFALNLOHHH, HNEIHDEKOKM<EICBKBBFNCN> CCBIHMLAAKK, IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI, string IGEPDAOOLBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class LELIFDBOLAG : AOCGGNLDEBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private readonly LEHFODJABPJ FOBLOMCENPC;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private static readonly HashSet<LEHFODJABPJ> IIAGJEJBBHP;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private static readonly HashSet<LEHFODJABPJ> CDFLIBOJCDC;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	private static readonly HashSet<LEHFODJABPJ> JIPADILBINB;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public TypeKey KKGMNHPHOBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x266A3C0", Offset = "0x26697C0", VA = "0x18266A3C0", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool JELMBPKGJOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x266A3B0", Offset = "0x26697B0", VA = "0x18266A3B0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool OPHHKFOOGHL
	{
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x266A410", Offset = "0x2669810", VA = "0x18266A410", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool CNLJNECAIHB
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x266A330", Offset = "0x2669730", VA = "0x18266A330", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x2668D00", Offset = "0x2668100", VA = "0x182668D00")]
	public bool JALKMOIONFF(string FFOEEMKIKJO, [Out] ACMHMPCOCEF ENAHKCAGJKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x9B2970", Offset = "0x9B1D70", VA = "0x1809B2970")]
	public LELIFDBOLAG(LEHFODJABPJ BGCEKLPNCIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x2668F70", Offset = "0x2668370", VA = "0x182668F70")]
	internal static TypeKey PBDFAIOMCHA(LEHFODJABPJ HAFNBBNOLPO)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x2669100", Offset = "0x2668500", VA = "0x182669100", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public readonly struct IDIBILMNNII : BLPDKENIACC.MALNAOAIKGH<FCMLLGFOEBF, LPCAMBCOBBH>
{
	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x2667A50", Offset = "0x2666E50", VA = "0x182667A50", Slot = "4")]
	public int HFNJFKFGCOJ(LPCAMBCOBBH FKPHPPGPLLD, FCMLLGFOEBF IOPCFKOHPBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x2667AD0", Offset = "0x2666ED0", VA = "0x182667AD0", Slot = "5")]
	public FCMLLGFOEBF LGNAHAJBMJP(LPCAMBCOBBH FKPHPPGPLLD, FCMLLGFOEBF IOPCFKOHPBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x2667A70", Offset = "0x2666E70", VA = "0x182667A70", Slot = "6")]
	public FCMLLGFOEBF HPCPLLLCPAG(LPCAMBCOBBH FKPHPPGPLLD, FCMLLGFOEBF IOPCFKOHPBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x26679B0", Offset = "0x2666DB0", VA = "0x1826679B0", Slot = "7")]
	public IReadOnlyList<FCMLLGFOEBF> ACCLKFPKHBP(LPCAMBCOBBH FKPHPPGPLLD, FCMLLGFOEBF IOPCFKOHPBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x2667AC0", Offset = "0x2666EC0", VA = "0x182667AC0", Slot = "8")]
	public FCMLLGFOEBF[] JNFEKMMHBHO(LPCAMBCOBBH FKPHPPGPLLD, FCMLLGFOEBF IOPCFKOHPBF, int DAKBPMOHLBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x2667AA0", Offset = "0x2666EA0", VA = "0x182667AA0", Slot = "9")]
	public bool IMACMADCOJN(LPCAMBCOBBH FKPHPPGPLLD, FCMLLGFOEBF IOPCFKOHPBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x26679F0", Offset = "0x2666DF0", VA = "0x1826679F0", Slot = "10")]
	public bool EHBKMALFMJE(LPCAMBCOBBH FKPHPPGPLLD, FCMLLGFOEBF IOPCFKOHPBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x26679D0", Offset = "0x2666DD0", VA = "0x1826679D0", Slot = "11")]
	public bool DOHDGMFHEPN(LPCAMBCOBBH FKPHPPGPLLD, FCMLLGFOEBF IOPCFKOHPBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x2667AE0", Offset = "0x2666EE0", VA = "0x182667AE0", Slot = "12")]
	public bool LLBIAAGPGFD(LPCAMBCOBBH FKPHPPGPLLD, FCMLLGFOEBF IOPCFKOHPBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x2667A10", Offset = "0x2666E10", VA = "0x182667A10", Slot = "13")]
	public bool ELEOBBOHDDH(LPCAMBCOBBH LFCHBABPELB, FCMLLGFOEBF IOPCFKOHPBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x2667A30", Offset = "0x2666E30", VA = "0x182667A30", Slot = "14")]
	public bool GKEEKMFIBMG(LPCAMBCOBBH FKPHPPGPLLD, FCMLLGFOEBF IOPCFKOHPBF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public abstract class MNGLGMKJIFI : ILKEOPJELCM
{
	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public AEMKHBLCFMH.HEIODONLACF IHMLBOBDKEH
	{
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x266B550", Offset = "0x266A950", VA = "0x18266B550", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public abstract JLEFPKJHFKH.DCJNAHIDFON CKCEDMNEIAI
	{
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public abstract PMKDFPMAACD.MKAKGJAKNPG ELHOBPGBAHG
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public abstract PHFLCIELONP.KEDDGHAKJLM PKILCJGBHPD
	{
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public KLOPJJFPPNK.OEAIGBPOPBO<HLGPJHLLHLK, FCMLLGFOEBF, PMKDFPMAACD> GPLIAFBCBJI
	{
		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x266B5A0", Offset = "0x266A9A0", VA = "0x18266B5A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public abstract OLBBMCFJDBM.MIMNCDNMBOB MKHNILOMCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public abstract DJODKJGKOCD GEJJGLMIFDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public abstract OLDBMBEFMDK PMCFOOHHPHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public abstract HHAHICNEGGE ILLBLNOGADL
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public abstract CLKIHOEIECH BKLIEICCPLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public abstract EBPKJEHHMPE OIINIEDANEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	protected MNGLGMKJIFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class DJLCAKNJBIM : KHJLPPCJJAN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[CompilerGenerated]
	private struct OAIFNCCEOBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<object, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public DJLCAKNJBIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public FCMLLGFOEBF action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private TaskAwaiter<KGPHFOFOMPJ<object, HEGOEPNOLEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x266B5F0", Offset = "0x266A9F0", VA = "0x18266B5F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x266B890", Offset = "0x266AC90", VA = "0x18266B890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private struct FJPHNOLHOEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<NMJFPHJOOOF, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public DJLCAKNJBIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public IReadOnlyList<FCMLLGFOEBF> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private TaskAwaiter<KGPHFOFOMPJ<object, HEGOEPNOLEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x2666FE0", Offset = "0x26663E0", VA = "0x182666FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x2667360", Offset = "0x2666760", VA = "0x182667360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	private readonly JKECMCHDNIJ JGILMOEKBKL;

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x9B2970", Offset = "0x9B1D70", VA = "0x1809B2970")]
	public DJLCAKNJBIM(JKECMCHDNIJ FLCBCFNKGNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x2666BD0", Offset = "0x2665FD0", VA = "0x182666BD0")]
	[AsyncStateMachine(typeof(OAIFNCCEOBI))]
	private Task<KGPHFOFOMPJ<object, HEGOEPNOLEN>> NKFEECKELMI(FCMLLGFOEBF IOPCFKOHPBF, bool FHAKEDFMMAB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x2666AA0", Offset = "0x2665EA0", VA = "0x182666AA0", Slot = "4")]
	[AsyncStateMachine(typeof(FJPHNOLHOEC))]
	public Task<KGPHFOFOMPJ<NMJFPHJOOOF, HEGOEPNOLEN>> JHMHEAAMIID(IReadOnlyList<FCMLLGFOEBF> NBIPNPJJADG, bool FHAKEDFMMAB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public struct JCPAANJCLNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400030B")]
	internal JPPHAFNKKAO<HMGBIKNIADJ, HNEIHDEKOKM<HMGBIKNIADJ.DMGEILLMCLF>, FCMLLGFOEBF, PBKHHIGENFA> FOBLOMCENPC;

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x262AC10", Offset = "0x262A010", VA = "0x18262AC10")]
	private JCPAANJCLNO([In] JPPHAFNKKAO<HMGBIKNIADJ, HNEIHDEKOKM<HMGBIKNIADJ.DMGEILLMCLF>, FCMLLGFOEBF, PBKHHIGENFA> IAKLCIGGMIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x2667E30", Offset = "0x2667230", VA = "0x182667E30")]
	public static JCPAANJCLNO HBLBJMFGHFK()
	{
		return default(JCPAANJCLNO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public static class BMKILEFGLOC
{
	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0xBDB660", Offset = "0xBDAA60", VA = "0x180BDB660")]
	public static JPPHAFNKKAO<HMGBIKNIADJ, HNEIHDEKOKM<HMGBIKNIADJ.DMGEILLMCLF>, FCMLLGFOEBF, PBKHHIGENFA> DOFCLJBEHDG(this JCPAANJCLNO JOCJBPPJMJJ)
	{
		return default(JPPHAFNKKAO<HMGBIKNIADJ, HNEIHDEKOKM<HMGBIKNIADJ.DMGEILLMCLF>, FCMLLGFOEBF, PBKHHIGENFA>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public struct PBKHHIGENFA : IHDKDPPJGOC.JCDJHCMIHCG<HMGBIKNIADJ, HNEIHDEKOKM<HMGBIKNIADJ.DMGEILLMCLF>, FCMLLGFOEBF>
{
	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x266B910", Offset = "0x266AD10", VA = "0x18266B910", Slot = "7")]
	public FCMLLGFOEBF FFEMOCBPAOD(HMGBIKNIADJ[] DMDJMOGKIMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0xFB97D0", Offset = "0xFB8BD0", VA = "0x180FB97D0")]
	public HNEIHDEKOKM<HMGBIKNIADJ.DMGEILLMCLF> IFGFNIEEFOB([In] HMGBIKNIADJ CAJLIMDCMCK)
	{
		return default(HNEIHDEKOKM<HMGBIKNIADJ.DMGEILLMCLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0xFD7600", Offset = "0xFD6A00", VA = "0x180FD7600")]
	public int FGCDMNNJGIP([In] HMGBIKNIADJ IKLIIHCLINL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x266B900", Offset = "0x266AD00", VA = "0x18266B900")]
	public int MFJKGNLENLL([In] HMGBIKNIADJ CAJLIMDCMCK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0xFD7600", Offset = "0xFD6A00", VA = "0x180FD7600", Slot = "4")]
	private int FIOPPNMNECG([In] HMGBIKNIADJ CAJLIMDCMCK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x266B900", Offset = "0x266AD00", VA = "0x18266B900", Slot = "5")]
	private int BALKFBAAAIB([In] HMGBIKNIADJ CAJLIMDCMCK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0xFB97D0", Offset = "0xFB8BD0", VA = "0x180FB97D0", Slot = "6")]
	private HNEIHDEKOKM<HMGBIKNIADJ.DMGEILLMCLF> ONDFKBFOAND([In] HMGBIKNIADJ CAJLIMDCMCK)
	{
		return default(HNEIHDEKOKM<HMGBIKNIADJ.DMGEILLMCLF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public struct CCEJNBKACKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	internal PMONINADFJH<HFHMMGMJMIM, FCMLLGFOEBF, GBIKJHOAOKE> FOBLOMCENPC;

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x262AC10", Offset = "0x262A010", VA = "0x18262AC10")]
	private CCEJNBKACKF([In] PMONINADFJH<HFHMMGMJMIM, FCMLLGFOEBF, GBIKJHOAOKE> BMAHMNEFFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x2665FB0", Offset = "0x26653B0", VA = "0x182665FB0")]
	public static CCEJNBKACKF HBLBJMFGHFK()
	{
		return default(CCEJNBKACKF);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public static class IAEELBCLPKG
{
	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0xBDB660", Offset = "0xBDAA60", VA = "0x180BDB660")]
	public static PMONINADFJH<HFHMMGMJMIM, FCMLLGFOEBF, GBIKJHOAOKE> DOFCLJBEHDG(this CCEJNBKACKF JOCJBPPJMJJ)
	{
		return default(PMONINADFJH<HFHMMGMJMIM, FCMLLGFOEBF, GBIKJHOAOKE>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public struct GBIKJHOAOKE : IGKIMLADGNK.JNBCFGFBPAP<HFHMMGMJMIM, FCMLLGFOEBF>
{
	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x2055A00", Offset = "0x2054E00", VA = "0x182055A00")]
	public int HBGADFGMKEB([In] HFHMMGMJMIM IKLIIHCLINL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x26673D0", Offset = "0x26667D0", VA = "0x1826673D0", Slot = "5")]
	public FCMLLGFOEBF OGFIEDCFBLB(HFHMMGMJMIM[] POJKCIPMBFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x2055A00", Offset = "0x2054E00", VA = "0x182055A00", Slot = "4")]
	private int FMFFGHPCLHB([In] HFHMMGMJMIM IKLIIHCLINL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public class JDGAEGPFMCF : ADGPAJEIFGP, IFNDEKFLNMG, HEGOEPNOLEN, ALOCPDILHNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	private readonly ALOCPDILHNE? GEACGBELIIN;

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public IFNIOLOKEFP KDGBOJEHLIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x9AE430", Offset = "0x9AD830", VA = "0x1809AE430", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(IFNIOLOKEFP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x9B51D0", Offset = "0x9B45D0", VA = "0x1809B51D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public override ALOCPDILHNE? JFBOFPIIHMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x9A91D0", Offset = "0x9A85D0", VA = "0x1809A91D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x2667F70", Offset = "0x2667370", VA = "0x182667F70", Slot = "7")]
	public override string JIBLDGHIHFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x2668100", Offset = "0x2667500", VA = "0x182668100")]
	private JDGAEGPFMCF(IFNIOLOKEFP AGBLNEPGFKF, ALOCPDILHNE? ODKEMFFPJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x2668080", Offset = "0x2667480", VA = "0x182668080")]
	public static JDGAEGPFMCF LLNNMBJCBDO(ALOCPDILHNE ODKEMFFPJCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x2667F00", Offset = "0x2667300", VA = "0x182667F00")]
	public static JDGAEGPFMCF DLFJLCINMJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x2667E90", Offset = "0x2667290", VA = "0x182667E90")]
	public static JDGAEGPFMCF BIDKFKIENDL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public static class CELJGOKPBJO
{
	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x33FD520", Offset = "0x33FC920", VA = "0x1833FD520")]
	public static KGPHFOFOMPJ<TOk, IFNDEKFLNMG> NMOJCDJIMOA<TOk>([In] this KGPHFOFOMPJ<TOk, IFNDEKFLNMG> JOCJBPPJMJJ, ALOCPDILHNE ODKEMFFPJCN) where TOk : notnull
	{
		return default(KGPHFOFOMPJ<TOk, IFNDEKFLNMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x33FD610", Offset = "0x33FCA10", VA = "0x1833FD610")]
	public static KGPHFOFOMPJ<TOk?, IFNDEKFLNMG?> PMFICHNPBEH<TOk>([In] this KGPHFOFOMPJ<TOk, IFNDEKFLNMG> JOCJBPPJMJJ)
	{
		return default(KGPHFOFOMPJ<TOk, IFNDEKFLNMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x33FD420", Offset = "0x33FC820", VA = "0x1833FD420")]
	public static KGPHFOFOMPJ<TOk?, IFNDEKFLNMG?> ICDALFKLGHD<TOk>([In] this KGPHFOFOMPJ<TOk, IFNDEKFLNMG> JOCJBPPJMJJ)
	{
		return default(KGPHFOFOMPJ<TOk, IFNDEKFLNMG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public interface DJODKJGKOCD
{
	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NMKPMPFIHMK([In] KGPHFOFOMPJ<LPCAMBCOBBH, ALOCPDILHNE> HBALBIOOGIJ);
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public static class HEICFBOLKCK
{
	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x3602F60", Offset = "0x3602360", VA = "0x183602F60")]
	public static bool NMKPMPFIHMK<TOk, TErr>(this DJODKJGKOCD JOCJBPPJMJJ, [In] KGPHFOFOMPJ<TOk, TErr> HBALBIOOGIJ) where TOk : notnull where TErr : notnull, ALOCPDILHNE
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public interface OLDBMBEFMDK
{
	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	EOEAKGLDJEO PFJHNDLNJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public interface HHAHICNEGGE
{
	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(Slot = "0")]
	INFMEKLNAKP PCCHOPBABJI(int MEABJLCPOGK);
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public interface LFGMNNDMJHB
{
	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	string KAFLMFCDNKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public interface JHOJPOCFOAP
{
	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JKCHHCGJDOG? NNJDDCAKGBL(IJOGBJOFPED<AFJOOIBLMOP> DOCCDCHJBLI);
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public interface PKHJBOBLCNJ
{
	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	string KAFLMFCDNKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public interface JKCHHCGJDOG
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	string KAFLMFCDNKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PKHJBOBLCNJ? LGIAKCHFACC(IJOGBJOFPED<DNIBKHBHLOO> LPLICMPKNLI);

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LFGMNNDMJHB? GMHMJHDJEAP(IJOGBJOFPED<AKEIPLNFNIN> JNOHLGFFMHD);
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public interface CLKIHOEIECH
{
	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> GMCOPEFDJHF(string FFOEEMKIKJO, string PCJJKLDOJMD);
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public interface EBPKJEHHMPE
{
	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JHOJPOCFOAP? EAMGLBJNHEJ([In] HNEIHDEKOKM<DJJIMCEGKJC> NJEIHJJJKHJ);
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public sealed class LIFDLDBGODB
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	private struct ICLPMLPCFID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public int FBMJOLKHIKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public LECJPJBNNBI? JOJNGGMBGKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public LECJPJBNNBI? JIFBNNEIHPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public readonly List<FCMLLGFOEBF> DLMCLEMAICI;

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x2667960", Offset = "0x2666D60", VA = "0x182667960")]
		private ICLPMLPCFID(int CJFNAFNJJLB, LECJPJBNNBI? PAOGOMANAOF, LECJPJBNNBI? GJNLADOGIPG, List<FCMLLGFOEBF> NBIPNPJJADG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x26678A0", Offset = "0x2666CA0", VA = "0x1826678A0")]
		public static ICLPMLPCFID HBLBJMFGHFK()
		{
			return default(ICLPMLPCFID);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	private readonly PIDCPBHOLKH<ICLPMLPCFID> GAPPMEKKBAE;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public static LIFDLDBGODB DNEPPKLGBFA
	{
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x266A930", Offset = "0x2669D30", VA = "0x18266A930")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public bool POMJMFNIBMP
	{
		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0xBEA690", Offset = "0xBE9A90", VA = "0x180BEA690")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0xBEA330", Offset = "0xBE9730", VA = "0x180BEA330")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x266A530", Offset = "0x2669930", VA = "0x18266A530")]
	public void CMADDMEGMNJ(IAENGEFPAJO GJNLADOGIPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x266A980", Offset = "0x2669D80", VA = "0x18266A980")]
	public void ONLJPLEDHDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x266A5F0", Offset = "0x26699F0", VA = "0x18266A5F0")]
	private static string? LCEHOMJFHGJ([In] ICLPMLPCFID BHJKIKBCANF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x266AD70", Offset = "0x266A170", VA = "0x18266AD70")]
	public LIFDLDBGODB()
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
