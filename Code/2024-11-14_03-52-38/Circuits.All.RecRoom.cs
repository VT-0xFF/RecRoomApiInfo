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
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
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
		[Cpp2IlInjected.Address(RVA = "0x223DDB0", Offset = "0x223D1B0", VA = "0x18223DDB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C5B80", Offset = "0x8C4F80", VA = "0x1808C5B80")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C5BC0", Offset = "0x8C4FC0", VA = "0x1808C5BC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class FIJILADMNPM : IDisposable, KGBHIDDAHKM, LBKFNMKDAGI, NGAGJKJDAOE, GPBMKHIOAKP
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class IMJLFNBPCFL : FCOPKECMIMK
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int PCCFAKPDBJG
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2233AA0", Offset = "0x2232EA0", VA = "0x182233AA0", Slot = "5")]
		public HNOIKODKKAI MGAAOLLLLCN(KDNCNEFJPFE.JFMNNKIPAGL PJBENGOCCDF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void EOLDKKPGGNG();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void KLMLKFBFBOG();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x22339E0", Offset = "0x2232DE0", VA = "0x1822339E0", Slot = "13")]
		public virtual void CJMBJENLGIJ(FIJILADMNPM GAMOFPOOCDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2233A20", Offset = "0x2232E20", VA = "0x182233A20", Slot = "14")]
		public virtual void JALHJJLBOGF(FIJILADMNPM GAMOFPOOCDL, HFDKJCIJLFF LLIKOHELCCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		protected IMJLFNBPCFL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface FCOPKECMIMK
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int PCCFAKPDBJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		HNOIKODKKAI MGAAOLLLLCN(KDNCNEFJPFE.JFMNNKIPAGL PJBENGOCCDF);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void EOLDKKPGGNG();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void KLMLKFBFBOG();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void CJMBJENLGIJ(FIJILADMNPM GAMOFPOOCDL);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void JALHJJLBOGF(FIJILADMNPM GAMOFPOOCDL, HFDKJCIJLFF LLIKOHELCCA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct MHIOMPMGNGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly JEDHPHBJKJA<LHMPGDLOMEB, HFDKJCIJLFF, FIJILADMNPM, IDMDJNIGDML.JHLOFCFNCNK<LHMPGDLOMEB, HFDKJCIJLFF, FIJILADMNPM>> MHKIBMGFPMF;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2238110", Offset = "0x2237510", VA = "0x182238110")]
		internal MHIOMPMGNGI(JEDHPHBJKJA<LHMPGDLOMEB, HFDKJCIJLFF, FIJILADMNPM, IDMDJNIGDML.JHLOFCFNCNK<LHMPGDLOMEB, HFDKJCIJLFF, FIJILADMNPM>> KPECMEHKPOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class PLBKICLKLNC : IDMDJNIGDML.JHLOFCFNCNK<LHMPGDLOMEB, HFDKJCIJLFF, FIJILADMNPM>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly PLBKICLKLNC GHDNHBBFDEB;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		private PLBKICLKLNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x138B8D0", Offset = "0x138ACD0", VA = "0x18138B8D0", Slot = "4")]
		public LHMPGDLOMEB DENDOLKFPMD(HFDKJCIJLFF EAFEIEDNLNL)
		{
			return default(LHMPGDLOMEB);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x223F410", Offset = "0x223E810", VA = "0x18223F410", Slot = "5")]
		public void CJMBJENLGIJ(FIJILADMNPM DADDPLMNJHB, HFDKJCIJLFF LLIKOHELCCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x223F520", Offset = "0x223E920", VA = "0x18223F520", Slot = "6")]
		public void JALHJJLBOGF(FIJILADMNPM DADDPLMNJHB, HFDKJCIJLFF LLIKOHELCCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct JKNOEKJAGFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public OBGJCPOEFJF<LHMPGDLOMEB, HFDKJCIJLFF, FIJILADMNPM, IDMDJNIGDML.JHLOFCFNCNK<LHMPGDLOMEB, HFDKJCIJLFF, FIJILADMNPM>> MHKIBMGFPMF;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2234690", Offset = "0x2233A90", VA = "0x182234690")]
		internal JKNOEKJAGFA(OBGJCPOEFJF<LHMPGDLOMEB, HFDKJCIJLFF, FIJILADMNPM, IDMDJNIGDML.JHLOFCFNCNK<LHMPGDLOMEB, HFDKJCIJLFF, FIJILADMNPM>> KPECMEHKPOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2234640", Offset = "0x2233A40", VA = "0x182234640")]
		public static JKNOEKJAGFA GIIIFAJNKEL()
		{
			return default(JKNOEKJAGFA);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct NKDGFBJGNEP : DMHNFCBKGOM.BJABKOFPGKF<HFDKJCIJLFF, FIJILADMNPM>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct GPFDMEEBCKM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<BMFECDODLAB<object, JLOPLHOLGBP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public FIJILADMNPM receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public HFDKJCIJLFF action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public NKDGFBJGNEP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<BMFECDODLAB<object, JLOPLHOLGBP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x2232060", Offset = "0x2231460", VA = "0x182232060", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x2232240", Offset = "0x2231640", VA = "0x182232240", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA48430", Offset = "0xA47830", VA = "0x180A48430", Slot = "4")]
		public KENIFKLGBBB<IKBGAEAMJPD> EELNOPJGOGE(FIJILADMNPM PDCCDIALKJH)
		{
			return default(KENIFKLGBBB<IKBGAEAMJPD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x223DC00", Offset = "0x223D000", VA = "0x18223DC00", Slot = "5")]
		[AsyncStateMachine(typeof(GPFDMEEBCKM))]
		public Task<BMFECDODLAB<object, JLOPLHOLGBP>> LLGNKLNMIFH(FIJILADMNPM PDCCDIALKJH, HFDKJCIJLFF LLIKOHELCCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x223DD30", Offset = "0x223D130", VA = "0x18223DD30", Slot = "6")]
		public HFDKJCIJLFF[] NNGMOJEDNCN(FIJILADMNPM PDCCDIALKJH)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct HEJNIEEOKHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<bool, JLOPLHOLGBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public FIJILADMNPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public KOLFGKMAFBF rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public IKFHAIHBMIK circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public HDFAHODOCKJ superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<BMFECDODLAB<bool, JLOPLHOLGBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2232850", Offset = "0x2231C50", VA = "0x182232850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2232AD0", Offset = "0x2231ED0", VA = "0x182232AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct POMAGLHLPOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<bool, JLOPLHOLGBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public FIJILADMNPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<BMFECDODLAB<bool, JLOPLHOLGBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x223F6B0", Offset = "0x223EAB0", VA = "0x18223F6B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x223F940", Offset = "0x223ED40", VA = "0x18223F940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct LMKCMAPFIAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public FIJILADMNPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x22372C0", Offset = "0x22366C0", VA = "0x1822372C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x22374A0", Offset = "0x22368A0", VA = "0x1822374A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct DHPFJKEEKIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<object, JLOPLHOLGBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public FIJILADMNPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public HFDKJCIJLFF action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<BMFECDODLAB<object, JLOPLHOLGBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2224220", Offset = "0x2223620", VA = "0x182224220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2224410", Offset = "0x2223810", VA = "0x182224410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct MFLBHEPOACE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public FIJILADMNPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<BMFECDODLAB<bool, JLOPLHOLGBP>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2237510", Offset = "0x2236910", VA = "0x182237510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2237CF0", Offset = "0x22370F0", VA = "0x182237CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly KENIFKLGBBB<IKBGAEAMJPD> EIOBHAMFIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly MHIOMPMGNGI JGKPCALGBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly AJOCCHEOPNI PPKAKDLCNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly AJPFCLBHIPO PHEGPJLBHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1950")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly LBBABFCGHBL OCPPJAPPKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1958")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly HHIMEGIMJAG.GBMJNLHNINB DMODCAGJKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1978")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly DELEOOJEBDP CGLLJPLMNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1980")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly GGABNMHCLNE MEKFHPFJDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1988")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly LAKDBDAKKMG HKJFDBMFNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1990")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly LGMNHNOBIKO HBCJKKJBFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1998")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EMJHMFDHIPJ JKFPPHGGMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19A8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private NKCJKAHLIKA ABMNKGJJMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19C8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly AJOCCHEOPNI.JCEBAALCCKK EBAFBHIEJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19D0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly FCGAHFGLIPI FDFBKBBDINJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public AJOCCHEOPNI OAPPBBDAMGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x222FF10", Offset = "0x222F310", VA = "0x18222FF10")]
		get
		{
			return default(AJOCCHEOPNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal FCOPKECMIMK DCGJEMFCFPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2230C50", Offset = "0x2230050", VA = "0x182230C50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal HNOIKODKKAI PMOCHLNDAAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2230DC0", Offset = "0x22301C0", VA = "0x182230DC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2230A80", Offset = "0x222FE80", VA = "0x182230A80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool CBFPGIPNPOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2230380", Offset = "0x222F780", VA = "0x182230380")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2231370", Offset = "0x2230770", VA = "0x182231370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public KMIJIHGLBIK AIHBOFKLOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2231700", Offset = "0x2230B00", VA = "0x182231700", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public HCBEEOFAFIE OFHIDGIPJEG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2231710", Offset = "0x2230B10", VA = "0x182231710", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public LMBNJEDLEED KBIBCDHDPPO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2231730", Offset = "0x2230B30", VA = "0x182231730", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public DPMPADEOKFJ AMKLJGICEBA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2231720", Offset = "0x2230B20", VA = "0x182231720", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public HHIMEGIMJAG? OEDKBIJELNK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2230AA0", Offset = "0x222FEA0", VA = "0x182230AA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private LCOMFHFIOEN? NHKBOKLAOBD
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2230B20", Offset = "0x222FF20", VA = "0x182230B20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2231400", Offset = "0x2230800", VA = "0x182231400")]
	private FIJILADMNPM(LBBABFCGHBL PIINBAOCKAG, KENIFKLGBBB<IKBGAEAMJPD> NPNBEFCNIIF, [In] MHIOMPMGNGI FGJBJOIDEFJ, [In] AJOCCHEOPNI ODAHCJMKNGJ, [In] AJPFCLBHIPO JLIIKLEEKDC, HNOIKODKKAI ODNILKNMPNO, [In] HHIMEGIMJAG.GBMJNLHNINB CIFFMDCCOBB, AJOCCHEOPNI.JCEBAALCCKK CNNBJNPPPJF, FCGAHFGLIPI HCMHJOEKBKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2230500", Offset = "0x222F900", VA = "0x182230500")]
	public static FIJILADMNPM GIIIFAJNKEL(LBBABFCGHBL PJBENGOCCDF, [In] COIJCCPJKGJ GJFIEOHIFLO, KPINGLICHNB OEHNPAGCIAG, [In] LMNDLKHBHCA NBINFMMKHHH, ECIDCLCKIFL BEFLCNCODHF, KENIFKLGBBB<IKBGAEAMJPD> NPNBEFCNIIF, KENIFKLGBBB<OLOCLCIJFOE> IMHDLICFMPD, DDMPAGDCGFP CLINKFHNFLI, HBDBJKDACHA MOLCPANMICM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2230640", Offset = "0x222FA40", VA = "0x182230640")]
	public static FIJILADMNPM GIIIFAJNKEL(LBBABFCGHBL PIINBAOCKAG, [In] AJOCCHEOPNI ODAHCJMKNGJ, [In] AJPFCLBHIPO JLIIKLEEKDC, KENIFKLGBBB<IKBGAEAMJPD> NPNBEFCNIIF, KENIFKLGBBB<OLOCLCIJFOE> IMHDLICFMPD, DDMPAGDCGFP CLINKFHNFLI, HBDBJKDACHA MOLCPANMICM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x222FF20", Offset = "0x222F320", VA = "0x18222FF20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2230220", Offset = "0x222F620", VA = "0x182230220")]
	[AsyncStateMachine(typeof(HEJNIEEOKHF))]
	internal Task<BMFECDODLAB<bool, JLOPLHOLGBP>> EFJCPBLAJEO(KOLFGKMAFBF MNLHLPJABEA, IKFHAIHBMIK ENPFCIOMLNF, HDFAHODOCKJ BFJEMNEACKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2230410", Offset = "0x222F810", VA = "0x182230410")]
	[AsyncStateMachine(typeof(POMAGLHLPOA))]
	public Task<BMFECDODLAB<bool, JLOPLHOLGBP>> GDGGJKPBBLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2230990", Offset = "0x222FD90", VA = "0x182230990")]
	[AsyncStateMachine(typeof(LMKCMAPFIAM))]
	public Task<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> IGONFIAAIDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2230DD0", Offset = "0x22301D0", VA = "0x182230DD0")]
	internal void NDDGIGAOGAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2231380", Offset = "0x2230780", VA = "0x182231380")]
	internal BLOKLLOGIFH<HFDKJCIJLFF> PNKOIJDMJPI([In] BPJMMCONJEM GCFFPGHLKHD)
	{
		return default(BLOKLLOGIFH<HFDKJCIJLFF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2230920", Offset = "0x222FD20", VA = "0x182230920")]
	internal bool GNCAJJOOKEA([In] BPJMMCONJEM GCFFPGHLKHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2230390", Offset = "0x222F790", VA = "0x182230390")]
	internal BLOKLLOGIFH<HFDKJCIJLFF> FNGNALMPDID([In] DNPKNMKNBAB EMPEIFBNLOE)
	{
		return default(BLOKLLOGIFH<HFDKJCIJLFF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2230110", Offset = "0x222F510", VA = "0x182230110")]
	[AsyncStateMachine(typeof(DHPFJKEEKIH))]
	internal Task<BMFECDODLAB<object, JLOPLHOLGBP>> EDKODBJGDOG(HFDKJCIJLFF LLIKOHELCCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2230FE0", Offset = "0x22303E0", VA = "0x182230FE0")]
	private HFDKJCIJLFF[] NNGMOJEDNCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2230CA0", Offset = "0x22300A0", VA = "0x182230CA0")]
	[AsyncStateMachine(typeof(MFLBHEPOACE))]
	public Task<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> MEBOKFHECJF(Guid GGPHBDFJJKE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class JGGMCEHHLCN
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2F38010", Offset = "0x2F37410", VA = "0x182F38010")]
	public static NJABAEODPJH<(TPrev?, FIJILADMNPM?), LCOMFHFIOEN> HGJEHCIHPII<TPrev>([In] this NJABAEODPJH<TPrev, FIJILADMNPM> EAFEIEDNLNL)
	{
		return default(NJABAEODPJH<(TPrev, FIJILADMNPM), LCOMFHFIOEN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2F382D0", Offset = "0x2F376D0", VA = "0x182F382D0")]
	public static NJABAEODPJH<TPrev?, FIJILADMNPM?> MHAICOCPAFM<TPrev>([In] this NJABAEODPJH<TPrev, FIJILADMNPM> EAFEIEDNLNL)
	{
		return default(NJABAEODPJH<TPrev, FIJILADMNPM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class OFEDJLBNKIO<TData> : MBCBLBGJNJI, ENNPBAIGGFM, JPIHCAEEFCD where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly EKPAMDKNMJG<OJMKIAECBHB>? ONIEDECPJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly string GMJKGFMAAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly TData EELMKJIGLGI;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public EKPAMDKNMJG<OJMKIAECBHB>? HGGBGJFEBKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x245F6C0", Offset = "0x245EAC0", VA = "0x18245F6C0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8A0F80", Offset = "0x8A0380", VA = "0x1808A0F80", Slot = "7")]
	public override string ECJFEDANMLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4A4D320", Offset = "0x4A4C720", VA = "0x184A4D320")]
	internal OFEDJLBNKIO([In] EKPAMDKNMJG<OJMKIAECBHB>? ODKBKLEHKNM, KENIFKLGBBB<LNDEDBPBNDA>? JPMOCMMIONB, IOKind? CAHNKELJALN, string NFKMLKNHFEM, [In] TData EIFGKHNPLEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class JHLHALCPHFD
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x22341A0", Offset = "0x22335A0", VA = "0x1822341A0")]
	public static BMFECDODLAB<JECPELJKEFN, ENNPBAIGGFM> KKIFCHBOKEM([In] this EDKGPDJNODJ<LCCNGFPKGFL> NFOEPGLNBOM)
	{
		return default(BMFECDODLAB<JECPELJKEFN, ENNPBAIGGFM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2F3B340", Offset = "0x2F3A740", VA = "0x182F3B340")]
	public static BMFECDODLAB<TOk, ENNPBAIGGFM> OOCCPIGNMNF<TOk>([In] this BMFECDODLAB<TOk, ENNPBAIGGFM> EAFEIEDNLNL, [In] EKPAMDKNMJG<OJMKIAECBHB>? ODKBKLEHKNM, KENIFKLGBBB<LNDEDBPBNDA>? JPMOCMMIONB, IOKind? CAHNKELJALN, string NFKMLKNHFEM) where TOk : notnull
	{
		return default(BMFECDODLAB<TOk, ENNPBAIGGFM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface LBBABFCGHBL
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	KEAHCMJEMMB.OMAOMMPANPH PJNFJGLLCOK
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	KDNCNEFJPFE.JFMNNKIPAGL IJIGKIHKFJD
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	FIJILADMNPM.FCOPKECMIMK MJEIJNDJLLO
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	IOECLFJLDNB.MDBAKDGIDKJ DGLBJKJLCFF
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	IDMDJNIGDML.JHLOFCFNCNK<LHMPGDLOMEB, HFDKJCIJLFF, FIJILADMNPM> BFMAJOJHGJC
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	NBBBODNMAKD HFKIOKMPEOF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	MHLELPEGFEA FCDGDDHNJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	LMODBKGOEIO HBEGJPHFJJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	BGOAGPGANPK OKHHMJJJFLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	ICMFMFKDIKE OBFONMFKLPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class HHPPHABJCLB
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2232C10", Offset = "0x2232010", VA = "0x182232C10")]
	public static HFDKJCIJLFF KMHFLOBALDI(this HFDKJCIJLFF EAFEIEDNLNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2232B40", Offset = "0x2231F40", VA = "0x182232B40")]
	public static HFDKJCIJLFF AEFMEDJKFFC(this BFPCBKDEJCF EAFEIEDNLNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct BFPCBKDEJCF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct ODDPMOHBDFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<object, JLOPLHOLGBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public FIJILADMNPM root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public BFPCBKDEJCF self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<BMFECDODLAB<object, JLOPLHOLGBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x223E090", Offset = "0x223D490", VA = "0x18223E090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x223E350", Offset = "0x223D750", VA = "0x18223E350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly ByteString FDJCHKNOIDG;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x948260", Offset = "0x947660", VA = "0x180948260")]
	private BFPCBKDEJCF(ByteString PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2223210", Offset = "0x2222610", VA = "0x182223210")]
	public static HFDKJCIJLFF PFLGFJKAACI(ByteString PFKKDHPJFEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2223160", Offset = "0x2222560", VA = "0x182223160")]
	public static DOIPFJMFMMP<LHMPGDLOMEB, BFPCBKDEJCF> LPEDHCGFGAM(HFDKJCIJLFF AJPIGBHIKCO)
	{
		return default(DOIPFJMFMMP<LHMPGDLOMEB, BFPCBKDEJCF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2223050", Offset = "0x2222450", VA = "0x182223050")]
	[AsyncStateMachine(typeof(ODDPMOHBDFG))]
	public static Task<BMFECDODLAB<object, JLOPLHOLGBP>> EDKODBJGDOG(FIJILADMNPM DADDPLMNJHB, BFPCBKDEJCF EAFEIEDNLNL)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct FBDHIGDOMLN
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2224A70", Offset = "0x2223E70", VA = "0x182224A70")]
	public static HFDKJCIJLFF PFLGFJKAACI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2224A00", Offset = "0x2223E00", VA = "0x182224A00")]
	public static DOIPFJMFMMP<LHMPGDLOMEB, FBDHIGDOMLN> LPEDHCGFGAM(HFDKJCIJLFF AJPIGBHIKCO)
	{
		return default(DOIPFJMFMMP<LHMPGDLOMEB, FBDHIGDOMLN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2224980", Offset = "0x2223D80", VA = "0x182224980")]
	public static BMFECDODLAB<FHMPKELNMGN, PBKMDGOJDEJ> AOFHOEOCMPE(FIJILADMNPM DADDPLMNJHB, [In] FBDHIGDOMLN EAFEIEDNLNL)
	{
		return default(BMFECDODLAB<FHMPKELNMGN, PBKMDGOJDEJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct ADMCOPGEOMN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct FLJGFHDGAIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<FHMPKELNMGN, PBKMDGOJDEJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public FIJILADMNPM root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public ADMCOPGEOMN self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private BMFECDODLAB<FHMPKELNMGN, PBKMDGOJDEJ> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2231740", Offset = "0x2230B40", VA = "0x182231740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2231AB0", Offset = "0x2230EB0", VA = "0x182231AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly KOLFGKMAFBF? KJMNDGGJCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly IKFHAIHBMIK? LPCMFMHCOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly HDFAHODOCKJ? IHCLKOFNDBM;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x215CBB0", Offset = "0x215BFB0", VA = "0x18215CBB0")]
	private ADMCOPGEOMN(KOLFGKMAFBF? MNLHLPJABEA, IKFHAIHBMIK? ENPFCIOMLNF, HDFAHODOCKJ? BFJEMNEACKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2222A70", Offset = "0x2221E70", VA = "0x182222A70")]
	public static HFDKJCIJLFF? PFLGFJKAACI(KOLFGKMAFBF? MNLHLPJABEA, IKFHAIHBMIK? ENPFCIOMLNF, HDFAHODOCKJ? BFJEMNEACKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2222960", Offset = "0x2221D60", VA = "0x182222960")]
	public static DOIPFJMFMMP<LHMPGDLOMEB, ADMCOPGEOMN> LPEDHCGFGAM(HFDKJCIJLFF AJPIGBHIKCO)
	{
		return default(DOIPFJMFMMP<LHMPGDLOMEB, ADMCOPGEOMN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2222820", Offset = "0x2221C20", VA = "0x182222820")]
	[AsyncStateMachine(typeof(FLJGFHDGAIN))]
	public static Task<BMFECDODLAB<FHMPKELNMGN, PBKMDGOJDEJ>> EDKODBJGDOG(FIJILADMNPM DADDPLMNJHB, ADMCOPGEOMN EAFEIEDNLNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct MIACMNLIADF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct FMDNHDIGKHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<JMILCABJNBN, JLOPLHOLGBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public MIACMNLIADF self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public FIJILADMNPM root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private BMFECDODLAB<JMILCABJNBN, JLOPLHOLGBP> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private BMFECDODLAB<object, JPIHCAEEFCD>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private BMFECDODLAB<object, JPIHCAEEFCD> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private BMFECDODLAB<object, JPIHCAEEFCD>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<BMFECDODLAB<object, JLOPLHOLGBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2231B20", Offset = "0x2230F20", VA = "0x182231B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2231F90", Offset = "0x2231390", VA = "0x182231F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IReadOnlyList<HFDKJCIJLFF> BCMICMFIIPA;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x948260", Offset = "0x947660", VA = "0x180948260")]
	private MIACMNLIADF(IReadOnlyList<HFDKJCIJLFF> FJHJEKPJEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2238300", Offset = "0x2237700", VA = "0x182238300")]
	public static HFDKJCIJLFF PFLGFJKAACI(IReadOnlyList<HFDKJCIJLFF> FJHJEKPJEMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2238260", Offset = "0x2237660", VA = "0x182238260")]
	public static DOIPFJMFMMP<LHMPGDLOMEB, MIACMNLIADF> LPEDHCGFGAM(HFDKJCIJLFF AJPIGBHIKCO)
	{
		return default(DOIPFJMFMMP<LHMPGDLOMEB, MIACMNLIADF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2238120", Offset = "0x2237520", VA = "0x182238120")]
	[AsyncStateMachine(typeof(FMDNHDIGKHK))]
	public static Task<BMFECDODLAB<JMILCABJNBN, JLOPLHOLGBP>> EDKODBJGDOG(FIJILADMNPM DADDPLMNJHB, MIACMNLIADF EAFEIEDNLNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct DNPKNMKNBAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly int AHBPDFJLDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int DIJEOHGLGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly byte[] EELMKJIGLGI;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x20412F0", Offset = "0x20406F0", VA = "0x1820412F0")]
	private DNPKNMKNBAB(int GMOPHNCDIJO, int OBFJPFHENMC, byte[] EIFGKHNPLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x22247C0", Offset = "0x2223BC0", VA = "0x1822247C0")]
	public static HFDKJCIJLFF PFLGFJKAACI(int GMOPHNCDIJO, int OBFJPFHENMC, ByteString EIFGKHNPLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x22245A0", Offset = "0x22239A0", VA = "0x1822245A0")]
	public static HFDKJCIJLFF[] IJLJGKEKOIL(HFDKJCIJLFF LLIKOHELCCA, int BOJMNJIOPBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x22246E0", Offset = "0x2223AE0", VA = "0x1822246E0")]
	public static DOIPFJMFMMP<LHMPGDLOMEB, DNPKNMKNBAB> LPEDHCGFGAM(HFDKJCIJLFF AJPIGBHIKCO)
	{
		return default(DOIPFJMFMMP<LHMPGDLOMEB, DNPKNMKNBAB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2224480", Offset = "0x2223880", VA = "0x182224480")]
	public static BMFECDODLAB<HFDKJCIJLFF, PBKMDGOJDEJ> AOFHOEOCMPE(FIJILADMNPM DADDPLMNJHB, [In] DNPKNMKNBAB EAFEIEDNLNL)
	{
		return default(BMFECDODLAB<HFDKJCIJLFF, PBKMDGOJDEJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct BPJMMCONJEM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct PLAKHKFPEGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<bool, PBKMDGOJDEJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public FIJILADMNPM root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public BPJMMCONJEM self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private BMFECDODLAB<bool, PBKMDGOJDEJ> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<BMFECDODLAB<FHMPKELNMGN, PBKMDGOJDEJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x223ED60", Offset = "0x223E160", VA = "0x18223ED60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x223F3A0", Offset = "0x223E7A0", VA = "0x18223F3A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly int AHBPDFJLDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int DIJEOHGLGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly byte[] EELMKJIGLGI;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x20412F0", Offset = "0x20406F0", VA = "0x1820412F0")]
	private BPJMMCONJEM(int GMOPHNCDIJO, int OBFJPFHENMC, byte[] EIFGKHNPLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2223F40", Offset = "0x2223340", VA = "0x182223F40")]
	public static HFDKJCIJLFF PFLGFJKAACI(int GMOPHNCDIJO, int OBFJPFHENMC, ByteString EIFGKHNPLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2223B30", Offset = "0x2222F30", VA = "0x182223B30")]
	public static HFDKJCIJLFF?[]? DLNPBHDJMLF(int BOJMNJIOPBK, KOLFGKMAFBF? MNLHLPJABEA, IKFHAIHBMIK? ENPFCIOMLNF, HDFAHODOCKJ? BFJEMNEACKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2223E60", Offset = "0x2223260", VA = "0x182223E60")]
	public static DOIPFJMFMMP<LHMPGDLOMEB, BPJMMCONJEM> LPEDHCGFGAM(HFDKJCIJLFF AJPIGBHIKCO)
	{
		return default(DOIPFJMFMMP<LHMPGDLOMEB, BPJMMCONJEM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2223D30", Offset = "0x2223130", VA = "0x182223D30")]
	[AsyncStateMachine(typeof(PLAKHKFPEGF))]
	public static Task<BMFECDODLAB<bool, PBKMDGOJDEJ>> EDKODBJGDOG(FIJILADMNPM DADDPLMNJHB, BPJMMCONJEM EAFEIEDNLNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class DELEOOJEBDP : KMIJIHGLBIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly FIJILADMNPM LNBMPNGMLBG;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public PJPFGLLDMPE? GHDNHBBFDEB
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2224110", Offset = "0x2223510", VA = "0x182224110", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x89A2A0", Offset = "0x8996A0", VA = "0x18089A2A0")]
	internal DELEOOJEBDP(FIJILADMNPM GAMOFPOOCDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class BOMGNNGFCHI : PJPFGLLDMPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly FIJILADMNPM LNBMPNGMLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly HIAEONOJIEE BGHBCILNABE;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8AA360", Offset = "0x8A9760", VA = "0x1808AA360")]
	public BOMGNNGFCHI(FIJILADMNPM GAMOFPOOCDL, HIAEONOJIEE HCGGNCNNIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2223570", Offset = "0x2222970", VA = "0x182223570", Slot = "4")]
	public BMFECDODLAB<JECPELJKEFN, ENNPBAIGGFM> LJEMLFHFMGH(EKPAMDKNMJG<OJMKIAECBHB> LFFCFCIDMIM, KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII, KENIFKLGBBB<JDBOICOFJHD> NHEAFFJJAEB)
	{
		return default(BMFECDODLAB<JECPELJKEFN, ENNPBAIGGFM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2223850", Offset = "0x2222C50", VA = "0x182223850", Slot = "5")]
	public BMFECDODLAB<JECPELJKEFN, ENNPBAIGGFM> PFDIHABBNCG(EKPAMDKNMJG<OJMKIAECBHB> LFFCFCIDMIM, KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII, KENIFKLGBBB<BFLMIPIKKEL> ACDHPDFADHO)
	{
		return default(BMFECDODLAB<JECPELJKEFN, ENNPBAIGGFM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class KEAHCMJEMMB : GLKDJEHDBOH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface OMAOMMPANPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<HIAEONOJIEE> BFCHJHGHMLP(FIJILADMNPM GAMOFPOOCDL, IKFHAIHBMIK? CEACDBENBJO, HDFAHODOCKJ? AGEDEGMFBLF, CancellationToken GBOOEEMCFEA);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		JEMKLAKFOEP ONNOBPCMCLB(FIJILADMNPM GAMOFPOOCDL, KOLFGKMAFBF NODKFDFMFED);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class KODGLDMJIKB : OMAOMMPANPH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct APOEEOOGFBM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public AsyncTaskMethodBuilder<HIAEONOJIEE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public FIJILADMNPM circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public IKFHAIHBMIK cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public HDFAHODOCKJ cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter<IOECLFJLDNB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x2222B70", Offset = "0x2221F70", VA = "0x182222B70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x2222D40", Offset = "0x2222140", VA = "0x182222D40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly KODGLDMJIKB GHDNHBBFDEB;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		private KODGLDMJIKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2235330", Offset = "0x2234730", VA = "0x182235330", Slot = "4")]
		[AsyncStateMachine(typeof(APOEEOOGFBM))]
		public Task<HIAEONOJIEE> BFCHJHGHMLP(FIJILADMNPM GAMOFPOOCDL, IKFHAIHBMIK? CEACDBENBJO, HDFAHODOCKJ? AGEDEGMFBLF, CancellationToken GBOOEEMCFEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2235490", Offset = "0x2234890", VA = "0x182235490", Slot = "5")]
		public JEMKLAKFOEP ONNOBPCMCLB(FIJILADMNPM GAMOFPOOCDL, KOLFGKMAFBF NODKFDFMFED)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct IADJJMHLIIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder<KEAHCMJEMMB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public FIJILADMNPM circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public IKFHAIHBMIK cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public HDFAHODOCKJ cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public KOLFGKMAFBF evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private OMAOMMPANPH <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter<HIAEONOJIEE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2232E60", Offset = "0x2232260", VA = "0x182232E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2233350", Offset = "0x2232750", VA = "0x182233350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly HIAEONOJIEE BGHBCILNABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly JEMKLAKFOEP JEMCKCKHNKM;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public HHIMEGIMJAG OEDKBIJELNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2234E10", Offset = "0x2234210", VA = "0x182234E10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public LCOMFHFIOEN GNEOBEAGBNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2234D50", Offset = "0x2234150", VA = "0x182234D50", Slot = "5")]
		get
		{
			return default(LCOMFHFIOEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public BOMGNNGFCHI KMJKNEMPALE
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x89EF40", Offset = "0x89E340", VA = "0x18089EF40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public FJHLICLHMDH OPONNNBBLJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x89EF10", Offset = "0x89E310", VA = "0x18089EF10", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0xAE5D00", Offset = "0xAE5100", VA = "0x180AE5D00")]
	private KEAHCMJEMMB(HIAEONOJIEE HCGGNCNNIJI, JEMKLAKFOEP KBHMDNCACHE, BOMGNNGFCHI EKHILLJIFGM, FJHLICLHMDH KBOFGDGPLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2234E60", Offset = "0x2234260", VA = "0x182234E60")]
	[AsyncStateMachine(typeof(IADJJMHLIIO))]
	public static Task<KEAHCMJEMMB> NHIEIKADKCP(FIJILADMNPM GAMOFPOOCDL, KOLFGKMAFBF NODKFDFMFED, IKFHAIHBMIK? CEACDBENBJO, HDFAHODOCKJ? AGEDEGMFBLF, CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2234CF0", Offset = "0x22340F0", VA = "0x182234CF0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class KDNCNEFJPFE : HNOIKODKKAI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface JFMNNKIPAGL
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<GLKDJEHDBOH> ONDFBFIDDLK(FIJILADMNPM GAMOFPOOCDL, KOLFGKMAFBF NODKFDFMFED, IKFHAIHBMIK? CEACDBENBJO, HDFAHODOCKJ? AGEDEGMFBLF, CancellationToken GBOOEEMCFEA);

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FMLNMMJEBIO();

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void FEKLHCGMELN();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class JPGIDANADFF : JFMNNKIPAGL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct MGJPMMOCENI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public AsyncTaskMethodBuilder<GLKDJEHDBOH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public FIJILADMNPM circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public KOLFGKMAFBF evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public IKFHAIHBMIK cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public HDFAHODOCKJ cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private TaskAwaiter<KEAHCMJEMMB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x2237D60", Offset = "0x2237160", VA = "0x182237D60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x22380A0", Offset = "0x22374A0", VA = "0x1822380A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x22346A0", Offset = "0x2233AA0", VA = "0x1822346A0", Slot = "4")]
		[AsyncStateMachine(typeof(MGJPMMOCENI))]
		public Task<GLKDJEHDBOH> ONDFBFIDDLK(FIJILADMNPM GAMOFPOOCDL, KOLFGKMAFBF NODKFDFMFED, IKFHAIHBMIK? CEACDBENBJO, HDFAHODOCKJ? AGEDEGMFBLF, CancellationToken GBOOEEMCFEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void FMLNMMJEBIO();

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void FEKLHCGMELN();

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		protected JPGIDANADFF()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct IHLGBCDDMOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder<GLKDJEHDBOH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public KDNCNEFJPFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter<FHMPKELNMGN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x2233770", Offset = "0x2232B70", VA = "0x182233770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x2233970", Offset = "0x2232D70", VA = "0x182233970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct HANPJBNHAAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public KDNCNEFJPFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public FIJILADMNPM circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public KOLFGKMAFBF evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public IKFHAIHBMIK cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public HDFAHODOCKJ cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<GLKDJEHDBOH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x22322B0", Offset = "0x22316B0", VA = "0x1822322B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x22327F0", Offset = "0x2231BF0", VA = "0x1822327F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly JFMNNKIPAGL ACLONILLIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly TaskCompletionSource<FHMPKELNMGN> GDPOMMFOBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly TaskCompletionSource<FHMPKELNMGN> GFAGNKFCKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly CancellationTokenSource BKFNOBCDBLE;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool CBFPGIPNPOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x953920", Offset = "0x952D20", VA = "0x180953920", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x94E700", Offset = "0x94DB00", VA = "0x18094E700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool PEHHLBMDPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x972CC0", Offset = "0x9720C0", VA = "0x180972CC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xE08A60", Offset = "0xE07E60", VA = "0x180E08A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool AKPKICAAAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x14498F0", Offset = "0x1448CF0", VA = "0x1814498F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2234800", Offset = "0x2233C00", VA = "0x182234800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public GLKDJEHDBOH? KLMBNJNLKBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8A1340", Offset = "0x8A0740", VA = "0x1808A1340", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8A1F10", Offset = "0x8A1310", VA = "0x1808A1F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2234AF0", Offset = "0x2233EF0", VA = "0x182234AF0", Slot = "7")]
	[AsyncStateMachine(typeof(IHLGBCDDMOC))]
	public Task<GLKDJEHDBOH> NIGLOBOLLDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2234BE0", Offset = "0x2233FE0", VA = "0x182234BE0")]
	public KDNCNEFJPFE(JFMNNKIPAGL PJBENGOCCDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2234990", Offset = "0x2233D90", VA = "0x182234990", Slot = "8")]
	[AsyncStateMachine(typeof(HANPJBNHAAH))]
	public Task EFNLHJGMJIO(FIJILADMNPM GAMOFPOOCDL, KOLFGKMAFBF NODKFDFMFED, IKFHAIHBMIK? CEACDBENBJO, HDFAHODOCKJ? AGEDEGMFBLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2234810", Offset = "0x2233C10", VA = "0x182234810", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class FMHMIDLHOHC : FKCNFMLIJOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly FJHLICLHMDH ADFDPKAFJDN;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x89A2A0", Offset = "0x8996A0", VA = "0x18089A2A0")]
	public FMHMIDLHOHC(FJHLICLHMDH KBOFGDGPLHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class NFOENMALBNF
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class OBBDMJAEABM<TGraph> : LNJFLFAMJMD where TGraph : MHLHJMNGPNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		protected readonly TGraph FENGFANCNMD;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public virtual HIEHADCBGDF? ALDDDDODJEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x1264C10", Offset = "0x1264010", VA = "0x181264C10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public KENIFKLGBBB<HBIMBCKJJCB> JFFLAICHMGG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x4A42E20", Offset = "0x4A42220", VA = "0x184A42E20", Slot = "5")]
			get
			{
				return default(KENIFKLGBBB<HBIMBCKJJCB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public KENIFKLGBBB<HBIMBCKJJCB>? KMAPABEJMGP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x4A42E40", Offset = "0x4A42240", VA = "0x184A42E40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x89A2A0", Offset = "0x8996A0", VA = "0x18089A2A0")]
		public OBBDMJAEABM(TGraph ENLCABFJIOK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class PIFGEKKEEIN : OBBDMJAEABM<KICLHPLFGFC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override HIEHADCBGDF? ALDDDDODJEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x223EC70", Offset = "0x223E070", VA = "0x18223EC70", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x223EC90", Offset = "0x223E090", VA = "0x18223EC90")]
		public PIFGEKKEEIN(KICLHPLFGFC EFJKKGJCINP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x223B970", Offset = "0x223AD70", VA = "0x18223B970")]
	public static LNJFLFAMJMD GIIIFAJNKEL(MHLHJMNGPNM ENLCABFJIOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class MNPJJMCMLEG : EIBKONLCFFL, FGKKEPNIBHB, MADALHNANHL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class CKMFKKICABI
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
			public CKMFKKICABI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public NBBBODNMAKD errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x223F9B0", Offset = "0x223EDB0", VA = "0x18223F9B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x223FC20", Offset = "0x223F020", VA = "0x18223FC20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public MNPJJMCMLEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public CKMFKKICABI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2224020", Offset = "0x2223420", VA = "0x182224020")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task FPIIINDKJIE(NBBBODNMAKD errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct FICAGPPGIKN : IAsyncStateMachine
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
		public MNPJJMCMLEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x222F9B0", Offset = "0x222EDB0", VA = "0x18222F9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x222FEB0", Offset = "0x222F2B0", VA = "0x18222FEB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class JEBINFEKPOF
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
			public JEBINFEKPOF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x223FC80", Offset = "0x223F080", VA = "0x18223FC80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x223FF60", Offset = "0x223F360", VA = "0x18223FF60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public MNPJJMCMLEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public JEBINFEKPOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2233EA0", Offset = "0x22332A0", VA = "0x182233EA0")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task ODNNNPEJGHK(NBBBODNMAKD errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly FLEMBEHFNAB MLLHODINIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly ICollection<JMMIPNHLFOO> BCMECMMHOHN;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private LBBABFCGHBL FBPPDGNLPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2239BC0", Offset = "0x2238FC0", VA = "0x182239BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public KENIFKLGBBB<JDBOICOFJHD> FIMPFOOABIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xAA0D70", Offset = "0xAA0170", VA = "0x180AA0D70", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(KENIFKLGBBB<JDBOICOFJHD>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xAA19C0", Offset = "0xAA0DC0", VA = "0x180AA19C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private KENIFKLGBBB<JGHPCKNODPB> NOFIHFGPLOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xE00E00", Offset = "0xE00200", VA = "0x180E00E00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public KENIFKLGBBB<CKIEBMEMCDM> HAONNDGGGNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8C2BE0", Offset = "0x8C1FE0", VA = "0x1808C2BE0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(KENIFKLGBBB<CKIEBMEMCDM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public override KENIFKLGBBB<LNDEDBPBNDA> NMFMCAFEBCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x22385C0", Offset = "0x22379C0", VA = "0x1822385C0", Slot = "20")]
		get
		{
			return default(KENIFKLGBBB<LNDEDBPBNDA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool JBADBJGHPGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2239610", Offset = "0x2238A10", VA = "0x182239610", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x223ABF0", Offset = "0x2239FF0", VA = "0x18223ABF0")]
	private MNPJJMCMLEG(FIJILADMNPM GAMOFPOOCDL, IDOFAFFGDFF NAALEPHLNNP, FLEMBEHFNAB ALOOIOCOCJL, KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII, KENIFKLGBBB<JDBOICOFJHD> NHEAFFJJAEB, KENIFKLGBBB<JGHPCKNODPB> NEFPINAGFII, bool JPFFJIENFKB, string ACDGEPBIBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2238F80", Offset = "0x2238380", VA = "0x182238F80")]
	public static MNPJJMCMLEG GIIIFAJNKEL(FIJILADMNPM GAMOFPOOCDL, IDOFAFFGDFF NAALEPHLNNP, FLEMBEHFNAB CMILLOOAKEN, KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII, KENIFKLGBBB<JGHPCKNODPB> NEFPINAGFII, KENIFKLGBBB<JDBOICOFJHD> NHEAFFJJAEB, bool JPFFJIENFKB, bool CBPAPLLJEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2239F90", Offset = "0x2239390", VA = "0x182239F90", Slot = "21")]
	protected override void NOCOEJHJFAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2238C30", Offset = "0x2238030", VA = "0x182238C30", Slot = "22")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x22384D0", Offset = "0x22378D0", VA = "0x1822384D0", Slot = "30")]
	public void BIFAAFNDMBD(JMMIPNHLFOO GIOKOFIEABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2239690", Offset = "0x2238A90", VA = "0x182239690", Slot = "27")]
	public void JCNONNJKDGO(KEKNKMPGDEE DHKNFIMDKIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x223A180", Offset = "0x2239580", VA = "0x18223A180", Slot = "28")]
	public void OHHENGCGBHF(ECOMPLJDNFD PNJEOLHDNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x223A030", Offset = "0x2239430", VA = "0x18223A030", Slot = "23")]
	protected override void ODJMLCAKLMK(FDMOELGNPCO NAGDPOAMCME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2239A50", Offset = "0x2238E50", VA = "0x182239A50", Slot = "32")]
	public string JNKCNPLKBAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x22387A0", Offset = "0x2237BA0", VA = "0x1822387A0", Slot = "29")]
	public string CEFIMHGHFJO(int CBPLCBHEDDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2239CA0", Offset = "0x22390A0", VA = "0x182239CA0")]
	private void LCBPHEMGCHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x223AB30", Offset = "0x2239F30", VA = "0x18223AB30", Slot = "31")]
	public void PHOLKILCHBO(JMMIPNHLFOO GIOKOFIEABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2238A70", Offset = "0x2237E70", VA = "0x182238A70")]
	private void DBGGCKFCFGM(bool PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2238610", Offset = "0x2237A10", VA = "0x182238610", Slot = "33")]
	[AsyncStateMachine(typeof(FICAGPPGIKN))]
	public Task CBEODCLFOGN(string PFKKDHPJFEH, bool MHAKCNPNLKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2238CD0", Offset = "0x22380D0", VA = "0x182238CD0")]
	public void FBNKGDLGMIB(string PFKKDHPJFEH, bool MHAKCNPNLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2239470", Offset = "0x2238870", VA = "0x182239470")]
	private void ICAFOMAOBJI(int PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0xAA19C0", Offset = "0xAA0DC0", VA = "0x180AA19C0")]
	internal void IFKMMCAOIAL(KENIFKLGBBB<JDBOICOFJHD> PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2238A60", Offset = "0x2237E60", VA = "0x182238A60")]
	[CompilerGenerated]
	private void CGIKIGKBFME(string PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2239BE0", Offset = "0x2238FE0", VA = "0x182239BE0")]
	[CompilerGenerated]
	private bool KGMBHIGKNHF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2239330", Offset = "0x2238730", VA = "0x182239330")]
	[CompilerGenerated]
	private bool HHDHJLCLGBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x22383C0", Offset = "0x22377C0", VA = "0x1822383C0")]
	[CompilerGenerated]
	private int AJMPDEMDEFP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2238530", Offset = "0x2237930", VA = "0x182238530")]
	[CompilerGenerated]
	private bool BJKAPAICCIH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x223AB20", Offset = "0x2239F20", VA = "0x18223AB20")]
	[CompilerGenerated]
	private void ONJLOMIIEFK(string PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2238410", Offset = "0x2237810", VA = "0x182238410")]
	[CompilerGenerated]
	private bool BCKJBLNBIII()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2239A00", Offset = "0x2238E00", VA = "0x182239A00")]
	[CompilerGenerated]
	private bool JNGADGJHHLO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2238E20", Offset = "0x2238220", VA = "0x182238E20")]
	[CompilerGenerated]
	private bool FCLDOEENAII()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x22383C0", Offset = "0x22377C0", VA = "0x1822383C0")]
	[CompilerGenerated]
	private int PINLDBMMEBM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2238EB0", Offset = "0x22382B0", VA = "0x182238EB0")]
	[CompilerGenerated]
	private bool FIBOFPGEMHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2238720", Offset = "0x2237B20", VA = "0x182238720")]
	[CompilerGenerated]
	private object CDGBJKLLCIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x22393F0", Offset = "0x22387F0", VA = "0x1822393F0")]
	[CompilerGenerated]
	private void HNPJPAEHBAH(object PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2239EC0", Offset = "0x22392C0", VA = "0x182239EC0")]
	[CompilerGenerated]
	private bool LKOCJIHHNGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class LHDIMBBPBKF
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class GEFPODCJFNI : PFMPBBHGOAI<GHFAEBIFEPE>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override NHBHFBMCACF NBMANLOHOOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x924F10", Offset = "0x924310", VA = "0x180924F10", Slot = "126")]
			get
			{
				return default(NHBHFBMCACF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2232000", Offset = "0x2231400", VA = "0x182232000")]
		public GEFPODCJFNI(FIJILADMNPM GAMOFPOOCDL, GHFAEBIFEPE KPECMEHKPOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class KLEKHMOHCGJ : CBFKBBMPLFF<LABMBEGIGBD>
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x22352C0", Offset = "0x22346C0", VA = "0x1822352C0")]
		public KLEKHMOHCGJ(FIJILADMNPM GAMOFPOOCDL, LABMBEGIGBD NAALEPHLNNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2234FD0", Offset = "0x22343D0", VA = "0x182234FD0", Slot = "120")]
		protected override void CGGIMGMFBCB(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2235270", Offset = "0x2234670", VA = "0x182235270")]
		[CompilerGenerated]
		private bool LMEOCBMGNDC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2235150", Offset = "0x2234550", VA = "0x182235150")]
		[CompilerGenerated]
		private void FPFOLPCFOFL(bool PFKKDHPJFEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class IHELEAIOCCO : CBFKBBMPLFF<PKOLHNIAKEN>
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class OBPCCHCJDAN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public AIKABKBAPKL nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public IHELEAIOCCO <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public OBPCCHCJDAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x223E040", Offset = "0x223D440", VA = "0x18223E040")]
			internal void OFEPEICKFOE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x223DFF0", Offset = "0x223D3F0", VA = "0x18223DFF0")]
			internal bool MIAIGBOCOPO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x223DE30", Offset = "0x223D230", VA = "0x18223DE30")]
			internal bool BNIDHODELDK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x223DED0", Offset = "0x223D2D0", VA = "0x18223DED0")]
			internal void JAAFLMLAICB(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x223DE80", Offset = "0x223D280", VA = "0x18223DE80")]
			internal bool ICMDGIABAPK()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2233700", Offset = "0x2232B00", VA = "0x182233700")]
		public IHELEAIOCCO(FIJILADMNPM GAMOFPOOCDL, PKOLHNIAKEN NAALEPHLNNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x22333C0", Offset = "0x22327C0", VA = "0x1822333C0", Slot = "120")]
		protected override void CGGIMGMFBCB(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class ONEFEHPCCBG : CBFKBBMPLFF<FKLEBAEDPPN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class LBEINKDOFKD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AIKABKBAPKL nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public ONEFEHPCCBG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public LBEINKDOFKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2235CB0", Offset = "0x22350B0", VA = "0x182235CB0")]
			internal object OFEPEICKFOE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2235800", Offset = "0x2234C00", VA = "0x182235800")]
			internal bool GHMCHHFEBPO(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x2235A60", Offset = "0x2234E60", VA = "0x182235A60")]
			internal void MIAIGBOCOPO(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x2235650", Offset = "0x2234A50", VA = "0x182235650")]
			internal string BNIDHODELDK(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x22358F0", Offset = "0x2234CF0", VA = "0x1822358F0")]
			internal IReadOnlyList<object> JAAFLMLAICB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x2235880", Offset = "0x2234C80", VA = "0x182235880")]
			internal bool ICMDGIABAPK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x22357B0", Offset = "0x2234BB0", VA = "0x1822357B0")]
			internal bool DLHKKGNEGFB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x2235940", Offset = "0x2234D40", VA = "0x182235940")]
			internal void KMPOOIIGEJG(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x223EC00", Offset = "0x223E000", VA = "0x18223EC00")]
		public ONEFEHPCCBG(FIJILADMNPM GAMOFPOOCDL, FKLEBAEDPPN NAALEPHLNNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x223E4B0", Offset = "0x223D8B0", VA = "0x18223E4B0", Slot = "120")]
		protected override void CGGIMGMFBCB(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class BOKGHHIGJNM : CBFKBBMPLFF<JNKEDJNCMNP>
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class NJJKGKCFJME
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public BOKGHHIGJNM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public AIKABKBAPKL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public NJJKGKCFJME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x223BC70", Offset = "0x223B070", VA = "0x18223BC70")]
			internal bool OFEPEICKFOE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x223BB50", Offset = "0x223AF50", VA = "0x18223BB50")]
			internal void MIAIGBOCOPO(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x223BB00", Offset = "0x223AF00", VA = "0x18223BB00")]
			internal bool BNIDHODELDK()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2223500", Offset = "0x2222900", VA = "0x182223500")]
		public BOKGHHIGJNM(FIJILADMNPM GAMOFPOOCDL, JNKEDJNCMNP NAALEPHLNNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x22232D0", Offset = "0x22226D0", VA = "0x1822232D0", Slot = "120")]
		protected override void CGGIMGMFBCB(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public abstract class FJPPMJLMHGD<TNode> : CBFKBBMPLFF<TNode> where TNode : notnull, KDHBCOHPJIC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct DLEHOJOABJN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public AsyncTaskMethodBuilder<BMFECDODLAB<KENIFKLGBBB<LJJEABOBKPI>, JLOPLHOLGBP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public FJPPMJLMHGD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private TaskAwaiter<BMFECDODLAB<KENIFKLGBBB<LJJEABOBKPI>, JLOPLHOLGBP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x5C025F0", Offset = "0x5C019F0", VA = "0x185C025F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x5C029E0", Offset = "0x5C01DE0", VA = "0x185C029E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct PLPBLNJLPNP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public AsyncTaskMethodBuilder<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public FJPPMJLMHGD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public KENIFKLGBBB<LJJEABOBKPI> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private TaskAwaiter<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x4B42540", Offset = "0x4B41940", VA = "0x184B42540", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x4B42930", Offset = "0x4B41D30", VA = "0x184B42930", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public sealed override bool IPEOOMJFCLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override KENIFKLGBBB<LJJEABOBKPI>? NJDNNNCHIPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x3F4D580", Offset = "0x3F4C980", VA = "0x183F4D580", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3F4D530", Offset = "0x3F4C930", VA = "0x183F4D530")]
		protected FJPPMJLMHGD(FIJILADMNPM GAMOFPOOCDL, TNode NAALEPHLNNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3F4D260", Offset = "0x3F4C660", VA = "0x183F4D260", Slot = "100")]
		[AsyncStateMachine(typeof(FJPPMJLMHGD<>.DLEHOJOABJN))]
		public override Task<BMFECDODLAB<KENIFKLGBBB<LJJEABOBKPI>, JLOPLHOLGBP>> KCDAOGEEJPK(string ACDGEPBIBHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3F4D490", Offset = "0x3F4C890", VA = "0x183F4D490", Slot = "124")]
		public sealed override bool OLDAMPMKHJN(KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3F4D1C0", Offset = "0x3F4C5C0", VA = "0x183F4D1C0", Slot = "112")]
		protected sealed override bool EFDFEFEKGJO(KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3F4D120", Offset = "0x3F4C520", VA = "0x183F4D120", Slot = "113")]
		protected override bool APDJJJFFIEC(KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x3F4D380", Offset = "0x3F4C780", VA = "0x183F4D380", Slot = "101")]
		[AsyncStateMachine(typeof(FJPPMJLMHGD<>.PLPBLNJLPNP))]
		public override Task<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> NNKCLAOPFON(KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class JCIPJKPBLBD : KOJHPOLGICP<PLLKJCPBPLO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class HLGKIFMFPIO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public JCIPJKPBLBD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public AIKABKBAPKL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public HLGKIFMFPIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x2232DE0", Offset = "0x22321E0", VA = "0x182232DE0")]
			internal bool MFKOMMPOBFI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x2232D20", Offset = "0x2232120", VA = "0x182232D20")]
			internal void BOIBLCOMILK(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2233E40", Offset = "0x2233240", VA = "0x182233E40")]
		public JCIPJKPBLBD(FIJILADMNPM GAMOFPOOCDL, PLLKJCPBPLO KPECMEHKPOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2233BF0", Offset = "0x2232FF0", VA = "0x182233BF0", Slot = "126")]
		protected override void FDDADDHIHEI(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class NMLNNHDFGHB : MMAKHJACMMJ<NAHCLKACHLG>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override NodeVisualizationKey NOMMKAICFPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x91EFB0", Offset = "0x91E3B0", VA = "0x18091EFB0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x223DD50", Offset = "0x223D150", VA = "0x18223DD50")]
		public NMLNNHDFGHB(FIJILADMNPM GAMOFPOOCDL, NAHCLKACHLG NAALEPHLNNP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public abstract class MMAKHJACMMJ<TNode> : CBFKBBMPLFF<TNode> where TNode : notnull, GIDEMOLOPGA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct EIHEEDFMMOG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public AsyncTaskMethodBuilder<BMFECDODLAB<KENIFKLGBBB<LJJEABOBKPI>, JLOPLHOLGBP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public MMAKHJACMMJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			private TaskAwaiter<BMFECDODLAB<KENIFKLGBBB<LJJEABOBKPI>, JLOPLHOLGBP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x3B9A5D0", Offset = "0x3B999D0", VA = "0x183B9A5D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x3B9AA60", Offset = "0x3B99E60", VA = "0x183B9AA60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct KOBDACNHMJM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public AsyncTaskMethodBuilder<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public MMAKHJACMMJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public KENIFKLGBBB<LJJEABOBKPI> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private TaskAwaiter<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x4537380", Offset = "0x4536780", VA = "0x184537380", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x45377F0", Offset = "0x4536BF0", VA = "0x1845377F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct LCDOFMMLIIJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public AsyncTaskMethodBuilder<BMFECDODLAB<JMILCABJNBN, JLOPLHOLGBP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public MMAKHJACMMJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private TaskAwaiter<BMFECDODLAB<JMILCABJNBN, JLOPLHOLGBP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x45E0280", Offset = "0x45DF680", VA = "0x1845E0280", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x45E0930", Offset = "0x45DFD30", VA = "0x1845E0930", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private sealed class OJDKFJLPKLD
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
				public OJDKFJLPKLD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0x38B1310", Offset = "0x38B0710", VA = "0x1838B1310", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000150")]
				[Cpp2IlInjected.Address(RVA = "0x8E9810", Offset = "0x8E8C10", VA = "0x1808E9810", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public JDDCKGCCEJC configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public AIKABKBAPKL nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public MMAKHJACMMJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public Func<string, bool> <>9__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public Action <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public OJDKFJLPKLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x4A62380", Offset = "0x4A61780", VA = "0x184A62380")]
			internal bool KMPOOIIGEJG(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x4A62860", Offset = "0x4A61C60", VA = "0x184A62860")]
			internal void OFEPEICKFOE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x4A622E0", Offset = "0x4A616E0", VA = "0x184A622E0")]
			[AsyncStateMachine(typeof(MMAKHJACMMJ<>.OJDKFJLPKLD.<<BuildConfigMenuInternal>b__7>d))]
			internal void GHMCHHFEBPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x4A62460", Offset = "0x4A61860", VA = "0x184A62460")]
			internal bool MIAIGBOCOPO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class DPBDBJLIIPD
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
				public DPBDBJLIIPD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				private TaskAwaiter<TaskStatus> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000156")]
				[Cpp2IlInjected.Address(RVA = "0x38B0FA0", Offset = "0x38B03A0", VA = "0x1838B0FA0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000157")]
				[Cpp2IlInjected.Address(RVA = "0x8E9810", Offset = "0x8E8C10", VA = "0x1808E9810", Slot = "5")]
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
			public OJDKFJLPKLD CS$<>8__locals1;

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
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public DPBDBJLIIPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x5C1E410", Offset = "0x5C1D810", VA = "0x185C1E410")]
			internal void BNIDHODELDK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
			internal string JAAFLMLAICB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x89A1B0", Offset = "0x8995B0", VA = "0x18089A1B0")]
			internal void ICMDGIABAPK(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x5C1E7B0", Offset = "0x5C1DBB0", VA = "0x185C1E7B0")]
			[AsyncStateMachine(typeof(MMAKHJACMMJ<>.DPBDBJLIIPD.<<BuildConfigMenuInternal>b__5>d))]
			internal void DLHKKGNEGFB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class CEJGINEAMDD
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
				public CEJGINEAMDD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016B")]
				[Cpp2IlInjected.Address(RVA = "0x38B0AD0", Offset = "0x38AFED0", VA = "0x1838B0AD0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0x8E9810", Offset = "0x8E8C10", VA = "0x1808E9810", Slot = "5")]
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
				public CEJGINEAMDD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010C")]
				private TaskAwaiter<BMFECDODLAB<KENIFKLGBBB<JGHPCKNODPB>, JLOPLHOLGBP>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0x38B0CB0", Offset = "0x38B00B0", VA = "0x1838B0CB0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0x8E9810", Offset = "0x8E8C10", VA = "0x1808E9810", Slot = "5")]
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
				public CEJGINEAMDD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				private TaskAwaiter<BMFECDODLAB<KENIFKLGBBB<HBFNEOMKDHH>, JLOPLHOLGBP>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0x38B0420", Offset = "0x38AF820", VA = "0x1838B0420", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0x8E9810", Offset = "0x8E8C10", VA = "0x1808E9810", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public MMAKHJACMMJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public KENIFKLGBBB<LJJEABOBKPI> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public JDDCKGCCEJC configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public AIKABKBAPKL nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public NNGAAJOKFAH nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public int minGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public int maxGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public MECNCANHOPI selectedInputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public string newInputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public List<IPIAMIIJCIF> inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public MECNCANHOPI selectedOutputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public string newOutputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public List<IPIAMIIJCIF> outputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public Func<string, bool> <>9__17;

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public CEJGINEAMDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x554D900", Offset = "0x554CD00", VA = "0x18554D900")]
			internal bool NJPIPAELEIC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x554D200", Offset = "0x554C600", VA = "0x18554D200")]
			internal void CLHEKFDLACN(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x554D3C0", Offset = "0x554C7C0", VA = "0x18554D3C0")]
			internal bool FFEOACCEOPF(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x554D7B0", Offset = "0x554CBB0", VA = "0x18554D7B0")]
			internal bool KDJEEHNKMAD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x554D160", Offset = "0x554C560", VA = "0x18554D160")]
			[AsyncStateMachine(typeof(MMAKHJACMMJ<>.CEJGINEAMDD.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void ANFMJGKCBAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x554D8C0", Offset = "0x554CCC0", VA = "0x18554D8C0")]
			internal bool NBJFPDNNEHB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x554D6F0", Offset = "0x554CAF0", VA = "0x18554D6F0")]
			internal void IGFKNCLFJBH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x554D640", Offset = "0x554CA40", VA = "0x18554D640")]
			internal bool HJBIJLCGJOP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x554D580", Offset = "0x554C980", VA = "0x18554D580")]
			internal void HACNFBKHBDK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x554D270", Offset = "0x554C670", VA = "0x18554D270")]
			internal bool EGLCNPCJLEF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x554D4A0", Offset = "0x554C8A0", VA = "0x18554D4A0")]
			internal bool FJIGOAMFENG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x554D850", Offset = "0x554CC50", VA = "0x18554D850")]
			internal void LOCCBPNCJMA(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x554D0C0", Offset = "0x554C4C0", VA = "0x18554D0C0")]
			[AsyncStateMachine(typeof(MMAKHJACMMJ<>.CEJGINEAMDD.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void AJCLFCEDLPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x554D9E0", Offset = "0x554CDE0", VA = "0x18554D9E0")]
			internal bool PKCANNJGNBN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x554D510", Offset = "0x554C910", VA = "0x18554D510")]
			internal bool FOPOCLFFJJH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x554D970", Offset = "0x554CD70", VA = "0x18554D970")]
			internal void PIEKGJEPMFP(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x554D320", Offset = "0x554C720", VA = "0x18554D320")]
			[AsyncStateMachine(typeof(MMAKHJACMMJ<>.CEJGINEAMDD.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void FAPOADALMHP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x554D7F0", Offset = "0x554CBF0", VA = "0x18554D7F0")]
			internal bool LLCEFPFNIIB()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class DHKPEKINMAG
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
				public DHKPEKINMAG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				private TaskAwaiter<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000176")]
				[Cpp2IlInjected.Address(RVA = "0x38B0710", Offset = "0x38AFB10", VA = "0x1838B0710", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000177")]
				[Cpp2IlInjected.Address(RVA = "0x8E9810", Offset = "0x8E8C10", VA = "0x1808E9810", Slot = "5")]
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
			public CEJGINEAMDD CS$<>8__locals1;

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
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public DHKPEKINMAG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x5BF4520", Offset = "0x5BF3920", VA = "0x185BF4520")]
			internal void HCJDPGNBPID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
			internal string JHMFPPEEIFO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x89A1B0", Offset = "0x8995B0", VA = "0x18089A1B0")]
			internal void LOJGEAALHNP(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x5BF4480", Offset = "0x5BF3880", VA = "0x185BF4480")]
			[AsyncStateMachine(typeof(MMAKHJACMMJ<>.DHKPEKINMAG.<<AddDynamicNodeGroupSettingV2>b__16>d))]
			internal void EJCBMENJHLH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		[CompilerGenerated]
		private sealed class CODMKPBAMHH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public NNGAAJOKFAH nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public List<IPIAMIIJCIF> portMenu;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public MMAKHJACMMJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public KENIFKLGBBB<LJJEABOBKPI> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public int portCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public Func<bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public CODMKPBAMHH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x5727230", Offset = "0x5726630", VA = "0x185727230")]
			internal bool FDEMINFPBBK()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private sealed class KCOOIANCHIO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public MADALHNANHL port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public CODMKPBAMHH CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public KCOOIANCHIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x44F0860", Offset = "0x44EFC60", VA = "0x1844F0860")]
			internal void GPGKCIKIBDE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x44F07B0", Offset = "0x44EFBB0", VA = "0x1844F07B0")]
			internal bool DFKJANHEMPL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x44F0970", Offset = "0x44EFD70", VA = "0x1844F0970")]
			internal void MBNAPNCGFMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x44F0800", Offset = "0x44EFC00", VA = "0x1844F0800")]
			internal bool EEFAGBFNHEC()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private sealed class GGNDKDBPKCM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public IPIAMIIJCIF portControls;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public KCOOIANCHIO CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public GGNDKDBPKCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x40472E0", Offset = "0x40466E0", VA = "0x1840472E0")]
			internal void AEBJFEOJPGD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class JHAPJJOPEFK
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
				public JHAPJJOPEFK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000130")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000131")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				private TaskAwaiter<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000187")]
				[Cpp2IlInjected.Address(RVA = "0x38B2740", Offset = "0x38B1B40", VA = "0x1838B2740", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000188")]
				[Cpp2IlInjected.Address(RVA = "0x8E9810", Offset = "0x8E8C10", VA = "0x1808E9810", Slot = "5")]
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
			public MECNCANHOPI selectedType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public NNGAAJOKFAH nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public MADALHNANHL port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public AIKABKBAPKL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public JHAPJJOPEFK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x441DA30", Offset = "0x441CE30", VA = "0x18441DA30")]
			internal int ACJBINKMJIP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x441DA70", Offset = "0x441CE70", VA = "0x18441DA70")]
			internal void DOEFFCJPBDK(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8A1340", Offset = "0x8A0740", VA = "0x1808A1340")]
			internal string PAFPHPFCDOL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x441DCB0", Offset = "0x441D0B0", VA = "0x18441DCB0")]
			[AsyncStateMachine(typeof(MMAKHJACMMJ<>.JHAPJJOPEFK.<<CreatePortItemV2>b__3>d))]
			internal void NNMOHHPKKNG(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x441DD70", Offset = "0x441D170", VA = "0x18441DD70")]
			internal bool ONIIEEFJADH(string text)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly Dictionary<KENIFKLGBBB<LJJEABOBKPI>, bool> CPKHPMOLBAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly Dictionary<KENIFKLGBBB<LJJEABOBKPI>, bool> LKENNDEIBPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private readonly Dictionary<KENIFKLGBBB<LJJEABOBKPI>, bool> HAONIGPBIDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Dictionary<KENIFKLGBBB<LJJEABOBKPI>, bool> JHIDOILDEBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private Dictionary<KENIFKLGBBB<LJJEABOBKPI>, bool> AFNDKIPHDMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private Dictionary<KENIFKLGBBB<LJJEABOBKPI>, bool> LHDJHNENNAE;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool JBMCALIGLFK
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected virtual bool JJCBKFHGLIM
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "126")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected virtual bool FKCPJPCDJDB
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "127")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected virtual bool JCADAMLHHDL
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "128")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override KENIFKLGBBB<HBIMBCKJJCB>? NAGCMDELHFC
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x48E38D0", Offset = "0x48E2CD0", VA = "0x1848E38D0", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override KENIFKLGBBB<LJJEABOBKPI>? NJDNNNCHIPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x48E3BA0", Offset = "0x48E2FA0", VA = "0x1848E3BA0", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override IEnumerable<EKPAMDKNMJG<OJMKIAECBHB>>? FEMADONHPJN
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x48E3990", Offset = "0x48E2D90", VA = "0x1848E3990", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x48E36B0", Offset = "0x48E2AB0", VA = "0x1848E36B0")]
		public MMAKHJACMMJ(FIJILADMNPM GAMOFPOOCDL, TNode NAALEPHLNNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "129")]
		protected virtual bool NOFKJHOHDOH(int CMLJGNACNAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "130")]
		protected virtual bool ENBGPBOCHKH(int CMLJGNACNAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "131")]
		protected virtual bool GDEDELDKKMI(int CMLJGNACNAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "132")]
		protected virtual void EKAKDNHIMCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x48E3510", Offset = "0x48E2910", VA = "0x1848E3510", Slot = "124")]
		public override bool OLDAMPMKHJN(KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x48DFCE0", Offset = "0x48DF0E0", VA = "0x1848DFCE0", Slot = "100")]
		[AsyncStateMachine(typeof(MMAKHJACMMJ<>.EIHEEDFMMOG))]
		public override Task<BMFECDODLAB<KENIFKLGBBB<LJJEABOBKPI>, JLOPLHOLGBP>> KCDAOGEEJPK(string ACDGEPBIBHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x48E3400", Offset = "0x48E2800", VA = "0x1848E3400", Slot = "101")]
		[AsyncStateMachine(typeof(MMAKHJACMMJ<>.KOBDACNHMJM))]
		public override Task<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> NNKCLAOPFON(KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x48DF850", Offset = "0x48DEC50", VA = "0x1848DF850", Slot = "102")]
		public override void INDNDMAGAFB(KENIFKLGBBB<LJJEABOBKPI> OBFJPFHENMC, KENIFKLGBBB<LJJEABOBKPI> KLACLBHAHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x48E2FA0", Offset = "0x48E23A0", VA = "0x1848E2FA0", Slot = "103")]
		public override IEnumerable<HFDKJCIJLFF> MAKMMJHAAHE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x48E35B0", Offset = "0x48E29B0", VA = "0x1848E35B0")]
		[AsyncStateMachine(typeof(MMAKHJACMMJ<>.LCDOFMMLIIJ))]
		private Task<BMFECDODLAB<JMILCABJNBN, JLOPLHOLGBP>> PFJILFACMMD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "133")]
		protected virtual bool MCKDEPFECMC(KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "134")]
		protected virtual bool ANDFLOEPCBD(KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "135")]
		protected virtual bool NNJPMMHJIHL(KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "136")]
		protected virtual bool PJIAHCLEOLA(KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "137")]
		protected virtual bool BEMJBKGPHEK(KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII, int IIKBHDMNEGE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "138")]
		protected virtual bool EJNMICKEDJG(KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII, int IIKBHDMNEGE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "139")]
		protected virtual bool MOAPJPILLGN(KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII, int BCDOPIAAPDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "140")]
		protected virtual bool BPBKJNMJNGG(KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII, int BCDOPIAAPDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "141")]
		protected virtual bool LOKFKHECDKK(KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII, int CPBOLBGOHDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "142")]
		protected virtual bool GFAKPJBCLAL(KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII, int KDMDBMCNMLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x48DFA50", Offset = "0x48DEE50", VA = "0x1848DFA50", Slot = "143")]
		protected virtual List<MECNCANHOPI> JHOFFNOHCPO(KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "144")]
		protected virtual void FIJGIPNCEPK(JDDCKGCCEJC PKGIKLFNNDJ, AAEFEFOEBCD OLHOFLLIIDC, NNGAAJOKFAH MMGOLLODAKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x48DEE00", Offset = "0x48DE200", VA = "0x1848DEE00", Slot = "120")]
		protected override void CGGIMGMFBCB(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x48E0740", Offset = "0x48DFB40", VA = "0x1848E0740")]
		private AAEFEFOEBCD LADCBIHHJIP(JDDCKGCCEJC PKGIKLFNNDJ, NNGAAJOKFAH MMGOLLODAKJ, KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x48E1E70", Offset = "0x48E1270", VA = "0x1848E1E70")]
		private List<IPIAMIIJCIF> LPBHIMBOMFM(JDDCKGCCEJC PKGIKLFNNDJ, NNGAAJOKFAH MMGOLLODAKJ, AAEFEFOEBCD IIPJIBHJMLE, bool DFCNNFBLEHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x48DFE00", Offset = "0x48DF200", VA = "0x1848DFE00")]
		private List<IPIAMIIJCIF> KMLABNECIFG(JDDCKGCCEJC PKGIKLFNNDJ, NNGAAJOKFAH MMGOLLODAKJ, MADALHNANHL MDMPLCCOJAE, bool DFCNNFBLEHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x48E3210", Offset = "0x48E2610", VA = "0x1848E3210")]
		private MECNCANHOPI NEDBFMHGMGF(List<MECNCANHOPI> GEKLFNKFKKE, MADALHNANHL MDMPLCCOJAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x48DED70", Offset = "0x48DE170", VA = "0x1848DED70")]
		[CompilerGenerated]
		private HFDKJCIJLFF BHFHAAFBFPD(IDOFAFFGDFF CLDPBDGHEDO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public sealed class JHKBMPBENGJ : CBFKBBMPLFF<KNFGFEDDOMA>
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class EBOPCGCMGMO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public JHKBMPBENGJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public AIKABKBAPKL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public EBOPCGCMGMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x2224930", Offset = "0x2223D30", VA = "0x182224930")]
			internal int OFEPEICKFOE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x22248A0", Offset = "0x2223CA0", VA = "0x1822248A0")]
			internal void MIAIGBOCOPO(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NodeVisualizationKey NOMMKAICFPN
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xBD1E40", Offset = "0xBD1240", VA = "0x180BD1E40", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2234130", Offset = "0x2233530", VA = "0x182234130")]
		public JHKBMPBENGJ(FIJILADMNPM GAMOFPOOCDL, KNFGFEDDOMA NAALEPHLNNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2233F70", Offset = "0x2233370", VA = "0x182233F70", Slot = "120")]
		protected override void CGGIMGMFBCB(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public sealed class BAOPBKNJNNE : KOJHPOLGICP<FHDLMHIKDNN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class LAJDLNHJBCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public BAOPBKNJNNE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public AIKABKBAPKL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public LAJDLNHJBCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x22355D0", Offset = "0x22349D0", VA = "0x1822355D0")]
			internal int MFKOMMPOBFI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x2235530", Offset = "0x2234930", VA = "0x182235530")]
			internal void BOIBLCOMILK(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2222FF0", Offset = "0x22223F0", VA = "0x182222FF0")]
		public BAOPBKNJNNE(FIJILADMNPM GAMOFPOOCDL, FHDLMHIKDNN KPECMEHKPOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2222DB0", Offset = "0x22221B0", VA = "0x182222DB0", Slot = "126")]
		protected override void FDDADDHIHEI(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private sealed class ODLJCOEJKFO : CBFKBBMPLFF<LAIBOEHCLKB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey NOMMKAICFPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x937AF0", Offset = "0x936EF0", VA = "0x180937AF0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x223E3C0", Offset = "0x223D7C0", VA = "0x18223E3C0")]
		public ODLJCOEJKFO(FIJILADMNPM GAMOFPOOCDL, LAIBOEHCLKB NAALEPHLNNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "120")]
		protected override void CGGIMGMFBCB(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class NKAOOIGHEKG : CBFKBBMPLFF<JCJDDJMCHFN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class FGHKMNGLPGB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public NKAOOIGHEKG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public JDDCKGCCEJC configure;

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
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public FGHKMNGLPGB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x222F4C0", Offset = "0x222E8C0", VA = "0x18222F4C0")]
			internal bool OFEPEICKFOE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x222ECA0", Offset = "0x222E0A0", VA = "0x18222ECA0")]
			internal void MIAIGBOCOPO(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x22278B0", Offset = "0x2226CB0", VA = "0x1822278B0")]
			internal bool ICMDGIABAPK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x2225B10", Offset = "0x2224F10", VA = "0x182225B10")]
			internal bool DLHKKGNEGFB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x22284D0", Offset = "0x22278D0", VA = "0x1822284D0")]
			internal void KMPOOIIGEJG(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x2226330", Offset = "0x2225730", VA = "0x182226330")]
			internal bool EFEHODCOJHE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x222EC50", Offset = "0x222E050", VA = "0x18222EC50")]
			internal bool MHBNCJJIGCO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x2226DB0", Offset = "0x22261B0", VA = "0x182226DB0")]
			internal void GBMEFNLACNA(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x22273D0", Offset = "0x22267D0", VA = "0x1822273D0")]
			internal bool GOGKKFJHJDN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x22274E0", Offset = "0x22268E0", VA = "0x1822274E0")]
			internal bool HAPMKFKFGJG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x2225AB0", Offset = "0x2224EB0", VA = "0x182225AB0")]
			internal void DKLDPHDOHCK(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x2226D60", Offset = "0x2226160", VA = "0x182226D60")]
			internal bool GBJOLDGGCCH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x222ED50", Offset = "0x222E150", VA = "0x18222ED50")]
			internal bool MKLNAMJJJDM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x2228630", Offset = "0x2227A30", VA = "0x182228630")]
			internal bool LEPNJNILMEA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x2225050", Offset = "0x2224450", VA = "0x182225050")]
			internal bool BIOJDLEHBBL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x222F070", Offset = "0x222E470", VA = "0x18222F070")]
			internal bool NEMFDGLFBCE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x2225920", Offset = "0x2224D20", VA = "0x182225920")]
			internal bool DIGIPGDPJKK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x222F600", Offset = "0x222EA00", VA = "0x18222F600")]
			internal bool OJOCCKDLNLJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x22252E0", Offset = "0x22246E0", VA = "0x1822252E0")]
			internal bool CDLHMIOBEDI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x22277C0", Offset = "0x2226BC0", VA = "0x1822277C0")]
			internal bool HNLJAHMHELF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x2226BC0", Offset = "0x2225FC0", VA = "0x182226BC0")]
			internal void FMNCOAOFPIF(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x2225190", Offset = "0x2224590", VA = "0x182225190")]
			internal bool BLBIBMOINBP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x222F730", Offset = "0x222EB30", VA = "0x18222F730")]
			internal bool PBGPBJOABIC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x2226490", Offset = "0x2225890", VA = "0x182226490")]
			internal bool EKPGKIBLHCI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x222EF80", Offset = "0x222E380", VA = "0x18222EF80")]
			internal bool NACKHCKEPBF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x2226FC0", Offset = "0x22263C0", VA = "0x182226FC0")]
			internal bool GECNHOJEEJJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x2226E10", Offset = "0x2226210", VA = "0x182226E10")]
			internal bool GBPDMKDBFGP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x2224EA0", Offset = "0x22242A0", VA = "0x182224EA0")]
			internal bool APCHJNIONNH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x2227240", Offset = "0x2226640", VA = "0x182227240")]
			internal bool GIPMLMDCMPO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x22257D0", Offset = "0x2224BD0", VA = "0x1822257D0")]
			internal void DCGMNEFHANG(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x222F560", Offset = "0x222E960", VA = "0x18222F560")]
			internal bool OIAILAPAHIK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x2224B10", Offset = "0x2223F10", VA = "0x182224B10")]
			internal bool ACAIFCGHFEF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x2228580", Offset = "0x2227980", VA = "0x182228580")]
			internal void KOMLHFNBHLE(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x22250F0", Offset = "0x22244F0", VA = "0x1822250F0")]
			internal bool BKNFPHBDGFI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x2226610", Offset = "0x2225A10", VA = "0x182226610")]
			internal bool ENIJPBAKIEB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x2227010", Offset = "0x2226410", VA = "0x182227010")]
			internal void GFHCEFDIHPG(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x2228860", Offset = "0x2227C60", VA = "0x182228860")]
			internal List<IPIAMIIJCIF> LLKCFFOMGDN(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x2224EF0", Offset = "0x22242F0", VA = "0x182224EF0")]
			internal bool BACCHGIGOMJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x2227420", Offset = "0x2226820", VA = "0x182227420")]
			internal int GOKAFIHCPNF()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x2226700", Offset = "0x2225B00", VA = "0x182226700")]
			internal void EOKEJHBMPNJ(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x22270E0", Offset = "0x22264E0", VA = "0x1822270E0")]
			internal bool GGLDJJDJGGC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x2228250", Offset = "0x2227650", VA = "0x182228250")]
			internal bool KGCMHPHOMII()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x2225B60", Offset = "0x2224F60", VA = "0x182225B60")]
			internal bool DLKKFBKJNOB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x2228090", Offset = "0x2227490", VA = "0x182228090")]
			internal int JOCEHEDHNNC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x2225720", Offset = "0x2224B20", VA = "0x182225720")]
			internal void DAMHKDOKEJB(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x2225A60", Offset = "0x2224E60", VA = "0x182225A60")]
			internal bool DKCLJDBGELK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x2225570", Offset = "0x2224970", VA = "0x182225570")]
			internal bool CKOKHONCILN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x2227130", Offset = "0x2226530", VA = "0x182227130")]
			internal bool GHEKOLANNDM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x22259C0", Offset = "0x2224DC0", VA = "0x1822259C0")]
			internal bool DJEMLDNCLGF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x22265C0", Offset = "0x22259C0", VA = "0x1822265C0")]
			internal bool ENCNFCCJEHN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x22254D0", Offset = "0x22248D0", VA = "0x1822254D0")]
			internal bool CGECFCKHNBF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x222F510", Offset = "0x222E910", VA = "0x18222F510")]
			internal string OGINLCBDEGI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x2227470", Offset = "0x2226870", VA = "0x182227470")]
			internal void GPHOBJFALEB(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x2224B60", Offset = "0x2223F60", VA = "0x182224B60")]
			internal int ADDIJGJICLK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x2227BB0", Offset = "0x2226FB0", VA = "0x182227BB0")]
			internal void JEKECKNCLAG(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x222F1F0", Offset = "0x222E5F0", VA = "0x18222F1F0")]
			internal bool NILIGIHCOBM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x222EEC0", Offset = "0x222E2C0", VA = "0x18222EEC0")]
			internal bool MNNBJPFONGL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x2227A50", Offset = "0x2226E50", VA = "0x182227A50")]
			internal bool JABAAKEAMNF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x2225330", Offset = "0x2224730", VA = "0x182225330")]
			internal float CDPHKKOBHFE()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x2225280", Offset = "0x2224680", VA = "0x182225280")]
			internal void CCIFALHBIBE(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x2227FA0", Offset = "0x22273A0", VA = "0x182227FA0")]
			internal bool JKAFMLJCMIL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x2226F00", Offset = "0x2226300", VA = "0x182226F00")]
			internal bool GCPMPMOKFPE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x22283E0", Offset = "0x22277E0", VA = "0x1822283E0")]
			internal bool KIPABFGHHGJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x22282A0", Offset = "0x22276A0", VA = "0x1822282A0")]
			internal bool KGJDDOJNAAE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x2227330", Offset = "0x2226730", VA = "0x182227330")]
			internal bool GKPKGAMAGMJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x2225C50", Offset = "0x2225050", VA = "0x182225C50")]
			internal bool DNFKOBAOBBJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x2225CA0", Offset = "0x22250A0", VA = "0x182225CA0")]
			internal void DNOGINKHJIP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x222F330", Offset = "0x222E730", VA = "0x18222F330")]
			internal string NPOALLOBOCB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x2228130", Offset = "0x2227530", VA = "0x182228130")]
			internal void KEBCGJGMIGI(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x2226B20", Offset = "0x2225F20", VA = "0x182226B20")]
			internal bool FLNLEAOJNMF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x222F780", Offset = "0x222EB80", VA = "0x18222F780")]
			internal bool PFLFGLBGKLB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x22263E0", Offset = "0x22257E0", VA = "0x1822263E0")]
			internal bool EFNMBHEMLFB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x2227CD0", Offset = "0x22270D0", VA = "0x182227CD0")]
			internal void JJPHDCGEPBA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x2226150", Offset = "0x2225550", VA = "0x182226150")]
			internal bool EBNMIKNKFNN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x22255C0", Offset = "0x22249C0", VA = "0x1822255C0")]
			internal bool CMGKLMCPHMM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x222ED00", Offset = "0x222E100", VA = "0x18222ED00")]
			internal bool MKIJGFJJJLJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x222F5B0", Offset = "0x222E9B0", VA = "0x18222F5B0")]
			internal bool OILCGEHHDPG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x2224CA0", Offset = "0x22240A0", VA = "0x182224CA0")]
			internal void AHKFKPOECOA(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x2227680", Offset = "0x2226A80", VA = "0x182227680")]
			internal bool HFIAAFIPCBO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x22285E0", Offset = "0x22279E0", VA = "0x1822285E0")]
			internal bool LEMOJOCOLAD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x2228770", Offset = "0x2227B70", VA = "0x182228770")]
			internal bool LKKJICNLKIA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x2225380", Offset = "0x2224780", VA = "0x182225380")]
			internal bool CEOCNMPMHII()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x2227580", Offset = "0x2226980", VA = "0x182227580")]
			internal void HBOAPDDIKOI(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x222F020", Offset = "0x222E420", VA = "0x18222F020")]
			internal bool NCJGNPACCFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x222F380", Offset = "0x222E780", VA = "0x18222F380")]
			internal bool ODEIGKMFHLL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x2228810", Offset = "0x2227C10", VA = "0x182228810")]
			internal bool LLDIFLNIAJG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x22261F0", Offset = "0x22255F0", VA = "0x1822261F0")]
			internal bool ECPPCLBIIEJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x2224FE0", Offset = "0x22243E0", VA = "0x182224FE0")]
			internal object BIJDONBKADB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x222EB70", Offset = "0x222DF70", VA = "0x18222EB70")]
			internal void MFAMINBLJFP(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x22282F0", Offset = "0x22276F0", VA = "0x1822282F0")]
			internal bool KHKFLNCJDKK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x22269C0", Offset = "0x2225DC0", VA = "0x1822269C0")]
			internal bool FKEDMPDAIIP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x2228480", Offset = "0x2227880", VA = "0x182228480")]
			internal int KMNIHKBOBBP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x2224E40", Offset = "0x2224240", VA = "0x182224E40")]
			internal void APBOFOKHLKH(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x2225880", Offset = "0x2224C80", VA = "0x182225880")]
			internal bool DEOEJNGKMBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x2225830", Offset = "0x2224C30", VA = "0x182225830")]
			internal bool DDMIMMPJNMD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x2228680", Offset = "0x2227A80", VA = "0x182228680")]
			internal int LHLIMNEOCPJ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x2226380", Offset = "0x2225780", VA = "0x182226380")]
			internal void EFMNKIDDCJK(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x2226870", Offset = "0x2225C70", VA = "0x182226870")]
			internal bool FIELFJLAKKI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x2226100", Offset = "0x2225500", VA = "0x182226100")]
			internal bool EADPOICNDFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x2227770", Offset = "0x2226B70", VA = "0x182227770")]
			internal bool HNFJIIKDPFG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x222F910", Offset = "0x222ED10", VA = "0x18222F910")]
			internal int PNBJNFKOIEK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x222EE60", Offset = "0x222E260", VA = "0x18222EE60")]
			internal void MMGKGHCHPNM(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x22261A0", Offset = "0x22255A0", VA = "0x1822261A0")]
			internal bool ECKBEBINGGN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x222EA10", Offset = "0x222DE10", VA = "0x18222EA10")]
			internal bool LLOLBFOJMNM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x222F420", Offset = "0x222E820", VA = "0x18222F420")]
			internal bool ODMKGBBPGOL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x2226550", Offset = "0x2225950", VA = "0x182226550")]
			internal object EMOAPIMDLNB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x222F6A0", Offset = "0x222EAA0", VA = "0x18222F6A0")]
			internal void PBFGKKKBDCD(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x2227C10", Offset = "0x2227010", VA = "0x182227C10")]
			internal bool JFFFPOGMFFP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x22272E0", Offset = "0x22266E0", VA = "0x1822272E0")]
			internal bool GKCNOKJLGMH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x2227AA0", Offset = "0x2226EA0", VA = "0x182227AA0")]
			internal object JBFCFOAPKDB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x2226CD0", Offset = "0x22260D0", VA = "0x182226CD0")]
			internal void FPEFODEJFJP(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x22260B0", Offset = "0x22254B0", VA = "0x1822260B0")]
			internal bool DPOLCALOHFA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x2226820", Offset = "0x2225C20", VA = "0x182226820")]
			internal int FEKHKLCONCM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x2227900", Offset = "0x2226D00", VA = "0x182227900")]
			internal void IILOKLJFMNM(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x22268C0", Offset = "0x2225CC0", VA = "0x1822268C0")]
			internal bool FIGIGGKLHKP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x2227B10", Offset = "0x2226F10", VA = "0x182227B10")]
			internal bool JCAIEFKCEED()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x2227290", Offset = "0x2226690", VA = "0x182227290")]
			internal bool GJLEOEEGHAA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x22287C0", Offset = "0x2227BC0", VA = "0x1822287C0")]
			internal int LKMGPDINNCB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x2226910", Offset = "0x2225D10", VA = "0x182226910")]
			internal void FIPJIGMKCPC(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x2226290", Offset = "0x2225690", VA = "0x182226290")]
			internal bool EEFHPKCACEF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x22267D0", Offset = "0x2225BD0", VA = "0x1822267D0")]
			internal bool FCHJLPPHEPL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x22253D0", Offset = "0x22247D0", VA = "0x1822253D0")]
			internal bool CFEBFJBKABE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x2225610", Offset = "0x2224A10", VA = "0x182225610")]
			internal float CNAOEGDOCPL()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x22281A0", Offset = "0x22275A0", VA = "0x1822281A0")]
			internal void KEMNMNLLEOI(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x2227630", Offset = "0x2226A30", VA = "0x182227630")]
			internal bool HCLGGAFDCOM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x222EC00", Offset = "0x222E000", VA = "0x18222EC00")]
			internal bool MFFNDLEKNPE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x2224D00", Offset = "0x2224100", VA = "0x182224D00")]
			internal bool AMELIDOHPPB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x222F240", Offset = "0x222E640", VA = "0x18222F240")]
			internal float NJIBFCEMNIM()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x2225470", Offset = "0x2224870", VA = "0x182225470")]
			internal void CFGHPMEPPAI(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x2225660", Offset = "0x2224A60", VA = "0x182225660")]
			internal bool CNIMPNHBHFI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x2225970", Offset = "0x2224D70", VA = "0x182225970")]
			internal bool DIHPNKCNKJF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x2224DF0", Offset = "0x22241F0", VA = "0x182224DF0")]
			internal string APADCDGOMIA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x222F130", Offset = "0x222E530", VA = "0x18222F130")]
			internal void NGEGLKMPGBJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x2225520", Offset = "0x2224920", VA = "0x182225520")]
			internal bool CHILICNEOIL(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x2227720", Offset = "0x2226B20", VA = "0x182227720")]
			internal bool HMLKOJLJDDC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x222EFD0", Offset = "0x222E3D0", VA = "0x18222EFD0")]
			internal bool NCAHLFAOAOC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x222F650", Offset = "0x222EA50", VA = "0x18222F650")]
			internal bool OLADKJJLOHE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x2225A10", Offset = "0x2224E10", VA = "0x182225A10")]
			internal string DJJOCOPBJAO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x222F0C0", Offset = "0x222E4C0", VA = "0x18222F0C0")]
			internal void NFDLAGHCBBJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x22280E0", Offset = "0x22274E0", VA = "0x1822280E0")]
			internal bool JOGPLMNCFAA(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x2224C00", Offset = "0x2224000", VA = "0x182224C00")]
			internal bool AHAIMLJIJOB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x2228040", Offset = "0x2227440", VA = "0x182228040")]
			internal bool JNOHACGIDAF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x2227810", Offset = "0x2226C10", VA = "0x182227810")]
			internal bool HOHCPCBILIL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x2226060", Offset = "0x2225460", VA = "0x182226060")]
			internal string DOAHGLBONHE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x2227180", Offset = "0x2226580", VA = "0x182227180")]
			internal void GHJGMJNMOAN(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x222F870", Offset = "0x222EC70", VA = "0x18222F870")]
			internal bool PLIONNEKGEF(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x2226660", Offset = "0x2225A60", VA = "0x182226660")]
			internal bool EODJAFMIDJL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x222F3D0", Offset = "0x222E7D0", VA = "0x18222F3D0")]
			internal bool ODKMIJOJIAB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x2226240", Offset = "0x2225640", VA = "0x182226240")]
			internal bool EDMBKJPDGOF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x222F1A0", Offset = "0x222E5A0", VA = "0x18222F1A0")]
			internal string NIJIINFKCIJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x222EF10", Offset = "0x222E310", VA = "0x18222EF10")]
			internal void MOLKKJAOJNO(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x22262E0", Offset = "0x22256E0", VA = "0x1822262E0")]
			internal bool EEMPMDONCDM(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x22276D0", Offset = "0x2226AD0", VA = "0x1822276D0")]
			internal bool HHDACEJAJHK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x222F7D0", Offset = "0x222EBD0", VA = "0x18222F7D0")]
			internal bool PFLMODPIEGB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x22258D0", Offset = "0x2224CD0", VA = "0x1822258D0")]
			internal bool DHBGMLMELPO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x2226E60", Offset = "0x2226260", VA = "0x182226E60")]
			internal string GBPJJFNKNIK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x222EAB0", Offset = "0x222DEB0", VA = "0x18222EAB0")]
			internal void MABKLDEKODC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x2226970", Offset = "0x2225D70", VA = "0x182226970")]
			internal bool FKDGKPGNANE(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x2226A80", Offset = "0x2225E80", VA = "0x182226A80")]
			internal bool FLGMJKBMAPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x222F960", Offset = "0x222ED60", VA = "0x18222F960")]
			internal bool PNDHOJCAMMN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x2225BB0", Offset = "0x2224FB0", VA = "0x182225BB0")]
			internal bool DNADGJLLAKL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x2225420", Offset = "0x2224820", VA = "0x182225420")]
			internal string CFFICKIPIOK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x222EDF0", Offset = "0x222E1F0", VA = "0x18222EDF0")]
			internal void MMFDICMHIDL(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x22266B0", Offset = "0x2225AB0", VA = "0x1822266B0")]
			internal bool EOHJGILBDPP(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x222EA60", Offset = "0x222DE60", VA = "0x18222EA60")]
			internal bool LNBNOCCODOA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x222F8C0", Offset = "0x222ECC0", VA = "0x18222F8C0")]
			internal bool PLJBOEAGOFA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x2225C00", Offset = "0x2225000", VA = "0x182225C00")]
			internal bool DNFEPOMKCIB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x22250A0", Offset = "0x22244A0", VA = "0x1822250A0")]
			internal string BIPKMIEDPPE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x22256B0", Offset = "0x2224AB0", VA = "0x1822256B0")]
			internal void DAJHIKEGGFL(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x2227FF0", Offset = "0x22273F0", VA = "0x182227FF0")]
			internal bool JMNPHAKHFCL(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x2224F40", Offset = "0x2224340", VA = "0x182224F40")]
			internal bool BDBKHCGKAMB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x2227860", Offset = "0x2226C60", VA = "0x182227860")]
			internal bool HOLJIFLHMLN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x22286D0", Offset = "0x2227AD0", VA = "0x1822286D0")]
			internal bool LJDAOFLAKCM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x2224BB0", Offset = "0x2223FB0", VA = "0x182224BB0")]
			internal string AFPADMNFBBA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x2227C60", Offset = "0x2227060", VA = "0x182227C60")]
			internal void JHDCOGIJGGG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x222EB20", Offset = "0x222DF20", VA = "0x18222EB20")]
			internal bool MCLGNPMIKHK(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x2227960", Offset = "0x2226D60", VA = "0x182227960")]
			internal bool IKCJIEBOMCF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x2224D50", Offset = "0x2224150", VA = "0x182224D50")]
			internal bool ANMCEDMPKCI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x2227A00", Offset = "0x2226E00", VA = "0x182227A00")]
			internal bool INJGJPNAEKC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x222F470", Offset = "0x222E870", VA = "0x18222F470")]
			internal string OEGFIDIBIMP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x2226760", Offset = "0x2225B60", VA = "0x182226760")]
			internal void EOOEDNDMBHF(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x2228200", Offset = "0x2227600", VA = "0x182228200")]
			internal bool KFEGENJPHME(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x2226AD0", Offset = "0x2225ED0", VA = "0x182226AD0")]
			internal bool FLMMEEMMEKH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x222F820", Offset = "0x222EC20", VA = "0x18222F820")]
			internal bool PJMCHGLDNAA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x2225230", Offset = "0x2224630", VA = "0x182225230")]
			internal bool BPEGHDACEDE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x2226B70", Offset = "0x2225F70", VA = "0x182226B70")]
			internal string FMKMCDOIGEG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x2226F50", Offset = "0x2226350", VA = "0x182226F50")]
			internal void GDJPAOHMMOD(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x2226EB0", Offset = "0x22262B0", VA = "0x182226EB0")]
			internal bool GCJHDMCIEKF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x2224F90", Offset = "0x2224390", VA = "0x182224F90")]
			internal bool BHGFBNHGKIJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x2226C20", Offset = "0x2226020", VA = "0x182226C20")]
			internal bool FNDONLDBJIL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x2225140", Offset = "0x2224540", VA = "0x182225140")]
			internal string BKPMAMDJCCH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x22264E0", Offset = "0x22258E0", VA = "0x1822264E0")]
			internal void EMJEAFOIGGG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x222F290", Offset = "0x222E690", VA = "0x18222F290")]
			internal bool NJNLNFKAONL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x2227380", Offset = "0x2226780", VA = "0x182227380")]
			internal bool GMNGIPLIODO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x2228530", Offset = "0x2227930", VA = "0x182228530")]
			internal bool KNGMMDHMEBA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x22275E0", Offset = "0x22269E0", VA = "0x1822275E0")]
			internal string HBOFHPGMNNK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x2226A10", Offset = "0x2225E10", VA = "0x182226A10")]
			internal void FLACMANELBA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x22251E0", Offset = "0x22245E0", VA = "0x1822251E0")]
			internal bool BNKEMIMAJBO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x22279B0", Offset = "0x2226DB0", VA = "0x1822279B0")]
			internal bool IMKJKENCLCN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x2227B60", Offset = "0x2226F60", VA = "0x182227B60")]
			internal bool JDKCOKFJHAO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x22271F0", Offset = "0x22265F0", VA = "0x1822271F0")]
			internal string GIGDGGGFCMH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x2227070", Offset = "0x2226470", VA = "0x182227070")]
			internal void GGFNPNOOGFI(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x222F2E0", Offset = "0x222E6E0", VA = "0x18222F2E0")]
			internal bool NLAOBAGKFNL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x2228720", Offset = "0x2227B20", VA = "0x182228720")]
			internal bool LKBOLHPJMKK(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x2228340", Offset = "0x2227740", VA = "0x182228340")]
			internal float KIEKNECJJIL()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x2226C70", Offset = "0x2226070", VA = "0x182226C70")]
			internal void FONGNHKKIKA(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x222EDA0", Offset = "0x222E1A0", VA = "0x18222EDA0")]
			internal bool MMFDGDFNJJJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x2224DA0", Offset = "0x22241A0", VA = "0x182224DA0")]
			internal bool AODJIKEAAAN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x2228430", Offset = "0x2227830", VA = "0x182228430")]
			internal bool KKEMAPBFIPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x2227530", Offset = "0x2226930", VA = "0x182227530")]
			internal int HBDLKEBJPJD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x2226430", Offset = "0x2225830", VA = "0x182226430")]
			internal void EKHOEANKNFM(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x2225780", Offset = "0x2224B80", VA = "0x182225780")]
			internal bool DAMMEJFMBPK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x2228390", Offset = "0x2227790", VA = "0x182228390")]
			internal bool KIOBDAMOBBN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x2224C50", Offset = "0x2224050", VA = "0x182224C50")]
			internal bool AHJMINJHEHC()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class MPKJIFHFONC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public FGHKMNGLPGB CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public MPKJIFHFONC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x223AE10", Offset = "0x223A210", VA = "0x18223AE10")]
			internal void HPMNBOHHLDB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class OLADPBCJJBM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public OLADPBCJJBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x223E430", Offset = "0x223D830", VA = "0x18223E430")]
			internal bool ABMCPGHEOCE(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly PPIBFCENDBJ PCDPJKNPOEH;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x223DAA0", Offset = "0x223CEA0", VA = "0x18223DAA0")]
		public NKAOOIGHEKG(FIJILADMNPM GAMOFPOOCDL, JCJDDJMCHFN NAALEPHLNNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x223BCC0", Offset = "0x223B0C0", VA = "0x18223BCC0", Slot = "120")]
		protected override void CGGIMGMFBCB(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class DCDJJAMNLFD : CBFKBBMPLFF<OCAOCCLFGHO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class LEOLOCILEHF
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
				public LEOLOCILEHF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				private TaskAwaiter<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002A5")]
				[Cpp2IlInjected.Address(RVA = "0x225C180", Offset = "0x225B580", VA = "0x18225C180", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0x8E9810", Offset = "0x8E8C10", VA = "0x1808E9810", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public DCDJJAMNLFD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public AIKABKBAPKL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public LEOLOCILEHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x22573E0", Offset = "0x22567E0", VA = "0x1822573E0")]
			internal string OFEPEICKFOE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x2257310", Offset = "0x2256710", VA = "0x182257310")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void MIAIGBOCOPO(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x2257230", Offset = "0x2256630", VA = "0x182257230")]
			internal int BNIDHODELDK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x2257280", Offset = "0x2256680", VA = "0x182257280")]
			internal void JAAFLMLAICB(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override NodeVisualizationKey NOMMKAICFPN
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xBD1E40", Offset = "0xBD1240", VA = "0x180BD1E40", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x22443B0", Offset = "0x22437B0", VA = "0x1822443B0")]
		public DCDJJAMNLFD(FIJILADMNPM GAMOFPOOCDL, OCAOCCLFGHO KPECMEHKPOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x2244060", Offset = "0x2243460", VA = "0x182244060", Slot = "120")]
		protected override void CGGIMGMFBCB(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public sealed class MBGBKBOEOPN : CBFKBBMPLFF<LJNNEAILOIB>
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private sealed class MHKKIDPOEAC
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
				public MHKKIDPOEAC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000180")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000181")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000182")]
				private TaskAwaiter<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BA")]
				[Cpp2IlInjected.Address(RVA = "0x225C490", Offset = "0x225B890", VA = "0x18225C490", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BB")]
				[Cpp2IlInjected.Address(RVA = "0x8E9810", Offset = "0x8E8C10", VA = "0x1808E9810", Slot = "5")]
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
				public MHKKIDPOEAC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000188")]
				private TaskAwaiter<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x225C7D0", Offset = "0x225BBD0", VA = "0x18225C7D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0x8E9810", Offset = "0x8E8C10", VA = "0x1808E9810", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public MBGBKBOEOPN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public AIKABKBAPKL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public MHKKIDPOEAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x225A1D0", Offset = "0x22595D0", VA = "0x18225A1D0")]
			internal string OFEPEICKFOE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x225A100", Offset = "0x2259500", VA = "0x18225A100")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void MIAIGBOCOPO(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x2259B90", Offset = "0x2258F90", VA = "0x182259B90")]
			internal int BNIDHODELDK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x2259F80", Offset = "0x2259380", VA = "0x182259F80")]
			internal void JAAFLMLAICB(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x2259F30", Offset = "0x2259330", VA = "0x182259F30")]
			internal string ICMDGIABAPK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x2259BE0", Offset = "0x2258FE0", VA = "0x182259BE0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void DLHKKGNEGFB(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x225A010", Offset = "0x2259410", VA = "0x18225A010")]
			internal bool KMPOOIIGEJG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x2259DD0", Offset = "0x22591D0", VA = "0x182259DD0")]
			internal void GHMCHHFEBPO(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x225A060", Offset = "0x2259460", VA = "0x18225A060")]
			internal bool MFMPFAACMNM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x2259CB0", Offset = "0x22590B0", VA = "0x182259CB0")]
			internal void EFEHODCOJHE(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x225A0B0", Offset = "0x22594B0", VA = "0x18225A0B0")]
			internal float MHBNCJJIGCO()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x2259D40", Offset = "0x2259140", VA = "0x182259D40")]
			internal void GBMEFNLACNA(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x2259E60", Offset = "0x2259260", VA = "0x182259E60")]
			internal int GIEALLKIKEM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x2259AF0", Offset = "0x2258EF0", VA = "0x182259AF0")]
			internal void ACMEEDHHAKJ(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x2259EC0", Offset = "0x22592C0", VA = "0x182259EC0")]
			internal bool GOGKKFJHJDN()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey NOMMKAICFPN
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0xBD1E40", Offset = "0xBD1240", VA = "0x180BD1E40", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x2259780", Offset = "0x2258B80", VA = "0x182259780")]
		public MBGBKBOEOPN(FIJILADMNPM GAMOFPOOCDL, LJNNEAILOIB NAALEPHLNNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x2258D40", Offset = "0x2258140", VA = "0x182258D40", Slot = "120")]
		protected override void CGGIMGMFBCB(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class HPLLPIPEKDJ : CBFKBBMPLFF<LMFNFIIDIOC>
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class MFBPOEBJAFN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public AIKABKBAPKL nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public HPLLPIPEKDJ <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public MFBPOEBJAFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x2259A50", Offset = "0x2258E50", VA = "0x182259A50")]
			internal Dictionary<string, LEGPHPNPHAK> OFEPEICKFOE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x2259A00", Offset = "0x2258E00", VA = "0x182259A00")]
			internal int MIAIGBOCOPO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x2259860", Offset = "0x2258C60", VA = "0x182259860")]
			internal void BNIDHODELDK(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x2259980", Offset = "0x2258D80", VA = "0x182259980")]
			internal bool JAAFLMLAICB()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey NOMMKAICFPN
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xBD1E40", Offset = "0xBD1240", VA = "0x180BD1E40", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x224F770", Offset = "0x224EB70", VA = "0x18224F770")]
		public HPLLPIPEKDJ(FIJILADMNPM GAMOFPOOCDL, LMFNFIIDIOC KPECMEHKPOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x224F4A0", Offset = "0x224E8A0", VA = "0x18224F4A0", Slot = "120")]
		protected override void CGGIMGMFBCB(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class BCKEGGNGOAJ : CBFKBBMPLFF<OIILDGIHBFB>
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private sealed class BGFFDBNPOEF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public AIKABKBAPKL nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public BCKEGGNGOAJ <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public BGFFDBNPOEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x2242960", Offset = "0x2241D60", VA = "0x182242960")]
			internal void OFEPEICKFOE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey NOMMKAICFPN
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0xBD1E40", Offset = "0xBD1240", VA = "0x180BD1E40", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x2242810", Offset = "0x2241C10", VA = "0x182242810")]
		public BCKEGGNGOAJ(FIJILADMNPM GAMOFPOOCDL, OIILDGIHBFB KPECMEHKPOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x2242690", Offset = "0x2241A90", VA = "0x182242690", Slot = "120")]
		protected override void CGGIMGMFBCB(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private sealed class HGOMFNOFEAG : MMAKHJACMMJ<KDLLGBFHCED>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool EHDONNIIIMP
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override bool FKBGAFFODMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x224F460", Offset = "0x224E860", VA = "0x18224F460", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override NodeVisualizationKey NOMMKAICFPN
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x923580", Offset = "0x922980", VA = "0x180923580", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x224F400", Offset = "0x224E800", VA = "0x18224F400")]
		public HGOMFNOFEAG(FIJILADMNPM GAMOFPOOCDL, KDLLGBFHCED NAALEPHLNNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "120")]
		protected override void CGGIMGMFBCB(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	private sealed class AAIGPPGIJPB : CBFKBBMPLFF<LMPFDHOOJFC>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override NodeVisualizationKey NOMMKAICFPN
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xB92E40", Offset = "0xB92240", VA = "0x180B92E40", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x2241200", Offset = "0x2240600", VA = "0x182241200")]
		public AAIGPPGIJPB(FIJILADMNPM GAMOFPOOCDL, LMPFDHOOJFC NAALEPHLNNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "120")]
		protected override void CGGIMGMFBCB(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class IIKKPMIJAPL : CBFKBBMPLFF<OIMAFGPAALE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override NodeVisualizationKey NOMMKAICFPN
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x9281B0", Offset = "0x9275B0", VA = "0x1809281B0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x224F900", Offset = "0x224ED00", VA = "0x18224F900")]
		public IIKKPMIJAPL(FIJILADMNPM GAMOFPOOCDL, OIMAFGPAALE NAALEPHLNNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "112")]
		protected override bool EFDFEFEKGJO(KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "120")]
		protected override void CGGIMGMFBCB(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class LDHKMOJDBLP : CBFKBBMPLFF<BPCNGIJNLIG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override NodeVisualizationKey NOMMKAICFPN
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x931180", Offset = "0x930580", VA = "0x180931180", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool JLKFBHIIKGA
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x22571E0", Offset = "0x22565E0", VA = "0x1822571E0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected override bool JFGIDKDLHGA
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x2257170", Offset = "0x2256570", VA = "0x182257170")]
		public LDHKMOJDBLP(FIJILADMNPM GAMOFPOOCDL, BPCNGIJNLIG NAALEPHLNNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "120")]
		protected override void CGGIMGMFBCB(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private sealed class FJJEMIOBBOG : CBFKBBMPLFF<BOLOAMLPLAJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override NodeVisualizationKey NOMMKAICFPN
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x924F10", Offset = "0x924310", VA = "0x180924F10", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override bool JLKFBHIIKGA
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x224C7D0", Offset = "0x224BBD0", VA = "0x18224C7D0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		protected override bool JFGIDKDLHGA
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x224C760", Offset = "0x224BB60", VA = "0x18224C760")]
		public FJJEMIOBBOG(FIJILADMNPM GAMOFPOOCDL, BOLOAMLPLAJ NAALEPHLNNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "120")]
		protected override void CGGIMGMFBCB(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public sealed class ACCACKFPEJL : KOJHPOLGICP<DOPLIBBCFLH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		[CompilerGenerated]
		private sealed class IBLFLCDNGOP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public ACCACKFPEJL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public AIKABKBAPKL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public IBLFLCDNGOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x224F880", Offset = "0x224EC80", VA = "0x18224F880")]
			internal float MFKOMMPOBFI()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x224F7E0", Offset = "0x224EBE0", VA = "0x18224F7E0")]
			internal void BOIBLCOMILK(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x2241660", Offset = "0x2240A60", VA = "0x182241660")]
		public ACCACKFPEJL(FIJILADMNPM GAMOFPOOCDL, DOPLIBBCFLH KPECMEHKPOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x22413E0", Offset = "0x22407E0", VA = "0x1822413E0", Slot = "126")]
		protected override void FDDADDHIHEI(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public sealed class OHMGKHKCNKG : CBFKBBMPLFF<IOBDIAEIKIL>
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		[CompilerGenerated]
		private sealed class ABOAKHOAGFB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public OHMGKHKCNKG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public AIKABKBAPKL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public ABOAKHOAGFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x2241390", Offset = "0x2240790", VA = "0x182241390")]
			internal bool OFEPEICKFOE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x2241270", Offset = "0x2240670", VA = "0x182241270")]
			internal void MIAIGBOCOPO(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x225A9A0", Offset = "0x2259DA0", VA = "0x18225A9A0")]
		public OHMGKHKCNKG(FIJILADMNPM GAMOFPOOCDL, IOBDIAEIKIL KPECMEHKPOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x225A700", Offset = "0x2259B00", VA = "0x18225A700", Slot = "120")]
		protected override void CGGIMGMFBCB(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public sealed class KFOCLGPOJMP : CBFKBBMPLFF<LEENNKONKCH>
	{
		[Cpp2IlInjected.Token(Token = "0x200007D")]
		[CompilerGenerated]
		private sealed class LFGMOEFCLDH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public AIKABKBAPKL nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public KFOCLGPOJMP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public LFGMOEFCLDH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x2257A90", Offset = "0x2256E90", VA = "0x182257A90")]
			internal object OFEPEICKFOE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x22575E0", Offset = "0x22569E0", VA = "0x1822575E0")]
			internal bool GHMCHHFEBPO(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x2257840", Offset = "0x2256C40", VA = "0x182257840")]
			internal void MIAIGBOCOPO(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x2257430", Offset = "0x2256830", VA = "0x182257430")]
			internal string BNIDHODELDK(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x22576D0", Offset = "0x2256AD0", VA = "0x1822576D0")]
			internal IReadOnlyList<object> JAAFLMLAICB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x2257660", Offset = "0x2256A60", VA = "0x182257660")]
			internal bool ICMDGIABAPK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x2257590", Offset = "0x2256990", VA = "0x182257590")]
			internal bool DLHKKGNEGFB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x2257720", Offset = "0x2256B20", VA = "0x182257720")]
			internal void KMPOOIIGEJG(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x2256CA0", Offset = "0x22560A0", VA = "0x182256CA0")]
		public KFOCLGPOJMP(FIJILADMNPM GAMOFPOOCDL, LEENNKONKCH KPECMEHKPOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x2256480", Offset = "0x2255880", VA = "0x182256480", Slot = "120")]
		protected override void CGGIMGMFBCB(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public sealed class PBCBPPEBLEI : FJPPMJLMHGD<MGEONNOGIJO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override NodeVisualizationKey NOMMKAICFPN
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x927090", Offset = "0x926490", VA = "0x180927090", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x225B250", Offset = "0x225A650", VA = "0x18225B250")]
		public PBCBPPEBLEI(FIJILADMNPM GAMOFPOOCDL, MGEONNOGIJO NAALEPHLNNP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public sealed class ENFHFNDFKBH : KOJHPOLGICP<GKCCBKOHDLP>
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class NBBJEPLLCID
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public ENFHFNDFKBH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public AIKABKBAPKL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public NBBJEPLLCID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x225A2C0", Offset = "0x22596C0", VA = "0x18225A2C0")]
			internal int MFKOMMPOBFI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x225A220", Offset = "0x2259620", VA = "0x18225A220")]
			internal void BOIBLCOMILK(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x2245E80", Offset = "0x2245280", VA = "0x182245E80")]
		public ENFHFNDFKBH(FIJILADMNPM GAMOFPOOCDL, GKCCBKOHDLP KPECMEHKPOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x2245BF0", Offset = "0x2244FF0", VA = "0x182245BF0", Slot = "126")]
		protected override void FDDADDHIHEI(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public sealed class HBBLNIEFNAA : CBFKBBMPLFF<BIFEEDPCIJG>
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		[CompilerGenerated]
		private sealed class GJNODKPMLFK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public HBBLNIEFNAA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public AIKABKBAPKL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public GJNODKPMLFK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x224EA60", Offset = "0x224DE60", VA = "0x18224EA60")]
			internal bool OFEPEICKFOE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x224E9D0", Offset = "0x224DDD0", VA = "0x18224E9D0")]
			internal void MIAIGBOCOPO(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x224F140", Offset = "0x224E540", VA = "0x18224F140")]
		public HBBLNIEFNAA(FIJILADMNPM GAMOFPOOCDL, BIFEEDPCIJG KPECMEHKPOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x224EF60", Offset = "0x224E360", VA = "0x18224EF60", Slot = "120")]
		protected override void CGGIMGMFBCB(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class HCIMDBCJMLO : CBFKBBMPLFF<MBNIIPEOKIN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		[CompilerGenerated]
		private sealed class GIJEONJBFFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public HCIMDBCJMLO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public AIKABKBAPKL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public GIJEONJBFFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x224E8C0", Offset = "0x224DCC0", VA = "0x18224E8C0")]
			internal bool OFEPEICKFOE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x224E830", Offset = "0x224DC30", VA = "0x18224E830")]
			internal void MIAIGBOCOPO(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x224F390", Offset = "0x224E790", VA = "0x18224F390")]
		public HCIMDBCJMLO(FIJILADMNPM GAMOFPOOCDL, MBNIIPEOKIN KPECMEHKPOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x224F1B0", Offset = "0x224E5B0", VA = "0x18224F1B0", Slot = "120")]
		protected override void CGGIMGMFBCB(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class JLGHFLBILNP : CBFKBBMPLFF<HNIMHMCNLPE>
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		[CompilerGenerated]
		private sealed class BDBCFOFCOOO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public JLGHFLBILNP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public AIKABKBAPKL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public BDBCFOFCOOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x2242910", Offset = "0x2241D10", VA = "0x182242910")]
			internal int OFEPEICKFOE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x2242880", Offset = "0x2241C80", VA = "0x182242880")]
			internal void MIAIGBOCOPO(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x2250140", Offset = "0x224F540", VA = "0x182250140")]
		public JLGHFLBILNP(FIJILADMNPM GAMOFPOOCDL, HNIMHMCNLPE KPECMEHKPOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x224FED0", Offset = "0x224F2D0", VA = "0x18224FED0", Slot = "120")]
		protected override void CGGIMGMFBCB(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class GJLDPAHHPKK : PFMPBBHGOAI<CGOEFPOMMBK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override NHBHFBMCACF NBMANLOHOOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x91EFB0", Offset = "0x91E3B0", VA = "0x18091EFB0", Slot = "126")]
			get
			{
				return default(NHBHFBMCACF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x224E970", Offset = "0x224DD70", VA = "0x18224E970")]
		public GJLDPAHHPKK(FIJILADMNPM GAMOFPOOCDL, CGOEFPOMMBK KPECMEHKPOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class ENMHHJPNJFJ : CBFKBBMPLFF<IDOFAFFGDFF>
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x2245EE0", Offset = "0x22452E0", VA = "0x182245EE0")]
		public ENMHHJPNJFJ(FIJILADMNPM GAMOFPOOCDL, IDOFAFFGDFF NAALEPHLNNP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public abstract class CBFKBBMPLFF<TNode> : OOJIJCAGPLP, IDisposable where TNode : notnull, IDOFAFFGDFF
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		[CompilerGenerated]
		private sealed class OHCBNAPKGCG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public CBFKBBMPLFF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			public FIJILADMNPM circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public OHCBNAPKGCG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x4A560D0", Offset = "0x4A554D0", VA = "0x184A560D0")]
			internal KEKMLILCBOL EJNHEPLHFHK(MJKEJFEKEHL portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		[CompilerGenerated]
		private struct PPMLAHLMNLM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public CBFKBBMPLFF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private TaskAwaiter<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x4B4D110", Offset = "0x4B4C510", VA = "0x184B4D110", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x8E9810", Offset = "0x8E8C10", VA = "0x1808E9810", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		[CompilerGenerated]
		private struct HOBBCEFDALG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public AsyncTaskMethodBuilder<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public CBFKBBMPLFF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public IDKEDNLGPGB? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public MJMAIMONCFG? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			private TaskAwaiter<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x4166750", Offset = "0x4165B50", VA = "0x184166750", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x41669F0", Offset = "0x4165DF0", VA = "0x1841669F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008D")]
		[CompilerGenerated]
		private sealed class BHLDAPAMHJL
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
				public BHLDAPAMHJL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CB")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000396")]
				[Cpp2IlInjected.Address(RVA = "0x38B1510", Offset = "0x38B0910", VA = "0x1838B1510", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000397")]
				[Cpp2IlInjected.Address(RVA = "0x8E9810", Offset = "0x8E8C10", VA = "0x1808E9810", Slot = "5")]
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
			public AIKABKBAPKL nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public CBFKBBMPLFF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public JDDCKGCCEJC configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public BHLDAPAMHJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
			internal string MBAADICFOKP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x89A1B0", Offset = "0x8995B0", VA = "0x18089A1B0")]
			internal void POFHPNOABDN(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0x52498A0", Offset = "0x5248CA0", VA = "0x1852498A0")]
			[AsyncStateMachine(typeof(CBFKBBMPLFF<>.BHLDAPAMHJL.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void NHGKOADFGGG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		[CompilerGenerated]
		private sealed class GOFODPFANIC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public AIKABKBAPKL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public GOFODPFANIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x407B9B0", Offset = "0x407ADB0", VA = "0x18407B9B0")]
			internal bool BLPHIEIFEIJ(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x407BA90", Offset = "0x407AE90", VA = "0x18407BA90")]
			internal bool EEAEMBEBOIP(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000090")]
		[CompilerGenerated]
		private struct CHPCALLLONH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public AsyncTaskMethodBuilder<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public CBFKBBMPLFF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			private TaskAwaiter<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x5638020", Offset = "0x5637420", VA = "0x185638020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x56383A0", Offset = "0x56377A0", VA = "0x1856383A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private readonly FIJILADMNPM LNBMPNGMLBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly bool BGBOMALBNHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private NFAHJJHODAG<LJJEABOBKPI, KEKMLILCBOL> ALOCBEMGICB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private NFAHJJHODAG<LJJEABOBKPI, NNGAAJOKFAH> MDIJPGJPIDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private List<Action> IONFAPOJPJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[CompilerGenerated]
		private Action<KENIFKLGBBB<LJJEABOBKPI>>? HJMEHNFAFBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[CompilerGenerated]
		private Action<KENIFKLGBBB<LJJEABOBKPI>, NNGAAJOKFAH>? GNEGMPHAICD;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		protected CHLHIIGLCHO OPONNNBBLJG
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x5453390", Offset = "0x5452790", VA = "0x185453390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		protected AIKABKBAPKL OCGAFBPPLBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x544F0E0", Offset = "0x544E4E0", VA = "0x18544F0E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		protected TNode FCMDHLLJOLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x89EF20", Offset = "0x89E320", VA = "0x18089EF20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public EKPAMDKNMJG<HAGNHDFDPID> FBILDBFMOLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0xE4F820", Offset = "0xE4EC20", VA = "0x180E4F820", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(EKPAMDKNMJG<HAGNHDFDPID>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public KENIFKLGBBB<DPKIJKMEKCI> DJHOHIGCADA
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x54541B0", Offset = "0x54535B0", VA = "0x1854541B0", Slot = "6")]
			get
			{
				return default(KENIFKLGBBB<DPKIJKMEKCI>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public object LCJKLBHDHIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x3BFD630", Offset = "0x3BFCA30", VA = "0x183BFD630", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public virtual bool EACLCMBEPFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int HNPECLDCLPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x5453E10", Offset = "0x5453210", VA = "0x185453E10", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public IJALJJFMGAC GNNIMLGBALI
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x5453DB0", Offset = "0x54531B0", VA = "0x185453DB0", Slot = "10")]
			get
			{
				return default(IJALJJFMGAC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string HAOGNFNDKOG
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x5454350", Offset = "0x5453750", VA = "0x185454350", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		protected virtual bool JFGIDKDLHGA
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual NodeVisualizationKey NOMMKAICFPN
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public KENIFKLGBBB<MNAMPAMBJOL> ICFHFMGLCNH
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x9D80D0", Offset = "0x9D74D0", VA = "0x1809D80D0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(KENIFKLGBBB<MNAMPAMBJOL>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x9D5D30", Offset = "0x9D5130", VA = "0x1809D5D30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual bool JLKFBHIIKGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual bool EHDONNIIIMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual BLBIGABDHJF HKKOFLCPCHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0xACF680", Offset = "0xACEA80", VA = "0x180ACF680", Slot = "94")]
			get
			{
				return default(BLBIGABDHJF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool FBCMEKKMHLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x5453B20", Offset = "0x5452F20", VA = "0x185453B20", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool LPJOCOKAACN
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x5453B80", Offset = "0x5452F80", VA = "0x185453B80", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool NGKNODDHLHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x5453BE0", Offset = "0x5452FE0", VA = "0x185453BE0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int MHAAGDCCJLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x5454160", Offset = "0x5453560", VA = "0x185454160", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool KODMFHAOKDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x5453F90", Offset = "0x5453390", VA = "0x185453F90", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool CPIPMJHAIHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x5453CF0", Offset = "0x54530F0", VA = "0x185453CF0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool EHGPCPLCNDP
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x5453C90", Offset = "0x5453090", VA = "0x185453C90", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool KDECCJMGNFI
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0xAA4D80", Offset = "0xAA4180", VA = "0x180AA4D80", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0xF9CE00", Offset = "0xF9C200", VA = "0x180F9CE00")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public virtual bool FHMEAAIFPFL
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual bool KKIONBBILBL
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x5453C40", Offset = "0x5453040", VA = "0x185453C40", Slot = "96")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool DNLANGHKHKC
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x5453EC0", Offset = "0x54532C0", VA = "0x185453EC0", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public IDKEDNLGPGB BACJLKMLKEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x54540A0", Offset = "0x54534A0", VA = "0x1854540A0", Slot = "28")]
			get
			{
				return default(IDKEDNLGPGB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public MJMAIMONCFG LLBOOPLHGGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x5454100", Offset = "0x5453500", VA = "0x185454100", Slot = "30")]
			get
			{
				return default(MJMAIMONCFG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool NOFLDGMOABD
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "108")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual DCCHBOOLAJN? JKLFLLOPJOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40", Slot = "109")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual KBHFAMABKMD? LCDOBGGHNNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40", Slot = "110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual IEnumerable<EKPAMDKNMJG<OJMKIAECBHB>>? FEMADONHPJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool PKJAONPMDEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x5453D50", Offset = "0x5453150", VA = "0x185453D50", Slot = "114")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public EKPAMDKNMJG<HBIMBCKJJCB> OGIFLKGMGOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x5453FE0", Offset = "0x54533E0", VA = "0x185453FE0", Slot = "62")]
			get
			{
				return default(EKPAMDKNMJG<HBIMBCKJJCB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public KENIFKLGBBB<HBIMBCKJJCB> JFFLAICHMGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x5453E60", Offset = "0x5453260", VA = "0x185453E60", Slot = "56")]
			get
			{
				return default(KENIFKLGBBB<HBIMBCKJJCB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public virtual bool IPEOOMJFCLL
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public virtual KENIFKLGBBB<HBIMBCKJJCB>? NAGCMDELHFC
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public virtual bool FKBGAFFODMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool HBEEHLFPBLL
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x5453F20", Offset = "0x5453320", VA = "0x185453F20", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string MKBLEONOOOC
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x89FC50", Offset = "0x89F050", VA = "0x18089FC50", Slot = "64")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x89FCD0", Offset = "0x89F0D0", VA = "0x18089FCD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		private string BILMFAFJNLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x89FBF0", Offset = "0x89EFF0", VA = "0x18089FBF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public EKPAMDKNMJG<OJMKIAECBHB> DFHPBCFNIFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x5454040", Offset = "0x5453440", VA = "0x185454040", Slot = "63")]
			get
			{
				return default(EKPAMDKNMJG<OJMKIAECBHB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public EKPAMDKNMJG<OJMKIAECBHB>? HIFOIOILFHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x5454230", Offset = "0x5453630", VA = "0x185454230", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public BGMIADDEGIF<LJJEABOBKPI, NNGAAJOKFAH> DCJNNGGABAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x5454310", Offset = "0x5453710", VA = "0x185454310", Slot = "65")]
			get
			{
				return default(BGMIADDEGIF<LJJEABOBKPI, NNGAAJOKFAH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public virtual KENIFKLGBBB<LJJEABOBKPI>? NJDNNNCHIPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public virtual bool JBMCALIGLFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public virtual bool DOLPPCCKNKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "123")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action MBHIOLNKFOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x5452650", Offset = "0x5451A50", VA = "0x185452650", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x5450760", Offset = "0x544FB60", VA = "0x185450760", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event GEAALMNOBON AFJDPLJBJKE
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x54508C0", Offset = "0x544FCC0", VA = "0x1854508C0", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x54521B0", Offset = "0x54515B0", VA = "0x1854521B0", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event DPJINNEAHAM FEKINEHEBGA
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x544EE70", Offset = "0x544E270", VA = "0x18544EE70", Slot = "41")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x5452570", Offset = "0x5451970", VA = "0x185452570", Slot = "42")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action FKJPCNJIOLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x544F660", Offset = "0x544EA60", VA = "0x18544F660", Slot = "43")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x5450B50", Offset = "0x544FF50", VA = "0x185450B50", Slot = "44")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action HFENLMDGHGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x544F040", Offset = "0x544E440", VA = "0x18544F040", Slot = "45")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x5450560", Offset = "0x544F960", VA = "0x185450560", Slot = "46")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<KENIFKLGBBB<LJJEABOBKPI>, NNGAAJOKFAH> KGEOFIHKLBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x5450A90", Offset = "0x544FE90", VA = "0x185450A90", Slot = "67")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x544FAA0", Offset = "0x544EEA0", VA = "0x18544FAA0", Slot = "68")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<KENIFKLGBBB<LJJEABOBKPI>, NNGAAJOKFAH> PAOGJAIOHOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x54509D0", Offset = "0x544FDD0", VA = "0x1854509D0", Slot = "71")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x544FB60", Offset = "0x544EF60", VA = "0x18544FB60", Slot = "72")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<KENIFKLGBBB<LJJEABOBKPI>> IFJLJLKHFCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x5450800", Offset = "0x544FC00", VA = "0x185450800", Slot = "69")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x544F9E0", Offset = "0x544EDE0", VA = "0x18544F9E0", Slot = "70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<KENIFKLGBBB<LJJEABOBKPI>, KENIFKLGBBB<LJJEABOBKPI>> OPPCBOJHKLA
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x5451F30", Offset = "0x5451330", VA = "0x185451F30", Slot = "73")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x544F240", Offset = "0x544E640", VA = "0x18544F240", Slot = "74")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<KENIFKLGBBB<LJJEABOBKPI>, NNGAAJOKFAH> HPLNHGNBJNB
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x544F300", Offset = "0x544E700", VA = "0x18544F300", Slot = "75")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x544FC20", Offset = "0x544F020", VA = "0x18544FC20", Slot = "76")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<KENIFKLGBBB<LJJEABOBKPI>, KENIFKLGBBB<LJJEABOBKPI>> GKLMEKGFFLL
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x54520F0", Offset = "0x54514F0", VA = "0x1854520F0", Slot = "77")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x5451FF0", Offset = "0x54513F0", VA = "0x185451FF0", Slot = "78")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x5453540", Offset = "0x5452940", VA = "0x185453540")]
		[GDCDIKCGJKC("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		[GDCDIKCGJKC("Need to handle `Name` better.")]
		protected CBFKBBMPLFF(FIJILADMNPM GAMOFPOOCDL, TNode NAALEPHLNNP, bool CBPAPLLJEDH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x54527C0", Offset = "0x5451BC0", VA = "0x1854527C0", Slot = "87")]
		protected virtual void NOCOEJHJFAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x544FCE0", Offset = "0x544F0E0", VA = "0x18544FCE0", Slot = "88")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x54524C0", Offset = "0x54518C0", VA = "0x1854524C0", Slot = "9")]
		[AsyncStateMachine(typeof(CBFKBBMPLFF<>.PPMLAHLMNLM))]
		public void MNEIDEBGGMB(int EDCFNOABMCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x5453280", Offset = "0x5452680", VA = "0x185453280")]
		public bool PKCJAIPMFJC([In] IDKEDNLGPGB PFKKDHPJFEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x544EE00", Offset = "0x544E200", VA = "0x18544EE00")]
		public bool AECJCFEMKFP([In] MJMAIMONCFG PFKKDHPJFEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x5450BB0", Offset = "0x544FFB0", VA = "0x185450BB0", Slot = "32")]
		public void IMPMCBLAOKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x54522E0", Offset = "0x54516E0", VA = "0x1854522E0", Slot = "33")]
		[AsyncStateMachine(typeof(CBFKBBMPLFF<>.HOBBCEFDALG))]
		public Task<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> LPHGBCKHJNI(IDKEDNLGPGB? LFDNCFPNICE, MJMAIMONCFG? NGPOFJJCJDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "97")]
		public virtual void BAPOFBNKCIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "98")]
		public virtual void OHJMENIILGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "99")]
		public virtual void LFHCIADGEBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xA73200", Offset = "0xA72600", VA = "0x180A73200")]
		protected void AMONFHGHLCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x991320", Offset = "0x990720", VA = "0x180991320")]
		protected void OOGMPDBMFFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x2444F40", Offset = "0x2444340", VA = "0x182444F40")]
		private void BFPFNBBMHEG([In] MJMAIMONCFG GEMHEIIKJKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x5451A10", Offset = "0x5450E10", VA = "0x185451A10", Slot = "100")]
		public virtual Task<BMFECDODLAB<KENIFKLGBBB<LJJEABOBKPI>, JLOPLHOLGBP>> KCDAOGEEJPK(string ACDGEPBIBHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x54526F0", Offset = "0x5451AF0", VA = "0x1854526F0", Slot = "101")]
		public virtual Task<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> NNKCLAOPFON(KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "102")]
		public virtual void INDNDMAGAFB(KENIFKLGBBB<LJJEABOBKPI> JGOMAIGJEJC, KENIFKLGBBB<LJJEABOBKPI> MOKGNANNIEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x5452430", Offset = "0x5451830", VA = "0x185452430", Slot = "103")]
		public virtual IEnumerable<HFDKJCIJLFF> MAKMMJHAAHE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x5452250", Offset = "0x5451650", VA = "0x185452250", Slot = "104")]
		public BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP> LJMKLGDGFME(string EACAMCBOFJF)
		{
			return default(BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x54533F0", Offset = "0x54527F0", VA = "0x1854533F0", Slot = "47")]
		public bool PPNHMCPAFNG([Out] Guid AEHGHLPIKHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x544F730", Offset = "0x544EB30", VA = "0x18544F730")]
		public bool DEJIJLBCLOH([In] Guid IDNKPJNNEPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "105")]
		public virtual void PGGELGPJGKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "106")]
		public virtual void JOIACGMNFMH(bool MFKAELIEDFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40", Slot = "107")]
		public virtual OLNIFBLHGGO LOGGPBJGDJP([In] AKOFDFGMDOJ CPJKKGMKNOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x54512F0", Offset = "0x54506F0", VA = "0x1854512F0")]
		protected void JICBJFMELHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x5450600", Offset = "0x544FA00", VA = "0x185450600", Slot = "112")]
		protected virtual bool EFDFEFEKGJO(KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "113")]
		protected virtual bool APDJJJFFIEC(KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "120")]
		protected virtual void CGGIMGMFBCB(JDDCKGCCEJC FBJFIFOCEBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x5450F00", Offset = "0x5450300", VA = "0x185450F00")]
		protected void JEPMBCNCOFO(JDDCKGCCEJC PKGIKLFNNDJ, Func<string> AIGALICOICE, Action<string> PJKBDNPPJIG, string JGPIOFBGFJD, string OKNDNBDFDGM, string LGPBODKLJLD, LNLHDOPCNFL DCEDEAINOCG, OBBHNDEFMBA FFKGONDHPEL, Func<string, bool> HBAGEKAJLPK, string BJLBOHLODDC, Func<string, bool> DDADDGPMPDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x5452FA0", Offset = "0x54523A0", VA = "0x185452FA0")]
		protected void PCPPCODNAJL(JDDCKGCCEJC PKGIKLFNNDJ, Func<string> AIGALICOICE, Action<string> PJKBDNPPJIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x544F3C0", Offset = "0x544E7C0", VA = "0x18544F3C0", Slot = "121")]
		protected virtual void CFMBFGOEKKA(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x5452EE0", Offset = "0x54522E0", VA = "0x185452EE0", Slot = "80")]
		public void OHHENGCGBHF(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x544F570", Offset = "0x544E970", VA = "0x18544F570", Slot = "81")]
		public GHEHLOPOPNH CGKMOOKIAFG()
		{
			return default(GHEHLOPOPNH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "124")]
		public virtual bool OLDAMPMKHJN(KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x183F6C0", Offset = "0x183EAC0", VA = "0x18183F6C0")]
		private void NBPDPJOEHKC([In] IDKEDNLGPGB OGKCMCMHLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x5450DB0", Offset = "0x54501B0", VA = "0x185450DB0")]
		private void JCDMFKFCMOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x54514D0", Offset = "0x54508D0", VA = "0x1854514D0")]
		private void JMKGNACEODM(KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII, MJKEJFEKEHL EDKDKOCDOEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0xBBCD50", Offset = "0xBBC150", VA = "0x180BBCD50")]
		private void EDFGPJEPMGO(KENIFKLGBBB<LJJEABOBKPI> HDCHKIOFILD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x544EF10", Offset = "0x544E310", VA = "0x18544EF10")]
		private void AKNBPNDLOFE(KENIFKLGBBB<LJJEABOBKPI> HDCHKIOFILD, MJKEJFEKEHL EFEFHNIJMMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x544EA50", Offset = "0x544DE50", VA = "0x18544EA50")]
		private void ADDFCBLLDEO(KENIFKLGBBB<LJJEABOBKPI> JGOMAIGJEJC, KENIFKLGBBB<LJJEABOBKPI> MOKGNANNIEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xBBBAF0", Offset = "0xBBAEF0", VA = "0x180BBBAF0")]
		private void NKOMKFEDBCH(KENIFKLGBBB<LJJEABOBKPI> JGOMAIGJEJC, KENIFKLGBBB<LJJEABOBKPI> MOKGNANNIEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x5280C70", Offset = "0x5280070", VA = "0x185280C70")]
		private void CJBDGNGIPIP(KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x5451AE0", Offset = "0x5450EE0", VA = "0x185451AE0")]
		private void KEEKDMBMEDD(KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII, MJKEJFEKEHL EDKDKOCDOEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x5452F30", Offset = "0x5452330", VA = "0x185452F30")]
		private void OILEPEBFIDA(KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII, MJKEJFEKEHL EFEFHNIJMMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x5450640", Offset = "0x544FA40", VA = "0x185450640", Slot = "125")]
		[AsyncStateMachine(typeof(CBFKBBMPLFF<>.CHPCALLLONH))]
		public Task<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> EPGEGPADGBH(string EACAMCBOFJF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x5450960", Offset = "0x544FD60", VA = "0x185450960", Slot = "54")]
		private void HLBNHDJFFKN(object IECMEOGLDOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x544F1D0", Offset = "0x544E5D0", VA = "0x18544F1D0", Slot = "55")]
		private void BLLILJGBNLD(object IECMEOGLDOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x54520B0", Offset = "0x54514B0", VA = "0x1854520B0", Slot = "29")]
		private bool KOGBGLKLPFD([In] IDKEDNLGPGB PFKKDHPJFEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x5451EF0", Offset = "0x54512F0", VA = "0x185451EF0", Slot = "31")]
		private bool KICLMBMEBBN([In] MJMAIMONCFG PFKKDHPJFEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x5452610", Offset = "0x5451A10", VA = "0x185452610", Slot = "48")]
		private bool NEDFPPBHJCH([In] Guid IDNKPJNNEPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x506D700", Offset = "0x506CB00", VA = "0x18506D700")]
		[CompilerGenerated]
		private string DBEJGBFJBEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x54532F0", Offset = "0x54526F0", VA = "0x1854532F0")]
		[CompilerGenerated]
		private void PLNOILPKKAN(string ACDGEPBIBHJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public sealed class CHEMFHDLEHH : FJPPMJLMHGD<LBPBHBJMFBF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public override NodeVisualizationKey NOMMKAICFPN
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x931F80", Offset = "0x931380", VA = "0x180931F80", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x22436D0", Offset = "0x2242AD0", VA = "0x1822436D0")]
		public CHEMFHDLEHH(FIJILADMNPM GAMOFPOOCDL, LBPBHBJMFBF NAALEPHLNNP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class OODCPGAHDKA : MMAKHJACMMJ<DNHLGMKNPAH>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public override NodeVisualizationKey NOMMKAICFPN
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x91EFB0", Offset = "0x91E3B0", VA = "0x18091EFB0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x225AB00", Offset = "0x2259F00", VA = "0x18225AB00")]
		public OODCPGAHDKA(FIJILADMNPM GAMOFPOOCDL, DNHLGMKNPAH NAALEPHLNNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "120")]
		protected override void CGGIMGMFBCB(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public abstract class PFMPBBHGOAI<T> : CBFKBBMPLFF<T> where T : notnull, BGCEOECOBNB
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class IICGKEOHIGA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public IReadOnlyList<KeyValuePair<string, LEGPHPNPHAK>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public PFMPBBHGOAI<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public AIKABKBAPKL nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public NHBHFBMCACF clipType;

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public IICGKEOHIGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
			internal IReadOnlyList<KeyValuePair<string, LEGPHPNPHAK>> OFEPEICKFOE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x4210260", Offset = "0x420F660", VA = "0x184210260")]
			internal int MIAIGBOCOPO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x420FB50", Offset = "0x420EF50", VA = "0x18420FB50")]
			internal void BNIDHODELDK(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x4210120", Offset = "0x420F520", VA = "0x184210120")]
			internal void JAAFLMLAICB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x420FFD0", Offset = "0x420F3D0", VA = "0x18420FFD0")]
			internal void ICMDGIABAPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x420FD70", Offset = "0x420F170", VA = "0x18420FD70")]
			internal bool DLHKKGNEGFB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x4210170", Offset = "0x420F570", VA = "0x184210170")]
			internal void KMPOOIIGEJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x420FD70", Offset = "0x420F170", VA = "0x18420FD70")]
			internal bool GHMCHHFEBPO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x42101C0", Offset = "0x420F5C0", VA = "0x1842101C0")]
			internal float MFMPFAACMNM()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x420FE00", Offset = "0x420F200", VA = "0x18420FE00")]
			internal void EFEHODCOJHE(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x4210210", Offset = "0x420F610", VA = "0x184210210")]
			internal float MHBNCJJIGCO()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x420FEC0", Offset = "0x420F2C0", VA = "0x18420FEC0")]
			internal void GBMEFNLACNA(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x420FF80", Offset = "0x420F380", VA = "0x18420FF80")]
			internal float GIEALLKIKEM()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x420FA90", Offset = "0x420EE90", VA = "0x18420FA90")]
			internal void ACMEEDHHAKJ(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override NodeVisualizationKey NOMMKAICFPN
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0xBD1E40", Offset = "0xBD1240", VA = "0x180BD1E40", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public abstract NHBHFBMCACF NBMANLOHOOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(Slot = "126")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x4B2DAB0", Offset = "0x4B2CEB0", VA = "0x184B2DAB0")]
		public PFMPBBHGOAI(FIJILADMNPM GAMOFPOOCDL, T NAALEPHLNNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x4B2CFC0", Offset = "0x4B2C3C0", VA = "0x184B2CFC0", Slot = "120")]
		protected sealed override void CGGIMGMFBCB(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private sealed class CLJFAOIAJHK : CBFKBBMPLFF<DMPCKONHFAD>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override NodeVisualizationKey NOMMKAICFPN
		{
			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x930680", Offset = "0x92FA80", VA = "0x180930680", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x2243BD0", Offset = "0x2242FD0", VA = "0x182243BD0")]
		public CLJFAOIAJHK(FIJILADMNPM GAMOFPOOCDL, DMPCKONHFAD NAALEPHLNNP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class CNCJJCIGGOG : CBFKBBMPLFF<NPBJLMGLAPN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class CIGDGDGBGHE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public CNCJJCIGGOG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public AIKABKBAPKL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public CIGDGDGBGHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x22437C0", Offset = "0x2242BC0", VA = "0x1822437C0")]
			internal int MIAIGBOCOPO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x2243730", Offset = "0x2242B30", VA = "0x182243730")]
			internal void BNIDHODELDK(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private static Dictionary<string, LEGPHPNPHAK>? CADFDGGGHEE;

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x2243FD0", Offset = "0x22433D0", VA = "0x182243FD0")]
		public CNCJJCIGGOG(FIJILADMNPM GAMOFPOOCDL, NPBJLMGLAPN NAALEPHLNNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x2243C40", Offset = "0x2243040", VA = "0x182243C40", Slot = "120")]
		protected override void CGGIMGMFBCB(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class PPCCBHLJCCD : PFMPBBHGOAI<KILJNPGHELO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public override NHBHFBMCACF NBMANLOHOOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40", Slot = "126")]
			get
			{
				return default(NHBHFBMCACF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x225BE10", Offset = "0x225B210", VA = "0x18225BE10")]
		public PPCCBHLJCCD(FIJILADMNPM GAMOFPOOCDL, KILJNPGHELO KPECMEHKPOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class GIPHKNDHGOJ : MMAKHJACMMJ<GLBELOKGNAB>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public override NodeVisualizationKey NOMMKAICFPN
		{
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x91EFB0", Offset = "0x91E3B0", VA = "0x18091EFB0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x224E910", Offset = "0x224DD10", VA = "0x18224E910")]
		public GIPHKNDHGOJ(FIJILADMNPM GAMOFPOOCDL, GLBELOKGNAB NAALEPHLNNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "120")]
		protected override void CGGIMGMFBCB(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	private sealed class JKMNIELDDJG : MMAKHJACMMJ<PKFGNKBEJHK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public override NodeVisualizationKey NOMMKAICFPN
		{
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x91EFB0", Offset = "0x91E3B0", VA = "0x18091EFB0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x224FE70", Offset = "0x224F270", VA = "0x18224FE70")]
		public JKMNIELDDJG(FIJILADMNPM GAMOFPOOCDL, PKFGNKBEJHK NAALEPHLNNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "120")]
		protected override void CGGIMGMFBCB(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class PCLJDBFHGAP : KOJHPOLGICP<JCPOFKJMJLI>
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class IPKAKHFAMHK
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
				public IPKAKHFAMHK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001E2")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40001E3")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40001E4")]
				private TaskAwaiter<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60003CB")]
				[Cpp2IlInjected.Address(RVA = "0x225BE70", Offset = "0x225B270", VA = "0x18225BE70", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CC")]
				[Cpp2IlInjected.Address(RVA = "0x8E9810", Offset = "0x8E8C10", VA = "0x1808E9810", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public AIKABKBAPKL nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public PCLJDBFHGAP <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public IPKAKHFAMHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x224FAF0", Offset = "0x224EEF0", VA = "0x18224FAF0")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void MFKOMMPOBFI(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x225B950", Offset = "0x225AD50", VA = "0x18225B950")]
		public PCLJDBFHGAP(FIJILADMNPM GAMOFPOOCDL, JCPOFKJMJLI KPECMEHKPOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x225B670", Offset = "0x225AA70", VA = "0x18225B670", Slot = "126")]
		protected override void FDDADDHIHEI(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class PADKNALFKLH : PFMPBBHGOAI<OCFAJEHIMBF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override NHBHFBMCACF NBMANLOHOOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x931180", Offset = "0x930580", VA = "0x180931180", Slot = "126")]
			get
			{
				return default(NHBHFBMCACF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x225AB60", Offset = "0x2259F60", VA = "0x18225AB60")]
		public PADKNALFKLH(FIJILADMNPM GAMOFPOOCDL, OCFAJEHIMBF KPECMEHKPOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private sealed class MBNBKPFNLGL : CBFKBBMPLFF<KKPIANLGIFK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public override NodeVisualizationKey NOMMKAICFPN
		{
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0xC42B60", Offset = "0xC41F60", VA = "0x180C42B60", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x22597F0", Offset = "0x2258BF0", VA = "0x1822597F0")]
		public MBNBKPFNLGL(FIJILADMNPM GAMOFPOOCDL, KKPIANLGIFK NAALEPHLNNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "120")]
		protected override void CGGIMGMFBCB(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public sealed class BAEMIAJIJLL : CBFKBBMPLFF<GMMPLPFIKEM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public sealed override NodeVisualizationKey NOMMKAICFPN
		{
			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public sealed override bool JLKFBHIIKGA
		{
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected sealed override bool JFGIDKDLHGA
		{
			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x2242620", Offset = "0x2241A20", VA = "0x182242620")]
		public BAEMIAJIJLL(FIJILADMNPM GAMOFPOOCDL, GMMPLPFIKEM NAALEPHLNNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x2242250", Offset = "0x2241650", VA = "0x182242250", Slot = "120")]
		protected override void CGGIMGMFBCB(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x2242580", Offset = "0x2241980", VA = "0x182242580")]
		private int DENHJOFHEKA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x22425C0", Offset = "0x22419C0", VA = "0x1822425C0")]
		private void KLCBGIFDDIF(int LFKMIMEIEKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public class PIGKJOLBGBP : ENMHHJPNJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x2245EE0", Offset = "0x22452E0", VA = "0x182245EE0")]
		public PIGKJOLBGBP(FIJILADMNPM GAMOFPOOCDL, IDOFAFFGDFF NAALEPHLNNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "120")]
		protected override void CGGIMGMFBCB(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class PJGGJJMDGHA : KOJHPOLGICP<IPJFIKIHCLN>
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x225B9B0", Offset = "0x225ADB0", VA = "0x18225B9B0")]
		public PJGGJJMDGHA(FIJILADMNPM GAMOFPOOCDL, IPJFIKIHCLN NAALEPHLNNP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public abstract class KOJHPOLGICP<TVariableNode> : CBFKBBMPLFF<TVariableNode> where TVariableNode : notnull, IPJFIKIHCLN
	{
		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private sealed class MACKCKJEMEI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public KOJHPOLGICP<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public AIKABKBAPKL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public MACKCKJEMEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x484DAA0", Offset = "0x484CEA0", VA = "0x18484DAA0")]
			internal bool OFEPEICKFOE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x484D9E0", Offset = "0x484CDE0", VA = "0x18484D9E0")]
			internal void MIAIGBOCOPO(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x484D810", Offset = "0x484CC10", VA = "0x18484D810")]
			internal bool BNIDHODELDK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x484D920", Offset = "0x484CD20", VA = "0x18484D920")]
			internal void JAAFLMLAICB(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x484D870", Offset = "0x484CC70", VA = "0x18484D870")]
			internal bool ICMDGIABAPK()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		[CompilerGenerated]
		private sealed class ABCHAMNKLMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public AIKABKBAPKL nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public KOJHPOLGICP<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public ABCHAMNKLMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x3FB40F0", Offset = "0x3FB34F0", VA = "0x183FB40F0")]
			internal void MFKOMMPOBFI(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public override NodeVisualizationKey NOMMKAICFPN
		{
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x91E870", Offset = "0x91DC70", VA = "0x18091E870", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public override BLBIGABDHJF HKKOFLCPCHG
		{
			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x453FF50", Offset = "0x453F350", VA = "0x18453FF50", Slot = "94")]
			get
			{
				return default(BLBIGABDHJF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x453FDB0", Offset = "0x453F1B0", VA = "0x18453FDB0")]
		protected KOJHPOLGICP(FIJILADMNPM GAMOFPOOCDL, TVariableNode NAALEPHLNNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x453F7C0", Offset = "0x453EBC0", VA = "0x18453F7C0", Slot = "88")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x453F330", Offset = "0x453E730", VA = "0x18453F330", Slot = "120")]
		protected override void CGGIMGMFBCB(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x453F940", Offset = "0x453ED40", VA = "0x18453F940", Slot = "126")]
		protected virtual void FDDADDHIHEI(JDDCKGCCEJC PKGIKLFNNDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x453FCC0", Offset = "0x453F0C0", VA = "0x18453FCC0", Slot = "105")]
		public override void PGGELGPJGKM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2235DB0", Offset = "0x22351B0", VA = "0x182235DB0")]
	public static OOJIJCAGPLP GIIIFAJNKEL(FIJILADMNPM GAMOFPOOCDL, IDOFAFFGDFF NAALEPHLNNP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public sealed class PANGBJCAKKN : EIBKONLCFFL, PCICDMNDAOD, MADALHNANHL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public KENIFKLGBBB<KOCMDBHIIKI> KIPHJKADCPG
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x938580", Offset = "0x937980", VA = "0x180938580", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(KENIFKLGBBB<KOCMDBHIIKI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public KENIFKLGBBB<BFLMIPIKKEL> GMLKNIAMCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0xA0B350", Offset = "0xA0A750", VA = "0x180A0B350", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(KENIFKLGBBB<BFLMIPIKKEL>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x225AC10", Offset = "0x225A010", VA = "0x18225AC10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private KENIFKLGBBB<HBFNEOMKDHH> GLCDBCCGJCK
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x923D60", Offset = "0x923160", VA = "0x180923D60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public override KENIFKLGBBB<LNDEDBPBNDA> NMFMCAFEBCI
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x225ABC0", Offset = "0x2259FC0", VA = "0x18225ABC0", Slot = "20")]
		get
		{
			return default(KENIFKLGBBB<LNDEDBPBNDA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x225AF70", Offset = "0x225A370", VA = "0x18225AF70")]
	private PANGBJCAKKN(FIJILADMNPM GAMOFPOOCDL, IDOFAFFGDFF NAALEPHLNNP, IEDIDOLAKPA MNINKIODMED, KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII, KENIFKLGBBB<BFLMIPIKKEL> ACDHPDFADHO, KENIFKLGBBB<HBFNEOMKDHH> BLPJFEPEEFC, bool JPFFJIENFKB, string ACDGEPBIBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x225AC20", Offset = "0x225A020", VA = "0x18225AC20")]
	public static PANGBJCAKKN GIIIFAJNKEL(FIJILADMNPM GAMOFPOOCDL, IDOFAFFGDFF NAALEPHLNNP, IEDIDOLAKPA OIDJAKEJHMI, KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII, KENIFKLGBBB<HBFNEOMKDHH> BLPJFEPEEFC, KENIFKLGBBB<BFLMIPIKKEL> ACDHPDFADHO, bool JPFFJIENFKB, bool CBPAPLLJEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x225AC10", Offset = "0x225A010", VA = "0x18225AC10")]
	internal void FHCNCJEGLPG(KENIFKLGBBB<BFLMIPIKKEL> PFKKDHPJFEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public abstract class EIBKONLCFFL : MADALHNANHL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct DFOBOGBMFCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private LOPNBIJFNCK? JAFKOFEHDFA;

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x2244420", Offset = "0x2243820", VA = "0x182244420")]
		public void FEPOBOIDOBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x2244430", Offset = "0x2243830", VA = "0x182244430")]
		public LOPNBIJFNCK NDGJGFNMBOF(EIBKONLCFFL JLBEABDFGJM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	protected readonly FIJILADMNPM LNBMPNGMLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	protected readonly IDOFAFFGDFF BFNDPADCLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private DFOBOGBMFCJ ILNMNDHPBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly OJFNBCBJIIC CEMIFKFGNHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private readonly List<LGBPCCDDBPE> GAOINKOCHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private readonly List<NMNGFCCLDAA> IHANKLPPGEJ;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	[GDCDIKCGJKC("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> LPPBMJHFIFG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x2245080", Offset = "0x2244480", VA = "0x182245080", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public DisplayKind MCAAKBKKBKM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x8AAEF0", Offset = "0x8AA2F0", VA = "0x1808AAEF0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public KENIFKLGBBB<HBIMBCKJJCB> JFFLAICHMGG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x22446F0", Offset = "0x2243AF0", VA = "0x1822446F0", Slot = "6")]
		get
		{
			return default(KENIFKLGBBB<HBIMBCKJJCB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public EKPAMDKNMJG<HBIMBCKJJCB> OGIFLKGMGOG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x2244DD0", Offset = "0x22441D0", VA = "0x182244DD0", Slot = "7")]
		get
		{
			return default(EKPAMDKNMJG<HBIMBCKJJCB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public EFLKGKHCABI LIBIBGMMMAL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x903100", Offset = "0x902500", VA = "0x180903100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public BCHMNKODLAL LILAJBDAADH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x2244E00", Offset = "0x2244200", VA = "0x182244E00", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	protected LOPNBIJFNCK JKFMDKCDKOF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x2244E00", Offset = "0x2244200", VA = "0x182244E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public PortImage EKAPHDKBMKI
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x2244CA0", Offset = "0x22440A0", VA = "0x182244CA0", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public string MKBLEONOOOC
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x89FDB0", Offset = "0x89F1B0", VA = "0x18089FDB0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x89FBE0", Offset = "0x89EFE0", VA = "0x18089FBE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public EKPAMDKNMJG<OJMKIAECBHB> DFHPBCFNIFA
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x2245230", Offset = "0x2244630", VA = "0x182245230", Slot = "9")]
		get
		{
			return default(EKPAMDKNMJG<OJMKIAECBHB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public KENIFKLGBBB<LJJEABOBKPI> JADFBKEIPMM
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x9FC000", Offset = "0x9FB400", VA = "0x1809FC000", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(KENIFKLGBBB<LJJEABOBKPI>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x9FB090", Offset = "0x9FA490", VA = "0x1809FB090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public abstract KENIFKLGBBB<LNDEDBPBNDA> NMFMCAFEBCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x2245A90", Offset = "0x2244E90", VA = "0x182245A90")]
	protected EIBKONLCFFL(FIJILADMNPM GAMOFPOOCDL, IDOFAFFGDFF NAALEPHLNNP, OJFNBCBJIIC MDMPLCCOJAE, KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII, bool JPFFJIENFKB, string ACDGEPBIBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x2245250", Offset = "0x2244650", VA = "0x182245250", Slot = "21")]
	protected virtual void NOCOEJHJFAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x2244720", Offset = "0x2243B20", VA = "0x182244720", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x22448D0", Offset = "0x2243CD0", VA = "0x1822448D0", Slot = "14")]
	public void EFJIOHOJNCE(LGBPCCDDBPE KKMEDFDHHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x2244870", Offset = "0x2243C70", VA = "0x182244870", Slot = "15")]
	public void EAPOKGMACJF(NMNGFCCLDAA KKMEDFDHHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x22453A0", Offset = "0x22447A0", VA = "0x1822453A0", Slot = "16")]
	public void OCHEHBLHFOH(FDMOELGNPCO NAGDPOAMCME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x2245A30", Offset = "0x2244E30", VA = "0x182245A30", Slot = "23")]
	protected virtual void ODJMLCAKLMK(FDMOELGNPCO NAGDPOAMCME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x2244EA0", Offset = "0x22442A0", VA = "0x182244EA0")]
	private void IJABGKAMBJA(bool KGHCPOJBNFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x2244930", Offset = "0x2243D30", VA = "0x182244930")]
	private void EGBGCMABGEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x2244B00", Offset = "0x2243F00", VA = "0x182244B00")]
	private void FGFFEDLBEOE([In] JMAAPAJIHMH DLHDBJHCNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x2245020", Offset = "0x2244420", VA = "0x182245020", Slot = "17")]
	public void LMIIHLECHKL(LGBPCCDDBPE KKMEDFDHHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x22451D0", Offset = "0x22445D0", VA = "0x1822451D0", Slot = "18")]
	public void NHEEFAGDJNN(NMNGFCCLDAA KKMEDFDHHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x89FBE0", Offset = "0x89EFE0", VA = "0x18089FBE0")]
	internal void LNIONPOMBPG(string ACDGEPBIBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x2244AE0", Offset = "0x2243EE0", VA = "0x182244AE0")]
	internal void EGMKANGBKGG(KBJPJHFPBOM PJBENGOCCDF, EFLKGKHCABI EKNPHEPNHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x9FB090", Offset = "0x9FA490", VA = "0x1809FB090")]
	internal void HLNGGOFHLCN(KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public sealed class KEKMLILCBOL : NNGAAJOKFAH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class FGGGFCHCFCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public FIJILADMNPM circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public IDOFAFFGDFF node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public KENIFKLGBBB<LJJEABOBKPI> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public FGGGFCHCFCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x2246AD0", Offset = "0x2245ED0", VA = "0x182246AD0")]
		internal MNPJJMCMLEG FMIHEFKEBAL((int PortDescIndex, int PortIndex, FLEMBEHFNAB InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x2246B60", Offset = "0x2245F60", VA = "0x182246B60")]
		internal PANGBJCAKKN OPKLBEMHPCC(IEDIDOLAKPA i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct APDANCJKFCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public KEKMLILCBOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private NBBBODNMAKD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private TaskAwaiter<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x22416C0", Offset = "0x2240AC0", VA = "0x1822416C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x2241B20", Offset = "0x2240F20", VA = "0x182241B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct PCGJGJPNEGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public KEKMLILCBOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public KENIFKLGBBB<JGHPCKNODPB> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private NBBBODNMAKD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private TaskAwaiter<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x225B2B0", Offset = "0x225A6B0", VA = "0x18225B2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x225B600", Offset = "0x225AA00", VA = "0x18225B600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct BICMCGAHDCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public KEKMLILCBOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public KENIFKLGBBB<HBFNEOMKDHH> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private NBBBODNMAKD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private TaskAwaiter<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x2242A70", Offset = "0x2241E70", VA = "0x182242A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x2242DC0", Offset = "0x22421C0", VA = "0x182242DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct CJGFPPJLAPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public KEKMLILCBOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public KENIFKLGBBB<JGHPCKNODPB> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public KENIFKLGBBB<JGHPCKNODPB> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private NBBBODNMAKD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private TaskAwaiter<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x2243810", Offset = "0x2242C10", VA = "0x182243810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x2243B60", Offset = "0x2242F60", VA = "0x182243B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct LCHHDJPEPKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public KEKMLILCBOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public KENIFKLGBBB<HBFNEOMKDHH> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public KENIFKLGBBB<HBFNEOMKDHH> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private NBBBODNMAKD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private TaskAwaiter<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x2256DB0", Offset = "0x22561B0", VA = "0x182256DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x2257100", Offset = "0x2256500", VA = "0x182257100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct BJLLPNEDGAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public KEKMLILCBOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private NBBBODNMAKD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private TaskAwaiter<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x2242E30", Offset = "0x2242230", VA = "0x182242E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x22432A0", Offset = "0x22426A0", VA = "0x1822432A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct LHJMLJLOGBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public KEKMLILCBOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private NBBBODNMAKD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private TaskAwaiter<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x2258580", Offset = "0x2257980", VA = "0x182258580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x22588D0", Offset = "0x2257CD0", VA = "0x1822588D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct CDBPOIMEMDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public KEKMLILCBOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public KENIFKLGBBB<JGHPCKNODPB> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private NBBBODNMAKD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private TaskAwaiter<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x2243310", Offset = "0x2242710", VA = "0x182243310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x2243660", Offset = "0x2242A60", VA = "0x182243660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct OHACJFCEHEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public KEKMLILCBOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public KENIFKLGBBB<HBFNEOMKDHH> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private NBBBODNMAKD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x225A340", Offset = "0x2259740", VA = "0x18225A340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x225A690", Offset = "0x2259A90", VA = "0x18225A690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct MAFAANMHMKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public KEKMLILCBOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public MECNCANHOPI type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public KENIFKLGBBB<JGHPCKNODPB> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private NBBBODNMAKD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private TaskAwaiter<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x2258940", Offset = "0x2257D40", VA = "0x182258940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x2258CD0", Offset = "0x22580D0", VA = "0x182258CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct PJMLODILHEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public KEKMLILCBOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public MECNCANHOPI type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public KENIFKLGBBB<HBFNEOMKDHH> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private NBBBODNMAKD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private TaskAwaiter<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x225BA10", Offset = "0x225AE10", VA = "0x18225BA10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x225BDA0", Offset = "0x225B1A0", VA = "0x18225BDA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private readonly bool FAAGOCFOFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly FIJILADMNPM LNBMPNGMLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private readonly bool ACFEJJLOPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private BGMIADDEGIF<JDBOICOFJHD, MNPJJMCMLEG> ALOJJOCBHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private BGMIADDEGIF<JDBOICOFJHD, FGKKEPNIBHB> HCKJANGLOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private readonly IDOFAFFGDFF BFNDPADCLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private BGMIADDEGIF<BFLMIPIKKEL, PANGBJCAKKN> JDMKNIEHGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private BGMIADDEGIF<BFLMIPIKKEL, PCICDMNDAOD> MMILBBHNOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private string? EGMNDPEKKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly MJKEJFEKEHL PEGNCMLNCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private KENIFKLGBBB<LJJEABOBKPI> PGDECCKCEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private readonly bool BGBOMALBNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	[CompilerGenerated]
	private Action? JMJODHBPJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	[CompilerGenerated]
	private Action? GMINLGAEBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	[CompilerGenerated]
	private Action<KENIFKLGBBB<JDBOICOFJHD>>? HNMIPLOGIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	[CompilerGenerated]
	private Action<KENIFKLGBBB<BFLMIPIKKEL>>? CAHDHKPEFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	[CompilerGenerated]
	private NNGAAJOKFAH.KGFBDKCEDDE? AMEKLNJGJCF;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool HFAJPJLKNHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x2254010", Offset = "0x2253410", VA = "0x182254010", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool MMIAOHONEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x2251E70", Offset = "0x2251270", VA = "0x182251E70", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool PJNBAFCPONB
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x22531A0", Offset = "0x22525A0", VA = "0x1822531A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public EKPAMDKNMJG<HBIMBCKJJCB> OGIFLKGMGOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x2253840", Offset = "0x2252C40", VA = "0x182253840", Slot = "7")]
		get
		{
			return default(EKPAMDKNMJG<HBIMBCKJJCB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool JAIEGJJKIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x2252A00", Offset = "0x2251E00", VA = "0x182252A00", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public BGMIADDEGIF<JDBOICOFJHD, FGKKEPNIBHB> FCGDBLHHJBO
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x89EF20", Offset = "0x89E320", VA = "0x18089EF20", Slot = "9")]
		get
		{
			return default(BGMIADDEGIF<JDBOICOFJHD, FGKKEPNIBHB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public string MKBLEONOOOC
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x2250F90", Offset = "0x2250390", VA = "0x182250F90", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public EKPAMDKNMJG<OJMKIAECBHB> DFHPBCFNIFA
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x2254EF0", Offset = "0x22542F0", VA = "0x182254EF0", Slot = "11")]
		get
		{
			return default(EKPAMDKNMJG<OJMKIAECBHB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public BGMIADDEGIF<BFLMIPIKKEL, PCICDMNDAOD> CEMHNIACGOH
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x89FDB0", Offset = "0x89F1B0", VA = "0x18089FDB0", Slot = "12")]
		get
		{
			return default(BGMIADDEGIF<BFLMIPIKKEL, PCICDMNDAOD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public KENIFKLGBBB<LJJEABOBKPI> JADFBKEIPMM
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x923D70", Offset = "0x923170", VA = "0x180923D70", Slot = "13")]
		get
		{
			return default(KENIFKLGBBB<LJJEABOBKPI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action IKMMGFLCPPF
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x2250730", Offset = "0x224FB30", VA = "0x182250730", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x2253260", Offset = "0x2252660", VA = "0x182253260", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action LGCPAMCGCPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x22507D0", Offset = "0x224FBD0", VA = "0x1822507D0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x2255B10", Offset = "0x2254F10", VA = "0x182255B10", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<KENIFKLGBBB<JDBOICOFJHD>, KENIFKLGBBB<JDBOICOFJHD>> PFKALHGNCAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x2255BE0", Offset = "0x2254FE0", VA = "0x182255BE0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x2250ED0", Offset = "0x22502D0", VA = "0x182250ED0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<KENIFKLGBBB<JDBOICOFJHD>, KENIFKLGBBB<JDBOICOFJHD>> EHMEJEJOCGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x2254F10", Offset = "0x2254310", VA = "0x182254F10", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x2251DB0", Offset = "0x22511B0", VA = "0x182251DB0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<KENIFKLGBBB<BFLMIPIKKEL>, KENIFKLGBBB<BFLMIPIKKEL>> HPCEOJOMDOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x2250940", Offset = "0x224FD40", VA = "0x182250940", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x2252880", Offset = "0x2251C80", VA = "0x182252880", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<KENIFKLGBBB<BFLMIPIKKEL>, KENIFKLGBBB<BFLMIPIKKEL>> CNCBCJPPCNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x2255CA0", Offset = "0x22550A0", VA = "0x182255CA0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x2250AF0", Offset = "0x224FEF0", VA = "0x182250AF0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<KENIFKLGBBB<JDBOICOFJHD>, FGKKEPNIBHB> KDEMCOKAAKM
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x2255D60", Offset = "0x2255160", VA = "0x182255D60", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x2251CF0", Offset = "0x22510F0", VA = "0x182251CF0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<KENIFKLGBBB<JDBOICOFJHD>> DMPFNPGHLCL
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x22540D0", Offset = "0x22534D0", VA = "0x1822540D0", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x2252250", Offset = "0x2251650", VA = "0x182252250", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<KENIFKLGBBB<JDBOICOFJHD>, FGKKEPNIBHB> GODONOINEIL
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x22543A0", Offset = "0x22537A0", VA = "0x1822543A0", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x2252940", Offset = "0x2251D40", VA = "0x182252940", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<KENIFKLGBBB<BFLMIPIKKEL>, PCICDMNDAOD> OFCIMCMNDEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x2250670", Offset = "0x224FA70", VA = "0x182250670", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x22542E0", Offset = "0x22536E0", VA = "0x1822542E0", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<KENIFKLGBBB<BFLMIPIKKEL>> HLDACEGIBKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x2250CC0", Offset = "0x22500C0", VA = "0x182250CC0", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x2252FC0", Offset = "0x22523C0", VA = "0x182252FC0", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<KENIFKLGBBB<BFLMIPIKKEL>, PCICDMNDAOD> ECJEEFDNNBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x2250880", Offset = "0x224FC80", VA = "0x182250880", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x22505B0", Offset = "0x224F9B0", VA = "0x1822505B0", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x2256380", Offset = "0x2255780", VA = "0x182256380")]
	private KEKMLILCBOL(bool JPFFJIENFKB, FIJILADMNPM GAMOFPOOCDL, bool BHPLDOAOFKK, BGMIADDEGIF<JDBOICOFJHD, MNPJJMCMLEG> DFCNNFBLEHB, BGMIADDEGIF<JDBOICOFJHD, FGKKEPNIBHB> LLEEPNPONOO, IDOFAFFGDFF NAALEPHLNNP, BGMIADDEGIF<BFLMIPIKKEL, PANGBJCAKKN> NFDCAHOLMGO, BGMIADDEGIF<BFLMIPIKKEL, PCICDMNDAOD> CDHJDAHCGPO, string? JPHNHFKALOP, MJKEJFEKEHL EDKDKOCDOEI, KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII, bool CBPAPLLJEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x2252310", Offset = "0x2251710", VA = "0x182252310")]
	public static KEKMLILCBOL GIIIFAJNKEL(bool JPFFJIENFKB, FIJILADMNPM GAMOFPOOCDL, bool BHPLDOAOFKK, IDOFAFFGDFF NAALEPHLNNP, MJKEJFEKEHL EDKDKOCDOEI, KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII, bool CBPAPLLJEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x2254FD0", Offset = "0x22543D0", VA = "0x182254FD0")]
	private void NOCOEJHJFAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x22511F0", Offset = "0x22505F0", VA = "0x1822511F0", Slot = "49")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x2250A00", Offset = "0x224FE00", VA = "0x182250A00", Slot = "38")]
	[AsyncStateMachine(typeof(APDANCJKFCB))]
	public Task<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> BGELHIDFAOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x2250FC0", Offset = "0x22503C0", VA = "0x182250FC0")]
	private (AGKDNPJKFGJ, int)? DNGJKKNCJJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x22504C0", Offset = "0x224F8C0", VA = "0x1822504C0")]
	private void ADAHOJHPKGA(int EFIGJEAJFMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x1898310", Offset = "0x1897710", VA = "0x181898310")]
	private void EOJFBEABGBN(int EFIGJEAJFMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x2254460", Offset = "0x2253860", VA = "0x182254460")]
	private void LPGGDMMNLJD(int AICMAKJLNFG, int KFDKGEJOOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x22537E0", Offset = "0x2252BE0", VA = "0x1822537E0")]
	private void HNKCAIOECGE(int AICMAKJLNFG, int KFDKGEJOOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x2255E40", Offset = "0x2255240", VA = "0x182255E40")]
	private void PHMMNCBIIEB(int EFIGJEAJFMG, KENIFKLGBBB<JDBOICOFJHD> COHNCEGOANI, FLEMBEHFNAB NKKDINBLGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x2255BC0", Offset = "0x2254FC0", VA = "0x182255BC0")]
	private void OMEEPHKHDPN(int KGHCPOJBNFM, KENIFKLGBBB<JDBOICOFJHD> COHNCEGOANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x2255E20", Offset = "0x2255220", VA = "0x182255E20")]
	private void PDFCLEGHKDG(int KGHCPOJBNFM, KENIFKLGBBB<JDBOICOFJHD> COHNCEGOANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x2253AD0", Offset = "0x2252ED0", VA = "0x182253AD0")]
	private void JEBDHMIFAIN(int EFIGJEAJFMG, KENIFKLGBBB<JDBOICOFJHD> COHNCEGOANI, FLEMBEHFNAB NKKDINBLGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x2255780", Offset = "0x2254B80", VA = "0x182255780")]
	private void OCFKLFPCKLP(int EFIGJEAJFMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0xE015B0", Offset = "0xE009B0", VA = "0x180E015B0")]
	private void NJNIHPPBLDH(int EFIGJEAJFMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x2253F20", Offset = "0x2253320", VA = "0x182253F20")]
	private void JHKPEHEOGGO(int EFIGJEAJFMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x1898310", Offset = "0x1897710", VA = "0x181898310")]
	private void AKECKPDPDCP(int EFIGJEAJFMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x2251EB0", Offset = "0x22512B0", VA = "0x182251EB0")]
	private void EMEFGIILEHC(int AICMAKJLNFG, int KFDKGEJOOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x2254DA0", Offset = "0x22541A0", VA = "0x182254DA0")]
	private void NANDPEILPHI(int AICMAKJLNFG, int KFDKGEJOOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x2252A80", Offset = "0x2251E80", VA = "0x182252A80")]
	private void HCADNFHFEHE(int EFIGJEAJFMG, KENIFKLGBBB<BFLMIPIKKEL> COHNCEGOANI, IEDIDOLAKPA NKKDINBLGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x2254800", Offset = "0x2253C00", VA = "0x182254800")]
	private void MCHGMODDEEO(int KGHCPOJBNFM, KENIFKLGBBB<BFLMIPIKKEL> COHNCEGOANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x2254190", Offset = "0x2253590", VA = "0x182254190")]
	private void KEFIOBMFMAH(int KGHCPOJBNFM, KENIFKLGBBB<BFLMIPIKKEL> COHNCEGOANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x2254930", Offset = "0x2253D30", VA = "0x182254930")]
	private void MPIGKKOGIDK(int EFIGJEAJFMG, KENIFKLGBBB<BFLMIPIKKEL> COHNCEGOANI, IEDIDOLAKPA NKKDINBLGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x2250D80", Offset = "0x2250180", VA = "0x182250D80")]
	private void DGLEGMDLIJO(int EFIGJEAJFMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0xE015B0", Offset = "0xE009B0", VA = "0x180E015B0")]
	private void KPHHKGKGEPB(int EFIGJEAJFMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x2250BB0", Offset = "0x224FFB0", VA = "0x182250BB0", Slot = "39")]
	[AsyncStateMachine(typeof(PCGJGJPNEGH))]
	public Task<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> BJCOMMMBDGK(KENIFKLGBBB<JGHPCKNODPB> NEFPINAGFII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x2254820", Offset = "0x2253C20", VA = "0x182254820", Slot = "40")]
	[AsyncStateMachine(typeof(BICMCGAHDCA))]
	public Task<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> MDMEKHNKJFL(KENIFKLGBBB<HBFNEOMKDHH> BLPJFEPEEFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x2253080", Offset = "0x2252480", VA = "0x182253080", Slot = "41")]
	[AsyncStateMachine(typeof(CJGFPPJLAPC))]
	public Task<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> HDEGAKKKECL(KENIFKLGBBB<JGHPCKNODPB> NEFPINAGFII, KENIFKLGBBB<JGHPCKNODPB> NFLPFLADMND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x22559F0", Offset = "0x2254DF0", VA = "0x1822559F0", Slot = "42")]
	[AsyncStateMachine(typeof(LCHHDJPEPKL))]
	public Task<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> OFFNGEJPJIK(KENIFKLGBBB<HBFNEOMKDHH> BLPJFEPEEFC, KENIFKLGBBB<HBFNEOMKDHH> NFLPFLADMND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x2254E00", Offset = "0x2254200", VA = "0x182254E00", Slot = "43")]
	[AsyncStateMachine(typeof(BJLLPNEDGAK))]
	public Task<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> NDPKFEKCFBH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x22558D0", Offset = "0x2254CD0", VA = "0x1822558D0", Slot = "44")]
	[AsyncStateMachine(typeof(LHJMLJLOGBB))]
	public Task<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> OEBIFKEHEMP(string EACAMCBOFJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x2253870", Offset = "0x2252C70", VA = "0x182253870", Slot = "45")]
	[AsyncStateMachine(typeof(CDBPOIMEMDO))]
	public Task<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> HPOJMONALAK(KENIFKLGBBB<JGHPCKNODPB> NEFPINAGFII, string ACDGEPBIBHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x22539A0", Offset = "0x2252DA0", VA = "0x1822539A0", Slot = "46")]
	[AsyncStateMachine(typeof(OHACJFCEHEN))]
	public Task<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> IDAABFEABAM(KENIFKLGBBB<HBFNEOMKDHH> BLPJFEPEEFC, string ACDGEPBIBHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x2253300", Offset = "0x2252700", VA = "0x182253300", Slot = "47")]
	[AsyncStateMachine(typeof(MAFAANMHMKE))]
	public Task<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> HKOFDEIEAHL(KENIFKLGBBB<JGHPCKNODPB> NEFPINAGFII, MECNCANHOPI EKNPHEPNHJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x22541B0", Offset = "0x22535B0", VA = "0x1822541B0", Slot = "48")]
	[AsyncStateMachine(typeof(PJMLODILHEA))]
	public Task<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> KGEELPBMDLA(KENIFKLGBBB<HBFNEOMKDHH> BLPJFEPEEFC, MECNCANHOPI EKNPHEPNHJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x2253430", Offset = "0x2252830", VA = "0x182253430")]
	internal void HLNGGOFHLCN(KENIFKLGBBB<LJJEABOBKPI> PFKKDHPJFEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public sealed class IOECLFJLDNB : HIAEONOJIEE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public interface MDBAKDGIDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		KBJPJHFPBOM EOJMDKFMHJL
		{
			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<IKFHAIHBMIK> KLBBMBNCEIM(CancellationToken GBOOEEMCFEA);

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<HDFAHODOCKJ> MIGHGEEEDHG(CancellationToken GBOOEEMCFEA);

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<PJEMDDJICJI> IGLAIOIMEHE(CancellationToken GBOOEEMCFEA);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct FHOPAOLLMFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<IOECLFJLDNB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public FIJILADMNPM circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public IKFHAIHBMIK roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public HDFAHODOCKJ superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private MDBAKDGIDKJ <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private HDFAHODOCKJ <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<IKFHAIHBMIK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private TaskAwaiter<HDFAHODOCKJ> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter<PJEMDDJICJI> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private TaskAwaiter<HHIMEGIMJAG> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x2246BF0", Offset = "0x2245FF0", VA = "0x182246BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x2247600", Offset = "0x2246A00", VA = "0x182247600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private readonly HHIMEGIMJAG LHBAGMIMLPH;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public HHIMEGIMJAG OEDKBIJELNK
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x89A2A0", Offset = "0x8996A0", VA = "0x18089A2A0")]
	private IOECLFJLDNB(HHIMEGIMJAG CECHAKOKJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x224F990", Offset = "0x224ED90", VA = "0x18224F990")]
	[AsyncStateMachine(typeof(FHOPAOLLMFK))]
	public static Task<IOECLFJLDNB> NHIEIKADKCP(FIJILADMNPM GAMOFPOOCDL, IKFHAIHBMIK? FKLCHFCGCOM, HDFAHODOCKJ? BFJEMNEACKG, CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x224F970", Offset = "0x224ED70", VA = "0x18224F970", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public readonly struct FCGAHFGLIPI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct GHHPFEPOJON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<object, JLOPLHOLGBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public FCGAHFGLIPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public HFDKJCIJLFF action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private TaskAwaiter<BMFECDODLAB<object, JLOPLHOLGBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x224E530", Offset = "0x224D930", VA = "0x18224E530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x224E7C0", Offset = "0x224DBC0", VA = "0x18224E7C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct EOFPHAKLNAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<bool, JLOPLHOLGBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public KOLFGKMAFBF rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public IKFHAIHBMIK circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public HDFAHODOCKJ superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public FCGAHFGLIPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private HFDKJCIJLFF[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private TaskAwaiter<BMFECDODLAB<object, JLOPLHOLGBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x2245F50", Offset = "0x2245350", VA = "0x182245F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x2246330", Offset = "0x2245730", VA = "0x182246330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct JFCGCNPEFOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public FCGAHFGLIPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private TaskAwaiter<BMFECDODLAB<object, JLOPLHOLGBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x224FBC0", Offset = "0x224EFC0", VA = "0x18224FBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x224FE00", Offset = "0x224F200", VA = "0x18224FE00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private readonly DDMPAGDCGFP AHCBFPIOBKG;

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x948260", Offset = "0x947660", VA = "0x180948260")]
	public FCGAHFGLIPI(DDMPAGDCGFP CLINKFHNFLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x2246500", Offset = "0x2245900", VA = "0x182246500")]
	[AsyncStateMachine(typeof(GHHPFEPOJON))]
	private Task<BMFECDODLAB<object, JLOPLHOLGBP>> DLKAHCIPCOB(HFDKJCIJLFF LLIKOHELCCA, bool PFAJPHGPIDK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x22463A0", Offset = "0x22457A0", VA = "0x1822463A0")]
	[AsyncStateMachine(typeof(EOFPHAKLNAM))]
	public Task<BMFECDODLAB<bool, JLOPLHOLGBP?>>? DLJAJEFEBCA(int BOJMNJIOPBK, KOLFGKMAFBF? MNLHLPJABEA, IKFHAIHBMIK? ENPFCIOMLNF, HDFAHODOCKJ? BFJEMNEACKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x2246630", Offset = "0x2245A30", VA = "0x182246630")]
	[AsyncStateMachine(typeof(JFCGCNPEFOC))]
	public Task<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> GGKFCAFBJMN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public sealed class EHAOIFEMKPE : JEMKLAKFOEP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private readonly NPKDBPHHBFN KPJEGKMFHOF;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public NPKDBPHHBFN DIJJPPFNOLO
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x89A2A0", Offset = "0x8996A0", VA = "0x18089A2A0")]
	private EHAOIFEMKPE(NPKDBPHHBFN HOECNKIAJEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x22444F0", Offset = "0x22438F0", VA = "0x1822444F0")]
	public static EHAOIFEMKPE LIJBJHOEHGL(FIJILADMNPM GAMOFPOOCDL, KOLFGKMAFBF NODKFDFMFED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x22444D0", Offset = "0x22438D0", VA = "0x1822444D0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public interface GLKDJEHDBOH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	HHIMEGIMJAG OEDKBIJELNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	LCOMFHFIOEN GNEOBEAGBNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	BOMGNNGFCHI KMJKNEMPALE
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	FJHLICLHMDH OPONNNBBLJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public interface HNOIKODKKAI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	GLKDJEHDBOH? KLMBNJNLKBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	bool PEHHLBMDPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	bool CBFPGIPNPOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<GLKDJEHDBOH?>? NIGLOBOLLDK();

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task EFNLHJGMJIO(FIJILADMNPM GAMOFPOOCDL, KOLFGKMAFBF NODKFDFMFED, IKFHAIHBMIK? CEACDBENBJO, HDFAHODOCKJ? AGEDEGMFBLF);
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[GFCMOGLFEEB("IStaticCV2Instance")]
public interface HIAEONOJIEE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	HHIMEGIMJAG OEDKBIJELNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[GFCMOGLFEEB("IStaticEVInstance")]
public interface JEMKLAKFOEP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	NPKDBPHHBFN DIJJPPFNOLO
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class GMINJCEADEP
{
	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x224EAB0", Offset = "0x224DEB0", VA = "0x18224EAB0")]
	public static OBGJCPOEFJF<LHMPGDLOMEB, HFDKJCIJLFF, FIJILADMNPM, IDMDJNIGDML.JHLOFCFNCNK<LHMPGDLOMEB, HFDKJCIJLFF, FIJILADMNPM>> DKHCAKNLCPD([In] this OBGJCPOEFJF<LHMPGDLOMEB, HFDKJCIJLFF, FIJILADMNPM, IDMDJNIGDML.JHLOFCFNCNK<LHMPGDLOMEB, HFDKJCIJLFF, FIJILADMNPM>> CKHKCDGJOAC)
	{
		return default(OBGJCPOEFJF<LHMPGDLOMEB, HFDKJCIJLFF, FIJILADMNPM, IDMDJNIGDML.JHLOFCFNCNK<LHMPGDLOMEB, HFDKJCIJLFF, FIJILADMNPM>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public sealed class GGABNMHCLNE : HCBEEOFAFIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private readonly FIJILADMNPM LNBMPNGMLBG;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool CBFPGIPNPOE
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x224E510", Offset = "0x224D910", VA = "0x18224E510", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x89A2A0", Offset = "0x8996A0", VA = "0x18089A2A0")]
	internal GGABNMHCLNE(FIJILADMNPM GAMOFPOOCDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal sealed class LAKDBDAKKMG : DPMPADEOKFJ
{
	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x2256D10", Offset = "0x2256110", VA = "0x182256D10", Slot = "4")]
	public KAIPJMIDHAA? BKBDAJCBKOA(string? DDMEPKPHGJJ, string? IKBFNHLKCMG, string? IBPJJOEOLAB, CKAPDHENPLM.IIIHCEPHAHJ.KKMNNLDMPMN CPNGGHJIFME, bool BJJDAOJEFEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public LAKDBDAKKMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public sealed class LGMNHNOBIKO : LMBNJEDLEED
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private struct JMMMNJKOOOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public AsyncTaskMethodBuilder<CHLHIIGLCHO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public LGMNHNOBIKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private TaskAwaiter<GLKDJEHDBOH?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x22501B0", Offset = "0x224F5B0", VA = "0x1822501B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x2250450", Offset = "0x224F850", VA = "0x182250450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private readonly FIJILADMNPM LNBMPNGMLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private IReadOnlyList<EKPAMDKNMJG<HAGNHDFDPID>>? IAEOLDCABHP;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public CHLHIIGLCHO? GHDNHBBFDEB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x2258500", Offset = "0x2257900", VA = "0x182258500", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public FJHLICLHMDH? MFGFKGIFKPL
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x2257E50", Offset = "0x2257250", VA = "0x182257E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool POPPKDJKBDP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x2257C20", Offset = "0x2257020", VA = "0x182257C20", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool CCIPEOBAHEG
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x2257BC0", Offset = "0x2256FC0", VA = "0x182257BC0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x89A2A0", Offset = "0x8996A0", VA = "0x18089A2A0")]
	internal LGMNHNOBIKO(FIJILADMNPM GAMOFPOOCDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x22580A0", Offset = "0x22574A0", VA = "0x1822580A0", Slot = "7")]
	[AsyncStateMachine(typeof(JMMMNJKOOOO))]
	public Task<CHLHIIGLCHO> IPGJJBGPDGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x2258190", Offset = "0x2257590", VA = "0x182258190", Slot = "9")]
	public IReadOnlyDictionary<EKPAMDKNMJG<HBIMBCKJJCB>, Guid> LJIGJDPBCGN(IEnumerable<GCKACGBMEHC> PFNDCAOAFME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x2257C80", Offset = "0x2257080", VA = "0x182257C80")]
	public BMFECDODLAB<AHLCHOPFNAL, JPIHCAEEFCD> EAPEFFFNOOO([In] AHLCHOPFNAL BIIMFGBLPPI, IEnumerable<GCKACGBMEHC> IJJCPCHMMFJ, int JBDHGNDDEAP)
	{
		return default(BMFECDODLAB<AHLCHOPFNAL, JPIHCAEEFCD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x2257ED0", Offset = "0x22572D0", VA = "0x182257ED0", Slot = "8")]
	private BMFECDODLAB<AHLCHOPFNAL, JPIHCAEEFCD> GDBJLGCKFHE([In] AHLCHOPFNAL BIIMFGBLPPI, IEnumerable<GCKACGBMEHC> IJJCPCHMMFJ, int JBDHGNDDEAP)
	{
		return default(BMFECDODLAB<AHLCHOPFNAL, JPIHCAEEFCD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class FJHLICLHMDH : CHLHIIGLCHO
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	internal static class GECDEEJCBHL
	{
		[Cpp2IlInjected.Token(Token = "0x20000CC")]
		[CompilerGenerated]
		private sealed class OMJLCCDDCNH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000294")]
			public HHIMEGIMJAG state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000295")]
			public MHLHJMNGPNM spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public OMJLCCDDCNH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0x225AA10", Offset = "0x2259E10", VA = "0x18225AA10")]
			internal bool EGKMCMMGODN(JLFDLOCJPFF n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CD")]
		[CompilerGenerated]
		private sealed class CPOCBLLOFCD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000296")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public CPOCBLLOFCD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FC")]
			[Cpp2IlInjected.Address(RVA = "0x2244040", Offset = "0x2243440", VA = "0x182244040")]
			internal void MALAOALOEFM(JLFDLOCJPFF n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x224DFB0", Offset = "0x224D3B0", VA = "0x18224DFB0")]
		public static BMFECDODLAB<CHLHIIGLCHO.BOMNODPPEMJ, BOMFIFNIFBO> PMHBOLLLGAG(FJHLICLHMDH EAFEIEDNLNL, [In] CHLHIIGLCHO.JIAEBLFIBNG KCHFAPGLICB)
		{
			return default(BMFECDODLAB<CHLHIIGLCHO.BOMNODPPEMJ, BOMFIFNIFBO>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x224C850", Offset = "0x224BC50", VA = "0x18224C850")]
		internal static BMFECDODLAB<(AEBCMIIICPL, LIDMJAIKFDK), BOMFIFNIFBO> AIBIDCCGFDD(FJHLICLHMDH EAFEIEDNLNL, LIDMJAIKFDK IIIAKIFDIBA, bool PIHPFPJEOGP, [In] EKPAMDKNMJG<HBIMBCKJJCB> KCLHIMGLGDA, [In] int? MEFMJCNICEE, [In] GHEHLOPOPNH? LEADCLNLKNO, [In] GHEHLOPOPNH? OFFOPCGPEKK)
		{
			return default(BMFECDODLAB<(AEBCMIIICPL, LIDMJAIKFDK), BOMFIFNIFBO>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x224DA80", Offset = "0x224CE80", VA = "0x18224DA80")]
		private static void EEHDLJPKKBI(bool PIHPFPJEOGP, GCKACGBMEHC NDDDMIOEDEN, AEBCMIIICPL NDLDPHAGFDI, [In] EKPAMDKNMJG<HBIMBCKJJCB> KCLHIMGLGDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x224D670", Offset = "0x224CA70", VA = "0x18224D670")]
		public static void AJCFJFGMNDO(CPAOBCLAMGG PLGDGFMJPOF, [In] CHLHIIGLCHO.JPKIFNMJKNE ACNPBFDAIKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x224DEC0", Offset = "0x224D2C0", VA = "0x18224DEC0")]
		[CompilerGenerated]
		internal static bool NHAJKMHKMCC(HHIMEGIMJAG JLABMCHFAHL, MHLHJMNGPNM EFKMBOKNOFF, JLFDLOCJPFF AADGIBJBJPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x224C820", Offset = "0x224BC20", VA = "0x18224C820")]
		[CompilerGenerated]
		internal static bool AHODDKHPMCC(JLFDLOCJPFF MKPJNGJDPAL)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private struct BAAKMKLIONK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public FJHLICLHMDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public KENIFKLGBBB<HBIMBCKJJCB> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public KENIFKLGBBB<KOCMDBHIIKI> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public KENIFKLGBBB<CKIEBMEMCDM> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private TaskAwaiter<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x2241B90", Offset = "0x2240F90", VA = "0x182241B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x22421E0", Offset = "0x22415E0", VA = "0x1822421E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private struct FDGPKFKCEIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public FJHLICLHMDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public EKPAMDKNMJG<OJMKIAECBHB> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public EKPAMDKNMJG<HBIMBCKJJCB> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public KENIFKLGBBB<LJJEABOBKPI> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public KENIFKLGBBB<JDBOICOFJHD> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private TaskAwaiter<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x2246720", Offset = "0x2245B20", VA = "0x182246720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x2246A60", Offset = "0x2245E60", VA = "0x182246A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[CompilerGenerated]
	private struct JADNMGALPHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public FJHLICLHMDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public EKPAMDKNMJG<OJMKIAECBHB> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public EKPAMDKNMJG<HBIMBCKJJCB> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public KENIFKLGBBB<LJJEABOBKPI> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public KENIFKLGBBB<BFLMIPIKKEL> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private TaskAwaiter<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x225E8D0", Offset = "0x225DCD0", VA = "0x18225E8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x225EC10", Offset = "0x225E010", VA = "0x18225EC10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private readonly FIJILADMNPM LNBMPNGMLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private readonly HIAEONOJIEE BGHBCILNABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private readonly JEMKLAKFOEP JEMCKCKHNKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private readonly PPIBFCENDBJ PCDPJKNPOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private readonly LGMNHNOBIKO NJLJIANFLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private Dictionary<EKPAMDKNMJG<OJMKIAECBHB>, OOJIJCAGPLP> BAMONPHAGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	[CompilerGenerated]
	private Action<EKPAMDKNMJG<OJMKIAECBHB>>? FKJPCNJIOLF;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public EKPAMDKNMJG<HBIMBCKJJCB> JLHMNDIHPNC
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x2249700", Offset = "0x2248B00", VA = "0x182249700", Slot = "4")]
		get
		{
			return default(EKPAMDKNMJG<HBIMBCKJJCB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public PPIBFCENDBJ KHHACCMJKJD
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x222FF10", Offset = "0x222F310", VA = "0x18222FF10", Slot = "5")]
		get
		{
			return default(PPIBFCENDBJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x224C240", Offset = "0x224B640", VA = "0x18224C240")]
	public FJHLICLHMDH(FIJILADMNPM GAMOFPOOCDL, HIAEONOJIEE HCGGNCNNIJI, JEMKLAKFOEP KBHMDNCACHE, LGMNHNOBIKO MGBGOEBGBKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x2247730", Offset = "0x2246B30", VA = "0x182247730", Slot = "48")]
	public KENIFKLGBBB<KPKMMJECGGG> ACFBJGFAHBJ(KENIFKLGBBB<HBIMBCKJJCB> IDNKPJNNEPC, KENIFKLGBBB<CKIEBMEMCDM> NHEAFFJJAEB)
	{
		return default(KENIFKLGBBB<KPKMMJECGGG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x2249080", Offset = "0x2248480", VA = "0x182249080", Slot = "49")]
	public KENIFKLGBBB<CNLOLLJJMNN> FCNDONODFBL(KENIFKLGBBB<HBIMBCKJJCB> IDNKPJNNEPC, KENIFKLGBBB<KOCMDBHIIKI> ACDHPDFADHO)
	{
		return default(KENIFKLGBBB<CNLOLLJJMNN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x224A9C0", Offset = "0x2249DC0", VA = "0x18224A9C0", Slot = "6")]
	public (bool, bool) KPAKIILCMNF(KENIFKLGBBB<HBIMBCKJJCB> IDNKPJNNEPC, KENIFKLGBBB<KOCMDBHIIKI> DBMNKEIBCEI, KENIFKLGBBB<CKIEBMEMCDM> CNAPGBNNOHG)
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x224A070", Offset = "0x2249470", VA = "0x18224A070")]
	public bool HKFPBKFNNID(KENIFKLGBBB<HBIMBCKJJCB> IDNKPJNNEPC, [In] APCNMLEPOLJ JAGECECLCKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x2247E90", Offset = "0x2247290", VA = "0x182247E90", Slot = "8")]
	public bool BNEMLIPJINN(FGKKEPNIBHB MMJBACDMLDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x2249E60", Offset = "0x2249260", VA = "0x182249E60", Slot = "9")]
	public bool HBPDGDNPHJM(PCICDMNDAOD FBNDBIELINP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x2249DA0", Offset = "0x22491A0", VA = "0x182249DA0", Slot = "10")]
	public ANMFOBIHIEA? GOMOMDCLEKG(KENIFKLGBBB<HBIMBCKJJCB> IDNKPJNNEPC, KENIFKLGBBB<CKIEBMEMCDM> NHEAFFJJAEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x224A400", Offset = "0x2249800", VA = "0x18224A400", Slot = "11")]
	public JJPKBDHPOPE? IFJNPJINADF(KENIFKLGBBB<HBIMBCKJJCB> IDNKPJNNEPC, KENIFKLGBBB<KOCMDBHIIKI> ACDHPDFADHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x2249820", Offset = "0x2248C20", VA = "0x182249820", Slot = "12")]
	public IEnumerable<KENIFKLGBBB<DHOPMDLFDBL>> GJFKEPMHHBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x224AFA0", Offset = "0x224A3A0", VA = "0x18224AFA0", Slot = "13")]
	public string LMDOBHKOODP(KENIFKLGBBB<DHOPMDLFDBL> MBJGNIPEMDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x2248640", Offset = "0x2247A40", VA = "0x182248640", Slot = "14")]
	public string DDCNOCPFAPI(KENIFKLGBBB<DHOPMDLFDBL> MBJGNIPEMDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x224B290", Offset = "0x224A690", VA = "0x18224B290")]
	public OOJIJCAGPLP? MAGPDIFLGAC([In] EKPAMDKNMJG<OJMKIAECBHB> LFFCFCIDMIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x2248D70", Offset = "0x2248170", VA = "0x182248D70")]
	public KENIFKLGBBB<OJMKIAECBHB> LPNDAEPFHPM(KENIFKLGBBB<HBIMBCKJJCB> IDNKPJNNEPC, [In] EKPAMDKNMJG<OJMKIAECBHB> EJNLLNHKFDG)
	{
		return default(KENIFKLGBBB<OJMKIAECBHB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x2249000", Offset = "0x2248400", VA = "0x182249000", Slot = "26")]
	public KENIFKLGBBB<OJMKIAECBHB> FBOBEPEKPOC(KENIFKLGBBB<HBIMBCKJJCB> IDNKPJNNEPC, KENIFKLGBBB<CKIEBMEMCDM> NHEAFFJJAEB)
	{
		return default(KENIFKLGBBB<OJMKIAECBHB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x22491E0", Offset = "0x22485E0", VA = "0x1822491E0", Slot = "27")]
	public KENIFKLGBBB<OJMKIAECBHB> FMHBACIDABP(KENIFKLGBBB<HBIMBCKJJCB> IDNKPJNNEPC, KENIFKLGBBB<KOCMDBHIIKI> ACDHPDFADHO)
	{
		return default(KENIFKLGBBB<OJMKIAECBHB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x2247AC0", Offset = "0x2246EC0", VA = "0x182247AC0")]
	private void ANJBKKCPMFA(EKPAMDKNMJG<OJMKIAECBHB> LFFCFCIDMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x2249100", Offset = "0x2248500", VA = "0x182249100")]
	public IEnumerable<OOJIJCAGPLP> FDPMMFNIEKL([In] EKPAMDKNMJG<HBIMBCKJJCB> IDNKPJNNEPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x2247960", Offset = "0x2246D60", VA = "0x182247960", Slot = "25")]
	public KENIFKLGBBB<CKIEBMEMCDM> AJCDKEDAPPA(KENIFKLGBBB<HBIMBCKJJCB> IDNKPJNNEPC, KENIFKLGBBB<OJMKIAECBHB> LFFCFCIDMIM, KENIFKLGBBB<KPKMMJECGGG> CPBOLBGOHDB)
	{
		return default(KENIFKLGBBB<CKIEBMEMCDM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x224C050", Offset = "0x224B450", VA = "0x18224C050", Slot = "28")]
	public KENIFKLGBBB<KOCMDBHIIKI> PKCDBDKBAKK(KENIFKLGBBB<HBIMBCKJJCB> IDNKPJNNEPC, KENIFKLGBBB<OJMKIAECBHB> LFFCFCIDMIM, KENIFKLGBBB<CNLOLLJJMNN> KDMDBMCNMLN)
	{
		return default(KENIFKLGBBB<KOCMDBHIIKI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x224B490", Offset = "0x224A890", VA = "0x18224B490")]
	private OOJIJCAGPLP? MKIGANGLLCB([In] EKPAMDKNMJG<OJMKIAECBHB> LFFCFCIDMIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x22479F0", Offset = "0x2246DF0", VA = "0x1822479F0")]
	private OOJIJCAGPLP AMCIOJDIAMG([In] EKPAMDKNMJG<OJMKIAECBHB> LFFCFCIDMIM, IDOFAFFGDFF NAALEPHLNNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x2248F70", Offset = "0x2248370", VA = "0x182248F70")]
	public IDOFAFFGDFF? EPNBOGIJPGJ([In] EKPAMDKNMJG<OJMKIAECBHB> LFFCFCIDMIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x224A8A0", Offset = "0x2249CA0", VA = "0x18224A8A0")]
	public LNJFLFAMJMD? JONFBEOKAPP([In] EKPAMDKNMJG<HBIMBCKJJCB> IDNKPJNNEPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x2247670", Offset = "0x2246A70", VA = "0x182247670", Slot = "20")]
	public IEnumerable<EEDCADADMDF> AALKCEBDHMJ(KENIFKLGBBB<HBIMBCKJJCB> IDNKPJNNEPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x2248DF0", Offset = "0x22481F0", VA = "0x182248DF0", Slot = "21")]
	public bool EDKFOJEDPHO(KENIFKLGBBB<DHOPMDLFDBL> MBJGNIPEMDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x224B010", Offset = "0x224A410", VA = "0x18224B010", Slot = "22")]
	public IEnumerable<APCNMLEPOLJ> LMNLPIEIIBE(KENIFKLGBBB<HBIMBCKJJCB> IDNKPJNNEPC, KENIFKLGBBB<KOCMDBHIIKI> DBMNKEIBCEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x224A5C0", Offset = "0x22499C0", VA = "0x18224A5C0", Slot = "23")]
	public IEnumerable<APCNMLEPOLJ> IPHPDOPAJBI(KENIFKLGBBB<HBIMBCKJJCB> IDNKPJNNEPC, KENIFKLGBBB<CKIEBMEMCDM> CNAPGBNNOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x224B390", Offset = "0x224A790", VA = "0x18224B390")]
	public KENIFKLGBBB<HBIMBCKJJCB> MEHDGIGAEFA([In] EKPAMDKNMJG<HBIMBCKJJCB> IDNKPJNNEPC)
	{
		return default(KENIFKLGBBB<HBIMBCKJJCB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x22483F0", Offset = "0x22477F0", VA = "0x1822483F0")]
	public KENIFKLGBBB<HBIMBCKJJCB>? CEHLKDPCIJF([In] EKPAMDKNMJG<HBIMBCKJJCB> IDNKPJNNEPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x2249760", Offset = "0x2248B60", VA = "0x182249760")]
	private MHLHJMNGPNM? GHIEGFLOEEB([In] EKPAMDKNMJG<HBIMBCKJJCB> IDNKPJNNEPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x224A8A0", Offset = "0x2249CA0", VA = "0x18224A8A0")]
	private LNJFLFAMJMD? OPPDNGNDEMO([In] EKPAMDKNMJG<HBIMBCKJJCB> IDNKPJNNEPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x2248E80", Offset = "0x2248280", VA = "0x182248E80", Slot = "32")]
	public EKPAMDKNMJG<HBIMBCKJJCB> EIODPEELHOD(KENIFKLGBBB<HBIMBCKJJCB> IDNKPJNNEPC)
	{
		return default(EKPAMDKNMJG<HBIMBCKJJCB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x2247CC0", Offset = "0x22470C0", VA = "0x182247CC0", Slot = "29")]
	public IEnumerable<MECNCANHOPI> BBELHGPFDEK(JLHIAACBLBA OAOGOFHFGDH, bool HCIMNDJBBIK, bool GMBBDDMLPIB, bool ICAMGGBAIED, bool BBBMCDNAFGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x224BBE0", Offset = "0x224AFE0", VA = "0x18224BBE0", Slot = "30")]
	public MECNCANHOPI PEOFFDNIFKE(JLHIAACBLBA OAOGOFHFGDH, MADALHNANHL NHJFDEJIHFP, bool HCIMNDJBBIK, bool GMBBDDMLPIB, bool ICAMGGBAIED, bool BBBMCDNAFGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x2247B50", Offset = "0x2246F50", VA = "0x182247B50")]
	public EEDCADADMDF KCJFGBPPKFK(KENIFKLGBBB<HBIMBCKJJCB> IDNKPJNNEPC, [In] APCNMLEPOLJ JAGECECLCKI)
	{
		return default(EEDCADADMDF);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x224B8C0", Offset = "0x224ACC0", VA = "0x18224B8C0", Slot = "33")]
	public APCNMLEPOLJ NPFHPKPKFBA(KENIFKLGBBB<HBIMBCKJJCB> IDNKPJNNEPC, KENIFKLGBBB<KOCMDBHIIKI> DBMNKEIBCEI, KENIFKLGBBB<CKIEBMEMCDM> CNAPGBNNOHG)
	{
		return default(APCNMLEPOLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x2247E20", Offset = "0x2247220", VA = "0x182247E20", Slot = "34")]
	public bool BFOIOBCIAAC(KENIFKLGBBB<HBIMBCKJJCB> IDNKPJNNEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x22478E0", Offset = "0x2246CE0", VA = "0x1822478E0", Slot = "35")]
	public bool AIADGJBIJDB(KENIFKLGBBB<HBIMBCKJJCB> IDNKPJNNEPC, KENIFKLGBBB<CKIEBMEMCDM> NHEAFFJJAEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x2248EF0", Offset = "0x22482F0", VA = "0x182248EF0", Slot = "36")]
	public bool EJNILOOEACM(KENIFKLGBBB<HBIMBCKJJCB> IDNKPJNNEPC, KENIFKLGBBB<KOCMDBHIIKI> ACDHPDFADHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x2249EE0", Offset = "0x22492E0", VA = "0x182249EE0")]
	public BMFECDODLAB<CHLHIIGLCHO.BOMNODPPEMJ, BOMFIFNIFBO> HFBBJHHMGBP([In] CHLHIIGLCHO.JIAEBLFIBNG KCHFAPGLICB)
	{
		return default(BMFECDODLAB<CHLHIIGLCHO.BOMNODPPEMJ, BOMFIFNIFBO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x22477B0", Offset = "0x2246BB0", VA = "0x1822477B0", Slot = "38")]
	[AsyncStateMachine(typeof(BAAKMKLIONK))]
	public Task<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> ADBEDMMJJLL(KENIFKLGBBB<HBIMBCKJJCB> IDNKPJNNEPC, KENIFKLGBBB<KOCMDBHIIKI> DBMNKEIBCEI, KENIFKLGBBB<CKIEBMEMCDM> CNAPGBNNOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x2248030", Offset = "0x2247430", VA = "0x182248030", Slot = "39")]
	public BMFECDODLAB<OFFEGAELCIN, JPIHCAEEFCD> BONLKCKDHNP(EKPAMDKNMJG<HBIMBCKJJCB> IDNKPJNNEPC, OFFEGAELCIN COCMGCBKHDE, MJMAIMONCFG DPHIOGCBFKO)
	{
		return default(BMFECDODLAB<OFFEGAELCIN, JPIHCAEEFCD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x2249F10", Offset = "0x2249310", VA = "0x182249F10", Slot = "40")]
	[AsyncStateMachine(typeof(FDGPKFKCEIJ))]
	public Task<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> HHOCCOIGECF(EKPAMDKNMJG<HBIMBCKJJCB> IDNKPJNNEPC, EKPAMDKNMJG<OJMKIAECBHB> PIOELGCHECI, KENIFKLGBBB<LJJEABOBKPI> CIPHICDHGLB, KENIFKLGBBB<JDBOICOFJHD> NHEAFFJJAEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x224C0E0", Offset = "0x224B4E0", VA = "0x18224C0E0", Slot = "41")]
	[AsyncStateMachine(typeof(JADNMGALPHF))]
	public Task<BMFECDODLAB<FHMPKELNMGN, JLOPLHOLGBP>> POEINMBOCPN(EKPAMDKNMJG<HBIMBCKJJCB> IDNKPJNNEPC, EKPAMDKNMJG<OJMKIAECBHB> BCNBAHPLNHO, KENIFKLGBBB<LJJEABOBKPI> HDFBAICLINP, KENIFKLGBBB<BFLMIPIKKEL> ACDHPDFADHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x2248470", Offset = "0x2247870", VA = "0x182248470", Slot = "42")]
	public HFKOJAMNIJB CHDOBIBJCIN(IEnumerable<GCKACGBMEHC> IJJCPCHMMFJ)
	{
		return default(HFKOJAMNIJB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x2247F10", Offset = "0x2247310", VA = "0x182247F10", Slot = "43")]
	public HFKOJAMNIJB BOHDOKNBGGH()
	{
		return default(HFKOJAMNIJB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x22498D0", Offset = "0x2248CD0", VA = "0x1822498D0")]
	private HCMIGMJPDCG GLNEAGNNBIE(ELMCKEEIEPE HAKDIDNIFLG, KENIFKLGBBB<HBIMBCKJJCB> MNEFPMEJNLM, IEnumerable<EKPAMDKNMJG<HBIMBCKJJCB>> JGKKAHJNPEA, IEnumerable<EKPAMDKNMJG<OJMKIAECBHB>> JILCHGLIFFB)
	{
		return default(HCMIGMJPDCG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x2249A80", Offset = "0x2248E80", VA = "0x182249A80", Slot = "44")]
	public HCMIGMJPDCG GLNEAGNNBIE(ELMCKEEIEPE HAKDIDNIFLG, KENIFKLGBBB<HBIMBCKJJCB> MNEFPMEJNLM, IEnumerable<EKPAMDKNMJG<OJMKIAECBHB>> JILCHGLIFFB, IEnumerable<GCKACGBMEHC> IJJCPCHMMFJ)
	{
		return default(HCMIGMJPDCG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x224B540", Offset = "0x224A940", VA = "0x18224B540")]
	private static IEnumerable<EKPAMDKNMJG<HBIMBCKJJCB>> NAPJLBMHNKA(IEnumerable<GCKACGBMEHC> IJJCPCHMMFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x2249260", Offset = "0x2248660", VA = "0x182249260")]
	private IEnumerable<EKPAMDKNMJG<OJMKIAECBHB>> GBPJMCNJBKP(IEnumerable<GCKACGBMEHC> IJJCPCHMMFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x224BB50", Offset = "0x224AF50", VA = "0x18224BB50", Slot = "45")]
	public List<LNAMGHMMLNL> PEFBMHFCJCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x22486B0", Offset = "0x2247AB0", VA = "0x1822486B0")]
	public (List<LNAMGHMMLNL>, bool) DFGJMCNNCPJ([In] APHGOEFBCOK EOHCAFEMLBI, string EPLPPJHJIIM, [In] IOMAAPBMLCO LIACOHFFEEA, ACAEKMNHKFG LMGKKJCMDNJ, ANPHBPNKAML CJENKHMGGBK)
	{
		return default((List<LNAMGHMMLNL>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x224BF60", Offset = "0x224B360", VA = "0x18224BF60", Slot = "47")]
	public bool PGFNAKNIBBB(KENIFKLGBBB<HBIMBCKJJCB> IDNKPJNNEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x2247DC0", Offset = "0x22471C0", VA = "0x182247DC0")]
	internal void BDPFJMGPHOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x224A840", Offset = "0x2249C40", VA = "0x18224A840")]
	internal Task JDEDGFJCCGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x224A4C0", Offset = "0x22498C0", VA = "0x18224A4C0", Slot = "7")]
	private bool IFLJLNIPFNE(KENIFKLGBBB<HBIMBCKJJCB> IDNKPJNNEPC, [In] APCNMLEPOLJ JAGECECLCKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x224A8A0", Offset = "0x2249CA0", VA = "0x18224A8A0", Slot = "15")]
	private LNJFLFAMJMD LNHBLBHIHOI([In] EKPAMDKNMJG<HBIMBCKJJCB> IDNKPJNNEPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x224B390", Offset = "0x224A790", VA = "0x18224B390", Slot = "16")]
	private KENIFKLGBBB<HBIMBCKJJCB> MHLKPFNHPDL([In] EKPAMDKNMJG<HBIMBCKJJCB> IDNKPJNNEPC)
	{
		return default(KENIFKLGBBB<HBIMBCKJJCB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x22483F0", Offset = "0x22477F0", VA = "0x1822483F0", Slot = "17")]
	private KENIFKLGBBB<HBIMBCKJJCB>? JJIBANPNLED([In] EKPAMDKNMJG<HBIMBCKJJCB> IDNKPJNNEPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x224A4D0", Offset = "0x22498D0", VA = "0x18224A4D0", Slot = "18")]
	private OOJIJCAGPLP IFLKGLDDADL([In] EKPAMDKNMJG<OJMKIAECBHB> LFFCFCIDMIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x2248D70", Offset = "0x2248170", VA = "0x182248D70", Slot = "19")]
	private KENIFKLGBBB<OJMKIAECBHB> EBEOPJHNNIP(KENIFKLGBBB<HBIMBCKJJCB> IDNKPJNNEPC, [In] EKPAMDKNMJG<OJMKIAECBHB> EJNLLNHKFDG)
	{
		return default(KENIFKLGBBB<OJMKIAECBHB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x224AEC0", Offset = "0x224A2C0", VA = "0x18224AEC0", Slot = "24")]
	private IEnumerable<OOJIJCAGPLP> LMCKHBODHAG([In] EKPAMDKNMJG<HBIMBCKJJCB> IDNKPJNNEPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x2247B50", Offset = "0x2246F50", VA = "0x182247B50", Slot = "31")]
	private EEDCADADMDF BBCGJCDDIFP(KENIFKLGBBB<HBIMBCKJJCB> IDNKPJNNEPC, [In] APCNMLEPOLJ JAGECECLCKI)
	{
		return default(EEDCADADMDF);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x2249EE0", Offset = "0x22492E0", VA = "0x182249EE0", Slot = "37")]
	private BMFECDODLAB<CHLHIIGLCHO.BOMNODPPEMJ, BOMFIFNIFBO> MIKELDACCJO([In] CHLHIIGLCHO.JIAEBLFIBNG KCHFAPGLICB)
	{
		return default(BMFECDODLAB<CHLHIIGLCHO.BOMNODPPEMJ, BOMFIFNIFBO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x224BAF0", Offset = "0x224AEF0", VA = "0x18224BAF0", Slot = "46")]
	private (List<LNAMGHMMLNL>, bool) PDPFCHAALIB([In] APHGOEFBCOK EOHCAFEMLBI, string EPLPPJHJIIM, [In] IOMAAPBMLCO LIACOHFFEEA, ACAEKMNHKFG LMGKKJCMDNJ, ANPHBPNKAML CJENKHMGGBK)
	{
		return default((List<LNAMGHMMLNL>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x224A8D0", Offset = "0x2249CD0", VA = "0x18224A8D0")]
	[CompilerGenerated]
	private OOJIJCAGPLP JPBDILBHHBI(IDOFAFFGDFF CLDPBDGHEDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x224B410", Offset = "0x224A810", VA = "0x18224B410")]
	[CompilerGenerated]
	private HBACACJHGDI MIDCBEGGMHL(EFLKGKHCABI CLDPBDGHEDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x224BEF0", Offset = "0x224B2F0", VA = "0x18224BEF0")]
	[CompilerGenerated]
	private IDOFAFFGDFF PFBNPNOCDOG(EKPAMDKNMJG<OJMKIAECBHB> CLDPBDGHEDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x224B4D0", Offset = "0x224A8D0", VA = "0x18224B4D0")]
	[CompilerGenerated]
	private MHLHJMNGPNM MPHCHFIAFAO(EKPAMDKNMJG<HBIMBCKJJCB> CLDPBDGHEDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class HBACACJHGDI : MECNCANHOPI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private struct LAMENAOMPKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<KENIFKLGBBB<JGHPCKNODPB>, JLOPLHOLGBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public HBACACJHGDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public EKPAMDKNMJG<HBIMBCKJJCB> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public EKPAMDKNMJG<OJMKIAECBHB> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public KENIFKLGBBB<LJJEABOBKPI> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private TaskAwaiter<BMFECDODLAB<KENIFKLGBBB<JGHPCKNODPB>, JLOPLHOLGBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x225EC80", Offset = "0x225E080", VA = "0x18225EC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x225EF00", Offset = "0x225E300", VA = "0x18225EF00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct BMPBJBHGCLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<KENIFKLGBBB<HBFNEOMKDHH>, JLOPLHOLGBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public HBACACJHGDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public EKPAMDKNMJG<HBIMBCKJJCB> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public EKPAMDKNMJG<OJMKIAECBHB> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public KENIFKLGBBB<LJJEABOBKPI> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private TaskAwaiter<BMFECDODLAB<KENIFKLGBBB<HBFNEOMKDHH>, JLOPLHOLGBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x225D7A0", Offset = "0x225CBA0", VA = "0x18225D7A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x225DA20", Offset = "0x225CE20", VA = "0x18225DA20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	private readonly EFLKGKHCABI NHFAKGLPHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	private readonly HIAEONOJIEE BGHBCILNABE;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public TypeKey EMPGAKOMBJH
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x9741A0", Offset = "0x9735A0", VA = "0x1809741A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public string FOJDOCHGNKI
	{
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x225E4A0", Offset = "0x225D8A0", VA = "0x18225E4A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public EFLKGKHCABI EOPFDABNMLO
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x225E640", Offset = "0x225DA40", VA = "0x18225E640")]
	public HBACACJHGDI(EFLKGKHCABI KOGFHBCHOLB, HIAEONOJIEE HCGGNCNNIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x225E330", Offset = "0x225D730", VA = "0x18225E330", Slot = "6")]
	[AsyncStateMachine(typeof(LAMENAOMPKM))]
	public Task<BMFECDODLAB<KENIFKLGBBB<JGHPCKNODPB>, JLOPLHOLGBP>> NIEGCGIADLK(EKPAMDKNMJG<HBIMBCKJJCB> IDNKPJNNEPC, EKPAMDKNMJG<OJMKIAECBHB> LFFCFCIDMIM, KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII, string ACDGEPBIBHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x225E4D0", Offset = "0x225D8D0", VA = "0x18225E4D0", Slot = "7")]
	[AsyncStateMachine(typeof(BMPBJBHGCLB))]
	public Task<BMFECDODLAB<KENIFKLGBBB<HBFNEOMKDHH>, JLOPLHOLGBP>> PFPBPBKKHFB(EKPAMDKNMJG<HBIMBCKJJCB> IDNKPJNNEPC, EKPAMDKNMJG<OJMKIAECBHB> LFFCFCIDMIM, KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII, string ACDGEPBIBHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class LOPNBIJFNCK : BCHMNKODLAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private readonly EFLKGKHCABI KNIELIDNDEI;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private static readonly HashSet<EFLKGKHCABI> OFPCAIEHJPI;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private static readonly HashSet<EFLKGKHCABI> DGEOEJDJMDM;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private static readonly HashSet<EFLKGKHCABI> JBMCHCDLACJ;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public TypeKey NOMMKAICFPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x2260720", Offset = "0x225FB20", VA = "0x182260720", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool GAAGCOIFCJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x2260710", Offset = "0x225FB10", VA = "0x182260710", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool MDGMFNNCPJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x2260770", Offset = "0x225FB70", VA = "0x182260770", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool BFLIIGNIPLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x2260690", Offset = "0x225FA90", VA = "0x182260690", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x225F2F0", Offset = "0x225E6F0", VA = "0x18225F2F0")]
	public bool HDLDFBFGBBO(string PFKKDHPJFEH, [Out] LHGGHHHMHCG GNKPBMKLHAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x89A2A0", Offset = "0x8996A0", VA = "0x18089A2A0")]
	public LOPNBIJFNCK(EFLKGKHCABI KPECMEHKPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x225F160", Offset = "0x225E560", VA = "0x18225F160")]
	internal static TypeKey EOCACHFLBCM(EFLKGKHCABI EKNPHEPNHJD)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x225E4A0", Offset = "0x225D8A0", VA = "0x18225E4A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public readonly struct HIFHINLPGFP : DMHNFCBKGOM.CBAFNPOPFMN<HFDKJCIJLFF, FHMPKELNMGN>
{
	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x225E780", Offset = "0x225DB80", VA = "0x18225E780", Slot = "4")]
	public int LGJJFOOBKAC(FHMPKELNMGN KGHCPOJBNFM, HFDKJCIJLFF LLIKOHELCCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x225E6E0", Offset = "0x225DAE0", VA = "0x18225E6E0", Slot = "5")]
	public HFDKJCIJLFF AFCDHLBHDOJ(FHMPKELNMGN KGHCPOJBNFM, HFDKJCIJLFF LLIKOHELCCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x225E7E0", Offset = "0x225DBE0", VA = "0x18225E7E0", Slot = "6")]
	public HFDKJCIJLFF OEOHJLDHJEG(FHMPKELNMGN KGHCPOJBNFM, HFDKJCIJLFF LLIKOHELCCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x225E760", Offset = "0x225DB60", VA = "0x18225E760", Slot = "7")]
	public IReadOnlyList<HFDKJCIJLFF> IAHBODCLPOH(FHMPKELNMGN KGHCPOJBNFM, HFDKJCIJLFF LLIKOHELCCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x225E6F0", Offset = "0x225DAF0", VA = "0x18225E6F0", Slot = "8")]
	public HFDKJCIJLFF[] CDPMCPOJPHM(FHMPKELNMGN KGHCPOJBNFM, HFDKJCIJLFF LLIKOHELCCA, int KHMIHCMKKEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x225E810", Offset = "0x225DC10", VA = "0x18225E810", Slot = "9")]
	public bool OPFFEIMPPAN(FHMPKELNMGN KGHCPOJBNFM, HFDKJCIJLFF LLIKOHELCCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x225E720", Offset = "0x225DB20", VA = "0x18225E720", Slot = "10")]
	public bool CNMJFLKIHGD(FHMPKELNMGN KGHCPOJBNFM, HFDKJCIJLFF LLIKOHELCCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x225E7C0", Offset = "0x225DBC0", VA = "0x18225E7C0", Slot = "11")]
	public bool OBDOBPLEAPB(FHMPKELNMGN KGHCPOJBNFM, HFDKJCIJLFF LLIKOHELCCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x225E7A0", Offset = "0x225DBA0", VA = "0x18225E7A0", Slot = "12")]
	public bool LPOPIEIHKMB(FHMPKELNMGN KGHCPOJBNFM, HFDKJCIJLFF LLIKOHELCCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x225E700", Offset = "0x225DB00", VA = "0x18225E700", Slot = "13")]
	public bool CKFLGAEOCJJ(FHMPKELNMGN EFLFHDNJFEB, HFDKJCIJLFF LLIKOHELCCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x225E740", Offset = "0x225DB40", VA = "0x18225E740", Slot = "14")]
	public bool DDCHHLOHJGD(FHMPKELNMGN KGHCPOJBNFM, HFDKJCIJLFF LLIKOHELCCA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public abstract class IJNIBIMGDJN : LBBABFCGHBL
{
	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public KEAHCMJEMMB.OMAOMMPANPH PJNFJGLLCOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x225E830", Offset = "0x225DC30", VA = "0x18225E830", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public abstract KDNCNEFJPFE.JFMNNKIPAGL IJIGKIHKFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public abstract FIJILADMNPM.FCOPKECMIMK MJEIJNDJLLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public abstract IOECLFJLDNB.MDBAKDGIDKJ DGLBJKJLCFF
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public IDMDJNIGDML.JHLOFCFNCNK<LHMPGDLOMEB, HFDKJCIJLFF, FIJILADMNPM> BFMAJOJHGJC
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x225E880", Offset = "0x225DC80", VA = "0x18225E880", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public abstract NBBBODNMAKD HFKIOKMPEOF
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public abstract MHLELPEGFEA FCDGDDHNJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public abstract LMODBKGOEIO HBEGJPHFJJL
	{
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public abstract BGOAGPGANPK OKHHMJJJFLF
	{
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public abstract ICMFMFKDIKE OBFONMFKLPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	protected IJNIBIMGDJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class DKCCJHGALGJ : ALLHNFBDNGN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct OMIEBGEMLNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<object, JLOPLHOLGBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public DKCCJHGALGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public HFDKJCIJLFF action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private TaskAwaiter<BMFECDODLAB<object, JLOPLHOLGBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x22608F0", Offset = "0x225FCF0", VA = "0x1822608F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x2260B90", Offset = "0x225FF90", VA = "0x182260B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct GICGFEANGEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<JMILCABJNBN, JLOPLHOLGBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public DKCCJHGALGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public IReadOnlyList<HFDKJCIJLFF> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private TaskAwaiter<BMFECDODLAB<object, JLOPLHOLGBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x225DF40", Offset = "0x225D340", VA = "0x18225DF40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x225E2C0", Offset = "0x225D6C0", VA = "0x18225E2C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	private readonly DDMPAGDCGFP AHCBFPIOBKG;

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x89A2A0", Offset = "0x8996A0", VA = "0x18089A2A0")]
	public DKCCJHGALGJ(DDMPAGDCGFP CLINKFHNFLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x225DC80", Offset = "0x225D080", VA = "0x18225DC80")]
	[AsyncStateMachine(typeof(OMIEBGEMLNH))]
	private Task<BMFECDODLAB<object, JLOPLHOLGBP>> DLKAHCIPCOB(HFDKJCIJLFF LLIKOHELCCA, bool PFAJPHGPIDK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x225DDB0", Offset = "0x225D1B0", VA = "0x18225DDB0", Slot = "4")]
	[AsyncStateMachine(typeof(GICGFEANGEL))]
	public Task<BMFECDODLAB<JMILCABJNBN, JLOPLHOLGBP>> MOFAGIAPMHF(IReadOnlyList<HFDKJCIJLFF> FJHJEKPJEMH, bool PFAJPHGPIDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public struct NKCJKAHLIKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	internal IKNEJNHIFEK<DNPKNMKNBAB, HFDKJCIJLFF, CKKDJNIPFNF> KNIELIDNDEI;

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x2238110", Offset = "0x2237510", VA = "0x182238110")]
	private NKCJKAHLIKA([In] IKNEJNHIFEK<DNPKNMKNBAB, HFDKJCIJLFF, CKKDJNIPFNF> EFOPLECDGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x2260890", Offset = "0x225FC90", VA = "0x182260890")]
	public static NKCJKAHLIKA GIIIFAJNKEL()
	{
		return default(NKCJKAHLIKA);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public static class OAFFIJMEGPF
{
	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x9F9470", Offset = "0x9F8870", VA = "0x1809F9470")]
	public static IKNEJNHIFEK<DNPKNMKNBAB, HFDKJCIJLFF, CKKDJNIPFNF> JGNBEBOFIEH(this NKCJKAHLIKA EAFEIEDNLNL)
	{
		return default(IKNEJNHIFEK<DNPKNMKNBAB, HFDKJCIJLFF, CKKDJNIPFNF>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public struct CKKDJNIPFNF : HAHECDGCELM.PFODLDCDPNA<DNPKNMKNBAB, HFDKJCIJLFF>
{
	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x225DA90", Offset = "0x225CE90", VA = "0x18225DA90", Slot = "5")]
	public HFDKJCIJLFF PEELDLFKBAC(DNPKNMKNBAB[] PKCEBELHPII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x1A371B0", Offset = "0x1A365B0", VA = "0x181A371B0")]
	public int GPAPKEECFFO([In] DNPKNMKNBAB EFDDMAFCIKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x1A371B0", Offset = "0x1A365B0", VA = "0x181A371B0", Slot = "4")]
	private int OLFALABCOOL([In] DNPKNMKNBAB GFBBNMFNOED)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public struct EMJHMFDHIPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	internal KLMCKAINDOO<BPJMMCONJEM, HFDKJCIJLFF, LOILHFMCHLL> KNIELIDNDEI;

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x2238110", Offset = "0x2237510", VA = "0x182238110")]
	private EMJHMFDHIPJ([In] KLMCKAINDOO<BPJMMCONJEM, HFDKJCIJLFF, LOILHFMCHLL> HBPELFMECPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x225DEE0", Offset = "0x225D2E0", VA = "0x18225DEE0")]
	public static EMJHMFDHIPJ GIIIFAJNKEL()
	{
		return default(EMJHMFDHIPJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public static class CDGHHJLPGMP
{
	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x9F9470", Offset = "0x9F8870", VA = "0x1809F9470")]
	public static KLMCKAINDOO<BPJMMCONJEM, HFDKJCIJLFF, LOILHFMCHLL> JGNBEBOFIEH(this EMJHMFDHIPJ EAFEIEDNLNL)
	{
		return default(KLMCKAINDOO<BPJMMCONJEM, HFDKJCIJLFF, LOILHFMCHLL>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public struct LOILHFMCHLL : IKKOOFBGGIE.HBOFKJJFKCP<BPJMMCONJEM, HFDKJCIJLFF>
{
	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x1A371B0", Offset = "0x1A365B0", VA = "0x181A371B0")]
	public int EFBPPDFGEKL([In] BPJMMCONJEM EFDDMAFCIKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x225EF70", Offset = "0x225E370", VA = "0x18225EF70", Slot = "5")]
	public HFDKJCIJLFF JEEIFHKBFIK(BPJMMCONJEM[] AOFJHMJLIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x1A371B0", Offset = "0x1A365B0", VA = "0x181A371B0", Slot = "4")]
	private int EAGPDOPEPMK([In] BPJMMCONJEM EFDDMAFCIKF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public class BKONGBKPCGM : MBCBLBGJNJI, BOMFIFNIFBO, JLOPLHOLGBP, JPIHCAEEFCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private readonly JPIHCAEEFCD? HGOILLMIDOI;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public DKJLMIBJANE MHFCAMFHEPH
	{
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x89FC40", Offset = "0x89F040", VA = "0x18089FC40", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(DKJLMIBJANE);
		}
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x8A7060", Offset = "0x8A6460", VA = "0x1808A7060")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public override JPIHCAEEFCD? BLEABIALBOK
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x89EF40", Offset = "0x89E340", VA = "0x18089EF40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x225D500", Offset = "0x225C900", VA = "0x18225D500", Slot = "7")]
	public override string ECJFEDANMLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x225D760", Offset = "0x225CB60", VA = "0x18225D760")]
	private BKONGBKPCGM(DKJLMIBJANE PMKDNKJPJKE, JPIHCAEEFCD? KCEGLGLBMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x225D670", Offset = "0x225CA70", VA = "0x18225D670")]
	public static BKONGBKPCGM OGEBHAKDOBJ(JPIHCAEEFCD KCEGLGLBMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x225D490", Offset = "0x225C890", VA = "0x18225D490")]
	public static BKONGBKPCGM CBGHLKJFNKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x225D6F0", Offset = "0x225CAF0", VA = "0x18225D6F0")]
	public static BKONGBKPCGM PDOCKJOCNED()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class EEKNLNAEJGB
{
	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x2D10A30", Offset = "0x2D0FE30", VA = "0x182D10A30")]
	public static BMFECDODLAB<TOk, BOMFIFNIFBO> JEPELICPMLE<TOk>([In] this BMFECDODLAB<TOk, BOMFIFNIFBO> EAFEIEDNLNL, JPIHCAEEFCD KCEGLGLBMEK) where TOk : notnull
	{
		return default(BMFECDODLAB<TOk, BOMFIFNIFBO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x2D10840", Offset = "0x2D0FC40", VA = "0x182D10840")]
	public static BMFECDODLAB<TOk?, BOMFIFNIFBO?> FALONHMHHOL<TOk>([In] this BMFECDODLAB<TOk, BOMFIFNIFBO> EAFEIEDNLNL)
	{
		return default(BMFECDODLAB<TOk, BOMFIFNIFBO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x2D10930", Offset = "0x2D0FD30", VA = "0x182D10930")]
	public static BMFECDODLAB<TOk?, BOMFIFNIFBO?> IICIBCJFCPJ<TOk>([In] this BMFECDODLAB<TOk, BOMFIFNIFBO> EAFEIEDNLNL)
	{
		return default(BMFECDODLAB<TOk, BOMFIFNIFBO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public interface NBBBODNMAKD
{
	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OBNJJKMGIOC([In] BMFECDODLAB<FHMPKELNMGN, JPIHCAEEFCD> HCMJFDLGOJF);
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public static class FCPFBGCBEGH
{
	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x2E9C4B0", Offset = "0x2E9B8B0", VA = "0x182E9C4B0")]
	public static bool OBNJJKMGIOC<TOk, TErr>(this NBBBODNMAKD EAFEIEDNLNL, [In] BMFECDODLAB<TOk, TErr> HCMJFDLGOJF) where TOk : notnull where TErr : notnull, JPIHCAEEFCD
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public interface MHLELPEGFEA
{
	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	HCJNKMMACAO LJEFAICALIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public interface LMODBKGOEIO
{
	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IJALJJFMGAC HKJILLEKLNN(int FAPEMOGNOJH);
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public interface EMPLONLGANH
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	string MKBLEONOOOC
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public interface ALIMBMEDBPJ
{
	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	APNBJGHIFEF? EHODOIOJGMO(KENIFKLGBBB<LJJEABOBKPI> NBHJEPMDBII);
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public interface JOEHMNDOIDG
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	string MKBLEONOOOC
	{
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public interface APNBJGHIFEF
{
	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	string MKBLEONOOOC
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JOEHMNDOIDG? IFEDEBCADDM(KENIFKLGBBB<JGHPCKNODPB> NEFPINAGFII);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EMPLONLGANH? BIHDCPMHJGG(KENIFKLGBBB<HBFNEOMKDHH> BLPJFEPEEFC);
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public interface BGOAGPGANPK
{
	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> CJGPEOGIPNE(string PFKKDHPJFEH, string EPLPPJHJIIM);
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public interface ICMFMFKDIKE
{
	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ALIMBMEDBPJ? PNJIOPOPODM([In] EKPAMDKNMJG<HAGNHDFDPID> IKBAKBGPHOB);
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class PDCKOKMPCKL
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	private struct APDFNCMHLNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public int DIJEOHGLGIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public IKFHAIHBMIK? FHHHIPCEBKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public IKFHAIHBMIK? KPJANHBFGGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public readonly List<HFDKJCIJLFF> BCMICMFIIPA;

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x225D440", Offset = "0x225C840", VA = "0x18225D440")]
		private APDFNCMHLNA(int OBFJPFHENMC, IKFHAIHBMIK? AFMDIJEIOBA, IKFHAIHBMIK? DJODGKPMPOP, List<HFDKJCIJLFF> FJHJEKPJEMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x225D380", Offset = "0x225C780", VA = "0x18225D380")]
		public static APDFNCMHLNA GIIIFAJNKEL()
		{
			return default(APDFNCMHLNA);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private readonly DAIFAGENGHN<APDFNCMHLNA> PGMDOIGFAPG;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public static PDCKOKMPCKL GHDNHBBFDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x2261300", Offset = "0x2260700", VA = "0x182261300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool IECAMGCBMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x931420", Offset = "0x930820", VA = "0x180931420")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x992330", Offset = "0x991730", VA = "0x180992330")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x2261240", Offset = "0x2260640", VA = "0x182261240")]
	public void FHPIDCNCGOL(HHIMEGIMJAG DJODGKPMPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x2260C00", Offset = "0x2260000", VA = "0x182260C00")]
	public void AANBFHAMEDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x2260F00", Offset = "0x2260300", VA = "0x182260F00")]
	private static string? AHAPLMHIJDM([In] APDFNCMHLNA HKDDAOJOOAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x2261450", Offset = "0x2260850", VA = "0x182261450")]
	public PDCKOKMPCKL()
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
