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
		[Cpp2IlInjected.Address(RVA = "0x7C513F0", Offset = "0x7C505F0", VA = "0x187C513F0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x23EA930", Offset = "0x23E9B30", VA = "0x1823EA930")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[KHFOLODBECL]
public class KIILEDNGGNC : BJGLCNBEADA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private class ONJANDIPHKL
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum LHJCAKKNCGN
		{
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			Needed = 0,
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			Requested = 1,
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			Default = 0
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public enum GNPPBPADEEH
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
		public readonly HashSet<BOJHBKNCJJE> MBCPHOKCEJJ;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public HLPHAAFBLAJ MGLIKNJJOIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8F7590", Offset = "0x8F6790", VA = "0x1808F7590")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool AAHPJKBKLFP
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7C4FDD0", Offset = "0x7C4EFD0", VA = "0x187C4FDD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool MEPIDFGGKFG
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7C4FF30", Offset = "0x7C4F130", VA = "0x187C4FF30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LHJCAKKNCGN JCJMGLFDNMH
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xA960C0", Offset = "0xA952C0", VA = "0x180A960C0")]
			[CompilerGenerated]
			get
			{
				return default(LHJCAKKNCGN);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xB25E10", Offset = "0xB25010", VA = "0x180B25E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7C50010", Offset = "0x7C4F210", VA = "0x187C50010")]
		public ONJANDIPHKL(BOJHBKNCJJE OJBKAFEOLCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7C50020", Offset = "0x7C4F220", VA = "0x187C50020")]
		public ONJANDIPHKL(HLPHAAFBLAJ CKEKKOGDLHG, BOJHBKNCJJE OJBKAFEOLCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7C4FDF0", Offset = "0x7C4EFF0", VA = "0x187C4FDF0")]
		public int HGAEMCMIDIK(HLPHAAFBLAJ CKEKKOGDLHG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7C4FF80", Offset = "0x7C4F180", VA = "0x187C4FF80")]
		public GNPPBPADEEH OAGLLMFOOED(BOJHBKNCJJE OJBKAFEOLCD)
		{
			return default(GNPPBPADEEH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7C4FE70", Offset = "0x7C4F070", VA = "0x187C4FE70")]
		public GNPPBPADEEH KIOPFANHAAF(BOJHBKNCJJE OJBKAFEOLCD)
		{
			return default(GNPPBPADEEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class GMEICEHLMBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public KeyValuePair<string, HLPHAAFBLAJ> pair;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public GMEICEHLMBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7C4A3D0", Offset = "0x7C495D0", VA = "0x187C4A3D0")]
		internal object JMEHGALJFGP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class GAOPPKNKPIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public string localizationKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public KIILEDNGGNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public ONJANDIPHKL entry;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public GAOPPKNKPIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7C49C70", Offset = "0x7C48E70", VA = "0x187C49C70")]
		internal object FEHLBFNMICJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7C49C20", Offset = "0x7C48E20", VA = "0x187C49C20")]
		internal object DLAGDCILLOD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class DPLOFBMKIHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public long requestorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public GAOPPKNKPIA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public DPLOFBMKIHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7C49600", Offset = "0x7C48800", VA = "0x187C49600")]
		internal object CBHDJLFOHBD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class ODKCDPBLPEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public string translationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public GAOPPKNKPIA CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public ODKCDPBLPEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F6E0", Offset = "0x7C4E8E0", VA = "0x187C4F6E0")]
		internal object GGPPBKHEIEH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class HKGMJMIDELB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public BOJHBKNCJJE requestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public string localizationKey;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public HKGMJMIDELB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7C4B0C0", Offset = "0x7C4A2C0", VA = "0x187C4B0C0")]
		internal object IKCAJCDNEFH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7C4B180", Offset = "0x7C4A380", VA = "0x187C4B180")]
		internal object MNKJLHNMKKH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct OLIIELBHMDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public AsyncTaskMethodBuilder<List<HLPHAAFBLAJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public KIILEDNGGNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public bool logExceptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private TaskAwaiter<CLEEPOMDELG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F910", Offset = "0x7C4EB10", VA = "0x187C4F910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7C4FD60", Offset = "0x7C4EF60", VA = "0x187C4FD60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class FLDIIANPOMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public List<HLPHAAFBLAJ> translations;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public FLDIIANPOMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7C49B90", Offset = "0x7C48D90", VA = "0x187C49B90")]
		internal object IGCPNMPHDAD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct PIMIGGIENDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public KIILEDNGGNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public IEnumerable<INLFGDDOIPN> persistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private FLDIIANPOMI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter<List<HLPHAAFBLAJ>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7C501D0", Offset = "0x7C4F3D0", VA = "0x187C501D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7C50C90", Offset = "0x7C4FE90", VA = "0x187C50C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class DLIHHCDDOKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public FJFKEPBNIKF notification;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public KIILEDNGGNC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public DLIHHCDDOKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7C49500", Offset = "0x7C48700", VA = "0x187C49500")]
		internal object LFEKNJBKFAK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7C49590", Offset = "0x7C48790", VA = "0x187C49590")]
		internal object NHFKJFGIKIJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7C494E0", Offset = "0x7C486E0", VA = "0x187C494E0")]
		internal void BHGJEMHEBGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class CFKPBMFOBJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int updatedStrings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public KIILEDNGGNC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public CFKPBMFOBJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7C49430", Offset = "0x7C48630", VA = "0x187C49430")]
		internal object KCHLIFMKMFK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct HMECPICGKEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public KIILEDNGGNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private CFKPBMFOBJE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<List<HLPHAAFBLAJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7C4B1D0", Offset = "0x7C4A3D0", VA = "0x187C4B1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7C4BFA0", Offset = "0x7C4B1A0", VA = "0x187C4BFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class NMCBCEGEKLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public KIILEDNGGNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public List<string> existingTranslations;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public NMCBCEGEKLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F560", Offset = "0x7C4E760", VA = "0x187C4F560")]
		internal object DNCEAHIPJLN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F660", Offset = "0x7C4E860", VA = "0x187C4F660")]
		internal object JPFFJFEPFBE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct ABGPEJBCOBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public KIILEDNGGNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public PPFCCODPGBI serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private NMCBCEGEKLA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private Dictionary<string, ONJANDIPHKL> <neededTranslationLookup>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private Guid <nextScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7C47530", Offset = "0x7C46730", VA = "0x187C47530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7C493D0", Offset = "0x7C485D0", VA = "0x187C493D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct GIHABAHCPIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public KIILEDNGGNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public GHIJJJNKODG deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7C49ED0", Offset = "0x7C490D0", VA = "0x187C49ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7C4A370", Offset = "0x7C49570", VA = "0x187C4A370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly LMFPIGNKHCL JKKALFFMIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly EENFDAPPFPG CLGFMPLKHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly PIJBAIOLPJE PLNNGKHENGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly JMCGIMEIOCB IBMNPFDADDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly DPDFKPJJMMF NIMPJCAJLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly string KAKCAEGJJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly IDisposable MJLNENACPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<string, ONJANDIPHKL> NOMFDBLJLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Dictionary<string, HLPHAAFBLAJ> MFKIDCCKKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private int FPCLAGKNFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private bool FJBDIDDOCFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private long BDFPPOBHHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private long PHNNBDANOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Guid LFPJLCJDAHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool HPMBHKEHLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly bool OJPLJMMDEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8A")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool EJKKGKNLLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly HashSet<DMPLGJNHONG> PBHFOIIEPHJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	internal Guid MALKKAMCGOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4300570", Offset = "0x42FF770", VA = "0x184300570")]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7C4E090", Offset = "0x7C4D290", VA = "0x187C4E090")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private long KLKOLHDJPGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D3D0", Offset = "0x7C4C5D0", VA = "0x187C4D3D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public string LFEEBGONJOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8F91E0", Offset = "0x8F83E0", VA = "0x1808F91E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8F92A0", Offset = "0x8F84A0", VA = "0x1808F92A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private string KBLPCIJKPDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7C4DAB0", Offset = "0x7C4CCB0", VA = "0x187C4DAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal bool MONPEBANBOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7C4DE70", Offset = "0x7C4D070", VA = "0x187C4DE70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	internal bool DFHKJIIDBFB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7C4DCC0", Offset = "0x7C4CEC0", VA = "0x187C4DCC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal bool GGEMNJDFEDI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D550", Offset = "0x7C4C750", VA = "0x187C4D550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool BLMKIDCCFMP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D210", Offset = "0x7C4C410", VA = "0x187C4D210", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private static EJJCGEPDLHL PIKIDINKEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7C4DF10", Offset = "0x7C4D110", VA = "0x187C4DF10")]
		get
		{
			return default(EJJCGEPDLHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private int NBHPFLMECKK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7C4D4A0", Offset = "0x7C4C6A0", VA = "0x187C4D4A0")]
	private static void IAFHAMPMCBD(JBIPFCJFOAK CBCJFCINKPJ, EJJCGEPDLHL KBFPLDFMKJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7C4C8D0", Offset = "0x7C4BAD0", VA = "0x187C4C8D0")]
	[NAOGKPPNIGE.MIHKMKENDLB.GBAIAGAIEPJ]
	internal static void BHMHEMCKFJH(JBPONICDCIO CKNPDKKKGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7C4EC70", Offset = "0x7C4DE70", VA = "0x187C4EC70")]
	[RecRoom.NoEngine.Common.Preserve]
	internal KIILEDNGGNC([NotNull][FMJHJHHALCB(null)] LMFPIGNKHCL JKKALFFMIKH, [NotNull][FMJHJHHALCB(null)] EENFDAPPFPG CLGFMPLKHPE, [NotNull][FMJHJHHALCB(null)] PIJBAIOLPJE PLNNGKHENGN, [FMJHJHHALCB(null)][NotNull] JMCGIMEIOCB IBMNPFDADDO, [FMJHJHHALCB(null)][NotNull] DPDFKPJJMMF NIMPJCAJLLG, [FMJHJHHALCB(null)][NotNull] IJAOOIKANEB GPCPMJIAFHJ, [FMJHJHHALCB(null)][NotNull] MEKMCOEEPLL NGAGNLPFNFJ, [NotNull][FMJHJHHALCB(null)] AFJINEAEPKI APAGJACOOAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7C4CCE0", Offset = "0x7C4BEE0", VA = "0x187C4CCE0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7C4EC00", Offset = "0x7C4DE00", VA = "0x187C4EC00")]
	private static string POOEHNNGBBG(Guid NEFEGLLNHEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7C4D570", Offset = "0x7C4C770", VA = "0x187C4D570")]
	private Dictionary<string, HLPHAAFBLAJ> IJDNMDCJKBB(IEnumerable<HLPHAAFBLAJ> OAEJLHLNEII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7C4D700", Offset = "0x7C4C900", VA = "0x187C4D700")]
	private void IKKEILGMIIK(Dictionary<string, HLPHAAFBLAJ> MKLHELLLAMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E950", Offset = "0x7C4DB50", VA = "0x187C4E950")]
	internal static string PJGLHLDBOLC(string NKEKGFPJFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7C4DF70", Offset = "0x7C4D170", VA = "0x187C4DF70", Slot = "4")]
	public bool NGKLINDACAB(DMPLGJNHONG CIGOBHNCPNE, bool MPKIENECBCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7C4DEC0", Offset = "0x7C4D0C0", VA = "0x187C4DEC0", Slot = "7")]
	public string MNFPPOOHLMM(string BCOHKLCJCPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7C4C100", Offset = "0x7C4B300", VA = "0x187C4C100", Slot = "8")]
	public EMOMEKNGKGO BBJFKMJFEFA(string EMPBMODGAHG, string PDEGCFKDOBB, [CanBeNull] BOJHBKNCJJE OJBKAFEOLCD)
	{
		return default(EMOMEKNGKGO);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7C4CE60", Offset = "0x7C4C060", VA = "0x187C4CE60", Slot = "9")]
	public void EPCPIMLNOMH(string EMPBMODGAHG, [NotNull] BOJHBKNCJJE OJBKAFEOLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7C4DAF0", Offset = "0x7C4CCF0", VA = "0x187C4DAF0", Slot = "10")]
	public OLIFDGFFBCC KIGCMCHKOOF(string EMPBMODGAHG)
	{
		return default(OLIFDGFFBCC);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7C4C000", Offset = "0x7C4B200", VA = "0x187C4C000")]
	[AsyncStateMachine(typeof(OLIIELBHMDA))]
	private Task<List<HLPHAAFBLAJ>> AHHGFKPOIEL(bool PHKLFJNGLDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C4DBC0", Offset = "0x7C4CDC0", VA = "0x187C4DBC0")]
	[AsyncStateMachine(typeof(PIMIGGIENDA))]
	private Task KKGJAKPNBIK(IEnumerable<INLFGDDOIPN> NDJPKPBNOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E150", Offset = "0x7C4D350", VA = "0x187C4E150")]
	private void OIONNLMDBFL(FJFKEPBNIKF CEHEEFDGHNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7C4DD10", Offset = "0x7C4CF10", VA = "0x187C4DD10")]
	[AsyncStateMachine(typeof(HMECPICGKEN))]
	private Task LKAFKMMGNEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7C4D2B0", Offset = "0x7C4C4B0", VA = "0x187C4D2B0", Slot = "11")]
	[AsyncStateMachine(typeof(ABGPEJBCOBJ))]
	public Task GPDLHPDCBDN(PPFCCODPGBI MKBCJJNBDGD, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7C4DDE0", Offset = "0x7C4CFE0", VA = "0x187C4DDE0", Slot = "5")]
	public void LLGEBMJIGHK(LJJCDEANBLH JPGPNLNCOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7C4CB40", Offset = "0x7C4BD40", VA = "0x187C4CB40")]
	private void DLBNKCDMEPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7C4C9C0", Offset = "0x7C4BBC0", VA = "0x187C4C9C0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(GIHABAHCPIK))]
	private Task CHADHDCNIOP(GHIJJJNKODG ELGFNCMNGAO, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E030", Offset = "0x7C4D230", VA = "0x187C4E030")]
	[CompilerGenerated]
	private object NINJCOJBCII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7C4D9F0", Offset = "0x7C4CBF0", VA = "0x187C4D9F0")]
	[CompilerGenerated]
	private string KEJPIJKFEJI(HLPHAAFBLAJ CKEKKOGDLHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7C4EB70", Offset = "0x7C4DD70", VA = "0x187C4EB70")]
	[CompilerGenerated]
	private object POAOAHMNFGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7C4CAB0", Offset = "0x7C4BCB0", VA = "0x187C4CAB0")]
	[CompilerGenerated]
	private object DAEGJLFMDAP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class MPOFAGCCGKF : BOJHBKNCJJE, IEquatable<BOJHBKNCJJE>
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public long JFJOAOHHOGF
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string BELCCOAPOOL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8F7590", Offset = "0x8F6790", VA = "0x1808F7590", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7C4F4C0", Offset = "0x7C4E6C0", VA = "0x187C4F4C0")]
	public MPOFAGCCGKF(long BEHEHKFONGA, string PDEGCFKDOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7C4F450", Offset = "0x7C4E650", VA = "0x187C4F450", Slot = "7")]
	public bool Equals(BOJHBKNCJJE HHDMEFHBCOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2514200", Offset = "0x2513400", VA = "0x182514200", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal class HJHIPOANHDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly BJGLCNBEADA IPDBAJOPDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private BOJHBKNCJJE OJBKAFEOLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private bool DEELPKNOHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private string PDEGCFKDOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private string BCOHKLCJCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private bool NAOBIHHEGPO;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	internal long GDAKPODLACJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7C4A680", Offset = "0x7C49880", VA = "0x187C4A680")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string BELCCOAPOOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7C4A7F0", Offset = "0x7C499F0", VA = "0x187C4A7F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7C4AEE0", Offset = "0x7C4A0E0", VA = "0x187C4AEE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7C4AFA0", Offset = "0x7C4A1A0", VA = "0x187C4AFA0")]
	public HJHIPOANHDI([Optional] BJGLCNBEADA ODPBGAGOMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7C4A8E0", Offset = "0x7C49AE0", VA = "0x187C4A8E0")]
	public OLIFDGFFBCC KPPBDHPGDDG(DMPLGJNHONG PCDIJANPPEM)
	{
		return default(OLIFDGFFBCC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7C4AA20", Offset = "0x7C49C20", VA = "0x187C4AA20")]
	internal void MEIPIBBEBLB(DMPLGJNHONG CBPFBLBBLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7C4A670", Offset = "0x7C49870", VA = "0x187C4A670")]
	public void BOFJLDDGHJF(DMPLGJNHONG CBPFBLBBLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7C4A6D0", Offset = "0x7C498D0", VA = "0x187C4A6D0")]
	private void EPCPIMLNOMH(DMPLGJNHONG CBPFBLBBLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7C4A620", Offset = "0x7C49820", VA = "0x187C4A620")]
	[CompilerGenerated]
	private object APPBCLPNNAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7C4A840", Offset = "0x7C49A40", VA = "0x187C4A840")]
	[CompilerGenerated]
	private object FIFEBOJNECC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class MFLCPDOENLK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private DMPLGJNHONG NGDMDLFBICN
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7C4F3D0", Offset = "0x7C4E5D0", VA = "0x187C4F3D0")]
	public MFLCPDOENLK(DMPLGJNHONG GMMMMKOHNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7C4F380", Offset = "0x7C4E580", VA = "0x187C4F380", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class EJBJPKKDFKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly DMPLGJNHONG GHOPMJLGHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly HJHIPOANHDI CACIFLBHFHE;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public OLIFDGFFBCC DPGEKCMHCLK
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7C496E0", Offset = "0x7C488E0", VA = "0x187C496E0")]
		get
		{
			return default(OLIFDGFFBCC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool PGDGLFFPMKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0D0", Offset = "0x8FA2D0", VA = "0x1808FB0D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string BELCCOAPOOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7C49860", Offset = "0x7C48A60", VA = "0x187C49860")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7C49930", Offset = "0x7C48B30", VA = "0x187C49930")]
	public EJBJPKKDFKN(DMPLGJNHONG CBPFBLBBLGH, [Optional] BJGLCNBEADA ODPBGAGOMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7C49820", Offset = "0x7C48A20", VA = "0x187C49820")]
	public void LNLMJJEFAEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7C496C0", Offset = "0x7C488C0", VA = "0x187C496C0")]
	public void BOFJLDDGHJF()
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
