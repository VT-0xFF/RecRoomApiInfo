using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using Google.Protobuf;
using JetBrains.Annotations;
using Mono.Math;
using RecNet;
using RecRoom.Persistence;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class CGLGLGCJPND : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2CD7160", Offset = "0x2CD5D60", VA = "0x182CD7160")]
	public CGLGLGCJPND(string DPNJMDFICMK, Exception CENDNNNNIKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal class FENDMGLAOOA : CCMLOLCKGDD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct ANDDPGPKPOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public AsyncTaskMethodBuilder<IReadOnlyList<ENAHKMKALEP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private TaskAwaiter<global::JDLOIHLLIBA<ENAHKMKALEP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x37E9F30", Offset = "0x37E8B30", VA = "0x1837E9F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x37EA110", Offset = "0x37E8D10", VA = "0x1837EA110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct LPPMKELBDFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AsyncTaskMethodBuilder<IReadOnlyList<MGBMDCLPDHC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private TaskAwaiter<List<MGBMDCLPDHC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x37F9980", Offset = "0x37F8580", VA = "0x1837F9980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x37F9B40", Offset = "0x37F8740", VA = "0x1837F9B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	[Preserve]
	public FENDMGLAOOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2CDDE30", Offset = "0x2CDCA30", VA = "0x182CDDE30", Slot = "4")]
	[AsyncStateMachine(typeof(ANDDPGPKPOK))]
	public Task<IReadOnlyList<ENAHKMKALEP>> CLIFDIENGFG(long KLMDBCIHINB, long IGCOFHNDKKI, [Optional] CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2CDDF80", Offset = "0x2CDCB80", VA = "0x182CDDF80", Slot = "5")]
	[AsyncStateMachine(typeof(LPPMKELBDFE))]
	public Task<IReadOnlyList<MGBMDCLPDHC>> GPEADNKKEOP(IReadOnlyList<int> LCALNCCFFGK, [Optional] CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface EBGJFDJEEIJ : IEquatable<EBGJFDJEEIJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int LHNPLNHGBOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	MGBMDCLPDHC DIHALCMFODP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime CGANALHAGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	LJOBFIBMMMJ? FIEAOJLAPBL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	BOFMCLIGAGB? KFOKPHFPBIP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	NEADPIHMLEO CKADHLIALDM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<ENHABCKLLMN> GBBOIJBHJMO();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum NEADPIHMLEO
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface CCMLOLCKGDD
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<ENAHKMKALEP>> CLIFDIENGFG(long KLMDBCIHINB, long IGCOFHNDKKI, [Optional] CancellationToken OKPCBPJCBCJ);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<MGBMDCLPDHC>> GPEADNKKEOP(IReadOnlyList<int> LCALNCCFFGK, [Optional] CancellationToken OKPCBPJCBCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class GFDIABGPJHL
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private sealed class OENNPACBEIC : EBGJFDJEEIJ, IEquatable<EBGJFDJEEIJ>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private struct CPEOOCJPODG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<ENHABCKLLMN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public OENNPACBEIC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private LOOEEAANAJA <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<OFPAILNJPLH> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private TaskAwaiter<ENHABCKLLMN> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x447FB20", Offset = "0x447E720", VA = "0x18447FB20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x447FFB0", Offset = "0x447EBB0", VA = "0x18447FFB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly ENAHKMKALEP ENNMKAMEFDL;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int LHNPLNHGBOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6B7080", Offset = "0x6B5C80", VA = "0x1806B7080", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public MGBMDCLPDHC DIHALCMFODP
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x698130", Offset = "0x696D30", VA = "0x180698130", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime IBELEOBANCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x1C36230", Offset = "0x1C34E30", VA = "0x181C36230", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public LJOBFIBMMMJ? FIEAOJLAPBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xCB47E0", Offset = "0xCB33E0", VA = "0x180CB47E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public BOFMCLIGAGB? KFOKPHFPBIP
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xCB47A0", Offset = "0xCB33A0", VA = "0x180CB47A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public NEADPIHMLEO CKADHLIALDM
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7933D0", Offset = "0x791FD0", VA = "0x1807933D0", Slot = "10")]
			get
			{
				return default(NEADPIHMLEO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x37FB280", Offset = "0x37F9E80", VA = "0x1837FB280", Slot = "9")]
		[AsyncStateMachine(typeof(CPEOOCJPODG))]
		public Task<ENHABCKLLMN> GBBOIJBHJMO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x37FB480", Offset = "0x37FA080", VA = "0x1837FB480")]
		public OENNPACBEIC(int MEBKPOAJOAP, MGBMDCLPDHC AIIMEJPFFJC, ENAHKMKALEP ENNMKAMEFDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x37FB1F0", Offset = "0x37F9DF0", VA = "0x1837FB1F0", Slot = "11")]
		public bool Equals(EBGJFDJEEIJ GHLMPEGFGCH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x37FB150", Offset = "0x37F9D50", VA = "0x1837FB150", Slot = "0")]
		public override bool Equals(object AOEMDAGAALP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x37FB440", Offset = "0x37FA040", VA = "0x1837FB440")]
		private bool KCPKPPBNKDH(OENNPACBEIC GHLMPEGFGCH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x37FB3B0", Offset = "0x37F9FB0", VA = "0x1837FB3B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class MBKPGGDIIPA : EBGJFDJEEIJ, IEquatable<EBGJFDJEEIJ>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private struct HMJLKFHDLDF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public AsyncTaskMethodBuilder<ENHABCKLLMN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public MBKPGGDIIPA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private TaskAwaiter<ENHABCKLLMN> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x44849F0", Offset = "0x44835F0", VA = "0x1844849F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x4484C30", Offset = "0x4483830", VA = "0x184484C30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly KAMHGLCAIAM INPPNLPLGBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly LJOBFIBMMMJ AHILJEAOJDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly BOFMCLIGAGB OKGALGMCJCO;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int LHNPLNHGBOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x37F9D80", Offset = "0x37F8980", VA = "0x1837F9D80", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public MGBMDCLPDHC DIHALCMFODP
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x37F9FE0", Offset = "0x37F8BE0", VA = "0x1837F9FE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime IBELEOBANCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x37FA080", Offset = "0x37F8C80", VA = "0x1837FA080", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public LJOBFIBMMMJ? FIEAOJLAPBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x37F9BE0", Offset = "0x37F87E0", VA = "0x1837F9BE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public BOFMCLIGAGB? KFOKPHFPBIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x37F9B90", Offset = "0x37F8790", VA = "0x1837F9B90", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public NEADPIHMLEO CKADHLIALDM
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x787CA0", Offset = "0x7868A0", VA = "0x180787CA0", Slot = "10")]
			get
			{
				return default(NEADPIHMLEO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x977AD0", Offset = "0x9766D0", VA = "0x180977AD0")]
		public MBKPGGDIIPA(KAMHGLCAIAM HFFNLDFGIIN, LJOBFIBMMMJ GGBEOHDGPIO, BOFMCLIGAGB FOCHAPBKHPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x37F9DD0", Offset = "0x37F89D0", VA = "0x1837F9DD0", Slot = "9")]
		[AsyncStateMachine(typeof(HMJLKFHDLDF))]
		public Task<ENHABCKLLMN> GBBOIJBHJMO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x37F9CE0", Offset = "0x37F88E0", VA = "0x1837F9CE0", Slot = "11")]
		public bool Equals(EBGJFDJEEIJ GHLMPEGFGCH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x37F9C30", Offset = "0x37F8830", VA = "0x1837F9C30", Slot = "0")]
		public override bool Equals(object AOEMDAGAALP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x37F9F80", Offset = "0x37F8B80", VA = "0x1837F9F80")]
		private bool KCPKPPBNKDH(MBKPGGDIIPA GHLMPEGFGCH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x37F9EF0", Offset = "0x37F8AF0", VA = "0x1837F9EF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class PAAOBONDGEO : EBGJFDJEEIJ, IEquatable<EBGJFDJEEIJ>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct EPMCKKAKKPK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public AsyncTaskMethodBuilder<ENHABCKLLMN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private TaskAwaiter<ENHABCKLLMN> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x4482960", Offset = "0x4481560", VA = "0x184482960", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x4482B40", Offset = "0x4481740", VA = "0x184482B40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly MGBMDCLPDHC DKJCECAKGAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly LJOBFIBMMMJ AHILJEAOJDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly BOFMCLIGAGB OKGALGMCJCO;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int LHNPLNHGBOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x37FC360", Offset = "0x37FAF60", VA = "0x1837FC360", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public MGBMDCLPDHC DIHALCMFODP
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x695E40", Offset = "0x694A40", VA = "0x180695E40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime IBELEOBANCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6AD8D0", Offset = "0x6AC4D0", VA = "0x1806AD8D0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public LJOBFIBMMMJ? FIEAOJLAPBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x37FC080", Offset = "0x37FAC80", VA = "0x1837FC080", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public BOFMCLIGAGB? KFOKPHFPBIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x37FC030", Offset = "0x37FAC30", VA = "0x1837FC030", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public NEADPIHMLEO CKADHLIALDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6AD8D0", Offset = "0x6AC4D0", VA = "0x1806AD8D0", Slot = "10")]
			get
			{
				return default(NEADPIHMLEO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x977AD0", Offset = "0x9766D0", VA = "0x180977AD0")]
		public PAAOBONDGEO(MGBMDCLPDHC AIIMEJPFFJC, LJOBFIBMMMJ GGBEOHDGPIO, BOFMCLIGAGB FOCHAPBKHPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x37FC3E0", Offset = "0x37FAFE0", VA = "0x1837FC3E0", Slot = "9")]
		[AsyncStateMachine(typeof(EPMCKKAKKPK))]
		public Task<ENHABCKLLMN> GBBOIJBHJMO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x37FC220", Offset = "0x37FAE20", VA = "0x1837FC220", Slot = "11")]
		public bool Equals(EBGJFDJEEIJ GHLMPEGFGCH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x37FC0D0", Offset = "0x37FACD0", VA = "0x1837FC0D0", Slot = "0")]
		public override bool Equals(object AOEMDAGAALP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x37FC4D0", Offset = "0x37FB0D0", VA = "0x1837FC4D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x37FC580", Offset = "0x37FB180", VA = "0x1837FC580")]
		private bool KCPKPPBNKDH(PAAOBONDGEO GHLMPEGFGCH)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct IHAPDDOLKEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<IList<EBGJFDJEEIJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public bool forceRefreshSaveHistoryCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public GFDIABGPJHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private IReadOnlyList<ENAHKMKALEP> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private TaskAwaiter<IReadOnlyList<ENAHKMKALEP>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private TaskAwaiter<IReadOnlyList<(int accountId, MGBMDCLPDHC account, ENAHKMKALEP roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x37F5F30", Offset = "0x37F4B30", VA = "0x1837F5F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x37F69C0", Offset = "0x37F55C0", VA = "0x1837F69C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct HLFCGDAHGBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, MGBMDCLPDHC account, ENAHKMKALEP roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public IReadOnlyList<ENAHKMKALEP> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public GFDIABGPJHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter<IReadOnlyList<MGBMDCLPDHC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x37F4590", Offset = "0x37F3190", VA = "0x1837F4590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x37F4F10", Offset = "0x37F3B10", VA = "0x1837F4F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly OPEFFGALNGO FFJELDOHHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly CCMLOLCKGDD LEHLOBGJGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly OIPOGEPDFIP DGDAGOGLMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly global::OLGNIMBEJFK<(long, long), IReadOnlyList<ENAHKMKALEP>> BNPLJCGGFAB;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2CE3480", Offset = "0x2CE2080", VA = "0x182CE3480")]
	[Preserve]
	public GFDIABGPJHL([MLOIHELMKFH(null)] CCMLOLCKGDD EFBCODEBGOB, [MLOIHELMKFH(null)] OIPOGEPDFIP CIIONCIDOLE, [MLOIHELMKFH(null)] OPEFFGALNGO EODIGEEPMKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2CE3180", Offset = "0x2CE1D80", VA = "0x182CE3180")]
	[AsyncStateMachine(typeof(IHAPDDOLKEO))]
	public Task<IList<EBGJFDJEEIJ>> HAMLDDIMFJI(long KLMDBCIHINB, long ONEELBLPKOK, bool BJFHLMAFCBP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2CE32D0", Offset = "0x2CE1ED0", VA = "0x182CE32D0")]
	private bool OLBIJBHBPGF(DateTime? FMCDKMDEMOO, long KLMDBCIHINB, long ONEELBLPKOK, out KAMHGLCAIAM KHJPFEIDFAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2CE3040", Offset = "0x2CE1C40", VA = "0x182CE3040")]
	[AsyncStateMachine(typeof(HLFCGDAHGBN))]
	private Task<IReadOnlyList<(int, MGBMDCLPDHC, ENAHKMKALEP)>> ECBFBGLGPNG(IReadOnlyList<ENAHKMKALEP> MCAOIMGHJGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface OIPOGEPDFIP
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<KAMHGLCAIAM> CKDCBJIGJBG;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LLMKOEDIGDD(long KLMDBCIHINB, long ONEELBLPKOK, DJIHHMDOBME BIBCOJPMADN, KJGKHGGPEAN IKLNANFHOOO);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CGLDNCPAJFL(long KLMDBCIHINB, long ONEELBLPKOK, out KAMHGLCAIAM KHJPFEIDFAP);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OJPJHCDAMGH(long KLMDBCIHINB, long ONEELBLPKOK, KJGKHGGPEAN IKLNANFHOOO, out KAMHGLCAIAM KHJPFEIDFAP);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LHJIIBLDIAF(long KLMDBCIHINB, long ONEELBLPKOK);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal interface FDGLANELENM : JMFFJBHIEHM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool DPDJKLKDDHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task BHLCICJJFOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DJKIKIGEIKB(Task DJBOLOFCCDO, string BAEKNCHPBGM);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal interface BPNNIPEHPFP : JMFFJBHIEHM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ENHABCKLLMN> NNKDICBIJNM(KAMHGLCAIAM KHJPFEIDFAP);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task PIECPJKOJDC(CancellationToken OKPCBPJCBCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal interface MNLEKKOFBOM : JMFFJBHIEHM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	AFCKFGFKPJC PKHPHKDPEEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EOCOBHIHBND();

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GGJHEINLBHB();
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal interface JMFFJBHIEHM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CKNDJHJGHOM(INMGAJCAIOM GFONEBKMLAH);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface BNKAOLAGPBJ
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan OGIPILEIOOA
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan GGIDMCBPBLA
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan FNPDLBGFGGC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan BMLFOIEIAHD
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool NLBEMEIEKNF
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool PMFEADKIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool HPIOGFLFMCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum BDNDIJAJIOH
{
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum LFEBHFOKPKN
{
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	InitialRoomLoad,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	AutoSave,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	SaveToDisk,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	SaveToRecNet,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	RestoreAutoSave,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct KOBJCIBGGPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly long NPOMMAJAFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly long IGCOFHNDKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly BDNDIJAJIOH JMPEGNOKOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[CanBeNull]
	public readonly Exception GNNPDHJOMEG;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x365A160", Offset = "0x3658D60", VA = "0x18365A160")]
	public KOBJCIBGGPL(long NPOMMAJAFEJ, long IGCOFHNDKKI, BDNDIJAJIOH JMPEGNOKOOB, [CanBeNull] Exception GNNPDHJOMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x365A110", Offset = "0x3658D10", VA = "0x18365A110")]
	public static KOBJCIBGGPL ENBHIILOAJE(AIMCOPKLBGF EJKPJGAAFHO, BDNDIJAJIOH JMPEGNOKOOB, [Optional] Exception GNNPDHJOMEG)
	{
		return default(KOBJCIBGGPL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public delegate void CIMEEIKCCII(KOBJCIBGGPL EDBLIFGMKAE);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface FICIOOAMFBB : JMFFJBHIEHM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action AONBMAKKMCI;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event CIMEEIKCCII BGKFCBPCFCO;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event CIMEEIKCCII CPNNLAPBBDI;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event CIMEEIKCCII CBPAJIGADPG;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<LFEBHFOKPKN, bool> LIHOHBFDFNE;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KKHLGPMMLIB();

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HCFLMLJEMGO(KOBJCIBGGPL EDBLIFGMKAE);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CJOHPNAHLJP(KOBJCIBGGPL EDBLIFGMKAE);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void EJAMKAPBGBC(KOBJCIBGGPL EDBLIFGMKAE);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void EIIFKLFJBNM(LFEBHFOKPKN ALOINNFJFCL, bool NNDPMBNNLLL);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal interface ALJBNAAMKDN : JMFFJBHIEHM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DJHDJJFLKGM();

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ECIDPPLNOCB();

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OICILAKIGII();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public delegate Task BOEPCHMOIGC(MMBJADMOHGP CAMLOJNDCJA, CancellationToken GIHOLCNOBIB);
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal interface EEGMJHFMDLE : JMFFJBHIEHM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool DLGMCLLKDGG
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PGOHBEFKFLJ(BOEPCHMOIGC JAIIAFBFMJC);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface MGDPMIBADCO : JMFFJBHIEHM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	TaskStatus DEEHCJPFCBD
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KAIOPAGCCDO(AIMCOPKLBGF ICIOKLAEBJL, OJPPJFIPFAD FEBOPLMBIIB, CancellationToken CLLGBCLOIHL);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class GMNINLEGMGL
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2CE3970", Offset = "0x2CE2570", VA = "0x182CE3970")]
	public static bool PHHHFLAIMKH(this MGDPMIBADCO KLKBGPFNKLF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface INMGAJCAIOM : LOOEEAANAJA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	CancellationToken LHGAEONACAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	FNLADHKGADM KPMJHCFFCHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	FJJKLBCOJIJ CBDMAFPJJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	LNIFJFFHNEM HKBELMLHIEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	AHNPBEMNBDD NNDPCGNEDGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	KJOIPNHICFJ JEJNDBAHFNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	EDIODIIJGCI HMIEFGCFFDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	HHGGLOOLNJE NLBFPNKOCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	FNONLEEMBIA KGCPGCHFBNN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	FDGLANELENM KEJLPAGGNOM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	BPNNIPEHPFP ODCBLJHMKJE
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	FICIOOAMFBB DHNGGFCOACC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	ALJBNAAMKDN PBNLNHOKJAD
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	MGDPMIBADCO DJCLMLPEHDD
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	EEGMJHFMDLE IOAJINDIIDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	GCOONBKMOLI MMEDPHCIOPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	JOKEPNIPFLI COCMCEKIIDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	CBKINJMGMAE JOIHKBLDGOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	BFEIBAAHKIM PEJCANEDBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	NKEPPPJLJGJ DGFJCKBJDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	PKCDHDPJNDG GHDNIIIIPCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IENFLCHLOJH ILFBABFIJLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	JJKIADCPHFH NEGGNABEAMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	MKDIIOOCCHE DBMIHMMDNDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	EHFLEDPGBMJ EKNFJDKBHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	PMILHCKNBKA EELJAMDLLDP
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	MNLEKKOFBOM EOILLHCAJIM
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	BNKAOLAGPBJ JAHJINALINE
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	DICPHDHAPLE BMNFBAPODGH
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	OIPOGEPDFIP CPIGHNLFAPO
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void IMOKNLDAMBO(OJPPJFIPFAD FIGDNGLOPGK);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface GCOONBKMOLI : JMFFJBHIEHM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IPMLHDGFENH AABPNGPFBPJ(Guid MJGBLGMCHFL);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KFPKFODPJHB(Guid MJGBLGMCHFL);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CHCAANJFLKL(Guid MJGBLGMCHFL, Task BADOEGFABBD);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ILMJLPLGDGM(Guid MJGBLGMCHFL, ENHABCKLLMN FCCBIDPJCKJ);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OICILAKIGII(Guid MJGBLGMCHFL);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<(ENHABCKLLMN, Task)> ENAILHPFCDG(Guid MJGBLGMCHFL);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface JOKEPNIPFLI : JMFFJBHIEHM, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface CBKINJMGMAE : JMFFJBHIEHM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void APJDOJNLGDP(MAAKCJEMEIP DPNJMDFICMK);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NNPNDNMHNDL(MAAKCJEMEIP DPNJMDFICMK);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<JKIMMKJPANP> GPBLGIJNNFF(CancellationToken EFKPEBBFCJF);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public delegate ENHABCKLLMN NMFECFPLNFE(JCBHONMOFEO KFOLKCJEHFF, JKIMMKJPANP EMFMLAOCKEB);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface BFEIBAAHKIM : JMFFJBHIEHM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IPMLHDGFENH AIIANCEOOMD(MAAKCJEMEIP PAJIGOLLBDJ);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BHCOBDAJFMK(Guid MJGBLGMCHFL, Task BADOEGFABBD);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface NKEPPPJLJGJ : JMFFJBHIEHM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ENHABCKLLMN> DGFJCKBJDHK(MAAKCJEMEIP KDHBDCIFOHL);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface PKCDHDPJNDG : JMFFJBHIEHM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PGGLGCLPJMP> KHFHMKEILHJ(IFANLHMJJPA DHJIFBEMLMJ, AIMCOPKLBGF ICIOKLAEBJL, CancellationToken OKPCBPJCBCJ);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface JJKIADCPHFH : JMFFJBHIEHM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ENHABCKLLMN DKNDDKBJGJL(JCBHONMOFEO KFOLKCJEHFF);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LOKCGNGMEII(string HKLHFKDNFJF);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface IENFLCHLOJH : JMFFJBHIEHM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MAAKCJEMEIP> EALEFCOPNMN(MAAKCJEMEIP PJCBPMCBLEN, CMFLPAKKNOD IGHKLNEJFBP, CancellationToken OKPCBPJCBCJ);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<MAAKCJEMEIP> GFGJABPLMGC(CancellationToken OKPCBPJCBCJ, CMFLPAKKNOD IGHKLNEJFBP);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CJABFHHEKHC GKMNOBJJEMO(KHCEKICDGEB FGKPBBLLHMN, IFANLHMJJPA DHJIFBEMLMJ);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CJABFHHEKHC MHKJFCPFOIN(KHCEKICDGEB FGKPBBLLHMN, IFANLHMJJPA DHJIFBEMLMJ);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface MKDIIOOCCHE : JMFFJBHIEHM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ENHABCKLLMN GMOFGOPFJHN(JCBHONMOFEO KFOLKCJEHFF, JKIMMKJPANP EMFMLAOCKEB);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ENHABCKLLMN KBEKEEEHHFI(JCBHONMOFEO ONNJILEPDIL);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ENHABCKLLMN HIODLDLLGLM(JCBHONMOFEO ONNJILEPDIL);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface EHFLEDPGBMJ
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KDHEOIMCKGP(AJACBNKONFD BANFIFDONHN);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ANLFCCJGBCE(AJACBNKONFD BANFIFDONHN);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KFHBILAOAJK(AJACBNKONFD BANFIFDONHN);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HAGBEFJGCCF(AJACBNKONFD BANFIFDONHN);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class AJACBNKONFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly AIMCOPKLBGF AMAAGEGMJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Dictionary<string, string> MJJOEOEIIPK;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public global::EOHJIFBBDNE<string> ELPGPEBKLFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x698130", Offset = "0x696D30", VA = "0x180698130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6BA2B0", Offset = "0x6B8EB0", VA = "0x1806BA2B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7343F0", Offset = "0x732FF0", VA = "0x1807343F0")]
	public AJACBNKONFD(AIMCOPKLBGF AOONFFMDOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2CD19D0", Offset = "0x2CD05D0", VA = "0x182CD19D0")]
	public AJACBNKONFD JAGOHFHCIKJ(string NANBEBOOGPM, string NENFOEKGNGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2CD1950", Offset = "0x2CD0550", VA = "0x182CD1950")]
	public bool EGPELPKOEJO(out IEnumerable<KeyValuePair<string, string>> DMGDDFAPJMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2CD1930", Offset = "0x2CD0530", VA = "0x182CD1930")]
	public AJACBNKONFD ADGABPBCIGA(global::EOHJIFBBDNE<string> KIACJFINHDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface DICPHDHAPLE
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool OJDBKPAMFLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string OMELDFIMCGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IHGCNJHJCIN();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GJGFOEBPFMM MDPPBLDHBIL(long DKGNBCMFBFJ);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::ELHLKJIIOLA<HDLEMCDEJDD, FLBFNPAMJHJ> JLBFJGMBIFD(long DKGNBCMFBFJ);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::ELHLKJIIOLA<HDLEMCDEJDD, HNMNGPNPECE> HENHCLMNOBF(long DKGNBCMFBFJ);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::ELHLKJIIOLA<long, LLNEIMOAMNN> LGNDEAFLINP();

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<bool> GJAACECJPPI(byte[] KEJLDHPINLO, byte[] KOPCFMHMPMC, CancellationToken OKPCBPJCBCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface LOOEEAANAJA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool PHHHFLAIMKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool KHEBDIPDOAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	Task FEAJDNFIJDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	OJPPJFIPFAD JHNEBCKBLOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action AONBMAKKMCI;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event CIMEEIKCCII BGKFCBPCFCO;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event CIMEEIKCCII CPNNLAPBBDI;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event CIMEEIKCCII CBPAJIGADPG;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<LFEBHFOKPKN, bool> LIHOHBFDFNE;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ECIDPPLNOCB();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	AONMNAPGDGL JMJHMJHNMCM();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	PJOCJLAHHCF LBCEONMDDAA();

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<ENHABCKLLMN> NNKDICBIJNM(KAMHGLCAIAM HFFNLDFGIIN);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task PIECPJKOJDC(CancellationToken OKPCBPJCBCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface KJOIPNHICFJ
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool CAOHEDNHOGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	string KOKGIGFLPDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LJGHPNNDAJA(Scene JDKDGAGJLJD);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task HLKBOPIBIOD(EOGEGPEPLGA IAILLEBIAFM, CancellationToken OKPCBPJCBCJ);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task PANGHGBFHNF();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface AHNPBEMNBDD
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	ELNLIPPPCOB ODANIKCBFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	int AGLAMCJFGHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool DGBNCDFFPIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool PHOCOEHEBEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool MGOEPEJGMBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool OKIPBPCDINL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool LABBHOLDIGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	JCBHONMOFEO LGHLKNLHIEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool LPOIBBNHDDC
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FNLADHKGADM IFDOHNIMAMP(FNLADHKGADM PMOACODFDOJ);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void POJLAJFOLCL(FNLADHKGADM MDGENIFLAAI);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task NBCNPGBNMBE(IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task OHAJOOMMGLC(CancellationToken OKPCBPJCBCJ);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task HNPCKOANKMC(ELCFDJJFPHK KLLKBLNBCMN, [Optional] CancellationToken OKPCBPJCBCJ);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ANIKHBCKDLK(float ALNDCKIFDLN);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OMAGJOMBOOD(string MCFOLFGBLFL);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IReadOnlyList<ABIIDIIIDBI> KNLBFBLMDPL();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IDisposable OAEOHDJCFNJ(object MAMKOIKAADI, ABIIDIIIDBI DHFHGEMGMMO);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	FLBFNPAMJHJ LLBOMCBBNMK();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void CCPJHNENPIC(int IPBKGICCLKP);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task GFFEGNFNHPC();

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void NGLILFLONND();

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool MLMAODHOKCA();

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task LLCGFPPGLEO(CancellationToken OKPCBPJCBCJ);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task NAJBFOEKAFJ(CancellationToken OKPCBPJCBCJ);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<PMNGKMLMACD> OLEBCBCDNHE(DateTime FBKPOJMJEFJ, CancellationToken OKPCBPJCBCJ);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Task<bool> NODDJFNJGMN(CancellationToken OKPCBPJCBCJ);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void BHIFOBGAJMH();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "25")]
	EAGHIGKDMOK EFMGHPANJNE(ILNHMGBKGOA ODKBEHHEOIA, HNMNGPNPECE DKMOAEPKFEL, IEnumerable<PersistenceView> HFMNCOGGPKJ, ref OGGBHCAJIJC LEIMCDGEPGJ);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void LLIKJHADNIK(CFFAMHPODII CKANKMGFDMC, in EAGHIGKDMOK PENAEKEAGKA);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void EOFHDGLNDHO(HNMNGPNPECE CNFINMGFNPM, bool CFHMIFOIPBI);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void FNMILHCEMFC();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void HMMMILNLFED(long KLMDBCIHINB, long IGCOFHNDKKI, OFPAILNJPLH LDIGOIDIFIL, DJIHHMDOBME BIBCOJPMADN);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void MJALDIGBPNE(long KLMDBCIHINB, long IGCOFHNDKKI);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void CLDIEFEIMOP(PersistenceView AEIOACDEMBJ);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool KHCGIHLDHCI(PersistenceView ENAFFFEEEOK);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool CBFMIANGLDK(CFFAMHPODII CKANKMGFDMC, ALPEFALFPBN IHADDGGEMGI, out MIKJJGJPDJD GMGPIBNPICG);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void PKKKBOGNONH();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void FODCMOINCFK();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "36")]
	IDisposable JLLIBFFELIG();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void APCMHFIPMMO(HNMNGPNPECE CNFINMGFNPM, ALPEFALFPBN IHADDGGEMGI);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<bool> OOEIAPFDMEO(FJJKLBCOJIJ NKGCEELNNIP, CancellationToken OKPCBPJCBCJ, IFANLHMJJPA DHJIFBEMLMJ);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void NOHOEHCOGAN(CancellationToken OKPCBPJCBCJ);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<JMJKOKLCGPH> GDELHMDPEJH(long KLMDBCIHINB, long IGCOFHNDKKI, string MLNFDJPEMCC, MPGMEFHBLFB.KBACJBIMPCN CAMLOJNDCJA, MPGMEFHBLFB.KBACJBIMPCN KOPCFMHMPMC, IReadOnlyDictionary<long, int> NLKFCNGDOLA, int HDKONKJOJHG, string HMBBKEJGHHF, bool MNNJOFPDJAK, int CHHAHJDOBHO);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<MKIKECIEMNI> KKOLCFGGIEP(string DKKNAFGMNBK, long KLMDBCIHINB, long IGCOFHNDKKI, string MLNFDJPEMCC, MPGMEFHBLFB.KBACJBIMPCN CAMLOJNDCJA, MPGMEFHBLFB.KBACJBIMPCN KOPCFMHMPMC, int DHOLEBLBBOC);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<OFPAILNJPLH> HBBKJBNOBOK(long KLMDBCIHINB, bool JOKENAJGPGJ, CancellationToken OKPCBPJCBCJ);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool JPEPEKLKAIM();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool OCEADBGONNG();

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool MMLFCBFHEON(IEnumerable<MIKJJGJPDJD> FJEDBKLPHHO);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void IDCFNEINLMB(List<GameObject> ECNMILHGBGH);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "49")]
	float FDHIDCJJNMO();

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool EKNGMPFFIAD(string AAACHMNNIGK, out Scene IPMKKEICEKI);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "51")]
	Task<Scene> ECJGEKMCGJE(string AAACHMNNIGK, LoadSceneMode ONAMJNOKJIO, bool AFIOACOFFOM, IFANLHMJJPA KIACJFINHDJ);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "52")]
	void CNPINMBDKCO();

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "53")]
	bool JMJGPPEENFC(ByteString PGJDMPEOAIC);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void LAIEAFMDALI(AIMCOPKLBGF PEBJFBOHFIA);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "56")]
	Task BJPIPDFHJIN(IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "57")]
	Task GCFDGBIIOKK(IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void AGHJPHPBPEP();

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "59")]
	IDisposable PMJGPJMKKKO();

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "60")]
	FJJGAIPOCOD DADMHMBBNAI();
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface FJJGAIPOCOD
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task GLMFKJFJLAC(CancellationToken OKPCBPJCBCJ);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CNLIMLGFKKB(CancellationToken OKPCBPJCBCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct EAGHIGKDMOK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public HashSet<int> HMMJJJCMDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public IDisposable GACHECFLGHM;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA850", Offset = "0x2CD9450", VA = "0x182CDA850", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum PMNGKMLMACD : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface ELNLIPPPCOB
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	AIMCOPKLBGF LKOCDKJBHKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	OFPAILNJPLH NEFKNLDAFJI
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	MKEIKAGIGLF KCBCIHGGHHO
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool JIKDFKBOAHG
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool PNLJEPMKDCK
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	int AGLAMCJFGHL
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action ALAOMJLCDPI;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<int> ECLBFAFCOAM;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JJJHNNPGKOL();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.GEBCHDOELLA> FFKDDAABGBM();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task FDHHDJHDLNF();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "13")]
	(AIMCOPKLBGF, OJPPJFIPFAD) OAELNAFKDLO();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "14")]
	EFPGKMAIMMO BIEGHENFEKA();

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JNMGKEGGHNO(long DKGNBCMFBFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface PMILHCKNBKA
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AJHDOGFJBOJ(out IEnumerable<int> MKOMOBFDCLH);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JFNOELPBFIB(ALINNECOEFE GIHOLCNOBIB);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FJKJPJKGPHI(ALINNECOEFE GIHOLCNOBIB);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface AEJAIAADJJO
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string BDEJBJMGKGC(ENHABCKLLMN GCFAJIEGBJK);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface PILCHFKJGMF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PPLFBHHDEIP(MJKAEANCLHI.PJJLELGKDPD DFOLEIENDAF);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HMJHMDBAHNI(MJKAEANCLHI.PJJLELGKDPD DFOLEIENDAF);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface EDIODIIJGCI : PILCHFKJGMF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ENHABCKLLMN AELLHAOPEIP(JCBHONMOFEO ONNJILEPDIL);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface HHGGLOOLNJE : PILCHFKJGMF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ENHABCKLLMN DKNDDKBJGJL(JCBHONMOFEO BHHJJPPBNKL);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface GJGFOEBPFMM
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::DGDFIFNFPJI<EOGEGPEPLGA, DLGHCKKHLGP>> OOBGFIKFBEM(string MLNFDJPEMCC, long DKGNBCMFBFJ, GFPNMHNEIAH.JBIDBHLOOJE DDIOPANOHAI, CancellationToken OKPCBPJCBCJ);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface ELHLKJIIOLA<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::DGDFIFNFPJI<byte[], DLGHCKKHLGP>> NMLOHILMMLK(TGetDataArg BHDBJANFJIF, CancellationToken OKPCBPJCBCJ);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::DGDFIFNFPJI<global::EIGLPCKODGO<TData>, DLGHCKKHLGP> BBODNMEOHIG(byte[] GAGLKGONONJ);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class CLOBNPJBMHB : INMGAJCAIOM, LOOEEAANAJA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct NJGDAEIPHGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AsyncTaskMethodBuilder<ENHABCKLLMN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public CLOBNPJBMHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public KAMHGLCAIAM autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<ENHABCKLLMN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x37FAAC0", Offset = "0x37F96C0", VA = "0x1837FAAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x37FAD60", Offset = "0x37F9960", VA = "0x1837FAD60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct ILHOEMONGGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public CLOBNPJBMHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x37F6FD0", Offset = "0x37F5BD0", VA = "0x1837F6FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class HAPCGCKBHKK : IEnumerable<JMFFJBHIEHM>, IEnumerable, IEnumerator<JMFFJBHIEHM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private JMFFJBHIEHM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public CLOBNPJBMHB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private JMFFJBHIEHM System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x712DA0", Offset = "0x7119A0", VA = "0x180712DA0")]
		[DebuggerHidden]
		public HAPCGCKBHKK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x37F4090", Offset = "0x37F2C90", VA = "0x1837F4090", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x37F44D0", Offset = "0x37F30D0", VA = "0x1837F44D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x37F4430", Offset = "0x37F3030", VA = "0x1837F4430", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JMFFJBHIEHM> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x37F4430", Offset = "0x37F3030", VA = "0x1837F4430", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly CancellationTokenSource MONICHCFKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly FNLADHKGADM MDGENIFLAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private bool JIGLPOGPBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private EIAHAEEIFII CPMFPPCELDH;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public FJJKLBCOJIJ CBDMAFPJJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x69B9C0", Offset = "0x69A5C0", VA = "0x18069B9C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x69CF10", Offset = "0x69BB10", VA = "0x18069CF10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public LNIFJFFHNEM HKBELMLHIEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x77FB40", Offset = "0x77E740", VA = "0x18077FB40", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x830ED0", Offset = "0x82FAD0", VA = "0x180830ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public AHNPBEMNBDD NNDPCGNEDGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7335A0", Offset = "0x7321A0", VA = "0x1807335A0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7F1D10", Offset = "0x7F0910", VA = "0x1807F1D10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public KJOIPNHICFJ JEJNDBAHFNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7315F0", Offset = "0x7301F0", VA = "0x1807315F0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6BA290", Offset = "0x6B8E90", VA = "0x1806BA290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public EDIODIIJGCI HMIEFGCFFDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x731600", Offset = "0x730200", VA = "0x180731600", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7F1D00", Offset = "0x7F0900", VA = "0x1807F1D00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public HHGGLOOLNJE NLBFPNKOCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6A4B50", Offset = "0x6A3750", VA = "0x1806A4B50", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x795190", Offset = "0x793D90", VA = "0x180795190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public FNONLEEMBIA KGCPGCHFBNN
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x6D9C80", Offset = "0x6D8880", VA = "0x1806D9C80", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7A46E0", Offset = "0x7A32E0", VA = "0x1807A46E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public FDGLANELENM KEJLPAGGNOM
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x758AB0", Offset = "0x7576B0", VA = "0x180758AB0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7A46C0", Offset = "0x7A32C0", VA = "0x1807A46C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public BPNNIPEHPFP ODCBLJHMKJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x70BC60", Offset = "0x70A860", VA = "0x18070BC60", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7BB460", Offset = "0x7BA060", VA = "0x1807BB460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public FICIOOAMFBB DHNGGFCOACC
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x73A230", Offset = "0x738E30", VA = "0x18073A230", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7C23F0", Offset = "0x7C0FF0", VA = "0x1807C23F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public ALJBNAAMKDN PBNLNHOKJAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6AB1B0", Offset = "0x6A9DB0", VA = "0x1806AB1B0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x6AB270", Offset = "0x6A9E70", VA = "0x1806AB270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public MGDPMIBADCO DJCLMLPEHDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x731610", Offset = "0x730210", VA = "0x180731610", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7A46D0", Offset = "0x7A32D0", VA = "0x1807A46D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public EEGMJHFMDLE IOAJINDIIDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x6A0370", Offset = "0x69EF70", VA = "0x1806A0370", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x6A05D0", Offset = "0x69F1D0", VA = "0x1806A05D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public GCOONBKMOLI MMEDPHCIOPG
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x6A0430", Offset = "0x69F030", VA = "0x1806A0430", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6A05E0", Offset = "0x69F1E0", VA = "0x1806A05E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public JOKEPNIPFLI COCMCEKIIDE
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x6A02F0", Offset = "0x69EEF0", VA = "0x1806A02F0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x6A05C0", Offset = "0x69F1C0", VA = "0x1806A05C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public CBKINJMGMAE JOIHKBLDGOD
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x6B6380", Offset = "0x6B4F80", VA = "0x1806B6380", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x6B63D0", Offset = "0x6B4FD0", VA = "0x1806B63D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public BFEIBAAHKIM PEJCANEDBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x86A4D0", Offset = "0x8690D0", VA = "0x18086A4D0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x86B060", Offset = "0x869C60", VA = "0x18086B060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public NKEPPPJLJGJ DGFJCKBJDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x6B84D0", Offset = "0x6B70D0", VA = "0x1806B84D0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x6B89A0", Offset = "0x6B75A0", VA = "0x1806B89A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public PKCDHDPJNDG GHDNIIIIPCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x6B8720", Offset = "0x6B7320", VA = "0x1806B8720", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x6B8B00", Offset = "0x6B7700", VA = "0x1806B8B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public IENFLCHLOJH ILFBABFIJLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x6D8000", Offset = "0x6D6C00", VA = "0x1806D8000", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6D99B0", Offset = "0x6D85B0", VA = "0x1806D99B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public JJKIADCPHFH NEGGNABEAMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6B77E0", Offset = "0x6B63E0", VA = "0x1806B77E0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x945CF0", Offset = "0x9448F0", VA = "0x180945CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public MKDIIOOCCHE DBMIHMMDNDH
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6B84B0", Offset = "0x6B70B0", VA = "0x1806B84B0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6DB4F0", Offset = "0x6DA0F0", VA = "0x1806DB4F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public EHFLEDPGBMJ EKNFJDKBHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6B84C0", Offset = "0x6B70C0", VA = "0x1806B84C0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x6B8990", Offset = "0x6B7590", VA = "0x1806B8990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public PMILHCKNBKA EELJAMDLLDP
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6DB4E0", Offset = "0x6DA0E0", VA = "0x1806DB4E0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6DB500", Offset = "0x6DA100", VA = "0x1806DB500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public MNLEKKOFBOM EOILLHCAJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6D7610", Offset = "0x6D6210", VA = "0x1806D7610", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6B8AE0", Offset = "0x6B76E0", VA = "0x1806B8AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public BNKAOLAGPBJ JAHJINALINE
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6DF1D0", Offset = "0x6DDDD0", VA = "0x1806DF1D0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6DF1F0", Offset = "0x6DDDF0", VA = "0x1806DF1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public DICPHDHAPLE BMNFBAPODGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6DF1E0", Offset = "0x6DDDE0", VA = "0x1806DF1E0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6DF200", Offset = "0x6DDE00", VA = "0x1806DF200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public OIPOGEPDFIP CPIGHNLFAPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6E40C0", Offset = "0x6E2CC0", VA = "0x1806E40C0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public OJPPJFIPFAD JHNEBCKBLOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x93B3D0", Offset = "0x939FD0", VA = "0x18093B3D0", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x945CD0", Offset = "0x9448D0", VA = "0x180945CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	private bool HOBFKIONDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2CDA0D0", Offset = "0x2CD8CD0", VA = "0x182CDA0D0", Slot = "45")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	private bool MHIPABEGDAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2CD9B90", Offset = "0x2CD8790", VA = "0x182CD9B90", Slot = "46")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	private Task DNMPCOEBDMN
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2CD9EA0", Offset = "0x2CD8AA0", VA = "0x182CD9EA0", Slot = "47")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	private CancellationToken DLNALPOAMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2CD9C10", Offset = "0x2CD8810", VA = "0x182CD9C10", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private FNLADHKGADM OEELOJJGEEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	private event Action JECCEEAHLBD
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2CD9EF0", Offset = "0x2CD8AF0", VA = "0x182CD9EF0", Slot = "35")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2CD9AD0", Offset = "0x2CD86D0", VA = "0x182CD9AD0", Slot = "36")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event CIMEEIKCCII FBACJBFFLBH
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2CD9DE0", Offset = "0x2CD89E0", VA = "0x182CD9DE0", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2CD9650", Offset = "0x2CD8250", VA = "0x182CD9650", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event CIMEEIKCCII GAKMCMIMBBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2CD9F50", Offset = "0x2CD8B50", VA = "0x182CD9F50", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2CD9B30", Offset = "0x2CD8730", VA = "0x182CD9B30", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event CIMEEIKCCII CDIBLABPHNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2CD9D80", Offset = "0x2CD8980", VA = "0x182CD9D80", Slot = "41")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2CDA140", Offset = "0x2CD8D40", VA = "0x182CDA140", Slot = "42")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event Action<LFEBHFOKPKN, bool> KKNAPDCEIBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2CD97F0", Offset = "0x2CD83F0", VA = "0x182CD97F0", Slot = "43")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2CD9E40", Offset = "0x2CD8A40", VA = "0x182CD9E40", Slot = "44")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x945CD0", Offset = "0x9448D0", VA = "0x180945CD0", Slot = "34")]
	public void IMOKNLDAMBO(OJPPJFIPFAD FIGDNGLOPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA2E0", Offset = "0x2CD8EE0", VA = "0x182CDA2E0")]
	[Preserve]
	internal CLOBNPJBMHB([MLOIHELMKFH(null)] FNLADHKGADM MDGENIFLAAI, [MLOIHELMKFH(null)] FJJKLBCOJIJ NKGCEELNNIP, [MLOIHELMKFH(null)] LNIFJFFHNEM CKOGFFNEAHK, [MLOIHELMKFH(null)] AHNPBEMNBDD OPBBALMJDDI, [MLOIHELMKFH(null)] KJOIPNHICFJ DOCKAONEOOG, [MLOIHELMKFH(null)] EDIODIIJGCI IGNEANDJINN, [MLOIHELMKFH(null)] HHGGLOOLNJE FBCIPODEIOK, [MLOIHELMKFH(null)] FNONLEEMBIA GFEIODEDCOL, [MLOIHELMKFH(null)] FDGLANELENM BJDIPLHAKEK, [MLOIHELMKFH(null)] BPNNIPEHPFP EDAINLPADNF, [MLOIHELMKFH(null)] FICIOOAMFBB AKFDIHCNLLI, [MLOIHELMKFH(null)] ALJBNAAMKDN NCLDOPAMJEG, [MLOIHELMKFH(null)] MGDPMIBADCO KLKBGPFNKLF, [MLOIHELMKFH(null)] EEGMJHFMDLE BFJPGIICPFP, [MLOIHELMKFH(null)] GCOONBKMOLI NJADAKMBNFJ, [MLOIHELMKFH(null)] JOKEPNIPFLI BGFNGKNAFON, [MLOIHELMKFH(null)] CBKINJMGMAE INNLGBJFLFP, [MLOIHELMKFH(null)] BFEIBAAHKIM FICHALLOJHN, [MLOIHELMKFH(null)] NKEPPPJLJGJ DKCJEGNIGFI, [MLOIHELMKFH(null)] PKCDHDPJNDG GPIAGAFCCLI, [MLOIHELMKFH(null)] JJKIADCPHFH PBFDJCEHPAC, [MLOIHELMKFH(null)] IENFLCHLOJH KDOMNDEKJBB, [MLOIHELMKFH(null)] MKDIIOOCCHE EKGCAIDIMNC, [MLOIHELMKFH(null)] EHFLEDPGBMJ CFOLPBGOHIH, [MLOIHELMKFH(null)] PMILHCKNBKA KJLDHIMAJIC, [MLOIHELMKFH(null)] BNKAOLAGPBJ CPNGCJKFMPJ, [MLOIHELMKFH(null)] DICPHDHAPLE JAFBBGPJPGH, [MLOIHELMKFH(null)] OIPOGEPDFIP KOHFOKFOJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x2CD9850", Offset = "0x2CD8450", VA = "0x182CD9850")]
	private void CKNDJHJGHOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2CD9940", Offset = "0x2CD8540", VA = "0x182CD9940", Slot = "54")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA290", Offset = "0x2CD8E90", VA = "0x182CDA290", Slot = "48")]
	private void PBNLMALHNMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x2CD9C30", Offset = "0x2CD8830", VA = "0x182CD9C30", Slot = "49")]
	private AONMNAPGDGL HMIDBJKEMCE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA210", Offset = "0x2CD8E10", VA = "0x182CDA210", Slot = "50")]
	private PJOCJLAHHCF OHEIDMAFBHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x2CD96B0", Offset = "0x2CD82B0", VA = "0x182CD96B0", Slot = "51")]
	[AsyncStateMachine(typeof(NJGDAEIPHGG))]
	private Task<ENHABCKLLMN> BMEILKJDEDJ(KAMHGLCAIAM KHJPFEIDFAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x2CD9FB0", Offset = "0x2CD8BB0", VA = "0x182CD9FB0", Slot = "52")]
	[AsyncStateMachine(typeof(ILHOEMONGGL))]
	private Task KNMELDGFBOA(CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA1A0", Offset = "0x2CD8DA0", VA = "0x182CDA1A0")]
	[IteratorStateMachine(typeof(HAPCGCKBHKK))]
	private IEnumerable<JMFFJBHIEHM> NODCPMCHLBH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA0E0", Offset = "0x2CD8CE0", VA = "0x182CDA0E0")]
	[CompilerGenerated]
	private void MIJNKDCHPHE(JMFFJBHIEHM CNBPNBOALAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal class OIELLPIGBJC : ACKNFIODJGH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct EKAKFOKNIBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public OIELLPIGBJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x4480DD0", Offset = "0x447F9D0", VA = "0x184480DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x4481150", Offset = "0x447FD50", VA = "0x184481150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly INMGAJCAIOM GFONEBKMLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly AHNPBEMNBDD OPBBALMJDDI;

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x733BB0", Offset = "0x7327B0", VA = "0x180733BB0")]
	public OIELLPIGBJC(INMGAJCAIOM GFONEBKMLAH, AHNPBEMNBDD OPBBALMJDDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x3663F30", Offset = "0x3662B30", VA = "0x183663F30", Slot = "4")]
	[AsyncStateMachine(typeof(EKAKFOKNIBN))]
	public Task<bool> HCLEJFLPKKG(CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x3664050", Offset = "0x3662C50", VA = "0x183664050")]
	[CompilerGenerated]
	private object MIPEPOFIPAN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal class POEBOBGAOFB : ACKNFIODJGH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct AGAHJCEPIJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public POEBOBGAOFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private float <timeoutTime>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x447D350", Offset = "0x447BF50", VA = "0x18447D350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x447D9F0", Offset = "0x447C5F0", VA = "0x18447D9F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const float PCBJGEJCFDL = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly INMGAJCAIOM GFONEBKMLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly AHNPBEMNBDD OPBBALMJDDI;

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	private ELNLIPPPCOB ODANIKCBFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3669020", Offset = "0x3667C20", VA = "0x183669020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x733BB0", Offset = "0x7327B0", VA = "0x180733BB0")]
	public POEBOBGAOFB(INMGAJCAIOM GFONEBKMLAH, AHNPBEMNBDD OPBBALMJDDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x3668EE0", Offset = "0x3667AE0", VA = "0x183668EE0", Slot = "4")]
	[AsyncStateMachine(typeof(AGAHJCEPIJA))]
	public Task<bool> HCLEJFLPKKG(CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x3668E00", Offset = "0x3667A00", VA = "0x183668E00")]
	[CompilerGenerated]
	private object COIOJDMKFLC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal class EGAEEHELKEI : ACKNFIODJGH
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class PPBCCPGKHBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public EGAEEHELKEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public Matchmaking.GEBCHDOELLA result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AIMCOPKLBGF newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public PPBCCPGKHBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x37FD200", Offset = "0x37FBE00", VA = "0x1837FD200")]
		internal object <RunFallback>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x37FD350", Offset = "0x37FBF50", VA = "0x1837FD350")]
		internal object <RunFallback>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x37FD3C0", Offset = "0x37FBFC0", VA = "0x1837FD3C0")]
		internal object <RunFallback>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct GFJOCPHFGMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public EGAEEHELKEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private PPBCCPGKHBE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<Matchmaking.GEBCHDOELLA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x37F27E0", Offset = "0x37F13E0", VA = "0x1837F27E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x37F3110", Offset = "0x37F1D10", VA = "0x1837F3110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private const float PCBJGEJCFDL = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly INMGAJCAIOM GFONEBKMLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly AHNPBEMNBDD OPBBALMJDDI;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	private ELNLIPPPCOB ODANIKCBFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x2CDB1A0", Offset = "0x2CD9DA0", VA = "0x182CDB1A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x733BB0", Offset = "0x7327B0", VA = "0x180733BB0")]
	public EGAEEHELKEI(INMGAJCAIOM GFONEBKMLAH, AHNPBEMNBDD OPBBALMJDDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x2CDB060", Offset = "0x2CD9C60", VA = "0x182CDB060", Slot = "4")]
	[AsyncStateMachine(typeof(GFJOCPHFGMO))]
	public Task<bool> HCLEJFLPKKG(CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal interface ACKNFIODJGH
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> HCLEJFLPKKG(CancellationToken OKPCBPJCBCJ);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal struct CEHBMPCLMKO
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class FIKEAEJKBAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public INMGAJCAIOM manager;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public FIKEAEJKBAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3655750", Offset = "0x3654350", VA = "0x183655750")]
		internal Task <CreateTask>b__0(MMBJADMOHGP data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct POGMEOMKPCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public CEHBMPCLMKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private KAMHGLCAIAM <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter<PMNGKMLMACD> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter<ENHABCKLLMN> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3669070", Offset = "0x3667C70", VA = "0x183669070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x36695F0", Offset = "0x36681F0", VA = "0x1836695F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct LBCPMOGHCJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public CEHBMPCLMKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x365A780", Offset = "0x3659380", VA = "0x18365A780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly CancellationToken OKPCBPJCBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly INMGAJCAIOM EJGPHLKANJG;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	private FJJKLBCOJIJ CBDMAFPJJAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2CD70D0", Offset = "0x2CD5CD0", VA = "0x182CD70D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	private AHNPBEMNBDD NNDPCGNEDGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2CD6C70", Offset = "0x2CD5870", VA = "0x182CD6C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	private ELNLIPPPCOB ODANIKCBFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2CD6CC0", Offset = "0x2CD58C0", VA = "0x182CD6CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	private BPNNIPEHPFP ODCBLJHMKJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2CD6AE0", Offset = "0x2CD56E0", VA = "0x182CD6AE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x2CD7120", Offset = "0x2CD5D20", VA = "0x182CD7120")]
	public CEHBMPCLMKO(CancellationToken OKPCBPJCBCJ, INMGAJCAIOM EJGPHLKANJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x2CD6E70", Offset = "0x2CD5A70", VA = "0x182CD6E70")]
	public static BOEPCHMOIGC LFMIPJNBGJN(INMGAJCAIOM EJGPHLKANJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x2CD6D40", Offset = "0x2CD5940", VA = "0x182CD6D40")]
	[AsyncStateMachine(typeof(POGMEOMKPCG))]
	public Task<bool> LDJEMKIKHJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x2CD6F30", Offset = "0x2CD5B30", VA = "0x182CD6F30")]
	private bool MBMCBHCIMOF(out KAMHGLCAIAM KHJPFEIDFAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x2CD69E0", Offset = "0x2CD55E0", VA = "0x182CD69E0")]
	[AsyncStateMachine(typeof(LBCPMOGHCJE))]
	private Task BMLMGIKBEMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x2CD6B30", Offset = "0x2CD5730", VA = "0x182CD6B30")]
	private Task<PMNGKMLMACD> IPGKCDNLOIE(KAMHGLCAIAM JHIDMANKPGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal struct IPMLHDGFENH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly GCOONBKMOLI NJADAKMBNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly Guid MJGBLGMCHFL;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private Task<(ENHABCKLLMN, Task)> CIOHIGDMPEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x2CEBA20", Offset = "0x2CEA620", VA = "0x182CEBA20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x2702E90", Offset = "0x2701A90", VA = "0x182702E90")]
	public IPMLHDGFENH(GCOONBKMOLI NJADAKMBNFJ, Guid MJGBLGMCHFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x2CEBAF0", Offset = "0x2CEA6F0", VA = "0x182CEBAF0")]
	public TaskAwaiter<(ENHABCKLLMN, Task)> BEFBLADKFHF()
	{
		return default(TaskAwaiter<(ENHABCKLLMN, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x2CEBB40", Offset = "0x2CEA740", VA = "0x182CEBB40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal struct AOMGIMDBOFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly TaskCompletionSource<(ENHABCKLLMN, Task)> OPMGJGBAJEJ;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public Task<(ENHABCKLLMN, Task)> CIOHIGDMPEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x2CD1DF0", Offset = "0x2CD09F0", VA = "0x182CD1DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x2CD2080", Offset = "0x2CD0C80", VA = "0x182CD2080")]
	public AOMGIMDBOFO(TimeSpan JBOENGFCOFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x2CD1F10", Offset = "0x2CD0B10", VA = "0x182CD1F10")]
	public void KMKNCLGLNNF(Task BADOEGFABBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x2CD1E30", Offset = "0x2CD0A30", VA = "0x182CD1E30")]
	public void ILNEPAOIKMA(ENHABCKLLMN GCFAJIEGBJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x2CD1EC0", Offset = "0x2CD0AC0", VA = "0x182CD1EC0")]
	public void JOLEABAFFFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x2CD1FF0", Offset = "0x2CD0BF0", VA = "0x182CD1FF0")]
	internal void MALHDGFFANI(string DPNJMDFICMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class BOEMGJJPNCM
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class IKHBCNFLLHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public long subRoomId;

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public IKHBCNFLLHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x15DAE50", Offset = "0x15D9A50", VA = "0x1815DAE50")]
		internal bool <Create>b__0(MKEIKAGIGLF subRoom)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x2CD5AE0", Offset = "0x2CD46E0", VA = "0x182CD5AE0")]
	public static PGGLGCLPJMP NBONEDNFGGC(long NPOMMAJAFEJ, long IGCOFHNDKKI, HDLEMCDEJDD KEJLDHPINLO, string MLNFDJPEMCC, HDLEMCDEJDD KOPCFMHMPMC, string DKKNAFGMNBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x2CD5970", Offset = "0x2CD4570", VA = "0x182CD5970")]
	public static PGGLGCLPJMP NBONEDNFGGC(OFPAILNJPLH LKOIAJDDEJJ, ENAHKMKALEP IPPPDNGCAKP, [Optional] string DKKNAFGMNBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x2CD5750", Offset = "0x2CD4350", VA = "0x182CD5750")]
	public static PGGLGCLPJMP NBONEDNFGGC(OFPAILNJPLH LKOIAJDDEJJ, long IGCOFHNDKKI, [Optional] string DKKNAFGMNBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x2CD5650", Offset = "0x2CD4250", VA = "0x182CD5650")]
	public static PGGLGCLPJMP LPCPHNJGIHD(this PGGLGCLPJMP ADEMJHPFLJL, OFPAILNJPLH LPBEHNGPEBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x2CD5570", Offset = "0x2CD4170", VA = "0x182CD5570")]
	public static PGGLGCLPJMP CANGHGMAPDE(this PGGLGCLPJMP ADEMJHPFLJL, ENAHKMKALEP ENCBJILONHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x2CD5490", Offset = "0x2CD4090", VA = "0x182CD5490")]
	public static PGGLGCLPJMP CANGHGMAPDE(this PGGLGCLPJMP ADEMJHPFLJL, MKEIKAGIGLF BMDLBGHGEFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[Preserve]
internal class GDFMNJCIHPH : FDGLANELENM, JMFFJBHIEHM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct PPKHIACJJJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public GDFMNJCIHPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x37FD460", Offset = "0x37FC060", VA = "0x1837FD460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly ALINNECOEFE BFCLCOJKPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private string GMEKOMDCBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private Task MLMEOBNKIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private INMGAJCAIOM GFONEBKMLAH;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool DPDJKLKDDHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x2CE2F90", Offset = "0x2CE1B90", VA = "0x182CE2F90", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public Task BHLCICJJFOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x2CE2DB0", Offset = "0x2CE19B0", VA = "0x182CE2DB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x766940", Offset = "0x765540", VA = "0x180766940", Slot = "7")]
	public void CKNDJHJGHOM(INMGAJCAIOM GFONEBKMLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x2CE2E10", Offset = "0x2CE1A10", VA = "0x182CE2E10", Slot = "6")]
	public void DJKIKIGEIKB(Task DJBOLOFCCDO, string BAEKNCHPBGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x2CE2C80", Offset = "0x2CE1880", VA = "0x182CE2C80")]
	[AsyncStateMachine(typeof(PPKHIACJJJL))]
	private Task AFMFENNDKPA(Task MOJMENKGNBI, string BAEKNCHPBGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x2CE2FC0", Offset = "0x2CE1BC0", VA = "0x182CE2FC0")]
	public GDFMNJCIHPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal class LOJONOMLJDE : MNLEKKOFBOM, JMFFJBHIEHM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private bool LPKFKNGHGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private AFCKFGFKPJC PGAMLKJHIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private FJJKLBCOJIJ NKGCEELNNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private BNKAOLAGPBJ CPNGCJKFMPJ;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public AFCKFGFKPJC PKHPHKDPEEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x365C290", Offset = "0x365AE90", VA = "0x18365C290", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x365BF10", Offset = "0x365AB10", VA = "0x18365BF10", Slot = "7")]
	public void CKNDJHJGHOM(INMGAJCAIOM GFONEBKMLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x365C0D0", Offset = "0x365ACD0", VA = "0x18365C0D0", Slot = "5")]
	public void EOCOBHIHBND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x365C090", Offset = "0x365AC90", VA = "0x18365C090", Slot = "6")]
	public void GGJHEINLBHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x365C300", Offset = "0x365AF00", VA = "0x18365C300")]
	private Task MKMHKPFHCGO(PNLENGEAFDM DGKCGFAKKDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x365C090", Offset = "0x365AC90", VA = "0x18365C090", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public LOJONOMLJDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class FAABLFDFGJB : BNKAOLAGPBJ
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private class NDBIHBPLCKD<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly PJKKABODCBD FLMDDENOENF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly string NANBEBOOGPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly T DOOMMHJABHL;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public T FGHAAIAMOAB
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x711D10", Offset = "0x710910", VA = "0x180711D10")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x711D30", Offset = "0x710930", VA = "0x180711D30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x2FE40B0", Offset = "0x2FE2CB0", VA = "0x182FE40B0")]
		public NDBIHBPLCKD(PJKKABODCBD FLMDDENOENF, string NANBEBOOGPM, T DOOMMHJABHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x2FE3D40", Offset = "0x2FE2940", VA = "0x182FE3D40")]
		private void ALFICABDPAP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly NDBIHBPLCKD<TimeSpan> OPBHILCFDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly NDBIHBPLCKD<TimeSpan> GLKIFMBPFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly NDBIHBPLCKD<TimeSpan> PKMOFDBIEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly NDBIHBPLCKD<TimeSpan> KIBHHALCPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly NDBIHBPLCKD<bool> EHCALFJHNFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly NDBIHBPLCKD<bool> ODCMAALHALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly NDBIHBPLCKD<bool> NKOIBPLKJEC;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public TimeSpan OGIPILEIOOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC8F0", Offset = "0x2CDB4F0", VA = "0x182CDC8F0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public TimeSpan GGIDMCBPBLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC7F0", Offset = "0x2CDB3F0", VA = "0x182CDC7F0", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public TimeSpan FNPDLBGFGGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC830", Offset = "0x2CDB430", VA = "0x182CDC830", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public TimeSpan BMLFOIEIAHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC8B0", Offset = "0x2CDB4B0", VA = "0x182CDC8B0", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool NLBEMEIEKNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC930", Offset = "0x2CDB530", VA = "0x182CDC930", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool PMFEADKIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC7B0", Offset = "0x2CDB3B0", VA = "0x182CDC7B0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public bool HPIOGFLFMCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC870", Offset = "0x2CDB470", VA = "0x182CDC870", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x2CDC970", Offset = "0x2CDB570", VA = "0x182CDC970")]
	[Preserve]
	public FAABLFDFGJB([MLOIHELMKFH(null)] PJKKABODCBD FLMDDENOENF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[Preserve]
internal class PHPPDPEFDME : FICIOOAMFBB, JMFFJBHIEHM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class JELHNEBHKNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public KOBJCIBGGPL roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public JELHNEBHKNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x44858D0", Offset = "0x44844D0", VA = "0x1844858D0")]
		internal object <Invoke>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action AONBMAKKMCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3667E70", Offset = "0x3666A70", VA = "0x183667E70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x3667DA0", Offset = "0x36669A0", VA = "0x183667DA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event CIMEEIKCCII BGKFCBPCFCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x36682C0", Offset = "0x3666EC0", VA = "0x1836682C0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3667940", Offset = "0x3666540", VA = "0x183667940", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event CIMEEIKCCII CPNNLAPBBDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3667D00", Offset = "0x3666900", VA = "0x183667D00", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3668360", Offset = "0x3666F60", VA = "0x183668360", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event CIMEEIKCCII CBPAJIGADPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3667A10", Offset = "0x3666610", VA = "0x183667A10", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3668220", Offset = "0x3666E20", VA = "0x183668220", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<LFEBHFOKPKN, bool> LIHOHBFDFNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3667F10", Offset = "0x3666B10", VA = "0x183667F10", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x36677C0", Offset = "0x36663C0", VA = "0x1836677C0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "19")]
	public void CKNDJHJGHOM(INMGAJCAIOM GFONEBKMLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x3667FB0", Offset = "0x3666BB0", VA = "0x183667FB0", Slot = "14")]
	public void KKHLGPMMLIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x3667E40", Offset = "0x3666A40", VA = "0x183667E40", Slot = "15")]
	public void HCFLMLJEMGO(KOBJCIBGGPL EDBLIFGMKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x3667860", Offset = "0x3666460", VA = "0x183667860", Slot = "16")]
	public void CJOHPNAHLJP(KOBJCIBGGPL EDBLIFGMKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x36679E0", Offset = "0x36665E0", VA = "0x1836679E0", Slot = "17")]
	public void EJAMKAPBGBC(KOBJCIBGGPL EDBLIFGMKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x3667890", Offset = "0x3666490", VA = "0x183667890", Slot = "18")]
	public void EIIFKLFJBNM(LFEBHFOKPKN ALOINNFJFCL, bool NNDPMBNNLLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x3667AB0", Offset = "0x36666B0", VA = "0x183667AB0")]
	private void GEBDNCFIHAJ(CIMEEIKCCII DHFHGEMGMMO, KOBJCIBGGPL EDBLIFGMKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public PHPPDPEFDME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[Preserve]
internal class INCJNMPHGIJ : ALJBNAAMKDN, JMFFJBHIEHM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct KAAKMPCNDIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public INCJNMPHGIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x37F8770", Offset = "0x37F7370", VA = "0x1837F8770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct DFIAGMEOPED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public INCJNMPHGIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x37ED000", Offset = "0x37EBC00", VA = "0x1837ED000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class ICFCDOOOGMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public ICFCDOOOGMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x37F5EC0", Offset = "0x37F4AC0", VA = "0x1837F5EC0")]
		internal object <TryRunFallback>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct NHEDCIBGJBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public INCJNMPHGIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private ICFCDOOOGMM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x37FA0D0", Offset = "0x37F8CD0", VA = "0x1837FA0D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x37FA660", Offset = "0x37F9260", VA = "0x1837FA660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class HOFNBKDPAFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public HOFNBKDPAFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x37F5110", Offset = "0x37F3D10", VA = "0x1837F5110")]
		internal object <LogFallbackStart>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private INMGAJCAIOM GFONEBKMLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private AHNPBEMNBDD OPBBALMJDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private ACKNFIODJGH[] HOILFIEKAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private CancellationTokenSource NAMBCJPDCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private int JHJBEDELFLF;

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x2CEA620", Offset = "0x2CE9220", VA = "0x182CEA620", Slot = "7")]
	public void CKNDJHJGHOM(INMGAJCAIOM GFONEBKMLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x2CEA7B0", Offset = "0x2CE93B0", VA = "0x182CEA7B0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB2E0", Offset = "0x2CE9EE0", VA = "0x182CEB2E0", Slot = "6")]
	public void OICILAKIGII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x2CEA7C0", Offset = "0x2CE93C0", VA = "0x182CEA7C0", Slot = "5")]
	public void ECIDPPLNOCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x2CEA6A0", Offset = "0x2CE92A0", VA = "0x182CEA6A0", Slot = "4")]
	[AsyncStateMachine(typeof(KAAKMPCNDIF))]
	public Task DJHDJJFLKGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x2CEAE40", Offset = "0x2CE9A40", VA = "0x182CEAE40")]
	private void KDHBIOPMNAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x2CEAB60", Offset = "0x2CE9760", VA = "0x182CEAB60")]
	[AsyncStateMachine(typeof(DFIAGMEOPED))]
	private Task HFFENGJOKBN(CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x2CEA4D0", Offset = "0x2CE90D0", VA = "0x182CEA4D0")]
	[AsyncStateMachine(typeof(NHEDCIBGJBD))]
	private Task<bool> BPCIFOCJHCB(int KLEGICPDLIF, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB180", Offset = "0x2CE9D80", VA = "0x182CEB180")]
	private void LFCOCNPJDHF(int KLEGICPDLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x2CEAA20", Offset = "0x2CE9620", VA = "0x182CEAA20")]
	private void HENJIGCJFAD(int KLEGICPDLIF, bool NNDPMBNNLLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2CEAC90", Offset = "0x2CE9890", VA = "0x182CEAC90")]
	private void HMECGIHIHBM(int KLEGICPDLIF, Exception CFGIDIAFBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2CEA910", Offset = "0x2CE9510", VA = "0x182CEA910")]
	private void EJIKFEGLOPF(CancellationToken OKPCBPJCBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public INCJNMPHGIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[Preserve]
internal class OFGNKELGJGF : EEGMJHFMDLE, JMFFJBHIEHM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct IECNPDEIDCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public OFGNKELGJGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public MMBJADMOHGP roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x4485040", Offset = "0x4483C40", VA = "0x184485040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class LKJBPPJEFIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public OFGNKELGJGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public MMBJADMOHGP roomData;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public LKJBPPJEFIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x4487600", Offset = "0x4486200", VA = "0x184487600")]
		internal List<Task> <GetPostLoadTaskGenerator>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct NGCMIEOFFNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public BOEPCHMOIGC taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public MMBJADMOHGP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x44884B0", Offset = "0x44870B0", VA = "0x1844884B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct KDFDKCDAGNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public OFGNKELGJGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x44861C0", Offset = "0x4484DC0", VA = "0x1844861C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly HashSet<BOEPCHMOIGC> LHEGBMBLIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private LNIFJFFHNEM CKOGFFNEAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private INMGAJCAIOM GFONEBKMLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private ABIIDIIIDBI KHKEGFPBKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private AJENNKMOMCG DENFMFAEGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private IDisposable DPACFOOJAOF;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool DLGMCLLKDGG
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x3663290", Offset = "0x3661E90", VA = "0x183663290", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	internal Task CIOHIGDMPEA
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3662D30", Offset = "0x3661930", VA = "0x183662D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x3662FC0", Offset = "0x3661BC0", VA = "0x183662FC0", Slot = "6")]
	public void CKNDJHJGHOM(INMGAJCAIOM GFONEBKMLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x36632A0", Offset = "0x3661EA0", VA = "0x1836632A0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x3663E50", Offset = "0x3662A50", VA = "0x183663E50", Slot = "5")]
	public bool PGOHBEFKFLJ(BOEPCHMOIGC JAIIAFBFMJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x36633E0", Offset = "0x3661FE0", VA = "0x1836633E0")]
	private void HBNKPIJBBLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x3662D40", Offset = "0x3661940", VA = "0x183662D40")]
	private void BAOLBGFHGDJ(MMBJADMOHGP CAMLOJNDCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x3663700", Offset = "0x3662300", VA = "0x183663700")]
	[AsyncStateMachine(typeof(IECNPDEIDCD))]
	private Task JPFBHEJKJLH(MMBJADMOHGP CAMLOJNDCJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x3663300", Offset = "0x3661F00", VA = "0x183663300")]
	private Func<CancellationToken, List<Task>> FLCKKGIMPLF(MMBJADMOHGP CAMLOJNDCJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x3663820", Offset = "0x3662420", VA = "0x183663820")]
	private List<Task> NLJGCALJAEB(MMBJADMOHGP CAMLOJNDCJA, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x3662C00", Offset = "0x3661800", VA = "0x183662C00")]
	[AsyncStateMachine(typeof(NGCMIEOFFNL))]
	private Task AFCNBGPHLJC(BOEPCHMOIGC BGPFNINLPEP, MMBJADMOHGP GAGLKGONONJ, CancellationToken GIHOLCNOBIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x3663600", Offset = "0x3662200", VA = "0x183663600")]
	[AsyncStateMachine(typeof(KDFDKCDAGNC))]
	private Task ICDCELMMAAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x3663D50", Offset = "0x3662950", VA = "0x183663D50")]
	private void OICILAKIGII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x3663EB0", Offset = "0x3662AB0", VA = "0x183663EB0")]
	public OFGNKELGJGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[Preserve]
internal class AHIECCMFHKH : MGDPMIBADCO, JMFFJBHIEHM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct KLJPGKPIOAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public AIMCOPKLBGF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public AHIECCMFHKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public OJPPJFIPFAD customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x36598A0", Offset = "0x36584A0", VA = "0x1836598A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct HGAKFNMPGHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public AHIECCMFHKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public AIMCOPKLBGF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public OJPPJFIPFAD customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private global::EOHJIFBBDNE<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private CMFLPAKKNOD <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private AJACBNKONFD <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x3656A80", Offset = "0x3655680", VA = "0x183656A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class BHPHODCMGPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public Task<PGGLGCLPJMP> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public BHPHODCMGPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x695E40", Offset = "0x694A40", VA = "0x180695E40")]
		internal Task<PGGLGCLPJMP> <ConnectToRoomAndRunLoadLogic>b__0(IFANLHMJJPA _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct PPPMBFOOJBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public AHIECCMFHKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public AIMCOPKLBGF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public IFANLHMJJPA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public OJPPJFIPFAD customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public CMFLPAKKNOD joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private BHPHODCMGPG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private MOBDJEKJCIH <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private IFANLHMJJPA <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private CancellationToken <roomCancellationToken>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private HJJEFEBIANJ <preOperationProgressTracker>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private CancellationTokenSource <photonJoinedTokenSource>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private CancellationToken <photonJoinedToken>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private Task <roomLoadTask>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private TaskAwaiter<PGGLGCLPJMP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x3669640", Offset = "0x3668240", VA = "0x183669640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct OOAEFMJCEJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public AHIECCMFHKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public IFANLHMJJPA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private IFANLHMJJPA <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private IFANLHMJJPA <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x3665720", Offset = "0x3664320", VA = "0x183665720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct IEIJEPGBAIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public AHIECCMFHKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private FNLADHKGADM <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x3657D80", Offset = "0x3656980", VA = "0x183657D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct NKIOCIOKGHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public IFANLHMJJPA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public AIMCOPKLBGF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public AHIECCMFHKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public CMFLPAKKNOD joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private IFANLHMJJPA <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private TaskAwaiter<DCHLPHEOJDC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x3660D90", Offset = "0x365F990", VA = "0x183660D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class MODMBCHMAOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public AIMCOPKLBGF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public MODMBCHMAOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x365F420", Offset = "0x365E020", VA = "0x18365F420")]
		internal object <JoinRoomLoadWithPhoton>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x365F320", Offset = "0x365DF20", VA = "0x18365F320")]
		internal string <JoinRoomLoadWithPhoton>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct NJGCPOCDLFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public AIMCOPKLBGF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public AHIECCMFHKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private MODMBCHMAOE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x36602D0", Offset = "0x365EED0", VA = "0x1836602D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct LHALANPPMLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public IFANLHMJJPA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public AHIECCMFHKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public CMFLPAKKNOD joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public PGGLGCLPJMP initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public AIMCOPKLBGF targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public MOBDJEKJCIH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private IFANLHMJJPA <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x365AE40", Offset = "0x3659A40", VA = "0x18365AE40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct EMEEGKOGDII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public IFANLHMJJPA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public AHIECCMFHKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private IFANLHMJJPA <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x3655380", Offset = "0x3653F80", VA = "0x183655380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct MCHJJCKOJPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public AHIECCMFHKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public IFANLHMJJPA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x365C380", Offset = "0x365AF80", VA = "0x18365C380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct BLPHGNAGBKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public IFANLHMJJPA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public AHIECCMFHKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private IFANLHMJJPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x3653110", Offset = "0x3651D10", VA = "0x183653110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct OCBMMGMHEML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public MMBJADMOHGP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public AHIECCMFHKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private TaskAwaiter<ENHABCKLLMN> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x3661930", Offset = "0x3660530", VA = "0x183661930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct OPEHGGMHGBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public AHIECCMFHKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private IFANLHMJJPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x36671B0", Offset = "0x3665DB0", VA = "0x1836671B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class BAJAOOIIOAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public AIMCOPKLBGF targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public BAJAOOIIOAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x3652500", Offset = "0x3651100", VA = "0x183652500")]
		internal object <LogRoomInstance>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class AEINKHCPILN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public AEINKHCPILN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x3652060", Offset = "0x3650C60", VA = "0x183652060")]
		internal void <LogRoomLoadCancellation>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class NPKDKIEBLNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public AIMCOPKLBGF targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public NPKDKIEBLNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x36618B0", Offset = "0x36604B0", VA = "0x1836618B0")]
		internal object <LogRoomLoadFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class AOAHOPAOOJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public AIMCOPKLBGF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public AOAHOPAOOJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x3652100", Offset = "0x3650D00", VA = "0x183652100")]
		internal string <LogRoomLoadSuccess>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly string NCHMOKGAFKD;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static readonly string BMKIIGFMGAM;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static readonly string IHGNJHLFBHO;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static readonly Guid IGEODPPIEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private FNONLEEMBIA GFEIODEDCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private LNIFJFFHNEM CKOGFFNEAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private FJJKLBCOJIJ NKGCEELNNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private INMGAJCAIOM GFONEBKMLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private AHNPBEMNBDD OPBBALMJDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private ALJBNAAMKDN NCLDOPAMJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private FDGLANELENM BJDIPLHAKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private FICIOOAMFBB AKFDIHCNLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private BNKAOLAGPBJ CPNGCJKFMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private IDisposable DPACFOOJAOF;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public TaskStatus DEEHCJPFCBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xA7EF80", Offset = "0xA7DB80", VA = "0x180A7EF80", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xF0D830", Offset = "0xF0C430", VA = "0x180F0D830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private ELNLIPPPCOB ODANIKCBFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x2CD0BD0", Offset = "0x2CCF7D0", VA = "0x182CD0BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x2CCE8E0", Offset = "0x2CCD4E0", VA = "0x182CCE8E0", Slot = "6")]
	public void CKNDJHJGHOM(INMGAJCAIOM GFONEBKMLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x2CCEE80", Offset = "0x2CCDA80", VA = "0x182CCEE80", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x2CD0A80", Offset = "0x2CCF680", VA = "0x182CD0A80", Slot = "5")]
	[AsyncStateMachine(typeof(KLJPGKPIOAD))]
	public Task KAIOPAGCCDO(AIMCOPKLBGF ICIOKLAEBJL, OJPPJFIPFAD FEBOPLMBIIB, CancellationToken CLLGBCLOIHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x2CCED20", Offset = "0x2CCD920", VA = "0x182CCED20")]
	[AsyncStateMachine(typeof(HGAKFNMPGHP))]
	private Task DMCNKBFLHLN(AIMCOPKLBGF ICIOKLAEBJL, OJPPJFIPFAD FEBOPLMBIIB, CancellationToken CLLGBCLOIHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x2CCF5E0", Offset = "0x2CCE1E0", VA = "0x182CCF5E0")]
	private static void FJGAHKKOFJE(AIMCOPKLBGF ICIOKLAEBJL, Exception CFGIDIAFBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x2CD0040", Offset = "0x2CCEC40", VA = "0x182CD0040")]
	private static void INOJJCMLCDH(AJACBNKONFD FACGOAINLHM, Exception CFGIDIAFBCD, [Optional] List<int> HCNGIIIGMJN, int JHJBEDELFLF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x2CD0EB0", Offset = "0x2CCFAB0", VA = "0x182CD0EB0")]
	[AsyncStateMachine(typeof(PPPMBFOOJBH))]
	private Task KPLOJFFLJOH(IFANLHMJJPA KIACJFINHDJ, AIMCOPKLBGF ICIOKLAEBJL, OJPPJFIPFAD FEBOPLMBIIB, CMFLPAKKNOD IOHDDBKPKDO, CancellationToken CLLGBCLOIHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x2CCFB20", Offset = "0x2CCE720", VA = "0x182CCFB20")]
	private void HEKJDAFFAIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x2CCEBE0", Offset = "0x2CCD7E0", VA = "0x182CCEBE0")]
	[AsyncStateMachine(typeof(OOAEFMJCEJL))]
	private Task DJJIPAKKEHP(IFANLHMJJPA KIACJFINHDJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x2CCF050", Offset = "0x2CCDC50", VA = "0x182CCF050")]
	private void EJHNGCHJOLO(AIMCOPKLBGF ICIOKLAEBJL, CancellationToken CLLGBCLOIHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x2CCE630", Offset = "0x2CCD230", VA = "0x182CCE630")]
	private void CJDBMCNFAPK(AIMCOPKLBGF ICIOKLAEBJL, CMFLPAKKNOD IOHDDBKPKDO, OperationCanceledException CIMHIBMOIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x2CCE380", Offset = "0x2CCCF80", VA = "0x182CCE380")]
	private void CECLNHEAPIM(AIMCOPKLBGF ICIOKLAEBJL, CMFLPAKKNOD IOHDDBKPKDO, Exception CFGIDIAFBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x2CD0C20", Offset = "0x2CCF820", VA = "0x182CD0C20")]
	private void KIPBCBONBMK(AIMCOPKLBGF ICIOKLAEBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x2CCF430", Offset = "0x2CCE030", VA = "0x182CCF430")]
	private static KOBJCIBGGPL EPMLBOBHLOE(AIMCOPKLBGF ICIOKLAEBJL)
	{
		return default(KOBJCIBGGPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x2CD11A0", Offset = "0x2CCFDA0", VA = "0x182CD11A0")]
	[AsyncStateMachine(typeof(IEIJEPGBAIB))]
	private Task LMBAAPBPNPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x2CD1780", Offset = "0x2CD0380", VA = "0x182CD1780")]
	private static DCHLPHEOJDC PPHNMGCBECJ(AIMCOPKLBGF ICIOKLAEBJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x2CCE210", Offset = "0x2CCCE10", VA = "0x182CCE210")]
	[AsyncStateMachine(typeof(NKIOCIOKGHL))]
	private Task CAHLLMKHMPL(AIMCOPKLBGF ICIOKLAEBJL, CMFLPAKKNOD IOHDDBKPKDO, IFANLHMJJPA KIACJFINHDJ, CancellationToken FBLNGKEOGEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x2CD12A0", Offset = "0x2CCFEA0", VA = "0x182CD12A0")]
	[AsyncStateMachine(typeof(NJGCPOCDLFC))]
	private Task MNAENKCIHCN(AIMCOPKLBGF ICIOKLAEBJL, CancellationTokenSource ALDPACJKGJD, Task NMLMLKGJIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x2CCFEB0", Offset = "0x2CCEAB0", VA = "0x182CCFEB0")]
	[AsyncStateMachine(typeof(LHALANPPMLG))]
	private Task IICCLKBMGPH(PGGLGCLPJMP GGLIAHNLGFB, MOBDJEKJCIH NNDHFKDGLFI, AIMCOPKLBGF KAJDBPGKJMC, CMFLPAKKNOD JLAAOIOAKOE, IFANLHMJJPA KIACJFINHDJ, CancellationToken LDIGLMPFFJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x2CCF7A0", Offset = "0x2CCE3A0", VA = "0x182CCF7A0")]
	private CMFLPAKKNOD FOJAAFBMGIL(CMFLPAKKNOD JLAAOIOAKOE, ref CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x2CCF9E0", Offset = "0x2CCE5E0", VA = "0x182CCF9E0")]
	[AsyncStateMachine(typeof(EMEEGKOGDII))]
	private Task GDGGLCBFKJA(IFANLHMJJPA KIACJFINHDJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x2CCDEC0", Offset = "0x2CCCAC0", VA = "0x182CCDEC0")]
	[AsyncStateMachine(typeof(MCHJJCKOJPE))]
	private Task BEGEBDAKEKH(IFANLHMJJPA KIACJFINHDJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x2CD0880", Offset = "0x2CCF480", VA = "0x182CD0880")]
	[AsyncStateMachine(typeof(BLPHGNAGBKE))]
	private Task JLAKKANOIMN(IFANLHMJJPA KIACJFINHDJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x2CD1400", Offset = "0x2CD0000", VA = "0x182CD1400")]
	[AsyncStateMachine(typeof(OCBMMGMHEML))]
	private Task PDENAAPPALN(MMBJADMOHGP GAGLKGONONJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x2CCFD70", Offset = "0x2CCE970", VA = "0x182CCFD70")]
	[AsyncStateMachine(typeof(OPEHGGMHGBP))]
	private Task HNPCKOANKMC(IFANLHMJJPA DHJIFBEMLMJ, CancellationToken FBLNGKEOGEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x2CCF470", Offset = "0x2CCE070", VA = "0x182CCF470")]
	private static void FDNHKCOCLID(AIMCOPKLBGF ICIOKLAEBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x2CCDFF0", Offset = "0x2CCCBF0", VA = "0x182CCDFF0")]
	private void BLHBKIEDBOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x2CCEB50", Offset = "0x2CCD750", VA = "0x182CCEB50")]
	private void DINOMBMFCFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x2CCFCE0", Offset = "0x2CCE8E0", VA = "0x182CCFCE0")]
	private void HFEILAPPEIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x2CCF3A0", Offset = "0x2CCDFA0", VA = "0x182CCF3A0")]
	private void ELJOLKBGOEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x2CD1030", Offset = "0x2CCFC30", VA = "0x182CD1030")]
	private static void LKNECOPIJAC(AIMCOPKLBGF ICIOKLAEBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x2CD09C0", Offset = "0x2CCF5C0", VA = "0x182CD09C0")]
	private static void JOCMDHLEHGN(AIMCOPKLBGF ICIOKLAEBJL, CancellationToken FBLNGKEOGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x2CCEED0", Offset = "0x2CCDAD0", VA = "0x182CCEED0")]
	private static void EFKEPBCGEPG(AIMCOPKLBGF ICIOKLAEBJL, Exception CFGIDIAFBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x2CD1540", Offset = "0x2CD0140", VA = "0x182CD1540")]
	private void PEOPAMNJOBK(AIMCOPKLBGF ICIOKLAEBJL, Task NMLMLKGJIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x2CCDDE0", Offset = "0x2CCC9E0", VA = "0x182CCDDE0")]
	private static void AJGKFIDACMM(Func<string> NOGJKHDOHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x2CD1920", Offset = "0x2CD0520", VA = "0x182CD1920")]
	public AHIECCMFHKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[Preserve]
internal sealed class JPALMMDHHDH : GCOONBKMOLI, JMFFJBHIEHM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class KLFOPNKNEBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public KLFOPNKNEBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x44864D0", Offset = "0x44850D0", VA = "0x1844864D0")]
		internal object <Add>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class PHJMKAEFOJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public PHJMKAEFOJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x4489B90", Offset = "0x4488790", VA = "0x184489B90")]
		internal object <Remove>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class NINKGHHACOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public NINKGHHACOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x4488810", Offset = "0x4487410", VA = "0x184488810")]
		internal object <Cancel>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class LPGHJPLFOLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public LPGHJPLFOLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x44876A0", Offset = "0x44862A0", VA = "0x1844876A0")]
		internal object <MarkStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class JHDGKHMOJDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public JHDGKHMOJDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x44859D0", Offset = "0x44845D0", VA = "0x1844859D0")]
		internal object <MarkFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly Dictionary<Guid, AOMGIMDBOFO> NJADAKMBNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private readonly TimeSpan OFDBEBOMDPO;

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "10")]
	public void CKNDJHJGHOM(INMGAJCAIOM GFONEBKMLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x2CEF4C0", Offset = "0x2CEE0C0", VA = "0x182CEF4C0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x2CEEE80", Offset = "0x2CEDA80", VA = "0x182CEEE80", Slot = "4")]
	public IPMLHDGFENH AABPNGPFBPJ(Guid MJGBLGMCHFL)
	{
		return default(IPMLHDGFENH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x2CEF820", Offset = "0x2CEE420", VA = "0x182CEF820", Slot = "5")]
	public bool KFPKFODPJHB(Guid MJGBLGMCHFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x2CEFAD0", Offset = "0x2CEE6D0", VA = "0x182CEFAD0", Slot = "8")]
	public bool OICILAKIGII(Guid MJGBLGMCHFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x2CEF100", Offset = "0x2CEDD00", VA = "0x182CEF100", Slot = "6")]
	public bool CHCAANJFLKL(Guid MJGBLGMCHFL, Task BADOEGFABBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x2CEF560", Offset = "0x2CEE160", VA = "0x182CEF560", Slot = "7")]
	public bool ILMJLPLGDGM(Guid MJGBLGMCHFL, ENHABCKLLMN GCFAJIEGBJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x2CEF4D0", Offset = "0x2CEE0D0", VA = "0x182CEF4D0", Slot = "9")]
	public Task<(ENHABCKLLMN, Task)> ENAILHPFCDG(Guid MJGBLGMCHFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x2CEFD40", Offset = "0x2CEE940", VA = "0x182CEFD40")]
	private void PJHGKBPEHHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x2CEFFE0", Offset = "0x2CEEBE0", VA = "0x182CEFFE0")]
	public JPALMMDHHDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[Preserve]
internal class FFJLPGAHOGH : JOKEPNIPFLI, JMFFJBHIEHM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private class AFJAGOCKIFH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private readonly AIMCOPKLBGF PEBJFBOHFIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private readonly CancellationTokenSource NAMBCJPDCFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public readonly CancellationToken KPIFEHGJPJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private bool PLBKMDIILOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private bool LNPINMMGACJ;

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x37E9190", Offset = "0x37E7D90", VA = "0x1837E9190")]
		public AFJAGOCKIFH(AIMCOPKLBGF PEBJFBOHFIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x37E9040", Offset = "0x37E7C40", VA = "0x1837E9040")]
		public void OICILAKIGII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x37E9010", Offset = "0x37E7C10", VA = "0x1837E9010", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class BCOFEDECBFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public PNLENGEAFDM disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public BCOFEDECBFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x37EA610", Offset = "0x37E9210", VA = "0x1837EA610")]
		internal object <OnDisconnectedFromPhotonWhileConnected>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private struct EALJJEALMCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public PNLENGEAFDM disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public FFJLPGAHOGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x37EDF10", Offset = "0x37ECB10", VA = "0x1837EDF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class IKOFOAGBCAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public IKOFOAGBCAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x37F6F60", Offset = "0x37F5B60", VA = "0x1837F6F60")]
		internal object <OnPlayerPresenceUpdated>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private struct IAKKJIPCOIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public FFJLPGAHOGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x37F53D0", Offset = "0x37F3FD0", VA = "0x1837F53D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x73CE90", Offset = "0x73BA90", VA = "0x18073CE90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class ADOMAHIGKLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public AIMCOPKLBGF newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public ADOMAHIGKLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x37E8EF0", Offset = "0x37E7AF0", VA = "0x1837E8EF0")]
		internal object <TryJoinRoomInstance>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x37E8F90", Offset = "0x37E7B90", VA = "0x1837E8F90")]
		internal object <TryJoinRoomInstance>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x37E8FD0", Offset = "0x37E7BD0", VA = "0x1837E8FD0")]
		internal object <TryJoinRoomInstance>b__3()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class PBPCOPCJMCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public PBPCOPCJMCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x37FC680", Offset = "0x37FB280", VA = "0x1837FC680")]
		internal void <TryJoinRoomInstance>b__1()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct FPPPNBEPMBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public AIMCOPKLBGF newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public FFJLPGAHOGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public OJPPJFIPFAD customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private ADOMAHIGKLA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x37F0A30", Offset = "0x37EF630", VA = "0x1837F0A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private LNIFJFFHNEM CKOGFFNEAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private INMGAJCAIOM GFONEBKMLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private ALJBNAAMKDN NCLDOPAMJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private AHNPBEMNBDD OPBBALMJDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private BNKAOLAGPBJ CPNGCJKFMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private MGDPMIBADCO KLKBGPFNKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private long EGGMNLNCDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private AFJAGOCKIFH DKINHGNDKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private bool DCOODKBGCKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private Task NJOMPHKNLAK;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private ELNLIPPPCOB ODANIKCBFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x2CDF4C0", Offset = "0x2CDE0C0", VA = "0x182CDF4C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool MNEMBGEHENH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x772830", Offset = "0x771430", VA = "0x180772830")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x2CDE4E0", Offset = "0x2CDD0E0", VA = "0x182CDE4E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x2CDE600", Offset = "0x2CDD200", VA = "0x182CDE600", Slot = "4")]
	public void CKNDJHJGHOM(INMGAJCAIOM GFONEBKMLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x2CDEBF0", Offset = "0x2CDD7F0", VA = "0x182CDEBF0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x2CDF060", Offset = "0x2CDDC60", VA = "0x182CDF060")]
	[AsyncStateMachine(typeof(EALJJEALMCK))]
	private Task HPCHOKLLKIL(PNLENGEAFDM JNNLBNPCGDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x2CDE2D0", Offset = "0x2CDCED0", VA = "0x182CDE2D0")]
	private void ALAOMJLCDPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x2CDE0C0", Offset = "0x2CDCCC0", VA = "0x182CDE0C0")]
	private void AHAPLMLGIHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x2CDE8B0", Offset = "0x2CDD4B0", VA = "0x182CDE8B0")]
	private void DKGLJEHHNHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x2CDEE60", Offset = "0x2CDDA60", VA = "0x182CDEE60")]
	private bool FDMKMPKAOEA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x2CDED70", Offset = "0x2CDD970", VA = "0x182CDED70")]
	[AsyncStateMachine(typeof(IAKKJIPCOIC))]
	private void ECLBFAFCOAM(int NKHNEPFILOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x2CDF180", Offset = "0x2CDDD80", VA = "0x182CDF180")]
	private void JMFLOPLPGDP(out IDisposable GKHAAFAGJCI, out IDisposable LBKMKBEBHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x2CDEEE0", Offset = "0x2CDDAE0", VA = "0x182CDEEE0")]
	private bool FNMECMCIIOD(AIMCOPKLBGF PEBJFBOHFIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x2CDE5C0", Offset = "0x2CDD1C0", VA = "0x182CDE5C0")]
	private void CFMFDILEMOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x2CDEAB0", Offset = "0x2CDD6B0", VA = "0x182CDEAB0")]
	[AsyncStateMachine(typeof(FPPPNBEPMBN))]
	private Task DMCNKBFLHLN(AIMCOPKLBGF PEBJFBOHFIA, OJPPJFIPFAD FEBOPLMBIIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x2CDF510", Offset = "0x2CDE110", VA = "0x182CDF510")]
	public FFJLPGAHOGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[Preserve]
internal sealed class MLNLJDBLOBI : CBKINJMGMAE, JMFFJBHIEHM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private struct OABHNBKNKJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public AsyncTaskMethodBuilder<JKIMMKJPANP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public MLNLJDBLOBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private TaskAwaiter<JKIMMKJPANP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x4488E20", Offset = "0x4487A20", VA = "0x184488E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x4489070", Offset = "0x4487C70", VA = "0x184489070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class JODIBGCPKLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public MAAKCJEMEIP message;

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public JODIBGCPKLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x4485A90", Offset = "0x4484690", VA = "0x184485A90")]
		internal object <MasterTryStartOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class JNLKFKPMNIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public MAAKCJEMEIP messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public JNLKFKPMNIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x4485A30", Offset = "0x4484630", VA = "0x184485A30")]
		internal object <TryStartOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class BMBKDOCFJIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public MAAKCJEMEIP request;

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public BMBKDOCFJIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x447E880", Offset = "0x447D480", VA = "0x18447E880")]
		internal object <RunOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private struct ENFODGEGOMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public MAAKCJEMEIP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public MLNLJDBLOBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private TaskAwaiter<KHCEKICDGEB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x44818D0", Offset = "0x44804D0", VA = "0x1844818D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class BOHDOJCOPGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public MAAKCJEMEIP operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public BOHDOJCOPGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x447E8E0", Offset = "0x447D4E0", VA = "0x18447E8E0")]
		internal object <RunOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private struct EOOHOFKEFNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public MAAKCJEMEIP operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public MLNLJDBLOBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private CMFLPAKKNOD <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private TaskAwaiter<MAAKCJEMEIP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x4482050", Offset = "0x4480C50", VA = "0x184482050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct PAOPAAPAGBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public AsyncTaskMethodBuilder<KHCEKICDGEB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public MLNLJDBLOBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public MAAKCJEMEIP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private CMFLPAKKNOD <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private TaskAwaiter<MAAKCJEMEIP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x44896C0", Offset = "0x44882C0", VA = "0x1844896C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x4489B10", Offset = "0x4488710", VA = "0x184489B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class DJIBFEMEJIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public KHCEKICDGEB operation;

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public DJIBFEMEJIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x44804F0", Offset = "0x447F0F0", VA = "0x1844804F0")]
		internal object <RunOperation>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct NKLNJODBJDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public KHCEKICDGEB operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public MLNLJDBLOBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private global::EOHJIFBBDNE<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x44888E0", Offset = "0x44874E0", VA = "0x1844888E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class HMBFPIOKLMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public MAAKCJEMEIP request;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public HMBFPIOKLMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x4484990", Offset = "0x4483590", VA = "0x184484990")]
		internal object <TryCreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class PJHBJJDDOMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public MAAKCJEMEIP request;

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public PJHBJJDDOMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x4489BF0", Offset = "0x44887F0", VA = "0x184489BF0")]
		internal object <CreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private INMGAJCAIOM GFONEBKMLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private FDGLANELENM BJDIPLHAKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private BFEIBAAHKIM FICHALLOJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private IENFLCHLOJH KDOMNDEKJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private FJJKLBCOJIJ NKGCEELNNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private TaskCompletionSource<JKIMMKJPANP> KOBCLGGPNNN;

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x365DB90", Offset = "0x365C790", VA = "0x18365DB90", Slot = "7")]
	public void CKNDJHJGHOM(INMGAJCAIOM GFONEBKMLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x365E370", Offset = "0x365CF70", VA = "0x18365E370", Slot = "6")]
	[AsyncStateMachine(typeof(OABHNBKNKJK))]
	public Task<JKIMMKJPANP> GPBLGIJNNFF(CancellationToken EFKPEBBFCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x365D780", Offset = "0x365C380", VA = "0x18365D780", Slot = "4")]
	public void APJDOJNLGDP(MAAKCJEMEIP DPNJMDFICMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x365E880", Offset = "0x365D480", VA = "0x18365E880", Slot = "5")]
	public void NNPNDNMHNDL(MAAKCJEMEIP DNOMDEOIJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x365EC60", Offset = "0x365D860", VA = "0x18365EC60")]
	[AsyncStateMachine(typeof(ENFODGEGOMD))]
	private Task OJOGGNDNELC(MAAKCJEMEIP PJCBPMCBLEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x365DDF0", Offset = "0x365C9F0", VA = "0x18365DDF0")]
	[AsyncStateMachine(typeof(EOOHOFKEFNA))]
	private Task GDPOPCJPMMO(MAAKCJEMEIP CDLBAGKMEKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x365E730", Offset = "0x365D330", VA = "0x18365E730")]
	[AsyncStateMachine(typeof(PAOPAAPAGBJ))]
	private Task<KHCEKICDGEB> MOGCFPPJLJE(MAAKCJEMEIP PJCBPMCBLEN, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x365DF20", Offset = "0x365CB20", VA = "0x18365DF20")]
	private CMFLPAKKNOD GKENDLKFNHL(MAAKCJEMEIP KDHBDCIFOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x365DCC0", Offset = "0x365C8C0", VA = "0x18365DCC0")]
	[AsyncStateMachine(typeof(NKLNJODBJDL))]
	private Task DJDGDCNJGEP(KHCEKICDGEB ECKBPFEGIAL, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x365E4B0", Offset = "0x365D0B0", VA = "0x18365E4B0")]
	private KHCEKICDGEB JNDCMBMJEEL(MAAKCJEMEIP PJCBPMCBLEN, CMFLPAKKNOD IGHKLNEJFBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x3102F00", Offset = "0x3101B00", VA = "0x183102F00")]
	private T BICMOICAEJG<T>(T NENFOEKGNGK) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x365DFA0", Offset = "0x365CBA0", VA = "0x18365DFA0")]
	private KHCEKICDGEB GKIKKHJAFOH(MAAKCJEMEIP PJCBPMCBLEN, CMFLPAKKNOD IGHKLNEJFBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public MLNLJDBLOBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x365DC70", Offset = "0x365C870", VA = "0x18365DC70")]
	[CompilerGenerated]
	private void DCJJPHDNLOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[Preserve]
internal sealed class IKMCIFIPLAI : BFEIBAAHKIM, JMFFJBHIEHM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class GHKJKCGHJNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public GHKJKCGHJNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x37F3160", Offset = "0x37F1D60", VA = "0x1837F3160")]
		internal object <OnOperationStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class LMNFEOEHDOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public LMNFEOEHDOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x37F9910", Offset = "0x37F8510", VA = "0x1837F9910")]
		internal object <SendReliableToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private FJJKLBCOJIJ NKGCEELNNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private MKDIIOOCCHE EKGCAIDIMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private CBKINJMGMAE INNLGBJFLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private GCOONBKMOLI NJADAKMBNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private PMILHCKNBKA KJLDHIMAJIC;

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x2CE8CC0", Offset = "0x2CE78C0", VA = "0x182CE8CC0", Slot = "6")]
	public void CKNDJHJGHOM(INMGAJCAIOM GFONEBKMLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x2CE8E30", Offset = "0x2CE7A30", VA = "0x182CE8E30", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x2CE8020", Offset = "0x2CE6C20", VA = "0x182CE8020", Slot = "4")]
	public IPMLHDGFENH AIIANCEOOMD(MAAKCJEMEIP PAJIGOLLBDJ)
	{
		return default(IPMLHDGFENH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x2CE8790", Offset = "0x2CE7390", VA = "0x182CE8790", Slot = "5")]
	public void BHCOBDAJFMK(Guid MJGBLGMCHFL, Task BADOEGFABBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x2CE95D0", Offset = "0x2CE81D0", VA = "0x182CE95D0")]
	private void FNGAMFOEBOA(byte LKLNMLJDNFN, int NJLEBONBCID, object MCEKJBECMCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x2CE8ED0", Offset = "0x2CE7AD0", VA = "0x182CE8ED0")]
	private void EEFPDHAHMNC(JKHCJJCNCHN PGOAEBLMINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x2CE9BF0", Offset = "0x2CE87F0", VA = "0x182CE9BF0")]
	private void LDEMGBEGDFI(JKHCJJCNCHN PGOAEBLMINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x2CE8A10", Offset = "0x2CE7610", VA = "0x182CE8A10")]
	private void CGIPLAGHMDH(JKHCJJCNCHN PGOAEBLMINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x2CEA1D0", Offset = "0x2CE8DD0", VA = "0x182CEA1D0")]
	private ENHABCKLLMN NNHMJPJFPBA(MAAKCJEMEIP KDHBDCIFOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x2CE96A0", Offset = "0x2CE82A0", VA = "0x182CE96A0")]
	private void HEMGHLLMOML(MAAKCJEMEIP CDLBAGKMEKL, ENHABCKLLMN GCFAJIEGBJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x2CE9ED0", Offset = "0x2CE8AD0", VA = "0x182CE9ED0")]
	private bool LNHBMHMGBIC(MAAKCJEMEIP CDLBAGKMEKL, ENHABCKLLMN GCFAJIEGBJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x2CE8500", Offset = "0x2CE7100", VA = "0x182CE8500")]
	private bool AMJIAJEIINE(MAAKCJEMEIP CIGOHPFDKLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x2CE98F0", Offset = "0x2CE84F0", VA = "0x182CE98F0")]
	private bool JBBJGLLCPFK(byte LKLNMLJDNFN, ExitGames.Client.Photon.Hashtable PGOAEBLMINI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public IKMCIFIPLAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[Preserve]
internal sealed class MMKACMKAEPO : NKEPPPJLJGJ, JMFFJBHIEHM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class PNENFAALKHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public JKIMMKJPANP operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public MMKACMKAEPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public MAAKCJEMEIP roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public PNENFAALKHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x448A1A0", Offset = "0x4488DA0", VA = "0x18448A1A0")]
		internal object <RecRoom.RoomLoading.IRoomManagerRequestOperation.RequestOperation>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x448A210", Offset = "0x4488E10", VA = "0x18448A210")]
		internal object <RecRoom.RoomLoading.IRoomManagerRequestOperation.RequestOperation>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private struct KNPFPPMDIMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public AsyncTaskMethodBuilder<ENHABCKLLMN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public MMKACMKAEPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public MAAKCJEMEIP roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private TaskAwaiter<ENHABCKLLMN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x4486A90", Offset = "0x4485690", VA = "0x184486A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x4486FF0", Offset = "0x4485BF0", VA = "0x184486FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class NJLECEMEPBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public JKIMMKJPANP operationType;

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public NJLECEMEPBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x4488870", Offset = "0x4487470", VA = "0x184488870")]
		internal object <CanLocalPlayerRequestOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class CHFONMKNCEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public MAAKCJEMEIP request;

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public CHFONMKNCEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x447F740", Offset = "0x447E340", VA = "0x18447F740")]
		internal object <RequestOperationInternal>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x447F7B0", Offset = "0x447E3B0", VA = "0x18447F7B0")]
		internal object <RequestOperationInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x447F820", Offset = "0x447E420", VA = "0x18447F820")]
		internal object <RequestOperationInternal>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private struct BFJOBHHMPKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public AsyncTaskMethodBuilder<ENHABCKLLMN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public MAAKCJEMEIP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public MMKACMKAEPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private CHFONMKNCEE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private IPMLHDGFENH <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private ENHABCKLLMN <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private TaskAwaiter<(ENHABCKLLMN validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x447E140", Offset = "0x447CD40", VA = "0x18447E140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x447E830", Offset = "0x447D430", VA = "0x18447E830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private FJJKLBCOJIJ NKGCEELNNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private MKDIIOOCCHE EKGCAIDIMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private BFEIBAAHKIM FICHALLOJHN;

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x365EED0", Offset = "0x365DAD0", VA = "0x18365EED0", Slot = "5")]
	public void CKNDJHJGHOM(INMGAJCAIOM GFONEBKMLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x365F1E0", Offset = "0x365DDE0", VA = "0x18365F1E0", Slot = "4")]
	[AsyncStateMachine(typeof(KNPFPPMDIMH))]
	private Task<ENHABCKLLMN> KBNCPIDFLDH(MAAKCJEMEIP KDHBDCIFOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x365EF80", Offset = "0x365DB80", VA = "0x18365EF80")]
	private bool GLEFNFNHGGH(JKIMMKJPANP ALOINNFJFCL, out ENHABCKLLMN HJIMPKKMPML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x365ED90", Offset = "0x365D990", VA = "0x18365ED90")]
	[AsyncStateMachine(typeof(BFJOBHHMPKO))]
	private Task<ENHABCKLLMN> CAADKLALPCD(MAAKCJEMEIP PJCBPMCBLEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public MMKACMKAEPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[Preserve]
internal sealed class IKFBDHFOLML : PKCDHDPJNDG, JMFFJBHIEHM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private struct CFEANEBNGGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public AsyncTaskMethodBuilder<PGGLGCLPJMP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public AIMCOPKLBGF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public IKFBDHFOLML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private TaskAwaiter<OFPAILNJPLH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x37EB940", Offset = "0x37EA540", VA = "0x1837EB940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x37EBB20", Offset = "0x37EA720", VA = "0x1837EBB20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class FJLPPBAAAAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public FJLPPBAAAAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x37F0830", Offset = "0x37EF430", VA = "0x1837F0830")]
		internal object <GetRoomDetails>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private struct NHNGIAEMCDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public AsyncTaskMethodBuilder<OFPAILNJPLH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public IKFBDHFOLML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public AIMCOPKLBGF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private FJLPPBAAAAP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private TaskAwaiter<CPDJMCBJMIL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x37FA6B0", Offset = "0x37F92B0", VA = "0x1837FA6B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x37FAA70", Offset = "0x37F9670", VA = "0x1837FAA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private sealed class DKDGJPHJKMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public DKDGJPHJKMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x15DAE50", Offset = "0x15D9A50", VA = "0x1815DAE50")]
		internal bool <GetRoomDataBlobWithHashForRoomDetails>b__0(MKEIKAGIGLF sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private AHNPBEMNBDD OPBBALMJDDI;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private static readonly (HDLEMCDEJDD superRoomData, string unityAssetId, HDLEMCDEJDD subRoomData) FGIPMMFIMGO;

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x2CE70A0", Offset = "0x2CE5CA0", VA = "0x182CE70A0", Slot = "5")]
	public void CKNDJHJGHOM(INMGAJCAIOM GFONEBKMLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x2CE74C0", Offset = "0x2CE60C0", VA = "0x182CE74C0", Slot = "4")]
	[AsyncStateMachine(typeof(CFEANEBNGGH))]
	public Task<PGGLGCLPJMP> KHFHMKEILHJ(IFANLHMJJPA DHJIFBEMLMJ, AIMCOPKLBGF ICIOKLAEBJL, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7870", Offset = "0x2CE6470", VA = "0x182CE7870")]
	[AsyncStateMachine(typeof(NHNGIAEMCDH))]
	private Task<OFPAILNJPLH> PKPIEAAFIHL(AIMCOPKLBGF ICIOKLAEBJL, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7640", Offset = "0x2CE6240", VA = "0x182CE7640")]
	private PGGLGCLPJMP NHKHAAAMDGK(AIMCOPKLBGF ICIOKLAEBJL, OFPAILNJPLH FHLCFCGKOHO, long ONEELBLPKOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7110", Offset = "0x2CE5D10", VA = "0x182CE7110")]
	private (HDLEMCDEJDD, string, HDLEMCDEJDD) KCMOEEAEFBC(AIMCOPKLBGF ICIOKLAEBJL, OFPAILNJPLH FHLCFCGKOHO, long ONEELBLPKOK)
	{
		return default((HDLEMCDEJDD, string, HDLEMCDEJDD));
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public IKFBDHFOLML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[Preserve]
internal sealed class IIBKFBLIKIG : IENFLCHLOJH, JMFFJBHIEHM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class GELEAOBLLCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public MAAKCJEMEIP request;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public GELEAOBLLCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x37F1B80", Offset = "0x37F0780", VA = "0x1837F1B80")]
		internal object <MasterSynchronizeRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private struct KHJDFNACIGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public AsyncTaskMethodBuilder<MAAKCJEMEIP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public MAAKCJEMEIP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public IIBKFBLIKIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public CMFLPAKKNOD pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private TaskAwaiter<MAAKCJEMEIP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x37F8C40", Offset = "0x37F7840", VA = "0x1837F8C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x37F90A0", Offset = "0x37F7CA0", VA = "0x1837F90A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct OKOAELDCPDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<MAAKCJEMEIP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public IIBKFBLIKIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public CMFLPAKKNOD pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private TaskAwaiter<MJPLDIOAJAH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x37FBA00", Offset = "0x37FA600", VA = "0x1837FBA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x37FBFE0", Offset = "0x37FABE0", VA = "0x1837FBFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class IAMCNLAJOBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public MAAKCJEMEIP request;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public IAMCNLAJOBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x37F5E60", Offset = "0x37F4A60", VA = "0x1837F5E60")]
		internal object <MasterSyncRequestAndValidateResponse>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct PFFJFEFOLJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public AsyncTaskMethodBuilder<MAAKCJEMEIP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public MAAKCJEMEIP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public IIBKFBLIKIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public CMFLPAKKNOD pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private ADLMHLPOFJH <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private CNGAKMMHAFA <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private TaskAwaiter<MJPLDIOAJAH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x37FC720", Offset = "0x37FB320", VA = "0x1837FC720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x37FD1B0", Offset = "0x37FBDB0", VA = "0x1837FD1B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private FJJKLBCOJIJ NKGCEELNNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private MNLEKKOFBOM AGFHOMEKGMK;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private AFCKFGFKPJC PKHPHKDPEEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x2CE6800", Offset = "0x2CE5400", VA = "0x182CE6800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x2CE6600", Offset = "0x2CE5200", VA = "0x182CE6600", Slot = "8")]
	public void CKNDJHJGHOM(INMGAJCAIOM GFONEBKMLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x2CE6690", Offset = "0x2CE5290", VA = "0x182CE6690", Slot = "4")]
	[AsyncStateMachine(typeof(KHJDFNACIGF))]
	public Task<MAAKCJEMEIP> EALEFCOPNMN(MAAKCJEMEIP PJCBPMCBLEN, CMFLPAKKNOD IGHKLNEJFBP, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x2CE68B0", Offset = "0x2CE54B0", VA = "0x182CE68B0", Slot = "5")]
	[AsyncStateMachine(typeof(OKOAELDCPDC))]
	public Task<MAAKCJEMEIP> GFGJABPLMGC(CancellationToken OKPCBPJCBCJ, CMFLPAKKNOD IGHKLNEJFBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x2CE6A10", Offset = "0x2CE5610", VA = "0x182CE6A10", Slot = "6")]
	public CJABFHHEKHC GKMNOBJJEMO(KHCEKICDGEB FGKPBBLLHMN, IFANLHMJJPA DHJIFBEMLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x2CE6E20", Offset = "0x2CE5A20", VA = "0x182CE6E20", Slot = "7")]
	public CJABFHHEKHC MHKJFCPFOIN(KHCEKICDGEB FGKPBBLLHMN, IFANLHMJJPA DHJIFBEMLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x2CE6CA0", Offset = "0x2CE58A0", VA = "0x182CE6CA0")]
	[AsyncStateMachine(typeof(PFFJFEFOLJD))]
	private Task<MAAKCJEMEIP> MAPAKDMHLMD(MAAKCJEMEIP PJCBPMCBLEN, CMFLPAKKNOD IGHKLNEJFBP, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x253A930", Offset = "0x2539530", VA = "0x18253A930")]
	private static byte[] OEFFJEINNOI(MAAKCJEMEIP DPNJMDFICMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x2CE6420", Offset = "0x2CE5020", VA = "0x182CE6420")]
	private static string CKKHDDIBMJG(byte[] BHDBJANFJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public IIBKFBLIKIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[Preserve]
internal sealed class FMGHBKPFCKB : MKDIIOOCCHE, JMFFJBHIEHM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private EDIODIIJGCI IGNEANDJINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private FJJKLBCOJIJ NKGCEELNNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private FDGLANELENM BJDIPLHAKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private JJKIADCPHFH PBFDJCEHPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	private AHNPBEMNBDD OPBBALMJDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private MGDPMIBADCO KLKBGPFNKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private EEGMJHFMDLE BFJPGIICPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private BNKAOLAGPBJ CPNGCJKFMPJ;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private ELNLIPPPCOB ODANIKCBFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x2CE1350", Offset = "0x2CDFF50", VA = "0x182CE1350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private static ENHABCKLLMN JLPALJILKIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x2CE1070", Offset = "0x2CDFC70", VA = "0x182CE1070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x2CE0B00", Offset = "0x2CDF700", VA = "0x182CE0B00", Slot = "7")]
	public void CKNDJHJGHOM(INMGAJCAIOM GFONEBKMLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x2CE0CC0", Offset = "0x2CDF8C0", VA = "0x182CE0CC0", Slot = "4")]
	public ENHABCKLLMN GMOFGOPFJHN(JCBHONMOFEO KFOLKCJEHFF, JKIMMKJPANP EMFMLAOCKEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x2CE10D0", Offset = "0x2CDFCD0", VA = "0x182CE10D0", Slot = "5")]
	public ENHABCKLLMN KBEKEEEHHFI(JCBHONMOFEO ONNJILEPDIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x2CE0E50", Offset = "0x2CDFA50", VA = "0x182CE0E50", Slot = "6")]
	public ENHABCKLLMN HIODLDLLGLM(JCBHONMOFEO ONNJILEPDIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x2CE0C60", Offset = "0x2CDF860", VA = "0x182CE0C60")]
	private static ENHABCKLLMN GGHINBCAGEK(PMLDGHOOJDK KLLKBLNBCMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public FMGHBKPFCKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public class JCENFDAECCB : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x2CEBC10", Offset = "0x2CEA810", VA = "0x182CEBC10")]
	public JCENFDAECCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x12744B0", Offset = "0x12730B0", VA = "0x1812744B0")]
	public JCENFDAECCB(string DPNJMDFICMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[Preserve]
internal sealed class OMLJIBNCANI : BPNNIPEHPFP, JMFFJBHIEHM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct FMHOFKELFPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public AsyncTaskMethodBuilder<ENHABCKLLMN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public OMLJIBNCANI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public KAMHGLCAIAM autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private global::EOHJIFBBDNE<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private IFANLHMJJPA <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private KJEOBNMEEGA <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private IFANLHMJJPA <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private TaskAwaiter<ENHABCKLLMN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x4483900", Offset = "0x4482500", VA = "0x184483900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x4483F90", Offset = "0x4482B90", VA = "0x184483F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct HKICHACBOPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public OMLJIBNCANI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x4484330", Offset = "0x4482F30", VA = "0x184484330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct PLDJIKBBLPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public OMLJIBNCANI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x4489C50", Offset = "0x4488850", VA = "0x184489C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct ENOBNHFKJGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public OMLJIBNCANI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x4481F10", Offset = "0x4480B10", VA = "0x184481F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct EMHJKCLCFOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public OMLJIBNCANI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public TimeSpan delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x44811A0", Offset = "0x447FDA0", VA = "0x1844811A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct HODFFPPNBGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public OMLJIBNCANI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public KJGKHGGPEAN autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private global::EOHJIFBBDNE<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x4484C80", Offset = "0x4483880", VA = "0x184484C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private static readonly TimeSpan KPKGOOOIMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private FJJKLBCOJIJ NKGCEELNNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private INMGAJCAIOM GFONEBKMLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	private AHNPBEMNBDD OPBBALMJDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private IENFLCHLOJH KDOMNDEKJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private FDGLANELENM BJDIPLHAKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private EEGMJHFMDLE BFJPGIICPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private CancellationTokenSource CIHHHDCLJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private Task NJEKENDPCIO;

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x3664AF0", Offset = "0x36636F0", VA = "0x183664AF0", Slot = "6")]
	public void CKNDJHJGHOM(INMGAJCAIOM GFONEBKMLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x1A06C30", Offset = "0x1A05830", VA = "0x181A06C30", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x3665060", Offset = "0x3663C60", VA = "0x183665060", Slot = "4")]
	[AsyncStateMachine(typeof(FMHOFKELFPO))]
	public Task<ENHABCKLLMN> NNKDICBIJNM(KAMHGLCAIAM KHJPFEIDFAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x36652D0", Offset = "0x3663ED0", VA = "0x1836652D0", Slot = "5")]
	[AsyncStateMachine(typeof(HKICHACBOPG))]
	public Task PIECPJKOJDC([Optional] CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x1A06C30", Offset = "0x1A05830", VA = "0x181A06C30")]
	public void DPGCHKHEOMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x36653F0", Offset = "0x3663FF0", VA = "0x1836653F0")]
	private KJEOBNMEEGA PLPHEHKDEHG(KAMHGLCAIAM KHJPFEIDFAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x3664CA0", Offset = "0x36638A0", VA = "0x183664CA0")]
	[AsyncStateMachine(typeof(PLDJIKBBLPN))]
	private Task DEPALKCKBPC(MMBJADMOHGP DGKCGFAKKDB, CancellationToken CLLGBCLOIHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x3664F40", Offset = "0x3663B40", VA = "0x183664F40")]
	[AsyncStateMachine(typeof(ENOBNHFKJGE))]
	private Task MFAGJOIODLK([Optional] CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x36649C0", Offset = "0x36635C0", VA = "0x1836649C0")]
	[AsyncStateMachine(typeof(EMHJKCLCFOK))]
	private Task CDJKCPIMMBC(TimeSpan GBOIGLPJNJA, CancellationToken CLLGBCLOIHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x36646D0", Offset = "0x36632D0", VA = "0x1836646D0")]
	private Task ABCNCKEEFBE(KJGKHGGPEAN IKLNANFHOOO, CancellationToken CLLGBCLOIHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x36651A0", Offset = "0x3663DA0", VA = "0x1836651A0")]
	[AsyncStateMachine(typeof(HODFFPPNBGO))]
	private Task OKGFLIGGFMJ(KJGKHGGPEAN IKLNANFHOOO, CancellationToken CLLGBCLOIHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x3664DD0", Offset = "0x36639D0", VA = "0x183664DD0")]
	private bool DKNDDKBJGJL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public OMLJIBNCANI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[Preserve]
internal class IKFHAFACMOG : JJKIADCPHFH, JMFFJBHIEHM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct NLJBMOJHHNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public IKFHAFACMOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private global::EOHJIFBBDNE<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x37FADB0", Offset = "0x37F99B0", VA = "0x1837FADB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private HHGGLOOLNJE FBCIPODEIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private INMGAJCAIOM GFONEBKMLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private MKDIIOOCCHE EKGCAIDIMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private IENFLCHLOJH KDOMNDEKJBB;

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7AE0", Offset = "0x2CE66E0", VA = "0x182CE7AE0", Slot = "6")]
	public void CKNDJHJGHOM(INMGAJCAIOM GFONEBKMLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7D60", Offset = "0x2CE6960", VA = "0x182CE7D60", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7DB0", Offset = "0x2CE69B0", VA = "0x182CE7DB0", Slot = "5")]
	[AsyncStateMachine(typeof(NLJBMOJHHNA))]
	public Task LOKCGNGMEII(string HKLHFKDNFJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7D00", Offset = "0x2CE6900", VA = "0x182CE7D00", Slot = "4")]
	public ENHABCKLLMN DKNDDKBJGJL(JCBHONMOFEO KFOLKCJEHFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7ED0", Offset = "0x2CE6AD0", VA = "0x182CE7ED0")]
	private BHIAKEBMNLI OKBEPIPGGCA(string HKLHFKDNFJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public IKFHAFACMOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public static class OOKEPIECKEA
{
	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x36667C0", Offset = "0x36653C0", VA = "0x1836667C0")]
	public static void LGKCGALFEFC(FNLADHKGADM MDGENIFLAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x3666600", Offset = "0x3665200", VA = "0x183666600")]
	internal static void ICLNBGJBOHH(FNLADHKGADM MDGENIFLAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x36666E0", Offset = "0x36652E0", VA = "0x1836666E0")]
	internal static void KLAFEBBAOBF(FNLADHKGADM MDGENIFLAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x3666980", Offset = "0x3665580", VA = "0x183666980")]
	internal static void MIMKPKHFDGL(FNLADHKGADM MDGENIFLAAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class MDILINAAJCB : global::JOMMPNKHCPN<MAAKCJEMEIP>
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class NEOOGLJAFOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public MAAKCJEMEIP message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public NEOOGLJAFOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x4488100", Offset = "0x4486D00", VA = "0x184488100")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly MDILINAAJCB OHEGMANNBEJ;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private const string HNPIHGONAPO = "pl";

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x365CEE0", Offset = "0x365BAE0", VA = "0x18365CEE0")]
	public ExitGames.Client.Photon.Hashtable ANBECOLJJND(MAAKCJEMEIP DPNJMDFICMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x365CF60", Offset = "0x365BB60", VA = "0x18365CF60", Slot = "5")]
	protected override void EJFPNDNELOE(MAAKCJEMEIP DPNJMDFICMK, IDictionary<object, object> GAGLKGONONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x365D0A0", Offset = "0x365BCA0", VA = "0x18365D0A0", Slot = "6")]
	public override MAAKCJEMEIP PPPEOPKFADK(IDictionary<object, object> GAGLKGONONJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x365CA10", Offset = "0x365B610", VA = "0x18365CA10")]
	private static void AJGKFIDACMM(string OBDDOIIMHHM, MAAKCJEMEIP DPNJMDFICMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x365D320", Offset = "0x365BF20", VA = "0x18365D320")]
	public MDILINAAJCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x365CB90", Offset = "0x365B790", VA = "0x18365CB90")]
	[CompilerGenerated]
	internal static string AMLAJGHKNAJ(PGGLGCLPJMP ADEMJHPFLJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public static class GANCJFJIKBP
{
	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public static ENHABCKLLMN JLPALJILKIA
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x2CE1070", Offset = "0x2CDFC70", VA = "0x182CE1070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x2CE29F0", Offset = "0x2CE15F0", VA = "0x182CE29F0")]
	public static bool EHCNGBINMMM(this ENHABCKLLMN GCFAJIEGBJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x2CE0C60", Offset = "0x2CDF860", VA = "0x182CE0C60")]
	public static ENHABCKLLMN GGHINBCAGEK(PMLDGHOOJDK DKCFLNKGNDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x2CE29E0", Offset = "0x2CE15E0", VA = "0x182CE29E0")]
	public static ENHABCKLLMN DDLICHMGNFN(params ENHABCKLLMN[] HNLEPDPPHAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x2CE27E0", Offset = "0x2CE13E0", VA = "0x182CE27E0")]
	public static ENHABCKLLMN ANOEEFCEAFJ(IEnumerable<ENHABCKLLMN> HNLEPDPPHAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x2CE2A10", Offset = "0x2CE1610", VA = "0x182CE2A10")]
	public static string LICDNAOMJOH(this ENHABCKLLMN HJIMPKKMPML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public abstract class MJKAEANCLHI : PILCHFKJGMF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public delegate ENHABCKLLMN PJJLELGKDPD([NotNull] JCBHONMOFEO MHBPNGKFGFF);

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class ODCDLGCKKEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public JCBHONMOFEO photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public ODCDLGCKKEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x44890C0", Offset = "0x4487CC0", VA = "0x1844890C0")]
		internal ENHABCKLLMN <Validate>b__0(PJJLELGKDPD v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private bool JIGLPOGPBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	protected readonly HashSet<PJJLELGKDPD> LHHMBPMMMEM;

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x365D6A0", Offset = "0x365C2A0", VA = "0x18365D6A0", Slot = "4")]
	public void PPLFBHHDEIP(PJJLELGKDPD DFOLEIENDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x365D640", Offset = "0x365C240", VA = "0x18365D640", Slot = "5")]
	public void HMJHMDBAHNI(PJJLELGKDPD DFOLEIENDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x365D3D0", Offset = "0x365BFD0", VA = "0x18365D3D0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x365D420", Offset = "0x365C020", VA = "0x18365D420")]
	protected ENHABCKLLMN GOADMDAGLJG(JCBHONMOFEO ONNJILEPDIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x365D700", Offset = "0x365C300", VA = "0x18365D700")]
	protected MJKAEANCLHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public class HHALOBJAMHA : MJKAEANCLHI, EDIODIIJGCI, PILCHFKJGMF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class IPAHMCLADMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public ENHABCKLLMN result;

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public IPAHMCLADMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x37F7D00", Offset = "0x37F6900", VA = "0x1837F7D00")]
		internal object <CanPlayerReload>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x2CDB050", Offset = "0x2CD9C50", VA = "0x182CDB050")]
	[Preserve]
	public HHALOBJAMHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x2CE43F0", Offset = "0x2CE2FF0", VA = "0x182CE43F0", Slot = "8")]
	public ENHABCKLLMN AELLHAOPEIP(JCBHONMOFEO ONNJILEPDIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public class EFCCBDGIGIK : MJKAEANCLHI, HHGGLOOLNJE, PILCHFKJGMF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class HOEBLHLCMHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public ENHABCKLLMN result;

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public HOEBLHLCMHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x37F50B0", Offset = "0x37F3CB0", VA = "0x1837F50B0")]
		internal object <CanPlayerSave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x2CDB050", Offset = "0x2CD9C50", VA = "0x182CDB050")]
	[Preserve]
	public EFCCBDGIGIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x2CDAED0", Offset = "0x2CD9AD0", VA = "0x182CDAED0", Slot = "8")]
	public ENHABCKLLMN DKNDDKBJGJL(JCBHONMOFEO BHHJJPPBNKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public enum ELCFDJJFPHK
{
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	Misc,
	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	LoadNewRoom,
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	ReloadRoom
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal static class BFMNGGENKCM
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private sealed class IKEEEMIOENA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public global::EOHJIFBBDNE<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public IKEEEMIOENA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x36581A0", Offset = "0x3656DA0", VA = "0x1836581A0")]
		internal object <PrintTimer>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public const string FGFICDNKDDN = "START: ";

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public const string AKFBJOJHFFH = "END: ";

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x2CD2400", Offset = "0x2CD1000", VA = "0x182CD2400")]
	public static global::EOHJIFBBDNE<string> EILMMDBFLMP([Optional] string FOAHDNEHBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x2CD24D0", Offset = "0x2CD10D0", VA = "0x182CD24D0")]
	private static void FGIKAHPIADG(string NANBEBOOGPM, LCANGBKGJKD KIACJFINHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x2CD27F0", Offset = "0x2CD13F0", VA = "0x182CD27F0")]
	private static void MAPANMAJFDF(string NANBEBOOGPM, LCANGBKGJKD KIACJFINHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x2CD2690", Offset = "0x2CD1290", VA = "0x182CD2690")]
	public static void JDAIAJIFOFJ(global::EOHJIFBBDNE<string> KIACJFINHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x2CD25D0", Offset = "0x2CD11D0", VA = "0x182CD25D0")]
	public static string GPDJPENHOEM(MAAKCJEMEIP KDHBDCIFOHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal static class IOMHPMKHDFA
{
	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB450", Offset = "0x2CEA050", VA = "0x182CEB450")]
	public static void EAODBCNKMOJ(this FJJKLBCOJIJ NKGCEELNNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB570", Offset = "0x2CEA170", VA = "0x182CEB570")]
	public static void HKCBCBENHPF(this FJJKLBCOJIJ NKGCEELNNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB460", Offset = "0x2CEA060", VA = "0x182CEB460")]
	private static void HINDECFCLFD(this FJJKLBCOJIJ NKGCEELNNIP, bool JMAIFNABCFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class OOEGGCKLELG : JOBPLKIKOKG, ELCFGCLPODH, NCBMGIHIGDO, KBDJMOGKCNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	private readonly ELCFGCLPODH GMHLGINCFIE;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public JCBHONMOFEO LGHLKNLHIEF
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x3666280", Offset = "0x3664E80", VA = "0x183666280", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public int FFBNDPMOEFD
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x3666180", Offset = "0x3664D80", VA = "0x183666180", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public int GAOEFJPHCCA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x36662D0", Offset = "0x3664ED0", VA = "0x1836662D0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool GGBIIEOIAEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x6AD850", Offset = "0x6AC450", VA = "0x1806AD850", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public int GHNIIHCNAPL
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x7933D0", Offset = "0x791FD0", VA = "0x1807933D0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event LDLHPCOIFJP.HGCCAFBHBMN CGJBHJOMDMK
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event PHGAIBCPCIA GLBFLHCMNFH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x3666040", Offset = "0x3664C40", VA = "0x183666040", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x3666340", Offset = "0x3664F40", VA = "0x183666340", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event Action<bool> MNLLKEFHAOD
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<JCBHONMOFEO> GHBHIMJDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action GDBEMODJOLA
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x36664C0", Offset = "0x36650C0", VA = "0x1836664C0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x3666560", Offset = "0x3665160", VA = "0x183666560", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x76F810", Offset = "0x76E410", VA = "0x18076F810")]
	public OOEGGCKLELG(ELCFGCLPODH GMHLGINCFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x36661D0", Offset = "0x3664DD0", VA = "0x1836661D0", Slot = "8")]
	public bool DKEHBKBPENH(byte LKLNMLJDNFN, ExitGames.Client.Photon.Hashtable ONCDJMKEGHD, FJDNOHIPOJF KIAKEGKLJHB, SendOptions COGEBLKDHFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x36660E0", Offset = "0x3664CE0", VA = "0x1836660E0", Slot = "29")]
	public JCBHONMOFEO BMPFHNOKAFH(int PGJKLAJHNNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x36663E0", Offset = "0x3664FE0", VA = "0x1836663E0", Slot = "16")]
	public JCBHONMOFEO MKLHAKFFFIC(int NGOALOPPBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "19")]
	public void JHDPIOCGPEP(object GIHOLCNOBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "20")]
	public void ADCEJOBBCCM(object GIHOLCNOBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "21")]
	public void BGEFLKBGJJI(object GIHOLCNOBIB, bool EDMGPHLGIGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x3665FE0", Offset = "0x3664BE0", VA = "0x183665FE0", Slot = "22")]
	public IDisposable AACEDHKFLOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8E0", Offset = "0x6AC4E0", VA = "0x1806AD8E0", Slot = "23")]
	private bool ADKEONNIFIJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "24")]
	public void BMMMOGNLCKD(StringBuilder OODMNFJPDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x3666320", Offset = "0x3664F20", VA = "0x183666320", Slot = "25")]
	public bool HKPFOOKBLJN(bool MABCFCLFLMM, out string CHGFDAMICCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	public void AFPHMEMAIOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x185F540", Offset = "0x185E140", VA = "0x18185F540", Slot = "28")]
	public void CFJKPCOFIDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal struct JKHCJJCNCHN
{
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public const string ALOMFEEFAGI = "v_result";

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public const string JLIHOGPNJOF = "oid";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private readonly IDictionary<object, object> PGOAEBLMINI;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool BPOKJGMAKGF
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x92F040", Offset = "0x92DC40", VA = "0x18092F040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x695F00", Offset = "0x694B00", VA = "0x180695F00")]
	public JKHCJJCNCHN(IDictionary<object, object> PGOAEBLMINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x2CEDD20", Offset = "0x2CEC920", VA = "0x182CEDD20")]
	public bool BHPEDEJGEOL(out MAAKCJEMEIP DPNJMDFICMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x2CEE030", Offset = "0x2CECC30", VA = "0x182CEE030")]
	public Guid NJDPGPANOJK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x2CEDDE0", Offset = "0x2CEC9E0", VA = "0x182CEDDE0")]
	public ENHABCKLLMN LOFFDAGLOAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x2CEDF40", Offset = "0x2CECB40", VA = "0x182CEDF40")]
	public static ExitGames.Client.Photon.Hashtable NBONEDNFGGC(MAAKCJEMEIP DPNJMDFICMK, ENHABCKLLMN GCFAJIEGBJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class LBFCINLNMME
{
	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x365A9B0", Offset = "0x36595B0", VA = "0x18365A9B0")]
	public static string HHFLFPCICOK(this AIMCOPKLBGF AOONFFMDOBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x365AC00", Offset = "0x3659800", VA = "0x18365AC00")]
	public static bool NGGBODGCJFE(this AIMCOPKLBGF AOONFFMDOBB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal struct AJENNKMOMCG : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private struct BIFKNILAPHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public AJENNKMOMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x3652F70", Offset = "0x3651B70", VA = "0x183652F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private readonly CancellationTokenSource NAMBCJPDCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private bool JIGLPOGPBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private Task DJBOLOFCCDO;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool BPOKJGMAKGF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x2CD1B70", Offset = "0x2CD0770", VA = "0x182CD1B70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	internal Task CIOHIGDMPEA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x2CD1AA0", Offset = "0x2CD06A0", VA = "0x182CD1AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x2CD1CD0", Offset = "0x2CD08D0", VA = "0x182CD1CD0")]
	public AJENNKMOMCG(CancellationToken OKPCBPJCBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x2CD1BA0", Offset = "0x2CD07A0", VA = "0x182CD1BA0")]
	[AsyncStateMachine(typeof(BIFKNILAPHJ))]
	public Task KLOBLCPGMLA(Func<CancellationToken, List<Task>> DKBDPOPPCCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x2CD1B20", Offset = "0x2CD0720", VA = "0x182CD1B20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public readonly struct ALJJGNGHFHD<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private struct DOBAADHOAIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public AsyncTaskMethodBuilder<global::DGDFIFNFPJI<global::EIGLPCKODGO<TData>, DLGHCKKHLGP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public IFANLHMJJPA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public global::ALJJGNGHFHD<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private IFANLHMJJPA <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private TaskAwaiter<global::DGDFIFNFPJI<byte[], DLGHCKKHLGP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x2FCD0D0", Offset = "0x2FCBCD0", VA = "0x182FCD0D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x2BE7960", Offset = "0x2BE6560", VA = "0x182BE7960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	private readonly global::ELHLKJIIOLA<TGetDataArg, TData> KGBPPPCHNGO;

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x695F00", Offset = "0x694B00", VA = "0x180695F00")]
	internal ALJJGNGHFHD(global::ELHLKJIIOLA<TGetDataArg, TData> GCFJADAOFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x3469830", Offset = "0x3468430", VA = "0x183469830")]
	[AsyncStateMachine(typeof(global::ALJJGNGHFHD<, >.DOBAADHOAIP))]
	public Task<global::DGDFIFNFPJI<global::EIGLPCKODGO<TData>, DLGHCKKHLGP>> CIGFBINDOCI(TGetDataArg BHDBJANFJIF, string INDHGHNFOEE, IFANLHMJJPA KIACJFINHDJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public static class GFPELKAHHLA
{
	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x253CC90", Offset = "0x253B890", VA = "0x18253CC90")]
	public static global::ALJJGNGHFHD<TGetDataArg, TData> GADFBDMBHED<TGetDataArg, TData>(global::ELHLKJIIOLA<TGetDataArg, TData> GCFJADAOFIH)
	{
		return default(global::ALJJGNGHFHD<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public class FNONLEEMBIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private readonly ECHMDFAPDFJ MCOFADAPPHF;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private const string GHAOEJJNOPF = "RL_LastSetOperationState";

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private const string AFFEBPDEJDF = "RL_LastLoadedRoomName";

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private const string KJFPNFKHGBB = "RL_LastLoadedRoomId";

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	private const string CKNJDMKIGIA = "RL_LastLoadedSubroomId";

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private const string MGAPLPHFMNN = "RL_LastRoomLoadStartTime";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private string AHDKIMCBKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	private long? LMMAOOEGOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	private long? JOOJMJGNGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	private KLOAJMHCOJF DHHPGCNFECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private long? DCLLLPBDNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private bool HIDJGAGLHOA;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public string FDJECOEFHJK
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public long INGPBNMMAPB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x2CE1780", Offset = "0x2CE0380", VA = "0x182CE1780")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public long FEOHJCDEBAO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x2CE1E90", Offset = "0x2CE0A90", VA = "0x182CE1E90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public KLOAJMHCOJF PBEHDFIEDMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x68C750", Offset = "0x68B350", VA = "0x18068C750")]
		get
		{
			return default(KLOAJMHCOJF);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x2CE1690", Offset = "0x2CE0290", VA = "0x182CE1690")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public long EKPNBMDPGKM
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x2CE1D40", Offset = "0x2CE0940", VA = "0x182CE1D40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x2CE1EF0", Offset = "0x2CE0AF0", VA = "0x182CE1EF0")]
	[Preserve]
	public FNONLEEMBIA([MLOIHELMKFH(null)] ECHMDFAPDFJ MCOFADAPPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x2CE17E0", Offset = "0x2CE03E0", VA = "0x182CE17E0")]
	private void FBOAHHKOIDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x2CE1990", Offset = "0x2CE0590", VA = "0x182CE1990")]
	public void GINIIOOEOOM(long KLMDBCIHINB, long ONEELBLPKOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x2CE1DA0", Offset = "0x2CE09A0", VA = "0x182CE1DA0")]
	public void IEJJGHKEGPF(string OMHPKPLKDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x2CE13A0", Offset = "0x2CDFFA0", VA = "0x182CE13A0")]
	public void EGDPBBEEDHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal class CJABFHHEKHC : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct KEAIDLOHIGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public AsyncTaskMethodBuilder<MAAKCJEMEIP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public MAAKCJEMEIP roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public CJABFHHEKHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private IFANLHMJJPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private TaskAwaiter<KDLEJCDLFKE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x3658380", Offset = "0x3656F80", VA = "0x183658380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x3658690", Offset = "0x3657290", VA = "0x183658690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct NKFOGADIAMC<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private sealed class CKEOLICCHNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public MAAKCJEMEIP roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public CKEOLICCHNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x36536E0", Offset = "0x36522E0", VA = "0x1836536E0")]
		internal MAAKCJEMEIP <MasterSendAllReceiveBufferedMessage>b__0(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct IECKMKFAKJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public AsyncTaskMethodBuilder<KDLEJCDLFKE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public MAAKCJEMEIP roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public CJABFHHEKHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private ADLMHLPOFJH <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private TaskAwaiter<KDLEJCDLFKE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x3657420", Offset = "0x3656020", VA = "0x183657420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x3657BF0", Offset = "0x36567F0", VA = "0x183657BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct JNCEHEBAMJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public CJABFHHEKHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x3658220", Offset = "0x3656E20", VA = "0x183658220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[CompilerGenerated]
	private sealed class OFGAMCMJAGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public OFGAMCMJAGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x37FB4E0", Offset = "0x37FA0E0", VA = "0x1837FB4E0")]
		internal object <ClearOperationSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private sealed class BHDMKNDDHMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public BHDMKNDDHMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x3652F10", Offset = "0x3651B10", VA = "0x183652F10")]
		internal object <ClearRoomLoadSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private sealed class LGBGAHCCPDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public LGBGAHCCPDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x37F98A0", Offset = "0x37F84A0", VA = "0x1837F98A0")]
		internal object <StartRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[CompilerGenerated]
	private sealed class DOCLFDDHBIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public DOCLFDDHBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x3654950", Offset = "0x3653550", VA = "0x183654950")]
		internal object <FinishRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	[CompilerGenerated]
	private sealed class BCOAEAHOFGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public CJABFHHEKHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public BCOAEAHOFGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x3652C90", Offset = "0x3651890", VA = "0x183652C90")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[CompilerGenerated]
	private sealed class BMJKELGELKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public Func<string> stepMessageGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public CJABFHHEKHC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public BMJKELGELKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x36533D0", Offset = "0x3651FD0", VA = "0x1836533D0")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private static readonly Guid GLCGELKCFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public readonly KHCEKICDGEB FKGOGBFCDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private readonly AFCKFGFKPJC IJFIMPLLAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	private readonly NCBMGIHIGDO NKGCEELNNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	private readonly KBDJMOGKCNH KDHDLEPLEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private bool NJNFDFNOEPN;

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x2CD8DB0", Offset = "0x2CD79B0", VA = "0x182CD8DB0")]
	public CJABFHHEKHC(KHCEKICDGEB ECKBPFEGIAL, AFCKFGFKPJC IJFIMPLLAKC, NCBMGIHIGDO NKGCEELNNIP, KBDJMOGKCNH KDHDLEPLEHN, IFANLHMJJPA DHJIFBEMLMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x2CD7CE0", Offset = "0x2CD68E0", VA = "0x182CD7CE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x2CD7CE0", Offset = "0x2CD68E0", VA = "0x182CD7CE0")]
	public void BPOGDCBGMDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x2CD8850", Offset = "0x2CD7450", VA = "0x182CD8850")]
	public void PGENNGLDAJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x2CD84C0", Offset = "0x2CD70C0", VA = "0x182CD84C0")]
	public void LOACBMJDCHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x2CD86A0", Offset = "0x2CD72A0", VA = "0x182CD86A0")]
	[AsyncStateMachine(typeof(KEAIDLOHIGN))]
	internal Task<MAAKCJEMEIP> OKHHGKCJAIM(IFANLHMJJPA DHJIFBEMLMJ, MAAKCJEMEIP KDHBDCIFOHL, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x253A930", Offset = "0x2539530", VA = "0x18253A930")]
	private static byte[] NGMOMPMAHGK<T>(T DPNJMDFICMK) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x253A470", Offset = "0x2539070", VA = "0x18253A470")]
	private static T FNJEEMHHCMH<T>(MessageParser<T> OGKIPBBFPDM, byte[] DPNJMDFICMK, T BBIFELIGBKL) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x2CD8080", Offset = "0x2CD6C80", VA = "0x182CD8080")]
	[AsyncStateMachine(typeof(IECKMKFAKJP))]
	private Task<KDLEJCDLFKE> HEKMBLCLNGJ(MAAKCJEMEIP KDHBDCIFOHL, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x253A190", Offset = "0x2538D90", VA = "0x18253A190")]
	[AsyncStateMachine(typeof(NLDIMGLFMMK))]
	internal Task<T> BPKBILPOGDI<T>(CancellationToken CLLGBCLOIHL, Func<CancellationToken, Task<T>> PKIKELLGLNI, int EGKGECANAEN = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x2CD7B90", Offset = "0x2CD6790", VA = "0x182CD7B90")]
	[AsyncStateMachine(typeof(JNCEHEBAMJF))]
	internal Task BPKBILPOGDI(CancellationToken CLLGBCLOIHL, Func<CancellationToken, Task> PKIKELLGLNI, int EGKGECANAEN = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x2CD8610", Offset = "0x2CD7210", VA = "0x182CD8610")]
	public MAAKCJEMEIP LPIAJCCIFFC(ADLMHLPOFJH IBGHFAPLJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x2CD81E0", Offset = "0x2CD6DE0", VA = "0x182CD81E0")]
	public BOHGOKBCKCN JHFMIGKEBFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x2CD8010", Offset = "0x2CD6C10", VA = "0x182CD8010")]
	public JFKFFKDAJMN GKGMPPOCDFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x2CD7A50", Offset = "0x2CD6650", VA = "0x182CD7A50")]
	public FCNCPHHOOLO BOLBOFFJFIK([Optional] HAHPELENECE? MEJGJPMOALC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x2CD8820", Offset = "0x2CD7420", VA = "0x182CD8820")]
	public void ONMBPFMDAID(Func<Guid, bool> ELLFPNJNAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x2CD82E0", Offset = "0x2CD6EE0", VA = "0x182CD82E0")]
	public void LAAAMNJALGJ(Func<Guid, bool> IJMNPOIBMFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x2CD8BB0", Offset = "0x2CD77B0", VA = "0x182CD8BB0")]
	public void PPKFEKFPJDE(Func<Guid, bool> ELLFPNJNAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x2CD89A0", Offset = "0x2CD75A0", VA = "0x182CD89A0")]
	public Guid PKALAAFOAKJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x2CD7E80", Offset = "0x2CD6A80", VA = "0x182CD7E80")]
	public void FLPGCJAKKEC(Guid EBAMGGDFELK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x2CD7900", Offset = "0x2CD6500", VA = "0x182CD7900")]
	public void BFMDBCDJDEE(MAAKCJEMEIP AGABGNEKPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x2CD7600", Offset = "0x2CD6200", VA = "0x182CD7600")]
	public void AJGKFIDACMM(string NEJGMJDACDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x2CD7780", Offset = "0x2CD6380", VA = "0x182CD7780")]
	public void AJGKFIDACMM(Func<string> HIFJCLOKEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x253A0B0", Offset = "0x2538CB0", VA = "0x18253A0B0")]
	private T BICMOICAEJG<T>(T NENFOEKGNGK) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x2CD75B0", Offset = "0x2CD61B0", VA = "0x182CD75B0")]
	public void ADHFBMLAIMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x253A620", Offset = "0x2539220", VA = "0x18253A620")]
	[CompilerGenerated]
	internal static string KPEAPEFELMD<T>(byte[] FCLGIGIIKEH, int PNNJBPIFMMJ, ref NKFOGADIAMC<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
internal sealed class OJPOGINGDAL : KHCEKICDGEB
{
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private sealed class LPFKNDKIADK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public LPFKNDKIADK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x4487630", Offset = "0x4486230", VA = "0x184487630")]
		internal object <.ctor>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private struct IMMEMFJAAHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public OJPOGINGDAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public CJABFHHEKHC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private JFKFFKDAJMN <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x4485480", Offset = "0x4484080", VA = "0x184485480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private sealed class DNHCMAMDEPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public EFPGKMAIMMO presence;

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public DNHCMAMDEPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x4480C90", Offset = "0x447F890", VA = "0x184480C90")]
		internal object <GetLocalPlayerPresence>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private readonly PGGLGCLPJMP GGLIAHNLGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private readonly AIMCOPKLBGF EKGMNIPHIII;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private const bool IBCHJPIHFKH = false;

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x36644C0", Offset = "0x36630C0", VA = "0x1836644C0")]
	public OJPOGINGDAL(PGGLGCLPJMP GGLIAHNLGFB, AIMCOPKLBGF EKGMNIPHIII, Guid MJGBLGMCHFL, INMGAJCAIOM GFONEBKMLAH, CMFLPAKKNOD COJLFKBFJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x3664370", Offset = "0x3662F70", VA = "0x183664370", Slot = "8")]
	[AsyncStateMachine(typeof(IMMEMFJAAHD))]
	protected override Task BONMGLIEICN(CJABFHHEKHC PHCHEONAKAJ, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x3664130", Offset = "0x3662D30", VA = "0x183664130")]
	private EFPGKMAIMMO BIEGHENFEKA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
internal class KJEOBNMEEGA : KHCEKICDGEB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private struct FINBFOAFFAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public KJEOBNMEEGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public CJABFHHEKHC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private IFANLHMJJPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private TaskAwaiter<JMJKOKLCGPH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x4483040", Offset = "0x4481C40", VA = "0x184483040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private readonly int FPPALIGNJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private readonly KAMHGLCAIAM HFFNLDFGIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public readonly long LEOLCJLMIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public readonly long IMHOEIPFFBG;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public JMJKOKLCGPH JKGKKMOACEK
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x70BC60", Offset = "0x70A860", VA = "0x18070BC60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x7BB460", Offset = "0x7BA060", VA = "0x1807BB460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x3659230", Offset = "0x3657E30", VA = "0x183659230")]
	public KJEOBNMEEGA(Guid MJGBLGMCHFL, INMGAJCAIOM GFONEBKMLAH, CMFLPAKKNOD COJLFKBFJBI, int FPPALIGNJBP, KAMHGLCAIAM HFFNLDFGIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x36590F0", Offset = "0x3657CF0", VA = "0x1836590F0", Slot = "8")]
	[AsyncStateMachine(typeof(FINBFOAFFAB))]
	protected override Task BONMGLIEICN(CJABFHHEKHC PHCHEONAKAJ, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal abstract class LAGDMNPAJAD : KHCEKICDGEB
{
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private sealed class AGKBPIDCLAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public LAGDMNPAJAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public FJJGAIPOCOD playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public AGKBPIDCLAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x447DA40", Offset = "0x447C640", VA = "0x18447DA40")]
		internal Task <RunAsync>b__0(IFANLHMJJPA postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x447DA80", Offset = "0x447C680", VA = "0x18447DA80")]
		internal object <RunAsync>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private struct DKFOCDMBJJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public LAGDMNPAJAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public CJABFHHEKHC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private AGKBPIDCLAK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x4480570", Offset = "0x447F170", VA = "0x184480570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[CompilerGenerated]
	private struct AMAAJMDOFCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public IFANLHMJJPA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public FJJGAIPOCOD playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public LAGDMNPAJAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		private IFANLHMJJPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x447DB00", Offset = "0x447C700", VA = "0x18447DB00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x365A730", Offset = "0x3659330", VA = "0x18365A730")]
	public LAGDMNPAJAD(Guid MJGBLGMCHFL, INMGAJCAIOM GFONEBKMLAH, CMFLPAKKNOD COJLFKBFJBI, string DEAHNKCCKCF, LFEBHFOKPKN ALOINNFJFCL, bool KJMICKMBGFC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x365A480", Offset = "0x3659080", VA = "0x18365A480", Slot = "8")]
	[AsyncStateMachine(typeof(DKFOCDMBJJF))]
	protected override Task BONMGLIEICN(CJABFHHEKHC PHCHEONAKAJ, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract Task HAEPNCKAKIK(CJABFHHEKHC PHCHEONAKAJ, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ);

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x365A5D0", Offset = "0x36591D0", VA = "0x18365A5D0")]
	[AsyncStateMachine(typeof(AMAAJMDOFCE))]
	private Task PICHMPNFJPK(IDisposable HGIIOHNPBOM, FJJGAIPOCOD JPLNGAFPBJN, IFANLHMJJPA KIACJFINHDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
internal class BMKFPBCFABC : KHCEKICDGEB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct OCHLEHEOMJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public BMKFPBCFABC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public CJABFHHEKHC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		private TaskAwaiter<DJIHHMDOBME> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x3662040", Offset = "0x3660C40", VA = "0x183662040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private readonly KJGKHGGPEAN IKLNANFHOOO;

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x2CD53F0", Offset = "0x2CD3FF0", VA = "0x182CD53F0")]
	public BMKFPBCFABC(Guid MJGBLGMCHFL, INMGAJCAIOM GFONEBKMLAH, CMFLPAKKNOD COJLFKBFJBI, KJGKHGGPEAN IKLNANFHOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x2CD5310", Offset = "0x2CD3F10", VA = "0x182CD5310", Slot = "7")]
	protected override string NLKKGGJPLKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x2CD51D0", Offset = "0x2CD3DD0", VA = "0x182CD51D0", Slot = "8")]
	[AsyncStateMachine(typeof(OCHLEHEOMJJ))]
	protected override Task BONMGLIEICN(CJABFHHEKHC PHCHEONAKAJ, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal abstract class KHCEKICDGEB : AACCMMBHPBL
{
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public delegate Task FBFAHHKOOAM(IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ);

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class PFEGOCKKHPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public IFANLHMJJPA operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public KHCEKICDGEB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public PFEGOCKKHPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x4489B60", Offset = "0x4488760", VA = "0x184489B60")]
		internal Task <Run>b__1(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class BBKMLKKNDDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public PFEGOCKKHPE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public BBKMLKKNDDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x447DFC0", Offset = "0x447CBC0", VA = "0x18447DFC0")]
		internal object <Run>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x447E080", Offset = "0x447CC80", VA = "0x18447E080")]
		internal object <Run>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct CGAGFJKKMCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public KHCEKICDGEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public Func<KHCEKICDGEB, IFANLHMJJPA, CJABFHHEKHC> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private PFEGOCKKHPE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private CJABFHHEKHC <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		private TaskAwaiter<MAAKCJEMEIP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x447E940", Offset = "0x447D540", VA = "0x18447E940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private struct CMMHGDGMNPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public KHCEKICDGEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x447F890", Offset = "0x447E490", VA = "0x18447F890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public readonly Guid DMGANIDFKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public readonly ByteString DEHANPMHEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public readonly CMFLPAKKNOD BPMOGCIKOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	protected readonly string CCPGABNCFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	private readonly INMGAJCAIOM GFONEBKMLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000369")]
	private readonly bool KJMICKMBGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400036A")]
	private readonly Queue<FBFAHHKOOAM> FHDEHKBBLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400036B")]
	private readonly HJJEFEBIANJ MPPLOMOAGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400036C")]
	private readonly LFEBHFOKPKN ALOINNFJFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400036D")]
	private bool PMNCAKEFDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public KLOAJMHCOJF HKLFMCNLNMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public KLOAJMHCOJF NDJDHNGNHKE;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public INMGAJCAIOM GAKEKCMDGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x694E70", Offset = "0x693A70", VA = "0x180694E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public AHNPBEMNBDD NNDPCGNEDGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x36588B0", Offset = "0x36574B0", VA = "0x1836588B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public KJOIPNHICFJ JEJNDBAHFNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x3658700", Offset = "0x3657300", VA = "0x183658700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public ELNLIPPPCOB ODANIKCBFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x3658900", Offset = "0x3657500", VA = "0x183658900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public float CNCPBENEOFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x3658750", Offset = "0x3657350", VA = "0x183658750", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event AIGLFAGDEND HOPFJDHFPEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x36586E0", Offset = "0x36572E0", VA = "0x1836586E0", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x3658E20", Offset = "0x3657A20", VA = "0x183658E20", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x3658FB0", Offset = "0x3657BB0", VA = "0x183658FB0")]
	protected KHCEKICDGEB(Guid MJGBLGMCHFL, INMGAJCAIOM GFONEBKMLAH, CMFLPAKKNOD COJLFKBFJBI, string DEAHNKCCKCF, LFEBHFOKPKN ALOINNFJFCL, bool KJMICKMBGFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x3658DE0", Offset = "0x36579E0", VA = "0x183658DE0", Slot = "7")]
	protected virtual string NLKKGGJPLKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x3658F50", Offset = "0x3657B50", VA = "0x183658F50")]
	public void PPGPAOPCOHM(FBFAHHKOOAM BGPFNINLPEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x3658AD0", Offset = "0x36576D0", VA = "0x183658AD0")]
	protected void LFHALDHKBDL(float NMDDPCLMDNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x3658980", Offset = "0x3657580", VA = "0x183658980")]
	[AsyncStateMachine(typeof(CGAGFJKKMCO))]
	public Task LDJEMKIKHJD(CancellationToken OKPCBPJCBCJ, IFANLHMJJPA DHJIFBEMLMJ, [Optional] Func<KHCEKICDGEB, IFANLHMJJPA, CJABFHHEKHC> MHKDJKNBJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x3658B70", Offset = "0x3657770", VA = "0x183658B70")]
	private void MHNNLLDBOGL(bool NNDPMBNNLLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x3658E40", Offset = "0x3657A40", VA = "0x183658E40")]
	private void OPGGBNADIKN(CJABFHHEKHC PHCHEONAKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task BONMGLIEICN(CJABFHHEKHC PHCHEONAKAJ, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ);

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x3658770", Offset = "0x3657370", VA = "0x183658770")]
	[AsyncStateMachine(typeof(CMMHGDGMNPJ))]
	private Task HDHOMNAEGBL(IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x3658AF0", Offset = "0x36576F0", VA = "0x183658AF0")]
	public MAAKCJEMEIP LPIAJCCIFFC(ADLMHLPOFJH IBGHFAPLJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x3658D00", Offset = "0x3657900", VA = "0x183658D00")]
	[CompilerGenerated]
	private Task NEPJCNKINJD(CancellationToken KKEIOLMHDBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
internal sealed class JIKCJILFGOL : LAGDMNPAJAD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private struct KOLFKEJLIPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public JIKCJILFGOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public CJABFHHEKHC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		private KOBJCIBGGPL <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		private JFKFFKDAJMN <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x4487040", Offset = "0x4485C40", VA = "0x184487040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000386")]
	private readonly PGGLGCLPJMP GDPIKLPIMBC;

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x2CEDC70", Offset = "0x2CEC870", VA = "0x182CEDC70")]
	public JIKCJILFGOL(Guid MJGBLGMCHFL, INMGAJCAIOM GFONEBKMLAH, PGGLGCLPJMP GDPIKLPIMBC, CMFLPAKKNOD COJLFKBFJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x2CEDB20", Offset = "0x2CEC720", VA = "0x182CEDB20", Slot = "9")]
	[AsyncStateMachine(typeof(KOLFKEJLIPB))]
	protected override Task HAEPNCKAKIK(CJABFHHEKHC PHCHEONAKAJ, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
internal class BHIAKEBMNLI : KHCEKICDGEB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private struct GMFJBIHGKKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public BHIAKEBMNLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public CJABFHHEKHC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private TaskAwaiter<DJIHHMDOBME> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x3656290", Offset = "0x3654E90", VA = "0x183656290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000390")]
	private readonly string OLNEHPOBAJL;

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x2CD4030", Offset = "0x2CD2C30", VA = "0x182CD4030")]
	public BHIAKEBMNLI(Guid MJGBLGMCHFL, INMGAJCAIOM GFONEBKMLAH, CMFLPAKKNOD COJLFKBFJBI, string OLNEHPOBAJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x2CD3F00", Offset = "0x2CD2B00", VA = "0x182CD3F00", Slot = "8")]
	[AsyncStateMachine(typeof(GMFJBIHGKKM))]
	protected override Task BONMGLIEICN(CJABFHHEKHC PHCHEONAKAJ, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
internal class IPLMPAIBHDN : LAGDMNPAJAD
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class FMCHMOKHGFG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000FD")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			public AsyncTaskMethodBuilder<MAAKCJEMEIP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public FMCHMOKHGFG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			private TaskAwaiter<DJIHHMDOBME> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			private TaskAwaiter<MAAKCJEMEIP> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0x448CB60", Offset = "0x448B760", VA = "0x18448CB60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0x448CEB0", Offset = "0x448BAB0", VA = "0x18448CEB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public IPLMPAIBHDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public FCNCPHHOOLO serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public BOHGOKBCKCN uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public FMCHMOKHGFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x37F08E0", Offset = "0x37EF4E0", VA = "0x1837F08E0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<MAAKCJEMEIP> <RunWhilePlayerDespawnedAsync>b__0(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private struct DBOGCIEFECB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public IPLMPAIBHDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public CJABFHHEKHC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private FMCHMOKHGFG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private KOBJCIBGGPL <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private JFKFFKDAJMN <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private TaskAwaiter<MAAKCJEMEIP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x37EC410", Offset = "0x37EB010", VA = "0x1837EC410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000397")]
	private readonly int DHOLEBLBBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000398")]
	[CanBeNull]
	private readonly OMDELFIKCOM ALNFALLNAOJ;

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB970", Offset = "0x2CEA570", VA = "0x182CEB970")]
	public IPLMPAIBHDN(Guid MJGBLGMCHFL, INMGAJCAIOM GFONEBKMLAH, int DHOLEBLBBOC, OMDELFIKCOM ALNFALLNAOJ, CMFLPAKKNOD COJLFKBFJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB720", Offset = "0x2CEA320", VA = "0x182CEB720", Slot = "9")]
	[AsyncStateMachine(typeof(DBOGCIEFECB))]
	protected override Task HAEPNCKAKIK(CJABFHHEKHC PHCHEONAKAJ, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB880", Offset = "0x2CEA480", VA = "0x182CEB880")]
	private void KKFIHOKAHHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB580", Offset = "0x2CEA180", VA = "0x182CEB580")]
	private void BACMIOHOMJA(IFANLHMJJPA DHJIFBEMLMJ, KOBJCIBGGPL EDBLIFGMKAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
internal abstract class EOPFPCCCFDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public readonly KHCEKICDGEB FKGOGBFCDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public readonly CJABFHHEKHC NLJOECHDDCD;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public AHNPBEMNBDD NNDPCGNEDGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC6D0", Offset = "0x2CDB2D0", VA = "0x182CDC6D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public ELNLIPPPCOB ODANIKCBFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC6F0", Offset = "0x2CDB2F0", VA = "0x182CDC6F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x2CDC750", Offset = "0x2CDB350", VA = "0x182CDC750")]
	protected EOPFPCCCFDH(CJABFHHEKHC PHCHEONAKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x2CDC520", Offset = "0x2CDB120", VA = "0x182CDC520")]
	protected void AJGKFIDACMM(string NEJGMJDACDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x2CDC540", Offset = "0x2CDB140", VA = "0x182CDC540")]
	public void AJGKFIDACMM(Func<string> HIFJCLOKEMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
internal struct JKIGCPLBFCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public Dictionary<Guid, List<LLGKCODFPOG>> JEKIIJNMPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public Dictionary<Guid, List<LLGKCODFPOG>> AENFMBPFIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public Dictionary<Guid, List<LLGKCODFPOG>> KBJGKFGELGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public List<Guid> DHJHPHMDLFH;

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x2CEE110", Offset = "0x2CECD10", VA = "0x182CEE110")]
	public static JKIGCPLBFCI FABELHKIKFB(AHNPBEMNBDD OPBBALMJDDI, KLOAJMHCOJF NONCDNOEOAP, MMBJADMOHGP OLKDPBHNDDI)
	{
		return default(JKIGCPLBFCI);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000102")]
internal struct EHPDLLLMFKF
{
	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8E0", Offset = "0x6AC4E0", VA = "0x1806AD8E0")]
	public static EHPDLLLMFKF NBONEDNFGGC()
	{
		return default(EHPDLLLMFKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void JOFJNDOCKOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void DNNLBPOEFAM(MMBJADMOHGP GAGLKGONONJ, object CKANKMGFDMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void FDFHPCCKHGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
internal struct CPDJMCBJMIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public readonly OFPAILNJPLH LDIGOIDIFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public readonly MKEIKAGIGLF HNNMJOFIGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public readonly EFNIPIEHPND ANIJOKOMPIB;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA6C0", Offset = "0x2CD92C0", VA = "0x182CDA6C0")]
	public CPDJMCBJMIL(OFPAILNJPLH LDIGOIDIFIL, MKEIKAGIGLF HNNMJOFIGDH, EFNIPIEHPND ANIJOKOMPIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal struct LEDIFLLHCLL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	private readonly CJABFHHEKHC PHCHEONAKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	private readonly Guid EBAMGGDFELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	private bool NNDPMBNNLLL;

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x365AD90", Offset = "0x3659990", VA = "0x18365AD90")]
	public static LEDIFLLHCLL PKALAAFOAKJ(CJABFHHEKHC PHCHEONAKAJ)
	{
		return default(LEDIFLLHCLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0xC67230", Offset = "0xC65E30", VA = "0x180C67230")]
	public void CEBPIABJKHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x365AC80", Offset = "0x3659880", VA = "0x18365AC80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x365ADF0", Offset = "0x36599F0", VA = "0x18365ADF0")]
	private LEDIFLLHCLL(CJABFHHEKHC PHCHEONAKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x365AC80", Offset = "0x3659880", VA = "0x18365AC80")]
	private void FLPGCJAKKEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x365ACE0", Offset = "0x36598E0", VA = "0x18365ACE0")]
	private Func<Guid, bool> EPOOHIBHICH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
internal class JFKFFKDAJMN : EOPFPCCCFDH, AACCMMBHPBL
{
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public delegate Task<KLOAJMHCOJF> OOOIOOAKFMO(MMBJADMOHGP GAGLKGONONJ, ODBFEHEDEIH FMAPHKFOMGB, HJJEFEBIANJ NNDHFKDGLFI, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private struct GKHAOJEHCCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public JFKFFKDAJMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public PGGLGCLPJMP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public bool isInitialLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private LEDIFLLHCLL <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private TaskAwaiter<MAAKCJEMEIP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x37F31D0", Offset = "0x37F1DD0", VA = "0x1837F31D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private struct GBDJOCHHHOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public AsyncTaskMethodBuilder<MAAKCJEMEIP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public JFKFFKDAJMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public PGGLGCLPJMP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		private IFANLHMJJPA <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		private TaskAwaiter<MAAKCJEMEIP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x37F17A0", Offset = "0x37F03A0", VA = "0x1837F17A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x37F1AC0", Offset = "0x37F06C0", VA = "0x1837F1AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private struct CJGEHNHAODN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public JFKFFKDAJMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public PGGLGCLPJMP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public bool isInitialLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private IFANLHMJJPA <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x37EBB70", Offset = "0x37EA770", VA = "0x1837EBB70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private sealed class MFFFOHPCNGC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010B")]
		private struct <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public AsyncTaskMethodBuilder<CPDJMCBJMIL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			public MFFFOHPCNGC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			private CPDJMCBJMIL <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			private TaskAwaiter<KLOAJMHCOJF> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			private TaskAwaiter<CPDJMCBJMIL> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x448B8B0", Offset = "0x448A4B0", VA = "0x18448B8B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0x448BEC0", Offset = "0x448AAC0", VA = "0x18448BEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010C")]
		private struct <<LoadRoomLocal>b__4>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public AsyncTaskMethodBuilder<MMBJADMOHGP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			public MFFFOHPCNGC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			private MMBJADMOHGP <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			private TaskAwaiter<KLOAJMHCOJF> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			private TaskAwaiter<MMBJADMOHGP> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0x448BF10", Offset = "0x448AB10", VA = "0x18448BF10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0x448C440", Offset = "0x448B040", VA = "0x18448C440", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010D")]
		private struct <<LoadRoomLocal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			public MFFFOHPCNGC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003FD")]
			private bool <reloadSceneForObjectModel>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003FE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			private TaskAwaiter<KLOAJMHCOJF> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			private ODBFEHEDEIH <timedYielder>5__3;

			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0x448A480", Offset = "0x4489080", VA = "0x18448A480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public JFKFFKDAJMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public PGGLGCLPJMP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public HJJEFEBIANJ preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public HJJEFEBIANJ downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public CPDJMCBJMIL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public HJJEFEBIANJ postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public MMBJADMOHGP phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public bool isInitialLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public GFPNMHNEIAH.JBIDBHLOOJE <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public MFFFOHPCNGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x4487830", Offset = "0x4486430", VA = "0x184487830")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<CPDJMCBJMIL> <LoadRoomLocal>b__2(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x4487970", Offset = "0x4486570", VA = "0x184487970")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<MMBJADMOHGP> <LoadRoomLocal>b__4(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x4487AB0", Offset = "0x44866B0", VA = "0x184487AB0")]
		internal void <LoadRoomLocal>b__6(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x4487700", Offset = "0x4486300", VA = "0x184487700")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task <LoadRoomLocal>b__0(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct EPANIBCGCJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public JFKFFKDAJMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public PGGLGCLPJMP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public bool isInitialLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		private MFFFOHPCNGC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private TaskAwaiter<CPDJMCBJMIL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private TaskAwaiter<MMBJADMOHGP> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x37EE5C0", Offset = "0x37ED1C0", VA = "0x1837EE5C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct IKBFFIPJDPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public JFKFFKDAJMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public IFANLHMJJPA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x37F6A40", Offset = "0x37F5640", VA = "0x1837F6A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct GLJLCAJFFOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public JFKFFKDAJMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public MMBJADMOHGP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public HJJEFEBIANJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private IFANLHMJJPA <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private TaskAwaiter<KLOAJMHCOJF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x37F3560", Offset = "0x37F2160", VA = "0x1837F3560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private struct INJDGOOLIKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public AsyncTaskMethodBuilder<KLOAJMHCOJF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public JFKFFKDAJMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public MMBJADMOHGP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public HJJEFEBIANJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private IFANLHMJJPA <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private TaskAwaiter<KLOAJMHCOJF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x37F7210", Offset = "0x37F5E10", VA = "0x1837F7210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x37F7CB0", Offset = "0x37F68B0", VA = "0x1837F7CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct GFJDLAIJJCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public AsyncTaskMethodBuilder<KLOAJMHCOJF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public JFKFFKDAJMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public MMBJADMOHGP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public HJJEFEBIANJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public ODBFEHEDEIH timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private IFANLHMJJPA <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		private TaskAwaiter<KLOAJMHCOJF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x37F1BE0", Offset = "0x37F07E0", VA = "0x1837F1BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x37F2790", Offset = "0x37F1390", VA = "0x1837F2790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct DNFAPMADDGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public AsyncTaskMethodBuilder<KLOAJMHCOJF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public JFKFFKDAJMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public KLOAJMHCOJF operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public HJJEFEBIANJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public MMBJADMOHGP deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private TaskAwaiter<KLOAJMHCOJF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x37EDCC0", Offset = "0x37EC8C0", VA = "0x1837EDCC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x37EDEC0", Offset = "0x37ECAC0", VA = "0x1837EDEC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private sealed class DCKPABAAENJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000116")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			public AsyncTaskMethodBuilder<KLOAJMHCOJF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public DCKPABAAENJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			private TaskAwaiter<KLOAJMHCOJF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004D4")]
			[Cpp2IlInjected.Address(RVA = "0x448C490", Offset = "0x448B090", VA = "0x18448C490", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0x448C9D0", Offset = "0x448B5D0", VA = "0x18448C9D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public JFKFFKDAJMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public MMBJADMOHGP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public HJJEFEBIANJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public OOOIOOAKFMO masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public ODBFEHEDEIH timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public KLOAJMHCOJF originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public DCKPABAAENJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x37ECEC0", Offset = "0x37EBAC0", VA = "0x1837ECEC0")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<KLOAJMHCOJF> <MasterLockedPhaseChangeBlock>b__0(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private struct FEOCFMOKOAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public AsyncTaskMethodBuilder<KLOAJMHCOJF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public JFKFFKDAJMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public MMBJADMOHGP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public HJJEFEBIANJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public OOOIOOAKFMO masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public ODBFEHEDEIH timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private TaskAwaiter<KLOAJMHCOJF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x37EFEA0", Offset = "0x37EEAA0", VA = "0x1837EFEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x37F0340", Offset = "0x37EEF40", VA = "0x1837F0340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private struct MLBBEDALOPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public JFKFFKDAJMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public MMBJADMOHGP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public HJJEFEBIANJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private KLOAJMHCOJF <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private IEnumerator<KLOAJMHCOJF> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private TaskAwaiter<KLOAJMHCOJF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x4487AF0", Offset = "0x44866F0", VA = "0x184487AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct NDNLPBMLFKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public JFKFFKDAJMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public MMBJADMOHGP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x4487F30", Offset = "0x4486B30", VA = "0x184487F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct FCCLFNGFHGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public INMGAJCAIOM roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public MMBJADMOHGP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x37EF760", Offset = "0x37EE360", VA = "0x1837EF760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private struct HMJFCIBOGCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public JFKFFKDAJMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public MMBJADMOHGP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x37F4F60", Offset = "0x37F3B60", VA = "0x1837F4F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private sealed class AJJCMDPOFFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public OFPAILNJPLH roomDetails;

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public AJJCMDPOFFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x37E9CA0", Offset = "0x37E88A0", VA = "0x1837E9CA0")]
		internal object <LogRoomDetails>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	private readonly ALINNECOEFE OPIMPJHBBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	private readonly ALINNECOEFE LKKEOHDAGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	private readonly FNONLEEMBIA GFEIODEDCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	private readonly BLPGEOLAGBI KJEMDPBOECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	private readonly EJMODGHJGFA HONPMCFKADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	private readonly MOBDJEKJCIH FCHJHBEHLEJ;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float CNCPBENEOFE
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x2CEC230", Offset = "0x2CEAE30", VA = "0x182CEC230", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private INMGAJCAIOM GAKEKCMDGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x2CD6150", Offset = "0x2CD4D50", VA = "0x182CD6150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event AIGLFAGDEND HOPFJDHFPEL
	{
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x2CEBC50", Offset = "0x2CEA850", VA = "0x182CEBC50", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x2CED600", Offset = "0x2CEC200", VA = "0x182CED600", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x2CED8E0", Offset = "0x2CEC4E0", VA = "0x182CED8E0")]
	public JFKFFKDAJMN(CJABFHHEKHC PHCHEONAKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x2CEBE10", Offset = "0x2CEAA10", VA = "0x182CEBE10")]
	[AsyncStateMachine(typeof(GKHAOJEHCCL))]
	public Task BJEGCELLMJG(PGGLGCLPJMP PJCBPMCBLEN, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ, bool MNNPMDGEACA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x2CED330", Offset = "0x2CEBF30", VA = "0x182CED330")]
	[AsyncStateMachine(typeof(GBDJOCHHHOM))]
	private Task<MAAKCJEMEIP> MHBDFLLNDAC(PGGLGCLPJMP PJCBPMCBLEN, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x2CEC850", Offset = "0x2CEB450", VA = "0x182CEC850")]
	[AsyncStateMachine(typeof(CJGEHNHAODN))]
	private Task IIICFJAALLG(PGGLGCLPJMP PJCBPMCBLEN, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ, bool MNNPMDGEACA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x2CEC0A0", Offset = "0x2CEACA0", VA = "0x182CEC0A0")]
	[AsyncStateMachine(typeof(EPANIBCGCJF))]
	private Task CBBKBGHMFLD(PGGLGCLPJMP PJCBPMCBLEN, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken IMFHLILMMNN, bool MNNPMDGEACA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x2CEBF70", Offset = "0x2CEAB70", VA = "0x182CEBF70")]
	[AsyncStateMachine(typeof(IKBFFIPJDPG))]
	private Task BJPIPDFHJIN(IFANLHMJJPA KIACJFINHDJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x2CECEF0", Offset = "0x2CEBAF0", VA = "0x182CECEF0")]
	[AsyncStateMachine(typeof(GLJLCAJFFOG))]
	private Task LCFCENOKPOF(MMBJADMOHGP GAGLKGONONJ, HJJEFEBIANJ NNDHFKDGLFI, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x2CED050", Offset = "0x2CEBC50", VA = "0x182CED050")]
	[AsyncStateMachine(typeof(INJDGOOLIKF))]
	private Task<KLOAJMHCOJF> LKMENJPDLPC(MMBJADMOHGP GAGLKGONONJ, ODBFEHEDEIH AEDIFBBHMJN, HJJEFEBIANJ NNDHFKDGLFI, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x2CEC430", Offset = "0x2CEB030", VA = "0x182CEC430")]
	[AsyncStateMachine(typeof(GFJDLAIJJCF))]
	private Task<KLOAJMHCOJF> GEDNDDEKAFD(MMBJADMOHGP GAGLKGONONJ, ODBFEHEDEIH AEDIFBBHMJN, HJJEFEBIANJ NNDHFKDGLFI, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x2CEC2A0", Offset = "0x2CEAEA0", VA = "0x182CEC2A0")]
	[AsyncStateMachine(typeof(DNFAPMADDGL))]
	private Task<KLOAJMHCOJF> FBNFCOCGMKA(KLOAJMHCOJF NONCDNOEOAP, MMBJADMOHGP OLKDPBHNDDI, HJJEFEBIANJ NNDHFKDGLFI, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ, bool JIDLHBOMPMB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x2CED7B0", Offset = "0x2CEC3B0", VA = "0x182CED7B0")]
	private bool POFKDGIFJIO(MMBJADMOHGP IPAJCBCFHDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x2CEC6A0", Offset = "0x2CEB2A0", VA = "0x182CEC6A0")]
	[AsyncStateMachine(typeof(FEOCFMOKOAO))]
	protected Task<KLOAJMHCOJF> IEIKMIFLNHH(MMBJADMOHGP GAGLKGONONJ, ODBFEHEDEIH AEDIFBBHMJN, HJJEFEBIANJ NNDHFKDGLFI, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ, OOOIOOAKFMO KLKIMLGLACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x2CEC9B0", Offset = "0x2CEB5B0", VA = "0x182CEC9B0")]
	[AsyncStateMachine(typeof(MLBBEDALOPL))]
	private Task IIJACKJNGKN(MMBJADMOHGP GAGLKGONONJ, HJJEFEBIANJ NNDHFKDGLFI, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x2CEC5F0", Offset = "0x2CEB1F0", VA = "0x182CEC5F0")]
	private void GPBCGGPJEIP(KLOAJMHCOJF LEMFPIGLCJA, HJJEFEBIANJ NNDHFKDGLFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x2CED620", Offset = "0x2CEC220", VA = "0x182CED620")]
	private void OKDFPJFMMKH(KLOAJMHCOJF FNLPDBJOFGC, out KLOAJMHCOJF LFEEMCFDLMK, out KLOAJMHCOJF KBFAFKPNKJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x2CEC660", Offset = "0x2CEB260", VA = "0x182CEC660")]
	private Task<CPDJMCBJMIL> IBKJKHONGEM(PGGLGCLPJMP PJCBPMCBLEN, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x2CEC250", Offset = "0x2CEAE50", VA = "0x182CEC250")]
	private Task<MMBJADMOHGP> EFNCNGALDKA(PGGLGCLPJMP PJCBPMCBLEN, CPDJMCBJMIL GAGLKGONONJ, GFPNMHNEIAH.JBIDBHLOOJE DDIOPANOHAI, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x2CECC30", Offset = "0x2CEB830", VA = "0x182CECC30")]
	[AsyncStateMachine(typeof(NDNLPBMLFKM))]
	private Task JHILPDABMGL(MMBJADMOHGP GAGLKGONONJ, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x2CED4B0", Offset = "0x2CEC0B0", VA = "0x182CED4B0")]
	[AsyncStateMachine(typeof(FCCLFNGFHGG))]
	private Task NICOMOIBLJL(MMBJADMOHGP GAGLKGONONJ, INMGAJCAIOM GFONEBKMLAH, IFANLHMJJPA DHJIFBEMLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x2CECB10", Offset = "0x2CEB710", VA = "0x182CECB10")]
	[AsyncStateMachine(typeof(HMJFCIBOGCJ))]
	private Task JFHCCPMCOBO(MMBJADMOHGP GAGLKGONONJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x2CEBDE0", Offset = "0x2CEA9E0", VA = "0x182CEBDE0")]
	private Task AMAKFIMKEMB(MMBJADMOHGP GAGLKGONONJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x2CED1D0", Offset = "0x2CEBDD0", VA = "0x182CED1D0")]
	private Task LNFPJCMDFJN(MMBJADMOHGP GAGLKGONONJ, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x2CEC640", Offset = "0x2CEB240", VA = "0x182CEC640")]
	private Task HMHCCMCABDD(MMBJADMOHGP GAGLKGONONJ, ODBFEHEDEIH AEDIFBBHMJN, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x2CEBC70", Offset = "0x2CEA870", VA = "0x182CEBC70")]
	private Task AILKPMFHFOL(MMBJADMOHGP GAGLKGONONJ, ODBFEHEDEIH AEDIFBBHMJN, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x2CECD80", Offset = "0x2CEB980", VA = "0x182CECD80")]
	private static Task KHIGBKHJDIK(CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x2CEC5D0", Offset = "0x2CEB1D0", VA = "0x182CEC5D0")]
	private Task GOEAOJFIJEA(MMBJADMOHGP GAGLKGONONJ, ODBFEHEDEIH AEDIFBBHMJN, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x2CED660", Offset = "0x2CEC260", VA = "0x182CED660")]
	private Task OMBGHALPEPM(MMBJADMOHGP GAGLKGONONJ, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x2CEC200", Offset = "0x2CEAE00", VA = "0x182CEC200")]
	private void CMIAPGPOJIG(PGGLGCLPJMP PJCBPMCBLEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x2CECD90", Offset = "0x2CEB990", VA = "0x182CECD90")]
	private static void KIHADLKIMKF(OFPAILNJPLH LDIGOIDIFIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
internal struct IDJLOJNICIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000475")]
	private INMGAJCAIOM GFONEBKMLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000476")]
	private KLOAJMHCOJF LEMFPIGLCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000477")]
	private MMBJADMOHGP GAGLKGONONJ;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private AHNPBEMNBDD NNDPCGNEDGC
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x2CE5430", Offset = "0x2CE4030", VA = "0x182CE5430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private ELNLIPPPCOB ODANIKCBFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x2CE5480", Offset = "0x2CE4080", VA = "0x182CE5480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x2CE5500", Offset = "0x2CE4100", VA = "0x182CE5500")]
	public static Task LDJEMKIKHJD(INMGAJCAIOM GFONEBKMLAH, KLOAJMHCOJF LEMFPIGLCJA, MMBJADMOHGP GAGLKGONONJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x2CE55B0", Offset = "0x2CE41B0", VA = "0x182CE55B0")]
	private void LDJEMKIKHJD()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal struct KKLCDDCLANJ
{
	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x3659780", Offset = "0x3658380", VA = "0x183659780")]
	public static Task LDJEMKIKHJD(CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal struct JKNBMBFHFOE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private struct DEEIOEIDIBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public CJABFHHEKHC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public MMBJADMOHGP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private IFANLHMJJPA <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x4480000", Offset = "0x447EC00", VA = "0x184480000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x2CEED30", Offset = "0x2CED930", VA = "0x182CEED30")]
	[AsyncStateMachine(typeof(DEEIOEIDIBL))]
	public static Task LDJEMKIKHJD(CJABFHHEKHC PHCHEONAKAJ, MMBJADMOHGP GAGLKGONONJ, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal struct EHOBFFCOGHI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private struct BLBAIILMOHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public CJABFHHEKHC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public MMBJADMOHGP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public ODBFEHEDEIH timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private KLOAJMHCOJF <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private INMGAJCAIOM <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		private AHNPBEMNBDD <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		private List<(PersistenceView, CFFAMHPODII)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private CFFAMHPODII <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x37EA6C0", Offset = "0x37E92C0", VA = "0x1837EA6C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x2CDBD70", Offset = "0x2CDA970", VA = "0x182CDBD70")]
	[AsyncStateMachine(typeof(BLBAIILMOHC))]
	public static Task LDJEMKIKHJD(CJABFHHEKHC PHCHEONAKAJ, MMBJADMOHGP GAGLKGONONJ, ODBFEHEDEIH AEDIFBBHMJN, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x2CDBB00", Offset = "0x2CDA700", VA = "0x182CDBB00")]
	private static void EFEJCMIIKOL(PersistenceView ENAFFFEEEOK, CFFAMHPODII CKANKMGFDMC, MMBJADMOHGP GAGLKGONONJ, KLOAJMHCOJF NONCDNOEOAP, bool CFHMIFOIPBI)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000124")]
internal struct EOGGHBFIEOH
{
	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x2CDC2A0", Offset = "0x2CDAEA0", VA = "0x182CDC2A0")]
	public static Task LDJEMKIKHJD(INMGAJCAIOM GFONEBKMLAH, MMBJADMOHGP GAGLKGONONJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
internal struct BGBLCCHNNII
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct PINDGCAIDOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public INMGAJCAIOM roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public MMBJADMOHGP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public CJABFHHEKHC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x3668400", Offset = "0x3667000", VA = "0x183668400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct EMBPCKBBIEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public BGBLCCHNNII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private TaskAwaiter<MAAKCJEMEIP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x3654AE0", Offset = "0x36536E0", VA = "0x183654AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private sealed class MPKLDPPPCEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public ALPEFALFPBN version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public MPKLDPPPCEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x365F520", Offset = "0x365E120", VA = "0x18365F520")]
		internal object <DestroyActivePersistenceViews>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x365F600", Offset = "0x365E200", VA = "0x18365F600")]
		internal object <DestroyActivePersistenceViews>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	private INMGAJCAIOM GFONEBKMLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	private MMBJADMOHGP GAGLKGONONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	private CJABFHHEKHC PHCHEONAKAJ;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	private static readonly ByteString IOHDBMFJFOL;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private AHNPBEMNBDD NNDPCGNEDGC
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x2CD3B10", Offset = "0x2CD2710", VA = "0x182CD3B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private ELNLIPPPCOB ODANIKCBFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x2CD3B60", Offset = "0x2CD2760", VA = "0x182CD3B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x2CD3D20", Offset = "0x2CD2920", VA = "0x182CD3D20")]
	[AsyncStateMachine(typeof(PINDGCAIDOJ))]
	public static Task LDJEMKIKHJD(INMGAJCAIOM GFONEBKMLAH, KLOAJMHCOJF LEMFPIGLCJA, MMBJADMOHGP GAGLKGONONJ, CJABFHHEKHC PHCHEONAKAJ, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x2CD3BE0", Offset = "0x2CD27E0", VA = "0x182CD3BE0")]
	[AsyncStateMachine(typeof(EMBPCKBBIEH))]
	private Task LDJEMKIKHJD(IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x2CD3470", Offset = "0x2CD2070", VA = "0x182CD3470")]
	private void HHEBBHIKMFG([NotNull] HNMNGPNPECE CNFINMGFNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x2CD3440", Offset = "0x2CD2040", VA = "0x182CD3440")]
	private bool FNEOFEMCODF(ALPEFALFPBN OLOLCGEOMNE, HNMNGPNPECE CNFINMGFNPM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
internal struct CLHBOMAIIDN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct DLLECBGMHBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public AsyncTaskMethodBuilder<MMBJADMOHGP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public CLHBOMAIIDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public GFPNMHNEIAH.JBIDBHLOOJE downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private IFANLHMJJPA <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private TaskAwaiter<(global::DGDFIFNFPJI<EOGEGPEPLGA, DLGHCKKHLGP>, global::DGDFIFNFPJI<global::EIGLPCKODGO<HNMNGPNPECE>, DLGHCKKHLGP>, global::DGDFIFNFPJI<global::EIGLPCKODGO<FLBFNPAMJHJ>, DLGHCKKHLGP>, global::DGDFIFNFPJI<global::EIGLPCKODGO<LLNEIMOAMNN>, DLGHCKKHLGP>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x37ED3B0", Offset = "0x37EBFB0", VA = "0x1837ED3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x37EDC70", Offset = "0x37EC870", VA = "0x1837EDC70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct AHIIBCBEHKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public AsyncTaskMethodBuilder<global::DGDFIFNFPJI<EOGEGPEPLGA, DLGHCKKHLGP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public IFANLHMJJPA downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public CLHBOMAIIDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public GFPNMHNEIAH.JBIDBHLOOJE downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private IFANLHMJJPA <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private TaskAwaiter<global::DGDFIFNFPJI<EOGEGPEPLGA, DLGHCKKHLGP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x37E9240", Offset = "0x37E7E40", VA = "0x1837E9240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x37E9730", Offset = "0x37E8330", VA = "0x1837E9730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	private global::ALJJGNGHFHD<HDLEMCDEJDD, FLBFNPAMJHJ> LKOIAJDDEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	private global::ALJJGNGHFHD<HDLEMCDEJDD, HNMNGPNPECE> HNNMJOFIGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	private global::ALJJGNGHFHD<long, LLNEIMOAMNN> HJGAPIHEHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	private GJGFOEBPFMM AAGFOCHMGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	private PGGLGCLPJMP PJCBPMCBLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	private OFPAILNJPLH LDIGOIDIFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	private MKEIKAGIGLF IJFPIBBHFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	private long DKGNBCMFBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	private IFANLHMJJPA KIACJFINHDJ;

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x2CD91C0", Offset = "0x2CD7DC0", VA = "0x182CD91C0")]
	public static Task<MMBJADMOHGP> KIHHHMICNPG(INMGAJCAIOM GFONEBKMLAH, PGGLGCLPJMP PJCBPMCBLEN, in CPDJMCBJMIL GAGLKGONONJ, GFPNMHNEIAH.JBIDBHLOOJE DDIOPANOHAI, IFANLHMJJPA KIACJFINHDJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x2CD94E0", Offset = "0x2CD80E0", VA = "0x182CD94E0")]
	[AsyncStateMachine(typeof(DLLECBGMHBC))]
	private Task<MMBJADMOHGP> LDJEMKIKHJD(GFPNMHNEIAH.JBIDBHLOOJE DDIOPANOHAI, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x2CD9180", Offset = "0x2CD7D80", VA = "0x182CD9180")]
	private HDLEMCDEJDD ENBHIILOAJE(NFOPFCDLIEC LBFCJBGOKPF)
	{
		return default(HDLEMCDEJDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x2CD8FD0", Offset = "0x2CD7BD0", VA = "0x182CD8FD0")]
	[AsyncStateMachine(typeof(AHIIBCBEHKC))]
	private Task<global::DGDFIFNFPJI<EOGEGPEPLGA, DLGHCKKHLGP>> EAJCIIDJADI(string MLNFDJPEMCC, long DKGNBCMFBFJ, GFPNMHNEIAH.JBIDBHLOOJE DDIOPANOHAI, IFANLHMJJPA JEHICCGJAJJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
internal struct FLDBMEFOKMI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct LFBHLMCPGDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public AsyncTaskMethodBuilder<CPDJMCBJMIL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public FLDBMEFOKMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private IFANLHMJJPA <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private TaskAwaiter<CPDJMCBJMIL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x37F90F0", Offset = "0x37F7CF0", VA = "0x1837F90F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x37F95A0", Offset = "0x37F81A0", VA = "0x1837F95A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct EMDCIDLHELF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public AsyncTaskMethodBuilder<CPDJMCBJMIL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public FLDBMEFOKMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		private TaskAwaiter<CPDJMCBJMIL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x37EE380", Offset = "0x37ECF80", VA = "0x1837EE380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x37EE570", Offset = "0x37ED170", VA = "0x1837EE570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private sealed class LDPDGOJJALJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public LDPDGOJJALJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x15DAE50", Offset = "0x15D9A50", VA = "0x1815DAE50")]
		internal bool <FetchRoomDetails>b__0(MKEIKAGIGLF sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct EPPCBEFKELF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public AsyncTaskMethodBuilder<CPDJMCBJMIL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public AHNPBEMNBDD callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private LDPDGOJJALJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private IFANLHMJJPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private TaskAwaiter<OFPAILNJPLH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x37EF1D0", Offset = "0x37EDDD0", VA = "0x1837EF1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x37EF710", Offset = "0x37EE310", VA = "0x1837EF710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	private AHNPBEMNBDD OPBBALMJDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	private FNONLEEMBIA GFEIODEDCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	private IFANLHMJJPA KIACJFINHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	private long KLMDBCIHINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	private long ONEELBLPKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	private string FLCOEKEHLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	private HDLEMCDEJDD KOKEGJGGDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	private HDLEMCDEJDD HJJDGNJBMDD;

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x2CE05A0", Offset = "0x2CDF1A0", VA = "0x182CE05A0")]
	public static Task<CPDJMCBJMIL> KIHHHMICNPG(INMGAJCAIOM GFONEBKMLAH, PGGLGCLPJMP PJCBPMCBLEN, IFANLHMJJPA KIACJFINHDJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x2CE09A0", Offset = "0x2CDF5A0", VA = "0x182CE09A0")]
	[AsyncStateMachine(typeof(LFBHLMCPGDC))]
	private Task<CPDJMCBJMIL> LDJEMKIKHJD(CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x2CE0410", Offset = "0x2CDF010", VA = "0x182CE0410")]
	[AsyncStateMachine(typeof(EMDCIDLHELF))]
	private Task<CPDJMCBJMIL> IBKJKHONGEM(long KLMDBCIHINB, long ONEELBLPKOK, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ, bool MFNAMPCNHAB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x2CE0290", Offset = "0x2CDEE90", VA = "0x182CE0290")]
	[AsyncStateMachine(typeof(EPPCBEFKELF))]
	public static Task<CPDJMCBJMIL> IBKJKHONGEM(AHNPBEMNBDD OPBBALMJDDI, long KLMDBCIHINB, long ONEELBLPKOK, CancellationToken OKPCBPJCBCJ, IFANLHMJJPA DHJIFBEMLMJ, bool MFNAMPCNHAB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x2CDFFE0", Offset = "0x2CDEBE0", VA = "0x182CDFFE0")]
	private void EBCIOKFJLGM(OFPAILNJPLH LDIGOIDIFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x2CE0830", Offset = "0x2CDF430", VA = "0x182CE0830")]
	private bool KNJIHKMGFGD(CPDJMCBJMIL GAGLKGONONJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x2CE00F0", Offset = "0x2CDECF0", VA = "0x182CE00F0")]
	private void HBGJHIJOCHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal struct HENMFJEPAFN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct OKCCEFANEOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public HENMFJEPAFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		private IFANLHMJJPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x37FB650", Offset = "0x37FA250", VA = "0x1837FB650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private const int MNGBGIEIOBK = 20;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	private const float KIDKPOEAAEB = 15f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	private AHNPBEMNBDD OPBBALMJDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	private MMBJADMOHGP GAGLKGONONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	private IFANLHMJJPA KIACJFINHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	private float EACDMNNBLIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	private float DFHGDMPOCNH;

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x2CE3E90", Offset = "0x2CE2A90", VA = "0x182CE3E90")]
	public static Task ECHFPKABKBM(INMGAJCAIOM GFONEBKMLAH, MMBJADMOHGP GAGLKGONONJ, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x2CE42C0", Offset = "0x2CE2EC0", VA = "0x182CE42C0")]
	[AsyncStateMachine(typeof(OKCCEFANEOI))]
	public Task LDJEMKIKHJD(CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x2CE3CD0", Offset = "0x2CE28D0", VA = "0x182CE3CD0")]
	private static void DENIAPIIKOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x2CE40F0", Offset = "0x2CE2CF0", VA = "0x182CE40F0")]
	private void IMLCEPNHLDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x2CE4030", Offset = "0x2CE2C30", VA = "0x182CE4030")]
	private static float GMCPMKGOKEM(AHNPBEMNBDD OPBBALMJDDI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x2CE3E70", Offset = "0x2CE2A70", VA = "0x182CE3E70")]
	private static float DMCGCHLDGDL()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000135")]
internal struct GMNGEPKDNED
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private struct HAHCNAKLGPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public CJABFHHEKHC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public MMBJADMOHGP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private KHCEKICDGEB <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private INMGAJCAIOM <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private BFOAOGBJEAJ.EBFMPNLAEMP <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private TaskAwaiter<MAAKCJEMEIP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x37F3B10", Offset = "0x37F2710", VA = "0x1837F3B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct LFDMFJLKPBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private PGACMHCPPJD.FKDKEKGGAAP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x37F95F0", Offset = "0x37F81F0", VA = "0x1837F95F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x2CE3740", Offset = "0x2CE2340", VA = "0x182CE3740")]
	[AsyncStateMachine(typeof(HAHCNAKLGPG))]
	public static Task LDJEMKIKHJD(CJABFHHEKHC PHCHEONAKAJ, MMBJADMOHGP GAGLKGONONJ, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x2CE35A0", Offset = "0x2CE21A0", VA = "0x182CE35A0")]
	private static Task<MAAKCJEMEIP> BLKJKIFCLGO(CJABFHHEKHC PHCHEONAKAJ, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x2CE38A0", Offset = "0x2CE24A0", VA = "0x182CE38A0")]
	[AsyncStateMachine(typeof(LFDMFJLKPBJ))]
	private static Task LFGONGGJFGE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal struct GNODGINJDNA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[CompilerGenerated]
	private struct CBHFMELDFDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public GNODGINJDNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private IFANLHMJJPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x37EB130", Offset = "0x37E9D30", VA = "0x1837EB130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private sealed class HEAPJPNCABK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public HEAPJPNCABK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x37F4510", Offset = "0x37F3110", VA = "0x1837F4510")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private struct JGPDLHCDJHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public GNODGINJDNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		private FBHHEJIEPKI <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x37F7D60", Offset = "0x37F6960", VA = "0x1837F7D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	private bool PBEBOAGMNPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private IFANLHMJJPA KIACJFINHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	private INMGAJCAIOM GFONEBKMLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	private CancellationToken OKPCBPJCBCJ;

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x2CE3C60", Offset = "0x2CE2860", VA = "0x182CE3C60")]
	public static Task PMLGPPIFPMD(INMGAJCAIOM GFONEBKMLAH, bool PBEBOAGMNPJ, IFANLHMJJPA KIACJFINHDJ, CancellationToken FBLNGKEOGEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x2CE3B50", Offset = "0x2CE2750", VA = "0x182CE3B50")]
	[AsyncStateMachine(typeof(CBHFMELDFDA))]
	private Task LDJEMKIKHJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x2CE3A20", Offset = "0x2CE2620", VA = "0x182CE3A20")]
	[AsyncStateMachine(typeof(JGPDLHCDJHM))]
	private Task HIFLHBBIDJD(bool AFIOACOFFOM, string AAACHMNNIGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8E0", Offset = "0x6AC4E0", VA = "0x1806AD8E0")]
	private bool EHHEKONPKCF(bool PBEBOAGMNPJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
internal struct ECCBANHELGK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private struct FILNBGDLKJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public ECCBANHELGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private IFANLHMJJPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x37F0390", Offset = "0x37EEF90", VA = "0x1837F0390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x37F07E0", Offset = "0x37EF3E0", VA = "0x1837F07E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private sealed class EJKLHEOKHBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public EJKLHEOKHBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x37EE330", Offset = "0x37ECF30", VA = "0x1837EE330")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct JGPNFLOJMPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public ECCBANHELGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private FBHHEJIEPKI <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x37F8240", Offset = "0x37F6E40", VA = "0x1837F8240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x37F8720", Offset = "0x37F7320", VA = "0x1837F8720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private EFNIPIEHPND OHNIPJAOOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	private IFANLHMJJPA KIACJFINHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	private INMGAJCAIOM GFONEBKMLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	private bool PIGKKFPOHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private MMBJADMOHGP GAGLKGONONJ;

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA910", Offset = "0x2CD9510", VA = "0x182CDA910")]
	public static Task<Scene> EDKEDDODDJI(INMGAJCAIOM GFONEBKMLAH, EFNIPIEHPND HAHEMDBDNHH, IFANLHMJJPA KIACJFINHDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x2CDAC60", Offset = "0x2CD9860", VA = "0x182CDAC60")]
	public static Task<Scene> OBKAAPFLNJH(INMGAJCAIOM GFONEBKMLAH, MMBJADMOHGP GAGLKGONONJ, IFANLHMJJPA KIACJFINHDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x2CDAAF0", Offset = "0x2CD96F0", VA = "0x182CDAAF0")]
	[AsyncStateMachine(typeof(FILNBGDLKJP))]
	private Task<Scene> LDJEMKIKHJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x2CDAC20", Offset = "0x2CD9820", VA = "0x182CDAC20")]
	private bool NICGJGMFEAA(MMBJADMOHGP GAGLKGONONJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA8A0", Offset = "0x2CD94A0", VA = "0x182CDA8A0")]
	private void CNPINMBDKCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA990", Offset = "0x2CD9590", VA = "0x182CDA990")]
	[AsyncStateMachine(typeof(JGPNFLOJMPN))]
	private Task<Scene> HIFLHBBIDJD(string AAACHMNNIGK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000140")]
internal struct EJMODGHJGFA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct CPDJDCMACOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public AsyncTaskMethodBuilder<KLOAJMHCOJF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public EJMODGHJGFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public KLOAJMHCOJF nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public MMBJADMOHGP deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private IFANLHMJJPA <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private TaskAwaiter<KLOAJMHCOJF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x37EBDD0", Offset = "0x37EA9D0", VA = "0x1837EBDD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x37EC3C0", Offset = "0x37EAFC0", VA = "0x1837EC3C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private struct CCFBFHIJEFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public AsyncTaskMethodBuilder<KLOAJMHCOJF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public EJMODGHJGFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public KLOAJMHCOJF state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private TaskAwaiter<MAAKCJEMEIP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x37EB670", Offset = "0x37EA270", VA = "0x1837EB670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x37EB8F0", Offset = "0x37EA4F0", VA = "0x1837EB8F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	private readonly CJABFHHEKHC PHCHEONAKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	private readonly FNONLEEMBIA GFEIODEDCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	private readonly BLPGEOLAGBI KJEMDPBOECL;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private KHCEKICDGEB FKGOGBFCDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x9DA4B0", Offset = "0x9D90B0", VA = "0x1809DA4B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x2CDC240", Offset = "0x2CDAE40", VA = "0x182CDC240")]
	public EJMODGHJGFA(CJABFHHEKHC PHCHEONAKAJ, FNONLEEMBIA GFEIODEDCOL, BLPGEOLAGBI KJEMDPBOECL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x2CDC070", Offset = "0x2CDAC70", VA = "0x182CDC070")]
	[AsyncStateMachine(typeof(CPDJDCMACOC))]
	public Task<KLOAJMHCOJF> JIKEHEELHHJ(KLOAJMHCOJF GEEMAIOIPKC, MMBJADMOHGP OLKDPBHNDDI, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ, bool JIDLHBOMPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x2CDBF00", Offset = "0x2CDAB00", VA = "0x182CDBF00")]
	[AsyncStateMachine(typeof(CCFBFHIJEFK))]
	private Task<KLOAJMHCOJF> FIGELDMJJOH(IFANLHMJJPA DHJIFBEMLMJ, KLOAJMHCOJF DBOAJCAFPEK, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x2CDC210", Offset = "0x2CDAE10", VA = "0x182CDC210")]
	private bool PIECHPLAOCA(KLOAJMHCOJF EPOHLJBECMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x2CDBEE0", Offset = "0x2CDAAE0", VA = "0x182CDBEE0")]
	private void AJGKFIDACMM(string NOGJKHDOHIA)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000143")]
internal struct LMMLJONOPCK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private struct KNKLONODEAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public KHCEKICDGEB operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public MMBJADMOHGP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public ODBFEHEDEIH timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private List<(PersistenceView, CFFAMHPODII)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private (PersistenceView, CFFAMHPODII) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x4486530", Offset = "0x4485130", VA = "0x184486530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x365BDB0", Offset = "0x365A9B0", VA = "0x18365BDB0")]
	[AsyncStateMachine(typeof(KNKLONODEAP))]
	public static Task LDJEMKIKHJD(KHCEKICDGEB ECKBPFEGIAL, MMBJADMOHGP GAGLKGONONJ, ODBFEHEDEIH AEDIFBBHMJN, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000145")]
internal struct NEKGLLGBPGP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct JPLLDLFNBHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public KHCEKICDGEB operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public MMBJADMOHGP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public ODBFEHEDEIH timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		private ALPEFALFPBN <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private List<(PersistenceView, CFFAMHPODII)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private CFFAMHPODII <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x4485AF0", Offset = "0x44846F0", VA = "0x184485AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x365FB70", Offset = "0x365E770", VA = "0x18365FB70")]
	[AsyncStateMachine(typeof(JPLLDLFNBHC))]
	public static Task LDJEMKIKHJD(KHCEKICDGEB ECKBPFEGIAL, MMBJADMOHGP GAGLKGONONJ, ODBFEHEDEIH AEDIFBBHMJN, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
internal struct BFOAOGBJEAJ
{
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	public struct EBFMPNLAEMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public List<MIKJJGJPDJD> IOILLIIJGNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public List<CFFAMHPODII> NPNBCNPGCMD;

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x91D560", Offset = "0x91C160", VA = "0x18091D560")]
		public EBFMPNLAEMP(List<MIKJJGJPDJD> IOILLIIJGNI, List<CFFAMHPODII> NPNBCNPGCMD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private sealed class HBBKBNGCLEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public IEnumerable<MIKJJGJPDJD> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public HBBKBNGCLEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x3656A00", Offset = "0x3655600", VA = "0x183656A00")]
		internal object <TryBulkInstantiateObjects>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000565")]
	private INMGAJCAIOM GFONEBKMLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	private MMBJADMOHGP GAGLKGONONJ;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private AHNPBEMNBDD NNDPCGNEDGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x2CD28F0", Offset = "0x2CD14F0", VA = "0x182CD28F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x2CD2940", Offset = "0x2CD1540", VA = "0x182CD2940")]
	public static EBFMPNLAEMP LDJEMKIKHJD(INMGAJCAIOM GFONEBKMLAH, MMBJADMOHGP GAGLKGONONJ)
	{
		return default(EBFMPNLAEMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x2CD29A0", Offset = "0x2CD15A0", VA = "0x182CD29A0")]
	private EBFMPNLAEMP LDJEMKIKHJD()
	{
		return default(EBFMPNLAEMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x2CD2CA0", Offset = "0x2CD18A0", VA = "0x182CD2CA0")]
	private EBFMPNLAEMP LKLIEJGLFIH(HNMNGPNPECE CNFINMGFNPM, ALPEFALFPBN IHADDGGEMGI)
	{
		return default(EBFMPNLAEMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x2CD31F0", Offset = "0x2CD1DF0", VA = "0x182CD31F0")]
	private bool OMMOEGPOPDL(IEnumerable<MIKJJGJPDJD> IOILLIIJGNI)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014A")]
internal struct LKPAKLIBJJP
{
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private sealed class KGMCNNPEGJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public BFOAOGBJEAJ.EBFMPNLAEMP instantiations;

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public KGMCNNPEGJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x4486420", Offset = "0x4485020", VA = "0x184486420")]
		internal object <Run>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private sealed class DFNEPOMFNGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public DFNEPOMFNGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x4480460", Offset = "0x447F060", VA = "0x184480460")]
		internal object <Run>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x365B720", Offset = "0x365A320", VA = "0x18365B720")]
	public static void LDJEMKIKHJD(KHCEKICDGEB ECKBPFEGIAL, MMBJADMOHGP GAGLKGONONJ, BFOAOGBJEAJ.EBFMPNLAEMP ICEDDAMEJGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
internal class BLPGEOLAGBI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct KMACKAMGDID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public BLPGEOLAGBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public KLOAJMHCOJF operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public MMBJADMOHGP deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public IFANLHMJJPA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x3659D80", Offset = "0x3658980", VA = "0x183659D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private sealed class EDHDBCLGMOE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000150")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400057B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400057C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400057D")]
			public EDHDBCLGMOE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400057E")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400057F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000572")]
			[Cpp2IlInjected.Address(RVA = "0x448CA20", Offset = "0x448B620", VA = "0x18448CA20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000573")]
			[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public BLPGEOLAGBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public MMBJADMOHGP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public IFANLHMJJPA handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public EDHDBCLGMOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x36549C0", Offset = "0x36535C0", VA = "0x1836549C0")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task <RunAuthorityHandler>b__0(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private struct KKDFJFNKPAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public BLPGEOLAGBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public MMBJADMOHGP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public IFANLHMJJPA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private EDHDBCLGMOE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x3659360", Offset = "0x3657F60", VA = "0x183659360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct CMBFCNHOFLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public BLPGEOLAGBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public IFANLHMJJPA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public MMBJADMOHGP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private IFANLHMJJPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private Dictionary<Guid, List<LLGKCODFPOG>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x36537F0", Offset = "0x36523F0", VA = "0x1836537F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private struct CMONJCPDBLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public BLPGEOLAGBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public IFANLHMJJPA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public MMBJADMOHGP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private IFANLHMJJPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		private Dictionary<Guid, List<LLGKCODFPOG>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x3653C70", Offset = "0x3652870", VA = "0x183653C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private sealed class BBCOKLICDCH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000155")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400059F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005A0")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005A1")]
			public LLGKCODFPOG handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005A2")]
			public BBCOKLICDCH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005A3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600057E")]
			[Cpp2IlInjected.Address(RVA = "0x448A340", Offset = "0x4488F40", VA = "0x18448A340", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057F")]
			[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public FAONIMIDACI runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public List<LLGKCODFPOG> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public MMBJADMOHGP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public BBCOKLICDCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x3652990", Offset = "0x3651590", VA = "0x183652990")]
		internal object <InvokeMethodsInParallel>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x3652B70", Offset = "0x3651770", VA = "0x183652B70")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task <InvokeMethodsInParallel>b__2(LLGKCODFPOG handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x3652A80", Offset = "0x3651680", VA = "0x183652A80")]
		internal object <InvokeMethodsInParallel>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct NIBHCECIKKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public FAONIMIDACI runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public List<LLGKCODFPOG> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public MMBJADMOHGP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private BBCOKLICDCH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x365FD50", Offset = "0x365E950", VA = "0x18365FD50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct DFLMODBNCME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public BLPGEOLAGBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public MMBJADMOHGP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public IFANLHMJJPA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x36546D0", Offset = "0x36532D0", VA = "0x1836546D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private sealed class NCHNPPIADON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public NCHNPPIADON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x365F6B0", Offset = "0x365E2B0", VA = "0x18365F6B0")]
		internal object <MasterInvokeHandlerMethods>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct GNEHNDMKOPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public BLPGEOLAGBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public MMBJADMOHGP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x36565B0", Offset = "0x36551B0", VA = "0x1836565B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private sealed class CALHHIPJDIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public CALHHIPJDIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x3653670", Offset = "0x3652270", VA = "0x183653670")]
		internal object <MasterSyncSendCompletionMark>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct DFIHPGEOGAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public BLPGEOLAGBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private TaskAwaiter<MAAKCJEMEIP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x3654170", Offset = "0x3652D70", VA = "0x183654170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private sealed class MFPLIIGCIEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public MFPLIIGCIEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x365D360", Offset = "0x365BF60", VA = "0x18365D360")]
		internal object <RemoveCompletedHandler>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private readonly CJABFHHEKHC PHCHEONAKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private JKIGCPLBFCI KJEMDPBOECL;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private KHCEKICDGEB FKGOGBFCDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x76FDE0", Offset = "0x76E9E0", VA = "0x18076FDE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x7343F0", Offset = "0x732FF0", VA = "0x1807343F0")]
	public BLPGEOLAGBI(CJABFHHEKHC PHCHEONAKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x2CD4C80", Offset = "0x2CD3880", VA = "0x182CD4C80")]
	[AsyncStateMachine(typeof(KMACKAMGDID))]
	public Task LDJEMKIKHJD(KLOAJMHCOJF NONCDNOEOAP, MMBJADMOHGP OLKDPBHNDDI, IFANLHMJJPA KIACJFINHDJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x2CD5070", Offset = "0x2CD3C70", VA = "0x182CD5070")]
	[AsyncStateMachine(typeof(KKDFJFNKPAG))]
	private Task ONNJMOKIHGP(MMBJADMOHGP GAGLKGONONJ, IFANLHMJJPA KIACJFINHDJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x2CD4270", Offset = "0x2CD2E70", VA = "0x182CD4270")]
	[AsyncStateMachine(typeof(CMBFCNHOFLD))]
	private Task AKGMLILOECI(MMBJADMOHGP GAGLKGONONJ, IFANLHMJJPA KIACJFINHDJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x2CD45A0", Offset = "0x2CD31A0", VA = "0x182CD45A0")]
	[AsyncStateMachine(typeof(CMONJCPDBLD))]
	private Task DJJJGHIOACC(MMBJADMOHGP GAGLKGONONJ, IFANLHMJJPA KIACJFINHDJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x2CD4F30", Offset = "0x2CD3B30", VA = "0x182CD4F30")]
	[AsyncStateMachine(typeof(NIBHCECIKKL))]
	private Task OEBAOGFCLDD(Guid EMJKCEMMMKP, List<LLGKCODFPOG> MNMIBAGPBIJ, FAONIMIDACI OGMOABLDOOJ, MMBJADMOHGP GAGLKGONONJ, CancellationToken GIHOLCNOBIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x2CD4A10", Offset = "0x2CD3610", VA = "0x182CD4A10")]
	[AsyncStateMachine(typeof(DFLMODBNCME))]
	private Task EMNNPEAEFLO(MMBJADMOHGP GAGLKGONONJ, IFANLHMJJPA KIACJFINHDJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x2CD4700", Offset = "0x2CD3300", VA = "0x182CD4700")]
	[AsyncStateMachine(typeof(GNEHNDMKOPH))]
	private Task EBJIDFCDPEA(Guid EPPIIDICLBO, MMBJADMOHGP GAGLKGONONJ, IFANLHMJJPA KIACJFINHDJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x2CD4DE0", Offset = "0x2CD39E0", VA = "0x182CD4DE0")]
	[AsyncStateMachine(typeof(DFIHPGEOGAN))]
	private Task LKBGONHMMAM(Guid EPPIIDICLBO, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x2CD40E0", Offset = "0x2CD2CE0", VA = "0x182CD40E0")]
	private void AGBEPDMNMOL(Guid EPPIIDICLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x2CD4B60", Offset = "0x2CD3760", VA = "0x182CD4B60")]
	private void HBBDFBHHFOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x2CD43D0", Offset = "0x2CD2FD0", VA = "0x182CD43D0")]
	public Guid BGABFADDFCJ(KLOAJMHCOJF LEMFPIGLCJA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x2CD4840", Offset = "0x2CD3440", VA = "0x182CD4840")]
	[CompilerGenerated]
	private object EGNMBEPBKAP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
public readonly struct DJIHHMDOBME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CB")]
	[CanBeNull]
	public readonly HNMNGPNPECE PLHPOLHGDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005CC")]
	[NotNull]
	public readonly LMHLEDALAHC PDMMBBCCCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005CD")]
	[CanBeNull]
	public readonly string BAMLFBEDNOB;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public IReadOnlyCollection<string> HAFJKDIFMDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x2CDA710", Offset = "0x2CD9310", VA = "0x182CDA710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public IReadOnlyDictionary<long, int> EENJDBNNFNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x2CDA730", Offset = "0x2CD9330", VA = "0x182CDA730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA750", Offset = "0x2CD9350", VA = "0x182CDA750")]
	public DJIHHMDOBME([CanBeNull] HNMNGPNPECE CAMLOJNDCJA, [NotNull] LMHLEDALAHC CELCJMPNDGF, [CanBeNull] string MLNFDJPEMCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015F")]
internal class FCNCPHHOOLO : EOPFPCCCFDH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private struct AJCFMOCMJOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public AsyncTaskMethodBuilder<DJIHHMDOBME> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public FCNCPHHOOLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public ILNHMGBKGOA serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x37E9780", Offset = "0x37E8380", VA = "0x1837E9780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x37E9C50", Offset = "0x37E8850", VA = "0x1837E9C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private sealed class CADJOOMBDDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public ILNHMGBKGOA serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public CADJOOMBDDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x37EAEF0", Offset = "0x37E9AF0", VA = "0x1837EAEF0")]
		internal Task <PreserializeViews>b__1(PersistenceView v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class KDBJNAMFIIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public CADJOOMBDDC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public KDBJNAMFIIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x37F8BD0", Offset = "0x37F77D0", VA = "0x1837F8BD0")]
		internal object <PreserializeViews>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private sealed class BOEFENEONFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public CADJOOMBDDC CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public BOEFENEONFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x37EAEB0", Offset = "0x37E9AB0", VA = "0x1837EAEB0")]
		internal Task <PreserializeViews>b__3(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private struct FDDMNFAJIEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public ILNHMGBKGOA serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public FCNCPHHOOLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private KDBJNAMFIIM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		private PGACMHCPPJD.NMFOPBFFJCO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x37EF8B0", Offset = "0x37EE4B0", VA = "0x1837EF8B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005CE")]
	private readonly HAHPELENECE MEJGJPMOALC;

	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	private static readonly TimeSpan JLKABBNBIJI;

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x2CDDD30", Offset = "0x2CDC930", VA = "0x182CDDD30")]
	public FCNCPHHOOLO(CJABFHHEKHC PHCHEONAKAJ, [Optional] HAHPELENECE? MEJGJPMOALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x2CDCF80", Offset = "0x2CDBB80", VA = "0x182CDCF80")]
	[AsyncStateMachine(typeof(AJCFMOCMJOO))]
	public Task<DJIHHMDOBME> ANBECOLJJND(long ONEELBLPKOK, string MLNFDJPEMCC, ILNHMGBKGOA ODKBEHHEOIA, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x2CDCC70", Offset = "0x2CDB870", VA = "0x182CDCC70")]
	[AsyncStateMachine(typeof(FDDMNFAJIEC))]
	private Task ACBBHHDEGCN(ILNHMGBKGOA ODKBEHHEOIA, IEnumerable<PersistenceView> HFMNCOGGPKJ, StringBuilder ODHJFDIBHNN, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x2CDD630", Offset = "0x2CDC230", VA = "0x182CDD630")]
	private DJIHHMDOBME IMHALCGKHIL(long ONEELBLPKOK, string MLNFDJPEMCC, ILNHMGBKGOA ODKBEHHEOIA, IEnumerable<PersistenceView> HFMNCOGGPKJ, StringBuilder ODHJFDIBHNN)
	{
		return default(DJIHHMDOBME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x2CDCDD0", Offset = "0x2CDB9D0", VA = "0x182CDCDD0")]
	private HNMNGPNPECE ADHGIFBJLDG(long ONEELBLPKOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x2CDDAA0", Offset = "0x2CDC6A0", VA = "0x182CDDAA0")]
	private void PPJFNOLACDD(HNMNGPNPECE DKMOAEPKFEL, StringBuilder ODHJFDIBHNN, IEnumerable<PersistenceView> HFMNCOGGPKJ, in EAGHIGKDMOK PENAEKEAGKA, ref OGGBHCAJIJC LEIMCDGEPGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x2CDD100", Offset = "0x2CDBD00", VA = "0x182CDD100")]
	private void EMDJENPCLEF(HNMNGPNPECE DKMOAEPKFEL, StringBuilder ODHJFDIBHNN, PersistenceView ENAFFFEEEOK, ref OGGBHCAJIJC LEIMCDGEPGJ, in EAGHIGKDMOK PENAEKEAGKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
internal class BOHGOKBCKCN : EOPFPCCCFDH
{
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private sealed class PNCONLBPAFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public MPGMEFHBLFB.KBACJBIMPCN roomDataUpload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public byte[] data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public MPGMEFHBLFB.KBACJBIMPCN subRoomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public PNCONLBPAFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x3668A70", Offset = "0x3667670", VA = "0x183668A70")]
		internal object <UploadRoomDataToStorage>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x3668B00", Offset = "0x3667700", VA = "0x183668B00")]
		internal object <UploadRoomDataToStorage>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x3668B50", Offset = "0x3667750", VA = "0x183668B50")]
		internal object <UploadRoomDataToStorage>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x3668BC0", Offset = "0x36677C0", VA = "0x183668BC0")]
		internal object <UploadRoomDataToStorage>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct FMHEMMMFLBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public AsyncTaskMethodBuilder<(MPGMEFHBLFB.KBACJBIMPCN roomDataUpload, MPGMEFHBLFB.KBACJBIMPCN subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public DJIHHMDOBME roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public BOHGOKBCKCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private PNCONLBPAFL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private float <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		private TaskAwaiter<MPGMEFHBLFB.KBACJBIMPCN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x3655790", Offset = "0x3654390", VA = "0x183655790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x3656240", Offset = "0x3654E40", VA = "0x183656240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct NCJDPJFIBAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public AsyncTaskMethodBuilder<JMJKOKLCGPH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public BOHGOKBCKCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public DJIHHMDOBME roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public OMDELFIKCOM roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		private TaskAwaiter<(MPGMEFHBLFB.KBACJBIMPCN roomDataUpload, MPGMEFHBLFB.KBACJBIMPCN subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		private TaskAwaiter<JMJKOKLCGPH> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x365F720", Offset = "0x365E320", VA = "0x18365F720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x365FB20", Offset = "0x365E720", VA = "0x18365FB20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct OPAJBCLENGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public AsyncTaskMethodBuilder<MKIKECIEMNI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public BOHGOKBCKCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public DJIHHMDOBME roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		private TaskAwaiter<(MPGMEFHBLFB.KBACJBIMPCN roomDataUpload, MPGMEFHBLFB.KBACJBIMPCN subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		private TaskAwaiter<MKIKECIEMNI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x3666DD0", Offset = "0x36659D0", VA = "0x183666DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x3667160", Offset = "0x3665D60", VA = "0x183667160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private sealed class IEDIOOBCFHG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016C")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400061C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400061D")]
			public AsyncTaskMethodBuilder<MAAKCJEMEIP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400061E")]
			public IEDIOOBCFHG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400061F")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000620")]
			private MAAKCJEMEIP <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000621")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000622")]
			private TaskAwaiter<MKIKECIEMNI> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000623")]
			private TaskAwaiter<JMJKOKLCGPH> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000624")]
			private TaskAwaiter<MAAKCJEMEIP> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60005BE")]
			[Cpp2IlInjected.Address(RVA = "0x448CF00", Offset = "0x448BB00", VA = "0x18448CF00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BF")]
			[Cpp2IlInjected.Address(RVA = "0x448DA80", Offset = "0x448C680", VA = "0x18448DA80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public BOHGOKBCKCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public DJIHHMDOBME roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public OMDELFIKCOM roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public IEDIOOBCFHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x3657C40", Offset = "0x3656840", VA = "0x183657C40")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<MAAKCJEMEIP> <UploadRoomDataBlobAndSyncReload>b__0(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private struct APIMKAGEKAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public AsyncTaskMethodBuilder<MAAKCJEMEIP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public BOHGOKBCKCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public DJIHHMDOBME roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public OMDELFIKCOM roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		private TaskAwaiter<MAAKCJEMEIP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x3652200", Offset = "0x3650E00", VA = "0x183652200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x36524B0", Offset = "0x36510B0", VA = "0x1836524B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40005F0")]
	private const float GLKANBNHAIO = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	private readonly PKCDHDPJNDG GPIAGAFCCLI;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private INMGAJCAIOM GAKEKCMDGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x2CD6150", Offset = "0x2CD4D50", VA = "0x182CD6150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x2CD67C0", Offset = "0x2CD53C0", VA = "0x182CD67C0")]
	public BOHGOKBCKCN(CJABFHHEKHC PHCHEONAKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x2CD6650", Offset = "0x2CD5250", VA = "0x182CD6650")]
	[AsyncStateMachine(typeof(FMHEMMMFLBA))]
	private Task<(MPGMEFHBLFB.KBACJBIMPCN, MPGMEFHBLFB.KBACJBIMPCN)> PJGHFJKPMPI(DJIHHMDOBME BIBCOJPMADN, long KLMDBCIHINB, long IGCOFHNDKKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x2CD6180", Offset = "0x2CD4D80", VA = "0x182CD6180")]
	[AsyncStateMachine(typeof(NCJDPJFIBAF))]
	public Task<JMJKOKLCGPH> FIMJDIEGLMH(int DHOLEBLBBOC, [CanBeNull] OMDELFIKCOM ALNFALLNAOJ, DJIHHMDOBME BIBCOJPMADN, long KLMDBCIHINB, long IGCOFHNDKKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x2CD64C0", Offset = "0x2CD50C0", VA = "0x182CD64C0")]
	[AsyncStateMachine(typeof(OPAJBCLENGI))]
	private Task<MKIKECIEMNI> OFAJFKFAJOF(string DKKNAFGMNBK, int DHOLEBLBBOC, DJIHHMDOBME BIBCOJPMADN, long KLMDBCIHINB, long IGCOFHNDKKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x2CD6310", Offset = "0x2CD4F10", VA = "0x182CD6310")]
	[AsyncStateMachine(typeof(APIMKAGEKAJ))]
	public Task<MAAKCJEMEIP> FOMEHOOHKFL(int DHOLEBLBBOC, [CanBeNull] OMDELFIKCOM ALNFALLNAOJ, DJIHHMDOBME BIBCOJPMADN, long KLMDBCIHINB, long IGCOFHNDKKI, IFANLHMJJPA DHJIFBEMLMJ, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016E")]
public abstract class BKPDLPLJGDK<T> where T : global::BKPDLPLJGDK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000630")]
	internal readonly INMGAJCAIOM CCJKJKKIGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000631")]
	private int? OGKMIIHJFKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000632")]
	protected readonly Guid DMGANIDFKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000633")]
	protected readonly JKIMMKJPANP PENFPEKMMHP;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	protected T HHMNBHPCOOP
	{
		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x2A62BF0", Offset = "0x2A617F0", VA = "0x182A62BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x2A62C50", Offset = "0x2A61850", VA = "0x182A62C50")]
	internal BKPDLPLJGDK(INMGAJCAIOM MEAIENEDNIF, JKIMMKJPANP EMFMLAOCKEB, [Optional] Guid? MJGBLGMCHFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x2A62A10", Offset = "0x2A61610", VA = "0x182A62A10")]
	private MAAKCJEMEIP LLOPHFMDOPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "4")]
	protected virtual void CLNOMKLNMNH(MAAKCJEMEIP DPNJMDFICMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x2A62900", Offset = "0x2A61500", VA = "0x182A62900")]
	public T FFIFJLNOCLD(JCBHONMOFEO BHHJJPPBNKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x2A62990", Offset = "0x2A61590", VA = "0x182A62990")]
	public T GDBIOPKNHIO(int PFAPPPLIOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x2A62AF0", Offset = "0x2A616F0", VA = "0x182A62AF0", Slot = "5")]
	public virtual Task<ENHABCKLLMN> NJOJOCBECGI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016F")]
public class AONMNAPGDGL : global::BKPDLPLJGDK<AONMNAPGDGL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000634")]
	private PGGLGCLPJMP ADEMJHPFLJL;

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x2CD22D0", Offset = "0x2CD0ED0", VA = "0x182CD22D0")]
	internal AONMNAPGDGL(INMGAJCAIOM MEAIENEDNIF, JKIMMKJPANP EMFMLAOCKEB, [Optional] Guid? MJGBLGMCHFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0x2CD22B0", Offset = "0x2CD0EB0", VA = "0x182CD22B0")]
	public AONMNAPGDGL JFAFHEELNBE(PGGLGCLPJMP ADEMJHPFLJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x2CD21F0", Offset = "0x2CD0DF0", VA = "0x182CD21F0", Slot = "4")]
	protected override void CLNOMKLNMNH(MAAKCJEMEIP DPNJMDFICMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000170")]
public class PJOCJLAHHCF : global::BKPDLPLJGDK<PJOCJLAHHCF>
{
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	internal enum ONGHCJEEABP
	{
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private struct HDHCAEOHDDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public AsyncTaskMethodBuilder<ENHABCKLLMN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public PJOCJLAHHCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		private TaskAwaiter<ENHABCKLLMN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x4483FE0", Offset = "0x4482BE0", VA = "0x184483FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x44842E0", Offset = "0x4482EE0", VA = "0x1844842E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000635")]
	private ONGHCJEEABP JMJNGPNDBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000636")]
	private string KLHILNJAEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000637")]
	private OMDELFIKCOM ADEMJHPFLJL;

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x36688F0", Offset = "0x36674F0", VA = "0x1836688F0")]
	internal PJOCJLAHHCF(INMGAJCAIOM MEAIENEDNIF, JKIMMKJPANP EMFMLAOCKEB, [Optional] Guid? MJGBLGMCHFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x36686E0", Offset = "0x36672E0", VA = "0x1836686E0")]
	public PJOCJLAHHCF HJDAKDJNCDA(string HMBBKEJGHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x36687B0", Offset = "0x36673B0", VA = "0x1836687B0")]
	public PJOCJLAHHCF MPDJGIBOKOF(bool MNNJOFPDJAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x3668740", Offset = "0x3667340", VA = "0x183668740")]
	public PJOCJLAHHCF MAMBEKJOKMK(string HKLHFKDNFJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x3668710", Offset = "0x3667310", VA = "0x183668710")]
	public PJOCJLAHHCF JLPAANGIBDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x3668570", Offset = "0x3667170", VA = "0x183668570", Slot = "4")]
	protected override void CLNOMKLNMNH(MAAKCJEMEIP DPNJMDFICMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x36687D0", Offset = "0x36673D0", VA = "0x1836687D0", Slot = "5")]
	[AsyncStateMachine(typeof(HDHCAEOHDDJ))]
	public override Task<ENHABCKLLMN> NJOJOCBECGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x3668770", Offset = "0x3667370", VA = "0x183668770")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<ENHABCKLLMN> MDECJOOKCKO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
internal static class EDOBFNENOHJ
{
	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x2CDAD80", Offset = "0x2CD9980", VA = "0x182CDAD80")]
	public static void LGACOANKNHO(this EFPGKMAIMMO IJBKAEMEDOK, AIMCOPKLBGF EKGMNIPHIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x2CDAD00", Offset = "0x2CD9900", VA = "0x182CDAD00")]
	public static void FDNHKCOCLID(this AIMCOPKLBGF AOONFFMDOBB, [Optional] string DPNJMDFICMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
public static class BOJEAPIIJFO
{
	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0x2CD6940", Offset = "0x2CD5540", VA = "0x182CD6940")]
	public static HDLEMCDEJDD NIMLKCHDKDI(this NFOPFCDLIEC LBFCJBGOKPF)
	{
		return default(HDLEMCDEJDD);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x2CD6880", Offset = "0x2CD5480", VA = "0x182CD6880")]
	public static NFOPFCDLIEC FKCBCPDBPML(this HDLEMCDEJDD BPLFDILNMPJ)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CreateAssetMenu]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000176")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000644")]
			public PMLDGHOOJDK ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000645")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000646")]
			public PMLDGHOOJDK HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000647")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000648")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000649")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60005E0")]
			[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000641")]
		private static PMLDGHOOJDK[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		private Dictionary<PMLDGHOOJDK, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x366B1B0", Offset = "0x3669DB0", VA = "0x18366B1B0")]
		public bool CHPPAFBJKIL(PMLDGHOOJDK DKCFLNKGNDE, out ResultConfig CPNGCJKFMPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x366B220", Offset = "0x3669E20", VA = "0x18366B220")]
		public ResultConfig KDMOJDHBAAC(PMLDGHOOJDK KLLKBLNBCMN, [Optional] HashSet<PMLDGHOOJDK> PPABNMOIGFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x366B8C0", Offset = "0x366A4C0", VA = "0x18366B8C0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x366B340", Offset = "0x3669F40", VA = "0x18366B340", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x71C1E0", Offset = "0x71ADE0", VA = "0x18071C1E0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
public static class PEEBKDAFNOM
{
	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x36674A0", Offset = "0x36660A0", VA = "0x1836674A0")]
	[JGJJPBKAAKL(HKPPGBCDEPD.GameOnly)]
	private static void CCOFINLLKDB(FNLADHKGADM MOAGNKMBIEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
public interface KAMHGLCAIAM : IEquatable<KAMHGLCAIAM>
{
	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	HIKDFNAHKIF AGKCKFKFJML
	{
		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	DateTime CAABGPGGFOM
	{
		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MBLLADHAPGF();

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BJGFHCEICFG(long KLMDBCIHINB, long ONEELBLPKOK, out DJIHHMDOBME BIBCOJPMADN);
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
internal class IHMHNHMEKND : OIPOGEPDFIP
{
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private sealed class GDFBIDBKENK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public KJGKHGGPEAN autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public GDFBIDBKENK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x37F1B10", Offset = "0x37F0710", VA = "0x1837F1B10")]
		internal object <TrySaveAutosaveData>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400064F")]
	private readonly AJLDIEMBDJM MNADLLJELMN;

	[Cpp2IlInjected.Token(Token = "0x4000650")]
	private const int DJAMMDAGBHP = 5;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event Action<KAMHGLCAIAM> CKDCBJIGJBG
	{
		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x2CE5A20", Offset = "0x2CE4620", VA = "0x182CE5A20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x2CE5980", Offset = "0x2CE4580", VA = "0x182CE5980", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x7343F0", Offset = "0x732FF0", VA = "0x1807343F0")]
	[Preserve]
	public IHMHNHMEKND([MLOIHELMKFH(null)] AJLDIEMBDJM MNADLLJELMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x2CE5C80", Offset = "0x2CE4880", VA = "0x182CE5C80", Slot = "6")]
	public bool LLMKOEDIGDD(long KLMDBCIHINB, long ONEELBLPKOK, DJIHHMDOBME BIBCOJPMADN, KJGKHGGPEAN IKLNANFHOOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x2CE5AC0", Offset = "0x2CE46C0", VA = "0x182CE5AC0")]
	private void LDHGNPDOGCM(KAMHGLCAIAM HFFNLDFGIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x2CE5800", Offset = "0x2CE4400", VA = "0x182CE5800", Slot = "7")]
	public bool CGLDNCPAJFL(long KLMDBCIHINB, long ONEELBLPKOK, out KAMHGLCAIAM KHJPFEIDFAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(RVA = "0x2CE5F80", Offset = "0x2CE4B80", VA = "0x182CE5F80", Slot = "8")]
	public bool OJPJHCDAMGH(long KLMDBCIHINB, long ONEELBLPKOK, KJGKHGGPEAN IKLNANFHOOO, out KAMHGLCAIAM KHJPFEIDFAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x2CE6030", Offset = "0x2CE4C30", VA = "0x182CE6030")]
	private void PDPIPLCMANH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x2CE5B60", Offset = "0x2CE4760", VA = "0x182CE5B60", Slot = "9")]
	public void LHJIIBLDIAF(long KLMDBCIHINB, long ONEELBLPKOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
internal abstract class EHHAJMJGMAP : AJLDIEMBDJM
{
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	protected enum GKMKMDCJNMK : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private sealed class HOJHMGEKEHO : IEnumerable<KAMHGLCAIAM>, IEnumerable, IEnumerator<KAMHGLCAIAM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		private KAMHGLCAIAM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public EHHAJMJGMAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private KJGKHGGPEAN autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public KJGKHGGPEAN <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		private KAMHGLCAIAM System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x712DA0", Offset = "0x7119A0", VA = "0x180712DA0")]
		[DebuggerHidden]
		public HOJHMGEKEHO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x37F5180", Offset = "0x37F3D80", VA = "0x1837F5180", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x37F5390", Offset = "0x37F3F90", VA = "0x1837F5390", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x37F52E0", Offset = "0x37F3EE0", VA = "0x1837F52E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KAMHGLCAIAM> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x37F52E0", Offset = "0x37F3EE0", VA = "0x1837F52E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private sealed class EFAMEGMAPCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public KJGKHGGPEAN autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public EFAMEGMAPCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x37EE2A0", Offset = "0x37ECEA0", VA = "0x1837EE2A0")]
		internal object <SaveAutosave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private sealed class IJBILDDBAOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public EHHAJMJGMAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public IJBILDDBAOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x37F6A10", Offset = "0x37F5610", VA = "0x1837F6A10")]
		internal void <TryReadAutosaveFile>b__0(BKNFEJMIGDD.EJMLICBONMI ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000656")]
	protected readonly string ADLPAJPDDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000657")]
	private readonly object GEFLGIABIIA;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public abstract HIKDFNAHKIF AGKCKFKFJML
	{
		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x2CDBA70", Offset = "0x2CDA670", VA = "0x182CDBA70")]
	protected EHHAJMJGMAP([CanBeNull] string FCEPMMFNOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x2CDB260", Offset = "0x2CD9E60", VA = "0x182CDB260", Slot = "5")]
	public bool GAODIMMNFDE(long KLMDBCIHINB, long ONEELBLPKOK, KJGKHGGPEAN IKLNANFHOOO, out KAMHGLCAIAM HFFNLDFGIIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x2CDB740", Offset = "0x2CDA340", VA = "0x182CDB740", Slot = "6")]
	[IteratorStateMachine(typeof(HOJHMGEKEHO))]
	public IEnumerable<KAMHGLCAIAM> OCCOCGHCHJE(KJGKHGGPEAN IKLNANFHOOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void FKAOEBOJLCE(Stream MOKFFIEBBOP, long KLMDBCIHINB, long ONEELBLPKOK, DJIHHMDOBME BIBCOJPMADN);

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool BOJDNDLLDNH(Stream OCNPKFKPGIL, long KLMDBCIHINB, long ONEELBLPKOK, NGKFOJFFACM JIHODMLLFEP, out DJIHHMDOBME BIBCOJPMADN);

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x2CDB410", Offset = "0x2CDA010", VA = "0x182CDB410", Slot = "7")]
	public KAMHGLCAIAM MCCANHAPINF(long KLMDBCIHINB, long ONEELBLPKOK, DJIHHMDOBME BIBCOJPMADN, KJGKHGGPEAN IKLNANFHOOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo PNGIMEINPOB(long KLMDBCIHINB, long ONEELBLPKOK, KJGKHGGPEAN IKLNANFHOOO, GKMKMDCJNMK MMBBHAPAEPA);

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo CDDMMHAFGGI(KJGKHGGPEAN IKLNANFHOOO, GKMKMDCJNMK MMBBHAPAEPA);

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x2CDB1F0", Offset = "0x2CD9DF0", VA = "0x182CDB1F0")]
	protected void EOPNKPLIOJE(BKNFEJMIGDD.EJMLICBONMI GGGGBLAIINP, string NOGJKHDOHIA, FileInfo GOIGEAFHIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x2CDB7C0", Offset = "0x2CDA3C0", VA = "0x182CDB7C0")]
	internal bool PGPMGKEJPCO(FileInfo LFFKBBPAFAI, long KLMDBCIHINB, long ONEELBLPKOK, out DJIHHMDOBME BIBCOJPMADN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	private void MNHJMJEOHJC(Exception DMGGPOEOJGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
internal class FHJHAICCDIH : EHHAJMJGMAP
{
	[Cpp2IlInjected.Token(Token = "0x4000667")]
	private const string FPKGGCMIBAO = "V2";

	[Cpp2IlInjected.Token(Token = "0x4000668")]
	private const string GBEIAPBINOD = "AutosavesV2";

	[Cpp2IlInjected.Token(Token = "0x4000669")]
	private const string DLMEOELAMMO = "RecoveryV2";

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public override HIKDFNAHKIF AGKCKFKFJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x19DD170", Offset = "0x19DBD70", VA = "0x1819DD170", Slot = "8")]
		get
		{
			return default(HIKDFNAHKIF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x2CDFF30", Offset = "0x2CDEB30", VA = "0x182CDFF30")]
	public FHJHAICCDIH([Optional] string FCEPMMFNOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x2CDF590", Offset = "0x2CDE190", VA = "0x182CDF590")]
	private void BMPBDAJBNEG(KJGKHGGPEAN IKLNANFHOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x2CDFC50", Offset = "0x2CDE850", VA = "0x182CDFC50", Slot = "9")]
	internal override void FKAOEBOJLCE(Stream MOKFFIEBBOP, long KLMDBCIHINB, long ONEELBLPKOK, DJIHHMDOBME BIBCOJPMADN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x2CDF610", Offset = "0x2CDE210", VA = "0x182CDF610", Slot = "10")]
	internal override bool BOJDNDLLDNH(Stream OCNPKFKPGIL, long KLMDBCIHINB, long ONEELBLPKOK, NGKFOJFFACM JIHODMLLFEP, out DJIHHMDOBME BIBCOJPMADN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x2CDFE40", Offset = "0x2CDEA40", VA = "0x182CDFE40", Slot = "11")]
	protected override FileInfo PNGIMEINPOB(long KLMDBCIHINB, long ONEELBLPKOK, KJGKHGGPEAN IKLNANFHOOO, GKMKMDCJNMK MMBBHAPAEPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x2CDFB40", Offset = "0x2CDE740", VA = "0x182CDFB40", Slot = "12")]
	protected override DirectoryInfo CDDMMHAFGGI(KJGKHGGPEAN IKLNANFHOOO, GKMKMDCJNMK MMBBHAPAEPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal sealed class HJBCLMOIEPG : EHHAJMJGMAP
{
	[Cpp2IlInjected.Token(Token = "0x400066A")]
	private static readonly byte[] NANBEBOOGPM;

	[Cpp2IlInjected.Token(Token = "0x400066B")]
	private const string GBEIAPBINOD = "Autosaves";

	[Cpp2IlInjected.Token(Token = "0x400066C")]
	private const string DLMEOELAMMO = "Recovery";

	[Cpp2IlInjected.Token(Token = "0x400066D")]
	private const string GEDCBGKEPLB = "Autosaves";

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400066E")]
	private readonly byte[] MLMODOJOICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400066F")]
	private readonly byte[] FIBCMIIGPNA;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public override HIKDFNAHKIF AGKCKFKFJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x9AC250", Offset = "0x9AAE50", VA = "0x1809AC250", Slot = "8")]
		get
		{
			return default(HIKDFNAHKIF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x2CE52E0", Offset = "0x2CE3EE0", VA = "0x182CE52E0")]
	public HJBCLMOIEPG([Optional] string FCEPMMFNOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x2CE4DD0", Offset = "0x2CE39D0", VA = "0x182CE4DD0", Slot = "9")]
	internal override void FKAOEBOJLCE(Stream MOKFFIEBBOP, long KLMDBCIHINB, long ONEELBLPKOK, DJIHHMDOBME BIBCOJPMADN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x2CE4570", Offset = "0x2CE3170", VA = "0x182CE4570", Slot = "10")]
	internal override bool BOJDNDLLDNH(Stream OCNPKFKPGIL, long KLMDBCIHINB, long ONEELBLPKOK, NGKFOJFFACM JIHODMLLFEP, out DJIHHMDOBME BIBCOJPMADN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x2CE5020", Offset = "0x2CE3C20", VA = "0x182CE5020")]
	private void OFGDNCNGIPL(byte[] FCLGIGIIKEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x2CE5130", Offset = "0x2CE3D30", VA = "0x182CE5130", Slot = "11")]
	protected override FileInfo PNGIMEINPOB(long KLMDBCIHINB, long ONEELBLPKOK, KJGKHGGPEAN IKLNANFHOOO, GKMKMDCJNMK MMBBHAPAEPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x2CE4CB0", Offset = "0x2CE38B0", VA = "0x182CE4CB0", Slot = "12")]
	protected override DirectoryInfo CDDMMHAFGGI(KJGKHGGPEAN IKLNANFHOOO, GKMKMDCJNMK MMBBHAPAEPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
public enum HIKDFNAHKIF : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000671")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x4000672")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x4000673")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
internal class FPIFEGGANAG : AJLDIEMBDJM
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[CompilerGenerated]
	private sealed class ANJFCPOCEOJ : IEnumerable<KAMHGLCAIAM>, IEnumerable, IEnumerator<KAMHGLCAIAM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		private KAMHGLCAIAM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public FPIFEGGANAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		private KJGKHGGPEAN autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		public KJGKHGGPEAN <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		private HIKDFNAHKIF[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private IEnumerator<KAMHGLCAIAM> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		private KAMHGLCAIAM System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000630")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000632")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x712DA0", Offset = "0x7119A0", VA = "0x180712DA0")]
		[DebuggerHidden]
		public ANJFCPOCEOJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x37EA530", Offset = "0x37E9130", VA = "0x1837EA530", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x37EA160", Offset = "0x37E8D60", VA = "0x1837EA160", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x37EA5C0", Offset = "0x37E91C0", VA = "0x1837EA5C0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x37EA4F0", Offset = "0x37E90F0", VA = "0x1837EA4F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x37EA440", Offset = "0x37E9040", VA = "0x1837EA440", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KAMHGLCAIAM> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x37EA440", Offset = "0x37E9040", VA = "0x1837EA440", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	private readonly HIKDFNAHKIF[] JIKANNBDKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000675")]
	private readonly Dictionary<HIKDFNAHKIF, AJLDIEMBDJM> MKGJPLEDFBJ;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public HIKDFNAHKIF AGKCKFKFJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x2CE2090", Offset = "0x2CE0C90", VA = "0x182CE2090", Slot = "4")]
		get
		{
			return default(HIKDFNAHKIF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x2CE2470", Offset = "0x2CE1070", VA = "0x182CE2470")]
	[Preserve]
	public FPIFEGGANAG(params AJLDIEMBDJM[] AAMGNEHFBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x2CE1F30", Offset = "0x2CE0B30", VA = "0x182CE1F30", Slot = "5")]
	public bool GAODIMMNFDE(long KLMDBCIHINB, long ONEELBLPKOK, KJGKHGGPEAN IKLNANFHOOO, out KAMHGLCAIAM HFFNLDFGIIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x2CE20D0", Offset = "0x2CE0CD0", VA = "0x182CE20D0")]
	private void HOIFNDGDLDB(int APNAJDGFAKD, long KLMDBCIHINB, long ONEELBLPKOK, KJGKHGGPEAN IKLNANFHOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x2CE23F0", Offset = "0x2CE0FF0", VA = "0x182CE23F0", Slot = "6")]
	[IteratorStateMachine(typeof(ANJFCPOCEOJ))]
	public IEnumerable<KAMHGLCAIAM> OCCOCGHCHJE(KJGKHGGPEAN IKLNANFHOOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x2CE2300", Offset = "0x2CE0F00", VA = "0x182CE2300", Slot = "7")]
	public KAMHGLCAIAM MCCANHAPINF(long KLMDBCIHINB, long ONEELBLPKOK, DJIHHMDOBME BIBCOJPMADN, KJGKHGGPEAN IKLNANFHOOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
internal static class KPKCMOGBLAE
{
	[Cpp2IlInjected.Token(Token = "0x4000683")]
	internal const int CGHCFCPBMBF = 32;

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x365A3E0", Offset = "0x3658FE0", VA = "0x18365A3E0")]
	internal static byte[] KAIGGKCGPBK(byte[] FCLGIGIIKEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x365A360", Offset = "0x3658F60", VA = "0x18365A360")]
	public static void BIBDIDEAINL(Stream LBBCPGHIOFP, byte[] IMCJLPIKHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x365A180", Offset = "0x3658D80", VA = "0x18365A180")]
	public static bool AFIAEBHMIAF(Stream LBBCPGHIOFP, long BFGOLIKKOMB, NGKFOJFFACM OLDMMJOCIMH, out byte[] JLNLLGNKMID)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000189")]
internal sealed class OCNPEHCILAL : KAMHGLCAIAM, IEquatable<KAMHGLCAIAM>, IEquatable<OCNPEHCILAL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000684")]
	private readonly EHHAJMJGMAP NMBKODNEDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000685")]
	public readonly FileInfo GALCJPDLCNF;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public HIKDFNAHKIF AGKCKFKFJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0xE6C620", Offset = "0xE6B220", VA = "0x180E6C620", Slot = "4")]
		get
		{
			return default(HIKDFNAHKIF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public DateTime CAABGPGGFOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x36628F0", Offset = "0x36614F0", VA = "0x1836628F0", Slot = "5")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x3662B00", Offset = "0x3661700", VA = "0x183662B00")]
	public OCNPEHCILAL(EHHAJMJGMAP CFFMDLMPACE, FileInfo LFFKBBPAFAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x3662A50", Offset = "0x3661650", VA = "0x183662A50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x3662990", Offset = "0x3661590", VA = "0x183662990", Slot = "6")]
	public void MBLLADHAPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x3662580", Offset = "0x3661180", VA = "0x183662580", Slot = "7")]
	public bool BJGFHCEICFG(long KLMDBCIHINB, long ONEELBLPKOK, out DJIHHMDOBME BIBCOJPMADN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x36625C0", Offset = "0x36611C0", VA = "0x1836625C0", Slot = "8")]
	public bool Equals(KAMHGLCAIAM GHLMPEGFGCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x36627A0", Offset = "0x36613A0", VA = "0x1836627A0", Slot = "9")]
	public bool Equals(OCNPEHCILAL GHLMPEGFGCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x36626A0", Offset = "0x36612A0", VA = "0x1836626A0", Slot = "0")]
	public override bool Equals(object AOEMDAGAALP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x3662850", Offset = "0x3661450", VA = "0x183662850", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x1E3EE00", Offset = "0x1E3DA00", VA = "0x181E3EE00")]
	public static bool HIPCOIHOPDI(OCNPEHCILAL FLCFFJEGIJG, OCNPEHCILAL DCMBMJJNKGM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x1E3E8C0", Offset = "0x1E3D4C0", VA = "0x181E3E8C0")]
	public static bool AMPJPPMBCJP(OCNPEHCILAL FLCFFJEGIJG, OCNPEHCILAL DCMBMJJNKGM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200018A")]
public delegate void NGKFOJFFACM(BKNFEJMIGDD.EJMLICBONMI MCLLGOIFFGH, string DPNJMDFICMK);
[Cpp2IlInjected.Token(Token = "0x200018B")]
internal interface AJLDIEMBDJM
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	HIKDFNAHKIF AGKCKFKFJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GAODIMMNFDE(long KLMDBCIHINB, long ONEELBLPKOK, KJGKHGGPEAN IKLNANFHOOO, out KAMHGLCAIAM HFFNLDFGIIN);

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<KAMHGLCAIAM> OCCOCGHCHJE(KJGKHGGPEAN IKLNANFHOOO);

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KAMHGLCAIAM MCCANHAPINF(long KLMDBCIHINB, long ONEELBLPKOK, DJIHHMDOBME BIBCOJPMADN, KJGKHGGPEAN IKLNANFHOOO);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200018E")]
public class JKMMEKILHLE
{
	[Cpp2IlInjected.Token(Token = "0x4000687")]
	private static byte[] AGGHFJMNIJN;

	[Cpp2IlInjected.Token(Token = "0x4000688")]
	private static int BFFGPOMCPJB;

	[Cpp2IlInjected.Token(Token = "0x4000689")]
	private static int MBPNPBCPPJJ;

	[Cpp2IlInjected.Token(Token = "0x400068A")]
	private static BigInteger ELICCIFCIHI;

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public JKMMEKILHLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x2CEE700", Offset = "0x2CED300", VA = "0x182CEE700")]
	private static string HIPMGELGEMF(byte[] APLKEMLCGID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x2CEE810", Offset = "0x2CED410", VA = "0x182CEE810")]
	public static string OIADEFGOGFH(byte[] FCLGIGIIKEH, bool ABEBLNADKAB)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200018F")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000190")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400068B")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000191")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
