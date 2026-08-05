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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x27831A0", Offset = "0x27823A0", VA = "0x1827831A0")]
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
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
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
public sealed class BMLBDHHGCHG : IDisposable, FLPHGAHLGAL, IMPMJJPIDLP, IHLODMFNEKL, ILICIEKDOAA
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class ABCHIIPHNKA : KBJJDACHKGK
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int FOIHFHPMKDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2765700", Offset = "0x2764900", VA = "0x182765700", Slot = "5")]
		public EPPBIMKACJL HNCAGEJLIDG(HOFOMPIHPAL.FLHBAFDPOGO POLANHDJCNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void LPNMEFOOEFJ();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void LNGOLPHPCPM();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x275BAC0", Offset = "0x275ACC0", VA = "0x18275BAC0", Slot = "13")]
		public virtual void OGGCHBODIDN(BMLBDHHGCHG CCCBLIDEHDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2765850", Offset = "0x2764A50", VA = "0x182765850", Slot = "14")]
		public virtual void LOPHAEPMGAD(BMLBDHHGCHG CCCBLIDEHDI, AGKENLKLGLL HDKINMMJOHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		protected ABCHIIPHNKA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface KBJJDACHKGK
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int FOIHFHPMKDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "1")]
		EPPBIMKACJL HNCAGEJLIDG(HOFOMPIHPAL.FLHBAFDPOGO POLANHDJCNH);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LPNMEFOOEFJ();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LNGOLPHPCPM();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void OGGCHBODIDN(BMLBDHHGCHG CCCBLIDEHDI);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void LOPHAEPMGAD(BMLBDHHGCHG CCCBLIDEHDI, AGKENLKLGLL HDKINMMJOHF);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct DKKFLPMOPCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly PIDEKIBKJPO<CJEEPIILMHM, AGKENLKLGLL, BMLBDHHGCHG, BFFLPJPCMEL.LIIAMKACFFM<CJEEPIILMHM, AGKENLKLGLL, BMLBDHHGCHG>> KIJPEEFIAAH;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2774DF0", Offset = "0x2773FF0", VA = "0x182774DF0")]
		internal DKKFLPMOPCN(PIDEKIBKJPO<CJEEPIILMHM, AGKENLKLGLL, BMLBDHHGCHG, BFFLPJPCMEL.LIIAMKACFFM<CJEEPIILMHM, AGKENLKLGLL, BMLBDHHGCHG>> AHLPFPPNCPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class AHNOLHLEPOJ : BFFLPJPCMEL.LIIAMKACFFM<CJEEPIILMHM, AGKENLKLGLL, BMLBDHHGCHG>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly AHNOLHLEPOJ NDDGJHHDBNJ;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		private AHNOLHLEPOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xAE91F0", Offset = "0xAE83F0", VA = "0x180AE91F0", Slot = "4")]
		public CJEEPIILMHM PEACJLNAKNH(AGKENLKLGLL CEENCLMGJAM)
		{
			return default(CJEEPIILMHM);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2770C40", Offset = "0x276FE40", VA = "0x182770C40", Slot = "5")]
		public void OGGCHBODIDN(BMLBDHHGCHG FHPKLENNKKO, AGKENLKLGLL HDKINMMJOHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2770B30", Offset = "0x276FD30", VA = "0x182770B30", Slot = "6")]
		public void LOPHAEPMGAD(BMLBDHHGCHG FHPKLENNKKO, AGKENLKLGLL HDKINMMJOHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct LLJDFFNOEMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public DHOEAEODOAI<CJEEPIILMHM, AGKENLKLGLL, BMLBDHHGCHG, BFFLPJPCMEL.LIIAMKACFFM<CJEEPIILMHM, AGKENLKLGLL, BMLBDHHGCHG>> KIJPEEFIAAH;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2781BC0", Offset = "0x2780DC0", VA = "0x182781BC0")]
		internal LLJDFFNOEMD(DHOEAEODOAI<CJEEPIILMHM, AGKENLKLGLL, BMLBDHHGCHG, BFFLPJPCMEL.LIIAMKACFFM<CJEEPIILMHM, AGKENLKLGLL, BMLBDHHGCHG>> AHLPFPPNCPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2781B70", Offset = "0x2780D70", VA = "0x182781B70")]
		public static LLJDFFNOEMD OIKMHICCLEP()
		{
			return default(LLJDFFNOEMD);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct IBDBLDMBIIG : AMPKJOMLEIF.CAOPBFGGNPI<AGKENLKLGLL, BMLBDHHGCHG>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct OJLBMCKBBCJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<LOAMJJJEMNF<object?, PLLHOMFPAAM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public BMLBDHHGCHG receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public AGKENLKLGLL action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public IBDBLDMBIIG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<LOAMJJJEMNF<object?, PLLHOMFPAAM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x2783220", Offset = "0x2782420", VA = "0x182783220", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x2783400", Offset = "0x2782600", VA = "0x182783400", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA6FFF0", Offset = "0xA6F1F0", VA = "0x180A6FFF0", Slot = "4")]
		public JFIBBLJIDCN<MCGHCCOIFPD> GDBLCAEKMIG(BMLBDHHGCHG IJKONPKDHEA)
		{
			return default(JFIBBLJIDCN<MCGHCCOIFPD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x27785F0", Offset = "0x27777F0", VA = "0x1827785F0", Slot = "5")]
		public void LMBCJFLDDBG(BMLBDHHGCHG IJKONPKDHEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x27784A0", Offset = "0x27776A0", VA = "0x1827784A0", Slot = "6")]
		[AsyncStateMachine(typeof(OJLBMCKBBCJ))]
		public Task<LOAMJJJEMNF<object, PLLHOMFPAAM>> BHMCMMFFJBJ(BMLBDHHGCHG IJKONPKDHEA, AGKENLKLGLL HDKINMMJOHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x27785D0", Offset = "0x27777D0", VA = "0x1827785D0", Slot = "7")]
		public AGKENLKLGLL[] KLDJJKBOMIH(BMLBDHHGCHG IJKONPKDHEA)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct GELGAGDAHAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<bool, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public BMLBDHHGCHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<LOAMJJJEMNF<bool, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2776E50", Offset = "0x2776050", VA = "0x182776E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x27770E0", Offset = "0x27762E0", VA = "0x1827770E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct DBOLDGOFCJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public BMLBDHHGCHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x27744F0", Offset = "0x27736F0", VA = "0x1827744F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x27746D0", Offset = "0x27738D0", VA = "0x1827746D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct BCAPPEGJLKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<object?, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public BMLBDHHGCHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AGKENLKLGLL action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<LOAMJJJEMNF<object?, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2771EF0", Offset = "0x27710F0", VA = "0x182771EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x27720E0", Offset = "0x27712E0", VA = "0x1827720E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly JFIBBLJIDCN<MCGHCCOIFPD> HGMOMNKHGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly DKKFLPMOPCN KFNGMLAEEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FDEGBPEFIAI FDDNGPBHCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly NIEIAPJEPLL OJBKFLAKEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B80")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly IAACJJOGHIC OPKIAJCANOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B88")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly KFOPAHDCEKH.OEJIMBCOPME GFEEPEGHOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BB0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly KAMJDMDLOAC BPNCBKKJCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BB8")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly MPBMCLBPAHA MIOADPJKFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BC0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly LGPAPENJAOP EMBGGENHEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BC8")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly CHAIPFACECL ELOJLAICNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BD0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private NOJIJMINLNJ BGICKFAMNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BE0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private LALBPBGHDCK FNIHKCDHDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C00")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly FDEGBPEFIAI.IAAGFBJAHNI BPLODKNPKGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C08")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly GNIGMIGAFND LCKOFABNMDE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public FDEGBPEFIAI MEMJAOOBBMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x27733E0", Offset = "0x27725E0", VA = "0x1827733E0")]
		get
		{
			return default(FDEGBPEFIAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal KBJJDACHKGK DMKIJAMFLKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2773390", Offset = "0x2772590", VA = "0x182773390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal EPPBIMKACJL ONBHMOEMJEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2773840", Offset = "0x2772A40", VA = "0x182773840")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2772840", Offset = "0x2771A40", VA = "0x182772840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool LKNDAINDJKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x27727B0", Offset = "0x27719B0", VA = "0x1827727B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x27724C0", Offset = "0x27716C0", VA = "0x1827724C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public MNOMGFJJPJB DMOCGBOEBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2773C60", Offset = "0x2772E60", VA = "0x182773C60", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public AMCDLJABINE GIOOEPFJALL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2773C70", Offset = "0x2772E70", VA = "0x182773C70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public LCNLBPCCDOL MGEFCBJDMHF
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2773C90", Offset = "0x2772E90", VA = "0x182773C90", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public ILCGECNILOJ GBNELHNAEML
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2773C80", Offset = "0x2772E80", VA = "0x182773C80", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public KFOPAHDCEKH? HHPJLCPBLFA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2773310", Offset = "0x2772510", VA = "0x182773310", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private FAMLAPLNGCO? CJLFACBKAEH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x27731E0", Offset = "0x27723E0", VA = "0x1827731E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2773960", Offset = "0x2772B60", VA = "0x182773960")]
	private BMLBDHHGCHG(IAACJJOGHIC GBEOAHCNHMI, JFIBBLJIDCN<MCGHCCOIFPD> NAJOEFDLOFP, [In] DKKFLPMOPCN CJOBEMGADGC, [In] FDEGBPEFIAI MLEKLFHJDLD, [In] NIEIAPJEPLL PIMOMFAIKEE, EPPBIMKACJL EMIEKNEJODH, [In] KFOPAHDCEKH.OEJIMBCOPME NPLONAKKBBO, FDEGBPEFIAI.IAAGFBJAHNI HNLDOOOKECJ, GNIGMIGAFND HJKOEPBJMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2773700", Offset = "0x2772900", VA = "0x182773700")]
	public static BMLBDHHGCHG OIKMHICCLEP(IAACJJOGHIC POLANHDJCNH, [In] BNOGCCPDFAK OGHGEHKLBHD, BANLJENLAGL EDKDALGHJFC, [In] LLHOGHIKFPH OLMFMFOFDIO, JKNHGMDHCCA PAPENPNANPO, JFIBBLJIDCN<MCGHCCOIFPD> NAJOEFDLOFP, JFIBBLJIDCN<OHNBELMDHEJ> FPCKMGFCIFG, FILIDBMOPNM LJPGHHICBDP, MKDJFCPHBKP GPPMGLIGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x27733F0", Offset = "0x27725F0", VA = "0x1827733F0")]
	public static BMLBDHHGCHG OIKMHICCLEP(IAACJJOGHIC GBEOAHCNHMI, [In] FDEGBPEFIAI MLEKLFHJDLD, [In] NIEIAPJEPLL PIMOMFAIKEE, JFIBBLJIDCN<MCGHCCOIFPD> NAJOEFDLOFP, JFIBBLJIDCN<OHNBELMDHEJ> FPCKMGFCIFG, FILIDBMOPNM LJPGHHICBDP, MKDJFCPHBKP GPPMGLIGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x27724D0", Offset = "0x27716D0", VA = "0x1827724D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x27726C0", Offset = "0x27718C0", VA = "0x1827726C0")]
	[AsyncStateMachine(typeof(GELGAGDAHAP))]
	public Task<LOAMJJJEMNF<bool, PLLHOMFPAAM>> GFJJIHLBMMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2773030", Offset = "0x2772230", VA = "0x182773030")]
	[AsyncStateMachine(typeof(DBOLDGOFCJL))]
	public Task<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> LJELAKCCNBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2772C90", Offset = "0x2771E90", VA = "0x182772C90")]
	internal void LEBHGFKJANP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x27727C0", Offset = "0x27719C0", VA = "0x1827727C0")]
	internal CJILJFGJKPL<AGKENLKLGLL> HDNLLKNJKGP([In] EGHBLGJNGKE LAIKJMPBOCF)
	{
		return default(CJILJFGJKPL<AGKENLKLGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2773170", Offset = "0x2772370", VA = "0x182773170")]
	internal bool MJJEFPJAPBC([In] EGHBLGJNGKE LAIKJMPBOCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2772EA0", Offset = "0x27720A0", VA = "0x182772EA0")]
	internal LOAMJJJEMNF<AGKENLKLGLL, PLLHOMFPAAM> LHFIHGMPJME([In] MLFAKCKOFLP HLMOEKKOGJF)
	{
		return default(LOAMJJJEMNF<AGKENLKLGLL, PLLHOMFPAAM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2773120", Offset = "0x2772320", VA = "0x182773120")]
	private void LMBCJFLDDBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2773850", Offset = "0x2772A50", VA = "0x182773850")]
	[AsyncStateMachine(typeof(BCAPPEGJLKI))]
	internal Task<LOAMJJJEMNF<object, PLLHOMFPAAM>> PDCFBAPJHPO(AGKENLKLGLL HDKINMMJOHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2772860", Offset = "0x2771A60", VA = "0x182772860")]
	private AGKENLKLGLL[] KLDJJKBOMIH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class DGNBFCCPGJD<TData> : DKPIACPJNCE, PGENCONCFGB, GEFBDEPLDON where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly NICODLFMDAJ<PKEJDDGKOJK>? ANJJAILPPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly string FIKKCGNKHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly TData ALBEJFPMKJB;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NICODLFMDAJ<PKEJDDGKOJK>? LMBAKAIBHDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x29FE530", Offset = "0x29FD730", VA = "0x1829FE530", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x9F6D90", Offset = "0x9F5F90", VA = "0x1809F6D90", Slot = "7")]
	public override string JOOGKGIFDEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6A21700", Offset = "0x6A20900", VA = "0x186A21700")]
	internal DGNBFCCPGJD([In] NICODLFMDAJ<PKEJDDGKOJK>? HOHPIHEDFGO, JFIBBLJIDCN<GOJKLMIIDHM>? KBDPFGINDJG, IOKind? AGKKNLAOHCD, string BDAAPBJEHGD, [In] TData DHAOEHNLNON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class FOCPBKOALPM
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2776780", Offset = "0x2775980", VA = "0x182776780")]
	public static LOAMJJJEMNF<EBJLFCJJLKE, PGENCONCFGB> KEMNNJMCHBN([In] this JMBKPLPJPML<DCPNOKINCKK> IICEMJDMKLG)
	{
		return default(LOAMJJJEMNF<EBJLFCJJLKE, PGENCONCFGB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3807C50", Offset = "0x3806E50", VA = "0x183807C50")]
	public static LOAMJJJEMNF<TOk, PGENCONCFGB> PKLFJAHMGOI<TOk>([In] this LOAMJJJEMNF<TOk, PGENCONCFGB> CEENCLMGJAM, [In] NICODLFMDAJ<PKEJDDGKOJK>? HOHPIHEDFGO, JFIBBLJIDCN<GOJKLMIIDHM>? KBDPFGINDJG, IOKind? AGKKNLAOHCD, string BDAAPBJEHGD) where TOk : notnull
	{
		return default(LOAMJJJEMNF<TOk, PGENCONCFGB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface IAACJJOGHIC
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	BPNIFDODBBN.AJKKABFCNJF LGHEPIFBAAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	HOFOMPIHPAL.FLHBAFDPOGO EIFIHAMJPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	BMLBDHHGCHG.KBJJDACHKGK FHCJFNBMJAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	KAMDFIOBPJP.BEPILBLDDEM MLINHMHPLBH
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	BFFLPJPCMEL.LIIAMKACFFM<CJEEPIILMHM, AGKENLKLGLL, BMLBDHHGCHG> OLAHPJMDOFF
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	CJDMGLKDALO.DNLPOCEMLNC AJGNMINGMGM
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	LAMDCDECGNG HNDGHLFBEFP
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	JINBEMABBNE AIJKJOCPIBI
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	NBFCEHFCGPE KIEEMLABNBC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	JDPILMMJHIO CPCPNHEGAFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	HCFBIPPLEMC ELHEOMJCNGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class ADGMPPCPIBF
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x27659A0", Offset = "0x2764BA0", VA = "0x1827659A0")]
	public static AGKENLKLGLL JPIFELPOGPJ(this AGKENLKLGLL CEENCLMGJAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x27658D0", Offset = "0x2764AD0", VA = "0x1827658D0")]
	public static AGKENLKLGLL ALGGCGCIAEC(this BFOHNGHBHJJ CEENCLMGJAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct BFOHNGHBHJJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct HBFBFMPJPFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<object?, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public BMLBDHHGCHG root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public BFOHNGHBHJJ self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<LOAMJJJEMNF<object?, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2777150", Offset = "0x2776350", VA = "0x182777150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2777410", Offset = "0x2776610", VA = "0x182777410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly ByteString ABLHJAOAOGP;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xD42160", Offset = "0xD41360", VA = "0x180D42160")]
	private BFOHNGHBHJJ(ByteString MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x27722F0", Offset = "0x27714F0", VA = "0x1827722F0")]
	public static AGKENLKLGLL HMENNHMOPGM(ByteString MLCDCHNOCFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2772240", Offset = "0x2771440", VA = "0x182772240")]
	public static FLDEEDHJIKG<CJEEPIILMHM, BFOHNGHBHJJ> DKMDNOBFIEL(AGKENLKLGLL NJCMLDAIPDB)
	{
		return default(FLDEEDHJIKG<CJEEPIILMHM, BFOHNGHBHJJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x27723B0", Offset = "0x27715B0", VA = "0x1827723B0")]
	[AsyncStateMachine(typeof(HBFBFMPJPFF))]
	public static Task<LOAMJJJEMNF<object, PLLHOMFPAAM>> PDCFBAPJHPO(BMLBDHHGCHG FHPKLENNKKO, BFOHNGHBHJJ CEENCLMGJAM)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct BODANMHPPAI
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2773D10", Offset = "0x2772F10", VA = "0x182773D10")]
	public static AGKENLKLGLL HMENNHMOPGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2773CA0", Offset = "0x2772EA0", VA = "0x182773CA0")]
	public static FLDEEDHJIKG<CJEEPIILMHM, BODANMHPPAI> DKMDNOBFIEL(AGKENLKLGLL NJCMLDAIPDB)
	{
		return default(FLDEEDHJIKG<CJEEPIILMHM, BODANMHPPAI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2773DB0", Offset = "0x2772FB0", VA = "0x182773DB0")]
	public static LOAMJJJEMNF<GKPOGNMPJHG, BHGOBKJBFOA> KHFEAELDEDF(BMLBDHHGCHG FHPKLENNKKO, [In] BODANMHPPAI CEENCLMGJAM)
	{
		return default(LOAMJJJEMNF<GKPOGNMPJHG, BHGOBKJBFOA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct KEIDJPLOKJO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct JDMLDNDMLPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<GKPOGNMPJHG, BHGOBKJBFOA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public BMLBDHHGCHG root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public KEIDJPLOKJO self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private LOAMJJJEMNF<GKPOGNMPJHG, BHGOBKJBFOA> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2779E40", Offset = "0x2779040", VA = "0x182779E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x277A400", Offset = "0x2779600", VA = "0x18277A400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly NHNBDDEEFPH? AILAECKEPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly HBBBCDHABCG? MKMAJNEOCLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly HAPGMLIDNII? IHNDBMIDBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly JLFEKJLHFFI? KGOEEGELOGN;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x21B1A90", Offset = "0x21B0C90", VA = "0x1821B1A90")]
	private KEIDJPLOKJO(NHNBDDEEFPH? JLIIGFHECCJ, HBBBCDHABCG? KGABJAIKBPB, HAPGMLIDNII? ALDFCBINAND, JLFEKJLHFFI? IHGNMLHENCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x277C620", Offset = "0x277B820", VA = "0x18277C620")]
	public static AGKENLKLGLL? HMENNHMOPGM(NHNBDDEEFPH? JLIIGFHECCJ, HBBBCDHABCG? KGABJAIKBPB, HAPGMLIDNII? ALDFCBINAND, JLFEKJLHFFI? IHGNMLHENCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x277C4D0", Offset = "0x277B6D0", VA = "0x18277C4D0")]
	public static FLDEEDHJIKG<CJEEPIILMHM, KEIDJPLOKJO> DKMDNOBFIEL(AGKENLKLGLL NJCMLDAIPDB)
	{
		return default(FLDEEDHJIKG<CJEEPIILMHM, KEIDJPLOKJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x277C730", Offset = "0x277B930", VA = "0x18277C730")]
	[AsyncStateMachine(typeof(JDMLDNDMLPE))]
	public static Task<LOAMJJJEMNF<GKPOGNMPJHG, BHGOBKJBFOA>> PDCFBAPJHPO(BMLBDHHGCHG FHPKLENNKKO, KEIDJPLOKJO CEENCLMGJAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct KFAIKDHNHNE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct KMPOCBDKHNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<MKMBMMHDKHK, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KFAIKDHNHNE self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public BMLBDHHGCHG root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private LOAMJJJEMNF<MKMBMMHDKHK, PLLHOMFPAAM> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private LOAMJJJEMNF<object?, GEFBDEPLDON>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private LOAMJJJEMNF<object?, GEFBDEPLDON> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private LOAMJJJEMNF<object?, GEFBDEPLDON>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter<LOAMJJJEMNF<object?, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x277D0B0", Offset = "0x277C2B0", VA = "0x18277D0B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x277D510", Offset = "0x277C710", VA = "0x18277D510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly IReadOnlyList<AGKENLKLGLL> HLPDLDEIALC;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xD42160", Offset = "0xD41360", VA = "0x180D42160")]
	private KFAIKDHNHNE(IReadOnlyList<AGKENLKLGLL> EPMMAHCPFOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x277C910", Offset = "0x277BB10", VA = "0x18277C910")]
	public static AGKENLKLGLL HMENNHMOPGM(IReadOnlyList<AGKENLKLGLL> EPMMAHCPFOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x277C870", Offset = "0x277BA70", VA = "0x18277C870")]
	public static FLDEEDHJIKG<CJEEPIILMHM, KFAIKDHNHNE> DKMDNOBFIEL(AGKENLKLGLL NJCMLDAIPDB)
	{
		return default(FLDEEDHJIKG<CJEEPIILMHM, KFAIKDHNHNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x277C9D0", Offset = "0x277BBD0", VA = "0x18277C9D0")]
	[AsyncStateMachine(typeof(KMPOCBDKHNM))]
	public static Task<LOAMJJJEMNF<MKMBMMHDKHK, PLLHOMFPAAM>> PDCFBAPJHPO(BMLBDHHGCHG FHPKLENNKKO, KFAIKDHNHNE CEENCLMGJAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct MLFAKCKOFLP
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class EKLOAHCJDCD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class KPGAKPCGFIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public NICODLFMDAJ<EKLOAHCJDCD> actionId;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public KPGAKPCGFIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x277D930", Offset = "0x277CB30", VA = "0x18277D930")]
		internal AGKENLKLGLL EJBBLJPLAHD(int count, int index, [In] ReadOnlySpan<byte> span)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly NICODLFMDAJ<EKLOAHCJDCD> GBJBCFAPBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly int FAGABNHAKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly int PMLOAHGMFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly byte[] ALBEJFPMKJB;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2782DB0", Offset = "0x2781FB0", VA = "0x182782DB0")]
	private MLFAKCKOFLP(NICODLFMDAJ<EKLOAHCJDCD> EHCGEEBBLCC, int KIFHGDECLNI, int NIBICIJAIGM, byte[] DHAOEHNLNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2782A00", Offset = "0x2781C00", VA = "0x182782A00")]
	public static AGKENLKLGLL HMENNHMOPGM(NICODLFMDAJ<EKLOAHCJDCD> EHCGEEBBLCC, int KIFHGDECLNI, int NIBICIJAIGM, ByteString DHAOEHNLNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2782B10", Offset = "0x2781D10", VA = "0x182782B10")]
	public static AGKENLKLGLL[] IDIDKFJNLII(AGKENLKLGLL HDKINMMJOHF, int HLFPNHOFPMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x27828B0", Offset = "0x2781AB0", VA = "0x1827828B0")]
	public static FLDEEDHJIKG<CJEEPIILMHM, MLFAKCKOFLP> DKMDNOBFIEL(AGKENLKLGLL NJCMLDAIPDB)
	{
		return default(FLDEEDHJIKG<CJEEPIILMHM, MLFAKCKOFLP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2782C20", Offset = "0x2781E20", VA = "0x182782C20")]
	public static LOAMJJJEMNF<AGKENLKLGLL, PLLHOMFPAAM> KHFEAELDEDF(BMLBDHHGCHG FHPKLENNKKO, [In] MLFAKCKOFLP CEENCLMGJAM)
	{
		return default(LOAMJJJEMNF<AGKENLKLGLL, PLLHOMFPAAM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct EGHBLGJNGKE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct DHEKJIMPJAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<bool, BHGOBKJBFOA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public BMLBDHHGCHG root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public EGHBLGJNGKE self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private LOAMJJJEMNF<bool, BHGOBKJBFOA> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, BHGOBKJBFOA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2774740", Offset = "0x2773940", VA = "0x182774740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2774D80", Offset = "0x2773F80", VA = "0x182774D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly int FAGABNHAKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly int PMLOAHGMFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly byte[] ALBEJFPMKJB;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xC21700", Offset = "0xC20900", VA = "0x180C21700")]
	private EGHBLGJNGKE(int KIFHGDECLNI, int NIBICIJAIGM, byte[] DHAOEHNLNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2775690", Offset = "0x2774890", VA = "0x182775690")]
	public static AGKENLKLGLL HMENNHMOPGM(int KIFHGDECLNI, int NIBICIJAIGM, ByteString DHAOEHNLNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2775490", Offset = "0x2774690", VA = "0x182775490")]
	public static AGKENLKLGLL?[]? FHDKFHAJFEI(int HLFPNHOFPMK, NHNBDDEEFPH? JLIIGFHECCJ, HBBBCDHABCG? KGABJAIKBPB, HAPGMLIDNII? ALDFCBINAND, JLFEKJLHFFI? IHGNMLHENCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x27753B0", Offset = "0x27745B0", VA = "0x1827753B0")]
	public static FLDEEDHJIKG<CJEEPIILMHM, EGHBLGJNGKE> DKMDNOBFIEL(AGKENLKLGLL NJCMLDAIPDB)
	{
		return default(FLDEEDHJIKG<CJEEPIILMHM, EGHBLGJNGKE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2775770", Offset = "0x2774970", VA = "0x182775770")]
	[AsyncStateMachine(typeof(DHEKJIMPJAM))]
	public static Task<LOAMJJJEMNF<bool, BHGOBKJBFOA>> PDCFBAPJHPO(BMLBDHHGCHG FHPKLENNKKO, EGHBLGJNGKE CEENCLMGJAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class KAMJDMDLOAC : MNOMGFJJPJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly BMLBDHHGCHG IECLKAPHAHM;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public KBOPEFNLGGH? NDDGJHHDBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x277C370", Offset = "0x277B570", VA = "0x18277C370", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
	internal KAMJDMDLOAC(BMLBDHHGCHG CCCBLIDEHDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class MJMIAKKOBJB : KBOPEFNLGGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly BMLBDHHGCHG IECLKAPHAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly PACLEKAFKMK DMFDBIKEBDE;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x9FFD40", Offset = "0x9FEF40", VA = "0x1809FFD40")]
	public MJMIAKKOBJB(BMLBDHHGCHG CCCBLIDEHDI, PACLEKAFKMK GNCHNFLHMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x27822B0", Offset = "0x27814B0", VA = "0x1827822B0", Slot = "4")]
	public LOAMJJJEMNF<EBJLFCJJLKE, PGENCONCFGB> IJMOPDELLMD(NICODLFMDAJ<PKEJDDGKOJK> CANDMCKMDKL, JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG, JFIBBLJIDCN<BACAMPPLFGC> HAPCGDBBODD)
	{
		return default(LOAMJJJEMNF<EBJLFCJJLKE, PGENCONCFGB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2781CB0", Offset = "0x2780EB0", VA = "0x182781CB0", Slot = "5")]
	public LOAMJJJEMNF<EBJLFCJJLKE, PGENCONCFGB> GDCFHMOGBGO(NICODLFMDAJ<PKEJDDGKOJK> CANDMCKMDKL, JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG, JFIBBLJIDCN<PADJNFOHKPF> DAPOJGPODED)
	{
		return default(LOAMJJJEMNF<EBJLFCJJLKE, PGENCONCFGB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class BPNIFDODBBN : KFHNMCPFJED, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface AJKKABFCNJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<PACLEKAFKMK> DLIEHDJGIIB(BMLBDHHGCHG CCCBLIDEHDI, HBBBCDHABCG? GBONBIBLNII, HAPGMLIDNII? KBJOIFIPALI, CancellationToken HCELDNOKOAM);

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		JKLLNEDIFMH ICFEIFLKLAH(BMLBDHHGCHG CCCBLIDEHDI, NHNBDDEEFPH BNCDGLPBPHI);
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class FKAHOCFIPHM : AJKKABFCNJF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private struct ECKNIBBIBDA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public AsyncTaskMethodBuilder<PACLEKAFKMK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public BMLBDHHGCHG circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public HBBBCDHABCG cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public HAPGMLIDNII cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private TaskAwaiter<KAMDFIOBPJP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2775170", Offset = "0x2774370", VA = "0x182775170", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2775340", Offset = "0x2774540", VA = "0x182775340", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly FKAHOCFIPHM NDDGJHHDBNJ;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		private FKAHOCFIPHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x27764C0", Offset = "0x27756C0", VA = "0x1827764C0", Slot = "4")]
		[AsyncStateMachine(typeof(ECKNIBBIBDA))]
		public Task<PACLEKAFKMK> DLIEHDJGIIB(BMLBDHHGCHG CCCBLIDEHDI, HBBBCDHABCG? GBONBIBLNII, HAPGMLIDNII? KBJOIFIPALI, CancellationToken HCELDNOKOAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2776620", Offset = "0x2775820", VA = "0x182776620", Slot = "5")]
		public JKLLNEDIFMH ICFEIFLKLAH(BMLBDHHGCHG CCCBLIDEHDI, NHNBDDEEFPH BNCDGLPBPHI)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct EPEKKNKJBFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public AsyncTaskMethodBuilder<BPNIFDODBBN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public BMLBDHHGCHG circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public HBBBCDHABCG cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public HAPGMLIDNII cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public NHNBDDEEFPH evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private AJKKABFCNJF <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TaskAwaiter<PACLEKAFKMK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2775E10", Offset = "0x2775010", VA = "0x182775E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2776310", Offset = "0x2775510", VA = "0x182776310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly PACLEKAFKMK DMFDBIKEBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly JKLLNEDIFMH MFHBMFIKKFC;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public KFOPAHDCEKH HHPJLCPBLFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x27740C0", Offset = "0x27732C0", VA = "0x1827740C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FAMLAPLNGCO JCJFFMCLIJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2773E90", Offset = "0x2773090", VA = "0x182773E90", Slot = "5")]
		get
		{
			return default(FAMLAPLNGCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MJMIAKKOBJB MKPFGKFLJAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public CIFBENMLFCL LFBFOMLIKCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xEE74F0", Offset = "0xEE66F0", VA = "0x180EE74F0")]
	private BPNIFDODBBN(PACLEKAFKMK GNCHNFLHMAC, JKLLNEDIFMH INGCPKGHKBK, MJMIAKKOBJB HALDEFGJHPO, CIFBENMLFCL DHNBAGFGEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2773F50", Offset = "0x2773150", VA = "0x182773F50")]
	[AsyncStateMachine(typeof(EPEKKNKJBFL))]
	public static Task<BPNIFDODBBN> JIPJHJKGJPD(BMLBDHHGCHG CCCBLIDEHDI, NHNBDDEEFPH BNCDGLPBPHI, HBBBCDHABCG? GBONBIBLNII, HAPGMLIDNII? KBJOIFIPALI, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2773E30", Offset = "0x2773030", VA = "0x182773E30", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class HOFOMPIHPAL : EPPBIMKACJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface FLHBAFDPOGO
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<KFHNMCPFJED> BHLABJGBHCA(BMLBDHHGCHG CCCBLIDEHDI, NHNBDDEEFPH BNCDGLPBPHI, HBBBCDHABCG? GBONBIBLNII, HAPGMLIDNII? KBJOIFIPALI, CancellationToken HCELDNOKOAM);

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JLFCKAMBJDO();

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void EEMNMKIKEOO();
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public abstract class IIBNMJLDLKI : FLHBAFDPOGO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private struct IACBHPEELAG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public AsyncTaskMethodBuilder<KFHNMCPFJED> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public BMLBDHHGCHG circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public NHNBDDEEFPH evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public HBBBCDHABCG cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public HAPGMLIDNII cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private TaskAwaiter<BPNIFDODBBN> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x27780F0", Offset = "0x27772F0", VA = "0x1827780F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x2778430", Offset = "0x2777630", VA = "0x182778430", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2778650", Offset = "0x2777850", VA = "0x182778650", Slot = "4")]
		[AsyncStateMachine(typeof(IACBHPEELAG))]
		public Task<KFHNMCPFJED> BHLABJGBHCA(BMLBDHHGCHG CCCBLIDEHDI, NHNBDDEEFPH BNCDGLPBPHI, HBBBCDHABCG? GBONBIBLNII, HAPGMLIDNII? KBJOIFIPALI, CancellationToken HCELDNOKOAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void JLFCKAMBJDO();

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void EEMNMKIKEOO();

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		protected IIBNMJLDLKI()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct ANEGFGDKAIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public AsyncTaskMethodBuilder<KFHNMCPFJED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public HOFOMPIHPAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter<GKPOGNMPJHG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x27714C0", Offset = "0x27706C0", VA = "0x1827714C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x27716C0", Offset = "0x27708C0", VA = "0x1827716C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct AJMIDPBNHAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public HOFOMPIHPAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public BMLBDHHGCHG circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public NHNBDDEEFPH evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public HBBBCDHABCG cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public HAPGMLIDNII cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter<KFHNMCPFJED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x2770F30", Offset = "0x2770130", VA = "0x182770F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x2771460", Offset = "0x2770660", VA = "0x182771460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly FLHBAFDPOGO MPDDJFAHINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly TaskCompletionSource<GKPOGNMPJHG> GKEMPOPDMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly TaskCompletionSource<GKPOGNMPJHG> HGKOADMIIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly CancellationTokenSource NMHCIBEMJGM;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool LKNDAINDJKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA1E2D0", Offset = "0xA1D4D0", VA = "0x180A1E2D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA1E050", Offset = "0xA1D250", VA = "0x180A1E050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool DBBHGEKFDEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xDB5500", Offset = "0xDB4700", VA = "0x180DB5500", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1339D10", Offset = "0x1338F10", VA = "0x181339D10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool PCBHJDCIELI
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xF6B4A0", Offset = "0xF6A6A0", VA = "0x180F6B4A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2777C00", Offset = "0x2776E00", VA = "0x182777C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public KFHNMCPFJED? KNMPLLKPFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9F2470", Offset = "0x9F1670", VA = "0x1809F2470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2777D90", Offset = "0x2776F90", VA = "0x182777D90", Slot = "7")]
	[AsyncStateMachine(typeof(ANEGFGDKAIA))]
	public Task<KFHNMCPFJED> FDGLNONOIEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2777FE0", Offset = "0x27771E0", VA = "0x182777FE0")]
	public HOFOMPIHPAL(FLHBAFDPOGO POLANHDJCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2777E80", Offset = "0x2777080", VA = "0x182777E80", Slot = "8")]
	[AsyncStateMachine(typeof(AJMIDPBNHAH))]
	public Task JPBNLDGKOPF(BMLBDHHGCHG CCCBLIDEHDI, NHNBDDEEFPH BNCDGLPBPHI, HBBBCDHABCG? GBONBIBLNII, HAPGMLIDNII? KBJOIFIPALI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2777C10", Offset = "0x2776E10", VA = "0x182777C10", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class AEGPNBFJMOF : LKMCMOLMEHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CIFBENMLFCL BCHFLKCKLFK;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
	public AEGPNBFJMOF(CIFBENMLFCL DHNBAGFGEEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal static class PHCMMIPNNMP
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class LGLFKDIDMPH<TGraph> : KLOPJCOPMLK where TGraph : ICPAFHENLAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		protected readonly TGraph DILOENOGEDG;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public virtual CGJKGCKLOFH? PCMCLCODEBP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x1800B40", Offset = "0x17FFD40", VA = "0x181800B40", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual NICODLFMDAJ<PKEJDDGKOJK>? JMOLJMEFNLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x1800B40", Offset = "0x17FFD40", VA = "0x181800B40", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public JFIBBLJIDCN<JJGKIIIBOJJ> DINAEIOCCKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x29ECB30", Offset = "0x29EBD30", VA = "0x1829ECB30", Slot = "5")]
			get
			{
				return default(JFIBBLJIDCN<JJGKIIIBOJJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public JFIBBLJIDCN<JJGKIIIBOJJ>? GNGCOBIEEDM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x50CB9D0", Offset = "0x50CABD0", VA = "0x1850CB9D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
		public LGLFKDIDMPH(TGraph CPICBKAHABD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private sealed class AIPNIJBONKF : LGLFKDIDMPH<AEJNIJMDADC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override CGJKGCKLOFH? PCMCLCODEBP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x2770E40", Offset = "0x2770040", VA = "0x182770E40", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override NICODLFMDAJ<PKEJDDGKOJK>? JMOLJMEFNLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x2770DB0", Offset = "0x276FFB0", VA = "0x182770DB0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2770E60", Offset = "0x2770060", VA = "0x182770E60")]
		public AIPNIJBONKF(AEJNIJMDADC AEBLHBOFKCO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2783470", Offset = "0x2782670", VA = "0x182783470")]
	public static KLOPJCOPMLK OIKMHICCLEP(ICPAFHENLAO CPICBKAHABD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class LLDLFLABLJL : CGGFCIGIACJ, DLMFJDADCBK, DEEMKFDPNME, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class BEJLAAJCIFC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private struct <<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public BEJLAAJCIFC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public LAMDCDECGNG errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x2783870", Offset = "0x2782A70", VA = "0x182783870", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2783AE0", Offset = "0x2782CE0", VA = "0x182783AE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public LLDLFLABLJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public BEJLAAJCIFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2772150", Offset = "0x2771350", VA = "0x182772150")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task AJKJBGHEDMA(LAMDCDECGNG errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct ENEBHOPMBFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public bool checkStringPurity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public LLDLFLABLJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x27758A0", Offset = "0x2774AA0", VA = "0x1827758A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2775DB0", Offset = "0x2774FB0", VA = "0x182775DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class DNEBNLJBIBO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private struct <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public DNEBNLJBIBO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x2783B40", Offset = "0x2782D40", VA = "0x182783B40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x2783E20", Offset = "0x2783020", VA = "0x182783E20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public LLDLFLABLJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public DNEBNLJBIBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2774E00", Offset = "0x2774000", VA = "0x182774E00")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task PMAGBNFHLDB(LAMDCDECGNG errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class LDLIOOELEKO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		private struct <<RequestSetVectorComponentValue>g__requestSetVectorComponentValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public LDLIOOELEKO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x27843A0", Offset = "0x27835A0", VA = "0x1827843A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x2784850", Offset = "0x2783A50", VA = "0x182784850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public LLDLFLABLJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int valueIndex;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public LDLIOOELEKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x277DAA0", Offset = "0x277CCA0", VA = "0x18277DAA0")]
		[AsyncStateMachine(typeof(<<RequestSetVectorComponentValue>g__requestSetVectorComponentValueInternal|0>d))]
		internal Task IMMMFPIMJBJ(LAMDCDECGNG errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class FLJNMLDMDCK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		private struct <<RequestSetQuaternionComponentValue>g__requestSetQuaternionComponentValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public FLJNMLDMDCK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x2783E80", Offset = "0x2783080", VA = "0x182783E80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x2784340", Offset = "0x2783540", VA = "0x182784340", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public LLDLFLABLJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public int valueIndex;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public FLJNMLDMDCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x27766B0", Offset = "0x27758B0", VA = "0x1827766B0")]
		[AsyncStateMachine(typeof(<<RequestSetQuaternionComponentValue>g__requestSetQuaternionComponentValueInternal|0>d))]
		internal Task DJCBEIMKOEO(LAMDCDECGNG errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly JCKMHJAJBIB NHMGKIEDCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly ICollection<POFDMOBIGOL> DIHAPANCBFD;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private IAACJJOGHIC CEMOHEGDHOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x277DB70", Offset = "0x277CD70", VA = "0x18277DB70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public JFIBBLJIDCN<BACAMPPLFGC> LDHGHGJKOGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xF524E0", Offset = "0xF516E0", VA = "0x180F524E0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(JFIBBLJIDCN<BACAMPPLFGC>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xF52460", Offset = "0xF51660", VA = "0x180F52460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private JFIBBLJIDCN<FLAIMFHIJIM> JADDPBKFPAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x132DD30", Offset = "0x132CF30", VA = "0x18132DD30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public JFIBBLJIDCN<PFJDLPPNNBM> BOACIBAIKMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA17F30", Offset = "0xA17130", VA = "0x180A17F30", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(JFIBBLJIDCN<PFJDLPPNNBM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override JFIBBLJIDCN<GOJKLMIIDHM> MHCEAOMNMDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x277F4C0", Offset = "0x277E6C0", VA = "0x18277F4C0", Slot = "21")]
		get
		{
			return default(JFIBBLJIDCN<GOJKLMIIDHM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool CPIBKPPOHLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x27802D0", Offset = "0x277F4D0", VA = "0x1827802D0", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2781950", Offset = "0x2780B50", VA = "0x182781950")]
	private LLDLFLABLJL(BMLBDHHGCHG CCCBLIDEHDI, CNJNPCHEFBN GCEDHPINDAM, JCKMHJAJBIB OODGCMIPOLN, JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG, JFIBBLJIDCN<BACAMPPLFGC> HAPCGDBBODD, JFIBBLJIDCN<FLAIMFHIJIM> CGNNJJCOPBO, bool HMPJAGJNCCK, string DGIAFBEDPNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2781170", Offset = "0x2780370", VA = "0x182781170")]
	public static LLDLFLABLJL OIKMHICCLEP(BMLBDHHGCHG CCCBLIDEHDI, CNJNPCHEFBN GCEDHPINDAM, JCKMHJAJBIB EEEOGOJIPGB, JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG, JFIBBLJIDCN<FLAIMFHIJIM> CGNNJJCOPBO, JFIBBLJIDCN<BACAMPPLFGC> HAPCGDBBODD, bool HMPJAGJNCCK, bool BAEMHFOCPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x27804B0", Offset = "0x277F6B0", VA = "0x1827804B0", Slot = "22")]
	protected override void ILLMBOBOELN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x277F5E0", Offset = "0x277E7E0", VA = "0x18277F5E0", Slot = "23")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x277F310", Offset = "0x277E510", VA = "0x18277F310", Slot = "31")]
	public void DANIBKJAHNJ(POFDMOBIGOL BAJNEJFBMKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x277F810", Offset = "0x277EA10", VA = "0x18277F810", Slot = "28")]
	public void FABMBBDOOOL(MMCENCFIHGP HOIFNCHIKEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x277E2A0", Offset = "0x277D4A0", VA = "0x18277E2A0", Slot = "29")]
	public void BKDMKNNIJBJ(DIGCEMNOGDG EEEMDOJPDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x27800E0", Offset = "0x277F2E0", VA = "0x1827800E0", Slot = "24")]
	protected override void HEKGHEDBPJF(IIOANHEMOAF BOKANDMKOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x27817D0", Offset = "0x27809D0", VA = "0x1827817D0", Slot = "33")]
	public string PEBLJHJJJEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x277DBA0", Offset = "0x277CDA0", VA = "0x18277DBA0", Slot = "30")]
	public string AMAPLEIDMLI(int JKMHCAHCOEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2780EE0", Offset = "0x27800E0", VA = "0x182780EE0")]
	private void MJPIAJHOFLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2780990", Offset = "0x277FB90", VA = "0x182780990", Slot = "32")]
	public void KLPGAKOGOBB(POFDMOBIGOL BAJNEJFBMKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x277E0E0", Offset = "0x277D2E0", VA = "0x18277E0E0")]
	private void BDMMIGAAJCF(bool MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x27816C0", Offset = "0x27808C0", VA = "0x1827816C0", Slot = "34")]
	[AsyncStateMachine(typeof(ENEBHOPMBFD))]
	public Task PBNMBAABNOA(string MLCDCHNOCFI, bool DEFFBGBMECD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x27805C0", Offset = "0x277F7C0", VA = "0x1827805C0")]
	public void JJBJDGMAOMI(string MLCDCHNOCFI, bool DEFFBGBMECD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2780D40", Offset = "0x277FF40", VA = "0x182780D40")]
	private void MGIGKDPHOLI(int MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x277FF20", Offset = "0x277F120", VA = "0x18277FF20")]
	private void HDBLFHCBFEC(int PMFJDKCLCGI, string MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x277FC00", Offset = "0x277EE00", VA = "0x18277FC00")]
	private void FPFNBCHMLMF(int PMFJDKCLCGI, string MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x277F370", Offset = "0x277E570", VA = "0x18277F370")]
	private string DEDCHOEKDGE(int PMFJDKCLCGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x277DE70", Offset = "0x277D070", VA = "0x18277DE70")]
	private string ANANFLIIJFK(int PMFJDKCLCGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0xF52460", Offset = "0xF51660", VA = "0x180F52460")]
	internal void CMEIEHLIEIE(JFIBBLJIDCN<BACAMPPLFGC> MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x277FBF0", Offset = "0x277EDF0", VA = "0x18277FBF0")]
	[CompilerGenerated]
	private void FONHPBJNNJG(string MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x277F680", Offset = "0x277E880", VA = "0x18277F680")]
	[CompilerGenerated]
	private bool EKKOKJGIBPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2780B20", Offset = "0x277FD20", VA = "0x182780B20")]
	[CompilerGenerated]
	private bool LBEHBIMDHPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2781110", Offset = "0x2780310", VA = "0x182781110")]
	[CompilerGenerated]
	private int NIBNFHBEBIJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2780230", Offset = "0x277F430", VA = "0x182780230")]
	[CompilerGenerated]
	private bool HEPNNLJCLOA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2780BF0", Offset = "0x277FDF0", VA = "0x182780BF0")]
	[CompilerGenerated]
	private void LFEGHJALGAM(string MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x27808D0", Offset = "0x277FAD0", VA = "0x1827808D0")]
	[CompilerGenerated]
	private bool KILNLOKOIAJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2780CF0", Offset = "0x277FEF0", VA = "0x182780CF0")]
	[CompilerGenerated]
	private bool MDBMCFECFAB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x277FDC0", Offset = "0x277EFC0", VA = "0x18277FDC0")]
	[CompilerGenerated]
	private bool GEOLGDEMIPN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2781110", Offset = "0x2780310", VA = "0x182781110")]
	[CompilerGenerated]
	private int PCNMPIDFAAI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2780720", Offset = "0x277F920", VA = "0x182780720")]
	[CompilerGenerated]
	private bool JPJOPAGMOEF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2780C00", Offset = "0x277FE00", VA = "0x182780C00")]
	[CompilerGenerated]
	private object LMEEDPEDKEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2780350", Offset = "0x277F550", VA = "0x182780350")]
	[CompilerGenerated]
	private void IFJLDPGFPLC(object MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x277FE50", Offset = "0x277F050", VA = "0x18277FE50")]
	[CompilerGenerated]
	private bool GJDCJDMAOGC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2780C80", Offset = "0x277FE80", VA = "0x182780C80")]
	[CompilerGenerated]
	private string MAPADPOFJPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x27808C0", Offset = "0x277FAC0", VA = "0x1827808C0")]
	[CompilerGenerated]
	private void KHENPJELHHC(string MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x27807F0", Offset = "0x277F9F0", VA = "0x1827807F0")]
	[CompilerGenerated]
	private bool KFCBIEELGMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x277E070", Offset = "0x277D270", VA = "0x18277E070")]
	[CompilerGenerated]
	private string BCANCFBHALI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x27802C0", Offset = "0x277F4C0", VA = "0x1827802C0")]
	[CompilerGenerated]
	private void HKNEDHEDEGM(string MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2780A50", Offset = "0x277FC50", VA = "0x182780A50")]
	[CompilerGenerated]
	private bool KMEMLGHOFIJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2780550", Offset = "0x277F750", VA = "0x182780550")]
	[CompilerGenerated]
	private string IOIGFIAAKOK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2780BE0", Offset = "0x277FDE0", VA = "0x182780BE0")]
	[CompilerGenerated]
	private void LEEACINBCDM(string MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x277F740", Offset = "0x277E940", VA = "0x18277F740")]
	[CompilerGenerated]
	private bool ELHEIFIBFEK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x27803D0", Offset = "0x277F5D0", VA = "0x1827803D0")]
	[CompilerGenerated]
	private string IKHLJKCEKBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x277DB90", Offset = "0x277CD90", VA = "0x18277DB90")]
	[CompilerGenerated]
	private void AJBMMCKIPCI(string MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x27815F0", Offset = "0x27807F0", VA = "0x1827815F0")]
	[CompilerGenerated]
	private bool PADCCINPMNI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x277FB80", Offset = "0x277ED80", VA = "0x18277FB80")]
	[CompilerGenerated]
	private string FIPMENBADEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2780710", Offset = "0x277F910", VA = "0x182780710")]
	[CompilerGenerated]
	private void JONBFEOGOIC(string MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x277F510", Offset = "0x277E710", VA = "0x18277F510")]
	[CompilerGenerated]
	private bool DNBOPNAONOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x277E000", Offset = "0x277D200", VA = "0x18277E000")]
	[CompilerGenerated]
	private string AOMDNJHPLCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x277F230", Offset = "0x277E430", VA = "0x18277F230")]
	[CompilerGenerated]
	private void BOKFIBJCBMP(string MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2781520", Offset = "0x2780720", VA = "0x182781520")]
	[CompilerGenerated]
	private bool OILOHCGLHBE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2780440", Offset = "0x277F640", VA = "0x182780440")]
	[CompilerGenerated]
	private string IKKCEGHCJCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2781160", Offset = "0x2780360", VA = "0x182781160")]
	[CompilerGenerated]
	private void OHOGKBFOADM(string MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x277F240", Offset = "0x277E440", VA = "0x18277F240")]
	[CompilerGenerated]
	private bool CBIOGDCEKMA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class JCEENKAGPJI
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private sealed class AHHEGLHNFIF : NGBBBGMAMMH<KECEIIKKDDG>
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class FCHMKDABPPA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public AHHEGLHNFIF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public OOMLOHBOPAJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public FCHMKDABPPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x2776450", Offset = "0x2775650", VA = "0x182776450")]
			internal object JJHKHADFADH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x2776380", Offset = "0x2775580", VA = "0x182776380")]
			internal void FIJOLHGPAJJ(object value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2770AC0", Offset = "0x276FCC0", VA = "0x182770AC0")]
		public AHHEGLHNFIF(BMLBDHHGCHG CCCBLIDEHDI, KECEIIKKDDG AHLPFPPNCPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2770830", Offset = "0x276FA30", VA = "0x182770830", Slot = "134")]
		protected override void DJABOMCCOKE(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public sealed class MNBMNFDBHCA : AJNKAPHEEJK<MLCHDEBOKOM>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override OCHEGKNJKMM BHNHGHGNBAM
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xBE5C50", Offset = "0xBE4E50", VA = "0x180BE5C50", Slot = "140")]
			get
			{
				return default(OCHEGKNJKMM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2783140", Offset = "0x2782340", VA = "0x182783140")]
		public MNBMNFDBHCA(BMLBDHHGCHG CCCBLIDEHDI, MLCHDEBOKOM AHLPFPPNCPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class MLNNOEJECDC : NGBBBGMAMMH<HGDFCAFNIIP>
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x27830D0", Offset = "0x27822D0", VA = "0x1827830D0")]
		public MLNNOEJECDC(BMLBDHHGCHG CCCBLIDEHDI, HGDFCAFNIIP GCEDHPINDAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2782DD0", Offset = "0x2781FD0", VA = "0x182782DD0", Slot = "134")]
		protected override void DJABOMCCOKE(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2782F50", Offset = "0x2782150", VA = "0x182782F50")]
		[CompilerGenerated]
		private bool GHEMGDDNEFL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2782FA0", Offset = "0x27821A0", VA = "0x182782FA0")]
		[CompilerGenerated]
		private void GJEIKAFLFKJ(bool MLCDCHNOCFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public sealed class KOLHLBNICHP : NGBBBGMAMMH<KCHIDNEGAHP>
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private sealed class PPMMMMHAGAC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public OOMLOHBOPAJ nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public KOLHLBNICHP <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public PPMMMMHAGAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x27836F0", Offset = "0x27828F0", VA = "0x1827836F0")]
			internal void JJHKHADFADH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x27836A0", Offset = "0x27828A0", VA = "0x1827836A0")]
			internal bool FIJOLHGPAJJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x2783600", Offset = "0x2782800", VA = "0x182783600")]
			internal bool CMLNADHEAEF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x2783740", Offset = "0x2782940", VA = "0x182783740")]
			internal void KPPJIHPOEEL(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x2783650", Offset = "0x2782850", VA = "0x182783650")]
			internal bool EBLGFJDKHCO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x277D8C0", Offset = "0x277CAC0", VA = "0x18277D8C0")]
		public KOLHLBNICHP(BMLBDHHGCHG CCCBLIDEHDI, KCHIDNEGAHP GCEDHPINDAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x277D580", Offset = "0x277C780", VA = "0x18277D580", Slot = "134")]
		protected override void DJABOMCCOKE(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public sealed class BCAMMFKIEGM : NGBBBGMAMMH<HHPCADGGBAJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private sealed class HLEMNJELEMA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public OOMLOHBOPAJ nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public BCAMMFKIEGM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public HLEMNJELEMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x2777A60", Offset = "0x2776C60", VA = "0x182777A60")]
			internal object JJHKHADFADH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x2777480", Offset = "0x2776680", VA = "0x182777480")]
			internal bool ANJLBEPLFDL(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x2777800", Offset = "0x2776A00", VA = "0x182777800")]
			internal void FIJOLHGPAJJ(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x2777630", Offset = "0x2776830", VA = "0x182777630")]
			internal string CMLNADHEAEF(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x2777B60", Offset = "0x2776D60", VA = "0x182777B60")]
			internal IReadOnlyList<object> KPPJIHPOEEL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2777790", Offset = "0x2776990", VA = "0x182777790")]
			internal bool EBLGFJDKHCO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x2777BB0", Offset = "0x2776DB0", VA = "0x182777BB0")]
			internal bool MOHKPNFBBHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x2777500", Offset = "0x2776700", VA = "0x182777500")]
			internal void BCBLAPKDEME(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2771E80", Offset = "0x2771080", VA = "0x182771E80")]
		public BCAMMFKIEGM(BMLBDHHGCHG CCCBLIDEHDI, HHPCADGGBAJ GCEDHPINDAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2771730", Offset = "0x2770930", VA = "0x182771730", Slot = "134")]
		protected override void DJABOMCCOKE(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class DNLAGDLEPKC : NGBBBGMAMMH<BCPECJBGCCE>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class KKLACDAHJCH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public DNLAGDLEPKC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public OOMLOHBOPAJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public KKLACDAHJCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x277CDB0", Offset = "0x277BFB0", VA = "0x18277CDB0")]
			internal bool JJHKHADFADH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x277CC80", Offset = "0x277BE80", VA = "0x18277CC80")]
			internal void FIJOLHGPAJJ(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x277CC30", Offset = "0x277BE30", VA = "0x18277CC30")]
			internal bool CMLNADHEAEF()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2775100", Offset = "0x2774300", VA = "0x182775100")]
		public DNLAGDLEPKC(BMLBDHHGCHG CCCBLIDEHDI, BCPECJBGCCE GCEDHPINDAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2774ED0", Offset = "0x27740D0", VA = "0x182774ED0", Slot = "134")]
		protected override void DJABOMCCOKE(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public abstract class NMFBAIOGNBH<TNode> : NGBBBGMAMMH<TNode> where TNode : notnull, GDIEIHKDGAK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private struct NDKJJOLPIFP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public AsyncTaskMethodBuilder<LOAMJJJEMNF<JFIBBLJIDCN<IMLHFCPAHJM>, PLLHOMFPAAM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public NMFBAIOGNBH<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private TaskAwaiter<LOAMJJJEMNF<JFIBBLJIDCN<IMLHFCPAHJM>, PLLHOMFPAAM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x537F0A0", Offset = "0x537E2A0", VA = "0x18537F0A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x537F4B0", Offset = "0x537E6B0", VA = "0x18537F4B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct BLOKHNCGIIE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public AsyncTaskMethodBuilder<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public NMFBAIOGNBH<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public JFIBBLJIDCN<IMLHFCPAHJM> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x605DE60", Offset = "0x605D060", VA = "0x18605DE60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x605E270", Offset = "0x605D470", VA = "0x18605E270", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public sealed override bool MFKKKJBBFKL
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "129")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public sealed override JFIBBLJIDCN<IMLHFCPAHJM>? LHMBHPHHJMH
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x53BE070", Offset = "0x53BD270", VA = "0x1853BE070", Slot = "133")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x5105B00", Offset = "0x5104D00", VA = "0x185105B00")]
		protected NMFBAIOGNBH(BMLBDHHGCHG CCCBLIDEHDI, TNode GCEDHPINDAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x53BDEB0", Offset = "0x53BD0B0", VA = "0x1853BDEB0", Slot = "114")]
		[AsyncStateMachine(typeof(NMFBAIOGNBH<>.NDKJJOLPIFP))]
		public override Task<LOAMJJJEMNF<JFIBBLJIDCN<IMLHFCPAHJM>, PLLHOMFPAAM>> LDCMFCGDIPG(string DGIAFBEDPNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x53BDC60", Offset = "0x53BCE60", VA = "0x1853BDC60", Slot = "138")]
		public sealed override bool CHCGOHDLBBJ(JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x53BDFD0", Offset = "0x53BD1D0", VA = "0x1853BDFD0", Slot = "126")]
		protected sealed override bool MJGKLEIAAIJ(JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x53BDD00", Offset = "0x53BCF00", VA = "0x1853BDD00", Slot = "127")]
		protected override bool DHAKHKHHMIL(JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x53BDDA0", Offset = "0x53BCFA0", VA = "0x1853BDDA0", Slot = "115")]
		[AsyncStateMachine(typeof(NMFBAIOGNBH<>.BLOKHNCGIIE))]
		public override Task<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> JMJHHIDJGGF(JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public sealed class KMPDDEJKLEL : PPMLHFHFDEL<CJDCFPICCDN>
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private sealed class CPGHEJCFMMC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public KMPDDEJKLEL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public OOMLOHBOPAJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public CPGHEJCFMMC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x2774470", Offset = "0x2773670", VA = "0x182774470")]
			internal bool PHMIIEGBIFK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x27743B0", Offset = "0x27735B0", VA = "0x1827743B0")]
			internal void LLJCGKBIOBK(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x277D050", Offset = "0x277C250", VA = "0x18277D050")]
		public KMPDDEJKLEL(BMLBDHHGCHG CCCBLIDEHDI, CJDCFPICCDN AHLPFPPNCPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x277CE00", Offset = "0x277C000", VA = "0x18277CE00", Slot = "140")]
		protected override void DBPPHPMJCAC(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private sealed class KDJMKPGOBLA : OODFLKOFLEK<ANLDAKFOIGL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override NodeVisualizationKey AFPMCDIFDOM
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0xBE2300", Offset = "0xBE1500", VA = "0x180BE2300", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x277C470", Offset = "0x277B670", VA = "0x18277C470")]
		public KDJMKPGOBLA(BMLBDHHGCHG CCCBLIDEHDI, ANLDAKFOIGL GCEDHPINDAM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public abstract class OODFLKOFLEK<TNode> : NGBBBGMAMMH<TNode> where TNode : notnull, PLNJIEBAAPH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct FLEPEOPDOCL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public AsyncTaskMethodBuilder<LOAMJJJEMNF<JFIBBLJIDCN<IMLHFCPAHJM>, PLLHOMFPAAM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public OODFLKOFLEK<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			private TaskAwaiter<LOAMJJJEMNF<JFIBBLJIDCN<IMLHFCPAHJM>, PLLHOMFPAAM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x49AE280", Offset = "0x49AD480", VA = "0x1849AE280", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x49AE730", Offset = "0x49AD930", VA = "0x1849AE730", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private struct BFEBBAIKIPI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public AsyncTaskMethodBuilder<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public OODFLKOFLEK<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public JFIBBLJIDCN<IMLHFCPAHJM> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x5E82040", Offset = "0x5E81240", VA = "0x185E82040", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x5E824C0", Offset = "0x5E816C0", VA = "0x185E824C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private struct IKPEPBJCNHM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public AsyncTaskMethodBuilder<LOAMJJJEMNF<MKMBMMHDKHK, PLLHOMFPAAM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public OODFLKOFLEK<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private TaskAwaiter<LOAMJJJEMNF<MKMBMMHDKHK, PLLHOMFPAAM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x4CA04E0", Offset = "0x4C9F6E0", VA = "0x184CA04E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x4CA0B90", Offset = "0x4C9FD90", VA = "0x184CA0B90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[CompilerGenerated]
		private sealed class NMDAIFDKFJA
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			private struct <<BuildConfigMenuInternal>b__7>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public NMDAIFDKFJA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0x40BF230", Offset = "0x40BE430", VA = "0x1840BF230", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000175")]
				[Cpp2IlInjected.Address(RVA = "0xA51B40", Offset = "0xA50D40", VA = "0x180A51B40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public KBGIAKLKLKJ configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public OOMLOHBOPAJ nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public OODFLKOFLEK<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public Func<string, bool> <>9__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public Action <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public NMDAIFDKFJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x53BD330", Offset = "0x53BC530", VA = "0x1853BD330")]
			internal bool BCBLAPKDEME(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x53BD800", Offset = "0x53BCA00", VA = "0x1853BD800")]
			internal void JJHKHADFADH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x53BD290", Offset = "0x53BC490", VA = "0x1853BD290")]
			[AsyncStateMachine(typeof(OODFLKOFLEK<>.NMDAIFDKFJA.<<BuildConfigMenuInternal>b__7>d))]
			internal void ANJLBEPLFDL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x53BD410", Offset = "0x53BC610", VA = "0x1853BD410")]
			internal bool FIJOLHGPAJJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[CompilerGenerated]
		private sealed class ICLLKLLODOC
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000057")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				public ICLLKLLODOC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				private TaskAwaiter<TaskStatus> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600017B")]
				[Cpp2IlInjected.Address(RVA = "0x40BEEC0", Offset = "0x40BE0C0", VA = "0x1840BEEC0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600017C")]
				[Cpp2IlInjected.Address(RVA = "0xA51B40", Offset = "0xA50D40", VA = "0x180A51B40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public string newFunctionName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public NMDAIFDKFJA CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public Func<string> <>9__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public Action<string> <>9__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public Action <>9__5;

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public ICLLKLLODOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x4C6F340", Offset = "0x4C6E540", VA = "0x184C6F340")]
			internal void CMLNADHEAEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
			internal string KPPJIHPOEEL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
			internal void EBLGFJDKHCO(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x4C6F750", Offset = "0x4C6E950", VA = "0x184C6F750")]
			[AsyncStateMachine(typeof(OODFLKOFLEK<>.ICLLKLLODOC.<<BuildConfigMenuInternal>b__5>d))]
			internal void MOHKPNFBBHA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		[CompilerGenerated]
		private sealed class MIJEMKODMIF
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000059")]
			private struct <<AddDynamicNodeGroupSettingV2>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010B")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010C")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010D")]
				public MIJEMKODMIF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000190")]
				[Cpp2IlInjected.Address(RVA = "0x40BE9F0", Offset = "0x40BDBF0", VA = "0x1840BE9F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000191")]
				[Cpp2IlInjected.Address(RVA = "0xA51B40", Offset = "0xA50D40", VA = "0x180A51B40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005A")]
			private struct <<AddDynamicNodeGroupSettingV2>b__6>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				public MIJEMKODMIF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000112")]
				private TaskAwaiter<LOAMJJJEMNF<JFIBBLJIDCN<FLAIMFHIJIM>, PLLHOMFPAAM>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000192")]
				[Cpp2IlInjected.Address(RVA = "0x40BEBD0", Offset = "0x40BDDD0", VA = "0x1840BEBD0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000193")]
				[Cpp2IlInjected.Address(RVA = "0xA51B40", Offset = "0xA50D40", VA = "0x180A51B40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005B")]
			private struct <<AddDynamicNodeGroupSettingV2>b__10>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000113")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000114")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000115")]
				public MIJEMKODMIF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000116")]
				private TaskAwaiter<LOAMJJJEMNF<JFIBBLJIDCN<HOEALKNOPIA>, PLLHOMFPAAM>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000194")]
				[Cpp2IlInjected.Address(RVA = "0x40BE330", Offset = "0x40BD530", VA = "0x1840BE330", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000195")]
				[Cpp2IlInjected.Address(RVA = "0xA51B40", Offset = "0xA50D40", VA = "0x180A51B40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public OODFLKOFLEK<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public JFIBBLJIDCN<IMLHFCPAHJM> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public KBGIAKLKLKJ configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public OOMLOHBOPAJ nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public DIDHPMBDBJK nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public int minGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public int maxGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public HLEKIDHKADJ selectedInputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public string newInputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public List<MHKCGDFIFFO> inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public HLEKIDHKADJ selectedOutputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public string newOutputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public List<MHKCGDFIFFO> outputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public Func<string, bool> <>9__17;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public MIJEMKODMIF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x52EB9E0", Offset = "0x52EABE0", VA = "0x1852EB9E0")]
			internal bool DPBKKCNFPCA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x52EBE60", Offset = "0x52EB060", VA = "0x1852EBE60")]
			internal void KCEAKLDCEGA(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x52EBD10", Offset = "0x52EAF10", VA = "0x1852EBD10")]
			internal bool INGGCPODGDA(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x52EBB80", Offset = "0x52EAD80", VA = "0x1852EBB80")]
			internal bool FBCHCJKAKFL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x52EB940", Offset = "0x52EAB40", VA = "0x1852EB940")]
			[AsyncStateMachine(typeof(OODFLKOFLEK<>.MIJEMKODMIF.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void DKANJGKGOKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x52EBCD0", Offset = "0x52EAED0", VA = "0x1852EBCD0")]
			internal bool GBHEHFGCEHE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x52EB690", Offset = "0x52EA890", VA = "0x1852EB690")]
			internal void AFPICIDEICN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x52EBC20", Offset = "0x52EAE20", VA = "0x1852EBC20")]
			internal bool FKOJEHCKIFE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x52EBA50", Offset = "0x52EAC50", VA = "0x1852EBA50")]
			internal void EDEBKGCFKON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x52EB7C0", Offset = "0x52EA9C0", VA = "0x1852EB7C0")]
			internal bool BLICLJAIEPK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x52EBB10", Offset = "0x52EAD10", VA = "0x1852EBB10")]
			internal bool EDLFHKLIPFK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x52EBDF0", Offset = "0x52EAFF0", VA = "0x1852EBDF0")]
			internal void JEHNGOKHONO(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x52EBED0", Offset = "0x52EB0D0", VA = "0x1852EBED0")]
			[AsyncStateMachine(typeof(OODFLKOFLEK<>.MIJEMKODMIF.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void MIBPBJDEECK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x52EBBC0", Offset = "0x52EADC0", VA = "0x1852EBBC0")]
			internal bool FGMIOBOPFJK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x52EB870", Offset = "0x52EAA70", VA = "0x1852EB870")]
			internal bool BOCOIJNBKHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x52EB750", Offset = "0x52EA950", VA = "0x1852EB750")]
			internal void AHMAKPFBKLJ(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x52EBF70", Offset = "0x52EB170", VA = "0x1852EBF70")]
			[AsyncStateMachine(typeof(OODFLKOFLEK<>.MIJEMKODMIF.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void MOHBLJKCFOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x52EB8E0", Offset = "0x52EAAE0", VA = "0x1852EB8E0")]
			internal bool DFONOCMNJNJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class AEHHJEPKHOF
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005D")]
			private struct <<AddDynamicNodeGroupSettingV2>b__16>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011D")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011E")]
				public AEHHJEPKHOF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011F")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000120")]
				private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x40BE620", Offset = "0x40BD820", VA = "0x1840BE620", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0xA51B40", Offset = "0xA50D40", VA = "0x180A51B40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public MIJEMKODMIF CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public Func<string> <>9__14;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public Action<string> <>9__15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public Action <>9__16;

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public AEHHJEPKHOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x4A7E1E0", Offset = "0x4A7D3E0", VA = "0x184A7E1E0")]
			internal void PGDIODCCEEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
			internal string IJMMCHDKGJF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
			internal void LBDGODBEGFD(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x4A7E140", Offset = "0x4A7D340", VA = "0x184A7E140")]
			[AsyncStateMachine(typeof(OODFLKOFLEK<>.AEHHJEPKHOF.<<AddDynamicNodeGroupSettingV2>b__16>d))]
			internal void GONOHKICFOL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		[CompilerGenerated]
		private sealed class KIKNEOCNJFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public DIDHPMBDBJK nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public List<MHKCGDFIFFO> portMenu;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public OODFLKOFLEK<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public JFIBBLJIDCN<IMLHFCPAHJM> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public int portCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public Func<bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public KIKNEOCNJFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x5015FE0", Offset = "0x50151E0", VA = "0x185015FE0")]
			internal bool BIDMBNNLPMC()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class DJMIBINNDHH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public DEEMKFDPNME port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public KIKNEOCNJFE CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public DJMIBINNDHH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x6A28DE0", Offset = "0x6A27FE0", VA = "0x186A28DE0")]
			internal void AHEMACHAFDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x6A28EF0", Offset = "0x6A280F0", VA = "0x186A28EF0")]
			internal bool GAKDIJNKKAH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x6A28F40", Offset = "0x6A28140", VA = "0x186A28F40")]
			internal void LEIDGBGGLJK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x6A29060", Offset = "0x6A28260", VA = "0x186A29060")]
			internal bool ONBMJNNDGCN()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000060")]
		[CompilerGenerated]
		private sealed class KJNAKOFGHDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public MHKCGDFIFFO portControls;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public DJMIBINNDHH CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public KJNAKOFGHDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x5018630", Offset = "0x5017830", VA = "0x185018630")]
			internal void ADHOCFMMIKD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class BPMLFBFHHKC
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000062")]
			private struct <<CreatePortItemV2>b__3>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000133")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000134")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000135")]
				public BPMLFBFHHKC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000136")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000137")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000138")]
				private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0x40C0660", Offset = "0x40BF860", VA = "0x1840C0660", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0xA51B40", Offset = "0xA50D40", VA = "0x180A51B40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public List<object> allTypeObjects;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public HLEKIDHKADJ selectedType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public DIDHPMBDBJK nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public DEEMKFDPNME port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public OOMLOHBOPAJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public BPMLFBFHHKC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x6161D10", Offset = "0x6160F10", VA = "0x186161D10")]
			internal int INGLEKOILNH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x6161920", Offset = "0x6160B20", VA = "0x186161920")]
			internal void DJBCGGHFIDE(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500")]
			internal string DOEAKBPHIIA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x6161C50", Offset = "0x6160E50", VA = "0x186161C50")]
			[AsyncStateMachine(typeof(OODFLKOFLEK<>.BPMLFBFHHKC.<<CreatePortItemV2>b__3>d))]
			internal void IDDDOFCFENP(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x6161B70", Offset = "0x6160D70", VA = "0x186161B70")]
			internal bool GONMJLPFIED(string text)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly Dictionary<JFIBBLJIDCN<IMLHFCPAHJM>, bool> PLMHHDAKBGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly Dictionary<JFIBBLJIDCN<IMLHFCPAHJM>, bool> CIHIPGBOONH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly Dictionary<JFIBBLJIDCN<IMLHFCPAHJM>, bool> KMIJHNFJOJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private Dictionary<JFIBBLJIDCN<IMLHFCPAHJM>, bool> DNFPIKKNLFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private Dictionary<JFIBBLJIDCN<IMLHFCPAHJM>, bool> IOGFJBJIJHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private Dictionary<JFIBBLJIDCN<IMLHFCPAHJM>, bool> PDJCJOIPHHB;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool FHGKEDBLDCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "136")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected virtual bool IJJLCFEJKJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		protected virtual bool IHLMMBHENIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "141")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		protected virtual bool AGFIBBOOAKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "142")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override JFIBBLJIDCN<JJGKIIIBOJJ>? NKMFGNAPIFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x5549270", Offset = "0x5548470", VA = "0x185549270", Slot = "130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override JFIBBLJIDCN<IMLHFCPAHJM>? LHMBHPHHJMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x5549520", Offset = "0x5548720", VA = "0x185549520", Slot = "133")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override IEnumerable<NICODLFMDAJ<PKEJDDGKOJK>>? EBJGONPBINF
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x5549320", Offset = "0x5548520", VA = "0x185549320", Slot = "125")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5549050", Offset = "0x5548250", VA = "0x185549050")]
		public OODFLKOFLEK(BMLBDHHGCHG CCCBLIDEHDI, TNode GCEDHPINDAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "143")]
		protected virtual bool ONHLMDDINGD(int ODLPNABGFEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "144")]
		protected virtual bool KIGMGMMHIMF(int ODLPNABGFEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "145")]
		protected virtual bool OEKPHLJLCDE(int ODLPNABGFEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "146")]
		protected virtual void AJHKCKNJBJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5544910", Offset = "0x5543B10", VA = "0x185544910", Slot = "138")]
		public override bool CHCGOHDLBBJ(JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5548EA0", Offset = "0x55480A0", VA = "0x185548EA0", Slot = "114")]
		[AsyncStateMachine(typeof(OODFLKOFLEK<>.FLEPEOPDOCL))]
		public override Task<LOAMJJJEMNF<JFIBBLJIDCN<IMLHFCPAHJM>, PLLHOMFPAAM>> LDCMFCGDIPG(string DGIAFBEDPNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x5548B30", Offset = "0x5547D30", VA = "0x185548B30", Slot = "115")]
		[AsyncStateMachine(typeof(OODFLKOFLEK<>.BFEBBAIKIPI))]
		public override Task<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> JMJHHIDJGGF(JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x5544700", Offset = "0x5543900", VA = "0x185544700", Slot = "116")]
		public override void BGMEPNMFAHE(JFIBBLJIDCN<IMLHFCPAHJM> NIBICIJAIGM, JFIBBLJIDCN<IMLHFCPAHJM> PJNHLGGHCLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5548C40", Offset = "0x5547E40", VA = "0x185548C40", Slot = "117")]
		public override IEnumerable<AGKENLKLGLL> KKCLLCBMLHN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5544BA0", Offset = "0x5543DA0", VA = "0x185544BA0")]
		[AsyncStateMachine(typeof(OODFLKOFLEK<>.IKPEPBJCNHM))]
		private Task<LOAMJJJEMNF<MKMBMMHDKHK, PLLHOMFPAAM>> CPIOJGBONAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "147")]
		protected virtual bool FJIDPGNNEMM(JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "148")]
		protected virtual bool GMKIAMFMEBL(JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "149")]
		protected virtual bool EGNLAFKPDNJ(JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "150")]
		protected virtual bool BMNAFLPPFEE(JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "151")]
		protected virtual bool MFPLAFOHPHG(JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG, int OFMFNBGBAML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "152")]
		protected virtual bool EPIBBCGGGAJ(JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG, int OFMFNBGBAML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "153")]
		protected virtual bool JDFNFKEHHPO(JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG, int KINJCIEBKLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "154")]
		protected virtual bool IDOPJLBKMHG(JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG, int KINJCIEBKLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "155")]
		protected virtual bool BKOMPOKJKND(JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG, int HIILHOHJDGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "156")]
		protected virtual bool PKGIEGIKECP(JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG, int ACPHKIIOJAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x5547760", Offset = "0x5546960", VA = "0x185547760", Slot = "157")]
		protected virtual List<HLEKIDHKADJ> GFFGICFGDJG(JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "158")]
		protected virtual void FLDIDFAOPJL(KBGIAKLKLKJ PHLPDDJGIJJ, CDELJENKLMB JHIFLFGBGCP, DIDHPMBDBJK MFIHIOCOPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x55455E0", Offset = "0x55447E0", VA = "0x1855455E0", Slot = "134")]
		protected override void DJABOMCCOKE(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x5546040", Offset = "0x5545240", VA = "0x185546040")]
		private CDELJENKLMB EGEKBKICLPL(KBGIAKLKLKJ PHLPDDJGIJJ, DIDHPMBDBJK MFIHIOCOPAI, JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x5547A00", Offset = "0x5546C00", VA = "0x185547A00")]
		private List<MHKCGDFIFFO> IGCPNKENPHJ(KBGIAKLKLKJ PHLPDDJGIJJ, DIDHPMBDBJK MFIHIOCOPAI, CDELJENKLMB GIIGAHONPBM, bool ADHCKOGOIAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x5544CA0", Offset = "0x5543EA0", VA = "0x185544CA0")]
		private List<MHKCGDFIFFO> DHNJGIEBGEJ(KBGIAKLKLKJ PHLPDDJGIJJ, DIDHPMBDBJK MFIHIOCOPAI, DEEMKFDPNME AKBKPEPJIKB, bool ADHCKOGOIAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x55449B0", Offset = "0x5543BB0", VA = "0x1855449B0")]
		private HLEKIDHKADJ CNHJPMFBDBE(List<HLEKIDHKADJ> INJDLPBPOAJ, DEEMKFDPNME AKBKPEPJIKB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x5548FC0", Offset = "0x55481C0", VA = "0x185548FC0")]
		[CompilerGenerated]
		private AGKENLKLGLL NAOCACMAMOH(CNJNPCHEFBN EOIAPGKFGAB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class FPCOJOCNDFO : NGBBBGMAMMH<AACLHCNIMMK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class LNJOMNJMLFM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public FPCOJOCNDFO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public OOMLOHBOPAJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public LNJOMNJMLFM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x2781C60", Offset = "0x2780E60", VA = "0x182781C60")]
			internal int JJHKHADFADH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x2781BD0", Offset = "0x2780DD0", VA = "0x182781BD0")]
			internal void FIJOLHGPAJJ(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey AFPMCDIFDOM
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x10DAED0", Offset = "0x10DA0D0", VA = "0x1810DAED0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x2776DE0", Offset = "0x2775FE0", VA = "0x182776DE0")]
		public FPCOJOCNDFO(BMLBDHHGCHG CCCBLIDEHDI, AACLHCNIMMK GCEDHPINDAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x2776C20", Offset = "0x2775E20", VA = "0x182776C20", Slot = "134")]
		protected override void DJABOMCCOKE(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public sealed class CCFNKMCBMJM : PPMLHFHFDEL<MAGDLBPKPEM>
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class KGKPDBBCCBD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public CCFNKMCBMJM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public OOMLOHBOPAJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public KGKPDBBCCBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x277CBB0", Offset = "0x277BDB0", VA = "0x18277CBB0")]
			internal int PHMIIEGBIFK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x277CB10", Offset = "0x277BD10", VA = "0x18277CB10")]
			internal void LLJCGKBIOBK(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2774350", Offset = "0x2773550", VA = "0x182774350")]
		public CCFNKMCBMJM(BMLBDHHGCHG CCCBLIDEHDI, MAGDLBPKPEM AHLPFPPNCPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2774110", Offset = "0x2773310", VA = "0x182774110", Slot = "140")]
		protected override void DBPPHPMJCAC(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private sealed class JGEAKGNOIGJ : NGBBBGMAMMH<OGDOOMABLJI>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey AFPMCDIFDOM
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xDA58B0", Offset = "0xDA4AB0", VA = "0x180DA58B0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x277A470", Offset = "0x2779670", VA = "0x18277A470")]
		public JGEAKGNOIGJ(BMLBDHHGCHG CCCBLIDEHDI, OGDOOMABLJI GCEDHPINDAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "134")]
		protected override void DJABOMCCOKE(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class JNOCOPAJAJN : NGBBBGMAMMH<DPOLMMBJFJP>
	{
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class AHCHIKCBELE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public JNOCOPAJAJN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public KBGIAKLKLKJ configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Func<string> <>9__224;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Action<string> <>9__225;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Func<int> <>9__228;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Action<int> <>9__229;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Func<bool> <>9__230;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<bool> <>9__231;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Func<bool> <>9__232;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Func<float> <>9__233;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public Action<float> <>9__234;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public Func<bool> <>9__235;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public Func<bool> <>9__236;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public Func<bool> <>9__237;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public Func<string> <>9__238;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public Action<string> <>9__239;

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public AHCHIKCBELE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x276E750", Offset = "0x276D950", VA = "0x18276E750")]
			internal bool JJHKHADFADH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x276D7B0", Offset = "0x276C9B0", VA = "0x18276D7B0")]
			internal void FIJOLHGPAJJ(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x276CC20", Offset = "0x276BE20", VA = "0x18276CC20")]
			internal bool EBLGFJDKHCO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x276FB90", Offset = "0x276ED90", VA = "0x18276FB90")]
			internal bool MOHKPNFBBHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x2765F00", Offset = "0x2765100", VA = "0x182765F00")]
			internal void BCBLAPKDEME(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x276E410", Offset = "0x276D610", VA = "0x18276E410")]
			internal bool IJENLOKLJJJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x276E7F0", Offset = "0x276D9F0", VA = "0x18276E7F0")]
			internal bool JLENOIANLCF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x276D680", Offset = "0x276C880", VA = "0x18276D680")]
			internal void FHCEBIEKIKJ(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x276D900", Offset = "0x276CB00", VA = "0x18276D900")]
			internal bool FOFGGAOBDEI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x27660B0", Offset = "0x27652B0", VA = "0x1827660B0")]
			internal bool BIFIFKAAENE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x276C550", Offset = "0x276B750", VA = "0x18276C550")]
			internal void CMPPBFMPBGN(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x276C740", Offset = "0x276B940", VA = "0x18276C740")]
			internal bool DBAHHJHIDBP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x276E5B0", Offset = "0x276D7B0", VA = "0x18276E5B0")]
			internal bool JBMHALHGJAJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x276DB30", Offset = "0x276CD30", VA = "0x18276DB30")]
			internal bool GFDAOFODIAG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x276D590", Offset = "0x276C790", VA = "0x18276D590")]
			internal bool FFFPIHDDPMI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x27706E0", Offset = "0x276F8E0", VA = "0x1827706E0")]
			internal bool PNLLEPECNAB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x276E600", Offset = "0x276D800", VA = "0x18276E600")]
			internal bool JDBGHJKMGLJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x276CB30", Offset = "0x276BD30", VA = "0x18276CB30")]
			internal bool DNLNOHODMFH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x2766210", Offset = "0x2765410", VA = "0x182766210")]
			internal bool BMKNIICDKMG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x276F740", Offset = "0x276E940", VA = "0x18276F740")]
			internal bool MHLJHMKKCLG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x276E650", Offset = "0x276D850", VA = "0x18276E650")]
			internal void JIDPLDCLBAM(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x276EC10", Offset = "0x276DE10", VA = "0x18276EC10")]
			internal bool KIMJCDKIGAK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x276DAE0", Offset = "0x276CCE0", VA = "0x18276DAE0")]
			internal bool GDKFBALLEDI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x276DCE0", Offset = "0x276CEE0", VA = "0x18276DCE0")]
			internal bool GKKFEBHNNEA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x276E200", Offset = "0x276D400", VA = "0x18276E200")]
			internal bool IDHNNABKFPH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x2765C60", Offset = "0x2764E60", VA = "0x182765C60")]
			internal bool AFFKIJPHELJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x276F250", Offset = "0x276E450", VA = "0x18276F250")]
			internal bool LMAGMDCIDBI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x276EB20", Offset = "0x276DD20", VA = "0x18276EB20")]
			internal bool KGLBFMGFMLC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x276DFA0", Offset = "0x276D1A0", VA = "0x18276DFA0")]
			internal bool HHHLHGIDLMF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x276E2F0", Offset = "0x276D4F0", VA = "0x18276E2F0")]
			internal void IHLCHOJMMDC(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x2765D50", Offset = "0x2764F50", VA = "0x182765D50")]
			internal bool ALHLMKFODLL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x276E840", Offset = "0x276DA40", VA = "0x18276E840")]
			internal bool JNHMGPKMPJJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x2766050", Offset = "0x2765250", VA = "0x182766050")]
			internal void BGEAONJDBGH(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x276E700", Offset = "0x276D900", VA = "0x18276E700")]
			internal bool JJDFKHHJIKK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x2765B20", Offset = "0x2764D20", VA = "0x182765B20")]
			internal bool ABEKKOHGDIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x276C4A0", Offset = "0x276B6A0", VA = "0x18276C4A0")]
			internal void CDEBLDMKFKI(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x2766320", Offset = "0x2765520", VA = "0x182766320")]
			internal List<MHKCGDFIFFO> BOCBBNLHNCG(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x276E950", Offset = "0x276DB50", VA = "0x18276E950")]
			internal bool KCJNDABDOIM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x2765DA0", Offset = "0x2764FA0", VA = "0x182765DA0")]
			internal int AMGFOLBNOBK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x276DF40", Offset = "0x276D140", VA = "0x18276DF40")]
			internal void HFLHNMLBMNC(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x276F5B0", Offset = "0x276E7B0", VA = "0x18276F5B0")]
			internal bool MEHHHFFADNK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x276EE40", Offset = "0x276E040", VA = "0x18276EE40")]
			internal bool KOEGPLNNNFB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x2765DF0", Offset = "0x2764FF0", VA = "0x182765DF0")]
			internal bool ANDEGLCLACI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x276DEF0", Offset = "0x276D0F0", VA = "0x18276DEF0")]
			internal int HAPJKACILBO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x276DDF0", Offset = "0x276CFF0", VA = "0x18276DDF0")]
			internal void GOCPOAFGIPG(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x27703C0", Offset = "0x276F5C0", VA = "0x1827703C0")]
			internal bool OJDIIBBJIFJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x276CC70", Offset = "0x276BE70", VA = "0x18276CC70")]
			internal bool EEDLGNHBAMH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x276D860", Offset = "0x276CA60", VA = "0x18276D860")]
			internal bool FJKJAGPIBKO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x276F560", Offset = "0x276E760", VA = "0x18276F560")]
			internal bool MDEPMLGFOGA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x276C650", Offset = "0x276B850", VA = "0x18276C650")]
			internal bool COICEECMPFE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x276DA40", Offset = "0x276CC40", VA = "0x18276DA40")]
			internal bool GANGHKLLHJA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x276FD30", Offset = "0x276EF30", VA = "0x18276FD30")]
			internal string NCPLNJKHAKL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x276D4D0", Offset = "0x276C6D0", VA = "0x18276D4D0")]
			internal void FCMDACKOPDH(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x276EDF0", Offset = "0x276DFF0", VA = "0x18276EDF0")]
			internal int KOCOBHNKCCI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x276D470", Offset = "0x276C670", VA = "0x18276D470")]
			internal void FBCIFBKFMPC(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x276C3E0", Offset = "0x276B5E0", VA = "0x18276C3E0")]
			internal bool CCJLHJOBIOJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x276DFF0", Offset = "0x276D1F0", VA = "0x18276DFF0")]
			internal bool HMMHDBFFFGL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x276C6A0", Offset = "0x276B8A0", VA = "0x18276C6A0")]
			internal bool CPACKNCBPIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x2765D00", Offset = "0x2764F00", VA = "0x182765D00")]
			internal float AJMIDINODJP()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x2770730", Offset = "0x276F930", VA = "0x182770730")]
			internal void POHGLIGOGCD(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x27662D0", Offset = "0x27654D0", VA = "0x1827662D0")]
			internal bool BNHHACKPJCG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x27707E0", Offset = "0x276F9E0", VA = "0x1827707E0")]
			internal bool POOPNIMMNIA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x276FC40", Offset = "0x276EE40", VA = "0x18276FC40")]
			internal bool MPNPEBDDGMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x276ED00", Offset = "0x276DF00", VA = "0x18276ED00")]
			internal bool KMOEAHJEPFA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x276FD80", Offset = "0x276EF80", VA = "0x18276FD80")]
			internal bool NDEKHBGEOFF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x2770500", Offset = "0x276F700", VA = "0x182770500")]
			internal bool PBDNLHNANMN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x276CFE0", Offset = "0x276C1E0", VA = "0x18276CFE0")]
			internal void EPEJNOOKGNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x276F1B0", Offset = "0x276E3B0", VA = "0x18276F1B0")]
			internal string LIFFCIFIEDH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x276E890", Offset = "0x276DA90", VA = "0x18276E890")]
			internal void JPDIMDJEAGG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x2770150", Offset = "0x276F350", VA = "0x182770150")]
			internal bool OAMIDPOCBFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x2770790", Offset = "0x276F990", VA = "0x182770790")]
			internal bool POLCFGGALHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x276C9E0", Offset = "0x276BBE0", VA = "0x18276C9E0")]
			internal bool DKILPFJOJDE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x276F8D0", Offset = "0x276EAD0", VA = "0x18276F8D0")]
			internal void MNNLIOHHLEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x276CE80", Offset = "0x276C080", VA = "0x18276CE80")]
			internal bool EKGFEHBANKD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x2770640", Offset = "0x276F840", VA = "0x182770640")]
			internal bool PJBLLGGFJPM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x276F6A0", Offset = "0x276E8A0", VA = "0x18276F6A0")]
			internal bool MHBCNPLFDNA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x276FFD0", Offset = "0x276F1D0", VA = "0x18276FFD0")]
			internal bool NKNPFGMAFML()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x276E550", Offset = "0x276D750", VA = "0x18276E550")]
			internal void JBDNINCNBEI(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x276C6F0", Offset = "0x276B8F0", VA = "0x18276C6F0")]
			internal bool DAOFEPIDHOO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x276E900", Offset = "0x276DB00", VA = "0x18276E900")]
			internal bool KBMKEBIGKOM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x276E090", Offset = "0x276D290", VA = "0x18276E090")]
			internal bool HNAABDCKOMI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x276CE30", Offset = "0x276C030", VA = "0x18276CE30")]
			internal bool EJPJEDKPANE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x276E150", Offset = "0x276D350", VA = "0x18276E150")]
			internal void IACMCBGBGIB(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x276EEE0", Offset = "0x276E0E0", VA = "0x18276EEE0")]
			internal bool LBEPCPJIPNB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x276ECB0", Offset = "0x276DEB0", VA = "0x18276ECB0")]
			internal bool KKPDALPLGEF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x276D540", Offset = "0x276C740", VA = "0x18276D540")]
			internal bool FECAEECAPMA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x2765CB0", Offset = "0x2764EB0", VA = "0x182765CB0")]
			internal bool AJFOPHKDFOB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x2765AB0", Offset = "0x2764CB0", VA = "0x182765AB0")]
			internal object AAGOBOCJEOF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x276F3D0", Offset = "0x276E5D0", VA = "0x18276F3D0")]
			internal void LOKOGNDPKMN(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x276F790", Offset = "0x276E990", VA = "0x18276F790")]
			internal bool MJLNNOKLMFO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x276EAD0", Offset = "0x276DCD0", VA = "0x18276EAD0")]
			internal bool KFOLDFJMAJP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x276EF80", Offset = "0x276E180", VA = "0x18276EF80")]
			internal int LBNOLGCAAHJ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x276FF20", Offset = "0x276F120", VA = "0x18276FF20")]
			internal void NHHMNDHMAOP(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x27705F0", Offset = "0x276F7F0", VA = "0x1827705F0")]
			internal bool PFFNDAAEPKB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x276FE30", Offset = "0x276F030", VA = "0x18276FE30")]
			internal bool NECOECPAKGE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x276FE80", Offset = "0x276F080", VA = "0x18276FE80")]
			internal int NEJLDLCBLOG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x276CD80", Offset = "0x276BF80", VA = "0x18276CD80")]
			internal void EJHNGNPIBMI(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x276EC60", Offset = "0x276DE60", VA = "0x18276EC60")]
			internal bool KINKPIKGKIH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x2770240", Offset = "0x276F440", VA = "0x182770240")]
			internal bool ODFJKHBDAMH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x276C600", Offset = "0x276B800", VA = "0x18276C600")]
			internal bool COELCHBIBJD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x276F0C0", Offset = "0x276E2C0", VA = "0x18276F0C0")]
			internal int LGJIOCHEKFH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x276DD90", Offset = "0x276CF90", VA = "0x18276DD90")]
			internal void GNLFOAMPBII(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x276C340", Offset = "0x276B540", VA = "0x18276C340")]
			internal bool BOKDOHLEDBA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x276F600", Offset = "0x276E800", VA = "0x18276F600")]
			internal bool MGADDFOHDHL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x276E500", Offset = "0x276D700", VA = "0x18276E500")]
			internal bool JAPKIGBMDKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x276D740", Offset = "0x276C940", VA = "0x18276D740")]
			internal object FHFDLJBCDIA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x2770070", Offset = "0x276F270", VA = "0x182770070")]
			internal void NPFLFANPDMD(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x2765C10", Offset = "0x2764E10", VA = "0x182765C10")]
			internal bool ADMELBPCHAK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x276C7E0", Offset = "0x276B9E0", VA = "0x18276C7E0")]
			internal bool DCLNCMKKHJP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x2766100", Offset = "0x2765300", VA = "0x182766100")]
			internal object BKDGKLHMNJG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x276E9F0", Offset = "0x276DBF0", VA = "0x18276E9F0")]
			internal void KDGCFAMFACA(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x276DC90", Offset = "0x276CE90", VA = "0x18276DC90")]
			internal bool GJBMBJNIACA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x276E040", Offset = "0x276D240", VA = "0x18276E040")]
			internal int HMONPDNODPG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x276FDD0", Offset = "0x276EFD0", VA = "0x18276FDD0")]
			internal void NDHHCPDHKAO(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x2770550", Offset = "0x276F750", VA = "0x182770550")]
			internal bool PBIEPMAFJOF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x276C990", Offset = "0x276BB90", VA = "0x18276C990")]
			internal bool DKANAOFKELB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x276CBD0", Offset = "0x276BDD0", VA = "0x18276CBD0")]
			internal bool DPBIBOCHBOI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x2770290", Offset = "0x276F490", VA = "0x182770290")]
			internal int OEFLHMBAAPE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x276D6E0", Offset = "0x276C8E0", VA = "0x18276D6E0")]
			internal void FHCJBCLHEJM(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x276F880", Offset = "0x276EA80", VA = "0x18276F880")]
			internal bool MMJAIALEGKO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x2770690", Offset = "0x276F890", VA = "0x182770690")]
			internal bool PMIJHMBBABE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x276F2A0", Offset = "0x276E4A0", VA = "0x18276F2A0")]
			internal bool LMEAIEJCKBG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x276CF20", Offset = "0x276C120", VA = "0x18276CF20")]
			internal float ELAGFIJOHFG()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x276CAD0", Offset = "0x276BCD0", VA = "0x18276CAD0")]
			internal void DNDEKHODAJF(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x276D950", Offset = "0x276CB50", VA = "0x18276D950")]
			internal bool FOJGAPOJCHK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x276C790", Offset = "0x276B990", VA = "0x18276C790")]
			internal bool DBFCGECPDLA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x276D810", Offset = "0x276CA10", VA = "0x18276D810")]
			internal bool FJIBLAJFNNI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x2765E40", Offset = "0x2765040", VA = "0x182765E40")]
			internal float AOJLBOAGKBG()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x276FBE0", Offset = "0x276EDE0", VA = "0x18276FBE0")]
			internal void MPFPCPCNGDJ(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x276DC40", Offset = "0x276CE40", VA = "0x18276DC40")]
			internal bool GICGLAAGJPB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x2770410", Offset = "0x276F610", VA = "0x182770410")]
			internal bool OKIHFOBBBNC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x2765BC0", Offset = "0x2764DC0", VA = "0x182765BC0")]
			internal string ABLLPCCCHBD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x2770350", Offset = "0x276F550", VA = "0x182770350")]
			internal void OIIHBKBEBOM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x276F160", Offset = "0x276E360", VA = "0x18276F160")]
			internal bool LIBPNMDHGFD(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x276CCC0", Offset = "0x276BEC0", VA = "0x18276CCC0")]
			internal bool EEKMAEKMOMG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x276D420", Offset = "0x276C620", VA = "0x18276D420")]
			internal bool EPPAJIIBIOL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x2770460", Offset = "0x276F660", VA = "0x182770460")]
			internal bool OKMMCGKBBIM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x2766000", Offset = "0x2765200", VA = "0x182766000")]
			internal string BEKKLHHJHHP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x276F360", Offset = "0x276E560", VA = "0x18276F360")]
			internal void LMKFPANDOKJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x276E4B0", Offset = "0x276D6B0", VA = "0x18276E4B0")]
			internal bool IPHLHEAMNHK(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x2765B70", Offset = "0x2764D70", VA = "0x182765B70")]
			internal bool ABJBMHKOIHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x276E6B0", Offset = "0x276D8B0", VA = "0x18276E6B0")]
			internal bool JILOJCDIBFF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x276FCE0", Offset = "0x276EEE0", VA = "0x18276FCE0")]
			internal bool NBHLOONLMHN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x276FED0", Offset = "0x276F0D0", VA = "0x18276FED0")]
			internal string NFOELBBFEBC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x2766260", Offset = "0x2765460", VA = "0x182766260")]
			internal void BNBJLLNAIBA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x276E9A0", Offset = "0x276DBA0", VA = "0x18276E9A0")]
			internal bool KCONADLGCHN(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x276F650", Offset = "0x276E850", VA = "0x18276F650")]
			internal bool MGJIBJJILKH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x276E7A0", Offset = "0x276D9A0", VA = "0x18276E7A0")]
			internal bool JLAKLMJLPDI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x276EB70", Offset = "0x276DD70", VA = "0x18276EB70")]
			internal bool KHOPLOILHDJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x276EA80", Offset = "0x276DC80", VA = "0x18276EA80")]
			internal string KEJPHCEDBKK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x276C430", Offset = "0x276B630", VA = "0x18276C430")]
			internal void CCPCOBMODHA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x276D8B0", Offset = "0x276CAB0", VA = "0x18276D8B0")]
			internal bool FJOGOJPKCEF(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x276DB80", Offset = "0x276CD80", VA = "0x18276DB80")]
			internal bool GFDCEGHMELE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x276E460", Offset = "0x276D660", VA = "0x18276E460")]
			internal bool IOGFDPOPMCB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x276EBC0", Offset = "0x276DDC0", VA = "0x18276EBC0")]
			internal bool KICIGFCNKMF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x276DE50", Offset = "0x276D050", VA = "0x18276DE50")]
			internal string GPJMLGMLGBI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x276C880", Offset = "0x276BA80", VA = "0x18276C880")]
			internal void DFENFDDLFAN(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x276F070", Offset = "0x276E270", VA = "0x18276F070")]
			internal bool LGDMGAKMFOF(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x276EDA0", Offset = "0x276DFA0", VA = "0x18276EDA0")]
			internal bool KOCBBHEMODO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x2765FB0", Offset = "0x27651B0", VA = "0x182765FB0")]
			internal bool BEBPMJOCLOE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x276E350", Offset = "0x276D550", VA = "0x18276E350")]
			internal bool IIAGILCGJKJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x276FF80", Offset = "0x276F180", VA = "0x18276FF80")]
			internal string NJOHPLFHAGN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x276CF70", Offset = "0x276C170", VA = "0x18276CF70")]
			internal void EMIMICHGAGL(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x276C940", Offset = "0x276BB40", VA = "0x18276C940")]
			internal bool DJLDHALOBAN(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x276D5E0", Offset = "0x276C7E0", VA = "0x18276D5E0")]
			internal bool FFHGFDNFGMA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x276F020", Offset = "0x276E220", VA = "0x18276F020")]
			internal bool LDAEEGCLNOG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x276EF30", Offset = "0x276E130", VA = "0x18276EF30")]
			internal bool LBJIIEPLCOB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x276C500", Offset = "0x276B700", VA = "0x18276C500")]
			internal string CGHKFMJLFHH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x276E3A0", Offset = "0x276D5A0", VA = "0x18276E3A0")]
			internal void IILPCLPFKIA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x27661C0", Offset = "0x27653C0", VA = "0x1827661C0")]
			internal bool BMAPFKAOJEM(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x2770100", Offset = "0x276F300", VA = "0x182770100")]
			internal bool NPPGEHJKPMC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x27704B0", Offset = "0x276F6B0", VA = "0x1827704B0")]
			internal bool OOPKBCGJDGP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x276F200", Offset = "0x276E400", VA = "0x18276F200")]
			internal bool LIGPEKGEJLI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x276CDE0", Offset = "0x276BFE0", VA = "0x18276CDE0")]
			internal string EJMDIBFODFB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x276CD10", Offset = "0x276BF10", VA = "0x18276CD10")]
			internal void EEMMHOOHDGA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x276D9F0", Offset = "0x276CBF0", VA = "0x18276D9F0")]
			internal bool GAFFOGBNBDA(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x2770020", Offset = "0x276F220", VA = "0x182770020")]
			internal bool NOJADMLMMJF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x2765F60", Offset = "0x2765160", VA = "0x182765F60")]
			internal bool BDDBGKKINJL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x276FC90", Offset = "0x276EE90", VA = "0x18276FC90")]
			internal bool NBCDGHGNDCI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x276DEA0", Offset = "0x276D0A0", VA = "0x18276DEA0")]
			internal string GPKNIOEHJGD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x276E0E0", Offset = "0x276D2E0", VA = "0x18276E0E0")]
			internal void HNPKMDPPPFJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x276C5B0", Offset = "0x276B7B0", VA = "0x18276C5B0")]
			internal bool CODFHMNEDGK(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x276DA90", Offset = "0x276CC90", VA = "0x18276DA90")]
			internal bool GCHEMDNBJJP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x276E250", Offset = "0x276D450", VA = "0x18276E250")]
			internal bool IGKLPGOHBIP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x276CED0", Offset = "0x276C0D0", VA = "0x18276CED0")]
			internal bool EKKJDMMLBCL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x276E2A0", Offset = "0x276D4A0", VA = "0x18276E2A0")]
			internal string IGLJDCAMDGM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x276F2F0", Offset = "0x276E4F0", VA = "0x18276F2F0")]
			internal void LMIDGKIPGLM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x276EFD0", Offset = "0x276E1D0", VA = "0x18276EFD0")]
			internal bool LCAAMMKPGPM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x2766170", Offset = "0x2765370", VA = "0x182766170")]
			internal bool BKIEPLNJCPP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x276C830", Offset = "0x276BA30", VA = "0x18276C830")]
			internal bool DDLEBCLPDOF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x276D630", Offset = "0x276C830", VA = "0x18276D630")]
			internal string FGELOCDNIKC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x276DBD0", Offset = "0x276CDD0", VA = "0x18276DBD0")]
			internal void GHMEOEKNMBC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x276E1B0", Offset = "0x276D3B0", VA = "0x18276E1B0")]
			internal bool IALEAKKHAEJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x276F6F0", Offset = "0x276E8F0", VA = "0x18276F6F0")]
			internal bool MHHBKMBOJDE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x27701F0", Offset = "0x276F3F0", VA = "0x1827701F0")]
			internal bool OBNBJCJJFID()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x276C390", Offset = "0x276B590", VA = "0x18276C390")]
			internal string BPKPGEDHDEG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x27702E0", Offset = "0x276F4E0", VA = "0x1827702E0")]
			internal void OFKMLBEPPKJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x276F510", Offset = "0x276E710", VA = "0x18276F510")]
			internal bool MBJEEBEJHBG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x276D9A0", Offset = "0x276CBA0", VA = "0x18276D9A0")]
			internal bool GACFBBMAEFM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x27701A0", Offset = "0x276F3A0", VA = "0x1827701A0")]
			internal bool OBHDIFPAAPP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x276F110", Offset = "0x276E310", VA = "0x18276F110")]
			internal string LHDOJONEGDD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x2765E90", Offset = "0x2765090", VA = "0x182765E90")]
			internal void BAFBJCCNPOK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x276F830", Offset = "0x276EA30", VA = "0x18276F830")]
			internal bool MLEKKFCGMEE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x276C8F0", Offset = "0x276BAF0", VA = "0x18276C8F0")]
			internal bool DGKNBHLFLAL(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x276CA30", Offset = "0x276BC30", VA = "0x18276CA30")]
			internal float DKNNJOGCCIA()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x276F460", Offset = "0x276E660", VA = "0x18276F460")]
			internal void MADEHAGKKMN(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x276EE90", Offset = "0x276E090", VA = "0x18276EE90")]
			internal bool KPMMKDMAAAN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x27705A0", Offset = "0x276F7A0", VA = "0x1827705A0")]
			internal bool PBPBBKLGNMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x276F7E0", Offset = "0x276E9E0", VA = "0x18276F7E0")]
			internal bool MKKMBJDOAMF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x276CB80", Offset = "0x276BD80", VA = "0x18276CB80")]
			internal int DOGIMKBPDAG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x276DD30", Offset = "0x276CF30", VA = "0x18276DD30")]
			internal void GNGMOGNOPKL(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x276CA80", Offset = "0x276BC80", VA = "0x18276CA80")]
			internal bool DMLNCBEJHEM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x276F4C0", Offset = "0x276E6C0", VA = "0x18276F4C0")]
			internal bool MBCLNENICBD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0x276ED50", Offset = "0x276DF50", VA = "0x18276ED50")]
			internal bool KNFDCNCDJFB()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class GEJDHMBGNIN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public AHCHIKCBELE CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public GEJDHMBGNIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x2794E00", Offset = "0x2794000", VA = "0x182794E00")]
			internal void GPOJOAEDCKG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class JNANAAAPGDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public JNANAAAPGDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x2799320", Offset = "0x2798520", VA = "0x182799320")]
			internal bool LKCOMBHKFJP(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private readonly DMJADDJKIFI CHHGPBBEOBM;

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x277C210", Offset = "0x277B410", VA = "0x18277C210")]
		public JNOCOPAJAJN(BMLBDHHGCHG CCCBLIDEHDI, DPOLMMBJFJP GCEDHPINDAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x277A4E0", Offset = "0x27796E0", VA = "0x18277A4E0", Slot = "134")]
		protected override void DJABOMCCOKE(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public sealed class NBFNGCLNJAF : NGBBBGMAMMH<PHDCIABFLIG>
	{
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private sealed class ENDPCIOIJNG
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006F")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400017B")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400017C")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				public ENDPCIOIJNG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000180")]
				private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002CA")]
				[Cpp2IlInjected.Address(RVA = "0x27A3B70", Offset = "0x27A2D70", VA = "0x1827A3B70", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002CB")]
				[Cpp2IlInjected.Address(RVA = "0xA51B40", Offset = "0xA50D40", VA = "0x180A51B40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public NBFNGCLNJAF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public OOMLOHBOPAJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public ENDPCIOIJNG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x2792DA0", Offset = "0x2791FA0", VA = "0x182792DA0")]
			internal string JJHKHADFADH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x2792CD0", Offset = "0x2791ED0", VA = "0x182792CD0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void FIJOLHGPAJJ(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x2792C80", Offset = "0x2791E80", VA = "0x182792C80")]
			internal int CMLNADHEAEF()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x2792DF0", Offset = "0x2791FF0", VA = "0x182792DF0")]
			internal void KPPJIHPOEEL(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey AFPMCDIFDOM
		{
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x10DAED0", Offset = "0x10DA0D0", VA = "0x1810DAED0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x27A1330", Offset = "0x27A0530", VA = "0x1827A1330")]
		public NBFNGCLNJAF(BMLBDHHGCHG CCCBLIDEHDI, PHDCIABFLIG AHLPFPPNCPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x27A0FD0", Offset = "0x27A01D0", VA = "0x1827A0FD0", Slot = "134")]
		protected override void DJABOMCCOKE(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public sealed class BNLINDMLMOB : NGBBBGMAMMH<GFMFEMBPHJI>
	{
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private sealed class GKNOBCJNMKB
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000072")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000183")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000184")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000185")]
				public GKNOBCJNMKB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000188")]
				private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002DF")]
				[Cpp2IlInjected.Address(RVA = "0x27A3830", Offset = "0x27A2A30", VA = "0x1827A3830", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E0")]
				[Cpp2IlInjected.Address(RVA = "0xA51B40", Offset = "0xA50D40", VA = "0x180A51B40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000073")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000189")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400018A")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400018B")]
				public GKNOBCJNMKB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400018C")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400018D")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400018E")]
				private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002E1")]
				[Cpp2IlInjected.Address(RVA = "0x27A3E80", Offset = "0x27A3080", VA = "0x1827A3E80", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E2")]
				[Cpp2IlInjected.Address(RVA = "0xA51B40", Offset = "0xA50D40", VA = "0x180A51B40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public BNLINDMLMOB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public OOMLOHBOPAJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public GKNOBCJNMKB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x2795EE0", Offset = "0x27950E0", VA = "0x182795EE0")]
			internal string JJHKHADFADH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x2795CC0", Offset = "0x2794EC0", VA = "0x182795CC0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void FIJOLHGPAJJ(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x2795AF0", Offset = "0x2794CF0", VA = "0x182795AF0")]
			internal int CMLNADHEAEF()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x2795F80", Offset = "0x2795180", VA = "0x182795F80")]
			internal void KPPJIHPOEEL(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x2795BE0", Offset = "0x2794DE0", VA = "0x182795BE0")]
			internal string EBLGFJDKHCO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x2796010", Offset = "0x2795210", VA = "0x182796010")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void MOHKPNFBBHA(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x2795AA0", Offset = "0x2794CA0", VA = "0x182795AA0")]
			internal bool BCBLAPKDEME()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x2795A10", Offset = "0x2794C10", VA = "0x182795A10")]
			internal void ANJLBEPLFDL(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x2795E00", Offset = "0x2795000", VA = "0x182795E00")]
			internal bool IEFENCHJKFN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x2795E50", Offset = "0x2795050", VA = "0x182795E50")]
			internal void IJENLOKLJJJ(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x2795F30", Offset = "0x2795130", VA = "0x182795F30")]
			internal float JLENOIANLCF()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x2795C30", Offset = "0x2794E30", VA = "0x182795C30")]
			internal void FHCEBIEKIKJ(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x27959B0", Offset = "0x2794BB0", VA = "0x1827959B0")]
			internal int AKFJCEDHJDA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x2795B40", Offset = "0x2794D40", VA = "0x182795B40")]
			internal void DBJNPDPJPOH(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x2795D90", Offset = "0x2794F90", VA = "0x182795D90")]
			internal bool FOFGGAOBDEI()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override NodeVisualizationKey AFPMCDIFDOM
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x10DAED0", Offset = "0x10DA0D0", VA = "0x1810DAED0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x2786660", Offset = "0x2785860", VA = "0x182786660")]
		public BNLINDMLMOB(BMLBDHHGCHG CCCBLIDEHDI, GFMFEMBPHJI GCEDHPINDAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x2785C80", Offset = "0x2784E80", VA = "0x182785C80", Slot = "134")]
		protected override void DJABOMCCOKE(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public sealed class NPPAIJBLMHH : NGBBBGMAMMH<DDEPMBAJKIO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private sealed class NOMDGNGHACC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public OOMLOHBOPAJ nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public NPPAIJBLMHH <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public NOMDGNGHACC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x27A2910", Offset = "0x27A1B10", VA = "0x1827A2910")]
			internal Dictionary<string, IENBLMBPDPG> JJHKHADFADH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x27A28C0", Offset = "0x27A1AC0", VA = "0x1827A28C0")]
			internal int FIJOLHGPAJJ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x27A2790", Offset = "0x27A1990", VA = "0x1827A2790")]
			internal void CMLNADHEAEF(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x27A29B0", Offset = "0x27A1BB0", VA = "0x1827A29B0")]
			internal bool KPPJIHPOEEL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override NodeVisualizationKey AFPMCDIFDOM
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x10DAED0", Offset = "0x10DA0D0", VA = "0x1810DAED0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x27A2D00", Offset = "0x27A1F00", VA = "0x1827A2D00")]
		public NPPAIJBLMHH(BMLBDHHGCHG CCCBLIDEHDI, DDEPMBAJKIO AHLPFPPNCPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x27A2A30", Offset = "0x27A1C30", VA = "0x1827A2A30", Slot = "134")]
		protected override void DJABOMCCOKE(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public sealed class CHFDBPNKBIL : NGBBBGMAMMH<CHAPLHGFMCN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private sealed class FFAIJJOBKLA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public OOMLOHBOPAJ nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public CHFDBPNKBIL <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public FFAIJJOBKLA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x27934A0", Offset = "0x27926A0", VA = "0x1827934A0")]
			internal void JJHKHADFADH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override NodeVisualizationKey AFPMCDIFDOM
		{
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x10DAED0", Offset = "0x10DA0D0", VA = "0x1810DAED0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x2788DC0", Offset = "0x2787FC0", VA = "0x182788DC0")]
		public CHFDBPNKBIL(BMLBDHHGCHG CCCBLIDEHDI, CHAPLHGFMCN AHLPFPPNCPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x2788C40", Offset = "0x2787E40", VA = "0x182788C40", Slot = "134")]
		protected override void DJABOMCCOKE(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class BLDNCNLBDLO<TNode> : OODFLKOFLEK<TNode> where TNode : notnull, EHJKCCEJMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override bool KNDAPENNKEH
		{
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "107")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override OMKDBELPALG? AHGFJFEEHDB
		{
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x5F72170", Offset = "0x5F71370", VA = "0x185F72170", Slot = "124")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override bool NPILGMGCOMC
		{
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x5F721E0", Offset = "0x5F713E0", VA = "0x185F721E0", Slot = "131")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override NodeVisualizationKey AFPMCDIFDOM
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xD955C0", Offset = "0xD947C0", VA = "0x180D955C0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x585A470", Offset = "0x5859670", VA = "0x18585A470")]
		public BLDNCNLBDLO(BMLBDHHGCHG CCCBLIDEHDI, TNode GCEDHPINDAM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class IENPCPBCOBM : BLDNCNLBDLO<FPEGFHFCMNL>
	{
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		[CompilerGenerated]
		private sealed class HONHKNCGBLF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public IENPCPBCOBM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public OOMLOHBOPAJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public HONHKNCGBLF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x2798380", Offset = "0x2797580", VA = "0x182798380")]
			internal object JJHKHADFADH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x27982B0", Offset = "0x27974B0", VA = "0x1827982B0")]
			internal void FIJOLHGPAJJ(object v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x27981C0", Offset = "0x27973C0", VA = "0x1827981C0")]
			internal void CMLNADHEAEF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private static object[]? LDFLFAAEPJH;

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x2798A00", Offset = "0x2797C00", VA = "0x182798A00")]
		public IENPCPBCOBM(BMLBDHHGCHG CCCBLIDEHDI, FPEGFHFCMNL GCEDHPINDAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x2798460", Offset = "0x2797660", VA = "0x182798460", Slot = "134")]
		protected override void DJABOMCCOKE(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private sealed class GPHNHJJIDIP : NGBBBGMAMMH<FKLMCDANKEF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override NodeVisualizationKey AFPMCDIFDOM
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0xC99980", Offset = "0xC98B80", VA = "0x180C99980", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x27966E0", Offset = "0x27958E0", VA = "0x1827966E0")]
		public GPHNHJJIDIP(BMLBDHHGCHG CCCBLIDEHDI, FKLMCDANKEF GCEDHPINDAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "134")]
		protected override void DJABOMCCOKE(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private sealed class CGIHKJKIPID : NGBBBGMAMMH<BDIOCEFPNHF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override NodeVisualizationKey AFPMCDIFDOM
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0xBDBAC0", Offset = "0xBDACC0", VA = "0x180BDBAC0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x2787F10", Offset = "0x2787110", VA = "0x182787F10")]
		public CGIHKJKIPID(BMLBDHHGCHG CCCBLIDEHDI, BDIOCEFPNHF GCEDHPINDAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "126")]
		protected override bool MJGKLEIAAIJ(JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "134")]
		protected override void DJABOMCCOKE(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private sealed class OLIFFMMEPFA : NGBBBGMAMMH<NGJEDJAIFGH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override NodeVisualizationKey AFPMCDIFDOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0xBC9F20", Offset = "0xBC9120", VA = "0x180BC9F20", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool HDDJIMJPNIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x27A31F0", Offset = "0x27A23F0", VA = "0x1827A31F0", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		protected override bool MMLNLDLEOFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x27A3180", Offset = "0x27A2380", VA = "0x1827A3180")]
		public OLIFFMMEPFA(BMLBDHHGCHG CCCBLIDEHDI, NGJEDJAIFGH GCEDHPINDAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "134")]
		protected override void DJABOMCCOKE(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class AEAKNLOKJBC : NGBBBGMAMMH<NCNCGNGKHBN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override NodeVisualizationKey AFPMCDIFDOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0xBE5C50", Offset = "0xBE4E50", VA = "0x180BE5C50", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override bool HDDJIMJPNIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x2784C40", Offset = "0x2783E40", VA = "0x182784C40", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		protected override bool MMLNLDLEOFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x2784BD0", Offset = "0x2783DD0", VA = "0x182784BD0")]
		public AEAKNLOKJBC(BMLBDHHGCHG CCCBLIDEHDI, NCNCGNGKHBN GCEDHPINDAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "134")]
		protected override void DJABOMCCOKE(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public sealed class KHODMMGGBAB : PPMLHFHFDEL<HHPIAOOFAAC>
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class COLFLEACHGE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public KHODMMGGBAB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public OOMLOHBOPAJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public COLFLEACHGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x2791610", Offset = "0x2790810", VA = "0x182791610")]
			internal float PHMIIEGBIFK()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x2791570", Offset = "0x2790770", VA = "0x182791570")]
			internal void LLJCGKBIOBK(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x2799890", Offset = "0x2798A90", VA = "0x182799890")]
		public KHODMMGGBAB(BMLBDHHGCHG CCCBLIDEHDI, HHPIAOOFAAC AHLPFPPNCPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x2799610", Offset = "0x2798810", VA = "0x182799610", Slot = "140")]
		protected override void DBPPHPMJCAC(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public sealed class EOGFPLNPDGC : NGBBBGMAMMH<AILGDMPGAKE>
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		[CompilerGenerated]
		private sealed class BOJCEFPFKGO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public EOGFPLNPDGC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public OOMLOHBOPAJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public BOJCEFPFKGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x2786800", Offset = "0x2785A00", VA = "0x182786800")]
			internal bool JJHKHADFADH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x27866D0", Offset = "0x27858D0", VA = "0x1827866D0")]
			internal void FIJOLHGPAJJ(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x2793130", Offset = "0x2792330", VA = "0x182793130")]
		public EOGFPLNPDGC(BMLBDHHGCHG CCCBLIDEHDI, AILGDMPGAKE AHLPFPPNCPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x2792E80", Offset = "0x2792080", VA = "0x182792E80", Slot = "134")]
		protected override void DJABOMCCOKE(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class NKIMPNLGOOK : NGBBBGMAMMH<FOGEDALIHDN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		[CompilerGenerated]
		private sealed class EGMMGBMAMLK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public OOMLOHBOPAJ nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public NKIMPNLGOOK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public EGMMGBMAMLK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x2792A50", Offset = "0x2791C50", VA = "0x182792A50")]
			internal object JJHKHADFADH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x2792470", Offset = "0x2791670", VA = "0x182792470")]
			internal bool ANJLBEPLFDL(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x27927F0", Offset = "0x27919F0", VA = "0x1827927F0")]
			internal void FIJOLHGPAJJ(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x2792620", Offset = "0x2791820", VA = "0x182792620")]
			internal string CMLNADHEAEF(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x2792B80", Offset = "0x2791D80", VA = "0x182792B80")]
			internal IReadOnlyList<object> KPPJIHPOEEL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x2792780", Offset = "0x2791980", VA = "0x182792780")]
			internal bool EBLGFJDKHCO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x2792BD0", Offset = "0x2791DD0", VA = "0x182792BD0")]
			internal bool MOHKPNFBBHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x27924F0", Offset = "0x27916F0", VA = "0x1827924F0")]
			internal void BCBLAPKDEME(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x27A26C0", Offset = "0x27A18C0", VA = "0x1827A26C0")]
		public NKIMPNLGOOK(BMLBDHHGCHG CCCBLIDEHDI, FOGEDALIHDN AHLPFPPNCPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x27A1EB0", Offset = "0x27A10B0", VA = "0x1827A1EB0", Slot = "134")]
		protected override void DJABOMCCOKE(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class NBLGANELIDB : NMFBAIOGNBH<GBGFENCGFOE>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override NodeVisualizationKey AFPMCDIFDOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0xDAAFB0", Offset = "0xDAA1B0", VA = "0x180DAAFB0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x27A13A0", Offset = "0x27A05A0", VA = "0x1827A13A0")]
		public NBLGANELIDB(BMLBDHHGCHG CCCBLIDEHDI, GBGFENCGFOE GCEDHPINDAM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class DOHLOIAPDLB : PPMLHFHFDEL<CCMPOMPLLBH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class DJEFNLCNBDE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public DOHLOIAPDLB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public OOMLOHBOPAJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public DJEFNLCNBDE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x27917A0", Offset = "0x27909A0", VA = "0x1827917A0")]
			internal int PHMIIEGBIFK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x2791700", Offset = "0x2790900", VA = "0x182791700")]
			internal void LLJCGKBIOBK(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x2791FC0", Offset = "0x27911C0", VA = "0x182791FC0")]
		public DOHLOIAPDLB(BMLBDHHGCHG CCCBLIDEHDI, CCMPOMPLLBH AHLPFPPNCPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x2791D30", Offset = "0x2790F30", VA = "0x182791D30", Slot = "140")]
		protected override void DBPPHPMJCAC(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class APHCAOHCGEL : NGBBBGMAMMH<GKGIGBDEIMK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		[CompilerGenerated]
		private sealed class NDJJPMNPKBF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public APHCAOHCGEL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public OOMLOHBOPAJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public NDJJPMNPKBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x27A1490", Offset = "0x27A0690", VA = "0x1827A1490")]
			internal bool JJHKHADFADH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x27A1400", Offset = "0x27A0600", VA = "0x1827A1400")]
			internal void FIJOLHGPAJJ(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x2785120", Offset = "0x2784320", VA = "0x182785120")]
		public APHCAOHCGEL(BMLBDHHGCHG CCCBLIDEHDI, GKGIGBDEIMK AHLPFPPNCPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x2784F40", Offset = "0x2784140", VA = "0x182784F40", Slot = "134")]
		protected override void DJABOMCCOKE(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class NFCDAENNBNJ : NGBBBGMAMMH<JHJMFOLJIHB>
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		[CompilerGenerated]
		private sealed class NJHIKANMBDM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public NFCDAENNBNJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public OOMLOHBOPAJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public NJHIKANMBDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x27A1E60", Offset = "0x27A1060", VA = "0x1827A1E60")]
			internal bool JJHKHADFADH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x27A1DD0", Offset = "0x27A0FD0", VA = "0x1827A1DD0")]
			internal void FIJOLHGPAJJ(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x27A16C0", Offset = "0x27A08C0", VA = "0x1827A16C0")]
		public NFCDAENNBNJ(BMLBDHHGCHG CCCBLIDEHDI, JHJMFOLJIHB AHLPFPPNCPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x27A14E0", Offset = "0x27A06E0", VA = "0x1827A14E0", Slot = "134")]
		protected override void DJABOMCCOKE(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public sealed class POHENHKEKEP : NGBBBGMAMMH<AMBADMABKDC>
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		[CompilerGenerated]
		private sealed class MIBMEGJEPDO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public POHENHKEKEP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public OOMLOHBOPAJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public MIBMEGJEPDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x279F9F0", Offset = "0x279EBF0", VA = "0x18279F9F0")]
			internal int JJHKHADFADH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x279F960", Offset = "0x279EB60", VA = "0x18279F960")]
			internal void FIJOLHGPAJJ(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x27A34B0", Offset = "0x27A26B0", VA = "0x1827A34B0")]
		public POHENHKEKEP(BMLBDHHGCHG CCCBLIDEHDI, AMBADMABKDC AHLPFPPNCPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x27A3240", Offset = "0x27A2440", VA = "0x1827A3240", Slot = "134")]
		protected override void DJABOMCCOKE(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public sealed class BGBNKHIKGDD : AJNKAPHEEJK<BHOIMMICFMI>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public override OCHEGKNJKMM BHNHGHGNBAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0xBE2300", Offset = "0xBE1500", VA = "0x180BE2300", Slot = "140")]
			get
			{
				return default(OCHEGKNJKMM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x27851F0", Offset = "0x27843F0", VA = "0x1827851F0")]
		public BGBNKHIKGDD(BMLBDHHGCHG CCCBLIDEHDI, BHOIMMICFMI AHLPFPPNCPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class GNHEELGMPPN : NGBBBGMAMMH<CNJNPCHEFBN>
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x27960E0", Offset = "0x27952E0", VA = "0x1827960E0")]
		public GNHEELGMPPN(BMLBDHHGCHG CCCBLIDEHDI, CNJNPCHEFBN GCEDHPINDAM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public abstract class NGBBBGMAMMH<TNode> : DBLLIICDFED, IDisposable where TNode : notnull, CNJNPCHEFBN
	{
		[Cpp2IlInjected.Token(Token = "0x2000091")]
		[CompilerGenerated]
		private sealed class CDDGCFFNMAN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public NGBBBGMAMMH<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public BMLBDHHGCHG circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public CDDGCFFNMAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x644B420", Offset = "0x644A620", VA = "0x18644B420")]
			internal KIMPAAHAMJP MNGJPPLMLKH(NNGNALIFMDH portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000092")]
		[CompilerGenerated]
		private struct KPEOPDFBKAC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public NGBBBGMAMMH<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x502AD70", Offset = "0x5029F70", VA = "0x18502AD70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0xA51B40", Offset = "0xA50D40", VA = "0x180A51B40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		[CompilerGenerated]
		private struct OBGPGJLGLOB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public AsyncTaskMethodBuilder<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public NGBBBGMAMMH<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public EKEFPBJPEEO? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public DMHPCPNFAPH? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x54BE250", Offset = "0x54BD450", VA = "0x1854BE250", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x54BE4F0", Offset = "0x54BD6F0", VA = "0x1854BE4F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class ADJPBLEJGKN
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000095")]
			private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D1")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D2")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D3")]
				public ADJPBLEJGKN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D4")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60003C6")]
				[Cpp2IlInjected.Address(RVA = "0x40BF430", Offset = "0x40BE630", VA = "0x1840BF430", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003C7")]
				[Cpp2IlInjected.Address(RVA = "0xA51B40", Offset = "0xA50D40", VA = "0x180A51B40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			public Func<string, bool> submitValidator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public OOMLOHBOPAJ nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public NGBBBGMAMMH<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public KBGIAKLKLKJ configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public ADJPBLEJGKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
			internal string GMJJJAFECJD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
			internal void OKPDMLBMJHP(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x4A7CC70", Offset = "0x4A7BE70", VA = "0x184A7CC70")]
			[AsyncStateMachine(typeof(NGBBBGMAMMH<>.ADJPBLEJGKN.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void ABEFMMNEKDC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000096")]
		[CompilerGenerated]
		private sealed class NHJNPPBMKBF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public OOMLOHBOPAJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public NHJNPPBMKBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x538E110", Offset = "0x538D310", VA = "0x18538E110")]
			internal bool OGDIBCFEACB(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x538E100", Offset = "0x538D300", VA = "0x18538E100")]
			internal bool NCGGLIMHEPN(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private struct EFBEPIMKNFI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public AsyncTaskMethodBuilder<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public NGBBBGMAMMH<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0x4532CF0", Offset = "0x4531EF0", VA = "0x184532CF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x4533080", Offset = "0x4532280", VA = "0x184533080", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private readonly BMLBDHHGCHG IECLKAPHAHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private readonly bool KLGOPDFCHHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private CKBGCKMFLGE<IMLHFCPAHJM, KIMPAAHAMJP> GGFAMIPMMJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private CKBGCKMFLGE<IMLHFCPAHJM, DIDHPMBDBJK> ACENAPCHADI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private List<Action> FEIJMBCMJEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[CompilerGenerated]
		private Action<JFIBBLJIDCN<IMLHFCPAHJM>>? EALGDAKHJOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[CompilerGenerated]
		private Action<JFIBBLJIDCN<IMLHFCPAHJM>, DIDHPMBDBJK>? FCBMELPNMDK;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		protected DJAFKPAFGEF LFBFOMLIKCM
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x5388A00", Offset = "0x5387C00", VA = "0x185388A00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		protected OOMLOHBOPAJ MPJGBENHJBH
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x538ADC0", Offset = "0x5389FC0", VA = "0x18538ADC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected TNode DAJPHJKKJMG
		{
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public NICODLFMDAJ<KHLCKNCKDPA> FEKCCGFMNPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x1384310", Offset = "0x1383510", VA = "0x181384310", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(NICODLFMDAJ<KHLCKNCKDPA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public JFIBBLJIDCN<KLCJLFMFFFM> GMJNOGLEODN
		{
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x538C820", Offset = "0x538BA20", VA = "0x18538C820", Slot = "6")]
			get
			{
				return default(JFIBBLJIDCN<KLCJLFMFFFM>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public object OGBBAAKFDKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x45A1050", Offset = "0x45A0250", VA = "0x1845A1050", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public virtual bool INJONLHGLIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "102")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public int NLNHPPFMCIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x538C480", Offset = "0x538B680", VA = "0x18538C480", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public CPMGKMACEBI LGBGEEDABNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x538C420", Offset = "0x538B620", VA = "0x18538C420", Slot = "10")]
			get
			{
				return default(CPMGKMACEBI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string GFMLBNHNLGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x538CA20", Offset = "0x538BC20", VA = "0x18538CA20", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected virtual bool MMLNLDLEOFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual NodeVisualizationKey AFPMCDIFDOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public JFIBBLJIDCN<IAJLMMGEEIN> FHDLOFAAPJP
		{
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0xE755B0", Offset = "0xE747B0", VA = "0x180E755B0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(JFIBBLJIDCN<IAJLMMGEEIN>);
			}
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0xE75BE0", Offset = "0xE74DE0", VA = "0x180E75BE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public virtual bool LBKEHOBEGNI
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "105")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public virtual bool HDDJIMJPNIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public virtual bool KNDAPENNKEH
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "107")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public virtual MFLJDCPMKGC OFNIEBEPCFM
		{
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0xF7C570", Offset = "0xF7B770", VA = "0x180F7C570", Slot = "108")]
			get
			{
				return default(MFLJDCPMKGC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool HGEFBOGGKAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x538C190", Offset = "0x538B390", VA = "0x18538C190", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool ELHKFFAFBJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x538C1F0", Offset = "0x538B3F0", VA = "0x18538C1F0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool GMLINKCFAEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x538C250", Offset = "0x538B450", VA = "0x18538C250", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public int OIFNLNMDGIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x538C7D0", Offset = "0x538B9D0", VA = "0x18538C7D0", Slot = "21")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public bool JIJPPFIFLIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x538C600", Offset = "0x538B800", VA = "0x18538C600", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public LCMAOOJCIDI NLCCMIPKLEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x538C360", Offset = "0x538B560", VA = "0x18538C360", Slot = "23")]
			get
			{
				return default(LCMAOOJCIDI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool IAJKAJDFFFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x538C300", Offset = "0x538B500", VA = "0x18538C300", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool LAIDDCODILH
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0xF3E770", Offset = "0xF3D970", VA = "0x180F3E770", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x133EAD0", Offset = "0x133DCD0", VA = "0x18133EAD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool ADLDCAGKNGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "109")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual bool FGNPKHENLOH
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x538C2B0", Offset = "0x538B4B0", VA = "0x18538C2B0", Slot = "110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public bool FJAAFFGAMFK
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x538C530", Offset = "0x538B730", VA = "0x18538C530", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public EKEFPBJPEEO DPCPIKHAIHO
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x538C710", Offset = "0x538B910", VA = "0x18538C710", Slot = "29")]
			get
			{
				return default(EKEFPBJPEEO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public DMHPCPNFAPH PKAGPKPGINM
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x538C770", Offset = "0x538B970", VA = "0x18538C770", Slot = "31")]
			get
			{
				return default(DMHPCPNFAPH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public virtual bool AGCPIMNHLBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public virtual GIPIMCFDOJE? PJBNGGEMFOO
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "123")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public virtual OMKDBELPALG? AHGFJFEEHDB
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "124")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public virtual IEnumerable<NICODLFMDAJ<PKEJDDGKOJK>>? EBJGONPBINF
		{
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "125")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool OPMMADILJPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x538C3C0", Offset = "0x538B5C0", VA = "0x18538C3C0", Slot = "128")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public NICODLFMDAJ<JJGKIIIBOJJ> JKPBDBKCDMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x538C650", Offset = "0x538B850", VA = "0x18538C650", Slot = "63")]
			get
			{
				return default(NICODLFMDAJ<JJGKIIIBOJJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public JFIBBLJIDCN<JJGKIIIBOJJ> DINAEIOCCKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x538C4D0", Offset = "0x538B6D0", VA = "0x18538C4D0", Slot = "57")]
			get
			{
				return default(JFIBBLJIDCN<JJGKIIIBOJJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public virtual bool MFKKKJBBFKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "129")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public virtual JFIBBLJIDCN<JJGKIIIBOJJ>? NKMFGNAPIFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public virtual bool NPILGMGCOMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "131")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public bool AODMPMICPKO
		{
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x538C590", Offset = "0x538B790", VA = "0x18538C590", Slot = "62")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public string BGMICIBNDMA
		{
			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x9F9470", Offset = "0x9F8670", VA = "0x1809F9470", Slot = "66")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x9F93F0", Offset = "0x9F85F0", VA = "0x1809F93F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public string GMOKJDINEPL
		{
			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x9F94E0", Offset = "0x9F86E0", VA = "0x1809F94E0", Slot = "67")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x9F95B0", Offset = "0x9F87B0", VA = "0x1809F95B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public JFIBBLJIDCN<PKEJDDGKOJK> MEFPIDENKCM
		{
			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x538C8A0", Offset = "0x538BAA0", VA = "0x18538C8A0", Slot = "64")]
			get
			{
				return default(JFIBBLJIDCN<PKEJDDGKOJK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public NICODLFMDAJ<PKEJDDGKOJK> AOKCFIKGOFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x538C6B0", Offset = "0x538B8B0", VA = "0x18538C6B0", Slot = "65")]
			get
			{
				return default(NICODLFMDAJ<PKEJDDGKOJK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public NICODLFMDAJ<PKEJDDGKOJK>? PFMJDKMHHBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x538C900", Offset = "0x538BB00", VA = "0x18538C900", Slot = "132")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public ONBCILOGPEM<IMLHFCPAHJM, DIDHPMBDBJK> MGOBMPLHLEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x538C9E0", Offset = "0x538BBE0", VA = "0x18538C9E0", Slot = "68")]
			get
			{
				return default(ONBCILOGPEM<IMLHFCPAHJM, DIDHPMBDBJK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public virtual JFIBBLJIDCN<IMLHFCPAHJM>? LHMBHPHHJMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "133")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public virtual bool FHGKEDBLDCB
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "136")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public virtual bool BKGLPFLEDCM
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "137")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action NAEAAHAJMNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x5388960", Offset = "0x5387B60", VA = "0x185388960", Slot = "38")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x5388A60", Offset = "0x5387C60", VA = "0x185388A60", Slot = "39")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event FOADNDILDNF FMALLFOJCBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x53897E0", Offset = "0x53889E0", VA = "0x1853897E0", Slot = "40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x53879A0", Offset = "0x5386BA0", VA = "0x1853879A0", Slot = "41")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event HGAGHDMCOPO FMMDHOGGNDB
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x5388B40", Offset = "0x5387D40", VA = "0x185388B40", Slot = "42")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x5387E30", Offset = "0x5387030", VA = "0x185387E30", Slot = "43")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action CBPJIHJANLO
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x5389A50", Offset = "0x5388C50", VA = "0x185389A50", Slot = "44")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x538AFB0", Offset = "0x538A1B0", VA = "0x18538AFB0", Slot = "45")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action CEABDCKCDLM
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x5388BE0", Offset = "0x5387DE0", VA = "0x185388BE0", Slot = "46")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x53899B0", Offset = "0x5388BB0", VA = "0x1853899B0", Slot = "47")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<JFIBBLJIDCN<IMLHFCPAHJM>, DIDHPMBDBJK> IDDDGIPMFMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x53888A0", Offset = "0x5387AA0", VA = "0x1853888A0", Slot = "70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0x538B270", Offset = "0x538A470", VA = "0x18538B270", Slot = "71")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<JFIBBLJIDCN<IMLHFCPAHJM>, DIDHPMBDBJK> GMKKNKBMLPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x5388D60", Offset = "0x5387F60", VA = "0x185388D60", Slot = "74")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0x538AC40", Offset = "0x5389E40", VA = "0x18538AC40", Slot = "75")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<JFIBBLJIDCN<IMLHFCPAHJM>> NDAPNBGNGJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x5388370", Offset = "0x5387570", VA = "0x185388370", Slot = "72")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x538AEF0", Offset = "0x538A0F0", VA = "0x18538AEF0", Slot = "73")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<JFIBBLJIDCN<IMLHFCPAHJM>, JFIBBLJIDCN<IMLHFCPAHJM>> OLKGGOJFFLI
		{
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x53898F0", Offset = "0x5388AF0", VA = "0x1853898F0", Slot = "76")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x538B8F0", Offset = "0x538AAF0", VA = "0x18538B8F0", Slot = "77")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<JFIBBLJIDCN<IMLHFCPAHJM>, DIDHPMBDBJK> PJLCDFECMMN
		{
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x5388C80", Offset = "0x5387E80", VA = "0x185388C80", Slot = "78")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x538B460", Offset = "0x538A660", VA = "0x18538B460", Slot = "79")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<JFIBBLJIDCN<IMLHFCPAHJM>, JFIBBLJIDCN<IMLHFCPAHJM>> PHOCMEKLLFF
		{
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x538AD00", Offset = "0x5389F00", VA = "0x18538AD00", Slot = "80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x5389B20", Offset = "0x5388D20", VA = "0x185389B20", Slot = "81")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x538BBC0", Offset = "0x538ADC0", VA = "0x18538BBC0")]
		[CGDAAOOHDFB("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		[CGDAAOOHDFB("Need to handle `Name` better.")]
		protected NGBBBGMAMMH(BMLBDHHGCHG CCCBLIDEHDI, TNode GCEDHPINDAM, bool BAEMHFOCPMB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x5389C50", Offset = "0x5388E50", VA = "0x185389C50", Slot = "100")]
		protected virtual void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x5388E20", Offset = "0x5388020", VA = "0x185388E20", Slot = "101")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x538B1C0", Offset = "0x538A3C0", VA = "0x18538B1C0", Slot = "9")]
		[AsyncStateMachine(typeof(NGBBBGMAMMH<>.KPEOPDFBKAC))]
		public void NMPACMNOKKI(int MHGIBNEIMFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x5387A40", Offset = "0x5386C40", VA = "0x185387A40")]
		public bool AOLFNNOFNKI([In] EKEFPBJPEEO MLCDCHNOCFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x5389880", Offset = "0x5388A80", VA = "0x185389880")]
		public bool ELBPMEEKCJA([In] DMHPCPNFAPH MLCDCHNOCFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x538B9B0", Offset = "0x538ABB0", VA = "0x18538B9B0", Slot = "33")]
		public void PKMFDIIBFML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x5389EF0", Offset = "0x53890F0", VA = "0x185389EF0", Slot = "34")]
		[AsyncStateMachine(typeof(NGBBBGMAMMH<>.OBGPGJLGLOB))]
		public Task<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> JCJDKKEICJH(EKEFPBJPEEO? KGEICFIBDCA, DMHPCPNFAPH? JLBNIDPEHNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "111")]
		public virtual void LNDGKLMFEJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "112")]
		public virtual void MOFDCBMPFAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "113")]
		public virtual void NCCOJNODCPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xF1E4F0", Offset = "0xF1D6F0", VA = "0x180F1E4F0")]
		protected void JHDLMCPDHDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xF744F0", Offset = "0xF736F0", VA = "0x180F744F0")]
		protected void NGHPIJNGLKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x2181840", Offset = "0x2180A40", VA = "0x182181840")]
		private void AOGJGGLPIDC([In] DMHPCPNFAPH PANMBKPFLFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x538A750", Offset = "0x5389950", VA = "0x18538A750", Slot = "114")]
		public virtual Task<LOAMJJJEMNF<JFIBBLJIDCN<IMLHFCPAHJM>, PLLHOMFPAAM>> LDCMFCGDIPG(string DGIAFBEDPNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x538A5F0", Offset = "0x53897F0", VA = "0x18538A5F0", Slot = "115")]
		public virtual Task<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> JMJHHIDJGGF(JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "116")]
		public virtual void BGMEPNMFAHE(JFIBBLJIDCN<IMLHFCPAHJM> OPODHENPEBM, JFIBBLJIDCN<IMLHFCPAHJM> AHCAJFPOBIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x538A6C0", Offset = "0x53898C0", VA = "0x18538A6C0", Slot = "117")]
		public virtual IEnumerable<AGKENLKLGLL> KKCLLCBMLHN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x538B710", Offset = "0x538A910", VA = "0x18538B710", Slot = "118")]
		public LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM> OOBGDKCFCMB(string PLJFDFBJOBL)
		{
			return default(LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x5388220", Offset = "0x5387420", VA = "0x185388220", Slot = "48")]
		public bool CEGFFANELLF([Out] Guid BLOOPCJEKIK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x5387ED0", Offset = "0x53870D0", VA = "0x185387ED0")]
		public bool BOOPFAJDPMF([In] Guid EEKBMGEEJKM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "119")]
		public virtual void AJIPEHIHHNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "120")]
		public virtual void GIFHBHKCGGN(bool CKIGBCMMBGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "121")]
		public virtual GBLOPNAHCAC DDPHKOEDAAF([In] MICHNFOPJNH HHPHBEKEPIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x538B520", Offset = "0x538A720", VA = "0x18538B520")]
		protected void OKJHEFEHGNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x538AEB0", Offset = "0x538A0B0", VA = "0x18538AEB0", Slot = "126")]
		protected virtual bool MJGKLEIAAIJ(JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x5389C20", Offset = "0x5388E20", VA = "0x185389C20", Slot = "89")]
		public bool IDIIJNCBDHJ(JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "127")]
		protected virtual bool DHAKHKHHMIL(JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "134")]
		protected virtual void DJABOMCCOKE(KBGIAKLKLKJ BMDPPDKPHHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x53884A0", Offset = "0x53876A0", VA = "0x1853884A0")]
		protected void CGBOLGIAEAE(KBGIAKLKLKJ PHLPDDJGIJJ, Func<string> INCLFPGFIFC, Action<string> IKIHGPPGMJM, string JOBCPBPACBN, string PHMDEDIAPLD, string NHBAEDJJBDC, GGABPGLMFAM ENJDPDICAOL, BOKHPJLFDEL LAPFEFMCOKM, Func<string, bool> JJHEHJOBOPG, string JLDFGKDOCAN, Func<string, bool> JNNMHLECLIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x5387AF0", Offset = "0x5386CF0", VA = "0x185387AF0")]
		protected void BDCICJDEEBB(KBGIAKLKLKJ PHLPDDJGIJJ, Func<string> INCLFPGFIFC, Action<string> IKIHGPPGMJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x53877F0", Offset = "0x53869F0", VA = "0x1853877F0", Slot = "135")]
		protected virtual void ABFBCMPPBFP(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x5387DE0", Offset = "0x5386FE0", VA = "0x185387DE0", Slot = "83")]
		public void BKDMKNNIJBJ(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x538B370", Offset = "0x538A570", VA = "0x18538B370", Slot = "84")]
		public ELIDMAMFOFN OJLLNHIGBPC()
		{
			return default(ELIDMAMFOFN);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "138")]
		public virtual bool CHCGOHDLBBJ(JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x1F6A610", Offset = "0x1F69810", VA = "0x181F6A610")]
		private void KMNHNJAFBOA([In] EKEFPBJPEEO BJHAAAPCKLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x538B7A0", Offset = "0x538A9A0", VA = "0x18538B7A0")]
		private void PAAMJBMBICD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x538B330", Offset = "0x538A530", VA = "0x18538B330", Slot = "90")]
		private void OHDJJIAILHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x5389220", Offset = "0x5388420", VA = "0x185389220", Slot = "92")]
		private void EEBBINHAHMI(JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x10C7D60", Offset = "0x10C6F60", VA = "0x1810C7D60", Slot = "94")]
		private void HHNADCOEHCP(JFIBBLJIDCN<IMLHFCPAHJM> MKHHKDJKLDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x538B010", Offset = "0x538A210", VA = "0x18538B010", Slot = "96")]
		private void NHKBPNNHKKN(JFIBBLJIDCN<IMLHFCPAHJM> MKHHKDJKLDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x538A040", Offset = "0x5389240", VA = "0x18538A040", Slot = "97")]
		private void JEKNABFLMBO(JFIBBLJIDCN<IMLHFCPAHJM> OPODHENPEBM, JFIBBLJIDCN<IMLHFCPAHJM> AHCAJFPOBIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x10C6A80", Offset = "0x10C5C80", VA = "0x1810C6A80", Slot = "98")]
		private void KLIPKCDMHJI(JFIBBLJIDCN<IMLHFCPAHJM> OPODHENPEBM, JFIBBLJIDCN<IMLHFCPAHJM> AHCAJFPOBIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x5388D40", Offset = "0x5387F40", VA = "0x185388D40", Slot = "91")]
		private void DNCIADDKCFD(JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x538A820", Offset = "0x5389A20", VA = "0x18538A820", Slot = "93")]
		private void LEJDGDCAKEE(JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x5388430", Offset = "0x5387630", VA = "0x185388430", Slot = "95")]
		private void CFPHCNIMAHF(JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x538A3F0", Offset = "0x53895F0", VA = "0x18538A3F0", Slot = "139")]
		[AsyncStateMachine(typeof(NGBBBGMAMMH<>.EFBEPIMKNFI))]
		public Task<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> JIJJAJAIMLJ(string PLJFDFBJOBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x538A510", Offset = "0x5389710", VA = "0x18538A510", Slot = "55")]
		private void JIOPEBAAGAG(object HICNOKDPNMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x538A580", Offset = "0x5389780", VA = "0x18538A580", Slot = "56")]
		private void JLEDBKLFDOK(object HICNOKDPNMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x4E95290", Offset = "0x4E94490", VA = "0x184E95290", Slot = "30")]
		private bool IFIBGPNIHMF([In] EKEFPBJPEEO MLCDCHNOCFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x5387AB0", Offset = "0x5386CB0", VA = "0x185387AB0", Slot = "32")]
		private bool APIKKNNBGOG([In] DMHPCPNFAPH MLCDCHNOCFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x5388B00", Offset = "0x5387D00", VA = "0x185388B00", Slot = "49")]
		private bool DBLABMGCDEA([In] Guid EEKBMGEEJKM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x5389BE0", Offset = "0x5388DE0", VA = "0x185389BE0")]
		[CompilerGenerated]
		private string IDDELJPMGBP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x5388180", Offset = "0x5387380", VA = "0x185388180")]
		[CompilerGenerated]
		private void CCPNLBEEMII(string DGIAFBEDPNJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class CKPHPDLHGIH : NMFBAIOGNBH<KPJLNEKCBJK>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public override NodeVisualizationKey AFPMCDIFDOM
		{
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0xD9C860", Offset = "0xD9BA60", VA = "0x180D9C860", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x2791510", Offset = "0x2790710", VA = "0x182791510")]
		public CKPHPDLHGIH(BMLBDHHGCHG CCCBLIDEHDI, KPJLNEKCBJK GCEDHPINDAM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private sealed class NKLDJFGOLGL : OODFLKOFLEK<LMLPBPJCGEO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public override NodeVisualizationKey AFPMCDIFDOM
		{
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0xBE2300", Offset = "0xBE1500", VA = "0x180BE2300", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x27A2730", Offset = "0x27A1930", VA = "0x1827A2730")]
		public NKLDJFGOLGL(BMLBDHHGCHG CCCBLIDEHDI, LMLPBPJCGEO GCEDHPINDAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "134")]
		protected override void DJABOMCCOKE(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public sealed class MPBPOKNMLCK : NGBBBGMAMMH<LLGJIONFHPC>
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		[CompilerGenerated]
		private sealed class FHAEAIGLIJA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public IReadOnlyList<KeyValuePair<string, IENBLMBPDPG>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public MPBPOKNMLCK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public OOMLOHBOPAJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public FHAEAIGLIJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
			internal IReadOnlyList<KeyValuePair<string, IENBLMBPDPG>> JJHKHADFADH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003D7")]
			[Cpp2IlInjected.Address(RVA = "0x2793FF0", Offset = "0x27931F0", VA = "0x182793FF0")]
			internal int FIJOLHGPAJJ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0x2793CA0", Offset = "0x2792EA0", VA = "0x182793CA0")]
			internal void CMLNADHEAEF(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0x2794570", Offset = "0x2793770", VA = "0x182794570")]
			internal int KPPJIHPOEEL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0x2793F10", Offset = "0x2793110", VA = "0x182793F10")]
			internal void EBLGFJDKHCO(int v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x2793E70", Offset = "0x2793070", VA = "0x182793E70")]
			internal int DBAHHJHIDBP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x2793C10", Offset = "0x2792E10", VA = "0x182793C10")]
			internal void BMKNIICDKMG(int v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x27945C0", Offset = "0x27937C0", VA = "0x1827945C0")]
			internal int MHLJHMKKCLG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x2794370", Offset = "0x2793570", VA = "0x182794370")]
			internal void JIDPLDCLBAM(int v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x2794520", Offset = "0x2793720", VA = "0x182794520")]
			internal int KGLBFMGFMLC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x27941B0", Offset = "0x27933B0", VA = "0x1827941B0")]
			internal void HHHLHGIDLMF(int v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0x27942D0", Offset = "0x27934D0", VA = "0x1827942D0")]
			internal int IHLCHOJMMDC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x2793A50", Offset = "0x2792C50", VA = "0x182793A50")]
			internal void ALHLMKFODLL(int v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x2794610", Offset = "0x2793810", VA = "0x182794610")]
			internal float MOHKPNFBBHA()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x2793B30", Offset = "0x2792D30", VA = "0x182793B30")]
			internal void BCBLAPKDEME(float v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x2793AE0", Offset = "0x2792CE0", VA = "0x182793AE0")]
			internal float ANJLBEPLFDL()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x2794240", Offset = "0x2793440", VA = "0x182794240")]
			internal void IEFENCHJKFN(float v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x2794320", Offset = "0x2793520", VA = "0x182794320")]
			internal bool IJENLOKLJJJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x2794400", Offset = "0x2793600", VA = "0x182794400")]
			internal void JLENOIANLCF(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x2793FA0", Offset = "0x27931A0", VA = "0x182793FA0")]
			internal int FHCEBIEKIKJ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x27939C0", Offset = "0x2792BC0", VA = "0x1827939C0")]
			internal void AKFJCEDHJDA(int v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x2793EC0", Offset = "0x27930C0", VA = "0x182793EC0")]
			internal float DBJNPDPJPOH()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0x2794120", Offset = "0x2793320", VA = "0x182794120")]
			internal void FOFGGAOBDEI(float v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x2793BC0", Offset = "0x2792DC0", VA = "0x182793BC0")]
			internal float BIFIFKAAENE()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0x2793DE0", Offset = "0x2792FE0", VA = "0x182793DE0")]
			internal void CMPPBFMPBGN(float v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0x2793970", Offset = "0x2792B70", VA = "0x182793970")]
			internal bool ADPGBHLAENB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x2794490", Offset = "0x2793690", VA = "0x182794490")]
			internal void KDFBACKJKIC(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override NodeVisualizationKey AFPMCDIFDOM
		{
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x10DAED0", Offset = "0x10DA0D0", VA = "0x1810DAED0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x27A0F60", Offset = "0x27A0160", VA = "0x1827A0F60")]
		public MPBPOKNMLCK(BMLBDHHGCHG CCCBLIDEHDI, LLGJIONFHPC AHLPFPPNCPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x279FE40", Offset = "0x279F040", VA = "0x18279FE40", Slot = "134")]
		protected sealed override void DJABOMCCOKE(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public abstract class AJNKAPHEEJK<T> : NGBBBGMAMMH<T> where T : notnull, KAODFBLAEHK
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class KJDGOKIHEJM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public IReadOnlyList<KeyValuePair<string, IENBLMBPDPG>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public AJNKAPHEEJK<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			public OOMLOHBOPAJ nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public OCHEGKNJKMM clipType;

			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public KJDGOKIHEJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
			internal IReadOnlyList<KeyValuePair<string, IENBLMBPDPG>> JJHKHADFADH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0x5017840", Offset = "0x5016A40", VA = "0x185017840")]
			internal int FIJOLHGPAJJ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0x5017350", Offset = "0x5016550", VA = "0x185017350")]
			internal void CMLNADHEAEF(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x5017B00", Offset = "0x5016D00", VA = "0x185017B00")]
			internal void KPPJIHPOEEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x5017630", Offset = "0x5016830", VA = "0x185017630")]
			internal void EBLGFJDKHCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FB")]
			[Cpp2IlInjected.Address(RVA = "0x5017270", Offset = "0x5016470", VA = "0x185017270")]
			internal bool MOHKPNFBBHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0x5017300", Offset = "0x5016500", VA = "0x185017300")]
			internal void BCBLAPKDEME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0x5017270", Offset = "0x5016470", VA = "0x185017270")]
			internal bool ANJLBEPLFDL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0x50179A0", Offset = "0x5016BA0", VA = "0x1850179A0")]
			internal float IEFENCHJKFN()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003FF")]
			[Cpp2IlInjected.Address(RVA = "0x50179F0", Offset = "0x5016BF0", VA = "0x1850179F0")]
			internal void IJENLOKLJJJ(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0x5017AB0", Offset = "0x5016CB0", VA = "0x185017AB0")]
			internal float JLENOIANLCF()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0x5017780", Offset = "0x5016980", VA = "0x185017780")]
			internal void FHCEBIEKIKJ(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x5017220", Offset = "0x5016420", VA = "0x185017220")]
			internal float AKFJCEDHJDA()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0x5017570", Offset = "0x5016770", VA = "0x185017570")]
			internal void DBJNPDPJPOH(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public override NodeVisualizationKey AFPMCDIFDOM
		{
			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0x10DAED0", Offset = "0x10DA0D0", VA = "0x1810DAED0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public abstract OCHEGKNJKMM BHNHGHGNBAM
		{
			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(Slot = "140")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x4B638D0", Offset = "0x4B62AD0", VA = "0x184B638D0")]
		public AJNKAPHEEJK(BMLBDHHGCHG CCCBLIDEHDI, T GCEDHPINDAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x4B62E20", Offset = "0x4B62020", VA = "0x184B62E20", Slot = "134")]
		protected sealed override void DJABOMCCOKE(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	private sealed class DHCMHDKDLFN : NGBBBGMAMMH<KEADDACIDLC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public override NodeVisualizationKey AFPMCDIFDOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0xDA7A10", Offset = "0xDA6C10", VA = "0x180DA7A10", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x2791690", Offset = "0x2790890", VA = "0x182791690")]
		public DHCMHDKDLFN(BMLBDHHGCHG CCCBLIDEHDI, KEADDACIDLC GCEDHPINDAM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class MAAJDFGIMEJ : NGBBBGMAMMH<AMAOJLLHJGJ>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A0")]
		[CompilerGenerated]
		private sealed class JNEONCFNNLK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public MAAJDFGIMEJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public OOMLOHBOPAJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public JNEONCFNNLK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0x2799430", Offset = "0x2798630", VA = "0x182799430")]
			internal int FIJOLHGPAJJ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x27993A0", Offset = "0x27985A0", VA = "0x1827993A0")]
			internal void CMLNADHEAEF(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private static Dictionary<string, IENBLMBPDPG>? NCCFMCJHFPI;

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x279F8F0", Offset = "0x279EAF0", VA = "0x18279F8F0")]
		public MAAJDFGIMEJ(BMLBDHHGCHG CCCBLIDEHDI, AMAOJLLHJGJ GCEDHPINDAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x279F580", Offset = "0x279E780", VA = "0x18279F580", Slot = "134")]
		protected override void DJABOMCCOKE(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public sealed class DKIAPNGIBDB : AJNKAPHEEJK<GLAOGPCMBPO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public override OCHEGKNJKMM BHNHGHGNBAM
		{
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "140")]
			get
			{
				return default(OCHEGKNJKMM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x2791CD0", Offset = "0x2790ED0", VA = "0x182791CD0")]
		public DKIAPNGIBDB(BMLBDHHGCHG CCCBLIDEHDI, GLAOGPCMBPO AHLPFPPNCPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private sealed class HJKOKPMAHEE : OODFLKOFLEK<FFJGOIBKHKI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public override NodeVisualizationKey AFPMCDIFDOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0xBE2300", Offset = "0xBE1500", VA = "0x180BE2300", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x2797870", Offset = "0x2796A70", VA = "0x182797870")]
		public HJKOKPMAHEE(BMLBDHHGCHG CCCBLIDEHDI, FFJGOIBKHKI GCEDHPINDAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "134")]
		protected override void DJABOMCCOKE(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	private sealed class EKKMDDMJBHO : OODFLKOFLEK<CLNPLBIOMKF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public override NodeVisualizationKey AFPMCDIFDOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0xBE2300", Offset = "0xBE1500", VA = "0x180BE2300", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x2792C20", Offset = "0x2791E20", VA = "0x182792C20")]
		public EKKMDDMJBHO(BMLBDHHGCHG CCCBLIDEHDI, CLNPLBIOMKF GCEDHPINDAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "134")]
		protected override void DJABOMCCOKE(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public sealed class BIFPINJJEOM : PPMLHFHFDEL<NJEMCEGIOML>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		[CompilerGenerated]
		private sealed class KLGHOANHHPD
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000A7")]
			private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001ED")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40001EE")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40001EF")]
				public KLGHOANHHPD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001F0")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40001F1")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40001F2")]
				private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600041A")]
				[Cpp2IlInjected.Address(RVA = "0x27A3520", Offset = "0x27A2720", VA = "0x1827A3520", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600041B")]
				[Cpp2IlInjected.Address(RVA = "0xA51B40", Offset = "0xA50D40", VA = "0x180A51B40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			public OOMLOHBOPAJ nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			public BIFPINJJEOM <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public KLGHOANHHPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0x279EAB0", Offset = "0x279DCB0", VA = "0x18279EAB0")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void PHMIIEGBIFK(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x2785530", Offset = "0x2784730", VA = "0x182785530")]
		public BIFPINJJEOM(BMLBDHHGCHG CCCBLIDEHDI, NJEMCEGIOML AHLPFPPNCPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x2785250", Offset = "0x2784450", VA = "0x182785250", Slot = "140")]
		protected override void DBPPHPMJCAC(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public sealed class KIHBLKHMDPB : AJNKAPHEEJK<MGCPBAICLIC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public override OCHEGKNJKMM BHNHGHGNBAM
		{
			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0xBC9F20", Offset = "0xBC9120", VA = "0x180BC9F20", Slot = "140")]
			get
			{
				return default(OCHEGKNJKMM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x27998F0", Offset = "0x2798AF0", VA = "0x1827998F0")]
		public KIHBLKHMDPB(BMLBDHHGCHG CCCBLIDEHDI, MGCPBAICLIC AHLPFPPNCPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private sealed class ICOOMKDKLMH : NGBBBGMAMMH<DNHGECODBPK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public override NodeVisualizationKey AFPMCDIFDOM
		{
			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0xD76DF0", Offset = "0xD75FF0", VA = "0x180D76DF0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x27983F0", Offset = "0x27975F0", VA = "0x1827983F0")]
		public ICOOMKDKLMH(BMLBDHHGCHG CCCBLIDEHDI, DNHGECODBPK GCEDHPINDAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "134")]
		protected override void DJABOMCCOKE(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public sealed class MKDDBMAAPBB : NGBBBGMAMMH<AKDEHNOIDNA>
	{
		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public sealed override NodeVisualizationKey AFPMCDIFDOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public sealed override bool HDDJIMJPNIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		protected sealed override bool MMLNLDLEOFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x279FDB0", Offset = "0x279EFB0", VA = "0x18279FDB0")]
		public MKDDBMAAPBB(BMLBDHHGCHG CCCBLIDEHDI, AKDEHNOIDNA GCEDHPINDAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x279FA40", Offset = "0x279EC40", VA = "0x18279FA40", Slot = "134")]
		protected override void DJABOMCCOKE(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x279FD10", Offset = "0x279EF10", VA = "0x18279FD10")]
		private int FJFDEIMPBFF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x279FD50", Offset = "0x279EF50", VA = "0x18279FD50")]
		private void IBPFGLEKJFL(int EJKIDBDKPMD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public class GLCIJBJBICA : GNHEELGMPPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x27960E0", Offset = "0x27952E0", VA = "0x1827960E0")]
		public GLCIJBJBICA(BMLBDHHGCHG CCCBLIDEHDI, CNJNPCHEFBN GCEDHPINDAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "134")]
		protected override void DJABOMCCOKE(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public sealed class BBCHEFFEEEK : PPMLHFHFDEL<BJPGNOFMGJO>
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x2785190", Offset = "0x2784390", VA = "0x182785190")]
		public BBCHEFFEEEK(BMLBDHHGCHG CCCBLIDEHDI, BJPGNOFMGJO GCEDHPINDAM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public abstract class PPMLHFHFDEL<TVariableNode> : NGBBBGMAMMH<TVariableNode> where TVariableNode : notnull, BJPGNOFMGJO
	{
		[Cpp2IlInjected.Token(Token = "0x20000AE")]
		[CompilerGenerated]
		private sealed class JKBOECFKHLA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			public PPMLHFHFDEL<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			public OOMLOHBOPAJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public JKBOECFKHLA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0x4ECB790", Offset = "0x4ECA990", VA = "0x184ECB790")]
			internal bool JJHKHADFADH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x4ECB6D0", Offset = "0x4ECA8D0", VA = "0x184ECB6D0")]
			internal void FIJOLHGPAJJ(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0x4ECB5C0", Offset = "0x4ECA7C0", VA = "0x184ECB5C0")]
			internal bool CMLNADHEAEF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0x4ECB7F0", Offset = "0x4ECA9F0", VA = "0x184ECB7F0")]
			internal void KPPJIHPOEEL(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000437")]
			[Cpp2IlInjected.Address(RVA = "0x4ECB620", Offset = "0x4ECA820", VA = "0x184ECB620")]
			internal bool EBLGFJDKHCO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AF")]
		[CompilerGenerated]
		private sealed class LFKCONNHEOG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			public OOMLOHBOPAJ nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			public PPMLHFHFDEL<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public LFKCONNHEOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0x50C4370", Offset = "0x50C3570", VA = "0x1850C4370")]
			internal void PHMIIEGBIFK(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public override NodeVisualizationKey AFPMCDIFDOM
		{
			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0xBF3BE0", Offset = "0xBF2DE0", VA = "0x180BF3BE0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public override MFLJDCPMKGC OFNIEBEPCFM
		{
			[Cpp2IlInjected.Token(Token = "0x600042C")]
			[Cpp2IlInjected.Address(RVA = "0x5640DD0", Offset = "0x563FFD0", VA = "0x185640DD0", Slot = "108")]
			get
			{
				return default(MFLJDCPMKGC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x5640C30", Offset = "0x563FE30", VA = "0x185640C30")]
		protected PPMLHFHFDEL(BMLBDHHGCHG CCCBLIDEHDI, TVariableNode GCEDHPINDAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x5640AB0", Offset = "0x563FCB0", VA = "0x185640AB0", Slot = "101")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x5640620", Offset = "0x563F820", VA = "0x185640620", Slot = "134")]
		protected override void DJABOMCCOKE(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x5640290", Offset = "0x563F490", VA = "0x185640290", Slot = "140")]
		protected virtual void DBPPHPMJCAC(KBGIAKLKLKJ PHLPDDJGIJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x56401E0", Offset = "0x563F3E0", VA = "0x1856401E0", Slot = "119")]
		public override void AJIPEHIHHNF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x27787B0", Offset = "0x27779B0", VA = "0x1827787B0")]
	public static DBLLIICDFED OIKMHICCLEP(BMLBDHHGCHG CCCBLIDEHDI, CNJNPCHEFBN GCEDHPINDAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public sealed class NGBMMAGOCEA : CGGFCIGIACJ, JPOFFCOHIDF, DEEMKFDPNME, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public JFIBBLJIDCN<KLMHALNMEAA> IBDFMBAKEAL
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0xD863B0", Offset = "0xD855B0", VA = "0x180D863B0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(JFIBBLJIDCN<KLMHALNMEAA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public JFIBBLJIDCN<PADJNFOHKPF> JGGJLFDPEEI
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0xE96C70", Offset = "0xE95E70", VA = "0x180E96C70", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(JFIBBLJIDCN<PADJNFOHKPF>);
		}
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x27A1780", Offset = "0x27A0980", VA = "0x1827A1780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private JFIBBLJIDCN<HOEALKNOPIA> CJFBEHCHEIL
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0xD73B30", Offset = "0xD72D30", VA = "0x180D73B30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public override JFIBBLJIDCN<GOJKLMIIDHM> MHCEAOMNMDL
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x27A1730", Offset = "0x27A0930", VA = "0x1827A1730", Slot = "21")]
		get
		{
			return default(JFIBBLJIDCN<GOJKLMIIDHM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x27A1AE0", Offset = "0x27A0CE0", VA = "0x1827A1AE0")]
	private NGBMMAGOCEA(BMLBDHHGCHG CCCBLIDEHDI, CNJNPCHEFBN GCEDHPINDAM, JJCMCCEKBDA DBHKDNOMGDD, JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG, JFIBBLJIDCN<PADJNFOHKPF> DAPOJGPODED, JFIBBLJIDCN<HOEALKNOPIA> DMLNAJIHPDP, bool HMPJAGJNCCK, string DGIAFBEDPNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x27A1790", Offset = "0x27A0990", VA = "0x1827A1790")]
	public static NGBMMAGOCEA OIKMHICCLEP(BMLBDHHGCHG CCCBLIDEHDI, CNJNPCHEFBN GCEDHPINDAM, JJCMCCEKBDA JLALKPGHLDH, JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG, JFIBBLJIDCN<HOEALKNOPIA> DMLNAJIHPDP, JFIBBLJIDCN<PADJNFOHKPF> DAPOJGPODED, bool HMPJAGJNCCK, bool BAEMHFOCPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x27A1780", Offset = "0x27A0980", VA = "0x1827A1780")]
	internal void FHNEHLGFMMK(JFIBBLJIDCN<PADJNFOHKPF> MLCDCHNOCFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public abstract class CGGFCIGIACJ : DEEMKFDPNME, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	private struct LFCONDMINDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private DCKIFBHEHBA? EMJICBGNDPN;

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x279ECA0", Offset = "0x279DEA0", VA = "0x18279ECA0")]
		public void FKFEALEGJFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x279ECB0", Offset = "0x279DEB0", VA = "0x18279ECB0")]
		public DCKIFBHEHBA GICOLOPAKGO(CGGFCIGIACJ ODDNIELKAMA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	protected readonly BMLBDHHGCHG IECLKAPHAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	protected readonly CNJNPCHEFBN JHPJFHAHHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private LFCONDMINDI NLLEEMPIIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private readonly KGPPIMEMMLP IKKOOJGOOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private readonly List<LJOIAHCEKGF> EAPLAGCFIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private readonly List<HPINOCLDBBE> LFFCOOGIBJL;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	[CGDAAOOHDFB("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> MBBHBGLEHIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x2787180", Offset = "0x2786380", VA = "0x182787180", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public DisplayKind ELJFDMCFGCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0xBFB9D0", Offset = "0xBFABD0", VA = "0x180BFB9D0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public JFIBBLJIDCN<JJGKIIIBOJJ> DINAEIOCCKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x2786BF0", Offset = "0x2785DF0", VA = "0x182786BF0", Slot = "6")]
		get
		{
			return default(JFIBBLJIDCN<JJGKIIIBOJJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public NICODLFMDAJ<JJGKIIIBOJJ> JKPBDBKCDMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x2786F40", Offset = "0x2786140", VA = "0x182786F40", Slot = "7")]
		get
		{
			return default(NICODLFMDAJ<JJGKIIIBOJJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public DHECOFGEKEO HGEINLPBLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0xD59F90", Offset = "0xD59190", VA = "0x180D59F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public PHMDDFIHFNF EPAJANNIJOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x2786EA0", Offset = "0x27860A0", VA = "0x182786EA0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	protected DCKIFBHEHBA NMCJMOIMAPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x2786EA0", Offset = "0x27860A0", VA = "0x182786EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public PortImage EFFGNDADAAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x2787BC0", Offset = "0x2786DC0", VA = "0x182787BC0", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public string BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x9F2450", Offset = "0x9F1650", VA = "0x1809F2450", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x9F24A0", Offset = "0x9F16A0", VA = "0x1809F24A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public NICODLFMDAJ<PKEJDDGKOJK> AOKCFIKGOFO
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x2786850", Offset = "0x2785A50", VA = "0x182786850", Slot = "9")]
		get
		{
			return default(NICODLFMDAJ<PKEJDDGKOJK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public JFIBBLJIDCN<IMLHFCPAHJM> DNEAAOEPKGF
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0xD34D90", Offset = "0xD33F90", VA = "0x180D34D90", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(JFIBBLJIDCN<IMLHFCPAHJM>);
		}
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0xE964A0", Offset = "0xE956A0", VA = "0x180E964A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public abstract JFIBBLJIDCN<GOJKLMIIDHM> MHCEAOMNMDL
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x2787DB0", Offset = "0x2786FB0", VA = "0x182787DB0")]
	protected CGGFCIGIACJ(BMLBDHHGCHG CCCBLIDEHDI, CNJNPCHEFBN GCEDHPINDAM, KGPPIMEMMLP AKBKPEPJIKB, JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG, bool HMPJAGJNCCK, string DGIAFBEDPNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x2787090", Offset = "0x2786290", VA = "0x182787090", Slot = "22")]
	protected virtual void ILLMBOBOELN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x2786DB0", Offset = "0x2785FB0", VA = "0x182786DB0", Slot = "23")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x2786FD0", Offset = "0x27861D0", VA = "0x182786FD0", Slot = "14")]
	public void HLDDCHLOHFC(LJOIAHCEKGF DJBNDMENDGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x2787D50", Offset = "0x2786F50", VA = "0x182787D50", Slot = "15")]
	public void PANFGGHMAII(HPINOCLDBBE DJBNDMENDGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x27872C0", Offset = "0x27864C0", VA = "0x1827872C0", Slot = "16")]
	public void KJIDKPCKCOI(IIOANHEMOAF BOKANDMKOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x2786F70", Offset = "0x2786170", VA = "0x182786F70", Slot = "24")]
	protected virtual void HEKGHEDBPJF(IIOANHEMOAF BOKANDMKOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x2786C20", Offset = "0x2785E20", VA = "0x182786C20", Slot = "19")]
	private void DMPLDMAAPLE(bool NIDPEFPJBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x2786870", Offset = "0x2785A70", VA = "0x182786870")]
	private void AOPBACNBCGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x2786A20", Offset = "0x2785C20", VA = "0x182786A20")]
	private void BHOCNPAPJCO([In] NMPGAPKOEJA HOOACPBPIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x2787030", Offset = "0x2786230", VA = "0x182787030", Slot = "17")]
	public void IIONLMJHGNK(LJOIAHCEKGF DJBNDMENDGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x2787CF0", Offset = "0x2786EF0", VA = "0x182787CF0", Slot = "18")]
	public void NMKBOEJBJOL(HPINOCLDBBE DJBNDMENDGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x9F24A0", Offset = "0x9F16A0", VA = "0x1809F24A0")]
	internal void KALBGALGOID(string DGIAFBEDPNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x2786BD0", Offset = "0x2785DD0", VA = "0x182786BD0")]
	internal void BNOGCBIPMBK(MEGGMABFBFO POLANHDJCNH, DHECOFGEKEO EDLOHJEBKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0xE964A0", Offset = "0xE956A0", VA = "0x180E964A0")]
	internal void AKNIBJDHEOK(JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public sealed class KIMPAAHAMJP : DIDHPMBDBJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class KMFLDGDCBMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public BMLBDHHGCHG circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public CNJNPCHEFBN node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public JFIBBLJIDCN<IMLHFCPAHJM> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public KMFLDGDCBMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x279EC10", Offset = "0x279DE10", VA = "0x18279EC10")]
		internal LLDLFLABLJL LFDBPOBGCHP((int PortDescIndex, int PortIndex, JCKMHJAJBIB InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x279EB80", Offset = "0x279DD80", VA = "0x18279EB80")]
		internal NGBMMAGOCEA DHKALJEHMJK(JJCMCCEKBDA i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct HLOBFDINNAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public KIMPAAHAMJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private LAMDCDECGNG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x2797CE0", Offset = "0x2796EE0", VA = "0x182797CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x2798150", Offset = "0x2797350", VA = "0x182798150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct FHPCIKMDEMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public KIMPAAHAMJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public JFIBBLJIDCN<FLAIMFHIJIM> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private LAMDCDECGNG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x2794660", Offset = "0x2793860", VA = "0x182794660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x27949B0", Offset = "0x2793BB0", VA = "0x1827949B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct FGJHOGDBKHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public KIMPAAHAMJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public JFIBBLJIDCN<HOEALKNOPIA> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private LAMDCDECGNG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x27935B0", Offset = "0x27927B0", VA = "0x1827935B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x2793900", Offset = "0x2792B00", VA = "0x182793900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct LLCELFFNNFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public KIMPAAHAMJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public JFIBBLJIDCN<FLAIMFHIJIM> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public JFIBBLJIDCN<FLAIMFHIJIM> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private LAMDCDECGNG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x279F1B0", Offset = "0x279E3B0", VA = "0x18279F1B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x279F510", Offset = "0x279E710", VA = "0x18279F510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct JIGAIDNNMJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public KIMPAAHAMJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public JFIBBLJIDCN<HOEALKNOPIA> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public JFIBBLJIDCN<HOEALKNOPIA> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private LAMDCDECGNG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x2798F50", Offset = "0x2798150", VA = "0x182798F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x27992B0", Offset = "0x27984B0", VA = "0x1827992B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct JGACGPIGHNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public KIMPAAHAMJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private LAMDCDECGNG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x2798A60", Offset = "0x2797C60", VA = "0x182798A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x2798EE0", Offset = "0x27980E0", VA = "0x182798EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct LIMOIFIMHAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public KIMPAAHAMJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private LAMDCDECGNG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x279EDF0", Offset = "0x279DFF0", VA = "0x18279EDF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x279F140", Offset = "0x279E340", VA = "0x18279F140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct FLDECOHOGNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public KIMPAAHAMJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public JFIBBLJIDCN<FLAIMFHIJIM> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private LAMDCDECGNG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x2794A20", Offset = "0x2793C20", VA = "0x182794A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x2794D90", Offset = "0x2793F90", VA = "0x182794D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct BMEBILKIFLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public KIMPAAHAMJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public JFIBBLJIDCN<HOEALKNOPIA> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private LAMDCDECGNG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x27858A0", Offset = "0x2784AA0", VA = "0x1827858A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x2785C10", Offset = "0x2784E10", VA = "0x182785C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct HLEKHNNBNGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public KIMPAAHAMJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public HLEKIDHKADJ type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public JFIBBLJIDCN<FLAIMFHIJIM> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private LAMDCDECGNG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x27978D0", Offset = "0x2796AD0", VA = "0x1827978D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x2797C70", Offset = "0x2796E70", VA = "0x182797C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct OFIBFMJHDIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public KIMPAAHAMJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public HLEKIDHKADJ type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public JFIBBLJIDCN<HOEALKNOPIA> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private LAMDCDECGNG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x27A2D70", Offset = "0x27A1F70", VA = "0x1827A2D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x27A3110", Offset = "0x27A2310", VA = "0x1827A3110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private readonly bool FEIKJGIIIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private readonly BMLBDHHGCHG IECLKAPHAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	private readonly bool NLMJGNHLFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private ONBCILOGPEM<BACAMPPLFGC, LLDLFLABLJL> MGCBHOOJFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private ONBCILOGPEM<BACAMPPLFGC, DLMFJDADCBK> APLMGOAKCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private readonly CNJNPCHEFBN JHPJFHAHHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private ONBCILOGPEM<PADJNFOHKPF, NGBMMAGOCEA> MLBHGPLACAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private ONBCILOGPEM<PADJNFOHKPF, JPOFFCOHIDF> DANNMEOEMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	private string? JKMLPPPIMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	private readonly NNGNALIFMDH GOMNKJLKPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	private JFIBBLJIDCN<IMLHFCPAHJM> CJOFGGEOECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	private readonly bool KLGOPDFCHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	[CompilerGenerated]
	private Action? HABKBPIKBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	[CompilerGenerated]
	private Action? HHIFAGPAAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	[CompilerGenerated]
	private Action<JFIBBLJIDCN<BACAMPPLFGC>>? ONIINAEINAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	[CompilerGenerated]
	private Action<JFIBBLJIDCN<PADJNFOHKPF>>? ELANBHNJLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	[CompilerGenerated]
	private DIDHPMBDBJK.IALJIPLLEBP? ODDBIGBHDJB;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool JKMOJKBCLPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x279CFF0", Offset = "0x279C1F0", VA = "0x18279CFF0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool DPLEFPPEMEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x279E140", Offset = "0x279D340", VA = "0x18279E140", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool DOEEPNMBEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x279A070", Offset = "0x2799270", VA = "0x18279A070", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public NICODLFMDAJ<JJGKIIIBOJJ> JKPBDBKCDMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x279C3D0", Offset = "0x279B5D0", VA = "0x18279C3D0", Slot = "7")]
		get
		{
			return default(NICODLFMDAJ<JJGKIIIBOJJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool EGAKNECDDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x279AEF0", Offset = "0x279A0F0", VA = "0x18279AEF0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public ONBCILOGPEM<BACAMPPLFGC, DLMFJDADCBK> JNHHIFHAOEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480", Slot = "9")]
		get
		{
			return default(ONBCILOGPEM<BACAMPPLFGC, DLMFJDADCBK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public string BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x279E980", Offset = "0x279DB80", VA = "0x18279E980", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public NICODLFMDAJ<PKEJDDGKOJK> AOKCFIKGOFO
	{
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x279A2C0", Offset = "0x27994C0", VA = "0x18279A2C0", Slot = "11")]
		get
		{
			return default(NICODLFMDAJ<PKEJDDGKOJK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public ONBCILOGPEM<PADJNFOHKPF, JPOFFCOHIDF> MJMFHHNIGAH
	{
		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x9F2450", Offset = "0x9F1650", VA = "0x1809F2450", Slot = "12")]
		get
		{
			return default(ONBCILOGPEM<PADJNFOHKPF, JPOFFCOHIDF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public JFIBBLJIDCN<IMLHFCPAHJM> DNEAAOEPKGF
	{
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0xBDBA00", Offset = "0xBDAC00", VA = "0x180BDBA00", Slot = "13")]
		get
		{
			return default(JFIBBLJIDCN<IMLHFCPAHJM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action? LPDPKOLFKDP
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x279DFE0", Offset = "0x279D1E0", VA = "0x18279DFE0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x279A220", Offset = "0x2799420", VA = "0x18279A220", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action? ECGAGMAMJCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x279BAF0", Offset = "0x279ACF0", VA = "0x18279BAF0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x279C900", Offset = "0x279BB00", VA = "0x18279C900", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<JFIBBLJIDCN<BACAMPPLFGC?>, JFIBBLJIDCN<BACAMPPLFGC?>>? PPBLBMMAFFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x279CD50", Offset = "0x279BF50", VA = "0x18279CD50", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x279D450", Offset = "0x279C650", VA = "0x18279D450", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<JFIBBLJIDCN<BACAMPPLFGC?>, JFIBBLJIDCN<BACAMPPLFGC?>>? BDOFDKHAIBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x279C840", Offset = "0x279BA40", VA = "0x18279C840", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x279AF70", Offset = "0x279A170", VA = "0x18279AF70", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<JFIBBLJIDCN<PADJNFOHKPF?>, JFIBBLJIDCN<PADJNFOHKPF?>>? JBKDACKGKCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x279BA30", Offset = "0x279AC30", VA = "0x18279BA30", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x279B030", Offset = "0x279A230", VA = "0x18279B030", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<JFIBBLJIDCN<PADJNFOHKPF?>, JFIBBLJIDCN<PADJNFOHKPF?>>? LNBGEGDAPPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x279DF20", Offset = "0x279D120", VA = "0x18279DF20", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x279B730", Offset = "0x279A930", VA = "0x18279B730", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<JFIBBLJIDCN<BACAMPPLFGC?>, DLMFJDADCBK?>? NBONNMENGCA
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x279C310", Offset = "0x279B510", VA = "0x18279C310", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x279E080", Offset = "0x279D280", VA = "0x18279E080", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<JFIBBLJIDCN<BACAMPPLFGC?>>? APPJJGCFKKB
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x279E800", Offset = "0x279DA00", VA = "0x18279E800", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x279B0F0", Offset = "0x279A2F0", VA = "0x18279B0F0", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<JFIBBLJIDCN<BACAMPPLFGC?>, DLMFJDADCBK?>? IJAPJPALICI
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x279DAC0", Offset = "0x279CCC0", VA = "0x18279DAC0", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x279B1B0", Offset = "0x279A3B0", VA = "0x18279B1B0", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<JFIBBLJIDCN<PADJNFOHKPF?>, JPOFFCOHIDF?>? AONOCKONCDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x279BBA0", Offset = "0x279ADA0", VA = "0x18279BBA0", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x279D260", Offset = "0x279C460", VA = "0x18279D260", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<JFIBBLJIDCN<PADJNFOHKPF?>>? FIJOHFKFPPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x279CE10", Offset = "0x279C010", VA = "0x18279CE10", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x279E8C0", Offset = "0x279DAC0", VA = "0x18279E8C0", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<JFIBBLJIDCN<PADJNFOHKPF?>, JPOFFCOHIDF?>? IHNOAKIAANH
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x279A9C0", Offset = "0x2799BC0", VA = "0x18279A9C0", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x279D1A0", Offset = "0x279C3A0", VA = "0x18279D1A0", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x279E9B0", Offset = "0x279DBB0", VA = "0x18279E9B0")]
	private KIMPAAHAMJP(bool HMPJAGJNCCK, BMLBDHHGCHG CCCBLIDEHDI, bool NJJCEFKCNJB, ONBCILOGPEM<BACAMPPLFGC, LLDLFLABLJL> ADHCKOGOIAC, ONBCILOGPEM<BACAMPPLFGC, DLMFJDADCBK> DCAELJCNLLF, CNJNPCHEFBN GCEDHPINDAM, ONBCILOGPEM<PADJNFOHKPF, NGBMMAGOCEA> GNFKEPNJCEC, ONBCILOGPEM<PADJNFOHKPF, JPOFFCOHIDF> LIPBIGEGDAP, string? IALHPNFJLDD, NNGNALIFMDH OOKMNDOJDMN, JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG, bool BAEMHFOCPMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x279E290", Offset = "0x279D490", VA = "0x18279E290")]
	public static KIMPAAHAMJP OIKMHICCLEP(bool HMPJAGJNCCK, BMLBDHHGCHG CCCBLIDEHDI, bool NJJCEFKCNJB, CNJNPCHEFBN GCEDHPINDAM, NNGNALIFMDH OOKMNDOJDMN, JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG, bool BAEMHFOCPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x279B270", Offset = "0x279A470", VA = "0x18279B270", Slot = "69")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x279D0B0", Offset = "0x279C2B0", VA = "0x18279D0B0", Slot = "38")]
	[AsyncStateMachine(typeof(HLOBFDINNAH))]
	public Task<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM?>>? JLLMFLACFNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x279A2E0", Offset = "0x27994E0", VA = "0x18279A2E0")]
	private (CLEPNDDCBFG?, int)? AKCBFOOHPEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x279A130", Offset = "0x2799330", VA = "0x18279A130", Slot = "58")]
	private void AGICPMJANJJ(int HHIOBJHFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x1F8CAB0", Offset = "0x1F8BCB0", VA = "0x181F8CAB0", Slot = "57")]
	private void PLCHPFBJMAM(int HHIOBJHFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x279C400", Offset = "0x279B600", VA = "0x18279C400", Slot = "61")]
	private void GCPPJOLHCGD(int NAGAODEEEFB, int FHNDFELPLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x279C7A0", Offset = "0x279B9A0", VA = "0x18279C7A0", Slot = "63")]
	private void GEHHAEEOIHJ(int NAGAODEEEFB, int FHNDFELPLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x279D510", Offset = "0x279C710", VA = "0x18279D510", Slot = "50")]
	private void KJKALJOLDPK(int HHIOBJHFHJN, JFIBBLJIDCN<BACAMPPLFGC> JJENDHOEICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x279DAA0", Offset = "0x279CCA0", VA = "0x18279DAA0", Slot = "54")]
	private void KJOFKCGFGAI(int NIDPEFPJBOO, JFIBBLJIDCN<BACAMPPLFGC> JJENDHOEICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x279C800", Offset = "0x279BA00", VA = "0x18279C800", Slot = "49")]
	private void GNNCIPHJBOM(int NIDPEFPJBOO, JFIBBLJIDCN<BACAMPPLFGC> JJENDHOEICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x279AA80", Offset = "0x2799C80", VA = "0x18279AA80", Slot = "53")]
	private void BCEJBILIOKC(int HHIOBJHFHJN, JFIBBLJIDCN<BACAMPPLFGC> JJENDHOEICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x279DDD0", Offset = "0x279CFD0", VA = "0x18279DDD0", Slot = "66")]
	private void LBHKKDHHKKJ(int HHIOBJHFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x132DD40", Offset = "0x132CF40", VA = "0x18132DD40", Slot = "65")]
	private void GGHCEONEAPJ(int HHIOBJHFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x279A8D0", Offset = "0x2799AD0", VA = "0x18279A8D0", Slot = "60")]
	private void BBFKAAFKFFJ(int HHIOBJHFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x1F8CAB0", Offset = "0x1F8BCB0", VA = "0x181F8CAB0", Slot = "59")]
	private void KJNLPBDGFFK(int HHIOBJHFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x279C9B0", Offset = "0x279BBB0", VA = "0x18279C9B0", Slot = "62")]
	private void HPBOIDLECLH(int NAGAODEEEFB, int FHNDFELPLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x2799950", Offset = "0x2798B50", VA = "0x182799950", Slot = "64")]
	private void AABINGCCNHC(int NAGAODEEEFB, int FHNDFELPLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x27999B0", Offset = "0x2798BB0", VA = "0x1827999B0", Slot = "52")]
	private void AAGAJCMIBCN(int HHIOBJHFHJN, JFIBBLJIDCN<PADJNFOHKPF> JJENDHOEICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x279AED0", Offset = "0x279A0D0", VA = "0x18279AED0", Slot = "56")]
	private void BDIGEFIFEBO(int NIDPEFPJBOO, JFIBBLJIDCN<PADJNFOHKPF> JJENDHOEICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x279C820", Offset = "0x279BA20", VA = "0x18279C820", Slot = "51")]
	private void HJDMIMEHNJO(int NIDPEFPJBOO, JFIBBLJIDCN<PADJNFOHKPF> JJENDHOEICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x279BEA0", Offset = "0x279B0A0", VA = "0x18279BEA0", Slot = "55")]
	private void GBANLKJNOOP(int HHIOBJHFHJN, JFIBBLJIDCN<PADJNFOHKPF> JJENDHOEICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x279BD50", Offset = "0x279AF50", VA = "0x18279BD50", Slot = "68")]
	private void FOHHGCEIMMB(int HHIOBJHFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x132DD40", Offset = "0x132CF40", VA = "0x18132DD40", Slot = "67")]
	private void CEOKCGHCGPC(int HHIOBJHFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x279B920", Offset = "0x279AB20", VA = "0x18279B920", Slot = "39")]
	[AsyncStateMachine(typeof(FHPCIKMDEMG))]
	public Task<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM?>>? EMAGEDBFEKI(JFIBBLJIDCN<FLAIMFHIJIM> CGNNJJCOPBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x279E180", Offset = "0x279D380", VA = "0x18279E180", Slot = "40")]
	[AsyncStateMachine(typeof(FGJHOGDBKHK))]
	public Task<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM?>>? OIGMNLLKJBI(JFIBBLJIDCN<HOEALKNOPIA> DMLNAJIHPDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x279B610", Offset = "0x279A810", VA = "0x18279B610", Slot = "41")]
	[AsyncStateMachine(typeof(LLCELFFNNFG))]
	public Task<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM?>>? EADEDBMJKIL(JFIBBLJIDCN<FLAIMFHIJIM> CGNNJJCOPBO, JFIBBLJIDCN<FLAIMFHIJIM> DBHJKAMDBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x279CED0", Offset = "0x279C0D0", VA = "0x18279CED0", Slot = "42")]
	[AsyncStateMachine(typeof(JIGAIDNNMJC))]
	public Task<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM?>>? ILBCBDNIIGD(JFIBBLJIDCN<HOEALKNOPIA> DMLNAJIHPDP, JFIBBLJIDCN<HOEALKNOPIA> DBHJKAMDBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x279BC60", Offset = "0x279AE60", VA = "0x18279BC60", Slot = "43")]
	[AsyncStateMachine(typeof(JGACGPIGHNM))]
	public Task<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM?>>? FLBAANHKIPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x279DCB0", Offset = "0x279CEB0", VA = "0x18279DCB0", Slot = "44")]
	[AsyncStateMachine(typeof(LIMOIFIMHAM))]
	public Task<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> KOGJNMDDBDF(string PLJFDFBJOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x279D320", Offset = "0x279C520", VA = "0x18279D320", Slot = "45")]
	[AsyncStateMachine(typeof(FLDECOHOGNB))]
	public Task<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> KHCJMOBEIAF(JFIBBLJIDCN<FLAIMFHIJIM> CGNNJJCOPBO, string DGIAFBEDPNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x279DB80", Offset = "0x279CD80", VA = "0x18279DB80", Slot = "46")]
	[AsyncStateMachine(typeof(BMEBILKIFLL))]
	public Task<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> KMAIJNIMALI(JFIBBLJIDCN<HOEALKNOPIA> DMLNAJIHPDP, string DGIAFBEDPNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x2799F40", Offset = "0x2799140", VA = "0x182799F40", Slot = "47")]
	[AsyncStateMachine(typeof(HLEKHNNBNGB))]
	public Task<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> ABKGOAOIAEG(JFIBBLJIDCN<FLAIMFHIJIM> CGNNJJCOPBO, HLEKIDHKADJ EDLOHJEBKFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x279B7F0", Offset = "0x279A9F0", VA = "0x18279B7F0", Slot = "48")]
	[AsyncStateMachine(typeof(OFIBFMJHDIA))]
	public Task<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> EGBHCLMBAPF(JFIBBLJIDCN<HOEALKNOPIA> DMLNAJIHPDP, HLEKIDHKADJ EDLOHJEBKFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x279A510", Offset = "0x2799710", VA = "0x18279A510")]
	internal void AKNIBJDHEOK(JFIBBLJIDCN<IMLHFCPAHJM> MLCDCHNOCFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public sealed class KAMDFIOBPJP : PACLEKAFKMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public interface BEPILBLDDEM
	{
		[Cpp2IlInjected.Token(Token = "0x20000C4")]
		public readonly struct JLCHMLFLBFC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000271")]
			public readonly IReadOnlyDictionary<NICODLFMDAJ<JJGKIIIBOJJ>, Guid>? KFHEGGGJAFM;

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0xD42160", Offset = "0xD41360", VA = "0x180D42160")]
			public JLCHMLFLBFC(IReadOnlyDictionary<NICODLFMDAJ<JJGKIIIBOJJ>, Guid>? KFHEGGGJAFM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		MEGGMABFBFO HFKJKKAJDGC
		{
			[Cpp2IlInjected.Token(Token = "0x60004CA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<HBBBCDHABCG> ICPGGOLEFIB(CancellationToken HCELDNOKOAM);

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<HAPGMLIDNII> OENDCKNLMNI(CancellationToken HCELDNOKOAM);

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<FLEFAONLOAJ> ANMCLGHBPOG(CancellationToken HCELDNOKOAM);

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<LPOALELDKHA> DEALMBBAAMN(CancellationToken HCELDNOKOAM);

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<JLCHMLFLBFC> BOMOJFCLELE(CancellationToken HCELDNOKOAM);

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<JIPEFLBDMEP> JBGNLEFPHKL(CancellationToken HCELDNOKOAM);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private struct HGCNLODMDJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public AsyncTaskMethodBuilder<KAMDFIOBPJP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public BMLBDHHGCHG circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public HBBBCDHABCG roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public HAPGMLIDNII superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private BEPILBLDDEM <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private HBBBCDHABCG <downloadedRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private HBBBCDHABCG <actualRoomData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private JIPEFLBDMEP <actualStaticConfig>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private HAPGMLIDNII <finalSuperRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private FLEFAONLOAJ <roomAssetData>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private LPOALELDKHA <playerSaveData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private TaskAwaiter<HBBBCDHABCG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private HBBBCDHABCG <>7__wrap8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private TaskAwaiter<JIPEFLBDMEP> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private TaskAwaiter<HAPGMLIDNII> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private TaskAwaiter<FLEFAONLOAJ> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private TaskAwaiter<LPOALELDKHA> <>u__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private TaskAwaiter<BEPILBLDDEM.JLCHMLFLBFC> <>u__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private TaskAwaiter<KFOPAHDCEKH> <>u__7;

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x2796750", Offset = "0x2795950", VA = "0x182796750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x2797800", Offset = "0x2796A00", VA = "0x182797800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	private readonly KFOPAHDCEKH GIAHKJBPHBB;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public KFOPAHDCEKH HHPJLCPBLFA
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
	private KAMDFIOBPJP(KFOPAHDCEKH AFANJBAECID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x27994A0", Offset = "0x27986A0", VA = "0x1827994A0")]
	[AsyncStateMachine(typeof(HGCNLODMDJE))]
	public static Task<KAMDFIOBPJP> JIPJHJKGJPD(BMLBDHHGCHG CCCBLIDEHDI, HBBBCDHABCG? GIKGHELDAKC, HAPGMLIDNII? ALDFCBINAND, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x2799480", Offset = "0x2798680", VA = "0x182799480", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public readonly struct GNIGMIGAFND
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private struct FBBPAHHJOLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<object, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public GNIGMIGAFND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public AGKENLKLGLL action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private TaskAwaiter<LOAMJJJEMNF<object, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x27931A0", Offset = "0x27923A0", VA = "0x1827931A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x2793430", Offset = "0x2792630", VA = "0x182793430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private struct EDGLGFPMMME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<bool, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public NHNBDDEEFPH rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public HBBBCDHABCG circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public HAPGMLIDNII superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public GNIGMIGAFND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private AGKENLKLGLL[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private TaskAwaiter<LOAMJJJEMNF<object, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x2792020", Offset = "0x2791220", VA = "0x182792020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x2792400", Offset = "0x2791600", VA = "0x182792400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private struct AGKLGMPNODB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public GNIGMIGAFND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private TaskAwaiter<LOAMJJJEMNF<object, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x2784C90", Offset = "0x2783E90", VA = "0x182784C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x2784ED0", Offset = "0x27840D0", VA = "0x182784ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private readonly FILIDBMOPNM HOJIPLNENIE;

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0xD42160", Offset = "0xD41360", VA = "0x180D42160")]
	public GNIGMIGAFND(FILIDBMOPNM LJPGHHICBDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x27964C0", Offset = "0x27956C0", VA = "0x1827964C0")]
	[AsyncStateMachine(typeof(FBBPAHHJOLL))]
	private Task<LOAMJJJEMNF<object, PLLHOMFPAAM>> JICLHBDIDDN(AGKENLKLGLL HDKINMMJOHF, bool LKDKFJKIIAP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x2796360", Offset = "0x2795560", VA = "0x182796360")]
	[AsyncStateMachine(typeof(EDGLGFPMMME))]
	public Task<LOAMJJJEMNF<bool, PLLHOMFPAAM?>>? HPJNPFBEDOD(int HLFPNHOFPMK, NHNBDDEEFPH? JLIIGFHECCJ, HBBBCDHABCG? KGABJAIKBPB, HAPGMLIDNII? ALDFCBINAND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x27965F0", Offset = "0x27957F0", VA = "0x1827965F0")]
	[AsyncStateMachine(typeof(AGKLGMPNODB))]
	public Task<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> NHLEMPKJEGJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class GMBFALKLLCI : JKLLNEDIFMH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private readonly OPKEOBGDEAH MGJNFOEMOCK;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public OPKEOBGDEAH MNMKEBFNLKD
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
	private GMBFALKLLCI(OPKEOBGDEAH GOFKKNMBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x2796170", Offset = "0x2795370", VA = "0x182796170")]
	public static GMBFALKLLCI JKAINKAKBPB(BMLBDHHGCHG CCCBLIDEHDI, NHNBDDEEFPH BNCDGLPBPHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x2796150", Offset = "0x2795350", VA = "0x182796150", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public interface KFHNMCPFJED : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	KFOPAHDCEKH HHPJLCPBLFA
	{
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	FAMLAPLNGCO JCJFFMCLIJM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	MJMIAKKOBJB MKPFGKFLJAD
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	CIFBENMLFCL LFBFOMLIKCM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public interface EPPBIMKACJL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	KFHNMCPFJED? KNMPLLKPFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	bool DBBHGEKFDEM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	bool LKNDAINDJKG
	{
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<KFHNMCPFJED?>? FDGLNONOIEB();

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task JPBNLDGKOPF(BMLBDHHGCHG CCCBLIDEHDI, NHNBDDEEFPH BNCDGLPBPHI, HBBBCDHABCG? GBONBIBLNII, HAPGMLIDNII? KBJOIFIPALI);
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[MIMDNFHLCKA("IStaticCV2Instance")]
public interface PACLEKAFKMK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	KFOPAHDCEKH HHPJLCPBLFA
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[MIMDNFHLCKA("IStaticEVInstance")]
public interface JKLLNEDIFMH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	OPKEOBGDEAH MNMKEBFNLKD
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public static class DKELFCPCAPP
{
	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x2791820", Offset = "0x2790A20", VA = "0x182791820")]
	public static DHOEAEODOAI<CJEEPIILMHM, AGKENLKLGLL, BMLBDHHGCHG, BFFLPJPCMEL.LIIAMKACFFM<CJEEPIILMHM, AGKENLKLGLL, BMLBDHHGCHG>> DAFMJJONIEO([In] this DHOEAEODOAI<CJEEPIILMHM, AGKENLKLGLL, BMLBDHHGCHG, BFFLPJPCMEL.LIIAMKACFFM<CJEEPIILMHM, AGKENLKLGLL, BMLBDHHGCHG>> BHBPMGNIGGM)
	{
		return default(DHOEAEODOAI<CJEEPIILMHM, AGKENLKLGLL, BMLBDHHGCHG, BFFLPJPCMEL.LIIAMKACFFM<CJEEPIILMHM, AGKENLKLGLL, BMLBDHHGCHG>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public sealed class MPBMCLBPAHA : AMCDLJABINE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private readonly BMLBDHHGCHG IECLKAPHAHM;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool LKNDAINDJKG
	{
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x279FE20", Offset = "0x279F020", VA = "0x18279FE20", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
	internal MPBMCLBPAHA(BMLBDHHGCHG CCCBLIDEHDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal sealed class LGPAPENJAOP : ILCGECNILOJ
{
	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x279ED50", Offset = "0x279DF50", VA = "0x18279ED50", Slot = "4")]
	public GOBDBEPFHGM? FKPPMNEGGLF(string? JNLIDFAFPGE, string? AHKMMMPMPNG, string? HBLGFEOKPIE, FAHICJPCNKP.LCPHKBFGOAM.GGPMNGJBAGE GJFACACGFDD, bool EBFGKKKBGEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public LGPAPENJAOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public sealed class CHAIPFACECL : LCNLBPCCDOL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private struct BJBJFGDPGDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public AsyncTaskMethodBuilder<DJAFKPAFGEF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public CHAIPFACECL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private TaskAwaiter<KFHNMCPFJED?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x2785590", Offset = "0x2784790", VA = "0x182785590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x2785830", Offset = "0x2784A30", VA = "0x182785830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private readonly BMLBDHHGCHG IECLKAPHAHM;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public DJAFKPAFGEF? NDDGJHHDBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x2788450", Offset = "0x2787650", VA = "0x182788450", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public CIFBENMLFCL? BLLBCDPJPLM
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x27884D0", Offset = "0x27876D0", VA = "0x1827884D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool PPODNFNNEAD
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x2787FE0", Offset = "0x27871E0", VA = "0x182787FE0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool OAAEPHFJMFL
	{
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x2787F80", Offset = "0x2787180", VA = "0x182787F80", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x2788A60", Offset = "0x2787C60", VA = "0x182788A60")]
	internal CHAIPFACECL(BMLBDHHGCHG CCCBLIDEHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x27881E0", Offset = "0x27873E0", VA = "0x1827881E0", Slot = "7")]
	[AsyncStateMachine(typeof(BJBJFGDPGDG))]
	public Task<DJAFKPAFGEF> CJPBBHJAELN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x2788550", Offset = "0x2787750", VA = "0x182788550", Slot = "9")]
	public IReadOnlyDictionary<NICODLFMDAJ<JJGKIIIBOJJ>, Guid> KEJLKGPCMJH(IEnumerable<AOAEIBCNJOH> IJJAGAIDIHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x27882D0", Offset = "0x27874D0", VA = "0x1827882D0", Slot = "10")]
	public DLDLNKNAFJI EHIPBMMECKA(IEnumerable<AOAEIBCNJOH> IJJAGAIDIHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x27888C0", Offset = "0x2787AC0", VA = "0x1827888C0")]
	public LOAMJJJEMNF<GLKGNFMINPH, GEFBDEPLDON> MGBMDFACAOM([In] GLKGNFMINPH LOFOODAKBML)
	{
		return default(LOAMJJJEMNF<GLKGNFMINPH, GEFBDEPLDON>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x2788040", Offset = "0x2787240", VA = "0x182788040", Slot = "8")]
	private LOAMJJJEMNF<GLKGNFMINPH, GEFBDEPLDON> BGCJCMFHEIP([In] GLKGNFMINPH LOFOODAKBML)
	{
		return default(LOAMJJJEMNF<GLKGNFMINPH, GEFBDEPLDON>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public sealed class CIFBENMLFCL : DJAFKPAFGEF
{
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	internal static class FEBKAEENAAN
	{
		[Cpp2IlInjected.Token(Token = "0x20000D7")]
		[CompilerGenerated]
		private sealed class DDBGCFIKODH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002AF")]
			public KFOPAHDCEKH state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002B0")]
			public ICPAFHENLAO spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x6000573")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public DDBGCFIKODH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0x27A86C0", Offset = "0x27A78C0", VA = "0x1827A86C0")]
			internal bool FGKCCKJBACI(KDCAAPPOJLF n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D8")]
		[CompilerGenerated]
		private sealed class JPBBIKPCIKA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002B1")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x6000575")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public JPBBIKPCIKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0x27ADE50", Offset = "0x27AD050", VA = "0x1827ADE50")]
			internal void GGOAGJDLHJG(KDCAAPPOJLF n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x27ABD80", Offset = "0x27AAF80", VA = "0x1827ABD80")]
		public static LOAMJJJEMNF<DJAFKPAFGEF.HOHEBEEJMKM, GDJCDAEPMMG> MENHHIHEOIL(CIFBENMLFCL CEENCLMGJAM, [In] DJAFKPAFGEF.HCBEBDAGJFJ EFGHMCKPMHN)
		{
			return default(LOAMJJJEMNF<DJAFKPAFGEF.HOHEBEEJMKM, GDJCDAEPMMG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x27AAEE0", Offset = "0x27AA0E0", VA = "0x1827AAEE0")]
		internal static LOAMJJJEMNF<(LIMPHJEMNLD, KOAPGOKLEPE), GDJCDAEPMMG> INJLLLAEKNB(CIFBENMLFCL CEENCLMGJAM, KOAPGOKLEPE JHBAGHLPLIE, bool FCLFFPNGOKL, [In] NICODLFMDAJ<JJGKIIIBOJJ> FMMIMFOFPJB, [In] int? LCAFLJFGCPF, [In] ELIDMAMFOFN? EFMOLMNICDH, [In] ELIDMAMFOFN? KAPKNEIAJDI)
		{
			return default(LOAMJJJEMNF<(LIMPHJEMNLD, KOAPGOKLEPE), GDJCDAEPMMG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x27AAA60", Offset = "0x27A9C60", VA = "0x1827AAA60")]
		private static void IHPLPBPLKCG(bool FCLFFPNGOKL, AOAEIBCNJOH COAOCPHILMM, LIMPHJEMNLD KONLDPKBBDD, [In] NICODLFMDAJ<JJGKIIIBOJJ> FMMIMFOFPJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x27AA570", Offset = "0x27A9770", VA = "0x1827AA570")]
		public static void FAJJGDFEJHL(MOKIDEKEKAD OKLLFGEBJJF, [In] DJAFKPAFGEF.OEOADIFHDIG GKOJJGKMFKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x27AA970", Offset = "0x27A9B70", VA = "0x1827AA970")]
		[CompilerGenerated]
		internal static bool HLDNACDDCOO(KFOPAHDCEKH MFNNHFPDHDC, ICPAFHENLAO NPKGNJPCGOC, KDCAAPPOJLF JHNLNBKOAFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x27ABD50", Offset = "0x27AAF50", VA = "0x1827ABD50")]
		[CompilerGenerated]
		internal static bool LELOGDOEOLG(KDCAAPPOJLF HHHCEJKIPDB)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct BPPNHPNFFHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public CIFBENMLFCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public JFIBBLJIDCN<JJGKIIIBOJJ> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public JFIBBLJIDCN<PKEJDDGKOJK> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public EKEFPBJPEEO offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public bool deleteBoard;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x27A6110", Offset = "0x27A5310", VA = "0x1827A6110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x27A6360", Offset = "0x27A5560", VA = "0x1827A6360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private struct LJDGGGGBMFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public CIFBENMLFCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public JFIBBLJIDCN<JJGKIIIBOJJ> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public NICODLFMDAJ<PKEJDDGKOJK> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public List<JFIBBLJIDCN<PKEJDDGKOJK>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public EKEFPBJPEEO localBoardPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public DMHPCPNFAPH localBoardRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public EKEFPBJPEEO offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x27AEA90", Offset = "0x27ADC90", VA = "0x1827AEA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x27AED50", Offset = "0x27ADF50", VA = "0x1827AED50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct LABABDNMLLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public CIFBENMLFCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public JFIBBLJIDCN<JJGKIIIBOJJ> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public NICODLFMDAJ<PKEJDDGKOJK> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public List<JFIBBLJIDCN<PKEJDDGKOJK>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x27AE490", Offset = "0x27AD690", VA = "0x1827AE490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x27AE6D0", Offset = "0x27AD8D0", VA = "0x1827AE6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[CompilerGenerated]
	private struct IJMAMKMKKNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public CIFBENMLFCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public JFIBBLJIDCN<JJGKIIIBOJJ> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public NICODLFMDAJ<PKEJDDGKOJK> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public JFIBBLJIDCN<JJGKIIIBOJJ> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public List<JFIBBLJIDCN<PKEJDDGKOJK>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x27AD3A0", Offset = "0x27AC5A0", VA = "0x1827AD3A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x27AD5E0", Offset = "0x27AC7E0", VA = "0x1827AD5E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private struct CIONODKJGGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public CIFBENMLFCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public NICODLFMDAJ<JJGKIIIBOJJ> legacyGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public NICODLFMDAJ<PKEJDDGKOJK> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public IReadOnlyList<NICODLFMDAJ<PKEJDDGKOJK>> nodeLegacyIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public IReadOnlyDictionary<EMFGBMOKCLK, (JFIBBLJIDCN<IMLHFCPAHJM>, JFIBBLJIDCN<BACAMPPLFGC>)> inputMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public IReadOnlyDictionary<BGOCPCCJMMH, (JFIBBLJIDCN<IMLHFCPAHJM>, JFIBBLJIDCN<PADJNFOHKPF>)> outputMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x27A63D0", Offset = "0x27A55D0", VA = "0x1827A63D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x27A6980", Offset = "0x27A5B80", VA = "0x1827A6980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private struct DDDBNIPKGHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public CIFBENMLFCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public JFIBBLJIDCN<JJGKIIIBOJJ> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public JFIBBLJIDCN<KLMHALNMEAA> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public JFIBBLJIDCN<PFJDLPPNNBM> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x27A87B0", Offset = "0x27A79B0", VA = "0x1827A87B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x27A8E00", Offset = "0x27A8000", VA = "0x1827A8E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[CompilerGenerated]
	private struct JOCPKDCOFAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<JFIBBLJIDCN<PKEJDDGKOJK>, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public CIFBENMLFCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public JFIBBLJIDCN<JJGKIIIBOJJ> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public JFIBBLJIDCN<KLCJLFMFFFM> nodeDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public EKEFPBJPEEO localSpacePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public DMHPCPNFAPH localSpaceRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private KFOPAHDCEKH <state>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private TaskAwaiter<LOAMJJJEMNF<Guid, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x27AD960", Offset = "0x27ACB60", VA = "0x1827AD960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x27ADDE0", Offset = "0x27ACFE0", VA = "0x1827ADDE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[CompilerGenerated]
	private struct JFGCDGHLDKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<JFIBBLJIDCN<IMLHFCPAHJM>, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public CIFBENMLFCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public JFIBBLJIDCN<JJGKIIIBOJJ> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public JFIBBLJIDCN<PKEJDDGKOJK> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private TaskAwaiter<LOAMJJJEMNF<JFIBBLJIDCN<IMLHFCPAHJM>, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x27AD650", Offset = "0x27AC850", VA = "0x1827AD650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x27AD8F0", Offset = "0x27ACAF0", VA = "0x1827AD8F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	[CompilerGenerated]
	private struct AHLCMOHFFCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public CIFBENMLFCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public NICODLFMDAJ<PKEJDDGKOJK> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public NICODLFMDAJ<JJGKIIIBOJJ> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public JFIBBLJIDCN<IMLHFCPAHJM> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public JFIBBLJIDCN<BACAMPPLFGC> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x27A57A0", Offset = "0x27A49A0", VA = "0x1827A57A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x27A5AE0", Offset = "0x27A4CE0", VA = "0x1827A5AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[CompilerGenerated]
	private struct EKOLKCEIPCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public CIFBENMLFCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public NICODLFMDAJ<PKEJDDGKOJK> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public NICODLFMDAJ<JJGKIIIBOJJ> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public JFIBBLJIDCN<IMLHFCPAHJM> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public JFIBBLJIDCN<PADJNFOHKPF> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x27A9EB0", Offset = "0x27A90B0", VA = "0x1827A9EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x27AA1F0", Offset = "0x27A93F0", VA = "0x1827AA1F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[CompilerGenerated]
	private struct BJJIIDLGAKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public CIFBENMLFCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public JFIBBLJIDCN<JJGKIIIBOJJ> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public JFIBBLJIDCN<PKEJDDGKOJK> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x27A5DB0", Offset = "0x27A4FB0", VA = "0x1827A5DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x27A60A0", Offset = "0x27A52A0", VA = "0x1827A60A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private struct IFGDFNGJMLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<IEnumerable<NICODLFMDAJ<PKEJDDGKOJK>>, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public CIFBENMLFCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public NICODLFMDAJ<JJGKIIIBOJJ> intoGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public IEnumerable<AOAEIBCNJOH> persistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public KOAPGOKLEPE templateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private TaskAwaiter<LOAMJJJEMNF<IEnumerable<CNJNPCHEFBN>, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x27ACCB0", Offset = "0x27ABEB0", VA = "0x1827ACCB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x27AD330", Offset = "0x27AC530", VA = "0x1827AD330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class CJOMHLCFNBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public CIFBENMLFCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public JFIBBLJIDCN<JJGKIIIBOJJ> sourceGraphId;

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public CJOMHLCFNBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x27A69E0", Offset = "0x27A5BE0", VA = "0x1827A69E0")]
		internal NICODLFMDAJ<PKEJDDGKOJK> HOBHICANFEH(JFIBBLJIDCN<PKEJDDGKOJK> i)
		{
			return default(NICODLFMDAJ<PKEJDDGKOJK>);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private struct ONMOJLPOFHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public CIFBENMLFCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x27AF780", Offset = "0x27AE980", VA = "0x1827AF780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x27AF9A0", Offset = "0x27AEBA0", VA = "0x1827AF9A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[CompilerGenerated]
	private struct KJDIIAEIGMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public CIFBENMLFCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public JFIBBLJIDCN<JJGKIIIBOJJ> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public JFIBBLJIDCN<PKEJDDGKOJK> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x27AE180", Offset = "0x27AD380", VA = "0x1827AE180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x27AE420", Offset = "0x27AD620", VA = "0x1827AE420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private struct PPBEKOAJKOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public CIFBENMLFCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public JFIBBLJIDCN<JJGKIIIBOJJ> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public JFIBBLJIDCN<PKEJDDGKOJK> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public JFIBBLJIDCN<IMLHFCPAHJM> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public JFIBBLJIDCN<FLAIMFHIJIM> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x27AFA10", Offset = "0x27AEC10", VA = "0x1827AFA10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x27AFD80", Offset = "0x27AEF80", VA = "0x1827AFD80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private struct HAEDOPJOCII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public CIFBENMLFCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public JFIBBLJIDCN<JJGKIIIBOJJ> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public JFIBBLJIDCN<PKEJDDGKOJK> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public JFIBBLJIDCN<IMLHFCPAHJM> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public JFIBBLJIDCN<FLAIMFHIJIM> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x27AC6C0", Offset = "0x27AB8C0", VA = "0x1827AC6C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x27ACB30", Offset = "0x27ABD30", VA = "0x1827ACB30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private struct JPJKFOPKCKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public CIFBENMLFCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public JFIBBLJIDCN<JJGKIIIBOJJ> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public JFIBBLJIDCN<PKEJDDGKOJK> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x27ADE70", Offset = "0x27AD070", VA = "0x1827ADE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x27AE110", Offset = "0x27AD310", VA = "0x1827AE110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private struct EGLFOEKBGEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public CIFBENMLFCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public JFIBBLJIDCN<JJGKIIIBOJJ> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public JFIBBLJIDCN<PKEJDDGKOJK> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public EKEFPBJPEEO localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public DMHPCPNFAPH localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private TaskAwaiter<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x27A9AF0", Offset = "0x27A8CF0", VA = "0x1827A9AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x27A9E40", Offset = "0x27A9040", VA = "0x1827A9E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	private readonly BMLBDHHGCHG IECLKAPHAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	private readonly PACLEKAFKMK DMFDBIKEBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	private readonly JKLLNEDIFMH MFHBMFIKKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	private readonly DMJADDJKIFI CHHGPBBEOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	private readonly CHAIPFACECL NIDAGGAJCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	private Dictionary<NICODLFMDAJ<PKEJDDGKOJK>, DBLLIICDFED> ICIGGGPLJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	[CompilerGenerated]
	private Action<NICODLFMDAJ<PKEJDDGKOJK>>? CBPJIHJANLO;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public NICODLFMDAJ<JJGKIIIBOJJ> HBBKBGBJFDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x278FAC0", Offset = "0x278ECC0", VA = "0x18278FAC0", Slot = "4")]
		get
		{
			return default(NICODLFMDAJ<JJGKIIIBOJJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public DMJADDJKIFI CGHLBDOIJGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x27733E0", Offset = "0x27725E0", VA = "0x1827733E0", Slot = "5")]
		get
		{
			return default(DMJADDJKIFI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x2790FF0", Offset = "0x27901F0", VA = "0x182790FF0")]
	public CIFBENMLFCL(BMLBDHHGCHG CCCBLIDEHDI, PACLEKAFKMK GNCHNFLHMAC, JKLLNEDIFMH INGCPKGHKBK, CHAIPFACECL JELPMNAKAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x278BB40", Offset = "0x278AD40", VA = "0x18278BB40", Slot = "83")]
	public JFIBBLJIDCN<FAIOCFLCPBP> FFJLLCIIPEI(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PFJDLPPNNBM> HAPCGDBBODD)
	{
		return default(JFIBBLJIDCN<FAIOCFLCPBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x278A780", Offset = "0x2789980", VA = "0x18278A780", Slot = "84")]
	public JFIBBLJIDCN<EJFMCNHIBMC> DJKALLNHBMB(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<KLMHALNMEAA> DAPOJGPODED)
	{
		return default(JFIBBLJIDCN<EJFMCNHIBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x278B120", Offset = "0x278A320", VA = "0x18278B120", Slot = "6")]
	public (bool, bool) EIIJBCDHOCF(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<KLMHALNMEAA> KHHBPMLEJLG, JFIBBLJIDCN<PFJDLPPNNBM> FMIMEMJAMNF)
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x278C5F0", Offset = "0x278B7F0", VA = "0x18278C5F0")]
	public bool JBOLDMJDDEG(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, [In] IJGKPBKEJIE NCBPFCPJMAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x278BEB0", Offset = "0x278B0B0", VA = "0x18278BEB0", Slot = "8")]
	public bool GOLEGOJLBMK(DLMFJDADCBK HOFFILDDDBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x278D9B0", Offset = "0x278CBB0", VA = "0x18278D9B0", Slot = "9")]
	public bool KECNDCMDDJJ(JPOFFCOHIDF GEMKLODFJPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x278B060", Offset = "0x278A260", VA = "0x18278B060", Slot = "10")]
	public AMDCDACLNEK? EHPAOFGEJAO(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PFJDLPPNNBM> HAPCGDBBODD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x2790560", Offset = "0x278F760", VA = "0x182790560", Slot = "11")]
	public LNAPJNBGIAM? POGJPNLLIGO(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<KLMHALNMEAA> DAPOJGPODED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x27892A0", Offset = "0x27884A0", VA = "0x1827892A0", Slot = "12")]
	public JFIBBLJIDCN<KLMHALNMEAA>? AMKGDEBBIOK(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL, JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG, JFIBBLJIDCN<PADJNFOHKPF> ACPHKIIOJAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x278C080", Offset = "0x278B280", VA = "0x18278C080", Slot = "13")]
	public JFIBBLJIDCN<PFJDLPPNNBM>? HBBBJMKLKIB(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL, JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG, JFIBBLJIDCN<BACAMPPLFGC> HIILHOHJDGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x278E7A0", Offset = "0x278D9A0", VA = "0x18278E7A0", Slot = "14")]
	public IEnumerable<JFIBBLJIDCN<JJGKIIIBOJJ>> MBDHGIAEOML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x278E9A0", Offset = "0x278DBA0", VA = "0x18278E9A0", Slot = "15")]
	public IEnumerable<JFIBBLJIDCN<PGBDOOFBIKC>> MHBODFOFGHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x2789590", Offset = "0x2788790", VA = "0x182789590", Slot = "16")]
	public string BGLCHKKGOAD(JFIBBLJIDCN<PGBDOOFBIKC> CPNGNJOIFCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x278DDE0", Offset = "0x278CFE0", VA = "0x18278DDE0", Slot = "17")]
	public string KLPIIDAJIIO(JFIBBLJIDCN<PGBDOOFBIKC> CPNGNJOIFCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x278AE40", Offset = "0x278A040", VA = "0x18278AE40")]
	public DBLLIICDFED? EGGPANIBEHO([In] NICODLFMDAJ<PKEJDDGKOJK> CANDMCKMDKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x278EA50", Offset = "0x278DC50", VA = "0x18278EA50", Slot = "23")]
	public JFIBBLJIDCN<KLCJLFMFFFM> NBCBNAIIKDH(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL)
	{
		return default(JFIBBLJIDCN<KLCJLFMFFFM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x278BAC0", Offset = "0x278ACC0", VA = "0x18278BAC0")]
	public JFIBBLJIDCN<PKEJDDGKOJK> FCKEPNJKMKL(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, [In] NICODLFMDAJ<PKEJDDGKOJK> MIAKDPHABPI)
	{
		return default(JFIBBLJIDCN<PKEJDDGKOJK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x278ADC0", Offset = "0x2789FC0", VA = "0x18278ADC0", Slot = "33")]
	public JFIBBLJIDCN<PKEJDDGKOJK> EDCKJGDABLD(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PFJDLPPNNBM> HAPCGDBBODD)
	{
		return default(JFIBBLJIDCN<PKEJDDGKOJK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x278E830", Offset = "0x278DA30", VA = "0x18278E830", Slot = "34")]
	public JFIBBLJIDCN<PKEJDDGKOJK> MCOBAIGIGIN(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<KLMHALNMEAA> DAPOJGPODED)
	{
		return default(JFIBBLJIDCN<PKEJDDGKOJK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x278F790", Offset = "0x278E990", VA = "0x18278F790")]
	public JFIBBLJIDCN<PKEJDDGKOJK>? NLFEEOBICAF(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, [In] NICODLFMDAJ<PKEJDDGKOJK> MIAKDPHABPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x278E0E0", Offset = "0x278D2E0", VA = "0x18278E0E0", Slot = "25")]
	public KOBMKDKBAEM? LEDFFCKFPIC(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x278E450", Offset = "0x278D650", VA = "0x18278E450", Slot = "26")]
	public long LKFDENJMLAB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x2790160", Offset = "0x278F360", VA = "0x182790160")]
	private void PFEGKKCLBOC(NICODLFMDAJ<PKEJDDGKOJK> CANDMCKMDKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x278AFB0", Offset = "0x278A1B0", VA = "0x18278AFB0", Slot = "31")]
	public IEnumerable<(JFIBBLJIDCN<JJGKIIIBOJJ>, JFIBBLJIDCN<PKEJDDGKOJK>)> EGHHJNONKML(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x278C110", Offset = "0x278B310", VA = "0x18278C110", Slot = "32")]
	public JFIBBLJIDCN<PFJDLPPNNBM> HBBBJMKLKIB(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL, JFIBBLJIDCN<FAIOCFLCPBP> HIILHOHJDGC)
	{
		return default(JFIBBLJIDCN<PFJDLPPNNBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x2789210", Offset = "0x2788410", VA = "0x182789210", Slot = "35")]
	public JFIBBLJIDCN<KLMHALNMEAA> AMKGDEBBIOK(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL, JFIBBLJIDCN<EJFMCNHIBMC> ACPHKIIOJAK)
	{
		return default(JFIBBLJIDCN<KLMHALNMEAA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x278DAB0", Offset = "0x278CCB0", VA = "0x18278DAB0")]
	private DBLLIICDFED? KKMFJFKNHCD([In] NICODLFMDAJ<PKEJDDGKOJK> CANDMCKMDKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x278F5B0", Offset = "0x278E7B0", VA = "0x18278F5B0")]
	public CNJNPCHEFBN? NFHIOBFBBJD([In] NICODLFMDAJ<PKEJDDGKOJK> CANDMCKMDKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x278A2F0", Offset = "0x27894F0", VA = "0x18278A2F0")]
	public KLOPJCOPMLK? CMCFGCCHLBO([In] NICODLFMDAJ<JJGKIIIBOJJ> EEKBMGEEJKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x278DFC0", Offset = "0x278D1C0", VA = "0x18278DFC0", Slot = "27")]
	public IEnumerable<CAHHBAHBJJE> LCOMNKGEOGM(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x278A260", Offset = "0x2789460", VA = "0x18278A260", Slot = "28")]
	public bool CJFHDMFLEMB(JFIBBLJIDCN<PGBDOOFBIKC> CPNGNJOIFCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x278A450", Offset = "0x2789650", VA = "0x18278A450", Slot = "29")]
	public IEnumerable<IJGKPBKEJIE> CMMBBJNNOPK(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<KLMHALNMEAA> KHHBPMLEJLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x278DB60", Offset = "0x278CD60", VA = "0x18278DB60", Slot = "30")]
	public IEnumerable<IJGKPBKEJIE> KLIDDFFGLFB(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PFJDLPPNNBM> FMIMEMJAMNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x278FC50", Offset = "0x278EE50", VA = "0x18278FC50")]
	public JFIBBLJIDCN<JJGKIIIBOJJ> OPGPAIFBIAJ([In] NICODLFMDAJ<JJGKIIIBOJJ> EEKBMGEEJKM)
	{
		return default(JFIBBLJIDCN<JJGKIIIBOJJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x2789910", Offset = "0x2788B10", VA = "0x182789910")]
	public JFIBBLJIDCN<JJGKIIIBOJJ>? CCOFLAKOLCB([In] NICODLFMDAJ<JJGKIIIBOJJ> EEKBMGEEJKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x278BDE0", Offset = "0x278AFE0", VA = "0x18278BDE0")]
	private ICPAFHENLAO? GKLLCIIDFJB([In] NICODLFMDAJ<JJGKIIIBOJJ> EEKBMGEEJKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x278A2F0", Offset = "0x27894F0", VA = "0x18278A2F0")]
	private KLOPJCOPMLK? LIFEBOHBAJM([In] NICODLFMDAJ<JJGKIIIBOJJ> EEKBMGEEJKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x278FB20", Offset = "0x278ED20", VA = "0x18278FB20", Slot = "21")]
	public JFIBBLJIDCN<JJGKIIIBOJJ>? OMLPDGOOJAJ(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x278A940", Offset = "0x2789B40", VA = "0x18278A940", Slot = "39")]
	public NICODLFMDAJ<JJGKIIIBOJJ> DLMICLJGBLN(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM)
	{
		return default(NICODLFMDAJ<JJGKIIIBOJJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x278D2F0", Offset = "0x278C4F0", VA = "0x18278D2F0", Slot = "40")]
	public NICODLFMDAJ<PKEJDDGKOJK> JNMMELFLGNE(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL)
	{
		return default(NICODLFMDAJ<PKEJDDGKOJK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x2789490", Offset = "0x2788690", VA = "0x182789490", Slot = "36")]
	public IEnumerable<HLEKIDHKADJ> AODLCLKAHPN(BDHCOKDFMAE PKIGDLACJPB, bool DHIDOOEHDBM, bool LJHJPDBEEED, bool CKPKDHDENBL, bool JDEJDBNADOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x2790260", Offset = "0x278F460", VA = "0x182790260", Slot = "37")]
	public HLEKIDHKADJ PLFPGKCFEDP(BDHCOKDFMAE PKIGDLACJPB, DEEMKFDPNME GKCPCOLCJCN, bool DHIDOOEHDBM, bool LJHJPDBEEED, bool CKPKDHDENBL, bool JDEJDBNADOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x278DE50", Offset = "0x278D050", VA = "0x18278DE50")]
	public CAHHBAHBJJE OKHFOHOBEDP(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, [In] IJGKPBKEJIE NCBPFCPJMAH)
	{
		return default(CAHHBAHBJJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x278A9B0", Offset = "0x2789BB0", VA = "0x18278A9B0", Slot = "41")]
	public IJGKPBKEJIE DMGCCMBMCFN(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<KLMHALNMEAA> KHHBPMLEJLG, JFIBBLJIDCN<PFJDLPPNNBM> FMIMEMJAMNF)
	{
		return default(IJGKPBKEJIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x27890C0", Offset = "0x27882C0", VA = "0x1827890C0", Slot = "42")]
	[AsyncStateMachine(typeof(BPPNHPNFFHH))]
	public Task<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> AHDJNOKJNBE(JFIBBLJIDCN<JJGKIIIBOJJ> GNANPNCDLKF, JFIBBLJIDCN<PKEJDDGKOJK> NEHHMBCJKJC, EKEFPBJPEEO OEBFFKLMAPN, bool PGOKOHFEGCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x2789BE0", Offset = "0x2788DE0", VA = "0x182789BE0", Slot = "43")]
	[AsyncStateMachine(typeof(LJDGGGGBMFI))]
	public Task<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> CGJNEHINEAP(JFIBBLJIDCN<JJGKIIIBOJJ> GNANPNCDLKF, NICODLFMDAJ<PKEJDDGKOJK> NEHHMBCJKJC, List<JFIBBLJIDCN<PKEJDDGKOJK>> MHMHBMFIPGB, EKEFPBJPEEO BDIPLMLOOIH, DMHPCPNFAPH JHKGAMGDJJM, EKEFPBJPEEO OEBFFKLMAPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x278F640", Offset = "0x278E840", VA = "0x18278F640", Slot = "46")]
	[AsyncStateMachine(typeof(LABABDNMLLJ))]
	public Task<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> NGOEPHHHENL(JFIBBLJIDCN<JJGKIIIBOJJ> GNANPNCDLKF, NICODLFMDAJ<PKEJDDGKOJK> NEHHMBCJKJC, List<JFIBBLJIDCN<PKEJDDGKOJK>> MHMHBMFIPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x278D730", Offset = "0x278C930", VA = "0x18278D730", Slot = "47")]
	[AsyncStateMachine(typeof(IJMAMKMKKNG))]
	public Task<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> KBHKGKFNFMB(JFIBBLJIDCN<JJGKIIIBOJJ> GNANPNCDLKF, NICODLFMDAJ<PKEJDDGKOJK> NEHHMBCJKJC, JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, List<JFIBBLJIDCN<PKEJDDGKOJK>> MHMHBMFIPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x278C320", Offset = "0x278B520", VA = "0x18278C320", Slot = "44")]
	public (IReadOnlyDictionary<EMFGBMOKCLK, (JFIBBLJIDCN<IMLHFCPAHJM>, JFIBBLJIDCN<BACAMPPLFGC>)>, IReadOnlyDictionary<BGOCPCCJMMH, (JFIBBLJIDCN<IMLHFCPAHJM>, JFIBBLJIDCN<PADJNFOHKPF>)>) IKCHKPANGMI(NICODLFMDAJ<JJGKIIIBOJJ> KGBOLHLELDL, JFIBBLJIDCN<PKEJDDGKOJK> NEHHMBCJKJC)
	{
		return default((IReadOnlyDictionary<EMFGBMOKCLK, (JFIBBLJIDCN<IMLHFCPAHJM>, JFIBBLJIDCN<BACAMPPLFGC>)>, IReadOnlyDictionary<BGOCPCCJMMH, (JFIBBLJIDCN<IMLHFCPAHJM>, JFIBBLJIDCN<PADJNFOHKPF>)>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x2789D90", Offset = "0x2788F90", VA = "0x182789D90", Slot = "45")]
	[AsyncStateMachine(typeof(CIONODKJGGP))]
	public Task CHGLIPNMHMP(NICODLFMDAJ<JJGKIIIBOJJ> KGBOLHLELDL, NICODLFMDAJ<PKEJDDGKOJK> NEHHMBCJKJC, IReadOnlyList<NICODLFMDAJ<PKEJDDGKOJK>> JHIJHCDDKOH, IReadOnlyDictionary<EMFGBMOKCLK, (JFIBBLJIDCN<IMLHFCPAHJM>, JFIBBLJIDCN<BACAMPPLFGC>)> ONJMEPFKFID, IReadOnlyDictionary<BGOCPCCJMMH, (JFIBBLJIDCN<IMLHFCPAHJM>, JFIBBLJIDCN<PADJNFOHKPF>)> CJOFBBJJFIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x27901F0", Offset = "0x278F3F0", VA = "0x1827901F0", Slot = "48")]
	public bool PHHHHNJJIMJ(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x278ABE0", Offset = "0x2789DE0", VA = "0x18278ABE0", Slot = "49")]
	public bool DPPBGEHPCNC(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PFJDLPPNNBM> HAPCGDBBODD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x278F8A0", Offset = "0x278EAA0", VA = "0x18278F8A0", Slot = "50")]
	public bool ODOAECHMLNC(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<KLMHALNMEAA> DAPOJGPODED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x2789D60", Offset = "0x2788F60", VA = "0x182789D60")]
	public LOAMJJJEMNF<DJAFKPAFGEF.HOHEBEEJMKM, GDJCDAEPMMG> CHBFNBLBOIN([In] DJAFKPAFGEF.HCBEBDAGJFJ EFGHMCKPMHN)
	{
		return default(LOAMJJJEMNF<DJAFKPAFGEF.HOHEBEEJMKM, GDJCDAEPMMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x278EAD0", Offset = "0x278DCD0", VA = "0x18278EAD0", Slot = "52")]
	[AsyncStateMachine(typeof(DDDBNIPKGHA))]
	public Task<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> NCOJJAKLBPP(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<KLMHALNMEAA> KHHBPMLEJLG, JFIBBLJIDCN<PFJDLPPNNBM> FMIMEMJAMNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x278AC60", Offset = "0x2789E60", VA = "0x18278AC60", Slot = "53")]
	[AsyncStateMachine(typeof(JOCPKDCOFAO))]
	public Task<LOAMJJJEMNF<JFIBBLJIDCN<PKEJDDGKOJK>, PLLHOMFPAAM>> EACPKFBIBFH(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<KLCJLFMFFFM> EPKMJEDGIDD, EKEFPBJPEEO AIKINAKEEAI, DMHPCPNFAPH OENCKFGAGBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x2788E30", Offset = "0x2788030", VA = "0x182788E30", Slot = "54")]
	[AsyncStateMachine(typeof(JFGCDGHLDKA))]
	public Task<LOAMJJJEMNF<JFIBBLJIDCN<IMLHFCPAHJM>, PLLHOMFPAAM>> ABNAAOHONLM(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL, string DGIAFBEDPNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x278D370", Offset = "0x278C570", VA = "0x18278D370", Slot = "55")]
	public LOAMJJJEMNF<EPLDKCJLFCI, GEFBDEPLDON> KBGIKKJKKDC(NICODLFMDAJ<JJGKIIIBOJJ> EEKBMGEEJKM, EPLDKCJLFCI HLKOPHCPAPH, DMHPCPNFAPH JEFJJBFMFAB)
	{
		return default(LOAMJJJEMNF<EPLDKCJLFCI, GEFBDEPLDON>);
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x278E2F0", Offset = "0x278D4F0", VA = "0x18278E2F0", Slot = "56")]
	[AsyncStateMachine(typeof(AHLCMOHFFCK))]
	public Task<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> LKAJJGBNJNN(NICODLFMDAJ<JJGKIIIBOJJ> EEKBMGEEJKM, NICODLFMDAJ<PKEJDDGKOJK> OGKJGHHMCEJ, JFIBBLJIDCN<IMLHFCPAHJM> DMMPOGOOAMO, JFIBBLJIDCN<BACAMPPLFGC> HAPCGDBBODD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x2789330", Offset = "0x2788530", VA = "0x182789330", Slot = "57")]
	[AsyncStateMachine(typeof(EKOLKCEIPCH))]
	public Task<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> AOBACGJCKJH(NICODLFMDAJ<JJGKIIIBOJJ> EEKBMGEEJKM, NICODLFMDAJ<PKEJDDGKOJK> FBGLNFJBNFJ, JFIBBLJIDCN<IMLHFCPAHJM> FGFEKNFJEIM, JFIBBLJIDCN<PADJNFOHKPF> DAPOJGPODED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x278F4A0", Offset = "0x278E6A0", VA = "0x18278F4A0", Slot = "58")]
	[AsyncStateMachine(typeof(BJJIIDLGAKB))]
	public Task<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> NEHCKDMNJNF(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x278E5D0", Offset = "0x278D7D0", VA = "0x18278E5D0", Slot = "59")]
	[AsyncStateMachine(typeof(IFGDFNGJMLP))]
	public Task<LOAMJJJEMNF<IEnumerable<NICODLFMDAJ<PKEJDDGKOJK>>, PLLHOMFPAAM>> LOEIMDNLABI(NICODLFMDAJ<JJGKIIIBOJJ> FPILOMLFIBK, KOAPGOKLEPE KCIAAGAALML, IEnumerable<AOAEIBCNJOH> JBDOMHNKPDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x2789990", Offset = "0x2788B90", VA = "0x182789990", Slot = "60")]
	public NKKGOBEEHAJ CDIPCPJJNFM()
	{
		return default(NKKGOBEEHAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x278D890", Offset = "0x278CA90", VA = "0x18278D890", Slot = "61")]
	public NKKGOBEEHAJ KDMAMJPGHPD()
	{
		return default(NKKGOBEEHAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x278F2C0", Offset = "0x278E4C0", VA = "0x18278F2C0", Slot = "64")]
	public PFGGOEPCHAB NDKEEIAKFKH(PCFHIBGFAHG BPPEGJEBCFP, JFIBBLJIDCN<JJGKIIIBOJJ> NJPHHHODCEO, IEnumerable<NICODLFMDAJ<JJGKIIIBOJJ>> IKNNDGHBKNK, IEnumerable<NICODLFMDAJ<PKEJDDGKOJK>> MHMHBMFIPGB, ISet<NICODLFMDAJ<LNBOIECBEGJ>>? GPJDEDABFAD)
	{
		return default(PFGGOEPCHAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x2789600", Offset = "0x2788800", VA = "0x182789600")]
	private PFGGOEPCHAB BHKLFAFIMHF(PCFHIBGFAHG BPPEGJEBCFP, JFIBBLJIDCN<JJGKIIIBOJJ> NJPHHHODCEO, IEnumerable<NICODLFMDAJ<JJGKIIIBOJJ>> IKNNDGHBKNK, IEnumerable<NICODLFMDAJ<PKEJDDGKOJK>> MHMHBMFIPGB, ISet<NICODLFMDAJ<LNBOIECBEGJ>>? GPJDEDABFAD)
	{
		return default(PFGGOEPCHAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x278B620", Offset = "0x278A820", VA = "0x18278B620", Slot = "62")]
	public PFGGOEPCHAB EMMHLDBJGJB(PCFHIBGFAHG BPPEGJEBCFP, JFIBBLJIDCN<JJGKIIIBOJJ> NJPHHHODCEO, IEnumerable<NICODLFMDAJ<PKEJDDGKOJK>> MHMHBMFIPGB, IEnumerable<AOAEIBCNJOH> JBDOMHNKPDL, ISet<NICODLFMDAJ<LNBOIECBEGJ>>? GPJDEDABFAD)
	{
		return default(PFGGOEPCHAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x278B8C0", Offset = "0x278AAC0", VA = "0x18278B8C0", Slot = "63")]
	public PFGGOEPCHAB EMMHLDBJGJB(PCFHIBGFAHG BPPEGJEBCFP, JFIBBLJIDCN<JJGKIIIBOJJ> NJPHHHODCEO, IEnumerable<JFIBBLJIDCN<PKEJDDGKOJK>> MHMHBMFIPGB, IEnumerable<AOAEIBCNJOH> JBDOMHNKPDL, ISet<NICODLFMDAJ<LNBOIECBEGJ>>? GPJDEDABFAD)
	{
		return default(PFGGOEPCHAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x2789EE0", Offset = "0x27890E0", VA = "0x182789EE0")]
	private static IEnumerable<NICODLFMDAJ<JJGKIIIBOJJ>> CJCMNBJGIHA(IEnumerable<AOAEIBCNJOH> JBDOMHNKPDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x278FCD0", Offset = "0x278EED0", VA = "0x18278FCD0")]
	private IEnumerable<NICODLFMDAJ<PKEJDDGKOJK>> OPMCNJBGIBI(IEnumerable<AOAEIBCNJOH> JBDOMHNKPDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x278F810", Offset = "0x278EA10", VA = "0x18278F810", Slot = "65")]
	public List<OBPPOPFLAHJ> OCMKKAMDGKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x278EC00", Offset = "0x278DE00", VA = "0x18278EC00")]
	public (List<OBPPOPFLAHJ>, bool) NDCAHFBICCP([In] EAFJPMDMMKG IDDDOPOIFCA, string OPJOIGJBJKN, [In] ANBCIFAPNOB HODJCEIEDIL, ECNMAGIDFGM OPKDLDCPHGP, OGFADLCEEFJ IOLLHHCJEPK)
	{
		return default((List<OBPPOPFLAHJ>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x278E8B0", Offset = "0x278DAB0", VA = "0x18278E8B0", Slot = "67")]
	public bool MFIEDFDCOJI(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x278F920", Offset = "0x278EB20", VA = "0x18278F920")]
	internal void OEOJBKEHAGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x2789060", Offset = "0x2788260", VA = "0x182789060")]
	internal Task AEDCMFPHNCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x2790620", Offset = "0x278F820", VA = "0x182790620", Slot = "68")]
	public LOAMJJJEMNF<JFIBBLJIDCN<KLMHALNMEAA>?, PLLHOMFPAAM> POHEHKJFGPE(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL, JFIBBLJIDCN<PFJDLPPNNBM> HAPCGDBBODD)
	{
		return default(LOAMJJJEMNF<JFIBBLJIDCN<KLMHALNMEAA>?, PLLHOMFPAAM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x278C920", Offset = "0x278BB20", VA = "0x18278C920", Slot = "69")]
	public LOAMJJJEMNF<JFIBBLJIDCN<PFJDLPPNNBM>?, PLLHOMFPAAM> JIIPJODLCOM(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL, JFIBBLJIDCN<KLMHALNMEAA> DAPOJGPODED)
	{
		return default(LOAMJJJEMNF<JFIBBLJIDCN<PFJDLPPNNBM>?, PLLHOMFPAAM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x2788F70", Offset = "0x2788170", VA = "0x182788F70", Slot = "70")]
	[AsyncStateMachine(typeof(ONMOJLPOFHN))]
	public Task<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> ACIFCAGBJAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x278F980", Offset = "0x278EB80", VA = "0x18278F980", Slot = "71")]
	[AsyncStateMachine(typeof(KJDIIAEIGMI))]
	public Task<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> OFKOGFFLDGM(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL, string DGIAFBEDPNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x278A320", Offset = "0x2789520", VA = "0x18278A320", Slot = "72")]
	public JFIBBLJIDCN<PKEJDDGKOJK>? CMDCDFMEKCL(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x2789AB0", Offset = "0x2788CB0", VA = "0x182789AB0", Slot = "73")]
	public JFIBBLJIDCN<PKEJDDGKOJK>? CDODBHEBOHN(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x278A6D0", Offset = "0x27898D0", VA = "0x18278A6D0", Slot = "74")]
	public int DHBDPEHJAMM(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x278B9D0", Offset = "0x278ABD0", VA = "0x18278B9D0", Slot = "75")]
	public int EOJBCJCMGBJ(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL, JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x278E4C0", Offset = "0x278D6C0", VA = "0x18278E4C0", Slot = "76")]
	public int LMPAACNHNLE(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL, JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG, JFIBBLJIDCN<FLAIMFHIJIM> CGNNJJCOPBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x278C1A0", Offset = "0x278B3A0", VA = "0x18278C1A0", Slot = "77")]
	public int HLOAINCCOEL(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL, JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG, JFIBBLJIDCN<FLAIMFHIJIM> CGNNJJCOPBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x278A800", Offset = "0x2789A00", VA = "0x18278A800", Slot = "78")]
	[AsyncStateMachine(typeof(PPBEKOAJKOO))]
	public Task<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> DLHCMHBHCNG(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL, JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG, JFIBBLJIDCN<FLAIMFHIJIM> CGNNJJCOPBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x27897D0", Offset = "0x27889D0", VA = "0x1827897D0", Slot = "79")]
	[AsyncStateMachine(typeof(HAEDOPJOCII))]
	public Task<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> CCNLBMPHMAF(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL, JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG, JFIBBLJIDCN<FLAIMFHIJIM> CGNNJJCOPBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x278E210", Offset = "0x278D410", VA = "0x18278E210", Slot = "80")]
	public int LGDDNNKCLNC(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL, JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x278BC30", Offset = "0x278AE30", VA = "0x18278BC30", Slot = "81")]
	[AsyncStateMachine(typeof(JPJKFOPKCKH))]
	public Task<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> FOIFIKFHBFM(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL, string MLCDCHNOCFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x278C490", Offset = "0x278B690", VA = "0x18278C490", Slot = "82")]
	[AsyncStateMachine(typeof(EGLFOEKBGEJ))]
	public Task<LOAMJJJEMNF<GKPOGNMPJHG, PLLHOMFPAAM>> INIACIMHEPF(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL, EKEFPBJPEEO KGEICFIBDCA, DMHPCPNFAPH JLBNIDPEHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x278E4B0", Offset = "0x278D6B0", VA = "0x18278E4B0", Slot = "7")]
	private bool LLPMMLHIGCF(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, [In] IJGKPBKEJIE NCBPFCPJMAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x278A2F0", Offset = "0x27894F0", VA = "0x18278A2F0", Slot = "18")]
	private KLOPJCOPMLK FHAJLEJMALP([In] NICODLFMDAJ<JJGKIIIBOJJ> EEKBMGEEJKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x27897C0", Offset = "0x27889C0", VA = "0x1827897C0", Slot = "19")]
	private JFIBBLJIDCN<JJGKIIIBOJJ> BMJMIDLGJMB([In] NICODLFMDAJ<JJGKIIIBOJJ> EEKBMGEEJKM)
	{
		return default(JFIBBLJIDCN<JJGKIIIBOJJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x2789910", Offset = "0x2788B10", VA = "0x182789910", Slot = "20")]
	private JFIBBLJIDCN<JJGKIIIBOJJ>? PEPNAHDNJHO([In] NICODLFMDAJ<JJGKIIIBOJJ> EEKBMGEEJKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x278BF30", Offset = "0x278B130", VA = "0x18278BF30", Slot = "22")]
	private DBLLIICDFED HAKAEPCFMMF([In] NICODLFMDAJ<PKEJDDGKOJK> CANDMCKMDKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x278BEA0", Offset = "0x278B0A0", VA = "0x18278BEA0", Slot = "24")]
	private JFIBBLJIDCN<PKEJDDGKOJK> GLJLNFPAMPL(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, [In] NICODLFMDAJ<PKEJDDGKOJK> MIAKDPHABPI)
	{
		return default(JFIBBLJIDCN<PKEJDDGKOJK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x278DE50", Offset = "0x278D050", VA = "0x18278DE50", Slot = "38")]
	private CAHHBAHBJJE LABGPKHACNK(JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, [In] IJGKPBKEJIE NCBPFCPJMAH)
	{
		return default(CAHHBAHBJJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x2789D60", Offset = "0x2788F60", VA = "0x182789D60", Slot = "51")]
	private LOAMJJJEMNF<DJAFKPAFGEF.HOHEBEEJMKM, GDJCDAEPMMG> KOAHGEKHCBD([In] DJAFKPAFGEF.HCBEBDAGJFJ EFGHMCKPMHN)
	{
		return default(LOAMJJJEMNF<DJAFKPAFGEF.HOHEBEEJMKM, GDJCDAEPMMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x278E080", Offset = "0x278D280", VA = "0x18278E080", Slot = "66")]
	private (List<OBPPOPFLAHJ>, bool) LDCCGIMLFIK([In] EAFJPMDMMKG IDDDOPOIFCA, string OPJOIGJBJKN, [In] ANBCIFAPNOB HODJCEIEDIL, ECNMAGIDFGM OPKDLDCPHGP, OGFADLCEEFJ IOLLHHCJEPK)
	{
		return default((List<OBPPOPFLAHJ>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x278DA30", Offset = "0x278CC30", VA = "0x18278DA30")]
	[CompilerGenerated]
	private MLFLGGNDJOP KGNGPABIKPC(DHECOFGEKEO EOIAPGKFGAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x278BBC0", Offset = "0x278ADC0", VA = "0x18278BBC0")]
	[CompilerGenerated]
	private CNJNPCHEFBN FNJKJAJAEIK(NICODLFMDAJ<PKEJDDGKOJK> EOIAPGKFGAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x278E730", Offset = "0x278D930", VA = "0x18278E730")]
	[CompilerGenerated]
	private ICPAFHENLAO LONJEJKHJKG(NICODLFMDAJ<JJGKIIIBOJJ> EOIAPGKFGAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x278C2B0", Offset = "0x278B4B0", VA = "0x18278C2B0")]
	[CompilerGenerated]
	private CNJNPCHEFBN IDGKPGKCJNL(NICODLFMDAJ<PKEJDDGKOJK> EOIAPGKFGAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x278BD70", Offset = "0x278AF70", VA = "0x18278BD70")]
	[CompilerGenerated]
	private ICPAFHENLAO GFCPFAKBLAF(NICODLFMDAJ<JJGKIIIBOJJ> EOIAPGKFGAB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class MLFLGGNDJOP : HLEKIDHKADJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private struct LALDLFEAJFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<JFIBBLJIDCN<FLAIMFHIJIM>, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public MLFLGGNDJOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public NICODLFMDAJ<JJGKIIIBOJJ> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public NICODLFMDAJ<PKEJDDGKOJK> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public JFIBBLJIDCN<IMLHFCPAHJM> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private TaskAwaiter<LOAMJJJEMNF<JFIBBLJIDCN<FLAIMFHIJIM>, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x27AE7A0", Offset = "0x27AD9A0", VA = "0x1827AE7A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x27AEA20", Offset = "0x27ADC20", VA = "0x1827AEA20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct EEAOKPGEHKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<JFIBBLJIDCN<HOEALKNOPIA>, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public MLFLGGNDJOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public NICODLFMDAJ<JJGKIIIBOJJ> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public NICODLFMDAJ<PKEJDDGKOJK> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public JFIBBLJIDCN<IMLHFCPAHJM> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private TaskAwaiter<LOAMJJJEMNF<JFIBBLJIDCN<HOEALKNOPIA>, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x27A9800", Offset = "0x27A8A00", VA = "0x1827A9800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x27A9A80", Offset = "0x27A8C80", VA = "0x1827A9A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000340")]
	private readonly DHECOFGEKEO EFBNAGPFFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	private readonly PACLEKAFKMK DMFDBIKEBDE;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public TypeKey FEFCBJEGDID
	{
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0xBFD840", Offset = "0xBFCA40", VA = "0x180BFD840", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public string MBPDODINOJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x27A7050", Offset = "0x27A6250", VA = "0x1827A7050", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public DHECOFGEKEO JEJHCPNOGDD
	{
		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x27AF680", Offset = "0x27AE880", VA = "0x1827AF680")]
	public MLFLGGNDJOP(DHECOFGEKEO OFGGLIGGIEF, PACLEKAFKMK GNCHNFLHMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x27AF510", Offset = "0x27AE710", VA = "0x1827AF510", Slot = "6")]
	[AsyncStateMachine(typeof(LALDLFEAJFK))]
	public Task<LOAMJJJEMNF<JFIBBLJIDCN<FLAIMFHIJIM>, PLLHOMFPAAM>> DLGAIHDCHDJ(NICODLFMDAJ<JJGKIIIBOJJ> EEKBMGEEJKM, NICODLFMDAJ<PKEJDDGKOJK> CANDMCKMDKL, JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG, string DGIAFBEDPNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x27AF3A0", Offset = "0x27AE5A0", VA = "0x1827AF3A0", Slot = "7")]
	[AsyncStateMachine(typeof(EEAOKPGEHKG))]
	public Task<LOAMJJJEMNF<JFIBBLJIDCN<HOEALKNOPIA>, PLLHOMFPAAM>> AKGIIBBEMHO(NICODLFMDAJ<JJGKIIIBOJJ> EEKBMGEEJKM, NICODLFMDAJ<PKEJDDGKOJK> CANDMCKMDKL, JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG, string DGIAFBEDPNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class DCKIFBHEHBA : PHMDDFIHFNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private readonly DHECOFGEKEO OMLFBAHOPMM;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private static readonly HashSet<DHECOFGEKEO> PLLKFPJELPF;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	private static readonly HashSet<DHECOFGEKEO> DNCMOLCOFBN;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private static readonly HashSet<DHECOFGEKEO> HJKPKAFNFDE;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public TypeKey AFPMCDIFDOM
	{
		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x27A8550", Offset = "0x27A7750", VA = "0x1827A8550", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool JLOJNNAIMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x27A8540", Offset = "0x27A7740", VA = "0x1827A8540", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool JJLJEAEFMBK
	{
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x27A85A0", Offset = "0x27A77A0", VA = "0x1827A85A0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public bool MCCOCECAMHG
	{
		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x27A84C0", Offset = "0x27A76C0", VA = "0x1827A84C0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x27A6DE0", Offset = "0x27A5FE0", VA = "0x1827A6DE0")]
	public bool ONGMIMEBEHB(string MLCDCHNOCFI, [Out] PPJCEHAAGCH GDHFBHNHFKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
	public DCKIFBHEHBA(DHECOFGEKEO AHLPFPPNCPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x27A6C50", Offset = "0x27A5E50", VA = "0x1827A6C50")]
	internal static TypeKey OKABFHICFAM(DHECOFGEKEO EDLOHJEBKFM)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x27A7050", Offset = "0x27A6250", VA = "0x1827A7050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public readonly struct FKHCBGBLFBC : AMPKJOMLEIF.CDIHPBHLCKH<AGKENLKLGLL, GKPOGNMPJHG>
{
	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x27AC5E0", Offset = "0x27AB7E0", VA = "0x1827AC5E0", Slot = "4")]
	public int JKGIJJGDLEP(GKPOGNMPJHG NIDPEFPJBOO, AGKENLKLGLL HDKINMMJOHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0x27AC690", Offset = "0x27AB890", VA = "0x1827AC690", Slot = "5")]
	public AGKENLKLGLL MCINDOLEKLH(GKPOGNMPJHG NIDPEFPJBOO, AGKENLKLGLL HDKINMMJOHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(RVA = "0x27AC5B0", Offset = "0x27AB7B0", VA = "0x1827AC5B0", Slot = "6")]
	public AGKENLKLGLL FGPAMGJNIJN(GKPOGNMPJHG NIDPEFPJBOO, AGKENLKLGLL HDKINMMJOHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x27AC6A0", Offset = "0x27AB8A0", VA = "0x1827AC6A0", Slot = "7")]
	public IReadOnlyList<AGKENLKLGLL> NFMFENBPPBF(GKPOGNMPJHG NIDPEFPJBOO, AGKENLKLGLL HDKINMMJOHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x27AC680", Offset = "0x27AB880", VA = "0x1827AC680", Slot = "8")]
	public AGKENLKLGLL[] LOMOMDPJAMH(GKPOGNMPJHG NIDPEFPJBOO, AGKENLKLGLL HDKINMMJOHF, int BJCGAPGLCHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x27AC570", Offset = "0x27AB770", VA = "0x1827AC570", Slot = "9")]
	public bool BEGLGOPEHIP(GKPOGNMPJHG NIDPEFPJBOO, AGKENLKLGLL HDKINMMJOHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x27AC660", Offset = "0x27AB860", VA = "0x1827AC660", Slot = "10")]
	public bool LJPPCBOGMFI(GKPOGNMPJHG NIDPEFPJBOO, AGKENLKLGLL HDKINMMJOHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x27AC600", Offset = "0x27AB800", VA = "0x1827AC600", Slot = "11")]
	public bool JLKFEPMKOPJ(GKPOGNMPJHG NIDPEFPJBOO, AGKENLKLGLL HDKINMMJOHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x27AC640", Offset = "0x27AB840", VA = "0x1827AC640", Slot = "12")]
	public bool KFENKEJCDKI(GKPOGNMPJHG NIDPEFPJBOO, AGKENLKLGLL HDKINMMJOHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x27AC620", Offset = "0x27AB820", VA = "0x1827AC620", Slot = "13")]
	public bool JPHFHHCBECI(GKPOGNMPJHG MKDJNMDODDK, AGKENLKLGLL HDKINMMJOHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x27AC590", Offset = "0x27AB790", VA = "0x1827AC590", Slot = "14")]
	public bool DJDOFKOCLCL(GKPOGNMPJHG NIDPEFPJBOO, AGKENLKLGLL HDKINMMJOHF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public abstract class DGJKDFLCFFL : IAACJJOGHIC
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public BPNIFDODBBN.AJKKABFCNJF LGHEPIFBAAN
	{
		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x27A9760", Offset = "0x27A8960", VA = "0x1827A9760", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public abstract HOFOMPIHPAL.FLHBAFDPOGO EIFIHAMJPKA
	{
		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public abstract BMLBDHHGCHG.KBJJDACHKGK FHCJFNBMJAM
	{
		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public abstract KAMDFIOBPJP.BEPILBLDDEM MLINHMHPLBH
	{
		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public BFFLPJPCMEL.LIIAMKACFFM<CJEEPIILMHM, AGKENLKLGLL, BMLBDHHGCHG> OLAHPJMDOFF
	{
		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x27A97B0", Offset = "0x27A89B0", VA = "0x1827A97B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public abstract CJDMGLKDALO.DNLPOCEMLNC AJGNMINGMGM
	{
		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public abstract LAMDCDECGNG HNDGHLFBEFP
	{
		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public abstract JINBEMABBNE AIJKJOCPIBI
	{
		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public abstract NBFCEHFCGPE KIEEMLABNBC
	{
		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public abstract JDPILMMJHIO CPCPNHEGAFD
	{
		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public abstract HCFBIPPLEMC ELHEOMJCNGE
	{
		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	protected DGJKDFLCFFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class AMLPPFBIMBM : LINPPJJJPOB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct FBFJJHAPPNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<object, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public AMLPPFBIMBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public AGKENLKLGLL action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private TaskAwaiter<LOAMJJJEMNF<object, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x27AA260", Offset = "0x27A9460", VA = "0x1827AA260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x27AA500", Offset = "0x27A9700", VA = "0x1827AA500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private struct LMJGDDGNPOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<MKMBMMHDKHK, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public AMLPPFBIMBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public IReadOnlyList<AGKENLKLGLL> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		private TaskAwaiter<LOAMJJJEMNF<object, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x27AEDC0", Offset = "0x27ADFC0", VA = "0x1827AEDC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x27AF140", Offset = "0x27AE340", VA = "0x1827AF140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	private readonly FILIDBMOPNM HOJIPLNENIE;

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
	public AMLPPFBIMBM(FILIDBMOPNM LJPGHHICBDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x27A5C80", Offset = "0x27A4E80", VA = "0x1827A5C80")]
	[AsyncStateMachine(typeof(FBFJJHAPPNM))]
	private Task<LOAMJJJEMNF<object, PLLHOMFPAAM>> JICLHBDIDDN(AGKENLKLGLL HDKINMMJOHF, bool LKDKFJKIIAP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x27A5B50", Offset = "0x27A4D50", VA = "0x1827A5B50", Slot = "4")]
	[AsyncStateMachine(typeof(LMJGDDGNPOL))]
	public Task<LOAMJJJEMNF<MKMBMMHDKHK, PLLHOMFPAAM>> HNGFNFFBJJO(IReadOnlyList<AGKENLKLGLL> EPMMAHCPFOI, bool LKDKFJKIIAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public struct LALBPBGHDCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000364")]
	internal ADBDBPDGGAO<MLFAKCKOFLP, NICODLFMDAJ<MLFAKCKOFLP.EKLOAHCJDCD>, AGKENLKLGLL, MJKMNLDNAAC> OMLFBAHOPMM;

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x2774DF0", Offset = "0x2773FF0", VA = "0x182774DF0")]
	private LALBPBGHDCK([In] ADBDBPDGGAO<MLFAKCKOFLP, NICODLFMDAJ<MLFAKCKOFLP.EKLOAHCJDCD>, AGKENLKLGLL, MJKMNLDNAAC> NFLOPBNGLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x27AE740", Offset = "0x27AD940", VA = "0x1827AE740")]
	public static LALBPBGHDCK OIKMHICCLEP()
	{
		return default(LALBPBGHDCK);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public static class FOOBJGPGBFP
{
	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0xC84900", Offset = "0xC83B00", VA = "0x180C84900")]
	public static ADBDBPDGGAO<MLFAKCKOFLP, NICODLFMDAJ<MLFAKCKOFLP.EKLOAHCJDCD>, AGKENLKLGLL, MJKMNLDNAAC> OKKBNIAFNKO(this LALBPBGHDCK CEENCLMGJAM)
	{
		return default(ADBDBPDGGAO<MLFAKCKOFLP, NICODLFMDAJ<MLFAKCKOFLP.EKLOAHCJDCD>, AGKENLKLGLL, MJKMNLDNAAC>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public struct MJKMNLDNAAC : EGDACDPHPND.FFBAPIAAFNG<MLFAKCKOFLP, NICODLFMDAJ<MLFAKCKOFLP.EKLOAHCJDCD>, AGKENLKLGLL>
{
	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x27AF1B0", Offset = "0x27AE3B0", VA = "0x1827AF1B0", Slot = "7")]
	public AGKENLKLGLL CPCHNAGAJFD(MLFAKCKOFLP[] GAKNKDKLDHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0x10D7840", Offset = "0x10D6A40", VA = "0x1810D7840")]
	public NICODLFMDAJ<MLFAKCKOFLP.EKLOAHCJDCD> MBCKPJKENEH([In] MLFAKCKOFLP JAPMIPHFGGE)
	{
		return default(NICODLFMDAJ<MLFAKCKOFLP.EKLOAHCJDCD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x10F7880", Offset = "0x10F6A80", VA = "0x1810F7880")]
	public int NCIHBEEIPKI([In] MLFAKCKOFLP KFFAIFBIBNO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0x27AF390", Offset = "0x27AE590", VA = "0x1827AF390")]
	public int MDLCHLAGGPJ([In] MLFAKCKOFLP JAPMIPHFGGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x10F7880", Offset = "0x10F6A80", VA = "0x1810F7880", Slot = "4")]
	private int DIHEPLLMJBF([In] MLFAKCKOFLP JAPMIPHFGGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(RVA = "0x27AF390", Offset = "0x27AE590", VA = "0x1827AF390", Slot = "5")]
	private int HPPGPMMBCBI([In] MLFAKCKOFLP JAPMIPHFGGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(RVA = "0x10D7840", Offset = "0x10D6A40", VA = "0x1810D7840", Slot = "6")]
	private NICODLFMDAJ<MLFAKCKOFLP.EKLOAHCJDCD> JNJAJOBMMNA([In] MLFAKCKOFLP JAPMIPHFGGE)
	{
		return default(NICODLFMDAJ<MLFAKCKOFLP.EKLOAHCJDCD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public struct NOJIJMINLNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	internal IKBOIGGOEHK<EGHBLGJNGKE, AGKENLKLGLL, DAGEDKENDJO> OMLFBAHOPMM;

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x2774DF0", Offset = "0x2773FF0", VA = "0x182774DF0")]
	private NOJIJMINLNJ([In] IKBOIGGOEHK<EGHBLGJNGKE, AGKENLKLGLL, DAGEDKENDJO> JEHGBNHFDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x27AF720", Offset = "0x27AE920", VA = "0x1827AF720")]
	public static NOJIJMINLNJ OIKMHICCLEP()
	{
		return default(NOJIJMINLNJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public static class NEICEKENNCA
{
	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0xC84900", Offset = "0xC83B00", VA = "0x180C84900")]
	public static IKBOIGGOEHK<EGHBLGJNGKE, AGKENLKLGLL, DAGEDKENDJO> OKKBNIAFNKO(this NOJIJMINLNJ CEENCLMGJAM)
	{
		return default(IKBOIGGOEHK<EGHBLGJNGKE, AGKENLKLGLL, DAGEDKENDJO>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public struct DAGEDKENDJO : DNPENKDAEAN.NPLFIDNFGDA<EGHBLGJNGKE, AGKENLKLGLL>
{
	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x21927C0", Offset = "0x21919C0", VA = "0x1821927C0")]
	public int DGCELPJNIFJ([In] EGHBLGJNGKE KFFAIFBIBNO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x27A6A70", Offset = "0x27A5C70", VA = "0x1827A6A70", Slot = "5")]
	public AGKENLKLGLL BDFJAOPBPMG(EGHBLGJNGKE[] JOALGJPIDHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x21927C0", Offset = "0x21919C0", VA = "0x1821927C0", Slot = "4")]
	private int INBMOPNFHKM([In] EGHBLGJNGKE KFFAIFBIBNO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public class FJNOBDECLGP : DKPIACPJNCE, GDJCDAEPMMG, PLLHOMFPAAM, GEFBDEPLDON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400036B")]
	private readonly GEFBDEPLDON? OCEMBFKBJCD;

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public MOKDNNJJAFN PMDIHHMBMHP
	{
		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x9F94F0", Offset = "0x9F86F0", VA = "0x1809F94F0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(MOKDNNJJAFN);
		}
		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3B0", Offset = "0x9FA5B0", VA = "0x1809FB3B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public override GEFBDEPLDON? FCLBMILNNDA
	{
		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x27AC3A0", Offset = "0x27AB5A0", VA = "0x1827AC3A0", Slot = "7")]
	public override string JOOGKGIFDEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x27AC530", Offset = "0x27AB730", VA = "0x1827AC530")]
	private FJNOBDECLGP(MOKDNNJJAFN HFFFCKALIAN, GEFBDEPLDON? BHINMCEADCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x27AC4B0", Offset = "0x27AB6B0", VA = "0x1827AC4B0")]
	public static FJNOBDECLGP KHPJCMAJCDJ(GEFBDEPLDON BHINMCEADCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x27AC330", Offset = "0x27AB530", VA = "0x1827AC330")]
	public static FJNOBDECLGP DGCFPDFMGFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x27AC2C0", Offset = "0x27AB4C0", VA = "0x1827AC2C0")]
	public static FJNOBDECLGP CINBDIKBJPO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public static class MJEPBCDCNPM
{
	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(RVA = "0x38F6210", Offset = "0x38F5410", VA = "0x1838F6210")]
	public static LOAMJJJEMNF<TOk, GDJCDAEPMMG> AMGEFNPLDJB<TOk>([In] this LOAMJJJEMNF<TOk, GDJCDAEPMMG> CEENCLMGJAM, GEFBDEPLDON BHINMCEADCF) where TOk : notnull
	{
		return default(LOAMJJJEMNF<TOk, GDJCDAEPMMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x38F6300", Offset = "0x38F5500", VA = "0x1838F6300")]
	public static LOAMJJJEMNF<TOk?, GDJCDAEPMMG?> GELAENJEBPE<TOk>([In] this LOAMJJJEMNF<TOk, GDJCDAEPMMG> CEENCLMGJAM)
	{
		return default(LOAMJJJEMNF<TOk, GDJCDAEPMMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x38F6110", Offset = "0x38F5310", VA = "0x1838F6110")]
	public static LOAMJJJEMNF<TOk?, GDJCDAEPMMG?> AFHPCDBLBNP<TOk>([In] this LOAMJJJEMNF<TOk, GDJCDAEPMMG> CEENCLMGJAM)
	{
		return default(LOAMJJJEMNF<TOk, GDJCDAEPMMG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public interface LAMDCDECGNG
{
	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DEAHEGPHJPK([In] LOAMJJJEMNF<GKPOGNMPJHG, GEFBDEPLDON> IGGKBIDIAJL);
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public static class BHLHOPDLPNB
{
	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x35B5720", Offset = "0x35B4920", VA = "0x1835B5720")]
	public static bool DEAHEGPHJPK<TOk, TErr>(this LAMDCDECGNG CEENCLMGJAM, [In] LOAMJJJEMNF<TOk, TErr> IGGKBIDIAJL) where TOk : notnull where TErr : notnull, GEFBDEPLDON
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public interface JINBEMABBNE
{
	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	BECHCCGPBGG GDBJNEDMCIM
	{
		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public interface NBFCEHFCGPE
{
	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CPMGKMACEBI KGPEEJPCMDF(int FJMFFNHCKNB);
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public interface DKACOCDEJGK
{
	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	string BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public interface KBCBHCGMLMA
{
	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEMHPMHDNDM? FOAGAFJNNOC(JFIBBLJIDCN<IMLHFCPAHJM> HCLOIOOJPJG);
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public interface HMAONEMAMDN
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	string BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public interface IEMHPMHDNDM
{
	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	string BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HMAONEMAMDN? AEJBCPNJFAO(JFIBBLJIDCN<FLAIMFHIJIM> CGNNJJCOPBO);

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DKACOCDEJGK? LPILLFKKDOJ(JFIBBLJIDCN<HOEALKNOPIA> DMLNAJIHPDP);
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public interface JDPILMMJHIO
{
	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> FEGMINJPHHI(string MLCDCHNOCFI, string OPJOIGJBJKN);
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public interface HCFBIPPLEMC
{
	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KBCBHCGMLMA? LAKGNEGBNFD([In] NICODLFMDAJ<KHLCKNCKDPA> EPKMJEDGIDD);
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class DEEPEACNDFG
{
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	private struct HHDOMNGIMOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public int PMLOAHGMFBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public HBBBCDHABCG? BBNINIIMAML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public HBBBCDHABCG? LAMLOOEHLKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public readonly List<AGKENLKLGLL> HLPDLDEIALC;

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x27ACC60", Offset = "0x27ABE60", VA = "0x1827ACC60")]
		private HHDOMNGIMOP(int NIBICIJAIGM, HBBBCDHABCG? AANJGPAHCLJ, HBBBCDHABCG? KCGNFFINPKJ, List<AGKENLKLGLL> EPMMAHCPFOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x27ACBA0", Offset = "0x27ABDA0", VA = "0x1827ACBA0")]
		public static HHDOMNGIMOP OIKMHICCLEP()
		{
			return default(HHDOMNGIMOP);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400036E")]
	private readonly PLAHILCPIKM<HHDOMNGIMOP> PHGAOPJLNIK;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public static DEEPEACNDFG NDDGJHHDBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x27A8F30", Offset = "0x27A8130", VA = "0x1827A8F30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public bool CNCBOOCFKME
	{
		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0xC8C5E0", Offset = "0xC8B7E0", VA = "0x180C8C5E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0xC8C5D0", Offset = "0xC8B7D0", VA = "0x180C8C5D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x27A8E70", Offset = "0x27A8070", VA = "0x1827A8E70")]
	public void EPLKJGPCEBL(KFOPAHDCEKH KCGNFFINPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x27A92C0", Offset = "0x27A84C0", VA = "0x1827A92C0")]
	public void ONJCNDKLGIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x27A8F80", Offset = "0x27A8180", VA = "0x1827A8F80")]
	private static string? GEGEOMNMDMB([In] HHDOMNGIMOP NJGHNNFJCLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x27A96B0", Offset = "0x27A88B0", VA = "0x1827A96B0")]
	public DEEPEACNDFG()
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
