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
public class KOMEHGHBFPG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2A9E290", Offset = "0x2A9D090", VA = "0x182A9E290")]
	public KOMEHGHBFPG(string GOJKMEMCPDE, Exception CNFPBKCKKEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal class HBDEEFMIINL : IPPKIEIBOFP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct CMHBDDEIJOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public AsyncTaskMethodBuilder<IReadOnlyList<AFNHPMBCFDA>> <>t__builder;

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
		private TaskAwaiter<global::GKICOOLOICJ<AFNHPMBCFDA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x32BA230", Offset = "0x32B9030", VA = "0x1832BA230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x32BA410", Offset = "0x32B9210", VA = "0x1832BA410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct OFLEPFFBCCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AsyncTaskMethodBuilder<IReadOnlyList<DAJNLJJOLEA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private TaskAwaiter<List<DAJNLJJOLEA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x32CAF70", Offset = "0x32C9D70", VA = "0x1832CAF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x32CB130", Offset = "0x32C9F30", VA = "0x1832CB130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	[Preserve]
	public HBDEEFMIINL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2342DA0", Offset = "0x2341BA0", VA = "0x182342DA0", Slot = "4")]
	[AsyncStateMachine(typeof(CMHBDDEIJOC))]
	public Task<IReadOnlyList<AFNHPMBCFDA>> PHKFHPPOMMO(long MOLCFNPABNJ, long PECECCFMGMF, [Optional] CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2342C60", Offset = "0x2341A60", VA = "0x182342C60", Slot = "5")]
	[AsyncStateMachine(typeof(OFLEPFFBCCO))]
	public Task<IReadOnlyList<DAJNLJJOLEA>> OHJFHCOEKEJ(IReadOnlyList<int> DKANGABDHCH, [Optional] CancellationToken GPNLCIOKAPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FPCAMBPEPGC : IEquatable<FPCAMBPEPGC>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int KBDIDPJBBPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	DAJNLJJOLEA CDONJJMLHCE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime BFKOBMJNCMI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	OJFBACJAEIP? GNDCBFEBNHO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	HHPPMLKOCJI? IFBKMOFFNFL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	JPMKOKIPJAL IOAAOIGINFG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<NHOKIGNMHJB> OLHCAOMHKBA();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum JPMKOKIPJAL
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface IPPKIEIBOFP
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<AFNHPMBCFDA>> PHKFHPPOMMO(long MOLCFNPABNJ, long PECECCFMGMF, [Optional] CancellationToken GPNLCIOKAPO);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<DAJNLJJOLEA>> OHJFHCOEKEJ(IReadOnlyList<int> DKANGABDHCH, [Optional] CancellationToken GPNLCIOKAPO);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class JDGLKLJLFFJ
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private sealed class BPDIMNNBMFM : FPCAMBPEPGC, IEquatable<FPCAMBPEPGC>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private struct PFONFKPMKBL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<NHOKIGNMHJB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public BPDIMNNBMFM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BPKJCDGALIE <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<KEBPHEIFBOC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private TaskAwaiter<NHOKIGNMHJB> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x3ED7E10", Offset = "0x3ED6C10", VA = "0x183ED7E10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x3ED81E0", Offset = "0x3ED6FE0", VA = "0x183ED81E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly AFNHPMBCFDA FNHOIGCIDKH;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int KBDIDPJBBPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x688A00", Offset = "0x687800", VA = "0x180688A00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public DAJNLJJOLEA CDONJJMLHCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x65B250", Offset = "0x65A050", VA = "0x18065B250", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime EOLNLLMECDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xE61BE0", Offset = "0xE609E0", VA = "0x180E61BE0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public OJFBACJAEIP? GNDCBFEBNHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x74D1B0", Offset = "0x74BFB0", VA = "0x18074D1B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public HHPPMLKOCJI? IFBKMOFFNFL
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x74D170", Offset = "0x74BF70", VA = "0x18074D170", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public JPMKOKIPJAL IOAAOIGINFG
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6674E0", Offset = "0x6662E0", VA = "0x1806674E0", Slot = "10")]
			get
			{
				return default(JPMKOKIPJAL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x32B9600", Offset = "0x32B8400", VA = "0x1832B9600", Slot = "9")]
		[AsyncStateMachine(typeof(PFONFKPMKBL))]
		public Task<NHOKIGNMHJB> OLHCAOMHKBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x32B9730", Offset = "0x32B8530", VA = "0x1832B9730")]
		public BPDIMNNBMFM(int HCKMPFIABHH, DAJNLJJOLEA AFCCLCENAOE, AFNHPMBCFDA FNHOIGCIDKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x32B9400", Offset = "0x32B8200", VA = "0x1832B9400", Slot = "11")]
		public bool Equals(FPCAMBPEPGC HNOJKNGFFBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x32B9490", Offset = "0x32B8290", VA = "0x1832B9490", Slot = "0")]
		public override bool Equals(object CCPIHKCBGHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x32B9530", Offset = "0x32B8330", VA = "0x1832B9530")]
		private bool GIPIIPCAPGP(BPDIMNNBMFM HNOJKNGFFBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x32B9570", Offset = "0x32B8370", VA = "0x1832B9570", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class JNOIPLGDNDA : FPCAMBPEPGC, IEquatable<FPCAMBPEPGC>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private struct EAJNBJLGBMB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public AsyncTaskMethodBuilder<NHOKIGNMHJB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public JNOIPLGDNDA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private TaskAwaiter<NHOKIGNMHJB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x3ECE970", Offset = "0x3ECD770", VA = "0x183ECE970", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x3ECEBB0", Offset = "0x3ECD9B0", VA = "0x183ECEBB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly JMDHMLDEGBF MMAPAPHFOLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly OJFBACJAEIP FAEIEKDACFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly HHPPMLKOCJI PPDLKJMDGKD;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int KBDIDPJBBPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x32C3020", Offset = "0x32C1E20", VA = "0x1832C3020", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public DAJNLJJOLEA CDONJJMLHCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x32C3160", Offset = "0x32C1F60", VA = "0x1832C3160", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime EOLNLLMECDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x32C2E80", Offset = "0x32C1C80", VA = "0x1832C2E80", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public OJFBACJAEIP? GNDCBFEBNHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x32C3200", Offset = "0x32C2000", VA = "0x1832C3200", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public HHPPMLKOCJI? IFBKMOFFNFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x32C3250", Offset = "0x32C2050", VA = "0x1832C3250", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public JPMKOKIPJAL IOAAOIGINFG
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x65BC40", Offset = "0x65AA40", VA = "0x18065BC40", Slot = "10")]
			get
			{
				return default(JPMKOKIPJAL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x11B0730", Offset = "0x11AF530", VA = "0x1811B0730")]
		public JNOIPLGDNDA(JMDHMLDEGBF DKJPBMEIDDE, OJFBACJAEIP DMNANDOGMGA, HHPPMLKOCJI DLFJMNNDMFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x32C32A0", Offset = "0x32C20A0", VA = "0x1832C32A0", Slot = "9")]
		[AsyncStateMachine(typeof(EAJNBJLGBMB))]
		public Task<NHOKIGNMHJB> OLHCAOMHKBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x32C2F80", Offset = "0x32C1D80", VA = "0x1832C2F80", Slot = "11")]
		public bool Equals(FPCAMBPEPGC HNOJKNGFFBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x32C2ED0", Offset = "0x32C1CD0", VA = "0x1832C2ED0", Slot = "0")]
		public override bool Equals(object CCPIHKCBGHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x32C3070", Offset = "0x32C1E70", VA = "0x1832C3070")]
		private bool GIPIIPCAPGP(JNOIPLGDNDA HNOJKNGFFBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x32C30D0", Offset = "0x32C1ED0", VA = "0x1832C30D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class BEDNHFFJEFB : FPCAMBPEPGC, IEquatable<FPCAMBPEPGC>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct FDEEFCANPMA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public AsyncTaskMethodBuilder<NHOKIGNMHJB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private TaskAwaiter<NHOKIGNMHJB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x3ED0740", Offset = "0x3ECF540", VA = "0x183ED0740", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x3ED0900", Offset = "0x3ECF700", VA = "0x183ED0900", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly DAJNLJJOLEA KCHOGMPJKLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly OJFBACJAEIP FAEIEKDACFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly HHPPMLKOCJI PPDLKJMDGKD;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int KBDIDPJBBPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x32B8CB0", Offset = "0x32B7AB0", VA = "0x1832B8CB0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public DAJNLJJOLEA CDONJJMLHCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x655E10", VA = "0x180657010", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime EOLNLLMECDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x65B5A0", Offset = "0x65A3A0", VA = "0x18065B5A0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public OJFBACJAEIP? GNDCBFEBNHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x32B8EE0", Offset = "0x32B7CE0", VA = "0x1832B8EE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public HHPPMLKOCJI? IFBKMOFFNFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x32B8F30", Offset = "0x32B7D30", VA = "0x1832B8F30", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public JPMKOKIPJAL IOAAOIGINFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x65B5A0", Offset = "0x65A3A0", VA = "0x18065B5A0", Slot = "10")]
			get
			{
				return default(JPMKOKIPJAL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x11B0730", Offset = "0x11AF530", VA = "0x1811B0730")]
		public BEDNHFFJEFB(DAJNLJJOLEA AFCCLCENAOE, OJFBACJAEIP DMNANDOGMGA, HHPPMLKOCJI DLFJMNNDMFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x32B8F80", Offset = "0x32B7D80", VA = "0x1832B8F80", Slot = "9")]
		[AsyncStateMachine(typeof(FDEEFCANPMA))]
		public Task<NHOKIGNMHJB> OLHCAOMHKBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x32B8A20", Offset = "0x32B7820", VA = "0x1832B8A20", Slot = "11")]
		public bool Equals(FPCAMBPEPGC HNOJKNGFFBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x32B8B60", Offset = "0x32B7960", VA = "0x1832B8B60", Slot = "0")]
		public override bool Equals(object CCPIHKCBGHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x32B8E30", Offset = "0x32B7C30", VA = "0x1832B8E30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x32B8D30", Offset = "0x32B7B30", VA = "0x1832B8D30")]
		private bool GIPIIPCAPGP(BEDNHFFJEFB HNOJKNGFFBE)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct DAHGHCLBHNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<IList<FPCAMBPEPGC>> <>t__builder;

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
		public JDGLKLJLFFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private IReadOnlyList<AFNHPMBCFDA> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private TaskAwaiter<IReadOnlyList<AFNHPMBCFDA>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private TaskAwaiter<IReadOnlyList<(int accountId, DAJNLJJOLEA account, AFNHPMBCFDA roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x32BA7D0", Offset = "0x32B95D0", VA = "0x1832BA7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x32BB260", Offset = "0x32BA060", VA = "0x1832BB260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct GPODFOFFAPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, DAJNLJJOLEA account, AFNHPMBCFDA roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public IReadOnlyList<AFNHPMBCFDA> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public JDGLKLJLFFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter<IReadOnlyList<DAJNLJJOLEA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x32BF8F0", Offset = "0x32BE6F0", VA = "0x1832BF8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x32C0270", Offset = "0x32BF070", VA = "0x1832C0270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly BOLJJNKMECH DBKCCAAAEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IPPKIEIBOFP JAFGCFAPHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly HOFBEIMOCLK PCBPAMANKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly global::NBIICPFMMDD<(long, long), IReadOnlyList<AFNHPMBCFDA>> CIMFLJEFAPN;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2346EC0", Offset = "0x2345CC0", VA = "0x182346EC0")]
	[Preserve]
	public JDGLKLJLFFJ([CDAJDCGEMGI(null)] IPPKIEIBOFP DJNJKFOKHDH, [CDAJDCGEMGI(null)] HOFBEIMOCLK MIPHFGDBBHA, [CDAJDCGEMGI(null)] BOLJJNKMECH CDMGLLLPOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2346B60", Offset = "0x2345960", VA = "0x182346B60")]
	[AsyncStateMachine(typeof(DAHGHCLBHNM))]
	public Task<IList<FPCAMBPEPGC>> FOOGCLKOEDG(long MOLCFNPABNJ, long DFGMBHPPELL, bool CIBJAFMGMIK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2346CB0", Offset = "0x2345AB0", VA = "0x182346CB0")]
	private bool ILMPBBOHNIF(DateTime? IIOCMIBPKOJ, long MOLCFNPABNJ, long DFGMBHPPELL, out JMDHMLDEGBF BACNBDCPFIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2346A20", Offset = "0x2345820", VA = "0x182346A20")]
	[AsyncStateMachine(typeof(GPODFOFFAPO))]
	private Task<IReadOnlyList<(int, DAJNLJJOLEA, AFNHPMBCFDA)>> DCLKFIFHCKL(IReadOnlyList<AFNHPMBCFDA> OPAAEBMKPAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HOFBEIMOCLK
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<JMDHMLDEGBF> OJPOONMMHCK;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DLMAJFBMFNE(long MOLCFNPABNJ, long DFGMBHPPELL, LKMGECBKGBM BALDFHIGHBN, AJPLFBMOADO IPKNOBCDJAN);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CPGKDBCEKLP(long MOLCFNPABNJ, long DFGMBHPPELL, out JMDHMLDEGBF BACNBDCPFIB);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FDLNGJBHNCB(long MOLCFNPABNJ, long DFGMBHPPELL, AJPLFBMOADO IPKNOBCDJAN, out JMDHMLDEGBF BACNBDCPFIB);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CDMIBJCAELC(long MOLCFNPABNJ, long DFGMBHPPELL);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal interface HFLPBFAPMMK : PLGHNFIOALA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool JCCBJMJBOCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task PGODLLLKJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JJCFDPCOIAB(Task JJCIEPGHDBG, string EFHGLHADIHC);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal interface IEIIFKOCFKM : PLGHNFIOALA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NHOKIGNMHJB> ODKHPLKJOBN(JMDHMLDEGBF BACNBDCPFIB);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NEAPAAFHMEF(CancellationToken GPNLCIOKAPO);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal interface AOJOFDEEIFK : PLGHNFIOALA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	CNEPFFAJFGO GMPDPCAJCLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FKBALBKJNJJ();

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IEEFJOLNNKH();
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal interface PLGHNFIOALA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ILMEFAAGLOH(BNMEKDBAOON GIGDLICKJEF);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface ALAIHBFAIAD
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan NKAEMMBOILL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan HFEGADFACKK
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan GGMMLMKNGFB
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan ACIKOPGGJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool CNKMDGFJABO
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool KIJEMKCDKHI
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool NHEJHEMHLOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum GJPCHKKJFNE
{
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct KMCFCCDNIEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly long PHDHDONKJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly long PECECCFMGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly GJPCHKKJFNE NKICFHCCMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[CanBeNull]
	public readonly Exception DGMBGDCANEP;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2A9E270", Offset = "0x2A9D070", VA = "0x182A9E270")]
	public KMCFCCDNIEO(long PHDHDONKJIJ, long PECECCFMGMF, GJPCHKKJFNE NKICFHCCMMH, [CanBeNull] Exception DGMBGDCANEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2A9E220", Offset = "0x2A9D020", VA = "0x182A9E220")]
	public static KMCFCCDNIEO ANJHDLDNACK(APEIEEGPGIG GPMKOKBNMCB, GJPCHKKJFNE NKICFHCCMMH, [Optional] Exception DGMBGDCANEP)
	{
		return default(KMCFCCDNIEO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public delegate void AEHHHDFPHCF(KMCFCCDNIEO AEPPKPHGPCI);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface ALADEOKCIJK : PLGHNFIOALA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action HFLDMAMBPDN;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event AEHHHDFPHCF DOLMHGMLLDB;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event AEHHHDFPHCF GFLIGGHHEAF;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event AEHHHDFPHCF BAAJCPOBKCF;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KGEHBIBLNMJ();

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CKFEAHNNLKD(KMCFCCDNIEO AEPPKPHGPCI);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DCPMGJCHAMD(KMCFCCDNIEO AEPPKPHGPCI);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HOHHFAEJMOI(KMCFCCDNIEO AEPPKPHGPCI);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface NEGPONDKAKL : PLGHNFIOALA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task JLLIENFLKLM();

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FHCNBPLELNA();

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JLLAJBPPFDK();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public delegate Task KLBHKFANOAN(HCAOAHLBICC GDMAJNKMCBP, CancellationToken MKDOEIGPNGM);
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal interface ABIMLOAGMPC : PLGHNFIOALA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool HCHGOBOELIH
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OLGFMMAIIGC(KLBHKFANOAN AFIMNNMNIEO);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal interface CHLBMEJKKDL : PLGHNFIOALA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	TaskStatus DJEPMDKIDNG
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JHNNOILKFHO(APEIEEGPGIG JJEJBFBOJLC, CancellationToken OAFNKBHDHDC);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal static class NILNGCDLOHJ
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2AA4610", Offset = "0x2AA3410", VA = "0x182AA4610")]
	public static bool AKHMNMBENGC(this CHLBMEJKKDL KMAKBLPNIPH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface BNMEKDBAOON : BPKJCDGALIE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	CancellationToken BNJEKKHLEJI
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	ELODGKLHEKG EFMLHEELPHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	HCDAFHMBMGC CMLCMGNCNMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	ODGLOMJMEFI JCGCGNPDDLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	JHHHHDEGGMN GNIOAJCHNPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	IIFLENBNAPC JGNNILPHNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	JNPJMBDOPFL HLHMGDDEDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	EBEKBJENPBA MHBPKGOACKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	FAKBOJPCPEP EKICIMCAFFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	HFLPBFAPMMK NIGIFDPOLOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	IEIIFKOCFKM INJJKNCFFBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	ALADEOKCIJK NHKMBMIHGFC
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	NEGPONDKAKL DBJPAJAJPOE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	CHLBMEJKKDL PJMLCEHEEJI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	ABIMLOAGMPC HBLPGJFCBJE
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	JENLDJDLCOI ABFCBMMFBNO
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	DLGIDCPMJNG NOKHCGDMGDD
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	AJGEIEHEPFM EFACKMOCHAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	KKAEGAFPCFN KMEBEIDGANF
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	EEMNNFECFAA PAHCHCNKEGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	JBIKLGIDHCH HHIMENADHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	APCGMHFIDII NGMLOFCBEHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	CJMIEMCMKCI KLOIIAMHEEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	CIHDMMKNLFK FNHHEMKKCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	NMKLOINCMMF JEHNGAALMDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	EEHJOGMMLGK IMNABOMJIHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	AOJOFDEEIFK FGBHHNGDJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	ALAIHBFAIAD HHFLGHDJMHM
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	NEJIOMHPBHD AENAIAGABFL
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	HOFBEIMOCLK CGBGADENLKC
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface JENLDJDLCOI : PLGHNFIOALA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	APCLHDOHCEF HEFJCCLOLGO(Guid HEHOBBBEICN);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AKJLIPOIGHF(Guid HEHOBBBEICN);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KNFHBJLLNPP(Guid HEHOBBBEICN, Task POAGCHANBPG);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EKLMIPLHBIL(Guid HEHOBBBEICN, NHOKIGNMHJB BABMKGHNHBM);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JLLAJBPPFDK(Guid HEHOBBBEICN);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<(NHOKIGNMHJB, Task)> ENHLOOPMFCF(Guid HEHOBBBEICN);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface DLGIDCPMJNG : PLGHNFIOALA, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface AJGEIEHEPFM : PLGHNFIOALA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NKJDICFIBGK(EBIJFBKIDNI GOJKMEMCPDE);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AAOABFKBHAO(EBIJFBKIDNI GOJKMEMCPDE);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<EHJEKJMFKEA> EHJLCHFKKFM(CancellationToken MCEAMJINAKP);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public delegate NHOKIGNMHJB GBKFMODGLAN(NAJNLFAFJGC BNIKFHMNHAE, EHJEKJMFKEA HOLLDENJHAO);
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface KKAEGAFPCFN : PLGHNFIOALA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	APCLHDOHCEF DDOPFOCLBFF(JPBBJDIHKKD MFIGLEKAFJG);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KJFJIOKOPKH(Guid HEHOBBBEICN, Task POAGCHANBPG);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface EEMNNFECFAA : PLGHNFIOALA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NHOKIGNMHJB> PAHCHCNKEGI(NAJNLFAFJGC NIKGDEJFIJN, EHJEKJMFKEA HMMAHJCPLAP, [Optional] KEBPHEIFBOC JGOOMMKAKLL);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface JBIKLGIDHCH : PLGHNFIOALA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BKDHKLDKOEI> JBGENADMHID(GEKJCIHAMFL DIOPAPPIBBL, APEIEEGPGIG JJEJBFBOJLC, CancellationToken GPNLCIOKAPO);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BKDHKLDKOEI DPPNPEOMPNM(APEIEEGPGIG JJEJBFBOJLC, KEBPHEIFBOC DPHNMJDPHKB, long DFGMBHPPELL);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BKDHKLDKOEI FMCNACCGHLA(APEIEEGPGIG JJEJBFBOJLC, ALDCBDNNGDB OBHFKPPDEKH, long DFGMBHPPELL);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BKDHKLDKOEI JGHHBMAPFIG(long PHDHDONKJIJ, long DFGMBHPPELL, string HCJPHBNCMNO, string LPNGHDMHFPE);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface CJMIEMCMKCI : PLGHNFIOALA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NHOKIGNMHJB MEEOKLLANDP(NAJNLFAFJGC BNIKFHMNHAE);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task EJBPGMOBNML(string KCGMDGFIHOJ);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface APCGMHFIDII : PLGHNFIOALA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EBIJFBKIDNI> GFGPONIFKGM(EBIJFBKIDNI NMKJPBEONAN, KFENGNLKFLE CNIOIHPDDOC, CancellationToken GPNLCIOKAPO);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<EBIJFBKIDNI> IFJDKJGHCJL(CancellationToken GPNLCIOKAPO, KFENGNLKFLE CNIOIHPDDOC);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OPMGMKLBION KEOJCOJLNKO(IJNLEAKKLBL NEBBKBEMJIK, GEKJCIHAMFL DIOPAPPIBBL);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OPMGMKLBION ONMIGIKACPH(IJNLEAKKLBL NEBBKBEMJIK, GEKJCIHAMFL DIOPAPPIBBL);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface CIHDMMKNLFK : PLGHNFIOALA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NHOKIGNMHJB EGMCPLOPAOP(NAJNLFAFJGC BNIKFHMNHAE, EHJEKJMFKEA HOLLDENJHAO);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NHOKIGNMHJB ELCHDBNNHEK(NAJNLFAFJGC CBOLEAMMNCK);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NHOKIGNMHJB JGHFIJNBFBI(NAJNLFAFJGC CBOLEAMMNCK);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface NMKLOINCMMF
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IGDPHAMJEFB(IGBEHNFHHGH AHCMKOFADKM);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EPDADJJHGOO(IGBEHNFHHGH AHCMKOFADKM);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NNCNLDKINCK(IGBEHNFHHGH AHCMKOFADKM);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IADJBIJFLMK(IGBEHNFHHGH AHCMKOFADKM);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class IGBEHNFHHGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly APEIEEGPGIG MPNCGPCCGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private Dictionary<string, string> BLIKNJOLMMM;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public global::EHGJMLLEIHA<string> BMFEDNKLCGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x65B250", Offset = "0x65A050", VA = "0x18065B250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6A0580", Offset = "0x69F380", VA = "0x1806A0580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6C4C50", Offset = "0x6C3A50", VA = "0x1806C4C50")]
	public IGBEHNFHHGH(APEIEEGPGIG HBECHKJHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2345670", Offset = "0x2344470", VA = "0x182345670")]
	public IGBEHNFHHGH LIFDJCFHMHM(string CCJNKBLKLDJ, string IGJPNMBCJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x23455F0", Offset = "0x23443F0", VA = "0x1823455F0")]
	public bool FEAGEKGJIPK(out IEnumerable<KeyValuePair<string, string>> HJLJBAIHHDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x20FBEB0", Offset = "0x20FACB0", VA = "0x1820FBEB0")]
	public IGBEHNFHHGH GJMKNPNGCOK(global::EHGJMLLEIHA<string> APDIGEDLLAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface NEJIOMHPBHD
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool OPMLMKIGBJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string KGAPPBPOKBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DIGKIDKMHCP();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CAIAFIMMKBO GCADPDMDGIH(long GNHKIAILMCL);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::MGAKLJPCJIN<JPCHJAOPHGN, JLBACGKCMLP> HEFLMLEHJAC(long GNHKIAILMCL);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::MGAKLJPCJIN<JPCHJAOPHGN, IOFNFGHMKGC> ANBONFBHIFC(long GNHKIAILMCL);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::MGAKLJPCJIN<long, ALDMECCOEFF> MDGEJELNKKP();

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool LMDJMLDEGDH(long GNHKIAILMCL, out string LPNGHDMHFPE, out string HCJPHBNCMNO, out JPCHJAOPHGN NNOMDFKLEJN, out JPCHJAOPHGN DIKDAGBPKJJ);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PJPHHFMFECC(BKDHKLDKOEI NMKJPBEONAN, long GNHKIAILMCL);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<bool> BKAKPKDMFAP(long GNHKIAILMCL, byte[] NNOMDFKLEJN, byte[] DIKDAGBPKJJ, CancellationToken GPNLCIOKAPO);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface BPKJCDGALIE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool AKHMNMBENGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool DOEKGNBKNBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action HFLDMAMBPDN;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event AEHHHDFPHCF DOLMHGMLLDB;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event AEHHHDFPHCF GFLIGGHHEAF;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event AEHHHDFPHCF BAAJCPOBKCF;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FHCNBPLELNA();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<NHOKIGNMHJB> EFJNGODIFMD([Optional][CanBeNull] KEBPHEIFBOC LIBHHACLAEN);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<NHOKIGNMHJB> GHLELIILDIN(NAJNLFAFJGC HANOLPJCOJH);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<NHOKIGNMHJB> OPNMLPJLDAP(int BGKPECJNKFO);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task EJBPGMOBNML(string KCGMDGFIHOJ);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<NHOKIGNMHJB> ODKHPLKJOBN(JMDHMLDEGBF DKJPBMEIDDE);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task NEAPAAFHMEF(CancellationToken GPNLCIOKAPO);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface IIFLENBNAPC
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	string EIFMEGKEDIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JKKKEGPBHLA(Scene CGIHLILEHKO);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task PMBBFDIOGBL(PBBNJOEIPIN GJDFJJOIPHP, CancellationToken GPNLCIOKAPO);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface JHHHHDEGGMN
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	HPNHGBDLHHJ JLLPNIPEBHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	int KLDFJECNFFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool JNKCOPGFOFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool CHGCGFOCOEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool BEAHCFOMLAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool PKLEKDODKHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool BBJCOJELLGN
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	NAJNLFAFJGC BBLMEJGPFHD
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ELODGKLHEKG PJDPPEJDOMK(ELODGKLHEKG JHMBJLLFPPI);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HKFMCNMBEEI(ELODGKLHEKG BGLEKJNFDOI);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task BPBFPGLPIPF(GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task OFNBNFEEDPP(CancellationToken GPNLCIOKAPO);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task OBAKGKHKMIA(MHLAFFPOEAP HDEEEPPJEGL, [Optional] CancellationToken GPNLCIOKAPO);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CBIHLLMKOIE(float OEFCMOECHGN);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JIEJEAFHBEN(string NFAIMPDODFD);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IReadOnlyList<BIMAAOFKEJA> EOGEGIGFENB();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IDisposable PLEEGGEJEMD(object NAHJDDBGMOA, BIMAAOFKEJA CCDFIIDBLNP);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "13")]
	JLBACGKCMLP BKMKMFFFHON();

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BAHBLCOHHHI(int FDFIHHPBDKK);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task KMPFABCKCCK();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void FLKKKAJELGD();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool KHOFLGAIHAG();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task MBAJOPFIMDI(CancellationToken GPNLCIOKAPO);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task FMCGNOPGNJK(CancellationToken GPNLCIOKAPO);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<HAHNEFDGINP> NCGGKCCEKHN(DateTime LNNCCINEJFE, CancellationToken GPNLCIOKAPO);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Task<bool> CFIGOKBKOJB(CancellationToken GPNLCIOKAPO);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void INHGLJIHPKH();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "25")]
	KAOKLILBFNH EENFLBHLAKO(CLIMILMGEFO KKAEEEBDAEI, IOFNFGHMKGC OJHDCGLFIGP, IEnumerable<PersistenceView> FBLBBMMKOFA, ref EDCLOMJFAPK LBNDJKJAFLM);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void EOOGCEDBMKD(OGPFCDLOHHL LFLBBPIPFGK, in KAOKLILBFNH PAKEAHNPOIE);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void HDACPOENBDF(IOFNFGHMKGC CNBHMNJLPIE, bool ECBEEOFKIEC);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void OMGFPOMGBEI();

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void EBBLBLCJPAC(long MOLCFNPABNJ, long PECECCFMGMF, KEBPHEIFBOC PPPFAIKANPD, LKMGECBKGBM BALDFHIGHBN);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void GDGLFENFHGE(long MOLCFNPABNJ, long PECECCFMGMF);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void BCGPJLKCAME(PersistenceView EMOBJJMNMCF);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool DEEHEJPNOMK(PersistenceView LFIMBOIOPFD);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool ANDFEHDBNEP(OGPFCDLOHHL LFLBBPIPFGK, FNCCMIGPLFA MGLNHNJLBCH, out CDDJOMAFKBB BOMNCEGFFOH);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void PLBMEBBNNIG();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void EJCEEMGLKHD();

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "36")]
	IDisposable PKEBMFAPFEG();

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void AKPFLNDEPLG(IOFNFGHMKGC CNBHMNJLPIE, FNCCMIGPLFA MGLNHNJLBCH);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<bool> LKALNDOAHPK(HCDAFHMBMGC IPDFOMJPIKI, CancellationToken GPNLCIOKAPO, GEKJCIHAMFL DIOPAPPIBBL);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void IBHJGCIEELP(CancellationToken GPNLCIOKAPO);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<KOAGAKIDHIL> MKFJLJJOJIN(long MOLCFNPABNJ, long PECECCFMGMF, string HCJPHBNCMNO, CPNCAGGGIFF.AKNNMODCGFG GDMAJNKMCBP, CPNCAGGGIFF.AKNNMODCGFG DIKDAGBPKJJ, Dictionary<long, int> ACJMDCAOJJE, int NDBBJPCHMEM, string LMGDIDCGNFH, bool NEENCKNKNDP, int IKLKDMPPLEA);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<ALDCBDNNGDB> GFPIIECGDPA(string LPNGHDMHFPE, long MOLCFNPABNJ, long PECECCFMGMF, string HCJPHBNCMNO, CPNCAGGGIFF.AKNNMODCGFG GDMAJNKMCBP, CPNCAGGGIFF.AKNNMODCGFG DIKDAGBPKJJ, int MFEAAAIIPBH);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<KEBPHEIFBOC> DHNACCAMAPC(long MOLCFNPABNJ, bool NCCIBBNCALG, CancellationToken GPNLCIOKAPO);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool OCLJCOJMCAL();

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool AEMFMKIEEMN();

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "47")]
	GameObject[] ILANACIFFFI(KJLHJDCEJFL[] CKJBPMOIOLL);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void CLOGMABCAKG(List<GameObject> HCDALHOMAOP);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "49")]
	float ICNIFMJHHCN();

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "50")]
	Task<Scene> KMKFAKNHMDC(string OFIBKFPDOOP, LoadSceneMode GBEMNLAHKMP, bool FPJHKLFPJPH, GEKJCIHAMFL APDIGEDLLAL);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void IIENLNIPMOI(APEIEEGPGIG IMNFJKOLNMO);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "52")]
	void DDPDPIDDEOC(string HMMAHJCPLAP, NAJNLFAFJGC NIKGDEJFIJN);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "53")]
	Task KDBMGDIEAFH(GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "54")]
	Task ANPODKBLJKL(GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void MOMMMAOIILB();

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "56")]
	IDisposable LOIKIIGDNOK();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "57")]
	GNFFGMEKIAC GBKDOBJCEAM();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface GNFFGMEKIAC
{
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task IFAPFJHKOPN(CancellationToken GPNLCIOKAPO);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BJDKNEOPLBA(CancellationToken GPNLCIOKAPO);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct KAOKLILBFNH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public HashSet<int> EFGIGCHPPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public IDisposable HBCGEBOPCPD;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x234B1A0", Offset = "0x2349FA0", VA = "0x18234B1A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public enum HAHNEFDGINP : byte
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	No,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface HPNHGBDLHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	APEIEEGPGIG HFGPKALBEGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	KEBPHEIFBOC LLFDMIJACFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	JDDHGPGBFHI DFFDIIIMJPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool CCGGOHKKIIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool GGNNBEJNHOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	int KLDFJECNFFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action DFAPHOBOAJG;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<int> MNMKBFGACKO;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HBFGECEDDPC();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.FKOHHLMAAMD> HNHCKIFHCNL();

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task DHOALPIJBEO();

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	APEIEEGPGIG OFDFCLFAICH();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	LAIENFFFOIL EAELJLJJEBN();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NFALJNDEJOB(long GNHKIAILMCL);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface EEHJOGMMLGK
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KFHMMGDDLFO(out IEnumerable<int> HPOLJLJJPAP);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AFCNOCCHGIK(EABJGGDLAPO MKDOEIGPNGM);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KENEAGOJHPM(EABJGGDLAPO MKDOEIGPNGM);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface OIDMMBOCEPL
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string IOJHNNKECLH(NHOKIGNMHJB MGCHLOMHBGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface ADFHNPGIPFL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BMDLPHPAJMP(AKCEMPFIBHH.LOHECFFOLLM PFPLDJAOGJC);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JLJNILIGELN(AKCEMPFIBHH.LOHECFFOLLM PFPLDJAOGJC);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface JNPJMBDOPFL : ADFHNPGIPFL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NHOKIGNMHJB OIDOBCOMIJO(NAJNLFAFJGC CBOLEAMMNCK);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface EBEKBJENPBA : ADFHNPGIPFL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NHOKIGNMHJB MEEOKLLANDP(NAJNLFAFJGC EKLMBAFFHEO);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface CAIAFIMMKBO
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::BEHELEDFPDP<PBBNJOEIPIN, FOCKIOEBELC>> LKCDPBDCHNJ(string HCJPHBNCMNO, long GNHKIAILMCL, CGCKIHILMNK.JNHPMADDELD CODODFINKNH, CancellationToken GPNLCIOKAPO);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface MGAKLJPCJIN<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::BEHELEDFPDP<byte[], FOCKIOEBELC>> IHANINKCBJB(TGetDataArg FMLMKJHIHMI, CancellationToken GPNLCIOKAPO);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::BEHELEDFPDP<global::DJFLMAPJICG<TData>, FOCKIOEBELC> KNBJNCMAELD(byte[] JANIFNADDOP);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class AALCAFAHNDH : BNMEKDBAOON, BPKJCDGALIE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct KGPNHAGGFHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public AsyncTaskMethodBuilder<NHOKIGNMHJB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AALCAFAHNDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public JMDHMLDEGBF autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TaskAwaiter<NHOKIGNMHJB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2A9D970", Offset = "0x2A9C770", VA = "0x182A9D970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2A9DC10", Offset = "0x2A9CA10", VA = "0x182A9DC10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct PMGGIJFPHOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public AALCAFAHNDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2AABDB0", Offset = "0x2AAABB0", VA = "0x182AABDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class KJLCBGEDHIF : IEnumerable<PLGHNFIOALA>, IEnumerable, IEnumerator<PLGHNFIOALA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private PLGHNFIOALA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public AALCAFAHNDH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		private PLGHNFIOALA System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x754F90", Offset = "0x753D90", VA = "0x180754F90")]
		[DebuggerHidden]
		public KJLCBGEDHIF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2A9DDA0", Offset = "0x2A9CBA0", VA = "0x182A9DDA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E1E0", Offset = "0x2A9CFE0", VA = "0x182A9E1E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E140", Offset = "0x2A9CF40", VA = "0x182A9E140", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PLGHNFIOALA> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E140", Offset = "0x2A9CF40", VA = "0x182A9E140", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly CancellationTokenSource JJGPOADPMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly ELODGKLHEKG BGLEKJNFDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool NNFHDNBGFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private KNNFEEOAAMH JLKINDNGFLD;

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public HCDAFHMBMGC CMLCMGNCNMF
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6570F0", Offset = "0x655EF0", VA = "0x1806570F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7111E0", Offset = "0x70FFE0", VA = "0x1807111E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ODGLOMJMEFI JCGCGNPDDLC
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6570A0", Offset = "0x655EA0", VA = "0x1806570A0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x711130", Offset = "0x70FF30", VA = "0x180711130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public JHHHHDEGGMN GNIOAJCHNPI
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6570D0", Offset = "0x655ED0", VA = "0x1806570D0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x77F290", Offset = "0x77E090", VA = "0x18077F290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public IIFLENBNAPC JGNNILPHNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6570B0", Offset = "0x655EB0", VA = "0x1806570B0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6E7920", Offset = "0x6E6720", VA = "0x1806E7920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public JNPJMBDOPFL HLHMGDDEDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x711340", Offset = "0x710140", VA = "0x180711340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public EBEKBJENPBA MHBPKGOACKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x657040", Offset = "0x655E40", VA = "0x180657040", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6692A0", Offset = "0x6680A0", VA = "0x1806692A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public FAKBOJPCPEP EKICIMCAFFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x657050", Offset = "0x655E50", VA = "0x180657050", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x678820", Offset = "0x677620", VA = "0x180678820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public HFLPBFAPMMK NIGIFDPOLOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x6E78E0", Offset = "0x6E66E0", VA = "0x1806E78E0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x678800", Offset = "0x677600", VA = "0x180678800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public IEIIFKOCFKM INJJKNCFFBE
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x780680", Offset = "0x77F480", VA = "0x180780680", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x780820", Offset = "0x77F620", VA = "0x180780820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public ALADEOKCIJK NHKMBMIHGFC
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x705590", Offset = "0x704390", VA = "0x180705590", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x711920", Offset = "0x710720", VA = "0x180711920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public NEGPONDKAKL DBJPAJAJPOE
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x70BBF0", Offset = "0x70A9F0", VA = "0x18070BBF0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x77FE30", Offset = "0x77EC30", VA = "0x18077FE30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public CHLBMEJKKDL PJMLCEHEEJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x657060", Offset = "0x655E60", VA = "0x180657060", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x678810", Offset = "0x677610", VA = "0x180678810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public ABIMLOAGMPC HBLPGJFCBJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x657070", Offset = "0x655E70", VA = "0x180657070", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887C90", VA = "0x180888E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public JENLDJDLCOI ABFCBMMFBNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x657090", Offset = "0x655E90", VA = "0x180657090", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x888760", Offset = "0x887560", VA = "0x180888760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public DLGIDCPMJNG NOKHCGDMGDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x657080", Offset = "0x655E80", VA = "0x180657080", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x678830", Offset = "0x677630", VA = "0x180678830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public AJGEIEHEPFM EFACKMOCHAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x70B910", Offset = "0x70A710", VA = "0x18070B910", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x70BA60", Offset = "0x70A860", VA = "0x18070BA60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public KKAEGAFPCFN KMEBEIDGANF
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x69EC00", Offset = "0x69DA00", VA = "0x18069EC00", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x70EC10", Offset = "0x70DA10", VA = "0x18070EC10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public EEMNNFECFAA PAHCHCNKEGI
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x70EAE0", Offset = "0x70D8E0", VA = "0x18070EAE0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x70EC20", Offset = "0x70DA20", VA = "0x18070EC20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public JBIKLGIDHCH HHIMENADHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x70EB30", Offset = "0x70D930", VA = "0x18070EB30", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x70EC40", Offset = "0x70DA40", VA = "0x18070EC40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public APCGMHFIDII NGMLOFCBEHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x70F620", Offset = "0x70E420", VA = "0x18070F620", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x70F910", Offset = "0x70E710", VA = "0x18070F910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public CJMIEMCMKCI KLOIIAMHEEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x88A370", Offset = "0x889170", VA = "0x18088A370", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x88A430", Offset = "0x889230", VA = "0x18088A430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public CIHDMMKNLFK FNHHEMKKCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xA6FB10", Offset = "0xA6E910", VA = "0x180A6FB10", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9FF760", Offset = "0x9FE560", VA = "0x1809FF760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public NMKLOINCMMF JEHNGAALMDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7E5FE0", Offset = "0x7E4DE0", VA = "0x1807E5FE0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xF95EC0", Offset = "0xF94CC0", VA = "0x180F95EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public EEHJOGMMLGK IMNABOMJIHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x70F900", Offset = "0x70E700", VA = "0x18070F900", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xECF810", Offset = "0xECE610", VA = "0x180ECF810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public AOJOFDEEIFK FGBHHNGDJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x70B980", Offset = "0x70A780", VA = "0x18070B980", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x12F3510", Offset = "0x12F2310", VA = "0x1812F3510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public ALAIHBFAIAD HHFLGHDJMHM
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x70EB40", Offset = "0x70D940", VA = "0x18070EB40", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x70EC50", Offset = "0x70DA50", VA = "0x18070EC50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public NEJIOMHPBHD AENAIAGABFL
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8F14E0", Offset = "0x8F02E0", VA = "0x1808F14E0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8F0B70", Offset = "0x8EF970", VA = "0x1808F0B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public HOFBEIMOCLK CGBGADENLKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8EF640", Offset = "0x8EE440", VA = "0x1808EF640", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	private bool IFGGLEBPOPK
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x232A8B0", Offset = "0x23296B0", VA = "0x18232A8B0", Slot = "42")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	private bool HIOODMBIJAM
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x232A960", Offset = "0x2329760", VA = "0x18232A960", Slot = "43")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	private CancellationToken LHBKNOBILLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x232A570", Offset = "0x2329370", VA = "0x18232A570", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	private ELODGKLHEKG IGBOJODDOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	private event Action PCEDIHKBBPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x232A850", Offset = "0x2329650", VA = "0x18232A850", Slot = "34")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x232A590", Offset = "0x2329390", VA = "0x18232A590", Slot = "35")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	private event AEHHHDFPHCF EBLPOMAENEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x232AE00", Offset = "0x2329C00", VA = "0x18232AE00", Slot = "36")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x232AB00", Offset = "0x2329900", VA = "0x18232AB00", Slot = "37")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	private event AEHHHDFPHCF LMCLFELJPAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x232B050", Offset = "0x2329E50", VA = "0x18232B050", Slot = "38")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x232A7F0", Offset = "0x23295F0", VA = "0x18232A7F0", Slot = "39")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event AEHHHDFPHCF BPIJENEIJNO
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x232AE60", Offset = "0x2329C60", VA = "0x18232AE60", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x232A450", Offset = "0x2329250", VA = "0x18232A450", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x232B0B0", Offset = "0x2329EB0", VA = "0x18232B0B0")]
	[Preserve]
	internal AALCAFAHNDH([CDAJDCGEMGI(null)] ELODGKLHEKG BGLEKJNFDOI, [CDAJDCGEMGI(null)] HCDAFHMBMGC IPDFOMJPIKI, [CDAJDCGEMGI(null)] ODGLOMJMEFI KDJGFDIPOHI, [CDAJDCGEMGI(null)] JHHHHDEGGMN NFACINHMFIO, [CDAJDCGEMGI(null)] IIFLENBNAPC HOBLNDCKACC, [CDAJDCGEMGI(null)] JNPJMBDOPFL DNIHJGFCFCF, [CDAJDCGEMGI(null)] EBEKBJENPBA MAMECCODHBI, [CDAJDCGEMGI(null)] FAKBOJPCPEP GDIICIICHHB, [CDAJDCGEMGI(null)] HFLPBFAPMMK KJCOGKHMNKJ, [CDAJDCGEMGI(null)] IEIIFKOCFKM DDKJDHNNJGO, [CDAJDCGEMGI(null)] ALADEOKCIJK EMOEAFOOMOP, [CDAJDCGEMGI(null)] NEGPONDKAKL MNLFDJBKOKG, [CDAJDCGEMGI(null)] CHLBMEJKKDL KMAKBLPNIPH, [CDAJDCGEMGI(null)] ABIMLOAGMPC DPOGNJMOHKO, [CDAJDCGEMGI(null)] JENLDJDLCOI OAOBCJBEBBB, [CDAJDCGEMGI(null)] DLGIDCPMJNG NDJIPPPMIAN, [CDAJDCGEMGI(null)] AJGEIEHEPFM LEEAMMCBLCJ, [CDAJDCGEMGI(null)] KKAEGAFPCFN ABGMNIJICLJ, [CDAJDCGEMGI(null)] EEMNNFECFAA IFAJDGKBNMB, [CDAJDCGEMGI(null)] JBIKLGIDHCH ADAKCMAAAFM, [CDAJDCGEMGI(null)] CJMIEMCMKCI GAHBOLPANAG, [CDAJDCGEMGI(null)] APCGMHFIDII KJBGOEIMDGL, [CDAJDCGEMGI(null)] CIHDMMKNLFK PAOPFHIHHOM, [CDAJDCGEMGI(null)] NMKLOINCMMF NMMMEOINFMF, [CDAJDCGEMGI(null)] EEHJOGMMLGK DPBMCDHPFLN, [CDAJDCGEMGI(null)] ALAIHBFAIAD HHBPPIPMCAN, [CDAJDCGEMGI(null)] NEJIOMHPBHD HGGIJDKANHN, [CDAJDCGEMGI(null)] HOFBEIMOCLK LANHIIJBHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x232AB60", Offset = "0x2329960", VA = "0x18232AB60")]
	private void ILMEFAAGLOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x232A660", Offset = "0x2329460", VA = "0x18232A660", Slot = "51")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x232B000", Offset = "0x2329E00", VA = "0x18232B000", Slot = "44")]
	private void MGALMJLEKMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x232A4B0", Offset = "0x23292B0", VA = "0x18232A4B0", Slot = "48")]
	private Task BBILBIDLMOK(string KCGMDGFIHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x232A8C0", Offset = "0x23296C0", VA = "0x18232A8C0", Slot = "45")]
	private Task<NHOKIGNMHJB> GDABLKDAGBA(KEBPHEIFBOC LIBHHACLAEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x232A5F0", Offset = "0x23293F0", VA = "0x18232A5F0", Slot = "46")]
	private Task<NHOKIGNMHJB> DAHILECENBH(NAJNLFAFJGC HANOLPJCOJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x232AEC0", Offset = "0x2329CC0", VA = "0x18232AEC0", Slot = "47")]
	private Task<NHOKIGNMHJB> LJLEGBPBHJB(int BGKPECJNKFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x232ACC0", Offset = "0x2329AC0", VA = "0x18232ACC0", Slot = "49")]
	[AsyncStateMachine(typeof(KGPNHAGGFHC))]
	private Task<NHOKIGNMHJB> JHPBBOFBLJF(JMDHMLDEGBF BACNBDCPFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x232A9E0", Offset = "0x23297E0", VA = "0x18232A9E0", Slot = "50")]
	[AsyncStateMachine(typeof(PMGGIJFPHOO))]
	private Task GLIIIPCIPAL(CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x232AC50", Offset = "0x2329A50", VA = "0x18232AC50")]
	[IteratorStateMachine(typeof(KJLCBGEDHIF))]
	private IEnumerable<PLGHNFIOALA> JGCPLAFDNNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x232AFA0", Offset = "0x2329DA0", VA = "0x18232AFA0")]
	[CompilerGenerated]
	private void MDBPEGNAODF(PLGHNFIOALA AFOPPLDIMJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal class JOEEFAKLMAB : GBMCEFMCKNP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct FANDNOEIJOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public JOEEFAKLMAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x32BDCD0", Offset = "0x32BCAD0", VA = "0x1832BDCD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x32BE050", Offset = "0x32BCE50", VA = "0x1832BE050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly BNMEKDBAOON GIGDLICKJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly JHHHHDEGGMN NFACINHMFIO;

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6E67F0", Offset = "0x6E55F0", VA = "0x1806E67F0")]
	public JOEEFAKLMAB(BNMEKDBAOON GIGDLICKJEF, JHHHHDEGGMN NFACINHMFIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x234A130", Offset = "0x2348F30", VA = "0x18234A130", Slot = "4")]
	[AsyncStateMachine(typeof(FANDNOEIJOD))]
	public Task<bool> BDJBIGDHFBE(CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x234A250", Offset = "0x2349050", VA = "0x18234A250")]
	[CompilerGenerated]
	private object MJINLOCEAGE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal class GNBLLLCJJEC : GBMCEFMCKNP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct GAIDEPFDKKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public GNBLLLCJJEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private float <timeoutTime>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x32BE0A0", Offset = "0x32BCEA0", VA = "0x1832BE0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x32BE6C0", Offset = "0x32BD4C0", VA = "0x1832BE6C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private const float IPAMLBKFDLE = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly BNMEKDBAOON GIGDLICKJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly JHHHHDEGGMN NFACINHMFIO;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	private HPNHGBDLHHJ JLLPNIPEBHB
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x2342B30", Offset = "0x2341930", VA = "0x182342B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6E67F0", Offset = "0x6E55F0", VA = "0x1806E67F0")]
	public GNBLLLCJJEC(BNMEKDBAOON GIGDLICKJEF, JHHHHDEGGMN NFACINHMFIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x23429F0", Offset = "0x23417F0", VA = "0x1823429F0", Slot = "4")]
	[AsyncStateMachine(typeof(GAIDEPFDKKK))]
	public Task<bool> BDJBIGDHFBE(CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x2342B80", Offset = "0x2341980", VA = "0x182342B80")]
	[CompilerGenerated]
	private object MDPMNKJOIFK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal class PGKCCJNLCLD : GBMCEFMCKNP
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class PPOPGHMPHKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public PGKCCJNLCLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public Matchmaking.FKOHHLMAAMD result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public APEIEEGPGIG newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public PPOPGHMPHKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3ED8B80", Offset = "0x3ED7980", VA = "0x183ED8B80")]
		internal object <RunFallback>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3ED8CD0", Offset = "0x3ED7AD0", VA = "0x183ED8CD0")]
		internal object <RunFallback>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3ED8D40", Offset = "0x3ED7B40", VA = "0x183ED8D40")]
		internal object <RunFallback>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct PKBJJIBFAKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public PGKCCJNLCLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private PPOPGHMPHKN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TaskAwaiter<Matchmaking.FKOHHLMAAMD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3ED8230", Offset = "0x3ED7030", VA = "0x183ED8230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3ED8AF0", Offset = "0x3ED78F0", VA = "0x183ED8AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private const float IPAMLBKFDLE = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly BNMEKDBAOON GIGDLICKJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly JHHHHDEGGMN NFACINHMFIO;

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	private HPNHGBDLHHJ JLLPNIPEBHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB550", Offset = "0x2AAA350", VA = "0x182AAB550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6E67F0", Offset = "0x6E55F0", VA = "0x1806E67F0")]
	public PGKCCJNLCLD(BNMEKDBAOON GIGDLICKJEF, JHHHHDEGGMN NFACINHMFIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x2AAB410", Offset = "0x2AAA210", VA = "0x182AAB410", Slot = "4")]
	[AsyncStateMachine(typeof(PKBJJIBFAKK))]
	public Task<bool> BDJBIGDHFBE(CancellationToken GPNLCIOKAPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal interface GBMCEFMCKNP
{
	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> BDJBIGDHFBE(CancellationToken GPNLCIOKAPO);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal struct KPFCBLHDFKP
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class PLONGDIHNGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public BNMEKDBAOON manager;

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public PLONGDIHNGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3ED8B40", Offset = "0x3ED7940", VA = "0x183ED8B40")]
		internal Task <CreateTask>b__0(HCAOAHLBICC data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct NOBCOJGDAEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public KPFCBLHDFKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private JMDHMLDEGBF <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<HAHNEFDGINP> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter<NHOKIGNMHJB> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x32C88E0", Offset = "0x32C76E0", VA = "0x1832C88E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x32C8DF0", Offset = "0x32C7BF0", VA = "0x1832C8DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct JINIDBFFOID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public KPFCBLHDFKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x32C2C50", Offset = "0x32C1A50", VA = "0x1832C2C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly CancellationToken GPNLCIOKAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly BNMEKDBAOON AMENCMGDIEH;

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	private HCDAFHMBMGC CMLCMGNCNMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E440", Offset = "0x2A9D240", VA = "0x182A9E440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private JHHHHDEGGMN GNIOAJCHNPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E780", Offset = "0x2A9D580", VA = "0x182A9E780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	private HPNHGBDLHHJ JLLPNIPEBHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E3C0", Offset = "0x2A9D1C0", VA = "0x182A9E3C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	private IEIIFKOCFKM INJJKNCFFBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E730", Offset = "0x2A9D530", VA = "0x182A9E730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x2A9EA40", Offset = "0x2A9D840", VA = "0x182A9EA40")]
	public KPFCBLHDFKP(CancellationToken GPNLCIOKAPO, BNMEKDBAOON AMENCMGDIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x2A9E310", Offset = "0x2A9D110", VA = "0x182A9E310")]
	public static KLBHKFANOAN APFFIENNDKD(BNMEKDBAOON AMENCMGDIEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x2A9E7D0", Offset = "0x2A9D5D0", VA = "0x182A9E7D0")]
	[AsyncStateMachine(typeof(NOBCOJGDAEF))]
	public Task<bool> LCBCKFDJBHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x2A9E490", Offset = "0x2A9D290", VA = "0x182A9E490")]
	private bool HCJCNABIMKP(out JMDHMLDEGBF BACNBDCPFIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x2A9E630", Offset = "0x2A9D430", VA = "0x182A9E630")]
	[AsyncStateMachine(typeof(JINIDBFFOID))]
	private Task HKLKDAFFHFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x2A9E900", Offset = "0x2A9D700", VA = "0x182A9E900")]
	private Task<HAHNEFDGINP> OJLNBPAAKLI(JMDHMLDEGBF NBBMJECKEDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal struct APCLHDOHCEF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly JENLDJDLCOI OAOBCJBEBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly Guid HEHOBBBEICN;

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	private Task<(NHOKIGNMHJB, Task)> HAENEKGNFHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x232DE70", Offset = "0x232CC70", VA = "0x18232DE70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x1D363E0", Offset = "0x1D351E0", VA = "0x181D363E0")]
	public APCLHDOHCEF(JENLDJDLCOI OAOBCJBEBBB, Guid HEHOBBBEICN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x232DE20", Offset = "0x232CC20", VA = "0x18232DE20")]
	public TaskAwaiter<(NHOKIGNMHJB, Task)> JBNILEFEADI()
	{
		return default(TaskAwaiter<(NHOKIGNMHJB, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x232DD50", Offset = "0x232CB50", VA = "0x18232DD50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal struct LPDBLCHBAPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly TaskCompletionSource<(NHOKIGNMHJB, Task)> KEAADMEGIJB;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Task<(NHOKIGNMHJB, Task)> HAENEKGNFHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2AA0C80", Offset = "0x2A9FA80", VA = "0x182AA0C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x2AA0CC0", Offset = "0x2A9FAC0", VA = "0x182AA0CC0")]
	public LPDBLCHBAPO(TimeSpan AHJIFDNMDHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x2AA0A70", Offset = "0x2A9F870", VA = "0x182AA0A70")]
	public void CAOLCFGIFJD(Task POAGCHANBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x2AA0BA0", Offset = "0x2A9F9A0", VA = "0x182AA0BA0")]
	public void MPCDPKBNEOJ(NHOKIGNMHJB MGCHLOMHBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x2AA0C30", Offset = "0x2A9FA30", VA = "0x182AA0C30")]
	public void NBJDKPFPNPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x2AA0B10", Offset = "0x2A9F910", VA = "0x182AA0B10")]
	internal void EMKJFJIKKFB(string GOJKMEMCPDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[Preserve]
internal class CAFOIEGOANO : HFLPBFAPMMK, PLGHNFIOALA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct LLKEKHBBNKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public CAFOIEGOANO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x2AA0120", Offset = "0x2A9EF20", VA = "0x182AA0120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly EABJGGDLAPO BOKPDPOCBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private string GPAHHAMKBFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private Task HOHPCOPPDNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private BNMEKDBAOON GIGDLICKJEF;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool JCCBJMJBOCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x232F2F0", Offset = "0x232E0F0", VA = "0x18232F2F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Task PGODLLLKJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x232F290", Offset = "0x232E090", VA = "0x18232F290", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6B19E0", Offset = "0x6B07E0", VA = "0x1806B19E0", Slot = "7")]
	public void ILMEFAAGLOH(BNMEKDBAOON GIGDLICKJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x232F320", Offset = "0x232E120", VA = "0x18232F320", Slot = "6")]
	public void JJCFDPCOIAB(Task JJCIEPGHDBG, string EFHGLHADIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x232F160", Offset = "0x232DF60", VA = "0x18232F160")]
	[AsyncStateMachine(typeof(LLKEKHBBNKO))]
	private Task ANEAHOJACHL(Task HFEGBDBKIHO, string EFHGLHADIHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x232F4A0", Offset = "0x232E2A0", VA = "0x18232F4A0")]
	public CAFOIEGOANO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal class LIPHLIFNKBB : AOJOFDEEIFK, PLGHNFIOALA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private bool IIIEHGPKKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private CNEPFFAJFGO OFIGFDBMNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private HCDAFHMBMGC IPDFOMJPIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private ALAIHBFAIAD HHBPPIPMCAN;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public CNEPFFAJFGO GMPDPCAJCLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x2A9F880", Offset = "0x2A9E680", VA = "0x182A9F880", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F8F0", Offset = "0x2A9E6F0", VA = "0x182A9F8F0", Slot = "7")]
	public void ILMEFAAGLOH(BNMEKDBAOON GIGDLICKJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F6C0", Offset = "0x2A9E4C0", VA = "0x182A9F6C0", Slot = "5")]
	public void FKBALBKJNJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F680", Offset = "0x2A9E480", VA = "0x182A9F680", Slot = "6")]
	public void IEEFJOLNNKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x2A9FA70", Offset = "0x2A9E870", VA = "0x182A9FA70")]
	private Task PCOMHCEJGAE(COIBEMMGBIM KIHDPCDCOMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F680", Offset = "0x2A9E480", VA = "0x182A9F680", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public LIPHLIFNKBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal class PFKHIPNHDIJ : ALAIHBFAIAD
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class PKGIIBBJDDF<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private readonly FJOBGIACABI PBAEKLCBBGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private readonly string CCJNKBLKLDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly T OGCEKMMDJKC;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public T AAFFKFKIJDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x6B19D0", Offset = "0x6B07D0", VA = "0x1806B19D0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x6B1A00", Offset = "0x6B0800", VA = "0x1806B1A00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x3064770", Offset = "0x3063570", VA = "0x183064770")]
		public PKGIIBBJDDF(FJOBGIACABI PBAEKLCBBGA, string CCJNKBLKLDJ, T OGCEKMMDJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x3064260", Offset = "0x3063060", VA = "0x183064260")]
		private void FFKLMMFMPKD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly PKGIIBBJDDF<TimeSpan> HAKBLAPAPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly PKGIIBBJDDF<TimeSpan> JOIEGCEIOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly PKGIIBBJDDF<TimeSpan> AKAINCAMKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly PKGIIBBJDDF<TimeSpan> HPAOLKCIILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly PKGIIBBJDDF<bool> PMCEOALCLGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly PKGIIBBJDDF<bool> MBHABDNKNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly PKGIIBBJDDF<bool> FJPIODJJFOG;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public TimeSpan NKAEMMBOILL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x2AAAF50", Offset = "0x2AA9D50", VA = "0x182AAAF50", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public TimeSpan HFEGADFACKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB010", Offset = "0x2AA9E10", VA = "0x182AAB010", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public TimeSpan GGMMLMKNGFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB090", Offset = "0x2AA9E90", VA = "0x182AAB090", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public TimeSpan ACIKOPGGJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB0D0", Offset = "0x2AA9ED0", VA = "0x182AAB0D0", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool CNKMDGFJABO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x2AAAFD0", Offset = "0x2AA9DD0", VA = "0x182AAAFD0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool KIJEMKCDKHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x2AAAF90", Offset = "0x2AA9D90", VA = "0x182AAAF90", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool NHEJHEMHLOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB050", Offset = "0x2AA9E50", VA = "0x182AAB050", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x2AAB110", Offset = "0x2AA9F10", VA = "0x182AAB110")]
	[Preserve]
	public PFKHIPNHDIJ([CDAJDCGEMGI(null)] FJOBGIACABI PBAEKLCBBGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[Preserve]
internal class DJNLJHNGCGI : ALADEOKCIJK, PLGHNFIOALA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class LENIONGFKAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public KMCFCCDNIEO roomEvent;

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public LENIONGFKAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x2A9F1A0", Offset = "0x2A9DFA0", VA = "0x182A9F1A0")]
		internal object <Invoke>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action HFLDMAMBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x2334FF0", Offset = "0x2333DF0", VA = "0x182334FF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x2335090", Offset = "0x2333E90", VA = "0x182335090", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event AEHHHDFPHCF DOLMHGMLLDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x2334C10", Offset = "0x2333A10", VA = "0x182334C10", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x2334CE0", Offset = "0x2333AE0", VA = "0x182334CE0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event AEHHHDFPHCF GFLIGGHHEAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x2334B70", Offset = "0x2333970", VA = "0x182334B70", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x2334930", Offset = "0x2333730", VA = "0x182334930", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event AEHHHDFPHCF BAAJCPOBKCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x23349D0", Offset = "0x23337D0", VA = "0x1823349D0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x2334A70", Offset = "0x2333870", VA = "0x182334A70", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "16")]
	public void ILMEFAAGLOH(BNMEKDBAOON GIGDLICKJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x2334D80", Offset = "0x2333B80", VA = "0x182334D80", Slot = "12")]
	public void KGEHBIBLNMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x2334B10", Offset = "0x2333910", VA = "0x182334B10", Slot = "13")]
	public void CKFEAHNNLKD(KMCFCCDNIEO AEPPKPHGPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x2334B40", Offset = "0x2333940", VA = "0x182334B40", Slot = "14")]
	public void DCPMGJCHAMD(KMCFCCDNIEO AEPPKPHGPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x2334CB0", Offset = "0x2333AB0", VA = "0x182334CB0", Slot = "15")]
	public void HOHHFAEJMOI(KMCFCCDNIEO AEPPKPHGPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x2335130", Offset = "0x2333F30", VA = "0x182335130")]
	private void PFJMFFOKNBK(AEHHHDFPHCF CCDFIIDBLNP, KMCFCCDNIEO AEPPKPHGPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public DJNLJHNGCGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[Preserve]
internal class NDBFDDKPLBC : NEGPONDKAKL, PLGHNFIOALA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct OCBPGPKOHBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public NDBFDDKPLBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x3ED7180", Offset = "0x3ED5F80", VA = "0x183ED7180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private struct LCLPDIFIFMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public NDBFDDKPLBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x3ED44A0", Offset = "0x3ED32A0", VA = "0x183ED44A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class OEMAPBGOALI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public OEMAPBGOALI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3ED75F0", Offset = "0x3ED63F0", VA = "0x183ED75F0")]
		internal object <TryRunFallback>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct JCMHBGEJKLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public NDBFDDKPLBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private OEMAPBGOALI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3ED2670", Offset = "0x3ED1470", VA = "0x183ED2670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3ED2C00", Offset = "0x3ED1A00", VA = "0x183ED2C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class DDPFJLEKHPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public DDPFJLEKHPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3ECE560", Offset = "0x3ECD360", VA = "0x183ECE560")]
		internal object <LogFallbackStart>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private BNMEKDBAOON GIGDLICKJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private JHHHHDEGGMN NFACINHMFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private GBMCEFMCKNP[] LONLIKJDIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private CancellationTokenSource GKECGJILIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private int HALBIMNLAIB;

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3550", Offset = "0x2AA2350", VA = "0x182AA3550", Slot = "7")]
	public void ILMEFAAGLOH(BNMEKDBAOON GIGDLICKJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3160", Offset = "0x2AA1F60", VA = "0x182AA3160", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x2AA35D0", Offset = "0x2AA23D0", VA = "0x182AA35D0", Slot = "6")]
	public void JLLAJBPPFDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x2AA32B0", Offset = "0x2AA20B0", VA = "0x182AA32B0", Slot = "5")]
	public void FHCNBPLELNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3740", Offset = "0x2AA2540", VA = "0x182AA3740", Slot = "4")]
	[AsyncStateMachine(typeof(OCBPGPKOHBE))]
	public Task JLLIENFLKLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x2AA2A30", Offset = "0x2AA1830", VA = "0x182AA2A30")]
	private void AMBBHAAEJKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x2AA2D70", Offset = "0x2AA1B70", VA = "0x182AA2D70")]
	[AsyncStateMachine(typeof(LCLPDIFIFMD))]
	private Task AONMABEKOIL(CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3400", Offset = "0x2AA2200", VA = "0x182AA3400")]
	[AsyncStateMachine(typeof(JCMHBGEJKLG))]
	private Task<bool> HFLEGFLPNDD(int AIPHGHFENPJ, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3850", Offset = "0x2AA2650", VA = "0x182AA3850")]
	private void KEJMCBONGAF(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3170", Offset = "0x2AA1F70", VA = "0x182AA3170")]
	private void FEKNOBJHEII(int AIPHGHFENPJ, bool OHMLJNNHABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x2AA2FB0", Offset = "0x2AA1DB0", VA = "0x182AA2FB0")]
	private void DHELLLECEKO(int AIPHGHFENPJ, Exception KLJBPOILBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x2AA2EA0", Offset = "0x2AA1CA0", VA = "0x182AA2EA0")]
	private void CEBMNHHDPOB(CancellationToken GPNLCIOKAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public NDBFDDKPLBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[Preserve]
internal class OAOKBNLOPLC : ABIMLOAGMPC, PLGHNFIOALA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct NODOBDLJELB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public OAOKBNLOPLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public HCAOAHLBICC roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3ED6890", Offset = "0x3ED5690", VA = "0x183ED6890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class DGEAKBPGKID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public OAOKBNLOPLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public HCAOAHLBICC roomData;

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public DGEAKBPGKID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3ECE8D0", Offset = "0x3ECD6D0", VA = "0x183ECE8D0")]
		internal List<Task> <GetPostLoadTaskGenerator>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct OLBIKPCHMGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public KLBHKFANOAN taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public HCAOAHLBICC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x3ED7AB0", Offset = "0x3ED68B0", VA = "0x183ED7AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct CNJBDHINDAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public OAOKBNLOPLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3ECDDF0", Offset = "0x3ECCBF0", VA = "0x183ECDDF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly HashSet<KLBHKFANOAN> EPMBGNOJINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private ODGLOMJMEFI KDJGFDIPOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private BNMEKDBAOON GIGDLICKJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private BIMAAOFKEJA JNHBFNGJFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private JAHIKDMIHPI BKDEPCPKJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private IDisposable FPCGKPDBOOH;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool HCHGOBOELIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6360", Offset = "0x2AA5160", VA = "0x182AA6360", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	internal Task HAENEKGNFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6840", Offset = "0x2AA5640", VA = "0x182AA6840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6370", Offset = "0x2AA5170", VA = "0x182AA6370", Slot = "6")]
	public void ILMEFAAGLOH(BNMEKDBAOON GIGDLICKJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5E90", Offset = "0x2AA4C90", VA = "0x182AA5E90", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6850", Offset = "0x2AA5650", VA = "0x182AA6850", Slot = "5")]
	public bool OLGFMMAIIGC(KLBHKFANOAN AFIMNNMNIEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6010", Offset = "0x2AA4E10", VA = "0x182AA6010")]
	private void HDAPCEFCOHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6DE0", Offset = "0x2AA5BE0", VA = "0x182AA6DE0")]
	private void PKNEBHPKGGE(HCAOAHLBICC GDMAJNKMCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5EF0", Offset = "0x2AA4CF0", VA = "0x182AA5EF0")]
	[AsyncStateMachine(typeof(NODOBDLJELB))]
	private Task EGKDAFHHAKP(HCAOAHLBICC GDMAJNKMCBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5DB0", Offset = "0x2AA4BB0", VA = "0x182AA5DB0")]
	private Func<CancellationToken, List<Task>> ADKPOGBMBBM(HCAOAHLBICC GDMAJNKMCBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2AA68B0", Offset = "0x2AA56B0", VA = "0x182AA68B0")]
	private List<Task> PFFHAIDOOKD(HCAOAHLBICC GDMAJNKMCBP, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6230", Offset = "0x2AA5030", VA = "0x182AA6230")]
	[AsyncStateMachine(typeof(OLBIKPCHMGA))]
	private Task HKCFJDGDJFO(KLBHKFANOAN CMFIFPKIEBE, HCAOAHLBICC JANIFNADDOP, CancellationToken MKDOEIGPNGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6740", Offset = "0x2AA5540", VA = "0x182AA6740")]
	[AsyncStateMachine(typeof(CNJBDHINDAA))]
	private Task KJBJFGOKAIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6640", Offset = "0x2AA5440", VA = "0x182AA6640")]
	private void JLLAJBPPFDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7060", Offset = "0x2AA5E60", VA = "0x182AA7060")]
	public OAOKBNLOPLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[Preserve]
internal class GGPCPKKFILP : CHLBMEJKKDL, PLGHNFIOALA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct PABCBDLNKKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public APEIEEGPGIG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public GGPCPKKFILP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x32CBF70", Offset = "0x32CAD70", VA = "0x1832CBF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct EBMJGDJJMJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public GGPCPKKFILP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public APEIEEGPGIG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private global::EHGJMLLEIHA<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private KFENGNLKFLE <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private IGBEHNFHHGH <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x32BC900", Offset = "0x32BB700", VA = "0x1832BC900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class BKFBNBEMKMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public Task<BKDHKLDKOEI> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public BKFBNBEMKMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x655E10", VA = "0x180657010")]
		internal Task<BKDHKLDKOEI> <ConnectToRoomAndRunLoadLogic>b__0(GEKJCIHAMFL _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct NPBFEBIDEFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public GGPCPKKFILP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public APEIEEGPGIG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public GEKJCIHAMFL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public KFENGNLKFLE joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private BKFBNBEMKMO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private CJPAOFNIIFD <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private GEKJCIHAMFL <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private CancellationToken <roomCancellationToken>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private OLCAEPENJCG <preOperationProgressTracker>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private CancellationTokenSource <photonJoinedTokenSource>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private CancellationToken <photonJoinedToken>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private Task <roomLoadTask>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private TaskAwaiter<BKDHKLDKOEI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x32C8E40", Offset = "0x32C7C40", VA = "0x1832C8E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private struct CBLMLHCFJIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public GGPCPKKFILP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public GEKJCIHAMFL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private GEKJCIHAMFL <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private GEKJCIHAMFL <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x2A96720", Offset = "0x2A95520", VA = "0x182A96720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private struct EMDNCCEFNLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public GGPCPKKFILP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private ELODGKLHEKG <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x32BD280", Offset = "0x32BC080", VA = "0x1832BD280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct JHPICHDJILK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public GEKJCIHAMFL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public APEIEEGPGIG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public GGPCPKKFILP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public KFENGNLKFLE joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private GEKJCIHAMFL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private TaskAwaiter<IKOPDIJPAKH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x32C2600", Offset = "0x32C1400", VA = "0x1832C2600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class HCPICIFNKKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public APEIEEGPGIG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public HCPICIFNKKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x32C0F00", Offset = "0x32BFD00", VA = "0x1832C0F00")]
		internal object <JoinRoomLoadWithPhoton>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x32C0E00", Offset = "0x32BFC00", VA = "0x1832C0E00")]
		internal string <JoinRoomLoadWithPhoton>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct NPKKBLKMAIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public APEIEEGPGIG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public GGPCPKKFILP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private HCPICIFNKKM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x32CA4B0", Offset = "0x32C92B0", VA = "0x1832CA4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct BAEMEKEONGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public GEKJCIHAMFL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public GGPCPKKFILP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public KFENGNLKFLE joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public BKDHKLDKOEI initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public APEIEEGPGIG targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public CJPAOFNIIFD progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private GEKJCIHAMFL <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x2A94AC0", Offset = "0x2A938C0", VA = "0x182A94AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct AMGECEAEHPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public GEKJCIHAMFL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public GGPCPKKFILP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private GEKJCIHAMFL <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x2A94690", Offset = "0x2A93490", VA = "0x182A94690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct IGPHECOABMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public GGPCPKKFILP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public GEKJCIHAMFL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x32C1590", Offset = "0x32C0390", VA = "0x1832C1590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct OIPEDFPLDOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public GEKJCIHAMFL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public GGPCPKKFILP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private GEKJCIHAMFL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x32CB180", Offset = "0x32C9F80", VA = "0x1832CB180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct NJFOABIHENH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public HCAOAHLBICC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public GGPCPKKFILP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private TaskAwaiter<NHOKIGNMHJB> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x32C7CE0", Offset = "0x32C6AE0", VA = "0x1832C7CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct LOJEAJJNCMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public GGPCPKKFILP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private GEKJCIHAMFL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x32C6200", Offset = "0x32C5000", VA = "0x1832C6200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class BNAOMLDKNPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public APEIEEGPGIG targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public BNAOMLDKNPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x2A95BB0", Offset = "0x2A949B0", VA = "0x182A95BB0")]
		internal object <LogRoomInstance>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class AFDKFCBJNOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public AFDKFCBJNOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x2A93FB0", Offset = "0x2A92DB0", VA = "0x182A93FB0")]
		internal void <LogRoomLoadCancellation>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class NFGHLBIDFKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public APEIEEGPGIG targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public NFGHLBIDFKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x32C7900", Offset = "0x32C6700", VA = "0x1832C7900")]
		internal object <LogRoomLoadFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class ENJMIMADNPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public APEIEEGPGIG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public ENJMIMADNPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x32BDA30", Offset = "0x32BC830", VA = "0x1832BDA30")]
		internal string <LogRoomLoadSuccess>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly string ICKLNAKDJPH;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly string BOLBOJCPJPI;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static readonly string LLIJHFCJNKE;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly Guid KOMPNEGMEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private FAKBOJPCPEP GDIICIICHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private ODGLOMJMEFI KDJGFDIPOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private HCDAFHMBMGC IPDFOMJPIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private BNMEKDBAOON GIGDLICKJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private JHHHHDEGGMN NFACINHMFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private NEGPONDKAKL MNLFDJBKOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private HFLPBFAPMMK KJCOGKHMNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private ALADEOKCIJK EMOEAFOOMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private ALAIHBFAIAD HHBPPIPMCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private IDisposable FPCGKPDBOOH;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public TaskStatus DJEPMDKIDNG
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x88B650", Offset = "0x88A450", VA = "0x18088B650", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x88B660", Offset = "0x88A460", VA = "0x18088B660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private HPNHGBDLHHJ JLLPNIPEBHB
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x233FE00", Offset = "0x233EC00", VA = "0x18233FE00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x23406A0", Offset = "0x233F4A0", VA = "0x1823406A0", Slot = "6")]
	public void ILMEFAAGLOH(BNMEKDBAOON GIGDLICKJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x233F3E0", Offset = "0x233E1E0", VA = "0x18233F3E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x2340BF0", Offset = "0x233F9F0", VA = "0x182340BF0", Slot = "5")]
	[AsyncStateMachine(typeof(PABCBDLNKKM))]
	public Task JHNNOILKFHO(APEIEEGPGIG JJEJBFBOJLC, CancellationToken OAFNKBHDHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x2341150", Offset = "0x233FF50", VA = "0x182341150")]
	[AsyncStateMachine(typeof(EBMJGDJJMJH))]
	private Task LBFFBGIFHHE(APEIEEGPGIG JJEJBFBOJLC, CancellationToken OAFNKBHDHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x233FE50", Offset = "0x233EC50", VA = "0x18233FE50")]
	private static void GOCANIHBNAN(APEIEEGPGIG JJEJBFBOJLC, Exception KLJBPOILBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x2341D00", Offset = "0x2340B00", VA = "0x182341D00")]
	private static void PKDIOHKKCKP(IGBEHNFHHGH JDHMHLBMOOE, Exception KLJBPOILBNM, [Optional] List<int> MNGMOBJPHHK, int HALBIMNLAIB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x2340E70", Offset = "0x233FC70", VA = "0x182340E70")]
	[AsyncStateMachine(typeof(NPBFEBIDEFM))]
	private Task KJNAOAJIICI(GEKJCIHAMFL APDIGEDLLAL, APEIEEGPGIG JJEJBFBOJLC, KFENGNLKFLE MHGPPPJICLB, CancellationToken OAFNKBHDHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x2340D20", Offset = "0x233FB20", VA = "0x182340D20")]
	private void KBDOJDEMKNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x233EDD0", Offset = "0x233DBD0", VA = "0x18233EDD0")]
	[AsyncStateMachine(typeof(CBLMLHCFJIH))]
	private Task COOPJMDOFNH(GEKJCIHAMFL APDIGEDLLAL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x233EF10", Offset = "0x233DD10", VA = "0x18233EF10")]
	private void DJCNEEHMGHJ(APEIEEGPGIG JJEJBFBOJLC, CancellationToken OAFNKBHDHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x23403F0", Offset = "0x233F1F0", VA = "0x1823403F0")]
	private void HHHJCABILOC(APEIEEGPGIG JJEJBFBOJLC, KFENGNLKFLE MHGPPPJICLB, OperationCanceledException NMPECJNCAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x23417B0", Offset = "0x23405B0", VA = "0x1823417B0")]
	private void OPBLIELPCDI(APEIEEGPGIG JJEJBFBOJLC, KFENGNLKFLE MHGPPPJICLB, Exception KLJBPOILBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x2340010", Offset = "0x233EE10", VA = "0x182340010")]
	private void GPLBEHEPJEK(APEIEEGPGIG JJEJBFBOJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x233ED90", Offset = "0x233DB90", VA = "0x18233ED90")]
	private static KMCFCCDNIEO CBKPFBEDCLD(APEIEEGPGIG JJEJBFBOJLC)
	{
		return default(KMCFCCDNIEO);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x2342620", Offset = "0x2341420", VA = "0x182342620")]
	[AsyncStateMachine(typeof(EMDNCCEFNLA))]
	private Task POFPPOOOHNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x2341290", Offset = "0x2340090", VA = "0x182341290")]
	private static IKOPDIJPAKH MIMGKEIOGOP(APEIEEGPGIG JJEJBFBOJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x2340FE0", Offset = "0x233FDE0", VA = "0x182340FE0")]
	[AsyncStateMachine(typeof(JHPICHDJILK))]
	private Task KLNKKAJFDMK(APEIEEGPGIG JJEJBFBOJLC, KFENGNLKFLE MHGPPPJICLB, GEKJCIHAMFL APDIGEDLLAL, CancellationToken IJAKIFIPFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x233F430", Offset = "0x233E230", VA = "0x18233F430")]
	[AsyncStateMachine(typeof(NPKKBLKMAIM))]
	private Task EJBCCMGMGMA(APEIEEGPGIG JJEJBFBOJLC, CancellationTokenSource EKAAJIDDNML, Task EDPGBENBLPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x233FC70", Offset = "0x233EA70", VA = "0x18233FC70")]
	[AsyncStateMachine(typeof(BAEMEKEONGA))]
	private Task FJLPOJNCFLF(BKDHKLDKOEI NFIKFCMLCIF, CJPAOFNIIFD KMIGMOKPKMP, APEIEEGPGIG NLNOBPPJHDN, KFENGNLKFLE JCOBIBENFPG, GEKJCIHAMFL APDIGEDLLAL, CancellationToken BBAAJAJIJEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x233F8F0", Offset = "0x233E6F0", VA = "0x18233F8F0")]
	private KFENGNLKFLE FHEAJBNBJGH(KFENGNLKFLE JCOBIBENFPG, ref CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x233FB30", Offset = "0x233E930", VA = "0x18233FB30")]
	[AsyncStateMachine(typeof(AMGECEAEHPH))]
	private Task FHGIFKLDAFO(GEKJCIHAMFL APDIGEDLLAL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x2341680", Offset = "0x2340480", VA = "0x182341680")]
	[AsyncStateMachine(typeof(IGPHECOABMP))]
	private Task OEBJNNDKKKN(GEKJCIHAMFL APDIGEDLLAL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x233F590", Offset = "0x233E390", VA = "0x18233F590")]
	[AsyncStateMachine(typeof(OIPEDFPLDOP))]
	private Task ELCHPJJKHHI(GEKJCIHAMFL APDIGEDLLAL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x2340A20", Offset = "0x233F820", VA = "0x182340A20")]
	[AsyncStateMachine(typeof(NJFOABIHENH))]
	private Task JCPFOBIILFE(HCAOAHLBICC JANIFNADDOP, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x2341540", Offset = "0x2340340", VA = "0x182341540")]
	[AsyncStateMachine(typeof(LOJEAJJNCMP))]
	private Task OBAKGKHKMIA(GEKJCIHAMFL DIOPAPPIBBL, CancellationToken IJAKIFIPFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x23408B0", Offset = "0x233F6B0", VA = "0x1823408B0")]
	private static void JCEPFPNOJOM(APEIEEGPGIG JJEJBFBOJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x233F6D0", Offset = "0x233E4D0", VA = "0x18233F6D0")]
	private void ENBNDLLOBKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x23414B0", Offset = "0x23402B0", VA = "0x1823414B0")]
	private void NGHJLMPHFHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x2340360", Offset = "0x233F160", VA = "0x182340360")]
	private void HHCLKIFFLMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x2340B60", Offset = "0x233F960", VA = "0x182340B60")]
	private void JFHIJNJHPPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x2341340", Offset = "0x2340140", VA = "0x182341340")]
	private static void MLGJBKOKNIB(APEIEEGPGIG JJEJBFBOJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x23402A0", Offset = "0x233F0A0", VA = "0x1823402A0")]
	private static void HCHNPGMLMEL(APEIEEGPGIG JJEJBFBOJLC, CancellationToken IJAKIFIPFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x233F260", Offset = "0x233E060", VA = "0x18233F260")]
	private static void DKJFCPENAPC(APEIEEGPGIG JJEJBFBOJLC, Exception KLJBPOILBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x2341A60", Offset = "0x2340860", VA = "0x182341A60")]
	private void PDBIHFGLMDE(APEIEEGPGIG JJEJBFBOJLC, Task EDPGBENBLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x2342540", Offset = "0x2341340", VA = "0x182342540")]
	private static void PNAJNCEFIKC(Func<string> IALJJELLBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x2342810", Offset = "0x2341610", VA = "0x182342810")]
	public GGPCPKKFILP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[Preserve]
internal sealed class CDOHPHBBFAG : JENLDJDLCOI, PLGHNFIOALA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class APOGDAEIPPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public APOGDAEIPPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x2A94A60", Offset = "0x2A93860", VA = "0x182A94A60")]
		internal object <Add>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class NILNHOMNMAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public NILNHOMNMAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4660", Offset = "0x2AA3460", VA = "0x182AA4660")]
		internal object <Remove>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private sealed class MIAOOANPEFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public MIAOOANPEFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1A80", Offset = "0x2AA0880", VA = "0x182AA1A80")]
		internal object <Cancel>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class CAMDGLMCIDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public CAMDGLMCIDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x2A96130", Offset = "0x2A94F30", VA = "0x182A96130")]
		internal object <MarkStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class DOBNLDPMACD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public DOBNLDPMACD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x2A983F0", Offset = "0x2A971F0", VA = "0x182A983F0")]
		internal object <MarkFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly Dictionary<Guid, LPDBLCHBAPO> OAOBCJBEBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly TimeSpan KOLGHMCKHAG;

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "10")]
	public void ILMEFAAGLOH(BNMEKDBAOON GIGDLICKJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x232F7A0", Offset = "0x232E5A0", VA = "0x18232F7A0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x232FD00", Offset = "0x232EB00", VA = "0x18232FD00", Slot = "4")]
	public APCLHDOHCEF HEFJCCLOLGO(Guid HEHOBBBEICN)
	{
		return default(APCLHDOHCEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x232F520", Offset = "0x232E320", VA = "0x18232F520", Slot = "5")]
	public bool AKJLIPOIGHF(Guid HEHOBBBEICN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x232FF80", Offset = "0x232ED80", VA = "0x18232FF80", Slot = "8")]
	public bool JLLAJBPPFDK(Guid HEHOBBBEICN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x23301D0", Offset = "0x232EFD0", VA = "0x1823301D0", Slot = "6")]
	public bool KNFHBJLLNPP(Guid HEHOBBBEICN, Task POAGCHANBPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x232F7B0", Offset = "0x232E5B0", VA = "0x18232F7B0", Slot = "7")]
	public bool EKLMIPLHBIL(Guid HEHOBBBEICN, NHOKIGNMHJB MGCHLOMHBGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x232FA00", Offset = "0x232E800", VA = "0x18232FA00", Slot = "9")]
	public Task<(NHOKIGNMHJB, Task)> ENHLOOPMFCF(Guid HEHOBBBEICN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x232FA70", Offset = "0x232E870", VA = "0x18232FA70")]
	private void FMEEFECKFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x2330590", Offset = "0x232F390", VA = "0x182330590")]
	public CDOHPHBBFAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[Preserve]
internal class AJFKEFHMEKP : DLGIDCPMJNG, PLGHNFIOALA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private class DOMOBBIPIJA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private readonly APEIEEGPGIG IMNFJKOLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private readonly CancellationTokenSource GKECGJILIPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public readonly CancellationToken LCAPMDJODNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private bool AIIFHCJIAOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private bool DGKCCECAGMN;

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x2A985D0", Offset = "0x2A973D0", VA = "0x182A985D0")]
		public DOMOBBIPIJA(APEIEEGPGIG IMNFJKOLNMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x2A98480", Offset = "0x2A97280", VA = "0x182A98480")]
		public void JLLAJBPPFDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x2A98450", Offset = "0x2A97250", VA = "0x182A98450", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class CNDNBJCJCIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public COIBEMMGBIM disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public CNDNBJCJCIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x2A97860", Offset = "0x2A96660", VA = "0x182A97860")]
		internal object <OnDisconnectedFromPhotonWhileConnected>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private struct NCINECKCMGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public COIBEMMGBIM disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public AJFKEFHMEKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x2AA26A0", Offset = "0x2AA14A0", VA = "0x182AA26A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class MMJIPGJGLIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public MMJIPGJGLIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1AE0", Offset = "0x2AA08E0", VA = "0x182AA1AE0")]
		internal object <OnPlayerPresenceUpdated>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct DDPFBDEBKFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public AJFKEFHMEKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x2A97940", Offset = "0x2A96740", VA = "0x182A97940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xDD0900", Offset = "0xDCF700", VA = "0x180DD0900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class LKCFMJIKMKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public APEIEEGPGIG newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public LKCFMJIKMKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x2A9FAF0", Offset = "0x2A9E8F0", VA = "0x182A9FAF0")]
		internal object <TryJoinRoomInstance>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x2A9FB90", Offset = "0x2A9E990", VA = "0x182A9FB90")]
		internal object <TryJoinRoomInstance>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x2A9FBD0", Offset = "0x2A9E9D0", VA = "0x182A9FBD0")]
		internal object <TryJoinRoomInstance>b__3()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class OGLOKPIIELK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public OGLOKPIIELK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7640", Offset = "0x2AA6440", VA = "0x182AA7640")]
		internal void <TryJoinRoomInstance>b__1()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private struct FGGHLHNOBDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public APEIEEGPGIG newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public AJFKEFHMEKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private LKCFMJIKMKA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x2A9A400", Offset = "0x2A99200", VA = "0x182A9A400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private ODGLOMJMEFI KDJGFDIPOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private BNMEKDBAOON GIGDLICKJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private NEGPONDKAKL MNLFDJBKOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private JHHHHDEGGMN NFACINHMFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private ALAIHBFAIAD HHBPPIPMCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private CHLBMEJKKDL KMAKBLPNIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private long EIAPOJLLGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private DOMOBBIPIJA MELACFGPDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private bool PPEECPHNLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private Task LDEGAMGPFAB;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private HPNHGBDLHHJ JLLPNIPEBHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x232C7A0", Offset = "0x232B5A0", VA = "0x18232C7A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public bool DGHGIEJOIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x80B7C0", Offset = "0x80A5C0", VA = "0x18080B7C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x232C420", Offset = "0x232B220", VA = "0x18232C420")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x232C7F0", Offset = "0x232B5F0", VA = "0x18232C7F0", Slot = "4")]
	public void ILMEFAAGLOH(BNMEKDBAOON GIGDLICKJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x232C500", Offset = "0x232B300", VA = "0x18232C500", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x232C680", Offset = "0x232B480", VA = "0x18232C680")]
	[AsyncStateMachine(typeof(NCINECKCMGO))]
	private Task EDNCFPMIFOE(COIBEMMGBIM ECJCCGHNOAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x232C210", Offset = "0x232B010", VA = "0x18232C210")]
	private void DFAPHOBOAJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x232CFC0", Offset = "0x232BDC0", VA = "0x18232CFC0")]
	private void MFNDHCJAKBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x232C010", Offset = "0x232AE10", VA = "0x18232C010")]
	private void CAEEJNHPNOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x232D1D0", Offset = "0x232BFD0", VA = "0x18232D1D0")]
	private bool MHIEIMDOJCJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x232D250", Offset = "0x232C050", VA = "0x18232D250")]
	[AsyncStateMachine(typeof(DDPFBDEBKFD))]
	private void MNMKBFGACKO(int BCGICHENIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x232CB50", Offset = "0x232B950", VA = "0x18232CB50")]
	private void KGNIEGGGCAO(out IDisposable POILNJLKNJK, out IDisposable MMIKKBIONIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x232BE90", Offset = "0x232AC90", VA = "0x18232BE90")]
	private bool BLPGPNFDAED(APEIEEGPGIG IMNFJKOLNMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x232CAA0", Offset = "0x232B8A0", VA = "0x18232CAA0")]
	private void JCLMDLHAHGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x232CE90", Offset = "0x232BC90", VA = "0x18232CE90")]
	[AsyncStateMachine(typeof(FGGHLHNOBDM))]
	private Task LBFFBGIFHHE(APEIEEGPGIG IMNFJKOLNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x232D340", Offset = "0x232C140", VA = "0x18232D340")]
	public AJFKEFHMEKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[Preserve]
internal sealed class EKKGKAHACFD : AJGEIEHEPFM, PLGHNFIOALA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct KFCOCKKCPAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public AsyncTaskMethodBuilder<EHJEKJMFKEA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public EKKGKAHACFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private TaskAwaiter<EHJEKJMFKEA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x2A9D6D0", Offset = "0x2A9C4D0", VA = "0x182A9D6D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x2A9D920", Offset = "0x2A9C720", VA = "0x182A9D920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class BJNNKMKPJEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public EBIJFBKIDNI message;

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public BJNNKMKPJEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x2A95B50", Offset = "0x2A94950", VA = "0x182A95B50")]
		internal object <MasterTryStartOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class FGKOGJNHPAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public EBIJFBKIDNI messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public FGKOGJNHPAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B140", Offset = "0x2A99F40", VA = "0x182A9B140")]
		internal object <TryStartOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class EMCDOKJODMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public EBIJFBKIDNI request;

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public EMCDOKJODMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x2A99A10", Offset = "0x2A98810", VA = "0x182A99A10")]
		internal object <RunOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private struct ALNABHHEICG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public EBIJFBKIDNI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public EKKGKAHACFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private TaskAwaiter<IJNLEAKKLBL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x2A94050", Offset = "0x2A92E50", VA = "0x182A94050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class NEAECFFEKPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public EBIJFBKIDNI operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public NEAECFFEKPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x2AA39B0", Offset = "0x2AA27B0", VA = "0x182AA39B0")]
		internal object <RunOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct OMLGHPKHMBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public EBIJFBKIDNI operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public EKKGKAHACFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private KFENGNLKFLE <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private TaskAwaiter<EBIJFBKIDNI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7810", Offset = "0x2AA6610", VA = "0x182AA7810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private struct JCHAHIIOEDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public AsyncTaskMethodBuilder<IJNLEAKKLBL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public EKKGKAHACFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public EBIJFBKIDNI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private KFENGNLKFLE <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private TaskAwaiter<EBIJFBKIDNI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x2A9C730", Offset = "0x2A9B530", VA = "0x182A9C730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x2A9CB80", Offset = "0x2A9B980", VA = "0x182A9CB80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class ENKKKCMMCHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public IJNLEAKKLBL operation;

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public ENKKKCMMCHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x2A99FC0", Offset = "0x2A98DC0", VA = "0x182A99FC0")]
		internal object <RunOperation>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private struct IJGPKFFFNDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public IJNLEAKKLBL operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public EKKGKAHACFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private global::EHGJMLLEIHA<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B9C0", Offset = "0x2A9A7C0", VA = "0x182A9B9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class PMHFCKMKBJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public EBIJFBKIDNI request;

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public PMHFCKMKBJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x2AABF80", Offset = "0x2AAAD80", VA = "0x182AABF80")]
		internal object <TryCreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class CADFPINFIGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public EBIJFBKIDNI request;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public CADFPINFIGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x2A960D0", Offset = "0x2A94ED0", VA = "0x182A960D0")]
		internal object <CreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private BNMEKDBAOON GIGDLICKJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private HFLPBFAPMMK KJCOGKHMNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private KKAEGAFPCFN ABGMNIJICLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private APCGMHFIDII KJBGOEIMDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private HCDAFHMBMGC IPDFOMJPIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private TaskCompletionSource<EHJEKJMFKEA> CMMPCKCEGHA;

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x23384C0", Offset = "0x23372C0", VA = "0x1823384C0", Slot = "7")]
	public void ILMEFAAGLOH(BNMEKDBAOON GIGDLICKJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x2337F80", Offset = "0x2336D80", VA = "0x182337F80", Slot = "6")]
	[AsyncStateMachine(typeof(KFCOCKKCPAB))]
	public Task<EHJEKJMFKEA> EHJLCHFKKFM(CancellationToken MCEAMJINAKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x2338D30", Offset = "0x2337B30", VA = "0x182338D30", Slot = "4")]
	public void NKJDICFIBGK(EBIJFBKIDNI GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x2337B80", Offset = "0x2336980", VA = "0x182337B80", Slot = "5")]
	public void AAOABFKBHAO(EBIJFBKIDNI AMJPDMBJMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x2338810", Offset = "0x2337610", VA = "0x182338810")]
	[AsyncStateMachine(typeof(ALNABHHEICG))]
	private Task MCHFLPKKIDH(EBIJFBKIDNI NMKJPBEONAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x2338340", Offset = "0x2337140", VA = "0x182338340")]
	[AsyncStateMachine(typeof(OMLGHPKHMBD))]
	private Task EPHJGDFCNJM(EBIJFBKIDNI IKCNEHGPIOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x23385A0", Offset = "0x23373A0", VA = "0x1823385A0")]
	[AsyncStateMachine(typeof(JCHAHIIOEDA))]
	private Task<IJNLEAKKLBL> JJOBODDHNHI(EBIJFBKIDNI NMKJPBEONAN, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x23386F0", Offset = "0x23374F0", VA = "0x1823386F0")]
	private KFENGNLKFLE MCDECNDFDEJ(EBIJFBKIDNI CHNJKNKLHMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x2339160", Offset = "0x2337F60", VA = "0x182339160")]
	[AsyncStateMachine(typeof(IJGPKFFFNDM))]
	private Task ONLAJBHLNFK(IJNLEAKKLBL OOLGEBPABAO, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x23380C0", Offset = "0x2336EC0", VA = "0x1823380C0")]
	private IJNLEAKKLBL EIILDCKLNHK(EBIJFBKIDNI NMKJPBEONAN, KFENGNLKFLE CNIOIHPDDOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x1DED790", Offset = "0x1DEC590", VA = "0x181DED790")]
	private T PIKGHDFEAKK<T>(T IGJPNMBCJPK) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x2338940", Offset = "0x2337740", VA = "0x182338940")]
	private IJNLEAKKLBL NJEKLCOHOND(EBIJFBKIDNI NMKJPBEONAN, KFENGNLKFLE CNIOIHPDDOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public EKKGKAHACFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x2338470", Offset = "0x2337270", VA = "0x182338470")]
	[CompilerGenerated]
	private void FOCNOECEKHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[Preserve]
internal sealed class GFLFCIEIAAP : KKAEGAFPCFN, PLGHNFIOALA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class DKMIDDPAGJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public DKMIDDPAGJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x2A98380", Offset = "0x2A97180", VA = "0x182A98380")]
		internal object <OnOperationStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class JKJLINKPPBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public JKJLINKPPBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x2A9CE80", Offset = "0x2A9BC80", VA = "0x182A9CE80")]
		internal object <SendReliableToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private HCDAFHMBMGC IPDFOMJPIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private CIHDMMKNLFK PAOPFHIHHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private AJGEIEHEPFM LEEAMMCBLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private JENLDJDLCOI OAOBCJBEBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	private EEHJOGMMLGK DPBMCDHPFLN;

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x233E2D0", Offset = "0x233D0D0", VA = "0x18233E2D0", Slot = "6")]
	public void ILMEFAAGLOH(BNMEKDBAOON GIGDLICKJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x233D8E0", Offset = "0x233C6E0", VA = "0x18233D8E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x233CB10", Offset = "0x233B910", VA = "0x18233CB10", Slot = "4")]
	public APCLHDOHCEF DDOPFOCLBFF(JPBBJDIHKKD NMKJPBEONAN)
	{
		return default(APCLHDOHCEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x233E740", Offset = "0x233D540", VA = "0x18233E740", Slot = "5")]
	public void KJFJIOKOPKH(Guid HEHOBBBEICN, Task POAGCHANBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x233E9C0", Offset = "0x233D7C0", VA = "0x18233E9C0")]
	private void MINBPELOMLI(byte IFOEKECCJIL, int DNKHIDJJODP, object HGENDMPDIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x233D980", Offset = "0x233C780", VA = "0x18233D980")]
	private void HLFJNOCNPCL(CNBCGACFMCE MMEEGBIBNIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x233D360", Offset = "0x233C160", VA = "0x18233D360")]
	private void DMKIBNDLMMJ(CNBCGACFMCE MMEEGBIBNIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x233D0B0", Offset = "0x233BEB0", VA = "0x18233D0B0")]
	private void DGEGANFDBBK(CNBCGACFMCE MMEEGBIBNIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x233D640", Offset = "0x233C440", VA = "0x18233D640")]
	private NHOKIGNMHJB DOEMBCLPCBL(EBIJFBKIDNI CHNJKNKLHMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x233E080", Offset = "0x233CE80", VA = "0x18233E080")]
	private void HMGMHLNNIGB(EBIJFBKIDNI IKCNEHGPIOF, NHOKIGNMHJB MGCHLOMHBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x233EA90", Offset = "0x233D890", VA = "0x18233EA90")]
	private bool OEMOLBAOKLJ(EBIJFBKIDNI IKCNEHGPIOF, NHOKIGNMHJB MGCHLOMHBGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x233C840", Offset = "0x233B640", VA = "0x18233C840")]
	private bool DDOPFOCLBFF(EBIJFBKIDNI JAMFBFHGPMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x233E440", Offset = "0x233D240", VA = "0x18233E440")]
	private bool KAMEJDLGKEJ(byte IFOEKECCJIL, ExitGames.Client.Photon.Hashtable MMEEGBIBNIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public GFLFCIEIAAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[Preserve]
internal sealed class JDIKIKOGLIG : EEMNNFECFAA, PLGHNFIOALA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class ANKGFMDGEGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public EHJEKJMFKEA operationType;

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public ANKGFMDGEGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x32B85D0", Offset = "0x32B73D0", VA = "0x1832B85D0")]
		internal object <RequestOperation>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private struct KFJHDFNJLII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public AsyncTaskMethodBuilder<NHOKIGNMHJB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public EHJEKJMFKEA operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public JDIKIKOGLIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public NAJNLFAFJGC player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public KEBPHEIFBOC detailsToReload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private TaskAwaiter<NHOKIGNMHJB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x32C3500", Offset = "0x32C2300", VA = "0x1832C3500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x32C3A90", Offset = "0x32C2890", VA = "0x1832C3A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	private sealed class AFMKBDKFPKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public EHJEKJMFKEA operationType;

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public AFMKBDKFPKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x32B7DF0", Offset = "0x32B6BF0", VA = "0x1832B7DF0")]
		internal object <CanLocalPlayerRequestOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class PJEHNDFKDAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public EHJEKJMFKEA operationType;

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public PJEHNDFKDAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x32CCAB0", Offset = "0x32CB8B0", VA = "0x1832CCAB0")]
		internal object <RequestOperationInternal>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x32CCB20", Offset = "0x32CB920", VA = "0x1832CCB20")]
		internal object <RequestOperationInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x32CCB90", Offset = "0x32CB990", VA = "0x1832CCB90")]
		internal object <RequestOperationInternal>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private struct AGLOBNCMNMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public AsyncTaskMethodBuilder<NHOKIGNMHJB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public EHJEKJMFKEA operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public JDIKIKOGLIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public NAJNLFAFJGC player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public KEBPHEIFBOC detailsToReload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private PJEHNDFKDAF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private APCLHDOHCEF <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private NHOKIGNMHJB <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private TaskAwaiter<(NHOKIGNMHJB validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x32B7E60", Offset = "0x32B6C60", VA = "0x1832B7E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x32B8580", Offset = "0x32B7380", VA = "0x1832B8580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class PFKOHAKOJJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public EHJEKJMFKEA operationType;

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public PFKOHAKOJJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x32CCA40", Offset = "0x32CB840", VA = "0x1832CCA40")]
		internal object <CreateOperationRequest>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private JBIKLGIDHCH ADAKCMAAAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private HCDAFHMBMGC IPDFOMJPIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private CIHDMMKNLFK PAOPFHIHHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private KKAEGAFPCFN ABGMNIJICLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private JHHHHDEGGMN NFACINHMFIO;

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x2347610", Offset = "0x2346410", VA = "0x182347610", Slot = "5")]
	public void ILMEFAAGLOH(BNMEKDBAOON GIGDLICKJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x2347970", Offset = "0x2346770", VA = "0x182347970", Slot = "4")]
	[AsyncStateMachine(typeof(KFJHDFNJLII))]
	public Task<NHOKIGNMHJB> PAHCHCNKEGI(NAJNLFAFJGC NIKGDEJFIJN, EHJEKJMFKEA HMMAHJCPLAP, [CanBeNull] KEBPHEIFBOC LIBHHACLAEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x2347710", Offset = "0x2346510", VA = "0x182347710")]
	private bool LAIFFMNPNIL(EHJEKJMFKEA HMMAHJCPLAP, out NHOKIGNMHJB BBLJKOEKFJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x2346FE0", Offset = "0x2345DE0", VA = "0x182346FE0")]
	[AsyncStateMachine(typeof(AGLOBNCMNMM))]
	private Task<NHOKIGNMHJB> ABLNKNCJLIG(NAJNLFAFJGC NIKGDEJFIJN, EHJEKJMFKEA HMMAHJCPLAP, [CanBeNull] KEBPHEIFBOC LIBHHACLAEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x2347150", Offset = "0x2345F50", VA = "0x182347150")]
	internal JPBBJDIHKKD GCEIJAHGMNP(NAJNLFAFJGC NIKGDEJFIJN, EHJEKJMFKEA HMMAHJCPLAP, [CanBeNull] KEBPHEIFBOC LIBHHACLAEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public JDIKIKOGLIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[Preserve]
internal sealed class JNBPLNNELDF : JBIKLGIDHCH, PLGHNFIOALA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private struct MBBFFIBPFFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public AsyncTaskMethodBuilder<BKDHKLDKOEI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public APEIEEGPGIG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public JNBPLNNELDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private TaskAwaiter<KEBPHEIFBOC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x32C64F0", Offset = "0x32C52F0", VA = "0x1832C64F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x32C66D0", Offset = "0x32C54D0", VA = "0x1832C66D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class IENBFCJMBOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public IENBFCJMBOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x32C14E0", Offset = "0x32C02E0", VA = "0x1832C14E0")]
		internal object <GetRoomDetails>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private struct OJJLIAGKDAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public AsyncTaskMethodBuilder<KEBPHEIFBOC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public JNBPLNNELDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public APEIEEGPGIG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private IENBFCJMBOP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private TaskAwaiter<FMJOIGPDDBD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x32CB440", Offset = "0x32CA240", VA = "0x1832CB440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x32CB800", Offset = "0x32CA600", VA = "0x1832CB800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class NCDICMLFAMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public NCDICMLFAMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0xDAFF10", Offset = "0xDAED10", VA = "0x180DAFF10")]
		internal bool <GetRoomDataBlobWithHashForRoomDetails>b__0(JDDHGPGBFHI sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private JHHHHDEGGMN NFACINHMFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private NEJIOMHPBHD HGGIJDKANHN;

	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private static readonly (JPCHJAOPHGN superRoomData, string unityAssetId, JPCHJAOPHGN subRoomData) OANMEINBOIA;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private HPNHGBDLHHJ JLLPNIPEBHB
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x23495E0", Offset = "0x23483E0", VA = "0x1823495E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x2349980", Offset = "0x2348780", VA = "0x182349980", Slot = "8")]
	public void ILMEFAAGLOH(BNMEKDBAOON GIGDLICKJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x2349A10", Offset = "0x2348810", VA = "0x182349A10", Slot = "4")]
	[AsyncStateMachine(typeof(MBBFFIBPFFN))]
	public Task<BKDHKLDKOEI> JBGENADMHID(GEKJCIHAMFL DIOPAPPIBBL, APEIEEGPGIG JJEJBFBOJLC, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x2349800", Offset = "0x2348600", VA = "0x182349800")]
	[AsyncStateMachine(typeof(OJJLIAGKDAK))]
	public Task<KEBPHEIFBOC> IEJOBEMFNIE(APEIEEGPGIG JJEJBFBOJLC, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x2349180", Offset = "0x2347F80", VA = "0x182349180", Slot = "5")]
	public BKDHKLDKOEI DPPNPEOMPNM(APEIEEGPGIG JJEJBFBOJLC, KEBPHEIFBOC DPHNMJDPHKB, long DFGMBHPPELL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x23494D0", Offset = "0x23482D0", VA = "0x1823494D0", Slot = "6")]
	public BKDHKLDKOEI FMCNACCGHLA(APEIEEGPGIG JJEJBFBOJLC, ALDCBDNNGDB OBHFKPPDEKH, long DFGMBHPPELL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x2349B90", Offset = "0x2348990", VA = "0x182349B90", Slot = "7")]
	public BKDHKLDKOEI JGHHBMAPFIG(long PHDHDONKJIJ, long DFGMBHPPELL, string HCJPHBNCMNO, string LPNGHDMHFPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x2349630", Offset = "0x2348430", VA = "0x182349630")]
	private static BKDHKLDKOEI GIIOHPPIFAI(long PHDHDONKJIJ, long DFGMBHPPELL, JPCHJAOPHGN PMDPJJKFBMI, string HCJPHBNCMNO, JPCHJAOPHGN GDMAJNKMCBP, string LPNGHDMHFPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x2349C90", Offset = "0x2348A90", VA = "0x182349C90")]
	private (JPCHJAOPHGN, string, JPCHJAOPHGN) JGINJHLFHJM(APEIEEGPGIG JJEJBFBOJLC, KEBPHEIFBOC DPHNMJDPHKB, long DFGMBHPPELL)
	{
		return default((JPCHJAOPHGN, string, JPCHJAOPHGN));
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public JNBPLNNELDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[Preserve]
internal sealed class NHJHJNLLIKJ : APCGMHFIDII, PLGHNFIOALA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private sealed class FOEBPNGDNMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public EBIJFBKIDNI request;

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public FOEBPNGDNMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x3ED0950", Offset = "0x3ECF750", VA = "0x183ED0950")]
		internal object <MasterSynchronizeRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private struct NPAOPMLCMBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public AsyncTaskMethodBuilder<EBIJFBKIDNI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public EBIJFBKIDNI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public NHJHJNLLIKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public KFENGNLKFLE pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private TaskAwaiter<EBIJFBKIDNI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x3ED6CD0", Offset = "0x3ED5AD0", VA = "0x183ED6CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x3ED7130", Offset = "0x3ED5F30", VA = "0x183ED7130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private struct EDIEAPECGIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public AsyncTaskMethodBuilder<EBIJFBKIDNI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public NHJHJNLLIKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public KFENGNLKFLE pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private TaskAwaiter<PPHEHMBDBKI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x3ECEC00", Offset = "0x3ECDA00", VA = "0x183ECEC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x3ECF1D0", Offset = "0x3ECDFD0", VA = "0x183ECF1D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class NMILFEBBMCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public EBIJFBKIDNI request;

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public NMILFEBBMCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x3ED6830", Offset = "0x3ED5630", VA = "0x183ED6830")]
		internal object <MasterSyncRequestAndValidateResponse>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct KGCOCBMDCEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<EBIJFBKIDNI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public EBIJFBKIDNI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public NHJHJNLLIKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public KFENGNLKFLE pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private FGKKFGNDBFI <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private BDFPHCNKEIF <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter<PPHEHMBDBKI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x3ED2E80", Offset = "0x3ED1C80", VA = "0x183ED2E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x3ED3920", Offset = "0x3ED2720", VA = "0x183ED3920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private HCDAFHMBMGC IPDFOMJPIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private AOJOFDEEIFK FDBKILOGKFB;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private CNEPFFAJFGO GMPDPCAJCLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3CE0", Offset = "0x2AA2AE0", VA = "0x182AA3CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3EF0", Offset = "0x2AA2CF0", VA = "0x182AA3EF0", Slot = "8")]
	public void ILMEFAAGLOH(BNMEKDBAOON GIGDLICKJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3A20", Offset = "0x2AA2820", VA = "0x182AA3A20", Slot = "4")]
	[AsyncStateMachine(typeof(NPAOPMLCMBE))]
	public Task<EBIJFBKIDNI> GFGPONIFKGM(EBIJFBKIDNI NMKJPBEONAN, KFENGNLKFLE CNIOIHPDDOC, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3D90", Offset = "0x2AA2B90", VA = "0x182AA3D90", Slot = "5")]
	[AsyncStateMachine(typeof(EDIEAPECGIG))]
	public Task<EBIJFBKIDNI> IFJDKJGHCJL(CancellationToken GPNLCIOKAPO, KFENGNLKFLE CNIOIHPDDOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3F80", Offset = "0x2AA2D80", VA = "0x182AA3F80", Slot = "6")]
	public OPMGMKLBION KEOJCOJLNKO(IJNLEAKKLBL NEBBKBEMJIK, GEKJCIHAMFL DIOPAPPIBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x2AA4390", Offset = "0x2AA3190", VA = "0x182AA4390", Slot = "7")]
	public OPMGMKLBION ONMIGIKACPH(IJNLEAKKLBL NEBBKBEMJIK, GEKJCIHAMFL DIOPAPPIBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x2AA4210", Offset = "0x2AA3010", VA = "0x182AA4210")]
	[AsyncStateMachine(typeof(KGCOCBMDCEH))]
	private Task<EBIJFBKIDNI> NJHOBMHLJBL(EBIJFBKIDNI NMKJPBEONAN, KFENGNLKFLE CNIOIHPDDOC, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3A10", Offset = "0x2AA2810", VA = "0x182AA3A10")]
	private static byte[] CMPMCFMOJKJ(EBIJFBKIDNI GOJKMEMCPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3B90", Offset = "0x2AA2990", VA = "0x182AA3B90")]
	private static string HCKHALNJDFH(byte[] FMLMKJHIHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public NHJHJNLLIKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[Preserve]
internal sealed class KIMCBLILIAJ : CIHDMMKNLFK, PLGHNFIOALA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	private JNPJMBDOPFL DNIHJGFCFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private HCDAFHMBMGC IPDFOMJPIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	private HFLPBFAPMMK KJCOGKHMNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	private CJMIEMCMKCI GAHBOLPANAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	private JHHHHDEGGMN NFACINHMFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	private CHLBMEJKKDL KMAKBLPNIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	private ABIMLOAGMPC DPOGNJMOHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private ALAIHBFAIAD HHBPPIPMCAN;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private HPNHGBDLHHJ JLLPNIPEBHB
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x234B600", Offset = "0x234A400", VA = "0x18234B600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private static NHOKIGNMHJB HILMDCPEEFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x232DCF0", Offset = "0x232CAF0", VA = "0x18232DCF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x234B650", Offset = "0x234A450", VA = "0x18234B650", Slot = "7")]
	public void ILMEFAAGLOH(BNMEKDBAOON GIGDLICKJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x234B1F0", Offset = "0x2349FF0", VA = "0x18234B1F0", Slot = "4")]
	public NHOKIGNMHJB EGMCPLOPAOP(NAJNLFAFJGC BNIKFHMNHAE, EHJEKJMFKEA HOLLDENJHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x234B380", Offset = "0x234A180", VA = "0x18234B380", Slot = "5")]
	public NHOKIGNMHJB ELCHDBNNHEK(NAJNLFAFJGC CBOLEAMMNCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x234B7B0", Offset = "0x234A5B0", VA = "0x18234B7B0", Slot = "6")]
	public NHOKIGNMHJB JGHFIJNBFBI(NAJNLFAFJGC CBOLEAMMNCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x232DA80", Offset = "0x232C880", VA = "0x18232DA80")]
	private static NHOKIGNMHJB FHAIGMPLCLF(EIIFCLNONEI HDEEEPPJEGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public KIMCBLILIAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public class JDAJHKOPKAE : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x23469E0", Offset = "0x23457E0", VA = "0x1823469E0")]
	public JDAJHKOPKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x1B46D20", Offset = "0x1B45B20", VA = "0x181B46D20")]
	public JDAJHKOPKAE(string GOJKMEMCPDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[Preserve]
internal sealed class EJOIBCFEBLH : IEIIFKOCFKM, PLGHNFIOALA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct MPOAEKIBEDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public AsyncTaskMethodBuilder<NHOKIGNMHJB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public EJOIBCFEBLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public JMDHMLDEGBF autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private global::EHGJMLLEIHA<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private GEKJCIHAMFL <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private GEKJCIHAMFL <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private TaskAwaiter<NHOKIGNMHJB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1B50", Offset = "0x2AA0950", VA = "0x182AA1B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2120", Offset = "0x2AA0F20", VA = "0x182AA2120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct MELPMBFPNEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public EJOIBCFEBLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x2AA0E30", Offset = "0x2A9FC30", VA = "0x182AA0E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct EMPPJNODGLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public EJOIBCFEBLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x2A99A70", Offset = "0x2A98870", VA = "0x182A99A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct BIIFNINCBFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public EJOIBCFEBLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x2A95280", Offset = "0x2A94080", VA = "0x182A95280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct GMLMMJDOCOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public EJOIBCFEBLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public TimeSpan delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B290", Offset = "0x2A9A090", VA = "0x182A9B290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct IOLCHIPPONM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public EJOIBCFEBLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public AJPLFBMOADO autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private global::EHGJMLLEIHA<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x2A9C340", Offset = "0x2A9B140", VA = "0x182A9C340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private static readonly TimeSpan DLINPIBKJDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private HCDAFHMBMGC IPDFOMJPIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private BNMEKDBAOON GIGDLICKJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private JHHHHDEGGMN NFACINHMFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	private APCGMHFIDII KJBGOEIMDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private HFLPBFAPMMK KJCOGKHMNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private ABIMLOAGMPC DPOGNJMOHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private CancellationTokenSource KMFLCPALNNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private Task MFMIFMDLMHE;

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x2337330", Offset = "0x2336130", VA = "0x182337330", Slot = "6")]
	public void ILMEFAAGLOH(BNMEKDBAOON GIGDLICKJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0xE77FA0", Offset = "0xE76DA0", VA = "0x180E77FA0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x23379D0", Offset = "0x23367D0", VA = "0x1823379D0", Slot = "4")]
	[AsyncStateMachine(typeof(MPOAEKIBEDK))]
	public Task<NHOKIGNMHJB> ODKHPLKJOBN(JMDHMLDEGBF BACNBDCPFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x23378B0", Offset = "0x23366B0", VA = "0x1823378B0", Slot = "5")]
	[AsyncStateMachine(typeof(MELPMBFPNEG))]
	public Task NEAPAAFHMEF([Optional] CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0xE77FA0", Offset = "0xE76DA0", VA = "0x180E77FA0")]
	public void GHCBMBPAACE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x23374F0", Offset = "0x23362F0", VA = "0x1823374F0")]
	private HHKEAKPEFHI LPIFKDPKIKL(JMDHMLDEGBF BACNBDCPFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x2336C10", Offset = "0x2335A10", VA = "0x182336C10")]
	[AsyncStateMachine(typeof(EMPPJNODGLF))]
	private Task CJNBDAOPKKO(HCAOAHLBICC KIHDPCDCOMG, CancellationToken OAFNKBHDHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x2336E70", Offset = "0x2335C70", VA = "0x182336E70")]
	[AsyncStateMachine(typeof(BIIFNINCBFC))]
	private Task GIOAFBKLGMA([Optional] CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x2336D40", Offset = "0x2335B40", VA = "0x182336D40")]
	[AsyncStateMachine(typeof(GMLMMJDOCOE))]
	private Task FANINBEEFEM(TimeSpan MKDLMEGBLBI, CancellationToken OAFNKBHDHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x2336F90", Offset = "0x2335D90", VA = "0x182336F90")]
	private Task HOPMPGJKKDJ(AJPLFBMOADO IPKNOBCDJAN, CancellationToken OAFNKBHDHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x2337200", Offset = "0x2336000", VA = "0x182337200")]
	[AsyncStateMachine(typeof(IOLCHIPPONM))]
	private Task IIHCNPJGJHF(AJPLFBMOADO IPKNOBCDJAN, CancellationToken OAFNKBHDHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x23377A0", Offset = "0x23365A0", VA = "0x1823377A0")]
	private bool MEEOKLLANDP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public EJOIBCFEBLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[Preserve]
internal class CPHJFOOGHIP : CJMIEMCMKCI, PLGHNFIOALA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct EOBMEAFOIMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public CPHJFOOGHIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private global::EHGJMLLEIHA<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x2A9A040", Offset = "0x2A98E40", VA = "0x182A9A040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	private EBEKBJENPBA MAMECCODHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	private BNMEKDBAOON GIGDLICKJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	private CIHDMMKNLFK PAOPFHIHHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	private APCGMHFIDII KJBGOEIMDGL;

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x2333090", Offset = "0x2331E90", VA = "0x182333090", Slot = "6")]
	public void ILMEFAAGLOH(BNMEKDBAOON GIGDLICKJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x2332F20", Offset = "0x2331D20", VA = "0x182332F20", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x2332F70", Offset = "0x2331D70", VA = "0x182332F70", Slot = "5")]
	[AsyncStateMachine(typeof(EOBMEAFOIMH))]
	public Task EJBPGMOBNML(string KCGMDGFIHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x23333F0", Offset = "0x23321F0", VA = "0x1823333F0", Slot = "4")]
	public NHOKIGNMHJB MEEOKLLANDP(NAJNLFAFJGC BNIKFHMNHAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x23332B0", Offset = "0x23320B0", VA = "0x1823332B0")]
	private GLLEMFCMOMN MBOEPFKAINI(string KCGMDGFIHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public CPHJFOOGHIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public static class BHIADAHKLDH
{
	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x232ECD0", Offset = "0x232DAD0", VA = "0x18232ECD0")]
	public static void PAKKNBOAJLE(ELODGKLHEKG BGLEKJNFDOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x232E6C0", Offset = "0x232D4C0", VA = "0x18232E6C0")]
	internal static void JLAHDKFMKCF(ELODGKLHEKG BGLEKJNFDOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x232EBF0", Offset = "0x232D9F0", VA = "0x18232EBF0")]
	internal static void NPILKDOHMNA(ELODGKLHEKG BGLEKJNFDOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x232E7A0", Offset = "0x232D5A0", VA = "0x18232E7A0")]
	internal static void KEHDNABJLAL(ELODGKLHEKG BGLEKJNFDOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal class CIOEJJANMAH : global::ILBPGEHAPFC<EBIJFBKIDNI>
{
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class LKIJOHIOJGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public EBIJFBKIDNI message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public LKIJOHIOJGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x2A9FC10", Offset = "0x2A9EA10", VA = "0x182A9FC10")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly CIOEJJANMAH JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private const string JNMPIOOHEDO = "pl";

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x2330650", Offset = "0x232F450", VA = "0x182330650")]
	public ExitGames.Client.Photon.Hashtable DGAMFOBEJMM(EBIJFBKIDNI GOJKMEMCPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x2330C70", Offset = "0x232FA70", VA = "0x182330C70", Slot = "5")]
	protected override void NGKOIINGJHA(EBIJFBKIDNI GOJKMEMCPDE, IDictionary<object, object> JANIFNADDOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x23306D0", Offset = "0x232F4D0", VA = "0x1823306D0", Slot = "6")]
	public override EBIJFBKIDNI HJFKJCGGCHL(IDictionary<object, object> JANIFNADDOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x2330DB0", Offset = "0x232FBB0", VA = "0x182330DB0")]
	private static void PNAJNCEFIKC(string MKJJIEOPNHC, EBIJFBKIDNI GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x2330FB0", Offset = "0x232FDB0", VA = "0x182330FB0")]
	public CIOEJJANMAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x2330920", Offset = "0x232F720", VA = "0x182330920")]
	[CompilerGenerated]
	internal static string KNHPGKDDIBI(BKDHKLDKOEI DEHKKADBBLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public static class AOLNGMHBICD
{
	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public static NHOKIGNMHJB HILMDCPEEFK
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x232DCF0", Offset = "0x232CAF0", VA = "0x18232DCF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x232DA60", Offset = "0x232C860", VA = "0x18232DA60")]
	public static bool CGILKJLBCKL(this NHOKIGNMHJB MGCHLOMHBGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x232DA80", Offset = "0x232C880", VA = "0x18232DA80")]
	public static NHOKIGNMHJB FHAIGMPLCLF(EIIFCLNONEI DDFPLICKPCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x232DCE0", Offset = "0x232CAE0", VA = "0x18232DCE0")]
	public static NHOKIGNMHJB IAOKIHNPAEL(params NHOKIGNMHJB[] AEHJOOJHIJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x232DAE0", Offset = "0x232C8E0", VA = "0x18232DAE0")]
	public static NHOKIGNMHJB HGAPCGCPCMG(IEnumerable<NHOKIGNMHJB> AEHJOOJHIJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x232D7F0", Offset = "0x232C5F0", VA = "0x18232D7F0")]
	public static string CENHFDEGDPM(this NHOKIGNMHJB BBLJKOEKFJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public abstract class AKCEMPFIBHH : ADFHNPGIPFL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public delegate NHOKIGNMHJB LOHECFFOLLM([NotNull] NAJNLFAFJGC CGAKICCGHEL);

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private sealed class CCKJFKIOBIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public NAJNLFAFJGC photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public CCKJFKIOBIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x2A97230", Offset = "0x2A96030", VA = "0x182A97230")]
		internal NHOKIGNMHJB <Validate>b__0(LOHECFFOLLM v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private bool NNFHDNBGFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	protected readonly HashSet<LOHECFFOLLM> ECNIECBEPOA;

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x232D3C0", Offset = "0x232C1C0", VA = "0x18232D3C0", Slot = "4")]
	public void BMDLPHPAJMP(LOHECFFOLLM PFPLDJAOGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x232D470", Offset = "0x232C270", VA = "0x18232D470", Slot = "5")]
	public void JLJNILIGELN(LOHECFFOLLM PFPLDJAOGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x232D420", Offset = "0x232C220", VA = "0x18232D420", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x232D4D0", Offset = "0x232C2D0", VA = "0x18232D4D0")]
	protected NHOKIGNMHJB PIEALGEAKLP(NAJNLFAFJGC CBOLEAMMNCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x232D770", Offset = "0x232C570", VA = "0x18232D770")]
	protected AKCEMPFIBHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public class PLIAAJIOEFD : AKCEMPFIBHH, JNPJMBDOPFL, ADFHNPGIPFL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private sealed class KALMJKMIAEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public NHOKIGNMHJB result;

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public KALMJKMIAEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x3ED2DB0", Offset = "0x3ED1BB0", VA = "0x183ED2DB0")]
		internal object <CanPlayerReload>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x2AABDA0", Offset = "0x2AAABA0", VA = "0x182AABDA0")]
	[Preserve]
	public PLIAAJIOEFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x2AABC20", Offset = "0x2AAAA20", VA = "0x182AABC20", Slot = "8")]
	public NHOKIGNMHJB OIDOBCOMIJO(NAJNLFAFJGC CBOLEAMMNCK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public class KJPJNKDDPFA : AKCEMPFIBHH, EBEKBJENPBA, ADFHNPGIPFL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class LCMHIGPNDIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public NHOKIGNMHJB result;

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public LCMHIGPNDIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x32C5460", Offset = "0x32C4260", VA = "0x1832C5460")]
		internal object <CanPlayerSave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x232D770", Offset = "0x232C570", VA = "0x18232D770")]
	[Preserve]
	public KJPJNKDDPFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x234B9D0", Offset = "0x234A7D0", VA = "0x18234B9D0", Slot = "8")]
	public NHOKIGNMHJB MEEOKLLANDP(NAJNLFAFJGC EKLMBAFFHEO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public enum MHLAFFPOEAP
{
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	Misc,
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	LoadNewRoom,
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	ReloadRoom
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal static class CLMDDHGDDFD
{
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class FMCHKAFOKBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public global::EHGJMLLEIHA<string> timer;

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public FMCHKAFOKBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B1A0", Offset = "0x2A99FA0", VA = "0x182A9B1A0")]
		internal object <PrintTimer>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public const string JLCAJEAHBPF = "START: ";

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public const string IPIICNIFFNE = "END: ";

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x2331650", Offset = "0x2330450", VA = "0x182331650")]
	public static global::EHGJMLLEIHA<string> CAGKCLEOBGF([Optional] string BFFLLNCOKMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x2331940", Offset = "0x2330740", VA = "0x182331940")]
	private static void HJOEDPGCALH(string CCJNKBLKLDJ, LFINMJIEICI APDIGEDLLAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x2331A50", Offset = "0x2330850", VA = "0x182331A50")]
	private static void IFDJHDJBIAL(string CCJNKBLKLDJ, LFINMJIEICI APDIGEDLLAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x23317E0", Offset = "0x23305E0", VA = "0x1823317E0")]
	public static void HCKJHFLFKFG(global::EHGJMLLEIHA<string> APDIGEDLLAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x2331720", Offset = "0x2330520", VA = "0x182331720")]
	public static string DIABADBDECC(EBIJFBKIDNI CHNJKNKLHMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal static class OKFEKODKLDA
{
	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x2AA76E0", Offset = "0x2AA64E0", VA = "0x182AA76E0")]
	public static void KLDCKNMNJLE(this HCDAFHMBMGC IPDFOMJPIKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7800", Offset = "0x2AA6600", VA = "0x182AA7800")]
	public static void PJHDKDNJNOI(this HCDAFHMBMGC IPDFOMJPIKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x2AA76F0", Offset = "0x2AA64F0", VA = "0x182AA76F0")]
	private static void PIEBPKADKKL(this HCDAFHMBMGC IPDFOMJPIKI, bool LNCGKJFEOBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public class JHPCMIAOFBD : LDNNONIOCEP, BKJHIOAPNMM, IMJIHPPIAKO, GOFFGKACLEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	private readonly BKJHIOAPNMM AFKAAAOJFHH;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public NAJNLFAFJGC BBLMEJGPFHD
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x23482F0", Offset = "0x23470F0", VA = "0x1823482F0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public int PCIKNCNKMAB
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x2347ED0", Offset = "0x2346CD0", VA = "0x182347ED0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public int DCFOHDEGGGG
	{
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x23480A0", Offset = "0x2346EA0", VA = "0x1823480A0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool AJPHCAHHDOI
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x6619E0", Offset = "0x6607E0", VA = "0x1806619E0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public int PMGHLBFGNFP
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x6674E0", Offset = "0x6662E0", VA = "0x1806674E0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event NNKDONAICAI.JPFPMNIHBLN OLEIONHDKCP
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event EHHIOMFPLEG ODGPIFNOBEH
	{
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x2347DD0", Offset = "0x2346BD0", VA = "0x182347DD0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x23480F0", Offset = "0x2346EF0", VA = "0x1823480F0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<bool> CJKEPLAHHFO
	{
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<NAJNLFAFJGC> CIKCJACLPAB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action NAILPCFNBHL
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x2347F20", Offset = "0x2346D20", VA = "0x182347F20", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x2348190", Offset = "0x2346F90", VA = "0x182348190", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0xA5A6E0", Offset = "0xA594E0", VA = "0x180A5A6E0")]
	public JHPCMIAOFBD(BKJHIOAPNMM AFKAAAOJFHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x2348340", Offset = "0x2347140", VA = "0x182348340", Slot = "8")]
	public bool NNFCHMIEFJK(byte IFOEKECCJIL, ExitGames.Client.Photon.Hashtable ENMGHICGBNH, PAKHLOGANCK EPALAPHAGOM, SendOptions KLCIFCEAPDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x2348250", Offset = "0x2347050", VA = "0x182348250", Slot = "29")]
	public NAJNLFAFJGC MMHADFICMCJ(int ODLJAAJMJOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x2347FC0", Offset = "0x2346DC0", VA = "0x182347FC0", Slot = "16")]
	public NAJNLFAFJGC DHHCBBGABIF(int BGKPECJNKFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "19")]
	public void JHLEIMMLKJJ(object MKDOEIGPNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "20")]
	public void ACGLGJLEBJL(object MKDOEIGPNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "21")]
	public void CDEILBDPKKG(object MKDOEIGPNGM, bool ILDKLPIPLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x2347E70", Offset = "0x2346C70", VA = "0x182347E70", Slot = "22")]
	public IDisposable BMEDHEKEIKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x65A820", Offset = "0x659620", VA = "0x18065A820", Slot = "23")]
	private bool NAOOHDJEBFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "24")]
	public void CHBHAGGKAIL(StringBuilder ELDCGCPJOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x2348230", Offset = "0x2347030", VA = "0x182348230", Slot = "25")]
	public bool KELOIMMBEPK(bool JHFAGBELEEM, out string EGNBEILEKKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	public void GMJHDICFAGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0xE2AFD0", Offset = "0xE29DD0", VA = "0x180E2AFD0", Slot = "28")]
	public void EJFJBOGOLDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal struct CNBCGACFMCE
{
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public const string JEJMKGICKNN = "v_result";

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public const string GENCAHOPOJN = "oid";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	private readonly IDictionary<object, object> MMEEGBIBNIO;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool PPICPACFBLI
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x79AF80", Offset = "0x799D80", VA = "0x18079AF80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x74C1F0", Offset = "0x74AFF0", VA = "0x18074C1F0")]
	public CNBCGACFMCE(IDictionary<object, object> MMEEGBIBNIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x2332E60", Offset = "0x2331C60", VA = "0x182332E60")]
	public bool KGMJDOAJMIG(out EBIJFBKIDNI GOJKMEMCPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x2332D80", Offset = "0x2331B80", VA = "0x182332D80")]
	public Guid IIMEAJKNLMI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x2332B30", Offset = "0x2331930", VA = "0x182332B30")]
	public NHOKIGNMHJB BLLEONLHDPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x2332C90", Offset = "0x2331A90", VA = "0x182332C90")]
	public static ExitGames.Client.Photon.Hashtable DAKLFHBAJIH(EBIJFBKIDNI GOJKMEMCPDE, NHOKIGNMHJB MGCHLOMHBGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class BHOPMCJDGJF
{
	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x232EF10", Offset = "0x232DD10", VA = "0x18232EF10")]
	public static string LJAACPDHDNC(this APEIEEGPGIG HBECHKJHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x232EE90", Offset = "0x232DC90", VA = "0x18232EE90")]
	public static bool AEOJPDNIGPI(this APEIEEGPGIG HBECHKJHJII)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal struct JAHIKDMIHPI : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private struct EPKKIKNGEED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public JAHIKDMIHPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x32BDB30", Offset = "0x32BC930", VA = "0x1832BDB30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	private readonly CancellationTokenSource GKECGJILIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	private bool NNFHDNBGFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	private Task JJCIEPGHDBG;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool PPICPACFBLI
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x2346010", Offset = "0x2344E10", VA = "0x182346010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	internal Task HAENEKGNFHD
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x2346040", Offset = "0x2344E40", VA = "0x182346040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x23461F0", Offset = "0x2344FF0", VA = "0x1823461F0")]
	public JAHIKDMIHPI(CancellationToken GPNLCIOKAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x23460C0", Offset = "0x2344EC0", VA = "0x1823460C0")]
	[AsyncStateMachine(typeof(EPKKIKNGEED))]
	public Task PALDPPNMEAO(Func<CancellationToken, List<Task>> HJHFPKKJLFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x2345FC0", Offset = "0x2344DC0", VA = "0x182345FC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public readonly struct GHKJEADOBPI<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private struct LJMNAAJHABE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public AsyncTaskMethodBuilder<global::BEHELEDFPDP<global::DJFLMAPJICG<TData>, FOCKIOEBELC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public GEKJCIHAMFL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public global::GHKJEADOBPI<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private GEKJCIHAMFL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private TaskAwaiter<global::BEHELEDFPDP<byte[], FOCKIOEBELC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x2CEC4F0", Offset = "0x2CEB2F0", VA = "0x182CEC4F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x23AE3B0", Offset = "0x23AD1B0", VA = "0x1823AE3B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private readonly global::MGAKLJPCJIN<TGetDataArg, TData> NKIPKAGLJMM;

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x74C1F0", Offset = "0x74AFF0", VA = "0x18074C1F0")]
	internal GHKJEADOBPI(global::MGAKLJPCJIN<TGetDataArg, TData> HADJLLLCKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x21CCF70", Offset = "0x21CBD70", VA = "0x1821CCF70")]
	[AsyncStateMachine(typeof(global::GHKJEADOBPI<, >.LJMNAAJHABE))]
	public Task<global::BEHELEDFPDP<global::DJFLMAPJICG<TData>, FOCKIOEBELC>> FMKCKONFEIA(TGetDataArg FMLMKJHIHMI, string KKIEFDMAMMF, GEKJCIHAMFL APDIGEDLLAL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public static class KJFECOGEKMF
{
	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x1ED6A50", Offset = "0x1ED5850", VA = "0x181ED6A50")]
	public static global::GHKJEADOBPI<TGetDataArg, TData> MIHDEIPKAKJ<TGetDataArg, TData>(global::MGAKLJPCJIN<TGetDataArg, TData> HADJLLLCKOJ)
	{
		return default(global::GHKJEADOBPI<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public class FAKBOJPCPEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private readonly NJPIIIJKOJL PNNNEFJKOAE;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private const string AAEDAOKGNKG = "RL_LastSetOperationState";

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private const string GGJJFGKAFON = "RL_LastLoadedRoomName";

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private const string EDICLALCBOL = "RL_LastLoadedRoomId";

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	private const string ALBBNOIGIPC = "RL_LastLoadedSubroomId";

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private const string DMFFCGCHJJI = "RL_LastRoomLoadStartTime";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private string GICOHKAGHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private long? IGPGGHKPLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private long? OKGGCOIAKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private EAPMGOIGJJL MMCJKKEDEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private long? LFOJBIACCNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private bool AMBDLABLJIJ;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public string PNGHOGFOOMB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public long OPOBLJALCPN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x233A0F0", Offset = "0x2338EF0", VA = "0x18233A0F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public long AOPLNJANPLI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x23399E0", Offset = "0x23387E0", VA = "0x1823399E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public EAPMGOIGJJL EHHKMNPIDBB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x739B20", Offset = "0x738920", VA = "0x180739B20")]
		get
		{
			return default(EAPMGOIGJJL);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x233A000", Offset = "0x2338E00", VA = "0x18233A000")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public long BFPGGJIFMJA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x2339FA0", Offset = "0x2338DA0", VA = "0x182339FA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x233A440", Offset = "0x2339240", VA = "0x18233A440")]
	[Preserve]
	public FAKBOJPCPEP([CDAJDCGEMGI(null)] NJPIIIJKOJL PNNNEFJKOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x2339DF0", Offset = "0x2338BF0", VA = "0x182339DF0")]
	private void CEDOKDMMFKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x2339A40", Offset = "0x2338840", VA = "0x182339A40")]
	public void CCFAOMGKDIC(long MOLCFNPABNJ, long DFGMBHPPELL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x23398F0", Offset = "0x23386F0", VA = "0x1823398F0")]
	public void BIOLJIAKKGE(string NPBFKIBBOBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x233A150", Offset = "0x2338F50", VA = "0x18233A150")]
	public void MFPMPOHEJOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class OPMGMKLBION : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct MNDGJBHCOOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public AsyncTaskMethodBuilder<EBIJFBKIDNI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public EBIJFBKIDNI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public OPMGMKLBION <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private GEKJCIHAMFL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private TaskAwaiter<CCOOCPIGFJB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x3ED50D0", Offset = "0x3ED3ED0", VA = "0x183ED50D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x3ED53E0", Offset = "0x3ED41E0", VA = "0x183ED53E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct EEOPOIMDMPP<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private sealed class GCKBPACCNKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public EBIJFBKIDNI roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public GCKBPACCNKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x3ED09B0", Offset = "0x3ECF7B0", VA = "0x183ED09B0")]
		internal EBIJFBKIDNI <MasterSendAllReceiveBufferedMessage>b__0(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct ELMBINMGLEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public AsyncTaskMethodBuilder<CCOOCPIGFJB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public EBIJFBKIDNI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public OPMGMKLBION <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private FGKKFGNDBFI <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private TaskAwaiter<CCOOCPIGFJB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x3ECFA20", Offset = "0x3ECE820", VA = "0x183ECFA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x3ED01F0", Offset = "0x3ECEFF0", VA = "0x183ED01F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct ABBKHBBFPFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public OPMGMKLBION <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x3ECCBA0", Offset = "0x3ECB9A0", VA = "0x183ECCBA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private sealed class AGOCCLKMDIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public AGOCCLKMDIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x3ECD180", Offset = "0x3ECBF80", VA = "0x183ECD180")]
		internal object <ClearOperationSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private sealed class NFCELEHFNNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public NFCELEHFNNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x3ED5430", Offset = "0x3ED4230", VA = "0x183ED5430")]
		internal object <ClearRoomLoadSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[CompilerGenerated]
	private sealed class DJFMEPJJHII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public DJFMEPJJHII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x3ECE900", Offset = "0x3ECD700", VA = "0x183ECE900")]
		internal object <StartRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private sealed class JGPPCKCOPMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public JGPPCKCOPMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x3ED2CC0", Offset = "0x3ED1AC0", VA = "0x183ED2CC0")]
		internal object <FinishRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[CompilerGenerated]
	private sealed class GNAINPNOPBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public OPMGMKLBION <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public GNAINPNOPBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x3ED1310", Offset = "0x3ED0110", VA = "0x183ED1310")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[CompilerGenerated]
	private sealed class GIPGFFMGGFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public Func<string> stepMessageGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public OPMGMKLBION <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public GIPGFFMGGFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x3ED1070", Offset = "0x3ECFE70", VA = "0x183ED1070")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private static readonly Guid HGIEEALBDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public readonly IJNLEAKKLBL DNDBIJCCHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private readonly CNEPFFAJFGO OINNIBDJDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private readonly IMJIHPPIAKO IPDFOMJPIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	private readonly GOFFGKACLEH IPDHDCELHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	private bool BHBPJACEHFJ;

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA0A0", Offset = "0x2AA8EA0", VA = "0x182AAA0A0")]
	public OPMGMKLBION(IJNLEAKKLBL OOLGEBPABAO, CNEPFFAJFGO OINNIBDJDBL, IMJIHPPIAKO IPDFOMJPIKI, GOFFGKACLEH IPDHDCELHOH, GEKJCIHAMFL DIOPAPPIBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8F00", Offset = "0x2AA7D00", VA = "0x182AA8F00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8F00", Offset = "0x2AA7D00", VA = "0x182AA8F00")]
	public void CPDMEOIAFBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8DB0", Offset = "0x2AA7BB0", VA = "0x182AA8DB0")]
	public void CFDHBGKFAEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9610", Offset = "0x2AA8410", VA = "0x182AA9610")]
	public void HIDADPIBDIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8C30", Offset = "0x2AA7A30", VA = "0x182AA8C30")]
	[AsyncStateMachine(typeof(MNDGJBHCOOL))]
	internal Task<EBIJFBKIDNI> BIABBANHFLA(GEKJCIHAMFL DIOPAPPIBBL, EBIJFBKIDNI CHNJKNKLHMC, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3A10", Offset = "0x2AA2810", VA = "0x182AA3A10")]
	private static byte[] KFBBIKFPHPG<T>(T GOJKMEMCPDE) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x2AD4900", Offset = "0x2AD3700", VA = "0x182AD4900")]
	private static T NOKFIPPCNNK<T>(MessageParser<T> AKEDKNBOIDO, byte[] GOJKMEMCPDE, T CHPNMHOBKHL) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x2AA91D0", Offset = "0x2AA7FD0", VA = "0x182AA91D0")]
	[AsyncStateMachine(typeof(ELMBINMGLEF))]
	private Task<CCOOCPIGFJB> GEKHKJFHGIL(EBIJFBKIDNI CHNJKNKLHMC, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x2AD4620", Offset = "0x2AD3420", VA = "0x182AD4620")]
	[AsyncStateMachine(typeof(NHGLFGCPHOC))]
	internal Task<T> NHCCGNKOBHG<T>(CancellationToken OAFNKBHDHDC, Func<CancellationToken, Task<T>> GHJPKHHPAAH, int KIDBPJKCJMO = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9A00", Offset = "0x2AA8800", VA = "0x182AA9A00")]
	[AsyncStateMachine(typeof(ABBKHBBFPFG))]
	internal Task NHCCGNKOBHG(CancellationToken OAFNKBHDHDC, Func<CancellationToken, Task> GHJPKHHPAAH, int KIDBPJKCJMO = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x2AA90A0", Offset = "0x2AA7EA0", VA = "0x182AA90A0")]
	public EBIJFBKIDNI DCPFDFDMNFO(FGKKFGNDBFI MKLBEFGGNMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9760", Offset = "0x2AA8560", VA = "0x182AA9760")]
	public JBJPDOJJABJ HLPDMEIDOCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9960", Offset = "0x2AA8760", VA = "0x182AA9960")]
	public ICCANIPPKEJ LGADDEENEIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9130", Offset = "0x2AA7F30", VA = "0x182AA9130")]
	public DFAFJMCGHAN EBEGGCBCHGG([Optional] CAINOHGEENI? KEMAOBJDDDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x2AA99D0", Offset = "0x2AA87D0", VA = "0x182AA99D0")]
	public void NFFBOINMHMM(Func<Guid, bool> EHDENJOEBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9B50", Offset = "0x2AA8950", VA = "0x182AA9B50")]
	public void OKKIICHNDFL(Func<Guid, bool> ABEDJBPMAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9480", Offset = "0x2AA8280", VA = "0x182AA9480")]
	public void HALGJJAMHDF(Func<Guid, bool> EHDENJOEBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x2AA89D0", Offset = "0x2AA77D0", VA = "0x182AA89D0")]
	public Guid ALBCGKDDNPA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x2AA97D0", Offset = "0x2AA85D0", VA = "0x182AA97D0")]
	public void IGPMONBKLMJ(Guid ALGKOPADFBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9330", Offset = "0x2AA8130", VA = "0x182AA9330")]
	public void GMJFKJOBCIG(EBIJFBKIDNI EHMADPHKADD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9EB0", Offset = "0x2AA8CB0", VA = "0x182AA9EB0")]
	public void PNAJNCEFIKC(string MLPJOFIPMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9D30", Offset = "0x2AA8B30", VA = "0x182AA9D30")]
	public void PNAJNCEFIKC(Func<string> FFKBDCJNKKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x2AD4AB0", Offset = "0x2AD38B0", VA = "0x182AD4AB0")]
	private T PIKGHDFEAKK<T>(T IGJPNMBCJPK) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8BE0", Offset = "0x2AA79E0", VA = "0x182AA8BE0")]
	public void BDCIECNAGOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x2AD4310", Offset = "0x2AD3110", VA = "0x182AD4310")]
	[CompilerGenerated]
	internal static string ABLELCOGPPA<T>(byte[] HFAIGCGNPJJ, int OOJOJEBMMDP, ref EEOPOIMDMPP<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
internal sealed class FCPODFONILB : IJNLEAKKLBL
{
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[CompilerGenerated]
	private sealed class NJBDGOOIHPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public NJBDGOOIHPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x2AA46C0", Offset = "0x2AA34C0", VA = "0x182AA46C0")]
		internal object <.ctor>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[CompilerGenerated]
	private struct CJJBMNODMIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public FCPODFONILB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public OPMGMKLBION operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private ICCANIPPKEJ <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x2A97310", Offset = "0x2A96110", VA = "0x182A97310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private sealed class KHOBCFKJEAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public LAIENFFFOIL presence;

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public KHOBCFKJEAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x2A9DC60", Offset = "0x2A9CA60", VA = "0x182A9DC60")]
		internal object <GetLocalPlayerPresence>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	private readonly BKDHKLDKOEI NFIKFCMLCIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	private readonly APEIEEGPGIG GIKJCJFOAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private readonly JBIKLGIDHCH ADAKCMAAAFM;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	private const bool GEHDPEPGHJG = false;

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x233AC40", Offset = "0x2339A40", VA = "0x18233AC40")]
	public FCPODFONILB(BKDHKLDKOEI NFIKFCMLCIF, APEIEEGPGIG GIKJCJFOAGP, Guid HEHOBBBEICN, BNMEKDBAOON GIGDLICKJEF, KFENGNLKFLE KKKPILGLMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x233AAF0", Offset = "0x23398F0", VA = "0x18233AAF0", Slot = "8")]
	[AsyncStateMachine(typeof(CJJBMNODMIB))]
	protected override Task NALJOKAAODL(OPMGMKLBION LHKCEHFGEMP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x233A480", Offset = "0x2339280", VA = "0x18233A480")]
	private LAIENFFFOIL EAELJLJJEBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x233A990", Offset = "0x2339790", VA = "0x18233A990")]
	private void LFLHLOMIELN(LAIENFFFOIL MFAMJHCIMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x233A8B0", Offset = "0x23396B0", VA = "0x18233A8B0")]
	private static void JCEPFPNOJOM(APEIEEGPGIG HBECHKJHJII, [Optional] string GOJKMEMCPDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
internal class HHKEAKPEFHI : IJNLEAKKLBL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private struct LCIALGLNOKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public HHKEAKPEFHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public OPMGMKLBION operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private GEKJCIHAMFL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private TaskAwaiter<KEBPHEIFBOC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x32C4DF0", Offset = "0x32C3BF0", VA = "0x1832C4DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private readonly int EILGBIPAPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private readonly JMDHMLDEGBF DKJPBMEIDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public readonly long GGKKKLDOKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public readonly long NCFKFPHKGGI;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x2343030", Offset = "0x2341E30", VA = "0x182343030")]
	public HHKEAKPEFHI(Guid HEHOBBBEICN, BNMEKDBAOON GIGDLICKJEF, KFENGNLKFLE KKKPILGLMJB, int EILGBIPAPDD, JMDHMLDEGBF DKJPBMEIDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x2342EF0", Offset = "0x2341CF0", VA = "0x182342EF0", Slot = "8")]
	[AsyncStateMachine(typeof(LCIALGLNOKJ))]
	protected override Task NALJOKAAODL(OPMGMKLBION LHKCEHFGEMP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
internal abstract class JHNCJDONPDO : IJNLEAKKLBL
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private sealed class LLPLJCINNJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public JHNCJDONPDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public GNFFGMEKIAC playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public LLPLJCINNJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x32C5FF0", Offset = "0x32C4DF0", VA = "0x1832C5FF0")]
		internal Task <RunAsync>b__0(GEKJCIHAMFL postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x32C6030", Offset = "0x32C4E30", VA = "0x1832C6030")]
		internal object <RunAsync>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private struct ONEDLAHCCEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public JHNCJDONPDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public OPMGMKLBION operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private LLPLJCINNJL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x32CB850", Offset = "0x32CA650", VA = "0x1832CB850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private struct JCIFBKOKHOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public GEKJCIHAMFL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public GNFFGMEKIAC playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public JHNCJDONPDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private GEKJCIHAMFL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x32C1DB0", Offset = "0x32C0BB0", VA = "0x1832C1DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x2347D90", Offset = "0x2346B90", VA = "0x182347D90")]
	public JHNCJDONPDO(Guid HEHOBBBEICN, BNMEKDBAOON GIGDLICKJEF, KFENGNLKFLE KKKPILGLMJB, string HBKMPJLDNLB, bool AHBIOOADOFD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x2347C40", Offset = "0x2346A40", VA = "0x182347C40", Slot = "8")]
	[AsyncStateMachine(typeof(ONEDLAHCCEJ))]
	protected override Task NALJOKAAODL(OPMGMKLBION LHKCEHFGEMP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract Task LKPHEFDHMHM(OPMGMKLBION LHKCEHFGEMP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO);

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x2347AE0", Offset = "0x23468E0", VA = "0x182347AE0")]
	[AsyncStateMachine(typeof(JCIFBKOKHOB))]
	private Task AAPPJEOOBCE(IDisposable NPAHFCBFOJA, GNFFGMEKIAC AFGNGJFECDC, GEKJCIHAMFL APDIGEDLLAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
internal class LOJMGHFNGNC : IJNLEAKKLBL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[CompilerGenerated]
	private struct AKFPGOMONDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public LOJMGHFNGNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public OPMGMKLBION operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		private TaskAwaiter<LKMGECBKGBM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x3ECD2F0", Offset = "0x3ECC0F0", VA = "0x183ECD2F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private readonly AJPLFBMOADO IPKNOBCDJAN;

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x2AA09D0", Offset = "0x2A9F7D0", VA = "0x182AA09D0")]
	public LOJMGHFNGNC(Guid HEHOBBBEICN, BNMEKDBAOON GIGDLICKJEF, KFENGNLKFLE KKKPILGLMJB, AJPLFBMOADO IPKNOBCDJAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x2AA07B0", Offset = "0x2A9F5B0", VA = "0x182AA07B0", Slot = "7")]
	protected override string MPIOLDIPGPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x2AA0890", Offset = "0x2A9F690", VA = "0x182AA0890", Slot = "8")]
	[AsyncStateMachine(typeof(AKFPGOMONDH))]
	protected override Task NALJOKAAODL(OPMGMKLBION LHKCEHFGEMP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
internal abstract class IJNLEAKKLBL : DJABOFDMEMI
{
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public delegate Task PKAAEIEPPHL(GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO);

	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private sealed class DOLDLCECIIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public GEKJCIHAMFL operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public IJNLEAKKLBL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public DOLDLCECIIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x32BBDD0", Offset = "0x32BABD0", VA = "0x1832BBDD0")]
		internal Task <Run>b__1(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private sealed class HGKFKLIGGCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public DOLDLCECIIE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public HGKFKLIGGCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x32C1050", Offset = "0x32BFE50", VA = "0x1832C1050")]
		internal object <Run>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x32C1110", Offset = "0x32BFF10", VA = "0x1832C1110")]
		internal object <Run>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private struct MDNNKMFLCNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public IJNLEAKKLBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public Func<IJNLEAKKLBL, GEKJCIHAMFL, OPMGMKLBION> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private DOLDLCECIIE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private OPMGMKLBION <operationContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private TaskAwaiter<EBIJFBKIDNI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x32C6720", Offset = "0x32C5520", VA = "0x1832C6720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct LFKGKGDMGFD : IAsyncStateMachine
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
		public IJNLEAKKLBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x32C5D60", Offset = "0x32C4B60", VA = "0x1832C5D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public readonly Guid MOPMMBDNOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public readonly ByteString FPLAENFHIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public readonly KFENGNLKFLE NJBFMLPJBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	protected readonly string HIGALCCOADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private readonly BNMEKDBAOON GIGDLICKJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private readonly bool AHBIOOADOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private bool LAFGPGKACJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public EAPMGOIGJJL GJJONJKDBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public EAPMGOIGJJL BLEIFMFKGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000364")]
	private readonly Queue<PKAAEIEPPHL> JLLFKCDGMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000365")]
	private readonly OLCAEPENJCG IIALFJCFKFG;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public BNMEKDBAOON BECJGHCKHIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x661A10", Offset = "0x660810", VA = "0x180661A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public JHHHHDEGGMN GNIOAJCHNPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x2345A20", Offset = "0x2344820", VA = "0x182345A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public IIFLENBNAPC JGNNILPHNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x2345BE0", Offset = "0x23449E0", VA = "0x182345BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public HPNHGBDLHHJ JLLPNIPEBHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x2345920", Offset = "0x2344720", VA = "0x182345920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public float AFEPPNOIIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x2345A00", Offset = "0x2344800", VA = "0x182345A00", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event MGLOKFBMOMI IBPFPEKACBI
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x2345D50", Offset = "0x2344B50", VA = "0x182345D50", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x2345A70", Offset = "0x2344870", VA = "0x182345A70", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x2345E80", Offset = "0x2344C80", VA = "0x182345E80")]
	protected IJNLEAKKLBL(Guid HEHOBBBEICN, BNMEKDBAOON GIGDLICKJEF, KFENGNLKFLE KKKPILGLMJB, string HBKMPJLDNLB, bool AHBIOOADOFD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x2345D10", Offset = "0x2344B10", VA = "0x182345D10", Slot = "7")]
	protected virtual string MPIOLDIPGPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x23459A0", Offset = "0x23447A0", VA = "0x1823459A0")]
	public void GOOKKOEKMLJ(PKAAEIEPPHL CMFIFPKIEBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x2345900", Offset = "0x2344700", VA = "0x182345900")]
	protected void FCACKHGLHFJ(float JOLHNMOCKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x2345A90", Offset = "0x2344890", VA = "0x182345A90")]
	[AsyncStateMachine(typeof(MDNNKMFLCNA))]
	public Task LCBCKFDJBHE(CancellationToken GPNLCIOKAPO, GEKJCIHAMFL DIOPAPPIBBL, [Optional] Func<IJNLEAKKLBL, GEKJCIHAMFL, OPMGMKLBION> AFAIHEHKLPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x2345D70", Offset = "0x2344B70", VA = "0x182345D70")]
	private void NGEIDOOHPMA(OPMGMKLBION LHKCEHFGEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task NALJOKAAODL(OPMGMKLBION LHKCEHFGEMP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO);

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x2345740", Offset = "0x2344540", VA = "0x182345740")]
	[AsyncStateMachine(typeof(LFKGKGDMGFD))]
	private Task BGPPOILHLNK(GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x2345880", Offset = "0x2344680", VA = "0x182345880")]
	public EBIJFBKIDNI DCPFDFDMNFO(FGKKFGNDBFI MKLBEFGGNMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x2345C30", Offset = "0x2344A30", VA = "0x182345C30")]
	[CompilerGenerated]
	private Task LHNMGHFJABD(CancellationToken MGEGOIPHNMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
internal sealed class POCIKLDNHAG : JHNCJDONPDO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private struct GIFKCBFOLNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public POCIKLDNHAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public OPMGMKLBION operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private KMCFCCDNIEO <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private ICCANIPPKEJ <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x3ED0AC0", Offset = "0x3ECF8C0", VA = "0x183ED0AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400037B")]
	private readonly BKDHKLDKOEI PENEAHICDBK;

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x2AAC280", Offset = "0x2AAB080", VA = "0x182AAC280")]
	public POCIKLDNHAG(Guid HEHOBBBEICN, BNMEKDBAOON GIGDLICKJEF, BKDHKLDKOEI PENEAHICDBK, KFENGNLKFLE KKKPILGLMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x2AAC130", Offset = "0x2AAAF30", VA = "0x182AAC130", Slot = "9")]
	[AsyncStateMachine(typeof(GIFKCBFOLNH))]
	protected override Task LKPHEFDHMHM(OPMGMKLBION LHKCEHFGEMP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
internal class GLLEMFCMOMN : IJNLEAKKLBL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private struct BNDAKLCOFOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public GLLEMFCMOMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public OPMGMKLBION operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private TaskAwaiter<LKMGECBKGBM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x32B9070", Offset = "0x32B7E70", VA = "0x1832B9070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000385")]
	private readonly string BLPKMOHCJBB;

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x2342950", Offset = "0x2341750", VA = "0x182342950")]
	public GLLEMFCMOMN(Guid HEHOBBBEICN, BNMEKDBAOON GIGDLICKJEF, KFENGNLKFLE KKKPILGLMJB, string BLPKMOHCJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x2342820", Offset = "0x2341620", VA = "0x182342820", Slot = "8")]
	[AsyncStateMachine(typeof(BNDAKLCOFOH))]
	protected override Task NALJOKAAODL(OPMGMKLBION LHKCEHFGEMP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
internal class BBJNJOAHKHI : JHNCJDONPDO
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class DPCLCBNCPPB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000FB")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			public AsyncTaskMethodBuilder<EBIJFBKIDNI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			public DPCLCBNCPPB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			private TaskAwaiter<LKMGECBKGBM> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			private TaskAwaiter<EBIJFBKIDNI> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0x3EDB180", Offset = "0x3ED9F80", VA = "0x183EDB180", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0x3EDB4C0", Offset = "0x3EDA2C0", VA = "0x183EDB4C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public BBJNJOAHKHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public DFAFJMCGHAN serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public JBJPDOJJABJ uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public DPCLCBNCPPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x2A98680", Offset = "0x2A97480", VA = "0x182A98680")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<EBIJFBKIDNI> <RunWhilePlayerDespawnedAsync>b__0(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private struct EBNLEOPLDMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public BBJNJOAHKHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public OPMGMKLBION operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private DPCLCBNCPPB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private KMCFCCDNIEO <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private ICCANIPPKEJ <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private TaskAwaiter<EBIJFBKIDNI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x2A987D0", Offset = "0x2A975D0", VA = "0x182A987D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400038C")]
	private readonly int MFEAAAIIPBH;

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x232E330", Offset = "0x232D130", VA = "0x18232E330")]
	public BBJNJOAHKHI(Guid HEHOBBBEICN, BNMEKDBAOON GIGDLICKJEF, int MFEAAAIIPBH, KFENGNLKFLE KKKPILGLMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x232E1D0", Offset = "0x232CFD0", VA = "0x18232E1D0", Slot = "9")]
	[AsyncStateMachine(typeof(EBNLEOPLDMI))]
	protected override Task LKPHEFDHMHM(OPMGMKLBION LHKCEHFGEMP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x232E0E0", Offset = "0x232CEE0", VA = "0x18232E0E0")]
	private void KKKLBIOECPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x232DF40", Offset = "0x232CD40", VA = "0x18232DF40")]
	private void DNIBKDIKAMP(GEKJCIHAMFL DIOPAPPIBBL, KMCFCCDNIEO AEPPKPHGPCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
internal abstract class KAFKKLBILBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public readonly IJNLEAKKLBL DNDBIJCCHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public readonly OPMGMKLBION NHLGPEPMOAI;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public JHHHHDEGGMN GNIOAJCHNPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x234B0B0", Offset = "0x2349EB0", VA = "0x18234B0B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public HPNHGBDLHHJ JLLPNIPEBHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x234B020", Offset = "0x2349E20", VA = "0x18234B020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x234B140", Offset = "0x2349F40", VA = "0x18234B140")]
	protected KAFKKLBILBI(OPMGMKLBION LHKCEHFGEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x234B100", Offset = "0x2349F00", VA = "0x18234B100")]
	protected void PNAJNCEFIKC(string MLPJOFIPMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x234B120", Offset = "0x2349F20", VA = "0x18234B120")]
	public void PNAJNCEFIKC(Func<string> FFKBDCJNKKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal struct MGIPMOFJMOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public Dictionary<Guid, List<IFAGDKLCNFF>> AMKAAJGJBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public Dictionary<Guid, List<IFAGDKLCNFF>> LLCMDOAJAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public Dictionary<Guid, List<IFAGDKLCNFF>> DCAKBGAEIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public List<Guid> NIIMFPAMBLO;

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x2AA1490", Offset = "0x2AA0290", VA = "0x182AA1490")]
	public static MGIPMOFJMOG BOPAOPJOHPG(JHHHHDEGGMN NFACINHMFIO, EAPMGOIGJJL KBGOEBJKIPO, HCAOAHLBICC JFCENPHKLKD)
	{
		return default(MGIPMOFJMOG);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000100")]
internal struct BLGDLMBDCCJ
{
	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x65A820", Offset = "0x659620", VA = "0x18065A820")]
	public static BLGDLMBDCCJ DAKLFHBAJIH()
	{
		return default(BLGDLMBDCCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void DGFJEGNAKHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void IIJNCPNCEDG(HCAOAHLBICC JANIFNADDOP, object LFLBBPIPFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void JPPPBNNCDAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
internal struct FMJOIGPDDBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public readonly KEBPHEIFBOC PPPFAIKANPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public readonly JDDHGPGBFHI ELFEIFCADJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public readonly HKINGCIIOMD DEHOGNNECIF;

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x233AF30", Offset = "0x2339D30", VA = "0x18233AF30")]
	public FMJOIGPDDBD(KEBPHEIFBOC PPPFAIKANPD, JDDHGPGBFHI ELFEIFCADJA, HKINGCIIOMD DEHOGNNECIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
internal struct DJHBPBOAGIA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	private readonly OPMGMKLBION LHKCEHFGEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	private readonly Guid ALGKOPADFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	private bool OHMLJNNHABC;

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x2334770", Offset = "0x2333570", VA = "0x182334770")]
	public static DJHBPBOAGIA ALBCGKDDNPA(OPMGMKLBION LHKCEHFGEMP)
	{
		return default(DJHBPBOAGIA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x1369D50", Offset = "0x1368B50", VA = "0x181369D50")]
	public void NDJFKCIOAAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x23347D0", Offset = "0x23335D0", VA = "0x1823347D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x23348E0", Offset = "0x23336E0", VA = "0x1823348E0")]
	private DJHBPBOAGIA(OPMGMKLBION LHKCEHFGEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x23347D0", Offset = "0x23335D0", VA = "0x1823347D0")]
	private void IGPMONBKLMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x2334830", Offset = "0x2333630", VA = "0x182334830")]
	private Func<Guid, bool> LEDBBMGFADK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
internal class ICCANIPPKEJ : KAFKKLBILBI, DJABOFDMEMI
{
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	public delegate Task<EAPMGOIGJJL> LBCIMFJFNGN(HCAOAHLBICC JANIFNADDOP, OJGNPIKFFGA DNEBOMAAIKF, OLCAEPENJCG KMIGMOKPKMP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private struct GOOOCDLMBBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public ICCANIPPKEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public BKDHKLDKOEI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private DJHBPBOAGIA <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private TaskAwaiter<EBIJFBKIDNI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x32BF570", Offset = "0x32BE370", VA = "0x1832BF570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private struct COBLFBGNOBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public AsyncTaskMethodBuilder<EBIJFBKIDNI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public ICCANIPPKEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public BKDHKLDKOEI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private GEKJCIHAMFL <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private TaskAwaiter<EBIJFBKIDNI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x32BA460", Offset = "0x32B9260", VA = "0x1832BA460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x32BA780", Offset = "0x32B9580", VA = "0x1832BA780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private struct GMGJBAJNDDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public ICCANIPPKEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public BKDHKLDKOEI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private GEKJCIHAMFL <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x32BF310", Offset = "0x32BE110", VA = "0x1832BF310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private sealed class NNIHHCIJBOB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000109")]
		private struct <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public AsyncTaskMethodBuilder<FMJOIGPDDBD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			public NNIHHCIJBOB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			private FMJOIGPDDBD <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			private TaskAwaiter<EAPMGOIGJJL> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			private TaskAwaiter<FMJOIGPDDBD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0x3ED9D90", Offset = "0x3ED8B90", VA = "0x183ED9D90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x3EDA4E0", Offset = "0x3ED92E0", VA = "0x183EDA4E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010A")]
		private struct <<LoadRoomLocal>b__4>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003E4")]
			public AsyncTaskMethodBuilder<HCAOAHLBICC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E5")]
			public NNIHHCIJBOB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E6")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003E7")]
			private HCAOAHLBICC <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			private TaskAwaiter<EAPMGOIGJJL> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			private TaskAwaiter<HCAOAHLBICC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x3EDA530", Offset = "0x3ED9330", VA = "0x183EDA530", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0x3EDAA60", Offset = "0x3ED9860", VA = "0x183EDAA60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010B")]
		private struct <<LoadRoomLocal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public NNIHHCIJBOB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			private TaskAwaiter<EAPMGOIGJJL> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			private OJGNPIKFFGA <timedYielder>5__2;

			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0x3ED8F20", Offset = "0x3ED7D20", VA = "0x183ED8F20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public ICCANIPPKEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public BKDHKLDKOEI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public OLCAEPENJCG preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public OLCAEPENJCG downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public FMJOIGPDDBD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public OLCAEPENJCG postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public HCAOAHLBICC phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public CGCKIHILMNK.JNHPMADDELD <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public NNIHHCIJBOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x32C8620", Offset = "0x32C7420", VA = "0x1832C8620")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<FMJOIGPDDBD> <LoadRoomLocal>b__2(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x32C8760", Offset = "0x32C7560", VA = "0x1832C8760")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<HCAOAHLBICC> <LoadRoomLocal>b__4(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x32C88A0", Offset = "0x32C76A0", VA = "0x1832C88A0")]
		internal void <LoadRoomLocal>b__6(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x32C84F0", Offset = "0x32C72F0", VA = "0x1832C84F0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task <LoadRoomLocal>b__0(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private struct GPOECJEEGJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public ICCANIPPKEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public BKDHKLDKOEI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		private NNIHHCIJBOB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private TaskAwaiter<FMJOIGPDDBD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private TaskAwaiter<HCAOAHLBICC> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x32C02C0", Offset = "0x32BF0C0", VA = "0x1832C02C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private struct DCHLDFLBGAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public ICCANIPPKEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public GEKJCIHAMFL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x32BB2B0", Offset = "0x32BA0B0", VA = "0x1832BB2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct CDHDJDPJJAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public ICCANIPPKEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public HCAOAHLBICC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public OLCAEPENJCG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		private GEKJCIHAMFL <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private TaskAwaiter<EAPMGOIGJJL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x32B9790", Offset = "0x32B8590", VA = "0x1832B9790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct KHPJBDCLNLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public AsyncTaskMethodBuilder<EAPMGOIGJJL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public ICCANIPPKEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public HCAOAHLBICC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public OLCAEPENJCG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private GEKJCIHAMFL <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private TaskAwaiter<EAPMGOIGJJL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x32C3AE0", Offset = "0x32C28E0", VA = "0x1832C3AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x32C4580", Offset = "0x32C3380", VA = "0x1832C4580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct GFEMKGGGLMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public AsyncTaskMethodBuilder<EAPMGOIGJJL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public ICCANIPPKEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public HCAOAHLBICC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public OLCAEPENJCG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public OJGNPIKFFGA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private GEKJCIHAMFL <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private TaskAwaiter<EAPMGOIGJJL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x32BE710", Offset = "0x32BD510", VA = "0x1832BE710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x32BF2C0", Offset = "0x32BE0C0", VA = "0x1832BF2C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private struct KMHNBGPGGDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public AsyncTaskMethodBuilder<EAPMGOIGJJL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public ICCANIPPKEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public EAPMGOIGJJL operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public OLCAEPENJCG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public HCAOAHLBICC deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private TaskAwaiter<EAPMGOIGJJL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x32C45D0", Offset = "0x32C33D0", VA = "0x1832C45D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x32C47D0", Offset = "0x32C35D0", VA = "0x1832C47D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class KEGCEDMELOG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000114")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			public AsyncTaskMethodBuilder<EAPMGOIGJJL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000438")]
			public KEGCEDMELOG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000439")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			private TaskAwaiter<EAPMGOIGJJL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004C3")]
			[Cpp2IlInjected.Address(RVA = "0x3EDAAB0", Offset = "0x3ED98B0", VA = "0x183EDAAB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0x3EDAFF0", Offset = "0x3ED9DF0", VA = "0x183EDAFF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public ICCANIPPKEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public HCAOAHLBICC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public OLCAEPENJCG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public LBCIMFJFNGN masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public OJGNPIKFFGA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public EAPMGOIGJJL originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public KEGCEDMELOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x32C33C0", Offset = "0x32C21C0", VA = "0x1832C33C0")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<EAPMGOIGJJL> <MasterLockedPhaseChangeBlock>b__0(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private struct CLOOPFIFPDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public AsyncTaskMethodBuilder<EAPMGOIGJJL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public ICCANIPPKEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public HCAOAHLBICC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public OLCAEPENJCG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public LBCIMFJFNGN masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public OJGNPIKFFGA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private TaskAwaiter<EAPMGOIGJJL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x32B9D40", Offset = "0x32B8B40", VA = "0x1832B9D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x32BA1E0", Offset = "0x32B8FE0", VA = "0x1832BA1E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private struct JGEOPGHKLGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public ICCANIPPKEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public HCAOAHLBICC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public OLCAEPENJCG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private EAPMGOIGJJL <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		private IEnumerator<EAPMGOIGJJL> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private TaskAwaiter<EAPMGOIGJJL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x32C2220", Offset = "0x32C1020", VA = "0x1832C2220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private struct DHPJPPMECDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public ICCANIPPKEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public HCAOAHLBICC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x32BB7D0", Offset = "0x32BA5D0", VA = "0x1832BB7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private struct LOHOPBJLPPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public ICCANIPPKEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public HCAOAHLBICC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x32C60B0", Offset = "0x32C4EB0", VA = "0x1832C60B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private sealed class HPCPFNFJOJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public KEBPHEIFBOC roomDetails;

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public HPCPFNFJOJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x32C11D0", Offset = "0x32BFFD0", VA = "0x1832C11D0")]
		internal object <LogRoomDetails>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	private readonly EABJGGDLAPO MBFGFCNONLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	private readonly EABJGGDLAPO CCABHIEGJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	private readonly FAKBOJPCPEP GDIICIICHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	private readonly NNBBGKOINHN AMLLMEIEEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	private readonly EMCEJDAKCDH IOGDDPLGLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	private readonly CJPAOFNIIFD BAHGIMPOFNL;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public float AFEPPNOIIIM
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x2344390", Offset = "0x2343190", VA = "0x182344390", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	private BNMEKDBAOON BECJGHCKHIC
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x23443F0", Offset = "0x23431F0", VA = "0x1823443F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event MGLOKFBMOMI IBPFPEKACBI
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x2344F00", Offset = "0x2343D00", VA = "0x182344F00", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x2344D80", Offset = "0x2343B80", VA = "0x182344D80", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x23450D0", Offset = "0x2343ED0", VA = "0x1823450D0")]
	public ICCANIPPKEJ(OPMGMKLBION LHKCEHFGEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x23440A0", Offset = "0x2342EA0", VA = "0x1823440A0")]
	[AsyncStateMachine(typeof(GOOOCDLMBBJ))]
	public Task HIMFJPMKCME(BKDHKLDKOEI NMKJPBEONAN, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x2343D80", Offset = "0x2342B80", VA = "0x182343D80")]
	[AsyncStateMachine(typeof(COBLFBGNOBL))]
	private Task<EBIJFBKIDNI> GBJCGLPPFAC(BKDHKLDKOEI NMKJPBEONAN, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x2344DA0", Offset = "0x2343BA0", VA = "0x182344DA0")]
	[AsyncStateMachine(typeof(GMGJBAJNDDB))]
	private Task KPPAJHOJMFP(BKDHKLDKOEI NMKJPBEONAN, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x2343980", Offset = "0x2342780", VA = "0x182343980")]
	[AsyncStateMachine(typeof(GPOECJEEGJI))]
	private Task EMNHIDACCMM(BKDHKLDKOEI NMKJPBEONAN, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken OLCMLFCKHKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x2344440", Offset = "0x2343240", VA = "0x182344440")]
	[AsyncStateMachine(typeof(DCHLDFLBGAG))]
	private Task KDBMGDIEAFH(GEKJCIHAMFL APDIGEDLLAL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x2343820", Offset = "0x2342620", VA = "0x182343820")]
	[AsyncStateMachine(typeof(CDHDJDPJJAB))]
	private Task ELKKHPBJIMN(HCAOAHLBICC JANIFNADDOP, OLCAEPENJCG KMIGMOKPKMP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x2344570", Offset = "0x2343370", VA = "0x182344570")]
	[AsyncStateMachine(typeof(KHPJBDCLNLF))]
	private Task<EAPMGOIGJJL> KDMNPMDJBOP(HCAOAHLBICC JANIFNADDOP, OJGNPIKFFGA BCKMHNJGABI, OLCAEPENJCG KMIGMOKPKMP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x23441F0", Offset = "0x2342FF0", VA = "0x1823441F0")]
	[AsyncStateMachine(typeof(GFEMKGGGLMJ))]
	private Task<EAPMGOIGJJL> HKPFNGPFJLF(HCAOAHLBICC JANIFNADDOP, OJGNPIKFFGA BCKMHNJGABI, OLCAEPENJCG KMIGMOKPKMP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x2344810", Offset = "0x2343610", VA = "0x182344810")]
	[AsyncStateMachine(typeof(KMHNBGPGGDC))]
	private Task<EAPMGOIGJJL> KFHLDGCLNIM(EAPMGOIGJJL KBGOEBJKIPO, HCAOAHLBICC JFCENPHKLKD, OLCAEPENJCG KMIGMOKPKMP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO, bool MLEKPHBEDEF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x2344FE0", Offset = "0x2343DE0", VA = "0x182344FE0")]
	private bool PEGIJHDFDGF(HCAOAHLBICC JEMLMBIJGDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x23435F0", Offset = "0x23423F0", VA = "0x1823435F0")]
	[AsyncStateMachine(typeof(CLOOPFIFPDG))]
	protected Task<EAPMGOIGJJL> ADCDAMDFEKO(HCAOAHLBICC JANIFNADDOP, OJGNPIKFFGA BCKMHNJGABI, OLCAEPENJCG KMIGMOKPKMP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO, LBCIMFJFNGN BFKCKELMINK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x23449A0", Offset = "0x23437A0", VA = "0x1823449A0")]
	[AsyncStateMachine(typeof(JGEOPGHKLGO))]
	private Task KIHAGMLCCMD(HCAOAHLBICC JANIFNADDOP, OLCAEPENJCG KMIGMOKPKMP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x2344F70", Offset = "0x2343D70", VA = "0x182344F70")]
	private void NGNCJGLHHDP(EAPMGOIGJJL GPBNCANIOMJ, OLCAEPENJCG KMIGMOKPKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x23443B0", Offset = "0x23431B0", VA = "0x1823443B0")]
	private void IPDAPKMKHFH(EAPMGOIGJJL EIENFDHOOKJ, out EAPMGOIGJJL LONGMJJOJLH, out EAPMGOIGJJL JHMMFDIPHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x2343F00", Offset = "0x2342D00", VA = "0x182343F00")]
	private Task<FMJOIGPDDBD> HBFKJIAJLIK(BKDHKLDKOEI NMKJPBEONAN, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x2344F20", Offset = "0x2343D20", VA = "0x182344F20")]
	private Task<HCAOAHLBICC> NFHGIGKJAEK(BKDHKLDKOEI NMKJPBEONAN, FMJOIGPDDBD JANIFNADDOP, CGCKIHILMNK.JNHPMADDELD CODODFINKNH, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x2343C30", Offset = "0x2342A30", VA = "0x182343C30")]
	[AsyncStateMachine(typeof(DHPJPPMECDO))]
	private Task FOLMDPBFNNC(HCAOAHLBICC JANIFNADDOP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x2344C60", Offset = "0x2343A60", VA = "0x182344C60")]
	[AsyncStateMachine(typeof(LOHOPBJLPPF))]
	private Task KOLGOFAMINE(HCAOAHLBICC JANIFNADDOP, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x23437A0", Offset = "0x23425A0", VA = "0x1823437A0")]
	private Task BKCJFNGCBCL(HCAOAHLBICC JANIFNADDOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x2343AD0", Offset = "0x23428D0", VA = "0x182343AD0")]
	private Task FJFGONPFKNO(HCAOAHLBICC JANIFNADDOP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x23437D0", Offset = "0x23425D0", VA = "0x1823437D0")]
	private Task CHFOBFKKNBB(HCAOAHLBICC JANIFNADDOP, OJGNPIKFFGA BCKMHNJGABI, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x2344420", Offset = "0x2343220", VA = "0x182344420")]
	private Task KAMPCEIHFMC(HCAOAHLBICC JANIFNADDOP, OJGNPIKFFGA BCKMHNJGABI, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x23446F0", Offset = "0x23434F0", VA = "0x1823446F0")]
	private static Task KFGIEBKMBOI(CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x2344B00", Offset = "0x2343900", VA = "0x182344B00")]
	private Task KNMCAEFBFKM(HCAOAHLBICC JANIFNADDOP, OJGNPIKFFGA BCKMHNJGABI, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x2344FC0", Offset = "0x2343DC0", VA = "0x182344FC0")]
	private Task PCIPAMNKLMD(HCAOAHLBICC JANIFNADDOP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x23437F0", Offset = "0x23425F0", VA = "0x1823437F0")]
	private void EGCNDCIHHEF(BKDHKLDKOEI NMKJPBEONAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x2343F40", Offset = "0x2342D40", VA = "0x182343F40")]
	private static void HIIEAGPFMKG(KEBPHEIFBOC PPPFAIKANPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal struct GBCPLJKBFCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400045E")]
	private BNMEKDBAOON GIGDLICKJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400045F")]
	private EAPMGOIGJJL GPBNCANIOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000460")]
	private HCAOAHLBICC JANIFNADDOP;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private JHHHHDEGGMN GNIOAJCHNPI
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x233B9A0", Offset = "0x233A7A0", VA = "0x18233B9A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	private HPNHGBDLHHJ JLLPNIPEBHB
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x233B920", Offset = "0x233A720", VA = "0x18233B920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x233B9F0", Offset = "0x233A7F0", VA = "0x18233B9F0")]
	public static Task LCBCKFDJBHE(BNMEKDBAOON GIGDLICKJEF, EAPMGOIGJJL GPBNCANIOMJ, HCAOAHLBICC JANIFNADDOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x233BAA0", Offset = "0x233A8A0", VA = "0x18233BAA0")]
	private void LCBCKFDJBHE()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal struct IOGKIHAHBLJ
{
	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x23446F0", Offset = "0x23434F0", VA = "0x1823446F0")]
	public static Task LCBCKFDJBHE(CancellationToken GPNLCIOKAPO)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011C")]
internal struct PMIAGILPANE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private struct KJCFMCPFGFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public OPMGMKLBION operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public HCAOAHLBICC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private GEKJCIHAMFL <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x3ED3970", Offset = "0x3ED2770", VA = "0x183ED3970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x2AABFE0", Offset = "0x2AAADE0", VA = "0x182AABFE0")]
	[AsyncStateMachine(typeof(KJCFMCPFGFJ))]
	public static Task LCBCKFDJBHE(OPMGMKLBION LHKCEHFGEMP, HCAOAHLBICC JANIFNADDOP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal struct LGEEDPAJKKF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private struct IPKMAOIMLMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public OPMGMKLBION operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public HCAOAHLBICC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public OJGNPIKFFGA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private EAPMGOIGJJL <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private BNMEKDBAOON <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		private JHHHHDEGGMN <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		private List<(PersistenceView, OGPFCDLOHHL)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private OGPFCDLOHHL <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x3ED1E80", Offset = "0x3ED0C80", VA = "0x183ED1E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F510", Offset = "0x2A9E310", VA = "0x182A9F510")]
	[AsyncStateMachine(typeof(IPKMAOIMLMJ))]
	public static Task LCBCKFDJBHE(OPMGMKLBION LHKCEHFGEMP, HCAOAHLBICC JANIFNADDOP, OJGNPIKFFGA BCKMHNJGABI, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F2A0", Offset = "0x2A9E0A0", VA = "0x182A9F2A0")]
	private static void GLNOHLEMIEN(PersistenceView LFIMBOIOPFD, OGPFCDLOHHL LFLBBPIPFGK, HCAOAHLBICC JANIFNADDOP, EAPMGOIGJJL KBGOEBJKIPO, bool ECBEEOFKIEC)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal struct NBKOALJKDIM
{
	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x2AA2420", Offset = "0x2AA1220", VA = "0x182AA2420")]
	public static Task LCBCKFDJBHE(BNMEKDBAOON GIGDLICKJEF, HCAOAHLBICC JANIFNADDOP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
internal struct JPLJLLFLILC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct NJJFLMLCIML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public BNMEKDBAOON roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public HCAOAHLBICC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public OPMGMKLBION operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x32C8380", Offset = "0x32C7180", VA = "0x1832C8380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct LECACMPMEKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public JPLJLLFLILC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		private TaskAwaiter<EBIJFBKIDNI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x32C54C0", Offset = "0x32C42C0", VA = "0x1832C54C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private sealed class IMNFBNCJIGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public FNCCMIGPLFA version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public IMNFBNCJIGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x32C1C20", Offset = "0x32C0A20", VA = "0x1832C1C20")]
		internal object <DestroyActivePersistenceViews>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x32C1D00", Offset = "0x32C0B00", VA = "0x1832C1D00")]
		internal object <DestroyActivePersistenceViews>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	private BNMEKDBAOON GIGDLICKJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400047E")]
	private HCAOAHLBICC JANIFNADDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	private OPMGMKLBION LHKCEHFGEMP;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	private static readonly ByteString MFCKAJMEBDJ;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	private JHHHHDEGGMN GNIOAJCHNPI
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x234AC80", Offset = "0x2349A80", VA = "0x18234AC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	private HPNHGBDLHHJ JLLPNIPEBHB
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x234AC00", Offset = "0x2349A00", VA = "0x18234AC00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x234AE40", Offset = "0x2349C40", VA = "0x18234AE40")]
	[AsyncStateMachine(typeof(NJJFLMLCIML))]
	public static Task LCBCKFDJBHE(BNMEKDBAOON GIGDLICKJEF, EAPMGOIGJJL GPBNCANIOMJ, HCAOAHLBICC JANIFNADDOP, OPMGMKLBION LHKCEHFGEMP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x234AD00", Offset = "0x2349B00", VA = "0x18234AD00")]
	[AsyncStateMachine(typeof(LECACMPMEKJ))]
	private Task LCBCKFDJBHE(GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x234A560", Offset = "0x2349360", VA = "0x18234A560")]
	private void FPAHPKINLAH([NotNull] IOFNFGHMKGC CNBHMNJLPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x234ACD0", Offset = "0x2349AD0", VA = "0x18234ACD0")]
	private bool KKMEGDDBDNP(FNCCMIGPLFA JKGBPKEJAFA, IOFNFGHMKGC CNBHMNJLPIE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
internal struct PHMJDOLDFNI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct NGEDLCAGOID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public AsyncTaskMethodBuilder<HCAOAHLBICC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public PHMJDOLDFNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public CGCKIHILMNK.JNHPMADDELD downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private GEKJCIHAMFL <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private TaskAwaiter<(global::BEHELEDFPDP<PBBNJOEIPIN, FOCKIOEBELC>, global::BEHELEDFPDP<global::DJFLMAPJICG<IOFNFGHMKGC>, FOCKIOEBELC>, global::BEHELEDFPDP<global::DJFLMAPJICG<JLBACGKCMLP>, FOCKIOEBELC>, global::BEHELEDFPDP<global::DJFLMAPJICG<ALDMECCOEFF>, FOCKIOEBELC>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x3ED59D0", Offset = "0x3ED47D0", VA = "0x183ED59D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x3ED6290", Offset = "0x3ED5090", VA = "0x183ED6290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct HKBDDBNNOMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public AsyncTaskMethodBuilder<global::BEHELEDFPDP<PBBNJOEIPIN, FOCKIOEBELC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public GEKJCIHAMFL downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public PHMJDOLDFNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public CGCKIHILMNK.JNHPMADDELD downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private GEKJCIHAMFL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		private TaskAwaiter<global::BEHELEDFPDP<PBBNJOEIPIN, FOCKIOEBELC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x3ED1590", Offset = "0x3ED0390", VA = "0x183ED1590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x3ED1A80", Offset = "0x3ED0880", VA = "0x183ED1A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	private global::GHKJEADOBPI<JPCHJAOPHGN, JLBACGKCMLP> POALMJMHJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000498")]
	private global::GHKJEADOBPI<JPCHJAOPHGN, IOFNFGHMKGC> ELFEIFCADJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000499")]
	private global::GHKJEADOBPI<long, ALDMECCOEFF> IGHEMOKCAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400049A")]
	private CAIAFIMMKBO BKEKFJIPLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400049B")]
	private BKDHKLDKOEI NMKJPBEONAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	private KEBPHEIFBOC PPPFAIKANPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	private JDDHGPGBFHI KPFCPBDCGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	private long GNHKIAILMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	private GEKJCIHAMFL APDIGEDLLAL;

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x2AAB5E0", Offset = "0x2AAA3E0", VA = "0x182AAB5E0")]
	public static Task<HCAOAHLBICC> IGFNOIKFCOE(BNMEKDBAOON GIGDLICKJEF, BKDHKLDKOEI NMKJPBEONAN, in FMJOIGPDDBD JANIFNADDOP, CGCKIHILMNK.JNHPMADDELD CODODFINKNH, GEKJCIHAMFL APDIGEDLLAL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x2AABAB0", Offset = "0x2AAA8B0", VA = "0x182AABAB0")]
	[AsyncStateMachine(typeof(NGEDLCAGOID))]
	private Task<HCAOAHLBICC> LCBCKFDJBHE(CGCKIHILMNK.JNHPMADDELD CODODFINKNH, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x2AAB5A0", Offset = "0x2AAA3A0", VA = "0x182AAB5A0")]
	private JPCHJAOPHGN ANJHDLDNACK(BCCAOCCFAIE LFFEAHLLHAI)
	{
		return default(JPCHJAOPHGN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x2AAB900", Offset = "0x2AAA700", VA = "0x182AAB900")]
	[AsyncStateMachine(typeof(HKBDDBNNOMM))]
	private Task<global::BEHELEDFPDP<PBBNJOEIPIN, FOCKIOEBELC>> KDIKMOBPDKO(string HCJPHBNCMNO, long GNHKIAILMCL, CGCKIHILMNK.JNHPMADDELD CODODFINKNH, GEKJCIHAMFL NDLFACDDLJO, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
internal struct EFFEAMFHLFL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct NKLNNFECBLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public AsyncTaskMethodBuilder<FMJOIGPDDBD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public EFFEAMFHLFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private GEKJCIHAMFL <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private TaskAwaiter<FMJOIGPDDBD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4730", Offset = "0x2AA3530", VA = "0x182AA4730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4BE0", Offset = "0x2AA39E0", VA = "0x182AA4BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct BINMMFGLIKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public AsyncTaskMethodBuilder<FMJOIGPDDBD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public EFFEAMFHLFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private TaskAwaiter<FMJOIGPDDBD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x2A958D0", Offset = "0x2A946D0", VA = "0x182A958D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x2A95AC0", Offset = "0x2A948C0", VA = "0x182A95AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private sealed class IDEIMKGOHAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public IDEIMKGOHAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0xDAFF10", Offset = "0xDAED10", VA = "0x180DAFF10")]
		internal bool <FetchRoomDetails>b__0(JDDHGPGBFHI sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct CBKFKHPMKNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public AsyncTaskMethodBuilder<FMJOIGPDDBD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public JHHHHDEGGMN callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private IDEIMKGOHAD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private GEKJCIHAMFL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private TaskAwaiter<KEBPHEIFBOC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x2A96190", Offset = "0x2A94F90", VA = "0x182A96190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x2A966D0", Offset = "0x2A954D0", VA = "0x182A966D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	private JHHHHDEGGMN NFACINHMFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	private FAKBOJPCPEP GDIICIICHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	private GEKJCIHAMFL APDIGEDLLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	private long MOLCFNPABNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	private long DFGMBHPPELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	private string NAJMFOGMLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	private JPCHJAOPHGN GLEHCKBFIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	private JPCHJAOPHGN PKIAMPIHOCO;

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x23358D0", Offset = "0x23346D0", VA = "0x1823358D0")]
	public static Task<FMJOIGPDDBD> IGFNOIKFCOE(BNMEKDBAOON GIGDLICKJEF, BKDHKLDKOEI NMKJPBEONAN, GEKJCIHAMFL APDIGEDLLAL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x2335CD0", Offset = "0x2334AD0", VA = "0x182335CD0")]
	[AsyncStateMachine(typeof(NKLNNFECBLH))]
	private Task<FMJOIGPDDBD> LCBCKFDJBHE(CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x2335740", Offset = "0x2334540", VA = "0x182335740")]
	[AsyncStateMachine(typeof(BINMMFGLIKA))]
	private Task<FMJOIGPDDBD> HBFKJIAJLIK(long MOLCFNPABNJ, long DFGMBHPPELL, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO, bool OJGGILPHFII = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x23355C0", Offset = "0x23343C0", VA = "0x1823355C0")]
	[AsyncStateMachine(typeof(CBKFKHPMKNE))]
	public static Task<FMJOIGPDDBD> HBFKJIAJLIK(JHHHHDEGGMN NFACINHMFIO, long MOLCFNPABNJ, long DFGMBHPPELL, CancellationToken GPNLCIOKAPO, GEKJCIHAMFL DIOPAPPIBBL, bool OJGGILPHFII = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x2335E30", Offset = "0x2334C30", VA = "0x182335E30")]
	private void MCJHBECOJHC(KEBPHEIFBOC PPPFAIKANPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x2335B60", Offset = "0x2334960", VA = "0x182335B60")]
	private bool KEPAOPIPIGB(FMJOIGPDDBD JANIFNADDOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x2335420", Offset = "0x2334220", VA = "0x182335420")]
	private void GPHEOKMOLOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
internal struct LANGDNNCBHA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct IIAMJECNCCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public LANGDNNCBHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private GEKJCIHAMFL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x3ED1AD0", Offset = "0x3ED08D0", VA = "0x183ED1AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	private const int MHFIHHFFEGN = 20;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	private const float BGEEMGCGNIL = 15f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	private JHHHHDEGGMN NFACINHMFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	private HCAOAHLBICC JANIFNADDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	private GEKJCIHAMFL APDIGEDLLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	private float CHGHPNHLOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	private float FJJIKNJNEOJ;

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F000", Offset = "0x2A9DE00", VA = "0x182A9F000")]
	public static Task NCODJPAEEPA(BNMEKDBAOON GIGDLICKJEF, HCAOAHLBICC JANIFNADDOP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x2A9EE10", Offset = "0x2A9DC10", VA = "0x182A9EE10")]
	[AsyncStateMachine(typeof(IIAMJECNCCE))]
	public Task LCBCKFDJBHE(CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x2A9EA80", Offset = "0x2A9D880", VA = "0x182A9EA80")]
	private static void EONJAIEFODL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x2A9EC20", Offset = "0x2A9DA20", VA = "0x182A9EC20")]
	private void GBMMJMBJPJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x2A9EF40", Offset = "0x2A9DD40", VA = "0x182A9EF40")]
	private static float LLKGANJMGEC(JHHHHDEGGMN NFACINHMFIO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x2A9EDF0", Offset = "0x2A9DBF0", VA = "0x182A9EDF0")]
	private static float IDHAALHLCCD()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal struct FAGEMJOIFEG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct EKBENMMCGMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public OPMGMKLBION operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public HCAOAHLBICC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private IJNLEAKKLBL <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		private BNMEKDBAOON <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private JIGAJLOCFFK.GLGMDEHDLCE <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private TaskAwaiter<EBIJFBKIDNI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x2A99320", Offset = "0x2A98120", VA = "0x182A99320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct JGDMKLNOAGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		private CLAOGHOLJIM.GKGCMCBHFOM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x2A9CBD0", Offset = "0x2A9B9D0", VA = "0x182A9CBD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x2339790", Offset = "0x2338590", VA = "0x182339790")]
	[AsyncStateMachine(typeof(EKBENMMCGMC))]
	public static Task LCBCKFDJBHE(OPMGMKLBION LHKCEHFGEMP, HCAOAHLBICC JANIFNADDOP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x2339720", Offset = "0x2338520", VA = "0x182339720")]
	private static Task<EBIJFBKIDNI> KHAAGFBBHNM(OPMGMKLBION LHKCEHFGEMP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x2339650", Offset = "0x2338450", VA = "0x182339650")]
	[AsyncStateMachine(typeof(JGDMKLNOAGB))]
	private static Task HJBHBLKKPLD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
internal struct NBKCKPFDNPN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private struct NFDBJMCKGLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public NBKCKPFDNPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		private GEKJCIHAMFL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x3ED5490", Offset = "0x3ED4290", VA = "0x183ED5490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private sealed class JPPAHIEGJGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public JPPAHIEGJGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x3ED2D30", Offset = "0x3ED1B30", VA = "0x183ED2D30")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private struct NGEGCELLKFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public NBKCKPFDNPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private OJCJOBAHOHI <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x3ED62E0", Offset = "0x3ED50E0", VA = "0x183ED62E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	private bool JCOBIOMDJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private GEKJCIHAMFL APDIGEDLLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private BNMEKDBAOON GIGDLICKJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private CancellationToken GPNLCIOKAPO;

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x2AA23B0", Offset = "0x2AA11B0", VA = "0x182AA23B0")]
	public static Task OFHCMEEIHNP(BNMEKDBAOON GIGDLICKJEF, bool JCOBIOMDJAM, GEKJCIHAMFL APDIGEDLLAL, CancellationToken IJAKIFIPFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x2AA2170", Offset = "0x2AA0F70", VA = "0x182AA2170")]
	[AsyncStateMachine(typeof(NFDBJMCKGLI))]
	private Task LCBCKFDJBHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x2AA2280", Offset = "0x2AA1080", VA = "0x182AA2280")]
	[AsyncStateMachine(typeof(NGEGCELLKFF))]
	private Task MHAPMLDLIAD(bool FPJHKLFPJPH, string OFIBKFPDOOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x65A820", Offset = "0x659620", VA = "0x18065A820")]
	private bool CCOPAAECCCA(bool JCOBIOMDJAM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct IDLCPHHEJIJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private struct NFIEPBIBDPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public IDLCPHHEJIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private GEKJCIHAMFL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x32C7980", Offset = "0x32C6780", VA = "0x1832C7980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x32C7C90", Offset = "0x32C6A90", VA = "0x1832C7C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private sealed class HFEPFKEFCMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public HFEPFKEFCMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x32C1000", Offset = "0x32BFE00", VA = "0x1832C1000")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct PCAJIPKGCKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public IDLCPHHEJIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		private OJCJOBAHOHI <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x32CC4B0", Offset = "0x32CB2B0", VA = "0x1832CC4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x32CC9F0", Offset = "0x32CB7F0", VA = "0x1832CC9F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	private HKINGCIIOMD HAKIKKPPHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private GEKJCIHAMFL APDIGEDLLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	private BNMEKDBAOON GIGDLICKJEF;

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x23455A0", Offset = "0x23443A0", VA = "0x1823455A0")]
	public static Task<Scene> PHKGDBMINFN(BNMEKDBAOON GIGDLICKJEF, HKINGCIIOMD GGEEOEBDOJA, GEKJCIHAMFL APDIGEDLLAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x2345310", Offset = "0x2344110", VA = "0x182345310")]
	[AsyncStateMachine(typeof(NFIEPBIBDPO))]
	private Task<Scene> LCBCKFDJBHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x2345450", Offset = "0x2344250", VA = "0x182345450")]
	[AsyncStateMachine(typeof(PCAJIPKGCKJ))]
	private Task<Scene> MHAPMLDLIAD(string OFIBKFPDOOP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
internal struct EMCEJDAKCDH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct KBHEBBKPAGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public AsyncTaskMethodBuilder<EAPMGOIGJJL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public EMCEJDAKCDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public EAPMGOIGJJL nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public HCAOAHLBICC deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private GEKJCIHAMFL <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private TaskAwaiter<EAPMGOIGJJL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x2A9CEF0", Offset = "0x2A9BCF0", VA = "0x182A9CEF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x2A9D680", Offset = "0x2A9C480", VA = "0x182A9D680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct ILLEOEKHIEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public AsyncTaskMethodBuilder<EAPMGOIGJJL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public EMCEJDAKCDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public EAPMGOIGJJL state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		private TaskAwaiter<EBIJFBKIDNI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x2A9BF00", Offset = "0x2A9AD00", VA = "0x182A9BF00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x2A9C2F0", Offset = "0x2A9B0F0", VA = "0x182A9C2F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	private readonly OPMGMKLBION LHKCEHFGEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	private readonly FAKBOJPCPEP GDIICIICHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	private readonly NNBBGKOINHN AMLLMEIEEDI;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private IJNLEAKKLBL DNDBIJCCHGF
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x7CCE20", Offset = "0x7CBC20", VA = "0x1807CCE20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x23395F0", Offset = "0x23383F0", VA = "0x1823395F0")]
	public EMCEJDAKCDH(OPMGMKLBION LHKCEHFGEMP, FAKBOJPCPEP GDIICIICHHB, NNBBGKOINHN AMLLMEIEEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x2339290", Offset = "0x2338090", VA = "0x182339290")]
	[AsyncStateMachine(typeof(KBHEBBKPAGF))]
	public Task<EAPMGOIGJJL> GHBENKCIKOC(EAPMGOIGJJL LJLGOEGBLHB, HCAOAHLBICC JFCENPHKLKD, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO, bool MLEKPHBEDEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x2339430", Offset = "0x2338230", VA = "0x182339430")]
	[AsyncStateMachine(typeof(ILLEOEKHIEB))]
	private Task<EAPMGOIGJJL> KEPIMGGAOKA(GEKJCIHAMFL DIOPAPPIBBL, EAPMGOIGJJL PBHDPEJBGCP, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x23395A0", Offset = "0x23383A0", VA = "0x1823395A0")]
	private bool KILAAELNBBM(EAPMGOIGJJL HLCMBINOMIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x23395D0", Offset = "0x23383D0", VA = "0x1823395D0")]
	private void PNAJNCEFIKC(string IALJJELLBDF)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000140")]
internal struct EFKHMDNNCLC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct OEDLNNCCNCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public IJNLEAKKLBL operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public HCAOAHLBICC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public OJGNPIKFFGA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private List<(PersistenceView, OGPFCDLOHHL)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private (PersistenceView, OGPFCDLOHHL) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x2AA70E0", Offset = "0x2AA5EE0", VA = "0x182AA70E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x2336AB0", Offset = "0x23358B0", VA = "0x182336AB0")]
	[AsyncStateMachine(typeof(OEDLNNCCNCJ))]
	public static Task LCBCKFDJBHE(IJNLEAKKLBL OOLGEBPABAO, HCAOAHLBICC JANIFNADDOP, OJGNPIKFFGA BCKMHNJGABI, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000142")]
internal struct PPDPHLHHKDA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct KOBAABHAFPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public IJNLEAKKLBL operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public HCAOAHLBICC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public OJGNPIKFFGA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private FNCCMIGPLFA <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private List<(PersistenceView, OGPFCDLOHHL)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private OGPFCDLOHHL <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x3ED3DD0", Offset = "0x3ED2BD0", VA = "0x183ED3DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x2AAC320", Offset = "0x2AAB120", VA = "0x182AAC320")]
	[AsyncStateMachine(typeof(KOBAABHAFPN))]
	public static Task LCBCKFDJBHE(IJNLEAKKLBL OOLGEBPABAO, HCAOAHLBICC JANIFNADDOP, OJGNPIKFFGA BCKMHNJGABI, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
internal struct JIGAJLOCFFK
{
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	public struct GLGMDEHDLCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public List<CDDJOMAFKBB> KADNFMOLMBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public List<OGPFCDLOHHL> MJACCPBOKDC;

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x6CE460", Offset = "0x6CD260", VA = "0x1806CE460")]
		public GLGMDEHDLCE(List<CDDJOMAFKBB> KADNFMOLMBF, List<OGPFCDLOHHL> MJACCPBOKDC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private sealed class IBNKLAEOGCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public List<CDDJOMAFKBB> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public IBNKLAEOGCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x32C1460", Offset = "0x32C0260", VA = "0x1832C1460")]
		internal object <BulkInstantiateObjects>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	private BNMEKDBAOON GIGDLICKJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	private HCAOAHLBICC JANIFNADDOP;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private JHHHHDEGGMN GNIOAJCHNPI
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x2348E50", Offset = "0x2347C50", VA = "0x182348E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x2348EA0", Offset = "0x2347CA0", VA = "0x182348EA0")]
	public static GLGMDEHDLCE LCBCKFDJBHE(BNMEKDBAOON GIGDLICKJEF, HCAOAHLBICC JANIFNADDOP)
	{
		return default(GLGMDEHDLCE);
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x2348F00", Offset = "0x2347D00", VA = "0x182348F00")]
	private GLGMDEHDLCE LCBCKFDJBHE()
	{
		return default(GLGMDEHDLCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x23483F0", Offset = "0x23471F0", VA = "0x1823483F0")]
	private GLGMDEHDLCE ANPHCMMMEIA(IOFNFGHMKGC CNBHMNJLPIE, FNCCMIGPLFA MGLNHNJLBCH)
	{
		return default(GLGMDEHDLCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x2348940", Offset = "0x2347740", VA = "0x182348940")]
	private GameObject[] ENJMOPBIPLJ(List<CDDJOMAFKBB> KADNFMOLMBF)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000148")]
internal struct CLEHELNOEOC
{
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private sealed class CDLAMDDEONE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public JIGAJLOCFFK.GLGMDEHDLCE instantiations;

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public CDLAMDDEONE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x2A97260", Offset = "0x2A96060", VA = "0x182A97260")]
		internal object <Run>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private sealed class BPEJGMODIBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public BPEJGMODIBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x2A96040", Offset = "0x2A94E40", VA = "0x182A96040")]
		internal object <Run>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x2330FF0", Offset = "0x232FDF0", VA = "0x182330FF0")]
	public static void LCBCKFDJBHE(IJNLEAKKLBL OOLGEBPABAO, HCAOAHLBICC JANIFNADDOP, JIGAJLOCFFK.GLGMDEHDLCE CPKDDKDHCMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
internal class NNBBGKOINHN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct LMONBKFKJKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public NNBBGKOINHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public EAPMGOIGJJL operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public HCAOAHLBICC deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public GEKJCIHAMFL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x3ED4C70", Offset = "0x3ED3A70", VA = "0x183ED4C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private sealed class MDGPPDIMPLN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200014E")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000565")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000566")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000567")]
			public MDGPPDIMPLN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000568")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000569")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000560")]
			[Cpp2IlInjected.Address(RVA = "0x3EDB040", Offset = "0x3ED9E40", VA = "0x183EDB040", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000561")]
			[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public NNBBGKOINHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public HCAOAHLBICC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public GEKJCIHAMFL handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public MDGPPDIMPLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x3ED4FB0", Offset = "0x3ED3DB0", VA = "0x183ED4FB0")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task <RunAuthorityHandler>b__0(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct LLIJLENGMAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public NNBBGKOINHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public HCAOAHLBICC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public GEKJCIHAMFL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private MDGPPDIMPLN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x3ED4850", Offset = "0x3ED3650", VA = "0x183ED4850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct AFGJLCEGHDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public NNBBGKOINHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public GEKJCIHAMFL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public HCAOAHLBICC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private GEKJCIHAMFL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private Dictionary<Guid, List<IFAGDKLCNFF>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x3ECCD00", Offset = "0x3ECBB00", VA = "0x183ECCD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private struct EMGCHKGAHIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public NNBBGKOINHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public GEKJCIHAMFL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public HCAOAHLBICC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private GEKJCIHAMFL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private Dictionary<Guid, List<IFAGDKLCNFF>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x3ED0240", Offset = "0x3ECF040", VA = "0x183ED0240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private sealed class DEKELKJHGDI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000153")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000589")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400058A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400058B")]
			public IFAGDKLCNFF handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400058C")]
			public DEKELKJHGDI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400058D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600056C")]
			[Cpp2IlInjected.Address(RVA = "0x3ED8DE0", Offset = "0x3ED7BE0", VA = "0x183ED8DE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600056D")]
			[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public NODKGJNBIEL runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public List<IFAGDKLCNFF> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public HCAOAHLBICC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public DEKELKJHGDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x3ECE5D0", Offset = "0x3ECD3D0", VA = "0x183ECE5D0")]
		internal object <InvokeMethodsInParallel>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x3ECE7B0", Offset = "0x3ECD5B0", VA = "0x183ECE7B0")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task <InvokeMethodsInParallel>b__2(IFAGDKLCNFF handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x3ECE6C0", Offset = "0x3ECD4C0", VA = "0x183ECE6C0")]
		internal object <InvokeMethodsInParallel>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct EJJCGFNDGHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public NODKGJNBIEL runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public List<IFAGDKLCNFF> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public HCAOAHLBICC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private DEKELKJHGDI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x3ECF4A0", Offset = "0x3ECE2A0", VA = "0x183ECF4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private struct EICGEPKHOPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public NNBBGKOINHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public HCAOAHLBICC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public GEKJCIHAMFL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x3ECF220", Offset = "0x3ECE020", VA = "0x183ECF220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private sealed class KCAEIEINMCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public KCAEIEINMCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x3ED2E10", Offset = "0x3ED1C10", VA = "0x183ED2E10")]
		internal object <MasterInvokeHandlerMethods>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct OJMHPPPAGAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public NNBBGKOINHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public HCAOAHLBICC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x3ED7660", Offset = "0x3ED6460", VA = "0x183ED7660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private sealed class CGBLFFPGDIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public CGBLFFPGDIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x3ECDD80", Offset = "0x3ECCB80", VA = "0x183ECDD80")]
		internal object <MasterSyncSendCompletionMark>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct AOHDHINGMBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public NNBBGKOINHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		private TaskAwaiter<EBIJFBKIDNI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x3ECD820", Offset = "0x3ECC620", VA = "0x183ECD820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private sealed class OEECNFBJPPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public OEECNFBJPPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x3ED7580", Offset = "0x3ED6380", VA = "0x183ED7580")]
		internal object <RemoveCompletedHandler>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000557")]
	private readonly OPMGMKLBION LHKCEHFGEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000558")]
	private MGIPMOFJMOG AMLLMEIEEDI;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private IJNLEAKKLBL DNDBIJCCHGF
	{
		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x6E7740", Offset = "0x6E6540", VA = "0x1806E7740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x6C4C50", Offset = "0x6C3A50", VA = "0x1806C4C50")]
	public NNBBGKOINHN(OPMGMKLBION LHKCEHFGEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5B00", Offset = "0x2AA4900", VA = "0x182AA5B00")]
	[AsyncStateMachine(typeof(LMONBKFKJKE))]
	public Task LCBCKFDJBHE(EAPMGOIGJJL KBGOEBJKIPO, HCAOAHLBICC JFCENPHKLKD, GEKJCIHAMFL APDIGEDLLAL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x2AA53B0", Offset = "0x2AA41B0", VA = "0x182AA53B0")]
	[AsyncStateMachine(typeof(LLIJLENGMAC))]
	private Task HDMCKCINICO(HCAOAHLBICC JANIFNADDOP, GEKJCIHAMFL APDIGEDLLAL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x2AA4DE0", Offset = "0x2AA3BE0", VA = "0x182AA4DE0")]
	[AsyncStateMachine(typeof(AFGJLCEGHDP))]
	private Task BAIODGEDHBD(HCAOAHLBICC JANIFNADDOP, GEKJCIHAMFL APDIGEDLLAL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5250", Offset = "0x2AA4050", VA = "0x182AA5250")]
	[AsyncStateMachine(typeof(EMGCHKGAHIJ))]
	private Task GKKDFCBONPI(HCAOAHLBICC JANIFNADDOP, GEKJCIHAMFL APDIGEDLLAL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5870", Offset = "0x2AA4670", VA = "0x182AA5870")]
	[AsyncStateMachine(typeof(EJJCGFNDGHJ))]
	private Task INEHBILAMOH(Guid FOCMMNAGAHJ, List<IFAGDKLCNFF> KBLJALNKBNI, NODKGJNBIEL CDBNLIAPAHN, HCAOAHLBICC JANIFNADDOP, CancellationToken MKDOEIGPNGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5C60", Offset = "0x2AA4A60", VA = "0x182AA5C60")]
	[AsyncStateMachine(typeof(EICGEPKHOPI))]
	private Task NGKFNODHOED(HCAOAHLBICC JANIFNADDOP, GEKJCIHAMFL APDIGEDLLAL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5110", Offset = "0x2AA3F10", VA = "0x182AA5110")]
	[AsyncStateMachine(typeof(OJMHPPPAGAH))]
	private Task BMAOFPLALIJ(Guid KPIJMANOKJC, HCAOAHLBICC JANIFNADDOP, GEKJCIHAMFL APDIGEDLLAL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x2AA59B0", Offset = "0x2AA47B0", VA = "0x182AA59B0")]
	[AsyncStateMachine(typeof(AOHDHINGMBH))]
	private Task KEBIKEACKJK(Guid KPIJMANOKJC, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5510", Offset = "0x2AA4310", VA = "0x182AA5510")]
	private void IIIDALPDADN(Guid KPIJMANOKJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x2AA4CC0", Offset = "0x2AA3AC0", VA = "0x182AA4CC0")]
	private void ADNMFNHPFBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x2AA56A0", Offset = "0x2AA44A0", VA = "0x182AA56A0")]
	public Guid ILMMNACEBKH(EAPMGOIGJJL GPBNCANIOMJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x2AA4F40", Offset = "0x2AA3D40", VA = "0x182AA4F40")]
	[CompilerGenerated]
	private object BELBDEMMDLK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
public readonly struct LKMGECBKGBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005B5")]
	[CanBeNull]
	public readonly IOFNFGHMKGC OELPELLNKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005B6")]
	[NotNull]
	public readonly List<string> EEDDOJKIDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B7")]
	[NotNull]
	public readonly Dictionary<long, int> FCAFAAHDABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005B8")]
	[CanBeNull]
	public readonly string PIPOFBLCJKP;

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x2A9FFC0", Offset = "0x2A9EDC0", VA = "0x182A9FFC0")]
	public LKMGECBKGBM([CanBeNull] IOFNFGHMKGC GDMAJNKMCBP, [NotNull] List<string> FMDPIAJBABC, [NotNull] Dictionary<long, int> CHFJFMJCDBO, [CanBeNull] string HCJPHBNCMNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015D")]
internal class DFAFJMCGHAN : KAFKKLBILBI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private struct BILHNCFDOJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public AsyncTaskMethodBuilder<LKMGECBKGBM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public DFAFJMCGHAN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public CLIMILMGEFO serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x2A953C0", Offset = "0x2A941C0", VA = "0x182A953C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x2A95880", Offset = "0x2A94680", VA = "0x182A95880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private sealed class BFFGKFDMGGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public CLIMILMGEFO serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public BFFGKFDMGGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x2A95040", Offset = "0x2A93E40", VA = "0x182A95040")]
		internal Task <PreserializeViews>b__1(PersistenceView v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class GLNDNJHEOJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public BFFGKFDMGGD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public GLNDNJHEOJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B220", Offset = "0x2A9A020", VA = "0x182A9B220")]
		internal object <PreserializeViews>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private sealed class BIOGIIBPJEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public BFFGKFDMGGD CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public BIOGIIBPJEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x2A95B10", Offset = "0x2A94910", VA = "0x182A95B10")]
		internal Task <PreserializeViews>b__3(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private struct ACOLECMGAKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public CLIMILMGEFO serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public DFAFJMCGHAN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private GLNDNJHEOJP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		private CLAOGHOLJIM.NKCFCIMANPC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x2A939C0", Offset = "0x2A927C0", VA = "0x182A939C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005B9")]
	private readonly CAINOHGEENI KEMAOBJDDDI;

	[Cpp2IlInjected.Token(Token = "0x40005BA")]
	private static readonly TimeSpan ICEECAJMHHF;

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x2334670", Offset = "0x2333470", VA = "0x182334670")]
	public DFAFJMCGHAN(OPMGMKLBION LHKCEHFGEMP, [Optional] CAINOHGEENI? KEMAOBJDDDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x2333450", Offset = "0x2332250", VA = "0x182333450")]
	[AsyncStateMachine(typeof(BILHNCFDOJK))]
	public Task<LKMGECBKGBM> DGAMFOBEJMM(long DFGMBHPPELL, string HCJPHBNCMNO, CLIMILMGEFO KKAEEEBDAEI, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x2333F40", Offset = "0x2332D40", VA = "0x182333F40")]
	[AsyncStateMachine(typeof(ACOLECMGAKB))]
	private Task LGBJAEBDECP(CLIMILMGEFO KKAEEEBDAEI, IEnumerable<PersistenceView> FBLBBMMKOFA, StringBuilder IHOCFABMDIP, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x2333740", Offset = "0x2332540", VA = "0x182333740")]
	private LKMGECBKGBM GIPPOJKKDME(long DFGMBHPPELL, string HCJPHBNCMNO, CLIMILMGEFO KKAEEEBDAEI, IEnumerable<PersistenceView> FBLBBMMKOFA, StringBuilder IHOCFABMDIP)
	{
		return default(LKMGECBKGBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x23335D0", Offset = "0x23323D0", VA = "0x1823335D0")]
	private IOFNFGHMKGC FELAOKIJFBP(long DFGMBHPPELL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x2333D20", Offset = "0x2332B20", VA = "0x182333D20")]
	private void HFJNMFGGBJP(IOFNFGHMKGC OJHDCGLFIGP, StringBuilder IHOCFABMDIP, IEnumerable<PersistenceView> FBLBBMMKOFA, in KAOKLILBFNH PAKEAHNPOIE, ref EDCLOMJFAPK LBNDJKJAFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x23340A0", Offset = "0x2332EA0", VA = "0x1823340A0")]
	private void PIKNBOOJMEK(IOFNFGHMKGC OJHDCGLFIGP, StringBuilder IHOCFABMDIP, PersistenceView LFIMBOIOPFD, ref EDCLOMJFAPK LBNDJKJAFLM, in KAOKLILBFNH PAKEAHNPOIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
internal class JBJPDOJJABJ : KAFKKLBILBI
{
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private sealed class ENFBJKPKFKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public CPNCAGGGIFF.AKNNMODCGFG roomDataUpload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public byte[] data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public CPNCAGGGIFF.AKNNMODCGFG subRoomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public ENFBJKPKFKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x32BD6A0", Offset = "0x32BC4A0", VA = "0x1832BD6A0")]
		internal object <UploadRoomData>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x32BD730", Offset = "0x32BC530", VA = "0x1832BD730")]
		internal object <UploadRoomData>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x32BD780", Offset = "0x32BC580", VA = "0x1832BD780")]
		internal object <UploadRoomData>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x32BD7F0", Offset = "0x32BC5F0", VA = "0x1832BD7F0")]
		internal object <UploadRoomData>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private struct EBGAEMOCMHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public AsyncTaskMethodBuilder<(CPNCAGGGIFF.AKNNMODCGFG roomDataUpload, CPNCAGGGIFF.AKNNMODCGFG subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public LKMGECBKGBM roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public JBJPDOJJABJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		private ENFBJKPKFKF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		private float <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		private TaskAwaiter<CPNCAGGGIFF.AKNNMODCGFG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x32BBE00", Offset = "0x32BAC00", VA = "0x1832BBE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x32BC8B0", Offset = "0x32BB6B0", VA = "0x1832BC8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private struct MINHACLOICC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public AsyncTaskMethodBuilder<KEBPHEIFBOC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public JBJPDOJJABJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		public LKMGECBKGBM roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		private TaskAwaiter<(CPNCAGGGIFF.AKNNMODCGFG roomDataUpload, CPNCAGGGIFF.AKNNMODCGFG subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		private TaskAwaiter<KOAGAKIDHIL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x32C74D0", Offset = "0x32C62D0", VA = "0x1832C74D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x32C78B0", Offset = "0x32C66B0", VA = "0x1832C78B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct BBDJIICMOEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public AsyncTaskMethodBuilder<ALDCBDNNGDB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public JBJPDOJJABJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public LKMGECBKGBM roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private TaskAwaiter<(CPNCAGGGIFF.AKNNMODCGFG roomDataUpload, CPNCAGGGIFF.AKNNMODCGFG subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private TaskAwaiter<ALDCBDNNGDB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x32B8640", Offset = "0x32B7440", VA = "0x1832B8640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x32B89D0", Offset = "0x32B77D0", VA = "0x1832B89D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private sealed class DIPBHGHJIEC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016A")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000605")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000606")]
			public AsyncTaskMethodBuilder<EBIJFBKIDNI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000607")]
			public DIPBHGHJIEC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000608")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000609")]
			private EBIJFBKIDNI <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400060A")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400060B")]
			private TaskAwaiter<ALDCBDNNGDB> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400060C")]
			private TaskAwaiter<KEBPHEIFBOC> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400060D")]
			private TaskAwaiter<EBIJFBKIDNI> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60005AA")]
			[Cpp2IlInjected.Address(RVA = "0x3EDB510", Offset = "0x3EDA310", VA = "0x183EDB510", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x3EDC240", Offset = "0x3EDB040", VA = "0x183EDC240", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public JBJPDOJJABJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public LKMGECBKGBM roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public DIPBHGHJIEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x32BBC90", Offset = "0x32BAA90", VA = "0x1832BBC90")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<EBIJFBKIDNI> <UploadRoomDataBlobAndSyncReload>b__0(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private struct DILCFMDBCDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public AsyncTaskMethodBuilder<EBIJFBKIDNI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public JBJPDOJJABJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public LKMGECBKGBM roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		private TaskAwaiter<EBIJFBKIDNI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x32BB9A0", Offset = "0x32BA7A0", VA = "0x1832BB9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x32BBC40", Offset = "0x32BAA40", VA = "0x1832BBC40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40005DB")]
	private const float JGEKPMABHLB = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	private readonly JBIKLGIDHCH ADAKCMAAAFM;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private BNMEKDBAOON BECJGHCKHIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x23443F0", Offset = "0x23431F0", VA = "0x1823443F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x2346920", Offset = "0x2345720", VA = "0x182346920")]
	public JBJPDOJJABJ(OPMGMKLBION LHKCEHFGEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x23464B0", Offset = "0x23452B0", VA = "0x1823464B0")]
	[AsyncStateMachine(typeof(EBGAEMOCMHK))]
	private Task<(CPNCAGGGIFF.AKNNMODCGFG, CPNCAGGGIFF.AKNNMODCGFG)> EJLPEBEKOIJ(LKMGECBKGBM BALDFHIGHBN, long MOLCFNPABNJ, long PECECCFMGMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x2346620", Offset = "0x2345420", VA = "0x182346620")]
	[AsyncStateMachine(typeof(MINHACLOICC))]
	public Task<KEBPHEIFBOC> LKGCFPKGPIA(int MFEAAAIIPBH, LKMGECBKGBM BALDFHIGHBN, long MOLCFNPABNJ, long PECECCFMGMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x2346790", Offset = "0x2345590", VA = "0x182346790")]
	[AsyncStateMachine(typeof(BBDJIICMOEH))]
	private Task<ALDCBDNNGDB> MKPHCIPBCOH(string LPNGHDMHFPE, int MFEAAAIIPBH, LKMGECBKGBM BALDFHIGHBN, long MOLCFNPABNJ, long PECECCFMGMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x2346310", Offset = "0x2345110", VA = "0x182346310")]
	[AsyncStateMachine(typeof(DILCFMDBCDG))]
	public Task<EBIJFBKIDNI> AHPKLMPCDDJ(int MFEAAAIIPBH, LKMGECBKGBM BALDFHIGHBN, long MOLCFNPABNJ, long PECECCFMGMF, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016C")]
public class JPBBJDIHKKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000618")]
	private readonly Guid HEHOBBBEICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000619")]
	private readonly EHJEKJMFKEA HOLLDENJHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400061A")]
	private BKDHKLDKOEI DEHKKADBBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400061B")]
	private int? BIEINBAPNAJ;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Guid MOPMMBDNOPL
	{
		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0xAC10F0", Offset = "0xABFEF0", VA = "0x180AC10F0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x234A4A0", Offset = "0x23492A0", VA = "0x18234A4A0")]
	public JPBBJDIHKKD(EHJEKJMFKEA HOLLDENJHAO, [Optional] Guid? HEHOBBBEICN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x20FBED0", Offset = "0x20FACD0", VA = "0x1820FBED0")]
	public JPBBJDIHKKD LMBCGHJIBCO(BKDHKLDKOEI DEHKKADBBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x234A330", Offset = "0x2349130", VA = "0x18234A330")]
	public EBIJFBKIDNI FJCJCNIEEHC(out Guid APDFCJDGEAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x234A410", Offset = "0x2349210", VA = "0x18234A410")]
	public JPBBJDIHKKD LGKAHKDFINB(NAJNLFAFJGC EKLMBAFFHEO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
public static class DMFNFFMDBLH
{
	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x2335380", Offset = "0x2334180", VA = "0x182335380")]
	public static JPCHJAOPHGN NFFGDIFEJAA(this BCCAOCCFAIE LFFEAHLLHAI)
	{
		return default(JPCHJAOPHGN);
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CreateAssetMenu]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200016F")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400061F")]
			public EIIFCLNONEI ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000620")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000621")]
			public EIIFCLNONEI HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000622")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000623")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000624")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60005BA")]
			[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400061C")]
		private static EIIFCLNONEI[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		private Dictionary<EIIFCLNONEI, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x2AAD010", Offset = "0x2AABE10", VA = "0x182AAD010")]
		public bool JCBNAEIKEJH(EIIFCLNONEI DDFPLICKPCJ, out ResultConfig HHBPPIPMCAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x2AACEF0", Offset = "0x2AABCF0", VA = "0x182AACEF0")]
		public ResultConfig CLCEPEJKAEO(EIIFCLNONEI HDEEEPPJEGL, [Optional] HashSet<EIIFCLNONEI> DBFHBEFEGCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x2AAD600", Offset = "0x2AAC400", VA = "0x182AAD600", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x2AAD080", Offset = "0x2AABE80", VA = "0x182AAD080", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0xC042B0", Offset = "0xC030B0", VA = "0x180C042B0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000171")]
public static class HOOPKNLOMIP
{
	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x2343150", Offset = "0x2341F50", VA = "0x182343150")]
	[IMCONJMNGLO(KJBNBKOGAAL.GameOnly)]
	private static void LGCOMGILHEP(ELODGKLHEKG LGHJONCDAJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000172")]
public interface JMDHMLDEGBF : IEquatable<JMDHMLDEGBF>
{
	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	NNGBDGBOMML CLKBGEEBAFN
	{
		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	DateTime OHPDEOABEIL
	{
		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PNBPAKBPFFA();

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IOCDEKMGBBH(long MOLCFNPABNJ, long DFGMBHPPELL, out LKMGECBKGBM BALDFHIGHBN);
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
internal class PCJEHKKGIIJ : HOFBEIMOCLK
{
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private sealed class JEOEJCDAGOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public AJPLFBMOADO autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public JEOEJCDAGOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x3ED2C50", Offset = "0x3ED1A50", VA = "0x183ED2C50")]
		internal object <TrySaveAutosaveData>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400062A")]
	private readonly CELJAEDAMMM DLPINKFHFNJ;

	[Cpp2IlInjected.Token(Token = "0x400062B")]
	private const int FOONCIMKFFL = 5;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<JMDHMLDEGBF> OJPOONMMHCK
	{
		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA840", Offset = "0x2AA9640", VA = "0x182AAA840", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x2AAAEB0", Offset = "0x2AA9CB0", VA = "0x182AAAEB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x6C4C50", Offset = "0x6C3A50", VA = "0x1806C4C50")]
	[Preserve]
	public PCJEHKKGIIJ([CDAJDCGEMGI(null)] CELJAEDAMMM DLPINKFHFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x2AAAA60", Offset = "0x2AA9860", VA = "0x182AAAA60", Slot = "6")]
	public bool DLMAJFBMFNE(long MOLCFNPABNJ, long DFGMBHPPELL, LKMGECBKGBM BALDFHIGHBN, AJPLFBMOADO IPKNOBCDJAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0x2AAAE10", Offset = "0x2AA9C10", VA = "0x182AAAE10")]
	private void HIOIFCBOJNK(JMDHMLDEGBF DKJPBMEIDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA8E0", Offset = "0x2AA96E0", VA = "0x182AAA8E0", Slot = "7")]
	public bool CPGKDBCEKLP(long MOLCFNPABNJ, long DFGMBHPPELL, out JMDHMLDEGBF BACNBDCPFIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x2AAAD60", Offset = "0x2AA9B60", VA = "0x182AAAD60", Slot = "8")]
	public bool FDLNGJBHNCB(long MOLCFNPABNJ, long DFGMBHPPELL, AJPLFBMOADO IPKNOBCDJAN, out JMDHMLDEGBF BACNBDCPFIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA2C0", Offset = "0x2AA90C0", VA = "0x182AAA2C0")]
	private void AGIBOOKHHCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA720", Offset = "0x2AA9520", VA = "0x182AAA720", Slot = "9")]
	public void CDMIBJCAELC(long MOLCFNPABNJ, long DFGMBHPPELL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000176")]
internal abstract class GAJOHNFLFGI : CELJAEDAMMM
{
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	protected enum MFDIBGFNHJF : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private sealed class CCGEBCHPLLK : IEnumerable<JMDHMLDEGBF>, IEnumerable, IEnumerator<JMDHMLDEGBF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		private JMDHMLDEGBF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public GAJOHNFLFGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		private AJPLFBMOADO autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public AJPLFBMOADO <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		private JMDHMLDEGBF System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60005E3")]
			[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60005E5")]
			[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x754F90", Offset = "0x753D90", VA = "0x180754F90")]
		[DebuggerHidden]
		public CCGEBCHPLLK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x2A96FE0", Offset = "0x2A95DE0", VA = "0x182A96FE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x2A971F0", Offset = "0x2A95FF0", VA = "0x182A971F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x2A97140", Offset = "0x2A95F40", VA = "0x182A97140", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JMDHMLDEGBF> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x2A97140", Offset = "0x2A95F40", VA = "0x182A97140", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class EOGPNKFOHLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public AJPLFBMOADO autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public EOGPNKFOHLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x2A9A370", Offset = "0x2A99170", VA = "0x182A9A370")]
		internal object <SaveAutosave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private sealed class DBBHBCGBHAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public GAJOHNFLFGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public DBBHBCGBHAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x2A97910", Offset = "0x2A96710", VA = "0x182A97910")]
		internal void <TryReadAutosaveFile>b__0(HLKPICCBEBB.DEENNFCDPID ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000631")]
	protected readonly string LANGDLLJDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000632")]
	private readonly object GPCBGLEIDBJ;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public abstract NNGBDGBOMML CLKBGEEBAFN
	{
		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x233B890", Offset = "0x233A690", VA = "0x18233B890")]
	protected GAJOHNFLFGI([CanBeNull] string EIOEJAMHJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x233B310", Offset = "0x233A110", VA = "0x18233B310", Slot = "5")]
	public bool GLOHAJBMNDO(long MOLCFNPABNJ, long DFGMBHPPELL, AJPLFBMOADO IPKNOBCDJAN, out JMDHMLDEGBF DKJPBMEIDDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x233B810", Offset = "0x233A610", VA = "0x18233B810", Slot = "6")]
	[IteratorStateMachine(typeof(CCGEBCHPLLK))]
	public IEnumerable<JMDHMLDEGBF> OIJCCGHNJDJ(AJPLFBMOADO IPKNOBCDJAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void DKLNLPAOBCB(Stream HHMPJGCDHKP, long MOLCFNPABNJ, long DFGMBHPPELL, LKMGECBKGBM BALDFHIGHBN);

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool NFPCELLPLOM(Stream COOMPKGFBMI, long MOLCFNPABNJ, long DFGMBHPPELL, NLDLEPKEJNC BJGIOAGOLII, out LKMGECBKGBM BALDFHIGHBN);

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0x233AF80", Offset = "0x2339D80", VA = "0x18233AF80", Slot = "7")]
	public JMDHMLDEGBF CCPFCNBCNFD(long MOLCFNPABNJ, long DFGMBHPPELL, LKMGECBKGBM BALDFHIGHBN, AJPLFBMOADO IPKNOBCDJAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo DJCFBNGMDEB(long MOLCFNPABNJ, long DFGMBHPPELL, AJPLFBMOADO IPKNOBCDJAN, MFDIBGFNHJF MIFLCKHFGOE);

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo ICHCGDFODCH(AJPLFBMOADO IPKNOBCDJAN, MFDIBGFNHJF MIFLCKHFGOE);

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(RVA = "0x233B4F0", Offset = "0x233A2F0", VA = "0x18233B4F0")]
	protected void JOBGOJHHLHP(HLKPICCBEBB.DEENNFCDPID IPIOPDFMFIE, string IALJJELLBDF, FileInfo FAEGOFALDDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(RVA = "0x233B560", Offset = "0x233A360", VA = "0x18233B560")]
	internal bool LKCDEOPEGLN(FileInfo DFBNDHNPDFL, long MOLCFNPABNJ, long DFGMBHPPELL, out LKMGECBKGBM BALDFHIGHBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	private void LOEEIFGHEBD(Exception AAGNMLCAPCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
internal class EFHPABJAAPM : GAJOHNFLFGI
{
	[Cpp2IlInjected.Token(Token = "0x4000642")]
	private const string HPJHBOOJCIE = "V2";

	[Cpp2IlInjected.Token(Token = "0x4000643")]
	private const string BJAAFAPJMGP = "AutosavesV2";

	[Cpp2IlInjected.Token(Token = "0x4000644")]
	private const string FHKLIBDDNFB = "RecoveryV2";

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public override NNGBDGBOMML CLKBGEEBAFN
	{
		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0xF3E8C0", Offset = "0xF3D6C0", VA = "0x180F3E8C0", Slot = "8")]
		get
		{
			return default(NNGBDGBOMML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x2336A00", Offset = "0x2335800", VA = "0x182336A00")]
	public EFHPABJAAPM([Optional] string EIOEJAMHJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x2336390", Offset = "0x2335190", VA = "0x182336390")]
	private void KLJECLIKHDC(AJPLFBMOADO IPKNOBCDJAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x2336030", Offset = "0x2334E30", VA = "0x182336030", Slot = "9")]
	internal override void DKLNLPAOBCB(Stream HHMPJGCDHKP, long MOLCFNPABNJ, long DFGMBHPPELL, LKMGECBKGBM BALDFHIGHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x2336410", Offset = "0x2335210", VA = "0x182336410", Slot = "10")]
	internal override bool NFPCELLPLOM(Stream COOMPKGFBMI, long MOLCFNPABNJ, long DFGMBHPPELL, NLDLEPKEJNC BJGIOAGOLII, out LKMGECBKGBM BALDFHIGHBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x2335F40", Offset = "0x2334D40", VA = "0x182335F40", Slot = "11")]
	protected override FileInfo DJCFBNGMDEB(long MOLCFNPABNJ, long DFGMBHPPELL, AJPLFBMOADO IPKNOBCDJAN, MFDIBGFNHJF MIFLCKHFGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(RVA = "0x2336280", Offset = "0x2335080", VA = "0x182336280", Slot = "12")]
	protected override DirectoryInfo ICHCGDFODCH(AJPLFBMOADO IPKNOBCDJAN, MFDIBGFNHJF MIFLCKHFGOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
internal sealed class CMCAFHHICMG : GAJOHNFLFGI
{
	[Cpp2IlInjected.Token(Token = "0x4000645")]
	private static readonly byte[] CCJNKBLKLDJ;

	[Cpp2IlInjected.Token(Token = "0x4000646")]
	private const string BJAAFAPJMGP = "Autosaves";

	[Cpp2IlInjected.Token(Token = "0x4000647")]
	private const string FHKLIBDDNFB = "Recovery";

	[Cpp2IlInjected.Token(Token = "0x4000648")]
	private const string IOMIPAFEHMM = "Autosaves";

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000649")]
	private readonly byte[] OANGIHEFCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400064A")]
	private readonly byte[] EFODDDDIEGH;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public override NNGBDGBOMML CLKBGEEBAFN
	{
		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x6A0480", Offset = "0x69F280", VA = "0x1806A0480", Slot = "8")]
		get
		{
			return default(NNGBDGBOMML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x23329E0", Offset = "0x23317E0", VA = "0x1823329E0")]
	public CMCAFHHICMG([Optional] string EIOEJAMHJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x2331C80", Offset = "0x2330A80", VA = "0x182331C80", Slot = "9")]
	internal override void DKLNLPAOBCB(Stream HHMPJGCDHKP, long MOLCFNPABNJ, long DFGMBHPPELL, LKMGECBKGBM BALDFHIGHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x2332150", Offset = "0x2330F50", VA = "0x182332150", Slot = "10")]
	internal override bool NFPCELLPLOM(Stream COOMPKGFBMI, long MOLCFNPABNJ, long DFGMBHPPELL, NLDLEPKEJNC BJGIOAGOLII, out LKMGECBKGBM BALDFHIGHBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x2332040", Offset = "0x2330E40", VA = "0x182332040")]
	private void LMKBPLJICIP(byte[] HFAIGCGNPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x2331B50", Offset = "0x2330950", VA = "0x182331B50", Slot = "11")]
	protected override FileInfo DJCFBNGMDEB(long MOLCFNPABNJ, long DFGMBHPPELL, AJPLFBMOADO IPKNOBCDJAN, MFDIBGFNHJF MIFLCKHFGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0x2331F20", Offset = "0x2330D20", VA = "0x182331F20", Slot = "12")]
	protected override DirectoryInfo ICHCGDFODCH(AJPLFBMOADO IPKNOBCDJAN, MFDIBGFNHJF MIFLCKHFGOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
public enum NNGBDGBOMML : byte
{
	[Cpp2IlInjected.Token(Token = "0x400064C")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x400064D")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x400064E")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal class ONHLMGKHHJK : CELJAEDAMMM
{
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private sealed class COHHKDFCNLM : IEnumerable<JMDHMLDEGBF>, IEnumerable, IEnumerator<JMDHMLDEGBF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		private JMDHMLDEGBF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public ONHLMGKHHJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		private AJPLFBMOADO autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public AJPLFBMOADO <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		private NNGBDGBOMML[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		private IEnumerator<JMDHMLDEGBF> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		private JMDHMLDEGBF System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x754F90", Offset = "0x753D90", VA = "0x180754F90")]
		[DebuggerHidden]
		public COHHKDFCNLM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x3ECE480", Offset = "0x3ECD280", VA = "0x183ECE480", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x3ECE0B0", Offset = "0x3ECCEB0", VA = "0x183ECE0B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x3ECE510", Offset = "0x3ECD310", VA = "0x183ECE510")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x3ECE440", Offset = "0x3ECD240", VA = "0x183ECE440", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x3ECE390", Offset = "0x3ECD190", VA = "0x183ECE390", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JMDHMLDEGBF> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x3ECE390", Offset = "0x3ECD190", VA = "0x183ECE390", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400064F")]
	private readonly NNGBDGBOMML[] EIFHFGJIDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000650")]
	private readonly Dictionary<NNGBDGBOMML, CELJAEDAMMM> ADLGENEBGGM;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public NNGBDGBOMML CLKBGEEBAFN
	{
		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x2AA85A0", Offset = "0x2AA73A0", VA = "0x182AA85A0", Slot = "4")]
		get
		{
			return default(NNGBDGBOMML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8660", Offset = "0x2AA7460", VA = "0x182AA8660")]
	[Preserve]
	public ONHLMGKHHJK(params CELJAEDAMMM[] MCJBELEEOMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8440", Offset = "0x2AA7240", VA = "0x182AA8440", Slot = "5")]
	public bool GLOHAJBMNDO(long MOLCFNPABNJ, long DFGMBHPPELL, AJPLFBMOADO IPKNOBCDJAN, out JMDHMLDEGBF DKJPBMEIDDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8120", Offset = "0x2AA6F20", VA = "0x182AA8120")]
	private void CAMLBDBEHID(int MEAMKJMDBNA, long MOLCFNPABNJ, long DFGMBHPPELL, AJPLFBMOADO IPKNOBCDJAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x2AA85E0", Offset = "0x2AA73E0", VA = "0x182AA85E0", Slot = "6")]
	[IteratorStateMachine(typeof(COHHKDFCNLM))]
	public IEnumerable<JMDHMLDEGBF> OIJCCGHNJDJ(AJPLFBMOADO IPKNOBCDJAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8350", Offset = "0x2AA7150", VA = "0x182AA8350", Slot = "7")]
	public JMDHMLDEGBF CCPFCNBCNFD(long MOLCFNPABNJ, long DFGMBHPPELL, LKMGECBKGBM BALDFHIGHBN, AJPLFBMOADO IPKNOBCDJAN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal static class BDILLOACMOJ
{
	[Cpp2IlInjected.Token(Token = "0x400065E")]
	internal const int CHABOAHLFHK = 32;

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x232E3C0", Offset = "0x232D1C0", VA = "0x18232E3C0")]
	internal static byte[] EEAPFDDHOFB(byte[] HFAIGCGNPJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x232E640", Offset = "0x232D440", VA = "0x18232E640")]
	public static void PAGLKLBDFLG(Stream KCFDLMABGLC, byte[] KHBDIABKGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x232E460", Offset = "0x232D260", VA = "0x18232E460")]
	public static bool KJFBLGMONOM(Stream KCFDLMABGLC, long KEABMFIIKFP, NLDLEPKEJNC IMPBFMIKHHH, out byte[] HOHAKHAHFMN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
internal sealed class GDHFAKLOIOC : JMDHMLDEGBF, IEquatable<JMDHMLDEGBF>, IEquatable<GDHFAKLOIOC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400065F")]
	private readonly GAJOHNFLFGI DCBGILCIHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000660")]
	public readonly FileInfo KGPMLIFOMEG;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public NNGBDGBOMML CLKBGEEBAFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x81BF20", Offset = "0x81AD20", VA = "0x18081BF20", Slot = "4")]
		get
		{
			return default(NNGBDGBOMML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public DateTime OHPDEOABEIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x233C1C0", Offset = "0x233AFC0", VA = "0x18233C1C0", Slot = "5")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x233C740", Offset = "0x233B540", VA = "0x18233C740")]
	public GDHFAKLOIOC(GAJOHNFLFGI PHGBMHIKGIC, FileInfo DFBNDHNPDFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x233C690", Offset = "0x233B490", VA = "0x18233C690", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x233C5D0", Offset = "0x233B3D0", VA = "0x18233C5D0", Slot = "6")]
	public void PNBPAKBPFFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x233C590", Offset = "0x233B390", VA = "0x18233C590", Slot = "7")]
	public bool IOCDEKMGBBH(long MOLCFNPABNJ, long DFGMBHPPELL, out LKMGECBKGBM BALDFHIGHBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x233C360", Offset = "0x233B160", VA = "0x18233C360", Slot = "8")]
	public bool Equals(JMDHMLDEGBF HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x233C440", Offset = "0x233B240", VA = "0x18233C440", Slot = "9")]
	public bool Equals(GDHFAKLOIOC HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x233C260", Offset = "0x233B060", VA = "0x18233C260", Slot = "0")]
	public override bool Equals(object CCPIHKCBGHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x233C4F0", Offset = "0x233B2F0", VA = "0x18233C4F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x19D5E50", Offset = "0x19D4C50", VA = "0x1819D5E50")]
	public static bool CJJJLAGEFIA(GDHFAKLOIOC EHPOMDFBCKH, GDHFAKLOIOC DJPDMBCBGFI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x19D6370", Offset = "0x19D5170", VA = "0x1819D6370")]
	public static bool HNHKEOFMCPG(GDHFAKLOIOC EHPOMDFBCKH, GDHFAKLOIOC DJPDMBCBGFI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
public delegate void NLDLEPKEJNC(HLKPICCBEBB.DEENNFCDPID DLHALMCOPEO, string GOJKMEMCPDE);
[Cpp2IlInjected.Token(Token = "0x2000184")]
internal interface CELJAEDAMMM
{
	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	NNGBDGBOMML CLKBGEEBAFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GLOHAJBMNDO(long MOLCFNPABNJ, long DFGMBHPPELL, AJPLFBMOADO IPKNOBCDJAN, out JMDHMLDEGBF DKJPBMEIDDE);

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<JMDHMLDEGBF> OIJCCGHNJDJ(AJPLFBMOADO IPKNOBCDJAN);

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JMDHMLDEGBF CCPFCNBCNFD(long MOLCFNPABNJ, long DFGMBHPPELL, LKMGECBKGBM BALDFHIGHBN, AJPLFBMOADO IPKNOBCDJAN);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000187")]
public class ABAJDIGBNMI
{
	[Cpp2IlInjected.Token(Token = "0x4000662")]
	private static byte[] GCDEGNDFAID;

	[Cpp2IlInjected.Token(Token = "0x4000663")]
	private static int BBIOPAKABFB;

	[Cpp2IlInjected.Token(Token = "0x4000664")]
	private static int ACMEFJOAGOE;

	[Cpp2IlInjected.Token(Token = "0x4000665")]
	private static BigInteger MCNKOBABGEE;

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public ABAJDIGBNMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x232B490", Offset = "0x232A290", VA = "0x18232B490")]
	private static string DPCKFJIDOBP(byte[] BMMLDIMMAAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x232B5A0", Offset = "0x232A3A0", VA = "0x18232B5A0")]
	public static string FBACHCLJNPO(byte[] HFAIGCGNPJJ, bool KDMKCCLJMIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000189")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000666")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200018A")]
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
