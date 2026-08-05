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
		[Cpp2IlInjected.Address(RVA = "0x78D520", Offset = "0x78C920", VA = "0x18078D520")]
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
		[Cpp2IlInjected.Address(RVA = "0x1C13800", Offset = "0x1C12C00", VA = "0x181C13800")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78E300", Offset = "0x78D700", VA = "0x18078E300")]
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
		[Cpp2IlInjected.Address(RVA = "0x78E340", Offset = "0x78D740", VA = "0x18078E340")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class MGIIALDDNBJ : IDisposable, PKLLFPMNDCA, EJGCHDICGHF, MOGFPOGFDEP, HFFNGEKGPKB, NBBICNALEIN
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class GEEIOJLLIAM : DDKOGNBIIEP
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int JDLEIIFNFOG
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1C0B190", Offset = "0x1C0A590", VA = "0x181C0B190", Slot = "5")]
		public PJLBJGBCJII FGPFDDBHLPA(BDBGKAHDKMI.AKAKNPELNKP KELDMPHCCLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void GLOIBAHELGB();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void HPFPJFLHEAB();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		protected GEEIOJLLIAM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface DDKOGNBIIEP
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int JDLEIIFNFOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		PJLBJGBCJII FGPFDDBHLPA(BDBGKAHDKMI.AKAKNPELNKP KELDMPHCCLC);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void GLOIBAHELGB();

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void HPFPJFLHEAB();
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct KCNMONHPCFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly PBLGPDHPCBC<PIKOLKDMDCL, LCJOHDOCEBL, MGIIALDDNBJ, OJLPDABNGCI.LHGAIJCJEMO<PIKOLKDMDCL, LCJOHDOCEBL, MGIIALDDNBJ>> ABOJMBBIHIM;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1C10110", Offset = "0x1C0F510", VA = "0x181C10110")]
		internal KCNMONHPCFE(PBLGPDHPCBC<PIKOLKDMDCL, LCJOHDOCEBL, MGIIALDDNBJ, OJLPDABNGCI.LHGAIJCJEMO<PIKOLKDMDCL, LCJOHDOCEBL, MGIIALDDNBJ>> GHADCFDOJAA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class DIEEAEMPGBA : OJLPDABNGCI.LHGAIJCJEMO<PIKOLKDMDCL, LCJOHDOCEBL, MGIIALDDNBJ>
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly DIEEAEMPGBA OMCMBELJBID;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		private DIEEAEMPGBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x93A110", Offset = "0x939510", VA = "0x18093A110", Slot = "4")]
		public PIKOLKDMDCL HIILFDGPLOL(LCJOHDOCEBL CLFMFOEGLFG)
		{
			return default(PIKOLKDMDCL);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
		public void JEGAMOFFBDM(MGIIALDDNBJ JMNDOLBKAMN, LCJOHDOCEBL PAFFKHOCLGN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct NDNJKBPDEGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public PPHKPIDMIPE<PIKOLKDMDCL, LCJOHDOCEBL, MGIIALDDNBJ, OJLPDABNGCI.LHGAIJCJEMO<PIKOLKDMDCL, LCJOHDOCEBL, MGIIALDDNBJ>> ABOJMBBIHIM;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1C13790", Offset = "0x1C12B90", VA = "0x181C13790")]
		internal NDNJKBPDEGF(PPHKPIDMIPE<PIKOLKDMDCL, LCJOHDOCEBL, MGIIALDDNBJ, OJLPDABNGCI.LHGAIJCJEMO<PIKOLKDMDCL, LCJOHDOCEBL, MGIIALDDNBJ>> GHADCFDOJAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1C13740", Offset = "0x1C12B40", VA = "0x181C13740")]
		public static NDNJKBPDEGF CLFIPFKIGEN()
		{
			return default(NDNJKBPDEGF);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct DEEMFIMOGCL : FJCNHIKCJBH.MPHHBHCLNBJ<FLPDFBHLNEH, LCJOHDOCEBL, MGIIALDDNBJ>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct ICBDNEINPNL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public AsyncTaskMethodBuilder<MEEAMGFNJIM<object, DBNOAAMPCCP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public MGIIALDDNBJ receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public LCJOHDOCEBL action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public DEEMFIMOGCL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private TaskAwaiter<MEEAMGFNJIM<object, DBNOAAMPCCP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x1C0E8E0", Offset = "0x1C0DCE0", VA = "0x181C0E8E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x1C0EAC0", Offset = "0x1C0DEC0", VA = "0x181C0EAC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x93A110", Offset = "0x939510", VA = "0x18093A110", Slot = "4")]
		public OKFPGADAGCG<FLPDFBHLNEH> IMEJIMFFAEK(MGIIALDDNBJ EIDGHHFIPHF)
		{
			return default(OKFPGADAGCG<FLPDFBHLNEH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1C04680", Offset = "0x1C03A80", VA = "0x181C04680", Slot = "5")]
		[AsyncStateMachine(typeof(ICBDNEINPNL))]
		public Task<MEEAMGFNJIM<object, DBNOAAMPCCP>> BICAKAGMPEO(MGIIALDDNBJ EIDGHHFIPHF, LCJOHDOCEBL PAFFKHOCLGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1C047B0", Offset = "0x1C03BB0", VA = "0x181C047B0", Slot = "6")]
		public LCJOHDOCEBL[] IAFAEEEMPIE(MGIIALDDNBJ EIDGHHFIPHF)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct INFMFIGLAKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<MEEAMGFNJIM<bool, DBNOAAMPCCP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public MGIIALDDNBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public BOGJDKIJOLK rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public OCFHMGCGDAI circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public CMFAAJONIFD superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private TaskAwaiter<MEEAMGFNJIM<bool, DBNOAAMPCCP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1C0EF20", Offset = "0x1C0E320", VA = "0x181C0EF20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1C0F1A0", Offset = "0x1C0E5A0", VA = "0x181C0F1A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct DCBPNPPLDGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder<MEEAMGFNJIM<bool, DBNOAAMPCCP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public MGIIALDDNBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private TaskAwaiter<MEEAMGFNJIM<bool, DBNOAAMPCCP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1C04390", Offset = "0x1C03790", VA = "0x181C04390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1C04610", Offset = "0x1C03A10", VA = "0x181C04610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct ONLENEMEHHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public MGIIALDDNBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private TaskAwaiter<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1C163B0", Offset = "0x1C157B0", VA = "0x181C163B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1C16590", Offset = "0x1C15990", VA = "0x181C16590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct EMFPIHLNDAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AsyncTaskMethodBuilder<MEEAMGFNJIM<object, DBNOAAMPCCP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public MGIIALDDNBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public LCJOHDOCEBL action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<MEEAMGFNJIM<object, DBNOAAMPCCP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1C06CD0", Offset = "0x1C060D0", VA = "0x181C06CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1C06EC0", Offset = "0x1C062C0", VA = "0x181C06EC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct FLEAPFGIJLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public MGIIALDDNBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<MEEAMGFNJIM<bool, DBNOAAMPCCP>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1C0A930", Offset = "0x1C09D30", VA = "0x181C0A930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1C0B120", Offset = "0x1C0A520", VA = "0x181C0B120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly OKFPGADAGCG<FLPDFBHLNEH> DAFBAFPAOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly KCNMONHPCFE MHDLLKEFNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly BFFLAGALKLM MFGJFPJAPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly BJEONLLPMDM IBEJPPJAKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly NENAKDOFDJC.IFMFEFIBPIH DLPIKLDBPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly PGKMFABMOOP PJIAEOJLODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly LIPNNCDJBGB AGHFCKEJCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly DOCBHODGPBF CFHDEFMMOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly FKCEHHIACKL NCLGOBJPJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private MIEHHDMGHFO CLIMPGPJMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private BECPAMCPDBM NLPHIDAPOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal readonly BFFLAGALKLM.HOHBHKKGHMB GMJBOHJGLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly MPMPJGCNOEF MHPOFCKNLID;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public BFFLAGALKLM LCMPKPGJKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1C12BB0", Offset = "0x1C11FB0", VA = "0x181C12BB0")]
		get
		{
			return default(BFFLAGALKLM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal DDKOGNBIIEP FOCGINPMEAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1C12790", Offset = "0x1C11B90", VA = "0x181C12790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal PJLBJGBCJII JNJLHAFPLCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7690D0", Offset = "0x7684D0", VA = "0x1807690D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x769100", Offset = "0x768500", VA = "0x180769100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool KLJALALCPJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x920760", Offset = "0x91FB60", VA = "0x180920760")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x91FFD0", Offset = "0x91F3D0", VA = "0x18091FFD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public BCIHBAFPMEL LOCLCDAECPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7653F0", Offset = "0x7647F0", VA = "0x1807653F0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ACFHIJIGPFG GFMKNMMOMFG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8877D0", Offset = "0x886BD0", VA = "0x1808877D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public MIJGGABCNJJ IEJCACLPBNN
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x769120", Offset = "0x768520", VA = "0x180769120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public EPPDJMDOLMG KGFPKMNHJMB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x824280", Offset = "0x823680", VA = "0x180824280", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private NICPLMDNOBF? COKJPNDKNFH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1C12990", Offset = "0x1C11D90", VA = "0x181C12990", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private AAIJHKLJJJE? PIHOJPMOJAF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1C127E0", Offset = "0x1C11BE0", VA = "0x181C127E0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1C12CE0", Offset = "0x1C120E0", VA = "0x181C12CE0")]
	private MGIIALDDNBJ(BJEONLLPMDM KDDNMNODBLK, OKFPGADAGCG<FLPDFBHLNEH> PAHAEGCNKGC, KCNMONHPCFE BPBCPJIMFCM, BFFLAGALKLM GEFLJJFNGLO, PJLBJGBCJII FBGBGEJBECH, [In] NENAKDOFDJC.IFMFEFIBPIH GIEGCLLFJDK, BFFLAGALKLM.HOHBHKKGHMB POMIBOHHKOA, MPMPJGCNOEF DPJLNMMLCPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1C11B10", Offset = "0x1C10F10", VA = "0x181C11B10")]
	public static MGIIALDDNBJ CLFIPFKIGEN(BJEONLLPMDM KELDMPHCCLC, BFFLAGALKLM.EDEGIKFKOOL OGKCKMPGAHD, OKFPGADAGCG<FLPDFBHLNEH> PAHAEGCNKGC, OKFPGADAGCG<DECFMIBEFJI> BAKCNIPFALL, GHOAKJOMOPC DFHAHCFPJNA, MCDAKKLJAMD JCENADJPOBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1C11BC0", Offset = "0x1C10FC0", VA = "0x181C11BC0")]
	public static MGIIALDDNBJ CLFIPFKIGEN(BJEONLLPMDM KDDNMNODBLK, [In] BFFLAGALKLM GEFLJJFNGLO, OKFPGADAGCG<FLPDFBHLNEH> PAHAEGCNKGC, OKFPGADAGCG<DECFMIBEFJI> BAKCNIPFALL, GHOAKJOMOPC DFHAHCFPJNA, MCDAKKLJAMD JCENADJPOBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1C11F30", Offset = "0x1C11330", VA = "0x181C11F30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1C12190", Offset = "0x1C11590", VA = "0x181C12190")]
	[AsyncStateMachine(typeof(INFMFIGLAKE))]
	internal Task<MEEAMGFNJIM<bool, DBNOAAMPCCP>> EIFMGPIGJBK(BOGJDKIJOLK FCLGCMFKGNJ, OCFHMGCGDAI JHPBHCGOAOG, CMFAAJONIFD ILOGCLKGEMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1C117B0", Offset = "0x1C10BB0", VA = "0x181C117B0")]
	[AsyncStateMachine(typeof(DCBPNPPLDGM))]
	public Task<MEEAMGFNJIM<bool, DBNOAAMPCCP>> AAFPBDHBJHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1C12AC0", Offset = "0x1C11EC0", VA = "0x181C12AC0")]
	[AsyncStateMachine(typeof(ONLENEMEHHF))]
	public Task<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> KMFIPNMJPPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1C11910", Offset = "0x1C10D10", VA = "0x181C11910")]
	internal void CAHHGJDBIFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1C12910", Offset = "0x1C11D10", VA = "0x181C12910")]
	internal GDILPCKNMEE<LCJOHDOCEBL> IKOIDMEBEAC([In] BPBMIFDGIFI BNJGAOGNDML)
	{
		return default(GDILPCKNMEE<LCJOHDOCEBL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1C118A0", Offset = "0x1C10CA0", VA = "0x181C118A0")]
	internal bool AKAPAPOPMCH([In] BPBMIFDGIFI BNJGAOGNDML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1C12110", Offset = "0x1C11510", VA = "0x181C12110")]
	internal GDILPCKNMEE<LCJOHDOCEBL> EIFIFOGKEHK([In] BIIHHKPNIMM OALBLAPOFDO)
	{
		return default(GDILPCKNMEE<LCJOHDOCEBL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1C122F0", Offset = "0x1C116F0", VA = "0x181C122F0")]
	[AsyncStateMachine(typeof(EMFPIHLNDAB))]
	internal Task<MEEAMGFNJIM<object, DBNOAAMPCCP>> GAPPBFAHPGJ(LCJOHDOCEBL PAFFKHOCLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1C12400", Offset = "0x1C11800", VA = "0x181C12400")]
	private LCJOHDOCEBL[] IAFAEEEMPIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1C12BC0", Offset = "0x1C11FC0", VA = "0x181C12BC0")]
	[AsyncStateMachine(typeof(FLEAPFGIJLP))]
	public Task<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> PHEDMCIAPEI(Guid ONPBKABKICF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class NOCCNFHACFL
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x24E8970", Offset = "0x24E7D70", VA = "0x1824E8970")]
	public static LJJNENCADGC<(TPrev?, MGIIALDDNBJ?), AAIJHKLJJJE> IFHHNINMAMA<TPrev>([In] this LJJNENCADGC<TPrev, MGIIALDDNBJ> CLFMFOEGLFG)
	{
		return default(LJJNENCADGC<(TPrev, MGIIALDDNBJ), AAIJHKLJJJE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x24E8C10", Offset = "0x24E8010", VA = "0x1824E8C10")]
	public static LJJNENCADGC<TPrev?, MGIIALDDNBJ?> KAMFBMJJMGI<TPrev>([In] this LJJNENCADGC<TPrev, MGIIALDDNBJ> CLFMFOEGLFG)
	{
		return default(LJJNENCADGC<TPrev, MGIIALDDNBJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class KOBOOAPJIDL<TData> : PGBNOEKHDBP, MCGJIAHKIFB, IEAOACDDPEG where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly MIPNFHKLOLI<EHDOJPLINGC>? BIOCJHLFIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly string ALLNCMAEEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly TData GJGGJKOHCEI;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public MIPNFHKLOLI<EHDOJPLINGC>? PEDEDIPJGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1EF9EB0", Offset = "0x1EF92B0", VA = "0x181EF9EB0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x76A450", Offset = "0x769850", VA = "0x18076A450", Slot = "7")]
	public override string EAPOOJKPODL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x38318B0", Offset = "0x3830CB0", VA = "0x1838318B0")]
	internal KOBOOAPJIDL([In] MIPNFHKLOLI<EHDOJPLINGC>? KIDMEFJBEKD, OKFPGADAGCG<LDFAIMDADIE>? PGONGIMBGKH, IOKind? HJPFFLBPPDC, string LMJAPBNMKLG, [In] TData OOIBMCBCEPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class BJKEOACHPOL
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1C03160", Offset = "0x1C02560", VA = "0x181C03160")]
	public static MEEAMGFNJIM<ANBFHOKBBIK, MCGJIAHKIFB> NLDHDANEHFN([In] this GHAGOIPAKHA<FDPELNBPCKL> BEDBNKPHAHF)
	{
		return default(MEEAMGFNJIM<ANBFHOKBBIK, MCGJIAHKIFB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x219EBD0", Offset = "0x219DFD0", VA = "0x18219EBD0")]
	public static MEEAMGFNJIM<TOk, MCGJIAHKIFB> GHIHMCIBMPG<TOk>([In] this MEEAMGFNJIM<TOk, MCGJIAHKIFB> CLFMFOEGLFG, [In] MIPNFHKLOLI<EHDOJPLINGC>? KIDMEFJBEKD, OKFPGADAGCG<LDFAIMDADIE>? PGONGIMBGKH, IOKind? HJPFFLBPPDC, string LMJAPBNMKLG) where TOk : notnull
	{
		return default(MEEAMGFNJIM<TOk, MCGJIAHKIFB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface BJEONLLPMDM
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	KABHJOMINLG.MOGBIGECOLJ AAEPJLOCBAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	BDBGKAHDKMI.AKAKNPELNKP FAJOIGOFNEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	MGIIALDDNBJ.DDKOGNBIIEP KPMFKCMJPNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	INMKNAOBIAH.KOMLFDNNDJO KMJMDAJCCOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	OJLPDABNGCI.LHGAIJCJEMO<PIKOLKDMDCL, LCJOHDOCEBL, MGIIALDDNBJ> GNBFAIENBGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	PGBJLPPKMAA GOKBCEJHAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	EGOCMJDPKGB GBOKJIEPKIN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	FOAMILBAHIL LDFEEJLCALH
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	DCGAOOCAHBD NOPGCCLCADL
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	LAPCFOKGHND MMNKIIBLCBB
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class CECKFEAOIJN
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1C03DF0", Offset = "0x1C031F0", VA = "0x181C03DF0")]
	public static LCJOHDOCEBL LBFAHMIONII(this LCJOHDOCEBL CLFMFOEGLFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1C03F00", Offset = "0x1C03300", VA = "0x181C03F00")]
	public static LCJOHDOCEBL PFLKHJEHIMI(this KGJCGHAEEFP CLFMFOEGLFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct KGJCGHAEEFP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct IMPABOEMAAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AsyncTaskMethodBuilder<MEEAMGFNJIM<object, DBNOAAMPCCP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public MGIIALDDNBJ root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public KGJCGHAEEFP self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private TaskAwaiter<MEEAMGFNJIM<object, DBNOAAMPCCP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1C0EBF0", Offset = "0x1C0DFF0", VA = "0x181C0EBF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x1C0EEB0", Offset = "0x1C0E2B0", VA = "0x181C0EEB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly ByteString OFPAGNFLHNE;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7D3110", Offset = "0x7D2510", VA = "0x1807D3110")]
	private KGJCGHAEEFP(ByteString LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1C10470", Offset = "0x1C0F870", VA = "0x181C10470")]
	public static LCJOHDOCEBL LBCKKFAMLBD(ByteString LPCGJALKADL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1C102B0", Offset = "0x1C0F6B0", VA = "0x181C102B0")]
	public static KEACEFCODEA<PIKOLKDMDCL, KGJCGHAEEFP> DFFDALPHMJD(LCJOHDOCEBL ILHFCJHEHHL)
	{
		return default(KEACEFCODEA<PIKOLKDMDCL, KGJCGHAEEFP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1C10360", Offset = "0x1C0F760", VA = "0x181C10360")]
	[AsyncStateMachine(typeof(IMPABOEMAAE))]
	public static Task<MEEAMGFNJIM<object, DBNOAAMPCCP>> GAPPBFAHPGJ(MGIIALDDNBJ JMNDOLBKAMN, KGJCGHAEEFP CLFMFOEGLFG)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct KFJHKKOJEEH
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1C10210", Offset = "0x1C0F610", VA = "0x181C10210")]
	public static LCJOHDOCEBL LBCKKFAMLBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1C10120", Offset = "0x1C0F520", VA = "0x181C10120")]
	public static KEACEFCODEA<PIKOLKDMDCL, KFJHKKOJEEH> DFFDALPHMJD(LCJOHDOCEBL ILHFCJHEHHL)
	{
		return default(KEACEFCODEA<PIKOLKDMDCL, KFJHKKOJEEH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1C10190", Offset = "0x1C0F590", VA = "0x181C10190")]
	public static MEEAMGFNJIM<EOKBOBHHEEM, PEPMMDADFIO> FMOCGKBELJJ(MGIIALDDNBJ JMNDOLBKAMN, [In] KFJHKKOJEEH CLFMFOEGLFG)
	{
		return default(MEEAMGFNJIM<EOKBOBHHEEM, PEPMMDADFIO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct ACNJJHPJLJO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct KJLBLAJPNHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder<MEEAMGFNJIM<EOKBOBHHEEM, PEPMMDADFIO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public MGIIALDDNBJ root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public ACNJJHPJLJO self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private MEEAMGFNJIM<EOKBOBHHEEM, PEPMMDADFIO> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1C10590", Offset = "0x1C0F990", VA = "0x181C10590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1C10900", Offset = "0x1C0FD00", VA = "0x181C10900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly BOGJDKIJOLK? EPGEDPLLMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly OCFHMGCGDAI? CLHJHDAILJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly CMFAAJONIFD? MOOJNMNAAJP;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x189C610", Offset = "0x189BA10", VA = "0x18189C610")]
	private ACNJJHPJLJO(BOGJDKIJOLK? FCLGCMFKGNJ, OCFHMGCGDAI? JHPBHCGOAOG, CMFAAJONIFD? ILOGCLKGEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1C004D0", Offset = "0x1BFF8D0", VA = "0x181C004D0")]
	public static LCJOHDOCEBL? LBCKKFAMLBD(BOGJDKIJOLK? FCLGCMFKGNJ, OCFHMGCGDAI? JHPBHCGOAOG, CMFAAJONIFD? ILOGCLKGEMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1C00280", Offset = "0x1BFF680", VA = "0x181C00280")]
	public static KEACEFCODEA<PIKOLKDMDCL, ACNJJHPJLJO> DFFDALPHMJD(LCJOHDOCEBL ILHFCJHEHHL)
	{
		return default(KEACEFCODEA<PIKOLKDMDCL, ACNJJHPJLJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1C00390", Offset = "0x1BFF790", VA = "0x181C00390")]
	[AsyncStateMachine(typeof(KJLBLAJPNHN))]
	public static Task<MEEAMGFNJIM<EOKBOBHHEEM, PEPMMDADFIO>> GAPPBFAHPGJ(MGIIALDDNBJ JMNDOLBKAMN, ACNJJHPJLJO CLFMFOEGLFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct OBMPCCKKFIE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct LEMCBMEHJMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<MEEAMGFNJIM<KCLBOAMOHJB, DBNOAAMPCCP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public OBMPCCKKFIE self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public MGIIALDDNBJ root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private MEEAMGFNJIM<KCLBOAMOHJB, DBNOAAMPCCP> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private MEEAMGFNJIM<object, IEAOACDDPEG>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private MEEAMGFNJIM<object, IEAOACDDPEG> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private MEEAMGFNJIM<object, IEAOACDDPEG>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter<MEEAMGFNJIM<object, DBNOAAMPCCP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1C10D10", Offset = "0x1C10110", VA = "0x181C10D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1C11180", Offset = "0x1C10580", VA = "0x181C11180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly IReadOnlyList<LCJOHDOCEBL> HMAAAPLBCOP;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7D3110", Offset = "0x7D2510", VA = "0x1807D3110")]
	private OBMPCCKKFIE(IReadOnlyList<LCJOHDOCEBL> HIKGMMOGGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1C13E20", Offset = "0x1C13220", VA = "0x181C13E20")]
	public static LCJOHDOCEBL LBCKKFAMLBD(IReadOnlyList<LCJOHDOCEBL> HIKGMMOGGPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1C13C40", Offset = "0x1C13040", VA = "0x181C13C40")]
	public static KEACEFCODEA<PIKOLKDMDCL, OBMPCCKKFIE> DFFDALPHMJD(LCJOHDOCEBL ILHFCJHEHHL)
	{
		return default(KEACEFCODEA<PIKOLKDMDCL, OBMPCCKKFIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1C13CE0", Offset = "0x1C130E0", VA = "0x181C13CE0")]
	[AsyncStateMachine(typeof(LEMCBMEHJMP))]
	public static Task<MEEAMGFNJIM<KCLBOAMOHJB, DBNOAAMPCCP>> GAPPBFAHPGJ(MGIIALDDNBJ JMNDOLBKAMN, OBMPCCKKFIE CLFMFOEGLFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct BIIHHKPNIMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly int ENJCEKMGBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly int ICOODGEKGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly byte[] GJGGJKOHCEI;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1638AA0", Offset = "0x1637EA0", VA = "0x181638AA0")]
	private BIIHHKPNIMM(int CHEGLPEPHED, int JPEMHHILGGG, byte[] OOIBMCBCEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1C03080", Offset = "0x1C02480", VA = "0x181C03080")]
	public static LCJOHDOCEBL LBCKKFAMLBD(int CHEGLPEPHED, int JPEMHHILGGG, ByteString OOIBMCBCEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1C02F40", Offset = "0x1C02340", VA = "0x181C02F40")]
	public static LCJOHDOCEBL[] HKDBJEJBDOP(LCJOHDOCEBL PAFFKHOCLGN, int MNNNNBPEBKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1C02D40", Offset = "0x1C02140", VA = "0x181C02D40")]
	public static KEACEFCODEA<PIKOLKDMDCL, BIIHHKPNIMM> DFFDALPHMJD(LCJOHDOCEBL ILHFCJHEHHL)
	{
		return default(KEACEFCODEA<PIKOLKDMDCL, BIIHHKPNIMM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1C02E20", Offset = "0x1C02220", VA = "0x181C02E20")]
	public static MEEAMGFNJIM<LCJOHDOCEBL, PEPMMDADFIO> FMOCGKBELJJ(MGIIALDDNBJ JMNDOLBKAMN, [In] BIIHHKPNIMM CLFMFOEGLFG)
	{
		return default(MEEAMGFNJIM<LCJOHDOCEBL, PEPMMDADFIO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct BPBMIFDGIFI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct DELJBKEFBJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AsyncTaskMethodBuilder<MEEAMGFNJIM<bool, PEPMMDADFIO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public MGIIALDDNBJ root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public BPBMIFDGIFI self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private MEEAMGFNJIM<bool, PEPMMDADFIO> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private TaskAwaiter<MEEAMGFNJIM<EOKBOBHHEEM, PEPMMDADFIO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1C047D0", Offset = "0x1C03BD0", VA = "0x181C047D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1C04E10", Offset = "0x1C04210", VA = "0x181C04E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly int ENJCEKMGBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly int ICOODGEKGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly byte[] GJGGJKOHCEI;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1638AA0", Offset = "0x1637EA0", VA = "0x181638AA0")]
	private BPBMIFDGIFI(int CHEGLPEPHED, int JPEMHHILGGG, byte[] OOIBMCBCEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1C03750", Offset = "0x1C02B50", VA = "0x181C03750")]
	public static LCJOHDOCEBL LBCKKFAMLBD(int CHEGLPEPHED, int JPEMHHILGGG, ByteString OOIBMCBCEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1C03830", Offset = "0x1C02C30", VA = "0x181C03830")]
	public static LCJOHDOCEBL?[]? NIFBPPICFKK(int MNNNNBPEBKF, BOGJDKIJOLK? FCLGCMFKGNJ, OCFHMGCGDAI? JHPBHCGOAOG, CMFAAJONIFD? ILOGCLKGEMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1C03540", Offset = "0x1C02940", VA = "0x181C03540")]
	public static KEACEFCODEA<PIKOLKDMDCL, BPBMIFDGIFI> DFFDALPHMJD(LCJOHDOCEBL ILHFCJHEHHL)
	{
		return default(KEACEFCODEA<PIKOLKDMDCL, BPBMIFDGIFI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1C03620", Offset = "0x1C02A20", VA = "0x181C03620")]
	[AsyncStateMachine(typeof(DELJBKEFBJF))]
	public static Task<MEEAMGFNJIM<bool, PEPMMDADFIO>> GAPPBFAHPGJ(MGIIALDDNBJ JMNDOLBKAMN, BPBMIFDGIFI CLFMFOEGLFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class PGKMFABMOOP : BCIHBAFPMEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly MGIIALDDNBJ JMGCILILDBJ;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public CECOHOPGPHF? OMCMBELJBID
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1C1BA40", Offset = "0x1C1AE40", VA = "0x181C1BA40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x767650", Offset = "0x766A50", VA = "0x180767650")]
	internal PGKMFABMOOP(MGIIALDDNBJ OMPBOPGBPIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class ODNNNMICKJM : CECOHOPGPHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly MGIIALDDNBJ JMGCILILDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly LHFFAOLHENF OALPAJIAPEC;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x769080", Offset = "0x768480", VA = "0x180769080")]
	public ODNNNMICKJM(MGIIALDDNBJ OMPBOPGBPIK, LHFFAOLHENF NKPODOIIHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1C15DB0", Offset = "0x1C151B0", VA = "0x181C15DB0", Slot = "4")]
	public MEEAMGFNJIM<ANBFHOKBBIK, MCGJIAHKIFB> EFMCDEFLFNI(MIPNFHKLOLI<EHDOJPLINGC> CNCFOBBIEIM, OKFPGADAGCG<OJDCJBFDJOM> FAOHNDGDAJK, OKFPGADAGCG<PNJPGKEBOIL> FJALPPDCKGN)
	{
		return default(MEEAMGFNJIM<ANBFHOKBBIK, MCGJIAHKIFB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1C16080", Offset = "0x1C15480", VA = "0x181C16080", Slot = "5")]
	public MEEAMGFNJIM<ANBFHOKBBIK, MCGJIAHKIFB> IFHMCACOPOP(MIPNFHKLOLI<EHDOJPLINGC> CNCFOBBIEIM, OKFPGADAGCG<OJDCJBFDJOM> FAOHNDGDAJK, OKFPGADAGCG<JCONNHOELGN> IOBPMILPHBD)
	{
		return default(MEEAMGFNJIM<ANBFHOKBBIK, MCGJIAHKIFB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class KABHJOMINLG : HOAAKDECBHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface MOGBIGECOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<LHFFAOLHENF> JDJHNLALLKM(MGIIALDDNBJ OMPBOPGBPIK, OCFHMGCGDAI? OIJHGFCMEHF, CMFAAJONIFD? AKODOEKJGDP, CancellationToken OMFABMCIOAC);

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "1")]
		OJDEJHGFJAE CAJMCNLKLOH(MGIIALDDNBJ OMPBOPGBPIK, BOGJDKIJOLK EHLNMKPLMAA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class DKJNJCPHAKJ : MOGBIGECOLJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct LBDAMEJACOP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public AsyncTaskMethodBuilder<LHFFAOLHENF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public MGIIALDDNBJ circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public OCFHMGCGDAI cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public CMFAAJONIFD cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter<INMKNAOBIAH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x1C10970", Offset = "0x1C0FD70", VA = "0x181C10970", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x1C10CA0", Offset = "0x1C100A0", VA = "0x181C10CA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly DKJNJCPHAKJ OMCMBELJBID;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		private DKJNJCPHAKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1C04F90", Offset = "0x1C04390", VA = "0x181C04F90", Slot = "4")]
		[AsyncStateMachine(typeof(LBDAMEJACOP))]
		public Task<LHFFAOLHENF> JDJHNLALLKM(MGIIALDDNBJ OMPBOPGBPIK, OCFHMGCGDAI? OIJHGFCMEHF, CMFAAJONIFD? AKODOEKJGDP, CancellationToken OMFABMCIOAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1C04F00", Offset = "0x1C04300", VA = "0x181C04F00", Slot = "5")]
		public OJDEJHGFJAE CAJMCNLKLOH(MGIIALDDNBJ OMPBOPGBPIK, BOGJDKIJOLK EHLNMKPLMAA)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct EMKHPJPLFGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder<KABHJOMINLG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public MGIIALDDNBJ circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public OCFHMGCGDAI cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public CMFAAJONIFD cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public BOGJDKIJOLK evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private MOGBIGECOLJ <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter<LHFFAOLHENF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1C06F30", Offset = "0x1C06330", VA = "0x181C06F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1C07490", Offset = "0x1C06890", VA = "0x181C07490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly LHFFAOLHENF OALPAJIAPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly OJDEJHGFJAE JHIMBAFEKEH;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public NICPLMDNOBF MFIKBPDMEAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1C0F990", Offset = "0x1C0ED90", VA = "0x181C0F990", Slot = "4")]
		get
		{
			return default(NICPLMDNOBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public AAIJHKLJJJE HHEFMHLCPOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1C0F930", Offset = "0x1C0ED30", VA = "0x181C0F930", Slot = "5")]
		get
		{
			return default(AAIJHKLJJJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ODNNNMICKJM JMDADLMJMLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x76B410", Offset = "0x76A810", VA = "0x18076B410", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public HPMLMHOPEKJ LIBGDAONDBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x767740", Offset = "0x766B40", VA = "0x180767740", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public AKCKKKMNCAO EDCAGMGACEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x767750", Offset = "0x766B50", VA = "0x180767750", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1C0F9F0", Offset = "0x1C0EDF0", VA = "0x181C0F9F0")]
	private KABHJOMINLG(LHFFAOLHENF NKPODOIIHEB, OJDEJHGFJAE FCBOMBAIDMF, ODNNNMICKJM FLOJOFMNMHJ, HPMLMHOPEKJ CDLEIAMOGOO, AKCKKKMNCAO NMHELAKECFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1C0F7C0", Offset = "0x1C0EBC0", VA = "0x181C0F7C0")]
	[AsyncStateMachine(typeof(EMKHPJPLFGD))]
	public static Task<KABHJOMINLG> FJLFLKJKHCC(MGIIALDDNBJ OMPBOPGBPIK, BOGJDKIJOLK EHLNMKPLMAA, OCFHMGCGDAI? OIJHGFCMEHF, CMFAAJONIFD? AKODOEKJGDP, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1C0F760", Offset = "0x1C0EB60", VA = "0x181C0F760", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class BDBGKAHDKMI : PJLBJGBCJII, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface AKAKNPELNKP
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<HOAAKDECBHN> EGDKOLKEBGL(MGIIALDDNBJ OMPBOPGBPIK, BOGJDKIJOLK EHLNMKPLMAA, OCFHMGCGDAI? OIJHGFCMEHF, CMFAAJONIFD? AKODOEKJGDP, CancellationToken OMFABMCIOAC);

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MKMAHIEOEAL();

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void HPLCOLALMCE();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class HFINDCJKKIG : AKAKNPELNKP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct MNFEFCHIFKJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public AsyncTaskMethodBuilder<HOAAKDECBHN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public MGIIALDDNBJ circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public BOGJDKIJOLK evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public OCFHMGCGDAI cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public CMFAAJONIFD cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private TaskAwaiter<KABHJOMINLG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x1C13010", Offset = "0x1C12410", VA = "0x181C13010", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x1C13350", Offset = "0x1C12750", VA = "0x181C13350", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x1C0C060", Offset = "0x1C0B460", VA = "0x181C0C060", Slot = "4")]
		[AsyncStateMachine(typeof(MNFEFCHIFKJ))]
		public Task<HOAAKDECBHN> EGDKOLKEBGL(MGIIALDDNBJ OMPBOPGBPIK, BOGJDKIJOLK EHLNMKPLMAA, OCFHMGCGDAI? OIJHGFCMEHF, CMFAAJONIFD? AKODOEKJGDP, CancellationToken OMFABMCIOAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void MKMAHIEOEAL();

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void HPLCOLALMCE();

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		protected HFINDCJKKIG()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct HLHKJFKBGFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder<HOAAKDECBHN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public BDBGKAHDKMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter<EOKBOBHHEEM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x1C0C580", Offset = "0x1C0B980", VA = "0x181C0C580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x1C0C780", Offset = "0x1C0BB80", VA = "0x181C0C780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct PLNEMAKGAMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public BDBGKAHDKMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public MGIIALDDNBJ circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public BOGJDKIJOLK evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public OCFHMGCGDAI cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public CMFAAJONIFD cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<HOAAKDECBHN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x1C1BB50", Offset = "0x1C1AF50", VA = "0x181C1BB50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x1C1C080", Offset = "0x1C1B480", VA = "0x181C1C080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly AKAKNPELNKP BOAEKCBHIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly TaskCompletionSource<EOKBOBHHEEM> IJJGHJJDKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly TaskCompletionSource<EOKBOBHHEEM> JGKHHBCNFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly CancellationTokenSource PNPPCNEIIKA;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool KLJALALCPJB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7B8540", Offset = "0x7B7940", VA = "0x1807B8540", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7B7D20", Offset = "0x7B7120", VA = "0x1807B7D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool JMGKFCEFHMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7EF5F0", Offset = "0x7EE9F0", VA = "0x1807EF5F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7EF610", Offset = "0x7EEA10", VA = "0x1807EF610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool LLFNJDJDCBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xD9EC20", Offset = "0xD9E020", VA = "0x180D9EC20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1C02B30", Offset = "0x1C01F30", VA = "0x181C02B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public HOAAKDECBHN? POJMBFODKIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x767970", Offset = "0x766D70", VA = "0x180767970", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x767760", Offset = "0x766B60", VA = "0x180767760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1C02B40", Offset = "0x1C01F40", VA = "0x181C02B40", Slot = "7")]
	[AsyncStateMachine(typeof(HLHKJFKBGFF))]
	public Task<HOAAKDECBHN> PNJHCKBDGNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1C02C30", Offset = "0x1C02030", VA = "0x181C02C30")]
	public BDBGKAHDKMI(AKAKNPELNKP KELDMPHCCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1C02860", Offset = "0x1C01C60", VA = "0x181C02860", Slot = "8")]
	[AsyncStateMachine(typeof(PLNEMAKGAMC))]
	public Task AODNKLOGIPI(MGIIALDDNBJ OMPBOPGBPIK, BOGJDKIJOLK EHLNMKPLMAA, OCFHMGCGDAI? OIJHGFCMEHF, CMFAAJONIFD? AKODOEKJGDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1C029C0", Offset = "0x1C01DC0", VA = "0x181C029C0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class DHEBDPJBJKB : NJHLAFDJMNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly HPMLMHOPEKJ NNOHKJLLFMG;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x767650", Offset = "0x766A50", VA = "0x180767650")]
	public DHEBDPJBJKB(HPMLMHOPEKJ CDLEIAMOGOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class EADMGKAMOKM
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class OHGMDCNAHCN<TGraph> : AEKDMDCHPLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		protected readonly TGraph ACEKGLNMGON;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public virtual CLNHMHNDLPF? EOKHNFOBDCL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xC26A60", Offset = "0xC25E60", VA = "0x180C26A60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x767650", Offset = "0x766A50", VA = "0x180767650")]
		public OHGMDCNAHCN(TGraph APALEIGJBCD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class LKHOCJFEDGH : OHGMDCNAHCN<BEMHELHCHKC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override CLNHMHNDLPF? EOKHNFOBDCL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x1C11210", Offset = "0x1C10610", VA = "0x181C11210", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1C11230", Offset = "0x1C10630", VA = "0x181C11230")]
		public LKHOCJFEDGH(BEMHELHCHKC LBEMAGHIPNE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x1C05DA0", Offset = "0x1C051A0", VA = "0x181C05DA0")]
	public static AEKDMDCHPLL CLFIPFKIGEN(GEBOGBCOJPJ APALEIGJBCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class FEFPJLINKEG : AKLBHANIJJD, IFHMHLGDELF, AGECCGKIHIC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class GOLDCAPLONP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private struct <<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public GOLDCAPLONP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public PGBJLPPKMAA errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private TaskAwaiter<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x1C1C440", Offset = "0x1C1B840", VA = "0x181C1C440", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x1C1C6B0", Offset = "0x1C1BAB0", VA = "0x181C1C6B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public FEFPJLINKEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public GOLDCAPLONP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x1C0B920", Offset = "0x1C0AD20", VA = "0x181C0B920")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task FPIFAAOJLGN(PGBJLPPKMAA errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct HAMCCGFGLJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public FEFPJLINKEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x1C0BB20", Offset = "0x1C0AF20", VA = "0x181C0BB20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x1C0C000", Offset = "0x1C0B400", VA = "0x181C0C000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class EONDLLEPFFE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public EONDLLEPFFE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private TaskAwaiter<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1C1C710", Offset = "0x1C1BB10", VA = "0x181C1C710", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x1C1C9F0", Offset = "0x1C1BDF0", VA = "0x181C1C9F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public FEFPJLINKEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public EONDLLEPFFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x1C07500", Offset = "0x1C06900", VA = "0x181C07500")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task HBCANKLEDCC(PGBJLPPKMAA errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly PLKLLHICPDP MIKJGFEJNOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly ICollection<DOFBBMLIDIC> GEBOOCKOLGB;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private BJEONLLPMDM JGKBEIAMMFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x1C09730", Offset = "0x1C08B30", VA = "0x181C09730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public OKFPGADAGCG<PNJPGKEBOIL> NFIDGPGIJFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x93E110", Offset = "0x93D510", VA = "0x18093E110", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(OKFPGADAGCG<PNJPGKEBOIL>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x986830", Offset = "0x985C30", VA = "0x180986830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public override OKFPGADAGCG<LDFAIMDADIE> PGDEMBNOJJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x1C09120", Offset = "0x1C08520", VA = "0x181C09120", Slot = "19")]
		get
		{
			return default(OKFPGADAGCG<LDFAIMDADIE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool COJKBHEIBMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x1C09850", Offset = "0x1C08C50", VA = "0x181C09850", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x1C0A720", Offset = "0x1C09B20", VA = "0x181C0A720")]
	private FEFPJLINKEG(MGIIALDDNBJ OMPBOPGBPIK, LBIPCGPOOIC BLMOEKLGDFI, PLKLLHICPDP COEGFBLGAEJ, OKFPGADAGCG<OJDCJBFDJOM> FAOHNDGDAJK, OKFPGADAGCG<PNJPGKEBOIL> FJALPPDCKGN, bool AHHJJHIGMLH, string DKFEAPHKBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1C08730", Offset = "0x1C07B30", VA = "0x181C08730")]
	public static FEFPJLINKEG CLFIPFKIGEN(MGIIALDDNBJ OMPBOPGBPIK, LBIPCGPOOIC BLMOEKLGDFI, PLKLLHICPDP INCBMJFBGNP, OKFPGADAGCG<OJDCJBFDJOM> FAOHNDGDAJK, OKFPGADAGCG<COCIAMPEGDB> CLLCDEJPLBE, OKFPGADAGCG<PNJPGKEBOIL> FJALPPDCKGN, bool AHHJJHIGMLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x1C0A400", Offset = "0x1C09800", VA = "0x181C0A400", Slot = "20")]
	protected override void OMELHDOHHCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x1C08AC0", Offset = "0x1C07EC0", VA = "0x181C08AC0", Slot = "21")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1C09A50", Offset = "0x1C08E50", VA = "0x181C09A50", Slot = "28")]
	public void LNODKKNKGCH(DOFBBMLIDIC INLJGGANNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1C09160", Offset = "0x1C08560", VA = "0x181C09160", Slot = "25")]
	public void HJHKBEBJFPG(AKJGJABBJKP HAOLPFHKADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1C07A80", Offset = "0x1C06E80", VA = "0x181C07A80", Slot = "26")]
	public void ANKGLGEEPJN(EENFCJBELLA DCDJOJOFMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1C09040", Offset = "0x1C08440", VA = "0x181C09040", Slot = "22")]
	protected override void FGGOAODPNOO(HABGMFKMPGG ANMFNKHEHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1C08420", Offset = "0x1C07820", VA = "0x181C08420", Slot = "30")]
	public string CEFEBDJCBON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1C0A0F0", Offset = "0x1C094F0", VA = "0x181C0A0F0", Slot = "27")]
	public string NKMLMNCBOAP(int GCHDMCAFBKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1C09D70", Offset = "0x1C09170", VA = "0x181C09D70")]
	private void NBBBMCAHEHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1C09CA0", Offset = "0x1C090A0", VA = "0x181C09CA0", Slot = "29")]
	public void MNDBOOJNHFL(DOFBBMLIDIC INLJGGANNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1C08590", Offset = "0x1C07990", VA = "0x181C08590")]
	private void CFLDIKBGPOL(bool LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1C09750", Offset = "0x1C08B50", VA = "0x181C09750", Slot = "31")]
	[AsyncStateMachine(typeof(HAMCCGFGLJO))]
	public Task JEKINPHKCPN(string LPCGJALKADL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1C08E70", Offset = "0x1C08270", VA = "0x181C08E70")]
	public void FCFPEEPBJHJ(string LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1C09B20", Offset = "0x1C08F20", VA = "0x181C09B20")]
	private void MBNHMKAENFO(int LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x986830", Offset = "0x985C30", VA = "0x180986830")]
	internal void NCOBIOMHHBA(OKFPGADAGCG<PNJPGKEBOIL> LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1C09FA0", Offset = "0x1C093A0", VA = "0x181C09FA0")]
	[CompilerGenerated]
	private bool NGAMFLNMGDF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1C095E0", Offset = "0x1C089E0", VA = "0x181C095E0")]
	[CompilerGenerated]
	private bool INOHCNHPJDA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1C09510", Offset = "0x1C08910", VA = "0x181C09510")]
	[CompilerGenerated]
	private int KKHJHCHIDFO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1C0A5C0", Offset = "0x1C099C0", VA = "0x181C0A5C0")]
	[CompilerGenerated]
	private bool OMLPFDGOOFM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1C08CD0", Offset = "0x1C080D0", VA = "0x181C08CD0")]
	[CompilerGenerated]
	private bool ELMHBHEJLNN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1C08E20", Offset = "0x1C08220", VA = "0x181C08E20")]
	[CompilerGenerated]
	private bool ENFPPEAHAOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1C079F0", Offset = "0x1C06DF0", VA = "0x181C079F0")]
	[CompilerGenerated]
	private bool AKFJNBHCIMA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1C09510", Offset = "0x1C08910", VA = "0x181C09510")]
	[CompilerGenerated]
	private int HKKNIPMBHGK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1C0A650", Offset = "0x1C09A50", VA = "0x181C0A650")]
	[CompilerGenerated]
	private bool PNNGACDDNFE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1C08C80", Offset = "0x1C08080", VA = "0x181C08C80")]
	[CompilerGenerated]
	private int EDPGFFKADIM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1C09560", Offset = "0x1C08960", VA = "0x181C09560")]
	[CompilerGenerated]
	private void INBDCCAFGEL(object LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1C08F70", Offset = "0x1C08370", VA = "0x181C08F70")]
	[CompilerGenerated]
	private bool FCHGJMEKNDI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class KCBAJPKJALG
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private abstract class HPMCKGIJAPF<TNode> : KNFLNIFNKIE<TNode> where TNode : notnull, LGHIAEOPNGB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private struct DNFMDBAEAFE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public AsyncTaskMethodBuilder<MEEAMGFNJIM<OKFPGADAGCG<OJDCJBFDJOM>, DBNOAAMPCCP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public HPMCKGIJAPF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private TaskAwaiter<MEEAMGFNJIM<OKFPGADAGCG<OJDCJBFDJOM>, DBNOAAMPCCP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x4D1D7D0", Offset = "0x4D1CBD0", VA = "0x184D1D7D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x4D1DBA0", Offset = "0x4D1CFA0", VA = "0x184D1DBA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private struct LHEFCMDLFGF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public AsyncTaskMethodBuilder<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public HPMCKGIJAPF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public OKFPGADAGCG<OJDCJBFDJOM> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			private TaskAwaiter<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x38DB530", Offset = "0x38DA930", VA = "0x1838DB530", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x38DB900", Offset = "0x38DAD00", VA = "0x1838DB900", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public sealed override bool LNJFDJHMOEC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x77E3E0", Offset = "0x77D7E0", VA = "0x18077E3E0", Slot = "109")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public sealed override OKFPGADAGCG<OJDCJBFDJOM>? OPCEAIGPAJF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x35395E0", Offset = "0x35389E0", VA = "0x1835395E0", Slot = "114")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x35395C0", Offset = "0x35389C0", VA = "0x1835395C0")]
		public HPMCKGIJAPF(MGIIALDDNBJ OMPBOPGBPIK, TNode BLMOEKLGDFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x35394A0", Offset = "0x35388A0", VA = "0x1835394A0", Slot = "92")]
		[AsyncStateMachine(typeof(HPMCKGIJAPF<>.DNFMDBAEAFE))]
		public override Task<MEEAMGFNJIM<OKFPGADAGCG<OJDCJBFDJOM>, DBNOAAMPCCP>> PLKAJKINAEM(string DKFEAPHKBMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x35392F0", Offset = "0x35386F0", VA = "0x1835392F0", Slot = "117")]
		public sealed override bool LCBKPKCKEEF(OKFPGADAGCG<OJDCJBFDJOM> FAOHNDGDAJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3539250", Offset = "0x3538650", VA = "0x183539250", Slot = "106")]
		protected sealed override bool HKNAPOACMFG(OKFPGADAGCG<OJDCJBFDJOM> FAOHNDGDAJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x35391B0", Offset = "0x35385B0", VA = "0x1835391B0", Slot = "107")]
		protected override bool ECNLNIFKBKD(OKFPGADAGCG<OJDCJBFDJOM> FAOHNDGDAJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3539390", Offset = "0x3538790", VA = "0x183539390", Slot = "93")]
		[AsyncStateMachine(typeof(HPMCKGIJAPF<>.LHEFCMDLFGF))]
		public override Task<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> LIPFEEBDEDN(OKFPGADAGCG<OJDCJBFDJOM> FAOHNDGDAJK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private sealed class PPDBHDDIAAP : PKJGNCBPECJ<FBFMAKLAPBC>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override NodeVisualizationKey GJLBOFLDHNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x8015E0", Offset = "0x8009E0", VA = "0x1808015E0", Slot = "82")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override bool PNEHCKIEOJH
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x77E3E0", Offset = "0x77D7E0", VA = "0x18077E3E0", Slot = "85")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1C1C3E0", Offset = "0x1C1B7E0", VA = "0x181C1C3E0")]
		public PPDBHDDIAAP(MGIIALDDNBJ OMPBOPGBPIK, FBFMAKLAPBC BLMOEKLGDFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private abstract class PKJGNCBPECJ<TNode> : KNFLNIFNKIE<TNode> where TNode : notnull, JAFNAJOHKIP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private struct HBFNMEPKKKA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public AsyncTaskMethodBuilder<MEEAMGFNJIM<OKFPGADAGCG<OJDCJBFDJOM>, DBNOAAMPCCP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public PKJGNCBPECJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private TaskAwaiter<MEEAMGFNJIM<OKFPGADAGCG<OJDCJBFDJOM>, DBNOAAMPCCP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x34FEE30", Offset = "0x34FE230", VA = "0x1834FEE30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x34FF1A0", Offset = "0x34FE5A0", VA = "0x1834FF1A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private struct FIHPKOAOOFC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public AsyncTaskMethodBuilder<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public PKJGNCBPECJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public OKFPGADAGCG<OJDCJBFDJOM> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private TaskAwaiter<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x33B3B00", Offset = "0x33B2F00", VA = "0x1833B3B00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x33B3E50", Offset = "0x33B3250", VA = "0x1833B3E50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override MIPNFHKLOLI<IOFALGJHBGF>? HKGDLJMPAFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x379EAC0", Offset = "0x379DEC0", VA = "0x18379EAC0", Slot = "110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override OKFPGADAGCG<OJDCJBFDJOM>? OPCEAIGPAJF
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x3E64120", Offset = "0x3E63520", VA = "0x183E64120", Slot = "114")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x35395C0", Offset = "0x35389C0", VA = "0x1835395C0")]
		public PKJGNCBPECJ(MGIIALDDNBJ OMPBOPGBPIK, TNode BLMOEKLGDFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3E64000", Offset = "0x3E63400", VA = "0x183E64000", Slot = "92")]
		[AsyncStateMachine(typeof(PKJGNCBPECJ<>.HBFNMEPKKKA))]
		public override Task<MEEAMGFNJIM<OKFPGADAGCG<OJDCJBFDJOM>, DBNOAAMPCCP>> PLKAJKINAEM(string DKFEAPHKBMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3E63E50", Offset = "0x3E63250", VA = "0x183E63E50", Slot = "117")]
		public sealed override bool LCBKPKCKEEF(OKFPGADAGCG<OJDCJBFDJOM> FAOHNDGDAJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3E63DB0", Offset = "0x3E631B0", VA = "0x183E63DB0", Slot = "106")]
		protected sealed override bool HKNAPOACMFG(OKFPGADAGCG<OJDCJBFDJOM> FAOHNDGDAJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3E63D10", Offset = "0x3E63110", VA = "0x183E63D10", Slot = "107")]
		protected override bool ECNLNIFKBKD(OKFPGADAGCG<OJDCJBFDJOM> FAOHNDGDAJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3E63EF0", Offset = "0x3E632F0", VA = "0x183E63EF0", Slot = "93")]
		[AsyncStateMachine(typeof(PKJGNCBPECJ<>.FIHPKOAOOFC))]
		public override Task<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> LIPFEEBDEDN(OKFPGADAGCG<OJDCJBFDJOM> FAOHNDGDAJK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private sealed class IKNMJMGFPMD : KNFLNIFNKIE<FIKCNPHCLOI>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override NodeVisualizationKey GJLBOFLDHNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x8BC410", Offset = "0x8BB810", VA = "0x1808BC410", Slot = "82")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x1C0EB90", Offset = "0x1C0DF90", VA = "0x181C0EB90")]
		public IKNMJMGFPMD(MGIIALDDNBJ OMPBOPGBPIK, FIKCNPHCLOI BLMOEKLGDFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private sealed class GNDHHEMJGGC : PKJGNCBPECJ<KJKKBCFPAHI>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool EMIPLECBDAF
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x77E3E0", Offset = "0x77D7E0", VA = "0x18077E3E0", Slot = "84")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override NodeVisualizationKey GJLBOFLDHNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xA53E80", Offset = "0xA53280", VA = "0x180A53E80", Slot = "82")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x1C0B8C0", Offset = "0x1C0ACC0", VA = "0x181C0B8C0")]
		public GNDHHEMJGGC(MGIIALDDNBJ OMPBOPGBPIK, KJKKBCFPAHI BLMOEKLGDFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private sealed class GPIPFOCEOJD : KNFLNIFNKIE<CDICAEKLHCC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override NodeVisualizationKey GJLBOFLDHNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xEDF040", Offset = "0xEDE440", VA = "0x180EDF040", Slot = "82")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x1C0BAC0", Offset = "0x1C0AEC0", VA = "0x181C0BAC0")]
		public GPIPFOCEOJD(MGIIALDDNBJ OMPBOPGBPIK, CDICAEKLHCC BLMOEKLGDFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private sealed class IHABALDLCDB : KNFLNIFNKIE<ADAEMENDNMK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override NodeVisualizationKey GJLBOFLDHNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xA535B0", Offset = "0xA529B0", VA = "0x180A535B0", Slot = "82")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1C0EB30", Offset = "0x1C0DF30", VA = "0x181C0EB30")]
		public IHABALDLCDB(MGIIALDDNBJ OMPBOPGBPIK, ADAEMENDNMK BLMOEKLGDFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x77E3E0", Offset = "0x77D7E0", VA = "0x18077E3E0", Slot = "106")]
		protected override bool HKNAPOACMFG(OKFPGADAGCG<OJDCJBFDJOM> FAOHNDGDAJK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class MIKHKELPPGF : KNFLNIFNKIE<IDOANKKIBFA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override NodeVisualizationKey GJLBOFLDHNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x81B9C0", Offset = "0x81ADC0", VA = "0x18081B9C0", Slot = "82")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x1C12FB0", Offset = "0x1C123B0", VA = "0x181C12FB0")]
		public MIKHKELPPGF(MGIIALDDNBJ OMPBOPGBPIK, IDOANKKIBFA BLMOEKLGDFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private sealed class MCJHAIGILJL : KNFLNIFNKIE<CDMHICLJPBP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override NodeVisualizationKey GJLBOFLDHNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xA0AE30", Offset = "0xA0A230", VA = "0x180A0AE30", Slot = "82")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x1C11750", Offset = "0x1C10B50", VA = "0x181C11750")]
		public MCJHAIGILJL(MGIIALDDNBJ OMPBOPGBPIK, CDMHICLJPBP BLMOEKLGDFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class OMKPHLICDDM : HPMCKGIJAPF<KGCHFKCBNOJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override NodeVisualizationKey GJLBOFLDHNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x937FA0", Offset = "0x9373A0", VA = "0x180937FA0", Slot = "82")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x1C16350", Offset = "0x1C15750", VA = "0x181C16350")]
		public OMKPHLICDDM(MGIIALDDNBJ OMPBOPGBPIK, KGCHFKCBNOJ BLMOEKLGDFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class KNFLNIFNKIE<TNode> : AMIHCCNNHOK, IDisposable where TNode : notnull, LBIPCGPOOIC
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private sealed class HGOIKNODFMB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public KNFLNIFNKIE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public MGIIALDDNBJ circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
			public HGOIKNODFMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x351BD10", Offset = "0x351B110", VA = "0x18351BD10")]
			internal PGCCHAKDPKN IBKLMHAFMNE(GCBMGCMKNGG portGroup, int index)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct EALCJDFDPKM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public AsyncTaskMethodBuilder<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public KNFLNIFNKIE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public CKMHLKANGCG? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public KFJPEFPIECD? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private TaskAwaiter<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x30153F0", Offset = "0x30147F0", VA = "0x1830153F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x3015690", Offset = "0x3014A90", VA = "0x183015690", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct JGJILBAFHOF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public AsyncTaskMethodBuilder<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public KNFLNIFNKIE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			private TaskAwaiter<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x379EE00", Offset = "0x379E200", VA = "0x18379EE00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x379F060", Offset = "0x379E460", VA = "0x18379F060", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private MGIIALDDNBJ JMGCILILDBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private CCNCEEPMLIB<OJDCJBFDJOM, PGCCHAKDPKN> HJEPGFAELPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private CCNCEEPMLIB<OJDCJBFDJOM, KNOLOAHCOCB> DCNMPJJGPCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[CompilerGenerated]
		private Action<OKFPGADAGCG<OJDCJBFDJOM>>? FOBMDKMFLAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[CompilerGenerated]
		private Action<OKFPGADAGCG<OJDCJBFDJOM>, KNOLOAHCOCB>? EOENJHLMDMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[CompilerGenerated]
		private Action<OKFPGADAGCG<OJDCJBFDJOM>, OKFPGADAGCG<OJDCJBFDJOM>>? ELFCPFLKMJD;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected TNode LDIKMFMDGMD
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x767740", Offset = "0x766B40", VA = "0x180767740")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public MIPNFHKLOLI<MKPDEFBPMHA> MKFMBMMMIFK
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0xD230A0", Offset = "0xD224A0", VA = "0x180D230A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(MIPNFHKLOLI<MKPDEFBPMHA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public object KNMGHOCIPIF
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x30902A0", Offset = "0x308F6A0", VA = "0x1830902A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public virtual bool FIPNIGDNCHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x77E3E0", Offset = "0x77D7E0", VA = "0x18077E3E0", Slot = "80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int ECDKMOIOOBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x3831310", Offset = "0x3830710", VA = "0x183831310", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public MIMCCKCJMAH DINAFOPAMCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x38312C0", Offset = "0x38306C0", VA = "0x1838312C0", Slot = "9")]
			get
			{
				return default(MIMCCKCJMAH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public string LLHDAPMDOIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x3831750", Offset = "0x3830B50", VA = "0x183831750", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public virtual NodeVisualizationKey GJLBOFLDHNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x763220", Offset = "0x762620", VA = "0x180763220", Slot = "82")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public OKFPGADAGCG<PGIHNDFJICK> KOOFEGEFDBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7731C0", Offset = "0x7725C0", VA = "0x1807731C0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(OKFPGADAGCG<PGIHNDFJICK>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x7B0FF0", Offset = "0x7B03F0", VA = "0x1807B0FF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public virtual bool DFMABHJODKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "83")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public virtual bool EMIPLECBDAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "84")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public virtual bool PNEHCKIEOJH
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "85")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public virtual IKNDNDFPBMG HIGBLIEACEE
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x8DA0C0", Offset = "0x8D94C0", VA = "0x1808DA0C0", Slot = "86")]
			get
			{
				return default(IKNDNDFPBMG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public bool NPBEKDFOPJE
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x38310E0", Offset = "0x38304E0", VA = "0x1838310E0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool GPHPBJAGGJH
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x3831130", Offset = "0x3830530", VA = "0x183831130", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool DNBPGAFCOAC
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x3831180", Offset = "0x3830580", VA = "0x183831180", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public int PIBHOOFLGPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x38315A0", Offset = "0x38309A0", VA = "0x1838315A0", Slot = "19")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool EPBCOJKGIMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x38314C0", Offset = "0x38308C0", VA = "0x1838314C0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public string BCLILPABKHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x38313D0", Offset = "0x38307D0", VA = "0x1838313D0", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public bool HNLGLJCIMDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x3831220", Offset = "0x3830620", VA = "0x183831220", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public bool CLIEAOKAIAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xAB2040", Offset = "0xAB1440", VA = "0x180AB2040", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xABD510", Offset = "0xABC910", VA = "0x180ABD510")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public virtual bool IBHGKBGHMLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "87")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public virtual bool FMLOEKOHPKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x38311D0", Offset = "0x38305D0", VA = "0x1838311D0", Slot = "88")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool OPAAKILEBLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x3831410", Offset = "0x3830810", VA = "0x183831410", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public CKMHLKANGCG MBLHMGPEFAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x3831500", Offset = "0x3830900", VA = "0x183831500", Slot = "27")]
			get
			{
				return default(CKMHLKANGCG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public KFJPEFPIECD JFMPNIDBDLB
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x3831550", Offset = "0x3830950", VA = "0x183831550", Slot = "29")]
			get
			{
				return default(KFJPEFPIECD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public virtual bool AMBEKKGIFGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "101")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public virtual DMDMGEGKDIJ? HJHMHEHLLIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x763220", Offset = "0x762620", VA = "0x180763220", Slot = "102")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public virtual BBJADMJILDJ? DHJJFJCPCPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x763220", Offset = "0x762620", VA = "0x180763220", Slot = "103")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public virtual IEnumerable<MIPNFHKLOLI<EHDOJPLINGC>>? AAIFGBPGPCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x763220", Offset = "0x762620", VA = "0x180763220", Slot = "104")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public bool DPLNGIJNHCM
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x3831270", Offset = "0x3830670", VA = "0x183831270", Slot = "108")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public MIPNFHKLOLI<IOFALGJHBGF> HLMJOIBMECA
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x3831350", Offset = "0x3830750", VA = "0x183831350", Slot = "54")]
			get
			{
				return default(MIPNFHKLOLI<IOFALGJHBGF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual bool LNJFDJHMOEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "109")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual MIPNFHKLOLI<IOFALGJHBGF>? HKGDLJMPAFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x38313A0", Offset = "0x38307A0", VA = "0x1838313A0", Slot = "110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool GCMDFAAPMKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x3831460", Offset = "0x3830860", VA = "0x183831460", Slot = "59")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public virtual string PDBKHDHIBAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x7699F0", Offset = "0x768DF0", VA = "0x1807699F0", Slot = "111")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x769A00", Offset = "0x768E00", VA = "0x180769A00", Slot = "112")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public MIPNFHKLOLI<EHDOJPLINGC> GHAGOGIMHBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x38315E0", Offset = "0x38309E0", VA = "0x1838315E0", Slot = "60")]
			get
			{
				return default(MIPNFHKLOLI<EHDOJPLINGC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public MIPNFHKLOLI<EHDOJPLINGC>? OGMOHCCHDAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x3831630", Offset = "0x3830A30", VA = "0x183831630", Slot = "113")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public ICPGDIAEEND<OJDCJBFDJOM, KNOLOAHCOCB> MBMKEAIDBFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x3831710", Offset = "0x3830B10", VA = "0x183831710", Slot = "62")]
			get
			{
				return default(ICPGDIAEEND<OJDCJBFDJOM, KNOLOAHCOCB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public virtual OKFPGADAGCG<OJDCJBFDJOM>? OPCEAIGPAJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x763220", Offset = "0x762620", VA = "0x180763220", Slot = "114")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action MNILNBBOMKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x382F6A0", Offset = "0x382EAA0", VA = "0x18382F6A0", Slot = "35")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x382D700", Offset = "0x382CB00", VA = "0x18382D700", Slot = "36")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event AHFJAHCECIB NNJFNLEAFBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x382F7A0", Offset = "0x382EBA0", VA = "0x18382F7A0", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x3830C80", Offset = "0x3830080", VA = "0x183830C80", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event INGKMIDDINO GOFPKLEIFPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x382EB40", Offset = "0x382DF40", VA = "0x18382EB40", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x382D900", Offset = "0x382CD00", VA = "0x18382D900", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action JOMCNJDIKBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x382DC60", Offset = "0x382D060", VA = "0x18382DC60", Slot = "41")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x382DAD0", Offset = "0x382CED0", VA = "0x18382DAD0", Slot = "42")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action IDCIICDPKLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x382E570", Offset = "0x382D970", VA = "0x18382E570", Slot = "43")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x382D7A0", Offset = "0x382CBA0", VA = "0x18382D7A0", Slot = "44")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<OKFPGADAGCG<OJDCJBFDJOM>, KNOLOAHCOCB> ODFJDDNDAMB
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x382F530", Offset = "0x382E930", VA = "0x18382F530", Slot = "64")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x3830250", Offset = "0x382F650", VA = "0x183830250", Slot = "65")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<OKFPGADAGCG<OJDCJBFDJOM>, KNOLOAHCOCB> DCFKDBJIGEH
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x382D840", Offset = "0x382CC40", VA = "0x18382D840", Slot = "68")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x382E610", Offset = "0x382DA10", VA = "0x18382E610", Slot = "69")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<OKFPGADAGCG<OJDCJBFDJOM>> KBJBEOKFBEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x382E6D0", Offset = "0x382DAD0", VA = "0x18382E6D0", Slot = "66")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x382D5F0", Offset = "0x382C9F0", VA = "0x18382D5F0", Slot = "67")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<OKFPGADAGCG<OJDCJBFDJOM>, OKFPGADAGCG<OJDCJBFDJOM>> EMAILBJOPGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x3830450", Offset = "0x382F850", VA = "0x183830450", Slot = "70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x382D9A0", Offset = "0x382CDA0", VA = "0x18382D9A0", Slot = "71")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<OKFPGADAGCG<OJDCJBFDJOM>, KNOLOAHCOCB> HDPCCMPLOBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x382F5E0", Offset = "0x382E9E0", VA = "0x18382F5E0", Slot = "72")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x382EC60", Offset = "0x382E060", VA = "0x18382EC60", Slot = "73")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3830DF0", Offset = "0x38301F0", VA = "0x183830DF0")]
		[HMIBGOFDLPO("Need to handle `Name` better.")]
		[HMIBGOFDLPO("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		public KNFLNIFNKIE(MGIIALDDNBJ OMPBOPGBPIK, TNode BLMOEKLGDFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3830590", Offset = "0x382F990", VA = "0x183830590", Slot = "78")]
		protected virtual void OMELHDOHHCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x382DD00", Offset = "0x382D100", VA = "0x18382DD00", Slot = "79")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x382DC10", Offset = "0x382D010", VA = "0x18382DC10", Slot = "81")]
		public virtual void DFBCCCIDCNH(int NNMDLMALIJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x382FDC0", Offset = "0x382F1C0", VA = "0x18382FDC0")]
		public bool KDBAMBKBMAK([In] CKMHLKANGCG LPCGJALKADL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x382F740", Offset = "0x382EB40", VA = "0x18382F740")]
		public bool JFOFKKNAHGL([In] KFJPEFPIECD LPCGJALKADL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x382D3D0", Offset = "0x382C7D0", VA = "0x18382D3D0", Slot = "89")]
		public virtual void AAEONGIFCPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x382F840", Offset = "0x382EC40", VA = "0x18382F840", Slot = "32")]
		[AsyncStateMachine(typeof(KNFLNIFNKIE<>.EALCJDFDPKM))]
		public Task<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> JLEOLOLGOHO(CKMHLKANGCG? EDOEDBAJLGN, KFJPEFPIECD? ALNLHNLOHOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "90")]
		public virtual void DOJIAHCBNDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "91")]
		public virtual void NNHCDDOANJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x134DAE0", Offset = "0x134CEE0", VA = "0x18134DAE0")]
		protected void KELKLBELNGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x1C19220", Offset = "0x1C18620", VA = "0x181C19220")]
		protected void MJPJDGHEEAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1015D10", Offset = "0x1015110", VA = "0x181015D10")]
		private void BPNIKCMEKHO([In] KFJPEFPIECD CKFJFCLIANA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3830D20", Offset = "0x3830120", VA = "0x183830D20", Slot = "92")]
		public virtual Task<MEEAMGFNJIM<OKFPGADAGCG<OJDCJBFDJOM>, DBNOAAMPCCP>> PLKAJKINAEM(string DKFEAPHKBMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x3830060", Offset = "0x382F460", VA = "0x183830060", Slot = "93")]
		public virtual Task<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> LIPFEEBDEDN(OKFPGADAGCG<OJDCJBFDJOM> FAOHNDGDAJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x382DB70", Offset = "0x382CF70", VA = "0x18382DB70", Slot = "94")]
		public virtual void CPLBCHCGHJP(OKFPGADAGCG<OJDCJBFDJOM> JPEMHHILGGG, OKFPGADAGCG<OJDCJBFDJOM> ADOGMMPMLJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x382ED20", Offset = "0x382E120", VA = "0x18382ED20", Slot = "95")]
		public virtual IEnumerable<LCJOHDOCEBL> GFGENFFNJEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x3830510", Offset = "0x382F910", VA = "0x183830510", Slot = "96")]
		public MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP> NKBIHEAJLFM(string EMGPIOIKIHM)
		{
			return default(MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x382F3E0", Offset = "0x382E7E0", VA = "0x18382F3E0", Slot = "45")]
		public bool IAJLAJEADPD([Out] Guid PIFNMNCMMHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x382FEC0", Offset = "0x382F2C0", VA = "0x18382FEC0", Slot = "97")]
		public virtual bool LBAFLKIEBDP([In] Guid OFLFFIGFOIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x382DA80", Offset = "0x382CE80", VA = "0x18382DA80", Slot = "98")]
		public virtual void CGCDLMDFFPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "99")]
		public virtual void EJELONDJPJN(bool CAFLOMEPFIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x763220", Offset = "0x762620", VA = "0x180763220", Slot = "100")]
		public virtual PGIOPALILBJ ALEHLIOHJHP([In] EJFLGAEPHLO CHHFJIKJLCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3830300", Offset = "0x382F700", VA = "0x183830300")]
		protected void MPLMGPOGGNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "105")]
		protected virtual void PMJBKPKIHMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x382EDB0", Offset = "0x382E1B0", VA = "0x18382EDB0", Slot = "106")]
		protected virtual bool HKNAPOACMFG(OKFPGADAGCG<OJDCJBFDJOM> FAOHNDGDAJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "107")]
		protected virtual bool ECNLNIFKBKD(OKFPGADAGCG<OJDCJBFDJOM> FAOHNDGDAJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "115")]
		protected virtual void BACFDIKCBNG(AAENHECDBJO LFDDCBICAEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "116")]
		protected virtual void JMALHLDPAPE(AAENHECDBJO CEGIHFAIELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x382D6B0", Offset = "0x382CAB0", VA = "0x18382D6B0", Slot = "74")]
		public void ANKGLGEEPJN(AAENHECDBJO CEGIHFAIELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x382F300", Offset = "0x382E700", VA = "0x18382F300", Slot = "75")]
		public IPABAODHIGJ HNMCGMMJCKB()
		{
			return default(IPABAODHIGJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "117")]
		public virtual bool LCBKPKCKEEF(OKFPGADAGCG<OJDCJBFDJOM> FAOHNDGDAJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x382DA60", Offset = "0x382CE60", VA = "0x18382DA60")]
		private void CCDEDIPKMOE([In] CKMHLKANGCG BAONBICGOEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x382FF80", Offset = "0x382F380", VA = "0x18382FF80")]
		private void LCODELGKACC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x382EDE0", Offset = "0x382E1E0", VA = "0x18382EDE0")]
		private void HNJFHKGFJMI(int ELEAOHMLPIN, GCBMGCMKNGG MPLIBLCGMPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3830400", Offset = "0x382F800", VA = "0x183830400")]
		private void NCBCJGNKCNN(int JPEMHHILGGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x382D420", Offset = "0x382C820", VA = "0x18382D420")]
		private void ACBBFGPJCNA(int JPEMHHILGGG, GCBMGCMKNGG ILCHBHGCINN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x382E790", Offset = "0x382DB90", VA = "0x18382E790")]
		private void FDNBDKPHLLA(int ILDHLGACPNI, int GJAGJOCFELH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x382D590", Offset = "0x382C990", VA = "0x18382D590")]
		private void AHOMMJJHLLP(int ILDHLGACPNI, int GJAGJOCFELH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x382DBC0", Offset = "0x382CFC0", VA = "0x18382DBC0")]
		private void DDFAIGKBPHL(int JPEMHHILGGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x382F990", Offset = "0x382ED90", VA = "0x18382F990")]
		private void JPHFICKJCJM(int ELEAOHMLPIN, GCBMGCMKNGG MPLIBLCGMPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x382EBE0", Offset = "0x382DFE0", VA = "0x18382EBE0")]
		private void FJINLJHPFHP(int JPEMHHILGGG, GCBMGCMKNGG ILCHBHGCINN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3830130", Offset = "0x382F530", VA = "0x183830130", Slot = "118")]
		[AsyncStateMachine(typeof(KNFLNIFNKIE<>.JGJILBAFHOF))]
		public virtual Task<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> MAEMAJGLFII(string EMGPIOIKIHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x382FF10", Offset = "0x382F310", VA = "0x18382FF10", Slot = "52")]
		private void LBMCCMDLFFN(object NOFFHLIODPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x382FE50", Offset = "0x382F250", VA = "0x18382FE50", Slot = "53")]
		private void LAAMHLIPGPL(object NOFFHLIODPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x382FE20", Offset = "0x382F220", VA = "0x18382FE20", Slot = "28")]
		private bool KOENIFMFBEP([In] CKMHLKANGCG LPCGJALKADL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x382D560", Offset = "0x382C960", VA = "0x18382D560", Slot = "30")]
		private bool AHJMBAJOEOO([In] KFJPEFPIECD LPCGJALKADL)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private sealed class KGJMFCCNOOJ : HPMCKGIJAPF<KOKJCJGAGJK>
	{
		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public override NodeVisualizationKey GJLBOFLDHNC
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xA65600", Offset = "0xA64A00", VA = "0x180A65600", Slot = "82")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x1C10530", Offset = "0x1C0F930", VA = "0x181C10530")]
		public KGJMFCCNOOJ(MGIIALDDNBJ OMPBOPGBPIK, KOKJCJGAGJK BLMOEKLGDFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class NKHPDGFFLDC : KNFLNIFNKIE<BMMDOCPAOOA>
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public override NodeVisualizationKey GJLBOFLDHNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x178D500", Offset = "0x178C900", VA = "0x18178D500", Slot = "82")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x1C137A0", Offset = "0x1C12BA0", VA = "0x181C137A0")]
		public NKHPDGFFLDC(MGIIALDDNBJ OMPBOPGBPIK, BMMDOCPAOOA BLMOEKLGDFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private sealed class ECIPFEFKNDE : KNFLNIFNKIE<GCAMOPPFJEF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public override NodeVisualizationKey GJLBOFLDHNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0xAB4B60", Offset = "0xAB3F60", VA = "0x180AB4B60", Slot = "82")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x1C05F30", Offset = "0x1C05330", VA = "0x181C05F30")]
		public ECIPFEFKNDE(MGIIALDDNBJ OMPBOPGBPIK, GCAMOPPFJEF BLMOEKLGDFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private sealed class FBLFDBBIEJA : KNFLNIFNKIE<NOEKAPDCDHM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public override NodeVisualizationKey GJLBOFLDHNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8AE210", Offset = "0x8AD610", VA = "0x1808AE210", Slot = "82")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x1C075D0", Offset = "0x1C069D0", VA = "0x181C075D0")]
		public FBLFDBBIEJA(MGIIALDDNBJ OMPBOPGBPIK, NOEKAPDCDHM BLMOEKLGDFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x1C0FA80", Offset = "0x1C0EE80", VA = "0x181C0FA80")]
	internal static AMIHCCNNHOK CLFIPFKIGEN(MGIIALDDNBJ OMPBOPGBPIK, LBIPCGPOOIC BLMOEKLGDFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public sealed class ODNNCKCGPCI : AKLBHANIJJD, LMOGDMOMPMJ, AGECCGKIHIC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public OKFPGADAGCG<JCONNHOELGN> IMFNEBANNJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xED3330", Offset = "0xED2730", VA = "0x180ED3330", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(OKFPGADAGCG<JCONNHOELGN>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x1064F50", Offset = "0x1064350", VA = "0x181064F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public override OKFPGADAGCG<LDFAIMDADIE> PGDEMBNOJJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x1C15D20", Offset = "0x1C15120", VA = "0x181C15D20", Slot = "19")]
		get
		{
			return default(OKFPGADAGCG<LDFAIMDADIE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x1C15D60", Offset = "0x1C15160", VA = "0x181C15D60")]
	private ODNNCKCGPCI(MGIIALDDNBJ OMPBOPGBPIK, LBIPCGPOOIC BLMOEKLGDFI, IOPBEJICCGN MKPAHEGOJFK, OKFPGADAGCG<OJDCJBFDJOM> FAOHNDGDAJK, OKFPGADAGCG<JCONNHOELGN> IOBPMILPHBD, bool AHHJJHIGMLH, string DKFEAPHKBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x1C15A00", Offset = "0x1C14E00", VA = "0x181C15A00")]
	public static ODNNCKCGPCI CLFIPFKIGEN(MGIIALDDNBJ OMPBOPGBPIK, LBIPCGPOOIC BLMOEKLGDFI, IOPBEJICCGN JLPFPEEBHJE, OKFPGADAGCG<OJDCJBFDJOM> FAOHNDGDAJK, OKFPGADAGCG<MDPMJJMJGJG> HKFFKMNNMFP, OKFPGADAGCG<JCONNHOELGN> IOBPMILPHBD, bool AHHJJHIGMLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x1064F50", Offset = "0x1064350", VA = "0x181064F50")]
	internal void INHHFCCCFKH(OKFPGADAGCG<JCONNHOELGN> LPCGJALKADL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public abstract class AKLBHANIJJD : AGECCGKIHIC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private struct JLAEJMPIAGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private CPIMBCODNCO? PMFCPEFHODM;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x1C0F750", Offset = "0x1C0EB50", VA = "0x181C0F750")]
		public void OOAOJFKKMLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x1C0F6B0", Offset = "0x1C0EAB0", VA = "0x181C0F6B0")]
		public CPIMBCODNCO KGAMFPMEMLE(AKLBHANIJJD IMFMCIFPBLO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	protected readonly MGIIALDDNBJ JMGCILILDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	protected readonly LBIPCGPOOIC GJHKJJGCNOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private JLAEJMPIAGL OJLJJDCFILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly MKLKHPBHMLE NAHCCGABNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly List<GOALCNDJDIC> GFLGBODCPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly List<HPIIBLGNLMG> KAONBBHCMBI;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public IEnumerable<StaticEdge> GCNNOLOPGCN
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x1C01450", Offset = "0x1C00850", VA = "0x181C01450", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public DisplayKind MPGHIEDLBEE
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7731C0", Offset = "0x7725C0", VA = "0x1807731C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public MIPNFHKLOLI<IOFALGJHBGF> HLMJOIBMECA
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x1C01420", Offset = "0x1C00820", VA = "0x181C01420", Slot = "6")]
		get
		{
			return default(MIPNFHKLOLI<IOFALGJHBGF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	protected ICGHHAJIBAE KCDOLEMGJBI
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x893EF0", Offset = "0x8932F0", VA = "0x180893EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public DDBPLIOJFAP NPLGDBJEJKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x1C01BD0", Offset = "0x1C00FD0", VA = "0x181C01BD0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	protected CPIMBCODNCO PBCNDCKNAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x1C01BD0", Offset = "0x1C00FD0", VA = "0x181C01BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public PortImage IAJPPIHEFNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x1C00D20", Offset = "0x1C00120", VA = "0x181C00D20", Slot = "12")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public string PDBKHDHIBAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x7653E0", Offset = "0x7647E0", VA = "0x1807653E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x765460", Offset = "0x764860", VA = "0x180765460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public MIPNFHKLOLI<EHDOJPLINGC> GHAGOGIMHBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x1C01270", Offset = "0x1C00670", VA = "0x181C01270", Slot = "8")]
		get
		{
			return default(MIPNFHKLOLI<EHDOJPLINGC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public OKFPGADAGCG<OJDCJBFDJOM> GFEEOBBHMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xC28D70", Offset = "0xC28170", VA = "0x180C28D70", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(OKFPGADAGCG<OJDCJBFDJOM>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xC277F0", Offset = "0xC26BF0", VA = "0x180C277F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public abstract OKFPGADAGCG<LDFAIMDADIE> PGDEMBNOJJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x1C01E20", Offset = "0x1C01220", VA = "0x181C01E20")]
	protected AKLBHANIJJD(MGIIALDDNBJ OMPBOPGBPIK, LBIPCGPOOIC BLMOEKLGDFI, MKLKHPBHMLE FFMKAHKENCL, OKFPGADAGCG<OJDCJBFDJOM> FAOHNDGDAJK, bool AHHJJHIGMLH, string DKFEAPHKBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x1C01CD0", Offset = "0x1C010D0", VA = "0x181C01CD0", Slot = "20")]
	protected virtual void OMELHDOHHCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x1C00E50", Offset = "0x1C00250", VA = "0x181C00E50", Slot = "21")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x1C01000", Offset = "0x1C00400", VA = "0x181C01000", Slot = "13")]
	public void FNHGDOPKPJA(GOALCNDJDIC BOCDMAKBFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x1C01B70", Offset = "0x1C00F70", VA = "0x181C01B70", Slot = "14")]
	public void IBBOPOHIMME(HPIIBLGNLMG BOCDMAKBFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x1C015E0", Offset = "0x1C009E0", VA = "0x181C015E0", Slot = "15")]
	public void HJLKCMHHFEN(HABGMFKMPGG ANMFNKHEHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x1C00FA0", Offset = "0x1C003A0", VA = "0x181C00FA0", Slot = "22")]
	protected virtual void FGGOAODPNOO(HABGMFKMPGG ANMFNKHEHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x1C01290", Offset = "0x1C00690", VA = "0x181C01290")]
	private void HCAPBLPNELN(bool JMBKGKDJDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x1C00B70", Offset = "0x1BFFF70", VA = "0x181C00B70")]
	private void BEPBJHFGJEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x1C01060", Offset = "0x1C00460", VA = "0x181C01060")]
	private void GCFIIALENPN([In] ENLIGFHDFKA LADNIBKBCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x1C01210", Offset = "0x1C00610", VA = "0x181C01210", Slot = "16")]
	public void GDAEPPDDIPE(GOALCNDJDIC BOCDMAKBFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x1C01C70", Offset = "0x1C01070", VA = "0x181C01C70", Slot = "17")]
	public void OGAJGJEEDFL(HPIIBLGNLMG BOCDMAKBFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x765460", Offset = "0x764860", VA = "0x180765460")]
	internal void BALEOLDEMLF(string DKFEAPHKBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0xC277F0", Offset = "0xC26BF0", VA = "0x180C277F0")]
	internal void HLJOCCEIFHI(OKFPGADAGCG<OJDCJBFDJOM> FAOHNDGDAJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public sealed class PGCCHAKDPKN : KNOLOAHCOCB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class GHONKJAJMKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public MGIIALDDNBJ circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public LBIPCGPOOIC node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public OKFPGADAGCG<OJDCJBFDJOM> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public bool canInteract;

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public GHONKJAJMKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x1C0B7C0", Offset = "0x1C0ABC0", VA = "0x181C0B7C0")]
		internal FEFPJLINKEG GKDAHCAOKJK((int PortDescIndex, int PortIndex, PLKLLHICPDP InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x1C0B840", Offset = "0x1C0AC40", VA = "0x181C0B840")]
		internal ODNNCKCGPCI JCMMDKDFOCO(IOPBEJICCGN i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct EHFODILCNDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AsyncTaskMethodBuilder<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public PGCCHAKDPKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private PGBJLPPKMAA <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private TaskAwaiter<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x1C06800", Offset = "0x1C05C00", VA = "0x181C06800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x1C06C60", Offset = "0x1C06060", VA = "0x181C06C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct HILIMIABJCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public AsyncTaskMethodBuilder<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public PGCCHAKDPKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public OKFPGADAGCG<COCIAMPEGDB> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private PGBJLPPKMAA <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private TaskAwaiter<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x1C0C1C0", Offset = "0x1C0B5C0", VA = "0x181C0C1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x1C0C510", Offset = "0x1C0B910", VA = "0x181C0C510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct EFILMGAIBGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public AsyncTaskMethodBuilder<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public PGCCHAKDPKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public OKFPGADAGCG<MDPMJJMJGJG> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private PGBJLPPKMAA <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private TaskAwaiter<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1C05F90", Offset = "0x1C05390", VA = "0x181C05F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x1C062E0", Offset = "0x1C056E0", VA = "0x181C062E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct AGACPIPILAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public AsyncTaskMethodBuilder<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public PGCCHAKDPKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public OKFPGADAGCG<COCIAMPEGDB> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public OKFPGADAGCG<COCIAMPEGDB> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private PGBJLPPKMAA <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private TaskAwaiter<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x1C005D0", Offset = "0x1BFF9D0", VA = "0x181C005D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x1C00920", Offset = "0x1BFFD20", VA = "0x181C00920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private struct CCDCIHFJLKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public AsyncTaskMethodBuilder<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public PGCCHAKDPKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public OKFPGADAGCG<MDPMJJMJGJG> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public OKFPGADAGCG<MDPMJJMJGJG> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private PGBJLPPKMAA <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private TaskAwaiter<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x1C03A30", Offset = "0x1C02E30", VA = "0x181C03A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x1C03D80", Offset = "0x1C03180", VA = "0x181C03D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private struct GEFIHFHPHCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public AsyncTaskMethodBuilder<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public PGCCHAKDPKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private PGBJLPPKMAA <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private TaskAwaiter<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x1C0B2E0", Offset = "0x1C0A6E0", VA = "0x181C0B2E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x1C0B750", Offset = "0x1C0AB50", VA = "0x181C0B750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct CHELKHLPCFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public AsyncTaskMethodBuilder<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public PGCCHAKDPKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private PGBJLPPKMAA <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private TaskAwaiter<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x1C03FD0", Offset = "0x1C033D0", VA = "0x181C03FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x1C04320", Offset = "0x1C03720", VA = "0x181C04320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct OBCMPJBBIPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public AsyncTaskMethodBuilder<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public PGCCHAKDPKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public OKFPGADAGCG<COCIAMPEGDB> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private PGBJLPPKMAA <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private TaskAwaiter<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x1C13880", Offset = "0x1C12C80", VA = "0x181C13880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x1C13BD0", Offset = "0x1C12FD0", VA = "0x181C13BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct FEFGGKHOAKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public AsyncTaskMethodBuilder<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public PGCCHAKDPKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public OKFPGADAGCG<MDPMJJMJGJG> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private PGBJLPPKMAA <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private TaskAwaiter<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x1C07630", Offset = "0x1C06A30", VA = "0x181C07630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x1C07980", Offset = "0x1C06D80", VA = "0x181C07980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly bool PDKIBECHDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly MGIIALDDNBJ JMGCILILDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly bool HAGLEGNPCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private ICPGDIAEEND<PNJPGKEBOIL, FEFPJLINKEG> AIFLMDKONBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private ICPGDIAEEND<PNJPGKEBOIL, IFHMHLGDELF> OEKEEOFOIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly LBIPCGPOOIC GJHKJJGCNOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private ICPGDIAEEND<JCONNHOELGN, ODNNCKCGPCI> KLBDOCCCNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private ICPGDIAEEND<JCONNHOELGN, LMOGDMOMPMJ> JDGAKJDCOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private string? FAEPBNIPJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly GCBMGCMKNGG BMFEIKFKAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private OKFPGADAGCG<OJDCJBFDJOM> BHCFIDDIJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[CompilerGenerated]
	private Action? EEGEDPKMFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	[CompilerGenerated]
	private Action? ODDKPMCNGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	[CompilerGenerated]
	private Action<OKFPGADAGCG<PNJPGKEBOIL>>? KEAKNABBLEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	[CompilerGenerated]
	private Action<OKFPGADAGCG<JCONNHOELGN>>? JKMBAKLFMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	[CompilerGenerated]
	private KNOLOAHCOCB.GENIMIHOMIM? AMHFIADBKKG;

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool HKHEJLKPAEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x1C18AA0", Offset = "0x1C17EA0", VA = "0x181C18AA0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool MLDCDKBGEIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x1C19BD0", Offset = "0x1C18FD0", VA = "0x181C19BD0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool DGDJOOOBECK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x1C17220", Offset = "0x1C16620", VA = "0x181C17220", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public MIPNFHKLOLI<IOFALGJHBGF> HLMJOIBMECA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x1C18B80", Offset = "0x1C17F80", VA = "0x181C18B80", Slot = "7")]
		get
		{
			return default(MIPNFHKLOLI<IOFALGJHBGF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public bool AGOOEJGINEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x1C1B000", Offset = "0x1C1A400", VA = "0x181C1B000", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public ICPGDIAEEND<PNJPGKEBOIL, IFHMHLGDELF> LJJKBJGHOFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x767750", Offset = "0x766B50", VA = "0x180767750", Slot = "9")]
		get
		{
			return default(ICPGDIAEEND<PNJPGKEBOIL, IFHMHLGDELF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public string PDBKHDHIBAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x1C16A80", Offset = "0x1C15E80", VA = "0x181C16A80", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public MIPNFHKLOLI<EHDOJPLINGC> GHAGOGIMHBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x1C18B60", Offset = "0x1C17F60", VA = "0x181C18B60", Slot = "11")]
		get
		{
			return default(MIPNFHKLOLI<EHDOJPLINGC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public ICPGDIAEEND<JCONNHOELGN, LMOGDMOMPMJ> AGHGIEAHLPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7653E0", Offset = "0x7647E0", VA = "0x1807653E0", Slot = "12")]
		get
		{
			return default(ICPGDIAEEND<JCONNHOELGN, LMOGDMOMPMJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public OKFPGADAGCG<OJDCJBFDJOM> GFEEOBBHMGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8A6710", Offset = "0x8A5B10", VA = "0x1808A6710", Slot = "13")]
		get
		{
			return default(OKFPGADAGCG<OJDCJBFDJOM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action LMFPHCLJNOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x1C1A0A0", Offset = "0x1C194A0", VA = "0x181C1A0A0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x1C18230", Offset = "0x1C17630", VA = "0x181C18230", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action<OKFPGADAGCG<PNJPGKEBOIL>, OKFPGADAGCG<PNJPGKEBOIL>> FMKJFGGEDCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x1C189E0", Offset = "0x1C17DE0", VA = "0x181C189E0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x1C18BB0", Offset = "0x1C17FB0", VA = "0x181C18BB0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<OKFPGADAGCG<JCONNHOELGN>, OKFPGADAGCG<JCONNHOELGN>> MJKPJKCPFAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x1C18390", Offset = "0x1C17790", VA = "0x181C18390", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1C1A960", Offset = "0x1C19D60", VA = "0x181C1A960", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<OKFPGADAGCG<PNJPGKEBOIL>, IFHMHLGDELF> LJHJOAFNDDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x1C19160", Offset = "0x1C18560", VA = "0x181C19160", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x1C1AF40", Offset = "0x1C1A340", VA = "0x181C1AF40", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<OKFPGADAGCG<PNJPGKEBOIL>> OGCAFCODOPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x1C19F20", Offset = "0x1C19320", VA = "0x181C19F20", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x1C182D0", Offset = "0x1C176D0", VA = "0x181C182D0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<OKFPGADAGCG<PNJPGKEBOIL>, IFHMHLGDELF> ECEOCPJIDDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x1C17000", Offset = "0x1C16400", VA = "0x181C17000", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x1C19FE0", Offset = "0x1C193E0", VA = "0x181C19FE0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<OKFPGADAGCG<JCONNHOELGN>, LMOGDMOMPMJ> CNIJHAOFLIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x1C1B890", Offset = "0x1C1AC90", VA = "0x181C1B890", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x1C18590", Offset = "0x1C17990", VA = "0x181C18590", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<OKFPGADAGCG<JCONNHOELGN>> GEFIKHCOODD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x1C1B7D0", Offset = "0x1C1ABD0", VA = "0x181C1B7D0", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x1C16970", Offset = "0x1C15D70", VA = "0x181C16970", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<OKFPGADAGCG<JCONNHOELGN>, LMOGDMOMPMJ> BCLCLPODGBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x1C16730", Offset = "0x1C15B30", VA = "0x181C16730", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x1C19240", Offset = "0x1C18640", VA = "0x181C19240", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x1C1B950", Offset = "0x1C1AD50", VA = "0x181C1B950")]
	private PGCCHAKDPKN(bool AHHJJHIGMLH, MGIIALDDNBJ OMPBOPGBPIK, bool GFEJFMNLDCE, ICPGDIAEEND<PNJPGKEBOIL, FEFPJLINKEG> JHGMILLGKGF, ICPGDIAEEND<PNJPGKEBOIL, IFHMHLGDELF> ALHDKLFBDOJ, LBIPCGPOOIC BLMOEKLGDFI, ICPGDIAEEND<JCONNHOELGN, ODNNCKCGPCI> ACJLOKFCAFC, ICPGDIAEEND<JCONNHOELGN, LMOGDMOMPMJ> IFBEHKEDFIB, string? KPNBBJEMDEN, GCBMGCMKNGG MPLIBLCGMPP, OKFPGADAGCG<OJDCJBFDJOM> FAOHNDGDAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x1C16AB0", Offset = "0x1C15EB0", VA = "0x181C16AB0")]
	public static PGCCHAKDPKN CLFIPFKIGEN(bool AHHJJHIGMLH, MGIIALDDNBJ OMPBOPGBPIK, bool GFEJFMNLDCE, LBIPCGPOOIC BLMOEKLGDFI, GCBMGCMKNGG MPLIBLCGMPP, OKFPGADAGCG<OJDCJBFDJOM> FAOHNDGDAJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x1C1B080", Offset = "0x1C1A480", VA = "0x181C1B080")]
	private void OMELHDOHHCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x1C17450", Offset = "0x1C16850", VA = "0x181C17450", Slot = "41")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x1C184A0", Offset = "0x1C178A0", VA = "0x181C184A0", Slot = "32")]
	[AsyncStateMachine(typeof(EHFODILCNDH))]
	public Task<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> FEDCBLIMJFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x1C18650", Offset = "0x1C17A50", VA = "0x181C18650")]
	private (OKMNAIAOBED, int)? FMMIEIAEHAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x1C170C0", Offset = "0x1C164C0", VA = "0x181C170C0")]
	private void CPALHLLFHDP(int FCAAEBKCPMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x1C19220", Offset = "0x1C18620", VA = "0x181C19220")]
	private void IMKGEHFMMOJ(int FCAAEBKCPMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x1C19830", Offset = "0x1C18C30", VA = "0x181C19830")]
	private void LHDPCEMODAI(int BBHBJMOBJND, int GHAPFMKDOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x7F0680", Offset = "0x7EFA80", VA = "0x1807F0680")]
	private void GAAOJIGAIFO(int FCAAEBKCPMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x1C19300", Offset = "0x1C18700", VA = "0x181C19300")]
	private void KNKCJHGFFMN(int FCAAEBKCPMM, int EKEODIBANIH, PLKLLHICPDP HGOEIFPLBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x1C16A30", Offset = "0x1C15E30", VA = "0x181C16A30")]
	private void BNHMJKJEECN(int JMBKGKDJDLG, int EKEODIBANIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x1C17400", Offset = "0x1C16800", VA = "0x181C17400")]
	private void DPBCKJMJFPD(int JMBKGKDJDLG, int EKEODIBANIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x1C17DD0", Offset = "0x1C171D0", VA = "0x181C17DD0")]
	private void EAPJDNDFHHN(int FCAAEBKCPMM, int EKEODIBANIH, PLKLLHICPDP HGOEIFPLBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x1C18880", Offset = "0x1C17C80", VA = "0x181C18880")]
	private void FONCENMBDKF(int FCAAEBKCPMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x1C19220", Offset = "0x1C18620", VA = "0x181C19220")]
	private void NCMGGIEKELO(int FCAAEBKCPMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x1C1A140", Offset = "0x1C19540", VA = "0x181C1A140")]
	private void NLCOCCDKNJP(int BBHBJMOBJND, int GHAPFMKDOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7F0680", Offset = "0x7EFA80", VA = "0x1807F0680")]
	private void ILEIJJKDMCL(int FCAAEBKCPMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x1C1AA20", Offset = "0x1C19E20", VA = "0x181C1AA20")]
	private void OGHOIBEJIHM(int FCAAEBKCPMM, int EKEODIBANIH, IOPBEJICCGN HGOEIFPLBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x1C167F0", Offset = "0x1C15BF0", VA = "0x181C167F0")]
	private void BAGBMNEAKAN(int JMBKGKDJDLG, int EKEODIBANIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x1C18450", Offset = "0x1C17850", VA = "0x181C18450")]
	private void FBJKNHKCEFF(int JMBKGKDJDLG, int EKEODIBANIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x1C1A4E0", Offset = "0x1C198E0", VA = "0x181C1A4E0")]
	private void ODPPECNPIOC(int FCAAEBKCPMM, int EKEODIBANIH, IOPBEJICCGN HGOEIFPLBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x1C19D20", Offset = "0x1C19120", VA = "0x181C19D20", Slot = "33")]
	[AsyncStateMachine(typeof(HILIMIABJCM))]
	public Task<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> MEILANEMCOG(OKFPGADAGCG<COCIAMPEGDB> CLLCDEJPLBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x1C19C10", Offset = "0x1C19010", VA = "0x181C19C10", Slot = "34")]
	[AsyncStateMachine(typeof(EFILMGAIBGK))]
	public Task<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> LMJCCJCNFLA(OKFPGADAGCG<MDPMJJMJGJG> HKFFKMNNMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x1C1B6B0", Offset = "0x1C1AAB0", VA = "0x181C1B6B0", Slot = "35")]
	[AsyncStateMachine(typeof(AGACPIPILAK))]
	public Task<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> PBDHMBBHBIO(OKFPGADAGCG<COCIAMPEGDB> CLLCDEJPLBE, OKFPGADAGCG<COCIAMPEGDB> GJAGJOCFELH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x1C172E0", Offset = "0x1C166E0", VA = "0x181C172E0", Slot = "36")]
	[AsyncStateMachine(typeof(CCDCIHFJLKI))]
	public Task<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> DOMBOIAEFCJ(OKFPGADAGCG<MDPMJJMJGJG> HKFFKMNNMFP, OKFPGADAGCG<MDPMJJMJGJG> GJAGJOCFELH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x1C19E30", Offset = "0x1C19230", VA = "0x181C19E30", Slot = "37")]
	[AsyncStateMachine(typeof(GEFIHFHPHCC))]
	public Task<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> MNBLLEGCNIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x1C19040", Offset = "0x1C18440", VA = "0x181C19040", Slot = "38")]
	[AsyncStateMachine(typeof(CHELKHLPCFB))]
	public Task<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> IEDMAMNCJBH(string EMGPIOIKIHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x1C16840", Offset = "0x1C15C40", VA = "0x181C16840", Slot = "39")]
	[AsyncStateMachine(typeof(OBCMPJBBIPK))]
	public Task<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> BLINDFKPLGF(OKFPGADAGCG<COCIAMPEGDB> CLLCDEJPLBE, string DKFEAPHKBMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x1C16600", Offset = "0x1C15A00", VA = "0x181C16600", Slot = "40")]
	[AsyncStateMachine(typeof(FEFGGKHOAKO))]
	public Task<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> AEELFNJELOG(OKFPGADAGCG<MDPMJJMJGJG> HKFFKMNNMFP, string DKFEAPHKBMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x1C18C70", Offset = "0x1C18070", VA = "0x181C18C70")]
	internal void HLJOCCEIFHI(OKFPGADAGCG<OJDCJBFDJOM> LPCGJALKADL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public sealed class INMKNAOBIAH : LHFFAOLHENF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public interface KOMLFDNNDJO
	{
		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		MJIEGDDILJC HOFMJHOFHHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<OCFHMGCGDAI> HCEJILIHACA(CancellationToken OMFABMCIOAC);

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<CMFAAJONIFD> FELGIDJMOFK(CancellationToken OMFABMCIOAC);

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<NDFHPLNPLMM> KCHFIKOOCIK(CancellationToken OMFABMCIOAC);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct BBLPAFGNKPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public AsyncTaskMethodBuilder<INMKNAOBIAH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public MGIIALDDNBJ circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public OCFHMGCGDAI roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public CMFAAJONIFD superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private KOMLFDNNDJO <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private CMFAAJONIFD <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private TaskAwaiter<OCFHMGCGDAI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private TaskAwaiter<CMFAAJONIFD> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private TaskAwaiter<NDFHPLNPLMM> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x1C01F80", Offset = "0x1C01380", VA = "0x181C01F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x1C027F0", Offset = "0x1C01BF0", VA = "0x181C027F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly NENAKDOFDJC MMGMNIEOJKI;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public NENAKDOFDJC NCAKAGPPEPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x767650", Offset = "0x766A50", VA = "0x180767650")]
	private INMKNAOBIAH(NENAKDOFDJC HJHJILBNAPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x1C0F230", Offset = "0x1C0E630", VA = "0x181C0F230")]
	[AsyncStateMachine(typeof(BBLPAFGNKPK))]
	public static Task<INMKNAOBIAH> FJLFLKJKHCC(MGIIALDDNBJ OMPBOPGBPIK, OCFHMGCGDAI? NDJHINJFLAD, CMFAAJONIFD? ILOGCLKGEMA, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x1C0F210", Offset = "0x1C0E610", VA = "0x181C0F210", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public readonly struct MPMPJGCNOEF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct PNAAOAAMAGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public AsyncTaskMethodBuilder<MEEAMGFNJIM<object, DBNOAAMPCCP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public MPMPJGCNOEF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public LCJOHDOCEBL action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private TaskAwaiter<MEEAMGFNJIM<object, DBNOAAMPCCP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x1C1C0E0", Offset = "0x1C1B4E0", VA = "0x181C1C0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x1C1C370", Offset = "0x1C1B770", VA = "0x181C1C370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct MCIPCBCGKMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public AsyncTaskMethodBuilder<MEEAMGFNJIM<bool, DBNOAAMPCCP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public BOGJDKIJOLK rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public OCFHMGCGDAI circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public CMFAAJONIFD superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public MPMPJGCNOEF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private LCJOHDOCEBL[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private TaskAwaiter<MEEAMGFNJIM<object, DBNOAAMPCCP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x1C11300", Offset = "0x1C10700", VA = "0x181C11300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x1C116E0", Offset = "0x1C10AE0", VA = "0x181C116E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct IAHLLPKBDLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public AsyncTaskMethodBuilder<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public MPMPJGCNOEF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private TaskAwaiter<MEEAMGFNJIM<object, DBNOAAMPCCP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x1C0E590", Offset = "0x1C0D990", VA = "0x181C0E590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x1C0E870", Offset = "0x1C0DC70", VA = "0x181C0E870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private readonly GHOAKJOMOPC ECHPOECIDOM;

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x7D3110", Offset = "0x7D2510", VA = "0x1807D3110")]
	public MPMPJGCNOEF(GHOAKJOMOPC DFHAHCFPJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x1C133C0", Offset = "0x1C127C0", VA = "0x181C133C0")]
	[AsyncStateMachine(typeof(PNAAOAAMAGC))]
	private Task<MEEAMGFNJIM<object, DBNOAAMPCCP>> DDIAGKIDPDK(LCJOHDOCEBL PAFFKHOCLGN, bool LBEBPDMECAC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x1C134F0", Offset = "0x1C128F0", VA = "0x181C134F0")]
	[AsyncStateMachine(typeof(MCIPCBCGKMM))]
	public Task<MEEAMGFNJIM<bool, DBNOAAMPCCP?>>? FFDIBDMCEIF(int MNNNNBPEBKF, BOGJDKIJOLK? FCLGCMFKGNJ, OCFHMGCGDAI? JHPBHCGOAOG, CMFAAJONIFD? ILOGCLKGEMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x1C13650", Offset = "0x1C12A50", VA = "0x181C13650")]
	[AsyncStateMachine(typeof(IAHLLPKBDLO))]
	public Task<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> OMMIKAHKMGL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public sealed class GPHCFMBOJFN : OJDEJHGFJAE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly APKGENLDBBF HAFMJKLBOOB;

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public APKGENLDBBF KMMBPONHMFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x767650", Offset = "0x766A50", VA = "0x180767650")]
	private GPHCFMBOJFN(APKGENLDBBF KLEPHJBOOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x1C0BA30", Offset = "0x1C0AE30", VA = "0x181C0BA30")]
	public static GPHCFMBOJFN HNNKJEMPCFP(MGIIALDDNBJ OMPBOPGBPIK, BOGJDKIJOLK EHLNMKPLMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x1C0BA10", Offset = "0x1C0AE10", VA = "0x181C0BA10", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface HOAAKDECBHN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	NICPLMDNOBF MFIKBPDMEAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	AAIJHKLJJJE HHEFMHLCPOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	ODNNNMICKJM JMDADLMJMLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	AKCKKKMNCAO EDCAGMGACEF
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	HPMLMHOPEKJ LIBGDAONDBH
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public interface PJLBJGBCJII : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000081")]
	HOAAKDECBHN? POJMBFODKIA
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	bool JMGKFCEFHMB
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	bool KLJALALCPJB
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<HOAAKDECBHN?>? PNJHCKBDGNB();

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task AODNKLOGIPI(MGIIALDDNBJ OMPBOPGBPIK, BOGJDKIJOLK EHLNMKPLMAA, OCFHMGCGDAI? OIJHGFCMEHF, CMFAAJONIFD? AKODOEKJGDP);
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[DDMJEPCLODL("IStaticCV2Instance")]
public interface LHFFAOLHENF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000084")]
	NENAKDOFDJC NCAKAGPPEPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[DDMJEPCLODL("IStaticEVInstance")]
public interface OJDEJHGFJAE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000085")]
	APKGENLDBBF KMMBPONHMFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public sealed class FKCEHHIACKL : EPPDJMDOLMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly MGIIALDDNBJ JMGCILILDBJ;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public JNCGMBOGKMC? OMCMBELJBID
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x1C0A820", Offset = "0x1C09C20", VA = "0x181C0A820", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x767650", Offset = "0x766A50", VA = "0x180767650")]
	internal FKCEHHIACKL(MGIIALDDNBJ OMPBOPGBPIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public sealed class AKCKKKMNCAO : JNCGMBOGKMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly LHFFAOLHENF OALPAJIAPEC;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public OFHGPGGODND DDIAGKIDPDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x1C00B10", Offset = "0x1BFFF10", VA = "0x181C00B10", Slot = "4")]
		get
		{
			return default(OFHGPGGODND);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public KPIBOFJMCHP ENGODODIHGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x1C00A50", Offset = "0x1BFFE50", VA = "0x181C00A50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public MIPNFHKLOLI<IOFALGJHBGF> ODFLFLILAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x1C00AB0", Offset = "0x1BFFEB0", VA = "0x181C00AB0", Slot = "6")]
		get
		{
			return default(MIPNFHKLOLI<IOFALGJHBGF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public NENAKDOFDJC JOIAGLGDJGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x1C00A00", Offset = "0x1BFFE00", VA = "0x181C00A00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x767650", Offset = "0x766A50", VA = "0x180767650")]
	public AKCKKKMNCAO(LHFFAOLHENF NKPODOIIHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x1C00990", Offset = "0x1BFFD90", VA = "0x181C00990")]
	public bool KEOAIDMDJEG([In] MIPNFHKLOLI<IOFALGJHBGF> OFLFFIGFOIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x1C00990", Offset = "0x1BFFD90", VA = "0x181C00990", Slot = "8")]
	private bool ACLDBIACLDN([In] MIPNFHKLOLI<IOFALGJHBGF> OFLFFIGFOIA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public static class EGFNDAHACID
{
	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x1C06350", Offset = "0x1C05750", VA = "0x181C06350")]
	public static PPHKPIDMIPE<PIKOLKDMDCL, LCJOHDOCEBL, MGIIALDDNBJ, OJLPDABNGCI.LHGAIJCJEMO<PIKOLKDMDCL, LCJOHDOCEBL, MGIIALDDNBJ>> FFAMHNEPGFF([In] this PPHKPIDMIPE<PIKOLKDMDCL, LCJOHDOCEBL, MGIIALDDNBJ, OJLPDABNGCI.LHGAIJCJEMO<PIKOLKDMDCL, LCJOHDOCEBL, MGIIALDDNBJ>> JIOIBMPKNGN)
	{
		return default(PPHKPIDMIPE<PIKOLKDMDCL, LCJOHDOCEBL, MGIIALDDNBJ, OJLPDABNGCI.LHGAIJCJEMO<PIKOLKDMDCL, LCJOHDOCEBL, MGIIALDDNBJ>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public sealed class LIPNNCDJBGB : ACFHIJIGPFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly MGIIALDDNBJ JMGCILILDBJ;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool KLJALALCPJB
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x1C111F0", Offset = "0x1C105F0", VA = "0x181C111F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x767650", Offset = "0x766A50", VA = "0x180767650")]
	internal LIPNNCDJBGB(MGIIALDDNBJ OMPBOPGBPIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public sealed class DOCBHODGPBF : MIJGGABCNJJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct IPHLMDJKBEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public AsyncTaskMethodBuilder<BCIEEEAOHOF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public DOCBHODGPBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private TaskAwaiter<HOAAKDECBHN?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x1C0F390", Offset = "0x1C0E790", VA = "0x181C0F390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x1C0F640", Offset = "0x1C0EA40", VA = "0x181C0F640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly MGIIALDDNBJ JMGCILILDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private IReadOnlyList<MIPNFHKLOLI<MKPDEFBPMHA>>? LPFLACAFHIG;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public BCIEEEAOHOF? OMCMBELJBID
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x1C053C0", Offset = "0x1C047C0", VA = "0x181C053C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool DJPELIJNFCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x1C05AE0", Offset = "0x1C04EE0", VA = "0x181C05AE0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool ENCEPKEOJNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x1C05360", Offset = "0x1C04760", VA = "0x181C05360", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x767650", Offset = "0x766A50", VA = "0x180767650")]
	internal DOCBHODGPBF(MGIIALDDNBJ OMPBOPGBPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x1C057B0", Offset = "0x1C04BB0", VA = "0x181C057B0", Slot = "7")]
	[AsyncStateMachine(typeof(IPHLMDJKBEM))]
	public Task<BCIEEEAOHOF> JBLIJMGOLDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x1C05440", Offset = "0x1C04840", VA = "0x181C05440")]
	internal Dictionary<MIPNFHKLOLI<IOFALGJHBGF>, Guid> GBPICOHODHI(IEnumerable<DAJJDHFICPI> IJEDCOIHAAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x1C05170", Offset = "0x1C04570", VA = "0x181C05170")]
	public MEEAMGFNJIM<MDPHAFPKPNH, IEAOACDDPEG> AHLPLEECDDC([In] MDPHAFPKPNH AEFCOHFEBBD, IEnumerable<DAJJDHFICPI> LEEIOGKJPKL, int NMDLGILNDBJ)
	{
		return default(MEEAMGFNJIM<MDPHAFPKPNH, IEAOACDDPEG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x1C05AA0", Offset = "0x1C04EA0", VA = "0x181C05AA0")]
	internal static IPABAODHIGJ JPGLMOOHNDP(EEPDDJEGOFM HOHPJLHPJPG, LBIPCGPOOIC BLMOEKLGDFI)
	{
		return default(IPABAODHIGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x1C058A0", Offset = "0x1C04CA0", VA = "0x181C058A0", Slot = "8")]
	private MEEAMGFNJIM<MDPHAFPKPNH, IEAOACDDPEG> JOHHMNNAAJC([In] MDPHAFPKPNH AEFCOHFEBBD, IEnumerable<DAJJDHFICPI> LEEIOGKJPKL, int NMDLGILNDBJ)
	{
		return default(MEEAMGFNJIM<MDPHAFPKPNH, IEAOACDDPEG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x1C05B40", Offset = "0x1C04F40", VA = "0x181C05B40")]
	[CompilerGenerated]
	internal static IPABAODHIGJ LKMIMINLDMB(EEPDDJEGOFM GODDELDCJCN, LBIPCGPOOIC CBAPJNGPNLI)
	{
		return default(IPABAODHIGJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public sealed class HPMLMHOPEKJ : BCIEEEAOHOF
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	internal static class OCBLDOAMNHK
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class PCMPCCGLBDA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public GEBOGBCOJPJ spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
			public PCMPCCGLBDA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x1C208E0", Offset = "0x1C1FCE0", VA = "0x181C208E0")]
			internal bool KBFHBBMMPAM(PINPLNGICBI n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private sealed class FFLHJJCJKKB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
			public FFLHJJCJKKB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x1C1EFC0", Offset = "0x1C1E3C0", VA = "0x181C1EFC0")]
			internal void OPDLIOFOCMN(PINPLNGICBI n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x1C154D0", Offset = "0x1C148D0", VA = "0x181C154D0")]
		public static MEEAMGFNJIM<BCIEEEAOHOF.FBDKOEICHJN, IEAOACDDPEG> LAGINJJKIEC(HPMLMHOPEKJ CLFMFOEGLFG, [In] BCIEEEAOHOF.BNOBGHACFMA LHPGBFGMEDK)
		{
			return default(MEEAMGFNJIM<BCIEEEAOHOF.FBDKOEICHJN, IEAOACDDPEG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x1C14780", Offset = "0x1C13B80", VA = "0x181C14780")]
		internal static MEEAMGFNJIM<(DBHBPHKMKBJ, HBIOJHLGOIE), DBNOAAMPCCP> KOKGLLEJPPJ(HPMLMHOPEKJ CLFMFOEGLFG, HBIOJHLGOIE JHFEODMFDGK, bool LGDOBIONJGG, [In] MIPNFHKLOLI<IOFALGJHBGF> GLBGNLOGMAI, [In] int? ICFLFKPHKFL, [In] IPABAODHIGJ? FLHJJEEEPIO, [In] IPABAODHIGJ? NPOCPJCLGKF)
		{
			return default(MEEAMGFNJIM<(DBHBPHKMKBJ, HBIOJHLGOIE), DBNOAAMPCCP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x1C142F0", Offset = "0x1C136F0", VA = "0x181C142F0")]
		private static void FFLAOCMLLLD(bool LGDOBIONJGG, DAJJDHFICPI JINLJHLPIMH, DBHBPHKMKBJ AEIDKKIEPOL, [In] MIPNFHKLOLI<IOFALGJHBGF> GLBGNLOGMAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x1C13EE0", Offset = "0x1C132E0", VA = "0x181C13EE0")]
		public static void DFFPMNBODCI(EAJFEDCIBLD GGNNKNFNCNK, [In] BCIEEEAOHOF.KDHIGPOINLN FPLELFOPGAN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly MGIIALDDNBJ JMGCILILDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly LHFFAOLHENF OALPAJIAPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly OJDEJHGFJAE JHIMBAFEKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private readonly GMNMAFJAEKA FEFOOCHLJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private readonly DOCBHODGPBF HDGGNAHMFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private Dictionary<MIPNFHKLOLI<EHDOJPLINGC>, AMIHCCNNHOK> CJLHHPJIBBO;

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x1C0E210", Offset = "0x1C0D610", VA = "0x181C0E210")]
	public HPMLMHOPEKJ(MGIIALDDNBJ OMPBOPGBPIK, LHFFAOLHENF NKPODOIIHEB, OJDEJHGFJAE FCBOMBAIDMF, DOCBHODGPBF MHMCCEHANFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x1C0DEC0", Offset = "0x1C0D2C0", VA = "0x181C0DEC0")]
	public AMIHCCNNHOK? NFLKDLBDDMM([In] MIPNFHKLOLI<EHDOJPLINGC> CNCFOBBIEIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x1C0C990", Offset = "0x1C0BD90", VA = "0x181C0C990")]
	private void CECCOOCBBLN(MIPNFHKLOLI<EHDOJPLINGC> CNCFOBBIEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x1C0D980", Offset = "0x1C0CD80", VA = "0x181C0D980")]
	private AMIHCCNNHOK? MNNLKDLKHOH([In] MIPNFHKLOLI<EHDOJPLINGC> CNCFOBBIEIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x1C0D710", Offset = "0x1C0CB10", VA = "0x181C0D710")]
	public LBIPCGPOOIC? LFIOBKJOOJM([In] MIPNFHKLOLI<EHDOJPLINGC> CNCFOBBIEIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x1C0CDA0", Offset = "0x1C0C1A0", VA = "0x181C0CDA0")]
	public AEKDMDCHPLL? GKPINAKEJOK([In] MIPNFHKLOLI<IOFALGJHBGF> OFLFFIGFOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x1C0E180", Offset = "0x1C0D580", VA = "0x181C0E180")]
	private GEBOGBCOJPJ? PGLJOOJIGMP([In] MIPNFHKLOLI<IOFALGJHBGF> OFLFFIGFOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x1C0C7F0", Offset = "0x1C0BBF0", VA = "0x181C0C7F0")]
	private AEKDMDCHPLL? AGPPNJHLBCG([In] MIPNFHKLOLI<IOFALGJHBGF> OFLFFIGFOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x1C0E020", Offset = "0x1C0D420", VA = "0x181C0E020", Slot = "6")]
	public IEnumerable<BGDPFFMCEIB> NNPKKBGAIOC(bool NADIAMOKNDD, bool HIHDJJJICHP, bool OHEBIAELJLN, bool LPGPLGCHDIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x1C0CD70", Offset = "0x1C0C170", VA = "0x181C0CD70")]
	public MEEAMGFNJIM<BCIEEEAOHOF.FBDKOEICHJN, IEAOACDDPEG> GDJDIDBCFHD([In] BCIEEEAOHOF.BNOBGHACFMA LHPGBFGMEDK)
	{
		return default(MEEAMGFNJIM<BCIEEEAOHOF.FBDKOEICHJN, IEAOACDDPEG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x1C0D790", Offset = "0x1C0CB90", VA = "0x181C0D790", Slot = "8")]
	public OMAGFAABBKJ LJMIBOLEIKI(IEnumerable<DAJJDHFICPI> LEEIOGKJPKL)
	{
		return default(OMAGFAABBKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x1C0D190", Offset = "0x1C0C590", VA = "0x181C0D190", Slot = "9")]
	public OMAGFAABBKJ IFMNBHGDFHG()
	{
		return default(OMAGFAABBKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x1C0D5A0", Offset = "0x1C0C9A0", VA = "0x181C0D5A0")]
	private JNGCAMDGEKN IKAAOCGNJLL(HCKHNCKIMEB LFJJHMBODKI, IEnumerable<MIPNFHKLOLI<IOFALGJHBGF>> LKPLEBIGEBI, IEnumerable<MIPNFHKLOLI<EHDOJPLINGC>> EIAMKGNMDMC)
	{
		return default(JNGCAMDGEKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x1C0D2B0", Offset = "0x1C0C6B0", VA = "0x181C0D2B0", Slot = "10")]
	public JNGCAMDGEKN IKAAOCGNJLL(HCKHNCKIMEB LFJJHMBODKI, IEnumerable<MIPNFHKLOLI<EHDOJPLINGC>> EIAMKGNMDMC, IEnumerable<DAJJDHFICPI> LEEIOGKJPKL)
	{
		return default(JNGCAMDGEKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x1C0C9F0", Offset = "0x1C0BDF0", VA = "0x181C0C9F0")]
	private static IEnumerable<MIPNFHKLOLI<IOFALGJHBGF>> CONLFCBBEPN(IEnumerable<DAJJDHFICPI> LEEIOGKJPKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x1C0DA20", Offset = "0x1C0CE20", VA = "0x181C0DA20")]
	private IEnumerable<MIPNFHKLOLI<EHDOJPLINGC>> NCPEDBEOHDC(IEnumerable<DAJJDHFICPI> LEEIOGKJPKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x1C0D100", Offset = "0x1C0C500", VA = "0x181C0D100", Slot = "4")]
	private AEKDMDCHPLL HLIBLCOBMLM([In] MIPNFHKLOLI<IOFALGJHBGF> OFLFFIGFOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x1C0CFC0", Offset = "0x1C0C3C0", VA = "0x181C0CFC0", Slot = "5")]
	private AMIHCCNNHOK HDEKGOFLANJ([In] MIPNFHKLOLI<EHDOJPLINGC> CNCFOBBIEIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x1C0CD70", Offset = "0x1C0C170", VA = "0x181C0CD70", Slot = "7")]
	private MEEAMGFNJIM<BCIEEEAOHOF.FBDKOEICHJN, IEAOACDDPEG> DCEPCKDHAJP([In] BCIEEEAOHOF.BNOBGHACFMA LHPGBFGMEDK)
	{
		return default(MEEAMGFNJIM<BCIEEEAOHOF.FBDKOEICHJN, IEAOACDDPEG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x1C0D110", Offset = "0x1C0C510", VA = "0x181C0D110")]
	[CompilerGenerated]
	private BMJCCAGEGNN IDHPKCGOAGM(ICGHHAJIBAE PBOOCHALMNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x1C0E110", Offset = "0x1C0D510", VA = "0x181C0E110")]
	[CompilerGenerated]
	private LBIPCGPOOIC PBNLCJHAIIG(MIPNFHKLOLI<EHDOJPLINGC> PBOOCHALMNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x1C0CF50", Offset = "0x1C0C350", VA = "0x181C0CF50")]
	[CompilerGenerated]
	private GEBOGBCOJPJ GOEEPAACJOB(MIPNFHKLOLI<IOFALGJHBGF> PBOOCHALMNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public sealed class BMJCCAGEGNN : BGDPFFMCEIB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct OBDBGAPEOCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public AsyncTaskMethodBuilder<MEEAMGFNJIM<OKFPGADAGCG<COCIAMPEGDB>, DBNOAAMPCCP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public BMJCCAGEGNN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public MIPNFHKLOLI<IOFALGJHBGF> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public MIPNFHKLOLI<EHDOJPLINGC> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public OKFPGADAGCG<OJDCJBFDJOM> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private TaskAwaiter<MEEAMGFNJIM<OKFPGADAGCG<COCIAMPEGDB>, DBNOAAMPCCP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x1C205F0", Offset = "0x1C1F9F0", VA = "0x181C205F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x1C20870", Offset = "0x1C1FC70", VA = "0x181C20870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private struct GLLNKACKHMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public AsyncTaskMethodBuilder<MEEAMGFNJIM<OKFPGADAGCG<MDPMJJMJGJG>, DBNOAAMPCCP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public BMJCCAGEGNN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public MIPNFHKLOLI<IOFALGJHBGF> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public MIPNFHKLOLI<EHDOJPLINGC> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public OKFPGADAGCG<OJDCJBFDJOM> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private TaskAwaiter<MEEAMGFNJIM<OKFPGADAGCG<MDPMJJMJGJG>, DBNOAAMPCCP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x1C1EFE0", Offset = "0x1C1E3E0", VA = "0x181C1EFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x1C1F260", Offset = "0x1C1E660", VA = "0x181C1F260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly ICGHHAJIBAE GFNPHGAEIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly LHFFAOLHENF OALPAJIAPEC;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public string FKDLEOOKPJN
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x1C1D580", Offset = "0x1C1C980", VA = "0x181C1D580", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x1C1D890", Offset = "0x1C1CC90", VA = "0x181C1D890")]
	public BMJCCAGEGNN(ICGHHAJIBAE PONPJFOOBAO, LHFFAOLHENF NKPODOIIHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x1C1D5B0", Offset = "0x1C1C9B0", VA = "0x181C1D5B0", Slot = "5")]
	[AsyncStateMachine(typeof(OBDBGAPEOCB))]
	public Task<MEEAMGFNJIM<OKFPGADAGCG<COCIAMPEGDB>, DBNOAAMPCCP>> IKBJBCPJFKG(MIPNFHKLOLI<IOFALGJHBGF> OFLFFIGFOIA, MIPNFHKLOLI<EHDOJPLINGC> CNCFOBBIEIM, OKFPGADAGCG<OJDCJBFDJOM> FAOHNDGDAJK, string DKFEAPHKBMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x1C1D720", Offset = "0x1C1CB20", VA = "0x181C1D720", Slot = "6")]
	[AsyncStateMachine(typeof(GLLNKACKHMD))]
	public Task<MEEAMGFNJIM<OKFPGADAGCG<MDPMJJMJGJG>, DBNOAAMPCCP>> PGHMCJGBCMK(MIPNFHKLOLI<IOFALGJHBGF> OFLFFIGFOIA, MIPNFHKLOLI<EHDOJPLINGC> CNCFOBBIEIM, OKFPGADAGCG<OJDCJBFDJOM> FAOHNDGDAJK, string DKFEAPHKBMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public sealed class CPIMBCODNCO : DDBPLIOJFAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly ICGHHAJIBAE LADLDAOEIKE;

	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private static readonly HashSet<ICGHHAJIBAE> BHPHJGLDEHN;

	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private static readonly HashSet<ICGHHAJIBAE> FMMPLFIHGHP;

	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private static readonly HashSet<ICGHHAJIBAE> BACMLHJDAJH;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public TypeKey GJLBOFLDHNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x1C1EE50", Offset = "0x1C1E250", VA = "0x181C1EE50", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public bool POPEMBFEIDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x1C1EE40", Offset = "0x1C1E240", VA = "0x181C1EE40", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool FEMJEHBOOFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x1C1EEA0", Offset = "0x1C1E2A0", VA = "0x181C1EEA0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool CHBKHGLNMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x1C1EDC0", Offset = "0x1C1E1C0", VA = "0x181C1EDC0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x1C1DBD0", Offset = "0x1C1CFD0", VA = "0x181C1DBD0")]
	public bool PGLHEGKPJDK(string LPCGJALKADL, [Out] EPAAJHMOMDP HPKIHOIGLID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x767650", Offset = "0x766A50", VA = "0x180767650")]
	public CPIMBCODNCO(ICGHHAJIBAE GHADCFDOJAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x1C1DA40", Offset = "0x1C1CE40", VA = "0x181C1DA40")]
	internal static TypeKey IEJGJCELEOK(ICGHHAJIBAE DJMKKNDNCBM)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x1C1D580", Offset = "0x1C1C980", VA = "0x181C1D580", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public readonly struct HGCCCKADAAJ : FJCNHIKCJBH.PLICBKEIOIM<LCJOHDOCEBL, EOKBOBHHEEM>
{
	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x1C1FCE0", Offset = "0x1C1F0E0", VA = "0x181C1FCE0", Slot = "4")]
	public int LPLGDLGLBLI(EOKBOBHHEEM JMBKGKDJDLG, LCJOHDOCEBL PAFFKHOCLGN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x1C1FCB0", Offset = "0x1C1F0B0", VA = "0x181C1FCB0", Slot = "5")]
	public LCJOHDOCEBL ICHGBOPLIPL(EOKBOBHHEEM JMBKGKDJDLG, LCJOHDOCEBL PAFFKHOCLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x1C1FBF0", Offset = "0x1C1EFF0", VA = "0x181C1FBF0", Slot = "6")]
	public LCJOHDOCEBL BDNHEMOJLDF(EOKBOBHHEEM JMBKGKDJDLG, LCJOHDOCEBL PAFFKHOCLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x1C1FD00", Offset = "0x1C1F100", VA = "0x181C1FD00", Slot = "7")]
	public IReadOnlyList<LCJOHDOCEBL> OHLGPADNBAF(EOKBOBHHEEM JMBKGKDJDLG, LCJOHDOCEBL PAFFKHOCLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x1C1FCA0", Offset = "0x1C1F0A0", VA = "0x181C1FCA0", Slot = "8")]
	public LCJOHDOCEBL[] HMEDMKEFGPD(EOKBOBHHEEM JMBKGKDJDLG, LCJOHDOCEBL PAFFKHOCLGN, int DANGDNPMMNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x1C1FC40", Offset = "0x1C1F040", VA = "0x181C1FC40", Slot = "9")]
	public bool CMAJDPKOOPH(EOKBOBHHEEM JMBKGKDJDLG, LCJOHDOCEBL PAFFKHOCLGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x1C1FC60", Offset = "0x1C1F060", VA = "0x181C1FC60", Slot = "10")]
	public bool EAADENOOILO(EOKBOBHHEEM JMBKGKDJDLG, LCJOHDOCEBL PAFFKHOCLGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x1C1FCC0", Offset = "0x1C1F0C0", VA = "0x181C1FCC0", Slot = "11")]
	public bool JCAMEKENFAK(EOKBOBHHEEM JMBKGKDJDLG, LCJOHDOCEBL PAFFKHOCLGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x1C1FC20", Offset = "0x1C1F020", VA = "0x181C1FC20", Slot = "12")]
	public bool BLGMNMILFPN(EOKBOBHHEEM JMBKGKDJDLG, LCJOHDOCEBL PAFFKHOCLGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x1C1FBD0", Offset = "0x1C1EFD0", VA = "0x181C1FBD0", Slot = "13")]
	public bool AGLNLBAKGNL(EOKBOBHHEEM CIFCOCHIFFA, LCJOHDOCEBL PAFFKHOCLGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x1C1FC80", Offset = "0x1C1F080", VA = "0x181C1FC80", Slot = "14")]
	public bool FCEPCEMIALG(EOKBOBHHEEM JMBKGKDJDLG, LCJOHDOCEBL PAFFKHOCLGN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public abstract class IEECLFKKFEI : BJEONLLPMDM
{
	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public KABHJOMINLG.MOGBIGECOLJ AAEPJLOCBAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x1C1FD70", Offset = "0x1C1F170", VA = "0x181C1FD70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public abstract BDBGKAHDKMI.AKAKNPELNKP FAJOIGOFNEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public abstract MGIIALDDNBJ.DDKOGNBIIEP KPMFKCMJPNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public abstract INMKNAOBIAH.KOMLFDNNDJO KMJMDAJCCOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public OJLPDABNGCI.LHGAIJCJEMO<PIKOLKDMDCL, LCJOHDOCEBL, MGIIALDDNBJ> GNBFAIENBGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x1C1FD20", Offset = "0x1C1F120", VA = "0x181C1FD20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public abstract PGBJLPPKMAA GOKBCEJHAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public abstract EGOCMJDPKGB GBOKJIEPKIN
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public abstract FOAMILBAHIL LDFEEJLCALH
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public abstract DCGAOOCAHBD NOPGCCLCADL
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public abstract LAPCFOKGHND MMNKIIBLCBB
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	protected IEECLFKKFEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public sealed class PHCLGJHCODK : KPIBOFJMCHP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct PDECOMAOEHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public AsyncTaskMethodBuilder<MEEAMGFNJIM<object, DBNOAAMPCCP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public PHCLGJHCODK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public LCJOHDOCEBL action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private TaskAwaiter<MEEAMGFNJIM<object, DBNOAAMPCCP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x1C20980", Offset = "0x1C1FD80", VA = "0x181C20980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x1C20C20", Offset = "0x1C20020", VA = "0x181C20C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct KDBKLMGILMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public AsyncTaskMethodBuilder<MEEAMGFNJIM<KCLBOAMOHJB, DBNOAAMPCCP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public PHCLGJHCODK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public IReadOnlyList<LCJOHDOCEBL> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private TaskAwaiter<MEEAMGFNJIM<object, DBNOAAMPCCP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x1C1FFB0", Offset = "0x1C1F3B0", VA = "0x181C1FFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x1C20330", Offset = "0x1C1F730", VA = "0x181C20330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly GHOAKJOMOPC ECHPOECIDOM;

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x767650", Offset = "0x766A50", VA = "0x180767650")]
	public PHCLGJHCODK(GHOAKJOMOPC DFHAHCFPJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x1C20DC0", Offset = "0x1C201C0", VA = "0x181C20DC0")]
	[AsyncStateMachine(typeof(PDECOMAOEHM))]
	private Task<MEEAMGFNJIM<object, DBNOAAMPCCP>> DDIAGKIDPDK(LCJOHDOCEBL PAFFKHOCLGN, bool LBEBPDMECAC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x1C20C90", Offset = "0x1C20090", VA = "0x181C20C90", Slot = "4")]
	[AsyncStateMachine(typeof(KDBKLMGILMO))]
	public Task<MEEAMGFNJIM<KCLBOAMOHJB, DBNOAAMPCCP>> BADHELNHLHD(IReadOnlyList<LCJOHDOCEBL> HIKGMMOGGPJ, bool LBEBPDMECAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct BECPAMCPDBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	internal AKKCLDONNMO<BIIHHKPNIMM, LCJOHDOCEBL, KFAEFFPCHEC> LADLDAOEIKE;

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x1C10110", Offset = "0x1C0F510", VA = "0x181C10110")]
	private BECPAMCPDBM([In] AKKCLDONNMO<BIIHHKPNIMM, LCJOHDOCEBL, KFAEFFPCHEC> JLFFAMFKFBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x1C1D520", Offset = "0x1C1C920", VA = "0x181C1D520")]
	public static BECPAMCPDBM CLFIPFKIGEN()
	{
		return default(BECPAMCPDBM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public static class HFJIDHCIKJK
{
	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0xA09C60", Offset = "0xA09060", VA = "0x180A09C60")]
	public static AKKCLDONNMO<BIIHHKPNIMM, LCJOHDOCEBL, KFAEFFPCHEC> HCJDMNMLKKO(this BECPAMCPDBM CLFMFOEGLFG)
	{
		return default(AKKCLDONNMO<BIIHHKPNIMM, LCJOHDOCEBL, KFAEFFPCHEC>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct KFAEFFPCHEC : HHKPBEBABPA.JHAHCKBGKFB<BIIHHKPNIMM, LCJOHDOCEBL>
{
	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x1C203A0", Offset = "0x1C1F7A0", VA = "0x181C203A0", Slot = "5")]
	public LCJOHDOCEBL LIJDHLKCCNB(BIIHHKPNIMM[] JJKICGPJGEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x11E3670", Offset = "0x11E2A70", VA = "0x1811E3670")]
	public int NKHOMMFKPKE([In] BIIHHKPNIMM LNHPBLNPKIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x11E3670", Offset = "0x11E2A70", VA = "0x1811E3670", Slot = "4")]
	private int CLOOBKCHNEN([In] BIIHHKPNIMM LFOHHIOCADA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct MIEHHDMGHFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	internal EBJHNJMMFML<BPBMIFDGIFI, LCJOHDOCEBL, IKKFKGIOBMG> LADLDAOEIKE;

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x1C10110", Offset = "0x1C0F510", VA = "0x181C10110")]
	private MIEHHDMGHFO([In] EBJHNJMMFML<BPBMIFDGIFI, LCJOHDOCEBL, IKKFKGIOBMG> KNGIMLEMOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x1C20590", Offset = "0x1C1F990", VA = "0x181C20590")]
	public static MIEHHDMGHFO CLFIPFKIGEN()
	{
		return default(MIEHHDMGHFO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public static class DGPAGEMNCAP
{
	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0xA09C60", Offset = "0xA09060", VA = "0x180A09C60")]
	public static EBJHNJMMFML<BPBMIFDGIFI, LCJOHDOCEBL, IKKFKGIOBMG> HCJDMNMLKKO(this MIEHHDMGHFO CLFMFOEGLFG)
	{
		return default(EBJHNJMMFML<BPBMIFDGIFI, LCJOHDOCEBL, IKKFKGIOBMG>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct IKKFKGIOBMG : KEPLOFOGCPD.AFGFEPEIMIO<BPBMIFDGIFI, LCJOHDOCEBL>
{
	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x11E3670", Offset = "0x11E2A70", VA = "0x1811E3670")]
	public int LCMMHEFHGFG([In] BPBMIFDGIFI LNHPBLNPKIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x1C1FDC0", Offset = "0x1C1F1C0", VA = "0x181C1FDC0", Slot = "5")]
	public LCJOHDOCEBL ICHBFBEMBOK(BPBMIFDGIFI[] CBAHIBDBJFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x11E3670", Offset = "0x11E2A70", VA = "0x1811E3670", Slot = "4")]
	private int EGIEGACELMB([In] BPBMIFDGIFI LNHPBLNPKIG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public interface PGBJLPPKMAA
{
	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JIDOHNCCABE([In] MEEAMGFNJIM<EOKBOBHHEEM, IEAOACDDPEG> BBHPNPGLHIG);
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public static class APLDLNKGNED
{
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x29F64B0", Offset = "0x29F58B0", VA = "0x1829F64B0")]
	public static bool JIDOHNCCABE<TOk, TErr>(this PGBJLPPKMAA CLFMFOEGLFG, [In] MEEAMGFNJIM<TOk, TErr> BBHPNPGLHIG) where TOk : notnull where TErr : notnull, IEAOACDDPEG
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public interface EGOCMJDPKGB
{
	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	FDCLLMFGOFB MBEKNADBEAK
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public interface FOAMILBAHIL
{
	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MIMCCKCJMAH DBBAFEDNBMJ(int OJBINANJOEJ);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public interface DOKCEHLAPJF
{
	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	string PDBKHDHIBAE
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public interface NHFKEEHPDHB
{
	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GEMNABKLOBB? PJHDFIDJCPB(OKFPGADAGCG<OJDCJBFDJOM> FAOHNDGDAJK);
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public interface IBBOEJLCINB
{
	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	string PDBKHDHIBAE
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public interface GEMNABKLOBB
{
	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	string PDBKHDHIBAE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IBBOEJLCINB? HCJOHMLJLEJ(OKFPGADAGCG<COCIAMPEGDB> CLLCDEJPLBE);

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DOKCEHLAPJF? LLJMKOAIFPB(OKFPGADAGCG<MDPMJJMJGJG> HKFFKMNNMFP);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public interface DCGAOOCAHBD
{
	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> BCMLLCAEEIL(string LPCGJALKADL, string CNKGFJIJGPA);
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public interface LAPCFOKGHND
{
	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NHFKEEHPDHB? EBAHOLONADG([In] MIPNFHKLOLI<MKPDEFBPMHA> JLBBOBOLFJC);
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public sealed class HEJHCMEGMOC
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	private struct CCEEAPFHFAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public int ICOODGEKGMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public OCFHMGCGDAI? NDIBCIMNBLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public OCFHMGCGDAI? COLHEAJBEJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public readonly List<LCJOHDOCEBL> HMAAAPLBCOP;

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x1C1D9F0", Offset = "0x1C1CDF0", VA = "0x181C1D9F0")]
		private CCEEAPFHFAN(int JPEMHHILGGG, OCFHMGCGDAI? PEOOJOAPAJP, OCFHMGCGDAI? DJHKIMHMNDC, List<LCJOHDOCEBL> HIKGMMOGGPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x1C1D930", Offset = "0x1C1CD30", VA = "0x181C1D930")]
		public static CCEEAPFHFAN CLFIPFKIGEN()
		{
			return default(CCEEAPFHFAN);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private readonly ACNMFPCDIDJ<CCEEAPFHFAN> KPIGAJGMCGC;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public static HEJHCMEGMOC OMCMBELJBID
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x1C1F2D0", Offset = "0x1C1E6D0", VA = "0x181C1F2D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool HMEDOLGCIJL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7B47D0", Offset = "0x7B3BD0", VA = "0x1807B47D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x889760", Offset = "0x888B60", VA = "0x180889760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x1C1F660", Offset = "0x1C1EA60", VA = "0x181C1F660")]
	public void JBLGBEALJFE(NENAKDOFDJC DJHKIMHMNDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x1C1F720", Offset = "0x1C1EB20", VA = "0x181C1F720")]
	public void KIGOCABCGME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x1C1F320", Offset = "0x1C1E720", VA = "0x181C1F320")]
	private static string? FIHJDLJFCPC([In] CCEEAPFHFAN NGCADLAFCFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x1C1FB20", Offset = "0x1C1EF20", VA = "0x181C1FB20")]
	public HEJHCMEGMOC()
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
