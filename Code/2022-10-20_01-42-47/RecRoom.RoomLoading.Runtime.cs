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
	[Cpp2IlInjected.Address(RVA = "0x2BDFF10", Offset = "0x2BDED10", VA = "0x182BDFF10")]
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
		[Cpp2IlInjected.Address(RVA = "0x33C4850", Offset = "0x33C3650", VA = "0x1833C4850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x33C4A30", Offset = "0x33C3830", VA = "0x1833C4A30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x33D5590", Offset = "0x33D4390", VA = "0x1833D5590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x33D5750", Offset = "0x33D4550", VA = "0x1833D5750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	[Preserve]
	public HBDEEFMIINL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2483950", Offset = "0x2482750", VA = "0x182483950", Slot = "4")]
	[AsyncStateMachine(typeof(CMHBDDEIJOC))]
	public Task<IReadOnlyList<AFNHPMBCFDA>> PHKFHPPOMMO(long MOLCFNPABNJ, long PECECCFMGMF, [Optional] CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2483810", Offset = "0x2482610", VA = "0x182483810", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3EEFDD0", Offset = "0x3EEEBD0", VA = "0x183EEFDD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x3EF01A0", Offset = "0x3EEEFA0", VA = "0x183EF01A0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x658BD0", Offset = "0x6579D0", VA = "0x180658BD0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x658120", Offset = "0x656F20", VA = "0x180658120", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xFA3870", Offset = "0xFA2670", VA = "0x180FA3870", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public OJFBACJAEIP? GNDCBFEBNHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x1BC3F20", Offset = "0x1BC2D20", VA = "0x181BC3F20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public HHPPMLKOCJI? IFBKMOFFNFL
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x1A0CBB0", Offset = "0x1A0B9B0", VA = "0x181A0CBB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public JPMKOKIPJAL IOAAOIGINFG
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x67DAA0", Offset = "0x67C8A0", VA = "0x18067DAA0", Slot = "10")]
			get
			{
				return default(JPMKOKIPJAL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x33C3C20", Offset = "0x33C2A20", VA = "0x1833C3C20", Slot = "9")]
		[AsyncStateMachine(typeof(PFONFKPMKBL))]
		public Task<NHOKIGNMHJB> OLHCAOMHKBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x33C3D50", Offset = "0x33C2B50", VA = "0x1833C3D50")]
		public BPDIMNNBMFM(int HCKMPFIABHH, DAJNLJJOLEA AFCCLCENAOE, AFNHPMBCFDA FNHOIGCIDKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x33C3A20", Offset = "0x33C2820", VA = "0x1833C3A20", Slot = "11")]
		public bool Equals(FPCAMBPEPGC HNOJKNGFFBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x33C3AB0", Offset = "0x33C28B0", VA = "0x1833C3AB0", Slot = "0")]
		public override bool Equals(object CCPIHKCBGHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x33C3B50", Offset = "0x33C2950", VA = "0x1833C3B50")]
		private bool GIPIIPCAPGP(BPDIMNNBMFM HNOJKNGFFBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x33C3B90", Offset = "0x33C2990", VA = "0x1833C3B90", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x3EE6930", Offset = "0x3EE5730", VA = "0x183EE6930", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x3EE6B70", Offset = "0x3EE5970", VA = "0x183EE6B70", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x33CD640", Offset = "0x33CC440", VA = "0x1833CD640", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public DAJNLJJOLEA CDONJJMLHCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x33CD780", Offset = "0x33CC580", VA = "0x1833CD780", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime EOLNLLMECDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x33CD4A0", Offset = "0x33CC2A0", VA = "0x1833CD4A0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public OJFBACJAEIP? GNDCBFEBNHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x33CD820", Offset = "0x33CC620", VA = "0x1833CD820", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public HHPPMLKOCJI? IFBKMOFFNFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x33CD870", Offset = "0x33CC670", VA = "0x1833CD870", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public JPMKOKIPJAL IOAAOIGINFG
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6722A0", Offset = "0x6710A0", VA = "0x1806722A0", Slot = "10")]
			get
			{
				return default(JPMKOKIPJAL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6FCD10", Offset = "0x6FBB10", VA = "0x1806FCD10")]
		public JNOIPLGDNDA(JMDHMLDEGBF DKJPBMEIDDE, OJFBACJAEIP DMNANDOGMGA, HHPPMLKOCJI DLFJMNNDMFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x33CD8C0", Offset = "0x33CC6C0", VA = "0x1833CD8C0", Slot = "9")]
		[AsyncStateMachine(typeof(EAJNBJLGBMB))]
		public Task<NHOKIGNMHJB> OLHCAOMHKBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x33CD5A0", Offset = "0x33CC3A0", VA = "0x1833CD5A0", Slot = "11")]
		public bool Equals(FPCAMBPEPGC HNOJKNGFFBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x33CD4F0", Offset = "0x33CC2F0", VA = "0x1833CD4F0", Slot = "0")]
		public override bool Equals(object CCPIHKCBGHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x33CD690", Offset = "0x33CC490", VA = "0x1833CD690")]
		private bool GIPIIPCAPGP(JNOIPLGDNDA HNOJKNGFFBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x33CD6F0", Offset = "0x33CC4F0", VA = "0x1833CD6F0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x3EE8700", Offset = "0x3EE7500", VA = "0x183EE8700", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x3EE88C0", Offset = "0x3EE76C0", VA = "0x183EE88C0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x33C32D0", Offset = "0x33C20D0", VA = "0x1833C32D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x6578C0", VA = "0x180658AC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime EOLNLLMECDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x65E170", Offset = "0x65CF70", VA = "0x18065E170", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public OJFBACJAEIP? GNDCBFEBNHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x33C3500", Offset = "0x33C2300", VA = "0x1833C3500", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public HHPPMLKOCJI? IFBKMOFFNFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x33C3550", Offset = "0x33C2350", VA = "0x1833C3550", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public JPMKOKIPJAL IOAAOIGINFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x65E170", Offset = "0x65CF70", VA = "0x18065E170", Slot = "10")]
			get
			{
				return default(JPMKOKIPJAL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6FCD10", Offset = "0x6FBB10", VA = "0x1806FCD10")]
		public BEDNHFFJEFB(DAJNLJJOLEA AFCCLCENAOE, OJFBACJAEIP DMNANDOGMGA, HHPPMLKOCJI DLFJMNNDMFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x33C35A0", Offset = "0x33C23A0", VA = "0x1833C35A0", Slot = "9")]
		[AsyncStateMachine(typeof(FDEEFCANPMA))]
		public Task<NHOKIGNMHJB> OLHCAOMHKBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x33C3040", Offset = "0x33C1E40", VA = "0x1833C3040", Slot = "11")]
		public bool Equals(FPCAMBPEPGC HNOJKNGFFBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x33C3180", Offset = "0x33C1F80", VA = "0x1833C3180", Slot = "0")]
		public override bool Equals(object CCPIHKCBGHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x33C3450", Offset = "0x33C2250", VA = "0x1833C3450", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x33C3350", Offset = "0x33C2150", VA = "0x1833C3350")]
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
		[Cpp2IlInjected.Address(RVA = "0x33C4DF0", Offset = "0x33C3BF0", VA = "0x1833C4DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x33C5880", Offset = "0x33C4680", VA = "0x1833C5880", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x33C9F10", Offset = "0x33C8D10", VA = "0x1833C9F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x33CA890", Offset = "0x33C9690", VA = "0x1833CA890", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2487A70", Offset = "0x2486870", VA = "0x182487A70")]
	[Preserve]
	public JDGLKLJLFFJ([CDAJDCGEMGI(null)] IPPKIEIBOFP DJNJKFOKHDH, [CDAJDCGEMGI(null)] HOFBEIMOCLK MIPHFGDBBHA, [CDAJDCGEMGI(null)] BOLJJNKMECH CDMGLLLPOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2487710", Offset = "0x2486510", VA = "0x182487710")]
	[AsyncStateMachine(typeof(DAHGHCLBHNM))]
	public Task<IList<FPCAMBPEPGC>> FOOGCLKOEDG(long MOLCFNPABNJ, long DFGMBHPPELL, bool CIBJAFMGMIK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2487860", Offset = "0x2486660", VA = "0x182487860")]
	private bool ILMPBBOHNIF(DateTime? IIOCMIBPKOJ, long MOLCFNPABNJ, long DFGMBHPPELL, out JMDHMLDEGBF BACNBDCPFIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x24875D0", Offset = "0x24863D0", VA = "0x1824875D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BDFEF0", Offset = "0x2BDECF0", VA = "0x182BDFEF0")]
	public KMCFCCDNIEO(long PHDHDONKJIJ, long PECECCFMGMF, GJPCHKKJFNE NKICFHCCMMH, [CanBeNull] Exception DGMBGDCANEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2BDFEA0", Offset = "0x2BDECA0", VA = "0x182BDFEA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BE6290", Offset = "0x2BE5090", VA = "0x182BE6290")]
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
		[Cpp2IlInjected.Address(RVA = "0x658120", Offset = "0x656F20", VA = "0x180658120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x658130", Offset = "0x656F30", VA = "0x180658130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x657F40", Offset = "0x656D40", VA = "0x180657F40")]
	public IGBEHNFHHGH(APEIEEGPGIG HBECHKJHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2486220", Offset = "0x2485020", VA = "0x182486220")]
	public IGBEHNFHHGH LIFDJCFHMHM(string CCJNKBLKLDJ, string IGJPNMBCJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x24861A0", Offset = "0x2484FA0", VA = "0x1824861A0")]
	public bool FEAGEKGJIPK(out IEnumerable<KeyValuePair<string, string>> HJLJBAIHHDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x223CC80", Offset = "0x223BA80", VA = "0x18223CC80")]
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
	[Cpp2IlInjected.Address(RVA = "0x248BD50", Offset = "0x248AB50", VA = "0x18248BD50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BDF5F0", Offset = "0x2BDE3F0", VA = "0x182BDF5F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF890", Offset = "0x2BDE690", VA = "0x182BDF890", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BEDA30", Offset = "0x2BEC830", VA = "0x182BEDA30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x9DD5E0", Offset = "0x9DC3E0", VA = "0x1809DD5E0")]
		[DebuggerHidden]
		public KJLCBGEDHIF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2BDFA20", Offset = "0x2BDE820", VA = "0x182BDFA20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2BDFE60", Offset = "0x2BDEC60", VA = "0x182BDFE60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2BDFDC0", Offset = "0x2BDEBC0", VA = "0x182BDFDC0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PLGHNFIOALA> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2BDFDC0", Offset = "0x2BDEBC0", VA = "0x182BDFDC0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6570D0", Offset = "0x655ED0", VA = "0x1806570D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x73A4A0", Offset = "0x7392A0", VA = "0x18073A4A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ODGLOMJMEFI JCGCGNPDDLC
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x66D760", Offset = "0x66C560", VA = "0x18066D760", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6E1000", Offset = "0x6DFE00", VA = "0x1806E1000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public JHHHHDEGGMN GNIOAJCHNPI
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6570B0", Offset = "0x655EB0", VA = "0x1806570B0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x73A490", Offset = "0x739290", VA = "0x18073A490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public IIFLENBNAPC JGNNILPHNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x66D770", Offset = "0x66C570", VA = "0x18066D770", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6F8AB0", Offset = "0x6F78B0", VA = "0x1806F8AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public JNPJMBDOPFL HLHMGDDEDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x66D780", Offset = "0x66C580", VA = "0x18066D780", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x769EB0", Offset = "0x768CB0", VA = "0x180769EB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public EBEKBJENPBA MHBPKGOACKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x66D700", Offset = "0x66C500", VA = "0x18066D700", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x67F860", Offset = "0x67E660", VA = "0x18067F860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public FAKBOJPCPEP EKICIMCAFFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x66D710", Offset = "0x66C510", VA = "0x18066D710", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x68EDB0", Offset = "0x68DBB0", VA = "0x18068EDB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public HFLPBFAPMMK NIGIFDPOLOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x6936D0", Offset = "0x6924D0", VA = "0x1806936D0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x68ED90", Offset = "0x68DB90", VA = "0x18068ED90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public IEIIFKOCFKM INJJKNCFFBE
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x65DD80", Offset = "0x65CB80", VA = "0x18065DD80", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8AB5A0", Offset = "0x8AA3A0", VA = "0x1808AB5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public ALADEOKCIJK NHKMBMIHGFC
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x65DE20", Offset = "0x65CC20", VA = "0x18065DE20", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7DAB10", Offset = "0x7D9910", VA = "0x1807DAB10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public NEGPONDKAKL DBJPAJAJPOE
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6936A0", Offset = "0x6924A0", VA = "0x1806936A0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8AABC0", Offset = "0x8A99C0", VA = "0x1808AABC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public CHLBMEJKKDL PJMLCEHEEJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x66D720", Offset = "0x66C520", VA = "0x18066D720", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x68EDA0", Offset = "0x68DBA0", VA = "0x18068EDA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public ABIMLOAGMPC HBLPGJFCBJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x66D730", Offset = "0x66C530", VA = "0x18066D730", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6DB540", Offset = "0x6DA340", VA = "0x1806DB540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public JENLDJDLCOI ABFCBMMFBNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x66D750", Offset = "0x66C550", VA = "0x18066D750", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x78E630", Offset = "0x78D430", VA = "0x18078E630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public DLGIDCPMJNG NOKHCGDMGDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x66D740", Offset = "0x66C540", VA = "0x18066D740", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x68EDC0", Offset = "0x68DBC0", VA = "0x18068EDC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public AJGEIEHEPFM EFACKMOCHAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x746200", Offset = "0x745000", VA = "0x180746200", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x746250", Offset = "0x745050", VA = "0x180746250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public KKAEGAFPCFN KMEBEIDGANF
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x70F7A0", Offset = "0x70E5A0", VA = "0x18070F7A0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x78BD80", Offset = "0x78AB80", VA = "0x18078BD80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public EEMNNFECFAA PAHCHCNKEGI
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x746120", Offset = "0x744F20", VA = "0x180746120", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x746210", Offset = "0x745010", VA = "0x180746210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public JBIKLGIDHCH HHIMENADHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7D7EE0", Offset = "0x7D6CE0", VA = "0x1807D7EE0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7D7FC0", Offset = "0x7D6DC0", VA = "0x1807D7FC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public APCGMHFIDII NGMLOFCBEHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x78CA10", Offset = "0x78B810", VA = "0x18078CA10", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7D8C30", Offset = "0x7D7A30", VA = "0x1807D8C30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public CJMIEMCMKCI KLOIIAMHEEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x78C710", Offset = "0x78B510", VA = "0x18078C710", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x78CA40", Offset = "0x78B840", VA = "0x18078CA40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public CIHDMMKNLFK FNHHEMKKCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x78C6F0", Offset = "0x78B4F0", VA = "0x18078C6F0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x78CA20", Offset = "0x78B820", VA = "0x18078CA20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public NMKLOINCMMF JEHNGAALMDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x78C700", Offset = "0x78B500", VA = "0x18078C700", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x78CA30", Offset = "0x78B830", VA = "0x18078CA30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public EEHJOGMMLGK IMNABOMJIHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7D8C20", Offset = "0x7D7A20", VA = "0x1807D8C20", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x1010CD0", Offset = "0x100FAD0", VA = "0x181010CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public AOJOFDEEIFK FGBHHNGDJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x78C9F0", Offset = "0x78B7F0", VA = "0x18078C9F0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x78CB90", Offset = "0x78B990", VA = "0x18078CB90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public ALAIHBFAIAD HHFLGHDJMHM
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x78CA00", Offset = "0x78B800", VA = "0x18078CA00", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x78CBA0", Offset = "0x78B9A0", VA = "0x18078CBA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public NEJIOMHPBHD AENAIAGABFL
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA1BCC0", Offset = "0xA1AAC0", VA = "0x180A1BCC0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA1B350", Offset = "0xA1A150", VA = "0x180A1B350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public HOFBEIMOCLK CGBGADENLKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA19E20", Offset = "0xA18C20", VA = "0x180A19E20", Slot = "33")]
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
		[Cpp2IlInjected.Address(RVA = "0x246B460", Offset = "0x246A260", VA = "0x18246B460", Slot = "42")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	private bool HIOODMBIJAM
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x246B510", Offset = "0x246A310", VA = "0x18246B510", Slot = "43")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	private CancellationToken LHBKNOBILLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x246B120", Offset = "0x2469F20", VA = "0x18246B120", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	private ELODGKLHEKG IGBOJODDOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	private event Action PCEDIHKBBPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x246B400", Offset = "0x246A200", VA = "0x18246B400", Slot = "34")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x246B140", Offset = "0x2469F40", VA = "0x18246B140", Slot = "35")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	private event AEHHHDFPHCF EBLPOMAENEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x246B9B0", Offset = "0x246A7B0", VA = "0x18246B9B0", Slot = "36")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x246B6B0", Offset = "0x246A4B0", VA = "0x18246B6B0", Slot = "37")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	private event AEHHHDFPHCF LMCLFELJPAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x246BC00", Offset = "0x246AA00", VA = "0x18246BC00", Slot = "38")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x246B3A0", Offset = "0x246A1A0", VA = "0x18246B3A0", Slot = "39")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event AEHHHDFPHCF BPIJENEIJNO
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x246BA10", Offset = "0x246A810", VA = "0x18246BA10", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x246B000", Offset = "0x2469E00", VA = "0x18246B000", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x246BC60", Offset = "0x246AA60", VA = "0x18246BC60")]
	[Preserve]
	internal AALCAFAHNDH([CDAJDCGEMGI(null)] ELODGKLHEKG BGLEKJNFDOI, [CDAJDCGEMGI(null)] HCDAFHMBMGC IPDFOMJPIKI, [CDAJDCGEMGI(null)] ODGLOMJMEFI KDJGFDIPOHI, [CDAJDCGEMGI(null)] JHHHHDEGGMN NFACINHMFIO, [CDAJDCGEMGI(null)] IIFLENBNAPC HOBLNDCKACC, [CDAJDCGEMGI(null)] JNPJMBDOPFL DNIHJGFCFCF, [CDAJDCGEMGI(null)] EBEKBJENPBA MAMECCODHBI, [CDAJDCGEMGI(null)] FAKBOJPCPEP GDIICIICHHB, [CDAJDCGEMGI(null)] HFLPBFAPMMK KJCOGKHMNKJ, [CDAJDCGEMGI(null)] IEIIFKOCFKM DDKJDHNNJGO, [CDAJDCGEMGI(null)] ALADEOKCIJK EMOEAFOOMOP, [CDAJDCGEMGI(null)] NEGPONDKAKL MNLFDJBKOKG, [CDAJDCGEMGI(null)] CHLBMEJKKDL KMAKBLPNIPH, [CDAJDCGEMGI(null)] ABIMLOAGMPC DPOGNJMOHKO, [CDAJDCGEMGI(null)] JENLDJDLCOI OAOBCJBEBBB, [CDAJDCGEMGI(null)] DLGIDCPMJNG NDJIPPPMIAN, [CDAJDCGEMGI(null)] AJGEIEHEPFM LEEAMMCBLCJ, [CDAJDCGEMGI(null)] KKAEGAFPCFN ABGMNIJICLJ, [CDAJDCGEMGI(null)] EEMNNFECFAA IFAJDGKBNMB, [CDAJDCGEMGI(null)] JBIKLGIDHCH ADAKCMAAAFM, [CDAJDCGEMGI(null)] CJMIEMCMKCI GAHBOLPANAG, [CDAJDCGEMGI(null)] APCGMHFIDII KJBGOEIMDGL, [CDAJDCGEMGI(null)] CIHDMMKNLFK PAOPFHIHHOM, [CDAJDCGEMGI(null)] NMKLOINCMMF NMMMEOINFMF, [CDAJDCGEMGI(null)] EEHJOGMMLGK DPBMCDHPFLN, [CDAJDCGEMGI(null)] ALAIHBFAIAD HHBPPIPMCAN, [CDAJDCGEMGI(null)] NEJIOMHPBHD HGGIJDKANHN, [CDAJDCGEMGI(null)] HOFBEIMOCLK LANHIIJBHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x246B710", Offset = "0x246A510", VA = "0x18246B710")]
	private void ILMEFAAGLOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x246B210", Offset = "0x246A010", VA = "0x18246B210", Slot = "51")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x246BBB0", Offset = "0x246A9B0", VA = "0x18246BBB0", Slot = "44")]
	private void MGALMJLEKMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x246B060", Offset = "0x2469E60", VA = "0x18246B060", Slot = "48")]
	private Task BBILBIDLMOK(string KCGMDGFIHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x246B470", Offset = "0x246A270", VA = "0x18246B470", Slot = "45")]
	private Task<NHOKIGNMHJB> GDABLKDAGBA(KEBPHEIFBOC LIBHHACLAEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x246B1A0", Offset = "0x2469FA0", VA = "0x18246B1A0", Slot = "46")]
	private Task<NHOKIGNMHJB> DAHILECENBH(NAJNLFAFJGC HANOLPJCOJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x246BA70", Offset = "0x246A870", VA = "0x18246BA70", Slot = "47")]
	private Task<NHOKIGNMHJB> LJLEGBPBHJB(int BGKPECJNKFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x246B870", Offset = "0x246A670", VA = "0x18246B870", Slot = "49")]
	[AsyncStateMachine(typeof(KGPNHAGGFHC))]
	private Task<NHOKIGNMHJB> JHPBBOFBLJF(JMDHMLDEGBF BACNBDCPFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x246B590", Offset = "0x246A390", VA = "0x18246B590", Slot = "50")]
	[AsyncStateMachine(typeof(PMGGIJFPHOO))]
	private Task GLIIIPCIPAL(CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x246B800", Offset = "0x246A600", VA = "0x18246B800")]
	[IteratorStateMachine(typeof(KJLCBGEDHIF))]
	private IEnumerable<PLGHNFIOALA> JGCPLAFDNNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x246BB50", Offset = "0x246A950", VA = "0x18246BB50")]
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
		[Cpp2IlInjected.Address(RVA = "0x33C82F0", Offset = "0x33C70F0", VA = "0x1833C82F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x33C8670", Offset = "0x33C7470", VA = "0x1833C8670", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x6576E0", Offset = "0x6564E0", VA = "0x1806576E0")]
	public JOEEFAKLMAB(BNMEKDBAOON GIGDLICKJEF, JHHHHDEGGMN NFACINHMFIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x248ACE0", Offset = "0x2489AE0", VA = "0x18248ACE0", Slot = "4")]
	[AsyncStateMachine(typeof(FANDNOEIJOD))]
	public Task<bool> BDJBIGDHFBE(CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x248AE00", Offset = "0x2489C00", VA = "0x18248AE00")]
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
		[Cpp2IlInjected.Address(RVA = "0x33C86C0", Offset = "0x33C74C0", VA = "0x1833C86C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x33C8CE0", Offset = "0x33C7AE0", VA = "0x1833C8CE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x24836E0", Offset = "0x24824E0", VA = "0x1824836E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6576E0", Offset = "0x6564E0", VA = "0x1806576E0")]
	public GNBLLLCJJEC(BNMEKDBAOON GIGDLICKJEF, JHHHHDEGGMN NFACINHMFIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x24835A0", Offset = "0x24823A0", VA = "0x1824835A0", Slot = "4")]
	[AsyncStateMachine(typeof(GAIDEPFDKKK))]
	public Task<bool> BDJBIGDHFBE(CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x2483730", Offset = "0x2482530", VA = "0x182483730")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public PPOPGHMPHKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3EF0B40", Offset = "0x3EEF940", VA = "0x183EF0B40")]
		internal object <RunFallback>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3EF0C90", Offset = "0x3EEFA90", VA = "0x183EF0C90")]
		internal object <RunFallback>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3EF0D00", Offset = "0x3EEFB00", VA = "0x183EF0D00")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EF01F0", Offset = "0x3EEEFF0", VA = "0x183EF01F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3EF0AB0", Offset = "0x3EEF8B0", VA = "0x183EF0AB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BED1D0", Offset = "0x2BEBFD0", VA = "0x182BED1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6576E0", Offset = "0x6564E0", VA = "0x1806576E0")]
	public PGKCCJNLCLD(BNMEKDBAOON GIGDLICKJEF, JHHHHDEGGMN NFACINHMFIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x2BED090", Offset = "0x2BEBE90", VA = "0x182BED090", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public PLONGDIHNGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3EF0B00", Offset = "0x3EEF900", VA = "0x183EF0B00")]
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
		[Cpp2IlInjected.Address(RVA = "0x33D2F00", Offset = "0x33D1D00", VA = "0x1833D2F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x33D3410", Offset = "0x33D2210", VA = "0x1833D3410", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x33CD270", Offset = "0x33CC070", VA = "0x1833CD270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BE00C0", Offset = "0x2BDEEC0", VA = "0x182BE00C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private JHHHHDEGGMN GNIOAJCHNPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0400", Offset = "0x2BDF200", VA = "0x182BE0400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	private HPNHGBDLHHJ JLLPNIPEBHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0040", Offset = "0x2BDEE40", VA = "0x182BE0040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	private IEIIFKOCFKM INJJKNCFFBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x2BE03B0", Offset = "0x2BDF1B0", VA = "0x182BE03B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x2BE06C0", Offset = "0x2BDF4C0", VA = "0x182BE06C0")]
	public KPFCBLHDFKP(CancellationToken GPNLCIOKAPO, BNMEKDBAOON AMENCMGDIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x2BDFF90", Offset = "0x2BDED90", VA = "0x182BDFF90")]
	public static KLBHKFANOAN APFFIENNDKD(BNMEKDBAOON AMENCMGDIEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x2BE0450", Offset = "0x2BDF250", VA = "0x182BE0450")]
	[AsyncStateMachine(typeof(NOBCOJGDAEF))]
	public Task<bool> LCBCKFDJBHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x2BE0110", Offset = "0x2BDEF10", VA = "0x182BE0110")]
	private bool HCJCNABIMKP(out JMDHMLDEGBF BACNBDCPFIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x2BE02B0", Offset = "0x2BDF0B0", VA = "0x182BE02B0")]
	[AsyncStateMachine(typeof(JINIDBFFOID))]
	private Task HKLKDAFFHFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x2BE0580", Offset = "0x2BDF380", VA = "0x182BE0580")]
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
		[Cpp2IlInjected.Address(RVA = "0x246EA20", Offset = "0x246D820", VA = "0x18246EA20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x1E76DC0", Offset = "0x1E75BC0", VA = "0x181E76DC0")]
	public APCLHDOHCEF(JENLDJDLCOI OAOBCJBEBBB, Guid HEHOBBBEICN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x246E9D0", Offset = "0x246D7D0", VA = "0x18246E9D0")]
	public TaskAwaiter<(NHOKIGNMHJB, Task)> JBNILEFEADI()
	{
		return default(TaskAwaiter<(NHOKIGNMHJB, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x246E900", Offset = "0x246D700", VA = "0x18246E900", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BE2900", Offset = "0x2BE1700", VA = "0x182BE2900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x2BE2940", Offset = "0x2BE1740", VA = "0x182BE2940")]
	public LPDBLCHBAPO(TimeSpan AHJIFDNMDHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x2BE26F0", Offset = "0x2BE14F0", VA = "0x182BE26F0")]
	public void CAOLCFGIFJD(Task POAGCHANBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x2BE2820", Offset = "0x2BE1620", VA = "0x182BE2820")]
	public void MPCDPKBNEOJ(NHOKIGNMHJB MGCHLOMHBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x2BE28B0", Offset = "0x2BE16B0", VA = "0x182BE28B0")]
	public void NBJDKPFPNPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x2BE2790", Offset = "0x2BE1590", VA = "0x182BE2790")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BE1DA0", Offset = "0x2BE0BA0", VA = "0x182BE1DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x246FEA0", Offset = "0x246ECA0", VA = "0x18246FEA0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Task PGODLLLKJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x246FE40", Offset = "0x246EC40", VA = "0x18246FE40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6991C0", Offset = "0x697FC0", VA = "0x1806991C0", Slot = "7")]
	public void ILMEFAAGLOH(BNMEKDBAOON GIGDLICKJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x246FED0", Offset = "0x246ECD0", VA = "0x18246FED0", Slot = "6")]
	public void JJCFDPCOIAB(Task JJCIEPGHDBG, string EFHGLHADIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x246FD10", Offset = "0x246EB10", VA = "0x18246FD10")]
	[AsyncStateMachine(typeof(LLKEKHBBNKO))]
	private Task ANEAHOJACHL(Task HFEGBDBKIHO, string EFHGLHADIHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x2470050", Offset = "0x246EE50", VA = "0x182470050")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BE1500", Offset = "0x2BE0300", VA = "0x182BE1500", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x2BE1570", Offset = "0x2BE0370", VA = "0x182BE1570", Slot = "7")]
	public void ILMEFAAGLOH(BNMEKDBAOON GIGDLICKJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x2BE1340", Offset = "0x2BE0140", VA = "0x182BE1340", Slot = "5")]
	public void FKBALBKJNJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x2BE1300", Offset = "0x2BE0100", VA = "0x182BE1300", Slot = "6")]
	public void IEEFJOLNNKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x2BE16F0", Offset = "0x2BE04F0", VA = "0x182BE16F0")]
	private Task PCOMHCEJGAE(COIBEMMGBIM KIHDPCDCOMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x2BE1300", Offset = "0x2BE0100", VA = "0x182BE1300", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x65B250", Offset = "0x65A050", VA = "0x18065B250")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x65B270", Offset = "0x65A070", VA = "0x18065B270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x316F1A0", Offset = "0x316DFA0", VA = "0x18316F1A0")]
		public PKGIIBBJDDF(FJOBGIACABI PBAEKLCBBGA, string CCJNKBLKLDJ, T OGCEKMMDJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x316EC90", Offset = "0x316DA90", VA = "0x18316EC90")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BECBD0", Offset = "0x2BEB9D0", VA = "0x182BECBD0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public TimeSpan HFEGADFACKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x2BECC90", Offset = "0x2BEBA90", VA = "0x182BECC90", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public TimeSpan GGMMLMKNGFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x2BECD10", Offset = "0x2BEBB10", VA = "0x182BECD10", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public TimeSpan ACIKOPGGJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x2BECD50", Offset = "0x2BEBB50", VA = "0x182BECD50", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool CNKMDGFJABO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x2BECC50", Offset = "0x2BEBA50", VA = "0x182BECC50", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool KIJEMKCDKHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x2BECC10", Offset = "0x2BEBA10", VA = "0x182BECC10", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool NHEJHEMHLOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x2BECCD0", Offset = "0x2BEBAD0", VA = "0x182BECCD0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x2BECD90", Offset = "0x2BEBB90", VA = "0x182BECD90")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public LENIONGFKAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0E20", Offset = "0x2BDFC20", VA = "0x182BE0E20")]
		internal object <Invoke>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action HFLDMAMBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x2475BA0", Offset = "0x24749A0", VA = "0x182475BA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x2475C40", Offset = "0x2474A40", VA = "0x182475C40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event AEHHHDFPHCF DOLMHGMLLDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x24757C0", Offset = "0x24745C0", VA = "0x1824757C0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x2475890", Offset = "0x2474690", VA = "0x182475890", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event AEHHHDFPHCF GFLIGGHHEAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x2475720", Offset = "0x2474520", VA = "0x182475720", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x24754E0", Offset = "0x24742E0", VA = "0x1824754E0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event AEHHHDFPHCF BAAJCPOBKCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x2475580", Offset = "0x2474380", VA = "0x182475580", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x2475620", Offset = "0x2474420", VA = "0x182475620", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "16")]
	public void ILMEFAAGLOH(BNMEKDBAOON GIGDLICKJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x2475930", Offset = "0x2474730", VA = "0x182475930", Slot = "12")]
	public void KGEHBIBLNMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x24756C0", Offset = "0x24744C0", VA = "0x1824756C0", Slot = "13")]
	public void CKFEAHNNLKD(KMCFCCDNIEO AEPPKPHGPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x24756F0", Offset = "0x24744F0", VA = "0x1824756F0", Slot = "14")]
	public void DCPMGJCHAMD(KMCFCCDNIEO AEPPKPHGPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x2475860", Offset = "0x2474660", VA = "0x182475860", Slot = "15")]
	public void HOHHFAEJMOI(KMCFCCDNIEO AEPPKPHGPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x2475CE0", Offset = "0x2474AE0", VA = "0x182475CE0")]
	private void PFJMFFOKNBK(AEHHHDFPHCF CCDFIIDBLNP, KMCFCCDNIEO AEPPKPHGPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EEF140", Offset = "0x3EEDF40", VA = "0x183EEF140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EEC460", Offset = "0x3EEB260", VA = "0x183EEC460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public OEMAPBGOALI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3EEF5B0", Offset = "0x3EEE3B0", VA = "0x183EEF5B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EEA630", Offset = "0x3EE9430", VA = "0x183EEA630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3EEABC0", Offset = "0x3EE99C0", VA = "0x183EEABC0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public DDPFJLEKHPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3EE6520", Offset = "0x3EE5320", VA = "0x183EE6520")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BE51D0", Offset = "0x2BE3FD0", VA = "0x182BE51D0", Slot = "7")]
	public void ILMEFAAGLOH(BNMEKDBAOON GIGDLICKJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x2BE4DE0", Offset = "0x2BE3BE0", VA = "0x182BE4DE0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x2BE5250", Offset = "0x2BE4050", VA = "0x182BE5250", Slot = "6")]
	public void JLLAJBPPFDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x2BE4F30", Offset = "0x2BE3D30", VA = "0x182BE4F30", Slot = "5")]
	public void FHCNBPLELNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x2BE53C0", Offset = "0x2BE41C0", VA = "0x182BE53C0", Slot = "4")]
	[AsyncStateMachine(typeof(OCBPGPKOHBE))]
	public Task JLLIENFLKLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x2BE46B0", Offset = "0x2BE34B0", VA = "0x182BE46B0")]
	private void AMBBHAAEJKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x2BE49F0", Offset = "0x2BE37F0", VA = "0x182BE49F0")]
	[AsyncStateMachine(typeof(LCLPDIFIFMD))]
	private Task AONMABEKOIL(CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x2BE5080", Offset = "0x2BE3E80", VA = "0x182BE5080")]
	[AsyncStateMachine(typeof(JCMHBGEJKLG))]
	private Task<bool> HFLEGFLPNDD(int AIPHGHFENPJ, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x2BE54D0", Offset = "0x2BE42D0", VA = "0x182BE54D0")]
	private void KEJMCBONGAF(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x2BE4DF0", Offset = "0x2BE3BF0", VA = "0x182BE4DF0")]
	private void FEKNOBJHEII(int AIPHGHFENPJ, bool OHMLJNNHABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x2BE4C30", Offset = "0x2BE3A30", VA = "0x182BE4C30")]
	private void DHELLLECEKO(int AIPHGHFENPJ, Exception KLJBPOILBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x2BE4B20", Offset = "0x2BE3920", VA = "0x182BE4B20")]
	private void CEBMNHHDPOB(CancellationToken GPNLCIOKAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EEE850", Offset = "0x3EED650", VA = "0x183EEE850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public DGEAKBPGKID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3EE6890", Offset = "0x3EE5690", VA = "0x183EE6890")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EEFA70", Offset = "0x3EEE870", VA = "0x183EEFA70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EE5DB0", Offset = "0x3EE4BB0", VA = "0x183EE5DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BE7FE0", Offset = "0x2BE6DE0", VA = "0x182BE7FE0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	internal Task HAENEKGNFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x2BE84C0", Offset = "0x2BE72C0", VA = "0x182BE84C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7FF0", Offset = "0x2BE6DF0", VA = "0x182BE7FF0", Slot = "6")]
	public void ILMEFAAGLOH(BNMEKDBAOON GIGDLICKJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7B10", Offset = "0x2BE6910", VA = "0x182BE7B10", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x2BE84D0", Offset = "0x2BE72D0", VA = "0x182BE84D0", Slot = "5")]
	public bool OLGFMMAIIGC(KLBHKFANOAN AFIMNNMNIEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7C90", Offset = "0x2BE6A90", VA = "0x182BE7C90")]
	private void HDAPCEFCOHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x2BE8A60", Offset = "0x2BE7860", VA = "0x182BE8A60")]
	private void PKNEBHPKGGE(HCAOAHLBICC GDMAJNKMCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7B70", Offset = "0x2BE6970", VA = "0x182BE7B70")]
	[AsyncStateMachine(typeof(NODOBDLJELB))]
	private Task EGKDAFHHAKP(HCAOAHLBICC GDMAJNKMCBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7A30", Offset = "0x2BE6830", VA = "0x182BE7A30")]
	private Func<CancellationToken, List<Task>> ADKPOGBMBBM(HCAOAHLBICC GDMAJNKMCBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2BE8530", Offset = "0x2BE7330", VA = "0x182BE8530")]
	private List<Task> PFFHAIDOOKD(HCAOAHLBICC GDMAJNKMCBP, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7EB0", Offset = "0x2BE6CB0", VA = "0x182BE7EB0")]
	[AsyncStateMachine(typeof(OLBIKPCHMGA))]
	private Task HKCFJDGDJFO(KLBHKFANOAN CMFIFPKIEBE, HCAOAHLBICC JANIFNADDOP, CancellationToken MKDOEIGPNGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x2BE83C0", Offset = "0x2BE71C0", VA = "0x182BE83C0")]
	[AsyncStateMachine(typeof(CNJBDHINDAA))]
	private Task KJBJFGOKAIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x2BE82C0", Offset = "0x2BE70C0", VA = "0x182BE82C0")]
	private void JLLAJBPPFDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x2BE8CE0", Offset = "0x2BE7AE0", VA = "0x182BE8CE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x33D6590", Offset = "0x33D5390", VA = "0x1833D6590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x33C6F20", Offset = "0x33C5D20", VA = "0x1833C6F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public BKFBNBEMKMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x6578C0", VA = "0x180658AC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x33D3460", Offset = "0x33D2260", VA = "0x1833D3460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BD83A0", Offset = "0x2BD71A0", VA = "0x182BD83A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x33C78A0", Offset = "0x33C66A0", VA = "0x1833C78A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x33CCC20", Offset = "0x33CBA20", VA = "0x1833CCC20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public HCPICIFNKKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x33CB520", Offset = "0x33CA320", VA = "0x1833CB520")]
		internal object <JoinRoomLoadWithPhoton>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x33CB420", Offset = "0x33CA220", VA = "0x1833CB420")]
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
		[Cpp2IlInjected.Address(RVA = "0x33D4AD0", Offset = "0x33D38D0", VA = "0x1833D4AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BD6740", Offset = "0x2BD5540", VA = "0x182BD6740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BD6310", Offset = "0x2BD5110", VA = "0x182BD6310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x33CBBB0", Offset = "0x33CA9B0", VA = "0x1833CBBB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x33D57A0", Offset = "0x33D45A0", VA = "0x1833D57A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x33D2300", Offset = "0x33D1100", VA = "0x1833D2300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x33D0820", Offset = "0x33CF620", VA = "0x1833D0820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public BNAOMLDKNPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7830", Offset = "0x2BD6630", VA = "0x182BD7830")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public AFDKFCBJNOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5C30", Offset = "0x2BD4A30", VA = "0x182BD5C30")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public NFGHLBIDFKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x33D1F20", Offset = "0x33D0D20", VA = "0x1833D1F20")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public ENJMIMADNPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x33C8050", Offset = "0x33C6E50", VA = "0x1833C8050")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B5E90", Offset = "0x9B4C90", VA = "0x1809B5E90", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x9B5EA0", Offset = "0x9B4CA0", VA = "0x1809B5EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private HPNHGBDLHHJ JLLPNIPEBHB
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x24809B0", Offset = "0x247F7B0", VA = "0x1824809B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x2481250", Offset = "0x2480050", VA = "0x182481250", Slot = "6")]
	public void ILMEFAAGLOH(BNMEKDBAOON GIGDLICKJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x247FF90", Offset = "0x247ED90", VA = "0x18247FF90", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x24817A0", Offset = "0x24805A0", VA = "0x1824817A0", Slot = "5")]
	[AsyncStateMachine(typeof(PABCBDLNKKM))]
	public Task JHNNOILKFHO(APEIEEGPGIG JJEJBFBOJLC, CancellationToken OAFNKBHDHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x2481D00", Offset = "0x2480B00", VA = "0x182481D00")]
	[AsyncStateMachine(typeof(EBMJGDJJMJH))]
	private Task LBFFBGIFHHE(APEIEEGPGIG JJEJBFBOJLC, CancellationToken OAFNKBHDHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x2480A00", Offset = "0x247F800", VA = "0x182480A00")]
	private static void GOCANIHBNAN(APEIEEGPGIG JJEJBFBOJLC, Exception KLJBPOILBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x24828B0", Offset = "0x24816B0", VA = "0x1824828B0")]
	private static void PKDIOHKKCKP(IGBEHNFHHGH JDHMHLBMOOE, Exception KLJBPOILBNM, [Optional] List<int> MNGMOBJPHHK, int HALBIMNLAIB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x2481A20", Offset = "0x2480820", VA = "0x182481A20")]
	[AsyncStateMachine(typeof(NPBFEBIDEFM))]
	private Task KJNAOAJIICI(GEKJCIHAMFL APDIGEDLLAL, APEIEEGPGIG JJEJBFBOJLC, KFENGNLKFLE MHGPPPJICLB, CancellationToken OAFNKBHDHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x24818D0", Offset = "0x24806D0", VA = "0x1824818D0")]
	private void KBDOJDEMKNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x247F980", Offset = "0x247E780", VA = "0x18247F980")]
	[AsyncStateMachine(typeof(CBLMLHCFJIH))]
	private Task COOPJMDOFNH(GEKJCIHAMFL APDIGEDLLAL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x247FAC0", Offset = "0x247E8C0", VA = "0x18247FAC0")]
	private void DJCNEEHMGHJ(APEIEEGPGIG JJEJBFBOJLC, CancellationToken OAFNKBHDHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2480FA0", Offset = "0x247FDA0", VA = "0x182480FA0")]
	private void HHHJCABILOC(APEIEEGPGIG JJEJBFBOJLC, KFENGNLKFLE MHGPPPJICLB, OperationCanceledException NMPECJNCAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x2482360", Offset = "0x2481160", VA = "0x182482360")]
	private void OPBLIELPCDI(APEIEEGPGIG JJEJBFBOJLC, KFENGNLKFLE MHGPPPJICLB, Exception KLJBPOILBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x2480BC0", Offset = "0x247F9C0", VA = "0x182480BC0")]
	private void GPLBEHEPJEK(APEIEEGPGIG JJEJBFBOJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x247F940", Offset = "0x247E740", VA = "0x18247F940")]
	private static KMCFCCDNIEO CBKPFBEDCLD(APEIEEGPGIG JJEJBFBOJLC)
	{
		return default(KMCFCCDNIEO);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x24831D0", Offset = "0x2481FD0", VA = "0x1824831D0")]
	[AsyncStateMachine(typeof(EMDNCCEFNLA))]
	private Task POFPPOOOHNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x2481E40", Offset = "0x2480C40", VA = "0x182481E40")]
	private static IKOPDIJPAKH MIMGKEIOGOP(APEIEEGPGIG JJEJBFBOJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x2481B90", Offset = "0x2480990", VA = "0x182481B90")]
	[AsyncStateMachine(typeof(JHPICHDJILK))]
	private Task KLNKKAJFDMK(APEIEEGPGIG JJEJBFBOJLC, KFENGNLKFLE MHGPPPJICLB, GEKJCIHAMFL APDIGEDLLAL, CancellationToken IJAKIFIPFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x247FFE0", Offset = "0x247EDE0", VA = "0x18247FFE0")]
	[AsyncStateMachine(typeof(NPKKBLKMAIM))]
	private Task EJBCCMGMGMA(APEIEEGPGIG JJEJBFBOJLC, CancellationTokenSource EKAAJIDDNML, Task EDPGBENBLPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x2480820", Offset = "0x247F620", VA = "0x182480820")]
	[AsyncStateMachine(typeof(BAEMEKEONGA))]
	private Task FJLPOJNCFLF(BKDHKLDKOEI NFIKFCMLCIF, CJPAOFNIIFD KMIGMOKPKMP, APEIEEGPGIG NLNOBPPJHDN, KFENGNLKFLE JCOBIBENFPG, GEKJCIHAMFL APDIGEDLLAL, CancellationToken BBAAJAJIJEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x24804A0", Offset = "0x247F2A0", VA = "0x1824804A0")]
	private KFENGNLKFLE FHEAJBNBJGH(KFENGNLKFLE JCOBIBENFPG, ref CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x24806E0", Offset = "0x247F4E0", VA = "0x1824806E0")]
	[AsyncStateMachine(typeof(AMGECEAEHPH))]
	private Task FHGIFKLDAFO(GEKJCIHAMFL APDIGEDLLAL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x2482230", Offset = "0x2481030", VA = "0x182482230")]
	[AsyncStateMachine(typeof(IGPHECOABMP))]
	private Task OEBJNNDKKKN(GEKJCIHAMFL APDIGEDLLAL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x2480140", Offset = "0x247EF40", VA = "0x182480140")]
	[AsyncStateMachine(typeof(OIPEDFPLDOP))]
	private Task ELCHPJJKHHI(GEKJCIHAMFL APDIGEDLLAL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x24815D0", Offset = "0x24803D0", VA = "0x1824815D0")]
	[AsyncStateMachine(typeof(NJFOABIHENH))]
	private Task JCPFOBIILFE(HCAOAHLBICC JANIFNADDOP, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x24820F0", Offset = "0x2480EF0", VA = "0x1824820F0")]
	[AsyncStateMachine(typeof(LOJEAJJNCMP))]
	private Task OBAKGKHKMIA(GEKJCIHAMFL DIOPAPPIBBL, CancellationToken IJAKIFIPFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x2481460", Offset = "0x2480260", VA = "0x182481460")]
	private static void JCEPFPNOJOM(APEIEEGPGIG JJEJBFBOJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x2480280", Offset = "0x247F080", VA = "0x182480280")]
	private void ENBNDLLOBKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x2482060", Offset = "0x2480E60", VA = "0x182482060")]
	private void NGHJLMPHFHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x2480F10", Offset = "0x247FD10", VA = "0x182480F10")]
	private void HHCLKIFFLMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x2481710", Offset = "0x2480510", VA = "0x182481710")]
	private void JFHIJNJHPPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x2481EF0", Offset = "0x2480CF0", VA = "0x182481EF0")]
	private static void MLGJBKOKNIB(APEIEEGPGIG JJEJBFBOJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x2480E50", Offset = "0x247FC50", VA = "0x182480E50")]
	private static void HCHNPGMLMEL(APEIEEGPGIG JJEJBFBOJLC, CancellationToken IJAKIFIPFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x247FE10", Offset = "0x247EC10", VA = "0x18247FE10")]
	private static void DKJFCPENAPC(APEIEEGPGIG JJEJBFBOJLC, Exception KLJBPOILBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x2482610", Offset = "0x2481410", VA = "0x182482610")]
	private void PDBIHFGLMDE(APEIEEGPGIG JJEJBFBOJLC, Task EDPGBENBLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x24830F0", Offset = "0x2481EF0", VA = "0x1824830F0")]
	private static void PNAJNCEFIKC(Func<string> IALJJELLBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x24833C0", Offset = "0x24821C0", VA = "0x1824833C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public APOGDAEIPPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x2BD66E0", Offset = "0x2BD54E0", VA = "0x182BD66E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public NILNHOMNMAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x2BE62E0", Offset = "0x2BE50E0", VA = "0x182BE62E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public MIAOOANPEFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x2BE3700", Offset = "0x2BE2500", VA = "0x182BE3700")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public CAMDGLMCIDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7DB0", Offset = "0x2BD6BB0", VA = "0x182BD7DB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public DOBNLDPMACD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA070", Offset = "0x2BD8E70", VA = "0x182BDA070")]
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
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "10")]
	public void ILMEFAAGLOH(BNMEKDBAOON GIGDLICKJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x2470350", Offset = "0x246F150", VA = "0x182470350", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x24708B0", Offset = "0x246F6B0", VA = "0x1824708B0", Slot = "4")]
	public APCLHDOHCEF HEFJCCLOLGO(Guid HEHOBBBEICN)
	{
		return default(APCLHDOHCEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x24700D0", Offset = "0x246EED0", VA = "0x1824700D0", Slot = "5")]
	public bool AKJLIPOIGHF(Guid HEHOBBBEICN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x2470B30", Offset = "0x246F930", VA = "0x182470B30", Slot = "8")]
	public bool JLLAJBPPFDK(Guid HEHOBBBEICN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x2470D80", Offset = "0x246FB80", VA = "0x182470D80", Slot = "6")]
	public bool KNFHBJLLNPP(Guid HEHOBBBEICN, Task POAGCHANBPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x2470360", Offset = "0x246F160", VA = "0x182470360", Slot = "7")]
	public bool EKLMIPLHBIL(Guid HEHOBBBEICN, NHOKIGNMHJB MGCHLOMHBGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x24705B0", Offset = "0x246F3B0", VA = "0x1824705B0", Slot = "9")]
	public Task<(NHOKIGNMHJB, Task)> ENHLOOPMFCF(Guid HEHOBBBEICN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x2470620", Offset = "0x246F420", VA = "0x182470620")]
	private void FMEEFECKFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x2471140", Offset = "0x246FF40", VA = "0x182471140")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BDA250", Offset = "0x2BD9050", VA = "0x182BDA250")]
		public DOMOBBIPIJA(APEIEEGPGIG IMNFJKOLNMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA100", Offset = "0x2BD8F00", VA = "0x182BDA100")]
		public void JLLAJBPPFDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA0D0", Offset = "0x2BD8ED0", VA = "0x182BDA0D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public CNDNBJCJCIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x2BD94E0", Offset = "0x2BD82E0", VA = "0x182BD94E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BE4320", Offset = "0x2BE3120", VA = "0x182BE4320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public MMJIPGJGLIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x2BE3760", Offset = "0x2BE2560", VA = "0x182BE3760")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BD95C0", Offset = "0x2BD83C0", VA = "0x182BD95C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x660AD0", Offset = "0x65F8D0", VA = "0x180660AD0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public LKCFMJIKMKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x2BE1770", Offset = "0x2BE0570", VA = "0x182BE1770")]
		internal object <TryJoinRoomInstance>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x2BE1810", Offset = "0x2BE0610", VA = "0x182BE1810")]
		internal object <TryJoinRoomInstance>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x2BE1850", Offset = "0x2BE0650", VA = "0x182BE1850")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public OGLOKPIIELK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x2BE92C0", Offset = "0x2BE80C0", VA = "0x182BE92C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BDC080", Offset = "0x2BDAE80", VA = "0x182BDC080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x246D350", Offset = "0x246C150", VA = "0x18246D350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public bool DGHGIEJOIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x95ACF0", Offset = "0x959AF0", VA = "0x18095ACF0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x246CFD0", Offset = "0x246BDD0", VA = "0x18246CFD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x246D3A0", Offset = "0x246C1A0", VA = "0x18246D3A0", Slot = "4")]
	public void ILMEFAAGLOH(BNMEKDBAOON GIGDLICKJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x246D0B0", Offset = "0x246BEB0", VA = "0x18246D0B0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x246D230", Offset = "0x246C030", VA = "0x18246D230")]
	[AsyncStateMachine(typeof(NCINECKCMGO))]
	private Task EDNCFPMIFOE(COIBEMMGBIM ECJCCGHNOAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x246CDC0", Offset = "0x246BBC0", VA = "0x18246CDC0")]
	private void DFAPHOBOAJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x246DB70", Offset = "0x246C970", VA = "0x18246DB70")]
	private void MFNDHCJAKBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x246CBC0", Offset = "0x246B9C0", VA = "0x18246CBC0")]
	private void CAEEJNHPNOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x246DD80", Offset = "0x246CB80", VA = "0x18246DD80")]
	private bool MHIEIMDOJCJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x246DE00", Offset = "0x246CC00", VA = "0x18246DE00")]
	[AsyncStateMachine(typeof(DDPFBDEBKFD))]
	private void MNMKBFGACKO(int BCGICHENIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x246D700", Offset = "0x246C500", VA = "0x18246D700")]
	private void KGNIEGGGCAO(out IDisposable POILNJLKNJK, out IDisposable MMIKKBIONIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x246CA40", Offset = "0x246B840", VA = "0x18246CA40")]
	private bool BLPGPNFDAED(APEIEEGPGIG IMNFJKOLNMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x246D650", Offset = "0x246C450", VA = "0x18246D650")]
	private void JCLMDLHAHGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x246DA40", Offset = "0x246C840", VA = "0x18246DA40")]
	[AsyncStateMachine(typeof(FGGHLHNOBDM))]
	private Task LBFFBGIFHHE(APEIEEGPGIG IMNFJKOLNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x246DEF0", Offset = "0x246CCF0", VA = "0x18246DEF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BDF350", Offset = "0x2BDE150", VA = "0x182BDF350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF5A0", Offset = "0x2BDE3A0", VA = "0x182BDF5A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public BJNNKMKPJEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x2BD77D0", Offset = "0x2BD65D0", VA = "0x182BD77D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public FGKOGJNHPAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x2BDCDC0", Offset = "0x2BDBBC0", VA = "0x182BDCDC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public EMCDOKJODMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB690", Offset = "0x2BDA490", VA = "0x182BDB690")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BD5CD0", Offset = "0x2BD4AD0", VA = "0x182BD5CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public NEAECFFEKPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x2BE5630", Offset = "0x2BE4430", VA = "0x182BE5630")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BE9490", Offset = "0x2BE8290", VA = "0x182BE9490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BDE3B0", Offset = "0x2BDD1B0", VA = "0x182BDE3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE800", Offset = "0x2BDD600", VA = "0x182BDE800", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public ENKKKCMMCHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x2BDBC40", Offset = "0x2BDAA40", VA = "0x182BDBC40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BDD640", Offset = "0x2BDC440", VA = "0x182BDD640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public PMHFCKMKBJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x2BEDC00", Offset = "0x2BECA00", VA = "0x182BEDC00")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public CADFPINFIGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7D50", Offset = "0x2BD6B50", VA = "0x182BD7D50")]
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
	[Cpp2IlInjected.Address(RVA = "0x2479070", Offset = "0x2477E70", VA = "0x182479070", Slot = "7")]
	public void ILMEFAAGLOH(BNMEKDBAOON GIGDLICKJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x2478B30", Offset = "0x2477930", VA = "0x182478B30", Slot = "6")]
	[AsyncStateMachine(typeof(KFCOCKKCPAB))]
	public Task<EHJEKJMFKEA> EHJLCHFKKFM(CancellationToken MCEAMJINAKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x24798E0", Offset = "0x24786E0", VA = "0x1824798E0", Slot = "4")]
	public void NKJDICFIBGK(EBIJFBKIDNI GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x2478730", Offset = "0x2477530", VA = "0x182478730", Slot = "5")]
	public void AAOABFKBHAO(EBIJFBKIDNI AMJPDMBJMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x24793C0", Offset = "0x24781C0", VA = "0x1824793C0")]
	[AsyncStateMachine(typeof(ALNABHHEICG))]
	private Task MCHFLPKKIDH(EBIJFBKIDNI NMKJPBEONAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x2478EF0", Offset = "0x2477CF0", VA = "0x182478EF0")]
	[AsyncStateMachine(typeof(OMLGHPKHMBD))]
	private Task EPHJGDFCNJM(EBIJFBKIDNI IKCNEHGPIOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x2479150", Offset = "0x2477F50", VA = "0x182479150")]
	[AsyncStateMachine(typeof(JCHAHIIOEDA))]
	private Task<IJNLEAKKLBL> JJOBODDHNHI(EBIJFBKIDNI NMKJPBEONAN, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x24792A0", Offset = "0x24780A0", VA = "0x1824792A0")]
	private KFENGNLKFLE MCDECNDFDEJ(EBIJFBKIDNI CHNJKNKLHMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x2479D10", Offset = "0x2478B10", VA = "0x182479D10")]
	[AsyncStateMachine(typeof(IJGPKFFFNDM))]
	private Task ONLAJBHLNFK(IJNLEAKKLBL OOLGEBPABAO, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x2478C70", Offset = "0x2477A70", VA = "0x182478C70")]
	private IJNLEAKKLBL EIILDCKLNHK(EBIJFBKIDNI NMKJPBEONAN, KFENGNLKFLE CNIOIHPDDOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x1F2E180", Offset = "0x1F2CF80", VA = "0x181F2E180")]
	private T PIKGHDFEAKK<T>(T IGJPNMBCJPK) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x24794F0", Offset = "0x24782F0", VA = "0x1824794F0")]
	private IJNLEAKKLBL NJEKLCOHOND(EBIJFBKIDNI NMKJPBEONAN, KFENGNLKFLE CNIOIHPDDOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public EKKGKAHACFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x2479020", Offset = "0x2477E20", VA = "0x182479020")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public DKMIDDPAGJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA000", Offset = "0x2BD8E00", VA = "0x182BDA000")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public JKJLINKPPBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x2BDEB00", Offset = "0x2BDD900", VA = "0x182BDEB00")]
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
	[Cpp2IlInjected.Address(RVA = "0x247EE80", Offset = "0x247DC80", VA = "0x18247EE80", Slot = "6")]
	public void ILMEFAAGLOH(BNMEKDBAOON GIGDLICKJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x247E490", Offset = "0x247D290", VA = "0x18247E490", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x247D6C0", Offset = "0x247C4C0", VA = "0x18247D6C0", Slot = "4")]
	public APCLHDOHCEF DDOPFOCLBFF(JPBBJDIHKKD NMKJPBEONAN)
	{
		return default(APCLHDOHCEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x247F2F0", Offset = "0x247E0F0", VA = "0x18247F2F0", Slot = "5")]
	public void KJFJIOKOPKH(Guid HEHOBBBEICN, Task POAGCHANBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x247F570", Offset = "0x247E370", VA = "0x18247F570")]
	private void MINBPELOMLI(byte IFOEKECCJIL, int DNKHIDJJODP, object HGENDMPDIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x247E530", Offset = "0x247D330", VA = "0x18247E530")]
	private void HLFJNOCNPCL(CNBCGACFMCE MMEEGBIBNIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x247DF10", Offset = "0x247CD10", VA = "0x18247DF10")]
	private void DMKIBNDLMMJ(CNBCGACFMCE MMEEGBIBNIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x247DC60", Offset = "0x247CA60", VA = "0x18247DC60")]
	private void DGEGANFDBBK(CNBCGACFMCE MMEEGBIBNIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x247E1F0", Offset = "0x247CFF0", VA = "0x18247E1F0")]
	private NHOKIGNMHJB DOEMBCLPCBL(EBIJFBKIDNI CHNJKNKLHMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x247EC30", Offset = "0x247DA30", VA = "0x18247EC30")]
	private void HMGMHLNNIGB(EBIJFBKIDNI IKCNEHGPIOF, NHOKIGNMHJB MGCHLOMHBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x247F640", Offset = "0x247E440", VA = "0x18247F640")]
	private bool OEMOLBAOKLJ(EBIJFBKIDNI IKCNEHGPIOF, NHOKIGNMHJB MGCHLOMHBGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x247D3F0", Offset = "0x247C1F0", VA = "0x18247D3F0")]
	private bool DDOPFOCLBFF(EBIJFBKIDNI JAMFBFHGPMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x247EFF0", Offset = "0x247DDF0", VA = "0x18247EFF0")]
	private bool KAMEJDLGKEJ(byte IFOEKECCJIL, ExitGames.Client.Photon.Hashtable MMEEGBIBNIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public ANKGFMDGEGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x33C2BF0", Offset = "0x33C19F0", VA = "0x1833C2BF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x33CDB20", Offset = "0x33CC920", VA = "0x1833CDB20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x33CE0B0", Offset = "0x33CCEB0", VA = "0x1833CE0B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public AFMKBDKFPKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x33C2410", Offset = "0x33C1210", VA = "0x1833C2410")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public PJEHNDFKDAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x33D70D0", Offset = "0x33D5ED0", VA = "0x1833D70D0")]
		internal object <RequestOperationInternal>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x33D7140", Offset = "0x33D5F40", VA = "0x1833D7140")]
		internal object <RequestOperationInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x33D71B0", Offset = "0x33D5FB0", VA = "0x1833D71B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x33C2480", Offset = "0x33C1280", VA = "0x1833C2480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x33C2BA0", Offset = "0x33C19A0", VA = "0x1833C2BA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public PFKOHAKOJJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x33D7060", Offset = "0x33D5E60", VA = "0x1833D7060")]
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
	[Cpp2IlInjected.Address(RVA = "0x24881C0", Offset = "0x2486FC0", VA = "0x1824881C0", Slot = "5")]
	public void ILMEFAAGLOH(BNMEKDBAOON GIGDLICKJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x2488520", Offset = "0x2487320", VA = "0x182488520", Slot = "4")]
	[AsyncStateMachine(typeof(KFJHDFNJLII))]
	public Task<NHOKIGNMHJB> PAHCHCNKEGI(NAJNLFAFJGC NIKGDEJFIJN, EHJEKJMFKEA HMMAHJCPLAP, [CanBeNull] KEBPHEIFBOC LIBHHACLAEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x24882C0", Offset = "0x24870C0", VA = "0x1824882C0")]
	private bool LAIFFMNPNIL(EHJEKJMFKEA HMMAHJCPLAP, out NHOKIGNMHJB BBLJKOEKFJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x2487B90", Offset = "0x2486990", VA = "0x182487B90")]
	[AsyncStateMachine(typeof(AGLOBNCMNMM))]
	private Task<NHOKIGNMHJB> ABLNKNCJLIG(NAJNLFAFJGC NIKGDEJFIJN, EHJEKJMFKEA HMMAHJCPLAP, [CanBeNull] KEBPHEIFBOC LIBHHACLAEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x2487D00", Offset = "0x2486B00", VA = "0x182487D00")]
	internal JPBBJDIHKKD GCEIJAHGMNP(NAJNLFAFJGC NIKGDEJFIJN, EHJEKJMFKEA HMMAHJCPLAP, [CanBeNull] KEBPHEIFBOC LIBHHACLAEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x33D0B10", Offset = "0x33CF910", VA = "0x1833D0B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x33D0CF0", Offset = "0x33CFAF0", VA = "0x1833D0CF0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public IENBFCJMBOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x33CBB00", Offset = "0x33CA900", VA = "0x1833CBB00")]
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
		[Cpp2IlInjected.Address(RVA = "0x33D5A60", Offset = "0x33D4860", VA = "0x1833D5A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x33D5E20", Offset = "0x33D4C20", VA = "0x1833D5E20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public NCDICMLFAMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0xEF1F20", Offset = "0xEF0D20", VA = "0x180EF1F20")]
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
		[Cpp2IlInjected.Address(RVA = "0x248A190", Offset = "0x2488F90", VA = "0x18248A190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x248A530", Offset = "0x2489330", VA = "0x18248A530", Slot = "8")]
	public void ILMEFAAGLOH(BNMEKDBAOON GIGDLICKJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x248A5C0", Offset = "0x24893C0", VA = "0x18248A5C0", Slot = "4")]
	[AsyncStateMachine(typeof(MBBFFIBPFFN))]
	public Task<BKDHKLDKOEI> JBGENADMHID(GEKJCIHAMFL DIOPAPPIBBL, APEIEEGPGIG JJEJBFBOJLC, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x248A3B0", Offset = "0x24891B0", VA = "0x18248A3B0")]
	[AsyncStateMachine(typeof(OJJLIAGKDAK))]
	public Task<KEBPHEIFBOC> IEJOBEMFNIE(APEIEEGPGIG JJEJBFBOJLC, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x2489D30", Offset = "0x2488B30", VA = "0x182489D30", Slot = "5")]
	public BKDHKLDKOEI DPPNPEOMPNM(APEIEEGPGIG JJEJBFBOJLC, KEBPHEIFBOC DPHNMJDPHKB, long DFGMBHPPELL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x248A080", Offset = "0x2488E80", VA = "0x18248A080", Slot = "6")]
	public BKDHKLDKOEI FMCNACCGHLA(APEIEEGPGIG JJEJBFBOJLC, ALDCBDNNGDB OBHFKPPDEKH, long DFGMBHPPELL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x248A740", Offset = "0x2489540", VA = "0x18248A740", Slot = "7")]
	public BKDHKLDKOEI JGHHBMAPFIG(long PHDHDONKJIJ, long DFGMBHPPELL, string HCJPHBNCMNO, string LPNGHDMHFPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x248A1E0", Offset = "0x2488FE0", VA = "0x18248A1E0")]
	private static BKDHKLDKOEI GIIOHPPIFAI(long PHDHDONKJIJ, long DFGMBHPPELL, JPCHJAOPHGN PMDPJJKFBMI, string HCJPHBNCMNO, JPCHJAOPHGN GDMAJNKMCBP, string LPNGHDMHFPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x248A840", Offset = "0x2489640", VA = "0x18248A840")]
	private (JPCHJAOPHGN, string, JPCHJAOPHGN) JGINJHLFHJM(APEIEEGPGIG JJEJBFBOJLC, KEBPHEIFBOC DPHNMJDPHKB, long DFGMBHPPELL)
	{
		return default((JPCHJAOPHGN, string, JPCHJAOPHGN));
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public FOEBPNGDNMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x3EE8910", Offset = "0x3EE7710", VA = "0x183EE8910")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EEEC90", Offset = "0x3EEDA90", VA = "0x183EEEC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x3EEF0F0", Offset = "0x3EEDEF0", VA = "0x183EEF0F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EE6BC0", Offset = "0x3EE59C0", VA = "0x183EE6BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x3EE7190", Offset = "0x3EE5F90", VA = "0x183EE7190", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public NMILFEBBMCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x3EEE7F0", Offset = "0x3EED5F0", VA = "0x183EEE7F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EEAE40", Offset = "0x3EE9C40", VA = "0x183EEAE40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x3EEB8E0", Offset = "0x3EEA6E0", VA = "0x183EEB8E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BE5960", Offset = "0x2BE4760", VA = "0x182BE5960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x2BE5B70", Offset = "0x2BE4970", VA = "0x182BE5B70", Slot = "8")]
	public void ILMEFAAGLOH(BNMEKDBAOON GIGDLICKJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x2BE56A0", Offset = "0x2BE44A0", VA = "0x182BE56A0", Slot = "4")]
	[AsyncStateMachine(typeof(NPAOPMLCMBE))]
	public Task<EBIJFBKIDNI> GFGPONIFKGM(EBIJFBKIDNI NMKJPBEONAN, KFENGNLKFLE CNIOIHPDDOC, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x2BE5A10", Offset = "0x2BE4810", VA = "0x182BE5A10", Slot = "5")]
	[AsyncStateMachine(typeof(EDIEAPECGIG))]
	public Task<EBIJFBKIDNI> IFJDKJGHCJL(CancellationToken GPNLCIOKAPO, KFENGNLKFLE CNIOIHPDDOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x2BE5C00", Offset = "0x2BE4A00", VA = "0x182BE5C00", Slot = "6")]
	public OPMGMKLBION KEOJCOJLNKO(IJNLEAKKLBL NEBBKBEMJIK, GEKJCIHAMFL DIOPAPPIBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x2BE6010", Offset = "0x2BE4E10", VA = "0x182BE6010", Slot = "7")]
	public OPMGMKLBION ONMIGIKACPH(IJNLEAKKLBL NEBBKBEMJIK, GEKJCIHAMFL DIOPAPPIBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x2BE5E90", Offset = "0x2BE4C90", VA = "0x182BE5E90")]
	[AsyncStateMachine(typeof(KGCOCBMDCEH))]
	private Task<EBIJFBKIDNI> NJHOBMHLJBL(EBIJFBKIDNI NMKJPBEONAN, KFENGNLKFLE CNIOIHPDDOC, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x2BE5690", Offset = "0x2BE4490", VA = "0x182BE5690")]
	private static byte[] CMPMCFMOJKJ(EBIJFBKIDNI GOJKMEMCPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x2BE5810", Offset = "0x2BE4610", VA = "0x182BE5810")]
	private static string HCKHALNJDFH(byte[] FMLMKJHIHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x248C1B0", Offset = "0x248AFB0", VA = "0x18248C1B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private static NHOKIGNMHJB HILMDCPEEFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x246E8A0", Offset = "0x246D6A0", VA = "0x18246E8A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x248C200", Offset = "0x248B000", VA = "0x18248C200", Slot = "7")]
	public void ILMEFAAGLOH(BNMEKDBAOON GIGDLICKJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x248BDA0", Offset = "0x248ABA0", VA = "0x18248BDA0", Slot = "4")]
	public NHOKIGNMHJB EGMCPLOPAOP(NAJNLFAFJGC BNIKFHMNHAE, EHJEKJMFKEA HOLLDENJHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x248BF30", Offset = "0x248AD30", VA = "0x18248BF30", Slot = "5")]
	public NHOKIGNMHJB ELCHDBNNHEK(NAJNLFAFJGC CBOLEAMMNCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x248C360", Offset = "0x248B160", VA = "0x18248C360", Slot = "6")]
	public NHOKIGNMHJB JGHFIJNBFBI(NAJNLFAFJGC CBOLEAMMNCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x246E630", Offset = "0x246D430", VA = "0x18246E630")]
	private static NHOKIGNMHJB FHAIGMPLCLF(EIIFCLNONEI HDEEEPPJEGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public KIMCBLILIAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public class JDAJHKOPKAE : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x2487590", Offset = "0x2486390", VA = "0x182487590")]
	public JDAJHKOPKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x1C87770", Offset = "0x1C86570", VA = "0x181C87770")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BE37D0", Offset = "0x2BE25D0", VA = "0x182BE37D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x2BE3DA0", Offset = "0x2BE2BA0", VA = "0x182BE3DA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BE2AB0", Offset = "0x2BE18B0", VA = "0x182BE2AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BDB6F0", Offset = "0x2BDA4F0", VA = "0x182BDB6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BD6F00", Offset = "0x2BD5D00", VA = "0x182BD6F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BDCF10", Offset = "0x2BDBD10", VA = "0x182BDCF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BDDFC0", Offset = "0x2BDCDC0", VA = "0x182BDDFC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2477EE0", Offset = "0x2476CE0", VA = "0x182477EE0", Slot = "6")]
	public void ILMEFAAGLOH(BNMEKDBAOON GIGDLICKJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0xFB9C20", Offset = "0xFB8A20", VA = "0x180FB9C20", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x2478580", Offset = "0x2477380", VA = "0x182478580", Slot = "4")]
	[AsyncStateMachine(typeof(MPOAEKIBEDK))]
	public Task<NHOKIGNMHJB> ODKHPLKJOBN(JMDHMLDEGBF BACNBDCPFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x2478460", Offset = "0x2477260", VA = "0x182478460", Slot = "5")]
	[AsyncStateMachine(typeof(MELPMBFPNEG))]
	public Task NEAPAAFHMEF([Optional] CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0xFB9C20", Offset = "0xFB8A20", VA = "0x180FB9C20")]
	public void GHCBMBPAACE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x24780A0", Offset = "0x2476EA0", VA = "0x1824780A0")]
	private HHKEAKPEFHI LPIFKDPKIKL(JMDHMLDEGBF BACNBDCPFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x24777C0", Offset = "0x24765C0", VA = "0x1824777C0")]
	[AsyncStateMachine(typeof(EMPPJNODGLF))]
	private Task CJNBDAOPKKO(HCAOAHLBICC KIHDPCDCOMG, CancellationToken OAFNKBHDHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x2477A20", Offset = "0x2476820", VA = "0x182477A20")]
	[AsyncStateMachine(typeof(BIIFNINCBFC))]
	private Task GIOAFBKLGMA([Optional] CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x24778F0", Offset = "0x24766F0", VA = "0x1824778F0")]
	[AsyncStateMachine(typeof(GMLMMJDOCOE))]
	private Task FANINBEEFEM(TimeSpan MKDLMEGBLBI, CancellationToken OAFNKBHDHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x2477B40", Offset = "0x2476940", VA = "0x182477B40")]
	private Task HOPMPGJKKDJ(AJPLFBMOADO IPKNOBCDJAN, CancellationToken OAFNKBHDHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x2477DB0", Offset = "0x2476BB0", VA = "0x182477DB0")]
	[AsyncStateMachine(typeof(IOLCHIPPONM))]
	private Task IIHCNPJGJHF(AJPLFBMOADO IPKNOBCDJAN, CancellationToken OAFNKBHDHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x2478350", Offset = "0x2477150", VA = "0x182478350")]
	private bool MEEOKLLANDP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BDBCC0", Offset = "0x2BDAAC0", VA = "0x182BDBCC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2473C40", Offset = "0x2472A40", VA = "0x182473C40", Slot = "6")]
	public void ILMEFAAGLOH(BNMEKDBAOON GIGDLICKJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x2473AD0", Offset = "0x24728D0", VA = "0x182473AD0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x2473B20", Offset = "0x2472920", VA = "0x182473B20", Slot = "5")]
	[AsyncStateMachine(typeof(EOBMEAFOIMH))]
	public Task EJBPGMOBNML(string KCGMDGFIHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x2473FA0", Offset = "0x2472DA0", VA = "0x182473FA0", Slot = "4")]
	public NHOKIGNMHJB MEEOKLLANDP(NAJNLFAFJGC BNIKFHMNHAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x2473E60", Offset = "0x2472C60", VA = "0x182473E60")]
	private GLLEMFCMOMN MBOEPFKAINI(string KCGMDGFIHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public CPHJFOOGHIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public static class BHIADAHKLDH
{
	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x246F880", Offset = "0x246E680", VA = "0x18246F880")]
	public static void PAKKNBOAJLE(ELODGKLHEKG BGLEKJNFDOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x246F270", Offset = "0x246E070", VA = "0x18246F270")]
	internal static void JLAHDKFMKCF(ELODGKLHEKG BGLEKJNFDOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x246F7A0", Offset = "0x246E5A0", VA = "0x18246F7A0")]
	internal static void NPILKDOHMNA(ELODGKLHEKG BGLEKJNFDOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x246F350", Offset = "0x246E150", VA = "0x18246F350")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public LKIJOHIOJGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x2BE1890", Offset = "0x2BE0690", VA = "0x182BE1890")]
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
	[Cpp2IlInjected.Address(RVA = "0x2471200", Offset = "0x2470000", VA = "0x182471200")]
	public ExitGames.Client.Photon.Hashtable DGAMFOBEJMM(EBIJFBKIDNI GOJKMEMCPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x2471820", Offset = "0x2470620", VA = "0x182471820", Slot = "5")]
	protected override void NGKOIINGJHA(EBIJFBKIDNI GOJKMEMCPDE, IDictionary<object, object> JANIFNADDOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x2471280", Offset = "0x2470080", VA = "0x182471280", Slot = "6")]
	public override EBIJFBKIDNI HJFKJCGGCHL(IDictionary<object, object> JANIFNADDOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x2471960", Offset = "0x2470760", VA = "0x182471960")]
	private static void PNAJNCEFIKC(string MKJJIEOPNHC, EBIJFBKIDNI GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x2471B60", Offset = "0x2470960", VA = "0x182471B60")]
	public CIOEJJANMAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x24714D0", Offset = "0x24702D0", VA = "0x1824714D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x246E8A0", Offset = "0x246D6A0", VA = "0x18246E8A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x246E610", Offset = "0x246D410", VA = "0x18246E610")]
	public static bool CGILKJLBCKL(this NHOKIGNMHJB MGCHLOMHBGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x246E630", Offset = "0x246D430", VA = "0x18246E630")]
	public static NHOKIGNMHJB FHAIGMPLCLF(EIIFCLNONEI DDFPLICKPCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x246E890", Offset = "0x246D690", VA = "0x18246E890")]
	public static NHOKIGNMHJB IAOKIHNPAEL(params NHOKIGNMHJB[] AEHJOOJHIJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x246E690", Offset = "0x246D490", VA = "0x18246E690")]
	public static NHOKIGNMHJB HGAPCGCPCMG(IEnumerable<NHOKIGNMHJB> AEHJOOJHIJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x246E3A0", Offset = "0x246D1A0", VA = "0x18246E3A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public CCKJFKIOBIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8EB0", Offset = "0x2BD7CB0", VA = "0x182BD8EB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x246DF70", Offset = "0x246CD70", VA = "0x18246DF70", Slot = "4")]
	public void BMDLPHPAJMP(LOHECFFOLLM PFPLDJAOGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x246E020", Offset = "0x246CE20", VA = "0x18246E020", Slot = "5")]
	public void JLJNILIGELN(LOHECFFOLLM PFPLDJAOGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x246DFD0", Offset = "0x246CDD0", VA = "0x18246DFD0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x246E080", Offset = "0x246CE80", VA = "0x18246E080")]
	protected NHOKIGNMHJB PIEALGEAKLP(NAJNLFAFJGC CBOLEAMMNCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x246E320", Offset = "0x246D120", VA = "0x18246E320")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public KALMJKMIAEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x3EEAD70", Offset = "0x3EE9B70", VA = "0x183EEAD70")]
		internal object <CanPlayerReload>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x2BEDA20", Offset = "0x2BEC820", VA = "0x182BEDA20")]
	[Preserve]
	public PLIAAJIOEFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x2BED8A0", Offset = "0x2BEC6A0", VA = "0x182BED8A0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public LCMHIGPNDIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x33CFA80", Offset = "0x33CE880", VA = "0x1833CFA80")]
		internal object <CanPlayerSave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x246E320", Offset = "0x246D120", VA = "0x18246E320")]
	[Preserve]
	public KJPJNKDDPFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x248C580", Offset = "0x248B380", VA = "0x18248C580", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public FMCHKAFOKBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x2BDCE20", Offset = "0x2BDBC20", VA = "0x182BDCE20")]
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
	[Cpp2IlInjected.Address(RVA = "0x2472200", Offset = "0x2471000", VA = "0x182472200")]
	public static global::EHGJMLLEIHA<string> CAGKCLEOBGF([Optional] string BFFLLNCOKMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x24724F0", Offset = "0x24712F0", VA = "0x1824724F0")]
	private static void HJOEDPGCALH(string CCJNKBLKLDJ, LFINMJIEICI APDIGEDLLAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x2472600", Offset = "0x2471400", VA = "0x182472600")]
	private static void IFDJHDJBIAL(string CCJNKBLKLDJ, LFINMJIEICI APDIGEDLLAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x2472390", Offset = "0x2471190", VA = "0x182472390")]
	public static void HCKJHFLFKFG(global::EHGJMLLEIHA<string> APDIGEDLLAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x24722D0", Offset = "0x24710D0", VA = "0x1824722D0")]
	public static string DIABADBDECC(EBIJFBKIDNI CHNJKNKLHMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal static class OKFEKODKLDA
{
	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x2BE9360", Offset = "0x2BE8160", VA = "0x182BE9360")]
	public static void KLDCKNMNJLE(this HCDAFHMBMGC IPDFOMJPIKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x2BE9480", Offset = "0x2BE8280", VA = "0x182BE9480")]
	public static void PJHDKDNJNOI(this HCDAFHMBMGC IPDFOMJPIKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x2BE9370", Offset = "0x2BE8170", VA = "0x182BE9370")]
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
		[Cpp2IlInjected.Address(RVA = "0x2488EA0", Offset = "0x2487CA0", VA = "0x182488EA0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public int PCIKNCNKMAB
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x2488A80", Offset = "0x2487880", VA = "0x182488A80", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public int DCFOHDEGGGG
	{
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x2488C50", Offset = "0x2487A50", VA = "0x182488C50", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool AJPHCAHHDOI
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x678020", Offset = "0x676E20", VA = "0x180678020", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public int PMGHLBFGNFP
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x67DAA0", Offset = "0x67C8A0", VA = "0x18067DAA0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event NNKDONAICAI.JPFPMNIHBLN OLEIONHDKCP
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event EHHIOMFPLEG ODGPIFNOBEH
	{
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x2488980", Offset = "0x2487780", VA = "0x182488980", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x2488CA0", Offset = "0x2487AA0", VA = "0x182488CA0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<bool> CJKEPLAHHFO
	{
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<NAJNLFAFJGC> CIKCJACLPAB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action NAILPCFNBHL
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x2488AD0", Offset = "0x24878D0", VA = "0x182488AD0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x2488D40", Offset = "0x2487B40", VA = "0x182488D40", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x1441A90", Offset = "0x1440890", VA = "0x181441A90")]
	public JHPCMIAOFBD(BKJHIOAPNMM AFKAAAOJFHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x2488EF0", Offset = "0x2487CF0", VA = "0x182488EF0", Slot = "8")]
	public bool NNFCHMIEFJK(byte IFOEKECCJIL, ExitGames.Client.Photon.Hashtable ENMGHICGBNH, PAKHLOGANCK EPALAPHAGOM, SendOptions KLCIFCEAPDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x2488E00", Offset = "0x2487C00", VA = "0x182488E00", Slot = "29")]
	public NAJNLFAFJGC MMHADFICMCJ(int ODLJAAJMJOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x2488B70", Offset = "0x2487970", VA = "0x182488B70", Slot = "16")]
	public NAJNLFAFJGC DHHCBBGABIF(int BGKPECJNKFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "19")]
	public void JHLEIMMLKJJ(object MKDOEIGPNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "20")]
	public void ACGLGJLEBJL(object MKDOEIGPNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "21")]
	public void CDEILBDPKKG(object MKDOEIGPNGM, bool ILDKLPIPLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x2488A20", Offset = "0x2487820", VA = "0x182488A20", Slot = "22")]
	public IDisposable BMEDHEKEIKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x65AD00", Offset = "0x659B00", VA = "0x18065AD00", Slot = "23")]
	private bool NAOOHDJEBFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "24")]
	public void CHBHAGGKAIL(StringBuilder ELDCGCPJOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x2488DE0", Offset = "0x2487BE0", VA = "0x182488DE0", Slot = "25")]
	public bool KELOIMMBEPK(bool JHFAGBELEEM, out string EGNBEILEKKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
	public void GMJHDICFAGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0xF6CC80", Offset = "0xF6BA80", VA = "0x180F6CC80", Slot = "28")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C5D00", Offset = "0x8C4B00", VA = "0x1808C5D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x8648F0", Offset = "0x8636F0", VA = "0x1808648F0")]
	public CNBCGACFMCE(IDictionary<object, object> MMEEGBIBNIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x2473A10", Offset = "0x2472810", VA = "0x182473A10")]
	public bool KGMJDOAJMIG(out EBIJFBKIDNI GOJKMEMCPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x2473930", Offset = "0x2472730", VA = "0x182473930")]
	public Guid IIMEAJKNLMI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x24736E0", Offset = "0x24724E0", VA = "0x1824736E0")]
	public NHOKIGNMHJB BLLEONLHDPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x2473840", Offset = "0x2472640", VA = "0x182473840")]
	public static ExitGames.Client.Photon.Hashtable DAKLFHBAJIH(EBIJFBKIDNI GOJKMEMCPDE, NHOKIGNMHJB MGCHLOMHBGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class BHOPMCJDGJF
{
	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x246FAC0", Offset = "0x246E8C0", VA = "0x18246FAC0")]
	public static string LJAACPDHDNC(this APEIEEGPGIG HBECHKJHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x246FA40", Offset = "0x246E840", VA = "0x18246FA40")]
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
		[Cpp2IlInjected.Address(RVA = "0x33C8150", Offset = "0x33C6F50", VA = "0x1833C8150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2486BC0", Offset = "0x24859C0", VA = "0x182486BC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	internal Task HAENEKGNFHD
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x2486BF0", Offset = "0x24859F0", VA = "0x182486BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2486DA0", Offset = "0x2485BA0", VA = "0x182486DA0")]
	public JAHIKDMIHPI(CancellationToken GPNLCIOKAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x2486C70", Offset = "0x2485A70", VA = "0x182486C70")]
	[AsyncStateMachine(typeof(EPKKIKNGEED))]
	public Task PALDPPNMEAO(Func<CancellationToken, List<Task>> HJHFPKKJLFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x2486B70", Offset = "0x2485970", VA = "0x182486B70", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E2E0D0", Offset = "0x2E2CED0", VA = "0x182E2E0D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x24EEFE0", Offset = "0x24EDDE0", VA = "0x1824EEFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private readonly global::MGAKLJPCJIN<TGetDataArg, TData> NKIPKAGLJMM;

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x8648F0", Offset = "0x8636F0", VA = "0x1808648F0")]
	internal GHKJEADOBPI(global::MGAKLJPCJIN<TGetDataArg, TData> HADJLLLCKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x230DCF0", Offset = "0x230CAF0", VA = "0x18230DCF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x20173E0", Offset = "0x20161E0", VA = "0x1820173E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public long OPOBLJALCPN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x247ACA0", Offset = "0x2479AA0", VA = "0x18247ACA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public long AOPLNJANPLI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x247A590", Offset = "0x2479390", VA = "0x18247A590")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public EAPMGOIGJJL EHHKMNPIDBB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x6A4720", Offset = "0x6A3520", VA = "0x1806A4720")]
		get
		{
			return default(EAPMGOIGJJL);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x247ABB0", Offset = "0x24799B0", VA = "0x18247ABB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public long BFPGGJIFMJA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x247AB50", Offset = "0x2479950", VA = "0x18247AB50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x247AFF0", Offset = "0x2479DF0", VA = "0x18247AFF0")]
	[Preserve]
	public FAKBOJPCPEP([CDAJDCGEMGI(null)] NJPIIIJKOJL PNNNEFJKOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x247A9A0", Offset = "0x24797A0", VA = "0x18247A9A0")]
	private void CEDOKDMMFKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x247A5F0", Offset = "0x24793F0", VA = "0x18247A5F0")]
	public void CCFAOMGKDIC(long MOLCFNPABNJ, long DFGMBHPPELL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x247A4A0", Offset = "0x24792A0", VA = "0x18247A4A0")]
	public void BIOLJIAKKGE(string NPBFKIBBOBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x247AD00", Offset = "0x2479B00", VA = "0x18247AD00")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EED090", Offset = "0x3EEBE90", VA = "0x183EED090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x3EED3A0", Offset = "0x3EEC1A0", VA = "0x183EED3A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public GCKBPACCNKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x3EE8970", Offset = "0x3EE7770", VA = "0x183EE8970")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EE79E0", Offset = "0x3EE67E0", VA = "0x183EE79E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x3EE81B0", Offset = "0x3EE6FB0", VA = "0x183EE81B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EE4B60", Offset = "0x3EE3960", VA = "0x183EE4B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public AGOCCLKMDIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x3EE5140", Offset = "0x3EE3F40", VA = "0x183EE5140")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public NFCELEHFNNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x3EED3F0", Offset = "0x3EEC1F0", VA = "0x183EED3F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public DJFMEPJJHII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x3EE68C0", Offset = "0x3EE56C0", VA = "0x183EE68C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public JGPPCKCOPMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x3EEAC80", Offset = "0x3EE9A80", VA = "0x183EEAC80")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public GNAINPNOPBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x3EE92D0", Offset = "0x3EE80D0", VA = "0x183EE92D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public GIPGFFMGGFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x3EE9030", Offset = "0x3EE7E30", VA = "0x183EE9030")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BEBD20", Offset = "0x2BEAB20", VA = "0x182BEBD20")]
	public OPMGMKLBION(IJNLEAKKLBL OOLGEBPABAO, CNEPFFAJFGO OINNIBDJDBL, IMJIHPPIAKO IPDFOMJPIKI, GOFFGKACLEH IPDHDCELHOH, GEKJCIHAMFL DIOPAPPIBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x2BEAB80", Offset = "0x2BE9980", VA = "0x182BEAB80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x2BEAB80", Offset = "0x2BE9980", VA = "0x182BEAB80")]
	public void CPDMEOIAFBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x2BEAA30", Offset = "0x2BE9830", VA = "0x182BEAA30")]
	public void CFDHBGKFAEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x2BEB290", Offset = "0x2BEA090", VA = "0x182BEB290")]
	public void HIDADPIBDIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x2BEA8B0", Offset = "0x2BE96B0", VA = "0x182BEA8B0")]
	[AsyncStateMachine(typeof(MNDGJBHCOOL))]
	internal Task<EBIJFBKIDNI> BIABBANHFLA(GEKJCIHAMFL DIOPAPPIBBL, EBIJFBKIDNI CHNJKNKLHMC, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x2BE5690", Offset = "0x2BE4490", VA = "0x182BE5690")]
	private static byte[] KFBBIKFPHPG<T>(T GOJKMEMCPDE) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x2C16580", Offset = "0x2C15380", VA = "0x182C16580")]
	private static T NOKFIPPCNNK<T>(MessageParser<T> AKEDKNBOIDO, byte[] GOJKMEMCPDE, T CHPNMHOBKHL) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x2BEAE50", Offset = "0x2BE9C50", VA = "0x182BEAE50")]
	[AsyncStateMachine(typeof(ELMBINMGLEF))]
	private Task<CCOOCPIGFJB> GEKHKJFHGIL(EBIJFBKIDNI CHNJKNKLHMC, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x2C162A0", Offset = "0x2C150A0", VA = "0x182C162A0")]
	[AsyncStateMachine(typeof(NHGLFGCPHOC))]
	internal Task<T> NHCCGNKOBHG<T>(CancellationToken OAFNKBHDHDC, Func<CancellationToken, Task<T>> GHJPKHHPAAH, int KIDBPJKCJMO = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x2BEB680", Offset = "0x2BEA480", VA = "0x182BEB680")]
	[AsyncStateMachine(typeof(ABBKHBBFPFG))]
	internal Task NHCCGNKOBHG(CancellationToken OAFNKBHDHDC, Func<CancellationToken, Task> GHJPKHHPAAH, int KIDBPJKCJMO = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x2BEAD20", Offset = "0x2BE9B20", VA = "0x182BEAD20")]
	public EBIJFBKIDNI DCPFDFDMNFO(FGKKFGNDBFI MKLBEFGGNMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x2BEB3E0", Offset = "0x2BEA1E0", VA = "0x182BEB3E0")]
	public JBJPDOJJABJ HLPDMEIDOCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x2BEB5E0", Offset = "0x2BEA3E0", VA = "0x182BEB5E0")]
	public ICCANIPPKEJ LGADDEENEIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x2BEADB0", Offset = "0x2BE9BB0", VA = "0x182BEADB0")]
	public DFAFJMCGHAN EBEGGCBCHGG([Optional] CAINOHGEENI? KEMAOBJDDDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x2BEB650", Offset = "0x2BEA450", VA = "0x182BEB650")]
	public void NFFBOINMHMM(Func<Guid, bool> EHDENJOEBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x2BEB7D0", Offset = "0x2BEA5D0", VA = "0x182BEB7D0")]
	public void OKKIICHNDFL(Func<Guid, bool> ABEDJBPMAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x2BEB100", Offset = "0x2BE9F00", VA = "0x182BEB100")]
	public void HALGJJAMHDF(Func<Guid, bool> EHDENJOEBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x2BEA650", Offset = "0x2BE9450", VA = "0x182BEA650")]
	public Guid ALBCGKDDNPA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x2BEB450", Offset = "0x2BEA250", VA = "0x182BEB450")]
	public void IGPMONBKLMJ(Guid ALGKOPADFBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x2BEAFB0", Offset = "0x2BE9DB0", VA = "0x182BEAFB0")]
	public void GMJFKJOBCIG(EBIJFBKIDNI EHMADPHKADD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x2BEBB30", Offset = "0x2BEA930", VA = "0x182BEBB30")]
	public void PNAJNCEFIKC(string MLPJOFIPMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x2BEB9B0", Offset = "0x2BEA7B0", VA = "0x182BEB9B0")]
	public void PNAJNCEFIKC(Func<string> FFKBDCJNKKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x2C16730", Offset = "0x2C15530", VA = "0x182C16730")]
	private T PIKGHDFEAKK<T>(T IGJPNMBCJPK) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x2BEA860", Offset = "0x2BE9660", VA = "0x182BEA860")]
	public void BDCIECNAGOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x2C15F90", Offset = "0x2C14D90", VA = "0x182C15F90")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public NJBDGOOIHPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x2BE6340", Offset = "0x2BE5140", VA = "0x182BE6340")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BD8F90", Offset = "0x2BD7D90", VA = "0x182BD8F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public KHOBCFKJEAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF8E0", Offset = "0x2BDE6E0", VA = "0x182BDF8E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x247B7F0", Offset = "0x247A5F0", VA = "0x18247B7F0")]
	public FCPODFONILB(BKDHKLDKOEI NFIKFCMLCIF, APEIEEGPGIG GIKJCJFOAGP, Guid HEHOBBBEICN, BNMEKDBAOON GIGDLICKJEF, KFENGNLKFLE KKKPILGLMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x247B6A0", Offset = "0x247A4A0", VA = "0x18247B6A0", Slot = "8")]
	[AsyncStateMachine(typeof(CJJBMNODMIB))]
	protected override Task NALJOKAAODL(OPMGMKLBION LHKCEHFGEMP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x247B030", Offset = "0x2479E30", VA = "0x18247B030")]
	private LAIENFFFOIL EAELJLJJEBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x247B540", Offset = "0x247A340", VA = "0x18247B540")]
	private void LFLHLOMIELN(LAIENFFFOIL MFAMJHCIMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x247B460", Offset = "0x247A260", VA = "0x18247B460")]
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
		[Cpp2IlInjected.Address(RVA = "0x33CF410", Offset = "0x33CE210", VA = "0x1833CF410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2483BE0", Offset = "0x24829E0", VA = "0x182483BE0")]
	public HHKEAKPEFHI(Guid HEHOBBBEICN, BNMEKDBAOON GIGDLICKJEF, KFENGNLKFLE KKKPILGLMJB, int EILGBIPAPDD, JMDHMLDEGBF DKJPBMEIDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x2483AA0", Offset = "0x24828A0", VA = "0x182483AA0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public LLPLJCINNJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x33D0610", Offset = "0x33CF410", VA = "0x1833D0610")]
		internal Task <RunAsync>b__0(GEKJCIHAMFL postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x33D0650", Offset = "0x33CF450", VA = "0x1833D0650")]
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
		[Cpp2IlInjected.Address(RVA = "0x33D5E70", Offset = "0x33D4C70", VA = "0x1833D5E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x33CC3D0", Offset = "0x33CB1D0", VA = "0x1833CC3D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x2488940", Offset = "0x2487740", VA = "0x182488940")]
	public JHNCJDONPDO(Guid HEHOBBBEICN, BNMEKDBAOON GIGDLICKJEF, KFENGNLKFLE KKKPILGLMJB, string HBKMPJLDNLB, bool AHBIOOADOFD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x24887F0", Offset = "0x24875F0", VA = "0x1824887F0", Slot = "8")]
	[AsyncStateMachine(typeof(ONEDLAHCCEJ))]
	protected override Task NALJOKAAODL(OPMGMKLBION LHKCEHFGEMP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract Task LKPHEFDHMHM(OPMGMKLBION LHKCEHFGEMP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO);

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x2488690", Offset = "0x2487490", VA = "0x182488690")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EE52B0", Offset = "0x3EE40B0", VA = "0x183EE52B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private readonly AJPLFBMOADO IPKNOBCDJAN;

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x2BE2650", Offset = "0x2BE1450", VA = "0x182BE2650")]
	public LOJMGHFNGNC(Guid HEHOBBBEICN, BNMEKDBAOON GIGDLICKJEF, KFENGNLKFLE KKKPILGLMJB, AJPLFBMOADO IPKNOBCDJAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x2BE2430", Offset = "0x2BE1230", VA = "0x182BE2430", Slot = "7")]
	protected override string MPIOLDIPGPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x2BE2510", Offset = "0x2BE1310", VA = "0x182BE2510", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public DOLDLCECIIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x33C63F0", Offset = "0x33C51F0", VA = "0x1833C63F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public HGKFKLIGGCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x33CB670", Offset = "0x33CA470", VA = "0x1833CB670")]
		internal object <Run>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x33CB730", Offset = "0x33CA530", VA = "0x1833CB730")]
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
		[Cpp2IlInjected.Address(RVA = "0x33D0D40", Offset = "0x33CFB40", VA = "0x1833D0D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x33D0380", Offset = "0x33CF180", VA = "0x1833D0380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x65E570", Offset = "0x65D370", VA = "0x18065E570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public JHHHHDEGGMN GNIOAJCHNPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x24865D0", Offset = "0x24853D0", VA = "0x1824865D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public IIFLENBNAPC JGNNILPHNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x2486790", Offset = "0x2485590", VA = "0x182486790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public HPNHGBDLHHJ JLLPNIPEBHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x24864D0", Offset = "0x24852D0", VA = "0x1824864D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public float AFEPPNOIIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x24865B0", Offset = "0x24853B0", VA = "0x1824865B0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event MGLOKFBMOMI IBPFPEKACBI
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x2486900", Offset = "0x2485700", VA = "0x182486900", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x2486620", Offset = "0x2485420", VA = "0x182486620", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x2486A30", Offset = "0x2485830", VA = "0x182486A30")]
	protected IJNLEAKKLBL(Guid HEHOBBBEICN, BNMEKDBAOON GIGDLICKJEF, KFENGNLKFLE KKKPILGLMJB, string HBKMPJLDNLB, bool AHBIOOADOFD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x24868C0", Offset = "0x24856C0", VA = "0x1824868C0", Slot = "7")]
	protected virtual string MPIOLDIPGPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x2486550", Offset = "0x2485350", VA = "0x182486550")]
	public void GOOKKOEKMLJ(PKAAEIEPPHL CMFIFPKIEBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x24864B0", Offset = "0x24852B0", VA = "0x1824864B0")]
	protected void FCACKHGLHFJ(float JOLHNMOCKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x2486640", Offset = "0x2485440", VA = "0x182486640")]
	[AsyncStateMachine(typeof(MDNNKMFLCNA))]
	public Task LCBCKFDJBHE(CancellationToken GPNLCIOKAPO, GEKJCIHAMFL DIOPAPPIBBL, [Optional] Func<IJNLEAKKLBL, GEKJCIHAMFL, OPMGMKLBION> AFAIHEHKLPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x2486920", Offset = "0x2485720", VA = "0x182486920")]
	private void NGEIDOOHPMA(OPMGMKLBION LHKCEHFGEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task NALJOKAAODL(OPMGMKLBION LHKCEHFGEMP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO);

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x24862F0", Offset = "0x24850F0", VA = "0x1824862F0")]
	[AsyncStateMachine(typeof(LFKGKGDMGFD))]
	private Task BGPPOILHLNK(GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x2486430", Offset = "0x2485230", VA = "0x182486430")]
	public EBIJFBKIDNI DCPFDFDMNFO(FGKKFGNDBFI MKLBEFGGNMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x24867E0", Offset = "0x24855E0", VA = "0x1824867E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EE8A80", Offset = "0x3EE7880", VA = "0x183EE8A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400037B")]
	private readonly BKDHKLDKOEI PENEAHICDBK;

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x2BEDF00", Offset = "0x2BECD00", VA = "0x182BEDF00")]
	public POCIKLDNHAG(Guid HEHOBBBEICN, BNMEKDBAOON GIGDLICKJEF, BKDHKLDKOEI PENEAHICDBK, KFENGNLKFLE KKKPILGLMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x2BEDDB0", Offset = "0x2BECBB0", VA = "0x182BEDDB0", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x33C3690", Offset = "0x33C2490", VA = "0x1833C3690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000385")]
	private readonly string BLPKMOHCJBB;

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x2483500", Offset = "0x2482300", VA = "0x182483500")]
	public GLLEMFCMOMN(Guid HEHOBBBEICN, BNMEKDBAOON GIGDLICKJEF, KFENGNLKFLE KKKPILGLMJB, string BLPKMOHCJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x24833D0", Offset = "0x24821D0", VA = "0x1824833D0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x3EF3140", Offset = "0x3EF1F40", VA = "0x183EF3140", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0x3EF3480", Offset = "0x3EF2280", VA = "0x183EF3480", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public DPCLCBNCPPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA300", Offset = "0x2BD9100", VA = "0x182BDA300")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BDA450", Offset = "0x2BD9250", VA = "0x182BDA450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400038C")]
	private readonly int MFEAAAIIPBH;

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x246EEE0", Offset = "0x246DCE0", VA = "0x18246EEE0")]
	public BBJNJOAHKHI(Guid HEHOBBBEICN, BNMEKDBAOON GIGDLICKJEF, int MFEAAAIIPBH, KFENGNLKFLE KKKPILGLMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x246ED80", Offset = "0x246DB80", VA = "0x18246ED80", Slot = "9")]
	[AsyncStateMachine(typeof(EBNLEOPLDMI))]
	protected override Task LKPHEFDHMHM(OPMGMKLBION LHKCEHFGEMP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x246EC90", Offset = "0x246DA90", VA = "0x18246EC90")]
	private void KKKLBIOECPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x246EAF0", Offset = "0x246D8F0", VA = "0x18246EAF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x248BC60", Offset = "0x248AA60", VA = "0x18248BC60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public HPNHGBDLHHJ JLLPNIPEBHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x248BBD0", Offset = "0x248A9D0", VA = "0x18248BBD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x248BCF0", Offset = "0x248AAF0", VA = "0x18248BCF0")]
	protected KAFKKLBILBI(OPMGMKLBION LHKCEHFGEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x248BCB0", Offset = "0x248AAB0", VA = "0x18248BCB0")]
	protected void PNAJNCEFIKC(string MLPJOFIPMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x248BCD0", Offset = "0x248AAD0", VA = "0x18248BCD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BE3110", Offset = "0x2BE1F10", VA = "0x182BE3110")]
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
	[Cpp2IlInjected.Address(RVA = "0x65AD00", Offset = "0x659B00", VA = "0x18065AD00")]
	public static BLGDLMBDCCJ DAKLFHBAJIH()
	{
		return default(BLGDLMBDCCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void DGFJEGNAKHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void IIJNCPNCEDG(HCAOAHLBICC JANIFNADDOP, object LFLBBPIPFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x247BAE0", Offset = "0x247A8E0", VA = "0x18247BAE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2475320", Offset = "0x2474120", VA = "0x182475320")]
	public static DJHBPBOAGIA ALBCGKDDNPA(OPMGMKLBION LHKCEHFGEMP)
	{
		return default(DJHBPBOAGIA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x14AB100", Offset = "0x14A9F00", VA = "0x1814AB100")]
	public void NDJFKCIOAAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x2475380", Offset = "0x2474180", VA = "0x182475380", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x2475490", Offset = "0x2474290", VA = "0x182475490")]
	private DJHBPBOAGIA(OPMGMKLBION LHKCEHFGEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x2475380", Offset = "0x2474180", VA = "0x182475380")]
	private void IGPMONBKLMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x24753E0", Offset = "0x24741E0", VA = "0x1824753E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x33C9B90", Offset = "0x33C8990", VA = "0x1833C9B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x33C4A80", Offset = "0x33C3880", VA = "0x1833C4A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x33C4DA0", Offset = "0x33C3BA0", VA = "0x1833C4DA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x33C9930", Offset = "0x33C8730", VA = "0x1833C9930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3EF1D50", Offset = "0x3EF0B50", VA = "0x183EF1D50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x3EF24A0", Offset = "0x3EF12A0", VA = "0x183EF24A0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3EF24F0", Offset = "0x3EF12F0", VA = "0x183EF24F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0x3EF2A20", Offset = "0x3EF1820", VA = "0x183EF2A20", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3EF0EE0", Offset = "0x3EEFCE0", VA = "0x183EF0EE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public NNIHHCIJBOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x33D2C40", Offset = "0x33D1A40", VA = "0x1833D2C40")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<FMJOIGPDDBD> <LoadRoomLocal>b__2(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x33D2D80", Offset = "0x33D1B80", VA = "0x1833D2D80")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<HCAOAHLBICC> <LoadRoomLocal>b__4(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x33D2EC0", Offset = "0x33D1CC0", VA = "0x1833D2EC0")]
		internal void <LoadRoomLocal>b__6(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x33D2B10", Offset = "0x33D1910", VA = "0x1833D2B10")]
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
		[Cpp2IlInjected.Address(RVA = "0x33CA8E0", Offset = "0x33C96E0", VA = "0x1833CA8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x33C58D0", Offset = "0x33C46D0", VA = "0x1833C58D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x33C3DB0", Offset = "0x33C2BB0", VA = "0x1833C3DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x33CE100", Offset = "0x33CCF00", VA = "0x1833CE100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x33CEBA0", Offset = "0x33CD9A0", VA = "0x1833CEBA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x33C8D30", Offset = "0x33C7B30", VA = "0x1833C8D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x33C98E0", Offset = "0x33C86E0", VA = "0x1833C98E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x33CEBF0", Offset = "0x33CD9F0", VA = "0x1833CEBF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x33CEDF0", Offset = "0x33CDBF0", VA = "0x1833CEDF0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3EF2A70", Offset = "0x3EF1870", VA = "0x183EF2A70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0x3EF2FB0", Offset = "0x3EF1DB0", VA = "0x183EF2FB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public KEGCEDMELOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x33CD9E0", Offset = "0x33CC7E0", VA = "0x1833CD9E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x33C4360", Offset = "0x33C3160", VA = "0x1833C4360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x33C4800", Offset = "0x33C3600", VA = "0x1833C4800", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x33CC840", Offset = "0x33CB640", VA = "0x1833CC840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x33C5DF0", Offset = "0x33C4BF0", VA = "0x1833C5DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x33D06D0", Offset = "0x33CF4D0", VA = "0x1833D06D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public HPCPFNFJOJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x33CB7F0", Offset = "0x33CA5F0", VA = "0x1833CB7F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2484F40", Offset = "0x2483D40", VA = "0x182484F40", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	private BNMEKDBAOON BECJGHCKHIC
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x2484FA0", Offset = "0x2483DA0", VA = "0x182484FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event MGLOKFBMOMI IBPFPEKACBI
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x2485AB0", Offset = "0x24848B0", VA = "0x182485AB0", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x2485930", Offset = "0x2484730", VA = "0x182485930", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x2485C80", Offset = "0x2484A80", VA = "0x182485C80")]
	public ICCANIPPKEJ(OPMGMKLBION LHKCEHFGEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x2484C50", Offset = "0x2483A50", VA = "0x182484C50")]
	[AsyncStateMachine(typeof(GOOOCDLMBBJ))]
	public Task HIMFJPMKCME(BKDHKLDKOEI NMKJPBEONAN, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x2484930", Offset = "0x2483730", VA = "0x182484930")]
	[AsyncStateMachine(typeof(COBLFBGNOBL))]
	private Task<EBIJFBKIDNI> GBJCGLPPFAC(BKDHKLDKOEI NMKJPBEONAN, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x2485950", Offset = "0x2484750", VA = "0x182485950")]
	[AsyncStateMachine(typeof(GMGJBAJNDDB))]
	private Task KPPAJHOJMFP(BKDHKLDKOEI NMKJPBEONAN, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x2484530", Offset = "0x2483330", VA = "0x182484530")]
	[AsyncStateMachine(typeof(GPOECJEEGJI))]
	private Task EMNHIDACCMM(BKDHKLDKOEI NMKJPBEONAN, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken OLCMLFCKHKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x2484FF0", Offset = "0x2483DF0", VA = "0x182484FF0")]
	[AsyncStateMachine(typeof(DCHLDFLBGAG))]
	private Task KDBMGDIEAFH(GEKJCIHAMFL APDIGEDLLAL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x24843D0", Offset = "0x24831D0", VA = "0x1824843D0")]
	[AsyncStateMachine(typeof(CDHDJDPJJAB))]
	private Task ELKKHPBJIMN(HCAOAHLBICC JANIFNADDOP, OLCAEPENJCG KMIGMOKPKMP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x2485120", Offset = "0x2483F20", VA = "0x182485120")]
	[AsyncStateMachine(typeof(KHPJBDCLNLF))]
	private Task<EAPMGOIGJJL> KDMNPMDJBOP(HCAOAHLBICC JANIFNADDOP, OJGNPIKFFGA BCKMHNJGABI, OLCAEPENJCG KMIGMOKPKMP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x2484DA0", Offset = "0x2483BA0", VA = "0x182484DA0")]
	[AsyncStateMachine(typeof(GFEMKGGGLMJ))]
	private Task<EAPMGOIGJJL> HKPFNGPFJLF(HCAOAHLBICC JANIFNADDOP, OJGNPIKFFGA BCKMHNJGABI, OLCAEPENJCG KMIGMOKPKMP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x24853C0", Offset = "0x24841C0", VA = "0x1824853C0")]
	[AsyncStateMachine(typeof(KMHNBGPGGDC))]
	private Task<EAPMGOIGJJL> KFHLDGCLNIM(EAPMGOIGJJL KBGOEBJKIPO, HCAOAHLBICC JFCENPHKLKD, OLCAEPENJCG KMIGMOKPKMP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO, bool MLEKPHBEDEF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x2485B90", Offset = "0x2484990", VA = "0x182485B90")]
	private bool PEGIJHDFDGF(HCAOAHLBICC JEMLMBIJGDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x24841A0", Offset = "0x2482FA0", VA = "0x1824841A0")]
	[AsyncStateMachine(typeof(CLOOPFIFPDG))]
	protected Task<EAPMGOIGJJL> ADCDAMDFEKO(HCAOAHLBICC JANIFNADDOP, OJGNPIKFFGA BCKMHNJGABI, OLCAEPENJCG KMIGMOKPKMP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO, LBCIMFJFNGN BFKCKELMINK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x2485550", Offset = "0x2484350", VA = "0x182485550")]
	[AsyncStateMachine(typeof(JGEOPGHKLGO))]
	private Task KIHAGMLCCMD(HCAOAHLBICC JANIFNADDOP, OLCAEPENJCG KMIGMOKPKMP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x2485B20", Offset = "0x2484920", VA = "0x182485B20")]
	private void NGNCJGLHHDP(EAPMGOIGJJL GPBNCANIOMJ, OLCAEPENJCG KMIGMOKPKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x2484F60", Offset = "0x2483D60", VA = "0x182484F60")]
	private void IPDAPKMKHFH(EAPMGOIGJJL EIENFDHOOKJ, out EAPMGOIGJJL LONGMJJOJLH, out EAPMGOIGJJL JHMMFDIPHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x2484AB0", Offset = "0x24838B0", VA = "0x182484AB0")]
	private Task<FMJOIGPDDBD> HBFKJIAJLIK(BKDHKLDKOEI NMKJPBEONAN, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x2485AD0", Offset = "0x24848D0", VA = "0x182485AD0")]
	private Task<HCAOAHLBICC> NFHGIGKJAEK(BKDHKLDKOEI NMKJPBEONAN, FMJOIGPDDBD JANIFNADDOP, CGCKIHILMNK.JNHPMADDELD CODODFINKNH, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x24847E0", Offset = "0x24835E0", VA = "0x1824847E0")]
	[AsyncStateMachine(typeof(DHPJPPMECDO))]
	private Task FOLMDPBFNNC(HCAOAHLBICC JANIFNADDOP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x2485810", Offset = "0x2484610", VA = "0x182485810")]
	[AsyncStateMachine(typeof(LOHOPBJLPPF))]
	private Task KOLGOFAMINE(HCAOAHLBICC JANIFNADDOP, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x2484350", Offset = "0x2483150", VA = "0x182484350")]
	private Task BKCJFNGCBCL(HCAOAHLBICC JANIFNADDOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x2484680", Offset = "0x2483480", VA = "0x182484680")]
	private Task FJFGONPFKNO(HCAOAHLBICC JANIFNADDOP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x2484380", Offset = "0x2483180", VA = "0x182484380")]
	private Task CHFOBFKKNBB(HCAOAHLBICC JANIFNADDOP, OJGNPIKFFGA BCKMHNJGABI, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x2484FD0", Offset = "0x2483DD0", VA = "0x182484FD0")]
	private Task KAMPCEIHFMC(HCAOAHLBICC JANIFNADDOP, OJGNPIKFFGA BCKMHNJGABI, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x24852A0", Offset = "0x24840A0", VA = "0x1824852A0")]
	private static Task KFGIEBKMBOI(CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x24856B0", Offset = "0x24844B0", VA = "0x1824856B0")]
	private Task KNMCAEFBFKM(HCAOAHLBICC JANIFNADDOP, OJGNPIKFFGA BCKMHNJGABI, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x2485B70", Offset = "0x2484970", VA = "0x182485B70")]
	private Task PCIPAMNKLMD(HCAOAHLBICC JANIFNADDOP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x24843A0", Offset = "0x24831A0", VA = "0x1824843A0")]
	private void EGCNDCIHHEF(BKDHKLDKOEI NMKJPBEONAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x2484AF0", Offset = "0x24838F0", VA = "0x182484AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x247C550", Offset = "0x247B350", VA = "0x18247C550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	private HPNHGBDLHHJ JLLPNIPEBHB
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x247C4D0", Offset = "0x247B2D0", VA = "0x18247C4D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x247C5A0", Offset = "0x247B3A0", VA = "0x18247C5A0")]
	public static Task LCBCKFDJBHE(BNMEKDBAOON GIGDLICKJEF, EAPMGOIGJJL GPBNCANIOMJ, HCAOAHLBICC JANIFNADDOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x247C650", Offset = "0x247B450", VA = "0x18247C650")]
	private void LCBCKFDJBHE()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal struct IOGKIHAHBLJ
{
	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x24852A0", Offset = "0x24840A0", VA = "0x1824852A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EEB930", Offset = "0x3EEA730", VA = "0x183EEB930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x2BEDC60", Offset = "0x2BECA60", VA = "0x182BEDC60")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EE9E40", Offset = "0x3EE8C40", VA = "0x183EE9E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x2BE1190", Offset = "0x2BDFF90", VA = "0x182BE1190")]
	[AsyncStateMachine(typeof(IPKMAOIMLMJ))]
	public static Task LCBCKFDJBHE(OPMGMKLBION LHKCEHFGEMP, HCAOAHLBICC JANIFNADDOP, OJGNPIKFFGA BCKMHNJGABI, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x2BE0F20", Offset = "0x2BDFD20", VA = "0x182BE0F20")]
	private static void GLNOHLEMIEN(PersistenceView LFIMBOIOPFD, OGPFCDLOHHL LFLBBPIPFGK, HCAOAHLBICC JANIFNADDOP, EAPMGOIGJJL KBGOEBJKIPO, bool ECBEEOFKIEC)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal struct NBKOALJKDIM
{
	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x2BE40A0", Offset = "0x2BE2EA0", VA = "0x182BE40A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x33D29A0", Offset = "0x33D17A0", VA = "0x1833D29A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x33CFAE0", Offset = "0x33CE8E0", VA = "0x1833CFAE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public IMNFBNCJIGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x33CC240", Offset = "0x33CB040", VA = "0x1833CC240")]
		internal object <DestroyActivePersistenceViews>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x33CC320", Offset = "0x33CB120", VA = "0x1833CC320")]
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
		[Cpp2IlInjected.Address(RVA = "0x248B830", Offset = "0x248A630", VA = "0x18248B830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	private HPNHGBDLHHJ JLLPNIPEBHB
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x248B7B0", Offset = "0x248A5B0", VA = "0x18248B7B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x248B9F0", Offset = "0x248A7F0", VA = "0x18248B9F0")]
	[AsyncStateMachine(typeof(NJJFLMLCIML))]
	public static Task LCBCKFDJBHE(BNMEKDBAOON GIGDLICKJEF, EAPMGOIGJJL GPBNCANIOMJ, HCAOAHLBICC JANIFNADDOP, OPMGMKLBION LHKCEHFGEMP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x248B8B0", Offset = "0x248A6B0", VA = "0x18248B8B0")]
	[AsyncStateMachine(typeof(LECACMPMEKJ))]
	private Task LCBCKFDJBHE(GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x248B110", Offset = "0x2489F10", VA = "0x18248B110")]
	private void FPAHPKINLAH([NotNull] IOFNFGHMKGC CNBHMNJLPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x248B880", Offset = "0x248A680", VA = "0x18248B880")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EED990", Offset = "0x3EEC790", VA = "0x183EED990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x3EEE250", Offset = "0x3EED050", VA = "0x183EEE250", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EE9550", Offset = "0x3EE8350", VA = "0x183EE9550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x3EE9A40", Offset = "0x3EE8840", VA = "0x183EE9A40", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BED260", Offset = "0x2BEC060", VA = "0x182BED260")]
	public static Task<HCAOAHLBICC> IGFNOIKFCOE(BNMEKDBAOON GIGDLICKJEF, BKDHKLDKOEI NMKJPBEONAN, in FMJOIGPDDBD JANIFNADDOP, CGCKIHILMNK.JNHPMADDELD CODODFINKNH, GEKJCIHAMFL APDIGEDLLAL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x2BED730", Offset = "0x2BEC530", VA = "0x182BED730")]
	[AsyncStateMachine(typeof(NGEDLCAGOID))]
	private Task<HCAOAHLBICC> LCBCKFDJBHE(CGCKIHILMNK.JNHPMADDELD CODODFINKNH, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x2BED220", Offset = "0x2BEC020", VA = "0x182BED220")]
	private JPCHJAOPHGN ANJHDLDNACK(BCCAOCCFAIE LFFEAHLLHAI)
	{
		return default(JPCHJAOPHGN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x2BED580", Offset = "0x2BEC380", VA = "0x182BED580")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BE63B0", Offset = "0x2BE51B0", VA = "0x182BE63B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x2BE6860", Offset = "0x2BE5660", VA = "0x182BE6860", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BD7550", Offset = "0x2BD6350", VA = "0x182BD7550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7740", Offset = "0x2BD6540", VA = "0x182BD7740", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public IDEIMKGOHAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0xEF1F20", Offset = "0xEF0D20", VA = "0x180EF1F20")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BD7E10", Offset = "0x2BD6C10", VA = "0x182BD7E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8350", Offset = "0x2BD7150", VA = "0x182BD8350", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2476480", Offset = "0x2475280", VA = "0x182476480")]
	public static Task<FMJOIGPDDBD> IGFNOIKFCOE(BNMEKDBAOON GIGDLICKJEF, BKDHKLDKOEI NMKJPBEONAN, GEKJCIHAMFL APDIGEDLLAL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x2476880", Offset = "0x2475680", VA = "0x182476880")]
	[AsyncStateMachine(typeof(NKLNNFECBLH))]
	private Task<FMJOIGPDDBD> LCBCKFDJBHE(CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x24762F0", Offset = "0x24750F0", VA = "0x1824762F0")]
	[AsyncStateMachine(typeof(BINMMFGLIKA))]
	private Task<FMJOIGPDDBD> HBFKJIAJLIK(long MOLCFNPABNJ, long DFGMBHPPELL, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO, bool OJGGILPHFII = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x2476170", Offset = "0x2474F70", VA = "0x182476170")]
	[AsyncStateMachine(typeof(CBKFKHPMKNE))]
	public static Task<FMJOIGPDDBD> HBFKJIAJLIK(JHHHHDEGGMN NFACINHMFIO, long MOLCFNPABNJ, long DFGMBHPPELL, CancellationToken GPNLCIOKAPO, GEKJCIHAMFL DIOPAPPIBBL, bool OJGGILPHFII = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x24769E0", Offset = "0x24757E0", VA = "0x1824769E0")]
	private void MCJHBECOJHC(KEBPHEIFBOC PPPFAIKANPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x2476710", Offset = "0x2475510", VA = "0x182476710")]
	private bool KEPAOPIPIGB(FMJOIGPDDBD JANIFNADDOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x2475FD0", Offset = "0x2474DD0", VA = "0x182475FD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EE9A90", Offset = "0x3EE8890", VA = "0x183EE9A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BE0C80", Offset = "0x2BDFA80", VA = "0x182BE0C80")]
	public static Task NCODJPAEEPA(BNMEKDBAOON GIGDLICKJEF, HCAOAHLBICC JANIFNADDOP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x2BE0A90", Offset = "0x2BDF890", VA = "0x182BE0A90")]
	[AsyncStateMachine(typeof(IIAMJECNCCE))]
	public Task LCBCKFDJBHE(CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x2BE0700", Offset = "0x2BDF500", VA = "0x182BE0700")]
	private static void EONJAIEFODL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x2BE08A0", Offset = "0x2BDF6A0", VA = "0x182BE08A0")]
	private void GBMMJMBJPJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x2BE0BC0", Offset = "0x2BDF9C0", VA = "0x182BE0BC0")]
	private static float LLKGANJMGEC(JHHHHDEGGMN NFACINHMFIO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x2BE0A70", Offset = "0x2BDF870", VA = "0x182BE0A70")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BDAFA0", Offset = "0x2BD9DA0", VA = "0x182BDAFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BDE850", Offset = "0x2BDD650", VA = "0x182BDE850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x247A340", Offset = "0x2479140", VA = "0x18247A340")]
	[AsyncStateMachine(typeof(EKBENMMCGMC))]
	public static Task LCBCKFDJBHE(OPMGMKLBION LHKCEHFGEMP, HCAOAHLBICC JANIFNADDOP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x247A2D0", Offset = "0x24790D0", VA = "0x18247A2D0")]
	private static Task<EBIJFBKIDNI> KHAAGFBBHNM(OPMGMKLBION LHKCEHFGEMP, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x247A200", Offset = "0x2479000", VA = "0x18247A200")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EED450", Offset = "0x3EEC250", VA = "0x183EED450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public JPPAHIEGJGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x3EEACF0", Offset = "0x3EE9AF0", VA = "0x183EEACF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EEE2A0", Offset = "0x3EED0A0", VA = "0x183EEE2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BE4030", Offset = "0x2BE2E30", VA = "0x182BE4030")]
	public static Task OFHCMEEIHNP(BNMEKDBAOON GIGDLICKJEF, bool JCOBIOMDJAM, GEKJCIHAMFL APDIGEDLLAL, CancellationToken IJAKIFIPFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x2BE3DF0", Offset = "0x2BE2BF0", VA = "0x182BE3DF0")]
	[AsyncStateMachine(typeof(NFDBJMCKGLI))]
	private Task LCBCKFDJBHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x2BE3F00", Offset = "0x2BE2D00", VA = "0x182BE3F00")]
	[AsyncStateMachine(typeof(NGEGCELLKFF))]
	private Task MHAPMLDLIAD(bool FPJHKLFPJPH, string OFIBKFPDOOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x65AD00", Offset = "0x659B00", VA = "0x18065AD00")]
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
		[Cpp2IlInjected.Address(RVA = "0x33D1FA0", Offset = "0x33D0DA0", VA = "0x1833D1FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x33D22B0", Offset = "0x33D10B0", VA = "0x1833D22B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public HFEPFKEFCMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x33CB620", Offset = "0x33CA420", VA = "0x1833CB620")]
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
		[Cpp2IlInjected.Address(RVA = "0x33D6AD0", Offset = "0x33D58D0", VA = "0x1833D6AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x33D7010", Offset = "0x33D5E10", VA = "0x1833D7010", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2486150", Offset = "0x2484F50", VA = "0x182486150")]
	public static Task<Scene> PHKGDBMINFN(BNMEKDBAOON GIGDLICKJEF, HKINGCIIOMD GGEEOEBDOJA, GEKJCIHAMFL APDIGEDLLAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x2485EC0", Offset = "0x2484CC0", VA = "0x182485EC0")]
	[AsyncStateMachine(typeof(NFIEPBIBDPO))]
	private Task<Scene> LCBCKFDJBHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x2486000", Offset = "0x2484E00", VA = "0x182486000")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BDEB70", Offset = "0x2BDD970", VA = "0x182BDEB70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF300", Offset = "0x2BDE100", VA = "0x182BDF300", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BDDB80", Offset = "0x2BDC980", VA = "0x182BDDB80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x2BDDF70", Offset = "0x2BDCD70", VA = "0x182BDDF70", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F7B00", Offset = "0x8F6900", VA = "0x1808F7B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x247A1A0", Offset = "0x2478FA0", VA = "0x18247A1A0")]
	public EMCEJDAKCDH(OPMGMKLBION LHKCEHFGEMP, FAKBOJPCPEP GDIICIICHHB, NNBBGKOINHN AMLLMEIEEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x2479E40", Offset = "0x2478C40", VA = "0x182479E40")]
	[AsyncStateMachine(typeof(KBHEBBKPAGF))]
	public Task<EAPMGOIGJJL> GHBENKCIKOC(EAPMGOIGJJL LJLGOEGBLHB, HCAOAHLBICC JFCENPHKLKD, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO, bool MLEKPHBEDEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x2479FE0", Offset = "0x2478DE0", VA = "0x182479FE0")]
	[AsyncStateMachine(typeof(ILLEOEKHIEB))]
	private Task<EAPMGOIGJJL> KEPIMGGAOKA(GEKJCIHAMFL DIOPAPPIBBL, EAPMGOIGJJL PBHDPEJBGCP, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x247A150", Offset = "0x2478F50", VA = "0x18247A150")]
	private bool KILAAELNBBM(EAPMGOIGJJL HLCMBINOMIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x247A180", Offset = "0x2478F80", VA = "0x18247A180")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BE8D60", Offset = "0x2BE7B60", VA = "0x182BE8D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x2477660", Offset = "0x2476460", VA = "0x182477660")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EEBD90", Offset = "0x3EEAB90", VA = "0x183EEBD90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x2BEDFA0", Offset = "0x2BECDA0", VA = "0x182BEDFA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x707A10", Offset = "0x706810", VA = "0x180707A10")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public IBNKLAEOGCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x33CBA80", Offset = "0x33CA880", VA = "0x1833CBA80")]
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
		[Cpp2IlInjected.Address(RVA = "0x2489A00", Offset = "0x2488800", VA = "0x182489A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x2489A50", Offset = "0x2488850", VA = "0x182489A50")]
	public static GLGMDEHDLCE LCBCKFDJBHE(BNMEKDBAOON GIGDLICKJEF, HCAOAHLBICC JANIFNADDOP)
	{
		return default(GLGMDEHDLCE);
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x2489AB0", Offset = "0x24888B0", VA = "0x182489AB0")]
	private GLGMDEHDLCE LCBCKFDJBHE()
	{
		return default(GLGMDEHDLCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x2488FA0", Offset = "0x2487DA0", VA = "0x182488FA0")]
	private GLGMDEHDLCE ANPHCMMMEIA(IOFNFGHMKGC CNBHMNJLPIE, FNCCMIGPLFA MGLNHNJLBCH)
	{
		return default(GLGMDEHDLCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x24894F0", Offset = "0x24882F0", VA = "0x1824894F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public CDLAMDDEONE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8EE0", Offset = "0x2BD7CE0", VA = "0x182BD8EE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public BPEJGMODIBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7CC0", Offset = "0x2BD6AC0", VA = "0x182BD7CC0")]
		internal object <Run>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x2471BA0", Offset = "0x24709A0", VA = "0x182471BA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EECC30", Offset = "0x3EEBA30", VA = "0x183EECC30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3EF3000", Offset = "0x3EF1E00", VA = "0x183EF3000", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000561")]
			[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public MDGPPDIMPLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x3EECF70", Offset = "0x3EEBD70", VA = "0x183EECF70")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EEC810", Offset = "0x3EEB610", VA = "0x183EEC810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EE4CC0", Offset = "0x3EE3AC0", VA = "0x183EE4CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EE8200", Offset = "0x3EE7000", VA = "0x183EE8200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3EF0DA0", Offset = "0x3EEFBA0", VA = "0x183EF0DA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600056D")]
			[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public DEKELKJHGDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x3EE6590", Offset = "0x3EE5390", VA = "0x183EE6590")]
		internal object <InvokeMethodsInParallel>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x3EE6770", Offset = "0x3EE5570", VA = "0x183EE6770")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task <InvokeMethodsInParallel>b__2(IFAGDKLCNFF handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x3EE6680", Offset = "0x3EE5480", VA = "0x183EE6680")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EE7460", Offset = "0x3EE6260", VA = "0x183EE7460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EE71E0", Offset = "0x3EE5FE0", VA = "0x183EE71E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public KCAEIEINMCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x3EEADD0", Offset = "0x3EE9BD0", VA = "0x183EEADD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EEF620", Offset = "0x3EEE420", VA = "0x183EEF620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public CGBLFFPGDIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x3EE5D40", Offset = "0x3EE4B40", VA = "0x183EE5D40")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EE57E0", Offset = "0x3EE45E0", VA = "0x183EE57E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public OEECNFBJPPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x3EEF540", Offset = "0x3EEE340", VA = "0x183EEF540")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B0BA0", Offset = "0x7AF9A0", VA = "0x1807B0BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x657F40", Offset = "0x656D40", VA = "0x180657F40")]
	public NNBBGKOINHN(OPMGMKLBION LHKCEHFGEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7780", Offset = "0x2BE6580", VA = "0x182BE7780")]
	[AsyncStateMachine(typeof(LMONBKFKJKE))]
	public Task LCBCKFDJBHE(EAPMGOIGJJL KBGOEBJKIPO, HCAOAHLBICC JFCENPHKLKD, GEKJCIHAMFL APDIGEDLLAL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7030", Offset = "0x2BE5E30", VA = "0x182BE7030")]
	[AsyncStateMachine(typeof(LLIJLENGMAC))]
	private Task HDMCKCINICO(HCAOAHLBICC JANIFNADDOP, GEKJCIHAMFL APDIGEDLLAL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x2BE6A60", Offset = "0x2BE5860", VA = "0x182BE6A60")]
	[AsyncStateMachine(typeof(AFGJLCEGHDP))]
	private Task BAIODGEDHBD(HCAOAHLBICC JANIFNADDOP, GEKJCIHAMFL APDIGEDLLAL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x2BE6ED0", Offset = "0x2BE5CD0", VA = "0x182BE6ED0")]
	[AsyncStateMachine(typeof(EMGCHKGAHIJ))]
	private Task GKKDFCBONPI(HCAOAHLBICC JANIFNADDOP, GEKJCIHAMFL APDIGEDLLAL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x2BE74F0", Offset = "0x2BE62F0", VA = "0x182BE74F0")]
	[AsyncStateMachine(typeof(EJJCGFNDGHJ))]
	private Task INEHBILAMOH(Guid FOCMMNAGAHJ, List<IFAGDKLCNFF> KBLJALNKBNI, NODKGJNBIEL CDBNLIAPAHN, HCAOAHLBICC JANIFNADDOP, CancellationToken MKDOEIGPNGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x2BE78E0", Offset = "0x2BE66E0", VA = "0x182BE78E0")]
	[AsyncStateMachine(typeof(EICGEPKHOPI))]
	private Task NGKFNODHOED(HCAOAHLBICC JANIFNADDOP, GEKJCIHAMFL APDIGEDLLAL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x2BE6D90", Offset = "0x2BE5B90", VA = "0x182BE6D90")]
	[AsyncStateMachine(typeof(OJMHPPPAGAH))]
	private Task BMAOFPLALIJ(Guid KPIJMANOKJC, HCAOAHLBICC JANIFNADDOP, GEKJCIHAMFL APDIGEDLLAL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7630", Offset = "0x2BE6430", VA = "0x182BE7630")]
	[AsyncStateMachine(typeof(AOHDHINGMBH))]
	private Task KEBIKEACKJK(Guid KPIJMANOKJC, GEKJCIHAMFL DIOPAPPIBBL, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7190", Offset = "0x2BE5F90", VA = "0x182BE7190")]
	private void IIIDALPDADN(Guid KPIJMANOKJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x2BE6940", Offset = "0x2BE5740", VA = "0x182BE6940")]
	private void ADNMFNHPFBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7320", Offset = "0x2BE6120", VA = "0x182BE7320")]
	public Guid ILMMNACEBKH(EAPMGOIGJJL GPBNCANIOMJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x2BE6BC0", Offset = "0x2BE59C0", VA = "0x182BE6BC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BE1C40", Offset = "0x2BE0A40", VA = "0x182BE1C40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BD7040", Offset = "0x2BD5E40", VA = "0x182BD7040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7500", Offset = "0x2BD6300", VA = "0x182BD7500", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public BFFGKFDMGGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6CC0", Offset = "0x2BD5AC0", VA = "0x182BD6CC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public GLNDNJHEOJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x2BDCEA0", Offset = "0x2BDBCA0", VA = "0x182BDCEA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public BIOGIIBPJEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7790", Offset = "0x2BD6590", VA = "0x182BD7790")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BD5640", Offset = "0x2BD4440", VA = "0x182BD5640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2475220", Offset = "0x2474020", VA = "0x182475220")]
	public DFAFJMCGHAN(OPMGMKLBION LHKCEHFGEMP, [Optional] CAINOHGEENI? KEMAOBJDDDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x2474000", Offset = "0x2472E00", VA = "0x182474000")]
	[AsyncStateMachine(typeof(BILHNCFDOJK))]
	public Task<LKMGECBKGBM> DGAMFOBEJMM(long DFGMBHPPELL, string HCJPHBNCMNO, CLIMILMGEFO KKAEEEBDAEI, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x2474AF0", Offset = "0x24738F0", VA = "0x182474AF0")]
	[AsyncStateMachine(typeof(ACOLECMGAKB))]
	private Task LGBJAEBDECP(CLIMILMGEFO KKAEEEBDAEI, IEnumerable<PersistenceView> FBLBBMMKOFA, StringBuilder IHOCFABMDIP, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x24742F0", Offset = "0x24730F0", VA = "0x1824742F0")]
	private LKMGECBKGBM GIPPOJKKDME(long DFGMBHPPELL, string HCJPHBNCMNO, CLIMILMGEFO KKAEEEBDAEI, IEnumerable<PersistenceView> FBLBBMMKOFA, StringBuilder IHOCFABMDIP)
	{
		return default(LKMGECBKGBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x2474180", Offset = "0x2472F80", VA = "0x182474180")]
	private IOFNFGHMKGC FELAOKIJFBP(long DFGMBHPPELL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x24748D0", Offset = "0x24736D0", VA = "0x1824748D0")]
	private void HFJNMFGGBJP(IOFNFGHMKGC OJHDCGLFIGP, StringBuilder IHOCFABMDIP, IEnumerable<PersistenceView> FBLBBMMKOFA, in KAOKLILBFNH PAKEAHNPOIE, ref EDCLOMJFAPK LBNDJKJAFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x2474C50", Offset = "0x2473A50", VA = "0x182474C50")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public ENFBJKPKFKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x33C7CC0", Offset = "0x33C6AC0", VA = "0x1833C7CC0")]
		internal object <UploadRoomData>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x33C7D50", Offset = "0x33C6B50", VA = "0x1833C7D50")]
		internal object <UploadRoomData>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x33C7DA0", Offset = "0x33C6BA0", VA = "0x1833C7DA0")]
		internal object <UploadRoomData>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x33C7E10", Offset = "0x33C6C10", VA = "0x1833C7E10")]
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
		[Cpp2IlInjected.Address(RVA = "0x33C6420", Offset = "0x33C5220", VA = "0x1833C6420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x33C6ED0", Offset = "0x33C5CD0", VA = "0x1833C6ED0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x33D1AF0", Offset = "0x33D08F0", VA = "0x1833D1AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x33D1ED0", Offset = "0x33D0CD0", VA = "0x1833D1ED0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x33C2C60", Offset = "0x33C1A60", VA = "0x1833C2C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x33C2FF0", Offset = "0x33C1DF0", VA = "0x1833C2FF0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3EF34D0", Offset = "0x3EF22D0", VA = "0x183EF34D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x3EF4200", Offset = "0x3EF3000", VA = "0x183EF4200", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public DIPBHGHJIEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x33C62B0", Offset = "0x33C50B0", VA = "0x1833C62B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x33C5FC0", Offset = "0x33C4DC0", VA = "0x1833C5FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x33C6260", Offset = "0x33C5060", VA = "0x1833C6260", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2484FA0", Offset = "0x2483DA0", VA = "0x182484FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x24874D0", Offset = "0x24862D0", VA = "0x1824874D0")]
	public JBJPDOJJABJ(OPMGMKLBION LHKCEHFGEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x2487060", Offset = "0x2485E60", VA = "0x182487060")]
	[AsyncStateMachine(typeof(EBGAEMOCMHK))]
	private Task<(CPNCAGGGIFF.AKNNMODCGFG, CPNCAGGGIFF.AKNNMODCGFG)> EJLPEBEKOIJ(LKMGECBKGBM BALDFHIGHBN, long MOLCFNPABNJ, long PECECCFMGMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x24871D0", Offset = "0x2485FD0", VA = "0x1824871D0")]
	[AsyncStateMachine(typeof(MINHACLOICC))]
	public Task<KEBPHEIFBOC> LKGCFPKGPIA(int MFEAAAIIPBH, LKMGECBKGBM BALDFHIGHBN, long MOLCFNPABNJ, long PECECCFMGMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x2487340", Offset = "0x2486140", VA = "0x182487340")]
	[AsyncStateMachine(typeof(BBDJIICMOEH))]
	private Task<ALDCBDNNGDB> MKPHCIPBCOH(string LPNGHDMHFPE, int MFEAAAIIPBH, LKMGECBKGBM BALDFHIGHBN, long MOLCFNPABNJ, long PECECCFMGMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x2486EC0", Offset = "0x2485CC0", VA = "0x182486EC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xE11EB0", Offset = "0xE10CB0", VA = "0x180E11EB0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x248B050", Offset = "0x2489E50", VA = "0x18248B050")]
	public JPBBJDIHKKD(EHJEKJMFKEA HOLLDENJHAO, [Optional] Guid? HEHOBBBEICN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x223CCA0", Offset = "0x223BAA0", VA = "0x18223CCA0")]
	public JPBBJDIHKKD LMBCGHJIBCO(BKDHKLDKOEI DEHKKADBBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x248AEE0", Offset = "0x2489CE0", VA = "0x18248AEE0")]
	public EBIJFBKIDNI FJCJCNIEEHC(out Guid APDFCJDGEAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x248AFC0", Offset = "0x2489DC0", VA = "0x18248AFC0")]
	public JPBBJDIHKKD LGKAHKDFINB(NAJNLFAFJGC EKLMBAFFHEO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
public static class DMFNFFMDBLH
{
	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x2475F30", Offset = "0x2474D30", VA = "0x182475F30")]
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
			[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BEEC90", Offset = "0x2BEDA90", VA = "0x182BEEC90")]
		public bool JCBNAEIKEJH(EIIFCLNONEI DDFPLICKPCJ, out ResultConfig HHBPPIPMCAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x2BEEB70", Offset = "0x2BED970", VA = "0x182BEEB70")]
		public ResultConfig CLCEPEJKAEO(EIIFCLNONEI HDEEEPPJEGL, [Optional] HashSet<EIIFCLNONEI> DBFHBEFEGCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x2BEF280", Offset = "0x2BEE080", VA = "0x182BEF280", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x2BEED00", Offset = "0x2BEDB00", VA = "0x182BEED00", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0xD12960", Offset = "0xD11760", VA = "0x180D12960")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000171")]
public static class HOOPKNLOMIP
{
	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x2483D00", Offset = "0x2482B00", VA = "0x182483D00")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public JEOEJCDAGOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x3EEAC10", Offset = "0x3EE9A10", VA = "0x183EEAC10")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BEC4C0", Offset = "0x2BEB2C0", VA = "0x182BEC4C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x2BECB30", Offset = "0x2BEB930", VA = "0x182BECB30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x657F40", Offset = "0x656D40", VA = "0x180657F40")]
	[Preserve]
	public PCJEHKKGIIJ([CDAJDCGEMGI(null)] CELJAEDAMMM DLPINKFHFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC6E0", Offset = "0x2BEB4E0", VA = "0x182BEC6E0", Slot = "6")]
	public bool DLMAJFBMFNE(long MOLCFNPABNJ, long DFGMBHPPELL, LKMGECBKGBM BALDFHIGHBN, AJPLFBMOADO IPKNOBCDJAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0x2BECA90", Offset = "0x2BEB890", VA = "0x182BECA90")]
	private void HIOIFCBOJNK(JMDHMLDEGBF DKJPBMEIDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC560", Offset = "0x2BEB360", VA = "0x182BEC560", Slot = "7")]
	public bool CPGKDBCEKLP(long MOLCFNPABNJ, long DFGMBHPPELL, out JMDHMLDEGBF BACNBDCPFIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC9E0", Offset = "0x2BEB7E0", VA = "0x182BEC9E0", Slot = "8")]
	public bool FDLNGJBHNCB(long MOLCFNPABNJ, long DFGMBHPPELL, AJPLFBMOADO IPKNOBCDJAN, out JMDHMLDEGBF BACNBDCPFIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x2BEBF40", Offset = "0x2BEAD40", VA = "0x182BEBF40")]
	private void AGIBOOKHHCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC3A0", Offset = "0x2BEB1A0", VA = "0x182BEC3A0", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x9DD5E0", Offset = "0x9DC3E0", VA = "0x1809DD5E0")]
		[DebuggerHidden]
		public CCGEBCHPLLK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8C60", Offset = "0x2BD7A60", VA = "0x182BD8C60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8E70", Offset = "0x2BD7C70", VA = "0x182BD8E70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8DC0", Offset = "0x2BD7BC0", VA = "0x182BD8DC0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JMDHMLDEGBF> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8DC0", Offset = "0x2BD7BC0", VA = "0x182BD8DC0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public EOGPNKFOHLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x2BDBFF0", Offset = "0x2BDADF0", VA = "0x182BDBFF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public DBBHBCGBHAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9590", Offset = "0x2BD8390", VA = "0x182BD9590")]
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
	[Cpp2IlInjected.Address(RVA = "0x247C440", Offset = "0x247B240", VA = "0x18247C440")]
	protected GAJOHNFLFGI([CanBeNull] string EIOEJAMHJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x247BEC0", Offset = "0x247ACC0", VA = "0x18247BEC0", Slot = "5")]
	public bool GLOHAJBMNDO(long MOLCFNPABNJ, long DFGMBHPPELL, AJPLFBMOADO IPKNOBCDJAN, out JMDHMLDEGBF DKJPBMEIDDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x247C3C0", Offset = "0x247B1C0", VA = "0x18247C3C0", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x247BB30", Offset = "0x247A930", VA = "0x18247BB30", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x247C0A0", Offset = "0x247AEA0", VA = "0x18247C0A0")]
	protected void JOBGOJHHLHP(HLKPICCBEBB.DEENNFCDPID IPIOPDFMFIE, string IALJJELLBDF, FileInfo FAEGOFALDDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(RVA = "0x247C110", Offset = "0x247AF10", VA = "0x18247C110")]
	internal bool LKCDEOPEGLN(FileInfo DFBNDHNPDFL, long MOLCFNPABNJ, long DFGMBHPPELL, out LKMGECBKGBM BALDFHIGHBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x107FD10", Offset = "0x107EB10", VA = "0x18107FD10", Slot = "8")]
		get
		{
			return default(NNGBDGBOMML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x24775B0", Offset = "0x24763B0", VA = "0x1824775B0")]
	public EFHPABJAAPM([Optional] string EIOEJAMHJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x2476F40", Offset = "0x2475D40", VA = "0x182476F40")]
	private void KLJECLIKHDC(AJPLFBMOADO IPKNOBCDJAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x2476BE0", Offset = "0x24759E0", VA = "0x182476BE0", Slot = "9")]
	internal override void DKLNLPAOBCB(Stream HHMPJGCDHKP, long MOLCFNPABNJ, long DFGMBHPPELL, LKMGECBKGBM BALDFHIGHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x2476FC0", Offset = "0x2475DC0", VA = "0x182476FC0", Slot = "10")]
	internal override bool NFPCELLPLOM(Stream COOMPKGFBMI, long MOLCFNPABNJ, long DFGMBHPPELL, NLDLEPKEJNC BJGIOAGOLII, out LKMGECBKGBM BALDFHIGHBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x2476AF0", Offset = "0x24758F0", VA = "0x182476AF0", Slot = "11")]
	protected override FileInfo DJCFBNGMDEB(long MOLCFNPABNJ, long DFGMBHPPELL, AJPLFBMOADO IPKNOBCDJAN, MFDIBGFNHJF MIFLCKHFGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(RVA = "0x2476E30", Offset = "0x2475C30", VA = "0x182476E30", Slot = "12")]
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
		[Cpp2IlInjected.Address(RVA = "0x711020", Offset = "0x70FE20", VA = "0x180711020", Slot = "8")]
		get
		{
			return default(NNGBDGBOMML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x2473590", Offset = "0x2472390", VA = "0x182473590")]
	public CMCAFHHICMG([Optional] string EIOEJAMHJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x2472830", Offset = "0x2471630", VA = "0x182472830", Slot = "9")]
	internal override void DKLNLPAOBCB(Stream HHMPJGCDHKP, long MOLCFNPABNJ, long DFGMBHPPELL, LKMGECBKGBM BALDFHIGHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x2472D00", Offset = "0x2471B00", VA = "0x182472D00", Slot = "10")]
	internal override bool NFPCELLPLOM(Stream COOMPKGFBMI, long MOLCFNPABNJ, long DFGMBHPPELL, NLDLEPKEJNC BJGIOAGOLII, out LKMGECBKGBM BALDFHIGHBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x2472BF0", Offset = "0x24719F0", VA = "0x182472BF0")]
	private void LMKBPLJICIP(byte[] HFAIGCGNPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x2472700", Offset = "0x2471500", VA = "0x182472700", Slot = "11")]
	protected override FileInfo DJCFBNGMDEB(long MOLCFNPABNJ, long DFGMBHPPELL, AJPLFBMOADO IPKNOBCDJAN, MFDIBGFNHJF MIFLCKHFGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0x2472AD0", Offset = "0x24718D0", VA = "0x182472AD0", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x9DD5E0", Offset = "0x9DC3E0", VA = "0x1809DD5E0")]
		[DebuggerHidden]
		public COHHKDFCNLM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x3EE6440", Offset = "0x3EE5240", VA = "0x183EE6440", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x3EE6070", Offset = "0x3EE4E70", VA = "0x183EE6070", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x3EE64D0", Offset = "0x3EE52D0", VA = "0x183EE64D0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x3EE6400", Offset = "0x3EE5200", VA = "0x183EE6400", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x3EE6350", Offset = "0x3EE5150", VA = "0x183EE6350", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JMDHMLDEGBF> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x3EE6350", Offset = "0x3EE5150", VA = "0x183EE6350", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BEA220", Offset = "0x2BE9020", VA = "0x182BEA220", Slot = "4")]
		get
		{
			return default(NNGBDGBOMML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x2BEA2E0", Offset = "0x2BE90E0", VA = "0x182BEA2E0")]
	[Preserve]
	public ONHLMGKHHJK(params CELJAEDAMMM[] MCJBELEEOMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x2BEA0C0", Offset = "0x2BE8EC0", VA = "0x182BEA0C0", Slot = "5")]
	public bool GLOHAJBMNDO(long MOLCFNPABNJ, long DFGMBHPPELL, AJPLFBMOADO IPKNOBCDJAN, out JMDHMLDEGBF DKJPBMEIDDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x2BE9DA0", Offset = "0x2BE8BA0", VA = "0x182BE9DA0")]
	private void CAMLBDBEHID(int MEAMKJMDBNA, long MOLCFNPABNJ, long DFGMBHPPELL, AJPLFBMOADO IPKNOBCDJAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x2BEA260", Offset = "0x2BE9060", VA = "0x182BEA260", Slot = "6")]
	[IteratorStateMachine(typeof(COHHKDFCNLM))]
	public IEnumerable<JMDHMLDEGBF> OIJCCGHNJDJ(AJPLFBMOADO IPKNOBCDJAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x2BE9FD0", Offset = "0x2BE8DD0", VA = "0x182BE9FD0", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x246EF70", Offset = "0x246DD70", VA = "0x18246EF70")]
	internal static byte[] EEAPFDDHOFB(byte[] HFAIGCGNPJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x246F1F0", Offset = "0x246DFF0", VA = "0x18246F1F0")]
	public static void PAGLKLBDFLG(Stream KCFDLMABGLC, byte[] KHBDIABKGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x246F010", Offset = "0x246DE10", VA = "0x18246F010")]
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
		[Cpp2IlInjected.Address(RVA = "0x96B3E0", Offset = "0x96A1E0", VA = "0x18096B3E0", Slot = "4")]
		get
		{
			return default(NNGBDGBOMML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public DateTime OHPDEOABEIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x247CD70", Offset = "0x247BB70", VA = "0x18247CD70", Slot = "5")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x247D2F0", Offset = "0x247C0F0", VA = "0x18247D2F0")]
	public GDHFAKLOIOC(GAJOHNFLFGI PHGBMHIKGIC, FileInfo DFBNDHNPDFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x247D240", Offset = "0x247C040", VA = "0x18247D240", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x247D180", Offset = "0x247BF80", VA = "0x18247D180", Slot = "6")]
	public void PNBPAKBPFFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x247D140", Offset = "0x247BF40", VA = "0x18247D140", Slot = "7")]
	public bool IOCDEKMGBBH(long MOLCFNPABNJ, long DFGMBHPPELL, out LKMGECBKGBM BALDFHIGHBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x247CF10", Offset = "0x247BD10", VA = "0x18247CF10", Slot = "8")]
	public bool Equals(JMDHMLDEGBF HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x247CFF0", Offset = "0x247BDF0", VA = "0x18247CFF0", Slot = "9")]
	public bool Equals(GDHFAKLOIOC HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x247CE10", Offset = "0x247BC10", VA = "0x18247CE10", Slot = "0")]
	public override bool Equals(object CCPIHKCBGHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x247D0A0", Offset = "0x247BEA0", VA = "0x18247D0A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x1B16C90", Offset = "0x1B15A90", VA = "0x181B16C90")]
	public static bool CJJJLAGEFIA(GDHFAKLOIOC EHPOMDFBCKH, GDHFAKLOIOC DJPDMBCBGFI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x1B171B0", Offset = "0x1B15FB0", VA = "0x181B171B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public ABAJDIGBNMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x246C040", Offset = "0x246AE40", VA = "0x18246C040")]
	private static string DPCKFJIDOBP(byte[] BMMLDIMMAAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x246C150", Offset = "0x246AF50", VA = "0x18246C150")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
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
