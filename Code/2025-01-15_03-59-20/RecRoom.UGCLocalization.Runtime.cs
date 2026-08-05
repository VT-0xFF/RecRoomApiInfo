using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_UGCLocalization_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7A03F90", Offset = "0x7A03390", VA = "0x187A03F90", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2200990", Offset = "0x21FFD90", VA = "0x182200990")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[GFHMGJFENGN]
public class PJJMDNABNAO : LCOONJCLGCG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private class BNHJHCMIFMN
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum BGFKGEGDNNH
		{
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			Needed = 0,
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			Requested = 1,
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			Default = 0
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public enum DBJOLILNFDL
		{
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			Modified,
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			AddedFirstOrRemovedLast
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly HashSet<ECBDMLJHHMH> JMGLDEGGPGA;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public KBKOJGKFLIO KMJLKOIHNAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8C7DC0", Offset = "0x8C71C0", VA = "0x1808C7DC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool JLEFFBCPPGH
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x79FBD40", Offset = "0x79FB140", VA = "0x1879FBD40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool KHADDGMPNFK
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x79FBD60", Offset = "0x79FB160", VA = "0x1879FBD60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public BGFKGEGDNNH HPKMHCBOLIE
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x968260", Offset = "0x967660", VA = "0x180968260")]
			[CompilerGenerated]
			get
			{
				return default(BGFKGEGDNNH);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x96FA40", Offset = "0x96EE40", VA = "0x18096FA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x79FC070", Offset = "0x79FB470", VA = "0x1879FC070")]
		public BNHJHCMIFMN(ECBDMLJHHMH MECAIFDCJCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x79FBEC0", Offset = "0x79FB2C0", VA = "0x1879FBEC0")]
		public BNHJHCMIFMN(KBKOJGKFLIO KPLEJIOJNFE, ECBDMLJHHMH MECAIFDCJCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x79FBE40", Offset = "0x79FB240", VA = "0x1879FBE40")]
		public int PLMJPPBEIOK(KBKOJGKFLIO KPLEJIOJNFE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x79FBDB0", Offset = "0x79FB1B0", VA = "0x1879FBDB0")]
		public DBJOLILNFDL PLMBKBLLIJA(ECBDMLJHHMH MECAIFDCJCB)
		{
			return default(DBJOLILNFDL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x79FBC80", Offset = "0x79FB080", VA = "0x1879FBC80")]
		public DBJOLILNFDL AGDADPDCFHH(ECBDMLJHHMH MECAIFDCJCB)
		{
			return default(DBJOLILNFDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class IOPNEDFMLKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public KeyValuePair<string, KBKOJGKFLIO> pair;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public IOPNEDFMLKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x79FF520", Offset = "0x79FE920", VA = "0x1879FF520")]
		internal object DBCKPALIBOB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class HFIIOEIEBOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public string localizationKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public PJJMDNABNAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public BNHJHCMIFMN entry;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public HFIIOEIEBOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x79FF1A0", Offset = "0x79FE5A0", VA = "0x1879FF1A0")]
		internal object IMDGGJJDLGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x79FF400", Offset = "0x79FE800", VA = "0x1879FF400")]
		internal object NNGKGLJEIDN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class DKJDALBKDIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public long requestorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public HFIIOEIEBOL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public DKJDALBKDIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x79FEC10", Offset = "0x79FE010", VA = "0x1879FEC10")]
		internal object LDECCIMHBOD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class CAPHPMMEKMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public string translationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public HFIIOEIEBOL CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public CAPHPMMEKMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x79FC080", Offset = "0x79FB480", VA = "0x1879FC080")]
		internal object GKCKGAABKCP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class AMNGGGJGCLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public ECBDMLJHHMH requestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public string localizationKey;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public AMNGGGJGCLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x79FB0C0", Offset = "0x79FA4C0", VA = "0x1879FB0C0")]
		internal object MDBFNFCGKKD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x79FB070", Offset = "0x79FA470", VA = "0x1879FB070")]
		internal object IIEJLJFJIIO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct NBNKAPKKOIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public AsyncTaskMethodBuilder<List<KBKOJGKFLIO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public PJJMDNABNAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public bool logExceptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private TaskAwaiter<PIGHCFIFDDJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x79FFAC0", Offset = "0x79FEEC0", VA = "0x1879FFAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x79FFF10", Offset = "0x79FF310", VA = "0x1879FFF10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class DBFNPMGPFNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public List<KBKOJGKFLIO> translations;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public DBFNPMGPFNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x79FCD40", Offset = "0x79FC140", VA = "0x1879FCD40")]
		internal object BFOFIMJBKNI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct BHPDCHDJPHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public PJJMDNABNAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public IEnumerable<CGBJPDKLJAK> persistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private DBFNPMGPFNL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter<List<KBKOJGKFLIO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x79FB180", Offset = "0x79FA580", VA = "0x1879FB180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x79FBC20", Offset = "0x79FB020", VA = "0x1879FBC20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class JILGJDGPDDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AONOMDABFOI notification;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public PJJMDNABNAO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public JILGJDGPDDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x79FF980", Offset = "0x79FED80", VA = "0x1879FF980")]
		internal object KMGLDJMFNDE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x79FF910", Offset = "0x79FED10", VA = "0x1879FF910")]
		internal object KDNHCFJANOB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x79FF8F0", Offset = "0x79FECF0", VA = "0x1879FF8F0")]
		internal void HJDLOFCDJLC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class JNPEAMMACNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int updatedStrings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public PJJMDNABNAO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public JNPEAMMACNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x79FFA10", Offset = "0x79FEE10", VA = "0x1879FFA10")]
		internal object PJIOPOFOEMN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct AHEMJKBMFLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public PJJMDNABNAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private JNPEAMMACNO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<List<KBKOJGKFLIO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x79FA260", Offset = "0x79F9660", VA = "0x1879FA260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x79FB010", Offset = "0x79FA410", VA = "0x1879FB010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class JDLPNBNIILN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public PJJMDNABNAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public List<string> existingTranslations;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public JDLPNBNIILN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x79FF7F0", Offset = "0x79FEBF0", VA = "0x1879FF7F0")]
		internal object PMIBEEFIHEG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x79FF770", Offset = "0x79FEB70", VA = "0x1879FF770")]
		internal object PKCBKOMFBNB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct DJHMNOBBAHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public PJJMDNABNAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public COFODAIELBI serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private JDLPNBNIILN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private Dictionary<string, BNHJHCMIFMN> <neededTranslationLookup>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private Guid <nextScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x79FCDD0", Offset = "0x79FC1D0", VA = "0x1879FCDD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x79FEBB0", Offset = "0x79FDFB0", VA = "0x1879FEBB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct PHLLKMLFPFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public PJJMDNABNAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public MCGHEPNDHCL deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7A00090", Offset = "0x79FF490", VA = "0x187A00090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7A00530", Offset = "0x79FF930", VA = "0x187A00530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly EDMBDJBNBHO LDPLKNELCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly OHIBLGFBNDM PCEDPHKHKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly ALDODBGDBHA HCMIHOCCGPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly HCMOGHGOBGB NPGFBLNGFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly DPBNAKNNKND CNADODAPMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly string KEGBBKDMJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly IDisposable DGFMHLNNJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<string, BNHJHCMIFMN> IJEIBGOJGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Dictionary<string, KBKOJGKFLIO> PIDNBPCKEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private int MBFDBCJDJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private bool ECADPDBHDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private long HPNBBKJBMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private long FPAPLPNDGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Guid JBLFDAFOHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool KKEGLLNDACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly bool AAPKPOFPDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8A")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool JFGDPBELOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly HashSet<KIKGNPOPHNH> GDADJJNFJCD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	internal Guid NEAAOAPDMNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x40603E0", Offset = "0x405F7E0", VA = "0x1840603E0")]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7A006C0", Offset = "0x79FFAC0", VA = "0x187A006C0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private long JHIEDJKCDNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7A01F50", Offset = "0x7A01350", VA = "0x187A01F50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public string HPDDLEEGKJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8CFAE0", Offset = "0x8CEEE0", VA = "0x1808CFAE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8CFA90", Offset = "0x8CEE90", VA = "0x1808CFA90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private string KMCPGHFGBPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7A00810", Offset = "0x79FFC10", VA = "0x187A00810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal bool DPAMJIPPGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7A00C00", Offset = "0x7A00000", VA = "0x187A00C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	internal bool OGEOANAFCIF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7A03080", Offset = "0x7A02480", VA = "0x187A03080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal bool MMLLBKNNMDP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7A02180", Offset = "0x7A01580", VA = "0x187A02180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool LCMKLEEDDID
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7A00620", Offset = "0x79FFA20", VA = "0x187A00620", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private static ANDMNHBOFDI IKFCBMDNGKK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7A02120", Offset = "0x7A01520", VA = "0x187A02120")]
		get
		{
			return default(ANDMNHBOFDI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private int BOFBOBGFIGI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7A015E0", Offset = "0x7A009E0", VA = "0x187A015E0")]
	private static void IFLBNIPEGGE(AGCOAIANNFC LNICHECHJFC, ANDMNHBOFDI PFLNNLCIDME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7A02F90", Offset = "0x7A02390", VA = "0x187A02F90")]
	[AGCFNMIICNN.EOJADANDAPN.IGDNFKFONFM]
	internal static void OHHPJPBCCIE(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7A031A0", Offset = "0x7A025A0", VA = "0x187A031A0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal PJJMDNABNAO([NotNull][CNGCCDLPGOD(null)] EDMBDJBNBHO LDPLKNELCKF, [NotNull][CNGCCDLPGOD(null)] OHIBLGFBNDM PCEDPHKHKKD, [NotNull][CNGCCDLPGOD(null)] ALDODBGDBHA HCMIHOCCGPG, [CNGCCDLPGOD(null)][NotNull] HCMOGHGOBGB NPGFBLNGFLA, [CNGCCDLPGOD(null)][NotNull] DPBNAKNNKND CNADODAPMKL, [CNGCCDLPGOD(null)][NotNull] NDFIBPFJJMA EHJOHGLDCCM, [CNGCCDLPGOD(null)][NotNull] CBKPLBJIJFB JNPEEDEABBA, [NotNull][CNGCCDLPGOD(null)] AJCHOFIOKBP OMPDJEGMEOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7A009F0", Offset = "0x79FFDF0", VA = "0x187A009F0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7A01480", Offset = "0x7A00880", VA = "0x187A01480")]
	private static string HMBBHJGCJPN(Guid PABLMODKAPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7A011E0", Offset = "0x7A005E0", VA = "0x187A011E0")]
	private Dictionary<string, KBKOJGKFLIO> GJGEEEMNNHM(IEnumerable<KBKOJGKFLIO> DACFHDMAPJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7A023B0", Offset = "0x7A017B0", VA = "0x187A023B0")]
	private void LPFEDKDMIAP(Dictionary<string, KBKOJGKFLIO> GCLPOBAKKLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7A021A0", Offset = "0x7A015A0", VA = "0x187A021A0")]
	internal static string LOFFKOAMEBE(string JNJBMODLGMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7A00D70", Offset = "0x7A00170", VA = "0x187A00D70", Slot = "4")]
	public bool FDEOFIKGIFD(KIKGNPOPHNH MEJCLMNJIGK, bool JCDOMELOGPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7A026A0", Offset = "0x7A01AA0", VA = "0x187A026A0", Slot = "7")]
	public string MPBCJNMDAIP(string CMNJCPJBHGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7A01790", Offset = "0x7A00B90", VA = "0x187A01790", Slot = "8")]
	public ODIKLKOLJGF JACLNONCFBA(string CJGEDMGNCIG, string MAPPNBHJLPD, [CanBeNull] ECBDMLJHHMH MECAIFDCJCB)
	{
		return default(ODIKLKOLJGF);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7A00E30", Offset = "0x7A00230", VA = "0x187A00E30", Slot = "9")]
	public void FODKOGAIMPE(string CJGEDMGNCIG, [NotNull] ECBDMLJHHMH MECAIFDCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7A026F0", Offset = "0x7A01AF0", VA = "0x187A026F0", Slot = "10")]
	public OHFADJDLNPI NFAKCAKKLMK(string CJGEDMGNCIG)
	{
		return default(OHFADJDLNPI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7A01690", Offset = "0x7A00A90", VA = "0x187A01690")]
	[AsyncStateMachine(typeof(NBNKAPKKOIC))]
	private Task<List<KBKOJGKFLIO>> IGCGFOICILJ(bool DPHEHGFCCMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7A02020", Offset = "0x7A01420", VA = "0x187A02020")]
	[AsyncStateMachine(typeof(BHPDCHDJPHD))]
	private Task KAGHEMIJIJI(IEnumerable<CGBJPDKLJAK> LLLHMPGFCPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7A027C0", Offset = "0x7A01BC0", VA = "0x187A027C0")]
	private void ODJIJPPCAMA(AONOMDABFOI KGAFPDBFPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7A030D0", Offset = "0x7A024D0", VA = "0x187A030D0")]
	[AsyncStateMachine(typeof(AHEMJKBMFLG))]
	private Task PIPIAEDBJHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7A00C50", Offset = "0x7A00050", VA = "0x187A00C50", Slot = "11")]
	[AsyncStateMachine(typeof(DJHMNOBBAHH))]
	public Task EPLCOCOJCPG(COFODAIELBI ODMLHODKOLD, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7A00780", Offset = "0x79FFB80", VA = "0x187A00780", Slot = "5")]
	public void BBBCCAHDFCJ(HGOBDFLLNNB JOMOCOIMIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7A00850", Offset = "0x79FFC50", VA = "0x187A00850")]
	private void DEEDDHKLHFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7A014F0", Offset = "0x7A008F0", VA = "0x187A014F0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(PHLLKMLFPFC))]
	private Task IAGACOGBBJE(MCGHEPNDHCL COKNKBNPIMH, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7A01420", Offset = "0x7A00820", VA = "0x187A01420")]
	[CompilerGenerated]
	private object HJEKCHJCHGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7A01360", Offset = "0x7A00760", VA = "0x187A01360")]
	[CompilerGenerated]
	private string GNLCLHBPCIA(KBKOJGKFLIO KPLEJIOJNFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7A00590", Offset = "0x79FF990", VA = "0x187A00590")]
	[CompilerGenerated]
	private object ALLNPPFHPFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7A00B70", Offset = "0x79FFF70", VA = "0x187A00B70")]
	[CompilerGenerated]
	private object EHBIKFPNIJK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class NNLIDMFDDHA : ECBDMLJHHMH, IEquatable<ECBDMLJHHMH>
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public long ODDAFMAOMHH
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string JHDJBKJIAHC
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8C7DC0", Offset = "0x8C71C0", VA = "0x1808C7DC0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x79FFFF0", Offset = "0x79FF3F0", VA = "0x1879FFFF0")]
	public NNLIDMFDDHA(long LPMIIFILJPI, string MAPPNBHJLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x79FFF80", Offset = "0x79FF380", VA = "0x1879FFF80", Slot = "7")]
	public bool Equals(ECBDMLJHHMH CABLGFIBABJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2328880", Offset = "0x2327C80", VA = "0x182328880", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal class CAPJHNIGDJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly LCOONJCLGCG JDDANOOEMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private ECBDMLJHHMH MECAIFDCJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private bool OKAPJIEDIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private string MAPPNBHJLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private string CMNJCPJBHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private bool JINLBPPAJNP;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	internal long KGHJNICEIBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x79FCBD0", Offset = "0x79FBFD0", VA = "0x1879FCBD0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string JHDJBKJIAHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x79FC7B0", Offset = "0x79FBBB0", VA = "0x1879FC7B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x79FC9D0", Offset = "0x79FBDD0", VA = "0x1879FC9D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x79FCC20", Offset = "0x79FC020", VA = "0x1879FCC20")]
	public CAPJHNIGDJM([Optional] LCOONJCLGCG KCLPDCIIPCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x79FCA90", Offset = "0x79FBE90", VA = "0x1879FCA90")]
	public OHFADJDLNPI JHBNGCBHNBK(KIKGNPOPHNH JBGLGACIHDG)
	{
		return default(OHFADJDLNPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x79FC300", Offset = "0x79FB700", VA = "0x1879FC300")]
	internal void BFLBMILJDBK(KIKGNPOPHNH IAGLHMMMEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x79FC8A0", Offset = "0x79FBCA0", VA = "0x1879FC8A0")]
	public void CLBLNEJDEJL(KIKGNPOPHNH IAGLHMMMEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x79FC8B0", Offset = "0x79FBCB0", VA = "0x1879FC8B0")]
	private void FODKOGAIMPE(KIKGNPOPHNH IAGLHMMMEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x79FC2B0", Offset = "0x79FB6B0", VA = "0x1879FC2B0")]
	[CompilerGenerated]
	private object ANMCGOONIJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x79FC800", Offset = "0x79FBC00", VA = "0x1879FC800")]
	[CompilerGenerated]
	private object CGEGKMJCJLC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class HJLCCELKNFK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private KIKGNPOPHNH EOEJBJOHDJN
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x79FF4A0", Offset = "0x79FE8A0", VA = "0x1879FF4A0")]
	public HJLCCELKNFK(KIKGNPOPHNH MOKJOEJBOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x79FF450", Offset = "0x79FE850", VA = "0x1879FF450", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class EGCOBNGDJAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly KIKGNPOPHNH CHEFJGLCOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly CAPJHNIGDJM LMADGNHDHEI;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public OHFADJDLNPI LPJHMFOHIPK
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x79FECF0", Offset = "0x79FE0F0", VA = "0x1879FECF0")]
		get
		{
			return default(OHFADJDLNPI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool HBMOOANBNGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8D0DA0", Offset = "0x8D01A0", VA = "0x1808D0DA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string JHDJBKJIAHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x79FEE70", Offset = "0x79FE270", VA = "0x1879FEE70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x79FEF40", Offset = "0x79FE340", VA = "0x1879FEF40")]
	public EGCOBNGDJAI(KIKGNPOPHNH IAGLHMMMEGA, [Optional] LCOONJCLGCG KCLPDCIIPCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x79FEE30", Offset = "0x79FE230", VA = "0x1879FEE30")]
	public void GIIOODNPBGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x79FECD0", Offset = "0x79FE0D0", VA = "0x1879FECD0")]
	public void CLBLNEJDEJL()
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
