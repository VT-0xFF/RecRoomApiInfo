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
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x21F7510", Offset = "0x21F6910", VA = "0x1821F7510")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D5A40", Offset = "0x8D4E40", VA = "0x1808D5A40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D5A80", Offset = "0x8D4E80", VA = "0x1808D5A80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class NPOGACBNNEB : IDisposable, ADBPIADFDBC, JOHMPBGNCNG, ACACAFDKEMN, OBBBHJPODDB
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class IKPFOMEKDFI : ODAOEHONNOG
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int FPLNKGFHODG
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x21EF9F0", Offset = "0x21EEDF0", VA = "0x1821EF9F0", Slot = "5")]
		public KJNBOEGDDID NBOJJGLHLAK(JPDGKKEBNJD.LEPFDOIFJNA ICFGLKCGHOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void FLKMANCLBNI();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void OIHCIAJNNIM();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x21EF930", Offset = "0x21EED30", VA = "0x1821EF930", Slot = "13")]
		public virtual void DBCAGCDNDIA(NPOGACBNNEB DAAJPDFKLAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x21EF970", Offset = "0x21EED70", VA = "0x1821EF970", Slot = "14")]
		public virtual void FMFDIDFNGGA(NPOGACBNNEB DAAJPDFKLAI, MMPFCBBACAJ MDOOJHKFGMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		protected IKPFOMEKDFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface ODAOEHONNOG
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int FPLNKGFHODG
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		KJNBOEGDDID NBOJJGLHLAK(JPDGKKEBNJD.LEPFDOIFJNA ICFGLKCGHOG);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void FLKMANCLBNI();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OIHCIAJNNIM();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DBCAGCDNDIA(NPOGACBNNEB DAAJPDFKLAI);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void FMFDIDFNGGA(NPOGACBNNEB DAAJPDFKLAI, MMPFCBBACAJ MDOOJHKFGMP);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct EMKABABHHDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly IMKDEIMDPBG<MHKGHIJEKIM, MMPFCBBACAJ, NPOGACBNNEB, PBBGFJIIJDE.CNELGLEOHLI<MHKGHIJEKIM, MMPFCBBACAJ, NPOGACBNNEB>> JLNLNODPCMP;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x21E9B70", Offset = "0x21E8F70", VA = "0x1821E9B70")]
		internal EMKABABHHDB(IMKDEIMDPBG<MHKGHIJEKIM, MMPFCBBACAJ, NPOGACBNNEB, PBBGFJIIJDE.CNELGLEOHLI<MHKGHIJEKIM, MMPFCBBACAJ, NPOGACBNNEB>> GDIPKBJJCBL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class ILBHLKBLCEG : PBBGFJIIJDE.CNELGLEOHLI<MHKGHIJEKIM, MMPFCBBACAJ, NPOGACBNNEB>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly ILBHLKBLCEG FKMJLLKHOAH;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		private ILBHLKBLCEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1363880", Offset = "0x1362C80", VA = "0x181363880", Slot = "4")]
		public MHKGHIJEKIM MDMGMOIPKNP(MMPFCBBACAJ MBGHIKEGJAA)
		{
			return default(MHKGHIJEKIM);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x21EFB40", Offset = "0x21EEF40", VA = "0x1821EFB40", Slot = "5")]
		public void DBCAGCDNDIA(NPOGACBNNEB FINELPFBLOK, MMPFCBBACAJ MDOOJHKFGMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x21EFC40", Offset = "0x21EF040", VA = "0x1821EFC40", Slot = "6")]
		public void FMFDIDFNGGA(NPOGACBNNEB FINELPFBLOK, MMPFCBBACAJ MDOOJHKFGMP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct FNHNEFPKHKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public CHBJLOGABAB<MHKGHIJEKIM, MMPFCBBACAJ, NPOGACBNNEB, PBBGFJIIJDE.CNELGLEOHLI<MHKGHIJEKIM, MMPFCBBACAJ, NPOGACBNNEB>> JLNLNODPCMP;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x21EA310", Offset = "0x21E9710", VA = "0x1821EA310")]
		internal FNHNEFPKHKG(CHBJLOGABAB<MHKGHIJEKIM, MMPFCBBACAJ, NPOGACBNNEB, PBBGFJIIJDE.CNELGLEOHLI<MHKGHIJEKIM, MMPFCBBACAJ, NPOGACBNNEB>> GDIPKBJJCBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x21EA2C0", Offset = "0x21E96C0", VA = "0x1821EA2C0")]
		public static FNHNEFPKHKG AALKPJMFIHM()
		{
			return default(FNHNEFPKHKG);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct JFFGFFPEAHN : OOFFKPOODLA.KJKFABBFMEB<MMPFCBBACAJ, NPOGACBNNEB>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct LFFHHIJJMGE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<MLIDCCDLMIE<object, FNDOAGAGANG>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NPOGACBNNEB receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public MMPFCBBACAJ action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public JFFGFFPEAHN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<MLIDCCDLMIE<object, FNDOAGAGANG>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x21F10E0", Offset = "0x21F04E0", VA = "0x1821F10E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x21F12C0", Offset = "0x21F06C0", VA = "0x1821F12C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA36F00", Offset = "0xA36300", VA = "0x180A36F00", Slot = "4")]
		public FGLBFCBPBCD<FFADPJAABGA> PCMDNOPOOOJ(NPOGACBNNEB HBMDFELGEPK)
		{
			return default(FGLBFCBPBCD<FFADPJAABGA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x21F0140", Offset = "0x21EF540", VA = "0x1821F0140", Slot = "5")]
		[AsyncStateMachine(typeof(LFFHHIJJMGE))]
		public Task<MLIDCCDLMIE<object, FNDOAGAGANG>> NKCJLKLGGBG(NPOGACBNNEB HBMDFELGEPK, MMPFCBBACAJ MDOOJHKFGMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x21F0120", Offset = "0x21EF520", VA = "0x1821F0120", Slot = "6")]
		public MMPFCBBACAJ[] LLNBKPFGGFI(NPOGACBNNEB HBMDFELGEPK)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct CAOAGEDLHLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<bool, FNDOAGAGANG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public NPOGACBNNEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public FJPDKJENCCL rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public HPGJHIFKKPI circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public GIMIMNLPGGB superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<MLIDCCDLMIE<bool, FNDOAGAGANG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x21E8710", Offset = "0x21E7B10", VA = "0x1821E8710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x21E8990", Offset = "0x21E7D90", VA = "0x1821E8990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct OLJJBDLNGGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<bool, FNDOAGAGANG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public NPOGACBNNEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<MLIDCCDLMIE<bool, FNDOAGAGANG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x21F7D40", Offset = "0x21F7140", VA = "0x1821F7D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x21F7FD0", Offset = "0x21F73D0", VA = "0x1821F7FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct OOIHBKEJMAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public NPOGACBNNEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x21F8040", Offset = "0x21F7440", VA = "0x1821F8040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x21F8220", Offset = "0x21F7620", VA = "0x1821F8220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct CLPIAIJGMAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<object, FNDOAGAGANG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public NPOGACBNNEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public MMPFCBBACAJ action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<MLIDCCDLMIE<object, FNDOAGAGANG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x21E8CB0", Offset = "0x21E80B0", VA = "0x1821E8CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x21E8EA0", Offset = "0x21E82A0", VA = "0x1821E8EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct GMDOFHLKBOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public NPOGACBNNEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<MLIDCCDLMIE<bool, FNDOAGAGANG>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x21EB0A0", Offset = "0x21EA4A0", VA = "0x1821EB0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x21EB880", Offset = "0x21EAC80", VA = "0x1821EB880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly FGLBFCBPBCD<FFADPJAABGA> CNDJKOPPCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly EMKABABHHDB IBOGAKKFNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly INOHKOGCPLC AEDNCMDCBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly PNFOMENFIPH HBIGIINDPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1950")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly GILIOFOOLBA FPIJFNMIACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1958")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly LEIHDBBDJBH.JHPJECPHHHE BMEMDFNIHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1978")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly LDLJEDLBNNK CAAPJHIADGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1980")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly CKPPFBFPNGE KMGBICDAANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1988")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly KPFEHFPNGGF HDMIBOIJDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1990")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly BMNJBAHPJDO GKBPNJIOCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1998")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private AOBFMICPLNG AFIDGALPCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19A8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private HAGIKLNJCBF CHAAIKEGJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19C8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly INOHKOGCPLC.PDFJLFIGFKB HEONFBCEDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19D0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly KLPMHLBMBFG PECKCDLKJIA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public INOHKOGCPLC GJGNKFKEEGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x21F6D50", Offset = "0x21F6150", VA = "0x1821F6D50")]
		get
		{
			return default(INOHKOGCPLC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal ODAOEHONNOG OHHAKPAIKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x21F6200", Offset = "0x21F5600", VA = "0x1821F6200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal KJNBOEGDDID AOBLOEGIPNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x21F6470", Offset = "0x21F5870", VA = "0x1821F6470")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x21F6450", Offset = "0x21F5850", VA = "0x1821F6450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool PEOEDFIEIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x21F6440", Offset = "0x21F5840", VA = "0x1821F6440")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x21F6880", Offset = "0x21F5C80", VA = "0x1821F6880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public BGONLBBIMFK IHDPLGCPINN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x21F74D0", Offset = "0x21F68D0", VA = "0x1821F74D0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public HAJGGMENBOH PKHENAFJGJK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x21F74E0", Offset = "0x21F68E0", VA = "0x1821F74E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public KLKDHEGPFBP LEOGGCOIGKH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x21F7500", Offset = "0x21F6900", VA = "0x1821F7500", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public GGDODLFCLBP PENBEEHIFMM
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x21F74F0", Offset = "0x21F68F0", VA = "0x1821F74F0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public LEIHDBBDJBH? ENGHBPIHIFE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x21F6180", Offset = "0x21F5580", VA = "0x1821F6180", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private MELCPLGPBGA? KGJHJICMGEN
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x21F6C20", Offset = "0x21F6020", VA = "0x1821F6C20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x21F71D0", Offset = "0x21F65D0", VA = "0x1821F71D0")]
	private NPOGACBNNEB(GILIOFOOLBA IMMBGNDBPHG, FGLBFCBPBCD<FFADPJAABGA> NMAAEIEEHNK, [In] EMKABABHHDB KMLLHKNMENP, [In] INOHKOGCPLC HANGHAOFILF, [In] PNFOMENFIPH PPEHJFPJNAM, KJNBOEGDDID PNKGEKHICOE, [In] LEIHDBBDJBH.JHPJECPHHHE KFJIFONFNMB, INOHKOGCPLC.PDFJLFIGFKB CFEHMOMCBPK, KLPMHLBMBFG CKCKODDGCNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x21F5FC0", Offset = "0x21F53C0", VA = "0x1821F5FC0")]
	public static NPOGACBNNEB AALKPJMFIHM(GILIOFOOLBA ICFGLKCGHOG, [In] BJGOOHILIKO MBOOANOMPHA, HEBNPFIHMPM PBOHJEKKDLA, [In] HADMLIJPEPI PFONPKHJEHP, IAPGLMDDIDO HPNMJDJJMFI, FGLBFCBPBCD<FFADPJAABGA> NMAAEIEEHNK, FGLBFCBPBCD<KJKEKKMCLIG> JMLOLBIBECA, LMNOHBMPKBL ILJMGJGDGFJ, NDACCGGEJBL HCEHPJJINIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x21F5CE0", Offset = "0x21F50E0", VA = "0x1821F5CE0")]
	public static NPOGACBNNEB AALKPJMFIHM(GILIOFOOLBA IMMBGNDBPHG, [In] INOHKOGCPLC HANGHAOFILF, [In] PNFOMENFIPH PPEHJFPJNAM, FGLBFCBPBCD<FFADPJAABGA> NMAAEIEEHNK, FGLBFCBPBCD<KJKEKKMCLIG> JMLOLBIBECA, LMNOHBMPKBL ILJMGJGDGFJ, NDACCGGEJBL HCEHPJJINIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x21F6250", Offset = "0x21F5650", VA = "0x1821F6250", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x21F6480", Offset = "0x21F5880", VA = "0x1821F6480")]
	[AsyncStateMachine(typeof(CAOAGEDLHLO))]
	internal Task<MLIDCCDLMIE<bool, FNDOAGAGANG>> HCONPAMOENJ(FJPDKJENCCL DPLFPHNCENJ, HPGJHIFKKPI CPJCPGIAANG, GIMIMNLPGGB PFHICJBHJNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x21F6F70", Offset = "0x21F6370", VA = "0x1821F6F70")]
	[AsyncStateMachine(typeof(OLJJBDLNGGO))]
	public Task<MLIDCCDLMIE<bool, FNDOAGAGANG>> OBHEPGBKJCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x21F7060", Offset = "0x21F6460", VA = "0x1821F7060")]
	[AsyncStateMachine(typeof(OOIHBKEJMAC))]
	public Task<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> PJMGMOPFIJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x21F6D60", Offset = "0x21F6160", VA = "0x1821F6D60")]
	internal void NFBKPOIBNDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x21F7150", Offset = "0x21F6550", VA = "0x1821F7150")]
	internal JEJCONLJHLG<MMPFCBBACAJ> PPJEFLLMCKG([In] AEPMFMNPHBN HELOGPJEANB)
	{
		return default(JEJCONLJHLG<MMPFCBBACAJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x21F65E0", Offset = "0x21F59E0", VA = "0x1821F65E0")]
	internal bool HNGDLMFEEEG([In] AEPMFMNPHBN HELOGPJEANB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x21F6100", Offset = "0x21F5500", VA = "0x1821F6100")]
	internal JEJCONLJHLG<MMPFCBBACAJ> CHKNLHKJGAC([In] PCOGICGICJG HMGGJCECMKN)
	{
		return default(JEJCONLJHLG<MMPFCBBACAJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x21F6770", Offset = "0x21F5B70", VA = "0x1821F6770")]
	[AsyncStateMachine(typeof(CLPIAIJGMAN))]
	internal Task<MLIDCCDLMIE<object, FNDOAGAGANG>> IIJEMPEHGDL(MMPFCBBACAJ MDOOJHKFGMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x21F6890", Offset = "0x21F5C90", VA = "0x1821F6890")]
	private MMPFCBBACAJ[] LLNBKPFGGFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x21F6650", Offset = "0x21F5A50", VA = "0x1821F6650")]
	[AsyncStateMachine(typeof(GMDOFHLKBOH))]
	public Task<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> HONEEDEBKLK(Guid BBKEHAAJHIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class EMDEKGAMIKD
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2CB24B0", Offset = "0x2CB18B0", VA = "0x182CB24B0")]
	public static FLELEMODBCE<(TPrev?, NPOGACBNNEB?), MELCPLGPBGA> LJHLEBAPIBJ<TPrev>([In] this FLELEMODBCE<TPrev, NPOGACBNNEB> MBGHIKEGJAA)
	{
		return default(FLELEMODBCE<(TPrev, NPOGACBNNEB), MELCPLGPBGA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2CB2770", Offset = "0x2CB1B70", VA = "0x182CB2770")]
	public static FLELEMODBCE<TPrev?, NPOGACBNNEB?> NKKBGMKMCCC<TPrev>([In] this FLELEMODBCE<TPrev, NPOGACBNNEB> MBGHIKEGJAA)
	{
		return default(FLELEMODBCE<TPrev, NPOGACBNNEB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class LDCMGAHDLIG<TData> : IDBHBLPOJHF, KEOPLBEKHHJ, JPHFAKFKMJL where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly JABLMADMPHA<EPJMFNGLNNN>? CGJEONMBFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly string APMJJEAFGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly TData BAFNFCIODAA;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public JABLMADMPHA<EPJMFNGLNNN>? EMNOIEPKNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2423F80", Offset = "0x2423380", VA = "0x182423F80", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8A9D20", Offset = "0x8A9120", VA = "0x1808A9D20", Slot = "7")]
	public override string KIGPPELGDEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x45D4700", Offset = "0x45D3B00", VA = "0x1845D4700")]
	internal LDCMGAHDLIG([In] JABLMADMPHA<EPJMFNGLNNN>? DGLKHDMIBMM, FGLBFCBPBCD<EEHNGBBGEED>? BBAJEHAHICP, IOKind? PDOLNOFBMCI, string ADPAIBGIHMB, [In] TData MPMEGOKIEPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class FKGAABLAOEK
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x21E9E20", Offset = "0x21E9220", VA = "0x1821E9E20")]
	public static MLIDCCDLMIE<GKEHBFMJDAP, KEOPLBEKHHJ> KKNOFFFACKL([In] this NCPKMBPEBOJ<IIOOPKHNAOO> KMGEBICNAND)
	{
		return default(MLIDCCDLMIE<GKEHBFMJDAP, KEOPLBEKHHJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2E53150", Offset = "0x2E52550", VA = "0x182E53150")]
	public static MLIDCCDLMIE<TOk, KEOPLBEKHHJ> GKOIJOHOAGP<TOk>([In] this MLIDCCDLMIE<TOk, KEOPLBEKHHJ> MBGHIKEGJAA, [In] JABLMADMPHA<EPJMFNGLNNN>? DGLKHDMIBMM, FGLBFCBPBCD<EEHNGBBGEED>? BBAJEHAHICP, IOKind? PDOLNOFBMCI, string ADPAIBGIHMB) where TOk : notnull
	{
		return default(MLIDCCDLMIE<TOk, KEOPLBEKHHJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface GILIOFOOLBA
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IHBEENLFKBG.ECCLMOOEBCF AMMILFAGLFF
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	JPDGKKEBNJD.LEPFDOIFJNA MPGKGNACDJG
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	NPOGACBNNEB.ODAOEHONNOG BDGMIDJHGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	OEBHBKDNBDG.NFMIJAKBECH BKFGDIMFICG
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	PBBGFJIIJDE.CNELGLEOHLI<MHKGHIJEKIM, MMPFCBBACAJ, NPOGACBNNEB> JOLMNNLEGOO
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	LFPDLPFKFJE OOLDKCALAJA
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	LPCOFCPLEOL LDLJHHAKFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	KKDAAEBGGLO JONEJEODGFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	FPNMOGPDGAA IAPBEAOKPID
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	CHGEHHOBBFA IPHJFKCFPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class JKIKPGANMAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x21F05B0", Offset = "0x21EF9B0", VA = "0x1821F05B0")]
	public static MMPFCBBACAJ MKEKDDOEJOB(this MMPFCBBACAJ MBGHIKEGJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x21F04E0", Offset = "0x21EF8E0", VA = "0x1821F04E0")]
	public static MMPFCBBACAJ FLOLDLAFOOK(this HANIBBLPJOM MBGHIKEGJAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct HANIBBLPJOM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct AGKPPEEEJMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<object, FNDOAGAGANG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public NPOGACBNNEB root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public HANIBBLPJOM self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<MLIDCCDLMIE<object, FNDOAGAGANG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x21E70C0", Offset = "0x21E64C0", VA = "0x1821E70C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x21E7380", Offset = "0x21E6780", VA = "0x1821E7380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly ByteString JKEIFELLNME;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x93EE00", Offset = "0x93E200", VA = "0x18093EE00")]
	private HANIBBLPJOM(ByteString LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x21EB8F0", Offset = "0x21EACF0", VA = "0x1821EB8F0")]
	public static MMPFCBBACAJ APBHGGGMMIF(ByteString LIHHDPOHLDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x21EB9B0", Offset = "0x21EADB0", VA = "0x1821EB9B0")]
	public static MHCCOIIPMCO<MHKGHIJEKIM, HANIBBLPJOM> EODKGIEODEJ(MMPFCBBACAJ LPCMLDDHOFB)
	{
		return default(MHCCOIIPMCO<MHKGHIJEKIM, HANIBBLPJOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x21EBA60", Offset = "0x21EAE60", VA = "0x1821EBA60")]
	[AsyncStateMachine(typeof(AGKPPEEEJMB))]
	public static Task<MLIDCCDLMIE<object, FNDOAGAGANG>> IIJEMPEHGDL(NPOGACBNNEB FINELPFBLOK, HANIBBLPJOM MBGHIKEGJAA)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct KMMBNAFBBJC
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x21F0E50", Offset = "0x21F0250", VA = "0x1821F0E50")]
	public static MMPFCBBACAJ APBHGGGMMIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x21F0EF0", Offset = "0x21F02F0", VA = "0x1821F0EF0")]
	public static MHCCOIIPMCO<MHKGHIJEKIM, KMMBNAFBBJC> EODKGIEODEJ(MMPFCBBACAJ LPCMLDDHOFB)
	{
		return default(MHCCOIIPMCO<MHKGHIJEKIM, KMMBNAFBBJC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x21F0F60", Offset = "0x21F0360", VA = "0x1821F0F60")]
	public static MLIDCCDLMIE<OKFEIOHLOGM, FLDDNKNCPHH> JKMAMNAOLPC(NPOGACBNNEB FINELPFBLOK, [In] KMMBNAFBBJC MBGHIKEGJAA)
	{
		return default(MLIDCCDLMIE<OKFEIOHLOGM, FLDDNKNCPHH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct EHLPEMOAADJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct GCOFGHKLMMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<OKFEIOHLOGM, FLDDNKNCPHH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public NPOGACBNNEB root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public EHLPEMOAADJ self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private MLIDCCDLMIE<OKFEIOHLOGM, FLDDNKNCPHH> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x21EAA80", Offset = "0x21E9E80", VA = "0x1821EAA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x21EADF0", Offset = "0x21EA1F0", VA = "0x1821EADF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly FJPDKJENCCL? HBNGDIMCGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly HPGJHIFKKPI? GNLGPMBBAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly GIMIMNLPGGB? CECBIJEHEND;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x21161D0", Offset = "0x21155D0", VA = "0x1821161D0")]
	private EHLPEMOAADJ(FJPDKJENCCL? DPLFPHNCENJ, HPGJHIFKKPI? CPJCPGIAANG, GIMIMNLPGGB? PFHICJBHJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x21E97C0", Offset = "0x21E8BC0", VA = "0x1821E97C0")]
	public static MMPFCBBACAJ? APBHGGGMMIF(FJPDKJENCCL? DPLFPHNCENJ, HPGJHIFKKPI? CPJCPGIAANG, GIMIMNLPGGB? PFHICJBHJNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x21E98C0", Offset = "0x21E8CC0", VA = "0x1821E98C0")]
	public static MHCCOIIPMCO<MHKGHIJEKIM, EHLPEMOAADJ> EODKGIEODEJ(MMPFCBBACAJ LPCMLDDHOFB)
	{
		return default(MHCCOIIPMCO<MHKGHIJEKIM, EHLPEMOAADJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x21E99D0", Offset = "0x21E8DD0", VA = "0x1821E99D0")]
	[AsyncStateMachine(typeof(GCOFGHKLMMA))]
	public static Task<MLIDCCDLMIE<OKFEIOHLOGM, FLDDNKNCPHH>> IIJEMPEHGDL(NPOGACBNNEB FINELPFBLOK, EHLPEMOAADJ MBGHIKEGJAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct OCDNPJFGPKJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct AHCNJNDGPEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<KCOOFONOLPB, FNDOAGAGANG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public OCDNPJFGPKJ self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public NPOGACBNNEB root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private MLIDCCDLMIE<KCOOFONOLPB, FNDOAGAGANG> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private MLIDCCDLMIE<object, JPHFAKFKMJL>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private MLIDCCDLMIE<object, JPHFAKFKMJL> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private MLIDCCDLMIE<object, JPHFAKFKMJL>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<MLIDCCDLMIE<object, FNDOAGAGANG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x21E73F0", Offset = "0x21E67F0", VA = "0x1821E73F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x21E7850", Offset = "0x21E6C50", VA = "0x1821E7850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IReadOnlyList<MMPFCBBACAJ> MIBBPGEGCOM;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x93EE00", Offset = "0x93E200", VA = "0x18093EE00")]
	private OCDNPJFGPKJ(IReadOnlyList<MMPFCBBACAJ> LEPHFNPNBLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x21F7590", Offset = "0x21F6990", VA = "0x1821F7590")]
	public static MMPFCBBACAJ APBHGGGMMIF(IReadOnlyList<MMPFCBBACAJ> LEPHFNPNBLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x21F7650", Offset = "0x21F6A50", VA = "0x1821F7650")]
	public static MHCCOIIPMCO<MHKGHIJEKIM, OCDNPJFGPKJ> EODKGIEODEJ(MMPFCBBACAJ LPCMLDDHOFB)
	{
		return default(MHCCOIIPMCO<MHKGHIJEKIM, OCDNPJFGPKJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x21F76F0", Offset = "0x21F6AF0", VA = "0x1821F76F0")]
	[AsyncStateMachine(typeof(AHCNJNDGPEA))]
	public static Task<MLIDCCDLMIE<KCOOFONOLPB, FNDOAGAGANG>> IIJEMPEHGDL(NPOGACBNNEB FINELPFBLOK, OCDNPJFGPKJ MBGHIKEGJAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct PCOGICGICJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly int NJGLPGPPJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int LGPOLAJNCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly byte[] BAFNFCIODAA;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1FE0C40", Offset = "0x1FE0040", VA = "0x181FE0C40")]
	private PCOGICGICJG(int MGEMHICLKEP, int AEAHMAMPNLO, byte[] MPMEGOKIEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x21F8290", Offset = "0x21F7690", VA = "0x1821F8290")]
	public static MMPFCBBACAJ APBHGGGMMIF(int MGEMHICLKEP, int AEAHMAMPNLO, ByteString MPMEGOKIEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x21F8450", Offset = "0x21F7850", VA = "0x1821F8450")]
	public static MMPFCBBACAJ[] JEFINILLJCM(MMPFCBBACAJ MDOOJHKFGMP, int MPKJLPAEKPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x21F8370", Offset = "0x21F7770", VA = "0x1821F8370")]
	public static MHCCOIIPMCO<MHKGHIJEKIM, PCOGICGICJG> EODKGIEODEJ(MMPFCBBACAJ LPCMLDDHOFB)
	{
		return default(MHCCOIIPMCO<MHKGHIJEKIM, PCOGICGICJG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x21F8580", Offset = "0x21F7980", VA = "0x1821F8580")]
	public static MLIDCCDLMIE<MMPFCBBACAJ, FLDDNKNCPHH> JKMAMNAOLPC(NPOGACBNNEB FINELPFBLOK, [In] PCOGICGICJG MBGHIKEGJAA)
	{
		return default(MLIDCCDLMIE<MMPFCBBACAJ, FLDDNKNCPHH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct AEPMFMNPHBN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct BDMHAONFLKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<bool, FLDDNKNCPHH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NPOGACBNNEB root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AEPMFMNPHBN self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private MLIDCCDLMIE<bool, FLDDNKNCPHH> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<MLIDCCDLMIE<OKFEIOHLOGM, FLDDNKNCPHH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x21E7F90", Offset = "0x21E7390", VA = "0x1821E7F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x21E85D0", Offset = "0x21E79D0", VA = "0x1821E85D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly int NJGLPGPPJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int LGPOLAJNCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly byte[] BAFNFCIODAA;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1FE0C40", Offset = "0x1FE0040", VA = "0x181FE0C40")]
	private AEPMFMNPHBN(int MGEMHICLKEP, int AEAHMAMPNLO, byte[] MPMEGOKIEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x21E6BE0", Offset = "0x21E5FE0", VA = "0x1821E6BE0")]
	public static MMPFCBBACAJ APBHGGGMMIF(int MGEMHICLKEP, int AEAHMAMPNLO, ByteString MPMEGOKIEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x21E6DA0", Offset = "0x21E61A0", VA = "0x1821E6DA0")]
	public static MMPFCBBACAJ?[]? HEINIDFMBGF(int MPKJLPAEKPN, FJPDKJENCCL? DPLFPHNCENJ, HPGJHIFKKPI? CPJCPGIAANG, GIMIMNLPGGB? PFHICJBHJNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x21E6CC0", Offset = "0x21E60C0", VA = "0x1821E6CC0")]
	public static MHCCOIIPMCO<MHKGHIJEKIM, AEPMFMNPHBN> EODKGIEODEJ(MMPFCBBACAJ LPCMLDDHOFB)
	{
		return default(MHCCOIIPMCO<MHKGHIJEKIM, AEPMFMNPHBN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x21E6F90", Offset = "0x21E6390", VA = "0x1821E6F90")]
	[AsyncStateMachine(typeof(BDMHAONFLKG))]
	public static Task<MLIDCCDLMIE<bool, FLDDNKNCPHH>> IIJEMPEHGDL(NPOGACBNNEB FINELPFBLOK, AEPMFMNPHBN MBGHIKEGJAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class LDLJEDLBNNK : BGONLBBIMFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly NPOGACBNNEB CIMEKGEELOP;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public NAOIODFEBAO? FKMJLLKHOAH
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x21F0FE0", Offset = "0x21F03E0", VA = "0x1821F0FE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8AF9B0", Offset = "0x8AEDB0", VA = "0x1808AF9B0")]
	internal LDLJEDLBNNK(NPOGACBNNEB DAAJPDFKLAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class HMDMIADKCOB : NAOIODFEBAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly NPOGACBNNEB CIMEKGEELOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly NDEFHBDPGED GCANOLEMPBI;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8A9CD0", Offset = "0x8A90D0", VA = "0x1808A9CD0")]
	public HMDMIADKCOB(NPOGACBNNEB DAAJPDFKLAI, NDEFHBDPGED ICMGGGGJNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x21EBE50", Offset = "0x21EB250", VA = "0x1821EBE50", Slot = "4")]
	public MLIDCCDLMIE<GKEHBFMJDAP, KEOPLBEKHHJ> HDAMKEPCHPB(JABLMADMPHA<EPJMFNGLNNN> IEIONDBAINP, FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI, FGLBFCBPBCD<CLEIGCGCLHM> MMFEJGDOBPF)
	{
		return default(MLIDCCDLMIE<GKEHBFMJDAP, KEOPLBEKHHJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x21EBB70", Offset = "0x21EAF70", VA = "0x1821EBB70", Slot = "5")]
	public MLIDCCDLMIE<GKEHBFMJDAP, KEOPLBEKHHJ> BMFAMDGEEPG(JABLMADMPHA<EPJMFNGLNNN> IEIONDBAINP, FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI, FGLBFCBPBCD<CANFCBOLFDP> EHCJDFNAANJ)
	{
		return default(MLIDCCDLMIE<GKEHBFMJDAP, KEOPLBEKHHJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class IHBEENLFKBG : FPNPACFIABK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface ECCLMOOEBCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<NDEFHBDPGED> KHJOOLBDCOO(NPOGACBNNEB DAAJPDFKLAI, HPGJHIFKKPI? JOOKPPEKIOI, GIMIMNLPGGB? LNKGGEMCGFE, CancellationToken EEHACKMODLA);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		KMIPODNMGGP NEJKPHHCGJE(NPOGACBNNEB DAAJPDFKLAI, FJPDKJENCCL BLOHLDFABIK);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class GBMPPBOCPDO : ECCLMOOEBCF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct GFGOJHOKCFF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public AsyncTaskMethodBuilder<NDEFHBDPGED> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public NPOGACBNNEB circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public HPGJHIFKKPI cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public GIMIMNLPGGB cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter<OEBHBKDNBDG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x21EAE60", Offset = "0x21EA260", VA = "0x1821EAE60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x21EB030", Offset = "0x21EA430", VA = "0x1821EB030", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly GBMPPBOCPDO FKMJLLKHOAH;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		private GBMPPBOCPDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x21EA890", Offset = "0x21E9C90", VA = "0x1821EA890", Slot = "4")]
		[AsyncStateMachine(typeof(GFGOJHOKCFF))]
		public Task<NDEFHBDPGED> KHJOOLBDCOO(NPOGACBNNEB DAAJPDFKLAI, HPGJHIFKKPI? JOOKPPEKIOI, GIMIMNLPGGB? LNKGGEMCGFE, CancellationToken EEHACKMODLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x21EA9F0", Offset = "0x21E9DF0", VA = "0x1821EA9F0", Slot = "5")]
		public KMIPODNMGGP NEJKPHHCGJE(NPOGACBNNEB DAAJPDFKLAI, FJPDKJENCCL BLOHLDFABIK)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct ALLCIDABGPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder<IHBEENLFKBG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public NPOGACBNNEB circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public HPGJHIFKKPI cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public GIMIMNLPGGB cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public FJPDKJENCCL evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private ECCLMOOEBCF <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter<NDEFHBDPGED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x21E7A20", Offset = "0x21E6E20", VA = "0x1821E7A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x21E7F20", Offset = "0x21E7320", VA = "0x1821E7F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly NDEFHBDPGED GCANOLEMPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly KMIPODNMGGP ABABGKPIMAG;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public LEIHDBBDJBH ENGHBPIHIFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x21EF650", Offset = "0x21EEA50", VA = "0x1821EF650", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public MELCPLGPBGA KFCENDKPJBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x21EF870", Offset = "0x21EEC70", VA = "0x1821EF870", Slot = "5")]
		get
		{
			return default(MELCPLGPBGA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public HMDMIADKCOB ILCMPODLGFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public LFMNPBDBKCI ADHLIGNFCFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8AA340", Offset = "0x8A9740", VA = "0x1808AA340", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0xAD47D0", Offset = "0xAD3BD0", VA = "0x180AD47D0")]
	private IHBEENLFKBG(NDEFHBDPGED ICMGGGGJNOP, KMIPODNMGGP FIBKJHAGPDN, HMDMIADKCOB JBGCLFNMLKH, LFMNPBDBKCI GKKACANFOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x21EF6A0", Offset = "0x21EEAA0", VA = "0x1821EF6A0")]
	[AsyncStateMachine(typeof(ALLCIDABGPG))]
	public static Task<IHBEENLFKBG> DHDAGHKIMEG(NPOGACBNNEB DAAJPDFKLAI, FJPDKJENCCL BLOHLDFABIK, HPGJHIFKKPI? JOOKPPEKIOI, GIMIMNLPGGB? LNKGGEMCGFE, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x21EF810", Offset = "0x21EEC10", VA = "0x1821EF810", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class JPDGKKEBNJD : KJNBOEGDDID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface LEPFDOIFJNA
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<FPNPACFIABK> LKIMLFKPPHB(NPOGACBNNEB DAAJPDFKLAI, FJPDKJENCCL BLOHLDFABIK, HPGJHIFKKPI? JOOKPPEKIOI, GIMIMNLPGGB? LNKGGEMCGFE, CancellationToken EEHACKMODLA);

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FADGHNAAHNL();

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void HFPJBAOHHJM();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class AICBLGENEOI : LEPFDOIFJNA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct ACNNCEMIAEM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public AsyncTaskMethodBuilder<FPNPACFIABK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public NPOGACBNNEB circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public FJPDKJENCCL evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public HPGJHIFKKPI cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public GIMIMNLPGGB cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private TaskAwaiter<IHBEENLFKBG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x21E6830", Offset = "0x21E5C30", VA = "0x1821E6830", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x21E6B70", Offset = "0x21E5F70", VA = "0x1821E6B70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x21E78C0", Offset = "0x21E6CC0", VA = "0x1821E78C0", Slot = "4")]
		[AsyncStateMachine(typeof(ACNNCEMIAEM))]
		public Task<FPNPACFIABK> LKIMLFKPPHB(NPOGACBNNEB DAAJPDFKLAI, FJPDKJENCCL BLOHLDFABIK, HPGJHIFKKPI? JOOKPPEKIOI, GIMIMNLPGGB? LNKGGEMCGFE, CancellationToken EEHACKMODLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void FADGHNAAHNL();

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void HFPJBAOHHJM();

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		protected AICBLGENEOI()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct JAFGCNAAAAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder<FPNPACFIABK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public JPDGKKEBNJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter<OKFEIOHLOGM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x21EFDC0", Offset = "0x21EF1C0", VA = "0x1821EFDC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x21EFFC0", Offset = "0x21EF3C0", VA = "0x1821EFFC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct NKHCKAIOHNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public JPDGKKEBNJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public NPOGACBNNEB circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public FJPDKJENCCL evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public HPGJHIFKKPI cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public GIMIMNLPGGB cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<FPNPACFIABK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x21F4050", Offset = "0x21F3450", VA = "0x1821F4050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x21F4580", Offset = "0x21F3980", VA = "0x1821F4580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly LEPFDOIFJNA DILMOBAKENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly TaskCompletionSource<OKFEIOHLOGM> OEPHFIACMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly TaskCompletionSource<OKFEIOHLOGM> BDPMNJBOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly CancellationTokenSource AAPCBOAEDJK;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool PEOEDFIEIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x927B80", Offset = "0x926F80", VA = "0x180927B80", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x9229F0", Offset = "0x921DF0", VA = "0x1809229F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool NMBIACJCIOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x953350", Offset = "0x952750", VA = "0x180953350", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xDE8380", Offset = "0xDE7780", VA = "0x180DE8380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool MCIGDDBJABF
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1409790", Offset = "0x1408B90", VA = "0x181409790")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x21F09A0", Offset = "0x21EFDA0", VA = "0x1821F09A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public FPNPACFIABK? LJJEECNBJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F50", Offset = "0x8A9350", VA = "0x1808A9F50", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8B81A0", Offset = "0x8B75A0", VA = "0x1808B81A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x21F09B0", Offset = "0x21EFDB0", VA = "0x1821F09B0", Slot = "7")]
	[AsyncStateMachine(typeof(JAFGCNAAAAL))]
	public Task<FPNPACFIABK> ICCFDPEINKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x21F0AA0", Offset = "0x21EFEA0", VA = "0x1821F0AA0")]
	public JPDGKKEBNJD(LEPFDOIFJNA ICFGLKCGHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x21F06C0", Offset = "0x21EFAC0", VA = "0x1821F06C0", Slot = "8")]
	[AsyncStateMachine(typeof(NKHCKAIOHNM))]
	public Task DNBFJBKFHJO(NPOGACBNNEB DAAJPDFKLAI, FJPDKJENCCL BLOHLDFABIK, HPGJHIFKKPI? JOOKPPEKIOI, GIMIMNLPGGB? LNKGGEMCGFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x21F0820", Offset = "0x21EFC20", VA = "0x1821F0820", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class DHOKGHDOFFA : CJIGNLEMEDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly LFMNPBDBKCI PGBPFFDBFIF;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8AF9B0", Offset = "0x8AEDB0", VA = "0x1808AF9B0")]
	public DHOKGHDOFFA(LFMNPBDBKCI GKKACANFOON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class JGKOPFNNFCF
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class LFCFDKHKGEG<TGraph> : CIPHLFPOECO where TGraph : AMKKFMOEIJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		protected readonly TGraph COAAENILMKE;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public virtual PKAIPFINPPO? HAIAGMJPHDD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x123F780", Offset = "0x123EB80", VA = "0x18123F780", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public FGLBFCBPBCD<PKMIDGFKCAI> FLOEADHOMKD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x45D6A90", Offset = "0x45D5E90", VA = "0x1845D6A90", Slot = "5")]
			get
			{
				return default(FGLBFCBPBCD<PKMIDGFKCAI>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public FGLBFCBPBCD<PKMIDGFKCAI>? LLJLKEPODBF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x45D6AB0", Offset = "0x45D5EB0", VA = "0x1845D6AB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9B0", Offset = "0x8AEDB0", VA = "0x1808AF9B0")]
		public LFCFDKHKGEG(TGraph GFHEHGHBDMK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class DABIHFHELLO : LFCFDKHKGEG<MJKPFCBLFAO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override PKAIPFINPPO? HAIAGMJPHDD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x21E8F10", Offset = "0x21E8310", VA = "0x1821E8F10", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x21E8F30", Offset = "0x21E8330", VA = "0x1821E8F30")]
		public DABIHFHELLO(MJKPFCBLFAO JBLJCJOBOEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x21F0350", Offset = "0x21EF750", VA = "0x1821F0350")]
	public static CIPHLFPOECO AALKPJMFIHM(AMKKFMOEIJN GFHEHGHBDMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class IDKGDBGCPID : FIPKNLJIHBL, FCHCPAMLLED, ABLAJBADJIF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class JCFAIHFEMEE
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
			public JCFAIHFEMEE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public LFPDLPFKFJE errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x21F86A0", Offset = "0x21F7AA0", VA = "0x1821F86A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x21F8910", Offset = "0x21F7D10", VA = "0x1821F8910", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public IDKGDBGCPID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public JCFAIHFEMEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x21F0030", Offset = "0x21EF430", VA = "0x1821F0030")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task OFNINCGLMMF(LFPDLPFKFJE errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct GACCOBFMOIF : IAsyncStateMachine
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
		public IDKGDBGCPID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x21EA320", Offset = "0x21E9720", VA = "0x1821EA320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x21EA830", Offset = "0x21E9C30", VA = "0x1821EA830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class BNDPAOAHOIB
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
			public BNDPAOAHOIB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x21F8970", Offset = "0x21F7D70", VA = "0x1821F8970", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x21F8C50", Offset = "0x21F8050", VA = "0x1821F8C50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public IDKGDBGCPID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public BNDPAOAHOIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x21E8640", Offset = "0x21E7A40", VA = "0x1821E8640")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task KKMBABOGLBH(LFPDLPFKFJE errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly ANJINNCDNGK KGDHBGKCNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly ICollection<HDGOJFKJDKI> EBNCFDLHGBG;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private GILIOFOOLBA BBMJIKJPAIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x21ED850", Offset = "0x21ECC50", VA = "0x1821ED850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public FGLBFCBPBCD<CLEIGCGCLHM> OJHEHLEMDMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA8C7B0", Offset = "0xA8BBB0", VA = "0x180A8C7B0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(FGLBFCBPBCD<CLEIGCGCLHM>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA8DDE0", Offset = "0xA8D1E0", VA = "0x180A8DDE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private FGLBFCBPBCD<EEBKBHCGBCM> EMEDEHMPBAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xDE2D90", Offset = "0xDE2190", VA = "0x180DE2D90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public FGLBFCBPBCD<GAMDJBJJMEG> ILJLDLMODCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8D21D0", Offset = "0x8D15D0", VA = "0x1808D21D0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(FGLBFCBPBCD<GAMDJBJJMEG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public override FGLBFCBPBCD<EEHNGBBGEED> GDIFMFODKFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x21ED5B0", Offset = "0x21EC9B0", VA = "0x1821ED5B0", Slot = "20")]
		get
		{
			return default(FGLBFCBPBCD<EEHNGBBGEED>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool MKKEFIPICCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x21ED770", Offset = "0x21ECB70", VA = "0x1821ED770", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x21EF430", Offset = "0x21EE830", VA = "0x1821EF430")]
	private IDKGDBGCPID(NPOGACBNNEB DAAJPDFKLAI, JMGKFHAJOAG ABBPLCKDHFH, ANJINNCDNGK LGHELLAPMKP, FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI, FGLBFCBPBCD<CLEIGCGCLHM> MMFEJGDOBPF, FGLBFCBPBCD<EEBKBHCGBCM> KIDFOJNAAAB, bool IJHANKLIPBM, string ADANIHOIEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x21ECC00", Offset = "0x21EC000", VA = "0x1821ECC00")]
	public static IDKGDBGCPID AALKPJMFIHM(NPOGACBNNEB DAAJPDFKLAI, JMGKFHAJOAG ABBPLCKDHFH, ANJINNCDNGK GJMNBMBONPJ, FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI, FGLBFCBPBCD<EEBKBHCGBCM> KIDFOJNAAAB, FGLBFCBPBCD<CLEIGCGCLHM> MMFEJGDOBPF, bool IJHANKLIPBM, bool NEDLMKCGKHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x21EE4E0", Offset = "0x21ED8E0", VA = "0x1821EE4E0", Slot = "21")]
	protected override void JLABJFAHLGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x21ED600", Offset = "0x21ECA00", VA = "0x1821ED600", Slot = "22")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x21ED7F0", Offset = "0x21ECBF0", VA = "0x1821ED7F0", Slot = "30")]
	public void EIKALJEEDJP(HDGOJFKJDKI PJOHPANGPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x21EDC50", Offset = "0x21ED050", VA = "0x1821EDC50", Slot = "27")]
	public void HOGNKMFMBCC(DEAGOMLBJPG EMDDCAKINKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x21EE6A0", Offset = "0x21EDAA0", VA = "0x1821EE6A0", Slot = "28")]
	public void LIGDHENKIKD(CJDJPPIEFBN IOKCPHALAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x21ED090", Offset = "0x21EC490", VA = "0x1821ED090", Slot = "23")]
	protected override void CCDCKDMJCDH(FMDBDIMJDHO NFBBKPHBIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x21ED930", Offset = "0x21ECD30", VA = "0x1821ED930", Slot = "32")]
	public string HGGCPIEFHDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x21EE220", Offset = "0x21ED620", VA = "0x1821EE220", Slot = "29")]
	public string JCCOAEMOLNI(int ALOHHMGKCFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x21ED1E0", Offset = "0x21EC5E0", VA = "0x1821ED1E0")]
	private void CGNAOIECLMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x21EE160", Offset = "0x21ED560", VA = "0x1821EE160", Slot = "31")]
	public void IOLJDCPPMDN(HDGOJFKJDKI PJOHPANGPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x21EDA90", Offset = "0x21ECE90", VA = "0x1821EDA90")]
	private void HHMFEFLHPDP(bool LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x21ED410", Offset = "0x21EC810", VA = "0x1821ED410", Slot = "33")]
	[AsyncStateMachine(typeof(GACCOBFMOIF))]
	public Task CIJHBLFAFLM(string LIHHDPOHLDK, bool KHBBCFLAKFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x21EF160", Offset = "0x21EE560", VA = "0x1821EF160")]
	public void MKABAFIDMDG(string LIHHDPOHLDK, bool KHBBCFLAKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x21EDFC0", Offset = "0x21ED3C0", VA = "0x1821EDFC0")]
	private void IDPNJBCNHEC(int LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0xA8DDE0", Offset = "0xA8D1E0", VA = "0x180A8DDE0")]
	internal void BHIJHCCCEAI(FGLBFCBPBCD<CLEIGCGCLHM> LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x21ED080", Offset = "0x21EC480", VA = "0x1821ED080")]
	[CompilerGenerated]
	private void BIMFCGHICCA(string LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x21EF2B0", Offset = "0x21EE6B0", VA = "0x1821EF2B0")]
	[CompilerGenerated]
	private bool NHOBCJJMIEM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x21ED870", Offset = "0x21ECC70", VA = "0x1821ED870")]
	[CompilerGenerated]
	private bool GELPJKDIEFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x21ED030", Offset = "0x21EC430", VA = "0x1821ED030")]
	[CompilerGenerated]
	private int AOOIGFOPLNK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x21EF0C0", Offset = "0x21EE4C0", VA = "0x1821EF0C0")]
	[CompilerGenerated]
	private bool MBFGKLECBPD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x21EF150", Offset = "0x21EE550", VA = "0x1821EF150")]
	[CompilerGenerated]
	private void MDBPCBIHPHM(string LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x21EF370", Offset = "0x21EE770", VA = "0x1821EF370")]
	[CompilerGenerated]
	private bool OPOLODKKIKH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x21EE650", Offset = "0x21EDA50", VA = "0x1821EE650")]
	[CompilerGenerated]
	private bool KJGANNMMFCK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x21ED520", Offset = "0x21EC920", VA = "0x1821ED520")]
	[CompilerGenerated]
	private bool DFMJGDIPLNE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x21ED030", Offset = "0x21EC430", VA = "0x1821ED030")]
	[CompilerGenerated]
	private int LKOHEMAFHGA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x21ED6A0", Offset = "0x21ECAA0", VA = "0x1821ED6A0")]
	[CompilerGenerated]
	private bool EDNDCPDHHPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x21EF040", Offset = "0x21EE440", VA = "0x1821EF040")]
	[CompilerGenerated]
	private object LMNJEPNPOCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x21ECFB0", Offset = "0x21EC3B0", VA = "0x1821ECFB0")]
	[CompilerGenerated]
	private void ABLCEDFDENK(object LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x21EE580", Offset = "0x21ED980", VA = "0x1821EE580")]
	[CompilerGenerated]
	private bool KBNGAAPDEOL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class NMCMMCIPCIO
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class EKIIFCLJPND : OGCBACNHCAJ<LGEBFEMJBFF>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override PECPIHLAAHC FJLKHDIPCLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x912E20", Offset = "0x912220", VA = "0x180912E20", Slot = "126")]
			get
			{
				return default(PECPIHLAAHC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x21E9B10", Offset = "0x21E8F10", VA = "0x1821E9B10")]
		public EKIIFCLJPND(NPOGACBNNEB DAAJPDFKLAI, LGEBFEMJBFF GDIPKBJJCBL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class ICJILCJJADB : NHHGMDNJAKI<JONAIKDFNMO>
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x21EC420", Offset = "0x21EB820", VA = "0x1821EC420")]
		public ICJILCJJADB(NPOGACBNNEB DAAJPDFKLAI, JONAIKDFNMO ABBPLCKDHFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x21EC2A0", Offset = "0x21EB6A0", VA = "0x1821EC2A0", Slot = "120")]
		protected override void PDMCCHBHFON(MBBLDDIEAEG APEEJDAEHKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x21EC130", Offset = "0x21EB530", VA = "0x1821EC130")]
		[CompilerGenerated]
		private bool CBICCIEKFBB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x21EC180", Offset = "0x21EB580", VA = "0x1821EC180")]
		[CompilerGenerated]
		private void GPFABFJBICE(bool LIHHDPOHLDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class AABPIPFDIKE : NHHGMDNJAKI<NGPFDOJCEAF>
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class OGEIAOKDGEC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public KAKEIEJNCPC nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public AABPIPFDIKE <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public OGEIAOKDGEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x21F7AC0", Offset = "0x21F6EC0", VA = "0x1821F7AC0")]
			internal void OCLFICMCOOJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x21F7A20", Offset = "0x21F6E20", VA = "0x1821F7A20")]
			internal bool GGPDEMIPGLG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x21F78B0", Offset = "0x21F6CB0", VA = "0x1821F78B0")]
			internal bool EMCEBNLMHAL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x21F7900", Offset = "0x21F6D00", VA = "0x1821F7900")]
			internal void FMDJPOMAPHE(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x21F7A70", Offset = "0x21F6E70", VA = "0x1821F7A70")]
			internal bool IPDFEJDPFOD()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x21DBA60", Offset = "0x21DAE60", VA = "0x1821DBA60")]
		public AABPIPFDIKE(NPOGACBNNEB DAAJPDFKLAI, NGPFDOJCEAF ABBPLCKDHFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x21DB720", Offset = "0x21DAB20", VA = "0x1821DB720", Slot = "120")]
		protected override void PDMCCHBHFON(MBBLDDIEAEG APEEJDAEHKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class DFKFKLLBFIP : NHHGMDNJAKI<ALFGAIKCAEH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class IDIKOKGPKBG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public KAKEIEJNCPC nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public DFKFKLLBFIP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public IDIKOKGPKBG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x21EC9E0", Offset = "0x21EBDE0", VA = "0x1821EC9E0")]
			internal object OCLFICMCOOJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x21EC960", Offset = "0x21EBD60", VA = "0x1821EC960")]
			internal bool JDGBEEGIBAC(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x21EC650", Offset = "0x21EBA50", VA = "0x1821EC650")]
			internal void GGPDEMIPGLG(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x21EC490", Offset = "0x21EB890", VA = "0x1821EC490")]
			internal string EMCEBNLMHAL(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x21EC600", Offset = "0x21EBA00", VA = "0x1821EC600")]
			internal IReadOnlyList<object> FMDJPOMAPHE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x21EC8F0", Offset = "0x21EBCF0", VA = "0x1821EC8F0")]
			internal bool IPDFEJDPFOD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x21EC8A0", Offset = "0x21EBCA0", VA = "0x1821EC8A0")]
			internal bool HAAOOOMJLBG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x21ECAE0", Offset = "0x21EBEE0", VA = "0x1821ECAE0")]
			internal void PCHFLDODIJH(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x21E9750", Offset = "0x21E8B50", VA = "0x1821E9750")]
		public DFKFKLLBFIP(NPOGACBNNEB DAAJPDFKLAI, ALFGAIKCAEH ABBPLCKDHFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x21E9000", Offset = "0x21E8400", VA = "0x1821E9000", Slot = "120")]
		protected override void PDMCCHBHFON(MBBLDDIEAEG APEEJDAEHKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class FJBMLJCOGNP : NHHGMDNJAKI<DHNMBADGJKM>
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class NPNLIDLFBMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public FJBMLJCOGNP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public KAKEIEJNCPC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public NPNLIDLFBMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x21F5C90", Offset = "0x21F5090", VA = "0x1821F5C90")]
			internal bool OCLFICMCOOJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x21F5B70", Offset = "0x21F4F70", VA = "0x1821F5B70")]
			internal void GGPDEMIPGLG(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x21F5B20", Offset = "0x21F4F20", VA = "0x1821F5B20")]
			internal bool EMCEBNLMHAL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x21E9DB0", Offset = "0x21E91B0", VA = "0x1821E9DB0")]
		public FJBMLJCOGNP(NPOGACBNNEB DAAJPDFKLAI, DHNMBADGJKM ABBPLCKDHFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x21E9B80", Offset = "0x21E8F80", VA = "0x1821E9B80", Slot = "120")]
		protected override void PDMCCHBHFON(MBBLDDIEAEG APEEJDAEHKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public abstract class GLHCFODNBCH<TNode> : NHHGMDNJAKI<TNode> where TNode : notnull, KICMJLBCKIP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct INNMLDDFJCF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public AsyncTaskMethodBuilder<MLIDCCDLMIE<FGLBFCBPBCD<NPNHBKKDMLD>, FNDOAGAGANG>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public GLHCFODNBCH<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private TaskAwaiter<MLIDCCDLMIE<FGLBFCBPBCD<NPNHBKKDMLD>, FNDOAGAGANG>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x4216730", Offset = "0x4215B30", VA = "0x184216730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x4216B30", Offset = "0x4215F30", VA = "0x184216B30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct KEOPJHDDLMB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public AsyncTaskMethodBuilder<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public GLHCFODNBCH<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public FGLBFCBPBCD<NPNHBKKDMLD> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private TaskAwaiter<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x452B210", Offset = "0x452A610", VA = "0x18452B210", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x452B610", Offset = "0x452AA10", VA = "0x18452B610", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public sealed override bool JOGLBLJELNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override FGLBFCBPBCD<NPNHBKKDMLD>? DMMDNINOMJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x4015660", Offset = "0x4014A60", VA = "0x184015660", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4015610", Offset = "0x4014A10", VA = "0x184015610")]
		protected GLHCFODNBCH(NPOGACBNNEB DAAJPDFKLAI, TNode ABBPLCKDHFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x40154F0", Offset = "0x40148F0", VA = "0x1840154F0", Slot = "100")]
		[AsyncStateMachine(typeof(GLHCFODNBCH<>.INNMLDDFJCF))]
		public override Task<MLIDCCDLMIE<FGLBFCBPBCD<NPNHBKKDMLD>, FNDOAGAGANG>> NDPPFJKIFEM(string ADANIHOIEKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4015200", Offset = "0x4014600", VA = "0x184015200", Slot = "124")]
		public sealed override bool COMLMJGDNHN(FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4015340", Offset = "0x4014740", VA = "0x184015340", Slot = "112")]
		protected sealed override bool GLLIPAEBILI(FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x40152A0", Offset = "0x40146A0", VA = "0x1840152A0", Slot = "113")]
		protected override bool FIIOOLIIDCC(FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x40153E0", Offset = "0x40147E0", VA = "0x1840153E0", Slot = "101")]
		[AsyncStateMachine(typeof(GLHCFODNBCH<>.KEOPJHDDLMB))]
		public override Task<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> KEAKELGGELP(FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class CHDBKODFPHB : PDCHOHKGFGJ<OJHHCKOKGNN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class LINAGHALMHP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public CHDBKODFPHB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public KAKEIEJNCPC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public LINAGHALMHP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x21F13F0", Offset = "0x21F07F0", VA = "0x1821F13F0")]
			internal bool OMEHKCBHFOI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x21F1330", Offset = "0x21F0730", VA = "0x1821F1330")]
			internal void KJBKFGLLEJL(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x21E8C50", Offset = "0x21E8050", VA = "0x1821E8C50")]
		public CHDBKODFPHB(NPOGACBNNEB DAAJPDFKLAI, OJHHCKOKGNN GDIPKBJJCBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x21E8A00", Offset = "0x21E7E00", VA = "0x1821E8A00", Slot = "126")]
		protected override void LBKMCFDLEAK(MBBLDDIEAEG APEEJDAEHKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class MBNIMHLBADF : OMEKNCLAIHF<FCODNKNDANO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override NodeVisualizationKey NDKJAMPIIHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x9178F0", Offset = "0x916CF0", VA = "0x1809178F0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x21F1470", Offset = "0x21F0870", VA = "0x1821F1470")]
		public MBNIMHLBADF(NPOGACBNNEB DAAJPDFKLAI, FCODNKNDANO ABBPLCKDHFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public abstract class OMEKNCLAIHF<TNode> : NHHGMDNJAKI<TNode> where TNode : notnull, HLNKKNILKCL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct GJEAPOHLLPE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public AsyncTaskMethodBuilder<MLIDCCDLMIE<FGLBFCBPBCD<NPNHBKKDMLD>, FNDOAGAGANG>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public OMEKNCLAIHF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			private TaskAwaiter<MLIDCCDLMIE<FGLBFCBPBCD<NPNHBKKDMLD>, FNDOAGAGANG>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x3FF73A0", Offset = "0x3FF67A0", VA = "0x183FF73A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x3FF7850", Offset = "0x3FF6C50", VA = "0x183FF7850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct AOMBFOALMHH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public AsyncTaskMethodBuilder<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public OMEKNCLAIHF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public FGLBFCBPBCD<NPNHBKKDMLD> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private TaskAwaiter<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x412C600", Offset = "0x412BA00", VA = "0x18412C600", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x412CA10", Offset = "0x412BE10", VA = "0x18412CA10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct CJIKAOIBNEC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public AsyncTaskMethodBuilder<MLIDCCDLMIE<KCOOFONOLPB, FNDOAGAGANG>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public OMEKNCLAIHF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private TaskAwaiter<MLIDCCDLMIE<KCOOFONOLPB, FNDOAGAGANG>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x5324F30", Offset = "0x5324330", VA = "0x185324F30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x5325600", Offset = "0x5324A00", VA = "0x185325600", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private sealed class NIPEPGJLIFG
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
				public NIPEPGJLIFG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0x387FC70", Offset = "0x387F070", VA = "0x18387FC70", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000150")]
				[Cpp2IlInjected.Address(RVA = "0x954FC0", Offset = "0x9543C0", VA = "0x180954FC0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public MBBLDDIEAEG configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public KAKEIEJNCPC nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public OMEKNCLAIHF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public Func<string, bool> <>9__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public Action <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public NIPEPGJLIFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x48C0DD0", Offset = "0x48C01D0", VA = "0x1848C0DD0")]
			internal bool PCHFLDODIJH(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x48C0AE0", Offset = "0x48BFEE0", VA = "0x1848C0AE0")]
			internal void OCLFICMCOOJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x48C0A40", Offset = "0x48BFE40", VA = "0x1848C0A40")]
			[AsyncStateMachine(typeof(OMEKNCLAIHF<>.NIPEPGJLIFG.<<BuildConfigMenuInternal>b__7>d))]
			internal void JDGBEEGIBAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x48C0630", Offset = "0x48BFA30", VA = "0x1848C0630")]
			internal bool GGPDEMIPGLG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class KGAPIIKDAGA
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
				public KGAPIIKDAGA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				private TaskAwaiter<TaskStatus> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000156")]
				[Cpp2IlInjected.Address(RVA = "0x387F8F0", Offset = "0x387ECF0", VA = "0x18387F8F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000157")]
				[Cpp2IlInjected.Address(RVA = "0x954FC0", Offset = "0x9543C0", VA = "0x180954FC0", Slot = "5")]
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
			public NIPEPGJLIFG CS$<>8__locals1;

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
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public KGAPIIKDAGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x4538580", Offset = "0x4537980", VA = "0x184538580")]
			internal void EMCEBNLMHAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00")]
			internal string FMDJPOMAPHE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F20", Offset = "0x8A9320", VA = "0x1808A9F20")]
			internal void IPDFEJDPFOD(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x45389A0", Offset = "0x4537DA0", VA = "0x1845389A0")]
			[AsyncStateMachine(typeof(OMEKNCLAIHF<>.KGAPIIKDAGA.<<BuildConfigMenuInternal>b__5>d))]
			internal void HAAOOOMJLBG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class CDPEOKIDMOJ
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
				public CDPEOKIDMOJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016B")]
				[Cpp2IlInjected.Address(RVA = "0x387F420", Offset = "0x387E820", VA = "0x18387F420", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0x954FC0", Offset = "0x9543C0", VA = "0x180954FC0", Slot = "5")]
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
				public CDPEOKIDMOJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010C")]
				private TaskAwaiter<MLIDCCDLMIE<FGLBFCBPBCD<EEBKBHCGBCM>, FNDOAGAGANG>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0x387F600", Offset = "0x387EA00", VA = "0x18387F600", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0x954FC0", Offset = "0x9543C0", VA = "0x180954FC0", Slot = "5")]
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
				public CDPEOKIDMOJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				private TaskAwaiter<MLIDCCDLMIE<FGLBFCBPBCD<NLOPGHOEPOD>, FNDOAGAGANG>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0x387ED50", Offset = "0x387E150", VA = "0x18387ED50", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0x954FC0", Offset = "0x9543C0", VA = "0x180954FC0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public OMEKNCLAIHF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public FGLBFCBPBCD<NPNHBKKDMLD> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public MBBLDDIEAEG configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public KAKEIEJNCPC nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public PDOBKPANMAN nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public int minGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public int maxGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public MHMKOPIHJHJ selectedInputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public string newInputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public List<DIFBDDCNADD> inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public MHMKOPIHJHJ selectedOutputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public string newOutputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public List<DIFBDDCNADD> outputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public Func<string, bool> <>9__17;

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public CDPEOKIDMOJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x5309230", Offset = "0x5308630", VA = "0x185309230")]
			internal bool GLNKMIHHGME()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x5309770", Offset = "0x5308B70", VA = "0x185309770")]
			internal void PPIMMEOFNPC(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x53090B0", Offset = "0x53084B0", VA = "0x1853090B0")]
			internal bool FBHGIKHHDJP(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x5309650", Offset = "0x5308A50", VA = "0x185309650")]
			internal bool KLBDEJPLKDD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x5309190", Offset = "0x5308590", VA = "0x185309190")]
			[AsyncStateMachine(typeof(OMEKNCLAIHF<>.CDPEOKIDMOJ.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void FEBEAMFCDHD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x5308EC0", Offset = "0x53082C0", VA = "0x185308EC0")]
			internal bool AOAPFDNPEFD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x53092A0", Offset = "0x53086A0", VA = "0x1853092A0")]
			internal void HCAGEKOMDNP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x53095A0", Offset = "0x53089A0", VA = "0x1853095A0")]
			internal bool JCBPIFFEJMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x53093D0", Offset = "0x53087D0", VA = "0x1853093D0")]
			internal void IBINLJDIKAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x5308F60", Offset = "0x5308360", VA = "0x185308F60")]
			internal bool DDOBIHAHEJH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x5309700", Offset = "0x5308B00", VA = "0x185309700")]
			internal bool ONNOBCBGJIB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x5309690", Offset = "0x5308A90", VA = "0x185309690")]
			internal void NGBMOGOFPAI(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x5309500", Offset = "0x5308900", VA = "0x185309500")]
			[AsyncStateMachine(typeof(OMEKNCLAIHF<>.CDPEOKIDMOJ.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void ILHFMNLFDKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x5308E60", Offset = "0x5308260", VA = "0x185308E60")]
			internal bool AHAMEJHLGMI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x5309360", Offset = "0x5308760", VA = "0x185309360")]
			internal bool HLJOIHPNAFN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x5309490", Offset = "0x5308890", VA = "0x185309490")]
			internal void IEHEHDOPIAM(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x5309010", Offset = "0x5308410", VA = "0x185309010")]
			[AsyncStateMachine(typeof(OMEKNCLAIHF<>.CDPEOKIDMOJ.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void EILEOODBPLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x5308F00", Offset = "0x5308300", VA = "0x185308F00")]
			internal bool CLJLBEDGLIF()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class CFIBLKCCGNA
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
				public CFIBLKCCGNA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				private TaskAwaiter<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000176")]
				[Cpp2IlInjected.Address(RVA = "0x387F040", Offset = "0x387E440", VA = "0x18387F040", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000177")]
				[Cpp2IlInjected.Address(RVA = "0x954FC0", Offset = "0x9543C0", VA = "0x180954FC0", Slot = "5")]
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
			public CDPEOKIDMOJ CS$<>8__locals1;

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
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public CFIBLKCCGNA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x53126D0", Offset = "0x5311AD0", VA = "0x1853126D0")]
			internal void AHHAAOKEMPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00")]
			internal string CECPPOFFMGL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F20", Offset = "0x8A9320", VA = "0x1808A9F20")]
			internal void BJEGBBKFGEM(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x5312630", Offset = "0x5311A30", VA = "0x185312630")]
			[AsyncStateMachine(typeof(OMEKNCLAIHF<>.CFIBLKCCGNA.<<AddDynamicNodeGroupSettingV2>b__16>d))]
			internal void ABNABDNDFIP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		[CompilerGenerated]
		private sealed class IGFHGNIMKFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public PDOBKPANMAN nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public List<DIFBDDCNADD> portMenu;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public OMEKNCLAIHF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public FGLBFCBPBCD<NPNHBKKDMLD> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public int portCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public Func<bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public IGFHGNIMKFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x41E4650", Offset = "0x41E3A50", VA = "0x1841E4650")]
			internal bool GLABEBPEHEG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private sealed class NBEPJOCOEIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public ABLAJBADJIF port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public IGFHGNIMKFG CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public NBEPJOCOEIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x48918A0", Offset = "0x4890CA0", VA = "0x1848918A0")]
			internal void ILFKKALPPAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x4891730", Offset = "0x4890B30", VA = "0x184891730")]
			internal bool ANMLAFOIIBM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x4891780", Offset = "0x4890B80", VA = "0x184891780")]
			internal void GMGAGHLNDCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x48919B0", Offset = "0x4890DB0", VA = "0x1848919B0")]
			internal bool PDHEBPGOOAE()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private sealed class JDOCGAMAOHA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public DIFBDDCNADD portControls;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public NBEPJOCOEIG CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public JDOCGAMAOHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x441BC00", Offset = "0x441B000", VA = "0x18441BC00")]
			internal void CMIJGMKIONG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class LKDOLEBJKHK
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
				public LKDOLEBJKHK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000130")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000131")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				private TaskAwaiter<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000187")]
				[Cpp2IlInjected.Address(RVA = "0x38810E0", Offset = "0x38804E0", VA = "0x1838810E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000188")]
				[Cpp2IlInjected.Address(RVA = "0x954FC0", Offset = "0x9543C0", VA = "0x180954FC0", Slot = "5")]
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
			public MHMKOPIHJHJ selectedType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public PDOBKPANMAN nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public ABLAJBADJIF port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public KAKEIEJNCPC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public LKDOLEBJKHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x46137A0", Offset = "0x4612BA0", VA = "0x1846137A0")]
			internal int CEEMDAELBMI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x4613980", Offset = "0x4612D80", VA = "0x184613980")]
			internal void LEKDLBPPHHE(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F50", Offset = "0x8A9350", VA = "0x1808A9F50")]
			internal string LENLAGPKKNM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x46138C0", Offset = "0x4612CC0", VA = "0x1846138C0")]
			[AsyncStateMachine(typeof(OMEKNCLAIHF<>.LKDOLEBJKHK.<<CreatePortItemV2>b__3>d))]
			internal void EIIHIPIGHGO(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x46137E0", Offset = "0x4612BE0", VA = "0x1846137E0")]
			internal bool CFOPIDMOCBI(string text)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly Dictionary<FGLBFCBPBCD<NPNHBKKDMLD>, bool> HDHMOLPBKBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly Dictionary<FGLBFCBPBCD<NPNHBKKDMLD>, bool> KALFHMPPBII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private readonly Dictionary<FGLBFCBPBCD<NPNHBKKDMLD>, bool> HAPCDNOPCOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Dictionary<FGLBFCBPBCD<NPNHBKKDMLD>, bool> CMGHHNALHOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private Dictionary<FGLBFCBPBCD<NPNHBKKDMLD>, bool> FOFHIHFFEMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private Dictionary<FGLBFCBPBCD<NPNHBKKDMLD>, bool> APMIAENFGIE;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool PIFAEHHDIIL
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected virtual bool ODGBAOFDBOB
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "126")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected virtual bool LHFFDEPLAHI
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "127")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected virtual bool JPMJPAKEGME
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "128")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override FGLBFCBPBCD<PKMIDGFKCAI>? MDDCJIDECKE
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x4AAFF50", Offset = "0x4AAF350", VA = "0x184AAFF50", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override FGLBFCBPBCD<NPNHBKKDMLD>? DMMDNINOMJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x4AB0220", Offset = "0x4AAF620", VA = "0x184AB0220", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override IEnumerable<JABLMADMPHA<EPJMFNGLNNN>>? PCEMIJDFCFD
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x4AB0010", Offset = "0x4AAF410", VA = "0x184AB0010", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x4AAFD30", Offset = "0x4AAF130", VA = "0x184AAFD30")]
		public OMEKNCLAIHF(NPOGACBNNEB DAAJPDFKLAI, TNode ABBPLCKDHFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "129")]
		protected virtual bool LGEEHKMLPIL(int HGLJPBJCFNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "130")]
		protected virtual bool DMDABHHCOPF(int HGLJPBJCFNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "131")]
		protected virtual bool LADKFHFKAPA(int HGLJPBJCFNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "132")]
		protected virtual void LEAELHFIEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x4AAB4F0", Offset = "0x4AAA8F0", VA = "0x184AAB4F0", Slot = "124")]
		public override bool COMLMJGDNHN(FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4AACFC0", Offset = "0x4AAC3C0", VA = "0x184AACFC0", Slot = "100")]
		[AsyncStateMachine(typeof(OMEKNCLAIHF<>.GJEAPOHLLPE))]
		public override Task<MLIDCCDLMIE<FGLBFCBPBCD<NPNHBKKDMLD>, FNDOAGAGANG>> NDPPFJKIFEM(string ADANIHOIEKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x4AACA20", Offset = "0x4AABE20", VA = "0x184AACA20", Slot = "101")]
		[AsyncStateMachine(typeof(OMEKNCLAIHF<>.AOMBFOALMHH))]
		public override Task<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> KEAKELGGELP(FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x4AACDB0", Offset = "0x4AAC1B0", VA = "0x184AACDB0", Slot = "102")]
		public override void MLFNEKLPDFO(FGLBFCBPBCD<NPNHBKKDMLD> AEAHMAMPNLO, FGLBFCBPBCD<NPNHBKKDMLD> ANHPPPBDANF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x4AACB30", Offset = "0x4AABF30", VA = "0x184AACB30", Slot = "103")]
		public override IEnumerable<MMPFCBBACAJ> KEAMPCLMJON()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x4AADA40", Offset = "0x4AACE40", VA = "0x184AADA40")]
		[AsyncStateMachine(typeof(OMEKNCLAIHF<>.CJIKAOIBNEC))]
		private Task<MLIDCCDLMIE<KCOOFONOLPB, FNDOAGAGANG>> NPNHJHEBIBK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "133")]
		protected virtual bool LLAEFHHINNL(FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "134")]
		protected virtual bool IOPFHNEJBNK(FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "135")]
		protected virtual bool GPGJNEDDHHF(FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "136")]
		protected virtual bool JPPPHDPEGEF(FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "137")]
		protected virtual bool AMMAEBKPPND(FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI, int HPGCECFLNLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "138")]
		protected virtual bool DBBDALONIEC(FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI, int HPGCECFLNLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "139")]
		protected virtual bool AMCIHAHFBCA(FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI, int EDLGFHADDOP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "140")]
		protected virtual bool DLPOIGPOBOD(FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI, int EDLGFHADDOP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "141")]
		protected virtual bool MKJKFLMFAMM(FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI, int MMFIDABOADB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "142")]
		protected virtual bool MDOGGEIFNFF(FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI, int HLBMMAHCHAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x4AAB630", Offset = "0x4AAAA30", VA = "0x184AAB630", Slot = "143")]
		protected virtual List<MHMKOPIHJHJ> IMPEFMBFJPG(FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "144")]
		protected virtual void GAPENMFDFIM(MBBLDDIEAEG APEEJDAEHKG, MBHOFJKNMCF JODLICMMDJD, PDOBKPANMAN BCABOCPHOGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x4AAF2C0", Offset = "0x4AAE6C0", VA = "0x184AAF2C0", Slot = "120")]
		protected override void PDMCCHBHFON(MBBLDDIEAEG APEEJDAEHKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x4AADB40", Offset = "0x4AACF40", VA = "0x184AADB40")]
		private MBHOFJKNMCF PCCNCHJGFEJ(MBBLDDIEAEG APEEJDAEHKG, PDOBKPANMAN BCABOCPHOGJ, FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x4AAB8D0", Offset = "0x4AAACD0", VA = "0x184AAB8D0")]
		private List<DIFBDDCNADD> JLEGNEOBBFL(MBBLDDIEAEG APEEJDAEHKG, PDOBKPANMAN BCABOCPHOGJ, MBHOFJKNMCF JEJGAOHOEPL, bool IINLMHKCFCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x4AAD0E0", Offset = "0x4AAC4E0", VA = "0x184AAD0E0")]
		private List<DIFBDDCNADD> NOHIOANOECM(MBBLDDIEAEG APEEJDAEHKG, PDOBKPANMAN BCABOCPHOGJ, ABLAJBADJIF MPICFOLCBBC, bool IINLMHKCFCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x4AAB300", Offset = "0x4AAA700", VA = "0x184AAB300")]
		private MHMKOPIHJHJ CHDKFCDDIEF(List<MHMKOPIHJHJ> ICCDFBFEGFH, ABLAJBADJIF MPICFOLCBBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x4AAB590", Offset = "0x4AAA990", VA = "0x184AAB590")]
		[CompilerGenerated]
		private MMPFCBBACAJ EHAMCPACFDF(JMGKFHAJOAG INBIGDGMENB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public sealed class OIIGKEPHAPE : NHHGMDNJAKI<KILCHAKAAJL>
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class JFOJKOJLBCB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public OIIGKEPHAPE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public KAKEIEJNCPC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public JFOJKOJLBCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x21F0300", Offset = "0x21EF700", VA = "0x1821F0300")]
			internal int OCLFICMCOOJ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x21F0270", Offset = "0x21EF670", VA = "0x1821F0270")]
			internal void GGPDEMIPGLG(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NodeVisualizationKey NDKJAMPIIHN
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF60", Offset = "0xBBD360", VA = "0x180BBDF60", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x21F7CD0", Offset = "0x21F70D0", VA = "0x1821F7CD0")]
		public OIIGKEPHAPE(NPOGACBNNEB DAAJPDFKLAI, KILCHAKAAJL ABBPLCKDHFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x21F7B10", Offset = "0x21F6F10", VA = "0x1821F7B10", Slot = "120")]
		protected override void PDMCCHBHFON(MBBLDDIEAEG APEEJDAEHKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public sealed class KHCGHBFILBC : PDCHOHKGFGJ<LIEFNAMKHAG>
	{
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class MOMAEKLILLO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public KHCGHBFILBC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public KAKEIEJNCPC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public MOMAEKLILLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x21F3FD0", Offset = "0x21F33D0", VA = "0x1821F3FD0")]
			internal int OMEHKCBHFOI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x21F3F30", Offset = "0x21F3330", VA = "0x1821F3F30")]
			internal void KJBKFGLLEJL(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x21F0DF0", Offset = "0x21F01F0", VA = "0x1821F0DF0")]
		public KHCGHBFILBC(NPOGACBNNEB DAAJPDFKLAI, LIEFNAMKHAG GDIPKBJJCBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x21F0BB0", Offset = "0x21EFFB0", VA = "0x1821F0BB0", Slot = "126")]
		protected override void LBKMCFDLEAK(MBBLDDIEAEG APEEJDAEHKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private sealed class MLADPBEDHAO : NHHGMDNJAKI<DLDENANGLMK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey NDKJAMPIIHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x928400", Offset = "0x927800", VA = "0x180928400", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x21F2010", Offset = "0x21F1410", VA = "0x1821F2010")]
		public MLADPBEDHAO(NPOGACBNNEB DAAJPDFKLAI, DLDENANGLMK ABBPLCKDHFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "120")]
		protected override void PDMCCHBHFON(MBBLDDIEAEG APEEJDAEHKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class MNPNLCBMCBB : NHHGMDNJAKI<PKEHKNCDGOE>
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class ACGMACLKBGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public MNPNLCBMCBB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public MBBLDDIEAEG configure;

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
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public ACGMACLKBGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x21E5F00", Offset = "0x21E5300", VA = "0x1821E5F00")]
			internal bool OCLFICMCOOJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x21DD8C0", Offset = "0x21DCCC0", VA = "0x1821DD8C0")]
			internal void GGPDEMIPGLG(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x21E4380", Offset = "0x21E3780", VA = "0x1821E4380")]
			internal bool IPDFEJDPFOD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x21DD9C0", Offset = "0x21DCDC0", VA = "0x1821DD9C0")]
			internal bool HAAOOOMJLBG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x21E63A0", Offset = "0x21E57A0", VA = "0x1821E63A0")]
			internal void PCHFLDODIJH(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x21E55F0", Offset = "0x21E49F0", VA = "0x1821E55F0")]
			internal bool MKFNKMAKMAO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x21DC7B0", Offset = "0x21DBBB0", VA = "0x1821DC7B0")]
			internal bool CGOBKLLFAIH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x21E6050", Offset = "0x21E5450", VA = "0x1821E6050")]
			internal void OFBHEDMCGOO(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x21E5240", Offset = "0x21E4640", VA = "0x1821E5240")]
			internal bool LNDPPIJHBKF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x21DDC00", Offset = "0x21DD000", VA = "0x1821DDC00")]
			internal bool HIBPOECNAIB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x21DCA10", Offset = "0x21DBE10", VA = "0x1821DCA10")]
			internal void CKPPBHANEDG(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x21E53D0", Offset = "0x21E47D0", VA = "0x1821E53D0")]
			internal bool MFJCNHHCFNF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x21DC8C0", Offset = "0x21DBCC0", VA = "0x1821DC8C0")]
			internal bool CHOONMCAADK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x21DC200", Offset = "0x21DB600", VA = "0x1821DC200")]
			internal bool BCNPGBAMNAI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x21DD310", Offset = "0x21DC710", VA = "0x1821DD310")]
			internal bool FDLEEAGGKLC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x21DCD00", Offset = "0x21DC100", VA = "0x1821DCD00")]
			internal bool DKMDGHLPOIK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x21E6000", Offset = "0x21E5400", VA = "0x1821E6000")]
			internal bool OEPDJINEGHN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x21E5290", Offset = "0x21E4690", VA = "0x1821E5290")]
			internal bool MAFFJALKFOP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x21E5D00", Offset = "0x21E5100", VA = "0x1821E5D00")]
			internal bool NIDCFCHMLEH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x21DDB10", Offset = "0x21DCF10", VA = "0x1821DDB10")]
			internal bool HCDAJLMNLDH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x21DD660", Offset = "0x21DCA60", VA = "0x1821DD660")]
			internal void GBADGKEGPKL(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x21E60B0", Offset = "0x21E54B0", VA = "0x1821E60B0")]
			internal bool OGFOHJDPOHL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x21E6350", Offset = "0x21E5750", VA = "0x1821E6350")]
			internal bool PAHLPEILJKH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x21E4B80", Offset = "0x21E3F80", VA = "0x1821E4B80")]
			internal bool LBCAKMEKDKC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x21E5E10", Offset = "0x21E5210", VA = "0x1821E5E10")]
			internal bool NKAGAEMADCN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x21DD210", Offset = "0x21DC610", VA = "0x1821DD210")]
			internal bool FAAEAOHKINN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x21DBEF0", Offset = "0x21DB2F0", VA = "0x1821DBEF0")]
			internal bool AFPBIKGDOCF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x21E3E20", Offset = "0x21E3220", VA = "0x1821E3E20")]
			internal bool HNOPABAHBGN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x21DC540", Offset = "0x21DB940", VA = "0x1821DC540")]
			internal bool CBGJKFOEOLC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x21E5BE0", Offset = "0x21E4FE0", VA = "0x1821E5BE0")]
			internal void NHAOFMDEJPE(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x21DD5C0", Offset = "0x21DC9C0", VA = "0x1821DD5C0")]
			internal bool FPFLEMEBPLE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x21DBD40", Offset = "0x21DB140", VA = "0x1821DBD40")]
			internal bool ACDOCBAFJBK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x21DD140", Offset = "0x21DC540", VA = "0x1821DD140")]
			internal void EMOANLBOMCA(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x21E4480", Offset = "0x21E3880", VA = "0x1821E4480")]
			internal bool JEGCLBMCHLK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x21E4570", Offset = "0x21E3970", VA = "0x1821E4570")]
			internal bool JIMBCDKINNO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x21E4420", Offset = "0x21E3820", VA = "0x1821E4420")]
			internal void JCNFHEKGGFG(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x21DDD40", Offset = "0x21DD140", VA = "0x1821DDD40")]
			internal List<DIFBDDCNADD> HLHHCLCPAOC(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x21DCD50", Offset = "0x21DC150", VA = "0x1821DCD50")]
			internal bool DLLBBCDJMJE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x21DD3B0", Offset = "0x21DC7B0", VA = "0x1821DD3B0")]
			internal int FFJGFPCCFJI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x21DC750", Offset = "0x21DBB50", VA = "0x1821DC750")]
			internal void CGBDEAHAEGG(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x21E5530", Offset = "0x21E4930", VA = "0x1821E5530")]
			internal bool MHOLABNBMJM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x21E5150", Offset = "0x21E4550", VA = "0x1821E5150")]
			internal bool LLBOLKOELHB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x21DC340", Offset = "0x21DB740", VA = "0x1821DC340")]
			internal bool BFNGOIMNEEK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x21DC450", Offset = "0x21DB850", VA = "0x1821DC450")]
			internal int BJKIELBDIGP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x21DDA60", Offset = "0x21DCE60", VA = "0x1821DDA60")]
			internal void HBAEAGBCGGL(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x21E5640", Offset = "0x21E4A40", VA = "0x1821E5640")]
			internal bool MMEGIHOOIFJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x21DC2F0", Offset = "0x21DB6F0", VA = "0x1821DC2F0")]
			internal bool BFAGDBEMGJN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x21E5D50", Offset = "0x21E5150", VA = "0x1821E5D50")]
			internal bool NILPPPAEFNH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x21E6740", Offset = "0x21E5B40", VA = "0x1821E6740")]
			internal bool PMPFCCDANIO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x21DBC00", Offset = "0x21DB000", VA = "0x1821DBC00")]
			internal bool AAHELOABCCB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x21E5330", Offset = "0x21E4730", VA = "0x1821E5330")]
			internal bool MDFACMLODEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x21E5EB0", Offset = "0x21E52B0", VA = "0x1821E5EB0")]
			internal string OCAALHGNPAB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x21DCBF0", Offset = "0x21DBFF0", VA = "0x1821DCBF0")]
			internal void DGFMAEOPDIC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x21E46C0", Offset = "0x21E3AC0", VA = "0x1821E46C0")]
			internal int JLIGPLPKANK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x21DC910", Offset = "0x21DBD10", VA = "0x1821DC910")]
			internal void CINPMFNNDKI(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x21DBCF0", Offset = "0x21DB0F0", VA = "0x1821DBCF0")]
			internal bool ACCLGGBPHBD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x21E65E0", Offset = "0x21E59E0", VA = "0x1821E65E0")]
			internal bool PJJAMPBOLEE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x21DBCA0", Offset = "0x21DB0A0", VA = "0x1821DBCA0")]
			internal bool ABMPPJCGFFJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x21E4760", Offset = "0x21E3B60", VA = "0x1821E4760")]
			internal float JMMPCOILDKP()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x21E41E0", Offset = "0x21E35E0", VA = "0x1821E41E0")]
			internal void INENCCJNEPG(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x21E4620", Offset = "0x21E3A20", VA = "0x1821E4620")]
			internal bool JKFEDGNDMCD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x21E52E0", Offset = "0x21E46E0", VA = "0x1821E52E0")]
			internal bool MBCGMLNEPAF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x21DC250", Offset = "0x21DB650", VA = "0x1821DC250")]
			internal bool BDGPMJGOPOE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x21E6400", Offset = "0x21E5800", VA = "0x1821E6400")]
			internal bool PDODKLPGFEI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x21DD780", Offset = "0x21DCB80", VA = "0x1821DD780")]
			internal bool GFCEBFCCBDJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x21E4C70", Offset = "0x21E4070", VA = "0x1821E4C70")]
			internal bool LDEHJJLECBB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x21E5790", Offset = "0x21E4B90", VA = "0x1821E5790")]
			internal void MPHDKEAHICB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x21E62B0", Offset = "0x21E56B0", VA = "0x1821E62B0")]
			internal string OOFLMCCFDLO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x21E5030", Offset = "0x21E4430", VA = "0x1821E5030")]
			internal void LIILMKAOFDO(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x21E4C20", Offset = "0x21E4020", VA = "0x1821E4C20")]
			internal bool LDAPGIDLFBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x21E5B90", Offset = "0x21E4F90", VA = "0x1821E5B90")]
			internal bool NFGLIOPHDDM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x21E6100", Offset = "0x21E5500", VA = "0x1821E6100")]
			internal bool OIOPDOAMDLH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x21E4CC0", Offset = "0x21E40C0", VA = "0x1821E4CC0")]
			internal void LEHPDIDHMFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x21E44D0", Offset = "0x21E38D0", VA = "0x1821E44D0")]
			internal bool JFBAMIJPOBP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x21DD820", Offset = "0x21DCC20", VA = "0x1821DD820")]
			internal bool GFFHOLMDDGI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x21E51F0", Offset = "0x21E45F0", VA = "0x1821E51F0")]
			internal bool LMAOAOKEONO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x21E5F50", Offset = "0x21E5350", VA = "0x1821E5F50")]
			internal bool OEFODIKOJOG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x21DD2B0", Offset = "0x21DC6B0", VA = "0x1821DD2B0")]
			internal void FCOKDEAHMAJ(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x21DCDF0", Offset = "0x21DC1F0", VA = "0x1821DCDF0")]
			internal bool DPNBKOKNAMO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x21E42E0", Offset = "0x21E36E0", VA = "0x1821E42E0")]
			internal bool IOEEFKDLAGI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x21DBC50", Offset = "0x21DB050", VA = "0x1821DBC50")]
			internal bool ABGIEDGKNPK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x21DBEA0", Offset = "0x21DB2A0", VA = "0x1821DBEA0")]
			internal bool AFMKGAHGKLH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x21E5730", Offset = "0x21E4B30", VA = "0x1821E5730")]
			internal void MOLDKGKENCI(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x21DCEF0", Offset = "0x21DC2F0", VA = "0x1821DCEF0")]
			internal bool EGANOIEDLCI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x21E4330", Offset = "0x21E3730", VA = "0x1821E4330")]
			internal bool IOOCMLPDPKK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x21E4860", Offset = "0x21E3C60", VA = "0x1821E4860")]
			internal bool KCIHAIFIPOD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x21E3FC0", Offset = "0x21E33C0", VA = "0x1821E3FC0")]
			internal bool IGBKJFLOAPL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x21E6630", Offset = "0x21E5A30", VA = "0x1821E6630")]
			internal object PJJBJOIEAOD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x21DC120", Offset = "0x21DB520", VA = "0x1821DC120")]
			internal void ANDJFKGPCKA(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x21DD0A0", Offset = "0x21DC4A0", VA = "0x1821DD0A0")]
			internal bool EIMAALMDFJK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x21DC4A0", Offset = "0x21DB8A0", VA = "0x1821DC4A0")]
			internal bool BLLCCKMCHID()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x21DDC50", Offset = "0x21DD050", VA = "0x1821DDC50")]
			internal int HICJNBAKBDD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x21E4800", Offset = "0x21E3C00", VA = "0x1821E4800")]
			internal void KBACEMOFKJM(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x21E4900", Offset = "0x21E3D00", VA = "0x1821E4900")]
			internal bool KGLHJCOEKOC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x21DDBB0", Offset = "0x21DCFB0", VA = "0x1821DDBB0")]
			internal bool HGGIFPAEPBA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x21E56E0", Offset = "0x21E4AE0", VA = "0x1821E56E0")]
			internal int MMNDGCMMBEG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x21E4FD0", Offset = "0x21E43D0", VA = "0x1821E4FD0")]
			internal void LGNCICLKDOK(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x21E6790", Offset = "0x21E5B90", VA = "0x1821E6790")]
			internal bool PNFKFJGAOFE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x21E47B0", Offset = "0x21E3BB0", VA = "0x1821E47B0")]
			internal bool JODBOOPANEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x21DBD90", Offset = "0x21DB190", VA = "0x1821DBD90")]
			internal bool ADMBOLHFPEH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x21DBFE0", Offset = "0x21DB3E0", VA = "0x1821DBFE0")]
			internal int AICKCJEADJH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x21E5FA0", Offset = "0x21E53A0", VA = "0x1821E5FA0")]
			internal void OENJJFEJNIK(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x21E64F0", Offset = "0x21E58F0", VA = "0x1821E64F0")]
			internal bool PFIMBFMEBEO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x21DD050", Offset = "0x21DC450", VA = "0x1821DD050")]
			internal bool EIKMLBABAHO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x21E49A0", Offset = "0x21E3DA0", VA = "0x1821E49A0")]
			internal bool KJFKNINGHCF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x21DD6C0", Offset = "0x21DCAC0", VA = "0x1821DD6C0")]
			internal object GBGBFHHBLED()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x21E40B0", Offset = "0x21E34B0", VA = "0x1821E40B0")]
			internal void IJKLEPODAEC(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x21E6540", Offset = "0x21E5940", VA = "0x1821E6540")]
			internal bool PHNBJOHNPCG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x21E4290", Offset = "0x21E3690", VA = "0x1821E4290")]
			internal bool IOBOKHDLHDI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x21DC630", Offset = "0x21DBA30", VA = "0x1821DC630")]
			internal object CEMANKGNHNB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x21DBB20", Offset = "0x21DAF20", VA = "0x1821DBB20")]
			internal void AAEBPHJGACC(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x21DD0F0", Offset = "0x21DC4F0", VA = "0x1821DD0F0")]
			internal bool ELCAAABPBCK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x21DC870", Offset = "0x21DBC70", VA = "0x1821DC870")]
			internal int CHKCBEAEPNN()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x21E50A0", Offset = "0x21E44A0", VA = "0x1821E50A0")]
			internal void LIMOGBHJINL(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x21E49F0", Offset = "0x21E3DF0", VA = "0x1821E49F0")]
			internal bool KLCNHDLFOPO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x21E64A0", Offset = "0x21E58A0", VA = "0x1821E64A0")]
			internal bool PFHLHOJLNDM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x21DC9C0", Offset = "0x21DBDC0", VA = "0x1821DC9C0")]
			internal bool CKOEKGMKCGC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x21DD7D0", Offset = "0x21DCBD0", VA = "0x1821DD7D0")]
			internal int GFCHLLHNNPJ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x21DC6A0", Offset = "0x21DBAA0", VA = "0x1821DC6A0")]
			internal void CFJIBGOCJID(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x21DCE40", Offset = "0x21DC240", VA = "0x1821DCE40")]
			internal bool EABEONLDNON()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x21E3ED0", Offset = "0x21E32D0", VA = "0x1821E3ED0")]
			internal bool IDDFIABEJHC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x21DC970", Offset = "0x21DBD70", VA = "0x1821DC970")]
			internal bool CJAOMLMPAGM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x21E5C40", Offset = "0x21E5040", VA = "0x1821E5C40")]
			internal float NHFGCCAOGPK()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x21DD4A0", Offset = "0x21DC8A0", VA = "0x1821DD4A0")]
			internal void FIDHBHGBLJP(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x21E4A90", Offset = "0x21E3E90", VA = "0x1821E4A90")]
			internal bool KMPIIJIPAMA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x21DCB50", Offset = "0x21DBF50", VA = "0x1821DCB50")]
			internal bool DBHKECNGNHK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x21E5E60", Offset = "0x21E5260", VA = "0x1821E5E60")]
			internal bool OAONHFOBNPC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x21E43D0", Offset = "0x21E37D0", VA = "0x1821E43D0")]
			internal float JBOEMFIDNEB()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x21E45C0", Offset = "0x21E39C0", VA = "0x1821E45C0")]
			internal void JIMBKGBPLMB(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x21DCF40", Offset = "0x21DC340", VA = "0x1821DCF40")]
			internal bool EGKCNFDAIDP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x21E61F0", Offset = "0x21E55F0", VA = "0x1821E61F0")]
			internal bool OMGLPMLCDIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x21DC590", Offset = "0x21DB990", VA = "0x1821DC590")]
			internal string CCIOBEBNIOC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x21DC800", Offset = "0x21DBC00", VA = "0x1821DC800")]
			internal void CHDMLMIGEMH(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x21E4060", Offset = "0x21E3460", VA = "0x1821E4060")]
			internal bool IHJPMAJKDKO(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x21DD000", Offset = "0x21DC400", VA = "0x1821DD000")]
			internal bool EIKJGPCFEDC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x21E6150", Offset = "0x21E5550", VA = "0x1821E6150")]
			internal bool OJDMDIOIADH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x21DD870", Offset = "0x21DCC70", VA = "0x1821DD870")]
			internal bool GFIIBPPNOJE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x21DC5E0", Offset = "0x21DB9E0", VA = "0x1821DC5E0")]
			internal string CELLIILLILP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x21DC3E0", Offset = "0x21DB7E0", VA = "0x1821DC3E0")]
			internal void BIMBCJEMMHJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x21E3DD0", Offset = "0x21E31D0", VA = "0x1821E3DD0")]
			internal bool HMOHJHKDBIA(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x21DD400", Offset = "0x21DC800", VA = "0x1821DD400")]
			internal bool FGNFPHLHBDH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x21DCCB0", Offset = "0x21DC0B0", VA = "0x1821DCCB0")]
			internal bool DIFELABOJDK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x21E6590", Offset = "0x21E5990", VA = "0x1821E6590")]
			internal bool PJADAMBAIAP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x21E51A0", Offset = "0x21E45A0", VA = "0x1821E51A0")]
			internal string LLKLFFFJBDN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x21E5470", Offset = "0x21E4870", VA = "0x1821E5470")]
			internal void MGBGCPIANKD(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x21DC4F0", Offset = "0x21DB8F0", VA = "0x1821DC4F0")]
			internal bool BNIEMEPGMEL(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x21E4B30", Offset = "0x21E3F30", VA = "0x1821E4B30")]
			internal bool LAIJGPOEBKM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x21DD970", Offset = "0x21DCD70", VA = "0x1821DD970")]
			internal bool GJJONAMPAHK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x21E4240", Offset = "0x21E3640", VA = "0x1821E4240")]
			internal bool IOBLCGDNHHL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x21DBDE0", Offset = "0x21DB1E0", VA = "0x1821DBDE0")]
			internal string AEIIELIAODN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x21E6240", Offset = "0x21E5640", VA = "0x1821E6240")]
			internal void OMMNDHFIHHF(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x21DCDA0", Offset = "0x21DC1A0", VA = "0x1821DCDA0")]
			internal bool DPLJGJPHPFE(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x21DDCA0", Offset = "0x21DD0A0", VA = "0x1821DDCA0")]
			internal bool HKMPKKJKGII()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x21E4AE0", Offset = "0x21E3EE0", VA = "0x1821E4AE0")]
			internal bool KNLFAHAIAGE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x21E66F0", Offset = "0x21E5AF0", VA = "0x1821E66F0")]
			internal bool PMLLBIAIOGO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x21DC700", Offset = "0x21DBB00", VA = "0x1821DC700")]
			internal string CFKKEGOANEH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x21DCF90", Offset = "0x21DC390", VA = "0x1821DCF90")]
			internal void EIEJMABMBPH(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x21E6300", Offset = "0x21E5700", VA = "0x1821E6300")]
			internal bool OPHONHDOIHB(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x21E4010", Offset = "0x21E3410", VA = "0x1821E4010")]
			internal bool IGMPCAMFHJL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x21E66A0", Offset = "0x21E5AA0", VA = "0x1821E66A0")]
			internal bool PLNJPABPICD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x21E3F20", Offset = "0x21E3320", VA = "0x1821E3F20")]
			internal bool IEDLHKFEDKC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x21DC390", Offset = "0x21DB790", VA = "0x1821DC390")]
			internal string BFONKGAGGAC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x21E5DA0", Offset = "0x21E51A0", VA = "0x1821E5DA0")]
			internal void NINGEAJIAIO(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x21E4670", Offset = "0x21E3A70", VA = "0x1821E4670")]
			internal bool JKPDGAHBOKJ(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x21E4520", Offset = "0x21E3920", VA = "0x1821E4520")]
			internal bool JGKHNIPNILJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x21DD450", Offset = "0x21DC850", VA = "0x1821DD450")]
			internal bool FHGMNIINPCG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x21DC030", Offset = "0x21DB430", VA = "0x1821DC030")]
			internal bool AJDADPDDHMN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x21DBAD0", Offset = "0x21DAED0", VA = "0x1821DBAD0")]
			internal string AACPLKDBBIJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x21E5C90", Offset = "0x21E5090", VA = "0x1821E5C90")]
			internal void NICKCMKPNOP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x21DCBA0", Offset = "0x21DBFA0", VA = "0x1821DCBA0")]
			internal bool DDLADGBPIJP(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x21DC1B0", Offset = "0x21DB5B0", VA = "0x1821DC1B0")]
			internal bool AODLJDCDJCN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x21E67E0", Offset = "0x21E5BE0", VA = "0x1821E67E0")]
			internal bool PNMHDDMLLHG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x21E54E0", Offset = "0x21E48E0", VA = "0x1821E54E0")]
			internal bool MHFBJOFKBBD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x21DCC60", Offset = "0x21DC060", VA = "0x1821DCC60")]
			internal string DHHDBGFGMPL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x21DD1A0", Offset = "0x21DC5A0", VA = "0x1821DD1A0")]
			internal void EPANDBPOKNH(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x21DC0D0", Offset = "0x21DB4D0", VA = "0x1821DC0D0")]
			internal bool AMOOIIIJGEG(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x21E4F80", Offset = "0x21E4380", VA = "0x1821E4F80")]
			internal bool LGLODACEEHG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x21E5100", Offset = "0x21E4500", VA = "0x1821E5100")]
			internal bool LINMFGPJMKF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x21DBF40", Offset = "0x21DB340", VA = "0x1821DBF40")]
			internal bool AGPGLMLNIEI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x21DD260", Offset = "0x21DC660", VA = "0x1821DD260")]
			internal string FCBLOBAPABI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x21DD550", Offset = "0x21DC950", VA = "0x1821DD550")]
			internal void FJICPDOLBGF(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x21DC080", Offset = "0x21DB480", VA = "0x1821DC080")]
			internal bool ALKAOOEKFCN(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x21E4A40", Offset = "0x21E3E40", VA = "0x1821E4A40")]
			internal bool KMLKNINAEEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x21DD360", Offset = "0x21DC760", VA = "0x1821DD360")]
			internal bool FECDKECLKEH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x21E4BD0", Offset = "0x21E3FD0", VA = "0x1821E4BD0")]
			internal bool LCNLEILBAJJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x21E4190", Offset = "0x21E3590", VA = "0x1821E4190")]
			internal string IMLHBIJHHKI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x21DBE30", Offset = "0x21DB230", VA = "0x1821DBE30")]
			internal void AFHOGOINCBH(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x21E5420", Offset = "0x21E4820", VA = "0x1821E5420")]
			internal bool MFMGOKDJCKH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x21DD730", Offset = "0x21DCB30", VA = "0x1821DD730")]
			internal bool GCEIHKLFANE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x21E3F70", Offset = "0x21E3370", VA = "0x1821E3F70")]
			internal bool IEPFINMGDBP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x21E4710", Offset = "0x21E3B10", VA = "0x1821E4710")]
			internal string JMDFODHADEC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x21E5580", Offset = "0x21E4980", VA = "0x1821E5580")]
			internal void MIAGAMHDAMP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x21DDAC0", Offset = "0x21DCEC0", VA = "0x1821DDAC0")]
			internal bool HCBBILEDLBH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x21E48B0", Offset = "0x21E3CB0", VA = "0x1821E48B0")]
			internal bool KEDHPKEEOLE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x21DDB60", Offset = "0x21DCF60", VA = "0x1821DDB60")]
			internal bool HDGAKMHPCAG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x21DBF90", Offset = "0x21DB390", VA = "0x1821DBF90")]
			internal string AHHHLKJKCKP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x21DCA70", Offset = "0x21DBE70", VA = "0x1821DCA70")]
			internal void COIJOPCOMOH(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x21DDA10", Offset = "0x21DCE10", VA = "0x1821DDA10")]
			internal bool HANMICGHKME()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x21DD610", Offset = "0x21DCA10", VA = "0x1821DD610")]
			internal bool FPIANIJEECM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x21E4950", Offset = "0x21E3D50", VA = "0x1821E4950")]
			internal bool KHEOBNBMOJI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x21DC2A0", Offset = "0x21DB6A0", VA = "0x1821DC2A0")]
			internal string BEEOPNLADAG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x21DCAE0", Offset = "0x21DBEE0", VA = "0x1821DCAE0")]
			internal void CPJJOEGBODG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x21DDCF0", Offset = "0x21DD0F0", VA = "0x1821DDCF0")]
			internal bool HKNABIFLMCF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x21DD920", Offset = "0x21DCD20", VA = "0x1821DD920")]
			internal bool GHDCOBJCHIP(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x21E5690", Offset = "0x21E4A90", VA = "0x1821E5690")]
			internal float MMJBOBBNFEB()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x21DCE90", Offset = "0x21DC290", VA = "0x1821DCE90")]
			internal void ECLCIANHNOK(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x21DBBB0", Offset = "0x21DAFB0", VA = "0x1821DBBB0")]
			internal bool AAFDHAGIJMD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x21E5380", Offset = "0x21E4780", VA = "0x1821E5380")]
			internal bool MDMNNMCOOOF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x21E5B40", Offset = "0x21E4F40", VA = "0x1821E5B40")]
			internal bool MPHJDOBBJEF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x21DD500", Offset = "0x21DC900", VA = "0x1821DD500")]
			internal int FIKIFBBEBAM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x21E3E70", Offset = "0x21E3270", VA = "0x1821E3E70")]
			internal void HPMEBFKACBI(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x21E6450", Offset = "0x21E5850", VA = "0x1821E6450")]
			internal bool PEJIIHONJDE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x21E4140", Offset = "0x21E3540", VA = "0x1821E4140")]
			internal bool IKLKIHHGOFL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x21E61A0", Offset = "0x21E55A0", VA = "0x1821E61A0")]
			internal bool OKCLBFLJCIG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class MIGJBKBMMCD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public ACGMACLKBGP CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public MIGJBKBMMCD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x21F14D0", Offset = "0x21F08D0", VA = "0x1821F14D0")]
			internal void BEHGFHIEGCA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class OEKIAGMBNAC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public OEKIAGMBNAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x21F7830", Offset = "0x21F6C30", VA = "0x1821F7830")]
			internal bool GPOCBEJDHME(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly AAAIEMIAKCM OFBIEDINOKI;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x21F3DD0", Offset = "0x21F31D0", VA = "0x1821F3DD0")]
		public MNPNLCBMCBB(NPOGACBNNEB DAAJPDFKLAI, PKEHKNCDGOE ABBPLCKDHFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x21F2080", Offset = "0x21F1480", VA = "0x1821F2080", Slot = "120")]
		protected override void PDMCCHBHFON(MBBLDDIEAEG APEEJDAEHKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class MHEOFGJLMEK : NHHGMDNJAKI<KGOHKFPBBIP>
	{
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class DCBBOMDKGNP
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
				public DCBBOMDKGNP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				private TaskAwaiter<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002A5")]
				[Cpp2IlInjected.Address(RVA = "0x22151F0", Offset = "0x22145F0", VA = "0x1822151F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0x954FC0", Offset = "0x9543C0", VA = "0x180954FC0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public MHEOFGJLMEK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public KAKEIEJNCPC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public DCBBOMDKGNP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x21FCC50", Offset = "0x21FC050", VA = "0x1821FCC50")]
			internal string OCLFICMCOOJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x21FCB80", Offset = "0x21FBF80", VA = "0x1821FCB80")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void GGPDEMIPGLG(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x21FCAA0", Offset = "0x21FBEA0", VA = "0x1821FCAA0")]
			internal int EMCEBNLMHAL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x21FCAF0", Offset = "0x21FBEF0", VA = "0x1821FCAF0")]
			internal void FMDJPOMAPHE(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override NodeVisualizationKey NDKJAMPIIHN
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF60", Offset = "0xBBD360", VA = "0x180BBDF60", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x220C160", Offset = "0x220B560", VA = "0x18220C160")]
		public MHEOFGJLMEK(NPOGACBNNEB DAAJPDFKLAI, KGOHKFPBBIP GDIPKBJJCBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x220BE10", Offset = "0x220B210", VA = "0x18220BE10", Slot = "120")]
		protected override void PDMCCHBHFON(MBBLDDIEAEG APEEJDAEHKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public sealed class EKIPOFCAKGJ : NHHGMDNJAKI<AHFOAOAJHIH>
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private sealed class EELAHKDNIBM
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
				public EELAHKDNIBM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000180")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000181")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000182")]
				private TaskAwaiter<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BA")]
				[Cpp2IlInjected.Address(RVA = "0x2214EB0", Offset = "0x22142B0", VA = "0x182214EB0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BB")]
				[Cpp2IlInjected.Address(RVA = "0x954FC0", Offset = "0x9543C0", VA = "0x180954FC0", Slot = "5")]
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
				public EELAHKDNIBM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000188")]
				private TaskAwaiter<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x2215500", Offset = "0x2214900", VA = "0x182215500", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0x954FC0", Offset = "0x9543C0", VA = "0x180954FC0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public EKIPOFCAKGJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public KAKEIEJNCPC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public EELAHKDNIBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x21FDA40", Offset = "0x21FCE40", VA = "0x1821FDA40")]
			internal string OCLFICMCOOJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x21FD610", Offset = "0x21FCA10", VA = "0x1821FD610")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void GGPDEMIPGLG(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x21FD530", Offset = "0x21FC930", VA = "0x1821FD530")]
			internal int EMCEBNLMHAL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x21FD580", Offset = "0x21FC980", VA = "0x1821FD580")]
			internal void FMDJPOMAPHE(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x21FD7B0", Offset = "0x21FCBB0", VA = "0x1821FD7B0")]
			internal string IPDFEJDPFOD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x21FD6E0", Offset = "0x21FCAE0", VA = "0x1821FD6E0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void HAAOOOMJLBG(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x21FDB20", Offset = "0x21FCF20", VA = "0x1821FDB20")]
			internal bool PCHFLDODIJH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x21FD800", Offset = "0x21FCC00", VA = "0x1821FD800")]
			internal void JDGBEEGIBAC(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x21FD900", Offset = "0x21FCD00", VA = "0x1821FD900")]
			internal bool LOJCBJINBHF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x21FD9B0", Offset = "0x21FCDB0", VA = "0x1821FD9B0")]
			internal void MKFNKMAKMAO(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x21FD4E0", Offset = "0x21FC8E0", VA = "0x1821FD4E0")]
			internal float CGOBKLLFAIH()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x21FDA90", Offset = "0x21FCE90", VA = "0x1821FDA90")]
			internal void OFBHEDMCGOO(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x21FD950", Offset = "0x21FCD50", VA = "0x1821FD950")]
			internal int LPEMGJFHKJI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x21FD440", Offset = "0x21FC840", VA = "0x1821FD440")]
			internal void ADEMDKKCBFJ(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x21FD890", Offset = "0x21FCC90", VA = "0x1821FD890")]
			internal bool LNDPPIJHBKF()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey NDKJAMPIIHN
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF60", Offset = "0xBBD360", VA = "0x180BBDF60", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x21FE710", Offset = "0x21FDB10", VA = "0x1821FE710")]
		public EKIPOFCAKGJ(NPOGACBNNEB DAAJPDFKLAI, AHFOAOAJHIH ABBPLCKDHFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x21FDCC0", Offset = "0x21FD0C0", VA = "0x1821FDCC0", Slot = "120")]
		protected override void PDMCCHBHFON(MBBLDDIEAEG APEEJDAEHKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class HHPFMHLPIFP : NHHGMDNJAKI<GMAGIOCIPAO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class LJNIGNPLCID
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public KAKEIEJNCPC nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public HHPFMHLPIFP <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public LJNIGNPLCID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x220B7C0", Offset = "0x220ABC0", VA = "0x18220B7C0")]
			internal Dictionary<string, LDCIFMJMAPN> OCLFICMCOOJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x220B770", Offset = "0x220AB70", VA = "0x18220B770")]
			internal int GGPDEMIPGLG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x220B5D0", Offset = "0x220A9D0", VA = "0x18220B5D0")]
			internal void EMCEBNLMHAL(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x220B6F0", Offset = "0x220AAF0", VA = "0x18220B6F0")]
			internal bool FMDJPOMAPHE()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey NDKJAMPIIHN
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF60", Offset = "0xBBD360", VA = "0x180BBDF60", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x2201930", Offset = "0x2200D30", VA = "0x182201930")]
		public HHPFMHLPIFP(NPOGACBNNEB DAAJPDFKLAI, GMAGIOCIPAO GDIPKBJJCBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x2201660", Offset = "0x2200A60", VA = "0x182201660", Slot = "120")]
		protected override void PDMCCHBHFON(MBBLDDIEAEG APEEJDAEHKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class IAPHGDOLBPN : NHHGMDNJAKI<CCKAIIKPJBC>
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private sealed class OBBFHMBOCBO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public KAKEIEJNCPC nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public IAPHGDOLBPN <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public OBBFHMBOCBO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x2212FE0", Offset = "0x22123E0", VA = "0x182212FE0")]
			internal void OCLFICMCOOJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey NDKJAMPIIHN
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF60", Offset = "0xBBD360", VA = "0x180BBDF60", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x2201EE0", Offset = "0x22012E0", VA = "0x182201EE0")]
		public IAPHGDOLBPN(NPOGACBNNEB DAAJPDFKLAI, CCKAIIKPJBC GDIPKBJJCBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x2201D60", Offset = "0x2201160", VA = "0x182201D60", Slot = "120")]
		protected override void PDMCCHBHFON(MBBLDDIEAEG APEEJDAEHKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private sealed class IOBHBMBKOIC : OMEKNCLAIHF<NDHDAHGOKOE>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool BAOEDMNAECC
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override bool DCJDBGGEPIE
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x2202A20", Offset = "0x2201E20", VA = "0x182202A20", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override NodeVisualizationKey NDKJAMPIIHN
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x9171F0", Offset = "0x9165F0", VA = "0x1809171F0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x22029C0", Offset = "0x2201DC0", VA = "0x1822029C0")]
		public IOBHBMBKOIC(NPOGACBNNEB DAAJPDFKLAI, NDHDAHGOKOE ABBPLCKDHFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "120")]
		protected override void PDMCCHBHFON(MBBLDDIEAEG APEEJDAEHKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	private sealed class NNGEJMPHEFB : NHHGMDNJAKI<NMALDLNILCJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override NodeVisualizationKey NDKJAMPIIHN
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xB8C170", Offset = "0xB8B570", VA = "0x180B8C170", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x220CF40", Offset = "0x220C340", VA = "0x18220CF40")]
		public NNGEJMPHEFB(NPOGACBNNEB DAAJPDFKLAI, NMALDLNILCJ ABBPLCKDHFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "120")]
		protected override void PDMCCHBHFON(MBBLDDIEAEG APEEJDAEHKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class NJBBNPKEOAK : NHHGMDNJAKI<HLNCCLOGLPJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override NodeVisualizationKey NDKJAMPIIHN
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x916370", Offset = "0x915770", VA = "0x180916370", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x220C960", Offset = "0x220BD60", VA = "0x18220C960")]
		public NJBBNPKEOAK(NPOGACBNNEB DAAJPDFKLAI, HLNCCLOGLPJ ABBPLCKDHFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "112")]
		protected override bool GLLIPAEBILI(FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "120")]
		protected override void PDMCCHBHFON(MBBLDDIEAEG APEEJDAEHKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class DDEPMAMDHJB : NHHGMDNJAKI<PNGGDNMKNEK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override NodeVisualizationKey NDKJAMPIIHN
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x915820", Offset = "0x914C20", VA = "0x180915820", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool ONFJFCDEAGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x21FCD10", Offset = "0x21FC110", VA = "0x1821FCD10", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected override bool FOEILCPEHPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x21FCCA0", Offset = "0x21FC0A0", VA = "0x1821FCCA0")]
		public DDEPMAMDHJB(NPOGACBNNEB DAAJPDFKLAI, PNGGDNMKNEK ABBPLCKDHFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "120")]
		protected override void PDMCCHBHFON(MBBLDDIEAEG APEEJDAEHKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private sealed class NJFJCJBCHJM : NHHGMDNJAKI<COBDEMLFNKL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override NodeVisualizationKey NDKJAMPIIHN
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x912E20", Offset = "0x912220", VA = "0x180912E20", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override bool ONFJFCDEAGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x220CA40", Offset = "0x220BE40", VA = "0x18220CA40", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		protected override bool FOEILCPEHPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x220C9D0", Offset = "0x220BDD0", VA = "0x18220C9D0")]
		public NJFJCJBCHJM(NPOGACBNNEB DAAJPDFKLAI, COBDEMLFNKL ABBPLCKDHFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "120")]
		protected override void PDMCCHBHFON(MBBLDDIEAEG APEEJDAEHKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public sealed class HIOFLIKNLLE : PDCHOHKGFGJ<LEJKEHLAJFE>
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		[CompilerGenerated]
		private sealed class GLKHDNKDDEI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public HIOFLIKNLLE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public KAKEIEJNCPC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public GLKHDNKDDEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x2200E40", Offset = "0x2200240", VA = "0x182200E40")]
			internal float OMEHKCBHFOI()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x2200DA0", Offset = "0x22001A0", VA = "0x182200DA0")]
			internal void KJBKFGLLEJL(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x2201C20", Offset = "0x2201020", VA = "0x182201C20")]
		public HIOFLIKNLLE(NPOGACBNNEB DAAJPDFKLAI, LEJKEHLAJFE GDIPKBJJCBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x22019A0", Offset = "0x2200DA0", VA = "0x1822019A0", Slot = "126")]
		protected override void LBKMCFDLEAK(MBBLDDIEAEG APEEJDAEHKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public sealed class AHCKDOJHKBG : NHHGMDNJAKI<BLKAGIKCCHA>
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		[CompilerGenerated]
		private sealed class LCMKCAEMKEE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public AHCKDOJHKBG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public KAKEIEJNCPC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public LCMKCAEMKEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x2206040", Offset = "0x2205440", VA = "0x182206040")]
			internal bool OCLFICMCOOJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x2205F20", Offset = "0x2205320", VA = "0x182205F20")]
			internal void GGPDEMIPGLG(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x21FA1A0", Offset = "0x21F95A0", VA = "0x1821FA1A0")]
		public AHCKDOJHKBG(NPOGACBNNEB DAAJPDFKLAI, BLKAGIKCCHA GDIPKBJJCBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x21F9EF0", Offset = "0x21F92F0", VA = "0x1821F9EF0", Slot = "120")]
		protected override void PDMCCHBHFON(MBBLDDIEAEG APEEJDAEHKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public sealed class ALPHHOEFBCI : NHHGMDNJAKI<AABNMGEGKPJ>
	{
		[Cpp2IlInjected.Token(Token = "0x200007D")]
		[CompilerGenerated]
		private sealed class OJIOAHJNBNI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public KAKEIEJNCPC nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public ALPHHOEFBCI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public OJIOAHJNBNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x2213E60", Offset = "0x2213260", VA = "0x182213E60")]
			internal object OCLFICMCOOJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x2213DE0", Offset = "0x22131E0", VA = "0x182213DE0")]
			internal bool JDGBEEGIBAC(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x2213AD0", Offset = "0x2212ED0", VA = "0x182213AD0")]
			internal void GGPDEMIPGLG(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x2213910", Offset = "0x2212D10", VA = "0x182213910")]
			internal string EMCEBNLMHAL(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x2213A80", Offset = "0x2212E80", VA = "0x182213A80")]
			internal IReadOnlyList<object> FMDJPOMAPHE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x2213D70", Offset = "0x2213170", VA = "0x182213D70")]
			internal bool IPDFEJDPFOD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x2213D20", Offset = "0x2213120", VA = "0x182213D20")]
			internal bool HAAOOOMJLBG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x2213F90", Offset = "0x2213390", VA = "0x182213F90")]
			internal void PCHFLDODIJH(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x21FAEF0", Offset = "0x21FA2F0", VA = "0x1821FAEF0")]
		public ALPHHOEFBCI(NPOGACBNNEB DAAJPDFKLAI, AABNMGEGKPJ GDIPKBJJCBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x21FA6E0", Offset = "0x21F9AE0", VA = "0x1821FA6E0", Slot = "120")]
		protected override void PDMCCHBHFON(MBBLDDIEAEG APEEJDAEHKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public sealed class LDMPAIDDELO : GLHCFODNBCH<PIEPNOPMADA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override NodeVisualizationKey NDKJAMPIIHN
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x920740", Offset = "0x91FB40", VA = "0x180920740", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x2206490", Offset = "0x2205890", VA = "0x182206490")]
		public LDMPAIDDELO(NPOGACBNNEB DAAJPDFKLAI, PIEPNOPMADA ABBPLCKDHFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public sealed class PPONHLPMACG : PDCHOHKGFGJ<KJBABHKGGHM>
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class JDNGMLIPIEG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public PPONHLPMACG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public KAKEIEJNCPC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public JDNGMLIPIEG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x2202D50", Offset = "0x2202150", VA = "0x182202D50")]
			internal int OMEHKCBHFOI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x2202CB0", Offset = "0x22020B0", VA = "0x182202CB0")]
			internal void KJBKFGLLEJL(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x2214B40", Offset = "0x2213F40", VA = "0x182214B40")]
		public PPONHLPMACG(NPOGACBNNEB DAAJPDFKLAI, KJBABHKGGHM GDIPKBJJCBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x22148B0", Offset = "0x2213CB0", VA = "0x1822148B0", Slot = "126")]
		protected override void LBKMCFDLEAK(MBBLDDIEAEG APEEJDAEHKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public sealed class JCHMBIHONJP : NHHGMDNJAKI<LIBEJHNIPBA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		[CompilerGenerated]
		private sealed class HNCCHGEANEJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public JCHMBIHONJP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public KAKEIEJNCPC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public HNCCHGEANEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x2201D10", Offset = "0x2201110", VA = "0x182201D10")]
			internal bool OCLFICMCOOJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x2201C80", Offset = "0x2201080", VA = "0x182201C80")]
			internal void GGPDEMIPGLG(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x2202C40", Offset = "0x2202040", VA = "0x182202C40")]
		public JCHMBIHONJP(NPOGACBNNEB DAAJPDFKLAI, LIBEJHNIPBA GDIPKBJJCBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x2202A60", Offset = "0x2201E60", VA = "0x182202A60", Slot = "120")]
		protected override void PDMCCHBHFON(MBBLDDIEAEG APEEJDAEHKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class INHLEBJDHEB : NHHGMDNJAKI<EDMOEKGOMBE>
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		[CompilerGenerated]
		private sealed class EHPIFOLNFKJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public INHLEBJDHEB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public KAKEIEJNCPC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public EHPIFOLNFKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x21FDC00", Offset = "0x21FD000", VA = "0x1821FDC00")]
			internal bool OCLFICMCOOJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x21FDB70", Offset = "0x21FCF70", VA = "0x1821FDB70")]
			internal void GGPDEMIPGLG(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x2202950", Offset = "0x2201D50", VA = "0x182202950")]
		public INHLEBJDHEB(NPOGACBNNEB DAAJPDFKLAI, EDMOEKGOMBE GDIPKBJJCBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x2202770", Offset = "0x2201B70", VA = "0x182202770", Slot = "120")]
		protected override void PDMCCHBHFON(MBBLDDIEAEG APEEJDAEHKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class OHOGGOGLOAF : NHHGMDNJAKI<JCCOECGFCGG>
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		[CompilerGenerated]
		private sealed class FACDGHCOMFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public OHOGGOGLOAF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public KAKEIEJNCPC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public FACDGHCOMFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x21FEBD0", Offset = "0x21FDFD0", VA = "0x1821FEBD0")]
			internal int OCLFICMCOOJ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x21FEB40", Offset = "0x21FDF40", VA = "0x1821FEB40")]
			internal void GGPDEMIPGLG(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x22138A0", Offset = "0x2212CA0", VA = "0x1822138A0")]
		public OHOGGOGLOAF(NPOGACBNNEB DAAJPDFKLAI, JCCOECGFCGG GDIPKBJJCBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x2213630", Offset = "0x2212A30", VA = "0x182213630", Slot = "120")]
		protected override void PDMCCHBHFON(MBBLDDIEAEG APEEJDAEHKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class FGBILBLMJAO : OGCBACNHCAJ<FPOPKGEBLNJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override PECPIHLAAHC FJLKHDIPCLG
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x9178F0", Offset = "0x916CF0", VA = "0x1809178F0", Slot = "126")]
			get
			{
				return default(PECPIHLAAHC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x21FF0E0", Offset = "0x21FE4E0", VA = "0x1821FF0E0")]
		public FGBILBLMJAO(NPOGACBNNEB DAAJPDFKLAI, FPOPKGEBLNJ GDIPKBJJCBL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class EIHIKBOKHHF : NHHGMDNJAKI<JMGKFHAJOAG>
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x21FDC50", Offset = "0x21FD050", VA = "0x1821FDC50")]
		public EIHIKBOKHHF(NPOGACBNNEB DAAJPDFKLAI, JMGKFHAJOAG ABBPLCKDHFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public abstract class NHHGMDNJAKI<TNode> : PDOBBIKMPEL, IDisposable where TNode : notnull, JMGKFHAJOAG
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		[CompilerGenerated]
		private sealed class NNMHNOIDDPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public NHHGMDNJAKI<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			public NPOGACBNNEB circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public NNMHNOIDDPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x48E6700", Offset = "0x48E5B00", VA = "0x1848E6700")]
			internal OBAIIIHPPPB JDHFLKBFLGI(FFKLHNCOINB portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		[CompilerGenerated]
		private struct OPMDCGJNMBJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public NHHGMDNJAKI<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private TaskAwaiter<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x4AB7D40", Offset = "0x4AB7140", VA = "0x184AB7D40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x954FC0", Offset = "0x9543C0", VA = "0x180954FC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		[CompilerGenerated]
		private struct ABEGOCEBIBA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public AsyncTaskMethodBuilder<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public NHHGMDNJAKI<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public KHCNBIDLEAA? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public JKPFCNCELMN? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			private TaskAwaiter<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x3F85E80", Offset = "0x3F85280", VA = "0x183F85E80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x3F86130", Offset = "0x3F85530", VA = "0x183F86130", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008D")]
		[CompilerGenerated]
		private sealed class DJGCEMELODM
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
				public DJGCEMELODM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CB")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000396")]
				[Cpp2IlInjected.Address(RVA = "0x387FE80", Offset = "0x387F280", VA = "0x18387FE80", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000397")]
				[Cpp2IlInjected.Address(RVA = "0x954FC0", Offset = "0x9543C0", VA = "0x180954FC0", Slot = "5")]
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
			public KAKEIEJNCPC nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public NHHGMDNJAKI<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public MBBLDDIEAEG configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public DJGCEMELODM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00")]
			internal string MFCKMDFCNAA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F20", Offset = "0x8A9320", VA = "0x1808A9F20")]
			internal void IHKCNLCHCHO(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0x5C31D30", Offset = "0x5C31130", VA = "0x185C31D30")]
			[AsyncStateMachine(typeof(NHHGMDNJAKI<>.DJGCEMELODM.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void CMJEOPHABLM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		[CompilerGenerated]
		private sealed class MFBBPJOGFEI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public KAKEIEJNCPC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public MFBBPJOGFEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x4818980", Offset = "0x4817D80", VA = "0x184818980")]
			internal bool JCALFPOHJKN(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x4818970", Offset = "0x4817D70", VA = "0x184818970")]
			internal bool CCOBJKHJENG(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000090")]
		[CompilerGenerated]
		private struct KLNEPMHNHHH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public AsyncTaskMethodBuilder<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public NHHGMDNJAKI<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			private TaskAwaiter<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x454CDB0", Offset = "0x454C1B0", VA = "0x18454CDB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x454D140", Offset = "0x454C540", VA = "0x18454D140", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private readonly NPOGACBNNEB CIMEKGEELOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly bool LJIDCDEFMDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private OAPEIPDONBD<NPNHBKKDMLD, OBAIIIHPPPB> COFDJKHKOGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private OAPEIPDONBD<NPNHBKKDMLD, PDOBKPANMAN> DFMIBCKNHKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private List<Action> LAMHONJALJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[CompilerGenerated]
		private Action<FGLBFCBPBCD<NPNHBKKDMLD>>? GLMBDELALLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[CompilerGenerated]
		private Action<FGLBFCBPBCD<NPNHBKKDMLD>, PDOBKPANMAN>? OOEGLIHBFLO;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		protected DCDABDCPDPJ ADHLIGNFCFI
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x48B5770", Offset = "0x48B4B70", VA = "0x1848B5770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		protected KAKEIEJNCPC KMLHAHNOLPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x48B1810", Offset = "0x48B0C10", VA = "0x1848B1810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		protected TNode DAGDPOOPLGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x8AE500", Offset = "0x8AD900", VA = "0x1808AE500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public JABLMADMPHA<DJFIOODIFAG> OPBLOCHLCCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0xE3B400", Offset = "0xE3A800", VA = "0x180E3B400", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(JABLMADMPHA<DJFIOODIFAG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public FGLBFCBPBCD<JFDKOCAMBNN> PKOLOHIHFLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x48B71F0", Offset = "0x48B65F0", VA = "0x1848B71F0", Slot = "6")]
			get
			{
				return default(FGLBFCBPBCD<JFDKOCAMBNN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public object IGMKBIEEBFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x3BBD770", Offset = "0x3BBCB70", VA = "0x183BBD770", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public virtual bool EANGINJLAMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int LCIPJNBIBJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x48B6E20", Offset = "0x48B6220", VA = "0x1848B6E20", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public CBPMOKFJJOF BDNBNJCBBPN
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x48B6DC0", Offset = "0x48B61C0", VA = "0x1848B6DC0", Slot = "10")]
			get
			{
				return default(CBPMOKFJJOF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string NMJGFOFJGFI
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x48B73B0", Offset = "0x48B67B0", VA = "0x1848B73B0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		protected virtual bool FOEILCPEHPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual NodeVisualizationKey NDKJAMPIIHN
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public FGLBFCBPBCD<AEFNCAJJOKC> CGGGIGEFEBP
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x9BE9C0", Offset = "0x9BDDC0", VA = "0x1809BE9C0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(FGLBFCBPBCD<AEFNCAJJOKC>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x9BCEC0", Offset = "0x9BC2C0", VA = "0x1809BCEC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual bool ONFJFCDEAGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual bool BAOEDMNAECC
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual JCONHALMGAE DNCOHEKNFFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0xAB7EF0", Offset = "0xAB72F0", VA = "0x180AB7EF0", Slot = "94")]
			get
			{
				return default(JCONHALMGAE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool EIOPJBJAKLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x48B6AD0", Offset = "0x48B5ED0", VA = "0x1848B6AD0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool PIHJMMEDFKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x48B6B40", Offset = "0x48B5F40", VA = "0x1848B6B40", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool ECNJMECBOOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x48B6BB0", Offset = "0x48B5FB0", VA = "0x1848B6BB0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int MAHPHJLEDNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x48B7190", Offset = "0x48B6590", VA = "0x1848B7190", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool NKCHKACOKKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x48B6FB0", Offset = "0x48B63B0", VA = "0x1848B6FB0", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool AAECDIIJGCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x48B6CE0", Offset = "0x48B60E0", VA = "0x1848B6CE0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool PGJLHCAJMDO
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x48B6C70", Offset = "0x48B6070", VA = "0x1848B6C70", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool BOAIPLFANPI
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0xA9E7C0", Offset = "0xA9DBC0", VA = "0x180A9E7C0", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0xF79E40", Offset = "0xF79240", VA = "0x180F79E40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public virtual bool PJBKPAJCKEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual bool IHOLGIOPJJG
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x48B6C20", Offset = "0x48B6020", VA = "0x1848B6C20", Slot = "96")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool BIONPBLIGNF
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x48B6EE0", Offset = "0x48B62E0", VA = "0x1848B6EE0", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public KHCNBIDLEAA CBMADBKBACD
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x48B70D0", Offset = "0x48B64D0", VA = "0x1848B70D0", Slot = "28")]
			get
			{
				return default(KHCNBIDLEAA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public JKPFCNCELMN AOFACHKJMAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x48B7130", Offset = "0x48B6530", VA = "0x1848B7130", Slot = "30")]
			get
			{
				return default(JKPFCNCELMN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool BKKHIMDAHBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "108")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual MEANKMLMHHM? KHJADIONIFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "109")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual CAPGNAKOMGK? KNIJPNICCBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual IEnumerable<JABLMADMPHA<EPJMFNGLNNN>>? PCEMIJDFCFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool JJECPIPJICO
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x48B6D50", Offset = "0x48B6150", VA = "0x1848B6D50", Slot = "114")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public JABLMADMPHA<PKMIDGFKCAI> LJAAJGEIPPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x48B7010", Offset = "0x48B6410", VA = "0x1848B7010", Slot = "62")]
			get
			{
				return default(JABLMADMPHA<PKMIDGFKCAI>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public FGLBFCBPBCD<PKMIDGFKCAI> FLOEADHOMKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x48B6E80", Offset = "0x48B6280", VA = "0x1848B6E80", Slot = "56")]
			get
			{
				return default(FGLBFCBPBCD<PKMIDGFKCAI>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public virtual bool JOGLBLJELNO
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public virtual FGLBFCBPBCD<PKMIDGFKCAI>? MDDCJIDECKE
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public virtual bool DCJDBGGEPIE
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool POAIBNOMCBB
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x48B6F40", Offset = "0x48B6340", VA = "0x1848B6F40", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string BKJCNMKILGO
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x8AFB20", Offset = "0x8AEF20", VA = "0x1808AFB20", Slot = "64")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x8AFAA0", Offset = "0x8AEEA0", VA = "0x1808AFAA0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		private string LEODBGNMEIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x8AFC20", Offset = "0x8AF020", VA = "0x1808AFC20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public JABLMADMPHA<EPJMFNGLNNN> KCCAKHKEOLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x48B7070", Offset = "0x48B6470", VA = "0x1848B7070", Slot = "63")]
			get
			{
				return default(JABLMADMPHA<EPJMFNGLNNN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public JABLMADMPHA<EPJMFNGLNNN>? FOHAPPPALHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x48B7280", Offset = "0x48B6680", VA = "0x1848B7280", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public FCMFIIGFAIL<NPNHBKKDMLD, PDOBKPANMAN> AEBBPEELLJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x48B7370", Offset = "0x48B6770", VA = "0x1848B7370", Slot = "65")]
			get
			{
				return default(FCMFIIGFAIL<NPNHBKKDMLD, PDOBKPANMAN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public virtual FGLBFCBPBCD<NPNHBKKDMLD>? DMMDNINOMJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public virtual bool PIFAEHHDIIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public virtual bool MDBHMAOIJEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "123")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action PIFKBGCJPKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x48B4C90", Offset = "0x48B4090", VA = "0x1848B4C90", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x48B1B60", Offset = "0x48B0F60", VA = "0x1848B1B60", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event GAKDLPOPMCE BOGENOOOALF
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x48B2CA0", Offset = "0x48B20A0", VA = "0x1848B2CA0", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x48B3E50", Offset = "0x48B3250", VA = "0x1848B3E50", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event IKEDDCKENCC GDOCIKAAEJD
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x48B3EF0", Offset = "0x48B32F0", VA = "0x1848B3EF0", Slot = "41")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x48B2D40", Offset = "0x48B2140", VA = "0x1848B2D40", Slot = "42")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action KKFFDOHHKGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x48B48A0", Offset = "0x48B3CA0", VA = "0x1848B48A0", Slot = "43")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x48B1B00", Offset = "0x48B0F00", VA = "0x1848B1B00", Slot = "44")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action DNKAJGFEFHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x48B4090", Offset = "0x48B3490", VA = "0x1848B4090", Slot = "45")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x48B6430", Offset = "0x48B5830", VA = "0x1848B6430", Slot = "46")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<FGLBFCBPBCD<NPNHBKKDMLD>, PDOBKPANMAN> EKAMOOFJHMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x48B1DA0", Offset = "0x48B11A0", VA = "0x1848B1DA0", Slot = "67")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x48B55E0", Offset = "0x48B49E0", VA = "0x1848B55E0", Slot = "68")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<FGLBFCBPBCD<NPNHBKKDMLD>, PDOBKPANMAN> OGJKNLDMGDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x48B5810", Offset = "0x48B4C10", VA = "0x1848B5810", Slot = "71")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x48B5D60", Offset = "0x48B5160", VA = "0x1848B5D60", Slot = "72")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<FGLBFCBPBCD<NPNHBKKDMLD>> IHFLLLPNMKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x48B58D0", Offset = "0x48B4CD0", VA = "0x1848B58D0", Slot = "69")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x48B3690", Offset = "0x48B2A90", VA = "0x1848B3690", Slot = "70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<FGLBFCBPBCD<NPNHBKKDMLD>, FGLBFCBPBCD<NPNHBKKDMLD>> NNANOINGKMH
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x48B5460", Offset = "0x48B4860", VA = "0x1848B5460", Slot = "73")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x48B5520", Offset = "0x48B4920", VA = "0x1848B5520", Slot = "74")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<FGLBFCBPBCD<NPNHBKKDMLD>, PDOBKPANMAN> FHEKDBBPNPE
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x48B1C70", Offset = "0x48B1070", VA = "0x1848B1C70", Slot = "75")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x48B5F20", Offset = "0x48B5320", VA = "0x1848B5F20", Slot = "76")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<FGLBFCBPBCD<NPNHBKKDMLD>, FGLBFCBPBCD<NPNHBKKDMLD>> JBBAKLGLBFK
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x48B3F90", Offset = "0x48B3390", VA = "0x1848B3F90", Slot = "77")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x48B4BD0", Offset = "0x48B3FD0", VA = "0x1848B4BD0", Slot = "78")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x48B64D0", Offset = "0x48B58D0", VA = "0x1848B64D0")]
		[EAFJAFLMLNJ("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		[EAFJAFLMLNJ("Need to handle `Name` better.")]
		protected NHHGMDNJAKI(NPOGACBNNEB DAAJPDFKLAI, TNode ABBPLCKDHFH, bool NEDLMKCGKHP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x48B4130", Offset = "0x48B3530", VA = "0x1848B4130", Slot = "87")]
		protected virtual void JLABJFAHLGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x48B23C0", Offset = "0x48B17C0", VA = "0x1848B23C0", Slot = "88")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x48B4E60", Offset = "0x48B4260", VA = "0x1848B4E60", Slot = "9")]
		[AsyncStateMachine(typeof(NHHGMDNJAKI<>.OPMDCGJNMBJ))]
		public void KMLGMIKHGNO(int FKMMEMJOKEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x48B1C00", Offset = "0x48B1000", VA = "0x1848B1C00")]
		public bool BPOGLEJNODF([In] KHCNBIDLEAA LIHHDPOHLDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x48B3620", Offset = "0x48B2A20", VA = "0x1848B3620")]
		public bool GMILGPCBHMJ([In] JKPFCNCELMN LIHHDPOHLDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x48B33D0", Offset = "0x48B27D0", VA = "0x1848B33D0", Slot = "32")]
		public void GFELLKBFGNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x48B5260", Offset = "0x48B4660", VA = "0x1848B5260", Slot = "33")]
		[AsyncStateMachine(typeof(NHHGMDNJAKI<>.ABEGOCEBIBA))]
		public Task<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> LJDCKDFHHFI(KHCNBIDLEAA? MIPHEMMOPOK, JKPFCNCELMN? ECBCCENFGFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "97")]
		public virtual void OEDMFAGGHNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "98")]
		public virtual void NMNCPNLCKCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "99")]
		public virtual void PNEJAGHOLJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xA51FC0", Offset = "0xA513C0", VA = "0x180A51FC0")]
		protected void BKOANEKEOHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x97EC90", Offset = "0x97E090", VA = "0x18097EC90")]
		protected void GLDNBEFKMNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x23FF5E0", Offset = "0x23FE9E0", VA = "0x1823FF5E0")]
		private void IIJAGBJDEGI([In] JKPFCNCELMN EFFHGIJAIIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x48B56A0", Offset = "0x48B4AA0", VA = "0x1848B56A0", Slot = "100")]
		public virtual Task<MLIDCCDLMIE<FGLBFCBPBCD<NPNHBKKDMLD>, FNDOAGAGANG>> NDPPFJKIFEM(string ADANIHOIEKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x48B4A70", Offset = "0x48B3E70", VA = "0x1848B4A70", Slot = "101")]
		public virtual Task<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> KEAKELGGELP(FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "102")]
		public virtual void MLFNEKLPDFO(FGLBFCBPBCD<NPNHBKKDMLD> GBIIBHFFJNE, FGLBFCBPBCD<NPNHBKKDMLD> CDAPOPBCOBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x48B4B40", Offset = "0x48B3F40", VA = "0x1848B4B40", Slot = "103")]
		public virtual IEnumerable<MMPFCBBACAJ> KEAMPCLMJON()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x48B5E20", Offset = "0x48B5220", VA = "0x1848B5E20", Slot = "104")]
		public MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG> OJCDKHFDLPD(string DHBCNDNKDDN)
		{
			return default(MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x48B1E60", Offset = "0x48B1260", VA = "0x1848B1E60", Slot = "47")]
		public bool DMJBKNCKDAC([Out] Guid GPPBJGMMLPP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x48B2F40", Offset = "0x48B2340", VA = "0x1848B2F40")]
		public bool FLHHKLDEMMI([In] Guid DAOIPHJHGNI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "105")]
		public virtual void AEAEDDMNDLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "106")]
		public virtual void AKOHEOGFLIH(bool HJAIMCCMLCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "107")]
		public virtual CLMIAKJFNIJ DPPPAIEBAID([In] CMJHHGKALCE PEBDIJIEOHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x48B1900", Offset = "0x48B0D00", VA = "0x1848B1900")]
		protected void AJCAELJGKAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x48B35E0", Offset = "0x48B29E0", VA = "0x1848B35E0", Slot = "112")]
		protected virtual bool GLLIPAEBILI(FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "113")]
		protected virtual bool FIIOOLIIDCC(FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "120")]
		protected virtual void PDMCCHBHFON(MBBLDDIEAEG PCEPPBEJCDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x48B1FB0", Offset = "0x48B13B0", VA = "0x1848B1FB0")]
		protected void DPNLLMHODIB(MBBLDDIEAEG APEEJDAEHKG, Func<string> ELCJBDIMCIO, Action<string> DNPLAGBOKNA, string BFBMOMGGKIP, string LDENAJJFHCJ, string KJOFJGKCPAJ, OJPGICPEADM GOCMJPFDIBJ, FCAFFLFKBGE LDEEMOFBMHC, Func<string, bool> MOAKKBLHOMD, string HHDBLODNINK, Func<string, bool> KDKMJFMFCFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x48B4F10", Offset = "0x48B4310", VA = "0x1848B4F10")]
		protected void LAHAOBFHGEO(MBBLDDIEAEG APEEJDAEHKG, Func<string> ELCJBDIMCIO, Action<string> DNPLAGBOKNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x48B3C90", Offset = "0x48B3090", VA = "0x1848B3C90", Slot = "121")]
		protected virtual void HFIKKCBBGOO(MBBLDDIEAEG APEEJDAEHKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x48B5210", Offset = "0x48B4610", VA = "0x1848B5210", Slot = "80")]
		public void LIGDHENKIKD(MBBLDDIEAEG APEEJDAEHKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x48B4970", Offset = "0x48B3D70", VA = "0x1848B4970", Slot = "81")]
		public LGKLMGHGDKJ KDGJNLBJJOM()
		{
			return default(LGKLMGHGDKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "124")]
		public virtual bool COMLMJGDNHN(FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x18899F0", Offset = "0x1888DF0", VA = "0x1818899F0")]
		private void OJIKHEBDBJK([In] KHCNBIDLEAA MBJNFCDOKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x48B3270", Offset = "0x48B2670", VA = "0x1848B3270")]
		private void FNOCCMJKOBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x48B3750", Offset = "0x48B2B50", VA = "0x1848B3750")]
		private void HBHGDLNNEEH(FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI, FFKLHNCOINB FBDIFKCJCCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0xBA7A00", Offset = "0xBA6E00", VA = "0x180BA7A00")]
		private void HKHMAPFFGPO(FGLBFCBPBCD<NPNHBKKDMLD> IHELCOHOCAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x48B4D30", Offset = "0x48B4130", VA = "0x1848B4D30")]
		private void KMCGLMNJGJE(FGLBFCBPBCD<NPNHBKKDMLD> IHELCOHOCAM, FFKLHNCOINB LDKHNAPNPHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x48B5990", Offset = "0x48B4D90", VA = "0x1848B5990")]
		private void OCGEBDFNKNL(FGLBFCBPBCD<NPNHBKKDMLD> GBIIBHFFJNE, FGLBFCBPBCD<NPNHBKKDMLD> CDAPOPBCOBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xBA7A20", Offset = "0xBA6E20", VA = "0x180BA7A20")]
		private void GAAMNBABPAF(FGLBFCBPBCD<NPNHBKKDMLD> GBIIBHFFJNE, FGLBFCBPBCD<NPNHBKKDMLD> CDAPOPBCOBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x48B5D40", Offset = "0x48B5140", VA = "0x1848B5D40")]
		private void OEFAIIFHNNI(FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x48B5FE0", Offset = "0x48B53E0", VA = "0x1848B5FE0")]
		private void PFPHICPCDDA(FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI, FFKLHNCOINB FBDIFKCJCCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x48B3200", Offset = "0x48B2600", VA = "0x1848B3200")]
		private void FNKBGPJLMDF(FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI, FFKLHNCOINB LDKHNAPNPHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x48B2DE0", Offset = "0x48B21E0", VA = "0x1848B2DE0", Slot = "125")]
		[AsyncStateMachine(typeof(NHHGMDNJAKI<>.KLNEPMHNHHH))]
		public Task<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> EHCLKKPMJGO(string DHBCNDNKDDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x48B5EB0", Offset = "0x48B52B0", VA = "0x1848B5EB0", Slot = "54")]
		private void PBFJMIBHAJD(object DAKFMJAOOAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x48B1D30", Offset = "0x48B1130", VA = "0x1848B1D30", Slot = "55")]
		private void CLLGEBNBDCH(object DAKFMJAOOAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x48B57D0", Offset = "0x48B4BD0", VA = "0x1848B57D0", Slot = "29")]
		private bool NMCNMPFGPFB([In] KHCNBIDLEAA LIHHDPOHLDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x48B2F00", Offset = "0x48B2300", VA = "0x1848B2F00", Slot = "31")]
		private bool EPJDOIFKIAG([In] JKPFCNCELMN LIHHDPOHLDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x48B63F0", Offset = "0x48B57F0", VA = "0x1848B63F0", Slot = "48")]
		private bool PHHBHLNMDBG([In] Guid DAOIPHJHGNI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x48B4050", Offset = "0x48B3450", VA = "0x1848B4050")]
		[CompilerGenerated]
		private string IFKCNHGKPJG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x48B53B0", Offset = "0x48B47B0", VA = "0x1848B53B0")]
		[CompilerGenerated]
		private void MALKIFDHOBB(string ADANIHOIEKJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public sealed class IMNELFGJOMI : GLHCFODNBCH<JIPOEGAHKPF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public override NodeVisualizationKey NDKJAMPIIHN
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x91D080", Offset = "0x91C480", VA = "0x18091D080", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x2202710", Offset = "0x2201B10", VA = "0x182202710")]
		public IMNELFGJOMI(NPOGACBNNEB DAAJPDFKLAI, JIPOEGAHKPF ABBPLCKDHFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class OAPMLJBGHCL : OMEKNCLAIHF<GLPJJKCGIFN>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public override NodeVisualizationKey NDKJAMPIIHN
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x9178F0", Offset = "0x916CF0", VA = "0x1809178F0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x220CFB0", Offset = "0x220C3B0", VA = "0x18220CFB0")]
		public OAPMLJBGHCL(NPOGACBNNEB DAAJPDFKLAI, GLPJJKCGIFN ABBPLCKDHFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "120")]
		protected override void PDMCCHBHFON(MBBLDDIEAEG APEEJDAEHKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public abstract class OGCBACNHCAJ<T> : NHHGMDNJAKI<T> where T : notnull, JIFODNPEAHI
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class OBDMIOPJLCP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public IReadOnlyList<KeyValuePair<string, LDCIFMJMAPN>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public OGCBACNHCAJ<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public KAKEIEJNCPC nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public PECPIHLAAHC clipType;

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public OBDMIOPJLCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00")]
			internal IReadOnlyList<KeyValuePair<string, LDCIFMJMAPN>> OCLFICMCOOJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x4A53C70", Offset = "0x4A53070", VA = "0x184A53C70")]
			internal int GGPDEMIPGLG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x4A53A00", Offset = "0x4A52E00", VA = "0x184A53A00")]
			internal void EMCEBNLMHAL(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x4A53C20", Offset = "0x4A53020", VA = "0x184A53C20")]
			internal void FMDJPOMAPHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x4A53E60", Offset = "0x4A53260", VA = "0x184A53E60")]
			internal void IPDFEJDPFOD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x4A53DD0", Offset = "0x4A531D0", VA = "0x184A53DD0")]
			internal bool HAAOOOMJLBG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x4A541F0", Offset = "0x4A535F0", VA = "0x184A541F0")]
			internal void PCHFLDODIJH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x4A53DD0", Offset = "0x4A531D0", VA = "0x184A53DD0")]
			internal bool JDGBEEGIBAC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x4A53FB0", Offset = "0x4A533B0", VA = "0x184A53FB0")]
			internal float LOJCBJINBHF()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x4A54070", Offset = "0x4A53470", VA = "0x184A54070")]
			internal void MKFNKMAKMAO(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x4A539A0", Offset = "0x4A52DA0", VA = "0x184A539A0")]
			internal float CGOBKLLFAIH()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x4A54130", Offset = "0x4A53530", VA = "0x184A54130")]
			internal void OFBHEDMCGOO(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x4A54010", Offset = "0x4A53410", VA = "0x184A54010")]
			internal float LPEMGJFHKJI()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x4A538E0", Offset = "0x4A52CE0", VA = "0x184A538E0")]
			internal void ADEMDKKCBFJ(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override NodeVisualizationKey NDKJAMPIIHN
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF60", Offset = "0xBBD360", VA = "0x180BBDF60", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public abstract PECPIHLAAHC FJLKHDIPCLG
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(Slot = "126")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x3FF1E50", Offset = "0x3FF1250", VA = "0x183FF1E50")]
		public OGCBACNHCAJ(NPOGACBNNEB DAAJPDFKLAI, T ABBPLCKDHFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x4A645C0", Offset = "0x4A639C0", VA = "0x184A645C0", Slot = "120")]
		protected sealed override void PDMCCHBHFON(MBBLDDIEAEG APEEJDAEHKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private sealed class FALDLCFAKOI : NHHGMDNJAKI<BKDJDOKLEFM>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override NodeVisualizationKey NDKJAMPIIHN
		{
			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x91B560", Offset = "0x91A960", VA = "0x18091B560", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x21FEC20", Offset = "0x21FE020", VA = "0x1821FEC20")]
		public FALDLCFAKOI(NPOGACBNNEB DAAJPDFKLAI, BKDJDOKLEFM ABBPLCKDHFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class DGPPDIODMEI : NHHGMDNJAKI<OBJEDIODJLJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class JNDILIFCBFI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public DGPPDIODMEI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public KAKEIEJNCPC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public JNDILIFCBFI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x2204F30", Offset = "0x2204330", VA = "0x182204F30")]
			internal int GGPDEMIPGLG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x2204EA0", Offset = "0x22042A0", VA = "0x182204EA0")]
			internal void EMCEBNLMHAL(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private static Dictionary<string, LDCIFMJMAPN>? FPJLOJBHGDN;

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x21FD0D0", Offset = "0x21FC4D0", VA = "0x1821FD0D0")]
		public DGPPDIODMEI(NPOGACBNNEB DAAJPDFKLAI, OBJEDIODJLJ ABBPLCKDHFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x21FCD60", Offset = "0x21FC160", VA = "0x1821FCD60", Slot = "120")]
		protected override void PDMCCHBHFON(MBBLDDIEAEG APEEJDAEHKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class JJHJKGDPPNI : OGCBACNHCAJ<BNIODJLOOBA>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public override PECPIHLAAHC FJLKHDIPCLG
		{
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "126")]
			get
			{
				return default(PECPIHLAAHC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x2204E40", Offset = "0x2204240", VA = "0x182204E40")]
		public JJHJKGDPPNI(NPOGACBNNEB DAAJPDFKLAI, BNIODJLOOBA GDIPKBJJCBL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class KKJAKFEGPKL : OMEKNCLAIHF<GOPEMOGPHIG>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public override NodeVisualizationKey NDKJAMPIIHN
		{
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x9178F0", Offset = "0x916CF0", VA = "0x1809178F0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x22059F0", Offset = "0x2204DF0", VA = "0x1822059F0")]
		public KKJAKFEGPKL(NPOGACBNNEB DAAJPDFKLAI, GOPEMOGPHIG ABBPLCKDHFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "120")]
		protected override void PDMCCHBHFON(MBBLDDIEAEG APEEJDAEHKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	private sealed class NGBDIICOBKE : OMEKNCLAIHF<HJEJKKLMPGH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public override NodeVisualizationKey NDKJAMPIIHN
		{
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x9178F0", Offset = "0x916CF0", VA = "0x1809178F0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x220C240", Offset = "0x220B640", VA = "0x18220C240")]
		public NGBDIICOBKE(NPOGACBNNEB DAAJPDFKLAI, HJEJKKLMPGH ABBPLCKDHFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "120")]
		protected override void PDMCCHBHFON(MBBLDDIEAEG APEEJDAEHKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class JFKPIJFDBAK : PDCHOHKGFGJ<GEIMLDGHJIA>
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class LPCGNGMDHAC
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
				public LPCGNGMDHAC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001E2")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40001E3")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40001E4")]
				private TaskAwaiter<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60003CB")]
				[Cpp2IlInjected.Address(RVA = "0x2214BA0", Offset = "0x2213FA0", VA = "0x182214BA0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CC")]
				[Cpp2IlInjected.Address(RVA = "0x954FC0", Offset = "0x9543C0", VA = "0x180954FC0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public KAKEIEJNCPC nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public JFKPIJFDBAK <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public LPCGNGMDHAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x220B860", Offset = "0x220AC60", VA = "0x18220B860")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void OMEHKCBHFOI(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x2204DE0", Offset = "0x22041E0", VA = "0x182204DE0")]
		public JFKPIJFDBAK(NPOGACBNNEB DAAJPDFKLAI, GEIMLDGHJIA GDIPKBJJCBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x2204B00", Offset = "0x2203F00", VA = "0x182204B00", Slot = "126")]
		protected override void LBKMCFDLEAK(MBBLDDIEAEG APEEJDAEHKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class GHDMINNKOHH : OGCBACNHCAJ<EAKNKCKEMAC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override PECPIHLAAHC FJLKHDIPCLG
		{
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x915820", Offset = "0x914C20", VA = "0x180915820", Slot = "126")]
			get
			{
				return default(PECPIHLAAHC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x2200D40", Offset = "0x2200140", VA = "0x182200D40")]
		public GHDMINNKOHH(NPOGACBNNEB DAAJPDFKLAI, EAKNKCKEMAC GDIPKBJJCBL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private sealed class MLIFEFNODGG : NHHGMDNJAKI<ILGOLDBIGMJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public override NodeVisualizationKey NDKJAMPIIHN
		{
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0xC1B0A0", Offset = "0xC1A4A0", VA = "0x180C1B0A0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x220C1D0", Offset = "0x220B5D0", VA = "0x18220C1D0")]
		public MLIFEFNODGG(NPOGACBNNEB DAAJPDFKLAI, ILGOLDBIGMJ ABBPLCKDHFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "120")]
		protected override void PDMCCHBHFON(MBBLDDIEAEG APEEJDAEHKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public sealed class PMMKPPHBMLP : NHHGMDNJAKI<IIOAAALEHML>
	{
		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public sealed override NodeVisualizationKey NDKJAMPIIHN
		{
			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public sealed override bool ONFJFCDEAGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected sealed override bool FOEILCPEHPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x2214840", Offset = "0x2213C40", VA = "0x182214840")]
		public PMMKPPHBMLP(NPOGACBNNEB DAAJPDFKLAI, IIOAAALEHML ABBPLCKDHFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x2214510", Offset = "0x2213910", VA = "0x182214510", Slot = "120")]
		protected override void PDMCCHBHFON(MBBLDDIEAEG APEEJDAEHKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x22144D0", Offset = "0x22138D0", VA = "0x1822144D0")]
		private int ODEKPIJCLMD()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x2214470", Offset = "0x2213870", VA = "0x182214470")]
		private void DCHAJALKBKI(int CCLPDLLIEKA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public class JAKCKBGJNPJ : EIHIKBOKHHF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x21FDC50", Offset = "0x21FD050", VA = "0x1821FDC50")]
		public JAKCKBGJNPJ(NPOGACBNNEB DAAJPDFKLAI, JMGKFHAJOAG ABBPLCKDHFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "120")]
		protected override void PDMCCHBHFON(MBBLDDIEAEG APEEJDAEHKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class FIFPPNFLJGO : PDCHOHKGFGJ<JDHJHBHMOLN>
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x21FF140", Offset = "0x21FE540", VA = "0x1821FF140")]
		public FIFPPNFLJGO(NPOGACBNNEB DAAJPDFKLAI, JDHJHBHMOLN ABBPLCKDHFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public abstract class PDCHOHKGFGJ<TVariableNode> : NHHGMDNJAKI<TVariableNode> where TVariableNode : notnull, JDHJHBHMOLN
	{
		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private sealed class ANEMFEJMMEE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public PDCHOHKGFGJ<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public KAKEIEJNCPC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public ANEMFEJMMEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x412AF90", Offset = "0x412A390", VA = "0x18412AF90")]
			internal bool OCLFICMCOOJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x412ADA0", Offset = "0x412A1A0", VA = "0x18412ADA0")]
			internal void GGPDEMIPGLG(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x412AC80", Offset = "0x412A080", VA = "0x18412AC80")]
			internal bool EMCEBNLMHAL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x412ACE0", Offset = "0x412A0E0", VA = "0x18412ACE0")]
			internal void FMDJPOMAPHE(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x412AE60", Offset = "0x412A260", VA = "0x18412AE60")]
			internal bool IPDFEJDPFOD()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		[CompilerGenerated]
		private sealed class JGKDFBKCJKJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public KAKEIEJNCPC nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public PDCHOHKGFGJ<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public JGKDFBKCJKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x442ACC0", Offset = "0x442A0C0", VA = "0x18442ACC0")]
			internal void OMEHKCBHFOI(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public override NodeVisualizationKey NDKJAMPIIHN
		{
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x92CF10", Offset = "0x92C310", VA = "0x18092CF10", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public override JCONHALMGAE DNCOHEKNFFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x4B54C70", Offset = "0x4B54070", VA = "0x184B54C70", Slot = "94")]
			get
			{
				return default(JCONHALMGAE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x4B54AC0", Offset = "0x4B53EC0", VA = "0x184B54AC0")]
		protected PDCHOHKGFGJ(NPOGACBNNEB DAAJPDFKLAI, TVariableNode ABBPLCKDHFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x4B540D0", Offset = "0x4B534D0", VA = "0x184B540D0", Slot = "88")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x4B54610", Offset = "0x4B53A10", VA = "0x184B54610", Slot = "120")]
		protected override void PDMCCHBHFON(MBBLDDIEAEG APEEJDAEHKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x4B54270", Offset = "0x4B53670", VA = "0x184B54270", Slot = "126")]
		protected virtual void LBKMCFDLEAK(MBBLDDIEAEG APEEJDAEHKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x4B53FD0", Offset = "0x4B533D0", VA = "0x184B53FD0", Slot = "105")]
		public override void AEAEDDMNDLB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x21F45E0", Offset = "0x21F39E0", VA = "0x1821F45E0")]
	public static PDOBBIKMPEL AALKPJMFIHM(NPOGACBNNEB DAAJPDFKLAI, JMGKFHAJOAG ABBPLCKDHFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public sealed class GFGFFGCFBOI : FIPKNLJIHBL, LKNAAMBHFDN, ABLAJBADJIF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public FGLBFCBPBCD<MPANLLKONFK> AJOAMFIHGIG
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x931D20", Offset = "0x931120", VA = "0x180931D20", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(FGLBFCBPBCD<MPANLLKONFK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public FGLBFCBPBCD<CANFCBOLFDP> OLAILCOHHID
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x9FA600", Offset = "0x9F9A00", VA = "0x1809FA600", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(FGLBFCBPBCD<CANFCBOLFDP>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x22009F0", Offset = "0x21FFDF0", VA = "0x1822009F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private FGLBFCBPBCD<NLOPGHOEPOD> ODPMKENKLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x914860", Offset = "0x913C60", VA = "0x180914860")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public override FGLBFCBPBCD<EEHNGBBGEED> GDIFMFODKFM
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x2200A00", Offset = "0x21FFE00", VA = "0x182200A00", Slot = "20")]
		get
		{
			return default(FGLBFCBPBCD<EEHNGBBGEED>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x2200A50", Offset = "0x21FFE50", VA = "0x182200A50")]
	private GFGFFGCFBOI(NPOGACBNNEB DAAJPDFKLAI, JMGKFHAJOAG ABBPLCKDHFH, JLJHFDIJJKE PMDIJMAHODG, FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI, FGLBFCBPBCD<CANFCBOLFDP> EHCJDFNAANJ, FGLBFCBPBCD<NLOPGHOEPOD> PJPFEICFNKD, bool IJHANKLIPBM, string ADANIHOIEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x22006A0", Offset = "0x21FFAA0", VA = "0x1822006A0")]
	public static GFGFFGCFBOI AALKPJMFIHM(NPOGACBNNEB DAAJPDFKLAI, JMGKFHAJOAG ABBPLCKDHFH, JLJHFDIJJKE FNAMNFIPOGA, FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI, FGLBFCBPBCD<NLOPGHOEPOD> PJPFEICFNKD, FGLBFCBPBCD<CANFCBOLFDP> EHCJDFNAANJ, bool IJHANKLIPBM, bool NEDLMKCGKHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x22009F0", Offset = "0x21FFDF0", VA = "0x1822009F0")]
	internal void BCGBGCLMNNL(FGLBFCBPBCD<CANFCBOLFDP> LIHHDPOHLDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public abstract class FIPKNLJIHBL : ABLAJBADJIF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct LAFOJPMGNDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private EHPBCMKMMMM? NAEDPOPJBDG;

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x2205E70", Offset = "0x2205270", VA = "0x182205E70")]
		public void FLFDAJFNFLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x2205E80", Offset = "0x2205280", VA = "0x182205E80")]
		public EHPBCMKMMMM HEMAIECJNGK(FIPKNLJIHBL MPPHHDDCKMM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	protected readonly NPOGACBNNEB CIMEKGEELOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	protected readonly JMGKFHAJOAG ECKGIBJCHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private LAFOJPMGNDP FKEHGGGGEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly MGJNCJJOCNH BJEHBCCLMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private readonly List<KKKJLAMOPDA> LJNIKFEAJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private readonly List<FNEPICGPAPH> HCFJDMPCPGJ;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	[EAFJAFLMLNJ("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> DAMMLCOOKOM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x21FF6A0", Offset = "0x21FEAA0", VA = "0x1821FF6A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public DisplayKind KLIFMLDBMAC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x8BA1F0", Offset = "0x8B95F0", VA = "0x1808BA1F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public FGLBFCBPBCD<PKMIDGFKCAI> FLOEADHOMKD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x22002A0", Offset = "0x21FF6A0", VA = "0x1822002A0", Slot = "6")]
		get
		{
			return default(FGLBFCBPBCD<PKMIDGFKCAI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public JABLMADMPHA<PKMIDGFKCAI> LJAAJGEIPPH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x21FF1A0", Offset = "0x21FE5A0", VA = "0x1821FF1A0", Slot = "7")]
		get
		{
			return default(JABLMADMPHA<PKMIDGFKCAI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public ENEPLLMIFHM HJCAJEFOKFI
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x20D2B10", Offset = "0x20D1F10", VA = "0x1820D2B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public HBIFGMFFHHL HBPOFJMHMIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x21FF9D0", Offset = "0x21FEDD0", VA = "0x1821FF9D0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	protected EHPBCMKMMMM ALEFLCDDOMK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x21FF9D0", Offset = "0x21FEDD0", VA = "0x1821FF9D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public PortImage NBEBLLEGKIA
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x21FF230", Offset = "0x21FE630", VA = "0x1821FF230", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public string BKJCNMKILGO
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB10", Offset = "0x8AEF10", VA = "0x1808AFB10", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x8AFC10", Offset = "0x8AF010", VA = "0x1808AFC10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public JABLMADMPHA<EPJMFNGLNNN> KCCAKHKEOLB
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x21FF990", Offset = "0x21FED90", VA = "0x1821FF990", Slot = "9")]
		get
		{
			return default(JABLMADMPHA<EPJMFNGLNNN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public FGLBFCBPBCD<NPNHBKKDMLD> AIJPKDMIGFP
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E9620", VA = "0x1809EA220", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(FGLBFCBPBCD<NPNHBKKDMLD>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x9E9C90", Offset = "0x9E9090", VA = "0x1809E9C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public abstract FGLBFCBPBCD<EEHNGBBGEED> GDIFMFODKFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x2200540", Offset = "0x21FF940", VA = "0x182200540")]
	protected FIPKNLJIHBL(NPOGACBNNEB DAAJPDFKLAI, JMGKFHAJOAG ABBPLCKDHFH, MGJNCJJOCNH MPICFOLCBBC, FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI, bool IJHANKLIPBM, string ADANIHOIEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x21FFA70", Offset = "0x21FEE70", VA = "0x1821FFA70", Slot = "21")]
	protected virtual void JLABJFAHLGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x21FF550", Offset = "0x21FE950", VA = "0x1821FF550", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x22002D0", Offset = "0x21FF6D0", VA = "0x1822002D0", Slot = "14")]
	public void MMEOBAIHJIG(KKKJLAMOPDA CKGGOPMBENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x2200330", Offset = "0x21FF730", VA = "0x182200330", Slot = "15")]
	public void NNHCBCLKOGN(FNEPICGPAPH CKGGOPMBENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x21FFBC0", Offset = "0x21FEFC0", VA = "0x1821FFBC0", Slot = "16")]
	public void KGHDFNIGOGP(FMDBDIMJDHO NFBBKPHBIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x21FF1D0", Offset = "0x21FE5D0", VA = "0x1821FF1D0", Slot = "23")]
	protected virtual void CCDCKDMJCDH(FMDBDIMJDHO NFBBKPHBIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x21FF360", Offset = "0x21FE760", VA = "0x1821FF360")]
	private void CFMEPAJIGHN(bool PAHNKMKPPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x21FF7E0", Offset = "0x21FEBE0", VA = "0x1821FF7E0")]
	private void FBGNENCLPFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x2200390", Offset = "0x21FF790", VA = "0x182200390")]
	private void OLOCPHKGJBC([In] MCOPIFNJCLB EHBCFIFAEOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x21FF4F0", Offset = "0x21FE8F0", VA = "0x1821FF4F0", Slot = "17")]
	public void DPNAOFHAKMD(KKKJLAMOPDA CKGGOPMBENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x2200240", Offset = "0x21FF640", VA = "0x182200240", Slot = "18")]
	public void KKLGANDGLOF(FNEPICGPAPH CKGGOPMBENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x8AFC10", Offset = "0x8AF010", VA = "0x1808AFC10")]
	internal void EIACILOFAHO(string ADANIHOIEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x21FF9B0", Offset = "0x21FEDB0", VA = "0x1821FF9B0")]
	internal void HHFAMKPPLFK(NHIELPAGKFM ICFGLKCGHOG, ENEPLLMIFHM LGJDMOCCBDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x9E9C90", Offset = "0x9E9090", VA = "0x1809E9C90")]
	internal void OFHGBOOILLK(FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public sealed class OBAIIIHPPPB : PDOBKPANMAN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class BLEIAFOBNEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public NPOGACBNNEB circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public JMGKFHAJOAG node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public FGLBFCBPBCD<NPNHBKKDMLD> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public BLEIAFOBNEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x21FB540", Offset = "0x21FA940", VA = "0x1821FB540")]
		internal IDKGDBGCPID FCOBBADEKAK((int PortDescIndex, int PortIndex, ANJINNCDNGK InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x21FB5D0", Offset = "0x21FA9D0", VA = "0x1821FB5D0")]
		internal GFGFFGCFBOI LGNJIDFHMAE(JLJHFDIJJKE i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct AHHLIGBKBNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public OBAIIIHPPPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private LFPDLPFKFJE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private TaskAwaiter<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x21FA210", Offset = "0x21F9610", VA = "0x1821FA210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x21FA670", Offset = "0x21F9A70", VA = "0x1821FA670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct EMKLCOINNGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public OBAIIIHPPPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public FGLBFCBPBCD<EEBKBHCGBCM> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private LFPDLPFKFJE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private TaskAwaiter<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x21FE780", Offset = "0x21FDB80", VA = "0x1821FE780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x21FEAD0", Offset = "0x21FDED0", VA = "0x1821FEAD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct IHLKCLGAIJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public OBAIIIHPPPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public FGLBFCBPBCD<NLOPGHOEPOD> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private LFPDLPFKFJE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private TaskAwaiter<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x2202350", Offset = "0x2201750", VA = "0x182202350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x22026A0", Offset = "0x2201AA0", VA = "0x1822026A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct HAOLBIBPGGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public OBAIIIHPPPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public FGLBFCBPBCD<EEBKBHCGBCM> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public FGLBFCBPBCD<EEBKBHCGBCM> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private LFPDLPFKFJE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private TaskAwaiter<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x2200EE0", Offset = "0x22002E0", VA = "0x182200EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x2201230", Offset = "0x2200630", VA = "0x182201230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct OBNCBILHBGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public OBAIIIHPPPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public FGLBFCBPBCD<NLOPGHOEPOD> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public FGLBFCBPBCD<NLOPGHOEPOD> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private LFPDLPFKFJE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private TaskAwaiter<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x22130F0", Offset = "0x22124F0", VA = "0x1822130F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x2213440", Offset = "0x2212840", VA = "0x182213440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct MBPKGOKDPJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public OBAIIIHPPPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private LFPDLPFKFJE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private TaskAwaiter<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x220B930", Offset = "0x220AD30", VA = "0x18220B930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x220BDA0", Offset = "0x220B1A0", VA = "0x18220BDA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct HCGPCDMFIHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public OBAIIIHPPPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private LFPDLPFKFJE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private TaskAwaiter<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x22012A0", Offset = "0x22006A0", VA = "0x1822012A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x22015F0", Offset = "0x22009F0", VA = "0x1822015F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct PKENLKNIKKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public OBAIIIHPPPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public FGLBFCBPBCD<EEBKBHCGBCM> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private LFPDLPFKFJE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private TaskAwaiter<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x22140B0", Offset = "0x22134B0", VA = "0x1822140B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x2214400", Offset = "0x2213800", VA = "0x182214400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct AOFMMJIFPFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public OBAIIIHPPPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public FGLBFCBPBCD<NLOPGHOEPOD> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private LFPDLPFKFJE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x21FAF60", Offset = "0x21FA360", VA = "0x1821FAF60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x21FB2B0", Offset = "0x21FA6B0", VA = "0x1821FB2B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct LDALFLCFGDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public OBAIIIHPPPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public MHMKOPIHJHJ type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public FGLBFCBPBCD<EEBKBHCGBCM> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private LFPDLPFKFJE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private TaskAwaiter<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x2206090", Offset = "0x2205490", VA = "0x182206090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x2206420", Offset = "0x2205820", VA = "0x182206420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct CMNDLALIFML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public OBAIIIHPPPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public MHMKOPIHJHJ type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public FGLBFCBPBCD<NLOPGHOEPOD> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private LFPDLPFKFJE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private TaskAwaiter<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x21FC6A0", Offset = "0x21FBAA0", VA = "0x1821FC6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x21FCA30", Offset = "0x21FBE30", VA = "0x1821FCA30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private readonly bool NONCLHHFEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly NPOGACBNNEB CIMEKGEELOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private readonly bool DGMJDHELDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private FCMFIIGFAIL<CLEIGCGCLHM, IDKGDBGCPID> DAIPLECKCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private FCMFIIGFAIL<CLEIGCGCLHM, FCHCPAMLLED> MOAJLKAIIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private readonly JMGKFHAJOAG ECKGIBJCHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private FCMFIIGFAIL<CANFCBOLFDP, GFGFFGCFBOI> PAPEAAFKKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private FCMFIIGFAIL<CANFCBOLFDP, LKNAAMBHFDN> EAKGIHFFMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private string? OOPEDLJDAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly FFKLHNCOINB LGMDNOHIHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private FGLBFCBPBCD<NPNHBKKDMLD> GKKLCCEPIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private readonly bool LJIDCDEFMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	[CompilerGenerated]
	private Action? OCNOLFLJOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	[CompilerGenerated]
	private Action? AEADKCIMFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	[CompilerGenerated]
	private Action<FGLBFCBPBCD<CLEIGCGCLHM>>? NJHHCOOOANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	[CompilerGenerated]
	private Action<FGLBFCBPBCD<CANFCBOLFDP>>? JOJEMNPAOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	[CompilerGenerated]
	private PDOBKPANMAN.JKOKFMBECGG? DEDEAOKIKNM;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool FCOENKEJNDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x22111E0", Offset = "0x22105E0", VA = "0x1822111E0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool KIPMPPGDNKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x220FD20", Offset = "0x220F120", VA = "0x18220FD20", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool KCFNEAJFDAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x2211060", Offset = "0x2210460", VA = "0x182211060", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public JABLMADMPHA<PKMIDGFKCAI> LJAAJGEIPPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x220D010", Offset = "0x220C410", VA = "0x18220D010", Slot = "7")]
		get
		{
			return default(JABLMADMPHA<PKMIDGFKCAI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool LNDONDGNDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x2210E20", Offset = "0x2210220", VA = "0x182210E20", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public FCMFIIGFAIL<CLEIGCGCLHM, FCHCPAMLLED> HDDCLJLIHFG
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x8AE500", Offset = "0x8AD900", VA = "0x1808AE500", Slot = "9")]
		get
		{
			return default(FCMFIIGFAIL<CLEIGCGCLHM, FCHCPAMLLED>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public string BKJCNMKILGO
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x220E190", Offset = "0x220D590", VA = "0x18220E190", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public JABLMADMPHA<EPJMFNGLNNN> KCCAKHKEOLB
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x220F290", Offset = "0x220E690", VA = "0x18220F290", Slot = "11")]
		get
		{
			return default(JABLMADMPHA<EPJMFNGLNNN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public FCMFIIGFAIL<CANFCBOLFDP, LKNAAMBHFDN> OFNFFDPPEFH
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB10", Offset = "0x8AEF10", VA = "0x1808AFB10", Slot = "12")]
		get
		{
			return default(FCMFIIGFAIL<CANFCBOLFDP, LKNAAMBHFDN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public FGLBFCBPBCD<NPNHBKKDMLD> AIJPKDMIGFP
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x914870", Offset = "0x913C70", VA = "0x180914870", Slot = "13")]
		get
		{
			return default(FGLBFCBPBCD<NPNHBKKDMLD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action BHMHIHMFEAN
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x2210BD0", Offset = "0x220FFD0", VA = "0x182210BD0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x2210FC0", Offset = "0x22103C0", VA = "0x182210FC0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action NJLFLJMFGMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x22112C0", Offset = "0x22106C0", VA = "0x1822112C0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x220FF10", Offset = "0x220F310", VA = "0x18220FF10", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<FGLBFCBPBCD<CLEIGCGCLHM>, FGLBFCBPBCD<CLEIGCGCLHM>> IDDMEFDJDDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x22114E0", Offset = "0x22108E0", VA = "0x1822114E0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x220FFC0", Offset = "0x220F3C0", VA = "0x18220FFC0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<FGLBFCBPBCD<CLEIGCGCLHM>, FGLBFCBPBCD<CLEIGCGCLHM>> KKMAEIIINLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x220F1D0", Offset = "0x220E5D0", VA = "0x18220F1D0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x220DA00", Offset = "0x220CE00", VA = "0x18220DA00", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<FGLBFCBPBCD<CANFCBOLFDP>, FGLBFCBPBCD<CANFCBOLFDP>> OLMPFAENMPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x2211120", Offset = "0x2210520", VA = "0x182211120", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x22115A0", Offset = "0x22109A0", VA = "0x1822115A0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<FGLBFCBPBCD<CANFCBOLFDP>, FGLBFCBPBCD<CANFCBOLFDP>> GPMLHKEACGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x2210D60", Offset = "0x2210160", VA = "0x182210D60", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x2211E30", Offset = "0x2211230", VA = "0x182211E30", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<FGLBFCBPBCD<CLEIGCGCLHM>, FCHCPAMLLED> LPDKFAKHNMD
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x2211EF0", Offset = "0x22112F0", VA = "0x182211EF0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x220DAC0", Offset = "0x220CEC0", VA = "0x18220DAC0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<FGLBFCBPBCD<CLEIGCGCLHM>> KIALCGONMIB
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x220DC40", Offset = "0x220D040", VA = "0x18220DC40", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x220DB80", Offset = "0x220CF80", VA = "0x18220DB80", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<FGLBFCBPBCD<CLEIGCGCLHM>, FCHCPAMLLED> LJMHFEOHEEB
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x2210F00", Offset = "0x2210300", VA = "0x182210F00", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x22120E0", Offset = "0x22114E0", VA = "0x1822120E0", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<FGLBFCBPBCD<CANFCBOLFDP>, LKNAAMBHFDN> CIGIAFGFIHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x220DD00", Offset = "0x220D100", VA = "0x18220DD00", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x220F110", Offset = "0x220E510", VA = "0x18220F110", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<FGLBFCBPBCD<CANFCBOLFDP>> OHNIKNCAMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x220DEF0", Offset = "0x220D2F0", VA = "0x18220DEF0", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x220FD60", Offset = "0x220F160", VA = "0x18220FD60", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<FGLBFCBPBCD<CANFCBOLFDP>, LKNAAMBHFDN> JFCNGKJEHCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x220E0D0", Offset = "0x220D4D0", VA = "0x18220E0D0", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x2212560", Offset = "0x2211960", VA = "0x182212560", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x2212EE0", Offset = "0x22122E0", VA = "0x182212EE0")]
	private OBAIIIHPPPB(bool IJHANKLIPBM, NPOGACBNNEB DAAJPDFKLAI, bool FPGDGEFKNKI, FCMFIIGFAIL<CLEIGCGCLHM, IDKGDBGCPID> IINLMHKCFCG, FCMFIIGFAIL<CLEIGCGCLHM, FCHCPAMLLED> DCDHLJKEHNH, JMGKFHAJOAG ABBPLCKDHFH, FCMFIIGFAIL<CANFCBOLFDP, GFGFFGCFBOI> OECOKGMEMPF, FCMFIIGFAIL<CANFCBOLFDP, LKNAAMBHFDN> EPNHLJOLBJA, string? PNDNIJNNCOK, FFKLHNCOINB FBDIFKCJCCO, FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI, bool NEDLMKCGKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x220D040", Offset = "0x220C440", VA = "0x18220D040")]
	public static OBAIIIHPPPB AALKPJMFIHM(bool IJHANKLIPBM, NPOGACBNNEB DAAJPDFKLAI, bool FPGDGEFKNKI, JMGKFHAJOAG ABBPLCKDHFH, FFKLHNCOINB FBDIFKCJCCO, FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI, bool NEDLMKCGKHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x2210420", Offset = "0x220F820", VA = "0x182210420")]
	private void JLABJFAHLGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x220E610", Offset = "0x220DA10", VA = "0x18220E610", Slot = "49")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x2212620", Offset = "0x2211A20", VA = "0x182212620", Slot = "38")]
	[AsyncStateMachine(typeof(AHHLIGBKBNK))]
	public Task<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> PEBEBKPJOJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x2212710", Offset = "0x2211B10", VA = "0x182212710")]
	private (JLKBECNJOBD, int)? PECLOKHHKBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x2210C70", Offset = "0x2210070", VA = "0x182210C70")]
	private void JMIBFOGJJOD(int GHLDIOHHNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x18E23C0", Offset = "0x18E17C0", VA = "0x1818E23C0")]
	private void BKMMLBLDOEI(int GHLDIOHHNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x2210080", Offset = "0x220F480", VA = "0x182210080")]
	private void JFGAAIGPGBI(int HHNDFHKFNLN, int OOCAPOEBBGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x2210EA0", Offset = "0x22102A0", VA = "0x182210EA0")]
	private void KLHHGCCJBKF(int HHNDFHKFNLN, int OOCAPOEBBGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x220F6B0", Offset = "0x220EAB0", VA = "0x18220F6B0")]
	private void GBADBECNIFI(int GHLDIOHHNFC, FGLBFCBPBCD<CLEIGCGCLHM> CPODDKDFJMM, ANJINNCDNGK EDLBBMLDLIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x2212DB0", Offset = "0x22121B0", VA = "0x182212DB0")]
	private void PKLNHLMPFDF(int PAHNKMKPPCD, FGLBFCBPBCD<CLEIGCGCLHM> CPODDKDFJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x22112A0", Offset = "0x22106A0", VA = "0x1822112A0")]
	private void LLFIDOEBFPI(int PAHNKMKPPCD, FGLBFCBPBCD<CLEIGCGCLHM> CPODDKDFJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x220E1C0", Offset = "0x220D5C0", VA = "0x18220E1C0")]
	private void DEJPDONNIBP(int GHLDIOHHNFC, FGLBFCBPBCD<CLEIGCGCLHM> CPODDKDFJMM, ANJINNCDNGK EDLBBMLDLIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x2211BA0", Offset = "0x2210FA0", VA = "0x182211BA0")]
	private void NCLPPKDFNPE(int GHLDIOHHNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0xDE2DA0", Offset = "0xDE21A0", VA = "0x180DE2DA0")]
	private void ANMEOOGMEBA(int GHLDIOHHNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x220FE20", Offset = "0x220F220", VA = "0x18220FE20")]
	private void IILMHPOGPIJ(int GHLDIOHHNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x18E23C0", Offset = "0x18E17C0", VA = "0x1818E23C0")]
	private void KAEMMGDLIHF(int GHLDIOHHNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x220F2B0", Offset = "0x220E6B0", VA = "0x18220F2B0")]
	private void FELJAOCPEPM(int HHNDFHKFNLN, int OOCAPOEBBGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x220F650", Offset = "0x220EA50", VA = "0x18220F650")]
	private void FPOBIGBEFOA(int HHNDFHKFNLN, int OOCAPOEBBGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x2211660", Offset = "0x2210A60", VA = "0x182211660")]
	private void MOKJHKDLMPN(int GHLDIOHHNFC, FGLBFCBPBCD<CANFCBOLFDP> CPODDKDFJMM, JLJHFDIJJKE EDLBBMLDLIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x22114C0", Offset = "0x22108C0", VA = "0x1822114C0")]
	private void MFNLBGDIGMN(int PAHNKMKPPCD, FGLBFCBPBCD<CANFCBOLFDP> CPODDKDFJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x2211CF0", Offset = "0x22110F0", VA = "0x182211CF0")]
	private void NFKDHNPFANB(int PAHNKMKPPCD, FGLBFCBPBCD<CANFCBOLFDP> CPODDKDFJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x2212940", Offset = "0x2211D40", VA = "0x182212940")]
	private void PKBAKKADAIM(int GHLDIOHHNFC, FGLBFCBPBCD<CANFCBOLFDP> CPODDKDFJMM, JLJHFDIJJKE EDLBBMLDLIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x2211370", Offset = "0x2210770", VA = "0x182211370")]
	private void MDGCAAANIHD(int GHLDIOHHNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0xDE2DA0", Offset = "0xDE21A0", VA = "0x180DE2DA0")]
	private void OPFNCDMFOME(int GHLDIOHHNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x220D6E0", Offset = "0x220CAE0", VA = "0x18220D6E0", Slot = "39")]
	[AsyncStateMachine(typeof(EMKLCOINNGI))]
	public Task<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> AFPGNFHCPBD(FGLBFCBPBCD<EEBKBHCGBCM> KIDFOJNAAAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x2212DD0", Offset = "0x22121D0", VA = "0x182212DD0", Slot = "40")]
	[AsyncStateMachine(typeof(IHLKCLGAIJG))]
	public Task<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> PLGAELINCOP(FGLBFCBPBCD<NLOPGHOEPOD> PJPFEICFNKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x220D7F0", Offset = "0x220CBF0", VA = "0x18220D7F0", Slot = "41")]
	[AsyncStateMachine(typeof(HAOLBIBPGGL))]
	public Task<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> BAMJMHJOINK(FGLBFCBPBCD<EEBKBHCGBCM> KIDFOJNAAAB, FGLBFCBPBCD<EEBKBHCGBCM> MNNPNHPGGOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x220DFB0", Offset = "0x220D3B0", VA = "0x18220DFB0", Slot = "42")]
	[AsyncStateMachine(typeof(OBNCBILHBGO))]
	public Task<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> CNOAGFGNLHO(FGLBFCBPBCD<NLOPGHOEPOD> PJPFEICFNKD, FGLBFCBPBCD<NLOPGHOEPOD> MNNPNHPGGOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x220D910", Offset = "0x220CD10", VA = "0x18220D910", Slot = "43")]
	[AsyncStateMachine(typeof(MBPKGOKDPJJ))]
	public Task<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> BDAANLDCDGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x2211D10", Offset = "0x2211110", VA = "0x182211D10", Slot = "44")]
	[AsyncStateMachine(typeof(HCGPCDMFIHF))]
	public Task<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> NHAGNJGAEAJ(string DHBCNDNKDDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x220D5B0", Offset = "0x220C9B0", VA = "0x18220D5B0", Slot = "45")]
	[AsyncStateMachine(typeof(PKENLKNIKKI))]
	public Task<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> ABOFHMFPNKC(FGLBFCBPBCD<EEBKBHCGBCM> KIDFOJNAAAB, string ADANIHOIEKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x220FBF0", Offset = "0x220EFF0", VA = "0x18220FBF0", Slot = "46")]
	[AsyncStateMachine(typeof(AOFMMJIFPFM))]
	public Task<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> GHCNLLFDOFK(FGLBFCBPBCD<NLOPGHOEPOD> PJPFEICFNKD, string ADANIHOIEKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x220DDC0", Offset = "0x220D1C0", VA = "0x18220DDC0", Slot = "47")]
	[AsyncStateMachine(typeof(LDALFLCFGDK))]
	public Task<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> CDFNNNKKEEF(FGLBFCBPBCD<EEBKBHCGBCM> KIDFOJNAAAB, MHMKOPIHJHJ LGJDMOCCBDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x2211FB0", Offset = "0x22113B0", VA = "0x182211FB0", Slot = "48")]
	[AsyncStateMachine(typeof(CMNDLALIFML))]
	public Task<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> NOBLHPPEEEO(FGLBFCBPBCD<NLOPGHOEPOD> PJPFEICFNKD, MHMKOPIHJHJ LGJDMOCCBDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x22121A0", Offset = "0x22115A0", VA = "0x1822121A0")]
	internal void OFHGBOOILLK(FGLBFCBPBCD<NPNHBKKDMLD> LIHHDPOHLDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public sealed class OEBHBKDNBDG : NDEFHBDPGED, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public interface NFMIJAKBECH
	{
		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		NHIELPAGKFM MOMAAAHAPGC
		{
			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<HPGJHIFKKPI> CPAPJCAGJIH(CancellationToken EEHACKMODLA);

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<GIMIMNLPGGB> DMIFNLANOML(CancellationToken EEHACKMODLA);

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<MMDKKMJKCJP> BEOPKFGOGJC(CancellationToken EEHACKMODLA);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct JOIAAFALPNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<OEBHBKDNBDG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public NPOGACBNNEB circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public HPGJHIFKKPI roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public GIMIMNLPGGB superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private NFMIJAKBECH <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private GIMIMNLPGGB <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<HPGJHIFKKPI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private TaskAwaiter<GIMIMNLPGGB> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter<MMDKKMJKCJP> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private TaskAwaiter<LEIHDBBDJBH> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x2204F80", Offset = "0x2204380", VA = "0x182204F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x2205980", Offset = "0x2204D80", VA = "0x182205980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private readonly LEIHDBBDJBH OLAAPIJPGHI;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public LEIHDBBDJBH ENGHBPIHIFE
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x8AF9B0", Offset = "0x8AEDB0", VA = "0x1808AF9B0")]
	private OEBHBKDNBDG(LEIHDBBDJBH GFKNBLCJBNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x22134B0", Offset = "0x22128B0", VA = "0x1822134B0")]
	[AsyncStateMachine(typeof(JOIAAFALPNA))]
	public static Task<OEBHBKDNBDG> DHDAGHKIMEG(NPOGACBNNEB DAAJPDFKLAI, HPGJHIFKKPI? CAAMOPOAIJO, GIMIMNLPGGB? PFHICJBHJNE, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x2213610", Offset = "0x2212A10", VA = "0x182213610", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public readonly struct KLPMHLBMBFG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct EDBNLOEOKNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<object, FNDOAGAGANG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public KLPMHLBMBFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public MMPFCBBACAJ action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private TaskAwaiter<MLIDCCDLMIE<object, FNDOAGAGANG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x21FD140", Offset = "0x21FC540", VA = "0x1821FD140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x21FD3D0", Offset = "0x21FC7D0", VA = "0x1821FD3D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct FEIGFACGHMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<bool, FNDOAGAGANG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public FJPDKJENCCL rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public HPGJHIFKKPI circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public GIMIMNLPGGB superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public KLPMHLBMBFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private MMPFCBBACAJ[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private TaskAwaiter<MLIDCCDLMIE<object, FNDOAGAGANG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x21FEC90", Offset = "0x21FE090", VA = "0x1821FEC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x21FF070", Offset = "0x21FE470", VA = "0x1821FF070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct BMAMNPGFPJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public KLPMHLBMBFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private TaskAwaiter<MLIDCCDLMIE<object, FNDOAGAGANG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x21FB660", Offset = "0x21FAA60", VA = "0x1821FB660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x21FB8A0", Offset = "0x21FACA0", VA = "0x1821FB8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private readonly LMNOHBMPKBL PFGFBDIFMPJ;

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x93EE00", Offset = "0x93E200", VA = "0x18093EE00")]
	public KLPMHLBMBFG(LMNOHBMPKBL ILJMGJGDGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x2205BB0", Offset = "0x2204FB0", VA = "0x182205BB0")]
	[AsyncStateMachine(typeof(EDBNLOEOKNI))]
	private Task<MLIDCCDLMIE<object, FNDOAGAGANG>> GLGKCCLCIGP(MMPFCBBACAJ MDOOJHKFGMP, bool COINEAOGNMD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x2205A50", Offset = "0x2204E50", VA = "0x182205A50")]
	[AsyncStateMachine(typeof(FEIGFACGHMP))]
	public Task<MLIDCCDLMIE<bool, FNDOAGAGANG?>>? EFALMKOEDLP(int MPKJLPAEKPN, FJPDKJENCCL? DPLFPHNCENJ, HPGJHIFKKPI? CPJCPGIAANG, GIMIMNLPGGB? PFHICJBHJNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x2205CE0", Offset = "0x22050E0", VA = "0x182205CE0")]
	[AsyncStateMachine(typeof(BMAMNPGFPJO))]
	public Task<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> LBHGGLOEOHI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public sealed class BALMBGFPMPP : KMIPODNMGGP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private readonly MICAAFONLBE OIDNFNDAOFE;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public MICAAFONLBE NLOJENLHHAL
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x8AF9B0", Offset = "0x8AEDB0", VA = "0x1808AF9B0")]
	private BALMBGFPMPP(MICAAFONLBE EILJODAGAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x21FB340", Offset = "0x21FA740", VA = "0x1821FB340")]
	public static BALMBGFPMPP GEBAPMNFHGF(NPOGACBNNEB DAAJPDFKLAI, FJPDKJENCCL BLOHLDFABIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x21FB320", Offset = "0x21FA720", VA = "0x1821FB320", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public interface FPNPACFIABK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	LEIHDBBDJBH ENGHBPIHIFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	MELCPLGPBGA KFCENDKPJBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	HMDMIADKCOB ILCMPODLGFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	LFMNPBDBKCI ADHLIGNFCFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public interface KJNBOEGDDID : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	FPNPACFIABK? LJJEECNBJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	bool NMBIACJCIOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	bool PEOEDFIEIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<FPNPACFIABK?>? ICCFDPEINKA();

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task DNBFJBKFHJO(NPOGACBNNEB DAAJPDFKLAI, FJPDKJENCCL BLOHLDFABIK, HPGJHIFKKPI? JOOKPPEKIOI, GIMIMNLPGGB? LNKGGEMCGFE);
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[NBCAKKJDAAM("IStaticCV2Instance")]
public interface NDEFHBDPGED : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	LEIHDBBDJBH ENGHBPIHIFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[NBCAKKJDAAM("IStaticEVInstance")]
public interface KMIPODNMGGP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	MICAAFONLBE NLOJENLHHAL
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class NNEFGILGLNL
{
	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x220CA90", Offset = "0x220BE90", VA = "0x18220CA90")]
	public static CHBJLOGABAB<MHKGHIJEKIM, MMPFCBBACAJ, NPOGACBNNEB, PBBGFJIIJDE.CNELGLEOHLI<MHKGHIJEKIM, MMPFCBBACAJ, NPOGACBNNEB>> LJHLMDFAFEJ([In] this CHBJLOGABAB<MHKGHIJEKIM, MMPFCBBACAJ, NPOGACBNNEB, PBBGFJIIJDE.CNELGLEOHLI<MHKGHIJEKIM, MMPFCBBACAJ, NPOGACBNNEB>> DBDMHGHLFAL)
	{
		return default(CHBJLOGABAB<MHKGHIJEKIM, MMPFCBBACAJ, NPOGACBNNEB, PBBGFJIIJDE.CNELGLEOHLI<MHKGHIJEKIM, MMPFCBBACAJ, NPOGACBNNEB>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public sealed class CKPPFBFPNGE : HAJGGMENBOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private readonly NPOGACBNNEB CIMEKGEELOP;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool PEOEDFIEIPF
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x21FC680", Offset = "0x21FBA80", VA = "0x1821FC680", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x8AF9B0", Offset = "0x8AEDB0", VA = "0x1808AF9B0")]
	internal CKPPFBFPNGE(NPOGACBNNEB DAAJPDFKLAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal sealed class KPFEHFPNGGF : GGDODLFCLBP
{
	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x2205DD0", Offset = "0x22051D0", VA = "0x182205DD0", Slot = "4")]
	public BAEJMCIBENI? HNBJCNFEIFF(string? NKDBIOJHKHB, string? ENDKHILOAMP, string? LAAKIIHMPAF, MBOEDPABAEA.JCCKDJKFEMN.KNOPIMPNFKP OCGGENEGDDP, bool DELJAAABCMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public KPFEHFPNGGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public sealed class BMNJBAHPJDO : KLKDHEGPFBP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private struct IGPFIFILPNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public AsyncTaskMethodBuilder<DCDABDCPDPJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public BMNJBAHPJDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private TaskAwaiter<FPNPACFIABK?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x2202040", Offset = "0x2201440", VA = "0x182202040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x22022E0", Offset = "0x22016E0", VA = "0x1822022E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private readonly NPOGACBNNEB CIMEKGEELOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private IReadOnlyList<JABLMADMPHA<DJFIOODIFAG>>? BMAEOAKDOOJ;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public DCDABDCPDPJ? FKMJLLKHOAH
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x21FBE20", Offset = "0x21FB220", VA = "0x1821FBE20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public LFMNPBDBKCI? NDKDOGOLPJP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x21FB910", Offset = "0x21FAD10", VA = "0x1821FB910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool BJPAODGMPPP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x21FBEA0", Offset = "0x21FB2A0", VA = "0x1821FBEA0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool IHGKKNPCCOC
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x21FBF00", Offset = "0x21FB300", VA = "0x1821FBF00", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x8AF9B0", Offset = "0x8AEDB0", VA = "0x1808AF9B0")]
	internal BMNJBAHPJDO(NPOGACBNNEB DAAJPDFKLAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x21FB990", Offset = "0x21FAD90", VA = "0x1821FB990", Slot = "7")]
	[AsyncStateMachine(typeof(IGPFIFILPNF))]
	public Task<DCDABDCPDPJ> CAKMIOHOEFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x21FBF60", Offset = "0x21FB360", VA = "0x1821FBF60", Slot = "9")]
	public IReadOnlyDictionary<JABLMADMPHA<PKMIDGFKCAI>, Guid> OALEEIMIFFE(IEnumerable<FGFJJKFMCDJ> IDHEHGCHNGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x21FBC50", Offset = "0x21FB050", VA = "0x1821FBC50")]
	public MLIDCCDLMIE<OICENHJDGJN, JPHFAKFKMJL> ECNENGKIBPA([In] OICENHJDGJN GNNGIEKMIGB, IEnumerable<FGFJJKFMCDJ> BNJAJJDKNIL, int HAPNOMENKIF)
	{
		return default(MLIDCCDLMIE<OICENHJDGJN, JPHFAKFKMJL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x21FBA80", Offset = "0x21FAE80", VA = "0x1821FBA80", Slot = "8")]
	private MLIDCCDLMIE<OICENHJDGJN, JPHFAKFKMJL> DGMJPENBMPA([In] OICENHJDGJN GNNGIEKMIGB, IEnumerable<FGFJJKFMCDJ> BNJAJJDKNIL, int HAPNOMENKIF)
	{
		return default(MLIDCCDLMIE<OICENHJDGJN, JPHFAKFKMJL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class LFMNPBDBKCI : DCDABDCPDPJ
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	internal static class JEKPLLOJGEO
	{
		[Cpp2IlInjected.Token(Token = "0x20000CC")]
		[CompilerGenerated]
		private sealed class IFOAIOOKMPJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000294")]
			public LEIHDBBDJBH state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000295")]
			public AMKKFMOEIJN spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public IFOAIOOKMPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0x2201F50", Offset = "0x2201350", VA = "0x182201F50")]
			internal bool PIMNIGOLBML(BOAKPOGKLFL n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CD")]
		[CompilerGenerated]
		private sealed class GLMIJGLGPOG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000296")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public GLMIJGLGPOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FC")]
			[Cpp2IlInjected.Address(RVA = "0x2200EC0", Offset = "0x22002C0", VA = "0x182200EC0")]
			internal void GBEHNJOMICA(BOAKPOGKLFL n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x22040B0", Offset = "0x22034B0", VA = "0x1822040B0")]
		public static MLIDCCDLMIE<DCDABDCPDPJ.CCGOMLPLGED, FEGHIOJFDLM> EHNFAJDFHCN(LFMNPBDBKCI MBGHIKEGJAA, [In] DCDABDCPDPJ.JFDMEKLFDBC HJEECPNIDIG)
		{
			return default(MLIDCCDLMIE<DCDABDCPDPJ.CCGOMLPLGED, FEGHIOJFDLM>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x2203240", Offset = "0x2202640", VA = "0x182203240")]
		internal static MLIDCCDLMIE<(GHNFLIKPNBE, AKJLFOKANCD), FEGHIOJFDLM> DOMIJCHPFCD(LFMNPBDBKCI MBGHIKEGJAA, AKJLFOKANCD DNOODCMNKPA, bool MFHNAPMHLHE, [In] JABLMADMPHA<PKMIDGFKCAI> LECMECBNCOB, [In] int? NBHAFJNBACJ, [In] LGKLMGHGDKJ? CILJEPMOGNF, [In] LGKLMGHGDKJ? PCBGKHKJGCA)
		{
			return default(MLIDCCDLMIE<(GHNFLIKPNBE, AKJLFOKANCD), FEGHIOJFDLM>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x2202E00", Offset = "0x2202200", VA = "0x182202E00")]
		private static void DAEALJMEELF(bool MFHNAPMHLHE, FGFJJKFMCDJ BLFEKFIMKCH, GHNFLIKPNBE GAJFAEJBGKL, [In] JABLMADMPHA<PKMIDGFKCAI> LECMECBNCOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x2204700", Offset = "0x2203B00", VA = "0x182204700")]
		public static void KBHEKKACCPM(CLMGCABGNKJ KODGDMIMNLB, [In] DCDABDCPDPJ.IJPNLCOILAH GHNEKGMNKPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x2204610", Offset = "0x2203A10", VA = "0x182204610")]
		[CompilerGenerated]
		internal static bool JFNEEALMLAH(LEIHDBBDJBH AOAPJHFLBJO, AMKKFMOEIJN LCMIMNECPEP, BOAKPOGKLFL OABJAFEEHNC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x2202DD0", Offset = "0x22021D0", VA = "0x182202DD0")]
		[CompilerGenerated]
		internal static bool CPGJEHNIAHE(BOAKPOGKLFL KFGHKJHEFCL)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private struct NHAEIMBJGGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public LFMNPBDBKCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public FGLBFCBPBCD<PKMIDGFKCAI> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public FGLBFCBPBCD<MPANLLKONFK> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public FGLBFCBPBCD<GAMDJBJJMEG> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private TaskAwaiter<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x220C2A0", Offset = "0x220B6A0", VA = "0x18220C2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x220C8F0", Offset = "0x220BCF0", VA = "0x18220C8F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private struct CENDFNFLCHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public LFMNPBDBKCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public JABLMADMPHA<EPJMFNGLNNN> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public JABLMADMPHA<PKMIDGFKCAI> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public FGLBFCBPBCD<NPNHBKKDMLD> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public FGLBFCBPBCD<CLEIGCGCLHM> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private TaskAwaiter<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x21FC2D0", Offset = "0x21FB6D0", VA = "0x1821FC2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x21FC610", Offset = "0x21FBA10", VA = "0x1821FC610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[CompilerGenerated]
	private struct LAABBAFLHGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public LFMNPBDBKCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public JABLMADMPHA<EPJMFNGLNNN> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public JABLMADMPHA<PKMIDGFKCAI> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public FGLBFCBPBCD<NPNHBKKDMLD> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public FGLBFCBPBCD<CANFCBOLFDP> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private TaskAwaiter<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x2219480", Offset = "0x2218880", VA = "0x182219480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x22197C0", Offset = "0x2218BC0", VA = "0x1822197C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private readonly NPOGACBNNEB CIMEKGEELOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private readonly NDEFHBDPGED GCANOLEMPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private readonly KMIPODNMGGP ABABGKPIMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private readonly AAAIEMIAKCM OFBIEDINOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private readonly BMNJBAHPJDO NIJEBJPBAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private Dictionary<JABLMADMPHA<EPJMFNGLNNN>, PDOBBIKMPEL> KHFLPEONNDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	[CompilerGenerated]
	private Action<JABLMADMPHA<EPJMFNGLNNN>>? KKFFDOHHKGC;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public JABLMADMPHA<PKMIDGFKCAI> KMAADMLLDLH
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x2208E60", Offset = "0x2208260", VA = "0x182208E60", Slot = "4")]
		get
		{
			return default(JABLMADMPHA<PKMIDGFKCAI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public AAAIEMIAKCM JILJODBCIPG
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x21F6D50", Offset = "0x21F6150", VA = "0x1821F6D50", Slot = "5")]
		get
		{
			return default(AAAIEMIAKCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x220B0B0", Offset = "0x220A4B0", VA = "0x18220B0B0")]
	public LFMNPBDBKCI(NPOGACBNNEB DAAJPDFKLAI, NDEFHBDPGED ICMGGGGJNOP, KMIPODNMGGP FIBKJHAGPDN, BMNJBAHPJDO HJBHPKNIFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x220A080", Offset = "0x2209480", VA = "0x18220A080", Slot = "48")]
	public FGLBFCBPBCD<IELMCAKIOEP> MPAFLDOCHJP(FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, FGLBFCBPBCD<GAMDJBJJMEG> MMFEJGDOBPF)
	{
		return default(FGLBFCBPBCD<IELMCAKIOEP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x220AE90", Offset = "0x220A290", VA = "0x18220AE90", Slot = "49")]
	public FGLBFCBPBCD<GGLOIFFDHHN> PJDHCNOMFME(FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, FGLBFCBPBCD<MPANLLKONFK> EHCJDFNAANJ)
	{
		return default(FGLBFCBPBCD<GGLOIFFDHHN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x2207E30", Offset = "0x2207230", VA = "0x182207E30", Slot = "6")]
	public (bool, bool) FHAEMOPCMPI(FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, FGLBFCBPBCD<MPANLLKONFK> AMMEAHPBDLK, FGLBFCBPBCD<GAMDJBJJMEG> LOKHFKKDAEC)
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x2208EC0", Offset = "0x22082C0", VA = "0x182208EC0")]
	public bool JKOGHOFLDBH(FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, [In] GBNHMHDFONC MEFPEBKHCKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x220AC20", Offset = "0x220A020", VA = "0x18220AC20", Slot = "8")]
	public bool PBKDBMAMNCO(FCHCPAMLLED GKHHOKIKEBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x2206C50", Offset = "0x2206050", VA = "0x182206C50", Slot = "9")]
	public bool DENHPMIODNK(LKNAAMBHFDN ECAKMPOJAKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x2206A80", Offset = "0x2205E80", VA = "0x182206A80", Slot = "10")]
	public KKBFEFCDMIL? BMDMLHHDPJA(FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, FGLBFCBPBCD<GAMDJBJJMEG> MMFEJGDOBPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x2208D20", Offset = "0x2208120", VA = "0x182208D20", Slot = "11")]
	public DPLJPGLMGHD? HIEOJIBOCIH(FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, FGLBFCBPBCD<MPANLLKONFK> EHCJDFNAANJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x22087C0", Offset = "0x2207BC0", VA = "0x1822087C0", Slot = "12")]
	public IEnumerable<FGLBFCBPBCD<INIPEGMNBKG>> GHPODAKDPGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x2207DC0", Offset = "0x22071C0", VA = "0x182207DC0", Slot = "13")]
	public string FGJCCHMIFNA(FGLBFCBPBCD<INIPEGMNBKG> GKEMLOFIAFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x22092D0", Offset = "0x22086D0", VA = "0x1822092D0", Slot = "14")]
	public string JNAKEGEMONA(FGLBFCBPBCD<INIPEGMNBKG> GKEMLOFIAFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x220AD90", Offset = "0x220A190", VA = "0x18220AD90")]
	public PDOBBIKMPEL? PEGIOCOJIPK([In] JABLMADMPHA<EPJMFNGLNNN> IEIONDBAINP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x22067B0", Offset = "0x2205BB0", VA = "0x1822067B0")]
	public FGLBFCBPBCD<EPJMFNGLNNN> IJMJKIBHBNE(FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, [In] JABLMADMPHA<EPJMFNGLNNN> CAFIHDMMHPD)
	{
		return default(FGLBFCBPBCD<EPJMFNGLNNN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x2206BD0", Offset = "0x2205FD0", VA = "0x182206BD0", Slot = "26")]
	public FGLBFCBPBCD<EPJMFNGLNNN> DCAPCBBKAGJ(FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, FGLBFCBPBCD<GAMDJBJJMEG> MMFEJGDOBPF)
	{
		return default(FGLBFCBPBCD<EPJMFNGLNNN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x2209810", Offset = "0x2208C10", VA = "0x182209810", Slot = "27")]
	public FGLBFCBPBCD<EPJMFNGLNNN> KHFMHCCGFOP(FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, FGLBFCBPBCD<MPANLLKONFK> EHCJDFNAANJ)
	{
		return default(FGLBFCBPBCD<EPJMFNGLNNN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x2209340", Offset = "0x2208740", VA = "0x182209340")]
	private void JOGFKOAIMPN(JABLMADMPHA<EPJMFNGLNNN> IEIONDBAINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x220A140", Offset = "0x2209540", VA = "0x18220A140")]
	public IEnumerable<PDOBBIKMPEL> NEMAPPHILKM([In] JABLMADMPHA<PKMIDGFKCAI> DAOIPHJHGNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x2206B40", Offset = "0x2205F40", VA = "0x182206B40", Slot = "25")]
	public FGLBFCBPBCD<GAMDJBJJMEG> DAJELOIMIDB(FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, FGLBFCBPBCD<EPJMFNGLNNN> IEIONDBAINP, FGLBFCBPBCD<IELMCAKIOEP> MMFIDABOADB)
	{
		return default(FGLBFCBPBCD<GAMDJBJJMEG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x2209FF0", Offset = "0x22093F0", VA = "0x182209FF0", Slot = "28")]
	public FGLBFCBPBCD<MPANLLKONFK> MOOJBKHINKA(FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, FGLBFCBPBCD<EPJMFNGLNNN> IEIONDBAINP, FGLBFCBPBCD<GGLOIFFDHHN> HLBMMAHCHAM)
	{
		return default(FGLBFCBPBCD<MPANLLKONFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x220A520", Offset = "0x2209920", VA = "0x18220A520")]
	private PDOBBIKMPEL? NLCPOMGBHOJ([In] JABLMADMPHA<EPJMFNGLNNN> IEIONDBAINP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x220A8D0", Offset = "0x2209CD0", VA = "0x18220A8D0")]
	private PDOBBIKMPEL NPDMNHJMKON([In] JABLMADMPHA<EPJMFNGLNNN> IEIONDBAINP, JMGKFHAJOAG ABBPLCKDHFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x2206F80", Offset = "0x2206380", VA = "0x182206F80")]
	public JMGKFHAJOAG? DNDFPGNKJNG([In] JABLMADMPHA<EPJMFNGLNNN> IEIONDBAINP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x2208330", Offset = "0x2207730", VA = "0x182208330")]
	public CIPHLFPOECO? FOLBCBJEODA([In] JABLMADMPHA<PKMIDGFKCAI> DAOIPHJHGNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x2207010", Offset = "0x2206410", VA = "0x182207010", Slot = "20")]
	public IEnumerable<PPAHLNEMJPC> EKCLOMFFCFK(FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x22099E0", Offset = "0x2208DE0", VA = "0x1822099E0", Slot = "21")]
	public bool KPFPOCPAIDD(FGLBFCBPBCD<INIPEGMNBKG> GKEMLOFIAFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x220A560", Offset = "0x2209960", VA = "0x18220A560", Slot = "22")]
	public IEnumerable<GBNHMHDFONC> NLOJGPGPHON(FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, FGLBFCBPBCD<MPANLLKONFK> AMMEAHPBDLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x2208870", Offset = "0x2207C70", VA = "0x182208870", Slot = "23")]
	public IEnumerable<GBNHMHDFONC> GNGDEFIBDPD(FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, FGLBFCBPBCD<GAMDJBJJMEG> LOKHFKKDAEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x2206F00", Offset = "0x2206300", VA = "0x182206F00")]
	public FGLBFCBPBCD<PKMIDGFKCAI> DMIDLKIGJJB([In] JABLMADMPHA<PKMIDGFKCAI> DAOIPHJHGNI)
	{
		return default(FGLBFCBPBCD<PKMIDGFKCAI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x2206A00", Offset = "0x2205E00", VA = "0x182206A00")]
	public FGLBFCBPBCD<PKMIDGFKCAI>? BMBIFHJNKIK([In] JABLMADMPHA<PKMIDGFKCAI> DAOIPHJHGNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x2209890", Offset = "0x2208C90", VA = "0x182209890")]
	private AMKKFMOEIJN? KIADOLINBEC([In] JABLMADMPHA<PKMIDGFKCAI> DAOIPHJHGNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x2208330", Offset = "0x2207730", VA = "0x182208330")]
	private CIPHLFPOECO? HPBCNAOEMMN([In] JABLMADMPHA<PKMIDGFKCAI> DAOIPHJHGNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x2208360", Offset = "0x2207760", VA = "0x182208360", Slot = "32")]
	public JABLMADMPHA<PKMIDGFKCAI> FPKMLBNJNLG(FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI)
	{
		return default(JABLMADMPHA<PKMIDGFKCAI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x22066B0", Offset = "0x2205AB0", VA = "0x1822066B0", Slot = "29")]
	public IEnumerable<MHMKOPIHJHJ> BJBLIBMGIJM(EFGOJHNMAKC CLMMPKKEDFK, bool KLHHNMDPDIK, bool EKMNEMOGJBP, bool BMAAPBCIGON, bool LLMHMKCIDMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x220A220", Offset = "0x2209620", VA = "0x18220A220", Slot = "30")]
	public MHMKOPIHJHJ NGEHPAEKPDG(EFGOJHNMAKC CLMMPKKEDFK, ABLAJBADJIF HGBHDMKNIJA, bool KLHHNMDPDIK, bool EKMNEMOGJBP, bool BMAAPBCIGON, bool LLMHMKCIDMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x2206830", Offset = "0x2205C30", VA = "0x182206830")]
	public PPAHLNEMJPC PMDJMINKIPO(FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, [In] GBNHMHDFONC MEFPEBKHCKK)
	{
		return default(PPAHLNEMJPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x2206CD0", Offset = "0x22060D0", VA = "0x182206CD0", Slot = "33")]
	public GBNHMHDFONC DFLBJEKPPIO(FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, FGLBFCBPBCD<MPANLLKONFK> AMMEAHPBDLK, FGLBFCBPBCD<GAMDJBJJMEG> LOKHFKKDAEC)
	{
		return default(GBNHMHDFONC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x220B040", Offset = "0x220A440", VA = "0x18220B040", Slot = "34")]
	public bool POCBCIGNGFN(FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x2209790", Offset = "0x2208B90", VA = "0x182209790", Slot = "35")]
	public bool KCDNNOJNCJJ(FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, FGLBFCBPBCD<GAMDJBJJMEG> MMFEJGDOBPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x2208DE0", Offset = "0x22081E0", VA = "0x182208DE0", Slot = "36")]
	public bool IEOJNMODJHD(FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, FGLBFCBPBCD<MPANLLKONFK> EHCJDFNAANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x220A100", Offset = "0x2209500", VA = "0x18220A100")]
	public MLIDCCDLMIE<DCDABDCPDPJ.CCGOMLPLGED, FEGHIOJFDLM> NCDMIOGKPPB([In] DCDABDCPDPJ.JFDMEKLFDBC HJEECPNIDIG)
	{
		return default(MLIDCCDLMIE<DCDABDCPDPJ.CCGOMLPLGED, FEGHIOJFDLM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x220AF10", Offset = "0x220A310", VA = "0x18220AF10", Slot = "38")]
	[AsyncStateMachine(typeof(NHAEIMBJGGJ))]
	public Task<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> PJJCPCFHJON(FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, FGLBFCBPBCD<MPANLLKONFK> AMMEAHPBDLK, FGLBFCBPBCD<GAMDJBJJMEG> LOKHFKKDAEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x22093D0", Offset = "0x22087D0", VA = "0x1822093D0", Slot = "39")]
	public MLIDCCDLMIE<EHKOICFFOKA, JPHFAKFKMJL> KABNCLLCFLK(JABLMADMPHA<PKMIDGFKCAI> DAOIPHJHGNI, EHKOICFFOKA LMJCNDKADIF, JKPFCNCELMN FMLKFHOKOBG)
	{
		return default(MLIDCCDLMIE<EHKOICFFOKA, JPHFAKFKMJL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x220A9A0", Offset = "0x2209DA0", VA = "0x18220A9A0", Slot = "40")]
	[AsyncStateMachine(typeof(CENDFNFLCHH))]
	public Task<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> OLIEJKCGPGB(JABLMADMPHA<PKMIDGFKCAI> DAOIPHJHGNI, JABLMADMPHA<EPJMFNGLNNN> COCEIHPEFEJ, FGLBFCBPBCD<NPNHBKKDMLD> GOECFLCKIEH, FGLBFCBPBCD<CLEIGCGCLHM> MMFEJGDOBPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x22070D0", Offset = "0x22064D0", VA = "0x1822070D0", Slot = "41")]
	[AsyncStateMachine(typeof(LAABBAFLHGJ))]
	public Task<MLIDCCDLMIE<OKFEIOHLOGM, FNDOAGAGANG>> ELKNKBEAMLI(JABLMADMPHA<PKMIDGFKCAI> DAOIPHJHGNI, JABLMADMPHA<EPJMFNGLNNN> FODMFADIEJB, FGLBFCBPBCD<NPNHBKKDMLD> KMKKEOGNIJL, FGLBFCBPBCD<CANFCBOLFDP> EHCJDFNAANJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x2208AF0", Offset = "0x2207EF0", VA = "0x182208AF0", Slot = "42")]
	public MKGMKEDJDJH HBMEENLHALH(IEnumerable<FGFJJKFMCDJ> BNJAJJDKNIL)
	{
		return default(MKGMKEDJDJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x220AB00", Offset = "0x2209F00", VA = "0x18220AB00", Slot = "43")]
	public MKGMKEDJDJH OPDNMOGJCMA()
	{
		return default(MKGMKEDJDJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x2207C10", Offset = "0x2207010", VA = "0x182207C10")]
	private NPKFLJDJEBP FBAOOBNKLPJ(OFBIHDMHFPE GDHKANAEBFB, FGLBFCBPBCD<PKMIDGFKCAI> FCOGLBEJEHH, IEnumerable<JABLMADMPHA<PKMIDGFKCAI>> NJAEGJIPLIP, IEnumerable<JABLMADMPHA<EPJMFNGLNNN>> NKPHFOJMCNG)
	{
		return default(NPKFLJDJEBP);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x22078F0", Offset = "0x2206CF0", VA = "0x1822078F0", Slot = "44")]
	public NPKFLJDJEBP FBAOOBNKLPJ(OFBIHDMHFPE GDHKANAEBFB, FGLBFCBPBCD<PKMIDGFKCAI> FCOGLBEJEHH, IEnumerable<JABLMADMPHA<EPJMFNGLNNN>> NKPHFOJMCNG, IEnumerable<FGFJJKFMCDJ> BNJAJJDKNIL)
	{
		return default(NPKFLJDJEBP);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x22083D0", Offset = "0x22077D0", VA = "0x1822083D0")]
	private static IEnumerable<JABLMADMPHA<PKMIDGFKCAI>> GBFANODHOCH(IEnumerable<FGFJJKFMCDJ> BNJAJJDKNIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x2209A70", Offset = "0x2208E70", VA = "0x182209A70")]
	private IEnumerable<JABLMADMPHA<EPJMFNGLNNN>> KPHAHDNIICK(IEnumerable<FGFJJKFMCDJ> BNJAJJDKNIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x2209950", Offset = "0x2208D50", VA = "0x182209950", Slot = "45")]
	public List<ALJFILFCCCH> KIIHFEBOPIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x2207230", Offset = "0x2206630", VA = "0x182207230")]
	public (List<ALJFILFCCCH>, bool) EOHNHAONJCP([In] IMGGIJIKKCH BELIPNCEOEA, string JCPOMHNJOIE, [In] NPADFMEMAMN JHKDINEMLAG, MDFDGPDDILG BEHEOEGJKMO, FGLGPALEHMB HFAADCIFMAM)
	{
		return default((List<ALJFILFCCCH>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x2209F00", Offset = "0x2209300", VA = "0x182209F00", Slot = "47")]
	public bool LJIBKAMKILD(FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x2208CC0", Offset = "0x22080C0", VA = "0x182208CC0")]
	internal void HCJPEBBHJIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x22069A0", Offset = "0x2205DA0", VA = "0x1822069A0")]
	internal Task BLKNJJMKDFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x220A130", Offset = "0x2209530", VA = "0x18220A130", Slot = "7")]
	private bool NBDIFMHEJPB(FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, [In] GBNHMHDFONC MEFPEBKHCKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x2208330", Offset = "0x2207730", VA = "0x182208330", Slot = "15")]
	private CIPHLFPOECO NJCBGHOAOGD([In] JABLMADMPHA<PKMIDGFKCAI> DAOIPHJHGNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x2206F00", Offset = "0x2206300", VA = "0x182206F00", Slot = "16")]
	private FGLBFCBPBCD<PKMIDGFKCAI> PMENEMBLNPM([In] JABLMADMPHA<PKMIDGFKCAI> DAOIPHJHGNI)
	{
		return default(FGLBFCBPBCD<PKMIDGFKCAI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x2206A00", Offset = "0x2205E00", VA = "0x182206A00", Slot = "17")]
	private FGLBFCBPBCD<PKMIDGFKCAI>? FFPLHANMBJE([In] JABLMADMPHA<PKMIDGFKCAI> DAOIPHJHGNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x22064F0", Offset = "0x22058F0", VA = "0x1822064F0", Slot = "18")]
	private PDOBBIKMPEL APOIFHBPKOE([In] JABLMADMPHA<EPJMFNGLNNN> IEIONDBAINP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x22067B0", Offset = "0x2205BB0", VA = "0x1822067B0", Slot = "19")]
	private FGLBFCBPBCD<EPJMFNGLNNN> BKEBJPMEJAN(FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, [In] JABLMADMPHA<EPJMFNGLNNN> CAFIHDMMHPD)
	{
		return default(FGLBFCBPBCD<EPJMFNGLNNN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x220A7F0", Offset = "0x2209BF0", VA = "0x18220A7F0", Slot = "24")]
	private IEnumerable<PDOBBIKMPEL> NNGLIBNPOPG([In] JABLMADMPHA<PKMIDGFKCAI> DAOIPHJHGNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x2206830", Offset = "0x2205C30", VA = "0x182206830", Slot = "31")]
	private PPAHLNEMJPC BKIBDIIJJLL(FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, [In] GBNHMHDFONC MEFPEBKHCKK)
	{
		return default(PPAHLNEMJPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x220A100", Offset = "0x2209500", VA = "0x18220A100", Slot = "37")]
	private MLIDCCDLMIE<DCDABDCPDPJ.CCGOMLPLGED, FEGHIOJFDLM> NANDMNLBMKA([In] DCDABDCPDPJ.JFDMEKLFDBC HJEECPNIDIG)
	{
		return default(MLIDCCDLMIE<DCDABDCPDPJ.CCGOMLPLGED, FEGHIOJFDLM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x2206650", Offset = "0x2205A50", VA = "0x182206650", Slot = "46")]
	private (List<ALJFILFCCCH>, bool) BHCFBLIGKMF([In] IMGGIJIKKCH BELIPNCEOEA, string JCPOMHNJOIE, [In] NPADFMEMAMN JHKDINEMLAG, MDFDGPDDILG BEHEOEGJKMO, FGLGPALEHMB HFAADCIFMAM)
	{
		return default((List<ALJFILFCCCH>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x220ACA0", Offset = "0x220A0A0", VA = "0x18220ACA0")]
	[CompilerGenerated]
	private PDOBBIKMPEL PCPAKDGNHKF(JMGKFHAJOAG INBIGDGMENB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x2209250", Offset = "0x2208650", VA = "0x182209250")]
	[CompilerGenerated]
	private JKLIHCCMFDJ JLKNFALCLAB(ENEPLLMIFHM INBIGDGMENB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x22065E0", Offset = "0x22059E0", VA = "0x1822065E0")]
	[CompilerGenerated]
	private JMGKFHAJOAG BGKOOMJGDPD(JABLMADMPHA<EPJMFNGLNNN> INBIGDGMENB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x2208750", Offset = "0x2207B50", VA = "0x182208750")]
	[CompilerGenerated]
	private AMKKFMOEIJN GGNKKKINGNH(JABLMADMPHA<PKMIDGFKCAI> INBIGDGMENB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class JKLIHCCMFDJ : MHMKOPIHJHJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private struct DFNOBDINNHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<FGLBFCBPBCD<EEBKBHCGBCM>, FNDOAGAGANG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public JKLIHCCMFDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public JABLMADMPHA<PKMIDGFKCAI> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public JABLMADMPHA<EPJMFNGLNNN> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public FGLBFCBPBCD<NPNHBKKDMLD> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private TaskAwaiter<MLIDCCDLMIE<FGLBFCBPBCD<EEBKBHCGBCM>, FNDOAGAGANG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x2216340", Offset = "0x2215740", VA = "0x182216340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x22165C0", Offset = "0x22159C0", VA = "0x1822165C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct LEKINGPGAEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<FGLBFCBPBCD<NLOPGHOEPOD>, FNDOAGAGANG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public JKLIHCCMFDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public JABLMADMPHA<PKMIDGFKCAI> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public JABLMADMPHA<EPJMFNGLNNN> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public FGLBFCBPBCD<NPNHBKKDMLD> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private TaskAwaiter<MLIDCCDLMIE<FGLBFCBPBCD<NLOPGHOEPOD>, FNDOAGAGANG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x2219980", Offset = "0x2218D80", VA = "0x182219980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x2219C00", Offset = "0x2219000", VA = "0x182219C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	private readonly ENEPLLMIFHM KALLJPNJCLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	private readonly NDEFHBDPGED GCANOLEMPBI;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public TypeKey PIEINFDMJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x952F70", Offset = "0x952370", VA = "0x180952F70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public string KGPALOLEKEO
	{
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x2216A30", Offset = "0x2215E30", VA = "0x182216A30", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public ENEPLLMIFHM CHFLMKAMGDE
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x22193E0", Offset = "0x22187E0", VA = "0x1822193E0")]
	public JKLIHCCMFDJ(ENEPLLMIFHM IIKOJDCGGKM, NDEFHBDPGED ICMGGGGJNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x2219100", Offset = "0x2218500", VA = "0x182219100", Slot = "6")]
	[AsyncStateMachine(typeof(DFNOBDINNHO))]
	public Task<MLIDCCDLMIE<FGLBFCBPBCD<EEBKBHCGBCM>, FNDOAGAGANG>> KDLFMPIEJOD(JABLMADMPHA<PKMIDGFKCAI> DAOIPHJHGNI, JABLMADMPHA<EPJMFNGLNNN> IEIONDBAINP, FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI, string ADANIHOIEKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x2219270", Offset = "0x2218670", VA = "0x182219270", Slot = "7")]
	[AsyncStateMachine(typeof(LEKINGPGAEN))]
	public Task<MLIDCCDLMIE<FGLBFCBPBCD<NLOPGHOEPOD>, FNDOAGAGANG>> LCJFFMCHCJN(JABLMADMPHA<PKMIDGFKCAI> DAOIPHJHGNI, JABLMADMPHA<EPJMFNGLNNN> IEIONDBAINP, FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI, string ADANIHOIEKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class EHPBCMKMMMM : HBIFGMFFHHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private readonly ENEPLLMIFHM KECJEOHFKGE;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private static readonly HashSet<ENEPLLMIFHM> EKECBJBOLBG;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private static readonly HashSet<ENEPLLMIFHM> KNAPBGDPJAN;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private static readonly HashSet<ENEPLLMIFHM> PGPLPJFMNOP;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public TypeKey NDKJAMPIIHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x2217C20", Offset = "0x2217020", VA = "0x182217C20", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool FNOIMOPBAOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x2217C10", Offset = "0x2217010", VA = "0x182217C10", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool ONIOJDHDACM
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x2217C70", Offset = "0x2217070", VA = "0x182217C70", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool NHHLDFIKICG
	{
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x2217B90", Offset = "0x2216F90", VA = "0x182217B90", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x22167C0", Offset = "0x2215BC0", VA = "0x1822167C0")]
	public bool OKDOCKLEMJA(string LIHHDPOHLDK, [Out] GOAGHLBHMGN CPHMPMKFGGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x8AF9B0", Offset = "0x8AEDB0", VA = "0x1808AF9B0")]
	public EHPBCMKMMMM(ENEPLLMIFHM GDIPKBJJCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x2216630", Offset = "0x2215A30", VA = "0x182216630")]
	internal static TypeKey ODMAHMFJLHD(ENEPLLMIFHM LGJDMOCCBDP)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x2216A30", Offset = "0x2215E30", VA = "0x182216A30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public readonly struct LABPNFPBMMH : OOFFKPOODLA.MEHBAPENJOF<MMPFCBBACAJ, OKFEIOHLOGM>
{
	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x2219920", Offset = "0x2218D20", VA = "0x182219920", Slot = "4")]
	public int MOFLKHLNIAJ(OKFEIOHLOGM PAHNKMKPPCD, MMPFCBBACAJ MDOOJHKFGMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x22198F0", Offset = "0x2218CF0", VA = "0x1822198F0", Slot = "5")]
	public MMPFCBBACAJ LKHMBHMKAAB(OKFEIOHLOGM PAHNKMKPPCD, MMPFCBBACAJ MDOOJHKFGMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x2219850", Offset = "0x2218C50", VA = "0x182219850", Slot = "6")]
	public MMPFCBBACAJ BNFFOPDJGBC(OKFEIOHLOGM PAHNKMKPPCD, MMPFCBBACAJ MDOOJHKFGMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x2219880", Offset = "0x2218C80", VA = "0x182219880", Slot = "7")]
	public IReadOnlyList<MMPFCBBACAJ> DOMIIFFMJDO(OKFEIOHLOGM PAHNKMKPPCD, MMPFCBBACAJ MDOOJHKFGMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x22198C0", Offset = "0x2218CC0", VA = "0x1822198C0", Slot = "8")]
	public MMPFCBBACAJ[] IGLBLEAAJIC(OKFEIOHLOGM PAHNKMKPPCD, MMPFCBBACAJ MDOOJHKFGMP, int BLCFINBJLND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x2219940", Offset = "0x2218D40", VA = "0x182219940", Slot = "9")]
	public bool OHLCCLGDMLF(OKFEIOHLOGM PAHNKMKPPCD, MMPFCBBACAJ MDOOJHKFGMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x2219900", Offset = "0x2218D00", VA = "0x182219900", Slot = "10")]
	public bool MKPBADFDIJK(OKFEIOHLOGM PAHNKMKPPCD, MMPFCBBACAJ MDOOJHKFGMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x22198D0", Offset = "0x2218CD0", VA = "0x1822198D0", Slot = "11")]
	public bool JKJLFJJAGHH(OKFEIOHLOGM PAHNKMKPPCD, MMPFCBBACAJ MDOOJHKFGMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x2219830", Offset = "0x2218C30", VA = "0x182219830", Slot = "12")]
	public bool AEAKBEBNFED(OKFEIOHLOGM PAHNKMKPPCD, MMPFCBBACAJ MDOOJHKFGMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x22198A0", Offset = "0x2218CA0", VA = "0x1822198A0", Slot = "13")]
	public bool FJALDLBCPBA(OKFEIOHLOGM FMEBGPNKMAK, MMPFCBBACAJ MDOOJHKFGMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x2219960", Offset = "0x2218D60", VA = "0x182219960", Slot = "14")]
	public bool OOICEPJLAPA(OKFEIOHLOGM PAHNKMKPPCD, MMPFCBBACAJ MDOOJHKFGMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public abstract class CIFPLMFMBJE : GILIOFOOLBA
{
	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public IHBEENLFKBG.ECCLMOOEBCF AMMILFAGLFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x22162F0", Offset = "0x22156F0", VA = "0x1822162F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public abstract JPDGKKEBNJD.LEPFDOIFJNA MPGKGNACDJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public abstract NPOGACBNNEB.ODAOEHONNOG BDGMIDJHGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public abstract OEBHBKDNBDG.NFMIJAKBECH BKFGDIMFICG
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public PBBGFJIIJDE.CNELGLEOHLI<MHKGHIJEKIM, MMPFCBBACAJ, NPOGACBNNEB> JOLMNNLEGOO
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x22162A0", Offset = "0x22156A0", VA = "0x1822162A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public abstract LFPDLPFKFJE OOLDKCALAJA
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public abstract LPCOFCPLEOL LDLJHHAKFCC
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public abstract KKDAAEBGGLO JONEJEODGFH
	{
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public abstract FPNMOGPDGAA IAPBEAOKPID
	{
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public abstract CHGEHHOBBFA IPHJFKCFPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	protected CIFPLMFMBJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class AMIBMIPNIKM : FHACJKJNHNK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct MLEGJFFFBKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<object, FNDOAGAGANG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public AMIBMIPNIKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public MMPFCBBACAJ action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private TaskAwaiter<MLIDCCDLMIE<object, FNDOAGAGANG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x2219E50", Offset = "0x2219250", VA = "0x182219E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x221A0F0", Offset = "0x22194F0", VA = "0x18221A0F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct INBCDCCLLHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<KCOOFONOLPB, FNDOAGAGANG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public AMIBMIPNIKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public IReadOnlyList<MMPFCBBACAJ> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private TaskAwaiter<MLIDCCDLMIE<object, FNDOAGAGANG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x2218B30", Offset = "0x2217F30", VA = "0x182218B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x2218EB0", Offset = "0x22182B0", VA = "0x182218EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	private readonly LMNOHBMPKBL PFGFBDIFMPJ;

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x8AF9B0", Offset = "0x8AEDB0", VA = "0x1808AF9B0")]
	public AMIBMIPNIKM(LMNOHBMPKBL ILJMGJGDGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x2216110", Offset = "0x2215510", VA = "0x182216110")]
	[AsyncStateMachine(typeof(MLEGJFFFBKP))]
	private Task<MLIDCCDLMIE<object, FNDOAGAGANG>> GLGKCCLCIGP(MMPFCBBACAJ MDOOJHKFGMP, bool COINEAOGNMD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x2215FE0", Offset = "0x22153E0", VA = "0x182215FE0", Slot = "4")]
	[AsyncStateMachine(typeof(INBCDCCLLHG))]
	public Task<MLIDCCDLMIE<KCOOFONOLPB, FNDOAGAGANG>> AOJIJCFCLMJ(IReadOnlyList<MMPFCBBACAJ> LEPHFNPNBLA, bool COINEAOGNMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public struct HAGIKLNJCBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	internal JKAHICBEDBK<PCOGICGICJG, MMPFCBBACAJ, MCGGJOMLIPN> KECJEOHFKGE;

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x21E9B70", Offset = "0x21E8F70", VA = "0x1821E9B70")]
	private HAGIKLNJCBF([In] JKAHICBEDBK<PCOGICGICJG, MMPFCBBACAJ, MCGGJOMLIPN> FKIOCGHNBFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x2218AD0", Offset = "0x2217ED0", VA = "0x182218AD0")]
	public static HAGIKLNJCBF AALKPJMFIHM()
	{
		return default(HAGIKLNJCBF);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public static class ADILMIPOEIP
{
	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x9E76C0", Offset = "0x9E6AC0", VA = "0x1809E76C0")]
	public static JKAHICBEDBK<PCOGICGICJG, MMPFCBBACAJ, MCGGJOMLIPN> ANEANNKPKNP(this HAGIKLNJCBF MBGHIKEGJAA)
	{
		return default(JKAHICBEDBK<PCOGICGICJG, MMPFCBBACAJ, MCGGJOMLIPN>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public struct MCGGJOMLIPN : KFCOPENCPOJ.NMEEHGFAPKD<PCOGICGICJG, MMPFCBBACAJ>
{
	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x2219C70", Offset = "0x2219070", VA = "0x182219C70", Slot = "5")]
	public MMPFCBBACAJ HBOFNMAIGPJ(PCOGICGICJG[] PAJCECKOKNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x1AA4AF0", Offset = "0x1AA3EF0", VA = "0x181AA4AF0")]
	public int GLDEJJFNBPI([In] PCOGICGICJG LPFLJGNNGIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x1AA4AF0", Offset = "0x1AA3EF0", VA = "0x181AA4AF0", Slot = "4")]
	private int AOKLEKLEOBC([In] PCOGICGICJG ANGIAFOLOMG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public struct AOBFMICPLNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	internal MCIKJAKKLLL<AEPMFMNPHBN, MMPFCBBACAJ, JGDHOMHCELD> KECJEOHFKGE;

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x21E9B70", Offset = "0x21E8F70", VA = "0x1821E9B70")]
	private AOBFMICPLNG([In] MCIKJAKKLLL<AEPMFMNPHBN, MMPFCBBACAJ, JGDHOMHCELD> LFLBKLPJOCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x2216240", Offset = "0x2215640", VA = "0x182216240")]
	public static AOBFMICPLNG AALKPJMFIHM()
	{
		return default(AOBFMICPLNG);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public static class DOEOPKCHMIL
{
	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x9E76C0", Offset = "0x9E6AC0", VA = "0x1809E76C0")]
	public static MCIKJAKKLLL<AEPMFMNPHBN, MMPFCBBACAJ, JGDHOMHCELD> ANEANNKPKNP(this AOBFMICPLNG MBGHIKEGJAA)
	{
		return default(MCIKJAKKLLL<AEPMFMNPHBN, MMPFCBBACAJ, JGDHOMHCELD>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public struct JGDHOMHCELD : CNMJHEJFONM.JMELFGFLDAH<AEPMFMNPHBN, MMPFCBBACAJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x1AA4AF0", Offset = "0x1AA3EF0", VA = "0x181AA4AF0")]
	public int OJACEPJDOPD([In] AEPMFMNPHBN LPFLJGNNGIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x2218F20", Offset = "0x2218320", VA = "0x182218F20", Slot = "5")]
	public MMPFCBBACAJ MLNPIBEGOHN(AEPMFMNPHBN[] KNAGKAMJEDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x1AA4AF0", Offset = "0x1AA3EF0", VA = "0x181AA4AF0", Slot = "4")]
	private int IEMGFAEHBOI([In] AEPMFMNPHBN LPFLJGNNGIF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public class FKHBIHDIPDL : IDBHBLPOJHF, FEGHIOJFDLM, FNDOAGAGANG, JPHFAKFKMJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private readonly JPHFAKFKMJL? HPOFFJMCNMA;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public FNMIJIAPFMH EJFPBPAJBAO
	{
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x8AE510", Offset = "0x8AD910", VA = "0x1808AE510", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(FNMIJIAPFMH);
		}
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x8AE520", Offset = "0x8AD920", VA = "0x1808AE520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public override JPHFAKFKMJL? CHLAGEGCGOG
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x2217D90", Offset = "0x2217190", VA = "0x182217D90", Slot = "7")]
	public override string KIGPPELGDEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x2218070", Offset = "0x2217470", VA = "0x182218070")]
	private FKHBIHDIPDL(FNMIJIAPFMH DDBAKACFGMN, JPHFAKFKMJL? APENDAOMGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x2217F80", Offset = "0x2217380", VA = "0x182217F80")]
	public static FKHBIHDIPDL OGCOFMJHPDA(JPHFAKFKMJL APENDAOMGPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x2217F10", Offset = "0x2217310", VA = "0x182217F10")]
	public static FKHBIHDIPDL LMCEFPIJKND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x2218000", Offset = "0x2217400", VA = "0x182218000")]
	public static FKHBIHDIPDL PEGCMPOKCOM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class PKNHAFBPJAE
{
	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x30167A0", Offset = "0x3015BA0", VA = "0x1830167A0")]
	public static MLIDCCDLMIE<TOk, FEGHIOJFDLM> GFBEPGGDIPC<TOk>([In] this MLIDCCDLMIE<TOk, FEGHIOJFDLM> MBGHIKEGJAA, JPHFAKFKMJL APENDAOMGPN) where TOk : notnull
	{
		return default(MLIDCCDLMIE<TOk, FEGHIOJFDLM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x3016890", Offset = "0x3015C90", VA = "0x183016890")]
	public static MLIDCCDLMIE<TOk?, FEGHIOJFDLM?> HLHPFJKBPPB<TOk>([In] this MLIDCCDLMIE<TOk, FEGHIOJFDLM> MBGHIKEGJAA)
	{
		return default(MLIDCCDLMIE<TOk, FEGHIOJFDLM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x3016980", Offset = "0x3015D80", VA = "0x183016980")]
	public static MLIDCCDLMIE<TOk?, FEGHIOJFDLM?> PIONKBCJDIB<TOk>([In] this MLIDCCDLMIE<TOk, FEGHIOJFDLM> MBGHIKEGJAA)
	{
		return default(MLIDCCDLMIE<TOk, FEGHIOJFDLM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public interface LFPDLPFKFJE
{
	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EAIFNNALFDC([In] MLIDCCDLMIE<OKFEIOHLOGM, JPHFAKFKMJL> CIFMGKBFCHA);
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public static class ONEGFPDCHAH
{
	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x2FFA810", Offset = "0x2FF9C10", VA = "0x182FFA810")]
	public static bool EAIFNNALFDC<TOk, TErr>(this LFPDLPFKFJE MBGHIKEGJAA, [In] MLIDCCDLMIE<TOk, TErr> CIFMGKBFCHA) where TOk : notnull where TErr : notnull, JPHFAKFKMJL
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public interface LPCOFCPLEOL
{
	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	LBMNLBLNBPN JFFDMPLOKKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public interface KKDAAEBGGLO
{
	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CBPMOKFJJOF GMPGMDNCAKJ(int GEBIPDLOLCB);
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public interface DPNKHINEDLF
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	string BKJCNMKILGO
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public interface ELLODAAHNLB
{
	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KFFAKFDGDKC? GDNBGKAKOCA(FGLBFCBPBCD<NPNHBKKDMLD> EEHAGFHKLKI);
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public interface MEJNEPDLOKP
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	string BKJCNMKILGO
	{
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public interface KFFAKFDGDKC
{
	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	string BKJCNMKILGO
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MEJNEPDLOKP? MKOENNAKFOJ(FGLBFCBPBCD<EEBKBHCGBCM> KIDFOJNAAAB);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DPNKHINEDLF? LNGCFFEHKLE(FGLBFCBPBCD<NLOPGHOEPOD> PJPFEICFNKD);
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public interface FPNMOGPDGAA
{
	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> IFNMLICPGAN(string LIHHDPOHLDK, string JCPOMHNJOIE);
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public interface CHGEHHOBBFA
{
	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ELLODAAHNLB? LKBFMGMHJPG([In] JABLMADMPHA<DJFIOODIFAG> HLNONALPAAP);
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class GLPMLIKPCOH
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	private struct GKMMCJPGIEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public int LGPOLAJNCMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public HPGJHIFKKPI? PIDLJAOFDJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public HPGJHIFKKPI? ILGAMFDHHDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public readonly List<MMPFCBBACAJ> MIBBPGEGCOM;

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x2218170", Offset = "0x2217570", VA = "0x182218170")]
		private GKMMCJPGIEL(int AEAHMAMPNLO, HPGJHIFKKPI? DAGEEMICANE, HPGJHIFKKPI? AEAMOEIBOKB, List<MMPFCBBACAJ> LEPHFNPNBLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x22180B0", Offset = "0x22174B0", VA = "0x1822180B0")]
		public static GKMMCJPGIEL AALKPJMFIHM()
		{
			return default(GKMMCJPGIEL);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private readonly IDGNMDLNIIO<GKMMCJPGIEL> EBNIJHBLJHO;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public static GLPMLIKPCOH FKMJLLKHOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x22184B0", Offset = "0x22178B0", VA = "0x1822184B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool ABOHJICIBBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x918830", Offset = "0x917C30", VA = "0x180918830")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x9822A0", Offset = "0x9816A0", VA = "0x1809822A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x2218500", Offset = "0x2217900", VA = "0x182218500")]
	public void GLINBENAAIE(LEIHDBBDJBH AEAMOEIBOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x22181C0", Offset = "0x22175C0", VA = "0x1822181C0")]
	public void AEPGPLCNFKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x22185C0", Offset = "0x22179C0", VA = "0x1822185C0")]
	private static string? GNOPGIKLLKE([In] GKMMCJPGIEL PBDMAGGDKEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x2218A20", Offset = "0x2217E20", VA = "0x182218A20")]
	public GLPMLIKPCOH()
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
