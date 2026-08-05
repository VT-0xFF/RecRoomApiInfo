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
		[Cpp2IlInjected.Address(RVA = "0x88AE190", Offset = "0x88ACB90", VA = "0x1888AE190", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2796C60", Offset = "0x2795660", VA = "0x182796C60")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[NHPBPJDIEFG]
public class DCLNKNDEGMG : KGNIEBGIABN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private class KADHDOHLCIG
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum KNDILDNIDHD
		{
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			Needed = 0,
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			Requested = 1,
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			Default = 0
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public enum FLMOIENKFNE
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
		public readonly HashSet<PMMGMEILPIF> AKKJHIBIMGB;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public GJLKBHFGBJA IJICEIIIFNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xA0A7B0", Offset = "0xA091B0", VA = "0x180A0A7B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool LKGMCIFANFN
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x88ACA30", Offset = "0x88AB430", VA = "0x1888ACA30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool GEPKAOLFIOE
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x88ACAD0", Offset = "0x88AB4D0", VA = "0x1888ACAD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public KNDILDNIDHD HGOGKOPFBKO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xA58550", Offset = "0xA56F50", VA = "0x180A58550")]
			[CompilerGenerated]
			get
			{
				return default(KNDILDNIDHD);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xA58560", Offset = "0xA56F60", VA = "0x180A58560")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x88ACBE0", Offset = "0x88AB5E0", VA = "0x1888ACBE0")]
		public KADHDOHLCIG(PMMGMEILPIF GHOBHGEOCLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x88ACBF0", Offset = "0x88AB5F0", VA = "0x1888ACBF0")]
		public KADHDOHLCIG(GJLKBHFGBJA AJKFMLAKBGM, PMMGMEILPIF GHOBHGEOCLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x88ACA50", Offset = "0x88AB450", VA = "0x1888ACA50")]
		public int HKLNMLHJHFO(GJLKBHFGBJA AJKFMLAKBGM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x88AC9A0", Offset = "0x88AB3A0", VA = "0x1888AC9A0")]
		public FLMOIENKFNE FLAANHBGCJJ(PMMGMEILPIF GHOBHGEOCLE)
		{
			return default(FLMOIENKFNE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x88ACB20", Offset = "0x88AB520", VA = "0x1888ACB20")]
		public FLMOIENKFNE PJAPOPHODGE(PMMGMEILPIF GHOBHGEOCLE)
		{
			return default(FLMOIENKFNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class MCGFPHHBMMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public KeyValuePair<string, GJLKBHFGBJA> pair;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public MCGFPHHBMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x88AD040", Offset = "0x88ABA40", VA = "0x1888AD040")]
		internal object GGLACGCKNGJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class PDANHPMMLBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public string localizationKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public DCLNKNDEGMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public KADHDOHLCIG entry;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public PDANHPMMLBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x88AD7F0", Offset = "0x88AC1F0", VA = "0x1888AD7F0")]
		internal object BCLKFKFDADO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x88ADA60", Offset = "0x88AC460", VA = "0x1888ADA60")]
		internal object DAGNKGKCKKE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class JHFHHFCJPFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public long requestorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public PDANHPMMLBJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public JHFHHFCJPFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x88AC8E0", Offset = "0x88AB2E0", VA = "0x1888AC8E0")]
		internal object FHJHLEFDFHA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class HGFLMDAIDJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public string translationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public PDANHPMMLBJ CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public HGFLMDAIDJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x88ABFE0", Offset = "0x88AA9E0", VA = "0x1888ABFE0")]
		internal object LACHMANCBKD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class GEKLOBNFAON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public PMMGMEILPIF requestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public string localizationKey;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public GEKLOBNFAON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x88AA090", Offset = "0x88A8A90", VA = "0x1888AA090")]
		internal object AOFLHKAFJNA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x88AA150", Offset = "0x88A8B50", VA = "0x1888AA150")]
		internal object OJKCOKPGGLD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct OPJMPBGIHMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public AsyncTaskMethodBuilder<List<GJLKBHFGBJA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public DCLNKNDEGMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public bool logExceptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private TaskAwaiter<HLOCBOFIPAC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x88AD330", Offset = "0x88ABD30", VA = "0x1888AD330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x88AD780", Offset = "0x88AC180", VA = "0x1888AD780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class OGJDJHJLOFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public List<GJLKBHFGBJA> translations;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public OGJDJHJLOFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x88AD2A0", Offset = "0x88ABCA0", VA = "0x1888AD2A0")]
		internal object DCHGMNFCFJG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct GBLEDAJNJOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public DCLNKNDEGMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public IEnumerable<CEIEJPOFNOJ> persistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private OGJDJHJLOFI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter<List<GJLKBHFGBJA>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x88A9590", Offset = "0x88A7F90", VA = "0x1888A9590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x88AA030", Offset = "0x88A8A30", VA = "0x1888AA030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class MCCINKDLIPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public EACJDKGLKMK notification;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public DCLNKNDEGMG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public MCCINKDLIPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x88ACFB0", Offset = "0x88AB9B0", VA = "0x1888ACFB0")]
		internal object IGACEDPEFFK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x88ACF40", Offset = "0x88AB940", VA = "0x1888ACF40")]
		internal object FNLJEFLHCPO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x88ACF20", Offset = "0x88AB920", VA = "0x1888ACF20")]
		internal void AAMGENFDABN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class IKLPIKOILHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int updatedStrings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public DCLNKNDEGMG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public IKLPIKOILHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x88AC830", Offset = "0x88AB230", VA = "0x1888AC830")]
		internal object LAPOCKMPJNM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct FIKNAMNHPBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public DCLNKNDEGMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private IKLPIKOILHB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<List<GJLKBHFGBJA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x88A8770", Offset = "0x88A7170", VA = "0x1888A8770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x88A9530", Offset = "0x88A7F30", VA = "0x1888A9530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class KGCPGDGIAOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public DCLNKNDEGMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public List<string> existingTranslations;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public KGCPGDGIAOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x88ACDA0", Offset = "0x88AB7A0", VA = "0x1888ACDA0")]
		internal object EOMANFMHMBK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x88ACEA0", Offset = "0x88AB8A0", VA = "0x1888ACEA0")]
		internal object HMJEJMDEEAM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct HDFKDFAJBCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public DCLNKNDEGMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public LOECPFNBOHH serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private KGCPGDGIAOH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private Dictionary<string, KADHDOHLCIG> <neededTranslationLookup>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private Guid <nextScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x88AA1A0", Offset = "0x88A8BA0", VA = "0x1888AA1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x88ABF80", Offset = "0x88AA980", VA = "0x1888ABF80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct IIELKFGDHLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public DCLNKNDEGMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public JFCHLDJHBKP deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x88AC330", Offset = "0x88AAD30", VA = "0x1888AC330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x88AC7D0", Offset = "0x88AB1D0", VA = "0x1888AC7D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly JDEBKMDHNMO GLDJKKJJLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly KFNMLAJAJEB CCJGANLKFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HFFIGAJJBDA EMKDIFAFLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly ICKNPKBJODA JEJFACEGMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly HLBCBFGNCDI OBBPCOLPIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly string BAOOFJDAALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly IDisposable BNONMHECOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<string, KADHDOHLCIG> IMLIMFCIJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Dictionary<string, GJLKBHFGBJA> NNDAKEDIHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private int MHEIHGJGJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private bool PEIMGGBICAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private long BJJAFPOFANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private long IADFGELPNFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Guid NIHIEJACOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool LMNNOJOMBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly bool ALIFCFAMIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8A")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool PHNEFEAHCCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly HashSet<BFEKNKCPDEB> NBFFAGIHJAE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	internal Guid ODPLCIGBFDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1AA14C0", Offset = "0x1A9FEC0", VA = "0x181AA14C0")]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x88A5660", Offset = "0x88A4060", VA = "0x1888A5660")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private long LNPPHIAKEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x88A6210", Offset = "0x88A4C10", VA = "0x1888A6210")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public string CJHLLNMPNDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA09190", Offset = "0xA07B90", VA = "0x180A09190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA09280", Offset = "0xA07C80", VA = "0x180A09280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private string CJMFFDDFNIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x88A5620", Offset = "0x88A4020", VA = "0x1888A5620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal bool NBHFPGNNFIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x88A79E0", Offset = "0x88A63E0", VA = "0x1888A79E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	internal bool PLIGBDBMPDO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x88A5440", Offset = "0x88A3E40", VA = "0x1888A5440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal bool MBCDDAPJGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x88A5500", Offset = "0x88A3F00", VA = "0x1888A5500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool DFBAAGDFLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x88A5720", Offset = "0x88A4120", VA = "0x1888A5720", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private static CHPALBDOOEK BHKICOLMGHE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x88A6CC0", Offset = "0x88A56C0", VA = "0x1888A6CC0")]
		get
		{
			return default(CHPALBDOOEK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private int LJFAJHMLLBH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x88A7E50", Offset = "0x88A6850", VA = "0x1888A7E50")]
	private static void NMIAFEIOBGD(EKAGHBMGAGO IJOJGNJMCGP, CHPALBDOOEK KCFPIAEHDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x88A6D20", Offset = "0x88A5720", VA = "0x1888A6D20")]
	[CGLGNCLDKHN.DPDEAPAPLBM.NMEBICDHLMD]
	internal static void JGOIPALGEOO(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x88A8060", Offset = "0x88A6A60", VA = "0x1888A8060")]
	[RecRoom.NoEngine.Common.Preserve]
	internal DCLNKNDEGMG([NotNull][CNHMBDDCGKB(null)] JDEBKMDHNMO GLDJKKJJLBL, [NotNull][CNHMBDDCGKB(null)] KFNMLAJAJEB CCJGANLKFLJ, [NotNull][CNHMBDDCGKB(null)] HFFIGAJJBDA EMKDIFAFLKB, [CNHMBDDCGKB(null)][NotNull] ICKNPKBJODA JEJFACEGMCJ, [CNHMBDDCGKB(null)][NotNull] HLBCBFGNCDI OBBPCOLPIFL, [CNHMBDDCGKB(null)][NotNull] AEGECEIBFDC KDHMHKHEJAM, [CNHMBDDCGKB(null)][NotNull] HEBBNJMIOCB OCGGFKMLMND, [NotNull][CNHMBDDCGKB(null)] JJPMOJNHOLC CCEMKGCMKEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x88A5980", Offset = "0x88A4380", VA = "0x1888A5980", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x88A5490", Offset = "0x88A3E90", VA = "0x1888A5490")]
	private static string ANPNNCMOIAC(Guid LHOLPBEPHAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x88A6B40", Offset = "0x88A5540", VA = "0x1888A6B40")]
	private Dictionary<string, GJLKBHFGBJA> JEEBHGDFFFO(IEnumerable<GJLKBHFGBJA> JEEEECAKANA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x88A6E10", Offset = "0x88A5810", VA = "0x1888A6E10")]
	private void KIBGMCIHGGD(Dictionary<string, GJLKBHFGBJA> FGFFPDHOKEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x88A6000", Offset = "0x88A4A00", VA = "0x1888A6000")]
	internal static string FPMNFGBLMOF(string BOEDKOAHHAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x88A7D90", Offset = "0x88A6790", VA = "0x1888A7D90", Slot = "4")]
	public bool NKKMMKKBIJO(BFEKNKCPDEB PPDPIELHBDF, bool KALBLPGLPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x88A7BE0", Offset = "0x88A65E0", VA = "0x1888A7BE0", Slot = "7")]
	public string MJIMCNGMAOK(string BECBHDDLOHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x88A7100", Offset = "0x88A5B00", VA = "0x1888A7100", Slot = "8")]
	public IOJKPCNPNOA KKLKBEIGMKB(string CJBNAOGDGJE, string CHCCOOMJKLJ, [CanBeNull] PMMGMEILPIF GHOBHGEOCLE)
	{
		return default(IOJKPCNPNOA);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x88A5B90", Offset = "0x88A4590", VA = "0x1888A5B90", Slot = "9")]
	public void FDCMODGJOOB(string CJBNAOGDGJE, [NotNull] PMMGMEILPIF GHOBHGEOCLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x88A57C0", Offset = "0x88A41C0", VA = "0x1888A57C0", Slot = "10")]
	public MLHMBDMHMJD DBCABCNGAPN(string CJBNAOGDGJE)
	{
		return default(MLHMBDMHMJD);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x88A7C90", Offset = "0x88A6690", VA = "0x1888A7C90")]
	[AsyncStateMachine(typeof(OPJMPBGIHMC))]
	private Task<List<GJLKBHFGBJA>> NIPPMPICLDD(bool CKPGJFKDLFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x88A5520", Offset = "0x88A3F20", VA = "0x1888A5520")]
	[AsyncStateMachine(typeof(GBLEDAJNJOE))]
	private Task BJFJCAFLCCK(IEnumerable<CEIEJPOFNOJ> FHGEBGHKCAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x88A6370", Offset = "0x88A4D70", VA = "0x1888A6370")]
	private void IGFLBEPLOBO(EACJDKGLKMK LLJIENJJIGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x88A7F00", Offset = "0x88A6900", VA = "0x1888A7F00")]
	[AsyncStateMachine(typeof(FIKNAMNHPBA))]
	private Task ODCGMPEEADD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x88A78C0", Offset = "0x88A62C0", VA = "0x1888A78C0", Slot = "11")]
	[AsyncStateMachine(typeof(HDFKDFAJBCD))]
	public Task LFILEGDFCOE(LOECPFNBOHH IPMPKPIBGHH, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x88A62E0", Offset = "0x88A4CE0", VA = "0x1888A62E0", Slot = "5")]
	public void HDCOLBFEBDC(BGHEHCDAEKD NIAPBNPEIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x88A7A30", Offset = "0x88A6430", VA = "0x1888A7A30")]
	private void LODAMKLIICP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x88A5890", Offset = "0x88A4290", VA = "0x1888A5890")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(IIELKFGDHLG))]
	private Task DHIDCAJEJGK(JFCHLDJHBKP KMLLEPPHFEF, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x88A7C30", Offset = "0x88A6630", VA = "0x1888A7C30")]
	[CompilerGenerated]
	private object NIEECKJLMEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x88A5F40", Offset = "0x88A4940", VA = "0x1888A5F40")]
	[CompilerGenerated]
	private string FJNHCDGNAPI(GJLKBHFGBJA AJKFMLAKBGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x88A5B00", Offset = "0x88A4500", VA = "0x1888A5B00")]
	[CompilerGenerated]
	private object EACOCNPLFOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x88A7FD0", Offset = "0x88A69D0", VA = "0x1888A7FD0")]
	[CompilerGenerated]
	private object PMGFFGLCENO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class HJPAMHABIEO : PMMGMEILPIF, IEquatable<PMMGMEILPIF>
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public long KIJDDDGOGCE
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string PJAAKIMNCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7B0", Offset = "0xA091B0", VA = "0x180A0A7B0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x88AC290", Offset = "0x88AAC90", VA = "0x1888AC290")]
	public HJPAMHABIEO(long KHNIMGKFPOO, string CHCCOOMJKLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x88AC220", Offset = "0x88AAC20", VA = "0x1888AC220", Slot = "7")]
	public bool Equals(PMMGMEILPIF JAOCPECLJLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x28E8C30", Offset = "0x28E7630", VA = "0x1828E8C30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal class CNFNPKJKHJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly KGNIEBGIABN JDLOIAFGNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private PMMGMEILPIF GHOBHGEOCLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private bool JKFBCALFBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private string CHCCOOMJKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private string BECBHDDLOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private bool GLHIHEAHIOJ;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	internal long BHAOKHNOOLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x88A50F0", Offset = "0x88A3AF0", VA = "0x1888A50F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string PJAAKIMNCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x88A49A0", Offset = "0x88A33A0", VA = "0x1888A49A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x88A4A50", Offset = "0x88A3450", VA = "0x1888A4A50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x88A5320", Offset = "0x88A3D20", VA = "0x1888A5320")]
	public CNFNPKJKHJC([Optional] KGNIEBGIABN BPDOIFAEGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x88A51E0", Offset = "0x88A3BE0", VA = "0x1888A51E0")]
	public MLHMBDMHMJD OBEPDGPHFDM(BFEKNKCPDEB LAAHLCJJOEA)
	{
		return default(MLHMBDMHMJD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x88A4C30", Offset = "0x88A3630", VA = "0x1888A4C30")]
	internal void FPILOHDMIEH(BFEKNKCPDEB BAHHKCPIIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x88A4A40", Offset = "0x88A3440", VA = "0x1888A4A40")]
	public void DLJIAJAKIEF(BFEKNKCPDEB BAHHKCPIIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x88A4B10", Offset = "0x88A3510", VA = "0x1888A4B10")]
	private void FDCMODGJOOB(BFEKNKCPDEB BAHHKCPIIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x88A49F0", Offset = "0x88A33F0", VA = "0x1888A49F0")]
	[CompilerGenerated]
	private object CIIHPADPMAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x88A5140", Offset = "0x88A3B40", VA = "0x1888A5140")]
	[CompilerGenerated]
	private object NCIFDIFJJND()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class CHHLDECGDLO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private BFEKNKCPDEB LBOINNBEOBP
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x88A4920", Offset = "0x88A3320", VA = "0x1888A4920")]
	public CHHLDECGDLO(BFEKNKCPDEB BIFKFBCMMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x88A48D0", Offset = "0x88A32D0", VA = "0x1888A48D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class AEGFFIKPANM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly BFEKNKCPDEB MFHFHLCJOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly CNFNPKJKHJC HHOLBDEJNAK;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public MLHMBDMHMJD NNDBPCDEGPH
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x88A4520", Offset = "0x88A2F20", VA = "0x1888A4520")]
		get
		{
			return default(MLHMBDMHMJD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool IDCOFCJJLMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA10D70", Offset = "0xA0F770", VA = "0x180A10D70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string PJAAKIMNCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x88A4400", Offset = "0x88A2E00", VA = "0x1888A4400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x88A4670", Offset = "0x88A3070", VA = "0x1888A4670")]
	public AEGFFIKPANM(BFEKNKCPDEB BAHHKCPIIIL, [Optional] KGNIEBGIABN BPDOIFAEGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x88A44E0", Offset = "0x88A2EE0", VA = "0x1888A44E0")]
	public void MHBGOKHAEPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x88A43E0", Offset = "0x88A2DE0", VA = "0x1888A43E0")]
	public void DLJIAJAKIEF()
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
