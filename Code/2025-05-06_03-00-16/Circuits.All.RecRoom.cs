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
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x271E670", Offset = "0x271CE70", VA = "0x18271E670")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA09330", Offset = "0xA07B30", VA = "0x180A09330")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA09370", Offset = "0xA07B70", VA = "0x180A09370")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class CBFIFLFMBFP : IDisposable, DCFLPFKBDBJ, CDCELBCHEGD, IJOMDCJCCMI, OMEKMCPOMAM
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class JOJGGEDKOJB : IFABMAAINID
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int PIECPACNPNK
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x271B100", Offset = "0x2719900", VA = "0x18271B100", Slot = "5")]
		public FPOFNHLILIO KMFFFNEIIBA(NACBMONFLFA.JADAMBFFCPB ILEBEOADOPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void ANCFALIIPAJ();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void EIMAHMCCMGB();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x26F8CA0", Offset = "0x26F74A0", VA = "0x1826F8CA0", Slot = "13")]
		public virtual void AOHFDNDMPLM(CBFIFLFMBFP MPABKJPPPMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x271B080", Offset = "0x2719880", VA = "0x18271B080", Slot = "14")]
		public virtual void CLHOBFLKMMJ(CBFIFLFMBFP MPABKJPPPMM, IOPMFGMDJPO GFMBHCHPLDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		protected JOJGGEDKOJB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface IFABMAAINID
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int PIECPACNPNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "1")]
		FPOFNHLILIO KMFFFNEIIBA(NACBMONFLFA.JADAMBFFCPB ILEBEOADOPL);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ANCFALIIPAJ();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void EIMAHMCCMGB();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void AOHFDNDMPLM(CBFIFLFMBFP MPABKJPPPMM);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void CLHOBFLKMMJ(CBFIFLFMBFP MPABKJPPPMM, IOPMFGMDJPO GFMBHCHPLDH);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct IKADFAAPLEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly FMMNACDHFCL<GAACMGKKDOM, IOPMFGMDJPO, CBFIFLFMBFP, APKEIIBCNIN.OAGAKJIEFFI<GAACMGKKDOM, IOPMFGMDJPO, CBFIFLFMBFP>> PEBAEBIABCE;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2718C30", Offset = "0x2717430", VA = "0x182718C30")]
		internal IKADFAAPLEM(FMMNACDHFCL<GAACMGKKDOM, IOPMFGMDJPO, CBFIFLFMBFP, APKEIIBCNIN.OAGAKJIEFFI<GAACMGKKDOM, IOPMFGMDJPO, CBFIFLFMBFP>> JLPKBNIJDEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class DNJLFEFPLIO : APKEIIBCNIN.OAGAKJIEFFI<GAACMGKKDOM, IOPMFGMDJPO, CBFIFLFMBFP>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly DNJLFEFPLIO DJLOIKDDKCN;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		private DNJLFEFPLIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xAA01F0", Offset = "0xA9E9F0", VA = "0x180AA01F0", Slot = "4")]
		public GAACMGKKDOM IHNOCKBGIME(IOPMFGMDJPO NFOGFJOGLPE)
		{
			return default(GAACMGKKDOM);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2714570", Offset = "0x2712D70", VA = "0x182714570", Slot = "5")]
		public void AOHFDNDMPLM(CBFIFLFMBFP PNDCHGJLEGG, IOPMFGMDJPO GFMBHCHPLDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2714670", Offset = "0x2712E70", VA = "0x182714670", Slot = "6")]
		public void CLHOBFLKMMJ(CBFIFLFMBFP PNDCHGJLEGG, IOPMFGMDJPO GFMBHCHPLDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct BAAMNFGCIBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public LAEAOCNGGLP<GAACMGKKDOM, IOPMFGMDJPO, CBFIFLFMBFP, APKEIIBCNIN.OAGAKJIEFFI<GAACMGKKDOM, IOPMFGMDJPO, CBFIFLFMBFP>> PEBAEBIABCE;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x270DC30", Offset = "0x270C430", VA = "0x18270DC30")]
		internal BAAMNFGCIBC(LAEAOCNGGLP<GAACMGKKDOM, IOPMFGMDJPO, CBFIFLFMBFP, APKEIIBCNIN.OAGAKJIEFFI<GAACMGKKDOM, IOPMFGMDJPO, CBFIFLFMBFP>> JLPKBNIJDEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x270DBE0", Offset = "0x270C3E0", VA = "0x18270DBE0")]
		public static BAAMNFGCIBC CJOJELENPLJ()
		{
			return default(BAAMNFGCIBC);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct MCBPMHBBLPB : FJEFMNCBJDG.LOIHMJCCLFN<IOPMFGMDJPO, CBFIFLFMBFP>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct NKLFCPJPJHD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<HCGBMJDNFKJ<object?, CPMHOEMAGED>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public CBFIFLFMBFP receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public IOPMFGMDJPO action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public MCBPMHBBLPB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<HCGBMJDNFKJ<object?, CPMHOEMAGED>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x271E420", Offset = "0x271CC20", VA = "0x18271E420", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x271E600", Offset = "0x271CE00", VA = "0x18271E600", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA7BE60", Offset = "0xA7A660", VA = "0x180A7BE60", Slot = "4")]
		public NLPIAAOFKEO<PIEODFHFNCJ> NPGHKFLEGEA(CBFIFLFMBFP KEEAPFDDBLD)
		{
			return default(NLPIAAOFKEO<PIEODFHFNCJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x271CE10", Offset = "0x271B610", VA = "0x18271CE10", Slot = "5")]
		public void HEADNKOLFDG(CBFIFLFMBFP KEEAPFDDBLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x271CE70", Offset = "0x271B670", VA = "0x18271CE70", Slot = "6")]
		[AsyncStateMachine(typeof(NKLFCPJPJHD))]
		public Task<HCGBMJDNFKJ<object, CPMHOEMAGED>> JBDLGEIFEGE(CBFIFLFMBFP KEEAPFDDBLD, IOPMFGMDJPO GFMBHCHPLDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x271CDF0", Offset = "0x271B5F0", VA = "0x18271CDF0", Slot = "7")]
		public IOPMFGMDJPO[] CKOOBEGMAMP(CBFIFLFMBFP KEEAPFDDBLD)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct OMOANGBOAFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<bool, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CBFIFLFMBFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<HCGBMJDNFKJ<bool, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x271E940", Offset = "0x271D140", VA = "0x18271E940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x271EBD0", Offset = "0x271D3D0", VA = "0x18271EBD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct OJPIDEOCCNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public CBFIFLFMBFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x271E6F0", Offset = "0x271CEF0", VA = "0x18271E6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x271E8D0", Offset = "0x271D0D0", VA = "0x18271E8D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct PPAOCIPNPLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<object?, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public CBFIFLFMBFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public IOPMFGMDJPO action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<HCGBMJDNFKJ<object?, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x271FEE0", Offset = "0x271E6E0", VA = "0x18271FEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x27200D0", Offset = "0x271E8D0", VA = "0x1827200D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly NLPIAAOFKEO<PIEODFHFNCJ> HPJGLIIOMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly IKADFAAPLEM AKGGHFKLPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly NNJEIMLLEGD CBANEAHNGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly PBBMMPAPLLJ PBPEBNEKFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B70")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly PNCMBCNMLMI BMLJCKKJMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B78")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly KKGMNBFIOAK.GEPOFFKIOOC IHNBEILKCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BA0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly FHBPOHFIPHM PCMONIOJHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BA8")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly JEKNKGEOKNH NCDFDMFLLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BB0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly MKHEPIGPCEP AKCKJEGGBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BB8")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly HEPLNLFDILK CBGDFKNFHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BC0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private DEBCKJBOCMG DADGEBLGFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BD0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private CNCAMPCMOHP EFDGJFLJDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BF0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly NNJEIMLLEGD.CLDFBIGFKLN KBJCFHHMKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BF8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly EIILBEGKKNL EBCONBLGKMG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NNJEIMLLEGD DOMDGLJAJMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x270F0A0", Offset = "0x270D8A0", VA = "0x18270F0A0")]
		get
		{
			return default(NNJEIMLLEGD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal IFABMAAINID MACNJANDNKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x270E9F0", Offset = "0x270D1F0", VA = "0x18270E9F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal FPOFNHLILIO LOEKGKDPOAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x270EB90", Offset = "0x270D390", VA = "0x18270EB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x270EF40", Offset = "0x270D740", VA = "0x18270EF40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool PHIBMLBJJJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x270F090", Offset = "0x270D890", VA = "0x18270F090")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x270EA40", Offset = "0x270D240", VA = "0x18270EA40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public GIOPBMKLFFP CLAHMMELIFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x270F3B0", Offset = "0x270DBB0", VA = "0x18270F3B0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public EGNLCNDIMEE MIHHKKAFLLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x270F3C0", Offset = "0x270DBC0", VA = "0x18270F3C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public NKMHAEJCNNL KDDOMMHDHOO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x270F3E0", Offset = "0x270DBE0", VA = "0x18270F3E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public DOPHMIAHEOA LKOJOKFJBHH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x270F3D0", Offset = "0x270DBD0", VA = "0x18270F3D0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public KKGMNBFIOAK? LIOODFBMCMP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x270EEC0", Offset = "0x270D6C0", VA = "0x18270EEC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private DKODMLGEKLD? LLGPAMOKCEC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x270EF60", Offset = "0x270D760", VA = "0x18270EF60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x270F0B0", Offset = "0x270D8B0", VA = "0x18270F0B0")]
	private CBFIFLFMBFP(PNCMBCNMLMI MHBIGPFAJHC, NLPIAAOFKEO<PIEODFHFNCJ> EIOPAHLHHKC, [In] IKADFAAPLEM HENMJEKPFLL, [In] NNJEIMLLEGD OPHLALHOGOE, [In] PBBMMPAPLLJ CJNIEDKEMPL, FPOFNHLILIO CABJNEPNBOC, [In] KKGMNBFIOAK.GEPOFFKIOOC JIOIHNKJEAE, NNJEIMLLEGD.CLDFBIGFKLN MIIKHMDANFK, EIILBEGKKNL MJHJCDGKBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x270DE20", Offset = "0x270C620", VA = "0x18270DE20")]
	public static CBFIFLFMBFP CJOJELENPLJ(PNCMBCNMLMI ILEBEOADOPL, [In] HDBCFKNBKKI INFEHFCNNNL, INGCADINADG KFMPMDECFDO, [In] KACBLIMCNID JEFCBGLMJAP, PNEJKBFADMK BBKJEJBICML, NLPIAAOFKEO<PIEODFHFNCJ> EIOPAHLHHKC, NLPIAAOFKEO<OCDGAOGMPPP> FCBKLKOBEBI, PPIFDECMEOD JKJNCGNOMJI, CCEBHFPCBEC LEJMPNAIFHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x270DF60", Offset = "0x270C760", VA = "0x18270DF60")]
	public static CBFIFLFMBFP CJOJELENPLJ(PNCMBCNMLMI MHBIGPFAJHC, [In] NNJEIMLLEGD OPHLALHOGOE, [In] PBBMMPAPLLJ CJNIEDKEMPL, NLPIAAOFKEO<PIEODFHFNCJ> EIOPAHLHHKC, NLPIAAOFKEO<OCDGAOGMPPP> FCBKLKOBEBI, PPIFDECMEOD JKJNCGNOMJI, CCEBHFPCBEC LEJMPNAIFHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x270E790", Offset = "0x270CF90", VA = "0x18270E790", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x270EA50", Offset = "0x270D250", VA = "0x18270EA50")]
	[AsyncStateMachine(typeof(OMOANGBOAFP))]
	public Task<HCGBMJDNFKJ<bool, CPMHOEMAGED>> GDHABGNOMBH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x270DD30", Offset = "0x270C530", VA = "0x18270DD30")]
	[AsyncStateMachine(typeof(OJPIDEOCCNH))]
	public Task<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> BLBJHDLKMCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x270ECB0", Offset = "0x270D4B0", VA = "0x18270ECB0")]
	internal void JGNMAAAAEBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x270DCB0", Offset = "0x270C4B0", VA = "0x18270DCB0")]
	internal PPKNIFNDLFA<IOPMFGMDJPO> BCCPHFLHIKF([In] JGJPBPJENAK CFCGJBNIPCG)
	{
		return default(PPKNIFNDLFA<IOPMFGMDJPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x270E980", Offset = "0x270D180", VA = "0x18270E980")]
	internal bool ENBMLFLNNPP([In] JGJPBPJENAK CFCGJBNIPCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x270E600", Offset = "0x270CE00", VA = "0x18270E600")]
	internal HCGBMJDNFKJ<IOPMFGMDJPO, CPMHOEMAGED> DCNFIIGKFIL([In] FLOGJLOBLDA HKKOOHJLMMD)
	{
		return default(HCGBMJDNFKJ<IOPMFGMDJPO, CPMHOEMAGED>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x270EB40", Offset = "0x270D340", VA = "0x18270EB40")]
	private void HEADNKOLFDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x270EBA0", Offset = "0x270D3A0", VA = "0x18270EBA0")]
	[AsyncStateMachine(typeof(PPAOCIPNPLE))]
	internal Task<HCGBMJDNFKJ<object, CPMHOEMAGED>> JEKGNGGDDCP(IOPMFGMDJPO GFMBHCHPLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x270E270", Offset = "0x270CA70", VA = "0x18270E270")]
	private IOPMFGMDJPO[] CKOOBEGMAMP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class DNFGEGCKCCL<TData> : PLLAIPNOLPG, JCOFLCFPMPM, IGEMMGEDLOA where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly CMDPIJDKPHC<KGLBPIDLJAB>? KLODCDJAFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly string LOFKFCJKLII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly TData BADLMALNNLF;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public CMDPIJDKPHC<KGLBPIDLJAB>? OELBEEGMAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2984D60", Offset = "0x2983560", VA = "0x182984D60", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x9E2460", Offset = "0x9E0C60", VA = "0x1809E2460", Slot = "7")]
	public override string KCDPOCMBOHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x68E5440", Offset = "0x68E3C40", VA = "0x1868E5440")]
	internal DNFGEGCKCCL([In] CMDPIJDKPHC<KGLBPIDLJAB>? GIHIDAJDIAB, NLPIAAOFKEO<GGAOHKIBKBD>? EJLEBONCNNH, IOKind? GDLAKCHPMBD, string NJAAPDELBNN, [In] TData NFNBKNAJBPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class IAAAPOANBAC
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2718320", Offset = "0x2716B20", VA = "0x182718320")]
	public static HCGBMJDNFKJ<GKMEGDNGDLG, JCOFLCFPMPM> PHABEECFPJK([In] this GGBJBGABBJA<IFPJDPMCCHP> IKNMAKOJPAB)
	{
		return default(HCGBMJDNFKJ<GKMEGDNGDLG, JCOFLCFPMPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x37CDCA0", Offset = "0x37CC4A0", VA = "0x1837CDCA0")]
	public static HCGBMJDNFKJ<TOk, JCOFLCFPMPM> NJNLDKBJCAC<TOk>([In] this HCGBMJDNFKJ<TOk, JCOFLCFPMPM> NFOGFJOGLPE, [In] CMDPIJDKPHC<KGLBPIDLJAB>? GIHIDAJDIAB, NLPIAAOFKEO<GGAOHKIBKBD>? EJLEBONCNNH, IOKind? GDLAKCHPMBD, string NJAAPDELBNN) where TOk : notnull
	{
		return default(HCGBMJDNFKJ<TOk, JCOFLCFPMPM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PNCMBCNMLMI
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	PPIONKMKDEM.BJABODJBOAI LGPOAPJOMEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	NACBMONFLFA.JADAMBFFCPB BHGMKFAGAGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	CBFIFLFMBFP.IFABMAAINID HFLHDMAAGOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	CJDNHKNDDJI.DFEGMMCMEBF PKHBJCOCEEC
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	APKEIIBCNIN.OAGAKJIEFFI<GAACMGKKDOM, IOPMFGMDJPO, CBFIFLFMBFP> BDKMIAJCJOB
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	DHOPMECPOPB.EIBEAMLHBGO GOAMJELJAJF
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	EFIIIKJACBD HPEGGFHJFJM
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	DDANONBHMDG ALJBOGIBADE
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	PPLGKLIDLAD FLPEMAMHFIA
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	AHCIJAAMNIC MEFIBGNCMCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	PHGJGDEAFJJ GDNNFNGPKDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class KLNOGGOHDBD
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x271B7C0", Offset = "0x2719FC0", VA = "0x18271B7C0")]
	public static IOPMFGMDJPO CKJHBCDNHIK(this IOPMFGMDJPO NFOGFJOGLPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x271B8D0", Offset = "0x271A0D0", VA = "0x18271B8D0")]
	public static IOPMFGMDJPO JIMILBACNDG(this NAEBFJMGILJ NFOGFJOGLPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct NAEBFJMGILJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct ADKOOMNEHHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<object?, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public CBFIFLFMBFP root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public NAEBFJMGILJ self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<HCGBMJDNFKJ<object?, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x270D790", Offset = "0x270BF90", VA = "0x18270D790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x270DA50", Offset = "0x270C250", VA = "0x18270DA50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly ByteString GDCDOMLHCOE;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xCEDE50", Offset = "0xCEC650", VA = "0x180CEDE50")]
	private NAEBFJMGILJ(ByteString OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x271DEA0", Offset = "0x271C6A0", VA = "0x18271DEA0")]
	public static IOPMFGMDJPO JAFDANKMDEP(ByteString OPMIAMEJKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x271E070", Offset = "0x271C870", VA = "0x18271E070")]
	public static ADAEHAOBIIA<GAACMGKKDOM, NAEBFJMGILJ> MDDBKKNJAEK(IOPMFGMDJPO EPJMHCCBMKN)
	{
		return default(ADAEHAOBIIA<GAACMGKKDOM, NAEBFJMGILJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x271DF60", Offset = "0x271C760", VA = "0x18271DF60")]
	[AsyncStateMachine(typeof(ADKOOMNEHHG))]
	public static Task<HCGBMJDNFKJ<object, CPMHOEMAGED>> JEKGNGGDDCP(CBFIFLFMBFP PNDCHGJLEGG, NAEBFJMGILJ NFOGFJOGLPE)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct HPICJEKBACK
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2718210", Offset = "0x2716A10", VA = "0x182718210")]
	public static IOPMFGMDJPO JAFDANKMDEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x27182B0", Offset = "0x2716AB0", VA = "0x1827182B0")]
	public static ADAEHAOBIIA<GAACMGKKDOM, HPICJEKBACK> MDDBKKNJAEK(IOPMFGMDJPO EPJMHCCBMKN)
	{
		return default(ADAEHAOBIIA<GAACMGKKDOM, HPICJEKBACK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2718190", Offset = "0x2716990", VA = "0x182718190")]
	public static HCGBMJDNFKJ<OLONILFLODF, FHIEBGLCLNJ> GPFOEJOAFKH(CBFIFLFMBFP PNDCHGJLEGG, [In] HPICJEKBACK NFOGFJOGLPE)
	{
		return default(HCGBMJDNFKJ<OLONILFLODF, FHIEBGLCLNJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct DNOIJOAFOFP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct LNGCKDJEGFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<OLONILFLODF, FHIEBGLCLNJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public CBFIFLFMBFP root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public DNOIJOAFOFP self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private HCGBMJDNFKJ<OLONILFLODF, FHIEBGLCLNJ> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x271C8D0", Offset = "0x271B0D0", VA = "0x18271C8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x271CC40", Offset = "0x271B440", VA = "0x18271CC40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly KKMNDMIFHBK? NDEHFNJADIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly AMFIADCCEFK? AKPJNGCNJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly NLICKNHNJCI? PNDBAFBFNNB;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2623900", Offset = "0x2622100", VA = "0x182623900")]
	private DNOIJOAFOFP(KKMNDMIFHBK? EIJIJJNENOI, AMFIADCCEFK? HDKGPBDFDHD, NLICKNHNJCI? GDDBLNGCPFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x27147F0", Offset = "0x2712FF0", VA = "0x1827147F0")]
	public static IOPMFGMDJPO? JAFDANKMDEP(KKMNDMIFHBK? EIJIJJNENOI, AMFIADCCEFK? HDKGPBDFDHD, NLICKNHNJCI? GDDBLNGCPFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2714A30", Offset = "0x2713230", VA = "0x182714A30")]
	public static ADAEHAOBIIA<GAACMGKKDOM, DNOIJOAFOFP> MDDBKKNJAEK(IOPMFGMDJPO EPJMHCCBMKN)
	{
		return default(ADAEHAOBIIA<GAACMGKKDOM, DNOIJOAFOFP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x27148F0", Offset = "0x27130F0", VA = "0x1827148F0")]
	[AsyncStateMachine(typeof(LNGCKDJEGFF))]
	public static Task<HCGBMJDNFKJ<OLONILFLODF, FHIEBGLCLNJ>> JEKGNGGDDCP(CBFIFLFMBFP PNDCHGJLEGG, DNOIJOAFOFP NFOGFJOGLPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct HIFMJEKAKGN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct MFOEDPHHPHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<LLABCKEFCJH, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public HIFMJEKAKGN self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CBFIFLFMBFP root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private HCGBMJDNFKJ<LLABCKEFCJH, CPMHOEMAGED> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private HCGBMJDNFKJ<object?, IGEMMGEDLOA>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private HCGBMJDNFKJ<object?, IGEMMGEDLOA> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private HCGBMJDNFKJ<object?, IGEMMGEDLOA>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter<HCGBMJDNFKJ<object?, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x271D000", Offset = "0x271B800", VA = "0x18271D000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x271D460", Offset = "0x271BC60", VA = "0x18271D460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly IReadOnlyList<IOPMFGMDJPO> KMAJCGOKOND;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xCEDE50", Offset = "0xCEC650", VA = "0x180CEDE50")]
	private HIFMJEKAKGN(IReadOnlyList<IOPMFGMDJPO> IMJIJNKIOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x27171C0", Offset = "0x27159C0", VA = "0x1827171C0")]
	public static IOPMFGMDJPO JAFDANKMDEP(IReadOnlyList<IOPMFGMDJPO> IMJIJNKIOAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x27173C0", Offset = "0x2715BC0", VA = "0x1827173C0")]
	public static ADAEHAOBIIA<GAACMGKKDOM, HIFMJEKAKGN> MDDBKKNJAEK(IOPMFGMDJPO EPJMHCCBMKN)
	{
		return default(ADAEHAOBIIA<GAACMGKKDOM, HIFMJEKAKGN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2717280", Offset = "0x2715A80", VA = "0x182717280")]
	[AsyncStateMachine(typeof(MFOEDPHHPHJ))]
	public static Task<HCGBMJDNFKJ<LLABCKEFCJH, CPMHOEMAGED>> JEKGNGGDDCP(CBFIFLFMBFP PNDCHGJLEGG, HIFMJEKAKGN NFOGFJOGLPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct FLOGJLOBLDA
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class FENLLDGMLDC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class DGBBCGKDAHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public CMDPIJDKPHC<FENLLDGMLDC> actionId;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public DGBBCGKDAHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2710210", Offset = "0x270EA10", VA = "0x182710210")]
		internal IOPMFGMDJPO IPPOMDNEAOC(int count, int index, [In] ReadOnlySpan<byte> span)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly CMDPIJDKPHC<FENLLDGMLDC> GJOLKEALCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly int FCHJPHAGFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly int NHCKMLOFHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly byte[] BADLMALNNLF;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2715970", Offset = "0x2714170", VA = "0x182715970")]
	private FLOGJLOBLDA(CMDPIJDKPHC<FENLLDGMLDC> POLGBHHHKGA, int PCFOAHIEPDL, int FPEOONOJHML, byte[] NFNBKNAJBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2715710", Offset = "0x2713F10", VA = "0x182715710")]
	public static IOPMFGMDJPO JAFDANKMDEP(CMDPIJDKPHC<FENLLDGMLDC> POLGBHHHKGA, int PCFOAHIEPDL, int FPEOONOJHML, ByteString NFNBKNAJBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2715470", Offset = "0x2713C70", VA = "0x182715470")]
	public static IOPMFGMDJPO[] APNEKJOCGEC(IOPMFGMDJPO GFMBHCHPLDH, int KOLPKELACKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2715820", Offset = "0x2714020", VA = "0x182715820")]
	public static ADAEHAOBIIA<GAACMGKKDOM, FLOGJLOBLDA> MDDBKKNJAEK(IOPMFGMDJPO EPJMHCCBMKN)
	{
		return default(ADAEHAOBIIA<GAACMGKKDOM, FLOGJLOBLDA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2715580", Offset = "0x2713D80", VA = "0x182715580")]
	public static HCGBMJDNFKJ<IOPMFGMDJPO, CPMHOEMAGED> GPFOEJOAFKH(CBFIFLFMBFP PNDCHGJLEGG, [In] FLOGJLOBLDA NFOGFJOGLPE)
	{
		return default(HCGBMJDNFKJ<IOPMFGMDJPO, CPMHOEMAGED>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct JGJPBPJENAK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct DCEMFJPFKIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<bool, FHIEBGLCLNJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public CBFIFLFMBFP root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public JGJPBPJENAK self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private HCGBMJDNFKJ<bool, FHIEBGLCLNJ> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, FHIEBGLCLNJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x270F9E0", Offset = "0x270E1E0", VA = "0x18270F9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2710020", Offset = "0x270E820", VA = "0x182710020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly int FCHJPHAGFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly int NHCKMLOFHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly byte[] BADLMALNNLF;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xC035A0", Offset = "0xC01DA0", VA = "0x180C035A0")]
	private JGJPBPJENAK(int PCFOAHIEPDL, int FPEOONOJHML, byte[] NFNBKNAJBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x271AAD0", Offset = "0x27192D0", VA = "0x18271AAD0")]
	public static IOPMFGMDJPO JAFDANKMDEP(int PCFOAHIEPDL, int FPEOONOJHML, ByteString NFNBKNAJBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x271ADC0", Offset = "0x27195C0", VA = "0x18271ADC0")]
	public static IOPMFGMDJPO?[]? MFCJNLNDCFI(int KOLPKELACKA, KKMNDMIFHBK? EIJIJJNENOI, AMFIADCCEFK? HDKGPBDFDHD, NLICKNHNJCI? GDDBLNGCPFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x271ACE0", Offset = "0x27194E0", VA = "0x18271ACE0")]
	public static ADAEHAOBIIA<GAACMGKKDOM, JGJPBPJENAK> MDDBKKNJAEK(IOPMFGMDJPO EPJMHCCBMKN)
	{
		return default(ADAEHAOBIIA<GAACMGKKDOM, JGJPBPJENAK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x271ABB0", Offset = "0x27193B0", VA = "0x18271ABB0")]
	[AsyncStateMachine(typeof(DCEMFJPFKIE))]
	public static Task<HCGBMJDNFKJ<bool, FHIEBGLCLNJ>> JEKGNGGDDCP(CBFIFLFMBFP PNDCHGJLEGG, JGJPBPJENAK NFOGFJOGLPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class FHBPOHFIPHM : GIOPBMKLFFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly CBFIFLFMBFP BLOIFBAMAPA;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public AOBCKJAKMIK? DJLOIKDDKCN
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x27150D0", Offset = "0x27138D0", VA = "0x1827150D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9EBB90", Offset = "0x9EA390", VA = "0x1809EBB90")]
	internal FHBPOHFIPHM(CBFIFLFMBFP MPABKJPPPMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class HKJENCNKGDD : AOBCKJAKMIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly CBFIFLFMBFP BLOIFBAMAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly BGNIJNAIFMH KMOOMFFELMH;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x9E57C0", Offset = "0x9E3FC0", VA = "0x1809E57C0")]
	public HKJENCNKGDD(CBFIFLFMBFP MPABKJPPPMM, BGNIJNAIFMH GIPBFFNFCDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2717460", Offset = "0x2715C60", VA = "0x182717460", Slot = "4")]
	public HCGBMJDNFKJ<GKMEGDNGDLG, JCOFLCFPMPM> MPPENLNBGCM(CMDPIJDKPHC<KGLBPIDLJAB> OPPFCAMGFJA, NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM, NLPIAAOFKEO<GJMDNLCCEPC> ECEBGAIHGFC)
	{
		return default(HCGBMJDNFKJ<GKMEGDNGDLG, JCOFLCFPMPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2717A50", Offset = "0x2716250", VA = "0x182717A50", Slot = "5")]
	public HCGBMJDNFKJ<GKMEGDNGDLG, JCOFLCFPMPM> PGFPCONHHBG(CMDPIJDKPHC<KGLBPIDLJAB> OPPFCAMGFJA, NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM, NLPIAAOFKEO<NAIBBEJGHLI> GHICKGEHGDH)
	{
		return default(HCGBMJDNFKJ<GKMEGDNGDLG, JCOFLCFPMPM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class PPIONKMKDEM : CEPMGLFFGOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface BJABODJBOAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<BGNIJNAIFMH> KMKPGOJBCNA(CBFIFLFMBFP MPABKJPPPMM, AMFIADCCEFK? OJAGEHDBKCB, NLICKNHNJCI? DMEFGCOJFLE, CancellationToken DNHBNMHIDAC);

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		BDKILJGICFC OKKEIMBAAML(CBFIFLFMBFP MPABKJPPPMM, KKMNDMIFHBK JAOMGMGEKCK);
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class DIIMFKLDDPJ : BJABODJBOAI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private struct MNKLADFLNOI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public AsyncTaskMethodBuilder<BGNIJNAIFMH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public CBFIFLFMBFP circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public AMFIADCCEFK cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public NLICKNHNJCI cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private TaskAwaiter<CJDNHKNDDJI> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x271D770", Offset = "0x271BF70", VA = "0x18271D770", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x271D940", Offset = "0x271C140", VA = "0x18271D940", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly DIIMFKLDDPJ DJLOIKDDKCN;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		private DIIMFKLDDPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2714380", Offset = "0x2712B80", VA = "0x182714380", Slot = "4")]
		[AsyncStateMachine(typeof(MNKLADFLNOI))]
		public Task<BGNIJNAIFMH> KMKPGOJBCNA(CBFIFLFMBFP MPABKJPPPMM, AMFIADCCEFK? OJAGEHDBKCB, NLICKNHNJCI? DMEFGCOJFLE, CancellationToken DNHBNMHIDAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x27144E0", Offset = "0x2712CE0", VA = "0x1827144E0", Slot = "5")]
		public BDKILJGICFC OKKEIMBAAML(CBFIFLFMBFP MPABKJPPPMM, KKMNDMIFHBK JAOMGMGEKCK)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct KCHDAFCOGIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public AsyncTaskMethodBuilder<PPIONKMKDEM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public CBFIFLFMBFP circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public AMFIADCCEFK cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NLICKNHNJCI cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public KKMNDMIFHBK evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private BJABODJBOAI <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter<BGNIJNAIFMH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x271B250", Offset = "0x2719A50", VA = "0x18271B250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x271B750", Offset = "0x2719F50", VA = "0x18271B750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly BGNIJNAIFMH KMOOMFFELMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly BDKILJGICFC BDMDEKOHLPG;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public KKGMNBFIOAK LIOODFBMCMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2720310", Offset = "0x271EB10", VA = "0x182720310", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public DKODMLGEKLD FGOIDKCKPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2720360", Offset = "0x271EB60", VA = "0x182720360", Slot = "5")]
		get
		{
			return default(DKODMLGEKLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public HKJENCNKGDD KIIBBHPLCNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public CEAAAOGMPJE GACKNFEGFDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xEB4DB0", Offset = "0xEB35B0", VA = "0x180EB4DB0")]
	private PPIONKMKDEM(BGNIJNAIFMH GIPBFFNFCDJ, BDKILJGICFC FJHHGGJIIPM, HKJENCNKGDD DMGFPGPLLJH, CEAAAOGMPJE NNIMNAHPKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2720140", Offset = "0x271E940", VA = "0x182720140")]
	[AsyncStateMachine(typeof(KCHDAFCOGIA))]
	public static Task<PPIONKMKDEM> BDDBDKBBGDP(CBFIFLFMBFP MPABKJPPPMM, KKMNDMIFHBK JAOMGMGEKCK, AMFIADCCEFK? OJAGEHDBKCB, NLICKNHNJCI? DMEFGCOJFLE, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x27202B0", Offset = "0x271EAB0", VA = "0x1827202B0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class NACBMONFLFA : FPOFNHLILIO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface JADAMBFFCPB
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CEPMGLFFGOE> PBCDBICJHKM(CBFIFLFMBFP MPABKJPPPMM, KKMNDMIFHBK JAOMGMGEKCK, AMFIADCCEFK? OJAGEHDBKCB, NLICKNHNJCI? DMEFGCOJFLE, CancellationToken DNHBNMHIDAC);

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OGAFAEPKKCN();

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KOAHMBHBKIM();
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public abstract class CPPGMAEMGCA : JADAMBFFCPB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private struct CLHHJLMJMLK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public AsyncTaskMethodBuilder<CEPMGLFFGOE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public CBFIFLFMBFP circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public KKMNDMIFHBK evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public AMFIADCCEFK cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public NLICKNHNJCI cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private TaskAwaiter<PPIONKMKDEM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x270F4D0", Offset = "0x270DCD0", VA = "0x18270F4D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x270F810", Offset = "0x270E010", VA = "0x18270F810", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x270F880", Offset = "0x270E080", VA = "0x18270F880", Slot = "4")]
		[AsyncStateMachine(typeof(CLHHJLMJMLK))]
		public Task<CEPMGLFFGOE> PBCDBICJHKM(CBFIFLFMBFP MPABKJPPPMM, KKMNDMIFHBK JAOMGMGEKCK, AMFIADCCEFK? OJAGEHDBKCB, NLICKNHNJCI? DMEFGCOJFLE, CancellationToken DNHBNMHIDAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void OGAFAEPKKCN();

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void KOAHMBHBKIM();

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		protected CPPGMAEMGCA()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct PNJFEBMHKPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AsyncTaskMethodBuilder<CEPMGLFFGOE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public NACBMONFLFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskAwaiter<OLONILFLODF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x271FBA0", Offset = "0x271E3A0", VA = "0x18271FBA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x271FDA0", Offset = "0x271E5A0", VA = "0x18271FDA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct FGGHOEFPDDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public NACBMONFLFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public CBFIFLFMBFP circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public KKMNDMIFHBK evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AMFIADCCEFK cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public NLICKNHNJCI cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<CEPMGLFFGOE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x2714B40", Offset = "0x2713340", VA = "0x182714B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x2715070", Offset = "0x2713870", VA = "0x182715070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly JADAMBFFCPB DDCMACNPPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly TaskCompletionSource<OLONILFLODF> LKHDGMJKCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly TaskCompletionSource<OLONILFLODF> IKHMIAPEOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly CancellationTokenSource DEAFNKEHNNG;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool PHIBMLBJJJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA0BF30", Offset = "0xA0A730", VA = "0x180A0BF30", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA0BCB0", Offset = "0xA0A4B0", VA = "0x180A0BCB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool ABPKKBNEOIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xD83040", Offset = "0xD81840", VA = "0x180D83040", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x12C97F0", Offset = "0x12C7FF0", VA = "0x1812C97F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool DKNIIKFJHHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x19A0EF0", Offset = "0x199F6F0", VA = "0x1819A0EF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x271DC90", Offset = "0x271C490", VA = "0x18271DC90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public CEPMGLFFGOE? BHKCDLNICII
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DC0", Offset = "0x9DF5C0", VA = "0x1809E0DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x271DCA0", Offset = "0x271C4A0", VA = "0x18271DCA0", Slot = "7")]
	[AsyncStateMachine(typeof(PNJFEBMHKPD))]
	public Task<CEPMGLFFGOE> JOLHKADGHAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x271DD90", Offset = "0x271C590", VA = "0x18271DD90")]
	public NACBMONFLFA(JADAMBFFCPB ILEBEOADOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x271DB30", Offset = "0x271C330", VA = "0x18271DB30", Slot = "8")]
	[AsyncStateMachine(typeof(FGGHOEFPDDE))]
	public Task HIAIDEEKLJH(CBFIFLFMBFP MPABKJPPPMM, KKMNDMIFHBK JAOMGMGEKCK, AMFIADCCEFK? OJAGEHDBKCB, NLICKNHNJCI? DMEFGCOJFLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x271D9B0", Offset = "0x271C1B0", VA = "0x18271D9B0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class CANMFBNBKLA : FAHGLKBFOGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CEAAAOGMPJE IDIAJLEDNKK;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x9EBB90", Offset = "0x9EA390", VA = "0x1809EBB90")]
	public CANMFBNBKLA(CEAAAOGMPJE NNIMNAHPKDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal static class LEMCPNLGNDE
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class KPLLKHMOLIK<TGraph> : OGLLKKPOEEN where TGraph : AJBGCNAPMOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		protected readonly TGraph ONKODFCJLJK;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public virtual BGBDGHEJNJA? PPNPIOGMOOL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x17ABBD0", Offset = "0x17AA3D0", VA = "0x1817ABBD0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual CMDPIJDKPHC<KGLBPIDLJAB>? ELENCOIFMPL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x17ABBD0", Offset = "0x17AA3D0", VA = "0x1817ABBD0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public NLPIAAOFKEO<PAJOPNAJIFC> DOCKCOIAGNN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x4F504F0", Offset = "0x4F4ECF0", VA = "0x184F504F0", Slot = "5")]
			get
			{
				return default(NLPIAAOFKEO<PAJOPNAJIFC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public NLPIAAOFKEO<PAJOPNAJIFC>? KEJFGILGDMP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x4F50510", Offset = "0x4F4ED10", VA = "0x184F50510", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9EBB90", Offset = "0x9EA390", VA = "0x1809EBB90")]
		public KPLLKHMOLIK(TGraph LJMFKPGJJNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private sealed class DEMFJHELNEO : KPLLKHMOLIK<HHAGJJNILEA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override BGBDGHEJNJA? PPNPIOGMOOL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x2710120", Offset = "0x270E920", VA = "0x182710120", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override CMDPIJDKPHC<KGLBPIDLJAB>? ELENCOIFMPL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x2710090", Offset = "0x270E890", VA = "0x182710090", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2710140", Offset = "0x270E940", VA = "0x182710140")]
		public DEMFJHELNEO(HHAGJJNILEA HNCEKNHCLGC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x271C1C0", Offset = "0x271A9C0", VA = "0x18271C1C0")]
	public static OGLLKKPOEEN CJOJELENPLJ(AJBGCNAPMOH LJMFKPGJJNC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class DGFCGAGPDLK : GCMFNEDFOMM, HPINLINDDFK, IIGEGHJBEFA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class IJMKLGMBHOH
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
			public IJMKLGMBHOH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public EFIIIKJACBD errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x2720420", Offset = "0x271EC20", VA = "0x182720420", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2720690", Offset = "0x271EE90", VA = "0x182720690", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public DGFCGAGPDLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public IJMKLGMBHOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2718B40", Offset = "0x2717340", VA = "0x182718B40")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task IKDNALGGFPL(EFIIIKJACBD errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct PMGOHCJEPLO : IAsyncStateMachine
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
		public DGFCGAGPDLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x271F630", Offset = "0x271DE30", VA = "0x18271F630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x271FB40", Offset = "0x271E340", VA = "0x18271FB40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class PONOJKGAOHD
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
			public PONOJKGAOHD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x27206F0", Offset = "0x271EEF0", VA = "0x1827206F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x27209D0", Offset = "0x271F1D0", VA = "0x1827209D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public DGFCGAGPDLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public PONOJKGAOHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x271FE10", Offset = "0x271E610", VA = "0x18271FE10")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task APHDLHJEOLI(EFIIIKJACBD errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class JMOFBLNGJEB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		private struct <<RequestSetVectorComponentValue>g__requestSetVectorComponentValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public JMOFBLNGJEB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x2720F50", Offset = "0x271F750", VA = "0x182720F50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x2721400", Offset = "0x271FC00", VA = "0x182721400", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public DGFCGAGPDLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int valueIndex;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public JMOFBLNGJEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x271AFB0", Offset = "0x27197B0", VA = "0x18271AFB0")]
		[AsyncStateMachine(typeof(<<RequestSetVectorComponentValue>g__requestSetVectorComponentValueInternal|0>d))]
		internal Task CJLOIGNOPGJ(EFIIIKJACBD errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class IFFPJECFBFP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		private struct <<RequestSetQuaternionComponentValue>g__requestSetQuaternionComponentValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public IFFPJECFBFP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x2720A30", Offset = "0x271F230", VA = "0x182720A30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x2720EF0", Offset = "0x271F6F0", VA = "0x182720EF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public DGFCGAGPDLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int valueIndex;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public IFFPJECFBFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2718A70", Offset = "0x2717270", VA = "0x182718A70")]
		[AsyncStateMachine(typeof(<<RequestSetQuaternionComponentValue>g__requestSetQuaternionComponentValueInternal|0>d))]
		internal Task MPBHGMBBKDO(EFIIIKJACBD errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly FKJCHPEGLLH FKIHEINAMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly ICollection<EPACLJDNGMH> POGDPIABPGN;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private PNCMBCNMLMI GJAOBEFNFMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2711930", Offset = "0x2710130", VA = "0x182711930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public NLPIAAOFKEO<GJMDNLCCEPC> LELGMGKKLAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xF1C4B0", Offset = "0xF1ACB0", VA = "0x180F1C4B0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(NLPIAAOFKEO<GJMDNLCCEPC>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xF1C750", Offset = "0xF1AF50", VA = "0x180F1C750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private NLPIAAOFKEO<IKLIGFGFCNJ> DJLKNEFMPNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x12C7F20", Offset = "0x12C6720", VA = "0x1812C7F20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public NLPIAAOFKEO<GCOKIOOPJJN> KCJHLOIEJHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA06680", Offset = "0xA04E80", VA = "0x180A06680", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(NLPIAAOFKEO<GCOKIOOPJJN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override NLPIAAOFKEO<GGAOHKIBKBD> NPEHLCFAENM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2710D10", Offset = "0x270F510", VA = "0x182710D10", Slot = "21")]
		get
		{
			return default(NLPIAAOFKEO<GGAOHKIBKBD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool ACJAPHMONDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2712D60", Offset = "0x2711560", VA = "0x182712D60", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2714160", Offset = "0x2712960", VA = "0x182714160")]
	private DGFCGAGPDLK(CBFIFLFMBFP MPABKJPPPMM, BKBACPLKPAP GDFCBMOFMFN, FKJCHPEGLLH NKKLCDDPMLE, NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM, NLPIAAOFKEO<GJMDNLCCEPC> ECEBGAIHGFC, NLPIAAOFKEO<IKLIGFGFCNJ> CEOGNLEJOEB, bool KBFHNLPGBJI, string GLGOHIJMLFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2710EA0", Offset = "0x270F6A0", VA = "0x182710EA0")]
	public static DGFCGAGPDLK CJOJELENPLJ(CBFIFLFMBFP MPABKJPPPMM, BKBACPLKPAP GDFCBMOFMFN, FKJCHPEGLLH JEOEDPICHHI, NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM, NLPIAAOFKEO<IKLIGFGFCNJ> CEOGNLEJOEB, NLPIAAOFKEO<GJMDNLCCEPC> ECEBGAIHGFC, bool KBFHNLPGBJI, bool IMIMPLPNBNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2713B40", Offset = "0x2712340", VA = "0x182713B40", Slot = "22")]
	protected override void NPIOKLMMDIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2711540", Offset = "0x270FD40", VA = "0x182711540", Slot = "23")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x27135C0", Offset = "0x2711DC0", VA = "0x1827135C0", Slot = "31")]
	public void MMECBMIBKLL(EPACLJDNGMH FHKDGBGHEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x27107D0", Offset = "0x270EFD0", VA = "0x1827107D0", Slot = "28")]
	public void BOOPBGFNFFO(EBNDOBOFAAN LAEPJLBKCEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2711A10", Offset = "0x2710210", VA = "0x182711A10", Slot = "29")]
	public void ENHBGDFAEEG(HHCJKCDMPHG NMAEJCPNIKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x27129A0", Offset = "0x27111A0", VA = "0x1827129A0", Slot = "24")]
	protected override void FNICLKCFFGF(JFEOKLEMHKB PIHIBDBKCCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2710650", Offset = "0x270EE50", VA = "0x182710650", Slot = "33")]
	public string BAOOFNKJJGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2713E90", Offset = "0x2712690", VA = "0x182713E90", Slot = "30")]
	public string PMNAINPNDIF(int CFPHIOFNMLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2713830", Offset = "0x2712030", VA = "0x182713830")]
	private void NIDJHBBELGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2711950", Offset = "0x2710150", VA = "0x182711950", Slot = "32")]
	public void ELNOBLIEJHB(EPACLJDNGMH FHKDGBGHEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2710380", Offset = "0x270EB80", VA = "0x182710380")]
	private void AFBEDANAMBE(bool OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2713CC0", Offset = "0x27124C0", VA = "0x182713CC0", Slot = "34")]
	[AsyncStateMachine(typeof(PMGOHCJEPLO))]
	public Task ONKLKFAHNEC(string OPMIAMEJKDH, bool EOJJGPJLKMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2711320", Offset = "0x270FB20", VA = "0x182711320")]
	public void DFMKFIFHPBC(string OPMIAMEJKDH, bool EOJJGPJLKMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2711790", Offset = "0x270FF90", VA = "0x182711790")]
	private void EIHOMAKIAMJ(int OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x27132B0", Offset = "0x2711AB0", VA = "0x1827132B0")]
	private void MIINODKNKOG(int DHPAIIHFFEJ, string OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2710B50", Offset = "0x270F350", VA = "0x182710B50")]
	private void CAFDIDDLHIO(int DHPAIIHFFEJ, string OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2713470", Offset = "0x2711C70", VA = "0x182713470")]
	private string MIJAPBPKDCL(int DHPAIIHFFEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2713090", Offset = "0x2711890", VA = "0x182713090")]
	private string LPMEELBICED(int DHPAIIHFFEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0xF1C750", Offset = "0xF1AF50", VA = "0x180F1C750")]
	internal void JLCEIPPJKDM(NLPIAAOFKEO<GJMDNLCCEPC> OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2711470", Offset = "0x270FC70", VA = "0x182711470")]
	[CompilerGenerated]
	private void DKJGNNIKNJA(string OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2712C30", Offset = "0x2711430", VA = "0x182712C30")]
	[CompilerGenerated]
	private bool HPBJHODHEDH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2713DD0", Offset = "0x27125D0", VA = "0x182713DD0")]
	[CompilerGenerated]
	private bool PLDDKOCPDOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2712DE0", Offset = "0x27115E0", VA = "0x182712DE0")]
	[CompilerGenerated]
	private int IGBJPBFMFPP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2710550", Offset = "0x270ED50", VA = "0x182710550")]
	[CompilerGenerated]
	private bool AJAMFAKJAPD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2712EC0", Offset = "0x27116C0", VA = "0x182712EC0")]
	[CompilerGenerated]
	private void LFNKNPMPOGP(string OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2711480", Offset = "0x270FC80", VA = "0x182711480")]
	[CompilerGenerated]
	private bool DNHDCNFICCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2713620", Offset = "0x2711E20", VA = "0x182713620")]
	[CompilerGenerated]
	private bool MNBBAIAGPLC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2713220", Offset = "0x2711A20", VA = "0x182713220")]
	[CompilerGenerated]
	private bool MGHNHOIJEOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2712DE0", Offset = "0x27115E0", VA = "0x182712DE0")]
	[CompilerGenerated]
	private int JBHAKAFGILA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2710DD0", Offset = "0x270F5D0", VA = "0x182710DD0")]
	[CompilerGenerated]
	private bool CINCKNMOBKD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2712FA0", Offset = "0x27117A0", VA = "0x182712FA0")]
	[CompilerGenerated]
	private object LMOGHJKBCIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x27136E0", Offset = "0x2711EE0", VA = "0x1827136E0")]
	[CompilerGenerated]
	private void NANCNIBFJMD(object OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2713A70", Offset = "0x2712270", VA = "0x182713A70")]
	[CompilerGenerated]
	private bool NIOFHGAMIOG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2712CF0", Offset = "0x27114F0", VA = "0x182712CF0")]
	[CompilerGenerated]
	private string HPFDJCKLOLF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2713BE0", Offset = "0x27123E0", VA = "0x182713BE0")]
	[CompilerGenerated]
	private void ODGNKGFMHGJ(string OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2711250", Offset = "0x270FA50", VA = "0x182711250")]
	[CompilerGenerated]
	private bool CKKLAKMANDJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2713020", Offset = "0x2711820", VA = "0x182713020")]
	[CompilerGenerated]
	private string LNHFOBAIAKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x27115E0", Offset = "0x270FDE0", VA = "0x1827115E0")]
	[CompilerGenerated]
	private void EAHOHLMOMMF(string OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2712B60", Offset = "0x2711360", VA = "0x182712B60")]
	[CompilerGenerated]
	private bool HNBIGJGMALD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2710D60", Offset = "0x270F560", VA = "0x182710D60")]
	[CompilerGenerated]
	private string CDPCFBKNOBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2712EA0", Offset = "0x27116A0", VA = "0x182712EA0")]
	[CompilerGenerated]
	private void JCFABJJEEEM(string OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x27115F0", Offset = "0x270FDF0", VA = "0x1827115F0")]
	[CompilerGenerated]
	private bool EBGIPODNJGE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2713670", Offset = "0x2711E70", VA = "0x182713670")]
	[CompilerGenerated]
	private string MOOFEHMPFPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2712EB0", Offset = "0x27116B0", VA = "0x182712EB0")]
	[CompilerGenerated]
	private void LBBCEMPJCCL(string OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2713760", Offset = "0x2711F60", VA = "0x182713760")]
	[CompilerGenerated]
	private bool NEGNLILCOMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x27105E0", Offset = "0x270EDE0", VA = "0x1827105E0")]
	[CompilerGenerated]
	private string AMDOFLAPOJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2710B40", Offset = "0x270F340", VA = "0x182710B40")]
	[CompilerGenerated]
	private void BPKAPNCOMAH(string OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x27116C0", Offset = "0x270FEC0", VA = "0x1827116C0")]
	[CompilerGenerated]
	private bool EHEDLFKHIND()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2712E30", Offset = "0x2711630", VA = "0x182712E30")]
	[CompilerGenerated]
	private string IIINOJOGNNH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2713A60", Offset = "0x2712260", VA = "0x182713A60")]
	[CompilerGenerated]
	private void NIMNGBDPKIH(string OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2713BF0", Offset = "0x27123F0", VA = "0x182713BF0")]
	[CompilerGenerated]
	private bool OGOGJFMIKFB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2712AF0", Offset = "0x27112F0", VA = "0x182712AF0")]
	[CompilerGenerated]
	private string HLFFAAKNBHA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2710540", Offset = "0x270ED40", VA = "0x182710540")]
	[CompilerGenerated]
	private void AFIOMMGHMOJ(string OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2712ED0", Offset = "0x27116D0", VA = "0x182712ED0")]
	[CompilerGenerated]
	private bool LHHJIINAMMN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class FPOLELDPKKA
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private sealed class NHLNDEHKPLN : IJIPHCJMIJF<CIGHEFJJOHO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class MAADLGLDHCL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public NHLNDEHKPLN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public LNHBIEKMMIC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public MAADLGLDHCL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x271CD80", Offset = "0x271B580", VA = "0x18271CD80")]
			internal object KOACCBJHCAE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x271CCB0", Offset = "0x271B4B0", VA = "0x18271CCB0")]
			internal void DAJNJOHEPHE(object value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x271E3B0", Offset = "0x271CBB0", VA = "0x18271E3B0")]
		public NHLNDEHKPLN(CBFIFLFMBFP MPABKJPPPMM, CIGHEFJJOHO JLPKBNIJDEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x271E120", Offset = "0x271C920", VA = "0x18271E120", Slot = "134")]
		protected override void KCBBIJPOMMB(APKPIDOBEFA NBFCHNOPHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public sealed class MECJCEPLKHI : PPDFFPOLCBE<GCHFAMANLAM>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override NGIJPDCOOEK DDDMJKGGPBD
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xBB4EE0", Offset = "0xBB36E0", VA = "0x180BB4EE0", Slot = "140")]
			get
			{
				return default(NGIJPDCOOEK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x271CFA0", Offset = "0x271B7A0", VA = "0x18271CFA0")]
		public MECJCEPLKHI(CBFIFLFMBFP MPABKJPPPMM, GCHFAMANLAM JLPKBNIJDEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class AANJJGCDGPK : IJIPHCJMIJF<LFPLIPLGAGM>
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x27029A0", Offset = "0x27011A0", VA = "0x1827029A0")]
		public AANJJGCDGPK(CBFIFLFMBFP MPABKJPPPMM, LFPLIPLGAGM GDFCBMOFMFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x27026F0", Offset = "0x2700EF0", VA = "0x1827026F0", Slot = "134")]
		protected override void KCBBIJPOMMB(APKPIDOBEFA NBFCHNOPHLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x27026A0", Offset = "0x2700EA0", VA = "0x1827026A0")]
		[CompilerGenerated]
		private bool FOCMOEJBMHL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2702870", Offset = "0x2701070", VA = "0x182702870")]
		[CompilerGenerated]
		private void PIOEBBLEHAP(bool OPMIAMEJKDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public sealed class LKEFOGGINID : IJIPHCJMIJF<LGEHICAMLAP>
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private sealed class PBLMHBIIKHO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public LNHBIEKMMIC nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public LKEFOGGINID <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public PBLMHBIIKHO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x271EE10", Offset = "0x271D610", VA = "0x18271EE10")]
			internal void KOACCBJHCAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x271EC40", Offset = "0x271D440", VA = "0x18271EC40")]
			internal bool DAJNJOHEPHE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x271EE60", Offset = "0x271D660", VA = "0x18271EE60")]
			internal bool LFCONHGLCKD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x271ECE0", Offset = "0x271D4E0", VA = "0x18271ECE0")]
			internal void IHPGAMMHHFC(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x271EC90", Offset = "0x271D490", VA = "0x18271EC90")]
			internal bool FJIIPMHGAJJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x271C860", Offset = "0x271B060", VA = "0x18271C860")]
		public LKEFOGGINID(CBFIFLFMBFP MPABKJPPPMM, LGEHICAMLAP GDFCBMOFMFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x271C520", Offset = "0x271AD20", VA = "0x18271C520", Slot = "134")]
		protected override void KCBBIJPOMMB(APKPIDOBEFA NBFCHNOPHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public sealed class KOEMHCMJIMC : IJIPHCJMIJF<BHBDMENBPCK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private sealed class PDIOCLEDFOD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public LNHBIEKMMIC nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public KOEMHCMJIMC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public PDIOCLEDFOD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x271F300", Offset = "0x271DB00", VA = "0x18271F300")]
			internal object KOACCBJHCAE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x271F560", Offset = "0x271DD60", VA = "0x18271F560")]
			internal bool OFCNKEHMCIB(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x271EEB0", Offset = "0x271D6B0", VA = "0x18271EEB0")]
			internal void DAJNJOHEPHE(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x271F400", Offset = "0x271DC00", VA = "0x18271F400")]
			internal string LFCONHGLCKD(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x271F2B0", Offset = "0x271DAB0", VA = "0x18271F2B0")]
			internal IReadOnlyList<object> IHPGAMMHHFC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x271F110", Offset = "0x271D910", VA = "0x18271F110")]
			internal bool FJIIPMHGAJJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x271F5E0", Offset = "0x271DDE0", VA = "0x18271F5E0")]
			internal bool OJDBMGKIAGD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x271F180", Offset = "0x271D980", VA = "0x18271F180")]
			internal void IHKKLMAGGNF(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x271C150", Offset = "0x271A950", VA = "0x18271C150")]
		public KOEMHCMJIMC(CBFIFLFMBFP MPABKJPPPMM, BHBDMENBPCK GDFCBMOFMFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x271BA00", Offset = "0x271A200", VA = "0x18271BA00", Slot = "134")]
		protected override void KCBBIJPOMMB(APKPIDOBEFA NBFCHNOPHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class FJJEIDNFHIH : IJIPHCJMIJF<NALIGCCKKDO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class LHEAMJABNCB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public FJJEIDNFHIH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public LNHBIEKMMIC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public LHEAMJABNCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x271C480", Offset = "0x271AC80", VA = "0x18271C480")]
			internal bool KOACCBJHCAE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x271C350", Offset = "0x271AB50", VA = "0x18271C350")]
			internal void DAJNJOHEPHE(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x271C4D0", Offset = "0x271ACD0", VA = "0x18271C4D0")]
			internal bool LFCONHGLCKD()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2715400", Offset = "0x2713C00", VA = "0x182715400")]
		public FJJEIDNFHIH(CBFIFLFMBFP MPABKJPPPMM, NALIGCCKKDO GDFCBMOFMFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x27151D0", Offset = "0x27139D0", VA = "0x1827151D0", Slot = "134")]
		protected override void KCBBIJPOMMB(APKPIDOBEFA NBFCHNOPHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public abstract class CAKJNBOEGGO<TNode> : IJIPHCJMIJF<TNode> where TNode : notnull, IOJCAJDGDMC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private struct BJHBCGCBOGK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public AsyncTaskMethodBuilder<HCGBMJDNFKJ<NLPIAAOFKEO<FGCGLNKNFGK>, CPMHOEMAGED>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public CAKJNBOEGGO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private TaskAwaiter<HCGBMJDNFKJ<NLPIAAOFKEO<FGCGLNKNFGK>, CPMHOEMAGED>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x5F1BDC0", Offset = "0x5F1A5C0", VA = "0x185F1BDC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x5F1C1D0", Offset = "0x5F1A9D0", VA = "0x185F1C1D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct FMPLIAOMFGA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public AsyncTaskMethodBuilder<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public CAKJNBOEGGO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public NLPIAAOFKEO<FGCGLNKNFGK> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x48E2AA0", Offset = "0x48E12A0", VA = "0x1848E2AA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x48E2EB0", Offset = "0x48E16B0", VA = "0x1848E2EB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public sealed override bool DLAGONFAHBO
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "129")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public sealed override NLPIAAOFKEO<FGCGLNKNFGK>? ACNKDCGHPJK
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x6300810", Offset = "0x62FF010", VA = "0x186300810", Slot = "133")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x502A4F0", Offset = "0x5028CF0", VA = "0x18502A4F0")]
		protected CAKJNBOEGGO(CBFIFLFMBFP MPABKJPPPMM, TNode GDFCBMOFMFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x63005B0", Offset = "0x62FEDB0", VA = "0x1863005B0", Slot = "114")]
		[AsyncStateMachine(typeof(CAKJNBOEGGO<>.BJHBCGCBOGK))]
		public override Task<HCGBMJDNFKJ<NLPIAAOFKEO<FGCGLNKNFGK>, CPMHOEMAGED>> GGAFGFDMLID(string GLGOHIJMLFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x63006D0", Offset = "0x62FEED0", VA = "0x1863006D0", Slot = "138")]
		public sealed override bool IKMKPJLKIHM(NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6300510", Offset = "0x62FED10", VA = "0x186300510", Slot = "126")]
		protected sealed override bool BHDLGPIADCK(NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6300770", Offset = "0x62FEF70", VA = "0x186300770", Slot = "127")]
		protected override bool MKEPFLKIPGH(NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6300400", Offset = "0x62FEC00", VA = "0x186300400", Slot = "115")]
		[AsyncStateMachine(typeof(CAKJNBOEGGO<>.FMPLIAOMFGA))]
		public override Task<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> AFNANOJHFNA(NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public sealed class IDCPEIAODPJ : NPDGDHKCCMH<FLCGMNFCPJA>
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private sealed class HLAHMIAPACB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public IDCPEIAODPJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public LNHBIEKMMIC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public HLAHMIAPACB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x2718110", Offset = "0x2716910", VA = "0x182718110")]
			internal bool NDLNCFEHFJN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x2718050", Offset = "0x2716850", VA = "0x182718050")]
			internal void DFBMIADMOCK(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x2718A10", Offset = "0x2717210", VA = "0x182718A10")]
		public IDCPEIAODPJ(CBFIFLFMBFP MPABKJPPPMM, FLCGMNFCPJA JLPKBNIJDEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x27187C0", Offset = "0x2716FC0", VA = "0x1827187C0", Slot = "140")]
		protected override void OLPANILNBFP(APKPIDOBEFA NBFCHNOPHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private sealed class KNCLPAEDKBI : BDPPJKIIHMO<NIIPODDJDFJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override NodeVisualizationKey FIEPPEJGGLF
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0xBCB360", Offset = "0xBC9B60", VA = "0x180BCB360", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x271B9A0", Offset = "0x271A1A0", VA = "0x18271B9A0")]
		public KNCLPAEDKBI(CBFIFLFMBFP MPABKJPPPMM, NIIPODDJDFJ GDFCBMOFMFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public abstract class BDPPJKIIHMO<TNode> : IJIPHCJMIJF<TNode> where TNode : notnull, OHNDAGGNNIA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct JMLOOALPGIF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public AsyncTaskMethodBuilder<HCGBMJDNFKJ<NLPIAAOFKEO<FGCGLNKNFGK>, CPMHOEMAGED>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public BDPPJKIIHMO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private TaskAwaiter<HCGBMJDNFKJ<NLPIAAOFKEO<FGCGLNKNFGK>, CPMHOEMAGED>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x4E2AFF0", Offset = "0x4E297F0", VA = "0x184E2AFF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x4E2B4A0", Offset = "0x4E29CA0", VA = "0x184E2B4A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private struct DDEMGFDBGBL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public AsyncTaskMethodBuilder<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public BDPPJKIIHMO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public NLPIAAOFKEO<FGCGLNKNFGK> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x68BFC70", Offset = "0x68BE470", VA = "0x1868BFC70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x68C00F0", Offset = "0x68BE8F0", VA = "0x1868C00F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private struct LIELMCPMEDG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public AsyncTaskMethodBuilder<HCGBMJDNFKJ<LLABCKEFCJH, CPMHOEMAGED>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public BDPPJKIIHMO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private TaskAwaiter<HCGBMJDNFKJ<LLABCKEFCJH, CPMHOEMAGED>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x4FDF5E0", Offset = "0x4FDDDE0", VA = "0x184FDF5E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x4FDFC90", Offset = "0x4FDE490", VA = "0x184FDFC90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[CompilerGenerated]
		private sealed class NJGNINOKGKO
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			private struct <<BuildConfigMenuInternal>b__7>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public NJGNINOKGKO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0x3FD0830", Offset = "0x3FCF030", VA = "0x183FD0830", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000175")]
				[Cpp2IlInjected.Address(RVA = "0xA2F200", Offset = "0xA2DA00", VA = "0x180A2F200", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public APKPIDOBEFA configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public LNHBIEKMMIC nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public BDPPJKIIHMO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public Func<string, bool> <>9__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public Action <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public NJGNINOKGKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x534BE30", Offset = "0x534A630", VA = "0x18534BE30")]
			internal bool IHKKLMAGGNF(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x534BF10", Offset = "0x534A710", VA = "0x18534BF10")]
			internal void KOACCBJHCAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x534C1E0", Offset = "0x534A9E0", VA = "0x18534C1E0")]
			[AsyncStateMachine(typeof(BDPPJKIIHMO<>.NJGNINOKGKO.<<BuildConfigMenuInternal>b__7>d))]
			internal void OFCNKEHMCIB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x534BA40", Offset = "0x534A240", VA = "0x18534BA40")]
			internal bool DAJNJOHEPHE()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[CompilerGenerated]
		private sealed class HFFOANPAJEG
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000057")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				public HFFOANPAJEG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				private TaskAwaiter<TaskStatus> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600017B")]
				[Cpp2IlInjected.Address(RVA = "0x3FD04C0", Offset = "0x3FCECC0", VA = "0x183FD04C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600017C")]
				[Cpp2IlInjected.Address(RVA = "0xA2F200", Offset = "0xA2DA00", VA = "0x180A2F200", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public string newFunctionName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public NJGNINOKGKO CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public Func<string> <>9__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public Action<string> <>9__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public Action <>9__5;

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public HFFOANPAJEG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x4A44BE0", Offset = "0x4A433E0", VA = "0x184A44BE0")]
			internal void LFCONHGLCKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
			internal string IHPGAMMHHFC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
			internal void FJIIPMHGAJJ(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x4A44F80", Offset = "0x4A43780", VA = "0x184A44F80")]
			[AsyncStateMachine(typeof(BDPPJKIIHMO<>.HFFOANPAJEG.<<BuildConfigMenuInternal>b__5>d))]
			internal void OJDBMGKIAGD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		[CompilerGenerated]
		private sealed class CLDNMEHJHLO
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000059")]
			private struct <<AddDynamicNodeGroupSettingV2>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010A")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010B")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010C")]
				public CLDNMEHJHLO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010D")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000190")]
				[Cpp2IlInjected.Address(RVA = "0x3FCFFF0", Offset = "0x3FCE7F0", VA = "0x183FCFFF0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000191")]
				[Cpp2IlInjected.Address(RVA = "0xA2F200", Offset = "0xA2DA00", VA = "0x180A2F200", Slot = "5")]
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
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				public CLDNMEHJHLO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				private TaskAwaiter<HCGBMJDNFKJ<NLPIAAOFKEO<IKLIGFGFCNJ>, CPMHOEMAGED>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000192")]
				[Cpp2IlInjected.Address(RVA = "0x3FD01D0", Offset = "0x3FCE9D0", VA = "0x183FD01D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000193")]
				[Cpp2IlInjected.Address(RVA = "0xA2F200", Offset = "0xA2DA00", VA = "0x180A2F200", Slot = "5")]
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
				[Cpp2IlInjected.Token(Token = "0x4000112")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000113")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000114")]
				public CLDNMEHJHLO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000115")]
				private TaskAwaiter<HCGBMJDNFKJ<NLPIAAOFKEO<GNIBIEHKAFH>, CPMHOEMAGED>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000194")]
				[Cpp2IlInjected.Address(RVA = "0x3FCF930", Offset = "0x3FCE130", VA = "0x183FCF930", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000195")]
				[Cpp2IlInjected.Address(RVA = "0xA2F200", Offset = "0xA2DA00", VA = "0x180A2F200", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public BDPPJKIIHMO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public NLPIAAOFKEO<FGCGLNKNFGK> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public APKPIDOBEFA configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public LNHBIEKMMIC nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public FGJEEAJAKCB nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public int minGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public int maxGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public MACFJNEIIPE selectedInputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public string newInputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public List<HDJDPBHABGL> inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public MACFJNEIIPE selectedOutputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public string newOutputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public List<HDJDPBHABGL> outputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public Func<string, bool> <>9__17;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public CLDNMEHJHLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x64D5230", Offset = "0x64D3A30", VA = "0x1864D5230")]
			internal bool ACCKMKLBBCO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x64D5A10", Offset = "0x64D4210", VA = "0x1864D5A10")]
			internal void NPHMFDAPBIN(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x64D5380", Offset = "0x64D3B80", VA = "0x1864D5380")]
			internal bool BKJPMKDJJLD(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x64D5340", Offset = "0x64D3B40", VA = "0x1864D5340")]
			internal bool ANLAKEOCPLB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x64D5460", Offset = "0x64D3C60", VA = "0x1864D5460")]
			[AsyncStateMachine(typeof(BDPPJKIIHMO<>.CLDNMEHJHLO.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void CMJNHDBOCJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x64D57A0", Offset = "0x64D3FA0", VA = "0x1864D57A0")]
			internal bool IKMELPDAHOI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x64D5560", Offset = "0x64D3D60", VA = "0x1864D5560")]
			internal void GLAPKPOAGBH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x64D58F0", Offset = "0x64D40F0", VA = "0x1864D58F0")]
			internal bool KBIEBPILFAB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x64D5170", Offset = "0x64D3970", VA = "0x1864D5170")]
			internal void AAHCJIPIIGB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x64D5840", Offset = "0x64D4040", VA = "0x1864D5840")]
			internal bool JJJNGJJGIJI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x64D5A80", Offset = "0x64D4280", VA = "0x1864D5A80")]
			internal bool PJMFJLNCNOF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x64D5690", Offset = "0x64D3E90", VA = "0x1864D5690")]
			internal void HDAHPKAFHFE(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x64D5700", Offset = "0x64D3F00", VA = "0x1864D5700")]
			[AsyncStateMachine(typeof(BDPPJKIIHMO<>.CLDNMEHJHLO.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void HMOELOKGGOD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x64D57E0", Offset = "0x64D3FE0", VA = "0x1864D57E0")]
			internal bool INFBLPPHFNC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x64D59A0", Offset = "0x64D41A0", VA = "0x1864D59A0")]
			internal bool MFCPBBMEIJC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x64D5620", Offset = "0x64D3E20", VA = "0x1864D5620")]
			internal void HCLEHMGLCCJ(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x64D52A0", Offset = "0x64D3AA0", VA = "0x1864D52A0")]
			[AsyncStateMachine(typeof(BDPPJKIIHMO<>.CLDNMEHJHLO.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void AJJOOAFGHDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x64D5500", Offset = "0x64D3D00", VA = "0x1864D5500")]
			internal bool DEDGPECEHBG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class NNABKAJGOIL
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005D")]
			private struct <<AddDynamicNodeGroupSettingV2>b__16>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011D")]
				public NNABKAJGOIL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011E")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011F")]
				private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x3FCFC20", Offset = "0x3FCE420", VA = "0x183FCFC20", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0xA2F200", Offset = "0xA2DA00", VA = "0x180A2F200", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public CLDNMEHJHLO CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public Func<string> <>9__14;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public Action<string> <>9__15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public Action <>9__16;

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public NNABKAJGOIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x5357630", Offset = "0x5355E30", VA = "0x185357630")]
			internal void OGKPLJFEOEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
			internal string BOOOPGIGHOL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
			internal void BKKEFGIMNHP(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x5357590", Offset = "0x5355D90", VA = "0x185357590")]
			[AsyncStateMachine(typeof(BDPPJKIIHMO<>.NNABKAJGOIL.<<AddDynamicNodeGroupSettingV2>b__16>d))]
			internal void LOCJOPNDLEC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		[CompilerGenerated]
		private sealed class FPLEPNNCAFL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public FGJEEAJAKCB nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public List<HDJDPBHABGL> portMenu;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public BDPPJKIIHMO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public NLPIAAOFKEO<FGCGLNKNFGK> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public int portCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public Func<bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public FPLEPNNCAFL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x48E8DA0", Offset = "0x48E75A0", VA = "0x1848E8DA0")]
			internal bool NHDKFKECNLM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class LLBGOJKJEPB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public IIGEGHJBEFA port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public FPLEPNNCAFL CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public LLBGOJKJEPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x5005F30", Offset = "0x5004730", VA = "0x185005F30")]
			internal void EIJEOCKOHBJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x50060A0", Offset = "0x50048A0", VA = "0x1850060A0")]
			internal bool LFNMEPOICFB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x5005E10", Offset = "0x5004610", VA = "0x185005E10")]
			internal void DJJBEGMOBBB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x5006040", Offset = "0x5004840", VA = "0x185006040")]
			internal bool ICJDABJMFIC()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000060")]
		[CompilerGenerated]
		private sealed class FNIINAMLEAB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public HDJDPBHABGL portControls;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public LLBGOJKJEPB CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public FNIINAMLEAB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x48E5130", Offset = "0x48E3930", VA = "0x1848E5130")]
			internal void HBOECEAFEAH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class EJJGEHKLKGA
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000062")]
			private struct <<CreatePortItemV2>b__3>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000133")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000134")]
				public EJJGEHKLKGA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000135")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000136")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000137")]
				private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0x3FD1C60", Offset = "0x3FD0460", VA = "0x183FD1C60", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0xA2F200", Offset = "0xA2DA00", VA = "0x180A2F200", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public List<object> allTypeObjects;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public MACFJNEIIPE selectedType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public FGJEEAJAKCB nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public IIGEGHJBEFA port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public LNHBIEKMMIC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public EJJGEHKLKGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x4404810", Offset = "0x4403010", VA = "0x184404810")]
			internal int GAKPPHIPFFG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x4404850", Offset = "0x4403050", VA = "0x184404850")]
			internal void IIELJEDIJCN(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0")]
			internal string EMDAHHNCKKC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x4404B80", Offset = "0x4403380", VA = "0x184404B80")]
			[AsyncStateMachine(typeof(BDPPJKIIHMO<>.EJJGEHKLKGA.<<CreatePortItemV2>b__3>d))]
			internal void OHONEPDKKOM(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x4404AA0", Offset = "0x44032A0", VA = "0x184404AA0")]
			internal bool MBAFAJJGBAA(string text)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly Dictionary<NLPIAAOFKEO<FGCGLNKNFGK>, bool> CEJOFOKCGLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly Dictionary<NLPIAAOFKEO<FGCGLNKNFGK>, bool> LFELFDNOBGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly Dictionary<NLPIAAOFKEO<FGCGLNKNFGK>, bool> NBGEOHHLECE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private Dictionary<NLPIAAOFKEO<FGCGLNKNFGK>, bool> KCLDNJMNAAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private Dictionary<NLPIAAOFKEO<FGCGLNKNFGK>, bool> HEJKLJGIGNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private Dictionary<NLPIAAOFKEO<FGCGLNKNFGK>, bool> PFJDCGCDOFH;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool OMOCHFFHAGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "136")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected virtual bool LLCLKFNGOKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		protected virtual bool IEBIJICPMBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "141")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		protected virtual bool BNDJLBFNKHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "142")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NLPIAAOFKEO<PAJOPNAJIFC>? CALGJHAFIJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x5DABEE0", Offset = "0x5DAA6E0", VA = "0x185DABEE0", Slot = "130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NLPIAAOFKEO<FGCGLNKNFGK>? ACNKDCGHPJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x5DAC190", Offset = "0x5DAA990", VA = "0x185DAC190", Slot = "133")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override IEnumerable<CMDPIJDKPHC<KGLBPIDLJAB>>? IOIDMNPDBJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x5DABF90", Offset = "0x5DAA790", VA = "0x185DABF90", Slot = "125")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5DABCC0", Offset = "0x5DAA4C0", VA = "0x185DABCC0")]
		public BDPPJKIIHMO(CBFIFLFMBFP MPABKJPPPMM, TNode GDFCBMOFMFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "143")]
		protected virtual bool DDCMDMHPBLG(int PGKIALDGAHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "144")]
		protected virtual bool JFEJMADBMPF(int PGKIALDGAHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "145")]
		protected virtual bool OMHKLGNOANN(int PGKIALDGAHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "146")]
		protected virtual void FOHMOLPDGPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8DE0", Offset = "0x5DA75E0", VA = "0x185DA8DE0", Slot = "138")]
		public override bool IKMKPJLKIHM(NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8AB0", Offset = "0x5DA72B0", VA = "0x185DA8AB0", Slot = "114")]
		[AsyncStateMachine(typeof(BDPPJKIIHMO<>.JMLOOALPGIF))]
		public override Task<HCGBMJDNFKJ<NLPIAAOFKEO<FGCGLNKNFGK>, CPMHOEMAGED>> GGAFGFDMLID(string GLGOHIJMLFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x5DA7370", Offset = "0x5DA5B70", VA = "0x185DA7370", Slot = "115")]
		[AsyncStateMachine(typeof(BDPPJKIIHMO<>.DDEMGFDBGBL))]
		public override Task<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> AFNANOJHFNA(NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8BD0", Offset = "0x5DA73D0", VA = "0x185DA8BD0", Slot = "116")]
		public override void GKBNAMALNPJ(NLPIAAOFKEO<FGCGLNKNFGK> FPEOONOJHML, NLPIAAOFKEO<FGCGLNKNFGK> ALLFIKNKLHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5DA7480", Offset = "0x5DA5C80", VA = "0x185DA7480", Slot = "117")]
		public override IEnumerable<IOPMFGMDJPO> AJGDNKMCMJG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5DAB940", Offset = "0x5DAA140", VA = "0x185DAB940")]
		[AsyncStateMachine(typeof(BDPPJKIIHMO<>.LIELMCPMEDG))]
		private Task<HCGBMJDNFKJ<LLABCKEFCJH, CPMHOEMAGED>> PFOKGJNACBP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "147")]
		protected virtual bool KIJKAIBHOOK(NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "148")]
		protected virtual bool ENENCBLBKCE(NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "149")]
		protected virtual bool MECDFJIKIAL(NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "150")]
		protected virtual bool BGPBHJGHCJB(NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "151")]
		protected virtual bool GDBEEDPJGPH(NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM, int GMCEBJMCMHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "152")]
		protected virtual bool PJMGEOBLMED(NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM, int GMCEBJMCMHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "153")]
		protected virtual bool MCJDPKFMPEA(NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM, int FDNENPJLAIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "154")]
		protected virtual bool ECFJCFDMIOE(NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM, int FDNENPJLAIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "155")]
		protected virtual bool MBHPKEOIJED(NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM, int KFAILCHCEPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "156")]
		protected virtual bool BNIAPNOFBFF(NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM, int ANCLACDALFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x5DA76E0", Offset = "0x5DA5EE0", VA = "0x185DA76E0", Slot = "157")]
		protected virtual List<MACFJNEIIPE> EEDOGGKLDDI(NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "158")]
		protected virtual void DKPFDPFBNDK(APKPIDOBEFA NBFCHNOPHLL, FOEMNLENBGB GMBBBGIAKBA, FGJEEAJAKCB MJCALJHCJFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8E80", Offset = "0x5DA7680", VA = "0x185DA8E80", Slot = "134")]
		protected override void KCBBIJPOMMB(APKPIDOBEFA NBFCHNOPHLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x5DA98E0", Offset = "0x5DA80E0", VA = "0x185DA98E0")]
		private FOEMNLENBGB LKOADFJNPJD(APKPIDOBEFA NBFCHNOPHLL, FGJEEAJAKCB MJCALJHCJFD, NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x5DA7980", Offset = "0x5DA6180", VA = "0x185DA7980")]
		private List<HDJDPBHABGL> EMNNFFJHBLH(APKPIDOBEFA NBFCHNOPHLL, FGJEEAJAKCB MJCALJHCJFD, FOEMNLENBGB CIKCABHNAFI, bool FDHEHNFLELM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x5DAB000", Offset = "0x5DA9800", VA = "0x185DAB000")]
		private List<HDJDPBHABGL> NMGMIKCBNCM(APKPIDOBEFA NBFCHNOPHLL, FGJEEAJAKCB MJCALJHCJFD, IIGEGHJBEFA IFDAMJHJJPI, bool FDHEHNFLELM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x5DABAD0", Offset = "0x5DAA2D0", VA = "0x185DABAD0")]
		private MACFJNEIIPE PLJFDIIHJCL(List<MACFJNEIIPE> OIEAMODABFG, IIGEGHJBEFA IFDAMJHJJPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x5DABA40", Offset = "0x5DAA240", VA = "0x185DABA40")]
		[CompilerGenerated]
		private IOPMFGMDJPO PLIDEHEBPOI(BKBACPLKPAP JEGIFICJAGL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class GONOCMLCHNB : IJIPHCJMIJF<CBNGALLIELN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class CJDMHFHIIHH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public GONOCMLCHNB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public LNHBIEKMMIC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public CJDMHFHIIHH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x270F480", Offset = "0x270DC80", VA = "0x18270F480")]
			internal int KOACCBJHCAE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x270F3F0", Offset = "0x270DBF0", VA = "0x18270F3F0")]
			internal void DAJNJOHEPHE(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey FIEPPEJGGLF
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x10883D0", Offset = "0x1086BD0", VA = "0x1810883D0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x2717150", Offset = "0x2715950", VA = "0x182717150")]
		public GONOCMLCHNB(CBFIFLFMBFP MPABKJPPPMM, CBNGALLIELN GDFCBMOFMFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x2716F90", Offset = "0x2715790", VA = "0x182716F90", Slot = "134")]
		protected override void KCBBIJPOMMB(APKPIDOBEFA NBFCHNOPHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public sealed class MNKBCICMGKL : NPDGDHKCCMH<NDPHGAPGPDI>
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class AFMAJFOFBMI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public MNKBCICMGKL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public LNHBIEKMMIC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public AFMAJFOFBMI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x270DB60", Offset = "0x270C360", VA = "0x18270DB60")]
			internal int NDLNCFEHFJN()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x270DAC0", Offset = "0x270C2C0", VA = "0x18270DAC0")]
			internal void DFBMIADMOCK(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x271D710", Offset = "0x271BF10", VA = "0x18271D710")]
		public MNKBCICMGKL(CBFIFLFMBFP MPABKJPPPMM, NDPHGAPGPDI JLPKBNIJDEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x271D4D0", Offset = "0x271BCD0", VA = "0x18271D4D0", Slot = "140")]
		protected override void OLPANILNBFP(APKPIDOBEFA NBFCHNOPHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private sealed class BPFHAKAEGOH : IJIPHCJMIJF<HNFEGPNAJOJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey FIEPPEJGGLF
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xD65C90", Offset = "0xD64490", VA = "0x180D65C90", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x270DC40", Offset = "0x270C440", VA = "0x18270DC40")]
		public BPFHAKAEGOH(CBFIFLFMBFP MPABKJPPPMM, HNFEGPNAJOJ GDFCBMOFMFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "134")]
		protected override void KCBBIJPOMMB(APKPIDOBEFA NBFCHNOPHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class IKNPCAHBHHE : IJIPHCJMIJF<INAEBEILIFK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class ABMMBCMMCPC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public IKNPCAHBHHE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public APKPIDOBEFA configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public Func<string> <>9__224;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Action<string> <>9__225;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Func<int> <>9__228;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Action<int> <>9__229;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Func<bool> <>9__230;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Func<bool> <>9__231;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<bool> <>9__232;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Func<float> <>9__233;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Action<float> <>9__234;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public Func<bool> <>9__235;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public Func<bool> <>9__236;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public Func<bool> <>9__237;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public Func<string> <>9__238;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public Action<string> <>9__239;

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public ABMMBCMMCPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x270BF90", Offset = "0x270A790", VA = "0x18270BF90")]
			internal bool KOACCBJHCAE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x2703610", Offset = "0x2701E10", VA = "0x182703610")]
			internal void DAJNJOHEPHE(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x2704020", Offset = "0x2702820", VA = "0x182704020")]
			internal bool FJIIPMHGAJJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x270D0D0", Offset = "0x270B8D0", VA = "0x18270D0D0")]
			internal bool OJDBMGKIAGD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x270B040", Offset = "0x2709840", VA = "0x18270B040")]
			internal void IHKKLMAGGNF(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x270C3F0", Offset = "0x270ABF0", VA = "0x18270C3F0")]
			internal bool MCLHFKLBCLH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x2703B10", Offset = "0x2702310", VA = "0x182703B10")]
			internal bool EJJCJJJIPID()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x270C7D0", Offset = "0x270AFD0", VA = "0x18270C7D0")]
			internal void MNINOENIMMK(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x270AAA0", Offset = "0x27092A0", VA = "0x18270AAA0")]
			internal bool HLABILHBCKE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x2702D20", Offset = "0x2701520", VA = "0x182702D20")]
			internal bool AJGACFDMBHM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x270CF20", Offset = "0x270B720", VA = "0x18270CF20")]
			internal void OBHCJMCICCO(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x270D020", Offset = "0x270B820", VA = "0x18270D020")]
			internal bool OGJCMENCDCI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x270BF40", Offset = "0x270A740", VA = "0x18270BF40")]
			internal bool KNOECNNPMGI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x270CAE0", Offset = "0x270B2E0", VA = "0x18270CAE0")]
			internal bool NFEFMBLAILJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x270CC40", Offset = "0x270B440", VA = "0x18270CC40")]
			internal bool NLAMMGNPLLI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x2702FD0", Offset = "0x27017D0", VA = "0x182702FD0")]
			internal bool BBAACBAPIEB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x270D420", Offset = "0x270BC20", VA = "0x18270D420")]
			internal bool PAIKCGIBMHO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x2703970", Offset = "0x2702170", VA = "0x182703970")]
			internal bool EAHKALNHDIJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x270CC90", Offset = "0x270B490", VA = "0x18270CC90")]
			internal bool NLPOBFACMJN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x2703D90", Offset = "0x2702590", VA = "0x182703D90")]
			internal bool FCFGHDNHGBN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x2702DC0", Offset = "0x27015C0", VA = "0x182702DC0")]
			internal void AMBJPNIMEMJ(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x270CA40", Offset = "0x270B240", VA = "0x18270CA40")]
			internal bool NEJCEHPHLLN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x27034D0", Offset = "0x2701CD0", VA = "0x1827034D0")]
			internal bool CLPHPJFKPEH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x270C300", Offset = "0x270AB00", VA = "0x18270C300")]
			internal bool LJDMMLLPKHM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x270CF80", Offset = "0x270B780", VA = "0x18270CF80")]
			internal bool OCKFPHKPDLF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x270D6F0", Offset = "0x270BEF0", VA = "0x18270D6F0")]
			internal bool PLAFNNJIKON()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x2703390", Offset = "0x2701B90", VA = "0x182703390")]
			internal bool CANOMEMNDBM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x2703820", Offset = "0x2702020", VA = "0x182703820")]
			internal bool DKFJKIACMID()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x270CD30", Offset = "0x270B530", VA = "0x18270CD30")]
			internal bool NNNLDBCONHO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x27038C0", Offset = "0x27020C0", VA = "0x1827038C0")]
			internal void DPENGLKEDAI(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x2704110", Offset = "0x2702910", VA = "0x182704110")]
			internal bool FNBENHDCOCE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x270C0D0", Offset = "0x270A8D0", VA = "0x18270C0D0")]
			internal bool LDCCCDINBGP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x270B460", Offset = "0x2709C60", VA = "0x18270B460")]
			internal void JLGGNGNFNKG(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x270ACB0", Offset = "0x27094B0", VA = "0x18270ACB0")]
			internal bool HOGHEFPEFLM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x270D310", Offset = "0x270BB10", VA = "0x18270D310")]
			internal bool ONOMFONNNGO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x2702F70", Offset = "0x2701770", VA = "0x182702F70")]
			internal void APOBOFHPMNP(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x27045D0", Offset = "0x2702DD0", VA = "0x1827045D0")]
			internal List<HDJDPBHABGL> GKMNCMGMHKO(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x2704530", Offset = "0x2702D30", VA = "0x182704530")]
			internal bool GFLMPNEDMAB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x270A700", Offset = "0x2708F00", VA = "0x18270A700")]
			internal int GOBPKMKGHHD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x2703D30", Offset = "0x2702530", VA = "0x182703D30")]
			internal void FBBKGAFMLLH(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x2702C10", Offset = "0x2701410", VA = "0x182702C10")]
			internal bool AFNHMBIAEEK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x2703CE0", Offset = "0x27024E0", VA = "0x182703CE0")]
			internal bool FAENFAELMKA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x270A960", Offset = "0x2709160", VA = "0x18270A960")]
			internal bool HGAKNALGPGL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x270AFF0", Offset = "0x27097F0", VA = "0x18270AFF0")]
			internal int IFEGCPEEIKE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x2703A60", Offset = "0x2702260", VA = "0x182703A60")]
			internal void EHBHPHCBIFO(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x270B350", Offset = "0x2709B50", VA = "0x18270B350")]
			internal bool JJPDNCNEJAM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x270C120", Offset = "0x270A920", VA = "0x18270C120")]
			internal bool LDFBBELMJAN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x270B190", Offset = "0x2709990", VA = "0x18270B190")]
			internal bool ILOFLAAKAGI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x270AF50", Offset = "0x2709750", VA = "0x18270AF50")]
			internal bool IDLINCMFEAK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x27033E0", Offset = "0x2701BE0", VA = "0x1827033E0")]
			internal bool CDBNMBJMENA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x270C6E0", Offset = "0x270AEE0", VA = "0x18270C6E0")]
			internal bool MKCFINEGMFF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x2703C00", Offset = "0x2702400", VA = "0x182703C00")]
			internal string EMKAOPPJIDF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x270B3A0", Offset = "0x2709BA0", VA = "0x18270B3A0")]
			internal void JKLEIKPALPD(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x270A5F0", Offset = "0x2708DF0", VA = "0x18270A5F0")]
			internal int GLNGKOJFCKO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x2702E70", Offset = "0x2701670", VA = "0x182702E70")]
			internal void APIBCMDOCPI(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x270C690", Offset = "0x270AE90", VA = "0x18270C690")]
			internal bool MIGGLDFDKLI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x27036C0", Offset = "0x2701EC0", VA = "0x1827036C0")]
			internal bool DHFICEOPMMC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x270C4E0", Offset = "0x270ACE0", VA = "0x18270C4E0")]
			internal bool MEIPAMEJDBJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x2704580", Offset = "0x2702D80", VA = "0x182704580")]
			internal float GHPGKGENHCB()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x2704360", Offset = "0x2702B60", VA = "0x182704360")]
			internal void GBBEPNCELDI(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x270A9B0", Offset = "0x27091B0", VA = "0x18270A9B0")]
			internal bool HGHNCACEJHO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x27040C0", Offset = "0x27028C0", VA = "0x1827040C0")]
			internal bool FMOCCHIAKPB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x270C950", Offset = "0x270B150", VA = "0x18270C950")]
			internal bool NAOHKIPGKGF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x270CFD0", Offset = "0x270B7D0", VA = "0x18270CFD0")]
			internal bool OCKOOANGJCF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x270D5B0", Offset = "0x270BDB0", VA = "0x18270D5B0")]
			internal bool PEJPBEGAKIA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x2704070", Offset = "0x2702870", VA = "0x182704070")]
			internal bool FKIOLJPMIBC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x270B6C0", Offset = "0x2709EC0", VA = "0x18270B6C0")]
			internal void KCOLGNLKCGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x270A750", Offset = "0x2708F50", VA = "0x18270A750")]
			internal string GPADHGBMDAE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x270CB80", Offset = "0x270B380", VA = "0x18270CB80")]
			internal void NFMIJJFKMPE(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x27035C0", Offset = "0x2701DC0", VA = "0x1827035C0")]
			internal bool DACOJJAOPFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x2703710", Offset = "0x2701F10", VA = "0x182703710")]
			internal bool DJGGADNNNHJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x2703F80", Offset = "0x2702780", VA = "0x182703F80")]
			internal bool FFOMGCHFOHC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x270BC30", Offset = "0x270A430", VA = "0x18270BC30")]
			internal void KLNDJJIPDGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x270D250", Offset = "0x270BA50", VA = "0x18270D250")]
			internal bool ONFPLKEODFJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x270B300", Offset = "0x2709B00", VA = "0x18270B300")]
			internal bool JIECAMFIMCF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x270BFE0", Offset = "0x270A7E0", VA = "0x18270BFE0")]
			internal bool KOFMKCFHOOK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x270D360", Offset = "0x270BB60", VA = "0x18270D360")]
			internal bool OPJJDJBIOAO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x2702B60", Offset = "0x2701360", VA = "0x182702B60")]
			internal void AEONKAHALAC(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x2702D70", Offset = "0x2701570", VA = "0x182702D70")]
			internal bool ALEHGPDKNCN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x270BEF0", Offset = "0x270A6F0", VA = "0x18270BEF0")]
			internal bool KNEIMNPIKNE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x270C9A0", Offset = "0x270B1A0", VA = "0x18270C9A0")]
			internal bool NBHODGIDNNJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x2703920", Offset = "0x2702120", VA = "0x182703920")]
			internal bool DPJDFBAAGFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x270D070", Offset = "0x270B870", VA = "0x18270D070")]
			internal void OHHHEIBIJIG(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x270C030", Offset = "0x270A830", VA = "0x18270C030")]
			internal bool KOPHAGMEPLD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x270B4C0", Offset = "0x2709CC0", VA = "0x18270B4C0")]
			internal bool JMKEHPCAAAJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x270D1B0", Offset = "0x270B9B0", VA = "0x18270D1B0")]
			internal bool OLGFFGHHECB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x270CBF0", Offset = "0x270B3F0", VA = "0x18270CBF0")]
			internal bool NIPCBJKCPAN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x270C8E0", Offset = "0x270B0E0", VA = "0x18270C8E0")]
			internal object MPMLPKNKAHC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x2703C50", Offset = "0x2702450", VA = "0x182703C50")]
			internal void ENBICFEEGAF(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x2703430", Offset = "0x2701C30", VA = "0x182703430")]
			internal bool CFNHEILCNIO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x270D740", Offset = "0x270BF40", VA = "0x18270D740")]
			internal bool PLINLEFNAPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x27032A0", Offset = "0x2701AA0", VA = "0x1827032A0")]
			internal int BLOBJAMHKBO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x2703ED0", Offset = "0x27026D0", VA = "0x182703ED0")]
			internal void FEBHAFPPDEE(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x27032F0", Offset = "0x2701AF0", VA = "0x1827032F0")]
			internal bool BOFFLCHJACJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x270AEB0", Offset = "0x27096B0", VA = "0x18270AEB0")]
			internal bool ICEMPHHNMCD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x2703520", Offset = "0x2701D20", VA = "0x182703520")]
			internal int CNMJMAGFJHJ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x270B610", Offset = "0x2709E10", VA = "0x18270B610")]
			internal void KCKCLNOGPBK(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x270C890", Offset = "0x270B090", VA = "0x18270C890")]
			internal bool MOAHHFHMNPB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x2703A10", Offset = "0x2702210", VA = "0x182703A10")]
			internal bool EFMDKBFHOCL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x2702BC0", Offset = "0x27013C0", VA = "0x182702BC0")]
			internal bool AEPFMMIIFLH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x270C350", Offset = "0x270AB50", VA = "0x18270C350")]
			internal int LKDPIDFMECM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x270B1E0", Offset = "0x27099E0", VA = "0x18270B1E0")]
			internal void JDHNLJMAJBG(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x270D560", Offset = "0x270BD60", VA = "0x18270D560")]
			internal bool PDNEKLPJBCG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x2703570", Offset = "0x2701D70", VA = "0x182703570")]
			internal bool DACAHEADEJM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x270B2B0", Offset = "0x2709AB0", VA = "0x18270B2B0")]
			internal bool JHCOCEJNBPG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x270ADF0", Offset = "0x27095F0", VA = "0x18270ADF0")]
			internal object IBNCPMHFFBC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x270D120", Offset = "0x270B920", VA = "0x18270D120")]
			internal void OJNNGIELBKI(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x2703670", Offset = "0x2701E70", VA = "0x182703670")]
			internal bool DGJEPPIHCOG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x2703FD0", Offset = "0x27027D0", VA = "0x182703FD0")]
			internal bool FJHGOMAJJPG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x270BB70", Offset = "0x270A370", VA = "0x18270BB70")]
			internal object KGICAMGFBPE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x270A860", Offset = "0x2709060", VA = "0x18270A860")]
			internal void HBBMCCIBJED(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x270C080", Offset = "0x270A880", VA = "0x18270C080")]
			internal bool LBOKGKHDECP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x2703B60", Offset = "0x2702360", VA = "0x182703B60")]
			internal int EJOBPNNNLGH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x270B510", Offset = "0x2709D10", VA = "0x18270B510")]
			internal void JMOGOINNBAK(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x2702C60", Offset = "0x2701460", VA = "0x182702C60")]
			internal bool AGBFLJNJPAH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x270AE60", Offset = "0x2709660", VA = "0x18270AE60")]
			internal bool IBPEKBBFLNG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x27042C0", Offset = "0x2702AC0", VA = "0x1827042C0")]
			internal bool GABAMGOGGNG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x270B140", Offset = "0x2709940", VA = "0x18270B140")]
			internal int IKGGIKPBBFM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x270C830", Offset = "0x270B030", VA = "0x18270C830")]
			internal void MNPEPBOIBLH(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x270C3A0", Offset = "0x270ABA0", VA = "0x18270C3A0")]
			internal bool LOLAFOMELPL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x27039C0", Offset = "0x27021C0", VA = "0x1827039C0")]
			internal bool EDOPAKGGMEI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x270C780", Offset = "0x270AF80", VA = "0x18270C780")]
			internal bool MNECCBAFPKA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x270C1C0", Offset = "0x270A9C0", VA = "0x18270C1C0")]
			internal float LGLIGANMEID()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x270CE70", Offset = "0x270B670", VA = "0x18270CE70")]
			internal void OBDFPPEJEGL(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x270C730", Offset = "0x270AF30", VA = "0x18270C730")]
			internal bool MLHOHMDACOA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x270AA00", Offset = "0x2709200", VA = "0x18270AA00")]
			internal bool HJHLMAGKBKK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x27031B0", Offset = "0x27019B0", VA = "0x1827031B0")]
			internal bool BGHOAGEAPND()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x270C440", Offset = "0x270AC40", VA = "0x18270C440")]
			internal float MCPOBAPMAOL()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x27044D0", Offset = "0x2702CD0", VA = "0x1827044D0")]
			internal void GENJOFJHHHD(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x2703E80", Offset = "0x2702680", VA = "0x182703E80")]
			internal bool FDKEJEPCPDM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x2704160", Offset = "0x2702960", VA = "0x182704160")]
			internal bool FOFMLADDGMF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x270C2B0", Offset = "0x270AAB0", VA = "0x18270C2B0")]
			internal string LIHHBPCFLAC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x27037B0", Offset = "0x2701FB0", VA = "0x1827037B0")]
			internal void DJLDNGJCDDG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x2703F30", Offset = "0x2702730", VA = "0x182703F30")]
			internal bool FEGKNHEDILA(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x2703760", Offset = "0x2701F60", VA = "0x182703760")]
			internal bool DJIHMAMPMPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x2703160", Offset = "0x2701960", VA = "0x182703160")]
			internal bool BFMAKPDEAJC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x270AC60", Offset = "0x2709460", VA = "0x18270AC60")]
			internal bool HOBODLOEEJP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x2703070", Offset = "0x2701870", VA = "0x182703070")]
			internal string BBGIKHNPPBF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x270A690", Offset = "0x2708E90", VA = "0x18270A690")]
			internal void GNDCLJFCLLO(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x270A640", Offset = "0x2708E40", VA = "0x18270A640")]
			internal bool GMENLDDMGIO(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x2704410", Offset = "0x2702C10", VA = "0x182704410")]
			internal bool GBOFFGMLLCH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x270C490", Offset = "0x270AC90", VA = "0x18270C490")]
			internal bool MDDOEFEGLEF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x2704310", Offset = "0x2702B10", VA = "0x182704310")]
			internal bool GAFOOBLOKKK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x270D510", Offset = "0x270BD10", VA = "0x18270D510")]
			internal string PDJLDJLOBOI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x2704250", Offset = "0x2702A50", VA = "0x182704250")]
			internal void FPGMNPHIEHB(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x270ADA0", Offset = "0x27095A0", VA = "0x18270ADA0")]
			internal bool IBGIDKOILFA(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x270CCE0", Offset = "0x270B4E0", VA = "0x18270CCE0")]
			internal bool NMADIJIAODO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x27041B0", Offset = "0x27029B0", VA = "0x1827041B0")]
			internal bool FOPIMJIIDKI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x2703E30", Offset = "0x2702630", VA = "0x182703E30")]
			internal bool FDFOLLCPMBG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x270D650", Offset = "0x270BE50", VA = "0x18270D650")]
			internal string PJKAPKKGIHI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x270AAF0", Offset = "0x27092F0", VA = "0x18270AAF0")]
			internal void HLDGBOEFPPI(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x270D470", Offset = "0x270BC70", VA = "0x18270D470")]
			internal bool PDFMGILHDEI(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x270CD80", Offset = "0x270B580", VA = "0x18270CD80")]
			internal bool NPAGIKHMBFB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x270C580", Offset = "0x270AD80", VA = "0x18270C580")]
			internal bool MFHHMNHDBBL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x2703110", Offset = "0x2701910", VA = "0x182703110")]
			internal bool BDLFBJGOLLD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x270CB30", Offset = "0x270B330", VA = "0x18270CB30")]
			internal string NFJOIGHHCLM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x2702CB0", Offset = "0x27014B0", VA = "0x182702CB0")]
			internal void AGOLDALGEDF(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x270A7A0", Offset = "0x2708FA0", VA = "0x18270A7A0")]
			internal bool HANMHIKALKM(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x270CDD0", Offset = "0x270B5D0", VA = "0x18270CDD0")]
			internal bool NPGCLMPCPBA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x2702E20", Offset = "0x2701620", VA = "0x182702E20")]
			internal bool ANHINPOMAGG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x2704200", Offset = "0x2702A00", VA = "0x182704200")]
			internal bool FPGCCPPADLH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x27030C0", Offset = "0x27018C0", VA = "0x1827030C0")]
			internal string BCKJGGADHIK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x270BB00", Offset = "0x270A300", VA = "0x18270BB00")]
			internal void KDKAALPCKGL(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x2703480", Offset = "0x2701C80", VA = "0x182703480")]
			internal bool CHHPMFJPFEK(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x270B0A0", Offset = "0x27098A0", VA = "0x18270B0A0")]
			internal bool IIEMBLHJFHJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x2702A10", Offset = "0x2701210", VA = "0x182702A10")]
			internal bool AABICMPOPCP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x270CA90", Offset = "0x270B290", VA = "0x18270CA90")]
			internal bool NEJOPHJFBBA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x270C530", Offset = "0x270AD30", VA = "0x18270C530")]
			internal string MENGIGABDGG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x270D3B0", Offset = "0x270BBB0", VA = "0x18270D3B0")]
			internal void OPPIEONCIOD(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x270CE20", Offset = "0x270B620", VA = "0x18270CE20")]
			internal bool OANJCFAMCKC(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x270C5D0", Offset = "0x270ADD0", VA = "0x18270C5D0")]
			internal bool MGDPMBGPIEO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x270B5C0", Offset = "0x2709DC0", VA = "0x18270B5C0")]
			internal bool JOJNCBHBLDH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x270AB60", Offset = "0x2709360", VA = "0x18270AB60")]
			internal bool HLLIDACNMFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x2703BB0", Offset = "0x27023B0", VA = "0x182703BB0")]
			internal string EKACCEIJAGA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x270D2A0", Offset = "0x270BAA0", VA = "0x18270D2A0")]
			internal void ONLJKEGPGNK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x270AF00", Offset = "0x2709700", VA = "0x18270AF00")]
			internal bool IDIHNHNCHFL(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x2702ED0", Offset = "0x27016D0", VA = "0x182702ED0")]
			internal bool APKDJDCBFEC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x2702F20", Offset = "0x2701720", VA = "0x182702F20")]
			internal bool APNEODEALON()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x270D4C0", Offset = "0x270BCC0", VA = "0x18270D4C0")]
			internal bool PDGBANGIPLK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x2703200", Offset = "0x2701A00", VA = "0x182703200")]
			internal string BIGIDDNNKFH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x2704460", Offset = "0x2702C60", VA = "0x182704460")]
			internal void GDKGGCLPLDK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x270C210", Offset = "0x270AA10", VA = "0x18270C210")]
			internal bool LHFCJEOKCHH(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x270AC10", Offset = "0x2709410", VA = "0x18270AC10")]
			internal bool HNLHIHBMKDI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x270C170", Offset = "0x270A970", VA = "0x18270C170")]
			internal bool LDIFPFDLJDD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x270AFA0", Offset = "0x27097A0", VA = "0x18270AFA0")]
			internal bool IFDBNHCPPAJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x270CED0", Offset = "0x270B6D0", VA = "0x18270CED0")]
			internal string OBDIKDCFBBA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x270A8F0", Offset = "0x27090F0", VA = "0x18270A8F0")]
			internal void HEEMPJLEDKD(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x270C260", Offset = "0x270AA60", VA = "0x18270C260")]
			internal bool LIBHKBCANID()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x27043C0", Offset = "0x2702BC0", VA = "0x1827043C0")]
			internal bool GBMPCHLJGIG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x270AD00", Offset = "0x2709500", VA = "0x18270AD00")]
			internal bool HPCHMAOOCCC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x270B410", Offset = "0x2709C10", VA = "0x18270B410")]
			internal string JKLNHEMOPKI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x270B240", Offset = "0x2709A40", VA = "0x18270B240")]
			internal void JFJGPBEIFLO(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x2703DE0", Offset = "0x27025E0", VA = "0x182703DE0")]
			internal bool FCJFEKLLOGK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x2703870", Offset = "0x2702070", VA = "0x182703870")]
			internal bool DKGDFBJMONH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x270D600", Offset = "0x270BE00", VA = "0x18270D600")]
			internal bool PGCAEIIMNOB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x270B670", Offset = "0x2709E70", VA = "0x18270B670")]
			internal string KCOFPKCPIJC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x270C620", Offset = "0x270AE20", VA = "0x18270C620")]
			internal void MGNNLOAILOG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x2702B10", Offset = "0x2701310", VA = "0x182702B10")]
			internal bool AEHPEEDMHFD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x270BBE0", Offset = "0x270A3E0", VA = "0x18270BBE0")]
			internal bool KIAHJAKIFDE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x270B570", Offset = "0x2709D70", VA = "0x18270B570")]
			internal bool JOCBKABGIBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x270C9F0", Offset = "0x270B1F0", VA = "0x18270C9F0")]
			internal string NCNHPJGDKMH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x270A7F0", Offset = "0x2708FF0", VA = "0x18270A7F0")]
			internal void HAOKALKNKLL(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x270D6A0", Offset = "0x270BEA0", VA = "0x18270D6A0")]
			internal bool PKMBLMIMGHP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x2703AC0", Offset = "0x27022C0", VA = "0x182703AC0")]
			internal bool EJEBJPLGJMF(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x2703250", Offset = "0x2701A50", VA = "0x182703250")]
			internal float BIHLHEPMLKN()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x2702A60", Offset = "0x2701260", VA = "0x182702A60")]
			internal void AAOGPGLPJKJ(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x270AD50", Offset = "0x2709550", VA = "0x18270AD50")]
			internal bool IALKFIOJPIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x2703340", Offset = "0x2701B40", VA = "0x182703340")]
			internal bool CAMGGNOBKKC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x270B0F0", Offset = "0x27098F0", VA = "0x18270B0F0")]
			internal bool IIFHNICGGEC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x270D200", Offset = "0x270BA00", VA = "0x18270D200")]
			internal int OLGGDGGMDPH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x270ABB0", Offset = "0x27093B0", VA = "0x18270ABB0")]
			internal void HNJKONOCMBD(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x2702AC0", Offset = "0x27012C0", VA = "0x182702AC0")]
			internal bool ADKKDBDGEIM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x270AA50", Offset = "0x2709250", VA = "0x18270AA50")]
			internal bool HKBDMCNHLJE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0x2703020", Offset = "0x2701820", VA = "0x182703020")]
			internal bool BBEPPIABLHO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class DALFNGAJDAH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public ABMMBCMMCPC CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public DALFNGAJDAH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x272C610", Offset = "0x272AE10", VA = "0x18272C610")]
			internal void FJNNMFDLNDK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class EFNGHENCAHP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public EFNGHENCAHP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x272DAD0", Offset = "0x272C2D0", VA = "0x18272DAD0")]
			internal bool DLOBCGPAMMB(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private readonly LEJEKGLGKAJ PELJFHAIADG;

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x271A970", Offset = "0x2719170", VA = "0x18271A970")]
		public IKNPCAHBHHE(CBFIFLFMBFP MPABKJPPPMM, INAEBEILIFK GDFCBMOFMFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2718C40", Offset = "0x2717440", VA = "0x182718C40", Slot = "134")]
		protected override void KCBBIJPOMMB(APKPIDOBEFA NBFCHNOPHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public sealed class MBAPPJDIDEN : IJIPHCJMIJF<ANJKNNDNEDO>
	{
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private sealed class OLOEMLMCBIK
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006F")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400017B")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400017C")]
				public OLOEMLMCBIK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002CA")]
				[Cpp2IlInjected.Address(RVA = "0x273E900", Offset = "0x273D100", VA = "0x18273E900", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002CB")]
				[Cpp2IlInjected.Address(RVA = "0xA2F200", Offset = "0xA2DA00", VA = "0x180A2F200", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public MBAPPJDIDEN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public LNHBIEKMMIC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public OLOEMLMCBIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x273D2F0", Offset = "0x273BAF0", VA = "0x18273D2F0")]
			internal string KOACCBJHCAE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x273D190", Offset = "0x273B990", VA = "0x18273D190")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void DAJNJOHEPHE(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x273D340", Offset = "0x273BB40", VA = "0x18273D340")]
			internal int LFCONHGLCKD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x273D260", Offset = "0x273BA60", VA = "0x18273D260")]
			internal void IHPGAMMHHFC(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey FIEPPEJGGLF
		{
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x10883D0", Offset = "0x1086BD0", VA = "0x1810883D0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x2734720", Offset = "0x2732F20", VA = "0x182734720")]
		public MBAPPJDIDEN(CBFIFLFMBFP MPABKJPPPMM, ANJKNNDNEDO JLPKBNIJDEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x27343C0", Offset = "0x2732BC0", VA = "0x1827343C0", Slot = "134")]
		protected override void KCBBIJPOMMB(APKPIDOBEFA NBFCHNOPHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public sealed class AIPDNNKFBLL : IJIPHCJMIJF<KJIFHPMLLKB>
	{
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private sealed class ICJFONEOEJI
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000072")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000182")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000183")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000184")]
				public ICJFONEOEJI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000185")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002DF")]
				[Cpp2IlInjected.Address(RVA = "0x273E5C0", Offset = "0x273CDC0", VA = "0x18273E5C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E0")]
				[Cpp2IlInjected.Address(RVA = "0xA2F200", Offset = "0xA2DA00", VA = "0x180A2F200", Slot = "5")]
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
				[Cpp2IlInjected.Token(Token = "0x4000188")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000189")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400018A")]
				public ICJFONEOEJI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400018B")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400018C")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400018D")]
				private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002E1")]
				[Cpp2IlInjected.Address(RVA = "0x273EC10", Offset = "0x273D410", VA = "0x18273EC10", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E2")]
				[Cpp2IlInjected.Address(RVA = "0xA2F200", Offset = "0xA2DA00", VA = "0x180A2F200", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public AIPDNNKFBLL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public LNHBIEKMMIC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public ICJFONEOEJI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x2732C20", Offset = "0x2731420", VA = "0x182732C20")]
			internal string KOACCBJHCAE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x2732900", Offset = "0x2731100", VA = "0x182732900")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void DAJNJOHEPHE(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x2732C70", Offset = "0x2731470", VA = "0x182732C70")]
			internal int LFCONHGLCKD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x2732B90", Offset = "0x2731390", VA = "0x182732B90")]
			internal void IHPGAMMHHFC(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x2732A20", Offset = "0x2731220", VA = "0x182732A20")]
			internal string FJIIPMHGAJJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x2732EC0", Offset = "0x27316C0", VA = "0x182732EC0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void OJDBMGKIAGD(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x2732B40", Offset = "0x2731340", VA = "0x182732B40")]
			internal bool IHKKLMAGGNF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x2732E30", Offset = "0x2731630", VA = "0x182732E30")]
			internal void OFCNKEHMCIB(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x2732CC0", Offset = "0x27314C0", VA = "0x182732CC0")]
			internal bool MABDGBGKMKF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x2732D10", Offset = "0x2731510", VA = "0x182732D10")]
			internal void MCLHFKLBCLH(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x27329D0", Offset = "0x27311D0", VA = "0x1827329D0")]
			internal float EJJCJJJIPID()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x2732DA0", Offset = "0x27315A0", VA = "0x182732DA0")]
			internal void MNINOENIMMK(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x2732A70", Offset = "0x2731270", VA = "0x182732A70")]
			internal int HCDFAFNJPCB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x2732860", Offset = "0x2731060", VA = "0x182732860")]
			internal void BBHJAPJMOLI(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x2732AD0", Offset = "0x27312D0", VA = "0x182732AD0")]
			internal bool HLABILHBCKE()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override NodeVisualizationKey FIEPPEJGGLF
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x10883D0", Offset = "0x1086BD0", VA = "0x1810883D0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x2722B40", Offset = "0x2721340", VA = "0x182722B40")]
		public AIPDNNKFBLL(CBFIFLFMBFP MPABKJPPPMM, KJIFHPMLLKB GDFCBMOFMFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x2722100", Offset = "0x2720900", VA = "0x182722100", Slot = "134")]
		protected override void KCBBIJPOMMB(APKPIDOBEFA NBFCHNOPHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public sealed class DLOJNKHOANN : IJIPHCJMIJF<GNNNOJCFCLC>
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private sealed class MIAECHONCAN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public LNHBIEKMMIC nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public DLOJNKHOANN <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public MIAECHONCAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x2736130", Offset = "0x2734930", VA = "0x182736130")]
			internal Dictionary<string, BJCOKIAGPOC> KOACCBJHCAE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x2736060", Offset = "0x2734860", VA = "0x182736060")]
			internal int DAJNJOHEPHE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x27361D0", Offset = "0x27349D0", VA = "0x1827361D0")]
			internal void LFCONHGLCKD(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x27360B0", Offset = "0x27348B0", VA = "0x1827360B0")]
			internal bool IHPGAMMHHFC()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override NodeVisualizationKey FIEPPEJGGLF
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x10883D0", Offset = "0x1086BD0", VA = "0x1810883D0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x272D6E0", Offset = "0x272BEE0", VA = "0x18272D6E0")]
		public DLOJNKHOANN(CBFIFLFMBFP MPABKJPPPMM, GNNNOJCFCLC JLPKBNIJDEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x272D410", Offset = "0x272BC10", VA = "0x18272D410", Slot = "134")]
		protected override void KCBBIJPOMMB(APKPIDOBEFA NBFCHNOPHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public sealed class EMMKKGOFEDK : IJIPHCJMIJF<FPLPHNEPFPO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private sealed class EOKHBBMFNBE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public LNHBIEKMMIC nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public EMMKKGOFEDK <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public EOKHBBMFNBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x272E1A0", Offset = "0x272C9A0", VA = "0x18272E1A0")]
			internal void KOACCBJHCAE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override NodeVisualizationKey FIEPPEJGGLF
		{
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x10883D0", Offset = "0x1086BD0", VA = "0x1810883D0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x272E050", Offset = "0x272C850", VA = "0x18272E050")]
		public EMMKKGOFEDK(CBFIFLFMBFP MPABKJPPPMM, FPLPHNEPFPO JLPKBNIJDEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x272DED0", Offset = "0x272C6D0", VA = "0x18272DED0", Slot = "134")]
		protected override void KCBBIJPOMMB(APKPIDOBEFA NBFCHNOPHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class AHCHPIDLFGB<TNode> : BDPPJKIIHMO<TNode> where TNode : notnull, MNMDDBOLHNA
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override bool HEHNCKNHEHC
		{
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "107")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override JLPGGFGGJCB? HBECHMGHMOP
		{
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x49E8CE0", Offset = "0x49E74E0", VA = "0x1849E8CE0", Slot = "124")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override bool CCFCAAJPCON
		{
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x49E8D90", Offset = "0x49E7590", VA = "0x1849E8D90", Slot = "131")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override NodeVisualizationKey FIEPPEJGGLF
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xD6C920", Offset = "0xD6B120", VA = "0x180D6C920", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x49E8D50", Offset = "0x49E7550", VA = "0x1849E8D50")]
		public AHCHPIDLFGB(CBFIFLFMBFP MPABKJPPPMM, TNode GDFCBMOFMFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class MBDIAANFIFI : AHCHPIDLFGB<CEIGPFOJPOB>
	{
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		[CompilerGenerated]
		private sealed class KDJOMGDAHAE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public MBDIAANFIFI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public LNHBIEKMMIC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public KDJOMGDAHAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x2733DC0", Offset = "0x27325C0", VA = "0x182733DC0")]
			internal object KOACCBJHCAE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x2733CF0", Offset = "0x27324F0", VA = "0x182733CF0")]
			internal void DAJNJOHEPHE(object v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x2733E30", Offset = "0x2732630", VA = "0x182733E30")]
			internal void LFCONHGLCKD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private static object[]? NPJCMGCGHME;

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x2734D30", Offset = "0x2733530", VA = "0x182734D30")]
		public MBDIAANFIFI(CBFIFLFMBFP MPABKJPPPMM, CEIGPFOJPOB GDFCBMOFMFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x2734790", Offset = "0x2732F90", VA = "0x182734790", Slot = "134")]
		protected override void KCBBIJPOMMB(APKPIDOBEFA NBFCHNOPHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private sealed class JPKNFFGIHOA : IJIPHCJMIJF<HNKDHGJDBBJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override NodeVisualizationKey FIEPPEJGGLF
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0xC4E890", Offset = "0xC4D090", VA = "0x180C4E890", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x2733C80", Offset = "0x2732480", VA = "0x182733C80")]
		public JPKNFFGIHOA(CBFIFLFMBFP MPABKJPPPMM, HNKDHGJDBBJ GDFCBMOFMFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "134")]
		protected override void KCBBIJPOMMB(APKPIDOBEFA NBFCHNOPHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private sealed class GDOCHKJBJDN : IJIPHCJMIJF<FLIIKMBCLGC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override NodeVisualizationKey FIEPPEJGGLF
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0xBB51B0", Offset = "0xBB39B0", VA = "0x180BB51B0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x2731990", Offset = "0x2730190", VA = "0x182731990")]
		public GDOCHKJBJDN(CBFIFLFMBFP MPABKJPPPMM, FLIIKMBCLGC GDFCBMOFMFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "126")]
		protected override bool BHDLGPIADCK(NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "134")]
		protected override void KCBBIJPOMMB(APKPIDOBEFA NBFCHNOPHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private sealed class PLDMLEILDGB : IJIPHCJMIJF<HJGCDOMIMEE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override NodeVisualizationKey FIEPPEJGGLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0xB705C0", Offset = "0xB6EDC0", VA = "0x180B705C0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool OBLHFFDBABO
		{
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x273E260", Offset = "0x273CA60", VA = "0x18273E260", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		protected override bool NAMJHKPLPCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x273E1F0", Offset = "0x273C9F0", VA = "0x18273E1F0")]
		public PLDMLEILDGB(CBFIFLFMBFP MPABKJPPPMM, HJGCDOMIMEE GDFCBMOFMFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "134")]
		protected override void KCBBIJPOMMB(APKPIDOBEFA NBFCHNOPHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class DLOAPFODMMP : IJIPHCJMIJF<GAGAJMGEPEA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override NodeVisualizationKey FIEPPEJGGLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0xBB4EE0", Offset = "0xBB36E0", VA = "0x180BB4EE0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override bool OBLHFFDBABO
		{
			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x272D3C0", Offset = "0x272BBC0", VA = "0x18272D3C0", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		protected override bool NAMJHKPLPCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x272D350", Offset = "0x272BB50", VA = "0x18272D350")]
		public DLOAPFODMMP(CBFIFLFMBFP MPABKJPPPMM, GAGAJMGEPEA GDFCBMOFMFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "134")]
		protected override void KCBBIJPOMMB(APKPIDOBEFA NBFCHNOPHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public sealed class FKLKEHGEAMM : NPDGDHKCCMH<GLMKPLNNIDL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class FOHILABIHHJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public FKLKEHGEAMM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public LNHBIEKMMIC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public FOHILABIHHJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x272F130", Offset = "0x272D930", VA = "0x18272F130")]
			internal float NDLNCFEHFJN()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x272F090", Offset = "0x272D890", VA = "0x18272F090")]
			internal void DFBMIADMOCK(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x272F030", Offset = "0x272D830", VA = "0x18272F030")]
		public FKLKEHGEAMM(CBFIFLFMBFP MPABKJPPPMM, GLMKPLNNIDL JLPKBNIJDEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x272EDB0", Offset = "0x272D5B0", VA = "0x18272EDB0", Slot = "140")]
		protected override void OLPANILNBFP(APKPIDOBEFA NBFCHNOPHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public sealed class DPHOMFHGFBF : IJIPHCJMIJF<IFGELIFALGP>
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		[CompilerGenerated]
		private sealed class KLNKAPPEMFA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public DPHOMFHGFBF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public LNHBIEKMMIC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public KLNKAPPEMFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x2734050", Offset = "0x2732850", VA = "0x182734050")]
			internal bool KOACCBJHCAE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x2733F20", Offset = "0x2732720", VA = "0x182733F20")]
			internal void DAJNJOHEPHE(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x272DA00", Offset = "0x272C200", VA = "0x18272DA00")]
		public DPHOMFHGFBF(CBFIFLFMBFP MPABKJPPPMM, IFGELIFALGP JLPKBNIJDEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x272D750", Offset = "0x272BF50", VA = "0x18272D750", Slot = "134")]
		protected override void KCBBIJPOMMB(APKPIDOBEFA NBFCHNOPHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class MBPPBAFKGGB : IJIPHCJMIJF<ELHDJCIDIGK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		[CompilerGenerated]
		private sealed class FDFDFNFMLBC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public LNHBIEKMMIC nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public MBPPBAFKGGB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public FDFDFNFMLBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x272E700", Offset = "0x272CF00", VA = "0x18272E700")]
			internal object KOACCBJHCAE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x272E990", Offset = "0x272D190", VA = "0x18272E990")]
			internal bool OFCNKEHMCIB(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x272E2B0", Offset = "0x272CAB0", VA = "0x18272E2B0")]
			internal void DAJNJOHEPHE(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x272E830", Offset = "0x272D030", VA = "0x18272E830")]
			internal string LFCONHGLCKD(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x272E6B0", Offset = "0x272CEB0", VA = "0x18272E6B0")]
			internal IReadOnlyList<object> IHPGAMMHHFC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x272E510", Offset = "0x272CD10", VA = "0x18272E510")]
			internal bool FJIIPMHGAJJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x272EA10", Offset = "0x272D210", VA = "0x18272EA10")]
			internal bool OJDBMGKIAGD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x272E580", Offset = "0x272CD80", VA = "0x18272E580")]
			internal void IHKKLMAGGNF(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x27355A0", Offset = "0x2733DA0", VA = "0x1827355A0")]
		public MBPPBAFKGGB(CBFIFLFMBFP MPABKJPPPMM, ELHDJCIDIGK JLPKBNIJDEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x2734D90", Offset = "0x2733590", VA = "0x182734D90", Slot = "134")]
		protected override void KCBBIJPOMMB(APKPIDOBEFA NBFCHNOPHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class DBHKMDJPLHD : CAKJNBOEGGO<LLKFHHJIKHM>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override NodeVisualizationKey FIEPPEJGGLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0xD790B0", Offset = "0xD778B0", VA = "0x180D790B0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x272D1C0", Offset = "0x272B9C0", VA = "0x18272D1C0")]
		public DBHKMDJPLHD(CBFIFLFMBFP MPABKJPPPMM, LLKFHHJIKHM GDFCBMOFMFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class FEJHKFBFKNB : NPDGDHKCCMH<LPKHGLINAIL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class IHEHEDCIODL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public FEJHKFBFKNB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public LNHBIEKMMIC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public IHEHEDCIODL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x2733030", Offset = "0x2731830", VA = "0x182733030")]
			internal int NDLNCFEHFJN()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x2732F90", Offset = "0x2731790", VA = "0x182732F90")]
			internal void DFBMIADMOCK(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x272ECF0", Offset = "0x272D4F0", VA = "0x18272ECF0")]
		public FEJHKFBFKNB(CBFIFLFMBFP MPABKJPPPMM, LPKHGLINAIL JLPKBNIJDEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x272EA60", Offset = "0x272D260", VA = "0x18272EA60", Slot = "140")]
		protected override void OLPANILNBFP(APKPIDOBEFA NBFCHNOPHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class PHANOAICMLK : IJIPHCJMIJF<GGEMAKHGKHD>
	{
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		[CompilerGenerated]
		private sealed class MNDCJHHMGKE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public PHANOAICMLK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public LNHBIEKMMIC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public MNDCJHHMGKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x2736800", Offset = "0x2735000", VA = "0x182736800")]
			internal bool KOACCBJHCAE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x2736770", Offset = "0x2734F70", VA = "0x182736770")]
			internal void DAJNJOHEPHE(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x273E180", Offset = "0x273C980", VA = "0x18273E180")]
		public PHANOAICMLK(CBFIFLFMBFP MPABKJPPPMM, GGEMAKHGKHD JLPKBNIJDEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x273DFA0", Offset = "0x273C7A0", VA = "0x18273DFA0", Slot = "134")]
		protected override void KCBBIJPOMMB(APKPIDOBEFA NBFCHNOPHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class OJFLBIEBCNC : IJIPHCJMIJF<NGLBHIKMHPI>
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		[CompilerGenerated]
		private sealed class LJDOKGDMFNF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public OJFLBIEBCNC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public LNHBIEKMMIC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public LJDOKGDMFNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x2734370", Offset = "0x2732B70", VA = "0x182734370")]
			internal bool KOACCBJHCAE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x27342E0", Offset = "0x2732AE0", VA = "0x1827342E0")]
			internal void DAJNJOHEPHE(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x273CBE0", Offset = "0x273B3E0", VA = "0x18273CBE0")]
		public OJFLBIEBCNC(CBFIFLFMBFP MPABKJPPPMM, NGLBHIKMHPI JLPKBNIJDEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x273CA00", Offset = "0x273B200", VA = "0x18273CA00", Slot = "134")]
		protected override void KCBBIJPOMMB(APKPIDOBEFA NBFCHNOPHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public sealed class MOAMFIDMGGP : IJIPHCJMIJF<GADPOJNMAJM>
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		[CompilerGenerated]
		private sealed class ENLENNCHHNP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public MOAMFIDMGGP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public LNHBIEKMMIC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public ENLENNCHHNP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x272E150", Offset = "0x272C950", VA = "0x18272E150")]
			internal int KOACCBJHCAE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x272E0C0", Offset = "0x272C8C0", VA = "0x18272E0C0")]
			internal void DAJNJOHEPHE(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x2736EA0", Offset = "0x27356A0", VA = "0x182736EA0")]
		public MOAMFIDMGGP(CBFIFLFMBFP MPABKJPPPMM, GADPOJNMAJM JLPKBNIJDEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x2736C30", Offset = "0x2735430", VA = "0x182736C30", Slot = "134")]
		protected override void KCBBIJPOMMB(APKPIDOBEFA NBFCHNOPHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public sealed class HCABAHKPECA : PPDFFPOLCBE<GBAGLOONANH>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public override NGIJPDCOOEK DDDMJKGGPBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0xBCB360", Offset = "0xBC9B60", VA = "0x180BCB360", Slot = "140")]
			get
			{
				return default(NGIJPDCOOEK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x2731AE0", Offset = "0x27302E0", VA = "0x182731AE0")]
		public HCABAHKPECA(CBFIFLFMBFP MPABKJPPPMM, GBAGLOONANH JLPKBNIJDEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class LELHKMLBLFM : IJIPHCJMIJF<BKBACPLKPAP>
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x2734150", Offset = "0x2732950", VA = "0x182734150")]
		public LELHKMLBLFM(CBFIFLFMBFP MPABKJPPPMM, BKBACPLKPAP GDFCBMOFMFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public abstract class IJIPHCJMIJF<TNode> : DHGFIPJKDOO, IDisposable where TNode : notnull, BKBACPLKPAP
	{
		[Cpp2IlInjected.Token(Token = "0x2000091")]
		[CompilerGenerated]
		private sealed class FLBJIEMHDHM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public IJIPHCJMIJF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public CBFIFLFMBFP circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public FLBJIEMHDHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x48D28B0", Offset = "0x48D10B0", VA = "0x1848D28B0")]
			internal OFFBJDFMAEK KBIGNJGKFBP(ANDADCHGJOB portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000092")]
		[CompilerGenerated]
		private struct MHJIAAHOCDI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public IJIPHCJMIJF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x52084D0", Offset = "0x5206CD0", VA = "0x1852084D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0xA2F200", Offset = "0xA2DA00", VA = "0x180A2F200", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		[CompilerGenerated]
		private struct DOGIKECLOMO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public AsyncTaskMethodBuilder<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public IJIPHCJMIJF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public DLGDAHEMPMJ? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public DGDOFNPFHCD? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x68EA1E0", Offset = "0x68E89E0", VA = "0x1868EA1E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x68EA480", Offset = "0x68E8C80", VA = "0x1868EA480", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class MCFMOCMONLK
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000095")]
			private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D0")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D1")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D2")]
				public MCFMOCMONLK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D3")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60003C6")]
				[Cpp2IlInjected.Address(RVA = "0x3FD0A30", Offset = "0x3FCF230", VA = "0x183FD0A30", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003C7")]
				[Cpp2IlInjected.Address(RVA = "0xA2F200", Offset = "0xA2DA00", VA = "0x180A2F200", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public Func<string, bool> submitValidator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			public LNHBIEKMMIC nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public IJIPHCJMIJF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public APKPIDOBEFA configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public MCFMOCMONLK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
			internal string COKJPAEHHIA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
			internal void BAFPNJKFJPA(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x51EC5B0", Offset = "0x51EADB0", VA = "0x1851EC5B0")]
			[AsyncStateMachine(typeof(IJIPHCJMIJF<>.MCFMOCMONLK.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void FGPCCLDBGGG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000096")]
		[CompilerGenerated]
		private sealed class EDPOECPPEIF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public LNHBIEKMMIC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public EDPOECPPEIF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x43E9600", Offset = "0x43E7E00", VA = "0x1843E9600")]
			internal bool KBGJLIEKOMA(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x43E96E0", Offset = "0x43E7EE0", VA = "0x1843E96E0")]
			internal bool KEKPOAADHAG(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private struct EENINJKLAGB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public AsyncTaskMethodBuilder<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public IJIPHCJMIJF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0x43ED0E0", Offset = "0x43EB8E0", VA = "0x1843ED0E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x43ED470", Offset = "0x43EBC70", VA = "0x1843ED470", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private readonly CBFIFLFMBFP BLOIFBAMAPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private readonly bool LCOJMEDIJDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private NEEMGKAPJDL<FGCGLNKNFGK, OFFBJDFMAEK> MFDLMHNOFHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private NEEMGKAPJDL<FGCGLNKNFGK, FGJEEAJAKCB> AFEKLIGFDBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private List<Action> EPGEKJBPHDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[CompilerGenerated]
		private Action<NLPIAAOFKEO<FGCGLNKNFGK>>? JDHBJBPHNKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[CompilerGenerated]
		private Action<NLPIAAOFKEO<FGCGLNKNFGK>, FGJEEAJAKCB>? PIPNNLJBMGD;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		protected LNOMLFPCEKA GACKNFEGFDP
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x4B7C040", Offset = "0x4B7A840", VA = "0x184B7C040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		protected LNHBIEKMMIC AHNAEKAOKNI
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x4B7EFD0", Offset = "0x4B7D7D0", VA = "0x184B7EFD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected TNode OHGKHHGBPBE
		{
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public CMDPIJDKPHC<KOBOGCBMJKE> LLOEAKONJIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x1337EC0", Offset = "0x13366C0", VA = "0x181337EC0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(CMDPIJDKPHC<KOBOGCBMJKE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public NLPIAAOFKEO<AGEMPNFBJCE> CJHDKDLIJGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x4B80D00", Offset = "0x4B7F500", VA = "0x184B80D00", Slot = "6")]
			get
			{
				return default(NLPIAAOFKEO<AGEMPNFBJCE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public object LJJLPIHDEKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x4491C10", Offset = "0x4490410", VA = "0x184491C10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public virtual bool LHFJIIAAMAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "102")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public int GEHPAEKDJGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x4B80960", Offset = "0x4B7F160", VA = "0x184B80960", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public KJPPCHHGBLL NPEMAOHOELP
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x4B80900", Offset = "0x4B7F100", VA = "0x184B80900", Slot = "10")]
			get
			{
				return default(KJPPCHHGBLL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string MGCBMALFFBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x4B80F00", Offset = "0x4B7F700", VA = "0x184B80F00", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected virtual bool NAMJHKPLPCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual NodeVisualizationKey FIEPPEJGGLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public NLPIAAOFKEO<DDIPAEPPIFH> PPNDPCNLEMA
		{
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0xE297D0", Offset = "0xE27FD0", VA = "0x180E297D0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(NLPIAAOFKEO<DDIPAEPPIFH>);
			}
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0xE2BE00", Offset = "0xE2A600", VA = "0x180E2BE00")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public virtual bool PBHJHPHGLJF
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "105")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public virtual bool OBLHFFDBABO
		{
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public virtual bool HEHNCKNHEHC
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "107")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public virtual CPEEAANHNKN NHGIEAMELEF
		{
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0xF46C70", Offset = "0xF45470", VA = "0x180F46C70", Slot = "108")]
			get
			{
				return default(CPEEAANHNKN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool HBOFLMJEDIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x4B80670", Offset = "0x4B7EE70", VA = "0x184B80670", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool DICLIIJJCKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x4B806D0", Offset = "0x4B7EED0", VA = "0x184B806D0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool EOIPEOJCHIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x4B80730", Offset = "0x4B7EF30", VA = "0x184B80730", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public int GMICFIFFFMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x4B80CB0", Offset = "0x4B7F4B0", VA = "0x184B80CB0", Slot = "21")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public bool CDHMJFPBDNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x4B80AE0", Offset = "0x4B7F2E0", VA = "0x184B80AE0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public PNOENJOAMMM LNHDCPAFPEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x4B80840", Offset = "0x4B7F040", VA = "0x184B80840", Slot = "23")]
			get
			{
				return default(PNOENJOAMMM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool MEMEJNCCCPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x4B807E0", Offset = "0x4B7EFE0", VA = "0x184B807E0", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool EPDKDDDNEHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0xF11310", Offset = "0xF0FB10", VA = "0x180F11310", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x12DBF40", Offset = "0x12DA740", VA = "0x1812DBF40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool HBPLMMIAOBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "109")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual bool PDLHDNMPLGP
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x4B80790", Offset = "0x4B7EF90", VA = "0x184B80790", Slot = "110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public bool CHGJPLFDEJF
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x4B80A10", Offset = "0x4B7F210", VA = "0x184B80A10", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public DLGDAHEMPMJ CHPCAADKHJO
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x4B80BF0", Offset = "0x4B7F3F0", VA = "0x184B80BF0", Slot = "29")]
			get
			{
				return default(DLGDAHEMPMJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public DGDOFNPFHCD OIHKBFCJFOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x4B80C50", Offset = "0x4B7F450", VA = "0x184B80C50", Slot = "31")]
			get
			{
				return default(DGDOFNPFHCD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public virtual bool HIPEKMOOMFI
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public virtual GFCFBIDKIHM? AEGOJEHDKEO
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "123")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public virtual JLPGGFGGJCB? HBECHMGHMOP
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "124")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public virtual IEnumerable<CMDPIJDKPHC<KGLBPIDLJAB>>? IOIDMNPDBJH
		{
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "125")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool CDMFKLPAOHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x4B808A0", Offset = "0x4B7F0A0", VA = "0x184B808A0", Slot = "128")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public CMDPIJDKPHC<PAJOPNAJIFC> KOKAGENLDFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x4B80B30", Offset = "0x4B7F330", VA = "0x184B80B30", Slot = "63")]
			get
			{
				return default(CMDPIJDKPHC<PAJOPNAJIFC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public NLPIAAOFKEO<PAJOPNAJIFC> DOCKCOIAGNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x4B809B0", Offset = "0x4B7F1B0", VA = "0x184B809B0", Slot = "57")]
			get
			{
				return default(NLPIAAOFKEO<PAJOPNAJIFC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public virtual bool DLAGONFAHBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "129")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public virtual NLPIAAOFKEO<PAJOPNAJIFC>? CALGJHAFIJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public virtual bool CCFCAAJPCON
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "131")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public bool ACAKGNJEBMF
		{
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x4B80A70", Offset = "0x4B7F270", VA = "0x184B80A70", Slot = "62")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public string ACOJEEABMOC
		{
			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x9E93E0", Offset = "0x9E7BE0", VA = "0x1809E93E0", Slot = "66")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x9E9480", Offset = "0x9E7C80", VA = "0x1809E9480")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public string DJHECOFDJHF
		{
			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x9E9310", Offset = "0x9E7B10", VA = "0x1809E9310", Slot = "67")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x9E9320", Offset = "0x9E7B20", VA = "0x1809E9320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public NLPIAAOFKEO<KGLBPIDLJAB> ECFJFNFNNFG
		{
			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x4B80D80", Offset = "0x4B7F580", VA = "0x184B80D80", Slot = "64")]
			get
			{
				return default(NLPIAAOFKEO<KGLBPIDLJAB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public CMDPIJDKPHC<KGLBPIDLJAB> DOGCNJOEHHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x4B80B90", Offset = "0x4B7F390", VA = "0x184B80B90", Slot = "65")]
			get
			{
				return default(CMDPIJDKPHC<KGLBPIDLJAB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public CMDPIJDKPHC<KGLBPIDLJAB>? NNJAHIBCMIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x4B80DE0", Offset = "0x4B7F5E0", VA = "0x184B80DE0", Slot = "132")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public GKFCELPELJB<FGCGLNKNFGK, FGJEEAJAKCB> DKNNFMNKDKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x4B80EC0", Offset = "0x4B7F6C0", VA = "0x184B80EC0", Slot = "68")]
			get
			{
				return default(GKFCELPELJB<FGCGLNKNFGK, FGJEEAJAKCB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public virtual NLPIAAOFKEO<FGCGLNKNFGK>? ACNKDCGHPJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "133")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public virtual bool OMOCHFFHAGP
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "136")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public virtual bool GLGILOPIHOI
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "137")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action LPNCKKGBCHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x4B7E1A0", Offset = "0x4B7C9A0", VA = "0x184B7E1A0", Slot = "38")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x4B7DA50", Offset = "0x4B7C250", VA = "0x184B7DA50", Slot = "39")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event MIDBKDCANOC LEJHMKGHALD
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x4B7FA00", Offset = "0x4B7E200", VA = "0x184B7FA00", Slot = "40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x4B7E100", Offset = "0x4B7C900", VA = "0x184B7E100", Slot = "41")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event PPFECKHCGAD MEMKOPBNLEC
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x4B7E060", Offset = "0x4B7C860", VA = "0x184B7E060", Slot = "42")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x4B7E7A0", Offset = "0x4B7CFA0", VA = "0x184B7E7A0", Slot = "43")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action BNBPBCEADKI
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x4B7E240", Offset = "0x4B7CA40", VA = "0x184B7E240", Slot = "44")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x4B7CF20", Offset = "0x4B7B720", VA = "0x184B7CF20", Slot = "45")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action KEEJMIGACMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x4B7E4F0", Offset = "0x4B7CCF0", VA = "0x184B7E4F0", Slot = "46")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x4B7FE70", Offset = "0x4B7E670", VA = "0x184B7FE70", Slot = "47")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<NLPIAAOFKEO<FGCGLNKNFGK>, FGJEEAJAKCB> DDNJLMLMHEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x4B7C930", Offset = "0x4B7B130", VA = "0x184B7C930", Slot = "70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0x4B7F540", Offset = "0x4B7DD40", VA = "0x184B7F540", Slot = "71")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<NLPIAAOFKEO<FGCGLNKNFGK>, FGJEEAJAKCB> CAFDPNDBKKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x4B7F480", Offset = "0x4B7DC80", VA = "0x184B7F480", Slot = "74")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0x4B7F270", Offset = "0x4B7DA70", VA = "0x184B7F270", Slot = "75")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<NLPIAAOFKEO<FGCGLNKNFGK>> KJKHAGHPPDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x4B7BC90", Offset = "0x4B7A490", VA = "0x184B7BC90", Slot = "72")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x4B7EF10", Offset = "0x4B7D710", VA = "0x184B7EF10", Slot = "73")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<NLPIAAOFKEO<FGCGLNKNFGK>, NLPIAAOFKEO<FGCGLNKNFGK>> OEICKCBKICA
		{
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x4B7F630", Offset = "0x4B7DE30", VA = "0x184B7F630", Slot = "76")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x4B7CCE0", Offset = "0x4B7B4E0", VA = "0x184B7CCE0", Slot = "77")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<NLPIAAOFKEO<FGCGLNKNFGK>, FGJEEAJAKCB> INPFNOEDHFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x4B7DB40", Offset = "0x4B7C340", VA = "0x184B7DB40", Slot = "78")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x4B7E8F0", Offset = "0x4B7D0F0", VA = "0x184B7E8F0", Slot = "79")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<NLPIAAOFKEO<FGCGLNKNFGK>, NLPIAAOFKEO<FGCGLNKNFGK>> NLPCEPDMDMD
		{
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x4B7CE60", Offset = "0x4B7B660", VA = "0x184B7CE60", Slot = "80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x4B7CDA0", Offset = "0x4B7B5A0", VA = "0x184B7CDA0", Slot = "81")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x4B800A0", Offset = "0x4B7E8A0", VA = "0x184B800A0")]
		[ENFMKHMGDHB("Need to handle `Name` better.")]
		[ENFMKHMGDHB("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		protected IJIPHCJMIJF(CBFIFLFMBFP MPABKJPPPMM, TNode GDFCBMOFMFN, bool IMIMPLPNBNI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x4B7F760", Offset = "0x4B7DF60", VA = "0x184B7F760", Slot = "100")]
		protected virtual void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x4B7D090", Offset = "0x4B7B890", VA = "0x184B7D090", Slot = "101")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x4B7E840", Offset = "0x4B7D040", VA = "0x184B7E840", Slot = "9")]
		[AsyncStateMachine(typeof(IJIPHCJMIJF<>.MHJIAAHOCDI))]
		public void JIOELDMMHLC(int CJFBLAOPKIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x4B7FF10", Offset = "0x4B7E710", VA = "0x184B7FF10")]
		public bool PKINDKBGBOO([In] DLGDAHEMPMJ OPMIAMEJKDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x4B7C8C0", Offset = "0x4B7B0C0", VA = "0x184B7C8C0")]
		public bool BEHEKEFABJB([In] DGDOFNPFHCD OPMIAMEJKDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x4B7E590", Offset = "0x4B7CD90", VA = "0x184B7E590", Slot = "33")]
		public void JFEEIDBFNIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x4B7F330", Offset = "0x4B7DB30", VA = "0x184B7F330", Slot = "34")]
		[AsyncStateMachine(typeof(IJIPHCJMIJF<>.DOGIKECLOMO))]
		public Task<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> MPFNLOJPGHI(DLGDAHEMPMJ? IKAECBBFJHO, DGDOFNPFHCD? KOBOFDGKPML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "111")]
		public virtual void GHLMFGCKDDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "112")]
		public virtual void IKAEDECCONN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "113")]
		public virtual void ONEGDDHIFOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xEF02C0", Offset = "0xEEEAC0", VA = "0x180EF02C0")]
		protected void AFHPHDONICN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xF40E20", Offset = "0xF3F620", VA = "0x180F40E20")]
		protected void MPJMFOGIKBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x211F0A0", Offset = "0x211D8A0", VA = "0x18211F0A0")]
		private void DABNDOAKDIG([In] DGDOFNPFHCD PMHMEKBKJJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x4B7DF90", Offset = "0x4B7C790", VA = "0x184B7DF90", Slot = "114")]
		public virtual Task<HCGBMJDNFKJ<NLPIAAOFKEO<FGCGLNKNFGK>, CPMHOEMAGED>> GGAFGFDMLID(string GLGOHIJMLFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x4B7BD50", Offset = "0x4B7A550", VA = "0x184B7BD50", Slot = "115")]
		public virtual Task<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> AFNANOJHFNA(NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "116")]
		public virtual void GKBNAMALNPJ(NLPIAAOFKEO<FGCGLNKNFGK> DHENBNFNJIC, NLPIAAOFKEO<FGCGLNKNFGK> IKKDCMIKIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x4B7BE20", Offset = "0x4B7A620", VA = "0x184B7BE20", Slot = "117")]
		public virtual IEnumerable<IOPMFGMDJPO> AJGDNKMCMJG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x4B7CF80", Offset = "0x4B7B780", VA = "0x184B7CF80", Slot = "118")]
		public HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED> DBGJOKBGEMK(string MJDGICLIAKI)
		{
			return default(HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x4B7E310", Offset = "0x4B7CB10", VA = "0x184B7E310", Slot = "48")]
		public bool INHPIEDJNBH([Out] Guid ABMMCPHJMGL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x4B7C9F0", Offset = "0x4B7B1F0", VA = "0x184B7C9F0")]
		public bool BGFPPOOMHEP([In] Guid FOEJGIIEFNC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "119")]
		public virtual void OMPDHJNPJPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "120")]
		public virtual void FLFJJMOFNBL(bool HAFJCEACJOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "121")]
		public virtual LNINKPIFODA CAJPFOPAKPD([In] KGKLDIAPIEK LKHPPMAOBBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x4B7DDA0", Offset = "0x4B7C5A0", VA = "0x184B7DDA0")]
		protected void FNDOEJKKIMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x4B7CCA0", Offset = "0x4B7B4A0", VA = "0x184B7CCA0", Slot = "126")]
		protected virtual bool BHDLGPIADCK(NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x4B7F600", Offset = "0x4B7DE00", VA = "0x184B7F600", Slot = "89")]
		public bool NNAEMHAAONF(NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "127")]
		protected virtual bool MKEPFLKIPGH(NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "134")]
		protected virtual void KCBBIJPOMMB(APKPIDOBEFA PLKFMODIHLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x4B7C0A0", Offset = "0x4B7A8A0", VA = "0x184B7C0A0")]
		protected void BBGICIIFMDF(APKPIDOBEFA NBFCHNOPHLL, Func<string> GIMBGLHOEGA, Action<string> GAALCBCBHIB, string JIOIPEMHCPO, string EGMMDLLEHBK, string MDDPKBHHKNF, PIMHFLEFNOB CDNJJGKIEGL, OLNPJNKPNFB CHCCDPDLOKO, Func<string, bool> OOKGOEFPLON, string AKBJAGAEABC, Func<string, bool> IHPDOECEBIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x4B7FAA0", Offset = "0x4B7E2A0", VA = "0x184B7FAA0")]
		protected void PAPJMKFJFCA(APKPIDOBEFA NBFCHNOPHLL, Func<string> GIMBGLHOEGA, Action<string> GAALCBCBHIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x4B7F0C0", Offset = "0x4B7D8C0", VA = "0x184B7F0C0", Slot = "135")]
		protected virtual void LNKBGKCMEMI(APKPIDOBEFA NBFCHNOPHLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x4B7DAF0", Offset = "0x4B7C2F0", VA = "0x184B7DAF0", Slot = "83")]
		public void ENHBGDFAEEG(APKPIDOBEFA NBFCHNOPHLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x4B7DC40", Offset = "0x4B7C440", VA = "0x184B7DC40", Slot = "84")]
		public CLHPMEOLFDE FEMMFBCLFFD()
		{
			return default(CLHPMEOLFDE);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "138")]
		public virtual bool IKMKPJLKIHM(NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x1F0DF80", Offset = "0x1F0C780", VA = "0x181F0DF80")]
		private void FEEHDEBFNOA([In] DLGDAHEMPMJ NCGKJMOKFAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x4B7BEF0", Offset = "0x4B7A6F0", VA = "0x184B7BEF0")]
		private void ALPGOMLHLKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x4B7D010", Offset = "0x4B7B810", VA = "0x184B7D010", Slot = "90")]
		private void DGNPNFPAAEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x4B7D490", Offset = "0x4B7BC90", VA = "0x184B7D490", Slot = "92")]
		private void EDLGFMBMDII(NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x108BD40", Offset = "0x108A540", VA = "0x18108BD40", Slot = "94")]
		private void ANEEBCOOLLE(NLPIAAOFKEO<FGCGLNKNFGK> MLBCMOLHELH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x4B7ED60", Offset = "0x4B7D560", VA = "0x184B7ED60", Slot = "96")]
		private void JLNJACDEDEE(NLPIAAOFKEO<FGCGLNKNFGK> MLBCMOLHELH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x4B7E9B0", Offset = "0x4B7D1B0", VA = "0x184B7E9B0", Slot = "97")]
		private void JJPKMCBNMBN(NLPIAAOFKEO<FGCGLNKNFGK> DHENBNFNJIC, NLPIAAOFKEO<FGCGLNKNFGK> IKKDCMIKIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x108BD20", Offset = "0x108A520", VA = "0x18108BD20", Slot = "98")]
		private void EAAMJCJOJGP(NLPIAAOFKEO<FGCGLNKNFGK> DHENBNFNJIC, NLPIAAOFKEO<FGCGLNKNFGK> IKKDCMIKIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x4B7E4D0", Offset = "0x4B7CCD0", VA = "0x184B7E4D0", Slot = "91")]
		private void JCLMMLCGDNB(NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x4B7C4A0", Offset = "0x4B7ACA0", VA = "0x184B7C4A0", Slot = "93")]
		private void BBOICGPEKJI(NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x4B7E460", Offset = "0x4B7CC60", VA = "0x184B7E460", Slot = "95")]
		private void IPBFLMKDGLH(NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x4B7FF80", Offset = "0x4B7E780", VA = "0x184B7FF80", Slot = "139")]
		[AsyncStateMachine(typeof(IJIPHCJMIJF<>.EENINJKLAGB))]
		public Task<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> PPALPHIEKLG(string MJDGICLIAKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x4B7F6F0", Offset = "0x4B7DEF0", VA = "0x184B7F6F0", Slot = "55")]
		private void NNKKEKEHBAE(object LCNJNLJAJEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x4B7DD30", Offset = "0x4B7C530", VA = "0x184B7DD30", Slot = "56")]
		private void FIHAGBMEJKO(object LCNJNLJAJEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x4B7D050", Offset = "0x4B7B850", VA = "0x184B7D050", Slot = "30")]
		private bool DKFLBKNPNDB([In] DLGDAHEMPMJ OPMIAMEJKDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x4B7BEB0", Offset = "0x4B7A6B0", VA = "0x184B7BEB0", Slot = "32")]
		private bool ALJBDNFMDEG([In] DGDOFNPFHCD OPMIAMEJKDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x4B7FE30", Offset = "0x4B7E630", VA = "0x184B7FE30", Slot = "49")]
		private bool PILCLODEHKN([In] Guid FOEJGIIEFNC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x4B7DC00", Offset = "0x4B7C400", VA = "0x184B7DC00")]
		[CompilerGenerated]
		private string FCABLIGIDIF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x4B7FD90", Offset = "0x4B7E590", VA = "0x184B7FD90")]
		[CompilerGenerated]
		private void PIEDAIMMAMI(string GLGOHIJMLFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class FIABBOOBBKO : CAKJNBOEGGO<LKFOOMKDANC>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public override NodeVisualizationKey FIEPPEJGGLF
		{
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0xD761F0", Offset = "0xD749F0", VA = "0x180D761F0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x272ED50", Offset = "0x272D550", VA = "0x18272ED50")]
		public FIABBOOBBKO(CBFIFLFMBFP MPABKJPPPMM, LKFOOMKDANC GDFCBMOFMFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private sealed class BABGDPNBPGG : BDPPJKIIHMO<CLPFPFHLDHK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public override NodeVisualizationKey FIEPPEJGGLF
		{
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0xBCB360", Offset = "0xBC9B60", VA = "0x180BCB360", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x2723110", Offset = "0x2721910", VA = "0x182723110")]
		public BABGDPNBPGG(CBFIFLFMBFP MPABKJPPPMM, CLPFPFHLDHK GDFCBMOFMFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "134")]
		protected override void KCBBIJPOMMB(APKPIDOBEFA NBFCHNOPHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public abstract class PPDFFPOLCBE<T> : IJIPHCJMIJF<T> where T : notnull, DOOCNODECOD
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		[CompilerGenerated]
		private sealed class BIALCKBIACL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public IReadOnlyList<KeyValuePair<string, BJCOKIAGPOC>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public PPDFFPOLCBE<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public LNHBIEKMMIC nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public NGIJPDCOOEK clipType;

			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public BIALCKBIACL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D7")]
			[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
			internal IReadOnlyList<KeyValuePair<string, BJCOKIAGPOC>> KOACCBJHCAE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0x5F19A50", Offset = "0x5F18250", VA = "0x185F19A50")]
			internal int DAJNJOHEPHE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0x5F19E40", Offset = "0x5F18640", VA = "0x185F19E40")]
			internal void LFCONHGLCKD(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0x5F19DF0", Offset = "0x5F185F0", VA = "0x185F19DF0")]
			internal void IHPGAMMHHFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x5F19C00", Offset = "0x5F18400", VA = "0x185F19C00")]
			internal void FJIIPMHGAJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x5F1A230", Offset = "0x5F18A30", VA = "0x185F1A230")]
			internal bool OJDBMGKIAGD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x5F19DA0", Offset = "0x5F185A0", VA = "0x185F19DA0")]
			internal void IHKKLMAGGNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x5F1A230", Offset = "0x5F18A30", VA = "0x185F1A230")]
			internal bool OFCNKEHMCIB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x5F1A060", Offset = "0x5F18860", VA = "0x185F1A060")]
			internal float MABDGBGKMKF()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x5F1A0B0", Offset = "0x5F188B0", VA = "0x185F1A0B0")]
			internal void MCLHFKLBCLH(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0x5F19BB0", Offset = "0x5F183B0", VA = "0x185F19BB0")]
			internal float EJJCJJJIPID()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x5F1A170", Offset = "0x5F18970", VA = "0x185F1A170")]
			internal void MNINOENIMMK(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x5F19D50", Offset = "0x5F18550", VA = "0x185F19D50")]
			internal float HCDFAFNJPCB()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x5F19990", Offset = "0x5F18190", VA = "0x185F19990")]
			internal void BBHJAPJMOLI(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override NodeVisualizationKey FIEPPEJGGLF
		{
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x10883D0", Offset = "0x1086BD0", VA = "0x1810883D0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public abstract NGIJPDCOOEK DDDMJKGGPBD
		{
			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(Slot = "140")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x558CEB0", Offset = "0x558B6B0", VA = "0x18558CEB0")]
		public PPDFFPOLCBE(CBFIFLFMBFP MPABKJPPPMM, T GDFCBMOFMFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x558C400", Offset = "0x558AC00", VA = "0x18558C400", Slot = "134")]
		protected sealed override void KCBBIJPOMMB(APKPIDOBEFA NBFCHNOPHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	private sealed class APHDFILJHEB : IJIPHCJMIJF<NPJKHCMFHOE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public override NodeVisualizationKey FIEPPEJGGLF
		{
			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0xD6D140", Offset = "0xD6B940", VA = "0x180D6D140", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x27230A0", Offset = "0x27218A0", VA = "0x1827230A0")]
		public APHDFILJHEB(CBFIFLFMBFP MPABKJPPPMM, NPJKHCMFHOE GDFCBMOFMFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public sealed class OPBGNLHFOCB : IJIPHCJMIJF<AFLEFNEHIMC>
	{
		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class GJFKKPFHDFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public OPBGNLHFOCB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public LNHBIEKMMIC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public GJFKKPFHDFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x2731A00", Offset = "0x2730200", VA = "0x182731A00")]
			internal int DAJNJOHEPHE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x2731A50", Offset = "0x2730250", VA = "0x182731A50")]
			internal void LFCONHGLCKD(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private static Dictionary<string, BJCOKIAGPOC>? INCFONAHDKN;

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x273D700", Offset = "0x273BF00", VA = "0x18273D700")]
		public OPBGNLHFOCB(CBFIFLFMBFP MPABKJPPPMM, AFLEFNEHIMC GDFCBMOFMFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x273D390", Offset = "0x273BB90", VA = "0x18273D390", Slot = "134")]
		protected override void KCBBIJPOMMB(APKPIDOBEFA NBFCHNOPHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public sealed class HOBFKHEGHFK : PPDFFPOLCBE<OFCJFAEMEGM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public override NGIJPDCOOEK DDDMJKGGPBD
		{
			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "140")]
			get
			{
				return default(NGIJPDCOOEK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x2732800", Offset = "0x2731000", VA = "0x182732800")]
		public HOBFKHEGHFK(CBFIFLFMBFP MPABKJPPPMM, OFCJFAEMEGM JLPKBNIJDEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private sealed class JCMCLELKOJA : BDPPJKIIHMO<KMFDMNOMILH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public override NodeVisualizationKey FIEPPEJGGLF
		{
			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0xBCB360", Offset = "0xBC9B60", VA = "0x180BCB360", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x2733560", Offset = "0x2731D60", VA = "0x182733560")]
		public JCMCLELKOJA(CBFIFLFMBFP MPABKJPPPMM, KMFDMNOMILH GDFCBMOFMFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "134")]
		protected override void KCBBIJPOMMB(APKPIDOBEFA NBFCHNOPHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	private sealed class EEILDDFHLFA : BDPPJKIIHMO<IBLAEBCLACC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public override NodeVisualizationKey FIEPPEJGGLF
		{
			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0xBCB360", Offset = "0xBC9B60", VA = "0x180BCB360", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x272DA70", Offset = "0x272C270", VA = "0x18272DA70")]
		public EEILDDFHLFA(CBFIFLFMBFP MPABKJPPPMM, IBLAEBCLACC GDFCBMOFMFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "134")]
		protected override void KCBBIJPOMMB(APKPIDOBEFA NBFCHNOPHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class MCKKBAFLPGI : NPDGDHKCCMH<ONOGDHGMLBH>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		[CompilerGenerated]
		private sealed class DIMMJGMFOFD
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000A5")]
			private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E7")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40001E8")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40001E9")]
				public DIMMJGMFOFD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001EA")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40001EB")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40001EC")]
				private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60003FB")]
				[Cpp2IlInjected.Address(RVA = "0x273E2B0", Offset = "0x273CAB0", VA = "0x18273E2B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003FC")]
				[Cpp2IlInjected.Address(RVA = "0xA2F200", Offset = "0xA2DA00", VA = "0x180A2F200", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public LNHBIEKMMIC nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public MCKKBAFLPGI <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public DIMMJGMFOFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x272D280", Offset = "0x272BA80", VA = "0x18272D280")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void NDLNCFEHFJN(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x27358F0", Offset = "0x27340F0", VA = "0x1827358F0")]
		public MCKKBAFLPGI(CBFIFLFMBFP MPABKJPPPMM, ONOGDHGMLBH JLPKBNIJDEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x2735610", Offset = "0x2733E10", VA = "0x182735610", Slot = "140")]
		protected override void OLPANILNBFP(APKPIDOBEFA NBFCHNOPHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class DCMGNMNJBAB : PPDFFPOLCBE<APPGICOOBAA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public override NGIJPDCOOEK DDDMJKGGPBD
		{
			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0xB705C0", Offset = "0xB6EDC0", VA = "0x180B705C0", Slot = "140")]
			get
			{
				return default(NGIJPDCOOEK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x272D220", Offset = "0x272BA20", VA = "0x18272D220")]
		public DCMGNMNJBAB(CBFIFLFMBFP MPABKJPPPMM, APPGICOOBAA JLPKBNIJDEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private sealed class CJHJJDLLCIA : IJIPHCJMIJF<HNHJDNPNLJB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public override NodeVisualizationKey FIEPPEJGGLF
		{
			[Cpp2IlInjected.Token(Token = "0x60003FF")]
			[Cpp2IlInjected.Address(RVA = "0xD57A20", Offset = "0xD56220", VA = "0x180D57A20", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x272C1C0", Offset = "0x272A9C0", VA = "0x18272C1C0")]
		public CJHJJDLLCIA(CBFIFLFMBFP MPABKJPPPMM, HNHJDNPNLJB GDFCBMOFMFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "134")]
		protected override void KCBBIJPOMMB(APKPIDOBEFA NBFCHNOPHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public sealed class PCFIPCIEOJJ : IJIPHCJMIJF<CJCGFFCMMFM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public sealed override NodeVisualizationKey FIEPPEJGGLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public sealed override bool OBLHFFDBABO
		{
			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		protected sealed override bool NAMJHKPLPCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x273DF30", Offset = "0x273C730", VA = "0x18273DF30")]
		public PCFIPCIEOJJ(CBFIFLFMBFP MPABKJPPPMM, CJCGFFCMMFM GDFCBMOFMFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x273DC60", Offset = "0x273C460", VA = "0x18273DC60", Slot = "134")]
		protected override void KCBBIJPOMMB(APKPIDOBEFA NBFCHNOPHLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x273DBC0", Offset = "0x273C3C0", VA = "0x18273DBC0")]
		private int EIILKECOMAM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x273DC00", Offset = "0x273C400", VA = "0x18273DC00")]
		private void JKANDCHAIHG(int IPCBOKHNPCP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class KOJLBEKFMBE : LELHKMLBLFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x2734150", Offset = "0x2732950", VA = "0x182734150")]
		public KOJLBEKFMBE(CBFIFLFMBFP MPABKJPPPMM, BKBACPLKPAP GDFCBMOFMFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "134")]
		protected override void KCBBIJPOMMB(APKPIDOBEFA NBFCHNOPHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public sealed class OKCKIADHGCK : NPDGDHKCCMH<JAGJFHMMNGO>
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x273CC50", Offset = "0x273B450", VA = "0x18273CC50")]
		public OKCKIADHGCK(CBFIFLFMBFP MPABKJPPPMM, JAGJFHMMNGO GDFCBMOFMFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public abstract class NPDGDHKCCMH<TVariableNode> : IJIPHCJMIJF<TVariableNode> where TVariableNode : notnull, JAGJFHMMNGO
	{
		[Cpp2IlInjected.Token(Token = "0x20000AC")]
		[CompilerGenerated]
		private sealed class GKIJPHHPGDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			public NPDGDHKCCMH<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			public LNHBIEKMMIC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public GKIJPHHPGDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0x49C2F60", Offset = "0x49C1760", VA = "0x1849C2F60")]
			internal bool KOACCBJHCAE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0x49C2D30", Offset = "0x49C1530", VA = "0x1849C2D30")]
			internal void DAJNJOHEPHE(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x49C2FC0", Offset = "0x49C17C0", VA = "0x1849C2FC0")]
			internal bool LFCONHGLCKD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x49C2EA0", Offset = "0x49C16A0", VA = "0x1849C2EA0")]
			internal void IHPGAMMHHFC(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0x49C2DF0", Offset = "0x49C15F0", VA = "0x1849C2DF0")]
			internal bool FJIIPMHGAJJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AD")]
		[CompilerGenerated]
		private sealed class LFIALCFLIMM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			public LNHBIEKMMIC nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			public NPDGDHKCCMH<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public LFIALCFLIMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0x4FDCD50", Offset = "0x4FDB550", VA = "0x184FDCD50")]
			internal void NDLNCFEHFJN(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public override NodeVisualizationKey FIEPPEJGGLF
		{
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0xBC4350", Offset = "0xBC2B50", VA = "0x180BC4350", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public override CPEEAANHNKN NHGIEAMELEF
		{
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x535A470", Offset = "0x5358C70", VA = "0x18535A470", Slot = "108")]
			get
			{
				return default(CPEEAANHNKN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x535A2D0", Offset = "0x5358AD0", VA = "0x18535A2D0")]
		protected NPDGDHKCCMH(CBFIFLFMBFP MPABKJPPPMM, TVariableNode GDFCBMOFMFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x5359880", Offset = "0x5358080", VA = "0x185359880", Slot = "101")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x5359A00", Offset = "0x5358200", VA = "0x185359A00", Slot = "134")]
		protected override void KCBBIJPOMMB(APKPIDOBEFA NBFCHNOPHLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x5359E90", Offset = "0x5358690", VA = "0x185359E90", Slot = "140")]
		protected virtual void OLPANILNBFP(APKPIDOBEFA NBFCHNOPHLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x535A220", Offset = "0x5358A20", VA = "0x18535A220", Slot = "119")]
		public override void OMPDHJNPJPG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2715990", Offset = "0x2714190", VA = "0x182715990")]
	public static DHGFIPJKDOO CJOJELENPLJ(CBFIFLFMBFP MPABKJPPPMM, BKBACPLKPAP GDFCBMOFMFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public sealed class JDAECIOJLCF : GCMFNEDFOMM, KDOIHIOKBML, IIGEGHJBEFA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public NLPIAAOFKEO<BFEAKKGKCCO> JNLNGFNNKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0xD43E80", Offset = "0xD42680", VA = "0x180D43E80", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(NLPIAAOFKEO<BFEAKKGKCCO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public NLPIAAOFKEO<NAIBBEJGHLI> MABIOELDGPB
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0xE3EBF0", Offset = "0xE3D3F0", VA = "0x180E3EBF0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(NLPIAAOFKEO<NAIBBEJGHLI>);
		}
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x27335C0", Offset = "0x2731DC0", VA = "0x1827335C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private NLPIAAOFKEO<GNIBIEHKAFH> MPLNPAKFODM
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0xD4C980", Offset = "0xD4B180", VA = "0x180D4C980")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public override NLPIAAOFKEO<GGAOHKIBKBD> NPEHLCFAENM
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x27335D0", Offset = "0x2731DD0", VA = "0x1827335D0", Slot = "21")]
		get
		{
			return default(NLPIAAOFKEO<GGAOHKIBKBD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x2733970", Offset = "0x2732170", VA = "0x182733970")]
	private JDAECIOJLCF(CBFIFLFMBFP MPABKJPPPMM, BKBACPLKPAP GDFCBMOFMFN, PACIHALIGEB DICKEBBEAPH, NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM, NLPIAAOFKEO<NAIBBEJGHLI> GHICKGEHGDH, NLPIAAOFKEO<GNIBIEHKAFH> GDHJOHGJMHC, bool KBFHNLPGBJI, string GLGOHIJMLFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x2733620", Offset = "0x2731E20", VA = "0x182733620")]
	public static JDAECIOJLCF CJOJELENPLJ(CBFIFLFMBFP MPABKJPPPMM, BKBACPLKPAP GDFCBMOFMFN, PACIHALIGEB ENLECGNCFFO, NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM, NLPIAAOFKEO<GNIBIEHKAFH> GDHJOHGJMHC, NLPIAAOFKEO<NAIBBEJGHLI> GHICKGEHGDH, bool KBFHNLPGBJI, bool IMIMPLPNBNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x27335C0", Offset = "0x2731DC0", VA = "0x1827335C0")]
	internal void ACMKOCCJANC(NLPIAAOFKEO<NAIBBEJGHLI> OPMIAMEJKDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public abstract class GCMFNEDFOMM : IIGEGHJBEFA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	private struct KNGHJCNDFMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private DCBONCPMLAB? MOMOJEKPCCH;

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x2734140", Offset = "0x2732940", VA = "0x182734140")]
		public void NNEMBDPLFBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x27340A0", Offset = "0x27328A0", VA = "0x1827340A0")]
		public DCBONCPMLAB GBCDBCBMKPP(GCMFNEDFOMM ODGJNCICLBH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	protected readonly CBFIFLFMBFP BLOIFBAMAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	protected readonly BKBACPLKPAP MOIJDLCEICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private KNGHJCNDFMJ IEIAFPEELNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private readonly ODFDNMFLKAO ALNMMPLHAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private readonly List<EPCGMNOLFKO> LPALLAJJBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly List<ALJCMHIHBFC> PCJLKMLHADG;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	[ENFMKHMGDHB("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> HBKLAEHMMMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x27310E0", Offset = "0x272F8E0", VA = "0x1827310E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public DisplayKind KEELHCJCADL
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x9EDEE0", Offset = "0x9EC6E0", VA = "0x1809EDEE0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public NLPIAAOFKEO<PAJOPNAJIFC> DOCKCOIAGNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x27310B0", Offset = "0x272F8B0", VA = "0x1827310B0", Slot = "6")]
		get
		{
			return default(NLPIAAOFKEO<PAJOPNAJIFC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public CMDPIJDKPHC<PAJOPNAJIFC> KOKAGENLDFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x2731710", Offset = "0x272FF10", VA = "0x182731710", Slot = "7")]
		get
		{
			return default(CMDPIJDKPHC<PAJOPNAJIFC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public EPHBLHJIMOD LDLJGADKHPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0xD28260", Offset = "0xD26A60", VA = "0x180D28260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public DGOLAOKNJIB ELFBFFMNNCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x2730480", Offset = "0x272EC80", VA = "0x182730480", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	protected DCBONCPMLAB LEMBAGBBNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x2730480", Offset = "0x272EC80", VA = "0x182730480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public PortImage BMLMPIGIPAM
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x27315E0", Offset = "0x272FDE0", VA = "0x1827315E0", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DD0", Offset = "0x9DF5D0", VA = "0x1809E0DD0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x9E0BB0", Offset = "0x9DF3B0", VA = "0x1809E0BB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public CMDPIJDKPHC<KGLBPIDLJAB> DOGCNJOEHHH
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x2730520", Offset = "0x272ED20", VA = "0x182730520", Slot = "9")]
		get
		{
			return default(CMDPIJDKPHC<KGLBPIDLJAB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public NLPIAAOFKEO<FGCGLNKNFGK> JOEFIFIEKKG
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0xCF7CF0", Offset = "0xCF64F0", VA = "0x180CF7CF0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(NLPIAAOFKEO<FGCGLNKNFGK>);
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0xE3E7C0", Offset = "0xE3CFC0", VA = "0x180E3E7C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public abstract NLPIAAOFKEO<GGAOHKIBKBD> NPEHLCFAENM
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x2731830", Offset = "0x2730030", VA = "0x182731830")]
	protected GCMFNEDFOMM(CBFIFLFMBFP MPABKJPPPMM, BKBACPLKPAP GDFCBMOFMFN, ODFDNMFLKAO IFDAMJHJJPI, NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM, bool KBFHNLPGBJI, string GLGOHIJMLFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x2731740", Offset = "0x272FF40", VA = "0x182731740", Slot = "22")]
	protected virtual void NPIOKLMMDIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x2730660", Offset = "0x272EE60", VA = "0x182730660", Slot = "23")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x2730540", Offset = "0x272ED40", VA = "0x182730540", Slot = "14")]
	public void CHIKLDMPOCB(EPCGMNOLFKO CEFGONEHBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x2731580", Offset = "0x272FD80", VA = "0x182731580", Slot = "15")]
	public void JJMAODLLEIM(ALJCMHIHBFC CEFGONEHBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x2730750", Offset = "0x272EF50", VA = "0x182730750", Slot = "16")]
	public void FBLINBDPNKG(JFEOKLEMHKB PIHIBDBKCCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x2731050", Offset = "0x272F850", VA = "0x182731050", Slot = "24")]
	protected virtual void FNICLKCFFGF(JFEOKLEMHKB PIHIBDBKCCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x27313F0", Offset = "0x272FBF0", VA = "0x1827313F0", Slot = "19")]
	private void JIDBCIBIEKM(bool LDIOMGMJIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x2731240", Offset = "0x272FA40", VA = "0x182731240")]
	private void JCFEABJDIBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x27302D0", Offset = "0x272EAD0", VA = "0x1827302D0")]
	private void AHLIJLOMFGA([In] FCAFBCEALEL JGLJMJEMHIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x2730600", Offset = "0x272EE00", VA = "0x182730600", Slot = "17")]
	public void DPMJHOJHAMN(EPCGMNOLFKO CEFGONEHBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x27305A0", Offset = "0x272EDA0", VA = "0x1827305A0", Slot = "18")]
	public void COLPJHNIHFA(ALJCMHIHBFC CEFGONEHBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x9E0BB0", Offset = "0x9DF3B0", VA = "0x1809E0BB0")]
	internal void JKPGBPMMECP(string GLGOHIJMLFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x2731220", Offset = "0x272FA20", VA = "0x182731220")]
	internal void HLMBPELPPCA(JIFFFPBOHLF ILEBEOADOPL, EPHBLHJIMOD PIJHKCJDAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0xE3E7C0", Offset = "0xE3CFC0", VA = "0x180E3E7C0")]
	internal void HBCGKFMHIBG(NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public sealed class OFFBJDFMAEK : FGJEEAJAKCB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class LIMIMOFJDOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public CBFIFLFMBFP circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public BKBACPLKPAP node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public NLPIAAOFKEO<FGCGLNKNFGK> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public LIMIMOFJDOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x2734250", Offset = "0x2732A50", VA = "0x182734250")]
		internal DGFCGAGPDLK GOADBGGMPIK((int PortDescIndex, int PortIndex, FKJCHPEGLLH InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x27341C0", Offset = "0x27329C0", VA = "0x1827341C0")]
		internal JDAECIOJLCF DNAGGKBDDCD(PACIHALIGEB i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct OKGLKCIKOPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public OFFBJDFMAEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private EFIIIKJACBD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x273CCB0", Offset = "0x273B4B0", VA = "0x18273CCB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x273D120", Offset = "0x273B920", VA = "0x18273D120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct AEMCOFKHOHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public OFFBJDFMAEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public NLPIAAOFKEO<IKLIGFGFCNJ> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private EFIIIKJACBD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x2721780", Offset = "0x271FF80", VA = "0x182721780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x2721AD0", Offset = "0x27202D0", VA = "0x182721AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct OHJBAGDDLBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public OFFBJDFMAEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public NLPIAAOFKEO<GNIBIEHKAFH> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private EFIIIKJACBD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x273C640", Offset = "0x273AE40", VA = "0x18273C640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x273C990", Offset = "0x273B190", VA = "0x18273C990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct BCFDMMPOGNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public OFFBJDFMAEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public NLPIAAOFKEO<IKLIGFGFCNJ> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public NLPIAAOFKEO<IKLIGFGFCNJ> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private EFIIIKJACBD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x2723170", Offset = "0x2721970", VA = "0x182723170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x27234D0", Offset = "0x2721CD0", VA = "0x1827234D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct MMLHCEHHKNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public OFFBJDFMAEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public NLPIAAOFKEO<GNIBIEHKAFH> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public NLPIAAOFKEO<GNIBIEHKAFH> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private EFIIIKJACBD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x27363A0", Offset = "0x2734BA0", VA = "0x1827363A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x2736700", Offset = "0x2734F00", VA = "0x182736700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct AJOEKDHNGJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public OFFBJDFMAEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private EFIIIKJACBD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x2722BB0", Offset = "0x27213B0", VA = "0x182722BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x2723030", Offset = "0x2721830", VA = "0x182723030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct NHFMMDJBDDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public OFFBJDFMAEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private EFIIIKJACBD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x2737120", Offset = "0x2735920", VA = "0x182737120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x2737470", Offset = "0x2735C70", VA = "0x182737470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct MNGMGOBIPKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public OFFBJDFMAEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public NLPIAAOFKEO<IKLIGFGFCNJ> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private EFIIIKJACBD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x2736850", Offset = "0x2735050", VA = "0x182736850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x2736BC0", Offset = "0x27353C0", VA = "0x182736BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct CJMPOIAMKAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public OFFBJDFMAEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public NLPIAAOFKEO<GNIBIEHKAFH> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private EFIIIKJACBD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x272C230", Offset = "0x272AA30", VA = "0x18272C230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x272C5A0", Offset = "0x272ADA0", VA = "0x18272C5A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct BIPGLPLFIPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public OFFBJDFMAEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public MACFJNEIIPE type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public NLPIAAOFKEO<IKLIGFGFCNJ> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private EFIIIKJACBD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x2723540", Offset = "0x2721D40", VA = "0x182723540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x27238E0", Offset = "0x27220E0", VA = "0x1827238E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct MHKNNCIDFIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public OFFBJDFMAEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public MACFJNEIIPE type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public NLPIAAOFKEO<GNIBIEHKAFH> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private EFIIIKJACBD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x2735C50", Offset = "0x2734450", VA = "0x182735C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x2735FF0", Offset = "0x27347F0", VA = "0x182735FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly bool PMMJCMDHMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly CBFIFLFMBFP BLOIFBAMAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private readonly bool KNEIOIHDBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private GKFCELPELJB<GJMDNLCCEPC, DGFCGAGPDLK> KLMBPCNHDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private GKFCELPELJB<GJMDNLCCEPC, HPINLINDDFK> CGHJDMBFHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private readonly BKBACPLKPAP MOIJDLCEICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private GKFCELPELJB<NAIBBEJGHLI, JDAECIOJLCF> JBAFLIBDGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private GKFCELPELJB<NAIBBEJGHLI, KDOIHIOKBML> NDBAOEKJFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	private string? IMJBDELIEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private readonly ANDADCHGJOB OOEONLAIEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private NLPIAAOFKEO<FGCGLNKNFGK> OBJJGMONKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private readonly bool LCOJMEDIJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	[CompilerGenerated]
	private Action? OJGOFGNKDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	[CompilerGenerated]
	private Action? NPDKDJNABPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	[CompilerGenerated]
	private Action<NLPIAAOFKEO<GJMDNLCCEPC>>? GHBDMCKIAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	[CompilerGenerated]
	private Action<NLPIAAOFKEO<NAIBBEJGHLI>>? GKJFALLLPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	[CompilerGenerated]
	private FGJEEAJAKCB.GOIGIGKBCDF? MKDLLGOFOPM;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool DKPCDENINBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x2739640", Offset = "0x2737E40", VA = "0x182739640", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool HHLCNPJKPAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x273C500", Offset = "0x273AD00", VA = "0x18273C500", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool OKOMBBCGDAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x2738CD0", Offset = "0x27374D0", VA = "0x182738CD0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public CMDPIJDKPHC<PAJOPNAJIFC> KOKAGENLDFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x273B890", Offset = "0x273A090", VA = "0x18273B890", Slot = "7")]
		get
		{
			return default(CMDPIJDKPHC<PAJOPNAJIFC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool EMMFMNPEPFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x2737790", Offset = "0x2735F90", VA = "0x182737790", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public GKFCELPELJB<GJMDNLCCEPC, HPINLINDDFK> MGGBGLEGENI
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770", Slot = "9")]
		get
		{
			return default(GKFCELPELJB<GJMDNLCCEPC, HPINLINDDFK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x273BD30", Offset = "0x273A530", VA = "0x18273BD30", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public CMDPIJDKPHC<KGLBPIDLJAB> DOGCNJOEHHH
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x27380F0", Offset = "0x27368F0", VA = "0x1827380F0", Slot = "11")]
		get
		{
			return default(CMDPIJDKPHC<KGLBPIDLJAB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public GKFCELPELJB<NAIBBEJGHLI, KDOIHIOKBML> IOHEIPPFBJB
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DD0", Offset = "0x9DF5D0", VA = "0x1809E0DD0", Slot = "12")]
		get
		{
			return default(GKFCELPELJB<NAIBBEJGHLI, KDOIHIOKBML>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public NLPIAAOFKEO<FGCGLNKNFGK> JOEFIFIEKKG
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0xB9D4B0", Offset = "0xB9BCB0", VA = "0x180B9D4B0", Slot = "13")]
		get
		{
			return default(NLPIAAOFKEO<FGCGLNKNFGK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action? CKMJMGFOIIO
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x273A660", Offset = "0x2738E60", VA = "0x18273A660", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x273BA80", Offset = "0x273A280", VA = "0x18273BA80", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action? EIOGIIPHMIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x273A4D0", Offset = "0x2738CD0", VA = "0x18273A4D0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x273B9D0", Offset = "0x273A1D0", VA = "0x18273B9D0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<NLPIAAOFKEO<GJMDNLCCEPC?>, NLPIAAOFKEO<GJMDNLCCEPC?>>? PMPIDBGMJFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x27384B0", Offset = "0x2736CB0", VA = "0x1827384B0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x273BB80", Offset = "0x273A380", VA = "0x18273BB80", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<NLPIAAOFKEO<GJMDNLCCEPC?>, NLPIAAOFKEO<GJMDNLCCEPC?>>? KENEOFNEHOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x27397C0", Offset = "0x2737FC0", VA = "0x1827397C0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x273A700", Offset = "0x2738F00", VA = "0x18273A700", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<NLPIAAOFKEO<NAIBBEJGHLI?>, NLPIAAOFKEO<NAIBBEJGHLI?>>? OOOFLHFMALB
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x2737BE0", Offset = "0x27363E0", VA = "0x182737BE0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x27394C0", Offset = "0x2737CC0", VA = "0x1827394C0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<NLPIAAOFKEO<NAIBBEJGHLI?>, NLPIAAOFKEO<NAIBBEJGHLI?>>? NIPCDAOEFKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x273A7C0", Offset = "0x2738FC0", VA = "0x18273A7C0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x2739700", Offset = "0x2737F00", VA = "0x182739700", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<NLPIAAOFKEO<GJMDNLCCEPC?>, HPINLINDDFK?>? BHFBBPGLLKO
	{
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x2739C80", Offset = "0x2738480", VA = "0x182739C80", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x273B180", Offset = "0x2739980", VA = "0x18273B180", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<NLPIAAOFKEO<GJMDNLCCEPC?>>? AIPPDLEOHOB
	{
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x27376D0", Offset = "0x2735ED0", VA = "0x1827376D0", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x27386A0", Offset = "0x2736EA0", VA = "0x1827386A0", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<NLPIAAOFKEO<GJMDNLCCEPC?>, HPINLINDDFK?>? EKKGMACMION
	{
		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x273B240", Offset = "0x2739A40", VA = "0x18273B240", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x27378D0", Offset = "0x27360D0", VA = "0x1827378D0", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<NLPIAAOFKEO<NAIBBEJGHLI?>, KDOIHIOKBML?>? LNJNGMKEMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x2739580", Offset = "0x2737D80", VA = "0x182739580", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x273A5A0", Offset = "0x2738DA0", VA = "0x18273A5A0", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<NLPIAAOFKEO<NAIBBEJGHLI?>>? HNMDKFBFOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x273AFA0", Offset = "0x27397A0", VA = "0x18273AFA0", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x2737810", Offset = "0x2736010", VA = "0x182737810", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<NLPIAAOFKEO<NAIBBEJGHLI?>, KDOIHIOKBML?>? ANIINCCGGME
	{
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x2737610", Offset = "0x2735E10", VA = "0x182737610", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x273A990", Offset = "0x2739190", VA = "0x18273A990", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x273C540", Offset = "0x273AD40", VA = "0x18273C540")]
	private OFFBJDFMAEK(bool KBFHNLPGBJI, CBFIFLFMBFP MPABKJPPPMM, bool CCCMADCAJOM, GKFCELPELJB<GJMDNLCCEPC, DGFCGAGPDLK> FDHEHNFLELM, GKFCELPELJB<GJMDNLCCEPC, HPINLINDDFK> MEBEFCGPCFD, BKBACPLKPAP GDFCBMOFMFN, GKFCELPELJB<NAIBBEJGHLI, JDAECIOJLCF> DKIIEIBDPOD, GKFCELPELJB<NAIBBEJGHLI, KDOIHIOKBML> AHPMDJHLLNC, string? NGNFFGELCDH, ANDADCHGJOB OEOLDHFLACK, NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM, bool IMIMPLPNBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x2738760", Offset = "0x2736F60", VA = "0x182738760")]
	public static OFFBJDFMAEK CJOJELENPLJ(bool KBFHNLPGBJI, CBFIFLFMBFP MPABKJPPPMM, bool CCCMADCAJOM, BKBACPLKPAP GDFCBMOFMFN, ANDADCHGJOB OEOLDHFLACK, NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM, bool IMIMPLPNBNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x2738EC0", Offset = "0x27376C0", VA = "0x182738EC0", Slot = "69")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x273C410", Offset = "0x273AC10", VA = "0x18273C410", Slot = "38")]
	[AsyncStateMachine(typeof(OKGLKCIKOPM))]
	public Task<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED?>>? PHMOJDFCCND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x2739E30", Offset = "0x2738630", VA = "0x182739E30")]
	private (HADDFHHDDAE?, int)? IBMAOJBNIDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x27393D0", Offset = "0x2737BD0", VA = "0x1827393D0", Slot = "58")]
	private void FBCBCIPCPJB(int KLPJCAHLIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x1F2DFA0", Offset = "0x1F2C7A0", VA = "0x181F2DFA0", Slot = "57")]
	private void ECAPFNMJJKJ(int KLPJCAHLIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x273AC00", Offset = "0x2739400", VA = "0x18273AC00", Slot = "61")]
	private void MAGNHALFPDI(int OLPLKIFIPBN, int OFLMAAAAPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x273BB20", Offset = "0x273A320", VA = "0x18273BB20", Slot = "63")]
	private void NPIJKKKPGCK(int OLPLKIFIPBN, int OFLMAAAAPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x273B300", Offset = "0x2739B00", VA = "0x18273B300", Slot = "50")]
	private void NEKBOEELJGA(int KLPJCAHLIKA, NLPIAAOFKEO<GJMDNLCCEPC> IPMBIMFONHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x2739260", Offset = "0x2737A60", VA = "0x182739260", Slot = "54")]
	private void EKHGFHLOCME(int LDIOMGMJIGF, NLPIAAOFKEO<GJMDNLCCEPC> IPMBIMFONHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x27398A0", Offset = "0x27380A0", VA = "0x1827398A0", Slot = "49")]
	private void HAFIMPEINOG(int LDIOMGMJIGF, NLPIAAOFKEO<GJMDNLCCEPC> IPMBIMFONHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x2737CA0", Offset = "0x27364A0", VA = "0x182737CA0", Slot = "53")]
	private void BKKENLJLKNP(int KLPJCAHLIKA, NLPIAAOFKEO<GJMDNLCCEPC> IPMBIMFONHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x273AAB0", Offset = "0x27392B0", VA = "0x18273AAB0", Slot = "66")]
	private void LEGFBNCLIGH(int KLPJCAHLIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x12C8770", Offset = "0x12C6F70", VA = "0x1812C8770", Slot = "65")]
	private void GKCKIOFHJHN(int KLPJCAHLIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x273BC40", Offset = "0x273A440", VA = "0x18273BC40", Slot = "60")]
	private void PAEEFBBKKGJ(int KLPJCAHLIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x1F2DFA0", Offset = "0x1F2C7A0", VA = "0x181F2DFA0", Slot = "59")]
	private void JJLONBFLFND(int KLPJCAHLIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x2738110", Offset = "0x2736910", VA = "0x182738110", Slot = "62")]
	private void CABGFIMLILI(int OLPLKIFIPBN, int OFLMAAAAPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x273AA50", Offset = "0x2739250", VA = "0x18273AA50", Slot = "64")]
	private void KKAJELHODAJ(int OLPLKIFIPBN, int OFLMAAAAPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x273BD60", Offset = "0x273A560", VA = "0x18273BD60", Slot = "52")]
	private void PEPJGCKFOGF(int KLPJCAHLIKA, NLPIAAOFKEO<NAIBBEJGHLI> IPMBIMFONHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x2739880", Offset = "0x2738080", VA = "0x182739880", Slot = "56")]
	private void GAIONALBNPL(int LDIOMGMJIGF, NLPIAAOFKEO<NAIBBEJGHLI> IPMBIMFONHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x273A580", Offset = "0x2738D80", VA = "0x18273A580", Slot = "51")]
	private void JCAAGGDBFHO(int LDIOMGMJIGF, NLPIAAOFKEO<NAIBBEJGHLI> IPMBIMFONHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x273A060", Offset = "0x2738860", VA = "0x18273A060", Slot = "55")]
	private void ILABKLKEJNC(int KLPJCAHLIKA, NLPIAAOFKEO<NAIBBEJGHLI> IPMBIMFONHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x2739280", Offset = "0x2737A80", VA = "0x182739280", Slot = "68")]
	private void EMIBIDKPFMC(int KLPJCAHLIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x12C8770", Offset = "0x12C6F70", VA = "0x1812C8770", Slot = "67")]
	private void AOAIGHJMAIO(int KLPJCAHLIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x273B8C0", Offset = "0x273A0C0", VA = "0x18273B8C0", Slot = "39")]
	[AsyncStateMachine(typeof(AEMCOFKHOHA))]
	public Task<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED?>>? NMDHNFHJAGG(NLPIAAOFKEO<IKLIGFGFCNJ> CEOGNLEJOEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x273A880", Offset = "0x2739080", VA = "0x18273A880", Slot = "40")]
	[AsyncStateMachine(typeof(OHJBAGDDLBA))]
	public Task<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED?>>? KFHDIMFKHLA(NLPIAAOFKEO<GNIBIEHKAFH> GDHJOHGJMHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x273B060", Offset = "0x2739860", VA = "0x18273B060", Slot = "41")]
	[AsyncStateMachine(typeof(BCFDMMPOGNF))]
	public Task<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED?>>? MJMNJALCEFM(NLPIAAOFKEO<IKLIGFGFCNJ> CEOGNLEJOEB, NLPIAAOFKEO<IKLIGFGFCNJ> HBHPBLHBACM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x2737AC0", Offset = "0x27362C0", VA = "0x182737AC0", Slot = "42")]
	[AsyncStateMachine(typeof(MMLHCEHHKNC))]
	public Task<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED?>>? BKEOLMFLAID(NLPIAAOFKEO<GNIBIEHKAFH> GDHJOHGJMHC, NLPIAAOFKEO<GNIBIEHKAFH> HBHPBLHBACM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x2739D40", Offset = "0x2738540", VA = "0x182739D40", Slot = "43")]
	[AsyncStateMachine(typeof(AJOEKDHNGJK))]
	public Task<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED?>>? HHEJIBLHFEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x273C2F0", Offset = "0x273AAF0", VA = "0x18273C2F0", Slot = "44")]
	[AsyncStateMachine(typeof(NHFMMDJBDDA))]
	public Task<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> PGGICCFMKJK(string MJDGICLIAKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x2737990", Offset = "0x2736190", VA = "0x182737990", Slot = "45")]
	[AsyncStateMachine(typeof(MNGMGOBIPKN))]
	public Task<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> BFPDMNMNHDH(NLPIAAOFKEO<IKLIGFGFCNJ> CEOGNLEJOEB, string GLGOHIJMLFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x2738D90", Offset = "0x2737590", VA = "0x182738D90", Slot = "46")]
	[AsyncStateMachine(typeof(CJMPOIAMKAD))]
	public Task<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> DNBPCAKCMOH(NLPIAAOFKEO<GNIBIEHKAFH> GDHJOHGJMHC, string GLGOHIJMLFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x2738570", Offset = "0x2736D70", VA = "0x182738570", Slot = "47")]
	[AsyncStateMachine(typeof(BIPGLPLFIPF))]
	public Task<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> CILDOABNCJH(NLPIAAOFKEO<IKLIGFGFCNJ> CEOGNLEJOEB, MACFJNEIIPE PIJHKCJDAHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x27374E0", Offset = "0x2735CE0", VA = "0x1827374E0", Slot = "48")]
	[AsyncStateMachine(typeof(MHKNNCIDFIM))]
	public Task<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> AAGNJIJAOJL(NLPIAAOFKEO<GNIBIEHKAFH> GDHJOHGJMHC, MACFJNEIIPE PIJHKCJDAHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x27398C0", Offset = "0x27380C0", VA = "0x1827398C0")]
	internal void HBCGKFMHIBG(NLPIAAOFKEO<FGCGLNKNFGK> OPMIAMEJKDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public sealed class CJDNHKNDDJI : BGNIJNAIFMH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public interface DFEGMMCMEBF
	{
		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		public readonly struct KBEKLAPFCJM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400026B")]
			public readonly IReadOnlyDictionary<CMDPIJDKPHC<PAJOPNAJIFC>, Guid>? MOFHPAMHGEN;

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0xCEDE50", Offset = "0xCEC650", VA = "0x180CEDE50")]
			public KBEKLAPFCJM(IReadOnlyDictionary<CMDPIJDKPHC<PAJOPNAJIFC>, Guid>? MOFHPAMHGEN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		JIFFFPBOHLF ONCFELJBOOD
		{
			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<AMFIADCCEFK> ECOPDNEIKGA(CancellationToken DNHBNMHIDAC);

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<NLICKNHNJCI> FICCCKHMAAD(CancellationToken DNHBNMHIDAC);

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<EBGFOJACALK> OOLFLDFIIHO(CancellationToken DNHBNMHIDAC);

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<OKGNGFGOKMI> KKLJIDNBCNI(CancellationToken DNHBNMHIDAC);

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<KBEKLAPFCJM> KIEBJHMNOKJ(CancellationToken DNHBNMHIDAC);

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<LGGGJOHAFMK> GKPILJNEPBL(CancellationToken DNHBNMHIDAC);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct GBHADFHJCCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public AsyncTaskMethodBuilder<CJDNHKNDDJI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public CBFIFLFMBFP circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public AMFIADCCEFK roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public NLICKNHNJCI superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private DFEGMMCMEBF <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private AMFIADCCEFK <downloadedRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private AMFIADCCEFK <actualRoomData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private LGGGJOHAFMK <actualStaticConfig>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private NLICKNHNJCI <finalSuperRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private EBGFOJACALK <roomAssetData>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private OKGNGFGOKMI <playerSaveData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private TaskAwaiter<AMFIADCCEFK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private AMFIADCCEFK <>7__wrap8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private TaskAwaiter<LGGGJOHAFMK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private TaskAwaiter<NLICKNHNJCI> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private TaskAwaiter<EBGFOJACALK> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private TaskAwaiter<OKGNGFGOKMI> <>u__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private TaskAwaiter<DFEGMMCMEBF.KBEKLAPFCJM> <>u__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private TaskAwaiter<KKGMNBFIOAK> <>u__7;

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x272F1B0", Offset = "0x272D9B0", VA = "0x18272F1B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x2730260", Offset = "0x272EA60", VA = "0x182730260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private readonly KKGMNBFIOAK LHHEKFOMBGA;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public KKGMNBFIOAK LIOODFBMCMP
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x9EBB90", Offset = "0x9EA390", VA = "0x1809EBB90")]
	private CJDNHKNDDJI(KKGMNBFIOAK MCEDPOCFAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x272C030", Offset = "0x272A830", VA = "0x18272C030")]
	[AsyncStateMachine(typeof(GBHADFHJCCD))]
	public static Task<CJDNHKNDDJI> BDDBDKBBGDP(CBFIFLFMBFP MPABKJPPPMM, AMFIADCCEFK? PDNEBCPKAAP, NLICKNHNJCI? GDDBLNGCPFI, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x272C1A0", Offset = "0x272A9A0", VA = "0x18272C1A0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public readonly struct EIILBEGKKNL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private struct MFAFEGEAGDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<object, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public EIILBEGKKNL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public IOPMFGMDJPO action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private TaskAwaiter<HCGBMJDNFKJ<object, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x2735950", Offset = "0x2734150", VA = "0x182735950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x2735BE0", Offset = "0x27343E0", VA = "0x182735BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private struct PALPMDDEING : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<bool, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public KKMNDMIFHBK rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public AMFIADCCEFK circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public NLICKNHNJCI superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public EIILBEGKKNL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private IOPMFGMDJPO[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private TaskAwaiter<HCGBMJDNFKJ<object, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x273D770", Offset = "0x273BF70", VA = "0x18273D770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x273DB50", Offset = "0x273C350", VA = "0x18273DB50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private struct AGOIOLPEGNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public EIILBEGKKNL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private TaskAwaiter<HCGBMJDNFKJ<object, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x2721B40", Offset = "0x2720340", VA = "0x182721B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x2721D80", Offset = "0x2720580", VA = "0x182721D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	private readonly PPIFDECMEOD BBCGLOPJCNJ;

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0xCEDE50", Offset = "0xCEC650", VA = "0x180CEDE50")]
	public EIILBEGKKNL(PPIFDECMEOD JKJNCGNOMJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x272DCB0", Offset = "0x272C4B0", VA = "0x18272DCB0")]
	[AsyncStateMachine(typeof(MFAFEGEAGDP))]
	private Task<HCGBMJDNFKJ<object, CPMHOEMAGED>> HEBGMLAKBNB(IOPMFGMDJPO GFMBHCHPLDH, bool EOPFBMLNBOG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x272DB50", Offset = "0x272C350", VA = "0x18272DB50")]
	[AsyncStateMachine(typeof(PALPMDDEING))]
	public Task<HCGBMJDNFKJ<bool, CPMHOEMAGED?>>? BHPEIOGBDKN(int KOLPKELACKA, KKMNDMIFHBK? EIJIJJNENOI, AMFIADCCEFK? HDKGPBDFDHD, NLICKNHNJCI? GDDBLNGCPFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x272DDE0", Offset = "0x272C5E0", VA = "0x18272DDE0")]
	[AsyncStateMachine(typeof(AGOIOLPEGNN))]
	public Task<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> KNAKPKDGKOD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public sealed class NGCAINLKHEI : BDKILJGICFC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private readonly KAJKCFDLHBD JNJEEIJCBBG;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public KAJKCFDLHBD DNFAFJKCEFD
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x9EBB90", Offset = "0x9EA390", VA = "0x1809EBB90")]
	private NGCAINLKHEI(KAJKCFDLHBD MDGECDCFIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x2736F30", Offset = "0x2735730", VA = "0x182736F30")]
	public static NGCAINLKHEI MPBEICGIKAG(CBFIFLFMBFP MPABKJPPPMM, KKMNDMIFHBK JAOMGMGEKCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x2736F10", Offset = "0x2735710", VA = "0x182736F10", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public interface CEPMGLFFGOE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	KKGMNBFIOAK LIOODFBMCMP
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	DKODMLGEKLD FGOIDKCKPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	HKJENCNKGDD KIIBBHPLCNC
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	CEAAAOGMPJE GACKNFEGFDP
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public interface FPOFNHLILIO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	CEPMGLFFGOE? BHKCDLNICII
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	bool ABPKKBNEOIA
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	bool PHIBMLBJJJF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<CEPMGLFFGOE?>? JOLHKADGHAK();

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task HIAIDEEKLJH(CBFIFLFMBFP MPABKJPPPMM, KKMNDMIFHBK JAOMGMGEKCK, AMFIADCCEFK? OJAGEHDBKCB, NLICKNHNJCI? DMEFGCOJFLE);
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[OKIIAHNJPLO("IStaticCV2Instance")]
public interface BGNIJNAIFMH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	KKGMNBFIOAK LIOODFBMCMP
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[OKIIAHNJPLO("IStaticEVInstance")]
public interface BDKILJGICFC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	KAJKCFDLHBD DNFAFJKCEFD
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public static class INMBLOAOEGI
{
	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x27330B0", Offset = "0x27318B0", VA = "0x1827330B0")]
	public static LAEAOCNGGLP<GAACMGKKDOM, IOPMFGMDJPO, CBFIFLFMBFP, APKEIIBCNIN.OAGAKJIEFFI<GAACMGKKDOM, IOPMFGMDJPO, CBFIFLFMBFP>> PHPEGMGKKHH([In] this LAEAOCNGGLP<GAACMGKKDOM, IOPMFGMDJPO, CBFIFLFMBFP, APKEIIBCNIN.OAGAKJIEFFI<GAACMGKKDOM, IOPMFGMDJPO, CBFIFLFMBFP>> GAGADOCFNHD)
	{
		return default(LAEAOCNGGLP<GAACMGKKDOM, IOPMFGMDJPO, CBFIFLFMBFP, APKEIIBCNIN.OAGAKJIEFFI<GAACMGKKDOM, IOPMFGMDJPO, CBFIFLFMBFP>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public sealed class JEKNKGEOKNH : EGNLCNDIMEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private readonly CBFIFLFMBFP BLOIFBAMAPA;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool PHIBMLBJJJF
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x2733C60", Offset = "0x2732460", VA = "0x182733C60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x9EBB90", Offset = "0x9EA390", VA = "0x1809EBB90")]
	internal JEKNKGEOKNH(CBFIFLFMBFP MPABKJPPPMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal sealed class MKHEPIGPCEP : DOPHMIAHEOA
{
	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x2736300", Offset = "0x2734B00", VA = "0x182736300", Slot = "4")]
	public GANHOMKGNKF? FNOEOPNKFFA(string? IKMNCDLIGOC, string? OIOALCPOHIC, string? KKIIGLPKLJN, AAMCMCBKMCH.BAJLEHEEFAE.EEECPMDKPIP LHIHNPKBEBN, bool NMJKALOCFPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public MKHEPIGPCEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public sealed class HEPLNLFDILK : NKMHAEJCNNL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[CompilerGenerated]
	private struct AHNHLGPADFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public AsyncTaskMethodBuilder<LNOMLFPCEKA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public HEPLNLFDILK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private TaskAwaiter<CEPMGLFFGOE?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x2721DF0", Offset = "0x27205F0", VA = "0x182721DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x2722090", Offset = "0x2720890", VA = "0x182722090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private readonly CBFIFLFMBFP BLOIFBAMAPA;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public LNOMLFPCEKA? DJLOIKDDKCN
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x2732310", Offset = "0x2730B10", VA = "0x182732310", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public CEAAAOGMPJE? GCFGCDMPNNH
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x2731CC0", Offset = "0x27304C0", VA = "0x182731CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool MALOHPFBHMB
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x2731EE0", Offset = "0x27306E0", VA = "0x182731EE0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool HACGBGEJANP
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x27322B0", Offset = "0x2730AB0", VA = "0x1827322B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x2732620", Offset = "0x2730E20", VA = "0x182732620")]
	internal HEPLNLFDILK(CBFIFLFMBFP MPABKJPPPMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x2732390", Offset = "0x2730B90", VA = "0x182732390", Slot = "7")]
	[AsyncStateMachine(typeof(AHNHLGPADFI))]
	public Task<LNOMLFPCEKA> PGNHLCDMODB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x2731F40", Offset = "0x2730740", VA = "0x182731F40", Slot = "9")]
	public IReadOnlyDictionary<CMDPIJDKPHC<PAJOPNAJIFC>, Guid> MFBJNNBLNJC(IEnumerable<PEBBACKHDPF> BMMMEMHMDOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x2731B40", Offset = "0x2730340", VA = "0x182731B40", Slot = "10")]
	public AGFPIOEDIOH ACDDDCIOMKH(IEnumerable<PEBBACKHDPF> BMMMEMHMDOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x2732480", Offset = "0x2730C80", VA = "0x182732480")]
	public HCGBMJDNFKJ<OJHIAMHDFFC, IGEMMGEDLOA> PKEBJMOEKJA([In] OJHIAMHDFFC DIGEMFOEKPA)
	{
		return default(HCGBMJDNFKJ<OJHIAMHDFFC, IGEMMGEDLOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x2731D40", Offset = "0x2730540", VA = "0x182731D40", Slot = "8")]
	private HCGBMJDNFKJ<OJHIAMHDFFC, IGEMMGEDLOA> EAJJONIIBDM([In] OJHIAMHDFFC DIGEMFOEKPA)
	{
		return default(HCGBMJDNFKJ<OJHIAMHDFFC, IGEMMGEDLOA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class CEAAAOGMPJE : LNOMLFPCEKA
{
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	internal static class NOPEFEGEKHK
	{
		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		[CompilerGenerated]
		private sealed class BGFNHHDIMIM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002A9")]
			public KKGMNBFIOAK state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002AA")]
			public AJBGCNAPMOH spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x6000554")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public BGFNHHDIMIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000555")]
			[Cpp2IlInjected.Address(RVA = "0x27413D0", Offset = "0x273FBD0", VA = "0x1827413D0")]
			internal bool MOKBHOLEKEO(MPFOGNHLCKF n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D6")]
		[CompilerGenerated]
		private sealed class BGMFDHDILKK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002AB")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x6000556")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public BGMFDHDILKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000557")]
			[Cpp2IlInjected.Address(RVA = "0x2741870", Offset = "0x2740070", VA = "0x182741870")]
			internal void HOEFEJHNGNA(MPFOGNHLCKF n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x2749B30", Offset = "0x2748330", VA = "0x182749B30")]
		public static HCGBMJDNFKJ<LNOMLFPCEKA.PEBGFHPEMLE, PBBGHPPLFHN> OEANMMBFPHG(CEAAAOGMPJE NFOGFJOGLPE, [In] LNOMLFPCEKA.FOEADAGDPBH FHMAIKMLNLH)
		{
			return default(HCGBMJDNFKJ<LNOMLFPCEKA.PEBGFHPEMLE, PBBGHPPLFHN>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x2748320", Offset = "0x2746B20", VA = "0x182748320")]
		internal static HCGBMJDNFKJ<(KDMMMAOIHGM, PJFHBAHAHKH), PBBGHPPLFHN> BFGMCJJGALE(CEAAAOGMPJE NFOGFJOGLPE, PJFHBAHAHKH EPAMADLDNAL, bool CFACEGOKIHJ, [In] CMDPIJDKPHC<PAJOPNAJIFC> MPAKIJLKONI, [In] int? PDADCCBIHPC, [In] CLHPMEOLFDE? OECCLNEGHCA, [In] CLHPMEOLFDE? JOPHPIINNCI)
		{
			return default(HCGBMJDNFKJ<(KDMMMAOIHGM, PJFHBAHAHKH), PBBGHPPLFHN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x2749590", Offset = "0x2747D90", VA = "0x182749590")]
		private static void HONFPGGABPE(bool CFACEGOKIHJ, PEBBACKHDPF GIKOLFBJMJH, KDMMMAOIHGM GFLANINLPGD, [In] CMDPIJDKPHC<PAJOPNAJIFC> MPAKIJLKONI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x2749190", Offset = "0x2747990", VA = "0x182749190")]
		public static void CMKKODGEAHA(JLGDGBCLLFJ MNOFGLNLFAJ, [In] LNOMLFPCEKA.ADNONMJPFKI KHFFGLKDNBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x2749A10", Offset = "0x2748210", VA = "0x182749A10")]
		[CompilerGenerated]
		internal static bool NDDPJCNFCAJ(KKGMNBFIOAK DNBCBLACNPG, AJBGCNAPMOH DNHMAELHDCO, MPFOGNHLCKF BHPBEFFBJML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x2749B00", Offset = "0x2748300", VA = "0x182749B00")]
		[CompilerGenerated]
		internal static bool NDPIFAJPPGA(MPFOGNHLCKF HGAAJHCCLOF)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct EKHOLPICANF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public CEAAAOGMPJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public NLPIAAOFKEO<PAJOPNAJIFC> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public NLPIAAOFKEO<KGLBPIDLJAB> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public DLGDAHEMPMJ offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public bool deleteBoard;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x27447F0", Offset = "0x2742FF0", VA = "0x1827447F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x2744A40", Offset = "0x2743240", VA = "0x182744A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct HMFFDLOHCLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public CEAAAOGMPJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public NLPIAAOFKEO<PAJOPNAJIFC> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public CMDPIJDKPHC<KGLBPIDLJAB> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public List<NLPIAAOFKEO<KGLBPIDLJAB>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public DLGDAHEMPMJ localBoardPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public DGDOFNPFHCD localBoardRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public DLGDAHEMPMJ offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x2745D20", Offset = "0x2744520", VA = "0x182745D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x2745FE0", Offset = "0x27447E0", VA = "0x182745FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct PHAGABJMMPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public CEAAAOGMPJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public NLPIAAOFKEO<PAJOPNAJIFC> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public CMDPIJDKPHC<KGLBPIDLJAB> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public List<NLPIAAOFKEO<KGLBPIDLJAB>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x274A420", Offset = "0x2748C20", VA = "0x18274A420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x274A660", Offset = "0x2748E60", VA = "0x18274A660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private struct FDKLCEFCMCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public CEAAAOGMPJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public NLPIAAOFKEO<PAJOPNAJIFC> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public CMDPIJDKPHC<KGLBPIDLJAB> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public NLPIAAOFKEO<PAJOPNAJIFC> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public List<NLPIAAOFKEO<KGLBPIDLJAB>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x2744AB0", Offset = "0x27432B0", VA = "0x182744AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x2744CF0", Offset = "0x27434F0", VA = "0x182744CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct MKMGAHJLPIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public CEAAAOGMPJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public CMDPIJDKPHC<PAJOPNAJIFC> legacyGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public CMDPIJDKPHC<KGLBPIDLJAB> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public IReadOnlyList<CMDPIJDKPHC<KGLBPIDLJAB>> nodeLegacyIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public IReadOnlyDictionary<EEAIELAINJC, (NLPIAAOFKEO<FGCGLNKNFGK>, NLPIAAOFKEO<GJMDNLCCEPC>)> inputMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public IReadOnlyDictionary<BHFNEOOOOJD, (NLPIAAOFKEO<FGCGLNKNFGK>, NLPIAAOFKEO<NAIBBEJGHLI>)> outputMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x2747380", Offset = "0x2745B80", VA = "0x182747380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x2747930", Offset = "0x2746130", VA = "0x182747930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[CompilerGenerated]
	private struct DDGPHEFGACA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public CEAAAOGMPJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public NLPIAAOFKEO<PAJOPNAJIFC> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public NLPIAAOFKEO<BFEAKKGKCCO> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public NLPIAAOFKEO<GCOKIOOPJJN> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x2743960", Offset = "0x2742160", VA = "0x182743960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x2743FB0", Offset = "0x27427B0", VA = "0x182743FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private struct GLFLCGLBKAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<NLPIAAOFKEO<KGLBPIDLJAB>, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public CEAAAOGMPJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public NLPIAAOFKEO<PAJOPNAJIFC> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public NLPIAAOFKEO<AGEMPNFBJCE> nodeDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public DLGDAHEMPMJ localSpacePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public DGDOFNPFHCD localSpaceRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private KKGMNBFIOAK <state>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private TaskAwaiter<HCGBMJDNFKJ<Guid, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x2745830", Offset = "0x2744030", VA = "0x182745830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x2745CB0", Offset = "0x27444B0", VA = "0x182745CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private struct JPKDKEJIIBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<NLPIAAOFKEO<FGCGLNKNFGK>, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public CEAAAOGMPJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public NLPIAAOFKEO<PAJOPNAJIFC> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public NLPIAAOFKEO<KGLBPIDLJAB> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private TaskAwaiter<HCGBMJDNFKJ<NLPIAAOFKEO<FGCGLNKNFGK>, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x2746B00", Offset = "0x2745300", VA = "0x182746B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x2746DA0", Offset = "0x27455A0", VA = "0x182746DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[CompilerGenerated]
	private struct BGJCNGNDINF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public CEAAAOGMPJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public CMDPIJDKPHC<KGLBPIDLJAB> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public CMDPIJDKPHC<PAJOPNAJIFC> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public NLPIAAOFKEO<FGCGLNKNFGK> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public NLPIAAOFKEO<GJMDNLCCEPC> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x27414C0", Offset = "0x273FCC0", VA = "0x1827414C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x2741800", Offset = "0x2740000", VA = "0x182741800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[CompilerGenerated]
	private struct ODEGMKCDCML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public CEAAAOGMPJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public CMDPIJDKPHC<KGLBPIDLJAB> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public CMDPIJDKPHC<PAJOPNAJIFC> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public NLPIAAOFKEO<FGCGLNKNFGK> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public NLPIAAOFKEO<NAIBBEJGHLI> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x274A070", Offset = "0x2748870", VA = "0x18274A070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x274A3B0", Offset = "0x2748BB0", VA = "0x18274A3B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	[CompilerGenerated]
	private struct AIKFFBPJIAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public CEAAAOGMPJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public NLPIAAOFKEO<PAJOPNAJIFC> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public NLPIAAOFKEO<KGLBPIDLJAB> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x27408F0", Offset = "0x273F0F0", VA = "0x1827408F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x2740BE0", Offset = "0x273F3E0", VA = "0x182740BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[CompilerGenerated]
	private struct FLFCOILLLEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<IEnumerable<CMDPIJDKPHC<KGLBPIDLJAB>>, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public CEAAAOGMPJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public CMDPIJDKPHC<PAJOPNAJIFC> intoGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public IEnumerable<PEBBACKHDPF> persistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public PJFHBAHAHKH templateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private TaskAwaiter<HCGBMJDNFKJ<IEnumerable<BKBACPLKPAP>, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x2744D60", Offset = "0x2743560", VA = "0x182744D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x27453E0", Offset = "0x2743BE0", VA = "0x1827453E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[CompilerGenerated]
	private sealed class BMILCMIGJBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public CEAAAOGMPJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public NLPIAAOFKEO<PAJOPNAJIFC> sourceGraphId;

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public BMILCMIGJBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x2741B80", Offset = "0x2740380", VA = "0x182741B80")]
		internal CMDPIJDKPHC<KGLBPIDLJAB> NGNJKBOHOON(NLPIAAOFKEO<KGLBPIDLJAB> i)
		{
			return default(CMDPIJDKPHC<KGLBPIDLJAB>);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private struct DGKELHJJBLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public CEAAAOGMPJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x2744560", Offset = "0x2742D60", VA = "0x182744560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x2744780", Offset = "0x2742F80", VA = "0x182744780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private struct PKIADJNMLED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public CEAAAOGMPJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public NLPIAAOFKEO<PAJOPNAJIFC> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public NLPIAAOFKEO<KGLBPIDLJAB> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x274A7E0", Offset = "0x2748FE0", VA = "0x18274A7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x274AA80", Offset = "0x2749280", VA = "0x18274AA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private struct FNOHLMGGECA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public CEAAAOGMPJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public NLPIAAOFKEO<PAJOPNAJIFC> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public NLPIAAOFKEO<KGLBPIDLJAB> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public NLPIAAOFKEO<FGCGLNKNFGK> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public NLPIAAOFKEO<IKLIGFGFCNJ> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x2745450", Offset = "0x2743C50", VA = "0x182745450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x27457C0", Offset = "0x2743FC0", VA = "0x1827457C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[CompilerGenerated]
	private struct DEAONNKKAFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public CEAAAOGMPJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public NLPIAAOFKEO<PAJOPNAJIFC> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public NLPIAAOFKEO<KGLBPIDLJAB> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public NLPIAAOFKEO<FGCGLNKNFGK> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public NLPIAAOFKEO<IKLIGFGFCNJ> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x2744020", Offset = "0x2742820", VA = "0x182744020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x2744490", Offset = "0x2742C90", VA = "0x182744490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private struct CPAFJDMKEBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public CEAAAOGMPJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public NLPIAAOFKEO<PAJOPNAJIFC> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public NLPIAAOFKEO<KGLBPIDLJAB> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x2741C70", Offset = "0x2740470", VA = "0x182741C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x2741F10", Offset = "0x2740710", VA = "0x182741F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private struct ADGIPLLPLFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public CEAAAOGMPJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public NLPIAAOFKEO<PAJOPNAJIFC> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public NLPIAAOFKEO<KGLBPIDLJAB> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public DLGDAHEMPMJ localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public DGDOFNPFHCD localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		private TaskAwaiter<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x2740530", Offset = "0x273ED30", VA = "0x182740530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x2740880", Offset = "0x273F080", VA = "0x182740880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	private readonly CBFIFLFMBFP BLOIFBAMAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	private readonly BGNIJNAIFMH KMOOMFFELMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	private readonly BDKILJGICFC BDMDEKOHLPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	private readonly LEJEKGLGKAJ PELJFHAIADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	private readonly HEPLNLFDILK HPCJFEGAPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	private Dictionary<CMDPIJDKPHC<KGLBPIDLJAB>, DHGFIPJKDOO> HOPNPHNBMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	[CompilerGenerated]
	private Action<CMDPIJDKPHC<KGLBPIDLJAB>>? BNBPBCEADKI;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public CMDPIJDKPHC<PAJOPNAJIFC> MBDHHMFCGBC
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x272AED0", Offset = "0x27296D0", VA = "0x18272AED0", Slot = "4")]
		get
		{
			return default(CMDPIJDKPHC<PAJOPNAJIFC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public LEJEKGLGKAJ IJGOAFCOHJP
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x270F0A0", Offset = "0x270D8A0", VA = "0x18270F0A0", Slot = "5")]
		get
		{
			return default(LEJEKGLGKAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x272BB10", Offset = "0x272A310", VA = "0x18272BB10")]
	public CEAAAOGMPJE(CBFIFLFMBFP MPABKJPPPMM, BGNIJNAIFMH GIPBFFNFCDJ, BDKILJGICFC FJHHGGJIIPM, HEPLNLFDILK NKHFOLAJEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x2725270", Offset = "0x2723A70", VA = "0x182725270", Slot = "83")]
	public NLPIAAOFKEO<LHDAOLHHICL> CHOBAPLFOGD(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<GCOKIOOPJJN> ECEBGAIHGFC)
	{
		return default(NLPIAAOFKEO<LHDAOLHHICL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x2725A30", Offset = "0x2724230", VA = "0x182725A30", Slot = "84")]
	public NLPIAAOFKEO<EKLADAEAEJL> DIENDENGPIO(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<BFEAKKGKCCO> GHICKGEHGDH)
	{
		return default(NLPIAAOFKEO<EKLADAEAEJL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x2725AB0", Offset = "0x27242B0", VA = "0x182725AB0", Slot = "6")]
	public (bool, bool) DJDDHDAJBJF(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<BFEAKKGKCCO> HHLKACCBEBO, NLPIAAOFKEO<GCOKIOOPJJN> AJOCPGOGBJH)
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x2727BC0", Offset = "0x27263C0", VA = "0x182727BC0")]
	public bool HDPBHKOMFKE(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, [In] BFLIFCJLFIG KICCNODEDJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x2728FB0", Offset = "0x27277B0", VA = "0x182728FB0", Slot = "8")]
	public bool IMDOINPENNG(HPINLINDDFK GCACDACDNFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x272A380", Offset = "0x2728B80", VA = "0x18272A380", Slot = "9")]
	public bool MENJCLKEAJH(KDOIHIOKBML FNGLGCODPFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x272A2C0", Offset = "0x2728AC0", VA = "0x18272A2C0", Slot = "10")]
	public FAKBIAPNDBI? LJNMMNCKCMD(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<GCOKIOOPJJN> ECEBGAIHGFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x2723EF0", Offset = "0x27226F0", VA = "0x182723EF0", Slot = "11")]
	public IEAFAGIFLIG? AHICGLLDMEL(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<BFEAKKGKCCO> GHICKGEHGDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x272AE40", Offset = "0x2729640", VA = "0x18272AE40", Slot = "12")]
	public NLPIAAOFKEO<BFEAKKGKCCO>? PAIONAHLBIA(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA, NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM, NLPIAAOFKEO<NAIBBEJGHLI> ANCLACDALFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x2728BC0", Offset = "0x27273C0", VA = "0x182728BC0", Slot = "13")]
	public NLPIAAOFKEO<GCOKIOOPJJN>? ICOHMNBHBAB(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA, NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM, NLPIAAOFKEO<GJMDNLCCEPC> KFAILCHCEPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x2729090", Offset = "0x2727890", VA = "0x182729090", Slot = "14")]
	public IEnumerable<NLPIAAOFKEO<PAJOPNAJIFC>> JBPKFAPAKBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x2726270", Offset = "0x2724A70", VA = "0x182726270", Slot = "15")]
	public IEnumerable<NLPIAAOFKEO<OLKHJIDMFKJ>> DOJEJOPLOCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x2724500", Offset = "0x2722D00", VA = "0x182724500", Slot = "16")]
	public string BIBNODLOHML(NLPIAAOFKEO<OLKHJIDMFKJ> HPELDEPGIDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x2728700", Offset = "0x2726F00", VA = "0x182728700", Slot = "17")]
	public string HLDHEFGEJPI(NLPIAAOFKEO<OLKHJIDMFKJ> HPELDEPGIDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x2725090", Offset = "0x2723890", VA = "0x182725090")]
	public DHGFIPJKDOO? CGLOJOJNFLM([In] CMDPIJDKPHC<KGLBPIDLJAB> OPPFCAMGFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x2724480", Offset = "0x2722C80", VA = "0x182724480", Slot = "23")]
	public NLPIAAOFKEO<AGEMPNFBJCE> BEKGKNOMHLB(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA)
	{
		return default(NLPIAAOFKEO<AGEMPNFBJCE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x272A6A0", Offset = "0x2728EA0", VA = "0x18272A6A0")]
	public NLPIAAOFKEO<KGLBPIDLJAB> NELDKIGOEEN(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, [In] CMDPIJDKPHC<KGLBPIDLJAB> PIBPFLDBKPD)
	{
		return default(NLPIAAOFKEO<KGLBPIDLJAB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x2726C20", Offset = "0x2725420", VA = "0x182726C20", Slot = "33")]
	public NLPIAAOFKEO<KGLBPIDLJAB> FFMJAHGKNNP(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<GCOKIOOPJJN> ECEBGAIHGFC)
	{
		return default(NLPIAAOFKEO<KGLBPIDLJAB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x272AA90", Offset = "0x2729290", VA = "0x18272AA90", Slot = "34")]
	public NLPIAAOFKEO<KGLBPIDLJAB> OECNGFDBNKP(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<BFEAKKGKCCO> GHICKGEHGDH)
	{
		return default(NLPIAAOFKEO<KGLBPIDLJAB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x27270D0", Offset = "0x27258D0", VA = "0x1827270D0")]
	public NLPIAAOFKEO<KGLBPIDLJAB>? GBBDGFMMNHB(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, [In] CMDPIJDKPHC<KGLBPIDLJAB> PIBPFLDBKPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x2726FA0", Offset = "0x27257A0", VA = "0x182726FA0", Slot = "25")]
	public MBFGLBMKLDO? FJJEDOAOAKP(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x2728C50", Offset = "0x2727450", VA = "0x182728C50", Slot = "26")]
	public long IHPHPNEHJAA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x2728F20", Offset = "0x2727720", VA = "0x182728F20")]
	private void ILCIDLLBOBD(CMDPIJDKPHC<KGLBPIDLJAB> OPPFCAMGFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x2729250", Offset = "0x2727A50", VA = "0x182729250", Slot = "31")]
	public IEnumerable<(NLPIAAOFKEO<PAJOPNAJIFC>, NLPIAAOFKEO<KGLBPIDLJAB>)> JPBFLHMNNAJ(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x2728B30", Offset = "0x2727330", VA = "0x182728B30", Slot = "32")]
	public NLPIAAOFKEO<GCOKIOOPJJN> ICOHMNBHBAB(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA, NLPIAAOFKEO<LHDAOLHHICL> KFAILCHCEPI)
	{
		return default(NLPIAAOFKEO<GCOKIOOPJJN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x272ADB0", Offset = "0x27295B0", VA = "0x18272ADB0", Slot = "35")]
	public NLPIAAOFKEO<BFEAKKGKCCO> PAIONAHLBIA(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA, NLPIAAOFKEO<EKLADAEAEJL> ANCLACDALFJ)
	{
		return default(NLPIAAOFKEO<BFEAKKGKCCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x2728CB0", Offset = "0x27274B0", VA = "0x182728CB0")]
	private DHGFIPJKDOO? IJNJJBMBPLI([In] CMDPIJDKPHC<KGLBPIDLJAB> OPPFCAMGFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x2724380", Offset = "0x2722B80", VA = "0x182724380")]
	public BKBACPLKPAP? AOILBJINMJI([In] CMDPIJDKPHC<KGLBPIDLJAB> OPPFCAMGFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x272A210", Offset = "0x2728A10", VA = "0x18272A210")]
	public OGLLKKPOEEN? MCJEFAEFJMA([In] CMDPIJDKPHC<PAJOPNAJIFC> FOEJGIIEFNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x2727610", Offset = "0x2725E10", VA = "0x182727610", Slot = "27")]
	public IEnumerable<PKIPLDOOGNO> GEOGAFHLJGI(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x2723A70", Offset = "0x2722270", VA = "0x182723A70", Slot = "28")]
	public bool AFDCBFOBHHK(NLPIAAOFKEO<OLKHJIDMFKJ> HPELDEPGIDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x27295B0", Offset = "0x2727DB0", VA = "0x1827295B0", Slot = "29")]
	public IEnumerable<BFLIFCJLFIG> KJCKMGGMLBD(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<BFEAKKGKCCO> HHLKACCBEBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x2728480", Offset = "0x2726C80", VA = "0x182728480", Slot = "30")]
	public IEnumerable<BFLIFCJLFIG> HLCBNDDKGLM(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<GCOKIOOPJJN> AJOCPGOGBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x272A240", Offset = "0x2728A40", VA = "0x18272A240")]
	public NLPIAAOFKEO<PAJOPNAJIFC> LJCOOIALEKL([In] CMDPIJDKPHC<PAJOPNAJIFC> FOEJGIIEFNC)
	{
		return default(NLPIAAOFKEO<PAJOPNAJIFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x2725950", Offset = "0x2724150", VA = "0x182725950")]
	public NLPIAAOFKEO<PAJOPNAJIFC>? DFNFDFMOIJO([In] CMDPIJDKPHC<PAJOPNAJIFC> FOEJGIIEFNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x272AF30", Offset = "0x2729730", VA = "0x18272AF30")]
	private AJBGCNAPMOH? PBBNLCLAHDJ([In] CMDPIJDKPHC<PAJOPNAJIFC> FOEJGIIEFNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x272A210", Offset = "0x2728A10", VA = "0x18272A210")]
	private OGLLKKPOEEN? KOHJDOFOAHB([In] CMDPIJDKPHC<PAJOPNAJIFC> FOEJGIIEFNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x2723FB0", Offset = "0x27227B0", VA = "0x182723FB0", Slot = "21")]
	public NLPIAAOFKEO<PAJOPNAJIFC>? AHMHLFAGEMD(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x272A400", Offset = "0x2728C00", VA = "0x18272A400", Slot = "39")]
	public CMDPIJDKPHC<PAJOPNAJIFC> MIBEJCLJBKA(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC)
	{
		return default(CMDPIJDKPHC<PAJOPNAJIFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x272A8D0", Offset = "0x27290D0", VA = "0x18272A8D0", Slot = "40")]
	public CMDPIJDKPHC<KGLBPIDLJAB> NPLDMLPOCLA(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA)
	{
		return default(CMDPIJDKPHC<KGLBPIDLJAB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x2727150", Offset = "0x2725950", VA = "0x182727150", Slot = "36")]
	public IEnumerable<MACFJNEIIPE> GBDFBMAFNFK(EAJEHKKNNHN DCCPCNJMDMN, bool HIHKJAJCJDP, bool IJNLHCIGAOJ, bool MKNKDMJBKNE, bool GNIGLCDBDOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x2726CA0", Offset = "0x27254A0", VA = "0x182726CA0", Slot = "37")]
	public MACFJNEIIPE FGBHKMLGBHH(EAJEHKKNNHN DCCPCNJMDMN, IIGEGHJBEFA HGJHANOJJBN, bool HIHKJAJCJDP, bool IJNLHCIGAOJ, bool MKNKDMJBKNE, bool GNIGLCDBDOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x2726100", Offset = "0x2724900", VA = "0x182726100")]
	public PKIPLDOOGNO EPDGOIICKLK(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, [In] BFLIFCJLFIG KICCNODEDJF)
	{
		return default(PKIPLDOOGNO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x2723B00", Offset = "0x2722300", VA = "0x182723B00", Slot = "41")]
	public BFLIFCJLFIG AFLPMHEENDL(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<BFEAKKGKCCO> HHLKACCBEBO, NLPIAAOFKEO<GCOKIOOPJJN> AJOCPGOGBJH)
	{
		return default(BFLIFCJLFIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x2729300", Offset = "0x2727B00", VA = "0x182729300", Slot = "42")]
	[AsyncStateMachine(typeof(EKHOLPICANF))]
	public Task<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> JPCIOGEBAMB(NLPIAAOFKEO<PAJOPNAJIFC> BDACPCGPEPN, NLPIAAOFKEO<KGLBPIDLJAB> HICHHNGCDAI, DLGDAHEMPMJ BFKGIFAKMAP, bool KAKKBIEJDLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x2727A40", Offset = "0x2726240", VA = "0x182727A40", Slot = "43")]
	[AsyncStateMachine(typeof(HMFFDLOHCLK))]
	public Task<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> GOJJEOIBHOG(NLPIAAOFKEO<PAJOPNAJIFC> BDACPCGPEPN, CMDPIJDKPHC<KGLBPIDLJAB> HICHHNGCDAI, List<NLPIAAOFKEO<KGLBPIDLJAB>> FOPDMKKOMHK, DLGDAHEMPMJ IMJMLHPOABN, DGDOFNPFHCD IMNCGCBGKFH, DLGDAHEMPMJ BFKGIFAKMAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x2725FB0", Offset = "0x27247B0", VA = "0x182725FB0", Slot = "46")]
	[AsyncStateMachine(typeof(PHAGABJMMPK))]
	public Task<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> DJGKDFHNCKD(NLPIAAOFKEO<PAJOPNAJIFC> BDACPCGPEPN, CMDPIJDKPHC<KGLBPIDLJAB> HICHHNGCDAI, List<NLPIAAOFKEO<KGLBPIDLJAB>> FOPDMKKOMHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x272AC50", Offset = "0x2729450", VA = "0x18272AC50", Slot = "47")]
	[AsyncStateMachine(typeof(FDKLCEFCMCM))]
	public Task<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> OMLHPMGODLF(NLPIAAOFKEO<PAJOPNAJIFC> BDACPCGPEPN, CMDPIJDKPHC<KGLBPIDLJAB> HICHHNGCDAI, NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, List<NLPIAAOFKEO<KGLBPIDLJAB>> FOPDMKKOMHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x2727250", Offset = "0x2725A50", VA = "0x182727250", Slot = "44")]
	public (IReadOnlyDictionary<EEAIELAINJC, (NLPIAAOFKEO<FGCGLNKNFGK>, NLPIAAOFKEO<GJMDNLCCEPC>)>, IReadOnlyDictionary<BHFNEOOOOJD, (NLPIAAOFKEO<FGCGLNKNFGK>, NLPIAAOFKEO<NAIBBEJGHLI>)>) GDGKBBLGOFI(CMDPIJDKPHC<PAJOPNAJIFC> HHPKLNJCNOB, NLPIAAOFKEO<KGLBPIDLJAB> HICHHNGCDAI)
	{
		return default((IReadOnlyDictionary<EEAIELAINJC, (NLPIAAOFKEO<FGCGLNKNFGK>, NLPIAAOFKEO<GJMDNLCCEPC>)>, IReadOnlyDictionary<BHFNEOOOOJD, (NLPIAAOFKEO<FGCGLNKNFGK>, NLPIAAOFKEO<NAIBBEJGHLI>)>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x2728DD0", Offset = "0x27275D0", VA = "0x182728DD0", Slot = "45")]
	[AsyncStateMachine(typeof(MKMGAHJLPIG))]
	public Task IKPHACEAIGA(CMDPIJDKPHC<PAJOPNAJIFC> HHPKLNJCNOB, CMDPIJDKPHC<KGLBPIDLJAB> HICHHNGCDAI, IReadOnlyList<CMDPIJDKPHC<KGLBPIDLJAB>> DCACNDHGFHE, IReadOnlyDictionary<EEAIELAINJC, (NLPIAAOFKEO<FGCGLNKNFGK>, NLPIAAOFKEO<GJMDNLCCEPC>)> OBBFPLGEFNM, IReadOnlyDictionary<BHFNEOOOOJD, (NLPIAAOFKEO<FGCGLNKNFGK>, NLPIAAOFKEO<NAIBBEJGHLI>)> BIBKCDLLNBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x2728D60", Offset = "0x2727560", VA = "0x182728D60", Slot = "48")]
	public bool IKEBMINBFKI(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x272B4A0", Offset = "0x2729CA0", VA = "0x18272B4A0", Slot = "49")]
	public bool PGKJHDKCCCF(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<GCOKIOOPJJN> ECEBGAIHGFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x27278B0", Offset = "0x27260B0", VA = "0x1827278B0", Slot = "50")]
	public bool GMCHBLBGJCO(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<BFEAKKGKCCO> GHICKGEHGDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x2725060", Offset = "0x2723860", VA = "0x182725060")]
	public HCGBMJDNFKJ<LNOMLFPCEKA.PEBGFHPEMLE, PBBGHPPLFHN> POLBDBCOMLB([In] LNOMLFPCEKA.FOEADAGDPBH FHMAIKMLNLH)
	{
		return default(HCGBMJDNFKJ<LNOMLFPCEKA.PEBGFHPEMLE, PBBGHPPLFHN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x2725360", Offset = "0x2723B60", VA = "0x182725360", Slot = "52")]
	[AsyncStateMachine(typeof(DDGPHEFGACA))]
	public Task<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> DDJHACONJFO(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<BFEAKKGKCCO> HHLKACCBEBO, NLPIAAOFKEO<GCOKIOOPJJN> AJOCPGOGBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x2727750", Offset = "0x2725F50", VA = "0x182727750", Slot = "53")]
	[AsyncStateMachine(typeof(GLFLCGLBKAM))]
	public Task<HCGBMJDNFKJ<NLPIAAOFKEO<KGLBPIDLJAB>, CPMHOEMAGED>> GJIPNAFCJBH(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<AGEMPNFBJCE> CIJHMIJNMBJ, DLGDAHEMPMJ NLABOGJHAHD, DGDOFNPFHCD CPLNLBDMBHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x272AB10", Offset = "0x2729310", VA = "0x18272AB10", Slot = "54")]
	[AsyncStateMachine(typeof(JPKDKEJIIBH))]
	public Task<HCGBMJDNFKJ<NLPIAAOFKEO<FGCGLNKNFGK>, CPMHOEMAGED>> OKLFIALNKOP(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA, string GLGOHIJMLFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x2728770", Offset = "0x2726F70", VA = "0x182728770", Slot = "55")]
	public HCGBMJDNFKJ<KBIBIFAHOOO, IGEMMGEDLOA> IAFAMMLHFAF(CMDPIJDKPHC<PAJOPNAJIFC> FOEJGIIEFNC, KBIBIFAHOOO DLKOIGDLHLK, DGDOFNPFHCD CBFEJCJHEIG)
	{
		return default(HCGBMJDNFKJ<KBIBIFAHOOO, IGEMMGEDLOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x27240E0", Offset = "0x27228E0", VA = "0x1827240E0", Slot = "56")]
	[AsyncStateMachine(typeof(BGJCNGNDINF))]
	public Task<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> ALMEEALEEKB(CMDPIJDKPHC<PAJOPNAJIFC> FOEJGIIEFNC, CMDPIJDKPHC<KGLBPIDLJAB> MMOOHENMKCO, NLPIAAOFKEO<FGCGLNKNFGK> PDLPOKNIBGE, NLPIAAOFKEO<GJMDNLCCEPC> ECEBGAIHGFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x2729450", Offset = "0x2727C50", VA = "0x182729450", Slot = "57")]
	[AsyncStateMachine(typeof(ODEGMKCDCML))]
	public Task<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> KFJIGLAPCAD(CMDPIJDKPHC<PAJOPNAJIFC> FOEJGIIEFNC, CMDPIJDKPHC<KGLBPIDLJAB> PEJBDOKHMNK, NLPIAAOFKEO<FGCGLNKNFGK> BHAOIOEHFFN, NLPIAAOFKEO<NAIBBEJGHLI> GHICKGEHGDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x2725840", Offset = "0x2724040", VA = "0x182725840", Slot = "58")]
	[AsyncStateMachine(typeof(AIKFFBPJIAM))]
	public Task<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> DFFJLFIPGMO(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x2728230", Offset = "0x2726A30", VA = "0x182728230", Slot = "59")]
	[AsyncStateMachine(typeof(FLFCOILLLEN))]
	public Task<HCGBMJDNFKJ<IEnumerable<CMDPIJDKPHC<KGLBPIDLJAB>>, CPMHOEMAGED>> HILNIMEEHOA(CMDPIJDKPHC<PAJOPNAJIFC> DEPDJNFGBDM, PJFHBAHAHKH JIBMOKNLPNN, IEnumerable<PEBBACKHDPF> GDOKGOIHILP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x2723950", Offset = "0x2722150", VA = "0x182723950", Slot = "60")]
	public GHDDELGKMOK AEGGJHCNCHM()
	{
		return default(GHDDELGKMOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x2727FD0", Offset = "0x27267D0", VA = "0x182727FD0", Slot = "61")]
	public GHDDELGKMOK HGPINEDDJMN()
	{
		return default(GHDDELGKMOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x2727420", Offset = "0x2725C20", VA = "0x182727420", Slot = "64")]
	public BCEGIJIDNDE GEEKHJJNCAJ(NDPKBBLDKKI HLJMOPLENFO, NLPIAAOFKEO<PAJOPNAJIFC> LAPNHIHIGLC, IEnumerable<CMDPIJDKPHC<PAJOPNAJIFC>> HMKHBBGACIB, IEnumerable<CMDPIJDKPHC<KGLBPIDLJAB>> FOPDMKKOMHK, ISet<CMDPIJDKPHC<KIHBEDJDDFP>>? LKBNMABMJJB)
	{
		return default(BCEGIJIDNDE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x2723D30", Offset = "0x2722530", VA = "0x182723D30")]
	private BCEGIJIDNDE AGPCCBEJICO(NDPKBBLDKKI HLJMOPLENFO, NLPIAAOFKEO<PAJOPNAJIFC> LAPNHIHIGLC, IEnumerable<CMDPIJDKPHC<PAJOPNAJIFC>> HMKHBBGACIB, IEnumerable<CMDPIJDKPHC<KGLBPIDLJAB>> FOPDMKKOMHK, ISet<CMDPIJDKPHC<KIHBEDJDDFP>>? LKBNMABMJJB)
	{
		return default(BCEGIJIDNDE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x27255A0", Offset = "0x2723DA0", VA = "0x1827255A0", Slot = "62")]
	public BCEGIJIDNDE DEFJBCAPGLE(NDPKBBLDKKI HLJMOPLENFO, NLPIAAOFKEO<PAJOPNAJIFC> LAPNHIHIGLC, IEnumerable<CMDPIJDKPHC<KGLBPIDLJAB>> FOPDMKKOMHK, IEnumerable<PEBBACKHDPF> GDOKGOIHILP, ISet<CMDPIJDKPHC<KIHBEDJDDFP>>? LKBNMABMJJB)
	{
		return default(BCEGIJIDNDE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x2725490", Offset = "0x2723C90", VA = "0x182725490", Slot = "63")]
	public BCEGIJIDNDE DEFJBCAPGLE(NDPKBBLDKKI HLJMOPLENFO, NLPIAAOFKEO<PAJOPNAJIFC> LAPNHIHIGLC, IEnumerable<NLPIAAOFKEO<KGLBPIDLJAB>> FOPDMKKOMHK, IEnumerable<PEBBACKHDPF> GDOKGOIHILP, ISet<CMDPIJDKPHC<KIHBEDJDDFP>>? LKBNMABMJJB)
	{
		return default(BCEGIJIDNDE);
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x272B120", Offset = "0x2729920", VA = "0x18272B120")]
	private static IEnumerable<CMDPIJDKPHC<PAJOPNAJIFC>> PGCEDAIHDCI(IEnumerable<PEBBACKHDPF> GDOKGOIHILP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x272B680", Offset = "0x2729E80", VA = "0x18272B680")]
	private IEnumerable<CMDPIJDKPHC<KGLBPIDLJAB>> PPLKAPAMHKP(IEnumerable<PEBBACKHDPF> GDOKGOIHILP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x272A470", Offset = "0x2728C70", VA = "0x18272A470", Slot = "65")]
	public List<EIOEHMLGJGF> MMHMJFIDDCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x2726320", Offset = "0x2724B20", VA = "0x182726320")]
	public (List<EIOEHMLGJGF>, bool) EBOFFMGMLPN([In] KDEJLGKGLLP OILLAKNGCGC, string KLNHOILIBHH, [In] IGODEECKAHO BFMHJPNMDDC, JHNMLCCBGPL NMHLAMOCBCM, FCJBDIHFGHG CBGPCGNFFLK)
	{
		return default((List<EIOEHMLGJGF>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x272A500", Offset = "0x2728D00", VA = "0x18272A500", Slot = "67")]
	public bool NAAOCMNILML(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x27259D0", Offset = "0x27241D0", VA = "0x1827259D0")]
	internal void DHGOMLOHCJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x27273C0", Offset = "0x2725BC0", VA = "0x1827273C0")]
	internal Task GECCNEFIOFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x2724690", Offset = "0x2722E90", VA = "0x182724690", Slot = "68")]
	public HCGBMJDNFKJ<NLPIAAOFKEO<BFEAKKGKCCO>?, CPMHOEMAGED> CDPPEENKGPK(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA, NLPIAAOFKEO<GCOKIOOPJJN> ECEBGAIHGFC)
	{
		return default(HCGBMJDNFKJ<NLPIAAOFKEO<BFEAKKGKCCO>?, CPMHOEMAGED>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x2729840", Offset = "0x2728040", VA = "0x182729840", Slot = "69")]
	public HCGBMJDNFKJ<NLPIAAOFKEO<GCOKIOOPJJN>?, CPMHOEMAGED> KMOFFCDIDJG(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA, NLPIAAOFKEO<BFEAKKGKCCO> GHICKGEHGDH)
	{
		return default(HCGBMJDNFKJ<NLPIAAOFKEO<GCOKIOOPJJN>?, CPMHOEMAGED>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x2728390", Offset = "0x2726B90", VA = "0x182728390", Slot = "70")]
	[AsyncStateMachine(typeof(DGKELHJJBLN))]
	public Task<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> HIMCMOFMIFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x272A790", Offset = "0x2728F90", VA = "0x18272A790", Slot = "71")]
	[AsyncStateMachine(typeof(PKIADJNMLED))]
	public Task<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> NOMFENHNCEM(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA, string GLGOHIJMLFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x2729120", Offset = "0x2727920", VA = "0x182729120", Slot = "72")]
	public NLPIAAOFKEO<KGLBPIDLJAB>? JDODJEFCAKK(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x272AFF0", Offset = "0x27297F0", VA = "0x18272AFF0", Slot = "73")]
	public NLPIAAOFKEO<KGLBPIDLJAB>? PDOANOPNDEB(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x272A5F0", Offset = "0x2728DF0", VA = "0x18272A5F0", Slot = "74")]
	public int NBDENLLMGPI(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x27269E0", Offset = "0x27251E0", VA = "0x1827269E0", Slot = "75")]
	public int EHOFKPCPFPI(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA, NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x2727930", Offset = "0x2726130", VA = "0x182727930", Slot = "76")]
	public int GNHHNGFIFKJ(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA, NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM, NLPIAAOFKEO<IKLIGFGFCNJ> CEOGNLEJOEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x2724580", Offset = "0x2722D80", VA = "0x182724580", Slot = "77")]
	public int CCAJJFINGFC(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA, NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM, NLPIAAOFKEO<IKLIGFGFCNJ> CEOGNLEJOEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x272A950", Offset = "0x2729150", VA = "0x18272A950", Slot = "78")]
	[AsyncStateMachine(typeof(FNOHLMGGECA))]
	public Task<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> ODADLILMFID(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA, NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM, NLPIAAOFKEO<IKLIGFGFCNJ> CEOGNLEJOEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x27280F0", Offset = "0x27268F0", VA = "0x1827280F0", Slot = "79")]
	[AsyncStateMachine(typeof(DEAONNKKAFA))]
	public Task<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> HIDPKLCJPBC(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA, NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM, NLPIAAOFKEO<IKLIGFGFCNJ> CEOGNLEJOEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x2727EF0", Offset = "0x27266F0", VA = "0x182727EF0", Slot = "80")]
	public int HFLKNIDFGKP(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA, NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x2724240", Offset = "0x2722A40", VA = "0x182724240", Slot = "81")]
	[AsyncStateMachine(typeof(CPAFJDMKEBK))]
	public Task<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> AMBHKMIDHGM(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA, string OPMIAMEJKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x272B520", Offset = "0x2729D20", VA = "0x18272B520", Slot = "82")]
	[AsyncStateMachine(typeof(ADGIPLLPLFK))]
	public Task<HCGBMJDNFKJ<OLONILFLODF, CPMHOEMAGED>> PMDHOLDEBON(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA, DLGDAHEMPMJ IKAECBBFJHO, DGDOFNPFHCD KOBOFDGKPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x2727600", Offset = "0x2725E00", VA = "0x182727600", Slot = "7")]
	private bool GEGKFHFIBJD(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, [In] BFLIFCJLFIG KICCNODEDJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x272A210", Offset = "0x2728A10", VA = "0x18272A210", Slot = "18")]
	private OGLLKKPOEEN KNPPFEDMIIB([In] CMDPIJDKPHC<PAJOPNAJIFC> FOEJGIIEFNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x2729830", Offset = "0x2728030", VA = "0x182729830", Slot = "19")]
	private NLPIAAOFKEO<PAJOPNAJIFC> KMIOEDJAOMC([In] CMDPIJDKPHC<PAJOPNAJIFC> FOEJGIIEFNC)
	{
		return default(NLPIAAOFKEO<PAJOPNAJIFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x2725950", Offset = "0x2724150", VA = "0x182725950", Slot = "20")]
	private NLPIAAOFKEO<PAJOPNAJIFC>? EEMAKHHMEMB([In] CMDPIJDKPHC<PAJOPNAJIFC> FOEJGIIEFNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x2726AD0", Offset = "0x27252D0", VA = "0x182726AD0", Slot = "22")]
	private DHGFIPJKDOO ENPAMOPHDEN([In] CMDPIJDKPHC<KGLBPIDLJAB> OPPFCAMGFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x2724570", Offset = "0x2722D70", VA = "0x182724570", Slot = "24")]
	private NLPIAAOFKEO<KGLBPIDLJAB> BLMOIFFPBLI(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, [In] CMDPIJDKPHC<KGLBPIDLJAB> PIBPFLDBKPD)
	{
		return default(NLPIAAOFKEO<KGLBPIDLJAB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x2726100", Offset = "0x2724900", VA = "0x182726100", Slot = "38")]
	private PKIPLDOOGNO DKOKIFBKGJA(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, [In] BFLIFCJLFIG KICCNODEDJF)
	{
		return default(PKIPLDOOGNO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x2725060", Offset = "0x2723860", VA = "0x182725060", Slot = "51")]
	private HCGBMJDNFKJ<LNOMLFPCEKA.PEBGFHPEMLE, PBBGHPPLFHN> CFKPPEMBBPK([In] LNOMLFPCEKA.FOEADAGDPBH FHMAIKMLNLH)
	{
		return default(HCGBMJDNFKJ<LNOMLFPCEKA.PEBGFHPEMLE, PBBGHPPLFHN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x2729030", Offset = "0x2727830", VA = "0x182729030", Slot = "66")]
	private (List<EIOEHMLGJGF>, bool) IMKNKDJIPDF([In] KDEJLGKGLLP OILLAKNGCGC, string KLNHOILIBHH, [In] IGODEECKAHO BFMHJPNMDDC, JHNMLCCBGPL NMHLAMOCBCM, FCJBDIHFGHG CBGPCGNFFLK)
	{
		return default((List<EIOEHMLGJGF>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x27276D0", Offset = "0x2725ED0", VA = "0x1827276D0")]
	[CompilerGenerated]
	private JPFHNMMAKCD GHGOAGFHBCF(EPHBLHJIMOD JEGIFICJAGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x2724410", Offset = "0x2722C10", VA = "0x182724410")]
	[CompilerGenerated]
	private BKBACPLKPAP BCEKCCJGLBF(CMDPIJDKPHC<KGLBPIDLJAB> JEGIFICJAGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x272A720", Offset = "0x2728F20", VA = "0x18272A720")]
	[CompilerGenerated]
	private AJBGCNAPMOH NMFINGDFOJG(CMDPIJDKPHC<PAJOPNAJIFC> JEGIFICJAGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x2725200", Offset = "0x2723A00", VA = "0x182725200")]
	[CompilerGenerated]
	private BKBACPLKPAP CHGJDLJFOEM(CMDPIJDKPHC<KGLBPIDLJAB> JEGIFICJAGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x27252F0", Offset = "0x2723AF0", VA = "0x1827252F0")]
	[CompilerGenerated]
	private AJBGCNAPMOH CMMKAAKMFHF(CMDPIJDKPHC<PAJOPNAJIFC> JEGIFICJAGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public sealed class JPFHNMMAKCD : MACFJNEIIPE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private struct BGEBPILPNLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<NLPIAAOFKEO<IKLIGFGFCNJ>, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public JPFHNMMAKCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public CMDPIJDKPHC<PAJOPNAJIFC> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public CMDPIJDKPHC<KGLBPIDLJAB> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public NLPIAAOFKEO<FGCGLNKNFGK> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private TaskAwaiter<HCGBMJDNFKJ<NLPIAAOFKEO<IKLIGFGFCNJ>, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x27410E0", Offset = "0x273F8E0", VA = "0x1827410E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x2741360", Offset = "0x273FB60", VA = "0x182741360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[CompilerGenerated]
	private struct BKMCDMGJHLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<NLPIAAOFKEO<GNIBIEHKAFH>, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public JPFHNMMAKCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public CMDPIJDKPHC<PAJOPNAJIFC> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public CMDPIJDKPHC<KGLBPIDLJAB> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public NLPIAAOFKEO<FGCGLNKNFGK> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private TaskAwaiter<HCGBMJDNFKJ<NLPIAAOFKEO<GNIBIEHKAFH>, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x2741890", Offset = "0x2740090", VA = "0x182741890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x2741B10", Offset = "0x2740310", VA = "0x182741B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private readonly EPHBLHJIMOD DEDKHBDGMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private readonly BGNIJNAIFMH KMOOMFFELMH;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public TypeKey CKJBMNHBNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0xBD6AB0", Offset = "0xBD52B0", VA = "0x180BD6AB0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public string EIBBEKMJKOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x2742380", Offset = "0x2740B80", VA = "0x182742380", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public EPHBLHJIMOD EAHBHEMEEPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x2746A60", Offset = "0x2745260", VA = "0x182746A60")]
	public JPFHNMMAKCD(EPHBLHJIMOD CHBHGBEFAKD, BGNIJNAIFMH GIPBFFNFCDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x27468F0", Offset = "0x27450F0", VA = "0x1827468F0", Slot = "6")]
	[AsyncStateMachine(typeof(BGEBPILPNLJ))]
	public Task<HCGBMJDNFKJ<NLPIAAOFKEO<IKLIGFGFCNJ>, CPMHOEMAGED>> PKOFFIFNCFL(CMDPIJDKPHC<PAJOPNAJIFC> FOEJGIIEFNC, CMDPIJDKPHC<KGLBPIDLJAB> OPPFCAMGFJA, NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM, string GLGOHIJMLFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x2746780", Offset = "0x2744F80", VA = "0x182746780", Slot = "7")]
	[AsyncStateMachine(typeof(BKMCDMGJHLE))]
	public Task<HCGBMJDNFKJ<NLPIAAOFKEO<GNIBIEHKAFH>, CPMHOEMAGED>> ABLBCNDEDJO(CMDPIJDKPHC<PAJOPNAJIFC> FOEJGIIEFNC, CMDPIJDKPHC<KGLBPIDLJAB> OPPFCAMGFJA, NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM, string GLGOHIJMLFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class DCBONCPMLAB : DGOLAOKNJIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private readonly EPHBLHJIMOD FIFFPJBDNCC;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private static readonly HashSet<EPHBLHJIMOD> MBGHOLJDJBB;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private static readonly HashSet<EPHBLHJIMOD> ELCCGAHCEOM;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private static readonly HashSet<EPHBLHJIMOD> JPIIEFJGAIL;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public TypeKey FIEPPEJGGLF
	{
		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x27437F0", Offset = "0x2741FF0", VA = "0x1827437F0", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool BKEPFIOPMAO
	{
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x27437E0", Offset = "0x2741FE0", VA = "0x1827437E0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool DPDBMFAAKLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x2743840", Offset = "0x2742040", VA = "0x182743840", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool NDDAEAFAMMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x2743760", Offset = "0x2741F60", VA = "0x182743760", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x2741F80", Offset = "0x2740780", VA = "0x182741F80")]
	public bool AJHOHMFMDLC(string OPMIAMEJKDH, [Out] PNPDGHGIFLI EMDLKGGDFMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x9EBB90", Offset = "0x9EA390", VA = "0x1809EBB90")]
	public DCBONCPMLAB(EPHBLHJIMOD JLPKBNIJDEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x27421F0", Offset = "0x27409F0", VA = "0x1827421F0")]
	internal static TypeKey BIDFBOMOHFD(EPHBLHJIMOD PIJHKCJDAHO)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x2742380", Offset = "0x2740B80", VA = "0x182742380", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public readonly struct IJMACKHMOAG : FJEFMNCBJDG.EPHLLDAPKBG<IOPMFGMDJPO, OLONILFLODF>
{
	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x27460F0", Offset = "0x27448F0", VA = "0x1827460F0", Slot = "4")]
	public int CJAPOPKHIEP(OLONILFLODF LDIOMGMJIGF, IOPMFGMDJPO GFMBHCHPLDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x2746130", Offset = "0x2744930", VA = "0x182746130", Slot = "5")]
	public IOPMFGMDJPO DHHCMLEHFFG(OLONILFLODF LDIOMGMJIGF, IOPMFGMDJPO GFMBHCHPLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x27460C0", Offset = "0x27448C0", VA = "0x1827460C0", Slot = "6")]
	public IOPMFGMDJPO CANBPICOAML(OLONILFLODF LDIOMGMJIGF, IOPMFGMDJPO GFMBHCHPLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x2746050", Offset = "0x2744850", VA = "0x182746050", Slot = "7")]
	public IReadOnlyList<IOPMFGMDJPO> ALCAAFNFKAD(OLONILFLODF LDIOMGMJIGF, IOPMFGMDJPO GFMBHCHPLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x2746070", Offset = "0x2744870", VA = "0x182746070", Slot = "8")]
	public IOPMFGMDJPO[] AMOBBLHBNAB(OLONILFLODF LDIOMGMJIGF, IOPMFGMDJPO GFMBHCHPLDH, int NOEGMDMHLFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x2746080", Offset = "0x2744880", VA = "0x182746080", Slot = "9")]
	public bool BHOOBPJLIGL(OLONILFLODF LDIOMGMJIGF, IOPMFGMDJPO GFMBHCHPLDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x27460A0", Offset = "0x27448A0", VA = "0x1827460A0", Slot = "10")]
	public bool BJIPJPOBMHH(OLONILFLODF LDIOMGMJIGF, IOPMFGMDJPO GFMBHCHPLDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x2746110", Offset = "0x2744910", VA = "0x182746110", Slot = "11")]
	public bool CNALKILELLC(OLONILFLODF LDIOMGMJIGF, IOPMFGMDJPO GFMBHCHPLDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x2746180", Offset = "0x2744980", VA = "0x182746180", Slot = "12")]
	public bool NHHFIDOKDLC(OLONILFLODF LDIOMGMJIGF, IOPMFGMDJPO GFMBHCHPLDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x2746140", Offset = "0x2744940", VA = "0x182746140", Slot = "13")]
	public bool HLGEMJOIOBM(OLONILFLODF INPEHJECAGO, IOPMFGMDJPO GFMBHCHPLDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x2746160", Offset = "0x2744960", VA = "0x182746160", Slot = "14")]
	public bool KNKCLJDJGEB(OLONILFLODF LDIOMGMJIGF, IOPMFGMDJPO GFMBHCHPLDH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public abstract class MNPOPLBDNAD : PNCMBCNMLMI
{
	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public PPIONKMKDEM.BJABODJBOAI LGPOAPJOMEE
	{
		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x2747990", Offset = "0x2746190", VA = "0x182747990", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public abstract NACBMONFLFA.JADAMBFFCPB BHGMKFAGAGH
	{
		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public abstract CBFIFLFMBFP.IFABMAAINID HFLHDMAAGOM
	{
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public abstract CJDNHKNDDJI.DFEGMMCMEBF PKHBJCOCEEC
	{
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public APKEIIBCNIN.OAGAKJIEFFI<GAACMGKKDOM, IOPMFGMDJPO, CBFIFLFMBFP> BDKMIAJCJOB
	{
		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x27479E0", Offset = "0x27461E0", VA = "0x1827479E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public abstract DHOPMECPOPB.EIBEAMLHBGO GOAMJELJAJF
	{
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public abstract EFIIIKJACBD HPEGGFHJFJM
	{
		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public abstract DDANONBHMDG ALJBOGIBADE
	{
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public abstract PPLGKLIDLAD FLPEMAMHFIA
	{
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public abstract AHCIJAAMNIC MEFIBGNCMCN
	{
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public abstract PHGJGDEAFJJ GDNNFNGPKDI
	{
		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	protected MNPOPLBDNAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class LDOAGBAJLML : PCKEKPKMHDF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private struct LNMFMEGKLGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<object, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public LDOAGBAJLML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public IOPMFGMDJPO action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private TaskAwaiter<HCGBMJDNFKJ<object, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x2747070", Offset = "0x2745870", VA = "0x182747070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x2747310", Offset = "0x2745B10", VA = "0x182747310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct JGBFEMPIBNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<LLABCKEFCJH, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public LDOAGBAJLML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public IReadOnlyList<IOPMFGMDJPO> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private TaskAwaiter<HCGBMJDNFKJ<object, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x2746390", Offset = "0x2744B90", VA = "0x182746390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x2746710", Offset = "0x2744F10", VA = "0x182746710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private readonly PPIFDECMEOD BBCGLOPJCNJ;

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x9EBB90", Offset = "0x9EA390", VA = "0x1809EBB90")]
	public LDOAGBAJLML(PPIFDECMEOD JKJNCGNOMJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x2746F40", Offset = "0x2745740", VA = "0x182746F40")]
	[AsyncStateMachine(typeof(LNMFMEGKLGB))]
	private Task<HCGBMJDNFKJ<object, CPMHOEMAGED>> HEBGMLAKBNB(IOPMFGMDJPO GFMBHCHPLDH, bool EOPFBMLNBOG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x2746E10", Offset = "0x2745610", VA = "0x182746E10", Slot = "4")]
	[AsyncStateMachine(typeof(JGBFEMPIBNG))]
	public Task<HCGBMJDNFKJ<LLABCKEFCJH, CPMHOEMAGED>> CMPFDILPOEK(IReadOnlyList<IOPMFGMDJPO> IMJIJNKIOAP, bool EOPFBMLNBOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public struct CNCAMPCMOHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	internal KOHJNADEOFH<FLOGJLOBLDA, CMDPIJDKPHC<FLOGJLOBLDA.FENLLDGMLDC>, IOPMFGMDJPO, JFLOOEPMANJ> FIFFPJBDNCC;

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x2718C30", Offset = "0x2717430", VA = "0x182718C30")]
	private CNCAMPCMOHP([In] KOHJNADEOFH<FLOGJLOBLDA, CMDPIJDKPHC<FLOGJLOBLDA.FENLLDGMLDC>, IOPMFGMDJPO, JFLOOEPMANJ> PJBMCOAECGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x2741C10", Offset = "0x2740410", VA = "0x182741C10")]
	public static CNCAMPCMOHP CJOJELENPLJ()
	{
		return default(CNCAMPCMOHP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public static class NNHGCOPCDMB
{
	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0xC627A0", Offset = "0xC60FA0", VA = "0x180C627A0")]
	public static KOHJNADEOFH<FLOGJLOBLDA, CMDPIJDKPHC<FLOGJLOBLDA.FENLLDGMLDC>, IOPMFGMDJPO, JFLOOEPMANJ> CMKEOGMMGKL(this CNCAMPCMOHP NFOGFJOGLPE)
	{
		return default(KOHJNADEOFH<FLOGJLOBLDA, CMDPIJDKPHC<FLOGJLOBLDA.FENLLDGMLDC>, IOPMFGMDJPO, JFLOOEPMANJ>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public struct JFLOOEPMANJ : PDDINIKBDGD.DDOKGNFNLPP<FLOGJLOBLDA, CMDPIJDKPHC<FLOGJLOBLDA.FENLLDGMLDC>, IOPMFGMDJPO>
{
	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(RVA = "0x27461B0", Offset = "0x27449B0", VA = "0x1827461B0", Slot = "7")]
	public IOPMFGMDJPO IGAIEOLCLNI(FLOGJLOBLDA[] DGPBDMFCFML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x10A1DE0", Offset = "0x10A05E0", VA = "0x1810A1DE0")]
	public CMDPIJDKPHC<FLOGJLOBLDA.FENLLDGMLDC> JDHEKIPHJHP([In] FLOGJLOBLDA CJMFNPKGKPN)
	{
		return default(CMDPIJDKPHC<FLOGJLOBLDA.FENLLDGMLDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x10A14B0", Offset = "0x109FCB0", VA = "0x1810A14B0")]
	public int MIIOAKOGACO([In] FLOGJLOBLDA JOOMDAEIMKN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x27461A0", Offset = "0x27449A0", VA = "0x1827461A0")]
	public int NBCJOEFDFDJ([In] FLOGJLOBLDA CJMFNPKGKPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x10A14B0", Offset = "0x109FCB0", VA = "0x1810A14B0", Slot = "4")]
	private int ACONHGBFCBJ([In] FLOGJLOBLDA CJMFNPKGKPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x27461A0", Offset = "0x27449A0", VA = "0x1827461A0", Slot = "5")]
	private int DLBPCFDPHNO([In] FLOGJLOBLDA CJMFNPKGKPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x10A1DE0", Offset = "0x10A05E0", VA = "0x1810A1DE0", Slot = "6")]
	private CMDPIJDKPHC<FLOGJLOBLDA.FENLLDGMLDC> CLEFGJPACNK([In] FLOGJLOBLDA CJMFNPKGKPN)
	{
		return default(CMDPIJDKPHC<FLOGJLOBLDA.FENLLDGMLDC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public struct DEBCKJBOCMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	internal KGOGLHGGKLI<JGJPBPJENAK, IOPMFGMDJPO, BCOLCBDPKJI> FIFFPJBDNCC;

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x2718C30", Offset = "0x2717430", VA = "0x182718C30")]
	private DEBCKJBOCMG([In] KGOGLHGGKLI<JGJPBPJENAK, IOPMFGMDJPO, BCOLCBDPKJI> JCBIJNHHKGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x2744500", Offset = "0x2742D00", VA = "0x182744500")]
	public static DEBCKJBOCMG CJOJELENPLJ()
	{
		return default(DEBCKJBOCMG);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public static class DJMPBBDNJDN
{
	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0xC627A0", Offset = "0xC60FA0", VA = "0x180C627A0")]
	public static KGOGLHGGKLI<JGJPBPJENAK, IOPMFGMDJPO, BCOLCBDPKJI> CMKEOGMMGKL(this DEBCKJBOCMG NFOGFJOGLPE)
	{
		return default(KGOGLHGGKLI<JGJPBPJENAK, IOPMFGMDJPO, BCOLCBDPKJI>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public struct BCOLCBDPKJI : ENLFFJCOAJJ.MNBCHNHMOAL<JGJPBPJENAK, IOPMFGMDJPO>
{
	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x212E4E0", Offset = "0x212CCE0", VA = "0x18212E4E0")]
	public int EEOEGECKCOK([In] JGJPBPJENAK JOOMDAEIMKN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x2740F00", Offset = "0x273F700", VA = "0x182740F00", Slot = "5")]
	public IOPMFGMDJPO KPIFFMFMIDG(JGJPBPJENAK[] JGHMOKNJEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x212E4E0", Offset = "0x212CCE0", VA = "0x18212E4E0", Slot = "4")]
	private int DPGPHCBNIHC([In] JGJPBPJENAK JOOMDAEIMKN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public class AKCMPIDBFMD : PLLAIPNOLPG, PBBGHPPLFHN, CPMHOEMAGED, IGEMMGEDLOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000365")]
	private readonly IGEMMGEDLOA? GNHFDHAKPNO;

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public KDGIEFLOCGP CHECJDOGKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x9E9470", Offset = "0x9E7C70", VA = "0x1809E9470", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(KDGIEFLOCGP);
		}
		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x9EC7A0", Offset = "0x9EAFA0", VA = "0x1809EC7A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public override IGEMMGEDLOA? CNCNHEBHEFN
	{
		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x2740CD0", Offset = "0x273F4D0", VA = "0x182740CD0", Slot = "7")]
	public override string KCDPOCMBOHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x2740EC0", Offset = "0x273F6C0", VA = "0x182740EC0")]
	private AKCMPIDBFMD(KDGIEFLOCGP KJHADNKKPBJ, IGEMMGEDLOA? HAIDEDMPMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x2740C50", Offset = "0x273F450", VA = "0x182740C50")]
	public static AKCMPIDBFMD AKLPCODBMDI(IGEMMGEDLOA HAIDEDMPMLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x2740DE0", Offset = "0x273F5E0", VA = "0x182740DE0")]
	public static AKCMPIDBFMD NGCLNPMJIPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x2740E50", Offset = "0x273F650", VA = "0x182740E50")]
	public static AKCMPIDBFMD ODDDAMDDPCG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public static class HKPOGFCNNJE
{
	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x37BEB90", Offset = "0x37BD390", VA = "0x1837BEB90")]
	public static HCGBMJDNFKJ<TOk, PBBGHPPLFHN> PEHJNEFKKOC<TOk>([In] this HCGBMJDNFKJ<TOk, PBBGHPPLFHN> NFOGFJOGLPE, IGEMMGEDLOA HAIDEDMPMLA) where TOk : notnull
	{
		return default(HCGBMJDNFKJ<TOk, PBBGHPPLFHN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x37BEA90", Offset = "0x37BD290", VA = "0x1837BEA90")]
	public static HCGBMJDNFKJ<TOk?, PBBGHPPLFHN?> FICMCAPOCFA<TOk>([In] this HCGBMJDNFKJ<TOk, PBBGHPPLFHN> NFOGFJOGLPE)
	{
		return default(HCGBMJDNFKJ<TOk, PBBGHPPLFHN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x37BE9A0", Offset = "0x37BD1A0", VA = "0x1837BE9A0")]
	public static HCGBMJDNFKJ<TOk?, PBBGHPPLFHN?> EAFHLCAKLNE<TOk>([In] this HCGBMJDNFKJ<TOk, PBBGHPPLFHN> NFOGFJOGLPE)
	{
		return default(HCGBMJDNFKJ<TOk, PBBGHPPLFHN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public interface EFIIIKJACBD
{
	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GBENCOOEBEP([In] HCGBMJDNFKJ<OLONILFLODF, IGEMMGEDLOA> HLPIAOANGMD);
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public static class HNPJCIGCPBO
{
	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x37C1110", Offset = "0x37BF910", VA = "0x1837C1110")]
	public static bool GBENCOOEBEP<TOk, TErr>(this EFIIIKJACBD NFOGFJOGLPE, [In] HCGBMJDNFKJ<TOk, TErr> HLPIAOANGMD) where TOk : notnull where TErr : notnull, IGEMMGEDLOA
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public interface DDANONBHMDG
{
	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	HMNEEOJAEKO OPADNNAJHIN
	{
		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public interface PPLGKLIDLAD
{
	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KJPPCHHGBLL PBEJJNNCIJI(int CBCOGLOFHMD);
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public interface DMKPCCJOHGG
{
	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public interface GGCOILKLHMB
{
	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AHAGJMFHNIG? COIAILLFIHC(NLPIAAOFKEO<FGCGLNKNFGK> BMMADBHBIJM);
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public interface AECAEFPAAMD
{
	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public interface AHAGJMFHNIG
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AECAEFPAAMD? KJJICLCNAOI(NLPIAAOFKEO<IKLIGFGFCNJ> CEOGNLEJOEB);

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DMKPCCJOHGG? BJFBNIFOOFF(NLPIAAOFKEO<GNIBIEHKAFH> GDHJOHGJMHC);
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public interface AHCIJAAMNIC
{
	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> EOIJMMFHBNB(string OPMIAMEJKDH, string KLNHOILIBHH);
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public interface PHGJGDEAFJJ
{
	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GGCOILKLHMB? DIKLIDEGDBP([In] CMDPIJDKPHC<KOBOGCBMJKE> CIJHMIJNMBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class MOMOGEDEHCM
{
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	private struct PJAEHKKPLAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public int NHCKMLOFHLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public AMFIADCCEFK? ADBAEOGNJHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public AMFIADCCEFK? CDNLNEPKADK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public readonly List<IOPMFGMDJPO> KMAJCGOKOND;

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x274A790", Offset = "0x2748F90", VA = "0x18274A790")]
		private PJAEHKKPLAC(int FPEOONOJHML, AMFIADCCEFK? LFDMGPFEAGK, AMFIADCCEFK? EMCGHJPDGPI, List<IOPMFGMDJPO> IMJIJNKIOAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x274A6D0", Offset = "0x2748ED0", VA = "0x18274A6D0")]
		public static PJAEHKKPLAC CJOJELENPLJ()
		{
			return default(PJAEHKKPLAC);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	private readonly BDPNHBHOHEJ<PJAEHKKPLAC> NDIIEEOBIOA;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public static MOMOGEDEHCM DJLOIKDDKCN
	{
		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x2748060", Offset = "0x2746860", VA = "0x182748060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public bool BHDKHGJFGKE
	{
		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0xC47930", Offset = "0xC46130", VA = "0x180C47930")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0xC466E0", Offset = "0xC44EE0", VA = "0x180C466E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x27480B0", Offset = "0x27468B0", VA = "0x1827480B0")]
	public void POKGKFAOGPN(KKGMNBFIOAK EMCGHJPDGPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x2747A30", Offset = "0x2746230", VA = "0x182747A30")]
	public void GADMPDDOKFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x2747D20", Offset = "0x2746520", VA = "0x182747D20")]
	private static string? ICLJCJILNKL([In] PJAEHKKPLAC MJBLBNMHLFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x2748270", Offset = "0x2746A70", VA = "0x182748270")]
	public MOMOGEDEHCM()
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
